using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;

namespace Odin.Warehouse.Inventory
{
    public partial class frm_SeparateLabels : KryptonForm
    {
        public frm_SeparateLabels()
        {
            InitializeComponent();
        }

        public double QtyOnLabel
        { get; set; }

        public double NewQty
        {
            get { try { return Convert.ToDouble(txt_NewQty.Text); }
                catch { return 0; }
                }
            set { txt_NewQty.Text = value.ToString();  }
        }

        public double QtyLabels
        {
            get
            {
                try { return Convert.ToInt32(txt_QtyLabels.Text); }
                catch { return 0; }
            }
            set { txt_QtyLabels.Text = value.ToString(); }
        }

        public int SeparType
        {
            get {
                if (rb_Once.Checked == true)
                    return 1;
                else
                    return 2;
            }
            set {
                if (value == 1)
                {
                    rb_Once.Checked = true;
                    rb_Multiple.Checked = false;
                    QtyLabels = 1;
                    txt_QtyLabels.Enabled = false;
                }
                else
                {
                    rb_Once.Checked = false;
                    rb_Multiple.Checked = true;
                    txt_QtyLabels.Enabled = true;

                }
            }
        }

        private void rb_Once_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Once.Checked == true)
                SeparType = 1;
            else
                SeparType = 2;
        }

        private void rb_Multiple_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Once.Checked == true)
                SeparType = 1;
            else
                SeparType = 2;
        }

        private void txt_NewQty_Validated(object sender, EventArgs e)
        {
           
            if (SeparType == 2)
            {
                QtyLabels = (Int32)(QtyOnLabel / NewQty);
            }
        }

        private void txt_QtyLabels_Validated(object sender, EventArgs e)
        {
            int _MaxLabels = (Int32)(QtyOnLabel / NewQty);
            if (QtyLabels > _MaxLabels)
                QtyLabels = _MaxLabels;

        }

        private void txt_NewQty_TextChanged(object sender, EventArgs e)
        {
            if (NewQty > QtyOnLabel)
            {
                MessageBox.Show("Quantity can not be more than old quantity on label!");
                NewQty = QtyOnLabel;
            }
        }
    }
}
