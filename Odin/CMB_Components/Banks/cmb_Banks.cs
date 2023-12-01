using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.CMB_Components.Banks
{
    public delegate void BankEventHandler(object sender);
    
    public partial class cmb_Banks : UserControl
    {
        public event BankEventHandler BankChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _BankId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Bank = "";

        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set
            {
                _isemptycolor = value;
                txt_Bank.StateCommon.Back.Color1 = value == true ? Color.LightPink : Color.White;
            }
        }

        public cmb_Banks()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }

        public string Bank
        {
            get { return txt_Bank.Text; }
            set
            {

                _Bank = value;
                txt_Bank.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Banks WHERE name = N'" + _Bank.ToString() + "' collate Cyrillic_General_CI_AI", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    BankId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _BankId = 0;
                    return;
                }

                if (BankChanged != null)
                {
                    BankChanged(this);
                }
            }
        }

        public int BankId
        {
            get
            {
                try { return _BankId; }
                catch { return 0; }
            }
            set
            {


                _BankId = value;

                if (_PrevId != _BankId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Banks WHERE id = " + _BankId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Bank.Text = dr["name"].ToString();
                        }
                    }
                    else
                    {
                        txt_Bank.Text = string.Empty;
                    }

                    _PrevId = _BankId;

                    if (BankChanged != null)
                    {
                        BankChanged(this);
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
            txt_Bank.Text = string.Empty;
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Banks popup = new frm_Banks();
            popup.cmb_BankOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Bank);
        }

        private void txt_Bank_TextChanged(object sender, EventArgs e)
        {
            try { Bank = txt_Bank.Text; }
            catch { }
        }
    }
}
