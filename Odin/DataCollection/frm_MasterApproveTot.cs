using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Workshop;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Odin.DataCollection
{

    public partial class frm_MasterApproveTot : BaseForm
    {
        public frm_MasterApproveTot()
        {
            InitializeComponent();            
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
        public DataTable datadetails;

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
            get
            {
                return rb_Valkas2.Checked == true ? 1 : rb_Valkas2B.Checked == true ? 2 : 0;
            }
            set
            {
                if (value == 1)
                {
                    rb_Valkas2.Checked = true;
                    rb_Valkas2B.Checked = false;
                }
                else if (value == 2)
                {
                    rb_Valkas2.Checked = false;
                    rb_Valkas2B.Checked = true;
                }
                else
                {
                    rb_Valkas2.Checked = false;
                    rb_Valkas2B.Checked = false;
                }
            }
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
            get;set;
        }

        public double Qty
        { get; set; }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
               
            }
        }
        public void FillList()
        {
            var data = (DataTable)Helper.getSP("sp_SelectSerialNumbersNAAll", ProdPlace);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
                
                SetCellsColor();
            });

          
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

        public void FillListLaunch(int _launchid)
        {
            //datadetails.Clear();
            datadetails = (DataTable)Helper.getSP("sp_SelectSerialNumbersNA", _launchid, ProdPlace);
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
                row.Cells["cn_toapprove"].Value = Convert.ToInt32(row.Cells["chk_check"].Value) == -1 ? Convert.ToDouble(row.Cells["cn_qty"].Value) : (object)0;

            }
        }
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

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            if (MasterId != 0
                && LaunchId != 0)
            {
                Qty = 0;
                foreach (DataRow row in datadetails.Rows)
                {
                    
                    Qty = Qty + Convert.ToDouble(row["qty"]);
                    
                }

                if (Qty <= QtyStarted)
                {
                    //Save info
                    DataTable data = new DataTable();
                    data.Columns.Add("id", typeof(int));
                    data.Columns.Add("issn", typeof(int));
                    data.Columns.Add("qty", typeof(double));

                    foreach (DataRow row in datadetails.Rows)
                    {
                            DataRow drser = data.NewRow();
                            drser["id"] = Convert.ToInt32(row["id"]);
                            drser["issn"] = Convert.ToInt32(row["issn"]);
                            drser["qty"] = Convert.ToDouble(row["qty"]);
                            data.Rows.Add(drser);
                    }

                        double _qty = 0;

                        _qty = Convert.ToDouble(Helper.getSP("sp_AddDataCollectionApprove", data, MasterId));

                    if (_qty > 0 || Freezed != OldFreezed)
                    {
                        //MessageBox.Show("Save launch");
                        int _res = Convert.ToInt32(Helper.getSP("sp_SaveLaunchStageProcess", LaunchId,
                            PrevStageId, StageId, NextStageId,
                            0,
                            _qty,
                            Freezed,
                            IsNextStageLast == -1 ? 0 : ProdPlace));
                    }

                    DialogResult result = KryptonTaskDialog.Show("Approving of info was successful!",
                                                                    "Approving of info was successful!",
                                                                    "",
                                                                    MessageBoxIcon.Information,
                                                                    TaskDialogButtons.OK);

                    LaunchId = 0;
                    BatchId = 0;
                    StageId = 0;
                    FillList();
                    FillData(0, 0);
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
            gv_List.ThreadSafeCall(delegate
            {

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["cn_toapprove"].Value = Convert.ToDouble(row.Cells["cn_qty"].Value);
                    row.Cells["chk_check"].Value = 0;
                }

                SetCellsColor();
            });
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            if (gv_List.CurrentRow.Cells["chk_check"].Selected == true)
            {
                int _launchid = 0;
                double _qty = 0;
                try {
                    
                    if (Convert.ToInt32(gv_List.CurrentRow.Cells["chk_check"].Value) == -1)
                    {
                        _launchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_launchid"].Value);
                        _qty = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_toapprove"].Value);
                    }
                    else
                        _launchid = 0;
                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_launchid"].Value) != Convert.ToInt32(row.Cells["cn_launchid"].Value))
                            row.Cells["chk_check"].Value = 0;
                    }

                }
                catch { }



                if (_launchid != 0)
                {
                    SqlConnection sqlConn = new SqlConnection(sConnStr);
                    sqlConn.Open();
                    DataSet ds1 = new DataSet();

                    SqlDataAdapter adapter1 =
                        new SqlDataAdapter(
                            "select lh.id, lh.name, lh.stageid, lh.batchid, isnull(dbo.fn_PrevQualityStage(lh.id), 0) as prevstageid, " +
                                        " convert(float, isnull(fb.qty, 0)) as freezed, convert(float, isnull(sta.qtystarted, 0)) as started " +
                                        " from prod_launchhead lh " +
                                        " left join PROD_FreezedLaunchStages fb on fb.launchid = lh.id and fb.stageid = lh.stageid" +
                                        " left join (select lsh.launchid, sum(lsh.qty) as qtystarted from PROD_LaunchStagesHis lsh " +
                                        "                   inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid and lsh.stageid = lh1.stageid" +
                                        "                    where lh1.id = " + _launchid + "" +
                                        "                    group by lh1.batchid, lsh.stageid, lsh.launchid) sta on sta.launchid = lh.id" +
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
                            //MessageBox.Show(QtyStarted.ToString());
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
                }
                RecalcQty();
                FillListLaunch(LaunchId);
                
                FillData(BatchId, StageId);
            }
        }

        private void frm_MasterApproveTot_Load(object sender, EventArgs e)
        {
            FillList();
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

                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillList();
        }

        private void btn_SetPlace_Click(object sender, EventArgs e)
        {
            DAL.MakeDefaultPlace(cmb_CommonPDA1.SelectedValue);
        }
    }
}
