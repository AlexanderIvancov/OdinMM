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


namespace Odin.CMB_Components.Rooms
{
    public delegate void RoomsEventHandler(object sender);

    public partial class cmb_Rooms : UserControl
    {
        public cmb_Rooms()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event RoomsEventHandler RoomsChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _RoomId = 0;
        int _PrevId = 0;
        int _tabrow = 1;
        int _tabcol = 1;

        bool _EnableSearchId = false;
        string _Room = "";

        int _placeid = 0;
       
        public int PlaceId
        {
            get { return _placeid; }
            set { _placeid = value; }
        }

        public int TabRow
        {
            get { return _tabrow; }
            set { _tabrow = value; }
        }

        public int TabCol
        {
            get { return _tabcol; }
            set { _tabcol = value; }
        }

        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set
            {
                _isemptycolor = value;
                if (value == true)
                    txt_Room.StateCommon.Back.Color1 = Color.LightPink;
                else
                    txt_Room.StateCommon.Back.Color1 = Color.White;
            }
        }

        public string Room
        {
            get { return txt_Room.Text; }
            set
            {

                _Room = value;
                txt_Room.Text = value;

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id, isnull(tabrow, 1) as tabrow, isnull(tabcol, 1) as tabcol FROM PROD_Rooms WHERE name = '" + _Room.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    RoomId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                    TabRow = Convert.ToInt32(dt.Rows[0]["tabrow"].ToString());
                    TabCol = Convert.ToInt32(dt.Rows[0]["tabcol"].ToString());
                }
                catch
                {

                    _RoomId = 0;
                    TabRow = 1;
                    TabCol = 1;
                    return;
                }


                if (RoomsChanged != null)
                {
                    RoomsChanged(this);
                }
            }
        }

        public int RoomId
        {
            get
            {
                try { return _RoomId; }
                catch { return 0; }
            }
            set
            {


                _RoomId = value;

                if (_PrevId != _RoomId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 name as room, isnull(tabrow, 1) as tabrow, isnull(tabcol, 1) as tabcol from PROD_Rooms where id = " + _RoomId, conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Room.Text = dr["room"].ToString();
                            TabRow = Convert.ToInt32(dr["tabrow"].ToString());
                            TabCol = Convert.ToInt32(dr["tabcol"].ToString());
                        }
                    }
                    else
                    {
                        txt_Room.Text = string.Empty;
                        TabRow = 1;
                        TabCol = 1;
                    }

                    _PrevId = _RoomId;

                    if (RoomsChanged != null)
                    {
                        RoomsChanged(this);
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
            txt_Room.Text = string.Empty;
            RoomId = 0;
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Rooms popup = new frm_Rooms();
            popup.cmb_RoomOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(PlaceId);
        }

        private void txt_Room_TextChanged(object sender, EventArgs e)
        {
            //try { Address = txt_Address.Text; }
            //catch { }
        }
    }
}
