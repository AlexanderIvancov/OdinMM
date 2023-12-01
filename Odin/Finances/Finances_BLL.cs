using Odin.Global_Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Odin.Finances
{
    public class Finances_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getProvodkiIncomes(string _datefrom, string _datetill)
        {
            string query = "sp_ExportInto1CIncomes";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getProvodkiSubconto(string _datefrom, string _datetill)
        {
            string query = "sp_ExportInto1CSubconto";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getDocuments(string _datefrom, string _datetill)
        {
            string query = "sp_SelectDocumentSummasAnalyzis";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getCheckAccounts(string _datefrom, string _datetill, int _account)
        {
            string query = _account == 2110 ? "sp_CheckDifference2110" : _account == 2120 ? "sp_CheckDifference2120" : "sp_CheckDifference2130";
            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getCheckAccountsOutDets(int _headid, string _datefrom, string _datetill)
        {
            string query = "sp_CheckDifference2110OutDets";
            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@headid",SqlDbType.NVarChar){Value = _headid},
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #region Block Date

        public void SetBlockDate(string _blockdate)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "set dateformat dmy update bas_blockdate set blockdate = convert(datetime, '" + _blockdate + "')";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            try { sqlComm.ExecuteNonQuery(); }
            catch { MessageBox.Show("You have no permissions to set block dates!"); }
            sqlConn.Close();

        }

        #endregion

        #region Intrastat

        public static DataTable getIntrastatIncome(string _datefrom, string _datetill)
        {
            string query = "sp_IntrastatIncomes";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };
            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getIntrastatOutcome(string _datefrom, string _datetill)
        {
            string query = "sp_IntrastatOutcomes";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };
            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion
    }
}
