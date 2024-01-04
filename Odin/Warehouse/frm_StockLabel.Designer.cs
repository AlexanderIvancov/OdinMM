namespace Odin.Warehouse
{
    partial class frm_StockLabel
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
            this.ctl_StockLabel1 = new Odin.Warehouse.Inventory.ctl_StockLabel();
            this.SuspendLayout();
            // 
            // ctl_StockLabel1
            // 
            this.ctl_StockLabel1.Article = "";
            this.ctl_StockLabel1.ArtId = 0;
            this.ctl_StockLabel1.Available = 0;
            this.ctl_StockLabel1.Comments = "";
            this.ctl_StockLabel1.DataCode = "";
            this.ctl_StockLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_StockLabel1.ExpDate = "07.03.2019 20:36:57";
            this.ctl_StockLabel1.Label = 0;
            this.ctl_StockLabel1.Location = new System.Drawing.Point(0, 0);
            this.ctl_StockLabel1.Name = "ctl_StockLabel1";
            this.ctl_StockLabel1.ParentLabel = 0;
            this.ctl_StockLabel1.PlaceId = 0;
            this.ctl_StockLabel1.Qty = 0D;
            this.ctl_StockLabel1.Size = new System.Drawing.Size(623, 383);
            this.ctl_StockLabel1.TabIndex = 0;
            this.ctl_StockLabel1.UnitId = 0;
            // 
            // frm_StockLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 383);
            this.Controls.Add(this.ctl_StockLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StockLabel";
            this.Text = "frm_StockLabel";
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        public Inventory.ctl_StockLabel ctl_StockLabel1;
    }
}