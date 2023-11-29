using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Sales.Reports
{
    public partial class frm_ProfitReports : BaseForm
    {
        public frm_ProfitReports()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "SellingDocs.xls", this.Name);
        }

        CO_BLL BLL = new CO_BLL();
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;


        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public double TotalProfit
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalProfit.Text); }
                catch { return 0; }
            }
            set { txt_TotalProfit.Text = value.ToString(); }
        }

        public double TradeMargin
        {
            get
            {
                try { return Convert.ToDouble(txt_TradeMargin.Text); }
                catch { return 0; }
            }
            set { txt_TradeMargin.Text = value.ToString(); }
        }

        public double Profit
        {
            get
            {
                try { return Convert.ToDouble(txt_Profit.Text); }
                catch { return 0; }
            }
            set { txt_Profit.Text = value.ToString(); }
        }

        #region Methods

        public void ClearDates()
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;
            txt_CreatDateTill.Value = System.DateTime.Now;
        }

        public void ClearFilter()
        {
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            txt_CreatDateFrom.Value = null; //Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();

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

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_totalqtysold"].Value) < Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value))
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.LightCoral;
                }
            }
        }

        public void RecalcTotals()
        {
            double _totalprofit = 0;
            double _totalcost = 0;
            double _totalsell = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _totalprofit = _totalprofit + Convert.ToDouble(row.Cells["cn_totalprofit"].Value);
                _totalcost = _totalcost + Convert.ToDouble(row.Cells["cn_totalcost"].Value);
                _totalsell = _totalsell + Convert.ToDouble(row.Cells["cn_totalsell"].Value);
            }

            txt_TotalProfit.ThreadSafeCall(delegate { TotalProfit = _totalprofit; });

            txt_TradeMargin.Invoke(new MethodInvoker(delegate { TradeMargin = Math.Round(_totalprofit * 100 / (_totalcost == 0 ? 1 : _totalcost), 2); }));

            txt_Profit.ThreadSafeCall(delegate { Profit = Math.Round(_totalprofit * 100 / (_totalsell == 0 ? 1 : _totalsell), 2); });
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            //DataTable data;
            var data = CO_BLL.getProfitReports(cmb_Firms1.FirmId, cmb_Types1.TypeId, txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                              txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim());

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

            RecalcTotals();
            //crystalReportViewer1.ThreadSafeCall(delegate
            //{
            //    ReportDocument rd;

            //    rd = OpenReport(data, chk_Summary.CheckState == CheckState.Checked ? true : false);

            //    crystalReportViewer1.ReportSource = rd;
            //});

        }

        public void ShowDets()
        {
            DataTable data;
            data = CO_BLL.getProfitReports(cmb_Firms1.FirmId, cmb_Types1.TypeId, txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                              txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim());

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            SetCellsColor();
            RecalcTotals();
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
            //MessageBox.Show(ColumnName);
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
                RecalcTotals();
            }
            catch
            { }

            SetCellsColor();

            //RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
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
                RecalcTotals();
            }
            catch { }
            SetCellsColor();
            //RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'"
                    : bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
                RecalcTotals();
            }
            catch { }
            SetCellsColor();
            //RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
                RecalcTotals();
            }
            catch { }
            SetCellsColor();
            //RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));

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


        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }


        private void txt_CreatDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateFrom.Value = txt_CreatDateFrom.Value == null ? System.DateTime.Now : txt_CreatDateFrom.Value;
        }

        private void txt_CreatDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateTill.Value = txt_CreatDateTill.Value == null ? System.DateTime.Now : txt_CreatDateTill.Value;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CreatDateTill.Value = System.DateTime.Now;
        }

        private void frm_ProfitReports_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            ClearDates();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //ShowDets();
            bwStart(bw_List);
        }


        #endregion

        private void gv_List_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string _batch = "";
            try
            { _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString(); }
            catch { }

            var _query = "sp_SelectBatchParentDeliveries";

            var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@batch",SqlDbType.NVarChar, 50) {Value = _batch}
                };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Deliveries for sub-batch " + _batch;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show();

        }
    }
}
