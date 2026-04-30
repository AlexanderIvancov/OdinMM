using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;

namespace Odin.CRM
{
    public partial class frm_AddCRMCompany : KryptonForm
    {
        public frm_AddCRMCompany()
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

        public string SPComments
        {
            get { return txt_SPComments.Text; }
            set { txt_SPComments.Text = value; }
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

        #endregion

        #region Methods

        public void CheckEmpty()
        {
            if (CompanyName == ""
                && RegNR == ""
                && VAT == ""
               )
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
        
    }
}
