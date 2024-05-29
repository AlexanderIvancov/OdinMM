using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace Odin.CMB_Components.BLL
{
    public class CMB_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        DAL_Functions Fun = new DAL_Functions();
        class_Global globClass = new class_Global();
        Helper MyHelper = new Helper();

        #region Units

        public static DataTable getUnits(string _beg)
        {
            string query = "EXECUTE sp_UnitsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddUnit(string Unit, string Description, int Decims, string UnitLat, int BaseUnitid, double CoefConv)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddUnit", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@unit", Unit);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@decimals", Decims);
            sqlComm.Parameters.AddWithValue("@unitlat", UnitLat);
            sqlComm.Parameters.AddWithValue("@baseunitid", BaseUnitid);
            sqlComm.Parameters.AddWithValue("@coefconv", CoefConv);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteUnit(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteUnit", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditUnit(int Id, string Unit, string Description, int Decims, string UnitLat, int BaseUnitid, double CoefConv)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditUnit", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@unit", Unit);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@decimals", Decims);
            sqlComm.Parameters.AddWithValue("@unitlat", UnitLat);
            sqlComm.Parameters.AddWithValue("@baseunitid", BaseUnitid);
            sqlComm.Parameters.AddWithValue("@coefconv", CoefConv);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        public static DataTable getCharUnits(string _beg, int _baseunitid, int _baseonly)
        {
            string query = "EXECUTE sp_CharUnitsSelectLike @Beg = '" + _beg + "', @BaseUnitId = " + _baseunitid + ", @baseonly = " + _baseonly;

            return Helper.QueryDT(query);
        }

        public int AddCharUnit(string Unit, string Description, int Decims, string UnitLat, int BaseUnitid, double CoefConv)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCharUnit", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@unit", Unit);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@decimals", Decims);
            sqlComm.Parameters.AddWithValue("@unitlat", UnitLat);
            sqlComm.Parameters.AddWithValue("@baseunitid", BaseUnitid);
            sqlComm.Parameters.AddWithValue("@coefconv", CoefConv);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteCharUnit(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCharUnit", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditCharUnit(int Id, string Unit, string Description, int Decims, string UnitLat, int BaseUnitid, double CoefConv)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCharUnit", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@unit", Unit);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@decimals", Decims);
            sqlComm.Parameters.AddWithValue("@unitlat", UnitLat);
            sqlComm.Parameters.AddWithValue("@baseunitid", BaseUnitid);
            sqlComm.Parameters.AddWithValue("@coefconv", CoefConv);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        #endregion

        #region Countries

        public static DataTable getCountries(string _beg)
        {
            string query = "EXECUTE sp_CountrySelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddCountry(string CountName, string ShortName, int CurId, int VAT, int ES)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCountry", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@CountName", CountName);
            sqlComm.Parameters.AddWithValue("@ShortName", ShortName);
            sqlComm.Parameters.AddWithValue("@CurId", CurId);
            sqlComm.Parameters.AddWithValue("@VAT", VAT);
            sqlComm.Parameters.AddWithValue("@ES", ES);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void DeleteCountry(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCountry", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        public void EditCountry(int Id, string CountName, string ShortName, int CurId, int VAT, int ES)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCountry", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@CountName", CountName);
            sqlComm.Parameters.AddWithValue("@ShortName", ShortName);
            sqlComm.Parameters.AddWithValue("@CurId", CurId);
            sqlComm.Parameters.AddWithValue("@VAT", VAT);
            sqlComm.Parameters.AddWithValue("@ES", ES);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        int _CountryId = 0;

        public int CountryCurId
        { get; set; }
        public int CountryVAT
        { get; set; }
        public int CountryEU
        { get; set; }
        public string CountryShortName
        { get; set; }
        public string Country
        { get; set; }
        public int CountryId
        {
            get { return _CountryId; }
            set { _CountryId = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectCountry @id = " + _CountryId, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Country = dr["country"].ToString();
                        CountryCurId = Convert.ToInt32(dr["currency"]);
                        CountryEU = Convert.ToInt32(dr["eurozone"]);
                        CountryShortName = dr["shortname"].ToString();
                        CountryVAT = Convert.ToInt32(dr["vat"]);
                    }
                }
                else
                {
                    Country = "";
                    CountryCurId = 0;
                    CountryEU = -1;
                    CountryShortName = "";
                    CountryVAT = 0;

                }
            }

        }

        #endregion

        #region Currencies

        public static DataTable getCurrencies(string _beg)
        {
            string query = "EXECUTE sp_CurrencySelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddCurrency(string Currency, string Description, string Symbol)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCurrency", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@currency", Currency);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@symbol", Symbol);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteCurrency(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCurrency", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditCurrency(int Id, string Currency, string Description, string Symbol)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCurrency", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@currency", Currency);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@symbol", Symbol);


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion

        #region CustCodes

        public static DataTable getCustCodes(string _beg)
        {
            string query = "EXECUTE sp_CustCodesSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }
        public int AddCustCode(string CustCode, string Description)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCustCode", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@code", CustCode);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteCustCode(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCustCode", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditCustCode(int Id, string CustCode, string Description)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCustCode", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@code", CustCode);
            sqlComm.Parameters.AddWithValue("@description", Description);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion

        #region Articles

        public static DataTable getArticles(string _beg)
        {
            string query = "EXECUTE sp_ArticlesSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getAliases(int _artid)
        {
            string query = "EXECUTE sp_ArticleAliases @artid = '" + _artid + "'";

            return Helper.QueryDT(query);
        }

        #endregion

        #region Types

        public static DataTable getTypes(string _beg)
        {
            string query = "EXECUTE sp_TypesSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }
        public int AddType(string Type, string Description, int ParentId, string TypeLat, int CustCodeId)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddArtType", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@type", Type);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@parentid", ParentId);
            sqlComm.Parameters.AddWithValue("@typelat", TypeLat);
            sqlComm.Parameters.AddWithValue("@custcodeid", CustCodeId);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public int EditType(int Id, string Type, string Description, int ParentId, string TypeLat, int CustCodeId)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditType", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@type", Type);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@parentid", ParentId);
            sqlComm.Parameters.AddWithValue("@typelat", TypeLat);
            sqlComm.Parameters.AddWithValue("@custcodeid", CustCodeId);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            return _res;
        }

        public void DeleteType(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteType", sqlConn);
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

        public static DataTable getTypeSpecificationsAll(int _typeid)
        {
            string query = "EXECUTE sp_TypesSpecificationsAll @typeid = " + _typeid;

            return Helper.QueryDT(query);
        }

        public static DataTable getTypeSpecifications(int _typeid)
        {
            string query = "EXECUTE sp_TypesSpecifications @typeid = " + _typeid;

            return Helper.QueryDT(query);
        }

        public void AddSpecification(string Specification, string TypeofData, string Comments, int CharUnitId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddSpecification", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@specification", Specification);
            sqlComm.Parameters.AddWithValue("@typeofdata", TypeofData);
            sqlComm.Parameters.AddWithValue("@comments", Comments);
            sqlComm.Parameters.AddWithValue("@charunitid", CharUnitId);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            
        }

        public void EditSpecification(int Id, string Specification, string TypeofData, string Comments, int CharUnitId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditSpecification", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@specification", Specification);
            sqlComm.Parameters.AddWithValue("@typeofdata", TypeofData);
            sqlComm.Parameters.AddWithValue("@comments", Comments);
            sqlComm.Parameters.AddWithValue("@charunitid", CharUnitId);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        
        public void DeleteSpecification(int Id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteSpecification", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void SaveSpecsForType(int _typeid, DataTable _specs)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveTypeSpecs", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _typeid);
            sqlComm.Parameters.Add("@tablespecs", SqlDbType.Structured);
            sqlComm.Parameters["@tablespecs"].TypeName = "UT_IDs";
            sqlComm.Parameters["@tablespecs"].Value = _specs;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion

        #region Departments

        public int AddDepartment(string Department, string Description, int ParentId, string RespPerson)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDepartment", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@department", Department);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@parentid", ParentId);
            sqlComm.Parameters.AddWithValue("@respperson", RespPerson);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public int EditDepartment(int Id, string Department, string Description, int ParentId, string RespPerson)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditDepartment", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@department", Department);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@parentid", ParentId);
            sqlComm.Parameters.AddWithValue("@respperson", RespPerson);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            return _res;
        }

        public void DeleteDepartment(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDepartment", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        #endregion

        #region Categories

        public int AddCategory(string Category, string Description, int ParentId)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCategory", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@category", Category);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@parentid", ParentId);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public int EditCategory(int Id, string Category, string Description, int ParentId)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCategory", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@category", Category);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.AddWithValue("@parentid", ParentId);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            return _res;
        }

        public void DeleteCategory(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCategory", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        #endregion

        #region Batches

        public static DataTable getBatches(string _beg)
        {
            string query = "EXECUTE sp_BatchSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getBatchesActiveOnly(string _beg)
        {
            string query = "EXECUTE sp_BatchSelectLikeActiveOnly @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getBatchesProject(string _beg)
        {
            string query = "EXECUTE sp_BatchProjectSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getBatchesProjectActiveOnly(string _beg)
        {
            string query = "EXECUTE sp_BatchProjectSelectLikeActiveOnly @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }
        public static DataTable getBatchesGroups(string _beg)
        {
            string query = "EXECUTE sp_BatchGroupsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }
        public static DataTable getBatchesGroupsActiveOnly(string _beg)
        {
            string query = "EXECUTE sp_BatchGroupsSelectLikeActiveOnly @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }
        #endregion

        #region Companies

        public static DataTable getFirms(string _beg)
        {
            string query = "EXECUTE sp_CompaniesSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        #endregion

        #region Incoterms

        public static DataTable getIncoterms(string _beg)
        {
            string query = "EXECUTE sp_IncotermsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddIncoterm(string Incoterm, string Description)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddIncoterm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@incoterm", Incoterm);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteIncoterm(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteIncoterm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditIncoterm(int Id, string Incoterm, string Description)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditIncoterm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@incoterm", Incoterm);
            sqlComm.Parameters.AddWithValue("@description", Description);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion

        #region Projects

        public static DataTable getProjects(string _beg)
        {
            string query = "EXECUTE sp_ProjectsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddProject(string Project)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddProject", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@project", Project);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteProject(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteProject", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditProject(int Id, string Project)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditProject", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@project", Project);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion

        #region End Customers

        public static DataTable getEndCustomers(string _beg)
        {
            string query = "EXECUTE sp_EndCustomersSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddEndCustomer(string EndCustomer)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddEndCustomer", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@endcustomer", EndCustomer);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteEndCustomer(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteEndCustomer", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditEndCustomer(int Id, string EndCustomer)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditEndCustomer", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@endcustomer", EndCustomer);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        #endregion

        #region Payment terms

        public static DataTable getPayterms(string _beg)
        {
            string query = "EXECUTE sp_PaytermsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }
        public int AddPayterm(string Payterm, string PaytermLat, string Description)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPayterm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@payterm", Payterm);
            sqlComm.Parameters.AddWithValue("@paytermlat", PaytermLat);
            sqlComm.Parameters.AddWithValue("@description", Description);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeletePayterm(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePayterm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditPayterm(int Id, string Payterm, string PaytermLat, string Description)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditPayterm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@payterm", Payterm);
            sqlComm.Parameters.AddWithValue("@paytermlat", PaytermLat);
            sqlComm.Parameters.AddWithValue("@description", Description);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        #endregion

        #region Transport

        public static DataTable getTransport(string _beg)
        {
            string query = "EXECUTE sp_TransportSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }


        public int AddTransport(string Name, string IntrastatCode, string TransType)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddTransport", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@Name", Name);
            sqlComm.Parameters.AddWithValue("@IntrastatCode", IntrastatCode);
            sqlComm.Parameters.AddWithValue("@TransType", TransType);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void EditTransport(int Id, string Name, string IntrastatCode, string TransType)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditTransport", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlComm.Parameters.AddWithValue("@Name", Name);
            sqlComm.Parameters.AddWithValue("@IntrastatCode", IntrastatCode);
            sqlComm.Parameters.AddWithValue("@TransType", TransType);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteTransport(int Id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteTransport", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        int _transportid = 0;

        public string Transport
        { get; set; }

        public string TransportIntrastat
        { get; set; }

        public string TransType
        { get; set; }

        public int TransportId
        {
            get { return _transportid; }
            set
            {
                _transportid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectTransport @id = " + _transportid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Transport = dr["name"].ToString();
                        TransportIntrastat = dr["intrastatcode"].ToString();
                        TransType = dr["transtype"].ToString();
                    }
                }
                else
                {
                    Transport = "";
                    TransportIntrastat = "";
                    TransType = "";
                }
            }

        }

        #endregion

        #region Sales orders

        public static DataTable getSalesOrders(string _beg)
        {
            string query = "EXECUTE sp_SalesOrdersSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        #endregion

        #region Quotations

        public static DataTable getQuotations(string _beg)
        {
            string query = "EXECUTE sp_QuotationsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        #endregion

        #region Banks


        public static DataTable getBanks(string _beg)
        {
            string query = "EXECUTE sp_BanksSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddBank(string Bank, string Iban, string Address, string Comments)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBank", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@Bank", Bank);
            sqlComm.Parameters.AddWithValue("@Iban", Iban);
            sqlComm.Parameters.AddWithValue("@Address", Address);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void DeleteBank(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCountry", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditBank(int Id, string Bank, string Iban, string Address, string Comments)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditBank", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@Bank", Bank);
            sqlComm.Parameters.AddWithValue("@Iban", Iban);
            sqlComm.Parameters.AddWithValue("@Address", Address);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion

        #region Users

        public static DataTable getUsers(string _beg)
        {
            string query = "EXECUTE sp_UsersSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int SaveUser(int Userid, string UserName, string UserSurname, string UserLogin, int IsDBUser, string UserMail,
                        string UserLang, string UserPhone, string UserFax, string UserJob, string UserInitials, int UserDeptId,
                        string UserTabNR, int IsActive, string UserShortName)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveUser", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@UserId", UserId);
            sqlComm.Parameters.AddWithValue("@UserName", UserName);
            sqlComm.Parameters.AddWithValue("@usersurname", UserSurname);
            sqlComm.Parameters.AddWithValue("@UserLogin", UserLogin);
            sqlComm.Parameters.AddWithValue("@IsDBUser", IsDBUser);
            sqlComm.Parameters.AddWithValue("@UserMail", UserMail);
            sqlComm.Parameters.AddWithValue("@UserLang", UserLang);
            sqlComm.Parameters.AddWithValue("@UserPhone", UserPhone);
            sqlComm.Parameters.AddWithValue("@UserFax", UserFax);
            sqlComm.Parameters.AddWithValue("@UserJob", UserJob);
            sqlComm.Parameters.AddWithValue("@UserInitials", UserInitials);
            sqlComm.Parameters.AddWithValue("@UserDeptId", UserDeptId);
            sqlComm.Parameters.AddWithValue("@UserTabNR", UserTabNR);
            sqlComm.Parameters.AddWithValue("@IsActive", IsActive);
            sqlComm.Parameters.AddWithValue("@ShortName", UserShortName);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        int _userid = 0;
        public int UserId
        {
            get { return _userid; }
            set
            {
                _userid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectUserDets @id = " + _userid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserName = dr["name"].ToString();
                        UserSurName = dr["surname"].ToString();
                        UserLogin = dr["userlogin"].ToString();
                        IsDBUser = Convert.ToInt32(dr["isdbuser"]);
                        UserEmail = dr["email"].ToString();
                        UserLang = dr["lang"].ToString();
                        UserJob = dr["jobtitle"].ToString();
                        UserInitials = dr["initials"].ToString();
                        UserDeptId = Convert.ToInt32(dr["deptid"]); ;
                        UserIsActive = Convert.ToInt32(dr["isactive"]); ;
                        UserPhone = dr["phone"].ToString();
                        UserFax = dr["fax"].ToString();
                        UserTabNR = dr["tabnr"].ToString();
                        UserShortName = dr["shortname"].ToString();
                        UserCurrent = dr["currentuser"].ToString();
                    }
                }
                else
                {
                    ClearUser();
                }
            }
        }

        public void ClearUser()
        {
            UserName = "";
            UserSurName = "";
            UserLogin = "";
            IsDBUser = 0;
            UserEmail = "";
            UserLang = "";
            UserJob = "";
            UserInitials = "";
            UserDeptId = 0;
            UserIsActive = 0;
            UserPhone = "";
            UserFax = "";
            UserTabNR = "";
            UserShortName = "";
            UserCurrent = "";
        }
        public string UserName
        { get; set; }
        public string UserSurName
        { get; set; }
        public string UserLogin
        { get; set; }
        public int IsDBUser
        { get; set; }
        public string UserEmail
        { get; set; }
        public string UserLang
        { get; set; }
        public string UserJob
        { get; set; }
        public string UserInitials
        { get; set; }
        public int UserDeptId
        { get; set; }
        public int UserIsActive
        { get; set; }
        public string UserPhone
        { get; set; }
        public string UserFax
        { get; set; }
        public string UserTabNR
        { get; set; }
        public string UserShortName
        { get; set; }
        public string UserCurrent
        { get; set; }
        public void DeleteUser(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteUser", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        public void EncryptMailPassword(int UserId, string PWD)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "update BAS_Users set mailpwd = " +
                                "EncryptByPassPhrase(name + surname + userlogin, @pwd, 1, CONVERT(varbinary, id)) where id = @userid";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlComm.Parameters.AddWithValue("@userid", UserId);
            sqlComm.Parameters.AddWithValue("@pwd", PWD);

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }
        #endregion

        #region Purchase Orders

        public static DataTable getPurchaseOrders(string _beg)
        {
            string query = "EXECUTE sp_PurchaseOrdersSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getPurchaseOrdersEnabledArticles(string _beg, int _artid)
        {
            string query = "EXECUTE sp_PurchaseOrdersSelectLikeArticles @Beg = '" + _beg + "', @artid = " + _artid;

            return Helper.QueryDT(query);
        }

        public static DataTable getPurchaseOrdersLines(int _poid)
        {
            string query = "EXECUTE sp_PurchaseOrdersLines @poid = '" + _poid + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getPurchaseOrdersLinesArticles(int _poid, int _artid)
        {
            string query = "EXECUTE sp_PurchaseOrdersLinesArticles @poid = '" + _poid + "', @artid = " + _artid;

            return Helper.QueryDT(query);
        }

        #endregion

        #region IncomeDocs

        public static DataTable getIncomeDocs(string _beg)
        {
            string query = "EXECUTE sp_IncomeDocsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddIncomeDocHead(string _name, string _serie, string _regdate, string _docdate, int _supid, string _comments, int _curid,
                                    double _currate, int _sender, int _producer, string _bargain, int _transportid, int _incotermsid,
                                    double _additcost, double _inadvance, string _advancedate, string _paydate, int _noreversepvn, 
                                    double _mediatedcost, int _check)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddIncomeDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@name", _name);
            sqlComm.Parameters.AddWithValue("@serie", _serie);
            sqlComm.Parameters.AddWithValue("@regdate", _regdate);
            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@supid", _supid);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@curid", _curid);
            sqlComm.Parameters.AddWithValue("@currate", _currate);
            sqlComm.Parameters.AddWithValue("@sender", _sender);
            sqlComm.Parameters.AddWithValue("@producer", _producer);
            sqlComm.Parameters.AddWithValue("@bargain", _bargain);
            sqlComm.Parameters.AddWithValue("@transportid", _transportid);
            sqlComm.Parameters.AddWithValue("@incotermsid", _incotermsid);
            sqlComm.Parameters.AddWithValue("@additcost", _additcost);
            sqlComm.Parameters.AddWithValue("@inadvance", _inadvance);
            sqlComm.Parameters.AddWithValue("@advancedate", _advancedate);
            sqlComm.Parameters.AddWithValue("@paydate", _paydate);
            sqlComm.Parameters.AddWithValue("@noreversepvn", _noreversepvn);
            sqlComm.Parameters.AddWithValue("@mediatedcost", _mediatedcost);
            sqlComm.Parameters.AddWithValue("@check", _check);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void EditIncomeDocHead(int _id, string _name, string _serie, string _regdate, string _docdate, int _supid, string _comments, int _curid,
                                    double _currate, int _sender, int _producer, string _bargain, int _transportid, int _incotermsid, double _additcost,
                                    double _inadvance, string _advancedate, string _paydate, int _noreversepvn, double _mediatedcost, int _check)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditIncomeDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlComm.Parameters.AddWithValue("@name", _name);
            sqlComm.Parameters.AddWithValue("@serie", _serie);
            sqlComm.Parameters.AddWithValue("@regdate", _regdate);
            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@supid", _supid);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@curid", _curid);
            sqlComm.Parameters.AddWithValue("@currate", _currate);
            sqlComm.Parameters.AddWithValue("@sender", _sender);
            sqlComm.Parameters.AddWithValue("@producer", _producer);
            sqlComm.Parameters.AddWithValue("@bargain", _bargain);
            sqlComm.Parameters.AddWithValue("@transportid", _transportid);
            sqlComm.Parameters.AddWithValue("@incotermsid", _incotermsid);
            sqlComm.Parameters.AddWithValue("@additcost", _additcost);
            sqlComm.Parameters.AddWithValue("@inadvance", _inadvance);
            sqlComm.Parameters.AddWithValue("@advancedate", _advancedate);
            sqlComm.Parameters.AddWithValue("@paydate", _paydate);
            sqlComm.Parameters.AddWithValue("@noreversepvn", _noreversepvn);
            sqlComm.Parameters.AddWithValue("@mediatedcost", _mediatedcost);
            sqlComm.Parameters.AddWithValue("@check", _check);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteIncomeDocHead(int _id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteIncomeDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        int _incomedocheadid = 0;

        public int IncomeDocHeadId
        {
            get { return _incomedocheadid; }
            set
            {
                _incomedocheadid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectIncomeDocHead @id = " + _incomedocheadid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        IncomeDocName = dr["name"].ToString();
                        IncomeDocSerie = dr["serie"].ToString();
                        IncomeDocRegDate = dr["regdate"].ToString();
                        IncomeDocDocDate = dr["docdate"].ToString();
                        IncomeDocComments = dr["comments"].ToString();
                        IncomeDocSupId = Convert.ToInt32(dr["supid"]);
                        IncomeDocCurId = Convert.ToInt32(dr["curid"]);
                        IncomeDocCurRate = Convert.ToDouble(dr["currate"]);
                        IncomeDocSender = Convert.ToInt32(dr["sendercountryid"]);
                        IncomeDocProducer = Convert.ToInt32(dr["producercountryid"]);
                        IncomeDocTransportId = Convert.ToInt32(dr["transportid"]);
                        IncomeDocIncotermsId = Convert.ToInt32(dr["incotermsid"]);
                        IncomeDocBargain = dr["bargain"].ToString();
                        IncomeDocAdditCost = Convert.ToDouble(dr["additcost"]);
                        IncomeDocAdvance = Convert.ToDouble(dr["inadvance"]);
                        IncomeDocAdvanceDate = dr["advancedate"].ToString();
                        IncomeDocPayDate = dr["paydate"].ToString();
                        IncomeDocNoReversePVN = Convert.ToInt32(dr["noreversepvn"]);
                        IncomeDocMediatedCost = Convert.ToDouble(dr["mediatedcost"]);
                        IncomeDocCheck = Convert.ToInt32(dr["check"]);
                        IncomeDocPlace = dr["place"].ToString();
                    }
                }
                else
                {
                    ClearIncomeDocHead();
                }
            }

        }
        public string IncomeDocName
        { get; set; }
        public string IncomeDocSerie
        { get; set; }
        public string IncomeDocRegDate
        { get; set; }
        public string IncomeDocDocDate
        { get; set; }
        public string IncomeDocComments
        { get; set; }
        public int IncomeDocSupId
        { get; set; }
        public int IncomeDocCurId
        { get; set; }
        public double IncomeDocCurRate
        { get; set; }
        public int IncomeDocSender
        { get; set; }
        public int IncomeDocProducer
        { get; set; }
        public int IncomeDocTransportId
        { get; set; }
        public int IncomeDocIncotermsId
        { get; set; }
        public string IncomeDocBargain
        { get; set; }
        public double IncomeDocAdditCost
        { get; set; }
        public double IncomeDocAdvance
        { get; set; }
        public string IncomeDocAdvanceDate
        { get; set; }
        public string IncomeDocPayDate
        { get; set; }
        public int IncomeDocNoReversePVN
        { get; set; }
        public double IncomeDocMediatedCost
        { get; set; }
        public int IncomeDocCheck
        { get; set; }
        public string IncomeDocPlace
        { get; set; }

        public void ClearIncomeDocHead()
        {
            IncomeDocName = "";
            IncomeDocSerie = "";
            IncomeDocRegDate = "";
            IncomeDocDocDate = "";
            IncomeDocComments = "";
            IncomeDocSupId = 0;
            IncomeDocCurId = 0;
            IncomeDocCurRate = 1;
            IncomeDocSender = 0;
            IncomeDocProducer = 0;
            IncomeDocTransportId = 0;
            IncomeDocIncotermsId = 0;
            IncomeDocBargain = "";
            IncomeDocAdditCost = 0;
            IncomeDocAdvance = 0;
            IncomeDocAdvanceDate = "";
            IncomeDocPayDate = "";
            IncomeDocNoReversePVN = 0;
            IncomeDocMediatedCost = 0;
            IncomeDocCheck = 0;
            IncomeDocPlace = "";
        }

        public static DataTable getStockDocsTypes(string _beg, string _lang, int _movtype)
        {
            string query = "EXECUTE sp_StockDocTypesSelectLike @Beg = '" + _beg + "', @lang = '" + _lang + "', @movtype = " + _movtype;

            return Helper.QueryDT(query);
        }

        public void CheckSendResaleLetter(int _headid)
        {
            bool _test = false;
            string strMessage = "";
            string emailaddresses = "";

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "execute sp_SelectResalePurchaseOrders @headid = " + _headid, conn);
            
            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    strMessage = strMessage + "\r\nPurchase order: " + dr["PurOrder"].ToString();
                    strMessage = strMessage + "\r\nLine: " + dr["PurLine"].ToString();
                    strMessage = strMessage + "\r\nSuppliers article: " + dr["SupArticle"].ToString();
                    strMessage = strMessage + "\r\nArticle: " + dr["Article"].ToString();
                    strMessage = strMessage + "\r\nQty: " + Convert.ToDouble(dr["Qty"]) + " " + dr["Unit"].ToString();
                }
                _test = true;
            }
            else
            { _test = false; }

            if (_test == true)
            {
                emailaddresses = Fun.EmailAddressesByType(3);

                if (emailaddresses != "")
                {
                    MyHelper.SendMessage(globClass.ReplaceChar(emailaddresses, ";", ","), "Resale orders income registration!", strMessage);
                }
            }

        }

        public static DataTable getIncomeAdvances(int _headid)
        {
            string query = "EXECUTE sp_SelectIncomeDocAdvances @headid = " + _headid;

            return Helper.QueryDT(query);
        }

        public void AddIncomeDocAdvance(int _headid, double _amount, int _curid, string _curdate, double _currate)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddIncomeDocAdvance", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", _headid);
            sqlComm.Parameters.AddWithValue("@amount", _amount);
            sqlComm.Parameters.AddWithValue("@curid", _curid);
            sqlComm.Parameters.AddWithValue("@curdate", _curdate);
            sqlComm.Parameters.AddWithValue("@currate", _currate);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
           
            sqlConn.Close();

        }

        public void EditIncomeDocAdvance(int _id, double _amount, int _curid, string _curdate, double _currate)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditIncomeDocAdvance", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlComm.Parameters.AddWithValue("@amount", _amount);
            sqlComm.Parameters.AddWithValue("@curid", _curid);
            sqlComm.Parameters.AddWithValue("@curdate", _curdate);
            sqlComm.Parameters.AddWithValue("@currate", _currate);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteIncomeDocAdvance(int _id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteIncomeDocAdvance", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion

        #region Movements

        public static DataTable getMoveDocs(string _beg)
        {
            string query = "EXECUTE sp_MoveDocsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddMoveDocHead(string _docdate, string _delivdate, string _comments, int _delivplaceid, int _delivaddressid, int _findelivplaceid,
                                    int _findelivaddressid, int _transportid, int _incotermsid, int _palqty, double _palweight,
                                    int _batchid, int _stageid, double _qtyonstage)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddMoveDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@delivdate", _delivdate);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@delivplaceid", _delivplaceid);
            sqlComm.Parameters.AddWithValue("@delivaddressid", _delivaddressid);
            sqlComm.Parameters.AddWithValue("@findelivplaceid", _findelivplaceid);
            sqlComm.Parameters.AddWithValue("@findelivaddressid", _findelivaddressid);
            sqlComm.Parameters.AddWithValue("@transportid", _transportid);
            sqlComm.Parameters.AddWithValue("@incotermsid", _incotermsid);
            sqlComm.Parameters.AddWithValue("@palqty", _palqty);
            sqlComm.Parameters.AddWithValue("@palweight", _palweight);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@qtyonstage", _qtyonstage);
            //sqlComm.Parameters.AddWithValue("@isreturn", _isreturn);
            //sqlComm.Parameters.AddWithValue("@creditaccount", _creditaccount);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void EditMoveDocHead(int _id, string _docdate, string _delivdate, string _comments, int _delivplaceid, int _delivaddressid, int _findelivplaceid,
                                    int _findelivaddressid, int _transportid, int _incotermsid, int _palqty, double _palweight, int _batchid,
                                    int _stageid, double _qtyonstage)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditMoveDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@delivdate", _delivdate);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@delivplaceid", _delivplaceid);
            sqlComm.Parameters.AddWithValue("@delivaddressid", _delivaddressid);
            sqlComm.Parameters.AddWithValue("@findelivplaceid", _findelivplaceid);
            sqlComm.Parameters.AddWithValue("@findelivaddressid", _findelivaddressid);
            sqlComm.Parameters.AddWithValue("@transportid", _transportid);
            sqlComm.Parameters.AddWithValue("@incotermsid", _incotermsid);
            sqlComm.Parameters.AddWithValue("@palqty", _palqty);
            sqlComm.Parameters.AddWithValue("@palweight", _palweight);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);
            sqlComm.Parameters.AddWithValue("@qtyonstage", _qtyonstage);
          

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteMoveDocHead(int _id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteMoveDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        int _movedocheadid = 0;

        public int MoveDocHeadId
        {
            get { return _movedocheadid; }
            set
            {
                _movedocheadid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectMoveDocHead @id = " + _movedocheadid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        MoveDocName = dr["name"].ToString();
                        MoveDocDocDate = dr["docdate"].ToString();
                        MoveDocDelivDate = dr["delivdate"].ToString();
                        MoveDocComments = dr["comments"].ToString();
                        MoveDocDelivPlaceId = Convert.ToInt32(dr["delivplaceid"]);
                        MoveDocDelivAddressId = Convert.ToInt32(dr["delivaddressid"]);
                        MoveDocFinDestPlaceId = Convert.ToInt32(dr["findestplaceid"]);
                        MoveDocFinDestAddressId = Convert.ToInt32(dr["findestaddressid"]);
                        MoveDocTransportId = Convert.ToInt32(dr["transportid"]);
                        MoveDocIncotermsId = Convert.ToInt32(dr["incotermsid"]);
                        MoveDocPalettesQty = Convert.ToInt32(dr["palettesqty"]);
                        MoveDocPalettesWeight = Convert.ToDouble(dr["palettesweight"]);
                        MoveDocDelivAddress = dr["delivaddress"].ToString();
                        MoveDocDelivPlace = dr["delivplace"].ToString();
                        MoveDocFinDestAddress = dr["findestaddress"].ToString();
                        MoveDocFinDestPlace = dr["findestplace"].ToString();
                        MoveDocIncoterms = dr["incoterms"].ToString();
                        MoveDocTransport = dr["transport"].ToString();
                        MoveDocBatchId = Convert.ToInt32(dr["batchid"]);
                        MoveDocBatch = dr["batch"].ToString();
                        MoveQtyInBatch = Convert.ToDouble(dr["qtyinbatch"]);
                        MoveProduct = dr["product"].ToString();
                        MoveConfOrder = dr["conforder"].ToString();
                        MoveUnit = dr["unit"].ToString();
                        MoveQtyOnStage = Convert.ToDouble(dr["qtyonstage"]);
                        MoveStageId = Convert.ToInt32(dr["stageid"]);
                        MoveCustomer = dr["customer"].ToString();
                        MoveSecArticle = dr["secarticle"].ToString();
                        MoveBatchComments = dr["batchcomments"].ToString();
                        MoveIsReturn = Convert.ToInt32(dr["isreturn"]);
                        MoveCreditAccount = dr["creditaccount"].ToString();
                    }
                }
                else
                {
                    ClearMoveDocHead();
                }
            }

        }

        public string MoveDocName
        { get; set; }
        public string MoveDocDocDate
        { get; set; }
        public string MoveDocDelivDate
        { get; set; }
        public string MoveDocComments
        { get; set; }
        public int MoveDocDelivPlaceId
        { get; set; }
        public string MoveDocDelivPlace
        { get; set; }
        public int MoveDocDelivAddressId
        { get; set; }
        public string MoveDocDelivAddress
        { get; set; }
        public int MoveDocFinDestPlaceId
        { get; set; }
        public string MoveDocFinDestPlace
        { get; set; }
        public int MoveDocFinDestAddressId
        { get; set; }
        public string MoveDocFinDestAddress
        { get; set; }
        public int MoveDocTransportId
        { get; set; }
        public string MoveDocTransport
        { get; set; }
        public int MoveDocIncotermsId
        { get; set; }
        public string MoveDocIncoterms
        { get; set; }
        public int MoveDocPalettesQty
        { get; set; }
        public double MoveDocPalettesWeight
        { get; set; }
        public int MoveDocBatchId
        { get; set; }
        public string MoveDocBatch
        { get; set; }
        public double MoveQtyInBatch
        { get; set; }
        public string MoveConfOrder
        { get; set; }
        public string MoveProduct
        { get; set; }
        public string MoveSecArticle
        { get; set; }
        public string MoveUnit
        { get; set; }
        public int MoveStageId
        { get; set; }
        public double MoveQtyOnStage
        { get; set; }
        public string MoveCustomer
        { get; set; }
        public string MoveBatchComments
        { get; set; }
        public int MoveIsReturn
        { get; set; }
        public string MoveCreditAccount
        { get; set; }


        public void ClearMoveDocHead()
        {
            MoveDocName = "";
            MoveDocDocDate = "";
            MoveDocDelivDate = "";
            MoveDocComments = "";
            MoveDocDelivPlaceId = 0;
            MoveDocDelivAddressId = 0;
            MoveDocFinDestPlaceId = 0;
            MoveDocFinDestAddressId = 0;
            MoveDocTransportId = 0;
            MoveDocIncotermsId = 0;
            MoveDocPalettesQty = 0;
            MoveDocPalettesWeight = 0;
            MoveDocDelivAddress = "";
            MoveDocDelivPlace = "";
            MoveDocFinDestAddress = "";
            MoveDocFinDestPlace = "";
            MoveDocIncoterms = "";
            MoveDocTransport = "";
            MoveDocBatchId = 0;
            MoveDocBatch = "";
            MoveQtyInBatch = 0;
            MoveProduct = "";
            MoveConfOrder = "";
            MoveUnit = "";
            MoveStageId = 0;
            MoveQtyOnStage = 0;
            MoveCustomer = "";
            MoveSecArticle = "";
            MoveBatchComments = "";
            MoveIsReturn = 0;
            MoveCreditAccount = "";
        }

        #endregion

        #region OutcomeDocs

        public static DataTable getOutcomeDocs(string _beg)
        {
            string query = "EXECUTE sp_OutcomeDocsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }
        public static DataTable getOutcomeDocsAll(string _beg)
        {
            string query = "EXECUTE sp_OutcomeDocsSelectLikeAll @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddOutcomeDocHead(string _docdate, string _comments, int _typeoff, int _reasonid, int _batchid)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddOutcomeDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@typeoff", _typeoff);
            sqlComm.Parameters.AddWithValue("@reasonid", _reasonid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void EditOutcomeDocHead(int _id, string _docdate, string _comments, int _typeoff, int _reasonid, int _batchid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditOutcomeDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@typeoff", _typeoff);
            sqlComm.Parameters.AddWithValue("@reasonid", _reasonid);
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteOutcomeDocHead(int _id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteOutcomeDocHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        int _outdocheadid = 0;

        public int OutDocHeadId
        {
            get { return _outdocheadid; }
            set { _outdocheadid = value; SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectOutDocHead @id = " + _outdocheadid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        OutDocName = dr["name"].ToString();
                        OutDocDocDate = dr["docdate"].ToString();
                        OutDocComments = dr["comments"].ToString();
                        OutDocTypeOff = Convert.ToInt32(dr["typeoff"]);
                        OutDocReasonId = Convert.ToInt32(dr["reasonid"]);
                        OutDocType = dr["type"].ToString();
                        OutDocReason = dr["reason"].ToString();
                        OutDocBatchId = Convert.ToInt32(dr["batchid"]);
                    }
                }
                else
                {
                    ClearOutDocHead();
                }
            }
        }

        public string OutDocName
        { get; set; }
        public string OutDocDocDate
        { get; set; }
        public string OutDocComments
        { get; set; }
        public int OutDocTypeOff
        { get; set; }
        public int OutDocReasonId
        { get; set; }
        public string OutDocType
        { get; set; }
        public string OutDocReason
        { get; set; }
        public int OutDocBatchId
        { get; set; }

        public void ClearOutDocHead()
        {
            OutDocName = "";
            OutDocDocDate = "";
            OutDocComments = "";
            OutDocTypeOff = 0;
            OutDocReasonId = 0;
            OutDocType = "";
            OutDocReason = "";
            OutDocBatchId = 0;
        }

        #endregion

        #region Requests
        public static DataTable getRequests(string _beg)
        {
            string query = "EXECUTE sp_RequestsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddRequestHead(string _comments, int _prodplaceid)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddRequestHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@placeid", _prodplaceid);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void EditRequestHead(int _id, string _comments, int _prodplaceid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditRequestHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@placeid", _prodplaceid);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteRequestHead(int _id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteRequestHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        int _requestid = 0;
        public int RequestId
        {
            get { return _requestid; }
            set
            {
                _requestid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectRequestHead @id = " + _requestid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        RequestName = dr["name"].ToString();
                        RequestComments = dr["comments"].ToString();
                        RequestProdPlace = Convert.ToInt32(dr["placeid"]);
                    }
                }
                else
                {
                    ClearRequestHead();
                }
            }
        }

        public string RequestName
        { get; set; }

        public string RequestComments
        { get; set; }
        public int RequestProdPlace
        { get; set; }

        public void ClearRequestHead()
        {
            RequestName = "";
            RequestComments = "";
            RequestProdPlace = 0;
        }

        #endregion

        #region Delivery Notes

        public static DataTable getDeliveryNotes(string _beg)
        {
            string query = "EXECUTE sp_DeliveryNotesSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }


        public int AddDelivNoteHead(string _docdate, string _delivdate, string _comments, int _delivplaceid, int _delivaddressid,
                                    int _finaldelivplaceid, int _finaldelivaddressid, int _transportid, int _incotermsid,
                                    int _palqty, double _palweight, string _creditaccount, int _isreturn, int _noreversepvn,
                                    int _internal)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDelivNoteHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@delivdate", _delivdate);
            sqlComm.Parameters.AddWithValue("@delivplaceid", _delivplaceid);
            sqlComm.Parameters.AddWithValue("@delivaddressid", _delivaddressid);
            sqlComm.Parameters.AddWithValue("@finaldelivplaceid", _finaldelivplaceid);
            sqlComm.Parameters.AddWithValue("@finaldelivaddressid", _finaldelivaddressid);
            sqlComm.Parameters.AddWithValue("@transportid", _transportid);
            sqlComm.Parameters.AddWithValue("@incotermsid", _incotermsid);
            sqlComm.Parameters.AddWithValue("@palqty", _palqty);
            sqlComm.Parameters.AddWithValue("@palweight", _palweight);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@creditaccount", _creditaccount);
            sqlComm.Parameters.AddWithValue("@isreturn", _isreturn);
            sqlComm.Parameters.AddWithValue("@noreversepvn", _noreversepvn);
            sqlComm.Parameters.AddWithValue("@internal", _internal);


            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void EditDelivNoteHead(int _id, string _docdate, string _delivdate, string _comments, int _delivplaceid, int _delivaddressid,
                                    int _finaldelivplaceid, int _finaldelivaddressid, int _transportid, int _incotermsid,
                                    int _palqty, double _palweight, string _creditaccount, int _isreturn, int _noreversepvn,
                                    int _internal)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditDelivNoteHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@delivdate", _delivdate);
            sqlComm.Parameters.AddWithValue("@delivplaceid", _delivplaceid);
            sqlComm.Parameters.AddWithValue("@delivaddressid", _delivaddressid);
            sqlComm.Parameters.AddWithValue("@finaldelivplaceid", _finaldelivplaceid);
            sqlComm.Parameters.AddWithValue("@finaldelivaddressid", _finaldelivaddressid);
            sqlComm.Parameters.AddWithValue("@transportid", _transportid);
            sqlComm.Parameters.AddWithValue("@incotermsid", _incotermsid);
            sqlComm.Parameters.AddWithValue("@palqty", _palqty);
            sqlComm.Parameters.AddWithValue("@palweight", _palweight);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@creditaccount", _creditaccount);
            sqlComm.Parameters.AddWithValue("@isreturn", _isreturn);
            sqlComm.Parameters.AddWithValue("@noreversepvn", _noreversepvn);
            sqlComm.Parameters.AddWithValue("@internal", _internal);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }


        public void DeleteDelivNoteHead(int _id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDelivNoteHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public string DelivNote
        { get; set; }
        public string DLNDocDate
        { get; set; }
        public string DLNDelivDate
        { get; set; }
        public string DLNComments
        { get; set; }
        public int DLNDelivPlaceId
        { get; set; }
        public int DLNDelivAddressId
        { get; set; }
        public int DLNFinalDelivPlaceId
        { get; set; }
        public int DLNFinalDelivAddressId
        { get; set; }
        public int DLNTransportId
        { get; set; }
        public int DLNIncotermsId
        { get; set; }
        public int DLNPalQty
        { get; set; }
        public double DLNPalWeight
        { get; set; }
        public string DLNCreditAccount
        { get; set; }
        public int DLNIsReturn
        { get; set; }
        public int DLNNoReversePVN
        { get; set; }
        public int DLNInternal
        { get; set; }

        public void ClearDelivNoteHead()
        {
            DelivNote = "";
            DLNComments = "";
            DLNDelivAddressId = 0;
            DLNDelivDate = "";
            DLNDelivPlaceId = 0;
            DLNDocDate = "";
            DLNFinalDelivAddressId = 0;
            DLNFinalDelivPlaceId = 0;
            DLNIncotermsId = 0;
            DLNPalQty = 0;
            DLNPalWeight = 0;
            DLNTransportId = 0;
            DLNCreditAccount = "";
            DLNIsReturn = 0;
            DLNNoReversePVN = 0;
            DLNInternal = 0;
        }

        int _delivnoteheadid = 0;

        public int DelivNoteHeadId
        {
            get { return _delivnoteheadid; }
            set
            {
                _delivnoteheadid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectDelivNoteHead @id = " + _delivnoteheadid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DelivNote = dr["name"].ToString();
                        DLNComments = dr["comments"].ToString();
                        DLNDelivAddressId = Convert.ToInt32(dr["delivaddressid"]);
                        DLNDelivDate = dr["delivdate"].ToString();
                        DLNDelivPlaceId = Convert.ToInt32(dr["delivplaceid"]);
                        DLNDocDate = dr["docdate"].ToString();
                        DLNFinalDelivAddressId = Convert.ToInt32(dr["findestaddressid"]);
                        DLNFinalDelivPlaceId = Convert.ToInt32(dr["findestplaceid"]);
                        DLNIncotermsId = Convert.ToInt32(dr["incotermsid"]);
                        DLNPalQty = Convert.ToInt32(dr["palettesqty"]);
                        DLNPalWeight = Convert.ToDouble(dr["palettesweight"]);
                        DLNTransportId = Convert.ToInt32(dr["transportid"]);
                        DLNCreditAccount = dr["creditaccount"].ToString();
                        DLNIsReturn = Convert.ToInt32(dr["isreturn"]);
                        DLNNoReversePVN = Convert.ToInt32(dr["noreversepvn"]);
                        DLNInternal = Convert.ToInt32(dr["internal"]);

                    }
                }
                else
                {
                    ClearDelivNoteHead();
                }
            }
        }


        #endregion

        #region BatcheStages

        public static DataTable getBatchStages(int _batchid)
        {
            string query = "EXECUTE sp_SelectBatchStages @batchid = '" + _batchid + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getBatchLaunchesStages(int _batchid)
        {
            string query = "EXECUTE sp_SelectBatchStagesLaunchesOnly @batchid = '" + _batchid + "'";

            return Helper.QueryDT(query);
        }


        #endregion

        #region ExpInvoices

        public static DataTable getExpInvoices(string _beg)
        {
            string query = "EXECUTE sp_ExpInvoiceSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int ExInvoiceType
        { get; set; }
        public string ExInvoice
        { get; set; }
        public string ExInvoiceSerie
        { get; set; }
        public string ExInvoiceStampDate
        { get; set; }
        public string ExInvoiceDocDate
        { get; set; }
        public string ExInvoiceComments
        { get; set; }
        public int ExInvoiceReceiverId
        { get; set; }
        public int ExInvoiceReceiverAddressId
        { get; set; }
        public int ExInvoiceBuyerId
        { get; set; }
        public int ExInvoiceBuyerAddressId
        { get; set; }
        public int ExInvoiceCurId
        { get; set; }
        public double ExInvoiceCurRate
        { get; set; }
        public int ExInvoiceTransportId
        { get; set; }
        public int ExInvoiceIncotermsId
        { get; set; }
        public string ExInvoiceBargain
        { get; set; }
        public string ExInvoiceBargainDesc
        { get; set; }
        public string ExInvoicePayment
        { get; set; }
        public string ExInvoicePaymentLat
        { get; set; }
        public int ExInvoiceBankAccountId
        { get; set; }
        public int ExInvoiceAssetId
        { get; set; }
        public int ExInvoiceSenderAddressId
        { get; set; }
        public string ExInvoicePlaceOfLoading
        { get; set; }
        public int ExInvoiceAgentId
        { get; set; }
        public int ExInvoiceAgentAddressId
        { get; set; }
        public int ExInvoiceBuyerCountryId
        { get; set; }
        public string ExInvoiceOrigin
        { get; set; }
        public string ExInvoiceSender
        { get; set; }
        public string ExInvoiceSenderVAT
        { get; set; }
        public string ExInvoiceSenderAddress
        { get; set; }
        public string ExInvoiceSenderBank
        { get; set; }
        public string ExInvoiceReceiver
        { get; set; }
        public string ExInvoiceReceiverVAT
        { get; set; }
        public string ExInvoiceReceiverAddress
        { get; set; }
        public string ExInvoiceReceiverLegalAddress
        { get; set; }
        public string ExInvoiceBuyer
        { get; set; }
        public string ExInvoiceBuyerVAT
        { get; set; }
        public string ExInvoiceBuyerAddress
        { get; set; }
        public string ExInvoiceBuyerLegalAddress
        { get; set; }
        public string ExInvoiceIncoterms
        { get; set; }
        public string ExInvoiceAsset
        { get; set; }
        public string ExInvoiceCurrency
        { get; set; }
        public string ExInvoicePlaceOfIssue
        { get; set; }
        public double ExInvoiceVAT
        { get; set; }
        public double ExInvoiceTotal
        { get; set; }
        public double ExInvoiceTotalVat
        { get; set; }
        public double ExInvoiceTotalWithVat
        { get; set; }
        public string ExInvoicePayBefore
        { get; set; }
        public string ExInvoiceReceiverBank
        { get; set; }
        public string ExInvoiceBuyerBank
        { get; set; }
        public string ExInvoiceSenderVatNr
        { get; set; }
        public string ExInvoiceReceiverVatNr
        { get; set; }
        public string ExInvoiceBuyerVatNr
        { get; set; }
        public string ExInvoiceIssuedBy
        { get; set; }
        public string ExInvoiceTotalWord
        { get; set; }
        public string ExInvoiceTotalWordLat
        { get; set; }
        public string ExInvoiceTransport
        { get; set; }
        public string ExInvoiceBargainDescLat
        { get; set; }
        public double ExInvoiceInAdvance
        { get; set; }
        public string ExInvoiceAdvanceDate
        { get; set; }
        public string ExInvoicePayDate
        { get; set; }
        public string ExInvoiceProformaNR
        { get; set; }
        public int ExInvoicePaymentId
        { get; set; }
        public int ExInvoiceSellerContPersId
        { get; set; }
        public int ExInvoiceBuyerContPersId
        { get; set; }
        public string ExInvoiceSellerContPerson
        { get; set; }
        public string ExInvoiceBuyerContPerson
        { get; set; }
        public string ExInvoiceSellerContPersEmail
        { get; set; }
        public int ExInvoiceValueForCustoms
        { get; set; }
        public double ExInvoiceTotalPay
        { get; set; }

        public int ExInvoiceESignature
        { get; set; }

        public string ExInvoiceRecepPers
        { get; set; }

        public string ExInvoiceESignaturePers
        { get; set; }

        public string ExInvoiceJobTitle
        { get; set; }
        public string ExInvoiceJobTitleLat
        { get; set; }
        int _exinvoiceid = 0;
        public int ExInvoiceId
        {
            get { return _exinvoiceid; }
            set
            {
                _exinvoiceid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectExInvoiceDocHead @id = " + _exinvoiceid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ExInvoice = dr["name"].ToString();
                        ExInvoiceType = Convert.ToInt32(dr["invtype"]);
                        ExInvoiceSerie = dr["serie"].ToString();
                        ExInvoiceStampDate = dr["stampdate"].ToString();
                        ExInvoiceDocDate = dr["docdate"].ToString();
                        ExInvoiceSenderAddressId = Convert.ToInt32(dr["senderaddressid"]);
                        ExInvoiceReceiverId = Convert.ToInt32(dr["receipid"]);
                        ExInvoiceReceiverAddressId = Convert.ToInt32(dr["receipaddressid"]);
                        ExInvoiceBuyerId = Convert.ToInt32(dr["buyerid"]);
                        ExInvoiceBuyerAddressId = Convert.ToInt32(dr["buyeraddressid"]);
                        ExInvoiceComments = dr["comments"].ToString();
                        ExInvoiceCurId = Convert.ToInt32(dr["curid"]);
                        ExInvoiceCurRate = Convert.ToDouble(dr["currate"]);
                        ExInvoiceBargain = dr["bargain"].ToString();
                        ExInvoiceTransportId = Convert.ToInt32(dr["transportid"]);
                        ExInvoiceIncotermsId = Convert.ToInt32(dr["incotermsid"]);
                        ExInvoiceAssetId = Convert.ToInt32(dr["assetid"]);
                        ExInvoicePayment = dr["payment"].ToString();
                        ExInvoicePaymentLat = dr["paymentlat"].ToString();
                        ExInvoicePlaceOfLoading = dr["placeofloading"].ToString();
                        ExInvoiceAgentId = Convert.ToInt32(dr["agentid"]);
                        ExInvoiceAgentAddressId = Convert.ToInt32(dr["agentaddressid"]);
                        ExInvoiceBankAccountId = Convert.ToInt32(dr["bankcontid"]);
                        ExInvoiceBuyerCountryId = Convert.ToInt32(dr["buyercountryid"]);
                        ExInvoiceOrigin = dr["origin"].ToString();
                        ExInvoiceSender = dr["sender"].ToString();
                        ExInvoiceSenderBank = dr["senderbank"].ToString();
                        ExInvoiceSenderVAT = dr["sendervat"].ToString();
                        ExInvoiceSenderAddress = dr["senderaddress"].ToString();
                        ExInvoiceReceiver = dr["receiver"].ToString();
                        ExInvoiceReceiverVAT = dr["receivervat"].ToString();
                        ExInvoiceReceiverAddress = dr["receiveraddress"].ToString();
                        ExInvoiceBuyer = dr["buyer"].ToString();
                        ExInvoiceBuyerVAT = dr["buyervat"].ToString();
                        ExInvoiceBuyerAddress = dr["buyeraddress"].ToString();
                        ExInvoiceIncoterms = dr["incoterms"].ToString();
                        ExInvoiceCurrency = dr["currency"].ToString();
                        ExInvoiceAsset = dr["asset"].ToString();
                        ExInvoicePlaceOfIssue = dr["placeofissue"].ToString();
                        ExInvoiceVAT = Convert.ToInt32(dr["vat"]);
                        ExInvoiceTotal = Convert.ToDouble(dr["total"]);
                        ExInvoiceTotalVat = Convert.ToDouble(dr["totalvat"]);
                        ExInvoiceTotalWithVat = Convert.ToDouble(dr["totalwithvat"]);
                        ExInvoicePayBefore = dr["paybefore"].ToString();
                        ExInvoiceReceiverBank = dr["receiverbank"].ToString();
                        ExInvoiceBuyerBank = dr["buyerbank"].ToString();
                        ExInvoiceSenderVatNr = dr["sendervatnr"].ToString();
                        ExInvoiceReceiverVatNr = dr["receivervatnr"].ToString();
                        ExInvoiceBuyerVatNr = dr["buyervatnr"].ToString();
                        ExInvoiceIssuedBy= dr["issuedby"].ToString();
                        ExInvoiceReceiverLegalAddress = dr["receiverlegaladdress"].ToString();
                        ExInvoiceBuyerLegalAddress = dr["buyerlegaladdress"].ToString();
                        ExInvoiceTotalWord = dr["totalword"].ToString();
                        ExInvoiceTotalWordLat = dr["totalwordlat"].ToString();
                        ExInvoiceBargainDesc = dr["bargaindesc"].ToString();
                        ExInvoiceTransport = dr["transport"].ToString();
                        ExInvoiceBargainDescLat = dr["bargaindesclat"].ToString();
                        ExInvoiceInAdvance = Convert.ToDouble(dr["inadvance"]);
                        ExInvoiceAdvanceDate = dr["advancedate"].ToString();
                        ExInvoiceProformaNR = dr["proforma"].ToString();
                        ExInvoicePayDate = dr["paydate"].ToString();
                        ExInvoicePaymentId = Convert.ToInt32(dr["paymentid"]);
                        ExInvoiceSellerContPersId = Convert.ToInt32(dr["sellercontpersid"]);
                        ExInvoiceBuyerContPersId = Convert.ToInt32(dr["buyercontpersid"]);
                        ExInvoiceSellerContPerson = dr["sellercontperson"].ToString();
                        ExInvoiceBuyerContPerson = dr["buyercontperson"].ToString();
                        ExInvoiceSellerContPersEmail = dr["selleremail"].ToString();
                        ExInvoiceValueForCustoms = Convert.ToInt32(dr["valueforcustoms"]);
                        ExInvoiceTotalPay = Convert.ToDouble(dr["totalpay"]);
                        ExInvoiceESignature = Convert.ToInt32(dr["esignature"]);
                        ExInvoiceRecepPers = dr["receppers"].ToString();
                        ExInvoiceESignaturePers = dr["esignaturepers"].ToString();
                        ExInvoiceJobTitle = dr["jobtitle"].ToString();
                        ExInvoiceJobTitleLat = dr["jobtitlelat"].ToString();
                    }
                }
                else
                {
                    ClearExInvoiceHead();
                }
            }

        }

        public void ClearExInvoiceHead()
        {
            ExInvoice = "";
            ExInvoiceAgentAddressId = 0;
            ExInvoiceAgentId = 0;
            ExInvoiceAssetId = 0;
            ExInvoiceBankAccountId = 0;
            ExInvoiceBargain = "";
            ExInvoiceBuyerAddressId = 0;
            ExInvoiceBuyerId = 0;
            ExInvoiceComments = "";
            ExInvoiceCurId = 0;
            ExInvoiceCurRate = 1;
            ExInvoiceDocDate = "";
            ExInvoiceIncotermsId = 0;
            ExInvoicePayment = "";
            ExInvoicePlaceOfLoading = "";
            ExInvoiceReceiverAddressId = 0;
            ExInvoiceReceiverId = 0;
            ExInvoiceSenderAddressId = 0;
            ExInvoiceSerie = "";
            ExInvoiceStampDate = "";
            ExInvoiceTransportId = 0;
            ExInvoiceType = 0;
            ExInvoiceBuyerCountryId = 1;
            ExInvoiceOrigin = "";
            ExInvoiceSender = "";
            ExInvoiceSenderVAT = "";
            ExInvoiceSenderAddress = "";
            ExInvoiceSenderBank = "";
            ExInvoiceReceiver = "";
            ExInvoiceReceiverVAT = "";
            ExInvoiceReceiverAddress = "";
            ExInvoiceBuyer = "";
            ExInvoiceBuyerVAT = "";
            ExInvoiceBuyerAddress = "";
            ExInvoiceIncoterms = "";
            ExInvoiceCurrency = "";
            ExInvoiceAsset = "";
            ExInvoicePlaceOfIssue = "";
            ExInvoiceVAT = 0;
            ExInvoiceTotal = 0;
            ExInvoiceTotalVat = 0;
            ExInvoiceTotalWithVat = 0;
            ExInvoicePayBefore = "";
            ExInvoiceBuyerBank = "";
            ExInvoiceReceiverBank = "";
            ExInvoiceSenderVatNr = "";
            ExInvoiceReceiverVatNr = "";
            ExInvoiceBuyerVatNr = "";
            ExInvoiceIssuedBy = "";
            ExInvoiceReceiverLegalAddress = "";
            ExInvoiceBuyerLegalAddress = "";
            ExInvoiceTotalWord = "";
            ExInvoiceBargainDesc = "";
            ExInvoiceTransport = "";
            ExInvoiceTotalWordLat = "";
            ExInvoiceBargainDescLat = "";
            ExInvoiceInAdvance = 0;
            ExInvoiceAdvanceDate = "";
            ExInvoiceProformaNR = "";
            ExInvoicePayDate = "";
            ExInvoicePaymentId = 0;
            ExInvoicePaymentLat = "";
            ExInvoiceSellerContPersId = 0;
            ExInvoiceBuyerContPersId = 0;
            ExInvoiceSellerContPerson = "";
            ExInvoiceBuyerContPerson = "";
            ExInvoiceSellerContPersEmail = "";
            ExInvoiceValueForCustoms = 0;
            ExInvoiceTotalPay = 0;
            ExInvoiceESignature = 0;
            ExInvoiceRecepPers = "";
            ExInvoiceESignaturePers = "";
            ExInvoiceJobTitle = "";
            ExInvoiceJobTitleLat = "";
        }

        public int AddExInvoice(string _serie, string _name, int _invtype, int _invcode, string _stampdate, string _docdate, int _receiverid,
                                    int _buyerid, int _recaddressid, int _buyeraddressid, string _comments, int _curid, double _currate,
                                    string _bargain, int _transportid, int _incotermsid, string _payment, int _bankaccountid,
                                    int _assetid, int _senderaddressid, string _placeofloading, int _agentid, int _agentaddressid,
                                    double _vat, string _paybefore, double _inadvance, string _advancedate, string _proforma, string _paydate,
                                    int _paymentid, int _sellercontpersid, int _buyercontpersid, int _valueforcustoms, int _esignature, string _recipient)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddExInvoiceHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@name", _name);
            sqlComm.Parameters.AddWithValue("@invtype", _invtype);
            sqlComm.Parameters.AddWithValue("@invcode", _invcode);
            sqlComm.Parameters.AddWithValue("@serie", _serie);
            sqlComm.Parameters.AddWithValue("@stampdate", _stampdate);
            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@receiverid", _receiverid);
            sqlComm.Parameters.AddWithValue("@recaddressid", _recaddressid);
            sqlComm.Parameters.AddWithValue("@buyerid", _buyerid);
            sqlComm.Parameters.AddWithValue("@buyeraddressid", _buyeraddressid);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@curid", _curid);
            sqlComm.Parameters.AddWithValue("@currate", _currate);
            sqlComm.Parameters.AddWithValue("@bargain", _bargain);
            sqlComm.Parameters.AddWithValue("@transportid", _transportid);
            sqlComm.Parameters.AddWithValue("@incotermsid", _incotermsid);
            sqlComm.Parameters.AddWithValue("@payment", _payment);
            sqlComm.Parameters.AddWithValue("@bankaccountid", _bankaccountid);
            sqlComm.Parameters.AddWithValue("@assetid", _assetid);
            sqlComm.Parameters.AddWithValue("@senderaddressid", _senderaddressid);
            sqlComm.Parameters.AddWithValue("@placeofloading", _placeofloading);
            sqlComm.Parameters.AddWithValue("@agentid", _agentid);
            sqlComm.Parameters.AddWithValue("@agentaddressid", _agentaddressid);
            sqlComm.Parameters.AddWithValue("@vat", _vat);
            sqlComm.Parameters.AddWithValue("@paybefore", _paybefore);
            sqlComm.Parameters.AddWithValue("@inadvance", _inadvance);
            sqlComm.Parameters.AddWithValue("@advancedate", _advancedate);
            sqlComm.Parameters.AddWithValue("@proforma", _proforma);
            sqlComm.Parameters.AddWithValue("@paydate", _paydate);
            sqlComm.Parameters.AddWithValue("@paymentid", _paymentid);
            sqlComm.Parameters.AddWithValue("@sellercontpersid", _sellercontpersid);
            sqlComm.Parameters.AddWithValue("@buyercontpersid", _buyercontpersid);
            sqlComm.Parameters.AddWithValue("@valueforcustoms", _valueforcustoms);
            sqlComm.Parameters.AddWithValue("@esignature", _esignature);
            sqlComm.Parameters.AddWithValue("@recipient", _recipient);


            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void EditExInvoice(int _id, string _name, string _serie, string _stampdate, string _docdate, int _receiverid,
                                    int _buyerid, int _recaddressid, int _buyeraddressid, string _comments, int _curid, double _currate,
                                    string _bargain, int _transportid, int _incotermsid, string _payment, int _bankaccountid,
                                    int _assetid, int _senderaddressid, string _placeofloading, int _agentid, int _agentaddressid,
                                    double _vat, string _paybefore, double _inadvance, string _advancedate, string _proforma, string _paydate,
                                    int _paymentid, int _sellercontpersid, int _buyercontpersid, int _valueforcustoms, int _esignature, string _recipient)
        {
           
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditExInvoiceHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);
            sqlComm.Parameters.AddWithValue("@name", _name);
            sqlComm.Parameters.AddWithValue("@serie", _serie);
            sqlComm.Parameters.AddWithValue("@stampdate", _stampdate);
            sqlComm.Parameters.AddWithValue("@docdate", _docdate);
            sqlComm.Parameters.AddWithValue("@receiverid", _receiverid);
            sqlComm.Parameters.AddWithValue("@recaddressid", _recaddressid);
            sqlComm.Parameters.AddWithValue("@buyerid", _buyerid);
            sqlComm.Parameters.AddWithValue("@buyeraddressid", _buyeraddressid);
            sqlComm.Parameters.AddWithValue("@comments", _comments);
            sqlComm.Parameters.AddWithValue("@curid", _curid);
            sqlComm.Parameters.AddWithValue("@currate", _currate);
            sqlComm.Parameters.AddWithValue("@bargain", _bargain);
            sqlComm.Parameters.AddWithValue("@transportid", _transportid);
            sqlComm.Parameters.AddWithValue("@incotermsid", _incotermsid);
            sqlComm.Parameters.AddWithValue("@payment", _payment);
            sqlComm.Parameters.AddWithValue("@bankaccountid", _bankaccountid);
            sqlComm.Parameters.AddWithValue("@assetid", _assetid);
            sqlComm.Parameters.AddWithValue("@senderaddressid", _senderaddressid);
            sqlComm.Parameters.AddWithValue("@placeofloading", _placeofloading);
            sqlComm.Parameters.AddWithValue("@agentid", _agentid);
            sqlComm.Parameters.AddWithValue("@agentaddressid", _agentaddressid);
            sqlComm.Parameters.AddWithValue("@vat", _vat);
            sqlComm.Parameters.AddWithValue("@paybefore", _paybefore);
            sqlComm.Parameters.AddWithValue("@inadvance", _inadvance);
            sqlComm.Parameters.AddWithValue("@advancedate", _advancedate);
            sqlComm.Parameters.AddWithValue("@proforma", _proforma);
            sqlComm.Parameters.AddWithValue("@paydate", _paydate);
            sqlComm.Parameters.AddWithValue("@paymentid", _paymentid);
            sqlComm.Parameters.AddWithValue("@sellercontpersid", _sellercontpersid);
            sqlComm.Parameters.AddWithValue("@buyercontpersid", _buyercontpersid);
            sqlComm.Parameters.AddWithValue("@valueforcustoms", _valueforcustoms);
            sqlComm.Parameters.AddWithValue("@esignature", _esignature);
            sqlComm.Parameters.AddWithValue("@recipient", _recipient);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
           
        }
        public void DeleteExInvoice(int _id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteExInvoiceHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", _id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }
        #endregion

        #region Package terms

        public static DataTable getPackage(string _beg)
        {
            string query = "EXECUTE sp_PackageSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }
        public int AddPackage(string Package, double VolWeight)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPackage", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@package", Package);
            sqlComm.Parameters.AddWithValue("@volweight", VolWeight);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeletePackage(int Id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePackage", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditPackage(int Id, string Package, double VolWeight)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditPackage", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@package", Package);
            sqlComm.Parameters.AddWithValue("@volweight", VolWeight);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        #endregion

        #region Bargains
        public static DataTable getBargains(string _beg)
        {
            string query = "EXECUTE sp_BargainsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }


        public int AddBargain(string Name, string IntrastatCode, string NameLat)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBargain", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@Name", Name);
            sqlComm.Parameters.AddWithValue("@NameLat", NameLat);
            sqlComm.Parameters.AddWithValue("@IntrastatCode", IntrastatCode);
            sqlComm.Parameters.AddWithValue("@IsActive", -1);
            sqlComm.Parameters.AddWithValue("@BargType", "");

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }

        public void EditBargain(int Id, string Name, string IntrastatCode, string NameLat)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditBargain", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlComm.Parameters.AddWithValue("@Name", Name);
            sqlComm.Parameters.AddWithValue("@NameLat", NameLat);
            sqlComm.Parameters.AddWithValue("@IntrastatCode", IntrastatCode);
            sqlComm.Parameters.AddWithValue("@IsActive", -1);
            sqlComm.Parameters.AddWithValue("@BargType", "");

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteBargain(int Id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteBargain", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }


        #endregion

        #region Printers


        string _DefPrinter = "";
        string _DefIPPrinter = "";
        int _DefPrinterDPI = 300;
        public int DefPrinterDPI
        {
            get { return _DefPrinterDPI; }
            set { _DefPrinterDPI = value; }
        }

        public string DefPrinter
        {
            get { return _DefPrinter; }
            set { _DefPrinter = value; }
        }
        public string DefIPPrinter
        {
            get { return _DefIPPrinter; }
            set { _DefIPPrinter = value; }
        }

        public static DataTable getPrinters(string name)
        {
            string query = "EXECUTE sp_SelectEtPrinters @pcname = '" + name + "'";

            return Helper.QueryDT(query);
        }

        public void MakeDefaultPinter(int PrinterId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_MakePrinterByDefault", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", PrinterId);
            sqlComm.Parameters.AddWithValue("@pcname", System.Environment.MachineName);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();


        }

        public void AddPrinter(string PrinterName, string IP_Address, int Default)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPrinter", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@name", PrinterName);
            sqlComm.Parameters.AddWithValue("@ip", IP_Address);
            sqlComm.Parameters.AddWithValue("@default", Default);
            sqlComm.Parameters.AddWithValue("@pcname", System.Environment.MachineName);
            
            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch
            { }
           
        }

        public void DeletePrinter(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_deletePrinter", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@id", id);
            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        public void EditPrinter(int Id, string PrinterName, string IP_Address, int Default)
        {
           
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditPrinter", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@name", PrinterName);
            sqlComm.Parameters.AddWithValue("@ip", IP_Address);
            sqlComm.Parameters.AddWithValue("@default", Default);
            sqlComm.Parameters.AddWithValue("@pcname", System.Environment.MachineName);
            //try
           // {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            //}
           // catch
           // { }

        }

        public void ShowDefaultPrinter()
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectEtPrinters", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@pcname", System.Environment.MachineName);

            sqlConn.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    if (Convert.ToInt32(sqlReader["default"]) == -1)
                    {
                        DefPrinter = sqlReader["name"].ToString();
                        DefIPPrinter = sqlReader["ipadress"].ToString();
                        DefPrinterDPI = (Int32)sqlReader["dpi"];
                    }
                }
                sqlReader.Close();
            }
            else
            {
                DefPrinter = "";
                DefIPPrinter = "";
                DefPrinterDPI = 300;
            }
            sqlConn.Close();
           
        }
        #endregion

        #region Operations

        public static DataTable getOperations(string _beg)
        {
            string query = "EXECUTE sp_OperationsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public int AddOperation(string Operation, string Formula)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddOperation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@operation", Operation);
            sqlComm.Parameters.AddWithValue("@formula", Formula);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteOperation(int Id)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteOperation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }
        public void EditOperation(int Id, string Operation, string Formula)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditOperation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", Id);
            sqlComm.Parameters.AddWithValue("@operation", Operation);
            sqlComm.Parameters.AddWithValue("@formula", Formula);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        #endregion

        #region Launches

        public static DataTable getLaunches(string _beg)
        {
            string query = "EXECUTE sp_LaunchSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }

        public static DataTable getLaunchGroups(string _beg)
        {
            string query = "EXECUTE sp_LaunchGroupsSelectLike @Beg = '" + _beg + "'";

            return Helper.QueryDT(query);
        }


        #endregion

        #region Places

        public static List<DataNode> StockPlacesList()
        {
            var queryData = Helper.QueryDT("SELECT id, name, parentid FROM STO_Shelves WHERE isnull(isactive, -1) = -1 ORDER BY name");
            var data = new List<DataNode>(queryData.AsEnumerable().
                Select(row => new DataNode
                {
                    Id = Convert.ToInt32(row["id"]),
                    Text = Convert.ToString(row["name"]),
                    ParentId = Convert.ToInt32(row["parentid"])
                }));

            return data;
        }

        #endregion

        #region FreezedReasons

        public static DataTable getFreezedReasons()
        {
            return Helper.QueryDT("SELECT * FROM TMP_FreezedReason where lang = '" + new DAL_Functions().UserLang + "'");
        }

        #endregion
    }

}
