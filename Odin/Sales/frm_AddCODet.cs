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
using Odin.Global_Classes;

namespace Odin.Sales
{
    public delegate void SaveChangesEventHandler(object sender);

    public partial class frm_AddCODet : KryptonForm
    {
        public frm_AddCODet()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value;}
        }

        public event SaveChangesEventHandler SaveChanges;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (SaveChanges != null)
            {
                SaveChanges(this);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
