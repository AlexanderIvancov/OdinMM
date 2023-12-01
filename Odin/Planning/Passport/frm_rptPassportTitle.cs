using ComponentFactory.Krypton.Toolkit;
using CrystalDecisions.CrystalReports.Engine;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Odin.Planning.Passport
{
    public partial class frm_rptPassportTitle : KryptonForm
    {
        public frm_rptPassportTitle()
        {
            InitializeComponent();
        }

        public int HeadId
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public int LaunchId
        { get; set; }

        public string Batch
        { get; set; }

        public string Launch
        { get; set; }

        public int BatchId
        { get; set; }

        public string Article
        { get; set; }

        public string CreatedBy
        { get; set; }
        
        public string ValidatedBy
        { get; set;}

        public string CreatedAt
        { get; set; }

        public string BatchStages
        { get; set; }

        public string CompanyOwner
        { get; set; }

        public string Address
        { get; set; }

        public string BatchComments
        { get;set;}

        public string OrderComments
        { get; set; }

        public string COrder
        { get; set; }

        public string CustArticle
        { get; set; }

        public string OrderType
        { get; set; }

        public int OrderTypeId
        { get; set; }

        public string Internal
        { get; set; }

        public string Quantity
        { get; set; }

        public int RepType
        { get; set; }

        public string Stage
        { get; set; }
        public string VizaComments
        { get; set; }

        DAL_Functions DAL = new DAL_Functions();
        Plan_BLL BLL = new Plan_BLL();


        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Planning\\Passport\\" + "rpt_PassportTitle.rpt";
            
            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);
            //Title
            DataTable datalab = new DataTable();
            DataRow drow1;
            datalab.Columns.Add("DMatrix", Type.GetType("System.Byte[]"));
            drow1 = datalab.NewRow();
            drow1[0] = DAL.StringDataMatrixToByte(Batch);
            datalab.Rows.Add(drow1);

            //Box
            DataTable datalaba = new DataTable();
            DataRow drowa;
            datalaba.Columns.Add("DMatrixA", Type.GetType("System.Byte[]"));
            drowa = datalaba.NewRow();
            drowa[0] = DAL.StringDataMatrixToByte(Batch);
            datalaba.Rows.Add(drowa);

            DataTable data = new DataTable();
            data = Plan_BLL.getPassportStages(BatchId);
            DataTable datawarnings = new DataTable();
            datawarnings = Plan_BLL.getPassportWarnings(BatchId);

            //data source
            report.Database.Tables[0].SetDataSource(datalab);
            report.Database.Tables[1].SetDataSource(dt);
            report.Database.Tables[2].SetDataSource(data);
            report.Database.Tables[3].SetDataSource(datalaba);

            report.Subreports["rsub_PassportTitle"].SetDataSource(datawarnings);
           

            ////parameters
            report.SetParameterValue("Creator", CreatedBy);
            report.SetParameterValue("Validator", ValidatedBy);
            report.SetParameterValue("CreatedAt", CreatedAt);
            report.SetParameterValue("BatchLab", "Partija: ");
            report.SetParameterValue("BatchCommentLab", "Partijas komentāri: ");
            report.SetParameterValue("Batch", Batch);
            report.SetParameterValue("Article", Article);
            report.SetParameterValue("BatchStages", BatchStages);
            report.SetParameterValue("Company", CompanyOwner);
            report.SetParameterValue("CustArticle", CustArticle);
            report.SetParameterValue("Address", Address);
            report.SetParameterValue("COrder", COrder);
            report.SetParameterValue("BatchComments", BatchComments);
            report.SetParameterValue("OrderComments", OrderComments);
            report.SetParameterValue("Internal", Internal);
            report.SetParameterValue("OrderType", OrderType);
            report.SetParameterValue("BatchQty", Quantity);
            report.SetParameterValue("OrderTypeId", OrderTypeId);
            report.SetParameterValue("BoxLabel1", Article + " (" + Batch + ")" );
            report.SetParameterValue("BoxLabel2", Article + " (" + Batch + ")");
            report.SetParameterValue("BoxLabel3", Article + " (" + Batch + ")");
            report.SetParameterValue("BoxLabel4", Article + " (" + Batch + ")");


            return report;

        }

        public ReportDocument OpenReportLaunch()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Planning\\Passport\\" + "rpt_PassportTitle.rpt";

            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
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
            drow1[0] = DAL.StringDataMatrixToByte(Batch);
            datalab.Rows.Add(drow1);
            //Box
            DataTable datalaba = new DataTable();
            DataRow drowa;
            datalaba.Columns.Add("DMatrixA", Type.GetType("System.Byte[]"));
            drowa = datalaba.NewRow();
            drowa[0] = DAL.StringDataMatrixToByte(Launch);
            datalaba.Rows.Add(drowa);


            DataTable data = new DataTable();
            data = Plan_BLL.getLaunchStages(LaunchId);

            //data source
            report.Database.Tables[0].SetDataSource(datalab);
            report.Database.Tables[1].SetDataSource(dt);
            report.Database.Tables[2].SetDataSource(data);
            report.Database.Tables[3].SetDataSource(datalaba);

            ////parameters
            report.SetParameterValue("Creator", CreatedBy);
            report.SetParameterValue("Validator", ValidatedBy);
            report.SetParameterValue("CreatedAt", CreatedAt);
            report.SetParameterValue("BatchLab", "Palaišana: ");
            report.SetParameterValue("BatchCommentLab", "Palaišanas komentāri: ");
            report.SetParameterValue("Batch", Launch);
            report.SetParameterValue("Article", Article);
            report.SetParameterValue("BatchStages", BatchStages);
            report.SetParameterValue("Company", CompanyOwner);
            report.SetParameterValue("CustArticle", CustArticle);
            report.SetParameterValue("Address", Address);
            report.SetParameterValue("COrder", COrder);
            report.SetParameterValue("BatchComments", BatchComments);
            report.SetParameterValue("OrderComments", OrderComments);
            report.SetParameterValue("Internal", Internal);
            report.SetParameterValue("OrderType", OrderType);
            report.SetParameterValue("BatchQty", Quantity);
            report.SetParameterValue("OrderTypeId", OrderTypeId);
            report.SetParameterValue("BoxLabel1", Article + " (" + Launch + ")");
            report.SetParameterValue("BoxLabel2", Article + " (" + Launch + ")");
            report.SetParameterValue("BoxLabel3", Article + " (" + Launch + ")");
            report.SetParameterValue("BoxLabel4", Article + " (" + Launch + ")");


            return report;

        }

        public ReportDocument OpenReportLaunchVizas()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Planning\\Passport\\" + "rpt_PassportVizas.rpt";

            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
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
            drow1[0] = DAL.StringDataMatrixToByte(Batch);
            datalab.Rows.Add(drow1);
            //Box
            DataTable datalaba = new DataTable();
            DataRow drowa;
            datalaba.Columns.Add("DMatrixA", Type.GetType("System.Byte[]"));
            drowa = datalaba.NewRow();
            drowa[0] = DAL.StringDataMatrixToByte(Launch);
            datalaba.Rows.Add(drowa);


            DataTable data = new DataTable();
            data = Plan_BLL.getLaunchVizas(LaunchId);
            
            //data source
            report.Database.Tables[0].SetDataSource(datalab);
            report.Database.Tables[1].SetDataSource(dt);
            report.Database.Tables[2].SetDataSource(datalaba);
            report.Database.Tables[3].SetDataSource(data);

            ////parameters
            report.SetParameterValue("Creator", CreatedBy);
            report.SetParameterValue("Validator", ValidatedBy);
            report.SetParameterValue("CreatedAt", CreatedAt);
            report.SetParameterValue("BatchLab", "Palaišana: ");
            report.SetParameterValue("BatchCommentLab", "Palaišanas komentāri: ");
            report.SetParameterValue("Batch", Launch);
            report.SetParameterValue("Article", Article);
            report.SetParameterValue("BatchStages", BatchStages);
            report.SetParameterValue("Company", CompanyOwner);
            report.SetParameterValue("CustArticle", CustArticle);
            report.SetParameterValue("Address", Address);
            report.SetParameterValue("COrder", COrder);
            report.SetParameterValue("BatchComments", BatchComments);
            report.SetParameterValue("OrderComments", OrderComments);
            report.SetParameterValue("Internal", Internal);
            report.SetParameterValue("OrderType", OrderType);
            report.SetParameterValue("BatchQty", Quantity);
            report.SetParameterValue("OrderTypeId", OrderTypeId);
            report.SetParameterValue("Stage", Stage);
            report.SetParameterValue("BoxLabel1", Article + " (" + Launch + ")");
            report.SetParameterValue("BoxLabel2", Article + " (" + Launch + ")");
            report.SetParameterValue("BoxLabel3", Article + " (" + Launch + ")");
            report.SetParameterValue("BoxLabel4", Article + " (" + Launch + ")");
            report.SetParameterValue("VizaComments", VizaComments);


            return report;

        }
        public void FillReport()
        {
            ReportDocument rd = RepType == 1 ? OpenReport() : RepType == 2 ? OpenReportLaunch() : OpenReportLaunchVizas();
            crystalReportViewer1.ReportSource = rd;

        }
    }
}
