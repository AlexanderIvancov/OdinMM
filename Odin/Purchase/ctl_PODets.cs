using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Planning;
using Odin.Register;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.Purchase
{
    public delegate void POIdSendingEventHandler(object sender);
    public partial class ctl_PODets : UserControl
    {
        public ctl_PODets()
        {
            InitializeComponent();
            frm_PurchaseOrders.ReceiveId += new ReceivePOId(RetPOId);
            PopupHelper = new PopupWindowHelper();
        }

        #region Variables

        Plan_BLL BLL = new Plan_BLL();
        PopupWindowHelper PopupHelper = null;
        DAL_Functions DLL = new DAL_Functions();
        DAL_Functions Fun = new DAL_Functions();
        class_Global globClass = new class_Global();
        PO_BLL POBll = new PO_BLL();
        Reg_BLL MyCat = new Reg_BLL();
        Helper MyHelper = new Helper();

        public DataTable DataNeeds;

        public event POIdSendingEventHandler SendPOId;

        public int RetPOId()
        {
            return POId;
        }

        bool _IsCopy = false;

        public bool IsCopy
        {
            get { return _IsCopy; }
        set { _IsCopy = value; }
        }

        int _poid = 0;
        public int POId
        {
            get { return _poid; }
            set
            {
                _poid = value;
                POBll.POId = _poid;

                Line = POBll.POLine;
                CatId = POBll.POCatalogId;
                ArtId = POBll.POArtId;
                Comments = POBll.POComments;
               

                StateId = POBll.POStateId;
                SupArticle = POBll.POSupArticle;
                SuppliersOrder = POBll.POSupOrder;
               
                Qty = POBll.POQty;
                ReqDate = POBll.POReqDate;
                MinExpDate = POBll.POMinExpDate;
                UnitId = POBll.POUnitId;
                DBUnitId = POBll.PODBUnitId;
                
                Vat = POBll.POVat;
                Discount = POBll.PODiscount;
                HeadId1 = POBll.POHeadId1;
               

                UnitFNPrice = POBll.POUnitPrice;
                UnitPriceBeg = Discount == 100 ? 0 : (POBll.POUnitPrice * 100 / (100 - Discount));

                CoefConv = POBll.POCoefConv;

                if (CoefConv == 0)
                    CoefConv = 1;
                UnitPrice = UnitPriceBeg / CoefConv;
                Multiplicity = Math.Round(1 / CoefConv, 7);
                Resale = POBll.POResale;
                InternalComments = POBll.POInternalComments;
                ProjectId = POBll.POProjectId;
                ChangeInOrder = POBll.POChangeInOrder;
                EndCustomer = POBll.POEndCustomer;

                strField = "txt_UnPrice";
                
                CalcPriceFields(4, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
                ShowLineTots();
            }
        }

       

        public int senderUnit
        { get; set; }

        public int senderQty
        { get; set; }

        public string strField = "";

        
        int _CatId = 0;
        int _PrevArtId = 0;
        
        public int PrevArtId
        {
            get { return _PrevArtId; }
            set { _PrevArtId = value; }
        }

        public int HeadId1
        { get; set; }
        public int HeadId
        {
            get { return cmb_PurchaseOrders1.PurchaseOrderId; }
            set { cmb_PurchaseOrders1.PurchaseOrderId = value; }
        }
        public int POLineId
        { get; set; }
        public int CurId
        { get; set; }
        public int DBUnitId
        { get; set; }
        public int Id
        { get; set; }
        public int SupId
        {
            get { return cmb_PurchaseOrders1.SupplierId; }
            set { cmb_PurchaseOrders1.SupplierId = value; }
        }
       
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        

        public int Line
        {
            get
            {
                try { return Convert.ToInt32(txt_Line.Text); }
                catch { return 0; }
            }
            set { txt_Line.Text = value.ToString(); }
        }

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                cmb_Articles1.ArticleId = value;

            }
        }

        public string Article1
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
        
        public int StateId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
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
        public double MOQ
        {
            get
            {
                try { return Convert.ToDouble(txt_MOQ.Text); }
                catch { return 0; }
            }
            set { txt_MOQ.Text = value.ToString(); }
        }
        public double NeedsInPO
        {
            get
            {
                try { return Convert.ToDouble(txt_NeedsInPO.Text); }
                catch { return 0; }
            }
            set { txt_NeedsInPO.Text = value.ToString(); }
        }
        public double MissedQty
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyMissed.Text); }
                catch { return 0; }
            }
            set { txt_QtyMissed.Text = value.ToString(); }
        }

        public double MPQ
        {
            get
            {
                try { return Convert.ToDouble(txt_MPQ.Text); }
                catch { return 0; }
            }
            set { txt_MPQ.Text = value.ToString(); }
        }
        public double UnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_UnPrice.Text); }
                catch { return 0; }
            }
            set { txt_UnPrice.Text = value.ToString(); }
        }
        public double UnitPriceBeg
        { get; set; }
        public double Discount
        {
            get
            {
                try { return Convert.ToDouble(txt_Disc.Text); }
                catch { return 0; }
            }
            set { txt_Disc.Text = value.ToString(); }
        }
        public double DiscFix
        {
            get
            {
                try { return Convert.ToDouble(txt_DiscFix.Text); }
                catch { return 0; }
            }
            set { txt_DiscFix.Text = value.ToString(); }
        }
        public double UnitFNPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_UnFNPrice.Text); }
                catch { return 0; }
            }
            set { txt_UnFNPrice.Text = value.ToString(); }
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
        public string ReqDate
        {
            get { return txt_ReqDate.Value.ToShortDateString(); }
            set
            {
                try { txt_ReqDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }
        public string MinExpDate
        {
            get {
                return txt_MinExpDate.Value == null ? "" : txt_MinExpDate.Value.ToString();
            }
            set
            {
                try {
                    txt_MinExpDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_MinExpDate.Value = null;}
            }
        }
        public string SuppliersOrder
        {
            get { return txt_SuppliersOrder.Text; }
            set { txt_SuppliersOrder.Text = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        public string ChangeInOrder
        {
            get { return txt_ChangeInOrder.Text; }
            set { txt_ChangeInOrder.Text = value; }
        }
        public string ArtComments
        {
            get { return txt_ArtComments.Text; }
            set { txt_ArtComments.Text = value; }
        }
        int _Previd = 0;
        public int CatId
        {
            get { return _CatId; }
            set
            {
                //
                _CatId = value;
                if (_CatId != _Previd)
                {
                    //MessageBox.Show("received!");
                    MyCat.CatId = _CatId;
                    ArtId = MyCat.CatArtId;
                    SupArticle = MyCat.CatFirmArt;
                    MOQ = MyCat.CatMOQ;
                    MPQ = MyCat.CatMPQ;
                    UnitId = MyCat.CatUnitId;
                    UnitPrice = MyCat.CatUnitPrice;
                    //if (POId == 0)
                    _Previd = _CatId;
                }

            }
        }
        public int PrimSup
        { get; set; }
        
        public double Multiplicity
        {
            get { return Convert.ToDouble(txt_Multiplicity.Text); }
            set { txt_Multiplicity.Text = value.ToString(); }
        }

        int _artfromneeds = 0;

        public int ArtFromNeeds
        {
            get { return _artfromneeds; }
            set { _artfromneeds = value; }
        }

        public int Resale
        {
            get { return chk_Resale.CheckState == CheckState.Checked ? -1 : 0; }
            set { chk_Resale.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked; }
        }

        public int ProjectId
        {
            get { return cmb_Projects1.ProjectId; }
            set { cmb_Projects1.ProjectId = value; }
        }

        public string InternalComments
        {
            get { return txt_InternalComments.Text; }
            set { txt_InternalComments.Text = value; }
        }

        public string EndCustomer
        {
            get { return txt_EndCustomer.Text; }
            set { txt_EndCustomer.Text = value; }
        }

        #endregion

        #region Methods

        public void FillNotCatalogDets(int _artid, string _article, int _unitid, double _unitprice)
        {
            ArtId = _artid;
            SupArticle = _article;
            UnitId = _unitid;
            UnitPrice = _unitprice;
        }

        public void EnableNeeds()
        {
            btn_Needs.Enabled = IsCopy != false
                || POId == 0;
        }

        public double MOQMPQ(double Qty, double MOQ, double MPQ)
        {
            double Ret = Qty < MOQ
                ? globClass.ApprovePOMOQ() == true ? MOQ : Qty
                : MPQ > 0 ? Math.Round((Qty % MPQ), 5) == 0 ? Qty : globClass.ApprovePOMOQ() == true ? Qty - (Qty % MPQ) + MPQ : Qty : Qty;
            return Ret;
        }

        public void ShowLineTots()
        {
            Total = Math.Round((Qty * UnitFNPrice), 2);
            TotalWVAT = Math.Round((Qty * PriceWVat), 2);
            TotalVAT = Math.Round(((Qty * PriceWVat) - (Qty * UnitFNPrice)), 2);
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = Qty > 0
            && ArtId != 0
            && UnitId != 0
            && HeadId != 0
            //|| CheckCatEx(cmb_Articles1.ArticleId, SupId) == false
            && ReqDate.Trim() != ""
            && String.IsNullOrEmpty(ReqDate.Trim()) != true;
        }

        public void CalcPriceFields(int sender, double vUnitPrice, double vDiscount, double vDiscFix, double vUnitFNPrice, double vVat, double vPriceWVat)
        {
            if (sender == 0)
            {
                //Discount Absolute (show)
                DiscFix = Math.Round((vUnitPrice * vDiscount / 100), 5);
                UnitFNPrice = vDiscount == 100 ? 0 : Math.Round((vUnitPrice * (100 - vDiscount) / 100), 5);
                CalcPriceFields(2, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
            }
            else if (sender == 3)
            {
                //Discount percentage (show)
                Discount = vUnitPrice == 0 ? 0 : Math.Round((DiscFix * 100 / vUnitPrice), 2);
                UnitFNPrice = Math.Round((vUnitPrice - DiscFix), 5);
                CalcPriceFields(2, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
            }
            else if (sender == 1)
            {
                // Esli cena s PVN, vichisljaem cenu bez PVN
                UnitFNPrice = Math.Round(((vPriceWVat * 100) / (100 + vVat)), 5);
            }
            else if (sender == 4)
            {
                UnitPrice = vDiscount == 100 ? 0 : Math.Round(UnitFNPrice * 100 / (100 - vDiscount), 5);
                CalcPriceFields(2, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
            }
            else
            {
                // Esli cena bez PVN, vichisljaem cenu s PVN
                PriceWVat = Math.Round((vUnitFNPrice + (vUnitFNPrice / 100 * vVat)), 5);
            }
        }

        public void ClearFields()
        {

            ArtId = 0;
            Qty = 0;
            UnitId = 0;
            UnitFNPrice = 0;
            Discount = 0;
            Comments = "";
            CatId = 0;
            CoefConv = 1;
            txt_MinExpDate.Value = null;
            SuppliersOrder = string.Empty;
            SupArticle = string.Empty;
            UnitPrice = 0;
            InternalComments = "";
            ChangeInOrder = "";
            ProjectId = 0;
            CalcPriceFields(0, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
            ShowLineTots();

            StateId = 1;
            Line = POBll.LastPOLine(cmb_PurchaseOrders1.PurchaseOrderId) + 1;
            
            CheckEmpty();

        }

        public void FillDates()
        {
            txt_ReqDate.Value = System.DateTime.Now;
        }
        #endregion

        #region Controls

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_MinExpDate.Value = System.DateTime.Now;
        }

        private void btn_Catalog_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.Parent.FindForm();

            Point LocationPoint = btn_Catalog.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + btn_Catalog.Height;
            Point _location = new Point(xpos, ypos);

            frm_FindCatalog popup = new frm_FindCatalog();
            popup.ctlDets = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };
            popup.ArtId = ArtId;
            popup.SupId = SupId;
            //MessageBox.Show(SupId.ToString());
            popup.FillList(ArtId, SupId);
        }

        private void btn_Requests_Click(object sender, EventArgs e)
        {

        }

        private void btn_Needs_Click(object sender, EventArgs e)
        {
            frm_AddPONeeds frm = new frm_AddPONeeds();

            frm.ctl_RMNeeds1.cmb_Articles1.ArticleId = ArtId;
            frm.ctl_RMNeeds1.EnableSave(false);

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                bool _test = true;

                if (frm.ctl_RMNeeds1.AvailableQty > 0
                    || BLL.QtyFreePO > 0)
                {
                    DialogResult result1 = KryptonTaskDialog.Show("Available or free po quantity existance!",
                                                                     "Are you want to save changes?",
                                                                     "Available quantity or free po quantity is more than zero! It is recommended to distribute it at the first!",
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.Yes |
                                                                     TaskDialogButtons.No);
                    _test = result1 != DialogResult.No;
                }

                if (_test == true)
                {
                    NeedsInPO = frm.ctl_RMNeeds1.PurchasedQty;
                    Qty = NeedsInPO;

                    if (Qty > 0)
                        Qty = MOQMPQ(Qty / CoefConv, MOQ, MPQ) * CoefConv;
                    ShowLineTots();
                    CheckEmpty();

                    //Fill temporary datatable for mapping with needs

                    //DataNeeds.Rows.Clear();

                    DataNeeds = frm.ctl_RMNeeds1.data.Copy();
                    ArtFromNeeds = frm.ctl_RMNeeds1.cmb_Articles1.ArticleId;
                }            
                               
            }
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_SuppliersOrder.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_SupArticle.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_ChangeInOrder.Text = string.Empty;
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            DBUnitId = cmb_Articles1.UnitId;
            UnitId = cmb_Articles1.UnitId;
            BLL.ArtIdTotal = ArtId;
            ArtComments = cmb_Articles1.Comments;

            MissedQty = BLL.QtyRest + BLL.QtyPurchased - BLL.QtyNeeds;


            //Clear needs
            
            NeedsInPO = 0;
            //Qty = 0;

            //ShowLineTots();
            //CheckEmpty();
        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            if (Qty > 0)
                Qty = MOQMPQ(Qty / CoefConv, MOQ, MPQ) * CoefConv;
            ShowLineTots();
            CheckEmpty();
        }

        private void txt_CoefConv_Validated(object sender, EventArgs e)
        {
            strField = "txt_UnPrice";
            
            if (CoefConv == 0)
                CoefConv = 1;
            UnitPrice = UnitPriceBeg / CoefConv;
            Multiplicity = Math.Round(1 / CoefConv, 7);
        }

        private void txt_Multiplicity_Validated(object sender, EventArgs e)
        {
            strField = "txt_UnPrice";

            CoefConv = Math.Round(1 / Multiplicity, 7);
            if (CoefConv == 0)
                CoefConv = 1;
            UnitPrice = UnitPriceBeg / CoefConv;
        }

        private void cmb_Units1_Click(object sender, EventArgs e)
        {
            senderUnit = 1;
        }

        private void cmb_Units1_UnitChanged(object sender)
        {
            strField = "txt_UnPrice";

            CoefConv = Fun.UnitRecalc(DBUnitId, UnitId);

            if (senderUnit == 1)
            {
                if (CoefConv == 0)
                    CoefConv = 1;

                UnitPrice = UnitPriceBeg / CoefConv;
                Multiplicity = Math.Round(1 / CoefConv, 7);
            }
        }
        
        private void txt_UnPrice_Click(object sender, EventArgs e)
        {
            strField = "txt_UnPrice";
        }

        private void txt_UnPrice_Enter(object sender, EventArgs e)
        {
            strField = "txt_UnPrice";
        }

        private void txt_UnPrice_Validated(object sender, EventArgs e)
        {
            UnitPriceBeg = UnitPrice * CoefConv;
        }

        private void txt_UnPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (strField == "txt_UnPrice")
                {
                    CalcPriceFields(0, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
                    ShowLineTots();
                }
            }
            catch { }
        }

        private void txt_Disc_Click(object sender, EventArgs e)
        {
            strField = "txt_Disc";
        }

        private void txt_Disc_Enter(object sender, EventArgs e)
        {
            strField = "txt_Disc";
        }

        private void txt_Disc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (strField == "txt_Disc")
                {
                    CalcPriceFields(0, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
                    ShowLineTots();
                }
            }
            catch { }
        }

        private void txt_Disc_Validated(object sender, EventArgs e)
        {
            try
            {
                if (strField == "txt_Disc")
                {
                    CalcPriceFields(0, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
                    ShowLineTots();
                }
            }
            catch { }
        }

        private void txt_DiscFix_Click(object sender, EventArgs e)
        {
            strField = "txt_DiscFix";
        }

        private void txt_DiscFix_Enter(object sender, EventArgs e)
        {
            strField = "txt_DiscFix";
        }

        private void txt_DiscFix_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (strField == "txt_DiscFix")
                {
                    CalcPriceFields(3, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
                    ShowLineTots();
                }
            }
            catch { }
        }

        private void txt_UnFNPrice_Click(object sender, EventArgs e)
        {
            strField = "txt_UnFNPrice";
        }

        private void txt_UnFNPrice_Enter(object sender, EventArgs e)
        {
            strField = "txt_UnFNPrice";
        }

        private void txt_UnFNPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (strField == "txt_UnFNPrice")
                {
                    CalcPriceFields(2, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
                    ShowLineTots();
                }
            }
            catch { }
            CheckEmpty();
        }

        private void txt_Vat_Click(object sender, EventArgs e)
        {
            strField = "txt_Vat";
        }

        private void txt_Vat_Enter(object sender, EventArgs e)
        {
            strField = "txt_Vat";
        }

        private void txt_Vat_TextChanged(object sender, EventArgs e)
        {
            if (strField == "txt_Vat")
            {
                int send = UnitFNPrice == 0 ? 1 : 2;
                CalcPriceFields(send, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
                ShowLineTots();
            }
            CheckEmpty();
        }

        private void txt_PriceWVat_Click(object sender, EventArgs e)
        {
            strField = "txt_PriceWVat";
        }

        private void txt_PriceWVat_Enter(object sender, EventArgs e)
        {
            strField = "txt_PriceWVat";
        }

        private void txt_PriceWVat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (strField == "txt_PriceWVat")
                {
                    //MessageBox.Show("ch!");
                    CalcPriceFields(1, UnitPrice, Discount, DiscFix, UnitFNPrice, Vat, PriceWVat);
                    ShowLineTots();
                }
            }
            catch { }
            CheckEmpty();
        }
        
        private void txt_SuppliersOrder_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_Comments_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_ChangeInOrder_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_ReqDate_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }



        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int NewLineId = 0;

            int _POId = 0;
            if (IsCopy == false)
                _POId = POId;

            double _QtyDistr = 0;

            #region If1
            if (DLL.CheckArtId(ArtId) != 0)
            {
                NewLineId = POBll.SavePOLine(_POId, HeadId, Line, ArtId, Qty, UnitId, UnitFNPrice, Vat, Discount, ReqDate, Comments, StateId, 
                                            CatId, CoefConv, MinExpDate, SuppliersOrder, SupArticle, Resale, ProjectId, InternalComments, ChangeInOrder);

                _QtyDistr = Math.Round(Qty / (CoefConv == 0 ? 1 : CoefConv), 5);
                //MessageBox.Show(NewLineId.ToString());
                //Needs distribution
                if (_POId == 0
                    && NewLineId != 0
                    && ArtFromNeeds == ArtId) //New line
                {
                    foreach (DataRow row in DataNeeds.Rows)
                    {
                        if (Convert.ToDouble(row["topurchase"]) > 0
                            && _QtyDistr > 0)
                        {
                            //MessageBox.Show("MAP!!!");
                            if (Convert.ToDouble(row["topurchase"]) > _QtyDistr)
                            {
                                POBll.MapPONeeds(NewLineId, Convert.ToInt32(row["id"]), Convert.ToInt32(row["typeneed"]), _QtyDistr, "");
                                _QtyDistr = 0;
                                
                                break;
                            }
                            else
                            {
                                POBll.MapPONeeds(NewLineId, Convert.ToInt32(row["id"]), Convert.ToInt32(row["typeneed"]), Convert.ToDouble(row["topurchase"]), "");
                                _QtyDistr = _QtyDistr - Convert.ToDouble(row["topurchase"]);
                               
                            }

                        }
                    }
                    
                }
                #endregion
                else //Existed line
                {
                    if (Math.Round(POBll.POQty / (POBll.POCoefConv == 0 ? 1 : POBll.POCoefConv), 5) > Qty
                        || POBll.POArtId != ArtId
                        || StateId == 2
                        || StateId == 3) //We must delete missed mappings
                    {
                        POBll.DeletePONeedsMaps(NewLineId);
                    }
                }

                //if (Resale == -1)
                //{
                //    PO_BLL POB = new PO_BLL();
                //    POB.POId = NewLineId;

                //    POB.POHeadId = POB.POHeadId1;

                //    string emailaddresses = "";
                //    emailaddresses = Fun.EmailAddressesByType(3);

                //    if (emailaddresses != "")
                //    {

                //        string strMessage = "Purchase order: " + POB.POName;
                //        strMessage = strMessage + "\r\nArt.Id: " + POB.POArtId;
                //        strMessage = strMessage + "\r\nSupplier: " + POB.POHeadSupplier;
                //        strMessage = strMessage + "\r\nSuppliers article: " + POB.POSupArticle;
                //        strMessage = strMessage + "\r\nQty: " + POB.POQty;

                //        MyHelper.SendMessage(globClass.ReplaceChar(emailaddresses, ";", ","), "Purchase order for resale NR : " + POB.POName + " was created!", strMessage);
                //    }
                //}

                ClearFields();
            }

            //Event
            SendPOId?.Invoke(this);
        }

        private void txt_SupArticle_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_Qty_Validating(object sender, CancelEventArgs e)
        {
            CheckEmpty();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DataNeeds.Rows)
            {
                MessageBox.Show(row["topurchase"].ToString());

            }

         }

        private void cmb_Common1_SelectedValueChanged(object sender)
        {
            CheckEmpty();
        }

        private void txt_ReqDate_ValueChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_InternalComments.Text = string.Empty;
        }

        private void txt_InternalComments_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
