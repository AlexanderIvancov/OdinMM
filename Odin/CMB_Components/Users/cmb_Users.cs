using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Users
{
    public delegate void UsersEventHandler(object sender);

    public partial class cmb_Users : UserControl
    {
        public cmb_Users()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event UsersEventHandler UserChanged;

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        CMB_BLL BLL = new CMB_BLL();
        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();
        DAL_Functions glob_Function = new DAL_Functions();



        int _UserId = 0;

        public int UserId
        {
            get { return _UserId; }
            set
            {
                _UserId = value;
                UserDets(_UserId);
            }
        }

        public string User
        {
            get { return txt_User.Text; }
            set
            {
                txt_User.Text = value;
            }
        }

        public string UserTN
        {
            get { return txt_TN.Text; }
            set { txt_TN.Text = value; }
        }

        public string UserLogin
        {
            get; set;
        }

        public string UserShortName
        {
            get; set;
        }
        #endregion


        #region Methods

        public void SetCursor()
        {
            txt_User.SelectionStart = txt_User.Text.Length;
        }

        public void UserDets(int Id)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            string strSQL = "select distinct tabnr as tabnum, (name + ' ' + surname) as name, userlogin, isnull(shortname, '') as shortname  " +
                        "from bas_users where id = " + Id;
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                    new SqlDataAdapter(strSQL, conn);

            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    UserTN = dr["tabnum"].ToString();
                    User = dr["name"].ToString();
                    UserLogin = dr["userlogin"].ToString();
                    UserShortName = dr["shortname"].ToString();
                }
            }
            else
            {
                ClearFields();
            }
        }

        public void UserDetsFromTN(string TN)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            string strSQL = "select distinct id " +
                        "from bas_users where tabnr = '" + TN + "'";

            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                    new SqlDataAdapter(strSQL, conn);

            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    UserId = Convert.ToInt32(dr["id"]);
                }
            }
            else
            {
                _UserId = 0;
                User = "";
                UserLogin = "";
            }

        }

        public void ClearFields()
        {
            User = "";
            UserTN = "";
            UserLogin = "";
            UserShortName = "";
        }

        public void ShowFilter(string Beg)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Users popup = new frm_Users();
            popup.cmb_UserOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Beg);
        }

        #endregion

        #region Controls
        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_User.Text = string.Empty;
            UserId = 0;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_TN.Text = string.Empty;
            UserDetsFromTN(txt_TN.Text);
            if (UserChanged != null)
            {
                UserChanged(this);
            }
        }

        private void txt_TN_Validated(object sender, EventArgs e)
        {
            UserDetsFromTN(txt_TN.Text);
            if (UserChanged != null)
            {
                UserChanged(this);
            }
        }

        private void txt_TN_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserDetsFromTN(txt_TN.Text);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UserChanged != null)
                {
                    UserChanged(this);
                }
            }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            ShowFilter(txt_User.Text);
        }


        #endregion


    }
}
