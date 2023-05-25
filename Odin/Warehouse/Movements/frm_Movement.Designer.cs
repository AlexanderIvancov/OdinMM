namespace Odin.Warehouse.Movements
{
    partial class frm_Movement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Movement));
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_LabelDets = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.mnu_LinesDets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_FilterForD = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminD = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bs_Dets = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonLabel22 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Launches1 = new Odin.CMB_Components.Launches.cmb_Launches();
            this.cmb_Articles2 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.cmb_Batches2 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.kryptonLabel19 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Users1 = new Odin.CMB_Components.Users.cmb_Users();
            this.gradientPanel23 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel18 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_PalWeight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_PalQty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Incoterms = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Transport = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_FinDestAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_FinDestPlace = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_DelivAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_DelivPlace = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gradientPanel21 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_DocDate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_MoveDocs1 = new Odin.CMB_Components.MoveDocs.cmb_MoveDocs();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.mnu_RepType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_Production = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Movement = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_PrintDLN = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.btn_ClearList = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel20 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyOfProduct = new Owf.Controls.NumericTetxBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.chk_Reserve = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmb_Places1 = new Odin.CMB_Components.Places.cmb_Places();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_StencilRequired = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_BatchStages1 = new Odin.CMB_Components.BatchStages.cmb_BatchStages();
            this.kryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Places2 = new Odin.CMB_Components.Places.cmb_Places();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Label = new Owf.Controls.NumericTetxBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gv_Dets = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_labelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_darticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dqtyoper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_placeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_labelto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_Dets = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_IntoExcelDets = new System.Windows.Forms.ToolStripButton();
            this.kryptonHeader3 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.cn_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyinbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.cn_qtytomove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyreserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_tomove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_docdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_placeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_storagerules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.mnu_LinesDets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Dets)).BeginInit();
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
            this.mnu_RepType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Dets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Dets)).BeginInit();
            this.bn_Dets.SuspendLayout();
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
            // mnu_Lines
            // 
            this.mnu_Lines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Lines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_LabelDets,
            this.mni_FilterFor,
            this.mni_Search,
            this.mni_FilterBy,
            this.mni_FilterExcludingSel,
            this.mni_RemoveFilter,
            this.mni_Copy,
            this.toolStripSeparator2,
            this.mni_Admin});
            this.mnu_Lines.Name = "mnu_Requests";
            this.mnu_Lines.Size = new System.Drawing.Size(211, 189);
            this.mnu_Lines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_Lines_Opening);
            // 
            // mni_LabelDets
            // 
            this.mni_LabelDets.Image = global::Odin.Global_Resourses.barcode_2d;
            this.mni_LabelDets.Name = "mni_LabelDets";
            this.mni_LabelDets.Size = new System.Drawing.Size(210, 22);
            this.mni_LabelDets.Text = "Label details";
            this.mni_LabelDets.Click += new System.EventHandler(this.mni_LabelDets_Click);
            // 
            // mni_FilterFor
            // 
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
            // mnu_LinesDets
            // 
            this.mnu_LinesDets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_LinesDets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_FilterForD,
            this.mni_SearchD,
            this.mni_FilterByD,
            this.mni_FilterExcludingSelD,
            this.mni_RemoveFilterD,
            this.mni_CopyD,
            this.toolStripSeparator5,
            this.mni_AdminD});
            this.mnu_LinesDets.Name = "mnu_Requests";
            this.mnu_LinesDets.Size = new System.Drawing.Size(211, 167);
            this.mnu_LinesDets.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesDets_Opening);
            // 
            // txt_FilterForD
            // 
            this.txt_FilterForD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FilterForD.Name = "txt_FilterForD";
            this.txt_FilterForD.Size = new System.Drawing.Size(150, 23);
            this.txt_FilterForD.TextChanged += new System.EventHandler(this.txt_FilterForD_TextChanged);
            // 
            // mni_SearchD
            // 
            this.mni_SearchD.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchD.Name = "mni_SearchD";
            this.mni_SearchD.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchD.Text = "Search for record";
            this.mni_SearchD.Click += new System.EventHandler(this.mni_SearchD_Click);
            // 
            // mni_FilterByD
            // 
            this.mni_FilterByD.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByD.Name = "mni_FilterByD";
            this.mni_FilterByD.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByD.Text = "Filter by selection";
            this.mni_FilterByD.Click += new System.EventHandler(this.mni_FilterByD_Click);
            // 
            // mni_FilterExcludingSelD
            // 
            this.mni_FilterExcludingSelD.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelD.Name = "mni_FilterExcludingSelD";
            this.mni_FilterExcludingSelD.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelD.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelD.Click += new System.EventHandler(this.mni_FilterExcludingSelD_Click);
            // 
            // mni_RemoveFilterD
            // 
            this.mni_RemoveFilterD.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterD.Name = "mni_RemoveFilterD";
            this.mni_RemoveFilterD.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterD.Text = "Remove filter";
            this.mni_RemoveFilterD.Click += new System.EventHandler(this.mni_RemoveFilterD_Click);
            // 
            // mni_CopyD
            // 
            this.mni_CopyD.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyD.Name = "mni_CopyD";
            this.mni_CopyD.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyD.Text = "Copy";
            this.mni_CopyD.Click += new System.EventHandler(this.mni_CopyD_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminD
            // 
            this.mni_AdminD.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminD.Name = "mni_AdminD";
            this.mni_AdminD.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminD.Text = "List settings";
            this.mni_AdminD.Click += new System.EventHandler(this.mni_AdminD_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document_plain.png");
            this.imageList1.Images.SetKeyName(1, "preferences.png");
            this.imageList1.Images.SetKeyName(2, "information2.png");
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
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.gv_Dets);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.bn_Dets);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeader3);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1205, 650);
            this.kryptonSplitContainer1.SplitterDistance = 471;
            this.kryptonSplitContainer1.TabIndex = 10;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Launches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel21);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Common1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Batches2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel19);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Users1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel23);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel18);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_PalWeight);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel14);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel13);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_PalQty);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel12);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Incoterms);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel11);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Transport);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel10);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_FinDestAddress);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel9);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_FinDestPlace);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel8);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_DelivAddress);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_DelivPlace);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel21);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Comments);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_DocDate);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_MoveDocs1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.gv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.kryptonPanel3);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.kryptonPanel2);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1205, 471);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Location = new System.Drawing.Point(5, 100);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel22.TabIndex = 272;
            this.kryptonLabel22.Values.Text = "Launch:";
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
            this.cmb_Launches1.Location = new System.Drawing.Point(107, 100);
            this.cmb_Launches1.Name = "cmb_Launches1";
            this.cmb_Launches1.ParentBatchId = 0;
            this.cmb_Launches1.Qty = 0D;
            this.cmb_Launches1.SecName = null;
            this.cmb_Launches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Launches1.StageId = 0;
            this.cmb_Launches1.StartDate = "";
            this.cmb_Launches1.TabIndex = 271;
            // 
            // cmb_Articles2
            // 
            this.cmb_Articles2.Article = "";
            this.cmb_Articles2.ArticleId = 0;
            this.cmb_Articles2.ArticleIdRec = 0;
            this.cmb_Articles2.ArtType = null;
            this.cmb_Articles2.BOMState = 0;
            this.cmb_Articles2.Comments = null;
            this.cmb_Articles2.CustCode = null;
            this.cmb_Articles2.CustCodeId = 0;
            this.cmb_Articles2.Department = null;
            this.cmb_Articles2.DeptId = 0;
            this.cmb_Articles2.Description = null;
            this.cmb_Articles2.IsActive = -1;
            this.cmb_Articles2.IsPF = 0;
            this.cmb_Articles2.Location = new System.Drawing.Point(64, 185);
            this.cmb_Articles2.Manufacturer = "";
            this.cmb_Articles2.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles2.Name = "cmb_Articles2";
            this.cmb_Articles2.Project = null;
            this.cmb_Articles2.ProjectId = 0;
            this.cmb_Articles2.QtyAvail = 0D;
            this.cmb_Articles2.QtyConsStock = 0D;
            this.cmb_Articles2.RMId = 0;
            this.cmb_Articles2.SecName = null;
            this.cmb_Articles2.Size = new System.Drawing.Size(228, 20);
            this.cmb_Articles2.SMTType = 0;
            this.cmb_Articles2.SpoilConst = 0D;
            this.cmb_Articles2.Stage = null;
            this.cmb_Articles2.StageID = 0;
            this.cmb_Articles2.TabIndex = 270;
            this.cmb_Articles2.TypeId = 0;
            this.cmb_Articles2.Unit = null;
            this.cmb_Articles2.UnitId = 0;
            this.cmb_Articles2.Weight = 0D;
            // 
            // kryptonLabel21
            // 
            this.kryptonLabel21.Location = new System.Drawing.Point(5, 184);
            this.kryptonLabel21.Name = "kryptonLabel21";
            this.kryptonLabel21.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel21.TabIndex = 269;
            this.kryptonLabel21.Values.Text = "Product:";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(107, 7);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(90, 20);
            this.cmb_Common1.sTable = "vw_ProductionStagesOnly";
            this.cmb_Common1.sText_Filled = "name";
            this.cmb_Common1.sTitle = "Stages of usage";
            this.cmb_Common1.TabIndex = 267;
            // 
            // cmb_Batches2
            // 
            this.cmb_Batches2.ActiveOnly = 0;
            this.cmb_Batches2.Article = null;
            this.cmb_Batches2.ArticleId = 0;
            this.cmb_Batches2.Batch = "";
            this.cmb_Batches2.BatchId = 0;
            this.cmb_Batches2.Comments = "";
            this.cmb_Batches2.ConfOrder = "";
            this.cmb_Batches2.ConfOrderId = 0;
            this.cmb_Batches2.CustArticle = "";
            this.cmb_Batches2.Customer = "";
            this.cmb_Batches2.IsActive = 0;
            this.cmb_Batches2.IsGroup = 0;
            this.cmb_Batches2.IsProject = 0;
            this.cmb_Batches2.IsQuote = 0;
            this.cmb_Batches2.Location = new System.Drawing.Point(107, 74);
            this.cmb_Batches2.Name = "cmb_Batches2";
            this.cmb_Batches2.ParentBatchId = 0;
            this.cmb_Batches2.Qty = 0D;
            this.cmb_Batches2.QtyLabels = 0;
            this.cmb_Batches2.ResDate = null;
            this.cmb_Batches2.SecName = null;
            this.cmb_Batches2.Size = new System.Drawing.Size(135, 20);
            this.cmb_Batches2.Stages = "";
            this.cmb_Batches2.StencilRequired = 0;
            this.cmb_Batches2.TabIndex = 266;
            this.cmb_Batches2.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches2_BatchChanged);
            this.cmb_Batches2.ControlClick += new Odin.CMB_Components.Batches.BatchControlEventHeader(this.cmb_Batches2_ControlClick);
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Location = new System.Drawing.Point(5, 408);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(117, 20);
            this.kryptonLabel19.TabIndex = 265;
            this.kryptonLabel19.Values.Text = "Assembling person:";
            // 
            // cmb_Users1
            // 
            this.cmb_Users1.Location = new System.Drawing.Point(5, 428);
            this.cmb_Users1.Name = "cmb_Users1";
            this.cmb_Users1.Size = new System.Drawing.Size(287, 20);
            this.cmb_Users1.TabIndex = 264;
            this.cmb_Users1.User = "";
            this.cmb_Users1.UserId = 0;
            this.cmb_Users1.UserLogin = null;
            this.cmb_Users1.UserShortName = "";
            this.cmb_Users1.UserTN = "";
            // 
            // gradientPanel23
            // 
            this.gradientPanel23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel23.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel23.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel23.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel23.Location = new System.Drawing.Point(5, 404);
            this.gradientPanel23.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel23.Name = "gradientPanel23";
            this.gradientPanel23.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel23.ShowBottomBorder = true;
            this.gradientPanel23.ShowLeftBorder = true;
            this.gradientPanel23.ShowRightBorder = true;
            this.gradientPanel23.ShowTopBorder = true;
            this.gradientPanel23.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel23.StartColor = System.Drawing.Color.White;
            this.gradientPanel23.TabIndex = 263;
            // 
            // kryptonLabel18
            // 
            this.kryptonLabel18.Location = new System.Drawing.Point(5, 74);
            this.kryptonLabel18.Name = "kryptonLabel18";
            this.kryptonLabel18.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel18.TabIndex = 262;
            this.kryptonLabel18.Values.Text = "Batch:";
            // 
            // txt_PalWeight
            // 
            this.txt_PalWeight.Location = new System.Drawing.Point(238, 377);
            this.txt_PalWeight.Name = "txt_PalWeight";
            this.txt_PalWeight.Size = new System.Drawing.Size(54, 23);
            this.txt_PalWeight.TabIndex = 260;
            this.txt_PalWeight.Text = "0";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(148, 377);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel14.TabIndex = 259;
            this.kryptonLabel14.Values.Text = "Pal. weight:";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(5, 377);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel13.TabIndex = 258;
            this.kryptonLabel13.Values.Text = "Palettes qty:";
            // 
            // txt_PalQty
            // 
            this.txt_PalQty.Location = new System.Drawing.Point(88, 377);
            this.txt_PalQty.Name = "txt_PalQty";
            this.txt_PalQty.Size = new System.Drawing.Size(54, 23);
            this.txt_PalQty.TabIndex = 257;
            this.txt_PalQty.Text = "0";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(5, 351);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel12.TabIndex = 256;
            this.kryptonLabel12.Values.Text = "Incoterms:";
            // 
            // txt_Incoterms
            // 
            this.txt_Incoterms.Location = new System.Drawing.Point(118, 351);
            this.txt_Incoterms.Name = "txt_Incoterms";
            this.txt_Incoterms.Size = new System.Drawing.Size(174, 23);
            this.txt_Incoterms.TabIndex = 255;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(5, 325);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel11.TabIndex = 254;
            this.kryptonLabel11.Values.Text = "Transport:";
            // 
            // txt_Transport
            // 
            this.txt_Transport.Location = new System.Drawing.Point(118, 325);
            this.txt_Transport.Name = "txt_Transport";
            this.txt_Transport.Size = new System.Drawing.Size(174, 23);
            this.txt_Transport.TabIndex = 253;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(5, 299);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(107, 20);
            this.kryptonLabel10.TabIndex = 252;
            this.kryptonLabel10.Values.Text = "Fin. dest. address:";
            // 
            // txt_FinDestAddress
            // 
            this.txt_FinDestAddress.Location = new System.Drawing.Point(118, 299);
            this.txt_FinDestAddress.Name = "txt_FinDestAddress";
            this.txt_FinDestAddress.Size = new System.Drawing.Size(174, 23);
            this.txt_FinDestAddress.TabIndex = 251;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(5, 273);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel9.TabIndex = 250;
            this.kryptonLabel9.Values.Text = "Fin. dest. place:";
            // 
            // txt_FinDestPlace
            // 
            this.txt_FinDestPlace.Location = new System.Drawing.Point(118, 273);
            this.txt_FinDestPlace.Name = "txt_FinDestPlace";
            this.txt_FinDestPlace.Size = new System.Drawing.Size(174, 23);
            this.txt_FinDestPlace.TabIndex = 249;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(5, 247);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel8.TabIndex = 248;
            this.kryptonLabel8.Values.Text = "Deliv. address:";
            // 
            // txt_DelivAddress
            // 
            this.txt_DelivAddress.Location = new System.Drawing.Point(118, 247);
            this.txt_DelivAddress.Name = "txt_DelivAddress";
            this.txt_DelivAddress.Size = new System.Drawing.Size(174, 23);
            this.txt_DelivAddress.TabIndex = 247;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(5, 221);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel7.TabIndex = 246;
            this.kryptonLabel7.Values.Text = "Deliv. place:";
            // 
            // txt_DelivPlace
            // 
            this.txt_DelivPlace.Location = new System.Drawing.Point(118, 221);
            this.txt_DelivPlace.Name = "txt_DelivPlace";
            this.txt_DelivPlace.Size = new System.Drawing.Size(174, 23);
            this.txt_DelivPlace.TabIndex = 245;
            // 
            // gradientPanel21
            // 
            this.gradientPanel21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel21.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel21.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel21.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel21.Location = new System.Drawing.Point(5, 212);
            this.gradientPanel21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel21.Name = "gradientPanel21";
            this.gradientPanel21.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel21.ShowBottomBorder = true;
            this.gradientPanel21.ShowLeftBorder = true;
            this.gradientPanel21.ShowRightBorder = true;
            this.gradientPanel21.ShowTopBorder = true;
            this.gradientPanel21.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel21.StartColor = System.Drawing.Color.White;
            this.gradientPanel21.TabIndex = 239;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(5, 160);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel6.TabIndex = 244;
            this.kryptonLabel6.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(107, 160);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(185, 23);
            this.txt_Comments.TabIndex = 243;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(5, 136);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel4.TabIndex = 242;
            this.kryptonLabel4.Values.Text = "Doc. date:";
            // 
            // txt_DocDate
            // 
            this.txt_DocDate.Location = new System.Drawing.Point(107, 136);
            this.txt_DocDate.Name = "txt_DocDate";
            this.txt_DocDate.Size = new System.Drawing.Size(112, 23);
            this.txt_DocDate.TabIndex = 241;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 48);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel3.TabIndex = 240;
            this.kryptonLabel3.Values.Text = "Movement doc.:";
            // 
            // cmb_MoveDocs1
            // 
            this.cmb_MoveDocs1.EnableSearchId = false;
            this.cmb_MoveDocs1.Location = new System.Drawing.Point(107, 48);
            this.cmb_MoveDocs1.MoveDoc = "";
            this.cmb_MoveDocs1.MoveDocId = 0;
            this.cmb_MoveDocs1.MoveDocSavedId = 0;
            this.cmb_MoveDocs1.Name = "cmb_MoveDocs1";
            this.cmb_MoveDocs1.Size = new System.Drawing.Size(185, 20);
            this.cmb_MoveDocs1.TabIndex = 239;
            this.cmb_MoveDocs1.MoveDocChanged += new Odin.CMB_Components.MoveDocs.MoveDocEventHandler(this.cmb_MoveDocs1_MoveDocChanged);
            this.cmb_MoveDocs1.ControlClick += new Odin.CMB_Components.MoveDocs.MoveDocControlEventHeader(this.cmb_MoveDocs1_ControlClick);
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(4, 126);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 238;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Print,
            this.btn_PrintDLN,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(299, 34);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Header";
            this.kryptonHeader1.Values.Image = global::Odin.Global_Resourses.Synchronize_24x24;
            // 
            // btn_Print
            // 
            this.btn_Print.ContextMenuStrip = this.mnu_RepType;
            this.btn_Print.Image = global::Odin.Global_Resourses.Printer;
            this.btn_Print.ToolTipBody = "Refresh";
            this.btn_Print.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // mnu_RepType
            // 
            this.mnu_RepType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_RepType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_Production,
            this.mni_Movement});
            this.mnu_RepType.Name = "mnu_Requests";
            this.mnu_RepType.Size = new System.Drawing.Size(134, 48);
            // 
            // mni_Production
            // 
            this.mni_Production.Image = global::Odin.Global_Resourses.Assembling_48x48;
            this.mni_Production.Name = "mni_Production";
            this.mni_Production.Size = new System.Drawing.Size(133, 22);
            this.mni_Production.Text = "Production";
            this.mni_Production.Click += new System.EventHandler(this.mni_Production_Click);
            // 
            // mni_Movement
            // 
            this.mni_Movement.Image = global::Odin.Global_Resourses.Transfer;
            this.mni_Movement.Name = "mni_Movement";
            this.mni_Movement.Size = new System.Drawing.Size(133, 22);
            this.mni_Movement.Text = "Movement";
            this.mni_Movement.Click += new System.EventHandler(this.mni_Movement_Click);
            // 
            // btn_PrintDLN
            // 
            this.btn_PrintDLN.Image = global::Odin.Global_Resourses.PrintDLN24x24;
            this.btn_PrintDLN.UniqueName = "619A25F513F443B3009B70E95B809C41";
            this.btn_PrintDLN.Click += new System.EventHandler(this.btn_PrintDLN_Click);
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
            this.cn_label,
            this.cn_artid,
            this.cn_article,
            this.cn_place,
            this.cn_qty,
            this.cn_qtyinbatch,
            this.cn_unit,
            this.btn_Add,
            this.cn_qtytomove,
            this.cn_qtyreserved,
            this.cn_comments,
            this.cn_expdate,
            this.cn_bdid,
            this.cn_reservation,
            this.cn_tomove,
            this.cn_docdate,
            this.cn_placeid,
            this.cn_storagerules});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 133);
            this.gv_List.Name = "gv_List";
            this.gv_List.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(901, 241);
            this.gv_List.TabIndex = 6;
            this.gv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellClick);
            this.gv_List.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gv_List_CellPainting);
            this.gv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValidated);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
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
            this.btn_ClearList,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 374);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(901, 25);
            this.bn_List.TabIndex = 5;
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
            // btn_ClearList
            // 
            this.btn_ClearList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ClearList.Image = global::Odin.Global_Resourses.clear;
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.RightToLeftAutoMirrorImage = true;
            this.btn_ClearList.Size = new System.Drawing.Size(23, 22);
            this.btn_ClearList.Text = "Clear";
            this.btn_ClearList.Click += new System.EventHandler(this.btn_ClearList_Click);
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
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonLabel20);
            this.kryptonPanel3.Controls.Add(this.txt_QtyOfProduct);
            this.kryptonPanel3.Controls.Add(this.chk_Reserve);
            this.kryptonPanel3.Controls.Add(this.btn_OK);
            this.kryptonPanel3.Controls.Add(this.cmb_Places1);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 399);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel3.Size = new System.Drawing.Size(901, 72);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonLabel20
            // 
            this.kryptonLabel20.Location = new System.Drawing.Point(530, 17);
            this.kryptonLabel20.Name = "kryptonLabel20";
            this.kryptonLabel20.Size = new System.Drawing.Size(147, 20);
            this.kryptonLabel20.TabIndex = 247;
            this.kryptonLabel20.Values.Text = "Qty to produce on stage:";
            this.kryptonLabel20.Visible = false;
            // 
            // txt_QtyOfProduct
            // 
            this.txt_QtyOfProduct.AllowDecimalSeparator = false;
            this.txt_QtyOfProduct.AllowSpace = false;
            this.txt_QtyOfProduct.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_QtyOfProduct.Location = new System.Drawing.Point(677, 17);
            this.txt_QtyOfProduct.Name = "txt_QtyOfProduct";
            this.txt_QtyOfProduct.Size = new System.Drawing.Size(100, 23);
            this.txt_QtyOfProduct.TabIndex = 246;
            this.txt_QtyOfProduct.Text = "0";
            this.txt_QtyOfProduct.Visible = false;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "ED62D4F425E1454A7EB8AAF6D8EF2F6F";
            // 
            // chk_Reserve
            // 
            this.chk_Reserve.Checked = true;
            this.chk_Reserve.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Reserve.Location = new System.Drawing.Point(135, 40);
            this.chk_Reserve.Name = "chk_Reserve";
            this.chk_Reserve.Size = new System.Drawing.Size(100, 20);
            this.chk_Reserve.TabIndex = 245;
            this.chk_Reserve.Values.Text = "Reserve labels";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(404, 17);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OK.Size = new System.Drawing.Size(93, 40);
            this.btn_OK.TabIndex = 40;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // cmb_Places1
            // 
            this.cmb_Places1.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Places1.Department = "";
            this.cmb_Places1.IsQuarantine = 0;
            this.cmb_Places1.Location = new System.Drawing.Point(135, 14);
            this.cmb_Places1.Lock = 0;
            this.cmb_Places1.Name = "cmb_Places1";
            this.cmb_Places1.PlaceId = 0;
            this.cmb_Places1.SelectedNode = null;
            this.cmb_Places1.Size = new System.Drawing.Size(231, 20);
            this.cmb_Places1.TabIndex = 6;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 14);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(94, 20);
            this.kryptonLabel1.TabIndex = 37;
            this.kryptonLabel1.Values.Text = "Move on place:";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lbl_StencilRequired);
            this.kryptonPanel2.Controls.Add(this.cmb_BatchStages1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel17);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel15);
            this.kryptonPanel2.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel2.Controls.Add(this.btn_Refresh);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.cmb_Places2);
            this.kryptonPanel2.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.txt_Label);
            this.kryptonPanel2.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel16);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel2.Size = new System.Drawing.Size(901, 133);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // lbl_StencilRequired
            // 
            this.lbl_StencilRequired.Location = new System.Drawing.Point(606, 76);
            this.lbl_StencilRequired.Name = "lbl_StencilRequired";
            this.lbl_StencilRequired.Size = new System.Drawing.Size(146, 16);
            this.lbl_StencilRequired.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbl_StencilRequired.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_StencilRequired.TabIndex = 245;
            this.lbl_StencilRequired.Values.Text = "Warning! Stencil required!";
            this.lbl_StencilRequired.Visible = false;
            // 
            // cmb_BatchStages1
            // 
            this.cmb_BatchStages1.BatchId = 0;
            this.cmb_BatchStages1.Launches = 0;
            this.cmb_BatchStages1.Location = new System.Drawing.Point(429, 74);
            this.cmb_BatchStages1.Name = "cmb_BatchStages1";
            this.cmb_BatchStages1.Size = new System.Drawing.Size(100, 20);
            this.cmb_BatchStages1.Stage = "";
            this.cmb_BatchStages1.StageId = 0;
            this.cmb_BatchStages1.TabIndex = 244;
            // 
            // kryptonLabel17
            // 
            this.kryptonLabel17.Location = new System.Drawing.Point(301, 74);
            this.kryptonLabel17.Name = "kryptonLabel17";
            this.kryptonLabel17.Size = new System.Drawing.Size(122, 20);
            this.kryptonLabel17.TabIndex = 243;
            this.kryptonLabel17.Values.Text = "Stage of production:";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(12, 74);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel15.TabIndex = 241;
            this.kryptonLabel15.Values.Text = "Batch:";
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
            this.cmb_Batches1.Location = new System.Drawing.Point(88, 74);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(207, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 240;
            this.cmb_Batches1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches1_BatchChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Refresh.Location = new System.Drawing.Point(551, 65);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Refresh.Size = new System.Drawing.Size(49, 42);
            this.btn_Refresh.TabIndex = 47;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 100);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel2.TabIndex = 46;
            this.kryptonLabel2.Values.Text = "Place:";
            // 
            // cmb_Places2
            // 
            this.cmb_Places2.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Places2.Department = "";
            this.cmb_Places2.IsQuarantine = 0;
            this.cmb_Places2.Location = new System.Drawing.Point(88, 100);
            this.cmb_Places2.Lock = 0;
            this.cmb_Places2.Name = "cmb_Places2";
            this.cmb_Places2.PlaceId = 0;
            this.cmb_Places2.SelectedNode = null;
            this.cmb_Places2.Size = new System.Drawing.Size(207, 20);
            this.cmb_Places2.TabIndex = 45;
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
            this.cmb_Articles1.Location = new System.Drawing.Point(88, 48);
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
            this.cmb_Articles1.TabIndex = 44;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(381, 48);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel5.TabIndex = 43;
            this.kryptonLabel5.Values.Text = "Label:";
            // 
            // txt_Label
            // 
            this.txt_Label.AllowDecimalSeparator = false;
            this.txt_Label.AllowSpace = false;
            this.txt_Label.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Label.Location = new System.Drawing.Point(429, 48);
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.Size = new System.Drawing.Size(100, 23);
            this.txt_Label.TabIndex = 42;
            this.txt_Label.Text = "0";
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "ED62D4F425E1454A7EB8AAF6D8EF2F6F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(901, 31);
            this.kryptonHeader2.TabIndex = 2;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Movement";
            this.kryptonHeader2.Values.Image = global::Odin.Global_Resourses.list16x16;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(12, 48);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel16.TabIndex = 35;
            this.kryptonLabel16.Values.Text = "Article:";
            // 
            // gv_Dets
            // 
            this.gv_Dets.AllowUserToAddRows = false;
            this.gv_Dets.AllowUserToDeleteRows = false;
            this.gv_Dets.AllowUserToOrderColumns = true;
            this.gv_Dets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Dets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_labelid,
            this.cn_dartid,
            this.cn_darticle,
            this.cn_dqtyoper,
            this.cn_dunit,
            this.cn_dplace,
            this.cn_placeto,
            this.cn_labelto,
            this.cn_id,
            this.cn_dcomments});
            this.gv_Dets.ContextMenuStrip = this.mnu_LinesDets;
            this.gv_Dets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Dets.Location = new System.Drawing.Point(0, 31);
            this.gv_Dets.Name = "gv_Dets";
            this.gv_Dets.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_Dets.ReadOnly = true;
            this.gv_Dets.RowHeadersWidth = 20;
            this.gv_Dets.Size = new System.Drawing.Size(1205, 118);
            this.gv_Dets.TabIndex = 9;
            this.gv_Dets.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_Dets_ColumnHeaderMouseClick);
            // 
            // cn_labelid
            // 
            this.cn_labelid.DataPropertyName = "labelfrom";
            this.cn_labelid.HeaderText = "Label";
            this.cn_labelid.Name = "cn_labelid";
            this.cn_labelid.ReadOnly = true;
            // 
            // cn_dartid
            // 
            this.cn_dartid.DataPropertyName = "artid";
            this.cn_dartid.FillWeight = 80F;
            this.cn_dartid.HeaderText = "Art. id";
            this.cn_dartid.Name = "cn_dartid";
            this.cn_dartid.ReadOnly = true;
            this.cn_dartid.Width = 80;
            // 
            // cn_darticle
            // 
            this.cn_darticle.DataPropertyName = "article";
            this.cn_darticle.FillWeight = 200F;
            this.cn_darticle.HeaderText = "Article";
            this.cn_darticle.Name = "cn_darticle";
            this.cn_darticle.ReadOnly = true;
            this.cn_darticle.Width = 200;
            // 
            // cn_dqtyoper
            // 
            this.cn_dqtyoper.DataPropertyName = "qtyoper";
            this.cn_dqtyoper.FillWeight = 80F;
            this.cn_dqtyoper.HeaderText = "Qty";
            this.cn_dqtyoper.Name = "cn_dqtyoper";
            this.cn_dqtyoper.ReadOnly = true;
            this.cn_dqtyoper.Width = 80;
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
            // cn_dplace
            // 
            this.cn_dplace.DataPropertyName = "placefrom";
            this.cn_dplace.FillWeight = 250F;
            this.cn_dplace.HeaderText = "Place from";
            this.cn_dplace.Name = "cn_dplace";
            this.cn_dplace.ReadOnly = true;
            this.cn_dplace.Width = 250;
            // 
            // cn_placeto
            // 
            this.cn_placeto.DataPropertyName = "placeto";
            this.cn_placeto.FillWeight = 250F;
            this.cn_placeto.HeaderText = "Place to";
            this.cn_placeto.Name = "cn_placeto";
            this.cn_placeto.ReadOnly = true;
            this.cn_placeto.Width = 250;
            // 
            // cn_labelto
            // 
            this.cn_labelto.DataPropertyName = "labelto";
            this.cn_labelto.HeaderText = "New label";
            this.cn_labelto.Name = "cn_labelto";
            this.cn_labelto.ReadOnly = true;
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            // 
            // cn_dcomments
            // 
            this.cn_dcomments.DataPropertyName = "comments";
            this.cn_dcomments.FillWeight = 150F;
            this.cn_dcomments.HeaderText = "Comments";
            this.cn_dcomments.Name = "cn_dcomments";
            this.cn_dcomments.ReadOnly = true;
            this.cn_dcomments.Width = 150;
            // 
            // bn_Dets
            // 
            this.bn_Dets.AddNewItem = null;
            this.bn_Dets.CountItem = this.toolStripLabel1;
            this.bn_Dets.DeleteItem = null;
            this.bn_Dets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Dets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Dets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.btn_Delete,
            this.btn_IntoExcelDets});
            this.bn_Dets.Location = new System.Drawing.Point(0, 149);
            this.bn_Dets.MoveFirstItem = this.toolStripButton1;
            this.bn_Dets.MoveLastItem = this.toolStripButton4;
            this.bn_Dets.MoveNextItem = this.toolStripButton3;
            this.bn_Dets.MovePreviousItem = this.toolStripButton2;
            this.bn_Dets.Name = "bn_Dets";
            this.bn_Dets.PositionItem = this.toolStripTextBox1;
            this.bn_Dets.Size = new System.Drawing.Size(1205, 25);
            this.bn_Dets.TabIndex = 8;
            this.bn_Dets.Text = "bn_Dets";
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
            // btn_IntoExcelDets
            // 
            this.btn_IntoExcelDets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_IntoExcelDets.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_IntoExcelDets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_IntoExcelDets.Name = "btn_IntoExcelDets";
            this.btn_IntoExcelDets.Size = new System.Drawing.Size(23, 22);
            this.btn_IntoExcelDets.Text = "Export into excel";
            this.btn_IntoExcelDets.Click += new System.EventHandler(this.btn_IntoExcelDets_Click);
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(1205, 31);
            this.kryptonHeader3.TabIndex = 3;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Document details";
            this.kryptonHeader3.Values.Image = global::Odin.Global_Resourses.document;
            // 
            // cn_label
            // 
            this.cn_label.DataPropertyName = "label";
            this.cn_label.HeaderText = "Label";
            this.cn_label.Name = "cn_label";
            this.cn_label.ReadOnly = true;
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
            this.cn_article.FillWeight = 200F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Width = 200;
            // 
            // cn_place
            // 
            this.cn_place.DataPropertyName = "place";
            this.cn_place.FillWeight = 250F;
            this.cn_place.HeaderText = "Place";
            this.cn_place.Name = "cn_place";
            this.cn_place.ReadOnly = true;
            this.cn_place.Width = 250;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 80F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 80;
            // 
            // cn_qtyinbatch
            // 
            this.cn_qtyinbatch.DataPropertyName = "qtyinbatch";
            this.cn_qtyinbatch.FillWeight = 80F;
            this.cn_qtyinbatch.HeaderText = "Qty in batch";
            this.cn_qtyinbatch.Name = "cn_qtyinbatch";
            this.cn_qtyinbatch.Width = 80;
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
            // btn_Add
            // 
            this.btn_Add.FillWeight = 25F;
            this.btn_Add.HeaderText = "";
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.ReadOnly = true;
            this.btn_Add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_Add.Width = 25;
            // 
            // cn_qtytomove
            // 
            this.cn_qtytomove.HeaderText = "Qty to move";
            this.cn_qtytomove.Name = "cn_qtytomove";
            this.cn_qtytomove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_qtytomove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_qtyreserved
            // 
            this.cn_qtyreserved.DataPropertyName = "reserved";
            this.cn_qtyreserved.HeaderText = "Reserved";
            this.cn_qtyreserved.Name = "cn_qtyreserved";
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.Width = 150;
            // 
            // cn_expdate
            // 
            this.cn_expdate.DataPropertyName = "expdate";
            this.cn_expdate.HeaderText = "Expiry date";
            this.cn_expdate.Name = "cn_expdate";
            this.cn_expdate.ReadOnly = true;
            // 
            // cn_bdid
            // 
            this.cn_bdid.DataPropertyName = "bdid";
            this.cn_bdid.HeaderText = "bdid";
            this.cn_bdid.Name = "cn_bdid";
            this.cn_bdid.Visible = false;
            // 
            // cn_reservation
            // 
            this.cn_reservation.DataPropertyName = "reservation";
            this.cn_reservation.HeaderText = "Reservation";
            this.cn_reservation.Name = "cn_reservation";
            // 
            // cn_tomove
            // 
            this.cn_tomove.DataPropertyName = "tomove";
            this.cn_tomove.HeaderText = "tomove";
            this.cn_tomove.Name = "cn_tomove";
            this.cn_tomove.Visible = false;
            // 
            // cn_docdate
            // 
            this.cn_docdate.DataPropertyName = "regdate";
            this.cn_docdate.HeaderText = "Doc. date";
            this.cn_docdate.Name = "cn_docdate";
            // 
            // cn_placeid
            // 
            this.cn_placeid.DataPropertyName = "placeid";
            this.cn_placeid.HeaderText = "placeid";
            this.cn_placeid.Name = "cn_placeid";
            this.cn_placeid.Visible = false;
            // 
            // cn_storagerules
            // 
            this.cn_storagerules.DataPropertyName = "storagerules";
            this.cn_storagerules.HeaderText = "Storage rules";
            this.cn_storagerules.Name = "cn_storagerules";
            // 
            // frm_Movement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 650);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Movement";
            this.TabText = "Movement";
            this.Text = "Stock movement";
            this.Load += new System.EventHandler(this.frm_Movement_Load);
            this.Resize += new System.EventHandler(this.frm_Movement_Resize);
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.mnu_LinesDets.ResumeLayout(false);
            this.mnu_LinesDets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Dets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel2.PerformLayout();
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
            this.mnu_RepType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Dets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Dets)).EndInit();
            this.bn_Dets.ResumeLayout(false);
            this.bn_Dets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private System.Windows.Forms.BindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.MoveDocs.cmb_MoveDocs cmb_MoveDocs1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Print;
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
        private System.Windows.Forms.ToolStripButton btn_ClearList;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private CMB_Components.Places.cmb_Places cmb_Places1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Owf.Controls.NumericTetxBox txt_Label;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Places.cmb_Places cmb_Places2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private System.Windows.Forms.ImageList imageList1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_DocDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_PalWeight;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_PalQty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Incoterms;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Transport;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_FinDestAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_FinDestPlace;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_DelivAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_DelivPlace;
        private Owf.Controls.GradientPanel2 gradientPanel21;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Dets;
        private System.Windows.Forms.BindingNavigator bn_Dets;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_IntoExcelDets;
        private System.Windows.Forms.BindingSource bs_Dets;
        private System.Windows.Forms.ContextMenuStrip mnu_LinesDets;
        private System.Windows.Forms.ToolStripTextBox txt_FilterForD;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchD;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByD;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelD;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterD;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminD;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel17;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Reserve;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private CMB_Components.Users.cmb_Users cmb_Users1;
        private Owf.Controls.GradientPanel2 gradientPanel23;
        private CMB_Components.BatchStages.cmb_BatchStages cmb_BatchStages1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel20;
        private Owf.Controls.NumericTetxBox txt_QtyOfProduct;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private CMB_Components.Batches.cmb_Batches cmb_Batches2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_PrintDLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_labelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_darticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dqtyoper;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_placeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_labelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcomments;
        private System.Windows.Forms.ToolStripMenuItem mni_LabelDets;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private System.Windows.Forms.ContextMenuStrip mnu_RepType;
        private System.Windows.Forms.ToolStripMenuItem mni_Production;
        private System.Windows.Forms.ToolStripMenuItem mni_Movement;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_StencilRequired;
        private CMB_Components.Articles.cmb_Articles cmb_Articles2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel21;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private CMB_Components.Launches.cmb_Launches cmb_Launches1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyinbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtytomove;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyreserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_expdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_tomove;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_docdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_placeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_storagerules;
    }
}