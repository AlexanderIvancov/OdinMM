using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Odin.Global_Classes;

namespace Odin.Warehouse.Deliveries
{
    public class DelivNote_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public static DataTable getDeliveries(int _headid, int _typeid, int _custid, int _artid, string _article,
                                                    string _datefrom, string _datetill, string _custart, 
                                                    string _comments, string _conforder, string _custorder, int _batchid)
        {
            string query = "sp_DeliveriesPortfolio";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@headid",SqlDbType.Int){Value = _headid },
                new SqlParameter("@typeid",SqlDbType.Int){Value = _typeid },
                new SqlParameter("@custid",SqlDbType.Int){Value = _custid },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = _article },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _datefrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _datetill},
                new SqlParameter("@custart",SqlDbType.NVarChar){Value = _custart},
                new SqlParameter("@comments",SqlDbType.NVarChar){Value = _comments},
                new SqlParameter("@conforder",SqlDbType.NVarChar){Value = _conforder},
                new SqlParameter("@custorder",SqlDbType.NVarChar){Value = _custorder},
                new SqlParameter("@batchid",SqlDbType.Int){Value = _batchid}
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getStockBatch(int _id, int _artid)
        {
            string query = "sp_SelectBatchStockDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@batchid",SqlDbType.Int){Value = _id },
                new SqlParameter("@artid",SqlDbType.Int){Value = _artid }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int AddDeliveryLine(int headid, int artid, int coid, string custarticle,
                                    double qty, double coefconv, int unitid, double unitprice,
                                    string comments, double netweight, double brutweight,
                                    string custcode, int qtypack, string package, DataTable stockoutdata,
                                    int isreturn)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDeliveryDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@custarticle", custarticle);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@coefconv", coefconv);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@netweight", netweight);
            sqlComm.Parameters.AddWithValue("@brutweight", brutweight);
            sqlComm.Parameters.AddWithValue("@custcode", custcode);
            sqlComm.Parameters.AddWithValue("@qtypack", qtypack);
            sqlComm.Parameters.AddWithValue("@package", package);
            sqlComm.Parameters.AddWithValue("@isreturn", isreturn);

            sqlComm.Parameters.Add("@tableout", SqlDbType.Structured);
            sqlComm.Parameters["@tableout"].TypeName = "UT_OutTable";
            sqlComm.Parameters["@tableout"].Value = stockoutdata;

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }
        public int AddDeliveryLineInternal(int id)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDeliveryDetsInternal", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlComm.Parameters.Add("@insertedinid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedinid"].Value);
            sqlConn.Close();
            return _res;
        }
        public void EditDeliveryLine(int id, string custarticle, string comments, double netweight, double brutweight,
                                    string custcode, int qtypack, string package, int isreturn, int coid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditDeliveryDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@custarticle", custarticle);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@netweight", netweight);
            sqlComm.Parameters.AddWithValue("@brutweight", brutweight);
            sqlComm.Parameters.AddWithValue("@custcode", custcode);
            sqlComm.Parameters.AddWithValue("@qtypack", qtypack);
            sqlComm.Parameters.AddWithValue("@package", package);
            sqlComm.Parameters.AddWithValue("@isreturn", isreturn);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            //try
            // {
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        public void DeleteDeliveryLine(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteStockDeliveryLine", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            
            //try
            // {
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }
        }

        int _ddid = 0;

        public int DelivNoteId
        {
            get { return _ddid; }
            set { _ddid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectDelivNoteDet @id = " + _ddid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DHeadId = Convert.ToInt32(dr["headid"]);
                        DCOId = Convert.ToInt32(dr["coid"]);
                        DComments = dr["comments"].ToString();
                        DCostPrice = Convert.ToDouble(dr["unitcostprice"]);
                        DCustArticle = dr["custarticle"].ToString();
                        DCustCode = dr["custcode"].ToString();
                        DArtId = Convert.ToInt32(dr["artid"]);
                        DQty = Convert.ToDouble(dr["qty"]);
                        DQtyPack = Convert.ToInt32(dr["qtypack"]);
                        DTotalCost = Convert.ToDouble(dr["totalcost"]);
                        DUnitId = Convert.ToInt32(dr["unitid"]);
                        DCoefConv = Convert.ToDouble(dr["coefconv"]);
                        DNetWeight = Convert.ToDouble(dr["netweight"]);
                        DBrutWeight = Convert.ToDouble(dr["brutweight"]);
                        DPackage = dr["package"].ToString();
                        DReturn = Convert.ToInt32(dr["isreturn"]);
                        DConfOrder = dr["conforder"].ToString();
                        DDelivDate = dr["delivdate"].ToString();
                        DCustomer = dr["customer"].ToString();;
                        DUnit = dr["unit"].ToString();;

                    }
                }
                else
                {
                    ClearDets();
                }
            }


        }

        public int DHeadId
        { get; set; }
        public int DCOId
        { get; set; }
        public int DArtId
        { get; set; }
        public double DQty
        { get; set; }
        public int DUnitId
        { get; set; }
        public double DCostPrice
        { get; set; }
        public string DCustArticle
        { get; set; }
        public string DComments
        { get; set; }
        public double DCoefConv
        { get; set; }
        public double DNetWeight
        { get; set; }
        public double DBrutWeight
        { get; set; }
        public double DTotalCost
        { get; set; }
        public int DQtyPack
        { get; set; }
        public string DPackage
        { get; set; }
        public string DCustCode
        { get; set; }
        public int DReturn
        { get; set; }
        public string DConfOrder
        { get; set; }
        public string DDelivDate
        { get; set; }
        public string DCustomer
        { get; set; }
        public string DUnit
        { get; set; }

        public void ClearDets()
        {
            DHeadId = 0;
            DCOId = 0;
            DComments = "";
            DCostPrice = 0;
            DCustArticle = "";
            DCustCode = "";
            DArtId = 0;
            DQty = 0;
            DQtyPack = 0;
            DTotalCost = 0;
            DUnitId = 0;
            DCoefConv = 0;
            DNetWeight = 0;
            DBrutWeight = 0;
            DPackage = "";
            DReturn = 0;
            DConfOrder = "";
            DDelivDate = "";
            DCustomer = "";
            DUnit = "";
        }


        #region Printing

        public string DelivNote
        { get; set; }
        public string DocDate
        { get; set; }
        public string DelivDate
        { get; set; }
        public string HeadComments
        { get; set; }
        public int DelivPlaceId
        { get; set; }
        public string DelivPlace
        { get; set; }
        public int DelivAddressId
        { get; set;}
        public string DelivAddress
        { get; set; }
        public int FinalDelivPlaceId
        { get; set; }
        public string FinalDelivPlace
        { get; set; }
        public int FinalDelivAddressId
        { get; set; }
        public string FinalDelivAddress
        { get; set; }
        public int TransportId
        { get; set; }
        public string Transport
        { get; set; }
        public int IncotermsId
        { get; set; }
        public string Incoterms
        { get; set; }
        public int PalQty
        { get; set; }
        public double PalWeight
        { get; set; }
        public string Seller
        { get; set; }
        public string SellerAddress
        { get; set; }
        public string SellerMail
        { get; set; }
        public string SellerContPers
        { get; set; }
        public string SellerPhone
        { get; set; }
        public string BuyerPhone
        { get; set; }
        public string SellerFax
        { get; set; }
        public string SellerVAT
        { get; set; }
        public string BuyerVAT
        { get; set; }
        public string BuyerContPerson
        { get; set; }
        public int BuyerCountryId
        { get; set; }
        public string DeliveryInvoices
        { get; set; }
        public int IsReturn
        { get; set; }
        public string CreditAccount
        { get; set; }
        public string BuyerCountryShort
        { get; set; }
        public void ClearDelivNoteHead()
        {
            DelivNote = "";
            HeadComments = "";
            DelivPlace = "";
            DelivAddressId = 0;
            DelivAddress = "";
            DelivDate = "";
            DelivPlaceId = 0;
            DocDate = "";
            FinalDelivAddressId = 0;
            FinalDelivPlaceId = 0;
            IncotermsId = 0;
            PalQty = 0;
            PalWeight = 0;
            TransportId = 0;
            FinalDelivPlace = "";
            FinalDelivAddress = "";
            Incoterms = "";
            Transport = "";
            Seller = "";
            SellerAddress = "";
            SellerMail = "";
            SellerFax = "";
            BuyerPhone = "";
            SellerPhone = "";
            SellerVAT = "";
            SellerContPers = "";
            BuyerVAT = "";
            BuyerContPerson = "";
            BuyerCountryId = 0;
            DeliveryInvoices = "";
            IsReturn = 0;
            CreditAccount = "";
            BuyerCountryShort = "";
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
                        HeadComments = dr["comments"].ToString();
                        DelivAddressId = Convert.ToInt32(dr["delivaddressid"]);
                        DelivAddress = dr["delivaddress"].ToString();
                        DelivDate = dr["delivdate"].ToString();
                        DelivPlace = dr["delivplace"].ToString();
                        DelivPlaceId = Convert.ToInt32(dr["delivplaceid"]);
                        DocDate = dr["docdate"].ToString();
                        FinalDelivAddressId = Convert.ToInt32(dr["findestaddressid"]);
                        FinalDelivPlaceId = Convert.ToInt32(dr["findestplaceid"]);
                        FinalDelivPlace = dr["findelivplace"].ToString();
                        FinalDelivAddress = dr["findelivaddress"].ToString();
                        IncotermsId = Convert.ToInt32(dr["incotermsid"]);
                        PalQty = Convert.ToInt32(dr["palettesqty"]);
                        PalWeight = Convert.ToDouble(dr["palettesweight"]);
                        TransportId = Convert.ToInt32(dr["transportid"]);
                        Incoterms = dr["incoterms"].ToString();
                        Transport = dr["transport"].ToString();
                        Seller = dr["seller"].ToString();
                        SellerAddress = dr["selleraddress"].ToString();
                        SellerMail = dr["selleremail"].ToString();
                        SellerFax = dr["sellerfax"].ToString();
                        BuyerPhone = dr["buyerphone"].ToString();
                        SellerPhone = dr["sellerphone"].ToString();
                        SellerVAT = dr["sellervat"].ToString();
                        SellerContPers = dr["sellercontpers"].ToString();
                        BuyerVAT = dr["buyervat"].ToString();
                        BuyerContPerson = dr["buyercontperson"].ToString();
                        BuyerCountryId = Convert.ToInt32(dr["buyercountry"]);
                        DeliveryInvoices = dr["invoices"].ToString();
                        IsReturn = Convert.ToInt32(dr["isreturn"]);
                        CreditAccount = dr["creditaccount"].ToString();
                        BuyerCountryShort = dr["buyercountryshort"].ToString();
                    }
                }
                else
                {
                    ClearDelivNoteHead();
                }
            }
        }


        public static DataTable getDeliveryDets(int _id)
        {
            string query = "sp_SelectDelivNoteDets";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getDeliveryDetsPrint(int _id)
        {
            string query = "sp_SelectDelivNoteDetsPrint";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getDeliveryDetsPrintMov(int _id)
        {
            string query = "sp_SelectDelivNoteDetsPrintMov";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }
        #endregion

        #region Packing

        public static DataTable getDeliveryNotPacked(int _id)
        {
            string query = "sp_SelectDelivNoteDetsNotPacked";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getDeliveryPackage(int _id)
        {
            string query = "sp_SelectDelivNoteDetsPackage";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getDeliveryPackageContent(int _id)
        {
            string query = "sp_SelectDelivNoteDetsPackageContent";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = _id }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int AddPackage(int headid, string package, int qtypack, 
                                    double brutweight, string comments, int boxno)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDeliveryPackage", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@brutweight", brutweight);
            sqlComm.Parameters.AddWithValue("@qtypack", qtypack);
            sqlComm.Parameters.AddWithValue("@package", package);
            sqlComm.Parameters.AddWithValue("@boxno", boxno);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }

        public void EditPackage(int id, int headid, string package, int qtypack,
                                    double brutweight, string comments, int boxno)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditDeliveryPackage", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@brutweight", brutweight);
            sqlComm.Parameters.AddWithValue("@qtypack", qtypack);
            sqlComm.Parameters.AddWithValue("@package", package);
            sqlComm.Parameters.AddWithValue("@boxno", boxno);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            
        }

        public void DeletePackage(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDeliveryPackage", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void AddPackageContent(int delivid, int packageid, double qty,
                                    double weightnet)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDeliveryPackageContent", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@delivid", delivid);
            sqlComm.Parameters.AddWithValue("@packid", packageid);
            sqlComm.Parameters.AddWithValue("@weightnet", weightnet);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        public void EditPackageContent(int id, double weightnet)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditDeliveryPackageContent", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@weightnet", weightnet);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }
        public void DeletePackageContent(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteDeliveryPackageContent", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public static DataTable getBatchBoxesForDelivery()
        {
            string query = "sp_SelectBatchBoxForDelivery";

            var sqlparams = new List<SqlParameter>
            {
               
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public static DataTable getBatchBoxesNotMapped(int _idin)
        {
            string query = "sp_SelectBatchBoxNotMapped";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@idin",SqlDbType.Int){Value = _idin }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        public int AddDeliveryLineFromBox(int headid, int packid, int artid, int coid, int inid,
                                    string custarticle, double qty, string comments, string custcode)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddDeliveryLineFromBox", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@packid", packid);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            sqlComm.Parameters.AddWithValue("@inid", inid);
            sqlComm.Parameters.AddWithValue("@custarticle", custarticle);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@custcode", custcode);

            sqlComm.Parameters.Add("@insertedid", SqlDbType.Int).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = Convert.ToInt32(sqlComm.Parameters["@insertedid"].Value);
            sqlConn.Close();

            return _res;
        }

        public string MapDeliveryLineFromBox(int headid, int packid, int delivid)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_MapDeliveryLineFromBox", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@headid", headid);
            sqlComm.Parameters.AddWithValue("@packid", packid);
            sqlComm.Parameters.AddWithValue("@delivid", delivid);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }

        public string MapCOToBatch(int packid, int batchid, int coid)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_MapCODeliveryBoxForBatch", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@packid", packid);
            sqlComm.Parameters.AddWithValue("@batchid", batchid);
            sqlComm.Parameters.AddWithValue("@coid", coid);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

            return _res;
        }

        public string SeparateBox(int packid, double qty)
        {
            string _res = "";

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SeparateDeliveryBox", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@packid", packid);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.Add("@success", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            _res = sqlComm.Parameters["@success"].Value.ToString();
            sqlConn.Close();

            return _res;
        }


        #endregion




        #region Invoices

        public static DataTable getDelivInvoices(int _delivid)
        {
            string query = "EXECUTE sp_SelectDeliveryInvoices @delivid = " + _delivid;

            return Helper.QueryDT(query);
        }

        public static DataTable getDelivIncomes(int _delivid)
        {
            string query = "EXECUTE sp_SelectDeliveryIncomes @delivid = " + _delivid;

            return Helper.QueryDT(query);
        }



        #endregion
    }
}
