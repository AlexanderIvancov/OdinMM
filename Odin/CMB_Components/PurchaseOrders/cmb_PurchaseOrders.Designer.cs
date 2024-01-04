namespace Odin.CMB_Components.PurchaseOrders
{
    partial class cmb_PurchaseOrders
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
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_AddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_PurchaseOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(150, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 20);
            this.btn_AdvView.TabIndex = 13;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AddNew.Location = new System.Drawing.Point(100, 0);
            this.btn_AddNew.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(25, 20);
            this.btn_AddNew.TabIndex = 15;
            this.btn_AddNew.Values.Image = global::Odin.Global_Resourses.bindingNavigatorAddNewItem_Image;
            this.btn_AddNew.Values.Text = "";
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_PurchaseOrder);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(100, 20);
            this.kryptonPanel1.TabIndex = 16;
            // 
            // txt_PurchaseOrder
            // 
            this.txt_PurchaseOrder.AllowButtonSpecToolTips = true;
            this.txt_PurchaseOrder.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_PurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PurchaseOrder.Location = new System.Drawing.Point(0, 0);
            this.txt_PurchaseOrder.Name = "txt_PurchaseOrder";
            this.txt_PurchaseOrder.Size = new System.Drawing.Size(100, 20);
            this.txt_PurchaseOrder.TabIndex = 1;
            this.txt_PurchaseOrder.TextChanged += new System.EventHandler(this.txt_PurchaseOrder_TextChanged);
            this.txt_PurchaseOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PurchaseOrder_KeyPress);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Edit.Location = new System.Drawing.Point(125, 0);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(25, 20);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Values.Image = global::Odin.Global_Resourses.EditTableHS;
            this.btn_Edit.Values.Text = "";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // cmb_PurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AdvView);
            this.Name = "cmb_PurchaseOrders";
            this.Size = new System.Drawing.Size(175, 20);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddNew;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_PurchaseOrder;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Edit;
    }
}
