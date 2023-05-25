namespace Odin.Warehouse.Deliveries
{
    partial class frm_EditDelivDets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditDelivDets));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Delivery = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.chk_Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_dconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_confdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_Return = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyPack = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_CustCodes1 = new Odin.CMB_Components.CustCodes.cmb_CustCodes();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_BrutWeight = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CustArticle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_NetWeight = new Owf.Controls.NumericTetxBox();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bs_Delivery = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Delivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Delivery)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonHeaderGroup1);
            this.kryptonPanel1.Controls.Add(this.chk_Return);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.cmb_Common1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.txt_QtyPack);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.cmb_CustCodes1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.txt_Comments);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txt_BrutWeight);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.txt_CustArticle);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.txt_NetWeight);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(399, 371);
            this.kryptonPanel1.TabIndex = 30;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 211);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_Delivery);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(399, 160);
            this.kryptonHeaderGroup1.TabIndex = 293;
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
            this.cn_dclient,
            this.cn_confdate,
            this.cn_dqty,
            this.cn_dunit,
            this.cn_custarticle,
            this.cn_dcoid});
            this.gv_Delivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Delivery.Location = new System.Drawing.Point(0, 0);
            this.gv_Delivery.Name = "gv_Delivery";
            this.gv_Delivery.RowHeadersWidth = 25;
            this.gv_Delivery.Size = new System.Drawing.Size(397, 131);
            this.gv_Delivery.TabIndex = 6;
            this.gv_Delivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Delivery_CellContentClick);
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
            this.cn_dqty.Visible = false;
            this.cn_dqty.Width = 90;
            // 
            // cn_dunit
            // 
            this.cn_dunit.DataPropertyName = "unit";
            this.cn_dunit.FillWeight = 40F;
            this.cn_dunit.HeaderText = "Unit";
            this.cn_dunit.Name = "cn_dunit";
            this.cn_dunit.ReadOnly = true;
            this.cn_dunit.Visible = false;
            this.cn_dunit.Width = 40;
            // 
            // cn_custarticle
            // 
            this.cn_custarticle.DataPropertyName = "custarticle";
            this.cn_custarticle.HeaderText = "Cust. article";
            this.cn_custarticle.Name = "cn_custarticle";
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
            // chk_Return
            // 
            this.chk_Return.Location = new System.Drawing.Point(118, 71);
            this.chk_Return.Name = "chk_Return";
            this.chk_Return.Size = new System.Drawing.Size(60, 20);
            this.chk_Return.TabIndex = 292;
            this.chk_Return.Values.Text = "Return";
            this.chk_Return.Visible = false;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(146, 40);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel11.TabIndex = 291;
            this.kryptonLabel11.Values.Text = "Package:";
            this.kryptonLabel11.Visible = false;
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.Location = new System.Drawing.Point(210, 40);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "name";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(68, 20);
            this.cmb_Common1.sTable = "BAS_Package";
            this.cmb_Common1.sText_Filled = "name";
            this.cmb_Common1.sTitle = "Package type";
            this.cmb_Common1.TabIndex = 290;
            this.cmb_Common1.Visible = false;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 40);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel6.TabIndex = 40;
            this.kryptonLabel6.Values.Text = "Qty of boxes:";
            this.kryptonLabel6.Visible = false;
            // 
            // txt_QtyPack
            // 
            this.txt_QtyPack.AllowDecimalSeparator = true;
            this.txt_QtyPack.AllowSpace = false;
            this.txt_QtyPack.Location = new System.Drawing.Point(118, 39);
            this.txt_QtyPack.Name = "txt_QtyPack";
            this.txt_QtyPack.Size = new System.Drawing.Size(22, 21);
            this.txt_QtyPack.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyPack.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_QtyPack.TabIndex = 39;
            this.txt_QtyPack.Text = "0";
            this.txt_QtyPack.Visible = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 181);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel5.TabIndex = 38;
            this.kryptonLabel5.Values.Text = "Customs code:";
            // 
            // cmb_CustCodes1
            // 
            this.cmb_CustCodes1.CustCode = "";
            this.cmb_CustCodes1.CustCodeId = 0;
            this.cmb_CustCodes1.EnableSearchId = false;
            this.cmb_CustCodes1.Location = new System.Drawing.Point(118, 181);
            this.cmb_CustCodes1.Name = "cmb_CustCodes1";
            this.cmb_CustCodes1.Size = new System.Drawing.Size(150, 20);
            this.cmb_CustCodes1.TabIndex = 37;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 123);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel3.TabIndex = 36;
            this.kryptonLabel3.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_Comments.Location = new System.Drawing.Point(118, 123);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(265, 52);
            this.txt_Comments.TabIndex = 35;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "C4D3A34557034D454F8866C7C83E9A02";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(146, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(105, 20);
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Text = "Brut weight (kgs):";
            this.kryptonLabel1.Visible = false;
            // 
            // txt_BrutWeight
            // 
            this.txt_BrutWeight.AllowDecimalSeparator = true;
            this.txt_BrutWeight.AllowSpace = false;
            this.txt_BrutWeight.Location = new System.Drawing.Point(248, 10);
            this.txt_BrutWeight.Name = "txt_BrutWeight";
            this.txt_BrutWeight.Size = new System.Drawing.Size(30, 21);
            this.txt_BrutWeight.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_BrutWeight.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_BrutWeight.TabIndex = 33;
            this.txt_BrutWeight.Text = "0";
            this.txt_BrutWeight.Visible = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 97);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel4.TabIndex = 32;
            this.kryptonLabel4.Values.Text = "Cust. article:";
            // 
            // txt_CustArticle
            // 
            this.txt_CustArticle.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_CustArticle.Location = new System.Drawing.Point(118, 97);
            this.txt_CustArticle.Name = "txt_CustArticle";
            this.txt_CustArticle.Size = new System.Drawing.Size(265, 20);
            this.txt_CustArticle.TabIndex = 31;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "C4D3A34557034D454F8866C7C83E9A02";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(103, 20);
            this.kryptonLabel2.TabIndex = 28;
            this.kryptonLabel2.Values.Text = "Net weight (kgs):";
            this.kryptonLabel2.Visible = false;
            // 
            // txt_NetWeight
            // 
            this.txt_NetWeight.AllowDecimalSeparator = true;
            this.txt_NetWeight.AllowSpace = false;
            this.txt_NetWeight.Location = new System.Drawing.Point(118, 12);
            this.txt_NetWeight.Name = "txt_NetWeight";
            this.txt_NetWeight.Size = new System.Drawing.Size(22, 21);
            this.txt_NetWeight.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_NetWeight.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_NetWeight.TabIndex = 27;
            this.txt_NetWeight.Text = "0";
            this.txt_NetWeight.Visible = false;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(293, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(293, 50);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_EditDelivDets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 371);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditDelivDets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit delivery details";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Delivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Delivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Owf.Controls.NumericTetxBox txt_BrutWeight;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustArticle;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Owf.Controls.NumericTetxBox txt_NetWeight;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Owf.Controls.NumericTetxBox txt_QtyPack;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CMB_Components.CustCodes.cmb_CustCodes cmb_CustCodes1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Return;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Delivery;
        private System.Windows.Forms.BindingSource bs_Delivery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_confdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcoid;
    }
}