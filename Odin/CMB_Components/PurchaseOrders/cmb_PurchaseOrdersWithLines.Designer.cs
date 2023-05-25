namespace Odin.CMB_Components.PurchaseOrders
{
    partial class cmb_PurchaseOrdersWithLines
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
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_Lines = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_PurchaseOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Lines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Lines
            // 
            this.cmb_Lines.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmb_Lines.DropDownWidth = 27;
            this.cmb_Lines.Location = new System.Drawing.Point(164, 0);
            this.cmb_Lines.Name = "cmb_Lines";
            this.cmb_Lines.Size = new System.Drawing.Size(44, 21);
            this.cmb_Lines.TabIndex = 1;
            this.cmb_Lines.SelectedValueChanged += new System.EventHandler(this.cmb_Lines_SelectedValueChanged);
            this.cmb_Lines.Click += new System.EventHandler(this.cmb_Lines_Click);
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(139, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 21);
            this.btn_AdvView.TabIndex = 14;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            this.btn_AdvView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AdvView_KeyDown);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_PurchaseOrder);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(139, 21);
            this.kryptonPanel1.TabIndex = 15;
            // 
            // txt_PurchaseOrder
            // 
            this.txt_PurchaseOrder.AllowButtonSpecToolTips = true;
            this.txt_PurchaseOrder.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_PurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PurchaseOrder.Location = new System.Drawing.Point(0, 0);
            this.txt_PurchaseOrder.Name = "txt_PurchaseOrder";
            this.txt_PurchaseOrder.Size = new System.Drawing.Size(139, 20);
            this.txt_PurchaseOrder.TabIndex = 1;
            this.txt_PurchaseOrder.TextChanged += new System.EventHandler(this.txt_PurchaseOrder_TextChanged);
            this.txt_PurchaseOrder.Click += new System.EventHandler(this.txt_PurchaseOrder_Click);
            this.txt_PurchaseOrder.Enter += new System.EventHandler(this.txt_PurchaseOrder_Enter);
            this.txt_PurchaseOrder.Leave += new System.EventHandler(this.txt_PurchaseOrder_Leave);
            this.txt_PurchaseOrder.Validated += new System.EventHandler(this.txt_PurchaseOrder_Validated);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // cmb_PurchaseOrdersWithLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_AdvView);
            this.Controls.Add(this.cmb_Lines);
            this.Name = "cmb_PurchaseOrdersWithLines";
            this.Size = new System.Drawing.Size(208, 21);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Lines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_Lines;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_PurchaseOrder;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}
