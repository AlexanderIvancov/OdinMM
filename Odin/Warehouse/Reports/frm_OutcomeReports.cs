using ComponentFactory.Krypton.Toolkit;
using System;

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
