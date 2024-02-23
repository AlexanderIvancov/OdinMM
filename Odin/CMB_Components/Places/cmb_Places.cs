using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Places
{
    public delegate void PlacesEventHandler(object sender);
    public partial class cmb_Places : UserControl
    {
        public cmb_Places()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }


        int _lock = 0;
        public int Lock
        {
            get
            {
                return _lock;
            }
            set { _lock = value; }

        }

        public event PlacesEventHandler SelectedValueChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        public TreeNode SelectedNode
        {
            get;
            set;
        }

        int _PlaceId = 0;
        string _Place = "";

        public int PlaceId
        {
            get { return _PlaceId; }
            set
            {
                if (_lock != -1)
                {
                    _PlaceId = value;
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 dbo.fn_FullPlaceTree(" + _PlaceId.ToString() + ") as Place, isnull(dbo.fn_CheckQuarantine(" + _PlaceId.ToString() + "),0) as IsQuarantine", conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Place.Text = dr["Place"].ToString();
                            _Place = dr["Place"].ToString();
                            IsQuarantine = _isquarantine = Convert.ToInt32(dr["IsQuarantine"]);
                        }
                        //CheckQuarantine(_PlaceId);
                    }
                    else
                    {
                        Department = string.Empty;
                        IsQuarantine = 0;
                    }

                    SelectedValueChanged?.Invoke(this);
                }
            }
        }
        public string Department
        {
            get { return txt_Place.Text; }
            set
            {
                _Place = value;
                txt_Place.Text = value;
            }
        }

        int _isquarantine = 0;

        public int IsQuarantine
        {
            get { return _isquarantine; }
            set {



                _isquarantine = value;

            }
        }

        //public void CheckQuarantine(int placeid)
        //{
        //    int _res = Convert.ToInt32(Helper.GetOneRecord("select id from (select * from STO_Shelves where id in " +
        //        " (select idpl from dbo.ifn_StockPlaces(dbo.fn_DefaultValue('quarantine')))) tab where tab.id = " + placeid));
        //    IsQuarantine = _res == 0 ? 0 : -1;
        //}

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Place.Text = "";
            PlaceId = 0;
        }

        public void ValueChanged()
        {
            SelectedValueChanged?.Invoke(this);
        }

        private void btn_TreeView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Places popup = new frm_Places();
            popup.cmb_PlacesOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);
            popup.Load_tree();
            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };
        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            if (Lock == -1)
            {
                this.btn_Lock.Values.Image = global::Odin.Global_Resourses.lock_open;
                Lock = 0;
            }
            else

            {
                this.btn_Lock.Values.Image = global::Odin.Global_Resourses._lock;
                Lock = -1;
            }
        }

        private void txt_Place_Validated(object sender, EventArgs e)
        {
            
        }

        private void txt_Place_TextChanged(object sender, EventArgs e)
        {
            if (txt_Place.Text.Trim() == ""
                && String.IsNullOrEmpty(txt_Place.Text) == true)
            {
                PlaceId = 0;
                ValueChanged();
            }
        }
    }
}
