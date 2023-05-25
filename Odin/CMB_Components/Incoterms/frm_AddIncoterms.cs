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

namespace Odin.CMB_Components.Incoterms
{
    public partial class frm_AddIncoterms : KryptonForm
    {
        public frm_AddIncoterms()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }
        public string Incoterms
        {
            get { return txt_Incoterms.Text; }
            set { txt_Incoterms.Text = value; }
        }

        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Incoterms.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }
        
    }
}
