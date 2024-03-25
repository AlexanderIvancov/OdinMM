using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Register;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Warehouse.StockIn
{
    public delegate int ReceiveSIId();

    public partial class frm_StockInwards : BaseForm
    {
        public frm_StockInwards()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "IncomeDocs.xls", this.Name);
        }

        #region Variables

        frm_AddStockIn frm = null;
        frm_EditStockIn frmEdit = null;
        frm_AddStockInFromPO frmwiz = null;

        public static event ReceiveSIId ReceiveId;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        StockIn_BLL SIBll = new StockIn_BLL();
        Reg_BLL RegBll = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();

        public ctl_StockInPO ctlPO = null;
        public ctl_StockInRests ctlIn = null;
        public ctl_StockInComponents ctlComponents = null;
        public Odin.Warehouse.History.ctl_IncomeTracing ctlTracing = null;
        public int ControlWidth = 250;

        //frm_AddPODets frm = null;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        int _sender = 0;

        public int SIId
        {
            get;
            set;
        }

        public int _PrevId = 0;

        public double Total
        {
            get { return Convert.ToDouble(txt_Total.Text); }
            set { txt_Total.Text = value.ToString(); }
        }
        public double TotalVat
        {
            get { return Convert.ToDouble(txt_TotalVat.Text); }
            set { txt_TotalVat.Text = value.ToString(); }
        }

        public double TotalWithVat
        {
            get { return Convert.ToDouble(txt_TotalWithVat.Text); }
            set { txt_TotalWithVat.Text = value.ToString(); }
        }

        public double TotalSelection
        {
            get { return Convert.ToDouble(txt_TotalSel.Text); }
            set { txt_TotalSel.Text = value.ToString(); }
        }

        #endregion

        #region Methods

        public void DisableActionButtons()
        {
            bn_List.Visible = false;
            //btn_AddFromPO.Enabled = false;
            //btn_Edit.Enabled = false;
            //btn_AddNew.Enabled = false;
        }

        public void ClearFilter()
        {
            cmb_IncomeDoc1.IncomeDocId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            txt_FirmArt.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_CreatDateFrom.Value = null; //Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();

        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_state"].Value) == -1)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                
            }
        }

        public void RecalcTotals(string _document, int _headid)
        {
            //double _total = 0;
            //double _totalvat = 0;
            //double _totalwithvat = 0;
            //double _additcost = 0;
            string _cur = "€";
            //double _vat = 0;

            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    try
            //    {
            //        if (row.Cells["cn_name"].Value.ToString() == _document)
            //        {
            //            _total = _total + Math.Round(Convert.ToDouble(row.Cells["cn_total"].Value), 2, MidpointRounding.AwayFromZero);
            //            _totalvat = _totalvat + Math.Round(Convert.ToDouble(row.Cells["cn_totalvat"].Value), 2, MidpointRounding.AwayFromZero);
            //            _totalwithvat = _totalwithvat + Math.Round(Convert.ToDouble(row.Cells["cn_totalwithvat"].Value), 2, MidpointRounding.AwayFromZero);
            //            _cur = row.Cells["cn_currency"].Value.ToString();
            //            if (Convert.ToInt32(row.Cells["cn_vat"].Value) != 0)
            //                _vat = Convert.ToInt32(row.Cells["cn_vat"].Value);
            //        }
            //    }
            //    catch{ }
            //}

            //_additcost = Convert.ToDouble(Helper.GetOneRecord("select top 1 isnull(additcost, 0) as additcost from sto_stockinhead where id = " + _headid));

            //Total = Math.Round(_total, 2) + _additcost;
            //TotalVat = Math.Round(_totalvat, 2) + Math.Round((_additcost / 100 * _vat), 2);
            //TotalWithVat = Math.Round(_totalwithvat, 2) + Math.Round(_additcost + (_additcost / 100 * _vat), 2);

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 * FROM vw_IncomeTotals WHERE headid = " + _headid.ToString(), conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Total = Math.Round(Convert.ToDouble(dr["total"]), 2, MidpointRounding.AwayFromZero);
                    TotalVat = Math.Round(Convert.ToDouble(dr["totalvatsum"]), 2, MidpointRounding.AwayFromZero);
                    TotalWithVat = Math.Round(Convert.ToDouble(dr["totalwithvatsum"]), 2, MidpointRounding.AwayFromZero);
                    _cur = dr["currency"].ToString();
                }
            }
            else
            {
                Total = 0;
                TotalVat = 0;
                TotalWithVat = 0;
                _cur = "";
            }

            lbl_Total.Text = "Total for document (" + _cur + "):";
            lbl_Vat.Text = "VAT (" + _cur + "):";
            lbl_TotalVat.Text = "Total + VAT (" + _cur + "):";
        }
        public void bw_List(object sender, DoWorkEventArgs e)
        {
                      
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = (DataTable)Helper.getSP("sp_StockIncomesPortfolio", cmb_IncomeDoc1.IncomeDocId, cmb_Types1.TypeId, cmb_Firms1.FirmId, chk_State.Checked == true ? -1 : 0,
                                            cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(), txt_FirmArt.Text, txt_Comments.Text,
                                            cmb_StockInTypes1.StockMovTypeId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
                try
                {
                    RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
                }
                catch { }

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        private void AddStockIn(object sender)
        {
            //frm.Close();
            bwStart(bw_List);
        }

        private void EditStockIn(object sender)
        {
            frmEdit.Close();
            bwStart(bw_List);
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

        private KryptonPage NewInputPO(string Article, int InId, int ArtId)
        {
            ctlPO = new ctl_StockInPO();
            ControlWidth = ctlPO.Width;

            ctlPO.IdIn = InId;
            ctlPO.FillPOs(InId);
            ctlPO.ArtId = ArtId;
           
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("PO's details ", 1, ctlPO, ctlPO.Width);
        }

        private KryptonPage NewInputComponents(int InId)
        {
            ctlComponents = new ctl_StockInComponents();
            ControlWidth = ctlComponents.Width;

            ctlComponents.IdIn = InId;
            ctlComponents.FillComponents(InId);
          
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Components details ", 1, ctlComponents, ctlComponents.Width);
        }

        private KryptonPage NewInputIn(string Article, int InId, int ArtId)
        {
            ctlIn = new ctl_StockInRests();
            ControlWidth = ctlIn.Width;

            ctlIn.Id = InId;
            ctlIn.ArticleId = ArtId;

            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Rests details ", 1, ctlIn, ctlIn.Width);
        }

        private KryptonPage NewInputTracing(int idin)
        {
            ctlTracing = new Odin.Warehouse.History.ctl_IncomeTracing();
            ControlWidth = ctlTracing.Width;
            
            ctlTracing.IdIn = idin;
            //MessageBox.Show(ctl.Width.ToString());

            return NewPage("Income tracing ", 1, ctlTracing, ctlTracing.Width);
        }

        private bool CheckOldRow()
        {

            try
            {
                SIId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                SIId = 0;
            }

            if (_PrevId == SIId)
            {
                return true;
            }
            else
            {
                _PrevId = SIId;
                return false;
            }
        }

        public void ShowDetails(int idin)
        {
            int _artid = 0;
            int _headid = 0;
            string _docname = "";

            try { _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value);
                _docname = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
            }
            catch { }

            if (_headid != 0)
                cmb_IncomeDoc1.IncomeDocId = _headid;
            RecalcTotals(_docname, _headid);

            FindPOPages(idin, _artid);
            FindRestsPages(idin, _artid);
            FindComponentPages(idin);
            FindIncomeTracingPages(idin);
        }

        public void FindPOPages(int idin, int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_StockInPO ctlPO1 = (ctl_StockInPO)page.Controls.Find("ctl_StockInPO", true).FirstOrDefault();
                if (ctlPO1 != null)
                {
                    ctlPO1.IdIn = idin;
                    ctlPO1.ArtId = artid;
                    ctlPO1.FillPOs(idin);                   
                }
                //break;
            }
        }

        public void FindComponentPages(int idin)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_StockInComponents ctlComponents1 = (ctl_StockInComponents)page.Controls.Find("ctl_StockInComponents", true).FirstOrDefault();
                if (ctlComponents1 != null)
                {
                    ctlComponents1.IdIn = idin;
                    ctlComponents1.FillComponents(idin);
                }
                //break;
            }
        }

        public void FindRestsPages(int idin, int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_StockInRests ctlRests1 = (ctl_StockInRests)page.Controls.Find("ctl_StockInRests", true).FirstOrDefault();
                if (ctlRests1 != null)
                {
                    ctlRests1.Id = idin;
                    ctlRests1.ArticleId = artid;
                    //ctlRests1.FillPOs(idin);
                }
                //break;
            }
        }

        public void FindIncomeTracingPages(int idin)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                Odin.Warehouse.History.ctl_IncomeTracing ctlTracing1 = (Odin.Warehouse.History.ctl_IncomeTracing)page.Controls.Find("ctl_IncomeTracing", true).FirstOrDefault();
                if (ctlTracing1 != null)
                {
                    ctlTracing1.IdIn = idin;
                    //ctlRests1.FillPOs(idin);
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
            //MessageBox.Show(ColumnName);
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
           
            SetCellsColor();
            try
            {
                RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
            }
            catch { }
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
            try
            {
                RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
            }
            catch { }
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
            try
            {
                RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
            }
            catch { }
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            SetCellsColor();
            try
            {
                RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
            }
            catch { }
        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for delivery notes list";
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

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CreatDateTill.Value = System.DateTime.Now;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_FirmArt.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void frm_StockInwards_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(/*kryptonSplitContainer1.Panel2*/kryptonPanel3, w);
            kryptonDockingManager1.ManageFloating(this);

            Helper.LoadColumns(gv_List, this.Name);
            txt_CreatDateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
            
        }


        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (cmb_IncomeDoc1.IncomeDocId != 0)
            {
                frm = new frm_AddStockIn();
                frm.ctl_StockInDets1.HeadId = cmb_IncomeDoc1.IncomeDocId;
                frm.ctl_StockInDets1.SupId = cmb_IncomeDoc1.SupplierId;

                RegBll.FirmId = cmb_IncomeDoc1.SupplierId;
                frm.ctl_StockInDets1.Vat = RegBll.CountryVAT;


                frm.StockInLineSaved += new StockInSavedEventHandler(AddStockIn);

                frm.Show(); frm.GetKryptonFormFields();
            }
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frmEdit = new frm_EditStockIn();
            frmEdit.ctl_StockInEdit1.Id = SIId;
            frmEdit.ctl_StockInEdit1.EditSendStockInId += new EditStockInIdSendingEventHandler(EditStockIn);

            frmEdit.Show();

        }

        #endregion

        private void btn_General_Click(object sender, EventArgs e)
        {

        }

        private void btn_POrders_Click(object sender, EventArgs e)
        {
            string _article = "";
            int _artid = 0;

            try
            {
                _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputPO(_article, SIId, _artid) });
        }

        private void btn_Rests_Click(object sender, EventArgs e)
        {
            string _article = "";
            int _artid = 0;

            try
            {
                _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputIn(_article, SIId, _artid) });
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(SIId);
            }
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }


        private void btn_Copy_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {
                int _res = Convert.ToInt32(Helper.getSP("sp_DeleteStockInLine", _id));
                if (_res == -1)
                    MessageBox.Show("Delete was successful!");
                else if (_res == 0-1)
                    MessageBox.Show("Delete was not successful! There are movements on this line!");
                else
                    MessageBox.Show("Delete was not successful! Error during operation!");
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void frm_StockInwards_Resize(object sender, EventArgs e)
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

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEdit = new frm_EditStockIn();
            frmEdit.ctl_StockInEdit1.Id = SIId;
            frmEdit.ctl_StockInEdit1.EditSendStockInId += new EditStockInIdSendingEventHandler(EditStockIn);

            frmEdit.Show();
        }

        private void cmb_IncomeDoc1_IncomeDocChanged(object sender)
        {
            if (cmb_IncomeDoc1._isedit == true)
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_AddService_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddServiceCost frm = new frm_AddServiceCost();
                frm.FillList();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in frm.gv_List.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["chk_Add"].Value) != 0)
                            Helper.getSP("sp_AddStockInServiceCost", _id, Convert.ToInt32(row.Cells["cn_id"].Value), Convert.ToDouble(row.Cells["cn_unitprice"].Value));
                    }
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                }
            }
        }

        private void btn_Tracing_Click(object sender, EventArgs e)
        {
            int _idin = 0;
            try { _idin = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputTracing(_idin) });
        }

        private void btn_AddFromPO_Click(object sender, EventArgs e)
        {
            if (cmb_IncomeDoc1.IncomeDocId != 0)
            {
                frmwiz = new frm_AddStockInFromPO();
                frmwiz.HeadId = cmb_IncomeDoc1.IncomeDocId;
                frmwiz.CurId = cmb_IncomeDoc1.CurId;
                frmwiz.StockLineSaved += new StockSavedEventHandler(AddStockIn);

                frmwiz.Show();

            }
        }

        private void btn_Components_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputComponents(SIId) });
        }

        private void txt_CreatDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateFrom.Value = txt_CreatDateFrom.Value == null ? System.DateTime.Now : txt_CreatDateFrom.Value;
        }

        private void txt_CreatDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateTill.Value = txt_CreatDateTill.Value == null ? System.DateTime.Now : txt_CreatDateTill.Value;
        }
    }
}
