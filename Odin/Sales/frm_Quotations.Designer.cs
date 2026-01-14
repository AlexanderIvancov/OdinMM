namespace Odin.Sales
{
    partial class frm_Quotations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Quotations));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ctl_btnNum2 = new Odin.CustomControls.ctl_btnNum();
            this.ctl_btnNum1 = new Odin.CustomControls.ctl_btnNum();
            this.btn_PCBNeeds = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Orders = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Process = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_History = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_General = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.chk_PCB = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Quotations1 = new Odin.CMB_Components.Quotations.cmb_Quotations();
            this.cmb_Week1 = new Odin.CMB_Components.Week.cmb_Week();
            this.txt_ReqDateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny6 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_CreatDateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_ReqDateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_CreatDateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Department1 = new Odin.CMB_Components.Departments.cmb_Department();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CustArticle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny7 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reqdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_leadweek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pcbtext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_SMT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_THT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_FTA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_IPA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_issent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_sentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_endcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_blockdelivery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_delivaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_AddNew = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Copy = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.btn_RMConsulting = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
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
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_RMConsulting);
            this.kryptonPanel1.Controls.Add(this.ctl_btnNum2);
            this.kryptonPanel1.Controls.Add(this.ctl_btnNum1);
            this.kryptonPanel1.Controls.Add(this.btn_PCBNeeds);
            this.kryptonPanel1.Controls.Add(this.btn_Orders);
            this.kryptonPanel1.Controls.Add(this.btn_Process);
            this.kryptonPanel1.Controls.Add(this.btn_History);
            this.kryptonPanel1.Controls.Add(this.btn_General);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1103, 49);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // ctl_btnNum2
            // 
            this.ctl_btnNum2.BackColor = System.Drawing.Color.Transparent;
            this.ctl_btnNum2.ButtonText = "Confirmed BOMs";
            this.ctl_btnNum2.FormText = "Confirmed BOM\'s list";
            this.ctl_btnNum2.GetCountQuery = "exec sp_SelectConfirmedBOMsCount";
            this.ctl_btnNum2.IconPath = global::Odin.Global_Resourses.Confirm_History;
            this.ctl_btnNum2.Location = new System.Drawing.Point(393, 2);
            this.ctl_btnNum2.Name = "ctl_btnNum2";
            this.ctl_btnNum2.Padding = new System.Windows.Forms.Padding(3);
            this.ctl_btnNum2.Qty = "1";
            this.ctl_btnNum2.Size = new System.Drawing.Size(199, 45);
            this.ctl_btnNum2.strRunQuery = "sp_SelectConfirmedBOMs";
            this.ctl_btnNum2.TabIndex = 12;
            // 
            // ctl_btnNum1
            // 
            this.ctl_btnNum1.BackColor = System.Drawing.Color.Transparent;
            this.ctl_btnNum1.ButtonText = "Invalide BOMs";
            this.ctl_btnNum1.FormText = "Invalide BOM\'s list";
            this.ctl_btnNum1.GetCountQuery = "exec sp_SelectInvalideBOMsCount";
            this.ctl_btnNum1.IconPath = ((System.Drawing.Image)(resources.GetObject("ctl_btnNum1.IconPath")));
            this.ctl_btnNum1.Location = new System.Drawing.Point(216, 2);
            this.ctl_btnNum1.Name = "ctl_btnNum1";
            this.ctl_btnNum1.Padding = new System.Windows.Forms.Padding(3);
            this.ctl_btnNum1.Qty = "9";
            this.ctl_btnNum1.Size = new System.Drawing.Size(187, 45);
            this.ctl_btnNum1.strRunQuery = "sp_SelectInvalideBOMs";
            this.ctl_btnNum1.TabIndex = 11;
            // 
            // btn_PCBNeeds
            // 
            this.btn_PCBNeeds.Location = new System.Drawing.Point(107, 5);
            this.btn_PCBNeeds.Name = "btn_PCBNeeds";
            this.btn_PCBNeeds.Size = new System.Drawing.Size(109, 39);
            this.btn_PCBNeeds.TabIndex = 9;
            this.btn_PCBNeeds.Values.Image = global::Odin.Global_Resourses.motherboard;
            this.btn_PCBNeeds.Values.Text = "PCB needs";
            this.btn_PCBNeeds.Click += new System.EventHandler(this.btn_PCBNeeds_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.Location = new System.Drawing.Point(955, 4);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Size = new System.Drawing.Size(109, 39);
            this.btn_Orders.TabIndex = 8;
            this.btn_Orders.Values.Image = global::Odin.Global_Resourses.Al_Right;
            this.btn_Orders.Values.Text = "Orders";
            this.btn_Orders.Visible = false;
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(859, 4);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(92, 39);
            this.btn_Process.TabIndex = 2;
            this.btn_Process.Values.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.btn_Process.Values.Text = "Process";
            this.btn_Process.Visible = false;
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(1067, 4);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(109, 39);
            this.btn_History.TabIndex = 7;
            this.btn_History.Values.Image = global::Odin.Global_Resourses.emblem_library_9156;
            this.btn_History.Values.Text = "History";
            this.btn_History.Visible = false;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_General
            // 
            this.btn_General.Location = new System.Drawing.Point(4, 5);
            this.btn_General.Name = "btn_General";
            this.btn_General.Size = new System.Drawing.Size(100, 39);
            this.btn_General.TabIndex = 1;
            this.btn_General.Values.Image = global::Odin.Global_Resourses.Docs;
            this.btn_General.Values.Text = "General";
            this.btn_General.Click += new System.EventHandler(this.btn_General_Click);
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
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1103, 593);
            this.kryptonSplitContainer1.SplitterDistance = 457;
            this.kryptonSplitContainer1.TabIndex = 6;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_PCB);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Quotations1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Week1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_ReqDateTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CreatDateTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_ReqDateFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CreatDateFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel16);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel15);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Department1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel14);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_CustArticle);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Comments);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Common1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel13);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel12);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel11);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel9);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel10);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
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
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1103, 457);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // chk_PCB
            // 
            this.chk_PCB.Checked = true;
            this.chk_PCB.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chk_PCB.Location = new System.Drawing.Point(91, 259);
            this.chk_PCB.Name = "chk_PCB";
            this.chk_PCB.Size = new System.Drawing.Size(108, 20);
            this.chk_PCB.TabIndex = 308;
            this.chk_PCB.ThreeState = true;
            this.chk_PCB.Values.Text = "PCB: Undefined";
            this.chk_PCB.CheckStateChanged += new System.EventHandler(this.chk_PCB_CheckStateChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(7, 48);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel1.TabIndex = 247;
            this.kryptonLabel1.Values.Text = "Quotation:";
            // 
            // cmb_Quotations1
            // 
            this.cmb_Quotations1.ClientId = 0;
            this.cmb_Quotations1.EnableSearchId = false;
            this.cmb_Quotations1.Location = new System.Drawing.Point(91, 48);
            this.cmb_Quotations1.Name = "cmb_Quotations1";
            this.cmb_Quotations1.Quotation = "";
            this.cmb_Quotations1.QuotationId = 0;
            this.cmb_Quotations1.QuotationSavedId = 0;
            this.cmb_Quotations1.Size = new System.Drawing.Size(203, 20);
            this.cmb_Quotations1.TabIndex = 246;
            // 
            // cmb_Week1
            // 
            this.cmb_Week1.FirstDateOfWeek = new System.DateTime(((long)(0)));
            this.cmb_Week1.LastDateOfWeek = new System.DateTime(((long)(0)));
            this.cmb_Week1.Location = new System.Drawing.Point(119, 324);
            this.cmb_Week1.Name = "cmb_Week1";
            this.cmb_Week1.Size = new System.Drawing.Size(104, 20);
            this.cmb_Week1.TabIndex = 245;
            this.cmb_Week1.Week = "W  .";
            this.cmb_Week1.weekNumber = 0;
            this.cmb_Week1.SelectedValueChanged += new Odin.CMB_Components.Week.WeekEventHandler(this.cmb_Week1_SelectedValueChanged);
            // 
            // txt_ReqDateTill
            // 
            this.txt_ReqDateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny6});
            this.txt_ReqDateTill.CalendarShowWeekNumbers = true;
            this.txt_ReqDateTill.CustomFormat = null;
            this.txt_ReqDateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ReqDateTill.Location = new System.Drawing.Point(189, 348);
            this.txt_ReqDateTill.Name = "txt_ReqDateTill";
            this.txt_ReqDateTill.NullValue = " ";
            this.txt_ReqDateTill.Size = new System.Drawing.Size(105, 21);
            this.txt_ReqDateTill.TabIndex = 217;
            this.txt_ReqDateTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_ReqDateTill_DropDown);
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny6.UniqueName = "8965B894993B4F920291611D31488FC0";
            this.buttonSpecAny6.Click += new System.EventHandler(this.buttonSpecAny6_Click);
            // 
            // txt_CreatDateTill
            // 
            this.txt_CreatDateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_CreatDateTill.CalendarShowWeekNumbers = true;
            this.txt_CreatDateTill.CustomFormat = null;
            this.txt_CreatDateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CreatDateTill.Location = new System.Drawing.Point(190, 300);
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
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // txt_ReqDateFrom
            // 
            this.txt_ReqDateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_ReqDateFrom.CalendarShowWeekNumbers = true;
            this.txt_ReqDateFrom.CustomFormat = null;
            this.txt_ReqDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ReqDateFrom.Location = new System.Drawing.Point(54, 348);
            this.txt_ReqDateFrom.Name = "txt_ReqDateFrom";
            this.txt_ReqDateFrom.NullValue = " ";
            this.txt_ReqDateFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_ReqDateFrom.TabIndex = 215;
            this.txt_ReqDateFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_ReqDateFrom_DropDown);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "2AEB854929374CB361A80771E44C2EAD";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // txt_CreatDateFrom
            // 
            this.txt_CreatDateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_CreatDateFrom.CalendarShowWeekNumbers = true;
            this.txt_CreatDateFrom.CustomFormat = null;
            this.txt_CreatDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CreatDateFrom.Location = new System.Drawing.Point(54, 300);
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
            this.buttonSpecAny5.Click += new System.EventHandler(this.buttonSpecAny5_Click);
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(7, 78);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 210;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(7, 187);
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
            this.cmb_Articles1.CertState = "";
            this.cmb_Articles1.Comments = null;
            this.cmb_Articles1.CustCode = null;
            this.cmb_Articles1.CustCodeId = 0;
            this.cmb_Articles1.Department = null;
            this.cmb_Articles1.DeptId = 0;
            this.cmb_Articles1.Description = null;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(12, 207);
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
            this.cmb_Articles1.TabIndex = 34;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(7, 140);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel15.TabIndex = 33;
            this.kryptonLabel15.Values.Text = "Department:";
            // 
            // cmb_Department1
            // 
            this.cmb_Department1.Department = "";
            this.cmb_Department1.DeptId = 0;
            this.cmb_Department1.Location = new System.Drawing.Point(91, 140);
            this.cmb_Department1.Name = "cmb_Department1";
            this.cmb_Department1.SelectedNode = null;
            this.cmb_Department1.Size = new System.Drawing.Size(179, 20);
            this.cmb_Department1.TabIndex = 32;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(7, 233);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel14.TabIndex = 31;
            this.kryptonLabel14.Values.Text = "Cust. article:";
            // 
            // txt_CustArticle
            // 
            this.txt_CustArticle.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny7});
            this.txt_CustArticle.Location = new System.Drawing.Point(91, 233);
            this.txt_CustArticle.Name = "txt_CustArticle";
            this.txt_CustArticle.Size = new System.Drawing.Size(204, 23);
            this.txt_CustArticle.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_CustArticle.TabIndex = 30;
            // 
            // buttonSpecAny7
            // 
            this.buttonSpecAny7.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny7.UniqueName = "90C4E6C9A1E1431FA6AE4F89E70F2995";
            this.buttonSpecAny7.Click += new System.EventHandler(this.buttonSpecAny7_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(7, 373);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel5.TabIndex = 29;
            this.kryptonLabel5.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_Comments.Location = new System.Drawing.Point(91, 373);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(204, 52);
            this.txt_Comments.TabIndex = 28;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "90C4E6C9A1E1431FA6AE4F89E70F2995";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(91, 166);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(148, 20);
            this.cmb_Common1.sTable = "SAL_QuotState";
            this.cmb_Common1.sText_Filled = "code";
            this.cmb_Common1.sTitle = "Order states";
            this.cmb_Common1.TabIndex = 27;
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(7, 167);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel13.TabIndex = 26;
            this.kryptonLabel13.Values.Text = "State:";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(161, 349);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel12.TabIndex = 24;
            this.kryptonLabel12.Values.Text = "till:";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(161, 300);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel11.TabIndex = 23;
            this.kryptonLabel11.Values.Text = "till:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(7, 349);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel9.TabIndex = 22;
            this.kryptonLabel9.Values.Text = "From:";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(7, 324);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(106, 20);
            this.kryptonLabel10.TabIndex = 21;
            this.kryptonLabel10.Values.Text = "Lead time (week):";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(7, 301);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(7, 280);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(118, 20);
            this.kryptonLabel7.TabIndex = 16;
            this.kryptonLabel7.Values.Text = "Registration period:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(7, 114);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel6.TabIndex = 14;
            this.kryptonLabel6.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(91, 114);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Types1.TabIndex = 13;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 88);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Customer:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(91, 88);
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
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_name,
            this.cn_revision,
            this.cn_client,
            this.cn_artid,
            this.cn_article,
            this.cn_custart,
            this.cn_type,
            this.cn_department,
            this.cn_qty,
            this.cn_unit,
            this.cn_reqdate,
            this.cn_leadweek,
            this.cn_state,
            this.cn_unitprice,
            this.cn_currency,
            this.cn_comments,
            this.cn_contract,
            this.cn_pcbtext,
            this.chk_SMT,
            this.chk_THT,
            this.chk_FTA,
            this.chk_IPA,
            this.cn_createdat,
            this.cn_createdby,
            this.cn_expdate,
            this.cn_stateid,
            this.chk_issent,
            this.cn_sentdate,
            this.cn_endcustomer,
            this.cn_paid,
            this.cn_conforder,
            this.cn_blockdelivery,
            this.cn_delivaddress});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.ReadOnly = true;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(799, 432);
            this.gv_List.TabIndex = 3;
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
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
            // cn_name
            // 
            this.cn_name.DataPropertyName = "name";
            this.cn_name.FillWeight = 90F;
            this.cn_name.HeaderText = "Quotation";
            this.cn_name.Name = "cn_name";
            this.cn_name.ReadOnly = true;
            this.cn_name.Width = 90;
            // 
            // cn_revision
            // 
            this.cn_revision.DataPropertyName = "revision";
            this.cn_revision.FillWeight = 50F;
            this.cn_revision.HeaderText = "Rev.";
            this.cn_revision.Name = "cn_revision";
            this.cn_revision.ReadOnly = true;
            this.cn_revision.Width = 50;
            // 
            // cn_client
            // 
            this.cn_client.DataPropertyName = "client";
            this.cn_client.FillWeight = 120F;
            this.cn_client.HeaderText = "Customer";
            this.cn_client.Name = "cn_client";
            this.cn_client.ReadOnly = true;
            this.cn_client.Width = 120;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
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
            // cn_custart
            // 
            this.cn_custart.DataPropertyName = "custarticle";
            this.cn_custart.FillWeight = 150F;
            this.cn_custart.HeaderText = "Cust. article";
            this.cn_custart.Name = "cn_custart";
            this.cn_custart.ReadOnly = true;
            this.cn_custart.Width = 150;
            // 
            // cn_type
            // 
            this.cn_type.DataPropertyName = "type";
            this.cn_type.HeaderText = "Type";
            this.cn_type.Name = "cn_type";
            this.cn_type.ReadOnly = true;
            // 
            // cn_department
            // 
            this.cn_department.DataPropertyName = "department";
            this.cn_department.HeaderText = "Department";
            this.cn_department.Name = "cn_department";
            this.cn_department.ReadOnly = true;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 70F;
            this.cn_qty.HeaderText = "Quantity";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 70;
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
            // cn_reqdate
            // 
            this.cn_reqdate.DataPropertyName = "leadtime";
            this.cn_reqdate.HeaderText = "Lead time";
            this.cn_reqdate.Name = "cn_reqdate";
            this.cn_reqdate.ReadOnly = true;
            // 
            // cn_leadweek
            // 
            this.cn_leadweek.DataPropertyName = "leadweek";
            this.cn_leadweek.HeaderText = "Lead week";
            this.cn_leadweek.Name = "cn_leadweek";
            this.cn_leadweek.ReadOnly = true;
            // 
            // cn_state
            // 
            this.cn_state.DataPropertyName = "state";
            this.cn_state.FillWeight = 80F;
            this.cn_state.HeaderText = "State";
            this.cn_state.Name = "cn_state";
            this.cn_state.ReadOnly = true;
            this.cn_state.Width = 80;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price";
            this.cn_unitprice.Name = "cn_unitprice";
            this.cn_unitprice.ReadOnly = true;
            // 
            // cn_currency
            // 
            this.cn_currency.DataPropertyName = "currency";
            this.cn_currency.FillWeight = 50F;
            this.cn_currency.HeaderText = "Curr.";
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
            this.cn_comments.ReadOnly = true;
            this.cn_comments.Width = 150;
            // 
            // cn_contract
            // 
            this.cn_contract.DataPropertyName = "contract";
            this.cn_contract.FillWeight = 150F;
            this.cn_contract.HeaderText = "Contract";
            this.cn_contract.Name = "cn_contract";
            this.cn_contract.ReadOnly = true;
            this.cn_contract.Width = 150;
            // 
            // cn_pcbtext
            // 
            this.cn_pcbtext.DataPropertyName = "pcbtext";
            this.cn_pcbtext.FillWeight = 35F;
            this.cn_pcbtext.HeaderText = "PCB";
            this.cn_pcbtext.Name = "cn_pcbtext";
            this.cn_pcbtext.ReadOnly = true;
            this.cn_pcbtext.Width = 35;
            // 
            // chk_SMT
            // 
            this.chk_SMT.DataPropertyName = "SMT";
            this.chk_SMT.FalseValue = "0";
            this.chk_SMT.FillWeight = 35F;
            this.chk_SMT.HeaderText = "SMT";
            this.chk_SMT.IndeterminateValue = "1";
            this.chk_SMT.Name = "chk_SMT";
            this.chk_SMT.ReadOnly = true;
            this.chk_SMT.TrueValue = "-1";
            this.chk_SMT.Width = 35;
            // 
            // chk_THT
            // 
            this.chk_THT.DataPropertyName = "THT";
            this.chk_THT.FalseValue = "0";
            this.chk_THT.FillWeight = 35F;
            this.chk_THT.HeaderText = "THT";
            this.chk_THT.IndeterminateValue = "1";
            this.chk_THT.Name = "chk_THT";
            this.chk_THT.ReadOnly = true;
            this.chk_THT.TrueValue = "-1";
            this.chk_THT.Width = 35;
            // 
            // chk_FTA
            // 
            this.chk_FTA.DataPropertyName = "FTA";
            this.chk_FTA.FalseValue = "0";
            this.chk_FTA.FillWeight = 35F;
            this.chk_FTA.HeaderText = "FTA";
            this.chk_FTA.IndeterminateValue = "1";
            this.chk_FTA.Name = "chk_FTA";
            this.chk_FTA.ReadOnly = true;
            this.chk_FTA.TrueValue = "-1";
            this.chk_FTA.Width = 35;
            // 
            // chk_IPA
            // 
            this.chk_IPA.DataPropertyName = "IPA";
            this.chk_IPA.FalseValue = "0";
            this.chk_IPA.FillWeight = 35F;
            this.chk_IPA.HeaderText = "IPA";
            this.chk_IPA.IndeterminateValue = "1";
            this.chk_IPA.Name = "chk_IPA";
            this.chk_IPA.ReadOnly = true;
            this.chk_IPA.TrueValue = "-1";
            this.chk_IPA.Width = 35;
            // 
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "createdat";
            this.cn_createdat.HeaderText = "Created at";
            this.cn_createdat.Name = "cn_createdat";
            this.cn_createdat.ReadOnly = true;
            // 
            // cn_createdby
            // 
            this.cn_createdby.DataPropertyName = "createdby";
            this.cn_createdby.HeaderText = "Created by";
            this.cn_createdby.Name = "cn_createdby";
            this.cn_createdby.ReadOnly = true;
            // 
            // cn_expdate
            // 
            this.cn_expdate.DataPropertyName = "expdate";
            this.cn_expdate.HeaderText = "Exp. date";
            this.cn_expdate.Name = "cn_expdate";
            this.cn_expdate.ReadOnly = true;
            // 
            // cn_stateid
            // 
            this.cn_stateid.DataPropertyName = "stateid";
            this.cn_stateid.HeaderText = "State ID";
            this.cn_stateid.Name = "cn_stateid";
            this.cn_stateid.ReadOnly = true;
            this.cn_stateid.Visible = false;
            // 
            // chk_issent
            // 
            this.chk_issent.DataPropertyName = "issent";
            this.chk_issent.FalseValue = "0";
            this.chk_issent.HeaderText = "Confirmed";
            this.chk_issent.IndeterminateValue = "1";
            this.chk_issent.Name = "chk_issent";
            this.chk_issent.ReadOnly = true;
            this.chk_issent.TrueValue = "-1";
            // 
            // cn_sentdate
            // 
            this.cn_sentdate.DataPropertyName = "sentdate";
            this.cn_sentdate.HeaderText = "Sent date";
            this.cn_sentdate.Name = "cn_sentdate";
            this.cn_sentdate.ReadOnly = true;
            // 
            // cn_endcustomer
            // 
            this.cn_endcustomer.DataPropertyName = "endcustomer";
            this.cn_endcustomer.HeaderText = "End customer";
            this.cn_endcustomer.Name = "cn_endcustomer";
            this.cn_endcustomer.ReadOnly = true;
            // 
            // cn_paid
            // 
            this.cn_paid.DataPropertyName = "paid";
            this.cn_paid.HeaderText = "Paid";
            this.cn_paid.Name = "cn_paid";
            this.cn_paid.ReadOnly = true;
            // 
            // cn_conforder
            // 
            this.cn_conforder.DataPropertyName = "conforder";
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            this.cn_conforder.ReadOnly = true;
            // 
            // cn_blockdelivery
            // 
            this.cn_blockdelivery.DataPropertyName = "blockdelivery";
            this.cn_blockdelivery.FalseValue = "0";
            this.cn_blockdelivery.FillWeight = 40F;
            this.cn_blockdelivery.HeaderText = "Block delivery";
            this.cn_blockdelivery.IndeterminateValue = "1";
            this.cn_blockdelivery.Name = "cn_blockdelivery";
            this.cn_blockdelivery.ReadOnly = true;
            this.cn_blockdelivery.TrueValue = "-1";
            this.cn_blockdelivery.Width = 40;
            // 
            // cn_delivaddress
            // 
            this.cn_delivaddress.DataPropertyName = "delivaddress";
            this.cn_delivaddress.HeaderText = "Deliv. address";
            this.cn_delivaddress.Name = "cn_delivaddress";
            this.cn_delivaddress.ReadOnly = true;
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
            this.btn_AddNew,
            this.btn_Edit,
            this.btn_Copy,
            this.btn_Delete,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 432);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(799, 25);
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
            // btn_Copy
            // 
            this.btn_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.btn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(23, 22);
            this.btn_Copy.Text = "Copy quotation";
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
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
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1103, 131);
            this.kryptonDockableWorkspace1.TabIndex = 4;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
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
            // btn_RMConsulting
            // 
            this.btn_RMConsulting.Location = new System.Drawing.Point(579, 5);
            this.btn_RMConsulting.Name = "btn_RMConsulting";
            this.btn_RMConsulting.Size = new System.Drawing.Size(144, 39);
            this.btn_RMConsulting.TabIndex = 20;
            this.btn_RMConsulting.Values.Image = global::Odin.Global_Resourses.Blackbox;
            this.btn_RMConsulting.Values.Text = "RM consulting";
            this.btn_RMConsulting.Click += new System.EventHandler(this.btn_RMConsulting_Click);
            // 
            // frm_Quotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 642);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Quotations";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.TabText = "Quotations";
            this.Text = "Quotations";
            this.Load += new System.EventHandler(this.frm_Quotations_Load);
            this.Resize += new System.EventHandler(this.frm_Quotations_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
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
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Orders;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Process;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_History;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_General;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private CustomControls.NullableDateTimePicker txt_ReqDateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private CustomControls.NullableDateTimePicker txt_CreatDateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private CustomControls.NullableDateTimePicker txt_ReqDateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private CustomControls.NullableDateTimePicker txt_CreatDateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private CMB_Components.Departments.cmb_Department cmb_Department1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustArticle;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
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
        private System.Windows.Forms.ToolStripButton btn_AddNew;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton btn_Copy;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
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
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private System.Windows.Forms.ImageList imageListSmall;
        private CMB_Components.Week.cmb_Week cmb_Week1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Quotations.cmb_Quotations cmb_Quotations1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_PCB;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_PCBNeeds;
        private CustomControls.ctl_btnNum ctl_btnNum1;
        private CustomControls.ctl_btnNum ctl_btnNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reqdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_leadweek;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pcbtext;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_SMT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_THT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_FTA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_IPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_expdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stateid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_issent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_endcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_blockdelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_delivaddress;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RMConsulting;
    }
}