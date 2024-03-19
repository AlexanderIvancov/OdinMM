using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Addresses
{
    public partial class frm_Address : KryptonForm
    {
        public frm_Address()
        {
            InitializeComponent();
        }

        public frm_Address(cmb_Address cmb)
        {
            InitializeComponent();
            f = new cmb_Address();
            cmb = f;
        }

        public void ChangeCMBElements()
        {
            try
            {
                (cmb_AddressOne).txt_Address.Text = gv_List.CurrentRow.Cells["cn_address"].Value.ToString();
                (cmb_AddressOne).AddressId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        class_Global glob_Class = new class_Global();
        
        bool _showingModal = false;
        cmb_Address f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void FillData(int FirmId, int Legal, int DelivPlace)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_AddressesList", FirmId, Legal, DelivPlace);

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
            Close();
        }
    }
}