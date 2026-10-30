namespace Odin.DataCollection
{
    partial class frm_AddRepairCardDet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddRepairCardDet));
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_Worktime = new Owf.Controls.NumericTetxBox();
            this.lbl_Worktime = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Text = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.txt_Oper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Oper_KeyPress);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_Worktime);
            this.kryptonPanel1.Controls.Add(this.lbl_Worktime);
            this.kryptonPanel1.Controls.Add(this.lbl_Text);
            this.kryptonPanel1.Controls.Add(this.txt_Text);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(548, 323);
            this.kryptonPanel1.TabIndex = 266;
            // 
            // txt_Worktime
            // 
            this.txt_Worktime.AllowDecimalSeparator = true;
            this.txt_Worktime.AllowSpace = false;
            this.txt_Worktime.Location = new System.Drawing.Point(190, 157);
            this.txt_Worktime.Name = "txt_Worktime";
            this.txt_Worktime.Size = new System.Drawing.Size(100, 31);
            this.txt_Worktime.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worktime.TabIndex = 280;
            this.txt_Worktime.Text = "0";
            // 
            // lbl_Worktime
            // 
            this.lbl_Worktime.Location = new System.Drawing.Point(13, 159);
            this.lbl_Worktime.Name = "lbl_Worktime";
            this.lbl_Worktime.Size = new System.Drawing.Size(156, 26);
            this.lbl_Worktime.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Worktime.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Worktime.TabIndex = 279;
            this.lbl_Worktime.Values.Text = "Worktime (min):";
            // 
            // lbl_Text
            // 
            this.lbl_Text.Location = new System.Drawing.Point(11, 191);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(78, 26);
            this.lbl_Text.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.TabIndex = 278;
            this.lbl_Text.Values.Text = "Defect:";
            // 
            // txt_Text
            // 
            this.txt_Text.Location = new System.Drawing.Point(11, 222);
            this.txt_Text.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Text.Multiline = true;
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(523, 90);
            this.txt_Text.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Text.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Text.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Text.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Text.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Text.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Text.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Text.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Text.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Text.TabIndex = 277;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            // 
            // frm_AddRepairCardDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 323);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.txt_Oper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddRepairCardDet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add repair card details";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Oper;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Text;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Text;
        public Owf.Controls.NumericTetxBox txt_Worktime;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Worktime;
    }
}