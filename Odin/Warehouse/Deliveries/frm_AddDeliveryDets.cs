using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.StockIn;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.Warehouse.Deliveries
{
    public delegate void StockDeliverySavedEventHandler(object sender);

    public partial class frm_AddDeliveryDets : KryptonForm
    {
        public frm_AddDeliveryDets()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
        }

        #region Variables

        public event StockDeliverySavedEventHandler StockDeliveryLineSaved;

        ProgressForm wait;

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        DataTable data1;
        class_Global glob_Class = new class_Global();
        DelivNote_BLL DLBll = new DelivNote_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();

        public int HeadId
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public string ConfOrder
        {
            get { return txt_ConfOrder.Text; }
            set { txt_ConfOrder.Text = value; }
        }

        public string CustOrder
        {
            get { return txt_CustOrder.Text; }
            set { txt_CustOrder.Text = value; }
        }

        public string CustArticle
        {
            get { return txt_CustArticle.Text; }
            set { txt_CustArticle.Text = value; }
        }

        public int COId
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

        public double AvailableQty
        {
            get
            {
                try { return Convert.ToDouble(txt_Available.Text); }
                catch { return 0; }
            }
            set { txt_Available.Text = value.ToString(); }
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

        public double CostUnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_CostUP.Text); }
                catch { return 0; }
            }
            set { txt_CostUP.Text = value.ToString(); }
        }

        public double CoefConv
        {
            get
            {
                try { return Convert.ToDouble(txt_CoefConv.Text); }
                catch { return 0; }
            }
            set { txt_CoefConv.Text = value.ToString(); }
        }

        public int UnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
        }

        public int CustCodeId
        {
            get { return cmb_CustCodes1.CustCodeId; }
            set { cmb_CustCodes1.CustCodeId = value; }
        }

        public double WeightNet
        {
            get
            {
                try { return Convert.ToDouble(txt_WeightNet.Text); }
                catch { return 0; }
            }
            set { txt_WeightNet.Text = value.ToString(); }
        }

        public double WeightBrut
        {
            get
            {
                try { return Convert.ToDouble(txt_WeightBrut.Text); }
                catch { return 0; }
            }
            set { txt_WeightBrut.Text = value.ToString(); }
        }

        public int PackQty
        {
            get
            {
                try { return Convert.ToInt32(txt_PackQty.Text); }
                catch { return 0; }
            }
            set { txt_PackQty.Text = value.ToString(); }
        }

        public string Package
        {
            get { return cmb_Packages1.Package; }
            set { cmb_Packages1.Package = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public double OrigUnitPrice
        { get; set; }

        public double QtyLeftToSend
        {
            get;
            set;
        }
        public double QtyLefToSendCO
        {
            get
            {
                try { return Convert.ToDouble(txt_LeftToSend.Text); }
                catch { return 0; }
            }
            set { txt_LeftToSend.Text = value.ToString(); }
        }

        public int Return
        {
            get
            {
                if (chk_Return.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Return.CheckState = CheckState.Checked;
                else
                    chk_Return.CheckState = CheckState.Unchecked;
            }
        }
        public int Internal
        { get; set; }
        #endregion

        #region Controls

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            ClearCODets();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowDets();
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.bindingNavigatorAddNewItem_Image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void gv_Delivery_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                COId = Convert.ToInt32(gv_Delivery.CurrentRow.Cells["cn_dcoid"].Value);
                ConfOrder = gv_Delivery.CurrentRow.Cells["cn_dconforder"].Value.ToString();
                CustOrder = gv_Delivery.CurrentRow.Cells["cn_custorder"].Value.ToString();
                CustArticle = gv_Delivery.CurrentRow.Cells["cn_custarticle"].Value.ToString();
                CoefConv = 1;
                UnitId = cmb_Articles1.UnitId;
                UnitPrice = Convert.ToDouble(gv_Delivery.CurrentRow.Cells["cn_oUnitPrice"].Value);
                OrigUnitPrice = Convert.ToDouble(gv_Delivery.CurrentRow.Cells["cn_oUnitPrice"].Value);
                QtyLeftToSend = Convert.ToDouble(gv_Delivery.CurrentRow.Cells["cn_dqty"].Value);
                QtyLefToSendCO = QtyLeftToSendToCO(COId);
                CheckUnitPrice();
                CheckDelivQty();
                lbl_SellPrice.Text = "Sell price(" + gv_Delivery.CurrentRow.Cells["cn_currency"].Value.ToString() + "):";
            }
            catch { ClearCODets(); }
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            UnitId = cmb_Articles1.UnitId;
            CustCodeId = cmb_Articles1.CustCodeId;
            AvailableQty = ShowAvailQty(ArticleId);

            if (ArticleId == 0)
            {
                ClearFields();
                cmb_Batches1.BatchId = 0;
                ShowDetsArt();
                //bwStart(bw_List);
            }
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            ArticleId = cmb_Batches1.ArticleId;
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            try
            {
                if (gv_List.CurrentRow.Cells["cn_totake"].Selected == true)
                {
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_totake"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value))
                        gv_List.CurrentRow.Cells["cn_totake"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_totake"].Value) < 0)
                        gv_List.CurrentRow.Cells["cn_totake"].Value = 0;

                    double _res = 0;

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        _res = _res + Convert.ToDouble(row.Cells["cn_totake"].Value);
                    }

                    if (cmb_Batches1.BatchId == 0)
                    {
                        if (_res > AvailableQty)
                        {
                            gv_List.CurrentRow.Cells["cn_totake"].Value = AvailableQty - (_res - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_totake"].Value));
                        }
                    }
                }
            }
            catch { gv_List.CurrentRow.Cells["cn_totake"].Value = 0; }

            Qty = RecalcDelivQty();
            RecalcWeightNet();
            //if (UnitPrice == 0)
            CostUnitPrice = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_unitprice"].Value);

            CheckDelivQty();
            CheckUnitPrice();
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            if (ArticleId != 0)
            {
                frm_AddArticleForDelivery frm = new frm_AddArticleForDelivery();
                frm.ArtId = ArticleId;
                frm.HeaderText = "List of confirmed orders for selected article: " + cmb_Articles1.Article;
                frm.ShowDets();

                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    int _id = 0;
                    bool _test = true;
                    foreach (DataGridViewRow row in frm.gv_Delivery.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["chk_Add"].Value) != 0)
                        {
                            //Check for existed co
                            _id = Convert.ToInt32(row.Cells["cn_did"].Value);

                            //if (data1.Rows.Count > 0)
                            //{
                            //    foreach (DataRow row1 in data1.Rows)
                            //    {
                            //        if (Convert.ToInt32(row1["id"]) == _id)
                            //        {
                            //            _test = false;
                            //            break;
                            //        }
                            //        else
                            //        { _test = true; }
                            //    }
                            //}
                            if (_test == true)
                            {

                                //Add new row
                                DataRow newrow = data1.NewRow();

                                newrow["id"] = Convert.ToInt32(row.Cells["cn_did"].Value);
                                newrow["coid"] = Convert.ToInt32(row.Cells["cn_dcoid"].Value);
                                newrow["conforder"] = row.Cells["cn_dconforder"].Value.ToString();
                                newrow["orderstate"] = row.Cells["cn_ostate"].Value.ToString();
                                newrow["client"] = row.Cells["cn_dclient"].Value.ToString();
                                newrow["confdate"] = row.Cells["cn_confdate"].Value.ToString();
                                newrow["confqty"] = Convert.ToDouble(row.Cells["cn_dqty"].Value);
                                newrow["unit"] = row.Cells["cn_dunit"].Value.ToString();
                                newrow["unitprice"] = Convert.ToDouble(row.Cells["cn_oUnitPrice"].Value);
                                newrow["custorder"] = row.Cells["cn_custorder"].Value.ToString();
                                newrow["delivplace"] = row.Cells["cn_ddelivplace"].Value.ToString();
                                newrow["delivaddress"] = row.Cells["cn_daddress"].Value.ToString();
                                newrow["custarticle"] = row.Cells["cn_custarticle"].Value.ToString();
                                newrow["comments"] = row.Cells["cn_dcomments"].Value.ToString();
                                newrow["resale"] = Convert.ToInt32(row.Cells["cn_resale"].Value);

                                data1.Rows.Add(newrow);
                            }

                        }
                    }
                    SetCellsColor();
                }
            }
        }

        public void CheckDelivQty()
        {
            if (QtyLefToSendCO < Qty
                && QtyLefToSendCO != 0)
            {//MessageBox.Show("Qty in order less than in delivery!");
                KryptonTaskDialog.Show("Qty warning!",
                                           "Qty in order less than in delivery!",
                                            "",
                                            MessageBoxIcon.Warning,
                                            TaskDialogButtons.OK);

                txt_Qty.StateActive.Back.Color1 = Color.Tomato;
            }
            else
                txt_Qty.StateActive.Back.Color1 = Color.White;
        }

        public double QtyLeftToSendToCO(int coid)
        {

            double _res = 0;

            foreach (DataGridViewRow row in this.gv_Delivery.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_dcoid"].Value) == coid)
                    _res = _res + Convert.ToDouble(row.Cells["cn_dqty"].Value);
            }

            return _res;
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gv_List.CurrentRow.Cells["btn_add"].Selected == true)
                    gv_List.CurrentRow.Cells["cn_totake"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);

                double _res = 0;

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    _res = _res + Convert.ToDouble(row.Cells["cn_totake"].Value);
                }
                if (cmb_Batches1.BatchId == 0)
                {
                    if (_res > AvailableQty)
                    {
                        gv_List.CurrentRow.Cells["cn_totake"].Value = AvailableQty - (_res - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value));
                    }
                }

                Qty = RecalcDelivQty();
                RecalcWeightNet();
                //if (UnitPrice == 0)
                CostUnitPrice = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_unitprice"].Value);

                CheckDelivQty();
                CheckUnitPrice();
            }
            catch { }
        }

        private void cmb_Units1_UnitChanged(object sender)
        {
            CoefConv = DAL.UnitRecalc(cmb_Articles1.UnitId, UnitId);

            if (CoefConv == 0)
                CoefConv = 1;

            UnitPrice = Math.Round(OrigUnitPrice / CoefConv, 5);

        }

        private void txt_CoefConv_TextChanged(object sender, EventArgs e)
        {
            double _CC = 1;
            if (CoefConv == 0)
                _CC = 1;
            else
                _CC = CoefConv;

            UnitPrice = Math.Round(OrigUnitPrice / _CC, 5);
        }

        #endregion

        #region Methods

        public void ClearCODets()
        {
            COId = 0;
            ConfOrder = "";
            CustOrder = "";
            CustArticle = "";
            //Qty = 0;
            UnitPrice = 0;
            CoefConv = 1;
            UnitId = cmb_Articles1.UnitId;
            QtyLefToSendCO = 0;
            CostUnitPrice = 0;
            Comments = "";
            OrigUnitPrice = 0;
        }

        public void ClearFields()
        {
            COId = 0;
            ConfOrder = "";
            CustOrder = "";
            CustArticle = "";
            Qty = 0;
            UnitPrice = 0;
            CoefConv = 1;
            UnitId = cmb_Articles1.UnitId;
            QtyLeftToSend = 0;
            CustCodeId = 0;
            UnitId = 0;
            Comments = "";
            CostUnitPrice = 0;
            OrigUnitPrice = 0;

        }

        public void RecalcWeightNet()
        {
            //double _res = 0;
            WeightNet = cmb_Articles1.Weight * Qty;
            //return _res;
        }

        public void ShowDets()
        {
            bwStart(bw_List);
            AvailableQty = ShowAvailQty(ArticleId);
            RecalcLeftToSend();
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_Delivery.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_did"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Yellow;
                if (Convert.ToInt32(row.Cells["cn_resale"].Value) == -1)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Orange;

            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            var data = DelivNote_BLL.getStockBatch(BatchId, ArticleId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });

            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_List;
            });

            if (BatchId != 0)
            {
                data1 = StockIn_BLL.getStockInBatchDelivery(BatchId);

                gv_Delivery.ThreadSafeCall(delegate
                {
                    gv_Delivery.AutoGenerateColumns = false;
                    bs_Delivery.DataSource = data1;
                    gv_Delivery.DataSource = bs_Delivery;
                    SetCellsColor();
                });
            }
            else
            {
                data1 = StockIn_BLL.getStockInArticleDelivery(-99/*ArticleId*/);

                gv_Delivery.ThreadSafeCall(delegate
                {
                    gv_Delivery.AutoGenerateColumns = false;
                    bs_Delivery.DataSource = data1;
                    gv_Delivery.DataSource = bs_Delivery;
                    SetCellsColor();
                });
            }


        }

        public void ShowDetsArt()
        {
            var data = DelivNote_BLL.getStockBatch(BatchId, ArticleId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });

            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_List;
            });

            if (BatchId != 0)
            {
                data1 = StockIn_BLL.getStockInBatchDelivery(BatchId);

                gv_Delivery.ThreadSafeCall(delegate
                {
                    gv_Delivery.AutoGenerateColumns = false;
                    bs_Delivery.DataSource = data1;
                    gv_Delivery.DataSource = bs_Delivery;

                });
            }
            else
            {
                data1 = StockIn_BLL.getStockInArticleDelivery(-99/*ArticleId*/);

                gv_Delivery.ThreadSafeCall(delegate
                {
                    gv_Delivery.AutoGenerateColumns = false;
                    bs_Delivery.DataSource = data1;
                    gv_Delivery.DataSource = bs_Delivery;

                });
            }
        }

        public double RecalcDelivQty()
        {
            double _res = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _res = _res + Convert.ToDouble(row.Cells["cn_totake"].Value);
            }
            return _res;
        }

        public double ShowAvailQty(int _artid)
        {
            double _res = 0;

            _res = Convert.ToDouble(Helper.GetOneRecord("select dbo.fn_QtyAvailable(" + _artid + ")"));

            return _res;
        }

        public void CheckUnitPrice()
        {
            if (OrigUnitPrice < CostUnitPrice)
                txt_UnitPrice.StateDisabled.Back.Color1 = Color.Tomato;
            else
                txt_UnitPrice.StateDisabled.Back.Color1 = Color.Gainsboro;
        }

        public void RecalcLeftToSend()
        {
            int _coid = 0;
            try
            {
                _coid = Convert.ToInt32(gv_Delivery.CurrentRow.Cells["cn_dcoid"].Value);
                QtyLefToSendCO = QtyLeftToSendToCO(_coid);
            }
            catch { ClearCODets(); }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            bool _checkarticle = true;
            int _artid = 0;
            int _prevartid = 0;
            int _checkerror = 0;
            //string _testarticle = "";
            //foreach (DataGridViewRow row1 in gv_List.Rows)
            //{
            //    _testarticle = row1.Cells["cn_article"].Value.ToString();
            //    if (_testarticle.Trim().ToUpper() != cmb_Articles1.Article.Trim().ToUpper())
            //    {
            //        _checkarticle = false;
            //        break;
            //    }
            //}

            if (HeadId != 0
            && Qty > 0
            && _checkarticle != false)
            {

                DataTable dataout = new DataTable();
                dataout.Columns.Add("headid", typeof(int));
                dataout.Columns.Add("artid", typeof(int));
                dataout.Columns.Add("labelid", typeof(int));
                dataout.Columns.Add("qty", typeof(double));
                dataout.Columns.Add("reqid", typeof(int));
                dataout.Columns.Add("comments", typeof(string));

                foreach (DataGridViewRow row in gv_List.Rows)
                {
                    if (Convert.ToDouble(row.Cells["cn_totake"].Value) > 0)
                    {
                        _prevartid = _artid;

                        DataRow dr = dataout.NewRow();
                        dr["headid"] = HeadId;
                        dr["artid"] = Convert.ToInt32(row.Cells["cn_artid"].Value);
                        dr["labelid"] = Convert.ToInt32(row.Cells["cn_label"].Value);
                        dr["qty"] = Convert.ToDouble(row.Cells["cn_totake"].Value);
                        dr["reqid"] = 0;
                        dr["comments"] = row.Cells["cn_comments"].Value.ToString();

                        dataout.Rows.Add(dr);

                        _artid = Convert.ToInt32(row.Cells["cn_artid"].Value);

                        if (_prevartid != _artid && _prevartid != 0)
                        {
                            _checkerror++;
                        }

                    }

                }

                if (Internal == -1
                    && cmb_Articles1.RMId == 0)
                    _checkerror++;

                if (_checkerror > 0)
                {
                    globClass.ShowMessage("Delivery warning!",
                        "Please check articles!",
                        "You want to make delivery for batch with different articles or you have no PF for internal delivery!");
                }
                else
                {
                    bool _test = true;

                    if (cmb_Batches1.BatchId != 0
                        && COId == 0)
                    {
                        DialogResult result1 = KryptonTaskDialog.Show("Delivery warning!",
                                                                  "Are you want to save changes?",
                                                                  "You want to make delivery for batch without confirmation orders!",
                                                                  MessageBoxIcon.Warning,
                                                                  TaskDialogButtons.Yes |
                                                                  TaskDialogButtons.No);
                        if (result1 == DialogResult.Yes)
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
                        int _res = DLBll.AddDeliveryLine(HeadId, _artid, COId, CustArticle, Qty, CoefConv, UnitId, UnitPrice, Comments,
                                                        WeightNet, WeightBrut, cmb_CustCodes1.CustCode, PackQty, Package, dataout, Return);

                        if (_res != 0)
                        {
                            if (Internal == -1)
                                DLBll.AddDeliveryLineInternal(_res);

                            if (StockDeliveryLineSaved != null)
                                StockDeliveryLineSaved(this);
                            bwStart(bw_List);
                        }
                        else
                        {
                            MessageBox.Show("Delivery line was not saved!");
                        }
                    }
                }
            }
        }

        private void gv_List_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }


        #endregion

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Qty = RecalcDelivQty();
                RecalcWeightNet();
                CostUnitPrice = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_unitprice"].Value);

                CheckDelivQty();
                CheckUnitPrice();
            }
            catch { }
        }

        private void btn_DeleteOrderLine_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gv_Delivery.SelectedRows)
            {
                gv_Delivery.Rows.Remove(row);
            }
        }

        private void frm_AddDeliveryDets_Load(object sender, EventArgs e)
        {
            data1 = StockIn_BLL.getStockInArticleDelivery(-99);
            gv_Delivery.ThreadSafeCall(delegate
            {
                gv_Delivery.AutoGenerateColumns = false;
                bs_Delivery.DataSource = data1;
                gv_Delivery.DataSource = bs_Delivery;
                SetCellsColor();
            });
        }
    }
}
