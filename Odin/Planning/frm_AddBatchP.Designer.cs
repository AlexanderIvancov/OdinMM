namespace Odin.Planning
{
    partial class frm_AddBatchP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddBatchP));
            this.ctl_CreatBatchDetsP1 = new Odin.Planning.Controls.ctl_CreatBatchDetsP();
            this.SuspendLayout();
            // 
            // ctl_CreatBatchDetsP1
            // 
            this.ctl_CreatBatchDetsP1._EditMode = 0;
            this.ctl_CreatBatchDetsP1.AllSpoil = 0;
            this.ctl_CreatBatchDetsP1.ArticleId = 0;
            this.ctl_CreatBatchDetsP1.Batch = "";
            this.ctl_CreatBatchDetsP1.BatchId = 0;
            this.ctl_CreatBatchDetsP1.Comments = "";
            this.ctl_CreatBatchDetsP1.COrderId = 0;
            this.ctl_CreatBatchDetsP1.Customer = "";
            this.ctl_CreatBatchDetsP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_CreatBatchDetsP1.fOldArticleId = 0;
            this.ctl_CreatBatchDetsP1.fOldComments = null;
            this.ctl_CreatBatchDetsP1.fOldEndDate = null;
            this.ctl_CreatBatchDetsP1.fOldQtyInBatch = 0D;
            this.ctl_CreatBatchDetsP1.fOldStartDate = null;
            this.ctl_CreatBatchDetsP1.fOldUrgent = 0;
            this.ctl_CreatBatchDetsP1.Location = new System.Drawing.Point(0, 0);
            this.ctl_CreatBatchDetsP1.Name = "ctl_CreatBatchDetsP1";
            this.ctl_CreatBatchDetsP1.PrevNum = 0;
            this.ctl_CreatBatchDetsP1.ProjectId = 0;
            this.ctl_CreatBatchDetsP1.QtyCanBeInBatch = 0D;
            this.ctl_CreatBatchDetsP1.QtyInBatch = 0D;
            this.ctl_CreatBatchDetsP1.QtyInProject = 0D;
            this.ctl_CreatBatchDetsP1.SalesOrderId = 0;
            this.ctl_CreatBatchDetsP1.Size = new System.Drawing.Size(1284, 680);
            this.ctl_CreatBatchDetsP1.StartDate = "27.01.2022 05:46:12";
            this.ctl_CreatBatchDetsP1.TabIndex = 0;
            this.ctl_CreatBatchDetsP1.Urgent = 0;
            this.ctl_CreatBatchDetsP1.SaveBatch += new Odin.Planning.Controls.SaveBatchPEventHandler(this.ctl_CreatBatchDetsP1_SaveBatch);
            // 
            // frm_AddBatchP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 680);
            this.Controls.Add(this.ctl_CreatBatchDetsP1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddBatchP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add batch";
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        public Controls.ctl_CreatBatchDetsP ctl_CreatBatchDetsP1;
    }
}