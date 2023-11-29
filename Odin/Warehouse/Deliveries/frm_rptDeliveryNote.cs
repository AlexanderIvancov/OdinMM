using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using CrystalDecisions.CrystalReports.Engine;


namespace Odin.Warehouse.Deliveries
{
    public partial class frm_rptDeliveryNote : KryptonForm
    {
        public frm_rptDeliveryNote()
        {
            InitializeComponent();
        }

        #region Variables

        int _delivnotetype = 1;

        public int DelivNoteType
        {
            get { return _delivnotetype; }
            set { _delivnotetype = value; }
        }

        public int HeadId
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        DAL_Functions DAL = new DAL_Functions();
        DelivNote_BLL BLL = new DelivNote_BLL();


        #endregion 

        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\Deliveries\\" + "rpt_DeliveryNote.rpt";


            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            BLL.DelivNoteHeadId = HeadId;
            ////
            DataTable data = new DataTable();
            DataTable datalab = new DataTable();
            if (DelivNoteType == 1)
                data = DelivNote_BLL.getDeliveryDetsPrint(HeadId);
            else
                data = DelivNote_BLL.getDeliveryDetsPrintMov(HeadId);


            string short_name = "";


            switch (BLL.BuyerCountryShort)
            {
                case "RU":
                    short_name = "RUS";
                    break;
                case "BY":
                    short_name = "RUS";
                    break;
                case "LV":
                    short_name = "LAT";
                    break;
                default:
                    short_name = "ENG";
                    break;
            }


            datalab = DAL_Functions.getReportLabels("DelivNote", short_name);

            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            ////parameters
                     

            report.SetParameterValue("Seller", BLL.Seller);
            report.SetParameterValue("SellerVAT", BLL.SellerVAT);
            report.SetParameterValue("SellerAddress", BLL.SellerAddress);
            report.SetParameterValue("SellerMail", BLL.SellerMail);
            report.SetParameterValue("DeliveryDate", BLL.DelivDate);
            report.SetParameterValue("DeliveryNote", BLL.DelivNote);
            report.SetParameterValue("SellerPhone", BLL.SellerPhone);
            report.SetParameterValue("BuyerPhone", BLL.BuyerPhone);
            report.SetParameterValue("SellerContPers", BLL.SellerContPers);
            report.SetParameterValue("HeadComments", BLL.HeadComments);
            report.SetParameterValue("Buyer", BLL.DelivPlace);
            report.SetParameterValue("BuyerVAT", BLL.BuyerVAT);
            report.SetParameterValue("BuyerAddress", BLL.FinalDelivAddress);
            report.SetParameterValue("BuyerContPers", BLL.BuyerContPerson);
            report.SetParameterValue("Pallete", BLL.PalQty);
            report.SetParameterValue("PalWeight", BLL.PalWeight);
            report.SetParameterValue("Invoices", BLL.DeliveryInvoices);
            if (DelivNoteType == 1)
                report.SetParameterValue("DelivNoteType", "1");
            else
                report.SetParameterValue("DelivNoteType", "2");
            report.SetParameterValue("IsReturn", BLL.IsReturn);
            report.SetParameterValue("CreditAccount", BLL.CreditAccount);

            //Labels

            foreach (DataRow row in datalab.Rows)
            {
                //MessageBox.Show(row["paramvalue"].ToString());
                try
                {
                    report.SetParameterValue(row["paramname"].ToString(), row["paramvalue"].ToString());
                }
                catch { }
            }

            report.SetParameterValue("UserName", System.Environment.UserName);
            
            return report;

        }

        private void frm_rptDeliveryNote_Load(object sender, EventArgs e)
        {
            
        }

        public void FillReport()
        {
            ReportDocument rd;

            rd = OpenReport();

            crystalReportViewer1.ReportSource = rd;

        }


    }
}
