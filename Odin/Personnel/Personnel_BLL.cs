using Odin.Global_Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Odin.Personnel
{
    public class Personnel_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getDayStaff(string datefrom, string datetill)
        {
            string query = "sp_SelectStaffByDate";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void SaveStaffPresence(string datefrom, string datetill, DataTable stages)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveStaffPresence", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@datefrom", datefrom);
            sqlComm.Parameters.AddWithValue("@datetill", datetill);
            sqlComm.Parameters.Add("@tablestages", SqlDbType.Structured);
            sqlComm.Parameters["@tablestages"].TypeName = "UT_CapaStages";
            sqlComm.Parameters["@tablestages"].Value = stages;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
