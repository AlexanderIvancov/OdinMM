using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Warehouse.StockIn
{
    public delegate void EditStockInIdSendingEventHandler(object sender);

    public partial class ctl_StockInEdit : UserControl
    {
        public ctl_StockInEdit()
        {
            InitializeComponent();
        }

        #region Variables

        public event EditStockInIdSendingEventHandler EditSendStockInId;

        StockIn_BLL Bll = new StockIn_BLL();


        public int State
        {
            get;set;
        }

        int _id = 0;
        public int Id
        {
            get { return _id; }
            set {
                _id = value;
                Bll.IdIn = _id;
                IncomeDocId = Bll.HeadId;
                IncomeDocIdCmb = Bll.HeadId;
                ArtId = Bll.ArtId;
                SupArticle = Bll.SupArticle;
                StockMoveTypeId = Bll.TypeInId;
                Qty = Bll.Qty;
                UnitId = Bll.UnitId;
                Comments = Bll.Comments;
                UnitPrice = Bll.UnitPrice;
                Discount = Bll.Discount;
                Vat = Bll.VAT;
                CoefConv = Bll.CoefConv;
                Weight = Bll.Weight;
                CustCodeId = Bll.CustCodeId;
                BatchId = Bll.BatchId;
                WasMovement = Bll.WasMovewment;
                State = Bll.State;
                UnitPriceWoDisc = Math.Round(Bll.UnitPrice * 100 / (100 - Bll.Discount), 5);
                Sender = Bll.SenderCountryId;
                Producer = Bll.ProducerCountryId;
                DataCode = Bll.DataCode;
                Dutycost = Bll.Dutycost;
                Total = Bll.Total;
                PriceWVat = UnitPrice * (Vat + 100) / 100;
            }

        }

        public int IncomeDocId
        {
            get;
            set; 
        }

        public int IncomeDocIdCmb
        {
            get { return cmb_IncomeDoc1.IncomeDocId; }
            set { cmb_IncomeDoc1.IncomeDocId = value; }
        }

        public int WasMovement
        {
            get; set;
        }


        public int StockMoveTypeId
        {
            get { return cmb_StockInTypes1.StockMovTypeId; }
            set { cmb_StockInTypes1.StockMovTypeId = value; }
        }

        //double _tmpQty = 0;

        public double TempQty
        { get; set; }

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                cmb_Articles1.ArticleId = value;

            }
        }

        public string Article
        {
            get { return cmb_Articles1.Article; }
            set
            {
                cmb_Articles1.Article = value;

            }
        }

        public int UnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
        }

        public string SupArticle
        {
            get { return txt_SupArticle.Text; }
            set { txt_SupArticle.Text = value; }
        }

        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }
                
        public double CoefConv
        {
            get
            {
                try { return Convert.ToDouble(txt_CoefConv.Text); }
                catch { return 1; }
            }
            set { txt_CoefConv.Text = value.ToString(); }
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
                      
        public double UnitPriceWoDisc
        {
            get;set;
        }
        public double Vat
        {
            get
            {
                try { return Convert.ToInt32(txt_Vat.Text); }
                catch { return 0; }
            }
            set { txt_Vat.Text = value.ToString(); }
        }
        public double PriceWVat
        {
            get
            {
                try { return Convert.ToDouble(txt_PriceWVat.Text); }
                catch { return 0; }
            }
            set { txt_PriceWVat.Text = value.ToString(); }
        }
        public double Discount
        {
            get
            {
                try { return Convert.ToDouble(txt_Disc.Text); }
                catch { return 0; }
            }
            set { txt_Disc.Text = value.ToString(); }
        }
        public double Dutycost
        {
            get
            {
                try { return Convert.ToDouble(txt_Dutycost.Text); }
                catch { return 0; }
            }
            set { txt_Dutycost.Text = value.ToString(); }
        }
        public double Total
        {
            get
            {
                try { return Convert.ToDouble(txt_Total.Text); }
                catch { return 0; }
            }
            set { txt_Total.Text = value.ToString(); }
        }
        public double TotalVAT
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalVAT.Text); }
                catch { return 0; }
            }
            set { txt_TotalVAT.Text = value.ToString(); }
        }

        public double TotalWVAT
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalWVAT.Text); }
                catch { return 0; }
            }
            set { txt_TotalWVAT.Text = value.ToString(); }
        }
                

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public double Multiplicity
        {
            get { return Convert.ToDouble(txt_Multiplicity.Text); }
            set { txt_Multiplicity.Text = value.ToString(); }
        }

        public int ArtUnitId
        {
            get { return cmb_Articles1.UnitId; }
            set { cmb_Articles1.UnitId = value; }
        }

        public int CustCodeId
        {
            get { return cmb_CustCodes1.CustCodeId; }
            set { cmb_CustCodes1.CustCodeId = value; }
        }

        public double Weight
        {
            get
            {
                try { return Convert.ToDouble(txt_Weight.Text); }
                catch { return 0; }
            }
            set { txt_Weight.Text = value.ToString(); }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public int Sender
        {
            get { return cmb_Countries1.CountryId; }
            set { cmb_Countries1.CountryId = value; }
        }

        public int Producer
        {
            get { return cmb_Countries2.CountryId; }
            set { cmb_Countries2.CountryId = value; }
        }

        public string DataCode
        {
            get { return txt_DataCode.Text; }
            set { txt_DataCode.Text = value; }
        }
        #endregion

        private void txt_Total_TextChanged(object sender, EventArgs e)
        {
            TotalVAT = Total * Vat/100;
            TotalWVAT = Total + TotalVAT;
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtUnitId = cmb_Articles1.UnitId;
            CustCodeId = cmb_Articles1.CustCodeId;
        }

        private void txt_CoefConv_Validated(object sender, EventArgs e)
        {
            if (CoefConv == 0)
                CoefConv = 1;
            
            Multiplicity = Math.Round(1 / (CoefConv == 0 ? 1 : CoefConv), 7);
        }

        private void txt_Multiplicity_Validated(object sender, EventArgs e)
        {
            CoefConv = Math.Round(1 / Multiplicity, 7);
            if (CoefConv == 0)
                CoefConv = 1;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            int _NewInwardId = Bll.EditStockIn(Id, IncomeDocId, ArtId, SupArticle, StockMoveTypeId, Qty, UnitId,
                                                Comments, UnitPrice, Discount, Vat, CoefConv, Weight, CustCodeId, 
                                                BatchId, Producer, DataCode, Dutycost, Total);

            //Deallocation
            if (_NewInwardId != 0)
            {
                EditSendStockInId?.Invoke(this);
            }
            else
            {
                DialogResult result = KryptonTaskDialog.Show("Edition warning!",
                                                                "Unit price was changed only.",
                                                                "There are movements or incorrect article exists or you tried change articles on less than in stock!",
                                                                MessageBoxIcon.Warning,
                                                                TaskDialogButtons.OK);

                EditSendStockInId?.Invoke(this);
            }

           
        }

        private void txt_Disc_TextChanged(object sender, EventArgs e)
        {
            UnitPrice = UnitPriceWoDisc - UnitPriceWoDisc / 100 * Discount;
        }
        private void txt_Dutycost_TextChanged(object sender, EventArgs e)
        {
            //UnitPrice = UnitPriceWoDisc - UnitPriceWoDisc / 100 * Discount;
        }
        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_DataCode.Text = string.Empty;
        }
    }
}
