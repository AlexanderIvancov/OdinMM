using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Currencies
{
    public delegate void CurrenciesEventHandler(object sender);
    public partial class cmb_Currency : UserControl
    {
        public event CurrenciesEventHandler CurrencyChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        CountryEventArgs args = new CountryEventArgs();
        int _CurrencyId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Currency = "";

        public cmb_Currency()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string Currency
        {
            get { return txt_Currency.Text; }
            set
            {

                _Currency = value;
                txt_Currency.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Currency WHERE currency = '" + _Currency.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    CurrencyId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    CurrencyId = 0;
                    return;
                }

                if (CurrencyChanged != null)
                {
                    CurrencyChanged(this);
                }
            }
        }

        public void UpdateCurRate()
        {
            if (CurrencyChanged != null)
            {
                CurrencyChanged(this);
            }
        }

        public int CurrencyId
        {
            get
            {
                try { return _CurrencyId; }
                catch { return 0; }
            }
            set
            {


                _CurrencyId = value;

                if (_PrevId != _CurrencyId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Currency WHERE id = " + _CurrencyId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Currency.Text = dr["currency"].ToString();
                        }
                    }
                    else
                    {
                        txt_Currency.Text = string.Empty;
                    }

                    _PrevId = _CurrencyId;

                    if (CurrencyChanged != null)
                    {
                        CurrencyChanged(this);
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

            frm_Currencies popup = new frm_Currencies();
            popup.cmb_CurrencyOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Currency);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            Currency = string.Empty;
        }

        private void txt_Currency_TextChanged(object sender, EventArgs e)
        {
            try { Currency = txt_Currency.Text; }
            catch { }
        }

        private void txt_Currency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
    public class CountryEventArgs : EventArgs
    {

    }
}
