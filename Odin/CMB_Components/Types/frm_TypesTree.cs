using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Odin.CMB_Components.Types
{
    public partial class frm_TypesTree : Form
    {
        cmb_Types f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        Helper helper = new Helper();
        DAL_Functions DLL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public frm_TypesTree()
        {
            InitializeComponent();
        }

        public frm_TypesTree(cmb_Types cmb)
        {
            InitializeComponent();
            f = new cmb_Types();
            cmb = f;
        }

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        private bool isSelectedNode;

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
            tv_Types.Nodes.Clear();

            var tnRoot = new KryptonTreeNode();

            tnRoot.Text = "(Root)";

            tnRoot.Tag = 0;

            tv_Types.Nodes.Add(tnRoot);
            FillChild(tnRoot, 0);

            //KryptonTreeNode dummy;
            //dummy = new KryptonTreeNode("dummy node");
            //dummy.Tag = "dummy";
            //tnRoot.Nodes.Add(dummy);
            
            //KryptonTreeNode tnParent;
            //var data = Helper.QueryDT("SELECT * FROM bas_type order by name");

            ////tv_Types.Nodes.Clear();
            //foreach (System.Data.DataRow dr in data.Rows)
            //{
            //    if (Convert.ToInt32(dr["parentid"]) == 0)
            //    {

            //        int value = Convert.ToInt32(dr["id"]);
            //        tnParent = CreateNewItem(dr["name"].ToString(), Convert.ToInt32(dr["id"]));
            //        tv_Types.Nodes.Add(tnParent);

            //        tnParent.Expand();
            //        FillChild(tnParent, value);


            //    }
            //}

            tnRoot.Expand();
            isSelectedNode = false;
            tv_Types.SelectedNode = null;
        }
        public int FillChild(KryptonTreeNode parent, int _id)
        {         
            
            var data = Helper.QueryDT("select * from bas_type where parentid =" + _id + " order by name");
            if (data.Rows.Count > 0)
            {
                foreach (System.Data.DataRow dr in data.Rows)
                {
                    KryptonTreeNode child = CreateNewItem(dr["name"].ToString(), Convert.ToInt32(dr["id"]));
                    child.Checked = true;
                    int temp = Convert.ToInt32(dr["id"]);
                    child.Collapse();
                    parent.Nodes.Add(child);
                    //parent.Expand();
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
        int _TypeId = 0;

        public string Description
        { get; set; }
        public string TypeLat
        { get; set; }
        public int CustCodeId
        { get; set; }

        public int TypeId
        {
            get { return _TypeId; }
            set
            {
                _TypeId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 * FROM BAS_Type WHERE id = " + _TypeId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Description = dr["description"].ToString();
                        TypeLat = dr["namelat"].ToString();
                        CustCodeId = Convert.ToInt32(dr["custcodeid"]);
                    }
                }
                else
                {
                    _TypeId = 0;
                    CustCodeId = 0;
                }
            }
        }

        #region Controls



        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddType frm = new frm_AddType();

            try
            {
                frm.ParentId = Convert.ToInt32(tv_Types.SelectedNode.Tag);
                frm.HeaderText = "Add type for: " + tv_Types.SelectedNode.Text;
            }
            catch
            {
                frm.ParentId = 0;
                frm.HeaderText = "Add type for root";
            }

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddType(frm.Type, frm.Description, frm.ParentId, frm.TypeLat, frm.CustCodeId);
                Load_tree();
                cmb_TypeOne.TypeId = _res;

            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                _showingModal = true;

                frm_AddType frm = new frm_AddType();

                try
                {
                    frm.ParentId = Convert.ToInt32(tv_Types.SelectedNode.Parent.Tag);
                    frm.HeaderText = "Edit type " + tv_Types.SelectedNode.Text + " for: " + tv_Types.SelectedNode.Parent.Text;
                }
                catch
                {
                    frm.ParentId = 0;
                    frm.HeaderText = "Add type for root";
                }

                frm.Type = tv_Types.SelectedNode.Text;
                frm.Id = Convert.ToInt32(tv_Types.SelectedNode.Tag);
                TypeId = Convert.ToInt32(tv_Types.SelectedNode.Tag);
                frm.Description = Description;
                frm.TypeLat = TypeLat;
                frm.CustCodeId = CustCodeId;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    int _res = Bll.EditType(frm.Id, frm.Type, frm.Description, frm.ParentId, frm.TypeLat, frm.CustCodeId);
                    Load_tree();
                    cmb_TypeOne.TypeId = _res;

                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
            catch { }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (glob_Class.DeleteConfirm() == true)
                {
                    //MessageBox.Show(TypeId.ToString());
                    Bll.DeleteType(TypeId);
                    Load_tree();
                }
            }
            catch { MessageBox.Show("Error!"); }
        }

        private void frm_TypesTree_Load(object sender, EventArgs e)
        {
            //Load_tree();
        }

        private void tv_Types_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isSelectedNode)
            {
                cmb_TypeOne.TypeId = Convert.ToInt32(e.Node.Tag);
                TypeId = Convert.ToInt32(e.Node.Tag);
                //cmb_TypeOne.Type = e.Node.Text;
                cmb_TypeOne.SelectedNode = e.Node;
                SelectedNode = e.Node;
                
                cmb_TypeOne.ValueChanged(tv_Types);
            }
            else
            {
                ///GroupId = 0;

            }

            isSelectedNode = true;
        }



        #endregion

        private void tv_Types_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            cmb_TypeOne.TypeId = Convert.ToInt32(e.Node.Tag);
            cmb_TypeOne.Type = e.Node.Text;
            cmb_TypeOne.SelectedNode = e.Node;
            SelectedNode = e.Node;
            
            cmb_TypeOne.ValueChanged(tv_Types);
            isSelectedNode = true;
        }

        private void tv_Types_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //cmb_TypeOne.TypeId = Convert.ToInt32(e.Node.Tag);
            //cmb_TypeOne.Type = e.Node.Text;
            //cmb_TypeOne.SelectedNode = e.Node;
            //SelectedNode = e.Node;
            //cmb_TypeOne.ValueChanged();
            //isSelectedNode = true;
            if (e.Node.IsExpanded == false)
                this.Close();
        }

        private void tv_Types_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked == true)
            {
                foreach (KryptonTreeNode node in e.Node.Nodes)
                {
                    node.Checked = true;
                }
            }
            else
            {
                foreach (KryptonTreeNode node in e.Node.Nodes)
                {
                    node.Checked = false;
                }
            }
        }

        private void frm_TypesTree_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frm_TypesTree_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cmb_TypeOne.TypeIDs.Clear();

            //foreach (KryptonTreeNode node in tv_Types.Nodes)
            //{
            //    if (node.Checked == true)
            //    {
            //        cmb_TypeOne.TypeIDs.Add(Convert.ToInt32(node.Tag));
            //    }
            //}
        }

        private void btn_Coincidences_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _type = "";

            _type = tv_Types.SelectedNode.Text;
            _id = Convert.ToInt32(tv_Types.SelectedNode.Tag);

            var _query = "sp_AnalyzeArticlesDifference";

            var sqlparams = new List<SqlParameter>()
            {
                new SqlParameter("@typeid",SqlDbType.Int) {Value = _id}
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Articles coincidences for type: " + _type;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Parameters_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _type = "";

            try
            {
                _type = tv_Types.SelectedNode.Text;
                _id = Convert.ToInt32(tv_Types.SelectedNode.Tag);
            }
            catch {
                _id = cmb_TypeOne.TypeId;
                _type = cmb_TypeOne.Type;
            }

            frm_TypeParameters frm = new frm_TypeParameters();
            frm.HeaderText = "Type specification for: " + _type;
            frm.TypeId = _id;
            frm.FillList(_id);

            frm.Show(); frm.GetKryptonFormFields();
        }
    }
}
