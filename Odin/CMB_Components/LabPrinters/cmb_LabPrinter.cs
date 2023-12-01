using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.LabPrinters
{
    public delegate void PrinterNameEventHandler(object sender);
    public delegate void PrinterIPEventHandler(object sender);

    public partial class cmb_LabPrinter : UserControl
    {
        public event PrinterNameEventHandler PrinterNameChanged;
        public event PrinterIPEventHandler PrinterIPChanged;


        PopupWindowHelper PopupHelper = null;

        class_Global Glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        PrinterEventArgs args = new PrinterEventArgs();

        public class PrinterEventArgs : EventArgs
        {

        }

        public string IP_Adress
        {
            get { return txt_Ip.Text; }
            set { txt_Ip.Text = value; }
        }

        public string PrinterName
        {
            get { return txt_Name.Text; }
            set { txt_Name.Text = value; }
        }
        int _PrinterDPI = 203;
        public int PrinterDPI
        {
            get { return _PrinterDPI; }
            set { _PrinterDPI = value; }
        }


        public cmb_LabPrinter()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PrinterNameChanged != null)
                    PrinterNameChanged(this);
            }
            catch { return; }
        }

        private void txt_Ip_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PrinterIPChanged != null)
                    PrinterIPChanged(this);
            }
            catch { return; }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_LabPrinters popup = new frm_LabPrinters();
            popup.cmb_LabPrinterOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData();
        }

        private void cmb_LabPrinter_Load(object sender, EventArgs e)
        {
            
        }

        public void ShowDefaults()
        {
            Bll.ShowDefaultPrinter();
            PrinterName = Bll.DefPrinter;
            IP_Adress = Bll.DefIPPrinter;
            PrinterDPI = Bll.DefPrinterDPI;
        }
    }
}
