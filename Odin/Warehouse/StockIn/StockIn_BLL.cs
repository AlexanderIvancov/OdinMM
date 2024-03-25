using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Odin.Warehouse.StockIn
{
    public class StockIn_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        int _idin = 0;
        public int HeadId { get; set; }
        public int ArtId { get; set; }
        public string SupArticle { get; set; }
        public int TypeInId { get; set; }
        public double Qty { get; set; }
        public int UnitId { get; set; }
        public string Comments { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }
        public double VAT { get; set; }
        public double CoefConv { get; set; }
        public double Weight { get; set; }
        public int CustCodeId { get; set; }
        public int BatchId { get; set; }
        public int WasMovewment { get; set; }
        public int State { get; set; }
        public int SenderCountryId { get; set; }
        public int ProducerCountryId { get; set; }
        public string DataCode { get; set; }
        public double Dutycost { get; set; }
        public int IdIn
        {
            get { return _idin; }
            set { _idin = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectStockInDets", _idin);

                if (dt.Rows.Count > 0)
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
                    }
                else
                    ClearFields();
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
        }

        #region Batches Stock in
        public int InsertedId = 0;
        int _bidin = 0;
        public int BIdIn
        {
            get { return _bidin; }
            set
            {
                _bidin = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectBatchStockInHead", _bidin);

                if (dt.Rows.Count > 0)
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
                else
                    ClearBatchIn();
            }
        }
        public int BArtId { get; set; }
        public string BCustArticle { get; set; }
        public string BSecArticle { get; set; }
        public string BDelivPlace { get; set; }
        public double BQty { get; set; }
        public double BQtyLeft { get; set; }
        public double BUnitPrice { get; set; }
        public string BUnit { get; set; }
        public int BCOid { get; set; }
        public string BConfOrder { get; set; }
        public double BQtyIn { get; set; }
        public int BCountCO { get; set; }

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
        #endregion

        #region Boxes Stock In
        public string AddedBox { get; set; }
        #endregion
    }
}