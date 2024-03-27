using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.PayTerms
{
    public partial class frm_Payterms : KryptonForm
    {
        public frm_Payterms()
        {
            InitializeComponent();
        }

        public frm_Payterms(cmb_Payterms cmb)
        {
            InitializeComponent();
            f = new cmb_Payterms();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Payterms f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Payterms)cmb_PaytermOne).txt_Payterm.Text = gv_List.CurrentRow.Cells["cn_payterms"].Value.ToString();
                ((cmb_Payterms)cmb_PaytermOne).PaytermsId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_PaytermsSelectLike", Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddPayterm frm = new frm_AddPayterm();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Convert.ToInt32(Helper.getSP("sp_AddPayterm", frm.Payterms, frm.PaytermsLat, frm.Description));
                FillData(frm.Payterms);
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
                frm_AddPayterm frm = new frm_AddPayterm();
                frm.Id = _id;
                frm.Payterms = gv_List.CurrentRow.Cells["cn_payterms"].Value.ToString();
                frm.PaytermsLat = gv_List.CurrentRow.Cells["cn_paytermslat"].Value.ToString();
                frm.Description = gv_List.CurrentRow.Cells["cn_description"].Value.ToString();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Helper.getSP("sp_EditPayterm", frm.Id, frm.Payterms, frm.PaytermsLat, frm.Description);
                    FillData(frm.Payterms);
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
                Helper.getSP("sp_DeletePayterm", _id);
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