namespace Odin.Sales
{
    partial class frm_EditPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditPayment));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_Total = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalMapped = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_SummaWVat = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CurRate = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Vat = new Owf.Controls.NumericTetxBox();
            this.lbl_Discount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_VatPerc = new Owf.Controls.NumericTetxBox();
            this.lbl_Price = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Summa = new Owf.Controls.NumericTetxBox();
            this.cmb_Currency1 = new Odin.CMB_Components.Currencies.cmb_Currency();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_PayDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms2 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.txt_Payment = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 222);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel1.Size = new System.Drawing.Size(526, 50);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(422, 8);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(323, 8);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 34);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lbl_Total);
            this.kryptonPanel2.Controls.Add(this.txt_TotalMapped);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.txt_Comments);
            this.kryptonPanel2.Controls.Add(this.txt_SummaWVat);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.txt_CurRate);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.txt_Vat);
            this.kryptonPanel2.Controls.Add(this.lbl_Discount);
            this.kryptonPanel2.Controls.Add(this.txt_VatPerc);
            this.kryptonPanel2.Controls.Add(this.lbl_Price);
            this.kryptonPanel2.Controls.Add(this.txt_Summa);
            this.kryptonPanel2.Controls.Add(this.cmb_Currency1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel2.Controls.Add(this.txt_PayDate);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel2.Controls.Add(this.cmb_Firms2);
            this.kryptonPanel2.Controls.Add(this.txt_Payment);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel2.Size = new System.Drawing.Size(526, 223);
            this.kryptonPanel2.TabIndex = 5;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Location = new System.Drawing.Point(249, 66);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(89, 20);
            this.lbl_Total.TabIndex = 311;
            this.lbl_Total.Values.Text = "Total mapped:";
            // 
            // txt_TotalMapped
            // 
            this.txt_TotalMapped.AllowDecimalSeparator = true;
            this.txt_TotalMapped.AllowSpace = false;
            this.txt_TotalMapped.Enabled = false;
            this.txt_TotalMapped.Location = new System.Drawing.Point(385, 66);
            this.txt_TotalMapped.Name = "txt_TotalMapped";
            this.txt_TotalMapped.Size = new System.Drawing.Size(72, 23);
            this.txt_TotalMapped.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_TotalMapped.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalMapped.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_TotalMapped.StateDisabled.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_TotalMapped.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalMapped.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_TotalMapped.TabIndex = 310;
            this.txt_TotalMapped.Text = "0";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 151);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel5.TabIndex = 309;
            this.kryptonLabel5.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Comments.Location = new System.Drawing.Point(105, 154);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(407, 54);
            this.txt_Comments.TabIndex = 308;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "281005753B9C42862A8E64375FFFA292";
            // 
            // txt_SummaWVat
            // 
            this.txt_SummaWVat.AllowDecimalSeparator = true;
            this.txt_SummaWVat.AllowSpace = false;
            this.txt_SummaWVat.Location = new System.Drawing.Point(164, 94);
            this.txt_SummaWVat.Name = "txt_SummaWVat";
            this.txt_SummaWVat.Size = new System.Drawing.Size(80, 23);
            this.txt_SummaWVat.TabIndex = 303;
            this.txt_SummaWVat.Text = "0";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(187, 125);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel4.TabIndex = 306;
            this.kryptonLabel4.Values.Text = "Cur. rate:";
            // 
            // txt_CurRate
            // 
            this.txt_CurRate.AllowDecimalSeparator = true;
            this.txt_CurRate.AllowSpace = false;
            this.txt_CurRate.Location = new System.Drawing.Point(258, 125);
            this.txt_CurRate.Name = "txt_CurRate";
            this.txt_CurRate.Size = new System.Drawing.Size(64, 23);
            this.txt_CurRate.TabIndex = 305;
            this.txt_CurRate.Text = "0";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 96);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel3.TabIndex = 304;
            this.kryptonLabel3.Values.Text = "Total (w/o VAT):";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(344, 97);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel1.TabIndex = 302;
            this.kryptonLabel1.Values.Text = "VAT:";
            // 
            // txt_Vat
            // 
            this.txt_Vat.AllowDecimalSeparator = true;
            this.txt_Vat.AllowSpace = false;
            this.txt_Vat.Location = new System.Drawing.Point(385, 96);
            this.txt_Vat.Name = "txt_Vat";
            this.txt_Vat.Size = new System.Drawing.Size(72, 23);
            this.txt_Vat.TabIndex = 301;
            this.txt_Vat.Text = "0";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.Location = new System.Drawing.Point(249, 97);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(56, 20);
            this.lbl_Discount.TabIndex = 300;
            this.lbl_Discount.Values.Text = "VAT (%):";
            // 
            // txt_VatPerc
            // 
            this.txt_VatPerc.AllowDecimalSeparator = true;
            this.txt_VatPerc.AllowSpace = false;
            this.txt_VatPerc.Location = new System.Drawing.Point(311, 96);
            this.txt_VatPerc.Name = "txt_VatPerc";
            this.txt_VatPerc.Size = new System.Drawing.Size(27, 23);
            this.txt_VatPerc.TabIndex = 299;
            this.txt_VatPerc.Text = "0";
            this.txt_VatPerc.TextChanged += new System.EventHandler(this.txt_VatPerc_TextChanged);
            // 
            // lbl_Price
            // 
            this.lbl_Price.Location = new System.Drawing.Point(12, 66);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(146, 20);
            this.lbl_Price.TabIndex = 298;
            this.lbl_Price.Values.Text = "Payment sum (with VAT):";
            // 
            // txt_Summa
            // 
            this.txt_Summa.AllowDecimalSeparator = true;
            this.txt_Summa.AllowSpace = false;
            this.txt_Summa.Location = new System.Drawing.Point(164, 65);
            this.txt_Summa.Name = "txt_Summa";
            this.txt_Summa.Size = new System.Drawing.Size(80, 23);
            this.txt_Summa.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Summa.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Summa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_Summa.TabIndex = 297;
            this.txt_Summa.Text = "0";
            this.txt_Summa.TextChanged += new System.EventHandler(this.txt_Summa_TextChanged);
            this.txt_Summa.Validated += new System.EventHandler(this.txt_Summa_Validated);
            // 
            // cmb_Currency1
            // 
            this.cmb_Currency1.Currency = "";
            this.cmb_Currency1.CurrencyId = 0;
            this.cmb_Currency1.EnableSearchId = false;
            this.cmb_Currency1.Location = new System.Drawing.Point(105, 125);
            this.cmb_Currency1.Name = "cmb_Currency1";
            this.cmb_Currency1.Size = new System.Drawing.Size(79, 20);
            this.cmb_Currency1.TabIndex = 296;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(12, 125);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel10.TabIndex = 295;
            this.kryptonLabel10.Values.Text = "Currency:";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(328, 125);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel14.TabIndex = 294;
            this.kryptonLabel14.Values.Text = "Payment date:";
            // 
            // txt_PayDate
            // 
            this.txt_PayDate.CalendarShowWeekNumbers = true;
            this.txt_PayDate.CustomFormat = null;
            this.txt_PayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_PayDate.Location = new System.Drawing.Point(424, 125);
            this.txt_PayDate.Name = "txt_PayDate";
            this.txt_PayDate.NullValue = " ";
            this.txt_PayDate.Size = new System.Drawing.Size(88, 21);
            this.txt_PayDate.TabIndex = 293;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(12, 39);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel9.TabIndex = 256;
            this.kryptonLabel9.Values.Text = "Buyer:";
            // 
            // cmb_Firms2
            // 
            this.cmb_Firms2.CountryId = 0;
            this.cmb_Firms2.CountryVAT = 0D;
            this.cmb_Firms2.CurId = 0;
            this.cmb_Firms2.CustIncotermsId = 0;
            this.cmb_Firms2.CustPaymentId = 0;
            this.cmb_Firms2.Enabled = false;
            this.cmb_Firms2.EnableSearchId = false;
            this.cmb_Firms2.Firm = "";
            this.cmb_Firms2.FirmId = 0;
            this.cmb_Firms2.IsEmptyColor = false;
            this.cmb_Firms2.Location = new System.Drawing.Point(105, 39);
            this.cmb_Firms2.Name = "cmb_Firms2";
            this.cmb_Firms2.Size = new System.Drawing.Size(228, 20);
            this.cmb_Firms2.SupComments = null;
            this.cmb_Firms2.SupIncotermsId = 0;
            this.cmb_Firms2.TabIndex = 255;
            this.cmb_Firms2.VATNr = null;
            // 
            // txt_Payment
            // 
            this.txt_Payment.Location = new System.Drawing.Point(105, 12);
            this.txt_Payment.Name = "txt_Payment";
            this.txt_Payment.Size = new System.Drawing.Size(141, 21);
            this.txt_Payment.StateActive.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Payment.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Payment.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Payment.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Payment.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Payment.StateNormal.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Payment.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Payment.TabIndex = 13;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Payment:";
            // 
            // frm_EditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 272);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit payment";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Owf.Controls.NumericTetxBox txt_SummaWVat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Owf.Controls.NumericTetxBox txt_CurRate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Owf.Controls.NumericTetxBox txt_Vat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Discount;
        private Owf.Controls.NumericTetxBox txt_VatPerc;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Price;
        private Owf.Controls.NumericTetxBox txt_Summa;
        private CMB_Components.Currencies.cmb_Currency cmb_Currency1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        public CustomControls.NullableDateTimePicker txt_PayDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private CMB_Components.Companies.cmb_Firms cmb_Firms2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Payment;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Total;
        private Owf.Controls.NumericTetxBox txt_TotalMapped;
    }
}