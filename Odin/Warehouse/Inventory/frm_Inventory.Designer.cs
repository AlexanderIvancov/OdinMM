namespace Odin.Warehouse.Inventory
{
    partial class frm_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Inventory));
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
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
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.cmb_InvNumber = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chk_Totals = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.chk_RMForType = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.chk_GroupByPlaces = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Label = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Department1 = new Odin.CMB_Components.Departments.cmb_Department();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Places1 = new Odin.CMB_Components.Places.cmb_Places();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_OnDate = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
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
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.btn_PrintLabel = new System.Windows.Forms.ToolStripButton();
            this.btn_TrayTube = new System.Windows.Forms.ToolStripButton();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_ClientRM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Packing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Tracing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Rests = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_General = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cn_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_placeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyrest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stockratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_invnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_manufbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_suparticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
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
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
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
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(974, 571);
            this.kryptonSplitContainer1.SplitterDistance = 385;
            this.kryptonSplitContainer1.TabIndex = 9;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_InvNumber);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Date);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Totals);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Batches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_RMForType);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_GroupByPlaces);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Label);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Department1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Places1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel16);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Types1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(974, 385);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // cmb_InvNumber
            // 
            this.cmb_InvNumber.IsEmptyColor = false;
            this.cmb_InvNumber.Location = new System.Drawing.Point(89, 302);
            this.cmb_InvNumber.Name = "cmb_InvNumber";
            this.cmb_InvNumber.OrderBy = "invnumber";
            this.cmb_InvNumber.sCurrentValue = "";
            this.cmb_InvNumber.SelectedValue = 0;
            this.cmb_InvNumber.sID_Filled = "id";
            this.cmb_InvNumber.Size = new System.Drawing.Size(150, 20);
            this.cmb_InvNumber.sTable = "vw_InvNumbers";
            this.cmb_InvNumber.sText_Filled = "invnumber";
            this.cmb_InvNumber.sTitle = "Inv. numbers";
            this.cmb_InvNumber.TabIndex = 255;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(6, 302);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel7.TabIndex = 254;
            this.kryptonLabel7.Values.Text = "Inv. number:";
            // 
            // txt_Date
            // 
            this.txt_Date.CalendarShowWeekNumbers = true;
            this.txt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Date.Location = new System.Drawing.Point(89, 356);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(92, 21);
            this.txt_Date.TabIndex = 250;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(5, 357);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel8.TabIndex = 243;
            this.kryptonLabel8.Values.Text = "Rest on date:";
            // 
            // chk_Totals
            // 
            this.chk_Totals.Location = new System.Drawing.Point(159, 279);
            this.chk_Totals.Name = "chk_Totals";
            this.chk_Totals.Size = new System.Drawing.Size(104, 20);
            this.chk_Totals.TabIndex = 242;
            this.chk_Totals.Values.Text = "Totals by stock";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(6, 331);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel4.TabIndex = 241;
            this.kryptonLabel4.Values.Text = "Reservation:";
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
            this.cmb_Batches1.Location = new System.Drawing.Point(89, 331);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 240;
            // 
            // chk_RMForType
            // 
            this.chk_RMForType.Location = new System.Drawing.Point(89, 227);
            this.chk_RMForType.Name = "chk_RMForType";
            this.chk_RMForType.Size = new System.Drawing.Size(140, 20);
            this.chk_RMForType.TabIndex = 239;
            this.chk_RMForType.Values.Text = "Raw material for type ";
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(6, 78);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 238;
            // 
            // chk_GroupByPlaces
            // 
            this.chk_GroupByPlaces.Location = new System.Drawing.Point(22, 279);
            this.chk_GroupByPlaces.Name = "chk_GroupByPlaces";
            this.chk_GroupByPlaces.Size = new System.Drawing.Size(112, 20);
            this.chk_GroupByPlaces.TabIndex = 42;
            this.chk_GroupByPlaces.Values.Text = "Group by places";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(6, 50);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel5.TabIndex = 41;
            this.kryptonLabel5.Values.Text = "Label:";
            // 
            // txt_Label
            // 
            this.txt_Label.AllowDecimalSeparator = false;
            this.txt_Label.AllowSpace = false;
            this.txt_Label.Location = new System.Drawing.Point(89, 50);
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.Size = new System.Drawing.Size(100, 23);
            this.txt_Label.TabIndex = 4;
            this.txt_Label.Text = "0";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(6, 253);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel2.TabIndex = 39;
            this.kryptonLabel2.Values.Text = "Department:";
            // 
            // cmb_Department1
            // 
            this.cmb_Department1.Department = "";
            this.cmb_Department1.DeptId = 0;
            this.cmb_Department1.Location = new System.Drawing.Point(89, 253);
            this.cmb_Department1.Name = "cmb_Department1";
            this.cmb_Department1.SelectedNode = null;
            this.cmb_Department1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Department1.TabIndex = 9;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(6, 129);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel1.TabIndex = 37;
            this.kryptonLabel1.Values.Text = "Place:";
            // 
            // cmb_Places1
            // 
            this.cmb_Places1.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Places1.Department = "";
            this.cmb_Places1.IsQuarantine = 0;
            this.cmb_Places1.Location = new System.Drawing.Point(10, 149);
            this.cmb_Places1.Lock = 0;
            this.cmb_Places1.Name = "cmb_Places1";
            this.cmb_Places1.PlaceId = 0;
            this.cmb_Places1.SelectedNode = null;
            this.cmb_Places1.Size = new System.Drawing.Size(283, 20);
            this.cmb_Places1.TabIndex = 6;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(6, 84);
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
            this.cmb_Articles1.Location = new System.Drawing.Point(10, 104);
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
            this.cmb_Articles1.TabIndex = 5;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(5, 201);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel6.TabIndex = 14;
            this.kryptonLabel6.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(89, 201);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Types1.TabIndex = 8;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 175);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Supplier:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(89, 175);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 7;
            this.cmb_Firms1.VATNr = null;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_OnDate,
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
            this.btn_Refresh.ToolTipBody = "Refresh";
            this.btn_Refresh.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_OnDate
            // 
            this.btn_OnDate.Image = global::Odin.Global_Resourses.Calendar_24x24;
            this.btn_OnDate.UniqueName = "AE62B69B75C348951C8EE9F853D32A65";
            this.btn_OnDate.Click += new System.EventHandler(this.btn_OnDate_Click);
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
            this.cn_label,
            this.cn_artid,
            this.cn_article,
            this.cn_secname,
            this.cn_description,
            this.cn_placeid,
            this.cn_place,
            this.cn_qtyrest,
            this.cn_unit,
            this.cn_comments,
            this.cn_type,
            this.cn_dept,
            this.cn_batch,
            this.cn_stockratio,
            this.cn_isactive,
            this.cn_dbatch,
            this.cn_customer,
            this.cn_invnumber,
            this.cn_sn,
            this.cn_manufbatch,
            this.cn_suparticle,
            this.cn_expdate});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(670, 360);
            this.gv_List.TabIndex = 3;
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
            this.btn_PrintLabel,
            this.btn_TrayTube});
            this.bn_List.Location = new System.Drawing.Point(0, 360);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(670, 25);
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
            // btn_PrintLabel
            // 
            this.btn_PrintLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_PrintLabel.Image = global::Odin.Global_Resourses.barcode_2d;
            this.btn_PrintLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PrintLabel.Name = "btn_PrintLabel";
            this.btn_PrintLabel.Size = new System.Drawing.Size(23, 22);
            this.btn_PrintLabel.Text = "Print label";
            this.btn_PrintLabel.Click += new System.EventHandler(this.btn_PrintLabel_Click);
            // 
            // btn_TrayTube
            // 
            this.btn_TrayTube.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_TrayTube.Image = global::Odin.Global_Resourses.Print1;
            this.btn_TrayTube.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_TrayTube.Name = "btn_TrayTube";
            this.btn_TrayTube.Size = new System.Drawing.Size(23, 22);
            this.btn_TrayTube.Text = "Print tray & tube label";
            this.btn_TrayTube.Click += new System.EventHandler(this.btn_TrayTube_Click);
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
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(974, 181);
            this.kryptonDockableWorkspace1.TabIndex = 6;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_ClientRM);
            this.kryptonPanel1.Controls.Add(this.btn_Packing);
            this.kryptonPanel1.Controls.Add(this.btn_Tracing);
            this.kryptonPanel1.Controls.Add(this.btn_Rests);
            this.kryptonPanel1.Controls.Add(this.btn_General);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(974, 49);
            this.kryptonPanel1.TabIndex = 6;
            // 
            // btn_ClientRM
            // 
            this.btn_ClientRM.Location = new System.Drawing.Point(420, 5);
            this.btn_ClientRM.Name = "btn_ClientRM";
            this.btn_ClientRM.Size = new System.Drawing.Size(149, 39);
            this.btn_ClientRM.TabIndex = 14;
            this.btn_ClientRM.Values.Image = global::Odin.Global_Resourses.chart_column;
            this.btn_ClientRM.Values.Text = "Client RM analysis";
            this.btn_ClientRM.Click += new System.EventHandler(this.btn_ClientRM_Click);
            // 
            // btn_Packing
            // 
            this.btn_Packing.Location = new System.Drawing.Point(314, 5);
            this.btn_Packing.Name = "btn_Packing";
            this.btn_Packing.Size = new System.Drawing.Size(100, 39);
            this.btn_Packing.TabIndex = 12;
            this.btn_Packing.Values.Image = global::Odin.Global_Resourses.package;
            this.btn_Packing.Values.Text = "Packed FC";
            this.btn_Packing.Click += new System.EventHandler(this.btn_Packing_Click);
            // 
            // btn_Tracing
            // 
            this.btn_Tracing.Location = new System.Drawing.Point(210, 5);
            this.btn_Tracing.Name = "btn_Tracing";
            this.btn_Tracing.Size = new System.Drawing.Size(100, 39);
            this.btn_Tracing.TabIndex = 3;
            this.btn_Tracing.Values.Image = global::Odin.Global_Resourses.Synchronize_24x24;
            this.btn_Tracing.Values.Text = "Tracing";
            this.btn_Tracing.Click += new System.EventHandler(this.btn_Tracing_Click);
            // 
            // btn_Rests
            // 
            this.btn_Rests.Location = new System.Drawing.Point(107, 5);
            this.btn_Rests.Name = "btn_Rests";
            this.btn_Rests.Size = new System.Drawing.Size(100, 39);
            this.btn_Rests.TabIndex = 2;
            this.btn_Rests.Values.Image = global::Odin.Global_Resourses.barcode_2d;
            this.btn_Rests.Values.Text = "Labels";
            this.btn_Rests.Click += new System.EventHandler(this.btn_Rests_Click);
            // 
            // btn_General
            // 
            this.btn_General.Location = new System.Drawing.Point(4, 5);
            this.btn_General.Name = "btn_General";
            this.btn_General.Size = new System.Drawing.Size(100, 39);
            this.btn_General.TabIndex = 1;
            this.btn_General.Values.Image = global::Odin.Global_Resourses.Docs;
            this.btn_General.Values.Text = "Details";
            this.btn_General.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // cn_label
            // 
            this.cn_label.DataPropertyName = "label";
            this.cn_label.FillWeight = 80F;
            this.cn_label.HeaderText = "Label";
            this.cn_label.Name = "cn_label";
            this.cn_label.ReadOnly = true;
            this.cn_label.Width = 80;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 80F;
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
            this.cn_artid.Width = 80;
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
            this.cn_secname.FillWeight = 150F;
            this.cn_secname.HeaderText = "2nd name";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.ReadOnly = true;
            this.cn_secname.Width = 150;
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
            // cn_placeid
            // 
            this.cn_placeid.DataPropertyName = "placeid";
            this.cn_placeid.FillWeight = 40F;
            this.cn_placeid.HeaderText = "placeid";
            this.cn_placeid.Name = "cn_placeid";
            this.cn_placeid.ReadOnly = true;
            this.cn_placeid.Visible = false;
            this.cn_placeid.Width = 40;
            // 
            // cn_place
            // 
            this.cn_place.DataPropertyName = "place";
            this.cn_place.FillWeight = 250F;
            this.cn_place.HeaderText = "Place";
            this.cn_place.Name = "cn_place";
            this.cn_place.ReadOnly = true;
            this.cn_place.Width = 250;
            // 
            // cn_qtyrest
            // 
            this.cn_qtyrest.DataPropertyName = "qtyrest";
            this.cn_qtyrest.FillWeight = 80F;
            this.cn_qtyrest.HeaderText = "Qty";
            this.cn_qtyrest.Name = "cn_qtyrest";
            this.cn_qtyrest.Width = 80;
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
            this.cn_type.DataPropertyName = "fulltype";
            this.cn_type.FillWeight = 150F;
            this.cn_type.HeaderText = "Type";
            this.cn_type.Name = "cn_type";
            this.cn_type.ReadOnly = true;
            this.cn_type.Width = 150;
            // 
            // cn_dept
            // 
            this.cn_dept.DataPropertyName = "department";
            this.cn_dept.HeaderText = "Department";
            this.cn_dept.Name = "cn_dept";
            this.cn_dept.ReadOnly = true;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.HeaderText = "Reservation";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.ReadOnly = true;
            // 
            // cn_stockratio
            // 
            this.cn_stockratio.DataPropertyName = "stockratio";
            this.cn_stockratio.HeaderText = "Stock ratio";
            this.cn_stockratio.Name = "cn_stockratio";
            this.cn_stockratio.ReadOnly = true;
            // 
            // cn_isactive
            // 
            this.cn_isactive.DataPropertyName = "isactive";
            this.cn_isactive.HeaderText = "isactive";
            this.cn_isactive.Name = "cn_isactive";
            this.cn_isactive.Visible = false;
            // 
            // cn_dbatch
            // 
            this.cn_dbatch.DataPropertyName = "prodbatch";
            this.cn_dbatch.HeaderText = "Batch";
            this.cn_dbatch.Name = "cn_dbatch";
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            // 
            // cn_invnumber
            // 
            this.cn_invnumber.DataPropertyName = "invnumber";
            this.cn_invnumber.HeaderText = "Inv. number";
            this.cn_invnumber.Name = "cn_invnumber";
            // 
            // cn_sn
            // 
            this.cn_sn.DataPropertyName = "sn";
            this.cn_sn.HeaderText = "S/N";
            this.cn_sn.Name = "cn_sn";
            // 
            // cn_manufbatch
            // 
            this.cn_manufbatch.DataPropertyName = "manufbatch";
            this.cn_manufbatch.HeaderText = "Manuf. batch";
            this.cn_manufbatch.Name = "cn_manufbatch";
            // 
            // cn_suparticle
            // 
            this.cn_suparticle.DataPropertyName = "suparticle";
            this.cn_suparticle.HeaderText = "Sup. article";
            this.cn_suparticle.Name = "cn_suparticle";
            // 
            // cn_expdate
            // 
            this.cn_expdate.DataPropertyName = "expdate";
            this.cn_expdate.HeaderText = "Exp. date";
            this.cn_expdate.Name = "cn_expdate";
            // 
            // frm_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 620);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Inventory";
            this.TabText = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frm_Inventory_Load);
            this.Resize += new System.EventHandler(this.frm_Inventory_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Tracing;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Rests;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_General;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
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
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private System.Windows.Forms.BindingSource bs_List;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private System.Windows.Forms.ImageList imageListSmall;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Departments.cmb_Department cmb_Department1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Places.cmb_Places cmb_Places1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Owf.Controls.NumericTetxBox txt_Label;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_GroupByPlaces;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_RMForType;
        private System.Windows.Forms.ToolStripButton btn_PrintLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Totals;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txt_Date;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_OnDate;
        private System.Windows.Forms.ToolStripButton btn_TrayTube;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Packing;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private CMB_Components.Common.cmb_Common cmb_InvNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ClientRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_placeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyrest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stockratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_invnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_manufbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_suparticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_expdate;
    }
}