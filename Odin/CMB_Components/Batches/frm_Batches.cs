using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Odin.CMB_Components.Batches
{
    public partial class frm_Batches : KryptonForm
    {
        public frm_Batches()
        {
            InitializeComponent();
        }

        public frm_Batches(cmb_Batches cmb)
        {
            InitializeComponent();
            f = new cmb_Batches();
            cmb = f;

        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Batches f;

        public void FillHeading(int _IsProject)
        {
            kryptonHeaderGroup1.ValuesPrimary.Heading = _IsProject == -1 ? "Batch projects" : "Batches";
        }

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Batches)cmb_BatchOne).txt_Batch.Text = gv_List.CurrentRow.Cells["cn_batches"].Value.ToString();
                ((cmb_Batches)cmb_BatchOne).BatchId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg, int ActiveOnly, int IsProject, int IsGroup)
        {
            gv_List.ThreadSafeCall(delegate
            {
                DataTable data = IsGroup == -1
                    ? ActiveOnly == 0 ? CMB_BLL.getBatchesGroups(Beg) : CMB_BLL.getBatchesGroupsActiveOnly(Beg)
                    : IsProject == 0
                        ? ActiveOnly == 0 ? CMB_BLL.getBatches(Beg) : CMB_BLL.getBatchesActiveOnly(Beg)
                        : ActiveOnly == 0 ? CMB_BLL.getBatchesProject(Beg) : CMB_BLL.getBatchesProjectActiveOnly(Beg);
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
            });
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
