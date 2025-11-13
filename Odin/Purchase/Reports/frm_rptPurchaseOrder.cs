using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.CrystalReports.Engine;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Odin.Purchase.Reports
{
    public partial class frm_rptPurchaseOrder : KryptonForm
    {
        public frm_rptPurchaseOrder()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;


        public int HeadId
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        DAL_Functions DAL = new DAL_Functions();
        PO_BLL BLL = new PO_BLL();
        public DataTable data;

        #endregion

        #region Methods

        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Purchase\\Reports\\" + "rpt_PurchaseOrder.rpt";

            string _lang = "";

            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            BLL.POHeadId = HeadId;
            
            ////
            //DataTable data = new DataTable();
            DataTable datalab = new DataTable();
            //data = PO_BLL.getPODets(HeadId);

            
            switch (BLL.POHeadSupplierCountryISO.Trim())
            {
                case "BY":
                    _lang = "RUS";
                    break;
                case "RU":
                    _lang = "RUS";
                    break;
                case "LV":
                    _lang = "LAT";
                    break;
                default:
                    _lang = "ENG";
                    break;
            }
            //MessageBox.Show(_lang);
            datalab = DAL_Functions.getReportLabels("PurchaseOrder", _lang);

            //datalab = DAL_Functions.getReportLabels("PurchaseOrder", (BLL.POHeadSupplierCountryISO == "BY" || BLL.POHeadSupplierCountryISO == "RU") ? "RUS" : (BLL.POHeadSupplierCountryISO == "LV" ? "LAT" : "ENG"));

            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            ////parameters

            report.SetParameterValue("PurchaseOrder", BLL.POHeader);
            report.SetParameterValue("PurchaseOrderDate", BLL.POHeadCreatAt);
            report.SetParameterValue("Payment", BLL.POHeadPayments);
            report.SetParameterValue("Supplier", BLL.POHeadSupplier);
            report.SetParameterValue("SupplierVAT", BLL.POHeadSupplierVAT);
            report.SetParameterValue("SupplierAddress", "                  " + BLL.POHeadSupAddress);
            report.SetParameterValue("SupplierCont", BLL.POHeadSupContPerson);
            report.SetParameterValue("SupplierPhone", BLL.POHeadSupContPersPhone);
            report.SetParameterValue("SupplierFax", BLL.POHeadSupContPersFax);
            report.SetParameterValue("SupplierMail", BLL.POHeadSupContPersMail);
            report.SetParameterValue("Contract", BLL.POHeadContract);
            report.SetParameterValue("Receiver", BLL.POHeadReceiver);
            report.SetParameterValue("ReceiverVAT", BLL.POHeadReceiverVAT);
            report.SetParameterValue("ReceiverAddress", "                 " + BLL.POHeadRecAddress);
            report.SetParameterValue("ReceiverCont", BLL.POHeadRecContPerson);
            report.SetParameterValue("ReceiverPhone", BLL.POHeadRecContPersPhone);
            report.SetParameterValue("ReceiverFax", BLL.POHeadRecContPersFax);
            report.SetParameterValue("ReceiverMail", BLL.POHeadRecContPersMail);
            report.SetParameterValue("HeadComments", BLL.POHeadComments);
            report.SetParameterValue("Incoterms", BLL.POHeadIncotermsStr);
            report.SetParameterValue("Currency", BLL.POHeadCurrency);
            report.SetParameterValue("BankCont", Convert.ToString(Helper.GetOneRecord(string.Format("SELECT account FROM vw_CurrentBanks WHERE id = '{0}'", BLL.POHeadBankContId))));

            //Labels

            foreach (DataRow row in datalab.Rows)
            {
                //MessageBox.Show(row["paramvalue"].ToString());
                report.SetParameterValue(row["paramname"].ToString(), row["paramvalue"].ToString());
            }

            report.SetParameterValue("UserName", System.Environment.UserName);

            return report;

        }


        public void FillReport()
        {
            ReportDocument rd;

            rd = OpenReport();

            crystalReportViewer1.ReportSource = rd;

        }

        #endregion

        #region Controls

        #endregion
    }
}
