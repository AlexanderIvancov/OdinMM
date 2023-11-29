using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

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
