using ComponentFactory.Krypton.Toolkit;
using Npgsql;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public partial class frm_SerialTracing : KryptonForm
    {
        public frm_SerialTracing()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        string postgreConnStr = ConfigurationManager.ConnectionStrings["PostgreConnectionString"].ConnectionString;

        DAL_Functions DAL = new DAL_Functions();
        Processing_BLL ProdBll = new Processing_BLL();
        CMB_BLL CmbBll = new CMB_BLL();



        public int ReadValue = 0;
        public string Result = "";
        int _counter = 0;
        public int Counter
        {
            get { return _counter; }
            set { _counter = value; }
        }

        int _RegMode = -1;
        int _Freezed = -1;

        public int RegMode
        {
            get { return _RegMode; }
            set
            {
                _RegMode = value;
                if (_RegMode == -1)
                {
                    chk_Replace.CheckState = CheckState.Unchecked;
                    chk_Replace.BackColor = Color.LightGreen;
                    ScanOrder = BatchId != 0 ? 2 : 1;
                }
                else
                {
                    chk_Replace.CheckState = CheckState.Checked;
                    chk_Replace.BackColor = Color.LightPink;
                    ScanOrder = BatchId != 0 ? 3 : 1;
                }
            }
        }

        public int Freezed
        {
            get { return _Freezed; }
            set
            {
                _Freezed = value;
                if (_Freezed == -1)
                {
                    chk_Freezed.CheckState = CheckState.Unchecked;
                    chk_Freezed.BackColor = Color.LightGreen;
                }
                else
                {
                    chk_Freezed.CheckState = CheckState.Checked;
                    chk_Freezed.BackColor = Color.LightPink;
                }
            }
        }
        public int BatchId
        {
            get { return cmb_BatchPDA1.BatchId; }
            set
            {
                cmb_BatchPDA1.BatchId = value;
                ScanOrder = value != 0 ? RegMode == -1 ? 2 : 3 : 1;

            }

        }

        int _StageId = 5;

        public int StageId
        {
            get { return _StageId; }
            set
            {
                _StageId = value;
                if (_StageId == 5) //QC_SMT
                {
                    chk_QCSMT.CheckState = CheckState.Checked;
                    chk_QCTHT.CheckState = CheckState.Unchecked;
                    chk_FQC.CheckState = CheckState.Unchecked;

                    chk_QCSMT.BackColor = Color.LightPink;
                    chk_QCTHT.BackColor = Color.LightGreen;
                    chk_FQC.BackColor = Color.LightGreen;
                }
                else if (_StageId == 6) //QC_THT
                {
                    chk_QCSMT.CheckState = CheckState.Unchecked;
                    chk_QCTHT.CheckState = CheckState.Checked;
                    chk_FQC.CheckState = CheckState.Unchecked;

                    chk_QCSMT.BackColor = Color.LightGreen;
                    chk_QCTHT.BackColor = Color.LightPink;
                    chk_FQC.BackColor = Color.LightGreen;
                }
                else if (_StageId == 7)//FQC
                {
                    chk_QCSMT.CheckState = CheckState.Unchecked;
                    chk_QCTHT.CheckState = CheckState.Unchecked;
                    chk_FQC.CheckState = CheckState.Checked;

                    chk_QCSMT.BackColor = Color.LightGreen;
                    chk_QCTHT.BackColor = Color.LightGreen;
                    chk_FQC.BackColor = Color.LightPink;
                }
                else
                {
                    chk_QCSMT.CheckState = CheckState.Unchecked;
                    chk_QCTHT.CheckState = CheckState.Unchecked;
                    chk_FQC.CheckState = CheckState.Unchecked;

                    chk_QCSMT.BackColor = Color.LightGreen;
                    chk_QCTHT.BackColor = Color.LightGreen;
                    chk_FQC.BackColor = Color.LightGreen;
                }

            }
        }

        public string _scanlabel = "";
        #endregion

        #region Methods

        public void AddSerialTracing(int stageid, int batchid, string serial)
        {
            string _res = ProdBll.AddSerialNumberTracing(stageid, batchid, serial);

            if (_res.IndexOf("success!") >= 0)
            {
                Counter++;
                _res = Counter.ToString() + ". " + _res;
            }

            txt_Result.Text = _res + " at " + System.DateTime.Now.ToString() + System.Environment.NewLine + txt_Result.Text;
        }

        public void AddSerialFreezed(int stageid, int batchid, int launchid, string serial, string placement, int reasonid)
        {
            ProdBll.AddSerialFreezed(stageid, batchid, launchid, serial, placement, reasonid);
        }

        public void ReplaceSerialTracing(string serial, int stageid, string replacement)
        {
            string _res = ProdBll.ReplaceSerialNumberTracing(serial, stageid, replacement);

            txt_Result.Text = _res + " at " + System.DateTime.Now.ToString() + System.Environment.NewLine + txt_Result.Text;
        }

        public void AddSerialAnalogue(string serial, string analogue, int asprimary)
        {
            string _res = ProdBll.AddSerialNumberAnalogue(serial, analogue, asprimary);

            txt_Result.Text = _res + " at " + System.DateTime.Now.ToString() + System.Environment.NewLine + txt_Result.Text;
        }

        int _scanorder = 1;
        public int ScanOrder
        {
            get { return _scanorder; }
            set
            {
                _scanorder = value;
                lbl_Order.Text = _scanorder == 1
                    ? "SCAN BATCH LABEL!"
                    : _scanorder == 2
                    ? "SCAN SERIAL LABEL!"
                    : _scanorder == 3 ? "SCAN SERIAL LABEL YOU WANT TO REPLACE!" : "SCAN REPLACEMENT LABEL!";
            }
        }

        //public void ScanLabelChange(int order)
        //{
        //    if (order == 1)
        //        lbl_Order.Text = "SCAN BATCH LABEL!";
        //    else if (order == 2)
        //        lbl_Order.Text = "SCAN SERIAL LABEL!";
        //    else if (order == 3)
        //        lbl_Order.Text = "SCAN SERIAL LABEL YOU WANT TO REPLACE!";
        //    else
        //        lbl_Order.Text = "SCAN REPLACEMENT LABEL!";
        //}

        #endregion

        #region Controls


        private void frm_SerialTracing_Load(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void chk_Replace_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Replace.CheckState == CheckState.Checked)
            {
                RegMode = 1;
                _scanlabel = "";
                txt_Oper.Focus();
            }
            else
            {
                RegMode = -1;
                txt_Oper.Focus();
                //cmb_Articles1.Focus();
            }
        }

        private void chk_Freezed_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Freezed.CheckState == CheckState.Checked)
            {
                Freezed = 1;
                _scanlabel = "";
                txt_Oper.Focus();
            }
            else
            {
                Freezed = -1;
                txt_Oper.Focus();
                //cmb_Articles1.Focus();
            }
        }

        #endregion

        private void chk_QCSMT_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_QCSMT.CheckState == CheckState.Checked)
            {
                StageId = 5;
                txt_Oper.Text = string.Empty;
                txt_Oper.Focus();
            }
        }

        private void chk_QCTHT_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_QCTHT.CheckState == CheckState.Checked)
            {
                StageId = 6;
                txt_Oper.Text = string.Empty;
                txt_Oper.Focus();
            }
        }

        private void chk_FQC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_FQC.CheckState == CheckState.Checked)
            {
                StageId = 7;
                txt_Oper.Text = string.Empty;
                txt_Oper.Focus();
            }
        }

        private void cmb_BatchPDA1_BatchChanged(object sender)
        {

            ScanOrder = BatchId == 0 ? 1 : RegMode == -1 ? 2 : 3;
            txt_Oper.Focus();
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            string _scanreplacement = "";


            if (e.KeyChar == (char)Keys.Enter)
            {
                //ReadValue = 0;
                //Check for batchstring _r = "";

                string _batch = txt_Oper.Text.Trim();
                int _batchid = 0;
                _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where Batch = '" + _batch + "'"));

                if (_batchid != 0)
                {
                    BatchId = _batchid;
                }
                else
                {
                    _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from PROD_SerialAssembling where serial = '" + txt_Oper.Text.Trim() + "' order by id desc"));
                    if (_batchid == 0)
                    {
                        //Trying to read batch from scanned serial label
                        string _batchtry = "L" + txt_Oper.Text.Trim().Substring(0, txt_Oper.Text.Trim().IndexOf("-") < 0 ? 0 : txt_Oper.Text.Trim().IndexOf("-")).ToString();
                        _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where Batch = '" + _batchtry + "'"));
                        if (_batchid == 0)
                            _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where analog = '" + txt_Oper.Text.Trim() + "' or serial = '" + txt_Oper.Text.Trim() + "' order by id desc"));
                    }



                    if (_batchid != 0
                        && _batchid != BatchId)
                    {
                        BatchId = _batchid;
                    }
                    else
                    {
                        if (BatchId == 0)
                        {
                            DialogResult result = KryptonTaskDialog.Show("Error during label reading!",
                                                                             "You are trying to insert label without batch!",
                                                                             "Label reading data: " + txt_Oper.Text.Trim(),
                                                                             MessageBoxIcon.Warning,
                                                                            TaskDialogButtons.OK);
                        }
                        else
                        {
                            //Trying to insert
                            if (RegMode == -1)
                            {
                                //Simple registration
                                //if (ScanOrder == 1)
                                //    ScanOrder = 2;

                                if (ScanOrder == 2)
                                {
                                    _scanlabel = txt_Oper.Text;
                                    if (_Freezed != -1)
                                    {
                                        CMB_Components.AddSerialFreezed.frm_AddSerialFreezed frm = new CMB_Components.AddSerialFreezed.frm_AddSerialFreezed();
                                        frm.StageId = StageId;
                                        frm.BatchId = BatchId;
                                        frm.Serial = txt_Oper.Text.Trim();

                                        DialogResult result = frm.ShowDialog();

                                        if (result == DialogResult.OK)
                                            AddSerialFreezed(frm.StageId, frm.BatchId, frm.LaunchId, frm.Serial, frm.Position, frm.FreezedReasonId);
                                    }
                                    //Add New Serial
                                    //MessageBox.Show("Adding!");
                                    AddSerialTracing(StageId, BatchId, txt_Oper.Text.Trim());
                                    _RegMode = -1;
                                }
                            }
                            else
                            {
                                if (BatchId != 0)
                                {
                                    //Replace
                                    if (ScanOrder == 3)
                                    {
                                        _scanlabel = txt_Oper.Text.Trim();
                                        ScanOrder = 4;
                                    }
                                    else
                                    {
                                        _scanreplacement = txt_Oper.Text.Trim();
                                        //Replacement
                                        //MessageBox.Show("Replacement!");
                                        ReplaceSerialTracing(_scanlabel, StageId, _scanreplacement);
                                        RegMode = -1;
                                    }
                                }

                            }
                        }
                    }
                }

                //else
                //{
                //        SqlConnection conn = new SqlConnection(sConnStr);
                //        conn.Open();
                //        DataSet ds = new DataSet();

                //        SqlDataAdapter adapter =
                //            new SqlDataAdapter(
                //                "execute sp_SelectStockLabelDetsForMove @id = " + ReadValue + ", @batchid = " + BatchId, conn);


                //        conn.Close();

                //        adapter.Fill(ds);

                //        DataTable dt = ds.Tables[0];

                //        if (dt.Rows.Count > 0)
                //        {
                //        if (CheckRow(ReadValue) == true)
                //        {
                //            foreach (DataRow dr in dt.Rows)
                //            {
                //                InsertRow(Convert.ToInt32(dr["artid"]), dr["article"].ToString(), ReadValue, Convert.ToDouble(dr["qty"]), dr["unit"].ToString(),
                //                            dr["batch"].ToString(), Convert.ToInt32(dr["placeid"]), dr["place"].ToString(), dr["comments"].ToString(),
                //                            dr["datacode"].ToString(), dr["expdate"].ToString(), Convert.ToInt32(dr["bdid"]));
                //            }
                //            SetCellsColor();
                //        }
                //    }
                //        else
                //        {
                //            DialogResult result = KryptonTaskDialog.Show("Error during label reading!",
                //                                                     "Error during label reading!",
                //                                                     "Label reading data: " + txt_Oper.Text.Trim(),
                //                                                     MessageBoxIcon.Warning,
                //                                                     TaskDialogButtons.OK);
                //        }
                //}

                //Clear temp field
                txt_Oper.Text = "";
                txt_Oper.Focus();

            }
        }

        private void btn_DeleteDocs_Click(object sender, EventArgs e)
        {
            Counter = 0;
            txt_Result.Text = "";
            txt_Oper.Focus();
        }

        private void txt_Result_Click(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void txt_Result_Enter(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void cmb_BatchPDA1_BatchTextEntered(object sender)
        {
            txt_Oper.Focus();
        }

        private void cmb_BatchPDA1_BatchKeyPressed(object sender)
        {
            txt_Oper.Focus();
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            BatchId = 0;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            long _lastnum = 20200101000000;
            string _machinename = "";
            string _tablename = "";
            long _number = 0;
            int indexOfSubstring = 0;
            string sql = "";
            bool isserial = false;
            int succount = 0;
            int blockno = 0;
            string _group = "";

            //_lastnum = Convert.ToInt64(Helper.GetOneRecord("select top 1 LastNum from PROD_SerialLastUpload"));

            DataTable data = new DataTable();
            data.Columns.Add("lastnum", typeof(long));
            DataTable datatables = new DataTable();
            datatables.Columns.Add("tablename", typeof(string));
            datatables.Columns.Add("num", typeof(long));
            DataTable dataserials = new DataTable();
            dataserials.Columns.Add("serial", typeof(string));
            dataserials.Columns.Add("tablename", typeof(string));
            dataserials.Columns.Add("group", typeof(string));


            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT LastNum, MachineName FROM PROD_SerialLastUpload", sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                datatables.Clear();
                _lastnum = Convert.ToInt64(row["LastNum"]);
                _machinename = row["MachineName"].ToString();


                NpgsqlConnection con = new NpgsqlConnection(postgreConnStr);
                con.Open();

                sql = "SELECT table_name, " +
                                " right(table_name, 14)::int8 as lastnum" +
                                " FROM information_schema.tables " +
                                " WHERE table_type = 'BASE TABLE' " +
                                " AND (table_name like 'TB_Board_Block_" + _machinename + "%' or table_name like 'TB_Board_" + _machinename + "%')" +
                                " and right(table_name, 14)::int8 > " + _lastnum +
                                " and right(table_name, 14)::int8 < (select max(right(table_name, 14)::int8) " +
                                                                            " FROM information_schema.tables " +
                                                                            " WHERE table_type = 'BASE TABLE' " +
                                                                            " AND(table_name like 'TB_Board_Block_" + _machinename + "%' or table_name like 'TB_Board_" + _machinename + "%') " +
                                                                            " and right(table_name, 14)::int8 > " + _lastnum +
                                                                            " AND table_schema NOT IN " +
                                                                            "('pg_catalog', 'information_schema'))::int8 " +
                                " AND table_schema NOT IN " +
                                " ('pg_catalog', 'information_schema') order by right(table_name, 14)::int8, table_name; ";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                NpgsqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DataRow dr = datatables.NewRow();
                    dr["tablename"] = rdr.GetString(0).ToString();
                    dr["num"] = rdr.GetInt64(1);
                    datatables.Rows.Add(dr);
                    //MessageBox.Show(rdr.GetString(0).ToString());
                }
                rdr.Close();
                con.Close();

                pb_Progress.ThreadSafeCall(delegate
                {
                    pb_Progress.Value = 0;
                    pb_Progress.Maximum = datatables.Rows.Count;
                });

                //Clear serials for machine
                dataserials.Clear();

                foreach (DataRow tablerow in datatables.Rows)
                #region foreach
                {
                    isserial = false;
                    _tablename = tablerow["tablename"].ToString();
                    _number = Convert.ToInt64(tablerow["num"]);
                    //Check if exists such number
                    DataRow[] foundrow = data.Select("lastnum = " + _number + "");
                    if (foundrow.Length == 0)
                    {
                        lbl_Progess.ThreadSafeCall(delegate { lbl_Progess.Text = "Downloading: " + _tablename; });

                        // do something...
                        indexOfSubstring = _tablename.IndexOf("Block");

                        if (indexOfSubstring > 0)
                        #region if
                        {
                            //Board table
                            sql = "select \"ProgramName\", \"BoardID\" from public.\"" + _tablename.Replace("_Block", "") + "\" where \"BoardID\" is not null";
                            con.Open();
                            NpgsqlCommand cmd1 = new NpgsqlCommand(sql, con);

                            NpgsqlDataReader rdr1 = cmd1.ExecuteReader();
                            while (rdr1.Read())
                            {
                                isserial = rdr1.GetString(0).ToString().EndsWith("+");
                                if (isserial == true)
                                {
                                    DataRow drser = dataserials.NewRow();
                                    drser["serial"] = rdr1.GetString(1).ToString();
                                    drser["tablename"] = _tablename;
                                    drser["group"] = rdr1.GetString(1).ToString();
                                    dataserials.Rows.Add(drser);
                                    //MessageBox.Show(rdr.GetString(0).ToString());
                                }
                            }

                            rdr1.Close();
                            con.Close();


                            //Smotrim chitat li bloki, v program name konec = "+"

                            if (isserial == true)
                            {
                                con.Open();
                                //Block table
                                sql = "select \"BlockID\", \"BlockNo\" from public.\"" + _tablename + "\" where \"BlockID\" is not null ORDER BY \"ID\"";
                                NpgsqlCommand cmd2 = new NpgsqlCommand(sql, con);
                                NpgsqlDataReader rdr2 = cmd2.ExecuteReader();

                                while (rdr2.Read())
                                {
                                    try { blockno = Convert.ToInt32(rdr2.GetString(1).ToString()); }
                                    catch { blockno = 0; }
                                    if (blockno == 1)
                                        _group = rdr2.GetString(0).ToString();

                                    DataRow drser = dataserials.NewRow();
                                    drser["serial"] = rdr2.GetString(0).ToString();
                                    drser["tablename"] = _tablename;
                                    drser["group"] = _group;
                                    dataserials.Rows.Add(drser);
                                }

                                rdr2.Close();
                                con.Close();
                            }
                        }
                        else
                        {
                            //Simple table
                            con.Open();
                            //Block table
                            sql = "select \"ProgramName\", \"BoardID\" from public.\"" + _tablename + "\" where \"BoardID\" is not null";
                            NpgsqlCommand cmd2 = new NpgsqlCommand(sql, con);
                            NpgsqlDataReader rdr2 = cmd2.ExecuteReader();

                            while (rdr2.Read())
                            {
                                isserial = rdr2.GetString(0).ToString().EndsWith("+");
                                if (isserial == true)
                                {
                                    DataRow drser = dataserials.NewRow();
                                    drser["serial"] = rdr2.GetString(1).ToString();
                                    drser["tablename"] = _tablename;
                                    drser["group"] = "";
                                    dataserials.Rows.Add(drser);
                                }
                            }
                            rdr2.Close();
                            con.Close();

                        }
                        #endregion
                        //Add new row with number
                        DataRow dr = data.NewRow();
                        dr["lastnum"] = _number;
                        data.Rows.Add(dr);

                        pb_Progress.ThreadSafeCall(delegate { pb_Progress.Value = pb_Progress.Value + 1; });
                    }

                }
                #endregion

                //Uploading data to server

                lbl_Progess.ThreadSafeCall(delegate { lbl_Progess.Text = "Uploading data to server..."; });

                DataTable dataresult = ProdBll.UploadSerialNumbers(dataserials, _machinename);

                StringBuilder result = new StringBuilder();

                foreach (DataRow rowresult in dataresult.Rows)
                {
                    result.Append(rowresult["result"].ToString());
                    result.Append(Environment.NewLine);

                    //txt_Result.Text = rowresult["result"].ToString() + System.Environment.NewLine + txt_Result.Text;
                    if (rowresult["result"].ToString().StartsWith("SUCCESS!") == true)
                        succount++;

                }
                txt_Result.ThreadSafeCall(delegate { txt_Result.Text = result.ToString(); });
            }

            pb_Progress.ThreadSafeCall(delegate
            {
                pb_Progress.Value = 0;
            });

            lbl_Progess.Text = "Done! " + succount.ToString() + " records added!";
            txt_Oper.Focus();


        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_Result.Text);
            txt_Oper.Focus();
        }

        private void frm_SerialTracing_Activated(object sender, EventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }


        private void btn_AddAnalog_Click(object sender, EventArgs e)
        {
            frm_AddSerialAnalog frm = new frm_AddSerialAnalog();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                && frm.SerialNumber != ""
                && frm.Analogue != "")
            {
                AddSerialAnalogue(frm.SerialNumber, frm.Analogue, frm.AnalogAsPrimary);
            }
            txt_Oper.Focus();
        }
    }
}
