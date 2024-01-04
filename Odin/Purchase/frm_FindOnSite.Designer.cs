namespace Odin.Purchase
{
    partial class frm_FindOnSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FindOnSite));
            this.ctl_FindOnSite1 = new Odin.Purchase.ctl_FindOnSite();
            this.SuspendLayout();
            // 
            // ctl_FindOnSite1
            // 
            this.ctl_FindOnSite1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_FindOnSite1.Location = new System.Drawing.Point(0, 0);
            this.ctl_FindOnSite1.Name = "ctl_FindOnSite1";
            this.ctl_FindOnSite1.Size = new System.Drawing.Size(627, 362);
            this.ctl_FindOnSite1.TabIndex = 0;
            // 
            // frm_FindOnSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 362);
            this.Controls.Add(this.ctl_FindOnSite1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_FindOnSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find on vendor\'s site";
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        public ctl_FindOnSite ctl_FindOnSite1;
    }
}