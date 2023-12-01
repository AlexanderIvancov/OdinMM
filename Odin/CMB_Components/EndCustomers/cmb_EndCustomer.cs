using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.EndCustomers
{
    public delegate void EndCustomerEventHandler(object sender);

    public partial class cmb_EndCustomer : UserControl
    {
        public cmb_EndCustomer()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event EndCustomerEventHandler EndCustomerChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;
        
        bool _EnableSearchId = false;
        string _EndCustomer = "";

        int _EndCustomerId = 0;
        int _PrevId = 0;

        public string EndCustomer
        {
            get { return txt_EndCustomer.Text; }
            set
            {

                _EndCustomer = value;
                txt_EndCustomer.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_EndCustomers WHERE customer = '" + _EndCustomer.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    EndCustomerId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _EndCustomerId = 0;
                    return;
                }

                if (EndCustomerChanged != null)
                {
                    EndCustomerChanged(this);
                }
            }
        }
        public int EndCustomerId
        {
            get
            {
                try { return _EndCustomerId; }
                catch { return 0; }
            }
            set
            {


                _EndCustomerId = value;

                if (_PrevId != _EndCustomerId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_EndCustomers WHERE id = " + _EndCustomerId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_EndCustomer.Text = dr["customer"].ToString();
                        }
                    }
                    else
                    {
                        txt_EndCustomer.Text = string.Empty;
                    }

                    _PrevId = _EndCustomerId;

                    if (EndCustomerChanged != null)
                    {
                        EndCustomerChanged(this);
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
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_EndCustomer.Text = string.Empty;
        }

        private void txt_EndCustomer_TextChanged(object sender, EventArgs e)
        {
            try { EndCustomer = txt_EndCustomer.Text; }
            catch { }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_EndCustomers popup = new frm_EndCustomers();
            popup.cmb_EndCustomerOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(EndCustomer);
        }

    }
}
