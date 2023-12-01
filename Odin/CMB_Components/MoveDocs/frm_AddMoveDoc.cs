using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;

namespace Odin.CMB_Components.MoveDocs
{
    public partial class frm_AddMoveDoc : KryptonForm
    {
        public frm_AddMoveDoc()
        {
            InitializeComponent();
        }

        #region Variables 
        DAL_Functions DLL = new DAL_Functions();

        int _id = 0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string MoveDoc
        {
            get { return txt_MoveDoc.Text; }
            set { txt_MoveDoc.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int DestPlaceId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value; }
        }

        public int FinDestPlaceId
        {
            get { return cmb_Firms2.FirmId; }
            set { cmb_Firms2.FirmId = value; }
        }

        public int DelivAddressId
        {
            get { return cmb_Address1.AddressId; }
            set { cmb_Address1.AddressId = value; }
        }

        public int FinDelivAddressId
        {
            get { return cmb_Address2.AddressId; }
            set { cmb_Address2.AddressId = value; }
        }

        public int IncotermsId
        {
            get { return cmb_Incoterms1.IncotermId; }
            set { cmb_Incoterms1.IncotermId = value; }
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
                
        public int TransportId
        {
            get { return cmb_Transport1.TransportId; }
            set { cmb_Transport1.TransportId = value; }
        }

        public int PalettesQty
        {
            get { try { return Convert.ToInt32(txt_PalettesQty.Text); }
                catch { return 0; }
            }
            set { txt_PalettesQty.Text = value.ToString(); }
        }

        public double PalettesWeight
        {
            get
            {
                try { return Convert.ToInt32(txt_PalWeight.Text); }
                catch { return 0; }
            }
            set { txt_PalWeight.Text = value.ToString(); }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public int StageId
        {
            get { return cmb_BatchStages1.StageId; }
            set { cmb_BatchStages1.StageId = value; }
        }

        public double QtyToProduce
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyOfProduct.Text); }
                catch { return 0; }
            }
            set { txt_QtyOfProduct.Text = value.ToString(); }
        }

        public string DelivDate
        {
            get
            {
                if (txt_DelivDate.Value == null)
                    return "";
                else
                    return txt_DelivDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_DelivDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_DelivDate.Value = null; }
            }
        }

        //public string CreditAccount
        //{
        //    get { return txt_CreditAccount.Text; }
        //    set { txt_CreditAccount.Text = value; }
        //}

        //public int IsReturn
        //{
        //    get
        //    {
        //        if (chk_return.Checked == true)
        //            return -1;
        //        else
        //            return 0;
        //    }
        //    set
        //    {
        //        if (value == -1)
        //            chk_return.Checked = true;
        //        else
        //            chk_return.Checked = false;
        //    }
        //}

        #endregion

        #region Methods

        public void FillAutoDoc(int _code)
        {
            MoveDoc = DLL.AutoDoc(_code, System.DateTime.Now.ToShortDateString());
            txt_DelivDate.Value = null;
        }

        #endregion 

        #region Controls

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_MoveDoc.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            cmb_Address1.FirmId = cmb_Firms1.FirmId;
        }

        private void cmb_Firms2_FirmsChanged(object sender)
        {
            cmb_Address2.FirmId = cmb_Firms2.FirmId;
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            bool _test = true;

            string _r = "";

            try
            {
                _r = Convert.ToString(Helper.GetOneRecord("select top 1 name from sto_stockouthead where batchid = " + cmb_Batches1.BatchId + " and batchid != 0 and id != " + Id + "order by id desc "));
            }
            catch { _r = ""; }


            if (_r != "")
            {
                lbl_Check.Text = "You already have movement document for this batch: " + _r;
                lbl_Check.Visible = true;
                //btn_OK.Enabled = false;
                //DialogResult result = KryptonTaskDialog.Show("Document creation warning!",
                //                                                     "Are you want make movement document?",
                //                                                     "You already have movement document for this batch: " + _r,
                //                                                     MessageBoxIcon.Warning,
                //                                                     TaskDialogButtons.Yes |
                //                                                     TaskDialogButtons.No);
                //if (result == DialogResult.Yes)
                //{
                //    _test = true;
                //}
                //else
                //{
                //    _test = false;
                //}
            }
            else
            {
                lbl_Check.Visible = false;
                //btn_OK.Enabled = true;
            }

            //if (_test == true)
            //    cmb_BatchStages1.BatchId = BatchId;
            //else
            //    cmb_Batches1.BatchId = 0;
           
        }


        private void txt_DelivDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DelivDate.Value = txt_DelivDate.Value == null ? System.DateTime.Now : txt_DelivDate.Value;
        }

        #endregion

       
    }
}
