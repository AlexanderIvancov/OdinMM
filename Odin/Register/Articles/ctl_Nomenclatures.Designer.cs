namespace Odin.Register.Articles
{
    partial class ctl_Nomenclatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_Nomenclatures));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Lock = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_AddNorm = new System.Windows.Forms.ToolStripButton();
            this.btn_AddSubProduct = new System.Windows.Forms.ToolStripButton();
            this.btn_Insert = new System.Windows.Forms.ToolStripButton();
            this.btn_EditNorm = new System.Windows.Forms.ToolStripButton();
            this.btn_Copy = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteNorm = new System.Windows.Forms.ToolStripButton();
            this.tv_BOM = new AdvancedDataGridView.TreeGridView();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cn_article = new AdvancedDataGridView.TreeGridColumn();
            this.cn_artid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_num = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_secname = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_qty = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_unit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_spoilnorm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_spoilconst = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_comments = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_date = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_user = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_id = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_using = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.cn_uniquerow = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.cn_stageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_BOM)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Lock);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(1134, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btn_Lock
            // 
            this.btn_Lock.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Lock.Location = new System.Drawing.Point(375, 13);
            this.btn_Lock.Name = "btn_Lock";
            this.btn_Lock.Size = new System.Drawing.Size(27, 25);
            this.btn_Lock.TabIndex = 41;
            this.btn_Lock.Values.Image = global::Odin.Global_Resourses.lock_open;
            this.btn_Lock.Values.Text = "";
            this.btn_Lock.Click += new System.EventHandler(this.btn_Lock_Click);
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
            this.cmb_Articles1.Location = new System.Drawing.Point(98, 15);
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(265, 20);
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.TabIndex = 39;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleChanged += new Odin.CMB_Components.Articles.ArticlesEventHandler(this.cmb_Articles1_ArticleChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(10, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel2.TabIndex = 38;
            this.kryptonLabel2.Values.Text = "Final product:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddNorm,
            this.btn_AddSubProduct,
            this.btn_Insert,
            this.btn_EditNorm,
            this.btn_Copy,
            this.btn_DeleteNorm});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 50);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1134, 25);
            this.bindingNavigator1.TabIndex = 41;
            this.bindingNavigator1.Text = "Bill of materials";
            // 
            // btn_AddNorm
            // 
            this.btn_AddNorm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNorm.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNorm.Image")));
            this.btn_AddNorm.Name = "btn_AddNorm";
            this.btn_AddNorm.RightToLeftAutoMirrorImage = true;
            this.btn_AddNorm.Size = new System.Drawing.Size(23, 22);
            this.btn_AddNorm.Text = "Add new";
            this.btn_AddNorm.Click += new System.EventHandler(this.btn_AddNorm_Click);
            // 
            // btn_AddSubProduct
            // 
            this.btn_AddSubProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddSubProduct.Image = global::Odin.Global_Resourses.node_tree_add;
            this.btn_AddSubProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddSubProduct.Name = "btn_AddSubProduct";
            this.btn_AddSubProduct.Size = new System.Drawing.Size(23, 22);
            this.btn_AddSubProduct.Text = "Add sub-product";
            this.btn_AddSubProduct.Click += new System.EventHandler(this.btn_AddSubProduct_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Insert.Image = global::Odin.Global_Resourses.insert_table_row_5996;
            this.btn_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(23, 22);
            this.btn_Insert.Text = "Insert row";
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_EditNorm
            // 
            this.btn_EditNorm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EditNorm.Image = global::Odin.Global_Resourses.edit;
            this.btn_EditNorm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditNorm.Name = "btn_EditNorm";
            this.btn_EditNorm.Size = new System.Drawing.Size(23, 22);
            this.btn_EditNorm.Text = "Edit selected line";
            this.btn_EditNorm.Click += new System.EventHandler(this.btn_EditNorm_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.btn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(23, 22);
            this.btn_Copy.Text = "Copy bill of materials";
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_DeleteNorm
            // 
            this.btn_DeleteNorm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteNorm.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteNorm.Image")));
            this.btn_DeleteNorm.Name = "btn_DeleteNorm";
            this.btn_DeleteNorm.RightToLeftAutoMirrorImage = true;
            this.btn_DeleteNorm.Size = new System.Drawing.Size(23, 22);
            this.btn_DeleteNorm.Text = "Delete";
            this.btn_DeleteNorm.Click += new System.EventHandler(this.btn_DeleteNorm_Click);
            // 
            // tv_BOM
            // 
            this.tv_BOM.AllowUserToAddRows = false;
            this.tv_BOM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tv_BOM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tv_BOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tv_BOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachmentColumn,
            this.cn_article,
            this.cn_artid,
            this.cn_num,
            this.cn_secname,
            this.cn_qty,
            this.cn_unit,
            this.cn_spoilnorm,
            this.cn_spoilconst,
            this.cn_comments,
            this.cn_date,
            this.cn_user,
            this.cn_id,
            this.cn_using,
            this.cn_uniquerow,
            this.cn_stageid});
            this.tv_BOM.ContextMenuStrip = this.mnu_Lines;
            this.tv_BOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_BOM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tv_BOM.ImageList = null;
            this.tv_BOM.Location = new System.Drawing.Point(0, 75);
            this.tv_BOM.Name = "tv_BOM";
            this.tv_BOM.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.tv_BOM.RowHeadersWidth = 25;
            this.tv_BOM.ShowCellErrors = false;
            this.tv_BOM.ShowRowErrors = false;
            this.tv_BOM.Size = new System.Drawing.Size(1134, 435);
            this.tv_BOM.TabIndex = 42;
            this.tv_BOM.NodeExpanded += new AdvancedDataGridView.ExpandedEventHandler(this.tv_BOM_NodeExpanded);
            this.tv_BOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tv_BOM_CellClick);
            this.tv_BOM.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tv_BOM_CellEnter);
            this.tv_BOM.SelectionChanged += new System.EventHandler(this.tv_BOM_SelectionChanged);
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
            this.mnu_Lines.Size = new System.Drawing.Size(205, 167);
            this.mnu_Lines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_Lines_Opening);
            // 
            // mni_FilterFor
            // 
            this.mni_FilterFor.Name = "mni_FilterFor";
            this.mni_FilterFor.Size = new System.Drawing.Size(100, 23);
            this.mni_FilterFor.Visible = false;
            // 
            // mni_Search
            // 
            this.mni_Search.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_Search.Name = "mni_Search";
            this.mni_Search.Size = new System.Drawing.Size(204, 22);
            this.mni_Search.Text = "Search for record";
            this.mni_Search.Click += new System.EventHandler(this.mni_Search_Click);
            // 
            // mni_FilterBy
            // 
            this.mni_FilterBy.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterBy.Name = "mni_FilterBy";
            this.mni_FilterBy.Size = new System.Drawing.Size(204, 22);
            this.mni_FilterBy.Text = "Filter by selection";
            this.mni_FilterBy.Visible = false;
            // 
            // mni_FilterExcludingSel
            // 
            this.mni_FilterExcludingSel.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSel.Name = "mni_FilterExcludingSel";
            this.mni_FilterExcludingSel.Size = new System.Drawing.Size(204, 22);
            this.mni_FilterExcludingSel.Text = "Filter excluding selection";
            this.mni_FilterExcludingSel.Visible = false;
            // 
            // mni_RemoveFilter
            // 
            this.mni_RemoveFilter.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilter.Name = "mni_RemoveFilter";
            this.mni_RemoveFilter.Size = new System.Drawing.Size(204, 22);
            this.mni_RemoveFilter.Text = "Remove filter";
            this.mni_RemoveFilter.Visible = false;
            // 
            // mni_Copy
            // 
            this.mni_Copy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_Copy.Name = "mni_Copy";
            this.mni_Copy.Size = new System.Drawing.Size(204, 22);
            this.mni_Copy.Text = "Copy";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // mni_Admin
            // 
            this.mni_Admin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_Admin.Name = "mni_Admin";
            this.mni_Admin.Size = new System.Drawing.Size(204, 22);
            this.mni_Admin.Text = "List settings";
            this.mni_Admin.Visible = false;
            // 
            // attachmentColumn
            // 
            this.attachmentColumn.HeaderText = "attachmentColumn";
            this.attachmentColumn.Name = "attachmentColumn";
            this.attachmentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attachmentColumn.Visible = false;
            // 
            // cn_article
            // 
            this.cn_article.DefaultNodeImage = null;
            this.cn_article.FillWeight = 200F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_article.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_article.Width = 200;
            // 
            // cn_artid
            // 
            this.cn_artid.FillWeight = 75F;
            this.cn_artid.HeaderText = "Art. Id.";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_artid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_artid.Width = 75;
            // 
            // cn_num
            // 
            this.cn_num.FillWeight = 35F;
            this.cn_num.HeaderText = "Num";
            this.cn_num.Name = "cn_num";
            this.cn_num.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_num.Width = 35;
            // 
            // cn_secname
            // 
            this.cn_secname.FillWeight = 150F;
            this.cn_secname.HeaderText = "2nd name";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_secname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_secname.Width = 150;
            // 
            // cn_qty
            // 
            this.cn_qty.FillWeight = 60F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_qty.Width = 60;
            // 
            // cn_unit
            // 
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_unit.Width = 40;
            // 
            // cn_spoilnorm
            // 
            this.cn_spoilnorm.FillWeight = 60F;
            this.cn_spoilnorm.HeaderText = "Spoil. %";
            this.cn_spoilnorm.Name = "cn_spoilnorm";
            this.cn_spoilnorm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_spoilnorm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_spoilnorm.Width = 60;
            // 
            // cn_spoilconst
            // 
            this.cn_spoilconst.FillWeight = 60F;
            this.cn_spoilconst.HeaderText = "Spoil. const";
            this.cn_spoilconst.Name = "cn_spoilconst";
            this.cn_spoilconst.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_spoilconst.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_spoilconst.Width = 60;
            // 
            // cn_comments
            // 
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_comments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_comments.Width = 150;
            // 
            // cn_date
            // 
            this.cn_date.HeaderText = "Date";
            this.cn_date.Name = "cn_date";
            this.cn_date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_date.Width = 100;
            // 
            // cn_user
            // 
            this.cn_user.HeaderText = "User";
            this.cn_user.Name = "cn_user";
            this.cn_user.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_user.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_user.Width = 100;
            // 
            // cn_id
            // 
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_id.Visible = false;
            this.cn_id.Width = 100;
            // 
            // cn_using
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.cn_using.DefaultCellStyle = dataGridViewCellStyle2;
            this.cn_using.FalseValue = null;
            this.cn_using.FillWeight = 40F;
            this.cn_using.HeaderText = "Using";
            this.cn_using.IndeterminateValue = null;
            this.cn_using.Name = "cn_using";
            this.cn_using.TrueValue = null;
            this.cn_using.Width = 40;
            // 
            // cn_uniquerow
            // 
            this.cn_uniquerow.HeaderText = "uniquerow";
            this.cn_uniquerow.Name = "cn_uniquerow";
            this.cn_uniquerow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_uniquerow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_uniquerow.Visible = false;
            this.cn_uniquerow.Width = 100;
            // 
            // cn_stageid
            // 
            this.cn_stageid.HeaderText = "stageid";
            this.cn_stageid.Name = "cn_stageid";
            this.cn_stageid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_stageid.Visible = false;
            // 
            // ctl_Nomenclatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tv_BOM);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_Nomenclatures";
            this.Size = new System.Drawing.Size(1134, 510);
            this.Load += new System.EventHandler(this.ctl_Nomenclatures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_BOM)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btn_AddNorm;
        private System.Windows.Forms.ToolStripButton btn_DeleteNorm;
        private System.Windows.Forms.ToolStripButton btn_Insert;
        private System.Windows.Forms.ToolStripButton btn_EditNorm;
        private AdvancedDataGridView.TreeGridView tv_BOM;
        private System.Windows.Forms.ToolStripButton btn_AddSubProduct;
        private System.Windows.Forms.ToolStripButton btn_Copy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Lock;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private System.Windows.Forms.DataGridViewImageColumn attachmentColumn;
        private AdvancedDataGridView.TreeGridColumn cn_article;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_artid;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_num;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_secname;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_qty;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_unit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_spoilnorm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_spoilconst;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_comments;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_date;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_user;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_id;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn cn_using;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn cn_uniquerow;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stageid;
    }
}
