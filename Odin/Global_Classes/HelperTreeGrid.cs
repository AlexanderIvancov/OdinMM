using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdvancedDataGridView;

namespace Odin.Global_Classes
{
    public class HelperTreeGrid
    {
        static Font boldFont;
        private static string example = "Example";

        /// <summary> 
        /// Updates child nodes for all parent nodes which equl to article
        /// </summary> 
        public static void UpdateNodeValues(TreeGridNode ancestorNode, string ancestorRefAxon,
            ref List<TreeGridNode> foundNodes, TreeGridView gv)
        {
            var cn_ID = Convert.ToString(ancestorNode.Cells[14].Value);
            List<TreeGridNode> insertNodes = new List<TreeGridNode>();
            boldFont = new Font(gv.DefaultCellStyle.Font, FontStyle.Bold);

            foundNodes = new List<TreeGridNode>();
            FindUpdateNodes(gv.Nodes, ancestorRefAxon, ref foundNodes);

            var xzx = ancestorNode.Cells[12].Value.ToString();
            var xcxc = ancestorNode.Cells[1].Value.ToString();

            //copies all child nodes from current parent node in to the new list
            foreach (var n in ancestorNode.Nodes)
            {
                insertNodes.Add(n);
            }




            foreach (var parent in foundNodes)
            {

                if (parent.Cells[14].Value.ToString() != cn_ID)
                {
                    //clear child nodes
                    parent.Nodes.Clear();

                    //inserts required nodes
                    foreach (var n in insertNodes)
                    {
                        var newNode = new TreeGridNode();
                        parent.Nodes.Add(newNode);

                        if (n.HasChildren)
                        {
                            newNode.DefaultCellStyle.Font = boldFont;
                            newNode.DefaultCellStyle.ForeColor = Color.Red;
                            newNode.Nodes.Add(null, example);
                        }

                        for (int i = 0; i < n.Cells.Count; i++)
                        {
                            newNode.Cells[i].Value = n.Cells[i].Value;
                        }

                        newNode.Cells[14].Value = Guid.NewGuid();

                    }

                }

            }
        }

        /// <summary> 
        /// Finds nodes which equal required Axon Reference
        /// </summary> 
        public static void FindUpdateNodes(IEnumerable<TreeGridNode> nodes, string refAxon,
            ref List<TreeGridNode> foundNodes)
        {
            foreach (TreeGridNode node in nodes)
            {
                // cn_RefAxon column value
                if (node.Cells[1].Value != example)
                {
                    // cn_NO_RefAxon column value
                    var value = node.Cells[1].Value.ToString();

                    // if not found requred node
                    if (value == refAxon)// && node.HasChildren)
                    {
                        //currentNode = node;
                        foundNodes.Add(node);
                    }

                    FindUpdateNodes(node.Nodes, refAxon, ref foundNodes);
                }
            }

        }

        /// <summary> 
        /// Expands/collapses all nodes 
        /// </summary> 
        public static void expandCollapseNodes(IEnumerable<TreeGridNode> nodes, bool isCollapse)
        {
            foreach (TreeGridNode node in nodes)
            {
                if (isCollapse)
                {
                    node.Collapse();
                }
                else
                {
                    node.Expand();
                }

                expandCollapseNodes(node.Nodes, isCollapse);
            }
        }

        /// <summary> 
        /// Updates nodes numbers sequence
        /// </summary> 
        public static void RefreshNodesSequence(TreeGridNodeCollection nodes)
        {
            int n = 1;
            foreach (TreeGridNode child in nodes)
            {
                child.Cells[3].Value = n;
                n++;
            }
        }

        public static void RemoveNode(TreeGridNodeCollection nodes, TreeGridNode nodeToRemove)
        {
            nodes.Remove(nodeToRemove);
            //overwrites sequence numbers
            RefreshNodesSequence(nodes);
        }

        public static TreeGridNode InsertNode(TreeGridNodeCollection nodes, TreeGridView gv)
        {
            TreeGridNode nodeToAdd = new TreeGridNode();
            var currentNode = gv.CurrentNode;

            nodes.Insert(currentNode.Index + 1, nodeToAdd);
            return nodeToAdd;
        }

        public static TreeGridNode InsertNode(TreeGridNodeCollection nodes, TreeGridNode node)
        {
            TreeGridNode nodeToAdd = new TreeGridNode();
            nodes.Insert(0, node);
            return nodeToAdd;
        }

        public static void ChangeNodePosition(TreeGridNodeCollection nodes, TreeGridNode currentNode, int index, TreeGridView gv)
        {
            TreeGridNode nodeToAdd = new TreeGridNode();

            var array = new ArrayList();
            boldFont = new Font(gv.DefaultCellStyle.Font, FontStyle.Bold);

            foreach (DataGridViewCell item in currentNode.Cells)
            {
                array.Add(item.Value);
            }

            nodes.Remove(currentNode);
            nodes.Insert(index, nodeToAdd);


            nodeToAdd.SetValues(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7],
                  array[8], array[9], array[10], array[11], array[12], array[13], array[14], array[15], array[16]);


            if (currentNode.HasChildren)
            {
                nodeToAdd.DefaultCellStyle.Font = boldFont;
                nodeToAdd.DefaultCellStyle.ForeColor = Color.Red;
                nodeToAdd.Nodes.Add(null, example);
            }
        }

        public static TreeGridNode InsertNode(TreeGridNodeCollection nodes, TreeGridView gv, TreeGridNode nodeToAdd)
        {
            var currentNode = gv.CurrentNode;

            nodes.Insert(currentNode.Index + 1, nodeToAdd);
            return nodeToAdd;
        }

        /// <summary> 
        /// Finds child node
        /// </summary> 
        public static bool isFoundNode(TreeGridNodeCollection nodes, string s_Value, string s_Cell)
        {
            return nodes.Any(t => t.Cells[s_Cell].Value.ToString() == s_Value);
        }

        /// <summary> 
        /// Removes fake node
        /// </summary> 
        public static void RemoveExampleNode(TreeGridNode node)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].Cells[1].Value != null)
                {
                    if (node.Nodes[i].Cells[1].Value.ToString() != example) continue;
                    node.Nodes.Remove(node.Nodes[i]);
                    break;
                }
            }
        }
    }
}
