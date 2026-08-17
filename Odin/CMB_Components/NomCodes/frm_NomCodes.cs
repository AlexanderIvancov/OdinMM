using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;


namespace Odin.CMB_Components.NomCodes
{
    public partial class frm_NomCodes : KryptonForm
    {
        public frm_NomCodes()
        {
            InitializeComponent();
        }

        public frm_NomCodes(cmb_NomCodes cmb)
        {
            InitializeComponent();
            f = new cmb_NomCodes();
            cmb = f;
        }
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_NomCodes f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getNomCodes(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_NomCodes)cmb_NomCodesOne).txt_NomCodes.Text = gv_List.CurrentRow.Cells["cn_nomcode"].Value.ToString();
                ((cmb_NomCodes)cmb_NomCodesOne).NomCodesId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
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
