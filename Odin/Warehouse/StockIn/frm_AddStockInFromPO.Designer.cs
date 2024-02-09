namespace Odin.Warehouse.StockIn
{
    partial class frm_AddStockInFromPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddStockInFromPO));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.chk_add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_place = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_suparticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_iunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oldqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coefconv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oldunitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_curid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custcodecmb = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cn_custcodeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_country = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cn_countryid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cn_resale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_internalcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_Clear = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Places1 = new Odin.CMB_Components.Places.cmb_Places();
            this.kryptonLabel25 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalVAT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel24 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalWVAT = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel23 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Total = new Owf.Controls.NumericTetxBox();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel27 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_StockInTypes1 = new Odin.CMB_Components.StockInTypes.cmb_StockInTypes();
            this.cmb_PurchaseOrders1 = new Odin.CMB_Components.PurchaseOrders.cmb_PurchaseOrders();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.btn_show = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
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
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel2);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1433, 636);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Purchase order details";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.basket_8134;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Details of purchase order";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_add,
            this.chk_place,
            this.cn_line,
            this.cn_artid,
            this.cn_article,
            this.cn_suparticle,
            this.cn_qty,
            this.cn_iunit,
            this.cn_oldqty,
            this.cn_unitprice,
            this.cn_vat,
            this.cn_coefconv,
            this.cn_oldunitprice,
            this.cn_currency,
            this.cn_comments,
            this.cn_id,
            this.cn_curid,
            this.cn_weight,
            this.cn_custcodecmb,
            this.cn_custcodeid,
            this.cn_unitid,
            this.cn_custcode,
            this.cn_country,
            this.cn_countryid,
            this.cn_resale,
            this.cn_internalcomments});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gv_List.Location = new System.Drawing.Point(0, 67);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.RowTemplate.Height = 26;
            this.gv_List.Size = new System.Drawing.Size(1431, 436);
            this.gv_List.TabIndex = 285;
            this.gv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellContentClick);
            this.gv_List.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellEnter);
            this.gv_List.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gv_List_CellPainting);
            this.gv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValidated);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            // 
            // chk_add
            // 
            this.chk_add.DataPropertyName = "add";
            this.chk_add.FalseValue = "0";
            this.chk_add.FillWeight = 40F;
            this.chk_add.HeaderText = "Add";
            this.chk_add.IndeterminateValue = "1";
            this.chk_add.Name = "chk_add";
            this.chk_add.TrueValue = "-1";
            this.chk_add.Width = 40;
            // 
            // chk_place
            // 
            this.chk_place.DataPropertyName = "place";
            this.chk_place.FalseValue = "0";
            this.chk_place.FillWeight = 40F;
            this.chk_place.HeaderText = "Place";
            this.chk_place.IndeterminateValue = "1";
            this.chk_place.Name = "chk_place";
            this.chk_place.TrueValue = "-1";
            this.chk_place.Width = 40;
            // 
            // cn_line
            // 
            this.cn_line.DataPropertyName = "line";
            this.cn_line.FillWeight = 40F;
            this.cn_line.HeaderText = "Line";
            this.cn_line.Name = "cn_line";
            this.cn_line.Width = 40;
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
            // cn_suparticle
            // 
            this.cn_suparticle.DataPropertyName = "suparticle";
            this.cn_suparticle.FillWeight = 250F;
            this.cn_suparticle.HeaderText = "Supplier\'s article";
            this.cn_suparticle.Name = "cn_suparticle";
            this.cn_suparticle.Width = 250;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 80F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 80;
            // 
            // cn_iunit
            // 
            this.cn_iunit.DataPropertyName = "unit";
            this.cn_iunit.FillWeight = 40F;
            this.cn_iunit.HeaderText = "Unit";
            this.cn_iunit.Name = "cn_iunit";
            this.cn_iunit.ReadOnly = true;
            this.cn_iunit.Width = 40;
            // 
            // cn_oldqty
            // 
            this.cn_oldqty.DataPropertyName = "oldqty";
            this.cn_oldqty.HeaderText = "oldqty";
            this.cn_oldqty.Name = "cn_oldqty";
            this.cn_oldqty.ReadOnly = true;
            this.cn_oldqty.Visible = false;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price";
            this.cn_unitprice.Name = "cn_unitprice";
            // 
            // cn_vat
            // 
            this.cn_vat.DataPropertyName = "vat";
            this.cn_vat.FillWeight = 40F;
            this.cn_vat.HeaderText = "VAT";
            this.cn_vat.Name = "cn_vat";
            this.cn_vat.Width = 40;
            // 
            // cn_coefconv
            // 
            this.cn_coefconv.DataPropertyName = "coefconv";
            this.cn_coefconv.HeaderText = "CoefConv";
            this.cn_coefconv.Name = "cn_coefconv";
            this.cn_coefconv.Visible = false;
            // 
            // cn_oldunitprice
            // 
            this.cn_oldunitprice.DataPropertyName = "oldunitprice";
            this.cn_oldunitprice.HeaderText = "oldunitprice";
            this.cn_oldunitprice.Name = "cn_oldunitprice";
            this.cn_oldunitprice.ReadOnly = true;
            this.cn_oldunitprice.Visible = false;
            // 
            // cn_currency
            // 
            this.cn_currency.DataPropertyName = "currency";
            this.cn_currency.FillWeight = 50F;
            this.cn_currency.HeaderText = "Currency";
            this.cn_currency.Name = "cn_currency";
            this.cn_currency.ReadOnly = true;
            this.cn_currency.Width = 50;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.Width = 150;
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.FillWeight = 5F;
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            this.cn_id.Width = 5;
            // 
            // cn_curid
            // 
            this.cn_curid.DataPropertyName = "curid";
            this.cn_curid.HeaderText = "curid";
            this.cn_curid.Name = "cn_curid";
            this.cn_curid.Visible = false;
            // 
            // cn_weight
            // 
            this.cn_weight.DataPropertyName = "weight";
            this.cn_weight.HeaderText = "Weight net";
            this.cn_weight.Name = "cn_weight";
            // 
            // cn_custcodecmb
            // 
            this.cn_custcodecmb.HeaderText = "Cust. code";
            this.cn_custcodecmb.Name = "cn_custcodecmb";
            this.cn_custcodecmb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_custcodecmb.Visible = false;
            // 
            // cn_custcodeid
            // 
            this.cn_custcodeid.DataPropertyName = "custcodeid";
            this.cn_custcodeid.HeaderText = "custcodeid";
            this.cn_custcodeid.Name = "cn_custcodeid";
            this.cn_custcodeid.Visible = false;
            // 
            // cn_unitid
            // 
            this.cn_unitid.DataPropertyName = "unitid";
            this.cn_unitid.HeaderText = "unitid";
            this.cn_unitid.Name = "cn_unitid";
            this.cn_unitid.Visible = false;
            // 
            // cn_custcode
            // 
            this.cn_custcode.DataPropertyName = "code";
            this.cn_custcode.FillWeight = 125F;
            this.cn_custcode.HeaderText = "Cust. code";
            this.cn_custcode.Name = "cn_custcode";
            this.cn_custcode.Width = 125;
            // 
            // cn_country
            // 
            this.cn_country.HeaderText = "Producer";
            this.cn_country.Name = "cn_country";
            // 
            // cn_countryid
            // 
            this.cn_countryid.HeaderText = "countryid";
            this.cn_countryid.Name = "cn_countryid";
            this.cn_countryid.Visible = false;
            // 
            // cn_resale
            // 
            this.cn_resale.DataPropertyName = "resale";
            this.cn_resale.HeaderText = "Resale";
            this.cn_resale.Name = "cn_resale";
            this.cn_resale.Visible = false;
            // 
            // cn_internalcomments
            // 
            this.cn_internalcomments.DataPropertyName = "internalcomments";
            this.cn_internalcomments.HeaderText = "Internal comments";
            this.cn_internalcomments.Name = "cn_internalcomments";
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
            this.btn_Clear,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 503);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(1431, 25);
            this.bn_List.TabIndex = 284;
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
            // btn_Clear
            // 
            this.btn_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(23, 22);
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
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
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.cmb_Places1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel25);
            this.kryptonPanel2.Controls.Add(this.txt_TotalVAT);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel24);
            this.kryptonPanel2.Controls.Add(this.txt_TotalWVAT);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel23);
            this.kryptonPanel2.Controls.Add(this.txt_Total);
            this.kryptonPanel2.Controls.Add(this.btn_OK);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 528);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(1431, 50);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(653, 17);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel2.TabIndex = 271;
            this.kryptonLabel2.Values.Text = "Place to:";
            // 
            // cmb_Places1
            // 
            this.cmb_Places1.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Places1.Department = "";
            this.cmb_Places1.IsQuarantine = 0;
            this.cmb_Places1.Location = new System.Drawing.Point(721, 17);
            this.cmb_Places1.Lock = 0;
            this.cmb_Places1.Name = "cmb_Places1";
            this.cmb_Places1.PlaceId = 0;
            this.cmb_Places1.SelectedNode = null;
            this.cmb_Places1.Size = new System.Drawing.Size(234, 20);
            this.cmb_Places1.TabIndex = 270;
            // 
            // kryptonLabel25
            // 
            this.kryptonLabel25.Location = new System.Drawing.Point(479, 17);
            this.kryptonLabel25.Name = "kryptonLabel25";
            this.kryptonLabel25.Size = new System.Drawing.Size(71, 20);
            this.kryptonLabel25.TabIndex = 269;
            this.kryptonLabel25.Values.Text = "Total+VAT:";
            // 
            // txt_TotalVAT
            // 
            this.txt_TotalVAT.AllowDecimalSeparator = true;
            this.txt_TotalVAT.AllowSpace = false;
            this.txt_TotalVAT.Location = new System.Drawing.Point(398, 17);
            this.txt_TotalVAT.Name = "txt_TotalVAT";
            this.txt_TotalVAT.Size = new System.Drawing.Size(77, 23);
            this.txt_TotalVAT.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_TotalVAT.TabIndex = 265;
            this.txt_TotalVAT.Text = "0";
            // 
            // kryptonLabel24
            // 
            this.kryptonLabel24.Location = new System.Drawing.Point(330, 17);
            this.kryptonLabel24.Name = "kryptonLabel24";
            this.kryptonLabel24.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel24.TabIndex = 268;
            this.kryptonLabel24.Values.Text = "Total Vat:";
            // 
            // txt_TotalWVAT
            // 
            this.txt_TotalWVAT.AllowDecimalSeparator = true;
            this.txt_TotalWVAT.AllowSpace = false;
            this.txt_TotalWVAT.Location = new System.Drawing.Point(567, 17);
            this.txt_TotalWVAT.Name = "txt_TotalWVAT";
            this.txt_TotalWVAT.Size = new System.Drawing.Size(80, 23);
            this.txt_TotalWVAT.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_TotalWVAT.TabIndex = 266;
            this.txt_TotalWVAT.Text = "0";
            // 
            // kryptonLabel23
            // 
            this.kryptonLabel23.Location = new System.Drawing.Point(174, 17);
            this.kryptonLabel23.Name = "kryptonLabel23";
            this.kryptonLabel23.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel23.TabIndex = 267;
            this.kryptonLabel23.Values.Text = "Total:";
            // 
            // txt_Total
            // 
            this.txt_Total.AllowDecimalSeparator = true;
            this.txt_Total.AllowSpace = false;
            this.txt_Total.Location = new System.Drawing.Point(241, 17);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(83, 23);
            this.txt_Total.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_Total.TabIndex = 264;
            this.txt_Total.Text = "0";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(1333, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OK.Size = new System.Drawing.Size(93, 40);
            this.btn_OK.TabIndex = 27;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel27);
            this.kryptonPanel1.Controls.Add(this.cmb_StockInTypes1);
            this.kryptonPanel1.Controls.Add(this.cmb_PurchaseOrders1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(1431, 67);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel27
            // 
            this.kryptonLabel27.Location = new System.Drawing.Point(12, 41);
            this.kryptonLabel27.Name = "kryptonLabel27";
            this.kryptonLabel27.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonLabel27.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel27.TabIndex = 277;
            this.kryptonLabel27.Values.Text = "Operation:";
            // 
            // cmb_StockInTypes1
            // 
            this.cmb_StockInTypes1.Lang = "ENG";
            this.cmb_StockInTypes1.Location = new System.Drawing.Point(113, 40);
            this.cmb_StockInTypes1.MovType = 1;
            this.cmb_StockInTypes1.Name = "cmb_StockInTypes1";
            this.cmb_StockInTypes1.Size = new System.Drawing.Size(175, 20);
            this.cmb_StockInTypes1.StockMovType = "";
            this.cmb_StockInTypes1.StockMovTypeId = 0;
            this.cmb_StockInTypes1.StockMovTypeLat = "";
            this.cmb_StockInTypes1.TabIndex = 276;
            // 
            // cmb_PurchaseOrders1
            // 
            this.cmb_PurchaseOrders1.ContactPersonId = 0;
            this.cmb_PurchaseOrders1.Contract = "";
            this.cmb_PurchaseOrders1.EnableSearchId = false;
            this.cmb_PurchaseOrders1.Location = new System.Drawing.Point(113, 14);
            this.cmb_PurchaseOrders1.Name = "cmb_PurchaseOrders1";
            this.cmb_PurchaseOrders1.PurchaseOrder = "";
            this.cmb_PurchaseOrders1.PurchaseOrderId = 0;
            this.cmb_PurchaseOrders1.PurchaseOrderSavedId = 0;
            this.cmb_PurchaseOrders1.Size = new System.Drawing.Size(175, 20);
            this.cmb_PurchaseOrders1.Supplier = null;
            this.cmb_PurchaseOrders1.SupplierId = 0;
            this.cmb_PurchaseOrders1.TabIndex = 4;
            this.cmb_PurchaseOrders1.PurchaseOrderChanged += new Odin.CMB_Components.PurchaseOrders.PurchaseOrdersEventHandler(this.cmb_PurchaseOrders1_PurchaseOrderChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 14);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(95, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Purchase order:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "artid";
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Art. id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Article";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "suparticle";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier\'s article";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn4.FillWeight = 80F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "unit";
            this.dataGridViewTextBoxColumn5.FillWeight = 40F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "oldqty";
            this.dataGridViewTextBoxColumn6.HeaderText = "oldqty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "unitprice";
            this.dataGridViewTextBoxColumn7.HeaderText = "Unit price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "vat";
            this.dataGridViewTextBoxColumn8.FillWeight = 40F;
            this.dataGridViewTextBoxColumn8.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "coefconv";
            this.dataGridViewTextBoxColumn9.HeaderText = "CoefConv";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "oldunitprice";
            this.dataGridViewTextBoxColumn10.HeaderText = "oldunitprice";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "comments";
            this.dataGridViewTextBoxColumn11.FillWeight = 170F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 170;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn12.FillWeight = 5F;
            this.dataGridViewTextBoxColumn12.HeaderText = "id";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 5;
            // 
            // btn_show
            // 
            this.btn_show.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown;
            this.btn_show.UniqueName = "427C6CB300594EE4FE9314232D9AE88C";
            // 
            // frm_AddStockInFromPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 636);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddStockInFromPO";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add stock-in from PO";
            this.Load += new System.EventHandler(this.frm_AddStockInFromPO_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel25;
        private Owf.Controls.NumericTetxBox txt_TotalVAT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private Owf.Controls.NumericTetxBox txt_TotalWVAT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel23;
        private Owf.Controls.NumericTetxBox txt_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
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
        private System.Windows.Forms.ToolStripButton btn_Clear;
        private System.Windows.Forms.ToolStripButton btn_Excel;
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Places.cmb_Places cmb_Places1;
        private CMB_Components.PurchaseOrders.cmb_PurchaseOrders cmb_PurchaseOrders1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_show;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel27;
        private CMB_Components.StockInTypes.cmb_StockInTypes cmb_StockInTypes1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_add;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_suparticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_iunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oldqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coefconv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oldunitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_curid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_weight;
        private System.Windows.Forms.DataGridViewComboBoxColumn cn_custcodecmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custcodeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custcode;
        private System.Windows.Forms.DataGridViewComboBoxColumn cn_country;
        private System.Windows.Forms.DataGridViewComboBoxColumn cn_countryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_resale;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_internalcomments;
    }
}