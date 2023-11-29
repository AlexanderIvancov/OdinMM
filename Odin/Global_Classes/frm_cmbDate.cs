using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;


namespace Odin.Global_Classes
{
    public partial class frm_cmbDate : KryptonForm
    {
        public frm_cmbDate()
        {
            InitializeComponent();
        }

        public string Date
        {
            get { return txt_Date.Value.ToShortDateString(); }
            set
            {
                try { txt_Date.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
    }
}
