using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Warehouse.StockIn;
using System.ComponentModel;

namespace Odin.Warehouse.Deliveries
{
    public partial class frm_AddArticleForDelivery : KryptonForm
    {
        public frm_AddArticleForDelivery()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
        }

        public string HeaderText
        {
            get { return kryptonHeaderGroup1.ValuesPrimary.Heading; }
            set { kryptonHeaderGroup1.ValuesPrimary.Heading = value; }
        }

        ProgressForm wait;

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        public int ArtId
        {
            get; set;
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            var data1 = StockIn_BLL.getStockInArticleDelivery(ArtId);

            gv_Delivery.ThreadSafeCall(delegate
            {
                gv_Delivery.AutoGenerateColumns = false;
                bs_Delivery.DataSource = data1;
                gv_Delivery.DataSource = bs_Delivery;

            });

        }

        public void ShowDets()
        {
            bwStart(bw_List);
        }
    }
}
