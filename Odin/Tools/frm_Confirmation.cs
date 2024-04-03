using System;
using System.Windows.Forms;

namespace Odin.Tools
{
    public partial class frm_Confirmation : Form
    {
        public frm_Confirmation()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return lbl_Message.Text; }
            set { lbl_Message.Text = value; }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Confirmation_Load(object sender, EventArgs e)
        {
            lbl_Message.Focus();
        }

        private void frm_Confirmation_Activated(object sender, EventArgs e)
        {
            lbl_Message.Focus();
        }
    }
}
