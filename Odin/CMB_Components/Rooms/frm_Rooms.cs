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


namespace Odin.CMB_Components.Rooms
{
    public partial class frm_Rooms : KryptonForm
    {
        public frm_Rooms()
        {
            InitializeComponent();
        }

        public frm_Rooms(cmb_Rooms cmb)
        {
            InitializeComponent();
            f = new cmb_Rooms();
            cmb = f;
        }

        public void ChangeCMBElements()
        {
            //try
            //{
                //((cmb_Rooms)cmb_RoomOne).txt_Room.Text = gv_List.CurrentRow.Cells["cn_room"].Value.ToString();
                ((cmb_Rooms)cmb_RoomOne).RoomId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            //}
            //catch { }
        }

        class_Global glob_Class = new class_Global();
        Reg_BLL Bll = new Reg_BLL();
        
        bool _showingModal = false;
        cmb_Rooms f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void FillData(int Placeid)
        {
            var data = Reg_BLL.getRooms(Placeid);

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
