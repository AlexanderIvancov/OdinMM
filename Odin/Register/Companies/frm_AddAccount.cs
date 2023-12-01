using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Register.Companies
{
    public partial class frm_AddAccount : KryptonForm
    {
        public frm_AddAccount()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }
        public int FirmId
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int BankId
        {
            get { return cmb_Banks1.BankId; }
            set { cmb_Banks1.BankId = value; }
        }

        public int CurrencyId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        public string Account
        {
            get { return txt_Account.Text; }
            set { txt_Account.Text = value; }

        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
            
        public int AsDefault
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
        #endregion

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Account.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}
