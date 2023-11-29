using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Global_Classes
{
    public partial class frm_cmbText : KryptonForm
    {
        public frm_cmbText()
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

        private void frm_cmbText_Load(object sender, EventArgs e)
        {
            txt_Text.Focus();
        }

        private void frm_cmbText_Activated(object sender, EventArgs e)
        {
            txt_Text.Focus();
        }
    }
}
