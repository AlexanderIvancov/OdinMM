using Odin.Global_Classes;
using System;
using System.Data;

namespace Odin.Purchase
{
    public class PO_BLL
    {

        #region Header

        int _poheadid = 0;
        public string POHeader { get; set; }
        public int POHeadSupId { get; set; }
        public int POHeadContPersId { get; set; }
        public string POHeadComments { get; set; }
        public string POHeadCreatAt { get; set; }
        public string POHeadCreatBy { get; set; }
        public string POHeadContract { get; set; }
        public int POHeadCurId { get; set; }
        public int POHeadIncoterms { get; set; }
        public int POHeadDelivPlaceId { get; set; }
        public int POHeadDelivAddressId { get; set; }
        public int POHeadSupplierCountry { get; set; }
        public string POHeadSupplier { get; set; }
        public string POHeadSupplierVAT { get; set; }
        public string POHeadSupAddress { get; set; }
        public string POHeadSupContPerson { get; set; }
        public string POHeadSupContPersPhone { get; set; }
        public string POHeadSupContPersFax { get; set; }
        public string POHeadSupContPersMail { get; set; }
        public string POHeadReceiver { get; set; }
        public string POHeadReceiverVAT { get; set; }
        public string POHeadRecAddress { get; set; }
        public string POHeadRecContPerson { get; set; }
        public string POHeadRecContPersPhone { get; set; }
        public string POHeadRecContPersFax { get; set; }
        public string POHeadRecContPersMail { get; set; }
        public string POHeadCurrency { get; set; }
        public string POHeadPayments { get; set; }
        public string POHeadIncotermsStr { get; set; }
        public int POHeadProcessing { get; set; }
        public string POHeadSupplierCountryISO { get; set; }
        public int POHeadId
        {
            get { return _poheadid; }
            set
            {
                _poheadid = value;
                DataTable dt = (DataTable)Helper.getSP("sp_SelectPOHeader", _poheadid);

                if (dt.Rows.Count > 0)
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
                else
                    ClearPOHead();
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

            DataTable dt = (DataTable)Helper.GetOneRecord("SELECT top 1 line FROM pur_dets WHERE headid = " + poheadid.ToString() + " order by line desc");

            if (dt.Rows.Count > 0)
                foreach (DataRow dr in dt.Rows)
                    _res = Convert.ToInt32(dr["line"]);
            else
                _res = 0;

            return _res;
        }
        public int POId
        {
            get { return _poid; }
            set
            {
                _poid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectPODets", _poid);

                if (dt.Rows.Count > 0)
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
                else
                    ClearPODets();
            }
        }
        public string POName { get; set; }
        public int POArtId { get; set; }
        public string POComments { get; set; }
        public string POCreatAt { get; set; }
        public string POCreatBy { get; set; }
        public string POSupArticle { get; set; }
        public string POSupOrder { get; set; }
        public int POLine { get; set; }
        public double POQty { get; set; }
        public double POQtyLeft { get; set; }    
        public string POReqDate { get; set; }
        public string POMinExpDate { get; set; }
        public int POStateId { get; set; }
        public int POUnitId { get; set; }
        public int PODBUnitId;
        public double POUnitPrice { get; set; }
        public double POVat { get; set; }
        public double PODiscount { get; set; }
        public int POHeadId1 { get; set; }
        public int POCatalogId { get; set; }
        public double POCoefConv { get; set; }
        public int POResale { get; set; }
        public int POProjectId { get; set; }
        public string POInternalComments { get; set; }
        public string POEndCustomer { get; set; }

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

        #endregion

        #region Confirmations

        int _confid = 0;
        public int ConfId
        {
            get { return _confid; }
            set
            {
                _confid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectPOConfDets", _confid);

                if (dt.Rows.Count > 0)
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
                else
                    ClearConfDets();
            }
        }
        public string ConfComments { get; set; }
        public string ConfCreatAt { get; set; }
        public string ConfCreatBy { get; set; }
        public int ConfPOId { get; set; }
        public string ConfDate { get; set; }
        public double ConfQty { get; set; }
        public string ConfType { get; set; }

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

        #endregion

    }
}