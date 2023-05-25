using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;

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
