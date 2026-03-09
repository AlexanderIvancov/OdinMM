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

namespace Odin.CRM
{
    public partial class ctl_Activities : UserControl
    {
        public ctl_Activities()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CRM_BLL BLL = new CRM_BLL();

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
                FillActivities(_FirmId);
            }
        }
        public void FillActivities(int Firmid)
        {
            var data = CRM_BLL.getActivities(Firmid);

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
            frm_AddActivity frm = new frm_AddActivity();
            frm.HeaderText = "Add new activity for: " + cmb_Firms1.Firm;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = BLL.AddActivity(FirmId, frm.ActivityId, frm.Products, frm.Comments);

                FillActivities(FirmId);
            }
        }

        public void ShowEdit()
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_AddActivity frm = new frm_AddActivity();

                frm.Id = _id;

                BLL.ActId = _id;
                frm.FirmId = BLL.ActFirmId;
                frm.ActivityId = BLL.ActActivityId;
                frm.Products = BLL.ActProducts;
                frm.Comments = BLL.ActComments;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BLL.EditActivity(frm.Id, frm.FirmId, frm.ActivityId, frm.Products, frm.Comments);

                    FillActivities(FirmId);
                }
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                BLL.DeleteActivity(_id);
                FillActivities(FirmId);
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

            BLL.ActId = _id;
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }
    }
}
