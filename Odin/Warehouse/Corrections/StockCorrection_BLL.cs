using Odin.Global_Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.Corrections
{
    public class StockCorrection_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getStockOutForBatch(int _batchid, int _stageid)
        {
            string query = "sp_SelectBatchRMOutDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void ReturnRMFromProduction(int bdid, int label, double qty)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockReturnLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@bdid", bdid);
            sqlComm.Parameters.AddWithValue("@label", label);
            sqlComm.Parameters.AddWithValue("@qty", qty);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

    }
}
