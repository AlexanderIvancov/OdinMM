using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.PayTerms
{
    public partial class frm_AddPayterm : KryptonForm
    {
        public frm_AddPayterm()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }
        public string Payterms
        {
            get { return txt_Payterms.Text; }
            set { txt_Payterms.Text = value; }
        }

        public string PaytermsLat
        {
            get { return txt_PayTermsLat.Text; }
            set { txt_PayTermsLat.Text = value; }
        }

        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }


        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Payterms.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }

        private void txt_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_PayTermsLat.Text = string.Empty;
        }
    }
}
