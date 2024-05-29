using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Planning
{
    public class Plan_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Batch management

        string _BatchName = "";
        public string BatchName
        {
            get { return _BatchName; }
            set { _BatchName = value;}
        }
        int _batchid = 0;
        public int BatchArtId { get; set; }
        public string BatchArticle { get; set; }
        public string BatchSecArticle { get; set; }
        public string BatchComments { get; set; }
        public string BatchSerials { get; set; }
        public double BatchQty { get; set; }
        public string BatchStartDate { get; set; }
        public int IsActive { get; set; }
        public int ParentBatchId { get; set; }
        public string DateOfClosing { get; set; }
        public int Urgent { get; set; }
        public string EndDate { get; set; }
        public int BatchCOId { get; set; }
        public double BatchQtyIn { get; set; }
        public double BatchCOPrice { get; set; }
        public string BatchCurrency { get; set; }
        public string BatchConfOrder { get; set; }
        public string BatchCustomer { get; set; }
        public int BatchQtyLabels { get; set; }
        public int BatchProjectId { get; set; }
        public string BatchProject { get; set; }
        public int BatchQuotId { get; set; }
        public string BatchResDate { get; set; }
        public int BatchToFollow { get; set; }
        public string Stencil { get; set; }
        public string Stencilplace { get; set; }
        public int BatchId
        {
            get { return _batchid; }
            set
            {
                _batchid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectBatchHeadDets", _batchid);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        BatchName = dr["batch"].ToString();
                        BatchArtId = Convert.ToInt32(dr["artid"]);
                        BatchComments = dr["comments"].ToString();
                        BatchQty = Convert.ToDouble(dr["qty"]);
                        BatchStartDate = dr["startdate"].ToString();
                        ParentBatchId = Convert.ToInt32(dr["parentbatchid"]);
                        DateOfClosing = dr["dateofclosing"].ToString();
                        Urgent = Convert.ToInt32(dr["urgent"]);
                        IsActive = Convert.ToInt32(dr["isactive"]);
                        EndDate = dr["enddate"].ToString();
                        BatchCOId = Convert.ToInt32(dr["coid"]);
                        BatchQtyIn = Convert.ToDouble(dr["qtyin"]);
                        BatchCOPrice = Convert.ToDouble(dr["coprice"]);
                        BatchCurrency = dr["currency"].ToString();
                        BatchConfOrder = dr["conforder"].ToString();
                        BatchCustomer = dr["customer"].ToString();
                        BatchArticle = dr["article"].ToString();
                        BatchSecArticle = dr["secarticle"].ToString();
                        BatchQtyLabels = Convert.ToInt32(dr["qtylabels"]);
                        BatchProjectId = Convert.ToInt32(dr["batchprojectid"]);
                        BatchProject = dr["batchproject"].ToString();
                        BatchSerials = dr["serialnumbers"].ToString();
                        BatchQuotId = Convert.ToInt32(dr["quotid"]);
                        BatchResDate = dr["resdate"].ToString();
                        BatchToFollow = Convert.ToInt32(dr["tofollow"]);
                    }
                else
                    ClearBatchHead();
            }
        }

        public void ClearBatchHead()
        {
            BatchName = "";
            BatchArtId = 0;
            BatchQty = 0;
            BatchComments = "";
            BatchStartDate = "";
            IsActive = 0;
            ParentBatchId = 0;
            EndDate = "";
            Urgent = 0;
            DateOfClosing = "";
            BatchCOId = 0;
            BatchQtyIn = 0;
            BatchCOPrice = 0;
            BatchCurrency = "";
            BatchConfOrder = "";
            BatchCustomer = "";
            BatchArticle = "";
            BatchSecArticle = "";
            BatchQtyLabels = 0;
            BatchProjectId = 0;
            BatchProject = "";
            BatchQuotId = 0;
            BatchSerials = "";
            BatchResDate = "";
            BatchToFollow = 0;
        }

        public int AddBatchHeader(string BatchName1, int ArtId, double Qty, string ResDate, string Comments, int ParentBatchId, int ChildBatchId, string EndDate, int Urgent)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_addbatchheader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@Name", BatchName1);             
            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@ResDate", ResDate);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@ParentBatchId", ParentBatchId);
            sqlComm.Parameters.AddWithValue("@ChildBatchId", ChildBatchId);
            sqlComm.Parameters.AddWithValue("@EndDate", EndDate);
            sqlComm.Parameters.AddWithValue("@Urgent", Urgent);
            sqlComm.Parameters.Add("@insertedname", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            BatchName = sqlComm.Parameters["@insertedname"].Value.ToString();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            //}
            //catch { BatchName = "Error!"; }
            return _res;
        }

        #endregion

        #region Totals

        int _totartid = 0;
        public int ArtIdTotal
        {
            get { return _totartid; }
            set
            {
                _totartid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectArtTotals", _totartid);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        QtyReserved = Math.Round(Convert.ToDouble(dr["qtyreserved"]), 5) ;
                        QtyRest = Math.Round(Convert.ToDouble(dr["qtyrest"]), 5);
                        QtyNeeds = Math.Round(Convert.ToDouble(dr["qtyneeds"]), 5);
                        QtyPurchased = Math.Round(Convert.ToDouble(dr["qtypurchased"]), 5);
                        QtyFreePO = Math.Round(Convert.ToDouble(dr["freepo"]), 5);
                        QtyNeedsCO = Math.Round(Convert.ToDouble(dr["needsfororders"]), 5);
                        QtyNotPlaced = Math.Round(Convert.ToDouble(dr["qtynotplaced"]), 5);
                        QtyInProduction = Math.Round(Convert.ToDouble(dr["qtyinproduction"]), 5);
                        QtyQuarantine = Math.Round(Convert.ToDouble(dr["quarantine"]), 5);
                    }
                else
                    ClearArtTotals();
            }
        }
        public double QtyReserved { get; set; }
        public double QtyRest { get; set; }
        public double QtyNeeds { get; set; }
        public double QtyNeedsCO { get; set; }
        public double QtyPurchased { get; set; }
        public double QtyFreePO { get; set; }
        public double QtyNotPlaced { get; set; }
        public double QtyInProduction { get; set; }
        public double QtyQuarantine { get; set; }

        public void ClearArtTotals()
        {
            QtyReserved = 0;
            QtyRest = 0;
            QtyNeeds = 0;
            QtyPurchased = 0;
            QtyFreePO = 0;
            QtyNeedsCO = 0;
            QtyNotPlaced = 0;
            QtyInProduction = 0;
            QtyQuarantine = 0;
        }

        #endregion

        #region PO distribution

        public DataTable CurrentPOs(int artid)
        {
            return Helper.QueryDT("execute sp_SelectPOCurrentNew @ArtId = " + artid);
        }

        public DataTable POReservations(int poid)
        {
            return Helper.QueryDT("execute sp_SelectPOReservationsNew @poid = " + poid);
        }

        public void ReleaseRMFromPO(int poid, int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReleaseRMFromPO", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@poid", poid);
            sqlComm.Parameters.AddWithValue("@id", id);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public static DataTable RMDeficiteInProduction(int stageid)
        {
            return Helper.QueryDT("execute sp_SelectProductionRMDeficite @stageid = " + stageid);
        }

        public static DataTable RMOverview(int stageid, int custid, int excludezero)
        {
            return Helper.QueryDT("execute sp_SelectRMOverview @stageid = " + stageid + ", @custid = " + custid + ", @excludezero = " + excludezero);
        }


        #endregion

        #region Calculation of cost

        public static DataTable getBatchCostRM(int _batchid, int _groupbydoc, int _projecta)
        {
            string query = "EXECUTE sp_SelectBatchRMCost @batchid = " + _batchid + ", @groupbydoc = " + _groupbydoc + ", @projecta = " + _projecta;

            return Helper.QueryDT(query);
        }

        public static DataTable getBatchCostRMCO(int _batchid, int _coid, int _groupbydoc, int _projecta)
        {
            string query = "EXECUTE sp_SelectBatchRMCostCO @batchid = " + _batchid + ", @coid = " + _coid + ", @groupbydoc = " + _groupbydoc + ", @projecta = " + _projecta;

            return Helper.QueryDT(query);
        }

        #endregion

        #region Passport

        public string PasBatch { get; set; }
        public string PasCreatedAt { get; set; }
        public string PasCreatedBy { get; set; }
        public string PasValidatedBy { get; set; }
        public string PasArticle { get; set; }
        public string PasBatchStages { get; set; }
        public string PasCompany { get; set; }
        public string PasAddress { get; set; }
        public string PasCustArticle { get; set; }
        public string PasConfOrder { get; set; }
        public string PasBatchComments { get; set; }
        public string PasOrderComments { get; set; }
        public int PasInternal { get; set; }
        public string PasOrderType { get; set; }
        public double PasQty { get; set; }
        public int PasOrderTypeId { get; set; }
        int _pasbatchid = 0;
        public int PasBatchId
        {
            get { return _pasbatchid; }
            set
            {
                _pasbatchid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectBatchPassportTitle", _pasbatchid);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        PasBatch = dr["batch"].ToString();
                        PasArticle = dr["article"].ToString();
                        PasCreatedAt = dr["createdat"].ToString();
                        PasCreatedBy = dr["createdby"].ToString();
                        PasValidatedBy = dr["validatedby"].ToString();
                        PasBatchStages = dr["batchstages"].ToString();
                        PasCompany = dr["companyowner"].ToString();
                        PasAddress = dr["address"].ToString();
                        PasCustArticle = dr["custarticle"].ToString();
                        PasConfOrder = dr["conforder"].ToString();
                        PasBatchComments = dr["batchcomments"].ToString();
                        PasOrderComments = dr["ordercomments"].ToString();
                        PasInternal = Convert.ToInt32(dr["internal"].ToString());
                        PasOrderType = dr["ordertype"].ToString();
                        PasQty = Convert.ToDouble(dr["batchqty"].ToString());
                        PasOrderTypeId = Convert.ToInt32(dr["ordertypeid"].ToString());
                    }
                else
                    ClearPasBatch();
            }
        }

        public void ClearPasBatch()
        {
            PasBatch = "";
            PasCreatedAt = "";
            PasCreatedBy = "";
            PasValidatedBy = "";
            PasBatchStages = "";
            PasCompany = "";
            PasAddress = "";
            PasCustArticle = "";
            PasConfOrder = "";
            PasBatchComments = "";
            PasOrderComments = "";
            PasInternal = 0;
            PasOrderType = "";
            PasQty = 0;
            PasOrderTypeId = -1;
        }

        #endregion

        #region Launch Passport

        public string LPasBatch { get; set; }
        public string LPasCreatedAt { get; set; }
        public string LPasCreatedBy { get; set; }
        public string LPasValidatedBy { get; set; }
        public string LPasArticle { get; set; }
        public string LPasLaunchStages { get; set; }
        public string LPasCompany { get; set; }
        public string LPasAddress { get; set; }
        public string LPasCustArticle { get; set; }
        public string LPasConfOrder { get; set; }
        public string LPasComments { get; set; }
        public string LPasOrderComments { get; set; }
        public int LPasInternal { get; set; }
        public string LPasOrderType { get; set; }
        public double LPasQty { get; set; }
        public int LPasOrderTypeId { get; set; }
        int _paslaunchid = 0;
        public int PasLaunchId
        {
            get { return _paslaunchid; }
            set
            {
                _paslaunchid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectLaunchPassportTitle", BatchId);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        LPasBatch = dr["batch"].ToString();
                        LPasArticle = dr["article"].ToString();
                        LPasCreatedAt = dr["createdat"].ToString();
                        LPasCreatedBy = dr["createdby"].ToString();
                        LPasValidatedBy = dr["validatedby"].ToString();
                        LPasLaunchStages = dr["launchstages"].ToString();
                        LPasCompany = dr["companyowner"].ToString();
                        LPasAddress = dr["address"].ToString();
                        LPasCustArticle = dr["custarticle"].ToString();
                        LPasConfOrder = dr["conforder"].ToString();
                        LPasComments = dr["comments"].ToString();
                        LPasOrderComments = dr["ordercomments"].ToString();
                        LPasInternal = Convert.ToInt32(dr["internal"].ToString());
                        LPasOrderType = dr["ordertype"].ToString();
                        LPasQty = Convert.ToDouble(dr["qty"].ToString());
                        LPasOrderTypeId = Convert.ToInt32(dr["ordertypeid"].ToString());
                    }
                else
                    ClearPasLaunch();
            }
        }

        public void ClearPasLaunch()
        {
            LPasBatch = "";
            LPasCreatedAt = "";
            LPasCreatedBy = "";
            LPasValidatedBy = "";
            LPasLaunchStages = "";
            LPasCompany = "";
            LPasAddress = "";
            LPasCustArticle = "";
            LPasConfOrder = "";
            LPasComments = "";
            LPasOrderComments = "";
            LPasInternal = 0;
            LPasOrderType = "";
            LPasQty = 0;
            LPasOrderTypeId = -1;
        }

        #endregion

        #region Launches

        public string LaunchName { get; set; }
        public string LaunchStartDate { get; set; }
        public string LaunchProdStartDate { get; set; }
        public string LaunchEndDate { get; set; }
        public double LaunchQty { get; set; }
        public int LaunchBatchId { get; set; }
        public int LaunchIsStarted { get; set; }
        public int LaunchStageId { get; set; }
        public string LaunchComments { get; set; }
        public int LaunchIsActive { get; set; }
        public string LaunchConfOrder { get; set; }
        public string LaunchCustomer { get; set; }
        public string LaunchArticle { get; set; }
        public string LaunchSecArticle { get; set; }
        public string LaunchStage { get; set; }
        public int LaunchQtyLabels { get; set; }
        public int LaunchParentBatchId { get; set; }
        public string LaunchAdditComments { get; set; }
        public string LaunchVizaComments { get; set; }
        public string LaunchSerials { get; set; }
        int _launchid = 0;
        public int LaunchId
        {
            get { return _launchid; }
            set
            {
                _launchid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectLaunchHeadDets", _launchid);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        LaunchName = dr["name"].ToString();
                        LaunchBatchId = Convert.ToInt32(dr["batchid"]);
                        LaunchStageId = Convert.ToInt32(dr["stageid"]);
                        LaunchIsStarted = Convert.ToInt32(dr["isstarted"]);
                        LaunchComments = dr["comments"].ToString();
                        LaunchQty = Convert.ToDouble(dr["qty"]);
                        LaunchStartDate = dr["startdate"].ToString();
                        LaunchParentBatchId = Convert.ToInt32(dr["parentbatchid"]);
                        LaunchIsActive = Convert.ToInt32(dr["isactive"]);
                        LaunchProdStartDate = dr["prodstartdate"].ToString();
                        LaunchEndDate = dr["enddate"].ToString();
                        LaunchConfOrder = dr["conforder"].ToString();
                        LaunchCustomer = dr["customer"].ToString();
                        LaunchArticle = dr["article"].ToString();
                        LaunchSecArticle = dr["secarticle"].ToString();
                        LaunchStage = dr["stage"].ToString();
                        LaunchQtyLabels = Convert.ToInt32(dr["qtylabels"]);
                        LaunchAdditComments = dr["additcomments"].ToString();
                        LaunchVizaComments = dr["vizacomments"].ToString();
                        LaunchSerials = dr["serialnumbers"].ToString();
                        Stencil = dr["stencil"].ToString();
                        Stencilplace = dr["stencilplace"].ToString();
                    }
                else
                    ClearLaunchHead();
            }
        }

        public void ClearLaunchHead()
        {
            LaunchName = "";
            LaunchStartDate = "";
            LaunchEndDate = "";
            LaunchQty = 0;
            LaunchBatchId = 0;
            LaunchComments = "";
            LaunchConfOrder = "";
            LaunchCustomer = "";
            LaunchEndDate = "";
            LaunchIsActive = 0;
            LaunchIsStarted = 0;
            LaunchParentBatchId = 0;
            LaunchSecArticle = "";
            LaunchStageId = 0;
            LaunchStartDate = "";
            LaunchArticle = "";
            LaunchStage = "";
            LaunchProdStartDate = "";
            LaunchQtyLabels = 0;
            LaunchAdditComments = "";
            LaunchVizaComments = "";
            LaunchSerials = "";
        }

        #endregion

        #region Batch projects

        string _ProjectName = "";
        public string ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        public int AddBatchProjectHeader(int ArtId, double Qty, string Comments, string StartDate, int IsQuot, string ResDate)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_addbatchprojectheader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;
                       
            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@StartDate", StartDate);
            sqlComm.Parameters.AddWithValue("@IsQuot", IsQuot);
            sqlComm.Parameters.AddWithValue("@ResDate", ResDate);
            sqlComm.Parameters.Add("@insertedname", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            ProjectName = sqlComm.Parameters["@insertedname"].Value.ToString();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            //}
            //catch { BatchName = "Error!"; }
            return _res;
        }

        public void EditBatchProjectHeader(int BatchId, int ArtId, double Qty, string Comments, string StartDate, string ResDate)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_editbatchprojectheader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@BatchId", BatchId);
            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@StartDate", StartDate);
            sqlComm.Parameters.AddWithValue("@ResDate", ResDate);

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void CloseBatchProject(int IdBatch)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_CloseBatchProject", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", IdBatch);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void FollowBatchProject(int IdBatch, int ToFollow)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_FollowBatchProject", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", IdBatch);
            sqlComm.Parameters.AddWithValue("@ToFollow", ToFollow);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public DataTable NomDetailsDataProject(int artid, double qty)
        {
            return Helper.QueryDT("execute sp_SelectCreatBatchProjectNew @ArtId = " + artid + ", @Qty = " + qty);
        }

        //public static DataTable getProjectMappings(int _projectid)
        //{
        //    string query = "EXECUTE sp_SelectSalesOrdersMappings @batchid = " + _batchid;

        //    return Helper.QueryDT(query);
        //}
        public static DataTable getRMAnalogs(int artid, int artcseid)
        {
            string query = "EXECUTE sp_SelectProjectAnalogues @artid = " + artid + ", @cseid = " + artcseid;

            return Helper.QueryDT(query);
        }
        public static DataTable getCreateBatchRM(int _projectid)
        {
            string query = "EXECUTE sp_SelectCreatBatchFromProject @projectid = " + _projectid;

            return Helper.QueryDT(query);
        }

        public int AddBatchHeaderFromProject(int ProjectId, int ArtId, double Qty, string ResDate, string Comments, int Urgent, string Serials)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_addbatchheaderfromproject", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@ProjectId", ProjectId);
            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@ResDate", ResDate);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@Urgent", Urgent);
            sqlComm.Parameters.AddWithValue("@SerialNumbers", Serials);
            sqlComm.Parameters.Add("@insertedname", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            BatchName = sqlComm.Parameters["@insertedname"].Value.ToString();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            //}
            //catch { BatchName = "Error!"; }
            return _res;
        }

        #endregion
    }
}