using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Planning.Controls;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Sales
{
    public delegate int ReceiveCOId();

    public partial class frm_ClientOrders : BaseForm
    {
        public frm_ClientOrders()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ConfirmationOrders.xls", this.Name);
        }

        #region Variables

        public static event ReceiveCOId ReceiveId;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CO_BLL COBll = new CO_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();

        private frm_AddCODet frm = null;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";


        public int COId
        {
            get;
            set;
        }

        public int _PrevId = 0;

        public bool _iscopy = false;

        public ctl_CODets ctlGen = null;
        public ctl_COConfirmations ctlConf = null;
        public ctl_CODeliveries ctlDeliv = null;
        public ctl_COInvoices ctlInvoices = null;

        public ctl_Batches ctlBatches = null;
        public ctl_COHistory ctlHistory = null;
        public int ControlWidth = 250;
        public ctl_Launches ctlBatchLaunches = null;
        public int ctlBatchLaunchesWidth = 0;
        public ctl_COAwaitingCost ctlAwaitingCost = null;

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

        private KryptonPage NewInputGeneral(int _COId)
        {
            ctlGen = new ctl_CODets();

            ControlWidth = ctlGen.Width;

            ctlGen.COId = _COId;
            ctlGen.COHeadId = COBll.COHeadId1;
            ctlGen.ShowSaveButton(true);
            ctlGen.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);


            return NewPage("General CO", 1, ctlGen, ctlGen.Width);
        }

        private KryptonPage NewInputConfirmation(int _COId)
        {
            ctlConf = new ctl_COConfirmations();

            ControlWidth = ctlConf.Width;
            //ctlConf.COId = _COId;
            ctlConf.cmb_SalesOrdersWithLines1.SalesOrderLineId = _COId;
            //ctlConf.ShowSaveButton(true);
            //ctlConf.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);


            return NewPage("Confirmations ", 1, ctlConf, ctlConf.Width);
        }

        private KryptonPage NewInputDelivery(int _COId)
        {
            ctlDeliv = new ctl_CODeliveries();

            ControlWidth = ctlDeliv.Width;
            //ctlConf.COId = _COId;
            ctlDeliv.cmb_SalesOrdersWithLines1.SalesOrderLineId = _COId;
            //ctlConf.ShowSaveButton(true);
            //ctlConf.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);


            return NewPage("Deliveries ", 1, ctlDeliv, ctlDeliv.Width);
        }

        private KryptonPage NewInputInvoices(int _COId)
        {
            ctlInvoices = new ctl_COInvoices();

            ControlWidth = ctlInvoices.Width;
            //ctlConf.COId = _COId;
            ctlInvoices.cmb_SalesOrdersWithLines1.SalesOrderLineId = _COId;
            //ctlConf.ShowSaveButton(true);
            //ctlConf.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);


            return NewPage("Invoices ", 1, ctlInvoices, ctlInvoices.Width);
        }

        private KryptonPage NewInputHistory(int _COId)
        {
            ctlHistory = new ctl_COHistory();

            ControlWidth = ctlHistory.Width;
            //ctlConf.COId = _COId;
            ctlHistory.COId = _COId;
            //ctlConf.ShowSaveButton(true);
            //ctlConf.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);

            return NewPage("History ", 1, ctlHistory, ctlHistory.Width);
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

        private KryptonPage NewInputBatchLaunches(int _coid)
        {

            ctlBatchLaunches = new ctl_Launches();
            ctlBatchLaunches.COId = _coid;
            ctlBatchLaunches.gv_List.ThreadSafeCall(delegate { ctlBatchLaunches.SetCellsColor(); });
            ControlWidth = ctlBatchLaunches.Width;
            ctlBatchLaunchesWidth = ctlBatchLaunches.Width;

            return NewPage("Batch launches", 1, ctlBatchLaunches, ctlBatchLaunches.Width);
        }

        private KryptonPage NewInputAwaitingCost(int _COId)
        {
            ctlAwaitingCost = new ctl_COAwaitingCost();

            ControlWidth = ctlAwaitingCost.Width;
            //ctlConf.COId = _COId;
            ctlAwaitingCost.cmb_SalesOrdersWithLines1.SalesOrderLineId = _COId;
            //ctlConf.ShowSaveButton(true);
            //ctlConf.SendCOId += new COIdSendingEventHandler(ChangeCOIdSelection);


            return NewPage("Awaiting cost ", 1, ctlAwaitingCost, ctlAwaitingCost.Width);
        }


        private void ChangeCOIdSelection(object sender)
        {
            bwStart(bw_List);
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_isprimary"].Value) == -1)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Orange;

                if (Convert.ToInt32(row.Cells["cn_stateid"].Value) == 4
                    || Convert.ToInt32(row.Cells["cn_stateid"].Value) == 3)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Gainsboro;
            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            DataTable datastates = new DataTable();
            datastates.Columns.Add("id", typeof(int));

            if (chk_New.CheckState == CheckState.Checked)
            {
                DataRow dr = datastates.NewRow();
                dr["id"] = 1;
                datastates.Rows.Add(dr);
            }
            if (chk_InProcess.CheckState == CheckState.Checked)
            {
                DataRow dr = datastates.NewRow();
                dr["id"] = 2;
                datastates.Rows.Add(dr);
            }
            if (chk_Cancelled.CheckState == CheckState.Checked)
            {
                DataRow dr = datastates.NewRow();
                dr["id"] = 3;
                datastates.Rows.Add(dr);
            }
            if (chk_Closed.CheckState == CheckState.Checked)
            {
                DataRow dr = datastates.NewRow();
                dr["id"] = 4;
                datastates.Rows.Add(dr);
            }

            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = CO_BLL.getSalesOrders(cmb_SalesOrders1.SalesOrderId, cmb_Batches1.BatchId, cmb_Types1.TypeId, cmb_Department1.DeptId, cmb_Firms1.FirmId, datastates,
                                            cmb_Articles1.ArticleId, cmb_Articles1.Article.Trim(), txt_CustArticle.Text, txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(), txt_CustOrder.Text, txt_Comments.Text,
                                            txt_ReqDateFrom.Value == null ? "" : txt_ReqDateFrom.Value.ToString().Trim(), txt_ReqDateTill.Value == null ? "" : txt_ReqDateTill.Value.ToString().Trim());

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

        public void ClearFilter()
        {
            cmb_SalesOrders1.SalesOrderId = 0;
            cmb_Batches1.BatchId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Department1.DeptId = 0;
            cmb_Common1.SelectedValue = 0;
            cmb_Articles1.ArticleId = 0;
            txt_CustOrder.Text = string.Empty;
            txt_CustArticle.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_CreatDateFrom.Value = null;
            txt_CreatDateTill.Value = null;
            txt_ReqDateFrom.Value = null;
            txt_ReqDateTill.Value = null;
            mni_FilterFor.Text = string.Empty;
            chk_InProcess.Checked = true;
            chk_Closed.Checked = false;
            chk_Cancelled.Checked = false;
            chk_New.Checked = true;
            bs_List.RemoveFilter();
            SetCellsColor();
        }

        private void AddCOLine(object sender)
        {
            int NewLineId = 0;
            int _coid = 0;

            if (_iscopy == false)
                _coid = frm.ctl_CODets1.COId;

            if (frm.ctl_CODets1.COArtId != 0
                 /*&& frm.ctl_CODets1.COQty != 0
                  *&& frm.ctl_CODets1.COUnitPrice != 0*/)
            {
                DataTable datastages = new DataTable();
                datastages.Columns.Add("id", typeof(int));
                datastages.Columns.Add("osid", typeof(int));
                datastages.Columns.Add("checked", typeof(int));

                foreach (DataGridViewRow row in frm.ctl_CODets1.gv_List.Rows)
                {
                    DataRow dr = datastages.NewRow();
                    dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                    //dr["osid"] = Convert.ToInt32(row.Cells["cn_osid"].Value);
                    dr["osid"] = _iscopy == true ? 0 : (object)Convert.ToInt32(row.Cells["cn_osid"].Value);


                    dr["checked"] = Convert.ToInt32(row.Cells["chk_checked"].Value);


                    datastages.Rows.Add(dr);
                }

                NewLineId = COBll.SaveCOLine(_coid, frm.ctl_CODets1.COHeadId, frm.ctl_CODets1.COLine, frm.ctl_CODets1.COCustOrder, frm.ctl_CODets1.COCustLine,
                                            "", "", frm.ctl_CODets1.COArtId, frm.ctl_CODets1.COCustArticle, frm.ctl_CODets1.COService, frm.ctl_CODets1.COQty,
                                            frm.ctl_CODets1.COUnitId, frm.ctl_CODets1.COReqDate, frm.ctl_CODets1.COStateId, frm.ctl_CODets1.COUnitPrice,
                                            frm.ctl_CODets1.COVat, frm.ctl_CODets1.COComments, frm.ctl_CODets1.COComments1,
                                            frm.ctl_CODets1.COLogComments, frm.ctl_CODets1.CODelivPlaceId, frm.ctl_CODets1.CODelivAddressId, frm.ctl_CODets1.COEndCustId, "", "", "",
                                            datastages, frm.ctl_CODets1.COInternal, frm.ctl_CODets1.COResale, frm.ctl_CODets1.COSpoilage, frm.ctl_CODets1.COBlocked, 
                                            frm.ctl_CODets1.COSalesComments, frm.ctl_CODets1.COContract, frm.ctl_CODets1.COPrimary);


                bwStart(bw_List);

                frm.Close();
            }


        }

        private bool CheckOldRow()
        {

            try
            {
                COId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                COId = 0;
            }

            if (_PrevId == COId)
            {
                return true;
            }
            else
            {
                _PrevId = COId;
                return false;
            }
        }

        public void ShowDetails(int coid)
        {
            COBll.COId = coid;

            //if (coid != 0)
            //    cmb_SalesOrders1.SalesOrderId = COBll.COHeadId1;

            FindGenPages(coid);
            FindConfPages(coid);
            FindBatchPages(coid);
            FindHistoryPages(coid);
            FindDelivPages(coid);
            FindInvoicesPages(coid);
            FindLaunchPages(coid);
            FindAwaitingCost(coid);

        }

        public void ShowEdit()
        {
            if (globClass.IsFormAlreadyOpen("frm_AddCODet")) return;

            _iscopy = false;

            frm = new frm_AddCODet();
            frm.ctl_CODets1.COId = COBll.COId;
            frm.ctl_CODets1.COHeadId = COBll.COHeadId1;

            frm.SaveChanges += new SaveChangesEventHandler(AddCOLine);

            frm.Show(); frm.GetKryptonFormFields();
        }
        public void FindGenPages(int coid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_CODets ctlGen1 = (ctl_CODets)page.Controls.Find("ctl_CODets", true).FirstOrDefault();
                if (ctlGen1 != null)
                {
                    ctlGen1.COId = coid;
                    ctlGen1.COHeadId = COBll.COHeadId1;
                    ctlGen1.ShowSaveButton(true);
                }
                //break;
            }
        }

        public void FindConfPages(int coid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_COConfirmations ctlConf1 = (ctl_COConfirmations)page.Controls.Find("ctl_COConfirmations", true).FirstOrDefault();
                if (ctlConf1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlConf1.cmb_SalesOrdersWithLines1.SalesOrderLineId = coid;
                    //ctlConf11.COId = coid;
                }
                //break;
            }
        }

        public void FindDelivPages(int coid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_CODeliveries ctlDeliv1 = (ctl_CODeliveries)page.Controls.Find("ctl_CODeliveries", true).FirstOrDefault();
                if (ctlDeliv1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlDeliv1.cmb_SalesOrdersWithLines1.SalesOrderLineId = coid;
                    //ctlConf11.COId = coid;
                }
                //break;
            }
        }

        public void FindAwaitingCost(int coid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_COAwaitingCost ctlAwaitingCost1 = (ctl_COAwaitingCost)page.Controls.Find("ctl_COAwaitingCost", true).FirstOrDefault();
                if (ctlAwaitingCost1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlAwaitingCost1.cmb_SalesOrdersWithLines1.SalesOrderLineId = coid;
                    //ctlConf11.COId = coid;
                }
                //break;
            }
        }

        public void FindInvoicesPages(int coid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_COInvoices ctlInvoices1 = (ctl_COInvoices)page.Controls.Find("ctl_COInvoices", true).FirstOrDefault();
                if (ctlInvoices1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlInvoices1.cmb_SalesOrdersWithLines1.SalesOrderLineId = coid;
                    //ctlConf11.COId = coid;
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
        public void FindLaunchPages(int coid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Launches ctlLaunch1 = (ctl_Launches)page.Controls.Find("ctl_Launches", true).FirstOrDefault();
                if (ctlLaunch1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlLaunch1.COId = coid;
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

        public void FindHistoryPages(int coid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_COHistory ctlHis1 = (ctl_COHistory)page.Controls.Find("ctl_COHistory", true).FirstOrDefault();
                if (ctlHis1 != null)
                {
                    //MessageBox.Show(coid.ToString());
                    ctlHis1.COId = coid;
                    //ctlConf11.COId = coid;
                }
                //break;
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


        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_CustOrder.Text = string.Empty;
        }


        private void frm_ClientOrders_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            txt_CreatDateFrom.Value = null;
            txt_CreatDateTill.Value = null;
            txt_ReqDateFrom.Value = null;
            txt_ReqDateTill.Value = null;
            cmb_Common1.SelectedValue = 0;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();

            try
            {
                COId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                COId = 0;
            }

            try
            {
                ShowDetails(COId);
            }
            catch { }
        }

        private void buttonSpecAny2_Click_1(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            txt_CustArticle.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_ReqDateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CreatDateTill.Value = System.DateTime.Now;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_ReqDateTill.Value = System.DateTime.Now;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_SalesOrders1.SalesOrderId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value);
            }
            catch { }
            if (CheckOldRow() == false)
            {
                try
                {
                    ShowDetails(COId);
                }
                catch { }
            }
        }

        private void cmb_SalesOrders1_SalesOrderChanged(object sender)
        {

        }

        private void cmb_SalesOrders1_SalesOrderSaved(object sender)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (globClass.IsFormAlreadyOpen("frm_AddCODet") || cmb_SalesOrders1.SalesOrderId == 0) return;

            _iscopy = false;

            frm = new frm_AddCODet();
            frm.ctl_CODets1.COId = 0;
            frm.ctl_CODets1.COHeadId = cmb_SalesOrders1.SalesOrderId;


            frm.ctl_CODets1.CODelivPlaceId = cmb_SalesOrders1.ClientId;
            frm.ctl_CODets1.FillAddress(cmb_SalesOrders1.ClientId);
            frm.ctl_CODets1.ShowSaveButton(false);
            frm.ctl_CODets1.COLine = COBll.LastCOLine(cmb_SalesOrders1.SalesOrderId) + 1;
            frm.ctl_CODets1.COStateId = 1;
            frm.ctl_CODets1.COReqDate = System.DateTime.Now.ToShortDateString();

            frm.SaveChanges += new SaveChangesEventHandler(AddCOLine);

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();

        }


        private void btn_Copy_Click(object sender, EventArgs e)
        {
            if (globClass.IsFormAlreadyOpen("frm_AddCODet")) return;

            _iscopy = true;

            frm = new frm_AddCODet();
            frm.ctl_CODets1.IsCopy = -1;
            frm.ctl_CODets1.COId = COBll.COId;
            frm.ctl_CODets1.COHeadId = COBll.COHeadId1;
            frm.ctl_CODets1.COLine = COBll.LastCOLine(COBll.COHeadId1) + 1;

            frm.SaveChanges += new SaveChangesEventHandler(AddCOLine);

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_General_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputGeneral(COBll.COId) });

            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputGeneral(COBll.COId) });

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (globClass.DeleteConfirm() == true)
            {
                MessageBox.Show(COBll.DeleteCOLine(COId));
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void btn_Confirmations_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputConfirmation(COBll.COId) });

            //kryptonDockingManager1.AddDockspace("Control",
            //                                  DockingEdge.Left,
            //                                  new KryptonPage[] { NewInputConfirmation(COBll.COId) });

        }

        private void btn_Batches_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputBatch(COBll.COId) });
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputBatch(COBll.COId) });
        }


        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void frm_ClientOrders_Resize(object sender, EventArgs e)
        {
            if (_Main.WindowState == FormWindowState.Maximized
                /*|| _Main.WindowState == FormWindowState.Normal*/)
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

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            COBll.COId = COId;
            COBll.COHeadId = COBll.COHeadId1;
           
            if (COId != 0)
            {
                string emailaddresses = "";
                string _neworder = "";
                if (COBll.IsNewOrderForArt(COBll.COArtId, COId) == false)
                {
                    emailaddresses = DAL.EmailAddressesByType(1);
                    _neworder = "Repeat";
                }
                else
                {
                    emailaddresses = DAL.EmailAddressesByType(2);
                    _neworder = "New order";
                }
                string _endcustomer = "";
                try { _endcustomer = Helper.GetOneRecord("select company from bas_companies where id = " + COBll.COEndCustId).ToString(); }
                catch { }
                //if (emailaddresses != "")
                //{

                string strMessage = "Order: " + COBll.COHeader;
                strMessage = strMessage + "\r\nCustomer: " + COBll.COCustomer;
                strMessage = strMessage + "\r\nEnd Customer: " + _endcustomer;
                strMessage = strMessage + "\r\nArticle: " + DAL.Article(COBll.COArtId);

                //strMessage = strMessage + "\r\nArticle: " + DAL.Article();
                strMessage = strMessage + "\r\nCust. article: " + COBll.COCustArticle;
                strMessage = strMessage + "\r\nQty: " + COBll.COQty;
                //strMessage = strMessage + System.Environment.NewLine + "PCB: " + COBll.QPCBText;
                strMessage = strMessage + "\r\nStages: " + COBll.COStages;
                strMessage = strMessage + "\r\nLead week: " + COBll.COLeadWeek;
                strMessage = strMessage + "\r\nComments: " + COBll.COComments;
                strMessage = strMessage + "\r\n" + _neworder;
                MyHelper.SendMessage(emailaddresses, "Order: " + COBll.COHeader, strMessage);

            }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputHistory(COBll.COId) });
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void btn_Deliveries_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputDelivery(COBll.COId) });
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
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

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                           DockingEdge.Left,
                                           new KryptonPage[] { NewInputInvoices(COBll.COId) });
        }

        private void btn_Launches_Click(object sender, EventArgs e)
        {
            int _coid = 0;

            try
            {
                _coid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }


            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputBatchLaunches(_coid) });
        }

        private void btn_Invoices_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                            DockingEdge.Left,
                                            new KryptonPage[] { NewInputInvoices(COBll.COId) });
        }

        private void btn_AwaitingCost_Click(object sender, EventArgs e)
        {

        }

        private void btn_MakeCOAsPO_Click(object sender, EventArgs e)
        {
            if (globClass.ConfirmMessage("CO for PO registration", "Are you sure you want to register CO as PO?", "CO as PO registration") == true)
            {
                MessageBox.Show(COBll.MakeCOasPO(COId));
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void btn_CapacityAnalyze_Click(object sender, EventArgs e)
        {
            int _days = 0;
            DataTable datacos = new DataTable();
            datacos.Columns.Add("id", typeof(int));

            foreach (DataGridViewRow row in this.gv_List.SelectedRows)
            {
                DataRow dr = datacos.NewRow();
                dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                datacos.Rows.Add(dr);
            }

            if (datacos.Rows.Count > 0)
            {
                frm_cmbNumber frm = new frm_cmbNumber();
                frm.HeaderText = "Enter production days";
                frm.LabelText = "Production days:";
                frm.FormNumber = 1;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (frm.FormNumber != 0)
                    {
                        _days = Convert.ToInt32(frm.FormNumber);
                        var _query = "sp_SelectCOCapacity";

                        var sqlparams = new List<SqlParameter>
                        {
                            new SqlParameter("@days",SqlDbType.Int){Value = _days },
                            new SqlParameter("@tablescos", SqlDbType.Structured) { TypeName = "UT_IDs", Value = datacos}

                        };


                        Template_DataGridView frmt = new Template_DataGridView();

                        frmt.Text = "Stage needs (workers count) ";
                        frmt.Query = _query;
                        frmt.SqlParams = sqlparams;
                        frmt.Show();
                    }
                }



            }
        }
    }

    #endregion


}
