using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Planning;
using Odin.Sales;
using Odin.Tools;
using Odin.Warehouse.StockIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Warehouse.History
{
    public partial class frm_StockHistory : BaseForm
    {
        public frm_StockHistory()
        {
            InitializeComponent();
            EDI = new ExportData(this.gv_IncomeList, "IncomesHistory.xls", this.Name);
            EDO = new ExportData(this.gv_OutcomeList, "OutcomesHistory.xls", this.Name);
            EDM = new ExportData(this.gv_MovementList, "MovementHistory.xls", this.Name);
            EDT = new ExportData(this.gv_MovementList, "TracingHistory.xls", this.Name);
            EDR = new ExportData(this.gv_ReturnsList, "ReturnsHistory.xls", this.Name);
            EDC = new ExportData(this.gv_CostList, "CostOfBatch" + cmb_Batches1.Batch + ".xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();

        ExportData EDI;
        ExportData EDO;
        ExportData EDM;
        ExportData EDT;
        ExportData EDC;
        ExportData EDR;
        Plan_BLL BLL = new Plan_BLL();
        CO_BLL COBLL = new CO_BLL();
        Helper MyHelper = new Helper();

        public int ControlWidth = 250;

        public int RowIndexI = 0;
        public int ColumnIndexI = 0;
        public string ColumnNameI = "";
        public string CellValueI = "";

        public int RowIndexO = 0;
        public int ColumnIndexO = 0;
        public string ColumnNameO = "";
        public string CellValueO = "";

        public int RowIndexM = 0;
        public int ColumnIndexM = 0;
        public string ColumnNameM = "";
        public string CellValueM = "";

        public int RowIndexT = 0;
        public int ColumnIndexT = 0;
        public string ColumnNameT = "";
        public string CellValueT = "";

        public int RowIndexC = 0;
        public int ColumnIndexC = 0;
        public string ColumnNameC = "";
        public string CellValueC = "";

        public int RowIndexR = 0;
        public int ColumnIndexR = 0;
        public string ColumnNameR = "";
        public string CellValueR = "";

        public int _PrevIdIn = 0;
        public int _PrevIdOut = 0;

        public ctl_IncomeTracing ctlInTracing = null;
        public ctl_StockInRests ctlIn = null;

        public int OperationTypeId
        {
            get
            {
                return Convert.ToInt32(cmb_Operation.SelectedValue);
                //catch { return 0; }
            }
            set { }
        }

        public int LabelId
        {
            get
            {
                 return Convert.ToInt32(txt_Label.Text);
                //catch { return 0; }
            }
            set { txt_Label.Text = value.ToString(); }
        }

        public double QtyIn
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyIn.Text); }
                catch { return 0; }
            }
            set { txt_QtyIn.Text = value.ToString(); }
        }

        public double BOMCost
        {
            get
            {
                try { return Convert.ToDouble(txt_BOMCost.Text); }
                catch { return 0; }
            }
            set { txt_BOMCost.Text = value.ToString(); }
        }

        public double UnitCost
        {
            get
            {
                try { return Convert.ToDouble(txt_CostPrice.Text); }
                catch { return 0; }
            }
            set { txt_CostPrice.Text = value.ToString(); }
        }

        public double Total
        {
            get
            {
                try { return Convert.ToDouble(txt_Total.Text); }
                catch { return 0; }
            }
            set { txt_Total.Text = value.ToString(); }
        }

        public double COPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_COPrice.Text); }
                catch { return 0; }
            }
            set { txt_COPrice.Text = value.ToString(); }
        }

        public double TotalOutcomes
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalOutcomes.Text); }
                catch { return 0; }
            }
            set { txt_TotalOutcomes.Text = value.ToString(); }
        }

        public double TotalIncomes
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalIncomes.Text); }
                catch { return 0; }
            }
            set { txt_TotalIncomes.Text = value.ToString(); }
        }

        public double TotalMovements
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalMovements.Text); }
                catch { return 0; }
            }
            set { txt_TotalMovements.Text = value.ToString(); }
        }

        public double TotalReturns
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalReturns.Text); }
                catch { return 0; }
            }
            set { txt_TotalReturns.Text = value.ToString(); }
        }

        public int _tempbatchid = 0;
        public string _tempbatch = "";

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

        public void FillOperTypes()
        {
            DataSet ds = new DataSet();

            string strSQL = ""; 

            cmb_Operation.SelectedValue = 0;

            strSQL = dn_Pages.SelectedPage == pg_Incomes
                ? "EXECUTE sp_SelectStockOperations @type = 1"
                : dn_Pages.SelectedPage == pg_Withdraw
                ? "EXECUTE sp_SelectStockOperations @type = -1"
                : "EXECUTE sp_SelectStockOperations @type = 0";


            SqlDataAdapter adapter =
                new SqlDataAdapter(
                   strSQL, sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            cmb_Operation.DataSource = dt;
            cmb_Operation.DisplayMember = "operation";
            cmb_Operation.ValueMember = "id";
        }

        public void bw_ListIncomes(object sender, DoWorkEventArgs e)
        {
            int _operid = 0;

            cmb_Operation.Invoke(new MethodInvoker(delegate { _operid = OperationTypeId; }));


            var data = StockHistory_BLL.getIncomesHistory(cmb_IncomeDoc1.IncomeDocId, _operid, cmb_Types1.TypeId, cmb_Firms1.FirmId, cmb_Batches1.BatchId, cmb_SalesOrders1.SalesOrderId,
                                            cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim(), txt_FirmArt.Text);

            gv_IncomeList.ThreadSafeCall(delegate
            {
                gv_IncomeList.AutoGenerateColumns = false;
                bs_IncomeList.DataSource = data;
                gv_IncomeList.DataSource = bs_IncomeList;
                RecalcTotalIncomes();
            });


            bn_IncomeList.ThreadSafeCall(delegate
            {
                bn_IncomeList.BindingSource = bs_IncomeList;
            });
        }

        public void bw_ListOutcomes(object sender, DoWorkEventArgs e)
        {
            int _operid = 0;

            cmb_Operation.Invoke(new MethodInvoker(delegate { _operid = OperationTypeId; }));
            var data = chk_Summary.CheckState == CheckState.Checked
               ? StockHistory_BLL.getOutcomesHistorySum(cmb_OutcomeDocs1.OutcomeDocId, _operid, cmb_Types1.TypeId, cmb_Firms1.FirmId, cmb_Batches1.BatchId, cmb_SalesOrders1.SalesOrderId,
                                            cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim(), txt_FirmArt.Text, cmb_Places1.PlaceId, chk_groupbybatch.Checked == true ? -1 : 0)
               : StockHistory_BLL.getOutcomesHistory(cmb_OutcomeDocs1.OutcomeDocId, _operid, cmb_Types1.TypeId, cmb_Firms1.FirmId, cmb_Batches1.BatchId, cmb_SalesOrders1.SalesOrderId,
                                            cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim(), txt_FirmArt.Text, cmb_Places1.PlaceId, chk_groupbybatch.Checked == true ? -1 : 0);

            gv_OutcomeList.ThreadSafeCall(delegate
            {
                gv_OutcomeList.AutoGenerateColumns = false;
                bs_OutcomeList.DataSource = data;
                gv_OutcomeList.DataSource = bs_OutcomeList;

                RecalcTotalOutcomes();

            });


            bn_OutcomeList.ThreadSafeCall(delegate
            {
                bn_OutcomeList.BindingSource = bs_OutcomeList;
            });
            SetCellsColor();
        }

        public void RecalcTotalsCost()
        {
            double _total = 0;
            BLL.BatchId = cmb_Batches1.BatchId;

            foreach (DataGridViewRow row in this.gv_CostList.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_use"].Value) != 0)
                    _total = _total + Convert.ToDouble(row.Cells["cn_ctotal"].Value);
            }
           
            Total = _total;

            if (cmb_Batches1.BatchId == 0 && cmb_SalesOrders1.SalesOrderId == 0)
            {
                QtyIn = 0;
                UnitCost = 0;
                COPrice = 0;
                BOMCost = 0;
            }
            else
            {
                if (cmb_Batches1.BatchId != 0)
                {
                    QtyIn = BLL.BatchQtyIn;
                    UnitCost = Math.Round(Total / (QtyIn == 0 ? 1 : QtyIn), 5);
                    COPrice = BLL.BatchCOPrice;
                }
                else
                {
                    int _coid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from sal_clientordersdets where headid =" + cmb_SalesOrders1.SalesOrderId));
                    COBLL.COId = _coid;
                    QtyIn = COBLL.COQtyIn;
                    UnitCost = Math.Round(Total / (QtyIn == 0 ? 1 : QtyIn), 5);
                    COPrice = COBLL.COUnitPrice;
                }
                lbl_COPrice.Text = "CO Price (" + BLL.BatchCurrency + ")";
                var param = new List<SqlParameter>
                {
                    new SqlParameter("@batchid", SqlDbType.Int) {Value = cmb_Batches1.BatchId},
                    new SqlParameter("@coid", SqlDbType.Int) {Value = cmb_SalesOrders1.SalesOrderId}
                };

                try
                {
                    //BOMCost = Convert.ToDouble(Helper.GetOneRecord("SELECT DISTINCT dbo.fn_NetUnitCostForBatch(@batchid)", param.ToArray()));
                    BOMCost = Convert.ToDouble(Helper.GetOneRecord("SELECT DISTINCT dbo.fn_NetUnitCostForBatchCO(@batchid, @coid)", param.ToArray()));
                }
                catch { BOMCost = 0; }
            }
        }
        
        public void RecalcTotalIncomes()
        {
            double _total = 0;

            foreach (DataGridViewRow row in this.gv_IncomeList.Rows)
            {
                _total = _total + Convert.ToDouble(row.Cells["cn_totaleur"].Value);
            }

            TotalIncomes = Math.Round(_total, 2);

        }

        public void RecalcTotalOutcomes()
        {
            double _total = 0;

            foreach (DataGridViewRow row in this.gv_OutcomeList.Rows)
            {
                _total = _total + Convert.ToDouble(row.Cells["cn_ototal"].Value);
            }

            TotalOutcomes = Math.Round(_total, 2);

        }

        public void RecalcTotalMovements()
        {
            double _total = 0;

            foreach (DataGridViewRow row in this.gv_MovementList.Rows)
            {
                _total = _total + Convert.ToDouble(row.Cells["cn_mtotal"].Value);
            }

            TotalMovements = Math.Round(_total, 2);
        }

        public void RecalcTotalReturns()
        {
            double _total = 0;

            foreach (DataGridViewRow row in this.gv_ReturnsList.Rows)
            {
                _total = _total + Convert.ToDouble(row.Cells["cn_rtotal"].Value);
            }

            TotalReturns = Math.Round(_total, 2);
        }

        public void bw_ListMovements(object sender, DoWorkEventArgs e)
        {
            int _operid = 0;

            cmb_Operation.Invoke(new MethodInvoker(delegate { _operid = OperationTypeId; }));

            var data = StockHistory_BLL.getMovementHistory(cmb_MoveDocs1.MoveDocId, _operid, cmb_Types1.TypeId, cmb_Batches1.BatchId, cmb_SalesOrders1.SalesOrderId,
                                            cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim(), cmb_Places1.PlaceId, cmb_Places2.PlaceId);

            gv_MovementList.ThreadSafeCall(delegate
            {
                gv_MovementList.AutoGenerateColumns = false;
                bs_MovementList.DataSource = data;
                gv_MovementList.DataSource = bs_MovementList;
                RecalcTotalMovements();
            });


            bn_MovementList.ThreadSafeCall(delegate
            {
                bn_MovementList.BindingSource = bs_MovementList;
            });
        }

        public void bw_ListCost(object sender, DoWorkEventArgs e)
        {
            try
            {
                bs_CostList.RemoveFilter();

                //var data = Plan_BLL.getBatchCostRM(cmb_Batches1.BatchId,  chk_GroupByDoc.CheckState == CheckState.Checked ? -1 : 0, chk_ExcludeA.CheckState == CheckState.Checked ? -1 : 0);

                var data = Plan_BLL.getBatchCostRMCO(cmb_Batches1.BatchId, cmb_SalesOrders1.SalesOrderId, chk_GroupByDoc.CheckState == CheckState.Checked ? -1 : 0, chk_ExcludeA.CheckState == CheckState.Checked ? -1 : 0);


                gv_CostList.ThreadSafeCall(delegate
                {
                    gv_CostList.AutoGenerateColumns = false;
                    bs_CostList.DataSource = data;
                    gv_CostList.DataSource = bs_CostList;
                    SetCellsColorCost();
                    RecalcTotalsCost();
                });


                bn_CostList.ThreadSafeCall(delegate
                {
                    bn_CostList.BindingSource = bs_CostList;
                });


            }
            catch { }
        }

        public void ShowDetailsCost()
        {
            try
            {
                if (cmb_Batches1.BatchId != 0
                    || cmb_SalesOrders1.SalesOrderId != 0)
                {
                    _tempbatchid = cmb_Batches1.BatchId;
                    _tempbatch = cmb_Batches1.Batch;

                    bs_CostList.RemoveFilter();

                    //var data = Plan_BLL.getBatchCostRM(cmb_Batches1.BatchId, chk_GroupByDoc.CheckState == CheckState.Checked ? -1 : 0, chk_ExcludeA.CheckState == CheckState.Checked ? -1 : 0);

                    var data = Plan_BLL.getBatchCostRMCO(cmb_Batches1.BatchId, cmb_SalesOrders1.SalesOrderId, chk_GroupByDoc.CheckState == CheckState.Checked ? -1 : 0, chk_ExcludeA.CheckState == CheckState.Checked ? -1 : 0);


                    gv_CostList.ThreadSafeCall(delegate
                    {
                        gv_CostList.AutoGenerateColumns = false;
                        bs_CostList.DataSource = data;
                        gv_CostList.DataSource = bs_CostList;
                        SetCellsColorCost();
                        RecalcTotalsCost();
                    });


                    bn_CostList.ThreadSafeCall(delegate
                    {
                        bn_CostList.BindingSource = bs_CostList;
                    });
                }
            }
            catch { }
        }

        public void bw_ListReturns(object sender, DoWorkEventArgs e)
        {
            try
            {
                bs_ReturnsList.RemoveFilter();

                var data = StockHistory_BLL.getReturnsHistory(cmb_Types1.TypeId, cmb_Batches1.BatchId, cmb_SalesOrders1.SalesOrderId,
                                            cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim());

                gv_ReturnsList.ThreadSafeCall(delegate
                {
                    gv_ReturnsList.AutoGenerateColumns = false;
                    bs_ReturnsList.DataSource = data;
                    gv_ReturnsList.DataSource = bs_ReturnsList;
                    RecalcTotalReturns();
                });


                bn_ReturnsList.ThreadSafeCall(delegate
                {
                    bn_ReturnsList.BindingSource = bs_ReturnsList;
                });


            }
            catch { }
        }

    public void SetCellsColor()
    {


            foreach (DataGridViewRow row in this.gv_OutcomeList.Rows)
            {

                if (Convert.ToInt32(row.Cells["cn_oid"].Value) == 418857)

                    if (Convert.ToInt32(row.Cells["cn_blockdelivery"].Value) != 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Brown;
            }
        }

        public void SetCellsColorCost()
        {
            foreach (DataGridViewRow row in this.gv_CostList.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isreturn"].Value) == 1)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Azure;
            }
        }

        public void ClearFilter()
        {
            txt_Label.Text = "";
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            txt_FirmArt.Text = string.Empty;
            txt_DateFrom.Value = null; //Convert.ToDateTime("01/01/2000");
            txt_DateTill.Value = null; //Convert.ToDateTime("01/01/2100");
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrders1.SalesOrderId = 0;
            mni_FilterForI.Text = string.Empty;
            bs_IncomeList.RemoveFilter();
            mni_FilterForO.Text = string.Empty;
            bs_OutcomeList.RemoveFilter();
            mni_FilterForM.Text = string.Empty;
            bs_MovementList.RemoveFilter();
        }

        public void FillLabels()
        {
            if (dn_Pages.SelectedPage == pg_Withdraw)
            {
                lbl_FirmsArt.Visible = true;
                lbl_Supplier.Visible = true;
                cmb_Firms1.Visible = true;
                txt_FirmArt.Visible = true;

                lbl_FirmsArt.Text = "Customer's article:";
                lbl_Supplier.Text = "Customer:";
                lbl_PlaceTo.Visible = false;
                cmb_Places2.Visible = false;
                lbl_Place.Visible = true;
                cmb_Places1.Visible = true;
                cmb_MoveDocs1.Visible = false;
                lbl_Document.Visible = true;
                cmb_OutcomeDocs1.Visible = true;
                cmb_IncomeDoc1.Visible = false;
                lbl_Article.Visible = true;
                cmb_Articles1.Visible = true;
                lbl_From.Visible = true;
                txt_DateFrom.Visible = true;
                txt_DateTill.Visible = true;
                lbl_Till.Visible = true;
                cmb_SalesOrders1.Visible = true;
                lbl_SalesOrders.Visible = true;
                lbl_Period.Visible = true;
                lbl_Type.Visible = true;
                cmb_Types1.Visible = true;
                lbl_Operation.Visible = true;
                cmb_Operation.Visible = true;
                chk_groupbybatch.Visible = true;
                chk_Summary.Visible = true;

            }
            else if (dn_Pages.SelectedPage == pg_Incomes)
            {
                lbl_FirmsArt.Visible = true;
                lbl_Supplier.Visible = true;
                cmb_Firms1.Visible = true;
                txt_FirmArt.Visible = true;

                lbl_FirmsArt.Text = "Supplier's article";
                lbl_Supplier.Text = "Supplier";
                lbl_PlaceTo.Visible = false;
                cmb_Places2.Visible = false;
                lbl_Place.Visible = false;
                cmb_Places1.Visible = false;
                cmb_MoveDocs1.Visible = false;
                lbl_Document.Visible = true;
                cmb_OutcomeDocs1.Visible = false;
                cmb_IncomeDoc1.Visible = true;
                lbl_Article.Visible = true;
                cmb_Articles1.Visible = true;
                lbl_From.Visible = true;
                txt_DateFrom.Visible = true;
                txt_DateTill.Visible = true;
                lbl_Till.Visible = true;
                cmb_SalesOrders1.Visible = true;
                lbl_SalesOrders.Visible = true;
                lbl_Period.Visible = true;
                lbl_Type.Visible = true;
                cmb_Types1.Visible = true;
                chk_Summary.Visible = false;
                chk_Summary.Checked = false;

                lbl_Operation.Visible = true;
                cmb_Operation.Visible = true;
                chk_groupbybatch.Visible = false;
            }
            else if (dn_Pages.SelectedPage == pg_Movements)
            {
                lbl_FirmsArt.Visible = false;
                lbl_Supplier.Visible = false;
                cmb_Firms1.Visible = false;
                txt_FirmArt.Visible = false;
                lbl_PlaceTo.Visible = true;
                cmb_Places2.Visible = true;
                lbl_Place.Visible = true;
                cmb_Places1.Visible = true;
                cmb_MoveDocs1.Visible = true;
                lbl_Document.Visible = true;
                cmb_OutcomeDocs1.Visible = false;
                cmb_IncomeDoc1.Visible = false;
                lbl_Article.Visible = true;
                cmb_Articles1.Visible = true;
                lbl_From.Visible = true;
                txt_DateFrom.Visible = true;
                txt_DateTill.Visible = true;
                lbl_Till.Visible = true;
                cmb_SalesOrders1.Visible = true;
                lbl_SalesOrders.Visible = true;
                lbl_Period.Visible = true;
                lbl_Type.Visible = true;
                cmb_Types1.Visible = true;
                lbl_Operation.Visible = true;
                cmb_Operation.Visible = true;
                chk_groupbybatch.Visible = false;
                chk_Summary.Visible = false;
                chk_Summary.Checked = false;


            }
            else if (dn_Pages.SelectedPage == pg_Returns)
            {
                lbl_FirmsArt.Visible = false;
                lbl_Supplier.Visible = false;
                cmb_Firms1.Visible = false;
                txt_FirmArt.Visible = false;

                lbl_FirmsArt.Text = "Supplier's article";
                lbl_Supplier.Text = "Supplier";
                lbl_PlaceTo.Visible = false;
                cmb_Places2.Visible = false;
                lbl_Place.Visible = false;
                cmb_Places1.Visible = false;
                cmb_MoveDocs1.Visible = false;
                lbl_Document.Visible = false;
                cmb_OutcomeDocs1.Visible = false;
                cmb_IncomeDoc1.Visible = false;
                lbl_Article.Visible = true;
                cmb_Articles1.Visible = true;
                lbl_From.Visible = true;
                txt_DateFrom.Visible = true;
                txt_DateTill.Visible = true;
                lbl_Till.Visible = true;
                cmb_SalesOrders1.Visible = true;
                lbl_SalesOrders.Visible = true;
                lbl_Period.Visible = true;
                lbl_Type.Visible = true;
                cmb_Types1.Visible = true;
                lbl_Operation.Visible = false;
                cmb_Operation.Visible = false;
                chk_groupbybatch.Visible = false;
                chk_Summary.Visible = false;
                chk_Summary.Checked = false;

            }
            else if (dn_Pages.SelectedPage == pg_Tracing)
            {
                lbl_FirmsArt.Visible = true;
                lbl_Supplier.Visible = true;
                cmb_Firms1.Visible = true;
                txt_FirmArt.Visible = true;
                lbl_FirmsArt.Text = "Supplier's article";
                lbl_Supplier.Text = "Supplier";
                lbl_PlaceTo.Visible = true;
                cmb_Places2.Visible = true;
                lbl_Place.Visible = true;
                cmb_Places1.Visible = true;
                cmb_MoveDocs1.Visible = false;
                lbl_Document.Visible = false;
                cmb_OutcomeDocs1.Visible = false;
                cmb_IncomeDoc1.Visible = false;
                lbl_Article.Visible = true;
                cmb_Articles1.Visible = true;
                lbl_From.Visible = true;
                txt_DateFrom.Visible = true;
                txt_DateTill.Visible = true;
                lbl_Till.Visible = true;
                cmb_SalesOrders1.Visible = true;
                lbl_SalesOrders.Visible = true;
                lbl_Period.Visible = true;
                lbl_Type.Visible = true;
                cmb_Types1.Visible = true;
                lbl_Operation.Visible = false;
                cmb_Operation.Visible = false;
                chk_groupbybatch.Visible = false;
                chk_Summary.Visible = false;
                chk_Summary.Checked = false;

            }
            else
            {
                lbl_FirmsArt.Visible = false;
                lbl_Supplier.Visible = false;
                cmb_Firms1.Visible = false;
                txt_FirmArt.Visible = false;

                lbl_FirmsArt.Visible = false;

                lbl_Supplier.Visible = false;
                lbl_PlaceTo.Visible = false;
                cmb_Places2.Visible = false;
                lbl_Place.Visible = false;
                cmb_Places1.Visible = false;
                cmb_MoveDocs1.Visible = false;
                lbl_Document.Visible = false;
                cmb_OutcomeDocs1.Visible = false;
                cmb_IncomeDoc1.Visible = false;
                lbl_Article.Visible = false;
                cmb_Articles1.Visible = false;
                lbl_From.Visible = false;
                txt_DateFrom.Visible = false;
                txt_DateTill.Visible = false;
                lbl_Till.Visible = false;
                //cmb_SalesOrders1.Visible = false;
                //lbl_SalesOrders.Visible = false;
                lbl_Period.Visible = false;
                lbl_Type.Visible = false;
                cmb_Types1.Visible = false;
                lbl_Operation.Visible = false;
                cmb_Operation.Visible = false;
                chk_groupbybatch.Visible = false;
                chk_Summary.Visible = false;
                chk_Summary.Checked = false;

            }
        }

        private bool CheckOldRowIncome()
        {

            int _idin = 0;
            try { _idin = Convert.ToInt32(gv_IncomeList.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_PrevIdIn == _idin)
            {
                return true;
            }
            else
            {
                _PrevIdIn = _idin;
                return false;
            }
        }

        #endregion

        #region Pages

        private KryptonPage NewPage(string name, int image, Control content, int _Width)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name;
            p.TextTitle = name;
            p.TextDescription = name;
            p.ImageSmall = imageListSmall.Images[image];

            //p.Width = _Width;

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);


            return p;
        }
        
        public void FindIncomeTracing(int idin)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_IncomeTracing ctlTracing1 = (ctl_IncomeTracing)page.Controls.Find("ctl_IncomeTracing", true).FirstOrDefault();
                if (ctlTracing1 != null)
                {
                    ctlTracing1.IdIn = idin;
                }
                //break;
            }
        }
        public void FindIncomeRests(int idin)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_StockInRests ctlRests1 = (ctl_StockInRests)page.Controls.Find("ctl_StockInRests", true).FirstOrDefault();
                if (ctlRests1 != null)
                {
                    ctlRests1.Id = idin;
                }
                //break;
            }
        }
        private KryptonPage NewInputTracing(int idin)
        {
            ctlInTracing = new ctl_IncomeTracing();
            ControlWidth = ctlInTracing.Width;


            ctlInTracing.IdIn = idin;
            //MessageBox.Show(ctl.Width.ToString());

            return NewPage("Income tracing ", 1, ctlInTracing, ctlInTracing.Width);
        }

        public void ShowIncomeTracing()
        {
            int _idin = 0;
            try { _idin = Convert.ToInt32(gv_IncomeList.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            FindIncomeTracing(_idin);
            FindIncomeRests(_idin);
        }

        private KryptonPage NewInputRest(string Article, int InId, int ArtId)
        {
            ctlIn = new ctl_StockInRests();
            ControlWidth = ctlIn.Width;

            ctlIn.Id = InId;
            ctlIn.ArticleId = ArtId;

            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Rests details ", 1, ctlIn, ctlIn.Width);
        }

        #endregion

        #region Controls

        #region ContextMenuI


        private void mnu_LinesI_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_IncomeList.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_IncomeList.HitTest(mpoint.X, mpoint.Y);

                RowIndexI = info.RowIndex;
                ColumnIndexI = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_IncomeList.ClearSelection();
                gv_IncomeList.Rows[RowIndexI].Cells[ColumnIndexI].Selected = true;
                gv_IncomeList.CurrentCell = gv_IncomeList.Rows[RowIndexI].Cells[ColumnIndexI];

                CellValueI = gv_IncomeList.Rows[RowIndexI].Cells[ColumnIndexI].Value.ToString();
                ColumnNameI = gv_IncomeList.Columns[ColumnIndexI].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexI = 0;
                ColumnIndexI = 0;
                return;
            }
        }

        private void mni_FilterForI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_IncomeList.Filter = ("Convert(" + ColumnNameI + " , 'System.String') like '%" + mni_FilterForI.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
                RecalcTotalIncomes();
            }
            catch
            { }
            //SetCellsColor();

        }

        private void mni_SearchI_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_IncomeList;
            frm.ColumnNumber = gv_IncomeList.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_IncomeList.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();

        }

        private void mni_FilterByI_Click(object sender, EventArgs e)
        {
            try
            {
                bs_IncomeList.Filter = String.IsNullOrEmpty(bs_IncomeList.Filter) == true
                    ? String.IsNullOrEmpty(CellValueI) == true
                        ? "(" + ColumnNameI + " is null OR Convert(" + ColumnNameI + ", 'System.String') = '')"
                        : "Convert(" + ColumnNameI + " , 'System.String') = '" + glob_Class.NES(CellValueI) + "'"
                    : String.IsNullOrEmpty(CellValueI) == true
                        ? bs_IncomeList.Filter + "AND (" + ColumnNameI + " is null OR Convert(" + ColumnNameI + ", 'System.String') = '')"
                        : bs_IncomeList.Filter + " AND Convert(" + ColumnNameI + " , 'System.String') = '" + glob_Class.NES(CellValueI) + "'";
                //MessageBox.Show(bs_List.Filter);
                RecalcTotalIncomes();
            }
            catch { }
           

        }

        private void mni_FilterExcludingSelI_Click(object sender, EventArgs e)
        {
            try
            {
                bs_IncomeList.Filter = String.IsNullOrEmpty(bs_IncomeList.Filter) == true
                    ? "Convert(" + ColumnNameI + " , 'System.String') <> '" + CellValueI + "'"
                    : bs_IncomeList.Filter + " AND " + ColumnNameI + " <> '" + CellValueI + "'";
                RecalcTotalIncomes();
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_RemoveFilterI_Click(object sender, EventArgs e)
        {
            try
            {
                bs_IncomeList.RemoveFilter();
                RecalcTotalIncomes();
            }
            catch { }
            //SetCellsColor();


        }

        private void mni_CopyI_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueI.ToString());
        }

        private void mni_AdminI_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for confirmation orders list";
            frm.grid = this.gv_IncomeList;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_IncomeList);
            }
        }

        private void btn_ExcelI_Click(object sender, EventArgs e)
        {
            EDI.DgvIntoExcel();
        }


        #endregion

        #region ContextMenuO



        private void mnu_LinesO_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_OutcomeList.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_OutcomeList.HitTest(mpoint.X, mpoint.Y);

                RowIndexO = info.RowIndex;
                ColumnIndexO = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_OutcomeList.ClearSelection();
                gv_OutcomeList.Rows[RowIndexO].Cells[ColumnIndexO].Selected = true;
                gv_OutcomeList.CurrentCell = gv_OutcomeList.Rows[RowIndexO].Cells[ColumnIndexO];

                CellValueO = gv_OutcomeList.Rows[RowIndexO].Cells[ColumnIndexO].Value.ToString();
                ColumnNameO = gv_OutcomeList.Columns[ColumnIndexO].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexO = 0;
                ColumnIndexO = 0;
                return;
            }
        }

        private void mni_FilterForO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_OutcomeList.Filter = ("Convert(" + ColumnNameO + " , 'System.String') like '%" + mni_FilterForO.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
                RecalcTotalOutcomes();
            }
            catch
            { }
            //SetCellsColor();

        }

        private void mni_SearchO_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_OutcomeList;
            frm.ColumnNumber = gv_OutcomeList.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_OutcomeList.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();

        }

        private void mni_FilterByO_Click(object sender, EventArgs e)
        {
            try
            {
                bs_OutcomeList.Filter = String.IsNullOrEmpty(bs_OutcomeList.Filter) == true
                    ? String.IsNullOrEmpty(CellValueO) == true
                        ? "(" + ColumnNameO + " is null OR Convert(" + ColumnNameO + ", 'System.String') = '')"
                        : "Convert(" + ColumnNameO + " , 'System.String') = '" + glob_Class.NES(CellValueO) + "'"
                    : String.IsNullOrEmpty(CellValueO) == true
                        ? bs_OutcomeList.Filter + "AND (" + ColumnNameO + " is null OR Convert(" + ColumnNameO + ", 'System.String') = '')"
                        : bs_OutcomeList.Filter + " AND Convert(" + ColumnNameO + " , 'System.String') = '" + glob_Class.NES(CellValueO) + "'";
                //MessageBox.Show(bs_List.Filter);
                RecalcTotalOutcomes();
            }
            catch { }
            //SetCellsColor();


        }

        private void mni_FilterExcludingSelO_Click(object sender, EventArgs e)
        {
            try
            {
                bs_OutcomeList.Filter = String.IsNullOrEmpty(bs_OutcomeList.Filter) == true
                    ? "Convert(" + ColumnNameO + " , 'System.String') <> '" + CellValueO + "'"
                    : bs_OutcomeList.Filter + " AND " + ColumnNameO + " <> '" + CellValueO + "'";
                RecalcTotalOutcomes();
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_RemoveFilterO_Click(object sender, EventArgs e)
        {
            try
            {
                bs_OutcomeList.RemoveFilter();
                RecalcTotalOutcomes();
            }
            catch { }
            //SetCellsColor();


        }

        private void mni_CopyO_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueO.ToString());
        }

        private void mni_AdminO_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for outcome history list";
            frm.grid = this.gv_OutcomeList;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_OutcomeList);
            }
        }

        private void btn_ExcelO_Click(object sender, EventArgs e)
        {
            EDO.DgvIntoExcel();
        }

        #endregion

        #region ContextMenuM

        private void mnu_LinesM_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_MovementList.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_MovementList.HitTest(mpoint.X, mpoint.Y);

                RowIndexM = info.RowIndex;
                ColumnIndexM = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_MovementList.ClearSelection();
                gv_MovementList.Rows[RowIndexM].Cells[ColumnIndexM].Selected = true;
                gv_MovementList.CurrentCell = gv_MovementList.Rows[RowIndexM].Cells[ColumnIndexM];

                CellValueM = gv_MovementList.Rows[RowIndexM].Cells[ColumnIndexM].Value.ToString();
                ColumnNameM = gv_MovementList.Columns[ColumnIndexM].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexM = 0;
                ColumnIndexM = 0;
                return;
            }
        }

        private void mni_FilterForM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_MovementList.Filter = ("Convert(" + ColumnNameM + " , 'System.String') like '%" + mni_FilterForM.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
                RecalcTotalMovements();
            }
            catch
            { }
            //SetCellsColor();

        }

        private void mni_SearchM_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_MovementList;
            frm.ColumnNumber = gv_MovementList.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_MovementList.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();

        }

        private void mni_FilterByM_Click(object sender, EventArgs e)
        {
            try
            {
                bs_MovementList.Filter = String.IsNullOrEmpty(bs_MovementList.Filter) == true
                    ? String.IsNullOrEmpty(CellValueM) == true
                        ? "(" + ColumnNameM + " is null OR Convert(" + ColumnNameM + ", 'System.String') = '')"
                        : "Convert(" + ColumnNameM + " , 'System.String') = '" + glob_Class.NES(CellValueM) + "'"
                    : String.IsNullOrEmpty(CellValueM) == true
                        ? bs_MovementList.Filter + "AND (" + ColumnNameM + " is null OR Convert(" + ColumnNameM + ", 'System.String') = '')"
                        : bs_MovementList.Filter + " AND Convert(" + ColumnNameM + " , 'System.String') = '" + glob_Class.NES(CellValueM) + "'";
                //MessageBox.Show(bs_List.Filter);
                RecalcTotalMovements();
            }
            catch { }
            //SetCellsColor();


        }

        private void mni_FilterExcludingSelM_Click(object sender, EventArgs e)
        {
            try
            {
                bs_MovementList.Filter = String.IsNullOrEmpty(bs_MovementList.Filter) == true
                    ? "Convert(" + ColumnNameM + " , 'System.String') <> '" + CellValueM + "'"
                    : bs_MovementList.Filter + " AND " + ColumnNameM + " <> '" + CellValueM + "'";
                RecalcTotalMovements();
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_RemoveFilterM_Click(object sender, EventArgs e)
        {
            try
            {
                bs_MovementList.RemoveFilter();
                RecalcTotalMovements();
            }
            catch { }
            //SetCellsColor();


        }

        private void mni_CopyM_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueM.ToString());
        }

        private void mni_AdminM_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for movement list";
            frm.grid = this.gv_MovementList;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_MovementList);
            }
        }

        private void btn_ExcelM_Click(object sender, EventArgs e)
        {
            EDM.DgvIntoExcel();
        }


        #endregion


        #region Context Menu Returns

        private void mnu_ReturnsLines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_ReturnsList.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_ReturnsList.HitTest(mpoint.X, mpoint.Y);

                RowIndexR = info.RowIndex;
                ColumnIndexR = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_ReturnsList.ClearSelection();
                gv_ReturnsList.Rows[RowIndexR].Cells[ColumnIndexR].Selected = true;
                gv_ReturnsList.CurrentCell = gv_ReturnsList.Rows[RowIndexR].Cells[ColumnIndexR];

                CellValueR = gv_ReturnsList.Rows[RowIndexR].Cells[ColumnIndexR].Value.ToString();
                ColumnNameR = gv_ReturnsList.Columns[ColumnIndexR].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexR = 0;
                ColumnIndexR = 0;
                return;
            }
        }

        private void mni_FilterForR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_ReturnsList.Filter = ("Convert(" + ColumnNameR + " , 'System.String') like '%" + mni_FilterForR.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
                RecalcTotalReturns();
            }
            catch
            { }
        }

        private void mni_SearchR_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_ReturnsList;
            frm.ColumnNumber = gv_ReturnsList.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_ReturnsList.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterByR_Click(object sender, EventArgs e)
        {
            try
            {
                bs_ReturnsList.Filter = String.IsNullOrEmpty(bs_ReturnsList.Filter) == true
                    ? String.IsNullOrEmpty(CellValueR) == true
                        ? "(" + ColumnNameR + " is null OR Convert(" + ColumnNameR + ", 'System.String') = '')"
                        : "Convert(" + ColumnNameR + " , 'System.String') = '" + glob_Class.NES(CellValueR) + "'"
                    : String.IsNullOrEmpty(CellValueR) == true
                        ? bs_ReturnsList.Filter + "AND (" + ColumnNameR + " is null OR Convert(" + ColumnNameR + ", 'System.String') = '')"
                        : bs_ReturnsList.Filter + " AND Convert(" + ColumnNameR + " , 'System.String') = '" + glob_Class.NES(CellValueR) + "'";
                //MessageBox.Show(bs_List.Filter);
                RecalcTotalReturns();
            }
            catch { }
        }

        private void mni_FilterExcludingSelR_Click(object sender, EventArgs e)
        {
            try
            {
                bs_ReturnsList.Filter = String.IsNullOrEmpty(bs_ReturnsList.Filter) == true
                    ? "Convert(" + ColumnNameR + " , 'System.String') <> '" + CellValueR + "'"
                    : bs_ReturnsList.Filter + " AND " + ColumnNameR + " <> '" + CellValueR + "'";
                RecalcTotalReturns();
            }
            catch { }
        }

        private void mni_RemoveFilterR_Click(object sender, EventArgs e)
        {
            try
            {
                bs_ReturnsList.RemoveFilter();
                RecalcTotalReturns();
            }
            catch { }
        }

        private void mni_CopyR_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueR.ToString());
        }

        private void mni_AdminR_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for returns list";
            frm.grid = this.gv_ReturnsList;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_ReturnsList);
            }
        }
        private void btn_ExcelR_Click(object sender, EventArgs e)
        {
            EDR.DgvIntoExcel();
        }
        #endregion


        #region Context Menu T


        private void mnu_LinesT_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_TracingList.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_TracingList.HitTest(mpoint.X, mpoint.Y);

                RowIndexT = info.RowIndex;
                ColumnIndexT = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_TracingList.ClearSelection();
                gv_TracingList.Rows[RowIndexT].Cells[ColumnIndexT].Selected = true;
                gv_TracingList.CurrentCell = gv_TracingList.Rows[RowIndexT].Cells[ColumnIndexT];

                CellValueT = gv_TracingList.Rows[RowIndexT].Cells[ColumnIndexT].Value.ToString();
                ColumnNameT = gv_TracingList.Columns[ColumnIndexT].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexT = 0;
                ColumnIndexT = 0;
                return;
            }
        }

        private void mni_FilterForT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_TracingList.Filter = ("Convert(" + ColumnNameT + " , 'System.String') like '%" + mni_FilterForT.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            //SetCellsColor();

        }

        private void mni_SearchT_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_TracingList;
            frm.ColumnNumber = gv_TracingList.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_TracingList.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();

        }

        private void mni_FilterByT_Click(object sender, EventArgs e)
        {
            try
            {
                bs_TracingList.Filter = String.IsNullOrEmpty(bs_TracingList.Filter) == true
                    ? String.IsNullOrEmpty(CellValueT) == true
                        ? "(" + ColumnNameT + " is null OR Convert(" + ColumnNameT + ", 'System.String') = '')"
                        : "Convert(" + ColumnNameT + " , 'System.String') = '" + glob_Class.NES(CellValueT) + "'"
                    : String.IsNullOrEmpty(CellValueT) == true
                        ? bs_TracingList.Filter + "AND (" + ColumnNameT + " is null OR Convert(" + ColumnNameT + ", 'System.String') = '')"
                        : bs_TracingList.Filter + " AND Convert(" + ColumnNameT + " , 'System.String') = '" + glob_Class.NES(CellValueT) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            //SetCellsColor();


        }

        private void mni_FilterExcludingSelT_Click(object sender, EventArgs e)
        {
            try
            {
                bs_TracingList.Filter = String.IsNullOrEmpty(bs_TracingList.Filter) == true
                    ? "Convert(" + ColumnNameT + " , 'System.String') <> '" + CellValueT + "'"
                    : bs_TracingList.Filter + " AND " + ColumnNameT + " <> '" + CellValueT + "'";
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_RemoveFilterT_Click(object sender, EventArgs e)
        {
            try
            {
                bs_TracingList.RemoveFilter();
            }
            catch { }
            //SetCellsColor();


        }

        private void mni_CopyT_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueT.ToString());
        }

        private void mni_AdminT_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for tracing";
            frm.grid = this.gv_TracingList;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_TracingList);
            }
        }

        private void btn_ExcelT_Click(object sender, EventArgs e)
        {
            EDT.DgvIntoExcel();
        }

        #endregion



        private void frm_StockHistory_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(/*kryptonSplitContainer1.Panel2*/kryptonPanel3, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_IncomeList);
            LoadColumns(gv_OutcomeList);
            LoadColumns(gv_MovementList);
            LoadColumns(gv_TracingList);
            LoadColumns(gv_CostList);
            LoadColumns(gv_ReturnsList);

            txt_DateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_DateTill.Value = null;

        }

        private void frm_StockHistory_Resize(object sender, EventArgs e)
        {
            if (_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });

                }
            }
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_DateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_DateTill.Value = System.DateTime.Now;
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }


        private void dn_Pages_Click(object sender, EventArgs e)
        {
            FillOperTypes();
            FillLabels();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (dn_Pages.SelectedPage == pg_Incomes)
            {
                DataGridViewColumn oldColumn = gv_IncomeList.SortedColumn;
                var dir = Helper.SaveDirection(gv_IncomeList);

                bwStart(bw_ListIncomes);

                Helper.RestoreDirection(gv_IncomeList, oldColumn, dir);
            }
            else if (dn_Pages.SelectedPage == pg_Withdraw)
            {
                DataGridViewColumn oldColumn = gv_OutcomeList.SortedColumn;
                var dir = Helper.SaveDirection(gv_OutcomeList);

                bwStart(bw_ListOutcomes);
                Helper.RestoreDirection(gv_OutcomeList, oldColumn, dir);
            }
            else if (dn_Pages.SelectedPage == pg_Movements)
            {
                DataGridViewColumn oldColumn = gv_MovementList.SortedColumn;
                var dir = Helper.SaveDirection(gv_MovementList);

                bwStart(bw_ListMovements);

                Helper.RestoreDirection(gv_MovementList, oldColumn, dir);
            }
            else if (dn_Pages.SelectedPage == pg_Cost)
            {
                DataGridViewColumn oldColumn = gv_CostList.SortedColumn;
                var dir = Helper.SaveDirection(gv_CostList);

                ShowDetailsCost();//bwStart(bw_ListCost);

                Helper.RestoreDirection(gv_CostList, oldColumn, dir);
            }
            else if (dn_Pages.SelectedPage == pg_Tracing)
            {
                //bwStart(bw_Tracing);
            }
            else
            {
                bwStart(bw_ListReturns);
            }

        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_FirmArt.Text = string.Empty;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();

        }

        private void txt_DateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DateFrom.Value = txt_DateFrom.Value == null ? System.DateTime.Now : txt_DateFrom.Value;
        }

        private void txt_DateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DateTill.Value = txt_DateTill.Value == null ? System.DateTime.Now : txt_DateTill.Value;
        }

        #endregion

        #region Context Menu Costs

        private void mnu_CostLines_Opening(object sender, CancelEventArgs e)
        {

            try
            {
                Point mpoint = gv_CostList.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_CostList.HitTest(mpoint.X, mpoint.Y);

                RowIndexC = info.RowIndex;
                ColumnIndexC = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_CostList.ClearSelection();
                gv_CostList.Rows[RowIndexC].Cells[ColumnIndexC].Selected = true;
                gv_CostList.CurrentCell = gv_CostList.Rows[RowIndexC].Cells[ColumnIndexC];

                CellValueC = gv_CostList.Rows[RowIndexC].Cells[ColumnIndexC].Value.ToString();
                ColumnNameC = gv_CostList.Columns[ColumnIndexC].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexC = 0;
                ColumnIndexC = 0;
                return;
            }
        }

        private void mni_SearchC_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_CostList;
            frm.ColumnNumber = gv_CostList.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_CostList.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }


        private void mni_FilterForC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_CostList.Filter = ("Convert(" + ColumnNameC + " , 'System.String') like '%" + mni_FilterForC.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
                RecalcTotalsCost();
            }
            catch
            { }
        }

        private void mni_FilterByC_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_CostList.Filter) == true)
                {
                    bs_CostList.Filter = String.IsNullOrEmpty(CellValueC) == true
                        ? "(" + ColumnNameC + " is null OR Convert(" + ColumnNameC + ", 'System.String') = '')"
                        : "Convert(" + ColumnNameC + " , 'System.String') = '" + glob_Class.NES(CellValueC) + "'";
                    RecalcTotalsCost();
                }
                else
                {
                    bs_CostList.Filter = String.IsNullOrEmpty(CellValueC) == true
                        ? bs_CostList.Filter + "AND (" + ColumnNameC + " is null OR Convert(" + ColumnNameC + ", 'System.String') = '')"
                        : bs_CostList.Filter + " AND Convert(" + ColumnNameC + " , 'System.String') = '" + glob_Class.NES(CellValueC) + "'";
                    RecalcTotalsCost();
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_CostList.Filter = String.IsNullOrEmpty(bs_CostList.Filter) == true
                    ? "Convert(" + ColumnNameC + " , 'System.String') <> '" + CellValueC + "'"
                    : bs_CostList.Filter + " AND " + ColumnNameC + " <> '" + CellValueC + "'";
                RecalcTotalsCost();
            }
            catch { }
        }

        private void mni_RemoveFilterC_Click(object sender, EventArgs e)
        {
            try
            {
                bs_CostList.RemoveFilter();
                RecalcTotalsCost();
            }
            catch { }
        }


        private void mni_CopyC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueC.ToString());
        }

        private void mni_AdminC_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for confirmation orders list";
            frm.grid = this.gv_CostList;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_CostList);
            }
        }


        private void btn_ExcelC_Click(object sender, EventArgs e)
        {
            EDC.DgvIntoExcel();
        }

        #endregion
        
        private void gv_CostList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_CostList.CurrentRow.Cells["chk_use"].Selected == true)
            {
                gv_CostList.EndEdit();

                RecalcTotalsCost();
            }
        }

        private void btn_Tracing_Click(object sender, EventArgs e)
        {
            int _idin = 0;
            try { _idin = Convert.ToInt32(gv_IncomeList.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputTracing(_idin) });
        }

        private void gv_IncomeList_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRowIncome() == false)
            {
                ShowIncomeTracing();
            }
        }

        private void btn_Rests_Click(object sender, EventArgs e)
        {
            string _article = "";
            int _artid = 0;
            int _idin = 0;

            try
            {
                _article = gv_IncomeList.CurrentRow.Cells["cn_article"].Value.ToString();
                _artid = Convert.ToInt32(gv_IncomeList.CurrentRow.Cells["cn_artid"].Value);
                _idin = Convert.ToInt32(gv_IncomeList.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputRest(_article, _idin, _artid) });
        }

        private void txt_BOMCost_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void txt_BOMCost_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btn_showcostdets_Click(object sender, EventArgs e)
        {

            var _query = "";
            //_query = "sp_SelectNetUnitCostForBatchDets";
            _query = "sp_SelectNetUnitCostForBatchDetsCO";

            var sqlparams = new List<SqlParameter>
                {
                 new SqlParameter("@batchid",SqlDbType.Int){Value = _tempbatchid},
                 new SqlParameter("@coid",SqlDbType.Int){Value = cmb_SalesOrders1.SalesOrderId}
                };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = cmb_Batches1.BatchId != 0 ? "BOM cost details for: " + _tempbatch : "BOM cost details for: " + cmb_SalesOrders1.SalesOrder;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_AwaitingCost_Click(object sender, EventArgs e)
        {
            var _query = "";
            //_query = "sp_SelectAwaitingUnitCostForBatchDets";
            _query = "sp_SelectAwaitingUnitCostForBatchDetsCO";
            var sqlparams = new List<SqlParameter>
                {
                new SqlParameter("@batchid",SqlDbType.Int){Value = cmb_Batches1.BatchId},
                new SqlParameter("@coid",SqlDbType.Int){Value = cmb_SalesOrders1.SalesOrderId}
                };

            Template_DataGridView frm = new Template_DataGridView();
            frm.Text = cmb_Batches1.BatchId != 0
                ? "Awaiting cost details for: " + cmb_Batches1.Batch
                : "Awaiting cost details for: " + cmb_SalesOrders1.SalesOrder;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }
    }
}
