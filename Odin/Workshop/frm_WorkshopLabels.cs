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
using System.Data.SqlClient;
using Odin.Tools;

namespace Odin.Workshop
{
    public partial class frm_WorkshopLabels : KryptonForm
    {
        public frm_WorkshopLabels()
        {
            InitializeComponent();
        }

        #region Variables


        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global globClass = new class_Global();
        PrinterLabels PrintLabels = new PrinterLabels();
        Tools_BLL BLL = new Tools_BLL();

        public int Length
        {
            get { return Convert.ToInt32(txt_Len.Text); }
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_From36.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Till36.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Batch.Text = string.Empty;
        }

        public bool CheckLabels()
        {
            if (Convert.ToInt32(txt_Diff.Text) <= 0
                || txt_From36.Text == "ERROR!"
                || txt_From10.Text == "ERROR!")
                return false;
            else
                return true;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (CheckLabels() == true)
            {
                string _tmpstr;
                frm_Print frm = new frm_Print();
                //frm.cmb_LabPrinter1.ShowDefaults();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 lt.ip, sp.name, sp.dpi from bas_labeltemplate lt inner join sys_printers sp on sp.ipadress = lt.ip where lt.id = 11", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    frm.IP_Address = dt.Rows[0]["ip"].ToString();
                    frm.Printer_DPI = Convert.ToInt32(dt.Rows[0]["dpi"].ToString());
                    frm.PrinterName = dt.Rows[0]["name"].ToString();
                }
                catch
                {
                    frm.cmb_LabPrinter1.ShowDefaults();
                }


                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PrintLabels.PrinterIp = frm.IP_Address;
                    PrintLabels.PrinterDPI = frm.Printer_DPI;

                    //Receiving fields of parameters 
                    var sqlparamsfields = new List<SqlParameter>()
                    {
                        new SqlParameter("@id",SqlDbType.Int) {Value = 11}
                    };

                    //string query = "if not exists (select id from PROD_WorkshopLabels where sn = @sn) " +
                    //    " begin INSERT INTO PROD_WorkshopLabels (batch, sn, counter, who, [when]) values (@batch, @sn, @counter, current_user, getdate()) end";
                    string query = "INSERT INTO PROD_WorkshopLabels (batch, sn, counter, who, [when]) values (@batch, @sn, @counter, current_user, getdate())";


                    var datafields = Helper.QuerySP("sp_SelectLabelTemplateFields", sqlparamsfields.ToArray());

                    //Receiving template of text
                    BLL.TempLabelId = 11;
                    string TemplateLabelText = BLL.TempLabelText;
                    //string _fieldname = "";

                    string _TmpBatch = txt_Batch.Text;
                    _TmpBatch = _TmpBatch.Replace("L", "");
                    _TmpBatch = _TmpBatch.Replace("l", "");

                    TemplateLabelText = TemplateLabelText.Replace("[BATCH]", _TmpBatch);
                    TemplateLabelText = TemplateLabelText.Replace("[SN]", txt_From36.Text);

                    int k = Convert.ToInt32(txt_From10.Text) + 1;

                    while (k <= Convert.ToInt32(txt_Till10.Text))
                    {
                        _tmpstr = globClass.Convert_10to36(k);
                        while (Length - _tmpstr.Length > 0)
                        {
                            _tmpstr = "0" + _tmpstr;
                        }

                        TemplateLabelText = TemplateLabelText + "\r\nR VAR1-1;" + _TmpBatch;
                        TemplateLabelText = TemplateLabelText + "\r\nR VAR2-1;" + _TmpBatch + "-" + _tmpstr;
                        TemplateLabelText = TemplateLabelText + "\r\nR VAR3-1;" + /*globClass.Convert_10to36(k)*/_tmpstr;
                        TemplateLabelText = TemplateLabelText + "\r\nA 1";
                        TemplateLabelText = TemplateLabelText + "\r\n";

                        k++;

                        /*
                            R VAR1-1;<BATCH>
                            R VAR2-1;<BATCH>-<123>
                            R VAR3-1;<123>
                            А 1    
                        */

                        //Save label on DB

                        List<SqlParameter> parameters = new List<SqlParameter>
                            {
                                new SqlParameter("@batch", SqlDbType.NVarChar) {Value = txt_Batch.Text},
                                new SqlParameter("@sn", SqlDbType.NVarChar) {Value = _TmpBatch + "-" + _tmpstr},
                                new SqlParameter("@counter", SqlDbType.Int) {Value = k}
                            };

                        Helper.ExecuteQuery(query, parameters.ToArray());
                    }
                    //MessageBox.Show(TemplateLabelText);
                    //Print label
                    PrintLabels.PrintLabel(TemplateLabelText, 1);
                }
                else
                { }
            }
            else
                globClass.ShowMessage("Error during printing!", "Please check labels!", "Counter or format is incorrect!");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_From10_Validated(object sender, EventArgs e)
        {
            
        }

        private void txt_From36_Validated(object sender, EventArgs e)
        {
            try {
                txt_From10.Text = globClass.Convert_36to10(txt_From36.Text).ToString();
                RecalcDiff();
            }
            catch { txt_From10.Text = "0"; }
        }

        public void RecalcDiff()
        {
            txt_Diff.Text = (Convert.ToInt32(txt_Till10.Text) - Convert.ToInt32(txt_From10.Text) + 1).ToString() ;
        }

        private void txt_Till10_Validated(object sender, EventArgs e)
        {

            
        }

        private void txt_Till36_Validated(object sender, EventArgs e)
        {
            try
            {
                txt_Till10.Text = globClass.Convert_36to10(txt_Till36.Text).ToString();
                RecalcDiff();
            }
            catch { txt_Till10.Text = "0"; }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {

            frm_Print frm = new frm_Print();
            //frm.cmb_LabPrinter1.ShowDefaults();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT TOP 1 lt.ip, sp.name, sp.dpi from bas_labeltemplate lt inner join sys_printers sp on sp.ipadress = lt.ip where lt.id = 11", sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            try
            {
                frm.IP_Address = dt.Rows[0]["ip"].ToString();
                frm.Printer_DPI = Convert.ToInt32(dt.Rows[0]["dpi"].ToString());
                frm.PrinterName = dt.Rows[0]["name"].ToString();
            }
            catch
            {
                frm.cmb_LabPrinter1.ShowDefaults();
            }

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintLabels.PrinterIp = frm.IP_Address;
                PrintLabels.PrinterDPI = frm.Printer_DPI;
                //Receiving fields of parameters 
                var sqlparamsfields = new List<SqlParameter>()
                {
                    new SqlParameter("@id",SqlDbType.Int) {Value = 11}
                };

                var datafields = Helper.QuerySP("sp_SelectLabelTemplateFields", sqlparamsfields.ToArray());

                //Receiving template of text
                BLL.TempLabelId = 11;
                string TemplateLabelText = BLL.TempLabelText;
                //string _fieldname = "";

                TemplateLabelText = TemplateLabelText.Replace("[BATCH]", "123456");
                TemplateLabelText = TemplateLabelText.Replace("[SN]", "ABC");

                PrintLabels.PrintLabel(TemplateLabelText, 1);
            }
            else
            { }        
        }

        private void frm_WorkshopLabels_Load(object sender, EventArgs e)
        {
            txt_From36.Text = "001";//globClass.Convert_10to36(Convert.ToInt32(txt_From10.Text));
            txt_Till36.Text = "001"; //globClass.Convert_10to36(Convert.ToInt32(txt_Till10.Text));
        }

        private void txt_From10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_From36.Text = globClass.Convert_10to36(Convert.ToInt32(txt_From10.Text));

                while (Length - txt_From36.Text.Length > 0)
                {
                    txt_From36.Text = "0" + txt_From36.Text;
                }

                RecalcDiff();
            }
            catch { txt_Till36.Text = "ERROR!"; }
        }

        private void txt_Till10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Till36.Text = globClass.Convert_10to36(Convert.ToInt32(txt_Till10.Text));

                while (Length - txt_Till36.Text.Length > 0)
                {
                    txt_Till36.Text = "0" + txt_Till36.Text;
                }

                RecalcDiff();
            }
            catch { txt_Till36.Text = "ERROR!"; }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {

            var _query = "";
            //_query = "sp_SelectNetUnitCostForBatchDets";
            _query = "sp_SelectPCBLabelsDets";

            var sqlparams = new List<SqlParameter>
                {
                 new SqlParameter("@batch",SqlDbType.NVarChar){Value = txt_Batch.Text},
                 };

            Template_DataGridView frm = new Template_DataGridView();


            frm.Text = "PCB labels creation details for: " + txt_Batch.Text;

            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show();
        }
    }
}
