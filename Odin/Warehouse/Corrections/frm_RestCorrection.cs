using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.Movements;
using Odin.Warehouse.StockOut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Warehouse.Corrections
{
    public partial class frm_RestCorrection : Form
    {
        public frm_RestCorrection()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
            ED = new ExportData(this.gv_List, "RestCorrection.xls", this.Name);
        }

        #region Variables


        frm_BCCorrection frm;

        ProgressForm wait;

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        AdmMenu mMenu = new AdmMenu();
        class_Global glob_Class = new class_Global();
        ExportData ED;
        DAL_Functions DAL = new DAL_Functions();
        StockOut_BLL SOBll = new StockOut_BLL();
        StockMove_BLL SMBll = new StockMove_BLL();
        StockCorrection_BLL SCBll = new StockCorrection_BLL();
        PrinterLabels PrintLabels = new PrinterLabels();
        Helper MyHelper = new Helper();

        int _OutMode = 1;

        public int OutMode
        {
            get { return _OutMode; }
            set { _OutMode = value; }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public int ReadValue = 0;
        public string Result = "";


        #endregion

        #region Methods

        public void LoadColumns(DataGridView grid)
        {
            DAL.UserLogin = System.Environment.UserName;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectUserGridViewColumn", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@userid", DAL.UserId);
            sqlComm.Parameters.AddWithValue("@formname", this.Name);
            sqlComm.Parameters.AddWithValue("@gridname", grid.Name);

            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        if (column.Name == reader["columnname"].ToString())
                        {
                            column.DisplayIndex = Convert.ToInt32(reader["columnorder"]);
                            column.HeaderText = reader["columntext"].ToString();
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                    }

                }
                reader.Close();
            }

            sqlConn.Close();

        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToDateTime(row.Cells["cn_when"].Value).ToShortDateString() != "01.01.2199")
                {
                    if (Convert.ToInt32(row.Cells["cn_iscounter"].Value) != 0)
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.Yellow;
                    else
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.Orange;
                }

                if (Convert.ToDouble(row.Cells["cn_qtydiff"].Value) != 0)
                {
                    if (Convert.ToDouble(row.Cells["cn_qtydiff"].Value) < 0)
                    {
                        row.Cells["cn_qtydiff"].Style.Font = new Font(this.Font, FontStyle.Bold);
                        row.Cells["cn_qtydiff"].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.Cells["cn_qtydiff"].Style.Font = new Font(this.Font, FontStyle.Bold);
                        row.Cells["cn_qtydiff"].Style.ForeColor = Color.Green;
                    }
                }
                else
                {
                    row.Cells["cn_qtydiff"].Style.Font = new Font(this.Font, FontStyle.Regular);
                    row.Cells["cn_qtydiff"].Style.ForeColor = Color.Black;
                }
            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            gv_List.ThreadSafeCall(delegate { bs_List.DataSource = null; });
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = StockCorrection_BLL.getStockOutForBatch(cmb_Batches1.BatchId, cmb_BatchStages1.StageId);

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();


                Helper.RestoreDirection(gv_List, oldColumn, dir);
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            chk_RemoveReservation.CheckState = CheckState.Unchecked;

            chk_DataScanner.CheckState = CheckState.Unchecked;

            chk_CheckMode.CheckState = CheckState.Unchecked;
        }

        public void AddQtyForLabel(int label, double qty, int printlabels)
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_label"].Value) == label
                    //&& Convert.ToDouble(row.Cells["cn_qtyrest"].Value) != qty
                    )
                {
                    double _corqty = qty;
                    double _qtyused = Convert.ToDouble(row.Cells["cn_qtyout"].Value);
                    double _qtyonlabel = Convert.ToDouble(row.Cells["cn_qty"].Value);
                    double _qtydiff = 0;

                    if (_corqty < 0)
                        _corqty = 0;
                    if (_corqty - _qtyonlabel > _qtyused)
                        _corqty = _qtyonlabel + _qtyused;

                    _qtydiff = _corqty - _qtyonlabel;

                    row.Cells["cn_qtyrest"].Value = _corqty;
                    row.Cells["cn_qtydiff"].Value = _qtydiff;
                    row.Cells["cn_iscounter"].Value = 0;
                    row.Cells["cn_when"].Value = System.DateTime.Now;

                    DataGridViewColumn newColumn = gv_List.Columns["cn_when"];

                    gv_List.Sort(newColumn, ListSortDirection.Ascending);

                    SetCellsColor();

                    btn_OK.Enabled = true;

                    frm.Close();

                    txt_Oper.Focus();

                    if (printlabels == -1)
                    {
                        //Print label
                        frm_Print frm1 = new frm_Print();

                        DialogResult result = frm1.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            PrintLabels.PrinterIp = frm1.IP_Address;
                            PrintLabels.PrinterDPI = frm1.Printer_DPI;
                            var sqlparamsfields = new List<SqlParameter>()
                            {
                                new SqlParameter("@id",SqlDbType.Int) {Value = label },
                                new SqlParameter("@qty",SqlDbType.Float) {Value = _corqty},
                                new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm1.LabelQty}
                            };
                            PrintLabels.PrintLabel(PrintLabels.LabelConstructor(1, "sp_SelectStockLabelDetsPrint", sqlparamsfields.ToArray()), 1/*frm1.LabelQty*/);
                            //Thread.Sleep(1000);
                        }
                    }
                    break;
                }
            }

            //Print label
        }

        public bool CheckChanges()
        {
            bool _res = false;
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_qtydiff"].Value) != 0)
                {
                    _res = true;
                    break;
                }
            }
            return _res;
        }


        #endregion

        #region Controls

        private void chk_DataScanner_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_DataScanner.CheckState == CheckState.Checked)
            {
                chk_DataScanner.Text = "Data scanner " + System.Environment.NewLine + "stock-out mode ON";
                chk_DataScanner.BackColor = Color.LightPink;
                OutMode = 2;
                txt_Oper.Focus();
                //frm_DirectStockOut frm = new frm_DirectStockOut();
                //frm.Show(); frm.GetKryptonFormFields();
                //txt_DC.Focus();
            }
            else
            {
                chk_DataScanner.Text = "Data scanner " + System.Environment.NewLine + "stock-out mode OFF";
                chk_DataScanner.BackColor = Color.LightGreen;
                OutMode = 1;
                //cmb_Articles1.Focus();
            }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            chk_DataScanner.CheckState = CheckState.Unchecked;
            if (OutMode == 3)
                txt_Oper.Focus();
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            chk_DataScanner.CheckState = CheckState.Unchecked;
            if (OutMode == 3)
                txt_Oper.Focus();
        }

        private void cmb_Batches1_ControlClick(object sender)
        {
            chk_DataScanner.CheckState = CheckState.Unchecked;
            if (OutMode == 3)
                txt_Oper.Focus();
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = cmb_Batches1.IsActive != 0;
        }

        #region Context menu


        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_List.ClearSelection();
                gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColor();
        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_List;
            frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();

        }

        private void mni_FilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? String.IsNullOrEmpty(CellValue) == true
                        ? "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'"
                    : String.IsNullOrEmpty(CellValue) == true
                        ? bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();


        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'"
                    : bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            SetCellsColor();


        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for confirmation orders list";
            frm.grid = this.gv_List;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_List);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }


        #endregion

        private void frm_RestCorrection_Load(object sender, EventArgs e)
        {
            bn_List.Items.Insert(0, new ToolStripControlHost(chk_SelectAll));

            LoadColumns(gv_List);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            //try
            //{
            int _res = 0;
            int _removereservation = 0;
            int _resmove = 0;
           
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                #region diff
                if (Convert.ToDouble(row.Cells["cn_qtydiff"].Value) != 0)
                {
                    _removereservation = cmb_Places1.PlaceId != 0
                               && Convert.ToInt32(row.Cells["chk_removeres"].Value) == -1//chk_RemoveReservation.Checked == true
                               && Convert.ToDouble(row.Cells["cn_qtyrest"].Value) > 0
                        ? -1
                        : 0;

                    if (Convert.ToDouble(row.Cells["cn_qtydiff"].Value) < 0)
                    {
                        //Check for remove reservation
                       

                        //Additional outcome
                        //Add stock out
                        _res = SOBll.AddStockOutLine(_res, Convert.ToInt32(row.Cells["cn_label"].Value),
                                                        -1 * Convert.ToDouble(row.Cells["cn_qtydiff"].Value),
                                                        Convert.ToInt32(row.Cells["cn_artid"].Value),
                                                        Convert.ToInt32(row.Cells["cn_id"].Value), 0,
                                                        Convert.ToInt32(row.Cells["cn_iscounter"].Value) == 0 ? "Rest correction for " + cmb_Batches1.Batch : "Rest correction for " + cmb_Batches1.Batch + " (X-Ray counter)");

                            if (_removereservation == -1)
                                _resmove = SMBll.AddStockMoveLineCorrection(_resmove,
                                                            Convert.ToInt32(row.Cells["cn_label"].Value),
                                                            Convert.ToDouble(row.Cells["cn_qtyrest"].Value),
                                                            cmb_Places1.PlaceId,
                                                            Convert.ToInt32(row.Cells["cn_id"].Value),
                                                            0,
                                                            Convert.ToInt32(row.Cells["cn_batchid"].Value),
                                                            0,
                                                            0,
                                                            "Removing of reservation of " + cmb_Batches1.Batch);


                            //Remove reservation if qty to return > 0
                            if (Convert.ToDouble(row.Cells["cn_qtyrest"].Value) == 0)
                                SOBll.RemoveLabelReservationCorrection(Convert.ToInt32(row.Cells["cn_label"].Value), Convert.ToInt32(row.Cells["cn_batchid"].Value));
                        }
                    else
                    {
                        //Return
                        SCBll.ReturnRMFromProduction(Convert.ToInt32(row.Cells["cn_id"].Value), Convert.ToInt32(row.Cells["cn_label"].Value), Convert.ToDouble(row.Cells["cn_qtydiff"].Value));
                        if (cmb_Places1.PlaceId != 0)
                            if (_removereservation == -1)
                                _resmove = SMBll.AddStockMoveLineCorrection(_resmove,
                                                       Convert.ToInt32(row.Cells["cn_label"].Value),
                                                       Convert.ToDouble(row.Cells["cn_qtyrest"].Value),
                                                       cmb_Places1.PlaceId,
                                                       Convert.ToInt32(row.Cells["cn_id"].Value),
                                                       0,
                                                       Convert.ToInt32(row.Cells["cn_batchid"].Value),
                                                       0,
                                                       0,
                                                       "Removing of reservation of " + cmb_Batches1.Batch);
                    }
                }
                else // Correct quantities, but remove reservation
                {
                    //Remove reservation if checked
                    _removereservation = cmb_Places1.PlaceId != 0
                            && Convert.ToInt32(row.Cells["chk_removeres"].Value) == -1
                            && Convert.ToDouble(row.Cells["cn_qtyrest"].Value) > 0
                        ? -1
                        : 0;

                    if (_removereservation == -1)
                        _resmove = SMBll.AddStockMoveLineCorrection(_resmove,
                                                        Convert.ToInt32(row.Cells["cn_label"].Value),
                                                        Convert.ToDouble(row.Cells["cn_qtyrest"].Value),
                                                        cmb_Places1.PlaceId,
                                                        Convert.ToInt32(row.Cells["cn_id"].Value),
                                                        0,
                                                        Convert.ToInt32(row.Cells["cn_batchid"].Value),
                                                        0,
                                                        0,
                                                        "Removing of reservation of " + cmb_Batches1.Batch);


                    //Remove reservation if qty to return > 0
                    if (Convert.ToDouble(row.Cells["cn_qtyrest"].Value) == 0
                        && Convert.ToInt32(row.Cells["chk_removeres"].Value) == -1)
                        SOBll.RemoveLabelReservationCorrection(Convert.ToInt32(row.Cells["cn_label"].Value), Convert.ToInt32(row.Cells["cn_batchid"].Value));

                }
                #endregion
            }

            if (_res != 0)
            {
                //Sending letter about stockout for fixed assets
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                SqlCommand sqlComm = new SqlCommand("sp_SelectLaunchRMOutDiff", sqlConn);
                sqlComm.Parameters.AddWithValue("@outheadid", _res);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlConn.Open();

                SqlDataReader reader = sqlComm.ExecuteReader();
                if (reader.HasRows)
                {
                    string strMessage = "";
                    string emailaddresses = "";
                    emailaddresses = DAL.EmailAddressesByType(19);
                    strMessage = "Batch: " + cmb_Batches1.Batch;

                    while (reader.Read())
                    {
                        strMessage = strMessage + "\r\nLaunch: " + reader["launch"].ToString();
                        strMessage = strMessage + "\r\nArticle: " + reader["article"].ToString();
                        strMessage = strMessage + ", qty diff: " + reader["qtyover"].ToString();
                        strMessage = strMessage + ", unit price: " + reader["unitprice"].ToString();
                        strMessage = strMessage + ", total: " + reader["total"].ToString();
                    }

                    reader.Close();
                    if (emailaddresses != "")
                    {
                        MyHelper.SendMessage(emailaddresses, "RM overs or missings for launch during stock outcomes!", strMessage);
                    }

                }
                sqlConn.Close();
            }

            #region If labels printing
            if (chk_PrintLabels.CheckState == CheckState.Checked)
            {
                frm_Print frm = new frm_Print();
                frm.cmb_LabPrinter1.ShowDefaults();
                    DialogResult result = frm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                    PrintLabels.PrinterIp = frm.IP_Address;
                        PrintLabels.PrinterDPI = frm.Printer_DPI;

                        foreach (DataGridViewRow row in this.gv_List.Rows)
                        {
                            if (//Convert.ToDouble(row.Cells["cn_qtydiff"].Value) != 0
                                //&& 
                                Convert.ToDouble(row.Cells["cn_qtyrest"].Value) > 0
                                && DAL.CheckMSL(Convert.ToInt32(row.Cells["cn_artid"].Value)) != "0")
                            {
                                var sqlparamsfields = new List<SqlParameter>()
                            {
                                new SqlParameter("@id",SqlDbType.Int) {Value = Convert.ToInt32(row.Cells["cn_label"].Value)},
                                new SqlParameter("@qty",SqlDbType.Float) {Value = Convert.ToDouble(row.Cells["cn_qtyrest"].Value)},
                                new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                            };
                            if (frm.LabelQty != 0)
                                PrintLabels.PrintLabel(PrintLabels.LabelConstructor(1, "sp_SelectStockLabelDetsPrint", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                            //Thread.Sleep(1000);
                        }
                    }
                }
            }
            #endregion
            try
            {
                bwStart(bw_List);
            }
            catch { }
            //}
            //catch { }
        }

        private void gv_List_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["cn_qtyrest"].Selected == true)
                /*|| gv_List.CurrentRow.Cells["cn_qtyout"].Selected == true*/
                btn_OK.Enabled = false;
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            if (gv_List.CurrentRow.Cells["cn_qtyrest"].Selected == true
                || gv_List.CurrentRow.Cells["cn_qtyout"].Selected == true)
            {
                double number;
                try
                {
                    bool success = Double.TryParse(gv_List.CurrentCell.Value.ToString(), out number);
                    if (success)
                    {
                        //Console.WriteLine("Converted '{0}' to {1}.", value, number);
                    }
                    else
                    {
                        gv_List.CurrentCell.Value = 0;
                        MessageBox.Show("Value must be number!");
                    }
                }
                catch { }
            }

            double _corqty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qtyrest"].Value);
            double _qtyused = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qtyout"].Value);
            double _qtyonlabel = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
            double _qtydiff = 0;

            if (_corqty < 0)
                _corqty = 0;
            if (_corqty - _qtyonlabel > _qtyused)
                _corqty = _qtyonlabel + _qtyused;

            _qtydiff = _corqty - _qtyonlabel;

            gv_List.CurrentRow.Cells["cn_qtyrest"].Value = Math.Round(_corqty, 5);
            gv_List.CurrentRow.Cells["cn_qtydiff"].Value = Math.Round(_qtydiff, 5);

            SetCellsColor();

            btn_OK.Enabled = true;
            //}
        }

        #endregion

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (OutMode != 3)
            {
                //string strLabelMark = "(3L)";
                //string strNextMark = "\n";
                double _qtyonlabel = 0;
                double _qtyrest = 0;
                string _unit = "";
                bool _isok = false;
                //char _PrevChar = (char)Keys.Space;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    //if (e.KeyChar == _PrevChar)
                    //{ 
                    bool _check = Int32.TryParse(txt_Oper.Text, out ReadValue);

                    if (_check == false)
                        ReadValue = 0;
                    //int begindex = ReadValue.IndexOf(strLabelMark);
                    //int endindex = 0;

                    //if (begindex > -1)
                    //{
                    //    endindex = ReadValue.Substring(begindex + 4, ReadValue.Length - (begindex + 4)).IndexOf(strNextMark);
                    //    Result = ReadValue.Substring(begindex + 4, endindex);

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_label"].Value) == /*Convert.ToInt32(txt_Oper.Text)*/ReadValue)
                        {
                            _isok = true;
                            _qtyonlabel = Convert.ToDouble(row.Cells["cn_qty"].Value);
                            _qtyrest = Convert.ToDouble(row.Cells["cn_qtyrest"].Value);
                            _unit = row.Cells["cn_unit"].Value.ToString();
                            break;
                        }

                    }
                    if (_isok == true)
                    {
                        //MessageBox.Show(Result);

                        frm = new frm_BCCorrection();
                        frm.Label = txt_Oper.Text;
                        frm.QtyInDB = _qtyonlabel;
                        frm.QtyOnLabel = _qtyrest;
                        frm.Unit = _unit;

                        frm.SendLabelQty += new SendLabelQtyEventHandler(AddQtyForLabel);
                        frm.Show(); frm.GetKryptonFormFields();

                        frm.ReceiveFocus();
                    }
                    else
                    {
                        KryptonTaskDialog.Show("Mistake during label entering!",
                                              "There is no such label in selected batch!",
                                              "",
                                              MessageBoxIcon.Warning,
                                              TaskDialogButtons.OK);
                        txt_Oper.Text = "";

                    }
                    //Clear temp field
                    txt_Oper.Text = "";
                    //}
                    //}
                    //txt_Oper.Focus();
                    //_PrevChar = (char)Keys.Enter;
                    //}
                    //else
                    //    _PrevChar = (char)Keys.Space;
                }
            }
            else
            {
               
                if (e.KeyChar == (char)Keys.Enter)
                {
                    //if (e.KeyChar == _PrevChar)
                    //{ 
                    bool _check = Int32.TryParse(txt_Oper.Text, out ReadValue);

                    if (_check == false)
                        ReadValue = 0;
                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_label"].Value) == /*Convert.ToInt32(txt_Oper.Text)*/ReadValue)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                                cell.Style.BackColor = Color.LightGreen;
                            txt_Oper.Text = "";
                            txt_Oper.Focus();
                            break;
                        }

                    }
                }
            }
        }

        private void txt_Oper_Validated(object sender, EventArgs e)
        {
            
            //MessageBox.Show(Result);
        }

        private void txt_Oper_TextChanged(object sender, EventArgs e)
        {
            //string strLabelMark = "(3L)";
            //string strNextMark = "\n";

            //ReadValue = txt_Oper.Text;
            
            ////if (ReadValue != strNextMark)
            ////{
            //int begindex = ReadValue.IndexOf(strLabelMark) + 4;
            //int endindex = 0;

            //if (begindex > -1)
            //{
            //    endindex = ReadValue.Substring(begindex, ReadValue.Length - begindex).IndexOf(strNextMark);
            //    Result = ReadValue.Substring(begindex, endindex);

            //        //MessageBox.Show(Result);

            //    frm_BCCorrection frm = new frm_BCCorrection();
            //    frm.Label = Result.ToString();

            //    frm.Show(); frm.GetKryptonFormFields();
                
            //    //Clear temp field
            //    //txt_Oper.Text = "";
            //}
            //    //txt_Oper.Text = "";
            ////}

        }

        private void frm_RestCorrection_FormClosing(object sender, FormClosingEventArgs e)
        {
            gv_List.ThreadSafeCall(delegate
            {
                bs_List.RemoveFilter();
                if (CheckChanges() == true)
                {
                    DialogResult result1 = KryptonTaskDialog.Show("Correction warning!",
                                                                   "Are you want to close?",
                                                                   "You have some unsaved lines!",
                                                                   MessageBoxIcon.Warning,
                                                                   TaskDialogButtons.Yes |
                                                                   TaskDialogButtons.No);
                    if (result1 == DialogResult.Yes)
                    {
                        e.Cancel = false;
                        DAL.DeleteBatchLock(cmb_Batches1.BatchId, this.Name);
                    }
                    else //(result1 == DialogResult.No)
                    {
                        e.Cancel = true;
                    }

                }
                else
                {
                    DAL.DeleteBatchLock(cmb_Batches1.BatchId, this.Name);
                }
            });
            //e.Cancel = true;
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            cmb_BatchStages1.BatchId = cmb_Batches1.BatchId;

            if (cmb_Batches1.BatchId != 0)
            {
                string _res = DAL.AddBatchLock(cmb_Batches1.BatchId, this.Name);
                if (_res != "")
                {
                    cmb_Batches1.ThreadSafeCall(delegate
                    {
                        DialogResult result1 = KryptonTaskDialog.Show("You can not work with such batch!",
                                   "This batch is locked by: " + _res,
                                   "",
                                   MessageBoxIcon.Warning,
                                   TaskDialogButtons.OK);
                    });
                    cmb_Batches1.BatchId = 0;
                }
            }
            else
            {
                DAL.DeleteBatchLock(cmb_Batches1.BatchId, this.Name);
            }


            CheckEmpty();
            
        }

        private void chk_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SelectAll.Checked == true)
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["chk_removeres"].Value = -1;
                }
            else
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["chk_removeres"].Value = 0;
                }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void chk_CheckMode_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_CheckMode.CheckState == CheckState.Checked)
            {
                chk_CheckMode.Text = "Data scanner " + System.Environment.NewLine + "check mode ON";
                chk_CheckMode.BackColor = Color.LightPink;
                OutMode = 3;
                txt_Oper.Focus();
                btn_OK.Visible = false;
                //frm_DirectStockOut frm = new frm_DirectStockOut();
                //frm.Show(); frm.GetKryptonFormFields();
                //txt_DC.Focus();
            }
            else
            {
                chk_CheckMode.Text = "Data scanner " + System.Environment.NewLine + "check mode OFF";
                chk_CheckMode.BackColor = Color.LightGreen;
                if (chk_DataScanner.CheckState == CheckState.Checked)
                    OutMode = 2;
                else
                    OutMode = 1;
                btn_OK.Visible = true;
                bwStart(bw_List);
                //cmb_Articles1.Focus();
            }
        }
    }
}
