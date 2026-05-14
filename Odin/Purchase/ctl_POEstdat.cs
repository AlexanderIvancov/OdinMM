using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.Purchase
{
    public partial class ctl_POEstdat : UserControl
    {
        public ctl_POEstdat()
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
                FillEstdat(_poid);
                POBll.POId = _poid;

            }
        }


        public void FillEstdat(int _POId)
        {
            var data = PO_BLL.getPOEstdat(_POId);

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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_AddPOEstdat frm = new frm_AddPOEstdat();
            frm.HeaderText = "Edit PO Estimated date " + cmb_PurchaseOrdersLines1.PurchaseOrder + " / " + cmb_PurchaseOrdersLines1.PurchaseOrderLine;
            frm.Estdat = POBll.POEstDate;
           

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                POBll.EditPOEstdat(POId, frm.Estdat);

                FillEstdat(POId);
            }

        }

        private void cmb_PurchaseOrdersLines1_Load(object sender, EventArgs e)
        {
           
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            POBll.EditPOEstdat(POId, "");
        }

        private void cmb_PurchaseOrdersLines1_PurchaseOrderChanged(object sender)
        {
            //if (_prevpoid != cmb_PurchaseOrdersLines1.PurchaseOrderLineId)

            //{
                //MessageBox.Show(cmb_PurchaseOrdersLines1.PurchaseOrderLineId.ToString());
                POId = cmb_PurchaseOrdersLines1.PurchaseOrderLineId;
                //_prevpoid = POId;
            //}
        }

    }
}
