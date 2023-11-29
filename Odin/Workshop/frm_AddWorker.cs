using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public partial class frm_AddWorker : KryptonForm
    {
        public frm_AddWorker()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return txt_Name.Text; }
            set { txt_Name.Text = value; }
        }
        public string UserSurName
        {
            get { return txt_SurName.Text; }
            set { txt_SurName.Text = value; }
        }
        public string RFID
        {
            get { return txt_RFID.Text; }
            set { txt_RFID.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int IsActive
        {
            get
            {
                return chk_IsActive.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_IsActive.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int IsMaster
        {
            get
            {
                return chk_ismaster.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_ismaster.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }
        public string UserTabNR
        {
            get { return txt_TabelNR.Text; }
            set { txt_TabelNR.Text = value; }
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = (String.IsNullOrEmpty(UserName) != true
                || String.IsNullOrEmpty(UserSurName) != true)
                && String.IsNullOrEmpty(UserTabNR) != true;
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            txt_RFID.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny8_Click(object sender, EventArgs e)
        {
            txt_TabelNR.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Name.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_SurName.Text = string.Empty;
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_SurName_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_TabelNR_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_Comments_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
