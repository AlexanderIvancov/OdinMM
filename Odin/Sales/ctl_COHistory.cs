using Odin.Global_Classes;
using System.Windows.Forms;
namespace Odin.Sales
{
    public partial class ctl_COHistory : UserControl
    {
        public ctl_COHistory()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CO_BLL BLL = new CO_BLL();


        int _COId = 0;

        public int COId
        {
            get { return _COId; }
            set
            {
                //cmb_Articles1.ArticleId = value;
                _COId = value;
                FillHistory(_COId);
                //SetCellsColor();
            }
        }

        public void FillHistory(int COId)
        {
            var data = CO_BLL.getHistoryOrders(COId);

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
