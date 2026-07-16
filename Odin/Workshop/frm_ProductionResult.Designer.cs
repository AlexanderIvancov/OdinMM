namespace Odin.Workshop
{
    partial class frm_ProductionResult
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

        public Main _frm_Main;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProductionResult));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_ShowParameter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Finish = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.cmb_SalesOrdersWithLines1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrdersWithLines();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lbl_Serial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Serial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.lbl_Line = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Lines = new Odin.CMB_Components.Common.cmb_Common();
            this.chk_ConcOperations = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_Sum = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.txt_DateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_DateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lbl_Till = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_From = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Worker = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Worker = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Launches1 = new Odin.CMB_Components.Launches.cmb_Launches();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dn_Pages = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.pg_Workers = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_operno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isapproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_islast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_analogs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_teortime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_teortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_parameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_prodtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_prodplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_workerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Sum = new System.Windows.Forms.ToolStripTextBox();
            this.pg_Machines = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Machines = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_macid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macheadid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mactopbot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macpcbsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macfeeder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macprevlabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macnewlabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macreplacedat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macreplacedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mactermprofiledate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mactermprofileby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macpastedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macpasteby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macmounterat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macmounterby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macovencheckat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_macovencheckby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_macLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_macFilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_macSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_macFilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_macFilterExSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_macRemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_macCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_macAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_Machines = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_macExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txt_MachSum = new System.Windows.Forms.ToolStripTextBox();
            this.pg_Repairs = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonHeaderGroup5 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Repairs = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.mnu_rLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_rFilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_rSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_rFilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_rFilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_rRemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_rCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_rAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_Repairs = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcelRepairs = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.kryptonHeaderGroup4 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_Legend = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Materials = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mlabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_matartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_matarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mlaunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_martid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_marticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_msecname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mwhen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_manufbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_incomedoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_mLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_mFilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_mSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_mFilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_mFilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_mRemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_mCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_mAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_Materials = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_mExcel = new System.Windows.Forms.ToolStripButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.bs_Materials = new Odin.Global_Classes.SyncBindingSource();
            this.miniToolStrip = new System.Windows.Forms.BindingNavigator(this.components);
            this.bs_Machines = new Odin.Global_Classes.SyncBindingSource();
            this.bs_Repairs = new Odin.Global_Classes.SyncBindingSource();
            this.cn_rid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rlaunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rsecname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rprodtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r301 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r302 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r303 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r304 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r305 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r306 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r307 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r311 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r312 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_314 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_r316 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_399 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rprodplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rwhen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rheadid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rworkerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dn_Pages)).BeginInit();
            this.dn_Pages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Workers)).BeginInit();
            this.pg_Workers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Machines)).BeginInit();
            this.pg_Machines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Machines)).BeginInit();
            this.mnu_macLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Machines)).BeginInit();
            this.bn_Machines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Repairs)).BeginInit();
            this.pg_Repairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup5.Panel)).BeginInit();
            this.kryptonHeaderGroup5.Panel.SuspendLayout();
            this.kryptonHeaderGroup5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Repairs)).BeginInit();
            this.mnu_rLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Repairs)).BeginInit();
            this.bn_Repairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup4.Panel)).BeginInit();
            this.kryptonHeaderGroup4.Panel.SuspendLayout();
            this.kryptonHeaderGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Materials)).BeginInit();
            this.mnu_mLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Materials)).BeginInit();
            this.bn_Materials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Materials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Machines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Repairs)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_ShowParameter);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_Finish);
            this.kryptonPanel1.Controls.Add(this.btn_Edit);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel1.Size = new System.Drawing.Size(1253, 49);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // btn_ShowParameter
            // 
            this.btn_ShowParameter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ShowParameter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_ShowParameter.Location = new System.Drawing.Point(389, 5);
            this.btn_ShowParameter.Name = "btn_ShowParameter";
            this.btn_ShowParameter.Size = new System.Drawing.Size(151, 39);
            this.btn_ShowParameter.TabIndex = 237;
            this.btn_ShowParameter.Values.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.btn_ShowParameter.Values.Text = "Show parameters";
            this.btn_ShowParameter.Click += new System.EventHandler(this.btn_ShowParameter_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Cancel.Location = new System.Drawing.Point(261, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(128, 39);
            this.btn_Cancel.TabIndex = 236;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel_Big;
            this.btn_Cancel.Values.Text = "Cancel shift";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Finish.Location = new System.Drawing.Point(133, 5);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(128, 39);
            this.btn_Finish.TabIndex = 235;
            this.btn_Finish.Values.Image = global::Odin.Global_Resourses.Finish_small;
            this.btn_Finish.Values.Text = "Finish shift";
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Edit.Location = new System.Drawing.Point(5, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(128, 39);
            this.btn_Edit.TabIndex = 234;
            this.btn_Edit.Values.Image = global::Odin.Global_Resourses.edit;
            this.btn_Edit.Values.Text = "Edit shift";
            this.btn_Edit.Click += new System.EventHandler(this.btn_EditHeader_Click);
            // 
            // mni_FilterExcludingSel
            // 
            this.mni_FilterExcludingSel.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSel.Name = "mni_FilterExcludingSel";
            this.mni_FilterExcludingSel.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSel.Text = "Filter excluding selection";
            this.mni_FilterExcludingSel.Click += new System.EventHandler(this.mni_FilterExcludingSel_Click);
            // 
            // mni_FilterBy
            // 
            this.mni_FilterBy.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterBy.Name = "mni_FilterBy";
            this.mni_FilterBy.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterBy.Text = "Filter by selection";
            this.mni_FilterBy.Click += new System.EventHandler(this.mni_FilterBy_Click);
            // 
            // mni_Search
            // 
            this.mni_Search.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_Search.Name = "mni_Search";
            this.mni_Search.Size = new System.Drawing.Size(210, 22);
            this.mni_Search.Text = "Search for record";
            this.mni_Search.Click += new System.EventHandler(this.mni_Search_Click);
            // 
            // mni_FilterFor
            // 
            this.mni_FilterFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterFor.Name = "mni_FilterFor";
            this.mni_FilterFor.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterFor.TextChanged += new System.EventHandler(this.mni_FilterFor_TextChanged);
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
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "E19B0EA24B3C4C4B83BBA9440FB95A94";
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabHighProfile;
            this.kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "3603EBC349EA4AA52F8724469FC85DA3";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1253, 47);
            this.kryptonDockableWorkspace1.TabIndex = 4;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // cmb_SalesOrdersWithLines1
            // 
            this.cmb_SalesOrdersWithLines1.ArticleId = 0;
            this.cmb_SalesOrdersWithLines1.BatchId = 0;
            this.cmb_SalesOrdersWithLines1.Location = new System.Drawing.Point(94, 130);
            this.cmb_SalesOrdersWithLines1.Name = "cmb_SalesOrdersWithLines1";
            this.cmb_SalesOrdersWithLines1.QtyInCO = 0D;
            this.cmb_SalesOrdersWithLines1.SalesOrder = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            this.cmb_SalesOrdersWithLines1.SalesOrderLine = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            this.cmb_SalesOrdersWithLines1.Size = new System.Drawing.Size(199, 21);
            this.cmb_SalesOrdersWithLines1.TabIndex = 232;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(6, 194);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel4.TabIndex = 220;
            this.kryptonLabel4.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(94, 194);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(174, 20);
            this.cmb_Types1.TabIndex = 218;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(8, 148);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel3.TabIndex = 217;
            this.kryptonLabel3.Values.Text = "Article:";
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
            this.cmb_Articles1.Location = new System.Drawing.Point(9, 171);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(284, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 216;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(8, 76);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 215;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(9, 106);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 214;
            this.kryptonLabel2.Values.Text = "Batch:";
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny4.UniqueName = "00654834D5824273E0820F141B99704A";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // lbl_Serial
            // 
            this.lbl_Serial.Location = new System.Drawing.Point(9, 50);
            this.lbl_Serial.Name = "lbl_Serial";
            this.lbl_Serial.Size = new System.Drawing.Size(124, 20);
            this.lbl_Serial.TabIndex = 287;
            this.lbl_Serial.Values.Text = "Serial NR of product:";
            this.lbl_Serial.Visible = false;
            // 
            // txt_Serial
            // 
            this.txt_Serial.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_Serial.Location = new System.Drawing.Point(134, 50);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(159, 23);
            this.txt_Serial.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Serial.TabIndex = 286;
            this.txt_Serial.Visible = false;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Line);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Lines);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_ConcOperations);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Sum);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_DateTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_DateFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Till);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_From);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Worker);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Worker);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Launches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Serial);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Serial);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_SalesOrdersWithLines1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Types1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Batches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.dn_Pages);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.kryptonHeaderGroup2);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1253, 705);
            this.kryptonSplitContainer2.SplitterDistance = 303;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // lbl_Line
            // 
            this.lbl_Line.Location = new System.Drawing.Point(5, 220);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(35, 20);
            this.lbl_Line.TabIndex = 301;
            this.lbl_Line.Values.Text = "Line:";
            this.lbl_Line.Visible = false;
            // 
            // cmb_Lines
            // 
            this.cmb_Lines.IsEmptyColor = false;
            this.cmb_Lines.Location = new System.Drawing.Point(94, 221);
            this.cmb_Lines.Name = "cmb_Lines";
            this.cmb_Lines.OrderBy = "name";
            this.cmb_Lines.sCurrentValue = "";
            this.cmb_Lines.SelectedValue = 0;
            this.cmb_Lines.sID_Filled = "id";
            this.cmb_Lines.Size = new System.Drawing.Size(199, 20);
            this.cmb_Lines.sTable = "PROD_Lines";
            this.cmb_Lines.sText_Filled = "name";
            this.cmb_Lines.sTitle = "SMT Lines";
            this.cmb_Lines.TabIndex = 300;
            this.cmb_Lines.Visible = false;
            // 
            // chk_ConcOperations
            // 
            this.chk_ConcOperations.Location = new System.Drawing.Point(94, 299);
            this.chk_ConcOperations.Name = "chk_ConcOperations";
            this.chk_ConcOperations.Size = new System.Drawing.Size(154, 20);
            this.chk_ConcOperations.TabIndex = 299;
            this.chk_ConcOperations.Values.Text = "Concatenate operations";
            // 
            // chk_Sum
            // 
            this.chk_Sum.Location = new System.Drawing.Point(94, 273);
            this.chk_Sum.Name = "chk_Sum";
            this.chk_Sum.Size = new System.Drawing.Size(74, 20);
            this.chk_Sum.TabIndex = 298;
            this.chk_Sum.Values.Text = "Sum only";
            // 
            // txt_DateTill
            // 
            this.txt_DateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_DateTill.CalendarShowWeekNumbers = true;
            this.txt_DateTill.CustomFormat = null;
            this.txt_DateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateTill.Location = new System.Drawing.Point(189, 246);
            this.txt_DateTill.Name = "txt_DateTill";
            this.txt_DateTill.NullValue = " ";
            this.txt_DateTill.Size = new System.Drawing.Size(104, 21);
            this.txt_DateTill.TabIndex = 297;
            this.txt_DateTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_DateTill_DropDown);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny2.UniqueName = "6A2751F9284C45EEA28C814570A892DD";
            // 
            // txt_DateFrom
            // 
            this.txt_DateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_DateFrom.CalendarShowWeekNumbers = true;
            this.txt_DateFrom.CustomFormat = null;
            this.txt_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateFrom.Location = new System.Drawing.Point(53, 246);
            this.txt_DateFrom.Name = "txt_DateFrom";
            this.txt_DateFrom.NullValue = " ";
            this.txt_DateFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_DateFrom.TabIndex = 296;
            this.txt_DateFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_DateFrom_DropDown);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            // 
            // lbl_Till
            // 
            this.lbl_Till.Location = new System.Drawing.Point(160, 247);
            this.lbl_Till.Name = "lbl_Till";
            this.lbl_Till.Size = new System.Drawing.Size(26, 20);
            this.lbl_Till.TabIndex = 295;
            this.lbl_Till.Values.Text = "till:";
            // 
            // lbl_From
            // 
            this.lbl_From.Location = new System.Drawing.Point(6, 246);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(41, 20);
            this.lbl_From.TabIndex = 294;
            this.lbl_From.Values.Text = "From:";
            // 
            // lbl_Worker
            // 
            this.lbl_Worker.Location = new System.Drawing.Point(6, 220);
            this.lbl_Worker.Name = "lbl_Worker";
            this.lbl_Worker.Size = new System.Drawing.Size(53, 20);
            this.lbl_Worker.TabIndex = 293;
            this.lbl_Worker.Values.Text = "Worker:";
            // 
            // cmb_Worker
            // 
            this.cmb_Worker.IsEmptyColor = false;
            this.cmb_Worker.Location = new System.Drawing.Point(94, 220);
            this.cmb_Worker.Name = "cmb_Worker";
            this.cmb_Worker.OrderBy = "surname";
            this.cmb_Worker.sCurrentValue = "";
            this.cmb_Worker.SelectedValue = 0;
            this.cmb_Worker.sID_Filled = "id";
            this.cmb_Worker.Size = new System.Drawing.Size(199, 20);
            this.cmb_Worker.sTable = "vw_Workers";
            this.cmb_Worker.sText_Filled = "worker";
            this.cmb_Worker.sTitle = "Workers";
            this.cmb_Worker.TabIndex = 292;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(9, 82);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel6.TabIndex = 291;
            this.kryptonLabel6.Values.Text = "Launch:";
            // 
            // cmb_Launches1
            // 
            this.cmb_Launches1.Article = "";
            this.cmb_Launches1.ArticleId = 0;
            this.cmb_Launches1.Batch = "";
            this.cmb_Launches1.BatchId = 0;
            this.cmb_Launches1.ConfOrder = "";
            this.cmb_Launches1.Customer = "";
            this.cmb_Launches1.EndDate = "";
            this.cmb_Launches1.IsActive = 0;
            this.cmb_Launches1.Launch = "";
            this.cmb_Launches1.LaunchId = 0;
            this.cmb_Launches1.Location = new System.Drawing.Point(94, 82);
            this.cmb_Launches1.Name = "cmb_Launches1";
            this.cmb_Launches1.ParentBatchId = 0;
            this.cmb_Launches1.Qty = 0D;
            this.cmb_Launches1.SecName = null;
            this.cmb_Launches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Launches1.StageId = 0;
            this.cmb_Launches1.StartDate = null;
            this.cmb_Launches1.TabIndex = 290;
            // 
            // cmb_Batches1
            // 
            this.cmb_Batches1.ActiveOnly = 0;
            this.cmb_Batches1.Article = null;
            this.cmb_Batches1.ArticleId = 0;
            this.cmb_Batches1.Batch = "";
            this.cmb_Batches1.BatchId = 0;
            this.cmb_Batches1.Comments = "";
            this.cmb_Batches1.ConfOrder = "";
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.CustArticle = "";
            this.cmb_Batches1.Customer = "";
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.IsGroup = 0;
            this.cmb_Batches1.IsProject = 0;
            this.cmb_Batches1.IsQuote = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(94, 106);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 213;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(9, 131);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel1.TabIndex = 212;
            this.kryptonLabel1.Values.Text = "Conf. order:";
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(303, 42);
            this.kryptonHeader1.TabIndex = 2;
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
            this.pg_Workers,
            this.pg_Machines,
            this.pg_Repairs});
            this.dn_Pages.SelectedIndex = 0;
            this.dn_Pages.Size = new System.Drawing.Size(945, 368);
            this.dn_Pages.TabIndex = 11;
            this.dn_Pages.Text = "kryptonDockableNavigator1";
            this.dn_Pages.Click += new System.EventHandler(this.dn_Pages_Click);
            // 
            // pg_Workers
            // 
            this.pg_Workers.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Workers.Controls.Add(this.kryptonHeaderGroup1);
            this.pg_Workers.Flags = 65534;
            this.pg_Workers.LastVisibleSet = true;
            this.pg_Workers.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Workers.Name = "pg_Workers";
            this.pg_Workers.Size = new System.Drawing.Size(943, 341);
            this.pg_Workers.Text = "Worker\'s processing";
            this.pg_Workers.ToolTipTitle = "Page ToolTip";
            this.pg_Workers.UniqueName = "5AC48C67E25A403CC3BEFE848DA97E15";
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
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(943, 341);
            this.kryptonHeaderGroup1.TabIndex = 11;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Worker\'s processing result";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.session_idle_time;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_sn,
            this.cn_operno,
            this.cn_batch,
            this.cn_launch,
            this.cn_qty,
            this.cn_artid,
            this.cn_article,
            this.cn_secname,
            this.cn_dconforder,
            this.cn_when,
            this.cn_worker,
            this.cn_isapproved,
            this.cn_islast,
            this.cn_analogs,
            this.cn_teortime,
            this.cn_teortotal,
            this.cn_parameters,
            this.cn_prodtime,
            this.cn_prodplace,
            this.cn_headid,
            this.cn_workerid});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(941, 276);
            this.gv_List.TabIndex = 8;
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
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
            // cn_sn
            // 
            this.cn_sn.DataPropertyName = "sn";
            this.cn_sn.FillWeight = 120F;
            this.cn_sn.HeaderText = "Serial NO";
            this.cn_sn.Name = "cn_sn";
            this.cn_sn.ReadOnly = true;
            this.cn_sn.Width = 120;
            // 
            // cn_operno
            // 
            this.cn_operno.DataPropertyName = "operno";
            this.cn_operno.HeaderText = "Oper. NO";
            this.cn_operno.Name = "cn_operno";
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.ReadOnly = true;
            // 
            // cn_launch
            // 
            this.cn_launch.DataPropertyName = "launch";
            this.cn_launch.HeaderText = "Launch";
            this.cn_launch.Name = "cn_launch";
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 70F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 70;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 60F;
            this.cn_artid.HeaderText = "Art. ID";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.Width = 60;
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
            // cn_secname
            // 
            this.cn_secname.DataPropertyName = "secname";
            this.cn_secname.HeaderText = "Sec. name";
            this.cn_secname.Name = "cn_secname";
            // 
            // cn_dconforder
            // 
            this.cn_dconforder.DataPropertyName = "conforder";
            this.cn_dconforder.HeaderText = "Conf. order";
            this.cn_dconforder.Name = "cn_dconforder";
            this.cn_dconforder.ReadOnly = true;
            // 
            // cn_when
            // 
            this.cn_when.DataPropertyName = "when";
            this.cn_when.HeaderText = "When";
            this.cn_when.Name = "cn_when";
            // 
            // cn_worker
            // 
            this.cn_worker.DataPropertyName = "worker";
            this.cn_worker.FillWeight = 180F;
            this.cn_worker.HeaderText = "Worker";
            this.cn_worker.Name = "cn_worker";
            this.cn_worker.Width = 180;
            // 
            // cn_isapproved
            // 
            this.cn_isapproved.DataPropertyName = "isapproved";
            this.cn_isapproved.HeaderText = "isapproved";
            this.cn_isapproved.Name = "cn_isapproved";
            this.cn_isapproved.Visible = false;
            // 
            // cn_islast
            // 
            this.cn_islast.DataPropertyName = "islast";
            this.cn_islast.HeaderText = "Is last";
            this.cn_islast.Name = "cn_islast";
            this.cn_islast.Visible = false;
            // 
            // cn_analogs
            // 
            this.cn_analogs.DataPropertyName = "analog";
            this.cn_analogs.HeaderText = "Analog";
            this.cn_analogs.Name = "cn_analogs";
            // 
            // cn_teortime
            // 
            this.cn_teortime.DataPropertyName = "teortime";
            this.cn_teortime.HeaderText = "Teor. time";
            this.cn_teortime.Name = "cn_teortime";
            // 
            // cn_teortotal
            // 
            this.cn_teortotal.DataPropertyName = "teortotal";
            this.cn_teortotal.HeaderText = "Teor. total";
            this.cn_teortotal.Name = "cn_teortotal";
            // 
            // cn_parameters
            // 
            this.cn_parameters.DataPropertyName = "parameters";
            this.cn_parameters.HeaderText = "Check parameters";
            this.cn_parameters.Name = "cn_parameters";
            // 
            // cn_prodtime
            // 
            this.cn_prodtime.DataPropertyName = "prodtime";
            this.cn_prodtime.HeaderText = "Prod. time";
            this.cn_prodtime.Name = "cn_prodtime";
            // 
            // cn_prodplace
            // 
            this.cn_prodplace.DataPropertyName = "prodplace";
            this.cn_prodplace.HeaderText = "Prod. place";
            this.cn_prodplace.Name = "cn_prodplace";
            // 
            // cn_headid
            // 
            this.cn_headid.DataPropertyName = "headid";
            this.cn_headid.HeaderText = "headid";
            this.cn_headid.Name = "cn_headid";
            this.cn_headid.Visible = false;
            // 
            // cn_workerid
            // 
            this.cn_workerid.DataPropertyName = "workerid";
            this.cn_workerid.HeaderText = "workerid";
            this.cn_workerid.Name = "cn_workerid";
            this.cn_workerid.Visible = false;
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
            this.btn_Excel,
            this.toolStripLabel2,
            this.txt_Sum});
            this.bn_List.Location = new System.Drawing.Point(0, 276);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(941, 25);
            this.bn_List.TabIndex = 3;
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
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel2.Text = "Selected sum";
            // 
            // txt_Sum
            // 
            this.txt_Sum.Name = "txt_Sum";
            this.txt_Sum.Size = new System.Drawing.Size(100, 25);
            // 
            // pg_Machines
            // 
            this.pg_Machines.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Machines.Controls.Add(this.kryptonHeaderGroup3);
            this.pg_Machines.Flags = 65534;
            this.pg_Machines.LastVisibleSet = true;
            this.pg_Machines.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Machines.Name = "pg_Machines";
            this.pg_Machines.Size = new System.Drawing.Size(943, 341);
            this.pg_Machines.Text = "SMT processing";
            this.pg_Machines.ToolTipTitle = "Page ToolTip";
            this.pg_Machines.UniqueName = "7BF16B8200CE446DD6A546007AED1D83";
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.gv_Machines);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.bn_Machines);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(943, 341);
            this.kryptonHeaderGroup3.TabIndex = 12;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "SMT processing result";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::Odin.Global_Resourses.pci;
            this.kryptonHeaderGroup3.ValuesSecondary.Heading = "";
            // 
            // gv_Machines
            // 
            this.gv_Machines.AllowUserToAddRows = false;
            this.gv_Machines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Machines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_macid,
            this.cn_macheadid,
            this.dataGridViewTextBoxColumn5,
            this.cn_macline,
            this.cn_mactopbot,
            this.cn_macpcbsn,
            this.cn_macfeeder,
            this.cn_macprevlabel,
            this.cn_macnewlabel,
            this.cn_macreplacedat,
            this.cn_macreplacedby,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.cn_mactermprofiledate,
            this.cn_mactermprofileby,
            this.cn_macpastedate,
            this.cn_macpasteby,
            this.cn_macmounterat,
            this.cn_macmounterby,
            this.cn_macovencheckat,
            this.cn_macovencheckby});
            this.gv_Machines.ContextMenuStrip = this.mnu_macLines;
            this.gv_Machines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Machines.Location = new System.Drawing.Point(0, 0);
            this.gv_Machines.Name = "gv_Machines";
            this.gv_Machines.RowHeadersWidth = 25;
            this.gv_Machines.Size = new System.Drawing.Size(941, 276);
            this.gv_Machines.TabIndex = 8;
            // 
            // cn_macid
            // 
            this.cn_macid.DataPropertyName = "id";
            this.cn_macid.FillWeight = 5F;
            this.cn_macid.HeaderText = "id";
            this.cn_macid.Name = "cn_macid";
            this.cn_macid.ReadOnly = true;
            this.cn_macid.Visible = false;
            this.cn_macid.Width = 5;
            // 
            // cn_macheadid
            // 
            this.cn_macheadid.DataPropertyName = "headid";
            this.cn_macheadid.HeaderText = "headid";
            this.cn_macheadid.Name = "cn_macheadid";
            this.cn_macheadid.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "launch";
            this.dataGridViewTextBoxColumn5.HeaderText = "Launch";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cn_macline
            // 
            this.cn_macline.DataPropertyName = "line";
            this.cn_macline.FillWeight = 50F;
            this.cn_macline.HeaderText = "Line";
            this.cn_macline.Name = "cn_macline";
            this.cn_macline.Width = 50;
            // 
            // cn_mactopbot
            // 
            this.cn_mactopbot.DataPropertyName = "topbot";
            this.cn_mactopbot.FillWeight = 50F;
            this.cn_mactopbot.HeaderText = "TOP/BOT";
            this.cn_mactopbot.Name = "cn_mactopbot";
            this.cn_mactopbot.Width = 50;
            // 
            // cn_macpcbsn
            // 
            this.cn_macpcbsn.DataPropertyName = "pcbsn";
            this.cn_macpcbsn.FillWeight = 120F;
            this.cn_macpcbsn.HeaderText = "PCB S/N.";
            this.cn_macpcbsn.Name = "cn_macpcbsn";
            this.cn_macpcbsn.ReadOnly = true;
            this.cn_macpcbsn.Width = 120;
            // 
            // cn_macfeeder
            // 
            this.cn_macfeeder.DataPropertyName = "feeder";
            this.cn_macfeeder.HeaderText = "Feeder";
            this.cn_macfeeder.Name = "cn_macfeeder";
            // 
            // cn_macprevlabel
            // 
            this.cn_macprevlabel.DataPropertyName = "prevlabel";
            this.cn_macprevlabel.HeaderText = "Prev. label";
            this.cn_macprevlabel.Name = "cn_macprevlabel";
            // 
            // cn_macnewlabel
            // 
            this.cn_macnewlabel.DataPropertyName = "newlabel";
            this.cn_macnewlabel.HeaderText = "New label";
            this.cn_macnewlabel.Name = "cn_macnewlabel";
            // 
            // cn_macreplacedat
            // 
            this.cn_macreplacedat.DataPropertyName = "replacedat";
            this.cn_macreplacedat.HeaderText = "Replaced at";
            this.cn_macreplacedat.Name = "cn_macreplacedat";
            // 
            // cn_macreplacedby
            // 
            this.cn_macreplacedby.DataPropertyName = "replacedby";
            this.cn_macreplacedby.FillWeight = 150F;
            this.cn_macreplacedby.HeaderText = "Replaced by";
            this.cn_macreplacedby.Name = "cn_macreplacedby";
            this.cn_macreplacedby.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "batch";
            this.dataGridViewTextBoxColumn4.HeaderText = "Batch";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "artid";
            this.dataGridViewTextBoxColumn7.FillWeight = 60F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Art. ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn8.FillWeight = 120F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Article";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "secname";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sec. name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "conforder";
            this.dataGridViewTextBoxColumn10.HeaderText = "Conf. order";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // cn_mactermprofiledate
            // 
            this.cn_mactermprofiledate.DataPropertyName = "termprofiledate";
            this.cn_mactermprofiledate.HeaderText = "Termprofile date";
            this.cn_mactermprofiledate.Name = "cn_mactermprofiledate";
            // 
            // cn_mactermprofileby
            // 
            this.cn_mactermprofileby.DataPropertyName = "termprofileby";
            this.cn_mactermprofileby.HeaderText = "Termprofile by";
            this.cn_mactermprofileby.Name = "cn_mactermprofileby";
            // 
            // cn_macpastedate
            // 
            this.cn_macpastedate.DataPropertyName = "pastedate";
            this.cn_macpastedate.HeaderText = "Paste check date";
            this.cn_macpastedate.Name = "cn_macpastedate";
            // 
            // cn_macpasteby
            // 
            this.cn_macpasteby.DataPropertyName = "pasteby";
            this.cn_macpasteby.HeaderText = "Paste check by";
            this.cn_macpasteby.Name = "cn_macpasteby";
            // 
            // cn_macmounterat
            // 
            this.cn_macmounterat.DataPropertyName = "mounterat";
            this.cn_macmounterat.HeaderText = "Mounter program date";
            this.cn_macmounterat.Name = "cn_macmounterat";
            // 
            // cn_macmounterby
            // 
            this.cn_macmounterby.DataPropertyName = "mounterby";
            this.cn_macmounterby.HeaderText = "Mounter program by";
            this.cn_macmounterby.Name = "cn_macmounterby";
            // 
            // cn_macovencheckat
            // 
            this.cn_macovencheckat.DataPropertyName = "ovencheckat";
            this.cn_macovencheckat.HeaderText = "Placement check at";
            this.cn_macovencheckat.Name = "cn_macovencheckat";
            // 
            // cn_macovencheckby
            // 
            this.cn_macovencheckby.DataPropertyName = "ovencheckby";
            this.cn_macovencheckby.HeaderText = "Placement check by";
            this.cn_macovencheckby.Name = "cn_macovencheckby";
            // 
            // mnu_macLines
            // 
            this.mnu_macLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_macLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_macFilterFor,
            this.mni_macSearch,
            this.mni_macFilterBy,
            this.mni_macFilterExSelection,
            this.mni_macRemoveFilter,
            this.mni_macCopy,
            this.toolStripSeparator9,
            this.mni_macAdmin});
            this.mnu_macLines.Name = "mnu_Requests";
            this.mnu_macLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_macLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_macLines_Opening);
            // 
            // mni_macFilterFor
            // 
            this.mni_macFilterFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_macFilterFor.Name = "mni_macFilterFor";
            this.mni_macFilterFor.Size = new System.Drawing.Size(150, 23);
            this.mni_macFilterFor.TextChanged += new System.EventHandler(this.mni_macFilterFor_TextChanged);
            // 
            // mni_macSearch
            // 
            this.mni_macSearch.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_macSearch.Name = "mni_macSearch";
            this.mni_macSearch.Size = new System.Drawing.Size(210, 22);
            this.mni_macSearch.Text = "Search for record";
            this.mni_macSearch.Click += new System.EventHandler(this.mni_macSearch_Click);
            // 
            // mni_macFilterBy
            // 
            this.mni_macFilterBy.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_macFilterBy.Name = "mni_macFilterBy";
            this.mni_macFilterBy.Size = new System.Drawing.Size(210, 22);
            this.mni_macFilterBy.Text = "Filter by selection";
            this.mni_macFilterBy.Click += new System.EventHandler(this.mni_macFilterBy_Click);
            // 
            // mni_macFilterExSelection
            // 
            this.mni_macFilterExSelection.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_macFilterExSelection.Name = "mni_macFilterExSelection";
            this.mni_macFilterExSelection.Size = new System.Drawing.Size(210, 22);
            this.mni_macFilterExSelection.Text = "Filter excluding selection";
            this.mni_macFilterExSelection.Click += new System.EventHandler(this.mni_macFilterExcludingSel_Click);
            // 
            // mni_macRemoveFilter
            // 
            this.mni_macRemoveFilter.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_macRemoveFilter.Name = "mni_macRemoveFilter";
            this.mni_macRemoveFilter.Size = new System.Drawing.Size(210, 22);
            this.mni_macRemoveFilter.Text = "Remove filter";
            this.mni_macRemoveFilter.Click += new System.EventHandler(this.mni_macRemoveFilter_Click);
            // 
            // mni_macCopy
            // 
            this.mni_macCopy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_macCopy.Name = "mni_macCopy";
            this.mni_macCopy.Size = new System.Drawing.Size(210, 22);
            this.mni_macCopy.Text = "Copy";
            this.mni_macCopy.Click += new System.EventHandler(this.mni_macCopy_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_macAdmin
            // 
            this.mni_macAdmin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_macAdmin.Name = "mni_macAdmin";
            this.mni_macAdmin.Size = new System.Drawing.Size(210, 22);
            this.mni_macAdmin.Text = "List settings";
            this.mni_macAdmin.Click += new System.EventHandler(this.mni_macAdmin_Click);
            // 
            // bn_Machines
            // 
            this.bn_Machines.AddNewItem = null;
            this.bn_Machines.CountItem = this.toolStripLabel3;
            this.bn_Machines.DeleteItem = null;
            this.bn_Machines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Machines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Machines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator6,
            this.toolStripTextBox2,
            this.toolStripLabel3,
            this.toolStripSeparator7,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator8,
            this.btn_macExcel,
            this.toolStripLabel4,
            this.txt_MachSum});
            this.bn_Machines.Location = new System.Drawing.Point(0, 276);
            this.bn_Machines.MoveFirstItem = this.toolStripButton5;
            this.bn_Machines.MoveLastItem = this.toolStripButton8;
            this.bn_Machines.MoveNextItem = this.toolStripButton7;
            this.bn_Machines.MovePreviousItem = this.toolStripButton6;
            this.bn_Machines.Name = "bn_Machines";
            this.bn_Machines.PositionItem = this.toolStripTextBox2;
            this.bn_Machines.Size = new System.Drawing.Size(941, 25);
            this.bn_Machines.TabIndex = 3;
            this.bn_Machines.Text = "Machines";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "of {0}";
            this.toolStripLabel3.ToolTipText = "Total number of items";
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
            // btn_macExcel
            // 
            this.btn_macExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_macExcel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_macExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_macExcel.Name = "btn_macExcel";
            this.btn_macExcel.Size = new System.Drawing.Size(23, 22);
            this.btn_macExcel.Text = "Export into excel";
            this.btn_macExcel.Click += new System.EventHandler(this.btn_macExcel_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel4.Text = "Selected sum";
            this.toolStripLabel4.Visible = false;
            // 
            // txt_MachSum
            // 
            this.txt_MachSum.Name = "txt_MachSum";
            this.txt_MachSum.Size = new System.Drawing.Size(100, 25);
            this.txt_MachSum.Visible = false;
            // 
            // pg_Repairs
            // 
            this.pg_Repairs.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Repairs.Controls.Add(this.kryptonHeaderGroup5);
            this.pg_Repairs.Controls.Add(this.kryptonHeaderGroup4);
            this.pg_Repairs.Flags = 65534;
            this.pg_Repairs.LastVisibleSet = true;
            this.pg_Repairs.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Repairs.Name = "pg_Repairs";
            this.pg_Repairs.Size = new System.Drawing.Size(943, 341);
            this.pg_Repairs.Text = "Repairs";
            this.pg_Repairs.ToolTipTitle = "Page ToolTip";
            this.pg_Repairs.UniqueName = "7C55254C351F4E51E6BBD7DD10599BC4";
            // 
            // kryptonHeaderGroup5
            // 
            this.kryptonHeaderGroup5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup5.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup5.Name = "kryptonHeaderGroup5";
            // 
            // kryptonHeaderGroup5.Panel
            // 
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.gv_Repairs);
            this.kryptonHeaderGroup5.Panel.Controls.Add(this.bn_Repairs);
            this.kryptonHeaderGroup5.Size = new System.Drawing.Size(749, 341);
            this.kryptonHeaderGroup5.TabIndex = 13;
            this.kryptonHeaderGroup5.ValuesPrimary.Heading = "Repair result";
            this.kryptonHeaderGroup5.ValuesPrimary.Image = global::Odin.Global_Resourses.Assembling_32x32;
            this.kryptonHeaderGroup5.ValuesSecondary.Heading = "";
            // 
            // gv_Repairs
            // 
            this.gv_Repairs.AllowUserToAddRows = false;
            this.gv_Repairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Repairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_rid,
            this.cn_rserial,
            this.cn_rbatch,
            this.cn_rlaunch,
            this.cn_rqty,
            this.cn_rartid,
            this.cn_rarticle,
            this.cn_rsecname,
            this.cn_rconforder,
            this.cn_rworker,
            this.cn_rprodtime,
            this.cn_r301,
            this.cn_r302,
            this.cn_r303,
            this.cn_r304,
            this.cn_r305,
            this.cn_r306,
            this.cn_r307,
            this.cn_r311,
            this.cn_r312,
            this.cn_314,
            this.cn_r316,
            this.cn_399,
            this.cn_rprodplace,
            this.cn_rwhen,
            this.cn_rheadid,
            this.cn_rworkerid});
            this.gv_Repairs.ContextMenuStrip = this.mnu_rLines;
            this.gv_Repairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Repairs.Location = new System.Drawing.Point(0, 0);
            this.gv_Repairs.Name = "gv_Repairs";
            this.gv_Repairs.RowHeadersWidth = 25;
            this.gv_Repairs.Size = new System.Drawing.Size(747, 276);
            this.gv_Repairs.TabIndex = 8;
            this.gv_Repairs.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_Repairs_ColumnHeaderMouseClick);
            // 
            // mnu_rLines
            // 
            this.mnu_rLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_rLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_rFilterFor,
            this.mni_rSearch,
            this.mni_rFilterBy,
            this.mni_rFilterExcludingSel,
            this.mni_rRemoveFilter,
            this.mni_rCopy,
            this.toolStripSeparator13,
            this.mni_rAdmin});
            this.mnu_rLines.Name = "mnu_Requests";
            this.mnu_rLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_rLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_rLines_Opening);
            // 
            // mni_rFilterFor
            // 
            this.mni_rFilterFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_rFilterFor.Name = "mni_rFilterFor";
            this.mni_rFilterFor.Size = new System.Drawing.Size(150, 23);
            this.mni_rFilterFor.TextChanged += new System.EventHandler(this.mni_rFilterFor_TextChanged);
            // 
            // mni_rSearch
            // 
            this.mni_rSearch.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_rSearch.Name = "mni_rSearch";
            this.mni_rSearch.Size = new System.Drawing.Size(210, 22);
            this.mni_rSearch.Text = "Search for record";
            this.mni_rSearch.Click += new System.EventHandler(this.mni_rSearch_Click);
            // 
            // mni_rFilterBy
            // 
            this.mni_rFilterBy.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_rFilterBy.Name = "mni_rFilterBy";
            this.mni_rFilterBy.Size = new System.Drawing.Size(210, 22);
            this.mni_rFilterBy.Text = "Filter by selection";
            this.mni_rFilterBy.Click += new System.EventHandler(this.mni_rFilterBy_Click);
            // 
            // mni_rFilterExcludingSel
            // 
            this.mni_rFilterExcludingSel.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_rFilterExcludingSel.Name = "mni_rFilterExcludingSel";
            this.mni_rFilterExcludingSel.Size = new System.Drawing.Size(210, 22);
            this.mni_rFilterExcludingSel.Text = "Filter excluding selection";
            this.mni_rFilterExcludingSel.Click += new System.EventHandler(this.mni_rFilterExcludingSel_Click);
            // 
            // mni_rRemoveFilter
            // 
            this.mni_rRemoveFilter.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_rRemoveFilter.Name = "mni_rRemoveFilter";
            this.mni_rRemoveFilter.Size = new System.Drawing.Size(210, 22);
            this.mni_rRemoveFilter.Text = "Remove filter";
            this.mni_rRemoveFilter.Click += new System.EventHandler(this.mni_rRemoveFilter_Click);
            // 
            // mni_rCopy
            // 
            this.mni_rCopy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_rCopy.Name = "mni_rCopy";
            this.mni_rCopy.Size = new System.Drawing.Size(210, 22);
            this.mni_rCopy.Text = "Copy";
            this.mni_rCopy.Click += new System.EventHandler(this.mni_rCopy_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_rAdmin
            // 
            this.mni_rAdmin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_rAdmin.Name = "mni_rAdmin";
            this.mni_rAdmin.Size = new System.Drawing.Size(210, 22);
            this.mni_rAdmin.Text = "List settings";
            this.mni_rAdmin.Click += new System.EventHandler(this.mni_rAdmin_Click);
            // 
            // bn_Repairs
            // 
            this.bn_Repairs.AddNewItem = null;
            this.bn_Repairs.CountItem = this.toolStripLabel5;
            this.bn_Repairs.DeleteItem = null;
            this.bn_Repairs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Repairs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Repairs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator10,
            this.toolStripTextBox3,
            this.toolStripLabel5,
            this.toolStripSeparator11,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripSeparator12,
            this.btn_ExcelRepairs,
            this.toolStripLabel6,
            this.toolStripTextBox4});
            this.bn_Repairs.Location = new System.Drawing.Point(0, 276);
            this.bn_Repairs.MoveFirstItem = this.toolStripButton9;
            this.bn_Repairs.MoveLastItem = this.toolStripButton12;
            this.bn_Repairs.MoveNextItem = this.toolStripButton11;
            this.bn_Repairs.MovePreviousItem = this.toolStripButton10;
            this.bn_Repairs.Name = "bn_Repairs";
            this.bn_Repairs.PositionItem = this.toolStripTextBox3;
            this.bn_Repairs.Size = new System.Drawing.Size(747, 25);
            this.bn_Repairs.TabIndex = 3;
            this.bn_Repairs.Text = "bindingNavigator1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "of {0}";
            this.toolStripLabel5.ToolTipText = "Total number of items";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Move first";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move previous";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Position";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Current position";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move next";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move last";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ExcelRepairs
            // 
            this.btn_ExcelRepairs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelRepairs.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExcelRepairs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelRepairs.Name = "btn_ExcelRepairs";
            this.btn_ExcelRepairs.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelRepairs.Text = "Export into excel";
            this.btn_ExcelRepairs.Click += new System.EventHandler(this.btn_ExcelRepairs_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel6.Text = "Selected sum";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 25);
            // 
            // kryptonHeaderGroup4
            // 
            this.kryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup4.Location = new System.Drawing.Point(749, 0);
            this.kryptonHeaderGroup4.Name = "kryptonHeaderGroup4";
            // 
            // kryptonHeaderGroup4.Panel
            // 
            this.kryptonHeaderGroup4.Panel.Controls.Add(this.kryptonPanel2);
            this.kryptonHeaderGroup4.Size = new System.Drawing.Size(194, 341);
            this.kryptonHeaderGroup4.TabIndex = 12;
            this.kryptonHeaderGroup4.ValuesPrimary.Heading = "Legend";
            this.kryptonHeaderGroup4.ValuesPrimary.Image = global::Odin.Global_Resourses.legend;
            this.kryptonHeaderGroup4.ValuesSecondary.Heading = "";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txt_Legend);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(192, 301);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // txt_Legend
            // 
            this.txt_Legend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Legend.Location = new System.Drawing.Point(0, 0);
            this.txt_Legend.Name = "txt_Legend";
            this.txt_Legend.Size = new System.Drawing.Size(192, 301);
            this.txt_Legend.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Legend.TabIndex = 0;
            this.txt_Legend.Text = resources.GetString("txt_Legend.Text");
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 368);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.gv_Materials);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.bn_Materials);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(945, 337);
            this.kryptonHeaderGroup2.TabIndex = 9;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Materials";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.barcode_2d;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "";
            // 
            // gv_Materials
            // 
            this.gv_Materials.AllowUserToAddRows = false;
            this.gv_Materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Materials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_mid,
            this.cn_mlabel,
            this.cn_matartid,
            this.cn_matarticle,
            this.cn_mbatch,
            this.cn_mlaunch,
            this.cn_martid,
            this.cn_marticle,
            this.cn_msecname,
            this.cn_mconforder,
            this.cn_mwhen,
            this.cn_mworker,
            this.cn_manufbatch,
            this.cn_incomedoc});
            this.gv_Materials.ContextMenuStrip = this.mnu_mLines;
            this.gv_Materials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Materials.Location = new System.Drawing.Point(0, 0);
            this.gv_Materials.Name = "gv_Materials";
            this.gv_Materials.RowHeadersWidth = 25;
            this.gv_Materials.Size = new System.Drawing.Size(943, 277);
            this.gv_Materials.TabIndex = 9;
            // 
            // cn_mid
            // 
            this.cn_mid.DataPropertyName = "id";
            this.cn_mid.FillWeight = 5F;
            this.cn_mid.HeaderText = "id";
            this.cn_mid.Name = "cn_mid";
            this.cn_mid.ReadOnly = true;
            this.cn_mid.Visible = false;
            this.cn_mid.Width = 5;
            // 
            // cn_mlabel
            // 
            this.cn_mlabel.DataPropertyName = "label";
            this.cn_mlabel.FillWeight = 120F;
            this.cn_mlabel.HeaderText = "Label";
            this.cn_mlabel.Name = "cn_mlabel";
            this.cn_mlabel.ReadOnly = true;
            this.cn_mlabel.Width = 120;
            // 
            // cn_matartid
            // 
            this.cn_matartid.DataPropertyName = "matartid";
            this.cn_matartid.FillWeight = 80F;
            this.cn_matartid.HeaderText = "Mat. art.id.";
            this.cn_matartid.Name = "cn_matartid";
            this.cn_matartid.Width = 80;
            // 
            // cn_matarticle
            // 
            this.cn_matarticle.DataPropertyName = "matarticle";
            this.cn_matarticle.FillWeight = 120F;
            this.cn_matarticle.HeaderText = "Material ";
            this.cn_matarticle.Name = "cn_matarticle";
            this.cn_matarticle.Width = 120;
            // 
            // cn_mbatch
            // 
            this.cn_mbatch.DataPropertyName = "batch";
            this.cn_mbatch.HeaderText = "Batch";
            this.cn_mbatch.Name = "cn_mbatch";
            this.cn_mbatch.ReadOnly = true;
            // 
            // cn_mlaunch
            // 
            this.cn_mlaunch.DataPropertyName = "launch";
            this.cn_mlaunch.HeaderText = "Launch";
            this.cn_mlaunch.Name = "cn_mlaunch";
            // 
            // cn_martid
            // 
            this.cn_martid.DataPropertyName = "artid";
            this.cn_martid.FillWeight = 60F;
            this.cn_martid.HeaderText = "Product art. ID";
            this.cn_martid.Name = "cn_martid";
            this.cn_martid.Width = 60;
            // 
            // cn_marticle
            // 
            this.cn_marticle.DataPropertyName = "article";
            this.cn_marticle.FillWeight = 120F;
            this.cn_marticle.HeaderText = "Product article";
            this.cn_marticle.Name = "cn_marticle";
            this.cn_marticle.ReadOnly = true;
            this.cn_marticle.Width = 120;
            // 
            // cn_msecname
            // 
            this.cn_msecname.DataPropertyName = "secname";
            this.cn_msecname.HeaderText = "Product sec. name";
            this.cn_msecname.Name = "cn_msecname";
            // 
            // cn_mconforder
            // 
            this.cn_mconforder.DataPropertyName = "conforder";
            this.cn_mconforder.HeaderText = "Conf. order";
            this.cn_mconforder.Name = "cn_mconforder";
            this.cn_mconforder.ReadOnly = true;
            // 
            // cn_mwhen
            // 
            this.cn_mwhen.DataPropertyName = "when";
            this.cn_mwhen.HeaderText = "When";
            this.cn_mwhen.Name = "cn_mwhen";
            // 
            // cn_mworker
            // 
            this.cn_mworker.DataPropertyName = "worker";
            this.cn_mworker.FillWeight = 180F;
            this.cn_mworker.HeaderText = "Worker";
            this.cn_mworker.Name = "cn_mworker";
            this.cn_mworker.Width = 180;
            // 
            // cn_manufbatch
            // 
            this.cn_manufbatch.DataPropertyName = "manufbatch";
            this.cn_manufbatch.HeaderText = "Manuf. batch";
            this.cn_manufbatch.Name = "cn_manufbatch";
            // 
            // cn_incomedoc
            // 
            this.cn_incomedoc.DataPropertyName = "incomedoc";
            this.cn_incomedoc.HeaderText = "Income doc.";
            this.cn_incomedoc.Name = "cn_incomedoc";
            // 
            // mnu_mLines
            // 
            this.mnu_mLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_mLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_mFilterFor,
            this.mni_mSearch,
            this.mni_mFilterBy,
            this.mni_mFilterExcludingSel,
            this.mni_mRemoveFilter,
            this.mni_mCopy,
            this.toolStripSeparator5,
            this.mni_mAdmin});
            this.mnu_mLines.Name = "mnu_Requests";
            this.mnu_mLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_mLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_mLines_Opening);
            // 
            // mni_mFilterFor
            // 
            this.mni_mFilterFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_mFilterFor.Name = "mni_mFilterFor";
            this.mni_mFilterFor.Size = new System.Drawing.Size(150, 23);
            this.mni_mFilterFor.TextChanged += new System.EventHandler(this.mni_mFilterFor_TextChanged);
            // 
            // mni_mSearch
            // 
            this.mni_mSearch.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_mSearch.Name = "mni_mSearch";
            this.mni_mSearch.Size = new System.Drawing.Size(210, 22);
            this.mni_mSearch.Text = "Search for record";
            this.mni_mSearch.Click += new System.EventHandler(this.mni_mSearch_Click);
            // 
            // mni_mFilterBy
            // 
            this.mni_mFilterBy.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_mFilterBy.Name = "mni_mFilterBy";
            this.mni_mFilterBy.Size = new System.Drawing.Size(210, 22);
            this.mni_mFilterBy.Text = "Filter by selection";
            this.mni_mFilterBy.Click += new System.EventHandler(this.mni_mFilterBy_Click);
            // 
            // mni_mFilterExcludingSel
            // 
            this.mni_mFilterExcludingSel.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_mFilterExcludingSel.Name = "mni_mFilterExcludingSel";
            this.mni_mFilterExcludingSel.Size = new System.Drawing.Size(210, 22);
            this.mni_mFilterExcludingSel.Text = "Filter excluding selection";
            this.mni_mFilterExcludingSel.Click += new System.EventHandler(this.mni_mFilterExcludingSel_Click);
            // 
            // mni_mRemoveFilter
            // 
            this.mni_mRemoveFilter.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_mRemoveFilter.Name = "mni_mRemoveFilter";
            this.mni_mRemoveFilter.Size = new System.Drawing.Size(210, 22);
            this.mni_mRemoveFilter.Text = "Remove filter";
            this.mni_mRemoveFilter.Click += new System.EventHandler(this.mni_mRemoveFilter_Click);
            // 
            // mni_mCopy
            // 
            this.mni_mCopy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_mCopy.Name = "mni_mCopy";
            this.mni_mCopy.Size = new System.Drawing.Size(210, 22);
            this.mni_mCopy.Text = "Copy";
            this.mni_mCopy.Click += new System.EventHandler(this.mni_mCopy_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_mAdmin
            // 
            this.mni_mAdmin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_mAdmin.Name = "mni_mAdmin";
            this.mni_mAdmin.Size = new System.Drawing.Size(210, 22);
            this.mni_mAdmin.Text = "List settings";
            this.mni_mAdmin.Click += new System.EventHandler(this.mni_mAdmin_Click);
            // 
            // bn_Materials
            // 
            this.bn_Materials.AddNewItem = null;
            this.bn_Materials.CountItem = this.toolStripLabel1;
            this.bn_Materials.DeleteItem = null;
            this.bn_Materials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Materials.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Materials.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.btn_mExcel});
            this.bn_Materials.Location = new System.Drawing.Point(0, 277);
            this.bn_Materials.MoveFirstItem = this.toolStripButton1;
            this.bn_Materials.MoveLastItem = this.toolStripButton4;
            this.bn_Materials.MoveNextItem = this.toolStripButton3;
            this.bn_Materials.MovePreviousItem = this.toolStripButton2;
            this.bn_Materials.Name = "bn_Materials";
            this.bn_Materials.PositionItem = this.toolStripTextBox1;
            this.bn_Materials.Size = new System.Drawing.Size(943, 25);
            this.bn_Materials.TabIndex = 4;
            this.bn_Materials.Text = "bindingNavigator1";
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
            // btn_mExcel
            // 
            this.btn_mExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_mExcel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_mExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_mExcel.Name = "btn_mExcel";
            this.btn_mExcel.Size = new System.Drawing.Size(23, 22);
            this.btn_mExcel.Text = "Export into excel";
            this.btn_mExcel.Click += new System.EventHandler(this.btn_mExcel_Click);
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
            this.kryptonSplitContainer1.Panel2Collapsed = true;
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1253, 705);
            this.kryptonSplitContainer1.SplitterDistance = 470;
            this.kryptonSplitContainer1.TabIndex = 6;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AddNewItem = null;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.CountItem = null;
            this.miniToolStrip.DeleteItem = null;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.MoveFirstItem = null;
            this.miniToolStrip.MoveLastItem = null;
            this.miniToolStrip.MoveNextItem = null;
            this.miniToolStrip.MovePreviousItem = null;
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.PositionItem = null;
            this.miniToolStrip.Size = new System.Drawing.Size(943, 25);
            this.miniToolStrip.TabIndex = 3;
            // 
            // cn_rid
            // 
            this.cn_rid.DataPropertyName = "id";
            this.cn_rid.FillWeight = 5F;
            this.cn_rid.HeaderText = "id";
            this.cn_rid.Name = "cn_rid";
            this.cn_rid.ReadOnly = true;
            this.cn_rid.Visible = false;
            this.cn_rid.Width = 5;
            // 
            // cn_rserial
            // 
            this.cn_rserial.DataPropertyName = "sn";
            this.cn_rserial.FillWeight = 120F;
            this.cn_rserial.HeaderText = "Serial NO";
            this.cn_rserial.Name = "cn_rserial";
            this.cn_rserial.ReadOnly = true;
            this.cn_rserial.Width = 120;
            // 
            // cn_rbatch
            // 
            this.cn_rbatch.DataPropertyName = "batch";
            this.cn_rbatch.HeaderText = "Batch";
            this.cn_rbatch.Name = "cn_rbatch";
            this.cn_rbatch.ReadOnly = true;
            // 
            // cn_rlaunch
            // 
            this.cn_rlaunch.DataPropertyName = "launch";
            this.cn_rlaunch.HeaderText = "Launch";
            this.cn_rlaunch.Name = "cn_rlaunch";
            // 
            // cn_rqty
            // 
            this.cn_rqty.DataPropertyName = "qty";
            this.cn_rqty.FillWeight = 70F;
            this.cn_rqty.HeaderText = "Qty";
            this.cn_rqty.Name = "cn_rqty";
            this.cn_rqty.ReadOnly = true;
            this.cn_rqty.Width = 70;
            // 
            // cn_rartid
            // 
            this.cn_rartid.DataPropertyName = "artid";
            this.cn_rartid.FillWeight = 60F;
            this.cn_rartid.HeaderText = "Art. ID";
            this.cn_rartid.Name = "cn_rartid";
            this.cn_rartid.Width = 60;
            // 
            // cn_rarticle
            // 
            this.cn_rarticle.DataPropertyName = "article";
            this.cn_rarticle.FillWeight = 120F;
            this.cn_rarticle.HeaderText = "Article";
            this.cn_rarticle.Name = "cn_rarticle";
            this.cn_rarticle.ReadOnly = true;
            this.cn_rarticle.Width = 120;
            // 
            // cn_rsecname
            // 
            this.cn_rsecname.DataPropertyName = "secname";
            this.cn_rsecname.HeaderText = "Sec. name";
            this.cn_rsecname.Name = "cn_rsecname";
            // 
            // cn_rconforder
            // 
            this.cn_rconforder.DataPropertyName = "conforder";
            this.cn_rconforder.HeaderText = "Conf. order";
            this.cn_rconforder.Name = "cn_rconforder";
            this.cn_rconforder.ReadOnly = true;
            // 
            // cn_rworker
            // 
            this.cn_rworker.DataPropertyName = "worker";
            this.cn_rworker.FillWeight = 180F;
            this.cn_rworker.HeaderText = "Worker";
            this.cn_rworker.Name = "cn_rworker";
            this.cn_rworker.Width = 180;
            // 
            // cn_rprodtime
            // 
            this.cn_rprodtime.DataPropertyName = "prodtime";
            this.cn_rprodtime.FillWeight = 80F;
            this.cn_rprodtime.HeaderText = "Prod. time(min)";
            this.cn_rprodtime.Name = "cn_rprodtime";
            this.cn_rprodtime.Width = 80;
            // 
            // cn_r301
            // 
            this.cn_r301.DataPropertyName = "301";
            this.cn_r301.HeaderText = "301";
            this.cn_r301.Name = "cn_r301";
            // 
            // cn_r302
            // 
            this.cn_r302.DataPropertyName = "302";
            this.cn_r302.HeaderText = "302";
            this.cn_r302.Name = "cn_r302";
            // 
            // cn_r303
            // 
            this.cn_r303.DataPropertyName = "303";
            this.cn_r303.HeaderText = "303";
            this.cn_r303.Name = "cn_r303";
            // 
            // cn_r304
            // 
            this.cn_r304.DataPropertyName = "304";
            this.cn_r304.HeaderText = "304";
            this.cn_r304.Name = "cn_r304";
            // 
            // cn_r305
            // 
            this.cn_r305.DataPropertyName = "305";
            this.cn_r305.HeaderText = "305";
            this.cn_r305.Name = "cn_r305";
            // 
            // cn_r306
            // 
            this.cn_r306.DataPropertyName = "306";
            this.cn_r306.HeaderText = "306";
            this.cn_r306.Name = "cn_r306";
            // 
            // cn_r307
            // 
            this.cn_r307.DataPropertyName = "307";
            this.cn_r307.HeaderText = "307";
            this.cn_r307.Name = "cn_r307";
            // 
            // cn_r311
            // 
            this.cn_r311.DataPropertyName = "311";
            this.cn_r311.HeaderText = "311";
            this.cn_r311.Name = "cn_r311";
            // 
            // cn_r312
            // 
            this.cn_r312.DataPropertyName = "312";
            this.cn_r312.HeaderText = "312";
            this.cn_r312.Name = "cn_r312";
            // 
            // cn_314
            // 
            this.cn_314.DataPropertyName = "314";
            this.cn_314.HeaderText = "314";
            this.cn_314.Name = "cn_314";
            // 
            // cn_r316
            // 
            this.cn_r316.DataPropertyName = "316";
            this.cn_r316.HeaderText = "316";
            this.cn_r316.Name = "cn_r316";
            // 
            // cn_399
            // 
            this.cn_399.DataPropertyName = "399";
            this.cn_399.HeaderText = "399";
            this.cn_399.Name = "cn_399";
            // 
            // cn_rprodplace
            // 
            this.cn_rprodplace.DataPropertyName = "prodplace";
            this.cn_rprodplace.HeaderText = "Prod. place";
            this.cn_rprodplace.Name = "cn_rprodplace";
            // 
            // cn_rwhen
            // 
            this.cn_rwhen.DataPropertyName = "when";
            this.cn_rwhen.HeaderText = "When";
            this.cn_rwhen.Name = "cn_rwhen";
            // 
            // cn_rheadid
            // 
            this.cn_rheadid.DataPropertyName = "headid";
            this.cn_rheadid.HeaderText = "headid";
            this.cn_rheadid.Name = "cn_rheadid";
            this.cn_rheadid.Visible = false;
            // 
            // cn_rworkerid
            // 
            this.cn_rworkerid.DataPropertyName = "workerid";
            this.cn_rworkerid.HeaderText = "workerid";
            this.cn_rworkerid.Name = "cn_rworkerid";
            this.cn_rworkerid.Visible = false;
            // 
            // frm_ProductionResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 754);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ProductionResult";
            this.TabText = "Production result";
            this.Text = "Production result";
            this.Load += new System.EventHandler(this.frm_ProductionResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dn_Pages)).EndInit();
            this.dn_Pages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pg_Workers)).EndInit();
            this.pg_Workers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Machines)).EndInit();
            this.pg_Machines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Machines)).EndInit();
            this.mnu_macLines.ResumeLayout(false);
            this.mnu_macLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Machines)).EndInit();
            this.bn_Machines.ResumeLayout(false);
            this.bn_Machines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Repairs)).EndInit();
            this.pg_Repairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup5.Panel)).EndInit();
            this.kryptonHeaderGroup5.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup5.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup5)).EndInit();
            this.kryptonHeaderGroup5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Repairs)).EndInit();
            this.mnu_rLines.ResumeLayout(false);
            this.mnu_rLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Repairs)).EndInit();
            this.bn_Repairs.ResumeLayout(false);
            this.bn_Repairs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup4.Panel)).EndInit();
            this.kryptonHeaderGroup4.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup4)).EndInit();
            this.kryptonHeaderGroup4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Materials)).EndInit();
            this.mnu_mLines.ResumeLayout(false);
            this.mnu_mLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Materials)).EndInit();
            this.bn_Materials.ResumeLayout(false);
            this.bn_Materials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_Materials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Machines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Repairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Edit;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Serial;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Serial;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CMB_Components.Launches.cmb_Launches cmb_Launches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Worker;
        private CMB_Components.Common.cmb_Common cmb_Worker;
        private CustomControls.NullableDateTimePicker txt_DateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private CustomControls.NullableDateTimePicker txt_DateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Till;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_From;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Sum;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Materials;
        private System.Windows.Forms.BindingNavigator bn_Materials;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_mExcel;
        private Global_Classes.SyncBindingSource bs_Materials;
        private System.Windows.Forms.ContextMenuStrip mnu_mLines;
        private System.Windows.Forms.ToolStripTextBox mni_mFilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_mSearch;
        private System.Windows.Forms.ToolStripMenuItem mni_mFilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_mFilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_mRemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_mCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mni_mAdmin;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_ConcOperations;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_matartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_matarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mlaunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_martid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_marticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_msecname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mwhen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_manufbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_incomedoc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Finish;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ShowParameter;
        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator dn_Pages;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Workers;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Machines;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_operno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isapproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_islast;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_analogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_teortime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_teortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_parameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_prodtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_prodplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_workerid;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txt_Sum;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Machines;
        private System.Windows.Forms.BindingNavigator bn_Machines;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btn_macExcel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txt_MachSum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Line;
        private CMB_Components.Common.cmb_Common cmb_Lines;
        private System.Windows.Forms.ContextMenuStrip mnu_macLines;
        private System.Windows.Forms.ToolStripTextBox mni_macFilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_macSearch;
        private System.Windows.Forms.ToolStripMenuItem mni_macFilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_macFilterExSelection;
        private System.Windows.Forms.ToolStripMenuItem mni_macRemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_macCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mni_macAdmin;
        private Global_Classes.SyncBindingSource bs_Machines;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macheadid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macline;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mactopbot;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macpcbsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macfeeder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macprevlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macnewlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macreplacedat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macreplacedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mactermprofiledate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mactermprofileby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macpastedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macpasteby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macmounterat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macmounterby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macovencheckat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_macovencheckby;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Repairs;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup5;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Repairs;
        private System.Windows.Forms.BindingNavigator bn_Repairs;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btn_ExcelRepairs;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup4;
        private Global_Classes.SyncBindingSource bs_Repairs;
        private System.Windows.Forms.ContextMenuStrip mnu_rLines;
        private System.Windows.Forms.ToolStripTextBox mni_rFilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_rSearch;
        private System.Windows.Forms.ToolStripMenuItem mni_rFilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_rFilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_rRemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_rCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem mni_rAdmin;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Legend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rlaunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rsecname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rprodtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r301;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r302;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r303;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r304;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r305;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r306;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r307;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r311;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r312;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_314;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_r316;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_399;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rprodplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rwhen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rheadid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rworkerid;
    }
}