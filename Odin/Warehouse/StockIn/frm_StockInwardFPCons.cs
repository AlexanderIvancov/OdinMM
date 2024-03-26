using AdvancedDataGridView;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.StockOut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Odin.Warehouse.StockIn
{
    public partial class frm_StockInwardFPCons : KryptonForm
    {
        public frm_StockInwardFPCons()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
            databoxes = new DataTable();
            databoxes.Columns.Add("id", typeof(int));

        }


        #region Variables

        ProgressForm wait;

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        StockIn_BLL SIBll = new StockIn_BLL();
        StockOut_BLL SOBLL = new StockOut_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
        DataTable databoxes;

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

        public string SecArticle
        {
            get { return txt_SecArticle.Text; }
            set { txt_SecArticle.Text = value; }
        }

        public string CustArticle
        {
            get { return txt_CustArticle.Text; }
            set { txt_CustArticle.Text = value; }
        }
        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }
        public string DelivPlace
        {
            get { return txt_DelivPlace.Text; }
            set { txt_DelivPlace.Text = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string ConfOrder
        {
            get { return txt_ConfOrder.Text; }
            set { txt_ConfOrder.Text = value; }
        }

        public int PlaceId
        {
            get { return cmb_Places1.PlaceId; }
            set { cmb_Places1.PlaceId = value; }
        }

        public double QtyOnStage
        {
            get; set;
        }

        public double QtyIncomeBefore
        { get; set; }

        public double QtyInBatch
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyInBatch.Text); }
                catch { return 0; }
            }
            set { txt_QtyInBatch.Text = value.ToString(); }
        }

        public double QtyIn
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyIn.Text); }
                catch { return 0; }
            }
            set { txt_QtyIn.Text = value.ToString(); }
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

        public double QtyAfter
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyAfter.Text); }
                catch { return 0; }
            }
            set { txt_QtyAfter.Text = value.ToString(); }
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

        public double Weight
        {
            get
            {
                try { return Convert.ToDouble(txt_Weight.Text); }
                catch { return 0; }
            }
            set { txt_Weight.Text = value.ToString(); }
        }

        public double QtyOnShelf(int ArtId, int PlaceId)
        {
            var param = new List<SqlParameter>
                {
                    new SqlParameter("@ArtId", SqlDbType.Int) {Value = ArtId},
                    new SqlParameter("@PlaceId", SqlDbType.Int) {Value = PlaceId}
                };

            try
            {
                return Convert.ToDouble(Helper.GetOneRecord("SELECT DISTINCT Sum(qty) from STO_Rests WHERE artid = @ArtId AND placeid = @PlaceId and qty > 0", param.ToArray()));
            }
            catch { return 0; }

        }
        public int ReadValue = 0;

        int _packid = 0;

        public int PackingId
        {
            get { return _packid; }
            set { _packid = value; }
        }

        public int ConfOrderId
        { get; set; }

        bool _FromBox = false;

        public string bCustArticle = "";
        public string bDelivPlace = "";
        public string bSecArticle = "";
        public string bConfOrder = "";
        public int bConfOrderId = 0;

        #endregion

        #region Methods

        public void ShowHeader(int _batchid)
        {
            //MessageBox.Show(_batchid.ToString());
            SIBll.BIdIn = _batchid;

            if (SIBll.BCountCO <= 1
                || _FromBox == true)
            {
                foreach (Form f in Application.OpenForms)
                {
                    //f.BringToFront();
                    if (f.Name == "frm_SelectCO")
                    {
                        f.Close();
                    }
                }
                ArticleId = SIBll.BArtId;
                if (_batchid == 0)
                    cmb_Articles1.Article = "";
                CustArticle = _FromBox == false ? SIBll.BCustArticle : bCustArticle;
                DelivPlace = _FromBox == false ? SIBll.BDelivPlace : bDelivPlace;
                QtyInBatch = SIBll.BQtyLeft;
                QtyIn = SIBll.BQtyLeft;
                QtyIncomeBefore = SIBll.BQtyIn;
                SecArticle = _FromBox == false ? SIBll.BSecArticle : bSecArticle;
                UnitPrice = SIBll.BUnitPrice;
                ConfOrder = _FromBox == false ? SIBll.BConfOrder : bConfOrder;
                ConfOrderId = _FromBox == false ? SIBll.BCOid : bConfOrderId;
                
            }
            else
            {
                ArticleId = 0;
                cmb_Articles1.Article = "";
                CustArticle = "";
                DelivPlace = "";
                QtyInBatch = 0;
                QtyIn = 0;
                QtyIncomeBefore = 0;
                SecArticle = "";
                UnitPrice = 0;
                ConfOrder = "";
                ConfOrderId = 0;

                if (glob_Class.IsFormAlreadyOpen("frm_SelectCO"))
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        //f.BringToFront();
                        if (f.Name == "frm_SelectCO")
                        {
                            frm_SelectCO frm = (frm_SelectCO)f;
                            frm.HeaderText = "Select COs";
                            frm.COSelected += new COSelectionEventHandler(SelectCO);
                            frm.FillCO(BatchId);
                            frm.SetCellsColor();
                            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
                        }
                    }
                }
                else
                {
                    frm_SelectCO frm = new frm_SelectCO();
                    frm.HeaderText = "Select COs";
                    frm.COSelected += new COSelectionEventHandler(SelectCO);
                    frm.FillCO(BatchId);
                    frm.SetCellsColor();

                    frm.Show(); frm.GetKryptonFormFields();
                    frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
                }
                databoxes.Clear();

                RecalcRMConsumption(QtyIn, cmb_Batches1.Qty);

            }


            QtyBefore = QtyOnShelf(ArticleId, PlaceId);

            PackingId = 0;
            _FromBox = false;

            ShowImage(DAL.ImagePath(ArticleId));

        }

        public void ShowDets()
        {
            //cmb_Batches1.ThreadSafeCall(delegate { bwStart(bw_List); });
            ShowDetsIn();
        }

        private void SelectCO(DataGridView gridview)
        {
            double _tmpqty = 0;
            int _tmpcoid = 0;
            int _tmpartid = 0;
            string _tmpconforder = "";
            string _tmpsecname = "";
            string _tmpdeliveryplace = "";

            gridview.EndEdit();

            foreach (DataGridViewRow row in gridview.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_add"].Value) == -1)
                {
                    DataRow dr = databoxes.NewRow();
                    dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                    databoxes.Rows.Add(dr);
                    _tmpqty = Convert.ToDouble(row.Cells["cn_qty"].Value);
                    _tmpcoid = Convert.ToInt32(row.Cells["cn_id"].Value);
                    _tmpartid = Convert.ToInt32(row.Cells["cn_artid"].Value);
                    _tmpconforder = row.Cells["cn_conforder"].Value.ToString();
                    _tmpsecname = row.Cells["cn_secname"].Value.ToString();
                    _tmpdeliveryplace = row.Cells["cn_deliveryplace"].Value.ToString();

                    break;
                }
            }

            ArticleId = _tmpartid;

            CustArticle = _tmpsecname;
            DelivPlace = _tmpdeliveryplace;
            QtyInBatch = _tmpqty;
            QtyIn = _tmpqty;//_tmpqty > QtyInBatch ? QtyInBatch : _tmpqty;
            QtyIncomeBefore = SIBll.BQtyIn;
            UnitPrice = SIBll.BUnitPrice;
            SecArticle = _tmpsecname;
            ConfOrder = _tmpconforder;
            ConfOrderId = _tmpcoid;

        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            var data = (DataTable)Helper.getSP("sp_SelectBatchStockInDets", BatchId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            var data1 = (DataTable)Helper.getSP("sp_SelectBatchDeliveryRests", BatchId);

            gv_Delivery.ThreadSafeCall(delegate
            {
                gv_Delivery.AutoGenerateColumns = false;
                bs_Delivery.DataSource = data1;
                gv_Delivery.DataSource = bs_Delivery;

            });

        }

        public void ShowDetsIn()
        {

            var data = (DataTable)Helper.getSP("sp_SelectBatchStockInDets", BatchId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            var data1 = (DataTable)Helper.getSP("sp_SelectBatchDeliveryRests", BatchId);

            gv_Delivery.ThreadSafeCall(delegate
            {
                gv_Delivery.AutoGenerateColumns = false;
                bs_Delivery.DataSource = data1;
                gv_Delivery.DataSource = bs_Delivery;

            });

            if (chk_Consume.CheckState == CheckState.Checked)
            {
                ShowRMConsumption();
            }
            else
            {
                tgv_List.Nodes.Clear();
            }
        }

        public void ShowRMConsumption()
        {
            tgv_List.ThreadSafeCall(delegate
            {
                tgv_List.Nodes.Clear();
                TreeGridNode node;
                Font boldFont = new Font(tgv_List.DefaultCellStyle.Font, FontStyle.Bold);


                var data2 = (DataTable)Helper.getSP("sp_SelectBatchStockInRMRests", BatchId);

                foreach (System.Data.DataRow dr in data2.AsEnumerable().OrderBy(a => a.Field<string>("unit"))
                                                                                    .ThenBy(a => a.Field<int>("artid")))
                {
                    //MessageBox.Show(dr["id"].ToString());

                    node = tgv_List.Nodes.Add(null, dr["artid"], dr["artid"], dr["article"], "", dr["qtyreserved"],
                                                        dr["unit"], "0", dr["id"], dr["qty"], dr["qtybom"], dr["given"],
                                                        dr["analogues"], "", "", dr["numdecimals"]);

                    if (Convert.ToDouble(dr["qtyreserved"]) <= 0)
                    {
                        foreach (DataGridViewCell cell in node.Cells)
                        {
                            cell.Style.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        foreach (DataGridViewCell cell in node.Cells)
                        {
                            cell.Style.BackColor = Color.Azure;
                        }
                    }
                    node.ImageIndex = 1;

                }
                //Add details nodes
                var datad = (DataTable)Helper.getSP("sp_SelectStockOutcomeRMForProceed", BatchId);

                foreach (System.Data.DataRow dr1 in datad.AsEnumerable().OrderBy(d => d.Field<string>("unit"))
                                                                        .ThenBy(d => d.Field<int>("artid"))
                                                                        .ThenBy(d => d.Field<DateTime>("launchdate"))
                                                                        .ThenBy(d => d.Field<DateTime>("expdate"))
                                                                        .ThenBy(d => d.Field<DateTime>("regdate"))
                                                                        .ThenBy(d => d.Field<double>("qtyreserved"))
                                                                        .ThenBy(d => d.Field<int>("label")))
                {
                    //MessageBox.Show(dr1["artid"].ToString() + " / " + dr1["label"].ToString());
                    foreach (TreeGridNode node1 in this.tgv_List.Nodes)
                    {
                        if (Convert.ToInt32(node1.Cells["cn_artid"].Value) == Convert.ToInt32(dr1["artid"]))
                            AddNode(dr1, boldFont, node1.Nodes, true);
                    }
                }

                foreach (TreeGridNode node1 in tgv_List.Nodes)
                {
                    ExpandNodes(node1);
                }


            });
        }

        private void ShowImage(string Path)
        {
            try
            {

                pic_Image.ImageLocation = Path;
                pic_Image.Load();


            }
            catch
            {

                pic_Image.Image = null;
            }

        }

        public bool CheckEmpty()
        {
            bool _res = false;

            if (cmb_Places1.PlaceId == 0
                || QtyIn <= 0
                || UnitPrice < 0
                || Weight <= 0)
            {
                _res = false;
                btn_OK.Enabled = false;
            }
            else
            {
                _res = true;
                btn_OK.Enabled = true;
            }
            return _res;
        }

        public bool CheckRMConsumption()
        {
            bool _res = true;

            foreach (TreeGridNode node in tgv_List.Nodes)
            {
                if (Convert.ToInt32(node.Cells["cn_qtyinbatch"].Value) > 0 &&
                    (Convert.ToDouble(node.Cells["cn_qtytogive"].Value) > Convert.ToDouble(node.Cells["cn_qtyonlabel"].Value)
                    || Convert.ToDouble(node.Cells["cn_qtyonlabel"].Value) <= 0))
                {
                    _res = false;
                    break;
                }
            }

            return _res;
        }

        public void CheckRMConsumptionMessages()
        {

            foreach (TreeGridNode node in tgv_List.Nodes)
            {
                if ((Convert.ToInt32(node.Cells["cn_qtyinbatch"].Value) > 0 &&
                    (Convert.ToDouble(node.Cells["cn_qtytogive"].Value) > Convert.ToDouble(node.Cells["cn_qtyonlabel"].Value)
                    || Convert.ToDouble(node.Cells["cn_qtyonlabel"].Value) <= 0))
                    && (Convert.ToInt32(node.Cells["cn_qtyinbatch"].Value) > Convert.ToInt32(node.Cells["cn_qtygiven"].Value)))

                {
                    KryptonTaskDialog.Show("Warning!!!",
                                           "Please check qty for " + node.Cells["cn_article"].Value.ToString() + "!",
                                            "",
                                            MessageBoxIcon.Warning,
                                            TaskDialogButtons.OK);
                }
            }
        }

        public void RecalcRMConsumption(double qtyin, double qtyinbatch)
        {
            double qtygiven = 0;
            double qtytogive = 0;
            double price = 0;

            if (qtyinbatch == 0)
                qtyinbatch = 1;


            foreach (TreeGridNode node in tgv_List.Nodes)
            {
                price = 0;



                qtytogive = Math.Round(((Convert.ToDouble(node.Cells["cn_qtyinbatch"].Value) / qtyinbatch) * qtyin)
                                //Possible deficite, QtyInBatch - left to receive on FCS
                                + ((Convert.ToDouble(node.Cells["cn_qtyinbatch"].Value) / qtyinbatch) * QtyIncomeBefore/*(qtyinbatch - (QtyInBatch < 0 ? 0 : QtyInBatch))*/)
                                //Already given
                                - Convert.ToDouble(node.Cells["cn_qtygiven"].Value), Convert.ToInt32(node.Cells["cn_roundnum"].Value));


                if (qtytogive > 0
                    && node.HasChildren)
                {
                    foreach (TreeGridNode childnode in node.Nodes)
                    {
                        if (Convert.ToDouble(childnode.Cells["cn_qtyonlabel"].Value) > qtytogive)
                        {
                            childnode.Cells["cn_qtytogive"].Value = qtytogive;
                            qtytogive = 0;
                            qtygiven = qtygiven + Convert.ToDouble(childnode.Cells["cn_qtytogive"].Value);
                            price = price + Math.Round((Convert.ToDouble(childnode.Cells["cn_qtytogive"].Value) * Convert.ToDouble(childnode.Cells["cn_tvunitprice"].Value)), 5);
                            break;
                        }
                        else
                        {
                            childnode.Cells["cn_qtytogive"].Value = Convert.ToDouble(childnode.Cells["cn_qtyonlabel"].Value);
                            qtytogive = qtytogive - Convert.ToDouble(childnode.Cells["cn_qtyonlabel"].Value);
                            qtygiven = qtygiven + Convert.ToDouble(childnode.Cells["cn_qtytogive"].Value);
                            price = price + Math.Round((Convert.ToDouble(childnode.Cells["cn_qtytogive"].Value) * Convert.ToDouble(childnode.Cells["cn_tvunitprice"].Value)), 5);
                        }

                    }
                    node.Cells["cn_qtytogive"].Value = qtygiven + qtytogive;
                    node.Cells["cn_tvunitprice"].Value = price;
                }
                else
                {
                    node.Cells["cn_qtytogive"].Value = 0;
                    node.Cells["cn_tvunitprice"].Value = 0;
                }

                if (Convert.ToDouble(node.Cells["cn_qtytogive"].Value) > Convert.ToDouble(node.Cells["cn_qtyonlabel"].Value)
                    || Convert.ToDouble(node.Cells["cn_qtyonlabel"].Value) <= 0)
                {
                    foreach (DataGridViewCell cell in node.Cells)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in node.Cells)
                    {
                        cell.Style.BackColor = Color.Azure;
                    }
                }

                qtygiven = 0;
            }
            double _unitprice = 0;

            foreach (TreeGridNode node in tgv_List.Nodes)
            {
                _unitprice = _unitprice + Math.Round(Convert.ToDouble(node.Cells["cn_tvunitprice"].Value), 5);
            }
            UnitPrice = _unitprice / (QtyIn == 0 ? 1 : QtyIn);
        }

        public void ShowTots()
        {
            QtyPlaced = QtyIn;
            QtyAfter = QtyBefore + QtyPlaced;
        }

        public void ExpandNodes(TreeGridNode node)
        {
            foreach (TreeGridNode node1 in node.Nodes)
            {
                node.Expand();
                ExpandNodes(node1);
            }
        }

        private void AddNode(DataRow dr, Font boldFont, TreeGridNodeCollection nodes, bool isAddingImage)
        {
            TreeGridNode node;
            string _tempexpdate = Convert.ToDateTime(dr["expdate"]) != Convert.ToDateTime("01/01/2199")
                ? Convert.ToDateTime(dr["expdate"]).ToShortDateString()
                : Convert.ToDateTime(dr["regdate"]).ToShortDateString();
            //DataGridViewCell cell;


            node = nodes.Add(null, dr["artid"], dr["artid"], dr["article"], dr["label"], dr["qtyreserved"],
                                                   dr["unit"], "0", dr["id"], "0", "0", "0", "", _tempexpdate,
                                                   dr["unitprice"], dr["numdecimals"]);

            //if (Convert.ToDateTime(dr["expdate"]) == Convert.ToDateTime("01/01/2199"))
            //{
            //    cell = node.Cells["cn_expdate"];
            //    cell.Style.BackColor = Color.LightGray;
            //}


            //if (Convert.ToInt32(node.Parent.Cells["cn_BatchId"].Value) == Convert.ToInt32(dr["batchdetid"]))
            //{//Color
            //    foreach (DataGridViewCell cell in node.Cells)
            //    {
            //        cell.Style.BackColor = Color.LightGray;
            //    }
            //}
            //else if (Convert.ToInt32(dr["usage"]) == 0)
            //{
            //    foreach (DataGridViewCell cell in node.Cells)
            //    {
            //        cell.Style.BackColor = Color.LightGray;
            //    }
            //}
            //else if (Convert.ToInt32(node.Parent.Cells["cn_BatchId"].Value) != Convert.ToInt32(dr["batchdetid"])
            //        && Convert.ToInt32(dr["batchdetid"]) != 0)
            //{
            //    foreach (DataGridViewCell cell in node.Cells)
            //    {
            //        cell.Style.BackColor = Color.PapayaWhip;//Color.Bisque;
            //    }
            //}
            //else
            //{

            //}


            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }

        }


        public void RecalcTotalForParent(TreeGridNode node)
        {
            double _Total = 0;
            foreach (TreeGridNode node1 in node.Nodes)
                _Total = _Total + Convert.ToDouble(node1.Cells["cn_qtytogive"].Value);
            node.Cells["cn_qtytogive"].Value = _Total;
            //Color and font

            //if (_Total > Convert.ToDouble(node.Cells["cn_LeftInBatch"].Value))
            //{
            //    node.Cells["cn_QtyToGive"].Style.BackColor = Color.Bisque;
            //}
            //else
            //{
            //    node.Cells["cn_QtyToGive"].Style.BackColor = Color.Azure;//Color.LightGray;
            //}

            if (Convert.ToDouble(node.Cells["cn_qtytogive"].Value) < Math.Round((Convert.ToDouble(node.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty) * QtyIn, 5))
                foreach (DataGridViewCell cell in node.Cells)
                    cell.Style.BackColor = Color.Red;
            else
                foreach (DataGridViewCell cell in node.Cells)
                    cell.Style.BackColor = Color.Azure;

        }
        #endregion

        #region Controls

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowHeader(BatchId);
            ShowDets();
            ShowTots();
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            Unit = cmb_Articles1.Unit;
            Weight = cmb_Articles1.Weight;
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            //MessageBox.Show(cmb_Batches1.BatchId.ToString());
            if (cmb_Batches1.BatchId != 0)
            {
                string _res = DAL.AddBatchLock(cmb_Batches1.BatchId, this.Name);
                if (_res != "")
                {
                    DialogResult result1 = KryptonTaskDialog.Show("You can not work with such batch!",
                                                                 "This batch is locked by: " + _res,
                                                                 "",
                                                                 MessageBoxIcon.Warning,
                                                                 TaskDialogButtons.OK);
                    cmb_Batches1.BatchId = 0;
                }
            }
            else
            {
                DAL.DeleteBatchLock(cmb_Batches1.BatchId, this.Name);
            }

            ShowHeader(BatchId);
            ShowDets();
            ShowTots();

            RecalcRMConsumption(QtyIn, cmb_Batches1.Qty);
            txt_Oper.Text = string.Empty;
        }

        private void pic_Image_DoubleClick(object sender, EventArgs e)
        {
            frm_FullImage frm = new frm_FullImage();
            frm.HeaderText = "Image for: " + ArticleId.ToString();
            frm.ShowImage(DAL.ImagePath(ArticleId));

            DialogResult result = frm.ShowDialog();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            btn_OK.Enabled = false;
            int _resout = 0;

            CheckRMConsumptionMessages();
            //if (chk_Consume.CheckState == CheckState.Unchecked
            //    || (chk_Consume.CheckState == CheckState.Checked
            //    && CheckRMConsumption() == true))
            {
                //Check if packkind batch is the same with FC batch
                int _tmpbatch = 0;
                int _tmpboxid = 0;
                foreach (DataRow row in databoxes.Rows)
                {
                    _tmpboxid = Convert.ToInt32(row["id"]);
                }

                //_tmpbatch = Convert.ToInt32(Helper.GetOneRecord("select top 1 isnull(nullif(bh.groupid, 0), batchid) as batchid from STO_DelivPackMapping pm left join PROD_BatchHead bh on bh.id = pm.batchid where packid = " + _tmpboxid));
                try
                {
                    _tmpbatch = Convert.ToInt32(Helper.GetOneRecord("select top 1 isnull(nullif(bh.groupid, 0), batchid) as batchid from STO_DelivPackMapping pm left join PROD_BatchHead bh on bh.id = pm.batchid where packid = " + _tmpboxid));
                }
                catch { _tmpbatch = 0; }
                if (BatchId != _tmpbatch)
                    databoxes.Clear();
                //
                string _res = SIBll.AddStockInFP(cmb_Articles1.ArticleId, QtyIn, UnitPrice, BatchId, PlaceId, Comments, databoxes, ConfOrderId);

                if (_res != "")
                {
                    if (chk_Consume.CheckState == CheckState.Checked)
                    //Consumption of RM
                    {
                        foreach (TreeGridNode node in this.tgv_List.Nodes)

                        {
                            ExpandNodes(node);

                            int _batchdetid = Convert.ToInt32(node.Cells["cn_batchid"].Value);
                            int _artid = Convert.ToInt32(node.Cells["cn_artid"].Value);
                            double _qtytogive = Convert.ToDouble(node.Cells["cn_qtytogive"].Value);

                            //if (_batchdetid != 0
                            //            && _qtytogive >= _qtyrest)
                            //    _removereservation = -1;

                            //Labels
                            foreach (TreeGridNode node1 in node.Nodes)
                            {
                                if (Convert.ToDouble(node1.Cells["cn_qtytogive"].Value) > 0)
                                {
                                    //Add stock out
                                    _resout = SOBLL.AddStockOutLineCons(_resout, Convert.ToInt32(node1.Cells["cn_tvlabel"].Value),
                                                                Convert.ToDouble(node1.Cells["cn_qtytogive"].Value),
                                                                _artid, _batchdetid, SIBll.InsertedId, "");

                                }
                            }
                        }

                        //Recalculate of cost of stock-in

                        Helper.getSP("sp_RecalculateFCPrice", SIBll.InsertedId, BatchId, System.DateTime.Now.ToShortDateString());


                        KryptonTaskDialog.Show("New stock consumption document for batch was created!",
                                            "Consumption document NO: " + SOBLL.OutcomeDocResult + " was created!",
                                            "",
                                            MessageBoxIcon.Information,
                                            TaskDialogButtons.OK);

                        //Check cost price and sales price
                        if (DAL.CheckCostPriceTab(SIBll.InsertedId) == false)
                        {
                            string strMessage = "";
                            string emailaddresses = "";
                            emailaddresses = DAL.EmailAddressesByType(12);
                            strMessage = "Batch: " + cmb_Batches1.Batch;
                            strMessage = strMessage + "\r\nArticle: " + cmb_Batches1.Article;
                            strMessage = strMessage + "\r\nCust. article: " + cmb_Batches1.CustArticle;
                            strMessage = strMessage + "\r\nCO price: " + DAL.ccpCOPrice;
                            strMessage = strMessage + "\r\nCost price: " + DAL.ccpInPrice;
                            //MyHelper.SendMessageWS(emailaddresses, "Batch " + cmb_Batches1.Batch + " cost price > 70% of sales price!", strMessage);
                            MyHelper.SendDirectEMail(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Batch " + cmb_Batches1.Batch + " cost price > 70% of sales price!", strMessage);
                        }

                    }

                    KryptonTaskDialog.Show("New stock income for batch was created!",
                                            "Documents NO: " + _res + " was created!",
                                            "",
                                            //"Quantity you want to enter is more than left in batch! ",
                                            MessageBoxIcon.Information,
                                            TaskDialogButtons.OK);
                }
                else
                    KryptonTaskDialog.Show("Mistake during stock-in!",
                                           "Document was not created!",
                                            "",
                                            MessageBoxIcon.Warning,
                                            TaskDialogButtons.OK);


                ShowHeader(BatchId);
                ShowDets();
                ShowTots();
                RecalcRMConsumption(QtyIn, cmb_Batches1.Qty);
                txt_Oper.Text = string.Empty;
                PackingId = 0;
                databoxes.Clear();
                btn_OK.Enabled = true;
            }
            //else
            //{
            //    KryptonTaskDialog.Show("Mistake during stock-in!",
            //                           "You are trying to make error consumption for RM!",
            //                            "Please check RM consumption lines!",
            //                            MessageBoxIcon.Exclamation,
            //                            TaskDialogButtons.OK);
            //}
        }

        private void txt_QtyIn_TextChanged(object sender, EventArgs e)
        {
            bool _res = CheckEmpty();

            //if (chk_Consume.CheckState == CheckState.Checked)
            //{
            //    ShowRMConsumption();
            //    RecalcRMConsumption(QtyIn, cmb_Batches1.Qty);
            //}
            //else
            //{
            //    tgv_List.Nodes.Clear();
            //}

            //ShowTots();
        }


        private void cmb_Places1_SelectedValueChanged(object sender)
        {
            bool _res = CheckEmpty();

            QtyBefore = QtyOnShelf(ArticleId, PlaceId);
            ShowTots();
        }

        private void txt_QtyIn_Leave(object sender, EventArgs e)
        {
            if (QtyIn < 0)
                QtyIn = 0;

            //if (QtyIn > QtyInBatch)
            //{
            //    DialogResult result1 = KryptonTaskDialog.Show("Quantity income is more than than qty on last stage!",
            //                                                         "Are you want to save changes?",
            //                                                         "Quantity you want to enter is more than qty on last stage! ",
            //                                                         MessageBoxIcon.Warning,
            //                                                         TaskDialogButtons.Yes |
            //                                                         TaskDialogButtons.No);
            //    if (result1 == DialogResult.No)
            //    {
            //        QtyIn = QtyInBatch;
            //    }
            //}

            if (QtyIn > QtyInBatch)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Quantity income is more than than qty on last stage!",
                                                                     "You can't make income qty more than on last stage!",
                                                                     "Quantity you want to enter is more than qty on last stage! ",
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.OK);

                QtyIn = QtyInBatch;
            }

            //if (CheckRMConsumption() == false)
            //{
            //    btn_OK.Enabled = false;
            //}

            if (chk_Consume.CheckState == CheckState.Checked)
            {
                ShowRMConsumption();
                RecalcRMConsumption(QtyIn, cmb_Batches1.Qty);
            }
            else
            {
                tgv_List.Nodes.Clear();
            }

            ShowTots();
        }


        #endregion

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void txt_QtyIn_Validated(object sender, EventArgs e)
        {

        }

        private void chk_Consume_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Consume.CheckState == CheckState.Checked)
            {
                ShowRMConsumption();
                RecalcRMConsumption(QtyIn, cmb_Batches1.Qty);
            }
            else
            {
                tgv_List.Nodes.Clear();
                UnitPrice = SIBll.BUnitPrice;
            }
        }

        private void tgv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double OutVal = 0;

            try
            {
                TreeGridNode node = tgv_List.CurrentNode;
                TreeGridNode parentnode = node.Parent;

                tgv_List.EndEdit();
                if (tgv_List.CurrentRow.Cells["cn_qtytogive"].Selected == true)
                {
                    //if (Convert.ToDateTime(DocDate) >= Convert.ToDateTime(node.Cells["cn_InDate"].Value.ToString()))
                    //{

                    try
                    { OutVal = Convert.ToDouble(node.Cells["cn_qtytogive"].Value); }
                    catch { OutVal = -1; }

                    if (OutVal == -1)
                        node.Cells["cn_qtytogive"].Value = 0;


                    if (Convert.ToDouble(node.Cells["cn_qtyonlabel"].Value) < Convert.ToDouble(node.Cells["cn_qtytogive"].Value))
                        node.Cells["cn_qtytogive"].Value = Convert.ToDouble(node.Cells["cn_qtyonlabel"].Value);


                    RecalcTotalForParent(parentnode);


                }

            }
            catch { }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _placeid = 0;
            try
            {
                _placeid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_iplaceid"].Value);
            }
            catch { }

            cmb_Places1.PlaceId = _placeid;
        }

        private void frm_StockInwardFPCons_FormClosing(object sender, FormClosingEventArgs e)
        {
            DAL.DeleteBatchLock(cmb_Batches1.BatchId, this.Name);
        }

        private void chk_scanbox_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_scanbox.CheckState == CheckState.Checked)
            {
                chk_scanbox.BackColor = Color.LightPink;
                txt_Oper.Focus();
            }
            else
            {
                chk_scanbox.BackColor = Color.LightGreen;
                cmb_Batches1.Focus();
            }
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int _tmpartid = 0;

            if (e.KeyChar == (char)Keys.Enter
                && chk_scanbox.Checked == true)
            {
                databoxes.Clear();
                if (txt_Oper.Text.Substring(0, 1) == "B")
                {
                    bool _check = Int32.TryParse(txt_Oper.Text.Substring(1), out ReadValue);
                    //PackingId = ReadValue;
                    if (_check == true)
                    {
                        SqlConnection conn = new SqlConnection(sConnStr);
                        conn.Open();
                        DataSet ds = new DataSet();

                        SqlDataAdapter adapter =
                            new SqlDataAdapter(
                                "select top 1 isnull(bmain.id, dl.batchid) as batchid, dl.qty, isnull(bchild.artid, bmain.artid) as artid from sto_delivpackmapping dl " +
                                            "inner join PROD_BatchHead bchild on bchild.id = dl.batchid " +
                                            "left join PROD_BatchHead bmain on bmain.id = bchild.groupid " +
                                            "where packid = " + ReadValue + " and isnull(inid, 0) = 0 and isnull(delivid, 0) = 0", conn);

                        adapter.Fill(ds);

                        DataTable dt = ds.Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            BatchId = Convert.ToInt32(dt.Rows[0]["batchid"]);
                            ArticleId = Convert.ToInt32(dt.Rows[0]["artid"]);
                            DataRow dr = databoxes.NewRow();
                            dr["id"] = ReadValue;
                            databoxes.Rows.Add(dr);

                            if (QtyInBatch < Convert.ToDouble(dt.Rows[0]["qty"]))
                            {
                                DialogResult result1 = KryptonTaskDialog.Show("Qty on FCS stage and in box are incorrect!",
                                                                        "Qty on FCS stage and in box are incorrect!",
                                                                        "Be careful! You must move on stage FCS at the first!",
                                                                        MessageBoxIcon.Warning,
                                                                        TaskDialogButtons.OK);

                                QtyIn = 0;
                                databoxes.Clear();
                                //PackingId = 0;
                            }
                            else
                            {
                                QtyIn = Convert.ToDouble(dt.Rows[0]["qty"]);
                            }


                            cmb_Batches1.Focus();
                        }
                        else
                        {
                            DialogResult result1 = KryptonTaskDialog.Show("There is no such registered box label!",
                                                                        "Box already registered or label is incorrect!",
                                                                        "There is no such registered box label!",
                                                                        MessageBoxIcon.Warning,
                                                                        TaskDialogButtons.OK);
                        }
                        conn.Close();
                    }
                    else
                    {
                        DialogResult result1 = KryptonTaskDialog.Show("There is no such registered box label!",
                                                                         "Impossible to read batch!",
                                                                         "There is no such registered box label!",
                                                                         MessageBoxIcon.Warning,
                                                                         TaskDialogButtons.OK);
                    }
                }
                else
                {
                    DialogResult result1 = KryptonTaskDialog.Show("There is no such registered box label!",
                                                                     "Impossible to read batch!",
                                                                     "There is no such registered box label!",
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.OK);
                }
                chk_scanbox.CheckState = CheckState.Unchecked;
                chk_scanbox.BackColor = Color.LightGreen;
            }
        }

        private void btn_SelectBoxFromList_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_SelectBox")) return;

            databoxes.Clear();

            frm_SelectBox frm = new frm_SelectBox();
            frm.HeaderText = "Select boxes";
            frm.BoxSelected += new BoxSelectionEventHandler(SelectBatchFromBoxes);
            frm.FillBoxes();
            frm.SetCellsColor();

            frm.Show(); frm.GetKryptonFormFields();
            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
        }

        private void SelectBatchFromBoxes(int _readvalue, DataGridView gridview)
        {
            _FromBox = true;
            double _tmpqty = 0;
            int _tmpbatch = 0;
            int _tmparticle = 0;
            int _tmpcoid = 0;

            databoxes.Clear();
            gridview.EndEdit();

            foreach (DataGridViewRow row in gridview.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_add"].Value) == -1)
                {
                    DataRow dr = databoxes.NewRow();
                    dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                    databoxes.Rows.Add(dr);
                    _tmpqty = _tmpqty + Convert.ToDouble(row.Cells["cn_qty"].Value);
                    _tmpbatch = Convert.ToInt32(row.Cells["cn_groupid"].Value);
                    _tmparticle = Convert.ToInt32(row.Cells["cn_artid"].Value);
                    _tmpcoid = Convert.ToInt32(row.Cells["cn_coid"].Value);
                    bCustArticle = row.Cells["cn_custarticle"].Value.ToString();
                    bDelivPlace = row.Cells["cn_delivplace"].Value.ToString();
                    bSecArticle = row.Cells["cn_secname"].Value.ToString();
                    bConfOrder = row.Cells["cn_conforder"].Value.ToString();
                }
            }

            bConfOrderId = _tmpcoid;
            if (bConfOrderId == 0)
                _FromBox = false;
            BatchId = _tmpbatch;
            ArticleId = _tmparticle;



            if (QtyInBatch < _tmpqty)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Qty on FCS stage and in box are incorrect!",
                                                        "Qty on FCS stage and in box are incorrect!",
                                                        "Be careful! You must move on stage FCS at the first!",
                                                        MessageBoxIcon.Warning,
                                                        TaskDialogButtons.OK);

                QtyIn = 0;
                databoxes.Clear();
            }
            else
            {
                QtyIn = _tmpqty;
            }

            if (chk_Consume.CheckState == CheckState.Checked)
            {
                ShowRMConsumption();
                RecalcRMConsumption(QtyIn, cmb_Batches1.Qty);
            }

            cmb_Batches1.Focus();


            /*SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "select top 1 batchid, qty from sto_delivpackmapping where packid = " + _readvalue + " and isnull(inid, 0) = 0 and isnull(delivid, 0) = 0", conn);

            adapter.Fill(ds);



            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                BatchId = Convert.ToInt32(dt.Rows[0]["batchid"]);
                PackingId = _readvalue;

                if (QtyInBatch < Convert.ToDouble(dt.Rows[0]["qty"]))
                {
                    DialogResult result1 = KryptonTaskDialog.Show("Qty on FCS stage and in box are incorrect!",
                                                            "Qty on FCS stage and in box are incorrect!",
                                                            "Be careful! You must move on stage FCS at the first!",
                                                            MessageBoxIcon.Warning,
                                                            TaskDialogButtons.OK);

                    QtyIn = 0;
                    PackingId = 0;
                }
                else
                {
                    QtyIn = Convert.ToDouble(dt.Rows[0]["qty"]);
                }


                cmb_Batches1.Focus();
            }
            else
            {
                DialogResult result1 = KryptonTaskDialog.Show("There is no such registered box label!",
                                                            "Box already registered or label is incorrect!",
                                                            "There is no such registered box label!",
                                                            MessageBoxIcon.Warning,
                                                            TaskDialogButtons.OK);
            }
            conn.Close();
            */
        }



        private void btn_MapToBox_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_SelectBox")) return;

            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_SelectBox frm = new frm_SelectBox();
                frm.HeaderText = "Select boxes";
                frm.BoxSelected += new BoxSelectionEventHandler(SelectBatchFromBoxesNotMapped);
                frm.FillBoxesNotMapped(_id);
                frm.SetCellsColor();

                frm.Show(); frm.GetKryptonFormFields();
                frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
            }
        }
        private void SelectBatchFromBoxesNotMapped(int _readvalue, DataGridView gridview)
        {
            double _tmpqty = 0;

            databoxes.Clear();
            gridview.EndEdit();

            int _id = 0;
            double _lefttomap = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _lefttomap = Math.Round(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_mapped"].Value), 5);
            }
            catch { }

            foreach (DataGridViewRow row in gridview.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_add"].Value) == -1)
                    _tmpqty = _tmpqty + Convert.ToDouble(row.Cells["cn_qty"].Value);
            }
            if (_tmpqty == _lefttomap)
            {
                foreach (DataGridViewRow row in gridview.Rows)
                {
                    if (Convert.ToInt32(row.Cells["chk_add"].Value) == -1)
                        Helper.getSP("sp_MapStockInBox", _id, Convert.ToInt32(row.Cells["cn_id"].Value));
                }
                ShowDetsIn();
                txt_Oper.Text = string.Empty;
            }
            else
            {
                globClass.ShowMessage("Qty mapping warning", "Please check qty and try again", "Qty you want to map is not correct!");
            }

        }

        private void btn_FindOrder_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_SelectCO")) return;

            databoxes.Clear();

            frm_SelectCO frm = new frm_SelectCO();
            frm.HeaderText = "Select COs";
            frm.COSelected += new COSelectionEventHandler(SelectCO);
            frm.FillCO(BatchId);
            frm.SetCellsColor();

            frm.Show(); frm.GetKryptonFormFields();
            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
        }
    }
}
