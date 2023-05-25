namespace Odin.Tools
{
    partial class frm_MenuPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MenuPermissions));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_userlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_isactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_isdbuser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_MenuItems = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mtabid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_mchecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_mtabname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mtabtext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_MenuItems = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.bs_MenuItems = new Odin.Global_Classes.SyncBindingSource();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_MenuItems)).BeginInit();
            this.bn_MenuItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(348, 487);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Users";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.User_32x32;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Users list";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_name,
            this.cn_surname,
            this.cn_userlogin,
            this.chk_isactive,
            this.chk_isdbuser,
            this.cn_shortname});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(346, 404);
            this.gv_List.TabIndex = 35;
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
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
            // cn_name
            // 
            this.cn_name.DataPropertyName = "name";
            this.cn_name.HeaderText = "Name";
            this.cn_name.Name = "cn_name";
            this.cn_name.ReadOnly = true;
            // 
            // cn_surname
            // 
            this.cn_surname.DataPropertyName = "surname";
            this.cn_surname.HeaderText = "Surname";
            this.cn_surname.Name = "cn_surname";
            this.cn_surname.ReadOnly = true;
            // 
            // cn_userlogin
            // 
            this.cn_userlogin.DataPropertyName = "userlogin";
            this.cn_userlogin.HeaderText = "Login name";
            this.cn_userlogin.Name = "cn_userlogin";
            this.cn_userlogin.ReadOnly = true;
            this.cn_userlogin.Visible = false;
            // 
            // chk_isactive
            // 
            this.chk_isactive.DataPropertyName = "isactive";
            this.chk_isactive.FalseValue = "0";
            this.chk_isactive.FillWeight = 40F;
            this.chk_isactive.HeaderText = "Active";
            this.chk_isactive.IndeterminateValue = "1";
            this.chk_isactive.Name = "chk_isactive";
            this.chk_isactive.TrueValue = "-1";
            this.chk_isactive.Visible = false;
            this.chk_isactive.Width = 40;
            // 
            // chk_isdbuser
            // 
            this.chk_isdbuser.DataPropertyName = "isdbuser";
            this.chk_isdbuser.FalseValue = "0";
            this.chk_isdbuser.FillWeight = 40F;
            this.chk_isdbuser.HeaderText = "Is db user";
            this.chk_isdbuser.IndeterminateValue = "1";
            this.chk_isdbuser.Name = "chk_isdbuser";
            this.chk_isdbuser.TrueValue = "-1";
            this.chk_isdbuser.Visible = false;
            this.chk_isdbuser.Width = 40;
            // 
            // cn_shortname
            // 
            this.cn_shortname.DataPropertyName = "shortname";
            this.cn_shortname.HeaderText = "Short name";
            this.cn_shortname.Name = "cn_shortname";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonSeparator1.Location = new System.Drawing.Point(348, 0);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(10, 487);
            this.kryptonSeparator1.SplitterWidth = 3;
            this.kryptonSeparator1.TabIndex = 1;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(358, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.gv_MenuItems);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.bn_MenuItems);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(331, 487);
            this.kryptonHeaderGroup2.TabIndex = 2;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Menu permissons";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.Keys;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "List of menu items";
            // 
            // gv_MenuItems
            // 
            this.gv_MenuItems.AllowUserToAddRows = false;
            this.gv_MenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_MenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_mid,
            this.cn_mtabid,
            this.chk_mchecked,
            this.cn_mtabname,
            this.cn_mtabtext});
            this.gv_MenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_MenuItems.Location = new System.Drawing.Point(0, 0);
            this.gv_MenuItems.Name = "gv_MenuItems";
            this.gv_MenuItems.RowHeadersWidth = 25;
            this.gv_MenuItems.Size = new System.Drawing.Size(329, 404);
            this.gv_MenuItems.TabIndex = 36;
            // 
            // cn_mid
            // 
            this.cn_mid.DataPropertyName = "id";
            this.cn_mid.FillWeight = 5F;
            this.cn_mid.HeaderText = "id";
            this.cn_mid.Name = "cn_mid";
            this.cn_mid.ReadOnly = true;
            this.cn_mid.Visible = false;
            this.cn_mid.Width = 5;
            // 
            // cn_mtabid
            // 
            this.cn_mtabid.DataPropertyName = "tabid";
            this.cn_mtabid.HeaderText = "tabid";
            this.cn_mtabid.Name = "cn_mtabid";
            this.cn_mtabid.Visible = false;
            // 
            // chk_mchecked
            // 
            this.chk_mchecked.DataPropertyName = "checked";
            this.chk_mchecked.FalseValue = "0";
            this.chk_mchecked.FillWeight = 40F;
            this.chk_mchecked.HeaderText = "Allow";
            this.chk_mchecked.IndeterminateValue = "1";
            this.chk_mchecked.Name = "chk_mchecked";
            this.chk_mchecked.TrueValue = "-1";
            this.chk_mchecked.Width = 40;
            // 
            // cn_mtabname
            // 
            this.cn_mtabname.DataPropertyName = "tabname";
            this.cn_mtabname.HeaderText = "tabname";
            this.cn_mtabname.Name = "cn_mtabname";
            this.cn_mtabname.ReadOnly = true;
            this.cn_mtabname.Visible = false;
            // 
            // cn_mtabtext
            // 
            this.cn_mtabtext.DataPropertyName = "tabtext";
            this.cn_mtabtext.FillWeight = 150F;
            this.cn_mtabtext.HeaderText = "Tab";
            this.cn_mtabtext.Name = "cn_mtabtext";
            this.cn_mtabtext.ReadOnly = true;
            this.cn_mtabtext.Width = 150;
            // 
            // bn_MenuItems
            // 
            this.bn_MenuItems.AddNewItem = null;
            this.bn_MenuItems.CountItem = this.toolStripLabel2;
            this.bn_MenuItems.DeleteItem = null;
            this.bn_MenuItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_MenuItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_MenuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator6,
            this.btn_Save});
            this.bn_MenuItems.Location = new System.Drawing.Point(0, 404);
            this.bn_MenuItems.MoveFirstItem = this.toolStripButton5;
            this.bn_MenuItems.MoveLastItem = this.toolStripButton8;
            this.bn_MenuItems.MoveNextItem = this.toolStripButton7;
            this.bn_MenuItems.MovePreviousItem = this.toolStripButton6;
            this.bn_MenuItems.Name = "bn_MenuItems";
            this.bn_MenuItems.PositionItem = this.toolStripTextBox2;
            this.bn_MenuItems.Size = new System.Drawing.Size(329, 25);
            this.bn_MenuItems.TabIndex = 35;
            this.bn_MenuItems.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move first";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move previous";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move next";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(23, 22);
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
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
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = this.toolStripLabel1;
            this.bn_List.DeleteItem = null;
            this.bn_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4});
            this.bn_List.Location = new System.Drawing.Point(0, 404);
            this.bn_List.MoveFirstItem = this.toolStripButton1;
            this.bn_List.MoveLastItem = this.toolStripButton4;
            this.bn_List.MoveNextItem = this.toolStripButton3;
            this.bn_List.MovePreviousItem = this.toolStripButton2;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.toolStripTextBox1;
            this.bn_List.Size = new System.Drawing.Size(346, 25);
            this.bn_List.TabIndex = 34;
            this.bn_List.Text = "bindingNavigator1";
            // 
            // frm_MenuPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 487);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonSeparator1);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MenuPermissions";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu permissions";
            this.Load += new System.EventHandler(this.frm_MenuPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_MenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_MenuItems)).EndInit();
            this.bn_MenuItems.ResumeLayout(false);
            this.bn_MenuItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_userlogin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_isactive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_isdbuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_shortname;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_MenuItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mtabid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_mchecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mtabname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mtabtext;
        private System.Windows.Forms.BindingNavigator bn_MenuItems;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Global_Classes.SyncBindingSource bs_MenuItems;
        private Global_Classes.SyncBindingSource bs_List;
    }
}