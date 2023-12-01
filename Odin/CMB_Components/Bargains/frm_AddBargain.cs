using ComponentFactory.Krypton.Toolkit;
using System;


namespace Odin.CMB_Components.Bargains
{
    public partial class frm_AddBargain : KryptonForm
    {
        public frm_AddBargain()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }

        public string Headertext
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Bargain
        {
            get { return txt_Bargain.Text; }
            set { txt_Bargain.Text = value; }
        }

        public string IntrastatCode
        {
            get { return txt_IntrastatCode.Text; }
            set { txt_IntrastatCode.Text = value; }
        }

        public string BargainLat
        {
            get { return txt_BargainLat.Text; }
            set { txt_BargainLat.Text = value; }
        }

        public void CheckEmpty()
        {
            if (txt_Bargain.Text == ""
                || txt_BargainLat.Text == ""
                || String.IsNullOrEmpty(Bargain) == true
                || String.IsNullOrEmpty(BargainLat) == true)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }


        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Bargain.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_BargainLat.Text = string.Empty;
        }

        private void txt_Bargain_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_BargainLat_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
