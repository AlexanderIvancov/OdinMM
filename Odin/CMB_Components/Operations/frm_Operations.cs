using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Operations
{
    public partial class frm_Operations : KryptonForm
    {
        public frm_Operations()
        {
            InitializeComponent();
        }

        public frm_Operations(cmb_Operations cmb)
        {
            InitializeComponent();
            f = new cmb_Operations();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Operations f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getOperations(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        public void ChangeCMBElements()
        {
            //try
            //{
            ((cmb_Operations)cmb_OperationOne).txt_Operation.Text = gv_List.CurrentRow.Cells["cn_operation"].Value.ToString();
            ((cmb_Operations)cmb_OperationOne).OperationId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            // }
            // catch { }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddOperation frm = new frm_AddOperation();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddOperation(frm.Operation, frm.Formula);
                FillData(frm.Operation);
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
                frm_AddOperation frm = new frm_AddOperation();
                frm.Operation = gv_List.CurrentRow.Cells["cn_operation"].Value.ToString();
                frm.Formula = gv_List.CurrentRow.Cells["cn_formula"].Value.ToString();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditOperation(_id, frm.Operation, frm.Formula);
                    FillData(frm.Operation);
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
                Bll.DeleteOperation(_id);
                FillData(string.Empty);
            }
        }
    }
}
