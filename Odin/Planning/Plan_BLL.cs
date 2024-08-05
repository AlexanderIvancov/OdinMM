using Odin.Global_Classes;
using System;
using System.Collections.Generic;
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

        public static DataTable getBatches(int _batchid, int _coid, int _artid, int _isactive, int _typeid, int _deptid, 
                            string _startdatefrom, string _startdatetill, string _enddatefrom, string _enddatetill)
        {
            string query = "EXECUTE sp_BatchesList @batchid = " +_batchid + ", @coid = " + _coid + ", @artid = " + _artid + ",@isactive = " + _isactive + 
                            ", @typeid = " + _typeid + ", @deptid = " + _deptid + ", @startdatefrom = '" + _startdatefrom + "', @startdatetill = '" + _startdatetill +
                            "', @enddatefrom = '" + _enddatefrom + "', @enddatetill = '" + _enddatetill + "'";

            return Helper.QueryDT(query);
        }
                
        public static DataTable getOrdersForBatches(int _typeid)
        {
            string query = "EXECUTE sp_SelectSalesOrdersForBatch @typeid = " + _typeid;

            return Helper.QueryDT(query);
        }

        public static DataTable getOrdersForBatchesBP(int _typeid)
        {
            string query = "EXECUTE sp_SelectSalesOrdersForBatchBP @typeid = " + _typeid;

            return Helper.QueryDT(query);
        }

        public static DataTable getOrdersForBatch(int _batchid)
        {
            string query = "EXECUTE sp_SelectSalesOrdersForBatchMapped @batchid = " + _batchid;

            return Helper.QueryDT(query);
        }


        public DataTable NomDetailsDataCB(int artid, double qty)
        {
            return Helper.QueryDT("execute sp_SelectCreatBatchNomenclatureNew @ArtId = " + artid + ", @Qty = " + qty);
        }

        public DataTable NomDetailsDataBatch(int batchid)
        {
            return Helper.QueryDT("execute sp_SelectBatchNomenclatureNew @batchid = " + batchid);
        }

        public int AddBatchHeader(string BatchName1, int ArtId, double Qty, string ResDate, string Comments, int ParentBatchId, int ChildBatchId, string EndDate, int Urgent, int ProdPlaceId)
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
            sqlComm.Parameters.AddWithValue("@ProdPlaceId", ProdPlaceId);
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

        public void EditBatchHeader(int BatchId, int ArtId, double Qty, string ResDate, string Comments, string EndDate, int Urgent, string Serials, int ProdPlaceId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_editbatchheader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@BatchId", BatchId);
            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@ResDate", ResDate);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@EndDate", EndDate);
            sqlComm.Parameters.AddWithValue("@Urgent", Urgent);
            sqlComm.Parameters.AddWithValue("@SerialNumbers", Serials);
            sqlComm.Parameters.AddWithValue("@ProdPlaceId", ProdPlaceId);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void EditBatchHeaderP(int BatchId, int ArtId, string ResDate, string Comments, int Urgent, string Serials, int ProdPlaceId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_editbatchheaderfromproject", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@BatchId", BatchId);
            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@ResDate", ResDate);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@Urgent", Urgent);
            sqlComm.Parameters.AddWithValue("@SerialNumbers", Serials);
            sqlComm.Parameters.AddWithValue("@ProdPlaceId", ProdPlaceId);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void AddBatchCOPOLink(int BatchId, int COId, int POId, double Qty, int ConfId, int QuotId)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchCOPOLink", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@batchid", BatchId);
            sqlComm.Parameters.AddWithValue("@coid", COId);
            sqlComm.Parameters.AddWithValue("@poid", POId);
            sqlComm.Parameters.AddWithValue("@qty", Qty);
            sqlComm.Parameters.AddWithValue("@confid", ConfId);
            sqlComm.Parameters.AddWithValue("@quotid", QuotId);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();
            //}
            //catch { }

        }

        public void EditBatchCOPOLink(int BatchId, int COId, int POId, double Qty, int ConfId, int QuotId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditBatchCOPOLink", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@batchid", BatchId);
            sqlComm.Parameters.AddWithValue("@coid", COId);
            sqlComm.Parameters.AddWithValue("@poid", POId);
            sqlComm.Parameters.AddWithValue("@qty", Qty);
            sqlComm.Parameters.AddWithValue("@confid", ConfId);
            sqlComm.Parameters.AddWithValue("@quotid", QuotId);

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();
            //}
            //catch { }
        }

        public void DeleteBatchCOPOLink(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteBatchCOPOLink", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();
            //}
            //catch { }
        }

        public int AddBatchDetail(int BatchId, int ArtId, double Qty, string Comments)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;


            sqlComm.Parameters.AddWithValue("@batchid", BatchId);
            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            //}
            //catch { }

            return _res;
        }

        public void AddBatchDetailSB(int IdBatch, int ArtId, double Qty)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchModifRM", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@batchid", IdBatch);
            sqlComm.Parameters.AddWithValue("@subprod", -1);

           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            

        }

        public void EditBatchDetail(int IdBatchDet, double Qty, string Comments, int IsActive, int DNP)
        {
            //int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditBatchDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@bdid", IdBatchDet);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@comments", Comments);
            sqlComm.Parameters.AddWithValue("@isactive", IsActive);
            sqlComm.Parameters.AddWithValue("@dnp", DNP);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void ReplaceBatchDetail(int bdid, int artid, double qty)
        {
            //int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReplaceBatchDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@bdid", bdid);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public int DeleteBatchDetail(int IdBatchDet)
        {
            int _Res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteBatchDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@bdid", IdBatchDet);
            sqlComm.Parameters.Add("@success", SqlDbType.Int).Direction = ParameterDirection.Output;
            //try
            //{
            sqlConn.Open();

            sqlComm.ExecuteNonQuery();
            _Res = Convert.ToInt32(sqlComm.Parameters["@success"].Value);
            sqlConn.Close();
            //}
            //catch { }
            return _Res;
        }

        public int DeleteBatch(int IdBatch)
        {
            int _Res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteBatch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@BatchId", IdBatch);
            sqlComm.Parameters.Add("@success", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _Res = Convert.ToInt32(sqlComm.Parameters["@success"].Value);
            sqlConn.Close();

            return _Res;
        }
            

        public void CloseBatch(int IdBatch)
        {
            
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_CloseBatch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", IdBatch);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void RollBackBatchQty(int IdBatch, double Qty)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_RollBackBatch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", IdBatch);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void OpenBatch(int IdBatch)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_OpenBatch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", IdBatch);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void BlockBatch(int IdBatch)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_BlockBatch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", IdBatch);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void EditMappedQty(int Id, double Qty)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditMappedQty", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void RelinkOrder(int Id, int COid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_RelinkCO", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlComm.Parameters.AddWithValue("@COId", COid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public bool CheckReplaceStages(int _batchdetid, int _newartid)
        {
            bool _test = false;


            int _res = Convert.ToInt32(Helper.GetOneRecord("select dbo.fn_CheckReplaceStages(" + _batchdetid + "," + _newartid + ")"));
            _test = _res != 0;

            return _test;
        }

        public bool CheckReplaceBatchArticles(int _artid, int _oldartid, int _batchid)
        {
            bool _test = false;


            int _res = Convert.ToInt32(Helper.GetOneRecord("select dbo.fn_CheckReplaceBatchArticles(" + _artid + "," + _oldartid + ", " + _batchid + ")"));
            _test = _res != 0;

            return _test;
        }

        int _batchid = 0;
        
        public int BatchArtId
        { get; set; }
        public string BatchArticle
        { get; set; }
        public string BatchSecArticle
        { get; set; }
        public string BatchComments
        { get; set; }
        public string BatchSerials
        { get; set; }
        public double BatchQty
        { get; set; }
        public string BatchStartDate
        { get; set; }
        public int IsActive
        { get; set; }
        public int ParentBatchId
        { get; set; }
        public string DateOfClosing
        { get; set; }
        public int Urgent
        { get; set; }
        public string EndDate
        { get; set; }
        public int BatchCOId
        { get; set; }
        public double BatchQtyIn
        { get; set; }
        public double BatchCOPrice
        { get; set; }
        public string BatchCurrency
        { get; set; }
        public string BatchConfOrder
        { get; set; }
        public string BatchCustomer
        { get; set; }
        public int BatchQtyLabels
        { get; set; }
        public int BatchProjectId
        { get; set; }
        public string BatchProject
        { get; set; }
        public int BatchQuotId
        { get; set; }
        public string BatchResDate
        { get; set; }
        public int BatchToFollow
        { get; set; }
        public string Stencil
        { get; set; }
        public string Stencilplace
        { get; set; }
        public int BatchId
        {
            get { return _batchid; }
            set
            {
                _batchid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectBatchHeadDets @id = " + _batchid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
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
                }
                else
                {
                    ClearBatchHead();
                }
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


        public static DataTable getBatchRMDets(int _batchid)
        {
            string query = "EXECUTE sp_SelectBatchRMDets @batchid = " + _batchid;

            return Helper.QueryDT(query);
        }

        #endregion

        #region RM Freezing

        public static DataTable getBatchRM(int _batchid)
        {
            string query = "EXECUTE sp_SelectBatchRMFreezedDets @batchid = " + _batchid;

            return Helper.QueryDT(query);
        }
        
        public static DataTable getBatchCO(int _batchid)
        {
            string query = "EXECUTE sp_SelectBatchCODets @batchid = " + _batchid;

            return Helper.QueryDT(query);
        }

        public static DataTable getBatchStock(int _batchid)
        {
            string query = "EXECUTE sp_SelectBatchStockMove @batchid = " + _batchid;

            return Helper.QueryDT(query);
        }

        public void ReserveRM(int bdid, double qty)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReserveBatchRM", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@bdid", bdid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public static DataTable getArticlesRM(int _artid)
        {
            string query = "EXECUTE sp_SelectArticleFreezedDets @artid = " + _artid;

            return Helper.QueryDT(query);
        }

        public static DataTable getNeedsRM(int _artid)
        {
            string query = "EXECUTE sp_SelectArticleNeedsDets @artid = " + _artid;

            return Helper.QueryDT(query);
        }

        public static DataTable getArtTotalsListRM(int _typeid, int _deptid, int _batchid, int _stageid)
        {
            string query = "sp_SelectArtTotalsList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
            
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
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectArtTotals @artid = " + _totartid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
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
                }
                else
                {
                    ClearArtTotals();
                }
            }
        }
        public double QtyReserved
        { get; set; }
        public double QtyRest
        { get; set; }
        public double QtyNeeds
        { get; set; }
        public double QtyNeedsCO
        { get; set; }
        public double QtyPurchased
        { get; set; }
        public double QtyFreePO
        { get; set; }
        public double QtyNotPlaced
        { get; set; }
        public double QtyInProduction
        { get; set; }
        public double QtyQuarantine
        { get; set; }

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

        public string PasBatch
        { get; set; }

        public string PasCreatedAt
        { get; set; }

        public string PasCreatedBy
        { get; set; }

        public string PasValidatedBy
        { get; set; }

        public string PasArticle
        { get; set; }

        public string PasBatchStages
        { get; set; }

        public string PasCompany
        { get; set; }

        public string PasAddress
        { get; set; }

        public string PasCustArticle
        { get; set; }

        public string PasConfOrder
        { get; set; }

        public string PasBatchComments
        { get; set; }
        public string PasOrderComments
        { get; set; }
        public int PasInternal
        { get; set; }
        public string PasOrderType
        { get; set; }
        public double PasQty
        { get; set; }
        public int PasOrderTypeId
        { get; set; }

        int _pasbatchid = 0;

        public int PasBatchId
        {
            get { return _pasbatchid; }
            set
            {
                _pasbatchid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectBatchPassportTitle @batchid = " + _pasbatchid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
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
                }
                else
                {
                    ClearPasBatch();
                }
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

        public static DataTable getPassportStages(int _batchid)
        {
            string query = "sp_SelectBatchPassportStages";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getPassportWarnings(int _batchid)
        {
            string query = "sp_SelectBatchWarnings";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        #endregion

        #region Launch Passport

        public string LPasBatch
        { get; set; }

        public string LPasCreatedAt
        { get; set; }

        public string LPasCreatedBy
        { get; set; }

        public string LPasValidatedBy
        { get; set; }

        public string LPasArticle
        { get; set; }

        public string LPasLaunchStages
        { get; set; }

        public string LPasCompany
        { get; set; }

        public string LPasAddress
        { get; set; }

        public string LPasCustArticle
        { get; set; }

        public string LPasConfOrder
        { get; set; }

        public string LPasComments
        { get; set; }
        public string LPasOrderComments
        { get; set; }
        public int LPasInternal
        { get; set; }
        public string LPasOrderType
        { get; set; }
        public double LPasQty
        { get; set; }
        public int LPasOrderTypeId
        { get; set; }

        int _paslaunchid = 0;

        public int PasLaunchId
        {
            get { return _paslaunchid; }
            set
            {
                _paslaunchid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectLaunchPassportTitle @launchid = " + _paslaunchid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
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
                }
                else
                {
                    ClearPasLaunch();
                }
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

        public static DataTable getPassportLaunchStages(int _launchid)
        {
            string query = "sp_SelectLaunchPassportStages";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _launchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region Serial numbers

        public static DataTable getSerialNumbers(int _serialnumber, int _usagestate, int _batchid, int _coid, int _artid, int _isactive, int _typeid, 
                            string _usedatefrom, string _usedatetill)
        {
            string query = "EXECUTE sp_SerialNumbersList @serial = " + _serialnumber + ", @usestate = " + _usagestate + ", @batchid = " + _batchid + ", @coid = " + _coid + ", @artid = " + _artid + ", @isactive = " + _isactive +
                            ", @typeid = " + _typeid + ", @usedatefrom = '" + _usedatefrom + "', @usedatetill = '" + _usedatetill + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getSerialNumbersPool(int _serialnumberfrom, int _serialnumbertill)
        {
            string query = "EXECUTE sp_SerialNumbersCheckIn @serialfrom = " + _serialnumberfrom + ", @serialtill = " + _serialnumbertill;

            return Helper.QueryDT(query);
        }

        public void SaveSerialNumbersPool(int _batchid, int _serialnumberfrom, int _serialnumbertill)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveSerialNumbers", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@serialfrom", _serialnumberfrom);
            sqlComm.Parameters.AddWithValue("@serialtill", _serialnumbertill);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteSerialNumber(int _id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteSerialNumber", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        #endregion

        #region Launches

        int _launchid = 0;

        public int LaunchId
        {
            get { return _launchid; }
            set { _launchid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectLaunchHeadDets @id = " + _launchid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
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
                }
                else
                {
                    ClearLaunchHead();
                }
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


        public string LaunchName
        { get; set; }
        public string LaunchStartDate
        { get; set; }
        public string LaunchProdStartDate
        { get; set; }
        public string LaunchEndDate
        { get; set; }
        public double LaunchQty
        { get; set; }
        public int LaunchBatchId
        { get; set; }
        public int LaunchIsStarted
        { get; set; }
        public int LaunchStageId
        { get; set; }
        public string LaunchComments
        { get; set; }
        public int LaunchIsActive
        { get; set; }
        public string LaunchConfOrder
        { get; set; }
        public string LaunchCustomer
        { get; set; }
        public string LaunchArticle
        { get; set; }
        public string LaunchSecArticle
        { get; set; }
        public string LaunchStage
        { get; set; }
        public int LaunchQtyLabels
        { get; set; }
        public int LaunchParentBatchId
        { get; set; }
        public string LaunchAdditComments
        { get; set; }
        public string LaunchVizaComments
        { get; set; }
        public string LaunchSerials
        { get; set; }

        public static DataTable getLaunches(int _batchid, int _coid, int _artid, int _isactive, int _typeid, 
                           string _startdatefrom, string _startdatetill)
        {
            string query = "EXECUTE sp_LaunchesList @batchid = " + _batchid + ", @coid = " + _coid + ", @artid = " + _artid + ",@isactive = " + _isactive +
                            ", @typeid = " + _typeid + ", @startdatefrom = '" + _startdatefrom + "', @startdatetill = '" + _startdatetill + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getLaunchesPortfolio(int _custid, int _typeid, int _stageid, int _artid, string _datefrom, string _datetill)
        {
            string query = "sp_LaunchesPortfolio";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchesPortfolioGantt(int _custid, int _typeid, int _stageid, int _artid, string _datefrom, string _datetill)
        {
            string query = "sp_LaunchesPortfolioGantt";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchHeadDet(int _launchid)
        {
            string query = "sp_SelectLaunchHeadDetsExt";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid },
                
            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchesCreatDet(int _batchid, int _stageid)
        {
            string query = "sp_SelectCreatLaunchDets";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchesCreatDetMB(int _batchid, int _stageid)
        {
            string query = "sp_SelectCreatLaunchDetsForMB";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchesEditDet(int _launchid)
        {
            string query = "sp_SelectLaunchEditDets";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid }
               

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchesAddDet(int _launchid)
        {
            string query = "sp_SelectLaunchAddDets";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid }


            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchesDet(int _launchid)
        {
            string query = "sp_SelectLaunchDets";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchesGroupDet(string _launch)
        {
            string query = "sp_SelectLaunchDetsGroup";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@launch",SqlDbType.NVarChar){Value = _launch }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getBatchLaunches(int _batchid)
        {
            string query = "sp_SelectBatchLaunches";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getBatchLaunchesCO(int _coid)
        {
            string query = "sp_SelectCOLaunches";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@coid",SqlDbType.Int){Value = _coid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getLaunchesStockDet(int _launchdetid)
        {
            string query = "sp_SelectLaunchStockDets";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@launchdetid",SqlDbType.Int){Value = _launchdetid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }
        public static DataTable getLaunchesPassport(int _batchid, int _launchid, int _coid, int _artid, int _isactive, int _typeid,
                           string _startdatefrom, string _startdatetill, int _custid, int _stageid)
        {
            string query = "EXECUTE sp_LaunchesPassportList @batchid = " + _batchid + ", @launchid = " + _launchid + ",@coid = " + _coid + ", @artid = " + _artid + ",@isactive = " + _isactive +
                            ", @typeid = " + _typeid + ", @startdatefrom = '" + _startdatefrom + "', @startdatetill = '" + _startdatetill + "', @custid = " + _custid + ", @stageid = " + _stageid;

            return Helper.QueryDT(query);
        }

        public static DataTable getLaunchesPassportComments(int _id)
        {
            string query = "EXECUTE sp_LaunchesPassportListCom @id = " + _id;

            return Helper.QueryDT(query);
        }

        public static DataTable getLaunchesPassportAddVisas(int _id)
        {
            string query = "EXECUTE sp_LaunchesPassportAddVisas @id = " + _id;

            return Helper.QueryDT(query);
        }

        public static DataTable getLaunchesPassportCommentsList(int _batchid, int _launchid, int _coid, int _artid, int _isactive, int _typeid,
                           string _startdatefrom, string _startdatetill, int _custid, int _stageid, int _state)
        {
            string query = "EXECUTE sp_LaunchesPassportListComReview @batchid = " + _batchid + ", @launchid = " + _launchid + ",@coid = " + _coid + ", @artid = " + _artid + ",@isactive = " + _isactive +
                           ", @typeid = " + _typeid + ", @startdatefrom = '" + _startdatefrom + "', @startdatetill = '" + _startdatetill + "', @custid = " + _custid + ", @stageid = " + _stageid + ", @state = " + _state;

            return Helper.QueryDT(query);
        }

        public void ReserveLaunchLabels(int launchdetid, DataTable tabids)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReserveLaunchLabels", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@launchdetid", launchdetid);
            sqlComm.Parameters.Add("@tablestates", SqlDbType.Structured);
            sqlComm.Parameters["@tablestates"].TypeName = "UT_LabelsLaunchReserve";
            sqlComm.Parameters["@tablestates"].Value = tabids;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void ReleaseLaunchLabels(int launchid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReleaseLaunchLabels", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@launchid", launchid);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }


        public string AddLaunchesToGroup(string _groupname, DataTable _launches)
        {
            string _res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunchesInGroup", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@groupname", _groupname);
            sqlComm.Parameters.Add("@tablelaunches", SqlDbType.Structured);
            sqlComm.Parameters["@tablelaunches"].TypeName = "UT_IDs";
            sqlComm.Parameters["@tablelaunches"].Value = _launches;
            sqlComm.Parameters.Add("@insertedgroup", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@insertedgroup"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public void ReleaseLaunchesfromGroup(DataTable _launches)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReleaseLaunchesFromGroup", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.Add("@tablelaunches", SqlDbType.Structured);
            sqlComm.Parameters["@tablelaunches"].TypeName = "UT_IDs";
            sqlComm.Parameters["@tablelaunches"].Value = _launches;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public string AddLaunchQualityViza(int launchid)
        {
            string _res;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunchQualityViza", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@launchid", launchid);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                _res = sqlComm.Parameters["@success"].Value.ToString();
                sqlConn.Close();
            }
            catch { _res = "Something wrong! Maybe you have no permission to make operation!"; }


            return _res;
        }

        public string AddLaunchQualityAddViza(int id)
        {
            string _res;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunchQualityAddViza", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                _res = sqlComm.Parameters["@success"].Value.ToString();
                sqlConn.Close();
            }
            catch { _res = "Something wrong! Maybe you have no permission to make operation!"; }


            return _res;
        }

        public string EditLaunchVisaComment(int launchid, string comments)
        {
            string _res;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditLaunchVisaComment", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@launchid", launchid);
            sqlComm.Parameters.AddWithValue("@comments", comments);


            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                _res = "Visa comment added successfully!";
                sqlConn.Close();
                
            }
            catch { _res = "Something wrong! Maybe you have no permission to make operation!"; }


            return _res;
        }

        public string AddLaunchAdditVisa(int launchid, string comments)
        {
            string _res;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunchAdditVisa", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@launchid", launchid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
                _res = "Visa added successfully!";
            }
            catch { _res = "Something wrong! Maybe you have no permission to make operation!"; }


            return _res;
        }

        public string EditLaunchAdditVisa(int id, string comments)
        {
            string _res;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditLaunchAdditVisa", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
                _res = sqlComm.Parameters["@success"].Value.ToString();
            }
            catch { _res = "Something wrong! Maybe you have no permission to make operation!"; }
            
            return _res;
        }

        public string AddLaunchIngenViza(int launchid)
        {
            string _res;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunchIngenViza", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@launchid", launchid);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                _res = sqlComm.Parameters["@success"].Value.ToString();
                sqlConn.Close();
            }
            catch { _res = "Something wrong! Maybe you have no permission to make operation!"; }

            return _res;
        }

        public string AddLaunchAdditIngenViza(int launchid)
        {
            string _res;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunchIngenAddViza", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", launchid);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                _res = sqlComm.Parameters["@success"].Value.ToString();
                sqlConn.Close();
            }
            catch { _res = "Something wrong! Maybe you have no permission to make operation!"; }

            return _res;
        }

        public void SavedLaunchPassportComments(int id, int launchid, string comments, string techcomments, int stateid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveLaunchPassportComments", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@launchid", launchid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@techcomments", techcomments);
            sqlComm.Parameters.AddWithValue("@stateid", stateid);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
            
        }

        public int AddLaunch(int batchid, int stageid, double qty, string comments, string startdate, string enddate, DataTable launchdets, string prodstartdate)
        {
            int _res = 0;
            //UT_Launches
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@stageid", stageid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@startdate", startdate);
            sqlComm.Parameters.AddWithValue("@enddate", enddate);
            sqlComm.Parameters.AddWithValue("@prodstartdate", prodstartdate);
            sqlComm.Parameters.Add("@tabledets", SqlDbType.Structured);
            sqlComm.Parameters["@tabledets"].TypeName = "UT_Launches";
            sqlComm.Parameters["@tabledets"].Value = launchdets;


            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);
            sqlConn.Close();

            return _res;
        }

        public void AddLaunchDets(int launchid, DataTable launchdets)
        {
            
            //UT_Launches
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunchDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@launchid", launchid);
            sqlComm.Parameters.Add("@tabledets", SqlDbType.Structured);
            sqlComm.Parameters["@tabledets"].TypeName = "UT_Launches";
            sqlComm.Parameters["@tabledets"].Value = launchdets;
                        
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
                       
        }

        public void AddLaunchDetsMBReserve(int launchid, DataTable launchdetsmb)
        {

            //UT_Launches
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddLaunchDetsMBReserve", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@launchid", launchid);
            sqlComm.Parameters.Add("@tabledets", SqlDbType.Structured);
            sqlComm.Parameters["@tabledets"].TypeName = "UT_LaunchMBReserve";
            sqlComm.Parameters["@tabledets"].Value = launchdetsmb;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }


        public string DeleteLaunch(int id)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteLaunch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res =sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public string EditLaunch(int id, string startdate, string prodstartdate, string enddate, string comments, double qty)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditLaunch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@startdate", startdate);
            sqlComm.Parameters.AddWithValue("@prodstartdate", prodstartdate);
            sqlComm.Parameters.AddWithValue("@enddate", enddate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@qty", qty);

            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public void AddAdditComments(int id, string addcomments)
        {
            

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditLaunchComments", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@additcomments", addcomments);
                       
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void EditLaunchDet(int id, double qty)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditLaunchDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@qty", qty);
                      
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
           
            sqlConn.Close();

          
        }

        public void DeleteLaunchDet(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteLaunchDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();


        }

        public static DataTable StartLaunch(int launchid)
        {
            string query = "sp_StartLaunch";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@launchid",SqlDbType.Int){Value = launchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void AutoReserveLaunch(int launchid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AutoReserveLaunch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@launchid", launchid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();
        }

        public static DataTable getLaunchStages(int _launchid)
        {
            string query = "sp_SelectLaunchPassportStages";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getLaunchVizas(int _launchid)
        {
            string query = "sp_SelectLaunchPassportVizas";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        #endregion

        #region BatchesRatio

        public static DataTable getBatchesRatio(int _batchid, int _artid, int _stageid, int _coid, int _isactive, int _typeid, int _deptid,
                            string _custarticle, string _custorder, string _startdatefrom, string _startdatetill, string _enddatefrom,
                            string _enddatetill, int _custid)
        {
            string query = "sp_BatchesRatioList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid },
                new SqlParameter("@coid",SqlDbType.Int){Value = _coid },
                new SqlParameter("@isactive",SqlDbType.Int){Value = _isactive },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid },
                new SqlParameter("@custarticle",SqlDbType.NVarChar){Value = _custarticle},
                new SqlParameter("@custorder",SqlDbType.NVarChar){Value = _custorder},
                new SqlParameter("@startdatefrom",SqlDbType.NVarChar){Value = _startdatefrom },
                new SqlParameter("@startdatetill",SqlDbType.NVarChar){Value = _startdatetill},
                new SqlParameter("@enddatefrom",SqlDbType.NVarChar){Value = _enddatefrom },
                new SqlParameter("@enddatetill",SqlDbType.NVarChar){Value = _enddatetill},
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }


        #endregion

        #region Batch projects

        public static DataTable getBatchProjects(int _batchid, int _coid, int _artid, int _isactive, int _typeid, int _deptid,
                            string _startdatefrom, string _startdatetill, string _enddatefrom, string _enddatetill, int _showbatches, int _custid)
        {
            string query = "EXECUTE sp_BatchProjectsList @batchid = " + _batchid + ", @coid = " + _coid + ", @artid = " + _artid + ",@isactive = " + _isactive +
                            ", @typeid = " + _typeid + ", @deptid = " + _deptid + ", @startdatefrom = '" + _startdatefrom + "', @startdatetill = '" + _startdatetill +
                            "', @enddatefrom = '" + _enddatefrom + "', @enddatetill = '" + _enddatetill + "', @showbatches = " + _showbatches + ", @custid = " + _custid; 

            return Helper.QueryDT(query);
        }

        string _ProjectName = "";

        public string ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        public int AddBatchProjectHeader(int ArtId, double Qty, string Comments, string StartDate, int IsQuot, string ResDate, int ProdPlaceId)
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
            sqlComm.Parameters.AddWithValue("@ProdPlaceId", ProdPlaceId);

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

        public void EditBatchProjectHeader(int BatchId, int ArtId, double Qty, string Comments, string StartDate, string ResDate, int ProdPlaceId)
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
            sqlComm.Parameters.AddWithValue("@ProdPlaceId", ProdPlaceId);
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

        public int AddBatchHeaderFromProject(int ProjectId, int ArtId, double Qty, string ResDate, string Comments, int Urgent, string Serials, int ProdPlaceId)
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
            sqlComm.Parameters.AddWithValue("@ProdPlaceId", ProdPlaceId);
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

        public void AddBatchDetFromProject(int batchid, DataTable launchdets)
        {
            
            //UT_Launches
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchDetFromProject", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@batchid", batchid);
           
            sqlComm.Parameters.Add("@tabledets", SqlDbType.Structured);
            sqlComm.Parameters["@tabledets"].TypeName = "UT_Launches";
            sqlComm.Parameters["@tabledets"].Value = launchdets;

            

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            
        }

        public int AddBatchProjectDetail(int BatchId, int ArtId, double Qty, string Comments, int IsActive, int DNP)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchProjectDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;


            sqlComm.Parameters.AddWithValue("@batchid", BatchId);
            sqlComm.Parameters.AddWithValue("@ArtId", ArtId);
            sqlComm.Parameters.AddWithValue("@Qty", Qty);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@IsActive", IsActive);
            sqlComm.Parameters.AddWithValue("@DNP", DNP);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            //}
            //catch { }

            return _res;
        }

        #endregion

        #region Launch Groups

        public static DataTable getGroupLaunches(string _groupname)
        {
            string query = "sp_SelectLaunchesGroup";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@groupname",SqlDbType.NVarChar){Value = _groupname }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getGroupLaunchesTot(int _stageid)
        {
            string query = "sp_SelectLaunchesGroupTot";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        #endregion

        #region Batch group

        public static DataTable getGroupBatchesTot(DataTable _stages)
        {
            string query = "sp_SelectBatchesGroupTot";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@tablestages", SqlDbType.Structured) { TypeName = "UT_IDs", Value = _stages},
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getGroupBatches(int _groupid)
        {
            string query = "sp_SelectBatchesGroup";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@id",SqlDbType.Int){Value = _groupid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getBatchStages(int _batchid)
        {
            string query = "sp_SelectBatchStages";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int AddBatchesToGroup(int _groupid, int _batchid, int _ismain)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchesInGroup", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@groupid", _groupid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@ismain", _ismain);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }

        #endregion

        #region Project planning

        public static DataTable getProjectPlanning(int custid, int perc)
        {
            return Helper.QueryDT("execute sp_SelectProjectPlanningFin @custid = " + custid + ", @perc = " + perc);
        }


        public static DataTable getPlanningView(int custid, string dateon)
        {
            return Helper.QueryDT("execute sp_PlanningView @custid = " + custid + ", @dateon = '" + dateon + "'");
        }

        public void AddBatchPlanning(int batchid, double qty, string plandate, string comments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchPlanning", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@plandate", plandate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void EditBatchPlanning(int id, double qty, string plandate, string comments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditBatchPlanning", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@plandate", plandate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteBatchPlanning(int batchid, string week)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteBatchPlanning", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@week", week);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteBatchPlanning(int planid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteBatchPlanningById", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", planid);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public static DataTable getProjectPlanningCapa(int weekscount, DataTable databatches)
        {
            string query = "sp_SelectProjectPlanningCapacityNeeds";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@weekscount",SqlDbType.Int){Value = weekscount },
                new SqlParameter("@tabbatch", SqlDbType.Structured) { TypeName = "UT_BatchQty", Value = databatches}
            };


            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getPlanningCapa(int weekscount)
        {
            string query = "sp_SelectPlanningCapacityNeeds";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@weekscount",SqlDbType.Int){Value = weekscount }                
            };


            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region Capacity

        public static DataTable getCapacityAnalyzis(int _days, DataTable _coids)
        {
            string query = "sp_SelectCOCapacity";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@days",SqlDbType.Int){Value = _days },
                new SqlParameter("@tablescos", SqlDbType.Structured) { TypeName = "UT_IDs", Value = _coids}
               
            };


            return Helper.QuerySP(query, sqlparams.ToArray());
            
        }

        #endregion

        #region Production Planning

        public static DataTable getProdPlanning(int custid, string datefrom, string datetill, int batchid, int coid, int isactive, int prodplaceid)
        {
            //.return Helper.QueryDT("execute sp_SelectProductionPlanningFin @custid = " + custid + ", @datefrom = " + perc);
            string query = "sp_SelectProductionPlanning";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@custid",SqlDbType.Int){Value = custid },
                new SqlParameter("@datefrom", SqlDbType.NVarChar) { Value = datefrom},
                new SqlParameter("@datetill", SqlDbType.NVarChar) { Value = datetill},
                new SqlParameter("@batchid",SqlDbType.Int){Value = batchid },
                new SqlParameter("@coid",SqlDbType.Int){Value = coid },
                new SqlParameter("@isactive",SqlDbType.Int){Value = isactive }
            };


            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getProdPlanningDets(string datefrom, string datetill)
        {
            //.return Helper.QueryDT("execute sp_SelectProductionPlanningFin @custid = " + custid + ", @datefrom = " + perc);
            string query = "sp_SelectProductionPlanningDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom", SqlDbType.NVarChar) { Value = datefrom},
                new SqlParameter("@datetill", SqlDbType.NVarChar) { Value = datetill}

            };


            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void SaveProductionPlanning(DataTable tableplanning)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveProductionPlanning", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.Add("@tableplanning", SqlDbType.Structured);
            sqlComm.Parameters["@tableplanning"].TypeName = "UT_BatchPlanning";
            sqlComm.Parameters["@tableplanning"].Value = tableplanning;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public static DataTable getProductionPlanningCapa(string date, int prodplaceid)
        {
            string query = "sp_SelectProductionPlanningCapacityNeeds";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@date",SqlDbType.NVarChar){Value = date }
            };


            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getProdPlanning2Weeks(string datefrom, int custid, int isactive, int prodplaceid)
        {
            //.return Helper.QueryDT("execute sp_SelectProductionPlanningFin @custid = " + custid + ", @datefrom = " + perc);
            string query = "sp_SelectProductionPlanning2Weeks";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom", SqlDbType.NVarChar) { Value = datefrom},
                new SqlParameter("@custid",SqlDbType.Int){Value = custid },
                new SqlParameter("@isactive",SqlDbType.Int){Value = isactive },
                new SqlParameter("@prodplaceid",SqlDbType.Int){Value = prodplaceid }

            };


            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion
    }
}
