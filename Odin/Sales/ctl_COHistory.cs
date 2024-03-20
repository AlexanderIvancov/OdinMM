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

        int _COId = 0;

        public int COId
        {
            get { return _COId; }
            set
            {
                _COId = value;
                FillHistory(_COId);
            }
        }

        public void FillHistory(int COId)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectCOHistory", COId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
            });

            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }
    }
}