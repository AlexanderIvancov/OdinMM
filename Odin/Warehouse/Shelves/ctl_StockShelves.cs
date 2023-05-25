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
using Odin.CMB_Components.BLL;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;


namespace Odin.Warehouse.Shelves
{
    public partial class ctl_StockShelves : UserControl
    {
        public ctl_StockShelves()
        {
            InitializeComponent();
        }
        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        StockReg_BLL BLL = new StockReg_BLL();
        TreeNode dummy;
        class_Global glob_Class = new class_Global();

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

        public string PlaceName
        { get; set; }
        public string PlaceDescription
        { get; set; }
        public int PlaceParentId
        { get; set; }
        public string PlaceCreatedAt
        { get; set; }
        public string PlaceCreatedBy
        { get; set; }
        public int PlaceDeptId
        { get; set; }
        public int PlaceFirmId
        { get; set; }
        public int PlaceIsProduction
        { get; set; }
        public int PlaceRespPersonId
        { get; set; }
        public int PlaceAddressId
        { get; set; }
        public int PlaceQuarantine
        { get; set; }

        int _placeid = 0;

        public int PlaceId
        {
            get { return _placeid; }
            set {
                _placeid = value;
                BLL.PlaceId = _placeid;
                PlaceName = BLL.PlaceName;
                PlaceDescription = BLL.PlaceDescription;
                PlaceParentId = BLL.PlaceParentId;
                PlaceCreatedAt = BLL.PlaceCreatedAt;
                PlaceCreatedBy = BLL.PlaceCreatedBy;
                PlaceAddressId = BLL.PlaceAddressId;
                PlaceDeptId = BLL.PlaceDeptId;
                PlaceFirmId = BLL.PlaceFirmId;
                PlaceIsProduction = BLL.PlaceIsProduction;
                PlaceRespPersonId = BLL.PlaceRespPersonId;
                PlaceQuarantine = BLL.PlaceQuarantine;
            }
        }

        #endregion

        #region Methods

        public void Load_Root()
        {
            var tnRoot = new TreeNode();

            tnRoot.Text = "(Root)";

            tnRoot.Tag = 0;

            tv_StockPlaces.Nodes.Add(tnRoot);
            TreeNode dummy;
            dummy = new TreeNode("dummy node");
            dummy.Tag = "dummy";
            tnRoot.Nodes.Add(dummy);
            PopulateChildren(tnRoot);
            tnRoot.Expand();
            //tnRoot.Sel = true;
            isSelectedNode = true;
        }

        private void PopulateChildren(TreeNode parent)
        {

            TreeNode dumyNode = parent.Nodes[0];
            if (dumyNode.Tag.ToString() == "dummy")
            {
                IEnumerable<DataNode> childItems;
                TreeNodeCollection nodes = parent.Nodes;
                TreeNode dummy;
                TreeNode child;
                dumyNode.Remove();
                if (parent.Tag.ToString() != "dummy")
                {
                    childItems = GetNodes((int)parent.Tag);
                    foreach (var item in childItems)
                    {
                        child = new TreeNode();
                        child.Tag = item.Id;
                        child.Text = item.Text;
                        if (item.ChildCount > 0)
                        {
                            dummy = new TreeNode("dummy node");
                            dummy.Tag = "dummy";
                            child.Nodes.Add(dummy);
                        }
                        nodes.Add(child);
                    }

                }

            }

        }

        private IEnumerable<DataNode> GetNodes(int parentId)
        {

            var data = Helper.QueryDT("SELECT * FROM STO_Shelves WHERE ParentId = " + parentId + " order by Name");
            foreach (System.Data.DataRow dr in data.Rows)
            {
                var param = new SqlParameter("@id", SqlDbType.Int);
                param.Value = Convert.ToInt32(dr["id"]);
                int childCount = (int)Helper.GetOneRecord("select count(*) FROM STO_Shelves WHERE ParentId = @id", param);
                var returnNode = new DataNode
                {
                    Id = Convert.ToInt32(dr["id"]),
                    Text = Convert.ToString(dr["name"]),
                    ParentId = Convert.ToInt32(dr["parentid"]),
                    ChildCount = childCount
                };
                yield return returnNode;
            }
        }
        
        public string TwoNodes(int Id)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT IsNull(s1.name + ' / ', '') + s.name as Shelf " +
                                        "from STO_Shelves s " +
                                        "LEFT JOIN STO_Shelves s1 ON s1.Id = s.ParentId " +
                                        "where s.id = @Id";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlConn.Open();

            SqlDataReader reader = sqlComm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                _res = reader["Shelf"].ToString();
                reader.Close();
            }
            else
            {
                _res = "";
            }
            sqlConn.Close();
            return _res;
        }

       

        #endregion


        #region Controls
           

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddShelf")) return;
            frm_AddShelf frm = new frm_AddShelf();
            frm.HeaderText = "Add new shelf for: " + SelectedNode.Text;
            frm.Quarantine = PlaceQuarantine;
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                int rowsaffected = BLL.AddStockPlace(frm.Place, frm.Description, PlaceId, frm.DeptId, frm.FirmId, frm.AddressId, frm.RespPersonId, frm.IsProduction, frm.Quarantine, frm.OwnerId);
                dummy = new TreeNode(frm.Place);
                dummy.Tag = rowsaffected;
                SelectedNode.Nodes.Add(dummy);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddShelf")) return;
            frm_AddShelf frm = new frm_AddShelf();
            frm.HeaderText = "Edit shelf: " + BLL.PlaceName;
            frm.Place = BLL.PlaceName;
            frm.Description = BLL.PlaceDescription;
            frm.DeptId = BLL.PlaceDeptId;
            frm.FirmId = BLL.PlaceFirmId;
            frm.AddressId = BLL.PlaceAddressId;
            frm.RespPersonId = BLL.PlaceRespPersonId;
            frm.IsProduction = BLL.PlaceIsProduction;
            frm.Quarantine = BLL.PlaceQuarantine;
            frm.OwnerId = BLL.PlaceOwnerId;

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                BLL.EditStockPlace(BLL.PlaceId, frm.Place, frm.Description, BLL.PlaceParentId, frm.DeptId, 
                                frm.FirmId, frm.AddressId, frm.RespPersonId, frm.IsProduction, frm.Quarantine, 
                                frm.OwnerId);
                SelectedNode.Text = frm.Place;
                BLL.PlaceId = Convert.ToInt32(SelectedNode.Tag);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (glob_Class.DeleteConfirm() == true)
            {
                if (BLL.DeleteStockPlace((Int32)SelectedNode.Tag) == -1)
                    SelectedNode.Remove();
                else
                    MessageBox.Show("Error during deleting, please check sub-places and movements!");
            }
        }

        private void btn_Permissions_Click(object sender, EventArgs e)
        {

        }

        private void tv_StockPlaces_AfterExpand(object sender, TreeViewEventArgs e)
        {
            PopulateChildren(e.Node);
        }


        private void tv_StockPlaces_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isSelectedNode)
            {
                PlaceId = Convert.ToInt32(e.Node.Tag);
                SelectedNode = e.Node;

            }
            else
            {
                PlaceId = 0;

            }

            isSelectedNode = true;
        }

        #endregion

        private void tv_StockPlaces_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void tv_StockPlaces_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tv_StockPlaces_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;
            //int result;
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));

                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt); //Destination point


                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode"); //From point

                //MessageBox.Show(NewNode.Tag.ToString() + " -> " + DestinationNode.Tag.ToString());

                //if (DestinationNode.Parent != NewNode.Parent)
                //{
                if (glob_Class.MoveConfirm("node " + NewNode.Text + " in", " node " + DestinationNode.Text))
                {
                    try
                    {

                        SqlConnection sqlConn = new SqlConnection(sConnStr);
                        SqlCommand sqlComm = new SqlCommand("sp_MoveStockPlace", sqlConn);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.Parameters.AddWithValue("@idplace", (Int32)NewNode.Tag);
                        sqlComm.Parameters.AddWithValue("@idtarget", (Int32)DestinationNode.Tag);

                        sqlConn.Open();

                        SqlDataReader reader = sqlComm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            int result = Convert.ToInt32(reader["Error"]);
                            if (result == 0)
                            {
                                DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                                DestinationNode.Expand();
                                //Remove Original Node
                                NewNode.Remove();
                            }
                            else
                            {
                                MessageBox.Show("Movement impossible!");
                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error during operation!");
                        }
                        sqlConn.Close();
                    }
                    catch
                    { MessageBox.Show("Error during operation!"); }
                }
                //}
            }
        }

        private void tv_StockPlaces_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked == true)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = true;
                }
            }
            else
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = false;
                }
            }
        }

        private void btn_PrintLabel_Click(object sender, EventArgs e)
        {

        }
    }
}