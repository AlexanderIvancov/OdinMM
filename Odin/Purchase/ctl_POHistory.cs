using Odin.Global_Classes;
using System.Windows.Forms;

namespace Odin.Purchase
{
    public partial class ctl_POHistory : UserControl
    {
        public ctl_POHistory()
        {
            InitializeComponent();
        }

        int _POId = 0;
        public int POId
        {
            get { return _POId; }
            set
            {
                //cmb_Articles1.ArticleId = value;
                _POId = value;
                FillHistory(_POId);
                //SetCellsColor();
            }
        }

        public void FillHistory(int POId)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectPOHistory", POId);

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