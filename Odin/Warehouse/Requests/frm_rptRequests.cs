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


namespace Odin.Warehouse.Requests
{
    public partial class frm_rptRequests : KryptonForm
    {
        public frm_rptRequests()
        {
            InitializeComponent();
        }

        #region Variables

        public int HeadId
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Request
        {
            get; set;
        }

        DAL_Functions DAL = new DAL_Functions();
        public DataTable data;



        #endregion

        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\Requests\\" + "rpt_Requests.rpt";


            //DataMatrix
            DataTable dt = new DataTable();

            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            //
            DataTable datalab = new DataTable();
            DataRow drow1;
            datalab.Columns.Add("DMatrix", Type.GetType("System.Byte[]"));
            drow1 = datalab.NewRow();
            drow1[0] = DAL.StringDataMatrixToByte(Request);
            datalab.Rows.Add(drow1);

            data.Columns.Add("datamatrix", Type.GetType("System.Byte[]"));
            //data.Columns["datamatrix"].Caption = "datamatrix";
            //data.Columns["datamatrix"].DataType = typeof(byte[]);

            foreach (DataRow row in data.Rows)
            {
                row["datamatrix"] = DAL.StringDataMatrixToByte(row["name"].ToString());
            }

            ////data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);
            report.Database.Tables["dt_DataMatrixField"].SetDataSource(datalab);


            //////parameters


            //report.SetParameterValue("Seller", BLL.Seller);
            //report.SetParameterValue("SellerVAT", BLL.SellerVAT);
            //report.SetParameterValue("SellerAddress", BLL.SellerAddress);
            //report.SetParameterValue("SellerMail", BLL.SellerMail);
            //report.SetParameterValue("DeliveryDate", BLL.DelivDate);
            //report.SetParameterValue("DeliveryNote", BLL.DelivNote);
            //report.SetParameterValue("SellerPhone", BLL.SellerPhone);
            //report.SetParameterValue("SellerFax", BLL.SellerFax);
            //report.SetParameterValue("SellerContPers", BLL.SellerContPers);
            //report.SetParameterValue("HeadComments", BLL.HeadComments);
            //report.SetParameterValue("Buyer", BLL.DelivPlace);
            //report.SetParameterValue("BuyerVAT", BLL.BuyerVAT);
            //report.SetParameterValue("BuyerAddress", BLL.FinalDelivAddress);
            //report.SetParameterValue("BuyerContPers", BLL.BuyerContPerson);
            //report.SetParameterValue("Incoterms", BLL.Incoterms);
            //report.SetParameterValue("Transport", BLL.Transport);
            //report.SetParameterValue("Pallete", BLL.PalQty);
            //report.SetParameterValue("PalWeight", BLL.PalWeight);
            //report.SetParameterValue("Invoices", BLL.DeliveryInvoices);


            report.SetParameterValue("UserName", System.Environment.UserName);

            return report;

        }

        #region Methods

        public void FillReport()
        {
            //DataRow dr = new DataRow data.Row;
            DataRow row = data.Rows[0];
            Request = row["name"].ToString();

            ReportDocument rd;

            rd = OpenReport();

            crystalReportViewer1.ReportSource = rd;

        }

        #endregion
    }
}
