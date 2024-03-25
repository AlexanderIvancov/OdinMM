using System;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.Movements
{
    public class StockMove_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        string _insertedmovdoc = "";
        public string InsertedMovDoc
        {
            get { return _insertedmovdoc; }
            set { _insertedmovdoc = value; }
        }

        public int AddStockMoveLinePDA(int _headid, int _label, double _qty, int _typemove, int _batchdetid, int _batchid)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockMoveLinePDA", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@label", _label);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@typemove", _typemove);
            sqlComm.Parameters.AddWithValue("@batchdetid", _batchdetid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);

            sqlComm.Parameters.Add("@insertedname", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            InsertedMovDoc = sqlComm.Parameters["@insertedname"].Value.ToString();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);
            sqlConn.Close();

            return _res;
        }

        public int AddStockMoveLinePDAGroup(int _headid, int _label, double _qty, int _typemove, string _groupname)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockMoveLinePDAGroup", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@label", _label);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@typemove", _typemove);
            sqlComm.Parameters.AddWithValue("@groupname", _groupname);
           
            sqlComm.Parameters.Add("@insertedname", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            InsertedMovDoc = sqlComm.Parameters["@insertedname"].Value.ToString();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);
            sqlConn.Close();

            return _res;
        }
    }
}