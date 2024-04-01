using CrystalDecisions.CrystalReports.Engine;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.Warehouse.Reports
{
    public partial class frm_InventoryReport : BaseForm
    {
        public frm_InventoryReport()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "Inventory.xls", this.Name);
        }

        StockRep_BLL BLL = new StockRep_BLL();
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;


        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public string Account = "";

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public string Language
        {
            get { if (rb_Lat.Checked == true)
                    return "LAT";
                else if(rb_Rus.Checked == true)
                    return "RUS";
                return "ENG";
            }
            set { }
        }
        
        #region Methods

        public void ClearDates()
        {
            txt_Date.Value = System.DateTime.Now;
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

        public void ClearFilter()
        {
            cmb_Articles1.ArticleId = 0;
            cmb_Types1.TypeId = 0;
            txt_Date.Value = System.DateTime.Now;
            cmb_Places1.PlaceId = 0;
            cmb_StockInTypes1.StockMovTypeId = 0;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
            cmb_Types1.LoadTypeIDS();
        }


        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //foreach (int typeid in cmb_Types1.TypeIDs)
            //{
            //    MessageBox.Show(typeid.ToString());
            //}

            Account = cmb_Places1.txt_Place.Text;

            DataTable data;
            data = StockRep_BLL.getInventoryReports(cmb_Articles1.ArticleId,
                                                    txt_Date.Value.ToShortDateString(),
                                                    cmb_Places1.PlaceId,
                                                    cmb_Types1.TypeId,
                                                    chk_groupbyplaces.Checked == true ? -1 : 0,
                                                    chk_groupbydoc.Checked == true ? -1 : 0,
                                                    chk_groupbylabel.Checked == true ? -1 : 0,
                                                    cmb_StockInTypes1.StockMovTypeId,
                                                    chk_ShowInTransit.Checked == true ? -1 : 0,
                                                    chk_WIP.Checked == true ? -1 : 0,
                                                    chk_GroupByPrices.Checked == true ? -1 : 0,
                                                    cmb_Users1.UserId);


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

            crystalReportViewer1.ThreadSafeCall(delegate
            {
                ReportDocument rd;

                rd = OpenReport(data, Language);

                crystalReportViewer1.ReportSource = rd;
            });

        }

        public void bw_ListFA(object sender, DoWorkEventArgs e)
        {
            //foreach (int typeid in cmb_Types1.TypeIDs)
            //{
            //    MessageBox.Show(typeid.ToString());
            //}

            Account = cmb_Places1.txt_Place.Text;

            DataTable data;
            data = StockRep_BLL.getInventoryReportsFA(cmb_Articles1.ArticleId,
                                                    txt_Date.Value.ToShortDateString(),
                                                    cmb_Places1.PlaceId,
                                                    cmb_Types1.TypeId,
                                                    chk_groupbyplaces.Checked == true ? -1 : 0,
                                                    chk_groupbydoc.Checked == true ? -1 : 0,
                                                    chk_groupbylabel.Checked == true ? -1 : 0,
                                                    cmb_StockInTypes1.StockMovTypeId,
                                                    chk_GroupByPrices.Checked == true ? -1 : 0,
                                                    cmb_Users1.UserId);


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

            crystalReportViewer1.ThreadSafeCall(delegate
            {
                ReportDocument rd;

                rd = OpenReport(data, Language);

                crystalReportViewer1.ReportSource = rd;
            });

        }

        public void bw_ListAccount(object sender, DoWorkEventArgs e)
        {
            DataTable data;
            data = StockRep_BLL.getInventoryReportsAccount(txt_Date.Value.ToShortDateString(),
                                                   Account,
                                                   chk_groupbyplaces.Checked == true ? -1 : 0,
                                                   chk_groupbydoc.Checked == true ? -1 : 0,
                                                   chk_groupbylabel.Checked == true ? -1 : 0,
                                                   chk_GroupByPrices.Checked == true ? -1 : 0,
                                                   chk_hidezero.Checked == true ? -1 : 0);


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

            crystalReportViewer1.ThreadSafeCall(delegate
            {

                ReportDocument rd;

                //using (var report = new ReportDocument())
                //{
                //    // your logic here
                //}

                rd = OpenReport(data, Language);

                crystalReportViewer1.ReportSource = rd;
            });

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
            }
            catch
            { }

            //SetCellsColor();
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

            }
            catch { }
            //SetCellsColor();
            //RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));

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
            //SetCellsColor();
            //RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            //SetCellsColor();
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

        private void frm_InventoryReport_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            ClearDates();
        }


        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Account = "All";
            bwStart(bw_List);
        }

        public ReportDocument OpenReport(DataTable data, string Lang)
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\Reports\\" + "rpt_Inventory.rpt";


            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);
                      
            DataTable datalab = new DataTable();
            datalab = DAL_Functions.getReportLabels("Inventory", Lang);

            //Check for currency
            int number;

            bool success = Int32.TryParse(DAL.DefaultValue("currency"), out number);
            
            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            ////parameters
            report.SetParameterValue("InventoryDate", txt_Date.Value.ToShortDateString());
            report.SetParameterValue("AktNr", txt_ActNum.Text);
            report.SetParameterValue("TypeReport", Account);
            report.SetParameterValue("AktDate", txt_ActDate.Value.ToShortDateString());
            //report.SetParameterValue("InvoiceDate", BLL.ExInvoiceDocDate);
            //report.SetParameterValue("Seller", BLL.ExInvoiceSender);
            //report.SetParameterValue("SellerVAT", BLL.ExInvoiceSenderVAT);

            //Labels

            foreach (DataRow row in datalab.Rows)
            {
                //MessageBox.Show(row["paramvalue"].ToString());
                report.SetParameterValue(row["paramname"].ToString(), row["paramvalue"].ToString());
            }

            //report.SetParameterValue("UserName", System.Environment.UserName);

            return report;

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_RMRefresh_Click(object sender, EventArgs e)
        {
            Account = "2110";
            bwStart(bw_ListAccount);
        }
                
        private void btn_WIPRefresh_Click(object sender, EventArgs e)
        {
            Account = "2120";
            bwStart(bw_ListAccount);
        }

        private void btn_FCSRefresh_Click(object sender, EventArgs e)
        {
            Account = "2130";
            bwStart(bw_ListAccount);
        }

        private void btn_OthersRefresh_Click(object sender, EventArgs e)
        {
            Account = "9999";
            bwStart(bw_ListAccount);
        }

        private void btn_FixedAssets_Click(object sender, EventArgs e)
        {
            Account = "All";
            bwStart(bw_ListFA);
        }
    }
}
