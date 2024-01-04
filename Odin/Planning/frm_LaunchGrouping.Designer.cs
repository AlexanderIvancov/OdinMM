namespace Odin.Planning
{
    partial class frm_LaunchGrouping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LaunchGrouping));
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_LaunchGroups1 = new Odin.CMB_Components.Launches.cmb_LaunchGroups();
            this.ds_Group = new System.Data.DataSet();
            this.dt_Group = new System.Data.DataTable();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.ds_List = new System.Data.DataSet();
            this.dt_List = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel19 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Users1 = new Odin.CMB_Components.Users.cmb_Users();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Group = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_glaunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_gartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_garticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_gqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_gcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_Group = new Odin.Global_Classes.SyncBindingSource();
            this.bn_Group = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Remove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.launchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_PrintRM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_MissingRM = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_reserverm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Start = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Group)).BeginInit();
            this.bn_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
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
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btn_Refresh);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.cmb_LaunchGroups1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel2.Size = new System.Drawing.Size(1125, 71);
            this.kryptonPanel2.TabIndex = 17;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Refresh.Location = new System.Drawing.Point(255, 15);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Refresh.Size = new System.Drawing.Size(47, 43);
            this.btn_Refresh.TabIndex = 292;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 25);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(81, 20);
            this.kryptonLabel2.TabIndex = 43;
            this.kryptonLabel2.Values.Text = "Group name:";
            // 
            // cmb_LaunchGroups1
            // 
            this.cmb_LaunchGroups1.Launches = "L201011-S2,L210211-9,LT18059-1";
            this.cmb_LaunchGroups1.LaunchGroup = "";
            this.cmb_LaunchGroups1.Location = new System.Drawing.Point(99, 25);
            this.cmb_LaunchGroups1.Name = "cmb_LaunchGroups1";
            this.cmb_LaunchGroups1.Size = new System.Drawing.Size(150, 20);
            this.cmb_LaunchGroups1.StageId = 0;
            this.cmb_LaunchGroups1.TabIndex = 0;
            // 
            // ds_Group
            // 
            this.ds_Group.DataSetName = "NewDataSet";
            this.ds_Group.Tables.AddRange(new System.Data.DataTable[] {
            this.dt_Group});
            // 
            // dt_Group
            // 
            this.dt_Group.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14});
            this.dt_Group.TableName = "dt_Group";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "id";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "launch";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "artid";
            this.dataColumn10.DataType = typeof(int);
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "article";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "customer";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "qty";
            this.dataColumn13.DataType = typeof(double);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "groupname";
            // 
            // ds_List
            // 
            this.ds_List.DataSetName = "NewDataSet";
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
            this.dataColumn7});
            this.dt_List.TableName = "dt_List";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "launch";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "artid";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "article";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "qty";
            this.dataColumn5.DataType = typeof(double);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "customer";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "groupname";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btn_MissingRM);
            this.kryptonPanel3.Controls.Add(this.btn_reserverm);
            this.kryptonPanel3.Controls.Add(this.btn_Start);
            this.kryptonPanel3.Controls.Add(this.btn_PrintRM);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel19);
            this.kryptonPanel3.Controls.Add(this.cmb_Users1);
            this.kryptonPanel3.Controls.Add(this.btn_Print);
            this.kryptonPanel3.Controls.Add(this.btn_OK);
            this.kryptonPanel3.Controls.Add(this.btn_Cancel);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 534);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel3.Size = new System.Drawing.Size(1125, 61);
            this.kryptonPanel3.TabIndex = 22;
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Location = new System.Drawing.Point(15, 10);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(187, 20);
            this.kryptonLabel19.TabIndex = 272;
            this.kryptonLabel19.Values.Text = "Assembling person for route list:";
            // 
            // cmb_Users1
            // 
            this.cmb_Users1.Location = new System.Drawing.Point(19, 31);
            this.cmb_Users1.Name = "cmb_Users1";
            this.cmb_Users1.Size = new System.Drawing.Size(283, 20);
            this.cmb_Users1.TabIndex = 271;
            this.cmb_Users1.User = "";
            this.cmb_Users1.UserId = 0;
            this.cmb_Users1.UserLogin = null;
            this.cmb_Users1.UserShortName = "";
            this.cmb_Users1.UserTN = "";
            // 
            // btn_Print
            // 
            this.btn_Print.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Print.Location = new System.Drawing.Point(815, 10);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(117, 41);
            this.btn_Print.TabIndex = 34;
            this.btn_Print.Values.Image = global::Odin.Global_Resourses.Print2;
            this.btn_Print.Values.Text = "Print route";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(932, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 41);
            this.btn_OK.TabIndex = 32;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cancel.Location = new System.Drawing.Point(1025, 10);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 41);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(601, 71);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            this.kryptonHeaderGroup2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.gv_Group);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.bn_Group);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(524, 463);
            this.kryptonHeaderGroup2.TabIndex = 23;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Grouping";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.ksirtet32x32;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "List of menu items";
            // 
            // gv_Group
            // 
            this.gv_Group.AllowUserToAddRows = false;
            this.gv_Group.AutoGenerateColumns = false;
            this.gv_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_gid,
            this.cn_glaunch,
            this.cn_gartid,
            this.cn_garticle,
            this.cn_gqty,
            this.cn_gcustomer});
            this.gv_Group.DataSource = this.bs_Group;
            this.gv_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Group.Location = new System.Drawing.Point(0, 0);
            this.gv_Group.Name = "gv_Group";
            this.gv_Group.RowHeadersWidth = 25;
            this.gv_Group.Size = new System.Drawing.Size(522, 380);
            this.gv_Group.TabIndex = 36;
            // 
            // cn_gid
            // 
            this.cn_gid.DataPropertyName = "id";
            this.cn_gid.HeaderText = "id";
            this.cn_gid.Name = "cn_gid";
            this.cn_gid.Visible = false;
            // 
            // cn_glaunch
            // 
            this.cn_glaunch.DataPropertyName = "launch";
            this.cn_glaunch.HeaderText = "Launch";
            this.cn_glaunch.Name = "cn_glaunch";
            // 
            // cn_gartid
            // 
            this.cn_gartid.DataPropertyName = "artid";
            this.cn_gartid.FillWeight = 80F;
            this.cn_gartid.HeaderText = "Art.ID";
            this.cn_gartid.Name = "cn_gartid";
            this.cn_gartid.Width = 80;
            // 
            // cn_garticle
            // 
            this.cn_garticle.DataPropertyName = "article";
            this.cn_garticle.FillWeight = 120F;
            this.cn_garticle.HeaderText = "Article";
            this.cn_garticle.Name = "cn_garticle";
            this.cn_garticle.Width = 120;
            // 
            // cn_gqty
            // 
            this.cn_gqty.DataPropertyName = "qty";
            this.cn_gqty.FillWeight = 80F;
            this.cn_gqty.HeaderText = "Qty";
            this.cn_gqty.Name = "cn_gqty";
            this.cn_gqty.Width = 80;
            // 
            // cn_gcustomer
            // 
            this.cn_gcustomer.DataPropertyName = "customer";
            this.cn_gcustomer.HeaderText = "Customer";
            this.cn_gcustomer.Name = "cn_gcustomer";
            // 
            // bs_Group
            // 
            this.bs_Group.DataMember = "dt_Group";
            this.bs_Group.DataSource = this.ds_Group;
            // 
            // bn_Group
            // 
            this.bn_Group.AddNewItem = null;
            this.bn_Group.BindingSource = this.bs_Group;
            this.bn_Group.CountItem = this.toolStripLabel2;
            this.bn_Group.DeleteItem = null;
            this.bn_Group.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Group.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Group.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator6});
            this.bn_Group.Location = new System.Drawing.Point(0, 380);
            this.bn_Group.MoveFirstItem = this.toolStripButton5;
            this.bn_Group.MoveLastItem = this.toolStripButton8;
            this.bn_Group.MoveNextItem = this.toolStripButton7;
            this.bn_Group.MovePreviousItem = this.toolStripButton6;
            this.bn_Group.Name = "bn_Group";
            this.bn_Group.PositionItem = this.toolStripTextBox2;
            this.bn_Group.Size = new System.Drawing.Size(522, 25);
            this.bn_Group.TabIndex = 35;
            this.bn_Group.Text = "bindingNavigator1";
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Remove);
            this.kryptonPanel1.Controls.Add(this.btn_Add);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(524, 71);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(77, 463);
            this.kryptonPanel1.TabIndex = 24;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(6, 199);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(63, 43);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Values.Image = global::Odin.Global_Resourses.back;
            this.btn_Remove.Values.Text = "";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 150);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(63, 43);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Values.Image = global::Odin.Global_Resourses.forward;
            this.btn_Add.Values.Text = "";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 71);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(524, 463);
            this.kryptonHeaderGroup1.TabIndex = 25;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Launches list";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.launch;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Launches list";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AutoGenerateColumns = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_launch,
            this.cn_artid,
            this.cn_article,
            this.cn_qty,
            this.cn_customer,
            this.idDataGridViewTextBoxColumn,
            this.launchDataGridViewTextBoxColumn,
            this.artidDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.groupnameDataGridViewTextBoxColumn});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.DataSource = this.bs_List;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.MultiSelect = false;
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(522, 380);
            this.gv_List.TabIndex = 35;
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
            // cn_launch
            // 
            this.cn_launch.DataPropertyName = "launch";
            this.cn_launch.HeaderText = "Launch";
            this.cn_launch.Name = "cn_launch";
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 80F;
            this.cn_artid.HeaderText = "Art.ID";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.Width = 80;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 120F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.Width = 120;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 80F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 80;
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // launchDataGridViewTextBoxColumn
            // 
            this.launchDataGridViewTextBoxColumn.DataPropertyName = "launch";
            this.launchDataGridViewTextBoxColumn.HeaderText = "launch";
            this.launchDataGridViewTextBoxColumn.Name = "launchDataGridViewTextBoxColumn";
            // 
            // artidDataGridViewTextBoxColumn
            // 
            this.artidDataGridViewTextBoxColumn.DataPropertyName = "artid";
            this.artidDataGridViewTextBoxColumn.HeaderText = "artid";
            this.artidDataGridViewTextBoxColumn.Name = "artidDataGridViewTextBoxColumn";
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // groupnameDataGridViewTextBoxColumn
            // 
            this.groupnameDataGridViewTextBoxColumn.DataPropertyName = "groupname";
            this.groupnameDataGridViewTextBoxColumn.HeaderText = "groupname";
            this.groupnameDataGridViewTextBoxColumn.Name = "groupnameDataGridViewTextBoxColumn";
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
            this.bn_List.Location = new System.Drawing.Point(0, 380);
            this.bn_List.MoveFirstItem = this.toolStripButton1;
            this.bn_List.MoveLastItem = this.toolStripButton4;
            this.bn_List.MoveNextItem = this.toolStripButton3;
            this.bn_List.MovePreviousItem = this.toolStripButton2;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.toolStripTextBox1;
            this.bn_List.Size = new System.Drawing.Size(522, 25);
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
            // btn_PrintRM
            // 
            this.btn_PrintRM.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_PrintRM.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_PrintRM.Location = new System.Drawing.Point(698, 10);
            this.btn_PrintRM.Name = "btn_PrintRM";
            this.btn_PrintRM.Size = new System.Drawing.Size(117, 41);
            this.btn_PrintRM.TabIndex = 273;
            this.btn_PrintRM.Values.Image = global::Odin.Global_Resourses.Print2;
            this.btn_PrintRM.Values.Text = "Print RM";
            this.btn_PrintRM.Click += new System.EventHandler(this.btn_PrintRM_Click);
            // 
            // btn_MissingRM
            // 
            this.btn_MissingRM.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_MissingRM.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MissingRM.Location = new System.Drawing.Point(356, 10);
            this.btn_MissingRM.Name = "btn_MissingRM";
            this.btn_MissingRM.Size = new System.Drawing.Size(115, 41);
            this.btn_MissingRM.TabIndex = 276;
            this.btn_MissingRM.Values.Image = global::Odin.Global_Resourses.messagebox_warning;
            this.btn_MissingRM.Values.Text = "Missing RM";
            this.btn_MissingRM.Click += new System.EventHandler(this.btn_MissingRM_Click);
            // 
            // btn_reserverm
            // 
            this.btn_reserverm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_reserverm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_reserverm.Location = new System.Drawing.Point(471, 10);
            this.btn_reserverm.Name = "btn_reserverm";
            this.btn_reserverm.Size = new System.Drawing.Size(134, 41);
            this.btn_reserverm.TabIndex = 275;
            this.btn_reserverm.Values.Image = global::Odin.Global_Resourses.snowflake24x24;
            this.btn_reserverm.Values.Text = "RM reservation";
            this.btn_reserverm.Click += new System.EventHandler(this.btn_reserverm_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Start.Location = new System.Drawing.Point(605, 10);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(93, 41);
            this.btn_Start.TabIndex = 274;
            this.btn_Start.Values.Image = global::Odin.Global_Resourses.player_play;
            this.btn_Start.Values.Text = "Start";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // frm_LaunchGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 595);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_LaunchGrouping";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launch RM reservation";
            this.Load += new System.EventHandler(this.frm_LaunchRMReservation_Load);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Group)).EndInit();
            this.bn_Group.ResumeLayout(false);
            this.bn_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
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
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion
        private Global_Classes.SyncBindingSource bs_List;
        private Global_Classes.SyncBindingSource bs_Group;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private CMB_Components.Launches.cmb_LaunchGroups cmb_LaunchGroups1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private System.Data.DataSet ds_List;
        private System.Data.DataTable dt_List;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataSet ds_Group;
        private System.Data.DataTable dt_Group;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Group;
        private System.Windows.Forms.BindingNavigator bn_Group;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Remove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_glaunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_gartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_garticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_gqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_gcustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private CMB_Components.Users.cmb_Users cmb_Users1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn launchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupnameDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_MissingRM;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_reserverm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Start;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_PrintRM;
    }
}