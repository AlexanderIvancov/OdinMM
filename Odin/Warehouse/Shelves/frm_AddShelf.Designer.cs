namespace Odin.Warehouse.Shelves
{
    partial class frm_AddShelf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddShelf));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms2 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.chk_Quarantine = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cmb_Address1 = new Odin.CMB_Components.Addresses.cmb_Address();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.chk_IsProduction = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Users1 = new Odin.CMB_Components.Users.cmb_Users();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Department1 = new Odin.CMB_Components.Departments.cmb_Department();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Description = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Place = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chk_Active = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.chk_Active);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.cmb_Firms2);
            this.kryptonPanel1.Controls.Add(this.chk_Quarantine);
            this.kryptonPanel1.Controls.Add(this.cmb_Address1);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.cmb_Firms1);
            this.kryptonPanel1.Controls.Add(this.chk_IsProduction);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.cmb_Users1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.cmb_Department1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.txt_Description);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txt_Place);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(371, 331);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 228);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel7.TabIndex = 32;
            this.kryptonLabel7.Values.Text = "Owner:";
            // 
            // cmb_Firms2
            // 
            this.cmb_Firms2.CountryId = 0;
            this.cmb_Firms2.CountryVAT = 0D;
            this.cmb_Firms2.CurId = 0;
            this.cmb_Firms2.CustIncotermsId = 0;
            this.cmb_Firms2.CustPaymentId = 0;
            this.cmb_Firms2.EnableSearchId = false;
            this.cmb_Firms2.Firm = "";
            this.cmb_Firms2.FirmId = 0;
            this.cmb_Firms2.IsEmptyColor = false;
            this.cmb_Firms2.Location = new System.Drawing.Point(92, 228);
            this.cmb_Firms2.Name = "cmb_Firms2";
            this.cmb_Firms2.Size = new System.Drawing.Size(204, 20);
            this.cmb_Firms2.SupComments = null;
            this.cmb_Firms2.SupIncotermsId = 0;
            this.cmb_Firms2.TabIndex = 31;
            this.cmb_Firms2.VATNr = null;
            // 
            // chk_Quarantine
            // 
            this.chk_Quarantine.Location = new System.Drawing.Point(202, 172);
            this.chk_Quarantine.Name = "chk_Quarantine";
            this.chk_Quarantine.Size = new System.Drawing.Size(84, 20);
            this.chk_Quarantine.TabIndex = 28;
            this.chk_Quarantine.Values.Text = "Quarantine";
            // 
            // cmb_Address1
            // 
            this.cmb_Address1.Address = "";
            this.cmb_Address1.AddressId = 0;
            this.cmb_Address1.DefaultDelivPlace = 0;
            this.cmb_Address1.EnableSearchId = false;
            this.cmb_Address1.FirmId = 0;
            this.cmb_Address1.IsEmptyColor = false;
            this.cmb_Address1.LegalAddress = 0;
            this.cmb_Address1.Location = new System.Drawing.Point(92, 295);
            this.cmb_Address1.Name = "cmb_Address1";
            this.cmb_Address1.Size = new System.Drawing.Size(267, 20);
            this.cmb_Address1.TabIndex = 27;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Location = new System.Drawing.Point(12, 256);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighInternalProfile;
            this.kryptonPanel2.Size = new System.Drawing.Size(347, 5);
            this.kryptonPanel2.TabIndex = 26;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 295);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel6.TabIndex = 25;
            this.kryptonLabel6.Values.Text = "Address:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 268);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel5.TabIndex = 23;
            this.kryptonLabel5.Values.Text = "Company:";
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
            this.cmb_Firms1.Location = new System.Drawing.Point(92, 268);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 22;
            this.cmb_Firms1.VATNr = null;
            this.cmb_Firms1.FirmsChanged += new Odin.CMB_Components.Companies.FirmsEventHandler(this.cmb_Firms1_FirmsChanged);
            // 
            // chk_IsProduction
            // 
            this.chk_IsProduction.Location = new System.Drawing.Point(92, 172);
            this.chk_IsProduction.Name = "chk_IsProduction";
            this.chk_IsProduction.Size = new System.Drawing.Size(83, 20);
            this.chk_IsProduction.TabIndex = 21;
            this.chk_IsProduction.Values.Text = "Production";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 200);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(120, 20);
            this.kryptonLabel4.TabIndex = 20;
            this.kryptonLabel4.Values.Text = "Responsible person:";
            // 
            // cmb_Users1
            // 
            this.cmb_Users1.Location = new System.Drawing.Point(138, 200);
            this.cmb_Users1.Name = "cmb_Users1";
            this.cmb_Users1.Size = new System.Drawing.Size(221, 20);
            this.cmb_Users1.TabIndex = 19;
            this.cmb_Users1.User = "";
            this.cmb_Users1.UserId = 0;
            this.cmb_Users1.UserLogin = null;
            this.cmb_Users1.UserShortName = "";
            this.cmb_Users1.UserTN = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 146);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Department:";
            // 
            // cmb_Department1
            // 
            this.cmb_Department1.Department = "";
            this.cmb_Department1.DeptId = 0;
            this.cmb_Department1.Location = new System.Drawing.Point(92, 146);
            this.cmb_Department1.Name = "cmb_Department1";
            this.cmb_Department1.SelectedNode = null;
            this.cmb_Department1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Department1.TabIndex = 17;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 96);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.Values.Text = "Description:";
            // 
            // txt_Description
            // 
            this.txt_Description.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_Description.Location = new System.Drawing.Point(92, 96);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(267, 44);
            this.txt_Description.TabIndex = 15;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "4B54690540C7404AA09756B32B269B85";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 70);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel1.TabIndex = 14;
            this.kryptonLabel1.Values.Text = "Place:";
            // 
            // txt_Place
            // 
            this.txt_Place.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Place.Location = new System.Drawing.Point(92, 70);
            this.txt_Place.Name = "txt_Place";
            this.txt_Place.Size = new System.Drawing.Size(150, 23);
            this.txt_Place.TabIndex = 13;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "4B54690540C7404AA09756B32B269B85";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(269, 52);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 38);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(269, 12);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // chk_Active
            // 
            this.chk_Active.Checked = true;
            this.chk_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Active.Location = new System.Drawing.Point(92, 44);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(57, 20);
            this.chk_Active.TabIndex = 34;
            this.chk_Active.Values.Text = "Active";
            // 
            // frm_AddShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 331);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddShelf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add stock place";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Place;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Description;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_IsProduction;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private CMB_Components.Users.cmb_Users cmb_Users1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private CMB_Components.Departments.cmb_Department cmb_Department1;
        private CMB_Components.Addresses.cmb_Address cmb_Address1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Quarantine;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private CMB_Components.Companies.cmb_Firms cmb_Firms2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Active;
    }
}