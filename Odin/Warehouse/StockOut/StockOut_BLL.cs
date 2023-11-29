using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.StockOut
{
    public class StockOut_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getStockOutDets(int _outheadid)
        {
            string query = "sp_SelectStockOutDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _outheadid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockOutProceedHead(int artid, int batchid, int requestid, int stageid, int leftonly)
        {
            string query = "sp_SelectStockOutcomeForProceed";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = artid },
                new SqlParameter("@batchid",SqlDbType.Int){Value = batchid },
                new SqlParameter("@requestid",SqlDbType.Int){Value = requestid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = stageid },
                new SqlParameter("@left",SqlDbType.Int){Value = leftonly }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockOutProceedDets(int artid, int batchid, int reserved)
        {
            string query = "sp_SelectStockOutcomeForProceedDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = artid },
                new SqlParameter("@batchid",SqlDbType.Int){Value = batchid },
                new SqlParameter("@reserved",SqlDbType.Int){Value = reserved }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockOutProceedRMDets(int batchid)
        {
            string query = "sp_SelectStockOutcomeRMForProceed";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = batchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockOutProceedInDocDets(int headid)
        {
            string query = "sp_SelectStockOutcomeInDocForProceed";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@headid",SqlDbType.Int){Value = headid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int AddStockOutLine(int _headid, int _label, double _qty, int _artid,
                                    int _batchid, int _requestid, string _comments)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockOutLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@label", _label);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@artid", _artid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@requestid", _requestid);
            sqlComm.Parameters.AddWithValue("@comments", _comments);

            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);
            sqlConn.Close();

            return _res;
        }

        public string OutcomeDocResult = "";

        public int AddStockOutLineCons(int _headid, int _label, double _qty, int _artid,
                                   int _batchid, int _setid, string _comments)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockOutLineCons", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@label", _label);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@artid", _artid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@setid", _setid);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedname", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);
            OutcomeDocResult = sqlComm.Parameters["@insertedname"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public int AddStockOutLineSimple(int _headid, int _inid, int _label, double _qty, int _artid,
                                   int _reasonid, string _comments)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockOutLineSimple", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@inid", _inid);
            sqlComm.Parameters.AddWithValue("@label", _label);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@artid", _artid);
            sqlComm.Parameters.AddWithValue("@reasonid", _reasonid);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@inserteddoc", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);
            OutcomeDocResult = sqlComm.Parameters["@inserteddoc"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public void RemoveLabelReservation(int _label)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_RemoveLabelReservation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@label", _label);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void RemoveLabelReservationCorrection(int _label, int _batchdetid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_RemoveLabelReservationCorrection", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@label", _label);
            sqlComm.Parameters.AddWithValue("@batchdetid", _batchdetid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void UpdateSetPrice(int _headid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_UpdateSetPrice", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", _headid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteStockOutLine(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockOutLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void MapLineToBatch(int id, int batchid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_MapStockOutLineToBatch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@batchid", batchid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public string TmpInsertedDoc = "";

        public int AddStockSetHeader(int _outdocid, int _batchid, int _artid, double _qty, string _docdate, string _comments, int _placeid)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockSetHeader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@outdocid", _outdocid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@artid", _artid);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@placeid", _placeid);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedname", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            TmpInsertedDoc = sqlComm.Parameters["@insertedname"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public void UpdateSetActPrice(int idin, string docdate)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_UpdateSetAktPrice", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@idin", idin);
            sqlComm.Parameters.AddWithValue("@docdate", docdate);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void RecalculateFCPrice(int idin, int batchid, string docdate)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_RecalculateFCPrice", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@idin", idin);
            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@docdate", docdate);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

    }
}
