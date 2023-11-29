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

namespace Odin.Global_Classes
{
    public partial class frm_Print : KryptonForm
    {
        public frm_Print()
        {
            InitializeComponent();
        }

        #region variables

        public string IP_Address
        {
            get { return cmb_LabPrinter1.IP_Adress; }
            set { cmb_LabPrinter1.IP_Adress = value; }
        }
        public int Printer_DPI
        {
            get { return cmb_LabPrinter1.PrinterDPI; }
            set { cmb_LabPrinter1.PrinterDPI = value; }
        }
        public string PrinterName
        {
            get { return cmb_LabPrinter1.PrinterName; }
            set { cmb_LabPrinter1.PrinterName = value; }
        }
        public int LabelQty
        {
            get {
                try { return Convert.ToInt32(txt_Qty.Text); }
                catch { return 1; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        #endregion
    }
}
