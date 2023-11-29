using Odin.Global_Classes;
using System.Windows.Forms;

namespace Odin.Warehouse.Requests.Controls
{
    public partial class ctl_ReqHistory : UserControl
    {
        public ctl_ReqHistory()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Requests_BLL BLL = new Requests_BLL();

        string __Request = "";

        public string Request
        {
            get { return __Request; }
            set
            {
                //cmb_Articles1.ArticleId = value;
                __Request = value;
                FillHistory(__Request);
                //SetCellsColor();
            }
        }

        public void FillHistory(string request)
        {
            var data = Requests_BLL.getHistoryRequests(request);

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
