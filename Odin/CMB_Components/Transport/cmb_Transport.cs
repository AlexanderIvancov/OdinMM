using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Transport
{
    public delegate void TransportEventHandler(object sender);

    public partial class cmb_Transport : UserControl
    {
        public event TransportEventHandler TransportChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;
        
        int _TransportId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Transport = "";

        public cmb_Transport()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }

        public string Transport
        {
            get { return txt_Transport.Text; }
            set
            {

                _Transport = value;
                txt_Transport.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Transport WHERE name = '" + _Transport.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    TransportId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _TransportId = 0;
                    return;
                }

                if (TransportChanged != null)
                {
                    TransportChanged(this);
                }
            }
        }

        public int TransportId
        {
            get
            {
                try { return _TransportId; }
                catch { return 0; }
            }
            set
            {


                _TransportId = value;

                if (_PrevId != _TransportId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Transport WHERE id = " + _TransportId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Transport.Text = dr["name"].ToString();
                        }
                    }
                    else
                    {
                        txt_Transport.Text = string.Empty;
                    }

                    _PrevId = _TransportId;

                    if (TransportChanged != null)
                    {
                        TransportChanged(this);
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

            frm_Transport popup = new frm_Transport();
            popup.cmb_TransportOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Transport);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            Transport = string.Empty;
        }

        private void txt_Transport_TextChanged(object sender, EventArgs e)
        {
            try { Transport = txt_Transport.Text; }
            catch { }
        }
    }
}
