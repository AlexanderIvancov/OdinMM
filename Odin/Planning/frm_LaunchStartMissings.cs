using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Data;

namespace Odin.Planning
{
    public partial class frm_LaunchStartMissings : KryptonForm
    {
        public frm_LaunchStartMissings()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "PurchaseOrders.xls", this.Name);
        }

        #region Variables

        public DataTable data;
        ExportData ED;

        #endregion

        public void FillData()
        {
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

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }
    }
}
