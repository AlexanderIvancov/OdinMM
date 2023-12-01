using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.BatchStages
{
    public delegate void StageEventHandler(object sender);

    public partial class cmb_BatchStages : UserControl
    {
        public cmb_BatchStages()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();
        
        public event StageEventHandler StageChanged;

        #region Variables

        int _islaunch = 0;
        int _BatchId = 0;
        public int BatchId
        {
            get { return _BatchId; }
            set { _BatchId = value; }
        }

        public int Launches
        {
            get { return _islaunch; }
            set { _islaunch = value; }
        }


        int _StageId = 0;
        string _Stage = "";

        int PrevId = 0;

        public string Stage
        {
            get { return txt_Stage.Text; }
            set
            {
                _Stage = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 id, name FROM BAS_Stages WHERE name = '" + _Stage + "'", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        StageId = Convert.ToInt32(dr["id"]);
                    }
                }
                else
                {
                    _StageId = 0;

                    if (PrevId != StageId)
                    {
                        if (StageChanged != null)
                            StageChanged(this);
                        PrevId = StageId;
                    }
                }
            }
        }

        public int StageId
        {
            get { return _StageId; }
            set
            {
                _StageId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("set dateformat dmy SELECT top 1 id, name FROM BAS_Stages WHERE id = " + _StageId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_Stage.Text = dr["name"].ToString();
                    }


                    if (PrevId != StageId)
                    {
                        if (StageChanged != null)
                            StageChanged(this);
                        PrevId = StageId;
                    }
                    //if (BatchChanged != null)
                    //{
                    //    BatchChanged(this);
                    //}
                }
                else
                {
                    txt_Stage.Text = "";
                }
            }
        }

        private void ShowStageFilter(int BatchId)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_BatchStages popup = new frm_BatchStages();
            popup.cmb_BatchStageOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(BatchId, Launches);
        }

        #endregion



        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Stage.Text = string.Empty;
        }

        private void txt_Stage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Stage = txt_Stage.Text;
            }
            catch
            {
                //return;
            }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            ShowStageFilter(BatchId);
        }
    }
}
