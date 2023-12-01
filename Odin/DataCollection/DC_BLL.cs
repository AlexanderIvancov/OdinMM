using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Odin.DataCollection
{
    public class DC_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public void AddDataCollection(int WorkerId, int LaunchId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollection", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);


            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void AddDataCollectionPause(int WorkId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionPause", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workid", WorkId);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void AddDataCollectionResume(int WorkId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionResume", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workid", WorkId);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        #region Serials

        public static DataTable getSerialNumbers(int workerid, int launchid)
        {
            string query = "sp_SelectSerialNumbersByWorkerByDate";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@workerid",SqlDbType.Int){Value = workerid },
                 new SqlParameter("@launchid",SqlDbType.Int){Value = launchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getSerialNumbersNotApproved(int _launchid, int _placeid)
        {
            string query = "sp_SelectSerialNumbersNA";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid },
                 new SqlParameter("@placeid",SqlDbType.Int){Value = _placeid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getSerialNumbersNotApprovedAll(int _placeid)
        {
            string query = "sp_SelectSerialNumbersNAAll";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@placeid",SqlDbType.Int){Value = _placeid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }


        public static DataTable getMaterials(int workerid)
        {
            string query = "sp_SelectMaterialsByWorkerByDate";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@workerid",SqlDbType.Int){Value = workerid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        public static DataTable getMaterialsByLaunch(int launchid)
        {
            string query = "sp_SelectMaterialsByLaunch";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@launchid",SqlDbType.Int){Value = launchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
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

        public double ApproveDataCollection(DataTable data, int workerid)
        {
            double _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionApprove", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

           
            sqlComm.Parameters.Add("@tabledc", SqlDbType.Structured);
            sqlComm.Parameters["@tabledc"].TypeName = "UT_DCApprove";
            sqlComm.Parameters["@tabledc"].Value = data;
            sqlComm.Parameters.AddWithValue("@workerid", workerid);
            sqlComm.Parameters.Add("@qty", SqlDbType.Float).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToDouble(sqlComm.Parameters["@qty"].Value);
            sqlConn.Close();


            return _res;
        }

        public void DeleteDataCollection(int id, int issn)
        {
           
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDataCollection", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@issn", issn);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }


        #endregion

    }
}
