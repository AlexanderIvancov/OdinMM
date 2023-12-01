using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Odin.Global_Classes;

namespace Odin.Warehouse.Movements
{
    public class StockMove_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getStockMoveRests(int _label, int _artid, int _placeid, int _batchid, int _stageid)
        {
            string query = "sp_StockMoveRests";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@label",SqlDbType.Int){Value = _label },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@placeid",SqlDbType.NVarChar){Value = _placeid },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveDets(int _outheadid)
        {
            string query = "sp_SelectStockMoveDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _outheadid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveDetsPrint(int _outheadid, int _stageid)
        {
            string query = "sp_SelectMoveDocPrintDef";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _outheadid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveBatchesPrint(int _batchid, int _stageid)
        {
            string query = "sp_SelectMoveDocPrintBatches";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveLaunchesPrint(int _launchid, int _stageid)
        {
            string query = "sp_SelectMoveDocPrintLaunches";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveRouteList(int _batchid)
        {
            string query = "sp_SelectRouteListForBatch";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveLaunch(int _launchid)
        {
            string query = "sp_SelectRouteListForLaunch";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveLaunchGroup(string _groupname)
        {
            string query = "sp_SelectRouteListForLaunchGroup";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@groupname",SqlDbType.NVarChar){Value = _groupname }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveLaunchGroupHead(string _groupname)
        {
            string query = "sp_SelectRouteListForLaunchGroupHead";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@groupname",SqlDbType.NVarChar){Value = _groupname }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveBatchGroupHead(int _groupid)
        {
            string query = "sp_SelectRouteListForBatchGroupHead";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@groupid",SqlDbType.Int){Value = _groupid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveBatchGroup(int _groupid)
        {
            string query = "sp_SelectRouteListForBatchGroup";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@groupid",SqlDbType.Int){Value = _groupid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockMoveLaunchesPrint(string _groupname)
        {
            string query = "sp_SelectMoveDocPrintLaunchesGroup";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@groupname",SqlDbType.NVarChar){Value = _groupname }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        public static DataTable getStockMoveBatchesPrint(int _groupid)
        {
            string query = "sp_SelectMoveDocPrintBatchesGroup";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@groupid",SqlDbType.NVarChar){Value = _groupid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int AddStockMoveLine(int _headid, int _label, double _qty, int _placeid, int _batchdetid, int _reserve, 
                                    int _batchid, int _stageid, double _qtyonstage, string _comments)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockMoveLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@label", _label);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@placeid", _placeid);
            sqlComm.Parameters.AddWithValue("@batchdetid", _batchdetid);
            sqlComm.Parameters.AddWithValue("@reserve", _reserve);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@qtyonstage", _qtyonstage);
            sqlComm.Parameters.AddWithValue("@comments", _comments);

            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);
            sqlConn.Close();

            return _res;
        }

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
        public static string GetStencil(string Article)
        {
            string query = "EXECUTE sp_SelectBOMStencils @Article = " + Article;

            return Helper.QueryDT(query).Rows[0].ItemArray[0].ToString();
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
        public int AddStockMoveLineCorrection(int _headid, int _label, double _qty, int _placeid, int _batchdetid, int _reserve,
                                    int _batchid, int _stageid, double _qtyonstage, string _comments)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockMoveLineCorrection", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@label", _label);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@placeid", _placeid);
            sqlComm.Parameters.AddWithValue("@batchdetid", _batchdetid);
            sqlComm.Parameters.AddWithValue("@reserve", _reserve);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@qtyonstage", _qtyonstage);
            sqlComm.Parameters.AddWithValue("@comments", _comments);

            sqlComm.Parameters.Add("@insertedheadid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedheadid"].Value);
            sqlConn.Close();

            return _res;
        }

        public int DeleteStockMoveLine(int id)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockDealLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@result"].Value);
            sqlConn.Close();

            return _res;
        }

        public int MergeLabel(int label, DataTable tablelabels)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_MergeStockLabels", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@label", label);
            sqlComm.Parameters.Add("@tablelabels", SqlDbType.Structured);
            sqlComm.Parameters["@tablelabels"].TypeName = "UT_Labels";
            sqlComm.Parameters["@tablelabels"].Value = tablelabels;
           
            sqlComm.Parameters.Add("@success", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@success"].Value);
            sqlConn.Close();

            return _res;
        }

        public void SeparateLabel(int label, double qty)
        {
          
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SeparateStockLabels", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@label", label);
            sqlComm.Parameters.AddWithValue("@qty", qty);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            
        }

        public void ReserveLabels(DataTable labels)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReserveLabelsForBatch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
                     
            sqlComm.Parameters.Add("@tablelabels", SqlDbType.Structured);
            sqlComm.Parameters["@tablelabels"].TypeName = "UT_LabelReservation";
            sqlComm.Parameters["@tablelabels"].Value = labels;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
