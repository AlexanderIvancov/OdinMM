using ComponentFactory.Krypton.Toolkit;
using Odin.CustomControls;
using Odin.Global_Classes;
using Odin.Planning;
using Odin.Tools;
using Odin.Workshop;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.DataCollection
{

    public partial class frm_MasterApproveFin : BaseForm
    {
        public frm_MasterApproveFin()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
            NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
            this.gv_Serials.EditingControlShowing +=
                new DataGridViewEditingControlShowingEventHandler(gv_Serials_EditingControlShowing);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public int ReadValue = 0;
        public string Result = "";

        class_Global globClass = new class_Global();
        PrinterLabels PrintLabels = new PrinterLabels();
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        DC_BLL DCBll = new DC_BLL();
        Plan_BLL PlanBll = new Plan_BLL();
        Processing_BLL PBLL = new Processing_BLL();
        public DataTable datadetails;
        frm_ScreenNumKeyboard popup;
        PopupWindowHelper PopupHelper = null;
        private static KeyPressEventHandler NumericCheckHandler;

        int _masterid = 0;

        public int MasterId
        {
            get { return _masterid; }
            set { _masterid = value; }
        }
        int _stateid = 0;
        /*
        0 - Available
        1 - At work
        2 - Paused             
        */
        public int StateId
        {
            get { return _stateid; }
            set { _stateid = value; }
        }

        public string Master
        {
            get { return txt_Master.Text; }
            set { txt_Master.Text = value; }
        }

        int _prevstageid = 0;
        public int PrevStageId
        {
            get { return _prevstageid; }
            set { _prevstageid = value; }
        }

        int _launchid = 0;

        public int LaunchId
        {
            get { return _launchid; }
            set { _launchid = value; }
        }

        string _launch = "";


        public int NextStageId
        { get; set; }

        public string PrevStage
        { get; set; }

        public int AllowMoveBack
        { get; set; }

        public int IsNextStageLast
        { get; set; }

        public int ProdPlace
        {
            get { return cmb_CommonPDA1.SelectedValue; }
            set { cmb_CommonPDA1.SelectedValue = value; }

            //    get
            //    {
            //        if (rb_Valkas2.Checked == true)
            //            return 1;
            //        else if (rb_Valkas2B.Checked == true)
            //            return 2;
            //        else
            //            return 0;
            //    }
            //    set
            //    {
            //        if (value == 1)
            //        {
            //            rb_Valkas2.Checked = true;
            //            rb_Valkas2B.Checked = false;
            //        }
            //        else if (value == 2)
            //        {
            //            rb_Valkas2.Checked = false;
            //            rb_Valkas2B.Checked = true;
            //        }
            //        else
            //        {
            //            rb_Valkas2.Checked = false;
            //            rb_Valkas2B.Checked = false;
            //        }
            //    }
        }

        public int StageId
        {
            get; set;
        }


        public int BatchId
        { get; set; }


        public double Freezed
        {
            get; set;
        }
        public double OldFreezed
        { get; set; }

        public double QtyStarted
        {
            get; set;
        }
        public double QtyTotalStarted
        {
            get; set;
        }
        public double Qty
        {
            get { return Convert.ToDouble(txt_Qty.Text); }
            set { txt_Qty.Text = value.ToString(); }
        }
        public double QtyToStart
        {
            get { return Convert.ToDouble(txt_QtyToStart.Text); }
            set { txt_QtyToStart.Text = value.ToString(); }
        }

        private float _measCellValue;
        public float MeasCellValue
        {
            get { return _measCellValue; }
            set { _measCellValue = value; }
        }

        public double PrevQty
        { get; set; }

        int _tmplaunchid = 0;

        public int TmpLaunchId
        {
            get { return _tmplaunchid; }
            set { _tmplaunchid = value; }
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            //foreach (DataGridViewRow row in this.gv_Serials.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
            //}
        }
        public void FillList()
        {
            var data = DC_BLL.getSerialNumbersNotApprovedAll(ProdPlace);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                //SetCellsColor();
            });


        }

        public void FillListLaunch(int _launchid)
        {
            //datadetails.Clear();
            datadetails = DC_BLL.getSerialNumbersNotApproved(_launchid, ProdPlace);

            gv_Serials.ThreadSafeCall(delegate
            {
                gv_Serials.AutoGenerateColumns = false;
                bs_Serials.DataSource = datadetails;
                gv_Serials.DataSource = bs_Serials;

                foreach (DataGridViewRow row in this.gv_Serials.Rows)
                {
                    row.Cells["cn_rtoapprove"].Value = Convert.ToDouble(row.Cells["cn_rqty"].Value);
                }

                SetCellsColor();
            });

            RecalcQtySerials();
        }

        public void RecalcQtySerials()
        {
            gv_Serials.EndEdit();
            double _qty = 0;

            foreach (DataGridViewRow row in this.gv_Serials.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_select"].Value) == -1)
                    try
                    {
                        _qty = _qty + Convert.ToDouble(row.Cells["cn_rtoapprove"].Value);
                    }
                    catch { _qty = _qty + 0; }
            }
            Qty = _qty;
        }

        public void RecalcQtyToStart()
        {
            gv_Serials.EndEdit();
            //double _qty = 0;

            //foreach (DataGridViewRow row in this.gv_Serials.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_select"].Value) == -1)
            //        try
            //        {
            //            _qty = _qty + Convert.ToDouble(row.Cells["cn_rtoapprove"].Value);
            //        }
            //        catch { _qty = _qty + 0; }
            //}
            if (Qty > QtyStarted)
            {
                if (QtyStarted + (PrevQty - QtyTotalStarted) > Qty)
                    QtyToStart = Qty - QtyStarted;
                else
                    QtyToStart = (PrevQty - QtyTotalStarted);
            }
            else
                QtyToStart = 0;
        }

        public void RecalcData(int _launchid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            sqlConn.Open();
            DataSet ds1 = new DataSet();

            SqlDataAdapter adapter1 =
                       new SqlDataAdapter(
                           "select lh.id, lh.name, lh.stageid, lh.batchid, " +
                                       " convert(float, isnull(fb.qty, 0)) as freezed, convert(float, isnull(sta.qtystarted, 0)) as started, " +
                                       " convert(float, isnull(totsta.qtystarted, 0)) as totalstarted " +
                                       " from prod_launchhead lh " +
                                       " left join PROD_FreezedLaunchStages fb on fb.launchid = lh.id and fb.stageid = lh.stageid" +
                                       " left join (select lsh.launchid, sum(lsh.qty) as qtystarted from PROD_LaunchStagesHis lsh " +
                                       "                   inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid and lsh.stageid = lh1.stageid" +
                                       "                    where lh1.id = " + _launchid + "" +
                                       "                    group by lh1.batchid, lsh.stageid, lsh.launchid) sta on sta.launchid = lh.id" +
                                       " left join (select lsh.launchid, sum(lsh.qty) as qtystarted from PROD_LaunchStagesHis lsh " +
                                       "                   inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid and lsh.stageid = lh1.stageid" +
                                       "                    where lh1.id = " + _launchid + " and lh1.qty > 0 " +
                                       "                    group by lh1.batchid, lsh.stageid, lsh.launchid) totsta on totsta.launchid = lh.id" +
                                       " where lh.id = " + _launchid + "", sqlConn);

            adapter1.Fill(ds1);

            DataTable dt1 = ds1.Tables[0];

            if (dt1.Rows.Count > 0)
            {
                foreach (DataRow dr1 in dt1.Rows)
                {

                    QtyStarted = Convert.ToDouble(dr1["started"].ToString()) - Convert.ToDouble(dr1["freezed"].ToString());
                    QtyTotalStarted = Convert.ToDouble(dr1["totalstarted"].ToString()) - Convert.ToDouble(dr1["freezed"].ToString());
                    //MessageBox.Show(QtyStarted.ToString());

                }
            }

            sqlConn.Close();
        }
        public void FillData(int _batchid, int _stageid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectBatchStageDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);

            sqlConn.Open();

            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows == true)
            {
                reader.Read();

                PrevStage = reader["prevname"].ToString();
                PrevStageId = Convert.ToInt32(reader["previd"]);
                NextStageId = Convert.ToInt32(reader["nextid"]);
                AllowMoveBack = Convert.ToInt32(reader["allowmoveback"]);
                IsNextStageLast = Convert.ToInt32(reader["isnextstagelast"]);

                reader.Close();
            }
            else
                ClearFields();

            sqlConn.Close();

        }

        public void ClearFields()
        {
            PrevStage = "";
            PrevStageId = 0;
            NextStageId = 0;
            AllowMoveBack = -1;
            IsNextStageLast = 0;
        }

        public void RefreshData(object sender)
        {
            FillList();
        }

        public void RecalcQty()
        {
            gv_List.EndEdit();

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_check"].Value) == -1)
                    row.Cells["cn_toapprove"].Value = Convert.ToDouble(row.Cells["cn_qty"].Value);
                else
                    row.Cells["cn_toapprove"].Value = 0;

            }
        }
        #region ScreenKeyboard

        private void ShowScreenNumKeyboard(DataGridViewCellEventArgs e, int columnIndex, int rowIndex)
        {
            string columnName = gv_Serials.Columns["cn_rtoapprove"].Name;

            //int rowHeight = dataGridView1.Rows[e.RowIndex].Height;
            int columnWidth = gv_Serials.Columns[columnName].Width;

            int ColumnIndex = columnIndex != -1 ? columnIndex : e.ColumnIndex;
            int RowIndex = rowIndex != -1 ? rowIndex : e.RowIndex;

            Rectangle cellRectangle = gv_Serials.GetCellDisplayRectangle(ColumnIndex, RowIndex, false);

            cellRectangle.X += gv_Serials.Left + columnWidth;
            cellRectangle.Y += gv_Serials.Top - 20;

            Point displayPoint = PointToScreen(new Point(cellRectangle.X, cellRectangle.Y));

            popup = new frm_ScreenNumKeyboard();
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            //popup.frm_MainOne = this;

            Form f;
            f = this.FindForm();

            PopupHelper.ShowPopup(f, popup, displayPoint);
        }

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (symremove)
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value = symbol;
                gv_Serials.CurrentCell.Value = symbol;
            }
            else
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value += symbol;
                if (Convert.ToDouble(gv_Serials.CurrentCell.Value + symbol) <= Convert.ToDouble(gv_Serials.CurrentRow.Cells["cn_rqty"].Value))
                    gv_Serials.CurrentCell.Value += symbol;
            }
            RecalcQtySerials();
        }

        private void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        #endregion

        #endregion

        private void btn_AssignMaster_Click(object sender, EventArgs e)
        {
            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.LabelText = "Scan your rfid: ";
            frm.HeaderText = "Scan your rfid: ";
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "execute sp_SelectMasterSN @rfid = '" + frm.FormText + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        if (Convert.ToInt32(dr1["isactive"]) == -1)
                        {
                            Master = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            MasterId = Convert.ToInt32(dr1["id"].ToString());
                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong master scanning! Your state is inactive!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");
                            Master = "";
                            MasterId = 0;
                        }
                    }
                }

                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong msater scanning! Your rfid is not correct or you have no master access!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your rfid is not correct!");
                    Master = "";
                    MasterId = 0;
                }
                sqlConn.Close();

            }

        }

        //private void btn_Approve_Click(object sender, EventArgs e)
        //{
        //    gv_List.EndEdit();

        //    if (MasterId != 0
        //        && LaunchId != 0)
        //    {
        //        Qty = 0;
        //        foreach (DataRow row in datadetails.Rows)
        //        {

        //            Qty = Qty + Convert.ToDouble(row["qty"]);

        //        }

        //        if (Qty <= QtyStarted)
        //        {
        //            //Save info
        //            DataTable data = new DataTable();
        //            data.Columns.Add("id", typeof(int));
        //            data.Columns.Add("issn", typeof(int));
        //            data.Columns.Add("qty", typeof(double));

        //            foreach (DataRow row in datadetails.Rows)
        //            {
        //                    DataRow drser = data.NewRow();
        //                    drser["id"] = Convert.ToInt32(row["id"]);
        //                    drser["issn"] = Convert.ToInt32(row["issn"]);
        //                    drser["qty"] = Convert.ToDouble(row["qty"]);
        //                    data.Rows.Add(drser);
        //            }

        //            double _qty = 0;

        //            _qty = DCBll.ApproveDataCollection(data, MasterId);

        //            if (_qty > 0 || Freezed != OldFreezed)
        //            {
        //                //MessageBox.Show("Save launch");
        //                int _res = PBLL.SaveLaunchStageProcess(LaunchId,
        //                    PrevStageId, StageId, NextStageId,
        //                    0,
        //                    _qty,
        //                    Freezed,
        //                    IsNextStageLast == -1 ? 0 : ProdPlace);
        //            }

        //            DialogResult result = KryptonTaskDialog.Show("Approving of info was successful!",
        //                                                            "Approving of info was successful!",
        //                                                            "",
        //                                                            MessageBoxIcon.Information,
        //                                                            TaskDialogButtons.OK);

        //            LaunchId = 0;
        //            BatchId = 0;
        //            StageId = 0;
        //            FillList();
        //            FillData(0, 0);
        //        }
        //        else
        //        {
        //            System.Media.SystemSounds.Exclamation.Play();
        //            frm_Error frm1 = new frm_Error();
        //            frm1.HeaderText = "Started qty less than you want to approve!";
        //            DialogResult result1 = frm1.ShowDialog();
        //        }
        //    }
        //    else
        //    {
        //        System.Media.SystemSounds.Exclamation.Play();
        //        frm_Error frm1 = new frm_Error();
        //        frm1.HeaderText = "Please check Master and Launch!";
        //        DialogResult result1 = frm1.ShowDialog();
        //    }
        //}
        private void btn_Approve_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            if (MasterId != 0
                && LaunchId != 0
                && Qty > 0)
            {
                if (Qty <= QtyStarted)
                {
                    //Save info
                    DataTable data = new DataTable();
                    data.Columns.Add("id", typeof(int));
                    data.Columns.Add("issn", typeof(int));
                    data.Columns.Add("qty", typeof(double));

                    foreach (DataGridViewRow row in this.gv_Serials.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_select"].Value) == -1
                            && Convert.ToDouble(row.Cells["cn_rtoapprove"].Value) > 0)
                        {
                            DataRow drser = data.NewRow();
                            drser["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                            drser["issn"] = Convert.ToInt32(row.Cells["cn_issn"].Value);
                            drser["qty"] = Convert.ToDouble(row.Cells["cn_rtoapprove"].Value);
                            data.Rows.Add(drser);
                        }
                    }

                    double _qty = 0;

                    _qty = DCBll.ApproveDataCollection(data, MasterId);

                    if (_qty > 0 || Freezed != OldFreezed)
                    {
                        //MessageBox.Show("Save launch");
                        int _res = PBLL.SaveLaunchStageProcess(LaunchId,
                            PrevStageId, StageId, NextStageId,
                            0,
                            _qty,
                            Freezed,
                            IsNextStageLast == -1 ? 0 : ProdPlace);
                    }

                    DialogResult result = KryptonTaskDialog.Show("Approving of info was successful!",
                                                                    "Approving of info was successful!",
                                                                    "",
                                                                    MessageBoxIcon.Information,
                                                                    TaskDialogButtons.OK);
                    FillList();


                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Started qty less than you want to approve!";
                    DialogResult result1 = frm1.ShowDialog();
                }
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Please check Master and Launch!";
                DialogResult result1 = frm1.ShowDialog();
            }
        }
        private void btn_Clean_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //gv_List.EndEdit();
            //if (gv_List.CurrentRow.Cells["chk_check"].Selected == true)
            //{
            //int _launchid = 0;
            //double _qty = 0;
            //try {

            //    if (Convert.ToInt32(gv_List.CurrentRow.Cells["chk_check"].Value) == -1)
            //    {
            //        _launchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_launchid"].Value);
            //        _qty = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_toapprove"].Value);
            //    }
            //    else
            //        _launchid = 0;
            //    foreach (DataGridViewRow row in this.gv_List.Rows)
            //    {
            //        if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_launchid"].Value) != Convert.ToInt32(row.Cells["cn_launchid"].Value))
            //            row.Cells["chk_check"].Value = 0;
            //    }

            //}
            //catch { }



            //    if (_launchid != 0)
            //    {
            //        SqlConnection sqlConn = new SqlConnection(sConnStr);
            //        sqlConn.Open();
            //        DataSet ds1 = new DataSet();

            //        SqlDataAdapter adapter1 =
            //            new SqlDataAdapter(
            //                "select lh.id, lh.name, lh.stageid, lh.batchid, isnull(dbo.fn_PrevQualityStage(lh.id), 0) as prevstageid, " +
            //                            " convert(float, isnull(fb.qty, 0)) as freezed, convert(float, isnull(sta.qtystarted, 0)) as started " +
            //                            " from prod_launchhead lh " +
            //                            " left join PROD_FreezedLaunchStages fb on fb.launchid = lh.id and fb.stageid = lh.stageid" +
            //                            " left join (select lsh.launchid, sum(lsh.qty) as qtystarted from PROD_LaunchStagesHis lsh " +
            //                            "                   inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid and lsh.stageid = lh1.stageid" +
            //                            "                    where lh1.id = " + _launchid + "" +
            //                            "                    group by lh1.batchid, lsh.stageid, lsh.launchid) sta on sta.launchid = lh.id" +
            //                            " where lh.id = " + _launchid + "", sqlConn);

            //        adapter1.Fill(ds1);

            //        DataTable dt1 = ds1.Tables[0];

            //        if (dt1.Rows.Count > 0)
            //        {
            //            foreach (DataRow dr1 in dt1.Rows)
            //            {
            //                LaunchId = Convert.ToInt32(dr1["id"].ToString());
            //                PrevStageId = Convert.ToInt32(dr1["prevstageid"].ToString());
            //                StageId = Convert.ToInt32(dr1["stageid"].ToString());
            //                BatchId = Convert.ToInt32(dr1["batchid"].ToString());
            //                Freezed = Convert.ToDouble(dr1["freezed"].ToString());
            //                OldFreezed = Convert.ToDouble(dr1["freezed"].ToString());
            //                QtyStarted = Convert.ToDouble(dr1["started"].ToString()) - Convert.ToDouble(dr1["freezed"].ToString());
            //                //MessageBox.Show(QtyStarted.ToString());
            //            }
            //        }
            //        else
            //        {
            //            //globClass.ShowMessage("Wrong launch scanning", "Please contact your master", "Your launch is not correct!");
            //            LaunchId = 0;
            //            PrevStageId = 0;
            //            StageId = 0;
            //            Freezed = 0;
            //            OldFreezed = 0;
            //            BatchId = 0;
            //            QtyStarted = 0;

            //        }
            //        sqlConn.Close();
            //    }
            //    else
            //    {
            //        LaunchId = 0;
            //        PrevStageId = 0;
            //        StageId = 0;
            //        Freezed = 0;
            //        OldFreezed = 0;
            //        BatchId = 0;
            //        QtyStarted = 0;
            //    }
            //    RecalcQty();
            //    FillListLaunch(LaunchId);

            //    FillData(BatchId, StageId);
            //}
        }

        private void frm_MasterApproveTot_Load(object sender, EventArgs e)
        {
            //FillList();
        }

        private void btn_EditContent_Click(object sender, EventArgs e)
        {
            if (globClass.IsFormAlreadyOpen("frm_MasterApproveDets")) return;

            if (LaunchId != 0)
            {
                frm_MasterApproveDets frm = new frm_MasterApproveDets();
                frm.MasterId = MasterId;
                frm.LaunchId = LaunchId;
                frm.Freezed = Freezed;
                frm.OldFreezed = Freezed;
                frm.ProdPlace = ProdPlace;
                frm.StageId = StageId;
                frm.PrevStageId = PrevStageId;
                frm.NextStageId = NextStageId;
                frm.IsNextStageLast = IsNextStageLast;
                frm.QtyStarted = QtyStarted;
                //frm.gv_List.ThreadSafeCall(delegate { frm.FillList(LaunchId); });
                frm.ApplyApproveChanges += new ApplyApprovingChangesEventHandler(RefreshData);

                frm.Show();
                frm.gv_List.ThreadSafeCall(delegate { frm.FillList(frm.LaunchId, frm.ProdPlace); });
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillList();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _launchid = 0;
            try { _launchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_launchid"].Value); }
            catch { }
            if (TmpLaunchId != _launchid)
            {
                if (_launchid != 0)
                {
                    SqlConnection sqlConn = new SqlConnection(sConnStr);
                    sqlConn.Open();
                    DataSet ds1 = new DataSet();

                    //SqlDataAdapter adapter1 =
                    //    new SqlDataAdapter(
                    //        "select lh.id, lh.name, lh.stageid, lh.batchid, isnull(dbo.fn_PrevQualityStage(lh.id), 0) as prevstageid, " +
                    //                    " convert(float, isnull(fb.qty, 0)) as freezed, convert(float, isnull(sta.qtystarted, 0)) as started " +
                    //                    " from prod_launchhead lh " +
                    //                    " left join PROD_FreezedLaunchStages fb on fb.launchid = lh.id and fb.stageid = lh.stageid" +
                    //                    " left join (select lsh.launchid, sum(lsh.qty) as qtystarted from PROD_LaunchStagesHis lsh " +
                    //                    "                   inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid and lsh.stageid = lh1.stageid" +
                    //                    "                    where lh1.id = " + _launchid + "" +
                    //                    "                    group by lh1.batchid, lsh.stageid, lsh.launchid) sta on sta.launchid = lh.id" +
                    //                    " where lh.id = " + _launchid + "", sqlConn);
                    SqlDataAdapter adapter1 =
                        new SqlDataAdapter(
                            "select lh.id, lh.name, lh.stageid, lh.batchid, isnull(dbo.fn_PrevQualityStage(lh.id), 0) as prevstageid, " +
                                        " convert(float, isnull(fb.qty, 0)) as freezed, convert(float, isnull(sta.qtystarted, 0)) as started, " +
                                        " convert(float, isnull(totsta.qtystarted, 0)) as totalstarted " +
                                        " from prod_launchhead lh " +
                                        " left join PROD_FreezedLaunchStages fb on fb.launchid = lh.id and fb.stageid = lh.stageid" +
                                        " left join (select lsh.launchid, sum(lsh.qty) as qtystarted from PROD_LaunchStagesHis lsh " +
                                        "                   inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid and lsh.stageid = lh1.stageid" +
                                        "                    where lh1.id = " + _launchid + "" +
                                        "                    group by lh1.batchid, lsh.stageid, lsh.launchid) sta on sta.launchid = lh.id" +
                                        " left join (select lsh.launchid, sum(lsh.qty) as qtystarted from PROD_LaunchStagesHis lsh " +
                                        "                   inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid and lsh.stageid = lh1.stageid" +
                                        "                    where lh1.id = " + _launchid + " and lh1.qty > 0 " +
                                        "                    group by lh1.batchid, lsh.stageid, lsh.launchid) totsta on totsta.launchid = lh.id" +
                                        " where lh.id = " + _launchid + "", sqlConn);

                    adapter1.Fill(ds1);

                    DataTable dt1 = ds1.Tables[0];

                    if (dt1.Rows.Count > 0)
                    {
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            LaunchId = Convert.ToInt32(dr1["id"].ToString());
                            PrevStageId = Convert.ToInt32(dr1["prevstageid"].ToString());
                            StageId = Convert.ToInt32(dr1["stageid"].ToString());
                            BatchId = Convert.ToInt32(dr1["batchid"].ToString());
                            Freezed = Convert.ToDouble(dr1["freezed"].ToString());
                            OldFreezed = Convert.ToDouble(dr1["freezed"].ToString());
                            QtyStarted = Convert.ToDouble(dr1["started"].ToString()) - Convert.ToDouble(dr1["freezed"].ToString());
                            QtyTotalStarted = Convert.ToDouble(dr1["totalstarted"].ToString()) - Convert.ToDouble(dr1["freezed"].ToString());
                            //MessageBox.Show(QtyStarted.ToString());
                            //string tmpstr = "select -1 * sum(lsh.qty) as qtyprev from PROD_LaunchStagesHis lsh " +
                            //    " inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid " +
                            //    " where lh1.batchid = " + BatchId +
                            //    " and lsh.stageid = " + PrevStageId +
                            //    " and lsh.qty < 0";
                            PrevQty = Convert.ToDouble(Helper.GetOneRecord("select isnull(-1 * sum(isnull(lsh.qty, 0)), 0) as qtyprev from PROD_LaunchStagesHis lsh " +
                                " inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid " +
                                " where lh1.batchid = " + BatchId +
                                " and lsh.stageid = " + PrevStageId +
                                " and lsh.qty < 0"));
                            //MessageBox.Show(PrevQty.ToString());
                        }
                    }
                    else
                    {
                        //globClass.ShowMessage("Wrong launch scanning", "Please contact your master", "Your launch is not correct!");
                        LaunchId = 0;
                        PrevStageId = 0;
                        StageId = 0;
                        Freezed = 0;
                        OldFreezed = 0;
                        BatchId = 0;
                        QtyStarted = 0;
                        QtyTotalStarted = 0;
                        PrevQty = 0;
                    }
                    sqlConn.Close();
                }
                else
                {
                    LaunchId = 0;
                    PrevStageId = 0;
                    StageId = 0;
                    Freezed = 0;
                    OldFreezed = 0;
                    BatchId = 0;
                    QtyStarted = 0;
                    PrevQty = 0;
                    QtyTotalStarted = 0;
                }
                FillListLaunch(_launchid);
                FillData(BatchId, StageId);
                TmpLaunchId = _launchid;
                RecalcQtyToStart();
            }
        }

        private void btn_Clean_Click_1(object sender, EventArgs e)
        {
            gv_Serials.ThreadSafeCall(delegate
            {

                foreach (DataGridViewRow row in this.gv_Serials.Rows)
                {
                    row.Cells["cn_rtoapprove"].Value = Convert.ToDouble(row.Cells["cn_rqty"].Value);
                }


                SetCellsColor();

                RecalcQtySerials();

            });
        }

        private void gv_Serials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_Serials.EndEdit();
            if (gv_Serials.CurrentRow.Cells["cn_select"].Selected == true)
            {
                RecalcQtySerials();
            }
        }

        private void gv_Serials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 8
                    && Convert.ToInt32(gv_Serials.CurrentRow.Cells["cn_issn"].Value) == 0)
                {
                    //MessageBox.Show(gv_List.CurrentCell.OwningColumn.Name);
                    ShowScreenNumKeyboard(e, -1, -1);
                    popup.CellText = gv_Serials.CurrentRow.Cells["cn_rtoapprove"].FormattedValue.ToString();
                }
            }
        }

        private void gv_Serials_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gv_Serials.CurrentCell.ColumnIndex == 8)
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
            else
            {
                e.Control.KeyPress -= NumericCheckHandler;
            }
        }

        private void gv_Serials_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (Convert.ToInt32(gv_Serials.CurrentRow.Cells["cn_issn"].Value) == -1)
                    gv_Serials.CurrentRow.Cells["cn_rtoapprove"].Value = 1;
                else
                {
                    if (gv_Serials.CurrentCell.Value != null &&
                        gv_Serials.CurrentCell.Value.ToString() == "-")
                    {
                        gv_Serials.CurrentCell.Value = null;
                    }

                    var cellValue = gv_Serials.CurrentCell.Value;
                    if (cellValue != null)
                    {

                        if (gv_Serials.Rows[e.RowIndex].Cells["cn_rtoapprove"].Value.ToString() != "")
                        {
                            MeasCellValue = float.Parse(gv_Serials.Rows[e.RowIndex].Cells["cn_rtoapprove"].Value.ToString());
                        }

                    }
                }
            }
        }

        private void gv_Serials_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gv_Serials.CurrentRow != null)
                {
                    popup.CellText = gv_Serials.CurrentRow.Cells["cn_rtoapprove"].Value.ToString();
                }
            }
            catch { }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            int _id = 0;
            int _issn = 0;

            if (globClass.DeleteConfirm() == true)
            {
                if (MasterId != 0)
                {
                    foreach (DataGridViewRow row in this.gv_Serials.SelectedRows)
                    {
                        try
                        {
                            _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                            _issn = Convert.ToInt32(row.Cells["cn_issn"].Value);
                        }
                        catch { _id = 0; }
                        if (_id != 0)
                        {
                            DCBll.DeleteDataCollection(_id, _issn);
                        }
                    }
                    FillList();
                    FillListLaunch(LaunchId);
                    //if (ApplyApproveChanges != null)
                    //    ApplyApproveChanges(this);
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Select master!";
                    DialogResult result1 = frm1.ShowDialog();
                }
            }
        }

        public void FillPlace()
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(Helper.GetOneRecord("select placeid from SYS_PCPlaces where pcname = '" + System.Environment.MachineName + "'"));
            }
            catch { }
            cmb_CommonPDA1.SelectedValue = _id;
        }

        private void btn_SetPlace_Click(object sender, EventArgs e)
        {
            DAL.MakeDefaultPlace(cmb_CommonPDA1.SelectedValue);
        }

        private void cmb_CommonPDA1_SelectedValueChanged(object sender)
        {
            FillList();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //int _id = 0;
            //try
            //{
            //    _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_launchid"].Value);
            //}
            //catch { _id = 0; }

            //PlanBll.LaunchId = _id;

            //if (PlanBll.LaunchIsStarted != -1)
            //{
            //    if (_id != 0
            //        && globClass.StartLaunchConfirm() == true)
            //    {
            //        DataTable datasource = Plan_BLL.StartLaunch(_id);
            //        if (datasource.Rows.Count > 0)
            //        {
            //            DialogResult result = KryptonTaskDialog.Show("Launch starting warning!",
            //                                               "Start is impossible!",
            //                                               "Launch have missing RM quantities!",
            //                                               MessageBoxIcon.Warning,
            //                                               TaskDialogButtons.OK);
            //            frm_LaunchStartMissings frm = new frm_LaunchStartMissings();
            //            frm.data = datasource.Clone();
            //            foreach (DataRow dr in datasource.Rows)
            //            {
            //                frm.data.ImportRow(dr);
            //            }

            //            frm.FillData();

            //            frm.Show();
            //        }
            //        else
            //        {
            //            DialogResult result = KryptonTaskDialog.Show("Launch started successfully!",
            //                                               "You can print route list for batch!",
            //                                               "Launch started!",
            //                                               MessageBoxIcon.Information,
            //                                               TaskDialogButtons.OK);
            //        }

            //        //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(12).ToShortDateString());

            //    }
            //}
            //else
            //{
            //    DialogResult result = KryptonTaskDialog.Show("Launch starting warning!",
            //                                                    "Start is impossible!",
            //                                                    "Launch already started!",
            //                                                    MessageBoxIcon.Warning,
            //                                                    TaskDialogButtons.OK);
            //}
        }

        private void btn_DeleteSN_Click(object sender, EventArgs e)
        {

        }

        private void btn_Start1_Click(object sender, EventArgs e)
        {
            int _res = 0;

            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_launchid"].Value);
            }
            catch { _id = 0; }

            PlanBll.LaunchId = _id;
            if (QtyToStart > 0)
            {
                _res = PBLL.SaveLaunchStageProcess(_id,
                                  PrevStageId,
                                  StageId,
                                  NextStageId,
                                  QtyToStart,
                                  //Convert.ToDouble(row.Cells["cn_tostart"].Value),
                                  0,
                                  Freezed,
                                  0);

                RecalcData(_id);
                gv_List.CurrentRow.Cells["cn_qtystarrted"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qtystarrted"].Value) + QtyToStart;
                RecalcQtyToStart();
            }
        }
    }
}
