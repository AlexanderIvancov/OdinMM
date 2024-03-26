using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.DataCollection
{
    public partial class frm_WorkerDC : BaseForm
    {
        public frm_WorkerDC()
        {
            InitializeComponent();
            timer.Interval = 300000;//для 10 минут значение меньше 600000
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        bool flag;

        void timer_Tick(object sender, EventArgs e)
        {
            MouseSimulator.MoveMouseAround();
        }



        #region Variables

        private ScanDataReceived DataReceived = new ScanDataReceived();

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public int ReadValue = 0;
        public string Result = "";

        class_Global globClass = new class_Global();
        PrinterLabels PrintLabels = new PrinterLabels();
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        DC_BLL DCBll = new DC_BLL();

        string _worker = "";
        int _workerid = 0;
        public string Worker
        {
            get { return txt_Worker.Text; }
            set { txt_Worker.Text = value; }
        }

        public int WorkerId
        {
            get { return _workerid; }
            set { _workerid = value; }
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
        
        string _launch = "";

        public string Launch
        {
            get { return txt_Launch.Text; }
            set { txt_Launch.Text = value; }
        }

        int _launchid = 0;

        public int LaunchId
        {
            get { return _launchid; }
            set { _launchid = value; }
        }

        int _workid = 0;

        int _prevstageid = 0;
        public int PrevStageId
        {
            get { return _prevstageid; }
            set { _prevstageid = value; }
        }

        public int WorkId
        {
            get { return _workid; }
            set { _workid = value; }
        }

        int _ContType = -1;

        public int OutMode
        {
            get { return _ContType; }
            set
            {
                _ContType = value;
                if (_ContType == -1)
                {
                    chk_Serial.BackColor = Color.LightPink;
                    chk_Launch.BackColor = Color.LightGreen;
                    chk_Materials.BackColor = Color.LightGreen;
                }
                else if (_ContType == 0)
                {
                    chk_Serial.BackColor = Color.LightGreen;
                    chk_Launch.BackColor = Color.LightGreen;
                    chk_Materials.BackColor = Color.LightPink;
                }
                else
                {
                    chk_Serial.BackColor = Color.LightGreen;
                    chk_Launch.BackColor = Color.LightPink;
                    chk_Materials.BackColor = Color.LightGreen;
                }
            }
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
        public void FillList(int _workerid, int _launchid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectSerialNumbersByWorkerByDate", _workerid, _launchid);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });

            //bn_.ThreadSafeCall(delegate
            //{
            //    bn_Materials.BindingSource = bs_Boxes;
            //});
        }

        public void FillMaterials(int _workerid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectMaterialsByWorkerByDate", _workerid);


            gv_Materials.ThreadSafeCall(delegate
            {
                gv_Materials.AutoGenerateColumns = false;
                bs_Materials.DataSource = data;
                gv_Materials.DataSource = bs_Materials;

                //SetCellsColor();
            });

            bn_Materials.ThreadSafeCall(delegate
            {
                bn_Materials.BindingSource = bs_Materials;
            });
        }

        public void FillMaterialsByLaunch(int _launchid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectMaterialsByLaunch", _launchid);


            gv_Materials.ThreadSafeCall(delegate
            {
                gv_Materials.AutoGenerateColumns = false;
                bs_Materials.DataSource = data;
                gv_Materials.DataSource = bs_Materials;

                //SetCellsColor();
            });

            bn_Materials.ThreadSafeCall(delegate
            {
                bn_Materials.BindingSource = bs_Materials;
            });
        }
        #endregion

        private void frm_WorkerDC_Activated(object sender, EventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void frm_WorkerDC_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            timer.Dispose();
        }

        private void frm_WorkerDC_Load(object sender, EventArgs e)
        {
            Helper.LoadColumns(gv_List, this.Name);
            Helper.LoadColumns(gv_Materials, this.Name);
            txt_Oper.Focus();
        }

      

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_Serial_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Serial.Checked == true)
                OutMode = -1;
        }

        private void chk_Materials_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Materials.Checked == true)
                OutMode = 0;
        }

        private void chk_Launch_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Launch.Checked == true)
                OutMode = 1;
        }

        private void btn_ChangeWorker_Click(object sender, EventArgs e)
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
                        "execute sp_SelectWorkerSN @rfid = '" + frm.FormText + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        if (Convert.ToInt32(dr1["isactive"]) == -1)
                        {
                            Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            WorkerId = Convert.ToInt32(dr1["id"].ToString());
                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong worker scanning! Your state is inactive! Please contact your master!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");
                            Worker = "";
                            WorkerId = 0;
                        }
                    }                  
                }
                
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong worker scanning! Your rfid is not correct! Please contact your master!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your rfid is not correct!");
                    Worker = "";
                    WorkerId = 0;
                }
                sqlConn.Close();

                FillList(WorkerId, LaunchId);
                //FillMaterials(WorkerId);

                OutMode = -1;
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }

            else
            {
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void btn_ChangeLaunch_Click(object sender, EventArgs e)
        {
            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.LabelText = "Scan launch: ";
            frm.HeaderText = "Scan launch: ";
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "select id, name, isnull(dbo.fn_PrevQualityStage(id), 0) as prevstageid from prod_launchhead where name = '" + frm.FormText + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        LaunchId = Convert.ToInt32(dr1["id"].ToString());
                        Launch = dr1["name"].ToString();
                        PrevStageId = Convert.ToInt32(dr1["prevstageid"].ToString());
                    }
                    FillMaterialsByLaunch(LaunchId);
                    FillList(WorkerId, LaunchId);
                }
                else
                {
                    //globClass.ShowMessage("Wrong launch scanning", "Please contact your master", "Your launch is not correct!");
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong launch scanning! Scan correct launch!";
                    DialogResult result1 = frm1.ShowDialog();
                    LaunchId = 0;
                    Launch = "";
                    PrevStageId = 0;
                    FillMaterialsByLaunch(0);
                    FillList(WorkerId, LaunchId);
                }
                sqlConn.Close();
                OutMode = -1;
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
            else
            {
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (WorkerId == 0
                    || LaunchId == 0)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Empty fields detected! Please check worker or launch!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Empty fields detected!", "Please check worker or launch", "Launch or worker are empty!");
                    OutMode = -1;
                    txt_Oper.Focus();
                }
                else
                {
                    string _serial = txt_Oper.Text.Trim();
                    string _res = DCBll.AddDataCollectionSerial(WorkerId, _serial, LaunchId, PrevStageId);
                    if (DCBll.SuccessId == -1)
                        FillList(WorkerId, LaunchId);
                    else if (DCBll.SuccessId == 1)
                        FillMaterialsByLaunch(LaunchId);
                    else
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        frm_Error frm1 = new frm_Error();
                        frm1.HeaderText = "Something wrong! " + _res;
                        DialogResult result = frm1.ShowDialog();
                    }
                    //if (OutMode == -1) //Serial numbers
                    //{

                    //    FillList(WorkerId);
                    //    txt_Oper.Focus();
                    //}
                    //else if (OutMode == 0) //Materials
                    //{

                    //    FillMaterials(WorkerId);
                    //    txt_Oper.Focus();
                    //}
                    //else //Launch
                    //{


                    //}
                    txt_Oper.Text = "";
                    txt_Oper.Focus();
                }
            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_DirectQty_Click(object sender, EventArgs e)
        {
            if (WorkerId == 0
                     || LaunchId == 0)
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Empty fields detected! Please check worker or launch!";
                DialogResult result1 = frm1.ShowDialog();
                OutMode = -1;
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
            else
            {
                frm_AddNumPDA frm = new frm_AddNumPDA();
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string _res = DCBll.AddDataCollectionQty(WorkerId, LaunchId, frm.Qty);
                    if (DCBll.SuccessId == -1)
                        FillList(WorkerId, LaunchId);
                    else
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        frm_Error frm1 = new frm_Error();
                        frm1.HeaderText = "Something wrong! " + _res;
                        DialogResult result1 = frm1.ShowDialog();
                    }
                    //MessageBox.Show(frm.Qty.ToString());
                }
            }
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }

        private void btn_DeleteMT_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_Materials.CurrentRow.Cells["cn_bid"].Value); }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {
                string _res = DCBll.DeleteDataCollectionMaterial(_id);
                if (DCBll.SuccessId == -1)
                    FillMaterialsByLaunch(LaunchId);
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Something wrong! " + _res;
                    DialogResult result1 = frm1.ShowDialog();
                }
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void btn_DeleteSN_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _serial = "";
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _serial = gv_List.CurrentRow.Cells["cn_serial"].Value.ToString();
            }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {
                string _res = DCBll.DeleteDataCollectionSerial(_id, _serial);
                if (DCBll.SuccessId == -1)
                    FillList(WorkerId, LaunchId);
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Something wrong! " + _res;
                    DialogResult result1 = frm1.ShowDialog();
                }
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void mni_AdminS_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for serials list";
            frm.grid = this.gv_List;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                Helper.LoadColumns(gv_List, this.Name);
            }
        }

        private void mni_AdminM_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for materials list";
            frm.grid = this.gv_Materials;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                Helper.LoadColumns(gv_Materials, this.Name);
            }
        }
    }
}
