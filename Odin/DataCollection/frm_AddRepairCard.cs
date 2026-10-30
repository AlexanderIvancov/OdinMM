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
    public partial class frm_AddRepairCard : KryptonForm
    {
        public frm_AddRepairCard()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public int BatchId
        {
            get { return cmb_BatchPDA1.BatchId; }
            set { cmb_BatchPDA1.BatchId = value; }
        }

        public string Serial
        {
            get { return txt_Serial.Text; }
            set { txt_Serial.Text = value; }
        }

        public string Analog
        {
            get { return txt_Analog.Text; }
            set { txt_Analog.Text = value; }
        }

        public string Defect
        {
            get { return txt_Text.Text; }
            set { txt_Text.Text = value; }
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string _serial = txt_Oper.Text.Trim();
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "execute sp_SelectSerialNrDetails @serial = '" + _serial + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        Serial = dr1["original"].ToString();
                        Analog = dr1["analog"].ToString();
                        BatchId = Convert.ToInt32(dr1["batchid"].ToString());
                    }
                }
                sqlConn.Close();

                SetFocus();
            }
        }

        public void SetFocus()
        {
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }
    }


}
