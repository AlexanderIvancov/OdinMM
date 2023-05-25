namespace Odin.Finances
{
    partial class frm_Intrastat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Intrastat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.dn_Pages = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.pg_Income = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_IncomeList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bn_IncomeList = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.btn_Upload1B = new System.Windows.Forms.ToolStripButton();
            this.pg_Outcome = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_OutcomeList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_regdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_docdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_supart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_itype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ioperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_supid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coefconv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totalvat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totalwithvat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_OutcomeList = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcelI = new System.Windows.Forms.ToolStripButton();
            this.btn_Upload2A = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_DateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_DateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bs_IncomeList = new Odin.Global_Classes.SyncBindingSource();
            this.bs_OutcomeList = new Odin.Global_Classes.SyncBindingSource();
            this.cn_inum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isuctcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_iweightnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_iproducer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ibargain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_itransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_iincoterms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dn_Pages)).BeginInit();
            this.dn_Pages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Income)).BeginInit();
            this.pg_Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_IncomeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_IncomeList)).BeginInit();
            this.bn_IncomeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Outcome)).BeginInit();
            this.pg_Outcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_OutcomeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_OutcomeList)).BeginInit();
            this.bn_OutcomeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_IncomeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OutcomeList)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dn_Pages);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(931, 603);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Intrastat";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.european_union_flag_3872;
            // 
            // dn_Pages
            // 
            this.dn_Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dn_Pages.Location = new System.Drawing.Point(0, 81);
            this.dn_Pages.Name = "dn_Pages";
            this.dn_Pages.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pg_Income,
            this.pg_Outcome});
            this.dn_Pages.SelectedIndex = 0;
            this.dn_Pages.Size = new System.Drawing.Size(929, 464);
            this.dn_Pages.TabIndex = 1;
            this.dn_Pages.Text = "kryptonDockableNavigator1";
            // 
            // pg_Income
            // 
            this.pg_Income.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Income.Controls.Add(this.gv_IncomeList);
            this.pg_Income.Controls.Add(this.bn_IncomeList);
            this.pg_Income.Flags = 65534;
            this.pg_Income.LastVisibleSet = true;
            this.pg_Income.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Income.Name = "pg_Income";
            this.pg_Income.Size = new System.Drawing.Size(927, 437);
            this.pg_Income.Text = "1B";
            this.pg_Income.ToolTipTitle = "Page ToolTip";
            this.pg_Income.UniqueName = "2B6928D3721E42AF228A7C438C886EBE";
            // 
            // gv_IncomeList
            // 
            this.gv_IncomeList.AllowUserToAddRows = false;
            this.gv_IncomeList.AllowUserToDeleteRows = false;
            this.gv_IncomeList.AllowUserToOrderColumns = true;
            this.gv_IncomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_IncomeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_inum,
            this.cn_isuctcode,
            this.cn_isumma,
            this.cn_iweightnet,
            this.cn_isender,
            this.cn_iproducer,
            this.cn_ibargain,
            this.cn_itransport,
            this.cn_iincoterms});
            this.gv_IncomeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_IncomeList.Location = new System.Drawing.Point(0, 0);
            this.gv_IncomeList.Name = "gv_IncomeList";
            this.gv_IncomeList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_IncomeList.ReadOnly = true;
            this.gv_IncomeList.RowHeadersWidth = 20;
            this.gv_IncomeList.Size = new System.Drawing.Size(927, 412);
            this.gv_IncomeList.TabIndex = 10;
            // 
            // bn_IncomeList
            // 
            this.bn_IncomeList.AddNewItem = null;
            this.bn_IncomeList.CountItem = this.toolStripLabel1;
            this.bn_IncomeList.DeleteItem = null;
            this.bn_IncomeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_IncomeList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_IncomeList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.btn_Upload1B});
            this.bn_IncomeList.Location = new System.Drawing.Point(0, 412);
            this.bn_IncomeList.MoveFirstItem = this.toolStripButton1;
            this.bn_IncomeList.MoveLastItem = this.toolStripButton4;
            this.bn_IncomeList.MoveNextItem = this.toolStripButton3;
            this.bn_IncomeList.MovePreviousItem = this.toolStripButton2;
            this.bn_IncomeList.Name = "bn_IncomeList";
            this.bn_IncomeList.PositionItem = this.toolStripTextBox1;
            this.bn_IncomeList.Size = new System.Drawing.Size(927, 25);
            this.bn_IncomeList.TabIndex = 9;
            this.bn_IncomeList.Text = "bn_IncomeList";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Export into excel 1B";
            // 
            // btn_Upload1B
            // 
            this.btn_Upload1B.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Upload1B.Image = global::Odin.Global_Resourses.Upload_24x24;
            this.btn_Upload1B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Upload1B.Name = "btn_Upload1B";
            this.btn_Upload1B.Size = new System.Drawing.Size(23, 22);
            this.btn_Upload1B.Text = "Upload in xml";
            // 
            // pg_Outcome
            // 
            this.pg_Outcome.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Outcome.Controls.Add(this.gv_OutcomeList);
            this.pg_Outcome.Controls.Add(this.bn_OutcomeList);
            this.pg_Outcome.Flags = 65534;
            this.pg_Outcome.LastVisibleSet = true;
            this.pg_Outcome.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Outcome.Name = "pg_Outcome";
            this.pg_Outcome.Size = new System.Drawing.Size(927, 437);
            this.pg_Outcome.Text = "2A";
            this.pg_Outcome.ToolTipTitle = "Page ToolTip";
            this.pg_Outcome.UniqueName = "6CD7BEEC261A4922DB98348ADE8A2A66";
            // 
            // gv_OutcomeList
            // 
            this.gv_OutcomeList.AllowUserToAddRows = false;
            this.gv_OutcomeList.AllowUserToDeleteRows = false;
            this.gv_OutcomeList.AllowUserToOrderColumns = true;
            this.gv_OutcomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_OutcomeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_headid,
            this.cn_name,
            this.cn_regdate,
            this.cn_docdate,
            this.cn_Supplier,
            this.cn_artid,
            this.cn_article,
            this.cn_supart,
            this.cn_itype,
            this.cn_ioperation,
            this.cn_supid,
            this.cn_qty,
            this.cn_unit,
            this.cn_unitprice,
            this.cn_discount,
            this.cn_currency,
            this.cn_vat,
            this.cn_Batch,
            this.cn_comments,
            this.cn_coefconv,
            this.cn_weight,
            this.cn_total,
            this.cn_totalvat,
            this.cn_totalwithvat,
            this.cn_custcode,
            this.cn_createdat,
            this.cn_createdby,
            this.cn_state});
            this.gv_OutcomeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_OutcomeList.Location = new System.Drawing.Point(0, 0);
            this.gv_OutcomeList.Name = "gv_OutcomeList";
            this.gv_OutcomeList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_OutcomeList.ReadOnly = true;
            this.gv_OutcomeList.RowHeadersWidth = 20;
            this.gv_OutcomeList.Size = new System.Drawing.Size(927, 412);
            this.gv_OutcomeList.TabIndex = 10;
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
            // cn_docdate
            // 
            this.cn_docdate.DataPropertyName = "docdate";
            this.cn_docdate.FillWeight = 90F;
            this.cn_docdate.HeaderText = "Doc. date";
            this.cn_docdate.Name = "cn_docdate";
            this.cn_docdate.ReadOnly = true;
            this.cn_docdate.Width = 90;
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
            // cn_supart
            // 
            this.cn_supart.DataPropertyName = "suparticle";
            this.cn_supart.FillWeight = 200F;
            this.cn_supart.HeaderText = "Supplier\'s article";
            this.cn_supart.Name = "cn_supart";
            this.cn_supart.ReadOnly = true;
            this.cn_supart.Width = 200;
            // 
            // cn_itype
            // 
            this.cn_itype.DataPropertyName = "type";
            this.cn_itype.HeaderText = "Type";
            this.cn_itype.Name = "cn_itype";
            this.cn_itype.ReadOnly = true;
            // 
            // cn_ioperation
            // 
            this.cn_ioperation.DataPropertyName = "operation";
            this.cn_ioperation.HeaderText = "Operation";
            this.cn_ioperation.Name = "cn_ioperation";
            this.cn_ioperation.ReadOnly = true;
            // 
            // cn_supid
            // 
            this.cn_supid.DataPropertyName = "supid";
            this.cn_supid.FillWeight = 30F;
            this.cn_supid.HeaderText = "supid";
            this.cn_supid.Name = "cn_supid";
            this.cn_supid.ReadOnly = true;
            this.cn_supid.Visible = false;
            this.cn_supid.Width = 30;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
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
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price";
            this.cn_unitprice.Name = "cn_unitprice";
            this.cn_unitprice.ReadOnly = true;
            // 
            // cn_discount
            // 
            this.cn_discount.DataPropertyName = "discount";
            this.cn_discount.FillWeight = 40F;
            this.cn_discount.HeaderText = "Disc.";
            this.cn_discount.Name = "cn_discount";
            this.cn_discount.ReadOnly = true;
            this.cn_discount.Width = 40;
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
            this.cn_vat.HeaderText = "Vat";
            this.cn_vat.Name = "cn_vat";
            this.cn_vat.ReadOnly = true;
            this.cn_vat.Width = 30;
            // 
            // cn_Batch
            // 
            this.cn_Batch.DataPropertyName = "batch";
            this.cn_Batch.HeaderText = "Batch";
            this.cn_Batch.Name = "cn_Batch";
            this.cn_Batch.ReadOnly = true;
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
            // cn_coefconv
            // 
            this.cn_coefconv.DataPropertyName = "coefconv";
            this.cn_coefconv.HeaderText = "CoefConv";
            this.cn_coefconv.Name = "cn_coefconv";
            this.cn_coefconv.ReadOnly = true;
            this.cn_coefconv.Visible = false;
            // 
            // cn_weight
            // 
            this.cn_weight.DataPropertyName = "weight";
            this.cn_weight.FillWeight = 80F;
            this.cn_weight.HeaderText = "Weight net";
            this.cn_weight.Name = "cn_weight";
            this.cn_weight.ReadOnly = true;
            this.cn_weight.Width = 80;
            // 
            // cn_total
            // 
            this.cn_total.DataPropertyName = "total";
            this.cn_total.HeaderText = "Total";
            this.cn_total.Name = "cn_total";
            this.cn_total.ReadOnly = true;
            // 
            // cn_totalvat
            // 
            this.cn_totalvat.DataPropertyName = "totalvat";
            this.cn_totalvat.HeaderText = "Total Vat";
            this.cn_totalvat.Name = "cn_totalvat";
            this.cn_totalvat.ReadOnly = true;
            // 
            // cn_totalwithvat
            // 
            this.cn_totalwithvat.DataPropertyName = "totalwithvat";
            this.cn_totalwithvat.HeaderText = "Total + Vat";
            this.cn_totalwithvat.Name = "cn_totalwithvat";
            this.cn_totalwithvat.ReadOnly = true;
            // 
            // cn_custcode
            // 
            this.cn_custcode.DataPropertyName = "custcode";
            this.cn_custcode.HeaderText = "Cust. code";
            this.cn_custcode.Name = "cn_custcode";
            this.cn_custcode.ReadOnly = true;
            // 
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "createdat";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.cn_createdat.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_createdat.FillWeight = 85F;
            this.cn_createdat.HeaderText = "Created at";
            this.cn_createdat.Name = "cn_createdat";
            this.cn_createdat.ReadOnly = true;
            this.cn_createdat.Width = 85;
            // 
            // cn_createdby
            // 
            this.cn_createdby.DataPropertyName = "createdby";
            this.cn_createdby.HeaderText = "Created by";
            this.cn_createdby.Name = "cn_createdby";
            this.cn_createdby.ReadOnly = true;
            // 
            // cn_state
            // 
            this.cn_state.DataPropertyName = "state";
            this.cn_state.HeaderText = "State";
            this.cn_state.Name = "cn_state";
            this.cn_state.ReadOnly = true;
            this.cn_state.Visible = false;
            // 
            // bn_OutcomeList
            // 
            this.bn_OutcomeList.AddNewItem = null;
            this.bn_OutcomeList.CountItem = this.bindingNavigatorCountItem;
            this.bn_OutcomeList.DeleteItem = null;
            this.bn_OutcomeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_OutcomeList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_OutcomeList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btn_ExcelI,
            this.btn_Upload2A});
            this.bn_OutcomeList.Location = new System.Drawing.Point(0, 412);
            this.bn_OutcomeList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_OutcomeList.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_OutcomeList.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_OutcomeList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_OutcomeList.Name = "bn_OutcomeList";
            this.bn_OutcomeList.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_OutcomeList.Size = new System.Drawing.Size(927, 25);
            this.bn_OutcomeList.TabIndex = 9;
            this.bn_OutcomeList.Text = "1B";
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
            // btn_ExcelI
            // 
            this.btn_ExcelI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelI.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExcelI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelI.Name = "btn_ExcelI";
            this.btn_ExcelI.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelI.Text = "Export into excel 2A";
            // 
            // btn_Upload2A
            // 
            this.btn_Upload2A.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Upload2A.Image = global::Odin.Global_Resourses.Upload_24x24;
            this.btn_Upload2A.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Upload2A.Name = "btn_Upload2A";
            this.btn_Upload2A.Size = new System.Drawing.Size(23, 22);
            this.btn_Upload2A.Text = "Upload in xml";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Refresh);
            this.kryptonPanel1.Controls.Add(this.txt_DateTill);
            this.kryptonPanel1.Controls.Add(this.txt_DateFrom);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(929, 81);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.Location = new System.Drawing.Point(172, 18);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(48, 45);
            this.btn_Refresh.TabIndex = 225;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_DateTill
            // 
            this.txt_DateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_DateTill.CalendarShowWeekNumbers = true;
            this.txt_DateTill.CustomFormat = null;
            this.txt_DateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateTill.Location = new System.Drawing.Point(61, 43);
            this.txt_DateTill.Name = "txt_DateTill";
            this.txt_DateTill.NullValue = " ";
            this.txt_DateTill.Size = new System.Drawing.Size(105, 21);
            this.txt_DateTill.TabIndex = 224;
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny4.UniqueName = "6A2751F9284C45EEA28C814570A892DD";
            // 
            // txt_DateFrom
            // 
            this.txt_DateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_DateFrom.CalendarShowWeekNumbers = true;
            this.txt_DateFrom.CustomFormat = null;
            this.txt_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateFrom.Location = new System.Drawing.Point(61, 16);
            this.txt_DateFrom.Name = "txt_DateFrom";
            this.txt_DateFrom.NullValue = " ";
            this.txt_DateFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_DateFrom.TabIndex = 223;
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny5.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(14, 43);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(29, 20);
            this.kryptonLabel11.TabIndex = 222;
            this.kryptonLabel11.Values.Text = "Till:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(14, 17);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 221;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // cn_inum
            // 
            this.cn_inum.DataPropertyName = "number";
            this.cn_inum.FillWeight = 45F;
            this.cn_inum.HeaderText = "Number";
            this.cn_inum.Name = "cn_inum";
            this.cn_inum.ReadOnly = true;
            this.cn_inum.Width = 45;
            // 
            // cn_isuctcode
            // 
            this.cn_isuctcode.DataPropertyName = "custcode";
            this.cn_isuctcode.FillWeight = 110F;
            this.cn_isuctcode.HeaderText = "Cust. code";
            this.cn_isuctcode.Name = "cn_isuctcode";
            this.cn_isuctcode.ReadOnly = true;
            this.cn_isuctcode.Width = 110;
            // 
            // cn_isumma
            // 
            this.cn_isumma.DataPropertyName = "summa";
            this.cn_isumma.FillWeight = 90F;
            this.cn_isumma.HeaderText = "Summa";
            this.cn_isumma.Name = "cn_isumma";
            this.cn_isumma.ReadOnly = true;
            this.cn_isumma.Width = 90;
            // 
            // cn_iweightnet
            // 
            this.cn_iweightnet.DataPropertyName = "weightnet";
            this.cn_iweightnet.FillWeight = 90F;
            this.cn_iweightnet.HeaderText = "Weight";
            this.cn_iweightnet.Name = "cn_iweightnet";
            this.cn_iweightnet.ReadOnly = true;
            this.cn_iweightnet.Width = 90;
            // 
            // cn_isender
            // 
            this.cn_isender.DataPropertyName = "sender";
            this.cn_isender.FillWeight = 80F;
            this.cn_isender.HeaderText = "Sender";
            this.cn_isender.Name = "cn_isender";
            this.cn_isender.ReadOnly = true;
            this.cn_isender.Width = 80;
            // 
            // cn_iproducer
            // 
            this.cn_iproducer.DataPropertyName = "producer";
            this.cn_iproducer.FillWeight = 80F;
            this.cn_iproducer.HeaderText = "Producer";
            this.cn_iproducer.Name = "cn_iproducer";
            this.cn_iproducer.ReadOnly = true;
            this.cn_iproducer.Width = 80;
            // 
            // cn_ibargain
            // 
            this.cn_ibargain.DataPropertyName = "bargain";
            this.cn_ibargain.FillWeight = 80F;
            this.cn_ibargain.HeaderText = "Bargain";
            this.cn_ibargain.Name = "cn_ibargain";
            this.cn_ibargain.ReadOnly = true;
            this.cn_ibargain.Width = 80;
            // 
            // cn_itransport
            // 
            this.cn_itransport.DataPropertyName = "transport";
            this.cn_itransport.FillWeight = 80F;
            this.cn_itransport.HeaderText = "Transport";
            this.cn_itransport.Name = "cn_itransport";
            this.cn_itransport.ReadOnly = true;
            this.cn_itransport.Width = 80;
            // 
            // cn_iincoterms
            // 
            this.cn_iincoterms.DataPropertyName = "incoterm";
            this.cn_iincoterms.FillWeight = 80F;
            this.cn_iincoterms.HeaderText = "Incoterm";
            this.cn_iincoterms.Name = "cn_iincoterms";
            this.cn_iincoterms.ReadOnly = true;
            this.cn_iincoterms.Width = 80;
            // 
            // frm_Intrastat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 603);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Intrastat";
            this.TabText = "Intrastat";
            this.Text = "Intrastat";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dn_Pages)).EndInit();
            this.dn_Pages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pg_Income)).EndInit();
            this.pg_Income.ResumeLayout(false);
            this.pg_Income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_IncomeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_IncomeList)).EndInit();
            this.bn_IncomeList.ResumeLayout(false);
            this.bn_IncomeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Outcome)).EndInit();
            this.pg_Outcome.ResumeLayout(false);
            this.pg_Outcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_OutcomeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_OutcomeList)).EndInit();
            this.bn_OutcomeList.ResumeLayout(false);
            this.bn_OutcomeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_IncomeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OutcomeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private CustomControls.NullableDateTimePicker txt_DateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private CustomControls.NullableDateTimePicker txt_DateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator dn_Pages;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Outcome;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Income;
        private System.Windows.Forms.BindingNavigator bn_OutcomeList;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btn_ExcelI;
        private System.Windows.Forms.BindingNavigator bn_IncomeList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton btn_Upload2A;
        private System.Windows.Forms.ToolStripButton btn_Upload1B;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_IncomeList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_OutcomeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_regdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_docdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_supart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_itype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ioperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_supid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coefconv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totalvat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totalwithvat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_state;
        private Global_Classes.SyncBindingSource bs_IncomeList;
        private Global_Classes.SyncBindingSource bs_OutcomeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isuctcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_iweightnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_iproducer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ibargain;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_itransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_iincoterms;
    }
}