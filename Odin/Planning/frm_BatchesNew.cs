using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Planning.Controls;
using Odin.Planning.Passport;
using Odin.Tools;
using Odin.Warehouse.StockOut.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Planning
{
    public delegate void BatchSavingNewEventHandler(object sender);
    public delegate int ReceiveRMIdNew();
    public delegate int ReceiveBatchIdNew();

    public partial class frm_BatchesNew : BaseForm
    {
        //private int _count = 1;

        public frm_BatchesNew()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "BatchList.xls", this.Name);
        }

        #region Variables

        public event BatchSaving1EventHandler BatchSaved;
        public static event ReceiveRMId ReceiveRMArtId;
        public static event ReceiveBatchId ReceiveBatchId;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int IsActive
        {
            get { return chk_Active.CheckState == CheckState.Checked ? -1 : chk_Active.CheckState == CheckState.Unchecked ? 0 : 1; }
            set { chk_Active.CheckState = value == -1 ? CheckState.Checked : value == 0 ? CheckState.Unchecked : CheckState.Indeterminate; }
        }

        public ctl_CreatBatchDets ctlCreatBatch = null;
        public ctl_BatchFreeze ctlBatchRM = null;
        public ctl_RMFreeze ctlArticlesRM = null;
        public ctl_ArtTotals ctlArtTotals = null;
        public ctl_RMPoDistribute ctlPOreserve = null;
        public ctl_BatchOrders ctlBatchOrders = null;
        public ctl_RMTracing ctlBatchRMCost = null;
        public ctl_BatchStock ctlBatchStock = null;
        public ctl_QCTracing ctlBatchQCTracing = null;
        public ctl_Launches ctlBatchLaunches = null;

        public int ctlCreatBatchWidth = 0;
        public int ctlBatchRMWidth = 0;
        public int ctlArticlesRMWidth = 0;
        public int ctlArtTotalsWidth = 0;
        public int ctlPOreserveWidth = 0;
        public int ctlBatchOrdersWidth = 0;
        public int ctlBatchRMCostWidth = 0;
        public int ctlBatchStockWidth = 0;
        public int ctlBatchQCTracingWidth = 0;
        public int ctlBatchLaunchesWidth = 0;

        public int ControlWidth = 250;
        public int BatchId { get; set; }
        int _PrevId = 0;
        frm_AddBatchP frm = null;
        frm_BatchGrouping frmg = null;
        public int TempArtId { get; set; }

        #endregion

        #region Methods

        private void SavedBatch(object sender)
        {
            BatchSaved?.Invoke(this);
        }

        public void ClearFilter()
        {
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            
            cmb_Types1.TypeId = 0;
            cmb_Department1.DeptId = 0;
            
            cmb_Articles1.ArticleId = 0;

            txt_StartFrom.Value = null;
            txt_StartTill.Value = null;
            txt_EndFrom.Value = null;
            txt_EndTill.Value = null;
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_rmstateid"].Value) == -1)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                if (Convert.ToInt32(row.Cells["cn_rmstateid"].Value) == 1)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Yellow;

                //if (Convert.ToInt32(row.Cells["cn_complected"].Value) != 0)
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                if (Convert.ToInt32(row.Cells["chk_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Gainsboro;
                if (Convert.ToInt32(row.Cells["cn_artid"].Value) != Convert.ToInt32(row.Cells["cn_coartid"].Value))
                {
                    row.Cells["cn_article"].Style.Font = new Font(this.Font, FontStyle.Bold);
                    row.Cells["cn_article"].Style.ForeColor = Color.Red;
                }
            }
        }

        public void LoadColumns(DataGridView grid)
        {
            DAL.UserLogin = Environment.UserName;

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
                    foreach (DataGridViewColumn column in grid.Columns)
                        if (column.Name == reader["columnname"].ToString())
                        {
                            column.DisplayIndex = Convert.ToInt32(reader["columnorder"]);
                            column.HeaderText = reader["columntext"].ToString();
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                reader.Close();
            }

            sqlConn.Close();

        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(cmb_SalesOrdersWithLines1.SalesOrderLineId.ToString());
            var data = (DataTable)Helper.getSP("sp_BatchesList", cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, IsActive,
                                            cmb_Types1.TypeId, cmb_Department1.DeptId, txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                            txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim(),
                                            txt_EndFrom.Value == null ? "" : txt_EndFrom.Value.ToString().Trim(),
                                            txt_EndTill.Value == null ? "" : txt_EndTill.Value.ToString().Trim());
                
            gv_List.ThreadSafeCall(delegate
            {
                //bs_List.RemoveFilter();
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

        private KryptonPage NewInputGeneral(int _batchid)
        {
            
            PlanBll.BatchId = _batchid;
            
            ctlCreatBatch = new ctl_CreatBatchDets();
            ctlCreatBatchWidth = ctlCreatBatch.Width;
            ctlCreatBatch.COrderId = PlanBll.BatchCOId;
            ctlCreatBatch.cmb_SalesOrdersWithLines1.SalesOrderLineId = PlanBll.BatchCOId;
            ctlCreatBatch.ArticleId = PlanBll.BatchArtId;
            ctlCreatBatch.fOldArticleId = PlanBll.BatchArtId;
            ctlCreatBatch.BatchId = _batchid;
            ctlCreatBatch.Batch = PlanBll.BatchName;
            ctlCreatBatch._EditMode = -1;
            ctlCreatBatch.QtyInBatch = PlanBll.BatchQty;
            ctlCreatBatch.fOldQtyInBatch = PlanBll.BatchQty;
            ctlCreatBatch.fOldComments = PlanBll.BatchComments;
            ctlCreatBatch.Comments = PlanBll.BatchComments;
            ctlCreatBatch.StartDate = PlanBll.BatchStartDate;
            ctlCreatBatch.fOldStartDate = PlanBll.BatchStartDate;
            ctlCreatBatch.fOldEndDate = PlanBll.EndDate;
            ctlCreatBatch.EndDate = PlanBll.EndDate;
            ctlCreatBatch.Urgent = PlanBll.Urgent;
            ctlCreatBatch.fOldUrgent = PlanBll.Urgent;
            ctlCreatBatch.FillExistedLines(_batchid);
            ctlCreatBatch.FillDecNum();
            ctlCreatBatch.FillGridBatch(_batchid);
            ctlCreatBatch.SaveBatch += new SaveBatchEventHandler(SavedBatch);
            
            ControlWidth = ctlCreatBatch.Width;
            ctlCreatBatchWidth = ctlCreatBatch.Width;

            return NewPage("Batch dets", 1, ctlCreatBatch, ctlCreatBatch.Width);
        }
        
        private KryptonPage NewInputBatchRM(int _batchid)
        {
            ctlBatchRM = new ctl_BatchFreeze();
            ctlBatchRM.cmb_Batches1.BatchId = _batchid;
            //ctlCreatBatch.SaveBatch += new SaveBatchEventHandler(SavedBatch);
            ctlBatchRM.SendArtId += new RMIdSendingEventHandler(ShowPages);
            
            ControlWidth = ctlBatchRM.Width;
            ctlBatchRMWidth = ctlBatchRM.Width;

            return NewPage("Batch RM reservation", 1, ctlBatchRM, ctlBatchRM.Width);
        }

        private KryptonPage NewInputBatchRMCost(int _batchid)
        {
            ctlBatchRMCost = new ctl_RMTracing();
            ctlBatchRMCost.cmb_Batches1.BatchId = _batchid;
            
            ControlWidth = ctlBatchRMCost.Width;
            ctlBatchRMCostWidth = ctlBatchRMCost.Width;

            return NewPage("Batch RM Cost", 1, ctlBatchRMCost, ctlBatchRMCost.Width);
        }

        private KryptonPage NewInputBatchQCTracing(int _batchid)
        {
            ctlBatchQCTracing = new ctl_QCTracing();
            ctlBatchQCTracing.BatchId = _batchid;

            ControlWidth = ctlBatchQCTracing.Width;
            ctlBatchQCTracingWidth = ctlBatchQCTracing.Width;

            return NewPage("Batch QC tracing", 1, ctlBatchQCTracing, ctlBatchQCTracing.Width);
        }

        private KryptonPage NewInputBatchLaunches(int _batchid)
        {
            ctlBatchLaunches = new ctl_Launches();
            ctlBatchLaunches.BatchId = _batchid;
            //ctlBatchLaunches.gv_List.ThreadSafeCall(delegate { ctlBatchLaunches.SetCellsColor(); });

            ControlWidth = ctlBatchLaunches.Width;
            ctlBatchLaunchesWidth = ctlBatchLaunches.Width;

            return NewPage("Batch launches", 1, ctlBatchLaunches, ctlBatchLaunches.Width);
        }

        private KryptonPage NewInputBatchCO(int _batchid)
        {
            ctlBatchOrders = new ctl_BatchOrders();
            ctlBatchOrders.cmb_Batches1.BatchId = _batchid;
          
            ControlWidth = ctlBatchOrders.Width;
            ctlBatchOrdersWidth = ctlBatchOrders.Width;

            return NewPage("Confirmation orders for batch", 1, ctlBatchOrders, ctlBatchOrders.Width);
        }

        private KryptonPage NewInputBatchStock(int _batchid)
        {
            ctlBatchStock = new ctl_BatchStock();
            ctlBatchStock.cmb_Batches1.BatchId = _batchid;

            ControlWidth = ctlBatchStock.Width;
            ctlBatchStockWidth = ctlBatchStock.Width;

            return NewPage("Stock movement for batch", 1, ctlBatchStock, ctlBatchStock.Width);
        }

        private KryptonPage NewInputArticle(int _artid, int _batchid)
        {
            ctlArticlesRM = new ctl_RMFreeze();
            ctlArticlesRM.cmb_Articles1.ArticleIdRec = _artid;
            ctlArticlesRM.BatchId = _batchid;
            //ctlArticlesRM.SendBatchId += new BatchIdSendingEventHandler(ShowBatchRMDetails);
            ctlArticlesRM.SendArtId += new ArtIdSendingEventHandler(ShowPages);

            ControlWidth = ctlArticlesRM.Width;
            ctlArticlesRMWidth = ctlArticlesRM.Width; 

            return NewPage("Articles reservation", 1, ctlArticlesRM, ctlArticlesRM.Width);
        }

        private KryptonPage NewInputPO(int _artid)
        {
            ctlPOreserve = new ctl_RMPoDistribute();
            ctlPOreserve.cmb_Articles1.ArticleId = _artid;
            ctlPOreserve.SendBatchId += new BatchIdPOSendingEventHandler(ShowPages);

            ControlWidth = ctlPOreserve.Width;
            ctlPOreserveWidth = ctlPOreserve.Width; 

            return NewPage("Purchase orders reservation", 1, ctlPOreserve, ctlPOreserve.Width);
        }

        private KryptonPage NewInputTotal(int _artid)
        {
            ctlArtTotals = new ctl_ArtTotals();
            ctlArtTotals.cmb_Articles1.ArticleId = _artid;

            ControlWidth = ctlArtTotals.Width;
            ctlArtTotalsWidth = ctlArtTotals.Width; 

            return NewPage("Articles totals", 1, ctlArtTotals, ctlArtTotals.Width);
        }

        public void FindGenPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_CreatBatchDets ctlGen1 = (ctl_CreatBatchDets)page.Controls.Find("ctl_CreatBatchDets", true).FirstOrDefault();
                if (ctlGen1 != null)
                {
                    PlanBll.BatchId = _batchid;

                    ctlGen1.COrderId = PlanBll.BatchCOId;
                    ctlGen1.cmb_SalesOrdersWithLines1.SalesOrderLineId = PlanBll.BatchCOId;
                    ctlGen1.ArticleId = PlanBll.BatchArtId;
                    ctlGen1.fOldArticleId = PlanBll.BatchArtId;
                    ctlGen1.BatchId = _batchid;
                    ctlGen1.Batch = PlanBll.BatchName;
                    ctlGen1._EditMode = -1;
                    ctlGen1.QtyInBatch = PlanBll.BatchQty;
                    ctlGen1.fOldQtyInBatch = PlanBll.BatchQty;
                    ctlGen1.fOldComments = PlanBll.BatchComments;
                    ctlGen1.Comments = PlanBll.BatchComments;
                    ctlGen1.StartDate = PlanBll.BatchStartDate;
                    ctlGen1.fOldStartDate = PlanBll.BatchStartDate;
                    ctlGen1.fOldEndDate = PlanBll.EndDate;
                    ctlGen1.EndDate = PlanBll.EndDate;
                    ctlGen1.Urgent = PlanBll.Urgent;
                    ctlGen1.fOldUrgent = PlanBll.Urgent;
                    ctlCreatBatch.FillExistedLines(_batchid);
                    ctlGen1.FillDecNum();
                    ctlGen1.FillGridBatch(_batchid);
                    ctlGen1.SaveBatch += new SaveBatchEventHandler(SavedBatch);
                    //ctlGen1.CheckEmpty();
                }
                //break;
            }
        }

        public void FindRMPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BatchFreeze ctlFreeze1 = (ctl_BatchFreeze)page.Controls.Find("ctl_BatchFreeze", true).FirstOrDefault();

                if (ctlFreeze1 != null)
                    //ctlFreeze1.BatchId = _batchid;
                    ctlFreeze1.cmb_Batches1.BatchId = _batchid;
            }
        }

        public void FindCostPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_RMTracing ctlCost1 = (ctl_RMTracing)page.Controls.Find("ctl_RMTracing", true).FirstOrDefault();

                if (ctlCost1 != null)
                    ctlCost1.cmb_Batches1.BatchId = _batchid;
            }
        }

        public void FindQCPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_QCTracing ctlQCt1 = (ctl_QCTracing)page.Controls.Find("ctl_QCTracing", true).FirstOrDefault();

                if (ctlQCt1 != null)
                    ctlQCt1.BatchId = _batchid;
            }
        }

        public void FindLaunchesPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Launches ctlLaunches1 = (ctl_Launches)page.Controls.Find("ctl_Launches", true).FirstOrDefault();

                if (ctlLaunches1 != null)
                    ctlLaunches1.BatchId = _batchid;
                    //ctlLaunches1.gv_List.ThreadSafeCall(delegate { ctlBatchLaunches.SetCellsColor(); });
            }
        }


        public void FindArticlesRMPages(int _articleid, int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_RMFreeze ctlRMFreeze1 = (ctl_RMFreeze)page.Controls.Find("ctl_RMFreeze", true).FirstOrDefault();

                if (ctlRMFreeze1 != null)
                {
                    ctlRMFreeze1.cmb_Articles1.ArticleIdRec = _articleid;
                    ctlRMFreeze1.BatchId = _batchid;
                }
            }
        }

        public void FindPORMPages(int _articleid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_RMPoDistribute ctlPOReserve1 = (ctl_RMPoDistribute)page.Controls.Find("ctl_RMPoDistribute", true).FirstOrDefault();

                if (ctlPOReserve1 != null)
                    ctlPOReserve1.cmb_Articles1.ArticleId = _articleid;
            }
        }

        public void FindArticlesTotalPages(int _articleid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_ArtTotals ctlTotal1 = (ctl_ArtTotals)page.Controls.Find("ctl_ArtTotals", true).FirstOrDefault();

                if (ctlTotal1 != null)
                    ctlTotal1.cmb_Articles1.ArticleId = _articleid;
            }
        }

        public void FindBatchCOPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BatchOrders ctlBatchCO1 = (ctl_BatchOrders)page.Controls.Find("ctl_BatchOrders", true).FirstOrDefault();

                if (ctlBatchCO1 != null)
                    ctlBatchCO1.cmb_Batches1.BatchId = _batchid;
            }
        }

        public void FindBatchStockPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BatchStock ctlBatchStock1 = (ctl_BatchStock)page.Controls.Find("ctl_BatchStock", true).FirstOrDefault();

                if (ctlBatchStock1 != null)
                    ctlBatchStock1.cmb_Batches1.BatchId = _batchid;
            }
        }

        private bool CheckOldRow()
        {
            try
            {
                BatchId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                BatchId = 0;
            }

            if (_PrevId == BatchId)
                return true;
            else
            {
                _PrevId = BatchId;
                return false;
            }
        }

        public void ShowDetails(int _batchid)
        {
            FindGenPages(_batchid);
            FindRMPages(_batchid);
            FindBatchCOPages(_batchid);
            FindBatchStockPages(_batchid);
            //FindCostPages(_batchid);
            FindQCPages(_batchid);
            FindLaunchesPages(_batchid);
        }

        private void AddBatch(object sender)
        {
            frm.Close();
            bwStart(bw_List);

            BatchSaved?.Invoke(this);
        }

        private void GroupBatch(object sender)
        {
            frmg.Close();
            bwStart(bw_List);

            BatchSaved?.Invoke(this);
        }

        public void ShowEdit()
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_batchid != 0)
            {
                PlanBll.BatchId = _batchid;
                frm = new frm_AddBatchP();

                frm.ctl_CreatBatchDetsP1.ArticleId = PlanBll.BatchArtId;
                frm.ctl_CreatBatchDetsP1.fOldArticleId = PlanBll.BatchArtId;
                frm.ctl_CreatBatchDetsP1.BatchId = _batchid;
                frm.ctl_CreatBatchDetsP1.Batch = PlanBll.BatchName;
                frm.ctl_CreatBatchDetsP1._EditMode = -1;
                frm.ctl_CreatBatchDetsP1.QtyInBatch = PlanBll.BatchQty;
                frm.ctl_CreatBatchDetsP1.fOldQtyInBatch = PlanBll.BatchQty;
                frm.ctl_CreatBatchDetsP1.fOldComments = PlanBll.BatchComments;
                frm.ctl_CreatBatchDetsP1.Comments = PlanBll.BatchComments;
                frm.ctl_CreatBatchDetsP1.StartDate = PlanBll.BatchStartDate;
                frm.ctl_CreatBatchDetsP1.fOldStartDate = PlanBll.BatchStartDate;
                frm.ctl_CreatBatchDetsP1.fOldEndDate = PlanBll.EndDate;
                frm.ctl_CreatBatchDetsP1.Urgent = PlanBll.Urgent;
                frm.ctl_CreatBatchDetsP1.fOldUrgent = PlanBll.Urgent;
                frm.ctl_CreatBatchDetsP1.ProjectId = PlanBll.BatchProjectId;
                frm.ctl_CreatBatchDetsP1.Serials = PlanBll.BatchSerials;
                //frm.ctl_CreatBatchDetsP1.FillExistedLines(_batchid);
                frm.ctl_CreatBatchDetsP1.FillDecNum();
                //frm.ctl_CreatBatchDetsP1.FillGridBatch(_batchid);

                frm.BatchSaved += new BatchSavedPEventHandler(AddBatch);

                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        //private void ShowGenDetails(object sender)
        //{
        //    int _batchid = 0;

        //    try
        //    {
        //        _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

        //    }
        //    catch { }

        //    int _artid = ReceiveRMArtId();
        //    FindArticlesRMPages(_artid, _batchid);
        //    FindArticlesTotalPages(_artid);
        //    FindPORMPages(_artid);
        //    //Reg.ArtId = _artid;
        //    //FindArtPages(_artid);
        //    //FindCatPages(_artid);
        //}

        //private void ShowBatchRMDetails(object sender)
        //{
        //    int _batchid = BatchId;//ReceiveBatchId();

        //    FindRMPages(_batchid);
        //    int _artid = ReceiveRMArtId();
        //    FindArticlesTotalPages(_artid);

        //}        

        public void ShowPages(int artid, bool general, bool batchrm, bool artrm, bool totalart, bool poreservation)
        {
            int _artid = artid;
            int _batchid = BatchId;

            if (general == true)
            {
                FindGenPages(0);
                FindGenPages(_batchid);
            }
            if (batchrm == true)
            {
                FindRMPages(0);
                FindRMPages(_batchid);
            }
            if (artrm == true)
            {
                FindArticlesRMPages(0, 0);
                FindArticlesRMPages(_artid, _batchid);
            }
            if (totalart == true)
            {
                FindArticlesTotalPages(0);
                FindArticlesTotalPages(_artid);
            }
            if (poreservation == true)
            {
                FindPORMPages(0);
                FindPORMPages(_artid);
            }
        }

        #endregion

        #region Controls

        private void frm_Batches_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);

            ClearFilter();
        }

        //kryptonDockingManager1.AddDockspace("Control",
        //                                   DockingEdge.Left,
        //                                   new KryptonPage[] { NewInput() });

        private void btn_BatchRM_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatchRM(_batchid) });
        }

        private void btn_DistributeRM_Click(object sender, EventArgs e)
        {
            int _artid = 0;
            try
            {
                _artid = ReceiveRMArtId();
            }
            catch { }
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputArticle(_artid, _batchid) });
        }

        private void btn_Tracing_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatchRMCost(_batchid) });
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
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
            DAL.UserLogin = Environment.UserName;
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

        #endregion

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm = new frm_AddBatchP();
                        
            frm.ctl_CreatBatchDetsP1.FillAutoDoc();
            frm.ctl_CreatBatchDetsP1.FillDecNum();
            frm.ctl_CreatBatchDetsP1._EditMode = 0;
            frm.ctl_CreatBatchDetsP1.AllSpoil = 0;
            frm.ctl_CreatBatchDetsP1.FillDates();
            
            frm.BatchSaved += new BatchSavedPEventHandler(AddBatch);

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void btn_Copy_Click(object sender, EventArgs e) { }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _batchid != 0)
                try
                {
                    if (Convert.ToInt32(Helper.getSP("sp_DeleteBatch", _batchid)) == -1)
                    {
                        MessageBox.Show("Deletion of batch was succesfull!");
                        bwStart(bw_List);
                    }
                    else
                        MessageBox.Show("Error during batch deletion!");
                }
                catch { }
        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try {
            _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0
                && glob_Class.CloseConfirm() == true)
            {
                Helper.getSP("sp_CloseBatch", _id);
                bwStart(bw_List);
            }
        }

        private void btn_OpenBatch_Click(object sender, EventArgs e)
        {

            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && glob_Class.OpenConfirm() == true)
            {
                Helper.getSP("sp_OpenBatch", _id);
                bwStart(bw_List);
            }
        }

        private void frm_Batches_Resize(object sender, EventArgs e)
        {
            //this.Refresh();
            if (_Main.WindowState == FormWindowState.Maximized
                 )
            {
                kryptonDockableWorkspace1.Refresh();
                foreach (var page in kryptonDockingManager1.PagesDocked.OrderBy(d => d.PointToScreen(Point.Empty).X))
                {
                    ctl_BatchOrders ctlBatchCO1 = (ctl_BatchOrders)page.Controls.Find("ctl_BatchOrders", true).FirstOrDefault();
                    if (ctlBatchCO1 != null)
                    {
                        //ctlBatchCO1 = new ctl_BatchOrders();
                        ControlWidth = ctlBatchOrdersWidth;
                    }
                    ctl_BatchFreeze ctlFreeze1 = (ctl_BatchFreeze)page.Controls.Find("ctl_BatchFreeze", true).FirstOrDefault();
                    if (ctlFreeze1 != null)
                    {
                        //ctlFreeze1 = new ctl_BatchFreeze();
                        ControlWidth = ctlBatchRMWidth;//ctlFreeze1.Width;
                    }
                    ctl_CreatBatchDets ctlGen1 = (ctl_CreatBatchDets)page.Controls.Find("ctl_CreatBatchDets", true).FirstOrDefault();
                    if (ctlGen1 != null)
                    {
                        //ctlGen1 = new ctl_CreatBatchDets();
                        ControlWidth = ctlCreatBatchWidth;//ctlGen1.Width;
                    }
                    ctl_RMFreeze ctlRMFreeze1 = (ctl_RMFreeze)page.Controls.Find("ctl_RMFreeze", true).FirstOrDefault();
                    if (ctlRMFreeze1 != null)
                    {
                        //ctlRMFreeze1 = new ctl_RMFreeze();
                        ControlWidth = ctlArticlesRMWidth;//ctlRMFreeze1.Width;
                    }
                    ctl_RMPoDistribute ctlPOReserve1 = (ctl_RMPoDistribute)page.Controls.Find("ctl_RMPoDistribute", true).FirstOrDefault();
                    if (ctlPOReserve1 != null)
                    {
                        //ctlPOReserve1 = new ctl_RMPoDistribute();
                        ControlWidth = ctlPOreserveWidth;//ctlPOReserve1.Width;
                    }
                    ctl_ArtTotals ctlTotal1 = (ctl_ArtTotals)page.Controls.Find("ctl_ArtTotals", true).FirstOrDefault();
                    if (ctlTotal1 != null)
                    {
                        //ctlTotal1 = new ctl_ArtTotals();
                        ControlWidth = ctlArtTotalsWidth;//ctlTotal1.Width;
                    }
                    ctl_BatchStock ctlBatchStock1 = (ctl_BatchStock)page.Controls.Find("ctl_BatchStock", true).FirstOrDefault();
                    if (ctlBatchStock1 != null)
                    {
                        //ctlBatchCO1 = new ctl_BatchOrders();
                        ControlWidth = ctlBatchStockWidth;
                    }
                    ctl_QCTracing ctlQC1 = (ctl_QCTracing)page.Controls.Find("ctl_QCTracing", true).FirstOrDefault();
                    if (ctlQC1 != null)
                    {
                        //ctlBatchCO1 = new ctl_BatchOrders();
                        ControlWidth = ctlBatchQCTracingWidth;
                    }
                    ctl_Launches ctlLaunches1 = (ctl_Launches)page.Controls.Find("ctl_Launches", true).FirstOrDefault();
                    if (ctlQC1 != null)
                    {
                        //ctlBatchCO1 = new ctl_BatchOrders();
                        ControlWidth = ctlBatchLaunchesWidth;
                    }

                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });
                }
                //var pages = new List<KryptonPage>();
                //kryptonDockableWorkspace1.Refresh();
                //foreach (var page in kryptonDockingManager1.PagesDocked.OrderBy(d => d.PointToScreen(Point.Empty).X))
                //{

                //    pages.Add(page);
                //    //kryptonDockingManager1.RemovePage(page, false);
                //    //kryptonDockingManager1.AddDockspace("Control",
                //    //                           DockingEdge.Left,
                //    //                           new KryptonPage[] { page });

                //}
                //kryptonDockingManager1.RemoveAllPages(false);
                //foreach (KryptonPage page in pages)
                //{
                //    kryptonDockingManager1.AddDockspace("Control",
                //                               DockingEdge.Left,
                //                               new KryptonPage[] { page });
                //}
            }
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_StartFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny3_Click_1(object sender, EventArgs e)
        {
            txt_StartTill.Value = System.DateTime.Now;
        }

        private void buttonSpecAny2_Click_1(object sender, EventArgs e)
        {
            txt_EndFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny1_Click_1(object sender, EventArgs e)
        {
            txt_EndTill.Value = System.DateTime.Now;
        }

        private void btn_General_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputGeneral(_batchid) });
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
                ShowDetails(BatchId);
        }

        private void btn_Totals_Click(object sender, EventArgs e)
        {
            int _artid = 0;
            try
            {
                _artid = ReceiveRMArtId();
            }
            catch { }
            
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputTotal(_artid) });
        }

        private void btn_POReservation_Click(object sender, EventArgs e)
        {
            int _artid = 0;
            try
            {
                _artid = ReceiveRMArtId();
            }
            catch { }
            
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputPO(_artid) });
        }

        private void btn_BatchStock_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatchStock(_batchid) });
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatchCO(_batchid) });
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void txt_StartFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_StartFrom.Value = txt_StartFrom.Value == null ? System.DateTime.Now : txt_StartFrom.Value;
        }

        private void txt_StartTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_StartTill.Value = txt_StartTill.Value == null ? System.DateTime.Now : txt_StartTill.Value;
        }

        private void txt_EndFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_EndFrom.Value = txt_EndFrom.Value == null ? System.DateTime.Now : txt_EndFrom.Value;
        }

        private void txt_EndTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_EndTill.Value = txt_EndTill.Value == null ? System.DateTime.Now : txt_EndTill.Value;
        }

        private void btn_Passport_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_batchid != 0)
            {
                PlanBll.PasBatchId = _batchid;
                frm_rptPassportTitle frm = new frm_rptPassportTitle();
                frm.HeaderText = "Print pasport for: " + PlanBll.PasBatch;
                frm.Batch = PlanBll.PasBatch;
                frm.BatchId = _batchid;
                frm.Article = PlanBll.PasArticle;
                frm.CreatedAt = PlanBll.PasCreatedAt;
                frm.CreatedBy = Environment.UserName;//PlanBll.PasCreatedBy;
                frm.ValidatedBy = PlanBll.PasValidatedBy;
                frm.BatchStages = PlanBll.PasBatchStages;
                frm.CompanyOwner = PlanBll.PasCompany;
                frm.Address = PlanBll.PasAddress;
                frm.CustArticle = PlanBll.PasCustArticle;
                frm.COrder = PlanBll.PasConfOrder;
                frm.BatchComments = PlanBll.PasBatchComments;
                frm.OrderComments = PlanBll.PasOrderComments;
                frm.Internal = PlanBll.PasInternal.ToString();
                frm.OrderType = PlanBll.PasOrderType;
                frm.Quantity = PlanBll.PasQty.ToString();
                frm.OrderTypeId = PlanBll.PasOrderTypeId;
                frm.RepType = 1;

                frm.FillReport();

                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void btn_PrintRouteList_Click(object sender, EventArgs e)
        {
            frm_rptStockMove frm = new frm_rptStockMove();

            PlanBll.BatchId = BatchId;

            //Check for group
            //int _isgroup = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where groupid = " + BatchId));

            //if (_isgroup == 0)
            //{
                frm.HeadId = 0;
                frm.Batch = PlanBll.BatchName;
                frm.QtyInBatch = PlanBll.BatchQty;
                frm.ConfOrder = PlanBll.BatchConfOrder;
                frm.AssPerson = cmb_Users1.UserShortName;
                frm.Article = PlanBll.BatchArticle;
                frm.DocDate = "";
                frm.Unit = "";
                frm.Customer = PlanBll.BatchCustomer;
                frm.DocName = "";
                frm.SecArticle = PlanBll.BatchSecArticle;
                frm.BatchId = BatchId;
                frm.RepType = 3;
                frm.Serials = PlanBll.BatchSerials;
            //}
            //else
            //{
            //    frm.HeadId = 0;
            //    frm.Batch = PlanBll.BatchName;
            //    frm.QtyInBatch = PlanBll.BatchQty;
            //    frm.ConfOrder = PlanBll.BatchConfOrder;
            //    frm.AssPerson = cmb_Users1.UserShortName;
            //    frm.Article = PlanBll.BatchArticle;
            //    frm.DocDate = "";
            //    frm.Unit = "";
            //    frm.Customer = PlanBll.BatchCustomer;
            //    frm.DocName = "";
            //    frm.SecArticle = PlanBll.BatchSecArticle;
            //    frm.BatchId = BatchId;
            //    frm.RepType = 8;
            //    frm.Serials = PlanBll.BatchSerials;
            //}
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_QCTracing_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatchQCTracing(_batchid) });
        }

        private void btn_RMDeficite_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            string _batch = "";

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString();
            }
            catch { }

            var _query = "sp_SelectBatchRMDeficite";

            var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@batchid",SqlDbType.Int) {Value = _batchid}
                };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "RM deficite for " + _batch ;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Launches_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            KryptonPage page = NewInputBatchLaunches(_batchid);

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { /*NewInputBatchLaunches(_batchid) */page});

            ctl_Launches ctlLaunches1 = (ctl_Launches)page.Controls.Find("ctl_Launches", true).FirstOrDefault();
        }

        private void btn_Block_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            int _blocked = 0;
            string _title = "Batch blocking warning!";
            string _message = "";
            string _instruction = "";
            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _blocked = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_blocked"].Value);
            }
            catch { }

            if (_blocked == 0)
            {
                _message = "Are you sure you want block batch?";
                _instruction = "It will not be possible to create launch!";
            }
            else
            {
                _message = "Are you sure you want unblock batch?";
                _instruction = "";
            }

            if (_batchid != 0
                && glob_Class.ConfirmMessage(_title, _instruction, _message) == true)
            {
                Helper.getSP("sp_BlockBatch", _batchid);
                bwStart(bw_List);
            }            
        }

        private void btn_Grouping_Click(object sender, EventArgs e)
        {
            frmg = new frm_BatchGrouping();
            frmg.BatchGrouped += new BatchGroupingEventHandler(GroupBatch);
            frmg.Show();
        }
    }
}