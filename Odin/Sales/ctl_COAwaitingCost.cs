using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.Sales
{
    public partial class ctl_COAwaitingCost : UserControl
    {
        public ctl_COAwaitingCost()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CO_BLL COBll = new CO_BLL();

        public double QtyOrdered
        {
            get {
                try { return Convert.ToDouble(txt_Ordered.Text); }
                catch { return 0; }
            }
            set { txt_Ordered.Text = value.ToString(); }
        }

        public double QtyDelivered
        {
            get
            {
                try { return Convert.ToDouble(txt_Delivered.Text); }
                catch { return 0; }
            }
            set { txt_Delivered.Text = value.ToString(); }
        }

        int _prevcoid = 0;
        int _coid = 0;
        public int COId
        {
            get { return cmb_SalesOrdersWithLines1.SalesOrderLineId; }
            set
            {
                _coid = value;
                FillDeliveries(_coid);
                COBll.COId = _coid;
                FillDets();
            }
        }

        int _confid = 0;

        public int ConfId
        {
            get { return _confid; }
            set
            {
                _confid = value;
                COBll.ConfId = _confid;
            }
        }
              
        public void FillDeliveries(int _COId)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectCODeliveries", _COId);

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

        public void FillDets()
        {
            QtyOrdered = COBll.COQty;
            QtyDelivered = COBll.COQtyDeliv;
        }
        private void cmb_SalesOrdersWithLines1_SalesOrderChanged(object sender)
        {
            if (_prevcoid != cmb_SalesOrdersWithLines1.SalesOrderLineId)

            {
                //MessageBox.Show(cmb_SalesOrdersWithLines1.SalesOrderLineId.ToString());
                COId = cmb_SalesOrdersWithLines1.SalesOrderLineId;
                _prevcoid = COId;
            }
        }
    }
}