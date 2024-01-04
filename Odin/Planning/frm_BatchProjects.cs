using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Planning.Controls;
using Odin.Sales;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Planning
{
    public delegate void BatchProjectSavingEventHandler(object sender);

    public partial class frm_BatchProjects : BaseForm
    {
        public frm_BatchProjects()
        {
            InitializeComponent();
        }

        #region Variables
        public event BatchProjectSavingEventHandler BatchProjectSaved;
        public static event ReceiveRMId ReceiveRMArtId;

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

        public ctl_CreatBatchProjectDets ctlCreatBatch = null;
        public ctl_BatchFreeze ctlBatchRM = null;
        public ctl_RMFreeze ctlArticlesRM = null;
        public ctl_ArtTotals ctlArtTotals = null;
        public ctl_RMPoDistribute ctlPOreserve = null;
        public ctl_BatchOrders ctlBatchOrders = null;
        public ctl_RMTracing ctlBatchRMCost = null;
        public ctl_BatchStock ctlBatchStock = null;
        public ctl_QCTracing ctlBatchQCTracing = null;
        public ctl_Launches ctlBatchLaunches = null;
        public ctl_Batches ctlBatches = null;

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
        
        public int ProjectId
        { get; set; }

        int _PrevId = 0;

        public int IsActive
        {
            get
            {
                return chk_Active.CheckState == CheckState.Checked ? -1 : chk_Active.CheckState == CheckState.Unchecked ? 0 : 1;
            }
            set
            {
                chk_Active.CheckState = value == -1 ? CheckState.Checked : value == 0 ? CheckState.Unchecked : CheckState.Indeterminate;
            }
        }

        frm_AddBatchProject frm;
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

        private KryptonPage NewInputBatchRM(int _batchid)
        {

            ctlBatchRM = new ctl_BatchFreeze();
            ctlBatchRM.cmb_Batches1.BatchId = _batchid;
            ctlBatchRM.cmb_Batches1.IsProject = -1;
            //ctlCreatBatch.SaveBatch += new SaveBatchEventHandler(SavedBatch);
            ctlBatchRM.SendArtId += new RMIdSendingEventHandler(ShowPages);

            ControlWidth = ctlBatchRM.Width;
            ctlBatchRMWidth = ctlBatchRM.Width;

            return NewPage("Batch RM reservation", 1, ctlBatchRM, ctlBatchRM.Width);
        }

        private KryptonPage NewInputArticle(int _artid, int _projectid)
        {
            ctlArticlesRM = new ctl_RMFreeze();
            ctlArticlesRM.cmb_Articles1.ArticleIdRec = _artid;
            ctlArticlesRM.BatchId = _projectid;
            //ctlArticlesRM.SendBatchId += new BatchIdSendingEventHandler(ShowBatchRMDetails);
            ctlArticlesRM.SendArtId += new ArtIdSendingEventHandler(ShowPages);

            ControlWidth = ctlArticlesRM.Width;
            ctlArticlesRMWidth = ctlArticlesRM.Width;

            return NewPage("Articles reservation", 1, ctlArticlesRM, ctlArticlesRM.Width);
        }

        private KryptonPage NewInputTotal(int _artid)
        {
            ctlArtTotals = new ctl_ArtTotals();
            ctlArtTotals.cmb_Articles1.ArticleId = _artid;

            ControlWidth = ctlArtTotals.Width;
            ctlArtTotalsWidth = ctlArtTotals.Width;

            return NewPage("Articles totals", 1, ctlArtTotals, ctlArtTotals.Width);
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

        private KryptonPage NewInputGeneral(int _projectid)
        {

            PlanBll.BatchId = _projectid;

            ctlCreatBatch = new ctl_CreatBatchProjectDets();
            ctlCreatBatchWidth = ctlCreatBatch.Width;

            ctlCreatBatch.SalesOrderId = PlanBll.BatchCOId;
            ctlCreatBatch.Customer = PlanBll.BatchCustomer;
            ctlCreatBatch.ArticleId = PlanBll.BatchArtId;
            ctlCreatBatch.fOldArticleId = PlanBll.BatchArtId;
            ctlCreatBatch.BatchId = _projectid;
            ctlCreatBatch.Batch = PlanBll.BatchName;
            ctlCreatBatch._EditMode = -1;
            ctlCreatBatch.QtyInBatch = PlanBll.BatchQty;
            ctlCreatBatch.fOldQtyInBatch = PlanBll.BatchQty;
            ctlCreatBatch.fOldComments = PlanBll.BatchComments;
            ctlCreatBatch.Comments = PlanBll.BatchComments;
            ctlCreatBatch.fOldStartDate = PlanBll.BatchStartDate;
            ctlCreatBatch.fOldEndDate = PlanBll.EndDate;
            ctlCreatBatch.fOldUrgent = PlanBll.Urgent;
            
            ctlCreatBatch.FillDecNum();
            ctlCreatBatch.FillGridBatch(_projectid);

            ctlCreatBatch.SaveBatch += new SaveBatchProjectEventHandler(SaveProject);//new SaveBatchProjectEventHandler(SavedProject);

            ControlWidth = ctlCreatBatch.Width;
            ctlCreatBatchWidth = ctlCreatBatch.Width;

            return NewPage("Project dets", 1, ctlCreatBatch, ctlCreatBatch.Width);
        }

        private KryptonPage NewInputBatch(int _COId)
        {
            ctlBatches = new ctl_Batches();
            ControlWidth = ctlBatches.Width;

            ctlBatches.cmb_SalesOrdersWithLines1.SalesOrderLineId = _COId;
            //ctlBatches.ArticleId = COBll.COArtId;
            //ctlBatches.QtyInCO = COBll.COQty;
            //if (COBll.COReqDate != null)
            //    ctlBatches.ResDate = Convert.ToDateTime(COBll.COReqDate).AddDays(-14).ToShortDateString();
            //ctlBatches.EndDate = COBll.COReqDate;
            //ctlBatches.Customer = COBll.COCustomer;
            ctlBatches.BatchChanged += new BatchChangingEventHandler(ChangeCOIdSelection);

            return NewPage("Batches ", 1, ctlBatches, ctlBatches.Width);
        }

        private KryptonPage NewInputBatchCO(int _batchid)
        {

            ctlBatchOrders = new ctl_BatchOrders();
            ctlBatchOrders.cmb_Batches1.BatchId = _batchid;

            ControlWidth = ctlBatchOrders.Width;
            ctlBatchOrdersWidth = ctlBatchOrders.Width;

            return NewPage("Confirmation orders for batch", 1, ctlBatchOrders, ctlBatchOrders.Width);
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

        private bool CheckOldRow()
        {

            try
            {
                ProjectId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                ProjectId = 0;
            }

            if (_PrevId == ProjectId)
            {
                return true;
            }
            else
            {
                _PrevId = ProjectId;
                return false;
            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            //MessageBox.Show(cmb_SalesOrdersWithLines1.SalesOrderLineId.ToString());
            var data = Plan_BLL.getBatchProjects(cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, IsActive,
                                            cmb_Types1.TypeId, cmb_Department1.DeptId, txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                            txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim(),
                                            txt_EndFrom.Value == null ? "" : txt_EndFrom.Value.ToString().Trim(),
                                            txt_EndTill.Value == null ? "" : txt_EndTill.Value.ToString().Trim(),
                                            chk_ShowBatches.Checked == true? -1:0, cmb_Firms1.FirmId);


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

        private void ChangeCOIdSelection(object sender)
        {
            //bwStart(bw_List);
        }
        private void AddBatchProject(object sender)
        {
            frm.Close();
            bwStart(bw_List);

            BatchProjectSaved?.Invoke(this);
        }

        private void SaveProject(object sender)
        {
            BatchProjectSaved?.Invoke(this);
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


                frm = new frm_AddBatchProject();

                frm.ctl_CreatBatchProjectDets1.SalesOrderId = PlanBll.BatchCOId;
                frm.ctl_CreatBatchProjectDets1.Customer = PlanBll.BatchCustomer;
                frm.ctl_CreatBatchProjectDets1.ArticleId = PlanBll.BatchArtId;
                frm.ctl_CreatBatchProjectDets1.fOldArticleId = PlanBll.BatchArtId;
                frm.ctl_CreatBatchProjectDets1.BatchId = _batchid;
                frm.ctl_CreatBatchProjectDets1.Batch = PlanBll.BatchName;
                frm.ctl_CreatBatchProjectDets1._EditMode = -1;
                frm.ctl_CreatBatchProjectDets1.QtyInBatch = PlanBll.BatchQty;
                frm.ctl_CreatBatchProjectDets1.fOldQtyInBatch = PlanBll.BatchQty;
                frm.ctl_CreatBatchProjectDets1.fOldComments = PlanBll.BatchComments;
                frm.ctl_CreatBatchProjectDets1.Comments = PlanBll.BatchComments;
                frm.ctl_CreatBatchProjectDets1.StartDate = PlanBll.BatchStartDate;
                frm.ctl_CreatBatchProjectDets1.fOldStartDate = PlanBll.BatchStartDate;
                frm.ctl_CreatBatchProjectDets1.QuotId = PlanBll.BatchQuotId;
                frm.ctl_CreatBatchProjectDets1.FillDecNum();
                frm.ctl_CreatBatchProjectDets1.FillGridBatch(_batchid);

                frm.ProjectSaved += new BatchProjectSavedEventHandler(AddBatchProject);

                frm.Show(); frm.GetKryptonFormFields();
            }

        }

        public void ShowPages(int artid, bool general, bool batchrm, bool artrm, bool totalart, bool poreservation)
        {
            int _artid = artid;
            int _batchid = ProjectId;

            int _coid = 0;

            try
            {
                _coid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_coid"].Value);
            }
            catch { }

            FindBatchPages(_coid);

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

        public void FindRMPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BatchFreeze ctlFreeze1 = (ctl_BatchFreeze)page.Controls.Find("ctl_BatchFreeze", true).FirstOrDefault();

                if (ctlFreeze1 != null)
                {
                    //ctlFreeze1.BatchId = _batchid;
                    ctlFreeze1.cmb_Batches1.BatchId = _batchid;
                }
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

        public void FindArticlesTotalPages(int _articleid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_ArtTotals ctlTotal1 = (ctl_ArtTotals)page.Controls.Find("ctl_ArtTotals", true).FirstOrDefault();

                if (ctlTotal1 != null)
                {
                    ctlTotal1.cmb_Articles1.ArticleId = _articleid;
                }
            }
        }
        public void FindPORMPages(int _articleid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_RMPoDistribute ctlPOReserve1 = (ctl_RMPoDistribute)page.Controls.Find("ctl_RMPoDistribute", true).FirstOrDefault();

                if (ctlPOReserve1 != null)
                {
                    ctlPOReserve1.cmb_Articles1.ArticleId = _articleid;
                }
            }
        }

        public void FindGenPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_CreatBatchProjectDets ctlGen1 = (ctl_CreatBatchProjectDets)page.Controls.Find("ctl_CreatBatchDets", true).FirstOrDefault();
                if (ctlGen1 != null)
                {

                    PlanBll.BatchId = _batchid;


                    ctlGen1.SalesOrderId = PlanBll.BatchCOId;
                    ctlGen1.Customer = PlanBll.BatchCustomer;
                    ctlGen1.ArticleId = PlanBll.BatchArtId;
                    ctlGen1.fOldArticleId = PlanBll.BatchArtId;
                    ctlGen1.BatchId = _batchid;
                    ctlGen1.Batch = PlanBll.BatchName;
                    ctlGen1._EditMode = -1;
                    ctlGen1.QtyInBatch = PlanBll.BatchQty;
                    ctlGen1.fOldQtyInBatch = PlanBll.BatchQty;
                    ctlGen1.fOldComments = PlanBll.BatchComments;
                    ctlGen1.Comments = PlanBll.BatchComments;
                    
                    ctlGen1.fOldStartDate = PlanBll.BatchStartDate;
                    ctlGen1.fOldEndDate = PlanBll.EndDate;
                    ctlGen1.fOldUrgent = PlanBll.Urgent;
                    
                    ctlGen1.FillDecNum();
                    ctlGen1.FillGridBatch(_batchid);

                    ctlGen1.SaveBatch += new SaveBatchProjectEventHandler(SaveProject);
                    //ctlGen1.CheckEmpty();
                }
                //break;
            }
        }

        public void FindBatchPages(int coid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Batches ctlBatch1 = (ctl_Batches)page.Controls.Find("ctl_Batches", true).FirstOrDefault();
                if (ctlBatch1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlBatch1.cmb_SalesOrdersWithLines1.SalesOrderLineId = coid;
                    //ctlBatch1.ArticleId = COBll.COArtId;
                    //ctlBatch1.QtyInCO = COBll.COQty;
                    //ctlBatch1.ResDate = Convert.ToDateTime(COBll.COReqDate).AddDays(-14).ToShortDateString();
                    //ctlBatch1.EndDate = COBll.COReqDate;
                    //ctlBatch1.Customer = COBll.COCustomer;


                    //ctlConf11.COId = coid;
                }
                //break;
            }
        }

        public void FindBatchCOPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BatchOrders ctlBatchCO1 = (ctl_BatchOrders)page.Controls.Find("ctl_BatchOrders", true).FirstOrDefault();

                if (ctlBatchCO1 != null)
                {
                    ctlBatchCO1.cmb_Batches1.BatchId = _batchid;
                }
            }
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

            frm.HeaderText = "Select view for project list";
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

        private void frm_BatchProjects_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);

            ClearFilter();
        }

        private void frm_BatchProjects_Resize(object sender, EventArgs e)
        {
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
                    ctl_CreatBatchProjectDets ctlGen1 = (ctl_CreatBatchProjectDets)page.Controls.Find("ctl_CreatBatchDets", true).FirstOrDefault();
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
            }
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(ProjectId);
            }
        }

        public void ShowDetails(int _projectid)
        {
            int _coid = 0;

            try
            {
                _coid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_coid"].Value);
            }
            catch { }

            FindBatchPages(_coid);

            FindGenPages(_projectid);
            FindRMPages(_projectid);
            FindBatchCOPages(_projectid);
            //FindBatchCOPages(_batchid);
            //FindBatchStockPages(_batchid);
            //FindQCPages(_batchid);
            //FindLaunchesPages(_batchid);
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
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

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm = new frm_AddBatchProject();

            frm.ctl_CreatBatchProjectDets1.FillAutoDoc();
            frm.ctl_CreatBatchProjectDets1.FillDecNum();
            frm.ctl_CreatBatchProjectDets1._EditMode = 0;
            frm.ctl_CreatBatchProjectDets1.AllSpoil = 0;
            frm.ctl_CreatBatchProjectDets1.FillGridNew(frm.ctl_CreatBatchProjectDets1.ArticleId, frm.ctl_CreatBatchProjectDets1.QtyInBatch);
            frm.ctl_CreatBatchProjectDets1.FillDates();


            frm.ProjectSaved += new BatchProjectSavedEventHandler(AddBatchProject);

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

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
            {
                try
                {
                    if (PlanBll.DeleteBatch(_batchid) == -1)
                    {
                        MessageBox.Show("Deletion of project was succesfull!");

                        bwStart(bw_List);
                    }
                    else
                        MessageBox.Show("Error during project deletion!");

                }

                catch { }
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }
        private void btn_Block_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            int _blocked = 0;
            string _title = "Project blocking warning!";
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
                _message = "Are you sure you want block project?";
            }
            else
            {
                _message = "Are you sure you want unblock batch?";
                _instruction = "";
            }

            if (_batchid != 0
                && glob_Class.ConfirmMessage(_title, _instruction, _message) == true)
            {
                PlanBll.BlockBatch(_batchid);
                bwStart(bw_List);
            }
        }


        private void btn_Active_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0
                && glob_Class.CloseConfirmProject() == true)
            {
                PlanBll.CloseBatchProject(_id);
                bwStart(bw_List);
            }
        }

        private void btn_BatchRM_Click(object sender, EventArgs e)
        {
            int _project = 0;

            try
            {
                _project = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }


            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatchRM(_project) });
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
        #endregion

        private void btn_General_Click(object sender, EventArgs e)
        {

            int _projectid = 0;

            try
            {
                _projectid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }


            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputGeneral(_projectid) });
        }

        private void btn_Batches_Click(object sender, EventArgs e)
        {
            int _coid = 0;

            try
            {
                _coid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_coid"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatch(_coid) });
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

        private void btn_ToFollow_Click(object sender, EventArgs e)
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
                string strMessage = PlanBll.BatchToFollow == 0 ? "You want to follow up the project?" : "You want to unfollow up the project?";
                if (glob_Class.MessageConfirm("Following project warning", strMessage) == true)
                {
                    PlanBll.FollowBatchProject(_batchid, (PlanBll.BatchToFollow == 0 ? -1 : 0));
                    bwStart(bw_List);
                }

            }
        }
    }
}
