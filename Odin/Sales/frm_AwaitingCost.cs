using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;

namespace Odin.Sales
{
    public partial class frm_AwaitingCost : KryptonForm
    {
        public frm_AwaitingCost()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CO_BLL COBll = new CO_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
    }
}
