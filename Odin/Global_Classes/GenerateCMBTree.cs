using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Odin.Global_Classes
{ /// <summary>
  /// The class regarding TreeView of Popup Window 
  /// </summary>
    public static class GenerateCMBTree
    {
        static readonly string dummyTag = "dummy";
        static readonly string dummyNode = "dummy node";
        public static readonly string root = "(Root)";
        private static readonly int emptyValue = 0;

        /// <summary>
        /// Fills root node of TreeView
        /// </summary>
        /// <param name="tree">TreeView to fill</param>
        /// <param name="getRootNodes">Function to get IEnumarble root nodes</param>
        public static void IntitialFillTree(TreeView tree, Func<int, IEnumerable<DataNode>> getRootNodes)
        {
            var tnRoot = new TreeNode();
            tnRoot.Text = root;
            tnRoot.Tag = emptyValue;
            tree.Nodes.Add(tnRoot);

            var dummy = new TreeNode(dummyNode);
            dummy.Tag = dummyTag;
            tnRoot.Nodes.Add(dummy);

            GetNodes(tnRoot, getRootNodes(emptyValue));
            tnRoot.Expand();
        }

        /// <summary>
        /// Populate parent node with child Data Nodes 
        /// </summary>
        private static void GetNodes(TreeNode parent, IEnumerable<DataNode> childItems = null)
        {
            TreeNode dumyNode = parent.Nodes[0];

            if (dumyNode.Tag.ToString() == dummyTag)
            {
                TreeNodeCollection nodes = parent.Nodes;
                TreeNode dummy;
                TreeNode child;

                dumyNode.Remove();

                if (parent.Tag.ToString() != dummyTag)
                {
                    foreach (var item in childItems)
                    {
                        child = new TreeNode();
                        child.Tag = item.Id;
                        child.Text = item.Text;
                        if (item.ChildCount > 0)
                        {
                            dummy = new TreeNode(dummyNode);
                            dummy.Tag = dummyTag;
                            child.Nodes.Add(dummy);
                        }

                        nodes.Add(child);
                    }
                }
            }
        }

        /// <summary>
        /// Fills parent node of TreeView
        /// </summary>
        /// <param name="parent">Parent node to fill</param>
        /// <param name="getChildNodes">Function to get IEnumarble child nodes</param>
        public static void PopulateChildren(TreeNode parent, Func<int, IEnumerable<DataNode>> getChildNodes = null)
        {
            if (getChildNodes != null)
            {
                GetNodes(parent, getChildNodes((int)parent.Tag));
            }
            else
            {
                GetNodes(parent);
            }
        }

        /// <summary>
        /// Loads TreeView with previously expanded or selected  nodes
        /// </summary>
        /// <param name="cmbTree">TreeView of CombBox</param>
        /// <param name="formTree">TreeView of Popup Window</param>
        /// <param name="getRootNodes">Function to get IEnumarble child nodes</param>
        public static void LoadTree(TreeView cmbTree, TreeView formTree,
            Func<int, IEnumerable<DataNode>> getRootNodes = null)
        {
            if (cmbTree.Nodes.Count > 0)
            {
                TreeNode[] myTreeNodeArray = new TreeNode[cmbTree.Nodes.Count];
                cmbTree.Nodes.CopyTo(myTreeNodeArray, 0);
                var selectedNode = cmbTree.SelectedNode;
                cmbTree.Nodes.Clear();
                formTree.Nodes.AddRange(myTreeNodeArray);

                if (selectedNode != null)
                {
                    formTree.SelectedNode = selectedNode;
                }
            }
            else
            {
                IntitialFillTree(formTree, getRootNodes);
            }
        }

        /// <summary>
        /// Saves TreeView with expanded or selected  nodes
        /// </summary>
        /// <param name="cmbTree">TreeView of CombBox</param>
        /// <param name="formTree">TreeView of Popup Window</param>
        public static void SaveTreeNodes(TreeView cmbTree, TreeView formTree)
        {
            var selectedNode = formTree.SelectedNode;
            cmbTree.Nodes.Clear();
            // Create an array of 'TreeNodes'.
            TreeNode[] myTreeNodeArray = new TreeNode[formTree.Nodes.Count];
            // Copy the tree nodes to the 'myTreeNodeArray' array.
            formTree.Nodes.CopyTo(myTreeNodeArray, 0);
            // Remove all the tree nodes from the 'myTreeViewBase' TreeView.
            formTree.Nodes.Clear();
            // Add the 'myTreeNodeArray' to the 'myTreeViewCustom' TreeView.
            cmbTree.Nodes.AddRange(myTreeNodeArray);
            cmbTree.SelectedNode = selectedNode;
        }

        /// <summary>
        /// Generates DataTable with checked nodes
        /// </summary>
        /// <returns>DataTable with two columns: ID and Text</returns>
        public static DataTable GenerateDataTable(TreeView tree)
        {
            DataTable tableOut = new DataTable();
            tableOut.Columns.Add("ID", typeof(int));
            tableOut.Columns.Add("Text", typeof(string));

            var selectedNodes = tree.Nodes.Descendants().Where(n => n.Checked).ToList();
            for (int i = 0; i < selectedNodes.Count; i++)
            {
                tableOut.Rows.Add(tableOut.NewRow());
                tableOut.Rows[i]["ID"] = selectedNodes[i].Tag;
                tableOut.Rows[i]["Text"] = selectedNodes[i].Text;
            }
            return tableOut;
        }



        /// <summary>
        /// Fills whole TreeView at once
        /// </summary>
        /// <param name="tree">TreeView to fill</param>
        /// /// <param name="items">IEnumarble child nodes</param>
        public static void IntitialWholeFillTree(TreeView tree, IEnumerable<DataNode> items)
        {
            TreeNode tnRoot = new TreeNode();
            PopulateWholeChildren(ref tnRoot, items, tree);
            if (tnRoot.Nodes.Count > 0)
            {
                tnRoot.Expand();
            }
        }

        /// <summary>
        /// Adds all nodes to parent root node in recursion
        /// </summary>
        private static void PopulateWholeChildren(ref TreeNode node, IEnumerable<DataNode> items, TreeView tree)
        {
            if (string.IsNullOrEmpty(node.Text))
            {
                node = new TreeNode();
                node.Text = root;
                node.Tag = emptyValue;
                tree.Nodes.Add(node);

                var childItems = items.Where(t => t.ParentId == 0).OrderBy(i => i.Text);
                foreach (var item in childItems)
                {
                    var child = new TreeNode()
                    {
                        Text = item.Text,
                        Tag = item.Id,
                    };
                    node.Nodes.Add(child);
                    PopulateWholeChildren(ref child, items, tree);

                }
            }
            else
            {
                var id = (int)node.Tag;
                var childItems = items.Where(t => t.ParentId == id).OrderBy(i => i.Text);
                foreach (var item in childItems)
                {
                    var child = new TreeNode()
                    {
                        Text = item.Text,
                        Tag = item.Id,
                    };
                    node.Nodes.Add(child);
                    PopulateWholeChildren(ref child, items, tree);

                }
            }
        }

        /// <summary>
        /// Fills whole TreeView at once without root node
        /// </summary>
        /// <param name="tree">TreeView to fill</param>
        /// /// <param name="items">IEnumarble child nodes</param>
        public static void IntitialWholeFillTreeWORoot(TreeView tree, IEnumerable<DataNode> items)
        {
            tree.Nodes.Clear();

            foreach (var item in items)
            {
                if (item.ParentId == 0)
                {
                    TreeNode tnParent = new TreeNode();
                    tnParent.Text = item.Text;
                    tnParent.Tag = item.Id;
                    tnParent.Collapse();
                    tree.Nodes.Add(tnParent);
                    PopulateWholeChildren(ref tnParent, items, tree);
                }
            }
        }



    }
}
