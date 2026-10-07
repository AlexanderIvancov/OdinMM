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
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.chk_IsValid = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tnvedLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cn_tnved = new System.Windows.Forms.TextBox();
            this.commentLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cn_comment = new System.Windows.Forms.TextBox();
            this.certNumLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cn_certNum = new System.Windows.Forms.TextBox();
            this.cn_dateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.dateFromLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cn_dateTo = new Odin.CustomControls.NullableDateTimePicker();
            this.dateToLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cn_workDate = new Odin.CustomControls.NullableDateTimePicker();
            this.workDateLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cn_workDate);
            this.kryptonPanel1.Controls.Add(this.workDateLabel);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Controls.Add(this.chk_IsValid);
            this.kryptonPanel1.Controls.Add(this.tnvedLabel);
            this.kryptonPanel1.Controls.Add(this.cn_tnved);
            this.kryptonPanel1.Controls.Add(this.commentLabel);
            this.kryptonPanel1.Controls.Add(this.cn_comment);
            this.kryptonPanel1.Controls.Add(this.certNumLabel);
            this.kryptonPanel1.Controls.Add(this.cn_certNum);
            this.kryptonPanel1.Controls.Add(this.cn_dateFrom);
            this.kryptonPanel1.Controls.Add(this.dateFromLabel);
            this.kryptonPanel1.Controls.Add(this.cn_dateTo);
            this.kryptonPanel1.Controls.Add(this.dateToLabel);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(354, 290);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // cmb_Articles1
            // 
            this.cmb_Articles1.Article = "";
            this.cmb_Articles1.ArticleId = 0;
            this.cmb_Articles1.ArticleIdRec = 0;
            this.cmb_Articles1.ArtType = null;
            this.cmb_Articles1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmb_Articles1.BOMState = 0;
            this.cmb_Articles1.CertState = "";
            this.cmb_Articles1.Comments = null;
            this.cmb_Articles1.CustCode = null;
            this.cmb_Articles1.CustCodeId = 0;
            this.cmb_Articles1.Department = null;
            this.cmb_Articles1.DeptId = 0;
            this.cmb_Articles1.Description = null;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(17, 111);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(316, 19);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 45;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleChanged += new Odin.CMB_Components.Articles.ArticlesEventHandler(this.cmb_Articles1_ArticleChanged);
            // 
            // chk_IsValid
            // 
            this.chk_IsValid.Location = new System.Drawing.Point(17, 193);
            this.chk_IsValid.Name = "chk_IsValid";
            this.chk_IsValid.Size = new System.Drawing.Size(101, 20);
            this.chk_IsValid.TabIndex = 78;
            this.chk_IsValid.Values.Text = "Valid HS Code";
            // 
            // tnvedLabel
            // 
            this.tnvedLabel.Location = new System.Drawing.Point(12, 167);
            this.tnvedLabel.Name = "tnvedLabel";
            this.tnvedLabel.Size = new System.Drawing.Size(61, 20);
            this.tnvedLabel.TabIndex = 28;
            this.tnvedLabel.Values.Text = "HS Code:";
            // 
            // cn_tnved
            // 
            this.cn_tnved.Location = new System.Drawing.Point(143, 167);
            this.cn_tnved.Name = "cn_tnved";
            this.cn_tnved.Size = new System.Drawing.Size(191, 20);
            this.cn_tnved.TabIndex = 27;
            // 
            // commentLabel
            // 
            this.commentLabel.Location = new System.Drawing.Point(12, 218);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(67, 20);
            this.commentLabel.TabIndex = 26;
            this.commentLabel.Values.Text = "Comment:";
            // 
            // cn_comment
            // 
            this.cn_comment.Location = new System.Drawing.Point(143, 218);
            this.cn_comment.Multiline = true;
            this.cn_comment.Name = "cn_comment";
            this.cn_comment.Size = new System.Drawing.Size(191, 54);
            this.cn_comment.TabIndex = 25;
            // 
            // certNumLabel
            // 
            this.certNumLabel.Location = new System.Drawing.Point(12, 142);
            this.certNumLabel.Name = "certNumLabel";
            this.certNumLabel.Size = new System.Drawing.Size(114, 20);
            this.certNumLabel.TabIndex = 24;
            this.certNumLabel.Values.Text = "Certificate number:";
            // 
            // cn_certNum
            // 
            this.cn_certNum.Location = new System.Drawing.Point(143, 142);
            this.cn_certNum.Name = "cn_certNum";
            this.cn_certNum.Size = new System.Drawing.Size(191, 20);
            this.cn_certNum.TabIndex = 23;
            // 
            // cn_dateFrom
            // 
            this.cn_dateFrom.CustomFormat = null;
            this.cn_dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cn_dateFrom.Location = new System.Drawing.Point(87, 23);
            this.cn_dateFrom.Name = "cn_dateFrom";
            this.cn_dateFrom.NullValue = " ";
            this.cn_dateFrom.Size = new System.Drawing.Size(83, 21);
            this.cn_dateFrom.TabIndex = 20;
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.Location = new System.Drawing.Point(12, 23);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(41, 20);
            this.dateFromLabel.TabIndex = 18;
            this.dateFromLabel.Values.Text = "From:";
            // 
            // cn_dateTo
            // 
            this.cn_dateTo.CustomFormat = null;
            this.cn_dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cn_dateTo.Location = new System.Drawing.Point(87, 52);
            this.cn_dateTo.Name = "cn_dateTo";
            this.cn_dateTo.NullValue = " ";
            this.cn_dateTo.Size = new System.Drawing.Size(83, 21);
            this.cn_dateTo.TabIndex = 20;
            // 
            // dateToLabel
            // 
            this.dateToLabel.Location = new System.Drawing.Point(12, 52);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(27, 20);
            this.dateToLabel.TabIndex = 18;
            this.dateToLabel.Values.Text = "To:";
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
            // cn_workDate
            // 
            this.cn_workDate.CustomFormat = null;
            this.cn_workDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cn_workDate.Location = new System.Drawing.Point(87, 78);
            this.cn_workDate.Name = "cn_workDate";
            this.cn_workDate.NullValue = " ";
            this.cn_workDate.Size = new System.Drawing.Size(83, 21);
            this.cn_workDate.TabIndex = 80;
            // 
            // workDateLabel
            // 
            this.workDateLabel.Location = new System.Drawing.Point(12, 78);
            this.workDateLabel.Name = "workDateLabel";
            this.workDateLabel.Size = new System.Drawing.Size(70, 20);
            this.workDateLabel.TabIndex = 79;
            this.workDateLabel.Values.Text = "Work date:";
            // 
            // frm_AddArtCertificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 290);
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
        public CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private CustomControls.NullableDateTimePicker cn_dateFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dateFromLabel;
        private CustomControls.NullableDateTimePicker cn_dateTo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dateToLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel certNumLabel;
        private System.Windows.Forms.TextBox cn_certNum;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel commentLabel;
        private System.Windows.Forms.TextBox cn_comment;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel tnvedLabel;
        private System.Windows.Forms.TextBox cn_tnved;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_IsValid;
        private CustomControls.NullableDateTimePicker cn_workDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel workDateLabel;
    }
}