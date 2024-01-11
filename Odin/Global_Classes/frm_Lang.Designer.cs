namespace Odin.Global_Classes
{
    partial class frm_Lang
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
            this.btn_eng = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_rus = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btn_eng
            // 
            this.btn_eng.Location = new System.Drawing.Point(12, 12);
            this.btn_eng.Name = "btn_eng";
            this.btn_eng.Size = new System.Drawing.Size(139, 20);
            this.btn_eng.TabIndex = 0;
            this.btn_eng.Values.Text = "kryptonRadioButton1";
            // 
            // btn_rus
            // 
            this.btn_rus.Location = new System.Drawing.Point(12, 38);
            this.btn_rus.Name = "btn_rus";
            this.btn_rus.Size = new System.Drawing.Size(139, 20);
            this.btn_rus.TabIndex = 1;
            this.btn_rus.Values.Text = "kryptonRadioButton2";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(12, 103);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(56, 33);
            this.btn_OK.TabIndex = 28;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 64);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(66, 33);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // frm_Lang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 143);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_rus);
            this.Controls.Add(this.btn_eng);
            this.Name = "frm_Lang";
            this.Text = "frm_Lang";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.GetKryptonFormFields(this.GetType());
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton btn_eng;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton btn_rus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
    }
}