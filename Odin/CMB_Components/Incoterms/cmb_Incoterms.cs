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

namespace Odin.CMB_Components.Incoterms
{
    public delegate void IncotermsEventHandler(object sender);


    public partial class cmb_Incoterms : UserControl
    {
        public cmb_Incoterms()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event IncotermsEventHandler IncotermsChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        IncotermsEventArgs args = new IncotermsEventArgs();
        int _IncotermsId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Incoterm = "";


        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set
            {
                _isemptycolor = value;
                if (value == true)
                    txt_Incoterm.StateCommon.Back.Color1 = Color.LightPink;
                else
                    txt_Incoterm.StateCommon.Back.Color1 = Color.White;
            }
        }

        public string Incoterms
        {
            get { return txt_Incoterm.Text; }
            set
            {

                _Incoterm = value;
                txt_Incoterm.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Incoterms WHERE incoterm = '" + _Incoterm.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    IncotermId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _IncotermsId = 0;
                    return;
                }

                if (IncotermsChanged != null)
                {
                    IncotermsChanged(this);
                }
            }
        }
        public int IncotermId
        {
            get
            {
                try { return _IncotermsId; }
                catch { return 0; }
            }
            set
            {


                _IncotermsId = value;

                if (_PrevId != _IncotermsId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Incoterms WHERE id = " + _IncotermsId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Incoterm.Text = dr["incoterm"].ToString();
                        }
                    }
                    else
                    {
                        txt_Incoterm.Text = string.Empty;
                    }

                    _PrevId = _IncotermsId;

                    if (IncotermsChanged != null)
                    {
                        IncotermsChanged(this);
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
            txt_Incoterm.Text = string.Empty;
        }

        private void txt_Incoterm_TextChanged(object sender, EventArgs e)
        {
            try { Incoterms = txt_Incoterm.Text; }
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

            frm_Incoterms popup = new frm_Incoterms();
            popup.cmb_IncotermOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Incoterms);
        }


    }
    public class IncotermsEventArgs : EventArgs
    {

    }
}
