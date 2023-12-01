using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Banks
{
    public partial class frm_Banks : KryptonForm
    {
        public frm_Banks(cmb_Banks cmb)
        {
            InitializeComponent();
            f = new cmb_Banks();
            cmb = f;
        }

        public frm_Banks()
        {
            InitializeComponent();
        }
            class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Banks f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Banks)cmb_BankOne).txt_Bank.Text = gv_List.CurrentRow.Cells["cn_banks"].Value.ToString();
                ((cmb_Banks)cmb_BankOne).BankId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getBanks(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddBank frm = new frm_AddBank();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddBank(frm.Bank, frm.Iban, frm.Address, frm.Comments);
                FillData(frm.Bank);
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
                frm_AddBank frm = new frm_AddBank();

                

                frm.Id = _id;
                frm.Bank = gv_List.CurrentRow.Cells["cn_banks"].Value.ToString();
                frm.HeaderText = "Edit bank: " + frm.Bank;
                frm.Iban = gv_List.CurrentRow.Cells["cn_iban"].Value.ToString();
                frm.Address= gv_List.CurrentRow.Cells["cn_address"].Value.ToString();
                frm.Comments= gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditBank(frm.Id, frm.Bank, frm.Iban, frm.Address, frm.Comments);
                    FillData(frm.Bank);
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
                Bll.DeleteBank(_id);
                FillData(string.Empty);
            }
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
