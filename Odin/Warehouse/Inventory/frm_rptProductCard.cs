using CrystalDecisions.CrystalReports.Engine;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Odin.Warehouse.Inventory
{
    public partial class frm_rptProductCard : Form
    {
        public frm_rptProductCard()
        {
            InitializeComponent();
        }

        DAL_Functions DAL = new DAL_Functions();

        public string Article
        { get; set; }
        public string ArtId
        { get; set; }
        public string Unit
        { get; set; }
        public string Qty
        { get; set; }
        public string Date
        { get; set; }
        public string Initials
        { get; set; }

        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\Inventory\\" + "rpt_ProductCartSimple.rpt";


            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

        
            //parameters

            report.Database.Tables[0].SetDataSource(dt);
          
            report.SetParameterValue("Article", Article);
            report.SetParameterValue("Unit", Unit);
            report.SetParameterValue("ArtId", ArtId);
            report.SetParameterValue("Qty", Qty);
            report.SetParameterValue("Date", Date);
            report.SetParameterValue("Initials", Initials);
            
            return report;

        }

        private void frm_rptProductCard_Load(object sender, EventArgs e)
        {
            ReportDocument rd;

            rd = OpenReport();

            crystalReportViewer1.ReportSource = rd;
        }
    }
}
