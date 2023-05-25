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
using ComponentFactory.Krypton.Ribbon;

namespace Odin.Tools
{
    public partial class frm_AddMail : KryptonForm
    {
        public frm_AddMail()
        {
            InitializeComponent();
        }

        public string Addresses
        {
            get { return txt_Address.Text; }
            set { txt_Address.Text = value; }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Address.Text = string.Empty;
        }
    }
}
