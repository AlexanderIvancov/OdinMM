namespace Odin.Sales
{
    partial class frm_AddCODet
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ctl_CODets1 = new Odin.Sales.ctl_CODets();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 443);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(548, 59);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(448, 13);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(349, 13);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 34);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // ctl_CODets1
            // 
            this.ctl_CODets1.COArtId = 0;
            this.ctl_CODets1.COBlocked = 0;
            this.ctl_CODets1.COComments = "";
            this.ctl_CODets1.COComments1 = "";
            this.ctl_CODets1.COContract = "";
            this.ctl_CODets1.COCreatAt = "";
            this.ctl_CODets1.COCreatBy = "";
            this.ctl_CODets1.COCustArticle = "";
            this.ctl_CODets1.COCustLine = "";
            this.ctl_CODets1.COCustOrder = "";
            this.ctl_CODets1.CODelivAddressId = 0;
            this.ctl_CODets1.CODelivPlaceId = 0;
            this.ctl_CODets1.COEndCustId = 0;
            this.ctl_CODets1.COEndCustRef = "";
            this.ctl_CODets1.COEndCustReqDate = "";
            this.ctl_CODets1.COHeadId = 0;
            this.ctl_CODets1.COId = 0;
            this.ctl_CODets1.COInternal = 0;
            this.ctl_CODets1.COLine = 0;
            this.ctl_CODets1.COLogComments = "";
            this.ctl_CODets1.COPrimary = 0;
            this.ctl_CODets1.COPurLine = null;
            this.ctl_CODets1.COPurOrder = null;
            this.ctl_CODets1.COQty = 0D;
            this.ctl_CODets1.COQtyInBatch = 0D;
            this.ctl_CODets1.COReqDate = "12.01.2022";
            this.ctl_CODets1.COResale = 0;
            this.ctl_CODets1.COSalesComments = "";
            this.ctl_CODets1.COService = 0;
            this.ctl_CODets1.COSpoilage = 0D;
            this.ctl_CODets1.COStateId = 0;
            this.ctl_CODets1.COUnitId = 0;
            this.ctl_CODets1.COUnitPrice = 0D;
            this.ctl_CODets1.COVat = 0D;
            this.ctl_CODets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_CODets1.EndCustOrder = null;
            this.ctl_CODets1.IsCopy = 0;
            this.ctl_CODets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_CODets1.Name = "ctl_CODets1";
            this.ctl_CODets1.Size = new System.Drawing.Size(548, 443);
            this.ctl_CODets1.TabIndex = 2;
            // 
            // frm_AddCODet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 502);
            this.Controls.Add(this.ctl_CODets1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_AddCODet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add CO line";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        public ctl_CODets ctl_CODets1;
    }
}