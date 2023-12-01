using Odin.Global_Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.History
{
    public class StockHistory_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getIncomesHistory(int _headid, int _opertypeid, int _typeid, int _supid, int _batchid, int _salesorderid, int _artid, string _article,
                                                    string _datefrom, string _datetill, string _suparticle)
        {
            string query = "sp_StockHistoryIncomes";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@headid",SqlDbType.Int){Value = _headid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@opertypeid",SqlDbType.Int){Value = _opertypeid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@suparticle",SqlDbType.NVarChar){Value = _suparticle},
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@orderid",SqlDbType.Int){Value = _salesorderid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        public static DataTable getOutcomesHistory(int _headid, int _opertypeid, int _typeid, int _custid, int _batchid, int _custorderid, int _artid, string _article,
                                                    string _datefrom, string _datetill, string _custarticle, int _placeid, int _groupbybatch)
        {
            string query = "sp_StockHistoryOutcomes";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@headid",SqlDbType.Int){Value = _headid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@opertypeid",SqlDbType.Int){Value = _opertypeid },
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@custarticle",SqlDbType.NVarChar){Value = _custarticle},
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@conforderid",SqlDbType.Int){Value = _custorderid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@placeid",SqlDbType.NVarChar){Value = _placeid},
                new SqlParameter("@groupbybatch",SqlDbType.NVarChar){Value = _groupbybatch}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        public static DataTable getMovementHistory(int _headid, int _opertypeid, int _typeid, int _batchid, int _salesorderid, int _artid, string _article,
                                                    string _datefrom, string _datetill, int _placefrom, int _placeto)
        {
            string query = "sp_StockHistoryMovements";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@headid",SqlDbType.Int){Value = _headid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@opertypeid",SqlDbType.Int){Value = _opertypeid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@orderid",SqlDbType.Int){Value = _salesorderid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@placefromid",SqlDbType.Int){Value = _placefrom},
                new SqlParameter("@placetoid",SqlDbType.Int){Value = _placeto}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
                
        public static DataTable getStockIncomeTracing(int _idin)
        {
            string query = "sp_StockIncomeTracing";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@idin",SqlDbType.Int){Value = _idin }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getReturnsHistory(int _typeid, int _batchid, int _salesorderid, int _artid, string _article,
                                                    string _datefrom, string _datetill)
        {
            string query = "sp_StockHistoryReturns";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@orderid",SqlDbType.Int){Value = _salesorderid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

    }
}
