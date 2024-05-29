using Odin.Global_Classes;
using System;
using System.Data;

namespace Odin.CMB_Components.BLL
{
    public class CMB_BLL
    {
        DAL_Functions Fun = new DAL_Functions();
        class_Global globClass = new class_Global();
        Helper MyHelper = new Helper();

        #region Countries

        int _CountryId = 0;
        public int CountryCurId { get; set; }
        public int CountryVAT { get; set; }
        public int CountryEU { get; set; }
        public string CountryShortName { get; set; }
        public string Country { get; set; }
        public int CountryId
        {
            get { return _CountryId; }
            set { _CountryId = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectCountry", _CountryId);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        Country = dr["country"].ToString();
                        CountryCurId = Convert.ToInt32(dr["currency"]);
                        CountryEU = Convert.ToInt32(dr["eurozone"]);
                        CountryShortName = dr["shortname"].ToString();
                        CountryVAT = Convert.ToInt32(dr["vat"]);
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

        #region Transport

        int _transportid = 0;
        public string Transport { get; set; }
        public string TransportIntrastat { get; set; }
        public string TransType { get; set; }
        public int TransportId
        {
            get { return _transportid; }
            set
            {
                _transportid = value;
                DataTable dt = (DataTable)Helper.getSP("sp_SelectTransport", _transportid);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        Transport = dr["name"].ToString();
                        TransportIntrastat = dr["intrastatcode"].ToString();
                        TransType = dr["transtype"].ToString();
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

        #region Users

        int _userid = 0;
        public int UserId
        {
            get { return _userid; }
            set
            {
                _userid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectUserDets", _userid);

                if (dt.Rows.Count > 0)
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
                else
                    ClearUser();
            }
        }
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string UserLogin { get; set; }
        public int IsDBUser { get; set; }
        public string UserEmail { get; set; }
        public string UserLang { get; set; }
        public string UserJob { get; set; }
        public string UserInitials { get; set; }
        public int UserDeptId { get; set; }
        public int UserIsActive { get; set; }
        public string UserPhone { get; set; }
        public string UserFax { get; set; }
        public string UserTabNR { get; set; }
        public string UserShortName { get; set; }
        public string UserCurrent { get; set; }

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

        #endregion

        #region IncomeDocs

        int _incomedocheadid = 0;
        public int IncomeDocHeadId
        {
            get { return _incomedocheadid; }
            set
            {
                _incomedocheadid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectIncomeDocHead", _incomedocheadid);

                if (dt.Rows.Count > 0)
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
                    }
                else
                    ClearIncomeDocHead();
            }

        }
        public string IncomeDocName { get; set; }
        public string IncomeDocSerie { get; set; }
        public string IncomeDocRegDate { get; set; }
        public string IncomeDocDocDate { get; set; }
        public string IncomeDocComments { get; set; }
        public int IncomeDocSupId { get; set; }
        public int IncomeDocCurId { get; set; }
        public double IncomeDocCurRate { get; set; }
        public int IncomeDocSender { get; set; }
        public int IncomeDocProducer { get; set; }
        public int IncomeDocTransportId { get; set; }
        public int IncomeDocIncotermsId { get; set; }
        public string IncomeDocBargain { get; set; }
        public double IncomeDocAdditCost { get; set; }
        public double IncomeDocAdvance { get; set; }
        public string IncomeDocAdvanceDate { get; set; }
        public string IncomeDocPayDate { get; set; }
        public int IncomeDocNoReversePVN { get; set; }
        public double IncomeDocMediatedCost { get; set; }
        public int IncomeDocCheck { get; set; }

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
        }

        public void CheckSendResaleLetter(int _headid)
        {
            bool _test = false;
            string strMessage = "";
            string emailaddresses = "";

            DataTable dt = (DataTable)Helper.getSP("sp_SelectResalePurchaseOrders", _headid);

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
                _test = false;

            if (_test == true)
            {
                emailaddresses = Fun.EmailAddressesByType(3);

                if (emailaddresses != "")
                    MyHelper.SendMessage(globClass.ReplaceChar(emailaddresses, ";", ","), "Resale orders income registration!", strMessage);
            }
        }

        #endregion

        #region Movements

        int _movedocheadid = 0;
        public int MoveDocHeadId
        {
            get { return _movedocheadid; }
            set
            {
                _movedocheadid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectMoveDocHead", _movedocheadid);

                if (dt.Rows.Count > 0)
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
                else
                    ClearMoveDocHead();
            }

        }
        public string MoveDocName { get; set; }
        public string MoveDocDocDate { get; set; }
        public string MoveDocDelivDate { get; set; }
        public string MoveDocComments { get; set; }
        public int MoveDocDelivPlaceId { get; set; }
        public string MoveDocDelivPlace { get; set; }
        public int MoveDocDelivAddressId { get; set; }
        public string MoveDocDelivAddress { get; set; }
        public int MoveDocFinDestPlaceId { get; set; }
        public string MoveDocFinDestPlace { get; set; }
        public int MoveDocFinDestAddressId { get; set; }
        public string MoveDocFinDestAddress { get; set; }
        public int MoveDocTransportId { get; set; }
        public string MoveDocTransport { get; set; }
        public int MoveDocIncotermsId { get; set; }
        public string MoveDocIncoterms { get; set; }
        public int MoveDocPalettesQty { get; set; }
        public double MoveDocPalettesWeight { get; set; }
        public int MoveDocBatchId { get; set; }
        public string MoveDocBatch { get; set; }
        public double MoveQtyInBatch { get; set; }
        public string MoveConfOrder { get; set; }
        public string MoveProduct { get; set; }
        public string MoveSecArticle { get; set; }
        public string MoveUnit { get; set; }
        public int MoveStageId { get; set; }
        public double MoveQtyOnStage { get; set; }
        public string MoveCustomer { get; set; }
        public string MoveBatchComments { get; set; }
        public int MoveIsReturn { get; set; }
        public string MoveCreditAccount { get; set; }

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

        int _outdocheadid = 0;
        public int OutDocHeadId
        {
            get { return _outdocheadid; }
            set {
                _outdocheadid = value; 

                DataTable dt = (DataTable)Helper.getSP("sp_SelectOutDocHead", _outdocheadid);

                if (dt.Rows.Count > 0)
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
                else
                    ClearOutDocHead();
            }
        }
        public string OutDocName { get; set; }
        public string OutDocDocDate { get; set; }
        public string OutDocComments { get; set; }
        public int OutDocTypeOff { get; set; }
        public int OutDocReasonId { get; set; }
        public string OutDocType { get; set; }
        public string OutDocReason { get; set; }
        public int OutDocBatchId { get; set; }

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

        int _requestid = 0;
        public int RequestId
        {
            get { return _requestid; }
            set
            {
                _requestid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectRequestHead", _requestid);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        RequestName = dr["name"].ToString();
                        RequestComments = dr["comments"].ToString();
                        RequestProdPlace = Convert.ToInt32(dr["placeid"]);
                    }
                else
                    ClearRequestHead();
            }
        }
        public string RequestName { get; set; }
        public string RequestComments { get; set; }
        public int RequestProdPlace { get; set; }

        public void ClearRequestHead()
        {
            RequestName = "";
            RequestComments = "";
            RequestProdPlace = 0;
        }

        #endregion

        #region Delivery Notes

        public string DelivNote { get; set; }
        public string DLNDocDate { get; set; }
        public string DLNDelivDate { get; set; }
        public string DLNComments { get; set; }
        public int DLNDelivPlaceId { get; set; }
        public int DLNDelivAddressId { get; set; }
        public int DLNFinalDelivPlaceId { get; set; }
        public int DLNFinalDelivAddressId { get; set; }
        public int DLNTransportId { get; set; }
        public int DLNIncotermsId { get; set; }
        public int DLNPalQty { get; set; }
        public double DLNPalWeight { get; set; }
        public string DLNCreditAccount { get; set; }
        public int DLNIsReturn { get; set; }
        public int DLNNoReversePVN { get; set; }
        public int DLNInternal { get; set; }
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
                else
                    ClearDelivNoteHead();
            }
        }

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

        #endregion

        #region ExpInvoices

        public int ExInvoiceType { get; set; }
        public string ExInvoice { get; set; }
        public string ExInvoiceSerie { get; set; }
        public string ExInvoiceStampDate { get; set; }
        public string ExInvoiceDocDate { get; set; }
        public string ExInvoiceComments { get; set; }
        public int ExInvoiceReceiverId { get; set; }
        public int ExInvoiceReceiverAddressId { get; set; }
        public int ExInvoiceBuyerId { get; set; }
        public int ExInvoiceBuyerAddressId { get; set; }
        public int ExInvoiceCurId { get; set; }
        public double ExInvoiceCurRate { get; set; }
        public int ExInvoiceTransportId { get; set; }
        public int ExInvoiceIncotermsId { get; set; }
        public string ExInvoiceBargain { get; set; }
        public string ExInvoiceBargainDesc { get; set; }
        public string ExInvoicePayment { get; set; }
        public string ExInvoicePaymentLat { get; set; }
        public int ExInvoiceBankAccountId { get; set; }
        public int ExInvoiceAssetId { get; set; }
        public int ExInvoiceSenderAddressId { get; set; }
        public string ExInvoicePlaceOfLoading { get; set; }
        public int ExInvoiceAgentId { get; set; }
        public int ExInvoiceAgentAddressId { get; set; }
        public int ExInvoiceBuyerCountryId { get; set; }
        public string ExInvoiceOrigin { get; set; }
        public string ExInvoiceSender { get; set; }
        public string ExInvoiceSenderVAT { get; set; }
        public string ExInvoiceSenderAddress { get; set; }
        public string ExInvoiceSenderBank { get; set; }
        public string ExInvoiceReceiver { get; set; }
        public string ExInvoiceReceiverVAT { get; set; }
        public string ExInvoiceReceiverAddress { get; set; }
        public string ExInvoiceReceiverLegalAddress { get; set; }
        public string ExInvoiceBuyer { get; set; }
        public string ExInvoiceBuyerVAT { get; set; }
        public string ExInvoiceBuyerAddress { get; set; }
        public string ExInvoiceBuyerLegalAddress { get; set; }
        public string ExInvoiceIncoterms { get; set; }
        public string ExInvoiceAsset { get; set; }
        public string ExInvoiceCurrency { get; set; }
        public string ExInvoicePlaceOfIssue { get; set; }
        public double ExInvoiceVAT { get; set; }
        public double ExInvoiceTotal { get; set; }
        public double ExInvoiceTotalVat { get; set; }
        public double ExInvoiceTotalWithVat { get; set; }
        public string ExInvoicePayBefore { get; set; }
        public string ExInvoiceReceiverBank { get; set; }
        public string ExInvoiceBuyerBank { get; set; }
        public string ExInvoiceSenderVatNr { get; set; }
        public string ExInvoiceReceiverVatNr { get; set; }
        public string ExInvoiceBuyerVatNr { get; set; }
        public string ExInvoiceIssuedBy { get; set; }
        public string ExInvoiceTotalWord { get; set; }
        public string ExInvoiceTotalWordLat { get; set; }
        public string ExInvoiceTransport { get; set; }
        public string ExInvoiceBargainDescLat { get; set; }
        public double ExInvoiceInAdvance { get; set; }
        public string ExInvoiceAdvanceDate { get; set; }
        public string ExInvoicePayDate { get; set; }
        public string ExInvoiceProformaNR { get; set; }
        public int ExInvoicePaymentId { get; set; }
        public int ExInvoiceSellerContPersId { get; set; }
        public int ExInvoiceBuyerContPersId { get; set; }
        public string ExInvoiceSellerContPerson { get; set; }
        public string ExInvoiceBuyerContPerson { get; set; }
        public string ExInvoiceSellerContPersEmail { get; set; }
        public int ExInvoiceValueForCustoms { get; set; }
        public double ExInvoiceTotalPay { get; set; }
        public int ExInvoiceESignature { get; set; }
        public string ExInvoiceRecepPers { get; set; }
        public string ExInvoiceESignaturePers { get; set; }
        public string ExInvoiceJobTitle { get; set; }
        public string ExInvoiceJobTitleLat { get; set; }
        int _exinvoiceid = 0;
        public int ExInvoiceId
        {
            get { return _exinvoiceid; }
            set
            {
                _exinvoiceid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectExInvoiceDocHead", _exinvoiceid);

                if (dt.Rows.Count > 0)
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
                else
                    ClearExInvoiceHead();
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

        #endregion

        #region FreezedReasons

        public static DataTable getFreezedReasons()
        {
            return Helper.QueryDT("SELECT * FROM TMP_FreezedReason where lang = '" + new DAL_Functions().UserLang + "'");
        }

        #endregion
    }
}