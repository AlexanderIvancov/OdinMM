namespace Odin.Planning.Passport
{
    partial class frm_LaunchPassportComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LaunchPassportComments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.miniToolStrip = new System.Windows.Forms.BindingNavigator(this.components);
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.grp_ComState = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rb_Cancelled = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Closed = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_New = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_All = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Launches1 = new Odin.CMB_Components.Launches.cmb_Launches();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_StartTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_StartFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.chk_Active = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cmb_SalesOrdersWithLines1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrdersWithLines();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gv_Comments = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ccomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_techcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_cstateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_statewho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_statewhen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_changedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_changedat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_CLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForC = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchC = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByC = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelC = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmn_CopyC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminC = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_Comments = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_EditCom = new System.Windows.Forms.ToolStripButton();
            this.btn_ExcelC = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteCom = new System.Windows.Forms.ToolStripButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.bs_Comments = new Odin.Global_Classes.SyncBindingSource();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_ComState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_ComState.Panel)).BeginInit();
            this.grp_ComState.Panel.SuspendLayout();
            this.grp_ComState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Comments)).BeginInit();
            this.mnu_CLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Comments)).BeginInit();
            this.bn_Comments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Comments)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
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
            this.miniToolStrip.Size = new System.Drawing.Size(1369, 25);
            this.miniToolStrip.TabIndex = 4;
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
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1242, 65);
            this.kryptonDockableWorkspace1.TabIndex = 5;
            this.kryptonDockableWorkspace1.TabStop = true;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.grp_ComState);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel9);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Common1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Launches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_StartTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_StartFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Active);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_SalesOrdersWithLines1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel11);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
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
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_Comments);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_Comments);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1242, 538);
            this.kryptonSplitContainer2.SplitterDistance = 313;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // grp_ComState
            // 
            this.grp_ComState.Location = new System.Drawing.Point(8, 323);
            this.grp_ComState.Name = "grp_ComState";
            // 
            // grp_ComState.Panel
            // 
            this.grp_ComState.Panel.Controls.Add(this.rb_Cancelled);
            this.grp_ComState.Panel.Controls.Add(this.rb_Closed);
            this.grp_ComState.Panel.Controls.Add(this.rb_New);
            this.grp_ComState.Panel.Controls.Add(this.rb_All);
            this.grp_ComState.Size = new System.Drawing.Size(285, 59);
            this.grp_ComState.TabIndex = 282;
            this.grp_ComState.Values.Heading = "Comments state";
            // 
            // rb_Cancelled
            // 
            this.rb_Cancelled.Location = new System.Drawing.Point(191, 3);
            this.rb_Cancelled.Name = "rb_Cancelled";
            this.rb_Cancelled.Size = new System.Drawing.Size(75, 20);
            this.rb_Cancelled.TabIndex = 3;
            this.rb_Cancelled.Values.Text = "Cancelled";
            // 
            // rb_Closed
            // 
            this.rb_Closed.Location = new System.Drawing.Point(116, 3);
            this.rb_Closed.Name = "rb_Closed";
            this.rb_Closed.Size = new System.Drawing.Size(59, 20);
            this.rb_Closed.TabIndex = 2;
            this.rb_Closed.Values.Text = "Closed";
            // 
            // rb_New
            // 
            this.rb_New.Location = new System.Drawing.Point(49, 3);
            this.rb_New.Name = "rb_New";
            this.rb_New.Size = new System.Drawing.Size(47, 20);
            this.rb_New.TabIndex = 1;
            this.rb_New.Values.Text = "New";
            // 
            // rb_All
            // 
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(7, 3);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(36, 20);
            this.rb_All.TabIndex = 0;
            this.rb_All.Values.Text = "All";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(8, 127);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel9.TabIndex = 281;
            this.kryptonLabel9.Values.Text = "Customer:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(94, 127);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(199, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 280;
            this.cmb_Firms1.VATNr = null;
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(94, 153);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(99, 20);
            this.cmb_Common1.sTable = "vw_ProductionStagesOnly";
            this.cmb_Common1.sText_Filled = "name";
            this.cmb_Common1.sTitle = "Stages of usage";
            this.cmb_Common1.TabIndex = 279;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(8, 153);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel6.TabIndex = 278;
            this.kryptonLabel6.Values.Text = "Stage:";
            // 
            // cmb_Launches1
            // 
            this.cmb_Launches1.Article = null;
            this.cmb_Launches1.ArticleId = 0;
            this.cmb_Launches1.Batch = "";
            this.cmb_Launches1.BatchId = 0;
            this.cmb_Launches1.ConfOrder = "";
            this.cmb_Launches1.Customer = "";
            this.cmb_Launches1.IsActive = 0;
            this.cmb_Launches1.Launch = "";
            this.cmb_Launches1.LaunchId = 0;
            this.cmb_Launches1.Location = new System.Drawing.Point(94, 74);
            this.cmb_Launches1.Name = "cmb_Launches1";
            this.cmb_Launches1.ParentBatchId = 0;
            this.cmb_Launches1.Qty = 0D;
            this.cmb_Launches1.SecName = null;
            this.cmb_Launches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Launches1.StageId = 0;
            this.cmb_Launches1.StartDate = "";
            this.cmb_Launches1.TabIndex = 277;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(8, 74);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel5.TabIndex = 276;
            this.kryptonLabel5.Values.Text = "Launch:";
            // 
            // txt_StartTill
            // 
            this.txt_StartTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_StartTill.CalendarShowWeekNumbers = true;
            this.txt_StartTill.CustomFormat = null;
            this.txt_StartTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartTill.Location = new System.Drawing.Point(188, 287);
            this.txt_StartTill.Name = "txt_StartTill";
            this.txt_StartTill.NullValue = " ";
            this.txt_StartTill.Size = new System.Drawing.Size(105, 21);
            this.txt_StartTill.TabIndex = 235;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            // 
            // txt_StartFrom
            // 
            this.txt_StartFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_StartFrom.CalendarShowWeekNumbers = true;
            this.txt_StartFrom.CustomFormat = null;
            this.txt_StartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartFrom.Location = new System.Drawing.Point(52, 287);
            this.txt_StartFrom.Name = "txt_StartFrom";
            this.txt_StartFrom.NullValue = " ";
            this.txt_StartFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_StartFrom.TabIndex = 234;
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny5.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            // 
            // chk_Active
            // 
            this.chk_Active.Checked = true;
            this.chk_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Active.Location = new System.Drawing.Point(93, 105);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(57, 20);
            this.chk_Active.TabIndex = 233;
            this.chk_Active.ThreeState = true;
            this.chk_Active.Values.Text = "Active";
            // 
            // cmb_SalesOrdersWithLines1
            // 
            this.cmb_SalesOrdersWithLines1.BatchId = 0;
            this.cmb_SalesOrdersWithLines1.Location = new System.Drawing.Point(94, 179);
            this.cmb_SalesOrdersWithLines1.Name = "cmb_SalesOrdersWithLines1";
            this.cmb_SalesOrdersWithLines1.SalesOrder = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            this.cmb_SalesOrdersWithLines1.SalesOrderLine = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            this.cmb_SalesOrdersWithLines1.Size = new System.Drawing.Size(199, 21);
            this.cmb_SalesOrdersWithLines1.TabIndex = 232;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(159, 286);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel11.TabIndex = 226;
            this.kryptonLabel11.Values.Text = "till:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(5, 287);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 225;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(5, 267);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(117, 20);
            this.kryptonLabel7.TabIndex = 223;
            this.kryptonLabel7.Values.Text = "Start of production:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(5, 245);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel4.TabIndex = 220;
            this.kryptonLabel4.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(93, 245);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(167, 20);
            this.cmb_Types1.TabIndex = 218;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 197);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel3.TabIndex = 217;
            this.kryptonLabel3.Values.Text = "Article:";
            // 
            // cmb_Articles1
            // 
            this.cmb_Articles1.Article = "";
            this.cmb_Articles1.ArticleId = 0;
            this.cmb_Articles1.ArtType = null;
            this.cmb_Articles1.BOMState = 0;
            this.cmb_Articles1.Comments = null;
            this.cmb_Articles1.CustCode = null;
            this.cmb_Articles1.CustCodeId = 0;
            this.cmb_Articles1.Department = null;
            this.cmb_Articles1.DeptId = 0;
            this.cmb_Articles1.Description = null;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.Location = new System.Drawing.Point(9, 220);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
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
            this.gradientPanel22.Location = new System.Drawing.Point(8, 100);
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
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 48);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 214;
            this.kryptonLabel2.Values.Text = "Batch:";
            // 
            // cmb_Batches1
            // 
            this.cmb_Batches1.ActiveOnly = 0;
            this.cmb_Batches1.Article = null;
            this.cmb_Batches1.ArticleId = 0;
            this.cmb_Batches1.Batch = "";
            this.cmb_Batches1.BatchId = 0;
            this.cmb_Batches1.ConfOrder = "";
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.Customer = "";
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(94, 48);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(128, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 213;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(7, 179);
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
            this.kryptonHeader1.Size = new System.Drawing.Size(313, 42);
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
            // gv_Comments
            // 
            this.gv_Comments.AllowUserToAddRows = false;
            this.gv_Comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Comments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_cid,
            this.cn_ccomments,
            this.cn_launch,
            this.cn_batch,
            this.cn_techcomments,
            this.cn_cstateid,
            this.cn_state,
            this.cn_who,
            this.cn_when,
            this.cn_statewho,
            this.cn_statewhen,
            this.cn_changedby,
            this.cn_changedat});
            this.gv_Comments.ContextMenuStrip = this.mnu_CLines;
            this.gv_Comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Comments.Location = new System.Drawing.Point(0, 0);
            this.gv_Comments.Name = "gv_Comments";
            this.gv_Comments.RowHeadersWidth = 25;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Comments.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Comments.Size = new System.Drawing.Size(924, 513);
            this.gv_Comments.TabIndex = 6;
            this.gv_Comments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Comments_CellDoubleClick);
            this.gv_Comments.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_Comments_ColumnHeaderMouseClick);
            // 
            // cn_cid
            // 
            this.cn_cid.DataPropertyName = "id";
            this.cn_cid.HeaderText = "id";
            this.cn_cid.Name = "cn_cid";
            this.cn_cid.Visible = false;
            // 
            // cn_ccomments
            // 
            this.cn_ccomments.DataPropertyName = "comments";
            this.cn_ccomments.FillWeight = 350F;
            this.cn_ccomments.HeaderText = "Comments";
            this.cn_ccomments.Name = "cn_ccomments";
            this.cn_ccomments.Width = 350;
            // 
            // cn_launch
            // 
            this.cn_launch.DataPropertyName = "launch";
            this.cn_launch.HeaderText = "Launch";
            this.cn_launch.Name = "cn_launch";
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            // 
            // cn_techcomments
            // 
            this.cn_techcomments.DataPropertyName = "techcomments";
            this.cn_techcomments.FillWeight = 250F;
            this.cn_techcomments.HeaderText = "Tech. dept. comments";
            this.cn_techcomments.Name = "cn_techcomments";
            this.cn_techcomments.Width = 250;
            // 
            // cn_cstateid
            // 
            this.cn_cstateid.DataPropertyName = "stateid";
            this.cn_cstateid.HeaderText = "stateid";
            this.cn_cstateid.Name = "cn_cstateid";
            this.cn_cstateid.Visible = false;
            // 
            // cn_state
            // 
            this.cn_state.DataPropertyName = "state";
            this.cn_state.HeaderText = "State";
            this.cn_state.Name = "cn_state";
            // 
            // cn_who
            // 
            this.cn_who.DataPropertyName = "who";
            this.cn_who.FillWeight = 90F;
            this.cn_who.HeaderText = "Who";
            this.cn_who.Name = "cn_who";
            this.cn_who.Width = 90;
            // 
            // cn_when
            // 
            this.cn_when.DataPropertyName = "when";
            this.cn_when.HeaderText = "When";
            this.cn_when.Name = "cn_when";
            // 
            // cn_statewho
            // 
            this.cn_statewho.DataPropertyName = "statewho";
            this.cn_statewho.FillWeight = 90F;
            this.cn_statewho.HeaderText = "State changed by";
            this.cn_statewho.Name = "cn_statewho";
            this.cn_statewho.Width = 90;
            // 
            // cn_statewhen
            // 
            this.cn_statewhen.DataPropertyName = "statewhen";
            this.cn_statewhen.HeaderText = "State changed at";
            this.cn_statewhen.Name = "cn_statewhen";
            // 
            // cn_changedby
            // 
            this.cn_changedby.DataPropertyName = "changedby";
            this.cn_changedby.HeaderText = "Changed by";
            this.cn_changedby.Name = "cn_changedby";
            // 
            // cn_changedat
            // 
            this.cn_changedat.DataPropertyName = "changedat";
            this.cn_changedat.HeaderText = "Changed at";
            this.cn_changedat.Name = "cn_changedat";
            // 
            // mnu_CLines
            // 
            this.mnu_CLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_CLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForC,
            this.mni_SearchC,
            this.mni_FilterByC,
            this.mni_FilterExcludingSelC,
            this.mni_RemoveFilterC,
            this.cmn_CopyC,
            this.toolStripSeparator5,
            this.mni_AdminC});
            this.mnu_CLines.Name = "mnu_Requests";
            this.mnu_CLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_CLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesC_Opening);
            // 
            // mni_FilterForC
            // 
            this.mni_FilterForC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForC.Name = "mni_FilterForC";
            this.mni_FilterForC.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForC.TextChanged += new System.EventHandler(this.mni_FilterForC_TextChanged);
            // 
            // mni_SearchC
            // 
            this.mni_SearchC.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchC.Name = "mni_SearchC";
            this.mni_SearchC.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchC.Text = "Search for record";
            this.mni_SearchC.Click += new System.EventHandler(this.mni_SearchC_Click);
            // 
            // mni_FilterByC
            // 
            this.mni_FilterByC.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByC.Name = "mni_FilterByC";
            this.mni_FilterByC.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByC.Text = "Filter by selection";
            this.mni_FilterByC.Click += new System.EventHandler(this.mni_FilterByC_Click);
            // 
            // mni_FilterExcludingSelC
            // 
            this.mni_FilterExcludingSelC.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelC.Name = "mni_FilterExcludingSelC";
            this.mni_FilterExcludingSelC.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelC.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelC.Click += new System.EventHandler(this.mni_FilterExcludingSelC_Click);
            // 
            // mni_RemoveFilterC
            // 
            this.mni_RemoveFilterC.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterC.Name = "mni_RemoveFilterC";
            this.mni_RemoveFilterC.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterC.Text = "Remove filter";
            this.mni_RemoveFilterC.Click += new System.EventHandler(this.mni_RemoveFilterC_Click);
            // 
            // cmn_CopyC
            // 
            this.cmn_CopyC.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.cmn_CopyC.Name = "cmn_CopyC";
            this.cmn_CopyC.Size = new System.Drawing.Size(210, 22);
            this.cmn_CopyC.Text = "Copy";
            this.cmn_CopyC.Click += new System.EventHandler(this.mni_CopyC_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminC
            // 
            this.mni_AdminC.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminC.Name = "mni_AdminC";
            this.mni_AdminC.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminC.Text = "List settings";
            this.mni_AdminC.Click += new System.EventHandler(this.mni_AdminC_Click);
            // 
            // bn_Comments
            // 
            this.bn_Comments.AddNewItem = null;
            this.bn_Comments.CountItem = this.toolStripLabel1;
            this.bn_Comments.DeleteItem = null;
            this.bn_Comments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Comments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Comments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.btn_EditCom,
            this.btn_ExcelC,
            this.btn_DeleteCom});
            this.bn_Comments.Location = new System.Drawing.Point(0, 513);
            this.bn_Comments.MoveFirstItem = this.toolStripButton1;
            this.bn_Comments.MoveLastItem = this.toolStripButton4;
            this.bn_Comments.MoveNextItem = this.toolStripButton3;
            this.bn_Comments.MovePreviousItem = this.toolStripButton2;
            this.bn_Comments.Name = "bn_Comments";
            this.bn_Comments.PositionItem = this.toolStripTextBox1;
            this.bn_Comments.Size = new System.Drawing.Size(924, 25);
            this.bn_Comments.TabIndex = 5;
            this.bn_Comments.Text = "bindingNavigator1";
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
            // btn_EditCom
            // 
            this.btn_EditCom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EditCom.Image = global::Odin.Global_Resourses.edit;
            this.btn_EditCom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditCom.Name = "btn_EditCom";
            this.btn_EditCom.Size = new System.Drawing.Size(23, 22);
            this.btn_EditCom.Text = "Edit comments";
            this.btn_EditCom.Click += new System.EventHandler(this.btn_EditCom_Click);
            // 
            // btn_ExcelC
            // 
            this.btn_ExcelC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelC.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall1;
            this.btn_ExcelC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelC.Name = "btn_ExcelC";
            this.btn_ExcelC.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelC.Text = "Export into excel";
            this.btn_ExcelC.Click += new System.EventHandler(this.btn_ExcelC_Click);
            // 
            // btn_DeleteCom
            // 
            this.btn_DeleteCom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteCom.Image = global::Odin.Global_Resourses.bindingNavigatorDeleteItem_Image;
            this.btn_DeleteCom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteCom.Name = "btn_DeleteCom";
            this.btn_DeleteCom.Size = new System.Drawing.Size(23, 22);
            this.btn_DeleteCom.Text = "Delete comments";
            this.btn_DeleteCom.Visible = false;
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
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1242, 608);
            this.kryptonSplitContainer1.SplitterDistance = 538;
            this.kryptonSplitContainer1.TabIndex = 10;
            // 
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            this.kryptonDockingManager1.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager1_DockspaceAdding);
            // 
            // frm_LaunchPassportComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 608);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_LaunchPassportComments";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.TabText = "Launch comments review";
            this.Text = "Launch comments review";
            this.Load += new System.EventHandler(this.frm_LaunchPassportComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_ComState.Panel)).EndInit();
            this.grp_ComState.Panel.ResumeLayout(false);
            this.grp_ComState.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_ComState)).EndInit();
            this.grp_ComState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Comments)).EndInit();
            this.mnu_CLines.ResumeLayout(false);
            this.mnu_CLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Comments)).EndInit();
            this.bn_Comments.ResumeLayout(false);
            this.bn_Comments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_Comments)).EndInit();
            this.ResumeLayout(false); //this.GetKryptonFormFields(this.GetType());

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CMB_Components.Launches.cmb_Launches cmb_Launches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CustomControls.NullableDateTimePicker txt_StartTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private CustomControls.NullableDateTimePicker txt_StartFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Active;
        private CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Comments;
        private System.Windows.Forms.ContextMenuStrip mnu_CLines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForC;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchC;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByC;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelC;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterC;
        private System.Windows.Forms.ToolStripMenuItem cmn_CopyC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminC;
        private System.Windows.Forms.BindingNavigator bn_Comments;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_EditCom;
        private System.Windows.Forms.ToolStripButton btn_DeleteCom;
        private System.Windows.Forms.ToolStripButton btn_ExcelC;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private Global_Classes.SyncBindingSource bs_Comments;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ccomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_techcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cstateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_who;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_statewho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_statewhen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_changedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_changedat;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grp_ComState;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Cancelled;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Closed;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_New;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_All;
    }
}