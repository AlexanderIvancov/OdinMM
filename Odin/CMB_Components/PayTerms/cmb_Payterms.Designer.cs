namespace Odin.CMB_Components.PayTerms
{
    partial class cmb_Payterms
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_Payterm = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_Payterm);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(199, 20);
            this.kryptonPanel1.TabIndex = 12;
            // 
            // txt_Payterm
            // 
            this.txt_Payterm.AllowButtonSpecToolTips = true;
            this.txt_Payterm.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Payterm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Payterm.Location = new System.Drawing.Point(0, 0);
            this.txt_Payterm.Name = "txt_Payterm";
            this.txt_Payterm.Size = new System.Drawing.Size(199, 20);
            this.txt_Payterm.TabIndex = 1;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(199, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 20);
            this.btn_AdvView.TabIndex = 11;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // cmb_Payterms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_AdvView);
            this.Name = "cmb_Payterms";
            this.Size = new System.Drawing.Size(224, 20);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Payterm;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
    }
}
