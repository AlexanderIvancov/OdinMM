using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Odin.CMB_Components.Places
{
    public partial class frm_Places : Form
    {
        public frm_Places()
        {
            InitializeComponent();
        }

        public frm_Places(cmb_Places cmb)
        {
            InitializeComponent();
            f = new cmb_Places();
            cmb = f;
        }

        cmb_Places f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        Helper helper = new Helper();
        DAL_Functions DLL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        bool _showingModal = false;

        DataTable datashelves = new DataTable();

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
        

        public void Load_tree()
        {
            KryptonTreeNode tnParent;
            var data = Helper.QueryDT("SELECT * FROM sto_shelves where isnull(isactive, -1) = -1 order by name ");

            tv_Places.Nodes.Clear();

            datashelves.Clear();
            datashelves.Columns.Add("id", typeof(int));
            datashelves.Columns.Add("name", typeof(string));
            datashelves.Columns.Add("parentid", typeof(int));

            foreach (System.Data.DataRow dr in data.Rows)
            {
                DataRow dr1 = datashelves.NewRow();
                dr1["id"] = Convert.ToInt32(dr["id"]);
                dr1["name"] = dr["name"].ToString();
                dr1["parentid"] = Convert.ToInt32(dr["parentid"]);
                datashelves.Rows.Add(dr1);
            }

            //foreach (System.Data.DataRow dr in data.Rows)
            //{
            //    if (Convert.ToInt32(dr["parentid"]) == 0)
            //    {

            //        int value = Convert.ToInt32(dr["id"]);
            //        tnParent = CreateNewItem(dr["name"].ToString(), Convert.ToInt32(dr["id"]));
            //        tv_Places.Nodes.Add(tnParent);

            //        tnParent.Expand();
            //        FillChild(tnParent, value);

            //    }
            //}
            DataRow[] foundrow = datashelves.Select("parentid = 0");
            foreach (System.Data.DataRow dr in foundrow)
            {
                int value = Convert.ToInt32(dr["id"]);
                tnParent = CreateNewItem(dr["name"].ToString(), Convert.ToInt32(dr["id"]));
                tv_Places.Nodes.Add(tnParent);
                tnParent.Expand();
                FillChild(tnParent, value);
            }
        }

        public int FillChild(KryptonTreeNode parent, int _id)
        {
            //var data = Helper.QueryDT("select * from sto_shelves where parentid =" + _id + " order by name");
            //if (data.Rows.Count > 0)
            //{
            //    foreach (System.Data.DataRow dr in data.Rows)
            //    {
            //        KryptonTreeNode child = CreateNewItem(dr["name"].ToString(), Convert.ToInt32(dr["id"]));
            //        int temp = Convert.ToInt32(dr["id"]);
            //        child.Collapse();
            //        parent.Nodes.Add(child);
            //        FillChild(child, temp);
            //    }
            //    return 0;
            //}
            //return 0;
            DataRow[] foundrow = datashelves.Select("parentid = " + _id);
            foreach (System.Data.DataRow dr in foundrow)
            {
                KryptonTreeNode child = CreateNewItem(dr["name"].ToString(), Convert.ToInt32(dr["id"]));
                int temp = Convert.ToInt32(dr["id"]);
                child.Collapse();
                parent.Nodes.Add(child);
                FillChild(child, temp);
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

        private void tv_Places_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isSelectedNode)
            {
                cmb_PlacesOne.PlaceId = Convert.ToInt32(e.Node.Tag);
                cmb_PlacesOne.SelectedNode = e.Node;
                SelectedNode = e.Node;
            }
            else
            {
            
            }

            isSelectedNode = true;
        }

        private void tv_Places_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            cmb_PlacesOne.PlaceId = Convert.ToInt32(e.Node.Tag);
            cmb_PlacesOne.SelectedNode = e.Node;
            SelectedNode = e.Node;
            isSelectedNode = true;
        }
    }
}
