namespace Odin.CRM
{
    partial class frm_CRMCompanies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CRMCompanies));
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
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.chk_potential = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.txt_Turnover = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Products = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Activities1 = new Odin.CMB_Components.Activities.cmb_Activities();
            this.chk_IsActive = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Countries1 = new Odin.CMB_Components.Countries.cmb_Countries();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_company = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_phone = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_fax = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_email = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_parentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_parentcompany = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_comments = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_countryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_country = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_webaddress = new System.Windows.Forms.DataGridViewLinkColumn();
            this.chk_custmark = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.chk_supmark = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.cn_isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_who = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_turnover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_salespotential = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_spcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_crmstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_crmstateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_crmmanager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_activities = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Active = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_schedule = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Contracts = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Events = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Activity = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_History = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Documents = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_General = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Contacts = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Addresses = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_RespManager = new Odin.CMB_Components.Common.cmb_Common();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
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
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            this.kryptonDockingManager1.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager1_DockspaceAdding);
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
            this.kryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
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
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1081, 658);
            this.kryptonSplitContainer1.SplitterDistance = 277;
            this.kryptonSplitContainer1.TabIndex = 6;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_RespManager);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_potential);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Common1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Turnover);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel14);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Products);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Activities1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_IsActive);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Countries1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1081, 277);
            this.kryptonSplitContainer2.SplitterDistance = 280;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // chk_potential
            // 
            this.chk_potential.Checked = true;
            this.chk_potential.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_potential.Location = new System.Drawing.Point(83, 209);
            this.chk_potential.Name = "chk_potential";
            this.chk_potential.Size = new System.Drawing.Size(103, 20);
            this.chk_potential.TabIndex = 47;
            this.chk_potential.ThreeState = true;
            this.chk_potential.Values.Text = "Sales potential";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(4, 99);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel4.TabIndex = 46;
            this.kryptonLabel4.Values.Text = "State:";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(83, 99);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(148, 20);
            this.cmb_Common1.sTable = "BAS_CRMState";
            this.cmb_Common1.sText_Filled = "state";
            this.cmb_Common1.sTitle = "CRM state";
            this.cmb_Common1.TabIndex = 45;
            // 
            // txt_Turnover
            // 
            this.txt_Turnover.AllowDecimalSeparator = false;
            this.txt_Turnover.AllowSpace = false;
            this.txt_Turnover.Location = new System.Drawing.Point(83, 180);
            this.txt_Turnover.Name = "txt_Turnover";
            this.txt_Turnover.Size = new System.Drawing.Size(87, 23);
            this.txt_Turnover.TabIndex = 44;
            this.txt_Turnover.Text = "0";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(4, 180);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel14.TabIndex = 43;
            this.kryptonLabel14.Values.Text = "Turnover:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(4, 151);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel6.TabIndex = 14;
            this.kryptonLabel6.Values.Text = "Products:";
            // 
            // txt_Products
            // 
            this.txt_Products.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_Products.Location = new System.Drawing.Point(83, 151);
            this.txt_Products.Name = "txt_Products";
            this.txt_Products.Size = new System.Drawing.Size(194, 23);
            this.txt_Products.TabIndex = 13;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "46482B28C1D342E20F86470E7089BEE4";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(4, 125);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Activity:";
            // 
            // cmb_Activities1
            // 
            this.cmb_Activities1.Activity = "";
            this.cmb_Activities1.ActivityId = 0;
            this.cmb_Activities1.EnableSearchId = false;
            this.cmb_Activities1.Location = new System.Drawing.Point(83, 125);
            this.cmb_Activities1.Name = "cmb_Activities1";
            this.cmb_Activities1.Size = new System.Drawing.Size(194, 20);
            this.cmb_Activities1.TabIndex = 7;
            // 
            // chk_IsActive
            // 
            this.chk_IsActive.Checked = true;
            this.chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_IsActive.Location = new System.Drawing.Point(176, 73);
            this.chk_IsActive.Name = "chk_IsActive";
            this.chk_IsActive.Size = new System.Drawing.Size(57, 20);
            this.chk_IsActive.TabIndex = 6;
            this.chk_IsActive.ThreeState = true;
            this.chk_IsActive.Values.Text = "Active";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 73);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Country:";
            // 
            // cmb_Countries1
            // 
            this.cmb_Countries1.Country = "";
            this.cmb_Countries1.CountryId = 0;
            this.cmb_Countries1.EnableSearchId = false;
            this.cmb_Countries1.Location = new System.Drawing.Point(83, 73);
            this.cmb_Countries1.Name = "cmb_Countries1";
            this.cmb_Countries1.Size = new System.Drawing.Size(87, 20);
            this.cmb_Countries1.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 47);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Company:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(83, 47);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(194, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 2;
            this.cmb_Firms1.VATNr = null;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(280, 42);
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
            this.cn_company,
            this.cn_phone,
            this.cn_fax,
            this.cn_email,
            this.cn_parentid,
            this.cn_parentcompany,
            this.cn_comments,
            this.cn_countryid,
            this.cn_country,
            this.cn_webaddress,
            this.chk_custmark,
            this.chk_supmark,
            this.cn_isactive,
            this.cn_when,
            this.cn_who,
            this.cn_turnover,
            this.chk_salespotential,
            this.cn_spcomments,
            this.cn_crmstate,
            this.cn_crmstateid,
            this.cn_budget,
            this.cn_crmmanager,
            this.cn_activities});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(796, 252);
            this.gv_List.TabIndex = 3;
            this.gv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellClick);
            this.gv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellContentClick);
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = " id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            // 
            // cn_company
            // 
            this.cn_company.DataPropertyName = "company";
            this.cn_company.FillWeight = 150F;
            this.cn_company.HeaderText = "Company";
            this.cn_company.Name = "cn_company";
            this.cn_company.ReadOnly = true;
            this.cn_company.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_company.Width = 150;
            // 
            // cn_phone
            // 
            this.cn_phone.DataPropertyName = "phone";
            this.cn_phone.HeaderText = "Phone";
            this.cn_phone.Name = "cn_phone";
            this.cn_phone.ReadOnly = true;
            this.cn_phone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_phone.Width = 100;
            // 
            // cn_fax
            // 
            this.cn_fax.DataPropertyName = "fax";
            this.cn_fax.HeaderText = "Fax";
            this.cn_fax.Name = "cn_fax";
            this.cn_fax.ReadOnly = true;
            this.cn_fax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_fax.Width = 100;
            // 
            // cn_email
            // 
            this.cn_email.DataPropertyName = "email";
            this.cn_email.HeaderText = "Email";
            this.cn_email.Name = "cn_email";
            this.cn_email.ReadOnly = true;
            this.cn_email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_email.Width = 100;
            // 
            // cn_parentid
            // 
            this.cn_parentid.DataPropertyName = "parentid";
            this.cn_parentid.HeaderText = "Parentid";
            this.cn_parentid.Name = "cn_parentid";
            this.cn_parentid.ReadOnly = true;
            this.cn_parentid.Visible = false;
            // 
            // cn_parentcompany
            // 
            this.cn_parentcompany.DataPropertyName = "parentcompany";
            this.cn_parentcompany.FillWeight = 150F;
            this.cn_parentcompany.HeaderText = "Parent company";
            this.cn_parentcompany.Name = "cn_parentcompany";
            this.cn_parentcompany.ReadOnly = true;
            this.cn_parentcompany.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_parentcompany.Width = 150;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.ReadOnly = true;
            this.cn_comments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_comments.Width = 150;
            // 
            // cn_countryid
            // 
            this.cn_countryid.DataPropertyName = "countryid";
            this.cn_countryid.HeaderText = "Countryid";
            this.cn_countryid.Name = "cn_countryid";
            this.cn_countryid.ReadOnly = true;
            this.cn_countryid.Visible = false;
            // 
            // cn_country
            // 
            this.cn_country.DataPropertyName = "country";
            this.cn_country.HeaderText = "Country";
            this.cn_country.Name = "cn_country";
            this.cn_country.ReadOnly = true;
            this.cn_country.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_country.Width = 100;
            // 
            // cn_webaddress
            // 
            this.cn_webaddress.DataPropertyName = "webaddress";
            this.cn_webaddress.HeaderText = "Web address";
            this.cn_webaddress.Name = "cn_webaddress";
            this.cn_webaddress.ReadOnly = true;
            this.cn_webaddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_webaddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chk_custmark
            // 
            this.chk_custmark.DataPropertyName = "custmark";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.chk_custmark.DefaultCellStyle = dataGridViewCellStyle1;
            this.chk_custmark.FalseValue = "0";
            this.chk_custmark.HeaderText = "Customer";
            this.chk_custmark.IndeterminateValue = "1";
            this.chk_custmark.Name = "chk_custmark";
            this.chk_custmark.ReadOnly = true;
            this.chk_custmark.TrueValue = "-1";
            // 
            // chk_supmark
            // 
            this.chk_supmark.DataPropertyName = "supmark";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.chk_supmark.DefaultCellStyle = dataGridViewCellStyle2;
            this.chk_supmark.FalseValue = "0";
            this.chk_supmark.HeaderText = "Supplier";
            this.chk_supmark.IndeterminateValue = "1";
            this.chk_supmark.Name = "chk_supmark";
            this.chk_supmark.ReadOnly = true;
            this.chk_supmark.TrueValue = "-1";
            // 
            // cn_isactive
            // 
            this.cn_isactive.DataPropertyName = "isactive";
            this.cn_isactive.HeaderText = "isactive";
            this.cn_isactive.Name = "cn_isactive";
            this.cn_isactive.ReadOnly = true;
            this.cn_isactive.Visible = false;
            // 
            // cn_when
            // 
            this.cn_when.DataPropertyName = "when";
            this.cn_when.HeaderText = "When";
            this.cn_when.Name = "cn_when";
            this.cn_when.ReadOnly = true;
            this.cn_when.Width = 100;
            // 
            // cn_who
            // 
            this.cn_who.DataPropertyName = "who";
            this.cn_who.HeaderText = "Who";
            this.cn_who.Name = "cn_who";
            this.cn_who.ReadOnly = true;
            this.cn_who.Width = 100;
            // 
            // cn_turnover
            // 
            this.cn_turnover.DataPropertyName = "turnover";
            this.cn_turnover.HeaderText = "Turnover(€)";
            this.cn_turnover.Name = "cn_turnover";
            this.cn_turnover.ReadOnly = true;
            // 
            // chk_salespotential
            // 
            this.chk_salespotential.DataPropertyName = "salespotential";
            this.chk_salespotential.FalseValue = "0";
            this.chk_salespotential.FillWeight = 40F;
            this.chk_salespotential.HeaderText = "Potential";
            this.chk_salespotential.IndeterminateValue = "1";
            this.chk_salespotential.Name = "chk_salespotential";
            this.chk_salespotential.ReadOnly = true;
            this.chk_salespotential.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk_salespotential.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk_salespotential.TrueValue = "-1";
            this.chk_salespotential.Width = 40;
            // 
            // cn_spcomments
            // 
            this.cn_spcomments.DataPropertyName = "spcomments";
            this.cn_spcomments.FillWeight = 150F;
            this.cn_spcomments.HeaderText = "Potential comments";
            this.cn_spcomments.Name = "cn_spcomments";
            this.cn_spcomments.ReadOnly = true;
            this.cn_spcomments.Width = 150;
            // 
            // cn_crmstate
            // 
            this.cn_crmstate.DataPropertyName = "crmstate";
            this.cn_crmstate.HeaderText = "State";
            this.cn_crmstate.Name = "cn_crmstate";
            this.cn_crmstate.ReadOnly = true;
            // 
            // cn_crmstateid
            // 
            this.cn_crmstateid.HeaderText = "crmstateid";
            this.cn_crmstateid.Name = "cn_crmstateid";
            this.cn_crmstateid.ReadOnly = true;
            this.cn_crmstateid.Visible = false;
            // 
            // cn_budget
            // 
            this.cn_budget.DataPropertyName = "budget";
            this.cn_budget.HeaderText = "Budget for electronics";
            this.cn_budget.Name = "cn_budget";
            this.cn_budget.ReadOnly = true;
            // 
            // cn_crmmanager
            // 
            this.cn_crmmanager.DataPropertyName = "crmmanager";
            this.cn_crmmanager.HeaderText = "CRM manager";
            this.cn_crmmanager.Name = "cn_crmmanager";
            this.cn_crmmanager.ReadOnly = true;
            // 
            // cn_activities
            // 
            this.cn_activities.DataPropertyName = "activities";
            this.cn_activities.HeaderText = "Activities";
            this.cn_activities.Name = "cn_activities";
            this.cn_activities.ReadOnly = true;
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
            this.btn_Delete,
            this.btn_Active,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 252);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(796, 25);
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
            this.btn_Active.Image = global::Odin.Global_Resourses.stop16x16_1;
            this.btn_Active.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(23, 22);
            this.btn_Active.Text = "Make inactive";
            this.btn_Active.Click += new System.EventHandler(this.btn_Active_Click);
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
            this.kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "3603EBC349EA4AA52F8724469FC85DA3";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1081, 376);
            this.kryptonDockableWorkspace1.TabIndex = 4;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_schedule);
            this.kryptonPanel1.Controls.Add(this.btn_Contracts);
            this.kryptonPanel1.Controls.Add(this.btn_Events);
            this.kryptonPanel1.Controls.Add(this.btn_Activity);
            this.kryptonPanel1.Controls.Add(this.btn_History);
            this.kryptonPanel1.Controls.Add(this.btn_Documents);
            this.kryptonPanel1.Controls.Add(this.btn_General);
            this.kryptonPanel1.Controls.Add(this.btn_Contacts);
            this.kryptonPanel1.Controls.Add(this.btn_Addresses);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1081, 49);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // btn_schedule
            // 
            this.btn_schedule.Location = new System.Drawing.Point(914, 5);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(109, 39);
            this.btn_schedule.TabIndex = 10;
            this.btn_schedule.Values.Image = global::Odin.Global_Resourses.schedule_1405;
            this.btn_schedule.Values.Text = "Schedule";
            this.btn_schedule.Visible = false;
            // 
            // btn_Contracts
            // 
            this.btn_Contracts.Location = new System.Drawing.Point(639, 5);
            this.btn_Contracts.Name = "btn_Contracts";
            this.btn_Contracts.Size = new System.Drawing.Size(100, 39);
            this.btn_Contracts.TabIndex = 9;
            this.btn_Contracts.Values.Image = global::Odin.Global_Resourses.Doc;
            this.btn_Contracts.Values.Text = "Contracts";
            // 
            // btn_Events
            // 
            this.btn_Events.Location = new System.Drawing.Point(524, 5);
            this.btn_Events.Name = "btn_Events";
            this.btn_Events.Size = new System.Drawing.Size(109, 39);
            this.btn_Events.TabIndex = 8;
            this.btn_Events.Values.Image = global::Odin.Global_Resourses.events;
            this.btn_Events.Values.Text = "Events";
            this.btn_Events.Click += new System.EventHandler(this.btn_Events_Click);
            // 
            // btn_Activity
            // 
            this.btn_Activity.Location = new System.Drawing.Point(346, 5);
            this.btn_Activity.Name = "btn_Activity";
            this.btn_Activity.Size = new System.Drawing.Size(174, 39);
            this.btn_Activity.TabIndex = 7;
            this.btn_Activity.Values.Image = global::Odin.Global_Resourses.factory;
            this.btn_Activity.Values.Text = "Activities and products";
            this.btn_Activity.Click += new System.EventHandler(this.btn_Activity_Click);
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(857, 5);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(109, 39);
            this.btn_History.TabIndex = 5;
            this.btn_History.Values.Image = global::Odin.Global_Resourses.emblem_library_9156;
            this.btn_History.Values.Text = "History";
            this.btn_History.Visible = false;
            // 
            // btn_Documents
            // 
            this.btn_Documents.Location = new System.Drawing.Point(972, 5);
            this.btn_Documents.Name = "btn_Documents";
            this.btn_Documents.Size = new System.Drawing.Size(109, 39);
            this.btn_Documents.TabIndex = 6;
            this.btn_Documents.Values.Image = global::Odin.Global_Resourses.folder_documents;
            this.btn_Documents.Values.Text = "Documents";
            this.btn_Documents.Visible = false;
            // 
            // btn_General
            // 
            this.btn_General.Location = new System.Drawing.Point(4, 5);
            this.btn_General.Name = "btn_General";
            this.btn_General.Size = new System.Drawing.Size(100, 39);
            this.btn_General.TabIndex = 1;
            this.btn_General.Values.Image = global::Odin.Global_Resourses.company_small;
            this.btn_General.Values.Text = "General";
            this.btn_General.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Contacts
            // 
            this.btn_Contacts.Location = new System.Drawing.Point(233, 5);
            this.btn_Contacts.Name = "btn_Contacts";
            this.btn_Contacts.Size = new System.Drawing.Size(109, 39);
            this.btn_Contacts.TabIndex = 3;
            this.btn_Contacts.Values.Image = global::Odin.Global_Resourses.Children;
            this.btn_Contacts.Values.Text = "Contacts";
            this.btn_Contacts.Click += new System.EventHandler(this.btn_Contacts_Click);
            // 
            // btn_Addresses
            // 
            this.btn_Addresses.Location = new System.Drawing.Point(108, 5);
            this.btn_Addresses.Name = "btn_Addresses";
            this.btn_Addresses.Size = new System.Drawing.Size(121, 39);
            this.btn_Addresses.TabIndex = 2;
            this.btn_Addresses.Values.Image = global::Odin.Global_Resourses.SendMail;
            this.btn_Addresses.Values.Text = "Addresses";
            this.btn_Addresses.Click += new System.EventHandler(this.btn_Addresses_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(4, 235);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(94, 20);
            this.kryptonLabel5.TabIndex = 60;
            this.kryptonLabel5.Values.Text = "Resp. manager:";
            // 
            // cmb_RespManager
            // 
            this.cmb_RespManager.IsEmptyColor = false;
            this.cmb_RespManager.Location = new System.Drawing.Point(101, 235);
            this.cmb_RespManager.Name = "cmb_RespManager";
            this.cmb_RespManager.OrderBy = "id";
            this.cmb_RespManager.sCurrentValue = "";
            this.cmb_RespManager.SelectedValue = 0;
            this.cmb_RespManager.sID_Filled = "id";
            this.cmb_RespManager.Size = new System.Drawing.Size(176, 20);
            this.cmb_RespManager.sTable = "vw_CRMManagers";
            this.cmb_RespManager.sText_Filled = "crmmanager";
            this.cmb_RespManager.sTitle = "Responsible manager";
            this.cmb_RespManager.TabIndex = 59;
            // 
            // frm_CRMCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 707);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CRMCompanies";
            this.TabText = "CRM register";
            this.Text = "CRM register";
            this.Load += new System.EventHandler(this.frm_Companies_Load);
            this.Resize += new System.EventHandler(this.frm_Companies_Resize);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_History;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Documents;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_General;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Contacts;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Addresses;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_IsActive;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Countries.cmb_Countries cmb_Countries1;
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
        private System.Windows.Forms.BindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private System.Windows.Forms.ImageList imageListSmall;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Events;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Activity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Activities.cmb_Activities cmb_Activities1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Products;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Owf.Controls.NumericTetxBox txt_Turnover;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Contracts;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_company;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_phone;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_fax;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_parentid;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_parentcompany;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_countryid;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_country;
        private System.Windows.Forms.DataGridViewLinkColumn cn_webaddress;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn chk_custmark;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn chk_supmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isactive;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_when;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_who;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_turnover;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_salespotential;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_spcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_crmstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_crmstateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_crmmanager;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_activities;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_potential;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CMB_Components.Common.cmb_Common cmb_RespManager;
    }
}