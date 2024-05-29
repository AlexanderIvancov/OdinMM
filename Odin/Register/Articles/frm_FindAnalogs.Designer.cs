namespace Odin.Register.Articles
{
    partial class frm_FindAnalogs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FindAnalogs));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.cn_analogid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_valid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_validby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_validat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_allowtoreplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Valid = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
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
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(876, 286);
            this.kryptonHeaderGroup1.TabIndex = 4;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Analogs";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Select units";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeight = 25;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_analogid,
            this.cn_art,
            this.cn_customer,
            this.cn_product,
            this.cn_comments,
            this.cn_oa,
            this.chk_valid,
            this.cn_validby,
            this.cn_validat,
            this.cn_who,
            this.cn_when,
            this.cn_id,
            this.cn_customerid,
            this.cn_productid,
            this.cn_allowtoreplace});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 25);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(874, 176);
            this.gv_List.TabIndex = 48;
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 201);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(874, 56);
            this.kryptonPanel1.TabIndex = 47;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(773, 11);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.btn_OK.Values.Text = "Replace";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = null;
            this.bn_List.DeleteItem = null;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_Edit,
            this.btn_Valid,
            this.btn_Delete});
            this.bn_List.Location = new System.Drawing.Point(0, 0);
            this.bn_List.MoveFirstItem = null;
            this.bn_List.MoveLastItem = null;
            this.bn_List.MoveNextItem = null;
            this.bn_List.MovePreviousItem = null;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = null;
            this.bn_List.Size = new System.Drawing.Size(874, 25);
            this.bn_List.TabIndex = 46;
            this.bn_List.Text = "Bill of materials";
            // 
            // btn_Add
            // 
            this.btn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeftAutoMirrorImage = true;
            this.btn_Add.Size = new System.Drawing.Size(23, 22);
            this.btn_Add.Text = "Add new";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Edit.Image = global::Odin.Global_Resourses.edit;
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(23, 22);
            this.btn_Edit.Text = "Edit selected line";
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
            // cn_analogid
            // 
            this.cn_analogid.DataPropertyName = "analogueid";
            this.cn_analogid.FillWeight = 70F;
            this.cn_analogid.HeaderText = "Analog ID";
            this.cn_analogid.Name = "cn_analogid";
            this.cn_analogid.Width = 70;
            // 
            // cn_art
            // 
            this.cn_art.DataPropertyName = "analog";
            this.cn_art.FillWeight = 150F;
            this.cn_art.HeaderText = "Analog";
            this.cn_art.Name = "cn_art";
            this.cn_art.Width = 150;
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            // 
            // cn_product
            // 
            this.cn_product.DataPropertyName = "product";
            this.cn_product.HeaderText = "Product";
            this.cn_product.Name = "cn_product";
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.Width = 150;
            // 
            // cn_oa
            // 
            this.cn_oa.DataPropertyName = "oa";
            this.cn_oa.FillWeight = 40F;
            this.cn_oa.HeaderText = "O/A";
            this.cn_oa.Name = "cn_oa";
            this.cn_oa.Width = 40;
            // 
            // chk_valid
            // 
            this.chk_valid.DataPropertyName = "valid";
            this.chk_valid.FalseValue = "0";
            this.chk_valid.FillWeight = 40F;
            this.chk_valid.HeaderText = "Valid";
            this.chk_valid.IndeterminateValue = "1";
            this.chk_valid.Name = "chk_valid";
            this.chk_valid.TrueValue = "-1";
            this.chk_valid.Width = 40;
            // 
            // cn_validby
            // 
            this.cn_validby.DataPropertyName = "validby";
            this.cn_validby.HeaderText = "Valid by";
            this.cn_validby.Name = "cn_validby";
            // 
            // cn_validat
            // 
            this.cn_validat.DataPropertyName = "validat";
            this.cn_validat.HeaderText = "Valid at";
            this.cn_validat.Name = "cn_validat";
            // 
            // cn_who
            // 
            this.cn_who.DataPropertyName = "who";
            this.cn_who.HeaderText = "Who";
            this.cn_who.Name = "cn_who";
            // 
            // cn_when
            // 
            this.cn_when.DataPropertyName = "when";
            this.cn_when.HeaderText = "When";
            this.cn_when.Name = "cn_when";
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.FillWeight = 5F;
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            this.cn_id.Width = 5;
            // 
            // cn_customerid
            // 
            this.cn_customerid.DataPropertyName = "customerid";
            this.cn_customerid.HeaderText = "customerid";
            this.cn_customerid.Name = "cn_customerid";
            this.cn_customerid.Visible = false;
            // 
            // cn_productid
            // 
            this.cn_productid.DataPropertyName = "productid";
            this.cn_productid.HeaderText = "productid";
            this.cn_productid.Name = "cn_productid";
            this.cn_productid.Visible = false;
            // 
            // cn_allowtoreplace
            // 
            this.cn_allowtoreplace.DataPropertyName = "allowtoreplace";
            this.cn_allowtoreplace.HeaderText = "Allow to replace";
            this.cn_allowtoreplace.Name = "cn_allowtoreplace";
            this.cn_allowtoreplace.Visible = false;
            // 
            // btn_Valid
            // 
            this.btn_Valid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Valid.Image = global::Odin.Global_Resourses.Approve_32;
            this.btn_Valid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Valid.Name = "btn_Valid";
            this.btn_Valid.Size = new System.Drawing.Size(23, 22);
            this.btn_Valid.Text = "Validate line";
            this.btn_Valid.Click += new System.EventHandler(this.btn_Valid_Click);
            // 
            // frm_FindAnalogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 286);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_FindAnalogs";
            this.Text = "Find analogs";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_analogid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_valid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_validby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_validat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_who;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_allowtoreplace;
        private System.Windows.Forms.ToolStripButton btn_Valid;
    }
}