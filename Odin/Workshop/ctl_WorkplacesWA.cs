using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Odin.Global_Classes;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using Odin.Tools;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;

namespace Odin.Workshop
{
    public delegate void SaveWorkplacesWAEventHandler(object sender);

    public partial class ctl_WorkplacesWA : UserControl
    {
        public ctl_WorkplacesWA()
        {
            InitializeComponent();
        }

        #region Variables


        //public event SaveWorkplacesEventHandler WorkplaceSaving;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        Processing_BLL BLL = new Processing_BLL();
        class_Global globClass = new class_Global();
        public string MEndpoint = global::Odin.Global_Resourses.BadgeAddress.ToString();
        public string MImport = global::Odin.Global_Resourses.BadgeImportItem.ToString();
        public string BadgeAccount = global::Odin.Global_Resourses.BadgeAccount.ToString();
        public string BadgePassword = global::Odin.Global_Resourses.BadgePassword.ToString();


        public ctl_WorkplaceWA ctl_WP = null;

        public int ControlWidth = 340;

        #endregion

        #region Badge Class

        class data
        {
            public string roleCode { get; set; }
            public string userName { get; set; }
            public string token { get; set; }
        }

        class response
        {
            public bool success { get; set; }
            public int code { get; set; }
            public data data { get; set; }
        }

        public class LaunchInfo
        {
            public string ESL_BARCODE { get; set; }
            public string COMM_BARCODE { get; set; }
            public string ADDRESS { get; set; }
            public string TABLE { get; set; }
            public string LAUNCH { get; set; }
            public string ART_ID { get; set; }
            public string ART_NAME { get; set; }

            public LaunchInfo(string esl_barcode, string comm_barcode, string address, string table, string launch, string art_id, string art_name)
            {
                ESL_BARCODE = esl_barcode;
                COMM_BARCODE = comm_barcode;
                ADDRESS = address;
                TABLE = table;
                LAUNCH = launch;
                ART_ID = art_id;
                ART_NAME = art_name;
            }
        }

        public class label
        {
            public string attrCategory { get; set; }
            public string attrName { get; set; }
            public string barCode { get; set; }
            public string itemTitle { get; set; }
            public string custFeature1 { get; set; }
            public string custFeature2 { get; set; }
            public string custFeature3 { get; set; }

            public label(string _attrCategory, string _attrName, string _barCode, string _itemTitle, string _custFeature1, string _custFeature2, string _custFeature3)
            {
                attrCategory = _attrCategory;
                attrName = _attrName;
                barCode = _barCode;
                itemTitle = _itemTitle;
                custFeature1 = _custFeature1;
                custFeature2 = _custFeature2;
                custFeature3 = _custFeature3;
            }
        }

        #endregion

        #region Methods


        public void FillWorktables(int _roomid)
        {
            //ScrollPosition = panel.AutoScrollPosition;
            //int _controlscroll = 0;
           
            //MessageBox.Show(ScrollPosition.X.ToString());
            //Clear old controls
            RemoveControls(this, typeof(ctl_WorkplaceWA));

            //Fill new

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectWorktablesWA", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@roomid", _roomid);

            sqlConn.Open();

            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows == true)
            {
                //int _count = reader.RecordsAffected;
                int _h = 8; //Start horizontal
                int _interval = 8;//Interval
                int _v = 8; //Start of vertical
                int _count = 0;
                while (reader.Read())
                {
                    ctl_WP = new ctl_WorkplaceWA();

                    ctl_WP.ID = Convert.ToInt32(reader["id"]);
                    ctl_WP.LaunchID = Convert.ToInt32(reader["launchid"]);
                    ctl_WP.Workplace = reader["workplace"].ToString();
                    ctl_WP.WorkPlaceID = Convert.ToInt32(reader["workplaceid"]);
                    ctl_WP.WorkerId = Convert.ToInt32(reader["workerid"]);
                    ctl_WP.WorkDate = reader["workdate"].ToString();
                    ctl_WP.ESL_Barcode = reader["esl_barcode"].ToString();
                    ctl_WP.COMM_Barcode = reader["comm_barcode"].ToString();
                    ctl_WP.Room = cmb_Rooms1.Room;
                    ctl_WP.FullTime = Convert.ToInt32(reader["fullwork"]);
                    ctl_WP.WorkMinutes = Convert.ToInt32(reader["workhours"]);

                    ctl_WP.Location = new Point(_h, _v);
                    _h = _h + ctl_WP.Width + _interval;

                    _count++;
                    if (_count % cmb_Rooms1.TabCol == 0)
                    {
                        _v = _v + ctl_WP.Height + _interval;
                        _h = 8;
                    }
                                       
                    panel.Controls.Add(ctl_WP);
                       
                }
                reader.Close();
            }

            sqlConn.Close();
            //panel.AutoScrollPosition = new Point(-1 * ScrollPosition.X, ScrollPosition.Y);
        }

        private void RemoveControls(Control control, Type type)
        {
            List<Control> controls = new List<Control>();
            Stack<Control> stack = new Stack<Control>();
            stack.Push(control);
            while (stack.Count > 0)
                foreach (Control child in stack.Pop().Controls)
                    if (child.GetType() == type)
                        controls.Add(child);
                    else
                        if (true == child.HasChildren)
                        stack.Push(child);

            foreach (Control ctrl in controls)
            {
                control.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }

        public void SyncronizeData(string tokenRequestURI, bool isempty)
        {
            String token = "";

            HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create(MEndpoint + tokenRequestURI);

            tokenRequest.Headers.Add("Language", "en");

            tokenRequest.ContentType = "application/json";
            tokenRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(tokenRequest.GetRequestStream()))
                {                   

                    string json = "{\"account\":" + JsonConvert.SerializeObject(BadgeAccount) + "," +
                                 "\"password\":" + JsonConvert.SerializeObject(BadgePassword) + ", " +
                                 "\"loginType\":\"3\"}";

                    streamWriter.Write(json);
                }
            }
            catch { MessageBox.Show("Error during request!!!"); }

            WebResponse tokenResponse = tokenRequest.GetResponse();

            var responseString = new StreamReader(tokenResponse.GetResponseStream()).ReadToEnd();

            response Response = JsonConvert.DeserializeObject<response>(responseString);
                       
            token = Response.data.token; 

            List<LaunchInfo> lst1 = new List<LaunchInfo>();

            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl.GetType() == typeof(ctl_Workplace))
                {
                    ctl_Workplace ctl = ctrl as ctl_Workplace;
                    //if (ctl.cmb_Launches1.Launch != ""
                    //    && ctl.txt_Article.Text != "")
                    lst1.Add(new LaunchInfo(ctl.ESL_Barcode, ctl.COMM_Barcode, ctl.Room, ctl.Workplace, isempty == false? ctl.cmb_Launches1.Launch : "", ctl.txt_Article.Text, ctl.txt_CustArticle.Text));
                }
            }
            

            setLaunch(lst1, token, MImport);

            //foreach (LaunchInfo info in lst1)
            //{
            //    MessageBox.Show(info.Room);
            //}

        }

        public void setLaunch(List<LaunchInfo> Launches, string token, string url)
        {
            List<label> itemList = new List<label>();
            foreach (LaunchInfo info in Launches)
            {
                //MessageBox.Show(info.COMM_BARCODE);
                itemList.Add(new label(info.LAUNCH.Trim() == ""? "empty" : "launch", info.LAUNCH.Trim() == "" ? "empty" : "launch", info.COMM_BARCODE, info.ADDRESS  + " / " + info.TABLE, info.LAUNCH, info.ART_ID, info.ART_NAME));
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(MEndpoint + url);

            request.Headers.Add("Language", "en");
            request.Headers.Add("Authorization", token);

            request.ContentType = "application/json";
            request.Method = "POST";
                   

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"agencyId\":\"1597317958637\"," +
                              "\"merchantId\":\"1690197501808\", " +
                              "\"itemList\":" + JsonConvert.SerializeObject(itemList) + "}"
            ;
                
                streamWriter.Write(json);
            }
          

            WebResponse response = request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            response Response = JsonConvert.DeserializeObject<response>(responseString);

            string _message = Response.success.ToString();
            //MessageBox.Show(_message);

        }

        //public const String version = "3";
        //public const String ENDPOINT = "http://192.168.10.162/zk/";
        //public const String ACCOUNT = "SuperMerchant";
        //public const String PASSWORD = "KW+PeT7f9KdwsZj/oSsrVf6fQyP5ZCi5ARURvYLw0IK1zT3sij3oGCU68ka7oLH16CJrDVToj3kqeokoOWG4d0pIFKgAtIWGt/0mtJnL+62difES0FzylTCQguEw2pHQ34EWk4Z0ukRZB4A+DiJSaIixrjePkm5Bypcb0pF96yY=";
        //public const long AGENCY_ID = 1597317958637;
        //public const long MERCHANT_ID = 1690197501808;
        //public const String clientId = "smd-baltic-sia";

        //public const String clientSecret = "X0Ix6bVXX7bSKvUvUVWgg8J0Hdp4sHaaKSwixcyGCr4Kj3EAbBEBFLu94rymJ9wI";

        /*
         def request(url_data, headers, json_data):
            try:
                response = requests.post(f'{ENDPOINT}{url_data}', headers=headers, json=json_data).json()
                return response
            except:
                return False

        def getToken():
            url_data = 'user/login'
            headers = { 'Language': 'en' }
            json_data = { 'account': ACCOUNT, 'password': PASSWORD, 'loginType': 3 }
            response = request(url_data, headers, json_data)
            if response.get('success'):
                return response.get('data').get('token')
            else:
                return False
             
             */



        //public void setLaunch(commBarcodeList, addressList, tableList, launchList, artIDList, artNameList)
        //{

        //}


        #endregion

        #region Controls

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillWorktables (cmb_Rooms1.RoomId);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            foreach (var ctl in panel.Controls)
            {
                if (ctl.GetType() == typeof(ctl_Workplace))
                {
                    ctl_WorkplaceWA ctlWP = ctl as ctl_WorkplaceWA;
                    BLL.SaveWorkplaceWA(ctlWP.ID, ctlWP.WorkPlaceID, ctlWP.LaunchID, ctlWP.WorkerId, ctlWP.FullTime, ctlWP.WorkDate, ctlWP.WorkMinutes);
                }
            }

            //SyncronizeData("user/login", false);            
          
        }
              
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (var ctl in panel.Controls)
            {
                if (ctl.GetType() == typeof(ctl_WorkplaceWA))
                {
                    ctl_WorkplaceWA ctlWP = ctl as ctl_WorkplaceWA;
                    ctlWP.ClearFields();
                }                  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(getToken());
        }

        private void cmb_Rooms1_RoomsChanged(object sender)
        {
            FillWorktables(cmb_Rooms1.RoomId);
        }


        #endregion

        private void btn_Syncronyze_Click(object sender, EventArgs e)
        {
            SyncronizeData("user/login", true);
            SyncronizeData("user/login", false);
        }

        private void ctl_WorkplacesWA_Load(object sender, EventArgs e)
        {
            FillWorktables(cmb_Rooms1.RoomId);
        }
    }
}
