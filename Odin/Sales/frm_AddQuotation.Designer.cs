namespace Odin.Sales
{
    partial class frm_AddQuotation
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
            this.ctl_QuotDets1 = new Odin.Sales.ctl_QuotDets();
            this.SuspendLayout();
            // 
            // ctl_QuotDets1
            // 
            this.ctl_QuotDets1.ArtId = 0;
            this.ctl_QuotDets1.Blocked = 0;
            this.ctl_QuotDets1.CheckRMQP = 0;
            this.ctl_QuotDets1.Comments = "";
            this.ctl_QuotDets1.CreatAt = "";
            this.ctl_QuotDets1.CreatBy = "";
            this.ctl_QuotDets1.CurId = 0;
            this.ctl_QuotDets1.CustArticle = "";
            this.ctl_QuotDets1.CustId = 0;
            this.ctl_QuotDets1.CustLine = "";
            this.ctl_QuotDets1.CustOrder = "";
            this.ctl_QuotDets1.DelivAddressId = 0;
            this.ctl_QuotDets1.DelivPlaceId = 0;
            this.ctl_QuotDets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_QuotDets1.EndCustomerId = 0;
            this.ctl_QuotDets1.ExpDate = "";
            this.ctl_QuotDets1.ExpDateD = new System.DateTime(((long)(0)));
            this.ctl_QuotDets1.Internal = 0;
            this.ctl_QuotDets1.IsCopy = 0;
            this.ctl_QuotDets1.IsProject = 0;
            this.ctl_QuotDets1.IsSent = 0;
            this.ctl_QuotDets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_QuotDets1.Name = "ctl_QuotDets1";
            this.ctl_QuotDets1.NotPaidAdvance = 0;
            this.ctl_QuotDets1.PCB = 1;
            this.ctl_QuotDets1.Primary = 0;
            this.ctl_QuotDets1.Qty = 0D;
            this.ctl_QuotDets1.Quotation = "";
            this.ctl_QuotDets1.QuotId = 0;
            this.ctl_QuotDets1.ReqDate = "05.09.2019";
            this.ctl_QuotDets1.ReqDateD = new System.DateTime(2019, 9, 5, 14, 23, 24, 595);
            this.ctl_QuotDets1.Resale = 0;
            this.ctl_QuotDets1.Revision = "";
            this.ctl_QuotDets1.SentDate = "05.09.2019 14:23:24 ";
            this.ctl_QuotDets1.SentDateD = new System.DateTime(2019, 9, 5, 14, 23, 24, 573);
            this.ctl_QuotDets1.Size = new System.Drawing.Size(548, 469);
            this.ctl_QuotDets1.Spoilage = 0D;
            this.ctl_QuotDets1.StateId = 0;
            this.ctl_QuotDets1.TabIndex = 0;
            this.ctl_QuotDets1.UnitId = 0;
            this.ctl_QuotDets1.UnitPrice = 0D;
            this.ctl_QuotDets1.ValidBOM = 0;
            this.ctl_QuotDets1.Week = "W  .";
            this.ctl_QuotDets1.SendQuotId += new Odin.Sales.QuotIdSendingEventHandler(this.ctl_QuotDets1_SendQuotId);
            // 
            // frm_AddQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(548, 469);
            this.Controls.Add(this.ctl_QuotDets1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_AddQuotation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add quotation";
            this.ResumeLayout(false);

        }

        #endregion

        public ctl_QuotDets ctl_QuotDets1;
    }
}