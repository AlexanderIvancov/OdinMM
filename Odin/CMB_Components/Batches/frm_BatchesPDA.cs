using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Batches
{
    public partial class frm_BatchesPDA : KryptonForm
    {
        public frm_BatchesPDA()
        {
            InitializeComponent();
        }

        public frm_BatchesPDA(cmb_BatchPDA cmb)
        {
            InitializeComponent();
            f = new cmb_BatchPDA();
            cmb = f;
        }


        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_BatchPDA f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_BatchPDA)cmb_BatchOne).txt_Batch.Text = gv_List.CurrentRow.Cells["cn_batches"].Value.ToString();
                ((cmb_BatchPDA)cmb_BatchOne).BatchId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getBatches(Beg);

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
