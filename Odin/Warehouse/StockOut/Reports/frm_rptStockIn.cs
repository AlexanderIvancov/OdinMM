using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Odin.Global_Classes;
using System.Data.SqlClient;
using Odin.Warehouse.StockIn;
namespace Odin.Warehouse.StockOut.Reports
{
    public partial class frm_rptStockIn : Form
    {
        public frm_rptStockIn()
        {
            InitializeComponent();
        }

        public int IncomeDocId
        { get; set; }
        public string DocName
        { get; set; }
        public string DocDate
        { get; set; }
        public string Place
        { get; set; }
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Helper MyHelper = new Helper();

        DAL_Functions DAL = new DAL_Functions();

        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_StockIn.rpt";


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
            data = StockIn_BLL.getStockInDets(IncomeDocId);

            //parameters
            
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);
            report.SetParameterValue("DocDate", DocDate);
            report.SetParameterValue("DocName", DocName);
            report.SetParameterValue("Place", Place);
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

        //private void customizeToolbar()
        //{
        //    foreach (Control ctrl in crystalReportViewer1.Controls)
        //    {
        //        if (ctrl is ToolStrip)
        //        {
        //            ToolStripButton btn_Print = new ToolStripButton();
        //            btn_Print.Click += btn_Print_Click;
        //            btn_Print.Image = Global_Resourses.Printer;
        //            btn_Print.ToolTipText = "Print";
        //            btn_Print.Alignment = ToolStripItemAlignment.Left;
        //            ((ToolStrip)ctrl).Items.Insert(1, btn_Print);
        //        }
        //    }
        //}

        //private void btn_Print_Click(object sender, EventArgs e)
        //{
        //    if (OutcomeDocId != 0)
        //    {
        //        //Sending letter about stockout for fixed assets
        //        SqlConnection sqlConn = new SqlConnection(sConnStr);
        //        SqlCommand sqlComm = new SqlCommand("sp_SelectFixedAssetsOutcomes", sqlConn);
        //        sqlComm.Parameters.AddWithValue("@id", OutcomeDocId);
        //        sqlComm.CommandType = CommandType.StoredProcedure;
        //        sqlConn.Open();

        //        SqlDataReader reader = sqlComm.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            string strMessage = "";
        //            string emailaddresses = "";
        //            emailaddresses = DAL.EmailAddressesByType(8);

        //            while (reader.Read())
        //            {
        //                strMessage = strMessage + "\r\nLabel: " + reader["labelid"].ToString();
        //                strMessage = strMessage + "\r\nDocument: " + reader["document"].ToString();
        //                strMessage = strMessage + "\r\nArticle: " + reader["Article"].ToString();
        //                strMessage = strMessage + "\r\nInv. number: " + reader["invnumber"].ToString();
        //                strMessage = strMessage + "\r\nSuppliers article: " + reader["suparticle"].ToString();
        //                strMessage = strMessage + "\r\nQty: " + reader["qty"].ToString();
        //                strMessage = strMessage + "\r\nUnit price: " + reader["unitprice"].ToString();
        //                strMessage = strMessage + "\r\nPlace: " + reader["place"].ToString();
        //                strMessage = strMessage + "\r\nSupplier: " + reader["supplier"].ToString();

        //            }

        //            reader.Close();
        //            if (emailaddresses != "")
        //            {
        //                MyHelper.SendMessage(emailaddresses, "Fixed asset stock outcomes!", strMessage);
        //            }

        //        }
        //        sqlConn.Close();
        //    }

        //        crystalReportViewer1.PrintReport();
        //}

        public void FillDataSet()
        {
            //this.sp_ArticlesTableAdapter.Fill(this.common.sp_Articles);
        }
    }
}
