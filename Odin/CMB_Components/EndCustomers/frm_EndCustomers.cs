using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.EndCustomers
{
    public partial class frm_EndCustomers : KryptonForm
    {
        public frm_EndCustomers()
        {
            InitializeComponent();
        }

        public frm_EndCustomers(cmb_EndCustomer cmb)
        {
            InitializeComponent();
            f = new cmb_EndCustomer();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_EndCustomer f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void FillData(string Beg)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_EndCustomersSelectLike", Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_EndCustomer)cmb_EndCustomerOne).txt_EndCustomer.Text = gv_List.CurrentRow.Cells["cn_customers"].Value.ToString();
                ((cmb_EndCustomer)cmb_EndCustomerOne).EndCustomerId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_cmbText frm = new frm_cmbText();
            frm.HeaderText = "Add new end customer";
            frm.LabelText = "End customer: ";
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Convert.ToInt32(Helper.getSP("sp_AddEndCustomer", frm.FormText));
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
                frm.HeaderText = "Edit end customer ";
                frm.LabelText = "End customer: ";
                frm.FormText = gv_List.CurrentRow.Cells["cn_customers"].Value.ToString();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Helper.getSP("sp_EditEndCustomer", _id, frm.FormText);
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
                Helper.getSP("sp_DeleteEndCustomer", _id);
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