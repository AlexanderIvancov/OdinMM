using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;

namespace Odin.CMB_Components.SalesOrders
{
    public partial class frm_AddSalesOrder : KryptonForm
    {
        public frm_AddSalesOrder()
        {
            InitializeComponent();
        }

        DAL_Functions DLL = new DAL_Functions();


        #region Variables
        public int Id
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string SalesOrder
        {
            get { return txt_SalesOrder.Text; }
            set { txt_SalesOrder.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int CustId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value; }
        }

        public int ContPersId
        {
            get { return cmb_ContactPersons1.ContPersId; }
            set { cmb_ContactPersons1.ContPersId = value; }
        }

        public string Contract
        {
            get { return txt_Contract.Text; }
            set{ txt_Contract.Text = value; }
            
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

        #endregion

        #region Methods

        public void FillAutoDoc(int _code)
        {
            SalesOrder = DLL.AutoDoc(_code, System.DateTime.Now.ToShortDateString());
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = cmb_Firms1.FirmId != 0;
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_SalesOrder.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            cmb_ContactPersons1.FirmId = cmb_Firms1.FirmId;
            CheckEmpty();
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Contract.Text = string.Empty;
        }
    }
}
