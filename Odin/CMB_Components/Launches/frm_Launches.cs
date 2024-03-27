using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Launches
{
    public partial class frm_Launches : KryptonForm
    {
        public frm_Launches()
        {
            InitializeComponent();
        }

        public frm_Launches(cmb_Launches cmb)
        {
            InitializeComponent();
            f = new cmb_Launches();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Launches f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Launches)cmb_LaunchOne).txt_Launch.Text = gv_List.CurrentRow.Cells["cn_launches"].Value.ToString();
                ((cmb_Launches)cmb_LaunchOne).LaunchId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
                if (Convert.ToInt32(row.Cells["cn_started"].Value) == -1)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.LightSkyBlue;
        }

        public void FillData(string Beg)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_LaunchSelectLike", Beg);

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