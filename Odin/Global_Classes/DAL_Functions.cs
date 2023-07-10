using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using DataMatrix.net;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace Odin.Global_Classes
{
    class DAL_Functions
    {
        class_Global globClass = new class_Global();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        #region Currency Rate

        public double curRate;
        public string curDate;

        public double CurRate
        {
            get { return this.curRate; }
            set { this.curRate = value; }
        }
        public string CurDate
        {
            get { return this.curDate; }
            set { this.curDate = value; }
        }
        public int DiffDays(string Date1, string Date2)
        {

            DateTime _date1;
            DateTime _date2;
            if (globClass.NES(Date1) != "")
            {
                try { _date1 = Convert.ToDateTime(Date1); }
                catch { _date1 = System.DateTime.Now; }
            }
            else
            {
                _date1 = System.DateTime.Now;
            }
            if (globClass.NES(Date2) != "")
            {
                try { _date2 = Convert.ToDateTime(Date2); }
                catch { _date2 = System.DateTime.Now; }
            }
            else
            {
                _date2 = System.DateTime.Now;
            }

            TimeSpan interval = _date1 - _date2;
            return Math.Abs(interval.Days);

        }

        public double CurrencyRate(int CurId, string CurDate)
        {
            double _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectCurRate", sqlConn);

            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.Add("@CurID", SqlDbType.Int);
            sqlComm.Parameters["@CurID"].Value = CurId;

            sqlComm.Parameters.Add("@CurDate", SqlDbType.NVarChar);
            sqlComm.Parameters["@CurDate"].Value = CurDate;

            try
            {
                sqlConn.Open();
                SqlDataReader sqlReader = sqlComm.ExecuteReader();
                sqlReader.Read();

                _res = Convert.ToDouble(sqlReader[0].ToString());

                sqlReader.Close();
                sqlConn.Close();

            }
            catch
            {
                _res = 0;
            }
            return _res;
        }

        public void ShowCurRate(int CurId, string CurDate)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectCurRate", sqlConn);

            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.Add("@CurID", SqlDbType.Int);
            sqlComm.Parameters["@CurID"].Value = CurId;

            sqlComm.Parameters.Add("@CurDate", SqlDbType.NVarChar);
            sqlComm.Parameters["@CurDate"].Value = CurDate;

            try
            {
                sqlConn.Open();
                SqlDataReader sqlReader = sqlComm.ExecuteReader();
                sqlReader.Read();

                curRate = Convert.ToDouble(sqlReader[0].ToString());
                curDate = sqlReader[1].ToString();

                sqlReader.Close();
                sqlConn.Close();

            }
            catch
            {
                curRate = 0;
                curDate = "";
            }

        }
        
        public static DataTable CurrencyRates(int curId, string dateFrom, string dateTill)
        {

            var _query = "sp_SelectCurrency";
            var sqlparams = new List<SqlParameter>
                                    {
                                        new SqlParameter("@CurId ",  SqlDbType.Int) {Value = curId},
                                        new SqlParameter("@DateFrom", SqlDbType.NVarChar) {Value = dateFrom},
                                        new SqlParameter("@DateTo", SqlDbType.NVarChar) {Value = dateTill}
                                    };

            var data = Helper.QuerySP(_query, sqlparams.ToArray());
            return data;
        }

        public static DataTable CurrencyList()
        {
            return Helper.QueryDT("SELECT DISTINCT currency, id FROM BAs_Currency ORDER BY currency");
        }


        public static DataTable CurrencyRatesList(string CurDate, string CurName)
        {
            return Helper.QueryDT(string.Format("execute sp_SelectCurrencyRates @CurDate = '{0}', @CurName = '{1}'",
                CurDate, CurName));
        }


        public static void AddCurrencyRate(int CrCurId, string date, double rate, double coef)
        {
            var sqlparams = new List<SqlParameter>
                                    {
                                        new SqlParameter("@CrCurId", SqlDbType.Int) {Value = CrCurId},
                                        new SqlParameter("@Date", SqlDbType.NVarChar) {Value = date},
                                        new SqlParameter("@Rate", SqlDbType.Float) {Value = rate},
                                        new SqlParameter("@Coef", SqlDbType.Float) {Value = coef}
                                    };

            Helper.ExecuteSP("sp_AddCurrencyRate", sqlparams.ToArray());
        }

        public static void EditCurrencyRate(int CrId, int CurId, string date, double rate, double coef)
        {
            var sqlparams = new List<SqlParameter>
                                    {
                                        new SqlParameter("@CrId", SqlDbType.Int) {Value = CrId},
                                        new SqlParameter("@CrCurId", SqlDbType.Int) {Value = CurId},
                                        new SqlParameter("@Date", SqlDbType.NVarChar) {Value = date},
                                        new SqlParameter("@Rate", SqlDbType.Float) {Value = rate},
                                        new SqlParameter("@Coef", SqlDbType.Float) {Value = coef}
                                    };

            Helper.ExecuteSP("sp_EditCurrencyRate", sqlparams.ToArray());
        }

        public static bool DeleteCurrencyRate(int Id)
        {
            var query = "DELETE FROM BAS_CurrencyRates WHERE Id = " + Id;
            return Helper.ExecuteQuery(query);
        }

        public static DataTable SelectCurrencyByName(string CurName)
        {
            return Helper.QueryDT(string.Format("SELECT id, currency, description FROM BAS_Currency WHERE currency = '{0}'", CurName));
        }


        #endregion

        #region User Info

        string _UserLogin = "";
        public double _UnitPrice;
        public int _Vat;
        public double _PriceWithVat;
        public int UserId
        { get; set; }
        public string UserName
        { get; set; }
        public string UserSurname
        { get; set; }
        public string UserEmail
        { get; set; }
        public string UserPhone
        { get; set; }
        public string UserFax
        { get; set; }
        public int UserDeptId
        { get; set; }
        public string UserMailPWD
        { get; set; }
        public string UserInitials
        { get; set; }
        string _currentuser = "";
        public string CurrentDBUser
        {
            get {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                string strSQL = "select distinct current_user as currentuser ";
                SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlComm.ExecuteReader();
                if (reader.HasRows == true)
                {
                    reader.Read();
                   _currentuser = reader["currentuser"].ToString();
                    reader.Close();
                }
                else
                {
                    _currentuser = "";
                }
                sqlConn.Close();

                return _currentuser; }
            set { _currentuser = value; }
        }
        public string UserLogin
        {
            get { return _UserLogin; }
            set
            {
                _UserLogin = value;
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                string strSQL = "select distinct id, name, surname, isnull(email, '') as usermail, isnull(lang, '') as userlang, " + 
                                    " isnull(phone, '') as phone, isnull(fax, '') as fax, isnull(deptid, 0) as DeptId, isnull(initials, '') as initials, " +
                                    " isnull(nullif(convert(nvarchar, DECRYPTBYPASSPHRASE(name + surname + userlogin, mailpwd, 1, CONVERT(varbinary, id))), ''), 'a') as usermailpwd " + 
                                    " from bas_users where userlogin = @userlogin";
                SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
                sqlComm.Parameters.AddWithValue("@userlogin", _UserLogin);
                sqlConn.Open();
                //try
                //{
                    SqlDataReader reader = sqlComm.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        reader.Read();
                        UserId = Convert.ToInt32(reader["id"]);
                        UserName = reader["name"].ToString();
                        UserSurname = reader["surname"].ToString();
                        UserEmail = reader["usermail"].ToString();
                        UserFax = reader["fax"].ToString();
                        UserPhone = reader["phone"].ToString();
                        UserDeptId = Convert.ToInt32(reader["DeptId"]);
                        UserMailPWD = reader["usermailpwd"].ToString();
                        UserInitials = reader["initials"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        UserId = 0;
                        UserName = "";
                        UserSurname = "";
                        UserEmail = "";
                        UserFax = "";
                        UserPhone = "";
                        UserDeptId = 0;
                        UserMailPWD = "";
                        UserInitials = "";
                    }
                //}
                //catch
                //{
                //    UserId = 0;
                //    UserName = "";
                //    UserSurname = "";
                //    UserEmail = "";
                //    UserFax = "";
                //    UserPhone = "";
                //    UserDeptId = 0;
                //    UserMailPWD = "";
                //}
                sqlConn.Close();
            }
        }
        #endregion

        #region Unit Price
        public double UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }
        public int Vat
        {
            get { return this._Vat; }
            set { this._Vat = value; }
        }
        public double UnitPriceWithVat
        {
            get { return this._PriceWithVat; }
            set { this._PriceWithVat = value; }
        }
        public void ShowArtPrice(int ArtId, int FirmId, double MinQty, int CurId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectPurchaserPrice", sqlConn);

            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.Add("@ArtId", SqlDbType.Int);
            sqlComm.Parameters["@ArtId"].Value = ArtId;

            sqlComm.Parameters.Add("@FirmId", SqlDbType.Int);
            sqlComm.Parameters["@FirmId"].Value = FirmId;

            sqlComm.Parameters.Add("@MinQty", SqlDbType.Float);
            sqlComm.Parameters["@MinQty"].Value = MinQty;

            sqlComm.Parameters.Add("@CurId", SqlDbType.Int);
            sqlComm.Parameters["@CurId"].Value = CurId;

            try
            {
                sqlConn.Open();
                SqlDataReader reader = sqlComm.ExecuteReader();
                reader.Read();

                UnitPrice = Convert.ToDouble(reader["Price"].ToString());
                Vat = Convert.ToInt32(reader["VAT"].ToString());
                UnitPriceWithVat = Convert.ToDouble(reader["PriceWithVAT"].ToString());

                reader.Close();
                sqlConn.Close();

            }
            catch
            {
                UnitPrice = 0;
                Vat = 0;
                UnitPriceWithVat = 0;
            }
        }
        public double UnitRecalc(int UnitSource, int UnitTarget)
        {
            double k = 0;
            if (UnitSource == UnitTarget)
            {
                return 1;
            }
            else
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                string strSQL = "select dbo.fn_CoefConv(" + UnitSource + ", " + UnitTarget+ ") as CoefConv";
                SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
                
                sqlConn.Open();

                SqlDataReader sqlReader = sqlComm.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    k = Convert.ToDouble(sqlReader["CoefConv"].ToString());
                    //if (k == 0)
                    //    k = 1;
                    sqlReader.Close();
                }
                else
                {
                    k = 1;
                }
                
                sqlConn.Close();
                return k;

            }
        }
        public string ShowFirmArticle(int ArtId, int FirmId)
        {
            string FA;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectRefFirm", sqlConn);

            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.Add("@IdFirm", SqlDbType.Int);
            sqlComm.Parameters["@IdFirm"].Value = FirmId;

            sqlComm.Parameters.Add("@ArtId", SqlDbType.Int);
            sqlComm.Parameters["@ArtId"].Value = ArtId;

            try
            {
                sqlConn.Open();
                SqlDataReader sqlReader = sqlComm.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    FA = sqlReader["RefFirm"].ToString();
                    sqlReader.Close();
                }
                else
                {
                    FA = "(none)";
                }


                sqlConn.Close();
                return FA;

            }
            catch
            {
                return "(none)";
            }
        }

        public string ShowArticleBySupArt(int FirmId, string SupArt)
        {
            string FA;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectArticleByRefFirm", sqlConn);

            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@IdFirm", FirmId);
            sqlComm.Parameters.AddWithValue("@SupArt", SupArt);

            try
            {
                sqlConn.Open();
                SqlDataReader sqlReader = sqlComm.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    sqlReader.Read();
                    FA = sqlReader["Article"].ToString();
                    sqlReader.Close();
                }
                else
                {
                    FA = SupArt + " - unknown";
                }


                sqlConn.Close();
                return FA;

            }
            catch
            {
                return SupArt + " - unknown";
            }
        }

        public string FullTypeName(int TypeId)
        {
            string Res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT dbo.fn_FullGroupTree(" + TypeId + ") as Type";
            //MessageBox.Show(strSQL);
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                Res = sqlReader["Type"].ToString();
            }
            sqlReader.Close();
            sqlConn.Close();
            return Res;
        }


        public string MyMailAdress()
        {
            string Res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT email FROM BAS_Users WHERE UserLogin = Current_User"; // '" + Environment.UserName + "'";
            //MessageBox.Show(strSQL);
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                Res = sqlReader["email"].ToString();
                sqlReader.Close();
            }

            sqlConn.Close();
            return Res;
        }


        #endregion

        #region Opened Forms

        //public void DeleteOpenedForms()
        //{
        //    var sqlparam = new SqlParameter("@UserId", SqlDbType.Int) { Value = UserId };
        //    Helper.ExecuteQuery("DELETE FROM PRI_OpenedForms WHERE OF_UserId = @UserId", sqlparam);
        //}

        //public void InsertOpenedForm(string formName, string formType)
        //{
        //    if (formName != "BookIntes.frm_Wait")//Waitformu ne vstavlaem
        //    {
        //        var sqlparams = new SqlParameter[3];

        //        sqlparams[0] = new SqlParameter("@UserId", SqlDbType.Int) { Value = UserId };
        //        sqlparams[1] = new SqlParameter("@FormName", SqlDbType.NVarChar) { Value = formName };
        //        sqlparams[2] = new SqlParameter("@FormType", SqlDbType.NVarChar) { Value = formType };
        //        Helper.ExecuteQuery("INSERT INTO PRI_OpenedForms (OF_UserId,OF_FormName, OF_FormType) " +
        //                            "VALUES(@UserId, @FormName, @FormType)", sqlparams);
        //    }
        //}


        //public DataTable SelectOpenedForms()
        //{
        //    var param = new SqlParameter("@UserId", SqlDbType.Int) { Value = UserId };
        //    var data = Helper.QueryDT("select * from PRI_OpenedForms where OF_UserId = @UserId", param);
        //    return data;
        //}

        #endregion

        #region Notifications

        //public string NotifAddressesConfirm(int POLineId)
        //{
        //    string Res = "";
        //    SqlConnection sqlConn = new SqlConnection(sConnStr);
        //    SqlCommand sqlComm = new SqlCommand("sp_SelectPONotifAddressesByType", sqlConn);
        //    sqlComm.CommandType = CommandType.StoredProcedure;

        //    sqlComm.Parameters.AddWithValue("@Id", POLineId);
        //    sqlComm.Parameters.AddWithValue("@Column", "Conf");

        //    try
        //    {
        //        sqlConn.Open();

        //        SqlDataReader reader = sqlComm.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                Res = Res + reader["address"].ToString() + "; ";
        //            }
        //            //Res = Res + reader.
        //            Res = Res.Substring(0, (Res.Length - 2));
        //            reader.Close();
        //        }

        //        sqlConn.Close();
        //    }
        //    catch
        //    { }
        //    return Res;
        //}

        //public string NotifAddressesDeliv(int POLineId)
        //{
        //    string Res = "";
        //    SqlConnection sqlConn = new SqlConnection(sConnStr);
        //    SqlCommand sqlComm = new SqlCommand("sp_SelectPONotifAddressesByType", sqlConn);
        //    sqlComm.CommandType = CommandType.StoredProcedure;

        //    sqlComm.Parameters.AddWithValue("@Id", POLineId);
        //    sqlComm.Parameters.AddWithValue("@Column", "deliv");

        //    try
        //    {
        //        sqlConn.Open();

        //        SqlDataReader reader = sqlComm.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                Res = Res + reader["address"].ToString() + "; ";
        //            }
        //            //Res = Res + reader.
        //            Res = Res.Substring(0, (Res.Length - 2));
        //            reader.Close();
        //        }

        //        sqlConn.Close();
        //    }
        //    catch
        //    { }
        //    return Res;
        //}

        //public string NotifAddressesDelivCO(int COLineId)
        //{
        //    string Res = "";
        //    SqlConnection sqlConn = new SqlConnection(sConnStr);
        //    SqlCommand sqlComm = new SqlCommand("sp_SelectCONotifAddressesByType", sqlConn);
        //    sqlComm.CommandType = CommandType.StoredProcedure;

        //    sqlComm.Parameters.AddWithValue("@Id", COLineId);
        //    sqlComm.Parameters.AddWithValue("@Column", "deliv");

        //    try
        //    {
        //        sqlConn.Open();

        //        SqlDataReader reader = sqlComm.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                Res = Res + reader["address"].ToString() + "; ";
        //            }
        //            //Res = Res + reader.
        //            Res = Res.Substring(0, (Res.Length - 2));
        //            reader.Close();
        //        }

        //        sqlConn.Close();
        //    }
        //    catch
        //    { }
        //    return Res;
        //}

        public string EmailFromContact(string FullName)
        {
            string res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "select distinct isnull(email, '') as email from bas_contacts where fullname = @fullname";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlComm.Parameters.AddWithValue("@fullname", FullName);

            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                res = reader["email"].ToString();
                reader.Close();
            }

            sqlConn.Close();
            return res;
        }

        public bool CheckIncomeControl(/*int POLineId*/int IdIn)
        {
            bool _res = false;
            int _r = 0;
            try
            {
                //_r = Convert.ToInt32(Helper.GetOneRecord("select distinct dbo.fn_CheckIncomeControl(" + POLineId + ")"));
                _r = Convert.ToInt32(Helper.GetOneRecord("select distinct dbo.fn_CheckIncomeControlFin(" + IdIn + ")"));
            }
            catch { }
            if (_r == 0)
                _res = false;
            else
                _res = true;

            return _res;
        }

        public bool CheckCoC(int POLineId, int HeadId)
        {
            bool _res = false;
            int _r = 0;
            try
            {
                _r = Convert.ToInt32(Helper.GetOneRecord("select distinct dbo.fn_CheckCoC(" + POLineId + ", " + HeadId + ")"));
            }
            catch { }
            if (_r == 0)
                _res = false;
            else
                _res = true;

            //SqlConnection sqlConn = new SqlConnection(sConnStr);
            //string strSQL = "select distinct dbo.fn_CheckIncomeControl(" + POLineId + ") as res";
            //SqlCommand sqlComm = new SqlCommand(sqlConn.

            return _res;
        }

        public string EmailAddressesByType(int type)
        {
            string _r = "";
            try
            {
                _r = Convert.ToString(Helper.GetOneRecord("select distinct dbo.fn_ConcEmailAddresses(" + type + ")"));
            }
            catch { }
            return _r;
        }


        #endregion

        #region Common

        public string WeekFromDate(string Date)
        {
            string _Res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT 'W' + Left(Right(datejalon, 4), 2) + '/' + Left(datejalon, 4) as [Week] FROM PRI_Date WHERE DateJMA = @Date";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlComm.Parameters.AddWithValue("@Date", Date);
            sqlConn.Open();

            try
            {
                SqlDataReader reader = sqlComm.ExecuteReader();
                if (reader.HasRows == true)
                {
                    reader.Read();
                    _Res = reader["Week"].ToString();
                    reader.Close();
                }

            }
            catch { }

            sqlConn.Close();
            return _Res;
        }

        public string FirmFromId(int Id)
        {
            string _Res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT company as Firm FROM bas_companies WHERE id = @Id";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlConn.Open();

            try
            {
                SqlDataReader reader = sqlComm.ExecuteReader();
                if (reader.HasRows == true)
                {
                    reader.Read();
                    _Res = reader["Firm"].ToString();
                    reader.Close();
                }

            }
            catch { }

            sqlConn.Close();
            return _Res;
        }

        public string Address
        { get; set; }
        public string Country
        { get; set; }

        public void AddressFromId(int Id)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT dbo.fn_FullAddress(@id) as Address, Isnull(c.Country, '') as Country FROM bas_addresses a LEFT JOIN bas_countries c on c.Id = a.CountryId WHERE id = @Id";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlComm.Parameters.AddWithValue("@Id", Id);
            sqlConn.Open();

            try
            {
                SqlDataReader reader = sqlComm.ExecuteReader();
                if (reader.HasRows == true)
                {
                    reader.Read();
                    Address = reader["Address"].ToString();
                    Country = reader["Country"].ToString();
                    reader.Close();
                }
                else
                {
                    Country = "";
                    Address = "";
                }

            }
            catch { }

            sqlConn.Close();

        }

        public double AvailQty(int ArtId)
        {
            var param = new SqlParameter("@ArtId", SqlDbType.Int);
            param.Value = ArtId;
            try
            {
                return Convert.ToDouble(Helper.GetOneRecord("SELECT DISTINCT dbo.fn_QtyAvailable(@ArtId)", param));
            }
            catch { return 0; }
        }

        public int CheckArtId(int ArtId)
        {
            var param = new SqlParameter("@ArtId", SqlDbType.Int);
            param.Value = ArtId;
            try
            {
                return Convert.ToInt32(Helper.GetOneRecord("SELECT DISTINCT id from bas_articles where id = @artid", param));
            }
            catch { return 0; }
        }

        public int CheckArticleSameName(int ArtId, string Article)
        {
            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@artid",SqlDbType.Int){Value = ArtId },
                new SqlParameter("@article",SqlDbType.NVarChar){Value = Article }

            };
                        
            try
            {
                return Convert.ToInt32(Helper.GetOneRecord("SELECT DISTINCT id from bas_articles where id != @artid and ltrim(rtrim(article)) = rtrim(ltrim(@article))", sqlparams.ToArray()));
            }
            catch { return 0; }
        }

        public int CheckIncomeDocSameName(int Id, string Name)
        {
            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@id",SqlDbType.Int){Value = Id },
                new SqlParameter("@Name",SqlDbType.NVarChar){Value = Name }

            };

            try
            {
                return Convert.ToInt32(Helper.GetOneRecord("SELECT DISTINCT id from STO_StockInHead where id != @id and ltrim(rtrim(name)) = rtrim(ltrim(@name))", sqlparams.ToArray()));
            }
            catch { return 0; }
        }


        public string CheckMSL(int ArtId)
        {
            //Temporary not used!
            var param = new SqlParameter("@ArtId", SqlDbType.Int);
            param.Value = ArtId;
            string strSQL = "declare @rmt int " +
                " select top 1 @rmt = value from BAS_Defaults def where def.field = 'rmtype'" +
                " SELECT iif(isnull(rmt.IdTY, 0) = 0, '-99', isnull(msl, '0')) " +
	            " from bas_articles a " +
                " left join dbo.ifn_Types(@rmt)rmt on rmt.IdTY = a.TypeID " +
                " where a.id = @artid";
            try
            {
                return Convert.ToString(Helper.GetOneRecord(strSQL, param));
            }
            catch { return "0"; }
            //return "a";
        }


        public int ArticleId(string Article)
        {
            int _res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "select distinct id from bas_articles where article = @article";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlComm.Parameters.AddWithValue("@article", Article);
            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                _res = Convert.ToInt32(reader["id"]);
                reader.Close();
            }
            else
            {
                _res = 0;
            }
            sqlConn.Close();
            return _res;
        }

        public string Article(int ArtId)
        {
            string Res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT article FROM bas_articles WHERE id = " + ArtId;
            //MessageBox.Show(strSQL);
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                Res = sqlReader["article"].ToString();
            }
            sqlReader.Close();
            sqlConn.Close();
            return Res;
        }
        
        public string Firm(int FirmId)
        {
            string Res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT company as Firm FROM bas_companies WHERE id = " + FirmId;
            //MessageBox.Show(strSQL);
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                Res = sqlReader["Firm"].ToString();
            }
            sqlReader.Close();
            sqlConn.Close();
            return Res;
        }
        public string ImagePath(int ArtId)
        {
            string Res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT ImagePath as Path FROM bas_articles WHERE id = " + ArtId;
            //MessageBox.Show(strSQL);
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                Res = sqlReader["Path"].ToString();
                sqlConn.Close();
            }
            sqlReader.Close();

            return Res;
        }
        public string Unit(int UnitId)
        {
            string Res = "";
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT unit as Unit FROM BAS_Unit WHERE Id = " + UnitId;
            //MessageBox.Show(strSQL);
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                Res = sqlReader["Unit"].ToString();
                sqlReader.Close();
            }

            sqlConn.Close();
            return Res;
        }

        public bool CheckBanDate(string Date)
        {
            bool _res = false;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "set dateformat dmy select distinct dbo.fn_CheckBanDate('" + Date + "') as Res";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (Convert.ToInt32(reader["Res"]) == -1)
                    _res = true;
                reader.Close();
            }
            sqlConn.Close();
            return _res;
        }

        public int AddressCount(int FirmId)
        {
            int _res = 0;
            string strSQL = "select distinct count(FA_Id) as adrcount from PRI_FirmAdresses where FA_FirmId = " + FirmId.ToString();
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();

            SqlDataReader reader = sqlComm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                _res = Convert.ToInt32(reader["adrcount"]);
                reader.Close();
            }
            sqlConn.Close();

            return _res;
        }

        //select distinct 
        //    UserMail

        //    from STO_StockShelves
        //    inner join PRI_Comitee on SS_RespPersonId = CM_Id
        //    inner join pri_user on CM_TabNum = right(TabNr, len(TabNR) -1)

        public static DataTable getWeeks(string datefrom, string datetill)
        {
            string query = "set dateformat dmy select * from dbo.ifn_Weeks(convert(datetime, '" + datefrom + "'), convert(datetime, '" + datetill + "'))";


            return Helper.QueryDT(query);
        }

        public string AutoDoc(int Code, string Date)
        {
            string _res = "";

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "set dateformat dmy select dbo.fn_SelectAutoDocWithMonth(" + Code + ", convert(datetime, '" + Date + "')) as AutoDoc", conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _res = dr["AutoDoc"].ToString();                    
                }
            }

            return _res;
        }

        public string DefaultValue(string field)
        {
            string _res = "";

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "set dateformat dmy select dbo.fn_DefaultValue('" + field + "') as DefValue", conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _res = dr["DefValue"].ToString();
                }
            }

            return _res;
        }

        public bool IsUserInGroup(string userLogin, string userGroup)
        {
            var param = new SqlParameter("@UserLogin", SqlDbType.NVarChar) { Value = userLogin };
            var param2 = new SqlParameter("@UserGroup", SqlDbType.NVarChar) { Value = userGroup };
            var data = Helper.QueryDT("SELECT dbo.fn_IsUserOfGroup(@UserLogin, @UserGroup) AS InGroup", param, param2);
            bool isInGroup = false;
            if (data.Rows.Count > 0)
            {
                isInGroup = Convert.ToInt32(data.Rows[0]["InGroup"]) == -1;
            }

            return isInGroup;
        }
        #endregion

        #region DataMatrix

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public byte[] StringDataMatrixToByte(string Field)
        {
            DmtxImageEncoder encoder = new DmtxImageEncoder();
            DmtxImageEncoderOptions options = new DmtxImageEncoderOptions();
            options.ModuleSize = 8;
            options.MarginSize = 30;
            options.BackColor = Color.White;
            options.ForeColor = Color.Black;
            options.Scheme = DmtxScheme.DmtxSchemeAsciiGS1;

            Bitmap encodedBitmap = encoder.EncodeImage(Field, options);

            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(encodedBitmap, typeof(byte[]));
        }

        public byte[] LogoToByte()
        {
            string Path = Application.StartupPath + "\\" + Global_Resourses.LogoImageName;

            Image img = Image.FromFile(Path);

            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        //private void getImage()
        //{
        //    FileStream fs;
        //    fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "img\\cube.png", FileMode.Open);
        //    BinaryReader BinRed = new BinaryReader(fs);
        //    try
        //    {
        //        CreateTable();
        //        DataRow dr = this.DsImages.Tables["images"].NewRow();
        //        dr["image"] = BinRed.ReadBytes((int)BinRed.BaseStream.Length);
        //        this.DsImages.Tables["images"].Rows.Add(dr);

        //        //FilStr.Close();
        //        BinRed.Close();

        //        DynamicImageExample DyImg = new DynamicImageExample();
        //        DyImg.SetDataSource(this.DsImages);
        //        this.crystalReportViewer1.ReportSource = DyImg;
        //    }
        //    catch (Exception er)
        //    {
        //        MessageBox.Show(er.Message, "Error");
        //    }
        //}

        #endregion

        #region Current company
        
        public int CurrentCompanyId()
        {
            int Res = 0;
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "SELECT DISTINCT id FROM BAS_Companies WHERE usercomp = -1";
            //MessageBox.Show(strSQL);
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

            sqlConn.Open();
            SqlDataReader sqlReader = sqlComm.ExecuteReader();
            if (sqlReader.HasRows)
            {
                sqlReader.Read();
                Res = Convert.ToInt32(sqlReader["id"]);
                sqlReader.Close();
            }

            sqlConn.Close();
            return Res;
        }

        #endregion

        #region Reports

        public static DataTable getReportLabels(string _reportname, string _lang)
        {
            string query = "sp_SelectReportLabels";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@repname",SqlDbType.NVarChar, 50){Value = _reportname },
                new SqlParameter("@lang",SqlDbType.NVarChar, 5){Value = _lang }
            };

            return Helper.QuerySP(query, sqlparams.ToArray());
        }

        #endregion

        #region Custom codes

        public static DataTable getCustomCodes()
        {
            DataTable data = Helper.QueryDT("select * from (SELECT id as cid, code from bas_custcodes union select 0 as cid, '' as code) tab order by tab.code");
            
            return data;
        }

        #endregion

        #region Countries

        public static DataTable getCountries()
        {
            DataTable data = Helper.QueryDT("select * from (SELECT id as cid, country from bas_countries union select 0 as cid, '' as country) tab order by tab.country");

            return data;
        }

        #endregion

        #region Stock

        public double QtyStock(int ArtId)
        {

            double _QtyStock = 0;

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "execute sp_SelectStockTotals @artid = " + ArtId, conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _QtyStock = Convert.ToDouble(dr["qtyrest"]) + Convert.ToDouble(dr["notplaced"]) - Convert.ToDouble(dr["quarantine"]);
                }
            }

            return _QtyStock;
        }


        public bool CheckProduction(int placeid)
        {

            if ((Convert.ToInt32(Helper.GetOneRecord("select isnull(isproduction, 0) as isproduction from sto_shelves where id = " + placeid))) == -1)
                return true;
            else
                return false;

        }

        public bool CheckCostPrice(int idin)
        {

            if (Convert.ToInt32(Helper.GetOneRecord("select dbo.fn_CheckCostPrice(" + idin + ")")) == -1)
                return true;
            else
                return false;

        }

        public double ccpInPrice
        { get; set; }
        public double ccpCOPrice
        { get; set; }
        
        public bool CheckCostPriceTab(int idin)
        {
            int res = 0;

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "select * from dbo.ifn_CheckCostPrice(" + idin + ")", conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ccpInPrice = Convert.ToDouble(dr["inprice"]);
                    ccpCOPrice = Convert.ToDouble(dr["coprice"]);
                    res = Convert.ToInt32(dr["res"]);
                }
            }
            else
            {
                ccpInPrice = 0;
                ccpCOPrice = 0;
                res = -1;
            }

            if (res == -1)
                return true;
            else
                return false;

        }

        #endregion

        #region Printers

        public static string GetDefaultPrinterName()
        {
            String[] printers = PrinterSettings.InstalledPrinters.Cast<string>().ToArray();
            for (int i = 0; i < printers.Length; i++)
                if (new PrinterSettings() { PrinterName = printers[i] }.IsDefaultPrinter)
                    return printers[i];
            return null;
        }

        #endregion

        #region Batch Locks

        public string AddBatchLock(int BatchId, string FormName)
        {
            string _res = "";
            if (BatchId != 0)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                string strSQL = "DELETE FROM BAS_BatchLocks where batchid = " + BatchId + " and [user] = Current_User and formname = '" + FormName + "' " +
                                " SELECT DISTINCT TOP 1 [user] as [user] FROM BAS_BatchLocks where batchid = " + BatchId + " and [user] != Current_User";
                SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);

                sqlConn.Open();
                SqlDataReader reader = sqlComm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    //MessageBox.Show("Sorry somebody is working on this request for the moment!");
                    _res = reader["user"].ToString();
                    reader.Close();
                }
                else
                {
                    sqlConn.Close();
                    sqlConn.Open();

                    string strSQL1 = "INSERT INTO BAS_BatchLocks (batchid, [user], formname) values (" + BatchId + ", Current_User, '" + FormName + "')";
                    //MessageBox.Show("INSERTED!");

                    SqlCommand sqlComm1 = new SqlCommand(strSQL1, sqlConn);

                    sqlComm1.ExecuteNonQuery();
                    _res = "";

                }
                sqlConn.Close();

            }
            return _res;
        }
        public void DeleteBatchLock(int BatchId, string FormName)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "DELETE FROM BAS_BatchLocks where batchid = isnull(nullif(convert(int, " + BatchId + "), 0), batchid) and formname = '" + FormName + "' and user = current_user";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }
        public void DeleteBatchLockAll()
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "DELETE FROM BAS_BatchLocks where [user] = Current_User";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        #endregion
        #region Places&PCs

        public void MakeDefaultPlace(int PlaceId)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_MakePlaceByDefault", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;

            sqlComm.Parameters.AddWithValue("@id", PlaceId);
            sqlComm.Parameters.AddWithValue("@pcname", System.Environment.MachineName);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();


        }

        #endregion
    }
}
