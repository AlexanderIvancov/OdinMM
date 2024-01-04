namespace Odin.Sales
{
    partial class ctl_COHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_COHistory));
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
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_corder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_service = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reqdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_logcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_delivplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_delivaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_typechange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_resale = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_Internal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1116, 414);
            this.kryptonHeaderGroup1.TabIndex = 16;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "History of confirmation order changes";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.history24x24;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeight = 25;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_conforder,
            this.cn_line,
            this.cn_customer,
            this.cn_artid,
            this.cn_art,
            this.cn_custarticle,
            this.cn_corder,
            this.cn_coline,
            this.chk_service,
            this.cn_qty,
            this.cn_unit,
            this.cn_unitprice,
            this.cn_currency,
            this.cn_reqdate,
            this.cn_state,
            this.cn_comments,
            this.cn_comments1,
            this.cn_logcomments,
            this.cn_delivplace,
            this.cn_delivaddress,
            this.cn_typechange,
            this.cn_who,
            this.cn_when,
            this.cn_id,
            this.cn_headid,
            this.cn_resale,
            this.cn_Internal});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 25);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(1114, 360);
            this.gv_List.TabIndex = 1;
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
            this.bindingNavigatorSeparator2});
            this.bn_List.Location = new System.Drawing.Point(0, 0);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(1114, 25);
            this.bn_List.TabIndex = 0;
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
            // cn_conforder
            // 
            this.cn_conforder.DataPropertyName = "conforder";
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            // 
            // cn_line
            // 
            this.cn_line.DataPropertyName = "orderline";
            this.cn_line.FillWeight = 50F;
            this.cn_line.HeaderText = "Line";
            this.cn_line.Name = "cn_line";
            this.cn_line.Width = 50;
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.HeaderText = "Art.id.";
            this.cn_artid.Name = "cn_artid";
            // 
            // cn_art
            // 
            this.cn_art.DataPropertyName = "article";
            this.cn_art.FillWeight = 150F;
            this.cn_art.HeaderText = "Article ";
            this.cn_art.Name = "cn_art";
            this.cn_art.Width = 150;
            // 
            // cn_custarticle
            // 
            this.cn_custarticle.DataPropertyName = "custarticle";
            this.cn_custarticle.FillWeight = 120F;
            this.cn_custarticle.HeaderText = "Cust. article";
            this.cn_custarticle.Name = "cn_custarticle";
            this.cn_custarticle.Width = 120;
            // 
            // cn_corder
            // 
            this.cn_corder.DataPropertyName = "corder";
            this.cn_corder.HeaderText = "Cust. order";
            this.cn_corder.Name = "cn_corder";
            // 
            // cn_coline
            // 
            this.cn_coline.DataPropertyName = "coline";
            this.cn_coline.FillWeight = 50F;
            this.cn_coline.HeaderText = "CO line";
            this.cn_coline.Name = "cn_coline";
            this.cn_coline.Width = 50;
            // 
            // chk_service
            // 
            this.chk_service.DataPropertyName = "service";
            this.chk_service.FalseValue = "0";
            this.chk_service.FillWeight = 40F;
            this.chk_service.HeaderText = "Service";
            this.chk_service.IndeterminateValue = "1";
            this.chk_service.Name = "chk_service";
            this.chk_service.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk_service.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk_service.TrueValue = "-1";
            this.chk_service.Width = 40;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 80F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 80;
            // 
            // cn_unit
            // 
            this.cn_unit.DataPropertyName = "unit";
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.Width = 40;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.FillWeight = 80F;
            this.cn_unitprice.HeaderText = "Unit price";
            this.cn_unitprice.Name = "cn_unitprice";
            this.cn_unitprice.Width = 80;
            // 
            // cn_currency
            // 
            this.cn_currency.DataPropertyName = "currency";
            this.cn_currency.FillWeight = 40F;
            this.cn_currency.HeaderText = "Curr.";
            this.cn_currency.Name = "cn_currency";
            this.cn_currency.Width = 40;
            // 
            // cn_reqdate
            // 
            this.cn_reqdate.DataPropertyName = "reqdate";
            this.cn_reqdate.HeaderText = "Req. date";
            this.cn_reqdate.Name = "cn_reqdate";
            // 
            // cn_state
            // 
            this.cn_state.DataPropertyName = "state";
            this.cn_state.HeaderText = "State";
            this.cn_state.Name = "cn_state";
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            // 
            // cn_comments1
            // 
            this.cn_comments1.DataPropertyName = "comments1";
            this.cn_comments1.HeaderText = "Comments 2";
            this.cn_comments1.Name = "cn_comments1";
            // 
            // cn_logcomments
            // 
            this.cn_logcomments.DataPropertyName = "logcomments";
            this.cn_logcomments.HeaderText = "Log. comments";
            this.cn_logcomments.Name = "cn_logcomments";
            // 
            // cn_delivplace
            // 
            this.cn_delivplace.DataPropertyName = "deliveryplace";
            this.cn_delivplace.HeaderText = "Deliv. place";
            this.cn_delivplace.Name = "cn_delivplace";
            // 
            // cn_delivaddress
            // 
            this.cn_delivaddress.DataPropertyName = "deliveryaddress";
            this.cn_delivaddress.FillWeight = 150F;
            this.cn_delivaddress.HeaderText = "Deliv. address";
            this.cn_delivaddress.Name = "cn_delivaddress";
            this.cn_delivaddress.Width = 150;
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
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.FillWeight = 5F;
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            this.cn_id.Width = 5;
            // 
            // cn_headid
            // 
            this.cn_headid.DataPropertyName = "headid";
            this.cn_headid.HeaderText = "headid";
            this.cn_headid.Name = "cn_headid";
            this.cn_headid.Visible = false;
            // 
            // cn_resale
            // 
            this.cn_resale.DataPropertyName = "resale";
            this.cn_resale.FalseValue = "0";
            this.cn_resale.FillWeight = 40F;
            this.cn_resale.HeaderText = "Resale";
            this.cn_resale.IndeterminateValue = "1";
            this.cn_resale.Name = "cn_resale";
            this.cn_resale.TrueValue = "-1";
            this.cn_resale.Width = 40;
            // 
            // cn_Internal
            // 
            this.cn_Internal.DataPropertyName = "internal";
            this.cn_Internal.FalseValue = "0";
            this.cn_Internal.FillWeight = 40F;
            this.cn_Internal.HeaderText = "Internal";
            this.cn_Internal.IndeterminateValue = "1";
            this.cn_Internal.Name = "cn_Internal";
            this.cn_Internal.TrueValue = "-1";
            this.cn_Internal.Width = 40;
            // 
            // ctl_COHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "ctl_COHistory";
            this.Size = new System.Drawing.Size(1116, 414);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
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
        private Global_Classes.SyncBindingSource bs_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_corder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reqdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_logcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_delivplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_delivaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_typechange;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_who;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_headid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_resale;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_Internal;
    }
}
