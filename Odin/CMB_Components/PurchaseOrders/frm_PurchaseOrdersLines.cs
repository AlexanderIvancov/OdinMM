using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Purchase;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.PurchaseOrders
{
    public partial class frm_PurchaseOrdersLines : KryptonForm
    {
        public frm_PurchaseOrdersLines()
        {
            InitializeComponent();
        }

        public frm_PurchaseOrdersLines(cmb_PurchaseOrdersLines cmb)
        {
            InitializeComponent();
            f = new cmb_PurchaseOrdersLines();
            cmb = f;
        }



        PO_BLL POBll = new PO_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_PurchaseOrdersLines f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_PurchaseOrdersLines)cmb_PurchaseOrderLinesOne).PurchaseOrderLineId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void SendSaveEvent()
        {

        }

        public void FillData(int POId)
        {
            var data = CMB_BLL.getPurchaseOrdersLines(POId);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        public void FillDataEnabledArticles(int POId, int ArticleId)
        {
            var data = CMB_BLL.getPurchaseOrdersLinesArticles(POId, ArticleId);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
