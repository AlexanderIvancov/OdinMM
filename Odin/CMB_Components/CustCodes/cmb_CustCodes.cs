using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.CustCodes
{
    public delegate void CustCodeEventHandler(object sender);

    public partial class cmb_CustCodes : UserControl
    {
        public event CustCodeEventHandler CustCodeChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        CustCodeEventArgs args = new CustCodeEventArgs();
        int _CustCodeId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _CustCode = "";

        public cmb_CustCodes()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string CustCode
        {
            get { return txt_CustCode.Text; }
            set
            {

                _CustCode = value;
                txt_CustCode.Text = value;

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_CustCodes WHERE code = '" + _CustCode.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    CustCodeId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _CustCodeId = 0;
                    return;
                }

                if (CustCodeChanged != null)
                {
                    CustCodeChanged(this);
                }
            }
        }

        public int CustCodeId
        {
            get
            {
                try { return _CustCodeId; }
                catch { return 0; }
            }
            set
            {


                _CustCodeId = value;

                if (_PrevId != _CustCodeId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_CustCodes WHERE id = " + _CustCodeId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_CustCode.Text = dr["code"].ToString();
                        }
                    }
                    else
                    {
                        txt_CustCode.Text = string.Empty;
                    }

                    _PrevId = _CustCodeId;

                    if (CustCodeChanged != null)
                    {
                        CustCodeChanged(this);
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

            frm_CustCodes popup = new frm_CustCodes();
            popup.cmb_CustCodeOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(CustCode);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_CustCode.Text = string.Empty;
        }

        private void txt_CustCode_TextChanged(object sender, EventArgs e)
        {
            try { CustCode = txt_CustCode.Text; }
            catch { }
        }
    }
    public class CustCodeEventArgs : EventArgs
    {

    }
}
