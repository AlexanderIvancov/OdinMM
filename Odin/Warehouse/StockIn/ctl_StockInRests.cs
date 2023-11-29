using Odin.Global_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Warehouse.StockIn
{
    public partial class ctl_StockInRests : UserControl
    {
        public ctl_StockInRests()
        {
            InitializeComponent();
        }

        int _id = 0;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;

                FillLabels(_id);
            }
        }

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_usage"].Value) == 0)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
                }
            }
        }

        public void FillLabels(int id)
        {
            var data = StockIn_BLL.getStockIncomeRests(id);

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

            SetCellsColor();
        }

    }
}
