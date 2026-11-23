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
            this.lbl_Mat1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Mat2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Mat3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Mat4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Mat5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Mat1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Mat2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Mat3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Mat4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Mat5 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.kryptonPanel1.Controls.Add(this.txt_Mat5);
            this.kryptonPanel1.Controls.Add(this.txt_Mat4);
            this.kryptonPanel1.Controls.Add(this.txt_Mat3);
            this.kryptonPanel1.Controls.Add(this.txt_Mat2);
            this.kryptonPanel1.Controls.Add(this.txt_Mat1);
            this.kryptonPanel1.Controls.Add(this.lbl_Mat5);
            this.kryptonPanel1.Controls.Add(this.lbl_Mat4);
            this.kryptonPanel1.Controls.Add(this.lbl_Mat3);
            this.kryptonPanel1.Controls.Add(this.lbl_Mat2);
            this.kryptonPanel1.Controls.Add(this.lbl_Mat1);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(548, 330);
            this.kryptonPanel1.TabIndex = 266;
            // 
            // txt_Worktime
            // 
            this.txt_Worktime.AllowDecimalSeparator = true;
            this.txt_Worktime.AllowSpace = false;
            this.txt_Worktime.Location = new System.Drawing.Point(433, 13);
            this.txt_Worktime.Name = "txt_Worktime";
            this.txt_Worktime.Size = new System.Drawing.Size(100, 31);
            this.txt_Worktime.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worktime.TabIndex = 280;
            this.txt_Worktime.Text = "0";
            // 
            // lbl_Worktime
            // 
            this.lbl_Worktime.Location = new System.Drawing.Point(256, 15);
            this.lbl_Worktime.Name = "lbl_Worktime";
            this.lbl_Worktime.Size = new System.Drawing.Size(156, 26);
            this.lbl_Worktime.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Worktime.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Worktime.TabIndex = 279;
            this.lbl_Worktime.Values.Text = "Worktime (min):";
            // 
            // lbl_Text
            // 
            this.lbl_Text.Location = new System.Drawing.Point(10, 15);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(78, 26);
            this.lbl_Text.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.TabIndex = 278;
            this.lbl_Text.Values.Text = "Defect:";
            // 
            // txt_Text
            // 
            this.txt_Text.Location = new System.Drawing.Point(11, 54);
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
            this.btn_OK.Location = new System.Drawing.Point(401, 174);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(133, 58);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(401, 238);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 58);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // lbl_Mat1
            // 
            this.lbl_Mat1.Location = new System.Drawing.Point(12, 159);
            this.lbl_Mat1.Name = "lbl_Mat1";
            this.lbl_Mat1.Size = new System.Drawing.Size(108, 26);
            this.lbl_Mat1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat1.TabIndex = 281;
            this.lbl_Mat1.Values.Text = "Material 1:";
            // 
            // lbl_Mat2
            // 
            this.lbl_Mat2.Location = new System.Drawing.Point(12, 191);
            this.lbl_Mat2.Name = "lbl_Mat2";
            this.lbl_Mat2.Size = new System.Drawing.Size(108, 26);
            this.lbl_Mat2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat2.TabIndex = 282;
            this.lbl_Mat2.Values.Text = "Material 2:";
            // 
            // lbl_Mat3
            // 
            this.lbl_Mat3.Location = new System.Drawing.Point(12, 223);
            this.lbl_Mat3.Name = "lbl_Mat3";
            this.lbl_Mat3.Size = new System.Drawing.Size(108, 26);
            this.lbl_Mat3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat3.TabIndex = 283;
            this.lbl_Mat3.Values.Text = "Material 3:";
            // 
            // lbl_Mat4
            // 
            this.lbl_Mat4.Location = new System.Drawing.Point(12, 255);
            this.lbl_Mat4.Name = "lbl_Mat4";
            this.lbl_Mat4.Size = new System.Drawing.Size(108, 26);
            this.lbl_Mat4.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat4.TabIndex = 284;
            this.lbl_Mat4.Values.Text = "Material 4:";
            // 
            // lbl_Mat5
            // 
            this.lbl_Mat5.Location = new System.Drawing.Point(12, 287);
            this.lbl_Mat5.Name = "lbl_Mat5";
            this.lbl_Mat5.Size = new System.Drawing.Size(108, 26);
            this.lbl_Mat5.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Mat5.TabIndex = 285;
            this.lbl_Mat5.Values.Text = "Material 5:";
            // 
            // txt_Mat1
            // 
            this.txt_Mat1.Location = new System.Drawing.Point(139, 159);
            this.txt_Mat1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mat1.Multiline = true;
            this.txt_Mat1.Name = "txt_Mat1";
            this.txt_Mat1.Size = new System.Drawing.Size(242, 26);
            this.txt_Mat1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Mat1.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Mat1.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Mat1.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Mat1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Mat1.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Mat1.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat1.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat1.TabIndex = 286;
            // 
            // txt_Mat2
            // 
            this.txt_Mat2.Location = new System.Drawing.Point(139, 191);
            this.txt_Mat2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mat2.Multiline = true;
            this.txt_Mat2.Name = "txt_Mat2";
            this.txt_Mat2.Size = new System.Drawing.Size(242, 26);
            this.txt_Mat2.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Mat2.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Mat2.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Mat2.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Mat2.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Mat2.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Mat2.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat2.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat2.TabIndex = 287;
            // 
            // txt_Mat3
            // 
            this.txt_Mat3.Location = new System.Drawing.Point(139, 223);
            this.txt_Mat3.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mat3.Multiline = true;
            this.txt_Mat3.Name = "txt_Mat3";
            this.txt_Mat3.Size = new System.Drawing.Size(242, 26);
            this.txt_Mat3.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat3.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Mat3.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Mat3.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Mat3.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Mat3.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Mat3.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Mat3.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat3.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat3.TabIndex = 288;
            // 
            // txt_Mat4
            // 
            this.txt_Mat4.Location = new System.Drawing.Point(139, 255);
            this.txt_Mat4.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mat4.Multiline = true;
            this.txt_Mat4.Name = "txt_Mat4";
            this.txt_Mat4.Size = new System.Drawing.Size(242, 26);
            this.txt_Mat4.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat4.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Mat4.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Mat4.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Mat4.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Mat4.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Mat4.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Mat4.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat4.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat4.TabIndex = 289;
            // 
            // txt_Mat5
            // 
            this.txt_Mat5.Location = new System.Drawing.Point(139, 287);
            this.txt_Mat5.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mat5.Multiline = true;
            this.txt_Mat5.Name = "txt_Mat5";
            this.txt_Mat5.Size = new System.Drawing.Size(242, 26);
            this.txt_Mat5.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat5.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Mat5.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Mat5.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Mat5.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Mat5.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Mat5.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Mat5.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat5.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Mat5.TabIndex = 290;
            // 
            // frm_AddRepairCardDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 330);
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
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Mat3;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Mat2;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Mat1;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Mat5;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Mat4;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Mat5;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Mat4;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Mat3;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Mat2;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Mat1;
    }
}