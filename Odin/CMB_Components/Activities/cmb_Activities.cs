using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using System.Data.SqlClient;

namespace Odin.CMB_Components.Activities
{
    public delegate void ActivitiesEventHandler(object sender);

    public partial class cmb_Activities : UserControl
    {
        public event ActivitiesEventHandler ActivitiesChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        ActivityEventArgs args = new ActivityEventArgs();
        int _ActivityId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Activity = "";

        public cmb_Activities()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string Activity
        {
            get { return txt_Activity.Text; }
            set
            {

                _Activity = value;
                txt_Activity.Text = value;

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Activities WHERE activity = '" + _Activity.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    ActivityId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _ActivityId = 0;
                    return;
                }

                if (ActivitiesChanged != null)
                {
                    ActivitiesChanged(this);
                }
            }
        }

        public int ActivityId
        {
            get
            {
                try { return _ActivityId; }
                catch { return 0; }
            }
            set
            {


                _ActivityId = value;

                if (_PrevId != _ActivityId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Activities WHERE id = " + _ActivityId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Activity.Text = dr["activity"].ToString();
                        }
                    }
                    else
                    {
                        txt_Activity.Text = string.Empty;
                    }

                    _PrevId = _ActivityId;

                    if (ActivitiesChanged != null)
                    {
                        ActivitiesChanged(this);
                    }

                }
            }
        }
        public bool EnableSearchId
        {
            get
            {
                return _EnableSearchId;
            }
            set
            {
                _EnableSearchId = value;
            }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Activities popup = new frm_Activities();
            popup.cmb_ActivityOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Activity);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Activity.Text = string.Empty;
        }

        private void txt_Activity_TextChanged(object sender, EventArgs e)
        {
            try { Activity = txt_Activity.Text; }
            catch { }
        }
    }
    public class ActivityEventArgs : EventArgs
    {

    }
}
