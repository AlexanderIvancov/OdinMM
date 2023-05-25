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


namespace Odin.CMB_Components.CustCodes
{
    public partial class frm_AddCustCode : KryptonForm
    {
        public frm_AddCustCode()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }
        public string CustCode
        {
            get { return txt_CustCode.Text; }
            set { txt_CustCode.Text = value; }
        }

        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_CustCode.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }
    }
}
