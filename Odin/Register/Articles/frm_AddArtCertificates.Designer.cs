namespace Odin.Register.Articles
{
    partial class frm_AddArtCertificates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddArtCertificates));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tnvedLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cn_tnved = new System.Windows.Forms.TextBox();
            this.commentLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cn_comment = new System.Windows.Forms.TextBox();
            this.certNumLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cn_certNum = new System.Windows.Forms.TextBox();
            this.dateToLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cn_dateTo = new Odin.CustomControls.NullableDateTimePicker();
            this.cn_dateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.dateFromLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tnvedLabel);
            this.kryptonPanel1.Controls.Add(this.cn_tnved);
            this.kryptonPanel1.Controls.Add(this.commentLabel);
            this.kryptonPanel1.Controls.Add(this.cn_comment);
            this.kryptonPanel1.Controls.Add(this.certNumLabel);
            this.kryptonPanel1.Controls.Add(this.cn_certNum);
            this.kryptonPanel1.Controls.Add(this.dateToLabel);
            this.kryptonPanel1.Controls.Add(this.cn_dateTo);
            this.kryptonPanel1.Controls.Add(this.cn_dateFrom);
            this.kryptonPanel1.Controls.Add(this.dateFromLabel);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(354, 219);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // tnvedLabel
            // 
            this.tnvedLabel.Location = new System.Drawing.Point(15, 125);
            this.tnvedLabel.Name = "tnvedLabel";
            this.tnvedLabel.Size = new System.Drawing.Size(51, 20);
            this.tnvedLabel.TabIndex = 28;
            this.tnvedLabel.Values.Text = "TNVED:";
            // 
            // cn_tnved
            // 
            this.cn_tnved.Location = new System.Drawing.Point(142, 125);
            this.cn_tnved.Name = "cn_tnved";
            this.cn_tnved.Size = new System.Drawing.Size(191, 20);
            this.cn_tnved.TabIndex = 27;
            // 
            // commentLabel
            // 
            this.commentLabel.Location = new System.Drawing.Point(15, 151);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(67, 20);
            this.commentLabel.TabIndex = 26;
            this.commentLabel.Values.Text = "Comment:";
            // 
            // cn_comment
            // 
            this.cn_comment.Location = new System.Drawing.Point(142, 151);
            this.cn_comment.Multiline = true;
            this.cn_comment.Name = "cn_comment";
            this.cn_comment.Size = new System.Drawing.Size(191, 54);
            this.cn_comment.TabIndex = 25;
            // 
            // certNumLabel
            // 
            this.certNumLabel.Location = new System.Drawing.Point(15, 99);
            this.certNumLabel.Name = "certNumLabel";
            this.certNumLabel.Size = new System.Drawing.Size(114, 20);
            this.certNumLabel.TabIndex = 24;
            this.certNumLabel.Values.Text = "Certificate number:";
            // 
            // cn_certNum
            // 
            this.cn_certNum.Location = new System.Drawing.Point(142, 99);
            this.cn_certNum.Name = "cn_certNum";
            this.cn_certNum.Size = new System.Drawing.Size(191, 20);
            this.cn_certNum.TabIndex = 23;
            // 
            // dateToLabel
            // 
            this.dateToLabel.Location = new System.Drawing.Point(12, 53);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(29, 20);
            this.dateToLabel.TabIndex = 22;
            this.dateToLabel.Values.Text = "Till:";
            // 
            // cn_dateTo
            // 
            this.cn_dateTo.CustomFormat = null;
            this.cn_dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cn_dateTo.Location = new System.Drawing.Point(87, 52);
            this.cn_dateTo.Name = "cn_dateTo";
            this.cn_dateTo.NullValue = " ";
            this.cn_dateTo.Size = new System.Drawing.Size(83, 21);
            this.cn_dateTo.TabIndex = 21;
            // 
            // cn_dateFrom
            // 
            this.cn_dateFrom.CustomFormat = null;
            this.cn_dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cn_dateFrom.Location = new System.Drawing.Point(87, 14);
            this.cn_dateFrom.Name = "cn_dateFrom";
            this.cn_dateFrom.NullValue = " ";
            this.cn_dateFrom.Size = new System.Drawing.Size(83, 21);
            this.cn_dateFrom.TabIndex = 20;
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.Location = new System.Drawing.Point(12, 13);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(41, 20);
            this.dateFromLabel.TabIndex = 18;
            this.dateFromLabel.Values.Text = "From:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(243, 52);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(243, 12);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // frm_AddArtCertificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 219);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddArtCertificates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add certificate ";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dateToLabel;
        private CustomControls.NullableDateTimePicker cn_dateTo;
        private CustomControls.NullableDateTimePicker cn_dateFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dateFromLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel certNumLabel;
        private System.Windows.Forms.TextBox cn_certNum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel commentLabel;
        private System.Windows.Forms.TextBox cn_comment;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel tnvedLabel;
        private System.Windows.Forms.TextBox cn_tnved;
    }
}