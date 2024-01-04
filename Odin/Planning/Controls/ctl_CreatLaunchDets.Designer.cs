namespace Odin.Planning.Controls
{
    partial class ctl_CreatLaunchDets
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_CreatLaunchDets));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_BatchComments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Stages = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_ProdStartDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyCanBeLaunchedTotal = new Owf.Controls.NumericTetxBox();
            this.btn_RecalcLaunched = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_EndDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Customer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_SalesOrdersWithLines1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrdersWithLines();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyCanBeLaunched = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NotLaunched = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_StartDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Qty = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_BatchStages1 = new Odin.CMB_Components.BatchStages.cmb_BatchStages();
            this.txt_Launch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_DeleteLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_Unit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_Decimals = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Round = new System.Windows.Forms.ToolStripButton();
            this.btn_Clear = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
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
            this.cn_numdecimals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.ds_MB = new System.Data.DataSet();
            this.dt_MB = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.btn_CBLMB = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_MB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MB)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_CBLMB);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel16);
            this.kryptonPanel1.Controls.Add(this.txt_BatchComments);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel15);
            this.kryptonPanel1.Controls.Add(this.txt_Stages);
            this.kryptonPanel1.Controls.Add(this.txt_ProdStartDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel1.Controls.Add(this.btn_Refresh);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel1.Controls.Add(this.txt_QtyCanBeLaunchedTotal);
            this.kryptonPanel1.Controls.Add(this.btn_RecalcLaunched);
            this.kryptonPanel1.Controls.Add(this.txt_EndDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.txt_Customer);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel1.Controls.Add(this.cmb_SalesOrdersWithLines1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel1.Controls.Add(this.txt_QtyCanBeLaunched);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.txt_NotLaunched);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.txt_Comments);
            this.kryptonPanel1.Controls.Add(this.txt_StartDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.txt_Qty);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.cmb_BatchStages1);
            this.kryptonPanel1.Controls.Add(this.txt_Launch);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(1107, 173);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(791, 39);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(104, 20);
            this.kryptonLabel16.TabIndex = 297;
            this.kryptonLabel16.Values.Text = "Batch comments:";
            // 
            // txt_BatchComments
            // 
            this.txt_BatchComments.Location = new System.Drawing.Point(791, 63);
            this.txt_BatchComments.Multiline = true;
            this.txt_BatchComments.Name = "txt_BatchComments";
            this.txt_BatchComments.Size = new System.Drawing.Size(305, 107);
            this.txt_BatchComments.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_BatchComments.TabIndex = 296;
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(534, 39);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel15.TabIndex = 295;
            this.kryptonLabel15.Values.Text = "Stages:";
            // 
            // txt_Stages
            // 
            this.txt_Stages.Location = new System.Drawing.Point(606, 39);
            this.txt_Stages.Name = "txt_Stages";
            this.txt_Stages.Size = new System.Drawing.Size(179, 23);
            this.txt_Stages.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Stages.TabIndex = 294;
            // 
            // txt_ProdStartDate
            // 
            this.txt_ProdStartDate.CalendarShowWeekNumbers = true;
            this.txt_ProdStartDate.CustomFormat = null;
            this.txt_ProdStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ProdStartDate.Location = new System.Drawing.Point(543, 121);
            this.txt_ProdStartDate.Name = "txt_ProdStartDate";
            this.txt_ProdStartDate.NullValue = " ";
            this.txt_ProdStartDate.Size = new System.Drawing.Size(89, 21);
            this.txt_ProdStartDate.TabIndex = 293;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(226, 122);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(94, 20);
            this.kryptonLabel14.TabIndex = 292;
            this.kryptonLabel14.Values.Text = "RM movement:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Refresh.Location = new System.Drawing.Point(241, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Refresh.Size = new System.Drawing.Size(47, 43);
            this.btn_Refresh.TabIndex = 291;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(478, 94);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(154, 20);
            this.kryptonLabel13.TabIndex = 290;
            this.kryptonLabel13.Values.Text = "Qty can be launched total:";
            // 
            // txt_QtyCanBeLaunchedTotal
            // 
            this.txt_QtyCanBeLaunchedTotal.AllowDecimalSeparator = true;
            this.txt_QtyCanBeLaunchedTotal.AllowSpace = false;
            this.txt_QtyCanBeLaunchedTotal.Enabled = false;
            this.txt_QtyCanBeLaunchedTotal.Location = new System.Drawing.Point(647, 94);
            this.txt_QtyCanBeLaunchedTotal.Name = "txt_QtyCanBeLaunchedTotal";
            this.txt_QtyCanBeLaunchedTotal.Size = new System.Drawing.Size(88, 21);
            this.txt_QtyCanBeLaunchedTotal.StateActive.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeLaunchedTotal.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyCanBeLaunchedTotal.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_QtyCanBeLaunchedTotal.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeLaunchedTotal.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyCanBeLaunchedTotal.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_QtyCanBeLaunchedTotal.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_QtyCanBeLaunchedTotal.StateDisabled.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeLaunchedTotal.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_QtyCanBeLaunchedTotal.TabIndex = 289;
            this.txt_QtyCanBeLaunchedTotal.Text = "0";
            // 
            // btn_RecalcLaunched
            // 
            this.btn_RecalcLaunched.Location = new System.Drawing.Point(744, 91);
            this.btn_RecalcLaunched.Name = "btn_RecalcLaunched";
            this.btn_RecalcLaunched.Size = new System.Drawing.Size(41, 27);
            this.btn_RecalcLaunched.TabIndex = 288;
            this.btn_RecalcLaunched.Values.Image = global::Odin.Global_Resourses.calculator_edit16x16;
            this.btn_RecalcLaunched.Values.Text = "";
            this.btn_RecalcLaunched.Click += new System.EventHandler(this.btn_RecalcLaunched_Click);
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.CalendarShowWeekNumbers = true;
            this.txt_EndDate.CustomFormat = null;
            this.txt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndDate.Location = new System.Drawing.Point(696, 121);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.NullValue = " ";
            this.txt_EndDate.Size = new System.Drawing.Size(89, 21);
            this.txt_EndDate.TabIndex = 287;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(637, 121);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel12.TabIndex = 286;
            this.kryptonLabel12.Values.Text = "ends at:";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(312, 39);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel11.TabIndex = 285;
            this.kryptonLabel11.Values.Text = "Customer:";
            // 
            // txt_Customer
            // 
            this.txt_Customer.Location = new System.Drawing.Point(384, 39);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(140, 23);
            this.txt_Customer.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Customer.TabIndex = 284;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(17, 66);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel10.TabIndex = 283;
            this.kryptonLabel10.Values.Text = "Conf. order:";
            // 
            // cmb_SalesOrdersWithLines1
            // 
            this.cmb_SalesOrdersWithLines1.ArticleId = 0;
            this.cmb_SalesOrdersWithLines1.BatchId = 0;
            this.cmb_SalesOrdersWithLines1.Location = new System.Drawing.Point(131, 67);
            this.cmb_SalesOrdersWithLines1.Name = "cmb_SalesOrdersWithLines1";
            this.cmb_SalesOrdersWithLines1.QtyInCO = 0D;
            this.cmb_SalesOrdersWithLines1.SalesOrder = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            this.cmb_SalesOrdersWithLines1.SalesOrderLine = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            this.cmb_SalesOrdersWithLines1.Size = new System.Drawing.Size(212, 21);
            this.cmb_SalesOrdersWithLines1.TabIndex = 282;
            this.cmb_SalesOrdersWithLines1.SalesOrderChanged += new Odin.CMB_Components.SalesOrders.SalesOrdersWHEventHandler(this.cmb_SalesOrdersWithLines1_SalesOrderChanged);
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(226, 94);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(125, 20);
            this.kryptonLabel9.TabIndex = 281;
            this.kryptonLabel9.Values.Text = "Qty can be launched:";
            // 
            // txt_QtyCanBeLaunched
            // 
            this.txt_QtyCanBeLaunched.AllowDecimalSeparator = true;
            this.txt_QtyCanBeLaunched.AllowSpace = false;
            this.txt_QtyCanBeLaunched.Enabled = false;
            this.txt_QtyCanBeLaunched.Location = new System.Drawing.Point(355, 93);
            this.txt_QtyCanBeLaunched.Name = "txt_QtyCanBeLaunched";
            this.txt_QtyCanBeLaunched.Size = new System.Drawing.Size(73, 21);
            this.txt_QtyCanBeLaunched.StateActive.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeLaunched.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyCanBeLaunched.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_QtyCanBeLaunched.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeLaunched.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyCanBeLaunched.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_QtyCanBeLaunched.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_QtyCanBeLaunched.StateDisabled.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeLaunched.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_QtyCanBeLaunched.TabIndex = 280;
            this.txt_QtyCanBeLaunched.Text = "0";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(17, 94);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel8.TabIndex = 279;
            this.kryptonLabel8.Values.Text = "Qty not launched:";
            // 
            // txt_NotLaunched
            // 
            this.txt_NotLaunched.AllowDecimalSeparator = true;
            this.txt_NotLaunched.AllowSpace = false;
            this.txt_NotLaunched.Enabled = false;
            this.txt_NotLaunched.Location = new System.Drawing.Point(131, 94);
            this.txt_NotLaunched.Name = "txt_NotLaunched";
            this.txt_NotLaunched.Size = new System.Drawing.Size(88, 21);
            this.txt_NotLaunched.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.txt_NotLaunched.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_NotLaunched.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_NotLaunched.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txt_NotLaunched.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_NotLaunched.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_NotLaunched.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_NotLaunched.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_NotLaunched.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_NotLaunched.TabIndex = 278;
            this.txt_NotLaunched.Text = "0";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(17, 147);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel7.TabIndex = 277;
            this.kryptonLabel7.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_Comments.Location = new System.Drawing.Point(95, 147);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(690, 23);
            this.txt_Comments.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Comments.TabIndex = 276;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "D5B6C03750554195328E4B264796E65F";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.CalendarShowWeekNumbers = true;
            this.txt_StartDate.CustomFormat = null;
            this.txt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartDate.Location = new System.Drawing.Point(326, 121);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.NullValue = " ";
            this.txt_StartDate.Size = new System.Drawing.Size(88, 21);
            this.txt_StartDate.TabIndex = 275;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(420, 122);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(120, 20);
            this.kryptonLabel6.TabIndex = 274;
            this.kryptonLabel6.Values.Text = "Production starts at:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(355, 67);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel5.TabIndex = 18;
            this.kryptonLabel5.Values.Text = "Article:";
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
            this.cmb_Articles1.Enabled = false;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(414, 67);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(282, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 17;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(17, 121);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel4.TabIndex = 15;
            this.kryptonLabel4.Values.Text = "Qty in launch:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.AllowDecimalSeparator = true;
            this.txt_Qty.AllowSpace = false;
            this.txt_Qty.Location = new System.Drawing.Point(131, 121);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(88, 21);
            this.txt_Qty.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Qty.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Qty.TabIndex = 14;
            this.txt_Qty.Text = "0";
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(17, 39);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Stage:";
            // 
            // cmb_BatchStages1
            // 
            this.cmb_BatchStages1.BatchId = 0;
            this.cmb_BatchStages1.Launches = -1;
            this.cmb_BatchStages1.Location = new System.Drawing.Point(95, 39);
            this.cmb_BatchStages1.Name = "cmb_BatchStages1";
            this.cmb_BatchStages1.Size = new System.Drawing.Size(140, 20);
            this.cmb_BatchStages1.Stage = "";
            this.cmb_BatchStages1.StageId = 0;
            this.cmb_BatchStages1.TabIndex = 12;
            this.cmb_BatchStages1.StageChanged += new Odin.CMB_Components.BatchStages.StageEventHandler(this.cmb_BatchStages1_StageChanged);
            // 
            // txt_Launch
            // 
            this.txt_Launch.Location = new System.Drawing.Point(384, 13);
            this.txt_Launch.Name = "txt_Launch";
            this.txt_Launch.Size = new System.Drawing.Size(140, 21);
            this.txt_Launch.StateActive.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Launch.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Launch.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Launch.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Launch.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Launch.StateNormal.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Launch.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Launch.TabIndex = 11;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(312, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Launch:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "Batch:";
            // 
            // cmb_Batches1
            // 
            this.cmb_Batches1.ActiveOnly = -1;
            this.cmb_Batches1.Article = null;
            this.cmb_Batches1.ArticleId = 0;
            this.cmb_Batches1.Batch = "";
            this.cmb_Batches1.BatchId = 0;
            this.cmb_Batches1.Comments = "";
            this.cmb_Batches1.ConfOrder = null;
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.CustArticle = "";
            this.cmb_Batches1.Customer = null;
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.IsGroup = 0;
            this.cmb_Batches1.IsProject = 0;
            this.cmb_Batches1.IsQuote = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(95, 14);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(140, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 0;
            this.cmb_Batches1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches1_BatchChanged);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = null;
            this.bn_List.DeleteItem = null;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_DeleteLine,
            this.toolStripLabel1,
            this.cmb_Unit,
            this.toolStripLabel2,
            this.cmb_Decimals,
            this.btn_Round,
            this.btn_Clear,
            this.btn_Save});
            this.bn_List.Location = new System.Drawing.Point(0, 173);
            this.bn_List.MoveFirstItem = null;
            this.bn_List.MoveLastItem = null;
            this.bn_List.MoveNextItem = null;
            this.bn_List.MovePreviousItem = null;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = null;
            this.bn_List.Size = new System.Drawing.Size(1107, 25);
            this.bn_List.TabIndex = 43;
            this.bn_List.Text = "Bill of materials";
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
            // btn_Clear
            // 
            this.btn_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(23, 22);
            this.btn_Clear.Text = "Clear quantities to previous state ";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(23, 22);
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            this.cn_theorstock,
            this.cn_numdecimals});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 198);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(1107, 359);
            this.gv_List.TabIndex = 44;
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
            // cn_numdecimals
            // 
            this.cn_numdecimals.DataPropertyName = "numdecimals";
            this.cn_numdecimals.HeaderText = "numdecimals";
            this.cn_numdecimals.Name = "cn_numdecimals";
            this.cn_numdecimals.Visible = false;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bomnum";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "BOM №";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "artid";
            this.dataGridViewTextBoxColumn3.FillWeight = 70F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Art. id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Article";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "analogs";
            this.dataGridViewTextBoxColumn5.FillWeight = 150F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Analogs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "unit";
            this.dataGridViewTextBoxColumn6.FillWeight = 40F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn7.FillWeight = 70F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Qty in launch";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 85;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "qtyinbatch";
            this.dataGridViewTextBoxColumn8.FillWeight = 70F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Qty in batch";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 85;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "launched";
            this.dataGridViewTextBoxColumn9.FillWeight = 70F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Total launched";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 85;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "reserved";
            this.dataGridViewTextBoxColumn10.FillWeight = 70F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Reserved";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "qtystock";
            this.dataGridViewTextBoxColumn11.FillWeight = 70F;
            this.dataGridViewTextBoxColumn11.HeaderText = "On stock";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 70;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "qtybom";
            this.dataGridViewTextBoxColumn12.FillWeight = 70F;
            this.dataGridViewTextBoxColumn12.HeaderText = "In BOM.";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 70;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "purchased";
            this.dataGridViewTextBoxColumn13.FillWeight = 70F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Purchased";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 70;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "porder";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn14.FillWeight = 70F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Pur. order";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 70;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "confdate";
            this.dataGridViewTextBoxColumn15.FillWeight = 70F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Conf. deliv. date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 70;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "qtybom";
            this.dataGridViewTextBoxColumn16.FillWeight = 70F;
            this.dataGridViewTextBoxColumn16.HeaderText = "In BOM.";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 70;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "qtybom";
            this.dataGridViewTextBoxColumn17.FillWeight = 70F;
            this.dataGridViewTextBoxColumn17.HeaderText = "In BOM.";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 70;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "qtybom";
            this.dataGridViewTextBoxColumn18.FillWeight = 70F;
            this.dataGridViewTextBoxColumn18.HeaderText = "In BOM.";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 70;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "qtyavailable";
            this.dataGridViewTextBoxColumn19.HeaderText = "Available";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // ds_MB
            // 
            this.ds_MB.DataSetName = "NewDataSet";
            this.ds_MB.Tables.AddRange(new System.Data.DataTable[] {
            this.dt_MB});
            // 
            // dt_MB
            // 
            this.dt_MB.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dt_MB.TableName = "dt_MB";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "batchdetid";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "artid";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "maxqtycse";
            this.dataColumn3.DataType = typeof(double);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "manufbatch";
            // 
            // btn_CBLMB
            // 
            this.btn_CBLMB.Location = new System.Drawing.Point(434, 91);
            this.btn_CBLMB.Name = "btn_CBLMB";
            this.btn_CBLMB.Size = new System.Drawing.Size(41, 27);
            this.btn_CBLMB.TabIndex = 299;
            this.btn_CBLMB.Values.Image = global::Odin.Global_Resourses.Question_point16x16;
            this.btn_CBLMB.Values.Text = "";
            this.btn_CBLMB.Click += new System.EventHandler(this.btn_CBLMB_Click);
            // 
            // ctl_CreatLaunchDets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_CreatLaunchDets";
            this.Size = new System.Drawing.Size(1107, 557);
            this.Load += new System.EventHandler(this.ctl_CreatLaunchDets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_MB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MB)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Launch;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripButton btn_DeleteLine;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmb_Unit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmb_Decimals;
        private System.Windows.Forms.ToolStripButton btn_Round;
        private System.Windows.Forms.ToolStripButton btn_Clear;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.BatchStages.cmb_BatchStages cmb_BatchStages1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Owf.Controls.NumericTetxBox txt_Qty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
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
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        public Owf.Controls.NumericTetxBox txt_NotLaunched;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        public Owf.Controls.NumericTetxBox txt_QtyCanBeLaunched;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Customer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
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
        public CustomControls.NullableDateTimePicker txt_StartDate;
        public CustomControls.NullableDateTimePicker txt_EndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RecalcLaunched;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        public Owf.Controls.NumericTetxBox txt_QtyCanBeLaunchedTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        public CustomControls.NullableDateTimePicker txt_ProdStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Stages;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_BatchComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batchdetid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bomnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_analog;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_numdecimals;
        private System.Data.DataSet ds_MB;
        private System.Data.DataTable dt_MB;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_CBLMB;
    }
}
