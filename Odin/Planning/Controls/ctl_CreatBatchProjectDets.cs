using AdvancedDataGridView;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Planning.Controls
{
    public delegate void SaveBatchProjectEventHandler(object sender);
    public partial class ctl_CreatBatchProjectDets : UserControl
    {
        public ctl_CreatBatchProjectDets()
        {
            InitializeComponent();
        }

        #region Variables

        public event SaveBatchProjectEventHandler SaveBatch;
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

        public double QtyInCO
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyInCO.Text); }
                catch { return 0; }
            }
            set { txt_QtyInCO.Text = value.ToString(); }

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
                return txt_StartDate.Value == null ? "" : txt_StartDate.Value.ToString();
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
        public string ResDate
        {
            get
            {
                return txt_ResDate.Value == null ? "" : txt_ResDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_ResDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_ResDate.Value = null; }
            }
        }
        //public string EndDate
        //{
        //    get
        //    {
        //        if (txt_EndDate.Value == null)
        //            return "";
        //        else
        //            return txt_EndDate.Value.ToString();
        //    }
        //    set
        //    {
        //        try
        //        {
        //            txt_EndDate.Value = Convert.ToDateTime(value);
        //        }
        //        catch { txt_EndDate.Value = null; }
        //    }
        //}



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
        public string fOldResDate
        { get; set; }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        int _SpoilType = 0;
        public int SalesOrderId
        {
            get { return cmb_SalesOrdersWithLines1.SalesOrderLineId; }
            set { cmb_SalesOrdersWithLines1.SalesOrderLineId = value; }
        }
        public int QuotId
        {
            get { return cmb_Quotations1.QuotationId; }
            set { cmb_Quotations1.QuotationId = value; }
        }
        public string Customer
        {
            get { return txt_Customer.Text; }
            set { txt_Customer.Text = value; }
        }
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
            Batch = QuotId == 0
                ? DLL.AutoDoc(19, System.DateTime.Now.ToShortDateString())
                : DLL.AutoDoc(20, System.DateTime.Now.ToShortDateString());
        }

        public bool CheckEmpty()
        {
            return ArticleId != 0
                && QtyInBatch != 0
                && StartDate.Trim() != "";

        }

        public void ClearNorm()
        {
            tv_BOM.Nodes.Clear();
        }

        public void SetCellsColor()
        {
            //try
            //{
            //    foreach (DataGridViewRow row in this.tv_BOM.Rows)
            //    {
            //        row.Cells["cn_nQtyDefault"].Style.BackColor = Color.Silver;
            //        if (Convert.ToDouble(row.Cells["cn_nSubProdQty"].Value) > 0)
            //            row.Cells["cn_nSubProdQty"].Style.BackColor = Color.Yellow;
            //        if (Convert.ToDouble(row.Cells["cn_nQtyAvailable"].Value) + Convert.ToDouble(row.Cells["cn_nWaitingPOQty"].Value) + Convert.ToDouble(row.Cells["cn_qtyqiven"].Value)
            //                            < Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value))
            //        {
            //            foreach (DataGridViewCell cell in row.Cells)
            //            {
            //                cell.Style.BackColor = Color.MistyRose;
            //            }
            //        }
            //    }
            //}
            //catch { }
        }

        public void FillGridNew(int ArtId, double QtyInBatch)
        {

            tv_BOM.Nodes.Clear();

            Font boldFont = new Font(tv_BOM.DefaultCellStyle.Font, FontStyle.Bold);

            var data = PlanBll.NomDetailsDataProject(ArtId, QtyInBatch);

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

            node = nodes.Add(null, dr["Article"], dr["ArtId"], dr["Unit"],
                            Convert.ToDouble(dr["Qty"]), Convert.ToDouble(dr["QtyInBatch"]), 
                            0, 0, "0",
                            Convert.ToDouble(dr["QtyOnStock"]), Convert.ToDouble(dr["QtyAvailable"]),
                            Convert.ToDouble(dr["WaitingPOQty"]), dr["WaitingPODate"].ToString(), dr["POrder"].ToString(),
                            dr["Supplier"].ToString(), Convert.ToDouble(dr["QtyNom"]), Convert.ToDouble(dr["SpoilNorm"]), 
                            Convert.ToInt32(dr["NumDecimals"]), Convert.ToDouble(dr["SpoilConst"]), dr["Stage"], "", QuotId == 0 ? -1 : 0, 0, 0);

            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }
            //SetRowColor(dr, node);


            //if (dr["IsSubProd"].ToString() == "-1")
            //{
            //    node.Expand();
            //    node.DefaultCellStyle.Font = boldFont;
            //    node.DefaultCellStyle.ForeColor = Color.Red;

            //    var data1 = PlanBll.NomDetailsDataCB(Convert.ToInt32(dr["ArtId"]), Convert.ToDouble(dr["Qty"])/*fQtyInBatch*/);
            //    foreach (System.Data.DataRow dr1 in data1.AsEnumerable().OrderBy(d => d.Field<int>("Num")))
            //    {
            //        //AddNode(dr1, boldFont, node.Nodes, true);
            //    }

            //    if (Convert.ToDouble(dr["QtyForSubBatch"]) == 0
            //        && node.HasChildren == true)
            //    {

            //        foreach (TreeGridNode node1 in node.Nodes)
            //        {
            //            node1.Cells["cn_nCheck"].Value = 0;
            //            node1.Cells["cn_nQtyInBatch"].Value = 0;
            //        }
            //    }
            //    node.Collapse();
            //}
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
            node = nodes.Add(null, dr["Article"], dr["artid"], dr["Unit"],
                             Math.Round(Convert.ToDouble(dr["QtyInNomenclature"]), 5), Convert.ToDouble(dr["QtyInBatch"]),
                             0, Convert.ToDouble(dr["QtyInBatch"]), dr["bdid"], 
                             Convert.ToDouble(dr["QtyOnStock"]), Convert.ToDouble(dr["QtyAvailable"]),
                             Convert.ToDouble(dr["WaitingPOQty"]), dr["WaitingPODate"].ToString(), dr["POrder"].ToString(), 
                             dr["Supplier"].ToString(), Convert.ToDouble(dr["QtyNom"]), Convert.ToDouble(dr["SpoilNorm"]), 
                             Convert.ToInt32(dr["NumDecimals"]), Convert.ToDouble(dr["SpoilConst"]),
                             dr["Stage"], dr["Comments"], Convert.ToInt32(dr["IsActive"]), Convert.ToDouble(dr["QtyGiven"]),
                             Convert.ToInt32(dr["DNP"]));

            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }

            //if (dr["ParentBatchId"].ToString() != "0")
            //{
            //    //node.Expand();
            //    node.DefaultCellStyle.Font = boldFont;
            //    node.DefaultCellStyle.ForeColor = Color.Red;

            //    var data1 = PlanBll.NomDetailsDataBatch(Convert.ToInt32(dr["ParentBatchId"]));
            //    foreach (System.Data.DataRow dr1 in data1.AsEnumerable().OrderBy(d => d.Field<int>("bdid")))
            //    {
            //        AddNodeBatch(dr1, boldFont, node.Nodes, false);
            //    }

            //}
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

            //if (node.HasChildren == true)
            //{
            //    //Recalc CSE QTY
            //    if (Spoilage == -1)
            //    {
            //        if (_tmpQtyWithSpoil > Convert.ToDouble(node.Cells["cn_nQtyAvailable"].Value))
            //            _tmpQtyCSE = _tmpQtyWithSpoil - Convert.ToDouble(node.Cells["cn_nQtyAvailable"].Value);
            //        else
            //             _tmpQtyCSE = 0;
            //        _tmpQtyRM = _tmpQtyWithSpoil - _tmpQtyCSE;
            //    }
            //    else
            //    {
            //        if (_tmpQtyWOSpoil > Convert.ToDouble(node.Cells["cn_nQtyAvailable"].Value))
            //            _tmpQtyCSE = _tmpQtyWOSpoil - Convert.ToDouble(node.Cells["cn_nQtyAvailable"].Value);
            //        else
            //            _tmpQtyCSE = 0;
            //        _tmpQtyRM = _tmpQtyWOSpoil - _tmpQtyCSE;
            //    }

            //    node.Cells["cn_nSubProdQty"].Value = _tmpQtyCSE;
            //    node.Cells["cn_nQtyInBatch"].Value = _tmpQtyRM;

               

            //    //Recalc children qty 
            //    foreach (TreeGridNode node1 in node.Nodes)
            //    {
            //        RecalcQtyBatch(node1, Spoilage, _tmpQtyCSE);
            //    }

            //}
            //else
            //{
                node.Cells["cn_nQtyInBatch"].Value = Spoilage == -1 ? _tmpQtyWithSpoil : (object)_tmpQtyWOSpoil;
            //}
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
                       

        public void FillDates()
        {
            //txt_EndDate.Value = System.DateTime.Now;
            //txt_EndDate.Value = null;
            txt_StartDate.Value = System.DateTime.Now;
            txt_StartDate.Value = null;
        }

        public void RecalcQtyInGrid()
        {
            double _tmpqty = QtyInBatch;
            
            //foreach (DataGridViewRow row in this.gv_Orders.Rows)
            //{
            //    if (_tmpqty > Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value))
            //    {
            //        row.Cells["cn_oqty"].Value = Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value);
            //        _tmpqty = _tmpqty - Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value);
            //    }
            //    else
            //    {

            //        row.Cells["cn_oqty"].Value = _tmpqty;
            //        _tmpqty = 0;
            //    }
                
            //}

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
                _tmpSpoil = Convert.ToInt16(tv_BOM.CurrentRow.Cells["cn_nWithSpoil"].Value) == -1 ? -1 : 0;

                double _tmpQtyCSE = 0;
                    //Recalc RM QTY
                _tmpQtyCSE = QtyInBatch;
               
                double _tmpPerc = 0;

                double _tmpQtyWOSpoil = 0;
                double _tmpQtyWithSpoil = 0;
                _tmpPerc = (100 + Convert.ToDouble(node.Cells["cn_nSpoilNorm"].Value)) / 100;
                _tmpQtyWOSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
                _tmpQtyWithSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                * _tmpPerc + Convert.ToDouble(node.Cells["cn_nSpoilConst"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));

                node.Cells["cn_nQtyInBatch"].Value = _tmpSpoil == 0 ? _tmpQtyWOSpoil : (object)_tmpQtyWithSpoil;


            }
        }
        
        private void btn_Spoilage_Click(object sender, EventArgs e)
        {
            if (_EditMode == 0)
            {

                AllSpoil = AllSpoil == 0 ? -1 : 0;

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
                frm.HeaderText = "Add new RM for batch project: " + Batch;
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
                frm.HeaderText = "Add new RM for batch project: " + Batch;
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
                    tv_BOM.Nodes.Add(null, frm.Article, frm.ArtId, frm.Unit,
                                     frm.Qty, frm.Qty, 0, 0, 0, frm.QtyStock, frm.QtyAvailable, frm.WaitingPO, frm.DelivDate, frm.POrder, frm.Supplier,
                                     0, 0, 0, 0, frm.Stage, "", frm.IsActive, 0, frm.DNP);
                }
            }
            else
            {
                frm_AddBatchRMLine frm = new frm_AddBatchRMLine();
                frm.Id = 0;
                frm.HeaderText = "Add new RM for batch ID: " + BatchId;
                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {                   
                    PlanBll.AddBatchDetail(BatchId, frm.ArtId, frm.Qty, "");
                   
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
                    MessageBox.Show("Please check quantity and article of the project!");
                else
                {
                    //Creation of header of new batch
                    int _id = PlanBll.AddBatchProjectHeader(ArticleId, QtyInBatch, Comments, StartDate, (QuotId == 0 ? 0 : -1), ResDate);
                    if (_id != 0)
                    {
                        //Creation of the link between Client order and batch
                        if (QtyInBatch > 0
                            && (cmb_SalesOrdersWithLines1.SalesOrderLineId != 0
                            || cmb_Quotations1.QuotationId != 0))
                            PlanBll.AddBatchCOPOLink(_id, cmb_SalesOrdersWithLines1.SalesOrderLineId, 0, QtyInBatch, 0, QuotId);
                        
                        
                        _tmpBatchName = PlanBll.ProjectName;
                        //Adding the details

                        tv_BOM.Invoke(new MethodInvoker(delegate
                        {
                            AddBatchProjectDet(_id);
                        } ));

                        MessageBox.Show("Project NO: " + _tmpBatchName + " was created!");

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
                    MessageBox.Show("Please check quantity and article of the project!");
                else
                {
                    if (QtyInBatch != fOldQtyInBatch
                        || ArticleId != fOldArticleId
                        || Comments != fOldComments
                        || StartDate != fOldStartDate
                        || ResDate != fOldResDate
                        )
                    {
                        //Header
                        PlanBll.EditBatchProjectHeader(BatchId, ArticleId, QtyInBatch, Comments, StartDate, ResDate);

                    }
                    if (QtyInBatch != fOldQtyInBatch
                               && fOldArticleId == cmb_Articles1.ArticleId)
                            PlanBll.EditBatchCOPOLink(BatchId, SalesOrderId, 0, QtyInBatch, 0, QuotId);
                    
                    //Details
                    
                    foreach (DataGridViewRow row in this.tv_BOM.Rows)
                    {
                        //MessageBox.Show(Convert.ToInt32(row.Cells["cn_dnp"].Value).ToString());
                            //if (Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value) != Convert.ToDouble(row.Cells["cn_nQtyDefOldB"].Value))
                            PlanBll.EditBatchDetail(Convert.ToInt32(row.Cells["cn_nBatchId"].Value), Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value), row.Cells["cn_Comments"].Value.ToString()
                                        , Convert.ToInt32(row.Cells["cn_ndetisactive"].Value), Convert.ToInt32(row.Cells["cn_dnp"].Value));

                        if (Convert.ToInt32(row.Cells["cn_nBatchId"].Value) == 0
                                && Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value) > 0)

                            _tmp = PlanBll.AddBatchDetail(BatchId, Convert.ToInt32(row.Cells["cn_nArtId"].Value), Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value), row.Cells["cn_Comments"].Value.ToString());
                    }

                    if (SaveBatch != null)
                    {
                        SaveBatch(this);
                    }
                   
                }
            }
        }

        public void AddBatchProjectDet(int _BatchId)
        {
            int _BatchDetId = 0;   
            
            foreach (TreeGridNode node in tv_BOM.Nodes)
            {
                if (glob_Class.NEN_Double(node.Cells[5].Value.ToString()) != 0)
                {
                    _BatchDetId = PlanBll.AddBatchProjectDetail(_BatchId, Convert.ToInt32(node.Cells["cn_nArtId"].Value),
                                                                        glob_Class.NEN_Double(node.Cells[5].Value.ToString()), node.Cells["cn_Comments"].Value.ToString(), 
                                                                        Convert.ToInt32(node.Cells["cn_ndetisactive"].Value), Convert.ToInt32(node.Cells["cn_dnp"].Value));
                    node.Cells["cn_nBatchId"].Value = _BatchDetId;
                }
            }            
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void tv_BOM_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            tv_BOM.EndEdit();
            TreeGridNode node;
            node = tv_BOM.CurrentNode;
            
            if (tv_BOM.CurrentRow.Cells["cn_nWithSpoil"].Selected == true)
            {
                int _tmpSpoil = 0;
                tv_BOM.EndEdit();
                _tmpSpoil = Convert.ToInt16(tv_BOM.CurrentRow.Cells["cn_nWithSpoil"].Value) == -1 ? -1 : 0;

                double _tmpQtyCSE = 0;
                _tmpQtyCSE = QtyInBatch;
                
                double _tmpPerc = 0;

                double _tmpQtyWOSpoil = 0;
                double _tmpQtyWithSpoil = 0;
                _tmpPerc = (100 + Convert.ToDouble(node.Cells["cn_nSpoilNorm"].Value)) / 100;
                _tmpQtyWOSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
                _tmpQtyWithSpoil = Math.Round(_tmpQtyCSE * Convert.ToDouble(node.Cells["cn_nQtyNom"].Value)
                                                                                * _tmpPerc + Convert.ToDouble(node.Cells["cn_nSpoilConst"].Value)
                                                                                , Convert.ToInt32(node.Cells["cn_nNumDecimals"].Value));
                node.Cells["cn_nQtyInBatch"].Value = _tmpSpoil == 0 ? _tmpQtyWOSpoil : (object)_tmpQtyWithSpoil;

            }

            SetCellsColor();
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            //lbl_Unit.Text = cmb_Articles1.Unit;

           
        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            double _checkqty = 0;

            //foreach (DataGridViewRow row in this.gv_Orders.Rows)
            //{
            //    _checkqty = _checkqty + Convert.ToDouble(row.Cells["cn_oqty"].Value);
            //}

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

                    int _artid = 0;
                    DateTime _reqdate = System.DateTime.Now.AddYears(100);

                    foreach (DataGridViewRow row in frm.gv_List.Rows)
                    {
                        if (row.Cells["chk_add"].Value != DBNull.Value
                        && Convert.ToInt16(row.Cells["chk_add"].Value) != 0)
                        {
                            //FillNewOrderLine(0, Convert.ToInt32(row.Cells["cn_id"].Value), row.Cells["cn_order"].Value.ToString(), row.Cells["cn_orderline"].Value.ToString(),
                            //    row.Cells["cn_article"].Value.ToString(), Convert.ToInt32(row.Cells["cn_artid"].Value), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value), 
                            //    row.Cells["cn_reqdate"].Value.ToString(), row.Cells["cn_customer"].Value.ToString(), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value));

                            _artid = Convert.ToInt32(row.Cells["cn_artid"].Value);
                            //Select minimum requested date
                            if (Convert.ToDateTime(row.Cells["cn_reqdate"].Value) < _reqdate)
                                _reqdate = Convert.ToDateTime(row.Cells["cn_reqdate"].Value);
                        }

                        //RecalcQtyInBatch();
                        ArticleId = _artid;
                        //EndDate = _reqdate.ToShortDateString();
                        
                        FillGridNew(ArticleId, QtyInBatch);
                    }
                }
                else //Edit
                {
                    int _artid = ArticleId;
                   
                    foreach (DataGridViewRow row in frm.gv_List.Rows)
                    {
                        if (row.Cells["chk_add"].Value != DBNull.Value
                        && Convert.ToInt16(row.Cells["chk_add"].Value) != 0)
                        {
                            if (ArticleId == Convert.ToInt32(row.Cells["cn_artid"].Value))
                            {
                                //FillNewOrderLine(0, Convert.ToInt32(row.Cells["cn_id"].Value), row.Cells["cn_order"].Value.ToString(), row.Cells["cn_orderline"].Value.ToString(),
                                //    row.Cells["cn_article"].Value.ToString(), Convert.ToInt32(row.Cells["cn_artid"].Value), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value),
                                //    row.Cells["cn_reqdate"].Value.ToString(), row.Cells["cn_customer"].Value.ToString(), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value));
                                
                            }
                        }
                    }

                    //RecalcQtyInBatch();
                    RecalcQtyInNomenclature();
                }
                //MessageBox.Show("OK!");
            }
                
        }
     
        #endregion

        private void txt_Qty_Enter(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
        }
              

        //private void txt_StartDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        //{
        //    txt_StartDate.Value = txt_StartDate.Value == null ? System.DateTime.Now : txt_StartDate.Value;
        //}

        //private void txt_EndDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        //{
        //    txt_EndDate.Value = txt_EndDate.Value == null ? System.DateTime.Now : txt_EndDate.Value;
        //}

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

        private void btn_AddCO_Click(object sender, EventArgs e)
        {
            frm_FillOrders frm = new frm_FillOrders();
            frm.BPMode = -1;
            frm.FillOrdersBP(0);

            DialogResult result = frm.ShowDialog();


            if (result == DialogResult.OK)
            {
                if (_EditMode == 0) //New
                {
                    int _artid = 0;

                    int _quotid = 0;
                   
                    DateTime _reqdate = System.DateTime.Now.AddYears(100);

                    foreach (DataGridViewRow row in frm.gv_List.Rows)
                    {
                        if (row.Cells["chk_add"].Value != DBNull.Value
                        && Convert.ToInt16(row.Cells["chk_add"].Value) != 0)
                        {
                            //FillNewOrderLine(0, Convert.ToInt32(row.Cells["cn_id"].Value), row.Cells["cn_order"].Value.ToString(), row.Cells["cn_orderline"].Value.ToString(),
                            //    row.Cells["cn_article"].Value.ToString(), Convert.ToInt32(row.Cells["cn_artid"].Value), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value),
                            //    row.Cells["cn_reqdate"].Value.ToString(), row.Cells["cn_customer"].Value.ToString(), Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value));

                            int _check = Convert.ToInt32(Helper.GetOneRecord("select distinct bh.id from PROD_BatchHead " +
                                            " bh inner join PROD_COBatch cb on cb.batchid = bh.id where bh.ispre = -1 " + 
                                            " and (cb.coid = " + row.Cells["cn_id"].Value.ToString() + " and isnull(cb.coid, 0) != 0)"));
                            if (_check == 0)
                            {
                                
                                _quotid = Convert.ToInt32(row.Cells["cn_quotid"].Value);
                                if (_quotid != 0)
                                    QuotId = _quotid;
                                else
                                    SalesOrderId = Convert.ToInt32(row.Cells["cn_id"].Value);



                                _artid = Convert.ToInt32(row.Cells["cn_artid"].Value);
                                //Select minimum requested date
                                if (Convert.ToDateTime(row.Cells["cn_reqdate"].Value) < _reqdate)
                                    _reqdate = Convert.ToDateTime(row.Cells["cn_reqdate"].Value);
                                if (_quotid == 0)
                                {
                                    QtyInCO = cmb_SalesOrdersWithLines1.QtyInCO;
                                    chk_SelectAll.Checked = true;
                                }
                                else
                                {
                                    QtyInCO = Convert.ToDouble(row.Cells["cn_qtyinorder"].Value);
                                    chk_SelectAll.Checked = false;
                                }
                                QtyInBatch = Convert.ToDouble(row.Cells["cn_qtyforbatch"].Value);
                                Customer = row.Cells["cn_customer"].Value.ToString();
                                ArticleId = _artid;
                                StartDate = _reqdate.AddDays(-21).ToShortDateString();
                                  
                                FillGridNew(ArticleId, QtyInBatch);
                                FillAutoDoc();
                            }
                            else
                            {
                                glob_Class.ShowMessage("Batch project exists!", "Please check qty of project and order and quotation!", "You can't create more than one project on one order!");
                            }
                            break;
                            
                        }
                        
                    }
                }
            }
        }

        private void txt_StartDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        {
            txt_StartDate.Value = txt_StartDate.Value == null ? System.DateTime.Now : txt_StartDate.Value;
        }

        private void btn_InvalideBOMs_Click(object sender, EventArgs e)
        {
            var _query = "sp_SelectInvalideBOMs";

            var sqlparams = new List<SqlParameter>()
            {

            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Invalide BOM's list ";
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show();
        }

        private void ctl_CreatBatchProjectDets_Load(object sender, EventArgs e)
        {
            bn_List.Items.Insert(0, new ToolStripControlHost(chk_SelectAll));
        }

        private void chk_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SelectAll.Checked == true)
                foreach (DataGridViewRow row in this.tv_BOM.Rows)
                {
                    row.Cells["cn_ndetisactive"].Value = -1;
                }
            else
                foreach (DataGridViewRow row in this.tv_BOM.Rows)
                {
                    row.Cells["cn_ndetisactive"].Value = 0;
                }
        }

        private void txt_ResDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        {
            txt_ResDate.Value = txt_ResDate.Value == null ? System.DateTime.Now : txt_ResDate.Value;
        }
    }
}
