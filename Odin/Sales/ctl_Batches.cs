using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Planning;
using System;
using System.Windows.Forms;

namespace Odin.Sales
{
    public delegate void BatchChangingEventHandler(object sender);
    public partial class ctl_Batches : UserControl
    {
        public ctl_Batches()
        {
            InitializeComponent();
        }

        public event BatchChangingEventHandler BatchChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CO_BLL COBll = new CO_BLL();
        Plan_BLL PlanBll = new Plan_BLL();

        int _prevcoid = 0;
        int _coid = 0;
        public int COId
        {
            get { return cmb_SalesOrdersWithLines1.SalesOrderLineId; }
            set
            {

                _coid = value;
                FillBatches(_coid);
                COBll.COId = _coid;
                FillDetails(_coid);
            }
        }

        int _confid = 0;

        frm_AddBatch frm = null;

        public int ConfId
        {
            get { return _confid; }
            set
            {
                _confid = value;
                COBll.ConfId = _confid;
            }
        }

        public int ArticleId
        {
            get; set;
        }
        public double QtyInCO
        { get; set; }
        public string ResDate
        { get; set; }
        public string EndDate
        { get; set; }
        public string Customer
        { get; set; }
        public int BOMState
        {
            get; set;
        }
        private void AddBatch(object sender)
        {
            frm.Close();
            FillBatches(COId);

            BatchChanged?.Invoke(this);
        }

        private double QtyInBatch()
        {
            double _QtyInBatch = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _QtyInBatch = _QtyInBatch + Convert.ToInt32(row.Cells["cn_qtymapped"].Value);
            }

            return _QtyInBatch;
        }

        public void FillBatches(int _COId)
        {
            var data = CO_BLL.getCOBatches(_COId);

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

        public void FillDetails(int _COId)
        {
            ArticleId = COBll.COArtId;
            QtyInCO = COBll.COQty + COBll.COSpoilageQty;
            if (COBll.COReqDate != null
                && String.IsNullOrEmpty(COBll.COReqDate) == false)
                ResDate = Convert.ToDateTime(COBll.COReqDate).AddDays(-14).ToShortDateString();
            EndDate = COBll.COReqDate;
            Customer = COBll.COCustomer;
            BOMState = COBll.COBOMState;
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (COId != 0)
            {
                frm_cmbBatchQty frm = new frm_cmbBatchQty();
                frm.HeaderText = "Select batch and qty you want to map: ";
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK
                    && frm.Qty > 0)
                {
                    PlanBll.AddBatchCOPOLink(frm.BatchId, COId, 0, frm.Qty, 0, 0);
                    FillBatches(COId);

                }
            }

            //if (BOMState != 0)
            //{
            //    frm = new frm_AddBatch();

            //    frm.ctl_CreatBatchDets1.COrderId = COId;
            //    frm.ctl_CreatBatchDets1.cmb_SalesOrdersWithLines1.SalesOrderLineId = COId;
            //    frm.ctl_CreatBatchDets1.ArticleId = ArticleId;
            //    frm.ctl_CreatBatchDets1.QtyInBatch = QtyInCO - QtyInBatch();

            //    frm.ctl_CreatBatchDets1.FillNewOrderLine(0, COId, cmb_SalesOrdersWithLines1.SalesOrder, cmb_SalesOrdersWithLines1.SalesOrderLine,
            //                                            frm.ctl_CreatBatchDets1.cmb_Articles1.Article, frm.ctl_CreatBatchDets1.cmb_Articles1.ArticleId,
            //                                            QtyInCO - QtyInBatch(), EndDate, COBll.COCustomer, QtyInCO - QtyInBatch());

            //    frm.ctl_CreatBatchDets1.FillDates();
            //    frm.ctl_CreatBatchDets1.FillAutoDoc();
            //    frm.ctl_CreatBatchDets1.FillDecNum();
            //    frm.ctl_CreatBatchDets1._EditMode = 0;
            //    frm.ctl_CreatBatchDets1.FillGridNew(frm.ctl_CreatBatchDets1.ArticleId, frm.ctl_CreatBatchDets1.QtyInBatch);

            //    frm.BatchSaved += new BatchSavedEventHandler(AddBatch);

            //    frm.Show(); frm.GetKryptonFormFields();
            //}
            //else
            //{
            //    KryptonTaskDialog.Show("You can't create batch!",
            //                           "BOM is not validated!",
            //                            "",
            //                            MessageBoxIcon.Warning,
            //                            TaskDialogButtons.OK);
            //}
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _batchid = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);

            }
            catch { }

            if (_batchid != 0
                && BOMState != 0)
            {
                PlanBll.BatchId = _batchid;
                frm = new frm_AddBatch();

                frm.ctl_CreatBatchDets1.COrderId = COId;
                frm.ctl_CreatBatchDets1.cmb_SalesOrdersWithLines1.SalesOrderLineId = COId;
                frm.ctl_CreatBatchDets1.ArticleId = ArticleId;
                frm.ctl_CreatBatchDets1.fOldArticleId = ArticleId;
                frm.ctl_CreatBatchDets1.BatchId = _batchid;
                frm.ctl_CreatBatchDets1.Batch = PlanBll.BatchName;
                frm.ctl_CreatBatchDets1._EditMode = -1;
                frm.ctl_CreatBatchDets1.QtyInBatch = PlanBll.BatchQty;
                frm.ctl_CreatBatchDets1.fOldQtyInBatch = PlanBll.BatchQty;
                frm.ctl_CreatBatchDets1.fOldComments = PlanBll.BatchComments;
                frm.ctl_CreatBatchDets1.Comments = PlanBll.BatchComments;
                frm.ctl_CreatBatchDets1.StartDate = PlanBll.BatchStartDate;
                frm.ctl_CreatBatchDets1.fOldStartDate = PlanBll.BatchStartDate;
                frm.ctl_CreatBatchDets1.fOldEndDate = PlanBll.EndDate;
                frm.ctl_CreatBatchDets1.EndDate = PlanBll.EndDate;
                frm.ctl_CreatBatchDets1.Urgent = PlanBll.Urgent;
                frm.ctl_CreatBatchDets1.fOldUrgent = PlanBll.Urgent;

                frm.ctl_CreatBatchDets1.FillExistedLines(_batchid);

                frm.ctl_CreatBatchDets1.FillDecNum();

                frm.ctl_CreatBatchDets1.FillGridBatch(_batchid);

                frm.BatchSaved += new BatchSavedEventHandler(AddBatch);

                frm.Show(); frm.GetKryptonFormFields();
            }
            else
            {
                KryptonTaskDialog.Show("You can't edit batch!",
                                       "BOM is not validated!",
                                        "",
                                        MessageBoxIcon.Warning,
                                        TaskDialogButtons.OK);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                try
                {
                    PlanBll.DeleteBatchCOPOLink(_id);
                    FillBatches(COId);
                }

                catch { }
            }
        }

        private void btn_EditMapped_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            int _id = 0;
            double _qty = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _qty = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_qtymapped"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_cmbNumber frm = new frm_cmbNumber();
                frm.FormNumber = _qty;
                frm.LabelText = "Mapped qty:";
                frm.HeaderText = "Enter new mapped qty";
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PlanBll.EditMappedQty(_id, frm.FormNumber);
                    FillBatches(COId);
                }
            }
            else
            {
                //KryptonTaskDialog.Show("You can't edit batch!",
                //                       "BOM is not validated!",
                //                        "",
                //                        MessageBoxIcon.Warning,
                //                        TaskDialogButtons.OK);
            }
        }

        private void btn_Relink_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            int _id = 0;
            double _qty = 0;

            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _qty = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_qtymapped"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_cmbCO frm = new frm_cmbCO();
                frm.LabelText = "Confirmation order:";
                frm.HeaderText = "Enter new confirmation order: ";
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK
                   )
                {
                    //if (COBll.COArtId == frm.ArtId)
                    {
                        PlanBll.RelinkOrder(_id, frm.COId);
                        FillBatches(COId);
                    }
                    //else
                    //{
                    //    KryptonTaskDialog.Show("You can't relink CO!",
                    //                           "Article is not the same!",
                    //                            "",
                    //                            MessageBoxIcon.Warning,
                    //                            TaskDialogButtons.OK);
                    //}
                }
            }
            else
            {
                //KryptonTaskDialog.Show("You can't edit batch!",
                //                       "BOM is not validated!",
                //                        "",
                //                        MessageBoxIcon.Warning,
                //                        TaskDialogButtons.OK);
            }
        }
    }
}
