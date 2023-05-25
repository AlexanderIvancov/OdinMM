namespace Odin.Planning
{
    partial class frm_AddBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddBatch));
            this.ctl_CreatBatchDets1 = new Odin.Planning.Controls.ctl_CreatBatchDets();
            this.SuspendLayout();
            // 
            // ctl_CreatBatchDets1
            // 
            this.ctl_CreatBatchDets1._EditMode = 0;
            this.ctl_CreatBatchDets1.AllSpoil = 0;
            this.ctl_CreatBatchDets1.ArticleId = 0;
            this.ctl_CreatBatchDets1.Batch = "";
            this.ctl_CreatBatchDets1.BatchId = 0;
            this.ctl_CreatBatchDets1.Comments = "";
            this.ctl_CreatBatchDets1.COrderId = 0;
            this.ctl_CreatBatchDets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_CreatBatchDets1.EndDate = "09/05/2018";
            this.ctl_CreatBatchDets1.fOldArticleId = 0;
            this.ctl_CreatBatchDets1.fOldComments = null;
            this.ctl_CreatBatchDets1.fOldEndDate = null;
            this.ctl_CreatBatchDets1.fOldQtyInBatch = 0D;
            this.ctl_CreatBatchDets1.fOldStartDate = null;
            this.ctl_CreatBatchDets1.fOldUrgent = 0;
            this.ctl_CreatBatchDets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_CreatBatchDets1.Name = "ctl_CreatBatchDets1";
            this.ctl_CreatBatchDets1.QtyInBatch = 0D;
            this.ctl_CreatBatchDets1.Size = new System.Drawing.Size(1279, 539);
            this.ctl_CreatBatchDets1.StartDate = "09/05/2018";
            this.ctl_CreatBatchDets1.TabIndex = 0;
            this.ctl_CreatBatchDets1.Urgent = 0;
            this.ctl_CreatBatchDets1.SaveBatch += new Odin.Planning.Controls.SaveBatchEventHandler(this.ctl_CreatBatchDets1_SaveBatch);
            // 
            // frm_AddBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 539);
            this.Controls.Add(this.ctl_CreatBatchDets1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddBatch";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add batch";
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.ctl_CreatBatchDets ctl_CreatBatchDets1;
    }
}