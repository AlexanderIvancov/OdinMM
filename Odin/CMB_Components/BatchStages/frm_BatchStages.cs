using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.BatchStages
{
    public partial class frm_BatchStages : KryptonForm
    {
        public frm_BatchStages()
        {
            InitializeComponent();
        }

        public frm_BatchStages(cmb_BatchStages cmb)
        {
            InitializeComponent();
            f = new cmb_BatchStages();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_BatchStages f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_checked"].Value) == -1)
                {
                    row.Cells["cn_name"].Style.BackColor = Color.FromArgb(192, 255, 192);
                }
                else
                {
                    row.Cells["cn_name"].Style.BackColor = Color.PapayaWhip;
                }
            }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_BatchStages)cmb_BatchStageOne).txt_Stage.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_BatchStages)cmb_BatchStageOne).StageId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(int BatchId, int IsLaunches)
        {
            DataTable data;
            if (IsLaunches == 0)
                data = CMB_BLL.getBatchStages(BatchId);
            else
                data = CMB_BLL.getBatchLaunchesStages(BatchId);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;


            SetCellsColor();

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
