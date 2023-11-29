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

namespace Odin.CMB_Components.Departments
{
    public delegate void DepartmentEventHandler(object sender);

    public partial class cmb_Department : UserControl
    {
        public cmb_Department()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event DepartmentEventHandler SelectedValueChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        public TreeNode SelectedNode
        {
            get;
            set;
        }

        int _DeptId = 0;
        string _Dept = "";

        public int DeptId
        {
            get { return _DeptId; }
            set
            {
                _DeptId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 department FROM BAS_Departments WHERE id = " + _DeptId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_Department.Text = dr["department"].ToString();
                        _Dept = dr["department"].ToString();
                       
                    }
                }
                else
                {
                    Department = string.Empty;
                }
            }
        }
        public string Department
        {
            get { return txt_Department.Text; }
            set
            {
                _Dept = value;
                txt_Department.Text = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 id FROM BAS_Departments WHERE department = '" + _Dept.ToString() + "'", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        _DeptId = Convert.ToInt32(dr["id"].ToString());
                    }
                }
                else
                {
                    _DeptId = 0;
                   
                }

            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Department.Text = string.Empty;
        }

        private void btn_TreeView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_TreeViewD popup = new frm_TreeViewD();
            popup.cmb_DepartmentOne = this;

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

        private void txt_Department_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Shelf = txt_Shelf.Text;
                if (glob_Class.NES(txt_Department.Text) == "")
                    DeptId = 0;
                if (SelectedValueChanged != null)
                {
                    SelectedValueChanged(this);
                }
            }
            catch { return; }
        }

        public void ValueChanged()
        {
            if (SelectedValueChanged != null)
            {
                SelectedValueChanged(this);
            }
        }

        private void txt_Department_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
}
