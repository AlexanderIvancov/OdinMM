using System;
using System.Windows.Forms;
using Odin.Global_Classes;

namespace Odin.Register.Articles
{
    public partial class ctl_BOMSupplier : UserControl
    {
        public ctl_BOMSupplier()
        {
            InitializeComponent();
        }

        Reg_BLL Reg = new Reg_BLL();

        int _batchid = 0;

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set
            {
                _batchid = value;
                ShowDets(_batchid);
            }
        }

        int _lock = 0;
        public int Lock
        {
            get
            {
                return _lock;
            }
            set
            {
                _lock = value;
                ShowDets(_batchid);
            }

        }

        public void ShowDets(int batchid)
        {
            var data = Reg.SelectBatchBOMData(batchid, _lock);

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            });

            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ExportData ED;

            string _filename = "Setup.xls";
            if (cmb_Batches1.ArticleId != 0)
                _filename = cmb_Batches1.Article + ".xls";
            ED = new ExportData(this.gv_List, _filename, this.Name);
            ED.DgvIntoExcel();
        }

        private void cmb_Batches1_BatchesChanged(object sender)
        {
            BatchId = cmb_Batches1.BatchId;
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Lock = Lock == -1 ? 0 : -1;
        }
    }
}