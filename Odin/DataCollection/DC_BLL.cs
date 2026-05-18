using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Odin.DataCollection
{
    public class DC_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public void AddDataCollection(int WorkerId, int LaunchId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollection", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);


            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void AddDataCollectionPause(int WorkId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionPause", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workid", WorkId);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void AddDataCollectionResume(int WorkId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionResume", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workid", WorkId);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        #region Serials

        public static DataTable getSerialNumbers(int workerid, int launchid)
        {
            string query = "sp_SelectSerialNumbersByWorkerByDate";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@workerid",SqlDbType.Int){Value = workerid },
                 new SqlParameter("@launchid",SqlDbType.Int){Value = launchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getSerialNumbersNotApproved(int _launchid, int _placeid)
        {
            string query = "sp_SelectSerialNumbersNA";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@launchid",SqlDbType.Int){Value = _launchid },
                 new SqlParameter("@placeid",SqlDbType.Int){Value = _placeid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getSerialNumbersNotApprovedAll(int _placeid)
        {
            string query = "sp_SelectSerialNumbersNAAll";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@placeid",SqlDbType.Int){Value = _placeid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }


        public static DataTable getMaterials(int workerid)
        {
            string query = "sp_SelectMaterialsByWorkerByDate";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@workerid",SqlDbType.Int){Value = workerid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        public static DataTable getMaterialsByLaunch(int launchid, int topbot)
        {
            string query = "sp_SelectMaterialsByLaunch";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@launchid",SqlDbType.Int){Value = launchid },
                 new SqlParameter("@topbot",SqlDbType.Int){Value = topbot }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        int _matlabel = 0;
        public int MaterialLabel
        {
            get { return _matlabel; }
            set { _matlabel = value; }
        }
        int _successid = 0;
        public int SuccessId
        {
            get { return _successid; }
            set { _successid = value; }
        }
        public string AddDataCollectionSerial(int WorkerId, string Serial, int LaunchId, int PrevStageId)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionSerial", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.AddWithValue("@prevstageid", PrevStageId);
            sqlComm.Parameters.Add("@label", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            MaterialLabel = Convert.ToInt32(sqlComm.Parameters["@label"].Value);
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }
        public string AddDataCollectionSerialOper(int WorkerId, string Serial, int LaunchId, int PrevStageId, int OperId, int IsLast,int PlaceId)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionSerialOper", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.AddWithValue("@operid", OperId);
            sqlComm.Parameters.AddWithValue("@islast", IsLast);
            sqlComm.Parameters.AddWithValue("@prevstageid", PrevStageId);
            sqlComm.Parameters.AddWithValue("@placeid", PlaceId);
            sqlComm.Parameters.Add("@label", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            MaterialLabel = Convert.ToInt32(sqlComm.Parameters["@label"].Value);
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }
        public bool CheckDataCollectionSerialOper(string Serial, int StageId, int LaunchId)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_CheckDataCollectionSerialOper", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.AddWithValue("@stageid", StageId);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res == "Success!" ? true : false;
        }

        public string AddDataCollectionQty(int WorkerId, int LaunchId, double Qty)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionDQ", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.AddWithValue("@qty", Qty);
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }
        public string AddDataCollectionQtyOper(int WorkerId, int LaunchId, double Qty, int OperId, int IsLast, int PlaceId)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionDQOper", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.AddWithValue("@qty", Qty);
            sqlComm.Parameters.AddWithValue("@operid", OperId);
            sqlComm.Parameters.AddWithValue("@islast", IsLast);
            sqlComm.Parameters.AddWithValue("@placeid", PlaceId);
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }
       
        public string DeleteDataCollectionSerial(int Id, string Serial)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDataCollectionSerial", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }

        public string DeleteDataCollectionMaterial(int Id)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDataCollectionMaterial", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }

        public double ApproveDataCollection(DataTable data, int workerid)
        {
            double _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionApprove", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

           
            sqlComm.Parameters.Add("@tabledc", SqlDbType.Structured);
            sqlComm.Parameters["@tabledc"].TypeName = "UT_DCApprove";
            sqlComm.Parameters["@tabledc"].Value = data;
            sqlComm.Parameters.AddWithValue("@workerid", workerid);
            sqlComm.Parameters.Add("@qty", SqlDbType.Float).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToDouble(sqlComm.Parameters["@qty"].Value);
            sqlConn.Close();


            return _res;
        }

        public void DeleteDataCollection(int id, int issn)
        {
           
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDataCollection", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@issn", issn);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }


        #endregion

        #region Machine Data Collection

        int _MDCHeadid = 0;
        public int MDCHeadid
        {
            get { return _MDCHeadid; }
            set
            {
                _MDCHeadid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectControlCardHead @id = " + _MDCHeadid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        MDCLineId = Convert.ToInt32(dr["lineid"]);
                        MDCLaunchId = Convert.ToInt32(dr["launchid"]);
                        MDCBatchId = Convert.ToInt32(dr["batchid"]);
                        MDCTopBot = Convert.ToInt32(dr["topbot"]);
                        MDCTermProfDate = dr["termprofiledate"].ToString();
                        MDCTermProfBy = dr["termprofileby"].ToString();
                        MDCMountDate = dr["mounterdate"].ToString();
                        MDCMountBy = dr["mounterby"].ToString();
                        MDCPasteDate = dr["pastedate"].ToString();
                        MDCPasteBy = dr["pasteby"].ToString();
                        MDCOvenCheckDate = dr["ovendate"].ToString();
                        MDCOvenCheckBy = dr["ovencheckby"].ToString();
                    }
                }
                else
                {
                    ClearMDCHead();
                }

            }
        }

        public void ClearMDCHead()
        {
            MDCLineId = 0;
            MDCLaunchId = 0;
            MDCBatchId = 0;
            MDCTopBot = 0;
            MDCTermProfDate = "";
            MDCTermProfBy = "";
            MDCMountDate = "";
            MDCMountBy = "";
            MDCPasteBy = "";
            MDCPasteDate = "";
            MDCOvenCheckDate = "";
            MDCOvenCheckBy = "";
        }

        public int MDCLineId
        { get; set; }
        public int MDCBatchId
        { get; set; }
        public int MDCLaunchId
        { get; set; }
        public int MDCTopBot
        { get; set; }
        public string MDCTermProfDate
        { get; set; }
        public string MDCTermProfBy
        { get; set; }
        public string MDCMountDate
        { get; set; }
        public string MDCMountBy
        { get; set; }
        public string MDCPasteDate
        { get; set; }
        public string MDCPasteBy
        { get; set; }
        public string MDCOvenCheckDate
        { get; set; }
        public string MDCOvenCheckBy
        { get; set; }

        public int SaveControlCardHeader(int _headid, int _lineid, int _launchid, int _batchid,
                    string _createdby,
                    int _topbot)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveControlCardHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", _headid);
            sqlComm.Parameters.AddWithValue("@lineid", _lineid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@launchid", _launchid);
            sqlComm.Parameters.AddWithValue("@topbot", _topbot);
            sqlComm.Parameters.AddWithValue("@createdby", _createdby);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;


            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }

        public void SetControlCardHeaderTerm(int _headid, string _termprofileby, int _stateid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveControlCardHeadTerm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", _headid);
            sqlComm.Parameters.AddWithValue("@termprofileby", _termprofileby);
            sqlComm.Parameters.AddWithValue("@stateid", _stateid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }


        public void SetControlCardHeaderMount(int _headid, string _mounterby, int _stateid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveControlCardHeadMount", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", _headid);
            sqlComm.Parameters.AddWithValue("@mounterby", _mounterby);
            sqlComm.Parameters.AddWithValue("@stateid", _stateid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void SetControlCardHeaderOvenCheck(int _headid, string _ovencheckby, int _stateid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveControlCardHeadOvenCheck", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", _headid);
            sqlComm.Parameters.AddWithValue("@ovencheckby", _ovencheckby);
            sqlComm.Parameters.AddWithValue("@stateid", _stateid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void SetControlCardHeaderPaste(int _headid, string _pasteby, int _stateid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveControlCardHeadPaste", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", _headid);
            sqlComm.Parameters.AddWithValue("@pasteby", _pasteby);
            sqlComm.Parameters.AddWithValue("@stateid", _stateid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public static DataTable getSerialNumbersMach(int launchid, int topbot)
        {
            string query = "sp_SelectSerialNumbersByMachine";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@launchid",SqlDbType.Int){Value = launchid },
                 new SqlParameter("@topbot",SqlDbType.Int){Value = topbot },
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void SaveControlCardDet(int _id, int _headid, string _feeder, int _oldlabelid, int _labelid,
                    string _platesn,
                    int _workerid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveControlCardDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@feeder", _feeder);
            sqlComm.Parameters.AddWithValue("@oldlabelid", _oldlabelid);
            sqlComm.Parameters.AddWithValue("@labelid", _labelid);
            sqlComm.Parameters.AddWithValue("@platesn", _platesn);
            sqlComm.Parameters.AddWithValue("@workerid", _workerid);

            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }           
        }

        public string AddDataCollectionMachMaterial(int WorkerId, string Serial, int LaunchId, int TopBot)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDataCollectionMachMaterial", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@workerid", WorkerId);
            sqlComm.Parameters.AddWithValue("@serial", Serial);
            sqlComm.Parameters.AddWithValue("@launchid", LaunchId);
            sqlComm.Parameters.Add("@label", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.AddWithValue("@topbot", TopBot);
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            MaterialLabel = Convert.ToInt32(sqlComm.Parameters["@label"].Value);
            SuccessId = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();
            //}
            //catch { }
            return _res;
        }

        public void DeleteDataCollectionMachine(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDataCollectionMachine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);


            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }

        }

        #endregion

    }
}
