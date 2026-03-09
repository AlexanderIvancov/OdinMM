using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using Odin.Global_Classes;

namespace Odin.CRM
{
    public class CRM_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region General

        public static DataTable getCRMCompanies(int _id, string _company, int _countryid, int _isactive, int _activity, 
                            string _products, int _turnover, int _crmstate, int _salespotential, string _crmmanager)
        {
            string query = "sp_CRMCompanyList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id },
                new SqlParameter("@company",SqlDbType.NVarChar){Value = _company },
                new SqlParameter("@countryid",SqlDbType.Int){Value = _countryid },
                new SqlParameter("@isactive",SqlDbType.Int){Value = _isactive },
                new SqlParameter("@activity",SqlDbType.Int){Value = _activity },
                new SqlParameter("@products",SqlDbType.NVarChar){Value = _products },
                new SqlParameter("@turnover",SqlDbType.Int){Value = _turnover },
                new SqlParameter("@crmstate",SqlDbType.Int){Value = _crmstate },
                new SqlParameter("@salespotential",SqlDbType.Int){Value = _salespotential },
                new SqlParameter("@crmmanager",SqlDbType.NVarChar){Value = _crmmanager },

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getCompanies(int _id, string _company, string _regnr, string _vat, int _countryid, int _isactive)
        {
            string query = "sp_CompanyList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id },
                new SqlParameter("@company",SqlDbType.NVarChar){Value = _company },
                new SqlParameter("@regnr",SqlDbType.NVarChar){Value = _regnr},
                new SqlParameter("@vat",SqlDbType.NVarChar){Value = _vat},
                new SqlParameter("@countryid",SqlDbType.Int){Value = _countryid },
                new SqlParameter("@isactive",SqlDbType.Int){Value = _isactive }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public string Company
        { get; set; }
        public string VAT
        { get; set; }
        public string RegNR
        { get; set; }
        public string Phone
        { get; set; }
        public string Fax
        { get; set; }
        public string Email
        { get; set; }
        public string WebAddress
        { get; set; }
        public int CountryId
        { get; set; }
        public int ParentId
        { get; set; }
        public string FirmCommments
        { get; set; }
        public int SupMark
        {
            get; set;
        }

        public int CustMark
        {
            get; set;
        }

        public int SupPayment
        {
            get; set;
        }

        public int CustPayment
        {
            get; set;
        }

        public int SupIncoterms
        {
            get; set;

        }

        public int CustIncoterms
        {
            get; set;

        }

        public int CompanyIsActive
        { get; set; }

        public double CountryVAT
        { get; set; }

        public string OneC
        {
            get; set;
        }
        public string SupComments
        {
            get; set;
        }
        public int CustPayTerms
        { get; set; }
        public int TransportId
        { get; set; }
        public int BankContId
        { get; set; }
        public int CRMState
        { get; set; }
        public string CRMComments
        { get; set; }
        public int SalesPotential
        { get; set; }
        public string SPComments
        { get; set; }
        public double Turnover
        {
            get;set;
        }
        public double Budget
        {
            get; set;
        }
        public string CRMManager
        { get; set; }
        int _firmid = 0;
        public int FirmId
        {
            get { return _firmid; }
            set
            {
                _firmid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectCompanyDets @id = " + _firmid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Company = dr["company"].ToString();
                        VAT = dr["vat"].ToString();
                        RegNR = dr["regcode"].ToString();
                        Phone = dr["phone"].ToString();
                        Fax = dr["fax"].ToString();
                        Email = dr["email"].ToString();
                        WebAddress = dr["webaddress"].ToString();
                        CountryId = Convert.ToInt32(dr["countryid"]);
                        ParentId = Convert.ToInt32(dr["parentid"]);
                        FirmCommments = dr["comments"].ToString();
                        SupMark = Convert.ToInt32(dr["supmark"]);
                        CustMark = Convert.ToInt32(dr["custmark"]);
                        SupPayment = Convert.ToInt32(dr["suppaymentid"]);
                        CustPayment = Convert.ToInt32(dr["custpaymentid"]);
                        SupIncoterms = Convert.ToInt32(dr["impincoterms"]);
                        CustIncoterms = Convert.ToInt32(dr["expincoterms"]);
                        CompanyIsActive = Convert.ToInt32(dr["isactive"]);
                        CountryVAT = Convert.ToDouble(dr["countryvat"]);
                        OneC = dr["1cnum"].ToString();
                        SupComments = dr["supcomments"].ToString();
                        CustPayTerms = Convert.ToInt32(dr["custpayterms"]);
                        TransportId = Convert.ToInt32(dr["transportid"]);
                        BankContId = Convert.ToInt32(dr["defbankconttopay"]);
                        CRMState = Convert.ToInt32(dr["crmstate"]);
                        CRMComments = dr["crmcomments"].ToString();
                        SalesPotential = Convert.ToInt32(dr["salespotential"]);
                        SPComments = dr["spcomments"].ToString();
                        Turnover = Convert.ToDouble(dr["turnover"]);
                        Budget = Convert.ToDouble(dr["budget"]);
                        CRMManager = dr["crmmanager"].ToString();
                    }
                }
                else
                {
                    ClearFirmFields();
                }
            }
        }

        public void ClearFirmFields()
        {
            Company = "";
            VAT = "";
            RegNR = "";
            Phone = "";
            Fax = "";
            Email = "";
            WebAddress = "";
            CountryId = 0;
            ParentId = 0;
            FirmCommments = "";
            SupMark = 0;
            CustMark = 0;
            SupPayment = 0;
            CustPayment = 0;
            SupIncoterms = 0;
            CustIncoterms = 0;
            CompanyIsActive = 0;
            CountryVAT = 0;
            OneC = "";
            SupComments = "";
            CustPayTerms = 0;
            TransportId = 0;
            BankContId = 0;
            CRMState = 0;
            CRMComments = "";
            SalesPotential = 0;
            SPComments = "";
            Turnover = 0;
            Budget = 0;
            CRMManager = "";
        }

        public int SaveCRMCompany(int id, string name, string phone, string fax, string email, int parentid, int countryid,
                               string webaddress, int supmark, int custmark, int isactive, double turnover, int crmstate, 
                               string crmcomments, int salespotential, string spcomments, double budget, string crmmanager)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveCRMCompany", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@name", name);
            sqlComm.Parameters.AddWithValue("@phone", phone);
            sqlComm.Parameters.AddWithValue("@fax", fax);
            sqlComm.Parameters.AddWithValue("@email", email);
            sqlComm.Parameters.AddWithValue("@parentid", parentid);
            sqlComm.Parameters.AddWithValue("@countryid", countryid);
            sqlComm.Parameters.AddWithValue("@webaddress", webaddress);
            sqlComm.Parameters.AddWithValue("@crmcomments", crmcomments);
            sqlComm.Parameters.AddWithValue("@supmark", supmark);
            sqlComm.Parameters.AddWithValue("@custmark", custmark);
            sqlComm.Parameters.AddWithValue("@isactive", isactive);
            sqlComm.Parameters.AddWithValue("@turnover", turnover);
            sqlComm.Parameters.AddWithValue("@crmstate", crmstate);
            sqlComm.Parameters.AddWithValue("@salespotential", salespotential);
            sqlComm.Parameters.AddWithValue("@spcomments", spcomments);
            sqlComm.Parameters.AddWithValue("@budget", budget);
            sqlComm.Parameters.AddWithValue("@crmmanager", crmmanager);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void DeleteCRMCompany(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCompany", sqlConn);
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

        #endregion

        #region Activities


        public int AddActivity(int firmid, int activityid, string products, string comments)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCompanyActivity", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@firmid", firmid);
            sqlComm.Parameters.AddWithValue("@activityid", activityid);
            sqlComm.Parameters.AddWithValue("@products", products);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
                sqlConn.Close();
            }
            catch { }
            return _res;
        }

        public void EditActivity(int id, int firmid, int activityid, string products, string comments)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCompanyActivity", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@firmid", firmid);
            sqlComm.Parameters.AddWithValue("@activityid", activityid);
            sqlComm.Parameters.AddWithValue("@products", products);
            sqlComm.Parameters.AddWithValue("@comments", comments);


            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }

        }

        public void DeleteActivity(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCompanyActivity", sqlConn);
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

        public static DataTable getActivities(int _id)
        {
            string query = "EXECUTE sp_ActivityList @id = " + _id;

            return Helper.QueryDT(query);
        }

        int _activityid = 0;

        public int ActId
        {
            get { return _activityid; }
            set
            {
                _activityid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectActivityDets @id = " + _activityid, conn);

                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ActActivityId = Convert.ToInt32(dr["activityid"]);
                        ActFirmId = Convert.ToInt32(dr["firmid"]);
                        ActProducts = dr["products"].ToString();
                        ActComments = dr["comments"].ToString();                       
                    }
                }
                else
                {
                    ClearActivities();
                }

            }
        }

        public int ActActivityId
        { get; set; }
        public int ActFirmId
        { get; set; }
        public string ActProducts
        { get; set; }
        public string ActComments
        { get; set; }

        public void ClearActivities()
        {
            ActActivityId = 0;
            ActFirmId = 0;
            ActProducts = "";
            ActComments = "";
        }
        #endregion

        #region Events
        
        public int AddEvent(int firmid, int contactid, string contact, string goal, string theme, string place, string eventdate, 
                               string eventway, string state, string result, string comments, string link)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCRMEvent", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@firmid", firmid);
            sqlComm.Parameters.AddWithValue("@contactid", contactid);
            sqlComm.Parameters.AddWithValue("@contact", contact);
            sqlComm.Parameters.AddWithValue("@eventgoal", goal);
            sqlComm.Parameters.AddWithValue("@eventtheme", theme);
            sqlComm.Parameters.AddWithValue("@place", place);
            sqlComm.Parameters.AddWithValue("@eventdate", eventdate);
            sqlComm.Parameters.AddWithValue("@eventway", eventway);
            sqlComm.Parameters.AddWithValue("@eventstate", state);
            sqlComm.Parameters.AddWithValue("@eventresult", result);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@link", link);
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

        public void EditEvent(int id, int firmid, int contactid, string contact, string goal, string theme, string place, string eventdate,
                               string eventway, string state, string result, string comments, string link)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCRMEvent", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@firmid", firmid);
            sqlComm.Parameters.AddWithValue("@contactid", contactid);
            sqlComm.Parameters.AddWithValue("@contact", contact);
            sqlComm.Parameters.AddWithValue("@eventgoal", goal);
            sqlComm.Parameters.AddWithValue("@eventtheme", theme);
            sqlComm.Parameters.AddWithValue("@place", place);
            sqlComm.Parameters.AddWithValue("@eventdate", eventdate);
            sqlComm.Parameters.AddWithValue("@eventway", eventway);
            sqlComm.Parameters.AddWithValue("@eventstate", state);
            sqlComm.Parameters.AddWithValue("@eventresult", result);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@link", link);
            
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }

        }

        public void DeleteEvent(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCRMEvent", sqlConn);
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

        public static DataTable getEvents(int _id)
        {
            string query = "EXECUTE sp_CRMEventList @id = " + _id;

            return Helper.QueryDT(query);
        }

       
        int _eventid = 0;

        public int EventId
        {
            get { return _eventid; }
            set
            {
                _eventid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectCRMEventDets @id = " + _eventid, conn);

                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EvContactId = Convert.ToInt32(dr["contactid"]);
                        EvFirmId = Convert.ToInt32(dr["firmid"]);
                        EvContact = dr["contact"].ToString();
                        EvGoal = dr["eventgoal"].ToString(); ;
                        EvTheme = dr["eventtheme"].ToString(); 
                        EvPlace = dr["place"].ToString();
                        EvDate = dr["eventdate"].ToString();
                        EvWay = dr["eventway"].ToString();
                        EvState = dr["eventstate"].ToString();
                        EvResult = dr["eventresult"].ToString();
                        EvLink = dr["link"].ToString();
                        EvComments = dr["comments"].ToString();
                    }
                }
                else
                {
                    ClearEvents();
                }

            }
        }

        public int EvContactId
        { get; set; }
        public int EvFirmId
        { get; set; }
        public string EvContact
        { get; set; }
        public string EvGoal
        { get; set; }
        public string EvTheme
        { get; set; }
        public string EvPlace
        { get; set; }
        public string EvDate
        { get; set; }
        public string EvWay
        { get; set; }
        public string EvState
        { get; set; }
        public string EvResult
        { get; set; }
        public string EvComments
        { get; set; }
        public string EvLink
        { get; set; }

        public void ClearEvents()
        {
            EvContactId = 0;
            EvFirmId = 0;
            EvContact = "";
            EvComments = "";
            EvGoal = "";
            EvTheme = "";
            EvPlace = "";
            EvDate = "";
            EvWay = "";
            EvState = "";
            EvResult = "";
            EvComments = "";
            EvLink = "";
        }
        #endregion

        #region Event schedule

        public void AddEventSchedule(int eventid, string action, string respperson, string plandate,
                               string execdate, int stateid, string result, string comments)
        {
            
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCRMEventSchedule", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@eventid", eventid);
            sqlComm.Parameters.AddWithValue("@action", action);
            sqlComm.Parameters.AddWithValue("@respperson", respperson);
            sqlComm.Parameters.AddWithValue("@plandate", plandate);
            sqlComm.Parameters.AddWithValue("@execdate", execdate);
            sqlComm.Parameters.AddWithValue("@stateid", stateid);
            sqlComm.Parameters.AddWithValue("@result", result);
            sqlComm.Parameters.AddWithValue("@comments", comments);
           

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
          
        }

        public void EditEventSchedule(int id, string action, string respperson, string plandate,
                               string execdate, int stateid, string result, string comments)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCRMEventSchedule", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@action", action);
            sqlComm.Parameters.AddWithValue("@respperson", respperson);
            sqlComm.Parameters.AddWithValue("@plandate", plandate);
            sqlComm.Parameters.AddWithValue("@execdate", execdate);
            sqlComm.Parameters.AddWithValue("@stateid", stateid);
            sqlComm.Parameters.AddWithValue("@result", result);
            sqlComm.Parameters.AddWithValue("@comments", comments);

            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }

        }

        public void DeleteEventSchedule(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCRMEventSchedule", sqlConn);
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

        public static DataTable getEventSchedule(int _eventid)
        {
            string query = "EXECUTE sp_CRMEventSchedule @eventid = " + _eventid;

            return Helper.QueryDT(query);
        }

        public static DataTable getEventScheduleList(int _custid, string _datefrom, string _datetill)
        {
            string query = "sp_CRMEventScheduleList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom },
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
            
        }
        
        int _eventshedid = 0;

        public int EventSchedId
        {
            get { return _eventshedid; }
            set
            {
                _eventshedid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectCRMEventSchedDets @id = " + _eventshedid, conn);

                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        EvsAction = dr["action"].ToString();
                        EvsRespPerson = dr["respperson"].ToString(); ;
                        EvsPlanDate = dr["plandate"].ToString();
                        EvsExecDate = dr["execdate"].ToString();
                        EvsState = dr["state"].ToString();
                        EvsStateId = Convert.ToInt32(dr["stateid"]);
                        EvsResult = dr["result"].ToString();
                        EvsComments = dr["comments"].ToString();
                    }
                }
                else
                {
                    ClearEvents();
                }

            }
        }
        
        
        public string EvsAction
        { get; set; }
        public string EvsRespPerson
        { get; set; }
        public string EvsPlanDate
        { get; set; }
        public string EvsExecDate
        { get; set; }
        public string EvsState
        { get; set; }
        public int EvsStateId
        { get; set; }
        public string EvsResult
        { get; set; }
        public string EvsComments
        { get; set; }
       
        public void ClearSchedEvents()
        {
            EvsAction = "";
            EvsRespPerson = "";
            EvsComments = "";
            EvsPlanDate = "";
            EvsExecDate = "";
            EvsState = "";
            EvsStateId = 0;
            EvsResult = "";
            EvsComments = "";

        }

        #endregion
    }
}
