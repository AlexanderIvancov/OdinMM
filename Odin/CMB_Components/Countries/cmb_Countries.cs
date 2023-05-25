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
namespace Odin.CMB_Components.Countries
{
    public delegate void CountriesEventHandler(object sender);
    public partial class cmb_Countries : UserControl
    {
        public event CountriesEventHandler CountryChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        CountryEventArgs args = new CountryEventArgs();
        int _CountryId = 0;
        int _PrevId = 0;
                
        bool _EnableSearchId = false;
        string _Country = "";
                
        public cmb_Countries()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string Country
        {
            get { return txt_Country.Text; }
            set {

                _Country = value;
                txt_Country.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Countries WHERE Country = '" + _Country.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    CountryId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {
                    
                    _CountryId = 0;
                    return;
                }

                if (CountryChanged != null)
                {
                    CountryChanged(this);
                }
            }
        }

        public int CountryId
        {
            get {
                try { return _CountryId; }
                catch { return 0; }
            }
            set {

                
                _CountryId = value;

                if (_PrevId != _CountryId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Countries WHERE id = " + _CountryId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Country.Text = dr["Country"].ToString();
                        }
                    }
                    else
                    {
                        txt_Country.Text = string.Empty;
                    }

                    _PrevId = _CountryId;

                    if (CountryChanged != null)
                    {
                        CountryChanged(this);
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
            
            frm_Countries popup = new frm_Countries();
            popup.cmb_CountryOne = this;

            PopupHelper.ClosePopup();
           
            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Country);          
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            Country = string.Empty;
        }

        private void txt_Country_TextChanged(object sender, EventArgs e)
        {
            try { Country = txt_Country.Text; }
            catch { }
        }
    }
    public class CountryEventArgs : EventArgs
    {

    }
}
