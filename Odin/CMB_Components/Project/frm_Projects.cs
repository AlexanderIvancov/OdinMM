using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Project
{
    public partial class frm_Projects : KryptonForm
    {
        public frm_Projects()
        {
            InitializeComponent();
        }

        public frm_Projects(cmb_Projects cmb)
        {
            InitializeComponent();
            f = new cmb_Projects();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Projects f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Projects)cmb_ProjectOne).txt_Project.Text = gv_List.CurrentRow.Cells["cn_project"].Value.ToString();
                ((cmb_Projects)cmb_ProjectOne).ProjectId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_ProjectsSelectLike", Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_cmbText frm = new frm_cmbText();
            frm.LabelText = "Project:";
            frm.HeaderText = "Add new project";
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Convert.ToInt32(Helper.getSP("sp_AddProject", frm.FormText));
                FillData(frm.FormText);
            }
            if (result == DialogResult.Cancel)
                _showingModal = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_cmbText frm = new frm_cmbText();
                frm.Id = _id;
                frm.LabelText = "Project:";
                frm.HeaderText = "Edit project";
                frm.FormText = gv_List.CurrentRow.Cells["cn_project"].Value.ToString();
                
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Helper.getSP("sp_EditProject", frm.Id, frm.FormText);
                    FillData(frm.FormText);
                }
                if (result == DialogResult.Cancel)
                    _showingModal = false;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true)
            {
                Helper.getSP("sp_DeleteProject", _id);
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
    }
}