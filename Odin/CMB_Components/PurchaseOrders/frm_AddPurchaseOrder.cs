using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;


namespace Odin.CMB_Components.PurchaseOrders
{
    public partial class frm_AddPurchaseOrder : KryptonForm
    {
        public frm_AddPurchaseOrder()
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

        public string PurchaseOrder
        {
            get { return txt_PurchaseOrder.Text; }
            set { txt_PurchaseOrder.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int SupId
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
            set { txt_Contract.Text = value; }

        }

        public int DelivPlaceId
        {
            get { return cmb_Firms2.FirmId; }
            set { cmb_Firms2.FirmId = value; }
        }

        public int DelivAddressId
        {
            get { return cmb_Address1.AddressId; }
            set { cmb_Address1.AddressId = value; }
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

        public int InProcess
        {
            get { if (chk_processing.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set {
                if (value == -1)
                    chk_processing.CheckState = CheckState.Checked;
                else
                    chk_processing.CheckState = CheckState.Unchecked;
            }
        }
        #endregion

        #region Methods

        public void FillAutoDoc(int _code)
        {
            PurchaseOrder = DLL.AutoDoc(_code, System.DateTime.Now.ToShortDateString());
        }

        public void CheckEmpty()
        {
            if (cmb_Firms1.FirmId == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        private void cmb_Firms2_FirmsChanged(object sender)
        {
            cmb_Address1.FirmId = cmb_Firms2.FirmId;
        }


        #endregion

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Contract.Text = string.Empty;
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            cmb_ContactPersons1.FirmId = cmb_Firms1.FirmId;
            CurId = cmb_Firms1.CurId;
            //MessageBox.Show(cmb_Firms1.SupIncotermsId.ToString());
            IncotermsId = cmb_Firms1.SupIncotermsId;
            Comments = cmb_Firms1.SupComments;
            CheckEmpty();
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_PurchaseOrder.Text = string.Empty;
        }
    }
}
