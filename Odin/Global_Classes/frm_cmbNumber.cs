using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Global_Classes
{
    public partial class frm_cmbNumber : KryptonForm
    {
        public frm_cmbNumber()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public double FormNumber
        {
            get
            {
                try { return Convert.ToDouble(txt_Number.Text); }
                catch { return 0; }
            }
            set { txt_Number.Text = value.ToString(); }
        }

        public int Id
        { get; set; }

        public string LabelText
        {
            get { return lbl_Text.Text; }
            set { lbl_Text.Text = value; }
        }
    }
}
