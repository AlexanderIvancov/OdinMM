namespace Odin.Planning.Controls
{
    partial class ctl_BatchFreeze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_BatchFreeze));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btn_Refresh = new System.Windows.Forms.ToolStripButton();
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
            this.btn_Replace = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_FreeAll = new System.Windows.Forms.ToolStripButton();
            this.btn_Wiz = new System.Windows.Forms.ToolStripButton();
            this.btn_Clear = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_History = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
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
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bomnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_free = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cn_reserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_freeze = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cn_requested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_given = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_losses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_overruns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_purchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_returned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_onstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_missed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nomenclature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_podelivdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_analogues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_notplaced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_incomedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_techmissings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_detcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_freepo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_detisactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_bomcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_inbom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dnp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_allanalogues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(1308, 47);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Batch:";
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
            this.cmb_Batches1.Location = new System.Drawing.Point(75, 12);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 0;
            this.cmb_Batches1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches1_BatchChanged);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = this.bindingNavigatorCountItem;
            this.bn_List.DeleteItem = null;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Refresh,
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
            this.btn_Replace,
            this.btn_Delete,
            this.btn_FreeAll,
            this.btn_Wiz,
            this.btn_Clear,
            this.btn_Excel,
            this.toolStripLabel1,
            this.btn_History,
            this.btn_Save});
            this.bn_List.Location = new System.Drawing.Point(0, 47);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(1308, 25);
            this.bn_List.TabIndex = 3;
            this.bn_List.Text = "bn_List";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(23, 22);
            this.btn_Refresh.Text = "Refresh info";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.btn_AddNew.Text = "Add new line";
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
            // btn_Replace
            // 
            this.btn_Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Replace.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.btn_Replace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(23, 22);
            this.btn_Replace.Text = "Replace RM";
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
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
            // btn_FreeAll
            // 
            this.btn_FreeAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_FreeAll.Image = global::Odin.Global_Resourses.unlock;
            this.btn_FreeAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FreeAll.Name = "btn_FreeAll";
            this.btn_FreeAll.Size = new System.Drawing.Size(23, 22);
            this.btn_FreeAll.Text = "Free reservation";
            this.btn_FreeAll.Click += new System.EventHandler(this.btn_FreeAll_Click);
            // 
            // btn_Wiz
            // 
            this.btn_Wiz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Wiz.Image = global::Odin.Global_Resourses.wizard;
            this.btn_Wiz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Wiz.Name = "btn_Wiz";
            this.btn_Wiz.Size = new System.Drawing.Size(23, 22);
            this.btn_Wiz.Text = "Default reservation";
            this.btn_Wiz.Click += new System.EventHandler(this.btn_Wiz_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(23, 22);
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btn_History
            // 
            this.btn_History.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_History.Image = global::Odin.Global_Resourses.history24x24;
            this.btn_History.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(23, 22);
            this.btn_History.Text = "History";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(23, 22);
            this.btn_Save.Text = "Save data";
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
            this.cn_bomnum,
            this.cn_artid,
            this.cn_article,
            this.cn_unit,
            this.cn_batch,
            this.cn_qty,
            this.cn_reserved,
            this.btn_free,
            this.cn_reserve,
            this.btn_freeze,
            this.cn_requested,
            this.cn_given,
            this.cn_losses,
            this.cn_overruns,
            this.cn_purchased,
            this.cn_returned,
            this.cn_onstock,
            this.cn_available,
            this.cn_missed,
            this.cn_nomenclature,
            this.cn_podelivdate,
            this.cn_analogues,
            this.cn_comments,
            this.cn_description,
            this.cn_createdat,
            this.cn_createdby,
            this.cn_notplaced,
            this.cn_incomedate,
            this.cn_isactive,
            this.cn_techmissings,
            this.cn_detcomments,
            this.cn_freepo,
            this.cn_detisactive,
            this.cn_bomcomments,
            this.cn_inbom,
            this.cn_dnp,
            this.cn_allanalogues});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 72);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(1308, 320);
            this.gv_List.TabIndex = 5;
            this.gv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellClick);
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
            this.gv_List.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gv_List_CellPainting);
            this.gv_List.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.gv_List_CellParsing);
            this.gv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValidated);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "artid";
            this.dataGridViewTextBoxColumn2.FillWeight = 70F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Art. id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Article";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unit";
            this.dataGridViewTextBoxColumn4.FillWeight = 40F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "batch";
            this.dataGridViewTextBoxColumn5.FillWeight = 80F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Batch";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn6.FillWeight = 70F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty in batch";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 85;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "reserved";
            this.dataGridViewTextBoxColumn7.FillWeight = 70F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Reserved";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "toreserve";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn8.FillWeight = 70F;
            this.dataGridViewTextBoxColumn8.HeaderText = "To reserve";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "requested";
            this.dataGridViewTextBoxColumn9.FillWeight = 70F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Requested";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "given";
            this.dataGridViewTextBoxColumn10.FillWeight = 70F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Given";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "purchased";
            this.dataGridViewTextBoxColumn11.FillWeight = 70F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Purchased";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 70;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "returned";
            this.dataGridViewTextBoxColumn12.FillWeight = 70F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Returned";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 70;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "qtystock";
            this.dataGridViewTextBoxColumn13.FillWeight = 70F;
            this.dataGridViewTextBoxColumn13.HeaderText = "On stock";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 70;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "available";
            this.dataGridViewTextBoxColumn14.FillWeight = 70F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Available";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 70;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "missed";
            this.dataGridViewTextBoxColumn15.FillWeight = 70F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Missed";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 70;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "nomenclature";
            this.dataGridViewTextBoxColumn16.FillWeight = 70F;
            this.dataGridViewTextBoxColumn16.HeaderText = "In nom.";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 70;
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            // 
            // cn_bomnum
            // 
            this.cn_bomnum.DataPropertyName = "bomnum";
            this.cn_bomnum.FillWeight = 40F;
            this.cn_bomnum.HeaderText = "BOM №";
            this.cn_bomnum.Name = "cn_bomnum";
            this.cn_bomnum.Width = 40;
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
            // cn_unit
            // 
            this.cn_unit.DataPropertyName = "unit";
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.ReadOnly = true;
            this.cn_unit.Width = 40;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.FillWeight = 80F;
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.ReadOnly = true;
            this.cn_batch.Width = 80;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 70F;
            this.cn_qty.HeaderText = "Qty in batch";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 85;
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
            // btn_free
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = " ";
            this.btn_free.DefaultCellStyle = dataGridViewCellStyle1;
            this.btn_free.FillWeight = 25F;
            this.btn_free.HeaderText = "";
            this.btn_free.Name = "btn_free";
            this.btn_free.ReadOnly = true;
            this.btn_free.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_free.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_free.Text = "->";
            this.btn_free.Width = 25;
            // 
            // cn_reserve
            // 
            this.cn_reserve.DataPropertyName = "toreserve";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cn_reserve.DefaultCellStyle = dataGridViewCellStyle2;
            this.cn_reserve.FillWeight = 70F;
            this.cn_reserve.HeaderText = "To reserve";
            this.cn_reserve.Name = "cn_reserve";
            this.cn_reserve.Width = 70;
            // 
            // btn_freeze
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = " ";
            this.btn_freeze.DefaultCellStyle = dataGridViewCellStyle3;
            this.btn_freeze.FillWeight = 25F;
            this.btn_freeze.HeaderText = "";
            this.btn_freeze.Name = "btn_freeze";
            this.btn_freeze.ReadOnly = true;
            this.btn_freeze.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_freeze.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_freeze.Width = 25;
            // 
            // cn_requested
            // 
            this.cn_requested.DataPropertyName = "requested";
            this.cn_requested.FillWeight = 70F;
            this.cn_requested.HeaderText = "Requested";
            this.cn_requested.Name = "cn_requested";
            this.cn_requested.ReadOnly = true;
            this.cn_requested.Width = 70;
            // 
            // cn_given
            // 
            this.cn_given.DataPropertyName = "given";
            this.cn_given.FillWeight = 70F;
            this.cn_given.HeaderText = "Given";
            this.cn_given.Name = "cn_given";
            this.cn_given.ReadOnly = true;
            this.cn_given.Width = 70;
            // 
            // cn_losses
            // 
            this.cn_losses.DataPropertyName = "givenreq";
            this.cn_losses.FillWeight = 80F;
            this.cn_losses.HeaderText = "Losses";
            this.cn_losses.Name = "cn_losses";
            this.cn_losses.Width = 80;
            // 
            // cn_overruns
            // 
            this.cn_overruns.DataPropertyName = "overruns";
            this.cn_overruns.FillWeight = 80F;
            this.cn_overruns.HeaderText = "Overruns";
            this.cn_overruns.Name = "cn_overruns";
            this.cn_overruns.Width = 80;
            // 
            // cn_purchased
            // 
            this.cn_purchased.DataPropertyName = "purchased";
            this.cn_purchased.FillWeight = 70F;
            this.cn_purchased.HeaderText = "Purchased";
            this.cn_purchased.Name = "cn_purchased";
            this.cn_purchased.ReadOnly = true;
            this.cn_purchased.Width = 70;
            // 
            // cn_returned
            // 
            this.cn_returned.DataPropertyName = "returned";
            this.cn_returned.FillWeight = 70F;
            this.cn_returned.HeaderText = "Returned";
            this.cn_returned.Name = "cn_returned";
            this.cn_returned.ReadOnly = true;
            this.cn_returned.Visible = false;
            this.cn_returned.Width = 70;
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
            // cn_available
            // 
            this.cn_available.DataPropertyName = "available";
            this.cn_available.FillWeight = 70F;
            this.cn_available.HeaderText = "Available";
            this.cn_available.Name = "cn_available";
            this.cn_available.ReadOnly = true;
            this.cn_available.Width = 70;
            // 
            // cn_missed
            // 
            this.cn_missed.DataPropertyName = "missed";
            this.cn_missed.FillWeight = 70F;
            this.cn_missed.HeaderText = "Missed";
            this.cn_missed.Name = "cn_missed";
            this.cn_missed.ReadOnly = true;
            this.cn_missed.Width = 70;
            // 
            // cn_nomenclature
            // 
            this.cn_nomenclature.DataPropertyName = "nomenclature";
            this.cn_nomenclature.FillWeight = 70F;
            this.cn_nomenclature.HeaderText = "In BOM";
            this.cn_nomenclature.Name = "cn_nomenclature";
            this.cn_nomenclature.ReadOnly = true;
            this.cn_nomenclature.Width = 70;
            // 
            // cn_podelivdate
            // 
            this.cn_podelivdate.DataPropertyName = "podelivdate";
            this.cn_podelivdate.HeaderText = "PO deliv. date";
            this.cn_podelivdate.Name = "cn_podelivdate";
            // 
            // cn_analogues
            // 
            this.cn_analogues.DataPropertyName = "analogues";
            this.cn_analogues.FillWeight = 200F;
            this.cn_analogues.HeaderText = "Replacements";
            this.cn_analogues.Name = "cn_analogues";
            this.cn_analogues.Width = 200;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            // 
            // cn_description
            // 
            this.cn_description.DataPropertyName = "description";
            this.cn_description.HeaderText = "Description";
            this.cn_description.Name = "cn_description";
            // 
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "createdat";
            this.cn_createdat.HeaderText = "Created at";
            this.cn_createdat.Name = "cn_createdat";
            // 
            // cn_createdby
            // 
            this.cn_createdby.DataPropertyName = "createdby";
            this.cn_createdby.HeaderText = "Created by";
            this.cn_createdby.Name = "cn_createdby";
            // 
            // cn_notplaced
            // 
            this.cn_notplaced.DataPropertyName = "notplaced";
            this.cn_notplaced.HeaderText = "Not placed";
            this.cn_notplaced.Name = "cn_notplaced";
            // 
            // cn_incomedate
            // 
            this.cn_incomedate.DataPropertyName = "incomedate";
            this.cn_incomedate.HeaderText = "Income date";
            this.cn_incomedate.Name = "cn_incomedate";
            // 
            // cn_isactive
            // 
            this.cn_isactive.DataPropertyName = "isactive";
            this.cn_isactive.HeaderText = "isactive";
            this.cn_isactive.Name = "cn_isactive";
            this.cn_isactive.Visible = false;
            // 
            // cn_techmissings
            // 
            this.cn_techmissings.DataPropertyName = "techmissings";
            this.cn_techmissings.HeaderText = "Tech. missings";
            this.cn_techmissings.Name = "cn_techmissings";
            // 
            // cn_detcomments
            // 
            this.cn_detcomments.DataPropertyName = "detcomments";
            this.cn_detcomments.HeaderText = "Comments of line";
            this.cn_detcomments.Name = "cn_detcomments";
            // 
            // cn_freepo
            // 
            this.cn_freepo.DataPropertyName = "freepo";
            this.cn_freepo.HeaderText = "Free PO";
            this.cn_freepo.Name = "cn_freepo";
            // 
            // cn_detisactive
            // 
            this.cn_detisactive.DataPropertyName = "detisactive";
            this.cn_detisactive.FalseValue = "0";
            this.cn_detisactive.FillWeight = 40F;
            this.cn_detisactive.HeaderText = "Active line";
            this.cn_detisactive.IndeterminateValue = "1";
            this.cn_detisactive.Name = "cn_detisactive";
            this.cn_detisactive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_detisactive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cn_detisactive.TrueValue = "-1";
            this.cn_detisactive.Visible = false;
            this.cn_detisactive.Width = 40;
            // 
            // cn_bomcomments
            // 
            this.cn_bomcomments.DataPropertyName = "bomcomments";
            this.cn_bomcomments.HeaderText = "BOM comments";
            this.cn_bomcomments.Name = "cn_bomcomments";
            // 
            // cn_inbom
            // 
            this.cn_inbom.DataPropertyName = "inbom";
            this.cn_inbom.HeaderText = "In BOM";
            this.cn_inbom.Name = "cn_inbom";
            // 
            // cn_dnp
            // 
            this.cn_dnp.DataPropertyName = "dnp";
            this.cn_dnp.FalseValue = "0";
            this.cn_dnp.FillWeight = 40F;
            this.cn_dnp.HeaderText = "DNP";
            this.cn_dnp.IndeterminateValue = "1";
            this.cn_dnp.Name = "cn_dnp";
            this.cn_dnp.TrueValue = "-1";
            this.cn_dnp.Width = 40;
            // 
            // cn_allanalogues
            // 
            this.cn_allanalogues.DataPropertyName = "allanalogs";
            this.cn_allanalogues.HeaderText = "Analogues";
            this.cn_allanalogues.Name = "cn_allanalogues";
            // 
            // ctl_BatchFreeze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_BatchFreeze";
            this.Size = new System.Drawing.Size(1308, 392);
            this.Load += new System.EventHandler(this.ctl_BatchFreeze_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ctl_BatchFreeze_Paint);
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
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
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
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_FreeAll;
        private System.Windows.Forms.ToolStripButton btn_Clear;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        public CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private System.Windows.Forms.ToolStripButton btn_Wiz;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private System.Windows.Forms.ToolStripButton btn_Replace;
        private System.Windows.Forms.ToolStripButton btn_History;
        private Global_Classes.SyncBindingSource bs_List;
        private System.Windows.Forms.ToolStripButton btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bomnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reserved;
        private System.Windows.Forms.DataGridViewButtonColumn btn_free;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reserve;
        private System.Windows.Forms.DataGridViewButtonColumn btn_freeze;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_requested;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_given;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_losses;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_overruns;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_purchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_returned;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_onstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_missed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nomenclature;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_podelivdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_analogues;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_notplaced;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_incomedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_techmissings;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_detcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_freepo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_detisactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bomcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inbom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_dnp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_allanalogues;
    }
}
