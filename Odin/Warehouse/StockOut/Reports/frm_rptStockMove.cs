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
using CrystalDecisions.Windows.Forms;
using Odin.Global_Classes;
using Odin.Warehouse.Movements;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace Odin.Warehouse.StockOut.Reports
{
    public partial class frm_rptStockMove : KryptonForm
    {
        public frm_rptStockMove()
        {
            InitializeComponent();
        }

        #region Variables

        public int HeadId
        { get; set; }    
        public string Batch
        { get; set; }
        public string ConfOrder
        { get; set; }
        public double QtyInBatch
        { get; set; }
        public string AssPerson
        { get; set; }
        public string Article
        { get; set;}
        public string SecArticle
        { get; set; }
        public string DocDate
        { get; set; }
        public string DocName
        { get; set; }
        public string Unit
        { get; set; }
        public string Customer
        { get; set; }
        public int StageId
        { get; set; }
        public string Stage
        { get; set; }
        public string Comments
        { get; set; }
        public int BatchId
        { get; set; }
        public int RepType
        { get; set; }
        public int QtyLabels
        { get; set; }
        public int LaunchId
        { get; set; }
        public string MoveDate
        { get; set; }
        public string Serials
        { get; set; }
        public string GroupName
        { get; set; }
        Helper MyHelper = new Helper();

        #endregion

        DAL_Functions DAL = new DAL_Functions();
        StockMove_BLL BLL = new StockMove_BLL();
        class_Global glob_Class = new class_Global();

        //public DataTable data;
        DataTable dataroute;
        DataTable datagroup;
        public ReportDocument OpenReport()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_StockMove.rpt";

            
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
            DataTable data = new DataTable();
            data = StockMove_BLL.getStockMoveDetsPrint(HeadId ,StageId);

            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            //parameters

            report.SetParameterValue("ConfOrder", ConfOrder);
            report.SetParameterValue("Batch", Batch);
            report.SetParameterValue("Product", Article);
            report.SetParameterValue("SecArticle", SecArticle);
            report.SetParameterValue("QtyInBatch", QtyInBatch.ToString());
            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("Unit", Unit);
            report.SetParameterValue("DocDate", DocDate);
            report.SetParameterValue("Stage", Stage);
            report.SetParameterValue("DocName", DocName);
            report.SetParameterValue("UserName", System.Environment.UserName);
            report.SetParameterValue("Customer", Customer);
            report.SetParameterValue("Comment", Comments);

            return report;

        }

        public ReportDocument OpenReportBatch()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_StockBatchReservation.rpt";

            int _warqty = 0;
            string _warnings = "";
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
            DataTable data = new DataTable();
            data = StockMove_BLL.getStockMoveBatchesPrint(BatchId, StageId);

            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            foreach (DataRow row in data.Rows)
            {
                if (Convert.ToInt32(row["warning"]) != 0
                    && row["artcomments"].ToString() != "")
                {
                    _warnings = _warnings + System.Environment.NewLine + row["article"].ToString() + ": " + row["artcomments"].ToString();
                    _warqty++;
                }
            }

            //parameters

            report.SetParameterValue("ConfOrder", ConfOrder);
            report.SetParameterValue("Batch", Batch);
            report.SetParameterValue("Product", Article);
            report.SetParameterValue("SecArticle", SecArticle);
            report.SetParameterValue("QtyInBatch", QtyInBatch.ToString());
            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("Stage", Stage);
            report.SetParameterValue("UserName", System.Environment.UserName);
            report.SetParameterValue("Customer", Customer);
            report.SetParameterValue("Comment", Comments);
            report.SetParameterValue("QtyLabels", QtyLabels == -999 ? "N/D" : QtyLabels.ToString());
            report.SetParameterValue("BatchLab", "Партия:");
            report.SetParameterValue("WarQty", _warqty);
            report.SetParameterValue("Warnings", _warnings.TrimStart());
            report.SetParameterValue("QtyLab", "Кол-во в партии:");
            report.SetParameterValue("Serials", Serials);
            report.SetParameterValue("Stencil", StockMove_BLL.GetStencil(Article));

            return report;

        }

        public ReportDocument OpenReportLaunchProd()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_StockBatchReservation.rpt";

            int _warqty = 0;
            string _warnings = "";
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
            DataTable data = new DataTable();
            data = StockMove_BLL.getStockMoveLaunchesPrint(LaunchId, StageId);

            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(data);

            foreach (DataRow row in data.Rows)
            {
                if (Convert.ToInt32(row["warning"]) != 0
                    && row["artcomments"].ToString() != "")
                {
                    _warnings = _warnings + System.Environment.NewLine  +  row["article"].ToString() + ": " + row["artcomments"].ToString();
                    _warqty++;
                }
            }

            //parameters

            report.SetParameterValue("ConfOrder", ConfOrder);
            report.SetParameterValue("Batch", Batch);
            report.SetParameterValue("Product", Article);
            report.SetParameterValue("SecArticle", SecArticle);
            report.SetParameterValue("QtyInBatch", QtyInBatch.ToString());
            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("Stage", Stage);
            report.SetParameterValue("UserName", System.Environment.UserName);
            report.SetParameterValue("Customer", Customer);
            report.SetParameterValue("Comment", Comments);
            report.SetParameterValue("QtyLabels", QtyLabels == -999 ? "N/D" : QtyLabels.ToString());
            report.SetParameterValue("BatchLab", "Запуск:");
            report.SetParameterValue("WarQty", _warqty);
            report.SetParameterValue("Warnings", _warnings.TrimStart());
            report.SetParameterValue("QtyLab", "Кол-во в зап.:");
            report.SetParameterValue("Serials", Serials);
            report.SetParameterValue("Stencil", StockMove_BLL.GetStencil(Article));
            return report;

        }

        public ReportDocument OpenReportRouteList()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_RouteList.rpt";


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
            dataroute = StockMove_BLL.getStockMoveRouteList(BatchId);
            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(dataroute);


            //parameters

            report.SetParameterValue("ConfOrder", ConfOrder);
            report.SetParameterValue("Batch", Batch);
            report.SetParameterValue("Product", Article);
            report.SetParameterValue("SecArticle", SecArticle);
            report.SetParameterValue("QtyInBatch", QtyInBatch.ToString());
            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("UserName", System.Environment.UserName);
            report.SetParameterValue("Customer", Customer);
            report.SetParameterValue("BatchLab", "Партия:");
            report.SetParameterValue("QtyLab", "Кол-во в партии:");
            report.SetParameterValue("Stage", "");
            report.SetParameterValue("MoveDate", "");
            report.SetParameterValue("Serials", Serials);
            report.SetParameterValue("Comment", Comments);

            return report;

        }

        public ReportDocument OpenReportBatchList()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_BatchGroupList.rpt";


            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            datagroup = StockMove_BLL.getStockMoveBatchGroupHead(BatchId);
            
            //
            dataroute = StockMove_BLL.getStockMoveBatchGroup(LaunchId);
            //data source for subreport
            report.Subreports[0].SetDataSource(datagroup);
            //data source for main report
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(dataroute);

            //parameters

            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("UserName", System.Environment.UserName);
            //report.SetParameterValue("MoveDate", MoveDate);
            report.SetParameterValue("BatchGroup", Batch);

            return report;

        }

        public ReportDocument OpenReportLaunch()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_RouteList.rpt";


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
            dataroute = StockMove_BLL.getStockMoveLaunch(LaunchId);
            //data source
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(dataroute);

            //parameters

            report.SetParameterValue("ConfOrder", ConfOrder);
            report.SetParameterValue("Batch", Batch);
            report.SetParameterValue("Product", Article);
            report.SetParameterValue("SecArticle", SecArticle);
            report.SetParameterValue("QtyInBatch", QtyInBatch.ToString());
            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("UserName", System.Environment.UserName);
            report.SetParameterValue("Customer", Customer);
            report.SetParameterValue("BatchLab", "Запуск:");
            report.SetParameterValue("QtyLab", "Кол-вл в зап.:");
            report.SetParameterValue("Stage", Stage);
            report.SetParameterValue("MoveDate", MoveDate);
            report.SetParameterValue("Serials", Serials);
            report.SetParameterValue("Comments", Comments);

            return report;

        }

        public ReportDocument OpenReportLaunchGroup()
        {
            ReportDocument report = new ReportDocument();

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_LaunchGroupList.rpt";


            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            datagroup = StockMove_BLL.getStockMoveLaunchGroupHead(GroupName);
            //
            dataroute = StockMove_BLL.getStockMoveLaunchGroup(GroupName);
            //data source for subreport
            report.Subreports[0].SetDataSource(datagroup);
            //data source for main report
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(dataroute);

            //parameters
            
            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("UserName", System.Environment.UserName);
            report.SetParameterValue("MoveDate", MoveDate);
            report.SetParameterValue("LaunchGroup", GroupName);

            return report;

        }

        public ReportDocument OpenReportLaunchRouteList()
        {
            ReportDocument report = new ReportDocument();

            int _warqty = 0;
            string _warnings = "";

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_LaunchGroupReservation.rpt";
            
            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            datagroup = StockMove_BLL.getStockMoveLaunchGroupHead(GroupName);
            //
            dataroute = StockMove_BLL.getStockMoveLaunchesPrint(GroupName);

            foreach (DataRow row in dataroute.Rows)
            {
                if (Convert.ToInt32(row["warning"]) != 0
                    && row["artcomments"].ToString() != "")
                {
                    _warnings = _warnings + System.Environment.NewLine + row["article"].ToString() + ": " + row["artcomments"].ToString();
                    _warqty++;
                }
            }

            //data source for subreport
            report.Subreports[0].SetDataSource(datagroup);
            //data source for main report
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(dataroute);

            //parameters

            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("UserName", System.Environment.UserName);
            //report.SetParameterValue("MoveDate", MoveDate);
            report.SetParameterValue("WarQty", _warqty);
            report.SetParameterValue("Warnings", _warnings.TrimStart());
            report.SetParameterValue("LaunchGroup", GroupName);

            return report;

        }

        public ReportDocument OpenReportBatchGroupReservation()
        {
            ReportDocument report = new ReportDocument();

            int _warqty = 0;
            string _warnings = "";

            report.FileName = Application.StartupPath + "\\Warehouse\\StockOut\\Reports\\" + "rpt_BatchGroupReservation.rpt";

            //DataMatrix
            DataTable dt = new DataTable();
            //StockPrint_DataSet.dt_DataMatrixFieldDataTable dt = new StockPrint_DataSet.dt_DataMatrixFieldDataTable();
            DataRow drow;
            // add the column in table to store the image of Byte array type 
            dt.Columns.Add("DLogo", Type.GetType("System.Byte[]"));
            drow = dt.NewRow();
            drow[0] = DAL.LogoToByte();
            dt.Rows.Add(drow);

            datagroup = StockMove_BLL.getStockMoveBatchGroupHead(BatchId);
            //
            dataroute = StockMove_BLL.getStockMoveBatchesPrint(LaunchId);

            foreach (DataRow row in dataroute.Rows)
            {
                if (Convert.ToInt32(row["warning"]) != 0
                    && row["artcomments"].ToString() != "")
                {
                    _warnings = _warnings + System.Environment.NewLine + row["article"].ToString() + ": " + row["artcomments"].ToString();
                    _warqty++;
                }
            }

            //data source for subreport
            report.Subreports[0].SetDataSource(datagroup);
            //data source for main report
            report.Database.Tables[0].SetDataSource(dt);
            report.Database.Tables[1].SetDataSource(dataroute);

            //parameters

            report.SetParameterValue("AssPerson", AssPerson);
            report.SetParameterValue("UserName", System.Environment.UserName);
            //report.SetParameterValue("MoveDate", MoveDate);
            report.SetParameterValue("WarQty", _warqty);
            report.SetParameterValue("Warnings", _warnings.TrimStart());
            report.SetParameterValue("Batch", Batch);

            return report;

        }


        private void frm_rptStockMove_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;

            customizeToolbar();

            ReportDocument rd;

            if (RepType == 1)
                rd = OpenReport();
            else if (RepType == 2)
                rd = OpenReportBatch();
            else if (RepType == 3)
                rd = OpenReportRouteList();
            else if (RepType == 4)
                rd = OpenReportLaunch();
            else if (RepType == 5)
                rd = OpenReportLaunchProd();
            else if (RepType == 6)
                rd = OpenReportLaunchGroup();
            else if (RepType == 7)
                rd = OpenReportLaunchRouteList();
            else if (RepType == 8)
                rd = OpenReportBatchList();
            else
                rd = OpenReportBatchGroupReservation();

            crystalReportViewer1.ReportSource = rd;
        }

        public void FillDataSet(int headid)
        {
            //data = StockMove_BLL.getStockMoveDetsPrint(headid);
        }

        public void UpdateLaunchPrintData(int launchid)
        {
            string query = "SET DATEFORMAT DMY UPDATE PROD_LaunchHead SET printedat = getdate(), printedby = current_user WHERE id = @id";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@id", SqlDbType.Int){Value = launchid}
            };

            //continew
            Helper.ExecuteQuery(query, parameters.ToArray());
        }
        private void customizeToolbar()
        {
            foreach (Control ctrl in crystalReportViewer1.Controls)
            {
                if (ctrl is ToolStrip)
                {
                    ToolStripButton btn_Print = new ToolStripButton();
                    btn_Print.Click += btn_Print_Click;
                    btn_Print.Image = Global_Resourses.Printer;
                    btn_Print.ToolTipText = "Print";
                    btn_Print.Alignment = ToolStripItemAlignment.Left;
                    ((ToolStrip)ctrl).Items.Insert(1, btn_Print);
                }
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (RepType == 3)
            {
                //Reservation of labels for route list
                DataTable datalabels = new DataTable();

                datalabels.Columns.Add("batchid", typeof(int));
                datalabels.Columns.Add("qty", typeof(double));
                datalabels.Columns.Add("label", typeof(int));

                foreach (DataRow row in dataroute.Rows)
                {
                    DataRow dr = datalabels.NewRow();
                    dr["batchid"] = Convert.ToInt32(row["batchdetid"].ToString());
                    dr["qty"] = Convert.ToDouble(row["qtyforbatch"].ToString());
                    dr["label"] = Convert.ToInt32(row["label"].ToString());

                    datalabels.Rows.Add(dr);
                }


                BLL.ReserveLabels(datalabels);

                //Sending letters

                string emailaddresses = DAL.EmailAddressesByType(7);

                string strMessage = "Batch " + Batch + " was sent on printer!";
                MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Batch: " + Batch + " was sent on printer!", strMessage);

            }
            if (RepType == 4
                || RepType == 8)
            {
                UpdateLaunchPrintData(LaunchId);
            }
            //for (int i = 0; i < gv_POPrint.Rows.Count; i++)
            //{
            //    if (Convert.ToBoolean(gv_POPrint.Rows[i].Cells["Select"].Value))
            //    {
            //        var userId = Purchase_BLL.Get_UserID(Environment.UserName);
            //        Purchase_BLL.Add_PrintingDate((int)gv_POPrint.Rows[i].Cells["cn_Id"].Value, DateTime.Now, userId);

            //    }
            //}

            crystalReportViewer1.PrintReport();
        }

    }
}
