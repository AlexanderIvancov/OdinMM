using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Purchase
{
    public partial class frm_EditPOneed : KryptonForm
    {
        public frm_EditPOneed()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }


        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            this.txt_Comments.Text = string.Empty;
        }
    }
}
