using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Odin.Global_Classes;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using System.Data.SqlClient;
using Odin.Tools;
using Odin.Register;
using Odin.Planning.Controls;

namespace Odin.Workshop
{
    public partial class frm_Processing : BaseForm
    {
        public frm_Processing()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ProcessingDets.xls",this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Processing_BLL ProcBll = new Processing_BLL();
        Reg_BLL RegBll = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();

        public int ControlWidth = 250;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int IsActive
        {
            get
            {
                if (chk_Active.CheckState == CheckState.Checked)
                    return -1;
                else if (chk_Active.CheckState == CheckState.Unchecked)
                    return 0;
                else
                    return 1;
            }
            set
            {
                if (value == -1)
                    chk_Active.CheckState = CheckState.Checked;
                else if (value == 0)
                    chk_Active.CheckState = CheckState.Unchecked;
                else
                    chk_Active.CheckState = CheckState.Indeterminate;
            }
        }

        public int Processing
        {
            get
            {
                if (chk_Processing.CheckState == CheckState.Checked)
                    return -1;
                else if (chk_Processing.CheckState == CheckState.Unchecked)
                    return 0;
                else
                    return 1;
            }
            set
            {
                if (value == -1)
                    chk_Processing.CheckState = CheckState.Checked;
                else if (value == 0)
                    chk_Processing.CheckState = CheckState.Unchecked;
                else
                    chk_Processing.CheckState = CheckState.Indeterminate;
            }
        }

        int _batchid = 0;
        public int BatchId
        {
            get { return _batchid; }
            set { _batchid = value;}
        }

        public int _PrevId = 0;

        public ctl_Process ctlProc = null;
        public ctl_ProcessHistory ctlProcHis = null;
        public ctl_ProcessHistoryOnDate ctlProcHisOnDate = null;
        public ctl_Launches ctlBatchLaunches = null;
        public ctl_LaunchProcess ctlLaunchProc = null;
        public int ctlBatchLaunchesWidth = 0;

        public int StageId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }

        public string FilterProcessing
        {
            get {
                if (Processing == -1)
                    return "(Convert(SMT, 'System.String') <> '0' OR " +
                            "Convert(QC_SMT, 'System.String') <> '0' OR " +
                            "Convert(THT, 'System.String') <> '0' OR " +
                            "Convert(QC_THT, 'System.String') <> '0' OR " +
                            "Convert(FTA, 'System.String') <> '0' OR " +
                            "Convert(FQC, 'System.String') <> '0' OR " +
                            "Convert(IPA, 'System.String') <> '0' OR " +
                            "Convert(FCS, 'System.String') <> '0')";
                else if
                   (Processing == 0)
                    return "NOT(Convert(SMT, 'System.String') <> '0' OR " +
                            "Convert(QC_SMT, 'System.String') <> '0' OR " +
                            "Convert(THT, 'System.String') <> '0' OR " +
                            "Convert(QC_THT, 'System.String') <> '0' OR " +
                            "Convert(FTA, 'System.String') <> '0' OR " +
                            "Convert(FQC, 'System.String') <> '0' OR " +
                            "Convert(IPA, 'System.String') <> '0' OR " +
                            "Convert(FCS, 'System.String') <> '0')";
                else
                    return "'A' = 'A'";
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

        public void ClearFilter()
        {
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Department1.DeptId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            txt_FirmArt.Text = string.Empty;
            txt_StartFrom.Value = null; 
            txt_StartTill.Value = null; 
            txt_EndFrom.Value = null; 
            txt_EndTill.Value = null;
            txt_CustOrder.Text = string.Empty;
            StageId = 0;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_SMT"].Value) > 0
                    || Convert.ToDouble(row.Cells["cn_QC_SMT"].Value) > 0
                    || Convert.ToDouble(row.Cells["cn_THT"].Value) > 0
                    || Convert.ToDouble(row.Cells["cn_QC_THT"].Value) > 0
                    || Convert.ToDouble(row.Cells["cn_FTA"].Value) > 0
                    || Convert.ToDouble(row.Cells["cn_QC_FTA"].Value) > 0
                    || Convert.ToDouble(row.Cells["cn_IPA"].Value) > 0
                    || Convert.ToDouble(row.Cells["cn_FCS"].Value) > 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);    
                if (Convert.ToDouble(row.Cells["cn_FCS"].Value) >= Convert.ToDouble(row.Cells["cn_qty"].Value)
                    || Convert.ToInt32(row.Cells["chk_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Gainsboro;//Color.FromArgb(192, 255, 192);
                if (Convert.ToInt32(row.Cells["cn_isprimary"].Value) == -1) //New
                {
                    row.Cells["cn_conforder"].Style.BackColor = Color.Orange;
                    row.Cells["cn_batch"].Style.BackColor = Color.Orange;
                }
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
            {
                return true;
            }
            else
            {
                _PrevId = BatchId;
                return false;
            }
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

        private KryptonPage NewInputProcess(int _batchid)
        {
            ctlProc = new ctl_Process();

            ctlProc.cmb_Batches1.BatchId = _batchid;
            ControlWidth = ctlProc.Width;
            //ctlGen.CheckEmpty();
            ctlProc.StageUpdating += new StageUpdatingEventHandler(RefreshData);

            return NewPage("Processing", 1, ctlProc, ctlProc.Width);
        }

        private KryptonPage NewInputLaunchProcess(int _batchid)
        {
            ctlLaunchProc = new ctl_LaunchProcess();

            ctlLaunchProc.cmb_Batches1.BatchId = _batchid;
            ControlWidth = ctlLaunchProc.Width;
            //ctlGen.CheckEmpty();
            ctlLaunchProc.StageUpdating += new LaunchStageUpdatingEventHandler(RefreshData);

            return NewPage("Launch processing", 1, ctlLaunchProc, ctlLaunchProc.Width);
        }

        private KryptonPage NewInputHistory(int _batchid)
        {
            ctlProcHis = new ctl_ProcessHistory();

            ctlProcHis.cmb_Batches1.BatchId = _batchid;
            ControlWidth = ctlProcHis.Width;
          
            //ctlGen.CheckEmpty();


            return NewPage("Processing history", 1, ctlProcHis, ctlProcHis.Width);
        }

        private KryptonPage NewInputHistoryOnDate()
        {
            ctlProcHisOnDate = new ctl_ProcessHistoryOnDate();

            ControlWidth = ctlProcHisOnDate.Width;

            //ctlGen.CheckEmpty();


            return NewPage("Processing history on date", 1, ctlProcHisOnDate, ctlProcHisOnDate.Width);
        }

        private KryptonPage NewInputBatchLaunches(int _batchid)
        {

            ctlBatchLaunches = new ctl_Launches();
            ctlBatchLaunches.BatchId = _batchid;

            ControlWidth = ctlBatchLaunches.Width;
            ctlBatchLaunchesWidth = ctlBatchLaunches.Width;

            return NewPage("Batch launches", 1, ctlBatchLaunches, ctlBatchLaunches.Width);
        }
        public void bw_List(object sender, DoWorkEventArgs e)
        {
            bs_List.RemoveFilter();

            var data = Processing_BLL.getStages(cmb_Batches1.BatchId, cmb_Articles1.ArticleId, StageId, cmb_SalesOrdersWithLines1.SalesOrderLineId, IsActive,
                                            cmb_Types1.TypeId, cmb_Department1.DeptId, txt_FirmArt.Text, txt_CustOrder.Text, 
                                            txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                            txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim(),
                                            txt_EndFrom.Value == null ? "" : txt_EndFrom.Value.ToString().Trim(),
                                            txt_EndTill.Value == null ? "" : txt_EndTill.Value.ToString().Trim(),
                                            cmb_Firms1.FirmId);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                if (cmb_Batches1.BatchId == 0)
                    bs_List.Filter = FilterProcessing;

                SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

        }

        public void ShowDetails(int _batchid)
        {
            FindProcessPages(_batchid);
            FindProcessHistoryPages(_batchid);
            FindLaunchesPages(_batchid);
            FindLaunchProcessPages(_batchid);
        }

        public void FindProcessPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Process ctlProc1 = (ctl_Process)page.Controls.Find("ctl_Process", true).FirstOrDefault();

                if (ctlProc1 != null)
                {
                    ctlProc1.cmb_Batches1.BatchId = _batchid;
                }
            }
        }
        public void FindLaunchProcessPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_LaunchProcess ctlProc1 = (ctl_LaunchProcess)page.Controls.Find("ctl_LaunchProcess", true).FirstOrDefault();

                if (ctlProc1 != null)
                {
                    ctlProc1.cmb_Batches1.BatchId = _batchid;
                }
            }
        }

        public void FindLaunchesPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Launches ctlLaunches1 = (ctl_Launches)page.Controls.Find("ctl_Launches", true).FirstOrDefault();

                if (ctlLaunches1 != null)
                {
                    ctlLaunches1.BatchId = _batchid;
                }
            }
        }
        public void FindProcessHistoryPages(int _batchid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_ProcessHistory ctlProc1 = (ctl_ProcessHistory)page.Controls.Find("ctl_ProcessHistory", true).FirstOrDefault();

                if (ctlProc1 != null)
                {
                    ctlProc1.cmb_Batches1.BatchId = _batchid;
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
                bs_List.Filter = FilterProcessing + (" AND Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
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
                bs_List.Filter = FilterProcessing;
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void frm_Processing_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(/*kryptonSplitContainer1.Panel2*/kryptonPanel3, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            txt_StartFrom.Value = null;
            txt_StartTill.Value = null;
            txt_EndFrom.Value = null;
            txt_EndTill.Value = null;

            //kryptonDockingManager1.AddDockspace("Control",
            //                                DockingEdge.Left,
            //                                new KryptonPage[] { NewInputLaunchProcess(0) });
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void frm_Processing_Resize(object sender, EventArgs e)
        {
           
            if (_Main.WindowState == FormWindowState.Maximized
                /*|| _Main.WindowState == FormWindowState.Normal*/)
            {
                var pages = new List<KryptonPage>();
                kryptonDockableWorkspace1.Refresh();
                foreach (var page in kryptonDockingManager1.PagesDocked.OrderBy(d => d.PointToScreen(Point.Empty).X))
                {

                    pages.Add(page);
                    //kryptonDockingManager1.RemovePage(page, false);
                    //kryptonDockingManager1.AddDockspace("Control",
                    //                           DockingEdge.Left,
                    //                           new KryptonPage[] { page });

                }
                kryptonDockingManager1.RemoveAllPages(false);
                foreach (KryptonPage page in pages)
                {
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });
                }
                //kryptonPanel3.Refresh();
            }
        }


        private void btn_Process_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputProcess(BatchId) });
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputProcess(BatchId) });
        }


        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_StartFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_StartTill.Value = System.DateTime.Now;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_EndTill.Value = System.DateTime.Now;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_EndFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_CustOrder.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_FirmArt.Text = string.Empty;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        private void RefreshData(object sender)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(BatchId);
            }
        }


        private void btn_History_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputHistory(BatchId) });
        }

        #endregion

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {

        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //kryptonDockingManager1.AddDockspace("Control",
            //                                DockingEdge.Left,
            //                                new KryptonPage[] { NewInputProcess(BatchId) });
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

        private void btn_OnDate_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputHistoryOnDate() });
        }

        private void btn_FreezeHistory_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            string _batch = "";
            try { _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString();
           }
            catch { }

            if (_batchid != 0)
            {
                var _query = "sp_SelectBatchProdFreezedHistory";

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@batchid",SqlDbType.Int) {Value = _batchid}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Freezing history for: " + _batch;
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show();
            }
        }

        private void btn_Launches_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }


            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatchLaunches(_batchid) });
        }

        private void btn_LaunchProcess_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                            DockingEdge.Left,
                                            new KryptonPage[] { NewInputLaunchProcess(BatchId) });
        }
    }
}
