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
namespace Odin.CMB_Components.Units
{
    public partial class frm_Units : KryptonForm
    {
        


        public frm_Units()
        {
            InitializeComponent();
            //ControlBox = false;
            //Text = "";
        }

        public frm_Units(cmb_Units cmb)
        {
            InitializeComponent();
            f = new cmb_Units();
            cmb = f;
        }

        

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Units f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
       
                
        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Units)cmb_UnitOne).txt_Unit.Text = gv_List.CurrentRow.Cells["cn_Units"].Value.ToString();
                ((cmb_Units)cmb_UnitOne).UnitId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddCharUnit frm = new frm_AddCharUnit();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddUnit(frm.Unit, frm.Description, frm.UnitDecs, frm.UnitLat, frm.BaseUnitid, frm.CoefConv);
                FillData(frm.Unit);
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
                frm_AddCharUnit frm = new frm_AddCharUnit();
                frm.Id = _id;
                frm.Unit = gv_List.CurrentRow.Cells["cn_Units"].Value.ToString();
                frm.Description = gv_List.CurrentRow.Cells["cn_description"].Value.ToString();
                frm.UnitDecs = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_decims"].Value);
                frm.UnitLat = gv_List.CurrentRow.Cells["cn_UnitLat"].Value.ToString();
                frm.BaseUnitid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_baseunitid"].Value);
                frm.CoefConv = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_coefconv"].Value);

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditUnit(frm.Id, frm.Unit, frm.Description, frm.UnitDecs, frm.UnitLat, frm.BaseUnitid, frm.CoefConv);
                    FillData(frm.Unit);
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
                Bll.DeleteUnit(_id);
                FillData(string.Empty);
            }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getUnits(Beg);

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
