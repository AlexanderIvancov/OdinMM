using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Register.Companies
{
    public partial class frm_AddCompany : KryptonForm
    {
        public frm_AddCompany()
        {
            InitializeComponent();
        }

        #region Variables
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public int Id
        { get; set; }
        public string FirmName
        {
            get { return txt_Name.Text; }
            set { txt_Name.Text = value; }
        }

        public string RegNR
        {
            get { return txt_RegNR.Text; }
            set { txt_RegNR.Text = value; }
        }

        public string VAT
        {
            get { return txt_VAT.Text; }
            set { txt_VAT.Text = value; }
        }
        public string Phone
        {
            get { return txt_Phone.Text; }
            set { txt_Phone.Text = value; }
        }
        public string Fax
        {
            get { return txt_Fax.Text; }
            set { txt_Fax.Text = value; }
        }
        public string Email
        {
            get { return txt_Email.Text; }
            set { txt_Email.Text = value; }
        }
               

        public int ParentId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value;}
        }
        public int CountryId
        {
            get { return cmb_Countries1.CountryId; }
            set { cmb_Countries1.CountryId = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string WebLink
        {
            get { return txt_Link.Text; }
            set { txt_Link.Text = value; }
        }

        public int SupMark
        {
            get {
                if (chk_Supplier.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set { if (value == -1)
                    chk_Supplier.CheckState = CheckState.Checked;
                else
                    chk_Supplier.CheckState = CheckState.Unchecked;
            }
        }

        public int CustMark
        {
            get
            {
                if (chk_Customer.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Customer.CheckState = CheckState.Checked;
                else
                    chk_Customer.CheckState = CheckState.Unchecked;
            }
        }

        public int SupPayment
        {
            get { return cmb_PaytermsSup.PaytermsId; }
            set { cmb_PaytermsSup.PaytermsId = value; }
        }

        public int CustPayment
        {
            get { return cmb_PaytermsCust.PaytermsId; }
            set { cmb_PaytermsCust.PaytermsId = value; }
        }

        public int SupIncoterms
        {
            get { return cmb_IncotermsSup.IncotermId; }
            set { cmb_IncotermsSup.IncotermId = value; }
            
        }

        public int CustIncoterms
        {
            get { return cmb_IncotermsCust.IncotermId; }
            set { cmb_IncotermsCust.IncotermId = value; }

        }

        public int IsActive
        {
            get
            {
                if (chk_IsActive.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_IsActive.CheckState = CheckState.Checked;
                else
                    chk_IsActive.CheckState = CheckState.Unchecked;
            }
        }

        public string OneC
        {
            get { return txt_1C.Text; }
            set { txt_1C.Text = value; }
        }

        public string SupComments
        {
            get { return txt_SupComments.Text; }
            set { txt_SupComments.Text = value; }
        }

        public int CustPayTerms
        {
            get { try { return Convert.ToInt32(txt_CustPayTerms.Text); }
                catch { return 0; }
            }
            set { txt_CustPayTerms.Text = value.ToString(); }
        }
        public int TransportId
        {
            get { return cmb_Transport1.TransportId; }
            set { cmb_Transport1.TransportId = value; }
        }

        public int BankContId
        {
            get { return cmb_BankCont.SelectedValue; }
            set { cmb_BankCont.SelectedValue = value; }
        }
        #endregion


        #region Methods

        public void CheckEmpty()
        {
            if (CompanyName == ""
                || RegNR == ""
                || VAT == "")
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        #endregion

        #region Controls

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Name.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_VAT.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_RegNR.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Phone.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_Fax.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_Email.Text = string.Empty;
        }
        private void buttonSpecAny9_Click(object sender, EventArgs e)
        {
            txt_Link.Text = "http://";
        }

        private void buttonSpecAny10_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void btn_Validation_Click(object sender, EventArgs e)
        {

        }

        private void btn_Link_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(WebLink);
            }
            catch { }
        }


        #endregion

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_RegNR_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_VAT_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            txt_1C.Text = string.Empty;
        }

        private void buttonSpecAny11_Click(object sender, EventArgs e)
        {
            txt_SupComments.Text = string.Empty;
        }
    }
}
