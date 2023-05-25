namespace Odin.Planning
{
    partial class frm_Batches
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
        public Main _frm_Main;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Batches));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Launches = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_RMDeficite = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_QCTracing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_PrintRouteList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Tracing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Passport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Orders = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_BatchStock = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Totals = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_General = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_POReservation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_DistributeRM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_BatchRM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gradientPanel21 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel19 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Users1 = new Odin.CMB_Components.Users.cmb_Users();
            this.txt_EndTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_EndFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_StartTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_StartFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.chk_Active = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cmb_SalesOrdersWithLines1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrdersWithLines();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Department1 = new Odin.CMB_Components.Departments.cmb_Department();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cn_parentbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_urgent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_dateofclosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_creatby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_complected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtystock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ALLSTAGES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_SMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_THT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_FTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_IPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rmstateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_blocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_coartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btn_AddNew = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Copy = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Active = new System.Windows.Forms.ToolStripButton();
            this.btn_Block = new System.Windows.Forms.ToolStripButton();
            this.btn_OpenBatch = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
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
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            this.kryptonDockingManager1.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager1_DockspaceAdding);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Launches);
            this.kryptonPanel1.Controls.Add(this.btn_RMDeficite);
            this.kryptonPanel1.Controls.Add(this.btn_QCTracing);
            this.kryptonPanel1.Controls.Add(this.btn_PrintRouteList);
            this.kryptonPanel1.Controls.Add(this.btn_Tracing);
            this.kryptonPanel1.Controls.Add(this.btn_Passport);
            this.kryptonPanel1.Controls.Add(this.btn_Orders);
            this.kryptonPanel1.Controls.Add(this.btn_BatchStock);
            this.kryptonPanel1.Controls.Add(this.btn_Totals);
            this.kryptonPanel1.Controls.Add(this.btn_General);
            this.kryptonPanel1.Controls.Add(this.btn_POReservation);
            this.kryptonPanel1.Controls.Add(this.btn_DistributeRM);
            this.kryptonPanel1.Controls.Add(this.btn_BatchRM);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1313, 49);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btn_Launches
            // 
            this.btn_Launches.Location = new System.Drawing.Point(569, 5);
            this.btn_Launches.Name = "btn_Launches";
            this.btn_Launches.Size = new System.Drawing.Size(100, 39);
            this.btn_Launches.TabIndex = 14;
            this.btn_Launches.Values.Image = global::Odin.Global_Resourses.launch;
            this.btn_Launches.Values.Text = "Launches";
            this.btn_Launches.Click += new System.EventHandler(this.btn_Launches_Click);
            // 
            // btn_RMDeficite
            // 
            this.btn_RMDeficite.Location = new System.Drawing.Point(1181, 5);
            this.btn_RMDeficite.Name = "btn_RMDeficite";
            this.btn_RMDeficite.Size = new System.Drawing.Size(100, 39);
            this.btn_RMDeficite.TabIndex = 13;
            this.btn_RMDeficite.Values.Image = global::Odin.Global_Resourses.Exclamation_Mark;
            this.btn_RMDeficite.Values.Text = "RM deficite";
            this.btn_RMDeficite.Visible = false;
            this.btn_RMDeficite.Click += new System.EventHandler(this.btn_RMDeficite_Click);
            // 
            // btn_QCTracing
            // 
            this.btn_QCTracing.Location = new System.Drawing.Point(1051, 5);
            this.btn_QCTracing.Name = "btn_QCTracing";
            this.btn_QCTracing.Size = new System.Drawing.Size(127, 39);
            this.btn_QCTracing.TabIndex = 12;
            this.btn_QCTracing.Values.Image = global::Odin.Global_Resourses.barcode_2d;
            this.btn_QCTracing.Values.Text = "Serial NR tracing";
            this.btn_QCTracing.Visible = false;
            this.btn_QCTracing.Click += new System.EventHandler(this.btn_QCTracing_Click);
            // 
            // btn_PrintRouteList
            // 
            this.btn_PrintRouteList.Location = new System.Drawing.Point(948, 5);
            this.btn_PrintRouteList.Name = "btn_PrintRouteList";
            this.btn_PrintRouteList.Size = new System.Drawing.Size(100, 39);
            this.btn_PrintRouteList.TabIndex = 11;
            this.btn_PrintRouteList.Values.Image = global::Odin.Global_Resourses.Print2;
            this.btn_PrintRouteList.Values.Text = "Route list";
            this.btn_PrintRouteList.Visible = false;
            this.btn_PrintRouteList.Click += new System.EventHandler(this.btn_PrintRouteList_Click);
            // 
            // btn_Tracing
            // 
            this.btn_Tracing.Location = new System.Drawing.Point(1285, 5);
            this.btn_Tracing.Name = "btn_Tracing";
            this.btn_Tracing.Size = new System.Drawing.Size(100, 39);
            this.btn_Tracing.TabIndex = 10;
            this.btn_Tracing.Values.Image = global::Odin.Global_Resourses.Synchronize_24x24;
            this.btn_Tracing.Values.Text = "RM tracing";
            this.btn_Tracing.Visible = false;
            this.btn_Tracing.Click += new System.EventHandler(this.btn_Tracing_Click);
            // 
            // btn_Passport
            // 
            this.btn_Passport.Location = new System.Drawing.Point(763, 5);
            this.btn_Passport.Name = "btn_Passport";
            this.btn_Passport.Size = new System.Drawing.Size(81, 39);
            this.btn_Passport.TabIndex = 8;
            this.btn_Passport.Values.Image = global::Odin.Global_Resourses.folder_documents;
            this.btn_Passport.Values.Text = "Passport";
            this.btn_Passport.Visible = false;
            this.btn_Passport.Click += new System.EventHandler(this.btn_Passport_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.Location = new System.Drawing.Point(466, 5);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Size = new System.Drawing.Size(97, 39);
            this.btn_Orders.TabIndex = 7;
            this.btn_Orders.Values.Image = global::Odin.Global_Resourses.Docs;
            this.btn_Orders.Values.Text = "Orders";
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // btn_BatchStock
            // 
            this.btn_BatchStock.Location = new System.Drawing.Point(847, 5);
            this.btn_BatchStock.Name = "btn_BatchStock";
            this.btn_BatchStock.Size = new System.Drawing.Size(97, 39);
            this.btn_BatchStock.TabIndex = 6;
            this.btn_BatchStock.Values.Image = global::Odin.Global_Resourses.package1;
            this.btn_BatchStock.Values.Text = "Stock";
            this.btn_BatchStock.Visible = false;
            this.btn_BatchStock.Click += new System.EventHandler(this.btn_BatchStock_Click);
            // 
            // btn_Totals
            // 
            this.btn_Totals.Location = new System.Drawing.Point(675, 5);
            this.btn_Totals.Name = "btn_Totals";
            this.btn_Totals.Size = new System.Drawing.Size(82, 39);
            this.btn_Totals.TabIndex = 5;
            this.btn_Totals.Values.Image = global::Odin.Global_Resourses.calculator_edit;
            this.btn_Totals.Values.Text = "Totals";
            this.btn_Totals.Visible = false;
            this.btn_Totals.Click += new System.EventHandler(this.btn_Totals_Click);
            // 
            // btn_General
            // 
            this.btn_General.Location = new System.Drawing.Point(8, 5);
            this.btn_General.Name = "btn_General";
            this.btn_General.Size = new System.Drawing.Size(100, 39);
            this.btn_General.TabIndex = 1;
            this.btn_General.Values.Image = global::Odin.Global_Resourses.Doc;
            this.btn_General.Values.Text = "General";
            this.btn_General.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_POReservation
            // 
            this.btn_POReservation.Location = new System.Drawing.Point(346, 5);
            this.btn_POReservation.Name = "btn_POReservation";
            this.btn_POReservation.Size = new System.Drawing.Size(114, 39);
            this.btn_POReservation.TabIndex = 4;
            this.btn_POReservation.Values.Image = global::Odin.Global_Resourses.basket_8134;
            this.btn_POReservation.Values.Text = "Reserve PO";
            this.btn_POReservation.Click += new System.EventHandler(this.btn_POReservation_Click);
            // 
            // btn_DistributeRM
            // 
            this.btn_DistributeRM.Location = new System.Drawing.Point(216, 5);
            this.btn_DistributeRM.Name = "btn_DistributeRM";
            this.btn_DistributeRM.Size = new System.Drawing.Size(127, 39);
            this.btn_DistributeRM.TabIndex = 3;
            this.btn_DistributeRM.Values.Image = global::Odin.Global_Resourses.snowflake24x24;
            this.btn_DistributeRM.Values.Text = " Reserve stock";
            this.btn_DistributeRM.Click += new System.EventHandler(this.btn_DistributeRM_Click);
            // 
            // btn_BatchRM
            // 
            this.btn_BatchRM.Location = new System.Drawing.Point(112, 5);
            this.btn_BatchRM.Name = "btn_BatchRM";
            this.btn_BatchRM.Size = new System.Drawing.Size(100, 39);
            this.btn_BatchRM.TabIndex = 2;
            this.btn_BatchRM.Values.Image = global::Odin.Global_Resourses.ksirtet_24x24;
            this.btn_BatchRM.Values.Text = "Batch RM";
            this.btn_BatchRM.Click += new System.EventHandler(this.btn_BatchRM_Click);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
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
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonDockableWorkspace1);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1313, 544);
            this.kryptonSplitContainer1.SplitterDistance = 355;
            this.kryptonSplitContainer1.TabIndex = 4;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel21);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel19);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Users1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_EndTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_EndFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_StartTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_StartFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Active);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_SalesOrdersWithLines1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel9);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel10);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel11);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Department1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Types1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Batches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1313, 355);
            this.kryptonSplitContainer2.SplitterDistance = 313;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // gradientPanel21
            // 
            this.gradientPanel21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel21.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel21.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel21.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel21.Location = new System.Drawing.Point(8, 301);
            this.gradientPanel21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel21.Name = "gradientPanel21";
            this.gradientPanel21.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel21.ShowBottomBorder = true;
            this.gradientPanel21.ShowLeftBorder = true;
            this.gradientPanel21.ShowRightBorder = true;
            this.gradientPanel21.ShowTopBorder = true;
            this.gradientPanel21.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel21.StartColor = System.Drawing.Color.White;
            this.gradientPanel21.TabIndex = 216;
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Location = new System.Drawing.Point(5, 303);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(187, 20);
            this.kryptonLabel19.TabIndex = 267;
            this.kryptonLabel19.Values.Text = "Assembling person for route list:";
            // 
            // cmb_Users1
            // 
            this.cmb_Users1.Location = new System.Drawing.Point(9, 323);
            this.cmb_Users1.Name = "cmb_Users1";
            this.cmb_Users1.Size = new System.Drawing.Size(287, 20);
            this.cmb_Users1.TabIndex = 266;
            this.cmb_Users1.User = "";
            this.cmb_Users1.UserId = 0;
            this.cmb_Users1.UserLogin = null;
            this.cmb_Users1.UserShortName = "";
            this.cmb_Users1.UserTN = "";
            // 
            // txt_EndTill
            // 
            this.txt_EndTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_EndTill.CalendarShowWeekNumbers = true;
            this.txt_EndTill.CustomFormat = null;
            this.txt_EndTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndTill.Location = new System.Drawing.Point(188, 276);
            this.txt_EndTill.Name = "txt_EndTill";
            this.txt_EndTill.NullValue = " ";
            this.txt_EndTill.Size = new System.Drawing.Size(105, 21);
            this.txt_EndTill.TabIndex = 237;
            this.txt_EndTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_EndTill_DropDown);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny1.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click_1);
            // 
            // txt_EndFrom
            // 
            this.txt_EndFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_EndFrom.CalendarShowWeekNumbers = true;
            this.txt_EndFrom.CustomFormat = null;
            this.txt_EndFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndFrom.Location = new System.Drawing.Point(52, 276);
            this.txt_EndFrom.Name = "txt_EndFrom";
            this.txt_EndFrom.NullValue = " ";
            this.txt_EndFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_EndFrom.TabIndex = 236;
            this.txt_EndFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_EndFrom_DropDown);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny2.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click_1);
            // 
            // txt_StartTill
            // 
            this.txt_StartTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_StartTill.CalendarShowWeekNumbers = true;
            this.txt_StartTill.CustomFormat = null;
            this.txt_StartTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartTill.Location = new System.Drawing.Point(188, 237);
            this.txt_StartTill.Name = "txt_StartTill";
            this.txt_StartTill.NullValue = " ";
            this.txt_StartTill.Size = new System.Drawing.Size(105, 21);
            this.txt_StartTill.TabIndex = 235;
            this.txt_StartTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartTill_DropDown);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click_1);
            // 
            // txt_StartFrom
            // 
            this.txt_StartFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_StartFrom.CalendarShowWeekNumbers = true;
            this.txt_StartFrom.CustomFormat = null;
            this.txt_StartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartFrom.Location = new System.Drawing.Point(52, 237);
            this.txt_StartFrom.Name = "txt_StartFrom";
            this.txt_StartFrom.NullValue = " ";
            this.txt_StartFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_StartFrom.TabIndex = 234;
            this.txt_StartFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartFrom_DropDown);
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny5.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny5.Click += new System.EventHandler(this.buttonSpecAny5_Click);
            // 
            // chk_Active
            // 
            this.chk_Active.Checked = true;
            this.chk_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Active.Location = new System.Drawing.Point(93, 79);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(57, 20);
            this.chk_Active.TabIndex = 233;
            this.chk_Active.ThreeState = true;
            this.chk_Active.Values.Text = "Active";
            // 
            // cmb_SalesOrdersWithLines1
            // 
            this.cmb_SalesOrdersWithLines1.ArticleId = 0;
            this.cmb_SalesOrdersWithLines1.BatchId = 0;
            this.cmb_SalesOrdersWithLines1.Location = new System.Drawing.Point(94, 103);
            this.cmb_SalesOrdersWithLines1.Name = "cmb_SalesOrdersWithLines1";
            this.cmb_SalesOrdersWithLines1.QtyInCO = 0D;
            this.cmb_SalesOrdersWithLines1.SalesOrder = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            this.cmb_SalesOrdersWithLines1.SalesOrderLine = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            this.cmb_SalesOrdersWithLines1.Size = new System.Drawing.Size(199, 21);
            this.cmb_SalesOrdersWithLines1.TabIndex = 232;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(159, 276);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel6.TabIndex = 231;
            this.kryptonLabel6.Values.Text = "till:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(5, 277);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel9.TabIndex = 230;
            this.kryptonLabel9.Values.Text = "From:";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(5, 256);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(112, 20);
            this.kryptonLabel10.TabIndex = 228;
            this.kryptonLabel10.Values.Text = "End of production:";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(159, 236);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel11.TabIndex = 226;
            this.kryptonLabel11.Values.Text = "till:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(5, 237);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 225;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(5, 217);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(117, 20);
            this.kryptonLabel7.TabIndex = 223;
            this.kryptonLabel7.Values.Text = "Start of production:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(5, 195);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel5.TabIndex = 221;
            this.kryptonLabel5.Values.Text = "Department:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(5, 169);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel4.TabIndex = 220;
            this.kryptonLabel4.Values.Text = "Type:";
            // 
            // cmb_Department1
            // 
            this.cmb_Department1.Department = "";
            this.cmb_Department1.DeptId = 0;
            this.cmb_Department1.Location = new System.Drawing.Point(93, 195);
            this.cmb_Department1.Name = "cmb_Department1";
            this.cmb_Department1.SelectedNode = null;
            this.cmb_Department1.Size = new System.Drawing.Size(143, 20);
            this.cmb_Department1.TabIndex = 219;
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(93, 169);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(167, 20);
            this.cmb_Types1.TabIndex = 218;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 121);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel3.TabIndex = 217;
            this.kryptonLabel3.Values.Text = "Article:";
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
            this.cmb_Articles1.Location = new System.Drawing.Point(9, 144);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(284, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 216;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(8, 72);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 215;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 45);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 214;
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
            this.cmb_Batches1.Location = new System.Drawing.Point(94, 45);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(128, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 213;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(7, 103);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel1.TabIndex = 212;
            this.kryptonLabel1.Values.Text = "Conf. order:";
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(313, 42);
            this.kryptonHeader1.TabIndex = 2;
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
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_batch,
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
            this.cn_parentbatch,
            this.chk_urgent,
            this.cn_dateofclosing,
            this.cn_type,
            this.cn_department,
            this.cn_createdat,
            this.cn_creatby,
            this.cn_customer,
            this.cn_conforder,
            this.cn_complected,
            this.cn_qtystock,
            this.cn_coid,
            this.cn_ALLSTAGES,
            this.cn_SMT,
            this.cn_THT,
            this.cn_FTA,
            this.cn_IPA,
            this.cn_rmstateid,
            this.chk_blocked,
            this.cn_coartid});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(995, 330);
            this.gv_List.TabIndex = 4;
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
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
            this.cn_secname.FillWeight = 200F;
            this.cn_secname.HeaderText = "2nd name";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.ReadOnly = true;
            this.cn_secname.Width = 200;
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
            // cn_parentbatch
            // 
            this.cn_parentbatch.DataPropertyName = "parentbatch";
            this.cn_parentbatch.FillWeight = 90F;
            this.cn_parentbatch.HeaderText = "Parent batch";
            this.cn_parentbatch.Name = "cn_parentbatch";
            this.cn_parentbatch.ReadOnly = true;
            this.cn_parentbatch.Width = 90;
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
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "creatat";
            this.cn_createdat.FillWeight = 50F;
            this.cn_createdat.HeaderText = "Created at";
            this.cn_createdat.Name = "cn_createdat";
            this.cn_createdat.ReadOnly = true;
            this.cn_createdat.Width = 50;
            // 
            // cn_creatby
            // 
            this.cn_creatby.DataPropertyName = "creatby";
            this.cn_creatby.HeaderText = "Created by";
            this.cn_creatby.Name = "cn_creatby";
            this.cn_creatby.ReadOnly = true;
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            this.cn_customer.ReadOnly = true;
            // 
            // cn_conforder
            // 
            this.cn_conforder.DataPropertyName = "conforder";
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            this.cn_conforder.ReadOnly = true;
            // 
            // cn_complected
            // 
            this.cn_complected.DataPropertyName = "complected";
            this.cn_complected.HeaderText = "complected";
            this.cn_complected.Name = "cn_complected";
            this.cn_complected.ReadOnly = true;
            this.cn_complected.Visible = false;
            // 
            // cn_qtystock
            // 
            this.cn_qtystock.DataPropertyName = "qtystock";
            this.cn_qtystock.HeaderText = "Stock qty";
            this.cn_qtystock.Name = "cn_qtystock";
            this.cn_qtystock.ReadOnly = true;
            // 
            // cn_coid
            // 
            this.cn_coid.DataPropertyName = "coid";
            this.cn_coid.HeaderText = "coid";
            this.cn_coid.Name = "cn_coid";
            this.cn_coid.ReadOnly = true;
            this.cn_coid.Visible = false;
            // 
            // cn_ALLSTAGES
            // 
            this.cn_ALLSTAGES.DataPropertyName = "ALL_STAGES";
            this.cn_ALLSTAGES.FillWeight = 60F;
            this.cn_ALLSTAGES.HeaderText = "ALL STAGES";
            this.cn_ALLSTAGES.Name = "cn_ALLSTAGES";
            this.cn_ALLSTAGES.ReadOnly = true;
            this.cn_ALLSTAGES.Width = 60;
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
            // cn_THT
            // 
            this.cn_THT.DataPropertyName = "THT";
            this.cn_THT.FillWeight = 60F;
            this.cn_THT.HeaderText = "THT";
            this.cn_THT.Name = "cn_THT";
            this.cn_THT.ReadOnly = true;
            this.cn_THT.Width = 60;
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
            // cn_IPA
            // 
            this.cn_IPA.DataPropertyName = "IPA";
            this.cn_IPA.FillWeight = 60F;
            this.cn_IPA.HeaderText = "IPA";
            this.cn_IPA.Name = "cn_IPA";
            this.cn_IPA.ReadOnly = true;
            this.cn_IPA.Width = 60;
            // 
            // cn_rmstateid
            // 
            this.cn_rmstateid.DataPropertyName = "rmstateid";
            this.cn_rmstateid.HeaderText = "rm state";
            this.cn_rmstateid.Name = "cn_rmstateid";
            this.cn_rmstateid.ReadOnly = true;
            this.cn_rmstateid.Visible = false;
            // 
            // chk_blocked
            // 
            this.chk_blocked.DataPropertyName = "blocked";
            this.chk_blocked.FalseValue = "0";
            this.chk_blocked.FillWeight = 40F;
            this.chk_blocked.HeaderText = "Blocked";
            this.chk_blocked.IndeterminateValue = "1";
            this.chk_blocked.Name = "chk_blocked";
            this.chk_blocked.ReadOnly = true;
            this.chk_blocked.TrueValue = "-1";
            this.chk_blocked.Width = 40;
            // 
            // cn_coartid
            // 
            this.cn_coartid.DataPropertyName = "coartid";
            this.cn_coartid.HeaderText = "CO art. id.";
            this.cn_coartid.Name = "cn_coartid";
            this.cn_coartid.ReadOnly = true;
            this.cn_coartid.Visible = false;
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
            this.mni_Admin.Click += new System.EventHandler(this.mni_Admin_Click);
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
            this.btn_AddNew,
            this.btn_Edit,
            this.btn_Copy,
            this.btn_Delete,
            this.btn_Active,
            this.btn_Block,
            this.btn_OpenBatch,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 330);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(995, 25);
            this.bn_List.TabIndex = 2;
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
            // btn_AddNew
            // 
            this.btn_AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNew.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.Image")));
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.RightToLeftAutoMirrorImage = true;
            this.btn_AddNew.Size = new System.Drawing.Size(23, 22);
            this.btn_AddNew.Text = "Add new";
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Edit.Image = global::Odin.Global_Resourses.edit;
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(23, 22);
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.btn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(23, 22);
            this.btn_Copy.Text = "Copy article";
            this.btn_Copy.Visible = false;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RightToLeftAutoMirrorImage = true;
            this.btn_Delete.Size = new System.Drawing.Size(23, 22);
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Active
            // 
            this.btn_Active.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Active.Image = global::Odin.Global_Resourses._lock;
            this.btn_Active.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(23, 22);
            this.btn_Active.Text = "Make inactive";
            this.btn_Active.Click += new System.EventHandler(this.btn_Active_Click);
            // 
            // btn_Block
            // 
            this.btn_Block.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Block.Image = global::Odin.Global_Resourses.stop16x16_1;
            this.btn_Block.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Block.Name = "btn_Block";
            this.btn_Block.Size = new System.Drawing.Size(23, 22);
            this.btn_Block.Text = "Block batch";
            this.btn_Block.Click += new System.EventHandler(this.btn_Block_Click);
            // 
            // btn_OpenBatch
            // 
            this.btn_OpenBatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_OpenBatch.Image = global::Odin.Global_Resourses.Unlock1;
            this.btn_OpenBatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_OpenBatch.Name = "btn_OpenBatch";
            this.btn_OpenBatch.Size = new System.Drawing.Size(23, 22);
            this.btn_OpenBatch.Text = "Open batch";
            this.btn_OpenBatch.Visible = false;
            this.btn_OpenBatch.Click += new System.EventHandler(this.btn_OpenBatch_Click);
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
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabHighProfile;
            this.kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "3603EBC349EA4AA52F8724469FC85DA3";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1313, 184);
            this.kryptonDockableWorkspace1.TabIndex = 4;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // frm_Batches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 593);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Batches";
            this.TabText = "Batches view";
            this.Text = "Batches view";
            this.Load += new System.EventHandler(this.frm_Batches_Load);
            this.Resize += new System.EventHandler(this.frm_Batches_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
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
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Main _Main;

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_BatchRM;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_DistributeRM;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_POReservation;
        private System.Windows.Forms.ImageList imageListSmall;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CMB_Components.Departments.cmb_Department cmb_Department1;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Active;
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
        private System.Windows.Forms.ToolStripButton btn_AddNew;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton btn_Copy;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_Active;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_General;
        private CustomControls.NullableDateTimePicker txt_EndTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private CustomControls.NullableDateTimePicker txt_EndFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private CustomControls.NullableDateTimePicker txt_StartTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private CustomControls.NullableDateTimePicker txt_StartFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Totals;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_BatchStock;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Orders;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Passport;
        private System.Windows.Forms.ToolStripButton btn_OpenBatch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Tracing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_PrintRouteList;
        private Owf.Controls.GradientPanel2 gradientPanel21;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private CMB_Components.Users.cmb_Users cmb_Users1;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_QCTracing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RMDeficite;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Launches;
        private System.Windows.Forms.ToolStripButton btn_Block;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_parentbatch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_urgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dateofclosing;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_creatby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_complected;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtystock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ALLSTAGES;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_SMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_THT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_FTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_IPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rmstateid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_blocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coartid;
    }
}