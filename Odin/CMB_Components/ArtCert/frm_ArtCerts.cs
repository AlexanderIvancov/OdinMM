using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Register;
using Odin.Register.Articles;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.ArtCerts
{
    public partial class frm_ArtCerts : KryptonForm
    {
        public frm_ArtCerts(cmb_ArtCerts cmb)
        {
            InitializeComponent();
            f = new cmb_ArtCerts();
            cmb = f;
        }

        public frm_ArtCerts()
        {
            InitializeComponent();
        }
            class_Global glob_Class = new class_Global();
        Reg_BLL Bll = new Reg_BLL();
        bool _showingModal = false;
        cmb_ArtCerts f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_ArtCerts)cmb_CertOne).txt_Cert.Text = gv_List.CurrentRow.Cells["cn_certNum"].Value.ToString();
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getCerts(Beg);

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
