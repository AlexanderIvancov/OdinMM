using System;
using System.Data;
using System.Data.SqlClient;

namespace Odin.DataCollection
{
    public class DC_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        int _matlabel = 0;
        public int MaterialLabel
        {
            get { return _matlabel; }
            set { _matlabel = value; }
        }
        int _successid = 0;
        public int SuccessId
        {
            get { return _successid; }
            set { _successid = value; }
        }

        public string AddDataCollectionSerial(int WorkerId, string Serial, int LaunchId, int PrevStageId)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionSerial", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.AddWithValue("@prevstageid", PrevStageId);
            sqlComm.Parameters.Add("@label", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            MaterialLabel = Convert.ToInt32(sqlComm.Parameters["@label"].Value);
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }

        public string AddDataCollectionSerialOper(int WorkerId, string Serial, int LaunchId, int PrevStageId, int OperId, int IsLast,int PlaceId)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionSerialOper", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.AddWithValue("@operid", OperId);
            sqlComm.Parameters.AddWithValue("@islast", IsLast);
            sqlComm.Parameters.AddWithValue("@prevstageid", PrevStageId);
            sqlComm.Parameters.AddWithValue("@placeid", PlaceId);
            sqlComm.Parameters.Add("@label", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            MaterialLabel = Convert.ToInt32(sqlComm.Parameters["@label"].Value);
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }
        public bool CheckDataCollectionSerialOper(string Serial, int StageId, int LaunchId)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_CheckDataCollectionSerialOper", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.AddWithValue("@stageid", StageId);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res == "Success!" ? true : false;
        }

        public string AddDataCollectionQty(int WorkerId, int LaunchId, double Qty)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionDQ", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.AddWithValue("@qty", Qty);
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }

        public string AddDataCollectionQtyOper(int WorkerId, int LaunchId, double Qty, int OperId, int IsLast, int PlaceId)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionDQOper", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.AddWithValue("@qty", Qty);
            sqlComm.Parameters.AddWithValue("@operid", OperId);
            sqlComm.Parameters.AddWithValue("@islast", IsLast);
            sqlComm.Parameters.AddWithValue("@placeid", PlaceId);
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }
       
        public string DeleteDataCollectionSerial(int Id, string Serial)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDataCollectionSerial", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }

        public string DeleteDataCollectionMaterial(int Id)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDataCollectionMaterial", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);

            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }
    }
}