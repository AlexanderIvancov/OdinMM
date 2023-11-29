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
using Odin.Planning.Controls;
using System.Data.SqlClient;
using Odin.Tools;
using Odin.Warehouse.Requests.Controls;
using Odin.Planning;
using Odin.CMB_Components.BLL;

namespace Odin.Warehouse.Requests
{
    public delegate void RequestSavingEventHandler(object sender);
    public partial class frm_Requests : BaseForm
    {
        public frm_Requests()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "RequestsList.xls", this.Name);
        }

        #region Variables
        public event RequestSavingEventHandler RequestSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Requests_BLL ReqBll = new Requests_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        Plan_BLL PlanBLL = new Plan_BLL();
        CMB_BLL cmbBll = new CMB_BLL();
        Helper MyHelper = new Helper();

        public DataTable data;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int _PrevId = 0;

        public int ReqId
        {
            get;
            set;
        }

              

        public int State
        {
            get
            {
                if (rb_New.Checked == true)
                    return 1;
                else if (rb_Enabled.Checked == true)
                    return -1;
                else if (rb_Closed.Checked == true)
                    return 0;
                else
                    return 99;
            }
            set
            {
                if (value == 0)
                    rb_Closed.Checked = true;
                else if (value == -1)
                    rb_Enabled.Checked = true;
                else if (value == 1)
                    rb_New.Checked = true;
                else
                    rb_All.Checked = true;
            }
        }

        bool _enabledbuttons = true;
        public bool EnabledButtons
        {
            get { return _enabledbuttons; }
            set {
                _enabledbuttons = value;
                if (_enabledbuttons == true)
                {
                    btn_AddNew.Visible = true;
                    btn_Delete.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Copy.Visible = true;
                    cmb_Requests1.Enabled = true;
                    btn_MapRequest.Enabled = true;
                    btn_EnableSelected.Enabled = true;

                    //foreach (DataGridViewColumn column in gv_List.Columns)
                    //{
                    //    if (column.Name == "cn_qtystock")
                    //    {
                    //        column.Visible = true;
                    //    }
                    //}

                }
                else
                {
                    btn_AddNew.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Copy.Visible = false;
                    cmb_Requests1.Enabled = false;
                    btn_MapRequest.Enabled = false;
                    btn_EnableSelected.Enabled = false;

                    foreach (DataGridViewColumn column in gv_List.Columns)
                    {
                        if (column.Name == "cn_qtystock" 
                            || column.Name == "cn_available")
                        {
                            column.Visible = false;
                        }
                    }

                }
            }
        }

        public ctl_RequestConsumptions ctlHistory = null;
        public ctl_ReqHistory ctlReqHistory = null;

        public int ControlWidth = 250;
        public int ControlHistoryOutWith = 0;

        frm_AddRequestDets frm = null;

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

        private KryptonPage NewInputHistory(int _ReqId)
        {
            ctlHistory = new ctl_RequestConsumptions();

            ControlWidth = ctlHistory.Width;
            ControlHistoryOutWith = ctlHistory.Width;
            //ctlConf.COId = _COId;
            ctlHistory.ReqId = _ReqId;
            //ctlConf.ShowSaveButton(true);
            //ctlConf.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);

            ControlHistoryOutWith = ctlHistory.Width;
            return NewPage("Consumption history ", 1, ctlHistory, ctlHistory.Width);
        }

        private KryptonPage NewInputReqHistory(string _Request)
        {
            ctlReqHistory = new ctl_ReqHistory();

            ControlWidth = ctlReqHistory.Width;
            //ctlConf.COId = _COId;
            ctlReqHistory.Request = _Request;
            //ctlConf.ShowSaveButton(true);
            //ctlConf.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);

            return NewPage("History ", 1, ctlReqHistory, ctlReqHistory.Width);
        }

        #endregion

        #region Methods

        private void SavedBatch(object sender)
        {
            if (RequestSaved != null)
            {
                RequestSaved(this);
            }
        }

        public void ClearFilter()
        {
            cmb_Requests1.RequestId = 0;
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;

            cmb_Types1.TypeId = 0;
            cmb_Department1.DeptId = 0;

            cmb_Articles1.ArticleId = 0;

            txt_From.Value = null;
            txt_Till.Value = null;

            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();

        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                //Green - Accepted
                if (row.Cells["cn_statedesc"].Value.ToString() == "Closed")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                    }
                }
                else if (row.Cells["cn_statedesc"].Value.ToString() == "New")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Yellow;
                    }
                }
                else
                { }
            }

       }

        private void AddRequest(object sender)
        {
            frm.Close();
            bwStart(bw_List);

            if (RequestSaved != null)
            {
                RequestSaved(this);
            }
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
            //Add states
            DataTable datastates = new DataTable();
            datastates.Columns.Add("id", typeof(int));

            if (chk_New.CheckState == CheckState.Checked)
            {
                DataRow dr = datastates.NewRow();
                dr["id"] = 1;
                datastates.Rows.Add(dr);
            }
            if (chk_Enabled.CheckState == CheckState.Checked)
            {
                DataRow dr = datastates.NewRow();
                dr["id"] = -1;
                datastates.Rows.Add(dr);
            }
            if (chk_Closed.CheckState == CheckState.Checked)
            {
                DataRow dr = datastates.NewRow();
                dr["id"] = 0;
                datastates.Rows.Add(dr);
            }

            //MessageBox.Show(cmb_SalesOrdersWithLines1.SalesOrderLineId.ToString());
            data = Requests_BLL.getRequests(cmb_Requests1.RequestId, cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, datastates,
                                            cmb_Types1.TypeId, cmb_Department1.DeptId, txt_From.Value == null ? "" : txt_From.Value.ToString().Trim(),
                                            txt_Till.Value == null ? "" : txt_Till.Value.ToString().Trim(), cmb_Firms1.FirmId);
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
                ReqId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                ReqId = 0;
            }

            if (_PrevId == ReqId)
            {
                return true;
            }
            else
            {
                _PrevId = ReqId;
                return false;
            }
        }

        public void ShowDetails(int reqid)
        {
            ReqBll.RequestDetId = reqid;
            FindConsHistoryPages(reqid);
            FindHistoryPages(ReqBll.RDReqName);

        }

        public void FindConsHistoryPages(int reqid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_RequestConsumptions ctlHis1 = (ctl_RequestConsumptions)page.Controls.Find("ctl_RequestConsumptions", true).FirstOrDefault();
                if (ctlHis1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlHis1.ReqId = reqid;
                    //ctlConf11.COId = coid;
                }
                //break;
            }
        }

        public void FindHistoryPages(string request)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_ReqHistory ctlHis1 = (ctl_ReqHistory)page.Controls.Find("ctl_ReqHistory", true).FirstOrDefault();
                if (ctlHis1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlHis1.Request = request;
                    //ctlConf11.COId = coid;
                }
                //break;
            }
        }


        #endregion

        #region Control


        private void frm_Requests_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);
            bn_List.Items.Insert(0, new ToolStripControlHost(chk_SelectAll));

            LoadColumns(gv_List);

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

            frm.HeaderText = "Select view for requests list";
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
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_From.Value = System.DateTime.Now;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Till.Value = System.DateTime.Now;
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm = new frm_AddRequestDets();

            cmbBll.RequestId = cmb_Requests1.RequestId;

            frm.ctl_CreatReqDets1.HeadId = cmb_Requests1.RequestId;
            frm.ctl_CreatReqDets1.ReqDateD = System.DateTime.Now;
            frm.ctl_CreatReqDets1.ProdPlaceId = cmbBll.RequestProdPlace;

            frm.RequestDetsSaved += new RequestDetsSavedEventHandler(AddRequest);


            frm.Show();

        }


        #endregion

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _reqid = 0;

            try { _reqid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_reqid != 0)
            {
                ReqBll.RequestDetId = _reqid;
                frm_EditRequestDet frm = new frm_EditRequestDet();

                frm.HeaderText = "Edit request for: " + ReqBll.RDArticle + ", batch: " + ReqBll.RDBatch;
                frm.Id = _reqid;
                frm.BatchDetId = ReqBll.RDBatchDetId;
                frm.ArticleId = ReqBll.RDArtId;
                frm.Qty = ReqBll.RDQty;
                frm.QtyOut = ReqBll.RDQtyOut;
                frm.ReqDate = ReqBll.RDReqDate;
                frm.State = ReqBll.RDState;
                frm.Urgent = ReqBll.RDUrgent;
                frm.Comments = ReqBll.RDComments;
                frm.Batch = ReqBll.RDBatch;
                frm.CauseId = ReqBll.RDCauseId;
                frm.Serials = ReqBll.RDSerials;
                frm.EnableArticle();
                frm.CheckEmpty();

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (!(DAL.CheckMBLimit(frm.ArticleId) == true && frm.Serials.Trim() == ""))
                    {

                        ReqBll.EditRequestDetail(_reqid, frm.ArticleId, frm.cmb_Articles1.Article, frm.BatchDetId, frm.Qty,
                                             frm.cmb_Articles1.UnitId, frm.ReqDate, frm.Urgent, frm.Comments, ReqBll.RDCatId,
                                             frm.State, frm.CauseId, frm.Serials);

                        int _oldurgent = ReqBll.RDUrgent;
                        int _oldstate = ReqBll.RDState;

                        ReqBll.RequestDetId = _reqid;

                        if (ReqBll.RDUrgent == -1
                            && _oldstate != -1
                            && _oldstate != ReqBll.RDState
                            && ReqBll.RDState == -1)
                        {
                            if (DAL.QtyStock(ReqBll.RDArtId) <= 0)
                            {
                                cmbBll.RequestId = ReqBll.RDHeadId;
                                string emailaddresses = "";
                                emailaddresses = DAL.EmailAddressesByType(5);

                                string strMessage = "Request number: " + cmbBll.RequestName;
                                strMessage = strMessage + "\r\nBatch: " + ReqBll.RDBatch;
                                strMessage = strMessage + "\r\nQty in request: " + ReqBll.RDQty;

                                MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Urgent request NR : " + cmbBll.RequestName + " has no stock!", strMessage);
                            }
                        }

                        if (frm.Batch == string.Empty
                            || frm.Batch == "")
                            KryptonTaskDialog.Show("Request edition warning!",
                                                    "Warning!",
                                                    "This request have no batch!",
                                                    MessageBoxIcon.Warning,
                                                    TaskDialogButtons.OK);


                        DataGridViewColumn oldColumn = gv_List.SortedColumn;
                        var dir = Helper.SaveDirection(gv_List);

                        bwStart(bw_List);

                        Helper.RestoreDirection(gv_List, oldColumn, dir);
                    }
                    else
                        glob_Class.ShowMessage("You have empty serial numbers fields!", "Enter serial numbers!", "Serial numbers warning!");
                }                
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _reqid = 0;

            try { _reqid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }
                      

            if (_reqid != 0)
            {
                DialogResult result = KryptonTaskDialog.Show("Request deleting warning!",
                                                                    "Are you sure you want to delete request?",
                                                                    "Request deleting will automatically free reserved qty for it.",
                                                                    MessageBoxIcon.Warning,
                                                                    TaskDialogButtons.Yes |
                                                                    TaskDialogButtons.No);
                if (result == DialogResult.Yes)
                {
                    ReqBll.RequestDetId = _reqid;
                    if (ReqBll.RDQtyOut > 0)
                    {
                        KryptonTaskDialog.Show("Request deleting warning!",
                                                                         "Warning!",
                                                                         "Request have stock outcomes so it cannot be deleted!",
                                                                         MessageBoxIcon.Warning,
                                                                         TaskDialogButtons.OK);
                    }
                    else
                    {
                        ReqBll.DeleteRequestDetail(_reqid);
                        DataGridViewColumn oldColumn = gv_List.SortedColumn;
                        var dir = Helper.SaveDirection(gv_List);

                        bwStart(bw_List);

                        Helper.RestoreDirection(gv_List, oldColumn, dir);
                    }
                }
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(ReqId);
            }
        }

        private void btn_HistoryOut_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputHistory(ReqBll.RequestDetId) });
        }

        private void txt_From_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_From.Value = txt_From.Value == null ? System.DateTime.Now : txt_From.Value;
        }

        private void txt_Till_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_Till.Value = txt_Till.Value == null ? System.DateTime.Now : txt_Till.Value;
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_List.Columns["chk_print"].Index)  //Checking index of checkbox column is equal to clickable cell index.
            {
                gv_List.EndEdit();

                //bs_List.ResetBindings(true);
                //if (Convert.ToInt32(gv_List.CurrentRow.Cells["chk_print"].Value) == -1)
                //{
                //    //Add row 
                //}
                //else
                //{
                //    //Delete row
                //}
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            frm_rptRequests frm = new frm_rptRequests();
            frm.HeaderText = "Print requests list ";

            frm.data = data.Clone();

            foreach (DataRow dr in data.Rows)
            {
                if (Convert.ToInt32(dr["toprint"]) == -1)
                {
                    frm.data.ImportRow(dr);
                }
            }

            frm.FillReport();

            frm.Show();
            

        }

        private void chk_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SelectAll.Checked == true)
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["chk_print"].Value = -1;
                }
            else
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["chk_print"].Value = 0;
                }
        }

        private void btn_MapRequest_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _batch = "";
            int _artid = 0;
            double _qty = 0;
            int _batchdetid = 0;
            int _oldbatchdetid = 0;

            try {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString();
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                _qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                _oldbatchdetid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchdetid"].Value);
            }
            catch { }

            if (//_batch == ""
                //&& 
                _id != 0
                && _artid != 0
                && _qty != 0)
            {
                frm_cmbBatch frm = new frm_cmbBatch();
                frm.Batch = _batch;


                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && frm.BatchId != 0
                    && frm.IsActive == -1)
                {

                    //Check for existed batch detail
                    _batchdetid = Convert.ToInt32(Helper.GetOneRecord("select top 1 isnull(id, 0) as id from prod_batchdet where bhid = " + frm.BatchId + " and artcstid = " +  _artid));

                    if (_batchdetid == 0)
                        //Add detail
                        _batchdetid = PlanBLL.AddBatchDetail(frm.BatchId, _artid, 0/*_qty*/, "");
                    
                    //Edit request, state - enabled

                    if (_batchdetid != 0
                        && _batchdetid != _oldbatchdetid)
                    {
                        var query = "UPDATE REQ_Dets SET /*State = -1,*/ batchdetid = " + _batchdetid + " WHERE Id = " + _id;
                        Helper.ExecuteQuery(query);

                        if (_batchdetid != _oldbatchdetid)
                        {
                            var query1 = "update STO_StockOutDets set batchdetid = rd.batchdetid " + 
                                            "from STO_StockOutReq orq " + 
                                            "inner join STO_StockOutDets so on so.id = orq.soid " +
                                            "inner join REQ_Dets rd on rd.id = orq.reqid " + 
                                            "where orq.reqid = " + _id;
                            Helper.ExecuteQuery(query1);
                            //Update given
                        }

                        ReqBll.RequestDetId = _id;
                        if (ReqBll.RDUrgent == -1)
                        {
                            if (DAL.QtyStock(ReqBll.RDArtId) <= 0)
                            {
                                cmbBll.RequestId = ReqBll.RDHeadId;
                                string emailaddresses = "";
                                emailaddresses = DAL.EmailAddressesByType(5);

                                string strMessage = "Request number: " + cmbBll.RequestName;
                                strMessage = strMessage + "\r\nBatch: " + ReqBll.RDBatch;
                                strMessage = strMessage + "\r\nQty in request: " + ReqBll.RDQty;

                                MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Urgent request NR : " + cmbBll.RequestName + " has no stock!", strMessage);
                            }
                        }
                    }

                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                    //Update state
                }

            }
            
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            int _reqid = 0;

            try { _reqid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_reqid != 0)
                ReqBll.RequestDetId = _reqid;

            if (ReqBll.RDBatchDetId == 0
                || ReqBll.RDBatchStateId == 0)
                KryptonTaskDialog.Show("Request line replacing warning!",
                                       "Warning!",
                                       "Request have no batch line, just must just edit line or map to existed!",
                                       MessageBoxIcon.Warning,
                                       TaskDialogButtons.OK);
            else
            {
                frm_cmbArt frm = new frm_cmbArt();
                frm.HeaderText = "Replace line in batch: " + ReqBll.RDBatch;
                
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && frm.ArticleId != ReqBll.RDArtId
                    && frm.ArticleId != 0)
                {

                    ReqBll.ReplaceRequestDetail(_reqid, ReqBll.RDBatchDetId, frm.ArticleId, frm.Comments);

                    ReqBll.RequestDetId = _reqid;
                    if (ReqBll.RDUrgent == -1)
                    {
                        if (DAL.QtyStock(ReqBll.RDArtId) <= 0)
                        {
                            cmbBll.RequestId = ReqBll.RDHeadId;
                            string emailaddresses = "";
                            emailaddresses = DAL.EmailAddressesByType(5);

                            string strMessage = "Request number: " + cmbBll.RequestName;
                            strMessage = strMessage + "\r\nBatch: " + ReqBll.RDBatch;
                            strMessage = strMessage + "\r\nQty in request: " + ReqBll.RDQty;

                            MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Urgent request NR : " + cmbBll.RequestName + " has no stock!", strMessage);
                        }
                    }

                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                }
            }
        }

        private void btn_EnableSelected_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            DialogResult result = KryptonTaskDialog.Show("Request enabling warning!",
                                                                   "Are you sure you want to enable selected requests?",
                                                                   "",
                                                                   MessageBoxIcon.Warning,
                                                                   TaskDialogButtons.Yes |
                                                                   TaskDialogButtons.No);
            if (result == DialogResult.Yes)
            {
                int _id = 0;
             

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    _id = Convert.ToInt32(row.Cells["cn_id"].Value);

                    if (Convert.ToInt32(row.Cells["chk_print"].Value) != 0)
                    {
                        var query = "UPDATE REQ_Dets SET State = -1 WHERE Id = " + _id + " and state != -1";
                        Helper.ExecuteQuery(query);
                    }

                }

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

            }

        }

        private void frm_Requests_Resize(object sender, EventArgs e)
        {
            if (_frm_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    ctl_RequestConsumptions ctlHis1 = (ctl_RequestConsumptions)page.Controls.Find("ctl_RequestConsumptions", true).FirstOrDefault();
                    if (ctlHis1 != null)
                    {                        
                        ControlWidth = ControlHistoryOutWith;
                    }


                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });
                }

            }

        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rests_Click(object sender, EventArgs e)
        {

        }

        private void btn_General_Click(object sender, EventArgs e)
        {

        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputReqHistory(ReqBll.RDReqName) });
        }
    }
}
