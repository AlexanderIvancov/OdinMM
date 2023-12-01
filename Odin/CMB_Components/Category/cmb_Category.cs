using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Category
{
    public delegate void CategoryEventHandler(object sender);

    public partial class cmb_Category : UserControl
    {
        public cmb_Category()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event CategoryEventHandler SelectedValueChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        public TreeNode SelectedNode
        {
            get;
            set;
        }

        int _CategoryId = 0;
        string _Category = "";

        public int CategoryId
        {
            get { return _CategoryId; }
            set
            {
                _CategoryId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 name FROM BAS_Category WHERE id = " + _CategoryId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_Category.Text = dr["name"].ToString();
                        _Category = dr["name"].ToString();

                    }
                }
                else
                {
                    Category = string.Empty;
                }
            }
        }
        public string Category
        {
            get { return txt_Category.Text; }
            set
            {
                _Category = value;
                txt_Category.Text = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 id FROM BAS_Category WHERE name = '" + _Category.ToString() + "'", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        _CategoryId = Convert.ToInt32(dr["id"].ToString());
                    }
                }
                else
                {
                    _CategoryId = 0;
                }

            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Category.Text = string.Empty;
        }

        public void ValueChanged()
        {
            SelectedValueChanged?.Invoke(this);
        }

        private void txt_Category_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Shelf = txt_Shelf.Text;
                if (glob_Class.NES(txt_Category.Text) == "")
                    CategoryId = 0;
                SelectedValueChanged?.Invoke(this);
            }
            catch { return; }
        }

        private void btn_TreeView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_TreeViewC popup = new frm_TreeViewC();
            popup.cmb_CategoryOne = this;

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
    }
}
