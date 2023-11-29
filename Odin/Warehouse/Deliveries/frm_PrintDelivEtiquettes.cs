using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Warehouse.Deliveries
{
    public delegate void SendPrintEventHandler(object sender);
    public partial class frm_PrintDelivEtiquettes : KryptonForm
    {
        public frm_PrintDelivEtiquettes()
        {
            InitializeComponent();
        }

        #region variables

        public event SendPrintEventHandler SendPrint;

        public string IP_Address
        {
            get { return cmb_LabPrinter1.IP_Adress; }
            set { cmb_LabPrinter1.IP_Adress = value; }
        }
        public int Printer_DPI
        {
            get { return cmb_LabPrinter1.PrinterDPI; }
        }

        public int LabelQty
        {
            get
            {
                try { return Convert.ToInt32(txt_LabelQty.Text); }
                catch { return 1; }
            }
        }

        public string Article
        {
            get { return txt_Article.Text; }
            set { txt_Article.Text = value; }
        }

        public string CustArticle
        {
            get { return txt_CustArt.Text; }
            set { txt_CustArt.Text = value; }
        }

        public string Customer
        {
            get { return txt_Customer.Text; }
            set { txt_Customer.Text = value; }
        }

        public string Batch
        {
            get { return cmb_Batches1.Batch; }
            set { cmb_Batches1.Batch = value; }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public string Order
        {
            get { return txt_ConfOrder.Text; }
            set { txt_ConfOrder.Text = value; }
        }

        public double Qty
        {
            get { return Convert.ToDouble(txt_Qty.Text); }
            set { txt_Qty.Text = value.ToString(); }
        }

        public double Weight
        {
            get { return Convert.ToDouble(txt_Weight.Text); }
            set { txt_Weight.Text = value.ToString(); }
        }

        public int BoxFrom
        {
            get { return Convert.ToInt32(txt_BoxFrom.Text); }
            set { txt_BoxFrom.Text = value.ToString(); }
        }

        public int BoxTill
        {
            get { return Convert.ToInt32(txt_BoxesTill.Text); }
            set { txt_BoxesTill.Text = value.ToString(); }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int PackingLabelTemplate
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }

        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SendPrint(this);
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            Order = cmb_Batches1.ConfOrder;
            Article = cmb_Batches1.Article;
            CustArticle = cmb_Batches1.SecName;
            Customer = cmb_Batches1.Customer;
        }

    }
}
