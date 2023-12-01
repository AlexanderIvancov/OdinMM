using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Package
{
    public partial class frm_Packages : KryptonForm
    {
        public frm_Packages()
        {
            InitializeComponent();
        }

        public frm_Packages(cmb_Packages cmb)
        {
            InitializeComponent();
            f = new cmb_Packages();
            cmb = f;
        }


        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Packages f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Packages)cmb_PackageOne).txt_Packages.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_Packages)cmb_PackageOne).PackageId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getPackage(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddPackage frm = new frm_AddPackage();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddPackage(frm.Package, frm.VolumeWeight);
                FillData(frm.Package);
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
                frm_AddPackage frm = new frm_AddPackage();
                frm.Id = _id;
                frm.Package = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                frm.VolumeWeight = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_volweight"].Value.ToString());

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditPackage(frm.Id, frm.Package, frm.VolumeWeight);
                    FillData(frm.Package);
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
                Bll.DeletePackage(_id);
                FillData(string.Empty);
            }
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
