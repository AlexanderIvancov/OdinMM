using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.CrystalReports.Engine;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Odin.Sales.Reports
{
    public partial class frm_rptExInvoicePrinting : KryptonForm
    {
        public frm_rptExInvoicePrinting()
        {
            InitializeComponent();
        }

        public int HeadId { get; set; }
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public string Lang { get; set; }
        public string ValueForCustoms { get; set; }
        public string CurrencyString { get; set; }

        DAL_Functions DAL = new DAL_Functions();
        CMB_BLL BLL = new CMB_BLL();
        CO_BLL COBll = new CO_BLL();

        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Sales\\Reports\\" + "rpt_ExInvoice.rpt";

            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            BLL.ExInvoiceId = HeadId;
            ////
            DataTable data = new DataTable();
            DataTable datalab = new DataTable();
            data = (DataTable)Helper.getSP("sp_SelectExInvoiceDets", HeadId);
            datalab = DAL_Functions.getReportLabels("ExpInvoice", Lang/*BLL.ExInvoiceBuyerCountryId == 1 ? "LAT" : "ENG"*/);

            //Check for currency
            int number;

            bool success = Int32.TryParse(DAL.DefaultValue("currency"), out number);

            if (success)
                //frm.UnitId = number;
                if (BLL.ExInvoiceCurId != number)
                {
                    DAL.ShowCurRate(BLL.ExInvoiceCurId, BLL.ExInvoiceDocDate);
                    CurrencyString = DAL.DefaultValue("invcur") + DAL.CurRate + " " + BLL.ExInvoiceCurrency + " = 1 " + DAL.DefaultValue("currencyname");
                }
                else
                    CurrencyString = "";
            else
                CurrencyString = "WARNING!!!";
                //frm.UnitId = 0;

            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            ////parameters
            report.SetParameterValue("InvoiceName", BLL.ExInvoice);
            report.SetParameterValue("InvoiceDate", BLL.ExInvoiceDocDate);
            report.SetParameterValue("Seller", BLL.ExInvoiceSender);
            report.SetParameterValue("SellerVAT", BLL.ExInvoiceSenderVAT);
            report.SetParameterValue("SellerAddress", BLL.ExInvoiceSenderAddress);
            report.SetParameterValue("SellerBank", BLL.ExInvoiceSenderBank);
            report.SetParameterValue("LoadingPlace", BLL.ExInvoicePlaceOfLoading);
            report.SetParameterValue("Receiver", BLL.ExInvoiceReceiver);
            report.SetParameterValue("ReceiverVAT", BLL.ExInvoiceReceiverVAT);
            report.SetParameterValue("ReceiverAddress", BLL.ExInvoiceReceiverAddress);
            report.SetParameterValue("Buyer", BLL.ExInvoiceBuyer);
            report.SetParameterValue("BuyerVAT", BLL.ExInvoiceBuyerVAT);
            report.SetParameterValue("BuyerAddress", BLL.ExInvoiceBuyerAddress);
            report.SetParameterValue("Country", BLL.ExInvoiceOrigin);
            report.SetParameterValue("Payment", Lang == "ENG" ? BLL.ExInvoicePayment : BLL.ExInvoicePaymentLat);
            report.SetParameterValue("Currency", BLL.ExInvoiceCurrency);
            report.SetParameterValue("Asset", BLL.ExInvoiceAsset);
            report.SetParameterValue("Incoterms", BLL.ExInvoiceIncoterms);
            report.SetParameterValue("HeadComments", BLL.ExInvoiceComments);
            report.SetParameterValue("PlaceOfIssue", BLL.ExInvoicePlaceOfIssue);
            report.SetParameterValue("VAT", BLL.ExInvoiceVAT);
            report.SetParameterValue("Total", BLL.ExInvoiceTotal);
            report.SetParameterValue("TotalVat", BLL.ExInvoiceTotalVat);
            report.SetParameterValue("TotalWithVat", BLL.ExInvoiceTotalWithVat);
            report.SetParameterValue("PayBefore", BLL.ExInvoicePayBefore);
            report.SetParameterValue("ReceiverBank", BLL.ExInvoiceReceiverBank);
            report.SetParameterValue("BuyerBank", BLL.ExInvoiceBuyerBank);
            report.SetParameterValue("SellerVATNr", BLL.ExInvoiceSenderVatNr);
            report.SetParameterValue("ReceiverVATNr", BLL.ExInvoiceReceiverVatNr);
            report.SetParameterValue("BuyerVATNr", BLL.ExInvoiceBuyerVatNr);
            report.SetParameterValue("IssuedBy", BLL.ExInvoiceIssuedBy);
            //report.SetParameterValue("IssuedBy", BLL.ExInvoiceESignature == 0? BLL.ExInvoiceIssuedBy : BLL.ExInvoiceESignaturePers);
            report.SetParameterValue("ReceiverLegalAddress", BLL.ExInvoiceReceiverLegalAddress);
            report.SetParameterValue("BuyerLegalAddress", BLL.ExInvoiceBuyerLegalAddress);
            report.SetParameterValue("TotalWord", Lang == "ENG" ? BLL.ExInvoiceTotalWord : BLL.ExInvoiceTotalWordLat);
            report.SetParameterValue("Language", /*BLL.ExInvoiceBuyerCountryId == 1 ? "LAT" : "ENG"*/Lang);
            report.SetParameterValue("Bargain", Lang == "ENG" ? BLL.ExInvoiceBargainDesc : BLL.ExInvoiceBargainDescLat);
            report.SetParameterValue("Transport", BLL.ExInvoiceTransport);
            report.SetParameterValue("CurrencyString", CurrencyString);
            report.SetParameterValue("InAdvance", BLL.ExInvoiceInAdvance);
            report.SetParameterValue("InvType", BLL.ExInvoiceType);
            report.SetParameterValue("Proforma", BLL.ExInvoiceProformaNR);
            report.SetParameterValue("SellerContPerson", BLL.ExInvoiceSellerContPerson);
            report.SetParameterValue("BuyerContPerson", BLL.ExInvoiceBuyerContPerson);
            report.SetParameterValue("SellerEmail", BLL.ExInvoiceSellerContPersEmail);
            report.SetParameterValue("ValueForCustoms", ValueForCustoms);
            report.SetParameterValue("TotalPay", BLL.ExInvoiceTotalPay);
            report.SetParameterValue("Esignature", BLL.ExInvoiceESignature);
            report.SetParameterValue("JobTitle", Lang == "ENG" ? BLL.ExInvoiceJobTitle : BLL.ExInvoiceJobTitleLat);
            //Labels

            foreach (DataRow row in datalab.Rows)
                //MessageBox.Show(row["paramvalue"].ToString());
                report.SetParameterValue(row["paramname"].ToString(), row["paramvalue"].ToString());

            //report.SetParameterValue("UserName", System.Environment.UserName);

            return report;
        }

        public void FillReport()
        {
            ReportDocument rd;

            rd = OpenReport();

            crystalReportViewer1.ReportSource = rd;
        }

    }
}