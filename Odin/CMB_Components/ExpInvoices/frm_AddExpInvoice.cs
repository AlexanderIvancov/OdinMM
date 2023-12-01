using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.ExpInvoices
{
    public delegate void ExportInvoiceSavingEventHandler(object sender);
    public partial class frm_AddExpInvoice : KryptonForm
    {
        public frm_AddExpInvoice()
        {
            InitializeComponent();
        }

        DAL_Functions DLL = new DAL_Functions();

        public ExportInvoiceSavingEventHandler ExportInvoiceSaving;

        #region Variables

        public int Id
        { get; set; }

        bool _isedit = false;

        public bool IsEdit
        {
            get { return _isedit; }
            set { _isedit = value;

                gp_Type.Enabled = _isedit != true;
            }
        }

        public int InvoiceType
        {
            get {
                return rb_Invoice.Checked == true ? 3 : rb_CreditNote.Checked == true ? 5 : 13;
            }

            set { if (value == 3)
                    rb_Invoice.Checked = true;
                else if (value == 5)
                    rb_CreditNote.Checked = true;
                else
                    rb_Advanced.Checked = true;
            }
        }

        public int InvCode
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Invoice
        {
            get { return txt_Invoice.Text; }
            set { txt_Invoice.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int ReceiverId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value; }
        }
        public int ReceiverAddressId
        {
            get { return cmb_Address1.AddressId; }
            set { cmb_Address1.AddressId = value; }
        }

        public int BuyerId
        {
            get { return cmb_Firms2.FirmId; }
            set { cmb_Firms2.FirmId = value; }
        }

        public int BuyerAddressId
        {
            get { return cmb_Address2.AddressId; }
            set { cmb_Address2.AddressId = value; }
        }

        public int SenderAddressId
        {
            get { return cmb_SenderAddress.SelectedValue; }
            set { cmb_SenderAddress.SelectedValue = value; }
        }

        public string Serie
        {
            get { return txt_Serie.Text; }
            set { txt_Serie.Text = value; }

        }

        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        public int IncotermsId
        {
            get { return cmb_Incoterms1.IncotermId; }
            set { cmb_Incoterms1.IncotermId = value; }
        }

        public double CurRate
        {
            get
            {
                try { return Convert.ToDouble(txt_CurRate.Text); }
                catch { return 1; }
            }
            set { txt_CurRate.Text = value.ToString(); }
        }

        public double InAdvance
        {
            get
            {
                try { return Convert.ToDouble(txt_InAdvance.Text); }
                catch { return 0; }
            }
            set { txt_InAdvance.Text = value.ToString(); }
        }

        public string StampDate
        {
            get { return txt_StampDate.Value.ToShortDateString(); }
            set
            {
                try { txt_StampDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string PayBefore
        {
            get
            {
                return txt_PayBefore.Value == null ? "" : txt_PayBefore.Value.ToString();
            }
            set
            {
                try
                {
                    txt_PayBefore.Value = Convert.ToDateTime(value);
                }
                catch { txt_PayBefore.Value = null; }
            }
        }

        public string PayDate
        {
            get
            {
                return txt_PayDate.Value == null ? "" : txt_PayDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_PayDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_PayDate.Value = null; }
            }
        }

        public string DocDate
        {
            get { return txt_DocDate.Value.ToShortDateString(); }
            set
            {
                try { txt_DocDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string Bargain
        {
            get { return cmb_Bargain1.BargainCode; }
            set { cmb_Bargain1.BargainCode = value; }
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

        public int AssetId
        {
            get { return cmb_Asset.SelectedValue; }
            set { cmb_Asset.SelectedValue = value; }
        }

        public string Payment
        {
            get { return cmb_Payterms1.Payterms; }
            set { cmb_Payterms1.Payterms = value; }
        }

        public int PaymentId
        {
            get { return cmb_Payterms1.PaytermsId; }
            set { cmb_Payterms1.PaytermsId = value; }
        }

        public string PlaceOfLoading
        {
            get { return cmb_PlaceOfLoading.sCurrentValue; }
            set { cmb_PlaceOfLoading.sCurrentValue = value; }
        }

        public double VAT
        {
            get { try { return Convert.ToInt32(txt_VAT.Text); }
                catch { return 0; } }
            set { txt_VAT.Text = value.ToString();}
        }

        public string AdvanceDate
        {
            get
            {
                return txt_AdvanceDate.Value == null ? "" : txt_AdvanceDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_AdvanceDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_AdvanceDate.Value = null; }
            }
        }

        public string ProformaNR
        {
            get { return txt_ProformaNR.Text; }
            set { txt_ProformaNR.Text = value; }
        }

        public int SellerContPersId
        {
            get { return cmb_ContactPersons1.ContPersId; }
            set { cmb_ContactPersons1.ContPersId = value; }
        }

        public int BuyerContPersId
        {
            get { return cmb_ContactPersons2.ContPersId; }
            set { cmb_ContactPersons2.ContPersId = value; }
        }

        public int ValueForCustoms
        {
            get {
                return chk_ValueForCustoms.Checked == true ? -1 : 0;
            }
            set {
                chk_ValueForCustoms.Checked = value == -1;
            }
        }

        public int ESignature
        {
            get
            {
                return chk_esignature.Checked == true ? -1 : 0;
            }
            set
            {
                chk_esignature.Checked = value == -1;
            }
        }

        public string Recipient
        {
            get { return txt_Recipient.Text; }
            set { txt_Recipient.Text = value; }
        }

        #endregion

        #region Methods

        public void CheckEmpty()
        {
            cmb_Firms1.IsEmptyColor = cmb_Firms1.FirmId == 0;
            cmb_Firms2.IsEmptyColor = cmb_Firms2.FirmId == 0;
            cmb_Address1.IsEmptyColor = cmb_Address1.AddressId == 0;
            cmb_Address2.IsEmptyColor = cmb_Address2.AddressId == 0;
            cmb_Incoterms1.IsEmptyColor = cmb_Incoterms1.IncotermId == 0;
            cmb_Bargain1.IsEmptyColor = cmb_Bargain1.BargainCode == ""
                || String.IsNullOrEmpty(cmb_Bargain1.Bargain) == true;
            cmb_BankCont.IsEmptyColor = cmb_BankCont.SelectedValue == 0;
            cmb_Asset.IsEmptyColor = cmb_Asset.SelectedValue == 0;
            cmb_PlaceOfLoading.IsEmptyColor = cmb_PlaceOfLoading.SelectedValue == 0;


            btn_OK.ThreadSafeCall(delegate {
                btn_OK.Enabled = ReceiverId != 0
                    && CurId != 0
                    && Invoice != ""
                    && string.IsNullOrEmpty(Invoice) != true
                    && BankContId != 0;
            });
        }

        public bool IsEmptyFields()
        {
            bool _test = true;

            if (cmb_Firms1.FirmId == 0
                || cmb_Firms2.FirmId == 0
                || cmb_Address1.AddressId == 0
                || cmb_Address2.AddressId == 0
                || cmb_Incoterms1.IncotermId == 0
                || (cmb_Bargain1.BargainCode == ""
                || String.IsNullOrEmpty(cmb_Bargain1.Bargain) == true)
                || cmb_BankCont.SelectedValue == 0
                || cmb_Asset.SelectedValue == 0
                ||
                cmb_PlaceOfLoading.SelectedValue == 0)
                _test = false;

            return _test;
        }
        public void FillDates()
        {
            txt_DocDate.Value = System.DateTime.Now;
            txt_StampDate.Value = System.DateTime.Now;
            txt_PayBefore.Value = System.DateTime.Now.AddDays(14); //2 weeks
            txt_AdvanceDate.Value = null;
            txt_PayDate.Value = System.DateTime.Now;
        }

        public void FillDoc()
        {
            
            InvCode = InvoiceType == 3 ? 11 : InvoiceType == 5 ? 12 : 13;

            Invoice = InvoiceType != 5 ? DLL.AutoDoc(InvCode, System.DateTime.Now.ToShortDateString()) : "";
        }

        public void FillSellerContPersons()
        {
            cmb_ContactPersons1.FirmId = DLL.CurrentCompanyId();
        }

        #endregion

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Serie.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CurRate.Text = "1";
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            CurId = cmb_Firms1.CurId;
            IncotermsId = cmb_Firms1.CustIncotermsId;
            CheckEmpty();
            cmb_Address1.FirmId = cmb_Firms1.FirmId;
            cmb_Address1.DefaultDelivPlace = -1;
            //PaymentId = cmb_Firms1.CustPaymentId;
            
        }

        private void cmb_Firms2_FirmsChanged(object sender)
        {
            cmb_Address2.FirmId = cmb_Firms2.FirmId;
            cmb_Address2.DefaultDelivPlace = -1;
            VAT = cmb_Firms2.CountryVAT;
            cmb_ContactPersons2.FirmId = cmb_Firms2.FirmId;
            cmb_ContactPersons2.ContPersId = 0;
            CheckEmpty();
        }

        private void cmb_Currency1_CurrencyChanged(object sender)
        {
            txt_CurRate.ThreadSafeCall(delegate
            {
                DLL.ShowCurRate(CurId, DocDate);
                CurRate = DLL.CurRate;
            });

            CheckEmpty();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            ReceiverId = BuyerId;
            ReceiverAddressId = BuyerAddressId;
        }

        private void rb_Invoice_CheckedChanged(object sender, EventArgs e)
        {
            if (Id == 0)
                FillDoc();
        }

        private void rb_Advanced_CheckedChanged(object sender, EventArgs e)
        {
            if (Id == 0)
                FillDoc();
        }

        private void rb_CreditNote_CheckedChanged(object sender, EventArgs e)
        {
            if (Id == 0)
                FillDoc();
        }

        private void txt_Invoice_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_PayBefore.Value = System.DateTime.Now;
        }

        private void cmb_Address1_AddressChanged(object sender)
        {
            CheckEmpty();//MessageBox.Show("Address1: " + cmb_Address1.AddressId.ToString());
        }

        private void cmb_Address2_AddressChanged(object sender)
        {
            CheckEmpty();// MessageBox.Show("Address2: " + cmb_Address2.AddressId.ToString());
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            txt_AdvanceDate.Value = System.DateTime.Now;
        }

        private void buttonSpecAny8_Click(object sender, EventArgs e)
        {
            txt_ProformaNR.Text = string.Empty;
        }

        private void buttonSpecAny9_Click(object sender, EventArgs e)
        {
            txt_PayDate.Value = System.DateTime.Now;
        }

        private void txt_PayBefore_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_PayBefore.Value = txt_PayBefore.Value == null ? System.DateTime.Now : txt_PayBefore.Value;
        }

        private void txt_AdvanceDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_AdvanceDate.Value = txt_AdvanceDate.Value == null ? System.DateTime.Now : txt_AdvanceDate.Value;
        }

        private void cmb_BankCont_SelectedValueChanged(object sender)
        {
            CheckEmpty();
        }

        private void cmb_Incoterms1_IncotermsChanged(object sender)
        {
            CheckEmpty();
        }

        private void cmb_Bargain1_BargainChanged(object sender)
        {
            CheckEmpty();
        }

        private void cmb_Asset_SelectedValueChanged(object sender)
        {
            CheckEmpty();
        }

        private void cmb_PlaceOfLoading_SelectedValueChanged(object sender)
        {
            CheckEmpty();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (IsEmptyFields() == false)
            {
                DialogResult result = MessageBox.Show("Are you sure you want register invoice?", "You have empty fields!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    ExportInvoiceSaving?.Invoke(this);
            }
            else
                ExportInvoiceSaving?.Invoke(this);
        }

        private void buttonSpecAny10_Click(object sender, EventArgs e)
        {
            txt_Recipient.Text = string.Empty;
        }
    }
}
