namespace Odin.Warehouse.Requests
{
    partial class frm_EnabledRequests
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

        public Odin.Warehouse.StockOut.frm_StockOut frmStockOut;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EnabledRequests));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.chk_SelectAll = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.btn_OK = new System.Windows.Forms.ToolStripButton();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_Print = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_urgent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtystock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reqdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_statedesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_catid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_creatby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_cause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_serials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.chk_SelectAll);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(785, 486);
            this.kryptonHeaderGroup1.TabIndex = 18;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Enabled requests list";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.Favorites_24x24;
            // 
            // chk_SelectAll
            // 
            this.chk_SelectAll.Location = new System.Drawing.Point(355, 218);
            this.chk_SelectAll.Name = "chk_SelectAll";
            this.chk_SelectAll.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.chk_SelectAll.Size = new System.Drawing.Size(72, 20);
            this.chk_SelectAll.TabIndex = 229;
            this.chk_SelectAll.Values.Text = "Select all";
            this.chk_SelectAll.CheckedChanged += new System.EventHandler(this.chk_SelectAll_CheckedChanged);
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.chk_Print,
            this.cn_headid,
            this.cn_name,
            this.cn_artid,
            this.cn_article,
            this.chk_urgent,
            this.cn_qty,
            this.cn_diff,
            this.cn_qtystock,
            this.cn_unit,
            this.cn_batch,
            this.cn_description,
            this.cn_reqdate,
            this.cn_comments,
            this.cn_statedesc,
            this.cn_type,
            this.cn_department,
            this.cn_catid,
            this.cn_createdat,
            this.cn_creatby,
            this.cn_custarticle,
            this.cn_cause,
            this.cn_place,
            this.cn_serials});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gv_List.Location = new System.Drawing.Point(0, 25);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(783, 432);
            this.gv_List.TabIndex = 5;
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
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
            this.btn_OK,
            this.btn_Print});
            this.bn_List.Location = new System.Drawing.Point(0, 0);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(783, 25);
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
            // btn_OK
            // 
            this.btn_OK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_OK.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(23, 22);
            this.btn_OK.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Print.Image = global::Odin.Global_Resourses.Printer;
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(23, 22);
            this.btn_Print.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click_1);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            // 
            // chk_Print
            // 
            this.chk_Print.DataPropertyName = "toprint";
            this.chk_Print.FalseValue = "0";
            this.chk_Print.FillWeight = 40F;
            this.chk_Print.HeaderText = "Print";
            this.chk_Print.IndeterminateValue = "1";
            this.chk_Print.Name = "chk_Print";
            this.chk_Print.TrueValue = "-1";
            this.chk_Print.Width = 40;
            // 
            // cn_headid
            // 
            this.cn_headid.DataPropertyName = "headid";
            this.cn_headid.HeaderText = "headid";
            this.cn_headid.Name = "cn_headid";
            this.cn_headid.Visible = false;
            // 
            // cn_name
            // 
            this.cn_name.DataPropertyName = "name";
            this.cn_name.HeaderText = "Request";
            this.cn_name.Name = "cn_name";
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 70F;
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.Width = 70;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 200F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.Width = 200;
            // 
            // chk_urgent
            // 
            this.chk_urgent.DataPropertyName = "urgent";
            this.chk_urgent.FillWeight = 40F;
            this.chk_urgent.HeaderText = "Urgent";
            this.chk_urgent.Name = "chk_urgent";
            this.chk_urgent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk_urgent.Width = 40;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 70F;
            this.cn_qty.HeaderText = "Quantity";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 70;
            // 
            // cn_diff
            // 
            this.cn_diff.DataPropertyName = "diff";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cn_diff.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_diff.FillWeight = 70F;
            this.cn_diff.HeaderText = "Left to give";
            this.cn_diff.Name = "cn_diff";
            this.cn_diff.Width = 70;
            // 
            // cn_qtystock
            // 
            this.cn_qtystock.DataPropertyName = "qtystock";
            this.cn_qtystock.FillWeight = 70F;
            this.cn_qtystock.HeaderText = "Qty stock";
            this.cn_qtystock.Name = "cn_qtystock";
            this.cn_qtystock.Width = 70;
            // 
            // cn_unit
            // 
            this.cn_unit.DataPropertyName = "unit";
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.Width = 40;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.FillWeight = 90F;
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.Width = 90;
            // 
            // cn_description
            // 
            this.cn_description.DataPropertyName = "description";
            this.cn_description.FillWeight = 150F;
            this.cn_description.HeaderText = "Description";
            this.cn_description.Name = "cn_description";
            this.cn_description.Width = 150;
            // 
            // cn_reqdate
            // 
            this.cn_reqdate.DataPropertyName = "reqdate";
            this.cn_reqdate.HeaderText = "Req. date";
            this.cn_reqdate.Name = "cn_reqdate";
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.Width = 150;
            // 
            // cn_statedesc
            // 
            this.cn_statedesc.DataPropertyName = "statedesc";
            this.cn_statedesc.HeaderText = "State";
            this.cn_statedesc.Name = "cn_statedesc";
            // 
            // cn_type
            // 
            this.cn_type.DataPropertyName = "type";
            this.cn_type.HeaderText = "Type";
            this.cn_type.Name = "cn_type";
            // 
            // cn_department
            // 
            this.cn_department.DataPropertyName = "department";
            this.cn_department.HeaderText = "Department";
            this.cn_department.Name = "cn_department";
            // 
            // cn_catid
            // 
            this.cn_catid.DataPropertyName = "catid";
            this.cn_catid.HeaderText = "catid";
            this.cn_catid.Name = "cn_catid";
            this.cn_catid.Visible = false;
            // 
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "operat";
            this.cn_createdat.FillWeight = 50F;
            this.cn_createdat.HeaderText = "Created at";
            this.cn_createdat.Name = "cn_createdat";
            this.cn_createdat.Width = 50;
            // 
            // cn_creatby
            // 
            this.cn_creatby.DataPropertyName = "operby";
            this.cn_creatby.HeaderText = "Created by";
            this.cn_creatby.Name = "cn_creatby";
            // 
            // cn_custarticle
            // 
            this.cn_custarticle.DataPropertyName = "custarticle";
            this.cn_custarticle.HeaderText = "For product";
            this.cn_custarticle.Name = "cn_custarticle";
            // 
            // cn_cause
            // 
            this.cn_cause.DataPropertyName = "cause";
            this.cn_cause.HeaderText = "Cause";
            this.cn_cause.Name = "cn_cause";
            // 
            // cn_place
            // 
            this.cn_place.DataPropertyName = "place";
            this.cn_place.HeaderText = "Place";
            this.cn_place.Name = "cn_place";
            // 
            // cn_serials
            // 
            this.cn_serials.DataPropertyName = "serials";
            this.cn_serials.HeaderText = "Serials";
            this.cn_serials.Name = "cn_serials";
            // 
            // frm_EnabledRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 486);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EnabledRequests";
            this.Text = "Enabled requests";
            this.Load += new System.EventHandler(this.frm_EnabledRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
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
        private System.Windows.Forms.ToolStripButton btn_OK;
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
        private System.Windows.Forms.ToolStripButton btn_Print;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_SelectAll;
        private Global_Classes.SyncBindingSource bs_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_urgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_diff;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtystock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reqdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_statedesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_catid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_creatby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cause;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_serials;
    }
}