using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Launches
{
    public delegate void LaunchGroupEventHandler(object sender);
    public partial class cmb_LaunchGroups : UserControl
    {
        public cmb_LaunchGroups()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event LaunchGroupEventHandler LaunchChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        #region Variables

        string _Launches = "";
        string _LaunchGroup = "";
        public string Launches
        {
            get { return _Launches; }
            set { _Launches = value; }
        }
        public string LaunchGroup
        {
            get { return txt_LaunchGroup.Text; }
            set
            {
                _LaunchGroup = value;
                txt_LaunchGroup.Text = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 dbo.GROUP_CONCAT(distinct name) as name FROM PROD_LaunchHead WHERE groupname = '" + _LaunchGroup + "'", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Launches = dr["name"].ToString();
                    }
                }
                else
                {

                    ClearFields();
                    if (LaunchChanged != null)
                        LaunchChanged(this);
                    //if (BatchChanged != null)
                    //{
                    //    BatchChanged(this);
                    //}
                }
            }
        }



        public int StageId
        { get; set; }
        #endregion

        public void ClearFields()
        {
            StageId = 0;
        }

        private void ShowLaunchFilter(string Beg)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_LaunchesGroups popup = new frm_LaunchesGroups();
            popup.cmb_LaunchOne = this;

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

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            ShowLaunchFilter(txt_LaunchGroup.Text);
        }

        private void txt_Launch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LaunchGroup = txt_LaunchGroup.Text;
            }
            catch
            {
                //return;
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_LaunchGroup.Text = string.Empty;

        }

        private void txt_Launch_Click(object sender, EventArgs e)
        {

        }

        private void txt_Launch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void txt_Launch_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (LaunchKeyPressed != null)
            //    {
            //        LaunchKeyPressed(this);
            //    }
            //}
        }
    }
}
