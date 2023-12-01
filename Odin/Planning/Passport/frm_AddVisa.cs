using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Planning.Passport
{
    public partial class frm_AddVisa : KryptonForm
    {
        public frm_AddVisa()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = "";
        }

        public void CheckEmpty()
        {
            if (txt_Comments.Text == "")
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        private void txt_Comments_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
