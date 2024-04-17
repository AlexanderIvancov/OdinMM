using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Odin.CMB_Components.FreezedReason
{
    public partial class frm_FreezedReason : KryptonForm
    {
        public frm_FreezedReason()
        {
            InitializeComponent();
        }

        public frm_FreezedReason(cmb_FreezedReason cmb)
        {
            InitializeComponent();
            f = new cmb_FreezedReason();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_FreezedReason f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_FreezedReason)cmb_FreezedReason).txt_FreezedReason.Text = gv_List.CurrentRow.Cells["cn_description"].Value.ToString();
                ((cmb_FreezedReason)cmb_FreezedReason).FreezedReasonId = (Int32)gv_List.CurrentRow.Cells["cn_code"].Value;
            }
            catch { }
        }

        public void FillData()
        {
            DataTable data = CMB_BLL.getFreezedReasons();
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
