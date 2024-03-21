using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public delegate void BatchStage2SavingEventHandler(object sender);
    public delegate void BatchStage2SendingEventHandler(object sender);

    public partial class ctl_ProcessStageV2 : UserControl
    {
        public ctl_ProcessStageV2()
        {
            InitializeComponent();
        }

        #region Variables
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public event BatchStage2SavingEventHandler BatchStageSaving;
        public event BatchStage2SendingEventHandler BatchStageSending;
        class_Global glob_Class = new class_Global();

        public double QtyOnStage
        {
            get; set;
        }

        public double PrevFreezedQty
        {
            get; set;
        }

        public double ProcQty
        { get; set; }
        public double PrevQty
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


        public double tRetQty
        {
            get
            {
                try { return Convert.ToDouble(txt_Ret.Text); }
                catch { return 0; }
            }
            set { txt_Ret.Text = value.ToString(); }
        }

        public double tProcQty
        {
            get
            {
                try { return Convert.ToDouble(txt_Proc.Text); }
                catch { return 0; }
            }
            set { txt_Proc.Text = value.ToString(); }
        }

        public double tQtyOnStage
        {
            get
            {
                try { return Convert.ToDouble(txt_OnStage.Text); }
                catch { return 0; }
            }
            set { txt_OnStage.Text = value.ToString(); }
        }

        public string Stage
        {
            get { return lbl_Stage.Text; }
            set
            {
                lbl_Stage.Text = value;

            }
        }

        public int StageId
        { get; set; }

        public int PrevStageId
        { get; set; }

        public int NextStageId
        { get; set; }

        public int BatchId
        { get; set; }

        public int Id
        { get; set; }

        public string PrevStage
        { get; set; }

        public int AllowMoveBack
        { get; set; }

        public int IsNextStageLast
        { get; set; }

        public int ProdPlace
        { get; set; }

        public double QtyInBatch
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyInBatch.Text); }
                catch { return 0; }
            }
            set { txt_QtyInBatch.Text = value.ToString(); }
        }

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
                NextStageId = Convert.ToInt32(reader["nextid"]);

                QtyOnStage = Convert.ToDouble(reader["qtyonstage"]) - Convert.ToDouble(reader["freezedqty"]);
                tQtyOnStage = Convert.ToDouble(reader["qtyonstage"]) - Convert.ToDouble(reader["freezedqty"]);

                tProcQty = 0;// Convert.ToDouble(reader["qtyonstage"]) - Convert.ToDouble(reader["freezedqty"]);
                tRetQty = 0;

                PrevQty = Convert.ToDouble(reader["prevqty"]) - Convert.ToDouble(reader["prevfreezedqty"]);

                Id = Convert.ToInt32(reader["id"]);
                PrevFreezedQty = Convert.ToDouble(reader["prevfreezedqty"]);
                tFreezedQty = Convert.ToDouble(reader["freezedqty"]);
                FreezedQty = Convert.ToDouble(reader["freezedqty"]);
                AllowMoveBack = Convert.ToInt32(reader["allowmoveback"]);
                IsNextStageLast = Convert.ToInt32(reader["isnextstagelast"]);

                reader.Close();
            }
            else
                ClearFields();
            sqlConn.Close();

            CheckPrevStage();
        }
        public void CheckPrevStage()
        {
            if (PrevStageId == 0)
            {
                btn_Start.Visible = true;
                btn_Delete.Visible = true;
                if (PrevQty > 0)
                {
                    lbl_Stage.StateNormal.ShortText.Color1 = Color.Red;
                    lbl_Stage.StateNormal.ShortText.Color2 = Color.Red;
                }
            }
            else
            {
                btn_Start.Visible = false;
                btn_Delete.Visible = false;
            }
            if (AllowMoveBack == 0)
            {
                btn_DeleteProcess.Enabled = false;
                lbl_Stage.StateNormal.ShortText.Color1 = Color.Silver;
                lbl_Stage.StateNormal.ShortText.Color2 = Color.Silver;
                MakeButtonsVisible(false);
            }
            else
            {
                btn_DeleteProcess.Enabled = true;
                MakeButtonsVisible(true);
            }
        }

        public void MakeButtonsVisible(bool _isvisible)
        {
            if (_isvisible == true)
            {
                txt_Ret.Visible = true;
                txt_Proc.Visible = true;
                btn_AddProcess.Visible = true;
                
                //btn_DeleteProcess.Visible = true;
                txt_Freezed.Visible = true;
                btn_Freeze.Visible = true;
                lbl_Freezed.Visible = true;
            }
            else
            {
                txt_Ret.Visible = false;
                txt_Proc.Visible = false;
                btn_AddProcess.Visible = false;
                btn_DeleteProcess.Visible = false;
                btn_Start.Visible = false;
                btn_Delete.Visible = false;
                if (StageId == 8)
                {
                    txt_Freezed.Visible = false;
                    lbl_Freezed.Visible = false;
                    txt_QtyInBatch.Visible = true;
                    lbl_QtyInBatch.Visible = true;
                }
                else
                {
                    txt_Freezed.Visible = true;
                    lbl_Freezed.Visible = true;
                    txt_QtyInBatch.Visible = false;
                    lbl_QtyInBatch.Visible = false;
                }
                btn_Freeze.Visible = false;
                //
            }
        }

        public void ClearFields()
        {
            Stage = "";
            PrevStage = "";
            PrevStageId = 0;
            ProcQty = 0;
            tProcQty = 0;
            PrevQty = 0;
            
            Id = 0;
            PrevFreezedQty = 0;
            tFreezedQty = 0;
            FreezedQty = 0;
            QtyOnStage = 0;
            AllowMoveBack = -1;
            IsNextStageLast = 0;
        }

        #endregion

        #region Controls

        private void btn_AddProcess_Click(object sender, EventArgs e)
        {
            if (NextStageId != 0
                && tProcQty != 0)
            {
                bool _test = true;
                if (IsNextStageLast != -1)
                {
                    DialogResult result = KryptonTaskDialog.Show("Next stage warning!",
                                "You will not allow to move back from next stage!",
                                "Are you sure you want to move batch on this stage?",
                                MessageBoxIcon.Warning,
                                TaskDialogButtons.Yes | TaskDialogButtons.No);
                    if (result == DialogResult.Yes)
                    {
                        //MessageBox.Show(ProdPlace.ToString());
                        //if (ProdPlace == 0)
                        //{
                        //    DialogResult result1 = KryptonTaskDialog.Show("Product place warning!",
                        //       "Impossible to put on last stage!",
                        //       "You must choose production place!",
                        //       MessageBoxIcon.Stop,
                        //       TaskDialogButtons.OK);
                        //    _test = false;
                        //}
                        //else
                            _test = true;
                    }
                    else
                        _test = false;
                }
                
                if (_test == true)
                {
                    //MessageBox.Show(StageId.ToString());
                    Helper.getSP("sp_AddBatchStageProcess", BatchId, NextStageId, StageId, tProcQty, IsNextStageLast == -1 ? 0 : ProdPlace);
                    BatchStageSaving?.Invoke(this);
                    BatchStageSending?.Invoke(this);
                }
            }
        }

        private void btn_DeleteProcess_Click(object sender, EventArgs e)
        {
            if (tRetQty != 0)
            {
                Helper.getSP("sp_AddBatchStageProcess", BatchId, PrevStageId, StageId, tRetQty, IsNextStageLast == -1 ? 0 : ProdPlace);
                BatchStageSaving?.Invoke(this);
                BatchStageSending?.Invoke(this);
            }
        }

        private void btn_Freeze_Click(object sender, EventArgs e)
        {
            if (tFreezedQty > tQtyOnStage + FreezedQty)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Freezing warning!",
                               "Impossible to freeze!",
                               "You can't freeze more than on stage!",
                               MessageBoxIcon.Stop,
                               TaskDialogButtons.OK);
            }
            else
            {
                Helper.getSP("sp_FreezeBatchStageProcess", BatchId, StageId, tFreezedQty);
                BatchStageSaving?.Invoke(this);
                BatchStageSending?.Invoke(this);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(PrevStageId.ToString());
            Helper.getSP("sp_AddBatchStageProcess", BatchId, StageId, PrevStageId, PrevQty, IsNextStageLast == -1 ? 0 : ProdPlace);
            BatchStageSaving?.Invoke(this);
            BatchStageSending?.Invoke(this);
        }

        private void btn_Wizard_Click(object sender, EventArgs e)
        {
            tProcQty = QtyOnStage;
        }

        private void btn_RetWizard_Click(object sender, EventArgs e)
        {
            tRetQty = QtyOnStage;
        }
        #endregion

        private void txt_Ret_Validated(object sender, EventArgs e)
        {
            if (txt_Ret.Text == ""
                || String.IsNullOrEmpty(txt_Ret.Text) == true)
                txt_Ret.Text = "0";
            if (QtyOnStage < tRetQty)
                tRetQty = QtyOnStage;
        }

        private void txt_Proc_Validated(object sender, EventArgs e)
        {
            if (txt_Proc.Text == ""
               || String.IsNullOrEmpty(txt_Proc.Text) == true)
                txt_Proc.Text = "0";
            if (QtyOnStage < tProcQty)
                tProcQty = QtyOnStage;
        }

        private void txt_Freezed_Validated(object sender, EventArgs e)
        {
            if (tFreezedQty < 0)
                tFreezedQty = 0;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (glob_Class.DeleteConfirm() == true)
            {
                Helper.getSP("sp_DeleteBatchStageProcess", BatchId, StageId);
                BatchStageSaving?.Invoke(this);
                BatchStageSending?.Invoke(this);
            }
        }
    }
}
