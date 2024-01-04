namespace Odin.Tools
{
    partial class frm_Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Error));
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Message = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Focus = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(519, 364);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 58);
            this.btn_Cancel.TabIndex = 28;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.stop32x32;
            this.btn_Cancel.Values.Text = "Close";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.Enabled = false;
            this.lbl_Message.Location = new System.Drawing.Point(12, 47);
            this.lbl_Message.Multiline = true;
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(640, 311);
            this.lbl_Message.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.lbl_Message.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Message.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.lbl_Message.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.lbl_Message.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lbl_Message.StateDisabled.Content.Color1 = System.Drawing.Color.Red;
            this.lbl_Message.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Message.TabIndex = 29;
            this.lbl_Message.Text = "kryptonTextBox1";
            // 
            // txt_Focus
            // 
            this.txt_Focus.Location = new System.Drawing.Point(171, 293);
            this.txt_Focus.Name = "txt_Focus";
            this.txt_Focus.Size = new System.Drawing.Size(100, 20);
            this.txt_Focus.TabIndex = 30;
            // 
            // frm_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 434);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_Focus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error!!!";
            this.Activated += new System.EventHandler(this.frm_Error_Activated);
            this.Load += new System.EventHandler(this.frm_Error_Load);
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lbl_Message;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Focus;
    }
}