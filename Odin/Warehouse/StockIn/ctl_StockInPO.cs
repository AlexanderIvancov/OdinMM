using Odin.Global_Classes;
using System;
using System.Windows.Forms;


namespace Odin.Warehouse.StockIn
{
    public partial class ctl_StockInPO : UserControl
    {
        public ctl_StockInPO()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        StockIn_BLL SIBll = new StockIn_BLL();

        public int IdIn
        {
            get; set;
        }

        public int ArtId
        { get; set; }

        #endregion


        #region Methods

        public void FillPOs(int id)
        {
            var data = StockIn_BLL.getStockInPOs(id);

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



        #endregion

        #region Controls

        #endregion

        private void btn_Add_Click(object sender, EventArgs e)
        {

            frm_AddPOLink frm = new frm_AddPOLink();
            frm.cmb_PurchaseOrdersWithLines1.ArticleId = ArtId;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                SIBll.AddStockPOLink(frm.PurchaseOrderLineId, IdIn, frm.Qty);
                FillPOs(IdIn);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _poid = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _poid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_poid"].Value);
            }
            catch { }

            if (glob_Class.DeleteConfirm() == true)
            {
                SIBll.DeleteStockPOLink(_id, _poid);
                FillPOs(IdIn);
            }
        }
    }
}
