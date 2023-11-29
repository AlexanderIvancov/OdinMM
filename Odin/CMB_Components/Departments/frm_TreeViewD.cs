using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;
using System.Data.SqlClient;

using ComponentFactory.Krypton.Toolkit;

namespace Odin.CMB_Components.Departments
{
    public partial class frm_TreeViewD : Form
    {

        cmb_Department f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        Helper helper = new Helper();
        DAL_Functions DLL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public frm_TreeViewD()
        {
            InitializeComponent();
        }

        public frm_TreeViewD(cmb_Department cmb)
        {
            InitializeComponent();
            f = new cmb_Department();
            cmb = f;
        }

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        private bool isSelectedNode = false;

        public string SelectedNodeText
        {
            get;
            set;
        }

        public int NodeId
        {
            get;
            set;
        }

        public string SelectedNodePath
        {
            get;
            set;
        }

        public TreeNode SelectedNode
        {
            get;
            set;
        }

        int _DeptId = 0;

        public string Description
        { get; set; }
        public string RespPersonTN
        { get; set; }

        public int DeptId
        {
            get { return _DeptId; }
            set {
                _DeptId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 * FROM BAS_Departments WHERE id = " + _DeptId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Description = dr["description"].ToString();
                        RespPersonTN = dr["resppersontn"].ToString();
                    }
                }
                else
                {
                    _DeptId = 0;

                }
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddDepartment frm = new frm_AddDepartment();

            try
            {
                frm.ParentId = Convert.ToInt32(tv_Depts.SelectedNode.Tag);
                frm.HeaderText = "Add department for: " + tv_Depts.SelectedNode.Text;
            }
            catch {
                frm.ParentId = 0;
                frm.HeaderText = "Add department for root";
            }

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddDepartment(frm.Department, frm.Description, frm.ParentId, frm.RespPerson);
                Load_tree();
                cmb_DepartmentOne.DeptId = _res;
                
            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddDepartment frm = new frm_AddDepartment();

            try
            {
                frm.ParentId = Convert.ToInt32(tv_Depts.SelectedNode.Parent.Tag);
                frm.HeaderText = "Edit department for: " + tv_Depts.SelectedNode.Parent.Text;
            }
            catch
            {
                frm.ParentId = 0;
                frm.HeaderText = "Add department for root";
            }

            frm.Department = tv_Depts.SelectedNode.Text;
            frm.Id = Convert.ToInt32(tv_Depts.SelectedNode.Tag);
            frm.Description = Description;
            frm.RespPerson = RespPersonTN;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.EditDepartment(frm.Id, frm.Department, frm.Description, frm.ParentId, frm.RespPerson);
                Load_tree();
                cmb_DepartmentOne.DeptId = _res;

            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //int _id = 0;
            try
            {
                //tv_Depts.HideSelection = true;
                if (glob_Class.DeleteConfirm() == true)
                {
                    Bll.DeleteDepartment(DeptId);
                    Load_tree();
                }
            }
            catch { MessageBox.Show("Error!"); }
        }

        private void tv_Depts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isSelectedNode)
            {
                cmb_DepartmentOne.DeptId = Convert.ToInt32(e.Node.Tag);
                DeptId = Convert.ToInt32(e.Node.Tag);
                cmb_DepartmentOne.Department = e.Node.Text;
                cmb_DepartmentOne.SelectedNode = e.Node;
                SelectedNode = e.Node;
                cmb_DepartmentOne.ValueChanged();

            }
            else
            {
                ///GroupId = 0;

            }

            isSelectedNode = true;
        }

        private void frm_TreeViewD_Load(object sender, EventArgs e)
        {
            //Load_tree();
        }

        public void Load_tree()
        {
            //tv_Depts.Nodes.Clear();

            //var tnRoot = new KryptonTreeNode();

            //tnRoot.Text = "(Root)";

            //tnRoot.Tag = 0;

            //tv_Depts.Nodes.Add(tnRoot);
            //FillChild(tnRoot, 0);

            //tnRoot.Expand();
            //isSelectedNode = false;
            //tv_Depts.SelectedNode = null;
            KryptonTreeNode tnParent;
            var data = Helper.QueryDT("SELECT * FROM bas_departments order by department");

            tv_Depts.Nodes.Clear();
            foreach (System.Data.DataRow dr in data.Rows)
            {
                if (Convert.ToInt32(dr["parentid"]) == 0)
                {

                    int value = Convert.ToInt32(dr["id"]);
                    tnParent = CreateNewItem(dr["department"].ToString(), Convert.ToInt32(dr["id"]));
                    tv_Depts.Nodes.Add(tnParent);

                    tnParent.Expand();
                    FillChild(tnParent, value);

                }
            }

        }

        public int FillChild(KryptonTreeNode parent, int _id)
        {

            var data = Helper.QueryDT("select * from bas_departments where parentid =" + _id + " order by department");
            if (data.Rows.Count > 0)
            {
                foreach (System.Data.DataRow dr in data.Rows)
                {
                    KryptonTreeNode child = CreateNewItem(dr["department"].ToString(), Convert.ToInt32(dr["id"]));
                    int temp = Convert.ToInt32(dr["id"]);
                    child.Collapse();
                    parent.Nodes.Add(child);
                    FillChild(child, temp);
                }
                return 0;
            }
            return 0;
        }

        private KryptonTreeNode CreateNewItem(string _nodetext, int _tag)
        {
            KryptonTreeNode item = new KryptonTreeNode();
            item.Text = _nodetext;
            item.Tag = _tag;
            return item;
        }

        private void tv_Depts_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            cmb_DepartmentOne.DeptId = Convert.ToInt32(e.Node.Tag);
            DeptId = Convert.ToInt32(e.Node.Tag);
            cmb_DepartmentOne.Department = e.Node.Text;
            cmb_DepartmentOne.SelectedNode = e.Node;
            SelectedNode = e.Node;
            cmb_DepartmentOne.ValueChanged();
            isSelectedNode = true;
        }

        private void tv_Depts_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.IsExpanded == false)
                this.Close();
        }
    }
}
