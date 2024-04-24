using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.CrystalReports.Engine;
using Odin.CMB_Components.BLL;
using Odin.CustomControls;
using Odin.Global_Classes;
using Odin.Warehouse.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odin.Warehouse.StockOut
{
    public partial class frm_StockOutPDA : KryptonForm
    {
        public frm_StockOutPDA()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
            NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
            this.gv_List.EditingControlShowing +=
                new DataGridViewEditingControlShowingEventHandler(gv_List_EditingControlShowing);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        private CancellationToken printToken;

        private static KeyPressEventHandler NumericCheckHandler;

        PopupWindowHelper PopupHelper = null;
        DAL_Functions DAL = new DAL_Functions();
        //StockMove_BLL SMBll = new StockMove_BLL();
        StockOut_BLL SOBll = new StockOut_BLL();
        PrinterLabels PrintLabels = new PrinterLabels();
        frm_ScreenNumKeyboard popup;
        CMB_BLL CmbBll = new CMB_BLL();
        class_Global Glob_Class = new class_Global();

        ReportDocument rd;

        public int ReadValue = 0;
        public string Result = "";

        public int RequestId
        { get; set; }

        public string Request
        {
            get { return txt_Request.Text; }
            set { txt_Request.Text = value; }
        }

        private float _measCellValue;
        public float MeasCellValue
        {
            get { return _measCellValue; }
            set { _measCellValue = value; }
        }

        public int OutHeaderId
        { get; set; }

        public string OutHeader
        { get; set; }

        #endregion

        #region Methods

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (symremove)
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value = symbol;
                gv_List.CurrentCell.Value = symbol;
            }
            else
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value += symbol;
                if (Convert.ToDouble(gv_List.CurrentCell.Value + symbol) <= Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qtybeg"].Value))
                {
                    gv_List.CurrentCell.Value += symbol;
                    //gv_List.CurrentCell.Value = Convert.ToDouble(gv_List.CurrentCell.Value);
                }
            }

        }

        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
            {
                e.Handled = e.KeyChar == '-' ? s.Text.Contains(e.KeyChar) : !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
        }

        public bool CheckSave()
        {
            bool _res = true;
            int _countrows = 0;
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _countrows++;
            }
            if (_countrows > 0)
                _res = false;
            return _res;
        }

        public void ClearFields()
        {
            Request = "";
            RequestId = 0;
            txt_Oper.Text = string.Empty;
            gv_List.Rows.Clear();
            ShowDocDets(0);
        }

        public void InsertRow(int artid, string article, int label, double qty, string unit, string labelbatch, int labelbdetid,
                            int placeid, string place, string comments, string datacode, string expdate, int reqbdetid, string reqbatch, 
                            int reqid, double qtyreq)
        {
            //dobavlaem index
            int _tmpindex = 0;
            try
            {
                _tmpindex = gv_List.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["cn_index"].Value));
            }
            catch { }
            _tmpindex++;
                       

            gv_List.Rows.Add(_tmpindex,
                             artid,
                             article,
                             label,
                             //qty,
                             0,
                             qty,
                             qtyreq,
                             unit,
                             reqbatch,
                             labelbatch,
                             placeid,
                             place,
                             comments,
                             datacode,
                             expdate,
                             reqbdetid,
                             labelbdetid,
                             reqid);

            gv_List.Sort(gv_List.Columns["cn_index"], ListSortDirection.Descending);
            gv_List.ClearSelection();
        }

        public void CheckLabel(string labelcontent)
        {
            string _artid = "";
            int _label = 0;
            try
            {
                _artid = gv_List.CurrentRow.Cells["cn_artid"].Value.ToString();
                _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value);
            }
            catch { }
            txt_Documents.Text = _artid == labelcontent
                ? "Check result for label " + _label.ToString() + " is OK! " + System.Environment.NewLine + txt_Documents.Text
                : "Check result for label " + _label.ToString() + " not OK! Content is: " + labelcontent + "!" + System.Environment.NewLine + txt_Documents.Text;
            chk_CheckLabel.CheckState = CheckState.Unchecked;
            chk_CheckLabel.BackColor = Color.LightGreen;
        }

        public bool CheckRow(int label)
        {
            bool _res = true;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_label"].Value) == label)
                {
                    _res = false;
                    break;
                }

            }

            return _res;
        }

        public void SetCellsColor()
        {
            //Proverjaem labels - est li v partii takie artikli
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (//Net rekvesta
                    Convert.ToInt32(row.Cells["cn_reqid"].Value) == 0
                    || 
                    (Convert.ToInt32(row.Cells["cn_reqid"].Value) != 0
                        && Convert.ToInt32(row.Cells["cn_reqbdetid"].Value) != Convert.ToInt32(row.Cells["cn_labelbdetid"].Value)
                        && Convert.ToInt32(row.Cells["cn_labelbdetid"].Value) != 0))
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.LightCoral;
                else
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);

            }

        }


        #endregion

        #region Controls

        private void gv_List_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gv_List.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
            else
            {
                e.Control.KeyPress -= NumericCheckHandler;
            }
        }

        private void ShowScreenNumKeyboard(DataGridViewCellEventArgs e, int columnIndex, int rowIndex)
        {
            string columnName = gv_List.Columns["cn_qty"].Name;

            //int rowHeight = dataGridView1.Rows[e.RowIndex].Height;
            int columnWidth = gv_List.Columns[columnName].Width;

            int ColumnIndex = columnIndex != -1 ? columnIndex : e.ColumnIndex;
            int RowIndex = rowIndex != -1 ? rowIndex : e.RowIndex;

            Rectangle cellRectangle = gv_List.GetCellDisplayRectangle(ColumnIndex, RowIndex, false);

            cellRectangle.X += gv_List.Left + columnWidth;
            cellRectangle.Y += gv_List.Top - 20;

            Point displayPoint = PointToScreen(new Point(cellRectangle.X, cellRectangle.Y));

            popup = new frm_ScreenNumKeyboard();
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            //popup.frm_MainOne = this;

            Form f;
            f = this.FindForm();

            PopupHelper.ShowPopup(f, popup, displayPoint);
        }

        public void UpdateRequestDets(int _requestid)
        {
            var data = Requests_BLL.getRequestRMDets(_requestid);

            foreach (DataGridViewRow rowgv in this.gv_List.Rows)
            {
                rowgv.Cells["cn_reqid"].Value = 0;
                rowgv.Cells["cn_reqbdetid"].Value = 0;
                rowgv.Cells["cn_requestbatch"].Value = "";
                rowgv.Cells["cn_qtyreq"].Value = 0;
            }


            foreach (DataRow row in data.Rows)
            {
                foreach (DataGridViewRow rowgv in this.gv_List.Rows)
                {
                    if (Convert.ToInt32(row["artid"]) == Convert.ToInt32(rowgv.Cells["cn_artid"].Value))
                    {
                        rowgv.Cells["cn_reqbdetid"].Value = Convert.ToInt32(row["batchid"]);
                        rowgv.Cells["cn_reqid"].Value = Convert.ToInt32(row["id"]);
                        rowgv.Cells["cn_requestbatch"].Value = row["batch"].ToString();
                        rowgv.Cells["cn_qtyreq"].Value = Convert.ToDouble(row["qtyleft"]);
                    }
                }
            }
        }

        public void ShowDocDets(int id)
        {
            var data = StockOut_BLL.getStockOutDets(id);

            gv_Dets.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_Dets.SortedColumn;
                var dir = Helper.SaveDirection(gv_Dets);


                gv_Dets.AutoGenerateColumns = false;
                bs_Dets.DataSource = data;
                gv_Dets.DataSource = bs_Dets;

                SetCellsColor();

                Helper.RestoreDirection(gv_Dets, oldColumn, dir);
            });

        }

        public bool CheckQtyReq(int artid, double qty)
        {
            bool _res = false;
            double _qtytemp = 0;

            foreach (DataGridViewRow rowgv in this.gv_List.Rows)
            {
                if (artid == Convert.ToInt32(rowgv.Cells["cn_artid"].Value))
                {
                    _qtytemp = _qtytemp + Convert.ToDouble(rowgv.Cells["cn_qtyreq"].Value);
                }
            }

            _res = _qtytemp < qty;

            return _res;
        }
        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (CheckSave() == false)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Write off warning!",
                                                               "Are you want to save changes?",
                                                               "You have outcomes, but unsaved lines!",
                                                               MessageBoxIcon.Warning,
                                                               TaskDialogButtons.Yes |
                                                               TaskDialogButtons.No |
                                                               TaskDialogButtons.Cancel);
                if (result1 == DialogResult.Yes)
                {
                    btn_OK.PerformClick();
                    this.Close();
                }
                else if (result1 == DialogResult.No)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
                this.Close();
        }

        private void frm_StockOutPDA_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (CheckSave() == false)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Write off warning!",
                                                               "Are you want to save changes?",
                                                               "You have outcomes, but unsaved lines!",
                                                               MessageBoxIcon.Warning,
                                                               TaskDialogButtons.Yes |
                                                               TaskDialogButtons.No |
                                                               TaskDialogButtons.Cancel);
                if (result1 == DialogResult.Yes)
                {
                    btn_OK.PerformClick();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = result1 != DialogResult.No;
                }
            }
        }

        private void frm_StockOutPDA_Load(object sender, EventArgs e)
        {

            txt_Oper.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
            txt_Oper.Focus();
        }

        private void chk_CheckLabel_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_CheckLabel.CheckState == CheckState.Checked)
            {
                chk_CheckLabel.BackColor = Color.LightPink;
                txt_Oper.Focus();
            }
            else
            {
                chk_CheckLabel.BackColor = Color.LightGreen;
                txt_Oper.Focus();
            }
        }

        private void gv_List_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gv_List.CurrentRow != null)
                {
                    popup.CellText = gv_List.CurrentRow.Cells["cn_qty"].Value.ToString();
                }
            }
            catch { }
        }

        private void gv_List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (gv_List.CurrentCell.Value != null &&
                    gv_List.CurrentCell.Value.ToString() == "-")
                {
                    gv_List.CurrentCell.Value = null;
                }

                var cellValue = gv_List.CurrentCell.Value;
                if (cellValue != null)
                {

                    if (gv_List.Rows[e.RowIndex].Cells["cn_qty"].Value.ToString() != "")
                    {
                        MeasCellValue = float.Parse(gv_List.Rows[e.RowIndex].Cells["cn_qty"].Value.ToString());
                    }

                }
            }
        }

        private void gv_List_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gv_List.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
            else
            {
                e.Control.KeyPress -= NumericCheckHandler;
            }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    ShowScreenNumKeyboard(e, -1, -1);
                    popup.CellText = gv_List.CurrentRow.Cells["cn_qty"].FormattedValue.ToString();

                }
            }
        }

        private void gv_List_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gv_List.SelectedRows)
            {
                gv_List.Rows.Remove(row);
            }

            gv_List.ClearSelection();

            txt_Oper.Focus();
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (chk_CheckLabel.CheckState == CheckState.Checked)
                {
                    CheckLabel(txt_Oper.Text.Trim());
                }
                else
                {
                    bool _check = Int32.TryParse(txt_Oper.Text, out ReadValue);

                    if (_check == false)
                    {
                        ReadValue = 0;
                        //Check for batchstring _r = "";

                        string _request = txt_Oper.Text.Trim();
                        int _requestid = 0;
                        //try
                        //{
                        _requestid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from req_head where name = '" + _request + "'"));
                        // }
                        //catch { BatchId = 0; }

                        if (_requestid != 0)
                        {
                            RequestId = _requestid;
                            //Update rows and cells color for new batch 
                            Request = txt_Oper.Text.Trim().ToUpper();

                            UpdateRequestDets(RequestId);

                            SetCellsColor();
                        }
                        else
                        {
                            DialogResult result = KryptonTaskDialog.Show("Error during label reading!",
                                                                     "Error during label reading!",
                                                                     "Label reading data: " + txt_Oper.Text.Trim(),
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.OK);
                        }
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(sConnStr);
                        conn.Open();
                        DataSet ds = new DataSet();

                        SqlDataAdapter adapter =
                            new SqlDataAdapter(
                                "execute sp_SelectStockLabelDetsForMoveRequest @id = " + ReadValue + ", @requestid = " + RequestId, conn);


                        conn.Close();

                        adapter.Fill(ds);

                        DataTable dt = ds.Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            if (CheckRow(ReadValue) == true)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    InsertRow(Convert.ToInt32(dr["artid"]), dr["article"].ToString(), ReadValue, Convert.ToDouble(dr["qty"]), dr["unit"].ToString(),
                                                dr["labelbatch"].ToString(), Convert.ToInt32(dr["labelbdetid"]), Convert.ToInt32(dr["placeid"]), dr["place"].ToString(), dr["comments"].ToString(),
                                                dr["datacode"].ToString(), dr["expdate"].ToString(), Convert.ToInt32(dr["reqbdetid"]), dr["requestbatch"].ToString(), Convert.ToInt32(dr["reqid"]), 
                                                Convert.ToDouble(dr["qtyreq"]));
                                }
                                SetCellsColor();
                            }
                        }
                        else
                        {
                            DialogResult result = KryptonTaskDialog.Show("Error during label reading!",
                                                                     "Error during label reading!",
                                                                     "Label reading data: " + txt_Oper.Text.Trim(),
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.OK);
                        }
                    }
                }
                //Clear temp field
                txt_Oper.Text = "";
                txt_Oper.Focus();

            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                int _res = 0; //Header

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (Convert.ToDouble(row.Cells["cn_qty"].Value) > 0
                        && Convert.ToDouble(row.Cells["cn_qty"].Value) <= Convert.ToDouble(row.Cells["cn_qtyreq"].Value)
                        && CheckQtyReq(Convert.ToInt32(row.Cells["cn_artid"].Value), Convert.ToDouble(row.Cells["cn_qtyreq"].Value)) == true
                        && !(Convert.ToInt32(row.Cells["cn_reqid"].Value) == 0
                            ||
                            (Convert.ToInt32(row.Cells["cn_reqid"].Value) != 0
                                && Convert.ToInt32(row.Cells["cn_reqbdetid"].Value) != Convert.ToInt32(row.Cells["cn_labelbdetid"].Value)
                                && Convert.ToInt32(row.Cells["cn_labelbdetid"].Value) != 0))
                        )
                    {
                        try
                        {
                            _res = SOBll.AddStockOutLine(_res, Convert.ToInt32(row.Cells["cn_label"].Value),
                                                    Convert.ToDouble(row.Cells["cn_qty"].Value),
                                                    Convert.ToInt32(row.Cells["cn_artid"].Value),
                                                    Convert.ToInt32(row.Cells["cn_reqbdetid"].Value),
                                                    Convert.ToInt32(row.Cells["cn_reqid"].Value),
                                                    row.Cells["cn_comments"].Value.ToString());
                            //_resmove = SMBll.AddStockMoveLinePDA(_resmove,
                            //                            Convert.ToInt32(row.Cells["cn_label"].Value),
                            //                            Convert.ToDouble(row.Cells["cn_qty"].Value),
                            //                            OutMode,
                            //                            Convert.ToInt32(row.Cells["cn_bdid"].Value),
                            //                            BatchId);

                        }
                        catch
                        {
                            DialogResult result = KryptonTaskDialog.Show("Quantity outcome line warning!",
                                                                 "Saving of line impossible due quantity or reservation!",
                                                                 "Please check line: " + row.Index.ToString(),
                                                                 MessageBoxIcon.Warning,
                                                                 TaskDialogButtons.OK);
                        }
                    }

                }

                OutHeaderId = _res;
               
                string _resdoc = Helper.GetOneRecord("select name from sto_stockouthead where id = " + _res).ToString();

                OutHeader = _resdoc;


                txt_Documents.Text = _resdoc + " at " + System.DateTime.Now.ToString() + System.Environment.NewLine + txt_Documents.Text;

                
                //if (chk_PrintDoc.Checked == true)
                //{
                //    SendToPrinter(_resmove, 1);
                //}

                ClearFields();
                ShowDocDets(_res);

                PrintOutLabels();

                txt_Oper.Focus();
            }
            catch { }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_Dets.CurrentRow.Cells["cn_oid"].Value); }
            catch { }

            if (_id != 0
                && Glob_Class.DeleteConfirm() == true)
            {
                SOBll.DeleteStockOutLine(_id);
                ShowDocDets(OutHeaderId);
            }
        }

        #region Printing

        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_StockOut.rpt";


            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            DataTable data = new DataTable();
            data = StockOut_BLL.getStockOutDets(OutHeaderId);
            //parameters

            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);
            report.SetParameterValue("DocDate", System.DateTime.Now.ToShortDateString());
            report.SetParameterValue("DocName", OutHeader);
            report.SetParameterValue("Reason", "");
            report.SetParameterValue("UserName", System.Environment.UserName);

            return report;

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //SendToPrinter(OutHeaderId, 1);

            frm_Print frm = new frm_Print();
            frm.cmb_LabPrinter1.ShowDefaults();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintLabels.PrinterIp = frm.IP_Address;
                PrintLabels.PrinterDPI = frm.Printer_DPI;

                foreach (DataGridViewRow row in this.gv_Dets.Rows)
                {
                    var sqlparamsfields = new List<SqlParameter>()
                    {
                        new SqlParameter("@id",SqlDbType.Int) {Value = Convert.ToInt32(row.Cells["cn_oid"].Value) },
                        new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                    };
                    if (frm.LabelQty != 0)
                        PrintLabels.PrintLabel(PrintLabels.LabelConstructor(5, "sp_SelectStockOutDetForLabel", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                }
            }
            else
            { }
        }

        public void PrintOutLabels()
        {
            frm_Print frm = new frm_Print();
            frm.cmb_LabPrinter1.ShowDefaults();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintLabels.PrinterIp = frm.IP_Address;
                PrintLabels.PrinterDPI = frm.Printer_DPI;

                foreach (DataGridViewRow row in this.gv_Dets.Rows)
                {
                    var sqlparamsfields = new List<SqlParameter>()
                    {
                        new SqlParameter("@id",SqlDbType.Int) {Value = Convert.ToInt32(row.Cells["cn_oid"].Value) },
                        new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                    };
                    if (frm.LabelQty != 0)
                        PrintLabels.PrintLabel(PrintLabels.LabelConstructor(5, "sp_SelectStockOutDetForLabel", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                }
            }
            else
            { }
        }
        private void SendToPrinter(int _outdocid, int _count)
        {
            var task = Task.Factory.StartNew((() =>
            {
                PrintMoveDoc(_outdocid, _count);
            }), TaskCreationOptions.AttachedToParent);

        }

        private void PrintMoveDoc(int outdocid, int count)
        {
            Action print =
            () =>
            {
                using (ReportDocument rd = OpenReport())
                {

                    rd.PrintOptions.PrinterName = DAL_Functions.GetDefaultPrinterName();
                    rd.PrintToPrinter(1, false, 0, 0);

                    //CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions popt = new CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions();
                    //popt.PrinterName = printerSettings.PrinterName;
                    //_report.ReportClientDocument.PrintOutputController.PrintReport(popt);

                }
            };

            PrintReport(count, print);

        }

        private void PrintReport(int count, Action printMethod)
        {
            // Create the base task  
            var task = Task.Factory.StartNew((() => { }), TaskCreationOptions.AttachedToParent);

            for (int i = 1; i <= count; i++)
            {
                // The printing task
                task = task.ContinueWith(t =>
                {
                    // Cancels the task
                    if (printToken.IsCancellationRequested)
                    {
                        return;
                    }

                    printMethod();

                }, TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.OnlyOnRanToCompletion);

            }
        }
        #endregion



    }
}
