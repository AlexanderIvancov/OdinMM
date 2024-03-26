using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Planning
{
    public delegate void LaunchSaving1EventHandler(object sender);

    public partial class frm_Launches : BaseForm
    {
        public frm_Launches()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "LaunchesList.xls", this.Name);
        }

        #region Variabes

        public event LaunchSaving1EventHandler LaunchSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        frm_AddLaunch frm = null;
        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int ControlWidth = 250;
        public int IsActive
        {
            get { return chk_Active.CheckState == CheckState.Checked ? -1 : chk_Active.CheckState == CheckState.Unchecked ? 0 : 1; }
            set { chk_Active.CheckState = value == -1 ? CheckState.Checked : value == 0 ? CheckState.Unchecked : CheckState.Indeterminate; }
        }

        #endregion

        #region Methods

        public void ClearFilter()
        {
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;

            cmb_Types1.TypeId = 0;
            
            cmb_Articles1.ArticleId = 0;

            txt_StartFrom.Value = null;
            txt_StartTill.Value = null;
        }

        public void SetCellsColor()
        {
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_complected"].Value) != 0)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.LightGray;
            //    if (Convert.ToInt32(row.Cells["chk_isactive"].Value) == 0)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.Gainsboro;

            //}
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(cmb_SalesOrdersWithLines1.SalesOrderLineId.ToString());
            var data = (DataTable)Helper.getSP("sp_LaunchesList", cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, IsActive,
                                            cmb_Types1.TypeId, txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                            txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim());

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

        private void AddLaunch(object sender)
        {
            frm.Close();
            bwStart(bw_List);

            LaunchSaved?.Invoke(this);
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
                Helper.LoadColumns(gv_List, this.Name);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        #endregion

        private void frm_Launches_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            Helper.LoadColumns(gv_List, this.Name);

            ClearFilter();
        }

        private void frm_Launches_Resize(object sender, EventArgs e)
        {
            if (_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    //ctl_BatchOrders ctlBatchCO1 = (ctl_BatchOrders)page.Controls.Find("ctl_BatchOrders", true).FirstOrDefault();
                    //if (ctlBatchCO1 != null)
                    //{
                    //    //ctlBatchCO1 = new ctl_BatchOrders();
                    //    ControlWidth = ctlBatchOrdersWidth;
                    //}
                    //ctl_BatchFreeze ctlFreeze1 = (ctl_BatchFreeze)page.Controls.Find("ctl_BatchFreeze", true).FirstOrDefault();
                    //if (ctlFreeze1 != null)
                    //{
                    //    //ctlFreeze1 = new ctl_BatchFreeze();
                    //    ControlWidth = ctlBatchRMWidth;//ctlFreeze1.Width;
                    //}
                    //ctl_CreatBatchDets ctlGen1 = (ctl_CreatBatchDets)page.Controls.Find("ctl_CreatBatchDets", true).FirstOrDefault();
                    //if (ctlGen1 != null)
                    //{
                    //    //ctlGen1 = new ctl_CreatBatchDets();
                    //    ControlWidth = ctlCreatBatchWidth;//ctlGen1.Width;
                    //}
                    //ctl_RMFreeze ctlRMFreeze1 = (ctl_RMFreeze)page.Controls.Find("ctl_RMFreeze", true).FirstOrDefault();
                    //if (ctlRMFreeze1 != null)
                    //{
                    //    //ctlRMFreeze1 = new ctl_RMFreeze();
                    //    ControlWidth = ctlArticlesRMWidth;//ctlRMFreeze1.Width;
                    //}
                    //ctl_RMPoDistribute ctlPOReserve1 = (ctl_RMPoDistribute)page.Controls.Find("ctl_RMPoDistribute", true).FirstOrDefault();
                    //if (ctlPOReserve1 != null)
                    //{
                    //    //ctlPOReserve1 = new ctl_RMPoDistribute();
                    //    ControlWidth = ctlPOreserveWidth;//ctlPOReserve1.Width;
                    //}
                    //ctl_ArtTotals ctlTotal1 = (ctl_ArtTotals)page.Controls.Find("ctl_ArtTotals", true).FirstOrDefault();
                    //if (ctlTotal1 != null)
                    //{
                    //    //ctlTotal1 = new ctl_ArtTotals();
                    //    ControlWidth = ctlArtTotalsWidth;//ctlTotal1.Width;
                    //}

                    //ctl_BatchStock ctlBatchStock1 = (ctl_BatchStock)page.Controls.Find("ctl_BatchStock", true).FirstOrDefault();
                    //if (ctlBatchStock1 != null)
                    //{
                    //    //ctlBatchCO1 = new ctl_BatchOrders();
                    //    ControlWidth = ctlBatchStockWidth;
                    //}

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


        #endregion

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm = new frm_AddLaunch();
                       
            frm.ctl_CreatLaunchDets1.FillDecNum();
            frm.ctl_CreatLaunchDets1.Mode = "new";
            //frm.ctl_CreatBatchDets1.AllSpoil = 0;
            //frm.ctl_CreatBatchDets1.FillGridNew(frm.ctl_CreatBatchDets1.ArticleId, frm.ctl_CreatBatchDets1.QtyInBatch);
            frm.ctl_CreatLaunchDets1.FillDates();

            frm.LaunchSaved += new LaunchSavedEventHandler(AddLaunch);

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Edit_Click(object sender, EventArgs e) { }

        private void btn_Delete_Click(object sender, EventArgs e) { }
    }
}