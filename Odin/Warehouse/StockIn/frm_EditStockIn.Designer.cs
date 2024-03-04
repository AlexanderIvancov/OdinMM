namespace Odin.Warehouse.StockIn
{
    partial class frm_EditStockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditStockIn));
            this.ctl_StockInEdit1 = new Odin.Warehouse.StockIn.ctl_StockInEdit();
            this.SuspendLayout();
            // 
            // ctl_StockInEdit1
            // 
            this.ctl_StockInEdit1.Article = "";
            this.ctl_StockInEdit1.ArtId = 0;
            this.ctl_StockInEdit1.ArtUnitId = 0;
            this.ctl_StockInEdit1.BatchId = 0;
            this.ctl_StockInEdit1.CoefConv = 0D;
            this.ctl_StockInEdit1.Comments = "";
            this.ctl_StockInEdit1.CustCodeId = 0;
            this.ctl_StockInEdit1.Discount = 0D;
            this.ctl_StockInEdit1.Dutycost = 0D;
            this.ctl_StockInEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_StockInEdit1.Id = 0;
            this.ctl_StockInEdit1.IncomeDocId = 0;
            this.ctl_StockInEdit1.Location = new System.Drawing.Point(0, 0);
            this.ctl_StockInEdit1.Multiplicity = 1D;
            this.ctl_StockInEdit1.Name = "ctl_StockInEdit1";
            this.ctl_StockInEdit1.PriceWVat = 0D;
            this.ctl_StockInEdit1.Qty = 0D;
            this.ctl_StockInEdit1.Size = new System.Drawing.Size(642, 275);
            this.ctl_StockInEdit1.State = 0;
            this.ctl_StockInEdit1.StockMoveTypeId = 1;
            this.ctl_StockInEdit1.SupArticle = "";
            this.ctl_StockInEdit1.TabIndex = 0;
            this.ctl_StockInEdit1.TempQty = 0D;
            this.ctl_StockInEdit1.Total = 0D;
            this.ctl_StockInEdit1.TotalVAT = 0D;
            this.ctl_StockInEdit1.TotalWVAT = 0D;
            this.ctl_StockInEdit1.UnitId = 0;
            this.ctl_StockInEdit1.UnitPrice = 0D;
            this.ctl_StockInEdit1.Vat = 0D;
            this.ctl_StockInEdit1.WasMovement = 0;
            this.ctl_StockInEdit1.Weight = 0D;
            this.ctl_StockInEdit1.EditSendStockInId += new Odin.Warehouse.StockIn.EditStockInIdSendingEventHandler(this.ctl_StockInEdit1_EditSendStockInId);
            // 
            // frm_EditStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 275);
            this.Controls.Add(this.ctl_StockInEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit stock in";
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        public ctl_StockInEdit ctl_StockInEdit1;
    }
}