namespace Odin.Planning
{
    partial class frm_AddLaunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddLaunch));
            this.ctl_CreatLaunchDets1 = new Odin.Planning.Controls.ctl_CreatLaunchDets();
            this.SuspendLayout();
            // 
            // ctl_CreatLaunchDets1
            // 
            this.ctl_CreatLaunchDets1.ArtId = 0;
            this.ctl_CreatLaunchDets1.BatchId = 0;
            this.ctl_CreatLaunchDets1.Comments = "";
            this.ctl_CreatLaunchDets1.Customer = "";
            this.ctl_CreatLaunchDets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_CreatLaunchDets1.Id = 0;
            this.ctl_CreatLaunchDets1.Launch = "";
            this.ctl_CreatLaunchDets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_CreatLaunchDets1.Mode = "new";
            this.ctl_CreatLaunchDets1.Name = "ctl_CreatLaunchDets1";
            this.ctl_CreatLaunchDets1.QtyCanBeLaunched = 0D;
            this.ctl_CreatLaunchDets1.QtyInLaunch = 0D;
            this.ctl_CreatLaunchDets1.QtyNotLaunched = 0D;
            this.ctl_CreatLaunchDets1.SalesOrderId = 0;
            this.ctl_CreatLaunchDets1.Size = new System.Drawing.Size(1191, 619);
            this.ctl_CreatLaunchDets1.StageId = 0;
            this.ctl_CreatLaunchDets1.TabIndex = 0;
            this.ctl_CreatLaunchDets1.SaveLaunch += new Odin.Planning.Controls.SaveLaunchEventHandler(this.ctl_CreatLaunchDets1_SaveLaunch);
            // 
            // frm_AddLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 619);
            this.Controls.Add(this.ctl_CreatLaunchDets1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddLaunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add launch";
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.ctl_CreatLaunchDets ctl_CreatLaunchDets1;
    }
}