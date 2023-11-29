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



namespace Odin.Sales.DeliveryPlanning
{
    public partial class frm_DeliveryItemDets : KryptonForm
    {
        public frm_DeliveryItemDets()
        {
            InitializeComponent();
        }

        public string ItemText
        {
            get { return txt_Text.Text; }
            set { txt_Text.Text = value; }
        }
    }
}
