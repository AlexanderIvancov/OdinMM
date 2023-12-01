using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
