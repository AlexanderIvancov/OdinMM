namespace Odin.Workshop
{
    partial class frm_Processing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Processing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.chk_Processing = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.cmb_SalesOrdersWithLines1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrdersWithLines();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_EndTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_EndFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_StartTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_StartFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Department1 = new Odin.CMB_Components.Departments.cmb_Department();
            this.chk_Active = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CustOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny6 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_FirmArt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.btn_FreezeHistory = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_LaunchProcess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Launches = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OnDate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_History = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Process = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_groupcontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_isactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_urgent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_dateofclosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_SMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_QC_SMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_XRAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_THT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_QC_THT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_FTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_QC_FTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_IPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_FCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Freezed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_firsmovedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isprimary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // mni_Search
            // 
            this.mni_Search.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_Search.Name = "mni_Search";
            this.mni_Search.Size = new System.Drawing.Size(210, 22);
            this.mni_Search.Text = "Search for record";
            this.mni_Search.Click += new System.EventHandler(this.mni_Search_Click);
            // 
            // mni_FilterFor
            // 
            this.mni_FilterFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterFor.Name = "mni_FilterFor";
            this.mni_FilterFor.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterFor.TextChanged += new System.EventHandler(this.mni_FilterFor_TextChanged);
            // 
            // mnu_Lines
            // 
            this.mnu_Lines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Lines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterFor,
            this.mni_Search,
            this.mni_FilterBy,
            this.mni_FilterExcludingSel,
            this.mni_RemoveFilter,
            this.mni_Copy,
            this.toolStripSeparator2,
            this.mni_Admin});
            this.mnu_Lines.Name = "mnu_Requests";
            this.mnu_Lines.Size = new System.Drawing.Size(211, 167);
            this.mnu_Lines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_Lines_Opening);
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
            this.mni_Admin.Click += new System.EventHandler(this.mni_Admin_Click);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            this.kryptonDockingManager1.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager1_DockspaceAdding);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 49);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonSplitContainer2);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonPanel3);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1090, 533);
            this.kryptonSplitContainer1.SplitterDistance = 426;
            this.kryptonSplitContainer1.TabIndex = 11;
            // 
            // kryptonSplitContainer2
            // 
            this.kryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.kryptonSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer2.Name = "kryptonSplitContainer2";
            // 
            // kryptonSplitContainer2.Panel1
            // 
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel14);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Processing);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel13);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Common1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_SalesOrdersWithLines1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel12);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_EndTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_EndFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_StartTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_StartFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel10);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel11);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Department1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Active);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Batches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel9);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CustOrder);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_FirmArt);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel16);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Types1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1090, 426);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(5, 183);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel14.TabIndex = 265;
            this.kryptonLabel14.Values.Text = "Customer:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(86, 183);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 264;
            this.cmb_Firms1.VATNr = null;
            // 
            // chk_Processing
            // 
            this.chk_Processing.Checked = true;
            this.chk_Processing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Processing.Location = new System.Drawing.Point(152, 82);
            this.chk_Processing.Name = "chk_Processing";
            this.chk_Processing.Size = new System.Drawing.Size(82, 20);
            this.chk_Processing.TabIndex = 263;
            this.chk_Processing.ThreeState = true;
            this.chk_Processing.Values.Text = "Processing";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(5, 105);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel13.TabIndex = 262;
            this.kryptonLabel13.Values.Text = "Stage:";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(87, 105);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "orderby";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(138, 20);
            this.cmb_Common1.sTable = "BAS_Stages";
            this.cmb_Common1.sText_Filled = "name";
            this.cmb_Common1.sTitle = "Stages";
            this.cmb_Common1.TabIndex = 261;
            // 
            // cmb_SalesOrdersWithLines1
            // 
            this.cmb_SalesOrdersWithLines1.ArticleId = 0;
            this.cmb_SalesOrdersWithLines1.BatchId = 0;
            this.cmb_SalesOrdersWithLines1.Location = new System.Drawing.Point(86, 131);
            this.cmb_SalesOrdersWithLines1.Name = "cmb_SalesOrdersWithLines1";
            this.cmb_SalesOrdersWithLines1.QtyInCO = 0D;
            this.cmb_SalesOrdersWithLines1.SalesOrder = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            this.cmb_SalesOrdersWithLines1.SalesOrderLine = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            this.cmb_SalesOrdersWithLines1.Size = new System.Drawing.Size(204, 21);
            this.cmb_SalesOrdersWithLines1.TabIndex = 260;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(25, 403);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel12.TabIndex = 259;
            this.kryptonLabel12.Values.Text = "Department:";
            this.kryptonLabel12.Visible = false;
            // 
            // txt_EndTill
            // 
            this.txt_EndTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_EndTill.CalendarShowWeekNumbers = true;
            this.txt_EndTill.CustomFormat = null;
            this.txt_EndTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndTill.Location = new System.Drawing.Point(185, 377);
            this.txt_EndTill.Name = "txt_EndTill";
            this.txt_EndTill.NullValue = " ";
            this.txt_EndTill.Size = new System.Drawing.Size(105, 21);
            this.txt_EndTill.TabIndex = 258;
            this.txt_EndTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_EndTill_DropDown);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny2.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // txt_EndFrom
            // 
            this.txt_EndFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_EndFrom.CalendarShowWeekNumbers = true;
            this.txt_EndFrom.CustomFormat = null;
            this.txt_EndFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndFrom.Location = new System.Drawing.Point(51, 377);
            this.txt_EndFrom.Name = "txt_EndFrom";
            this.txt_EndFrom.NullValue = " ";
            this.txt_EndFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_EndFrom.TabIndex = 257;
            this.txt_EndFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_EndFrom_DropDown);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // txt_StartTill
            // 
            this.txt_StartTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_StartTill.CalendarShowWeekNumbers = true;
            this.txt_StartTill.CustomFormat = null;
            this.txt_StartTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartTill.Location = new System.Drawing.Point(185, 338);
            this.txt_StartTill.Name = "txt_StartTill";
            this.txt_StartTill.NullValue = " ";
            this.txt_StartTill.Size = new System.Drawing.Size(105, 21);
            this.txt_StartTill.TabIndex = 256;
            this.txt_StartTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartTill_DropDown);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny4.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // txt_StartFrom
            // 
            this.txt_StartFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_StartFrom.CalendarShowWeekNumbers = true;
            this.txt_StartFrom.CustomFormat = null;
            this.txt_StartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartFrom.Location = new System.Drawing.Point(51, 338);
            this.txt_StartFrom.Name = "txt_StartFrom";
            this.txt_StartFrom.NullValue = " ";
            this.txt_StartFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_StartFrom.TabIndex = 255;
            this.txt_StartFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartFrom_DropDown);
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny5.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny5.Click += new System.EventHandler(this.buttonSpecAny5_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(158, 377);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel4.TabIndex = 254;
            this.kryptonLabel4.Values.Text = "till:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(4, 378);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel5.TabIndex = 253;
            this.kryptonLabel5.Values.Text = "From:";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(4, 357);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(112, 20);
            this.kryptonLabel10.TabIndex = 252;
            this.kryptonLabel10.Values.Text = "End of production:";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(158, 337);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel11.TabIndex = 251;
            this.kryptonLabel11.Values.Text = "till:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(4, 338);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 250;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(4, 318);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(117, 20);
            this.kryptonLabel7.TabIndex = 249;
            this.kryptonLabel7.Values.Text = "Start of production:";
            // 
            // cmb_Department1
            // 
            this.cmb_Department1.Department = "";
            this.cmb_Department1.DeptId = 0;
            this.cmb_Department1.Location = new System.Drawing.Point(107, 403);
            this.cmb_Department1.Name = "cmb_Department1";
            this.cmb_Department1.SelectedNode = null;
            this.cmb_Department1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Department1.TabIndex = 248;
            this.cmb_Department1.Visible = false;
            // 
            // chk_Active
            // 
            this.chk_Active.Checked = true;
            this.chk_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Active.Location = new System.Drawing.Point(72, 82);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(57, 20);
            this.chk_Active.TabIndex = 247;
            this.chk_Active.ThreeState = true;
            this.chk_Active.Values.Text = "Active";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(4, 131);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel3.TabIndex = 246;
            this.kryptonLabel3.Values.Text = "Conf. order:";
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
            this.cmb_Batches1.Location = new System.Drawing.Point(87, 51);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(137, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 244;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(4, 297);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel9.TabIndex = 243;
            this.kryptonLabel9.Values.Text = "Cust. order:";
            // 
            // txt_CustOrder
            // 
            this.txt_CustOrder.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny6});
            this.txt_CustOrder.Location = new System.Drawing.Point(85, 297);
            this.txt_CustOrder.Name = "txt_CustOrder";
            this.txt_CustOrder.Size = new System.Drawing.Size(205, 23);
            this.txt_CustOrder.TabIndex = 242;
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny6.UniqueName = "37A7E4CC6EDD4E03049882481BF8DE9B";
            this.buttonSpecAny6.Click += new System.EventHandler(this.buttonSpecAny6_Click);
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(9, 78);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 237;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 51);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 236;
            this.kryptonLabel2.Values.Text = "Batch:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 251);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(110, 20);
            this.kryptonLabel1.TabIndex = 234;
            this.kryptonLabel1.Values.Text = "Customer\'s article:";
            // 
            // txt_FirmArt
            // 
            this.txt_FirmArt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_FirmArt.Location = new System.Drawing.Point(7, 271);
            this.txt_FirmArt.Name = "txt_FirmArt";
            this.txt_FirmArt.Size = new System.Drawing.Size(283, 23);
            this.txt_FirmArt.StateDisabled.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.txt_FirmArt.TabIndex = 233;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "37A7E4CC6EDD4E03049882481BF8DE9B";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(3, 205);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel16.TabIndex = 230;
            this.kryptonLabel16.Values.Text = "Article:";
            // 
            // cmb_Articles1
            // 
            this.cmb_Articles1.Article = "";
            this.cmb_Articles1.ArticleId = 0;
            this.cmb_Articles1.ArticleIdRec = 0;
            this.cmb_Articles1.ArtType = null;
            this.cmb_Articles1.BOMState = 0;
            this.cmb_Articles1.Comments = null;
            this.cmb_Articles1.CustCode = null;
            this.cmb_Articles1.CustCodeId = 0;
            this.cmb_Articles1.Department = null;
            this.cmb_Articles1.DeptId = 0;
            this.cmb_Articles1.Description = null;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(7, 228);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(283, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 229;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(4, 157);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel6.TabIndex = 223;
            this.kryptonLabel6.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(86, 157);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Types1.TabIndex = 222;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear,
            this.btn_Print});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(299, 42);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Filter";
            this.kryptonHeader1.Values.Image = global::Odin.Global_Resourses.Filter;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.UniqueName = "3502D2542D5C42F0078623FF0A695273";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Image = global::Odin.Global_Resourses.Printer;
            this.btn_Print.UniqueName = "50782B3FB58A4FE97399F6948AF9FDDB";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_batch,
            this.cn_groupcontent,
            this.cn_conforder,
            this.cn_artid,
            this.cn_article,
            this.cn_secname,
            this.cn_qty,
            this.cn_unit,
            this.cn_description,
            this.cn_startdate,
            this.cn_enddate,
            this.chk_isactive,
            this.cn_comments,
            this.chk_urgent,
            this.cn_dateofclosing,
            this.cn_type,
            this.cn_department,
            this.cn_SMT,
            this.cn_QC_SMT,
            this.cn_XRAY,
            this.cn_THT,
            this.cn_QC_THT,
            this.cn_FTA,
            this.cn_QC_FTA,
            this.cn_IPA,
            this.cn_GPA,
            this.cn_FCS,
            this.cn_Freezed,
            this.cn_Rest,
            this.cn_customer,
            this.cn_firsmovedate,
            this.cn_isprimary});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(786, 401);
            this.gv_List.TabIndex = 5;
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
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
            this.btn_FreezeHistory});
            this.bn_List.Location = new System.Drawing.Point(0, 401);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(786, 25);
            this.bn_List.TabIndex = 1;
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
            this.btn_Excel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(23, 22);
            this.btn_Excel.Text = "Export into excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_FreezeHistory
            // 
            this.btn_FreezeHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_FreezeHistory.Image = global::Odin.Global_Resourses.snowflake24x24;
            this.btn_FreezeHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FreezeHistory.Name = "btn_FreezeHistory";
            this.btn_FreezeHistory.Size = new System.Drawing.Size(23, 22);
            this.btn_FreezeHistory.Text = "Show freezing history";
            this.btn_FreezeHistory.Click += new System.EventHandler(this.btn_FreezeHistory_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonDockableWorkspace1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1090, 102);
            this.kryptonPanel3.TabIndex = 6;
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.AutoScroll = true;
            this.kryptonDockableWorkspace1.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "3603EBC349EA4AA52F8724469FC85DA3";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1090, 102);
            this.kryptonDockableWorkspace1.TabIndex = 7;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_LaunchProcess);
            this.kryptonPanel1.Controls.Add(this.btn_Launches);
            this.kryptonPanel1.Controls.Add(this.btn_OnDate);
            this.kryptonPanel1.Controls.Add(this.btn_History);
            this.kryptonPanel1.Controls.Add(this.btn_Process);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1090, 49);
            this.kryptonPanel1.TabIndex = 10;
            // 
            // btn_LaunchProcess
            // 
            this.btn_LaunchProcess.Location = new System.Drawing.Point(7, 5);
            this.btn_LaunchProcess.Name = "btn_LaunchProcess";
            this.btn_LaunchProcess.Size = new System.Drawing.Size(148, 39);
            this.btn_LaunchProcess.TabIndex = 1;
            this.btn_LaunchProcess.Values.Image = global::Odin.Global_Resourses.traffic_lights_green32x32;
            this.btn_LaunchProcess.Values.Text = "Launch process";
            this.btn_LaunchProcess.Click += new System.EventHandler(this.btn_LaunchProcess_Click);
            // 
            // btn_Launches
            // 
            this.btn_Launches.Location = new System.Drawing.Point(554, 5);
            this.btn_Launches.Name = "btn_Launches";
            this.btn_Launches.Size = new System.Drawing.Size(100, 39);
            this.btn_Launches.TabIndex = 15;
            this.btn_Launches.Values.Image = global::Odin.Global_Resourses.launch;
            this.btn_Launches.Values.Text = "Launches";
            this.btn_Launches.Click += new System.EventHandler(this.btn_Launches_Click);
            // 
            // btn_OnDate
            // 
            this.btn_OnDate.Location = new System.Drawing.Point(414, 5);
            this.btn_OnDate.Name = "btn_OnDate";
            this.btn_OnDate.Size = new System.Drawing.Size(137, 39);
            this.btn_OnDate.TabIndex = 7;
            this.btn_OnDate.Values.Image = global::Odin.Global_Resourses.Calendar_24x24;
            this.btn_OnDate.Values.Text = "History on date";
            this.btn_OnDate.Click += new System.EventHandler(this.btn_OnDate_Click);
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(302, 5);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(109, 39);
            this.btn_History.TabIndex = 6;
            this.btn_History.Values.Image = global::Odin.Global_Resourses.emblem_library_9156;
            this.btn_History.Values.Text = "History";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(158, 5);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(141, 39);
            this.btn_Process.TabIndex = 2;
            this.btn_Process.Values.Image = global::Odin.Global_Resourses.memory_32x32;
            this.btn_Process.Values.Text = "Batch process";
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.FillWeight = 90F;
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.ReadOnly = true;
            this.cn_batch.Width = 90;
            // 
            // cn_groupcontent
            // 
            this.cn_groupcontent.DataPropertyName = "groupcontent";
            this.cn_groupcontent.HeaderText = "Group content";
            this.cn_groupcontent.Name = "cn_groupcontent";
            this.cn_groupcontent.ReadOnly = true;
            // 
            // cn_conforder
            // 
            this.cn_conforder.DataPropertyName = "conforder";
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            this.cn_conforder.ReadOnly = true;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 70F;
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
            this.cn_artid.Width = 70;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 200F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Width = 200;
            // 
            // cn_secname
            // 
            this.cn_secname.DataPropertyName = "secname";
            this.cn_secname.HeaderText = "2nd name";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.ReadOnly = true;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 70F;
            this.cn_qty.HeaderText = "Quantity";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 70;
            // 
            // cn_unit
            // 
            this.cn_unit.DataPropertyName = "unit";
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.ReadOnly = true;
            this.cn_unit.Width = 40;
            // 
            // cn_description
            // 
            this.cn_description.DataPropertyName = "description";
            this.cn_description.FillWeight = 150F;
            this.cn_description.HeaderText = "Description";
            this.cn_description.Name = "cn_description";
            this.cn_description.ReadOnly = true;
            this.cn_description.Width = 150;
            // 
            // cn_startdate
            // 
            this.cn_startdate.DataPropertyName = "startdate";
            this.cn_startdate.HeaderText = "Start of production";
            this.cn_startdate.Name = "cn_startdate";
            this.cn_startdate.ReadOnly = true;
            // 
            // cn_enddate
            // 
            this.cn_enddate.DataPropertyName = "enddate";
            this.cn_enddate.HeaderText = "End of production";
            this.cn_enddate.Name = "cn_enddate";
            this.cn_enddate.ReadOnly = true;
            // 
            // chk_isactive
            // 
            this.chk_isactive.DataPropertyName = "isactive";
            this.chk_isactive.FalseValue = "0";
            this.chk_isactive.FillWeight = 40F;
            this.chk_isactive.HeaderText = "Active";
            this.chk_isactive.IndeterminateValue = "1";
            this.chk_isactive.Name = "chk_isactive";
            this.chk_isactive.ReadOnly = true;
            this.chk_isactive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk_isactive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk_isactive.TrueValue = "-1";
            this.chk_isactive.Width = 40;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.ReadOnly = true;
            this.cn_comments.Width = 150;
            // 
            // chk_urgent
            // 
            this.chk_urgent.DataPropertyName = "urgent";
            this.chk_urgent.FillWeight = 40F;
            this.chk_urgent.HeaderText = "Urgent";
            this.chk_urgent.Name = "chk_urgent";
            this.chk_urgent.ReadOnly = true;
            this.chk_urgent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk_urgent.Width = 40;
            // 
            // cn_dateofclosing
            // 
            this.cn_dateofclosing.DataPropertyName = "dateofclosing";
            this.cn_dateofclosing.HeaderText = "Date of closing";
            this.cn_dateofclosing.Name = "cn_dateofclosing";
            this.cn_dateofclosing.ReadOnly = true;
            // 
            // cn_type
            // 
            this.cn_type.DataPropertyName = "type";
            this.cn_type.HeaderText = "Type";
            this.cn_type.Name = "cn_type";
            this.cn_type.ReadOnly = true;
            // 
            // cn_department
            // 
            this.cn_department.DataPropertyName = "department";
            this.cn_department.HeaderText = "Department";
            this.cn_department.Name = "cn_department";
            this.cn_department.ReadOnly = true;
            // 
            // cn_SMT
            // 
            this.cn_SMT.DataPropertyName = "SMT";
            this.cn_SMT.FillWeight = 60F;
            this.cn_SMT.HeaderText = "SMT";
            this.cn_SMT.Name = "cn_SMT";
            this.cn_SMT.ReadOnly = true;
            this.cn_SMT.Width = 60;
            // 
            // cn_QC_SMT
            // 
            this.cn_QC_SMT.DataPropertyName = "QC_SMT";
            this.cn_QC_SMT.FillWeight = 60F;
            this.cn_QC_SMT.HeaderText = "QC_SMT";
            this.cn_QC_SMT.Name = "cn_QC_SMT";
            this.cn_QC_SMT.ReadOnly = true;
            this.cn_QC_SMT.Width = 60;
            // 
            // cn_XRAY
            // 
            this.cn_XRAY.DataPropertyName = "XRAY";
            this.cn_XRAY.FillWeight = 60F;
            this.cn_XRAY.HeaderText = "XRAY";
            this.cn_XRAY.Name = "cn_XRAY";
            this.cn_XRAY.ReadOnly = true;
            this.cn_XRAY.Width = 60;
            // 
            // cn_THT
            // 
            this.cn_THT.DataPropertyName = "THT";
            this.cn_THT.FillWeight = 60F;
            this.cn_THT.HeaderText = "THT";
            this.cn_THT.Name = "cn_THT";
            this.cn_THT.ReadOnly = true;
            this.cn_THT.Width = 60;
            // 
            // cn_QC_THT
            // 
            this.cn_QC_THT.DataPropertyName = "QC_THT";
            this.cn_QC_THT.FillWeight = 60F;
            this.cn_QC_THT.HeaderText = "QC_THT";
            this.cn_QC_THT.Name = "cn_QC_THT";
            this.cn_QC_THT.ReadOnly = true;
            this.cn_QC_THT.Width = 60;
            // 
            // cn_FTA
            // 
            this.cn_FTA.DataPropertyName = "FTA";
            this.cn_FTA.FillWeight = 60F;
            this.cn_FTA.HeaderText = "FTA";
            this.cn_FTA.Name = "cn_FTA";
            this.cn_FTA.ReadOnly = true;
            this.cn_FTA.Width = 60;
            // 
            // cn_QC_FTA
            // 
            this.cn_QC_FTA.DataPropertyName = "FQC";
            this.cn_QC_FTA.FillWeight = 60F;
            this.cn_QC_FTA.HeaderText = "FQC";
            this.cn_QC_FTA.Name = "cn_QC_FTA";
            this.cn_QC_FTA.ReadOnly = true;
            this.cn_QC_FTA.Width = 60;
            // 
            // cn_IPA
            // 
            this.cn_IPA.DataPropertyName = "IPA";
            this.cn_IPA.FillWeight = 60F;
            this.cn_IPA.HeaderText = "IPA";
            this.cn_IPA.Name = "cn_IPA";
            this.cn_IPA.ReadOnly = true;
            this.cn_IPA.Width = 60;
            // 
            // cn_GPA
            // 
            this.cn_GPA.DataPropertyName = "GPA";
            this.cn_GPA.FillWeight = 60F;
            this.cn_GPA.HeaderText = "GPA";
            this.cn_GPA.Name = "cn_GPA";
            this.cn_GPA.ReadOnly = true;
            this.cn_GPA.Width = 60;
            // 
            // cn_FCS
            // 
            this.cn_FCS.DataPropertyName = "FCS";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cn_FCS.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_FCS.FillWeight = 60F;
            this.cn_FCS.HeaderText = "FCS";
            this.cn_FCS.Name = "cn_FCS";
            this.cn_FCS.ReadOnly = true;
            this.cn_FCS.Width = 60;
            // 
            // cn_Freezed
            // 
            this.cn_Freezed.DataPropertyName = "Freezed";
            this.cn_Freezed.FillWeight = 60F;
            this.cn_Freezed.HeaderText = "Freezed";
            this.cn_Freezed.Name = "cn_Freezed";
            this.cn_Freezed.ReadOnly = true;
            this.cn_Freezed.Width = 60;
            // 
            // cn_Rest
            // 
            this.cn_Rest.DataPropertyName = "rest";
            this.cn_Rest.FillWeight = 80F;
            this.cn_Rest.HeaderText = "Rest";
            this.cn_Rest.Name = "cn_Rest";
            this.cn_Rest.ReadOnly = true;
            this.cn_Rest.Width = 80;
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            this.cn_customer.ReadOnly = true;
            // 
            // cn_firsmovedate
            // 
            this.cn_firsmovedate.DataPropertyName = "firstmovedate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.cn_firsmovedate.DefaultCellStyle = dataGridViewCellStyle2;
            this.cn_firsmovedate.HeaderText = "First move date";
            this.cn_firsmovedate.Name = "cn_firsmovedate";
            this.cn_firsmovedate.ReadOnly = true;
            // 
            // cn_isprimary
            // 
            this.cn_isprimary.DataPropertyName = "isprimary";
            this.cn_isprimary.HeaderText = "isprimary";
            this.cn_isprimary.Name = "cn_isprimary";
            this.cn_isprimary.ReadOnly = true;
            this.cn_isprimary.Visible = false;
            // 
            // frm_Processing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 582);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Processing";
            this.TabText = "Processing";
            this.Text = "Processing";
            this.Load += new System.EventHandler(this.frm_Processing_Load);
            this.Resize += new System.EventHandler(this.frm_Processing_Resize);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private System.Windows.Forms.ImageList imageListSmall;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator bn_List;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_FirmArt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Print;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Process;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_History;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Active;
        private CMB_Components.Departments.cmb_Department cmb_Department1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private CustomControls.NullableDateTimePicker txt_EndTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private CustomControls.NullableDateTimePicker txt_EndFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private CustomControls.NullableDateTimePicker txt_StartTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private CustomControls.NullableDateTimePicker txt_StartFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Processing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OnDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private System.Windows.Forms.ToolStripButton btn_FreezeHistory;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Launches;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_LaunchProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_groupcontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_enddate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_isactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_urgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dateofclosing;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_SMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_QC_SMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_XRAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_THT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_QC_THT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_FTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_QC_FTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_IPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_FCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Freezed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Rest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_firsmovedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isprimary;
    }
}