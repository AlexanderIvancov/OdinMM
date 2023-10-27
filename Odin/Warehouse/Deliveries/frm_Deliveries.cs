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
using Odin.CMB_Components.BLL;

namespace Odin.Warehouse.Deliveries
{
    public partial class frm_Deliveries : BaseForm
    {
        public frm_Deliveries()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "DeliveryNotes.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DelivNote_BLL DNBll = new DelivNote_BLL();
        Reg_BLL RegBll = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
        PrinterLabels PrintLabels = new PrinterLabels();
        frm_PrintDelivEtiquettes frmprint = null;
        CMB_BLL cmbBLL = new CMB_BLL();

        public double Total
        {
            get { return Convert.ToDouble(txt_Total.Text); }
            set { txt_Total.Text = value.ToString(); }
        }
        
        private frm_EditDelivDets frm = null;

        public int ControlWidth = 250;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public ctl_Packing ctlPack = null;
        public ctl_Invoices ctlInvoices = null;
        public ctl_Incomes ctlIncomes = null;

        public int DNId
        {
            get;
            set;
        }

        public int _PrevId = 0;

        public DateTime DateFromD
        {
            get { return Convert.ToDateTime(txt_CreatDateFrom.Value); }
            set { txt_CreatDateFrom.Value = value; }
        }

        public DateTime DateTillD
        {
            get { return Convert.ToDateTime(txt_CreatDateTill.Value); }
            set { txt_CreatDateTill.Value = value; }
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

        private KryptonPage NewInputPackage(int DelivNoteId, string DelivNote)
        {
            ctlPack = new ctl_Packing();
            ControlWidth = ctlPack.Width;

            ctlPack.DelivNoteId = DelivNoteId;
            
            ctlPack.HeaderText = "Not packed delivery note lines for: " + DelivNote;
            //ctlGen.cmb_Articles1.ArticleId = ArtId;
            //ctlGen.SendArtId += new ArtIdSendingEventHandler(ChangeArtIdSelection);
            
            return NewPage("Packing", 1, ctlPack, ctlPack.Width);
        }

        private KryptonPage NewInputInvoices(int delivnoteid)
        {
            ctlInvoices = new ctl_Invoices();
            ControlWidth = ctlInvoices.Width;
            ctlInvoices.DelivId = delivnoteid;

            return NewPage("Invoices ", 1, ctlInvoices, ctlInvoices.Width);
        }

        private KryptonPage NewInputIncomes(int delivnoteid)
        {
            ctlIncomes = new ctl_Incomes();
            ControlWidth = ctlIncomes.Width;
            ctlIncomes.DelivId = delivnoteid;

            return NewPage("Invoices ", 1, ctlIncomes, ctlIncomes.Width);
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
            cmb_DeliveryNotes1.DelivNoteId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            txt_FirmArt.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_CreatDateFrom.Value = null; //Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
            txt_ConfOrder.Text = string.Empty;
            txt_CustOrder.Text = string.Empty;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
        }

        public void SetCellsColor()
        { }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(cmb_DeliveryNotes1.DelivNoteId.ToString());
            var data = DelivNote_BLL.getDeliveries(cmb_DeliveryNotes1.DelivNoteId, cmb_Types1.TypeId, cmb_Firms1.FirmId, cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(), txt_FirmArt.Text, txt_Comments.Text, txt_ConfOrder.Text, txt_CustOrder.Text,
                                            cmb_Batches1.BatchId);

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

            //foreach (DataColumn column in data.Columns)
            //{
            //    MessageBox.Show(column.ColumnName);
            //}
        }

        private void AddLineIn(object sender)
        {
            //frm.Close();
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        private void AddBoxes(DataGridView gridview)
        {
            gridview.EndEdit();
            foreach (DataGridViewRow row in gridview.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_add"].Value) == -1)
                {
                    DNBll.AddDeliveryLineFromBox(cmb_DeliveryNotes1.DelivNoteId,
                             Convert.ToInt32(row.Cells["cn_id"].Value),
                             Convert.ToInt32(row.Cells["cn_artid"].Value),
                             Convert.ToInt32(row.Cells["cn_coid"].Value),
                             Convert.ToInt32(row.Cells["cn_inid"].Value),
                             row.Cells["cn_custarticle"].Value.ToString(),
                             Convert.ToDouble(row.Cells["cn_qty"].Value),
                             row.Cells["cn_comments"].Value.ToString(),
                             row.Cells["cn_custcode"].Value.ToString());
                }
            }

            //frm.Close();
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        private void MapBoxes(DataGridView gridview)
        {
            string _res = "";
            gridview.EndEdit();

            int _delivid = 0;
            try { _delivid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }
            if (_delivid != 0)
            {
                foreach (DataGridViewRow row in gridview.Rows)
                {
                    if (Convert.ToInt32(row.Cells["chk_add"].Value) == -1)
                    {
                        _res = DNBll.MapDeliveryLineFromBox(cmb_DeliveryNotes1.DelivNoteId,
                                 Convert.ToInt32(row.Cells["cn_id"].Value),
                                _delivid);
                        MessageBox.Show(_res);
                    }
                }

                //frm.Close();
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        public void ShowDetails(int ddid)
        {
            //gv_List.Invoke(new MethodInvoker(delegate {
                DNBll.DelivNoteId = ddid;

                if (ddid != 0)
                    cmb_DeliveryNotes1.DelivNoteId = DNBll.DHeadId;


                int _headid = 0;
                string _docname = "";

                try
                {
                    _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value);
                    _docname = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();

                }
                catch { }

                RecalcTotals(_docname, _headid);

                FindPackPages(DNBll.DHeadId, cmb_DeliveryNotes1.DelivNote);
                FindInvoicesPages(DNId);
                FindIncomesPages(DNId);
            //}));

        }

        private bool CheckOldRow()
        {

            try
            {
                DNId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                DNId = 0;
            }

            if (_PrevId == DNId)
            {
                return true;
            }
            else
            {
                _PrevId = DNId;
                return false;
            }
        }

        public void ShowEdit()
        {
            //if (globClass.IsFormAlreadyOpen("frm_EditDelivDets")) return;
            gv_List.Invoke(new MethodInvoker(delegate {
                int _id = 0;
                try
                {
                    _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                }
                catch { }
                // MessageBox.Show(_id.ToString());
                if (_id != 0)
                {
                    DNBll.DelivNoteId = _id;

                    frm = new frm_EditDelivDets();
                    frm.Id = _id;
                    frm.NetWeight = DNBll.DNetWeight;
                    frm.BrutWeight = DNBll.DBrutWeight;
                    frm.QtyPack = DNBll.DQtyPack;
                    frm.Package = DNBll.DPackage;
                    frm.CustArticle = DNBll.DCustArticle;
                    frm.CustCode = DNBll.DCustCode;
                    frm.Comments = DNBll.DComments;
                    frm.Return = DNBll.DReturn;
                    frm.ArtId = DNBll.DArtId;
                    frm.ConfOrder = DNBll.DConfOrder;
                    frm.DelivDate = DNBll.DDelivDate;
                    frm.Customer = DNBll.DCustomer;
                    frm.Unit = DNBll.DUnit;
                    frm.COId = DNBll.DCOId;
                    frm.Qty = DNBll.DQty;

                    frm.ShowDets();

                    frm.SaveChanges += new SaveChangesDNEventHandler(EditDelivNoteDets);

                    frm.Show();
                }
            }));
           
        }

        public void EditDelivNoteDets(int id)
        {
            int _coid = 0;

            frm.gv_Delivery.EndEdit();

            foreach (DataGridViewRow row in frm.gv_Delivery.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_Add"].Value) == -1)
                {
                    _coid = Convert.ToInt32(row.Cells["cn_dcoid"].Value);
                    break;
                }
                
                
            }
            //MessageBox.Show(id.ToString());
            DNBll.EditDeliveryLine(id, frm.CustArticle, frm.Comments, frm.NetWeight, frm.BrutWeight, frm.CustCode, frm.QtyPack, frm.Package, frm.Return, _coid);

            frm.Close();
            bwStart(bw_List);
        }

        public void FindPackPages(int _delivnoteid, string _delivnote)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Packing ctlPack1 = (ctl_Packing)page.Controls.Find("ctl_Packing", true).FirstOrDefault();
                if (ctlPack1 != null)
                {
                    ctlPack1.DelivNoteId = _delivnoteid;
                    ctlPack1.HeaderText = "Not packed delivery note lines for: " + _delivnote;
                }
                //break;
            }
        }

        public void FindInvoicesPages(int _delivnoteid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Invoices ctlInvoices = (ctl_Invoices)page.Controls.Find("ctl_Invoices", true).FirstOrDefault();
                if (ctlInvoices != null)
                {
                    ctlInvoices.DelivId = _delivnoteid;
                }
                //break;
            }
        }

        public void FindIncomesPages(int _delivnoteid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Incomes ctlIncomes = (ctl_Incomes)page.Controls.Find("ctl_Incomes", true).FirstOrDefault();
                if (ctlIncomes != null)
                {
                    ctlIncomes.DelivId = _delivnoteid;
                }
                //break;
            }
        }

        public void RecalcTotals(string _document, int _headid)
        {
            double _total = 0;
            //double _totalvat = 0;
            //double _totalwithvat = 0;
            string _cur = "€";
            //double _vat = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                try
                {
                    if (row.Cells["cn_name"].Value.ToString() == _document)
                    {
                        _total = _total + Math.Round(Convert.ToDouble(row.Cells["cn_costpricebr"].Value) * Convert.ToDouble(row.Cells["cn_qty"].Value), 2, MidpointRounding.AwayFromZero);
                    }
                }
                catch { }
            }

            Total = _total;

            lbl_Total.Invoke(new MethodInvoker(delegate { lbl_Total.Text = "Total for document (" + _cur + "):"; }));
            
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

            frm.HeaderText = "Select view for deliveries list";
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

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CreatDateTill.Value = System.DateTime.Now;
        }

        private void frm_Deliveries_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(/*kryptonSplitContainer1.Panel2*/kryptonPanel3, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            txt_CreatDateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            int _headid = 0;
            string _docname = "";

            try
            {
                _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value);
                _docname = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();

            }
            catch { }

            RecalcTotals(_docname, _headid);
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_ConfOrder.Text = string.Empty;
        }


        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_FirmArt.Text = string.Empty;
        }
        
        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_CustOrder.Text = string.Empty;
        }

        private void frm_Deliveries_Resize(object sender, EventArgs e)
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

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (cmb_DeliveryNotes1.DelivNoteId != 0)
            {
                frm_AddDeliveryDets frm = new frm_AddDeliveryDets();
                frm.HeadId = cmb_DeliveryNotes1.DelivNoteId;
                cmbBLL.DelivNoteHeadId = cmb_DeliveryNotes1.DelivNoteId;
                frm.Internal = cmbBLL.DLNInternal;
                //MessageBox.Show(frm.Internal.ToString());
                frm.HeaderText = "Add delivery line for: " + cmb_DeliveryNotes1.DelivNote;

                frm.StockDeliveryLineSaved += new StockDeliverySavedEventHandler(AddLineIn);

                frm.Show();
            }
            else
            {
                MessageBox.Show("Please add delivery note!");
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            frm_rptDeliveryNote frm = new frm_rptDeliveryNote();
            frm.DelivNoteType = 1;
            frm.HeadId = cmb_DeliveryNotes1.DelivNoteId;
            frm.HeaderText = "Print delivery note: " + cmb_DeliveryNotes1.DelivNote;
            frm.FillReport();          

            frm.Show();
        }

        #endregion

        private void cmb_Week1_SelectedValueChanged(object sender)
        {
            DateFromD = cmb_Week1.FirstDateOfWeek;
            DateTillD = cmb_Week1.LastDateOfWeek;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {

                DNBll.DeleteDeliveryLine(_id);
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
                ShowDetails(DNId);
            }
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }
       
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputPackage(cmb_DeliveryNotes1.DelivNoteId, cmb_DeliveryNotes1.DelivNote) });
        }

        private void txt_CreatDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateFrom.Value = txt_CreatDateFrom.Value == null ? System.DateTime.Now : txt_CreatDateFrom.Value;
        }

        private void txt_CreatDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateTill.Value = txt_CreatDateTill.Value == null ? System.DateTime.Now : txt_CreatDateTill.Value;
        }

        private void btn_PrintLabel_Click(object sender, EventArgs e)
        {
            frmprint = new frm_PrintDelivEtiquettes();

            string _article = "";
            string _customer = "";
            string _custart = "";
            string _batch = "";
            string _order = "";
            
            try { _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
                _customer = gv_List.CurrentRow.Cells["cn_findestination"].Value.ToString();
                _custart = gv_List.CurrentRow.Cells["cn_custart"].Value.ToString();
                _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString();
                _order = gv_List.CurrentRow.Cells["cn_conforder"].Value.ToString();
            }
            catch { }

            frmprint.Batch = _batch;
            frmprint.Article = _article;
            frmprint.Customer = _customer;
            frmprint.CustArticle = _custart;
            frmprint.Order = _order;
            frmprint.PackingLabelTemplate = 4;
            frmprint.cmb_LabPrinter1.ShowDefaults();
            
            frmprint.SendPrint += new SendPrintEventHandler(SendToPrint);

            frmprint.Show();

        }
        private void SendToPrint(object sender)
        {
           
            PrintLabels.PrinterIp = frmprint.IP_Address;
            PrintLabels.PrinterDPI = frmprint.Printer_DPI;

            if (frmprint.BoxFrom > frmprint.BoxTill)
                MessageBox.Show("Please check boxes!!!");
            else
            {
                for (int i = frmprint.BoxFrom; i <= frmprint.BoxTill; i++)
                {
                    var sqlparamsfields = new List<SqlParameter>()
                    {
                        new SqlParameter("@article",SqlDbType.NVarChar) {Value = frmprint.Article},
                        new SqlParameter("@customer",SqlDbType.NVarChar) {Value = frmprint.Customer},
                        new SqlParameter("@custarticle",SqlDbType.NVarChar) {Value = frmprint.CustArticle},
                        new SqlParameter("@batch",SqlDbType.NVarChar) {Value = frmprint.Batch},
                        new SqlParameter("@order",SqlDbType.NVarChar) {Value = frmprint.Order},
                        new SqlParameter("@qty",SqlDbType.Float) {Value = frmprint.Qty},
                        new SqlParameter("@weight",SqlDbType.Float) {Value = frmprint.Weight},
                        new SqlParameter("@boxno",SqlDbType.Int) {Value = i},
                        new SqlParameter("@comments",SqlDbType.NVarChar) {Value = frmprint.Comments},
                        new SqlParameter("@labelqty",SqlDbType.Int) {Value = frmprint.LabelQty}
                    };
                    //MessageBox.Show(i.ToString());
                    //txt_Comments.Text = PrintLabels.LabelConstructor(frmprint.PackingLabelTemplate, "sp_SelectStockPackLabelPrint", sqlparamsfields.ToArray());
                    PrintLabels.PrintLabel(PrintLabels.LabelConstructor(frmprint.PackingLabelTemplate, "sp_SelectStockPackLabelPrint", sqlparamsfields.ToArray()), 1/*frmprint.LabelQty*/);
                }
                frmprint.Close();
            }
        }

        private void btn_Invoices_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputInvoices(DNId) });
        }

        private void btn_DNPicking_Click(object sender, EventArgs e)
        {

            if (cmb_DeliveryNotes1.DelivNoteId != 0)
            {
                if (glob_Class.IsFormAlreadyOpen("frm_DNPicking")) return;

                frm_DNPicking frm = new frm_DNPicking();
                frm.HeaderText = "Add boxes for: " + cmb_DeliveryNotes1.DelivNote;
                frm.AddBoxes += new AddDeliveryBoxesEventHandler(AddBoxes);
                frm.FillList();
                DialogResult result = frm.ShowDialog();
                frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
                //if (result == DialogResult.OK)
                //{

                //}
            }
            else
            {
                MessageBox.Show("Please add delivery note!");
            }
        }

        private void btn_DNMapping_Click(object sender, EventArgs e)
        {
            if (cmb_DeliveryNotes1.DelivNoteId != 0)
            {
                if (glob_Class.IsFormAlreadyOpen("frm_DNPicking")) return;

                frm_DNPicking frm = new frm_DNPicking();
                frm.HeaderText = "Add boxes for: " + cmb_DeliveryNotes1.DelivNote;
                frm.AddBoxes += new AddDeliveryBoxesEventHandler(MapBoxes);
                frm.FillList();
                DialogResult result = frm.ShowDialog();
                frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
                //if (result == DialogResult.OK)
                //{

                //}
            }
            else
            {
                MessageBox.Show("Please add delivery note!");
            }
        }

        private void btn_Content_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _package = "";

            try {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _package = gv_List.CurrentRow.Cells["cn_package"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                var _query = "sp_SelectDelivNotePackageContent";

                var sqlparams = new List<SqlParameter>()
                    {
                        new SqlParameter("@id",SqlDbType.Int) {Value = _id},
                        new SqlParameter("@package",SqlDbType.NVarChar) {Value = _package}
                    };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Package content for: " + _package;
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show();
            }
        }

        private void btn_Incomes_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                             DockingEdge.Left,
                                             new KryptonPage[] { NewInputIncomes(DNId) });
        }
    }
}
