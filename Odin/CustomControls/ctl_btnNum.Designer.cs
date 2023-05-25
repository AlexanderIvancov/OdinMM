namespace Odin.CustomControls
{
    partial class ctl_btnNum
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Qty = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_ShowDets = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_Qty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(129, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 41);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.Location = new System.Drawing.Point(3, 7);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(24, 26);
            this.lbl_Qty.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbl_Qty.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Qty.TabIndex = 0;
            this.lbl_Qty.Values.Text = "0";
            // 
            // btn_ShowDets
            // 
            this.btn_ShowDets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ShowDets.Location = new System.Drawing.Point(2, 2);
            this.btn_ShowDets.Name = "btn_ShowDets";
            this.btn_ShowDets.Size = new System.Drawing.Size(127, 41);
            this.btn_ShowDets.TabIndex = 11;
            this.btn_ShowDets.Values.Image = global::Odin.Global_Resourses.Decline_32;
            this.btn_ShowDets.Values.Text = "Invalide BOMs";
            this.btn_ShowDets.Click += new System.EventHandler(this.btn_ShowDets_Click);
            // 
            // ctl_btnNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_ShowDets);
            this.Controls.Add(this.panel1);
            this.Name = "ctl_btnNum";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(186, 45);
            this.Load += new System.EventHandler(this.ctl_btnNum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ShowDets;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Qty;
    }
}
