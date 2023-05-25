namespace Odin.Global_Classes
{
    partial class frm_Wait
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
            this.circularProgressControl1 = new Odin.CustomControls.CircularProgressControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circularProgressControl1
            // 
            this.circularProgressControl1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.circularProgressControl1.Interval = 60;
            this.circularProgressControl1.Location = new System.Drawing.Point(0, 0);
            this.circularProgressControl1.MinimumSize = new System.Drawing.Size(28, 28);
            this.circularProgressControl1.Name = "circularProgressControl1";
            this.circularProgressControl1.Rotation = Odin.CustomControls.CircularProgressControl.Direction.CLOCKWISE;
            this.circularProgressControl1.Size = new System.Drawing.Size(66, 65);
            this.circularProgressControl1.StartAngle = 270;
            this.circularProgressControl1.TabIndex = 0;
            this.circularProgressControl1.TickColor = System.Drawing.Color.Lime;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar1.Location = new System.Drawing.Point(0, 60);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Info.Location = new System.Drawing.Point(72, 25);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(100, 16);
            this.lbl_Info.TabIndex = 3;
            this.lbl_Info.Text = "Please wait...";
            // 
            // frm_Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(192, 77);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.circularProgressControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Wait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Wait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CircularProgressControl circularProgressControl1;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label lbl_Info;
    }
}