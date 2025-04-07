namespace Odin.Planning
{
    partial class frm_ProductionPlanning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public Main _Main;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProductionPlanning));
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_Comments = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.mnu_LinesP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForP = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchP = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByP = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExludingSelP = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterP = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminP = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_Planned = new System.Windows.Forms.BindingSource(this.components);
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_batchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyinbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sumbefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_teortime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_prodplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.btn_Validate = new System.Windows.Forms.ToolStripButton();
            this.btn_Invalidate = new System.Windows.Forms.ToolStripButton();
            this.btn_Check = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel14 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel28 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CGPA = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel29 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NGPA = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel30 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel13 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel25 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CIPA = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel26 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NIPA = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel27 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel12 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel22 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CFQC = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel23 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NFQC = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel24 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel10 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CFTA = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NFTA = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel18 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel9 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CQTHT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NQTHT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel8 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CTHT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NTHT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel11 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel19 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CXRay = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel20 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NXray = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QCSMT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NQSMT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CSMT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NSMT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.gv_Planned = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_pbatchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_partid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_particle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_psecname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pqtyinbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_punit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pplanned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pweekoper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_Planned = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Delete1 = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel1 = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel34 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.btn_Launches = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Weeks = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel32 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Week1 = new Odin.CMB_Components.Week.cmb_Week();
            this.txt_StartTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_StartFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel31 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel33 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chk_Active = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cmb_SalesOrdersWithLines1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrdersWithLines();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.btn_Refresh1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mni_Holidays = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.mnu_LinesP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Planned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel14)).BeginInit();
            this.kryptonPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel13)).BeginInit();
            this.kryptonPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel12)).BeginInit();
            this.kryptonPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel10)).BeginInit();
            this.kryptonPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel9)).BeginInit();
            this.kryptonPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).BeginInit();
            this.kryptonPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel11)).BeginInit();
            this.kryptonPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Planned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Planned)).BeginInit();
            this.bn_Planned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Lines
            // 
            this.mnu_Lines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Lines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_Comments,
            this.mni_Holidays,
            this.mni_FilterFor,
            this.mni_Search,
            this.mni_FilterBy,
            this.mni_FilterExcludingSel,
            this.mni_RemoveFilter,
            this.mni_Copy,
            this.toolStripSeparator2,
            this.mni_Admin});
            this.mnu_Lines.Name = "mnu_Requests";
            this.mnu_Lines.Size = new System.Drawing.Size(211, 233);
            this.mnu_Lines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_Lines_Opening);
            // 
            // mni_Comments
            // 
            this.mni_Comments.Image = global::Odin.Global_Resourses.Favorites_24x24;
            this.mni_Comments.Name = "mni_Comments";
            this.mni_Comments.Size = new System.Drawing.Size(210, 22);
            this.mni_Comments.Text = "Add comments";
            this.mni_Comments.Click += new System.EventHandler(this.mni_Comments_Click);
            // 
            // mni_FilterFor
            // 
            this.mni_FilterFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterFor.Name = "mni_FilterFor";
            this.mni_FilterFor.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterFor.TextChanged += new System.EventHandler(this.mni_FilterFor_TextChanged);
            // 
            // mni_Search
            // 
            this.mni_Search.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_Search.Name = "mni_Search";
            this.mni_Search.Size = new System.Drawing.Size(210, 22);
            this.mni_Search.Text = "Search for record";
            this.mni_Search.Click += new System.EventHandler(this.mni_Search_Click);
            // 
            // mni_FilterBy
            // 
            this.mni_FilterBy.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterBy.Name = "mni_FilterBy";
            this.mni_FilterBy.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterBy.Text = "Filter by selection";
            this.mni_FilterBy.Click += new System.EventHandler(this.mni_FilterBy_Click);
            // 
            // mni_FilterExcludingSel
            // 
            this.mni_FilterExcludingSel.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSel.Name = "mni_FilterExcludingSel";
            this.mni_FilterExcludingSel.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSel.Text = "Filter excluding selection";
            this.mni_FilterExcludingSel.Click += new System.EventHandler(this.mni_FilterExcludingSel_Click);
            // 
            // mni_RemoveFilter
            // 
            this.mni_RemoveFilter.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilter.Name = "mni_RemoveFilter";
            this.mni_RemoveFilter.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilter.Text = "Remove filter";
            this.mni_RemoveFilter.Click += new System.EventHandler(this.mni_RemoveFilter_Click);
            // 
            // mni_Copy
            // 
            this.mni_Copy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_Copy.Name = "mni_Copy";
            this.mni_Copy.Size = new System.Drawing.Size(210, 22);
            this.mni_Copy.Text = "Copy";
            this.mni_Copy.Click += new System.EventHandler(this.mni_Copy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_Admin
            // 
            this.mni_Admin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_Admin.Name = "mni_Admin";
            this.mni_Admin.Size = new System.Drawing.Size(210, 22);
            this.mni_Admin.Text = "List settings";
            this.mni_Admin.Visible = false;
            this.mni_Admin.Click += new System.EventHandler(this.mni_Admin_Click);
            // 
            // mnu_LinesP
            // 
            this.mnu_LinesP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_LinesP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForP,
            this.mni_SearchP,
            this.mni_FilterByP,
            this.mni_FilterExludingSelP,
            this.mni_RemoveFilterP,
            this.mni_CopyP,
            this.toolStripSeparator5,
            this.mni_AdminP});
            this.mnu_LinesP.Name = "mnu_Requests";
            this.mnu_LinesP.Size = new System.Drawing.Size(211, 167);
            this.mnu_LinesP.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesP_Opening);
            // 
            // mni_FilterForP
            // 
            this.mni_FilterForP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForP.Name = "mni_FilterForP";
            this.mni_FilterForP.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForP.TextChanged += new System.EventHandler(this.mni_FilterForP_TextChanged);
            // 
            // mni_SearchP
            // 
            this.mni_SearchP.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchP.Name = "mni_SearchP";
            this.mni_SearchP.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchP.Text = "Search for record";
            this.mni_SearchP.Click += new System.EventHandler(this.mni_SearchP_Click);
            // 
            // mni_FilterByP
            // 
            this.mni_FilterByP.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByP.Name = "mni_FilterByP";
            this.mni_FilterByP.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByP.Text = "Filter by selection";
            this.mni_FilterByP.Click += new System.EventHandler(this.mni_FilterByP_Click);
            // 
            // mni_FilterExludingSelP
            // 
            this.mni_FilterExludingSelP.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExludingSelP.Name = "mni_FilterExludingSelP";
            this.mni_FilterExludingSelP.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExludingSelP.Text = "Filter excluding selection";
            this.mni_FilterExludingSelP.Click += new System.EventHandler(this.mni_FilterExcludingSelP_Click);
            // 
            // mni_RemoveFilterP
            // 
            this.mni_RemoveFilterP.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterP.Name = "mni_RemoveFilterP";
            this.mni_RemoveFilterP.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterP.Text = "Remove filter";
            this.mni_RemoveFilterP.Click += new System.EventHandler(this.mni_RemoveFilterP_Click);
            // 
            // mni_CopyP
            // 
            this.mni_CopyP.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyP.Name = "mni_CopyP";
            this.mni_CopyP.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyP.Text = "Copy";
            this.mni_CopyP.Click += new System.EventHandler(this.mni_CopyP_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminP
            // 
            this.mni_AdminP.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminP.Name = "mni_AdminP";
            this.mni_AdminP.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminP.Text = "List settings";
            this.mni_AdminP.Click += new System.EventHandler(this.mni_AdminP_Click);
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_batchid,
            this.cn_batch,
            this.cn_artid,
            this.cn_article,
            this.cn_secname,
            this.cn_qtyinbatch,
            this.cn_unit,
            this.cn_week,
            this.cn_conforder,
            this.cn_customer,
            this.cn_stages,
            this.cn_sumbefore,
            this.cn_teortime,
            this.cn_prodplace});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(72, 121);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 10;
            this.gv_List.Size = new System.Drawing.Size(1812, 515);
            this.gv_List.TabIndex = 25;
            this.gv_List.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gv_List_CellFormatting);
            this.gv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValidated);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            this.gv_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_List_KeyDown);
            // 
            // cn_batchid
            // 
            this.cn_batchid.DataPropertyName = "id";
            this.cn_batchid.Frozen = true;
            this.cn_batchid.HeaderText = "batchid";
            this.cn_batchid.Name = "cn_batchid";
            this.cn_batchid.Visible = false;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.Frozen = true;
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 50F;
            this.cn_artid.Frozen = true;
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.Width = 50;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 120F;
            this.cn_article.Frozen = true;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.Width = 120;
            // 
            // cn_secname
            // 
            this.cn_secname.DataPropertyName = "secname";
            this.cn_secname.FillWeight = 120F;
            this.cn_secname.Frozen = true;
            this.cn_secname.HeaderText = "2nd name";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.Width = 120;
            // 
            // cn_qtyinbatch
            // 
            this.cn_qtyinbatch.DataPropertyName = "qtyinbatch";
            this.cn_qtyinbatch.FillWeight = 80F;
            this.cn_qtyinbatch.Frozen = true;
            this.cn_qtyinbatch.HeaderText = "Qty in batch";
            this.cn_qtyinbatch.Name = "cn_qtyinbatch";
            this.cn_qtyinbatch.Width = 80;
            // 
            // cn_unit
            // 
            this.cn_unit.DataPropertyName = "unit";
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.Frozen = true;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.Width = 40;
            // 
            // cn_week
            // 
            this.cn_week.DataPropertyName = "leadweek";
            this.cn_week.FillWeight = 80F;
            this.cn_week.Frozen = true;
            this.cn_week.HeaderText = "Lead week";
            this.cn_week.Name = "cn_week";
            this.cn_week.Width = 80;
            // 
            // cn_conforder
            // 
            this.cn_conforder.DataPropertyName = "conforder";
            this.cn_conforder.Frozen = true;
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.Frozen = true;
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            // 
            // cn_stages
            // 
            this.cn_stages.DataPropertyName = "stages";
            this.cn_stages.Frozen = true;
            this.cn_stages.HeaderText = "Stages";
            this.cn_stages.Name = "cn_stages";
            // 
            // cn_sumbefore
            // 
            this.cn_sumbefore.DataPropertyName = "sumbefore";
            this.cn_sumbefore.HeaderText = "sumbefore";
            this.cn_sumbefore.Name = "cn_sumbefore";
            this.cn_sumbefore.Visible = false;
            // 
            // cn_teortime
            // 
            this.cn_teortime.DataPropertyName = "teortime";
            this.cn_teortime.HeaderText = "teortime";
            this.cn_teortime.Name = "cn_teortime";
            this.cn_teortime.Visible = false;
            // 
            // cn_prodplace
            // 
            this.cn_prodplace.DataPropertyName = "prodplace";
            this.cn_prodplace.HeaderText = "Prod. place";
            this.cn_prodplace.Name = "cn_prodplace";
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = this.bindingNavigatorCountItem;
            this.bn_List.DeleteItem = null;
            this.bn_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btn_Excel,
            this.btn_Validate,
            this.btn_Invalidate,
            this.btn_Check});
            this.bn_List.Location = new System.Drawing.Point(72, 636);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(1812, 25);
            this.bn_List.TabIndex = 24;
            this.bn_List.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Excel
            // 
            this.btn_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall1;
            this.btn_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(23, 22);
            this.btn_Excel.Text = "Export into excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Validate
            // 
            this.btn_Validate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Validate.Image = global::Odin.Global_Resourses.Ok;
            this.btn_Validate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Validate.Name = "btn_Validate";
            this.btn_Validate.Size = new System.Drawing.Size(23, 22);
            this.btn_Validate.Text = "Validate";
            this.btn_Validate.Click += new System.EventHandler(this.btn_Validate_Click);
            // 
            // btn_Invalidate
            // 
            this.btn_Invalidate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Invalidate.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Invalidate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Invalidate.Name = "btn_Invalidate";
            this.btn_Invalidate.Size = new System.Drawing.Size(23, 22);
            this.btn_Invalidate.Text = "Cancel validation";
            this.btn_Invalidate.Click += new System.EventHandler(this.btn_Invalidate_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Check.Image = global::Odin.Global_Resourses.OptionsFollowUp;
            this.btn_Check.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(23, 22);
            this.btn_Check.Text = "Check qty";
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonPanel14);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel13);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel12);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel10);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel9);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel8);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel11);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel7);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel6);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel4.Location = new System.Drawing.Point(72, 661);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(1812, 78);
            this.kryptonPanel4.TabIndex = 22;
            // 
            // kryptonPanel14
            // 
            this.kryptonPanel14.Controls.Add(this.kryptonLabel28);
            this.kryptonPanel14.Controls.Add(this.txt_CGPA);
            this.kryptonPanel14.Controls.Add(this.kryptonLabel29);
            this.kryptonPanel14.Controls.Add(this.txt_NGPA);
            this.kryptonPanel14.Controls.Add(this.kryptonLabel30);
            this.kryptonPanel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel14.Location = new System.Drawing.Point(1020, 0);
            this.kryptonPanel14.Name = "kryptonPanel14";
            this.kryptonPanel14.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel14.TabIndex = 13;
            // 
            // kryptonLabel28
            // 
            this.kryptonLabel28.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel28.Name = "kryptonLabel28";
            this.kryptonLabel28.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel28.TabIndex = 4;
            this.kryptonLabel28.Values.Text = "Coef.:";
            // 
            // txt_CGPA
            // 
            this.txt_CGPA.AllowDecimalSeparator = true;
            this.txt_CGPA.AllowSpace = false;
            this.txt_CGPA.Location = new System.Drawing.Point(57, 49);
            this.txt_CGPA.Name = "txt_CGPA";
            this.txt_CGPA.Size = new System.Drawing.Size(54, 23);
            this.txt_CGPA.TabIndex = 3;
            this.txt_CGPA.Text = "1";
            this.txt_CGPA.TextChanged += new System.EventHandler(this.txt_CGPA_TextChanged);
            // 
            // kryptonLabel29
            // 
            this.kryptonLabel29.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel29.Name = "kryptonLabel29";
            this.kryptonLabel29.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel29.TabIndex = 2;
            this.kryptonLabel29.Values.Text = "Needs:";
            // 
            // txt_NGPA
            // 
            this.txt_NGPA.AllowDecimalSeparator = false;
            this.txt_NGPA.AllowSpace = false;
            this.txt_NGPA.Location = new System.Drawing.Point(57, 25);
            this.txt_NGPA.Name = "txt_NGPA";
            this.txt_NGPA.ReadOnly = true;
            this.txt_NGPA.Size = new System.Drawing.Size(54, 23);
            this.txt_NGPA.TabIndex = 1;
            this.txt_NGPA.Text = "0";
            // 
            // kryptonLabel30
            // 
            this.kryptonLabel30.Location = new System.Drawing.Point(37, 5);
            this.kryptonLabel30.Name = "kryptonLabel30";
            this.kryptonLabel30.Size = new System.Drawing.Size(40, 19);
            this.kryptonLabel30.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel30.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel30.TabIndex = 0;
            this.kryptonLabel30.Values.Text = "GPA";
            // 
            // kryptonPanel13
            // 
            this.kryptonPanel13.Controls.Add(this.kryptonLabel25);
            this.kryptonPanel13.Controls.Add(this.txt_CIPA);
            this.kryptonPanel13.Controls.Add(this.kryptonLabel26);
            this.kryptonPanel13.Controls.Add(this.txt_NIPA);
            this.kryptonPanel13.Controls.Add(this.kryptonLabel27);
            this.kryptonPanel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel13.Location = new System.Drawing.Point(902, 0);
            this.kryptonPanel13.Name = "kryptonPanel13";
            this.kryptonPanel13.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel13.TabIndex = 12;
            // 
            // kryptonLabel25
            // 
            this.kryptonLabel25.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel25.Name = "kryptonLabel25";
            this.kryptonLabel25.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel25.TabIndex = 4;
            this.kryptonLabel25.Values.Text = "Coef.:";
            // 
            // txt_CIPA
            // 
            this.txt_CIPA.AllowDecimalSeparator = true;
            this.txt_CIPA.AllowSpace = false;
            this.txt_CIPA.Location = new System.Drawing.Point(57, 49);
            this.txt_CIPA.Name = "txt_CIPA";
            this.txt_CIPA.Size = new System.Drawing.Size(54, 23);
            this.txt_CIPA.TabIndex = 3;
            this.txt_CIPA.Text = "1";
            this.txt_CIPA.TextChanged += new System.EventHandler(this.txt_CIPA_TextChanged);
            // 
            // kryptonLabel26
            // 
            this.kryptonLabel26.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel26.Name = "kryptonLabel26";
            this.kryptonLabel26.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel26.TabIndex = 2;
            this.kryptonLabel26.Values.Text = "Needs:";
            // 
            // txt_NIPA
            // 
            this.txt_NIPA.AllowDecimalSeparator = false;
            this.txt_NIPA.AllowSpace = false;
            this.txt_NIPA.Location = new System.Drawing.Point(57, 25);
            this.txt_NIPA.Name = "txt_NIPA";
            this.txt_NIPA.ReadOnly = true;
            this.txt_NIPA.Size = new System.Drawing.Size(54, 23);
            this.txt_NIPA.TabIndex = 1;
            this.txt_NIPA.Text = "0";
            // 
            // kryptonLabel27
            // 
            this.kryptonLabel27.Location = new System.Drawing.Point(37, 5);
            this.kryptonLabel27.Name = "kryptonLabel27";
            this.kryptonLabel27.Size = new System.Drawing.Size(33, 19);
            this.kryptonLabel27.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel27.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel27.TabIndex = 0;
            this.kryptonLabel27.Values.Text = "IPA";
            // 
            // kryptonPanel12
            // 
            this.kryptonPanel12.Controls.Add(this.kryptonLabel22);
            this.kryptonPanel12.Controls.Add(this.txt_CFQC);
            this.kryptonPanel12.Controls.Add(this.kryptonLabel23);
            this.kryptonPanel12.Controls.Add(this.txt_NFQC);
            this.kryptonPanel12.Controls.Add(this.kryptonLabel24);
            this.kryptonPanel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel12.Location = new System.Drawing.Point(784, 0);
            this.kryptonPanel12.Name = "kryptonPanel12";
            this.kryptonPanel12.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel12.TabIndex = 11;
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel22.TabIndex = 4;
            this.kryptonLabel22.Values.Text = "Coef.:";
            // 
            // txt_CFQC
            // 
            this.txt_CFQC.AllowDecimalSeparator = true;
            this.txt_CFQC.AllowSpace = false;
            this.txt_CFQC.Location = new System.Drawing.Point(57, 49);
            this.txt_CFQC.Name = "txt_CFQC";
            this.txt_CFQC.Size = new System.Drawing.Size(54, 23);
            this.txt_CFQC.TabIndex = 3;
            this.txt_CFQC.Text = "1";
            this.txt_CFQC.TextChanged += new System.EventHandler(this.txt_CFQC_TextChanged);
            // 
            // kryptonLabel23
            // 
            this.kryptonLabel23.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel23.Name = "kryptonLabel23";
            this.kryptonLabel23.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel23.TabIndex = 2;
            this.kryptonLabel23.Values.Text = "Needs:";
            // 
            // txt_NFQC
            // 
            this.txt_NFQC.AllowDecimalSeparator = false;
            this.txt_NFQC.AllowSpace = false;
            this.txt_NFQC.Location = new System.Drawing.Point(57, 25);
            this.txt_NFQC.Name = "txt_NFQC";
            this.txt_NFQC.ReadOnly = true;
            this.txt_NFQC.Size = new System.Drawing.Size(54, 23);
            this.txt_NFQC.TabIndex = 1;
            this.txt_NFQC.Text = "0";
            // 
            // kryptonLabel24
            // 
            this.kryptonLabel24.Location = new System.Drawing.Point(37, 5);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.Size = new System.Drawing.Size(40, 19);
            this.kryptonLabel24.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel24.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel24.TabIndex = 0;
            this.kryptonLabel24.Values.Text = "FQC";
            // 
            // kryptonPanel10
            // 
            this.kryptonPanel10.Controls.Add(this.kryptonLabel16);
            this.kryptonPanel10.Controls.Add(this.txt_CFTA);
            this.kryptonPanel10.Controls.Add(this.kryptonLabel17);
            this.kryptonPanel10.Controls.Add(this.txt_NFTA);
            this.kryptonPanel10.Controls.Add(this.kryptonLabel18);
            this.kryptonPanel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel10.Location = new System.Drawing.Point(666, 0);
            this.kryptonPanel10.Name = "kryptonPanel10";
            this.kryptonPanel10.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel10.TabIndex = 10;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel16.TabIndex = 4;
            this.kryptonLabel16.Values.Text = "Coef.:";
            // 
            // txt_CFTA
            // 
            this.txt_CFTA.AllowDecimalSeparator = true;
            this.txt_CFTA.AllowSpace = false;
            this.txt_CFTA.Location = new System.Drawing.Point(57, 49);
            this.txt_CFTA.Name = "txt_CFTA";
            this.txt_CFTA.Size = new System.Drawing.Size(54, 23);
            this.txt_CFTA.TabIndex = 3;
            this.txt_CFTA.Text = "1";
            this.txt_CFTA.TextChanged += new System.EventHandler(this.txt_CFTA_TextChanged);
            // 
            // kryptonLabel17
            // 
            this.kryptonLabel17.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel17.Name = "kryptonLabel17";
            this.kryptonLabel17.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel17.TabIndex = 2;
            this.kryptonLabel17.Values.Text = "Needs:";
            // 
            // txt_NFTA
            // 
            this.txt_NFTA.AllowDecimalSeparator = false;
            this.txt_NFTA.AllowSpace = false;
            this.txt_NFTA.Location = new System.Drawing.Point(57, 25);
            this.txt_NFTA.Name = "txt_NFTA";
            this.txt_NFTA.ReadOnly = true;
            this.txt_NFTA.Size = new System.Drawing.Size(54, 23);
            this.txt_NFTA.TabIndex = 1;
            this.txt_NFTA.Text = "0";
            // 
            // kryptonLabel18
            // 
            this.kryptonLabel18.Location = new System.Drawing.Point(37, 5);
            this.kryptonLabel18.Name = "kryptonLabel18";
            this.kryptonLabel18.Size = new System.Drawing.Size(37, 19);
            this.kryptonLabel18.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel18.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel18.TabIndex = 0;
            this.kryptonLabel18.Values.Text = "FTA";
            // 
            // kryptonPanel9
            // 
            this.kryptonPanel9.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel9.Controls.Add(this.txt_CQTHT);
            this.kryptonPanel9.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel9.Controls.Add(this.txt_NQTHT);
            this.kryptonPanel9.Controls.Add(this.kryptonLabel15);
            this.kryptonPanel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel9.Location = new System.Drawing.Point(548, 0);
            this.kryptonPanel9.Name = "kryptonPanel9";
            this.kryptonPanel9.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel9.TabIndex = 9;
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel13.TabIndex = 4;
            this.kryptonLabel13.Values.Text = "Coef.:";
            // 
            // txt_CQTHT
            // 
            this.txt_CQTHT.AllowDecimalSeparator = true;
            this.txt_CQTHT.AllowSpace = false;
            this.txt_CQTHT.Location = new System.Drawing.Point(57, 49);
            this.txt_CQTHT.Name = "txt_CQTHT";
            this.txt_CQTHT.Size = new System.Drawing.Size(54, 23);
            this.txt_CQTHT.TabIndex = 3;
            this.txt_CQTHT.Text = "1";
            this.txt_CQTHT.TextChanged += new System.EventHandler(this.txt_CQTHT_TextChanged);
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel14.TabIndex = 2;
            this.kryptonLabel14.Values.Text = "Needs:";
            // 
            // txt_NQTHT
            // 
            this.txt_NQTHT.AllowDecimalSeparator = false;
            this.txt_NQTHT.AllowSpace = false;
            this.txt_NQTHT.Location = new System.Drawing.Point(57, 25);
            this.txt_NQTHT.Name = "txt_NQTHT";
            this.txt_NQTHT.ReadOnly = true;
            this.txt_NQTHT.Size = new System.Drawing.Size(54, 23);
            this.txt_NQTHT.TabIndex = 1;
            this.txt_NQTHT.Text = "0";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(26, 5);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(62, 19);
            this.kryptonLabel15.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel15.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel15.TabIndex = 0;
            this.kryptonLabel15.Values.Text = "QC THT";
            // 
            // kryptonPanel8
            // 
            this.kryptonPanel8.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel8.Controls.Add(this.txt_CTHT);
            this.kryptonPanel8.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel8.Controls.Add(this.txt_NTHT);
            this.kryptonPanel8.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel8.Location = new System.Drawing.Point(430, 0);
            this.kryptonPanel8.Name = "kryptonPanel8";
            this.kryptonPanel8.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel8.TabIndex = 8;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel10.TabIndex = 4;
            this.kryptonLabel10.Values.Text = "Coef.:";
            // 
            // txt_CTHT
            // 
            this.txt_CTHT.AllowDecimalSeparator = true;
            this.txt_CTHT.AllowSpace = false;
            this.txt_CTHT.Location = new System.Drawing.Point(57, 49);
            this.txt_CTHT.Name = "txt_CTHT";
            this.txt_CTHT.Size = new System.Drawing.Size(54, 23);
            this.txt_CTHT.TabIndex = 3;
            this.txt_CTHT.Text = "1";
            this.txt_CTHT.TextChanged += new System.EventHandler(this.txt_CTHT_TextChanged);
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel11.TabIndex = 2;
            this.kryptonLabel11.Values.Text = "Needs:";
            // 
            // txt_NTHT
            // 
            this.txt_NTHT.AllowDecimalSeparator = false;
            this.txt_NTHT.AllowSpace = false;
            this.txt_NTHT.Location = new System.Drawing.Point(57, 25);
            this.txt_NTHT.Name = "txt_NTHT";
            this.txt_NTHT.ReadOnly = true;
            this.txt_NTHT.Size = new System.Drawing.Size(54, 23);
            this.txt_NTHT.TabIndex = 1;
            this.txt_NTHT.Text = "0";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(37, 5);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(38, 19);
            this.kryptonLabel12.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel12.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel12.TabIndex = 0;
            this.kryptonLabel12.Values.Text = "THT";
            // 
            // kryptonPanel11
            // 
            this.kryptonPanel11.Controls.Add(this.kryptonLabel19);
            this.kryptonPanel11.Controls.Add(this.txt_CXRay);
            this.kryptonPanel11.Controls.Add(this.kryptonLabel20);
            this.kryptonPanel11.Controls.Add(this.txt_NXray);
            this.kryptonPanel11.Controls.Add(this.kryptonLabel21);
            this.kryptonPanel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel11.Location = new System.Drawing.Point(312, 0);
            this.kryptonPanel11.Name = "kryptonPanel11";
            this.kryptonPanel11.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel11.TabIndex = 7;
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel19.TabIndex = 4;
            this.kryptonLabel19.Values.Text = "Coef.:";
            // 
            // txt_CXRay
            // 
            this.txt_CXRay.AllowDecimalSeparator = true;
            this.txt_CXRay.AllowSpace = false;
            this.txt_CXRay.Location = new System.Drawing.Point(57, 49);
            this.txt_CXRay.Name = "txt_CXRay";
            this.txt_CXRay.Size = new System.Drawing.Size(54, 23);
            this.txt_CXRay.TabIndex = 3;
            this.txt_CXRay.Text = "1";
            this.txt_CXRay.TextChanged += new System.EventHandler(this.txt_CXRay_TextChanged);
            // 
            // kryptonLabel20
            // 
            this.kryptonLabel20.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel20.Name = "kryptonLabel20";
            this.kryptonLabel20.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel20.TabIndex = 2;
            this.kryptonLabel20.Values.Text = "Needs:";
            // 
            // txt_NXray
            // 
            this.txt_NXray.AllowDecimalSeparator = false;
            this.txt_NXray.AllowSpace = false;
            this.txt_NXray.Location = new System.Drawing.Point(57, 25);
            this.txt_NXray.Name = "txt_NXray";
            this.txt_NXray.ReadOnly = true;
            this.txt_NXray.Size = new System.Drawing.Size(54, 23);
            this.txt_NXray.TabIndex = 1;
            this.txt_NXray.Text = "0";
            // 
            // kryptonLabel21
            // 
            this.kryptonLabel21.Location = new System.Drawing.Point(37, 5);
            this.kryptonLabel21.Name = "kryptonLabel21";
            this.kryptonLabel21.Size = new System.Drawing.Size(48, 19);
            this.kryptonLabel21.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel21.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel21.TabIndex = 0;
            this.kryptonLabel21.Values.Text = "XRAY";
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel7.Controls.Add(this.txt_QCSMT);
            this.kryptonPanel7.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel7.Controls.Add(this.txt_NQSMT);
            this.kryptonPanel7.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel7.Location = new System.Drawing.Point(194, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel7.TabIndex = 3;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel7.TabIndex = 4;
            this.kryptonLabel7.Values.Text = "Coef.:";
            // 
            // txt_QCSMT
            // 
            this.txt_QCSMT.AllowDecimalSeparator = true;
            this.txt_QCSMT.AllowSpace = false;
            this.txt_QCSMT.Location = new System.Drawing.Point(57, 49);
            this.txt_QCSMT.Name = "txt_QCSMT";
            this.txt_QCSMT.Size = new System.Drawing.Size(54, 23);
            this.txt_QCSMT.TabIndex = 3;
            this.txt_QCSMT.Text = "1";
            this.txt_QCSMT.TextChanged += new System.EventHandler(this.txt_QCSMT_TextChanged);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel8.TabIndex = 2;
            this.kryptonLabel8.Values.Text = "Needs:";
            // 
            // txt_NQSMT
            // 
            this.txt_NQSMT.AllowDecimalSeparator = false;
            this.txt_NQSMT.AllowSpace = false;
            this.txt_NQSMT.Location = new System.Drawing.Point(57, 25);
            this.txt_NQSMT.Name = "txt_NQSMT";
            this.txt_NQSMT.ReadOnly = true;
            this.txt_NQSMT.Size = new System.Drawing.Size(54, 23);
            this.txt_NQSMT.TabIndex = 1;
            this.txt_NQSMT.Text = "0";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(27, 5);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(64, 19);
            this.kryptonLabel9.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel9.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel9.TabIndex = 0;
            this.kryptonLabel9.Values.Text = "QC SMT";
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel6.Controls.Add(this.txt_CSMT);
            this.kryptonPanel6.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel6.Controls.Add(this.txt_NSMT);
            this.kryptonPanel6.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel6.Location = new System.Drawing.Point(76, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(118, 78);
            this.kryptonPanel6.TabIndex = 2;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel6.TabIndex = 4;
            this.kryptonLabel6.Values.Text = "Coef.:";
            // 
            // txt_CSMT
            // 
            this.txt_CSMT.AllowDecimalSeparator = true;
            this.txt_CSMT.AllowSpace = false;
            this.txt_CSMT.Location = new System.Drawing.Point(57, 49);
            this.txt_CSMT.Name = "txt_CSMT";
            this.txt_CSMT.Size = new System.Drawing.Size(54, 23);
            this.txt_CSMT.TabIndex = 3;
            this.txt_CSMT.Text = "1";
            this.txt_CSMT.TextChanged += new System.EventHandler(this.txt_CSMT_TextChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(6, 26);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel5.TabIndex = 2;
            this.kryptonLabel5.Values.Text = "Needs:";
            // 
            // txt_NSMT
            // 
            this.txt_NSMT.AllowDecimalSeparator = false;
            this.txt_NSMT.AllowSpace = false;
            this.txt_NSMT.Location = new System.Drawing.Point(57, 25);
            this.txt_NSMT.Name = "txt_NSMT";
            this.txt_NSMT.ReadOnly = true;
            this.txt_NSMT.Size = new System.Drawing.Size(54, 23);
            this.txt_NSMT.TabIndex = 1;
            this.txt_NSMT.Text = "0";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(37, 5);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(40, 19);
            this.kryptonLabel4.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel4.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.TabIndex = 0;
            this.kryptonLabel4.Values.Text = "SMT";
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.btn_Add);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(76, 78);
            this.kryptonPanel5.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Add.Location = new System.Drawing.Point(13, 16);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(49, 49);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Values.Image = global::Odin.Global_Resourses.edit_add;
            this.btn_Add.Values.Text = "";
            this.btn_Add.Visible = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader2.Location = new System.Drawing.Point(72, 739);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(1812, 36);
            this.kryptonHeader2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonHeader2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonHeader2.TabIndex = 21;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Planned";
            this.kryptonHeader2.Values.Image = global::Odin.Global_Resourses.autostart;
            this.kryptonHeader2.Visible = false;
            // 
            // gv_Planned
            // 
            this.gv_Planned.AllowUserToAddRows = false;
            this.gv_Planned.AllowUserToDeleteRows = false;
            this.gv_Planned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Planned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_pbatchid,
            this.cn_pbatch,
            this.cn_partid,
            this.cn_particle,
            this.cn_psecname,
            this.cn_pqtyinbatch,
            this.cn_punit,
            this.cn_pplanned,
            this.cn_pweekoper,
            this.cn_pconforder,
            this.cn_pcustomer,
            this.cn_diff});
            this.gv_Planned.ContextMenuStrip = this.mnu_LinesP;
            this.gv_Planned.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_Planned.Location = new System.Drawing.Point(72, 775);
            this.gv_Planned.Name = "gv_Planned";
            this.gv_Planned.RowHeadersWidth = 10;
            this.gv_Planned.Size = new System.Drawing.Size(1812, 114);
            this.gv_Planned.TabIndex = 20;
            this.gv_Planned.Visible = false;
            this.gv_Planned.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_Planned_ColumnHeaderMouseClick);
            // 
            // cn_pbatchid
            // 
            this.cn_pbatchid.DataPropertyName = "batchid";
            this.cn_pbatchid.HeaderText = "batchid";
            this.cn_pbatchid.Name = "cn_pbatchid";
            this.cn_pbatchid.Visible = false;
            // 
            // cn_pbatch
            // 
            this.cn_pbatch.DataPropertyName = "batch";
            this.cn_pbatch.HeaderText = "Batch project";
            this.cn_pbatch.Name = "cn_pbatch";
            // 
            // cn_partid
            // 
            this.cn_partid.DataPropertyName = "artid";
            this.cn_partid.FillWeight = 50F;
            this.cn_partid.HeaderText = "Art. id";
            this.cn_partid.Name = "cn_partid";
            this.cn_partid.Width = 50;
            // 
            // cn_particle
            // 
            this.cn_particle.DataPropertyName = "article";
            this.cn_particle.FillWeight = 120F;
            this.cn_particle.HeaderText = "Article";
            this.cn_particle.Name = "cn_particle";
            this.cn_particle.Width = 120;
            // 
            // cn_psecname
            // 
            this.cn_psecname.DataPropertyName = "secname";
            this.cn_psecname.FillWeight = 120F;
            this.cn_psecname.HeaderText = "2nd name";
            this.cn_psecname.Name = "cn_psecname";
            this.cn_psecname.Width = 120;
            // 
            // cn_pqtyinbatch
            // 
            this.cn_pqtyinbatch.DataPropertyName = "qtyinbatch";
            this.cn_pqtyinbatch.FillWeight = 80F;
            this.cn_pqtyinbatch.HeaderText = "Project qty";
            this.cn_pqtyinbatch.Name = "cn_pqtyinbatch";
            this.cn_pqtyinbatch.Width = 80;
            // 
            // cn_punit
            // 
            this.cn_punit.DataPropertyName = "unit";
            this.cn_punit.FillWeight = 40F;
            this.cn_punit.HeaderText = "Unit";
            this.cn_punit.Name = "cn_punit";
            this.cn_punit.Width = 40;
            // 
            // cn_pplanned
            // 
            this.cn_pplanned.DataPropertyName = "plannedqty";
            this.cn_pplanned.HeaderText = "Planned";
            this.cn_pplanned.Name = "cn_pplanned";
            // 
            // cn_pweekoper
            // 
            this.cn_pweekoper.DataPropertyName = "weekoper";
            this.cn_pweekoper.HeaderText = "Oper. week";
            this.cn_pweekoper.Name = "cn_pweekoper";
            // 
            // cn_pconforder
            // 
            this.cn_pconforder.DataPropertyName = "conforder";
            this.cn_pconforder.HeaderText = "Conf. order";
            this.cn_pconforder.Name = "cn_pconforder";
            // 
            // cn_pcustomer
            // 
            this.cn_pcustomer.DataPropertyName = "customer";
            this.cn_pcustomer.HeaderText = "Customer";
            this.cn_pcustomer.Name = "cn_pcustomer";
            // 
            // cn_diff
            // 
            this.cn_diff.DataPropertyName = "diff";
            this.cn_diff.FillWeight = 50F;
            this.cn_diff.HeaderText = "Deficite";
            this.cn_diff.Name = "cn_diff";
            this.cn_diff.Width = 50;
            // 
            // bn_Planned
            // 
            this.bn_Planned.AddNewItem = null;
            this.bn_Planned.CountItem = this.toolStripLabel1;
            this.bn_Planned.DeleteItem = null;
            this.bn_Planned.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Planned.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Planned.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.btn_Delete1,
            this.btn_Excel1});
            this.bn_Planned.Location = new System.Drawing.Point(72, 889);
            this.bn_Planned.MoveFirstItem = this.toolStripButton1;
            this.bn_Planned.MoveLastItem = this.toolStripButton4;
            this.bn_Planned.MoveNextItem = this.toolStripButton3;
            this.bn_Planned.MovePreviousItem = this.toolStripButton2;
            this.bn_Planned.Name = "bn_Planned";
            this.bn_Planned.PositionItem = this.toolStripTextBox1;
            this.bn_Planned.Size = new System.Drawing.Size(1812, 25);
            this.bn_Planned.TabIndex = 19;
            this.bn_Planned.Text = "bn_Planned";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Delete1
            // 
            this.btn_Delete1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Delete1.Image = global::Odin.Global_Resourses.bindingNavigatorDeleteItem_Image;
            this.btn_Delete1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete1.Name = "btn_Delete1";
            this.btn_Delete1.Size = new System.Drawing.Size(23, 22);
            this.btn_Delete1.Text = "Delete line";
            this.btn_Delete1.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Excel1
            // 
            this.btn_Excel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excel1.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall1;
            this.btn_Excel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excel1.Name = "btn_Excel1";
            this.btn_Excel1.Size = new System.Drawing.Size(23, 22);
            this.btn_Excel1.Text = "Export into excel";
            this.btn_Excel1.Click += new System.EventHandler(this.btn_Excel1_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btn_Delete);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 121);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabDock;
            this.kryptonPanel3.Size = new System.Drawing.Size(72, 793);
            this.kryptonPanel3.TabIndex = 14;
            this.kryptonPanel3.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Delete.Location = new System.Drawing.Point(12, 631);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(49, 49);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Values.Image = global::Odin.Global_Resourses.delete2__2_;
            this.btn_Delete.Values.Text = "";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel34);
            this.kryptonPanel2.Controls.Add(this.cmb_Common1);
            this.kryptonPanel2.Controls.Add(this.btn_Launches);
            this.kryptonPanel2.Controls.Add(this.btn_Save);
            this.kryptonPanel2.Controls.Add(this.btn_Print);
            this.kryptonPanel2.Controls.Add(this.txt_Weeks);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel32);
            this.kryptonPanel2.Controls.Add(this.cmb_Week1);
            this.kryptonPanel2.Controls.Add(this.txt_StartTill);
            this.kryptonPanel2.Controls.Add(this.txt_StartFrom);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel31);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel33);
            this.kryptonPanel2.Controls.Add(this.chk_Active);
            this.kryptonPanel2.Controls.Add(this.cmb_SalesOrdersWithLines1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel2.Controls.Add(this.btn_Refresh1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.cmb_Firms1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 36);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1884, 85);
            this.kryptonPanel2.TabIndex = 12;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(1139, 54);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 294;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            this.kryptonButton1.Visible = false;
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel34
            // 
            this.kryptonLabel34.Location = new System.Drawing.Point(695, 19);
            this.kryptonLabel34.Name = "kryptonLabel34";
            this.kryptonLabel34.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel34.TabIndex = 293;
            this.kryptonLabel34.Values.Text = "Prod. place:";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(773, 19);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(148, 20);
            this.cmb_Common1.sTable = "PROD_ProdPlaces";
            this.cmb_Common1.sText_Filled = "place";
            this.cmb_Common1.sTitle = "Production places";
            this.cmb_Common1.TabIndex = 292;
            // 
            // btn_Launches
            // 
            this.btn_Launches.Location = new System.Drawing.Point(1095, 3);
            this.btn_Launches.Name = "btn_Launches";
            this.btn_Launches.Size = new System.Drawing.Size(100, 39);
            this.btn_Launches.TabIndex = 291;
            this.btn_Launches.Values.Image = global::Odin.Global_Resourses.launch;
            this.btn_Launches.Values.Text = "Launches";
            this.btn_Launches.Click += new System.EventHandler(this.btn_Launches_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Location = new System.Drawing.Point(1002, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 39);
            this.btn_Save.TabIndex = 290;
            this.btn_Save.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.Values.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Print.Location = new System.Drawing.Point(1002, 43);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(90, 38);
            this.btn_Print.TabIndex = 289;
            this.btn_Print.Values.Image = global::Odin.Global_Resourses.Printer;
            this.btn_Print.Values.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // txt_Weeks
            // 
            this.txt_Weeks.AllowDecimalSeparator = false;
            this.txt_Weeks.AllowSpace = false;
            this.txt_Weeks.Location = new System.Drawing.Point(795, 45);
            this.txt_Weeks.Name = "txt_Weeks";
            this.txt_Weeks.Size = new System.Drawing.Size(33, 23);
            this.txt_Weeks.TabIndex = 288;
            this.txt_Weeks.Text = "3";
            // 
            // kryptonLabel32
            // 
            this.kryptonLabel32.Location = new System.Drawing.Point(696, 47);
            this.kryptonLabel32.Name = "kryptonLabel32";
            this.kryptonLabel32.Size = new System.Drawing.Size(96, 20);
            this.kryptonLabel32.TabIndex = 287;
            this.kryptonLabel32.Values.Text = "Weeks to show:";
            // 
            // cmb_Week1
            // 
            this.cmb_Week1.FirstDateOfWeek = new System.DateTime(((long)(0)));
            this.cmb_Week1.LastDateOfWeek = new System.DateTime(((long)(0)));
            this.cmb_Week1.Location = new System.Drawing.Point(583, 45);
            this.cmb_Week1.Name = "cmb_Week1";
            this.cmb_Week1.Size = new System.Drawing.Size(105, 20);
            this.cmb_Week1.TabIndex = 286;
            this.cmb_Week1.Week = "W  .";
            this.cmb_Week1.weekNumber = 0;
            // 
            // txt_StartTill
            // 
            this.txt_StartTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_StartTill.CalendarShowWeekNumbers = true;
            this.txt_StartTill.CustomFormat = null;
            this.txt_StartTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartTill.Location = new System.Drawing.Point(583, 18);
            this.txt_StartTill.Name = "txt_StartTill";
            this.txt_StartTill.NullValue = " ";
            this.txt_StartTill.Size = new System.Drawing.Size(105, 21);
            this.txt_StartTill.TabIndex = 285;
            this.txt_StartTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartTill_DropDown);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            // 
            // txt_StartFrom
            // 
            this.txt_StartFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_StartFrom.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.txt_StartFrom.CalendarShowWeekNumbers = true;
            this.txt_StartFrom.CustomFormat = null;
            this.txt_StartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartFrom.Location = new System.Drawing.Point(438, 18);
            this.txt_StartFrom.Name = "txt_StartFrom";
            this.txt_StartFrom.NullValue = " ";
            this.txt_StartFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_StartFrom.TabIndex = 284;
            this.txt_StartFrom.ValueChanged += new System.EventHandler(this.txt_StartFrom_ValueChanged);
            this.txt_StartFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartFrom_DropDown);
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny5.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            // 
            // kryptonLabel31
            // 
            this.kryptonLabel31.Location = new System.Drawing.Point(549, 18);
            this.kryptonLabel31.Name = "kryptonLabel31";
            this.kryptonLabel31.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel31.TabIndex = 283;
            this.kryptonLabel31.Values.Text = "till:";
            // 
            // kryptonLabel33
            // 
            this.kryptonLabel33.Location = new System.Drawing.Point(293, 18);
            this.kryptonLabel33.Name = "kryptonLabel33";
            this.kryptonLabel33.Size = new System.Drawing.Size(146, 20);
            this.kryptonLabel33.TabIndex = 281;
            this.kryptonLabel33.Values.Text = "Start of production from:";
            // 
            // chk_Active
            // 
            this.chk_Active.Checked = true;
            this.chk_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Active.Location = new System.Drawing.Point(227, 18);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(57, 20);
            this.chk_Active.TabIndex = 280;
            this.chk_Active.ThreeState = true;
            this.chk_Active.Values.Text = "Active";
            // 
            // cmb_SalesOrdersWithLines1
            // 
            this.cmb_SalesOrdersWithLines1.ArticleId = 0;
            this.cmb_SalesOrdersWithLines1.BatchId = 0;
            this.cmb_SalesOrdersWithLines1.Location = new System.Drawing.Point(85, 43);
            this.cmb_SalesOrdersWithLines1.Name = "cmb_SalesOrdersWithLines1";
            this.cmb_SalesOrdersWithLines1.QtyInCO = 0D;
            this.cmb_SalesOrdersWithLines1.SalesOrder = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            this.cmb_SalesOrdersWithLines1.SalesOrderLine = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            this.cmb_SalesOrdersWithLines1.Size = new System.Drawing.Size(199, 21);
            this.cmb_SalesOrdersWithLines1.TabIndex = 279;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 45);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel3.TabIndex = 278;
            this.kryptonLabel3.Values.Text = "Conf. order:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(5, 17);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 277;
            this.kryptonLabel2.Values.Text = "Batch:";
            // 
            // cmb_Batches1
            // 
            this.cmb_Batches1.ActiveOnly = 0;
            this.cmb_Batches1.Article = null;
            this.cmb_Batches1.ArticleId = 0;
            this.cmb_Batches1.Batch = "";
            this.cmb_Batches1.BatchId = 0;
            this.cmb_Batches1.Comments = "";
            this.cmb_Batches1.ConfOrder = "";
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.CustArticle = "";
            this.cmb_Batches1.Customer = "";
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.IsGroup = 0;
            this.cmb_Batches1.IsProject = 0;
            this.cmb_Batches1.IsQuote = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(85, 17);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(128, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 276;
            // 
            // btn_Refresh1
            // 
            this.btn_Refresh1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh1.Location = new System.Drawing.Point(941, 19);
            this.btn_Refresh1.Name = "btn_Refresh1";
            this.btn_Refresh1.Size = new System.Drawing.Size(44, 38);
            this.btn_Refresh1.TabIndex = 275;
            this.btn_Refresh1.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh1.Values.Text = "";
            this.btn_Refresh1.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(293, 45);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel1.TabIndex = 272;
            this.kryptonLabel1.Values.Text = "Customer:";
            // 
            // cmb_Firms1
            // 
            this.cmb_Firms1.CountryId = 0;
            this.cmb_Firms1.CountryVAT = 0D;
            this.cmb_Firms1.CurId = 0;
            this.cmb_Firms1.CustIncotermsId = 0;
            this.cmb_Firms1.CustPaymentId = 0;
            this.cmb_Firms1.EnableSearchId = false;
            this.cmb_Firms1.Firm = "";
            this.cmb_Firms1.FirmId = 0;
            this.cmb_Firms1.IsEmptyColor = false;
            this.cmb_Firms1.Location = new System.Drawing.Point(384, 45);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(193, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 271;
            this.cmb_Firms1.VATNr = null;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(1884, 36);
            this.kryptonHeader1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonHeader1.TabIndex = 11;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Planning of production";
            this.kryptonHeader1.Values.Image = global::Odin.Global_Resourses.table_tab_search;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_Refresh.UniqueName = "A8592A65CA544DAA0AA07B1430A8F75B";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 914);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel1.Size = new System.Drawing.Size(1884, 45);
            this.kryptonPanel1.TabIndex = 6;
            this.kryptonPanel1.Visible = false;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(1696, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 35);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cancel.Location = new System.Drawing.Point(1789, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 35);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // mni_Holidays
            // 
            this.mni_Holidays.Image = global::Odin.Global_Resourses.IncludeCalendar;
            this.mni_Holidays.Name = "mni_Holidays";
            this.mni_Holidays.Size = new System.Drawing.Size(210, 22);
            this.mni_Holidays.Text = "Mark as holiday";
            this.mni_Holidays.Click += new System.EventHandler(this.mni_Holidays_Click);
            // 
            // frm_ProductionPlanning
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 959);
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel4);
            this.Controls.Add(this.kryptonHeader2);
            this.Controls.Add(this.gv_Planned);
            this.Controls.Add(this.bn_Planned);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonHeader1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ProductionPlanning";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Project planning";
            this.Text = "Production planning";
            this.Load += new System.EventHandler(this.frm_ProjectPlanning_Load);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.mnu_LinesP.ResumeLayout(false);
            this.mnu_LinesP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Planned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel14)).EndInit();
            this.kryptonPanel14.ResumeLayout(false);
            this.kryptonPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel13)).EndInit();
            this.kryptonPanel13.ResumeLayout(false);
            this.kryptonPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel12)).EndInit();
            this.kryptonPanel12.ResumeLayout(false);
            this.kryptonPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel10)).EndInit();
            this.kryptonPanel10.ResumeLayout(false);
            this.kryptonPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel9)).EndInit();
            this.kryptonPanel9.ResumeLayout(false);
            this.kryptonPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).EndInit();
            this.kryptonPanel8.ResumeLayout(false);
            this.kryptonPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel11)).EndInit();
            this.kryptonPanel11.ResumeLayout(false);
            this.kryptonPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            this.kryptonPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            this.kryptonPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Planned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Planned)).EndInit();
            this.bn_Planned.ResumeLayout(false);
            this.bn_Planned.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private System.Windows.Forms.BindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Delete;
        private System.Windows.Forms.BindingNavigator bn_Planned;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Excel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private System.Windows.Forms.BindingSource bs_Planned;
        private System.Windows.Forms.ContextMenuStrip mnu_LinesP;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForP;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchP;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByP;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExludingSelP;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterP;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminP;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh1;
        private System.Windows.Forms.ToolStripButton btn_Delete1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pweekoper;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pplanned;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_punit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pqtyinbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_psecname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_particle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_partid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pbatchid;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Planned;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Owf.Controls.NumericTetxBox txt_QCSMT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Owf.Controls.NumericTetxBox txt_NQSMT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Owf.Controls.NumericTetxBox txt_CSMT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Owf.Controls.NumericTetxBox txt_NSMT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel12;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private Owf.Controls.NumericTetxBox txt_CFQC;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel23;
        private Owf.Controls.NumericTetxBox txt_NFQC;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Owf.Controls.NumericTetxBox txt_CFTA;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel17;
        private Owf.Controls.NumericTetxBox txt_NFTA;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Owf.Controls.NumericTetxBox txt_CQTHT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Owf.Controls.NumericTetxBox txt_NQTHT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Owf.Controls.NumericTetxBox txt_CTHT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Owf.Controls.NumericTetxBox txt_NTHT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private Owf.Controls.NumericTetxBox txt_CXRay;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel20;
        private Owf.Controls.NumericTetxBox txt_NXray;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel21;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel14;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel28;
        private Owf.Controls.NumericTetxBox txt_CGPA;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel29;
        private Owf.Controls.NumericTetxBox txt_NGPA;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel30;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel13;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel25;
        private Owf.Controls.NumericTetxBox txt_CIPA;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel26;
        private Owf.Controls.NumericTetxBox txt_NIPA;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel27;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Active;
        private CustomControls.NullableDateTimePicker txt_StartTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private CustomControls.NullableDateTimePicker txt_StartFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel31;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel33;
        private CMB_Components.Week.cmb_Week cmb_Week1;
        private Owf.Controls.NumericTetxBox txt_Weeks;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel32;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Launches;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel34;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private System.Windows.Forms.ToolStripButton btn_Validate;
        private System.Windows.Forms.ToolStripButton btn_Invalidate;
        private System.Windows.Forms.ToolStripMenuItem mni_Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyinbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_week;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stages;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sumbefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_teortime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_prodplace;
        private System.Windows.Forms.ToolStripButton btn_Check;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ToolStripMenuItem mni_Holidays;
    }
}