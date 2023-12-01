using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.ExpInvoices
{
    public partial class frm_ExpInvoices : KryptonForm
    {
        public frm_ExpInvoices()
        {
            InitializeComponent();
        }

        public frm_ExpInvoices(cmb_ExpInvoice cmb)
        {
            InitializeComponent();
            f = new cmb_ExpInvoice();
            cmb = f;
        }
        
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_ExpInvoice f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {

                ((cmb_ExpInvoice)cmb_ExpInvoiceOne).txt_ExpInvoice.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_ExpInvoice)cmb_ExpInvoiceOne).InvoiceId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getExpInvoices(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddExpInvoice")) return;

            _showingModal = true;

            frm_AddExpInvoice frm = new frm_AddExpInvoice();
            frm.FillDates();
            frm.FillDoc();
            frm.PaymentId = 1;
            frm.IsEdit = false;
            frm.FillSellerContPersons();

            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;

                int _res = Bll.AddExInvoice(frm.Serie, frm.Invoice, frm.InvoiceType, frm.InvCode, frm.StampDate, frm.DocDate, frm.ReceiverId,
                                            frm.BuyerId, frm.ReceiverAddressId, frm.BuyerAddressId, frm.Comments, frm.CurId, frm.CurRate,
                                            frm.Bargain, frm.TransportId, frm.IncotermsId, frm.Payment, frm.BankContId, frm.AssetId,
                                            frm.SenderAddressId, "", 0, 0, frm.VAT, frm.PayBefore, frm.InAdvance,
                                            frm.AdvanceDate, frm.ProformaNR, frm.PayDate, frm.PaymentId, frm.SellerContPersId, 
                                            frm.BuyerContPersId, frm.ValueForCustoms, frm.ESignature, frm.Recipient);
                FillData(frm.Invoice);
                ((cmb_ExpInvoice)cmb_ExpInvoiceOne).InvoiceSendSave();

            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            //MessageBox.Show(_id.ToString());

            if (_id != 0)
            {
                if (glob_Class.IsFormAlreadyOpen("frm_AddExpInvoice")) return;

                _showingModal = true;

                frm_AddExpInvoice frm = new frm_AddExpInvoice();
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

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditExInvoice(frm.Id, frm.Invoice, frm.Serie, frm.StampDate, frm.DocDate, frm.ReceiverId,
                                            frm.BuyerId, frm.ReceiverAddressId, frm.BuyerAddressId, frm.Comments, frm.CurId, frm.CurRate,
                                            frm.Bargain, frm.TransportId, frm.IncotermsId, frm.Payment, frm.BankContId, frm.AssetId,
                                            frm.SenderAddressId, "", 0, 0, frm.VAT, frm.PayBefore, frm.InAdvance, frm.AdvanceDate,
                                            frm.ProformaNR, frm.PayDate, frm.PaymentId, frm.SellerContPersId, frm.BuyerContPersId, frm.ValueForCustoms,
                                            frm.ESignature, frm.Recipient);
                    if (frm.InvoiceType == 5)
                        FillData(frm.Invoice);
                    else
                        FillData(Bll.ExInvoice);
                    ((cmb_ExpInvoice)cmb_ExpInvoiceOne).InvoiceSendSave();
                    ((cmb_ExpInvoice)cmb_ExpInvoiceOne).ValueForCustoms = frm.ValueForCustoms;
                    ((cmb_ExpInvoice)cmb_ExpInvoiceOne).BuyerId = frm.BuyerId;

                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
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
                Bll.DeleteExInvoice(_id);
                FillData(string.Empty);
            }
        }
    }
}
