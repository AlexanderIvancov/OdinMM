using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.CMB_Components.StockInTypes
{
    public delegate void SITypeChangesEventHandler(object sender);

    public partial class cmb_StockInTypes : UserControl
    {
        public cmb_StockInTypes()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event SITypeChangesEventHandler TypesChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _TypeId = 0;
        int _PrevId = 0;


        string _Type = "";
        string _Lang = "ENG";

        public string Lang
        {
            get { return _Lang; }
            set { _Lang = value; }
        }

        public int MovType
        { get; set; }

        string _StockMovtypeLat = "";
        public string StockMovTypeLat
        {
            get { return _StockMovtypeLat; }
            set { _StockMovtypeLat = value; }
        }


        public string StockMovType
        {
            get { return txt_Type.Text; }
            set
            {

                _Type = value;
                txt_Type.Text = value;

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 typenum as typeid FROM STO_MoveTypes WHERE movdescription = '" + _Type.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    StockMovTypeId = Convert.ToInt32(dt.Rows[0]["typeid"].ToString());
                }
                catch
                {

                    _TypeId = 0;
                    return;
                }

                if (TypesChanged != null)
                {
                    TypesChanged(this);
                }
            }
        }

        public int StockMovTypeId
        {
            get
            {
                try { return _TypeId; }
                catch { return 0; }
            }
            set
            {


                _TypeId = value;

                if (_PrevId != _TypeId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 movdescription from STO_MoveTypes where typenum = " + _TypeId.ToString() + " and movlang = '" + Lang + "'", conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Type.Text = dr["movdescription"].ToString();
                        }
                    }
                    else
                    {
                        txt_Type.Text = string.Empty;
                    }

                    _PrevId = _TypeId;

                    if (TypesChanged != null)
                    {
                        TypesChanged(this);
                    }

                }
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Type.Text = string.Empty;
            StockMovTypeId = 0;
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_StockMovTypes popup = new frm_StockMovTypes();
            popup.cmb_StockInTypeOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(StockMovType, Lang, MovType);
        }
    }
}
