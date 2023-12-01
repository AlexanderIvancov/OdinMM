using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Drawing;

namespace Odin.CMB_Components.IncomeDocs
{
    public partial class frm_AddIncomeDoc : KryptonForm
    {
        public frm_AddIncomeDoc()
        {
            InitializeComponent();
        }

        DAL_Functions DLL = new DAL_Functions();
        class_Global glob_Class = new class_Global();

        #region Variables
        int _id = 0;
        public int Id
        { get { return _id; }
            set { _id = value; } }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string IncomeDoc
        {
            get { return txt_IncomeDoc.Text; }
            set { txt_IncomeDoc.Text = value; }
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
            get { try { return Convert.ToDouble(txt_CurRate.Text); }
                catch { return 1; } }
            set { txt_CurRate.Text = value.ToString(); }
        }

        public string RegDate
        {
            get
            {
                if (txt_RegDate.Value == null)
                    return "";
                else
                    return txt_RegDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_RegDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_RegDate.Value = null; }
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
            get { return cmb_Common1.sCurrentValue; }
            set { cmb_Common1.sCurrentValue = value; }
        }

        public int ProducerCountryId
        {
            get { return cmb_Countries1.CountryId; }
            set { cmb_Countries1.CountryId = value; }
        }

        public int SenderCountryId
        {
            get { return cmb_Countries2.CountryId; }
            set { cmb_Countries2.CountryId = value; }
        }

        public int TransportId
        {
            get { return cmb_Transport1.TransportId; }
            set { cmb_Transport1.TransportId = value; }
        }

        public double AdditCost
        {
            get {
                try { return Convert.ToDouble(txt_AdditCost.Text); }
                catch { return 0; }
            }
            set{ txt_AdditCost.Text = value.ToString(); }
            
        }

        public double Advance
        {
            get
            {
                try { return Convert.ToDouble(txt_Advance.Text); }
                catch { return 0; }
            }
            set { txt_Advance.Text = value.ToString(); }

        }

        public string AdvanceDate
        {
            get
            {
                if (txt_AdvanceDate.Value == null)
                    return "";
                else
                    return txt_AdvanceDate.Value.ToString();
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
        public string PayDate
        {
            get
            {
                if (txt_PayDate.Value == null)
                    return "";
                else
                    return txt_PayDate.Value.ToString();
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

        public string VAT
        {
            get { return txt_VAT.Text; }
            set { txt_VAT.Text = value; }
        }

        public int NoReversePVN
        {
            get {
                if (chk_noreversepvn.Checked == true)
                    return -1;
                else
                    return 0;
            }
            set { if (value == -1)
                    chk_noreversepvn.Checked = true;
                else
                    chk_noreversepvn.Checked = false;
            }
        }
        public double MediatedCost
        {
            get
            {
                try { return Convert.ToDouble(txt_MediatedCost.Text); }
                catch { return 0; }
            }
            set { txt_MediatedCost.Text = value.ToString(); }

        }

        public int Check
        {
            get
            {
                if (chk_Check.Checked == true)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Check.Checked = true;
                else
                    chk_Check.Checked = false;
            }
        }

        #endregion


        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Serie.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_IncomeDoc.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CurRate.Text = "1";
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            CurId = cmb_Firms1.CurId;
            IncotermsId = cmb_Firms1.SupIncotermsId;
            VAT = cmb_Firms1.VATNr;
            //MessageBox.Show(SupId.ToString());
            CheckEmpty();
        }

        public void CheckEmpty()
        {
            btn_OK.ThreadSafeCall(delegate {
                if (IncomeDoc == ""
                    || string.IsNullOrEmpty(IncomeDoc) == true
                    || SupId == 0
                    || CurId == 0
                    || CurRate == 0)
                {
                    btn_OK.Enabled = false;
                }
                else
                {
                    btn_OK.Enabled = true;
                }
                if (DLL.CheckIncomeDocSameName(Id, IncomeDoc) != 0)
                    txt_IncomeDoc.StateCommon.Back.Color1 = Color.LightPink;
                else
                    txt_IncomeDoc.StateCommon.Back.Color1 = Color.White;
            });
        }

        public void RecalcCurRate()
        {
            //double _oldcurrate = 0;
            //_oldcurrate = CurRate;
            //double _sumdoc = 0;
            //double _doccurrate = 0;
            //double _advcurrate = 0;

            //txt_CurRate.ThreadSafeCall(delegate
            //{
            //    try
            //    {
            //        _sumdoc = Math.Round(Convert.ToDouble(Helper.GetOneRecord("select sum(unitprice * qty) from STO_StockInDets where headid = " + Id)));
            //    }
            //    catch { }
            //    _doccurrate = DLL.CurrencyRate(CurId, RegDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : RegDate.Trim());
            //    _advcurrate = DLL.CurrencyRate(CurId, AdvanceDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : AdvanceDate.Trim());

            //    if (_sumdoc == 0)
            //        CurRate = _doccurrate;
            //    else
            //        CurRate = (Advance * _advcurrate + (_sumdoc - Advance) * _doccurrate) / _sumdoc;

            //    if (CurRate == 0
            //        || (Advance != 0 && _advcurrate == 0))
            //        txt_CurRate.StateCommon.Back.Color1 = Color.Red;
            //    else
            //    {
            //        if (_oldcurrate != CurRate)
            //            txt_CurRate.StateCommon.Back.Color1 = Color.Yellow;
            //        else
            //            txt_CurRate.StateCommon.Back.Color1 = Color.White;
            //    }


            //});

            txt_CurRate.ThreadSafeCall(delegate
            {
                DLL.ShowCurRate(CurId, RegDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : RegDate.Trim());
                CurRate = DLL.CurRate;
                if (CurRate == 0)
                    txt_CurRate.StateCommon.Back.Color1 = Color.Red;
                else
                    txt_CurRate.StateCommon.Back.Color1 = Color.White;
            });

            CheckEmpty();
        }

        private void txt_IncomeDoc_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void cmb_Currency1_CurrencyChanged(object sender)
        {
            RecalcCurRate();
            //txt_CurRate.ThreadSafeCall(delegate
            //{
            //   DLL.ShowCurRate(CurId, RegDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : RegDate.Trim());
            //   CurRate = DLL.CurRate;
            //    if (CurRate == 0)
            //        txt_CurRate.StateCommon.Back.Color1 = Color.Red;
            //    else
            //        txt_CurRate.StateCommon.Back.Color1 = Color.White;
            //});

            CheckEmpty();
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_AdditCost.Text = "0";
        }

        private void frm_AddIncomeDoc_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            txt_AdvanceDate.Value = System.DateTime.Now;
        }

        public void FillDate()
        {
            txt_DocDate.Value = System.DateTime.Now;
            txt_AdvanceDate.Value = null;
            txt_PayDate.Value = System.DateTime.Now;
            txt_RegDate.Value = null;
        }

        private void buttonSpecAny9_Click(object sender, EventArgs e)
        {
            txt_PayDate.Value = System.DateTime.Now;
        }

        private void txt_DocDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_RegDate_ValueChanged(object sender, EventArgs e)
        {
            //txt_CurRate.ThreadSafeCall(delegate
            //{
            //    DLL.ShowCurRate(CurId, RegDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : RegDate.Trim());
            //    CurRate = DLL.CurRate;
            //    if (CurRate == 0)
            //        txt_CurRate.StateCommon.Back.Color1 = Color.Red;
            //    else
            //        txt_CurRate.StateCommon.Back.Color1 = Color.White;
            //});
            RecalcCurRate();
            CheckEmpty();
        }

        private void buttonSpecAny8_Click(object sender, EventArgs e)
        {
            txt_VAT.Text = string.Empty;
        }

        private void txt_RegDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_RegDate.Value = txt_RegDate.Value == null ? System.DateTime.Now : txt_RegDate.Value;
        }

        private void txt_AdvanceDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_AdvanceDate.Value = txt_AdvanceDate.Value == null ? System.DateTime.Now : txt_AdvanceDate.Value;
        }

        private void txt_PayDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_PayDate.Value = txt_PayDate.Value == null ? System.DateTime.Now : txt_PayDate.Value;
        }

        private void txt_CurRate_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_Advance_TextChanged(object sender, EventArgs e)
        {
            RecalcCurRate();
            CheckEmpty();
        }

        private void txt_AdvanceDate_ValueChanged(object sender, EventArgs e)
        {
            RecalcCurRate();
            CheckEmpty();
        }

        private void btn_AdvancePayments_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AdvancePayments")) return;

            if (Id != 0)
            {
                frm_AdvancePayments frm = new frm_AdvancePayments();
                frm.HeadId = Id;
                frm.Show();
                frm.gv_List.ThreadSafeCall(delegate { frm.FillAdvances(frm.HeadId); });
            }
            else
                glob_Class.ShowMessage("Registration impossible", "Please register document!", "You must register document at the first!");
        }
    }
}
