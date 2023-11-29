using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Odin.CMB_Components.Category
{
    public partial class frm_TreeViewC : KryptonForm
    {

        cmb_Category f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        Helper helper = new Helper();
        DAL_Functions DLL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public frm_TreeViewC()
        {
            InitializeComponent();
        }
        public frm_TreeViewC(cmb_Category cmb)
        {
            InitializeComponent();
            f = new cmb_Category();
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

        int _CategoryId = 0;

        public string Description
        { get; set; }

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
                    new SqlDataAdapter("SELECT top 1 * FROM BAS_Category WHERE id = " + _CategoryId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Description = dr["description"].ToString();

                    }
                }
                else
                {
                    _CategoryId = 0;

                }
            }
        }

        private void tv_Cats_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isSelectedNode)
            {
                cmb_CategoryOne.CategoryId = Convert.ToInt32(e.Node.Tag);
                CategoryId = Convert.ToInt32(e.Node.Tag);
                cmb_CategoryOne.Category = e.Node.Text;
                cmb_CategoryOne.SelectedNode = e.Node;
                SelectedNode = e.Node;
                cmb_CategoryOne.ValueChanged();

            }
            else
            {
                ///GroupId = 0;

            }

            isSelectedNode = true;
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
            var data = Helper.QueryDT("SELECT * FROM bas_category order by name");

            tv_Cats.Nodes.Clear();
            foreach (System.Data.DataRow dr in data.Rows)
            {
                if (Convert.ToInt32(dr["parentid"]) == 0)
                {

                    int value = Convert.ToInt32(dr["id"]);
                    tnParent = CreateNewItem(dr["name"].ToString(), Convert.ToInt32(dr["id"]));
                    tv_Cats.Nodes.Add(tnParent);

                    tnParent.Expand();
                    FillChild(tnParent, value);

                }
            }

        }

        public int FillChild(KryptonTreeNode parent, int _id)
        {

            var data = Helper.QueryDT("select * from bas_category where parentid =" + _id + " order by name");
            if (data.Rows.Count > 0)
            {
                foreach (System.Data.DataRow dr in data.Rows)
                {
                    KryptonTreeNode child = CreateNewItem(dr["name"].ToString(), Convert.ToInt32(dr["id"]));
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

        private void tv_Cats_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            cmb_CategoryOne.CategoryId = Convert.ToInt32(e.Node.Tag);
            CategoryId = Convert.ToInt32(e.Node.Tag);
            cmb_CategoryOne.Category = e.Node.Text;
            cmb_CategoryOne.SelectedNode = e.Node;
            SelectedNode = e.Node;
            cmb_CategoryOne.ValueChanged();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddCategory frm = new frm_AddCategory();

            try
            {
                frm.ParentId = Convert.ToInt32(tv_Cats.SelectedNode.Tag);
                frm.HeaderText = "Add category for: " + tv_Cats.SelectedNode.Text;
            }
            catch
            {
                frm.ParentId = 0;
                frm.HeaderText = "Add category for root";
            }

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddCategory(frm.Category, frm.Description, frm.ParentId);
                Load_tree();
                cmb_CategoryOne.CategoryId = _res;

            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddCategory frm = new frm_AddCategory();

            try
            {
                frm.ParentId = Convert.ToInt32(tv_Cats.SelectedNode.Parent.Tag);
                frm.HeaderText = "Edit category for: " + tv_Cats.SelectedNode.Parent.Text;
            }
            catch
            {
                frm.ParentId = 0;
                frm.HeaderText = "Edit category for root";
            }

            frm.Category = tv_Cats.SelectedNode.Text;
            frm.Id = Convert.ToInt32(tv_Cats.SelectedNode.Tag);
            frm.Description = Description;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.EditCategory(frm.Id, frm.Category, frm.Description, frm.ParentId);
                Load_tree();
                cmb_CategoryOne.CategoryId = _res;

            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                //tv_Depts.HideSelection = true;
                if (glob_Class.DeleteConfirm() == true)
                {
                    Bll.DeleteCategory(CategoryId);
                    Load_tree();
                }
            }
            catch { MessageBox.Show("Error!"); }
        }
    }
}
