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
                if (chk_IsActive.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_IsActive.CheckState = CheckState.Checked;
                else
                    chk_IsActive.CheckState = CheckState.Unchecked;
            }
        }

        public int IsMaster
        {
            get
            {
                if (chk_ismaster.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_ismaster.CheckState = CheckState.Checked;
                else
                    chk_ismaster.CheckState = CheckState.Unchecked;
            }
        }
        public string UserTabNR
        {
            get { return txt_TabelNR.Text; }
            set { txt_TabelNR.Text = value; }
        }

        public void CheckEmpty()
        {
            if ((String.IsNullOrEmpty(UserName) == true
                && String.IsNullOrEmpty(UserSurName) == true)
                || String.IsNullOrEmpty(UserTabNR) == true)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
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
