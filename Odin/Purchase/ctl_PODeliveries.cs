using Odin.Global_Classes;
using System.Windows.Forms;

namespace Odin.Purchase
{
    public partial class ctl_PODeliveries : UserControl
    {
        public ctl_PODeliveries()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return khg_Header.ValuesPrimary.Heading; }
            set { khg_Header.ValuesPrimary.Heading = value; }
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
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectPODeliveries", POId);

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