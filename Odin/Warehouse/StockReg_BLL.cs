using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
namespace Odin.Warehouse
{
    public class StockReg_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Stock Places

        int _placeid = 0;

        public string PlaceName
        { get; set; }
        public string PlaceDescription
        { get; set; }
        public int PlaceParentId
        { get; set; }
        public string PlaceCreatedAt
        { get; set; }
        public string PlaceCreatedBy
        { get; set; }
        public int PlaceDeptId
        { get; set; }
        public int PlaceFirmId
        { get; set; }
        public int PlaceIsProduction
        { get; set; }
        public int PlaceRespPersonId
        { get; set; }
        public int PlaceAddressId
        { get; set; }
        public int PlaceQuarantine
        { get; set; }

        public int PlaceOwnerId
        {
            get; set;
        }


        public int PlaceId
        {
            get { return _placeid; }
            set
            {
                _placeid = value;

                var data = Helper.QueryDT("set dateformat dmy select distinct s.id, s.name, isnull(s.description, '') as description, s.parentid, convert(nvarchar(10), s.createdat, 103) as createdat, s.createdby, isnull(s.deptid, 0) as deptid, " +
                     " isnull(s.firmid, 0) as firmid, isnull(s.isproduction, 0) as isproduction, isnull(s.resppersonid, 0) as resppersonid, isnull(s.addressid, 0) as addressid, isnull(s.quarantine, 0) as quarantine, isnull(s.ownerid, 0) as ownerid " +
                     " from sto_shelves s where s.id = " + PlaceId);
                if (data.Rows.Count > 0)
                {
                    foreach (System.Data.DataRow dr in data.Rows)
                    {

                        PlaceName = dr["name"].ToString();
                        PlaceDescription = dr["description"].ToString();
                        PlaceParentId = Convert.ToInt32(dr["parentid"]);
                        PlaceCreatedAt = dr["createdat"].ToString();
                        PlaceCreatedBy = dr["createdby"].ToString();
                        PlaceAddressId = Convert.ToInt32(dr["addressid"]);
                        PlaceDeptId = Convert.ToInt32(dr["deptid"]);
                        PlaceFirmId = Convert.ToInt32(dr["firmid"]);
                        PlaceIsProduction = Convert.ToInt32(dr["isproduction"]);
                        PlaceRespPersonId = Convert.ToInt32(dr["resppersonid"]);
                        PlaceQuarantine = Convert.ToInt32(dr["quarantine"]);
                        PlaceOwnerId = Convert.ToInt32(dr["ownerid"]);

                    }
                }
                else
                {
                    ClearPlaceDets();
                }

            }
        }
        public void ClearPlaceDets()
        {
            PlaceName = "";
            PlaceDescription = "";
            PlaceParentId = 0;
            PlaceCreatedAt = "";
            PlaceCreatedBy = "";
            PlaceAddressId = 0;
            PlaceDeptId = 0;
            PlaceFirmId = 0;
            PlaceIsProduction = 0;
            PlaceRespPersonId = 0;
            PlaceQuarantine = 0;
            PlaceOwnerId = 0;
        }

        public int AddStockPlace(string name, string description, int parentid, int deptid, int firmid, int addressid,
                            int resppersid, int isproduction, int quarantine, int ownerid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockPlace", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@name", name);
            sqlComm.Parameters.AddWithValue("@description", description);
            sqlComm.Parameters.AddWithValue("@parentid", parentid);
            sqlComm.Parameters.AddWithValue("@deptid", deptid);
            sqlComm.Parameters.AddWithValue("@firmid", firmid);
            sqlComm.Parameters.AddWithValue("@addressid", addressid);
            sqlComm.Parameters.AddWithValue("@resppersid", resppersid);
            sqlComm.Parameters.AddWithValue("@isproduction", isproduction);
            sqlComm.Parameters.AddWithValue("@quarantine", quarantine);
            sqlComm.Parameters.AddWithValue("@ownerid", ownerid);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

            return Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);

        }


        public void EditStockPlace(int id, string name, string description, int parentid, int deptid, int firmid,
                    int addressid, int resppersid, int isproduction, int quarantine, int ownerid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditStockPlace", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@name", name);
            sqlComm.Parameters.AddWithValue("@description", description);
            sqlComm.Parameters.AddWithValue("@parentid", parentid);
            sqlComm.Parameters.AddWithValue("@deptid", deptid);
            sqlComm.Parameters.AddWithValue("@firmid", firmid);
            sqlComm.Parameters.AddWithValue("@addressid", addressid);
            sqlComm.Parameters.AddWithValue("@resppersid", resppersid);
            sqlComm.Parameters.AddWithValue("@isproduction", isproduction);
            sqlComm.Parameters.AddWithValue("@quarantine", quarantine);
            sqlComm.Parameters.AddWithValue("@ownerid", ownerid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }


        public int DeleteStockPlace(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockPlace", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@Success", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

            return Convert.ToInt32(sqlComm.Parameters["@Success"].Value);
        }
        #endregion


    }
}
