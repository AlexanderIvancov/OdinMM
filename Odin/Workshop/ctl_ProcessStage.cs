using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public delegate void BatchStageSavingEventHandler(object sender);
    public partial class ctl_ProcessStage : UserControl
    {
        public ctl_ProcessStage()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        Processing_BLL PBLL = new Processing_BLL();
        public event BatchStageSavingEventHandler BatchStageSaving;

        public double PrevQty
        {
            get;set;
        }

        public double PrevFreezedQty
        {
            get; set;
        }

        public double InProcQty
        { get; set; }

        public double FreezedQty
        { get; set; }

        public double tFreezedQty
        {
            get
            {
                try { return Convert.ToDouble(txt_Freezed.Text); }
                catch { return 0; }
            }
            set { txt_Freezed.Text = value.ToString(); }
        }

        public double tPrevQty
        {
            get { try { return Convert.ToDouble(txt_Prev.Text); }
                catch { return 0; } }
            set { txt_Prev.Text = value.ToString(); }
        }

        public double tInProcQty
        {
            get
            {
                try { return Convert.ToDouble(txt_InProc.Text); }
                catch { return 0; }
            }
            set { txt_InProc.Text = value.ToString(); }
        }

        public string Stage
        {
            get { return lbl_Stage.Text; }
            set { lbl_Stage.Text = value;
                
            }
        }

        public int StageId
        { get; set; }

        public int PrevStageId
        { get; set; }


        public int BatchId
        { get; set; }

        public int Id
        { get; set; }

        public string PrevStage
        { get; set; }

        #endregion

        #region Methods

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

                Stage = reader["name"].ToString();
                PrevStage = reader["prevname"].ToString();
                PrevStageId = Convert.ToInt32(reader["previd"]);
                InProcQty = Convert.ToDouble(reader["qtyonstage"]) - Convert.ToDouble(reader["freezedqty"]);
                tInProcQty = Convert.ToDouble(reader["qtyonstage"]) - Convert.ToDouble(reader["freezedqty"]);
                PrevQty = Convert.ToDouble(reader["prevqty"]) - Convert.ToDouble(reader["prevfreezedqty"]); 
                tPrevQty = Convert.ToDouble(reader["prevqty"]) - Convert.ToDouble(reader["prevfreezedqty"]); 
                Id = Convert.ToInt32(reader["id"]);
                PrevFreezedQty = Convert.ToDouble(reader["prevfreezedqty"]);
                tFreezedQty = Convert.ToDouble(reader["freezedqty"]);
                FreezedQty = Convert.ToDouble(reader["freezedqty"]);

                reader.Close();
            }
            else
                ClearFields();
            sqlConn.Close();
        }
        
        public void ClearFields()
        {
            Stage = "";
            PrevStage = "";
            PrevStageId = 0;
            InProcQty = 0;
            tInProcQty = 0;
            PrevQty = 0;
            tPrevQty = 0;
            Id = 0;
            PrevFreezedQty = 0;
            tFreezedQty = 0;
            FreezedQty = 0;
        }

        #endregion

        #region Controls

        private void txt_Prev_Validated(object sender, EventArgs e)
        {
            if (tPrevQty > PrevQty)
            {
                MessageBox.Show("You can't move qty more than on prevous stage!");
                tPrevQty = PrevQty;
            }
            if (tPrevQty <= 0)
                tPrevQty = PrevQty;
        }

        private void txt_InProc_Validated(object sender, EventArgs e)
        {
            if (tInProcQty > InProcQty)
            {
                MessageBox.Show("You can't delete qty more than on stage!");
                tInProcQty = InProcQty;
            }
            if (tInProcQty <= 0)
                tInProcQty = 0;

        }

        private void btn_AddProcess_Click(object sender, EventArgs e)
        {
            PBLL.AddStageProcess(BatchId, StageId, PrevStageId, tPrevQty, 1);
            if (BatchStageSaving != null)
                BatchStageSaving(this);
        }

        private void btn_DeleteProcess_Click(object sender, EventArgs e)
        {
            DialogResult result1 = KryptonTaskDialog.Show("Deletion of progress warning!",
                                                                    "Are you want to remove progress of batch?",
                                                                    "If you delete progress, it will automatically move on previous stage.",
                                                                    MessageBoxIcon.Warning,
                                                                    TaskDialogButtons.Yes |
                                                                    TaskDialogButtons.No);
            if (result1 == DialogResult.Yes
                && InProcQty != tInProcQty)
            {
                PBLL.AddStageProcess(BatchId, PrevStageId, StageId, InProcQty - tInProcQty, 1);
            }
            if (BatchStageSaving != null)
                BatchStageSaving(this);
        }
        
        private void btn_Freeze_Click(object sender, EventArgs e)
        {
            PBLL.FreezeStageProcess(BatchId, StageId, tFreezedQty);
            if (BatchStageSaving != null)
                BatchStageSaving(this);
        }
        
        #endregion

    }
}
