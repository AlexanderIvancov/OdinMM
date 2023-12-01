using CrystalDecisions.CrystalReports.Engine;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;
namespace Odin.Warehouse.StockOut.Reports
{
    public partial class frm_rptStockOut : Form
    {
        public frm_rptStockOut()
        {
            InitializeComponent();
        }

        public int OutcomeDocId
        { get; set; }
        public string DocName
        { get; set; }
        public string DocDate
        { get; set; }
        public string DocReason
        { get; set; }

        DAL_Functions DAL = new DAL_Functions();

        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_StockOut.rpt";


            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            DataTable data = new DataTable();
            data = StockOut_BLL.getStockOutDets(OutcomeDocId);

            //parameters
            
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);
            report.SetParameterValue("DocDate", DocDate);
            report.SetParameterValue("DocName", DocName);
            report.SetParameterValue("Reason", DocReason);
            report.SetParameterValue("UserName", System.Environment.UserName);
            
            return report;

        }

        private void frm_rptStockOut_Load(object sender, EventArgs e)
        {
            ReportDocument rd;

            rd = OpenReport();

            crystalReportViewer1.ReportSource = rd;

            // TODO: This line of code loads data into the 'common.sp_Articles' table. You can move, or remove it, as needed.
        
        }

        public void FillDataSet()
        {
            //this.sp_ArticlesTableAdapter.Fill(this.common.sp_Articles);
        }
    }
}
