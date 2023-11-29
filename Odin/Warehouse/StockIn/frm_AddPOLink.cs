using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Purchase;
using System;
namespace Odin.Warehouse.StockIn
{
    public partial class frm_AddPOLink : KryptonForm
    {
        public frm_AddPOLink()
        {
            InitializeComponent();
        }

        PO_BLL Bll = new PO_BLL();
        DAL_Functions Dll = new DAL_Functions();
        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public double QtyLeft
        {
            get
            {
                try { return Convert.ToDouble(txt_LeftInPO.Text); }
                catch { return 0; }
            }
            set { txt_LeftInPO.Text = value.ToString(); }
        }

        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }

        public int PurchaseOrderLineId
        {
            get { return cmb_PurchaseOrdersWithLines1.PurchaseOrderLineId; }
            set { cmb_PurchaseOrdersWithLines1.PurchaseOrderLineId = value; }
        }

        private void cmb_PurchaseOrdersWithLines1_PurchaseOrderChanged(object sender)
        {
            Bll.POId = cmb_PurchaseOrdersWithLines1.PurchaseOrderLineId;
            QtyLeft = Math.Round(Bll.POQtyLeft /*/ Bll.POCoefConv == 0 ? 1 : Bll.POCoefConv*/, 5);
            Unit = Dll.Unit(Bll.POUnitId);
            CheckEmpty();
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = cmb_PurchaseOrdersWithLines1.PurchaseOrderLineId != 0
                && Qty > 0;
        }
    }
}
