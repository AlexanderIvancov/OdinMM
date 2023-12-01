using AdvancedDataGridView;
using Odin.Global_Classes;
using Odin.Sales;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Planning.Controls
{
    public delegate void SaveBatchEventHandler(object sender);
    public partial class ctl_CreatBatchDets : UserControl
    {
        public ctl_CreatBatchDets()
        {
            InitializeComponent();
        }

        #region Variables

        public event SaveBatchEventHandler SaveBatch;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DLL = new DAL_Functions();
        

        public bool tmpValidated = false;

        public int BatchId
        { get; set; }

        public string Batch
        {
            get { return txt_Batch.Text; }
            set { txt_Batch.Text = value; }
        }
        public double QtyInBatch
        {
            get { try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; } }
            set { txt_Qty.Text = value.ToString(); }

        }

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public int COrderId
        {
            get { return cmb_SalesOrdersWithLines1.SalesOrderLineId; }
            set { cmb_SalesOrdersWithLines1.SalesOrderLineId = value; }
        }

        public string StartDate
        {
            get
            {
                if (txt_StartDate.Value == null)
                    return "";
                else
                    return txt_StartDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_StartDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_StartDate.Value = null; }
            }
        }
        public string EndDate
        {
            get
            {
                if (txt_EndDate.Value == null)
                    return "";
                else
                    return txt_EndDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_EndDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_EndDate.Value = null; }
            }
        }
        
        public string Serials
        { get; set; }
        /*public string StartDate
        {
            get { return txt_StartDate.Value.ToShortDateString(); }
            set
            {
                try { txt_StartDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }*/
        /*
        public string EndDate
        {
            get { return txt_EndDate.Value.ToShortDateString(); }
            set
            {
                try { txt_EndDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }*/

        public double fOldQtyInBatch
        { get; set; }
        public int fOldArticleId
        { get; set; }
        public string fOldComments
        { get; set; }
        public string fOldStartDate
        { get; set; }
        public string fOldEndDate
        { get; set; }
        public int fOldUrgent
        { get; set; }
        public int Urgent
        {
            get { if (chk_Urgent.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set {
                if (value == -1)
                    chk_Urgent.Checked = true;
                else
                    chk_Urgent.Checked = false;
            }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        int _SpoilType = 0;

        public int AllSpoil
        {
            get
            {
                return _SpoilType;
            }
            set
            {
                _SpoilType = value;
                if (_SpoilType == 0)
                {
                    //Without spoilage
                    btn_Spoilage.Text = "All without spoilage";
                    btn_Spoilage.Image = Global_Resourses.trash_green;
                }
                else
                {
                    btn_Spoilage.Image = Global_Resourses.trash_red;
                    btn_Spoilage.Text = "All with spoilage";
                    //With spoilage
                }

            }
        }

        public int _EditMode1 = 0; //-by default - new 

        public int _EditMode
        {
            get { return _EditMode1; }
            set
            {
                _EditMode1 = value;
                //if (_EditMode1 == 0)
                //{
                //    btn_AddGamme.Enabled = false;
                //    btn_EditBatchGamme.Enabled = false;
                //    btn_DeleteGamme.Enabled = false;
                //}
                //else
                //{
                //    btn_AddGamme.Enabled = true;
                //    btn_EditBatchGamme.Enabled = true;
                //    btn_DeleteGamme.Enabled = true;
                //}

            }
        }
       
        string _tmpBatchName = "";

        #endregion

        #region Methods

        public void FillAutoDoc()
        {
            Batch = DLL.AutoDoc(3, System.DateTime.Now.ToShortDateString());
        }

        public bool CheckEmpty()
        {
            if (ArticleId == 0
                || QtyInBatch == 0
                || StartDate == ""
                //|| EndDate == ""
                //|| (Convert.ToDateTime(StartDate) > Convert.ToDateTime(EndDate))
                )
                return false;
            else
                return true;

        }

        public void ClearNorm()
        {
            tv_BOM.Nodes.Clear();
        }

        public void SetCellsColor()
        {
            try
            {
                foreach (DataGridViewRow row in this.tv_BOM.Rows)
                {
                    row.Cells["cn_nQtyDefault"].Style.BackColor = Color.Silver;
                    if (Convert.ToDouble(row.Cells["cn_nSubProdQty"].Value) > 0)
                        row.Cells["cn_nSubProdQty"].Style.BackColor = Color.Yellow;
                    if (Convert.ToDouble(row.Cells["cn_nQtyAvailable"].Value) + Convert.ToDouble(row.Cells["cn_nWaitingPOQty"].Value) + Convert.ToDouble(row.Cells["cn_qtyqiven"].Value)
                                        < Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value))
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Style.BackColor = Color.MistyRose;
                        }
                    }
                }
            }
            catch { }
        }

        public void FillGridNew(int ArtId, double QtyInBatch)
        {

            tv_BOM.Nodes.Clear();

            Font boldFont = new Font(tv_BOM.DefaultCellStyle.Font, FontStyle.Bold);

            var data = PlanBll.NomDetailsDataCB(ArtId, QtyInBatch);

            foreach (System.Data.DataRow dr in data.AsEnumerable().OrderBy(d => d.Field<int>("Num")))
            {
                AddNode(dr, boldFont, tv_BOM.Nodes, true);
            }

            tv_BOM.Focus();
            foreach (TreeGridNode node1 in tv_BOM.Nodes)
            {
                ExpandNodes(node1);
            }

            if (AllSpoil == -1)
            {
                foreach (TreeGridNode node in this.tv_BOM.Nodes)
                {
                    RecalcQtyBatch(node, -1, QtyInBatch);
                }
            }
            else
            {
                foreach (TreeGridNode node in this.tv_BOM.Nodes)
                {
                    RecalcQtyBatch(node, 0, QtyInBatch);
                }
            }

            FillBatchUnits();
            SetCellsColor();
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

            node = nodes.Add(null, dr["Article"], dr["CreateSB"], dr["ArtId"], dr["Unit"],
                            Convert.ToDouble(dr["Qty"]), Convert.ToDouble(dr["QtyInBatch"]), Convert.ToDouble(dr["QtyForSubBatch"]),
                            0, 0, "0", dr["IsSubProd"], dr["CSEArtId"], 0, 0,
                            Convert.ToDouble(dr["QtyOnStock"]), Convert.ToDouble(dr["QtyAvailable"]),
                            Convert.ToDouble(dr["WaitingPOQty"]), dr["WaitingPODate"].ToString(), dr["POrder"].ToString(),
                            dr["Supplier"].ToString(), Convert.ToDouble(dr["QtyForSubBatch"]),
                            Convert.ToDouble(dr["QtyNom"]), Convert.ToDouble(dr["SpoilNorm"]), 
                            Convert.ToInt32(dr["NumDecimals"]), Convert.ToDouble(dr["SpoilConst"]), "", dr["Stage"], "", -1, 0, 0);

            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }

            //SetRowColor(dr, node);


            if (dr["IsSubProd"].ToString() == "-1")
            {
                node.Expand();
                node.DefaultCellStyle.Font = boldFont;
                node.DefaultCellStyle.ForeColor = Color.Red;

                var data1 = PlanBll.NomDetailsDataCB(Convert.ToInt32(dr["ArtId"]), Convert.ToDouble(dr["Qty"])/*fQtyInBatch*/);
                foreach (System.Data.DataRow dr1 in data1.AsEnumerable().OrderBy(d => d.Field<int>("Num")))
                {
                    AddNode(dr1, boldFont, node.Nodes, true);
                }

                //node.Collapse();
                //node.Expand();


                if (Convert.ToDouble(dr["QtyForSubBatch"]) == 0
                    && node.HasChildren == true)
                {

                    foreach (TreeGridNode node1 in node.Nodes)
                    {
                        node1.Cells["cn_nCheck"].Value = 0;
                        node1.Cells["cn_nQtyInBatch"].Value = 0;
                    }
                }
                node.Collapse();
            }
        }
        
        public void FillGridBatch(int BatchId)
        {
            tv_BOM.Nodes.Clear();
            Font boldFont = new Font(tv_BOM.DefaultCellStyle.Font, FontStyle.Bold);
            //TreeGridNode node;
            //MessageBox.Show(fQtyInBatch.ToString());
            var data = PlanBll.NomDetailsDataBatch(BatchId);

            foreach (System.Data.DataRow dr in data.AsEnumerable().OrderBy(d => d.Field<int>("bdid")))
            {
                AddNodeBatch(dr, boldFont, tv_BOM.Nodes, true);
            }
            FillBatchUnits();

            foreach (TreeGridNode node1 in tv_BOM.Nodes)
            {
                ExpandNodes(node1);
            }
            SetCellsColor();
        }

        private void AddNodeBatch(DataRow dr, Font boldFont, TreeGridNodeCollection nodes, bool isAddingImage)
        {
            TreeGridNode node;
            node = nodes.Add(null, dr["Article"], -1, dr["artid"], dr["Unit"],
                             Math.Round(Convert.ToDouble(dr["QtyInNomenclature"]), 5), Convert.ToDouble(dr["QtyInBatch"]),
                             Convert.ToDouble(dr["QtyForSubBatch"]), 0, 
                             Convert.ToDouble(dr["QtyInBatch"]), dr["bdid"], 0, dr["CSEArtId"], Convert.ToInt32(dr["ParentBatchId"]),
                             Convert.ToInt32(dr["BatchHeadId"]), Convert.ToDouble(dr["QtyOnStock"]), Convert.ToDouble(dr["QtyAvailable"]),
                            Convert.ToDouble(dr["WaitingPOQty"]), dr["WaitingPODate"].ToString(), dr["POrder"].ToString(), 
                            dr["Supplier"].ToString(), Convert.ToDouble(dr["QtyForSubBatch"]),
                            Convert.ToDouble(dr["QtyNom"]), Convert.ToDouble(dr["SpoilNorm"]), 
                            Convert.ToInt32(dr["NumDecimals"]), Convert.ToDouble(dr["SpoilConst"]),
                            dr["SubBatch"], dr["Stage"], dr["Comments"], Convert.ToInt32(dr["IsActive"]), Convert.ToDouble(dr["QtyGiven"])
                            , Convert.ToInt32(dr["DNP"]));

            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }

            //if (Math.Round(Convert.ToDouble(dr["QtyInNomenclature"]), 3) == 0
            //    && Convert.ToDouble(dr["QtyInBatch"]) > 0)
            //    node.Cells["cn_DiffPerc"].Style.BackColor = Color.LightGreen;
            //else if (Math.Round(Convert.ToDouble(dr["QtyInNomenclature"]), 3) > 0
            //            && Convert.ToDouble(dr["QtyInBatch"]) == 0)
            //    node.Cells["cn_DiffPerc"].Style.BackColor = Color.LightPink;
            //else if (Math.Round(Convert.ToDouble(dr["QtyInNomenclature"]), 3) > Convert.ToDouble(dr["QtyInBatch"]))
            //{
            //    node.Cells["cn_nQtyDefault"].Style.Font = new Font(this.Font, FontStyle.Bold);
            //    node.Cells["cn_nQtyDefault"].Style.ForeColor = Color.Red;
            //}

            //SetRowColor(dr, node);


            if (dr["ParentBatchId"].ToString() != "0")
            {
                //node.Expand();
                node.DefaultCellStyle.Font = boldFont;
                node.DefaultCellStyle.ForeColor = Color.Red;

                var data1 = PlanBll.NomDetailsDataBatch(Convert.ToInt32(dr["ParentBatchId"]));
                foreach (System.Data.DataRow dr1 in data1.AsEnumerable().OrderBy(d => d.Field<int>("bdid")))
                {
                    AddNodeBatch(dr1, boldFont, node.Nodes, false);
                }

            }
        }

        public void FillBatchUnits()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            string _tmpUnit = "";
            int _k = 0;
            foreach (DataGridViewRow row in tv_BOM.Rows)
            {
                _k = 0;
                _tmpUnit = row.Cells["cn_nUnit"].Value.ToString().Trim();
                foreach (DataRow raw1 in dt.Rows)
                {
                    if (raw1["Unit"].ToString().Trim() == _tmpUnit)
                        _k++;
                }
                if (_k == 0)
                {
                    DataRow _addrow = dt.NewRow();
                    _addrow["Unit"] = _tmpUnit;
                    dt.Rows.Add(_addrow);
                }
            }

            cmb_Unit.ComboBox.DataSource = dt;
            cmb_Unit.ComboBox.DisplayMember = "Unit";
            cmb_Unit.ComboBox.ValueMember = "Unit";
        }

        public void FillDecNum()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(Int32)));

            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());


            dt.Rows[0][0] = 0;
            dt.Rows[1][0] = 1;
            dt.Rows[2][0] = 2;
            dt.Rows[3][0] = 3;
            dt.Rows[4][0] = 4;

            cmb_Decimals.ComboBox.DataSource = dt;
            cmb_Decimals.ComboBox.DisplayMember = "Id";
            cmb_Decimals.ComboBox.ValueMember = "Id";
        }

        public void RecalcQtyBatch(TreeGridNode node, int Spoilage, double QtyCSE)
        {
            double _tmpPerc = 0;
            double _tmpQtyCSE = 0;
            double _tmpQtyRM = 0;
            double _tmpQtyWOSpoil = 0;
            double _tmpQtyWithSpoil = 0;
            _tmpPerc = (100 + Convert.ToDouble(node.Cells["cn_nSpoilNorm"].Value)) / 100;
            _tmpQtyWOSpoil = Math.Round(QtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                            , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
            _tmpQtyWithSpoil = Math.Round(QtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                            * _tmpPerc + Convert.ToDouble(node.Cells["cn_nSpoilConst"].Value)
                                                                            , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));

            if (node.HasChildren == true)
            {
                //Recalc CSE QTY
                if (Spoilage == -1)
                {
                    if (_tmpQtyWithSpoil > Convert.ToDouble(node.Cells["cn_nQtyAvailable"].Value))
                        _tmpQtyCSE = _tmpQtyWithSpoil - Convert.ToDouble(node.Cells["cn_nQtyAvailable"].Value);
                    else
                         _tmpQtyCSE = 0;
                    _tmpQtyRM = _tmpQtyWithSpoil - _tmpQtyCSE;
                }
                else
                {
                    if (_tmpQtyWOSpoil > Convert.ToDouble(node.Cells["cn_nQtyAvailable"].Value))
                        _tmpQtyCSE = _tmpQtyWOSpoil - Convert.ToDouble(node.Cells["cn_nQtyAvailable"].Value);
                    else
                        _tmpQtyCSE = 0;
                    _tmpQtyRM = _tmpQtyWOSpoil - _tmpQtyCSE;
                }

                node.Cells["cn_nSubProdQty"].Value = _tmpQtyCSE;
                node.Cells["cn_nQtyInBatch"].Value = _tmpQtyRM;

               

                //Recalc children qty 
                foreach (TreeGridNode node1 in node.Nodes)
                {
                    RecalcQtyBatch(node1, Spoilage, _tmpQtyCSE);
                }

            }
            else
            {
                if (Spoilage == -1)
                {

                    node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWithSpoil;
                }
                else
                    node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWOSpoil;
            }
            SetCellsColor();
        }

        public void RecalcQtyInNomenclature()
        {
            foreach (DataGridViewRow row in this.tv_BOM.Rows)
            {
                if (QtyInBatch != fOldQtyInBatch
                    && Math.Round(Convert.ToDouble(row.Cells["cn_nQtyDefOldB"].Value), 3) != 0)
                {
                    if (Math.Round(Convert.ToDouble(row.Cells["cn_nQtyNom"].Value), 3) != 0)
                        row.Cells["cn_nQtyInBatch"].Value = Math.Round(Convert.ToDouble(row.Cells["cn_nQtyNom"].Value) * QtyInBatch, 3);
                    //if (fOldQtyInBatch != 0)
                    //cn_nQtyNom
                    //row.Cells["cn_nQtyInBatch"].Value = Math.Round((Convert.ToDouble(row.Cells["cn_nQtyDefOldB"].Value) -
                    //Convert.ToDouble(row.Cells["cn_nSpoilConst"].Value)) / fOldQtyInBatch * QtyInBatch 
                    //                                    + Convert.ToDouble(row.Cells["cn_nSpoilConst"].Value), 3);
                    //else
                        //row.Cells["cn_nQtyInBatch"].Value = Math.Round(Convert.ToDouble(row.Cells["cn_nQtyDefOldB"].Value) * QtyInBatch + Convert.ToDouble(row.Cells["cn_nSpoilConst"].Value), 3);
                    
                    if (QtyInBatch == 0)
                        row.Cells["cn_nQtyInBatch"].Value = 0;
                }
                else
                {
                    row.Cells["cn_nQtyInBatch"].Value = Convert.ToDouble(row.Cells["cn_nQtyDefOldB"].Value);
                }
            }
        }

        public void FillNewOrderLine(int id, int coid, string order, string line, string article, int artid, 
                                double qty, string reqdate, string customer, double qtyinbatch)
        {
            DataRow row = dt_Orders.NewRow();

            row["id"] = id;
            row["coid"] = coid;
            row["order"] = order;
            row["line"] = line;
            row["article"] = article;
            row["artid"] = artid;
            row["qty"] = qty;
            row["reqdate"] = reqdate;
            row["customer"] = customer;
            row["qtyforbatch"] = qtyinbatch;

            dt_Orders.Rows.Add(row);
        }

        public void FillExistedLines(int batchid)
        {
            ClearOrders();

            //sp_SelectSalesOrdersMappings
            var data = CO_BLL.getBatchMappings(batchid);

            foreach (DataRow row1 in data.Rows)
            {
                FillNewOrderLine(Convert.ToInt32(row1["id"]), Convert.ToInt32(row1["coid"]), row1["corder"].ToString(), row1["orderline"].ToString(), 
                                row1["article"].ToString(), Convert.ToInt32(row1["artid"]),  Convert.ToDouble(row1["qty"]), row1["reqdate"].ToString(),
                                row1["customer"].ToString(), Convert.ToDouble(row1["qtylinked"]));
            }

            //gv_Orders.ThreadSafeCall(delegate
            //{
            //    gv_Orders.AutoGenerateColumns = false;
            //    bs_Orders.DataSource = data;
            //    gv_Orders.DataSource = bs_Orders;

            //});
        }

        public void ClearOrders()
        {
            ds_Orders.Clear();
        }

        public void RecalcQtyInBatch()
        {
            double _tmpqty = 0;
            foreach (DataGridViewRow row in this.gv_Orders.Rows)
            {
                _tmpqty = _tmpqty + Convert.ToDouble(row.Cells["cn_oqty"].Value);
            }
            QtyInBatch = _tmpqty;
        }

        public void FillDates()
        {
            txt_EndDate.Value = System.DateTime.Now;
            txt_EndDate.Value = null;
            txt_StartDate.Value = System.DateTime.Now;
            txt_StartDate.Value = null;
        }

        public void RecalcQtyInGrid()
        {
            double _tmpqty = QtyInBatch;
            
            foreach (DataGridViewRow row in this.gv_Orders.Rows)
            {
                if (_tmpqty > Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value))
                {
                    row.Cells["cn_oqty"].Value = Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value);
                    _tmpqty = _tmpqty - Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value);
                }
                else
                {

                    row.Cells["cn_oqty"].Value = _tmpqty;
                    _tmpqty = 0;
                }
                
            }

        }

        #endregion

        #region Controls

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tv_BOM.Nodes.Clear();
        }

        private void tv_BOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tv_BOM.EndEdit();
            TreeGridNode node;
            node = tv_BOM.CurrentNode;
            int _tmpSpoil = 0;
            if (tv_BOM.CurrentRow.Cells["cn_nWithSpoil"].Selected == true)
            {
                tv_BOM.EndEdit();
                if (Convert.ToInt16(tv_BOM.CurrentRow.Cells["cn_nWithSpoil"].Value) == -1)
                    _tmpSpoil = -1;
                else
                    _tmpSpoil = 0;

                double _tmpQtyCSE = 0;
                    //Recalc RM QTY
                if (node.Level == 1)
                    _tmpQtyCSE = QtyInBatch;
                else
                    _tmpQtyCSE = Convert.ToDouble(node.Parent.Cells["cn_nSubProdQty"].Value);


                double _tmpPerc = 0;

                double _tmpQtyWOSpoil = 0;
                double _tmpQtyWithSpoil = 0;
                _tmpPerc = (100 + Convert.ToDouble(node.Cells["cn_nSpoilNorm"].Value)) / 100;
                _tmpQtyWOSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
                _tmpQtyWithSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                * _tmpPerc + Convert.ToDouble(node.Cells["cn_nSpoilConst"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
                if (Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value) > 0
                            && node.HasChildren == true)
                {
                    if (_tmpSpoil == 0)
                        node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWOSpoil - Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value);
                    else
                        node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWithSpoil - Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value);
                    //Recalc children
                    foreach (TreeGridNode node1 in node.Nodes)
                    {
                        RecalcQtyBatch(node1, _tmpSpoil, Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value));
                    }
                }
                else
                {
                    if (_tmpSpoil == 0)
                        node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWOSpoil;
                    else
                        node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWithSpoil;
                }

            }
        }
        
        private void btn_Spoilage_Click(object sender, EventArgs e)
        {
            if (_EditMode == 0)
            {

                if (AllSpoil == 0)
                    AllSpoil = -1;
                else
                    AllSpoil = 0;

                if (AllSpoil == -1)
                {
                    foreach (TreeGridNode node in this.tv_BOM.Nodes)
                    {
                        RecalcQtyBatch(node, -1, QtyInBatch);
                    }
                }
                else
                {
                    foreach (TreeGridNode node in this.tv_BOM.Nodes)
                    {
                        RecalcQtyBatch(node, 0, QtyInBatch);
                    }
                }
            }
        }
        
        private void btn_AddSubProduct_Click(object sender, EventArgs e)
        {
            if (_EditMode == 0)
            {
                //New, adding only in treegrid
                frm_AddBatchRMLine frm = new frm_AddBatchRMLine();
                frm.Id = 0;
                frm.HeaderText = "Add new RM for batch: " + Batch;
                TreeGridNode node;
                node = tv_BOM.CurrentNode;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                    try
                    {
                        node.Nodes.Add(null, frm.Article, -1, frm.ArtId, frm.Unit,
                                    frm.Qty, frm.Qty, 0, 0, 0, 0, 0, ArticleId,
                                    0, 0, frm.QtyStock, frm.QtyAvailable, frm.WaitingPO, frm.DelivDate, frm.POrder, frm.Supplier,
                                    0, frm.Qty / (QtyInBatch == 0 ? 1 : QtyInBatch), 0, 0, 0, "", frm.Stage);
                    }
                    catch { }
            }
            else
            {
                //Edit, directly in batch!
                MessageBox.Show("Please insert line directly in sub-batch!");
            }
        }

        private void btn_DeleteNorm_Click(object sender, EventArgs e)
        {
            if (_EditMode == 0)
            {
                //New!
                TreeGridNode node;
                node = tv_BOM.CurrentNode;
                tv_BOM.Nodes.Remove(node);
            }
            else
            {
                //Modify directly in batch
                if (glob_Class.DeleteConfirm() == true)
                {
                    DataGridViewRow row;
                    row = this.tv_BOM.CurrentRow;

                    try
                    {
                        if (Convert.ToInt32(row.Cells["cn_nChildBatchId"].Value) != 0)
                        {
                            if (PlanBll.DeleteBatch(Convert.ToInt32(this.tv_BOM.CurrentRow.Cells["cn_nChildBatchId"].Value)) == -1)
                            {
                                MessageBox.Show("Deletion of batch was succesfull!");
                                FillGridBatch(BatchId);
                            }
                            else
                                MessageBox.Show("Error during batch deletion!");
                        }

                        if (PlanBll.DeleteBatchDetail(Convert.ToInt32(this.tv_BOM.CurrentRow.Cells["cn_nBatchId"].Value)) == 1)
                        {
                            MessageBox.Show("Deletion of detail was succesfull!");
                            FillGridBatch(BatchId);
                        }
                        else
                            MessageBox.Show("Error during batch line deletion!");

                    }
                    catch { }

                }


            }
        }

        private void btn_AddNorm_Click(object sender, EventArgs e)
        {
            if (_EditMode == 0)
            {
                frm_AddBatchRMLine frm = new frm_AddBatchRMLine();
                frm.Id = 0;
                frm.HeaderText = "Add new RM for batch: " + Batch;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (cmb_Articles1.ArticleId == frm.ArtId)
                    {
                        if (QtyInBatch >= frm.Qty)
                        {
                            FillGridNew(ArticleId, QtyInBatch - frm.Qty);
                        }
                        else
                        {
                            ClearNorm();
                        }
                    }


                    tv_BOM.Nodes.Add(null, frm.Article, -1, frm.ArtId, frm.Unit,
                                     frm.Qty, frm.Qty, 0, 0, 0, 0, 0, ArticleId,
                                     0, 0, frm.QtyStock, frm.QtyAvailable, frm.WaitingPO, frm.DelivDate, frm.POrder, frm.Supplier,
                                     0, frm.Qty / (QtyInBatch == 0 ? 1 : QtyInBatch), 0, 0, 0, "", frm.Stage, "", frm.IsActive, frm.DNP);
                }
            }
            else
            {
                frm_AddBatchRMLine frm = new frm_AddBatchRMLine();
                frm.Id = 0;
                frm.HeaderText = "Add new RM for batch ID: " + tv_BOM.CurrentRow.Cells["cn_nBatchHeadId"].Value.ToString();
                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    if (frm.SubBatch == 0)
                    {
                        PlanBll.AddBatchDetail(Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_nBatchHeadId"].Value), frm.ArtId, frm.Qty, "");
                    }
                    else
                    {
                        PlanBll.AddBatchDetailSB(Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_nBatchHeadId"].Value), frm.ArtId, frm.Qty);
                    }
                    FillGridBatch(BatchId);
                }
            }
        }

        private void btn_Round_Click(object sender, EventArgs e)
        {
            tv_BOM.EndEdit();
            foreach (DataGridViewRow row in this.tv_BOM.Rows)
            {
                if (row.Cells["cn_nUnit"].Value.ToString().Trim() == cmb_Unit.Text.Trim())
                {
                    row.Cells["cn_nQtyInBatch"].Value = glob_Class.RoundUp(Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value), Convert.ToInt32(cmb_Decimals.Text));
                }
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            tv_BOM.EndEdit();
            if (_EditMode == 0) //New batch
            {
                //MessageBox.Show(COrderId.ToString());
                if (CheckEmpty() == false)
                    MessageBox.Show("Please check quantity and article and production dates of the batch!");
                else
                {
                    //Creation of header of new batch
                    int _id = PlanBll.AddBatchHeader("", ArticleId, QtyInBatch, StartDate, Comments, 0, 0, EndDate, Urgent);
                    if (_id != 0)
                    {
                        //Creation of the link between Client order and batch
                        foreach (DataRow row in dt_Orders.Rows)
                        {
                            if (Convert.ToDouble(row["qty"]) > 0
                                && Convert.ToInt32(row["artid"]) == cmb_Articles1.ArticleId)
                            PlanBll.AddBatchCOPOLink(_id, Convert.ToInt32(row["coid"]), 0, Convert.ToDouble(row["qty"]), 0, 0);
                        }
                        
                        _tmpBatchName = PlanBll.BatchName;
                        //Adding the details

                        tv_BOM.Invoke(new MethodInvoker(delegate
                        {
                            AddBatchDet(_id, tv_BOM.Nodes);
                        }
                        ));

                        MessageBox.Show("Batch NO: " + _tmpBatchName + " was created!");

                        btn_Clear.PerformClick();
                        Batch = _tmpBatchName;

                    }
                    else
                    {
                        MessageBox.Show("Error during creation of batch header!");
                    }

                    if (SaveBatch != null)
                    {
                        SaveBatch(this);
                    }
                }

            }
            else //Modification
            {
                int _tmp = 0;
                if (CheckEmpty() == false)
                    MessageBox.Show("Please check quantity and article of the batch!");
                else
                {
                    if (QtyInBatch != fOldQtyInBatch
                        || ArticleId != fOldArticleId
                        || Comments != fOldComments
                        || StartDate != fOldStartDate
                        || EndDate != fOldEndDate
                        || Urgent != fOldUrgent)
                    {
                        //Header
                        PlanBll.EditBatchHeader(BatchId, ArticleId, QtyInBatch, StartDate, Comments, EndDate, Urgent, "");

                    }
                        //Delete temporary deleted links
                        var data = CO_BLL.getBatchMappings(BatchId);
                        int k = 0;
                        int tmpid = 0;
                        foreach (DataRow row1 in data.Rows)
                        {
                            k = 0;
                            tmpid = Convert.ToInt32(row1["id"]);
                            foreach (DataRow row in dt_Orders.Rows)
                            {
                                if (Convert.ToInt32(row["id"]) == tmpid)
                                    k++;
                            }
                            if (k == 0)
                                PlanBll.DeleteBatchCOPOLink(tmpid);
                        }


                        //Edit links
                        foreach (DataRow row in dt_Orders.Rows)
                        {
                            if (Convert.ToDouble(row["qty"]) > 0
                                    && Convert.ToInt32(row["artid"]) == cmb_Articles1.ArticleId)
                                PlanBll.EditBatchCOPOLink(BatchId, Convert.ToInt32(row["coid"]), 0, Convert.ToDouble(row["qty"]), 0, 0);
                        }
                        
                        //Details
                        foreach (DataGridViewRow row in this.tv_BOM.Rows)
                        {
                            //Check for header
                            if (Convert.ToInt32(row.Cells["cn_nChildBatchId"].Value) != 0
                                && Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value) != Convert.ToDouble(row.Cells["cn_nQtyDefOldB"].Value))
                            {
                                PlanBll.EditBatchHeader(Convert.ToInt32(row.Cells["cn_nChildBatchId"].Value), Convert.ToInt32(row.Cells["cn_nArtId"].Value), Convert.ToInt32(row.Cells["cn_nQtyInBatch"].Value), StartDate, "", EndDate, Urgent, Serials);
                            }

                            //if (Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value) != Convert.ToDouble(row.Cells["cn_nQtyDefOldB"].Value))
                            PlanBll.EditBatchDetail(Convert.ToInt32(row.Cells["cn_nBatchId"].Value), Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value), row.Cells["cn_Comments"].Value.ToString(), Convert.ToInt32(row.Cells["cn_ndetisactive"].Value), Convert.ToInt32(row.Cells["cn_dnp"].Value));

                            if (Convert.ToInt32(row.Cells["cn_nBatchId"].Value) == 0
                                && Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value) > 0)
                                
                                _tmp = PlanBll.AddBatchDetail(Convert.ToInt32(row.Cells["cn_nBatchHeadId"].Value), Convert.ToInt32(row.Cells["cn_nArtId"].Value), Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value), row.Cells["cn_Comments"].Value.ToString());

                        }

                        if (SaveBatch != null)
                        {
                            SaveBatch(this);
                        }
                   
                }
            }
        }

        public void AddBatchDet(int _BatchId, TreeGridNodeCollection nodes)
        {
            int _BatchDetId = 0;   
            int _IdSB = 0;//Future id of subbatch

            //select temporary stage
            string _tmpstage = "";
            foreach (TreeGridNode node in nodes)
            {
                if (node.Cells["cn_nStage"].Value.ToString() != "")
                {
                    _tmpstage = node.Cells["cn_nStage"].Value.ToString();
                    break;
                }
            }
            string _Batch = "";
            if (_tmpstage != "")
                _Batch = _tmpBatchName + "/" + _tmpstage;

            foreach (TreeGridNode node in nodes)
            {
                //MessageBox.Show(glob_Class.NEN_Double(node.Cells["cn_nQtyInBatch"].Value.ToString()).ToString());
                if (glob_Class.NEN_Double(node.Cells[6].Value.ToString()) != 0
                    || node.HasChildren == true)
                {
                    _BatchDetId = PlanBll.AddBatchDetail(_BatchId, Convert.ToInt32(node.Cells["cn_nArtId"].Value),
                                                                        glob_Class.NEN_Double(node.Cells[6].Value.ToString()), node.Cells["cn_Comments"].Value.ToString());
                    node.Cells["cn_nBatchId"].Value = _BatchDetId;
                }
                if (
                    //Qty of sub-product more than 0!
                        glob_Class.NEN_Double(node.Cells[7].Value.ToString()) > 0
                        && node.HasChildren == true)
                {
                    //MessageBox.Show(_Batch);
                    //Sozdaem podpartiju
                    _IdSB = PlanBll.AddBatchHeader(_Batch, Convert.ToInt32(node.Cells["cn_nArtId"].Value), glob_Class.NEN_Double(node.Cells[7].Value.ToString()), StartDate, "Sub-Batch for batch id: " + _BatchId.ToString(), _BatchId, _BatchDetId, EndDate, Urgent);
                    //details
                    if (_IdSB != 0)
                    {
                        tv_BOM.Invoke(new MethodInvoker(delegate { AddBatchDet(_IdSB, node.Nodes); }));
                    }
                }
            }
            //LogBll.UpdateBatchRMState(_BatchId);
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void tv_BOM_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(tv_BOM.CurrentRow.Cells["cn_nSubProdQty"].Value.ToString());
            tv_BOM.EndEdit();
            TreeGridNode node;
            node = tv_BOM.CurrentNode;

            if (node.Cells["cn_nSubProdQty"].Selected == true
                && node.HasChildren == true)
            {
                double _tmpQtyCSE = 0;
                //Recalc RM QTY
                if (node.Level == 1)
                    _tmpQtyCSE = QtyInBatch;
                else
                    _tmpQtyCSE = Convert.ToDouble(node.Parent.Cells["cn_nSubProdQty"].Value);


                double _tmpPerc = 0;
                                
                double _tmpQtyWOSpoil = 0;
                double _tmpQtyWithSpoil = 0;
                _tmpPerc = (100 + Convert.ToDouble(node.Cells["cn_nSpoilNorm"].Value)) / 100;
                _tmpQtyWOSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
                _tmpQtyWithSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                * _tmpPerc + Convert.ToDouble(node.Cells["cn_nSpoilConst"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));

                if (AllSpoil == 0) 
                    node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWOSpoil - Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value);
                else
                    node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWithSpoil - Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value);
                //Recalc children
                foreach (TreeGridNode node1 in node.Nodes)
                {
                    RecalcQtyBatch(node1, AllSpoil, Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value));
                }
                
            }


            if (tv_BOM.CurrentRow.Cells["cn_nWithSpoil"].Selected == true)
            {
                int _tmpSpoil = 0;
                tv_BOM.EndEdit();
                if (Convert.ToInt16(tv_BOM.CurrentRow.Cells["cn_nWithSpoil"].Value) == -1)
                    _tmpSpoil = -1;
                else
                    _tmpSpoil = 0;

                double _tmpQtyCSE = 0;
                //Recalc RM QTY
                if (node.Level == 1)
                    _tmpQtyCSE = QtyInBatch;
                else
                    _tmpQtyCSE = Convert.ToDouble(node.Parent.Cells["cn_nSubProdQty"].Value);


                double _tmpPerc = 0;

                double _tmpQtyWOSpoil = 0;
                double _tmpQtyWithSpoil = 0;
                _tmpPerc = (100 + Convert.ToDouble(node.Cells["cn_nSpoilNorm"].Value)) / 100;
                _tmpQtyWOSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
                _tmpQtyWithSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                * _tmpPerc + Convert.ToDouble(node.Cells["cn_nSpoilConst"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
                if (Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value) > 0
                            && node.HasChildren == true)
                {
                    if (_tmpSpoil == 0)
                        node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWOSpoil - Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value);
                    else
                        node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWithSpoil - Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value);
                    //Recalc children
                    foreach (TreeGridNode node1 in node.Nodes)
                    {
                        RecalcQtyBatch(node1, _tmpSpoil, Convert.ToDouble(node.Cells["cn_nSubProdQty"].Value));
                    }
                }
                else
                {
                    if (_tmpSpoil == 0)
                        node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWOSpoil;
                    else
                        node.Cells["cn_nQtyInBatch"].Value = _tmpQtyWithSpoil;
                }
            }

            SetCellsColor();
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            lbl_Unit.Text = cmb_Articles1.Unit;

           
        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            double _checkqty = 0;

            foreach (DataGridViewRow row in this.gv_Orders.Rows)
            {
                _checkqty = _checkqty + Convert.ToDouble(row.Cells["cn_oqty"].Value);
            }

            if (QtyInBatch > _checkqty
                && _checkqty != 0)
                QtyInBatch = _checkqty;
            //if (tmpValidated == false)
            //{
            if (_EditMode == 0)
            {
                FillGridNew(ArticleId, QtyInBatch);
            }
            else
            {
                RecalcQtyInNomenclature();
            }
            RecalcQtyInGrid();

            btn_Save.Enabled = true;
            //MessageBox.Show("Validated!");
            //    tmpValidated = true;
            //}
            //else
            //{
            //    tmpValidated = false;
            //}

        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //    if (tmpValidated == false)
                //    {
                if (_EditMode == 0)
                {
                    FillGridNew(ArticleId, QtyInBatch);
                }
                else
                {
                    RecalcQtyInNomenclature();
                }
                    //MessageBox.Show("KeyPressed!");
            //        tmpValidated = true;
            //    }
            //    else
            //    {
            //        tmpValidated = false;    
            //    }
            }
        }

        private void btn_AddNewOrder_Click(object sender, EventArgs e)
        {
            frm_FillOrders frm = new frm_FillOrders();
            frm.FillOrders(0);

            if (_EditMode != 0)
                frm.FilterByArticleEdit(ArticleId);

            DialogResult result = frm.ShowDialog();


            if (result == DialogResult.OK)
            {
                if (_EditMode == 0) //New
                {
                    ClearOrders();

                    int _artid = 0;
                    DateTime _reqdate = System.DateTime.Now.AddYears(100);

                    foreach (DataGridViewRow row in frm.gv_List.Rows)
                    {
                        if (row.Cells["chk_add"].Value != DBNull.Value
                        && Convert.ToInt16(row.Cells["chk_add"].Value) != 0)
                        {
                            FillNewOrderLine(0, Convert.ToInt32(row.Cells["cn_id"].Value), row.Cells["cn_order"].Value.ToString(), row.Cells["cn_orderline"].Value.ToString(),
                                row.Cells["cn_article"].Value.ToString(), Convert.ToInt32(row.Cells["cn_artid"].Value), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value), 
                                row.Cells["cn_reqdate"].Value.ToString(), row.Cells["cn_customer"].Value.ToString(), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value));

                            _artid = Convert.ToInt32(row.Cells["cn_artid"].Value);
                            //Select minimum requested date
                            if (Convert.ToDateTime(row.Cells["cn_reqdate"].Value) < _reqdate)
                                _reqdate = Convert.ToDateTime(row.Cells["cn_reqdate"].Value);
                        }

                        RecalcQtyInBatch();
                        ArticleId = _artid;
                        //EndDate = _reqdate.ToShortDateString();
                        StartDate = _reqdate.AddDays(-21).ToShortDateString();
                        FillGridNew(ArticleId, QtyInBatch);
                    }
                }
                else //Edit
                {
                    int _artid = ArticleId;
                    DateTime _reqdate = Convert.ToDateTime(EndDate);

                    foreach (DataGridViewRow row in frm.gv_List.Rows)
                    {
                        if (row.Cells["chk_add"].Value != DBNull.Value
                        && Convert.ToInt16(row.Cells["chk_add"].Value) != 0)
                        {
                            if (ArticleId == Convert.ToInt32(row.Cells["cn_artid"].Value))
                            {
                                FillNewOrderLine(0, Convert.ToInt32(row.Cells["cn_id"].Value), row.Cells["cn_order"].Value.ToString(), row.Cells["cn_orderline"].Value.ToString(),
                                    row.Cells["cn_article"].Value.ToString(), Convert.ToInt32(row.Cells["cn_artid"].Value), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value),
                                    row.Cells["cn_reqdate"].Value.ToString(), row.Cells["cn_customer"].Value.ToString(), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value));


                                //Select minimum requested date
                                if (Convert.ToDateTime(row.Cells["cn_reqdate"].Value) < _reqdate)
                                    _reqdate = Convert.ToDateTime(row.Cells["cn_reqdate"].Value);
                            }
                        }
                    }

                    RecalcQtyInBatch();
                    RecalcQtyInNomenclature();
                }
                //MessageBox.Show("OK!");
            }
                
        }

        private void btn_DeleteOrder_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_Orders.CurrentRow.Cells["cn_coid"].Value); }
            catch { }
            
            foreach(DataRow row in dt_Orders.Rows)
            {
                if (Convert.ToInt32(row["coid"]) == _id)
                {
                    row.Delete();
                    RecalcQtyInBatch();

                    if (_EditMode == 0)
                    {
                        FillGridNew(ArticleId, QtyInBatch);
                    }
                    else
                    {
                        RecalcQtyInNomenclature();
                    }

                    break;
                }
            }
        }

        private void gv_Orders_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_Orders.EndEdit();
            
            if (gv_Orders.CurrentRow.Cells["cn_oqty"].Selected == true)
            {
                if (Convert.ToDouble(gv_Orders.CurrentRow.Cells["cn_oqty"].Value) > Convert.ToDouble(gv_Orders.CurrentRow.Cells["cn_qtyforbatch"].Value))
                    gv_Orders.CurrentRow.Cells["cn_oqty"].Value = Convert.ToDouble(gv_Orders.CurrentRow.Cells["cn_qtyforbatch"].Value);

                RecalcQtyInBatch();

                if (_EditMode == 0)
                {
                    FillGridNew(ArticleId, QtyInBatch);
                }
                else
                {
                    RecalcQtyInNomenclature();
                }

                btn_Save.Enabled = true;
            }


        }


        #endregion

        private void txt_Qty_Enter(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
        }

        private void gv_Orders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (gv_Orders.CurrentRow.Cells["cn_oqty"].Selected == true)
            {
                btn_Save.Enabled = false;
            }
        }

        private void txt_StartDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        {
            txt_StartDate.Value = txt_StartDate.Value == null ? System.DateTime.Now : txt_StartDate.Value;
        }

        private void txt_EndDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        {
            txt_EndDate.Value = txt_EndDate.Value == null ? System.DateTime.Now : txt_EndDate.Value;
        }

        private void tv_BOM_NodeExpanding(object sender, ExpandingEventArgs e)
        {
            //foreach (TreeGridNode node1 in e.Node.Nodes)
            //{
                //ExpandNodes(e.Node);
            //}
        }

        private void cmb_Articles1_ArticleValidated(object sender)
        {
            if (_EditMode == 0)
            {
                FillGridNew(ArticleId, QtyInBatch);
            }

            btn_Save.Enabled = true;
        }
    }
}
