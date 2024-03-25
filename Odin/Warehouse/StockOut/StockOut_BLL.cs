using System;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.StockOut
{
    public class StockOut_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

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
    }
}