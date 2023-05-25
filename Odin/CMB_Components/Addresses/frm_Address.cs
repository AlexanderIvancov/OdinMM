using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;
using Odin.Register;


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
                ((cmb_Address)cmb_AddressOne).txt_Address.Text = gv_List.CurrentRow.Cells["cn_address"].Value.ToString();
                ((cmb_Address)cmb_AddressOne).AddressId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        class_Global glob_Class = new class_Global();
        Reg_BLL Bll = new Reg_BLL();
        
        bool _showingModal = false;
        cmb_Address f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void FillData(int FirmId, int Legal, int DelivPlace)
        {
            var data = Reg_BLL.getAddresses(FirmId, Legal, DelivPlace);

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
