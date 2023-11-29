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

namespace Odin.Warehouse.StockIn
{
    public delegate void StockInSavedEventHandler(object sender);
    public partial class frm_AddStockIn : KryptonForm
    {
        public frm_AddStockIn()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public event StockInSavedEventHandler StockInLineSaved;
        
        private void ctl_StockInDets1_SendStockInId(object sender)
        {

            if (StockInLineSaved != null)
                StockInLineSaved(this);
        }
    }
}
