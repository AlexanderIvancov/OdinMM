using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.Reports
{
    public class StockRep_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getIncomesReports(int _supid, int _typeid,  int _operid, 
                                                    string _datefrom, string _datetill, 
                                                    int _countries, int _includena)
        {
            string query = "sp_StockReportsIncomes";

            var sqlparams = new List<SqlParameter>
            {   
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@opertypeid",SqlDbType.Int){Value = _operid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@countries",SqlDbType.Int){Value = _countries },
                new SqlParameter("@includena",SqlDbType.Int){Value = _includena }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getIncomesReportsSum(int _supid, int _typeid, int _operid,
                                                    string _datefrom, string _datetill, 
                                                    int _countries, int _includena)
        {
            string query = "sp_StockReportsIncomesSum";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@opertypeid",SqlDbType.Int){Value = _operid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@countries",SqlDbType.Int){Value = _countries },
                new SqlParameter("@includena",SqlDbType.Int){Value = _includena }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getInventoryReports(int _artid, string _date, int _placeid, int _typeid, 
                                                     int _groupbyplaces, int _groupbydoc, int _groupbylabel,
                                                     int _movtypeid, int _showintransit, int _showwip, 
                                                     int _groupbyprices, int _resppersid)
        {
            string query = Convert.ToDateTime(_date) <= Convert.ToDateTime("31.12.2019") ? "sp_SelectStockRestsOnDate1706" : "sp_SelectStockRestsOnDate";
            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@date",SqlDbType.NVarChar){Value = _date},
                new SqlParameter("@placeid",SqlDbType.Int){Value = _placeid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@groupbyplaces",SqlDbType.Int){Value = _groupbyplaces },
                new SqlParameter("@groupbydoc",SqlDbType.Int){Value = _groupbydoc },
                new SqlParameter("@groupbylabel",SqlDbType.Int){Value = _groupbylabel },
                new SqlParameter("@movtypeid",SqlDbType.Int){Value = _movtypeid },
                new SqlParameter("@showintransit",SqlDbType.Int){Value = _showintransit },
                new SqlParameter("@showwip",SqlDbType.Int){Value = _showwip },
                new SqlParameter("@groupbyprices",SqlDbType.Int){Value = _groupbyprices },
                new SqlParameter("@resppersid",SqlDbType.Int){Value = _resppersid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getInventoryReportsFA(int _artid, string _date, int _placeid, int _typeid,
                                                     int _groupbyplaces, int _groupbydoc, int _groupbylabel,
                                                     int _movtypeid, int _groupbyprices, int _resppersid)
        {
            string query = "";


            query = "sp_SelectStockRestsOnDateFA";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@date",SqlDbType.NVarChar){Value = _date},
                new SqlParameter("@placeid",SqlDbType.Int){Value = _placeid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@groupbyplaces",SqlDbType.Int){Value = _groupbyplaces },
                new SqlParameter("@groupbydoc",SqlDbType.Int){Value = _groupbydoc },
                new SqlParameter("@groupbylabel",SqlDbType.Int){Value = _groupbylabel },
                new SqlParameter("@movtypeid",SqlDbType.Int){Value = _movtypeid },
                new SqlParameter("@groupbyprices",SqlDbType.Int){Value = _groupbyprices },
                new SqlParameter("@resppersid",SqlDbType.Int){Value = _resppersid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }


        public static DataTable getInventoryReportsAccount(string _date, string _account, 
                                                     int _groupbyplaces, int _groupbydoc, 
                                                     int _groupbylabel, int _groupbyprices)
        {
            string query = Convert.ToDateTime(_date) <= Convert.ToDateTime("31.12.2019")
                ? "sp_SelectStockRestsOnDateAccount1706"
                : "sp_SelectStockRestsOnDateAccount";
            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@date",SqlDbType.NVarChar){Value = _date},
                new SqlParameter("@account",SqlDbType.Int){Value = _account },
                new SqlParameter("@groupbyplaces",SqlDbType.Int){Value = _groupbyplaces },
                new SqlParameter("@groupbydoc",SqlDbType.Int){Value = _groupbydoc },
                new SqlParameter("@groupbylabel",SqlDbType.Int){Value = _groupbylabel },
                new SqlParameter("@groupbyprices",SqlDbType.Int){Value = _groupbyprices }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getMovementReports(int _typeid, int _operid,
                                                    string _datefrom, string _datetill)
        {
            string query = "sp_StockReportsMovement";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@opertypeid",SqlDbType.Int){Value = _operid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getMovementReportsSum(int _typeid, int _operid,
                                                    string _datefrom, string _datetill)
        {
            string query = "sp_StockReportsMovementSum";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@opertypeid",SqlDbType.Int){Value = _operid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getDeadStock(int _typeid, string _date)
        {
            string query = "sp_SelectDeadStock";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@date",SqlDbType.NVarChar){Value = _date}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
    }
}
