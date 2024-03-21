using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Finances
{
    public partial class frm_Export1C : KryptonForm
    {
        public frm_Export1C()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
        }

        #region Variables
        ProgressForm wait;

        public string _import1cPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string import1cProvodki = "provodki";
        string import1cSubkonto = "subconto";
        string import1cZurn = "Zurn";

        DAL_Functions DLL = new DAL_Functions();

        //MessageBox.Show(path);


        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        #endregion


        public void bw_Export1C(object sender, DoWorkEventArgs e)
        {
            string _regnum = DLL.DefaultValue("regnum");

            bool _result = true;

            string insertQuery = "";

            string createTablequeryProv = "Create Table " + import1cProvodki + " (ZHURN Char(2), DATE DATETIME, " +
                                      "NOMDOK Char(50), DEBET_ACC Char(7), DEB_SUB1 Char(70), DEB_SUB2 Char(70), " +
                                      "DEB_SUB3 Char(70), KRED_ACC Char(7), KRED_SUB1 Char(70), KRED_SUB2 Char(70), " +
                                      "KRED_SUB3 Char(70), VID_DEB1 Char(20), VID_DEB2 Char(20), VID_DEB3 Char(20), " +
                                      "VID_KRED1 Char(20), VID_KRED2 Char(20), VID_KRED3 Char(20), CURRENCY Char(3), " +
                                      "QNTY Double, SUMM_PROV Double, TAX Char(7), DOC_SUMM Double, " +
                                      "SUMMVAL Double, DOCSUMMVAL Double, VAL_DOC Char(3), " +
                                      "DOC_DATE DATETIME, DOC_NOM Char(50), SODERZ Char(140), VID_VOZVR Char(30), " +
                                      "VID_OPER Char(30), VID_DOC Char(30), ANALIT_PVN Char(50), AN_CODE Char(5), " +
                                      "DOC Char(255), SUMMA_POST Double) ";

            string clearTableQueryProv = "delete from " + import1cProvodki;
                       
            using (var dBaseConnection = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @" Data Source=" + _import1cPath + "; " +
                @"Extended Properties=dBase IV")
                )
            {
                dBaseConnection.Open();

                if (File.Exists(_import1cPath + "\\" + import1cProvodki + ".dbf"))
                {
                    var cmd = new OleDbCommand(clearTableQueryProv, dBaseConnection);
                    cmd.ExecuteNonQuery();

                    var data = (DataTable)Helper.getSP("sp_ExportInto1CIncomes", txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                                               txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim());
                  
                    pb_Progress.ThreadSafeCall(delegate
                    {
                        pb_Progress.Value = 0;
                        pb_Progress.Maximum = data.Rows.Count;
                    });

                    foreach (var r in data.AsEnumerable())
                    {
                        insertQuery =
                            "insert into " + import1cProvodki +
                            " Values (ZHURN, DATE, " +
                                      "NOMDOK, DEBET_ACC, DEB_SUB1, DEB_SUB2, " +
                                      "DEB_SUB3, KRED_ACC, KRED_SUB1, KRED_SUB2, " +
                                      "KRED_SUB3, VID_DEB1, VID_DEB2, VID_DEB3, " +
                                      "VID_KRED1, VID_KRED2, VID_KRED3, CURRENCY, " +
                                      "QNTY, SUMM_PROV, TAX, DOC_SUMM, " +
                                      "SUMMVAL, DOCSUMMVAL, VAL_DOC, " +
                                      "DOC_DATE, DOC_NOM, SODERZ, VID_VOZVR, " +
                                      "VID_OPER, VID_DOC, ANALIT_PVN, AN_CODE, " +
                                      "DOC, SUMMA_POST)";

                        OleDbCommand cmdi = new OleDbCommand(insertQuery, dBaseConnection);

                        cmdi.Parameters.AddWithValue("ZHURN", DBNull.Value);
                        cmdi.Parameters.AddWithValue("DATE", r.Field<DateTime>("regdate"));
                        cmdi.Parameters.AddWithValue("NOMDOK", r.Field<string>("name"));
                        cmdi.Parameters.AddWithValue("DEBET_ACC", r.Field<string>("debet"));
                        cmdi.Parameters.AddWithValue("DEB_SUB1", r.Field<string>("debsub"));
                        cmdi.Parameters.AddWithValue("DEB_SUB2", r.Field<string>("debsub2"));
                        cmdi.Parameters.AddWithValue("DEB_SUB3", "");
                        cmdi.Parameters.AddWithValue("KRED_ACC", r.Field<string>("kredit"));
                        cmdi.Parameters.AddWithValue("KRED_SUB1", r.Field<string>("kredsub1"));
                        cmdi.Parameters.AddWithValue("KRED_SUB2", r.Field<string>("kredsub2"));
                        cmdi.Parameters.AddWithValue("KRED_SUB3", "");
                        cmdi.Parameters.AddWithValue("VID_DEB1", r.Field<string>("viddeb"));
                        cmdi.Parameters.AddWithValue("VID_DEB2", r.Field<string>("viddeb2"));
                        cmdi.Parameters.AddWithValue("VID_DEB3", "");
                        cmdi.Parameters.AddWithValue("VID_KRED1", r.Field<string>("vidkred"));
                        cmdi.Parameters.AddWithValue("VID_KRED2", r.Field<string>("vidkred2"));
                        cmdi.Parameters.AddWithValue("VID_KRED3", "");
                        cmdi.Parameters.AddWithValue("CURRENCY", r.Field<string>("currency"));
                        cmdi.Parameters.AddWithValue("QNTY", Convert.ToDecimal("0"));
                        cmdi.Parameters.AddWithValue("SUMM_PROV", r.Field<decimal>("summa"));
                        cmdi.Parameters.AddWithValue("TAX", r.Field<string>("tax"));
                        cmdi.Parameters.AddWithValue("DOC_SUMM", r.Field<decimal>("docsum"));
                        cmdi.Parameters.AddWithValue("SUMMVAL", r.Field<decimal>("sumval"));
                        cmdi.Parameters.AddWithValue("DOCSUMMVAL", r.Field<decimal>("docsumval"));
                        cmdi.Parameters.AddWithValue("VAL_DOC", r.Field<string>("currency"));
                        cmdi.Parameters.AddWithValue("DOC_DATE", r.Field<DateTime>("docdate"));
                        cmdi.Parameters.AddWithValue("DOC_NOM", r.Field<string>("docnom"));
                        cmdi.Parameters.AddWithValue("SODERZ", r.Field<string>("soderz"));
                        cmdi.Parameters.AddWithValue("VID_VOZVR", r.Field<string>("vidvozvr"));
                        cmdi.Parameters.AddWithValue("VID_OPER", "");
                        cmdi.Parameters.AddWithValue("VID_DOC", r.Field<string>("viddok"));
                        cmdi.Parameters.AddWithValue("ANALIT_PVN", r.Field<string>("analitika"));
                        cmdi.Parameters.AddWithValue("AN_CODE", r.Field<string>("kodanal"));
                        cmdi.Parameters.AddWithValue("DOC", "");
                        cmdi.Parameters.AddWithValue("SUMMA_POST", Convert.ToDecimal("0"));

                        cmdi.ExecuteNonQuery();

                        pb_Progress.ThreadSafeCall(delegate { pb_Progress.Value = pb_Progress.Value + 1;  });
                       
                    }


                }
                else
                {
                    KryptonTaskDialog.Show("Mistake during exporting of provodki.dbf!",
                                       "Document was not created!",
                                        "Please check file in selected folder! If there is no such file, restore it's original!",
                                        MessageBoxIcon.Warning,
                                        TaskDialogButtons.OK);

                    _result = false;
                    //var cmd = new OleDbCommand(createTablequeryProv, dBaseConnection);
                    //cmd.ExecuteNonQuery();
                }

            }


            //string createTablequeryZurn = "Create Table " + import1cProvodki + " (SKLADKOD Int, GOD Int, " +
            //                         "MES Int, DEN Int, DATA DateTime, TTNNUM Char(50), SERIJA Char(50)," +
            //                         "DOKUMNUM Char(50), OPERACKOD Char(50), VALKOD Char(50), " +
            //                         "VALKURS Char(50), KLIENTKOD Char(50), KLIENTNAI Char(75), " +
            //                         "OPLATDATA DateTime, POLUCDATA DateTime, " +
            //                         " SUMTOVAR Double, SUMNALOG Double, " +
            //                         "SUMSEBES Double, SUMTTN Double, SUMSKID Double, SUMTARA Double," +
            //                         "PRIM Char(50), POLUCKOD Char(50), KLIENTGRINSKOD Int, POLUCGRINSKOD Int, POLUCNAI Char(75)) ";

            string clearTableQueryZurn = "delete from " + import1cZurn;


            using (var dBaseConnection = new OleDbConnection(
               @"Provider=Microsoft.ACE.OLEDB.12.0;" +
               @" Data Source=" + _import1cPath + "; " +
               @"Extended Properties=dBase IV")
               )
            {
                dBaseConnection.Open();

                if (File.Exists(_import1cPath + "\\" + import1cZurn + ".dbf"))
                {
                    var cmd = new OleDbCommand(clearTableQueryZurn, dBaseConnection);
                    cmd.ExecuteNonQuery();
                }

                insertQuery =
                            "insert into " + import1cZurn +
                            " Values (DATA_N, DATA_K, ZURN, NCODE, ORG_REG_NR)";

                OleDbCommand cmdi = new OleDbCommand(insertQuery, dBaseConnection);

                cmdi.Parameters.AddWithValue("DATA_N", Convert.ToDateTime(txt_DateFrom.Value.ToString()));
                cmdi.Parameters.AddWithValue("DATA_K", Convert.ToDateTime(txt_DateTill.Value.ToString()));
                cmdi.Parameters.AddWithValue("ZURN", DBNull.Value);
                cmdi.Parameters.AddWithValue("NCODE", 1);
                cmdi.Parameters.AddWithValue("ORG_REG_NR", _regnum);

                cmdi.ExecuteNonQuery();


            }
                    //string createTablequerySubconto = "Create Table " + import1cSubkonto + " (SKLADKOD Int, GOD Int, " +
                    //                         "MES Int, DEN Int, DATA DateTime, TTNNUM Char(50), SERIJA Char(50)," +
                    //                         "DOKUMNUM Char(50), OPERACKOD Char(50), VALKOD Char(50), " +
                    //                         "VALKURS Char(50), KLIENTKOD Char(50), KLIENTNAI Char(75), " +
                    //                         "OPLATDATA DateTime, POLUCDATA DateTime, " +
                    //                         " SUMTOVAR Double, SUMNALOG Double, " +
                    //                         "SUMSEBES Double, SUMTTN Double, SUMSKID Double, SUMTARA Double," +
                    //                         "PRIM Char(50), POLUCKOD Char(50), KLIENTGRINSKOD Int, POLUCGRINSKOD Int, POLUCNAI Char(75)) ";


            string clearTableQuerySubconto = "delete from " + import1cSubkonto;

            using (var dBaseConnection = new OleDbConnection(
               @"Provider=Microsoft.ACE.OLEDB.12.0;" +
               @" Data Source=" + _import1cPath + "; " +
               @"Extended Properties=dBase IV")
               )
            {
                dBaseConnection.Open();



                if (File.Exists(_import1cPath + "\\" + import1cSubkonto + ".dbf"))
                {
                    var cmd = new OleDbCommand(clearTableQuerySubconto, dBaseConnection);
                    cmd.ExecuteNonQuery();

                    var data = (DataTable)Helper.getSP("sp_ExportInto1CSubconto", txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                                               txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim());

                   

                    pb_Progress.ThreadSafeCall(delegate
                    {
                        pb_Progress.Value = 0;
                        pb_Progress.Maximum = data.Rows.Count;
                    });

                    foreach (var r in data.AsEnumerable())
                    {
                        insertQuery =
                            "insert into " + import1cSubkonto +
                            " Values (VID, CODE, NAME, CENA, CURRENCY, " +
                                      "FULL_NAME, REG_NUM, REG_NALOG, ADRESS, " +
                                      "RS1, RS2, PHONES, PILN_PERS, " +
                                      "BANK, COUNTRY, DATA_NAKL, DATA_OPL, " +
                                      "CODE_KL, JUR_FIZ, VID_DOC)";

                        OleDbCommand cmdi1 = new OleDbCommand(insertQuery, dBaseConnection);

                        cmdi1.Parameters.AddWithValue("VID", r.Field<string>("vid"));
                        cmdi1.Parameters.AddWithValue("CODE", r.Field<string>("code"));
                        cmdi1.Parameters.AddWithValue("NAME", r.Field<string>("name"));
                        cmdi1.Parameters.AddWithValue("CENA", r.Field<decimal>("cena"));
                        cmdi1.Parameters.AddWithValue("CURRENCY", r.Field<string>("currency"));
                        cmdi1.Parameters.AddWithValue("FULL_NAME", r.Field<string>("fullname"));
                        cmdi1.Parameters.AddWithValue("REG_NUM", r.Field<string>("regnum"));
                        cmdi1.Parameters.AddWithValue("REG_NALOG", r.Field<string>("regnalog"));
                        cmdi1.Parameters.AddWithValue("ADRESS", r.Field<string>("adress"));
                        cmdi1.Parameters.AddWithValue("RS1", r.Field<string>("rs1"));
                        cmdi1.Parameters.AddWithValue("RS2", r.Field<string>("rs2"));
                        cmdi1.Parameters.AddWithValue("PHONES", r.Field<string>("phones"));
                        cmdi1.Parameters.AddWithValue("PILN_PERS", r.Field<string>("pilnpers"));
                        cmdi1.Parameters.AddWithValue("BANK", r.Field<string>("bank"));
                        cmdi1.Parameters.AddWithValue("COUNTRY", r.Field<string>("country"));
                        cmdi1.Parameters.AddWithValue("DATA_NAKL", r.Field<DateTime>("datanakl"));
                        cmdi1.Parameters.AddWithValue("DATA_OPL", r.Field<DateTime>("dataopl"));
                        cmdi1.Parameters.AddWithValue("CODE_KL", r.Field<string>("codekl"));
                        cmdi1.Parameters.AddWithValue("JUR_FIZ", r.Field<int>("jurfiz"));
                        cmdi1.Parameters.AddWithValue("VID_DOC", r.Field<string>("viddoc"));
                       
                        cmdi1.ExecuteNonQuery();

                        pb_Progress.ThreadSafeCall(delegate { pb_Progress.Value = pb_Progress.Value + 1; });
                    }


                }

                else
                {
                    KryptonTaskDialog.Show("Mistake during exporting of subconto.dbf!",
                                       "Document was not created!",
                                        "Please check file in selected folder! If there is no such file, restore it's original!",
                                        MessageBoxIcon.Warning,
                                        TaskDialogButtons.OK);

                    _result = false;
                    //var cmd = new OleDbCommand(createTablequeryProv, dBaseConnection);
                    //cmd.ExecuteNonQuery();
                }
            }

            if (_result != true)
            KryptonTaskDialog.Show("Mistakes during exporting!",
                                       "Some files was not created was not created!",
                                        "Please check file in selected folder! If there is no such file, restore it's original!",
                                        MessageBoxIcon.Warning,
                                        TaskDialogButtons.OK);
            else
            KryptonTaskDialog.Show("Exporting was successful!",
                                      "Files was created!",
                                      "",
                                       MessageBoxIcon.Information,
                                       TaskDialogButtons.OK);

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.SelectedPath = _import1cPath;

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                _import1cPath = FBD.SelectedPath;

                bwStart(bw_Export1C);
            }
        }

        private void frm_Export1C_Load(object sender, EventArgs e)
        {
            txt_DateFrom.Value = System.DateTime.Now;
            txt_DateTill.Value = System.DateTime.Now;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_DateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_DateTill.Value = System.DateTime.Now;
        }

        private void txt_DateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DateFrom.Value = txt_DateFrom.Value == null ? System.DateTime.Now : txt_DateFrom.Value;
        }

        private void txt_DateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DateTill.Value = txt_DateTill.Value == null ? System.DateTime.Now : txt_DateTill.Value;
        }
    }
}
