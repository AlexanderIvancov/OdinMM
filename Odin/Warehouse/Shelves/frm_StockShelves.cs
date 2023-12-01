using ComponentFactory.Krypton.Toolkit;
using System;

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
