using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Odin.Register
{
    public class Reg_BLL
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Articles

        public static DataTable getArticleForAnalyzis()
        {
            string query = "select distinct t.id, t.artid, a.article, a.secname " +
                            " from tmp_articleforanalyzis t " +
                            " inner join bas_articles a on a.id = t.artid " +
                            " where who = current_user";

            return Helper.QueryDT(query);
        }

        public void AddArticleForAnalyzis(int artid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "if not exists (select distinct id from tmp_articleforanalyzis where artid = " + artid + " and who = current_user) " +
                            " insert into tmp_articleforanalyzis (artid, who) values (" + artid + ", current_user)";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteArticleForAnalyzis(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "delete from tmp_articleforanalyzis where id = " + id;
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        public void DeleteArticleForAnalyzisAll()
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "delete from tmp_articleforanalyzis where who = current_user";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

        }

        int _artid = 0;
        public string Article { get; set; }
        public string SecName { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public int UnitId { get; set; }
        public int DeptId { get; set; }
        public string Unit { get; set; }
        public string Type { get; set; }
        public string Dept { get; set; }
        public string Comments { get; set; }
        public int CustCodeId { get; set; }
        public string ImagePath { get; set; }
        public int CreateSubBatch { get; set; }
        public double Weight { get; set; }
        public double QtyReserve { get; set; }
        public string Revision { get; set; }
        public string StorageRules { get; set; }
        public int IsActive { get; set; }
        public double SpoilNorm { get; set; }
        public int StageId { get; set; }
        public string MSL { get; set; }
        public int Service { get; set; }
        public double QtyStock { get; set; }
        public int LabelsQty { get; set; }
        public int StencilRequired { get; set; }
        public int StencilID { get; set; }
        public int Warning { get; set; }
        public double SpoilConst { get; set; }
        public int AsPF { get; set; }
        public int MBLimit { get; set; }
        public int ArtId
        {
            get { return _artid; }
            set
            {
                _artid = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectArticleDets @id = " + _artid, conn);

                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        Article = dr["article"].ToString();
                        SecName = dr["secname"].ToString();
                        Unit = dr["unit"].ToString();
                        UnitId = Convert.ToInt32(dr["unitid"]);
                        Description = dr["Description"].ToString();
                        Comments = dr["Comments"].ToString();
                        Type = dr["type"].ToString();
                        TypeId = Convert.ToInt32(dr["typeid"]);
                        Weight = Convert.ToDouble(dr["weight"]);
                        CustCodeId = Convert.ToInt32(dr["CustCodeId"]);
                        Dept = dr["department"].ToString();
                        DeptId = Convert.ToInt32((dr["deptid"]).ToString());
                        ImagePath = dr["imagepath"].ToString();
                        QtyReserve = Convert.ToDouble(dr["QtyReserve"]);
                        CreateSubBatch = Convert.ToInt32(dr["createsubbatch"]);
                        IsActive = Convert.ToInt32(dr["isactive"]);
                        Revision = dr["revision"].ToString();
                        StorageRules = dr["storagerules"].ToString();
                        SpoilNorm = Convert.ToDouble(dr["spoilnorm"]);
                        StageId = Convert.ToInt32(dr["stageid"]);
                        MSL = dr["msl"].ToString();
                        Service = Convert.ToInt32(dr["service"]);
                        QtyStock = Convert.ToDouble(dr["qtystock"]);
                        LabelsQty = Convert.ToInt32(dr["qtylabels"]);
                        StencilRequired = Convert.ToInt32(dr["stencilrequired"]);
                        StencilID = Convert.ToInt32(dr["stencilid"]);
                        Warning = Convert.ToInt32(dr["warning"]);
                        SpoilConst = Convert.ToDouble(dr["spoilconst"]);
                        AsPF = Convert.ToInt32(dr["AsPF"]);
                        MBLimit = Convert.ToInt32(dr["MBLimit"]);
                    }
                else
                    ClearArtFields();
            }
        }

        public void ClearArtFields()
        {
            SecName = "";
            Description = "";
            Comments = "";
            TypeId = 0;
            Type = "";
            UnitId = 0;
            Unit = "";
            DeptId = 0;
            Dept = "";
            Comments = "";
            CustCodeId = 0;
            ImagePath = "";
            CreateSubBatch = 0;
            Weight = 0;
            QtyReserve = 0;
            Revision = "";
            StorageRules = "";
            IsActive = -1;
            SpoilNorm = 0;
            StageId = 0;
            MSL = "1";
            Service = 0;
            QtyStock = 0;
            LabelsQty = 0;
            StencilID = 0;
            StencilRequired = 0;
            Warning = 0;
            SpoilConst = 0;
            AsPF = 0;
            MBLimit = 0;
        }
        #endregion

        #region Nomenclatures

        public DataTable ArticleParents(int IdCst)
        {
            return Helper.QueryDT("select distinct artid from dbo.ifn_ArticleParents(" + IdCst + ")");
        }

        public DataTable NomenclatureChild(int IdCse)
        {
            return Helper.QueryDT("select * from BAS_Nomenclatures where IdCse = " + IdCse);
        }

        public int MaxNumber(int id)
        {
            var data = ((DataTable)Helper.getSP("sp_BOMDetails", id)).AsEnumerable();
            return data.Count() > 0 ? data.Max(d => d.Field<int>("LineNumber")) : 0;
        }

        public int IdCstById(int Id)
        {
            return Convert.ToInt32(Helper.GetOneRecord("SELECT IdCST FROM BAS_Nomenclatures WHERE ID = " + Id));
        }

        public DataTable FindParent(int id)
        {
            return Helper.QueryDT(string.Format("select n.IdCSE, a.Article from BAS_Nomenclatures n inner join BAS_Articles a on a.Id = n.IdCSE where n.Id= {0}", id));
        }

        public int BOMChildCount(int idCSE)
        {
            return Convert.ToInt32(Helper.GetOneRecord(string.Format("select count(*) from bas_nomenclatures where idcse ={0}", idCSE)));
        }

        public void IncreaseBOMNumbers(int IdCse, int Number)
        {
            var p = new SqlParameter("@IdCse", SqlDbType.Int) { Value = IdCse };
            var p2 = new SqlParameter("@Number", SqlDbType.Int) { Value = Number };
            Helper.ExecuteQuery("UPDATE BAS_Nomenclatures SET LineNumber = LineNumber + 1 WHERE IdCse = @IdCse AND LineNumber > @Number", p, p2);
        }

        public void DecreaseBOMNumbers(int IdCse, int Number)
        {
            var p = new SqlParameter("@IdCse", SqlDbType.Int) { Value = IdCse };
            var p2 = new SqlParameter("@Number", SqlDbType.Int) { Value = Number };
            Helper.ExecuteQuery("UPDATE BAS_Nomenclatures SET  LineNumber = LineNumber - 1 WHERE IdCse = @IdCse AND LineNumber > @Number", p, p2);
        }

        #endregion

        #region Companies

        public string Company { get; set; }
        public string VAT { get; set; }
        public string RegNR { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebAddress { get; set; }
        public int CountryId { get; set; }
        public int ParentId { get; set; }
        public string FirmCommments { get; set; }
        public int SupMark { get; set; }
        public int CustMark { get; set; }
        public int SupPayment { get; set; }
        public int CustPayment { get; set; }
        public int SupIncoterms { get; set; }
        public int CustIncoterms { get; set; }
        public int CompanyIsActive { get; set; }
        public double CountryVAT { get; set; }
        public string OneC { get;set; }
        public string SupComments { get; set; }
        public int CustPayTerms { get; set; }
        public int TransportId { get; set; }
        public int BankContId { get; set; }

        int _firmid = 0;
        public int FirmId
        {
            get { return _firmid; }
            set
            {
                DataTable dt = (DataTable)Helper.getSP("sp_SelectCompanyDets", _firmid);

                if (dt.Rows.Count > 0)
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
                    }
                else
                    ClearFirmFields();
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
        }

        #endregion

        #region Addresses

        int _addressid = 0;

        public int AddressId
        {
            get { return _addressid; }
            set {
                _addressid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectAddressDets @id = " + _addressid, conn);

                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {

                        AddCountryId = Convert.ToInt32(dr["countryid"]);
                        AddFirmId = Convert.ToInt32(dr["firmid"]);
                        AddRegionState = dr["region"].ToString();
                        AddCity = dr["city"].ToString();
                        AddZIPcode = dr["postindex"].ToString();
                        AddStreet = dr["street"].ToString();
                        AddHouse = dr["house"].ToString();
                        AddIsActive = Convert.ToInt32(dr["isactive"]);
                        AddLegalAddress = Convert.ToInt32(dr["legaladdress"]);
                        AddActualAddress = Convert.ToInt32(dr["actaddress"]);
                        AddDefaultDelivPlace = Convert.ToInt32(dr["defaultdeliveryplace"]);
                        AddComments = dr["comments"].ToString();
                        AddFullAddress = dr["fulladdress"].ToString();
                    }
                else
                    ClearAddress();
            }
        }
        public int AddCountryId { get; set; }
        public int AddFirmId { get; set; }
        public int AddIsActive { get; set; }
        public int AddLegalAddress { get; set; }
        public int AddActualAddress { get; set; }
        public int AddDefaultDelivPlace { get; set; }
        public string AddRegionState { get; set; }
        public string AddCity { get; set; }
        public string AddZIPcode { get; set; }
        public string AddStreet { get; set; }
        public string AddHouse { get; set; }
        public string AddComments { get; set; }
        public string AddFullAddress { get; set; }

        public void ClearAddress()
        {
            AddCountryId = 0;
            AddFirmId = 0;
            AddRegionState = string.Empty;
            AddCity = string.Empty;
            AddZIPcode = string.Empty;
            AddStreet = string.Empty;
            AddHouse = string.Empty;
            AddIsActive = 0;
            AddLegalAddress = 0;
            AddActualAddress = 0;
            AddDefaultDelivPlace = 0;
            AddComments = string.Empty;
            AddFullAddress = "";
        }

        #endregion

        #region Contacts

        public string ContFullName { get; set; }
        public string ContJobTitle { get; set; }
        public string ContEmail { get; set; }
        public string ContPhone { get; set; }
        public string ContFax { get; set; }
        public string ContComments { get; set; }
        int _contactid = 0;

        public int ContactId
        {
            get { return _contactid; }
            set { _contactid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SelectContactDets", _contactid);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {

                        ContFullName = dr["fullname"].ToString();
                        ContJobTitle = dr["jobtitle"].ToString();
                        ContEmail = dr["email"].ToString();
                        ContPhone = dr["phone"].ToString();
                        ContFax = dr["fax"].ToString();
                        ContComments = dr["comments"].ToString();
                    }
                else
                    ClearContact();
            }
        }
        public void ClearContact()
        {
            ContFullName = string.Empty;
            ContJobTitle = string.Empty;
            ContEmail = string.Empty;
            ContPhone = string.Empty;
            ContFax = string.Empty;
            ContComments = string.Empty;
        }

        #endregion

        #region Banks

        public int BankId { get; set; }
        public int BankCurId { get; set; }
        public string BankAccount { get; set; }
        public int BankAsDefault { get; set; }
        public string BankComments { get; set; }
        int _accountid = 0;

        public int AccountId
        {
            get { return _accountid; }
            set
            {
                _accountid = value;

                DataTable dt = (DataTable)Helper.getSP("sp_SaveAlias", _accountid);

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        BankId = Convert.ToInt32(dr["bankid"]);
                        BankCurId = Convert.ToInt32(dr["curid"]);
                        BankAccount = dr["account"].ToString();
                        BankAsDefault = Convert.ToInt32(dr["asdefault"]);
                        BankComments = dr["comments"].ToString();
                    }
                else
                    ClearAccounts();
            }
        }

        public void ClearAccounts()
        {
            BankId = 0;
            BankCurId = 0;
            BankAccount = "";
            BankAsDefault = 0;
            BankComments = "";
        }
        #endregion

        #region Catalog

        int _catid = 0;

        public int CatId
        {
            get { return _catid; }
            set
            {
                _catid = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_CatalogArtDets @id = " + _catid, conn);

                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                    foreach (DataRow dr in dt.Rows)
                    {
                        CatArtId = Convert.ToInt32(dr["artid"]);
                        CatBargain = Convert.ToInt32(dr["bargtype"]);
                        CatFirmArt = dr["firmart"].ToString();
                        CatFirmId = Convert.ToInt32(dr["firmid"]);
                        CatUnitId = Convert.ToInt32(dr["unitid"]);
                        CatUnitPrice = Convert.ToDouble(dr["unitprice"]);
                        CatCurId = Convert.ToInt32(dr["curid"]);
                        CatManufacturer = dr["manufacturer"].ToString();
                        CatDelivDerm = Convert.ToInt32(dr["delivterm"]);
                        CatMOQ = Convert.ToDouble(dr["moq"]);
                        CatMPQ = Convert.ToDouble(dr["mpq"]);
                        CatAsDefault = Convert.ToInt32(dr["asdefault"]);
                        CatMinExpDays = Convert.ToInt32(dr["minexpdays"]);
                        CatCoefConv = Convert.ToDouble(dr["coefconv"]);
                        CatComments = dr["comments"].ToString();
                        CatELink = dr["elink"].ToString();
                        CatVat = Convert.ToInt32(dr["vat"]);
                        CatDataCode = dr["datacode"].ToString();
                        CatDelivTermTxt = dr["delivtermtxt"].ToString();
                        CatQuoted = Convert.ToInt32(dr["quoted"]);
                        CatBarCode = dr["ean"].ToString();
                        CatForCust = Convert.ToInt32(dr["forcustomer"]);
                        CatValidTill = dr["validtill"].ToString();
                    }
                else
                    ClearCatDets();
            }
        }

        public void ClearCatDets()
        {
            CatArtId = 0;
            CatBargain = -1;
            CatFirmArt = "";
            CatFirmId = 0;
            CatUnitId = 0;
            CatUnitPrice = 0;
            CatCurId = 1;
            CatManufacturer = "";
            CatDelivDerm = 0;
            CatMOQ = 0;
            CatMPQ = 0;
            CatAsDefault = 0;
            CatMinExpDays = 0;
            CatCoefConv = 0;
            CatComments = "";
            CatELink = "";
            CatVat = 0;
            CatDataCode = "";
            CatDelivTermTxt = "";
            CatQuoted = 0;
            CatBarCode = "";
            CatForCust = 0;
            CatValidTill = "";
        }

        public int CatArtId        { get; set; }
        public int CatBargain        { get; set; }
        public int CatFirmId        { get; set; }
        public string CatFirmArt        { get; set; }
        public int CatUnitId        { get; set; }
        public double CatUnitPrice        { get; set; }
        public int CatCurId        { get; set; }
        public string CatManufacturer        { get; set; }
        public int CatDelivDerm        { get; set; }
        public double CatMOQ        { get; set; }
        public double CatMPQ        { get; set; }
        public int CatAsDefault        { get; set; }
        public int CatMinExpDays        { get; set; }
        public double CatCoefConv        { get; set; }
        public string CatComments        { get; set; }
        public string CatELink        { get; set; }
        public int CatVat        { get; set; }
        public string CatDataCode        { get; set; }
        public string CatDelivTermTxt        { get; set; }
        public int CatQuoted        { get; set; }
        public string CatBarCode        { get; set; }
        public int CatForCust        { get; set; }
        public string CatValidTill
        { get; set; }
        public int AddCatalogItem(int bargtype, int artid, int firmid, string firmart, int unitid, double unitprice, int curid,
                                string manufacturer, string comments, int delivterm, double moq, double mpq, int asdefault,
                                string elink, int vat, int minexpdays, double coefconv, string datacode, string delivtermtxt,
                                int quoted, string barcode, int forcustomer, string validtill)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddCatalogItem", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@bargtype", bargtype);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@firmid", firmid);
            sqlComm.Parameters.AddWithValue("@firmart", firmart);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@curid", curid);
            sqlComm.Parameters.AddWithValue("@manufacturer", manufacturer);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@delivterm", delivterm);
            sqlComm.Parameters.AddWithValue("@moq", moq);
            sqlComm.Parameters.AddWithValue("@mpq", mpq);
            sqlComm.Parameters.AddWithValue("@asdefault", asdefault);
            sqlComm.Parameters.AddWithValue("@elink", elink);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@minexpdays", minexpdays);
            sqlComm.Parameters.AddWithValue("@coefconv", coefconv);
            sqlComm.Parameters.AddWithValue("@datacode", datacode);
            sqlComm.Parameters.AddWithValue("@delivtermtxt", delivtermtxt);
            sqlComm.Parameters.AddWithValue("@quoted", quoted);
            sqlComm.Parameters.AddWithValue("@ean", barcode);
            sqlComm.Parameters.AddWithValue("@forcustomer", forcustomer);
            sqlComm.Parameters.AddWithValue("@validtill", validtill);

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

        public void EditCatalogItem(int id, int bargtype, int artid, int firmid, string firmart, int unitid, double unitprice, int curid,
                                string manufacturer, string comments, int delivterm, double moq, double mpq, int asdefault,
                                string elink, int vat, int minexpdays, double coefconv, string datacode, string delivtermtxt,
                                int quoted, string barcode, int forcustomer, string validtill)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditCatalogItem", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@bargtype", bargtype);
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@firmid", firmid);
            sqlComm.Parameters.AddWithValue("@firmart", firmart);
            sqlComm.Parameters.AddWithValue("@unitid", unitid);
            sqlComm.Parameters.AddWithValue("@unitprice", unitprice);
            sqlComm.Parameters.AddWithValue("@curid", curid);
            sqlComm.Parameters.AddWithValue("@manufacturer", manufacturer);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@delivterm", delivterm);
            sqlComm.Parameters.AddWithValue("@moq", moq);
            sqlComm.Parameters.AddWithValue("@mpq", mpq);
            sqlComm.Parameters.AddWithValue("@asdefault", asdefault);
            sqlComm.Parameters.AddWithValue("@elink", elink);
            sqlComm.Parameters.AddWithValue("@vat", vat);
            sqlComm.Parameters.AddWithValue("@minexpdays", minexpdays);
            sqlComm.Parameters.AddWithValue("@coefconv", coefconv);
            sqlComm.Parameters.AddWithValue("@datacode", datacode);
            sqlComm.Parameters.AddWithValue("@delivtermtxt", delivtermtxt);
            sqlComm.Parameters.AddWithValue("@quoted", quoted);
            sqlComm.Parameters.AddWithValue("@ean", barcode);
            sqlComm.Parameters.AddWithValue("@forcustomer", forcustomer);
            sqlComm.Parameters.AddWithValue("@validtill", validtill);
            //try
            //{
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            //}
            //catch { }

        }


        public void DeleteCatalogItem(int id)
        {

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteCatalogItem", sqlConn);
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

        public DataTable DownloadCatalog(DataTable data, int supid)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DownloadSupplierCatalog", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;

            sqlComm.Parameters.AddWithValue("@supid", supid);
            sqlComm.Parameters.Add("@tablecatalog", SqlDbType.Structured);
            sqlComm.Parameters["@tablecatalog"].TypeName = "UT_Catalog";
            sqlComm.Parameters["@tablecatalog"].Value = data;

            sqlConn.Open();
            da.SelectCommand = sqlComm;
            da.Fill(dt);
            sqlConn.Close();
            return dt;
        }
        #endregion

        #region Rationing

        public int SaveArticleRatio(int artid, DataTable ratios)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveRatios", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.Add("@tableratios", SqlDbType.Structured);
            sqlComm.Parameters["@tableratios"].TypeName = "UT_ArtRatioStages";
            sqlComm.Parameters["@tableratios"].Value = ratios;
                       
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            
            return _res;
        }

        public int SaveArticleRatioStages(int artid, DataTable ratios)
        {
            int _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveRatioStages", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.Add("@tableratios", SqlDbType.Structured);
            sqlComm.Parameters["@tableratios"].TypeName = "UT_ArtRatioStagesNew";
            sqlComm.Parameters["@tableratios"].Value = ratios;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();

            return _res;
        }

        public void AddRatioOperation(int artid, int stageid, string operation, string formula, int useonce, int operno, string comments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddRatioOperation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@stageid", stageid);
            sqlComm.Parameters.AddWithValue("@operation", operation);
            sqlComm.Parameters.AddWithValue("@formula", formula);
            sqlComm.Parameters.AddWithValue("@useontime", useonce);
            sqlComm.Parameters.AddWithValue("@operno", operno);
            sqlComm.Parameters.AddWithValue("@comments", comments);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void EditRatioOperation(int id, string operation, string formula, int useonce, int operno, string comments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditRatioOperation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@operation", operation);
            sqlComm.Parameters.AddWithValue("@formula", formula);
            sqlComm.Parameters.AddWithValue("@useontime", useonce);
            sqlComm.Parameters.AddWithValue("@operno", operno);
            sqlComm.Parameters.AddWithValue("@comments", comments);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteRatioOperation(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteRatioOperation", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public double SelectFormulaRes(int id)
        {
            double _res = 0;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectFormulaRes", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@operid", id);
            sqlComm.Parameters.Add("@res", SqlDbType.Float).Direction = ParameterDirection.Output;

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteNonQuery();
                _res = Convert.ToDouble(sqlComm.Parameters["@res"].Value);
                sqlConn.Close();
            }
            catch { _res = -999; }
            return _res;
        }

        public void SaveFormulaParams(DataTable parameters, int operid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SaveFormulaParams", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@operid", operid);
            sqlComm.Parameters.Add("@tableparams", SqlDbType.Structured);
            sqlComm.Parameters["@tableparams"].TypeName = "UT_ArtRatioStagesFormulaParams";
            sqlComm.Parameters["@tableparams"].Value = parameters;

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        #endregion

        #region BOM Setup

        public DataTable BOMSetupData(int Id)
        {
            return Helper.QueryDT("execute sp_SelectBOMSetup @artId = " + Id);
        }
        public DataTable SelectBatchBOMData(int Id, int Check)
        {
            return Helper.QueryDT("execute [sp_SelectBatchBOMNew] @batchid = " + Id + ", @nullcheck =" + Check);
        }

        public void AddBOMSetup(int artid, int tooltypeid, int toolid, int required, double qty, string comments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBOMSetup", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            
            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@tooltypeid", tooltypeid);
            sqlComm.Parameters.AddWithValue("@toolid", toolid);
            sqlComm.Parameters.AddWithValue("@required", required);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@comments", comments);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void EditBOMSetup(int id, int tooltypeid, int toolid, int required, double qty, string comments)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditBOMSetup", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@tooltypeid", tooltypeid);
            sqlComm.Parameters.AddWithValue("@toolid", toolid);
            sqlComm.Parameters.AddWithValue("@required", required);
            sqlComm.Parameters.AddWithValue("@qty", qty);
            sqlComm.Parameters.AddWithValue("@comments", comments);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteBOMSetup(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteBOMSetup", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void CopyBOMSetup(int artid, int targetid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_CopyBOMSetup", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@targetid", targetid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void CopyBOMStages(int artid, int targetid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_CopyBOMRatio", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@targetid", targetid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        #endregion

        #region Analogues

        public DataTable ArticleAnaloguesData(int Id, int CSEId)
        {
            return Helper.QueryDT("execute sp_SelectArticleAnalogues @artId = " + Id + ", @CSEId = " + CSEId);
        }

        public void AddAnalog(int artid, int analogid, int customerid, string comments, int productid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddAnalog", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@analogid", analogid);
            sqlComm.Parameters.AddWithValue("@customerid", customerid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@productid", productid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void EditAnalog(int id, int analogid, int customerid, string comments, int productid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_EditAnalog", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);
            sqlComm.Parameters.AddWithValue("@analogid", analogid);
            sqlComm.Parameters.AddWithValue("@customerid", customerid);
            sqlComm.Parameters.AddWithValue("@comments", comments);
            sqlComm.Parameters.AddWithValue("@productid", productid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void DeleteAnalog(int id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_DeleteAnalog", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", id);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void AddAnalogToBOM(int artcseid, int artcstid, int analogid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddBOMAnalog", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artcseid", artcseid);
            sqlComm.Parameters.AddWithValue("@artcstid", artcstid);
            sqlComm.Parameters.AddWithValue("@analogid", analogid);
           
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void ValidAnalog(int artid, int analogid, int productid, int valid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_ValidAnalog", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@artid", artid);
            sqlComm.Parameters.AddWithValue("@analogid", analogid);
            sqlComm.Parameters.AddWithValue("@productid", productid);
            sqlComm.Parameters.AddWithValue("@valid", valid);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }
        #endregion
    }
}