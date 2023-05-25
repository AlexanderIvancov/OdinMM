using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;

namespace Odin.CMB_Components.Users
{
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }

        public frm_Users(cmb_Users cmb)
        {
            InitializeComponent();
            f = new cmb_Users();
            f = cmb;
        }

        cmb_Users f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getUsers(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Users)cmb_UserOne).txt_User.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_Users)cmb_UserOne).UserId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddUser frm = new frm_AddUser();
            DialogResult result = frm.ShowDialog();
            frm.HeaderText = "Add new user";

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.SaveUser(0, frm.UserName, frm.UserSurName, frm.UserLogin, frm.IsDBUser, frm.UserEmail, frm.UserLang,
                                        frm.UserPhone, frm.UserFax, frm.UserJob, frm.UserInitials, frm.UserDeptId, frm.UserTabNR, 
                                        frm.IsActive, frm.UserShortName);
                FillData(frm.UserName + " " + frm.UserSurName);
            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                Bll.UserId = _id;
                frm_AddUser frm = new frm_AddUser();

                frm.HeaderText = "Edit user:" + Bll.UserName + " " + Bll.UserSurName;
                frm.UserName = Bll.UserName;
                frm.UserSurName = Bll.UserSurName;
                frm.UserLogin = Bll.UserLogin;
                frm.IsDBUser = Bll.IsDBUser;
                frm.UserEmail = Bll.UserEmail;
                frm.UserLang = Bll.UserLang;
                frm.UserJob = Bll.UserJob;
                frm.UserInitials = Bll.UserInitials;
                frm.UserDeptId = Bll.UserDeptId;
                frm.IsActive = Bll.UserIsActive;
                frm.UserPhone = Bll.UserPhone;
                frm.UserFax = Bll.UserFax;
                frm.UserTabNR = Bll.UserTabNR;
                frm.UserShortName = Bll.UserShortName;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    int _res = Bll.SaveUser(_id, frm.UserName, frm.UserSurName, frm.UserLogin, frm.IsDBUser, frm.UserEmail, frm.UserLang,
                                            frm.UserPhone, frm.UserFax, frm.UserJob, frm.UserInitials, frm.UserDeptId, frm.UserTabNR,
                                            frm.IsActive, frm.UserShortName);
                    FillData(frm.UserName + " " + frm.UserSurName);
                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true)
            {
                Bll.DeleteUser(_id);
                FillData(string.Empty);
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void btn_Security_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                Bll.UserId = _id;
                //if (Bll.UserLogin.ToLower().Trim() != Bll.UserCurrent.ToLower().Trim()/*System.Environment.UserName.ToLower()*/)
                //{
                //    _showingModal = false;
                //    MessageBox.Show("You can not change password for user with different login! Current user: " + Bll.UserCurrent.ToLower() + ", login to change: " + Bll.UserLogin.ToLower());
                //}
                //else
                //{
                    frm_EmailPassword frm = new frm_EmailPassword();

                    frm.HeaderText = "Edit email password for programm for:" + Bll.UserName + " " + Bll.UserSurName;
                    frm.UserLogin = Bll.UserLogin;
                   
                    DialogResult result = frm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        _showingModal = false;
                        Bll.EncryptMailPassword(_id, frm.Password);
                        
                        FillData(Bll.UserName + " " + Bll.UserSurName);
                    }
                    if (result == DialogResult.Cancel)
                    {
                        _showingModal = false;
                    }
                //}
            }
        }
    }
}
