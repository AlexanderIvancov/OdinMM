namespace Odin.Warehouse.Packing
{
    partial class frm_Packing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Packing));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Content = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Separate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_AddOrder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_boxid = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_DeliveryNotes1 = new Odin.CMB_Components.DeliveryNotes.cmb_DeliveryNotes();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Serial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmb_SalesOrdersWithLines1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrdersWithLines();
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
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_boxno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ddelivplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_daddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_inid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_delivnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_finaldestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_delivid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_closedat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_closedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_closedplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_additcontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.txt_ClosingDate = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.kryptonPanel1.Controls.Add(this.btn_Content);
            this.kryptonPanel1.Controls.Add(this.btn_Print);
            this.kryptonPanel1.Controls.Add(this.btn_Edit);
            this.kryptonPanel1.Controls.Add(this.btn_Separate);
            this.kryptonPanel1.Controls.Add(this.btn_AddOrder);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel1.Size = new System.Drawing.Size(1018, 49);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // btn_Content
            // 
            this.btn_Content.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Content.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Content.Location = new System.Drawing.Point(468, 5);
            this.btn_Content.Name = "btn_Content";
            this.btn_Content.Size = new System.Drawing.Size(115, 39);
            this.btn_Content.TabIndex = 236;
            this.btn_Content.Values.Image = global::Odin.Global_Resourses.barcode_2d;
            this.btn_Content.Values.Text = "Show content";
            this.btn_Content.Click += new System.EventHandler(this.btn_Content_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Print.Location = new System.Drawing.Point(368, 5);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(100, 39);
            this.btn_Print.TabIndex = 235;
            this.btn_Print.Values.Image = global::Odin.Global_Resourses.Print2;
            this.btn_Print.Values.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Edit.Location = new System.Drawing.Point(263, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(105, 39);
            this.btn_Edit.TabIndex = 234;
            this.btn_Edit.Values.Image = global::Odin.Global_Resourses.edit;
            this.btn_Edit.Values.Text = "Edit box";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Separate
            // 
            this.btn_Separate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Separate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Separate.Location = new System.Drawing.Point(134, 5);
            this.btn_Separate.Name = "btn_Separate";
            this.btn_Separate.Size = new System.Drawing.Size(129, 39);
            this.btn_Separate.TabIndex = 233;
            this.btn_Separate.Values.Image = global::Odin.Global_Resourses.arrow_divide;
            this.btn_Separate.Values.Text = "Separate box";
            this.btn_Separate.Click += new System.EventHandler(this.btn_Separate_Click);
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_AddOrder.Location = new System.Drawing.Point(5, 5);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(129, 39);
            this.btn_AddOrder.TabIndex = 232;
            this.btn_AddOrder.Values.Image = global::Odin.Global_Resourses.Docs;
            this.btn_AddOrder.Values.Text = "Change order";
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
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
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1018, 506);
            this.kryptonSplitContainer1.SplitterDistance = 449;
            this.kryptonSplitContainer1.TabIndex = 5;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_ClosingDate);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_boxid);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_DeliveryNotes1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel12);
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
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1018, 449);
            this.kryptonSplitContainer2.SplitterDistance = 313;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(9, 50);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel6.TabIndex = 291;
            this.kryptonLabel6.Values.Text = "Box ID:";
            // 
            // txt_boxid
            // 
            this.txt_boxid.AllowDecimalSeparator = false;
            this.txt_boxid.AllowSpace = false;
            this.txt_boxid.Location = new System.Drawing.Point(134, 47);
            this.txt_boxid.Name = "txt_boxid";
            this.txt_boxid.Size = new System.Drawing.Size(100, 23);
            this.txt_boxid.TabIndex = 290;
            this.txt_boxid.Text = "0";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(6, 197);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel5.TabIndex = 289;
            this.kryptonLabel5.Values.Text = "Delivery note:";
            // 
            // cmb_DeliveryNotes1
            // 
            this.cmb_DeliveryNotes1.DelivNote = "";
            this.cmb_DeliveryNotes1.DelivNoteId = 0;
            this.cmb_DeliveryNotes1.DelivNoteSavedId = 0;
            this.cmb_DeliveryNotes1.EnableSearchId = false;
            this.cmb_DeliveryNotes1.Location = new System.Drawing.Point(94, 197);
            this.cmb_DeliveryNotes1.Name = "cmb_DeliveryNotes1";
            this.cmb_DeliveryNotes1.Size = new System.Drawing.Size(193, 20);
            this.cmb_DeliveryNotes1.TabIndex = 288;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(9, 73);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(124, 20);
            this.kryptonLabel12.TabIndex = 287;
            this.kryptonLabel12.Values.Text = "Serial NR of product:";
            // 
            // txt_Serial
            // 
            this.txt_Serial.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_Serial.Location = new System.Drawing.Point(134, 73);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(159, 23);
            this.txt_Serial.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Serial.TabIndex = 286;
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny4.UniqueName = "00654834D5824273E0820F141B99704A";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
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
            this.kryptonLabel4.Location = new System.Drawing.Point(6, 223);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel4.TabIndex = 220;
            this.kryptonLabel4.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(94, 223);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(169, 20);
            this.cmb_Types1.TabIndex = 218;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 148);
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
            this.gradientPanel22.Location = new System.Drawing.Point(8, 99);
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
            this.cmb_Batches1.Size = new System.Drawing.Size(128, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 213;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(7, 130);
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
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_package,
            this.cn_boxno,
            this.cn_batch,
            this.cn_qty,
            this.cn_artid,
            this.cn_article,
            this.cn_custcode,
            this.cn_coid,
            this.cn_custarticle,
            this.cn_dconforder,
            this.cn_custorder,
            this.cn_dclient,
            this.cn_dunit,
            this.cn_ddelivplace,
            this.cn_daddress,
            this.cn_weight,
            this.cn_inid,
            this.cn_comments,
            this.cn_batchid,
            this.cn_delivnote,
            this.cn_finaldestination,
            this.cn_state,
            this.cn_delivid,
            this.cn_closedat,
            this.cn_closedby,
            this.cn_closedplace,
            this.cn_additcontent,
            this.cn_headid});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(700, 424);
            this.gv_List.TabIndex = 7;
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
            // cn_package
            // 
            this.cn_package.DataPropertyName = "package";
            this.cn_package.HeaderText = "Package";
            this.cn_package.Name = "cn_package";
            this.cn_package.ReadOnly = true;
            // 
            // cn_boxno
            // 
            this.cn_boxno.DataPropertyName = "boxno";
            this.cn_boxno.FillWeight = 50F;
            this.cn_boxno.HeaderText = "Box NO.";
            this.cn_boxno.Name = "cn_boxno";
            this.cn_boxno.ReadOnly = true;
            this.cn_boxno.Width = 50;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.ReadOnly = true;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 70F;
            this.cn_qty.HeaderText = "Qty in box";
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
            // cn_custcode
            // 
            this.cn_custcode.DataPropertyName = "custcode";
            this.cn_custcode.HeaderText = "Custom\'s code";
            this.cn_custcode.Name = "cn_custcode";
            // 
            // cn_coid
            // 
            this.cn_coid.DataPropertyName = "coid";
            this.cn_coid.FillWeight = 80F;
            this.cn_coid.HeaderText = "coid";
            this.cn_coid.Name = "cn_coid";
            this.cn_coid.ReadOnly = true;
            this.cn_coid.Visible = false;
            this.cn_coid.Width = 80;
            // 
            // cn_custarticle
            // 
            this.cn_custarticle.DataPropertyName = "custarticle";
            this.cn_custarticle.FillWeight = 150F;
            this.cn_custarticle.HeaderText = "Cust. article";
            this.cn_custarticle.Name = "cn_custarticle";
            this.cn_custarticle.ReadOnly = true;
            this.cn_custarticle.Width = 150;
            // 
            // cn_dconforder
            // 
            this.cn_dconforder.DataPropertyName = "conforder";
            this.cn_dconforder.HeaderText = "Conf. order";
            this.cn_dconforder.Name = "cn_dconforder";
            this.cn_dconforder.ReadOnly = true;
            // 
            // cn_custorder
            // 
            this.cn_custorder.DataPropertyName = "custorder";
            this.cn_custorder.HeaderText = "Customer\'s order";
            this.cn_custorder.Name = "cn_custorder";
            this.cn_custorder.ReadOnly = true;
            // 
            // cn_dclient
            // 
            this.cn_dclient.DataPropertyName = "client";
            this.cn_dclient.FillWeight = 120F;
            this.cn_dclient.HeaderText = "Customer";
            this.cn_dclient.Name = "cn_dclient";
            this.cn_dclient.ReadOnly = true;
            this.cn_dclient.Width = 120;
            // 
            // cn_dunit
            // 
            this.cn_dunit.DataPropertyName = "unit";
            this.cn_dunit.FillWeight = 40F;
            this.cn_dunit.HeaderText = "Unit";
            this.cn_dunit.Name = "cn_dunit";
            this.cn_dunit.ReadOnly = true;
            this.cn_dunit.Width = 40;
            // 
            // cn_ddelivplace
            // 
            this.cn_ddelivplace.DataPropertyName = "delivplace";
            this.cn_ddelivplace.FillWeight = 150F;
            this.cn_ddelivplace.HeaderText = "Deliv. place";
            this.cn_ddelivplace.Name = "cn_ddelivplace";
            this.cn_ddelivplace.ReadOnly = true;
            this.cn_ddelivplace.Width = 150;
            // 
            // cn_daddress
            // 
            this.cn_daddress.DataPropertyName = "delivaddress";
            this.cn_daddress.FillWeight = 125F;
            this.cn_daddress.HeaderText = "Deliv. address";
            this.cn_daddress.Name = "cn_daddress";
            this.cn_daddress.ReadOnly = true;
            this.cn_daddress.Width = 125;
            // 
            // cn_weight
            // 
            this.cn_weight.DataPropertyName = "weight";
            this.cn_weight.HeaderText = "Weight";
            this.cn_weight.Name = "cn_weight";
            this.cn_weight.ReadOnly = true;
            // 
            // cn_inid
            // 
            this.cn_inid.DataPropertyName = "inid";
            this.cn_inid.HeaderText = "inid";
            this.cn_inid.Name = "cn_inid";
            this.cn_inid.Visible = false;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.Width = 150;
            // 
            // cn_batchid
            // 
            this.cn_batchid.DataPropertyName = "batchid";
            this.cn_batchid.HeaderText = "batchid";
            this.cn_batchid.Name = "cn_batchid";
            this.cn_batchid.Visible = false;
            // 
            // cn_delivnote
            // 
            this.cn_delivnote.DataPropertyName = "delivnote";
            this.cn_delivnote.HeaderText = "Deliv. note";
            this.cn_delivnote.Name = "cn_delivnote";
            // 
            // cn_finaldestination
            // 
            this.cn_finaldestination.DataPropertyName = "finaldestination";
            this.cn_finaldestination.HeaderText = "Final destination";
            this.cn_finaldestination.Name = "cn_finaldestination";
            // 
            // cn_state
            // 
            this.cn_state.DataPropertyName = "state";
            this.cn_state.HeaderText = "State";
            this.cn_state.Name = "cn_state";
            // 
            // cn_delivid
            // 
            this.cn_delivid.DataPropertyName = "delivid";
            this.cn_delivid.HeaderText = "delivid";
            this.cn_delivid.Name = "cn_delivid";
            this.cn_delivid.Visible = false;
            // 
            // cn_closedat
            // 
            this.cn_closedat.DataPropertyName = "closedat";
            this.cn_closedat.HeaderText = "Closed at";
            this.cn_closedat.Name = "cn_closedat";
            // 
            // cn_closedby
            // 
            this.cn_closedby.DataPropertyName = "closedby";
            this.cn_closedby.HeaderText = "Closed by";
            this.cn_closedby.Name = "cn_closedby";
            // 
            // cn_closedplace
            // 
            this.cn_closedplace.DataPropertyName = "closedplace";
            this.cn_closedplace.HeaderText = "Place of closing";
            this.cn_closedplace.Name = "cn_closedplace";
            // 
            // cn_additcontent
            // 
            this.cn_additcontent.DataPropertyName = "addcontent";
            this.cn_additcontent.HeaderText = "Add. content";
            this.cn_additcontent.Name = "cn_additcontent";
            // 
            // cn_headid
            // 
            this.cn_headid.DataPropertyName = "headid";
            this.cn_headid.HeaderText = "headid";
            this.cn_headid.Name = "cn_headid";
            this.cn_headid.Visible = false;
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
            this.btn_Delete,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 424);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(700, 25);
            this.bn_List.TabIndex = 2;
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
            // btn_Delete
            // 
            this.btn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Delete.Image = global::Odin.Global_Resourses.bindingNavigatorDeleteItem_Image;
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(23, 22);
            this.btn_Delete.Text = "Delete box";
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
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1018, 52);
            this.kryptonDockableWorkspace1.TabIndex = 4;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "E19B0EA24B3C4C4B83BBA9440FB95A94";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // txt_ClosingDate
            // 
            this.txt_ClosingDate.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_ClosingDate.CalendarShowWeekNumbers = true;
            this.txt_ClosingDate.CustomFormat = null;
            this.txt_ClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ClosingDate.Location = new System.Drawing.Point(94, 249);
            this.txt_ClosingDate.Name = "txt_ClosingDate";
            this.txt_ClosingDate.NullValue = " ";
            this.txt_ClosingDate.Size = new System.Drawing.Size(105, 21);
            this.txt_ClosingDate.TabIndex = 295;
            this.txt_ClosingDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_ClosingDate_DropDown);
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny5.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(8, 249);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(81, 20);
            this.kryptonLabel8.TabIndex = 294;
            this.kryptonLabel8.Values.Text = "Closing date:";
            // 
            // frm_Packing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 555);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Packing";
            this.TabText = "FC packing";
            this.Text = "FC packing";
            this.Load += new System.EventHandler(this.frm_Packing_Load);
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Edit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Separate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
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
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private Global_Classes.SyncBindingSource bs_List;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Serial;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Content;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CMB_Components.DeliveryNotes.cmb_DeliveryNotes cmb_DeliveryNotes1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Owf.Controls.NumericTetxBox txt_boxid;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_package;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_boxno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ddelivplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_daddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_delivnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_finaldestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_delivid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_closedat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_closedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_closedplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_additcontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_headid;
        private CustomControls.NullableDateTimePicker txt_ClosingDate;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
    }
}