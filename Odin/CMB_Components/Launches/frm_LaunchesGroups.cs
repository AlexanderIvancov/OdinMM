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

namespace Odin.CMB_Components.Launches
{
    public partial class frm_LaunchesGroups : KryptonForm
    {
        public frm_LaunchesGroups()
        {
            InitializeComponent();
        }

        public frm_LaunchesGroups(cmb_Launches cmb)
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
                ((cmb_LaunchGroups)cmb_LaunchOne).txt_LaunchGroup.Text = gv_List.CurrentRow.Cells["cn_launchgroups"].Value.ToString();
                
            }
            catch { }
        }
        
        public void FillData(string Beg)
        {
            var data = CMB_BLL.getLaunchGroups(Beg);

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
