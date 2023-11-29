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

namespace Odin.CMB_Components.Bargains
{
    public delegate void BargainEventHandler(object sender);

    public partial class cmb_Bargain : UserControl
    {
        public cmb_Bargain()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }


        public event BargainEventHandler BargainChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        string _BargainCode = "";
       
        bool _EnableSearchId = false;
        string _Bargain= "";
        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set
            {
                _isemptycolor = value;
                if (value == true)
                    txt_Bargain.StateCommon.Back.Color1 = Color.LightPink;
                else
                    txt_Bargain.StateCommon.Back.Color1 = Color.White;
            }
        }
        public string Bargain
        {
            get { return txt_Bargain.Text; }
            set
            {

                _Bargain = value;
                txt_Bargain.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 code FROM BAS_Bargain WHERE description = '" + _Bargain.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    BargainCode = dt.Rows[0]["code"].ToString();
                }
                catch
                {

                    _BargainCode = "";
                    return;
                }

                if (BargainChanged != null)
                {
                    BargainChanged(this);
                }
            }
        }

        public string BargainCode
        {
            get
            {
                try { return _BargainCode; }
                catch { return ""; }
            }
            set
            {


                _BargainCode = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 * FROM BAS_Bargain WHERE code = '" + _BargainCode.ToString() + "'", conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Bargain.Text = dr["description"].ToString();
                        }
                    }
                    else
                    {
                        txt_Bargain.Text = string.Empty;
                    }

                    if (BargainChanged != null)
                    {
                        BargainChanged(this);
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
            txt_Bargain.Text = string.Empty;
            if (BargainChanged != null)
            {
                BargainChanged(this);
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

            frm_Bargains popup = new frm_Bargains();
            popup.cmb_BargainOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Bargain);
        }

        private void txt_Bargain_TextChanged(object sender, EventArgs e)
        {
            Bargain = txt_Bargain.Text;
            if (BargainChanged != null)
            {
                BargainChanged(this);
            }

        }
    }
}
