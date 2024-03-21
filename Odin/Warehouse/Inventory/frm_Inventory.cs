using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.Deliveries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Warehouse.Inventory
{
    public delegate int ReceiveMyLabel();
    public delegate int ReceiveMyArt();

    public partial class frm_Inventory : BaseForm
    {
        public frm_Inventory()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "StockInventory.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
        PrinterLabels PrintLabels = new PrinterLabels();

        public static event ReceiveMyLabel ReceiveLabel;
        public static event ReceiveMyArt ReceiveArt;

        //public ctl_PODets ctlGen = null;
        public ctl_StockArtDets ctlGen = null;
        public ctl_StockLabel ctlLabel = null;
        public ctl_LabelTracing ctlTracing = null;

        public int ControlWidth = 250;


        //frm_AddPODets frm = null;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int ArtId
        {
            get;
            set;
        }

        public int rLabel
        {
            get; set;
        }

        public int Label
        {
            get
            {
                try { return Convert.ToInt32(txt_Label.Text); }
                catch { return 0; }
            }
            set { txt_Label.Text = value.ToString(); }
        }
        public int _PrevId = 0;
        public int _PrevLabel = 0;
        //public double Total
        //{
        //    get { return Convert.ToDouble(txt_Total.Text); }
        //    set { txt_Total.Text = value.ToString(); }
        //}
        //public double TotalVat
        //{
        //    get { return Convert.ToDouble(txt_TotalVat.Text); }
        //    set { txt_TotalVat.Text = value.ToString(); }
        //}

        //public double TotalWithVat
        //{
        //    get { return Convert.ToDouble(txt_TotalWithVat.Text); }
        //    set { txt_TotalWithVat.Text = value.ToString(); }
        //}

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
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            cmb_Places1.PlaceId = 0;
            cmb_Department1.DeptId = 0;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
            cmb_InvNumber.sCurrentValue = "";
        }
        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Gainsboro;
            }
        }

        public void RecalcTotals()
        {
            //double _total = 0;
            //double _totalvat = 0;
            //double _totalwithvat = 0;

            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    _total = _total + Math.Round(Convert.ToDouble(row.Cells["cn_total"].Value), 2, MidpointRounding.AwayFromZero);
            //    _totalvat = _totalvat + Math.Round(Convert.ToDouble(row.Cells["cn_totalvat"].Value), 2, MidpointRounding.AwayFromZero);
            //    _totalwithvat = _totalwithvat + Math.Round(Convert.ToDouble(row.Cells["cn_totalwithvat"].Value), 2, MidpointRounding.AwayFromZero);
            //}

            //Total = _total;
            //TotalVat = _totalvat;
            //TotalWithVat = _totalwithvat;
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = (DataTable)Helper.getSP("sp_StockInventory", cmb_Articles1.ArticleId, cmb_Types1.TypeId, cmb_Firms1.FirmId, cmb_Articles1.Article, cmb_Places1.PlaceId,
                                                       cmb_Department1.DeptId, Label, chk_GroupByPlaces.Checked == true ? -1 : 0, cmb_Batches1.BatchId,
                                                       chk_Totals.Checked == true ? -1 : 0, cmb_InvNumber.sCurrentValue);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
                RecalcTotals();

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public void bw_ListOnDate(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = (DataTable)Helper.getSP("sp_StockInventoryOnDate", cmb_Articles1.ArticleId, cmb_Types1.TypeId, cmb_Firms1.FirmId, cmb_Articles1.Article, cmb_Places1.PlaceId,
                                                        cmb_Department1.DeptId, Label, chk_GroupByPlaces.Checked == true ? -1 : 0, cmb_Batches1.BatchId,
                                                        chk_Totals.Checked == true ? -1 : 0, txt_Date.Value.ToShortDateString().Trim());

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
                RecalcTotals();

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
                ArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch
            {
                ArtId = 0;
            }

            if (_PrevId == ArtId)
            {
                return true;
            }
            else
            {
                _PrevId = ArtId;
                return false;
            }
        }

        private bool CheckOldRowLabel()
        {

            int _label = 0;
            try { _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value); }
            catch { }

            if (_PrevLabel == _label)
            {
                return true;
            }
            else
            {
                _PrevLabel = _label;
                return false;
            }
        }

        public void ShowDetails(int artid)
        {
            //int _label = 0;
            //try { _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value); }
            //catch { }

            FindGenPages(artid);


            //if (_label != _PrevLabel)
            //{
            //    _PrevLabel = _label;
            //    FindLabelPages(_label);
            //}


        }

        public void ShowLabelDetails()
        {
            int _label = 0;
            try { _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value); }
            catch { }

            FindLabelPages(_label);

        }

        public void ShowLabelTracing()
        {
            int _label = 0;
            try { _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value); }
            catch { }

            FindLabelTracing(_label);

        }


        public void ChangeLabelSelection(object sender)
        {
            int _label = ReceiveLabel();

            FindLabelPages(_label);
            //ShowDetails();
        }

        public void ChangeGenSelection(object sender)
        {
            int _artid = ReceiveArt();

            bwStart(bw_List);

            FindGenPages(_artid);
            
        }

        public void UpdatingList(object sender)
        {
            bwStart(bw_List);
            //ShowDetails();
        }

        public void FindGenPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_StockArtDets ctlGen1 = (ctl_StockArtDets)page.Controls.Find("ctl_StockArtDets", true).FirstOrDefault();
                if (ctlGen1 != null)
                {
                    ctlGen1.ArticleId = artid;


                    //ctlGen1.CheckEmpty();
                }
                //break;
            }
        }

        public void FindLabelPages(int label)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_StockLabel ctlLabel1 = (ctl_StockLabel)page.Controls.Find("ctl_StockLabel", true).FirstOrDefault();
                if (ctlLabel1 != null)
                {
                    ctlLabel1.txt_Label.Text = label.ToString();
                    //ctlGen.SendLabel += new LabelSendingEventHandler(ChangeLabelSelection);

                    //ctlGen1.CheckEmpty();
                }
                //break;
            }
        }

        public void FindLabelTracing(int label)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_LabelTracing ctlTracing1 = (ctl_LabelTracing)page.Controls.Find("ctl_LabelTracing", true).FirstOrDefault();
                if (ctlTracing1 != null)
                {
                    ctlTracing1.txt_Label.Text = label.ToString();
                }
                //break;
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

        private KryptonPage NewInputGeneral(string Article, int ArtId)
        {
            ctlGen = new ctl_StockArtDets();
            ControlWidth = ctlGen.Width;


            ctlGen.cmb_Articles1.ArticleId = ArtId;
            ctlGen.SetCellsColor();
            ctlGen.SendLabel += new LabelSendingEventHandler(ChangeLabelSelection);

            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Rest details ", 1, ctlGen, ctlGen.Width);
        }

        private KryptonPage NewInputLabel(int Label)
        {
            ctlLabel = new ctl_StockLabel();
            ControlWidth = ctlLabel.Width;


            ctlLabel.txt_Label.Text = Label.ToString();
            ctlLabel.SaveLabel += new LabelSavingEventHandler(ChangeGenSelection);
            ctlLabel.RemoveReservation += new RemovingReservationEventHandler(UpdatingList);

            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Label details ", 1, ctlLabel, ctlLabel.Width);
        }

        private KryptonPage NewInputTracing(int Label)
        {
            ctlTracing = new ctl_LabelTracing();
            ControlWidth = ctlTracing.Width;


            ctlTracing.txt_Label.Text = Label.ToString();
            //MessageBox.Show(ctl.Width.ToString());

            return NewPage("Label tracing ", 1, ctlTracing, ctlTracing.Width);
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
            RecalcTotals();
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
            RecalcTotals();

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
            RecalcTotals();
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            SetCellsColor();
            RecalcTotals();

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


        private void frm_Inventory_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);

            txt_Date.Value = System.DateTime.Now;
        }


        private void btn_General_Click(object sender, EventArgs e)
        {
            string _article = "";
            try { _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString(); }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputGeneral(_article, ArtId) });
        }

        private void btn_Rests_Click(object sender, EventArgs e)
        {
            int _label = 0;
            try { _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value); }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputLabel(_label) });
        }

        private void btn_Tracing_Click(object sender, EventArgs e)
        {
            int _label = 0;
            try { _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value); }
            catch { }

            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputTracing(_label) });
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(ArtId);
            }

            if (CheckOldRowLabel() == false)
            {
                ShowLabelDetails();
                ShowLabelTracing();
            }
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        #endregion

        private void frm_Inventory_Resize(object sender, EventArgs e)
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_PrintLabel_Click(object sender, EventArgs e)
        {
            frm_Print frm = new frm_Print();
            frm.cmb_LabPrinter1.ShowDefaults();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintLabels.PrinterIp = frm.IP_Address;
                PrintLabels.PrinterDPI = frm.Printer_DPI;

                if (gv_List.SelectedRows.Count > 0)
                {

                    foreach (DataGridViewRow row in this.gv_List.SelectedRows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_label"].Value) != 0
                            && DAL.CheckMSL(Convert.ToInt32(row.Cells["cn_artid"].Value)) != "0")
                        {
                            // MessageBox.Show(Convert.ToInt32(row.Cells["cn_label"].Value).ToString());
                            var sqlparamsfields = new List<SqlParameter>()
                        {
                            new SqlParameter("@id",SqlDbType.Int) {Value = Convert.ToInt32(row.Cells["cn_label"].Value)},
                            new SqlParameter("@qty",SqlDbType.Float) {Value = Convert.ToDouble(row.Cells["cn_qtyrest"].Value)},
                            new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                        };
                        if (frm.LabelQty != 0)
                            PrintLabels.PrintLabel(PrintLabels.LabelConstructor(1, "sp_SelectStockLabelDetsPrint", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                            //Thread.Sleep(2000);
                        }
                    }
                }
                else
                {
                    if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value) != 0
                            && DAL.CheckMSL(Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value)) != "0")
                    {
                        // MessageBox.Show(Convert.ToInt32(row.Cells["cn_label"].Value).ToString());
                        var sqlparamsfields = new List<SqlParameter>()
                        {
                            new SqlParameter("@id",SqlDbType.Int) {Value = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value)},
                            new SqlParameter("@qty",SqlDbType.Float) {Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qtyrest"].Value)},
                            new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                        };
                        if (frm.LabelQty != 0)
                            PrintLabels.PrintLabel(PrintLabels.LabelConstructor(1, "sp_SelectStockLabelDetsPrint", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                        //Thread.Sleep(2000);
                    }
                }
                
            }
            else
            { }
        }

        private void btn_OnDate_Click(object sender, EventArgs e)
        {
            bwStart(bw_ListOnDate);
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_TrayTube_Click(object sender, EventArgs e)
        {
            int _artid = 0;
            try
            {
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch { _artid = cmb_Articles1.ArticleId; }

            frm_Print frm = new frm_Print();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT TOP 1 lt.ip, sp.name, sp.dpi from bas_labeltemplate lt inner join sys_printers sp on sp.ipadress = lt.ip where lt.id = 6", sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            try
            {
                frm.IP_Address = dt.Rows[0]["ip"].ToString();
                frm.Printer_DPI = Convert.ToInt32(dt.Rows[0]["dpi"].ToString());
                frm.PrinterName = dt.Rows[0]["name"].ToString();
            }
            catch
            {
                frm.cmb_LabPrinter1.ShowDefaults();
            }
                        
            DialogResult result = frm.ShowDialog();
           

            if (result == DialogResult.OK)
            {
                
                PrintLabels.PrinterIp = frm.IP_Address;
                PrintLabels.PrinterDPI = frm.Printer_DPI;

                if (gv_List.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in this.gv_List.SelectedRows)
                    {
                        {
                            var sqlparamsfields = new List<SqlParameter>()
                        {
                            new SqlParameter("@artid",SqlDbType.Int) {Value = Convert.ToInt32(row.Cells["cn_artid"].Value)},
                            new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                        };
                            if (frm.LabelQty != 0)
                                PrintLabels.PrintLabel(PrintLabels.LabelConstructor(6, "sp_SelectStockLabelTrayTube", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);

                        }
                    }
                }
                else
                {
                   var sqlparamsfields = new List<SqlParameter>()
                        {
                            new SqlParameter("@artid",SqlDbType.Int) {Value = _artid},
                            new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                        };
                    if (frm.LabelQty != 0)
                        PrintLabels.PrintLabel(PrintLabels.LabelConstructor(6, "sp_SelectStockLabelTrayTube", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
    
                }
            }
            else
            { }
        }


        private void btn_Packing_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_DNPicking")) return;

            frm_DNPicking frm = new frm_DNPicking();
            frm.HeaderText = "Packed final commodity ";
            frm.FillList();
            DialogResult result = frm.ShowDialog();
            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
        }

        private void btn_ClientRM_Click(object sender, EventArgs e)
        {
            string strBeg = cmb_Articles1.Article;

            var _query = "sp_SelectClientRMAnalyzis";

            var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@strBeg",SqlDbType.NVarChar) {Value = strBeg},
                };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Stock value ";
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }
    }
}
