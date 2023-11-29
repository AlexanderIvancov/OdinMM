using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Bargains
{
    public partial class frm_Bargains : KryptonForm
    {
        public frm_Bargains()
        {
            InitializeComponent();
        }

        public frm_Bargains(cmb_Bargain cmb)
        {
            InitializeComponent();
            f = new cmb_Bargain();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Bargain f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Bargain)cmb_BargainOne).txt_Bargain.Text = gv_List.CurrentRow.Cells["cn_bargain"].Value.ToString();
                ((cmb_Bargain)cmb_BargainOne).BargainCode = gv_List.CurrentRow.Cells["cn_code"].Value.ToString();
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getBargains(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddBargain frm = new frm_AddBargain();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddBargain(frm.Bargain, frm.IntrastatCode, frm.BargainLat);
                FillData(frm.Bargain);
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
            string _bargain = "";
            string _bargainlat = "";
            string _intrastatcode = "";


            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _bargain = gv_List.CurrentRow.Cells["cn_bargain"].Value.ToString();
                _bargainlat = gv_List.CurrentRow.Cells["cn_bargainlat"].Value.ToString();
                _intrastatcode = gv_List.CurrentRow.Cells["cn_code"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_AddBargain frm = new frm_AddBargain();
                frm.Id = _id;
                frm.Headertext = "Edit bargain: " + _bargain;
                frm.Bargain = _bargain;
                frm.IntrastatCode = _intrastatcode;
                frm.BargainLat = _bargainlat;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditBargain(frm.Id, frm.Bargain, frm.IntrastatCode, frm.BargainLat);
                    FillData(frm.Bargain);
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
                Bll.DeleteBargain(_id);
                FillData(string.Empty);
            }
        }
    }
}
