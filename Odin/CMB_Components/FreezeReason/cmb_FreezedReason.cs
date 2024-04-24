using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.FreezedReason
{
    public delegate void FreezedReasonEventHandler(object sender);

    public partial class cmb_FreezedReason : UserControl
    {
        public cmb_FreezedReason()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        public event FreezedReasonEventHandler FreezedReasonChanged;

        #region Variables

        int _BatchId = 0;
        public int BatchId
        {
            get { return _BatchId; }
            set { _BatchId = value; }
        }

        public int _FreezedReasonId = 0;
        public string _FreezedReason = "";

        public int PrevId = 0;

        public string FreezedReason
        {
            get { return txt_FreezedReason.Text; }
            set
            {
                _FreezedReason = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    //new SqlDataAdapter("SELECT top 1 code, description FROM TMP_FreezedReason WHERE description = '" + _FreezedReason + "'", conn);
                    new SqlDataAdapter("SELECT top 1 code, description FROM TMP_FreezedReason WHERE description = '" + _FreezedReason + "' and lang = '" + new DAL_Functions().UserLang + "'", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                        FreezedReasonId = Convert.ToInt32(dr["code"]);
                else
                {
                    _FreezedReasonId = 0;

                    if (PrevId != FreezedReasonId)
                    {
                        FreezedReasonChanged?.Invoke(this);
                        PrevId = FreezedReasonId;
                    }
                }
            }
        }

        public int FreezedReasonId
        {
            get { return _FreezedReasonId; }
            set
            {
                _FreezedReasonId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    //new SqlDataAdapter("set dateformat dmy SELECT top 1 code, description FROM TMP_FreezedReason WHERE code = " + _FreezedReasonId.ToString(), conn);
                    new SqlDataAdapter("set dateformat dmy SELECT top 1 code, description FROM TMP_FreezedReason WHERE code = " + _FreezedReasonId.ToString() + " and lang = '" + new DAL_Functions().UserLang + "'", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_FreezedReason.Text = dr["description"].ToString();
                        _FreezedReason = dr["description"].ToString();
                    }

                    if (PrevId != FreezedReasonId)
                    {
                        FreezedReasonChanged?.Invoke(this);
                        PrevId = FreezedReasonId;
                    }
                    //if (BatchChanged != null)
                    //{
                    //    BatchChanged(this);
                    //}
                }
                else
                {
                    txt_FreezedReason.Text = "";
                    _FreezedReason = "";
                }
            }
        }

        private void ShowFreezedReasonFilter()
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_FreezedReason popup = new frm_FreezedReason();
            popup.cmb_FreezedReason = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                    _e.Cancel = true;
            };

            popup.FillData();
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            _FreezedReason = string.Empty;
            txt_FreezedReason.Text = string.Empty;
        }

        private void txt_FreezedReason_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FreezedReason = _FreezedReason = txt_FreezedReason.Text;
            }
            catch
            {
                //return;
            }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            ShowFreezedReasonFilter();
        }
    }
}