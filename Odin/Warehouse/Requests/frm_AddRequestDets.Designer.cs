namespace Odin.Warehouse.Requests
{
    partial class frm_AddRequestDets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddRequestDets));
            this.ctl_CreatReqDets1 = new Odin.Warehouse.Requests.Controls.ctl_CreatReqDets();
            this.SuspendLayout();
            // 
            // ctl_CreatReqDets1
            // 
            this.ctl_CreatReqDets1.ArticleId = 0;
            this.ctl_CreatReqDets1.BatchId = 0;
            this.ctl_CreatReqDets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_CreatReqDets1.HeadId = 0;
            this.ctl_CreatReqDets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_CreatReqDets1.Mode = 0;
            this.ctl_CreatReqDets1.Name = "ctl_CreatReqDets1";
            this.ctl_CreatReqDets1.Product = "";
            this.ctl_CreatReqDets1.QtyInBatch = 0D;
            this.ctl_CreatReqDets1.ReqDate = "28/08/2018";
            this.ctl_CreatReqDets1.ReqDateD = new System.DateTime(2018, 8, 28, 0, 0, 0, 0);
            this.ctl_CreatReqDets1.SecName = "";
            this.ctl_CreatReqDets1.Size = new System.Drawing.Size(956, 413);
            this.ctl_CreatReqDets1.TabIndex = 0;
            this.ctl_CreatReqDets1.SaveRequest += new Odin.Warehouse.Requests.Controls.SaveRequestDEventHandler(this.ctl_CreatReqDets1_SaveRequest);
            // 
            // frm_AddRequestDets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 413);
            this.Controls.Add(this.ctl_CreatReqDets1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddRequestDets";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add request details";
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.ctl_CreatReqDets ctl_CreatReqDets1;
    }
}