namespace Odin.CMB_Components.Articles
{
    partial class frm_Articles
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
        public cmb_Articles cmb_ArticleOne;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Articles));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_AliasList = new CombBoxGridView.ComboBoxGrid();
            this.cn_aliases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_aliasid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_Aliases = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_AddAlias = new System.Windows.Forms.ToolStripButton();
            this.btn_EditAlias = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteAlias = new System.Windows.Forms.ToolStripButton();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.gv_List = new CombBoxGridView.ComboBoxGrid();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_AddNew = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.txt_Stock = new System.Windows.Forms.ToolStripButton();
            this.btn_CONeeds = new System.Windows.Forms.ToolStripButton();
            this.btn_Coincidences = new System.Windows.Forms.ToolStripButton();
            this.btn_ProductCard = new System.Windows.Forms.ToolStripButton();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.bs_AliasesList = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Setup = new System.Windows.Forms.ToolStripButton();
            this.btn_Supplier = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AliasList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Aliases)).BeginInit();
            this.bn_Aliases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_AliasesList)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_AliasList);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_Aliases);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonHeader1);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bindingNavigator1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(398, 357);
            this.kryptonHeaderGroup1.TabIndex = 2;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Articles";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Select units";
            // 
            // gv_AliasList
            // 
            this.gv_AliasList.AllowUserToAddRows = false;
            this.gv_AliasList.AllowUserToResizeRows = false;
            this.gv_AliasList.BackgroundColor = System.Drawing.Color.White;
            this.gv_AliasList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_AliasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_AliasList.ColumnHeadersVisible = false;
            this.gv_AliasList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_aliases,
            this.cn_aliasid,
            this.cn_artid});
            this.gv_AliasList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_AliasList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gv_AliasList.GridColor = System.Drawing.Color.LightGray;
            this.gv_AliasList.Location = new System.Drawing.Point(0, 242);
            this.gv_AliasList.Name = "gv_AliasList";
            this.gv_AliasList.RowHeadersVisible = false;
            this.gv_AliasList.Size = new System.Drawing.Size(396, 92);
            this.gv_AliasList.TabIndex = 8;
            this.gv_AliasList.TabStop = false;
            // 
            // cn_aliases
            // 
            this.cn_aliases.DataPropertyName = "alias";
            this.cn_aliases.FillWeight = 250F;
            this.cn_aliases.HeaderText = "aliases";
            this.cn_aliases.Name = "cn_aliases";
            this.cn_aliases.Width = 250;
            // 
            // cn_aliasid
            // 
            this.cn_aliasid.DataPropertyName = "id";
            this.cn_aliasid.FillWeight = 50F;
            this.cn_aliasid.HeaderText = "id";
            this.cn_aliasid.Name = "cn_aliasid";
            this.cn_aliasid.Visible = false;
            this.cn_aliasid.Width = 50;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.HeaderText = "artid";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.Visible = false;
            // 
            // bn_Aliases
            // 
            this.bn_Aliases.AddNewItem = null;
            this.bn_Aliases.CountItem = null;
            this.bn_Aliases.DeleteItem = null;
            this.bn_Aliases.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Aliases.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddAlias,
            this.btn_EditAlias,
            this.btn_DeleteAlias});
            this.bn_Aliases.Location = new System.Drawing.Point(0, 217);
            this.bn_Aliases.MoveFirstItem = null;
            this.bn_Aliases.MoveLastItem = null;
            this.bn_Aliases.MoveNextItem = null;
            this.bn_Aliases.MovePreviousItem = null;
            this.bn_Aliases.Name = "bn_Aliases";
            this.bn_Aliases.PositionItem = null;
            this.bn_Aliases.Size = new System.Drawing.Size(396, 25);
            this.bn_Aliases.TabIndex = 7;
            this.bn_Aliases.Text = "Aliases";
            // 
            // btn_AddAlias
            // 
            this.btn_AddAlias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddAlias.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddAlias.Image")));
            this.btn_AddAlias.Name = "btn_AddAlias";
            this.btn_AddAlias.RightToLeftAutoMirrorImage = true;
            this.btn_AddAlias.Size = new System.Drawing.Size(23, 22);
            this.btn_AddAlias.Text = "Add new alias";
            this.btn_AddAlias.Click += new System.EventHandler(this.btn_AddAlias_Click);
            // 
            // btn_EditAlias
            // 
            this.btn_EditAlias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EditAlias.Image = global::Odin.Global_Resourses.edit;
            this.btn_EditAlias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditAlias.Name = "btn_EditAlias";
            this.btn_EditAlias.Size = new System.Drawing.Size(23, 22);
            this.btn_EditAlias.Text = "Edit";
            this.btn_EditAlias.Click += new System.EventHandler(this.btn_EditAlias_Click);
            // 
            // btn_DeleteAlias
            // 
            this.btn_DeleteAlias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteAlias.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteAlias.Image")));
            this.btn_DeleteAlias.Name = "btn_DeleteAlias";
            this.btn_DeleteAlias.RightToLeftAutoMirrorImage = true;
            this.btn_DeleteAlias.Size = new System.Drawing.Size(23, 22);
            this.btn_DeleteAlias.Text = "Delete";
            this.btn_DeleteAlias.Click += new System.EventHandler(this.btn_DeleteAlias_Click);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 195);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(396, 22);
            this.kryptonHeader1.TabIndex = 6;
            this.kryptonHeader1.Values.Description = "Aliases for selected article";
            this.kryptonHeader1.Values.Heading = "Aliases";
            this.kryptonHeader1.Values.Image = global::Odin.Global_Resourses.ButtonImageSmall;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToResizeRows = false;
            this.gv_List.BackgroundColor = System.Drawing.Color.White;
            this.gv_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.ColumnHeadersVisible = false;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_article,
            this.cn_secname,
            this.cn_id,
            this.cn_isactive});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Top;
            this.gv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gv_List.GridColor = System.Drawing.Color.LightGray;
            this.gv_List.Location = new System.Drawing.Point(0, 25);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersVisible = false;
            this.gv_List.Size = new System.Drawing.Size(396, 170);
            this.gv_List.TabIndex = 5;
            this.gv_List.TabStop = false;
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            this.gv_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_List_KeyDown);
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 150F;
            this.cn_article.HeaderText = "articles";
            this.cn_article.Name = "cn_article";
            this.cn_article.Width = 150;
            // 
            // cn_secname
            // 
            this.cn_secname.DataPropertyName = "secname";
            this.cn_secname.FillWeight = 150F;
            this.cn_secname.HeaderText = "secname";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.Width = 150;
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.FillWeight = 75F;
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Width = 75;
            // 
            // cn_isactive
            // 
            this.cn_isactive.DataPropertyName = "isactive";
            this.cn_isactive.HeaderText = "isactive";
            this.cn_isactive.Name = "cn_isactive";
            this.cn_isactive.Visible = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddNew,
            this.btn_Edit,
            this.btn_Delete,
            this.txt_Stock,
            this.btn_CONeeds,
            this.btn_Coincidences,
            this.btn_Setup,
            this.btn_Supplier,
            this.btn_ProductCard});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(396, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNew.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.Image")));
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.RightToLeftAutoMirrorImage = true;
            this.btn_AddNew.Size = new System.Drawing.Size(23, 22);
            this.btn_AddNew.Text = "Add new";
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
            // txt_Stock
            // 
            this.txt_Stock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.txt_Stock.Image = global::Odin.Global_Resourses.bricks;
            this.txt_Stock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(23, 22);
            this.txt_Stock.Text = "Total details";
            this.txt_Stock.Click += new System.EventHandler(this.txt_Stock_Click);
            // 
            // btn_CONeeds
            // 
            this.btn_CONeeds.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_CONeeds.Image = global::Odin.Global_Resourses.Favorites_24x24;
            this.btn_CONeeds.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CONeeds.Name = "btn_CONeeds";
            this.btn_CONeeds.Size = new System.Drawing.Size(23, 22);
            this.btn_CONeeds.Text = "CO rm needs details";
            this.btn_CONeeds.Click += new System.EventHandler(this.btn_CONeeds_Click);
            // 
            // btn_Coincidences
            // 
            this.btn_Coincidences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Coincidences.Image = global::Odin.Global_Resourses.arrow_switch;
            this.btn_Coincidences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Coincidences.Name = "btn_Coincidences";
            this.btn_Coincidences.Size = new System.Drawing.Size(23, 22);
            this.btn_Coincidences.Text = "Check for coincidence";
            this.btn_Coincidences.Click += new System.EventHandler(this.btn_Coincidences_Click);
            // 
            // btn_ProductCard
            // 
            this.btn_ProductCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ProductCard.Image = global::Odin.Global_Resourses.Print2;
            this.btn_ProductCard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ProductCard.Name = "btn_ProductCard";
            this.btn_ProductCard.Size = new System.Drawing.Size(23, 22);
            this.btn_ProductCard.Text = "Print product card";
            this.btn_ProductCard.Click += new System.EventHandler(this.btn_ProductCard_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // btn_Setup
            // 
            this.btn_Setup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Setup.Image = global::Odin.Global_Resourses.setting_tools;
            this.btn_Setup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Setup.Name = "btn_Setup";
            this.btn_Setup.Size = new System.Drawing.Size(23, 22);
            this.btn_Setup.Text = "Show setup";
            this.btn_Setup.Click += new System.EventHandler(this.btn_Setup_Click);
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Supplier.Image = global::Odin.Global_Resourses.Anketa;
            this.btn_Supplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Size = new System.Drawing.Size(23, 22);
            this.btn_Supplier.Text = "Show supplier";
            this.btn_Supplier.Click += new System.EventHandler(this.btn_Supplier_Click);
            // 
            // frm_Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(398, 357);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Articles";
            this.Text = "Articles";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Articles_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Articles_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_AliasList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Aliases)).EndInit();
            this.bn_Aliases.ResumeLayout(false);
            this.bn_Aliases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_AliasesList)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btn_AddNew;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.BindingSource bs_List;
        private System.Windows.Forms.ToolStripButton txt_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isactive;
        private System.Windows.Forms.ToolStripButton btn_CONeeds;
        private System.Windows.Forms.BindingNavigator bn_Aliases;
        private System.Windows.Forms.ToolStripButton btn_AddAlias;
        private System.Windows.Forms.ToolStripButton btn_EditAlias;
        private System.Windows.Forms.ToolStripButton btn_DeleteAlias;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private CombBoxGridView.ComboBoxGrid gv_AliasList;
        private System.Windows.Forms.BindingSource bs_AliasesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_aliases;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_aliasid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.ToolStripButton btn_ProductCard;
        private System.Windows.Forms.ToolStripButton btn_Coincidences;
        public CombBoxGridView.ComboBoxGrid gv_List;
        private System.Windows.Forms.ToolStripButton btn_Setup;
        private System.Windows.Forms.ToolStripButton btn_Supplier;
    }
}