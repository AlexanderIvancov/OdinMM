namespace Odin.Warehouse.Reports
{
    partial class frm_TurnoverReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TurnoverReports));
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtybeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sumbeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sumin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sumout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sumend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtydiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sumdiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btn_FCSRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_WIPRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OthersRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_RMRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_CreatDateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_CreatDateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Controls.Add(this.splitter2);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(817, 618);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.gv_List);
            this.kryptonPanel4.Controls.Add(this.bn_List);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 207);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel4.Size = new System.Drawing.Size(817, 411);
            this.kryptonPanel4.TabIndex = 3;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_num,
            this.cn_artid,
            this.cn_article,
            this.cn_unit,
            this.cn_unitprice,
            this.cn_qtybeg,
            this.cn_sumbeg,
            this.cn_qtyin,
            this.cn_sumin,
            this.cn_qtyout,
            this.cn_sumout,
            this.cn_qtyend,
            this.cn_sumend,
            this.cn_qtydiff,
            this.cn_sumdiff});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(817, 386);
            this.gv_List.TabIndex = 5;
            // 
            // cn_num
            // 
            this.cn_num.DataPropertyName = "num";
            this.cn_num.FillWeight = 70F;
            this.cn_num.HeaderText = "Num.";
            this.cn_num.Name = "cn_num";
            this.cn_num.ReadOnly = true;
            this.cn_num.Width = 70;
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
            // cn_unit
            // 
            this.cn_unit.DataPropertyName = "unit";
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.ReadOnly = true;
            this.cn_unit.Width = 40;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.FillWeight = 80F;
            this.cn_unitprice.HeaderText = "Unit price (€)";
            this.cn_unitprice.Name = "cn_unitprice";
            this.cn_unitprice.ReadOnly = true;
            this.cn_unitprice.Width = 80;
            // 
            // cn_qtybeg
            // 
            this.cn_qtybeg.DataPropertyName = "qtybeg";
            this.cn_qtybeg.FillWeight = 80F;
            this.cn_qtybeg.HeaderText = "Qty beg.";
            this.cn_qtybeg.Name = "cn_qtybeg";
            this.cn_qtybeg.ReadOnly = true;
            this.cn_qtybeg.Width = 80;
            // 
            // cn_sumbeg
            // 
            this.cn_sumbeg.DataPropertyName = "sumbeg";
            this.cn_sumbeg.FillWeight = 80F;
            this.cn_sumbeg.HeaderText = "Summ beg.(€)";
            this.cn_sumbeg.Name = "cn_sumbeg";
            this.cn_sumbeg.ReadOnly = true;
            this.cn_sumbeg.Width = 80;
            // 
            // cn_qtyin
            // 
            this.cn_qtyin.DataPropertyName = "qtyin";
            this.cn_qtyin.FillWeight = 80F;
            this.cn_qtyin.HeaderText = "Qty in";
            this.cn_qtyin.Name = "cn_qtyin";
            this.cn_qtyin.ReadOnly = true;
            this.cn_qtyin.Width = 80;
            // 
            // cn_sumin
            // 
            this.cn_sumin.DataPropertyName = "sumin";
            this.cn_sumin.FillWeight = 80F;
            this.cn_sumin.HeaderText = "Sum in (€)";
            this.cn_sumin.Name = "cn_sumin";
            this.cn_sumin.ReadOnly = true;
            this.cn_sumin.Width = 80;
            // 
            // cn_qtyout
            // 
            this.cn_qtyout.DataPropertyName = "qtyout";
            this.cn_qtyout.FillWeight = 80F;
            this.cn_qtyout.HeaderText = "Qty out";
            this.cn_qtyout.Name = "cn_qtyout";
            this.cn_qtyout.ReadOnly = true;
            this.cn_qtyout.Width = 80;
            // 
            // cn_sumout
            // 
            this.cn_sumout.DataPropertyName = "sumout";
            this.cn_sumout.FillWeight = 80F;
            this.cn_sumout.HeaderText = "Sum out (€)";
            this.cn_sumout.Name = "cn_sumout";
            this.cn_sumout.ReadOnly = true;
            this.cn_sumout.Width = 80;
            // 
            // cn_qtyend
            // 
            this.cn_qtyend.DataPropertyName = "qtyend";
            this.cn_qtyend.FillWeight = 80F;
            this.cn_qtyend.HeaderText = "Qty end";
            this.cn_qtyend.Name = "cn_qtyend";
            this.cn_qtyend.ReadOnly = true;
            this.cn_qtyend.Width = 80;
            // 
            // cn_sumend
            // 
            this.cn_sumend.DataPropertyName = "sumend";
            this.cn_sumend.FillWeight = 80F;
            this.cn_sumend.HeaderText = "Sum end (€)";
            this.cn_sumend.Name = "cn_sumend";
            this.cn_sumend.ReadOnly = true;
            this.cn_sumend.Width = 80;
            // 
            // cn_qtydiff
            // 
            this.cn_qtydiff.DataPropertyName = "qtydiff";
            this.cn_qtydiff.FillWeight = 80F;
            this.cn_qtydiff.HeaderText = "Qty diff";
            this.cn_qtydiff.Name = "cn_qtydiff";
            this.cn_qtydiff.ReadOnly = true;
            this.cn_qtydiff.Width = 80;
            // 
            // cn_sumdiff
            // 
            this.cn_sumdiff.DataPropertyName = "sumdiff";
            this.cn_sumdiff.FillWeight = 80F;
            this.cn_sumdiff.HeaderText = "Sum diff (€)";
            this.cn_sumdiff.Name = "cn_sumdiff";
            this.cn_sumdiff.ReadOnly = true;
            this.cn_sumdiff.Width = 80;
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
            this.bn_List.Location = new System.Drawing.Point(0, 386);
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
            this.splitter2.Location = new System.Drawing.Point(0, 204);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(817, 3);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel3.Controls.Add(this.txt_CreatDateTill);
            this.kryptonPanel3.Controls.Add(this.txt_CreatDateFrom);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel3.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(817, 204);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 48);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_FCSRefresh);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_WIPRefresh);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_OthersRefresh);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_RMRefresh);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(223, 97);
            this.kryptonGroupBox2.TabIndex = 282;
            this.kryptonGroupBox2.Values.Heading = "Account";
            // 
            // btn_FCSRefresh
            // 
            this.btn_FCSRefresh.Location = new System.Drawing.Point(111, 4);
            this.btn_FCSRefresh.Name = "btn_FCSRefresh";
            this.btn_FCSRefresh.Size = new System.Drawing.Size(101, 31);
            this.btn_FCSRefresh.TabIndex = 3;
            this.btn_FCSRefresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_FCSRefresh.Values.Text = "2130";
            this.btn_FCSRefresh.Click += new System.EventHandler(this.btn_FCSRefresh_Click);
            // 
            // btn_WIPRefresh
            // 
            this.btn_WIPRefresh.Location = new System.Drawing.Point(4, 39);
            this.btn_WIPRefresh.Name = "btn_WIPRefresh";
            this.btn_WIPRefresh.Size = new System.Drawing.Size(101, 31);
            this.btn_WIPRefresh.TabIndex = 2;
            this.btn_WIPRefresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_WIPRefresh.Values.Text = "2120";
            this.btn_WIPRefresh.Click += new System.EventHandler(this.btn_WIPRefresh_Click);
            // 
            // btn_OthersRefresh
            // 
            this.btn_OthersRefresh.Location = new System.Drawing.Point(111, 39);
            this.btn_OthersRefresh.Name = "btn_OthersRefresh";
            this.btn_OthersRefresh.Size = new System.Drawing.Size(101, 31);
            this.btn_OthersRefresh.TabIndex = 1;
            this.btn_OthersRefresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_OthersRefresh.Values.Text = "Others";
            this.btn_OthersRefresh.Visible = false;
            // 
            // btn_RMRefresh
            // 
            this.btn_RMRefresh.Location = new System.Drawing.Point(4, 4);
            this.btn_RMRefresh.Name = "btn_RMRefresh";
            this.btn_RMRefresh.Size = new System.Drawing.Size(101, 31);
            this.btn_RMRefresh.TabIndex = 0;
            this.btn_RMRefresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_RMRefresh.Values.Text = "2110";
            this.btn_RMRefresh.Click += new System.EventHandler(this.btn_RMRefresh_Click);
            // 
            // txt_CreatDateTill
            // 
            this.txt_CreatDateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_CreatDateTill.CalendarShowWeekNumbers = true;
            this.txt_CreatDateTill.CustomFormat = null;
            this.txt_CreatDateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CreatDateTill.Location = new System.Drawing.Point(199, 177);
            this.txt_CreatDateTill.Name = "txt_CreatDateTill";
            this.txt_CreatDateTill.NullValue = " ";
            this.txt_CreatDateTill.Size = new System.Drawing.Size(104, 21);
            this.txt_CreatDateTill.TabIndex = 237;
            this.txt_CreatDateTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_CreatDateTill_DropDown);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny4.UniqueName = "6A2751F9284C45EEA28C814570A892DD";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // txt_CreatDateFrom
            // 
            this.txt_CreatDateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_CreatDateFrom.CalendarShowWeekNumbers = true;
            this.txt_CreatDateFrom.CustomFormat = null;
            this.txt_CreatDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CreatDateFrom.Location = new System.Drawing.Point(59, 177);
            this.txt_CreatDateFrom.Name = "txt_CreatDateFrom";
            this.txt_CreatDateFrom.NullValue = " ";
            this.txt_CreatDateFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_CreatDateFrom.TabIndex = 236;
            this.txt_CreatDateFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_CreatDateFrom_MouseDown);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(166, 178);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel11.TabIndex = 235;
            this.kryptonLabel11.Values.Text = "till:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(12, 177);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 234;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 156);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel7.TabIndex = 233;
            this.kryptonLabel7.Values.Text = "Period:";
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonHeader1.Size = new System.Drawing.Size(817, 34);
            this.kryptonHeader1.TabIndex = 2;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Filter";
            this.kryptonHeader1.Values.Image = global::Odin.Global_Resourses.Filter;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            this.btn_Refresh.Visible = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.UniqueName = "3502D2542D5C42F0078623FF0A695273";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(817, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 618);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.crystalReportViewer1);
            this.kryptonPanel2.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(820, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel2.Size = new System.Drawing.Size(435, 618);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 41);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(435, 577);
            this.crystalReportViewer1.TabIndex = 4;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.AutoSize = false;
            this.kryptonHeader2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(435, 41);
            this.kryptonHeader2.TabIndex = 3;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Print form";
            this.kryptonHeader2.Values.Image = global::Odin.Global_Resourses.AppMenuPrint1;
            // 
            // frm_TurnoverReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 618);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_TurnoverReports";
            this.TabText = "Turnover reports";
            this.Text = "Turnover reports";
            this.Load += new System.EventHandler(this.frm_MovementReports_Load);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.GetKryptonFormFields(this.GetType());
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.BindingSource bs_List;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
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
        private BSE.Windows.Forms.Splitter splitter2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private CustomControls.NullableDateTimePicker txt_CreatDateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private CustomControls.NullableDateTimePicker txt_CreatDateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private BSE.Windows.Forms.Splitter splitter1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_FCSRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_WIPRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OthersRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RMRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtybeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sumbeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sumin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyout;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sumout;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sumend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtydiff;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sumdiff;
    }
}