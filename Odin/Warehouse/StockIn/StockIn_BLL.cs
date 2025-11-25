using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.StockIn
{
    public class StockIn_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getStockIncomes(int _headid, int _typeid, int _supid, int _state, int _artid, string _article,
                                                    string _datefrom, string _datetill, string _firmart, string _comments,
                                                    int _opertypeid)
        {
            string query = "sp_StockIncomesPortfolio";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@headid",SqlDbType.Int){Value = _headid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@supid",SqlDbType.Int){Value = _supid },
                new SqlParameter("@state",SqlDbType.Int){Value = _state },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@firmart",SqlDbType.NVarChar){Value = _firmart},
                new SqlParameter("@comments",SqlDbType.NVarChar){Value = _comments},
                new SqlParameter("@opertypeid",SqlDbType.Int){Value = _opertypeid}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInDets(int _inheadid)
        {
            string query = "sp_SelectStockInDetsAll";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _inheadid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockRests(int _artid)
        {
            string query = "sp_StockRestForArticleByPlaces";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid }

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int AddStockIn(int headid, int artid, string suparticle, int type, double qty, int unitid, string comments, 
                            double unitprice, double discount, double vat, double coefconv, double weight, int custcodeid,
                            int batchid, int state, int poid, int producer, string datacode, double dutycost, double total, 
                            double totalvat, int blockdelivery)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockInLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@suparticle", suparticle);
            sqlComm.Parameters.AddWithValue("@type", type);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@discount", discount);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@coefconv", coefconv);
            sqlComm.Parameters.AddWithValue("@weight", weight);
            sqlComm.Parameters.AddWithValue("@custcodeid", custcodeid);
            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@state", state);
            sqlComm.Parameters.AddWithValue("@poid", poid);
            sqlComm.Parameters.AddWithValue("@producer", producer);
            sqlComm.Parameters.AddWithValue("@datacode", datacode);
            sqlComm.Parameters.AddWithValue("@dutycost", dutycost);
            sqlComm.Parameters.AddWithValue("@total", total);
            sqlComm.Parameters.AddWithValue("@totalvat", totalvat);
            sqlComm.Parameters.AddWithValue("@blockdelivery", blockdelivery);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }

        public int AddStockDeallocation(int idin, int label, int artid, int placeid, double qty, string expdate,
                            int suplabelid, int usage, string comments, string datacode, string manufbatch)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockDeallocation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@idin", idin);
            sqlComm.Parameters.AddWithValue("@label", label);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@placeid", placeid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@expdate", expdate);
            sqlComm.Parameters.AddWithValue("@usage", usage);
            sqlComm.Parameters.AddWithValue("@suplabelid", suplabelid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@datacode", datacode);
            sqlComm.Parameters.AddWithValue("@manufbatch", manufbatch);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }

        public void SetNoExpDate(int label)
        {
           

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SetNoExpDate", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@label", label);
          
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public int EditStockIn(int id, int headid, int artid, string suparticle, int type, double qty, int unitid, string comments,
                            double unitprice, double discount, double vat, double coefconv, double weight, int custcodeid,
                            int batchid, int producer, string datacode, double dutycost, double total, double totalvat,
                            int blockdelivery)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditStockInLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;


            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@suparticle", suparticle);
            sqlComm.Parameters.AddWithValue("@type", type);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@discount", discount);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@coefconv", coefconv);
            sqlComm.Parameters.AddWithValue("@weight", weight);
            sqlComm.Parameters.AddWithValue("@custcodeid", custcodeid);
            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@producer", producer);
            sqlComm.Parameters.AddWithValue("@datacode", datacode);
            sqlComm.Parameters.AddWithValue("@dutycost", dutycost);
            sqlComm.Parameters.AddWithValue("@total", total);
            sqlComm.Parameters.AddWithValue("@totalvat", totalvat);
            sqlComm.Parameters.AddWithValue("@blockdelivery", blockdelivery);


            sqlComm.Parameters.Add("@success", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@success"].Value);
            sqlConn.Close();

            return _res;

        }

        public int AddStockPOLink(int poid, int idin, double qty)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockINPOLink", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@poid", poid);
            sqlComm.Parameters.AddWithValue("@idin", idin);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

            return _res;
        }

        public int DeleteStockPOLink(int id, int poid)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockINPOLink", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@poid", poid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

            return _res;
        }

        public int EditStockPOLink(int id, double qty)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditStockINPOLink", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@qty", qty);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

            return _res;
        }

        public int DeleteStockInLine(int id)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockInLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@result"].Value);
            sqlConn.Close();

            return _res;
        }

        public static DataTable getStockNotPlaced(int _artid, int _headid)
        {
            string query = "sp_StockNotPlacedIncomes";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@headid",SqlDbType.Int){Value = _headid }
                

            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInPOs(int _idin)
        {
            string query = "sp_SelectStockInPODets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@idin",SqlDbType.Int){Value = _idin }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInComponents(int _idin)
        {
            string query = "sp_SelectStockInComponents";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@idin",SqlDbType.Int){Value = _idin }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockIncomeRests(int _id)
        {
            string query = "sp_SelectStockIncomeRests";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@idin",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockServices()
        {
            string query = "sp_SelectStockServicesRests";

            var sqlparams = new List<SqlParameter>
            {
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInFromPO(int _poid)
        {
            string query = "sp_SelectStockFromPORests";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@poid",SqlDbType.Int){Value = _poid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        int _idin = 0;

        public int HeadId
        { get; set; }
        public int ArtId
        { get; set; }
        public string SupArticle
        { get; set; }
        public int TypeInId
        { get; set; }
        public double Qty
        { get; set; }
        public int UnitId
        { get; set; }
        public string Comments
        { get; set; }
        public double UnitPrice
        { get; set; }
        public double Discount
        { get; set; }
        public double VAT
        { get; set; }
        public double CoefConv
        { get; set; }
        public double Weight
        { get; set; }
        public int CustCodeId
        { get; set; }
        public int BatchId
        { get; set; }
        public int WasMovewment
        { get; set; }
        public int State
        { get; set; }
        public int SenderCountryId
        { get; set; }
        public int ProducerCountryId
        { get; set; }
        public string DataCode
        { get; set; }
        public double Dutycost
        { get; set; }
        public double Total
        { get; set; }
        public int BlockDelivery
        { get; set; }

        public int IdIn
        {
            get { return _idin; }
            set { _idin = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectStockInDets @id = " + _idin, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        HeadId = Convert.ToInt32(dr["headid"]);
                        ArtId = Convert.ToInt32(dr["artid"]);
                        SupArticle = dr["suparticle"].ToString();
                        TypeInId = Convert.ToInt32(dr["typeinid"]);
                        Qty = Convert.ToDouble(dr["qty"]);
                        UnitId = Convert.ToInt32(dr["unitid"]);
                        Comments = dr["comments"].ToString();
                        UnitPrice = Convert.ToDouble(dr["unitprice"]);
                        Discount = Convert.ToDouble(dr["discount"]);
                        VAT = Convert.ToDouble(dr["vat"]);
                        CoefConv = Convert.ToDouble(dr["coefconv"]);
                        Weight = Convert.ToDouble(dr["weight"]);
                        CustCodeId = Convert.ToInt32(dr["custcodeid"]);
                        BatchId = Convert.ToInt32(dr["batchid"]);
                        WasMovewment = Convert.ToInt32(dr["wasmovement"]);
                        State = Convert.ToInt32(dr["state"]);
                        SenderCountryId = Convert.ToInt32(dr["sendercountryid"]);
                        ProducerCountryId = Convert.ToInt32(dr["producercountryid"]);
                        DataCode = dr["datacode"].ToString();
                        Dutycost = Convert.ToDouble(dr["dutycost"]);
                        Total = Convert.ToDouble(dr["total"]) != 0 ? Convert.ToDouble(dr["total"]) : UnitPrice * Qty;
                        BlockDelivery = Convert.ToInt32(dr["blockdelivery"]);
                    }
                }
                else
                {
                    ClearFields();
                }

            }
        }

        public void ClearFields()
        {
            HeadId = 0;
            ArtId = 0;
            SupArticle = "";
            TypeInId = 0;
            Qty = 0;
            UnitId = 0;
            Comments = "";
            UnitPrice = 0;
            Discount = 0;
            VAT = 0;
            CoefConv = 0;
            Weight = 0;
            CustCodeId = 0;
            BatchId = 0;
            WasMovewment = 0;
            State = 0;
            SenderCountryId = 0;
            ProducerCountryId = 0;
            DataCode = "";
            Dutycost = 0;
            BlockDelivery = 0;
        }


        #region Batches Stock in
        int _bidin = 0;

        public int BIdIn
        {
            get { return _bidin; }
            set
            {
                _bidin = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectBatchStockInHead @id = " + _bidin, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        BArtId = Convert.ToInt32(dr["artid"]);
                        BCustArticle = dr["custarticle"].ToString();
                        BSecArticle = dr["secname"].ToString();
                        BQty = Math.Round(Convert.ToDouble(dr["qty"]), 5);
                        BQtyLeft = Math.Round(Convert.ToDouble(dr["qty"]) - Convert.ToDouble(dr["qtyin"]), 5);
                        BQtyIn = Math.Round(Convert.ToDouble(dr["qtyin"]), 5);
                        BUnit = dr["unit"].ToString();
                        BDelivPlace = dr["deliveryplace"].ToString();
                        BUnitPrice = Convert.ToDouble(dr["unitprice"]);
                        BCOid = Convert.ToInt32(dr["coid"]);
                        BConfOrder = dr["conforder"].ToString();
                        BCountCO = Convert.ToInt32(dr["countco"]);
                    }
                }
                else
                {
                    ClearBatchIn();
                }

            }
        }

        public int BArtId
        { get; set; }

        public string BCustArticle
        { get; set; }
        public string BSecArticle
        { get; set; }
        public string BDelivPlace
        { get; set; }
        public double BQty
        { get; set; }
        public double BQtyLeft
        { get; set; }
        public double BUnitPrice
        { get; set; }
        public string BUnit
        { get; set; }
        public int BCOid
        { get; set; }
        public string BConfOrder
        { get; set; }
        public double BQtyIn
        { get; set; }
        public int BCountCO
        { get; set; }

        public void ClearBatchIn()
        {
            BArtId = 0;
            BCustArticle = "";
            BSecArticle = "";
            BDelivPlace = "";
            BQty = 0;
            BQtyLeft = 0;
            BUnitPrice = 0;
            BUnit = "";
            BCOid = 0;
            BConfOrder = "";
            BQtyIn = 0;
            BCountCO = 0;
        }

        public static DataTable getStockInBatch(int _id)
        {
            string query = "sp_SelectBatchStockInDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInBatchDelivery(int _id)
        {
            string query = "sp_SelectBatchDeliveryRests";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInArticleDelivery(int _id)
        {
            string query = "sp_SelectArticleDeliveryRests";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInArticleDeliveryEdit(int _id)
        {
            string query = "sp_SelectArticleDeliveryRestsNewForEdit";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockInBatchRMDets(int _id)
        {
            string query = "sp_SelectBatchStockInRMRests";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int InsertedId = 0;

        public string AddStockInFP(int artid, double qty, double unitprice, int batchid, int placeid, string comments, DataTable tablebox, int coid)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockInFP", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@placeid", placeid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            //sqlComm.Parameters.AddWithValue("@packid", packid);
            sqlComm.Parameters.Add("@tableboxes", SqlDbType.Structured);
            sqlComm.Parameters["@tableboxes"].TypeName = "UT_IDs";
            sqlComm.Parameters["@tableboxes"].Value = tablebox;
            sqlComm.Parameters.AddWithValue("@_coid", coid);

            sqlComm.Parameters.Add("@docname", SqlDbType.NVarChar, 25).Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@docname"].Value.ToString();
            InsertedId = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }

        public void AddServiceCost(int id, int serviceid, double unitprice)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockInServiceCost", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@serviceid", serviceid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }
        #endregion

        #region Boxes Stock In

        public string AddedBox
        { get; set; }

        public int AddStockInBoxHeader(int batchid, int coid, string package, double qty, double weightbrut, string comments, int boxno, int closed, int place)
        {
            int _res = 0;
            
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockInBoxHeader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@package", package);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@weightbrut", weightbrut);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@boxno", boxno);
            sqlComm.Parameters.AddWithValue("@closed", closed);
            sqlComm.Parameters.AddWithValue("@place", place);
            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
                       
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);

            AddedBox = _res != 0 ? package : "";

            sqlConn.Close();

            return _res;
        }

        public void EditStockInBoxHeader(int id, string package, double qty, double weightbrut, string comments, int boxno, int closed, int place)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditStockInBoxHeader", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@package", package);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@weightbrut", weightbrut);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@boxno", boxno);
            sqlComm.Parameters.AddWithValue("@closed", closed);
            sqlComm.Parameters.AddWithValue("@place", place);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();            
        }

        public void AddStockInBoxAdditContent(int id, string label, double qty)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockInBoxAdditContent", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@label", label);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void AddStockInBoxDets(int packid, DataTable dataserials)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddStockInBoxDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@packid", packid);
            sqlComm.Parameters.Add("@tableserials", SqlDbType.Structured);
            sqlComm.Parameters["@tableserials"].TypeName = "UT_Serials";
            sqlComm.Parameters["@tableserials"].Value = dataserials;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteStockInBoxDets(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockInBoxDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteStockInBoxAddDets(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockInBoxAddDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteStockInBox(int packid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockInBox", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@packid", packid);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public static DataTable getBoxesNotPlaced()
        {
            string query = "sp_SelectBoxesNotPlaced";

            var sqlparams = new List<SqlParameter>
            {
                
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getBatchBoxesNotMapped(int _idin)
        {
            string query = "sp_SelectBoxesNotMapped";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@idin",SqlDbType.Int){Value = _idin }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getBoxesContent(int packid)
        {
            string query = "sp_SelectBatchBoxContent";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@packid",SqlDbType.Int){Value = packid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public void MapStockInBox(int inid, int packid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_MapStockInBox", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@inid", inid);
            sqlComm.Parameters.AddWithValue("@packid", packid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            
        }

        public static DataTable getBatchCONotIn(int _batchid)
        {
            string query = "sp_SelectCOsNotIn";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        #endregion
    }
}
