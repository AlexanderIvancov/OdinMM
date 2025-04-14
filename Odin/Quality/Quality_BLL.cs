using Odin.Global_Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Odin.Quality
{
    public class Quality_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getIncomeControlList(int _typeid, int _supid, int _artid, string _article,
                                                    string _secname)
        {
            string query = "sp_IncomeControlList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@secname",SqlDbType.NVarChar){Value = _secname}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void SaveIncomeControl(int id, int artid, int supid,   string comments)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveIncomeControl", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@supid", supid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteIncomeControl(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteIncomeControl", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public static DataTable getIncomeControlResultList(int _typeid, int _supid, int _artid, string _article,
                                                   string _secname, string _datefrom, string _datetill, int _batchid)
        {
            string query = "sp_IncomeControlResultList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@secname",SqlDbType.NVarChar){Value = _secname},
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void SaveIncomeControlResult(int id, int idin, double qtychecked, double qtyscrap, string reclamation, string comments, string checkdate, string controller)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveIncomeControlResult", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@inid", idin);
            sqlComm.Parameters.AddWithValue("@qtychecked", qtychecked);
            sqlComm.Parameters.AddWithValue("@qtyscrap", qtyscrap);
            sqlComm.Parameters.AddWithValue("@reclamation", reclamation);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@checkdate", checkdate);
            sqlComm.Parameters.AddWithValue("@controller", controller);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteIncomeControlResult(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteIncomeControlResult", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public static DataTable getStockForIncomeControl(int _artid, int _headid)
        {
            string query = "sp_StockIncomesForControl";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@headid",SqlDbType.Int){Value = _headid }


            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

    }
}
