using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.CrystalReports.Engine;
using Odin.CMB_Components.BLL;
using Odin.CustomControls;
using Odin.Global_Classes;
using Odin.Planning;
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

namespace Odin.Warehouse.Movements
{
    public delegate void DisplayKeyboardSymbolEventHandler(string symbol, bool symremove);


    public partial class frm_MovePDA : KryptonForm
    {
        public frm_MovePDA()
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
        StockMove_BLL SMBll = new StockMove_BLL();
        PrinterLabels PrintLabels = new PrinterLabels();
        frm_ScreenNumKeyboard popup;
        CMB_BLL CmbBll = new CMB_BLL();
        class_Global globClass = new class_Global();
        ReportDocument rd;

        public int ReadValue = 0;
        public string Result = "";

        int _CheckStencil = 0;
        public int CheckStencil
        {
            get { return _CheckStencil; }
            set
            {
                _CheckStencil = value;
                if (_CheckStencil == 0)
                {
                    btn_OK.Enabled = false;
                    DialogResult result = KryptonTaskDialog.Show("You can't make movement!",
                                                                     "Stencil required!",
                                                                     "Stencil required!",
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.OK);
                }
                else
                    btn_OK.Enabled = true;
            }
        }

        int _OutMode = -1;

        public int OutMode
        {
            get { return _OutMode; }
            set
            {

                _OutMode = value;
                if (_OutMode == -1)
                {
                    chk_InProduction.CheckState = CheckState.Checked;
                    chk_ReturnFromProduction.CheckState = CheckState.Unchecked;
                    chk_InProduction.BackColor = Color.LightPink;
                    chk_ReturnFromProduction.BackColor = Color.LightGreen;
                }
                else
                {
                    chk_ReturnFromProduction.CheckState = CheckState.Checked;
                    chk_InProduction.CheckState = CheckState.Unchecked;
                    chk_InProduction.BackColor = Color.LightGreen;
                    chk_ReturnFromProduction.BackColor = Color.LightPink;
                }
            }
        }

        public int BatchId
        { get; set; }

        public string Batch
        {
            get { return txt_Batch.Text; }
            set { txt_Batch.Text = value; }
        }

        private float _measCellValue;
        public float MeasCellValue
        {
            get { return _measCellValue; }
            set { _measCellValue = value; }
        }
        bool _islg = false;
        public bool IsLaunchGroup
        {
            get { return _islg; }
            set { _islg = value; }
        }
        #endregion

        #region Methods

        public void SetCellsColor()
        {
            //Proverjaem labels - est li v partii takie artikli
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (IsLaunchGroup == false)
                {
                    if (

                        //Convert.ToInt32(row.Cells["cn_bdid"].Value) == 0
                        //|| ((row.Cells["cn_batch"].Value.ToString().Trim() != ""
                        //|| string.IsNullOrEmpty(row.Cells["cn_batch"].Value.ToString().Trim()) != true)
                        //&& 
                        row.Cells["cn_batch"].Value.ToString().ToUpper() != Batch.ToUpper()
                        //)

                        )
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.LightCoral;
                    else
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                }
                else
                {
                    if (
                        //(
                        //row.Cells["cn_batch"].Value.ToString().Trim() != ""
                        //|| string.IsNullOrEmpty(row.Cells["cn_batch"].Value.ToString().Trim()) != true)
                        //&& 
                        row.Cells["cn_batch"].Value.ToString().ToUpper() != Batch.ToUpper()
                        )
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.LightCoral;
                    else
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                }
            }

        }

        public void ClearFields()
        {
            Batch = "";
            BatchId = 0;
            CheckStencil = 0;
            txt_Oper.Text = string.Empty;
            gv_List.Rows.Clear();
        }

        public void UpdateBatchDets(int _batchid)
        {
            var data = Plan_BLL.getBatchRMDets(_batchid);

            foreach (DataGridViewRow rowgv in this.gv_List.Rows)
            {
                rowgv.Cells["cn_bdid"].Value = 0;
            }

            //SetCellsColor();

            foreach (DataRow row in data.Rows)
            {
                foreach (DataGridViewRow rowgv in this.gv_List.Rows)
                {
                    if (Convert.ToInt32(row["artid"]) == Convert.ToInt32(rowgv.Cells["cn_artid"].Value))
                    {
                        rowgv.Cells["cn_bdid"].Value = Convert.ToInt32(row["id"]);

                    }
                }
            }

            //SetCellsColor();
        }

        public void InsertRow(int artid, string article, int label, double qty, string unit, string batch, int placeid, string place, string comments, string datacode, string expdate, int bdid)
        {
            //dobavlaem index
            int _tmpindex = 0;
            try
            {
                _tmpindex = gv_List.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["cn_index"].Value));
            }
            catch { }
            _tmpindex++;

            //DataGridViewRow row = (DataGridViewRow)gv_List.Rows[0].Clone();


            //row.Cells["cn_index"].Value = _tmpindex;
            //row.Cells["cn_artid"].Value = artid;
            //row.Cells["cn_article"].Value = article;
            //row.Cells["cn_label"].Value = label;
            //row.Cells["cn_qty"].Value = qty;
            //row.Cells["cn_unit"].Value = unit;
            //row.Cells["cn_batch"].Value = batch;
            //row.Cells["cn_placeid"].Value = placeid;
            //row.Cells["cn_place"].Value = place;
            //row.Cells["cn_comments"].Value = comments;
            //row.Cells["cn_expdate"].Value = expdate;
            //row.Cells["cn_bdid"].Value = bdid;

            //gv_List.Rows.Add(row);

            gv_List.Rows.Add(_tmpindex,
                             artid,
                             article,
                             label,
                             qty,
                             qty,
                             unit,
                             batch,
                             placeid,
                             place,
                             comments,
                             datacode,
                             expdate,
                             bdid);

            gv_List.Sort(gv_List.Columns["cn_index"], ListSortDirection.Descending);
            gv_List.ClearSelection();
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
                    gv_List.CurrentCell.Value += symbol;
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

        private void SendToPrinter(int _movdocid, int _count)
        {
            var task = Task.Factory.StartNew((() =>
            {
                PrintMoveDoc(_movdocid, _count);
            }), TaskCreationOptions.AttachedToParent);

        }

        private void PrintMoveDoc(int movdocid, int count)
        {
            void print()
            {
                using (ReportDocument rd = OpenReport(movdocid))
                {

                    rd.PrintOptions.PrinterName = DAL_Functions.GetDefaultPrinterName();
                    rd.PrintToPrinter(1, false, 0, 0);

                    //CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions popt = new CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions();
                    //popt.PrinterName = printerSettings.PrinterName;
                    //_report.ReportClientDocument.PrintOutputController.PrintReport(popt);

                }
            }

            PrintReport(count, print);

        }

        public ReportDocument OpenReport(int _movdocid)
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_StockMove.rpt";

            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);


            //
            DataTable data = new DataTable();
            data = StockMove_BLL.getStockMoveDetsPrint(_movdocid, 0);

            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            //parameters
            CmbBll.MoveDocHeadId = _movdocid;

            report.SetParameterValue("ConfOrder", CmbBll.MoveConfOrder);
            report.SetParameterValue("Batch", CmbBll.MoveDocBatch);
            report.SetParameterValue("Product", CmbBll.MoveProduct);
            report.SetParameterValue("SecArticle", CmbBll.MoveSecArticle);
            report.SetParameterValue("QtyInBatch", CmbBll.MoveQtyInBatch.ToString());
            report.SetParameterValue("AssPerson", System.Environment.UserName);
            report.SetParameterValue("Unit", CmbBll.MoveUnit);
            report.SetParameterValue("DocDate", CmbBll.MoveDocDocDate);
            report.SetParameterValue("Stage", "ALL");
            report.SetParameterValue("DocName", CmbBll.MoveDocName);
            report.SetParameterValue("UserName", System.Environment.UserName);
            report.SetParameterValue("Customer", CmbBll.MoveCustomer);
            report.SetParameterValue("Comment", CmbBll.MoveBatchComments);

            return report;

        }

        #endregion

        #region Controls

        private void chk_InProduction_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_InProduction.CheckState == CheckState.Checked)
            {
                OutMode = -1;
                txt_Oper.Focus();
            }
            else
            {
                OutMode = 1;
                txt_Oper.Focus();
                //cmb_Articles1.Focus();
            }
        }

        private void chk_ReturnFromProduction_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ReturnFromProduction.CheckState == CheckState.Checked)
            {
                OutMode = 1;
                txt_Oper.Focus();
            }
            else
            {
                OutMode = -1;
                txt_Oper.Focus();
                //cmb_Articles1.Focus();
            }
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

                        string _batch = txt_Oper.Text.Trim();
                        int _batchid = 0;
                        _batch = globClass.BeforeChar(_batch, "-");
                        txt_Oper.Text = _batch;

                        //if (_batch.Substring(0, 2) == "LG")
                        //{
                        //    IsLaunchGroup = true;
                        //    _batchid = 0;
                        //}
                        //else
                        //{
                        //    IsLaunchGroup = false;
                        _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where Batch = '" + _batch + "'"));
                        //}


                        if (_batchid != 0)
                        {
                            BatchId = _batchid;
                            //Update rows and cells color for new batch 
                            Batch = txt_Oper.Text.Trim().ToUpper();
                            CheckStencil = Convert.ToInt32(Helper.GetOneRecord("select top 1 dbo.fn_StencilRequired(bh.artid) from prod_batchhead bh where bh.id = " + BatchId));

                            UpdateBatchDets(BatchId);

                            SetCellsColor();
                        }
                        else if (IsLaunchGroup == true)
                        {
                            Batch = txt_Oper.Text.Trim().ToUpper();


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

                        SqlDataAdapter //adapter;
                        //if (IsLaunchGroup == false)
                            adapter =
                            new SqlDataAdapter(
                                "execute sp_SelectStockLabelDetsForMove @id = " + ReadValue + ", @batchid = " + BatchId, conn);
                        //else
                        //    adapter =
                        //        new SqlDataAdapter(
                        //        "execute sp_SelectStockLabelDetsForMoveLG @id = " + ReadValue, conn);

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
                                                dr["batch"].ToString(), Convert.ToInt32(dr["placeid"]), dr["place"].ToString(), dr["comments"].ToString(),
                                                dr["datacode"].ToString(), dr["expdate"].ToString(), Convert.ToInt32(dr["bdid"]));
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (CheckSave() == false)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Deallocation warning!",
                                                               "Are you want to save changes?",
                                                               "You have moved but unsaved lines!",
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

        private void frm_MovePDA_Load(object sender, EventArgs e)
        {

            txt_Oper.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
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


        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            try
            {
                int _resmove = 0; //Header

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (Convert.ToDouble(row.Cells["cn_qty"].Value) > 0)
                    {
                        try
                        {
                            //if (IsLaunchGroup == false)
                            _resmove = SMBll.AddStockMoveLinePDA(_resmove,
                                                        Convert.ToInt32(row.Cells["cn_label"].Value),
                                                        Convert.ToDouble(row.Cells["cn_qty"].Value),
                                                        OutMode,
                                                        Convert.ToInt32(row.Cells["cn_bdid"].Value),
                                                        BatchId);
                            //else
                            //_resmove = SMBll.AddStockMoveLinePDAGroup(_resmove,
                            //                            Convert.ToInt32(row.Cells["cn_label"].Value),
                            //                            Convert.ToDouble(row.Cells["cn_qty"].Value),
                            //                            OutMode,
                            //                            Batch);

                        }
                        catch
                        {
                            DialogResult result = KryptonTaskDialog.Show("Quantity deallocation line warning!",
                                                                 "Saving of line impossible!",
                                                                 "Please check line: " + row.Index.ToString(),
                                                                 MessageBoxIcon.Warning,
                                                                 TaskDialogButtons.OK);
                        }
                    }

                }

                txt_Documents.Text = SMBll.InsertedMovDoc + " at " + System.DateTime.Now.ToString() + System.Environment.NewLine + txt_Documents.Text;

                if (chk_PrintDoc.Checked == true)
                {
                    SendToPrinter(_resmove, 1);
                }

                ClearFields();
                txt_Oper.Focus();
            }
            catch { }
        }

        private void txt_Documents_Enter(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void btn_DeleteDocs_Click(object sender, EventArgs e)
        {
            txt_Documents.Text = "";
            txt_Oper.Focus();
        }

        private void chk_PrintDoc_CheckedChanged(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }


        #endregion

        private void frm_MovePDA_Activated(object sender, EventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void frm_MovePDA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckSave() == false
                && CheckStencil != 0)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Deallocation warning!",
                                                               "Are you want to save changes?",
                                                               "You have moved but unsaved lines!",
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

        private void btn_Print_Click(object sender, EventArgs e)
        {
            int _label = 0;
            int _artid = 0;
            double _qty = 0;
            try
            {
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value);
                _qty = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_qty"].Value);
            }
            catch { }

            if (_label != 0)
            {
                frm_Print frm = new frm_Print();
                frm.cmb_LabPrinter1.ShowDefaults();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PrintLabels.PrinterIp = frm.IP_Address;
                    PrintLabels.PrinterDPI = frm.Printer_DPI;

                    var sqlparamsfields = new List<SqlParameter>()
                {
                    new SqlParameter("@id",SqlDbType.Int) {Value = _label},
                    new SqlParameter("@qty",SqlDbType.Float) {Value = _qty},
                    new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                };

                    if (DAL.CheckMSL(_artid) != "0"
                        && frm.LabelQty != 0)
                        PrintLabels.PrintLabel(PrintLabels.LabelConstructor(1, "sp_SelectStockLabelDetsPrint", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                    else
                        MessageBox.Show("MSL = 0! Printing impossible!");
                    txt_Oper.Focus();
                }
                else
                {
                    txt_Oper.Focus();
                }
            }
            else
            { txt_Oper.Focus(); }
        }
    }
}
