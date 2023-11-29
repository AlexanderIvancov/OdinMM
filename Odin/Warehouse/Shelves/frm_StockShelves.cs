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

namespace Odin.Warehouse.Shelves
{
    public partial class frm_StockShelves : KryptonForm
    {
        public frm_StockShelves()
        {
            InitializeComponent();
        }

        public void FillTree()
        {
            ctl_StockShelves1.Load_Root();
        }

        private void ctl_StockShelves1_Load(object sender, EventArgs e)
        {

        }
    }
}
