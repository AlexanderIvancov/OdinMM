using ComponentFactory.Krypton.Toolkit;
using System;


namespace Odin.Global_Classes
{
    public partial class frm_cmbDate : KryptonForm
    {
        public frm_cmbDate()
        {
            InitializeComponent();
        }

        public string Date
        {
            get { return txt_Date.Value.ToShortDateString(); }
            set
            {
                try { txt_Date.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
    }
}
