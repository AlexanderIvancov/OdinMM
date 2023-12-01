using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.ExpInvoices
{
    public delegate void ExpInvoiceEventHandler(object sender);
    public delegate void ExpInvoiceSavedEventHandler(object sender);

    public partial class cmb_ExpInvoice : UserControl
    {
        public cmb_ExpInvoice()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event ExpInvoiceEventHandler ExpInvoiceChanged;
        public event ExpInvoiceSavedEventHandler ExpInvoiceSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _InvoiceId = 0;
        int _PrevId = 0;
        public bool _isedit = false;

        class_Global glob_Class = new class_Global();
          
        CMB_BLL Bll = new CMB_BLL();

        bool _EnableSearchId = false;
        string _Invoice = "";
        int _buyerid = 0;
        int _receipid = 0;
        int _valueforcustoms = 0;
        frm_AddExpInvoice frm = null;
        public int BuyerId
        {
            get { return _buyerid; }
            set { _buyerid = value; }
        }

        public int ReceipId
        {
            get { return _receipid; }
            set { _receipid = value; }
        }

        public int ValueForCustoms
        {
            get { return _valueforcustoms; }
            set { _valueforcustoms = value; }
        }

        public string Invoice
        {
            get { return txt_ExpInvoice.Text; }
            set
            {

                _Invoice = value;
                txt_ExpInvoice.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM FIN_DocHeader WHERE name = '" + _Invoice.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    InvoiceId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _InvoiceId = 0;
                    return;
                }

                if (ExpInvoiceChanged != null)
                {
                    ExpInvoiceChanged(this);
                }
            }
        }

        public int InvoiceId
        {
            get
            {
                try { return _InvoiceId; }
                catch { return 0; }
            }
            set
            {


                _InvoiceId = value;

                //MessageBox.Show(_InvoiceId.ToString());

                if (_PrevId != _InvoiceId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 name, buyerid, isnull(valueforcustoms, 0) as valueforcustoms FROM FIN_DocHeader WHERE id = " + _InvoiceId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_ExpInvoice.Text = dr["name"].ToString();
                            BuyerId = Convert.ToInt32(dr["buyerid"]);
                            ValueForCustoms = Convert.ToInt32(dr["valueforcustoms"]);
                        }
                    }
                    else
                    {
                        txt_ExpInvoice.Text = string.Empty;
                        BuyerId = 0;
                        ValueForCustoms = 0;
                    }

                    _PrevId = _InvoiceId;

                    if (ExpInvoiceChanged != null)
                    {
                        ExpInvoiceChanged(this);
                    }

                }
            }
        }

        int _InvoiceSavedId = 0;

        public int InvoiceSavedId
        {
            get { return _InvoiceSavedId; }
            set
            {
                _InvoiceSavedId = value;
                if (ExpInvoiceSaved != null)
                {
                    ExpInvoiceSaved(this);
                }
            }
        }

        public void InvoiceSendSave()
        {
            if (ExpInvoiceSaved != null)
            {
                ExpInvoiceSaved(this);
            }
        }

        public bool EnableSearchId
        {
            get
            {
                return _EnableSearchId;
            }
            set
            {
                _EnableSearchId = value;
            }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_ExpInvoices popup = new frm_ExpInvoices();
            popup.cmb_ExpInvoiceOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Invoice);
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddExpInvoice")) return;

            frm = new frm_AddExpInvoice();
            frm.FillDates();
            frm.FillDoc();
            frm.PaymentId = 1;
            frm.FillSellerContPersons();

            frm.IsEdit = false;
            
            frm.CheckEmpty();

            frm.ExportInvoiceSaving += new ExportInvoiceSavingEventHandler(AddingInvoice);
            frm.Show();
                        
        }

        public void AddingInvoice(object sender)
        {

            int _res = Bll.AddExInvoice(frm.Serie, frm.Invoice, frm.InvoiceType, frm.InvCode, frm.StampDate, frm.DocDate, frm.ReceiverId,
                                        frm.BuyerId, frm.ReceiverAddressId, frm.BuyerAddressId, frm.Comments, frm.CurId, frm.CurRate,
                                        frm.Bargain, frm.TransportId, frm.IncotermsId, frm.Payment, frm.BankContId, frm.AssetId,
                                        frm.SenderAddressId, frm.PlaceOfLoading, 0, 0, frm.VAT, frm.PayBefore, frm.InAdvance,
                                        frm.AdvanceDate, frm.ProformaNR, frm.PayDate, frm.PaymentId, frm.SellerContPersId,
                                        frm.BuyerContPersId, frm.ValueForCustoms, frm.ESignature, frm.Recipient);
            InvoiceId = _res;
            if (ExpInvoiceChanged != null)
                ExpInvoiceChanged(this);

            frm.Close();

        }

        public void EditingInvoice(object sender)
        {

            Bll.EditExInvoice(frm.Id, frm.Invoice, frm.Serie, frm.StampDate, frm.DocDate, frm.ReceiverId,
                                             frm.BuyerId, frm.ReceiverAddressId, frm.BuyerAddressId, frm.Comments, frm.CurId, frm.CurRate,
                                             frm.Bargain, frm.TransportId, frm.IncotermsId, frm.Payment, frm.BankContId, frm.AssetId,
                                             frm.SenderAddressId, frm.PlaceOfLoading, 0, 0, frm.VAT, frm.PayBefore, frm.InAdvance,
                                             frm.AdvanceDate, frm.ProformaNR, frm.PayDate, frm.PaymentId, frm.SellerContPersId,
                                             frm.BuyerContPersId, frm.ValueForCustoms, frm.ESignature, frm.Recipient);

            if (frm.InvoiceType == 5)
                Invoice = frm.Invoice;

            ValueForCustoms = frm.ValueForCustoms;
            BuyerId = frm.BuyerId;

            frm.Close();

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = InvoiceId; }
            catch { }

            //MessageBox.Show(_id.ToString());

            if (_id != 0)
            {
                if (glob_Class.IsFormAlreadyOpen("frm_AddExpInvoice")) return;

                frm = new frm_AddExpInvoice();
                frm.Id = _id;
                frm.IsEdit = true;
                Bll.ExInvoiceId = _id;
                frm.Invoice = Bll.ExInvoice;
                frm.FillSellerContPersons();

                frm.HeaderText = "Edit invoice: " + frm.Invoice;

                frm.Serie = Bll.ExInvoiceSerie;
                frm.InvoiceType = Bll.ExInvoiceType;
                frm.StampDate = Bll.ExInvoiceStampDate;
                frm.DocDate = Bll.ExInvoiceDocDate;
                frm.ReceiverId = Bll.ExInvoiceReceiverId;
                frm.BuyerId = Bll.ExInvoiceBuyerId;
                frm.ReceiverAddressId = Bll.ExInvoiceReceiverAddressId;
                frm.BuyerAddressId = Bll.ExInvoiceBuyerAddressId;
                frm.Comments = Bll.ExInvoiceComments;
                frm.CurId = Bll.ExInvoiceCurId;
                frm.CurRate = Bll.ExInvoiceCurRate;
                frm.Bargain = Bll.ExInvoiceBargain;
                frm.TransportId = Bll.ExInvoiceTransportId;
                frm.IncotermsId = Bll.ExInvoiceIncotermsId;
                frm.Payment = Bll.ExInvoicePayment;
                frm.BankContId = Bll.ExInvoiceBankAccountId;
                frm.AssetId = Bll.ExInvoiceAssetId;
                frm.SenderAddressId = Bll.ExInvoiceSenderAddressId;
                frm.PlaceOfLoading = Bll.ExInvoicePlaceOfLoading;
                frm.VAT = Bll.ExInvoiceVAT;
                frm.PayBefore = Bll.ExInvoicePayBefore;
                frm.InAdvance = Bll.ExInvoiceInAdvance;
                frm.AdvanceDate = Bll.ExInvoiceAdvanceDate;
                frm.ProformaNR = Bll.ExInvoiceProformaNR;
                frm.PayDate = Bll.ExInvoicePayDate;
                frm.PaymentId = Bll.ExInvoicePaymentId;
                frm.SellerContPersId = Bll.ExInvoiceSellerContPersId;
                frm.BuyerContPersId = Bll.ExInvoiceBuyerContPersId;
                frm.ValueForCustoms = Bll.ExInvoiceValueForCustoms;
                frm.ESignature = Bll.ExInvoiceESignature;
                frm.Recipient = Bll.ExInvoiceRecepPers;

                frm.CheckEmpty();

                frm.ExportInvoiceSaving += new ExportInvoiceSavingEventHandler(EditingInvoice);

                frm.Show();
                
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_ExpInvoice.Text = string.Empty;
        }

        private void txt_ExpInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void txt_ExpInvoice_TextChanged(object sender, EventArgs e)
        {
            try { Invoice = txt_ExpInvoice.Text; }
            catch { }
        }
    }
}
