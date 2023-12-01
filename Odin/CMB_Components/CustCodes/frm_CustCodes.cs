using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.CustCodes
{
    public partial class frm_CustCodes : KryptonForm
    {
        public frm_CustCodes()
        {
            InitializeComponent();
        }

        public frm_CustCodes(cmb_CustCodes cmb)
        {
            InitializeComponent();
            f = new cmb_CustCodes();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_CustCodes f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_CustCodes)cmb_CustCodeOne).txt_CustCode.Text = gv_List.CurrentRow.Cells["cn_custcodes"].Value.ToString();
                ((cmb_CustCodes)cmb_CustCodeOne).CustCodeId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddCustCode frm = new frm_AddCustCode();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddCustCode(frm.CustCode, frm.Description);
                FillData(frm.CustCode);
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
                frm_AddCustCode frm = new frm_AddCustCode();
                frm.Id = _id;
                frm.CustCode = gv_List.CurrentRow.Cells["cn_custcodes"].Value.ToString();
                frm.Description = gv_List.CurrentRow.Cells["cn_description"].Value.ToString();
               
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditCustCode(frm.Id, frm.CustCode, frm.Description);
                    FillData(frm.CustCode);
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
                Bll.DeleteCustCode(_id);
                FillData(string.Empty);
            }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getCustCodes(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

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
