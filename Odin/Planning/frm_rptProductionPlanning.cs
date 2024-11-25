using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace Odin.Planning
{
    public partial class frm_rptProductionPlanning : Form
    {
        public frm_rptProductionPlanning()
        {
            InitializeComponent();
        }

        //public string Supplier { get; set; }
        //public string DocType { get; set; }
        //public string Procedure { get; set; }
        //public string ChangeDate { get; set; }
        //public string Numurs { get; set; }
        //public string BargCode { get; set; }
        //public string Incoterm { get; set; }
        //public string Total { get; set; }
        //public string StatTotal { get; set; }
        //public string CurRate { get; set; }
        public string Week1 { get; set; }
        public string Week2 { get; set; }

        public DataTable data01;
        public DataTable data02;
        public DataTable data03;
        public DataTable data04;
        public DataTable data05;
        public DataTable data11;
        public DataTable data12;
        public DataTable data13;
        public DataTable data14;
        public DataTable data15;


        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Planning\\" + "rpt_Plan2Weeks.rpt";




            //data source
            //report.Database.Tables[0].SetDataSource(data);
            report.Subreports["SubReport1"].Database.Tables[0].SetDataSource(data01);
            report.Subreports["SubReport2"].Database.Tables[0].SetDataSource(data02);
            report.Subreports["SubReport3"].Database.Tables[0].SetDataSource(data03);
            report.Subreports["SubReport4"].Database.Tables[0].SetDataSource(data04);
            report.Subreports["SubReport5"].Database.Tables[0].SetDataSource(data05);
            report.Subreports["SubReport6"].Database.Tables[0].SetDataSource(data11);
            report.Subreports["SubReport7"].Database.Tables[0].SetDataSource(data12);
            report.Subreports["SubReport8"].Database.Tables[0].SetDataSource(data13);
            report.Subreports["SubReport9"].Database.Tables[0].SetDataSource(data14);
            report.Subreports["SubReport10"].Database.Tables[0].SetDataSource(data15);
            //report.Subreports["rsub_DeclTaxes.rpt"].Database.Tables[0].SetDataSource(datataxes);
            //report.Subreports["rsub_DeclOverheads.rpt"].Database.Tables[0].SetDataSource(dataoverheads);

            ////parameters
            //report.SetParameterValue("Supplier", Supplier);
            //report.SetParameterValue("Seller", Seller);
            //report.SetParameterValue("DocType", DocType);
            //report.SetParameterValue("Procedure", Procedure);
            //report.SetParameterValue("ChangeDate", ChangeDate);
            //report.SetParameterValue("Numurs", Numurs);
            //report.SetParameterValue("BargCode", BargCode);
            //report.SetParameterValue("Incoterm", Incoterm);
            //report.SetParameterValue("Total", Total);
            //report.SetParameterValue("StatTotal", StatTotal);
            //report.SetParameterValue("CurRate", CurRate);
            report.SetParameterValue("Week1", Week1);
            report.SetParameterValue("Week2", Week2);
            report.SetParameterValue("UserName", System.Environment.UserName);

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
