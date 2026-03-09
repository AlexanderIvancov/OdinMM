namespace Odin.CRM
{
    partial class frm_AddCRMCompany
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_Budget = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.txt_Turnover = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chk_SalesPotential = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.txt_SPComments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny11 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.chk_Customer = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_Supplier = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_IsActive = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny10 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_Link = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Link = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny9 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Countries1 = new Odin.CMB_Components.Countries.cmb_Countries();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny6 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Fax = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Phone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Validation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmb_RespManager = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 314);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(529, 59);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(431, 13);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(332, 13);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 34);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.cmb_RespManager);
            this.kryptonPanel2.Controls.Add(this.txt_Budget);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.cmb_Common1);
            this.kryptonPanel2.Controls.Add(this.txt_Turnover);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel2.Controls.Add(this.chk_SalesPotential);
            this.kryptonPanel2.Controls.Add(this.txt_SPComments);
            this.kryptonPanel2.Controls.Add(this.chk_Customer);
            this.kryptonPanel2.Controls.Add(this.chk_Supplier);
            this.kryptonPanel2.Controls.Add(this.chk_IsActive);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.txt_Comments);
            this.kryptonPanel2.Controls.Add(this.txt_Link);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel2.Controls.Add(this.cmb_Countries1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel2.Controls.Add(this.cmb_Firms1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.txt_Email);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.txt_Fax);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.txt_Phone);
            this.kryptonPanel2.Controls.Add(this.btn_Validation);
            this.kryptonPanel2.Controls.Add(this.lbl_Name);
            this.kryptonPanel2.Controls.Add(this.txt_Name);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel2.Size = new System.Drawing.Size(529, 314);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // txt_Budget
            // 
            this.txt_Budget.AllowDecimalSeparator = true;
            this.txt_Budget.AllowSpace = false;
            this.txt_Budget.Location = new System.Drawing.Point(323, 254);
            this.txt_Budget.Name = "txt_Budget";
            this.txt_Budget.Size = new System.Drawing.Size(87, 23);
            this.txt_Budget.TabIndex = 54;
            this.txt_Budget.Text = "0";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(184, 254);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(133, 20);
            this.kryptonLabel2.TabIndex = 53;
            this.kryptonLabel2.Values.Text = "Budget for electronics:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 41);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel1.TabIndex = 52;
            this.kryptonLabel1.Values.Text = "State:";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(86, 41);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "id";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(148, 20);
            this.cmb_Common1.sTable = "BAS_CRMState";
            this.cmb_Common1.sText_Filled = "state";
            this.cmb_Common1.sTitle = "CRM state";
            this.cmb_Common1.TabIndex = 51;
            // 
            // txt_Turnover
            // 
            this.txt_Turnover.AllowDecimalSeparator = true;
            this.txt_Turnover.AllowSpace = false;
            this.txt_Turnover.Location = new System.Drawing.Point(86, 254);
            this.txt_Turnover.Name = "txt_Turnover";
            this.txt_Turnover.Size = new System.Drawing.Size(87, 23);
            this.txt_Turnover.TabIndex = 50;
            this.txt_Turnover.Text = "0";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(12, 254);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel14.TabIndex = 49;
            this.kryptonLabel14.Values.Text = "Turnover:";
            // 
            // chk_SalesPotential
            // 
            this.chk_SalesPotential.Location = new System.Drawing.Point(12, 225);
            this.chk_SalesPotential.Name = "chk_SalesPotential";
            this.chk_SalesPotential.Size = new System.Drawing.Size(106, 20);
            this.chk_SalesPotential.TabIndex = 48;
            this.chk_SalesPotential.Values.Text = "Sales potential:";
            // 
            // txt_SPComments
            // 
            this.txt_SPComments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny11});
            this.txt_SPComments.Location = new System.Drawing.Point(124, 225);
            this.txt_SPComments.Name = "txt_SPComments";
            this.txt_SPComments.Size = new System.Drawing.Size(397, 23);
            this.txt_SPComments.TabIndex = 47;
            // 
            // buttonSpecAny11
            // 
            this.buttonSpecAny11.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny11.UniqueName = "0A0081F22486475415BE69C7CDFDA743";
            // 
            // chk_Customer
            // 
            this.chk_Customer.Checked = true;
            this.chk_Customer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Customer.Location = new System.Drawing.Point(297, 127);
            this.chk_Customer.Name = "chk_Customer";
            this.chk_Customer.Size = new System.Drawing.Size(76, 20);
            this.chk_Customer.TabIndex = 42;
            this.chk_Customer.Values.Text = "Customer";
            // 
            // chk_Supplier
            // 
            this.chk_Supplier.Location = new System.Drawing.Point(394, 127);
            this.chk_Supplier.Name = "chk_Supplier";
            this.chk_Supplier.Size = new System.Drawing.Size(68, 20);
            this.chk_Supplier.TabIndex = 41;
            this.chk_Supplier.Values.Text = "Supplier";
            // 
            // chk_IsActive
            // 
            this.chk_IsActive.Checked = true;
            this.chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_IsActive.Location = new System.Drawing.Point(442, 12);
            this.chk_IsActive.Name = "chk_IsActive";
            this.chk_IsActive.Size = new System.Drawing.Size(57, 20);
            this.chk_IsActive.TabIndex = 32;
            this.chk_IsActive.Values.Text = "Active";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(12, 183);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel10.TabIndex = 23;
            this.kryptonLabel10.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny10});
            this.txt_Comments.Location = new System.Drawing.Point(86, 183);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(435, 36);
            this.txt_Comments.TabIndex = 22;
            // 
            // buttonSpecAny10
            // 
            this.buttonSpecAny10.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny10.UniqueName = "0A0081F22486475415BE69C7CDFDA743";
            this.buttonSpecAny10.Click += new System.EventHandler(this.buttonSpecAny10_Click);
            // 
            // txt_Link
            // 
            this.txt_Link.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Link,
            this.buttonSpecAny9});
            this.txt_Link.Location = new System.Drawing.Point(86, 153);
            this.txt_Link.Name = "txt_Link";
            this.txt_Link.Size = new System.Drawing.Size(435, 24);
            this.txt_Link.TabIndex = 21;
            this.txt_Link.Text = "http://";
            // 
            // btn_Link
            // 
            this.btn_Link.Image = global::Odin.Global_Resourses.domain_template;
            this.btn_Link.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight;
            this.btn_Link.UniqueName = "4807859833CE431C9DA671C4E3C5342F";
            this.btn_Link.Click += new System.EventHandler(this.btn_Link_Click);
            // 
            // buttonSpecAny9
            // 
            this.buttonSpecAny9.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny9.UniqueName = "503F499952AF4AD38B95C5B5702DB45E";
            this.buttonSpecAny9.Click += new System.EventHandler(this.buttonSpecAny9_Click);
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(12, 153);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel9.TabIndex = 20;
            this.kryptonLabel9.Values.Text = "Web:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(238, 98);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel8.TabIndex = 18;
            this.kryptonLabel8.Values.Text = "Country:";
            // 
            // cmb_Countries1
            // 
            this.cmb_Countries1.Country = "";
            this.cmb_Countries1.CountryId = 0;
            this.cmb_Countries1.EnableSearchId = false;
            this.cmb_Countries1.Location = new System.Drawing.Point(297, 98);
            this.cmb_Countries1.Name = "cmb_Countries1";
            this.cmb_Countries1.Size = new System.Drawing.Size(128, 20);
            this.cmb_Countries1.TabIndex = 17;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 124);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel7.TabIndex = 16;
            this.kryptonLabel7.Values.Text = "Parent:";
            // 
            // cmb_Firms1
            // 
            this.cmb_Firms1.CountryId = 0;
            this.cmb_Firms1.CountryVAT = 0D;
            this.cmb_Firms1.CurId = 0;
            this.cmb_Firms1.CustIncotermsId = 0;
            this.cmb_Firms1.CustPaymentId = 0;
            this.cmb_Firms1.EnableSearchId = false;
            this.cmb_Firms1.Firm = "";
            this.cmb_Firms1.FirmId = 0;
            this.cmb_Firms1.IsEmptyColor = false;
            this.cmb_Firms1.Location = new System.Drawing.Point(86, 124);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(191, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 15;
            this.cmb_Firms1.VATNr = null;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 98);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel5.TabIndex = 12;
            this.kryptonLabel5.Values.Text = "E-mail:";
            // 
            // txt_Email
            // 
            this.txt_Email.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny6});
            this.txt_Email.Location = new System.Drawing.Point(86, 98);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(142, 23);
            this.txt_Email.TabIndex = 11;
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny6.UniqueName = "0A0081F22486475415BE69C7CDFDA743";
            this.buttonSpecAny6.Click += new System.EventHandler(this.buttonSpecAny6_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(236, 72);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(31, 20);
            this.kryptonLabel4.TabIndex = 10;
            this.kryptonLabel4.Values.Text = "Fax:";
            // 
            // txt_Fax
            // 
            this.txt_Fax.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_Fax.Location = new System.Drawing.Point(283, 72);
            this.txt_Fax.Name = "txt_Fax";
            this.txt_Fax.Size = new System.Drawing.Size(142, 23);
            this.txt_Fax.TabIndex = 9;
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny5.UniqueName = "0A0081F22486475415BE69C7CDFDA743";
            this.buttonSpecAny5.Click += new System.EventHandler(this.buttonSpecAny5_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 72);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Phone:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_Phone.Location = new System.Drawing.Point(86, 72);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(142, 23);
            this.txt_Phone.TabIndex = 7;
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny4.UniqueName = "0A0081F22486475415BE69C7CDFDA743";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // btn_Validation
            // 
            this.btn_Validation.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Validation.Location = new System.Drawing.Point(283, 35);
            this.btn_Validation.Name = "btn_Validation";
            this.btn_Validation.Size = new System.Drawing.Size(90, 31);
            this.btn_Validation.TabIndex = 6;
            this.btn_Validation.Values.Image = global::Odin.Global_Resourses.Question_point16x16;
            this.btn_Validation.Values.Text = "Validation";
            this.btn_Validation.Click += new System.EventHandler(this.btn_Validation_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(12, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(46, 20);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Values.Text = "Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Name.Location = new System.Drawing.Point(86, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(339, 23);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "0A0081F22486475415BE69C7CDFDA743";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // cmb_RespManager
            // 
            this.cmb_RespManager.IsEmptyColor = false;
            this.cmb_RespManager.Location = new System.Drawing.Point(148, 283);
            this.cmb_RespManager.Name = "cmb_RespManager";
            this.cmb_RespManager.OrderBy = "id";
            this.cmb_RespManager.sCurrentValue = "";
            this.cmb_RespManager.SelectedValue = 0;
            this.cmb_RespManager.sID_Filled = "id";
            this.cmb_RespManager.Size = new System.Drawing.Size(231, 20);
            this.cmb_RespManager.sTable = "vw_CRMManagers";
            this.cmb_RespManager.sText_Filled = "crmmanager";
            this.cmb_RespManager.sTitle = "Responsible manager";
            this.cmb_RespManager.TabIndex = 55;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 283);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(130, 20);
            this.kryptonLabel6.TabIndex = 56;
            this.kryptonLabel6.Values.Text = "Responsible manager:";
            // 
            // frm_AddCRMCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 373);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_AddCRMCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add company";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Name;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Validation;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Link;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Link;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private CMB_Components.Countries.cmb_Countries cmb_Countries1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Email;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Fax;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Phone;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_IsActive;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Customer;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Supplier;
        private Owf.Controls.NumericTetxBox txt_Turnover;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_SalesPotential;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_SPComments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private Owf.Controls.NumericTetxBox txt_Budget;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CMB_Components.Common.cmb_Common cmb_RespManager;
    }
}