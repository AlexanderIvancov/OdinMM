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
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;

using System.Runtime.InteropServices;
using System.Diagnostics;
using Odin.Global_Classes;
using Odin.Register.Articles;

using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Net;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;
using AegisImplicitMail;
using System.Data;
using System.Data.SqlClient;
namespace Odin
{
    public partial class frm_Test : BaseForm
    {
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public frm_Test()
        {
            InitializeComponent();
            //ControlBox = false;
            //Text = "";

            //Color _mainFormBackColor = Color.FromArgb(125, 166, 226);
            //panel1.BackColor = _mainFormBackColor;

            //Color _selectedTabColor = Color.FromArgb(156, 221, 252);

            //panel2.BackColor = _selectedTabColor;

            //Color _TabColor = Color.FromArgb(168, 192, 234);

            //panel3.BackColor = _TabColor;
        }

        Helper MyHelper = new Helper();
        DAL_Functions DLL = new DAL_Functions();
        public int ControlWidth = 250;
        class_Global glob_Class = new class_Global();
        //private KryptonPage NewInputGeneral(string Article, int ArtId)
        //{
        //    //ctlGen = new ctl_General();
        //    //ControlWidth = ctlGen.Width;


        //    //ctlGen.cmb_Articles1.ArticleId = ArtId;
        //    ////ctlGen.SendArtId += new ArtIdSendingEventHandler(ChangeArtIdSelection);

        //    ////MessageBox.Show(ctl.Width.ToString());
        //    //return NewPage("General article", 1, ctlGen, ctlGen.Width);
        //}

        private KryptonPage NewPage(string name, int image, Control content, int _Width)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name;
            p.TextTitle = name;
            p.TextDescription = name;
            p.ImageSmall = imageListSmall.Images[image];

            //p.Width = _Width;

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);


            return p;
        }

        //public ctl_General ctlGen = null;

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var cell in kryptonDockingManager1.Cells)
            {
                //MessageBox.Show(cell.Width.ToString());
                cell.Width = 300;
                //cell.ResetPalette();
            }

            
           

            kryptonDockingManager1.ShowAllPages();
            
            //kryptonDockingManager1.RemoveAllPages(true);
            //this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.HideAllPages();
        }
        private void btn_General_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddDockspace("Control",
           //                                    DockingEdge.Left,
            //                                   new KryptonPage[] { NewInputGeneral("Article", 4) });
        }

        private void frm_Test_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(panel1, w);
            kryptonDockingManager1.ManageFloating(this);
        }

        private void frm_Test_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                
            }
                    
                    //{ kryptonDockableWorkspace1.; }
        }

        //static readonly HttpClient _client = new HttpClient();
        

        private static async Task<Token> GetElibilityToken(/*HttpClient client*/)
        {
            var _client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string baseAddress = @"https://my.arrow.com/api/security/oauth/token";

            string grant_type = "client_credentials";
            string client_id = "smd-baltic-sia";
            string client_secret = "X0Ix6bVXX7bSKvUvUVWgg8J0Hdp4sHaaKSwixcyGCr4Kj3EAbBEBFLu94rymJ9wI";

            var form = new Dictionary<string, string>
                {
                    {"grant_type", grant_type},
                    {"client_id", client_id},
                    {"client_secret", client_secret},
                };

            HttpResponseMessage tokenResponse = await _client.PostAsync(baseAddress, new FormUrlEncodedContent(form));
            var jsonContent = await tokenResponse.Content.ReadAsStringAsync();

            Token tok = JsonConvert.DeserializeObject<Token>(jsonContent);
            return tok;
        }


        internal class Token
        {
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("token_type")]
            public string TokenType { get; set; }

            [JsonProperty("expires_in")]
            public int ExpiresIn { get; set; }

            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }
        }

        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        //1st method
        //Task<Token> task = GetElibilityToken();
        //task.Wait();

        //var result = task.Result;
        //string S = result.AccessToken;

        //MessageBox.Show(S.ToString());

        //2nd method
        //https://my.arrow.com/api/security/oauth/token
        //client_credentials
        //PYpBP2jo
        //X0Ix6bVXX7bSKvUvUVWgg8J0Hdp4sHaaKSwixcyGCr4Kj3EAbBEBFLu94rymJ9wI
        //ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //string url = "https://my.arrow.com/api/security/oauth/token";
        //string data = "{\"client_id\":\"smd-baltic-sia\", \"client_secret\":X0Ix6bVXX7bSKvUvUVWgg8J0Hdp4sHaaKSwixcyGCr4Kj3EAbBEBFLu94rymJ9wI, \"grant_type\":client_credentials}";

        //WebRequest myReq = WebRequest.Create(url);
        //myReq.Method = "POST";
        //myReq.ContentLength = data.Length;
        //myReq.ContentType = "application/json; charset=UTF-8";
        //UTF8Encoding enc = new UTF8Encoding();
        //myReq.Headers.Remove("auth-token");
        //using (Stream ds = myReq.GetRequestStream())
        //{
        //    ds.Write(enc.GetBytes(data), 0, data.Length);
        //}
        //WebResponse wr = myReq.GetResponse();
        //Stream receiveStream = wr.GetResponseStream();
        //StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
        //string content = reader.ReadToEnd();
        ////Response.Write(content);
        //MessageBox.Show(content);

        //3rd methods using restsharp

        //"multipart/form-data"/*

        //ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //var client = new RestClient("https://my.arrow.com/api/security/oauth/token");
        //var request = new RestRequest(Method.POST);

        //request.AddHeader("cache-control", "no-cache");
        //request.AddHeader("content-type", "application/x-www-form-urlencoded");
        //request.AddParameter("application/x-www-form-urlencoded", "grant_type=client_credentials&client_id=smd-baltic-sia&client_secret=X0Ix6bVXX7bSKvUvUVWgg8J0Hdp4sHaaKSwixcyGCr4Kj3EAbBEBFLu94rymJ9wI", ParameterType.RequestBody);

        //IRestResponse response = client.Execute(request);

        //dynamic resp = JObject.Parse(response.Content);
        //String token = resp.access_token;

        //client = new RestClient("https://xxx.xxx.com/services/api/x/users/v1/employees");
        //request = new RestRequest(Method.GET);
        //request.AddHeader("authorization", "Bearer " + token);
        //request.AddHeader("cache-control", "no-cache");
        //response = client.Execute(request);

        //MessageBox.Show(response.Content);

        private void btn_Test_Click(object sender, EventArgs e)
        {
            //JObject joResponse = JObject.Parse(searchPart(getToken(), "AON7418", 2, 2, 100, "EUR"));

            //string _price = (String)joResponse["access_token"];

            //MessageBox.Show(_price);

            //txt_Test.Text = searchPart(getToken(), txt_PN.Text, Convert.ToInt32(txt_PageN.Text), Convert.ToInt32(txt_QtyOnPage.Text), Convert.ToInt32(txt_Qty.Text), "EUR");

            string emailaddresses = "jarett@inbox.ru; p.levins@smd-baltic.lv";

            string strMessage = "Test for direct message!";
            MyHelper.SendDirectEMail(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Test message!", strMessage);
        }

        #region Arrow OAuth

        public const String version = "3";

        public const String clientId = "smd-baltic-sia";

        public const String clientSecret = "X0Ix6bVXX7bSKvUvUVWgg8J0Hdp4sHaaKSwixcyGCr4Kj3EAbBEBFLu94rymJ9wI";

        public String getToken()
        {

            String token = "";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            // Create a request using a URL that can receive a post.  

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://my.arrow.com/api/security/oauth/token");

            request.ServicePoint.Expect100Continue = false;

            //request.Credentials = new NetworkCredential(userName, passWord);

            string toEncode = clientId + ":" + clientSecret;

            byte[] toEncodeInBytes = Encoding.UTF8.GetBytes(toEncode);

            string encoded = Convert.ToBase64String(toEncodeInBytes);

            // Set the Method property of the request to POST. 

            request.Method = "POST";



            request.Accept = "*/*";

            request.ContentType = "application/x-www-form-urlencoded";

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:69.0) Gecko/20100101 Firefox/69.0";

            // Create POST data and convert it to a byte array. 

            request.Headers.Add("Authorization",

                "Basic " + encoded);



            request.Headers.Add("client_id", clientId);

            // Set the ContentLength property of the WebRequest. 

            string postData = "grant_type=client_credentials";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            request.ContentLength = byteArray.Length;



            // Get the request stream. 

            Stream dataStream = request.GetRequestStream();

            // Write the data to the request stream. 



            dataStream.Write(byteArray, 0, byteArray.Length);

            // Close the Stream object. 

            //dataStream.Flush();

            dataStream.Close();

            // Get the response.

            try

            {

                WebResponse response = request.GetResponse();

                // Display the status. 

                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();



                JObject joResponse = JObject.Parse(responseString);

                token = (String)joResponse["access_token"];

                // Close the response. 

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

                        Console.WriteLine(text);

                    }

                }

            }

            return token;

        }

        private String getCPNURL(String cpn, int pageNumber, int pageSize, String currency, String endCustomer, String version)
        {

            String url = "";

            if (endCustomer != null)
            {

                url = string.Format(

                "https://my.arrow.com/api/priceandavail/cpns/{0}/parts/?currency={1}&pageNumber={2}&pageSize={3}&version={4}&endCustomer={5}",

                Uri.EscapeDataString(cpn),

                Uri.EscapeDataString(currency),

                Uri.EscapeDataString(pageNumber + ""),

                Uri.EscapeDataString(pageSize + ""),

                Uri.EscapeDataString(version),

                Uri.EscapeDataString(endCustomer)

                );

            }
            else
            {



                url = string.Format(

                "https://my.arrow.com/api/priceandavail/cpns/{0}/parts/?currency={1}&pageNumber={2}&pageSize={3}&version={4}",

                Uri.EscapeDataString(cpn),

                Uri.EscapeDataString(currency),

                Uri.EscapeDataString(pageNumber + ""),

                Uri.EscapeDataString(pageSize + ""),

                Uri.EscapeDataString(version));

            }

            return url;



        }

        public String searchPart(String accessToken, String search, int pageNumber, int pageSize, int quantity, String currency)
        {

            String responseString = "";



            String url = string.Format(

            "https://my.arrow.com/api/priceandavail/parts?currency={0}&pageNumber={1}&pageSize={2}&search={3}&quantity={4}&version={5}",

            Uri.EscapeDataString(currency),

            Uri.EscapeDataString(pageNumber + ""),

            Uri.EscapeDataString(pageSize + ""),

            Uri.EscapeDataString(search + ""),

            Uri.EscapeDataString(quantity + ""),

            Uri.EscapeDataString(version));

            // Create a request using a URL that can receive a post.  

            Console.WriteLine("URL:" + url);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // Set the Method property of the request to POST. 

            request.Method = "GET";



            request.Accept = "*/*";

            request.ContentType = "application/x-www-form-urlencoded";

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:69.0) Gecko/20100101 Firefox/69.0";

            // Create POST data and convert it to a byte array. 

            request.Headers.Add("Authorization",

                "Bearer" + accessToken);



            request.Headers.Add("client_id", clientId);

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

                        Console.WriteLine(text);

                    }

                }

            }

            return responseString;

        }

        public String searchPartByCPN(String accessToken, String cpn, int pageNumber, int pageSize, String currency, String endCustomer)
        {

            String responseString = "";



            String url = getCPNURL(cpn, pageNumber, pageNumber, currency, endCustomer, version);

            // Create a request using a URL that can receive a post.  

            Console.WriteLine("URL:" + url);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // Set the Method property of the request to POST. 

            request.Method = "GET";



            request.Accept = "*/*";

            request.ContentType = "application/x-www-form-urlencoded";

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:69.0) Gecko/20100101 Firefox/69.0";

            // Create POST data and convert it to a byte array. 

            request.Headers.Add("Authorization",

                "Bearer" + accessToken);



            request.Headers.Add("client_id", clientId);



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

                        Console.WriteLine(text);

                    }

                }

            }

            return responseString;

        }
        
        public String searchPartByDocId(String accessToken, String docId, String currency)
        {

            String responseString = "";



            String url = string.Format(

            "https://my.arrow.com/api/priceandavail/parts/{0}?currency={1}&version={2}",

            Uri.EscapeDataString(docId),

            Uri.EscapeDataString(currency),

            Uri.EscapeDataString(version));

            // Create a request using a URL that can receive a post.  

            Console.WriteLine("URL:" + url);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            // Set the Method property of the request to POST. 

            request.Method = "GET";



            request.Accept = "*/*";

            request.ContentType = "application/x-www-form-urlencoded";

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:69.0) Gecko/20100101 Firefox/69.0";

            // Create POST data and convert it to a byte array. 

            request.Headers.Add("Authorization",

                "Bearer" + accessToken);



            request.Headers.Add("client_id", clientId);

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

                        Console.WriteLine(text);

                    }

                }

            }

            return responseString;

        }

        private void kryptonLabel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Send_Click(object sender, EventArgs e)
        {
            SendDirectEMail(txt_Recepient.Text, "Test message", "Test message");
        }

        public void SendDirectEMail(string To, string Subject, string Message)
        {

            string From = txt_email.Text;

            if (String.IsNullOrEmpty(To))
            {
                MessageBox.Show("Missing recipient address.", "Email Error");
                return;
            }
           
            if (String.IsNullOrEmpty(From))
            {
                MessageBox.Show("Missing sender address.", "Email Error");
                return;
            }

            if (String.IsNullOrEmpty(Subject))
            {
                MessageBox.Show("Missing subject line.", "Email Error");
                return;
            }

            if (String.IsNullOrEmpty(Message))
            {
                MessageBox.Show("Missing message.", "Email Error");
                return;
            }
            _from = From;
            _to = To;
            _subject = Subject;
            _message = Message;
            var mail = From;
            var host = txt_SMTP.Text;

            var user = txt_email.Text;
            var pass = txt_PWD.Text;
            //MessageBox.Show(pass);

            //Generate Message 
            var mymessage = new MimeMailMessage();
            mymessage.From = new MimeMailAddress(mail);


            mymessage.To.Add(To);

            mymessage.Subject = Subject;
            mymessage.IsBodyHtml = true;
            mymessage.Headers.Add("Content-type", "text/html; charset=utf-8");
            //mymessage.Body = frmMail.Message;



            string[] arr = Message.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string _tmpmessage = arr.FirstOrDefault();

            for (int i = 1; i < arr.Length; i++)
            {
                _tmpmessage = _tmpmessage + "<br>" + arr[i].ToString();
            }

            mymessage.Body = "<html>" +
                        "<body>" +
                        _tmpmessage +
                        "</body>" +
                        "</html>";


            //MimeAttachment attachment;

            //string[] arr1 = frmMail.Attachments.Split(';');

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (!String.IsNullOrEmpty(arr1[i].ToString().Trim()))
            //    {
            //        attachment = new MimeAttachment(arr1[i].ToString().Trim());
            //        mymessage.Attachments.Add(attachment);
            //    }
            //}

            //Create Smtp Client
            var mailer = new MimeMailer(host, 465);

            mailer.User = user;
            mailer.Password = pass;
            mailer.SslType = SslMode.Ssl;
            mailer.AuthenticationMode = AuthenticationType.Base64;

            //Set a delegate function for call back
            mailer.SendCompleted += compEvent;
            mailer.SendMailAsync(mymessage);
        }

        public void compEvent(object sender, AsyncCompletedEventArgs e)
        {
            //AddMailLog(_from, _to, _subject, _message, e.Cancelled == true ? "Cancelled" : (e.Error != null ? "Error : " + e.Error.Message : "Mail sent"));
            if (e.UserState != null)
                Console.Out.WriteLine(e.UserState.ToString());

            Console.Out.WriteLine("is it canceled? " + e.Cancelled);

            if (e.Error != null)
                MessageBox.Show("Error : " + e.Error.Message + ", UserState = " + e.UserState.ToString());
            //Console.Out.WriteLine("Error : " + e.Error.Message);
        }

        private void compEvent1(object sender, AsyncCompletedEventArgs e)
        {
            if (e.UserState != null)
                MessageBox.Show(e.UserState.ToString());
                //Console.Out.WriteLine(e.UserState.ToString());
            //Console.Out.WriteLine("is it canceled? " + e.Cancelled);
            if (e.Error != null)
                MessageBox.Show("Error : " + e.Error.Message + ", UserState = " + e.UserState.ToString());
            else
                MessageBox.Show("Success!");
        }

        string _from = "";
        string _to = "";
        string _subject = "";
        string _message = "";

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            string strSQL = "select distinct email from bas_users where isactive = -1 and isnull(email, '') != '' order by surname ";
            SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            
            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    MyHelper.SendDirectEMail(reader["email"].ToString(), "Test message", "Test message");
                }
                reader.Close();
            }

            sqlConn.Close();
        }

        public void TestConnection()
        {
                                
            var host = txt_SMTP.Text;
            var user = txt_email.Text;
            var pass = txt_PWD.Text;

            var mailer = new MimeMailer(host, 465, user, pass)
            {
                Timeout = 500,
                SslType = _mode,//SslMode.Auto,
                AuthenticationMode = AuthenticationType.Base64,
            };
            mailer.SendCompleted += compEvent1;
            mailer.TestConnection();
        }

        AegisImplicitMail.SslMode _mode
        {
            get {
                if (rb_Auto.Checked == true)
                    return SslMode.Auto;
                else if (rb_Ssl.Checked == true)
                    return SslMode.Ssl;
                else if (rb_Tls.Checked == true)
                    return SslMode.Tls;
                else
                    return SslMode.None;

            }
        }

        private void btn_TextConnection_Click(object sender, EventArgs e)
        {
            TestConnection();
        }


        #endregion

        //protected override void WndProc(ref Message message)
        //{
        //    const int WM_NCHITTEST = 0x0084;

        //    if (message.Msg == WM_NCHITTEST)
        //    {
        //        return;
        //    }

        //    base.WndProc(ref message);
        //}
    }

}
