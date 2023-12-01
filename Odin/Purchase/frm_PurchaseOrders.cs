using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Purchase.Reports;
using Odin.Register;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Odin.Purchase
{
    public delegate int ReceivePOId();

    public partial class frm_PurchaseOrders : BaseForm
    {
        public frm_PurchaseOrders()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "PurchaseOrders.xls", this.Name);
        }

        #region Variables

        public static event ReceivePOId ReceiveId;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        PO_BLL POBll = new PO_BLL();
        Reg_BLL RegBll = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();

        public ctl_PODets ctlGen = null;
        public ctl_AddFromNeeds ctlNeeds = null;
        public ctl_POConfirms ctlConf = null;
        public ctl_PODeliveries ctlDeliveries = null;
        public ctl_POHistory ctlHistory = null;

        public int ControlWidth = 250;

        frm_AddPODets frm = null;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";


        public int POId
        {
            get;
            set;
        }

        public int _PrevId = 0;

        public DataTable data;

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
            cmb_PurchaseOrders1.PurchaseOrderId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Common1.SelectedValue = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            txt_SupOrder.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_CreatDateFrom.Value = null; //Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
            txt_ReqDateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_ReqDateTill.Value = null;//Convert.ToDateTime("01/01/2100");
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
            txt_ConfBefore.Value = null;
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_inprocess"].Value) != 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Yellow;
                try
                {
                    if (Convert.ToDateTime(row.Cells["cn_confdate"].Value) <= System.DateTime.Now.AddDays(5)
                        //Convert.ToDateTime(row.Cells["cn_confdate"].Value).AddDays(5) <= System.DateTime.Now
                        && row.Cells["cn_state"].Value.ToString().ToLower() == "open")
                        row.Cells["cn_confdate"].Style.BackColor = Color.Red;
                }
                catch { }
            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            data = PO_BLL.getPurchaseOrders(cmb_PurchaseOrders1.PurchaseOrderId, cmb_Types1.TypeId, cmb_Firms1.FirmId, cmb_Common1.SelectedValue,
                                            cmb_Articles1.ArticleId, cmb_Articles1.Article.Trim(), txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(), txt_SupOrder.Text, txt_Comments.Text,
                                            txt_ReqDateFrom.Value == null ? "" : txt_ReqDateFrom.Value.ToString().Trim(), 
                                            txt_ReqDateTill.Value == null ? "" : txt_ReqDateTill.Value.ToString().Trim(),
                                            txt_ConfBefore.Value == null ? "" : txt_ConfBefore.Value.ToString().Trim());

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

        private KryptonPage NewInputGeneral(int _POId)
        {
            ctlGen = new ctl_PODets();

            ctlGen.POId = _POId;
            ctlGen.cmb_PurchaseOrders1.PurchaseOrderId = POBll.POHeadId1;
            ctlGen.SendPOId += new POIdSendingEventHandler(ChangePOIdSelection);
            ctlGen.CheckEmpty();

            ControlWidth = ctlGen.Width;

            return NewPage("General PO", 1, ctlGen, ctlGen.Width);
        }

        private KryptonPage NewInputNeeds()
        {
            ctlNeeds = new ctl_AddFromNeeds();
                        
            ctlNeeds.POHeadId = POBll.POHeadId1;
            ctlNeeds.RefreshData();
            ctlNeeds.SetCellsColor();

            ControlWidth = ctlNeeds.Width;

            return NewPage("Articles needs ", 1, ctlNeeds, ctlNeeds.Width);
        }

        private KryptonPage NewInputConfirmation(int _POId)
        {
            ctlConf = new ctl_POConfirms();

            ControlWidth = ctlConf.Width;
            //ctlConf.COId = _COId;
            ctlConf.cmb_PurchaseOrdersLines1.PurchaseOrderLineId = _POId;
            //ctlConf.ShowSaveButton(true);
            //ctlConf.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);
            
            return NewPage("Confirmations ", 1, ctlConf, ctlConf.Width);
        }

        private KryptonPage NewInputHistory(int _COId)
        {
            ctlHistory = new ctl_POHistory();

            ControlWidth = ctlHistory.Width;
            ctlHistory.POId = _COId;
           
            return NewPage("History ", 1, ctlHistory, ctlHistory.Width);
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


        private KryptonPage NewInputDeliveries(int _POId)
        {
            ctlDeliveries = new ctl_PODeliveries();

            ControlWidth = ctlDeliveries.Width;
            ctlDeliveries.POId = _POId;
            ctlDeliveries.HeaderText = "History of deliveries for: " + POBll.POName + '/' + POBll.POLine;

            return NewPage("Deliveries history ", 1, ctlDeliveries, ctlDeliveries.Width);
        }
        private void ChangePOIdSelection(object sender)
        {
            bwStart(bw_List);
        }

        private bool CheckOldRow()
        {

            try
            {
                POId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                POId = 0;
            }

            if (_PrevId == POId)
            {
                return true;
            }
            else
            {
                _PrevId = POId;
                return false;
            }
        }

        public void ShowDetails(int poid)
        {
            POBll.POId = poid;

            cmb_PurchaseOrders1.PurchaseOrderId = POBll.POHeadId1;
            
            FindGenPages(poid);
            FindConfPages(poid);
            FindDeliveriesPages(poid);
            FindHistoryPages(poid);

            //FindBatchPages(coid);

        }

        public void ShowEdit()
        {
            if (globClass.IsFormAlreadyOpen("frm_AddPODets")) return;

            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm = new frm_AddPODets();

                frm.ctl_PODets1.cmb_PurchaseOrders1.PurchaseOrderId = cmb_PurchaseOrders1.PurchaseOrderId;
                frm.ctl_PODets1.POId = _id;
                frm.ctl_PODets1.EnableNeeds();

                frm.POLineSaved += new POSavedEventHandler(AddPO);

                frm.Show();
            }
        }
        public void FindGenPages(int poid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_PODets ctlGen1 = (ctl_PODets)page.Controls.Find("ctl_PODets", true).FirstOrDefault();
                if (ctlGen1 != null)
                {
                    ctlGen1.POId = poid;
                    ctlGen1.HeadId = POBll.POHeadId1;

                    ctlGen1.CheckEmpty();
                }
                //break;
            }
        }

        public void FindConfPages(int poid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_POConfirms ctlConf1 = (ctl_POConfirms)page.Controls.Find("ctl_POConfirms", true).FirstOrDefault();
                if (ctlConf1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlConf1.cmb_PurchaseOrdersLines1.PurchaseOrderLineId = poid;
                    //ctlConf11.COId = coid;
                }

            }
        }

        public void FindDeliveriesPages(int poid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_PODeliveries ctlDeliveries1 = (ctl_PODeliveries)page.Controls.Find("ctl_PODeliveries", true).FirstOrDefault();
                if (ctlDeliveries1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlDeliveries1.POId = poid;
                    ctlDeliveries1.HeaderText = "History of deliveries for: " + POBll.POName + '/' + POBll.POLine;
                    //ctlConf11.COId = coid;
                }

            }
        }

        public void FindNeedsPages(int poheadid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_AddFromNeeds ctlNeeds1 = (ctl_AddFromNeeds)page.Controls.Find("ctl_AddFromNeeds", true).FirstOrDefault();
                if (ctlNeeds1 != null)
                {
                    ctlNeeds1.RefreshData();
                    //ctlNeeds1.POHeadId = poheadid;
                }
                //break;
            }
        }

        public void FindHistoryPages(int poid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_POHistory ctlHis1 = (ctl_POHistory)page.Controls.Find("ctl_POHistory", true).FirstOrDefault();
                if (ctlHis1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlHis1.POId = poid;
                    //ctlConf11.COId = coid;
                }
                //break;
            }
        }

        #endregion

        #region Controls

        private void frm_PurchaseOrders_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            txt_CreatDateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
            txt_ReqDateFrom.Value = null;//Convert.ToDateTime("01/01/2000");
            txt_ReqDateTill.Value = null;// Convert.ToDateTime("01/01/2100");
            cmb_Common1.SelectedValue = 1;
            txt_ConfBefore.Value = null;

            bn_List.Items.Insert(0, new ToolStripControlHost(chk_SelectAll));
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

            frm.HeaderText = "Select view for purchase orders list";
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

        private void AddPO(object sender)
        {
           
            if (frm.ctl_PODets1.POId != 0)
                frm.Close();

            gv_List.Invoke(new MethodInvoker(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }));


            //FindNeedsPages(cmb_PurchaseOrders1.PurchaseOrderId);
        }


        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_SupOrder.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;// Convert.ToDateTime("01/01/2000");
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CreatDateTill.Value = System.DateTime.Now;//Convert.ToDateTime("01/01/2100");
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_ReqDateFrom.Value = System.DateTime.Now;//Convert.ToDateTime("01/01/2000");
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_ReqDateTill.Value = System.DateTime.Now;//Convert.ToDateTime("01/01/2100");
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
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
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (globClass.IsFormAlreadyOpen("frm_AddPODets")) return;

            if (cmb_PurchaseOrders1.PurchaseOrderId != 0)
            {
                bool _globtest = true;

                frm = new frm_AddPODets();
                
                frm.ctl_PODets1.cmb_PurchaseOrders1.PurchaseOrderId = cmb_PurchaseOrders1.PurchaseOrderId;
                frm.ctl_PODets1.Line = POBll.LastPOLine(cmb_PurchaseOrders1.PurchaseOrderId) + 1;
                frm.ctl_PODets1.StateId = 1;
                RegBll.FirmId = cmb_PurchaseOrders1.SupplierId;
                frm.ctl_PODets1.Vat = RegBll.CountryVAT;
                frm.ctl_PODets1.EnableNeeds();
                frm.ctl_PODets1.FillDates();
                //frm.ctl_PODets1.SupId = cmb_PurchaseOrders1.SupplierId;

                foreach (var page in kryptonDockingManager1.Pages)
                {
                    ctl_AddFromNeeds ctlNeeds1 = (ctl_AddFromNeeds)page.Controls.Find("ctl_AddFromNeeds", true).FirstOrDefault();
                    if (ctlNeeds1 != null && Math.Round(ctlNeeds1.ctl_RMNeeds1.PurchasedQty, 0) > 0)
                    {
                        bool _test = true;

                        if (ctlNeeds1.ctl_RMNeeds1.AvailableQty > 0
                            || ctlNeeds1.QtyFreePO > 0)
                        {
                            DialogResult result1 = KryptonTaskDialog.Show("Available or free po quantity existance!",
                                                                             "Are you want to save changes?",
                                                                             "Available quantity or free po quantity is more than zero! It is recommended to distribute it at the first!",
                                                                             MessageBoxIcon.Warning,
                                                                             TaskDialogButtons.Yes |
                                                                             TaskDialogButtons.No);
                            _test = result1 != DialogResult.No;
                        }

                        if (_test == true)
                        {
                            frm.ctl_PODets1.ArtId = ctlNeeds1.ctl_RMNeeds1.ArtId;
                            frm.ctl_PODets1.ArtFromNeeds = ctlNeeds1.ctl_RMNeeds1.ArtId;
                            frm.ctl_PODets1.NeedsInPO = ctlNeeds1.ctl_RMNeeds1.PurchasedQty;
                            frm.ctl_PODets1.Qty = frm.ctl_PODets1.NeedsInPO;

                            if (frm.ctl_PODets1.Qty > 0)
                                frm.ctl_PODets1.Qty = frm.ctl_PODets1.MOQMPQ(frm.ctl_PODets1.Qty
                                                    / frm.ctl_PODets1.CoefConv, frm.ctl_PODets1.MOQ, frm.ctl_PODets1.MPQ) * frm.ctl_PODets1.CoefConv;

                            //Date of purchase order!!



                            frm.ctl_PODets1.ShowLineTots();
                            frm.ctl_PODets1.CheckEmpty();

                            frm.ctl_PODets1.DataNeeds = ctlNeeds1.ctl_RMNeeds1.data.Copy();
                        }
                        else
                        {
                            _globtest = false;
                        }
                    }
                }

                if (_globtest == true)
                {
                    frm.POLineSaved += new POSavedEventHandler(AddPO);
                    frm.Show();
                }
                else
                {
                    frm = null;
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            if (globClass.IsFormAlreadyOpen("frm_AddPODets")) return;

            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm = new frm_AddPODets();

                frm.ctl_PODets1.cmb_PurchaseOrders1.PurchaseOrderId = cmb_PurchaseOrders1.PurchaseOrderId;
                frm.ctl_PODets1.POId = _id;
                frm.ctl_PODets1.IsCopy = true;
                frm.ctl_PODets1.Line = POBll.LastPOLine(cmb_PurchaseOrders1.PurchaseOrderId) + 1;
                frm.ctl_PODets1.StateId = 1;
                frm.ctl_PODets1.EnableNeeds();

                frm.POLineSaved += new POSavedEventHandler(AddPO);

                frm.Show();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (globClass.DeleteConfirm() == true)
            {
                MessageBox.Show(POBll.DeletePOLine(_id));
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            int _headid = 0;
            try { _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value); }
            catch { }
            if (_headid != 0
                && globClass.CancelConfirm() == true)
            {
                POBll.CancelAllLines(_headid);
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(POId);
            }
        }

        private void btn_General_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputGeneral(POBll.POId) });
        }

        private void btn_Confirmations_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputConfirmation(POBll.POId) });
        }

        private void frm_PurchaseOrders_Resize(object sender, EventArgs e)
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

        private void btn_Requests_Click(object sender, EventArgs e)
        {
            int _countcontrols = 0;

            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_AddFromNeeds ctlNeeds1 = (ctl_AddFromNeeds)page.Controls.Find("ctl_AddFromNeeds", true).FirstOrDefault();
                if (ctlNeeds1 != null)
                {
                    _countcontrols++;
                }
            }

            if (_countcontrols > 0)
                MessageBox.Show("You can't open more than one needs page!");
            else
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputNeeds() });
         
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void cmb_PurchaseOrders1_PurchaseOrderChanged(object sender)
        {
            //FindNeedsPages(cmb_PurchaseOrders1.PurchaseOrderId);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            if (cmb_PurchaseOrders1.PurchaseOrderId != 0)
            {

                frm_rptPurchaseOrder frm = new frm_rptPurchaseOrder();
                frm.HeadId = cmb_PurchaseOrders1.PurchaseOrderId;


                frm.HeaderText = "Print purchase order: " + cmb_PurchaseOrders1.PurchaseOrder;

                frm.data = data.Clone();

                foreach (DataRow dr in data.Rows)
                {
                    if (Convert.ToInt32(dr["toprint"]) == -1
                        && Convert.ToInt32(dr["headid"]) == cmb_PurchaseOrders1.PurchaseOrderId)
                    {
                        frm.data.ImportRow(dr);
                    }
                }


                frm.FillReport();

                frm.Show();
            }
        }

        private void btn_Batches_Click(object sender, EventArgs e)
        {

        }

        private void btn_Deliveries_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputDeliveries(POBll.POId) });
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void txt_CreatDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateFrom.Value = txt_CreatDateFrom.Value == null ? System.DateTime.Now : txt_CreatDateFrom.Value;
        }

        private void txt_CreatDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateTill.Value = txt_CreatDateTill.Value == null ? System.DateTime.Now : txt_CreatDateTill.Value;
        }

        private void txt_ReqDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ReqDateFrom.Value = txt_ReqDateFrom.Value == null ? System.DateTime.Now : txt_ReqDateFrom.Value;
        }

        private void txt_ReqDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ReqDateTill.Value = txt_ReqDateTill.Value == null ? System.DateTime.Now : txt_ReqDateTill.Value;
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

        private void btn_SendLetter_Click(object sender, EventArgs e)
        {
            string emailaddresses = DAL.EmailAddressesByType(3);
            string strMessage = "";
            int c = 0;

            if (emailaddresses != "")
            {
                var data = PO_BLL.getPODets(cmb_PurchaseOrders1.PurchaseOrderId);
                POBll.POHeadId = cmb_PurchaseOrders1.PurchaseOrderId;

                foreach (DataRow row in data.Rows)
                {
                    if (Convert.ToInt32(row["resale"]) == -1)
                    {
                        c++;
                        strMessage = c == 1
                            ? "Line N: " + row["line"] + ", Art.Id: " + row["artid"]
                                                    + ", Suppliers article: " + row["article"]
                                                    + ", Qty: " + row["qty"] + " " + row["unit"]
                            : strMessage + "\r\nLine N: " + row["line"] + ", Art.Id: " + row["artid"]
                                                    + ", Suppliers article: " + row["article"]
                                                    + ", Qty: " + row["qty"] + " " + row["unit"];
                        //strMessage = strMessage + "Art.Id: " + row["artid"];
                        //strMessage = strMessage + "\r\nSuppliers article: " + row["article"];
                        //strMessage = strMessage + "\r\nQty: " + row["qty"] + " " + row["unit"];


                    }
                
                }
                MyHelper.SendMessage(globClass.ReplaceChar(emailaddresses, ";", ","),
                                   "Purchase order for resale NR : " + cmb_PurchaseOrders1.PurchaseOrder + ", supplier: " + POBll.POHeadSupplier + " was created!",
                                   strMessage);
            }
          
        }

        private void txt_ConfBefore_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ConfBefore.Value = txt_ConfBefore.Value == null ? System.DateTime.Now : txt_ConfBefore.Value;
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputHistory(POBll.POId) });
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
