namespace Odin.Register.Articles
{
    partial class frm_BOMManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BOMManagement));
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.chk_OrderExists = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.grp_BOMvalidation = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rb_Invalid = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Valid = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_All = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.chk_IsActive = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_SecArticle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_ExtArt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Description = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_History = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Setup = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Rationing = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_RatioList = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Conditional = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.ctl_BOMSimple1 = new Odin.Register.Articles.ctl_BOMSimple();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.bs_HistoryList = new Odin.Global_Classes.SyncBindingSource();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_storagerules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stornorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reffirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_msl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bomstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_validat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_validby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_SMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_QC_SMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_XRAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_THT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_QC_THT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_FTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_FQC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_IPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_FCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_spsmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sptht = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.grp_BOMvalidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_BOMvalidation.Panel)).BeginInit();
            this.grp_BOMvalidation.Panel.SuspendLayout();
            this.grp_BOMvalidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_HistoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.splitter1);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeaderGroup2);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1248, 566);
            this.kryptonSplitContainer1.SplitterDistance = 337;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_OrderExists);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Types1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.grp_BOMvalidation);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_IsActive);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_SecArticle);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Comments);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_ExtArt);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Description);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1248, 337);
            this.kryptonSplitContainer2.SplitterDistance = 304;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // chk_OrderExists
            // 
            this.chk_OrderExists.Checked = true;
            this.chk_OrderExists.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_OrderExists.Location = new System.Drawing.Point(163, 248);
            this.chk_OrderExists.Name = "chk_OrderExists";
            this.chk_OrderExists.Size = new System.Drawing.Size(88, 20);
            this.chk_OrderExists.TabIndex = 23;
            this.chk_OrderExists.ThreeState = true;
            this.chk_OrderExists.Values.Text = "Orders exist";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(9, 93);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel3.TabIndex = 22;
            this.kryptonLabel3.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(90, 93);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(200, 20);
            this.cmb_Types1.TabIndex = 21;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // grp_BOMvalidation
            // 
            this.grp_BOMvalidation.Location = new System.Drawing.Point(9, 270);
            this.grp_BOMvalidation.Name = "grp_BOMvalidation";
            // 
            // grp_BOMvalidation.Panel
            // 
            this.grp_BOMvalidation.Panel.Controls.Add(this.rb_Invalid);
            this.grp_BOMvalidation.Panel.Controls.Add(this.rb_Valid);
            this.grp_BOMvalidation.Panel.Controls.Add(this.rb_All);
            this.grp_BOMvalidation.Size = new System.Drawing.Size(281, 59);
            this.grp_BOMvalidation.TabIndex = 20;
            this.grp_BOMvalidation.Values.Heading = "BOM validation";
            // 
            // rb_Invalid
            // 
            this.rb_Invalid.Location = new System.Drawing.Point(156, 3);
            this.rb_Invalid.Name = "rb_Invalid";
            this.rb_Invalid.Size = new System.Drawing.Size(58, 20);
            this.rb_Invalid.TabIndex = 2;
            this.rb_Invalid.Values.Text = "Invalid";
            // 
            // rb_Valid
            // 
            this.rb_Valid.Location = new System.Drawing.Point(79, 3);
            this.rb_Valid.Name = "rb_Valid";
            this.rb_Valid.Size = new System.Drawing.Size(50, 20);
            this.rb_Valid.TabIndex = 1;
            this.rb_Valid.Values.Text = "Valid";
            // 
            // rb_All
            // 
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(7, 3);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(36, 20);
            this.rb_All.TabIndex = 0;
            this.rb_All.Values.Text = "All";
            // 
            // chk_IsActive
            // 
            this.chk_IsActive.Checked = true;
            this.chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_IsActive.Location = new System.Drawing.Point(90, 248);
            this.chk_IsActive.Name = "chk_IsActive";
            this.chk_IsActive.Size = new System.Drawing.Size(67, 20);
            this.chk_IsActive.TabIndex = 17;
            this.chk_IsActive.ThreeState = true;
            this.chk_IsActive.Values.Text = "Is active";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(9, 119);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel8.TabIndex = 16;
            this.kryptonLabel8.Values.Text = "2nd name:";
            // 
            // txt_SecArticle
            // 
            this.txt_SecArticle.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_SecArticle.Location = new System.Drawing.Point(90, 119);
            this.txt_SecArticle.Name = "txt_SecArticle";
            this.txt_SecArticle.Size = new System.Drawing.Size(200, 23);
            this.txt_SecArticle.TabIndex = 15;
            this.txt_SecArticle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SecArticle_KeyDown);
            this.txt_SecArticle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SecArticle_KeyPress);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny4.UniqueName = "46482B28C1D342E20F86470E7089BEE4";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(9, 222);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel7.TabIndex = 14;
            this.kryptonLabel7.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_Comments.Location = new System.Drawing.Point(90, 222);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(200, 23);
            this.txt_Comments.TabIndex = 13;
            this.txt_Comments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Comments_KeyDown);
            this.txt_Comments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Comments_KeyPress);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "46482B28C1D342E20F86470E7089BEE4";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(9, 197);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel6.TabIndex = 12;
            this.kryptonLabel6.Values.Text = "Firm\'s article:";
            // 
            // txt_ExtArt
            // 
            this.txt_ExtArt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_ExtArt.Location = new System.Drawing.Point(90, 197);
            this.txt_ExtArt.Name = "txt_ExtArt";
            this.txt_ExtArt.Size = new System.Drawing.Size(200, 23);
            this.txt_ExtArt.TabIndex = 11;
            this.txt_ExtArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ExtArt_KeyDown);
            this.txt_ExtArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ExtArt_KeyPress);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "46482B28C1D342E20F86470E7089BEE4";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(9, 171);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Customer:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(90, 171);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(200, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 9;
            this.cmb_Firms1.VATNr = null;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(9, 145);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Description:";
            // 
            // txt_Description
            // 
            this.txt_Description.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Description.Location = new System.Drawing.Point(90, 145);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(200, 23);
            this.txt_Description.TabIndex = 3;
            this.txt_Description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Description_KeyDown);
            this.txt_Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Description_KeyPress);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "46482B28C1D342E20F86470E7089BEE4";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(9, 48);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Article:";
            // 
            // cmb_Articles1
            // 
            this.cmb_Articles1.Article = "";
            this.cmb_Articles1.ArticleId = 0;
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
            this.cmb_Articles1.Location = new System.Drawing.Point(9, 68);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(281, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 1;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleKeyPressed += new Odin.CMB_Components.Articles.ArticlesKeyPressedEventHandler(this.cmb_Articles1_ArticleKeyPressed);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear,
            this.btn_History,
            this.btn_Setup,
            this.btn_Rationing,
            this.btn_RatioList});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(304, 42);
            this.kryptonHeader1.TabIndex = 0;
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
            // btn_History
            // 
            this.btn_History.Image = global::Odin.Global_Resourses.history24x24;
            this.btn_History.UniqueName = "AB43F932A89A4B253CAF8CF6A06FBFF1";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Setup
            // 
            this.btn_Setup.Image = global::Odin.Global_Resourses.setting_tools;
            this.btn_Setup.UniqueName = "FF1C913391914D498CB82BD60A85CED3";
            this.btn_Setup.Click += new System.EventHandler(this.btn_Setup_Click);
            // 
            // btn_Rationing
            // 
            this.btn_Rationing.Image = global::Odin.Global_Resourses.stopwatch_start;
            this.btn_Rationing.UniqueName = "3C759C86CA254403F881BB22C486ED49";
            this.btn_Rationing.Click += new System.EventHandler(this.btn_Rationing_Click);
            // 
            // btn_RatioList
            // 
            this.btn_RatioList.Image = global::Odin.Global_Resourses.table_go;
            this.btn_RatioList.UniqueName = "F153799663E74615DC8540C82B0E8716";
            this.btn_RatioList.Click += new System.EventHandler(this.btn_RatioList_Click);
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_article,
            this.cn_secname,
            this.cn_description,
            this.cn_unit,
            this.cn_comments,
            this.cn_type,
            this.cn_weight,
            this.cn_storagerules,
            this.cn_stornorm,
            this.cn_reffirm,
            this.cn_isactive,
            this.cn_msl,
            this.cn_bomstate,
            this.cn_validat,
            this.cn_validby,
            this.cn_customer,
            this.cn_stencil,
            this.cn_SMT,
            this.cn_QC_SMT,
            this.cn_XRAY,
            this.cn_THT,
            this.cn_QC_THT,
            this.cn_FTA,
            this.cn_FQC,
            this.cn_IPA,
            this.cn_GPA,
            this.cn_FCS,
            this.cn_spsmt,
            this.cn_sptht});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(939, 312);
            this.gv_List.TabIndex = 2;
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // mnu_Lines
            // 
            this.mnu_Lines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Lines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterFor,
            this.mni_Search,
            this.mni_Conditional,
            this.mni_FilterBy,
            this.mni_FilterExcludingSel,
            this.mni_RemoveFilter,
            this.mni_Copy,
            this.toolStripSeparator2,
            this.mni_Admin});
            this.mnu_Lines.Name = "mnu_Requests";
            this.mnu_Lines.Size = new System.Drawing.Size(211, 189);
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
            // mni_Conditional
            // 
            this.mni_Conditional.Image = global::Odin.Global_Resourses.layout_header;
            this.mni_Conditional.ImageTransparentColor = System.Drawing.Color.White;
            this.mni_Conditional.Name = "mni_Conditional";
            this.mni_Conditional.Size = new System.Drawing.Size(210, 22);
            this.mni_Conditional.Text = "Conditional filter";
            this.mni_Conditional.Click += new System.EventHandler(this.mni_Conditional_Click);
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
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 312);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(939, 25);
            this.bn_List.TabIndex = 0;
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
            this.btn_Active.Image = global::Odin.Global_Resourses.stop16x16_1;
            this.btn_Active.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(23, 22);
            this.btn_Active.Text = "Make inactive";
            this.btn_Active.Visible = false;
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
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(1045, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.StarSize = "400*,400*";
            this.kryptonDockableWorkspace1.Root.UniqueName = "3603EBC349EA4AA52F8724469FC85DA3";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(203, 224);
            this.kryptonDockableWorkspace1.TabIndex = 5;
            this.kryptonDockableWorkspace1.TabStop = true;
            this.kryptonDockableWorkspace1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonDockableWorkspace1_Paint);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(1042, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 224);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.ctl_BOMSimple1);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(1042, 224);
            this.kryptonHeaderGroup2.TabIndex = 3;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Bill of materials";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.swf;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Management";
            // 
            // ctl_BOMSimple1
            // 
            this.ctl_BOMSimple1.ArtId = 0;
            this.ctl_BOMSimple1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_BOMSimple1.fileName = null;
            this.ctl_BOMSimple1.igvArtId = 0;
            this.ctl_BOMSimple1.Location = new System.Drawing.Point(0, 0);
            this.ctl_BOMSimple1.Lock = 0;
            this.ctl_BOMSimple1.Name = "ctl_BOMSimple1";
            this.ctl_BOMSimple1.OldigvArtId = 0;
            this.ctl_BOMSimple1.Size = new System.Drawing.Size(1040, 171);
            this.ctl_BOMSimple1.TabIndex = 0;
            this.ctl_BOMSimple1.ValidAt = "";
            this.ctl_BOMSimple1.ValidBy = "";
            this.ctl_BOMSimple1.ValidId = 0;
            this.ctl_BOMSimple1.ValidState = "";
            this.ctl_BOMSimple1.SendRMArtId += new Odin.Register.Articles.SendRMArtIdEventHandler(this.ctl_BOMSimple1_SendRMArtId);
            this.ctl_BOMSimple1.SendBOMArtId += new Odin.Register.Articles.SendBOMArtIdEventHandler(this.ctl_BOMSimple1_SendBOMArtId);
            // 
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            this.kryptonDockingManager1.DockableWorkspaceAdded += new System.EventHandler<ComponentFactory.Krypton.Docking.DockableWorkspaceEventArgs>(this.kryptonDockingManager1_DockableWorkspaceAdded);
            this.kryptonDockingManager1.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager1_DockspaceAdding);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonPalette1.GridStyles.GridCustom1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.Ribbon.RibbonGroupArea.StateCommon.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "Art. id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
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
            // cn_description
            // 
            this.cn_description.DataPropertyName = "description";
            this.cn_description.FillWeight = 200F;
            this.cn_description.HeaderText = "Description";
            this.cn_description.Name = "cn_description";
            this.cn_description.ReadOnly = true;
            this.cn_description.Width = 200;
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
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.ReadOnly = true;
            this.cn_comments.Width = 150;
            // 
            // cn_type
            // 
            this.cn_type.DataPropertyName = "type";
            this.cn_type.HeaderText = "Type";
            this.cn_type.Name = "cn_type";
            this.cn_type.ReadOnly = true;
            // 
            // cn_weight
            // 
            this.cn_weight.DataPropertyName = "weight";
            this.cn_weight.FillWeight = 50F;
            this.cn_weight.HeaderText = "Weight";
            this.cn_weight.Name = "cn_weight";
            this.cn_weight.ReadOnly = true;
            this.cn_weight.Width = 50;
            // 
            // cn_storagerules
            // 
            this.cn_storagerules.DataPropertyName = "storagerules";
            this.cn_storagerules.HeaderText = "Storage rules";
            this.cn_storagerules.Name = "cn_storagerules";
            this.cn_storagerules.ReadOnly = true;
            // 
            // cn_stornorm
            // 
            this.cn_stornorm.DataPropertyName = "stornorm";
            this.cn_stornorm.FillWeight = 50F;
            this.cn_stornorm.HeaderText = "Stock ratio";
            this.cn_stornorm.Name = "cn_stornorm";
            this.cn_stornorm.ReadOnly = true;
            this.cn_stornorm.Width = 50;
            // 
            // cn_reffirm
            // 
            this.cn_reffirm.DataPropertyName = "reffirm";
            this.cn_reffirm.HeaderText = "Firm\'s reference";
            this.cn_reffirm.Name = "cn_reffirm";
            this.cn_reffirm.ReadOnly = true;
            // 
            // cn_isactive
            // 
            this.cn_isactive.DataPropertyName = "isactive";
            this.cn_isactive.HeaderText = "isactive";
            this.cn_isactive.Name = "cn_isactive";
            this.cn_isactive.ReadOnly = true;
            this.cn_isactive.Visible = false;
            // 
            // cn_msl
            // 
            this.cn_msl.DataPropertyName = "msl";
            this.cn_msl.FillWeight = 35F;
            this.cn_msl.HeaderText = "MSL";
            this.cn_msl.Name = "cn_msl";
            this.cn_msl.ReadOnly = true;
            this.cn_msl.Width = 35;
            // 
            // cn_bomstate
            // 
            this.cn_bomstate.DataPropertyName = "bomstate";
            this.cn_bomstate.HeaderText = "bomstate";
            this.cn_bomstate.Name = "cn_bomstate";
            this.cn_bomstate.ReadOnly = true;
            this.cn_bomstate.Visible = false;
            // 
            // cn_validat
            // 
            this.cn_validat.DataPropertyName = "validat";
            this.cn_validat.HeaderText = "Valid. at";
            this.cn_validat.Name = "cn_validat";
            this.cn_validat.ReadOnly = true;
            // 
            // cn_validby
            // 
            this.cn_validby.DataPropertyName = "validby";
            this.cn_validby.HeaderText = "Valid. by";
            this.cn_validby.Name = "cn_validby";
            this.cn_validby.ReadOnly = true;
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            this.cn_customer.ReadOnly = true;
            // 
            // cn_stencil
            // 
            this.cn_stencil.DataPropertyName = "stencil";
            this.cn_stencil.HeaderText = "Stencil";
            this.cn_stencil.Name = "cn_stencil";
            this.cn_stencil.ReadOnly = true;
            // 
            // cn_SMT
            // 
            this.cn_SMT.DataPropertyName = "SMT";
            this.cn_SMT.HeaderText = "SMT";
            this.cn_SMT.Name = "cn_SMT";
            this.cn_SMT.ReadOnly = true;
            // 
            // cn_QC_SMT
            // 
            this.cn_QC_SMT.DataPropertyName = "QC_SMT";
            this.cn_QC_SMT.HeaderText = "QC_SMT";
            this.cn_QC_SMT.Name = "cn_QC_SMT";
            this.cn_QC_SMT.ReadOnly = true;
            // 
            // cn_XRAY
            // 
            this.cn_XRAY.DataPropertyName = "XRAY";
            this.cn_XRAY.HeaderText = "XRAY";
            this.cn_XRAY.Name = "cn_XRAY";
            this.cn_XRAY.ReadOnly = true;
            // 
            // cn_THT
            // 
            this.cn_THT.DataPropertyName = "THT";
            this.cn_THT.HeaderText = "THT";
            this.cn_THT.Name = "cn_THT";
            this.cn_THT.ReadOnly = true;
            // 
            // cn_QC_THT
            // 
            this.cn_QC_THT.DataPropertyName = "QC_THT";
            this.cn_QC_THT.HeaderText = "QC_THT";
            this.cn_QC_THT.Name = "cn_QC_THT";
            this.cn_QC_THT.ReadOnly = true;
            // 
            // cn_FTA
            // 
            this.cn_FTA.DataPropertyName = "FTA";
            this.cn_FTA.HeaderText = "FTA";
            this.cn_FTA.Name = "cn_FTA";
            this.cn_FTA.ReadOnly = true;
            // 
            // cn_FQC
            // 
            this.cn_FQC.DataPropertyName = "FQC";
            this.cn_FQC.HeaderText = "FQC";
            this.cn_FQC.Name = "cn_FQC";
            this.cn_FQC.ReadOnly = true;
            // 
            // cn_IPA
            // 
            this.cn_IPA.DataPropertyName = "IPA";
            this.cn_IPA.HeaderText = "IPA";
            this.cn_IPA.Name = "cn_IPA";
            this.cn_IPA.ReadOnly = true;
            // 
            // cn_GPA
            // 
            this.cn_GPA.DataPropertyName = "GPA";
            this.cn_GPA.HeaderText = "GPA";
            this.cn_GPA.Name = "cn_GPA";
            this.cn_GPA.ReadOnly = true;
            // 
            // cn_FCS
            // 
            this.cn_FCS.DataPropertyName = "FCS";
            this.cn_FCS.HeaderText = "FCS";
            this.cn_FCS.Name = "cn_FCS";
            this.cn_FCS.ReadOnly = true;
            // 
            // cn_spsmt
            // 
            this.cn_spsmt.DataPropertyName = "spsmt";
            this.cn_spsmt.HeaderText = "S.p. SMT";
            this.cn_spsmt.Name = "cn_spsmt";
            this.cn_spsmt.ReadOnly = true;
            // 
            // cn_sptht
            // 
            this.cn_sptht.DataPropertyName = "sptht";
            this.cn_sptht.HeaderText = "S.p. THT";
            this.cn_sptht.Name = "cn_sptht";
            this.cn_sptht.ReadOnly = true;
            // 
            // frm_BOMManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 566);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BOMManagement";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.TabText = "BOM management";
            this.Text = "BOM management";
            this.Load += new System.EventHandler(this.frm_BOMManagement_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_BOMManagement_Paint);
            this.Resize += new System.EventHandler(this.frm_BOMManagement_Resize);
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
            ((System.ComponentModel.ISupportInitialize)(this.grp_BOMvalidation.Panel)).EndInit();
            this.grp_BOMvalidation.Panel.ResumeLayout(false);
            this.grp_BOMvalidation.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_BOMvalidation)).EndInit();
            this.grp_BOMvalidation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_HistoryList)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grp_BOMvalidation;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Invalid;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valid;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_All;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_IsActive;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_SecArticle;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_ExtArt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Description;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
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
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ctl_BOMSimple ctl_BOMSimple1;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private System.Windows.Forms.ToolStripMenuItem mni_Conditional;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_History;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.ImageList imageListSmall;
        private BSE.Windows.Forms.Splitter splitter1;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private Global_Classes.SyncBindingSource bs_List;
        private Global_Classes.SyncBindingSource bs_HistoryList;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Setup;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Rationing;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_RatioList;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_OrderExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_storagerules;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stornorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reffirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_msl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bomstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_validat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_validby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_SMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_QC_SMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_XRAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_THT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_QC_THT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_FTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_FQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_IPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_FCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_spsmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sptht;
    }
}