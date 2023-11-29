using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Purchase
{
    public class PO_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getPurchaseOrders(int _headid, int _typeid, int _supid, int _stateid, int _artid, string _article,
                                                    string _datefrom, string _datetill, string _suporder, string _comments,
                                                    string _reqdatefrom, string _reqdatetill, string _confbefore)
        {
            string query = "sp_PurchasePortfolio";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@poid",SqlDbType.Int){Value = _headid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@stateid",SqlDbType.Int){Value = _stateid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@suporder",SqlDbType.NVarChar){Value = _suporder},
                new SqlParameter("@comments",SqlDbType.NVarChar){Value = _comments },
                new SqlParameter("@reqdatefrom",SqlDbType.NVarChar){Value = _reqdatefrom},
                new SqlParameter("@reqdatetill",SqlDbType.NVarChar){Value = _reqdatetill},
                new SqlParameter("@confbefore",SqlDbType.NVarChar){Value = _confbefore}

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }


        #region Header

        public int AddPurchaseOrderHead(int SupId, int ContPersonId, string Comments, string Contract, int CurId,
                                        int IncotermId, int DelivPlaceId, int DelivAddressId, int InProcess)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPurchaseOrderHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@SupId", SupId);
            sqlComm.Parameters.AddWithValue("@ContPersonId", ContPersonId);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@Contract", Contract);
            sqlComm.Parameters.AddWithValue("@CurId", CurId);
            sqlComm.Parameters.AddWithValue("@IncotermId", IncotermId);
            sqlComm.Parameters.AddWithValue("@DelivPlaceId", DelivPlaceId);
            sqlComm.Parameters.AddWithValue("@DelivAddressId", DelivAddressId);
            sqlComm.Parameters.AddWithValue("@InProcess", InProcess);

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

        public void EditPurchaseOrderHead(int Id, int SupId, int ContPersonId, string Comments, string Contract, int CurId,
                                            int IncotermId, int DelivPlaceId, int DelivAddressId, int InProcess)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditPurchaseOrderHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlComm.Parameters.AddWithValue("@SupId", SupId);
            sqlComm.Parameters.AddWithValue("@ContPersonId", ContPersonId);
            sqlComm.Parameters.AddWithValue("@Comments", Comments);
            sqlComm.Parameters.AddWithValue("@Contract", Contract);
            sqlComm.Parameters.AddWithValue("@CurId", CurId);
            sqlComm.Parameters.AddWithValue("@IncotermId", IncotermId);
            sqlComm.Parameters.AddWithValue("@DelivPlaceId", DelivPlaceId);
            sqlComm.Parameters.AddWithValue("@DelivAddressId", DelivAddressId);
            sqlComm.Parameters.AddWithValue("@InProcess", InProcess);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        public void DeletePurchaseOrderHead(int Id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePurchaseOrderHead", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@Id", Id);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch { }
        }

        int _poheadid = 0;

        public string POHeader
        { get; set; }
        public int POHeadSupId
        { get; set; }
        public int POHeadContPersId
        { get; set; }
        public string POHeadComments
        { get; set; }
        public string POHeadCreatAt
        { get; set; }
        public string POHeadCreatBy
        { get; set; }
        public string POHeadContract
        { get; set; }
        public int POHeadCurId
        { get; set; }
        public int POHeadIncoterms
        { get; set; }
        public int POHeadDelivPlaceId
        { get; set; }
        public int POHeadDelivAddressId
        { get; set; }
        public int POHeadSupplierCountry
        { get; set; }
        public string POHeadSupplier
        { get; set; }
        public string POHeadSupplierVAT
        { get; set; }
        public string POHeadSupAddress
        { get; set; }
        public string POHeadSupContPerson
        { get; set; }
        public string POHeadSupContPersPhone
        { get; set; }
        public string POHeadSupContPersFax
        { get; set; }
        public string POHeadSupContPersMail
        { get; set; }
        public string POHeadReceiver
        { get; set; }
        public string POHeadReceiverVAT
        { get; set; }
        public string POHeadRecAddress
        { get; set; }
        public string POHeadRecContPerson
        { get; set; }
        public string POHeadRecContPersPhone
        { get; set; }
        public string POHeadRecContPersFax
        { get; set; }
        public string POHeadRecContPersMail
        { get; set; }
        public string POHeadCurrency
        { get; set; }
        public string POHeadPayments
        { get; set; }
        public string POHeadIncotermsStr
        { get; set; }
        public int POHeadProcessing
        {
            get;
            set;
        }
        public string POHeadSupplierCountryISO
        { get; set; }
        public int POHeadId
        {
            get { return _poheadid; }
            set
            {
                _poheadid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectPOHeader @id = " + _poheadid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        POHeader = dr["name"].ToString();
                        POHeadSupId = Convert.ToInt32(dr["supid"]);
                        POHeadContPersId = Convert.ToInt32(dr["contpersid"]);
                        POHeadCreatAt = dr["when"].ToString();
                        POHeadCreatBy = dr["userlogin"].ToString();
                        POHeadComments = dr["comments"].ToString();
                        POHeadContract = dr["contract"].ToString();
                        POHeadCurId = Convert.ToInt32(dr["curid"]);
                        POHeadIncoterms = Convert.ToInt32(dr["incotermid"]);
                        POHeadDelivPlaceId = Convert.ToInt32(dr["delivplaceid"]);
                        POHeadDelivAddressId = Convert.ToInt32(dr["delivaddressid"]);
                        POHeadSupplierCountry = Convert.ToInt32(dr["supcountryid"]);
                        POHeadSupplier = dr["supplier"].ToString();
                        POHeadSupplierVAT = dr["suppliervat"].ToString();
                        POHeadSupAddress = dr["supaddress"].ToString();
                        POHeadSupContPerson = dr["supcontperson"].ToString();
                        POHeadSupContPersPhone = dr["supcontpersphone"].ToString();
                        POHeadSupContPersFax = dr["supcontpersfax"].ToString();
                        POHeadSupContPersMail = dr["supcontpersmail"].ToString();
                        POHeadReceiver = dr["receiver"].ToString();
                        POHeadReceiverVAT = dr["receivervat"].ToString();
                        POHeadRecAddress = dr["recaddress"].ToString();
                        POHeadRecContPerson = dr["reccontperson"].ToString();
                        POHeadRecContPersPhone = dr["reccontpersphone"].ToString();
                        POHeadRecContPersFax = dr["reccontpersfax"].ToString();
                        POHeadRecContPersMail = dr["reccontpersmail"].ToString();
                        POHeadCurrency = dr["currency"].ToString();
                        POHeadPayments = dr["payment"].ToString();
                        POHeadIncotermsStr = dr["incoterms"].ToString();
                        POHeadProcessing = Convert.ToInt32(dr["inprocess"]);
                        POHeadSupplierCountryISO = dr["countryiso"].ToString();
                    }
                }
                else
                {
                    ClearPOHead();
                }
            }
        }
        public void ClearPOHead()
        {
            POHeader = "";
            POHeadSupId = 0;
            POHeadContPersId = 0;
            POHeadCreatAt = "";
            POHeadCreatBy = "";
            POHeadComments = "";
            POHeadContract = "";
            POHeadCurId = 0;
            POHeadIncoterms = 0;
            POHeadDelivPlaceId = 0;
            POHeadDelivAddressId = 0;
            POHeadSupplierCountry = 0;
            POHeadSupplier = "";
            POHeadSupAddress = "";
            POHeadSupContPerson = "";
            POHeadSupContPersPhone = "";
            POHeadSupContPersFax = "";
            POHeadSupContPersMail = "";
            POHeadReceiver = "";
            POHeadRecAddress = "";
            POHeadRecContPerson = "";
            POHeadRecContPersPhone = "";
            POHeadRecContPersFax = "";
            POHeadRecContPersMail = "";
            POHeadCurrency = "";
            POHeadPayments = "";
            POHeadSupplierVAT = "";
            POHeadReceiverVAT = "";
            POHeadIncotermsStr = "";
            POHeadProcessing = 0;
            POHeadSupplierCountryISO = "";
        }

        #endregion

        #region Details

        int _poid = 0;

        public int LastPOLine(int poheadid)
        {
            int _res = 0;

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 line FROM pur_dets WHERE headid = " + poheadid.ToString() + " order by line desc", conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _res = Convert.ToInt32(dr["line"]);
                }
            }
            else
            {
                _res = 0;
            }

            return _res;
        }

        public int POId
        {
            get { return _poid; }
            set
            {
                _poid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectPODets @id = " + _poid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        POName = dr["name"].ToString();
                        POArtId = Convert.ToInt32(dr["artid"]);
                        POComments = dr["comments"].ToString();
                        POCreatAt = dr["createdat"].ToString();
                        POCreatBy = dr["createdby"].ToString();
                        POSupArticle = dr["suparticle"].ToString();
                        POSupOrder = dr["suporder"].ToString();
                        POLine = Convert.ToInt32(dr["line"]);
                        POQty = Convert.ToDouble(dr["qty"]);
                        POQtyLeft = Convert.ToDouble(dr["qtyleft"]);
                        POReqDate = dr["reqdate"].ToString();
                        POMinExpDate = dr["minexpdate"].ToString();
                        POStateId = Convert.ToInt32(dr["stateid"]);
                        POUnitId = Convert.ToInt32(dr["unitid"]);
                        POUnitPrice = Convert.ToDouble(dr["unitprice"]);
                        POVat = Convert.ToDouble(dr["vat"]);
                        PODiscount = Convert.ToDouble(dr["discount"]);
                        POHeadId1 = Convert.ToInt32(dr["headid"]);
                        POCatalogId = Convert.ToInt32(dr["catalogid"]);
                        POCoefConv = Convert.ToDouble(dr["coefconv"]);
                        PODBUnitId = Convert.ToInt32(dr["dbunitid"]);
                        POResale = Convert.ToInt32(dr["resale"]);
                        POProjectId = Convert.ToInt32(dr["projectid"]);
                        POInternalComments = dr["internalcomments"].ToString();
                        POEndCustomer = dr["endcustomer"].ToString();
                    }
                }
                else
                {
                    ClearPODets();
                }
            }
        }

        public string POName
        { get; set; }
        public int POArtId
        { get; set; }
        public string POComments
        { get; set; }
        public string POCreatAt
        { get; set; }
        public string POCreatBy
        { get; set; }
        public string POSupArticle
        { get; set; }
        public string POSupOrder
        { get; set; }
        public int POLine
        { get; set; }
        public double POQty
        { get; set; }
        public double POQtyLeft
        { get; set; }
        public string POReqDate
        { get; set; }
        public string POMinExpDate
        { get; set; }
        public int POStateId
        { get; set; }
        public int POUnitId
        { get; set; }
        public int PODBUnitId;
        public double POUnitPrice
        { get; set; }
        public double POVat
        { get; set; }
        public double PODiscount
        { get; set; }
        public int POHeadId1
        { get; set; }
        public int POCatalogId
        { get; set; }
        public double POCoefConv
        { get; set; }
        public int POResale
        { get; set; }

        public int POProjectId
        { get; set; }
        public string POInternalComments
        { get; set; }
        public string POEndCustomer
        { get; set; }
        public void ClearPODets()
        {
            POName = "";
            POArtId = 0;
            POComments = string.Empty;
            POCreatAt = string.Empty;
            POCreatBy = string.Empty;
            POSupArticle = string.Empty;
            POLine = 0;
            POQty = 0;
            POReqDate = string.Empty;
            POMinExpDate = string.Empty;
            POStateId = 0;
            POUnitId = 0;
            POUnitPrice = 0;
            POVat = 0;
            PODiscount = 0;
            POHeadId1 = 0;
            POCatalogId = 0;
            POCoefConv = 0;
            PODBUnitId = 0;
            POQtyLeft = 0;
            POResale = 0;
            POProjectId = 0;
            POInternalComments = "";
            POEndCustomer = "";
        }

        public int SavePOLine(int id, int headid, int line, int artid, double qty, int unitid, double unitprice, double vat,
                            double discount, string reqdate, string comments, int stateid, int catalogid, double coefconv,
                            string bestbefore, string suporder, string suparticle, int resale, int projectid, string internalcomments)
        {
            int _res = 0;


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SavePODets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@line", line);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@discount", discount);
            sqlComm.Parameters.AddWithValue("@reqdate", reqdate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@stateid", stateid);
            sqlComm.Parameters.AddWithValue("@catalogid", catalogid);
            sqlComm.Parameters.AddWithValue("@coefconv", coefconv);
            sqlComm.Parameters.AddWithValue("@bestbefore", bestbefore);
            sqlComm.Parameters.AddWithValue("@suporder", suporder);
            sqlComm.Parameters.AddWithValue("@suparticle", suparticle);
            sqlComm.Parameters.AddWithValue("@resale", resale);
            sqlComm.Parameters.AddWithValue("@projectid", projectid);
            sqlComm.Parameters.AddWithValue("@internalcomments", internalcomments);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();



            return _res;
        }

        public void SavePOLineFromNeeds(int needid, double qty, int catalogid)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SavePODetsFromNeeds", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@needid", needid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@catalogid", catalogid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public string DeletePOLine(int id)
        {
            string _res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePODets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public void CancelAllLines(int headid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_CancelPO", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void MapPONeeds(int poid, int needid, int typeneed, double qty, string comments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPONeedsMapping", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@poid", poid);
            sqlComm.Parameters.AddWithValue("@needid", needid);
            sqlComm.Parameters.AddWithValue("@typeneed", typeneed);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@comments", comments);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void AddPONotificationBatch(int poid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBatchNotificationPO", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@poid", poid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }


        public void DeletePONeedsMaps(int poid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePONeedsMapping", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@poid", poid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }


        #endregion

        #region Printing

        public static DataTable getPODets(int _id)
        {
            string query = "sp_SelectPODetsPrint";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region Confirmations

        public static DataTable getPOConfirmations(int _poid)
        {
            string query = "EXECUTE sp_SelectPOConfirmations @poid = " + _poid;

            return Helper.QueryDT(query);
        }

        int _confid = 0;

        public int ConfId
        {
            get { return _confid; }
            set
            {
                _confid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectPOConfDets @id = " + _confid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        ConfComments = dr["comments"].ToString();
                        ConfCreatAt = dr["createdat"].ToString();
                        ConfCreatBy = dr["createdby"].ToString();
                        ConfPOId = Convert.ToInt32(dr["poid"]);
                        ConfDate = dr["confirmdate"].ToString();
                        ConfQty = Convert.ToDouble(dr["confirmqty"]);
                        ConfType = dr["conftype"].ToString();

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
        public string ConfCreatBy
        { get; set; }
        public int ConfPOId
        { get; set; }
        public string ConfDate
        { get; set; }
        public double ConfQty
        { get; set; }
        public string ConfType
        { get; set; }


        public void ClearConfDets()
        {
            ConfComments = "";
            ConfCreatAt = "";
            ConfCreatBy = "";
            ConfPOId = 0;
            ConfDate = "";
            ConfQty = 0;
            ConfType = "";
        }

        public int AddPOConfirmation(int poid, double qty, string confdate, string comments, string conftype)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPOConfirm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@poid", poid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@confdate", confdate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@conftype", conftype);


            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();


            return _res;
        }

        public void AddPOConfirmationAll(int poid, string confdate, string conftype)
        {


            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPOConfirmAll", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@poid", poid);
            sqlComm.Parameters.AddWithValue("@confdate", confdate);
            sqlComm.Parameters.AddWithValue("@conftype", conftype);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void EditPOConfirmation(int id, int poid, double qty, string confdate, string comments, string conftype)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditPOConfirm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@poid", poid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@confdate", confdate);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@conftype", conftype);


            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

        }

        public void DeletePOConfirmation(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePOConfirm", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();

        }

        #endregion

        #region Deliveries

        public static DataTable getDeliveries(int _id)
        {
            string query = "EXECUTE sp_SelectPODeliveries @id = " + _id;

            return Helper.QueryDT(query);
        }

        #endregion

        #region History

        public static DataTable getHistoryOrders(int _id)
        {
            string query = "EXECUTE sp_SelectPOHistory @poid = " + _id;

            return Helper.QueryDT(query);
        }

        #endregion

        #region Processing

        public static DataTable getNeedsHeaders(int _batchid, int _isactive)
        {
            string query = "sp_SelectNeedsProcessHeaders";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@isactive",SqlDbType.Int){Value = _isactive }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }


        public static DataTable getArtTotalsListRMForAdding(int _typeid, int _deptid, int _batchid, int _stageid)
        {
            string query = "sp_SelectArtTotalsListForAdding";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@deptid",SqlDbType.Int){Value = _deptid },
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid },
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getArtTotalsListRMForAddingBatches(DataTable tablebatches, int _stageid)
        {
            string query = "sp_SelectArtTotalsListForAddingBatches";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@tablebatches", SqlDbType.Structured) { TypeName = "UT_IDs", Value = tablebatches},
                new SqlParameter("@stageid",SqlDbType.Int){Value = _stageid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getActiveBatches()
        {
            string query = "sp_SelectActiveBatches";

            var sqlparams = new List<SqlParameter>
            {

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public void AddNewNeeds(int batchid, string comments, DataTable data)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPONeedsForProcess", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.Add("@tableart", SqlDbType.Structured);
            sqlComm.Parameters["@tableart"].TypeName = "UT_ArtQty";
            sqlComm.Parameters["@tableart"].Value = data;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void AddNewNeedsBatches(string comments, DataTable databatches, DataTable data)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPONeedsForProcessBatches", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.Add("@tablebatches", SqlDbType.Structured);
            sqlComm.Parameters["@tablebatches"].TypeName = "UT_IDs";
            sqlComm.Parameters["@tablebatches"].Value = databatches;
            sqlComm.Parameters.Add("@tableart", SqlDbType.Structured);
            sqlComm.Parameters["@tableart"].TypeName = "UT_ArtQty";
            sqlComm.Parameters["@tableart"].Value = data;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void AddNewNeedDet(int headid, int artid, double qty)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddPONeedsDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@qty", qty);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public int EditNeedDets(int id, double qty, string comments)
        {
            int _state = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditPONeedsDet", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.Add("@state", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _state = Convert.ToInt32(sqlComm.Parameters["@state"].Value);
            sqlConn.Close();
            return _state;
        }

        public static DataTable getNeedsDetails(int _needid)
        {
            string query = "sp_SelectNeedsProcessDetails";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _needid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getNeedsDetailsCat(int _needid)
        {
            string query = "sp_SelectNeedsProcessDetailsCat";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _needid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }
        public static DataTable getNeedsDetailsCatDet(int _needid)
        {
            string query = "sp_SelectNeedsProcessDetailsCatDet";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _needid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getNeedsPOs(int _needid)
        {
            string query = "sp_SelectNeedsPODetails";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@needid",SqlDbType.Int){Value = _needid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public static DataTable getNeedsForArticle(int _artid)
        {
            string query = "sp_SelectNeedsForArticle";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());

        }

        public string DeletePONeedLine(int id)
        {
            string _res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePONeedDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public string DeletePONeed(int id)
        {
            string _res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeletePONeed", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public string ClosePONeed(int id)
        {
            string _res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ClosePONeed", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public void EditPONeedComments(int id, string comments)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("update pur_needsheader set comments = @comments where id = @id ", sqlConn);
            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@comments", comments);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        #endregion
    }
}
