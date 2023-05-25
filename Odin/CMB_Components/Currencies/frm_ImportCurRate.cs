using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;
using System.Xml.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Odin.CMB_Components.Currencies
{
    public delegate void CurRateSavingEventHandler(object sender);
    public partial class frm_ImportCurRate : KryptonForm
    {
        private ProgressForm progress;
        private DateTime dateCurrency = new DateTime();
        private DateTime dateCurrencyTill = new DateTime();

        //public class Root
        //{
        //   public Rate[] rates { get; set; }
        //}
        //public class Root
        //{
            
        //    //public List<Rate> rate { get; set; }
        //}

        //public class Rate
        //{
        //    public int Cur_ID { get; set; }
        //    public DateTime Date { get; set; }
        //    public string Cur_Abbreviation { get; set; }
        //    public int Cur_Scale { get; set; }
        //    public string Cur_Name { get; set; }
        //    public decimal? Cur_OfficialRate { get; set; }
        //}

        public class Rate
        {
            public int Cur_ID { get; set; }
            public DateTime Date { get; set; }
            public string Cur_Abbreviation { get; set; }
            public int Cur_Scale { get; set; }
            public string Cur_Name { get; set; }
            public double Cur_OfficialRate { get; set; }
        }

        //public class Root
        //{
        //    public int Cur_ID { get; set; }
        //    public DateTime Date { get; set; }
        //    public string Cur_Abbreviation { get; set; }
        //    public int Cur_Scale { get; set; }
        //    public string Cur_Name { get; set; }
        //    public double Cur_OfficialRate { get; set; }
        //}

        public frm_ImportCurRate()
        {
            InitializeComponent();
        }
        DAL_Functions BLL = new DAL_Functions();

        public event CurRateSavingEventHandler RateSaving;

        private void frm_ImportCurRate_Load(object sender, EventArgs e)
        {
            progress = new ProgressForm(this);
            dt_CurDate.Value = System.DateTime.Now;
            dt_CurDateTill.Value = System.DateTime.Now;
            dateCurrency = dt_CurDate.Value;
            dateCurrencyTill = dt_CurDateTill.Value;
        }

        private void dt_CurDate_ValueChanged(object sender, EventArgs e)
        {
            dateCurrency = dt_CurDate.Value;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            progress.bwStart(bw_OperationsBY);
        }

        private void bw_Operations(object sender, DoWorkEventArgs e)
        {
            gv_Info.ThreadSafeCall(delegate
            {
                gv_Info.Rows.Clear();
            });

            for (DateTime dateCurrency1 = dateCurrency; dateCurrency1 <= dateCurrencyTill.AddDays(1); dateCurrency1 = dateCurrency1.AddDays(1))
            {
                //System.Net.WebProxy pry = new System.Net.WebProxy(global::Odin.Global_Resourses.ProxyIP/*"192.168.10.5"*/, 8080);
                ////The DefaultCredentials automically get username and password.
                //pry.Credentials = CredentialCache.DefaultCredentials;
                //GlobalProxySelection.Select = pry;

                dateCurrency = dateCurrency1.AddDays(-1);

                var stringMonth = dateCurrency.Month.ToString();
                //adds zero to the month
                if (/*dt_CurDate.Value.Month < 10*/dateCurrency.Month < 10)
                {
                    stringMonth = "0" + dateCurrency.Month;
                }

                var stringDay = dateCurrency.Day.ToString();
                //adds zero to the day
                if (dateCurrency.Day < 10)
                {
                    stringDay = "0" + dateCurrency.Day;
                }


                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                WebClient client = new WebClient();
                string downloadString = client.DownloadString("https://www.bank.lv/vk/ecb.xml?date=" +
                    dateCurrency.Year + stringMonth + stringDay);

                var cRateString = "<CRates";

                int indexRate = downloadString.IndexOf(cRateString);
                var begingStr = downloadString.Substring(0, indexRate + cRateString.Length) + ">";
                int indexDate = downloadString.IndexOf("<Date>");
                var endStr = downloadString.Substring(indexDate, downloadString.Length - indexDate);

                var xmlString = begingStr + endStr;


                XDocument xmlDocument = XDocument.Parse(xmlString);

                var data = from d in xmlDocument.Descendants("Currency")
                           select new
                           {
                               CurrencyName = d.Element("ID").Value,
                               Rate = d.Element("Rate").Value
                           };

                gv_Info.ThreadSafeCall(delegate
                {

                    foreach (var row in data.ToList())
                    {
                        var shortDate = dateCurrency.AddDays(1).ToShortDateString(); //dt_CurDate.Value.ToShortDateString();//
                        var curName = DAL_Functions.SelectCurrencyByName(row.CurrencyName);
                        if (curName.Rows.Count == 1)
                        {
                            DAL_Functions.AddCurrencyRate(curName.Rows[0].Field<int>("id"),
                                shortDate, Convert.ToDouble(row.Rate), 1);
                            gv_Info.Rows.Add("Added data. Currency:" + row.CurrencyName + ", date: " + shortDate +
                                         ", rate: " + row.Rate + ", coef: " + 1);
                        }
                        else
                        {
                            gv_Info.Rows.Add("Currency was not found:" + row.CurrencyName);
                        }

                    }
                });
            }
            if (RateSaving != null)
                RateSaving(this);
        }

        private void bw_OperationsBY(object sender, DoWorkEventArgs e)
        {
            gv_Info.ThreadSafeCall(delegate
            {
                gv_Info.Rows.Clear();
            });

            for (DateTime dateCurrency1 = dateCurrency; dateCurrency1 <= dateCurrencyTill.AddDays(1); dateCurrency1 = dateCurrency1.AddDays(1))
            {
                dateCurrency = dateCurrency1.AddDays(-1);

                //String responseString = "";


                //String url = string.Format(

                //"https://www.nbrb.by/api/exrates/rates?ondate={0}&periodicity={1}",

                //Uri.EscapeDataString(dateCurrency.Year + "-" + dateCurrency.Month + "-" + dateCurrency.Day),

                //Uri.EscapeDataString(0 + ""));
                gv_Info.ThreadSafeCall(delegate
                {
                    ImportCurrencyBY(dateCurrency);
                });
                //MessageBox.Show(url);
            }
            if (RateSaving != null)
                RateSaving(this);
        }

        private void frm_ImportCurRate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RateSaving != null)
                RateSaving(this);
        }

        private void dt_CurDateTill_ValueChanged(object sender, EventArgs e)
        {
            if (dt_CurDateTill.Value > System.DateTime.Now)
                dt_CurDateTill.Value = System.DateTime.Now;
            dateCurrencyTill = dt_CurDateTill.Value;
        }

        public int SelectCurrencyByName(string CurName)
        {
            //return QueryDT(string.Format("SELECT CU_Id, CU_Name, CU_Description FROM PRI_Currency WHERE CU_Name = '{0}'", CurName));
            return Convert.ToInt32(Helper.GetOneRecord(string.Format("SELECT id FROM BAS_Currency WHERE currency = '{0}'", CurName)));
        }

        public String searchCurrency(DateTime OnDate, int Periodicity)
        {

            String responseString = "";


            String url = string.Format(

            "https://www.nbrb.by/api/exrates/rates?ondate={0}&periodicity={1}",

            Uri.EscapeDataString(OnDate.Year + "-" + OnDate.Month + "-" + OnDate.Day),

            Uri.EscapeDataString(Periodicity + ""));

            // Create a request using a URL that can receive a post.  

            gv_Info.Rows.Add(url);
            //Console.WriteLine("URL:" + url);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // Set the Method property of the request to POST. 

            request.Method = "GET";
           
            request.Accept = "*/*";

            request.ContentType = "application/x-www-form-urlencoded";

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:69.0) Gecko/20100101 Firefox/69.0";

            // Create POST data and convert it to a byte array. 

            /*request.Headers.Add("Authorization",

                "Bearer" + accessToken);
            
            request.Headers.Add("client_id", clientId);*/

            // Get the response.

            try

            {

                WebResponse response = request.GetResponse();

                // Display the status. 

                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


                //Console.WriteLine("Response:" + responseString);

                response.Close();

            }

            catch (WebException e)

            {

                using (WebResponse response = e.Response)

                {

                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    Console.WriteLine("Error code: {0}", httpResponse.StatusCode);

                    using (Stream data = response.GetResponseStream())

                    using (var reader = new StreamReader(data))

                    {

                        string text = reader.ReadToEnd();

                        MessageBox.Show(text);

                    }

                }

            }

            return responseString;

        }

        public void ImportCurrencyBY(DateTime onDate)
        {
            //string json =
            //    @"[{""Cur_ID"":145,""Date"":""2016 - 07 - 06T00: 00:00"",""Cur_Abbreviation"":""USD"",""Cur_Scale"":1,""Cur_Name"":""Доллар США"",""Cur_OfficialRate"":2.0048},{""Cur_ID"":292,""Date"":""2016 - 07 - 06T00: 00:00"",""Cur_Abbreviation"":""EUR"",""Cur_Scale"":1,""Cur_Name"":""Евро"",""Cur_OfficialRate"":2.2354}]";

            int curid = 0;
            string str = "";

            
            str = searchCurrency(onDate, 0);


            //Currencies rates;

            //Currencies CurrencyRates = JsonConvert.DeserializeObject<Currencies>(str);

            //Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(str);

            var myDeserializedClass = JsonConvert.DeserializeObject<List<Rate>>(str);

            foreach (var item in myDeserializedClass)
            {
                var shortDate = onDate.Date.AddDays(0).ToShortDateString();//item.Date.AddDays(1).ToShortDateString(); 
                curid = SelectCurrencyByName(item.Cur_Abbreviation);
                if (curid != 0)
                {
                    DAL_Functions.AddCurrencyRate(curid,
                        shortDate, Convert.ToDouble(item.Cur_OfficialRate / Convert.ToDouble(item.Cur_Scale)), item.Cur_Scale);
                    gv_Info.Rows.Add("Added data. Currency:" + item.Cur_Abbreviation + ", date: " + shortDate.ToString() +
                                         ", rate: " + item.Cur_OfficialRate / Convert.ToDouble(item.Cur_Scale) + ", coef: " + item.Cur_Scale);
                }
                else
                {
                    gv_Info.Rows.Add("Currency was not found:" + item.Cur_Name);
                }
            }

        }

    }
}
