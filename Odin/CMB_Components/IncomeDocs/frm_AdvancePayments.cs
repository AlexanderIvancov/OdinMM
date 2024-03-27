using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.IncomeDocs
{
    public partial class frm_AdvancePayments : KryptonForm
    {
        public frm_AdvancePayments()
        {
            InitializeComponent();
        }
        CMB_BLL Bll = new CMB_BLL();
        class_Global glob_Class = new class_Global();
        public int HeadId { get; set; }

        public void FillAdvances(int headid)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectIncomeDocAdvances", headid);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddAdvance frm = new frm_AddAdvance();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Helper.getSP("sp_AddIncomeDocAdvance", HeadId, frm.Amount, frm.CurId, frm.CurDate, frm.Rate);
                FillAdvances(HeadId);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id  = 0;
            double _amount = 0;
            int _curid = 0;
            string _curdate = "";
            double _rate = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _amount = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_amount"].Value);
                _curid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value);
                _curdate = gv_List.CurrentRow.Cells["cn_paydate"].Value.ToString();
                _rate = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_currate"].Value);
            }
            catch { }
            if (_id != 0)
            {
                frm_AddAdvance frm = new frm_AddAdvance();
                frm.Amount = _amount;
                frm.CurId = _curid;
                frm.CurDate = _curdate;
                frm.Rate = _rate;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Helper.getSP("sp_EditIncomeDocAdvance", _id, frm.Amount, frm.CurId, frm.CurDate, frm.Rate);
                    FillAdvances(HeadId);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                
            }
            catch { }
            if (_id != 0 && glob_Class.DeleteConfirm() == true)
            {
                Helper.getSP("sp_DeleteIncomeDocAdvance", _id);
                FillAdvances(HeadId);
            }
        }
    }
}