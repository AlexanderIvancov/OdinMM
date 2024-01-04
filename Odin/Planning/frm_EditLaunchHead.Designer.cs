namespace Odin.Planning
{
    partial class frm_EditLaunchHead
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditLaunchHead));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Qty = new Owf.Controls.NumericTetxBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batchdetid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bomnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_analog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oldqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyinbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totallaunched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_onstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_notplaced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtypo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_porder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_confdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_inbom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_theorstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_Unit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_Decimals = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Round = new System.Windows.Forms.ToolStripButton();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_EndDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_ProdStartDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_StartDate = new Odin.CustomControls.NullableDateTimePicker();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.txt_Qty);
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.txt_Comments);
            this.kryptonPanel1.Controls.Add(this.txt_EndDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel1.Controls.Add(this.txt_ProdStartDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel1.Controls.Add(this.txt_StartDate);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(718, 533);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(230, 15);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel4.TabIndex = 303;
            this.kryptonLabel4.Values.Text = "Qty in launch:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.AllowDecimalSeparator = true;
            this.txt_Qty.AllowSpace = false;
            this.txt_Qty.Location = new System.Drawing.Point(351, 16);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(88, 21);
            this.txt_Qty.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Qty.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Qty.TabIndex = 302;
            this.txt_Qty.Text = "0";
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            this.txt_Qty.Validated += new System.EventHandler(this.txt_Qty_Validated);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gv_List);
            this.panel1.Controls.Add(this.bn_List);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 378);
            this.panel1.TabIndex = 301;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeight = 25;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_batchdetid,
            this.cn_bomnum,
            this.cn_stage,
            this.cn_artid,
            this.cn_article,
            this.cn_analog,
            this.cn_unit,
            this.cn_qty,
            this.cn_oldqty,
            this.cn_qtyinbatch,
            this.cn_totallaunched,
            this.cn_onstock,
            this.cn_reserved,
            this.cn_notplaced,
            this.cn_qtypo,
            this.cn_porder,
            this.cn_confdate,
            this.cn_inbom,
            this.cn_available,
            this.cn_theorstock});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 25);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(718, 353);
            this.gv_List.TabIndex = 46;
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            // 
            // cn_batchdetid
            // 
            this.cn_batchdetid.DataPropertyName = "batchdetid";
            this.cn_batchdetid.HeaderText = "bdid";
            this.cn_batchdetid.Name = "cn_batchdetid";
            this.cn_batchdetid.Visible = false;
            // 
            // cn_bomnum
            // 
            this.cn_bomnum.DataPropertyName = "bomnum";
            this.cn_bomnum.FillWeight = 40F;
            this.cn_bomnum.HeaderText = "BOM №";
            this.cn_bomnum.Name = "cn_bomnum";
            this.cn_bomnum.Width = 40;
            // 
            // cn_stage
            // 
            this.cn_stage.DataPropertyName = "stage";
            this.cn_stage.FillWeight = 70F;
            this.cn_stage.HeaderText = "Stage";
            this.cn_stage.Name = "cn_stage";
            this.cn_stage.Width = 70;
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
            this.cn_article.FillWeight = 150F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Width = 150;
            // 
            // cn_analog
            // 
            this.cn_analog.DataPropertyName = "analogs";
            this.cn_analog.HeaderText = "Analogs";
            this.cn_analog.Name = "cn_analog";
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
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 70F;
            this.cn_qty.HeaderText = "Qty in launch";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 85;
            // 
            // cn_oldqty
            // 
            this.cn_oldqty.DataPropertyName = "oldqty";
            this.cn_oldqty.HeaderText = "old qty";
            this.cn_oldqty.Name = "cn_oldqty";
            this.cn_oldqty.ReadOnly = true;
            this.cn_oldqty.Visible = false;
            // 
            // cn_qtyinbatch
            // 
            this.cn_qtyinbatch.DataPropertyName = "qtyinbatch";
            this.cn_qtyinbatch.HeaderText = "Qty in batch";
            this.cn_qtyinbatch.Name = "cn_qtyinbatch";
            // 
            // cn_totallaunched
            // 
            this.cn_totallaunched.DataPropertyName = "launched";
            this.cn_totallaunched.HeaderText = "Total launched";
            this.cn_totallaunched.Name = "cn_totallaunched";
            this.cn_totallaunched.Visible = false;
            // 
            // cn_onstock
            // 
            this.cn_onstock.DataPropertyName = "qtystock";
            this.cn_onstock.FillWeight = 70F;
            this.cn_onstock.HeaderText = "On stock";
            this.cn_onstock.Name = "cn_onstock";
            this.cn_onstock.ReadOnly = true;
            this.cn_onstock.Width = 70;
            // 
            // cn_reserved
            // 
            this.cn_reserved.DataPropertyName = "reserved";
            this.cn_reserved.FillWeight = 70F;
            this.cn_reserved.HeaderText = "Reserved";
            this.cn_reserved.Name = "cn_reserved";
            this.cn_reserved.ReadOnly = true;
            this.cn_reserved.Width = 70;
            // 
            // cn_notplaced
            // 
            this.cn_notplaced.DataPropertyName = "notplaced";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.cn_notplaced.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_notplaced.FillWeight = 70F;
            this.cn_notplaced.HeaderText = "Not placed";
            this.cn_notplaced.Name = "cn_notplaced";
            this.cn_notplaced.Width = 70;
            // 
            // cn_qtypo
            // 
            this.cn_qtypo.DataPropertyName = "purchased";
            this.cn_qtypo.FillWeight = 70F;
            this.cn_qtypo.HeaderText = "Purchased";
            this.cn_qtypo.Name = "cn_qtypo";
            this.cn_qtypo.Width = 70;
            // 
            // cn_porder
            // 
            this.cn_porder.DataPropertyName = "porder";
            this.cn_porder.HeaderText = "Pur. order";
            this.cn_porder.Name = "cn_porder";
            // 
            // cn_confdate
            // 
            this.cn_confdate.DataPropertyName = "confdate";
            this.cn_confdate.HeaderText = "Conf. deliv. date";
            this.cn_confdate.Name = "cn_confdate";
            // 
            // cn_inbom
            // 
            this.cn_inbom.DataPropertyName = "qtybom";
            this.cn_inbom.FillWeight = 70F;
            this.cn_inbom.HeaderText = "In BOM.";
            this.cn_inbom.Name = "cn_inbom";
            this.cn_inbom.ReadOnly = true;
            this.cn_inbom.Width = 70;
            // 
            // cn_available
            // 
            this.cn_available.DataPropertyName = "qtyavailable";
            this.cn_available.HeaderText = "Available";
            this.cn_available.Name = "cn_available";
            this.cn_available.Visible = false;
            // 
            // cn_theorstock
            // 
            this.cn_theorstock.DataPropertyName = "theorstock";
            this.cn_theorstock.HeaderText = "Theor. stock";
            this.cn_theorstock.Name = "cn_theorstock";
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
            this.bn_List.CountItem = null;
            this.bn_List.DeleteItem = null;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_DeleteLine,
            this.toolStripLabel1,
            this.cmb_Unit,
            this.toolStripLabel2,
            this.cmb_Decimals,
            this.btn_Round});
            this.bn_List.Location = new System.Drawing.Point(0, 0);
            this.bn_List.MoveFirstItem = null;
            this.bn_List.MoveLastItem = null;
            this.bn_List.MoveNextItem = null;
            this.bn_List.MovePreviousItem = null;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = null;
            this.bn_List.Size = new System.Drawing.Size(718, 25);
            this.bn_List.TabIndex = 45;
            this.bn_List.Text = "Bill of materials";
            // 
            // btn_Add
            // 
            this.btn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Add.Image = global::Odin.Global_Resourses.bindingNavigatorAddNewItem_Image;
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(23, 22);
            this.btn_Add.Text = "Add RM line";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_DeleteLine
            // 
            this.btn_DeleteLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteLine.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteLine.Image")));
            this.btn_DeleteLine.Name = "btn_DeleteLine";
            this.btn_DeleteLine.RightToLeftAutoMirrorImage = true;
            this.btn_DeleteLine.Size = new System.Drawing.Size(23, 22);
            this.btn_DeleteLine.Text = "Delete";
            this.btn_DeleteLine.Click += new System.EventHandler(this.btn_DeleteLine_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Round";
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(18, 22);
            this.toolStripLabel2.Text = "to";
            // 
            // cmb_Decimals
            // 
            this.cmb_Decimals.Name = "cmb_Decimals";
            this.cmb_Decimals.Size = new System.Drawing.Size(75, 25);
            // 
            // btn_Round
            // 
            this.btn_Round.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Round.Image = global::Odin.Global_Resourses.Ok;
            this.btn_Round.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Round.Name = "btn_Round";
            this.btn_Round.Size = new System.Drawing.Size(23, 22);
            this.btn_Round.Text = "Round selected units";
            this.btn_Round.Click += new System.EventHandler(this.btn_Round_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(11, 68);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel7.TabIndex = 300;
            this.kryptonLabel7.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_Comments.Location = new System.Drawing.Point(90, 69);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(350, 80);
            this.txt_Comments.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Comments.TabIndex = 299;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "D5B6C03750554195328E4B264796E65F";
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.CalendarShowWeekNumbers = true;
            this.txt_EndDate.CustomFormat = null;
            this.txt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndDate.Location = new System.Drawing.Point(351, 42);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.NullValue = " ";
            this.txt_EndDate.Size = new System.Drawing.Size(89, 21);
            this.txt_EndDate.TabIndex = 298;
            this.txt_EndDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_EndDate_DropDown);
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(230, 42);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(116, 20);
            this.kryptonLabel12.TabIndex = 297;
            this.kryptonLabel12.Values.Text = "Production ends at:";
            // 
            // txt_ProdStartDate
            // 
            this.txt_ProdStartDate.CalendarShowWeekNumbers = true;
            this.txt_ProdStartDate.CustomFormat = null;
            this.txt_ProdStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ProdStartDate.Location = new System.Drawing.Point(133, 41);
            this.txt_ProdStartDate.Name = "txt_ProdStartDate";
            this.txt_ProdStartDate.NullValue = " ";
            this.txt_ProdStartDate.Size = new System.Drawing.Size(89, 21);
            this.txt_ProdStartDate.TabIndex = 296;
            this.txt_ProdStartDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_ProdStartDate_DropDown);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(10, 42);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(120, 20);
            this.kryptonLabel6.TabIndex = 295;
            this.kryptonLabel6.Values.Text = "Production starts at:";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(10, 16);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(94, 20);
            this.kryptonLabel14.TabIndex = 294;
            this.kryptonLabel14.Values.Text = "RM movement:";
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.CalendarShowWeekNumbers = true;
            this.txt_StartDate.CustomFormat = null;
            this.txt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartDate.Location = new System.Drawing.Point(133, 15);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.NullValue = " ";
            this.txt_StartDate.Size = new System.Drawing.Size(88, 21);
            this.txt_StartDate.TabIndex = 293;
            this.txt_StartDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartDate_DropDown);
            this.txt_StartDate.Validated += new System.EventHandler(this.txt_StartDate_Validated);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(616, 15);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 27;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(616, 55);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 26;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_EditLaunchHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 533);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditLaunchHead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit launch header";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_EditLaunchHead_FormClosing);
            this.Load += new System.EventHandler(this.frm_EditLaunchHead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        public CustomControls.NullableDateTimePicker txt_StartDate;
        public CustomControls.NullableDateTimePicker txt_ProdStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        public CustomControls.NullableDateTimePicker txt_EndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripButton btn_DeleteLine;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmb_Unit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmb_Decimals;
        private System.Windows.Forms.ToolStripButton btn_Round;
        private Global_Classes.SyncBindingSource bs_List;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batchdetid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bomnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_analog;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oldqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyinbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totallaunched;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_onstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_notplaced;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtypo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_porder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_confdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inbom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_theorstock;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Owf.Controls.NumericTetxBox txt_Qty;
    }
}