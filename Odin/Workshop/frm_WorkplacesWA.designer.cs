namespace Odin.Workshop
{
    partial class frm_WorkplacesWA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_WorkplacesWA));
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
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
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.ctl_WorkplacesWA1 = new Odin.Workshop.ctl_WorkplacesWA();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_tabnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_workdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_fulldate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_workhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_workplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_operno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btn_Cancel);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 596);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(1230, 49);
            this.kryptonPanel2.TabIndex = 34;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cancel.Location = new System.Drawing.Point(1135, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 39);
            this.btn_Cancel.TabIndex = 228;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(703, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 596);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(706, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(524, 596);
            this.kryptonHeaderGroup1.TabIndex = 37;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Worktables and workers assignment";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.workers_refresh;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_worker,
            this.cn_tabnr,
            this.cn_workdate,
            this.chk_fulldate,
            this.cn_workhours,
            this.cn_workplace,
            this.cn_launch,
            this.cn_batch,
            this.cn_operno,
            this.cn_artid,
            this.cn_article,
            this.cn_secname,
            this.cn_dconforder});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(522, 515);
            this.gv_List.TabIndex = 8;
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
            this.btn_Edit,
            this.btn_Delete,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 515);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(522, 25);
            this.bn_List.TabIndex = 3;
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
            // btn_Excel
            // 
            this.btn_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(23, 22);
            this.btn_Excel.Text = "Export into excel";
            // 
            // btn_Edit
            // 
            this.btn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Edit.Image = global::Odin.Global_Resourses.edit;
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(23, 22);
            this.btn_Edit.Text = "Edit assignment";
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Delete.Image = global::Odin.Global_Resourses.bindingNavigatorDeleteItem_Image;
            this.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(23, 22);
            this.btn_Delete.Text = "Delete assignment";
            // 
            // ctl_WorkplacesWA1
            // 
            this.ctl_WorkplacesWA1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctl_WorkplacesWA1.Location = new System.Drawing.Point(0, 0);
            this.ctl_WorkplacesWA1.Name = "ctl_WorkplacesWA1";
            this.ctl_WorkplacesWA1.Size = new System.Drawing.Size(703, 596);
            this.ctl_WorkplacesWA1.TabIndex = 35;
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
            // cn_worker
            // 
            this.cn_worker.DataPropertyName = "worker";
            this.cn_worker.FillWeight = 180F;
            this.cn_worker.HeaderText = "Worker";
            this.cn_worker.Name = "cn_worker";
            this.cn_worker.Width = 180;
            // 
            // cn_tabnr
            // 
            this.cn_tabnr.DataPropertyName = "tabnum";
            this.cn_tabnr.HeaderText = "Tab. NR";
            this.cn_tabnr.Name = "cn_tabnr";
            // 
            // cn_workdate
            // 
            this.cn_workdate.DataPropertyName = "workdate";
            this.cn_workdate.HeaderText = "Work date";
            this.cn_workdate.Name = "cn_workdate";
            // 
            // chk_fulldate
            // 
            this.chk_fulldate.DataPropertyName = "fulldate";
            this.chk_fulldate.FalseValue = "-1";
            this.chk_fulldate.FillWeight = 40F;
            this.chk_fulldate.HeaderText = "Full date";
            this.chk_fulldate.IndeterminateValue = "1";
            this.chk_fulldate.Name = "chk_fulldate";
            this.chk_fulldate.TrueValue = "0";
            this.chk_fulldate.Width = 40;
            // 
            // cn_workhours
            // 
            this.cn_workhours.DataPropertyName = "workhours";
            this.cn_workhours.HeaderText = "Worktime (min)";
            this.cn_workhours.Name = "cn_workhours";
            // 
            // cn_workplace
            // 
            this.cn_workplace.DataPropertyName = "workplace";
            this.cn_workplace.HeaderText = "Workplace";
            this.cn_workplace.Name = "cn_workplace";
            // 
            // cn_launch
            // 
            this.cn_launch.DataPropertyName = "launch";
            this.cn_launch.HeaderText = "Launch";
            this.cn_launch.Name = "cn_launch";
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.ReadOnly = true;
            // 
            // cn_operno
            // 
            this.cn_operno.DataPropertyName = "operno";
            this.cn_operno.HeaderText = "Oper. NO";
            this.cn_operno.Name = "cn_operno";
            this.cn_operno.Visible = false;
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
            // cn_secname
            // 
            this.cn_secname.DataPropertyName = "secname";
            this.cn_secname.HeaderText = "Sec. name";
            this.cn_secname.Name = "cn_secname";
            // 
            // cn_dconforder
            // 
            this.cn_dconforder.DataPropertyName = "conforder";
            this.cn_dconforder.HeaderText = "Conf. order";
            this.cn_dconforder.Name = "cn_dconforder";
            this.cn_dconforder.ReadOnly = true;
            // 
            // frm_WorkplacesWA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 645);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ctl_WorkplacesWA1);
            this.Controls.Add(this.kryptonPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_WorkplacesWA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Workers assignment";
            this.Text = "Workers assignment";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Main _Main;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ctl_WorkplacesWA ctl_WorkplacesWA1;
        private BSE.Windows.Forms.Splitter splitter1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
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
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_tabnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_workdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_fulldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_workhours;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_workplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_operno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dconforder;
    }
}