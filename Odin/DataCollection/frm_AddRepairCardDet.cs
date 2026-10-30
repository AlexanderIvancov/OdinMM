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
using Odin.Purchase;
using Odin.Global_Classes;
using Odin.CustomControls;
using Owf.Controls;
using System.Data.SqlClient;

namespace Odin.DataCollection
{
    public partial class frm_AddRepairCardDet : KryptonForm
    {
        public frm_AddRepairCardDet()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        int _id = 0;
        int _headid = 0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int HeadId
        { get { return _headid; }
            set { _headid = value; }
        }
       

        public string FormText
        {
            get { return txt_Text.Text; }
            set { txt_Text.Text = value; }
        }
        public string FormLabel
        {
            get { return lbl_Text.Text; }
            set { lbl_Text.Text = value; }
        }

        public double WorkTime
        {
            get
            {
                try { return Convert.ToDouble(txt_Worktime.Text); }
                catch { return 0; }
            }
            set { txt_Worktime.Text = value.ToString(); }
        }
        int _formmode = 0;
        public int FormMode
        {
            get { return _formmode; }
            set { _formmode = value;
                if (_formmode == -1)
                {
                    //Defect
                    FormLabel = "Defect:";
                    txt_Worktime.Visible = false;
                    lbl_Worktime.Visible = false;
                }
                else if (_formmode == 0)
                {
                    //Defect
                    FormLabel = "Repair actions:";
                    txt_Worktime.Visible = false;
                    lbl_Worktime.Visible = false;
                }
                else if (_formmode == 1)
                {
                    FormLabel = "Comments:";
                    txt_Worktime.Visible = true;
                    lbl_Worktime.Visible = true;
                    //Description
                }
                else
                {
                    FormLabel = "Conclusion:";
                    txt_Worktime.Visible = false;
                    lbl_Worktime.Visible = false;
                }
            }
        }
        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    string _serial = txt_Oper.Text.Trim();
            //    SqlConnection sqlConn = new SqlConnection(sConnStr);
            //    sqlConn.Open();
            //    DataSet ds1 = new DataSet();

            //    SqlDataAdapter adapter1 =
            //        new SqlDataAdapter(
            //            "execute sp_SelectSerialNrDetails @serial = '" + _serial + "'", sqlConn);

            //    adapter1.Fill(ds1);

            //    DataTable dt1 = ds1.Tables[0];

            //    if (dt1.Rows.Count > 0)
            //    {
            //        foreach (DataRow dr1 in dt1.Rows)
            //        {
            //            Serial = dr1["original"].ToString();
            //            Analog = dr1["analog"].ToString();
            //            BatchId = Convert.ToInt32(dr1["batchid"].ToString());
            //        }
            //    }
            //    sqlConn.Close();

            //    SetFocus();
            //}
        }

        public void SetFocus()
        {
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }
    }


}
