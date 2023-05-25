namespace Odin.Planning
{
    partial class frm_AddBatchProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddBatchProject));
            this.ctl_CreatBatchProjectDets1 = new Odin.Planning.Controls.ctl_CreatBatchProjectDets();
            this.SuspendLayout();
            // 
            // ctl_CreatBatchProjectDets2
            // 
            this.ctl_CreatBatchProjectDets1._EditMode = 0;
            this.ctl_CreatBatchProjectDets1.AllSpoil = 0;
            this.ctl_CreatBatchProjectDets1.ArticleId = 0;
            this.ctl_CreatBatchProjectDets1.Batch = "";
            this.ctl_CreatBatchProjectDets1.BatchId = 0;
            this.ctl_CreatBatchProjectDets1.Comments = "";
            this.ctl_CreatBatchProjectDets1.COrderId = 0;
            this.ctl_CreatBatchProjectDets1.Customer = "";
            this.ctl_CreatBatchProjectDets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_CreatBatchProjectDets1.fOldArticleId = 0;
            this.ctl_CreatBatchProjectDets1.fOldComments = null;
            this.ctl_CreatBatchProjectDets1.fOldEndDate = null;
            this.ctl_CreatBatchProjectDets1.fOldQtyInBatch = 0D;
            this.ctl_CreatBatchProjectDets1.fOldStartDate = null;
            this.ctl_CreatBatchProjectDets1.fOldUrgent = 0;
            this.ctl_CreatBatchProjectDets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_CreatBatchProjectDets1.Name = "ctl_CreatBatchProjectDets2";
            this.ctl_CreatBatchProjectDets1.QtyInBatch = 0D;
            this.ctl_CreatBatchProjectDets1.QtyInCO = 0D;
            this.ctl_CreatBatchProjectDets1.SalesOrderId = 0;
            this.ctl_CreatBatchProjectDets1.Size = new System.Drawing.Size(1075, 599);
            this.ctl_CreatBatchProjectDets1.TabIndex = 0;
            this.ctl_CreatBatchProjectDets1.SaveBatch += new Odin.Planning.Controls.SaveBatchProjectEventHandler(this.ctl_CreatBatchDets1_SaveBatch);
            // 
            // frm_AddBatchProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 599);
            this.Controls.Add(this.ctl_CreatBatchProjectDets1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddBatchProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add batch project";
            this.ResumeLayout(false);

        }

        #endregion
               
        public Controls.ctl_CreatBatchProjectDets ctl_CreatBatchProjectDets1;
    }
}