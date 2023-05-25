namespace Odin.Warehouse.Corrections
{
    partial class frm_BCCorrection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BCCorrection));
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.chk_PrintLabels = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.txt_Oper = new System.Windows.Forms.TextBox();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Unit = new Owf.Controls.NumericTetxBox();
            this.txt_QtyInDB = new Owf.Controls.NumericTetxBox();
            this.txt_Label = new Owf.Controls.NumericTetxBox();
            this.numericTetxBox1 = new Owf.Controls.NumericTetxBox();
            this.txt_Qty = new Owf.Controls.NumericTetxBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.chk_PrintLabels);
            this.kryptonPanel2.Controls.Add(this.txt_Oper);
            this.kryptonPanel2.Controls.Add(this.btn_OK);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 225);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(477, 49);
            this.kryptonPanel2.TabIndex = 32;
            // 
            // chk_PrintLabels
            // 
            this.chk_PrintLabels.Location = new System.Drawing.Point(228, 15);
            this.chk_PrintLabels.Name = "chk_PrintLabels";
            this.chk_PrintLabels.Size = new System.Drawing.Size(98, 20);
            this.chk_PrintLabels.TabIndex = 225;
            this.chk_PrintLabels.Values.Text = "Reprint labels";
            // 
            // txt_Oper
            // 
            this.txt_Oper.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Oper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Oper.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Oper.ForeColor = System.Drawing.Color.Transparent;
            this.txt_Oper.Location = new System.Drawing.Point(8, 26);
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.Size = new System.Drawing.Size(10, 8);
            this.txt_Oper.TabIndex = 224;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(379, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OK.Size = new System.Drawing.Size(93, 39);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok_big;
            this.btn_OK.Values.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(111, 43);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Text = "Label:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 165);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(206, 43);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 35;
            this.kryptonLabel2.Values.Text = "Correct rest:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 116);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(210, 43);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.TabIndex = 39;
            this.kryptonLabel3.Values.Text = "Qty on label:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 69);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(88, 43);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.TabIndex = 41;
            this.kryptonLabel4.Values.Text = "Unit:";
            // 
            // txt_Unit
            // 
            this.txt_Unit.AllowDecimalSeparator = false;
            this.txt_Unit.AllowSpace = false;
            this.txt_Unit.Enabled = false;
            this.txt_Unit.Location = new System.Drawing.Point(228, 69);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.ReadOnly = true;
            this.txt_Unit.Size = new System.Drawing.Size(169, 41);
            this.txt_Unit.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Unit.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Unit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Unit.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Unit.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Unit.StateDisabled.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Unit.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Unit.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Unit.TabIndex = 42;
            // 
            // txt_QtyInDB
            // 
            this.txt_QtyInDB.AllowDecimalSeparator = false;
            this.txt_QtyInDB.AllowSpace = false;
            this.txt_QtyInDB.Enabled = false;
            this.txt_QtyInDB.Location = new System.Drawing.Point(228, 116);
            this.txt_QtyInDB.Name = "txt_QtyInDB";
            this.txt_QtyInDB.ReadOnly = true;
            this.txt_QtyInDB.Size = new System.Drawing.Size(237, 41);
            this.txt_QtyInDB.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_QtyInDB.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_QtyInDB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_QtyInDB.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.txt_QtyInDB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyInDB.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_QtyInDB.StateDisabled.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_QtyInDB.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_QtyInDB.StateDisabled.Content.Color1 = System.Drawing.Color.Red;
            this.txt_QtyInDB.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyInDB.TabIndex = 40;
            // 
            // txt_Label
            // 
            this.txt_Label.AllowDecimalSeparator = false;
            this.txt_Label.AllowSpace = false;
            this.txt_Label.Enabled = false;
            this.txt_Label.Location = new System.Drawing.Point(228, 22);
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.ReadOnly = true;
            this.txt_Label.Size = new System.Drawing.Size(237, 41);
            this.txt_Label.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Label.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Label.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Label.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Label.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Label.StateDisabled.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txt_Label.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Label.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Label.TabIndex = 38;
            this.txt_Label.Text = "0";
            // 
            // numericTetxBox1
            // 
            this.numericTetxBox1.AllowDecimalSeparator = false;
            this.numericTetxBox1.AllowSpace = false;
            this.numericTetxBox1.Location = new System.Drawing.Point(-328, -167);
            this.numericTetxBox1.Name = "numericTetxBox1";
            this.numericTetxBox1.Size = new System.Drawing.Size(162, 41);
            this.numericTetxBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericTetxBox1.TabIndex = 37;
            this.numericTetxBox1.Text = "000000";
            // 
            // txt_Qty
            // 
            this.txt_Qty.AllowDecimalSeparator = true;
            this.txt_Qty.AllowSpace = false;
            this.txt_Qty.Location = new System.Drawing.Point(228, 167);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(237, 41);
            this.txt_Qty.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txt_Qty.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.TabIndex = 33;
            this.txt_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            this.txt_Qty.Validated += new System.EventHandler(this.txt_Qty_Validated);
            // 
            // frm_BCCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(477, 274);
            this.Controls.Add(this.txt_Unit);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txt_QtyInDB);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txt_Label);
            this.Controls.Add(this.numericTetxBox1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.kryptonPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BCCorrection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter correct qty ";
            this.Load += new System.EventHandler(this.frm_BCCorrection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.TextBox txt_Oper;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private Owf.Controls.NumericTetxBox txt_Qty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Owf.Controls.NumericTetxBox numericTetxBox1;
        private Owf.Controls.NumericTetxBox txt_Label;
        private Owf.Controls.NumericTetxBox txt_QtyInDB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Owf.Controls.NumericTetxBox txt_Unit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_PrintLabels;
    }
}