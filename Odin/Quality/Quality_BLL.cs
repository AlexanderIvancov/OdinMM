using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Odin.Global_Classes;


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

    }
}
