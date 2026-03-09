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


namespace Odin.CMB_Components.Activities
{
    public partial class frm_AddActivity : KryptonForm
    {
        public frm_AddActivity()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }
        public string Activity
        {
            get { return txt_Activity.Text; }
            set { txt_Activity.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Activity.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}
