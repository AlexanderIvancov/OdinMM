namespace Odin.Warehouse.StockOut
{
    partial class frm_StockOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockOut));
            this.tgv_List = new AdvancedDataGridView.TreeGridView();
            this.attachmentColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cn_ArtId = new AdvancedDataGridView.TreeGridColumn();
            this.cn_ArtId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_BatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_RequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_LeftInBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_LabelDets = new System.Windows.Forms.ToolStripMenuItem();
            this.cn_QtyOnLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Give = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cn_QtyToGive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_QtyRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_PlaceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_LinesDets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_MapBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_FilterForD = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminD = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Dets = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.cmb_OutcomeDocs1 = new Odin.CMB_Components.OutcomeDocs.cmb_OutcomeDocs();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Reason = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Type = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gradientPanel21 = new Owf.Controls.GradientPanel2();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_DocDate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Set = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
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
            this.btn_Wizard = new System.Windows.Forms.ToolStripButton();
            this.btn_ClearList = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.btn_Expand = new System.Windows.Forms.ToolStripButton();
            this.btn_Collapse = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Places1 = new Odin.CMB_Components.Places.cmb_Places();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_EnabledRequests = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chk_Left = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.chk_Reserved = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Requests1 = new Odin.CMB_Components.Requests.cmb_Requests();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Label = new Owf.Controls.NumericTetxBox();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gv_Dets = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.btn_PrintLabel = new System.Windows.Forms.ToolStripButton();
            this.kryptonHeader3 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_labelid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_darticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dqtyoper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_drequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ddepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tgv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            this.mnu_LinesDets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
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
            // tgv_List
            // 
            this.tgv_List.AllowUserToAddRows = false;
            this.tgv_List.AllowUserToDeleteRows = false;
            this.tgv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachmentColumn,
            this.cn_ArtId,
            this.cn_ArtId1,
            this.cn_Article,
            this.cn_Batch,
            this.cn_BatchId,
            this.cn_Request,
            this.cn_RequestId,
            this.cn_LeftInBatch,
            this.cn_Reserved,
            this.cn_Available,
            this.cn_Unit,
            this.cn_Label,
            this.cn_QtyOnLabel,
            this.btn_Give,
            this.cn_QtyToGive,
            this.cn_QtyRest,
            this.cn_Place,
            this.cn_ExpiryDate,
            this.cn_Comments,
            this.cn_Usage,
            this.cn_PlaceId});
            this.tgv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tgv_List.ImageList = null;
            this.tgv_List.Location = new System.Drawing.Point(0, 153);
            this.tgv_List.Name = "tgv_List";
            this.tgv_List.RowHeadersWidth = 25;
            this.tgv_List.Size = new System.Drawing.Size(1120, 261);
            this.tgv_List.TabIndex = 6;
            this.tgv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tgv_List_CellClick);
            this.tgv_List.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tgv_List_CellPainting);
            this.tgv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tgv_List_CellValidated);
            // 
            // attachmentColumn
            // 
            this.attachmentColumn.HeaderText = "attachmentColumn";
            this.attachmentColumn.Name = "attachmentColumn";
            this.attachmentColumn.Visible = false;
            // 
            // cn_ArtId
            // 
            this.cn_ArtId.DefaultNodeImage = null;
            this.cn_ArtId.FillWeight = 120F;
            this.cn_ArtId.HeaderText = "Art. id";
            this.cn_ArtId.Name = "cn_ArtId";
            this.cn_ArtId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_ArtId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_ArtId.Width = 120;
            // 
            // cn_ArtId1
            // 
            this.cn_ArtId1.HeaderText = "treeArtColumn";
            this.cn_ArtId1.Name = "cn_ArtId1";
            this.cn_ArtId1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_ArtId1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_ArtId1.Visible = false;
            // 
            // cn_Article
            // 
            this.cn_Article.FillWeight = 200F;
            this.cn_Article.HeaderText = "Article";
            this.cn_Article.Name = "cn_Article";
            this.cn_Article.ReadOnly = true;
            this.cn_Article.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_Article.Width = 200;
            // 
            // cn_Batch
            // 
            this.cn_Batch.HeaderText = "Batch";
            this.cn_Batch.Name = "cn_Batch";
            this.cn_Batch.ReadOnly = true;
            this.cn_Batch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_BatchId
            // 
            this.cn_BatchId.HeaderText = "BatchId";
            this.cn_BatchId.Name = "cn_BatchId";
            this.cn_BatchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_BatchId.Visible = false;
            // 
            // cn_Request
            // 
            this.cn_Request.HeaderText = "Request";
            this.cn_Request.Name = "cn_Request";
            this.cn_Request.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_RequestId
            // 
            this.cn_RequestId.HeaderText = "ReqId";
            this.cn_RequestId.Name = "cn_RequestId";
            this.cn_RequestId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_RequestId.Visible = false;
            // 
            // cn_LeftInBatch
            // 
            this.cn_LeftInBatch.FillWeight = 80F;
            this.cn_LeftInBatch.HeaderText = "Left in batch";
            this.cn_LeftInBatch.Name = "cn_LeftInBatch";
            this.cn_LeftInBatch.ReadOnly = true;
            this.cn_LeftInBatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_LeftInBatch.Width = 80;
            // 
            // cn_Reserved
            // 
            this.cn_Reserved.FillWeight = 80F;
            this.cn_Reserved.HeaderText = "Reserved";
            this.cn_Reserved.Name = "cn_Reserved";
            this.cn_Reserved.ReadOnly = true;
            this.cn_Reserved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_Reserved.Width = 80;
            // 
            // cn_Available
            // 
            this.cn_Available.FillWeight = 80F;
            this.cn_Available.HeaderText = "Available";
            this.cn_Available.Name = "cn_Available";
            this.cn_Available.ReadOnly = true;
            this.cn_Available.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_Available.Width = 80;
            // 
            // cn_Unit
            // 
            this.cn_Unit.FillWeight = 40F;
            this.cn_Unit.HeaderText = "Unit";
            this.cn_Unit.Name = "cn_Unit";
            this.cn_Unit.ReadOnly = true;
            this.cn_Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_Unit.Width = 40;
            // 
            // cn_Label
            // 
            this.cn_Label.ContextMenuStrip = this.mnu_Lines;
            this.cn_Label.HeaderText = "Label";
            this.cn_Label.Name = "cn_Label";
            this.cn_Label.ReadOnly = true;
            this.cn_Label.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mnu_Lines
            // 
            this.mnu_Lines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Lines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_LabelDets});
            this.mnu_Lines.Name = "mnu_Requests";
            this.mnu_Lines.Size = new System.Drawing.Size(140, 26);
            // 
            // mni_LabelDets
            // 
            this.mni_LabelDets.Image = global::Odin.Global_Resourses.barcode_2d;
            this.mni_LabelDets.Name = "mni_LabelDets";
            this.mni_LabelDets.Size = new System.Drawing.Size(139, 22);
            this.mni_LabelDets.Text = "Label details";
            this.mni_LabelDets.Click += new System.EventHandler(this.mni_LabelDets_Click);
            // 
            // cn_QtyOnLabel
            // 
            this.cn_QtyOnLabel.HeaderText = "Qty on label";
            this.cn_QtyOnLabel.Name = "cn_QtyOnLabel";
            this.cn_QtyOnLabel.ReadOnly = true;
            this.cn_QtyOnLabel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_Give
            // 
            this.btn_Give.FillWeight = 25F;
            this.btn_Give.HeaderText = "";
            this.btn_Give.Name = "btn_Give";
            this.btn_Give.Width = 25;
            // 
            // cn_QtyToGive
            // 
            this.cn_QtyToGive.HeaderText = "Qty to give";
            this.cn_QtyToGive.Name = "cn_QtyToGive";
            this.cn_QtyToGive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_QtyRest
            // 
            this.cn_QtyRest.HeaderText = "Rest on label";
            this.cn_QtyRest.Name = "cn_QtyRest";
            this.cn_QtyRest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_Place
            // 
            this.cn_Place.FillWeight = 200F;
            this.cn_Place.HeaderText = "Place";
            this.cn_Place.Name = "cn_Place";
            this.cn_Place.ReadOnly = true;
            this.cn_Place.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_Place.Width = 200;
            // 
            // cn_ExpiryDate
            // 
            this.cn_ExpiryDate.HeaderText = "Exp. date";
            this.cn_ExpiryDate.Name = "cn_ExpiryDate";
            this.cn_ExpiryDate.ReadOnly = true;
            this.cn_ExpiryDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_Comments
            // 
            this.cn_Comments.FillWeight = 150F;
            this.cn_Comments.HeaderText = "Comments";
            this.cn_Comments.Name = "cn_Comments";
            this.cn_Comments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_Comments.Width = 150;
            // 
            // cn_Usage
            // 
            this.cn_Usage.HeaderText = "Usage";
            this.cn_Usage.Name = "cn_Usage";
            this.cn_Usage.ReadOnly = true;
            this.cn_Usage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_Usage.Visible = false;
            // 
            // cn_PlaceId
            // 
            this.cn_PlaceId.HeaderText = "PlaceId";
            this.cn_PlaceId.Name = "cn_PlaceId";
            this.cn_PlaceId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_PlaceId.Visible = false;
            // 
            // mnu_LinesDets
            // 
            this.mnu_LinesDets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_LinesDets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_MapBatch,
            this.txt_FilterForD,
            this.mni_SearchD,
            this.mni_FilterByD,
            this.mni_FilterExcludingSelD,
            this.mni_RemoveFilterD,
            this.mni_CopyD,
            this.toolStripSeparator5,
            this.mni_AdminD});
            this.mnu_LinesDets.Name = "mnu_Requests";
            this.mnu_LinesDets.Size = new System.Drawing.Size(211, 189);
            this.mnu_LinesDets.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesDets_Opening);
            // 
            // mnu_MapBatch
            // 
            this.mnu_MapBatch.Image = global::Odin.Global_Resourses.application_link;
            this.mnu_MapBatch.Name = "mnu_MapBatch";
            this.mnu_MapBatch.Size = new System.Drawing.Size(210, 22);
            this.mnu_MapBatch.Text = "Map line to batch";
            this.mnu_MapBatch.Click += new System.EventHandler(this.mnu_MapBatch_Click);
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
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
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
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.gv_Dets);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.bn_Dets);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeader3);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1424, 593);
            this.kryptonSplitContainer1.SplitterDistance = 471;
            this.kryptonSplitContainer1.TabIndex = 11;
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
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_OutcomeDocs1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel7);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Reason);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Type);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel21);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel6);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_Comments);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_DocDate);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel3);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.gradientPanel22);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.tgv_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.bn_List);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.kryptonPanel3);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.kryptonPanel2);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1424, 471);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // cmb_OutcomeDocs1
            // 
            this.cmb_OutcomeDocs1.BatchId = 0;
            this.cmb_OutcomeDocs1.EnableDN = false;
            this.cmb_OutcomeDocs1.EnableSearchId = false;
            this.cmb_OutcomeDocs1.Location = new System.Drawing.Point(107, 48);
            this.cmb_OutcomeDocs1.Name = "cmb_OutcomeDocs1";
            this.cmb_OutcomeDocs1.OutcomeDoc = "";
            this.cmb_OutcomeDocs1.OutcomeDocId = 0;
            this.cmb_OutcomeDocs1.OutcomeDocSavedId = 0;
            this.cmb_OutcomeDocs1.Size = new System.Drawing.Size(185, 20);
            this.cmb_OutcomeDocs1.TabIndex = 249;
            this.cmb_OutcomeDocs1.OutDocChanged += new Odin.CMB_Components.OutcomeDocs.OutDocEventHandler(this.cmb_OutcomeDocs1_OutDocChanged);
            this.cmb_OutcomeDocs1.OutDocSaved += new Odin.CMB_Components.OutcomeDocs.OutDocSavedEventHandler(this.cmb_OutcomeDocs1_OutDocSaved);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(5, 109);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel7.TabIndex = 248;
            this.kryptonLabel7.Values.Text = "Reason:";
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(107, 109);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(185, 23);
            this.txt_Reason.TabIndex = 247;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 85);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel1.TabIndex = 246;
            this.kryptonLabel1.Values.Text = "Type:";
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(107, 85);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(185, 23);
            this.txt_Type.TabIndex = 245;
            // 
            // gradientPanel21
            // 
            this.gradientPanel21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel21.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel21.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel21.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel21.Location = new System.Drawing.Point(5, 188);
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
            this.kryptonLabel6.Location = new System.Drawing.Point(5, 161);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel6.TabIndex = 244;
            this.kryptonLabel6.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(107, 161);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(185, 23);
            this.txt_Comments.TabIndex = 243;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(5, 135);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel4.TabIndex = 242;
            this.kryptonLabel4.Values.Text = "Doc. date:";
            // 
            // txt_DocDate
            // 
            this.txt_DocDate.Enabled = false;
            this.txt_DocDate.Location = new System.Drawing.Point(107, 135);
            this.txt_DocDate.Name = "txt_DocDate";
            this.txt_DocDate.Size = new System.Drawing.Size(112, 23);
            this.txt_DocDate.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_DocDate.TabIndex = 241;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(5, 48);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel3.TabIndex = 240;
            this.kryptonLabel3.Values.Text = "Outcome doc.:";
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(5, 76);
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
            this.btn_Set,
            this.btn_Print,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(299, 36);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Header";
            this.kryptonHeader1.Values.Image = global::Odin.Global_Resourses.stock_outcome32x32;
            // 
            // btn_Set
            // 
            this.btn_Set.Image = global::Odin.Global_Resourses.add_set;
            this.btn_Set.Text = "Assembling";
            this.btn_Set.UniqueName = "8E054C37175D49952E981405D46C1858";
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Image = global::Odin.Global_Resourses.Printer;
            this.btn_Print.ToolTipBody = "Refresh";
            this.btn_Print.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.UniqueName = "3502D2542D5C42F0078623FF0A695273";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = this.bindingNavigatorCountItem;
            this.bn_List.DeleteItem = null;
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
            this.btn_Wizard,
            this.btn_ClearList,
            this.btn_Excel,
            this.btn_Expand,
            this.btn_Collapse});
            this.bn_List.Location = new System.Drawing.Point(0, 128);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(1120, 25);
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
            // btn_Wizard
            // 
            this.btn_Wizard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Wizard.Image = global::Odin.Global_Resourses.wizard;
            this.btn_Wizard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Wizard.Name = "btn_Wizard";
            this.btn_Wizard.Size = new System.Drawing.Size(23, 22);
            this.btn_Wizard.Text = "Wizard";
            this.btn_Wizard.Visible = false;
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
            this.btn_Excel.Visible = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Expand
            // 
            this.btn_Expand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Expand.Image = global::Odin.Global_Resourses.Expand;
            this.btn_Expand.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Expand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Expand.Name = "btn_Expand";
            this.btn_Expand.Size = new System.Drawing.Size(23, 22);
            this.btn_Expand.Text = "Expand";
            this.btn_Expand.Click += new System.EventHandler(this.btn_Expand_Click);
            // 
            // btn_Collapse
            // 
            this.btn_Collapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Collapse.Image = global::Odin.Global_Resourses.Collapse;
            this.btn_Collapse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Collapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Collapse.Name = "btn_Collapse";
            this.btn_Collapse.Size = new System.Drawing.Size(23, 22);
            this.btn_Collapse.Text = "Collapse";
            this.btn_Collapse.Click += new System.EventHandler(this.btn_Collapse_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel3.Controls.Add(this.cmb_Places1);
            this.kryptonPanel3.Controls.Add(this.btn_OK);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 414);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel3.Size = new System.Drawing.Size(1120, 57);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(17, 18);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(236, 20);
            this.kryptonLabel10.TabIndex = 42;
            this.kryptonLabel10.Values.Text = "Remove reservation, move rests on place:";
            // 
            // cmb_Places1
            // 
            this.cmb_Places1.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Places1.Department = "";
            this.cmb_Places1.IsQuarantine = 0;
            this.cmb_Places1.Location = new System.Drawing.Point(255, 18);
            this.cmb_Places1.Lock = 0;
            this.cmb_Places1.Name = "cmb_Places1";
            this.cmb_Places1.PlaceId = 0;
            this.cmb_Places1.SelectedNode = null;
            this.cmb_Places1.Size = new System.Drawing.Size(234, 20);
            this.cmb_Places1.TabIndex = 41;
            this.cmb_Places1.SelectedValueChanged += new Odin.CMB_Components.Places.PlacesEventHandler(this.cmb_Places1_SelectedValueChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(502, 8);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OK.Size = new System.Drawing.Size(93, 40);
            this.btn_OK.TabIndex = 40;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btn_EnabledRequests);
            this.kryptonPanel2.Controls.Add(this.chk_Left);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel2.Controls.Add(this.cmb_Common1);
            this.kryptonPanel2.Controls.Add(this.chk_Reserved);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel2.Controls.Add(this.cmb_Requests1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel2.Controls.Add(this.btn_Refresh);
            this.kryptonPanel2.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.txt_Label);
            this.kryptonPanel2.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel16);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel2.Size = new System.Drawing.Size(1120, 128);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // btn_EnabledRequests
            // 
            this.btn_EnabledRequests.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_EnabledRequests.Location = new System.Drawing.Point(500, 62);
            this.btn_EnabledRequests.Name = "btn_EnabledRequests";
            this.btn_EnabledRequests.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_EnabledRequests.Size = new System.Drawing.Size(43, 36);
            this.btn_EnabledRequests.TabIndex = 246;
            this.btn_EnabledRequests.Values.Image = global::Odin.Global_Resourses.Favorites_24x24;
            this.btn_EnabledRequests.Values.Text = "";
            this.btn_EnabledRequests.Click += new System.EventHandler(this.btn_EnabledRequests_Click);
            // 
            // chk_Left
            // 
            this.chk_Left.Checked = true;
            this.chk_Left.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Left.Location = new System.Drawing.Point(382, 97);
            this.chk_Left.Name = "chk_Left";
            this.chk_Left.Size = new System.Drawing.Size(138, 20);
            this.chk_Left.TabIndex = 245;
            this.chk_Left.Values.Text = "Left for consumption";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(12, 97);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel9.TabIndex = 244;
            this.kryptonLabel9.Values.Text = "Stage:";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(88, 97);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(148, 20);
            this.cmb_Common1.sTable = "vw_ProductionStagesOnly";
            this.cmb_Common1.sText_Filled = "name";
            this.cmb_Common1.sTitle = "Production stages";
            this.cmb_Common1.TabIndex = 243;
            // 
            // chk_Reserved
            // 
            this.chk_Reserved.Location = new System.Drawing.Point(242, 97);
            this.chk_Reserved.Name = "chk_Reserved";
            this.chk_Reserved.Size = new System.Drawing.Size(134, 20);
            this.chk_Reserved.TabIndex = 242;
            this.chk_Reserved.Values.Text = "Reserved labels only";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(242, 69);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel8.TabIndex = 241;
            this.kryptonLabel8.Values.Text = "Request:";
            // 
            // cmb_Requests1
            // 
            this.cmb_Requests1.EnableSearchId = false;
            this.cmb_Requests1.Location = new System.Drawing.Point(305, 69);
            this.cmb_Requests1.Name = "cmb_Requests1";
            this.cmb_Requests1.Request = "";
            this.cmb_Requests1.RequestId = 0;
            this.cmb_Requests1.RequestSavedId = 0;
            this.cmb_Requests1.Size = new System.Drawing.Size(187, 20);
            this.cmb_Requests1.TabIndex = 240;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 69);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 49;
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
            this.cmb_Batches1.Location = new System.Drawing.Point(88, 69);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(148, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 48;
            this.cmb_Batches1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches1_BatchChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Refresh.Location = new System.Drawing.Point(570, 60);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Refresh.Size = new System.Drawing.Size(43, 41);
            this.btn_Refresh.TabIndex = 47;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.cmb_Articles1.CertState = "";
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(88, 40);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(310, 20);
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
            this.kryptonLabel5.Location = new System.Drawing.Point(409, 40);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel5.TabIndex = 43;
            this.kryptonLabel5.Values.Text = "Label:";
            // 
            // txt_Label
            // 
            this.txt_Label.AllowDecimalSeparator = false;
            this.txt_Label.AllowSpace = false;
            this.txt_Label.Location = new System.Drawing.Point(457, 40);
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.Size = new System.Drawing.Size(100, 23);
            this.txt_Label.TabIndex = 42;
            this.txt_Label.Text = "0";
            this.txt_Label.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Label_Validating);
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(1120, 31);
            this.kryptonHeader2.TabIndex = 2;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Outcome creation";
            this.kryptonHeader2.Values.Image = global::Odin.Global_Resourses.list16x16;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(12, 40);
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
            this.cn_id,
            this.cn_labelid,
            this.cn_dartid,
            this.cn_darticle,
            this.cn_dqtyoper,
            this.cn_dunit,
            this.cn_dplace,
            this.cn_unitprice,
            this.cn_dbatch,
            this.cn_drequest,
            this.cn_dcomments,
            this.cn_ddepartment});
            this.gv_Dets.ContextMenuStrip = this.mnu_LinesDets;
            this.gv_Dets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Dets.Location = new System.Drawing.Point(0, 56);
            this.gv_Dets.Name = "gv_Dets";
            this.gv_Dets.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_Dets.ReadOnly = true;
            this.gv_Dets.RowHeadersWidth = 20;
            this.gv_Dets.Size = new System.Drawing.Size(1424, 61);
            this.gv_Dets.TabIndex = 9;
            // 
            // bn_Dets
            // 
            this.bn_Dets.AddNewItem = null;
            this.bn_Dets.CountItem = this.toolStripLabel1;
            this.bn_Dets.DeleteItem = null;
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
            this.toolStripButton5,
            this.btn_PrintLabel});
            this.bn_Dets.Location = new System.Drawing.Point(0, 31);
            this.bn_Dets.MoveFirstItem = this.toolStripButton1;
            this.bn_Dets.MoveLastItem = this.toolStripButton4;
            this.bn_Dets.MoveNextItem = this.toolStripButton3;
            this.bn_Dets.MovePreviousItem = this.toolStripButton2;
            this.bn_Dets.Name = "bn_Dets";
            this.bn_Dets.PositionItem = this.toolStripTextBox1;
            this.bn_Dets.Size = new System.Drawing.Size(1424, 25);
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
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Export into excel";
            // 
            // btn_PrintLabel
            // 
            this.btn_PrintLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_PrintLabel.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrintLabel.Image")));
            this.btn_PrintLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PrintLabel.Name = "btn_PrintLabel";
            this.btn_PrintLabel.Size = new System.Drawing.Size(23, 22);
            this.btn_PrintLabel.Text = "Print outcome label";
            this.btn_PrintLabel.Click += new System.EventHandler(this.btn_PrintLabel_Click);
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(1424, 31);
            this.kryptonHeader3.TabIndex = 3;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Document details";
            this.kryptonHeader3.Values.Image = global::Odin.Global_Resourses.document;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "ED62D4F425E1454A7EB8AAF6D8EF2F6F";
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "Id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            // 
            // cn_labelid
            // 
            this.cn_labelid.DataPropertyName = "label";
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
            this.cn_dqtyoper.DataPropertyName = "qty";
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
            this.cn_dplace.DataPropertyName = "place";
            this.cn_dplace.FillWeight = 250F;
            this.cn_dplace.HeaderText = "Place";
            this.cn_dplace.Name = "cn_dplace";
            this.cn_dplace.ReadOnly = true;
            this.cn_dplace.Width = 250;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price(BYN)";
            this.cn_unitprice.Name = "cn_unitprice";
            this.cn_unitprice.ReadOnly = true;
            // 
            // cn_dbatch
            // 
            this.cn_dbatch.DataPropertyName = "batch";
            this.cn_dbatch.FillWeight = 75F;
            this.cn_dbatch.HeaderText = "Batch";
            this.cn_dbatch.Name = "cn_dbatch";
            this.cn_dbatch.ReadOnly = true;
            this.cn_dbatch.Width = 75;
            // 
            // cn_drequest
            // 
            this.cn_drequest.DataPropertyName = "request";
            this.cn_drequest.FillWeight = 75F;
            this.cn_drequest.HeaderText = "Request";
            this.cn_drequest.Name = "cn_drequest";
            this.cn_drequest.ReadOnly = true;
            this.cn_drequest.Width = 75;
            // 
            // cn_dcomments
            // 
            this.cn_dcomments.DataPropertyName = "comments";
            this.cn_dcomments.FillWeight = 250F;
            this.cn_dcomments.HeaderText = "Comments";
            this.cn_dcomments.Name = "cn_dcomments";
            this.cn_dcomments.ReadOnly = true;
            this.cn_dcomments.Width = 250;
            // 
            // cn_ddepartment
            // 
            this.cn_ddepartment.HeaderText = "Department";
            this.cn_ddepartment.Name = "cn_ddepartment";
            this.cn_ddepartment.ReadOnly = true;
            // 
            // frm_StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 593);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_StockOut";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.TabText = "Stock outcomes";
            this.Text = "Stock outcomes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_StockOut_FormClosing);
            this.Load += new System.EventHandler(this.frm_StockOut_Load);
            this.Resize += new System.EventHandler(this.frm_StockOut_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tgv_List)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_LinesDets.ResumeLayout(false);
            this.mnu_LinesDets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
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

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private Owf.Controls.GradientPanel2 gradientPanel21;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_DocDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Print;
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
        private System.Windows.Forms.ToolStripButton btn_ClearList;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Owf.Controls.NumericTetxBox txt_Label;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
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
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private System.Windows.Forms.ImageList imageListSmall;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripMenuItem mni_LabelDets;
        private System.Windows.Forms.BindingSource bs_List;
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Reason;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Type;
        private CMB_Components.OutcomeDocs.cmb_OutcomeDocs cmb_OutcomeDocs1;
        private System.Windows.Forms.ToolStripButton btn_Expand;
        private System.Windows.Forms.ToolStripButton btn_Collapse;
        private AdvancedDataGridView.TreeGridView tgv_List;
        private System.Windows.Forms.ToolStripButton btn_Wizard;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Reserved;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private CMB_Components.Places.cmb_Places cmb_Places1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Set;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Left;
        private System.Windows.Forms.DataGridViewImageColumn attachmentColumn;
        private AdvancedDataGridView.TreeGridColumn cn_ArtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ArtId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_BatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_RequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_LeftInBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_QtyOnLabel;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Give;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_QtyToGive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_QtyRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_PlaceId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_EnabledRequests;
        public CMB_Components.Requests.cmb_Requests cmb_Requests1;
        private System.Windows.Forms.ToolStripMenuItem mnu_MapBatch;
        private System.Windows.Forms.ToolStripButton btn_PrintLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_labelid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_darticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dqtyoper;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_drequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ddepartment;
    }
}