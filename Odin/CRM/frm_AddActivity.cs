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

namespace Odin.CRM
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
        public int FirmId
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int ActivityId
        {
            get { return cmb_Activities1.ActivityId; }
            set { cmb_Activities1.ActivityId = value; }
        }

        public string Products
        {
            get { return txt_Products.Text; }
            set { txt_Products.Text = value; }

        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
            
        
        #endregion

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Products.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}
