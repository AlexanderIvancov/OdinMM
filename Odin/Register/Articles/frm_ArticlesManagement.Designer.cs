namespace Odin.Register.Articles
{
    partial class frm_ArticlesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ArticlesManagement));
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.chk_MSL = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_BOM = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.grp_BOMvalidation = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rb_Invalid = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Valid = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_All = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.chk_IsActive = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_IsCertified = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_SecArticle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmb_Department1 = new Odin.CMB_Components.Departments.cmb_Department();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_ExtArt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Description = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.cn_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_barg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_msl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_warning = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_iscertified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_imagepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_fulltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_aliases = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Analogs = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Rationing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Assemblies = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Suppliers = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Properties = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_History = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Documents = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_BOM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_General = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.btn_Certificates = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
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
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "5CC0CB756DE0468887A30440DACB45E4";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "DDAF0C146EE64A6B3BB719F1A947B4DE";
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
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1051, 682);
            this.kryptonSplitContainer1.SplitterDistance = 246;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_MSL);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_BOM);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.grp_BOMvalidation);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel9);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Common1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_IsActive);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_IsCertified);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_SecArticle);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Department1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Comments);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_ExtArt);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Types1);
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
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1051, 246);
            this.kryptonSplitContainer2.SplitterDistance = 284;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // chk_MSL
            // 
            this.chk_MSL.Checked = true;
            this.chk_MSL.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chk_MSL.Location = new System.Drawing.Point(180, 364);
            this.chk_MSL.Name = "chk_MSL";
            this.chk_MSL.Size = new System.Drawing.Size(67, 20);
            this.chk_MSL.TabIndex = 22;
            this.chk_MSL.ThreeState = true;
            this.chk_MSL.Values.Text = "No MSL";
            // 
            // chk_BOM
            // 
            this.chk_BOM.Checked = true;
            this.chk_BOM.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chk_BOM.Location = new System.Drawing.Point(90, 364);
            this.chk_BOM.Name = "chk_BOM";
            this.chk_BOM.Size = new System.Drawing.Size(84, 20);
            this.chk_BOM.TabIndex = 21;
            this.chk_BOM.ThreeState = true;
            this.chk_BOM.Values.Text = "BOM exists";
            // 
            // grp_BOMvalidation
            // 
            this.grp_BOMvalidation.Location = new System.Drawing.Point(9, 299);
            this.grp_BOMvalidation.Name = "grp_BOMvalidation";
            // 
            // grp_BOMvalidation.Panel
            // 
            this.grp_BOMvalidation.Panel.Controls.Add(this.rb_Invalid);
            this.grp_BOMvalidation.Panel.Controls.Add(this.rb_Valid);
            this.grp_BOMvalidation.Panel.Controls.Add(this.rb_All);
            this.grp_BOMvalidation.Size = new System.Drawing.Size(265, 59);
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
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(9, 273);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel9.TabIndex = 19;
            this.kryptonLabel9.Values.Text = "Usage stage:";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(90, 273);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(184, 20);
            this.cmb_Common1.sTable = "vw_ProductionStagesOnly";
            this.cmb_Common1.sText_Filled = "name";
            this.cmb_Common1.sTitle = "Stages of usage";
            this.cmb_Common1.TabIndex = 18;
            this.cmb_Common1.SelectedValueChanged += new Odin.CMB_Components.Common.CommonEventHandler(this.cmb_Common1_SelectedValueChanged);
            // 
            // chk_IsActive
            // 
            this.chk_IsActive.Checked = true;
            this.chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_IsActive.Location = new System.Drawing.Point(90, 247);
            this.chk_IsActive.Name = "chk_IsActive";
            this.chk_IsActive.Size = new System.Drawing.Size(67, 20);
            this.chk_IsActive.TabIndex = 17;
            this.chk_IsActive.ThreeState = true;
            this.chk_IsActive.Values.Text = "Is active";
            this.chk_IsActive.CheckedChanged += new System.EventHandler(this.chk_IsActive_CheckedChanged);
            // 
            // chk_IsCertified
            // 
            this.chk_IsCertified.Checked = true;
            this.chk_IsCertified.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chk_IsCertified.Location = new System.Drawing.Point(167, 247);
            this.chk_IsCertified.Name = "chk_IsCertified";
            this.chk_IsCertified.Size = new System.Drawing.Size(80, 20);
            this.chk_IsCertified.TabIndex = 17;
            this.chk_IsCertified.ThreeState = true;
            this.chk_IsCertified.Values.Text = "Is certified";
            this.chk_IsCertified.CheckedChanged += new System.EventHandler(this.chk_IsCertified_CheckedChanged);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(9, 118);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel8.TabIndex = 16;
            this.kryptonLabel8.Values.Text = "2nd name:";
            // 
            // txt_SecArticle
            // 
            this.txt_SecArticle.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_SecArticle.Location = new System.Drawing.Point(90, 118);
            this.txt_SecArticle.Name = "txt_SecArticle";
            this.txt_SecArticle.Size = new System.Drawing.Size(184, 23);
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
            // cmb_Department1
            // 
            this.cmb_Department1.Department = "";
            this.cmb_Department1.DeptId = 0;
            this.cmb_Department1.Location = new System.Drawing.Point(90, 390);
            this.cmb_Department1.Name = "cmb_Department1";
            this.cmb_Department1.SelectedNode = null;
            this.cmb_Department1.Size = new System.Drawing.Size(184, 20);
            this.cmb_Department1.TabIndex = 7;
            this.cmb_Department1.Visible = false;
            this.cmb_Department1.SelectedValueChanged += new Odin.CMB_Components.Departments.DepartmentEventHandler(this.cmb_Department1_SelectedValueChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(9, 390);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Department:";
            this.kryptonLabel4.Visible = false;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(9, 221);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel7.TabIndex = 14;
            this.kryptonLabel7.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_Comments.Location = new System.Drawing.Point(90, 221);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(184, 23);
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
            this.kryptonLabel6.Location = new System.Drawing.Point(9, 196);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel6.TabIndex = 12;
            this.kryptonLabel6.Values.Text = "Firm\'s article:";
            // 
            // txt_ExtArt
            // 
            this.txt_ExtArt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_ExtArt.Location = new System.Drawing.Point(90, 196);
            this.txt_ExtArt.Name = "txt_ExtArt";
            this.txt_ExtArt.Size = new System.Drawing.Size(184, 23);
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
            this.kryptonLabel5.Location = new System.Drawing.Point(9, 170);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Company:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(90, 170);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(184, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 9;
            this.cmb_Firms1.VATNr = null;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(9, 94);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(90, 94);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(184, 20);
            this.cmb_Types1.TabIndex = 5;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            this.cmb_Types1.SelectedValueChanged += new Odin.CMB_Components.Types.TypesEventHandler(this.cmb_Types1_SelectedValueChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(9, 144);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Description:";
            // 
            // txt_Description
            // 
            this.txt_Description.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Description.Location = new System.Drawing.Point(90, 144);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(184, 23);
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
            this.cmb_Articles1.IsCertified = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(9, 68);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(265, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 1;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleChanged += new Odin.CMB_Components.Articles.ArticlesEventHandler(this.cmb_Articles1_ArticleChanged);
            this.cmb_Articles1.ArticleKeyPressed += new Odin.CMB_Components.Articles.ArticlesKeyPressedEventHandler(this.cmb_Articles1_ArticleKeyPressed);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(284, 42);
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
            this.cn_department,
            this.cn_isactive,
            this.cn_barg,
            this.cn_stage,
            this.cn_msl,
            this.cn_custcode,
            this.cn_warning,
            this.cn_iscertified,
            this.cn_imagepath,
            this.cn_fulltype,
            this.cn_aliases});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(762, 221);
            this.gv_List.TabIndex = 2;
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
            this.gv_List.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_CellMouseDown);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.FillWeight = 40F;
            this.cn_id.HeaderText = "Art. id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Width = 40;
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
            // cn_department
            // 
            this.cn_department.DataPropertyName = "department";
            this.cn_department.HeaderText = "Department";
            this.cn_department.Name = "cn_department";
            this.cn_department.ReadOnly = true;
            // 
            // cn_isactive
            // 
            this.cn_isactive.DataPropertyName = "isactive";
            this.cn_isactive.HeaderText = "isactive";
            this.cn_isactive.Name = "cn_isactive";
            this.cn_isactive.ReadOnly = true;
            this.cn_isactive.Visible = false;
            // 
            // cn_barg
            // 
            this.cn_barg.DataPropertyName = "barg";
            this.cn_barg.HeaderText = "barg";
            this.cn_barg.Name = "cn_barg";
            this.cn_barg.ReadOnly = true;
            this.cn_barg.Visible = false;
            // 
            // cn_stage
            // 
            this.cn_stage.DataPropertyName = "stage";
            this.cn_stage.HeaderText = "Stage";
            this.cn_stage.Name = "cn_stage";
            this.cn_stage.ReadOnly = true;
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
            // cn_custcode
            // 
            this.cn_custcode.DataPropertyName = "custcode";
            this.cn_custcode.HeaderText = "Cust. code";
            this.cn_custcode.Name = "cn_custcode";
            this.cn_custcode.ReadOnly = true;
            // 
            // cn_warning
            // 
            this.cn_warning.DataPropertyName = "warning";
            this.cn_warning.FalseValue = "0";
            this.cn_warning.FillWeight = 40F;
            this.cn_warning.HeaderText = "Warn.";
            this.cn_warning.IndeterminateValue = "1";
            this.cn_warning.Name = "cn_warning";
            this.cn_warning.ReadOnly = true;
            this.cn_warning.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_warning.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cn_warning.TrueValue = "-1";
            this.cn_warning.Width = 40;
            // 
            // cn_iscertified
            // 
            this.cn_iscertified.DataPropertyName = "iscertified";
            this.cn_iscertified.FalseValue = "0";
            this.cn_iscertified.FillWeight = 40F;
            this.cn_iscertified.HeaderText = "Cert.";
            this.cn_iscertified.IndeterminateValue = "1";
            this.cn_iscertified.Name = "cn_iscertified";
            this.cn_iscertified.ReadOnly = true;
            this.cn_iscertified.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_iscertified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cn_iscertified.TrueValue = "-1";
            this.cn_iscertified.Width = 40;
            //this.cn_iscertified.State = this.cn_iscertified.
            // 
            // cn_imagepath
            // 
            this.cn_imagepath.DataPropertyName = "imagepath";
            this.cn_imagepath.FillWeight = 150F;
            this.cn_imagepath.HeaderText = "Image path";
            this.cn_imagepath.Name = "cn_imagepath";
            this.cn_imagepath.ReadOnly = true;
            this.cn_imagepath.Width = 150;
            // 
            // cn_fulltype
            // 
            this.cn_fulltype.DataPropertyName = "fulltype";
            this.cn_fulltype.HeaderText = "Full type path";
            this.cn_fulltype.Name = "cn_fulltype";
            this.cn_fulltype.ReadOnly = true;
            // 
            // cn_aliases
            // 
            this.cn_aliases.DataPropertyName = "aliases";
            this.cn_aliases.HeaderText = "Aliases";
            this.cn_aliases.Name = "cn_aliases";
            this.cn_aliases.ReadOnly = true;
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
            this.bn_List.Location = new System.Drawing.Point(0, 221);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(762, 25);
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
            this.kryptonDockableWorkspace1.Root.StarSize = "400*,400*";
            this.kryptonDockableWorkspace1.Root.UniqueName = "3603EBC349EA4AA52F8724469FC85DA3";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1051, 431);
            this.kryptonDockableWorkspace1.TabIndex = 4;
            this.kryptonDockableWorkspace1.TabStop = true;
            this.kryptonDockableWorkspace1.WorkspaceCellAdding += new System.EventHandler<ComponentFactory.Krypton.Workspace.WorkspaceCellEventArgs>(this.kryptonDockableWorkspace1_WorkspaceCellAdding);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Certificates);
            this.kryptonPanel1.Controls.Add(this.btn_Analogs);
            this.kryptonPanel1.Controls.Add(this.btn_Rationing);
            this.kryptonPanel1.Controls.Add(this.btn_Assemblies);
            this.kryptonPanel1.Controls.Add(this.btn_Suppliers);
            this.kryptonPanel1.Controls.Add(this.btn_Properties);
            this.kryptonPanel1.Controls.Add(this.btn_History);
            this.kryptonPanel1.Controls.Add(this.btn_Documents);
            this.kryptonPanel1.Controls.Add(this.btn_BOM);
            this.kryptonPanel1.Controls.Add(this.btn_General);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1051, 49);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // btn_Analogs
            // 
            this.btn_Analogs.Location = new System.Drawing.Point(480, 3);
            this.btn_Analogs.Name = "btn_Analogs";
            this.btn_Analogs.Size = new System.Drawing.Size(107, 40);
            this.btn_Analogs.TabIndex = 9;
            this.btn_Analogs.Values.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.btn_Analogs.Values.Text = "Analogs";
            this.btn_Analogs.Click += new System.EventHandler(this.btn_Analogs_Click);
            // 
            // btn_Rationing
            // 
            this.btn_Rationing.Location = new System.Drawing.Point(248, 3);
            this.btn_Rationing.Name = "btn_Rationing";
            this.btn_Rationing.Size = new System.Drawing.Size(118, 40);
            this.btn_Rationing.TabIndex = 8;
            this.btn_Rationing.Values.Image = global::Odin.Global_Resourses.stopwatch_start;
            this.btn_Rationing.Values.Text = "Rationing";
            this.btn_Rationing.Click += new System.EventHandler(this.btn_Rationing_Click);
            // 
            // btn_Assemblies
            // 
            this.btn_Assemblies.Location = new System.Drawing.Point(591, 3);
            this.btn_Assemblies.Name = "btn_Assemblies";
            this.btn_Assemblies.Size = new System.Drawing.Size(107, 40);
            this.btn_Assemblies.TabIndex = 7;
            this.btn_Assemblies.Values.Image = global::Odin.Global_Resourses.arrow_join;
            this.btn_Assemblies.Values.Text = "Assemblies";
            this.btn_Assemblies.Click += new System.EventHandler(this.btn_Assemblies_Click);
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.Location = new System.Drawing.Point(370, 3);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.Size = new System.Drawing.Size(107, 40);
            this.btn_Suppliers.TabIndex = 6;
            this.btn_Suppliers.Values.Image = global::Odin.Global_Resourses.kwrite;
            this.btn_Suppliers.Values.Text = "Catalog";
            this.btn_Suppliers.Click += new System.EventHandler(this.btn_Suppliers_Click);
            // 
            // btn_Properties
            // 
            this.btn_Properties.Location = new System.Drawing.Point(942, 3);
            this.btn_Properties.Name = "btn_Properties";
            this.btn_Properties.Size = new System.Drawing.Size(109, 40);
            this.btn_Properties.TabIndex = 5;
            this.btn_Properties.Values.Image = global::Odin.Global_Resourses.Properties_24x24;
            this.btn_Properties.Values.Text = "Properties";
            this.btn_Properties.Visible = false;
            this.btn_Properties.Click += new System.EventHandler(this.btn_Properties_Click);
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(702, 3);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(109, 39);
            this.btn_History.TabIndex = 4;
            this.btn_History.Values.Image = global::Odin.Global_Resourses.emblem_library_9156;
            this.btn_History.Values.Text = "History";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Documents
            // 
            this.btn_Documents.Location = new System.Drawing.Point(930, 3);
            this.btn_Documents.Name = "btn_Documents";
            this.btn_Documents.Size = new System.Drawing.Size(109, 40);
            this.btn_Documents.TabIndex = 3;
            this.btn_Documents.Values.Image = global::Odin.Global_Resourses.folder_documents;
            this.btn_Documents.Values.Text = "Documents";
            this.btn_Documents.Visible = false;
            this.btn_Documents.Click += new System.EventHandler(this.btn_Documents_Click);
            // 
            // btn_BOM
            // 
            this.btn_BOM.Location = new System.Drawing.Point(107, 3);
            this.btn_BOM.Name = "btn_BOM";
            this.btn_BOM.Size = new System.Drawing.Size(137, 40);
            this.btn_BOM.TabIndex = 2;
            this.btn_BOM.Values.Image = global::Odin.Global_Resourses.FormDesignThisForm;
            this.btn_BOM.Values.Text = "Bill of materials";
            this.btn_BOM.Click += new System.EventHandler(this.btn_BOM_Click);
            // 
            // btn_General
            // 
            this.btn_General.Location = new System.Drawing.Point(3, 3);
            this.btn_General.Name = "btn_General";
            this.btn_General.Size = new System.Drawing.Size(100, 40);
            this.btn_General.TabIndex = 1;
            this.btn_General.Values.Image = global::Odin.Global_Resourses.ButtonImageLarge;
            this.btn_General.Values.Text = "General";
            this.btn_General.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // btn_Certificates
            // 
            this.btn_Certificates.Location = new System.Drawing.Point(817, 3);
            this.btn_Certificates.Name = "btn_Certificates";
            this.btn_Certificates.Size = new System.Drawing.Size(107, 40);
            this.btn_Certificates.TabIndex = 10;
            this.btn_Certificates.Values.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.btn_Certificates.Values.Text = "Certificates";
            this.btn_Certificates.Click += new System.EventHandler(this.btn_Certificates_Click);
            //this.btn_Certificates.Visible = false;
            // 
            // frm_ArticlesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 731);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ArticlesManagement";
            this.TabText = "Articles";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.frm_ArticlesManagement_Load);
            this.Resize += new System.EventHandler(this.frm_ArticlesManagement_Resize);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Documents;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_BOM;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_General;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Description;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_ExtArt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CMB_Components.Departments.cmb_Department cmb_Department1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Types.cmb_Types cmb_Types1;
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
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton btn_Active;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_History;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_SecArticle;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private System.Windows.Forms.ImageList imageListSmall;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Properties;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_IsActive;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_IsCertified;
        private System.Windows.Forms.ToolStripButton btn_Copy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Suppliers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Assemblies;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grp_BOMvalidation;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Invalid;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valid;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_All;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_BOM;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Rationing;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_MSL;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Analogs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Certificates;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_barg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_msl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custcode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_warning;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_iscertified;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_imagepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_fulltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_aliases;
    }
}