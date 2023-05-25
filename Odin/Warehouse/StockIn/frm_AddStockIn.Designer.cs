namespace Odin.Warehouse.StockIn
{
    partial class frm_AddStockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddStockIn));
            this.ctl_StockInDets1 = new Odin.Warehouse.StockIn.ctl_StockInDets();
            this.SuspendLayout();
            // 
            // ctl_StockInDets1
            // 
            this.ctl_StockInDets1.Article = "";
            this.ctl_StockInDets1.ArtId = 0;
            this.ctl_StockInDets1.ArtUnit = "";
            this.ctl_StockInDets1.CoefConv = 0D;
            this.ctl_StockInDets1.Comments = "";
            this.ctl_StockInDets1.Discount = 0D;
            this.ctl_StockInDets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_StockInDets1.ExpDate = "";
            this.ctl_StockInDets1.IsCopy = false;
            this.ctl_StockInDets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_StockInDets1.Multiplicity = 0D;
            this.ctl_StockInDets1.Name = "ctl_StockInDets1";
            this.ctl_StockInDets1.PriceWVat = 0D;
            this.ctl_StockInDets1.Qty = 0D;
            this.ctl_StockInDets1.QtyAfter = 0D;
            this.ctl_StockInDets1.QtyBefore = 0D;
            this.ctl_StockInDets1.QtyInOrder = 0D;
            this.ctl_StockInDets1.QtyPlaced = 0D;
            this.ctl_StockInDets1.QtyToPlace = 0D;
            this.ctl_StockInDets1.Size = new System.Drawing.Size(646, 562);
            this.ctl_StockInDets1.StockInId = 0;
            this.ctl_StockInDets1.SupArticle = "";
            this.ctl_StockInDets1.TabIndex = 0;
            this.ctl_StockInDets1.TempQty = 0D;
            this.ctl_StockInDets1.Total = 0D;
            this.ctl_StockInDets1.TotalVAT = 0D;
            this.ctl_StockInDets1.TotalWVAT = 0D;
            this.ctl_StockInDets1.UnitId = 0;
            this.ctl_StockInDets1.UnitPrice = 0D;
            this.ctl_StockInDets1.UnitPriceInOrder = 0D;
            this.ctl_StockInDets1.Vat = 0D;
            this.ctl_StockInDets1.SendStockInId += new Odin.Warehouse.StockIn.StockInIdSendingEventHandler(this.ctl_StockInDets1_SendStockInId);
            // 
            // frm_AddStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 562);
            this.Controls.Add(this.ctl_StockInDets1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add stock income line";
            this.ResumeLayout(false);

        }

        #endregion

        public ctl_StockInDets ctl_StockInDets1;
    }
}