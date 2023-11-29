using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.ContactPersons
{
    public delegate void ContPersEventHandler(object sender);

    public partial class cmb_ContactPersons : UserControl
    {
        public cmb_ContactPersons()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event ContPersEventHandler ContPersChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _ContPersId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _ContPers = "";

        int _firmid = 0;

        public int FirmId
        {
            get { return _firmid; }
            set { _firmid = value; }
        }

        public string ContPers
        {
            get { return txt_ContPerson.Text; }
            set
            {

                _ContPers = value;
                txt_ContPerson.Text = value;

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Contacts WHERE fullname = N'" + _ContPers.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    ContPersId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _ContPersId = 0;
                    return;
                }

                if (ContPersChanged != null)
                {
                    ContPersChanged(this);
                }
            }
        }



        public int ContPersId
        {
            get
            {
                try { return _ContPersId; }
                catch { return 0; }
            }
            set
            {


                _ContPersId = value;

                if (_PrevId != _ContPersId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 fullname from bas_contacts where id = " + _ContPersId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_ContPerson.Text = dr["fullname"].ToString();
                        }
                    }
                    else
                    {
                        txt_ContPerson.Text = string.Empty;
                    }

                    _PrevId = _ContPersId;

                    if (ContPersChanged != null)
                    {
                        ContPersChanged(this);
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
            txt_ContPerson.Text = string.Empty;
            ContPersId = 0;
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_ContactPerson popup = new frm_ContactPerson();
            popup.cmb_ContactPersonOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(FirmId);
        }

        private void txt_ContPerson_TextChanged(object sender, EventArgs e)
        {
            try { ContPers = txt_ContPerson.Text; }
            catch { }
        }
    }
}
