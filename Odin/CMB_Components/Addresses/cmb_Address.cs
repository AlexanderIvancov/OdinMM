using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.CMB_Components.Addresses
{
    public delegate void AddressEventHandler(object sender);

    public partial class cmb_Address : UserControl
    {
        public cmb_Address()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event AddressEventHandler AddressChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _AddressId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Address = "";

        int _firmid = 0;
        int _legal = 0;
        int _defaultdelivplace = 0;

        public int FirmId
        {
            get { return _firmid; }
            set { _firmid = value; }
        }

        public int LegalAddress
        {
            get { return _legal; }
                set{ _legal = value; }
        }

        public int DefaultDelivPlace
        {
            get { return _defaultdelivplace; }
            set { _defaultdelivplace = value; }
        }


        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set
            {
                _isemptycolor = value;
                txt_Address.StateCommon.Back.Color1 = value == true ? Color.LightPink : Color.White;
            }
        }

        public string Address
        {
            get { return txt_Address.Text; }
            set
            {

                _Address = value;
                txt_Address.Text = value;

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Addresses WHERE fulladdress = '" + _Address.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    AddressId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _AddressId = 0;
                    return;
                }


                AddressChanged?.Invoke(this);
            }
        }

        public int AddressId
        {
            get
            {
                try { return _AddressId; }
                catch { return 0; }
            }
            set
            {


                _AddressId = value;

                if (_PrevId != _AddressId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 dbo.fn_FullAddress(" + _AddressId.ToString() + ") as address", conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Address.Text = dr["address"].ToString();
                        }
                    }
                    else
                    {
                        txt_Address.Text = string.Empty;
                    }

                    _PrevId = _AddressId;

                    AddressChanged?.Invoke(this);

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
            txt_Address.Text = string.Empty;
            AddressId = 0;
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Address popup = new frm_Address();
            popup.cmb_AddressOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(FirmId, LegalAddress, DefaultDelivPlace);
        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {
            //try { Address = txt_Address.Text; }
            //catch { }
        }
    }
}
