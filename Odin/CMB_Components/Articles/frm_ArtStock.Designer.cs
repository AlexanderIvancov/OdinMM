namespace Odin.CMB_Components.Articles
{
    partial class frm_ArtStock
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
            this.ctl_ArtTotals1 = new Odin.Planning.Controls.ctl_ArtTotals();
            this.SuspendLayout();
            // 
            // ctl_ArtTotals1
            // 
            this.ctl_ArtTotals1.ArtId = 0;
            this.ctl_ArtTotals1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_ArtTotals1.HeaderText = "Total for:";
            this.ctl_ArtTotals1.Location = new System.Drawing.Point(0, 0);
            this.ctl_ArtTotals1.Name = "ctl_ArtTotals1";
            this.ctl_ArtTotals1.QtyAvailable = 0D;
            this.ctl_ArtTotals1.QtyAwaiting = 0D;
            this.ctl_ArtTotals1.QtyFreePO = 0D;
            this.ctl_ArtTotals1.QtyInProduction = 0D;
            this.ctl_ArtTotals1.QtyNeeds = 0D;
            this.ctl_ArtTotals1.QtyNeedsCO = 0D;
            this.ctl_ArtTotals1.QtyNotPlaced = 0D;
            this.ctl_ArtTotals1.QtyPurchased = 0D;
            this.ctl_ArtTotals1.QtyReserved = 0D;
            this.ctl_ArtTotals1.QtyStock = 0D;
            this.ctl_ArtTotals1.Size = new System.Drawing.Size(279, 414);
            this.ctl_ArtTotals1.TabIndex = 0;
            this.ctl_ArtTotals1.Unit = "";
            // 
            // frm_ArtStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 414);
            this.Controls.Add(this.ctl_ArtTotals1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ArtStock";
            this.Text = "frm_ArtStock";
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        public Planning.Controls.ctl_ArtTotals ctl_ArtTotals1;
    }
}