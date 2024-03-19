using AegisImplicitMail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
//using AdvancedDataGridView;
//using EmailHandler;
using System.Windows.Forms;

namespace Odin.Global_Classes
{
    public class Helper
    {
        static string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        DAL_Functions DAL = new DAL_Functions();
        class_Global GlobClass = new class_Global();
        public string SendAddresses;
        public string MailText;
        public string MailSubject;

        #region DB Helpers

        /// <summary> 
        /// try/catch block for transaction
        /// </summary> 
        public static string Transaction(string query)
        {
            StringBuilder transaction = new StringBuilder();
            transaction.Append("BEGIN TRANSACTION; ");
            transaction.Append("BEGIN TRY ");
            transaction.Append(query);
            transaction.Append(" COMMIT; ");
            transaction.Append("END TRY ");
            transaction.Append("BEGIN CATCH ");
            transaction.Append("IF @@TRANCOUNT > 0 ROLLBACK; ");
            transaction.Append("END CATCH ");
            return transaction.ToString();
        }

        /// <summary> 
        /// Converts String Query to DataTable
        /// </summary> 
        /// <param name="queryString">SQL query</param>
        /// <param name="connStr">SQL Server connection string</param>
        /// <param name="isStoredProcedure">Is it stored procedure</param>
        /// <returns>DataTable</returns>
        public static DataTable QueryDT(string queryString, string connStr,
                                        bool isStoredProcedure,
                                        params SqlParameter[] list
                                        )
        {
            using (var connection = new SqlConnection(connStr))
            {
                var sda = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand(queryString, connection);

                cmd.CommandTimeout = 3000;

                if (isStoredProcedure)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                if (list.Count() != 0)
                {
                    cmd.Parameters.AddRange(list);
                }

                sda.SelectCommand = cmd;

                var ds = new DataSet();
                sda.Fill(ds);

                return ds.Tables[0];
            }
        }

        public static Dictionary<string, SqlDbType> typeMap = new Dictionary<string, SqlDbType>
        {
            ["char"] = SqlDbType.NVarChar,
            ["nchar"] = SqlDbType.NVarChar,
            ["nvarchar"] = SqlDbType.NVarChar,
            ["varchar"] = SqlDbType.NVarChar,
            ["int"] = SqlDbType.Int,
            ["smallint"] = SqlDbType.SmallInt,
            ["bigint"] = SqlDbType.BigInt,
            ["varbinary"] = SqlDbType.VarBinary,
            ["bit"] = SqlDbType.Bit,
            ["datetime"] = SqlDbType.DateTime2,
            ["decimal"] = SqlDbType.Decimal,
            ["float"] = SqlDbType.Float,
            ["tinyint"] = SqlDbType.TinyInt,
            ["table type"] = SqlDbType.Structured,
            ["datetime"] = SqlDbType.Time
        };

        public static object getSP(string sp, params object[] parameters)
        {
            var sqlparams = new List<SqlParameter>();
            DataTable dt = QueryDT($@"select PARAMETER_NAME, PARAMETER_MODE, CHARACTER_MAXIMUM_LENGTH, DATA_TYPE from INFORMATION_SCHEMA.PARAMETERS
                        where SPECIFIC_NAME = '{sp}'");
            var res = true;
            if (dt.Rows.Count > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                    switch (dt.Rows[i].ItemArray[1].ToString())
                    {
                        case "IN":
                            sqlparams.Add(new SqlParameter(dt.Rows[i].ItemArray[0].ToString(), parameters[i]));
                            break;
                        case "INOUT":
                        case "OUT":
                            sqlparams.Add(new SqlParameter(dt.Rows[i].ItemArray[0].ToString(), ""));
                            sqlparams[i].Direction = ParameterDirection.Output;
                            res = false;
                            break;
                    }
                    
            return res ? QuerySP(sp, sqlparams.ToArray()) : ExecuteSP(sp, sqlparams.ToArray());
        }

        /// <summary> 
        /// Converts String Query to DataTable
        /// </summary> 
        /// <param name="queryString">SQL query</param>
        /// <param name="connStr">SQL Server connection string</param>
        /// <returns>DataTable</returns>
        public static DataTable QueryDT(string queryString, params SqlParameter[] list)
        {
            return QueryDT(queryString, sConnStr, false, list);
        }

        /// <summary> 
        /// Converts String Query to DataTable
        /// </summary> 
        /// <param name="queryString">SQL query</param>
        /// <param name="connStr">SQL Server connection string</param>
        /// <returns>DataTable</returns>
        public static DataTable QueryDT(string queryString, bool isStoredProcedure, params SqlParameter[] list)
        {
            return QueryDT(queryString, sConnStr, isStoredProcedure, list);
        }

        /// <summary> 
        /// Converts String Query to DataTable with paramaters
        /// </summary> 
        public static DataTable QueryString(string sQueryString, string conString)
        {
            using (var connection = new SqlConnection(conString))
            {
                var sda = new SqlDataAdapter(sQueryString, connection);
                var ds = new DataSet();
                sda.Fill(ds);

                return ds.Tables[0];
            }
        }

        public static DataTable QueryDTstring(string sQueryString)
        {
            return QueryDT(sQueryString);
        }

        /// <summary> 
        /// Converts String Query to DataTable with paramaters
        /// </summary> 
        public static DataTable QueryStorProc(string StoredProcedure, string conString, params SqlParameter[] list)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            using (var connection = new SqlConnection(conString))
            {
                var cmd = new SqlCommand(StoredProcedure, connection);

                if (list.Count() != 0)
                    cmd.Parameters.AddRange(list);
                cmd.Connection.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3000;
                da.SelectCommand = cmd;

                DataColumn dc = new DataColumn("autoincrement");
                dt.Columns.Add(dc);
                dc.AutoIncrement = true;
                dt.Columns["autoincrement"].AutoIncrementSeed = 1;
                dt.Columns["autoincrement"].AutoIncrementStep = 1;
                
                

                da.Fill(dt);

                return dt;
            }
        }

        /// <summary> 
        /// Converts String Query to DataTable with paramaters
        /// </summary> 
        public static DataTable QuerySP(string sQueryString, params SqlParameter[] list)
        {
            return QueryStorProc(sQueryString, sConnStr, list);
        }

        /// <summary> 
        /// Returns one record 
        /// </summary> 
        public static object GetRecord(string sQueryString, string conString, params SqlParameter[] list)
        {
            // var sConnStr = conString ?? defaultConnStr;

            using (var connection = new SqlConnection(conString))
            {
                var cmd = new SqlCommand(sQueryString, connection);

                if (list.Count() != 0)
                    cmd.Parameters.AddRange(list);

                cmd.Connection.Open();

                object res = cmd.ExecuteScalar();
                try
                {
                    return res;
                }
                catch
                {
                    return null;
                }
            }
        }

        /// <summary> 
        /// Returns one record 
        /// </summary> 
        public static object GetOneRecord(string sQueryString, params SqlParameter[] list)
        {
            return GetRecord(sQueryString, sConnStr, list);
        }

        /// <summary> 
        /// Executes stored procedure
        /// </summary> 
        public static object ExecuteStorProc(string sQueryString, string conString, params SqlParameter[] list)
        {
            // var sConnStr = conString ?? Properties.Settings.Default.DBAxonConnectionString;
            using (var connection = new SqlConnection(conString))
            {
                var cmd = new SqlCommand(sQueryString, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 3000;
                if (list.Count() != 0)
                    cmd.Parameters.AddRange(list);

                cmd.Connection.Open();
                var isRowsAffected = cmd.ExecuteNonQuery();

                var outParam = list.Where(item => item.Direction == ParameterDirection.Output).SingleOrDefault();
                return outParam != null ? outParam.Value : isRowsAffected == 1;
            }
        }

        /// <summary> 
        /// Executes stored procedure
        /// </summary> 
        public static object ExecuteSP(string sQueryString, params SqlParameter[] list)
        {
            return ExecuteStorProc(sQueryString, sConnStr, list);
        }

        /// <summary> 
        /// Executes query string
        ///  "select * from customers where city = @city";
        /// </summary> 
        public static bool ExecuteQueryString(string sQueryString, string conString, params SqlParameter[] list)
        {
            // var sConnStr = conString ?? Properties.Settings.Default.DBAxonConnectionString;
            using (var connection = new SqlConnection(conString))
            {
                var cmd = new SqlCommand(sQueryString, connection);
                cmd.CommandType = CommandType.Text;

                if (list.Count() != 0)
                    cmd.Parameters.AddRange(list);

                cmd.Connection.Open();
                var isRowsAffected = cmd.ExecuteNonQuery();
                return isRowsAffected == 1;
            }
        }

        /// <summary> 
        /// Executes query string
        ///  "delete from table where id = @id ";
        /// </summary> 
        public static bool ExecuteQuery(string sQueryString, params SqlParameter[] list)
        {
            return ExecuteQueryString(sQueryString, sConnStr, list);
        }

        #endregion

        #region Mail Helper

        frm_EmailNew frmMail = null;
        
        public void SendMessage(string To, string Subject, string Message)
        {

            frmMail = new frm_EmailNew();

            frmMail.From = DAL.MyMailAdress();
            frmMail.To = GlobClass.NES(To) != "" ? frmMail.From + ", " + To : frmMail.From;

            frmMail.Subject = Subject;
            frmMail.Message = Message;
            
            frmMail.SendMail += new MailSendingEventHandler(SendEMail);

            frmMail.Show();
            
        }
        public void SendMessageWS(string To, string Subject, string Message)
        {
            frmMail = new frm_EmailNew();

            frmMail.From = DAL.MyMailAdress();
            frmMail.To = To;
           
            frmMail.Subject = Subject;
            frmMail.Message = Message;

            frmMail.SendMail += new MailSendingEventHandler(SendEMail);

            frmMail.Show();

        }
        public void SendEMail(object sender)
        {

            if (String.IsNullOrEmpty(frmMail.To))
            {
                MessageBox.Show("Missing recipient address.", "Email Error");
                return;
            }

            if (String.IsNullOrEmpty(frmMail.From))
            {
                MessageBox.Show("Missing sender address.", "Email Error");
                return;
            }

            if (String.IsNullOrEmpty(frmMail.Subject))
            {
                MessageBox.Show("Missing subject line.", "Email Error");
                return;
            }

            if (String.IsNullOrEmpty(frmMail.Message))
            {
                MessageBox.Show("Missing message.", "Email Error");
                return;
            }
            _from = frmMail.From;
            _to = frmMail.To;
            _subject = frmMail.Subject;
            _message = frmMail.Message;
            var mail = frmMail.From;
            var host = Properties.Settings.Default.SMTPAddress;

            DAL.UserLogin = DAL.CurrentDBUser;//System.Environment.UserName;

            var user = DAL.UserEmail;
            var pass = DAL.UserMailPWD;
            //MessageBox.Show(pass);

            //Generate Message 
            var mymessage = new MimeMailMessage();
            mymessage.From = new MimeMailAddress(mail);

            //string[] arr = frmMail.To.Split(',');

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!String.IsNullOrEmpty(arr[i].ToString().Trim()))
            //    {
            //       mymessage.To.Add(arr.ToString().Trim());
            //    }
            //}

            mymessage.To.Add(frmMail.To);

            mymessage.Subject = frmMail.Subject;
            mymessage.IsBodyHtml = true;
            mymessage.Headers.Add("Content-type", "text/html; charset=utf-8");
            //mymessage.Body = frmMail.Message;


           
            string[] arr = frmMail.Message.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string _tmpmessage = arr.FirstOrDefault();

            for (int i = 1; i < arr.Length; i++)
            {
                _tmpmessage = _tmpmessage + "<br>" + arr[i].ToString();
            }
            //foreach (string s in arr)
            //{
            //    _tmpmessage = _tmpmessage + "<br>" + s;
            //}


                mymessage.Body = "<html>" +
                            "<body>" +
                            _tmpmessage +
                            "</body>" +
                            "</html>"; 


            MimeAttachment attachment;

            string[] arr1 = frmMail.Attachments.Split(';');

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!String.IsNullOrEmpty(arr1[i].ToString().Trim()))
                {
                    attachment = new MimeAttachment(arr1[i].ToString().Trim());
                    mymessage.Attachments.Add(attachment);
                }
            }

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

        public void SendDirectEMail(string To, string Subject, string Message)
        {

            if (String.IsNullOrEmpty(To))
            {
                MessageBox.Show("Missing recipient address.", "Email Error");
                return;
            }
            string From = DAL.MyMailAdress();
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
            var host = Properties.Settings.Default.SMTPAddress;

            DAL.UserLogin = DAL.CurrentDBUser;//System.Environment.UserName;

            var user = DAL.UserEmail;
            var pass = DAL.UserMailPWD;
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

        string _from = "";
        string _to = "";
        string _subject = "";
        string _message = "";

        public void SendDirectEMailWithAttachment(string To, string Subject, string Message, string Attachments)
        {

            if (String.IsNullOrEmpty(To))
            {
                MessageBox.Show("Missing recipient address.", "Email Error");
                return;
            }
            string From = DAL.MyMailAdress();
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
            var host = Properties.Settings.Default.SMTPAddress;

            DAL.UserLogin = DAL.CurrentDBUser;//System.Environment.UserName;

            var user = DAL.UserEmail;
            var pass = DAL.UserMailPWD;
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
                _tmpmessage = _tmpmessage + "<br>" + arr[i].ToString();

            mymessage.Body = "<html>" +
                        "<body>" +
                        _tmpmessage +
                        "</body>" +
                        "</html>";


            MimeAttachment attachment;

            string[] arr1 = Attachments.Split(';');

            for (int i = 0; i < arr1.Length; i++)
                if (!String.IsNullOrEmpty(arr1[i].ToString().Trim()))
                {
                    attachment = new MimeAttachment(arr1[i].ToString().Trim());
                    mymessage.Attachments.Add(attachment);
                }

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
            AddMailLog(_from, _to, _subject, _message, e.Cancelled == true ? "Cancelled" : (e.Error != null ? "Error : " + e.Error.Message : "Mail sent"));
            if (e.UserState != null)
                Console.Out.WriteLine(e.UserState.ToString());

            Console.Out.WriteLine("is it canceled? " + e.Cancelled);

            if (e.Error != null)
                MessageBox.Show("Error : " + e.Error.Message);
            //Console.Out.WriteLine("Error : " + e.Error.Message);
            //frmMail.Close();
        }

        public void AddMailLog(string from, string to, string subject, string message, string result)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_AddNotifMailLog", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@from", from);
            sqlComm.Parameters.AddWithValue("@to", to);
            sqlComm.Parameters.AddWithValue("@subject", subject);
            sqlComm.Parameters.AddWithValue("@message", message);
            sqlComm.Parameters.AddWithValue("@result", result);

            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
        }

        #endregion

        /// <summary> 
        /// Removes fake node from TreeGridview
        /// </summary> 
        //public static void RemoveExampleNode(TreeGridNode node)
        //{
        //    for (int i = 0; i < node.Nodes.Count; i++)
        //    {
        //        if (node.Nodes[i].Cells[1].Value.ToString() != "Example") continue;
        //        node.Nodes.Remove(node.Nodes[i]);
        //        break;
        //    }
        //}

        //Converts the DataGridView to DataTable
        public static DataTable DataGridViewToDataTable(DataGridView dgv, String tblName, int minRow)
        {
            DataTable dt = new DataTable(tblName);

            // Header columns
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);
            }

            // Data cells
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgv.Columns.Count; j++)
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                dt.Rows.Add(dr);
            }

            // Related to the bug arround min size when using ExcelLibrary for export
            for (int i = dgv.Rows.Count; i < minRow; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dt.Columns.Count; j++)
                    dr[j] = "  ";
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static DataTable YesNoDataTable()
        {
            DataTable dataYesNo = new DataTable();
            dataYesNo.Columns.Add(new DataColumn("YesNo", typeof(string)));
            dataYesNo.Columns.Add(new DataColumn("Id", typeof(int)));

            dataYesNo.Rows.Add(dataYesNo.NewRow());
            dataYesNo.Rows.Add(dataYesNo.NewRow());

            dataYesNo.Rows[0][0] = "Yes";
            dataYesNo.Rows[0][1] = 1;
            dataYesNo.Rows[1][0] = "No";
            dataYesNo.Rows[1][1] = 0;

            return dataYesNo;
        }

        public static void LoadColumns(DataGridView grid, string ControlName)
        {
            DAL_Functions dal = new DAL_Functions();
            class_Global globClass = new class_Global();
            dal.UserLogin = Environment.UserName;
            //var data = BLL_Functions.LoaDgvColumns(dal.UserId, ControlName, grid.Name);


            //foreach (DataRow row in data.Rows)
            //{
            //    foreach (DataGridViewColumn column in grid.Columns)
            //    {
            //        if (column.Name == row["columnname"].ToString())
            //        {
            //            column.DisplayIndex = Convert.ToInt32(row["columnorder"]);
            //            column.HeaderText = row["columntext"].ToString();
            //            column.Visible = globClass.NumToBool(row["columnvisibility"].ToString());
            //        }
            //    }
            //}
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        public static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }

        /// <summary>
        /// Method to resize the image
        /// </summary>
        /// <param name="image">Bitmap image.</param>
        /// <param name="maxWidth">max resize width.</param>
        /// <param name="maxHeight">max resize height.</param> 
        public static Bitmap ScaleBitmap(Bitmap image, int maxWidth, int maxHeight)
        {
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // stretch ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            Bitmap newImage = new Bitmap(image, newWidth, newHeight);
            return newImage;
        }

        /// <summary>
        /// Aligns in the center required control
        /// </summary>
        /// <param name="ParentWidth">Width of the container</param>
        /// <param name="ParentHeight">Height of the container</param>
        /// <param name="ControlAlign">The control to align</param>
        /// <returns></returns>
        public static Point AlignCenterControl(int ParentWidth, int ParentHeight,
            Control ControlAlign)
        {
            var coordX = (ParentWidth - ControlAlign.Width) / 2;
            var coordY = (ParentHeight - ControlAlign.Height) / 2;
            var LocationPoint = new Point(coordX, coordY);
            ControlAlign.Location = LocationPoint;
            return LocationPoint;
        }

        #region GridView

        /// <summary> 
        /// Saves DataGridView sort direction
        /// </summary> 
        public static ListSortDirection SaveDirection(DataGridView gv_List)
        {
            return gv_List.SortOrder == System.Windows.Forms.SortOrder.Ascending
                ? ListSortDirection.Ascending
                : ListSortDirection.Descending;
        }

        /// <summary> 
        /// Restores DataGridView sort direction
        /// </summary> 
        public static void RestoreDirection(DataGridView gv_List, DataGridViewColumn oldColumn,
            ListSortDirection sortDir)
        {
            if (oldColumn != null)
                //try
                //{
               gv_List.ThreadSafeCall(delegate
               {
                   DataGridViewColumn newColumn = gv_List.Columns[oldColumn.Name];
                   gv_List.Sort(newColumn, sortDir);
                   newColumn.HeaderCell.SortGlyphDirection =
                       sortDir == ListSortDirection.Ascending
                           ? System.Windows.Forms.SortOrder.Ascending
                           : System.Windows.Forms.SortOrder.Descending;
               });
                //}
                //catch { }
        }

        #endregion
    }
}