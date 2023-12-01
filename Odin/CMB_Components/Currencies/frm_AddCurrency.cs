using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.Currencies
{
    public partial class frm_AddCurrency : KryptonForm
    {
        public frm_AddCurrency()
        {
            InitializeComponent();
        }
        #region Variables

        public int Id
        { get; set; }
        public string Currency
        {
            get { return txt_Currency.Text; }
            set { txt_Currency.Text = value; }
        }

        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }

        public string Symbol
        {
            get { return txt_Symbol.Text; }
            set { txt_Symbol.Text = value; }
        }

        #endregion

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }
    }
}
