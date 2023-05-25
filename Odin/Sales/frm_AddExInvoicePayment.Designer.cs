namespace Odin.Sales
{
    partial class frm_AddExInvoicePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddExInvoicePayment));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_PaymentDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbl_Amount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_PaidAmount = new Owf.Controls.NumericTetxBox();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.txt_PaymentDate);
            this.kryptonPanel1.Controls.Add(this.lbl_Amount);
            this.kryptonPanel1.Controls.Add(this.txt_PaidAmount);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(385, 253);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(13, 217);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel11.TabIndex = 41;
            this.kryptonLabel11.Values.Text = "Payment date:";
            // 
            // txt_PaymentDate
            // 
            this.txt_PaymentDate.CalendarShowWeekNumbers = true;
            this.txt_PaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_PaymentDate.Location = new System.Drawing.Point(137, 217);
            this.txt_PaymentDate.Name = "txt_PaymentDate";
            this.txt_PaymentDate.Size = new System.Drawing.Size(102, 21);
            this.txt_PaymentDate.TabIndex = 40;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.Location = new System.Drawing.Point(13, 191);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(82, 20);
            this.lbl_Amount.TabIndex = 39;
            this.lbl_Amount.Values.Text = "Paid amount:";
            // 
            // txt_PaidAmount
            // 
            this.txt_PaidAmount.AllowDecimalSeparator = true;
            this.txt_PaidAmount.AllowSpace = false;
            this.txt_PaidAmount.Location = new System.Drawing.Point(137, 191);
            this.txt_PaidAmount.Name = "txt_PaidAmount";
            this.txt_PaidAmount.Size = new System.Drawing.Size(102, 20);
            this.txt_PaidAmount.TabIndex = 38;
            this.txt_PaidAmount.Text = "0";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(283, 52);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(283, 12);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // frm_AddExInvoicePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(385, 253);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddExInvoicePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add payment";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txt_PaymentDate;
        public Owf.Controls.NumericTetxBox txt_PaidAmount;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Amount;
    }
}