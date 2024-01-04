namespace Odin.CMB_Components.SalesOrders
{
    partial class cmb_SalesOrdersWithLines
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
            this.cmb_Lines = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_SalesOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Lines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Lines
            // 
            this.cmb_Lines.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmb_Lines.DropDownWidth = 27;
            this.cmb_Lines.Location = new System.Drawing.Point(166, 0);
            this.cmb_Lines.Name = "cmb_Lines";
            this.cmb_Lines.Size = new System.Drawing.Size(44, 21);
            this.cmb_Lines.TabIndex = 0;
            this.cmb_Lines.SelectedValueChanged += new System.EventHandler(this.cmb_Lines_SelectedValueChanged);
            this.cmb_Lines.Click += new System.EventHandler(this.cmb_Lines_Click);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_SalesOrder);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(141, 21);
            this.kryptonPanel1.TabIndex = 14;
            // 
            // txt_SalesOrder
            // 
            this.txt_SalesOrder.AllowButtonSpecToolTips = true;
            this.txt_SalesOrder.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_SalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SalesOrder.Location = new System.Drawing.Point(0, 0);
            this.txt_SalesOrder.Name = "txt_SalesOrder";
            this.txt_SalesOrder.Size = new System.Drawing.Size(141, 20);
            this.txt_SalesOrder.TabIndex = 1;
            this.txt_SalesOrder.TextChanged += new System.EventHandler(this.txt_SalesOrder_TextChanged);
            this.txt_SalesOrder.Enter += new System.EventHandler(this.txt_SalesOrder_Enter);
            this.txt_SalesOrder.Leave += new System.EventHandler(this.txt_SalesOrder_Leave);
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(141, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 21);
            this.btn_AdvView.TabIndex = 13;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // cmb_SalesOrdersWithLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_AdvView);
            this.Controls.Add(this.cmb_Lines);
            this.Name = "cmb_SalesOrdersWithLines";
            this.Size = new System.Drawing.Size(210, 21);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Lines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_Lines;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_SalesOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
        private System.Windows.Forms.BindingSource bs_List;
    }
}
