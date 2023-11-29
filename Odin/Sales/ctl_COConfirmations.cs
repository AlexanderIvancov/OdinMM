using Odin.Global_Classes;
using System;
using System.Windows.Forms;
namespace Odin.Sales
{
    public partial class ctl_COConfirmations : UserControl
    {
        public ctl_COConfirmations()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CO_BLL COBll = new CO_BLL();

        int _prevcoid = 0;
        int _coid = 0;
        public int COId
        {
            get { return cmb_SalesOrdersWithLines1.SalesOrderLineId; }
            set
            {

                _coid = value;
                FillConfirmations(_coid);
                COBll.COId = _coid;

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

        public double _ConfBefore()
        {
            double _res = 0;

            foreach (DataGridViewRow row in gv_List.Rows)
            {
                _res = _res + Convert.ToDouble(row.Cells["cn_confirmqty"].Value);
            }

            return _res;
        }

        public void FillConfirmations(int _COId)
        {
            var data = CO_BLL.getCOConfirmations(_COId);

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddCOConfirmation frm = new frm_AddCOConfirmation();


            frm.Qty = COBll.COQty - _ConfBefore();
            frm.ConfDate = System.DateTime.Now.ToShortDateString();//COBll.COReqDate;
            frm.DelivPlaceId = COBll.CODelivPlaceId;
            frm.DelivAddressId = COBll.CODelivAddressId;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = COBll.AddCOConfirmation(COId, frm.Qty, frm.ConfDate, frm.Comments, frm.DelivPlaceId, frm.DelivAddressId);

                FillConfirmations(COId);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_AddCOConfirmation frm = new frm_AddCOConfirmation();
            frm.HeaderText = "Edit CO confirmation for " + cmb_SalesOrdersWithLines1.SalesOrder + " / " + cmb_SalesOrdersWithLines1.SalesOrderLine;
            frm.Qty = COBll.ConfQty;
            frm.ConfDate = COBll.ConfDate;
            frm.Comments = COBll.ConfComments;
            frm.DelivPlaceId = COBll.ConfDelivPlaceId;
            frm.DelivAddressId = COBll.ConfAddressId;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                COBll.EditCOConfirmation(COBll.ConfId, COId, frm.Qty, frm.ConfDate, frm.Comments, frm.DelivPlaceId, frm.DelivAddressId);

                FillConfirmations(COId);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _confid = 0;

            try { _confid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { _confid = 0; }

            if (glob_Class.DeleteConfirm() == true)
            {
                COBll.DeleteCOConfirmation(_confid);
                FillConfirmations(COId);
            }
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

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            try { ConfId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { ConfId = 0; }
        }
    }
}
