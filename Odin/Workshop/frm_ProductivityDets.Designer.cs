﻿namespace Odin.Workshop
{
    partial class frm_ProductivityDets
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
            this.ctl_ProductivityDets1 = new Odin.Workshop.ctl_ProductivityDets();
            this.SuspendLayout();
            // 
            // ctl_ProductivityDets1
            // 
            this.ctl_ProductivityDets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_ProductivityDets1.Location = new System.Drawing.Point(0, 0);
            this.ctl_ProductivityDets1.Name = "ctl_ProductivityDets1";
            this.ctl_ProductivityDets1.Size = new System.Drawing.Size(766, 370);
            this.ctl_ProductivityDets1.StageId = 0;
            this.ctl_ProductivityDets1.TabIndex = 0;
            // 
            // frm_ProductivityDets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 370);
            this.Controls.Add(this.ctl_ProductivityDets1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_ProductivityDets";
            this.Text = "Productivity details";
            this.ResumeLayout(false);

        }

        #endregion

        public ctl_ProductivityDets ctl_ProductivityDets1;
    }
}