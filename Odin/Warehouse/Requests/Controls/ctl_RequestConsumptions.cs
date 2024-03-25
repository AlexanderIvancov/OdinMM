using Odin.Global_Classes;
using System.Windows.Forms;

namespace Odin.Warehouse.Requests.Controls
{
    public partial class ctl_RequestConsumptions : UserControl
    {
        public ctl_RequestConsumptions()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Requests_BLL BLL = new Requests_BLL();


        int _ReqId = 0;

        public int ReqId
        {
            get { return _ReqId; }
            set
            {
                //cmb_Articles1.ArticleId = value;
                _ReqId = value;
                FillHistory(_ReqId);
                //SetCellsColor();
            }
        }

        public void FillHistory(int ReqId)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectRequestOutcomes", ReqId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                //SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

    }
}
