using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Tools
{
    public partial class frm_TemplateExportDataDGV : KryptonForm
    {
        public frm_TemplateExportDataDGV()
        {
            InitializeComponent();
        }

        private void chk_CheckAll_CheckStateChanged(object sender, EventArgs e)
        {
            chk_CheckAll.Text = chk_CheckAll.Checked ? "Uncheck All" : "Check All";
        }
    }
}
