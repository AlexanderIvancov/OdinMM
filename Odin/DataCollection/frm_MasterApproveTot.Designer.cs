namespace Odin.DataCollection
{
    partial class frm_MasterApproveTot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MasterApproveTot));
            this.btn_DeleteSN = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.chk_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_launch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtystarrted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_toapprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CheckAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_EditContent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_AssignMaster = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_Valkas2B = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Valkas2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_Approve = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Master = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DeleteSN
            // 
            this.btn_DeleteSN.Image = global::Odin.Global_Resourses.delete2;
            this.btn_DeleteSN.UniqueName = "DA1C7802EB9D4E471E915DBE7CFB126B";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_List.ColumnHeadersHeight = 40;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_check,
            this.cn_launch,
            this.cn_artid,
            this.cn_article,
            this.cn_launchid,
            this.cn_coid,
            this.cn_conforder,
            this.cn_qtystarrted,
            this.cn_qty,
            this.cn_toapprove});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 50;
            this.gv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_List.Size = new System.Drawing.Size(913, 723);
            this.gv_List.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_List.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.TabIndex = 228;
            this.gv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellContentClick);
            // 
            // chk_check
            // 
            this.chk_check.DataPropertyName = "toadd";
            this.chk_check.FalseValue = "0";
            this.chk_check.FillWeight = 80F;
            this.chk_check.HeaderText = "Check";
            this.chk_check.IndeterminateValue = "1";
            this.chk_check.Name = "chk_check";
            this.chk_check.TrueValue = "-1";
            this.chk_check.Width = 80;
            // 
            // cn_launch
            // 
            this.cn_launch.DataPropertyName = "launch";
            this.cn_launch.FillWeight = 220F;
            this.cn_launch.HeaderText = "Launch";
            this.cn_launch.Name = "cn_launch";
            this.cn_launch.ReadOnly = true;
            this.cn_launch.Width = 220;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
            this.cn_artid.Visible = false;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 250F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Visible = false;
            this.cn_article.Width = 250;
            // 
            // cn_launchid
            // 
            this.cn_launchid.DataPropertyName = "launchid";
            this.cn_launchid.HeaderText = "launchid";
            this.cn_launchid.Name = "cn_launchid";
            this.cn_launchid.ReadOnly = true;
            this.cn_launchid.Visible = false;
            // 
            // cn_coid
            // 
            this.cn_coid.HeaderText = "coid";
            this.cn_coid.Name = "cn_coid";
            this.cn_coid.Visible = false;
            // 
            // cn_conforder
            // 
            this.cn_conforder.FillWeight = 300F;
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            this.cn_conforder.ReadOnly = true;
            this.cn_conforder.Visible = false;
            this.cn_conforder.Width = 300;
            // 
            // cn_qtystarrted
            // 
            this.cn_qtystarrted.DataPropertyName = "qtystarted";
            this.cn_qtystarrted.FillWeight = 150F;
            this.cn_qtystarrted.HeaderText = "Qty started";
            this.cn_qtystarrted.Name = "cn_qtystarrted";
            this.cn_qtystarrted.Width = 150;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 150F;
            this.cn_qty.HeaderText = "Qty made";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 150;
            // 
            // cn_toapprove
            // 
            this.cn_toapprove.DataPropertyName = "toapprove";
            this.cn_toapprove.FillWeight = 150F;
            this.cn_toapprove.HeaderText = "To approve";
            this.cn_toapprove.Name = "cn_toapprove";
            this.cn_toapprove.Width = 150;
            // 
            // btn_CheckAll
            // 
            this.btn_CheckAll.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked;
            this.btn_CheckAll.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_CheckAll.Image = global::Odin.Global_Resourses.check21;
            this.btn_CheckAll.Text = "Check all serials";
            this.btn_CheckAll.UniqueName = "81681B3AEC05405E34B119F6E7AE8DA4";
            this.btn_CheckAll.Visible = false;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_DeleteSN,
            this.btn_CheckAll,
            this.btn_Refresh});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(915, 781);
            this.kryptonHeaderGroup1.TabIndex = 251;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Serial numbers of products";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.pci;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Labels list ";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_Refresh.UniqueName = "FD381D0D561B4DA5DB9A876899A04899";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(915, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_EditContent);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_AssignMaster);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Master);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(335, 781);
            this.kryptonHeaderGroup2.TabIndex = 249;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Actions";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.agt_update_critical;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Worker info";
            // 
            // btn_EditContent
            // 
            this.btn_EditContent.Location = new System.Drawing.Point(16, 160);
            this.btn_EditContent.Name = "btn_EditContent";
            this.btn_EditContent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_EditContent.Size = new System.Drawing.Size(306, 70);
            this.btn_EditContent.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditContent.TabIndex = 248;
            this.btn_EditContent.Values.Image = global::Odin.Global_Resourses.edit;
            this.btn_EditContent.Values.Text = "Edit content";
            this.btn_EditContent.Click += new System.EventHandler(this.btn_EditContent_Click);
            // 
            // btn_AssignMaster
            // 
            this.btn_AssignMaster.Location = new System.Drawing.Point(16, 84);
            this.btn_AssignMaster.Name = "btn_AssignMaster";
            this.btn_AssignMaster.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_AssignMaster.Size = new System.Drawing.Size(306, 70);
            this.btn_AssignMaster.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AssignMaster.TabIndex = 246;
            this.btn_AssignMaster.Values.Image = global::Odin.Global_Resourses.Master;
            this.btn_AssignMaster.Values.Text = "Assign master";
            this.btn_AssignMaster.Click += new System.EventHandler(this.btn_AssignMaster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rb_Valkas2B);
            this.panel1.Controls.Add(this.rb_Valkas2);
            this.panel1.Controls.Add(this.btn_Approve);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 258);
            this.panel1.TabIndex = 244;
            // 
            // rb_Valkas2B
            // 
            this.rb_Valkas2B.Location = new System.Drawing.Point(167, 26);
            this.rb_Valkas2B.Name = "rb_Valkas2B";
            this.rb_Valkas2B.Size = new System.Drawing.Size(113, 26);
            this.rb_Valkas2B.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Valkas2B.TabIndex = 251;
            this.rb_Valkas2B.Values.Text = "Valkas 2B";
            // 
            // rb_Valkas2
            // 
            this.rb_Valkas2.Location = new System.Drawing.Point(16, 26);
            this.rb_Valkas2.Name = "rb_Valkas2";
            this.rb_Valkas2.Size = new System.Drawing.Size(100, 26);
            this.rb_Valkas2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Valkas2.TabIndex = 250;
            this.rb_Valkas2.Values.Text = "Valkas 2";
            // 
            // btn_Approve
            // 
            this.btn_Approve.Location = new System.Drawing.Point(16, 88);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Approve.Size = new System.Drawing.Size(306, 77);
            this.btn_Approve.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Approve.TabIndex = 241;
            this.btn_Approve.Values.Image = global::Odin.Global_Resourses.Approve_48;
            this.btn_Approve.Values.Text = "Approve";
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(16, 171);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Close.Size = new System.Drawing.Size(306, 77);
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.TabIndex = 240;
            this.btn_Close.Values.Image = global::Odin.Global_Resourses.exit;
            this.btn_Close.Values.Text = "Exit";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(16, 7);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(81, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 239;
            this.kryptonLabel2.Values.Text = "Master:";
            // 
            // txt_Master
            // 
            this.txt_Master.Enabled = false;
            this.txt_Master.Location = new System.Drawing.Point(16, 38);
            this.txt_Master.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Master.Multiline = true;
            this.txt_Master.Name = "txt_Master";
            this.txt_Master.ReadOnly = true;
            this.txt_Master.Size = new System.Drawing.Size(306, 41);
            this.txt_Master.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Master.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Master.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Master.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Master.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Master.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Master.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Master.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Master.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Master.TabIndex = 240;
            this.txt_Master.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_MasterApproveTot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 781);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MasterApproveTot";
            this.TabText = "Supervisor\'s Approval";
            this.Text = "Supervisor\'s Approval";
            this.Load += new System.EventHandler(this.frm_MasterApproveTot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_DeleteSN;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_CheckAll;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AssignMaster;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2B;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Approve;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Master;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_EditContent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtystarrted;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_toapprove;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Refresh;
    }
}