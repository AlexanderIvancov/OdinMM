using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public delegate void Launch2SavingEventHandler(object sender, int ScrollPosition, int StageId);
    public delegate void Launch2SendingEventHandler(object sender);

    public partial class ctl_ProcessStageLaunch : UserControl
    {
        public ctl_ProcessStageLaunch()
        {
            InitializeComponent();
        }


        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public event Launch2SavingEventHandler LaunchStageSaving;
        public event Launch2SendingEventHandler LaunchStageSending;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();

        int _id = 0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int BatchId
        { get; set; }

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

        public int ProdPlace
        { get; set; }

        public int PrevStageId
        { get; set; }

        public int NextStageId
        { get; set; }
        
        public string PrevStage
        { get; set; }

        public int AllowMoveBack
        { get; set; }

        public int IsNextStageLast
        { get; set; }

        public void FillList(int _BatchId, int _StageId)
        {
            var data = (DataTable)Helper.getSP("sp_SelectBatchLaunchesProcessing", _BatchId, _StageId);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
                try
                {
                    //RecalcTotals();
                    //RecalcUnitPrice(SellCoef);
                }
                catch { }
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_finished"].Value) == Convert.ToDouble(row.Cells["cn_started"].Value)
                    && Convert.ToDouble(row.Cells["cn_inlaunch"].Value) == Convert.ToDouble(row.Cells["cn_started"].Value)
                    && Convert.ToDouble(row.Cells["cn_started"].Value) > 0)
                    row.DefaultCellStyle.BackColor = Color.Gainsboro;
            }
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

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.stopwatch_start16x16.Width;
                var h = Global_Resourses.stopwatch_start16x16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.stopwatch_start16x16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            double _tofinish = 0;
            int _res = 0;
            bool _test = true;
            gv_List.EndEdit();
            if (DAL.CheckArticleWandI(BatchId) == -1 && NextStageId == 10)
            {
                glob_Class.ShowMessage("Launch processing error!", "Check article Weight or Image!", "You can't move launch because of article Weight or Image are not valid!");
                return;
            }
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _tofinish = _tofinish + Convert.ToDouble(row.Cells["cn_tofinish"].Value);
            }

            //MessageBox.Show(IsNextStageLast.ToString() + ProdPlace.ToString() + _tofinish.ToString());
            //if (IsNextStageLast != -1
            //&& ProdPlace == 0
            //&& _tofinish > 0)
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

            if (_test == true)
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (Convert.ToDouble(row.Cells["cn_tostart"].Value) != 0
                        || Convert.ToDouble(row.Cells["cn_tofinish"].Value) != 0
                        || Convert.ToDouble(row.Cells["cn_freezed"].Value) != Convert.ToDouble(row.Cells["cn_oldfreezed"].Value))
                    //if (Convert.ToDouble(row.Cells["cn_started"].Value) != Convert.ToDouble(row.Cells["cn_oldstarted"].Value)
                    //|| Convert.ToDouble(row.Cells["cn_finished"].Value) != Convert.ToDouble(row.Cells["cn_oldfinished"].Value)
                    //|| Convert.ToDouble(row.Cells["cn_freezed"].Value) != Convert.ToDouble(row.Cells["cn_oldfreezed"].Value))
                    {
                        _res = Convert.ToInt32(Helper.getSP("sp_SaveLaunchStageProcess", Convert.ToInt32(row.Cells["cn_id"].Value),
                                PrevStageId, StageId, NextStageId,
                                Convert.ToDouble(row.Cells["cn_tostart"].Value),
                                Convert.ToDouble(row.Cells["cn_tofinish"].Value),
                                Convert.ToDouble(row.Cells["cn_freezed"].Value), IsNextStageLast == -1 ? 0 : ProdPlace));

                    }
                }
                if (_res == 0)
                    glob_Class.ShowMessage("Launch processing error!", "Check batch and permissions and state of launch!", "You can't move launch because of permissions or batch movement existance or launch is not started!");
                else
                {
                    FillList(BatchId, StageId);
                    LaunchStageSaving?.Invoke(this, gv_List.HorizontalScrollingOffset, StageId);
                    LaunchStageSending?.Invoke(this);
                }
            }
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double _prevsum = 0;
            double _sumtostart = 0;
            double _sumstarted = 0;
            double _inlaunch = 0;
            double _tpmstart = 0;
            double _tmpstarted = 0;
            double _freezed = 0;
            
            gv_List.EndEdit();

            if (gv_List.CurrentRow.Cells["cn_tostart"].Selected == true)
            {
                if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_prevstageid"].Value) == -99)
                {
                    //Check started
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value) + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tostart"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_inlaunch"].Value))
                        gv_List.CurrentRow.Cells["cn_tostart"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_inlaunch"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value);
                }
                else
                {
                    _prevsum = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_prevsum"].Value);
                    _inlaunch = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_inlaunch"].Value);
                    _tpmstart = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tostart"].Value);
                    _tmpstarted = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value);
                    

                    gv_List.CurrentRow.Cells["cn_tostart"].Value = _tpmstart + _tmpstarted > _inlaunch ? _inlaunch - _tmpstarted : _tpmstart;
                    _tpmstart = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tostart"].Value);

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        _sumtostart = _sumtostart + Convert.ToDouble(row.Cells["cn_tostart"].Value);
                        _sumstarted = _sumstarted + Convert.ToDouble(row.Cells["cn_started"].Value);
                    }

                   

                    if (_sumstarted + _sumtostart > _prevsum)
                        gv_List.CurrentRow.Cells["cn_tostart"].Value = (_prevsum - _sumstarted - _sumtostart + _tpmstart) > _inlaunch - _tmpstarted ?
                                                                        _inlaunch - _tmpstarted :
                                                                        (_prevsum - _sumstarted - _sumtostart + _tpmstart) ;

                }
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tostart"].Value) < 0)
                    gv_List.CurrentRow.Cells["cn_tostart"].Value = 0;

            }
            if (gv_List.CurrentRow.Cells["cn_tofinish"].Selected == true)
            {
                _freezed = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_freezed"].Value);

                //Check started
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_finished"].Value) + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tofinish"].Value) + _freezed > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value))
                    gv_List.CurrentRow.Cells["cn_tofinish"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_finished"].Value) - _freezed;
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tofinish"].Value) < 0)
                    gv_List.CurrentRow.Cells["cn_tofinish"].Value = 0;

            }

            if (gv_List.CurrentRow.Cells["cn_freezed"].Selected == true)
            {
                _freezed = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_freezed"].Value);
                //Check started
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_finished"].Value) + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tofinish"].Value) + _freezed > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value))
                   gv_List.CurrentRow.Cells["cn_freezed"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_finished"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tofinish"].Value);
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_freezed"].Value) < 0)
                    gv_List.CurrentRow.Cells["cn_freezed"].Value = 0;

            }

        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for processing list";
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

        private void ctl_ProcessStageLaunch_Load(object sender, EventArgs e)
        {
            Helper.LoadColumns(gv_List, this.Name);
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            double _prevsum = 0;
            double _sumtostart = 0;
            double _sumstarted = 0;
            double _inlaunch = 0;
            double _tmpstarted = 0;
            double _freezed = 0;

            //try
            //{
                if (gv_List.CurrentRow.Cells["btn_add"].Selected == true)
                {
                    if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_prevstageid"].Value) == -99)
                    {
                        gv_List.CurrentRow.Cells["cn_tostart"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_inlaunch"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value);
                    }
                    else
                    {
                        _prevsum = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_prevsum"].Value);
                        _inlaunch = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_inlaunch"].Value);
                        _tmpstarted = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_started"].Value);
                        _freezed = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_freezed"].Value);
                        foreach (DataGridViewRow row in this.gv_List.Rows)
                        {
                            _sumtostart = _sumtostart + Convert.ToDouble(row.Cells["cn_tostart"].Value);
                            _sumstarted = _sumstarted + Convert.ToDouble(row.Cells["cn_started"].Value);
                        }
                        gv_List.CurrentRow.Cells["cn_tostart"].Value = (_prevsum - _sumstarted - _sumtostart) > _inlaunch - _tmpstarted ?
                                                                       _inlaunch - _tmpstarted :
                                                                       (_prevsum - _sumstarted - _sumtostart);

                    }
                    
                }


            //}
            //catch { }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
