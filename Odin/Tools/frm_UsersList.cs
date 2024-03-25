using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.CMB_Components.Users;
using Odin.Global_Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Tools
{
    public partial class frm_UsersList : KryptonForm
    {
        public frm_UsersList()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "UsersList.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        Tools_BLL Bll = new Tools_BLL();
        CMB_BLL Bllc = new CMB_BLL();
        CMB_BLL Bll1 = new CMB_BLL();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int _PrevId = 0;
        
        public int UserId
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_isactive"].Value) != -1)
                    row.DefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }

        public void FillList()
        {
            var data = (DataTable)Helper.getSP("sp_UsersList");

            gv_List.ThreadSafeCall(delegate
            {

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
                SetCellsColor();
                
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
 
        }

        private bool CheckOldRow()
        {

            try
            {
                UserId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                UserId = 0;
            }

            if (_PrevId == UserId)
            {
                return true;
            }
            else
            {
                _PrevId = UserId;
                return false;
            }
        }

        #region Context menu


        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_List.ClearSelection();
                gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColor();
        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_List;
            frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();

        }

        private void mni_FilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? String.IsNullOrEmpty(CellValue) == true
                        ? "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'"
                    : String.IsNullOrEmpty(CellValue) == true
                        ? bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();


        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'"
                    : bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            
        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for confirmation orders list";
            frm.grid = this.gv_List;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                Helper.LoadColumns(gv_List, this.Name);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }


        #endregion
        #endregion

        #region Controls

        private void cmb_Users1_UserChanged(object sender)
        {
            FillList();
        }
        private void frm_UsersList_Load(object sender, EventArgs e)
        {
            Helper.LoadColumns(gv_List, this.Name);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                Helper.getSP("sp_DeleteUser", _id);
                FillList();
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                //cmb_Users1.UserId = UserId;
            }
        }


        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillList();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                Bllc.UserId = _id;
                if (Bllc.UserLogin.ToLower().Trim() != Bllc.UserCurrent.ToLower().Trim()
                    /*Bllc.UserLogin != System.Environment.UserName*/)
                {
                    MessageBox.Show("You can not change password for user with different login! Current user: " + Bllc.UserCurrent.ToLower() + ", login to change: " + Bllc.UserLogin.ToLower());
                    //MessageBox.Show("You can not change password for user with different login!");
                }
                else
                {
                    frm_EmailPassword frm = new frm_EmailPassword();

                    frm.HeaderText = "Edit email password for programm for:" + Bllc.UserName + " " + Bllc.UserSurName;
                    frm.UserLogin = Bllc.UserLogin;

                    DialogResult result = frm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        Bllc.EncryptMailPassword(_id, frm.Password);
                    }
                    if (result == DialogResult.Cancel)
                    {
                        
                    }
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                Bll1.UserId = _id;
                frm_AddUser frm = new frm_AddUser();

                frm.HeaderText = "Edit user:" + Bll1.UserName + " " + Bll1.UserSurName;
                frm.UserName = Bll1.UserName;
                frm.UserSurName = Bll1.UserSurName;
                frm.UserLogin = Bll1.UserLogin;
                frm.IsDBUser = Bll1.IsDBUser;
                frm.UserEmail = Bll1.UserEmail;
                frm.UserLang = Bll1.UserLang;
                frm.UserJob = Bll1.UserJob;
                frm.UserInitials = Bll1.UserInitials;
                frm.UserDeptId = Bll1.UserDeptId;
                frm.IsActive = Bll1.UserIsActive;
                frm.UserPhone = Bll1.UserPhone;
                frm.UserFax = Bll1.UserFax;
                frm.UserTabNR = Bll1.UserTabNR;
                frm.UserShortName = Bll1.UserShortName;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                   
                    int _res = Bll1.SaveUser(_id, frm.UserName, frm.UserSurName, frm.UserLogin, frm.IsDBUser, frm.UserEmail, frm.UserLang,
                                            frm.UserPhone, frm.UserFax, frm.UserJob, frm.UserInitials, frm.UserDeptId, frm.UserTabNR,
                                            frm.IsActive, frm.UserShortName);
                    FillList();
                }
                
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser();
            DialogResult result = frm.ShowDialog();
            frm.HeaderText = "Add new user";

            if (result == DialogResult.OK)
            {
                int _res = Bll1.SaveUser(0, frm.UserName, frm.UserSurName, frm.UserLogin, frm.IsDBUser, frm.UserEmail, frm.UserLang,
                                        frm.UserPhone, frm.UserFax, frm.UserJob, frm.UserInitials, frm.UserDeptId, frm.UserTabNR,
                                        frm.IsActive, frm.UserShortName);
                FillList();
            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
