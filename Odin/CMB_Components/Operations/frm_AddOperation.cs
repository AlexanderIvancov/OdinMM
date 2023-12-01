using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.Operations
{
    public partial class frm_AddOperation : KryptonForm
    {
        public frm_AddOperation()
        {
            InitializeComponent();
        }

        #region Variables

        public string Operation
        {
            get { return txt_Operation.Text; }
            set { txt_Operation.Text = value; }
        }

        public string Formula
        {
            get { return txt_Formula.Text; }
            set { txt_Formula.Text = value; }
        }


        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Operation.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Formula.Text = string.Empty;
        }
    }
}
