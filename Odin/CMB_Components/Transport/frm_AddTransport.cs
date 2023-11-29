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

namespace Odin.CMB_Components.Transport
{
    public partial class frm_AddTransport : KryptonForm
    {
        public frm_AddTransport()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }

        public string Headertext
        {
            get { return this.Text; }
            set{ this.Text = value; }
        }

        public string Transport
        {
            get { return txt_Transport.Text; }
            set { txt_Transport.Text = value; }
        }

        public string IntrastatCode
        {
            get { return txt_IntrastatCode.Text; }
            set { txt_IntrastatCode.Text = value; }
        }

        public string TransType
        {
            get { return txt_TransType.Text; }
            set { txt_TransType.Text = value; }
        }

        public void CheckEmpty()
        {
            if (txt_Transport.Text == ""
                || String.IsNullOrEmpty(Transport) == true)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }
        #endregion


        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Transport.Text = string.Empty;
        }

        private void txt_Transport_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
