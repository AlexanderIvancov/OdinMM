using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Odin.Sales
{
    public class CO_BLL
    {

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Sales Orders

        #region Header

        public int AddSalesOrderHead(int CustId, int ContPersonId, string Comments, string Contract, int CurId, int IncotermId)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddSalesOrderHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@CustId", CustId);
            sqlComm.Parameters.AddWithValue("@ContPersonId", ContPersonId);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@Contract", Contract);
            sqlComm.Parameters.AddWithValue("@CurId", CurId);
            sqlComm.Parameters.AddWithValue("@IncotermId", IncotermId);

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

        public void EditSalesOrderHead(int Id, int CustId, int ContPersonId, string Comments, string Contract, int CurId, int IncotermId)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditSalesOrderHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlComm.Parameters.AddWithValue("@CustId", CustId);
            sqlComm.Parameters.AddWithValue("@ContPersonId", ContPersonId);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@Contract", Contract);
            sqlComm.Parameters.AddWithValue("@CurId", CurId);
            sqlComm.Parameters.AddWithValue("@IncotermId", IncotermId);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        public void DeleteSalesOrderHead(int Id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteSalesOrderHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);

            //try
            //{
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            //}
            //catch { }
        }

        int _coheadid = 0;

        public string COHeader
        { get; set; }
        public int COHeadCustId
        { get; set; }
        public int COHeadContPersId
        { get; set; }
        public string COHeadComments
        { get; set; }
        public string COHeadCreatAt
        { get; set; }
        public string COHeadCreatBy
        { get; set; }
        public string COHeadContract
        { get; set; }
        public int COHeadCurId
        { get; set; }
        public int COHeadIncoterms
        { get; set; }
        public int COHeadId
        {
            get { return _coheadid; }
            set { _coheadid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectCOHeader @id = " + _coheadid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        COHeader = dr["name"].ToString();
                        COHeadCustId = Convert.ToInt32(dr["clientid"]);
                        COHeadContPersId = Convert.ToInt32(dr["contpersonid"]);
                        COHeadCreatAt = dr["when"].ToString();
                        COHeadCreatBy = dr["userlogin"].ToString();
                        COHeadComments = dr["comments"].ToString();
                        COHeadContract = dr["contract"].ToString();
                        COHeadCurId = Convert.ToInt32(dr["curid"]); ;
                        COHeadIncoterms = Convert.ToInt32(dr["incotermid"]); ;
                    }
                }
                else
                {
                    ClearCOHead();
                }
            }
        }
        public void ClearCOHead()
        {
            COHeader = "";
            COHeadCustId = 0;
            COHeadContPersId = 0;
            COHeadCreatAt = "";
            COHeadCreatBy = "";
            COHeadComments = "";
            COHeadContract = "";
            COHeadCurId = 0;
            COHeadIncoterms = 0;
        }

        #endregion

        #region Details

        public static DataTable getSalesOrders(int _coheadid, int _batchid, int _typeid, int _deptid, int _custid, DataTable _states, int _artid, string _article,
            string _custarticle, string _datefrom, string _datetill, string _custorder, string _comments, string _reqdatefrom, string _reqdatetill)
        {
            string query = "sp_SalesPortfolio";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@coid",SqlDbType.Int){Value = _coheadid },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid },
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                //new SqlParameter("@stateid",SqlDbType.Int){Value = _stateid },
                new SqlParameter("@tablestates", SqlDbType.Structured) { TypeName = "UT_IDs", Value = _states},
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@custarticle",SqlDbType.NVarChar){Value = _custarticle},
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@custorder",SqlDbType.NVarChar){Value = _custorder},
                new SqlParameter("@comments",SqlDbType.NVarChar){Value = _comments },
                new SqlParameter("@reqdatefrom",SqlDbType.NVarChar){Value = _reqdatefrom},
                new SqlParameter("@reqdatetill",SqlDbType.NVarChar){Value = _reqdatetill}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getCOStages(int _coid)
        {
            string query = "sp_SelectOrderStages";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@coid",SqlDbType.Int){Value = _coid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        int _coid = 0;

        public bool IsNewOrderForArt(int artid, int coid)
        {
            bool _test = true;

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "select top 1 id from sal_clientordersdets where id < " + coid + " and artid = " + artid, conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            _test = dt.Rows.Count <= 0;

            return _test;
        }

        public int COId
        {
            get { return _coid; }
            set
            {
                _coid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectCODets @id = " + _coid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        COArtId = Convert.ToInt32(dr["artid"]);
                        COComments1 = dr["comments1"].ToString();
                        COComments = dr["comments"].ToString();
                        COCreatAt = dr["createdat"].ToString();
                        COCreatBy = dr["createdby"].ToString();
                        COCustArticle = dr["custarticle"].ToString();
                        COCustLine = dr["custorderline"].ToString();
                        COCustOrder = dr["custorder"].ToString();
                        CODelivAddressId = Convert.ToInt32(dr["delivaddressid"]);
                        CODelivPlaceId = Convert.ToInt32(dr["delivplaceid"]);
                        COEndCustId = Convert.ToInt32(dr["endcustid"]);
                        COEndCustRef = dr["endcustref"].ToString();
                        COEndCustReqDate = dr["endcustreqdate"].ToString();
                        COLine = Convert.ToInt32(dr["orderline"]);
                        COLogComments = dr["logcomments"].ToString();
                        COPurLine = dr["porder"].ToString();
                        COPurOrder = dr["poline"].ToString();
                        COQty = Convert.ToDouble(dr["qty"]);
                        COQtyDeliv = Convert.ToDouble(dr["qtydeliv"]);
                        COReqDate = dr["reqdate"].ToString();
                        COService = Convert.ToInt32(dr["service"]);
                        COStateId = Convert.ToInt32(dr["stateid"]);
                        COUnitId = Convert.ToInt32(dr["unitid"]);
                        COUnitPrice = Convert.ToDouble(dr["unitprice"]);
                        COVat = Convert.ToDouble(dr["vat"]);
                        COHeadId1 = Convert.ToInt32(dr["headid"]);
                        COCustomer = dr["customer"].ToString();
                        COStages = dr["stages"].ToString();
                        COQuotId = Convert.ToInt32(dr["quotid"]);
                        COLeadWeek = dr["leadweek"].ToString();
                        COBOMState = Convert.ToInt32(dr["bomstate"]);
                        COQtyInvoiced = Convert.ToDouble(dr["qtyinvoiced"]);
                        COInternal = Convert.ToInt32(dr["internal"]);
                        COLeftInAdvance = Convert.ToDouble(dr["leftinadvance"]);
                        COAllowToInvoice = Convert.ToInt32(dr["allowtoinvoice"]);
                        COResale = Convert.ToInt32(dr["resale"]);
                        COSpoilageQty = Convert.ToDouble(dr["spoilageqty"]);
                        COQtyInBatch = Convert.ToDouble(dr["qtyinbatch"]);
                        COBlocked = Convert.ToInt32(dr["blockdelivery"]);
                        COPaid = Convert.ToDouble(dr["paid"]);
                        COSalesComments = dr["salescomments"].ToString();
                        COQtyIn = Convert.ToDouble(dr["qtyin"]);
                        COPrimary = Convert.ToInt32(dr["isprimary"]);
                    }
                }
                else
                {
                    ClearCODets();
                }
            }
        }

        public int COHeadId1
        {
            get; set;
        }

        public int COLine
        {
            get; set;
        }
        public int COArtId
        {
            get; set;
        }
        public int COService
        {
            get; set;
        }
        public string COCustOrder
        {
            get; set;
        }
        public string COCustLine
        {
            get; set;
        }
        public string COPurOrder
        {
            get; set;
        }
        public string COPurLine
        {
            get; set;
        }
        public string COCustArticle
        {
            get; set;
        }
        public double COQty
        {
            get; set;
        }
        public double COQtyDeliv
        { get; set; }
        public string COReqDate
        { get; set; }
        public int COUnitId
        {
            get; set;
        }
        public double COUnitPrice
        {
            get; set;
        }
        public double COVat
        {
            get; set;
        }
        public int COStateId
        {
            get; set;
        }
        public string COComments
        {
            get; set;
        }
        public string COComments1
        {
            get; set;
        }
        public string COLogComments
        {
            get; set;
        }
        public int CODelivPlaceId
        {
            get; set;
        }
        public int CODelivAddressId
        {
            get; set;
        }
        public int COEndCustId
        {
            get; set;
        }
        public string EndCustOrder
        {
            get; set;
        }
        public string COEndCustRef
        {
            get; set;
        }
        public string COEndCustReqDate
        {
            get; set;
        }
        public string COCreatAt
        {
            get; set;
        }
        public string COCreatBy
        {
            get; set;
        }
        public string COCustomer
        { get; set; }
        public string COStages
        { get; set; }
        public int COQuotId
        { get; set; }
        public string COLeadWeek
        { get; set; }
        public int COBOMState
        { get; set; }
        public double COQtyInvoiced
        { get; set; }
        public int COInternal
        { get; set; }
        public double COInAdvance
        { get; set; }
        public double COLeftInAdvance
        { get; set; }
        public int COAllowToInvoice
        { get; set; }
        public int COEndCustomerId
        { get; set; }
        public int COResale
        { get; set; }
        public double COSpoilageQty
        { get; set; }
        public double COQtyInBatch
        { get; set; }
        public int COBlocked
        { get; set; }
        public double COPaid
        { get; set; }
        public string COSalesComments
        { get; set; }
        public double COQtyIn
        { get; set; }
        public int COPrimary
        { get; set; }
        public void ClearCODets()
        {
            COArtId = 0;
            COComments1 = "";
            COComments = "";
            COCreatAt = "";
            COCreatBy = "";
            COCustArticle = "";
            COCustLine = "";
            COCustOrder = "";
            CODelivAddressId = 0;
            CODelivPlaceId = 0;
            COEndCustId = 0;
            COEndCustRef = "";
            COEndCustReqDate = "";
            COLine = 0;
            COLogComments = "";
            COPurLine = "";
            COPurOrder = "";
            COQty = 0;
            COReqDate = "";
            COService = 0;
            COStateId = 0;
            COUnitId = 0;
            COUnitPrice = 0;
            COVat = 0;
            COHeadId1 = 0;
            COCustomer = "";
            COStages = "";
            COQuotId = 0;
            COLeadWeek = "";
            COBOMState = 0;
            COQtyDeliv = 0;
            COQtyInvoiced = 0;
            COInternal = 0;
            COLeftInAdvance = 0;
            COAllowToInvoice = -1;
            COEndCustomerId = 0;
            COResale = 0;
            COSpoilageQty = 0;
            COQtyInBatch = 0;
            COBlocked = 0;
            COPaid = 0;
            COSalesComments = "";
            COQtyIn = 0;
            COPrimary = 0;
        }

        public int SaveCOLine(int id, int headid, int line, string corder, string coline, string porder, string poline, int artid, string custarticle,
                            int service, double qty, int unitid, string reqdate, int stateid, double unitprice, double vat,
                            string comments, string comments1, string logcomments, int delivplaceid, int delivaddressid, int endcustid, string endcustorder,
                            string endcustref, string endcustreqdate, DataTable stages, int _internal, int _resale, double _spoilage, int _blocked,
                            string _salescomments, int _isprimary)
        {
            int _res = 0;


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveCODets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@line", line);
            sqlComm.Parameters.AddWithValue("@corder", corder);
            sqlComm.Parameters.AddWithValue("@coline", coline);
            sqlComm.Parameters.AddWithValue("@porder", porder);
            sqlComm.Parameters.AddWithValue("@poline", poline);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@custarticle", custarticle);
            sqlComm.Parameters.AddWithValue("@service", service);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@reqdate", reqdate);
            sqlComm.Parameters.AddWithValue("@stateid", stateid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@comments1", comments1);
            sqlComm.Parameters.AddWithValue("@logcomments", logcomments);
            sqlComm.Parameters.AddWithValue("@delivplaceid", delivplaceid);
            sqlComm.Parameters.AddWithValue("@delivaddressid", delivaddressid);
            sqlComm.Parameters.AddWithValue("@endcustid", endcustid);
            sqlComm.Parameters.AddWithValue("@endcustorder", endcustorder);
            sqlComm.Parameters.AddWithValue("@endcustref", endcustref);
            sqlComm.Parameters.AddWithValue("@endcustreqdate", endcustreqdate);
            sqlComm.Parameters.AddWithValue("@spoilage", _spoilage);
            sqlComm.Parameters.AddWithValue("@blocked", _blocked);

            sqlComm.Parameters.Add("@tablestages", SqlDbType.Structured);
            sqlComm.Parameters["@tablestages"].TypeName = "UT_COStages";
            sqlComm.Parameters["@tablestages"].Value = stages;
            sqlComm.Parameters.AddWithValue("@internal", _internal);
            sqlComm.Parameters.AddWithValue("@resale", _resale);
            sqlComm.Parameters.AddWithValue("@salescomments", _salescomments);
            sqlComm.Parameters.AddWithValue("@isprimary", _isprimary);


            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();
            

            return _res;
        }

        public int LastCOLine(int coheadid)
        {
            int _res = 0;

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 orderline FROM sal_clientordersdets WHERE headid = " + coheadid.ToString() + " order by orderline desc", conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _res = Convert.ToInt32(dr["orderline"]);
                }
            }
            else
            {
                _res = 0;
            }

            return _res;
        }

        public string DeleteCOLine(int id)
        {
            string _res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCODets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public string MakeCOasPO(int id)
        {
            string _res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_MakeCOAsPO", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        #endregion

        #region Confirmations

        public static DataTable getCOConfirmations(int _coid)
        {
            string query = "EXECUTE sp_SelectCOConfirmations @coid = " + _coid;

            return Helper.QueryDT(query);
        }

        public static DataTable getCOConfirmationsPortfolio(int _custid, int _typeid, int _artid, string _datefrom, string _datetill)
        {
            string query = "sp_COConfirmationsPortfolio";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        int _confid = 0;

        public int ConfId
        {
            get { return _confid; }
            set { _confid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectCOConfDets @confid = " + _confid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        ConfComments = dr["comments"].ToString();
                        ConfCreatAt = dr["creatat"].ToString();
                        ConfCreatBy = Convert.ToInt32(dr["creatby"]);
                        ConfCOId = Convert.ToInt32(dr["coid"]);
                        ConfDate = dr["confirmdate"].ToString();
                        ConfQty = Convert.ToDouble(dr["confirmqty"]);
                        ConfDelivPlaceId = Convert.ToInt32(dr["delivplaceid"]);
                        ConfAddressId = Convert.ToInt32(dr["addressid"]);
                    }
                }
                else
                {
                    ClearConfDets();
                }
            }
        }

        public string ConfComments
        { get; set; }
        public string ConfCreatAt
        { get; set; }
        public int ConfCreatBy
        { get; set; }
        public int ConfCOId
        { get; set; }
        public string ConfDate
        { get; set; }
        public double ConfQty
        { get; set; }
        public int ConfDelivPlaceId
        { get; set; }
        public int ConfAddressId
        { get; set; }

        public void ClearConfDets()
        {
            ConfComments = "";
            ConfCreatAt = "";
            ConfCreatBy = 0;
            ConfCOId = 0;
            ConfDate = "";
            ConfQty = 0;
            ConfAddressId = 0;
            ConfDelivPlaceId = 0;
        }

        public int AddCOConfirmation(int coid, double qty, string confdate, string comments, int delivplaceid, int addressid)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCOConfirm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@confdate", confdate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@delivplaceid", delivplaceid);
            sqlComm.Parameters.AddWithValue("@addressid", addressid);


            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();


            return _res;
        }

        public void EditCOConfirmation(int id, int coid, double qty, string confdate, string comments, int delivplaceid, int addressid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCOConfirm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@confdate", confdate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@delivplaceid", delivplaceid);
            sqlComm.Parameters.AddWithValue("@addressid", addressid);


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

        }

        public void DeleteCOConfirmation(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCOConfirm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

        }
        #endregion

        #region Batches
        public static DataTable getCOBatches(int _coid)
        {
            string query = "EXECUTE sp_SelectCOBatches @coid = " + _coid;

            return Helper.QueryDT(query);
        }
        public static DataTable getBatchMappings(int _batchid)
        {
            string query = "EXECUTE sp_SelectSalesOrdersMappings @batchid = " + _batchid;

            return Helper.QueryDT(query);
        }

        #endregion

        #region Deliveries

        public static DataTable getCODeliveries(int _coid)
        {
            string query = "EXECUTE sp_SelectCODeliveries @coid = " + _coid;

            return Helper.QueryDT(query);
        }

        #endregion

        #region History

        public static DataTable getHistoryOrders(int _id)
        {
            string query = "EXECUTE sp_SelectCOHistory @coid = " + _id;

            return Helper.QueryDT(query);
        }

        #endregion

        #endregion

        #region Quotations

        public static DataTable getQuotStages(int _coid)
        {
            string query = "sp_SelectQuotationStages";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@quotid",SqlDbType.Int){Value = _coid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        int _quotid = 0;



        public int QuotId
        {
            get { return _quotid; }
            set
            {
                _quotid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectQuotDets @id = " + _quotid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        QArtId = Convert.ToInt32(dr["artid"]);
                        QComments = dr["comments"].ToString();
                        QCreatAt = dr["createdat"].ToString();
                        QCreatBy = dr["createdby"].ToString();
                        QCustArticle = dr["custarticle"].ToString();
                        QQty = Convert.ToDouble(dr["qty"]);
                        QReqDate = dr["reqdate"].ToString();
                        QExpDate = dr["expdate"].ToString();
                        QWeek = dr["leadweek"].ToString();
                        QStateId = Convert.ToInt32(dr["stateid"]);
                        QUnitId = Convert.ToInt32(dr["unitid"]);
                        QUnitPrice = Convert.ToDouble(dr["unitprice"]);
                        QName = dr["name"].ToString();
                        QRevision = dr["revision"].ToString();
                        QPCB = Convert.ToInt32(dr["pcb"]);
                        QCustId = Convert.ToInt32(dr["custid"]);
                        QPCBText = dr["pcbtext"].ToString();
                        QCurId = Convert.ToInt32(dr["curid"]);
                        QCOrder = dr["corder"].ToString();
                        QCOLine = dr["coline"].ToString();
                        QIsSent = Convert.ToInt32(dr["issent"]);
                        QSentDate = dr["sentdate"].ToString();
                        QQtyInvoiced = Convert.ToDouble(dr["qtyinvoiced"]);
                        QNotPaidAdvance = Convert.ToInt32(dr["notpaidadvance"]);
                        QEndCustomerId = Convert.ToInt32(dr["endcustomerid"]);
                        QInternal = Convert.ToInt32(dr["internal"]);
                        QSpoilageQty = Convert.ToDouble(dr["spoilageqty"]);
                        QResale = Convert.ToInt32(dr["resale"]);
                        QBlockDelivery = Convert.ToInt32(dr["blockdelivery"]);
                        QIsProject = Convert.ToInt32(dr["isproject"]);
                        QValidBOM = Convert.ToInt32(dr["isvalid"]);
                        QCheckRMQP = Convert.ToInt32(dr["checkrmqp"]);
                        QPrimary = Convert.ToInt32(dr["isprimary"]);
                        QDelivPlaceId = Convert.ToInt32(dr["delivplaceid"]);
                        QDelivAddressId = Convert.ToInt32(dr["delivaddressid"]);
                    }
                }
                else
                {
                    ClearQuotDets();
                }
            }
        }

        public int QArtId
        {
            get; set;
        }

        public int QCustId
        {
            get; set;
        }
        public string QName
        { get; set; }
        public string QRevision
        {
            get; set;
        }

        public string QCustArticle
        {
            get; set;
        }
        public double QQty
        {
            get; set;
        }
        public string QReqDate
        { get; set; }
        public string QWeek
        { get; set; }
        public string QExpDate
        { get; set; }
        public int QUnitId
        {
            get; set;
        }
        public double QUnitPrice
        {
            get; set;
        }

        public int QStateId
        {
            get; set;
        }
        public string QComments
        {
            get; set;
        }

        public int QPCB
        {
            get; set;
        }

        public string QPCBText
        {
            get; set;
        }

        public string QCreatAt
        {
            get; set;
        }
        public string QCreatBy
        {
            get; set;
        }
        public int QCurId
        {
            get; set;
        }
        public string QCOrder
        { get; set; }
        public string QCOLine
        { get; set; }

        public int QIsSent
        { get; set; }

        public string QSentDate
        { get; set; }

        public double QQtyInvoiced
        { get; set; }

        public int QNotPaidAdvance
        { get; set; }
        public int QEndCustomerId
        { get; set; }
        public int QInternal
        { get; set; }
        public double QSpoilageQty
        { get; set; }
        public int QResale
        { get; set; }
        public int QBlockDelivery
        { get; set; }
        public int QIsProject
        { get; set; }
        public int QValidBOM
        { get; set; }
        public int QCheckRMQP
        { get; set; }
        public int QPrimary
        { get; set; }
        public int QDelivPlaceId
        { get; set; }
        public int QDelivAddressId
        { get; set; }
        public void ClearQuotDets()
        {
            QCustId = 0;
            QName = "";
            QArtId = 0;
            QComments = "";
            QRevision = "";
            QCreatAt = "";
            QCreatBy = "";
            QCustArticle = "";
            QPCB = 1;
            QPCBText = "";
            QQty = 0;
            QReqDate = "";
            QExpDate = "";
            QWeek = "";
            QStateId = 0;
            QUnitId = 0;
            QUnitPrice = 0;
            QCurId = 0;
            QCOLine = "";
            QCOrder = "";
            QIsSent = 0;
            QSentDate = "";
            QNotPaidAdvance = 0;
            QEndCustomerId = 0;
            QInternal = 0;
            QSpoilageQty = 0;
            QResale = 0;
            QBlockDelivery = 0;
            QIsProject = 0;
            QValidBOM = 0;
            QCheckRMQP = 0;
            QPrimary = 0;
            QDelivPlaceId = 0;
            QDelivAddressId = 0;
        }
        public int SaveQuotation(int id, int artid, string revision, string custarticle, double qty, int unitid, string reqdate,
                                string expdate, string week, int stateid, double unitprice, string comments, int custid,
                                int pcb, DataTable stages, int CurId, string corder, string coline, int issent, string sentdate,
                                int endcustomerid, int _internal, double _spoilage, int _resale, int _blockdelivery, int _isproject,
                                int _isprimary, int _delivplaceid, int _delivaddressid)
        {
            int _res = 0;


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveQuotation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@revision", revision);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@custarticle", custarticle);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@reqdate", reqdate);
            sqlComm.Parameters.AddWithValue("@expdate", expdate);
            sqlComm.Parameters.AddWithValue("@week", week);
            sqlComm.Parameters.AddWithValue("@stateid", stateid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@custid", custid);
            sqlComm.Parameters.AddWithValue("@pcb", pcb);
            sqlComm.Parameters.AddWithValue("@curid", CurId);
            sqlComm.Parameters.AddWithValue("@corder", corder);
            sqlComm.Parameters.AddWithValue("@coline", coline);
            sqlComm.Parameters.AddWithValue("@issent", issent);
            sqlComm.Parameters.AddWithValue("@sentdate", sentdate);
            sqlComm.Parameters.AddWithValue("@endcustomerid", endcustomerid);
            sqlComm.Parameters.AddWithValue("@internal", _internal);
            sqlComm.Parameters.AddWithValue("@spoilage", _spoilage);
            sqlComm.Parameters.AddWithValue("@resale", _resale);
            sqlComm.Parameters.AddWithValue("@blockdelivery", _blockdelivery);
            sqlComm.Parameters.AddWithValue("@isproject", _isproject);
            sqlComm.Parameters.AddWithValue("@isprimary", _isprimary);
            sqlComm.Parameters.AddWithValue("@delivplaceid", _delivplaceid);
            sqlComm.Parameters.AddWithValue("@delivaddressid", _delivaddressid);

            sqlComm.Parameters.Add("@tablestages", SqlDbType.Structured);
            sqlComm.Parameters["@tablestages"].TypeName = "UT_COStages";
            sqlComm.Parameters["@tablestages"].Value = stages;

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@isneworder", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            CreateOrder = Convert.ToInt32(sqlComm.Parameters["@isneworder"].Value) == -1;
            sqlConn.Close();

            return _res;
        }


        bool _createorder = false;
        public bool CreateOrder
        {
            get { return _createorder; }
            set { _createorder = value; }
        }

        public int AddCOFromQuotation(int id)
        {
            int _res = 0;


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCOFromQuotation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }


        public int DeleteQuotation(int id)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteQuotation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@success", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@success"].Value);
            sqlConn.Close();

            return _res;

        }
        public static DataTable getQuotations(int _id, int _typeid, int _deptid, int _custid, int _stateid, int _artid, string _custarticle,
                            string _datefrom, string _datetill, string _comments, string _reqdatefrom, string _reqdatetill, int _pcb)
        {
            string query = "sp_SalesQuotationsPortfolio";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid },
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@stateid",SqlDbType.Int){Value = _stateid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@custarticle",SqlDbType.NVarChar){Value = _custarticle},
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@comments",SqlDbType.NVarChar){Value = _comments },
                new SqlParameter("@reqdatefrom",SqlDbType.NVarChar){Value = _reqdatefrom},
                new SqlParameter("@reqdatetill",SqlDbType.NVarChar){Value = _reqdatetill},
                new SqlParameter("@pcb",SqlDbType.Int){Value = _pcb}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region Export Invoices

        public static DataTable getExInvoices(int _invoiceid, int _invtypeid, int _typeid, int _deptid, int _receiverid, int _buyerid,
                            int _coid, int _artid, string _custarticle, string _datefrom, string _datetill, string _comments, int _paid, int _active)
        {
            string query = "sp_ExportInvoicesPortfolio";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@invoiceid",SqlDbType.Int){Value = _invoiceid },
                new SqlParameter("@invtypeid",SqlDbType.Int){Value = _invtypeid },
                new SqlParameter("@coid",SqlDbType.Int){Value = _coid },
                new SqlParameter("@receiverid",SqlDbType.Int){Value = _receiverid },
                new SqlParameter("@buyerid",SqlDbType.NVarChar){Value = _buyerid},
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@custarticle",SqlDbType.NVarChar){Value = _custarticle},
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@comments",SqlDbType.NVarChar){Value = _comments },
                new SqlParameter("@paid",SqlDbType.Int){Value = _paid },
                new SqlParameter("@active",SqlDbType.Int){Value = _active }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void AddExInvoiceDets(int delivid, int headid, int artid, string payment, double qty, int unitid, double unitprice, double vat,
                                    double discount, string custcode, string comments, int coid, int isservice, int additexpences, 
                                    int quotid, int ispaid, double paidinadvance, string salescomments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddExInvoiceDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@delivid", delivid);
            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@payment", payment);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@discount", discount);
            sqlComm.Parameters.AddWithValue("@custcode", custcode);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@isservice", isservice);
            sqlComm.Parameters.AddWithValue("@isadditexpences", additexpences);
            sqlComm.Parameters.AddWithValue("@quotid", quotid);
            sqlComm.Parameters.AddWithValue("@ispaid", ispaid);
            sqlComm.Parameters.AddWithValue("@paidinadvance", paidinadvance);
            sqlComm.Parameters.AddWithValue("@salescomments", salescomments);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        public void EditExInvoiceDets(int id, int artid, string payment, double qty, int unitid, double unitprice, double vat,
                                   double discount, string custcode, string comments, int coid, int isservice, int additexpences, 
                                   int quotid, int ispaid, double paidinadvance, int isactive, string salescomments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditExInvoiceDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@payment", payment);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@discount", discount);
            sqlComm.Parameters.AddWithValue("@custcode", custcode);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@isservice", isservice);
            sqlComm.Parameters.AddWithValue("@isadditexpences", additexpences);
            sqlComm.Parameters.AddWithValue("@quotid", quotid);
            sqlComm.Parameters.AddWithValue("@ispaid", ispaid);
            sqlComm.Parameters.AddWithValue("@paidinadvance", paidinadvance);
            sqlComm.Parameters.AddWithValue("@isactive", isactive);
            sqlComm.Parameters.AddWithValue("@salescomments", salescomments);

            //try
            //{
            sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
           // }
           // catch { }
        }

        public void DeleteExInvoiceDets(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteExInvoiceDets", sqlConn);
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

        public void CloseExInvoice(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_CloseExInvoice", sqlConn);
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

        public static DataTable getExInvoiceDets(int _invoiceid)
        {
            string query = "sp_SelectExInvoiceDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _invoiceid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getCOInvoices(int _coid)
        {
            string query = "EXECUTE sp_SelectCOInvoices @coid = " + _coid;

            return Helper.QueryDT(query);
        }

        int _invdetid = 0;

        public int InvoiceDetId
        {
            get { return _invdetid; }
            set { _invdetid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectExInvoiceDet @id = " + _invdetid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        InvLine = Convert.ToInt32(dr["Line"]);
                        InvProduct = dr["Product"].ToString();
                        InvComments = dr["Comments"].ToString();
                        InvArtId = Convert.ToInt32(dr["artid"]);
                        InvCOId = Convert.ToInt32(dr["coid"]);
                        InvQty = Convert.ToDouble(dr["Qty"]);
                        InvUnitId = Convert.ToInt32(dr["unitid"]);
                        InvUnitPrice = Convert.ToDouble(dr["UnitPrice"]);
                        InvDelivId = Convert.ToInt32(dr["delivid"]);
                        InvDelivNote = dr["delivnote"].ToString();
                        InvVAT = Convert.ToDouble(dr["VAT"]);
                        InvCustCode = dr["CustCode"].ToString();
                        InvCurId = Convert.ToInt32(dr["curid"]);
                        InvIsAdditExpences = Convert.ToInt32(dr["isadditexpences"]);
                        InvIsService = Convert.ToInt32(dr["isservice"]);
                        InvDiscount = Convert.ToDouble(dr["discount"]);
                        InvQuotId = Convert.ToInt32(dr["quotid"]);
                        InvIsPaid = Convert.ToInt32(dr["ispaid"]);
                        InvInAdvance = Convert.ToDouble(dr["InAdvance"]);
                        InvLeftInAdvance = Convert.ToDouble(dr["LeftInAdvance"]);
                        InvAllowToInvoice = Convert.ToInt32(dr["allowtoinvoice"]);
                        InvIsActive = Convert.ToInt32(dr["isactive"]);
                        InvSalesComments = dr["salescomments"].ToString();
                    }
                }
                else
                {
                    ClearInvDets();
                }

            }
        }

        public int InvLine
        { get; set; }
        public string InvProduct
        { get; set; }
        public int InvArtId
        { get; set; }
        public double InvQty
        { get; set; }
        public string InvComments
        { get; set; }
        public int InvUnitId
        { get; set; }
        public double InvUnitPrice
        { get; set; }
        public int InvDelivId
        { get; set; }
        public int InvCOId
        { get; set; }
        public string InvDelivNote
        { get; set; }
        public double InvVAT
        { get; set; }
        public string InvCustCode
        { get; set; }
        public int InvCurId
        { get; set; }
        public int InvIsService
        { get; set; }
        public int InvIsAdditExpences
        { get; set; }
        public double InvDiscount
        { get; set; }
        public int InvQuotId
        { get; set; }
        public int InvIsPaid
        { get; set; }
        public double InvInAdvance
        { get; set; }
        public double InvLeftInAdvance
        { get; set; }
        public int InvAllowToInvoice
        { get; set; }
        public int InvIsActive
        { get; set; }
        public string InvSalesComments
        { get; set; }
        public void ClearInvDets()
        {
            InvLine = 0;
            InvProduct = "";
            InvComments = "";
            InvArtId = 0;
            InvCOId = 0;
            InvQty = 0;
            InvUnitId = 0;
            InvUnitPrice = 0;
            InvDelivId = 0;
            InvDelivNote = "";
            InvVAT = 0;
            InvCustCode ="";
            InvCurId =0;
            InvIsAdditExpences = 0;
            InvIsService = 0;
            InvDiscount = 0;
            InvQuotId = 0;
            InvIsPaid = 0;
            InvInAdvance = 0;
            InvLeftInAdvance = 0;
            InvAllowToInvoice = 0;
            InvIsActive = -1;
            InvSalesComments = "";
        }

        public static DataTable getInvoicePayments(int _id)
        {
            string query = "EXECUTE sp_SelectExInvoicePayments @invoiceid = " + _id;

            return Helper.QueryDT(query);
        }

        public void AddExInvoicePayment(int invoiceid, double paymentsum, string paymentdate)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddExInvoicePayments", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@invoiceid", invoiceid);
            sqlComm.Parameters.AddWithValue("@paymentsum", paymentsum);
            sqlComm.Parameters.AddWithValue("@paymentdate", paymentdate);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

        }

        public void AddExInvoicePaymentAll(int invoiceid, double paymentsum, string paymentdate)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddExInvoicePaymentsAll", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@invoiceid", invoiceid);
            sqlComm.Parameters.AddWithValue("@paymentsum", paymentsum);
            sqlComm.Parameters.AddWithValue("@paymentdate", paymentdate);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

        }

        public void EditExInvoicePayment(int id, double paymentsum, string paymentdate)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditExInvoicePayments", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@paymentsum", paymentsum);
            sqlComm.Parameters.AddWithValue("@paymentdate", paymentdate);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

        }

        public void DeleteExInvoicePayment(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteExInvoicePayments", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

        }

        #endregion

        #region Reports

        public static DataTable getSellingReports(int _custid, int _typeid, 
                                                    string _datefrom, string _datetill, 
                                                    int _countries, int _invtype)
        {
            string query = "sp_StockReportsSelling";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@countries",SqlDbType.Int){Value = _countries },
                new SqlParameter("@invtype",SqlDbType.Int){Value = _invtype }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getSellingReportsSum(int _custid, int _typeid, 
                                                    string _datefrom, string _datetill, 
                                                    int _countries, int _invtype)
        {
            string query = "sp_StockReportsSellingSum";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@countries",SqlDbType.Int){Value = _countries },
                new SqlParameter("@invtype",SqlDbType.Int){Value = _invtype }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getProfitReports(int _custid, int _typeid,
                                                    string _datefrom, string _datetill)
        {
            string query = "sp_SelectProfitReport";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

      

        #endregion

        #region Payments

        public int AddPaymentHeader(int buyerid, int @typeid, string regdate, double amount, double vat, int curid, double currate, string comments)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPaymentHeader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@buyerid", buyerid);
            sqlComm.Parameters.AddWithValue("@typeid", typeid);
            sqlComm.Parameters.AddWithValue("@regdate", regdate);
            sqlComm.Parameters.AddWithValue("@amount", amount);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@curid", curid);
            sqlComm.Parameters.AddWithValue("@currate", currate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
          
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }

        int _successid = 0;
        public int SuccessId
        {
            get { return _successid; }
            set { _successid = value; }
        }
        public string EditPaymentHeader(int id, string regdate, double amount, double vat, int curid, double currate, string comments)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditPaymentHeader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@regdate", regdate);
            sqlComm.Parameters.AddWithValue("@amount", amount);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@curid", curid);
            sqlComm.Parameters.AddWithValue("@currate", currate);
            sqlComm.Parameters.AddWithValue("@comments", comments);

            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@successid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            _successid = Convert.ToInt32(sqlComm.Parameters["@successid"].Value);
            sqlConn.Close();

            return _res;
        }

        public void AddPaymentDetails(int headid, int invoicedetid, string paydate, double amount)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPaymentDetails", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@paydate", paydate);
            sqlComm.Parameters.AddWithValue("@invoicedetid", invoicedetid);
            sqlComm.Parameters.AddWithValue("@amount", amount);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            
        }

        public void DeletePayment(int headid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteExInvoicePaymentsAll", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeletePaymentDetails(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePaymentDetails", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void EditPaymentDetails(int id, double amount, string paydate)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditPaymentDetails", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@amount", amount);
            sqlComm.Parameters.AddWithValue("@paydate", paydate);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void ReleasePaymentDetails(int headid, int coid, int curid, double amount, int quotid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReleasePaymentDetails", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@quotid", quotid);
            sqlComm.Parameters.AddWithValue("@curid", curid);
            sqlComm.Parameters.AddWithValue("@amount", amount);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void ReleasePaymentDetailsCur(int headid, int coid, int curid, double amount, int quotid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ReleasePaymentDetailsCur", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@quotid", quotid);
            sqlComm.Parameters.AddWithValue("@curid", curid);
            sqlComm.Parameters.AddWithValue("@amount", amount);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void RelinkPaymentDetails(int headid, int coid, int curid, double amount, int payall, int quotid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_RelinkPaymentDetails", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@quotid", quotid);
            sqlComm.Parameters.AddWithValue("@curid", curid);
            sqlComm.Parameters.AddWithValue("@amount", amount);
            sqlComm.Parameters.AddWithValue("@payall", payall);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void RelinkPaymentDetailsCur(int headid, int coid, int curid, double amount, int quotid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_RelinkPaymentDetailsCur", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@quotid", quotid);
            sqlComm.Parameters.AddWithValue("@curid", curid);
            sqlComm.Parameters.AddWithValue("@amount", amount);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public static DataTable getCOPayments(int _id, int _quotid)
        {
            string query = "EXECUTE sp_SelectCOPayments @id = " + _id + ", @quotid = " + _quotid;

            return Helper.QueryDT(query);
        }

        public static DataTable getPayments(string _datefrom, string _datetill, int _buyerid)
        {
            string query = "sp_PaymentsList";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@buyerid",SqlDbType.Int){Value = _buyerid},
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getPaymentDets(int _headid, int _coid)
        {
            string query = "sp_SelectPaymentDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@headid",SqlDbType.Int){Value = _headid},
                new SqlParameter("@coid",SqlDbType.Int){Value = _coid}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getPaymentNotPaidDets(int _buyerid, int _invoicetype)
        {
            string query = "sp_SelectPaymentNotPaidDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@buyerid",SqlDbType.Int){Value = _buyerid},
                new SqlParameter("@invtype",SqlDbType.Int){Value = _invoicetype}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getPaymentsByOrders(string _datefrom, string _datetill, int _buyerid)
        {
            string query = "sp_PaymentsListByOrders";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@buyerid",SqlDbType.Int){Value = _buyerid},
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getNotPaidInvoice(int _buyerid, int _invoicetype)
        {
            string query = "sp_PaymentsListNotPaidInvoices";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@buyerid",SqlDbType.Int){Value = _buyerid},
                new SqlParameter("@invtype",SqlDbType.Int){Value = _invoicetype}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getPaidOrders(int _custid)
        {
            string query = "sp_PaymentsListByOrdersRelink";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getPaidOrdersCur(int _custid, int _curid)
        {
            string query = "sp_PaymentsListByOrdersRelinkCur";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid},
                new SqlParameter("@curid",SqlDbType.Int){Value = _curid}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        #endregion
    }

}
