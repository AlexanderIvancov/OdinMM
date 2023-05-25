namespace Odin.Purchase
{
    partial class frm_AddPODets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddPODets));
            this.ctl_PODets1 = new Odin.Purchase.ctl_PODets();
            this.SuspendLayout();
            // 
            // ctl_PODets1
            // 
            this.ctl_PODets1.ArtComments = "";
            this.ctl_PODets1.ArtFromNeeds = 0;
            this.ctl_PODets1.Article1 = "";
            this.ctl_PODets1.ArtId = 0;
            this.ctl_PODets1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctl_PODets1.CatId = 0;
            this.ctl_PODets1.CoefConv = 1D;
            this.ctl_PODets1.Comments = "";
            this.ctl_PODets1.CurId = 0;
            this.ctl_PODets1.DBUnitId = 0;
            this.ctl_PODets1.DiscFix = 0D;
            this.ctl_PODets1.Discount = 0D;
            this.ctl_PODets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_PODets1.HeaderText = "";
            this.ctl_PODets1.HeadId = 0;
            this.ctl_PODets1.HeadId1 = 0;
            this.ctl_PODets1.Id = 0;
            this.ctl_PODets1.InternalComments = "";
            this.ctl_PODets1.IsCopy = false;
            this.ctl_PODets1.Line = 0;
            this.ctl_PODets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_PODets1.MinExpDate = "";
            this.ctl_PODets1.MissedQty = 0D;
            this.ctl_PODets1.MOQ = 0D;
            this.ctl_PODets1.MPQ = 0D;
            this.ctl_PODets1.Multiplicity = 1D;
            this.ctl_PODets1.Name = "ctl_PODets1";
            this.ctl_PODets1.NeedsInPO = 0D;
            this.ctl_PODets1.POId = 0;
            this.ctl_PODets1.POLineId = 0;
            this.ctl_PODets1.PrevArtId = 0;
            this.ctl_PODets1.PriceWVat = 0D;
            this.ctl_PODets1.PrimSup = 0;
            this.ctl_PODets1.ProjectId = 0;
            this.ctl_PODets1.Qty = 0D;
            this.ctl_PODets1.ReqDate = "18.05.2018";
            this.ctl_PODets1.Resale = 0;
            this.ctl_PODets1.senderQty = 0;
            this.ctl_PODets1.senderUnit = 0;
            this.ctl_PODets1.Size = new System.Drawing.Size(624, 461);
            this.ctl_PODets1.StateId = 0;
            this.ctl_PODets1.SupArticle = "";
            this.ctl_PODets1.SupId = 0;
            this.ctl_PODets1.SuppliersOrder = "";
            this.ctl_PODets1.TabIndex = 0;
            this.ctl_PODets1.Total = 0D;
            this.ctl_PODets1.TotalVAT = 0D;
            this.ctl_PODets1.TotalWVAT = 0D;
            this.ctl_PODets1.UnitFNPrice = 0D;
            this.ctl_PODets1.UnitId = 0;
            this.ctl_PODets1.UnitPrice = 0D;
            this.ctl_PODets1.UnitPriceBeg = 0D;
            this.ctl_PODets1.Vat = 0D;
            this.ctl_PODets1.SendPOId += new Odin.Purchase.POIdSendingEventHandler(this.ctl_PODets1_SendPOId);
            // 
            // frm_AddPODets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.ctl_PODets1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddPODets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add purchase order line";
            this.ResumeLayout(false);

        }

        #endregion

        public ctl_PODets ctl_PODets1;
    }
}