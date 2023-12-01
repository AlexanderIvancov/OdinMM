using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.Inventory
{
    public class StockInventory
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Inventory

        public static DataTable getStockInventory(int _artid, int _typeid, int _supid, string _article, int _placeid, int _deptid,
                                                int _labelid, int _groupby, int _batchid, int _totals, string _invnumber)
        {
            string query = "sp_StockInventory";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@placeid",SqlDbType.Int){Value = _placeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid},
                new SqlParameter("@label",SqlDbType.Int){Value = _labelid},
                new SqlParameter("@group",SqlDbType.Int){Value = _groupby},
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid},
                new SqlParameter("@totals",SqlDbType.Int){Value = _totals},
                new SqlParameter("@invnumbertext",SqlDbType.NVarChar){Value = _invnumber}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInventoryOnDate(int _artid, int _typeid, int _supid, string _article, int _placeid, int _deptid,
                                                int _labelid, int _groupby, int _batchid, int _totals, string _date)
        {
            string query = "sp_StockInventoryOnDate";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@placeid",SqlDbType.Int){Value = _placeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid},
                new SqlParameter("@label",SqlDbType.Int){Value = _labelid},
                new SqlParameter("@group",SqlDbType.Int){Value = _groupby},
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid},
                new SqlParameter("@totals",SqlDbType.Int){Value = _totals},
                new SqlParameter("@date",SqlDbType.NVarChar){Value = _date}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockRests(int _artid)
        {
            string query = "sp_SelectStockRests";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getSpecifications(int _label)
        {
            string query = "sp_SelectStockLabelSpecification";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@label",SqlDbType.Int){Value = _label }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getInDocs(int _label)
        {
            string query = "sp_SelectStockLabelInDocs";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _label }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getLabelReservations(int _label)
        {
            string query = "sp_SelectStockLabelReservations";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _label }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int ArtIdFromLabel(int Label)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "select distinct artid from sto_rests where id = @id";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlComm.Parameters.AddWithValue("@id", Label);
            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                _res = Convert.ToInt32(reader["artid"]);
                reader.Close();
            }
            else
            {
                _res = 0;
            }
            sqlConn.Close();
            return _res;
        }

        #endregion

        #region Label


        public void EditStockLabel(int id, string expdate, int usage, int parentlabel, string comments, string datacode, string manufbatch)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditStockLabel", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@expdate", expdate);
            sqlComm.Parameters.AddWithValue("@usage", usage);
            sqlComm.Parameters.AddWithValue("@parentlabel", parentlabel);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@datacode", datacode);
            sqlComm.Parameters.AddWithValue("@manufbatch", manufbatch);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void RemoveLabelReservation(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_RemoveLabelReservation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@label", id);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion

        #region Tracing

        public static DataTable getStockLabelTracing(int _label)
        {
            string query = "sp_StockLabelTracing";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@label",SqlDbType.Int){Value = _label }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region ProductCard

        public static DataTable getProductCard(int _artid, string _datefrom, string _datetill, int _type, int _account)
        {
            string query = "sp_SelectProductCard";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@type",SqlDbType.Int){Value = _type },
                new SqlParameter("@accountid",SqlDbType.Int){Value = _account }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region Package

        public static DataTable getBatchBoxList(int _boxid, string _serial, int _batchid, int _conforderid, int _artid, int _delivnoteid, int _typeid, string _closingdate)
        {
            string query = "sp_SelectBatchBoxList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@boxid",SqlDbType.Int){Value = _boxid },
                new SqlParameter("@serial",SqlDbType.NVarChar){Value = _serial },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@conforderid",SqlDbType.Int){Value = _conforderid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@delivnoteid",SqlDbType.Int){Value = _delivnoteid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@closingdate",SqlDbType.NVarChar){Value = _closingdate },

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion
    }
}
