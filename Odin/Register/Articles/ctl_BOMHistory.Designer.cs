namespace Odin.Register.Articles
{
    partial class ctl_BOMHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_BOMHistory));
            this.mnu_LinesHis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForHis = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchHis = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByHis = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelHis = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterHis = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyHis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminHis = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_HistoryList = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_HistoryList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_hline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_hartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_harticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_hsecart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_hunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_hqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_hcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nspoilnorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_spoilconst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_typechange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_hstage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_HistoryList = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_HistoryExcel = new System.Windows.Forms.ToolStripButton();
            this.mnu_LinesHis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_HistoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HistoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_HistoryList)).BeginInit();
            this.bn_HistoryList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_LinesHis
            // 
            this.mnu_LinesHis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_LinesHis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForHis,
            this.mni_SearchHis,
            this.mni_FilterByHis,
            this.mni_FilterExcludingSelHis,
            this.mni_RemoveFilterHis,
            this.mni_CopyHis,
            this.toolStripSeparator5,
            this.mni_AdminHis});
            this.mnu_LinesHis.Name = "mnu_Requests";
            this.mnu_LinesHis.Size = new System.Drawing.Size(211, 167);
            this.mnu_LinesHis.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesHis_Opening);
            // 
            // mni_FilterForHis
            // 
            this.mni_FilterForHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForHis.Name = "mni_FilterForHis";
            this.mni_FilterForHis.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForHis.TextChanged += new System.EventHandler(this.mni_FilterForHis_TextChanged);
            // 
            // mni_SearchHis
            // 
            this.mni_SearchHis.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchHis.Name = "mni_SearchHis";
            this.mni_SearchHis.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchHis.Text = "Search for record";
            this.mni_SearchHis.Click += new System.EventHandler(this.mni_SearchHis_Click);
            // 
            // mni_FilterByHis
            // 
            this.mni_FilterByHis.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByHis.Name = "mni_FilterByHis";
            this.mni_FilterByHis.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByHis.Text = "Filter by selection";
            this.mni_FilterByHis.Click += new System.EventHandler(this.mni_FilterByHis_Click);
            // 
            // mni_FilterExcludingSelHis
            // 
            this.mni_FilterExcludingSelHis.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelHis.Name = "mni_FilterExcludingSelHis";
            this.mni_FilterExcludingSelHis.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelHis.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelHis.Click += new System.EventHandler(this.mni_FilterExcludingSelHis_Click);
            // 
            // mni_RemoveFilterHis
            // 
            this.mni_RemoveFilterHis.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterHis.Name = "mni_RemoveFilterHis";
            this.mni_RemoveFilterHis.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterHis.Text = "Remove filter";
            this.mni_RemoveFilterHis.Click += new System.EventHandler(this.mni_RemoveFilterHis_Click);
            // 
            // mni_CopyHis
            // 
            this.mni_CopyHis.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyHis.Name = "mni_CopyHis";
            this.mni_CopyHis.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyHis.Text = "Copy";
            this.mni_CopyHis.Click += new System.EventHandler(this.mni_CopyHis_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminHis
            // 
            this.mni_AdminHis.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminHis.Name = "mni_AdminHis";
            this.mni_AdminHis.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminHis.Text = "List settings";
            this.mni_AdminHis.Click += new System.EventHandler(this.mni_AdminHis_Click);
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup3.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup3.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.gv_HistoryList);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.bn_HistoryList);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(690, 439);
            this.kryptonHeaderGroup3.TabIndex = 14;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "History of BOM changes";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::Odin.Global_Resourses.history24x24;
            // 
            // gv_HistoryList
            // 
            this.gv_HistoryList.AllowUserToAddRows = false;
            this.gv_HistoryList.ColumnHeadersHeight = 25;
            this.gv_HistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_HistoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_hline,
            this.cn_hartid,
            this.cn_harticle,
            this.cn_hsecart,
            this.cn_hunit,
            this.cn_hqty,
            this.dataGridViewTextBoxColumn5,
            this.cn_hcomments,
            this.cn_nspoilnorm,
            this.cn_spoilconst,
            this.cn_typechange,
            this.cn_who,
            this.cn_when,
            this.cn_nid,
            this.cn_hstage});
            this.gv_HistoryList.ContextMenuStrip = this.mnu_LinesHis;
            this.gv_HistoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_HistoryList.Location = new System.Drawing.Point(0, 25);
            this.gv_HistoryList.Name = "gv_HistoryList";
            this.gv_HistoryList.RowHeadersWidth = 25;
            this.gv_HistoryList.Size = new System.Drawing.Size(688, 385);
            this.gv_HistoryList.TabIndex = 1;
            this.gv_HistoryList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_HistoryList_ColumnHeaderMouseClick);
            // 
            // cn_hline
            // 
            this.cn_hline.DataPropertyName = "line";
            this.cn_hline.FillWeight = 40F;
            this.cn_hline.HeaderText = "Line";
            this.cn_hline.Name = "cn_hline";
            this.cn_hline.Width = 40;
            // 
            // cn_hartid
            // 
            this.cn_hartid.DataPropertyName = "artid";
            this.cn_hartid.HeaderText = "Art.id.";
            this.cn_hartid.Name = "cn_hartid";
            // 
            // cn_harticle
            // 
            this.cn_harticle.DataPropertyName = "article";
            this.cn_harticle.FillWeight = 150F;
            this.cn_harticle.HeaderText = "Article name";
            this.cn_harticle.Name = "cn_harticle";
            this.cn_harticle.Width = 150;
            // 
            // cn_hsecart
            // 
            this.cn_hsecart.DataPropertyName = "secname";
            this.cn_hsecart.FillWeight = 120F;
            this.cn_hsecart.HeaderText = "2nd name";
            this.cn_hsecart.Name = "cn_hsecart";
            this.cn_hsecart.Width = 120;
            // 
            // cn_hunit
            // 
            this.cn_hunit.DataPropertyName = "unit";
            this.cn_hunit.FillWeight = 40F;
            this.cn_hunit.HeaderText = "Unit";
            this.cn_hunit.Name = "cn_hunit";
            this.cn_hunit.Width = 40;
            // 
            // cn_hqty
            // 
            this.cn_hqty.DataPropertyName = "qty";
            this.cn_hqty.FillWeight = 50F;
            this.cn_hqty.HeaderText = "Qty";
            this.cn_hqty.Name = "cn_hqty";
            this.cn_hqty.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "using";
            this.dataGridViewTextBoxColumn5.FalseValue = "0";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Using";
            this.dataGridViewTextBoxColumn5.IndeterminateValue = "1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.TrueValue = "-1";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // cn_hcomments
            // 
            this.cn_hcomments.DataPropertyName = "comments";
            this.cn_hcomments.HeaderText = "Comments";
            this.cn_hcomments.Name = "cn_hcomments";
            // 
            // cn_nspoilnorm
            // 
            this.cn_nspoilnorm.DataPropertyName = "spoilnorm";
            this.cn_nspoilnorm.FillWeight = 50F;
            this.cn_nspoilnorm.HeaderText = "Spoil. %";
            this.cn_nspoilnorm.Name = "cn_nspoilnorm";
            this.cn_nspoilnorm.Width = 50;
            // 
            // cn_spoilconst
            // 
            this.cn_spoilconst.DataPropertyName = "spoilconst";
            this.cn_spoilconst.HeaderText = "Spoil. const";
            this.cn_spoilconst.Name = "cn_spoilconst";
            // 
            // cn_typechange
            // 
            this.cn_typechange.DataPropertyName = "typechange";
            this.cn_typechange.HeaderText = "Type of change";
            this.cn_typechange.Name = "cn_typechange";
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
            // cn_nid
            // 
            this.cn_nid.DataPropertyName = "id";
            this.cn_nid.FillWeight = 5F;
            this.cn_nid.HeaderText = "id";
            this.cn_nid.Name = "cn_nid";
            this.cn_nid.Visible = false;
            this.cn_nid.Width = 5;
            // 
            // cn_hstage
            // 
            this.cn_hstage.DataPropertyName = "stage";
            this.cn_hstage.HeaderText = "Stage";
            this.cn_hstage.Name = "cn_hstage";
            // 
            // bn_HistoryList
            // 
            this.bn_HistoryList.AddNewItem = null;
            this.bn_HistoryList.CountItem = this.toolStripLabel1;
            this.bn_HistoryList.DeleteItem = null;
            this.bn_HistoryList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_HistoryList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.btn_HistoryExcel});
            this.bn_HistoryList.Location = new System.Drawing.Point(0, 0);
            this.bn_HistoryList.MoveFirstItem = this.toolStripButton1;
            this.bn_HistoryList.MoveLastItem = this.toolStripButton4;
            this.bn_HistoryList.MoveNextItem = this.toolStripButton3;
            this.bn_HistoryList.MovePreviousItem = this.toolStripButton2;
            this.bn_HistoryList.Name = "bn_HistoryList";
            this.bn_HistoryList.PositionItem = this.toolStripTextBox1;
            this.bn_HistoryList.Size = new System.Drawing.Size(688, 25);
            this.bn_HistoryList.TabIndex = 0;
            this.bn_HistoryList.Text = "bindingNavigator1";
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
            // btn_HistoryExcel
            // 
            this.btn_HistoryExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_HistoryExcel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_HistoryExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_HistoryExcel.Name = "btn_HistoryExcel";
            this.btn_HistoryExcel.Size = new System.Drawing.Size(23, 22);
            this.btn_HistoryExcel.Text = "Export into excel";
            this.btn_HistoryExcel.Click += new System.EventHandler(this.btn_HistoryExcel_Click);
            // 
            // ctl_BOMHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup3);
            this.Name = "ctl_BOMHistory";
            this.Size = new System.Drawing.Size(690, 439);
            this.Load += new System.EventHandler(this.ctl_BOMHistory_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ctl_BOMHistory_Paint);
            this.mnu_LinesHis.ResumeLayout(false);
            this.mnu_LinesHis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_HistoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_HistoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_HistoryList)).EndInit();
            this.bn_HistoryList.ResumeLayout(false);
            this.bn_HistoryList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mnu_LinesHis;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForHis;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchHis;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByHis;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelHis;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterHis;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyHis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminHis;
        private System.Windows.Forms.BindingSource bs_HistoryList;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_hline;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_hartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_harticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_hsecart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_hunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_hqty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_hcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nspoilnorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_spoilconst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_typechange;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_who;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_hstage;
        private System.Windows.Forms.BindingNavigator bn_HistoryList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_HistoryExcel;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_HistoryList;
    }
}
