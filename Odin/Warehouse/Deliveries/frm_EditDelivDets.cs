using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Warehouse.StockIn;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Odin.Warehouse.Deliveries
{
    public delegate void SaveChangesDNEventHandler(int id);

    public partial class frm_EditDelivDets : KryptonForm
    {
        public frm_EditDelivDets()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
        }

        #region Variables


        ProgressForm wait;

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        public int ArtId
        {
            get; set;
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            var data1 = StockIn_BLL.getStockInArticleDelivery(ArtId);

            gv_Delivery.ThreadSafeCall(delegate
            {
                gv_Delivery.AutoGenerateColumns = false;
                bs_Delivery.DataSource = data1;
                gv_Delivery.DataSource = bs_Delivery;

            });

            //Add already delivered conf.order
            if (COId != 0)
            {
                DataRow newrow = data1.NewRow();

                newrow["toadd"] = -1;
                newrow["id"] = Id;
                newrow["coid"] = COId;
                newrow["conforder"] = ConfOrder;
                newrow["orderstate"] = "";
                newrow["client"] = Customer;
                newrow["confdate"] = DelivDate;
                newrow["confqty"] = Qty;
                newrow["unit"] = Unit;
                newrow["unitprice"] = 0;
                newrow["custorder"] = "";
                newrow["delivplace"] = "";
                newrow["delivaddress"] = "";
                newrow["custarticle"] = CustArticle;
                newrow["comments"] = "";

                data1.Rows.Add(newrow);
            }
        }

        public void ShowDets()
        {
            bwStart(bw_List);
        }

        public event SaveChangesDNEventHandler SaveChanges;

        public int Id
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public double NetWeight
        {
            get {
                try { return Convert.ToDouble(txt_NetWeight.Text); }
                catch { return 0; }
            }
            set { txt_NetWeight.Text = value.ToString(); }
        }

        public double BrutWeight
        {
            get
            {
                try { return Convert.ToDouble(txt_BrutWeight.Text); }
                catch { return 0; }
            }
            set { txt_BrutWeight.Text = value.ToString(); }
        }

        public int QtyPack
        {
            get
            {
                try { return Convert.ToInt32(txt_QtyPack.Text); }
                catch { return 0; }
            }
            set { txt_QtyPack.Text = value.ToString(); }
        }

        public string Package
        {
            get { return cmb_Common1.sCurrentValue; }
            set { cmb_Common1.sCurrentValue = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string CustCode
        {
            get { return cmb_CustCodes1.CustCode; }
            set { cmb_CustCodes1.CustCode = value; }
        }

        public string CustArticle
        {
            get { return txt_CustArticle.Text; }
            set { txt_CustArticle.Text = value; }
        }

        public int Return
        {
            get {
                return chk_Return.CheckState == CheckState.Checked ? -1 : 0;
            }
            set { chk_Return.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public string ConfOrder
        { get; set; }
        public string DelivDate
        { get; set; }
        public string Customer
        { get; set; }
        public string Unit
        { get; set; }
        public int COId
        { get; set; }
        public double Qty
        { get; set; }


        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_CustArticle.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SaveChanges?.Invoke(Id);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_Delivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Delivery.CurrentRow.Cells["chk_Add"].Selected == true)
            {
                gv_Delivery.EndEdit();

                if (Convert.ToInt32(gv_Delivery.CurrentRow.Cells["chk_Add"].Value) != 0)
                {
                    int _coid = Convert.ToInt32(gv_Delivery.CurrentRow.Cells["cn_dcoid"].Value);
                    foreach (DataGridViewRow row in this.gv_Delivery.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_dcoid"].Value) != _coid)
                            row.Cells["chk_Add"].Value = 0;
                    }
                }
            }

         }
    }
}
