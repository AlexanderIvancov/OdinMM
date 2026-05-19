namespace Odin.CustomControls
{
    partial class txtFocused
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtFocused));
            this.txt_Text = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_Text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Text
            // 
            this.txt_Text.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Text.Location = new System.Drawing.Point(122, 165);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(298, 40);
            this.txt_Text.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Text.TabIndex = 248;
            this.txt_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Text_KeyPress);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::Odin.Global_Resourses.delete2__2_;
            this.buttonSpecAny1.UniqueName = "230EC88DC01B438AB4AC2625E22E1FF0";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(367, 18);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(133, 58);
            this.btn_OK.TabIndex = 247;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(367, 82);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 58);
            this.btn_Cancel.TabIndex = 246;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lbl_Text);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(522, 223);
            this.kryptonPanel1.TabIndex = 250;
            // 
            // lbl_Text
            // 
            this.lbl_Text.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_Text.Location = new System.Drawing.Point(181, 93);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(158, 36);
            this.lbl_Text.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Text.TabIndex = 250;
            this.lbl_Text.Values.Text = "Instruction:";
            // 
            // txtFocused
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 223);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.txt_Text);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "txtFocused";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cmbTextPDA";
            this.Activated += new System.EventHandler(this.frm_cmbTextPDA_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Text;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Text;
    }
}