using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;

namespace Odin.Register.Companies
{
    public partial class ctl_Banks : UserControl
    {
        public ctl_Banks()
        {
            InitializeComponent();
        }
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL BLL = new Reg_BLL();

        public int Id
        {
            get;
            set;
        }

        int _FirmId = 0;

        public int FirmId
        {
            get { return cmb_Firms1.FirmId; }
            set
            {
                _FirmId = value;
                FillAccounts(_FirmId);
            }
        }
        public void FillAccounts(int Firmid)
        {
            var data = Reg_BLL.getAccounts(Firmid);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddAccount frm = new frm_AddAccount();
            frm.HeaderText = "Add new account for: " + cmb_Firms1.Firm;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = BLL.AddAccount(FirmId, frm.BankId, frm.CurrencyId, frm.Account, frm.AsDefault, frm.Comments);

                FillAccounts(FirmId);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_AddAccount frm = new frm_AddAccount();

                frm.Id = _id;

                BLL.AccountId = _id;
                frm.FirmId = FirmId;
                frm.BankId = BLL.BankId;
                frm.CurrencyId = BLL.BankCurId;
                frm.Account = BLL.BankAccount;
                frm.AsDefault = BLL.BankAsDefault;
                frm.Comments = BLL.BankComments;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BLL.EditAccount(frm.Id, frm.FirmId, frm.BankId, frm.CurrencyId, frm.Account, frm.AsDefault, frm.Comments);

                    FillAccounts(FirmId);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                BLL.DeleteAccount(_id);
                FillAccounts(FirmId);
            }
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            FirmId = cmb_Firms1.FirmId;
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            BLL.AccountId = _id;
        }
    }
}
