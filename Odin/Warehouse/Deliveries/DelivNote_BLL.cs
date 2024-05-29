using Odin.Global_Classes;
using System;
using System.Data;

namespace Odin.Warehouse.Deliveries
{
    public class DelivNote_BLL
    {
        int _ddid = 0;
        public int DelivNoteId
        {
            get { return _ddid; }
            set { _ddid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectDelivNoteDetTest", _ddid);

                if (dt.Rows.Count > 0)
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
                        DSpec = dr["spec"].ToString();
                        DOrderState = Convert.ToInt32(dr["orderstate"]);
                        DDelivDate = dr["delivdate"].ToString();
                        DCustomer = dr["customer"].ToString();
                        DUnit = dr["unit"].ToString();
                        DInvoice = dr["invoice"].ToString();
                    }
                else
                    ClearDets();
            }
        }
        public int DHeadId { get; set; }
        public int DCOId { get; set; }
        public int DArtId { get; set; }
        public double DQty { get; set; }
        public int DUnitId { get; set; }
        public double DCostPrice { get; set; }
        public string DCustArticle { get; set; }
        public string DComments { get; set; }
        public double DCoefConv { get; set; }
        public double DNetWeight { get; set; }
        public double DBrutWeight { get; set; }
        public double DTotalCost { get; set; }
        public int DQtyPack { get; set; }
        public string DPackage { get; set; }
        public string DCustCode { get; set; }
        public int DReturn { get; set; }
        public string DConfOrder { get; set; }
        public string DSpec { get; set; }
        public int DOrderState { get; set; } 
        public string DDelivDate { get; set; }
        public string DCustomer { get; set; }
        public string DUnit { get; set; }
        public string DInvoice { get; set; }

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
            DSpec = "";
            DOrderState = 0;
            DDelivDate = "";
            DCustomer = "";
            DUnit = "";
            DInvoice = "";
        }

        int _delivnoteheadid = 0;
        public int DelivNoteHeadId
        {
            get { return _delivnoteheadid; }
            set
            {
                _delivnoteheadid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectDelivNoteHead", _delivnoteheadid);

                if (dt.Rows.Count > 0)
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
                else
                    ClearDelivNoteHead();
            }
        }
        public string DelivNote { get; set; }
        public string DocDate { get; set; }
        public string DelivDate { get; set; }
        public string HeadComments { get; set; }
        public int DelivPlaceId { get; set; }
        public string DelivPlace { get; set; }
        public int DelivAddressId { get; set;}
        public string DelivAddress { get; set; }
        public int FinalDelivPlaceId { get; set; }
        public string FinalDelivPlace { get; set; }
        public int FinalDelivAddressId { get; set; }
        public string FinalDelivAddress { get; set; }
        public int TransportId { get; set; }
        public string Transport { get; set; }
        public int IncotermsId { get; set; }
        public string Incoterms { get; set; }
        public int PalQty { get; set; }
        public double PalWeight { get; set; }
        public string Seller { get; set; }
        public string SellerAddress { get; set; }
        public string SellerMail { get; set; }
        public string SellerContPers { get; set; }
        public string SellerPhone { get; set; }
        public string BuyerPhone { get; set; }
        public string SellerFax { get; set; }
        public string SellerVAT { get; set; }
        public string BuyerVAT { get; set; }
        public string BuyerContPerson { get; set; }
        public int BuyerCountryId { get; set; }
        public string DeliveryInvoices { get; set; }
        public int IsReturn { get; set; }
        public string CreditAccount { get; set; }
        public string BuyerCountryShort { get; set; }

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
    }
}