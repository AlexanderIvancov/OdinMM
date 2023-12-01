using AdvancedDataGridView;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Planning.Controls
{
    public delegate void SaveBatchPEventHandler(object sender);
    public partial class ctl_CreatBatchDetsP : UserControl
    {
        public ctl_CreatBatchDetsP()
        {
            InitializeComponent();
            ED = new ExportData(this.tv_BOM, "BatchesRM.xls", this.Name);
        }

        #region Variables
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public event SaveBatchPEventHandler SaveBatch;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        DataTable data;
        public bool tmpValidated = false;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int BatchId
        { get; set; }

        public string Batch
        {
            get { return txt_Batch.Text; }
            set { txt_Batch.Text = value; }
        }
        public double QtyInBatch
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }

        }

        public double QtyCanBeInBatch
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyCanBeBatch.Text); }
                catch { return 0; }
            }
            set { txt_QtyCanBeBatch.Text = value.ToString(); }

        }

        public double QtyInProject
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyInBP.Text); }
                catch { return 0; }
            }
            set { txt_QtyInBP.Text = value.ToString(); }

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

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string Serials
        {
            get { return txt_Serial.Text; }
            set { txt_Serial.Text = value; }
        }

        int _SpoilType = 0;
        public int SalesOrderId
        {
            get { return cmb_SalesOrdersWithLines1.SalesOrderLineId; }
            set { cmb_SalesOrdersWithLines1.SalesOrderLineId = value; }
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

        public int Urgent
        {
            get
            {
                return chk_Urgent.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_Urgent.Checked = value == -1;
            }
        }

        public int _EditMode1 = 0; //-by default - new 

        public int _EditMode
        {
            get { return _EditMode1; }
            set
            {
                _EditMode1 = value;
                if (_EditMode1 == 0)
                    txt_Qty.Enabled = true;
                else
                {
                    txt_Qty.Enabled = false;
                    cmb_Articles1.Enabled = false;
                }
            }
        }

        string _tmpBatchName = "";

        public int ProjectId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        int _prevnum = 0;
        public int PrevNum { get { return _prevnum; } set { _prevnum = value; } }

        public int PCBPerPanel
        {
            get
            {
                try { return Convert.ToInt32(txt_PCB.Text); }
                catch { return 0; }
            }
            set { txt_PCB.Text = value.ToString(); }
        }

        #endregion

        #region Methods

        public void LoadColumns(DataGridView grid)
        {
            DAL.UserLogin = System.Environment.UserName;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectUserGridViewColumn", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@userid", DAL.UserId);
            sqlComm.Parameters.AddWithValue("@formname", this.Name);
            sqlComm.Parameters.AddWithValue("@gridname", grid.Name);

            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        if (column.Name == reader["columnname"].ToString())
                        {
                            column.DisplayIndex = Convert.ToInt32(reader["columnorder"]);
                            column.HeaderText = reader["columntext"].ToString();
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                    }

                }
                reader.Close();
            }

            sqlConn.Close();

        }

        public void FillAutoDoc()
        {
            Batch = DAL.AutoDoc(3, System.DateTime.Now.ToShortDateString());
        }

        public bool CheckEmpty()
        {
            return ArticleId != 0
                && QtyInBatch != 0
                && StartDate != ""
                && cmb_Batches1.IsQuote != -1
                && (CheckSerialNeeds(cmb_Articles1.ArticleId) != true || Serials != "");

        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.tv_BOM.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_dnp"].Value) == -1)
                    row.Cells["cn_nQtyInProject"].Style.ForeColor = Color.Red;
            }
        }
        //public void RecalcQtyBatch(int Spoilage, double QtyCSE)
        //{
        //    double _tmpPerc = 0;
        //    double _tmpQtyWOSpoil = 0;
        //    double _tmpQtyWithSpoil = 0;

        //    foreach(DataGridViewRow row in this.gv_List.Rows)
        //    { 
        //    _tmpPerc = (100 + Convert.ToDouble(row.Cells["cn_spoilnorm"].Value)) / 100;

        //    _tmpQtyWOSpoil = Math.Round(QtyCSE * Convert.ToDouble(row.Cells["cn_qtybom"].Value)
        //                                                                    , Convert.ToInt32(row.Cells["cn_numdec"].Value));
        //    _tmpQtyWithSpoil = Math.Round(QtyCSE * Convert.ToDouble(row.Cells["cn_qtybom"].Value)
        //                                                                    * _tmpPerc + Convert.ToDouble(row.Cells["cn_spoilconst"].Value)
        //                                                                    , Convert.ToInt32(row.Cells["cn_numdec"].Value));

        //    if (Spoilage == -1)
        //    {
        //        row.Cells["cn_qtyforbatch"].Value = _tmpQtyWithSpoil;
        //    }
        //    else
        //        row.Cells["cn_qtyforbatch"].Value = _tmpQtyWOSpoil;
        //    }

        //    SetCellsColor();
        //}

        public void FillDates()
        {            
            txt_StartDate.Value = System.DateTime.Now;
            txt_StartDate.Value = null;
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

        public bool CheckSerialNeeds(int ArtId)
        {
            bool _res = false;

            int _r1 = Convert.ToInt32(Helper.GetOneRecord("select dbo.fn_CheckSerialNeeds(" + ArtId + ")"));
            _res = _r1 == -1;
            return _res;
        }
        public double RecalcMaxQtyCanBeLaunched()
        {
            foreach (TreeGridNode node1 in tv_BOM.Nodes)
            {
                node1.Expand();
            }

            double _qtymax = QtyInProject;
            double _prevmax = QtyInProject;
            double _tmpqty = 0;
            double _tmpqtystock = 0;
            double _tmpqtypo = 0;
            int _stage = 0;
            double _qtyinbom = 0;
            //1-st maximum 
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToDouble(row.Cells["cn_qtybom"].Value) != 0)
            //    {
            //        _tmpqty = Math.Round(Convert.ToDouble(row.Cells["cn_maxqty"].Value) / Convert.ToDouble(row.Cells["cn_qtybom"].Value), 5);
            //    }
            //}
            //MessageBox.Show("!");

            //foreach (TreeGridNode node in this.tv_BOM.Nodes)
            //{
            //    if (Convert.ToInt32(node.Cells["cn_nUse"].Value) == -1)
            //    {
            //        _tmpqty = Convert.ToDouble(node.Cells["cn_nQtyInProject"].Value);
            //        _tmpqtystock = Convert.ToDouble(node.Cells["cn_nAvailable"].Value);
            //        _tmpqtypo = Convert.ToDouble(node.Cells["cn_nWaitingQtyPO"].Value);
            //        _stage = Convert.ToInt32(node.Cells["cn_nstockforbatch"].Value);
            //    }
            //    else
            //    {
            //        _tmpqty = 0;
            //        _tmpqtystock = 0;
            //        _tmpqtypo = 0;
            //        _stage = 0;
            //    }

            //    if (node.HasChildren == true
            //        && Convert.ToInt32(node.Cells["cn_nUse"].Value) == 0)
            //    {
            //        foreach (TreeGridNode nodec in node.Nodes)
            //        {
            //            if (Convert.ToInt32(nodec.Cells["cn_nUse"].Value) == -1)
            //            {
            //                _tmpqty = _tmpqty + Convert.ToDouble(nodec.Cells["cn_nQtyInProject"].Value);
            //                _tmpqtystock = _tmpqtystock + (Convert.ToDouble(nodec.Cells["cn_nQtyInProject"].Value) < Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) ?
            //                                                    Convert.ToDouble(nodec.Cells["cn_nQtyInProject"].Value) :
            //                                                    Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value));
            //                _tmpqtypo = _tmpqtypo + (Convert.ToDouble(nodec.Cells["cn_nQtyInProject"].Value) < Convert.ToDouble(nodec.Cells["cn_nWaitingQtyPO"].Value) ?
            //                                                   Convert.ToDouble(nodec.Cells["cn_nQtyInProject"].Value) :
            //                                                   Convert.ToDouble(nodec.Cells["cn_nWaitingQtyPO"].Value));
            //            }
            //        }
            //    }

            //    //MessageBox.Show(_tmpqty.ToString());

            //    if (_tmpqty != 0)
            //    {
            //        if (_stage == -1)
            //            _qtymax = _tmpqty < _tmpqtystock ? _qtymax : (Math.Round(_tmpqtystock / (_tmpqty / QtyInProject), 0));
            //        else
            //            _qtymax = _tmpqty < (_tmpqtystock + _tmpqtypo) ? _qtymax : (Math.Round((_tmpqtystock + _tmpqtypo) / (_tmpqty / QtyInProject), 0));
            //        //MessageBox.Show(node.Cells["cn_nArticle"].Value.ToString() + " " +  _qtymax.ToString());
            //        if (_prevmax > _qtymax)
            //            _prevmax = _qtymax;
            //    }                
            //}
            tv_BOM.EndEdit();
            int _countuse = 0;
            foreach (TreeGridNode node in this.tv_BOM.Nodes)
            {
                if (Convert.ToInt32(node.Cells["cn_dnp"].Value) != -1)
                {
                    _qtyinbom = Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value);

                    if (node.HasChildren == false
                        || (node.HasChildren == true && Convert.ToInt32(node.Cells["cn_nUse"].Value) == -1)
                        )
                    {
                        //if (Convert.ToInt32(node.Cells["cn_nUse"].Value) == -1)
                        //{
                        _tmpqty = Convert.ToDouble(node.Cells["cn_nQtyInProject"].Value);
                        _tmpqtystock = Convert.ToDouble(node.Cells["cn_nAvailable"].Value);
                        _tmpqtypo = Convert.ToDouble(node.Cells["cn_nWaitingQtyPO"].Value);
                        _stage = Convert.ToInt32(node.Cells["cn_nstockforbatch"].Value);

                        //MessageBox.Show(_tmpqty.ToString());

                        if (_tmpqty != 0)
                        {
                            if (_stage == -1)
                            {
                                //if (_qtyinbom == 0
                                //    || (Math.Round(_tmpqty / QtyInProject, 2) != _qtyinbom))

                                //    _qtymax = _tmpqty < _tmpqtystock ? _qtymax : (Math.Round(_tmpqtystock / (_tmpqty / QtyInProject), 0));
                                //else
                                //    _qtymax = _tmpqty < _tmpqtystock ? _qtymax : (Math.Round(_tmpqtystock / (_qtyinbom), 0));
                                _qtymax = _qtyinbom == 0 ? Math.Round(_tmpqtystock / (_tmpqty / QtyInProject), 0) : Math.Round(_tmpqtystock / (_qtyinbom), 0);
                            }
                            else
                            {
                                //if (_qtyinbom == 0
                                //    || (Math.Round(_tmpqty / QtyInProject, 2) != _qtyinbom))
                                //    _qtymax = _tmpqty < (_tmpqtystock + _tmpqtypo) ? _qtymax : (Math.Round((_tmpqtystock + _tmpqtypo) / (_tmpqty / QtyInProject), 0));
                                //else
                                //    _qtymax = _tmpqty < (_tmpqtystock + _tmpqtypo) ? _qtymax : (Math.Round((_tmpqtystock + _tmpqtypo) / (_qtyinbom), 0));
                                _qtymax = _qtyinbom == 0
                                    ? Math.Round((_tmpqtystock + _tmpqtypo) / (_tmpqty / QtyInProject), 0)
                                    : Math.Round((_tmpqtystock + _tmpqtypo) / (_qtyinbom), 0);

                            }
                            if (_prevmax > _qtymax)
                                _prevmax = _qtymax;
                        }
                        else
                            _prevmax = 0;
                    }
                    else
                    {
                        if (node.HasChildren == true)
                        {

                            _countuse = 0;
                            foreach (TreeGridNode node1 in node.Nodes)
                            {
                                if (Convert.ToInt32(node1.Cells["cn_nUse"].Value) == -1
                                    //&& !
                                    )
                                {
                                    _countuse = 1;
                                    _tmpqty = Convert.ToDouble(node1.Cells["cn_nQtyInProject"].Value);
                                    _tmpqtystock = Convert.ToDouble(node1.Cells["cn_nAvailable"].Value);
                                    _tmpqtypo = Convert.ToDouble(node1.Cells["cn_nWaitingQtyPO"].Value);
                                    _stage = Convert.ToInt32(node1.Cells["cn_nstockforbatch"].Value);

                                    if (_tmpqty != 0)
                                    {
                                        _qtymax = _stage == -1
                                            ? _qtyinbom == 0 ? Math.Round(_tmpqtystock / (_tmpqty / QtyInProject), 0) : Math.Round(_tmpqtystock / (_qtyinbom), 0)
                                            : _qtyinbom == 0
                                                ? Math.Round((_tmpqtystock + _tmpqtypo) / (_tmpqty / QtyInProject), 0)
                                                : Math.Round((_tmpqtystock + _tmpqtypo) / _qtyinbom, 0);

                                        if (_prevmax > _qtymax)
                                            _prevmax = _qtymax;
                                    }
                                    else
                                        _prevmax = 0;
                                    //MessageBox.Show(_prevmax.ToString());
                                }
                            }
                        }
                        if (_countuse == 0)
                            _prevmax = 0;
                    }
                }
            }
            if (_prevmax < 0)
                _prevmax = 0;
            return _prevmax;
        }

        public void RecalcQtyCanBeLaunched(double _qtymax)
        {
            foreach (TreeGridNode node1 in tv_BOM.Nodes)
            {
                node1.Expand();
            }

            double _qtyinbom = 0;
            double _qtylefttodist = 0;
            double _qtytodist = 0;
            int _stage = 0;
            if (_qtymax == 0)
            {
                foreach (DataGridViewRow row in tv_BOM.Rows)
                {
                    row.Cells["cn_nQtyInBatch"].Value = 0;
                }
            }
            else
            {
                //1-st maximum 
                foreach (TreeGridNode node in this.tv_BOM.Nodes)
                {
                    if ((node.HasChildren == false
                        || (node.HasChildren == true && Convert.ToInt32(node.Cells["cn_nUse"].Value) == -1))
                        && !(Convert.ToInt32(node.Cells["cn_dnp"].Value) == -1))
                    {
                        //double _tmpBOM = 0;
                        //if (node.HasChildren == true)
                        //    _tmpBOM = _qtymax;
                        //else
                        //    _tmpBOM = QtyInProject;

                        if (node.HasChildren == false)
                        {
                            _qtyinbom = Math.Round(Convert.ToDouble(node.Cells["cn_nQtyInProject"].Value) / QtyInProject, 5);
                        }
                        else
                        {
                            if (Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value) != 0)
                                _qtyinbom = Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value);
                            else
                            {
                                double _tmpBOM = 0;
                                foreach (TreeGridNode node2 in node.Nodes)
                                { 
                                    _tmpBOM = _tmpBOM + Convert.ToDouble(node2.Cells["cn_nQtyInProject"].Value);
                                }
                                _qtyinbom = Math.Round(_tmpBOM / QtyInProject, 5);
                            }
                        }
                        //if (Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value) == 0
                        //    || Math.Round(Convert.ToDouble(node.Cells["cn_nQtyInProject"].Value) / _qtymax, 5) != Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value))
                        //    _qtyinbom = Math.Round(Convert.ToDouble(node.Cells["cn_nQtyInProject"].Value) / _qtymax, 5);
                        //else
                        //    _qtyinbom = Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value);

                        _qtylefttodist = Math.Round(_qtyinbom * _qtymax, 5);

                        _stage = Convert.ToInt32(node.Cells["cn_nstockforbatch"].Value);

                        _qtytodist = _stage == -1
                            ? Convert.ToDouble(node.Cells["cn_nAvailable"].Value) < _qtylefttodist ? Convert.ToDouble(node.Cells["cn_nAvailable"].Value) : _qtylefttodist
                            : (Convert.ToDouble(node.Cells["cn_nAvailable"].Value) + Convert.ToDouble(node.Cells["cn_nWaitingQtyPO"].Value)) < _qtylefttodist ? (Convert.ToDouble(node.Cells["cn_nAvailable"].Value) + Convert.ToDouble(node.Cells["cn_nWaitingQtyPO"].Value)) : _qtylefttodist;

                        node.Cells["cn_nQtyInBatch"].Value = _qtytodist;
                        //_qtylefttodist = _qtylefttodist - _qtytodist;

                        //if (node.HasChildren == true)
                        //{
                        //    foreach (TreeGridNode nodec in node.Nodes)
                        //    {
                        //        if (_stage == -1)
                        //        {
                        //            _qtytodist = Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) < _qtylefttodist ? Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) : _qtylefttodist;
                        //        }
                        //        else
                        //        {
                        //            _qtytodist = (Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) + Convert.ToDouble(nodec.Cells["cn_nWaitingQtyPO"].Value)) < _qtylefttodist ? (Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) + Convert.ToDouble(nodec.Cells["cn_nWaitingQtyPO"].Value)) : _qtylefttodist;
                        //        }
                        //        nodec.Cells["cn_nQtyInBatch"].Value = _qtytodist;
                        //        _qtylefttodist = _qtylefttodist - _qtytodist;
                        //    }
                    }
                    else
                    {
                        if (node.HasChildren == true)
                        {
                            double _tmpTotal = 0;
                            foreach (TreeGridNode node3 in node.Nodes)
                            {
                                _tmpTotal = _tmpTotal + Convert.ToDouble(node3.Cells["cn_nQtyInProject"].Value);
                            }

                            _qtyinbom = Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value);

                            foreach (TreeGridNode nodec in node.Nodes)
                            {
                                if (Convert.ToInt32(nodec.Cells["cn_nUse"].Value) == -1
                                    && !(Convert.ToInt32(nodec.Cells["cn_dnp"].Value) == -1))
                                {
                                    if (Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value) != 0)
                                        _qtyinbom = Convert.ToDouble(node.Cells["cn_nQtyBOM"].Value);
                                    else
                                    {
                                        if (_qtyinbom == 0)
                                            _qtyinbom = Math.Round(_tmpTotal / QtyInProject, 5);
                                            //  || (_qtyinbom == 0 && Math.Round(Convert.ToDouble(nodec.Cells["cn_nQtyInProject"].Value) / _qtymax, 5) != _qtyinbom))
                                            //_qtyinbom = Math.Round(Convert.ToDouble(nodec.Cells["cn_nQtyInProject"].Value) / _qtymax, 5);
                                    }

                                    _qtylefttodist = Math.Round(_qtyinbom * _qtymax, 5);
                                    _stage = Convert.ToInt32(nodec.Cells["cn_nstockforbatch"].Value);

                                    _qtytodist = _stage == -1
                                        ? Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) < _qtylefttodist ? Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) : _qtylefttodist
                                        : (Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) + Convert.ToDouble(nodec.Cells["cn_nWaitingQtyPO"].Value)) < _qtylefttodist ? (Convert.ToDouble(nodec.Cells["cn_nAvailable"].Value) + Convert.ToDouble(nodec.Cells["cn_nWaitingQtyPO"].Value)) : _qtylefttodist;
                                    nodec.Cells["cn_nQtyInBatch"].Value = _qtytodist;
                                    //        _qtylefttodist = _qtylefttodist - _qtytodist;

                                }
                            }
                        }
                    }

                    //if (node.Cells["cn_nUnit"].ToString().ToLower().Trim() == "pc")
                    //    node.Cells["cn_nQtyInBatch"].Value = glob_Class.RoundUp(Convert.ToDouble(node.Cells["cn_nQtyInBatch"].Value), 0);
                }
            }
        }

        public DateTime RecalcDateCanBeLaunched()
        {
            DateTime _mindate = System.DateTime.Now;



            return _mindate;
        }
        public void FillHeader(int _projectid, int _salesorderid)
        {
            if (_salesorderid != 0)
                ProjectId = Convert.ToInt32(Helper.GetOneRecord("select top 1 cb.batchid from prod_cobatch cb "+
                    " inner join prod_batchhead bh on cb.batchid = bh.id " +
                    " where coid = " + _salesorderid + " and isnull(bh.ispre, 0) = -1"));
            Customer = cmb_Batches1.Customer;
            QtyInProject = cmb_Batches1.Qty;
            ArticleId = cmb_Batches1.ArticleId;
            if (_EditMode == 0)
                Comments = Helper.GetOneRecord("select top 1 comments from prod_batchhead where id = " + ProjectId.ToString()).ToString();
            //StartDate = cmb_Batches1.ResDate;
        }

        public void FillDets()
        {
            if (_EditMode == 0)
            {
                //DataGridViewColumn oldColumn = gv_List.SortedColumn;
                //var dir = Helper.SaveDirection(gv_List);
                
                data = Plan_BLL.getCreateBatchRM(ProjectId);


                //gv_List.ThreadSafeCall(delegate
                //{
                //    gv_List.AutoGenerateColumns = false;
                //    bs_List.DataSource = data;
                //    gv_List.DataSource = bs_List;
                //    SetCellsColor();
                //});

                //Helper.RestoreDirection(gv_List, oldColumn, dir);
                //SetCellsColor();
                tv_BOM.Nodes.Clear();
                PrevNum = 0;

                Font boldFont = new Font(tv_BOM.DefaultCellStyle.Font, FontStyle.Bold);

                DataRow[] foundrow = data.Select("origartid = 0");

                foreach (System.Data.DataRow dr in foundrow.AsEnumerable().OrderBy(d => d.Field<int>("bomnum")))
                {
                    AddNode(dr, boldFont, tv_BOM.Nodes, true, -1);
                }

                tv_BOM.Focus();
                foreach (TreeGridNode node1 in tv_BOM.Nodes)
                {
                    if (node1.HasChildren == false)
                        node1.Cells["cn_nUse"].ReadOnly = true;
                    ExpandNodes(node1);
                }

                //bn_List.ThreadSafeCall(delegate
                //{
                //    bn_List.BindingSource = bs_List;
                //});
                FillBatchUnits();
            }
            else
            {

            }
        }

        private void AddNode(DataRow dr, Font boldFont, TreeGridNodeCollection nodes, bool isAddingImage, int _Use)
        {
            TreeGridNode node;

            //New node
            node = nodes.Add(null, dr["Article"], _Use, dr["ArtId"], dr["bomnum"], dr["Unit"],
                            Convert.ToDouble(dr["QtyInProject"]), 0/*Convert.ToDouble(dr["QtyInBatch"])*/,
                            Convert.ToDouble(dr["QtyAvailable"]), Convert.ToDouble(dr["QtyOnStock"]), 
                            Convert.ToDouble(dr["WaitingPOQty"]), Convert.ToDouble(dr["QtyBom"]),
                            dr["Stage"], Convert.ToDouble(dr["MaxQty"]), dr["origartid"],
                            dr["WaitingPODate"].ToString(), dr["POrder"].ToString(),
                            dr["Supplier"].ToString(), Convert.ToInt32(dr["Id"]), 
                            Convert.ToInt32(dr["stockforbatch"]), dr["FullPOInfo"].ToString(), 
                            Convert.ToInt32(dr["dnp"]));
            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }

            DataRow[] foundrow = data.Select("origartid = " + Convert.ToInt32(dr["ArtId"]));
            if (foundrow.Length > 0)
            {
                foreach (System.Data.DataRow dr1 in foundrow.AsEnumerable().OrderBy(d => d.Field<int>("bomnum")))
                {
                    AddNode(dr1, boldFont, node.Nodes, true, 0);
                }
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
        public void ExpandNodes(TreeGridNode node)
        {
            foreach (TreeGridNode node1 in node.Nodes)
            {
                node.Expand();
                ExpandNodes(node1);
            }
        }

        #endregion

        #region Controls

        #region Context menu


        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                //Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
                //DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

                //RowIndex = info.RowIndex;
                //ColumnIndex = info.ColumnIndex;
                ////MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                //gv_List.ClearSelection();
                //gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                //gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

                //CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                //ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            //}
            //catch
            //{ }
            //SetCellsColor();

        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            //frm_Find frm = new frm_Find();
            //frm.grid = gv_List;
            //frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
            //frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
            //frm.ShowDialog();
        }

        private void mni_FilterBy_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (String.IsNullOrEmpty(bs_List.Filter) == true)
            //    {
            //        if (String.IsNullOrEmpty(CellValue) == true)
            //            bs_List.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
            //        else
            //            bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
            //    }
            //    else
            //    {
            //        if (String.IsNullOrEmpty(CellValue) == true)
            //            bs_List.Filter = bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
            //        else
            //            bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
            //    }
            //    //MessageBox.Show(bs_List.Filter);

            //}
            //catch { }
            //SetCellsColor();

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (String.IsNullOrEmpty(bs_List.Filter) == true)
            //        bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
            //    else
            //        bs_List.Filter = bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            //}
            //catch { }
            //SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        bs_List.RemoveFilter();
        //    }
        //    catch { }
        //    SetCellsColor();

        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            //frm_GridViewAdm frm = new frm_GridViewAdm();

            //frm.HeaderText = "Select view for batches RM list";
            //frm.grid = this.gv_List;
            //frm.formname = this.Name;
            //DAL.UserLogin = System.Environment.UserName;
            //frm.UserId = DAL.UserId;

            //frm.FillData(frm.grid);

            //DialogResult result = frm.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
            //    LoadColumns(gv_List);
            //}
        }




        #endregion

        private void ctl_CreatBatchDetsP_Load(object sender, EventArgs e)
        {
            //LoadColumns(gv_List);
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillHeader(ProjectId, SalesOrderId);
            FillDets();
            QtyCanBeInBatch = RecalcMaxQtyCanBeLaunched();
            QtyInBatch = QtyCanBeInBatch;
            //QtyInBatch = RecalcMaxQtyCanBeLaunched();
            //QtyCanBeInBatch = QtyInBatch;
            RecalcQtyCanBeLaunched(QtyInBatch);
            if (CheckSerialNeeds(cmb_Articles1.ArticleId) == false)
            { lbl_Serial.Visible = false;
                txt_Serial.Visible = false;
            }
            else
            {
                lbl_Serial.Visible = true;
                txt_Serial.Visible = true;
            }
            SetCellsColor();
        }

        private void cmb_SalesOrdersWithLines1_SalesOrderChanged(object sender)
        {           
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            SalesOrderId = cmb_Batches1.ConfOrderId;
            if (cmb_Batches1.IsQuote == -1)
            {
                glob_Class.ShowMessage("Project ERROR!", "You can't create batch on quote project!", "Please create confirmation order first!");
                btn_Refresh.Enabled = false;
            }
            else
                btn_Refresh.Enabled = true;
        }

        private void cmb_Batches1_ControlClick(object sender)
        {

        }
        private void txt_StartDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        {
            txt_StartDate.Value = txt_StartDate.Value == null ? System.DateTime.Now : txt_StartDate.Value;
        }


        #endregion

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (QtyInBatch > QtyCanBeInBatch)
                    QtyInBatch = QtyCanBeInBatch;

                RecalcQtyCanBeLaunched(QtyInBatch);
            }
            catch { RecalcQtyCanBeLaunched(0);  }
        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            if (QtyInBatch > QtyCanBeInBatch)
                QtyInBatch = QtyCanBeInBatch;

            RecalcQtyCanBeLaunched(QtyInBatch);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            tv_BOM.EndEdit();
            if (_EditMode == 0) //New batch
            {
                #region Create new
                if (glob_Class.ConfirmMessage("Batch creation confirmation", "Please check quanities!", "Are you sure you want to create batch?") == true)
                {
                    foreach (TreeGridNode node1 in tv_BOM.Nodes)
                    {
                        node1.Expand();
                    }                
                    //MessageBox.Show(COrderId.ToString());
                    if (CheckEmpty() == false)
                        MessageBox.Show("Please check quantity and article and date and serial numbers state of the batch!");
                    else
                    {
                        //Creation of header of new batch
                        int _id = PlanBll.AddBatchHeaderFromProject(ProjectId, ArticleId, QtyInBatch, StartDate, Comments, Urgent, Serials);
                        if (_id != 0)
                        {
                            DataTable datadets = new DataTable();
                            datadets.Columns.Add("batchdetid", typeof(int));
                            datadets.Columns.Add("artid", typeof(int));
                            datadets.Columns.Add("qty", typeof(double));

                            foreach (DataGridViewRow row in tv_BOM.Rows)
                            {
                                if (
                                    //!(Math.Round(Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value), 5) == 0 
                                    //|| Convert.ToInt32(row.Cells["cn_nOrigArt"].Value) != 0)
                                    Convert.ToInt32(row.Cells["cn_batchdetid"].Value) != 0)
                                {
                                    //Insert into temporary table
                                    DataRow drl = datadets.NewRow();
                                    drl["batchdetid"] = Convert.ToInt32(row.Cells["cn_batchdetid"].Value);
                                    drl["artid"] = Convert.ToInt32(row.Cells["cn_nArtId"].Value);
                                    drl["qty"] = Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value);

                                    datadets.Rows.Add(drl);

                                }
                            }

                            PlanBll.AddBatchDetFromProject(_id, datadets);
                            //    //Creation of the link between Client order and batch
                            //    if (QtyInBatch > 0
                            //        & cmb_SalesOrdersWithLines1.SalesOrderLineId != 0)
                            //        PlanBll.AddBatchCOPOLink(_id, cmb_SalesOrdersWithLines1.SalesOrderLineId, 0, QtyInBatch, 0);


                            //    _tmpBatchName = PlanBll.ProjectName;
                            //    //Adding the details

                            //    tv_BOM.Invoke(new MethodInvoker(delegate
                            //    {
                            //        AddBatchDet(_id);
                            //    }));

                            MessageBox.Show("Batch NO: " + PlanBll.BatchName + " was created!");

                            btn_Refresh.PerformClick();
                            //    Batch = _tmpBatchName;

                            //}

                            if (SaveBatch != null)
                            {
                                SaveBatch(this);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error during creation of batch header!");
                        }
                    }

                }
                #endregion
          
            }
            else
            #region Modificaton
            //Modification
            {
                if (ArticleId == 0
                     || StartDate == ""
                     || (CheckSerialNeeds(cmb_Articles1.ArticleId) == true && Serials == ""))
                    MessageBox.Show("Please check article or RM lead time or serials of the batch!");
                else
                {
                    if (ArticleId != fOldArticleId
                        || Comments != fOldComments
                        || StartDate != fOldStartDate
                        || Urgent != fOldUrgent)
                    {
                        //Header
                        PlanBll.EditBatchHeaderP(BatchId, ArticleId, StartDate, Comments, Urgent, Serials);

                    }

                    if (SaveBatch != null)
                    {
                        SaveBatch(this);
                    }

                }
            #endregion
            }
        }

        private void btn_AddNorm_Click(object sender, EventArgs e)
        {

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

        private void tv_BOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tv_BOM.CurrentRow.Cells["cn_nUse"].Selected == true)
            {
                tv_BOM.EndEdit();
                if (tv_BOM.CurrentNode.HasChildren == true)
                {
                    if (Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_nUse"].Value) == -1)
                    {
                        foreach (TreeGridNode node in tv_BOM.CurrentRow.Nodes)
                        { node.Cells["cn_nUse"].Value = 0; }
                    }
                }
                else
                {
                    int _level = tv_BOM.CurrentNode.Level;
                    if (_level == 2)
                    {
                        TreeGridNode parentnode = tv_BOM.CurrentNode.Parent;
                        if (Convert.ToInt32(tv_BOM.CurrentRow.Cells["cn_nUse"].Value) == -1)
                        {
                            parentnode.Cells["cn_nUse"].Value = 0;
                            foreach (TreeGridNode node in parentnode.Nodes)
                            {
                                if (node.Index != tv_BOM.CurrentNode.Index)
                                    node.Cells["cn_nUse"].Value = 0;
                            }
                        }
                    }
                }
                foreach (DataGridViewRow row in this.tv_BOM.Rows)
                {
                    if (Convert.ToInt32(row.Cells["cn_nUse"].Value) == 0)
                        row.Cells["cn_nQtyInBatch"].Value = 0;
                }
                QtyCanBeInBatch = RecalcMaxQtyCanBeLaunched();
                QtyInBatch = QtyCanBeInBatch;
                RecalcQtyCanBeLaunched(QtyInBatch);
            }
        }

        private void tv_BOM_Validated(object sender, EventArgs e)
        {
            //QtyInBatch = RecalcMaxQtyCanBeLaunched();
            //RecalcQtyCanBeLaunched(QtyInBatch);
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            PCBPerPanel = Convert.ToInt32(Helper.GetOneRecord("select isnull(dbo.fn_PCBPerPanel( " + ArticleId +  "), 0)"));
        }

        private void txt_Serial_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_Qty_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
