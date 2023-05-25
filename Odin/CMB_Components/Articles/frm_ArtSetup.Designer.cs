namespace Odin.CMB_Components.Articles
{
    partial class frm_ArtSetup
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
            this.ctl_BOMSetup1 = new Odin.Register.Articles.ctl_BOMSetup();
            this.SuspendLayout();
            // 
            // ctl_BOMSetup1
            // 
            this.ctl_BOMSetup1.ArtId = 0;
            this.ctl_BOMSetup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_BOMSetup1.Location = new System.Drawing.Point(0, 0);
            this.ctl_BOMSetup1.Lock = 0;
            this.ctl_BOMSetup1.Name = "ctl_BOMSetup1";
            this.ctl_BOMSetup1.Size = new System.Drawing.Size(830, 350);
            this.ctl_BOMSetup1.TabIndex = 0;
            // 
            // frm_ArtSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 350);
            this.Controls.Add(this.ctl_BOMSetup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_ArtSetup";
            this.Text = "Article setup";
            this.ResumeLayout(false);

        }

        #endregion

        public Register.Articles.ctl_BOMSetup ctl_BOMSetup1;
    }
}