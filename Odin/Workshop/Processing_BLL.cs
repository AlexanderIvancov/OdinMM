using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Odin.Global_Classes;
namespace Odin.Workshop
{
    public class Processing_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Processing

        public void AddStageProcess(int _batchid , int _stageid , int _prevstageid, double _qty, int _prodplaceid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchStageProcess", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@prevstageid", _prevstageid);
            sqlComm.Parameters.AddWithValue("@qty", _qty);
            sqlComm.Parameters.AddWithValue("@prodplace", _prodplaceid);


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public int SaveLaunchStageProcess(int _launchid, int _prevstageid, int _stageid, int _nextstageid, double _qtystarted, double _qtyfinished, double _qtyfreezed, int _prodplaceid)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveLaunchStageProcess", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@launchid", _launchid);
            sqlComm.Parameters.AddWithValue("@prevstageid", _prevstageid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@nextstageid", _nextstageid);
            sqlComm.Parameters.AddWithValue("@qtystarted", _qtystarted);
            sqlComm.Parameters.AddWithValue("@qtyfinished", _qtyfinished);
            sqlComm.Parameters.AddWithValue("@qtyfreezed", _qtyfreezed);
            sqlComm.Parameters.AddWithValue("@prodplace", _prodplaceid);
            sqlComm.Parameters.Add("@success", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@success"].Value);
            sqlConn.Close();
            return _res;
        }


        public void DeleteStageProcess(int _batchid, int _stageid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteBatchStageProcess", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void FreezeStageProcess(int _batchid, int _stageid, double _qty)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_FreezeBatchStageProcess", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@qty", _qty);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public static DataTable getStages(int _batchid, int _artid, int _stageid, int _coid, int _isactive, int _typeid, int _deptid,
                            string _custarticle, string _custorder, string _startdatefrom, string _startdatetill, string _enddatefrom, 
                            string _enddatetill, int _custid)
        {
            string query = "sp_ProductionStagesList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid },
                new SqlParameter("@coid",SqlDbType.Int){Value = _coid },
                new SqlParameter("@isactive",SqlDbType.Int){Value = _isactive },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid },
                new SqlParameter("@custarticle",SqlDbType.NVarChar){Value = _custarticle},
                new SqlParameter("@custorder",SqlDbType.NVarChar){Value = _custorder},
                new SqlParameter("@startdatefrom",SqlDbType.NVarChar){Value = _startdatefrom },
                new SqlParameter("@startdatetill",SqlDbType.NVarChar){Value = _startdatetill},
                new SqlParameter("@enddatefrom",SqlDbType.NVarChar){Value = _enddatefrom },
                new SqlParameter("@enddatetill",SqlDbType.NVarChar){Value = _enddatetill},
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStagesHistory(int _batchid)
        {
            string query = "sp_SelectBatchProcessHistory";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getProcessingHistory(int _stageid, string _datefrom,
                            string _datetill)
        {
            string query = "sp_SelectBatchStagesProcessHistory";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getBatchLaunchesProcessing(int _batchid, int _stageid)
        {
            string query = "sp_SelectBatchLaunchesProcessing";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region Capacity

        public static DataTable getStages(int stageid)
        {
            string query = "select id, name as stage from bas_stages where id = isnull(nullif(" + stageid + ", 0), id) and indic = -1 order by orderby";

            return Helper.QueryDT(query);
        }

        public static DataTable getShifts(int stageid, int shiftid, int placeid, int typeselection)
        {
            string query = "";
            if (typeselection == 1) //All
                query = "select id, name as stage from bas_shifts where stageid = isnull(nullif(" + stageid + ", 0), stageid) " + 
                " and shiftid = isnull(nullif(" + shiftid + ", 0), shiftid) and placeid = isnull(nullif(" + placeid + ", 0), placeid) order by id";
            else if (typeselection == 0) //Production
                query = "select sh.id, sh.name as stage from bas_shifts sh inner join bas_stages s on s.id = sh.stageid where (isnull(s.quality, 0) = 0 and s.id != 4 and s.id != 9) and stageid = isnull(nullif(" + stageid + ", 0), stageid) " +
                               " and shiftid = isnull(nullif(" + shiftid + ", 0), shiftid) and placeid = isnull(nullif(" + placeid + ", 0), placeid) order by sh.id";
            else //Quality
                query = "select sh.id, sh.name as stage from bas_shifts sh inner join bas_stages s on s.id = sh.stageid where (isnull(s.quality, 0) = -1 or s.id = 4 or s.id = 9) and stageid = isnull(nullif(" + stageid + ", 0), stageid) " +
                                " and shiftid = isnull(nullif(" + shiftid + ", 0), shiftid) and placeid = isnull(nullif(" + placeid + ", 0), placeid) order by sh.id";
            return Helper.QueryDT(query);
        }

        public static DataTable getCapacity(int stageid, string datefrom, string datetill)
        {
            string query = "sp_SelectProductionCapacity";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = datetill},
                new SqlParameter("@stageid",SqlDbType.Int){Value = stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getCapacityShifts(int stageid, string datefrom, string datetill, int @shiftid, int placeid)
        {
            string query = "sp_SelectProductionCapacityShifts";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = datetill},
                new SqlParameter("@stageid",SqlDbType.Int){Value = stageid },
                new SqlParameter("@shiftid",SqlDbType.Int){Value = shiftid },
                new SqlParameter("@placeid",SqlDbType.Int){Value = placeid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void SaveCapacity(string datefrom, string datetill, DataTable stages)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveCapacity", sqlConn);
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

        public void SaveCapacityShift(string datefrom, string datetill, DataTable stages)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveCapacityShift", sqlConn);
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
        #endregion

        #region Indicators

        public static DataTable getProductivityIndicator(string datefrom, string datetill)
        {
            //string query = "sp_SelectProductivityIndicator";
            string query = "sp_SelectProductivityIndicatorWeeks";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getProductivityIndicatorSum(string datefrom, string datetill)
        {
            string query = "sp_SelectProductivityIndicatorSum";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getProductivityIndicatorDets(int _stageid, string _datefrom,
                            string _datetill)
        {
            string query = "sp_SelectProductivityIndicatorDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region Serial numbers

        public string AddSerialNumberTracing(int _stageid, int _batchid, string _serial)
        {
            string _res = "";


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddSerialTracing", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@serial", _serial);
            sqlComm.Parameters.Add("@result", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@result"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public string ReplaceSerialNumberTracing(string _serial, int _stageid, string _replacement)
        {
            string _res = "";


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReplaceSerialTracing", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@serial", _serial);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@replacement", _replacement);

            sqlComm.Parameters.Add("@result", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@result"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public string AddSerialNumberAnalogue(string _serial, string _analogue, int _asprimary)
        {
            string _res = "";


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddSerialAnalogue", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@serial", _serial);
            sqlComm.Parameters.AddWithValue("@analogue", _analogue);
            sqlComm.Parameters.AddWithValue("@asprimary", _asprimary);

            sqlComm.Parameters.Add("@result", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@result"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public static DataTable getQCTracing(int _batchid)
        {
            string query = "sp_SelectQCTracing";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public DataTable UploadSerialNumbers(DataTable dataserials, string machinename)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_UploadSerialNumbers", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@machinename", machinename);
            sqlComm.Parameters.Add("@tableserials", SqlDbType.Structured);
            sqlComm.Parameters["@tableserials"].TypeName = "UT_Serials";
            sqlComm.Parameters["@tableserials"].Value = dataserials;

            sqlConn.Open();
            da.SelectCommand = sqlComm;
            da.Fill(dt);
            sqlConn.Close();
            return dt;
            
        }

        #endregion

        #region Workers

        public static DataTable getWorkers()
        {
            string query = "EXECUTE sp_WorkersList";

            return Helper.QueryDT(query);
        }

        public int SaveWorker(int Id, string UserName, string UserSurname, 
                        string TabNum, int IsActive, string RFID, string Comments, int IsMaster)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveWorker", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlComm.Parameters.AddWithValue("@UserName", UserName);
            sqlComm.Parameters.AddWithValue("@usersurname", UserSurname);
            sqlComm.Parameters.AddWithValue("@TabNum", TabNum);
            sqlComm.Parameters.AddWithValue("@IsActive", IsActive);
            sqlComm.Parameters.AddWithValue("@RFID", RFID);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@IsMaster", IsMaster);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public string DeleteWorker(int Id)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteWorker", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            return _res;
        }

        #endregion

        #region Results
        public static DataTable getProductionResults(string _serial, int _launchid, int _batchid, int _conforderid, int _artid,
                                                    int _typeid, int _workerid, string _datefrom, string _datetill, int _sum, int _concoper)
        {
            string query = "sp_SelectProductionResults";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@serial",SqlDbType.NVarChar){Value = _serial },
                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid, },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@conforderid",SqlDbType.Int){Value = _conforderid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@workerid",SqlDbType.Int){Value = _workerid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill },
                new SqlParameter("@sum",SqlDbType.Int){Value = _sum },
                new SqlParameter("@concoper",SqlDbType.Int){Value = _concoper }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        public static DataTable getProductionMaterials(int _launchid, int _batchid, int _conforderid, int _artid,
                                                    int _typeid, int _workerid, string _datefrom, string _datetill)
        {
            string query = "sp_SelectProductionMaterials";

            var sqlparams = new List<SqlParameter>
            {
               
                new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid, },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@conforderid",SqlDbType.Int){Value = _conforderid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@workerid",SqlDbType.Int){Value = _workerid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        #endregion
    }
}
