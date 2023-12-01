using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Tools
{
    public partial class frm_AddMailType : KryptonForm
    {
        public frm_AddMailType()
        {
            InitializeComponent();
        }

        public int Type
        {
            get;set;
        }
        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }
               

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }
    }
}
