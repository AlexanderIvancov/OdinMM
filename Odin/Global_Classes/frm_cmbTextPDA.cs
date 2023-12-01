using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Global_Classes
{
    public partial class frm_cmbTextPDA : KryptonForm
    {
        public frm_cmbTextPDA()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string FormText
        {
            get { return txt_Text.Text; }
            set { txt_Text.Text = value; }
        }

        public int Id
        { get; set; }

        public string LabelText
        {
            get { return lbl_Text.Text; }
            set { lbl_Text.Text = value; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Text.Text = string.Empty;
        }

        private void frm_cmbTextPDA_Activated(object sender, EventArgs e)
        {
            txt_Text.Focus();
        }

        private void txt_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
