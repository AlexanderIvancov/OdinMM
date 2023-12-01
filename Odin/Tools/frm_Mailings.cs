using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.Tools
{
    public partial class frm_Mailings : KryptonForm
    {
        public frm_Mailings()
        {
            InitializeComponent();
        }

        class_Global globClass = new class_Global();
        Tools_BLL BLL = new Tools_BLL();

        public void FillTypesList()
        {
            var data = Tools_BLL.getMailingsTypes();

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

        public void FillMailList(int _typeid)
        {
            var data = Tools_BLL.getMailings(_typeid);

            gv_MailList.ThreadSafeCall(delegate
            {

                gv_MailList.AutoGenerateColumns = false;
                bs_MailList.DataSource = data;
                gv_MailList.DataSource = bs_MailList;

            });


            bn_MailList.ThreadSafeCall(delegate
            {
                bn_MailList.BindingSource = bs_MailList;
            });

        }

        private void frm_Mailings_Load(object sender, EventArgs e)
        {
            FillTypesList();
        }

        private void btn_AddGroup_Click(object sender, EventArgs e)
        {
            frm_AddMailType frm = new frm_AddMailType();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                BLL.SaveMailingType(0, frm.Description);
                FillTypesList();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _description = "";
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _description = gv_List.CurrentRow.Cells["cn_description"].Value.ToString();
            }
            catch { }

            frm_AddMailType frm = new frm_AddMailType();
            frm.Description = _description;


            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                BLL.SaveMailingType(_id, frm.Description);
                FillTypesList();
            }

        }

       
        private void btn_EditEmails_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _typeid = 0;
            string _addresses = "";
            try
            {
                _id = Convert.ToInt32(gv_MailList.CurrentRow.Cells["cn_mid"].Value);
                _typeid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _addresses = gv_MailList.CurrentRow.Cells["cn_memails"].Value.ToString();
            }
            catch { }

            if (_id != 0
                && String.IsNullOrEmpty(_addresses) == false)
            {
                frm_AddMail frm = new frm_AddMail();
                frm.Addresses = _addresses;
                frm.HeaderText = "Edit email addresses";

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BLL.SaveMailing(_id, _typeid, frm.Addresses);
                    FillMailList(_typeid);
                }

            }

        }

        private void btn_AddEmail_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddMail frm = new frm_AddMail();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BLL.SaveMailing(0, _id, frm.Addresses);
                    FillMailList(_id);
                }

            }
        }

        private void btn_DeleteEmail_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _typeid = 0;
            try
            {
                _id = Convert.ToInt32(gv_MailList.CurrentRow.Cells["cn_mid"].Value);
                _typeid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {
                BLL.DeleteMailing(_id);

                FillMailList(_typeid);
            }
         }
        

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }
            FillMailList(_id);
        }
    }
}
