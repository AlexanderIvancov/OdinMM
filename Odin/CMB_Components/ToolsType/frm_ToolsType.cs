using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.ToolsType
{
    public partial class frm_ToolsType : KryptonForm
    {
        public frm_ToolsType()
        {
            InitializeComponent();
        }

        public frm_ToolsType(cmb_ToolsType cmb)
        {
            InitializeComponent();
            f = new cmb_ToolsType();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_ToolsType f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }


        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_ToolsType)cmb_ToolsTypeOne).txt_ToolsType.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_ToolsType)cmb_ToolsTypeOne).ToolsTypeId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getToolsType(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddToolsType frm = new frm_AddToolsType();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddToolsType(frm.ToolsType);
                FillData(frm.ToolsType);
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
                frm_AddToolsType frm = new frm_AddToolsType();
                frm.Id = _id;
                frm.ToolsType = Bll.ToolsType;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditToolsType(frm.Id, frm.ToolsType);
                    FillData(frm.ToolsType);
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
                Bll.DeleteToolsType(_id);
                FillData(string.Empty);
            }
        }
    }
}
