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


namespace Odin.Register.Companies
{
    public partial class frm_AddContacts : KryptonForm
    {
        public frm_AddContacts()
        {
            InitializeComponent();
        }

        #region Variables

        public string HeaderText
        { get; set; }

        public int Id
        { get; set; }

        public int FirmId
        { get; set; }

        public string FullName
        {
            get { return txt_FullName.Text; }
            set { txt_FullName.Text = value; }
        }

        public string JobTitle
        {
            get { return txt_JobTitle.Text; }
            set { txt_JobTitle.Text = value; }

        }

        public string Email
        {
            get { return txt_Email.Text; }
            set { txt_Email.Text = value; }
        }

        public string Phone
        {
            get { return txt_Phone.Text; }
            set { txt_Phone.Text = value; }
        }

        public string Fax
        {
            get { return txt_Fax.Text; }
            set { txt_Fax.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_FullName.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_JobTitle.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Email.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Phone.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_Fax.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        public void CheckEmpty()
        {
            if (String.IsNullOrEmpty(FullName) == true)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        private void txt_FullName_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
