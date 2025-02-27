using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.Deliveries;
using Odin.Warehouse.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Warehouse.Packing
{
    public partial class frm_Packing : BaseForm
    {
        public frm_Packing()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "PackingData.xls", this.Name);
        }

        #region Variables

        ExportData ED;
        
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        StockInventory BLL = new StockInventory();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        PrinterLabels PrintLabels = new PrinterLabels();
        DelivNote_BLL DNBll = new DelivNote_BLL();

        Helper MyHelper = new Helper();
        
             
        public int ControlWidth = 250;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int PackId
        { get; set; }

        int _PrevId = 0;

        #endregion

        #region Methods

        public void ClearFilter()
        {
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            cmb_SalesOrdersWithLines1.SalesOrder = "";
            cmb_DeliveryNotes1.DelivNoteId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            txt_Serial.Text = string.Empty;
            txt_boxid.Text = string.Empty;
        }

        public void SetCellsColor()
        {
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_rmstateid"].Value) == -1)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.FromArgb(192, 255, 192);
            //    if (Convert.ToInt32(row.Cells["cn_rmstateid"].Value) == 1)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.Yellow;
            //    if (Convert.ToInt32(row.Cells["chk_isactive"].Value) == 0)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.Gainsboro;
            //}
        }

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

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            var data = StockInventory.getBatchBoxList(String.IsNullOrEmpty(txt_boxid.Text.Trim()) == true || txt_boxid.Text.Trim() == "" ? 0 : Convert.ToInt32(txt_boxid.Text), txt_Serial.Text, cmb_Batches1.BatchId,
                                            cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, cmb_DeliveryNotes1.DelivNoteId, cmb_Types1.TypeId,
                                            txt_ClosingDate.Value == null ? "" : txt_ClosingDate.Value.ToString().Trim(),
                                            txt_ClosingDateTill.Value == null ? "" : txt_ClosingDateTill.Value.ToString().Trim());


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

        }

        private bool CheckOldRow()
        {

            try
            {
                PackId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                PackId = 0;
            }

            if (_PrevId == PackId)
            {
                return true;
            }
            else
            {
                _PrevId = PackId;
                return false;
            }
        }

        #endregion

        #region Controls

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
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
                //if (String.IsNullOrEmpty(bs_List.Filter) == true)
                bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //else
                //    bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
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

            frm.HeaderText = "Select view for batches list";
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
        }

        #endregion

        private void frm_Packing_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            ClearFilter();
            txt_ClosingDate.Value = null;
            txt_ClosingDateTill.Value = null;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_boxid.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Serial.Text = string.Empty;
        }

        private void btn_Content_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_packid != 0)
            {
                var _query = "sp_SelectBatchBoxContent";

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@packid",SqlDbType.Int) {Value = _packid}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Box content: ";
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_packid != 0)
            {
                frm_Print frm = new frm_Print();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 lt.ip, sp.name, sp.dpi from bas_labeltemplate lt inner join sys_printers sp on sp.ipadress = lt.ip where lt.id = 7", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    frm.IP_Address = dt.Rows[0]["ip"].ToString();
                    frm.Printer_DPI = Convert.ToInt32(dt.Rows[0]["dpi"].ToString());
                    frm.PrinterName = dt.Rows[0]["name"].ToString();
                }
                catch
                {
                    frm.cmb_LabPrinter1.ShowDefaults();
                }

                frm.LabelQty = 2;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PrintLabels.PrinterIp = frm.IP_Address;
                    PrintLabels.PrinterDPI = frm.Printer_DPI;

                    var sqlparamsfields = new List<SqlParameter>()
                        {
                            new SqlParameter("@packid",SqlDbType.Int) {Value = _packid},
                            new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                        };
                    if (frm.LabelQty != 0)
                        PrintLabels.PrintLabel(PrintLabels.LabelConstructor(7, "sp_SelectBatchBoxDet", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                }
                else
                { }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _package = "";
            int _qtypack = 0;
            double _weightbrut = 0;
            string _comments = "";
            int _boxno = 0;
            int _headid = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _qtypack = 1;
                _weightbrut = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_weight"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _package = gv_List.CurrentRow.Cells["cn_package"].Value.ToString();
                _boxno = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_boxno"].Value);
                _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddPack frm = new frm_AddPack();
                frm.HeaderText = "Edit package: " + _package;
                frm.Package = _package;
                frm.QtyPack = _qtypack;
                frm.WeightBrut = _weightbrut;
                frm.Comments = _comments;
                frm.BoxNO = _boxno;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DNBll.EditPackage(_id, _headid, frm.Package, frm.QtyPack, frm.WeightBrut, frm.Comments, frm.BoxNO);
                    bwStart(bw_List);
                }
            }
        }

        private void btn_Separate_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            int _coid = 0;
            string _batch = "";
            int _id = 0;
            double _qty = 0;
            int _delivid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);
                _coid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_coid"].Value);
                _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString();
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                _delivid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_delivid"].Value);
            }
            catch { }

            if (_id != 0
                && _delivid == 0)
            {
                frm_cmbNumber frm = new frm_cmbNumber();
                frm.LabelText = "Enter qty to separate:";
                frm.HeaderText = "Separation of boxes";

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && frm.FormNumber > 0)
                {
                    string _res = DNBll.SeparateBox(_id, frm.FormNumber);
                    MessageBox.Show(_res);
                    bwStart(bw_List);
                }
            }
            else
                globClass.ShowMessage("Separation of boxes", "Delete delivery line for this box!", "Separation impossible, delivery note exists!");
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            int _coid = 0;
            string _batch = "";
            int _id = 0;
            int _delivid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);
                _coid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_coid"].Value);
                _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString();
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _delivid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_delivid"].Value);
            }
            catch { }

            if (_batchid != 0
                && _delivid == 0)
            {
                frm_SelectOrders frm = new frm_SelectOrders();
                frm.BatchId = _batchid;
                frm.FillOrders(_batchid);
                frm.HeaderText = "Confirmation orders for batch: " + _batch;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK
                    && frm.COId != _coid
                    && frm.COId != 0
                    && _id != 0)
                {
                    foreach (DataGridViewRow row in gv_List.SelectedRows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_batchid"].Value) == _batchid)
                            DNBll.MapCOToBatch(Convert.ToInt32(row.Cells["cn_id"].Value), _batchid, frm.COId);
                    }
                    bwStart(bw_List);
                }

            }
            else
                globClass.ShowMessage("Changing order", "Delete delivery line for this box!", "Changing order impossible, delivery note exists!");

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {

                DNBll.DeletePackage(_id);

                bwStart(bw_List);

            }
        }

        private void txt_ClosingDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ClosingDate.Value = txt_ClosingDate.Value == null ? System.DateTime.Now : txt_ClosingDate.Value;
        }

        private void txt_ClosingDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ClosingDateTill.Value = txt_ClosingDateTill.Value == null ? System.DateTime.Now : txt_ClosingDateTill.Value;
        }
    }
}
