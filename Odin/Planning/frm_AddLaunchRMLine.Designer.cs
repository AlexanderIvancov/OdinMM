namespace Odin.Planning
{
    partial class frm_AddLaunchRMLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddLaunchRMLine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
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
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_batchdetid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bomnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_analog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyinbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totallaunched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_onstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_notplaced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtypo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_porder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_confdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_inbom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_theorstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 402);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(776, 57);
            this.kryptonPanel1.TabIndex = 49;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cancel.Location = new System.Drawing.Point(676, 10);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 37);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(586, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 37);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
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
            this.bindingNavigatorSeparator2});
            this.bn_List.Location = new System.Drawing.Point(0, 377);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(776, 25);
            this.bn_List.TabIndex = 263;
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
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeight = 25;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_batchdetid,
            this.cn_bomnum,
            this.cn_stage,
            this.cn_artid,
            this.cn_article,
            this.cn_analog,
            this.cn_unit,
            this.cn_qty,
            this.cn_qtyinbatch,
            this.cn_totallaunched,
            this.cn_onstock,
            this.cn_reserved,
            this.cn_notplaced,
            this.cn_qtypo,
            this.cn_porder,
            this.cn_confdate,
            this.cn_inbom,
            this.cn_available,
            this.cn_theorstock});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(776, 377);
            this.gv_List.TabIndex = 264;
            // 
            // cn_batchdetid
            // 
            this.cn_batchdetid.DataPropertyName = "batchdetid";
            this.cn_batchdetid.HeaderText = "bdid";
            this.cn_batchdetid.Name = "cn_batchdetid";
            this.cn_batchdetid.Visible = false;
            // 
            // cn_bomnum
            // 
            this.cn_bomnum.DataPropertyName = "bomnum";
            this.cn_bomnum.FillWeight = 40F;
            this.cn_bomnum.HeaderText = "BOM №";
            this.cn_bomnum.Name = "cn_bomnum";
            this.cn_bomnum.Width = 40;
            // 
            // cn_stage
            // 
            this.cn_stage.DataPropertyName = "stage";
            this.cn_stage.FillWeight = 70F;
            this.cn_stage.HeaderText = "Stage";
            this.cn_stage.Name = "cn_stage";
            this.cn_stage.Width = 70;
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
            // cn_analog
            // 
            this.cn_analog.DataPropertyName = "analogs";
            this.cn_analog.HeaderText = "Analogs";
            this.cn_analog.Name = "cn_analog";
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
            this.cn_qty.HeaderText = "Qty in launch";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 85;
            // 
            // cn_qtyinbatch
            // 
            this.cn_qtyinbatch.DataPropertyName = "qtyinbatch";
            this.cn_qtyinbatch.HeaderText = "Qty in batch";
            this.cn_qtyinbatch.Name = "cn_qtyinbatch";
            // 
            // cn_totallaunched
            // 
            this.cn_totallaunched.DataPropertyName = "launched";
            this.cn_totallaunched.HeaderText = "Total launched";
            this.cn_totallaunched.Name = "cn_totallaunched";
            this.cn_totallaunched.Visible = false;
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
            // cn_reserved
            // 
            this.cn_reserved.DataPropertyName = "reserved";
            this.cn_reserved.FillWeight = 70F;
            this.cn_reserved.HeaderText = "Reserved";
            this.cn_reserved.Name = "cn_reserved";
            this.cn_reserved.ReadOnly = true;
            this.cn_reserved.Width = 70;
            // 
            // cn_notplaced
            // 
            this.cn_notplaced.DataPropertyName = "notplaced";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.cn_notplaced.DefaultCellStyle = dataGridViewCellStyle2;
            this.cn_notplaced.FillWeight = 70F;
            this.cn_notplaced.HeaderText = "Not placed";
            this.cn_notplaced.Name = "cn_notplaced";
            this.cn_notplaced.Width = 70;
            // 
            // cn_qtypo
            // 
            this.cn_qtypo.DataPropertyName = "purchased";
            this.cn_qtypo.FillWeight = 70F;
            this.cn_qtypo.HeaderText = "Purchased";
            this.cn_qtypo.Name = "cn_qtypo";
            this.cn_qtypo.Width = 70;
            // 
            // cn_porder
            // 
            this.cn_porder.DataPropertyName = "porder";
            this.cn_porder.HeaderText = "Pur. order";
            this.cn_porder.Name = "cn_porder";
            // 
            // cn_confdate
            // 
            this.cn_confdate.DataPropertyName = "confdate";
            this.cn_confdate.HeaderText = "Conf. deliv. date";
            this.cn_confdate.Name = "cn_confdate";
            // 
            // cn_inbom
            // 
            this.cn_inbom.DataPropertyName = "qtybom";
            this.cn_inbom.FillWeight = 70F;
            this.cn_inbom.HeaderText = "In BOM.";
            this.cn_inbom.Name = "cn_inbom";
            this.cn_inbom.ReadOnly = true;
            this.cn_inbom.Width = 70;
            // 
            // cn_available
            // 
            this.cn_available.DataPropertyName = "qtyavailable";
            this.cn_available.HeaderText = "Available";
            this.cn_available.Name = "cn_available";
            this.cn_available.Visible = false;
            // 
            // cn_theorstock
            // 
            this.cn_theorstock.DataPropertyName = "theorstock";
            this.cn_theorstock.HeaderText = "Theor. stock";
            this.cn_theorstock.Name = "cn_theorstock";
            // 
            // frm_AddLaunchRMLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 459);
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddLaunchRMLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add launch lines";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private Global_Classes.SyncBindingSource bs_List;
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
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batchdetid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bomnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_analog;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyinbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totallaunched;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_onstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_notplaced;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtypo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_porder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_confdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inbom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_theorstock;
    }
}