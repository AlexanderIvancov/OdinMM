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
