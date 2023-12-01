using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Planning.Controls
{
    public partial class ctl_BatchStock : UserControl
    {
        public ctl_BatchStock()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "BatchStock.xls", this.Name);
        }

        #region Variables

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        ExportData ED;
        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();

        int _batchid = 0;

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set
            {

                _batchid = value;
                ShowDets(_batchid);
            }
        }

       

        public double QtyStock
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyStock.Text); }
                catch { return 0; }
            }
            set { txt_QtyStock.Text = value.ToString(); }
        }

        public double StockIn
        {
            get
            {
                try { return Convert.ToDouble(txt_StockIn.Text); }
                catch { return 0; }
            }
            set { txt_StockIn.Text = value.ToString(); }
        }

        public double StockOut
        {
            get
            {
                try { return Convert.ToDouble(txt_StockOut.Text); }
                catch { return 0; }
            }
            set { txt_StockOut.Text = value.ToString(); }
        }




        #endregion

        #region Methods

        public void ShowDets(int batchid)
        {
            ClearTotals();
            try
            {
                var data = Plan_BLL.getBatchStock(batchid);

                gv_List.ThreadSafeCall(delegate
                {
                    gv_List.AutoGenerateColumns = false;
                    bs_List.DataSource = data;
                    gv_List.DataSource = bs_List;
                    SetCellsColor();
                });

                FillTotals();
                
                bn_List.ThreadSafeCall(delegate
                {
                    bn_List.BindingSource = bs_List;
                });
            }
            catch { FillTotals(); }
        }

        public void FillTotals()
        {
            double _qtyin = 0;
            double _qtyout = 0;
            double _qtystock = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_ismove"].Value) == 0)
                {
                    _qtystock = _qtystock + Convert.ToDouble(row.Cells["cn_qty"].Value);

                    if (Convert.ToInt32(row.Cells["cn_typemove"].Value) < 0)
                        _qtyout = _qtyout + -1 * Convert.ToDouble(row.Cells["cn_qty"].Value);
                    else
                        _qtyin = _qtyin + Convert.ToDouble(row.Cells["cn_qty"].Value);
                
                }
            }
            QtyStock = _qtystock;
            StockIn = _qtyin;
            StockOut = _qtyout;
        }

        public void ClearTotals()
        {

            QtyStock = 0;
            StockIn = 0;
            StockOut = 0;
        }
        public void SetCellsColor()
        {

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

        #endregion

        #region Controls


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
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
                else
                    bs_List.Filter = bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
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

            frm.HeaderText = "Select view for batches stock";
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

        private void ctl_BatchStock_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }


        private void cmb_Batches1_BatchChanged(object sender)
        {
            BatchId = cmb_Batches1.BatchId;
        }

        #endregion

    }
}
