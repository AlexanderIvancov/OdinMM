using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using System.Data.SqlClient;

namespace Odin.Sales
{
    public partial class ctl_Payments : UserControl
    {
        public ctl_Payments()
        {
            InitializeComponent();
        }

        #region Variables

        int _invoicedetid = 0;
        public int InvoiceDetId
        {
            get { return _invoicedetid; }
            set { _invoicedetid = value;
                FillPayments(_invoicedetid);
            }
        }
        public int InvoiceHeadId
        { get; set; }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CO_BLL COBll = new CO_BLL();
        DAL_Functions DLL = new DAL_Functions();
        Helper MyHelper = new Helper();

        public double Billed
        {
            get
            {
                try { return Convert.ToDouble(txt_Billed.Text); }
                catch { return 0; }
            }
            set { txt_Billed.Text = value.ToString(); }
        }

        public double Paid
        {
            get
            {
                try { return Convert.ToDouble(txt_Paid.Text); }
                catch { return 0; }
            }
            set { txt_Paid.Text = value.ToString(); }
        }

        public double InvoiceBilled
        {
            get
            {
                try { return Convert.ToDouble(txt_InvoiceBilled.Text); }
                catch { return 0; }
            }
            set { txt_InvoiceBilled.Text = value.ToString(); }
        }

        public double InvoicePaid
        {
            get
            {
                try { return Convert.ToDouble(txt_InvoicePaid.Text); }
                catch { return 0; }
            }
            set { txt_InvoicePaid.Text = value.ToString(); }
        }

        #endregion

        #region Methods

        public void FillPayments(int invoicedetid)
        {
            var data = CO_BLL.getInvoicePayments(invoicedetid);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                //SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            ShowTotals();
        }

        public void ShowTotals()
        {
            double _paid = 0;
            foreach (DataGridViewRow row in this.gv_List.Rows)
                _paid = _paid + Convert.ToDouble(row.Cells["cn_paymentsum"].Value);
            Paid = _paid;

            //Total by invoice 
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("exec sp_SelectExInvoiceTotals " + InvoiceHeadId.ToString(), conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    InvoiceBilled = Convert.ToDouble(dr["billed"]);
                    InvoicePaid = Convert.ToDouble(dr["paid"]);
                }
            }

        }

        public void SendPaymentNotification(int InvoiceDetId)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 isnull(d.ispaid, 0) as ispaid, isnull(q.name, '') as quotation FROM FIN_DocDets d INNER JOIN SAL_Quotations q on q.id = d.quotid WHERE d.id = " + InvoiceDetId.ToString(), conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["ispaid"]) == -1
                        && dr["quotation"].ToString() != "")
                    {
                        //Send letter to sales dept
                       
                        string emailaddresses = DLL.EmailAddressesByType(6);
                       
                        string strMessage = "Quotation " + dr["quotation"].ToString() + " is paid!";
                        MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Quotation: " + dr["quotation"].ToString() + " is paid!", strMessage);

                    }
                }
            }


        }

        public void SendPaymentNotificationAll(int InvoiceDetId)
        {
            int _invoiceheadid = 0;
            string emailaddresses = "";
            string strMessage = "";

            _invoiceheadid = Convert.ToInt32(Helper.GetOneRecord("select top 1 d.headid from FIN_DocDets d WHERE d.id = " + InvoiceDetId.ToString()));

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT isnull(d.ispaid, 0) as ispaid, isnull(q.name, '') as quotation FROM FIN_DocDets d INNER JOIN SAL_Quotations q on q.id = d.quotid WHERE d.headid = " + _invoiceheadid.ToString(), conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                emailaddresses = DLL.EmailAddressesByType(6);

                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["ispaid"]) == -1
                        && dr["quotation"].ToString() != "")
                    {
                        //Send letter to sales dept
                        strMessage = "Quotation " + dr["quotation"].ToString() + " is paid!";
                        MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Quotation: " + dr["quotation"].ToString() + " is paid!", strMessage);

                    }
                }
            }


        }

        #endregion

        #region Controls


        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddExInvoicePayment frm = new frm_AddExInvoicePayment();
            frm.PaymentDate = System.DateTime.Now.ToShortDateString();
            frm.PaidAmount = Billed - Paid;
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                COBll.AddExInvoicePayment(InvoiceDetId, frm.PaidAmount, frm.PaymentDate);

                FillPayments(InvoiceDetId);

                SendPaymentNotification(InvoiceDetId);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_AddExInvoicePayment frm = new frm_AddExInvoicePayment();
                frm.PaymentDate = gv_List.CurrentRow.Cells["cn_paymentdate"].Value.ToString();
                frm.PaidAmount = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_paymentsum"].Value);
                frm.HeaderText = "Edit payment on " + frm.PaymentDate;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    COBll.EditExInvoicePayment(_id, frm.PaidAmount, frm.PaymentDate);

                    FillPayments(InvoiceDetId);

                    SendPaymentNotification(InvoiceDetId);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                COBll.DeleteExInvoicePayment(_id);
                FillPayments(InvoiceDetId);
            }
        }

        private void btn_PayAll_Click(object sender, EventArgs e)
        {
            frm_AddExInvoicePayment frm = new frm_AddExInvoicePayment();
            frm.PaymentDate = System.DateTime.Now.ToShortDateString();
            frm.HeaderText = "ADD PAYMENT FOR ALL LINES BY FIFO";
            frm.lbl_Amount.Text = "Total paid amount:";
            frm.PaidAmount = Math.Round(InvoiceBilled - InvoicePaid, 5);
            //frm.txt_PaidAmount.Enabled = false;
            DialogResult result = frm.ShowDialog();



            if (result == DialogResult.OK)
            {
                COBll.AddExInvoicePaymentAll(InvoiceDetId, frm.PaidAmount, frm.PaymentDate);

                FillPayments(InvoiceDetId);

                SendPaymentNotificationAll(InvoiceDetId);
            }

        }

        #endregion


    }
}
