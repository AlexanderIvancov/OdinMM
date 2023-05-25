namespace Odin.Warehouse.Deliveries
{
    partial class frm_AddArticleForDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddArticleForDelivery));
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Delivery = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bs_Delivery = new System.Windows.Forms.BindingSource(this.components);
            this.chk_Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_dconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ostate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_confdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ddelivplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_daddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_did = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Delivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Delivery)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btn_OK);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 370);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(733, 49);
            this.kryptonPanel2.TabIndex = 32;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(635, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OK.Size = new System.Drawing.Size(93, 39);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
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
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_Delivery);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(733, 370);
            this.kryptonHeaderGroup1.TabIndex = 38;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "List of confirmed orders for selected article";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.Docs24x24;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Please select necessary line and add it into list below";
            // 
            // gv_Delivery
            // 
            this.gv_Delivery.AllowUserToAddRows = false;
            this.gv_Delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Delivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_Add,
            this.cn_dconforder,
            this.cn_ostate,
            this.cn_dclient,
            this.cn_confdate,
            this.cn_dqty,
            this.cn_dunit,
            this.cn_oUnitPrice,
            this.cn_custorder,
            this.cn_ddelivplace,
            this.cn_daddress,
            this.cn_custarticle,
            this.cn_dcomments,
            this.cn_dcoid,
            this.cn_did});
            this.gv_Delivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Delivery.Location = new System.Drawing.Point(0, 0);
            this.gv_Delivery.Name = "gv_Delivery";
            this.gv_Delivery.RowHeadersWidth = 25;
            this.gv_Delivery.Size = new System.Drawing.Size(731, 341);
            this.gv_Delivery.TabIndex = 6;
            // 
            // chk_Add
            // 
            this.chk_Add.DataPropertyName = "toadd";
            this.chk_Add.FalseValue = "0";
            this.chk_Add.FillWeight = 35F;
            this.chk_Add.HeaderText = "Add";
            this.chk_Add.IndeterminateValue = "1";
            this.chk_Add.Name = "chk_Add";
            this.chk_Add.TrueValue = "-1";
            this.chk_Add.Width = 35;
            // 
            // cn_dconforder
            // 
            this.cn_dconforder.DataPropertyName = "conforder";
            this.cn_dconforder.HeaderText = "Conf. order";
            this.cn_dconforder.Name = "cn_dconforder";
            this.cn_dconforder.ReadOnly = true;
            // 
            // cn_ostate
            // 
            this.cn_ostate.DataPropertyName = "orderstate";
            this.cn_ostate.HeaderText = "State";
            this.cn_ostate.Name = "cn_ostate";
            // 
            // cn_dclient
            // 
            this.cn_dclient.DataPropertyName = "client";
            this.cn_dclient.FillWeight = 120F;
            this.cn_dclient.HeaderText = "Customer";
            this.cn_dclient.Name = "cn_dclient";
            this.cn_dclient.ReadOnly = true;
            this.cn_dclient.Width = 120;
            // 
            // cn_confdate
            // 
            this.cn_confdate.DataPropertyName = "confdate";
            this.cn_confdate.HeaderText = "Conf. date";
            this.cn_confdate.Name = "cn_confdate";
            // 
            // cn_dqty
            // 
            this.cn_dqty.DataPropertyName = "confqty";
            this.cn_dqty.FillWeight = 90F;
            this.cn_dqty.HeaderText = "Conf. qty";
            this.cn_dqty.Name = "cn_dqty";
            this.cn_dqty.ReadOnly = true;
            this.cn_dqty.Width = 90;
            // 
            // cn_dunit
            // 
            this.cn_dunit.DataPropertyName = "unit";
            this.cn_dunit.FillWeight = 40F;
            this.cn_dunit.HeaderText = "Unit";
            this.cn_dunit.Name = "cn_dunit";
            this.cn_dunit.ReadOnly = true;
            this.cn_dunit.Width = 40;
            // 
            // cn_oUnitPrice
            // 
            this.cn_oUnitPrice.DataPropertyName = "unitprice";
            this.cn_oUnitPrice.HeaderText = "Unit price (€)";
            this.cn_oUnitPrice.Name = "cn_oUnitPrice";
            // 
            // cn_custorder
            // 
            this.cn_custorder.DataPropertyName = "custorder";
            this.cn_custorder.HeaderText = "Customer\'s order";
            this.cn_custorder.Name = "cn_custorder";
            // 
            // cn_ddelivplace
            // 
            this.cn_ddelivplace.DataPropertyName = "delivplace";
            this.cn_ddelivplace.FillWeight = 150F;
            this.cn_ddelivplace.HeaderText = "Deliv. place";
            this.cn_ddelivplace.Name = "cn_ddelivplace";
            this.cn_ddelivplace.ReadOnly = true;
            this.cn_ddelivplace.Width = 150;
            // 
            // cn_daddress
            // 
            this.cn_daddress.DataPropertyName = "delivaddress";
            this.cn_daddress.FillWeight = 125F;
            this.cn_daddress.HeaderText = "Deliv. address";
            this.cn_daddress.Name = "cn_daddress";
            this.cn_daddress.Width = 125;
            // 
            // cn_custarticle
            // 
            this.cn_custarticle.DataPropertyName = "custarticle";
            this.cn_custarticle.HeaderText = "Cust. article";
            this.cn_custarticle.Name = "cn_custarticle";
            // 
            // cn_dcomments
            // 
            this.cn_dcomments.DataPropertyName = "comments";
            this.cn_dcomments.FillWeight = 170F;
            this.cn_dcomments.HeaderText = "Comments";
            this.cn_dcomments.Name = "cn_dcomments";
            this.cn_dcomments.Width = 170;
            // 
            // cn_dcoid
            // 
            this.cn_dcoid.DataPropertyName = "coid";
            this.cn_dcoid.FillWeight = 80F;
            this.cn_dcoid.HeaderText = "coid";
            this.cn_dcoid.Name = "cn_dcoid";
            this.cn_dcoid.ReadOnly = true;
            this.cn_dcoid.Visible = false;
            this.cn_dcoid.Width = 80;
            // 
            // cn_did
            // 
            this.cn_did.DataPropertyName = "id";
            this.cn_did.FillWeight = 5F;
            this.cn_did.HeaderText = "id";
            this.cn_did.Name = "cn_did";
            this.cn_did.ReadOnly = true;
            this.cn_did.Visible = false;
            this.cn_did.Width = 5;
            // 
            // frm_AddArticleForDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 419);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddArticleForDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add confirmation order for delivery";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Delivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Delivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private System.Windows.Forms.BindingSource bs_Delivery;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Delivery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ostate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_confdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ddelivplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_daddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_did;
    }
}