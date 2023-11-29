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

namespace Odin.Global_Classes
{
    public partial class frm_cmbNumber : KryptonForm
    {
        public frm_cmbNumber()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public double FormNumber
        {
            get { try { return  Convert.ToDouble(txt_Number.Text); }
                catch { return 0; } }
            set { txt_Number.Text = value.ToString(); }
        }

        public int Id
        { get; set; }

        public string LabelText
        {
            get { return lbl_Text.Text; }
            set { lbl_Text.Text = value; }
        }
    }
}
