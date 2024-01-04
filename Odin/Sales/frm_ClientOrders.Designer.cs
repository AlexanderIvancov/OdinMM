namespace Odin.Sales
{
    partial class frm_ClientOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ClientOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.chk_Cancelled = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_Closed = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_InProcess = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_New = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.txt_ReqDateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny6 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_CreatDateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_ReqDateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_CreatDateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Department1 = new Odin.CMB_Components.Departments.cmb_Department();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CustArticle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny7 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CustOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_SalesOrders1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrders();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
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
            this.btn_AddNew = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Copy = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_SendEmail = new System.Windows.Forms.ToolStripButton();
            this.btn_MakeCOAsPO = new System.Windows.Forms.ToolStripButton();
            this.btn_Active = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_CapacityAnalyze = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Invoices = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Launches = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_AwaitingCost = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Delays = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Process = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Batches = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_History = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Documents = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_General = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Payments = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Deliveries = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Confirmations = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custorderline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_servce = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reqdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_logcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_delivplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_delivaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_quotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_leadweek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtydelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtytosend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_endcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_resale = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_qtystock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_blockdelivery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_salescomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_isprimary = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
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
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            this.kryptonDockingManager1.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager1_DockspaceAdding);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
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
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1467, 685);
            this.kryptonSplitContainer1.SplitterDistance = 440;
            this.kryptonSplitContainer1.TabIndex = 5;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Cancelled);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Closed);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_InProcess);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_New);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_ReqDateTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CreatDateTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_ReqDateFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CreatDateFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel16);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel15);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Department1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel14);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CustArticle);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Comments);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Common1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel13);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel12);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel11);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel9);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel10);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Types1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CustOrder);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Batches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_SalesOrders1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1467, 440);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // chk_Cancelled
            // 
            this.chk_Cancelled.Location = new System.Drawing.Point(151, 192);
            this.chk_Cancelled.Name = "chk_Cancelled";
            this.chk_Cancelled.Size = new System.Drawing.Size(76, 20);
            this.chk_Cancelled.TabIndex = 245;
            this.chk_Cancelled.Values.Text = "Cancelled";
            // 
            // chk_Closed
            // 
            this.chk_Closed.Location = new System.Drawing.Point(233, 192);
            this.chk_Closed.Name = "chk_Closed";
            this.chk_Closed.Size = new System.Drawing.Size(60, 20);
            this.chk_Closed.TabIndex = 244;
            this.chk_Closed.Values.Text = "Closed";
            // 
            // chk_InProcess
            // 
            this.chk_InProcess.Checked = true;
            this.chk_InProcess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_InProcess.Location = new System.Drawing.Point(68, 192);
            this.chk_InProcess.Name = "chk_InProcess";
            this.chk_InProcess.Size = new System.Drawing.Size(79, 20);
            this.chk_InProcess.TabIndex = 243;
            this.chk_InProcess.Values.Text = "In process";
            // 
            // chk_New
            // 
            this.chk_New.Checked = true;
            this.chk_New.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_New.Location = new System.Drawing.Point(13, 192);
            this.chk_New.Name = "chk_New";
            this.chk_New.Size = new System.Drawing.Size(48, 20);
            this.chk_New.TabIndex = 242;
            this.chk_New.Values.Text = "New";
            // 
            // txt_ReqDateTill
            // 
            this.txt_ReqDateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny6});
            this.txt_ReqDateTill.CalendarShowWeekNumbers = true;
            this.txt_ReqDateTill.CustomFormat = null;
            this.txt_ReqDateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ReqDateTill.Location = new System.Drawing.Point(189, 375);
            this.txt_ReqDateTill.Name = "txt_ReqDateTill";
            this.txt_ReqDateTill.NullValue = " ";
            this.txt_ReqDateTill.Size = new System.Drawing.Size(105, 21);
            this.txt_ReqDateTill.TabIndex = 217;
            this.txt_ReqDateTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_ReqDateTill_DropDown);
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny6.UniqueName = "8965B894993B4F920291611D31488FC0";
            this.buttonSpecAny6.Click += new System.EventHandler(this.buttonSpecAny6_Click);
            // 
            // txt_CreatDateTill
            // 
            this.txt_CreatDateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_CreatDateTill.CalendarShowWeekNumbers = true;
            this.txt_CreatDateTill.CustomFormat = null;
            this.txt_CreatDateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CreatDateTill.Location = new System.Drawing.Point(190, 331);
            this.txt_CreatDateTill.Name = "txt_CreatDateTill";
            this.txt_CreatDateTill.NullValue = " ";
            this.txt_CreatDateTill.Size = new System.Drawing.Size(105, 21);
            this.txt_CreatDateTill.TabIndex = 216;
            this.txt_CreatDateTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_CreatDateTill_DropDown);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny4.UniqueName = "6A2751F9284C45EEA28C814570A892DD";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // txt_ReqDateFrom
            // 
            this.txt_ReqDateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_ReqDateFrom.CalendarShowWeekNumbers = true;
            this.txt_ReqDateFrom.CustomFormat = null;
            this.txt_ReqDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ReqDateFrom.Location = new System.Drawing.Point(54, 375);
            this.txt_ReqDateFrom.Name = "txt_ReqDateFrom";
            this.txt_ReqDateFrom.NullValue = " ";
            this.txt_ReqDateFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_ReqDateFrom.TabIndex = 215;
            this.txt_ReqDateFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_ReqDateFrom_DropDown);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "2AEB854929374CB361A80771E44C2EAD";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // txt_CreatDateFrom
            // 
            this.txt_CreatDateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_CreatDateFrom.CalendarShowWeekNumbers = true;
            this.txt_CreatDateFrom.CustomFormat = null;
            this.txt_CreatDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CreatDateFrom.Location = new System.Drawing.Point(54, 331);
            this.txt_CreatDateFrom.Name = "txt_CreatDateFrom";
            this.txt_CreatDateFrom.NullValue = " ";
            this.txt_CreatDateFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_CreatDateFrom.TabIndex = 213;
            this.txt_CreatDateFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_CreatDateFrom_DropDown);
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny5.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny5.Click += new System.EventHandler(this.buttonSpecAny5_Click);
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(7, 104);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 210;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(7, 213);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel16.TabIndex = 35;
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
            this.cmb_Articles1.Location = new System.Drawing.Point(12, 233);
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
            this.cmb_Articles1.TabIndex = 34;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(7, 166);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel15.TabIndex = 33;
            this.kryptonLabel15.Values.Text = "Department:";
            // 
            // cmb_Department1
            // 
            this.cmb_Department1.Department = "";
            this.cmb_Department1.DeptId = 0;
            this.cmb_Department1.Location = new System.Drawing.Point(91, 166);
            this.cmb_Department1.Name = "cmb_Department1";
            this.cmb_Department1.SelectedNode = null;
            this.cmb_Department1.Size = new System.Drawing.Size(179, 20);
            this.cmb_Department1.TabIndex = 32;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(7, 283);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel14.TabIndex = 31;
            this.kryptonLabel14.Values.Text = "Cust. article:";
            // 
            // txt_CustArticle
            // 
            this.txt_CustArticle.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny7});
            this.txt_CustArticle.Location = new System.Drawing.Point(91, 283);
            this.txt_CustArticle.Name = "txt_CustArticle";
            this.txt_CustArticle.Size = new System.Drawing.Size(204, 23);
            this.txt_CustArticle.TabIndex = 30;
            // 
            // buttonSpecAny7
            // 
            this.buttonSpecAny7.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny7.UniqueName = "90C4E6C9A1E1431FA6AE4F89E70F2995";
            this.buttonSpecAny7.Click += new System.EventHandler(this.buttonSpecAny7_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(7, 402);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel5.TabIndex = 29;
            this.kryptonLabel5.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_Comments.Location = new System.Drawing.Point(91, 402);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(204, 36);
            this.txt_Comments.TabIndex = 28;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "90C4E6C9A1E1431FA6AE4F89E70F2995";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click_1);
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(91, 444);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(148, 20);
            this.cmb_Common1.sTable = "SAL_OrderState";
            this.cmb_Common1.sText_Filled = "code";
            this.cmb_Common1.sTitle = "Order states";
            this.cmb_Common1.TabIndex = 27;
            this.cmb_Common1.Visible = false;
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(7, 444);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel13.TabIndex = 26;
            this.kryptonLabel13.Values.Text = "State:";
            this.kryptonLabel13.Visible = false;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(161, 376);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel12.TabIndex = 24;
            this.kryptonLabel12.Values.Text = "till:";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(161, 331);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel11.TabIndex = 23;
            this.kryptonLabel11.Values.Text = "till:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(7, 376);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel9.TabIndex = 22;
            this.kryptonLabel9.Values.Text = "From:";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(7, 355);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(156, 20);
            this.kryptonLabel10.TabIndex = 21;
            this.kryptonLabel10.Values.Text = "Requested delivery period:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(7, 332);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(7, 311);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(118, 20);
            this.kryptonLabel7.TabIndex = 16;
            this.kryptonLabel7.Values.Text = "Registration period:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(7, 140);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel6.TabIndex = 14;
            this.kryptonLabel6.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(91, 140);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Types1.TabIndex = 13;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(7, 257);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel4.TabIndex = 10;
            this.kryptonLabel4.Values.Text = "Cust. order:";
            // 
            // txt_CustOrder
            // 
            this.txt_CustOrder.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_CustOrder.Location = new System.Drawing.Point(91, 257);
            this.txt_CustOrder.Name = "txt_CustOrder";
            this.txt_CustOrder.Size = new System.Drawing.Size(148, 23);
            this.txt_CustOrder.TabIndex = 9;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "90C4E6C9A1E1431FA6AE4F89E70F2995";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 114);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Customer:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(91, 114);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 7;
            this.cmb_Firms1.VATNr = null;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(7, 77);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 5;
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
            this.cmb_Batches1.Location = new System.Drawing.Point(131, 77);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(163, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(7, 51);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(118, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Confirmation order:";
            // 
            // cmb_SalesOrders1
            // 
            this.cmb_SalesOrders1.ClientId = 0;
            this.cmb_SalesOrders1.ContactPersonId = 0;
            this.cmb_SalesOrders1.Contract = "";
            this.cmb_SalesOrders1.EnableSearchId = false;
            this.cmb_SalesOrders1.Internal = 0;
            this.cmb_SalesOrders1.Location = new System.Drawing.Point(131, 51);
            this.cmb_SalesOrders1.Name = "cmb_SalesOrders1";
            this.cmb_SalesOrders1.SalesOrder = "";
            this.cmb_SalesOrders1.SalesOrderId = 0;
            this.cmb_SalesOrders1.SalesOrderSavedId = 0;
            this.cmb_SalesOrders1.Size = new System.Drawing.Size(163, 20);
            this.cmb_SalesOrders1.TabIndex = 2;
            this.cmb_SalesOrders1.SalesOrderChanged += new Odin.CMB_Components.SalesOrders.SalesOrdersEventHandler(this.cmb_SalesOrders1_SalesOrderChanged);
            this.cmb_SalesOrders1.SalesOrderSaved += new Odin.CMB_Components.SalesOrders.SalesOrdersSavedEventHandler(this.cmb_SalesOrders1_SalesOrderSaved);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear});
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
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_headid,
            this.cn_name,
            this.cn_contract,
            this.cn_client,
            this.cn_line,
            this.cn_custorder,
            this.cn_custorderline,
            this.cn_artid,
            this.cn_article,
            this.cn_secname,
            this.cn_type,
            this.cn_department,
            this.chk_servce,
            this.cn_qty,
            this.cn_unit,
            this.cn_reqdate,
            this.cn_state,
            this.cn_unitprice,
            this.cn_currency,
            this.cn_vat,
            this.cn_comments,
            this.cn_comments1,
            this.cn_logcomments,
            this.cn_delivplace,
            this.cn_delivaddress,
            this.cn_createdat,
            this.cn_createdby,
            this.cn_quotation,
            this.cn_leadweek,
            this.cn_qtydelivered,
            this.cn_qtytosend,
            this.cn_stateid,
            this.cn_endcustomer,
            this.cn_paid,
            this.chk_resale,
            this.cn_qtystock,
            this.cn_blockdelivery,
            this.cn_salescomments,
            this.chk_isprimary});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_List.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_List.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_List.Size = new System.Drawing.Size(1163, 415);
            this.gv_List.TabIndex = 3;
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
            this.btn_AddNew,
            this.btn_Edit,
            this.btn_Copy,
            this.btn_Delete,
            this.btn_SendEmail,
            this.btn_MakeCOAsPO,
            this.btn_Active,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 415);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(1163, 25);
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
            this.btn_Copy.Text = "Copy confirmation order";
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
            // btn_SendEmail
            // 
            this.btn_SendEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_SendEmail.Image = global::Odin.Global_Resourses.SendMail;
            this.btn_SendEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(23, 22);
            this.btn_SendEmail.Text = "Send email";
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // btn_MakeCOAsPO
            // 
            this.btn_MakeCOAsPO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_MakeCOAsPO.Image = global::Odin.Global_Resourses.basket_put;
            this.btn_MakeCOAsPO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_MakeCOAsPO.Name = "btn_MakeCOAsPO";
            this.btn_MakeCOAsPO.Size = new System.Drawing.Size(23, 22);
            this.btn_MakeCOAsPO.Text = "Make CO as PO";
            this.btn_MakeCOAsPO.Click += new System.EventHandler(this.btn_MakeCOAsPO_Click);
            // 
            // btn_Active
            // 
            this.btn_Active.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Active.Image = global::Odin.Global_Resourses.stop16x16_1;
            this.btn_Active.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(23, 22);
            this.btn_Active.Text = "Make inactive";
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
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1467, 240);
            this.kryptonDockableWorkspace1.TabIndex = 4;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_CapacityAnalyze);
            this.kryptonPanel1.Controls.Add(this.btn_Invoices);
            this.kryptonPanel1.Controls.Add(this.btn_Launches);
            this.kryptonPanel1.Controls.Add(this.btn_AwaitingCost);
            this.kryptonPanel1.Controls.Add(this.btn_Delays);
            this.kryptonPanel1.Controls.Add(this.btn_Process);
            this.kryptonPanel1.Controls.Add(this.btn_Batches);
            this.kryptonPanel1.Controls.Add(this.btn_History);
            this.kryptonPanel1.Controls.Add(this.btn_Documents);
            this.kryptonPanel1.Controls.Add(this.btn_General);
            this.kryptonPanel1.Controls.Add(this.btn_Payments);
            this.kryptonPanel1.Controls.Add(this.btn_Deliveries);
            this.kryptonPanel1.Controls.Add(this.btn_Confirmations);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1467, 49);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // btn_CapacityAnalyze
            // 
            this.btn_CapacityAnalyze.Location = new System.Drawing.Point(1209, 5);
            this.btn_CapacityAnalyze.Name = "btn_CapacityAnalyze";
            this.btn_CapacityAnalyze.Size = new System.Drawing.Size(144, 39);
            this.btn_CapacityAnalyze.TabIndex = 18;
            this.btn_CapacityAnalyze.Values.Image = global::Odin.Global_Resourses.participation_rate;
            this.btn_CapacityAnalyze.Values.Text = "Capacity analyze";
            this.btn_CapacityAnalyze.Click += new System.EventHandler(this.btn_CapacityAnalyze_Click);
            // 
            // btn_Invoices
            // 
            this.btn_Invoices.Location = new System.Drawing.Point(1344, 5);
            this.btn_Invoices.Name = "btn_Invoices";
            this.btn_Invoices.Size = new System.Drawing.Size(105, 39);
            this.btn_Invoices.TabIndex = 16;
            this.btn_Invoices.Values.Image = global::Odin.Global_Resourses.invoice24x24;
            this.btn_Invoices.Values.Text = "Invoices";
            this.btn_Invoices.Visible = false;
            this.btn_Invoices.Click += new System.EventHandler(this.btn_Invoices_Click);
            // 
            // btn_Launches
            // 
            this.btn_Launches.Location = new System.Drawing.Point(971, 5);
            this.btn_Launches.Name = "btn_Launches";
            this.btn_Launches.Size = new System.Drawing.Size(100, 39);
            this.btn_Launches.TabIndex = 15;
            this.btn_Launches.Values.Image = global::Odin.Global_Resourses.launch;
            this.btn_Launches.Values.Text = "Launches";
            this.btn_Launches.Click += new System.EventHandler(this.btn_Launches_Click);
            // 
            // btn_AwaitingCost
            // 
            this.btn_AwaitingCost.Location = new System.Drawing.Point(1076, 5);
            this.btn_AwaitingCost.Name = "btn_AwaitingCost";
            this.btn_AwaitingCost.Size = new System.Drawing.Size(128, 39);
            this.btn_AwaitingCost.TabIndex = 11;
            this.btn_AwaitingCost.Values.Image = global::Odin.Global_Resourses.coins_delete;
            this.btn_AwaitingCost.Values.Text = "Awaiting cost";
            this.btn_AwaitingCost.Click += new System.EventHandler(this.btn_AwaitingCost_Click);
            // 
            // btn_Delays
            // 
            this.btn_Delays.Location = new System.Drawing.Point(422, 5);
            this.btn_Delays.Name = "btn_Delays";
            this.btn_Delays.Size = new System.Drawing.Size(95, 39);
            this.btn_Delays.TabIndex = 9;
            this.btn_Delays.Values.Image = global::Odin.Global_Resourses.Exclamation_Mark;
            this.btn_Delays.Values.Text = "Delays";
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(107, 5);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(92, 39);
            this.btn_Process.TabIndex = 2;
            this.btn_Process.Values.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.btn_Process.Values.Text = "Process";
            // 
            // btn_Batches
            // 
            this.btn_Batches.Location = new System.Drawing.Point(202, 5);
            this.btn_Batches.Name = "btn_Batches";
            this.btn_Batches.Size = new System.Drawing.Size(92, 39);
            this.btn_Batches.TabIndex = 3;
            this.btn_Batches.Values.Image = global::Odin.Global_Resourses.ksirtet_24x24;
            this.btn_Batches.Values.Text = "Batches";
            this.btn_Batches.Click += new System.EventHandler(this.btn_Batches_Click);
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(742, 5);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(109, 39);
            this.btn_History.TabIndex = 7;
            this.btn_History.Values.Image = global::Odin.Global_Resourses.emblem_library_9156;
            this.btn_History.Values.Text = "History";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Documents
            // 
            this.btn_Documents.Location = new System.Drawing.Point(856, 5);
            this.btn_Documents.Name = "btn_Documents";
            this.btn_Documents.Size = new System.Drawing.Size(109, 39);
            this.btn_Documents.TabIndex = 8;
            this.btn_Documents.Values.Image = global::Odin.Global_Resourses.folder_documents;
            this.btn_Documents.Values.Text = "Documents";
            // 
            // btn_General
            // 
            this.btn_General.Location = new System.Drawing.Point(4, 5);
            this.btn_General.Name = "btn_General";
            this.btn_General.Size = new System.Drawing.Size(100, 39);
            this.btn_General.TabIndex = 1;
            this.btn_General.Values.Image = global::Odin.Global_Resourses.Docs;
            this.btn_General.Values.Text = "General";
            this.btn_General.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Payments
            // 
            this.btn_Payments.Location = new System.Drawing.Point(634, 5);
            this.btn_Payments.Name = "btn_Payments";
            this.btn_Payments.Size = new System.Drawing.Size(105, 39);
            this.btn_Payments.TabIndex = 6;
            this.btn_Payments.Values.Image = global::Odin.Global_Resourses.payment_icon;
            this.btn_Payments.Values.Text = "Payments";
            this.btn_Payments.Click += new System.EventHandler(this.btn_Payments_Click);
            // 
            // btn_Deliveries
            // 
            this.btn_Deliveries.Location = new System.Drawing.Point(521, 5);
            this.btn_Deliveries.Name = "btn_Deliveries";
            this.btn_Deliveries.Size = new System.Drawing.Size(109, 39);
            this.btn_Deliveries.TabIndex = 5;
            this.btn_Deliveries.Values.Image = global::Odin.Global_Resourses.truckyellow24x24;
            this.btn_Deliveries.Values.Text = "Deliveries";
            this.btn_Deliveries.Click += new System.EventHandler(this.btn_Deliveries_Click);
            // 
            // btn_Confirmations
            // 
            this.btn_Confirmations.Location = new System.Drawing.Point(297, 5);
            this.btn_Confirmations.Name = "btn_Confirmations";
            this.btn_Confirmations.Size = new System.Drawing.Size(121, 39);
            this.btn_Confirmations.TabIndex = 4;
            this.btn_Confirmations.Values.Image = global::Odin.Global_Resourses.signature_5789;
            this.btn_Confirmations.Values.Text = "Confirmations";
            this.btn_Confirmations.Click += new System.EventHandler(this.btn_Confirmations_Click);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            // 
            // cn_headid
            // 
            this.cn_headid.DataPropertyName = "headid";
            this.cn_headid.HeaderText = "headid";
            this.cn_headid.Name = "cn_headid";
            this.cn_headid.ReadOnly = true;
            this.cn_headid.Visible = false;
            // 
            // cn_name
            // 
            this.cn_name.DataPropertyName = "name";
            this.cn_name.FillWeight = 90F;
            this.cn_name.HeaderText = "Order";
            this.cn_name.Name = "cn_name";
            this.cn_name.ReadOnly = true;
            this.cn_name.Width = 90;
            // 
            // cn_contract
            // 
            this.cn_contract.DataPropertyName = "contract";
            this.cn_contract.HeaderText = "Contract";
            this.cn_contract.Name = "cn_contract";
            this.cn_contract.ReadOnly = true;
            // 
            // cn_client
            // 
            this.cn_client.DataPropertyName = "client";
            this.cn_client.FillWeight = 120F;
            this.cn_client.HeaderText = "Client";
            this.cn_client.Name = "cn_client";
            this.cn_client.ReadOnly = true;
            this.cn_client.Width = 120;
            // 
            // cn_line
            // 
            this.cn_line.DataPropertyName = "orderline";
            this.cn_line.FillWeight = 30F;
            this.cn_line.HeaderText = "Line";
            this.cn_line.Name = "cn_line";
            this.cn_line.ReadOnly = true;
            this.cn_line.Width = 30;
            // 
            // cn_custorder
            // 
            this.cn_custorder.DataPropertyName = "custorder";
            this.cn_custorder.HeaderText = "Cust. order";
            this.cn_custorder.Name = "cn_custorder";
            this.cn_custorder.ReadOnly = true;
            // 
            // cn_custorderline
            // 
            this.cn_custorderline.DataPropertyName = "custorderline";
            this.cn_custorderline.FillWeight = 30F;
            this.cn_custorderline.HeaderText = "CO line";
            this.cn_custorderline.Name = "cn_custorderline";
            this.cn_custorderline.ReadOnly = true;
            this.cn_custorderline.Width = 30;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
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
            this.cn_secname.DataPropertyName = "custarticle";
            this.cn_secname.FillWeight = 150F;
            this.cn_secname.HeaderText = "Cust. article";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.ReadOnly = true;
            this.cn_secname.Width = 150;
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
            // chk_servce
            // 
            this.chk_servce.DataPropertyName = "service";
            this.chk_servce.FillWeight = 40F;
            this.chk_servce.HeaderText = "Service";
            this.chk_servce.Name = "chk_servce";
            this.chk_servce.ReadOnly = true;
            this.chk_servce.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk_servce.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk_servce.Width = 40;
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
            // cn_reqdate
            // 
            this.cn_reqdate.DataPropertyName = "reqdate";
            this.cn_reqdate.HeaderText = "Requested date";
            this.cn_reqdate.Name = "cn_reqdate";
            this.cn_reqdate.ReadOnly = true;
            // 
            // cn_state
            // 
            this.cn_state.DataPropertyName = "state";
            this.cn_state.FillWeight = 80F;
            this.cn_state.HeaderText = "State";
            this.cn_state.Name = "cn_state";
            this.cn_state.ReadOnly = true;
            this.cn_state.Width = 80;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price";
            this.cn_unitprice.Name = "cn_unitprice";
            this.cn_unitprice.ReadOnly = true;
            // 
            // cn_currency
            // 
            this.cn_currency.DataPropertyName = "currency";
            this.cn_currency.FillWeight = 40F;
            this.cn_currency.HeaderText = "Currency";
            this.cn_currency.Name = "cn_currency";
            this.cn_currency.ReadOnly = true;
            this.cn_currency.Width = 40;
            // 
            // cn_vat
            // 
            this.cn_vat.DataPropertyName = "vat";
            this.cn_vat.FillWeight = 30F;
            this.cn_vat.HeaderText = "VAT";
            this.cn_vat.Name = "cn_vat";
            this.cn_vat.ReadOnly = true;
            this.cn_vat.Width = 30;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_comments.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.ReadOnly = true;
            this.cn_comments.Width = 5;
            // 
            // cn_comments1
            // 
            this.cn_comments1.DataPropertyName = "comments1";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_comments1.DefaultCellStyle = dataGridViewCellStyle2;
            this.cn_comments1.HeaderText = "Comments part 2";
            this.cn_comments1.Name = "cn_comments1";
            this.cn_comments1.ReadOnly = true;
            // 
            // cn_logcomments
            // 
            this.cn_logcomments.DataPropertyName = "logcomments";
            this.cn_logcomments.HeaderText = "Log. comments";
            this.cn_logcomments.Name = "cn_logcomments";
            this.cn_logcomments.ReadOnly = true;
            // 
            // cn_delivplace
            // 
            this.cn_delivplace.DataPropertyName = "delivplace";
            this.cn_delivplace.HeaderText = "Deliv. place";
            this.cn_delivplace.Name = "cn_delivplace";
            this.cn_delivplace.ReadOnly = true;
            this.cn_delivplace.Visible = false;
            // 
            // cn_delivaddress
            // 
            this.cn_delivaddress.DataPropertyName = "delivaddress";
            this.cn_delivaddress.HeaderText = "Deliv. address";
            this.cn_delivaddress.Name = "cn_delivaddress";
            this.cn_delivaddress.ReadOnly = true;
            // 
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "createdat";
            this.cn_createdat.FillWeight = 50F;
            this.cn_createdat.HeaderText = "Created at";
            this.cn_createdat.Name = "cn_createdat";
            this.cn_createdat.ReadOnly = true;
            this.cn_createdat.Width = 50;
            // 
            // cn_createdby
            // 
            this.cn_createdby.DataPropertyName = "createdby";
            this.cn_createdby.HeaderText = "Created by";
            this.cn_createdby.Name = "cn_createdby";
            this.cn_createdby.ReadOnly = true;
            // 
            // cn_quotation
            // 
            this.cn_quotation.DataPropertyName = "quotation";
            this.cn_quotation.HeaderText = "Quotation";
            this.cn_quotation.Name = "cn_quotation";
            this.cn_quotation.ReadOnly = true;
            // 
            // cn_leadweek
            // 
            this.cn_leadweek.DataPropertyName = "leadweek";
            this.cn_leadweek.FillWeight = 80F;
            this.cn_leadweek.HeaderText = "Lead week";
            this.cn_leadweek.Name = "cn_leadweek";
            this.cn_leadweek.ReadOnly = true;
            this.cn_leadweek.Width = 80;
            // 
            // cn_qtydelivered
            // 
            this.cn_qtydelivered.DataPropertyName = "qtydelivered";
            this.cn_qtydelivered.HeaderText = "Delivered";
            this.cn_qtydelivered.Name = "cn_qtydelivered";
            this.cn_qtydelivered.ReadOnly = true;
            // 
            // cn_qtytosend
            // 
            this.cn_qtytosend.DataPropertyName = "qtytosend";
            this.cn_qtytosend.HeaderText = "To send";
            this.cn_qtytosend.Name = "cn_qtytosend";
            this.cn_qtytosend.ReadOnly = true;
            // 
            // cn_stateid
            // 
            this.cn_stateid.DataPropertyName = "stateid";
            this.cn_stateid.HeaderText = "stateid";
            this.cn_stateid.Name = "cn_stateid";
            this.cn_stateid.ReadOnly = true;
            this.cn_stateid.Visible = false;
            // 
            // cn_endcustomer
            // 
            this.cn_endcustomer.DataPropertyName = "endcustomer";
            this.cn_endcustomer.HeaderText = "End customer";
            this.cn_endcustomer.Name = "cn_endcustomer";
            this.cn_endcustomer.ReadOnly = true;
            // 
            // cn_paid
            // 
            this.cn_paid.DataPropertyName = "paid";
            this.cn_paid.HeaderText = "Paid";
            this.cn_paid.Name = "cn_paid";
            this.cn_paid.ReadOnly = true;
            // 
            // chk_resale
            // 
            this.chk_resale.DataPropertyName = "resale";
            this.chk_resale.FalseValue = "0";
            this.chk_resale.FillWeight = 40F;
            this.chk_resale.HeaderText = "Resale";
            this.chk_resale.IndeterminateValue = "1";
            this.chk_resale.Name = "chk_resale";
            this.chk_resale.ReadOnly = true;
            this.chk_resale.TrueValue = "-1";
            this.chk_resale.Width = 40;
            // 
            // cn_qtystock
            // 
            this.cn_qtystock.DataPropertyName = "qtystock";
            this.cn_qtystock.FillWeight = 80F;
            this.cn_qtystock.HeaderText = "Qty stock";
            this.cn_qtystock.Name = "cn_qtystock";
            this.cn_qtystock.ReadOnly = true;
            this.cn_qtystock.Width = 80;
            // 
            // cn_blockdelivery
            // 
            this.cn_blockdelivery.DataPropertyName = "blockdelivery";
            this.cn_blockdelivery.FalseValue = "0";
            this.cn_blockdelivery.FillWeight = 40F;
            this.cn_blockdelivery.HeaderText = "Block delivery";
            this.cn_blockdelivery.IndeterminateValue = "1";
            this.cn_blockdelivery.Name = "cn_blockdelivery";
            this.cn_blockdelivery.ReadOnly = true;
            this.cn_blockdelivery.TrueValue = "-1";
            this.cn_blockdelivery.Width = 40;
            // 
            // cn_salescomments
            // 
            this.cn_salescomments.DataPropertyName = "salescomments";
            this.cn_salescomments.HeaderText = "Sales comments";
            this.cn_salescomments.Name = "cn_salescomments";
            this.cn_salescomments.ReadOnly = true;
            // 
            // chk_isprimary
            // 
            this.chk_isprimary.DataPropertyName = "isprimary";
            this.chk_isprimary.FalseValue = "0";
            this.chk_isprimary.FillWeight = 40F;
            this.chk_isprimary.HeaderText = "Primary";
            this.chk_isprimary.IndeterminateValue = "1";
            this.chk_isprimary.Name = "chk_isprimary";
            this.chk_isprimary.ReadOnly = true;
            this.chk_isprimary.TrueValue = "-1";
            this.chk_isprimary.Width = 40;
            // 
            // frm_ClientOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 734);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ClientOrders";
            this.TabText = "Confirmation orders";
            this.Text = "Confirmation orders";
            this.Load += new System.EventHandler(this.frm_ClientOrders_Load);
            this.Resize += new System.EventHandler(this.frm_ClientOrders_Resize);
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Payments;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Deliveries;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_General;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_History;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Documents;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private CMB_Components.SalesOrders.cmb_SalesOrders cmb_SalesOrders1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustOrder;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private CMB_Components.Common.cmb_Common cmb_Common1;
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
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private System.Windows.Forms.ImageList imageListSmall;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Batches;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustArticle;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private CMB_Components.Departments.cmb_Department cmb_Department1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Process;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Confirmations;
        private CustomControls.NullableDateTimePicker txt_CreatDateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private CustomControls.NullableDateTimePicker txt_ReqDateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private CustomControls.NullableDateTimePicker txt_CreatDateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private CustomControls.NullableDateTimePicker txt_ReqDateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Delays;
        private System.Windows.Forms.ToolStripButton btn_SendEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AwaitingCost;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Cancelled;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Closed;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_InProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_New;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Launches;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Invoices;
        private System.Windows.Forms.ToolStripButton btn_MakeCOAsPO;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_CapacityAnalyze;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custorderline;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_department;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_servce;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reqdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_logcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_delivplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_delivaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_quotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_leadweek;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtydelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtytosend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_endcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_paid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_resale;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtystock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_blockdelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_salescomments;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_isprimary;
    }
}