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
    public delegate void TextEnteringEventHandler(string TextValue);
    public partial class frm_cmbTextPDA_NC : KryptonForm
    {
        public frm_cmbTextPDA_NC()
        {
            InitializeComponent();
        }

        public event TextEnteringEventHandler TextEntering;

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string FormText
        {
            get { return txt_Text.Text; }
            set { txt_Text.Text = value; }
        }

        public int Id
        { get; set; }

        public string LabelText
        {
            get { return lbl_Text.Text; }
            set { lbl_Text.Text = value; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Text.Text = string.Empty;
        }

        private void frm_cmbTextPDA_Activated(object sender, EventArgs e)
        {
            txt_Text.Focus();
        }

        private void txt_Text_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (TextEntering != null)
                    TextEntering(FormText);
                FormText = "";
                txt_Text.Focus();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (TextEntering != null)
                TextEntering(FormText);
            FormText = "";
            txt_Text.Focus();
        }
    }
}
