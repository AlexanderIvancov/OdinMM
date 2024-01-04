namespace Odin.Planning.Controls
{
    partial class ctl_RMFreeze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_RMFreeze));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_description = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.btn_FreeAll = new System.Windows.Forms.ToolStripButton();
            this.btn_Wiz = new System.Windows.Forms.ToolStripButton();
            this.btn_Clear = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txt_Available = new System.Windows.Forms.ToolStripTextBox();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_free = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cn_reserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_freeze = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cn_requested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_given = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_purchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_returned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_missed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nomenclature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_inprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_techmissings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ispre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
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
            this.kryptonPanel1.Controls.Add(this.txt_description);
            this.kryptonPanel1.Controls.Add(this.txt_comments);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(818, 47);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(623, 12);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(261, 23);
            this.txt_description.TabIndex = 6;
            // 
            // txt_comments
            // 
            this.txt_comments.Location = new System.Drawing.Point(356, 12);
            this.txt_comments.Name = "txt_comments";
            this.txt_comments.Size = new System.Drawing.Size(261, 23);
            this.txt_comments.TabIndex = 5;
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
            this.cmb_Articles1.Location = new System.Drawing.Point(84, 12);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(265, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 2;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleChanged += new Odin.CMB_Components.Articles.ArticlesEventHandler(this.cmb_Articles1_ArticleChanged);
            this.cmb_Articles1.ArticleKeyPressed += new Odin.CMB_Components.Articles.ArticlesKeyPressedEventHandler(this.cmb_Articles1_ArticleKeyPressed);
            this.cmb_Articles1.ArticleIdKeyPressed += new Odin.CMB_Components.Articles.ArticlesIdKeyPressedEventHandler(this.cmb_Articles1_ArticleIdKeyPressed);
            this.cmb_Articles1.ArticleValidated += new Odin.CMB_Components.Articles.ArticleValidatedEventHandler(this.cmb_Articles1_ArticleValidated);
            this.cmb_Articles1.ArticleIdReceiving += new Odin.CMB_Components.Articles.ArticleIdReceivingEventHandler(this.cmb_Articles1_ArticleIdReceiving);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Article:";
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
            this.btn_FreeAll,
            this.btn_Wiz,
            this.btn_Clear,
            this.btn_Edit,
            this.btn_Delete,
            this.btn_Excel,
            this.toolStripLabel1,
            this.btn_Save,
            this.toolStripLabel2,
            this.txt_Available});
            this.bn_List.Location = new System.Drawing.Point(0, 47);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(818, 25);
            this.bn_List.TabIndex = 4;
            this.bn_List.Text = "bn_List";
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
            this.btn_Wiz.Image = global::Odin.Global_Resourses.fifo24x24;
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
            // btn_Edit
            // 
            this.btn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Edit.Image = global::Odin.Global_Resourses.edit;
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(23, 22);
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RightToLeftAutoMirrorImage = true;
            this.btn_Delete.Size = new System.Drawing.Size(23, 22);
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Visible = false;
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
            this.btn_Excel.Visible = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel2.Text = "Available:";
            // 
            // txt_Available
            // 
            this.txt_Available.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Available.ForeColor = System.Drawing.Color.Red;
            this.txt_Available.Name = "txt_Available";
            this.txt_Available.Size = new System.Drawing.Size(75, 25);
            this.txt_Available.Text = "0";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeight = 25;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_batch,
            this.cn_artid,
            this.cn_article,
            this.cn_secname,
            this.cn_Date,
            this.cn_week,
            this.cn_unit,
            this.cn_qty,
            this.cn_reserved,
            this.btn_free,
            this.cn_reserve,
            this.btn_freeze,
            this.cn_requested,
            this.cn_given,
            this.cn_purchased,
            this.cn_returned,
            this.cn_missed,
            this.cn_nomenclature,
            this.cn_inprod,
            this.cn_techmissings,
            this.cn_ispre});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 72);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(818, 325);
            this.gv_List.TabIndex = 6;
            this.gv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellClick);
            this.gv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellContentClick);
            this.gv_List.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellEnter);
            this.gv_List.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellLeave);
            this.gv_List.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gv_List_CellPainting);
            this.gv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValidated);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
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
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 70F;
            this.cn_artid.HeaderText = "Prod. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
            this.cn_artid.Width = 70;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "product";
            this.cn_article.FillWeight = 150F;
            this.cn_article.HeaderText = "Product";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Width = 150;
            // 
            // cn_secname
            // 
            this.cn_secname.DataPropertyName = "secname";
            this.cn_secname.FillWeight = 120F;
            this.cn_secname.HeaderText = "2nd name";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.Width = 120;
            // 
            // cn_Date
            // 
            this.cn_Date.DataPropertyName = "resdate";
            this.cn_Date.FillWeight = 80F;
            this.cn_Date.HeaderText = "Start of production";
            this.cn_Date.Name = "cn_Date";
            this.cn_Date.ReadOnly = true;
            this.cn_Date.Width = 80;
            // 
            // cn_week
            // 
            this.cn_week.DataPropertyName = "week";
            this.cn_week.FillWeight = 70F;
            this.cn_week.HeaderText = "Week";
            this.cn_week.Name = "cn_week";
            this.cn_week.ReadOnly = true;
            this.cn_week.Width = 70;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cn_reserve.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_reserve.FillWeight = 70F;
            this.cn_reserve.HeaderText = "To reserve";
            this.cn_reserve.Name = "cn_reserve";
            this.cn_reserve.Width = 70;
            // 
            // btn_freeze
            // 
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
            this.cn_nomenclature.HeaderText = "In nom.";
            this.cn_nomenclature.Name = "cn_nomenclature";
            this.cn_nomenclature.ReadOnly = true;
            this.cn_nomenclature.Width = 70;
            // 
            // cn_inprod
            // 
            this.cn_inprod.DataPropertyName = "inprod";
            this.cn_inprod.HeaderText = "Production";
            this.cn_inprod.Name = "cn_inprod";
            // 
            // cn_techmissings
            // 
            this.cn_techmissings.DataPropertyName = "techmissings";
            this.cn_techmissings.HeaderText = "Tech. missings";
            this.cn_techmissings.Name = "cn_techmissings";
            // 
            // cn_ispre
            // 
            this.cn_ispre.DataPropertyName = "ispre";
            this.cn_ispre.HeaderText = "ispre";
            this.cn_ispre.Name = "cn_ispre";
            this.cn_ispre.Visible = false;
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
            // ctl_RMFreeze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_RMFreeze";
            this.Size = new System.Drawing.Size(818, 397);
            this.Load += new System.EventHandler(this.ctl_RMFreeze_Load);
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
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.ToolStripButton btn_FreeAll;
        private System.Windows.Forms.ToolStripButton btn_Wiz;
        private System.Windows.Forms.ToolStripButton btn_Clear;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txt_Available;
        public CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_description;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_comments;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_week;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reserved;
        private System.Windows.Forms.DataGridViewButtonColumn btn_free;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reserve;
        private System.Windows.Forms.DataGridViewButtonColumn btn_freeze;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_requested;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_given;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_purchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_returned;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_missed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nomenclature;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_techmissings;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ispre;
    }
}
