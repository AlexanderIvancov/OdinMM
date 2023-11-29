using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public partial class frm_AddSerialAnalog : KryptonForm
    {
        public frm_AddSerialAnalog()
        {
            InitializeComponent();
        }
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int AnalogAsPrimary
        {
            get
            {
                return chk_analogasprimary.Checked == true ? -1 : 0;
            }
            set
            {
                chk_analogasprimary.Checked = value == -1;
            }
        }

        public int Id
        { get; set; }

        public string SerialNumber
        {
            get { return txt_Serial.Text; }
            set { txt_Serial.Text = value; }
        }

        public string Analogue
        {
            get { return txt_Analog.Text; }
            set { txt_Analog.Text = value; }
        }
        private void frm_AddSerialAnalog_Activated(object sender, EventArgs e)
        {
            txt_Serial.Focus();
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Serial.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Analog.Text = string.Empty;
        }

        private void txt_Serial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_Analog.Focus();

            }

        }
    }
}
