using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Odin.Workshop
{
    public delegate void LaunchStageUpdatingEventHandler(object sender);
    public partial class ctl_LaunchProcess : UserControl
    {
        public ctl_LaunchProcess()
        {
            InitializeComponent();
        }


        #region Variables       

        List<ControlScrollbars> scrollbars = new List<ControlScrollbars>();
        public class ControlScrollbars
        {
            public int _StageId;
            public int _ScrollPosition;
        }


        public event LaunchStageUpdatingEventHandler StageUpdating;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        int _batchid = 0;

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set
            {
                _batchid = value;
                FillProcesses(BatchId);
            }
        }

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

        public ctl_ProcessStageLaunch ctlProc = null;

        public int ControlWidth = 330;

        Point ScrollPosition;
        //int ControlScrollPosition = 0;
        //int TmpStageId = 0;

        #endregion

        #region Methods

        public void FillProcesses(int _batchid)
        {
            //ScrollPosition = panel.AutoScrollPosition;
            int _controlscroll = 0;
            RememberScrolls();
            //MessageBox.Show(ScrollPosition.X.ToString());
            //Clear old controls
            RemoveControls(this, typeof(ctl_ProcessStageLaunch));

            //Fill new

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectBatchStagesOnly", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);

            sqlConn.Open();

            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows == true)
            {
                //int _count = reader.RecordsAffected;
                int _h = 8; //Start horizontal
                int _interval = 8;//Interval
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["id"]) != 8) //Not adding FQC
                    {
                        ctlProc = new ctl_ProcessStageLaunch();

                        ctlProc.BatchId = _batchid;
                        ctlProc.ProdPlace = ProdPlace;
                        ctlProc.StageId = Convert.ToInt32(reader["id"]);
                        ctlProc.Stage = reader["name"].ToString();
                        ctlProc.FillList(ctlProc.BatchId, ctlProc.StageId);
                        ctlProc.FillData(ctlProc.BatchId, ctlProc.StageId);
                        ctlProc.LaunchStageSaving += new Launch2SavingEventHandler(AddProcess);
                        ctlProc.LaunchStageSending += new Launch2SendingEventHandler(RefreshProcesses);


                        //ctlProc.Location = new Point(_h, 55);
                        ctlProc.Location = new Point(_h, 8);
                        _h = _h + ctlProc.Width + _interval;
                        //this.Controls.Add(ctlProc);
                        panel.Controls.Add(ctlProc);
                        ctlProc.gv_List.ThreadSafeCall(delegate { ctlProc.SetCellsColor(); });
                        var first = scrollbars.FirstOrDefault(c => c._StageId == ctlProc.StageId);
                        _controlscroll = first != null ? first._ScrollPosition : 0;
                        //if (ctl.StageId == TmpStageId)
                        //ctl.gv_List.ThreadSafeCall(delegate { ctl.gv_List.HorizontalScrollingOffset = ControlScrollPosition; });
                        ctlProc.gv_List.ThreadSafeCall(delegate { ctlProc.gv_List.HorizontalScrollingOffset = _controlscroll; });
                    }
                }
                reader.Close();
            }

            sqlConn.Close();
            panel.AutoScrollPosition = new Point(-1 * ScrollPosition.X, ScrollPosition.Y);
        }

        private void RemoveControls(Control control, Type type)
        {
            List<Control> controls = new List<Control>();
            Stack<Control> stack = new Stack<Control>();
            stack.Push(control);
            while (stack.Count > 0)
                foreach (Control child in stack.Pop().Controls)
                    if (child.GetType() == type)
                        controls.Add(child);
                    else
                        if (true == child.HasChildren)
                        stack.Push(child);

            foreach (Control ctrl in controls)
            {
                control.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }

        private void RememberScrolls()
        {
            scrollbars.Clear();
            foreach (Control control in panel.Controls)
            {
                if (control.GetType() == typeof(ctl_ProcessStageLaunch))
                {
                    ctl_ProcessStageLaunch ctl = control as ctl_ProcessStageLaunch;
                    scrollbars.Add(new ControlScrollbars() { _StageId = ctl.StageId, _ScrollPosition = ctl.gv_List.HorizontalScrollingOffset });
                    //ctl.gv_List.ThreadSafeCall(delegate { ctl.SetCellsColor(); });
                    //if (ctl.StageId == TmpStageId)
                    //    ctl.gv_List.ThreadSafeCall(delegate { ctl.gv_List.HorizontalScrollingOffset = ControlScrollPosition; });
                }

            }
        }
        private void AddProcess(object sender, int _scrollposition, int _stageid)
        {
            RememberScrolls();

            FillProcesses(BatchId);
            ProdPlace = 0;
            foreach (Control control in panel.Controls)
            {
                if (control.GetType() == typeof(ctl_ProcessStageLaunch))
                {
                    ctl_ProcessStageLaunch ctl = control as ctl_ProcessStageLaunch;
                    ctl.ProdPlace = ProdPlace;
                    //ControlScrollPosition = _scrollposition;
                    //TmpStageId = _stageid;
                    //ctl.gv_List.ThreadSafeCall(delegate { ctl.gv_List.HorizontalScrollingOffset = _scrollposition;  });
                }

            }
        }


        private void RefreshProcesses(object sender)
        {
            if (StageUpdating != null)
                StageUpdating(this);
        }

        #endregion

        #region Controls

        private void cmb_Batches1_BatchChanged(object sender)
        {
            BatchId = cmb_Batches1.BatchId;

        }


        private void rb_Valkas2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.GetType() == typeof(ctl_ProcessStageLaunch))
                {
                    ctl_ProcessStageLaunch ctl = control as ctl_ProcessStageLaunch;
                    ctl.ProdPlace = ProdPlace;//rb_Valkas2.Checked == true ? 1 : 2;
                }

            }
        }

        private void rb_Valkas2B_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in panel.Controls)
            {

                if (control.GetType() == typeof(ctl_ProcessStageLaunch))
                {
                    ctl_ProcessStageLaunch ctl = control as ctl_ProcessStageLaunch;
                    ctl.ProdPlace = ProdPlace;// rb_Valkas2.Checked == true ? 1 : 2;
                }
            }
        }

        #endregion

        private void ctl_LaunchProcess_Paint(object sender, PaintEventArgs e)
        {

            int _controlscroll = 0;
            foreach (Control control in panel.Controls)
            {
                if (control.GetType() == typeof(ctl_ProcessStageLaunch))
                {
                    ctl_ProcessStageLaunch ctl = control as ctl_ProcessStageLaunch;
                    ctl.gv_List.ThreadSafeCall(delegate { ctl.SetCellsColor(); });
                    var first = scrollbars.FirstOrDefault(c => c._StageId == ctl.StageId);
                    _controlscroll = first != null ? first._ScrollPosition : 0;
                    //if (ctl.StageId == TmpStageId)
                    //ctl.gv_List.ThreadSafeCall(delegate { ctl.gv_List.HorizontalScrollingOffset = ControlScrollPosition; });
                    ctl.gv_List.ThreadSafeCall(delegate { ctl.gv_List.HorizontalScrollingOffset = _controlscroll; });
                }

            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillProcesses(BatchId);
        }
    }
}
