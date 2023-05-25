namespace Odin.Warehouse.Shelves
{
    partial class frm_StockShelves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockShelves));
            this.ctl_StockShelves1 = new Odin.Warehouse.Shelves.ctl_StockShelves();
            this.SuspendLayout();
            // 
            // ctl_StockShelves1
            // 
            this.ctl_StockShelves1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_StockShelves1.Location = new System.Drawing.Point(0, 0);
            this.ctl_StockShelves1.Name = "ctl_StockShelves1";
            this.ctl_StockShelves1.NodeId = 0;
            this.ctl_StockShelves1.PlaceAddressId = 0;
            this.ctl_StockShelves1.PlaceCreatedAt = "";
            this.ctl_StockShelves1.PlaceCreatedBy = "";
            this.ctl_StockShelves1.PlaceDeptId = 0;
            this.ctl_StockShelves1.PlaceDescription = "";
            this.ctl_StockShelves1.PlaceFirmId = 0;
            this.ctl_StockShelves1.PlaceId = 0;
            this.ctl_StockShelves1.PlaceIsProduction = 0;
            this.ctl_StockShelves1.PlaceName = null;
            this.ctl_StockShelves1.PlaceParentId = 0;
            this.ctl_StockShelves1.PlaceRespPersonId = 0;
            this.ctl_StockShelves1.SelectedNode = null;
            this.ctl_StockShelves1.SelectedNodePath = null;
            this.ctl_StockShelves1.SelectedNodeText = null;
            this.ctl_StockShelves1.Size = new System.Drawing.Size(451, 372);
            this.ctl_StockShelves1.TabIndex = 0;
            this.ctl_StockShelves1.Load += new System.EventHandler(this.ctl_StockShelves1_Load);
            // 
            // frm_StockShelves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 372);
            this.Controls.Add(this.ctl_StockShelves1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_StockShelves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock shelves";
            this.ResumeLayout(false);

        }

        #endregion

        private ctl_StockShelves ctl_StockShelves1;
    }
}