using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.Warehouse.StockIn
{
    public partial class frm_StockInwardFP : KryptonForm
    {
        public frm_StockInwardFP()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
            databoxes = new DataTable();
            databoxes.Columns.Add("id", typeof(int));
        }

        #region Variables

        ProgressForm wait;

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        class_Global glob_Class = new class_Global();
        StockIn_BLL SIBll = new StockIn_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
        DataTable databoxes;

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }
        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public string SecArticle
        { get { return txt_SecArticle.Text; }
            set { txt_SecArticle.Text = value; }
        }

        public string CustArticle
        {
            get { return txt_CustArticle.Text; }
            set { txt_CustArticle.Text = value; }
        }
        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }
        public string DelivPlace 
        {
            get { return txt_DelivPlace.Text; }
            set { txt_DelivPlace.Text = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string ConfOrder
        {
            get { return txt_ConfOrder.Text; }
            set { txt_ConfOrder.Text = value; }
        }

        public int PlaceId
        {
            get { return cmb_Places1.PlaceId; }
            set { cmb_Places1.PlaceId = value; }
        }
        
        public double QtyInBatch
        {
            get { try { return Convert.ToDouble(txt_QtyInBatch.Text); }
                catch { return 0; }
            }
            set { txt_QtyInBatch.Text = value.ToString(); }
        }

        public double QtyIn
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyIn.Text); }
                catch { return 0; }
            }
            set { txt_QtyIn.Text = value.ToString(); }
        }

        public double QtyBefore
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyBefore.Text); }
                catch { return 0; }
            }
            set { txt_QtyBefore.Text = value.ToString(); }
        }

        public double QtyPlaced
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyPlaced.Text); }
                catch { return 0; }
            }
            set { txt_QtyPlaced.Text = value.ToString(); }
        }

        public double QtyAfter
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyAfter.Text); }
                catch { return 0; }
            }
            set { txt_QtyAfter.Text = value.ToString(); }
        }

        public double UnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_UnitPrice.Text); }
                catch { return 0; }
            }
            set { txt_UnitPrice.Text = value.ToString(); }
        }

        public double QtyOnShelf(int ArtId, int PlaceId)
        {
            var param = new List<SqlParameter>
                {
                    new SqlParameter("@ArtId", SqlDbType.Int) {Value = ArtId},
                    new SqlParameter("@PlaceId", SqlDbType.Int) {Value = PlaceId}
                };

            try
            {
                return Convert.ToDouble(Helper.GetOneRecord("SELECT DISTINCT Sum(qty) from STO_Rests WHERE artid = @ArtId AND placeid = @PlaceId and qty > 0", param.ToArray()));
            }
            catch { return 0; }

        }

        #endregion

        #region Methods

        public void ShowHeader(int _batchid)
        {
            //MessageBox.Show(_batchid.ToString());
            SIBll.BIdIn = _batchid;
            ArticleId = SIBll.BArtId;
            if (_batchid == 0)
                cmb_Articles1.Article = "";
            CustArticle = SIBll.BCustArticle;
            DelivPlace = SIBll.BDelivPlace;
            QtyInBatch = SIBll.BQtyLeft;
            QtyIn = SIBll.BQtyLeft;
            SecArticle = SIBll.BSecArticle;
            UnitPrice = SIBll.BUnitPrice;
            ConfOrder = SIBll.BConfOrder;

            QtyBefore = QtyOnShelf(ArticleId, PlaceId);

            ShowImage(DAL.ImagePath(ArticleId));

        }

        public void ShowDets()
        {
            //cmb_Batches1.ThreadSafeCall(delegate { bwStart(bw_List); });
            ShowDetsIn();
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            var data = StockIn_BLL.getStockInBatch(BatchId);

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

            var data1 = StockIn_BLL.getStockInBatchDelivery(BatchId);

            gv_Delivery.ThreadSafeCall(delegate
            {
                gv_Delivery.AutoGenerateColumns = false;
                bs_Delivery.DataSource = data1;
                gv_Delivery.DataSource = bs_Delivery;

            });

        }

        public void ShowDetsIn()
        {

            var data = StockIn_BLL.getStockInBatch(BatchId);

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

            var data1 = StockIn_BLL.getStockInBatchDelivery(BatchId);

            gv_Delivery.ThreadSafeCall(delegate
            {
                gv_Delivery.AutoGenerateColumns = false;
                bs_Delivery.DataSource = data1;
                gv_Delivery.DataSource = bs_Delivery;

            });
        }

        private void ShowImage(string Path)
        {
            try
            {

                pic_Image.ImageLocation = Path;
                pic_Image.Load();


            }
            catch
            {

                pic_Image.Image = null;
            }

        }

        public bool CheckEmpty()
        {
            bool _res = false;

            if (cmb_Places1.PlaceId == 0
                || QtyIn <= 0
                || UnitPrice < 0)
            {
                _res = false;
                btn_OK.Enabled = false;
            }
            else
            {
                _res = true;
                btn_OK.Enabled = true;
            }
            return _res;
        }

        public void ShowTots()
        {
            QtyPlaced = QtyIn;
            QtyAfter = QtyBefore + QtyPlaced;
        }

        #endregion

        #region Controls

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowHeader(BatchId);
            ShowDets();
            ShowTots();
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            Unit = cmb_Articles1.Unit;
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            ShowHeader(BatchId);
            ShowDets();
            ShowTots();
        }

        private void pic_Image_DoubleClick(object sender, EventArgs e)
        {
            frm_FullImage frm = new frm_FullImage();
            frm.HeaderText = "Image for: " + ArticleId.ToString();
            frm.ShowImage(DAL.ImagePath(ArticleId));

            DialogResult result = frm.ShowDialog();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            string _res = SIBll.AddStockInFP(cmb_Articles1.ArticleId, QtyIn, UnitPrice, BatchId, PlaceId, Comments, databoxes, 0);

            if (_res != "")
                KryptonTaskDialog.Show("New stock income for batch was created!",
                                        "Document NO:" + _res + " was created!",
                                        "",
                                        //"Quantity you want to enter is more than left in batch! ",
                                        MessageBoxIcon.Information,
                                        TaskDialogButtons.OK);
            else
                KryptonTaskDialog.Show("Mistake during stock-in!",
                                       "Document was not created!",
                                        "",
                                        MessageBoxIcon.Warning,
                                        TaskDialogButtons.OK);

            ShowHeader(BatchId);
            ShowDets();
            ShowTots();
        }
        
        private void txt_QtyIn_TextChanged(object sender, EventArgs e)
        {
            bool _res = CheckEmpty();
            
                        

            ShowTots();
        }


        private void cmb_Places1_SelectedValueChanged(object sender)
        {
            bool _res = CheckEmpty();

            QtyBefore = QtyOnShelf(ArticleId, PlaceId);
            ShowTots();
        }

        private void txt_QtyIn_Leave(object sender, EventArgs e)
        {
            if (QtyIn < 0)
                QtyIn = 0;

            if (QtyIn > QtyInBatch)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Quantity income is more than left in batch!",
                                                                     "Are you want to save changes?",
                                                                     "Quantity you want to enter is more than left in batch! ",
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.Yes |
                                                                     TaskDialogButtons.No);
                if (result1 == DialogResult.No)
                {
                    QtyIn = QtyInBatch;
                }
            }
            ShowTots();
        }


        #endregion

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void txt_QtyIn_Validated(object sender, EventArgs e)
        {

        }
    }
}
