﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;


namespace Odin.Planning.Controls
{
    public delegate void SaveLaunchEventHandler(object sender);

    public partial class ctl_CreatLaunchDets : UserControl
    {
        public ctl_CreatLaunchDets()
        {
            InitializeComponent();
        }

        #region Variables

        public event SaveLaunchEventHandler SaveLaunch;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        string _mode = "new";

        public string Mode
        {
            get { return _mode; }
            set { _mode = value;
                if (_mode == "new")
                    cmb_Batches1.Enabled = true;
                else
                    cmb_Batches1.Enabled = false;
            }
        }

        public int Id
        { get; set; }

        public string Launch
        { get  { return txt_Launch.Text; }
            set { txt_Launch.Text = value; } }

        public int StageId
        {
            get { return cmb_BatchStages1.StageId; }
            set { cmb_BatchStages1.StageId = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }

        }

        public string Stages
        {
            get { return txt_Stages.Text; }
            set { txt_Stages.Text = value; }
        }

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public double QtyInLaunch
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }

        }

        public string Customer
        {
            get { return txt_Customer.Text; }
            set { txt_Customer.Text = value; }
        }

        public double QtyCanBeLaunched
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyCanBeLaunched.Text); }
                catch { return 0; }
            }
            set { txt_QtyCanBeLaunched.Text = value.ToString(); }

        }

        public double QtyCanBeLaunchedTotal
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyCanBeLaunchedTotal.Text); }
                catch { return 0; }
            }
            set { txt_QtyCanBeLaunchedTotal.Text = value.ToString(); }

        }

        public double QtyNotLaunched
        {
            get
            {
                try { return Convert.ToDouble(txt_NotLaunched.Text); }
                catch { return 0; }
            }
            set { txt_NotLaunched.Text = value.ToString(); }

        }

        public int SalesOrderId
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

        public string ProdStartDate
        {
            get
            {
                if (txt_ProdStartDate.Value == null)
                    return "";
                else
                    return txt_StartDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_ProdStartDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_ProdStartDate.Value = null; }
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


        #endregion

        #region Methods

        public void ShowLaunchHead(int id)
        {

        }

        public void ShowBatchHead(int batchid, int stageid)
        {
            SalesOrderId = cmb_Batches1.ConfOrderId;
            Customer = cmb_Batches1.Customer;
            ArtId = cmb_Batches1.ArticleId;
            Stages = cmb_Batches1.Stages;
            QtyNotLaunched = Convert.ToDouble(Helper.GetOneRecord("select isnull(dbo.fn_NotLaunchedBatchQty(" + batchid + "," + stageid + "), 0)"));
           
        }

        public void SetCellsColor()
        {
            //double ToFreeze = 0;
            int _bdtemp = 0;
            int _colorcount = 0;
            try
            {
                if (gv_List.Rows.Count > 0)
                {
                    _bdtemp = Convert.ToInt32(gv_List.Rows[0].Cells["cn_batchdetid"].Value);
                    _colorcount = 1;

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (_bdtemp != Convert.ToInt32(row.Cells["cn_batchdetid"].Value))
                        {
                            //Next color

                            //Switch
                            _bdtemp = Convert.ToInt32(row.Cells["cn_batchdetid"].Value);
                            _colorcount++;
                            
                        }
                        row.DefaultCellStyle.BackColor = _colorcount % 2 == 0 ? Color.FromArgb(192, 255, 192) : Color.Azure;//Color.LightGreen : Color.LightPink;
                        //Grouping colors

                        //    //Color of freezed qty
                        //    if (Convert.ToDouble((row.Cells["cn_reserve"].Value)) < 0)
                        //        row.Cells["cn_reserve"].Style.ForeColor = Color.Blue;
                        //    else if (Convert.ToDouble((row.Cells["cn_reserve"].Value)) > 0)
                        //        row.Cells["cn_reserve"].Style.ForeColor = Color.Green;
                        //    else
                        //        row.Cells["cn_reserve"].Style.ForeColor = Color.Black;

                        //    ToFreeze = Convert.ToDouble(row.Cells["cn_qty"].Value)
                        //                - Convert.ToDouble(row.Cells["cn_reserved"].Value)
                        //                //- Convert.ToDouble(row.Cells["cn_requested"].Value)
                        //                - Convert.ToDouble(row.Cells["cn_given"].Value)
                        //                + Convert.ToDouble(row.Cells["cn_returned"].Value);
                        //    //Color of available qty
                        //    if (Convert.ToDouble(row.Cells["cn_missed"].Value) > 0)//(Convert.ToDouble(row.Cells["cn_available"].Value) < ToFreeze)
                        //    {
                        //        row.Cells["cn_article"].Style.Font = new Font(this.Font, FontStyle.Bold);
                        //        row.Cells["cn_article"].Style.ForeColor = Color.Red;
                        //    }

                        //    if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) == 0
                        //        && Convert.ToDouble(row.Cells["cn_qty"].Value) > 0)
                        //    {
                        //        //green
                        //        row.Cells["cn_nomenclature"].Style.BackColor = Color.LightGreen;
                        //    }
                        //    else if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) > 0
                        //        && Convert.ToDouble(row.Cells["cn_qty"].Value) == 0)
                        //    {
                        //        //red
                        //        row.Cells["cn_nomenclature"].Style.BackColor = Color.LightPink;
                        //    }
                        //    else if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) >
                        //       Math.Round(Convert.ToDouble(row.Cells["cn_qty"].Value), 3))
                        //    {
                        //        row.Cells["cn_nomenclature"].Style.Font = new Font(this.Font, FontStyle.Bold);
                        //        row.Cells["cn_nomenclature"].Style.ForeColor = Color.Red;
                        //    }
                        //    else { }
                        //    //if (Convert.ToDouble((row.Cells["cn_TheorRest"].Value)) < 0)
                        //    //{
                        //    //    row.Cells["cn_TheorRest"].Style.Font = new Font(this.Font, FontStyle.Bold);
                        //    //    row.Cells["cn_TheorRest"].Style.ForeColor = Color.Red;
                        //    //}
                        //    if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                        //        foreach (DataGridViewCell cell in row.Cells)
                        //            cell.Style.BackColor = Color.Gainsboro;
                    }
                }
            }
            catch
            { }
        }

        public void SetCellsColorMissings()
        {
            try
            {
                if (gv_List.Rows.Count > 0)
                {
                   
                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (Convert.ToDouble(row.Cells["cn_qty"].Value) > Convert.ToDouble(row.Cells["cn_available"].Value))
                        {
                            row.DefaultCellStyle.BackColor = Color.Tomato;
                        }
                      
                    }
                }
            }
            catch
            { }

        }

        public void FillAutoLaunch(int batchid, int stageid)
        {
            string strSelect = "declare @batch nvarchar(25) " +
                " select @batch = batch from PROD_BatchHead where id = " + batchid + 
                " if exists (select id from PROD_LaunchHead where name like @batch + '-1%') " +
                " select dbo.fn_LaunchNextName(" + batchid + ") " +
                " else " +
                " select dbo.fn_LaunchNextNameST("+ batchid +"," + stageid + ") ";
            // Comments = strSelect;
            string _res = Convert.ToString(Helper.GetOneRecord(strSelect));
            Launch = _res;
        }

        public bool CheckEmpty()
        {
            if (BatchId == 0
                || QtyInLaunch == 0
                || StartDate == ""
                || EndDate == ""
                || ProdStartDate == ""
                || (Convert.ToDateTime(StartDate) > Convert.ToDateTime(ProdStartDate))
                || (Convert.ToDateTime(ProdStartDate) > Convert.ToDateTime(EndDate))
                )
                return false;
            else
                return true;

        }

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
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                _k = 0;
                _tmpUnit = row.Cells["cn_unit"].Value.ToString().Trim();
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

        public void FillDates()
        {
            txt_EndDate.Value = System.DateTime.Now;
            txt_EndDate.Value = null;
            txt_StartDate.Value = System.DateTime.Now;
            txt_StartDate.Value = null;
            txt_ProdStartDate.Value = System.DateTime.Now;
            txt_ProdStartDate.Value = null;

        }

        public void ShowBatchDets(int _batchid, int _stageid)
        {
            var data = Plan_BLL.getLaunchesCreatDet(_batchid, _stageid);
            
            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;



                SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            QtyInLaunch = 0;
            FillBatchUnits();
            RecalcQtyCanBeLaunched(BatchId, StageId);
            RecalcQtyCanBeLaunchedTotal(BatchId, StageId);

        }

        public void ShowLaunchDets(int _launchid)
        {

        }

        public void RecalcQtyCanBeLaunched(int _batchid, int _stageid)
        {
            if (Mode == "new")
            {
                if (_batchid != 0)
                {
                    if (gv_List.Rows.Count > 0)
                    {
                        double maxq = Convert.ToDouble(gv_List.Rows[0].Cells["cn_onstock"].Value) / (Convert.ToDouble(gv_List.Rows[0].Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty);

                        foreach (DataGridViewRow row in this.gv_List.Rows)
                        {
                            try
                            {
                                if (Convert.ToDouble(row.Cells["cn_onstock"].Value) / (Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty) < maxq)
                                {
                                    maxq = Convert.ToDouble(row.Cells["cn_onstock"].Value) / (Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty);
                                }
                            }
                            catch { maxq = 0; }
                        }

                        QtyCanBeLaunched = Convert.ToInt32(maxq);
                    }
                    else
                        QtyCanBeLaunched = 0;
                }
                else
                { QtyCanBeLaunched = 0; }
            }
            //QtyNotLaunched = Convert.ToDouble(Helper.GetOneRecord("select isnull(dbo.fn_NotLaunchedBatchQty(" + _batchid + "," + _stageid + "), 0)"));
        }

        public void RecalcQtyCanBeLaunchedTotal(int _batchid, int _stageid)
        {
            if (Mode == "new")
            {
                if (_batchid != 0)
                {
                    if (gv_List.Rows.Count > 0)
                    {
                        double maxq = (Convert.ToDouble(gv_List.Rows[0].Cells["cn_onstock"].Value) + Convert.ToDouble(gv_List.Rows[0].Cells["cn_available"].Value)) / (Convert.ToDouble(gv_List.Rows[0].Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty);

                        foreach (DataGridViewRow row in this.gv_List.Rows)
                        {
                            try
                            {
                                if ((Convert.ToDouble(row.Cells["cn_onstock"].Value) + Convert.ToDouble(row.Cells["cn_available"].Value)) / (Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty) < maxq)
                                {
                                    maxq = (Convert.ToDouble(row.Cells["cn_onstock"].Value) + Convert.ToDouble(row.Cells["cn_available"].Value)) / (Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty);
                                }
                            }
                            catch { maxq = 0; }
                        }
                        try
                        {
                            QtyCanBeLaunchedTotal = Convert.ToInt32(maxq) > QtyCanBeLaunched ? QtyCanBeLaunched : Convert.ToInt32(maxq);
                        }
                        catch { QtyCanBeLaunchedTotal = 0; }
                    }
                    else
                        QtyCanBeLaunchedTotal = 0;
                }
                else
                { QtyCanBeLaunchedTotal = 0; }
            }
            //QtyNotLaunched = Convert.ToDouble(Helper.GetOneRecord("select isnull(dbo.fn_NotLaunchedBatchQty(" + _batchid + "," + _stageid + "), 0)"));
        }

        public void RecalcLaunchRMQty()
        {
            int _numdecimals = 0;
            gv_List.EndEdit();
            if (Mode == "new")
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    _numdecimals = Convert.ToInt32(row.Cells["cn_numdecimals"].Value);
                    //row.Cells["cn_qty"].Value = (Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty) * QtyInLaunch > Convert.ToDouble(row.Cells["cn_onstock"].Value) ?
                    //                            Convert.ToDouble(row.Cells["cn_onstock"].Value) : Math.Round((Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty) * QtyInLaunch, 5);
                    if (_numdecimals == 0)
                        row.Cells["cn_qty"].Value = Math.Round(((Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty) * QtyInLaunch) + 0.49, 0);
                    else
                        row.Cells["cn_qty"].Value = Math.Round((Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value) / cmb_Batches1.Qty) * QtyInLaunch, _numdecimals);
                }
            }

            SetCellsColor();
            SetCellsColorMissings();
        }
        
        #endregion

        #region Controls

        #region Context menu


        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_List.ClearSelection();
                gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
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
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColor();

        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_List;
            frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
                else
                    bs_List.Filter = bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            SetCellsColor();
            RecalcQtyCanBeLaunched(BatchId, StageId);
            RecalcQtyCanBeLaunchedTotal(BatchId, StageId);

        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for batches list";
            frm.grid = this.gv_List;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_List);
            }
        }

        #endregion


        private void cmb_Batches1_BatchChanged(object sender)
        {
            cmb_BatchStages1.BatchId = BatchId;
            txt_BatchComments.Text = cmb_Batches1.Comments;
            //ShowBatchHead(BatchId, StageId);
            //if (Mode == "new")
            //{
            //    FillAutoLaunch(BatchId);
            //}
            //ShowBatchDets(BatchId, StageId);

        }

        private void ctl_CreatLaunchDets_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void cmb_BatchStages1_StageChanged(object sender)
        {
            ShowBatchHead(BatchId, StageId);
            ShowBatchDets(BatchId, StageId);
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            //if (QtyInLaunch > QtyCanBeLaunched)
            //    QtyInLaunch = QtyCanBeLaunched;
            if (QtyInLaunch > QtyNotLaunched)
                QtyInLaunch = QtyNotLaunched;

            RecalcLaunchRMQty();           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            int _bdtemp = 0;
            if (QtyInLaunch > 0
                //&& gv_List.Rows.Count > 0
                && CheckEmpty() != false
                && cmb_BatchStages1.StageId != 0)
            {
                _bdtemp = 0;
                DataTable datadets = new DataTable();
                datadets.Columns.Add("batchdetid", typeof(int));
                datadets.Columns.Add("artid", typeof(int));
                datadets.Columns.Add("qty", typeof(double));

                foreach (DataGridViewRow row in gv_List.Rows)
                {
                    if (_bdtemp != Convert.ToInt32(row.Cells["cn_batchdetid"].Value)
                        && Convert.ToDouble(row.Cells["cn_qty"].Value) > 0
                        && Convert.ToInt32(row.Cells["cn_batchdetid"].Value) != 0)
                    {
                        //Insert into temporary table
                        DataRow drl = datadets.NewRow();
                        drl["batchdetid"] = Convert.ToInt32(row.Cells["cn_batchdetid"].Value);
                        drl["artid"] = Convert.ToInt32(row.Cells["cn_artid"].Value);
                        drl["qty"] = Convert.ToDouble(row.Cells["cn_qty"].Value);

                        datadets.Rows.Add(drl);

                        //Switch
                        _bdtemp = Convert.ToInt32(row.Cells["cn_batchdetid"].Value);
                    }
                }

                int _result = BLL.AddLaunch(BatchId, StageId, QtyInLaunch, Comments, StartDate, EndDate, datadets, ProdStartDate);

                if (_result != 0
                    && SaveLaunch != null)
                    SaveLaunch(this);

            }
            else
                MessageBox.Show("Please check quantity and stage and dates of the batch!");
        }


        private void cmb_SalesOrdersWithLines1_SalesOrderChanged(object sender)
        {

        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gv_List.SelectedRows)
            {
                gv_List.Rows.Remove(row);
            }

            RecalcQtyCanBeLaunched(BatchId, StageId);
            RecalcQtyCanBeLaunchedTotal(BatchId, StageId);
        }


        private void btn_Round_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (row.Cells["cn_unit"].Value.ToString().Trim() == cmb_Unit.Text.Trim())
                {
                    row.Cells["cn_qty"].Value = glob_Class.RoundUp(Convert.ToDouble(row.Cells["cn_qty"].Value), Convert.ToInt32(cmb_Decimals.Text));
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                QtyInLaunch = 0;
                row.Cells["cn_qty"].Value = 0;                
            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_RecalcLaunched_Click(object sender, EventArgs e)
        {
            RecalcQtyCanBeLaunched(BatchId, StageId);
            RecalcQtyCanBeLaunchedTotal(BatchId, StageId);
        }

        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowBatchHead(BatchId, StageId);
            if (Mode == "new")
            {
                FillAutoLaunch(BatchId, StageId);
            }
            ShowBatchDets(BatchId, StageId);
        }
    }
}