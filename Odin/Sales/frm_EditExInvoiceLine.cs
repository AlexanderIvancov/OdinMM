using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;


namespace Odin.Sales
{
    public partial class frm_EditExInvoiceLine : KryptonForm
    {
        public frm_EditExInvoiceLine()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        CO_BLL COBll = new CO_BLL();

        int _invtype = 3;

        public int InvoiceType
        {
            get { return _invtype; }
            set
            {
                _invtype = value;
                if (value == 13)
                {
                    chk_ispaid.Visible = true;
                    txt_InAdvance.Visible = false;
                    txt_LeftInAdvance.Visible = false;
                    lbl_InAdvance.Visible = false;
                    lbl_LeftinAdvance.Visible = false;
                }
                else
                {
                    chk_ispaid.Visible = false;
                    txt_InAdvance.Visible = true;
                    txt_LeftInAdvance.Visible = true;
                    lbl_InAdvance.Visible = true;
                    lbl_LeftinAdvance.Visible = true;
                }
            }
        }

        //int _allowtoinvoice = -1;
        //public int AllowToinvoice
        //{
        //    get
        //    {
        //        return _allowtoinvoice;
        //    }
        //    set
        //    {
        //        _allowtoinvoice = value;
        //        if (_allowtoinvoice == -1)
        //            lbl_NotPaid.Visible = false;
        //        else
        //            lbl_NotPaid.Visible = true;
        //    }
        //}

        public int Line
        {
            get
            {
                try { return Convert.ToInt32(txt_Line.Text); }
                catch { return 0; }
            }
            set { txt_Line.Text = value.ToString(); }
        }
        public double Total
        {
            get { return Convert.ToDouble(txt_Total.Text); }
            set { txt_Total.Text = value.ToString(); }
        }
        public double TotalVat
        {
            get { return Convert.ToDouble(txt_TotalVat.Text); }
            set { txt_TotalVat.Text = value.ToString(); }
        }

        public double TotalWithVat
        {
            get { return Convert.ToDouble(txt_TotalWithVat.Text); }
            set { txt_TotalWithVat.Text = value.ToString(); }
        }

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public int UnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
        }
        public string Product
        {
            get { return txt_Product.Text; }
            set { txt_Product.Text = value; }
        }
        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        public int COCurId
        { get; set; }
        public int InvoiceCurId
        { get; set; }
        public double FirmVAT
        { get; set; }


        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public double UnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_UnitPrice.Text); }
                catch { return 0; }
            }
            set { txt_UnitPrice.Text = value.ToString(); }
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

        public double LeftInAdvance
        {
            get
            {
                try { return Convert.ToDouble(txt_LeftInAdvance.Text); }
                catch { return 0; }
            }
            set { txt_LeftInAdvance.Text = value.ToString(); }
        }

        public double VAT
        { get; set; }

        public string CustCode
        {
            get { return cmb_CustCodes1.CustCode; }
            set { cmb_CustCodes1.CustCode = value; }
        }
        public int CustCodeId
        {
            get { return cmb_CustCodes1.CustCodeId; }
            set { cmb_CustCodes1.CustCodeId = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int IsService
        {
            get
            {
                return chk_IsService.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_IsService.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int AdditExpenses
        {
            get
            {
                return chk_AdditCost.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_AdditCost.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int COId
        {
            get { return cmb_SalesOrdersWithLines1.SalesOrderLineId; }
            set { cmb_SalesOrdersWithLines1.SalesOrderLineId = value; }
        }

        public string DelivNote
        {
            get { return txt_DelivNote.Text; }
            set { txt_DelivNote.Text = value; }
        }

        public double Discount
        {
            get
            {
                try { return Convert.ToDouble(txt_Discount.Text); }
                catch { return 0; }
            }
            set { txt_Discount.Text = value.ToString(); }
        }

        public int QuotId
        {
            get { return cmb_Quotations1.QuotationId; }
            set { cmb_Quotations1.QuotationId = value; }
        }

        public int IsPaid
        {
            get
            {
                return chk_ispaid.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_ispaid.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int IsActive
        {
            get
            {
                return chk_isactive.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_isactive.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }
        public string SalesComments
        {
            get { return txt_SalesComments.Text; }
            set { txt_SalesComments.Text = value; }
        }

        int _InvId = 0;
        public int InvId
        {
            get { return _InvId; }
            set
            {
                _InvId = value;
                COBll.InvoiceDetId = _InvId;
                Line = COBll.InvLine;
                COId = COBll.InvCOId;
                QuotId = COBll.InvQuotId;

                ArtId = COBll.InvArtId;
                Product = COBll.InvProduct;

                UnitId = COBll.InvUnitId;
                UnitPrice = COBll.InvUnitPrice;
                CurId = COBll.InvCurId;
                Comments = COBll.InvComments;
                CustCode = COBll.InvCustCode;
                IsService = COBll.InvIsService;
                AdditExpenses = COBll.InvIsAdditExpences;
                Discount = COBll.InvDiscount;
                DelivNote = COBll.InvDelivNote;
                if (DelivNote.Trim() != "")
                {
                    cmb_SalesOrdersWithLines1.Enabled = false;
                    cmb_Articles1.Enabled = false;
                    txt_Qty.Enabled = false;
                }
                else
                {
                    cmb_SalesOrdersWithLines1.Enabled = true;
                    cmb_Articles1.Enabled = true;
                    txt_Qty.Enabled = true;
                }

                Qty = COBll.InvQty;
                IsPaid = COBll.InvIsPaid;
                InAdvance = COBll.InvInAdvance;
                LeftInAdvance = COBll.InvLeftInAdvance;
                IsActive = COBll.InvIsActive;
                SalesComments = COBll.InvSalesComments;
                //AllowToinvoice = COBll.InvAllowToInvoice;

                RecalcTotals();
            }
        }

        #endregion

        #region Methods

        public void ShowOrderDets(int coid)
        {
            COBll.COId = coid;
            ArtId = COBll.COArtId;
            Product = COBll.COCustArticle;
            Qty = COBll.COQty - COBll.COQtyInvoiced;
            UnitId = COBll.COUnitId;
            UnitPrice = COBll.COUnitPrice;
            COBll.COHeadId = COBll.COHeadId1;
            CurId = COBll.COHeadCurId;
            CustCodeId = cmb_Articles1.CustCodeId;
            IsService = COBll.COService;

        }

        public void ShowQuotDets(int quotid)
        {
            COBll.QuotId = quotid;
            ArtId = COBll.QArtId;
            Product = COBll.QCustArticle;
            Qty = COBll.QQty - COBll.QQtyInvoiced;
            UnitId = COBll.QUnitId;
            UnitPrice = COBll.QUnitPrice;
            CurId = COBll.QCurId;
            CustCodeId = cmb_Articles1.CustCodeId;
        }

        public void RecalcUnitPriceSimple(double sellcoef)
        {
            UnitPrice = Math.Round(COBll.COUnitPrice * sellcoef, 5);
        }

        public void RecalcTotals()
        {
            double _total = 0;
            double _totalvat = 0;
            double _totalwithvat = 0;

            string _cur = "€";


            _total = Math.Round(Qty * UnitPrice, 2, MidpointRounding.AwayFromZero);
            _totalvat = Math.Round(Qty * UnitPrice / 100 * FirmVAT, 2, MidpointRounding.AwayFromZero);
            _totalwithvat = Math.Round((Qty * UnitPrice) + (Qty * UnitPrice / 100 * FirmVAT), 2, MidpointRounding.AwayFromZero);
            _cur = cmb_Currency1.Currency;

            Total = _total;
            TotalVat = _totalvat;
            TotalWithVat = _totalwithvat;

            lbl_Total.Text = "Total (" + _cur + "):";
            lbl_Vat.Text = "VAT (" + _cur + "):";
            lbl_TotalVat.Text = "Total + VAT (" + _cur + "):";
        }

        #endregion

        #region Controls

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            UnitId = cmb_Articles1.UnitId;
            CustCodeId = cmb_Articles1.CustCodeId;
            if (cmb_SalesOrdersWithLines1.SalesOrderLineId == 0)
            {
                CurId = InvoiceCurId;
                Product = cmb_Articles1.SecName;
            }
        }

        private void cmb_SalesOrdersWithLines1_SalesOrderChanged(object sender)
        {
            ShowOrderDets(cmb_SalesOrdersWithLines1.SalesOrderLineId);
            RecalcTotals();

        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            RecalcTotals();
        }

        private void txt_UnitPrice_Validated(object sender, EventArgs e)
        {
            RecalcTotals();
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Product.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void cmb_Quotations1_QuotationChanged(object sender)
        {
            if (cmb_Quotations1.QuotationId != 0)
                cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            ShowQuotDets(cmb_Quotations1.QuotationId);
            RecalcTotals();
        }

        private void txt_InAdvance_Validated(object sender, EventArgs e)
        {
            if (InAdvance > LeftInAdvance)
            {
                InAdvance = LeftInAdvance;
            }
        }
    }
}
