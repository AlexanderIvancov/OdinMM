using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.Banks
{
    public partial class frm_AddBank : KryptonForm
    {
        public frm_AddBank()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }

        public string HeaderText
        { get { return this.Text; }
        set { this.Text = value; }
        }
        public string Bank
        { get { return txt_Bank.Text; }
        set { txt_Bank.Text = value; }
        }
        public string Iban
        {
            get { return txt_Iban.Text; }
            set { txt_Iban.Text = value; }
        }
        public string Address
        {
            get { return txt_Address.Text; }
            set { txt_Address.Text = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Bank.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Iban.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Address.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}
