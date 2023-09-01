using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using AdvancedDataGridView;
using Odin.Purchase;
using ComponentFactory.Krypton.Toolkit;
namespace Odin.Warehouse.StockIn
{
    public delegate void StockInIdSendingEventHandler(object sender);

    public partial class ctl_StockInDets : UserControl
    {
        public ctl_StockInDets()
        {
            InitializeComponent();
            frm_StockInwards.ReceiveId += new ReceiveSIId(RetSIId);
        }

        #region Variables

        List<TreeGridNode> foundNodes = new List<TreeGridNode>();
        public event StockInIdSendingEventHandler SendStockInId;
        Font boldFont;

        public int RetSIId()
        {
            return StockInId;
        }

        bool _IsCopy = false;

        public bool IsCopy
        {
            get { return _IsCopy; }
            set { _IsCopy = value; }
        }

        public string strField = "UP";
        public string strSender = "PO";

        int _stockinid = 0;

        public int StockInId
        {
            get { return _stockinid; }
            set { _stockinid = value; }
        }

        StockIn_BLL SIBll = new StockIn_BLL();
        DAL_Functions Fun = new DAL_Functions();
        class_Global globClass = new class_Global();
        PO_BLL POBll = new PO_BLL();
        Helper MyHelper = new Helper();

        public int HeadId
        { get; set; }

        public int PurchaseOrderLineId
        {
            get { return cmb_PurchaseOrdersWithLines1.PurchaseOrderLineId; }
            set { cmb_PurchaseOrdersWithLines1.PurchaseOrderLineId = value; }
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

        public double QtyBefore
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyBefore.Text); }
                catch { return 0; }
            }
            set { txt_QtyBefore.Text = value.ToString(); }
        }

        public double QtyPlaced
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyPlaced.Text); }
                catch { return 0; }
            }
            set { txt_QtyPlaced.Text = value.ToString(); }
        }

        public double QtyToPlace
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyToPlace.Text); }
                catch { return 0; }
            }
            set { txt_QtyToPlace.Text = value.ToString(); }
        }

        public double QtyAfter
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyAfter.Text); }
                catch { return 0; }
            }
            set { txt_QtyAfter.Text = value.ToString(); }
        }
        
        public double CoefConv
        {
            get
            {
                try { return Convert.ToDouble(txt_CoefConv.Text); }
                catch { return 1; }
            }
            set { txt_CoefConv.Text = value.ToString();
                if (txt_CoefConv.Text == "0")
                    txt_CoefConv.StateCommon.Back.Color1 = Color.Tomato;
                else
                    txt_CoefConv.StateCommon.Back.Color1 = Color.White;
            }
        }

        public double QtyInOrder
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyInOrder.Text); }
                catch { return 0; }
            }
            set { txt_QtyInOrder.Text = value.ToString(); }
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

        public double UnitPriceInOrder
        {
            get
            {
                try { return Convert.ToDouble(txt_UnPriceInOrder.Text); }
                catch { return 0; }
            }
            set { txt_UnPriceInOrder.Text = value.ToString(); }
        }

        public double CoefConvInOrder
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

        public string ExpDate
        {
            get
            {
                if (txt_ExpDate.Value == null)
                    return "";
                else
                    return txt_ExpDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_ExpDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_ExpDate.Value = null; }
            }
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

        public string ArtUnit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }

        public int CustCodeId
        {
            get { return cmb_CustCodes1.CustCodeId; }
            set { cmb_CustCodes1.CustCodeId = value; }
        }

        public double Weight
        {
            get { try { return Convert.ToDouble(txt_Weight.Text); }
                catch { return 0; } }
            set { txt_Weight.Text = value.ToString(); }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public int StateId
        {
            get { if (StockMoveTypeId == 25)
                    return 0;
                else
                    return -1;  
                        }
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

        public int SupId
        {
            get;set;
        }
        int _incomecontrol = 0;
        public int IncomeControl
        { get; set; }

        public int NoExpDate
        {
            get { if (chk_NoDate.Checked == true)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_NoDate.Checked = true;

                else
                    chk_NoDate.Checked = false;

            }
        }
        public string ManufBatch
        {
            get { return txt_ManufBatch.Text; }
            set { txt_ManufBatch.Text = value; }
        }
        #endregion

        #region Methods

        public void ClearFields()
        {
            SupArticle = "";
            QtyInOrder = 0;
            Qty = 0;
            UnitPriceInOrder = 0;
            UnitPrice = 0;
            CoefConv = 1;
            CoefConvInOrder = 1;
            //Vat = 0;

            strField = "UP";
            CalcPriceVat();

            ShowLineTots();
            NoExpDate = 0;
            ManufBatch = "";
        }

        private void ShowLineTots()
        {
            Total = Math.Round((Qty * UnitPrice), 2);
            TotalWVAT = Math.Round((Qty * PriceWVat), 2);
            TotalVAT = Math.Round(((Qty * PriceWVat) - (Qty * UnitPrice)), 2);
        }

        private void CalcPriceVat()
        {
            PriceWVat = Math.Round((UnitPrice + (UnitPrice / 100 * Vat)), 5, MidpointRounding.AwayFromZero);
            ShowLineTots();
        }

        private void CalcPrice()
        {
            UnitPrice = Math.Round(((PriceWVat * 100) / (100 + Vat)), 5, MidpointRounding.AwayFromZero);
            ShowLineTots();
        }

        private void CheckUnitPrice()
        {
            if (UnitPrice != UnitPriceInOrder)
                txt_UnitPrice.BackColor = Color.Pink;
            else
                txt_UnitPrice.BackColor = Color.White;
        }

        private void CheckQty()
        {
            if (Qty != QtyInOrder)
                txt_Qty.BackColor = Color.Pink;
            else
                txt_Qty.BackColor = Color.White;
        }

        public void CheckUnit()
        {
            if (cmb_Articles1.UnitId != cmb_Units1.UnitId)
                txt_Unit.BackColor = Color.Pink;
            else
                txt_Unit.BackColor = Color.White;
        }

        public void CheckEmpty()
        {
            if (Qty <= 0
                || ArtId == 0
                || UnitId == 0
                || StockMoveTypeId == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        public void CheckResale()
        {
            PO_BLL POB = new PO_BLL();
            POB.POId = PurchaseOrderLineId;

            if (POB.POResale == -1)
            {
                lbl_Resale.Visible = true;
            }
            else
            {
                lbl_Resale.Visible = false;
            }
        }


        public void ShowPODets(int _poid)
        {
            POBll.POId = _poid;

            ArtId = POBll.POArtId;
            if (_poid == 0)
                cmb_Articles1.txt_Article.Text = "";
            UnitId = POBll.POUnitId;
            SupArticle = POBll.POSupArticle;
            QtyInOrder = POBll.POQtyLeft;
            Qty = POBll.POQtyLeft;
            UnitPriceInOrder = POBll.POUnitPrice;
            UnitPrice = POBll.POUnitPrice;
            CoefConv = POBll.POCoefConv;
            CoefConvInOrder = POBll.POCoefConv;
            Vat = POBll.POVat;
            Comments = POBll.POComments;
            Discount = 0;
            strField = "UP";
            CalcPriceVat();

            ShowLineTots();
            CheckQty();

        }

        public void FillStockDets(int ArtId)
        {
            tv_Rests.Nodes.Clear();

            var data = StockIn_BLL.getStockRests(ArtId);

            foreach (DataRow dr in data.AsEnumerable().OrderBy(d => d.Field<string>("place")))
            {
                AddNode(dr, boldFont, tv_Rests.Nodes, true, false);
            }
            RecalcTempQty();
            RecalcTotal();
            RecalcQtyLeft();
        }

        public void CheckIncomeControl(int _ArtId, int _SupId, int _POId)
        {
            IncomeControl = Convert.ToInt32(Helper.GetOneRecord("select dbo.fn_CheckIncomeControl(" + _ArtId + ", " + _SupId + ", " + _POId + ")"));
            if (IncomeControl == -1)
                lbl_Quarantine.Visible = true;
            else
                lbl_Quarantine.Visible = false;
        }

        private void AddNode(DataRow dr, Font boldFont, TreeGridNodeCollection nodes,
                   bool isAddingImage, bool isExpand)
        {
            TreeGridNode node;
            node = nodes.Add(null, dr["place"], dr["placeid"], Convert.ToDouble(dr["qty"]).ToString(), "0", Convert.ToDouble(dr["qty"]).ToString(), "");


            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }
            
        }

        private void RecalcQtyInNodes()
        {
            foreach (TreeGridNode node in tv_Rests.Nodes)
            {
                double _tmpqty = 0;
                double _qtybefore = Convert.ToDouble(node.Cells["cn_qtyonplace"].Value);
                double _qtyoper = Convert.ToDouble(node.Cells["cn_qtyoper"].Value);
                
                if (node.HasChildren == true)
                {
                    foreach (TreeGridNode node1 in node.Nodes)
                    {
                        _tmpqty = _tmpqty + Convert.ToDouble(node1.Cells["cn_qtyoper"].Value);
                    }
                }

                node.Cells["cn_QtyAfter"].Value = _qtybefore + _qtyoper + _tmpqty;
            }
        }

        private void RecalcQtyLeft()
        {
            double _coefconv = 1;
            if (CoefConv == 0)
                _coefconv = 1;
            else
                _coefconv = CoefConv;

            double _tmp = 0;

            foreach (DataGridViewRow row in tv_Rests.Rows)
            {
                _tmp = _tmp + Convert.ToDouble(row.Cells["cn_qtyoper"].Value);
            }

            QtyToPlace = Qty / _coefconv - _tmp;
        }

        private void RecalcTotal()
        {
            QtyBefore = TempQty;

            double _tmp = 0;

            foreach (DataGridViewRow row in tv_Rests.Rows)
            {
                _tmp = _tmp + Convert.ToDouble(row.Cells["cn_qtyoper"].Value);
            }
            QtyPlaced = _tmp;

            QtyAfter = QtyBefore + _tmp;
        }

        private void RecalcTempQty()
        {
            double _tmp = 0;
            foreach (DataGridViewRow row in tv_Rests.Rows)
            {
                _tmp = _tmp + Convert.ToDouble(row.Cells["cn_qtyonplace"].Value);
            }

            TempQty = _tmp;
        }
        
        #endregion

        #region Controls

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            //MessageBox.Show("Chenged!");
            ArtUnit = cmb_Articles1.Unit;
            CustCodeId = cmb_Articles1.CustCodeId;
            CheckUnit();

            if (strSender == "ART" /*&& ArtId != 0*/)
            {
                cmb_PurchaseOrdersWithLines1.ArticleId = cmb_Articles1.ArticleId;
                cmb_PurchaseOrdersWithLines1.PurchaseOrderId = 0;
                //cmb_PurchaseOrdersWithLines1.PurchaseOrderId = 0;
                //cmb_PurchaseOrdersWithLines1.txt_PurchaseOrder.Text = "";
                //cmb_PurchaseOrdersWithLines1.PurchaseOrderLineId = 0;
                //MessageBox.Show(cmb_Articles1.ArticleId.ToString());
                ClearFields();
                UnitId = cmb_Articles1.UnitId;
                Weight = cmb_Articles1.Weight;
            }
            else
            {
                strSender = "PO";
                cmb_PurchaseOrdersWithLines1.ArticleId = 0;
            }

            if (ArtId == 0)
                ClearFields();
            FillStockDets(cmb_Articles1.ArticleId);

            CheckIncomeControl(cmb_Articles1.ArticleId, SupId, PurchaseOrderLineId);
            CheckResale();
        }

        private void txt_UnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalcPriceVat();
            CheckUnitPrice();
        }
        
        private void txt_PriceWVat_TextChanged(object sender, EventArgs e)
        {
            CalcPrice();
            CheckUnitPrice();
        }

        private void txt_UnitPrice_Click(object sender, EventArgs e)
        {
            strField = "UP";
        }

        private void txt_UnitPrice_Enter(object sender, EventArgs e)
        {
            strField = "UP";
        }

        private void txt_PriceWVat_Click(object sender, EventArgs e)
        {
            strField = "VAT";
        }

        private void txt_PriceWVat_Enter(object sender, EventArgs e)
        {
            strField = "VAT";
        }

        private void txt_Vat_TextChanged(object sender, EventArgs e)
        {
            if (strField == "UP")
                CalcPriceVat();
            else
                CalcPrice();
            CheckUnitPrice();
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            ShowLineTots();
            RecalcTempQty();
            RecalcTotal();
            RecalcQtyLeft();
            CheckQty();
        }

        private void cmb_PurchaseOrdersWithLines1_PurchaseOrderChanged(object sender)
        {
            ShowPODets(PurchaseOrderLineId);
            CheckResale();
        }

        private void btn_AddPlaces_Click(object sender, EventArgs e)
        {
            bool foundnode = false;
            if (
                QtyToPlace != 0
                && cmb_Places1.PlaceId != 0
                && Fun.CheckProduction(cmb_Places1.PlaceId) != true
                && !(IncomeControl == -1 && cmb_Places1.IsQuarantine != -1)
                )
            {
                foreach (TreeGridNode node in tv_Rests.Nodes)
                {
                    if (Convert.ToInt32(node.Cells["cn_placeid"].Value) == cmb_Places1.PlaceId)
                    {
                        TreeGridNode node1;
                        TreeGridNodeCollection nodes = node.Nodes;
                        node1 = nodes.Add(null, cmb_Places1.txt_Place.Text, cmb_Places1.PlaceId.ToString(), "0", QtyToPlace, "0", txt_DataCode.Text, "", ManufBatch);
                        foundnode = true;
                        node.Expand();
                        break;
                    }
                }
                if (foundnode != true)
                {
                    //Adding new node
                    foreach (TreeGridNode node in tv_Rests.Nodes)
                    {
                        node.Collapse();
                    }

                    TreeGridNode node1;
                    node1 = tv_Rests.Nodes.Add(null, cmb_Places1.txt_Place.Text, cmb_Places1.PlaceId.ToString(), "0", QtyToPlace, "0", txt_DataCode.Text, "", ManufBatch);

                    foreach (TreeGridNode node in tv_Rests.Nodes)
                    {
                        node.Expand();
                    }
                }

                RecalcQtyInNodes();
                RecalcTotal();
                RecalcTempQty();
                RecalcQtyLeft();
            }
        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            try {

                TreeGridNode node = tv_Rests.CurrentNode;
                if (node.HasChildren == true)
                {
                    node.Nodes.Clear();
                    tv_Rests.Nodes.Remove(node);
                }
                else
                {
                    try
                    {
                        if (node.Parent.HasChildren == true)
                        {
                            TreeGridNode node1 = node.Parent;
                           node1.Nodes.Remove(node);

                        }
                              
                    }
                    catch {

                    }

                    
                }
              
                RecalcQtyInNodes();
                RecalcQtyLeft();
                RecalcTotal();

            }
            catch { }

        }

        private void ctl_StockInDets_Load(object sender, EventArgs e)
        {
            txt_ExpDate.Value = null;
        }

        private void cmb_PurchaseOrdersWithLines1_Enter(object sender, EventArgs e)
        {
            strSender = "PO";
        }

        private void cmb_Articles1_Enter(object sender, EventArgs e)
        {
            strSender = "ART";
        }

        private void cmb_Articles1_ArticleCleared(object sender)
        {
            strSender = "ART";
            //ArtId = 0;
        }

        private void cmb_PurchaseOrdersWithLines1_ControlClick(object sender)
        {
            strSender = "PO";
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_ExpDate.Value = System.DateTime.Now;
        }

        private void cmb_Units1_UnitChanged(object sender)
        {
            CoefConv = Fun.UnitRecalc(cmb_Articles1.UnitId, UnitId);
            if (CoefConv == 0)
                CoefConv = 1;
            //UnitPrice = UnitPriceInOrder / CoefConv;
            UnitPrice = UnitPriceInOrder / CoefConvInOrder * CoefConv;
            Multiplicity = Math.Round(1 / CoefConv, 7);
        }

        private void txt_CoefConv_Validated(object sender, EventArgs e)
        {
            if (CoefConv == 0)
                CoefConv = 1;
            //UnitPrice = UnitPriceInOrder / CoefConv;
            UnitPrice = UnitPriceInOrder / (CoefConvInOrder == 0 ? 1 : CoefConvInOrder) * CoefConv;
            Multiplicity = Math.Round(1 / (CoefConv == 0 ? 1 : CoefConv), 7);
        }

        private void txt_Multiplicity_Validated(object sender, EventArgs e)
        {
            CoefConv = Math.Round(1 / Multiplicity, 7);
            if (CoefConv == 0)
                CoefConv = 1;
            UnitPrice = UnitPriceInOrder / (CoefConvInOrder == 0 ? 1 : CoefConvInOrder) * CoefConv;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            bool _test = true;
            if (Qty > 0
                && StockMoveTypeId != 0
                && ArtId != 0
                && UnitId != 0)
            {
                if (QtyToPlace > 0)
                {
                    DialogResult result = KryptonTaskDialog.Show("Quantity deallocation warning!",
                                                                 "Are you want to save changes?",
                                                                 "Quantity you want to place less than income's quantity",
                                                                 MessageBoxIcon.Warning,
                                                                 TaskDialogButtons.Yes |
                                                                 TaskDialogButtons.No);
                    if (result == DialogResult.Yes)
                    {
                        _test = true;
                    }
                    else
                    {
                        _test = false;
                    }
                }

                if (_test == true)
                {
                    int _NewInwardId = SIBll.AddStockIn(HeadId, ArtId, SupArticle, StockMoveTypeId, Qty, UnitId, Comments, UnitPrice, Discount,
                                                        Vat, CoefConv, Weight, CustCodeId, BatchId, StateId, PurchaseOrderLineId, Producer, DataCode);

                    //Deallocation
                    if (_NewInwardId != 0)
                    {
                        int _inslab = 0;
                        foreach (DataGridViewRow row in this.tv_Rests.Rows)
                        {
                            if (Convert.ToDouble(row.Cells["cn_qtyoper"].Value) > 0
                                && StateId != 0)
                            _inslab = SIBll.AddStockDeallocation(_NewInwardId, 0, ArtId, Convert.ToInt32(row.Cells["cn_placeid"].Value), Convert.ToDouble(row.Cells["cn_qtyoper"].Value),
                                                            ExpDate, 0, -1, row.Cells["cn_comments"].Value.ToString(), row.Cells["cn_datacode"].Value.ToString(),
                                                            row.Cells["cn_manufbatch"].Value.ToString());
                            if (_inslab != 0
                                && NoExpDate == -1)
                                SIBll.SetNoExpDate(_inslab);
                        }

                        PO_BLL POB = new PO_BLL();
                        POB.POId = PurchaseOrderLineId;

                        if (POB.POResale == -1)
                        {
                            POB.POHeadId = POB.POHeadId1;
                            string emailaddresses = "";
                            emailaddresses = Fun.EmailAddressesByType(3);

                            if (emailaddresses != "")
                            {

                                string strMessage = "Purchase order: " + POB.POName;
                                strMessage = strMessage + "\r\nSupplier: " + POB.POHeadSupplier;
                                strMessage = strMessage + "\r\nSuppliers article: " + POB.POSupArticle;
                                strMessage = strMessage + "\r\nArticle: " + cmb_Articles1.Article;
                                strMessage = strMessage + "\r\nQty: " + Qty.ToString() + " " + cmb_Units1.Unit;//POB.POQty;

                                MyHelper.SendDirectEMail(globClass.ReplaceChar(emailaddresses, ";", ","), "Purchase order for resale NR : " + POB.POName + " reception!", strMessage);
                            }
                        }

                        cmb_Articles1.ArticleId = 0;
                        ClearFields();
                        cmb_PurchaseOrdersWithLines1.ArticleId = 0;
                        cmb_PurchaseOrdersWithLines1.PurchaseOrderId = 0;

                        if (SendStockInId != null)
                        {
                            SendStockInId(this);
                        }
                    }
                }
            }
        }

        private void cmb_StockInTypes1_TypesChanged(object sender)
        {
            if (StockMoveTypeId == 2)
                cmb_Batches1.Enabled = true;
            else
                cmb_Batches1.Enabled = false;
        }


        private void txt_Disc_TextChanged(object sender, EventArgs e)
        {
            double _tmpup = UnitPrice;

            double _tmpunitprice = Math.Round(/*UnitPriceInOrder*/_tmpup / (CoefConvInOrder == 0 ? 1 : CoefConvInOrder) * CoefConv, 5);

            UnitPrice = Math.Round(_tmpunitprice - _tmpunitprice / 100 * Discount, 5);//Math.Round(_tmpunitprice * 100 / (100 - Discount), 5);
        }

        #endregion

        private void txt_ExpDate_DoubleClick(object sender, EventArgs e)
        {
            txt_ExpDate.Value = txt_ExpDate.Value == null ? System.DateTime.Now : txt_ExpDate.Value;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_DataCode.Text = string.Empty;
        }

        private void cmb_Places1_SelectedValueChanged(object sender)
        {
            //if (Fun.CheckProduction(cmb_Places1.PlaceId) == true)
            //    KryptonTaskDialog.Show("Placement warning!",
            //                           "You can't place directly to production!",
            //                           "You can't place directly to production!",
            //                           MessageBoxIcon.Warning,
            //                           TaskDialogButtons.OK);
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_ManufBatch.Text = string.Empty;
        }
    }
}
