using Odin.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Odin.Global_Classes
{
    class PrinterLabels
    {

        #region Variables

        public string PrinterPort = Properties.Settings.Default.Printer_Port;

        private System.Net.Sockets.TcpClient tc;
        class_Global GlobClass = new class_Global();
        string _PrinterIp = "";
        Tools_BLL BLL = new Tools_BLL();

        public string PrinterIp
        {
            get { return _PrinterIp; }
            set { _PrinterIp = value; }
        }

        public int PrinterDPI
        { get; set; }

        public double Coef()
        {
            return Convert.ToDouble(300 / Convert.ToDouble(PrinterDPI));
        }


        #endregion

        #region Methods

        public void PrintLabel(string StringToPrint, int LabelQty)
        {
            //try
            //{
            //tc = new System.Net.Sockets.TcpClient();
            //tc.Connect(PrinterIp, Convert.ToInt32(PrinterPort));

            //while (LabelQty > 0)
            //{
            //    Stream stm = tc.GetStream();
            //    UTF8Encoding asen = new UTF8Encoding();

            //    //ASCIIEncoding asen = new ASCIIEncoding();
            //    byte[] ba = asen.GetBytes(StringToPrint);
            //    stm.Write(ba, 0, ba.Length);

            //    Thread.Sleep(1500);
            //    LabelQty--;
            //}

            //tc.Close();

            //New asynchronous tcpclient connection
            var client = new TcpClient();
            if (!client.ConnectAsync(PrinterIp, Convert.ToInt32(PrinterPort)).Wait(2000))
            {
                // connection failure
                MessageBox.Show("Connection failure!");
            }
            else
            {
                while (LabelQty > 0)
                {
                    Stream stm = client.GetStream();
                    UTF8Encoding asen = new UTF8Encoding();

                    //ASCIIEncoding asen = new ASCIIEncoding();
                    byte[] ba = asen.GetBytes(StringToPrint);
                    stm.Write(ba, 0, ba.Length);

                    Thread.Sleep(1500);
                    LabelQty--;
                }

                client.Close();
            }



            //}
            //catch
            //{ }
        }

        //public string Query
        //{
        //    get;
        //    set;
        //}

        //public List<SqlParameter> SqlParams
        //{
        //    get;
        //    set;
        //}

        public string LabelConstructor(int TemplateId, string StoredProcedure, params SqlParameter[] ParamList)
        {
            string _res = "";

            //Receiving of data
            var data = Helper.QuerySP(StoredProcedure, ParamList);
            //Receiving fields of parameters 
            var sqlparamsfields = new List<SqlParameter>()
            {
                new SqlParameter("@id",SqlDbType.Int) {Value = TemplateId}
            };

            var datafields = Helper.QuerySP("sp_SelectLabelTemplateFields", sqlparamsfields.ToArray());
            //Receiving template of text
            BLL.TempLabelId = TemplateId;
            string TemplateLabelText = BLL.TempLabelText;
            string _fieldname = "";
            string _spname = "";
            int _symnum = 1;
            string _value = "";

            foreach (DataRow rowfield in datafields.Rows)
            {
                _fieldname = rowfield["labelfield"].ToString();
                _spname = rowfield["spfield"].ToString();
                _symnum = Convert.ToInt32(rowfield["symnum"]);

                foreach (DataColumn column in data.Columns)
                {
                    if (column.ColumnName == _spname)
                    {
                        _value = data.Rows[0][_spname].ToString().Substring(0, data.Rows[0][_spname].ToString().Length < _symnum ? data.Rows[0][_spname].ToString().Length : _symnum);

                        if (column.ColumnName == "artid")  _value = _value.Length < 3 ? _value.Insert(0, " ") : _value;
                        TemplateLabelText = TemplateLabelText.Replace(_fieldname, _value);
                        break;
                    }
                }
            }

            _res = TemplateLabelText;

            return _res;
        }

        #endregion
    }
}
