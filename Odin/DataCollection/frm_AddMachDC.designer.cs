namespace Odin.DataCollection
{
    partial class frm_AddMachDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddMachDC));
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_Viza = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Launch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Oper
            // 
            this.txt_Oper.Location = new System.Drawing.Point(505, 186);
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.Size = new System.Drawing.Size(121, 54);
            this.txt_Oper.TabIndex = 265;
            this.txt_Oper.Text = "";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lbl_Viza);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.txt_Launch);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(548, 323);
            this.kryptonPanel1.TabIndex = 266;
            // 
            // lbl_Viza
            // 
            this.lbl_Viza.Location = new System.Drawing.Point(105, 60);
            this.lbl_Viza.Name = "lbl_Viza";
            this.lbl_Viza.Size = new System.Drawing.Size(234, 26);
            this.lbl_Viza.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.lbl_Viza.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Viza.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbl_Viza.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Viza.TabIndex = 263;
            this.lbl_Viza.Values.Text = "NO VIZA ON LAUNCH!!!";
            this.lbl_Viza.Visible = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 21);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 244;
            this.kryptonLabel2.Values.Text = "Launch:";
            // 
            // txt_Launch
            // 
            this.txt_Launch.Enabled = false;
            this.txt_Launch.Location = new System.Drawing.Point(103, 15);
            this.txt_Launch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Launch.Multiline = true;
            this.txt_Launch.Name = "txt_Launch";
            this.txt_Launch.ReadOnly = true;
            this.txt_Launch.Size = new System.Drawing.Size(239, 40);
            this.txt_Launch.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Launch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Launch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Launch.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Launch.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Launch.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Launch.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Launch.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Launch.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Launch.StateNormal.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Launch.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Launch.TabIndex = 245;
            this.txt_Launch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(401, 15);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(133, 58);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(401, 79);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 58);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Visible = false;
            // 
            // frm_AddMachDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 323);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.txt_Oper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddMachDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create control card";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Oper;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Viza;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Launch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
    }
}