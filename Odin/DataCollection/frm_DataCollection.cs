using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Odin.DataCollection
{
    public partial class frm_DataCollection : BaseForm
    {
        public frm_DataCollection()
        {
            InitializeComponent();
            timer.Interval = 300000;//для 10 минут значение меньше 600000
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);

            bw_Worker.WorkerReportsProgress = true;
            bw_Worker.WorkerSupportsCancellation = true;
            bw_WrongWorker.WorkerReportsProgress = true;
            bw_WrongWorker.WorkerSupportsCancellation = true;
            bw_Launch.WorkerReportsProgress = true;
            bw_Launch.WorkerSupportsCancellation = true;
            bw_WrongLaunch.WorkerReportsProgress = true;
            bw_WrongLaunch.WorkerSupportsCancellation = true;
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
            get { return _worker; }
            set { _worker = value; }
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
            get { return _launch; }
            set { _launch = value; }
        }

        int _launchid = 0;

        public int LaunchId
        {
            get { return _launchid; }
            set { _launchid = value; }
        }

        int _workid = 0;

        public int WorkId
        {
            get { return _workid; }
            set { _workid = value; }
        }

        #endregion


        #region Methods

        #endregion


        #region Controls
        private void frm_DataCollection_Load(object sender, EventArgs e)
        {
            lbl_Clock.Value = GetWaitInterval().ToString();
        }

        private void frm_DataCollection_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
        }

        public int GetWaitInterval()
        {
            return Convert.ToInt32(global::Odin.Global_Resourses.DCWaitInterval.ToString());
        }

        public void DisableButtons()
        {
            btn_Pause.Enabled = false;
            btn_Finish.Enabled = false;
            btn_Resume.Enabled = false;
        }
        #endregion

        
        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            string _tempstr = "";
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                _tempstr = txt_Oper.Text.Trim();
                SetFocus();

                //if (StateId == 1 )
                if (bw_WrongWorker.IsBusy)
                    bw_WrongWorker.CancelAsync();
                if (bw_Launch.IsBusy)
                    bw_Launch.CancelAsync();
                if (bw_WrongLaunch.IsBusy)
                    bw_WrongLaunch.CancelAsync();

                if (bw_Worker.IsBusy)
                {
                    if (StateId == 0)
                    {
                        bw_Worker.CancelAsync();
                        //Trying to read launch and state
                        if (StateId == 0)//Available
                        {
                            SqlConnection sqlConn = new SqlConnection(sConnStr);
                            sqlConn.Open();
                            DataSet ds1 = new DataSet();

                            SqlDataAdapter adapter1 =
                                new SqlDataAdapter(
                                    "select id, name from prod_launchhead where name = '" + _tempstr + "'", sqlConn);

                            adapter1.Fill(ds1);

                            DataTable dt1 = ds1.Tables[0];

                            if (dt1.Rows.Count > 0)
                            {
                                foreach (DataRow dr1 in dt1.Rows)
                                {
                                    LaunchId = Convert.ToInt32(dr1["id"].ToString());
                                    Launch = dr1["name"].ToString();
                                }
                                DCBll.AddDataCollection(WorkerId, LaunchId);
                                LaunchStarted(Launch);
                                if (!bw_Launch.IsBusy)
                                    bw_Launch.RunWorkerAsync(null);
                            }
                            else
                            {
                                CancelBg(bw_Launch);
                                WrongLaunch();
                                if (!bw_WrongLaunch.IsBusy)
                                    bw_WrongLaunch.RunWorkerAsync(null);
                            }
                        }
                       
                    }
                }
                else
                {
                    
                    //Trying to read worker
                    SqlConnection sqlConn = new SqlConnection(sConnStr);
                    sqlConn.Open();
                    DataSet ds1 = new DataSet();

                        SqlDataAdapter adapter1 =
                            new SqlDataAdapter(
                                "execute sp_SelectWorker @rfid = '" + _tempstr + "'", sqlConn);

                        adapter1.Fill(ds1);

                        DataTable dt1 = ds1.Tables[0];

                    if (dt1.Rows.Count > 0)
                    {
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            WorkerId = Convert.ToInt32(dr1["id"].ToString());
                            StateId = Convert.ToInt32(dr1["stateid"].ToString());
                            WorkId = Convert.ToInt32(dr1["workid"].ToString());
                            Launch = dr1["launch"].ToString();
                        }

                        HelloWorker(StateId);
                        if (!bw_Worker.IsBusy)
                            bw_Worker.RunWorkerAsync(null);
                    }
                    else
                    {

                        Worker = "";
                        WorkerId = 0;
                        StateId = -99;
                        WorkId = 0;
                        Launch = "";
                        CancelBg(bw_WrongWorker);

                        WrongWorker();
                        if (!bw_WrongWorker.IsBusy)
                            bw_WrongWorker.RunWorkerAsync(null);
                    }

                }
                               
            }
        }

        private void txt_Oper_Leave(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DataCollection_Activated(object sender, EventArgs e)
        {
            lbl_Batch.Visible = false;
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void bw_Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var WaitInterval = GetWaitInterval();

            var bwAsync = sender as BackgroundWorker;
            int totalSteps = WaitInterval * 10;

            for (int i = totalSteps; i > 1; i--)
            {
                Thread.Sleep(100);
                bwAsync.ReportProgress(Convert.ToInt32(i * (Convert.ToDouble(WaitInterval) / totalSteps)));

                if (bwAsync.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }

            bwAsync.ReportProgress(WaitInterval);
        }

        private void bw_Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_Clock.ColorLight = e.ProgressPercentage <= 3 ? Color.Red : Color.Green;
            lbl_Clock.ThreadSafeCall(delegate { lbl_Clock.Value = e.ProgressPercentage.ToString(); });
        }

        private void bw_Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                HelloMessage();
                DisableButtons();
            }

        }
        //Wrong worker
        private void bw_WrongWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var WaitInterval = 3;

            var bwAsync = sender as BackgroundWorker;
            int totalSteps = WaitInterval * 10;

            for (int i = totalSteps; i > 1; i--)
            {
                Thread.Sleep(100);
                bwAsync.ReportProgress(Convert.ToInt32(i * (Convert.ToDouble(WaitInterval) / totalSteps)));

                if (bwAsync.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }

            bwAsync.ReportProgress(WaitInterval);
        }

        private void bw_WrongWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_Clock.ColorLight = e.ProgressPercentage <= 3 ? Color.Red : Color.Green;
            lbl_Clock.ThreadSafeCall(delegate { lbl_Clock.Value = e.ProgressPercentage.ToString(); });
        }

        private void bw_WrongWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                HelloMessage();
            }
            lbl_Clock.ColorLight = Color.Green;
            lbl_Clock.ThreadSafeCall(delegate { lbl_Clock.Value = GetWaitInterval().ToString(); });
        }

        //Launch
        private void bw_Launch_DoWork(object sender, DoWorkEventArgs e)
        {
            var WaitInterval = 3;

            var bwAsync = sender as BackgroundWorker;
            int totalSteps = WaitInterval * 10;

            for (int i = totalSteps; i > 1; i--)
            {
                Thread.Sleep(100);
                bwAsync.ReportProgress(Convert.ToInt32(i * (Convert.ToDouble(WaitInterval) / totalSteps)));

                if (bwAsync.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }

            bwAsync.ReportProgress(WaitInterval);
        }

        private void bw_Launch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_Clock.ColorLight = e.ProgressPercentage <= 3 ? Color.Red : Color.Green;
            lbl_Clock.ThreadSafeCall(delegate { lbl_Clock.Value = e.ProgressPercentage.ToString(); });
        }

        private void bw_Launch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                HelloMessage();

            }
            lbl_Clock.ColorLight = Color.Green;
            lbl_Clock.ThreadSafeCall(delegate { lbl_Clock.Value = GetWaitInterval().ToString(); });
        }

        public void SetFocus()
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }
        public void HelloMessage()
        {
            lbl_Worker.ThreadSafeCall(delegate 
            {
                lbl_Worker.Text = ScanDataReceived.HelloMessageTitle;
            }
            );
            lbl_Batch.ThreadSafeCall(delegate
            {
                lbl_Batch.Visible = false;
            });
        }

        public void HelloWorker(int StateId)
        {
            lbl_Worker.ThreadSafeCall(delegate
            {
                lbl_Worker.Text = ScanDataReceived.helloWorker + Worker;
            }
            );
            lbl_Batch.ThreadSafeCall(delegate
            {
                lbl_Batch.Text = StateId == 0
                    ? ScanDataReceived.scanLaunchLabel
                    : StateId == 1 ? ScanDataReceived.finishLaunch + Launch + ScanDataReceived.finishLaunch1 : ScanDataReceived.lunchBreak;
                lbl_Batch.Visible = true;
            }
            );
            btn_Resume.ThreadSafeCall(delegate {
                switch (StateId)
                {
                    case 0:
                        btn_Resume.Enabled = false;
                        break;
                    case 1: btn_Resume.Enabled = false;
                        break;
                    default: btn_Resume.Enabled = true;
                        break;
                }
            });
            btn_Pause.ThreadSafeCall(delegate {
                switch (StateId)
                {
                    case 0:
                        btn_Pause.Enabled = false;
                        break;
                    case 1:
                        btn_Pause.Enabled = true;
                        break;
                    default:
                        btn_Pause.Enabled = false;
                        break;
                }
            });
            btn_Finish.ThreadSafeCall(delegate {
                switch (StateId)
                {
                    case 0:
                        btn_Finish.Enabled = false;
                        break;
                    case 1:
                        btn_Finish.Enabled = true;
                        break;
                    default:
                        btn_Finish.Enabled = false;
                        break;
                }
            });
            
        }
        public void WrongWorker()
        {

            lbl_Worker.Invoke(new MethodInvoker (delegate
            {
                lbl_Worker.Text = ScanDataReceived.wrongWorker;
            }
            ));          
            

            lbl_Batch.ThreadSafeCall(delegate
            {
                lbl_Batch.Visible = false;
            }
            );
            DisableButtons();
        }

        public void LaunchStarted(string _launch)
        {

            lbl_Worker.Invoke(new MethodInvoker(delegate
            {
                lbl_Worker.Text = ScanDataReceived.helloWorker + Worker;
            }
            ));


            lbl_Batch.ThreadSafeCall(delegate
            {
                lbl_Batch.Text = ScanDataReceived.LaunchStarted + _launch;
                lbl_Batch.Visible = true;
            }
            );
            //WorkId = 0;
            DisableButtons();
        }

        public void LaunchBreaked()
        {

            lbl_Worker.Invoke(new MethodInvoker(delegate
            {
                lbl_Worker.Text = ScanDataReceived.helloWorker + Worker;
            }
            ));


            lbl_Batch.ThreadSafeCall(delegate
            {
                lbl_Batch.Text = ScanDataReceived.lunchBreakGO;
                lbl_Batch.Visible = true;
            }
            );
            //WorkId = 0;
            DisableButtons();
        }

        public void LaunchResumed()
        {

            lbl_Worker.Invoke(new MethodInvoker(delegate
            {
                lbl_Worker.Text = ScanDataReceived.helloWorker + Worker;
            }
            ));


            lbl_Batch.ThreadSafeCall(delegate
            {
                lbl_Batch.Text = ScanDataReceived.lunchBreakResumed + Launch;
                lbl_Batch.Visible = true;
            }
            );
            //WorkId = 0;
            DisableButtons();
        }

        public void WrongLaunch()
        {

            lbl_Worker.Invoke(new MethodInvoker(delegate
            {
                lbl_Worker.Text = ScanDataReceived.helloWorker + Worker;
                
            }
            ));


            lbl_Batch.ThreadSafeCall(delegate
            {
                lbl_Batch.Text = ScanDataReceived.wrongLaunch;

                lbl_Batch.Visible = true;
            }
            );
            DisableButtons();
        }

        private void bw_WrongLaunch_DoWork(object sender, DoWorkEventArgs e)
        {
            var WaitInterval = 3;

            var bwAsync = sender as BackgroundWorker;
            int totalSteps = WaitInterval * 10;

            for (int i = totalSteps; i > 1; i--)
            {
                Thread.Sleep(100);
                bwAsync.ReportProgress(Convert.ToInt32(i * (Convert.ToDouble(WaitInterval) / totalSteps)));

                if (bwAsync.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }

            bwAsync.ReportProgress(WaitInterval);
        }

        private void bw_WrongLaunch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_Clock.ColorLight = e.ProgressPercentage <= 3 ? Color.Red : Color.Green;
            lbl_Clock.ThreadSafeCall(delegate { lbl_Clock.Value = e.ProgressPercentage.ToString(); });
        }

        private void bw_WrongLaunch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                HelloMessage();

            }
            lbl_Clock.ColorLight = Color.Green;
            lbl_Clock.ThreadSafeCall(delegate { lbl_Clock.Value = GetWaitInterval().ToString(); });
        }

        public void StopBW()
        {
            bw_Worker.CancelAsync();
            bw_Launch.CancelAsync();
            //bwBatchBegin.CancelAsync();
            //bwBatchEnd.CancelAsync();
        }
        public static void CancelBg(BackgroundWorker bg)
        {
            if (bg.IsBusy)
            {
                bg.CancelAsync();
            }
        }

        private void frm_DataCollection_Paint(object sender, PaintEventArgs e)
        {
            int xstart = (panelmain.Width - 597) / 2;
            int ystart = (panelmain.Height - 77) / 2;

            this.btn_Pause.Location = new System.Drawing.Point(xstart, ystart);
            this.btn_Resume.Location = new System.Drawing.Point(xstart + 201, ystart);
            this.btn_Finish.Location = new System.Drawing.Point(xstart + 402, ystart);
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            DCBll.AddDataCollectionPause(WorkId);
            LaunchBreaked();
            if (!bw_Launch.IsBusy)
                bw_Launch.RunWorkerAsync(null);
            CancelBg(bw_Worker);
        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {
            DCBll.AddDataCollectionResume(WorkId);
            LaunchResumed();
            if (!bw_Launch.IsBusy)
                bw_Launch.RunWorkerAsync(null);
            CancelBg(bw_Worker);
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {

        }

        
    }
}
