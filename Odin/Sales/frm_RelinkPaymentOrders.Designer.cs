namespace Odin.Sales
{
    partial class frm_RelinkPaymentOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RelinkPaymentOrders));
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.ds_Orders = new System.Data.DataSet();
            this.dt_Orders = new System.Data.DataTable();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.ds_List = new System.Data.DataSet();
            this.dt_List = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Rest = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_PayDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalInPayment = new Owf.Controls.NumericTetxBox();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Total = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalMapped = new Owf.Controls.NumericTetxBox();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Orders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_oartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oquot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_topay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oquotid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oinvoiceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ooldamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Orders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_oFilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_oSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_oFilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_oFilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_oRemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_oCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_oAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_Orders = new Odin.Global_Classes.SyncBindingSource();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rb_All = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Invoice = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Proforma = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.bn_Orders = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_RemoveAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Wizard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Remove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_quot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_invoiceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oldamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Orders)).BeginInit();
            this.mnu_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Orders)).BeginInit();
            this.bn_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
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
            this.toolStripSeparator7,
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_Admin
            // 
            this.mni_Admin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_Admin.Name = "mni_Admin";
            this.mni_Admin.Size = new System.Drawing.Size(210, 22);
            this.mni_Admin.Text = "List settings";
            this.mni_Admin.Click += new System.EventHandler(this.mni_Admin_Click);
            // 
            // ds_Orders
            // 
            this.ds_Orders.DataSetName = "ds_Orders";
            this.ds_Orders.Tables.AddRange(new System.Data.DataTable[] {
            this.dt_Orders});
            // 
            // dt_Orders
            // 
            this.dt_Orders.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn25});
            this.dt_Orders.TableName = "dt_Orders";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "invoice";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "conforder";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "quota";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "id";
            this.dataColumn15.DataType = typeof(int);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "amount";
            this.dataColumn16.DataType = typeof(double);
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "currency";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "artid";
            this.dataColumn18.DataType = typeof(int);
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "article";
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "coid";
            this.dataColumn20.DataType = typeof(int);
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "quotid";
            this.dataColumn21.DataType = typeof(int);
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "invoiceid";
            this.dataColumn22.DataType = typeof(int);
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "topay";
            this.dataColumn23.DataType = typeof(double);
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "oldamount";
            this.dataColumn25.DataType = typeof(double);
            // 
            // ds_List
            // 
            this.ds_List.DataSetName = "ds_List";
            this.ds_List.Tables.AddRange(new System.Data.DataTable[] {
            this.dt_List});
            // 
            // dt_List
            // 
            this.dt_List.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn24});
            this.dt_List.TableName = "dt_List";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "invoice";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "conforder";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "quota";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "id";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "amount";
            this.dataColumn5.DataType = typeof(double);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "currency";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "artid";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "article";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "coid";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "quotid";
            this.dataColumn10.DataType = typeof(int);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "invoiceid";
            this.dataColumn11.DataType = typeof(int);
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "oldamount";
            this.dataColumn24.DataType = typeof(double);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.txt_Rest);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel1.Controls.Add(this.txt_PayDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txt_TotalInPayment);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.lbl_Total);
            this.kryptonPanel1.Controls.Add(this.txt_TotalMapped);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 492);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCustom2;
            this.kryptonPanel1.Size = new System.Drawing.Size(1404, 58);
            this.kryptonPanel1.TabIndex = 13;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(1054, 20);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel2.TabIndex = 298;
            this.kryptonLabel2.Values.Text = "Rest:";
            // 
            // txt_Rest
            // 
            this.txt_Rest.AllowDecimalSeparator = true;
            this.txt_Rest.AllowSpace = false;
            this.txt_Rest.Enabled = false;
            this.txt_Rest.Location = new System.Drawing.Point(1109, 20);
            this.txt_Rest.Name = "txt_Rest";
            this.txt_Rest.Size = new System.Drawing.Size(94, 21);
            this.txt_Rest.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txt_Rest.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Rest.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Rest.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Rest.StateDisabled.Content.Color1 = System.Drawing.Color.Green;
            this.txt_Rest.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Rest.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Rest.TabIndex = 297;
            this.txt_Rest.Text = "0";
            this.txt_Rest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(458, 20);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel14.TabIndex = 296;
            this.kryptonLabel14.Values.Text = "Payment date:";
            // 
            // txt_PayDate
            // 
            this.txt_PayDate.CalendarShowWeekNumbers = true;
            this.txt_PayDate.CustomFormat = null;
            this.txt_PayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_PayDate.Location = new System.Drawing.Point(554, 20);
            this.txt_PayDate.Name = "txt_PayDate";
            this.txt_PayDate.NullValue = " ";
            this.txt_PayDate.Size = new System.Drawing.Size(88, 21);
            this.txt_PayDate.TabIndex = 295;
            this.txt_PayDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_PayDate_DropDown);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(662, 21);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(105, 20);
            this.kryptonLabel1.TabIndex = 32;
            this.kryptonLabel1.Values.Text = "Total in payment:";
            // 
            // txt_TotalInPayment
            // 
            this.txt_TotalInPayment.AllowDecimalSeparator = true;
            this.txt_TotalInPayment.AllowSpace = false;
            this.txt_TotalInPayment.Enabled = false;
            this.txt_TotalInPayment.Location = new System.Drawing.Point(773, 21);
            this.txt_TotalInPayment.Name = "txt_TotalInPayment";
            this.txt_TotalInPayment.Size = new System.Drawing.Size(83, 21);
            this.txt_TotalInPayment.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.txt_TotalInPayment.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalInPayment.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_TotalInPayment.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_TotalInPayment.StateDisabled.Content.Color1 = System.Drawing.Color.Red;
            this.txt_TotalInPayment.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalInPayment.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_TotalInPayment.TabIndex = 31;
            this.txt_TotalInPayment.Text = "0";
            this.txt_TotalInPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_TotalInPayment.TextChanged += new System.EventHandler(this.txt_TotalInPayment_TextChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(1211, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 38);
            this.btn_OK.TabIndex = 30;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.Location = new System.Drawing.Point(859, 21);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(89, 20);
            this.lbl_Total.TabIndex = 29;
            this.lbl_Total.Values.Text = "Total mapped:";
            // 
            // txt_TotalMapped
            // 
            this.txt_TotalMapped.AllowDecimalSeparator = true;
            this.txt_TotalMapped.AllowSpace = false;
            this.txt_TotalMapped.Enabled = false;
            this.txt_TotalMapped.Location = new System.Drawing.Point(954, 21);
            this.txt_TotalMapped.Name = "txt_TotalMapped";
            this.txt_TotalMapped.Size = new System.Drawing.Size(94, 21);
            this.txt_TotalMapped.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_TotalMapped.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalMapped.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_TotalMapped.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_TotalMapped.StateDisabled.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_TotalMapped.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalMapped.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_TotalMapped.TabIndex = 28;
            this.txt_TotalMapped.Text = "0";
            this.txt_TotalMapped.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cancel.Location = new System.Drawing.Point(1304, 10);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 38);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(682, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            this.kryptonHeaderGroup2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.gv_Orders);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonPanel3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.bn_Orders);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(722, 492);
            this.kryptonHeaderGroup2.TabIndex = 15;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Proformas / invoices";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.invoice32x32;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "List of menu items";
            // 
            // gv_Orders
            // 
            this.gv_Orders.AllowUserToAddRows = false;
            this.gv_Orders.AutoGenerateColumns = false;
            this.gv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_oartid,
            this.cn_oarticle,
            this.cn_oinvoice,
            this.cn_oconforder,
            this.cn_oquot,
            this.cn_oid,
            this.cn_oamount,
            this.cn_topay,
            this.cn_ocurrency,
            this.cn_ocoid,
            this.cn_oquotid,
            this.cn_oinvoiceid,
            this.cn_ooldamount});
            this.gv_Orders.ContextMenuStrip = this.mnu_Orders;
            this.gv_Orders.DataSource = this.bs_Orders;
            this.gv_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Orders.Location = new System.Drawing.Point(0, 62);
            this.gv_Orders.Name = "gv_Orders";
            this.gv_Orders.RowHeadersWidth = 25;
            this.gv_Orders.Size = new System.Drawing.Size(720, 347);
            this.gv_Orders.TabIndex = 38;
            this.gv_Orders.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Orders_CellValidated);
            this.gv_Orders.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_Orders_ColumnHeaderMouseClick);
            // 
            // cn_oartid
            // 
            this.cn_oartid.DataPropertyName = "artid";
            this.cn_oartid.HeaderText = "Art.ID";
            this.cn_oartid.Name = "cn_oartid";
            this.cn_oartid.ReadOnly = true;
            // 
            // cn_oarticle
            // 
            this.cn_oarticle.DataPropertyName = "article";
            this.cn_oarticle.HeaderText = "Article";
            this.cn_oarticle.Name = "cn_oarticle";
            this.cn_oarticle.ReadOnly = true;
            // 
            // cn_oinvoice
            // 
            this.cn_oinvoice.DataPropertyName = "invoice";
            this.cn_oinvoice.HeaderText = "Proforma/Invoice";
            this.cn_oinvoice.Name = "cn_oinvoice";
            this.cn_oinvoice.ReadOnly = true;
            // 
            // cn_oconforder
            // 
            this.cn_oconforder.DataPropertyName = "conforder";
            this.cn_oconforder.HeaderText = "Conf. order";
            this.cn_oconforder.Name = "cn_oconforder";
            this.cn_oconforder.ReadOnly = true;
            // 
            // cn_oquot
            // 
            this.cn_oquot.DataPropertyName = "quota";
            this.cn_oquot.HeaderText = "Quot.";
            this.cn_oquot.Name = "cn_oquot";
            this.cn_oquot.ReadOnly = true;
            // 
            // cn_oid
            // 
            this.cn_oid.DataPropertyName = "id";
            this.cn_oid.HeaderText = "id";
            this.cn_oid.Name = "cn_oid";
            this.cn_oid.ReadOnly = true;
            this.cn_oid.Visible = false;
            // 
            // cn_oamount
            // 
            this.cn_oamount.DataPropertyName = "amount";
            this.cn_oamount.FillWeight = 80F;
            this.cn_oamount.HeaderText = "Amount";
            this.cn_oamount.Name = "cn_oamount";
            this.cn_oamount.ReadOnly = true;
            this.cn_oamount.Width = 80;
            // 
            // cn_topay
            // 
            this.cn_topay.DataPropertyName = "topay";
            this.cn_topay.FillWeight = 80F;
            this.cn_topay.HeaderText = "To pay";
            this.cn_topay.Name = "cn_topay";
            this.cn_topay.Width = 80;
            // 
            // cn_ocurrency
            // 
            this.cn_ocurrency.DataPropertyName = "currency";
            this.cn_ocurrency.FillWeight = 40F;
            this.cn_ocurrency.HeaderText = "Curr.";
            this.cn_ocurrency.Name = "cn_ocurrency";
            this.cn_ocurrency.ReadOnly = true;
            this.cn_ocurrency.Width = 40;
            // 
            // cn_ocoid
            // 
            this.cn_ocoid.DataPropertyName = "coid";
            this.cn_ocoid.HeaderText = "coid";
            this.cn_ocoid.Name = "cn_ocoid";
            this.cn_ocoid.ReadOnly = true;
            this.cn_ocoid.Visible = false;
            // 
            // cn_oquotid
            // 
            this.cn_oquotid.DataPropertyName = "quotid";
            this.cn_oquotid.HeaderText = "quotid";
            this.cn_oquotid.Name = "cn_oquotid";
            this.cn_oquotid.ReadOnly = true;
            this.cn_oquotid.Visible = false;
            // 
            // cn_oinvoiceid
            // 
            this.cn_oinvoiceid.DataPropertyName = "invoiceid";
            this.cn_oinvoiceid.HeaderText = "invoiceid";
            this.cn_oinvoiceid.Name = "cn_oinvoiceid";
            this.cn_oinvoiceid.ReadOnly = true;
            this.cn_oinvoiceid.Visible = false;
            // 
            // cn_ooldamount
            // 
            this.cn_ooldamount.DataPropertyName = "oldamount";
            this.cn_ooldamount.HeaderText = "oldamount";
            this.cn_ooldamount.Name = "cn_ooldamount";
            this.cn_ooldamount.ReadOnly = true;
            this.cn_ooldamount.Visible = false;
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
            this.toolStripSeparator8,
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
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_oAdmin
            // 
            this.mni_oAdmin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_oAdmin.Name = "mni_oAdmin";
            this.mni_oAdmin.Size = new System.Drawing.Size(210, 22);
            this.mni_oAdmin.Text = "List settings";
            this.mni_oAdmin.Click += new System.EventHandler(this.mni_oAdmin_Click);
            // 
            // bs_Orders
            // 
            this.bs_Orders.DataMember = "dt_Orders";
            this.bs_Orders.DataSource = this.ds_Orders;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(720, 62);
            this.kryptonPanel3.TabIndex = 37;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(5, 5);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_All);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Invoice);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Proforma);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(204, 54);
            this.kryptonGroupBox1.TabIndex = 309;
            this.kryptonGroupBox1.Values.Heading = "Type of documents";
            this.kryptonGroupBox1.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            // 
            // rb_All
            // 
            this.rb_All.Location = new System.Drawing.Point(158, 3);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(36, 20);
            this.rb_All.TabIndex = 3;
            this.rb_All.Values.Text = "All";
            this.rb_All.CheckedChanged += new System.EventHandler(this.rb_All_CheckedChanged);
            // 
            // rb_Invoice
            // 
            this.rb_Invoice.Location = new System.Drawing.Point(82, 3);
            this.rb_Invoice.Name = "rb_Invoice";
            this.rb_Invoice.Size = new System.Drawing.Size(61, 20);
            this.rb_Invoice.TabIndex = 1;
            this.rb_Invoice.Values.Text = "Invoice";
            this.rb_Invoice.CheckedChanged += new System.EventHandler(this.rb_Invoice_CheckedChanged);
            // 
            // rb_Proforma
            // 
            this.rb_Proforma.Checked = true;
            this.rb_Proforma.Location = new System.Drawing.Point(9, 3);
            this.rb_Proforma.Name = "rb_Proforma";
            this.rb_Proforma.Size = new System.Drawing.Size(73, 20);
            this.rb_Proforma.TabIndex = 0;
            this.rb_Proforma.Values.Text = "Proforma";
            this.rb_Proforma.CheckedChanged += new System.EventHandler(this.rb_Proforma_CheckedChanged);
            // 
            // bn_Orders
            // 
            this.bn_Orders.AddNewItem = null;
            this.bn_Orders.BindingSource = this.bs_Orders;
            this.bn_Orders.CountItem = this.toolStripLabel2;
            this.bn_Orders.DeleteItem = null;
            this.bn_Orders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Orders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Orders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator6});
            this.bn_Orders.Location = new System.Drawing.Point(0, 409);
            this.bn_Orders.MoveFirstItem = this.toolStripButton5;
            this.bn_Orders.MoveLastItem = this.toolStripButton8;
            this.bn_Orders.MoveNextItem = this.toolStripButton7;
            this.bn_Orders.MovePreviousItem = this.toolStripButton6;
            this.bn_Orders.Name = "bn_Orders";
            this.bn_Orders.PositionItem = this.toolStripTextBox2;
            this.bn_Orders.Size = new System.Drawing.Size(720, 25);
            this.bn_Orders.TabIndex = 35;
            this.bn_Orders.Text = "bindingNavigator1";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btn_RemoveAll);
            this.kryptonPanel2.Controls.Add(this.btn_Wizard);
            this.kryptonPanel2.Controls.Add(this.btn_Add);
            this.kryptonPanel2.Controls.Add(this.btn_Remove);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel2.Location = new System.Drawing.Point(605, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel2.Size = new System.Drawing.Size(77, 492);
            this.kryptonPanel2.TabIndex = 16;
            // 
            // btn_RemoveAll
            // 
            this.btn_RemoveAll.Location = new System.Drawing.Point(6, 102);
            this.btn_RemoveAll.Name = "btn_RemoveAll";
            this.btn_RemoveAll.Size = new System.Drawing.Size(63, 43);
            this.btn_RemoveAll.TabIndex = 3;
            this.btn_RemoveAll.Values.Image = global::Odin.Global_Resourses.forwardx2;
            this.btn_RemoveAll.Values.Text = "";
            this.btn_RemoveAll.Click += new System.EventHandler(this.btn_RemoveAll_Click);
            // 
            // btn_Wizard
            // 
            this.btn_Wizard.Location = new System.Drawing.Point(5, 295);
            this.btn_Wizard.Name = "btn_Wizard";
            this.btn_Wizard.Size = new System.Drawing.Size(63, 43);
            this.btn_Wizard.TabIndex = 2;
            this.btn_Wizard.Values.Image = global::Odin.Global_Resourses.wand;
            this.btn_Wizard.Values.Text = "";
            this.btn_Wizard.Visible = false;
            this.btn_Wizard.Click += new System.EventHandler(this.btn_Wizard_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(5, 246);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(63, 43);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Values.Image = global::Odin.Global_Resourses.back;
            this.btn_Add.Values.Text = "";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Add_MouseDown);
            this.btn_Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Add_MouseMove);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(6, 150);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(63, 43);
            this.btn_Remove.TabIndex = 0;
            this.btn_Remove.Values.Image = global::Odin.Global_Resourses.forward;
            this.btn_Remove.Values.Text = "";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(605, 492);
            this.kryptonHeaderGroup1.TabIndex = 17;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Payment details";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.Money;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Payment details";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AutoGenerateColumns = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_artid,
            this.cn_article,
            this.cn_invoice,
            this.cn_conforder,
            this.cn_quot,
            this.cn_amount,
            this.cn_currency,
            this.cn_invoiceid,
            this.cn_oldamount});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.DataSource = this.bs_List;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.MultiSelect = false;
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(603, 409);
            this.gv_List.TabIndex = 35;
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
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
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 80F;
            this.cn_artid.HeaderText = "Art.ID";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
            this.cn_artid.Width = 80;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 120F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Width = 120;
            // 
            // cn_invoice
            // 
            this.cn_invoice.DataPropertyName = "invoice";
            this.cn_invoice.FillWeight = 90F;
            this.cn_invoice.HeaderText = "Proforma/Invoice";
            this.cn_invoice.Name = "cn_invoice";
            this.cn_invoice.ReadOnly = true;
            this.cn_invoice.Width = 90;
            // 
            // cn_conforder
            // 
            this.cn_conforder.DataPropertyName = "conforder";
            this.cn_conforder.FillWeight = 90F;
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            this.cn_conforder.ReadOnly = true;
            this.cn_conforder.Width = 90;
            // 
            // cn_quot
            // 
            this.cn_quot.DataPropertyName = "quota";
            this.cn_quot.FillWeight = 90F;
            this.cn_quot.HeaderText = "Quot.";
            this.cn_quot.Name = "cn_quot";
            this.cn_quot.ReadOnly = true;
            this.cn_quot.Width = 90;
            // 
            // cn_amount
            // 
            this.cn_amount.DataPropertyName = "amount";
            this.cn_amount.FillWeight = 70F;
            this.cn_amount.HeaderText = "Amount";
            this.cn_amount.Name = "cn_amount";
            this.cn_amount.ReadOnly = true;
            this.cn_amount.Width = 70;
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
            // cn_invoiceid
            // 
            this.cn_invoiceid.DataPropertyName = "invoiceid";
            this.cn_invoiceid.HeaderText = "invoiceid";
            this.cn_invoiceid.Name = "cn_invoiceid";
            this.cn_invoiceid.ReadOnly = true;
            this.cn_invoiceid.Visible = false;
            // 
            // cn_oldamount
            // 
            this.cn_oldamount.DataPropertyName = "oldamount";
            this.cn_oldamount.HeaderText = "oldamount";
            this.cn_oldamount.Name = "cn_oldamount";
            this.cn_oldamount.ReadOnly = true;
            this.cn_oldamount.Visible = false;
            // 
            // bs_List
            // 
            this.bs_List.DataMember = "dt_List";
            this.bs_List.DataSource = this.ds_List;
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.BindingSource = this.bs_List;
            this.bn_List.CountItem = this.toolStripLabel1;
            this.bn_List.DeleteItem = null;
            this.bn_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4});
            this.bn_List.Location = new System.Drawing.Point(0, 409);
            this.bn_List.MoveFirstItem = this.toolStripButton1;
            this.bn_List.MoveLastItem = this.toolStripButton4;
            this.bn_List.MoveNextItem = this.toolStripButton3;
            this.bn_List.MovePreviousItem = this.toolStripButton2;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.toolStripTextBox1;
            this.bn_List.Size = new System.Drawing.Size(603, 25);
            this.bn_List.TabIndex = 34;
            this.bn_List.Text = "bindingNavigator1";
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
            // frm_RelinkPaymentOrders
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 550);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RelinkPaymentOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relink payment orders";
            this.Load += new System.EventHandler(this.frm_RelinkPaymentOrders_Load);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Orders)).EndInit();
            this.mnu_Orders.ResumeLayout(false);
            this.mnu_Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bn_Orders)).EndInit();
            this.bn_Orders.ResumeLayout(false);
            this.bn_Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private Global_Classes.SyncBindingSource bs_Orders;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private System.Windows.Forms.BindingNavigator bn_Orders;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Total;
        private Owf.Controls.NumericTetxBox txt_TotalMapped;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Wizard;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Remove;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Owf.Controls.NumericTetxBox txt_TotalInPayment;
        private System.Windows.Forms.ContextMenuStrip mnu_Orders;
        private System.Windows.Forms.ToolStripTextBox mni_oFilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_oSearch;
        private System.Windows.Forms.ToolStripMenuItem mni_oFilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_oFilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_oRemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_oCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mni_oAdmin;
        private System.Data.DataSet ds_List;
        private System.Data.DataTable dt_List;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataSet ds_Orders;
        private System.Data.DataTable dt_Orders;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_All;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Invoice;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Proforma;
        private System.Data.DataColumn dataColumn23;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Orders;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        public CustomControls.NullableDateTimePicker txt_PayDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RemoveAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oquot;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_topay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oquotid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oinvoiceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ooldamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_quot;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_invoiceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oldamount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Owf.Controls.NumericTetxBox txt_Rest;
    }
}