using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odin.Global_Classes;
using System.Data.SqlClient;
using System.Data;

namespace Odin.Warehouse.Requests
{
    public class Requests_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getRequests(int _requestid, int _batchid, int _coid, int _artid, DataTable _states, int _typeid, int _deptid,
                          string _datefrom, string _datetill, int _custid)
        {
            //string query = "EXECUTE sp_RequestsList  @reqid = " + _requestid + ", @batchid = " + _batchid + ", @coid = " + _coid + ", @artid = " + _artid + ", @isactive = " + _states +
            //                ", @typeid = " + _typeid + ", @deptid = " + _deptid + ", @datefrom = '" + _datefrom + "', @datetill = '" + _datetill + "'";
            string query = "sp_RequestsList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@reqid",SqlDbType.Int){Value = _requestid },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@coid",SqlDbType.Int){Value = _coid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@tablestates", SqlDbType.Structured) { TypeName = "UT_IDs", Value = _states},
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid}
            };


            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getRequestsEnabled()
        {
            string query = "EXECUTE sp_RequestsListEnabled";

            return Helper.QueryDT(query);
        }

        public int RequestHeadId
        { get; set; }


        public int AddRequestDetail(int HeadId, int ArtId, string Article, int BatchDetId, double Qty, int UnitId,
                                string ReqDate, int Urgent, string Comments, int CatId, int Reserve, int CauseId, int PlaceId)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddRequestDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@headid", HeadId);
            sqlComm.Parameters.AddWithValue("@artid", ArtId);
            sqlComm.Parameters.AddWithValue("@article", Article);
            sqlComm.Parameters.AddWithValue("@batchdetid", BatchDetId);
            sqlComm.Parameters.AddWithValue("@qty", Qty);
            sqlComm.Parameters.AddWithValue("@unitid", UnitId);
            sqlComm.Parameters.AddWithValue("@reqdate", ReqDate);
            sqlComm.Parameters.AddWithValue("@urgent", Urgent);
            sqlComm.Parameters.AddWithValue("@comments", Comments);
            sqlComm.Parameters.AddWithValue("@catid", CatId);
            sqlComm.Parameters.AddWithValue("@reserve", Reserve);
            sqlComm.Parameters.AddWithValue("@causeid", CauseId);
            sqlComm.Parameters.AddWithValue("@placeid", PlaceId);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            RequestHeadId = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);

            sqlConn.Close();
            //}
            //catch { }

            return _res;
        }

        public void EditRequestDetail(int Id, int ArtId, string Article, int BatchDetId, double Qty, int UnitId,
                                        string ReqDate, int Urgent, string Comments, int CatId, int State, int CauseId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditRequestDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@artid", ArtId);
            sqlComm.Parameters.AddWithValue("@article", Article);
            sqlComm.Parameters.AddWithValue("@batchdetid", BatchDetId);
            sqlComm.Parameters.AddWithValue("@qty", Qty);
            sqlComm.Parameters.AddWithValue("@unitid", UnitId);
            sqlComm.Parameters.AddWithValue("@reqdate", ReqDate);
            sqlComm.Parameters.AddWithValue("@urgent", Urgent);
            sqlComm.Parameters.AddWithValue("@comments", Comments);
            sqlComm.Parameters.AddWithValue("@catid", CatId);
            sqlComm.Parameters.AddWithValue("@state", State);
            sqlComm.Parameters.AddWithValue("@causeid", CauseId);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteRequestDetail(int Id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteRequestDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", Id);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void ReplaceRequestDetail(int Id, int BatchId, int ArtId, string Comments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReplaceRequestDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@oldbatchdetid", BatchId);
            sqlComm.Parameters.AddWithValue("@artid", ArtId);
            sqlComm.Parameters.AddWithValue("@comments", Comments);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }


        int _RequestDetId = 0;
        public int RequestDetId
        {
            get { return _RequestDetId; }
            set {
                _RequestDetId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectRequestDet @id = " + _RequestDetId, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        RDArtId = Convert.ToInt32(dr["artid"]);
                        RDArticle = dr["article"].ToString();
                        RDBatchDetId = Convert.ToInt32(dr["batchdetid"]);
                        RDCatId = Convert.ToInt32(dr["catid"]);
                        RDComments = dr["comments"].ToString();
                        RDHeadId = Convert.ToInt32(dr["headid"]);
                        RDQty = Convert.ToDouble(dr["qty"]);
                        RDQtyOut = Convert.ToDouble(dr["qtyout"]);
                        RDReqDate = dr["reqdate"].ToString();
                        RDState = Convert.ToInt32(dr["state"]);
                        RDUrgent = Convert.ToInt32(dr["urgent"]);
                        RDUnitid = Convert.ToInt32(dr["unitid"]);
                        RDBatch = dr["batch"].ToString();
                        RDCauseId = Convert.ToInt32(dr["causeid"]);
                        RDBatchStateId = Convert.ToInt32(dr["batchisactive"]);
                        RDReqName = dr["reqname"].ToString();
                    }
                }
                else
                {
                    ClearRDets();
                }
            }
        }

        public void ClearRDets()
        {
            RDBatchDetId = 0;
            RDArticle = "";
            RDArtId = 0;
            RDCatId = 0;
            RDComments = "";
            RDHeadId = 0;
            RDQty = 0;
            RDQtyOut = 0;
            RDReqDate = "";
            RDState = 0;
            RDUnitid = 0;
            RDUrgent = 0;
            RDBatch = "";
            RDCauseId = 0;
            RDBatchStateId = 0;
            RDReqName = "";
        }
        public int RDBatchDetId
        { get; set; }
        public int RDArtId
        { get; set; }
        public string RDArticle
        { get; set; }
        public int RDUrgent
        { get; set; }
        public int RDState
        { get; set; }
        public int RDUnitid
        { get; set; }
        public double RDQty
        { get; set; }
        public double RDQtyOut
        { get; set; }
        public int RDHeadId
        { get; set; }
        public int RDCatId
        { get; set; }
        public string RDReqDate
        { get; set; }
        public string RDComments
        { get; set; }
        public string RDBatch
        { get; set; }
        public int RDCauseId
        { get; set; }
        public int RDBatchStateId
        { get; set; }
        public string RDReqName
        { get; set; }

        public static DataTable getRequestRMDets(int _requestid)
        {
            string query = "EXECUTE sp_SelectRequestRMDets @reqid = " + _requestid;

            return Helper.QueryDT(query);
        }

        #region History

        public static DataTable getHistoryOutcomes(int _id)
        {
            string query = "EXECUTE sp_SelectRequestOutcomes @id = " + _id;

            return Helper.QueryDT(query);
        }

        public static DataTable getHistoryRequests(string _request)
        {
            string query = "EXECUTE sp_SelectRequestHistory @request = '" + _request + "'";

            return Helper.QueryDT(query);
        }

        #endregion
    }
}
