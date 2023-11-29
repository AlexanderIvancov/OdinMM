using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

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
            get
            {
                return chk_Default.CheckState == CheckState.Checked ? -1 : 0;
            }
            set { chk_Default.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked; }
        }

        private void CheckEmpty()
        {
            btn_OK.Enabled = PrinterName != ""
                && IP_Address != "";
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
