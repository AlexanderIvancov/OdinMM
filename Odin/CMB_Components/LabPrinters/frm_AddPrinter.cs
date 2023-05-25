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
using Odin.Global_Classes;

namespace Odin.CMB_Components.LabPrinters
{
    public partial class frm_AddPrinter : KryptonForm
    {
        public frm_AddPrinter()
        {
            InitializeComponent();
        }

        class_Global GlobClass = new class_Global();
        #region Variables

        public int Id
        {
            get;
            set;
        }

        public string PrinterName
        {
            get { return txt_Name.Text; }
            set { txt_Name.Text = value; }
        }
        public string IP_Address
        {
            get { return txt_IP.Text; }
            set { txt_IP.Text = value; }
        }
        public int Default
        {
            get { if (chk_Default.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set { if (value == -1)
                    chk_Default.CheckState = CheckState.Checked;
                else
                    chk_Default.CheckState = CheckState.Unchecked; }
        }

        private void CheckEmpty()
        {
            if (PrinterName == ""
                || IP_Address == "")
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }
        
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Name.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_IP.Text = string.Empty;
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_IP_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
