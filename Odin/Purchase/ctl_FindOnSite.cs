using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Odin.Purchase
{
    public partial class ctl_FindOnSite : UserControl
    {
        public ctl_FindOnSite()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "CatalogImportResult.xls", this.Name);
        }

        #region variables
        DAL_Functions DAL = new DAL_Functions();
        Helper MyHelper = new Helper();
        class_Global glob_Class = new class_Global();
        ExportData ED;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";


        #endregion

        #region Arrow OAuth

        #region Arrow Class

        class openPrices
        {
            public string status { get; set; }
            public int requestedQuantity { get; set; }
            public int results { get; set; }
            public int pages { get; set; }
            public int totalRecords { get; set; }
            public int currentPage { get; set; }
            public int nextPageNumber { get; set; }
            public pricingResponse[] pricingResponse { get; set; }

        }

        class pricingResponse
        {
            public string responseState { get; set; }
            //public string itemId { get; set; }
            //public string warehouseId { get; set; }
            //public string warehouseCode { get; set; }
            //public string currency { get; set; }
            //public string documentId { get; set; }
            public string resalePrice { get; set; }
            public string fohQuantity { get; set; }
            //public string description { get; set; }
            public string partNumber { get; set; }
            //public string tariffApplicable { get; set; }
            //public string tariffValue { get; set; }
            //public string nextDelivery { get; set; }
            //public string nextQuantity { get; set; }
            public string minOrderQuantity { get; set; }
            //public string multOrderQuantity { get; set; }
            //public string manufacturer { get; set; }
            //public string supplier { get; set; }
            //public string htsCode { get; set; }
            //public string pkg { get; set; }
            //public int spq { get; set; }
            //public pricingTier[] pricingTier { get; set; }
            //public urlData[] urlData { get; set; }
            public leadTime leadTime { get; set; }
            //public arwPartNum arwPartNum { get; set; }
            //public suppPartNum suppPartNum { get; set; }
            //public string bufferQuantity { get; set; }
            //public string euRohs { get; set; }
            //public string chinaRohs { get; set; }
            //public bool quotable { get; set; }
            //public bool purchaseable { get; set; }
            //public bool arrowInitiated { get; set; }
            //public bool nonCancelableNonReturnable { get; set; }
            //public string taxonomy { get; set; }
            //public string partClassification { get; set; }
            //public string partBuyCurrency { get; set; }
            //public string exportControlClassificationNumberUS { get; set; }
            //public string exportControlClassificationNumberWAS { get; set; }
            //public string lifeCycleStatus { get; set; }
        }
        class customerPartData
        {
            public string approved { get; set; }
            public string customerPartNumber { get; set; }
            public string kanbanInd { get; set; }
            public string rank { get; set; }
            public string srvcType { get; set; }
        }
        class pricingTier
        {
            public string minQuantity { get; set; }
            public string maxQuantity { get; set; }
            public string resalePrice { get; set; }
        }
        class urlData
        {
            public string type { get; set; }
            public string value { get; set; }
        }
        class leadTime
        {
            public int supplierLeadTime { get; set; }
            public string supplierLeadTimeDate { get; set; }
            public int arrowLeadTime { get; set; }
        }
        class arwPartNum
        {
            public bool isExactMatch { get; set; }
            public string name { get; set; }
        }
        class suppPartNum
        {
            public bool isExactMatch { get; set; }
            public string name { get; set; }
        }

        #endregion

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

            string url = endCustomer != null
                ? string.Format(

                "https://my.arrow.com/api/priceandavail/cpns/{0}/parts/?currency={1}&pageNumber={2}&pageSize={3}&version={4}&endCustomer={5}",

                Uri.EscapeDataString(cpn),

                Uri.EscapeDataString(currency),

                Uri.EscapeDataString(pageNumber + ""),

                Uri.EscapeDataString(pageSize + ""),

                Uri.EscapeDataString(version),

                Uri.EscapeDataString(endCustomer)

                )
                : string.Format(

                "https://my.arrow.com/api/priceandavail/cpns/{0}/parts/?currency={1}&pageNumber={2}&pageSize={3}&version={4}",

                Uri.EscapeDataString(cpn),

                Uri.EscapeDataString(currency),

                Uri.EscapeDataString(pageNumber + ""),

                Uri.EscapeDataString(pageSize + ""),

                Uri.EscapeDataString(version));
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

        #endregion

        #region Controls

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (txt_PN.Text != "")
            {

                string str = "";
                str = searchPart(getToken(), txt_PN.Text, Convert.ToInt32(cmb_PageN.Text), Convert.ToInt32(txt_QtyOnPage.Text), Convert.ToInt32(txt_Qty.Text), "EUR");


                openPrices openPrices;

                openPrices = JsonConvert.DeserializeObject<openPrices>(str);

                //Filling the pages
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("PageN", typeof(string)));

                for (int i = 1; i <= openPrices.pages; i++)
                {
                    DataRow row = dt.NewRow();
                    row["PageN"] = i.ToString();
                    dt.Rows.Add(row);

                }
                cmb_PageN.DataSource = dt;
                cmb_PageN.DisplayMember = "PageN";

                ds_List.Clear();

                foreach (pricingResponse entry in openPrices.pricingResponse)
                {
                    DataRow row = dt_List.NewRow();

                    row["PartNum"] = entry.partNumber.ToString();
                    try
                    {
                        row["UnitPrice"] = Convert.ToDouble(entry.resalePrice.ToString());
                    }
                    catch { row["UnitPrice"] = 0; }
                    try
                    {
                        row["LeadTime"] = Convert.ToInt32(entry.leadTime.supplierLeadTime.ToString());
                    }
                    catch { row["LeadTime"] = 0; }
                    try
                    {
                        row["QtyOnStock"] = Convert.ToDouble(entry.fohQuantity.ToString());
                    }
                    catch { row["QtyOnStock"] = 0; }
                    try
                    {
                        row["MOQ"] = Convert.ToDouble(entry.minOrderQuantity.ToString());
                    }
                    catch { row["MOQ"] = 0; }



                    dt_List.Rows.Add(row);

                }

            }
        }

        #region Context menu


        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_List.ClearSelection();
                gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            //SetCellsColor();

        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_List;
            frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? String.IsNullOrEmpty(CellValue) == true
                        ? "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'"
                    : String.IsNullOrEmpty(CellValue) == true
                        ? bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            //SetCellsColor();

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'"
                    : bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }
        #endregion

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_PN.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Qty.Text = "1";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            row["PageN"] = "1";
            dt.Rows.Add(row);
            cmb_PageN.DataSource = dt;
            cmb_PageN.DisplayMember = "PageN";
        }

    }
}
