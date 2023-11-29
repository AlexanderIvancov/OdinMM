using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Package
{
    public delegate void PackagesEventHandler(object sender);

    public partial class cmb_Packages : UserControl
    {
        public event PackagesEventHandler PackagesChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _PackageId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Packages = "";


        public cmb_Packages()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public string Package
        {
            get { return txt_Packages.Text; }
            set
            {

                _Packages = value;
                txt_Packages.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Package WHERE name = '" + _Packages.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    PackageId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _PackageId = 0;
                    return;
                }

                if (PackagesChanged != null)
                {
                    PackagesChanged(this);
                }
            }
        }

        public int PackageId
        {
            get
            {
                try { return _PackageId; }
                catch { return 0; }
            }
            set
            {


                _PackageId = value;

                if (_PrevId != _PackageId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Package WHERE id = " + _PackageId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Packages.Text = dr["name"].ToString();
                        }
                    }
                    else
                    {
                        txt_Packages.Text = string.Empty;
                    }

                    _PrevId = _PackageId;

                    if (PackagesChanged != null)
                    {
                        PackagesChanged(this);
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

            frm_Packages popup = new frm_Packages();
            popup.cmb_PackageOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Package);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Packages.Text = string.Empty;
        }

        private void txt_Packages_TextChanged(object sender, EventArgs e)
        {
            try { Package = txt_Packages.Text; }
            catch { }
        }
    }
}
