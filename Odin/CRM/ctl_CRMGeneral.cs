using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Register;
namespace Odin.CRM
{
    public delegate void FirmsIdSendingEventHandler(object sender);

    public partial class ctl_CRMGeneral : UserControl
    {
        public ctl_CRMGeneral()
        {
            InitializeComponent();
            frm_CRMCompanies.ReceiveId += new ReceiveFirmId(RetFirmId);
        }

        public event FirmsIdSendingEventHandler SendFirmId;

        #region Variables

        CRM_BLL CRMBll = new CRM_BLL();
        //Reg_BLL Reg = new Reg_BLL();
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        int _firmid = 0;

        public int FirmId
        {
            get { return _firmid; }
            set { _firmid = value;
                CRMBll.FirmId = _firmid;
                FirmName = CRMBll.Company;
                Phone = CRMBll.Phone;
                Fax = CRMBll.Fax;
                Email = CRMBll.Email;
                WebLink = CRMBll.WebAddress;
                CountryId = CRMBll.CountryId;
                ParentId = CRMBll.ParentId;
                Comments = CRMBll.CRMComments;
                SupMark = CRMBll.SupMark;
                CustMark = CRMBll.CustMark;
                IsActive = CRMBll.CompanyIsActive;
                SPComments = CRMBll.SPComments;
                CRMState = CRMBll.CRMState;
                Turnover = CRMBll.Turnover;
                SalesPotential = CRMBll.SalesPotential;
                Budget = CRMBll.Budget;
                CRMManager = CRMBll.CRMManager;
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

        public string FirmName
        {
            get { return txt_Name.Text; }
            set { txt_Name.Text = value; }
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

        public string SPComments
        {
            get { return txt_SPComments.Text; }
            set { txt_SPComments.Text = value; }
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
                if (chk_Supplier.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
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

        public int SalesPotential
        {
            get
            {
                if (chk_SalesPotential.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_SalesPotential.CheckState = CheckState.Checked;
                else
                    chk_SalesPotential.CheckState = CheckState.Unchecked;
            }
        }      


        public double Turnover
        {
            get { return Convert.ToDouble(txt_Turnover.Text); }
            set { txt_Turnover.Text = value.ToString(); }
        }

        public int CRMState
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }

        public double Budget
        {
            get { return Convert.ToDouble(txt_Budget.Text); }
            set { txt_Budget.Text = value.ToString(); }
        }

        public string CRMManager
        {
            get { return cmb_RespManager.sCurrentValue; }
            set { cmb_RespManager.sCurrentValue = value; }
        }

        #endregion

        #region Controls

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Name.Text = string.Empty;
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
            if (FirmName == ""
              )
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }


        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            CRMBll.SaveCRMCompany(FirmId, FirmName, Phone, Fax, Email, ParentId, CountryId,
                                            WebLink, SupMark, CustMark, IsActive, Turnover, CRMState,Comments,
                                           SalesPotential, SPComments, Budget, CRMManager);
            //Reg.SaveCompany(FirmId, FirmName, RegNR, VAT, Phone, Fax, Email, ParentId, CountryId, WebLink,
            //                Comments, SupMark, CustMark, SupPayment, CustPayment, SupIncoterms, CustIncoterms,
            //                IsActive, OneC, SupComments, CustPayTerms, TransportId, BankContId);

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

       
        private void buttonSpecAny11_Click(object sender, EventArgs e)
        {
            txt_SPComments.Text = string.Empty;
        }

        private void btn_Validation_Click(object sender, EventArgs e)
        {

        }
    }
}
