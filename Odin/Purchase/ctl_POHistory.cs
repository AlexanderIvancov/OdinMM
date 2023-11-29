using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Purchase;

namespace Odin.Purchase
{
    public partial class ctl_POHistory : UserControl
    {
        public ctl_POHistory()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        PO_BLL BLL = new PO_BLL();


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
            var data = PO_BLL.getHistoryOrders(POId);

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
