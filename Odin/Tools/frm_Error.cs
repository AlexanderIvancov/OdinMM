using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Purchase;
using Odin.Global_Classes;
using Odin.CustomControls;
using Owf.Controls;

namespace Odin.Tools
{
    public partial class frm_Error : Form
    {
        public frm_Error()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return lbl_Message.Text; }
            set { lbl_Message.Text = value; }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Error_Load(object sender, EventArgs e)
        {
            txt_Focus.Focus();
        }

        private void frm_Error_Activated(object sender, EventArgs e)
        {
            txt_Focus.Focus();
        }
    }
}
