using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.CrystalReports.Engine;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Warehouse.Inventory
{
    public partial class frm_ProductCard : BaseForm
    {
        public frm_ProductCard()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ProductCard.xls", this.Name);
            //wait = new ProgressForm(this);
        }

        #region Variables

        //ProgressForm wait;

        //public void bwStart(DoWorkEventHandler doWork)
        //{
        //    wait.bwStart(doWork);
        //}

        class_Global glob_Class = new class_Global();
        StockInventory StockBll = new StockInventory();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
        DataTable data;


        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public string Account = "";

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public int AccountId
        {
            get { if (rb_All.Checked == true)
                    return 1;
                else if (rb_RM.Checked == true)
                    return -1;
                else
                    return 0;
            }
        }
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

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            data = StockInventory.getProductCard(cmb_Articles1.ArticleId,
                                                    txt_DateFrom.Value == null ? "" : Convert.ToDateTime(txt_DateFrom.Value).ToShortDateString().Trim(),
                                                    txt_DateTill.Value == null ? "" : Convert.ToDateTime(txt_DateTill.Value).ToShortDateString().Trim(),
                                                    chk_type.Checked == true ? 0 : -1, AccountId);


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

            //crystalReportViewer1.ThreadSafeCall(delegate
            //{
            //    ReportDocument rd;

            //    rd = OpenReport(data);

            //    crystalReportViewer1.ReportSource = rd;
            //});

        }

        public ReportDocument OpenReport(DataTable data)
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\Inventory\\" + "rpt_ProductCard.rpt";


            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);
                       
            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            ////parameters
            report.SetParameterValue("DateFrom", txt_DateFrom.Value == null ? "" : Convert.ToDateTime(txt_DateFrom.Value).ToShortDateString().Trim());
            report.SetParameterValue("DateTill", txt_DateTill.Value == null ? "" : Convert.ToDateTime(txt_DateTill.Value).ToShortDateString().Trim());
            report.SetParameterValue("Article", cmb_Articles1.Article);
            report.SetParameterValue("Unit", cmb_Articles1.Unit);
            report.SetParameterValue("ArtId", cmb_Articles1.ArticleId);
            report.SetParameterValue("RestAtBeginning", Convert.ToDouble(txt_RestAtBeg.Text)); //txt_RestAtBeg.Text == "0" ? "0.0000" : Convert.ToDecimal(txt_RestAtBeg.Text));
            report.SetParameterValue("CenaAtBeginning", Convert.ToDouble(txt_TotalAtBeg.Text) / Convert.ToDouble(txt_RestAtBeg.Text == "0" ? "1" : txt_RestAtBeg.Text));
            report.SetParameterValue("SumAtBeginning", Convert.ToDouble(txt_TotalAtBeg.Text));
            report.SetParameterValue("SumAtEnd", Convert.ToDouble(txt_TotalAtEnd.Text));

            //Labels

            //foreach (DataRow row in datalab.Rows)
            //{
            //    //MessageBox.Show(row["paramvalue"].ToString());
            //    report.SetParameterValue(row["paramname"].ToString(), row["paramvalue"].ToString());
            //}

            //report.SetParameterValue("UserName", System.Environment.UserName);

            return report;

        }

        public void RecalcTotals()
        {
            //Beginning
           
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "execute sp_SelectStockRestOnDateArtAccount @artid = " + cmb_Articles1.ArticleId 
                                                            + ", @date = '" + (txt_DateFrom.Value == null ? "" : Convert.ToDateTime(txt_DateFrom.Value).ToShortDateString().Trim()) 
                                                            + "', @accountid = " + AccountId, conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];
            //MessageBox.Show(dt.Rows.Count.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txt_RestAtBeg.Text = String.IsNullOrEmpty(dr["qty"].ToString()) == true ? "0" : dr["qty"].ToString();
                    txt_TotalAtBeg.Text = String.IsNullOrEmpty(dr["total"].ToString()) == true ? "0" : dr["total"].ToString();
                }
            }
            else
            {
                txt_RestAtBeg.Text = "0";
                txt_TotalAtBeg.Text ="0";
            }

            //End
            SqlConnection conn1 = new SqlConnection(sConnStr);
            conn1.Open();
            DataSet ds1 = new DataSet();

            SqlDataAdapter adapter1 =
                new SqlDataAdapter(
                    "execute sp_SelectStockRestOnDateArtAccount @artid = " + cmb_Articles1.ArticleId + 
                                                                ", @date = '" + (txt_DateTill.Value == null ? "" : Convert.ToDateTime(txt_DateTill.Value).AddDays(1).ToShortDateString().Trim()) 
                                                                + "', @accountid = " + AccountId, conn1);


            conn1.Close();

            adapter1.Fill(ds1);

            DataTable dt1 = ds1.Tables[0];

            if (dt1.Rows.Count > 0)
            {
                foreach (DataRow dr in dt1.Rows)
                {
                    txt_RestAtEnd.Text = String.IsNullOrEmpty(dr["qty"].ToString()) == true ? "0" : dr["qty"].ToString();
                    txt_TotalAtEnd.Text = String.IsNullOrEmpty(dr["total"].ToString()) == true ? "0" : dr["total"].ToString();
                }
            }
            else
            {
                txt_RestAtEnd.Text = "0";
                txt_TotalAtEnd.Text = "0";
            }
            //Incomes & Outcomes
            double _income = 0;
            double _outcome = 0;
            double _totalin = 0;
            double _totalout = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _income = _income + Convert.ToDouble(row.Cells["cn_qtyin"].Value);
                _outcome = _outcome + Convert.ToDouble(row.Cells["cn_qtyout"].Value);
                _totalin = Convert.ToDouble(row.Cells["cn_qtyin"].Value) == 0 ? _totalin : _totalin + Convert.ToDouble(row.Cells["cn_total"].Value);
                _totalout = Convert.ToDouble(row.Cells["cn_qtyout"].Value) == 0 ? _totalout : _totalout + Convert.ToDouble(row.Cells["cn_total"].Value);
            }

            txt_QtyIn.Text = _income.ToString();
            txt_TotalIn.Text = _totalin.ToString();
            txt_QtyOut.Text = _outcome.ToString();
            txt_TotalOut.Text = _totalout.ToString();
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
            //SetCellsColor();
            //RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));

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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_Articles1.ArticleId = 0;
            txt_DateFrom.Value = System.DateTime.Now;
        }

        private void frm_ProductCard_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void txt_DateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DateFrom.Value = txt_DateFrom.Value == null ? System.DateTime.Now : txt_DateFrom.Value;
        }

        private void txt_DateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DateTill.Value = txt_DateTill.Value == null ? System.DateTime.Now : txt_DateTill.Value;
        }
        
        private void cmb_Articles1_ArticleChanged(object sender)
        {
            txt_Unit.Text = cmb_Articles1.Unit;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
            RecalcTotals();

            crystalReportViewer1.ThreadSafeCall(delegate
            {
                ReportDocument rd;

                rd = OpenReport(data);

                crystalReportViewer1.ReportSource = rd;
            });
        }

        #endregion

    }
}
