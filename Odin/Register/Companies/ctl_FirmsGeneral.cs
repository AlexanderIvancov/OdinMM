using System;
using System.Windows.Forms;

namespace Odin.Register.Companies
{
    public delegate void FirmsIdSendingEventHandler(object sender);

    public partial class ctl_FirmsGeneral : UserControl
    {
        public ctl_FirmsGeneral()
        {
            InitializeComponent();
            frm_Companies.ReceiveId += new ReceiveFirmId(RetFirmId);
        }

        public event FirmsIdSendingEventHandler SendFirmId;

        #region Variables

        Reg_BLL Reg = new Reg_BLL();

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        int _firmid = 0;

        public int FirmId
        {
            get { return _firmid; }
            set
            {
                _firmid = value;
                Reg.FirmId = _firmid;
                FirmName = Reg.Company;
                VAT = Reg.VAT;
                RegNR = Reg.RegNR;
                Phone = Reg.Phone;
                Fax = Reg.Fax;
                Email = Reg.Email;
                WebLink = Reg.WebAddress;
                CountryId = Reg.CountryId;
                ParentId = Reg.ParentId;
                Comments = Reg.FirmCommments;
                SupMark = Reg.SupMark;
                CustMark = Reg.CustMark;
                SupPayment = Reg.SupPayment;
                CustPayment = Reg.CustPayment;
                SupIncoterms = Reg.SupIncoterms;
                CustIncoterms = Reg.CustIncoterms;
                IsActive = Reg.CompanyIsActive;
                OneC = Reg.OneC;
                SupComments = Reg.SupComments;
                CustPayTerms = Reg.CustPayTerms;
                TransportId = Reg.TransportId;
                BankContId = Reg.BankContId;
            }
        }

        public int RetFirmId()
        {
            return FirmId;
        }

        public int IsActive
        {
            get
            {
                return chk_IsActive.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_IsActive.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

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
            set { cmb_Firms1.FirmId = value; }
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

        public string SupComments
        {
            get { return txt_SupComments.Text; }
            set { txt_SupComments.Text = value; }
        }

        public string WebLink
        {
            get { return txt_Link.Text; }
            set { txt_Link.Text = value; }
        }

        public int SupMark
        {
            get
            {
                return chk_Supplier.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_Supplier.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int CustMark
        {
            get
            {
                return chk_Customer.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_Customer.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
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

        public string OneC
        {
            get { return txt_1C.Text; }
            set { txt_1C.Text = value; }
        }

        public int CustPayTerms
        {
            get
            {
                try { return Convert.ToInt32(txt_CustPayTerms.Text); }
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

        public void CheckEmpty()
        {
            btn_OK.Enabled = FirmName != ""
                && RegNR != ""
                && VAT != "";
        }

        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Reg.SaveCompany(FirmId, FirmName, RegNR, VAT, Phone, Fax, Email, ParentId, CountryId, WebLink,
                            Comments, SupMark, CustMark, SupPayment, CustPayment, SupIncoterms, CustIncoterms,
                            IsActive, OneC, SupComments, CustPayTerms, TransportId, BankContId);

            if (SendFirmId != null)
            {
                SendFirmId(this);
            }
        }

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

        private void btn_Validation_Click(object sender, EventArgs e)
        {

        }
    }
}
