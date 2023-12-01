using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.PayTerms
{
    public delegate void PaytermsEventHandler(object sender);
    
    public partial class cmb_Payterms : UserControl
    {
        public event PaytermsEventHandler PaytermsChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _PaytermsId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Payterms = "";

        public cmb_Payterms()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string Payterms
        {
            get { return txt_Payterm.Text; }
            set
            {

                _Payterms = value;
                txt_Payterm.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_PayTerms WHERE term = N'" + _Payterms.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    PaytermsId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _PaytermsId = 0;
                    return;
                }

                PaytermsChanged?.Invoke(this);
            }
        }

        public int PaytermsId
        {
            get
            {
                try { return _PaytermsId; }
                catch { return 0; }
            }
            set
            {


                _PaytermsId = value;

                if (_PrevId != _PaytermsId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_PayTerms WHERE id = " + _PaytermsId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Payterm.Text = dr["term"].ToString();
                        }
                    }
                    else
                    {
                        txt_Payterm.Text = string.Empty;
                    }

                    _PrevId = _PaytermsId;

                    PaytermsChanged?.Invoke(this);

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

            frm_Payterms popup = new frm_Payterms();
            popup.cmb_PaytermOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Payterms);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Payterm.Text = string.Empty;
        }
    }
}
