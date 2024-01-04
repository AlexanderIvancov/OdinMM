namespace Odin.CMB_Components.Week
{
    partial class cmb_Week
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
            this.txt_Week = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.btn_Previous = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Next = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.SuspendLayout();
            // 
            // txt_Week
            // 
            this.txt_Week.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Previous,
            this.btn_Next});
            this.txt_Week.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Week.Location = new System.Drawing.Point(0, 0);
            this.txt_Week.Mask = "W00.0000";
            this.txt_Week.Name = "txt_Week";
            this.txt_Week.Size = new System.Drawing.Size(100, 20);
            this.txt_Week.TabIndex = 0;
            this.txt_Week.Text = "W  .";
            this.txt_Week.TextChanged += new System.EventHandler(this.txt_Week_TextChanged);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Previous;
            this.btn_Previous.UniqueName = "4219CA1A4E87457F7D91F03FB60D603B";
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Next;
            this.btn_Next.UniqueName = "78BE0BE8647E438FB2A15A8311F0DCE5";
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // cmb_Week
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Week);
            this.Name = "cmb_Week";
            this.Size = new System.Drawing.Size(100, 20);
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txt_Week;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Previous;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Next;
    }
}
