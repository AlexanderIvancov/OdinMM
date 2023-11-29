using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Odin.Global_Classes
{
    public static class ExtMethods
    {
        /// <summary>
        /// Traverses all children for Parent Node Collection
        /// </summary>
        public static IEnumerable<TreeNode> Descendants(this TreeNodeCollection c)
        {
            foreach (var node in c.OfType<TreeNode>())
            {
                yield return node;

                foreach (var child in node.Nodes.Descendants())
                {
                    yield return child;
                }
            }
        }

        public static void AppendText(this RichTextBox richTextBox, string text, Font font)
        {
            richTextBox.Select(richTextBox.TextLength, 0);

            richTextBox.SelectionFont = font;
            richTextBox.AppendText(text);
            richTextBox.SelectionFont = richTextBox.Font;
        }
    }
}
