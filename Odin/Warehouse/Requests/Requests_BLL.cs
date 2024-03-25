using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.Requests
{
    public class Requests_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public int RequestHeadId { get; set; }

        public int AddRequestDetail(int HeadId, int ArtId, string Article, int BatchDetId, double Qty, int UnitId,
                                 string ReqDate, int Urgent, string Comments, int CatId, int Reserve, int CauseId,
                                 int PlaceId, string Serials)
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
            sqlComm.Parameters.AddWithValue("@serials", Serials);

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

        int _RequestDetId = 0;
        public int RequestDetId
        {
            get { return _RequestDetId; }
            set {
                _RequestDetId = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectRequestDet", _RequestDetId);

                if (dt.Rows.Count > 0)
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
                        RDSerials = dr["serials"].ToString();
                    }
                else
                    ClearRDets();
            }
        }
        public int RDBatchDetId { get; set; }
        public int RDArtId { get; set; }
        public string RDArticle { get; set; }
        public int RDUrgent { get; set; }
        public int RDState { get; set; }
        public int RDUnitid { get; set; }
        public double RDQty { get; set; }
        public double RDQtyOut { get; set; }
        public int RDHeadId { get; set; }
        public int RDCatId { get; set; }
        public string RDReqDate { get; set; }
        public string RDComments { get; set; }
        public string RDBatch { get; set; }
        public int RDCauseId { get; set; }
        public int RDBatchStateId { get; set; }
        public string RDReqName { get; set; }
        public string RDSerials { get; set; }

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
            RDSerials = "";
        }
    }
}