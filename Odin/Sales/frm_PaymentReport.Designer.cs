namespace Odin.Sales
{
    partial class frm_PaymentReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PaymentReport));
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
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Quotations1 = new Odin.CMB_Components.Quotations.cmb_Quotations();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_SalesOrders1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrders();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms2 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.txt_CreatDateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_CreatDateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dn_Pages = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.pg_Payments = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_buyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_buyerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_regdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_vatperc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_amountwithvat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_amounteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_amountwithvateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_paiddet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_doctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_quotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currencyinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_spentadvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_detid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mapped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_curid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_relink = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.pg_Orders = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_Orders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_obuyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_obuyerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oquotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oconfordsum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oquotsum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oprofinvoices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_opaidbyinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ototalpaidbyproforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_invoicespaidbyproforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ototalpaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_olefttopay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_leftinadvace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oquotid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Orders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_oFilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_oSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_oFilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_oFilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_oRemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_oCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_oAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_Orders = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_oExcel = new System.Windows.Forms.ToolStripButton();
            this.btn_relink2 = new System.Windows.Forms.ToolStripButton();
            this.pg_Invoices = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.khg_Dets = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_PayDetails = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dprofinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_invoiceamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dinvcurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dpayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dpaymentsum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_paymentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_paidbyproforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_payheadid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_PayDetails = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_relink1 = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_ByProforma = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalByProforma = new Owf.Controls.NumericTetxBox();
            this.lbl_TotalVat = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalWithVat = new Owf.Controls.NumericTetxBox();
            this.lbl_Vat = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalVat = new Owf.Controls.NumericTetxBox();
            this.lbl_Total = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Total = new Owf.Controls.NumericTetxBox();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.bs_Orders = new Odin.Global_Classes.SyncBindingSource();
            this.bs_PayDetails = new Odin.Global_Classes.SyncBindingSource();
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
            ((System.ComponentModel.ISupportInitialize)(this.dn_Pages)).BeginInit();
            this.dn_Pages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Payments)).BeginInit();
            this.pg_Payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Orders)).BeginInit();
            this.pg_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Orders)).BeginInit();
            this.mnu_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Orders)).BeginInit();
            this.bn_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Invoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khg_Dets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khg_Dets.Panel)).BeginInit();
            this.khg_Dets.Panel.SuspendLayout();
            this.khg_Dets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PayDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_PayDetails)).BeginInit();
            this.bn_PayDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_PayDetails)).BeginInit();
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
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.khg_Dets);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonPanel2);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1210, 728);
            this.kryptonSplitContainer1.SplitterDistance = 457;
            this.kryptonSplitContainer1.TabIndex = 18;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Quotations1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_SalesOrders1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel9);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CreatDateTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CreatDateFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel11);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.dn_Pages);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1210, 457);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(6, 100);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel1.TabIndex = 258;
            this.kryptonLabel1.Values.Text = "Quotation:";
            // 
            // cmb_Quotations1
            // 
            this.cmb_Quotations1.ClientId = 0;
            this.cmb_Quotations1.EnableSearchId = false;
            this.cmb_Quotations1.Location = new System.Drawing.Point(91, 100);
            this.cmb_Quotations1.Name = "cmb_Quotations1";
            this.cmb_Quotations1.Quotation = "";
            this.cmb_Quotations1.QuotationId = 0;
            this.cmb_Quotations1.QuotationSavedId = 0;
            this.cmb_Quotations1.Size = new System.Drawing.Size(203, 20);
            this.cmb_Quotations1.TabIndex = 257;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(6, 74);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel2.TabIndex = 256;
            this.kryptonLabel2.Values.Text = "Conf. order:";
            // 
            // cmb_SalesOrders1
            // 
            this.cmb_SalesOrders1.ClientId = 0;
            this.cmb_SalesOrders1.ContactPersonId = 0;
            this.cmb_SalesOrders1.Contract = "";
            this.cmb_SalesOrders1.EnableSearchId = false;
            this.cmb_SalesOrders1.Internal = 0;
            this.cmb_SalesOrders1.Location = new System.Drawing.Point(91, 74);
            this.cmb_SalesOrders1.Name = "cmb_SalesOrders1";
            this.cmb_SalesOrders1.SalesOrder = "";
            this.cmb_SalesOrders1.SalesOrderId = 0;
            this.cmb_SalesOrders1.SalesOrderSavedId = 0;
            this.cmb_SalesOrders1.Size = new System.Drawing.Size(203, 20);
            this.cmb_SalesOrders1.TabIndex = 255;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(6, 48);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel9.TabIndex = 254;
            this.kryptonLabel9.Values.Text = "Buyer:";
            // 
            // cmb_Firms2
            // 
            this.cmb_Firms2.CountryId = 0;
            this.cmb_Firms2.CountryVAT = 0D;
            this.cmb_Firms2.CurId = 0;
            this.cmb_Firms2.CustIncotermsId = 0;
            this.cmb_Firms2.CustPaymentId = 0;
            this.cmb_Firms2.EnableSearchId = false;
            this.cmb_Firms2.Firm = "";
            this.cmb_Firms2.FirmId = 0;
            this.cmb_Firms2.IsEmptyColor = false;
            this.cmb_Firms2.Location = new System.Drawing.Point(91, 48);
            this.cmb_Firms2.Name = "cmb_Firms2";
            this.cmb_Firms2.Size = new System.Drawing.Size(203, 20);
            this.cmb_Firms2.SupComments = null;
            this.cmb_Firms2.SupIncotermsId = 0;
            this.cmb_Firms2.TabIndex = 253;
            this.cmb_Firms2.VATNr = null;
            // 
            // txt_CreatDateTill
            // 
            this.txt_CreatDateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_CreatDateTill.CalendarShowWeekNumbers = true;
            this.txt_CreatDateTill.CustomFormat = null;
            this.txt_CreatDateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CreatDateTill.Location = new System.Drawing.Point(188, 150);
            this.txt_CreatDateTill.Name = "txt_CreatDateTill";
            this.txt_CreatDateTill.NullValue = " ";
            this.txt_CreatDateTill.Size = new System.Drawing.Size(105, 21);
            this.txt_CreatDateTill.TabIndex = 216;
            this.txt_CreatDateTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_CreatDateTill_DropDown);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny4.UniqueName = "6A2751F9284C45EEA28C814570A892DD";
            // 
            // txt_CreatDateFrom
            // 
            this.txt_CreatDateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_CreatDateFrom.CalendarShowWeekNumbers = true;
            this.txt_CreatDateFrom.CustomFormat = null;
            this.txt_CreatDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CreatDateFrom.Location = new System.Drawing.Point(52, 150);
            this.txt_CreatDateFrom.Name = "txt_CreatDateFrom";
            this.txt_CreatDateFrom.NullValue = " ";
            this.txt_CreatDateFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_CreatDateFrom.TabIndex = 213;
            this.txt_CreatDateFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_CreatDateFrom_DropDown);
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny5.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(159, 150);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel11.TabIndex = 23;
            this.kryptonLabel11.Values.Text = "till:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(5, 151);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(5, 130);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(118, 20);
            this.kryptonLabel7.TabIndex = 16;
            this.kryptonLabel7.Values.Text = "Registration period:";
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
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
            this.btn_Refresh.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.UniqueName = "3502D2542D5C42F0078623FF0A695273";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dn_Pages
            // 
            this.dn_Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dn_Pages.Location = new System.Drawing.Point(0, 0);
            this.dn_Pages.Name = "dn_Pages";
            this.dn_Pages.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pg_Payments,
            this.pg_Orders,
            this.pg_Invoices});
            this.dn_Pages.SelectedIndex = 0;
            this.dn_Pages.Size = new System.Drawing.Size(906, 457);
            this.dn_Pages.TabIndex = 2;
            this.dn_Pages.Text = "kryptonDockableNavigator1";
            this.dn_Pages.Click += new System.EventHandler(this.dn_Pages_Click);
            // 
            // pg_Payments
            // 
            this.pg_Payments.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Payments.Controls.Add(this.gv_List);
            this.pg_Payments.Controls.Add(this.bn_List);
            this.pg_Payments.Flags = 65534;
            this.pg_Payments.LastVisibleSet = true;
            this.pg_Payments.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Payments.Name = "pg_Payments";
            this.pg_Payments.Size = new System.Drawing.Size(904, 430);
            this.pg_Payments.Text = "Payments";
            this.pg_Payments.ToolTipTitle = "Page ToolTip";
            this.pg_Payments.UniqueName = "2B6928D3721E42AF228A7C438C886EBE";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.ColumnHeadersHeight = 40;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_buyer,
            this.cn_buyerid,
            this.cn_regdate,
            this.cn_payment,
            this.cn_amount,
            this.cn_vatperc,
            this.cn_VAT,
            this.cn_amountwithvat,
            this.cn_currency,
            this.cn_amounteur,
            this.cn_amountwithvateur,
            this.cn_paiddet,
            this.cn_invoice,
            this.cn_doctype,
            this.cn_conforder,
            this.cn_quotation,
            this.cn_currencyinco,
            this.cn_spentadvance,
            this.cn_comments,
            this.cn_who,
            this.cn_when,
            this.cn_id,
            this.cn_detid,
            this.cn_article,
            this.cn_mapped,
            this.cn_curid,
            this.cn_currate});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 10;
            this.gv_List.Size = new System.Drawing.Size(904, 405);
            this.gv_List.TabIndex = 262;
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            // 
            // cn_buyer
            // 
            this.cn_buyer.DataPropertyName = "buyer";
            this.cn_buyer.HeaderText = "Buyer";
            this.cn_buyer.Name = "cn_buyer";
            // 
            // cn_buyerid
            // 
            this.cn_buyerid.DataPropertyName = "buyerid";
            this.cn_buyerid.HeaderText = "buyerid";
            this.cn_buyerid.Name = "cn_buyerid";
            this.cn_buyerid.Visible = false;
            // 
            // cn_regdate
            // 
            this.cn_regdate.DataPropertyName = "regdate";
            this.cn_regdate.HeaderText = "Reg. date";
            this.cn_regdate.Name = "cn_regdate";
            // 
            // cn_payment
            // 
            this.cn_payment.DataPropertyName = "payment";
            this.cn_payment.HeaderText = "Payment";
            this.cn_payment.Name = "cn_payment";
            // 
            // cn_amount
            // 
            this.cn_amount.DataPropertyName = "amount";
            this.cn_amount.FillWeight = 80F;
            this.cn_amount.HeaderText = "Amount";
            this.cn_amount.Name = "cn_amount";
            this.cn_amount.Width = 80;
            // 
            // cn_vatperc
            // 
            this.cn_vatperc.DataPropertyName = "vatperc";
            this.cn_vatperc.FillWeight = 40F;
            this.cn_vatperc.HeaderText = "VAT (%)";
            this.cn_vatperc.Name = "cn_vatperc";
            this.cn_vatperc.Width = 40;
            // 
            // cn_VAT
            // 
            this.cn_VAT.DataPropertyName = "vat";
            this.cn_VAT.FillWeight = 70F;
            this.cn_VAT.HeaderText = "VAT";
            this.cn_VAT.Name = "cn_VAT";
            this.cn_VAT.Width = 70;
            // 
            // cn_amountwithvat
            // 
            this.cn_amountwithvat.DataPropertyName = "amountwovat";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_amountwithvat.DefaultCellStyle = dataGridViewCellStyle2;
            this.cn_amountwithvat.FillWeight = 80F;
            this.cn_amountwithvat.HeaderText = "Amount\r\n - VAT";
            this.cn_amountwithvat.Name = "cn_amountwithvat";
            this.cn_amountwithvat.Width = 80;
            // 
            // cn_currency
            // 
            this.cn_currency.DataPropertyName = "currency";
            this.cn_currency.FillWeight = 50F;
            this.cn_currency.HeaderText = "Curr.";
            this.cn_currency.Name = "cn_currency";
            this.cn_currency.Width = 50;
            // 
            // cn_amounteur
            // 
            this.cn_amounteur.DataPropertyName = "amounteur";
            this.cn_amounteur.FillWeight = 80F;
            this.cn_amounteur.HeaderText = "Amount (€)";
            this.cn_amounteur.Name = "cn_amounteur";
            this.cn_amounteur.Width = 80;
            // 
            // cn_amountwithvateur
            // 
            this.cn_amountwithvateur.DataPropertyName = "amountwovateur";
            this.cn_amountwithvateur.FillWeight = 80F;
            this.cn_amountwithvateur.HeaderText = "Amount\r\n - VAT (€)";
            this.cn_amountwithvateur.Name = "cn_amountwithvateur";
            this.cn_amountwithvateur.Width = 80;
            // 
            // cn_paiddet
            // 
            this.cn_paiddet.DataPropertyName = "paiddet";
            this.cn_paiddet.FillWeight = 80F;
            this.cn_paiddet.HeaderText = "Pay for\r\n invoice";
            this.cn_paiddet.Name = "cn_paiddet";
            this.cn_paiddet.Width = 80;
            // 
            // cn_invoice
            // 
            this.cn_invoice.DataPropertyName = "invoice";
            this.cn_invoice.HeaderText = "Proforma/Invoice";
            this.cn_invoice.Name = "cn_invoice";
            // 
            // cn_doctype
            // 
            this.cn_doctype.DataPropertyName = "doctype";
            this.cn_doctype.HeaderText = "Doc. type";
            this.cn_doctype.Name = "cn_doctype";
            // 
            // cn_conforder
            // 
            this.cn_conforder.DataPropertyName = "conforder";
            this.cn_conforder.FillWeight = 120F;
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            this.cn_conforder.Width = 120;
            // 
            // cn_quotation
            // 
            this.cn_quotation.DataPropertyName = "quotation";
            this.cn_quotation.FillWeight = 120F;
            this.cn_quotation.HeaderText = "Quotation";
            this.cn_quotation.Name = "cn_quotation";
            this.cn_quotation.Width = 120;
            // 
            // cn_currencyinco
            // 
            this.cn_currencyinco.DataPropertyName = "currencyinco";
            this.cn_currencyinco.HeaderText = "Curr.\r\n in CO";
            this.cn_currencyinco.Name = "cn_currencyinco";
            // 
            // cn_spentadvance
            // 
            this.cn_spentadvance.DataPropertyName = "spentadvance";
            this.cn_spentadvance.FillWeight = 80F;
            this.cn_spentadvance.HeaderText = "Spent\r\n advance";
            this.cn_spentadvance.Name = "cn_spentadvance";
            this.cn_spentadvance.Width = 80;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            // 
            // cn_who
            // 
            this.cn_who.DataPropertyName = "who";
            this.cn_who.HeaderText = "Who";
            this.cn_who.Name = "cn_who";
            // 
            // cn_when
            // 
            this.cn_when.DataPropertyName = "when";
            this.cn_when.HeaderText = "When";
            this.cn_when.Name = "cn_when";
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            // 
            // cn_detid
            // 
            this.cn_detid.DataPropertyName = "detid";
            this.cn_detid.HeaderText = "detid";
            this.cn_detid.Name = "cn_detid";
            this.cn_detid.Visible = false;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            // 
            // cn_mapped
            // 
            this.cn_mapped.DataPropertyName = "mapped";
            this.cn_mapped.HeaderText = "Mapped";
            this.cn_mapped.Name = "cn_mapped";
            // 
            // cn_curid
            // 
            this.cn_curid.DataPropertyName = "curid";
            this.cn_curid.HeaderText = "curid";
            this.cn_curid.Name = "cn_curid";
            this.cn_curid.Visible = false;
            // 
            // cn_currate
            // 
            this.cn_currate.DataPropertyName = "currate";
            this.cn_currate.HeaderText = "currate";
            this.cn_currate.Name = "cn_currate";
            this.cn_currate.Visible = false;
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
            this.btn_relink,
            this.btn_Delete,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 405);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(904, 25);
            this.bn_List.TabIndex = 261;
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
            // btn_relink
            // 
            this.btn_relink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_relink.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.btn_relink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_relink.Name = "btn_relink";
            this.btn_relink.Size = new System.Drawing.Size(23, 22);
            this.btn_relink.Text = "Re-link payments";
            this.btn_relink.Visible = false;
            this.btn_relink.Click += new System.EventHandler(this.btn_relink_Click);
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
            // pg_Orders
            // 
            this.pg_Orders.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Orders.Controls.Add(this.gv_Orders);
            this.pg_Orders.Controls.Add(this.bn_Orders);
            this.pg_Orders.Flags = 65534;
            this.pg_Orders.LastVisibleSet = true;
            this.pg_Orders.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Orders.Name = "pg_Orders";
            this.pg_Orders.Size = new System.Drawing.Size(904, 430);
            this.pg_Orders.Text = "Conf. orders / Quotations";
            this.pg_Orders.ToolTipTitle = "Page ToolTip";
            this.pg_Orders.UniqueName = "6CD7BEEC261A4922DB98348ADE8A2A66";
            // 
            // gv_Orders
            // 
            this.gv_Orders.AllowUserToAddRows = false;
            this.gv_Orders.AllowUserToDeleteRows = false;
            this.gv_Orders.ColumnHeadersHeight = 40;
            this.gv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_obuyer,
            this.cn_obuyerid,
            this.cn_ocorder,
            this.cn_oquotation,
            this.cn_oconfordsum,
            this.cn_oquotsum,
            this.cn_ocurrency,
            this.cn_oprofinvoices,
            this.cn_opaidbyinvoice,
            this.cn_ototalpaidbyproforma,
            this.cn_invoicespaidbyproforma,
            this.cn_ototalpaid,
            this.cn_olefttopay,
            this.cn_leftinadvace,
            this.cn_oid,
            this.cn_oquotid});
            this.gv_Orders.ContextMenuStrip = this.mnu_Orders;
            this.gv_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Orders.Location = new System.Drawing.Point(0, 0);
            this.gv_Orders.Name = "gv_Orders";
            this.gv_Orders.RowHeadersWidth = 10;
            this.gv_Orders.Size = new System.Drawing.Size(904, 405);
            this.gv_Orders.TabIndex = 263;
            this.gv_Orders.SelectionChanged += new System.EventHandler(this.gv_Orders_SelectionChanged);
            // 
            // cn_obuyer
            // 
            this.cn_obuyer.DataPropertyName = "buyer";
            this.cn_obuyer.FillWeight = 150F;
            this.cn_obuyer.HeaderText = "Buyer";
            this.cn_obuyer.Name = "cn_obuyer";
            this.cn_obuyer.Width = 150;
            // 
            // cn_obuyerid
            // 
            this.cn_obuyerid.DataPropertyName = "buyerid";
            this.cn_obuyerid.HeaderText = "buyerid";
            this.cn_obuyerid.Name = "cn_obuyerid";
            this.cn_obuyerid.Visible = false;
            // 
            // cn_ocorder
            // 
            this.cn_ocorder.DataPropertyName = "conforder";
            this.cn_ocorder.FillWeight = 120F;
            this.cn_ocorder.HeaderText = "Conf. order";
            this.cn_ocorder.Name = "cn_ocorder";
            this.cn_ocorder.Width = 120;
            // 
            // cn_oquotation
            // 
            this.cn_oquotation.DataPropertyName = "quotation";
            this.cn_oquotation.FillWeight = 120F;
            this.cn_oquotation.HeaderText = "Quotation";
            this.cn_oquotation.Name = "cn_oquotation";
            this.cn_oquotation.Width = 120;
            // 
            // cn_oconfordsum
            // 
            this.cn_oconfordsum.DataPropertyName = "confordsum";
            this.cn_oconfordsum.FillWeight = 80F;
            this.cn_oconfordsum.HeaderText = "Order sum";
            this.cn_oconfordsum.Name = "cn_oconfordsum";
            this.cn_oconfordsum.Width = 80;
            // 
            // cn_oquotsum
            // 
            this.cn_oquotsum.DataPropertyName = "quotsum";
            this.cn_oquotsum.FillWeight = 80F;
            this.cn_oquotsum.HeaderText = "Quot. sum";
            this.cn_oquotsum.Name = "cn_oquotsum";
            this.cn_oquotsum.Width = 80;
            // 
            // cn_ocurrency
            // 
            this.cn_ocurrency.DataPropertyName = "currency";
            this.cn_ocurrency.FillWeight = 50F;
            this.cn_ocurrency.HeaderText = "Curr.";
            this.cn_ocurrency.Name = "cn_ocurrency";
            this.cn_ocurrency.Width = 50;
            // 
            // cn_oprofinvoices
            // 
            this.cn_oprofinvoices.DataPropertyName = "profinvoices";
            this.cn_oprofinvoices.FillWeight = 200F;
            this.cn_oprofinvoices.HeaderText = "Invoices/proformas";
            this.cn_oprofinvoices.Name = "cn_oprofinvoices";
            this.cn_oprofinvoices.Width = 200;
            // 
            // cn_opaidbyinvoice
            // 
            this.cn_opaidbyinvoice.DataPropertyName = "paidbyinvoice";
            this.cn_opaidbyinvoice.FillWeight = 80F;
            this.cn_opaidbyinvoice.HeaderText = "Paid by \r\ninvoice";
            this.cn_opaidbyinvoice.Name = "cn_opaidbyinvoice";
            this.cn_opaidbyinvoice.Width = 80;
            // 
            // cn_ototalpaidbyproforma
            // 
            this.cn_ototalpaidbyproforma.DataPropertyName = "totalpaidbyproforma";
            this.cn_ototalpaidbyproforma.HeaderText = "Total paid \r\nby proformas";
            this.cn_ototalpaidbyproforma.Name = "cn_ototalpaidbyproforma";
            // 
            // cn_invoicespaidbyproforma
            // 
            this.cn_invoicespaidbyproforma.DataPropertyName = "invoicespaidbyproforma";
            this.cn_invoicespaidbyproforma.HeaderText = "Invoices paid \r\nby proformas";
            this.cn_invoicespaidbyproforma.Name = "cn_invoicespaidbyproforma";
            // 
            // cn_ototalpaid
            // 
            this.cn_ototalpaid.DataPropertyName = "totalpaid";
            this.cn_ototalpaid.FillWeight = 80F;
            this.cn_ototalpaid.HeaderText = "Total paid";
            this.cn_ototalpaid.Name = "cn_ototalpaid";
            this.cn_ototalpaid.Width = 80;
            // 
            // cn_olefttopay
            // 
            this.cn_olefttopay.DataPropertyName = "lefttopay";
            this.cn_olefttopay.HeaderText = "Left to pay";
            this.cn_olefttopay.Name = "cn_olefttopay";
            // 
            // cn_leftinadvace
            // 
            this.cn_leftinadvace.DataPropertyName = "leftinadvance";
            this.cn_leftinadvace.HeaderText = "Left in advance";
            this.cn_leftinadvace.Name = "cn_leftinadvace";
            // 
            // cn_oid
            // 
            this.cn_oid.DataPropertyName = "id";
            this.cn_oid.HeaderText = "id";
            this.cn_oid.Name = "cn_oid";
            this.cn_oid.Visible = false;
            // 
            // cn_oquotid
            // 
            this.cn_oquotid.DataPropertyName = "quotid";
            this.cn_oquotid.HeaderText = "quotid";
            this.cn_oquotid.Name = "cn_oquotid";
            this.cn_oquotid.Visible = false;
            // 
            // mnu_Orders
            // 
            this.mnu_Orders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Orders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_oFilterFor,
            this.mni_oSearch,
            this.mni_oFilterBy,
            this.mni_oFilterExcludingSel,
            this.mni_oRemoveFilter,
            this.mni_oCopy,
            this.toolStripSeparator5,
            this.mni_oAdmin});
            this.mnu_Orders.Name = "mnu_Requests";
            this.mnu_Orders.Size = new System.Drawing.Size(211, 167);
            this.mnu_Orders.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_Orders_Opening);
            // 
            // mni_oFilterFor
            // 
            this.mni_oFilterFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_oFilterFor.Name = "mni_oFilterFor";
            this.mni_oFilterFor.Size = new System.Drawing.Size(150, 23);
            this.mni_oFilterFor.TextChanged += new System.EventHandler(this.mni_oFilterFor_TextChanged);
            // 
            // mni_oSearch
            // 
            this.mni_oSearch.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_oSearch.Name = "mni_oSearch";
            this.mni_oSearch.Size = new System.Drawing.Size(210, 22);
            this.mni_oSearch.Text = "Search for record";
            this.mni_oSearch.Click += new System.EventHandler(this.mni_oSearch_Click);
            // 
            // mni_oFilterBy
            // 
            this.mni_oFilterBy.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_oFilterBy.Name = "mni_oFilterBy";
            this.mni_oFilterBy.Size = new System.Drawing.Size(210, 22);
            this.mni_oFilterBy.Text = "Filter by selection";
            this.mni_oFilterBy.Click += new System.EventHandler(this.mni_oFilterBy_Click);
            // 
            // mni_oFilterExcludingSel
            // 
            this.mni_oFilterExcludingSel.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_oFilterExcludingSel.Name = "mni_oFilterExcludingSel";
            this.mni_oFilterExcludingSel.Size = new System.Drawing.Size(210, 22);
            this.mni_oFilterExcludingSel.Text = "Filter excluding selection";
            this.mni_oFilterExcludingSel.Click += new System.EventHandler(this.mni_oFilterExcludingSel_Click);
            // 
            // mni_oRemoveFilter
            // 
            this.mni_oRemoveFilter.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_oRemoveFilter.Name = "mni_oRemoveFilter";
            this.mni_oRemoveFilter.Size = new System.Drawing.Size(210, 22);
            this.mni_oRemoveFilter.Text = "Remove filter";
            this.mni_oRemoveFilter.Click += new System.EventHandler(this.mni_oRemoveFilter_Click);
            // 
            // mni_oCopy
            // 
            this.mni_oCopy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_oCopy.Name = "mni_oCopy";
            this.mni_oCopy.Size = new System.Drawing.Size(210, 22);
            this.mni_oCopy.Text = "Copy";
            this.mni_oCopy.Click += new System.EventHandler(this.mni_oCopy_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_oAdmin
            // 
            this.mni_oAdmin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_oAdmin.Name = "mni_oAdmin";
            this.mni_oAdmin.Size = new System.Drawing.Size(210, 22);
            this.mni_oAdmin.Text = "List settings";
            this.mni_oAdmin.Click += new System.EventHandler(this.mni_oAdmin_Click);
            // 
            // bn_Orders
            // 
            this.bn_Orders.AddNewItem = null;
            this.bn_Orders.CountItem = this.toolStripLabel1;
            this.bn_Orders.DeleteItem = null;
            this.bn_Orders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Orders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Orders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.btn_oExcel,
            this.btn_relink2});
            this.bn_Orders.Location = new System.Drawing.Point(0, 405);
            this.bn_Orders.MoveFirstItem = this.toolStripButton1;
            this.bn_Orders.MoveLastItem = this.toolStripButton4;
            this.bn_Orders.MoveNextItem = this.toolStripButton3;
            this.bn_Orders.MovePreviousItem = this.toolStripButton2;
            this.bn_Orders.Name = "bn_Orders";
            this.bn_Orders.PositionItem = this.toolStripTextBox1;
            this.bn_Orders.Size = new System.Drawing.Size(904, 25);
            this.bn_Orders.TabIndex = 262;
            this.bn_Orders.Text = "Orders";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_oExcel
            // 
            this.btn_oExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_oExcel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_oExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_oExcel.Name = "btn_oExcel";
            this.btn_oExcel.Size = new System.Drawing.Size(23, 22);
            this.btn_oExcel.Text = "Export into excel";
            // 
            // btn_relink2
            // 
            this.btn_relink2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_relink2.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.btn_relink2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_relink2.Name = "btn_relink2";
            this.btn_relink2.Size = new System.Drawing.Size(23, 22);
            this.btn_relink2.Text = "Relink payments";
            this.btn_relink2.Click += new System.EventHandler(this.btn_relink2_Click);
            // 
            // pg_Invoices
            // 
            this.pg_Invoices.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Invoices.Flags = 65534;
            this.pg_Invoices.LastVisibleSet = true;
            this.pg_Invoices.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Invoices.Name = "pg_Invoices";
            this.pg_Invoices.Size = new System.Drawing.Size(904, 430);
            this.pg_Invoices.Text = "Invoices/Proformas";
            this.pg_Invoices.ToolTipTitle = "Page ToolTip";
            this.pg_Invoices.UniqueName = "82383F5B9C934E4993AA0ED940F7D87B";
            this.pg_Invoices.Visible = false;
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.AutoScroll = true;
            this.kryptonDockableWorkspace1.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(1124, 41);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "3603EBC349EA4AA52F8724469FC85DA3";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(86, 225);
            this.kryptonDockableWorkspace1.TabIndex = 10;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // khg_Dets
            // 
            this.khg_Dets.Dock = System.Windows.Forms.DockStyle.Left;
            this.khg_Dets.Location = new System.Drawing.Point(0, 41);
            this.khg_Dets.Name = "khg_Dets";
            // 
            // khg_Dets.Panel
            // 
            this.khg_Dets.Panel.Controls.Add(this.gv_PayDetails);
            this.khg_Dets.Panel.Controls.Add(this.bn_PayDetails);
            this.khg_Dets.Size = new System.Drawing.Size(1124, 225);
            this.khg_Dets.TabIndex = 9;
            this.khg_Dets.ValuesPrimary.Heading = "Payment details";
            this.khg_Dets.ValuesPrimary.Image = global::Odin.Global_Resourses.Money;
            this.khg_Dets.Visible = false;
            // 
            // gv_PayDetails
            // 
            this.gv_PayDetails.AllowUserToAddRows = false;
            this.gv_PayDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_PayDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cn_dprofinvoice,
            this.cn_invoiceamount,
            this.cn_dinvcurrency,
            this.cn_dpayment,
            this.cn_dpaymentsum,
            this.cn_currpay,
            this.cn_paymentdate,
            this.cn_paidbyproforma,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.cn_payheadid});
            this.gv_PayDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_PayDetails.Location = new System.Drawing.Point(0, 25);
            this.gv_PayDetails.Name = "gv_PayDetails";
            this.gv_PayDetails.RowHeadersWidth = 25;
            this.gv_PayDetails.Size = new System.Drawing.Size(1122, 142);
            this.gv_PayDetails.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 5F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // cn_dprofinvoice
            // 
            this.cn_dprofinvoice.DataPropertyName = "name";
            this.cn_dprofinvoice.HeaderText = "Proforma/invoice";
            this.cn_dprofinvoice.Name = "cn_dprofinvoice";
            // 
            // cn_invoiceamount
            // 
            this.cn_invoiceamount.DataPropertyName = "invoiceamount";
            this.cn_invoiceamount.HeaderText = "Invoice amount";
            this.cn_invoiceamount.Name = "cn_invoiceamount";
            // 
            // cn_dinvcurrency
            // 
            this.cn_dinvcurrency.DataPropertyName = "currency";
            this.cn_dinvcurrency.FillWeight = 60F;
            this.cn_dinvcurrency.HeaderText = "Curr. in inv.";
            this.cn_dinvcurrency.Name = "cn_dinvcurrency";
            this.cn_dinvcurrency.Width = 60;
            // 
            // cn_dpayment
            // 
            this.cn_dpayment.DataPropertyName = "payment";
            this.cn_dpayment.HeaderText = "Payment";
            this.cn_dpayment.Name = "cn_dpayment";
            // 
            // cn_dpaymentsum
            // 
            this.cn_dpaymentsum.DataPropertyName = "paidamount";
            this.cn_dpaymentsum.FillWeight = 80F;
            this.cn_dpaymentsum.HeaderText = "Paid amount";
            this.cn_dpaymentsum.Name = "cn_dpaymentsum";
            this.cn_dpaymentsum.Width = 80;
            // 
            // cn_currpay
            // 
            this.cn_currpay.DataPropertyName = "currpay";
            this.cn_currpay.FillWeight = 60F;
            this.cn_currpay.HeaderText = "Currency in payment";
            this.cn_currpay.Name = "cn_currpay";
            this.cn_currpay.Width = 60;
            // 
            // cn_paymentdate
            // 
            this.cn_paymentdate.DataPropertyName = "paymentdate";
            this.cn_paymentdate.HeaderText = "Payment date";
            this.cn_paymentdate.Name = "cn_paymentdate";
            // 
            // cn_paidbyproforma
            // 
            this.cn_paidbyproforma.DataPropertyName = "paidbyproforma";
            this.cn_paidbyproforma.FillWeight = 80F;
            this.cn_paidbyproforma.HeaderText = "Paid by proforma";
            this.cn_paidbyproforma.Name = "cn_paidbyproforma";
            this.cn_paidbyproforma.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "when";
            this.dataGridViewTextBoxColumn2.HeaderText = "Creat. at";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "who";
            this.dataGridViewTextBoxColumn3.HeaderText = "Creat. by";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cn_payheadid
            // 
            this.cn_payheadid.DataPropertyName = "payheadid";
            this.cn_payheadid.HeaderText = "payheadid";
            this.cn_payheadid.Name = "cn_payheadid";
            this.cn_payheadid.Visible = false;
            // 
            // bn_PayDetails
            // 
            this.bn_PayDetails.AddNewItem = null;
            this.bn_PayDetails.CountItem = this.toolStripLabel2;
            this.bn_PayDetails.DeleteItem = null;
            this.bn_PayDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_PayDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator6,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator7,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator8,
            this.btn_relink1});
            this.bn_PayDetails.Location = new System.Drawing.Point(0, 0);
            this.bn_PayDetails.MoveFirstItem = this.toolStripButton5;
            this.bn_PayDetails.MoveLastItem = this.toolStripButton8;
            this.bn_PayDetails.MoveNextItem = this.toolStripButton7;
            this.bn_PayDetails.MovePreviousItem = this.toolStripButton6;
            this.bn_PayDetails.Name = "bn_PayDetails";
            this.bn_PayDetails.PositionItem = this.toolStripTextBox2;
            this.bn_PayDetails.Size = new System.Drawing.Size(1122, 25);
            this.bn_PayDetails.TabIndex = 2;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move first";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move previous";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move next";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move last";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_relink1
            // 
            this.btn_relink1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_relink1.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.btn_relink1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_relink1.Name = "btn_relink1";
            this.btn_relink1.Size = new System.Drawing.Size(23, 22);
            this.btn_relink1.Text = "Relink payment";
            this.btn_relink1.Visible = false;
            this.btn_relink1.Click += new System.EventHandler(this.btn_relink1_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lbl_ByProforma);
            this.kryptonPanel2.Controls.Add(this.txt_TotalByProforma);
            this.kryptonPanel2.Controls.Add(this.lbl_TotalVat);
            this.kryptonPanel2.Controls.Add(this.txt_TotalWithVat);
            this.kryptonPanel2.Controls.Add(this.lbl_Vat);
            this.kryptonPanel2.Controls.Add(this.txt_TotalVat);
            this.kryptonPanel2.Controls.Add(this.lbl_Total);
            this.kryptonPanel2.Controls.Add(this.txt_Total);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.kryptonPanel2.Size = new System.Drawing.Size(1210, 41);
            this.kryptonPanel2.TabIndex = 6;
            this.kryptonPanel2.Visible = false;
            // 
            // lbl_ByProforma
            // 
            this.lbl_ByProforma.Location = new System.Drawing.Point(784, 11);
            this.lbl_ByProforma.Name = "lbl_ByProforma";
            this.lbl_ByProforma.Size = new System.Drawing.Size(141, 20);
            this.lbl_ByProforma.TabIndex = 25;
            this.lbl_ByProforma.Values.Text = "Paid by proforma (EUR):";
            // 
            // txt_TotalByProforma
            // 
            this.txt_TotalByProforma.AllowDecimalSeparator = true;
            this.txt_TotalByProforma.AllowSpace = false;
            this.txt_TotalByProforma.Location = new System.Drawing.Point(931, 11);
            this.txt_TotalByProforma.Name = "txt_TotalByProforma";
            this.txt_TotalByProforma.Size = new System.Drawing.Size(91, 23);
            this.txt_TotalByProforma.TabIndex = 24;
            this.txt_TotalByProforma.Text = "0";
            this.txt_TotalByProforma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_TotalVat
            // 
            this.lbl_TotalVat.Location = new System.Drawing.Point(567, 11);
            this.lbl_TotalVat.Name = "lbl_TotalVat";
            this.lbl_TotalVat.Size = new System.Drawing.Size(111, 20);
            this.lbl_TotalVat.TabIndex = 23;
            this.lbl_TotalVat.Values.Text = "Total + VAT (EUR):";
            // 
            // txt_TotalWithVat
            // 
            this.txt_TotalWithVat.AllowDecimalSeparator = true;
            this.txt_TotalWithVat.AllowSpace = false;
            this.txt_TotalWithVat.Location = new System.Drawing.Point(686, 11);
            this.txt_TotalWithVat.Name = "txt_TotalWithVat";
            this.txt_TotalWithVat.Size = new System.Drawing.Size(91, 23);
            this.txt_TotalWithVat.TabIndex = 22;
            this.txt_TotalWithVat.Text = "0";
            this.txt_TotalWithVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Vat
            // 
            this.lbl_Vat.Location = new System.Drawing.Point(398, 11);
            this.lbl_Vat.Name = "lbl_Vat";
            this.lbl_Vat.Size = new System.Drawing.Size(61, 20);
            this.lbl_Vat.TabIndex = 21;
            this.lbl_Vat.Values.Text = "Vat(EUR):";
            // 
            // txt_TotalVat
            // 
            this.txt_TotalVat.AllowDecimalSeparator = true;
            this.txt_TotalVat.AllowSpace = false;
            this.txt_TotalVat.Location = new System.Drawing.Point(482, 11);
            this.txt_TotalVat.Name = "txt_TotalVat";
            this.txt_TotalVat.Size = new System.Drawing.Size(63, 23);
            this.txt_TotalVat.TabIndex = 20;
            this.txt_TotalVat.Text = "0";
            this.txt_TotalVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Location = new System.Drawing.Point(146, 11);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(151, 20);
            this.lbl_Total.TabIndex = 19;
            this.lbl_Total.Values.Text = "Total for document (EUR):";
            // 
            // txt_Total
            // 
            this.txt_Total.AllowDecimalSeparator = true;
            this.txt_Total.AllowSpace = false;
            this.txt_Total.Location = new System.Drawing.Point(303, 11);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(75, 23);
            this.txt_Total.TabIndex = 0;
            this.txt_Total.Text = "0";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            this.kryptonDockingManager1.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager1_DockspaceAdding);
            // 
            // frm_PaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 728);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_PaymentReport";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Payment report";
            this.Text = "Payment report";
            this.Load += new System.EventHandler(this.frm_PaymentReport_Load);
            this.Resize += new System.EventHandler(this.frm_PaymentReport_Resize);
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dn_Pages)).EndInit();
            this.dn_Pages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pg_Payments)).EndInit();
            this.pg_Payments.ResumeLayout(false);
            this.pg_Payments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Orders)).EndInit();
            this.pg_Orders.ResumeLayout(false);
            this.pg_Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Orders)).EndInit();
            this.mnu_Orders.ResumeLayout(false);
            this.mnu_Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Orders)).EndInit();
            this.bn_Orders.ResumeLayout(false);
            this.bn_Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Invoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khg_Dets.Panel)).EndInit();
            this.khg_Dets.Panel.ResumeLayout(false);
            this.khg_Dets.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khg_Dets)).EndInit();
            this.khg_Dets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_PayDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_PayDetails)).EndInit();
            this.bn_PayDetails.ResumeLayout(false);
            this.bn_PayDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_PayDetails)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

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
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private CMB_Components.Companies.cmb_Firms cmb_Firms2;
        private CustomControls.NullableDateTimePicker txt_CreatDateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private CustomControls.NullableDateTimePicker txt_CreatDateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ByProforma;
        private Owf.Controls.NumericTetxBox txt_TotalByProforma;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_TotalVat;
        private Owf.Controls.NumericTetxBox txt_TotalWithVat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Vat;
        private Owf.Controls.NumericTetxBox txt_TotalVat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Total;
        private Owf.Controls.NumericTetxBox txt_Total;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.SalesOrders.cmb_SalesOrders cmb_SalesOrders1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Quotations.cmb_Quotations cmb_Quotations1;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup khg_Dets;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator dn_Pages;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Payments;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Invoices;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Orders;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
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
        private System.Windows.Forms.ToolStripButton btn_Excel;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Orders;
        private System.Windows.Forms.BindingNavigator bn_Orders;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_oExcel;
        private Global_Classes.SyncBindingSource bs_Orders;
        private System.Windows.Forms.ContextMenuStrip mnu_Orders;
        private System.Windows.Forms.ToolStripMenuItem mni_oSearch;
        private System.Windows.Forms.ToolStripMenuItem mni_oFilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_oFilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_oRemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_oCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mni_oAdmin;
        private System.Windows.Forms.ToolStripTextBox mni_oFilterFor;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_PayDetails;
        private System.Windows.Forms.BindingNavigator bn_PayDetails;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private Global_Classes.SyncBindingSource bs_PayDetails;
        private System.Windows.Forms.ToolStripButton btn_relink;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_buyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_buyerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_regdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_vatperc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_amountwithvat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_amounteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_amountwithvateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_paiddet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_doctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_quotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currencyinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_spentadvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_who;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_detid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mapped;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_curid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currate;
        private System.Windows.Forms.ToolStripButton btn_relink1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dprofinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_invoiceamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dinvcurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dpayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dpaymentsum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_paymentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_paidbyproforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_payheadid;
        private System.Windows.Forms.ToolStripButton btn_relink2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_obuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_obuyerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oquotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oconfordsum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oquotsum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oprofinvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_opaidbyinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ototalpaidbyproforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_invoicespaidbyproforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ototalpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_olefttopay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_leftinadvace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oquotid;
    }
}