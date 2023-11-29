using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Odin.Global_Classes;
using Odin.Warehouse.Movements;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;

namespace Odin.Warehouse.Reports
{
    public partial class frm_OutcomeReports : KryptonForm
    {
        public frm_OutcomeReports()
        {
            InitializeComponent();
        }


        private void txt_CreatDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateFrom.Value = txt_CreatDateFrom.Value == null ? System.DateTime.Now : txt_CreatDateFrom.Value;
        }

        private void txt_CreatDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateTill.Value = txt_CreatDateTill.Value == null ? System.DateTime.Now : txt_CreatDateTill.Value;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
