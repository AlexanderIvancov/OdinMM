namespace Odin.DataCollection
{
    partial class frm_AddRepairCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddRepairCard));
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Analog = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Serial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_BatchPDA1 = new Odin.CMB_Components.Batches.cmb_BatchPDA();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Text = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.kryptonPanel1.Controls.Add(this.lbl_Text);
            this.kryptonPanel1.Controls.Add(this.txt_Text);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.txt_Analog);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txt_Serial);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.cmb_BatchPDA1);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(548, 440);
            this.kryptonPanel1.TabIndex = 266;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(18, 280);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(82, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 280;
            this.kryptonLabel2.Values.Text = "Analog:";
            // 
            // txt_Analog
            // 
            this.txt_Analog.Enabled = false;
            this.txt_Analog.Location = new System.Drawing.Point(126, 272);
            this.txt_Analog.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Analog.Multiline = true;
            this.txt_Analog.Name = "txt_Analog";
            this.txt_Analog.ReadOnly = true;
            this.txt_Analog.Size = new System.Drawing.Size(185, 40);
            this.txt_Analog.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Analog.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Analog.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Analog.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Analog.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Analog.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Analog.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Analog.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Analog.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Analog.TabIndex = 279;
            this.txt_Analog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 236);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(52, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 278;
            this.kryptonLabel1.Values.Text = "S/N:";
            // 
            // txt_Serial
            // 
            this.txt_Serial.Enabled = false;
            this.txt_Serial.Location = new System.Drawing.Point(126, 228);
            this.txt_Serial.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Serial.Multiline = true;
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.ReadOnly = true;
            this.txt_Serial.Size = new System.Drawing.Size(185, 40);
            this.txt_Serial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Serial.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Serial.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Serial.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Serial.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Serial.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Serial.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Serial.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Serial.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Serial.TabIndex = 277;
            this.txt_Serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(15, 189);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(71, 26);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.TabIndex = 235;
            this.kryptonLabel3.Values.Text = "Batch:";
            // 
            // cmb_BatchPDA1
            // 
            this.cmb_BatchPDA1.Article = null;
            this.cmb_BatchPDA1.ArticleId = 0;
            this.cmb_BatchPDA1.Batch = "";
            this.cmb_BatchPDA1.BatchId = 0;
            this.cmb_BatchPDA1.ClearButtonVisible = -1;
            this.cmb_BatchPDA1.COId = 0;
            this.cmb_BatchPDA1.ConfOrder = null;
            this.cmb_BatchPDA1.CountID = 0;
            this.cmb_BatchPDA1.Customer = null;
            this.cmb_BatchPDA1.IsActive = 0;
            this.cmb_BatchPDA1.Location = new System.Drawing.Point(126, 182);
            this.cmb_BatchPDA1.Name = "cmb_BatchPDA1";
            //this.cmb_BatchPDA1.NoLogo = 0;
            this.cmb_BatchPDA1.ParentBatchId = 0;
            this.cmb_BatchPDA1.Qty = 0D;
            this.cmb_BatchPDA1.QtyLabels = 0;
            this.cmb_BatchPDA1.ResDate = null;
            this.cmb_BatchPDA1.SecName = null;
            this.cmb_BatchPDA1.Size = new System.Drawing.Size(314, 41);
            this.cmb_BatchPDA1.StencilRequired = 0;
            this.cmb_BatchPDA1.TabIndex = 234;
            this.cmb_BatchPDA1.TextBoxEnabled = -1;
            this.cmb_BatchPDA1.Unit = "";
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
            // lbl_Text
            // 
            this.lbl_Text.Location = new System.Drawing.Point(18, 312);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(78, 26);
            this.lbl_Text.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.TabIndex = 282;
            this.lbl_Text.Values.Text = "Defect:";
            // 
            // txt_Text
            // 
            this.txt_Text.Location = new System.Drawing.Point(15, 339);
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
            this.txt_Text.TabIndex = 281;
            // 
            // frm_AddRepairCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 440);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.txt_Oper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddRepairCard";
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public CMB_Components.Batches.cmb_BatchPDA cmb_BatchPDA1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Analog;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Serial;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Text;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Text;
    }
}