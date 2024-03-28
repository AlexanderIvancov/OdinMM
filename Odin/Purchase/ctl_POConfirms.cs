using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.Purchase
{
    public partial class ctl_POConfirms : UserControl
    {
        public ctl_POConfirms()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();

        PO_BLL POBll = new PO_BLL();

        int _prevpoid = 0;
        int _poid = 0;
        public int POId
        {
            get { return cmb_PurchaseOrdersLines1.PurchaseOrderLineId; }
            set
            {
                _poid = value;
                FillConfirmations(_poid);
                POBll.POId = _poid;

            }
        }
        int _confid = 0;
        public int ConfId
        {
            get { return _confid; }
            set
            {
                _confid = value;
                POBll.ConfId = _confid;
                //MessageBox.Show(POBll.ConfId.ToString());
            }
        }

        public double _ConfBefore()
        {
            double _res = 0;

            foreach (DataGridViewRow row in gv_List.Rows)
                _res = _res + Convert.ToDouble(row.Cells["cn_confirmqty"].Value);

            return _res;
        }

        public void FillConfirmations(int _POId)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectPOConfirmations", _POId);

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
            frm_AddPOConfirmation frm = new frm_AddPOConfirmation();


            frm.Qty = POBll.POQty - _ConfBefore();
            frm.ConfDate = POBll.POReqDate;
            frm.FillType();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = Convert.ToInt32(Helper.getSP("sp_AddPOConfirm", POId, frm.Qty, frm.ConfDate, frm.Comments, frm.ConfType));

                FillConfirmations(POId);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_AddPOConfirmation frm = new frm_AddPOConfirmation();
            frm.HeaderText = "Edit PO confirmation for " + cmb_PurchaseOrdersLines1.PurchaseOrder + " / " + cmb_PurchaseOrdersLines1.PurchaseOrderLine;
            frm.FillType();
            frm.Qty = POBll.ConfQty;
            frm.ConfDate = POBll.ConfDate;
            frm.Comments = POBll.ConfComments;
            frm.ConfType = POBll.ConfType;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Helper.getSP("sp_EditPOConfirm", POBll.ConfId, POId, frm.Qty, frm.ConfDate, frm.Comments, frm.ConfType);

                FillConfirmations(POId);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _confid = 0;

            try { _confid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { _confid = 0; }

            if (glob_Class.DeleteConfirm() == true)
                Helper.getSP("sp_DeletePOConfirm", _confid);
        }
              

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            try {
                ConfId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { ConfId = 0; }
        }

        private void cmb_PurchaseOrdersLines1_Load(object sender, EventArgs e)        {        }

        private void cmb_PurchaseOrdersLines1_PurchaseOrderChanged(object sender)
        {
            //if (_prevpoid != cmb_PurchaseOrdersLines1.PurchaseOrderLineId)

            //{
                //MessageBox.Show(cmb_PurchaseOrdersLines1.PurchaseOrderLineId.ToString());
                POId = cmb_PurchaseOrdersLines1.PurchaseOrderLineId;
                //_prevpoid = POId;
            //}
        }

        private void btn_ConfirmAll_Click(object sender, EventArgs e)
        {
            if (glob_Class.MessageConfirm("All lines confirmation", "Are you sure you want to confirm on all lines?") == true)
            {
                frm_AddPOConfWizard frm = new frm_AddPOConfWizard();
                frm.Date = POBll.POReqDate;
                frm.FillType();
                frm.HeaderText = "Edit PO confirmation for " + cmb_PurchaseOrdersLines1.PurchaseOrder + " / " + cmb_PurchaseOrdersLines1.PurchaseOrderLine;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Helper.getSP("sp_AddPOConfirmAll", POId, frm.Date, frm.ConfType);
                    FillConfirmations(POId);
                }
            }
        }
    }
}