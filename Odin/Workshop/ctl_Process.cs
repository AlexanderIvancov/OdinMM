using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Odin.Workshop
{
    public delegate void StageUpdatingEventHandler(object sender);

    public partial class ctl_Process : UserControl
    {
        public ctl_Process()
        {
            InitializeComponent();
        }

        #region Variables

        public event StageUpdatingEventHandler StageUpdating;
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
            get {
                if (rb_Valkas2.Checked == true)
                    return 1;
                else if (rb_Valkas2B.Checked == true)
                    return 2;
                else
                    return 0;
            }
            set {
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

        public ctl_ProcessStageV2 ctlProc = null;

        public int ControlWidth = 170;

        #endregion

        #region Methods

        public void FillProcesses(int _batchid)
        {
            //Clear old controls
            RemoveControls(this, typeof(ctl_ProcessStageV2));

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
                    ctlProc = new ctl_ProcessStageV2();

                    ctlProc.BatchId = _batchid;
                    ctlProc.ProdPlace = ProdPlace;
                    ctlProc.StageId = Convert.ToInt32(reader["id"]);
                    ctlProc.QtyInBatch = cmb_Batches1.Qty;
                    ctlProc.FillData(ctlProc.BatchId, ctlProc.StageId);
                    ctlProc.BatchStageSaving += new BatchStage2SavingEventHandler(AddProcess);
                    ctlProc.BatchStageSending += new BatchStage2SendingEventHandler(RefreshProcesses);

                    ctlProc.Location = new Point(_h, 55);
                    _h = _h + ctlProc.Width + _interval;
                    
                    this.Controls.Add(ctlProc);
                }
                reader.Close();
            }
                
            sqlConn.Close();
            
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

        private void AddProcess(object sender)
        {
            FillProcesses(BatchId);
            ProdPlace = 0;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(ctl_ProcessStageV2))
                {
                    ctl_ProcessStageV2 ctl = control as ctl_ProcessStageV2;
                    ctl.ProdPlace = ProdPlace;
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
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(ctl_ProcessStageV2))
                {
                    ctl_ProcessStageV2 ctl = control as ctl_ProcessStageV2;
                    ctl.ProdPlace = ProdPlace;//rb_Valkas2.Checked == true ? 1 : 2;
                }
               
            }
        }

        private void rb_Valkas2B_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control.GetType() == typeof(ctl_ProcessStageV2))
                {
                    ctl_ProcessStageV2 ctl = control as ctl_ProcessStageV2;
                    ctl.ProdPlace = ProdPlace;// rb_Valkas2.Checked == true ? 1 : 2;
                }
            }
        }

        #endregion

    }
}
