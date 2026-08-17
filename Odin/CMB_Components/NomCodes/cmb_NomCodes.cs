using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.NomCodes
{
    public delegate void NomCodesEventHandler(object sender);

    public partial class cmb_NomCodes : UserControl
    {
        public cmb_NomCodes()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event NomCodesEventHandler NomCodesChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;
        
        bool _EnableSearchId = false;
        string _NomCodes = "";

        int _NomCodesId = 0;
        int _PrevId = 0;

        public string NomCodes
        {
            get { return txt_NomCodes.Text; }
            set
            {

                _NomCodes = value;
                txt_NomCodes.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM STO_StockInDets WHERE nomcode = '" + _NomCodes.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    NomCodesId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _NomCodesId = 0;
                    return;
                }

                NomCodesChanged?.Invoke(this);
            }
        }
        public int NomCodesId
        {
            get
            {
                try { return _NomCodesId; }
                catch { return 0; }
            }
            set
            {


                _NomCodesId = value;

                if (_PrevId != _NomCodesId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM STO_StockInDets WHERE id = " + _NomCodesId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_NomCodes.Text = dr["nomcode"].ToString();
                        }
                    }
                    else
                    {
                        txt_NomCodes.Text = string.Empty;
                    }

                    _PrevId = _NomCodesId;

                    NomCodesChanged?.Invoke(this);

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
            txt_NomCodes.Text = string.Empty;
        }

        private void txt_NomCodes_TextChanged(object sender, EventArgs e)
        {
            try { _NomCodes = txt_NomCodes.Text; }
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

            frm_NomCodes popup = new frm_NomCodes();
            popup.cmb_NomCodesOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(NomCodes);
        }

    }
}
