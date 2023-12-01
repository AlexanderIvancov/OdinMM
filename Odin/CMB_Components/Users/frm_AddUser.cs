using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Users
{
    public partial class frm_AddUser : KryptonForm
    {
        public frm_AddUser()
        {
            InitializeComponent();
        }
        #region Variables
        public string HeaderText
        {
            get { return this.Text; }
            set{ this.Text = value; }
        }

        public int Id
        { get; set; }
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
        public string UserLogin
        {
            get { return txt_UserLogin.Text; }
            set { txt_UserLogin.Text = value; }
        }
        public int IsDBUser
        {
            get { if (chk_IsDBUser.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set { if (value == -1)
                    chk_IsDBUser.CheckState = CheckState.Checked;
                else
                    chk_IsDBUser.CheckState = CheckState.Unchecked;
                }
        }
        public string UserEmail
        {
            get { return txt_Email.Text; }
            set { txt_Email.Text = value; }
        }
        public string UserLang
        {
            get { return cmb_Lang.Text; }
            set { cmb_Lang.Text = value; }
        }
        public string UserJob
        {
            get { return txt_Job.Text; }
            set { txt_Job.Text = value; }
        }

        public string UserInitials
        {
            get { return txt_Initials.Text; }
            set { txt_Initials.Text = value; }
        }

        public string UserShortName
        {
            get { return txt_ShortName.Text; }
            set { txt_ShortName.Text = value; }
        }

        public int UserDeptId
        {
            get { return cmb_Department1.DeptId; }
            set { cmb_Department1.DeptId = value; }
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

        public string UserPhone
        {
            get { return txt_UserPhone.Text; }
            set { txt_UserPhone.Text = value; }
        }

        public string UserFax
        {
            get { return txt_UserFax.Text; }
            set { txt_UserFax.Text = value; }
        }

        public string UserTabNR
        {
            get { return txt_TabelNR.Text; }
            set { txt_TabelNR.Text = value; }
        }



        #endregion
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Name.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_SurName.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_UserLogin.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Email.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_UserPhone.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_UserFax.Text = string.Empty;
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            txt_Job.Text = string.Empty;
        }

        private void buttonSpecAny9_Click(object sender, EventArgs e)
        {
            txt_Initials.Text = string.Empty;
        }

        public void CheckEmpty()
        {
            if (String.IsNullOrEmpty(UserName) == true
                && String.IsNullOrEmpty(UserSurName) == true)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_SurName_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void buttonSpecAny10_Click(object sender, EventArgs e)
        {
            txt_ShortName.Text = string.Empty;
        }
    }
}
