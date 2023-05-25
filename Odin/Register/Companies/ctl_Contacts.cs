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
    public partial class ctl_Contacts : UserControl
    {
        public ctl_Contacts()
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
                FillContacts(_FirmId);
            }
        }
        public void FillContacts(int Firmid)
        {
            var data = Reg_BLL.getContacts(FirmId);

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


        private void cmb_Firms1_FirmsChanged(object sender)
        {
            FirmId = cmb_Firms1.FirmId;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddContacts frm = new frm_AddContacts();
            frm.HeaderText = "Add contact for:" + cmb_Firms1.Firm;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = BLL.AddContact(FirmId, frm.FullName, frm.JobTitle, frm.Email, frm.Phone, frm.Fax, frm.Comments);

                FillContacts(FirmId);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_AddContacts frm = new frm_AddContacts();

                frm.Id = _id;

                BLL.ContactId = _id;
                frm.FirmId = FirmId;
                frm.FullName = BLL.ContFullName;
                frm.JobTitle = BLL.ContJobTitle;
                frm.Email = BLL.ContEmail;
                frm.Phone = BLL.ContPhone;
                frm.Fax = BLL.ContFax;
                frm.Comments = BLL.ContComments;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BLL.EditContact(frm.Id, FirmId, frm.FullName, frm.JobTitle, frm.Email, frm.Phone, frm.Fax, frm.Comments);

                    FillContacts(FirmId);
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
                BLL.DeleteContact(_id);
                FillContacts(FirmId);
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            BLL.ContactId = _id;
        }
    }
}
