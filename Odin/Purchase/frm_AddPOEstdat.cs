using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;


namespace Odin.Purchase
{
    public partial class frm_AddPOEstdat : KryptonForm
    {
        public frm_AddPOEstdat()
        {
            InitializeComponent();
        }

        #region Variables

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public string Estdat
        {
            get { return txt_Estdat.Value.ToShortDateString(); }
            set
            {
                try { txt_Estdat.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }
        #endregion

        #region Methods


        public void CheckEmpty()
        {
            btn_OK.Enabled = Estdat != "";
        }

        #endregion

        #region Controls

        #endregion


        private void frm_AddPOEstdat_Load(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
