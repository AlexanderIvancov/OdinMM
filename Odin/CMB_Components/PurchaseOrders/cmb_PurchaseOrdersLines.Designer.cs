namespace Odin.CMB_Components.PurchaseOrders
{
    partial class cmb_PurchaseOrdersLines
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
            this.btn_AdvViewLine = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Line = new Owf.Controls.NumericTetxBox();
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_PurchaseOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.SuspendLayout();
            // 
            // btn_AdvViewLine
            // 
            this.btn_AdvViewLine.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvViewLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvViewLine.Location = new System.Drawing.Point(185, 0);
            this.btn_AdvViewLine.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvViewLine.Name = "btn_AdvViewLine";
            this.btn_AdvViewLine.Size = new System.Drawing.Size(25, 20);
            this.btn_AdvViewLine.TabIndex = 15;
            this.btn_AdvViewLine.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvViewLine.Values.Text = "";
            this.btn_AdvViewLine.Click += new System.EventHandler(this.btn_AdvViewLine_Click);
            // 
            // txt_Line
            // 
            this.txt_Line.AllowDecimalSeparator = false;
            this.txt_Line.AllowSpace = false;
            this.txt_Line.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_Line.Location = new System.Drawing.Point(157, 0);
            this.txt_Line.Name = "txt_Line";
            this.txt_Line.Size = new System.Drawing.Size(28, 20);
            this.txt_Line.TabIndex = 16;
            this.txt_Line.Text = "0";
            this.txt_Line.TextChanged += new System.EventHandler(this.txt_Line_TextChanged);
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(132, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 20);
            this.btn_AdvView.TabIndex = 17;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // txt_PurchaseOrder
            // 
            this.txt_PurchaseOrder.AllowButtonSpecToolTips = true;
            this.txt_PurchaseOrder.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_PurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_PurchaseOrder.Location = new System.Drawing.Point(0, 0);
            this.txt_PurchaseOrder.Name = "txt_PurchaseOrder";
            this.txt_PurchaseOrder.Size = new System.Drawing.Size(132, 20);
            this.txt_PurchaseOrder.TabIndex = 18;
            this.txt_PurchaseOrder.TextChanged += new System.EventHandler(this.txt_PurchaseOrder_TextChanged);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // cmb_PurchaseOrdersLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_PurchaseOrder);
            this.Controls.Add(this.btn_AdvView);
            this.Controls.Add(this.txt_Line);
            this.Controls.Add(this.btn_AdvViewLine);
            this.Name = "cmb_PurchaseOrdersLines";
            this.Size = new System.Drawing.Size(210, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvViewLine;
        private Owf.Controls.NumericTetxBox txt_Line;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_PurchaseOrder;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}
