namespace Odin.Planning
{
    partial class frm_LaunchesPlanningG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LaunchesPlanningG));
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Week1 = new Odin.CMB_Components.Week.cmb_Week();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Excel = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_NotStarted = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmb_Launches1 = new Odin.CMB_Components.Launches.cmb_Launches();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.gradientPanel21 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel19 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Users1 = new Odin.CMB_Components.Users.cmb_Users();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.monthView1 = new System.Windows.Forms.Calendar.MonthView();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_DateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_DateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cm_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_RMMissings = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_EditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_AutoReserve = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ReserveRM = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_InsertComment = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_PrintItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LaunchPassport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.redTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherColorTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timeScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_GroupLaunches = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.cm_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 167);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel1.TabIndex = 43;
            this.kryptonLabel1.Values.Text = "Week:";
            // 
            // cmb_Week1
            // 
            this.cmb_Week1.FirstDateOfWeek = new System.DateTime(((long)(0)));
            this.cmb_Week1.LastDateOfWeek = new System.DateTime(((long)(0)));
            this.cmb_Week1.Location = new System.Drawing.Point(88, 167);
            this.cmb_Week1.Name = "cmb_Week1";
            this.cmb_Week1.Size = new System.Drawing.Size(100, 20);
            this.cmb_Week1.TabIndex = 42;
            this.cmb_Week1.Week = "W  .";
            this.cmb_Week1.weekNumber = 0;
            this.cmb_Week1.SelectedValueChanged += new Odin.CMB_Components.Week.WeekEventHandler(this.cmb_Week1_SelectedValueChanged);
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(4, 121);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel16.TabIndex = 41;
            this.kryptonLabel16.Values.Text = "Article:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(5, 70);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel6.TabIndex = 39;
            this.kryptonLabel6.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(89, 70);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Types1.TabIndex = 38;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 44);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel3.TabIndex = 37;
            this.kryptonLabel3.Values.Text = "Customer:";
            // 
            // btn_Excel
            // 
            this.btn_Excel.Image = global::Odin.Global_Resourses.table_go;
            this.btn_Excel.UniqueName = "A1326F9C2D6440B8B89EAC5E7970D223";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
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
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(9, 141);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(283, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 40;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear,
            this.btn_Excel,
            this.btn_NotStarted});
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
            // btn_NotStarted
            // 
            this.btn_NotStarted.Image = global::Odin.Global_Resourses.stock_mail_priority_high_2821;
            this.btn_NotStarted.UniqueName = "8429ECC047EB493AD6B7A6B82FCB0D33";
            this.btn_NotStarted.Click += new System.EventHandler(this.btn_NotStarted_Click);
            // 
            // cmb_Launches1
            // 
            this.cmb_Launches1.Article = null;
            this.cmb_Launches1.ArticleId = 0;
            this.cmb_Launches1.Batch = "";
            this.cmb_Launches1.BatchId = 0;
            this.cmb_Launches1.ConfOrder = "";
            this.cmb_Launches1.Customer = "";
            this.cmb_Launches1.EndDate = "";
            this.cmb_Launches1.IsActive = 0;
            this.cmb_Launches1.Launch = "";
            this.cmb_Launches1.LaunchId = 0;
            this.cmb_Launches1.Location = new System.Drawing.Point(89, 8);
            this.cmb_Launches1.Name = "cmb_Launches1";
            this.cmb_Launches1.ParentBatchId = 0;
            this.cmb_Launches1.Qty = 0D;
            this.cmb_Launches1.SecName = null;
            this.cmb_Launches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Launches1.StageId = 0;
            this.cmb_Launches1.StartDate = "";
            this.cmb_Launches1.TabIndex = 275;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(5, 8);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel4.TabIndex = 274;
            this.kryptonLabel4.Values.Text = "Launch:";
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(5, 35);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 272;
            // 
            // gradientPanel21
            // 
            this.gradientPanel21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel21.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel21.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel21.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel21.Location = new System.Drawing.Point(5, 224);
            this.gradientPanel21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel21.Name = "gradientPanel21";
            this.gradientPanel21.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel21.ShowBottomBorder = true;
            this.gradientPanel21.ShowLeftBorder = true;
            this.gradientPanel21.ShowRightBorder = true;
            this.gradientPanel21.ShowTopBorder = true;
            this.gradientPanel21.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel21.StartColor = System.Drawing.Color.White;
            this.gradientPanel21.TabIndex = 271;
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Location = new System.Drawing.Point(5, 230);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(187, 20);
            this.kryptonLabel19.TabIndex = 270;
            this.kryptonLabel19.Values.Text = "Assembling person for route list:";
            // 
            // cmb_Users1
            // 
            this.cmb_Users1.Location = new System.Drawing.Point(9, 251);
            this.cmb_Users1.Name = "cmb_Users1";
            this.cmb_Users1.Size = new System.Drawing.Size(283, 20);
            this.cmb_Users1.TabIndex = 269;
            this.cmb_Users1.User = "";
            this.cmb_Users1.UserId = 0;
            this.cmb_Users1.UserLogin = null;
            this.cmb_Users1.UserShortName = "";
            this.cmb_Users1.UserTN = "";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(89, 96);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(99, 20);
            this.cmb_Common1.sTable = "vw_ProductionStagesOnly";
            this.cmb_Common1.sText_Filled = "name";
            this.cmb_Common1.sTitle = "Stages of usage";
            this.cmb_Common1.TabIndex = 268;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(5, 96);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel2.TabIndex = 44;
            this.kryptonLabel2.Values.Text = "Stage:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(89, 44);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 36;
            this.cmb_Firms1.VATNr = null;
            // 
            // monthView1
            // 
            this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthView1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(0, 321);
            this.monthView1.MaxSelectionCount = 90;
            this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(299, 365);
            this.monthView1.TabIndex = 3;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
            this.monthView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.monthView1_MouseUp);
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.monthView1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonPanel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.kryptonSplitContainer2.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabHighProfile;
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1277, 686);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_DateTill);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.txt_DateFrom);
            this.kryptonPanel1.Controls.Add(this.cmb_Launches1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.gradientPanel22);
            this.kryptonPanel1.Controls.Add(this.gradientPanel21);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel19);
            this.kryptonPanel1.Controls.Add(this.cmb_Users1);
            this.kryptonPanel1.Controls.Add(this.cmb_Common1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cmb_Week1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel16);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.cmb_Types1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.cmb_Firms1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 42);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(299, 279);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // txt_DateTill
            // 
            this.txt_DateTill.CalendarShowWeekNumbers = true;
            this.txt_DateTill.CustomFormat = null;
            this.txt_DateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateTill.Location = new System.Drawing.Point(203, 193);
            this.txt_DateTill.Name = "txt_DateTill";
            this.txt_DateTill.NullValue = " ";
            this.txt_DateTill.Size = new System.Drawing.Size(89, 21);
            this.txt_DateTill.TabIndex = 289;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(171, 194);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(26, 20);
            this.kryptonLabel12.TabIndex = 288;
            this.kryptonLabel12.Values.Text = "till:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(5, 193);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel5.TabIndex = 277;
            this.kryptonLabel5.Values.Text = "Date from:";
            // 
            // txt_DateFrom
            // 
            this.txt_DateFrom.CalendarShowWeekNumbers = true;
            this.txt_DateFrom.CustomFormat = null;
            this.txt_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateFrom.Location = new System.Drawing.Point(88, 193);
            this.txt_DateFrom.Name = "txt_DateFrom";
            this.txt_DateFrom.NullValue = " ";
            this.txt_DateFrom.Size = new System.Drawing.Size(77, 21);
            this.txt_DateFrom.TabIndex = 276;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 686);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cm_Main
            // 
            this.cm_Main.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cm_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_addItem,
            this.btn_GroupLaunches,
            this.btn_RMMissings,
            this.btn_EditItem,
            this.mnu_Start,
            this.mni_AutoReserve,
            this.btn_ReserveRM,
            this.btn_InsertComment,
            this.btn_CopyText,
            this.btn_DeleteItem,
            this.btn_PrintItem,
            this.btn_LaunchPassport,
            this.toolStripSeparator1,
            this.redTagToolStripMenuItem,
            this.yellowTagToolStripMenuItem,
            this.greenTagToolStripMenuItem,
            this.blueTagToolStripMenuItem,
            this.otherColorTagToolStripMenuItem,
            this.toolStripSeparator2,
            this.timeScaleToolStripMenuItem});
            this.cm_Main.Name = "cm_Main";
            this.cm_Main.Size = new System.Drawing.Size(181, 434);
            this.cm_Main.Opening += new System.ComponentModel.CancelEventHandler(this.cm_Main_Opening);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Image = global::Odin.Global_Resourses.bindingNavigatorAddNewItem_Image;
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(180, 22);
            this.btn_addItem.Text = "Add launch";
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_RMMissings
            // 
            this.btn_RMMissings.Image = global::Odin.Global_Resourses.messagebox_warning;
            this.btn_RMMissings.Name = "btn_RMMissings";
            this.btn_RMMissings.Size = new System.Drawing.Size(180, 22);
            this.btn_RMMissings.Text = "RM missings";
            this.btn_RMMissings.Click += new System.EventHandler(this.btn_RMMissings_Click);
            // 
            // btn_EditItem
            // 
            this.btn_EditItem.Image = global::Odin.Global_Resourses.edit;
            this.btn_EditItem.Name = "btn_EditItem";
            this.btn_EditItem.Size = new System.Drawing.Size(180, 22);
            this.btn_EditItem.Text = "Edit launch";
            this.btn_EditItem.Click += new System.EventHandler(this.btn_EditItem_Click);
            // 
            // mnu_Start
            // 
            this.mnu_Start.Image = global::Odin.Global_Resourses.player_play;
            this.mnu_Start.Name = "mnu_Start";
            this.mnu_Start.Size = new System.Drawing.Size(180, 22);
            this.mnu_Start.Text = "Start launch";
            this.mnu_Start.Click += new System.EventHandler(this.mnu_Start_Click);
            // 
            // mni_AutoReserve
            // 
            this.mni_AutoReserve.Image = global::Odin.Global_Resourses.wand;
            this.mni_AutoReserve.Name = "mni_AutoReserve";
            this.mni_AutoReserve.Size = new System.Drawing.Size(180, 22);
            this.mni_AutoReserve.Text = "Auto reserve RM";
            this.mni_AutoReserve.Click += new System.EventHandler(this.mni_AutoReserve_Click);
            // 
            // btn_ReserveRM
            // 
            this.btn_ReserveRM.Image = global::Odin.Global_Resourses.snowflake24x24;
            this.btn_ReserveRM.Name = "btn_ReserveRM";
            this.btn_ReserveRM.Size = new System.Drawing.Size(180, 22);
            this.btn_ReserveRM.Text = "Reserve RM";
            this.btn_ReserveRM.Click += new System.EventHandler(this.btn_ReserveRM_Click);
            // 
            // btn_InsertComment
            // 
            this.btn_InsertComment.Image = global::Odin.Global_Resourses.comment_add;
            this.btn_InsertComment.Name = "btn_InsertComment";
            this.btn_InsertComment.Size = new System.Drawing.Size(180, 22);
            this.btn_InsertComment.Text = "Insert comment";
            this.btn_InsertComment.Click += new System.EventHandler(this.btn_InsertComment_Click);
            // 
            // btn_CopyText
            // 
            this.btn_CopyText.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.btn_CopyText.Name = "btn_CopyText";
            this.btn_CopyText.Size = new System.Drawing.Size(180, 22);
            this.btn_CopyText.Text = "Copy text";
            this.btn_CopyText.Click += new System.EventHandler(this.btn_CopyText_Click);
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.Image = global::Odin.Global_Resourses.bindingNavigatorDeleteItem_Image;
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(180, 22);
            this.btn_DeleteItem.Text = "Delete launch";
            this.btn_DeleteItem.Click += new System.EventHandler(this.btn_DeleteItem_Click);
            // 
            // btn_PrintItem
            // 
            this.btn_PrintItem.Image = global::Odin.Global_Resourses.Printer;
            this.btn_PrintItem.Name = "btn_PrintItem";
            this.btn_PrintItem.Size = new System.Drawing.Size(180, 22);
            this.btn_PrintItem.Text = "Print launch";
            this.btn_PrintItem.Click += new System.EventHandler(this.btn_PrintItem_Click);
            // 
            // btn_LaunchPassport
            // 
            this.btn_LaunchPassport.Image = global::Odin.Global_Resourses.folder_documents;
            this.btn_LaunchPassport.Name = "btn_LaunchPassport";
            this.btn_LaunchPassport.Size = new System.Drawing.Size(180, 22);
            this.btn_LaunchPassport.Text = "Launch passport";
            this.btn_LaunchPassport.Click += new System.EventHandler(this.btn_LaunchPassport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // redTagToolStripMenuItem
            // 
            this.redTagToolStripMenuItem.Name = "redTagToolStripMenuItem";
            this.redTagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redTagToolStripMenuItem.Text = "Red tag";
            this.redTagToolStripMenuItem.Visible = false;
            // 
            // yellowTagToolStripMenuItem
            // 
            this.yellowTagToolStripMenuItem.Name = "yellowTagToolStripMenuItem";
            this.yellowTagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yellowTagToolStripMenuItem.Text = "Yellow tag";
            this.yellowTagToolStripMenuItem.Visible = false;
            // 
            // greenTagToolStripMenuItem
            // 
            this.greenTagToolStripMenuItem.Name = "greenTagToolStripMenuItem";
            this.greenTagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenTagToolStripMenuItem.Text = "Green tag";
            this.greenTagToolStripMenuItem.Visible = false;
            // 
            // blueTagToolStripMenuItem
            // 
            this.blueTagToolStripMenuItem.Name = "blueTagToolStripMenuItem";
            this.blueTagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueTagToolStripMenuItem.Text = "Blue tag";
            this.blueTagToolStripMenuItem.Visible = false;
            // 
            // otherColorTagToolStripMenuItem
            // 
            this.otherColorTagToolStripMenuItem.Name = "otherColorTagToolStripMenuItem";
            this.otherColorTagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherColorTagToolStripMenuItem.Text = "Other color tag...";
            this.otherColorTagToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // timeScaleToolStripMenuItem
            // 
            this.timeScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hourToolStripMenuItem,
            this.minToolStripMenuItem,
            this.minToolStripMenuItem1,
            this.minToolStripMenuItem2});
            this.timeScaleToolStripMenuItem.Name = "timeScaleToolStripMenuItem";
            this.timeScaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timeScaleToolStripMenuItem.Text = "Timescale";
            // 
            // hourToolStripMenuItem
            // 
            this.hourToolStripMenuItem.Name = "hourToolStripMenuItem";
            this.hourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hourToolStripMenuItem.Text = "1 hour";
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minToolStripMenuItem.Text = "30 min";
            // 
            // minToolStripMenuItem1
            // 
            this.minToolStripMenuItem1.Name = "minToolStripMenuItem1";
            this.minToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.minToolStripMenuItem1.Text = "15 min";
            // 
            // minToolStripMenuItem2
            // 
            this.minToolStripMenuItem2.Name = "minToolStripMenuItem2";
            this.minToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.minToolStripMenuItem2.Text = "5 min";
            // 
            // btn_GroupLaunches
            // 
            this.btn_GroupLaunches.Image = global::Odin.Global_Resourses.layers;
            this.btn_GroupLaunches.Name = "btn_GroupLaunches";
            this.btn_GroupLaunches.Size = new System.Drawing.Size(180, 22);
            this.btn_GroupLaunches.Text = "Group launches";
            this.btn_GroupLaunches.Click += new System.EventHandler(this.btn_GroupLaunches_Click);
            // 
            // frm_LaunchesPlanningG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 686);
            this.Controls.Add(this.kryptonSplitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_LaunchesPlanningG";
            this.TabText = "Launches planning";
            this.Text = "Launches planning";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.cm_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Week.cmb_Week cmb_Week1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Excel;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private CMB_Components.Launches.cmb_Launches cmb_Launches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private Owf.Controls.GradientPanel2 gradientPanel21;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private CMB_Components.Users.cmb_Users cmb_Users1;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private System.Windows.Forms.Calendar.MonthView monthView1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ContextMenuStrip cm_Main;
        private System.Windows.Forms.ToolStripMenuItem btn_addItem;
        private System.Windows.Forms.ToolStripMenuItem btn_RMMissings;
        private System.Windows.Forms.ToolStripMenuItem btn_EditItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Start;
        private System.Windows.Forms.ToolStripMenuItem mni_AutoReserve;
        private System.Windows.Forms.ToolStripMenuItem btn_ReserveRM;
        private System.Windows.Forms.ToolStripMenuItem btn_CopyText;
        private System.Windows.Forms.ToolStripMenuItem btn_DeleteItem;
        private System.Windows.Forms.ToolStripMenuItem btn_PrintItem;
        private System.Windows.Forms.ToolStripMenuItem btn_LaunchPassport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem redTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherColorTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem timeScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_NotStarted;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public CustomControls.NullableDateTimePicker txt_DateFrom;
        public CustomControls.NullableDateTimePicker txt_DateTill;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private System.Windows.Forms.ToolStripMenuItem btn_InsertComment;
        private System.Windows.Forms.ToolStripMenuItem btn_GroupLaunches;
    }
}