namespace Odin.Warehouse.Reports
{
    partial class frm_InventoryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InventoryReport));
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
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
            this.splitter2 = new BSE.Windows.Forms.Splitter();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.chk_hidezero = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Users1 = new Odin.CMB_Components.Users.cmb_Users();
            this.chk_GroupByPrices = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_ActNum = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_ActDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btn_FCSRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_WIPRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OthersRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_RMRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chk_WIP = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_ShowInTransit = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rb_Rus = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_English = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Lat = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel27 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_StockInTypes1 = new Odin.CMB_Components.StockInTypes.cmb_StockInTypes();
            this.txt_Date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.chk_groupbylabel = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_groupbydoc = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Places1 = new Odin.CMB_Components.Places.cmb_Places();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.chk_groupbyplaces = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_FixedAssets = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cn_autoincrement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_regdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_placedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_fullplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_invnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_suparticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
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
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.crystalReportViewer1);
            this.kryptonPanel2.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(820, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel2.Size = new System.Drawing.Size(701, 633);
            this.kryptonPanel2.TabIndex = 6;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 41);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(701, 592);
            this.crystalReportViewer1.TabIndex = 4;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.AutoSize = false;
            this.kryptonHeader2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(701, 41);
            this.kryptonHeader2.TabIndex = 3;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Print form";
            this.kryptonHeader2.Values.Image = global::Odin.Global_Resourses.AppMenuPrint1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(817, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 633);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Controls.Add(this.splitter2);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(817, 633);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.gv_List);
            this.kryptonPanel4.Controls.Add(this.bn_List);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 332);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel4.Size = new System.Drawing.Size(817, 301);
            this.kryptonPanel4.TabIndex = 3;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_autoincrement,
            this.cn_artid,
            this.cn_article,
            this.cn_label,
            this.cn_stage,
            this.cn_name,
            this.cn_regdate,
            this.cn_type,
            this.cn_Supplier,
            this.cn_placedate,
            this.cn_fullplace,
            this.cn_qty,
            this.cn_unit,
            this.cn_unitlat,
            this.cn_unitprice,
            this.cn_total,
            this.cn_batch,
            this.cn_invnumber,
            this.cn_suparticle});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(817, 276);
            this.gv_List.TabIndex = 5;
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
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 276);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(817, 25);
            this.bn_List.TabIndex = 4;
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
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 329);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(817, 3);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.chk_hidezero);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel3.Controls.Add(this.cmb_Users1);
            this.kryptonPanel3.Controls.Add(this.chk_GroupByPrices);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel3.Controls.Add(this.txt_ActNum);
            this.kryptonPanel3.Controls.Add(this.txt_ActDate);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel3.Controls.Add(this.gradientPanel22);
            this.kryptonPanel3.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel3.Controls.Add(this.chk_WIP);
            this.kryptonPanel3.Controls.Add(this.chk_ShowInTransit);
            this.kryptonPanel3.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel27);
            this.kryptonPanel3.Controls.Add(this.cmb_StockInTypes1);
            this.kryptonPanel3.Controls.Add(this.txt_Date);
            this.kryptonPanel3.Controls.Add(this.chk_groupbylabel);
            this.kryptonPanel3.Controls.Add(this.chk_groupbydoc);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel3.Controls.Add(this.cmb_Places1);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel3.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel3.Controls.Add(this.cmb_Types1);
            this.kryptonPanel3.Controls.Add(this.chk_groupbyplaces);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel3.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(817, 329);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // chk_hidezero
            // 
            this.chk_hidezero.Location = new System.Drawing.Point(402, 183);
            this.chk_hidezero.Name = "chk_hidezero";
            this.chk_hidezero.Size = new System.Drawing.Size(111, 20);
            this.chk_hidezero.TabIndex = 292;
            this.chk_hidezero.Values.Text = "Hide zero prices";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(8, 303);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(192, 20);
            this.kryptonLabel7.TabIndex = 290;
            this.kryptonLabel7.Values.Text = "* - common and fixed assets only";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(8, 210);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(125, 20);
            this.kryptonLabel6.TabIndex = 289;
            this.kryptonLabel6.Values.Text = "Responsible person*:";
            // 
            // cmb_Users1
            // 
            this.cmb_Users1.Location = new System.Drawing.Point(134, 210);
            this.cmb_Users1.Name = "cmb_Users1";
            this.cmb_Users1.Size = new System.Drawing.Size(265, 20);
            this.cmb_Users1.TabIndex = 288;
            this.cmb_Users1.User = "";
            this.cmb_Users1.UserId = 0;
            this.cmb_Users1.UserLogin = null;
            this.cmb_Users1.UserShortName = "";
            this.cmb_Users1.UserTN = "";
            // 
            // chk_GroupByPrices
            // 
            this.chk_GroupByPrices.Checked = true;
            this.chk_GroupByPrices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_GroupByPrices.Location = new System.Drawing.Point(13, 264);
            this.chk_GroupByPrices.Name = "chk_GroupByPrices";
            this.chk_GroupByPrices.Size = new System.Drawing.Size(110, 20);
            this.chk_GroupByPrices.TabIndex = 287;
            this.chk_GroupByPrices.Values.Text = "Group by prices";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(8, 48);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel5.TabIndex = 286;
            this.kryptonLabel5.Values.Text = "Act number:";
            // 
            // txt_ActNum
            // 
            this.txt_ActNum.Location = new System.Drawing.Point(121, 48);
            this.txt_ActNum.Name = "txt_ActNum";
            this.txt_ActNum.Size = new System.Drawing.Size(100, 23);
            this.txt_ActNum.TabIndex = 285;
            this.txt_ActNum.Text = "0";
            // 
            // txt_ActDate
            // 
            this.txt_ActDate.CalendarShowWeekNumbers = true;
            this.txt_ActDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ActDate.Location = new System.Drawing.Point(121, 74);
            this.txt_ActDate.Name = "txt_ActDate";
            this.txt_ActDate.Size = new System.Drawing.Size(100, 21);
            this.txt_ActDate.TabIndex = 284;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(8, 74);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel3.TabIndex = 283;
            this.kryptonLabel3.Values.Text = "Act date:";
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(13, 99);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(800, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 282;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(512, 107);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_FCSRefresh);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_WIPRefresh);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_OthersRefresh);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_RMRefresh);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(223, 97);
            this.kryptonGroupBox2.TabIndex = 281;
            this.kryptonGroupBox2.Values.Heading = "Accounting inventory";
            // 
            // btn_FCSRefresh
            // 
            this.btn_FCSRefresh.Location = new System.Drawing.Point(111, 39);
            this.btn_FCSRefresh.Name = "btn_FCSRefresh";
            this.btn_FCSRefresh.Size = new System.Drawing.Size(101, 31);
            this.btn_FCSRefresh.TabIndex = 3;
            this.btn_FCSRefresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_FCSRefresh.Values.Text = "43";
            this.btn_FCSRefresh.Click += new System.EventHandler(this.btn_FCSRefresh_Click);
            // 
            // btn_WIPRefresh
            // 
            this.btn_WIPRefresh.Location = new System.Drawing.Point(4, 39);
            this.btn_WIPRefresh.Name = "btn_WIPRefresh";
            this.btn_WIPRefresh.Size = new System.Drawing.Size(101, 31);
            this.btn_WIPRefresh.TabIndex = 2;
            this.btn_WIPRefresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_WIPRefresh.Values.Text = "20";
            this.btn_WIPRefresh.Click += new System.EventHandler(this.btn_WIPRefresh_Click);
            // 
            // btn_OthersRefresh
            // 
            this.btn_OthersRefresh.Location = new System.Drawing.Point(111, 4);
            this.btn_OthersRefresh.Name = "btn_OthersRefresh";
            this.btn_OthersRefresh.Size = new System.Drawing.Size(101, 31);
            this.btn_OthersRefresh.TabIndex = 1;
            this.btn_OthersRefresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_OthersRefresh.Values.Text = "Others";
            this.btn_OthersRefresh.Click += new System.EventHandler(this.btn_OthersRefresh_Click);
            // 
            // btn_RMRefresh
            // 
            this.btn_RMRefresh.Location = new System.Drawing.Point(4, 4);
            this.btn_RMRefresh.Name = "btn_RMRefresh";
            this.btn_RMRefresh.Size = new System.Drawing.Size(101, 31);
            this.btn_RMRefresh.TabIndex = 0;
            this.btn_RMRefresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_RMRefresh.Values.Text = "10.1";
            this.btn_RMRefresh.Click += new System.EventHandler(this.btn_RMRefresh_Click);
            // 
            // chk_WIP
            // 
            this.chk_WIP.Checked = true;
            this.chk_WIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_WIP.Location = new System.Drawing.Point(402, 158);
            this.chk_WIP.Name = "chk_WIP";
            this.chk_WIP.Size = new System.Drawing.Size(78, 20);
            this.chk_WIP.TabIndex = 280;
            this.chk_WIP.Values.Text = "Show WIP";
            // 
            // chk_ShowInTransit
            // 
            this.chk_ShowInTransit.Location = new System.Drawing.Point(402, 237);
            this.chk_ShowInTransit.Name = "chk_ShowInTransit";
            this.chk_ShowInTransit.Size = new System.Drawing.Size(104, 20);
            this.chk_ShowInTransit.TabIndex = 279;
            this.chk_ShowInTransit.Values.Text = "Show in transit";
            this.chk_ShowInTransit.Visible = false;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(512, 237);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Rus);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_English);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Lat);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(223, 55);
            this.kryptonGroupBox1.TabIndex = 278;
            this.kryptonGroupBox1.Values.Heading = "Printing language";
            // 
            // rb_Rus
            // 
            this.rb_Rus.Location = new System.Drawing.Point(151, 3);
            this.rb_Rus.Name = "rb_Rus";
            this.rb_Rus.Size = new System.Drawing.Size(64, 20);
            this.rb_Rus.TabIndex = 2;
            this.rb_Rus.Values.Text = "Russian";
            // 
            // rb_English
            // 
            this.rb_English.Checked = true;
            this.rb_English.Location = new System.Drawing.Point(71, 3);
            this.rb_English.Name = "rb_English";
            this.rb_English.Size = new System.Drawing.Size(61, 20);
            this.rb_English.TabIndex = 1;
            this.rb_English.Values.Text = "English";
            // 
            // rb_Lat
            // 
            this.rb_Lat.Location = new System.Drawing.Point(4, 3);
            this.rb_Lat.Name = "rb_Lat";
            this.rb_Lat.Size = new System.Drawing.Size(61, 20);
            this.rb_Lat.TabIndex = 0;
            this.rb_Lat.Values.Text = "Latvian";
            // 
            // kryptonLabel27
            // 
            this.kryptonLabel27.Location = new System.Drawing.Point(8, 184);
            this.kryptonLabel27.Name = "kryptonLabel27";
            this.kryptonLabel27.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonLabel27.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel27.TabIndex = 277;
            this.kryptonLabel27.Values.Text = "Operation:";
            // 
            // cmb_StockInTypes1
            // 
            this.cmb_StockInTypes1.Lang = "ENG";
            this.cmb_StockInTypes1.Location = new System.Drawing.Point(134, 184);
            this.cmb_StockInTypes1.MovType = 1;
            this.cmb_StockInTypes1.Name = "cmb_StockInTypes1";
            this.cmb_StockInTypes1.Size = new System.Drawing.Size(161, 20);
            this.cmb_StockInTypes1.StockMovType = "";
            this.cmb_StockInTypes1.StockMovTypeId = 0;
            this.cmb_StockInTypes1.StockMovTypeLat = "";
            this.cmb_StockInTypes1.TabIndex = 276;
            // 
            // txt_Date
            // 
            this.txt_Date.CalendarShowWeekNumbers = true;
            this.txt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Date.Location = new System.Drawing.Point(121, 237);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(92, 21);
            this.txt_Date.TabIndex = 249;
            // 
            // chk_groupbylabel
            // 
            this.chk_groupbylabel.Checked = true;
            this.chk_groupbylabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_groupbylabel.Location = new System.Drawing.Point(391, 264);
            this.chk_groupbylabel.Name = "chk_groupbylabel";
            this.chk_groupbylabel.Size = new System.Drawing.Size(109, 20);
            this.chk_groupbylabel.TabIndex = 248;
            this.chk_groupbylabel.Values.Text = "Group by labels";
            // 
            // chk_groupbydoc
            // 
            this.chk_groupbydoc.Checked = true;
            this.chk_groupbydoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_groupbydoc.Location = new System.Drawing.Point(246, 264);
            this.chk_groupbydoc.Name = "chk_groupbydoc";
            this.chk_groupbydoc.Size = new System.Drawing.Size(139, 20);
            this.chk_groupbydoc.TabIndex = 247;
            this.chk_groupbydoc.Values.Text = "Group by documents";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(8, 158);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel4.TabIndex = 246;
            this.kryptonLabel4.Values.Text = "Stock place*:";
            // 
            // cmb_Places1
            // 
            this.cmb_Places1.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Places1.Department = "";
            this.cmb_Places1.IsQuarantine = 0;
            this.cmb_Places1.Location = new System.Drawing.Point(134, 158);
            this.cmb_Places1.Lock = 0;
            this.cmb_Places1.Name = "cmb_Places1";
            this.cmb_Places1.PlaceId = 0;
            this.cmb_Places1.SelectedNode = null;
            this.cmb_Places1.Size = new System.Drawing.Size(265, 20);
            this.cmb_Places1.TabIndex = 245;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 107);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel1.TabIndex = 244;
            this.kryptonLabel1.Values.Text = "Article*:";
            // 
            // cmb_Articles1
            // 
            this.cmb_Articles1.Article = "";
            this.cmb_Articles1.ArticleId = 0;
            this.cmb_Articles1.ArticleIdRec = 0;
            this.cmb_Articles1.ArtType = null;
            this.cmb_Articles1.BOMState = 0;
            this.cmb_Articles1.CertState = "";
            this.cmb_Articles1.Comments = null;
            this.cmb_Articles1.CustCode = null;
            this.cmb_Articles1.CustCodeId = 0;
            this.cmb_Articles1.Department = null;
            this.cmb_Articles1.DeptId = 0;
            this.cmb_Articles1.Description = null;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(134, 106);
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
            this.cmb_Articles1.Stage = null;
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 243;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 132);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel2.TabIndex = 242;
            this.kryptonLabel2.Values.Text = "Type*:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(134, 132);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(196, 20);
            this.cmb_Types1.TabIndex = 241;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // chk_groupbyplaces
            // 
            this.chk_groupbyplaces.Checked = true;
            this.chk_groupbyplaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_groupbyplaces.Location = new System.Drawing.Point(123, 264);
            this.chk_groupbyplaces.Name = "chk_groupbyplaces";
            this.chk_groupbyplaces.Size = new System.Drawing.Size(112, 20);
            this.chk_groupbyplaces.TabIndex = 240;
            this.chk_groupbyplaces.Values.Text = "Group by places";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(8, 238);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(110, 20);
            this.kryptonLabel8.TabIndex = 234;
            this.kryptonLabel8.Values.Text = "Inventory on date:";
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_FixedAssets,
            this.btn_Refresh,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonHeader1.Size = new System.Drawing.Size(817, 42);
            this.kryptonHeader1.TabIndex = 2;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Filter";
            this.kryptonHeader1.Values.Image = global::Odin.Global_Resourses.Filter;
            // 
            // btn_FixedAssets
            // 
            this.btn_FixedAssets.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_FixedAssets.Image = global::Odin.Global_Resourses.toolbox;
            this.btn_FixedAssets.UniqueName = "FE5F36CD6C8248129A92CED3FB774333";
            this.btn_FixedAssets.Click += new System.EventHandler(this.btn_FixedAssets_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.UniqueName = "3502D2542D5C42F0078623FF0A695273";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cn_autoincrement
            // 
            this.cn_autoincrement.DataPropertyName = "autoincrement";
            this.cn_autoincrement.FillWeight = 60F;
            this.cn_autoincrement.HeaderText = "Num.";
            this.cn_autoincrement.Name = "cn_autoincrement";
            this.cn_autoincrement.ReadOnly = true;
            this.cn_autoincrement.Width = 60;
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
            this.cn_article.FillWeight = 150F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Width = 150;
            // 
            // cn_label
            // 
            this.cn_label.DataPropertyName = "label";
            this.cn_label.HeaderText = "Label";
            this.cn_label.Name = "cn_label";
            this.cn_label.ReadOnly = true;
            // 
            // cn_stage
            // 
            this.cn_stage.DataPropertyName = "stage";
            this.cn_stage.FillWeight = 50F;
            this.cn_stage.HeaderText = "Stage";
            this.cn_stage.Name = "cn_stage";
            this.cn_stage.ReadOnly = true;
            this.cn_stage.Width = 50;
            // 
            // cn_name
            // 
            this.cn_name.DataPropertyName = "incomedoc";
            this.cn_name.HeaderText = "Income doc.";
            this.cn_name.Name = "cn_name";
            this.cn_name.ReadOnly = true;
            // 
            // cn_regdate
            // 
            this.cn_regdate.DataPropertyName = "regdate";
            this.cn_regdate.FillWeight = 90F;
            this.cn_regdate.HeaderText = "Reg. date";
            this.cn_regdate.Name = "cn_regdate";
            this.cn_regdate.ReadOnly = true;
            this.cn_regdate.Width = 90;
            // 
            // cn_type
            // 
            this.cn_type.DataPropertyName = "type";
            this.cn_type.HeaderText = "Type";
            this.cn_type.Name = "cn_type";
            this.cn_type.ReadOnly = true;
            this.cn_type.Width = 70;
            // 
            // cn_Supplier
            // 
            this.cn_Supplier.DataPropertyName = "supplier";
            this.cn_Supplier.FillWeight = 120F;
            this.cn_Supplier.HeaderText = "Supplier";
            this.cn_Supplier.Name = "cn_Supplier";
            this.cn_Supplier.ReadOnly = true;
            this.cn_Supplier.Width = 120;
            // 
            // cn_placedate
            // 
            this.cn_placedate.DataPropertyName = "place";
            this.cn_placedate.HeaderText = "Place";
            this.cn_placedate.Name = "cn_placedate";
            this.cn_placedate.ReadOnly = true;
            // 
            // cn_fullplace
            // 
            this.cn_fullplace.DataPropertyName = "fullplace";
            this.cn_fullplace.FillWeight = 200F;
            this.cn_fullplace.HeaderText = "Full place";
            this.cn_fullplace.Name = "cn_fullplace";
            this.cn_fullplace.ReadOnly = true;
            this.cn_fullplace.Width = 200;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qtyrest";
            this.cn_qty.FillWeight = 80F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 80;
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
            // cn_unitlat
            // 
            this.cn_unitlat.DataPropertyName = "unitlat";
            this.cn_unitlat.FillWeight = 40F;
            this.cn_unitlat.HeaderText = "Unit (BR)";
            this.cn_unitlat.Name = "cn_unitlat";
            this.cn_unitlat.ReadOnly = true;
            this.cn_unitlat.Width = 40;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price (BR)";
            this.cn_unitprice.Name = "cn_unitprice";
            this.cn_unitprice.ReadOnly = true;
            // 
            // cn_total
            // 
            this.cn_total.DataPropertyName = "total";
            this.cn_total.HeaderText = "Total (BR)";
            this.cn_total.Name = "cn_total";
            this.cn_total.ReadOnly = true;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.ReadOnly = true;
            // 
            // cn_invnumber
            // 
            this.cn_invnumber.DataPropertyName = "invnumber";
            this.cn_invnumber.HeaderText = "Inv. number";
            this.cn_invnumber.Name = "cn_invnumber";
            this.cn_invnumber.ReadOnly = true;
            // 
            // cn_suparticle
            // 
            this.cn_suparticle.DataPropertyName = "suparticle";
            this.cn_suparticle.HeaderText = "Sup. article";
            this.cn_suparticle.Name = "cn_suparticle";
            this.cn_suparticle.ReadOnly = true;
            // 
            // frm_InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 633);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_InventoryReport";
            this.TabText = "Inventory report";
            this.Text = "Inventory report";
            this.Load += new System.EventHandler(this.frm_InventoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private BSE.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_groupbyplaces;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private System.Windows.Forms.BindingSource bs_List;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private BSE.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator bn_List;
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
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_groupbylabel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_groupbydoc;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CMB_Components.Places.cmb_Places cmb_Places1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txt_Date;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel27;
        private CMB_Components.StockInTypes.cmb_StockInTypes cmb_StockInTypes1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_English;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Lat;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_ShowInTransit;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_WIP;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_FCSRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_WIPRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OthersRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RMRefresh;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_ActNum;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txt_ActDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_GroupByPrices;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_FixedAssets;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CMB_Components.Users.cmb_Users cmb_Users1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Rus;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_hidezero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_autoincrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_regdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_placedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_fullplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_invnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_suparticle;
    }
}