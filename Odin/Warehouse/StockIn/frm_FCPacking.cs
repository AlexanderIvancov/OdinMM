using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Odin.Warehouse.StockIn
{
    public partial class frm_FCPacking : KryptonForm
    {
        //private uint fPreviousExecutionState;

        public frm_FCPacking()
        {
            InitializeComponent();

            //// Set new state to prevent system sleep
            //fPreviousExecutionState = NativeMethods.SetThreadExecutionState(
            //    NativeMethods.ES_CONTINUOUS | NativeMethods.ES_SYSTEM_REQUIRED);
            //if (fPreviousExecutionState == 0)
            //{
            //    Console.WriteLine("SetThreadExecutionState failed. Do something here...");
            //    Close();
            //}

            timer.Interval = 300000;//для 10 минут значение меньше 600000
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }
        Timer timer = new Timer();

        bool flag;

        void timer_Tick(object sender, EventArgs e)
        {
            MouseSimulator.MoveMouseAround();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public int ReadValue = 0;
        public string Result = "";
        StockIn_BLL BLL = new StockIn_BLL();
        class_Global globClass = new class_Global();
        PrinterLabels PrintLabels = new PrinterLabels();
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        frm_EditBoxContent frm = null;
        frm_FCAdditContent frma = null;
        Helper MyHelper = new Helper();

        int _ContType = -1;

        public int OutMode
        {
            get { return _ContType; }
            set
            {
                _ContType = value;
                if (_ContType == -1)
                {
                    chk_Serial.CheckState = CheckState.Checked;
                    chk_Batch.CheckState = CheckState.Unchecked;
                    chk_Serial.BackColor = Color.LightPink;
                    chk_Batch.BackColor = Color.LightGreen;
                }
                else
                {
                    chk_Batch.CheckState = CheckState.Checked;
                    chk_Serial.CheckState = CheckState.Unchecked;
                    chk_Serial.BackColor = Color.LightGreen;
                    chk_Batch.BackColor = Color.LightPink;
                }
            }
        }

        public int BatchId
        { get; set; }

        public string Batch
        {
            get { return txt_Batch.Text; }
            set { txt_Batch.Text = value; }
        }

        public int tmpBatchId
        { get; set; }
        public string tmpBatch
        { get; set; }
        public int COId
        {
            get; set;
        }

        public string ConfOrder
        {
            get; set;
        }

        int _prodplace = 2;
        public int ProdPlace
        {
            get { return _prodplace; }
            set { _prodplace = value; }
        }

        #endregion

        #region Methods
        public void LoadColumns(DataGridView grid)
        {
            DAL.UserLogin = System.Environment.UserName;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectUserGridViewColumn", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@userid", DAL.UserId);
            sqlComm.Parameters.AddWithValue("@formname", this.Name);
            sqlComm.Parameters.AddWithValue("@gridname", grid.Name);

            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        if (column.Name == reader["columnname"].ToString())
                        {
                            column.DisplayIndex = Convert.ToInt32(reader["columnorder"]);
                            column.HeaderText = reader["columntext"].ToString();
                            column.Visible = globClass.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                    }

                }
                reader.Close();
            }

            sqlConn.Close();

        }
        public void ClearFields()
        {
            Batch = "";
            BatchId = 0;
            txt_Oper.Text = string.Empty;
            gv_List.Rows.Clear();
            tmpBatch = "";
            tmpBatchId = 0;
        }

        public void SetCellsColor()
        {

            foreach (DataGridViewRow row in this.gv_Boxes.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_closed"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);

            }

        }

        public bool CheckSave()
        {
            bool _res = true;
            int _countrows = 0;
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _countrows++;
            }
            if (_countrows > 0)
                _res = false;
            return _res;
        }

        public bool CheckBatch(string _serial)
        {
            bool _res = false;

            string _batchtry = "L" + _serial.Substring(0, _serial.IndexOf("-") < 0 ? 0 : _serial.IndexOf("-")).ToString();

            int _batchid = 0;
            int _packid = 0;
            int _prevbatchid = 0;

            _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where serial = '" + _serial + "' and stageid = 7"));
            //_batchid = _batchid == 0 ? Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where Batch = '" + _batchtry + "'")) : _batchid;

            foreach (DataGridViewRow row in gv_List.Rows)
            {
                _prevbatchid = Convert.ToInt32(row.Cells["cn_batchid"].Value);
            }


            if (_batchid == 0
                ||
                (_prevbatchid != 0 &&
                _prevbatchid != _batchid))
                _res = false;
            else
            {
                _packid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from sto_packcontent where sn = '" + _serial + "'"));
                _res = _packid == 0;
            }
            return _res;
        }

        public bool CheckRow(string _serial)
        {
            bool _res = true;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (row.Cells["cn_serial"].Value.ToString() == _serial)
                {
                    _res = false;
                    break;
                }

            }

            int _resdb = Convert.ToInt32(Helper.GetOneRecord("select id from sto_packcontent where sn = '" + _serial + "'"));
            if (_resdb != 0)
                _res = false;

            return _res;
        }

        public string ErrorMessage
        { get; set; }

        public bool CheckErrors(string _serial, string _original, string _analog, int _asprimary)
        {
            bool _res = true;
            ErrorMessage = "";
            //string _batchtry = "L" + _serial.Substring(0, _serial.IndexOf("-") < 0 ? 0 : _serial.IndexOf("-")).ToString();

            int _batchid = 0;
            int _packid = 0;
            int _counttmp = 0;
            int _prevbatchid = 0;

            //_batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 isnull(nullif(bh.groupid, 0), st.batchid) as batchid from prod_serialtracing st left join PROD_BatchHead bh on bh.id = st.batchid where (st.serial = '" + _serial + "' or st.analog = '" + _serial + "') and st.stageid = 7 "));

            //_batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where (serial = '" + _serial + "' or analog = '" + _serial + "') and stageid = 7 "));
            //_batchid = _batchid == 0 ? Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where Batch = '" + _batchtry + "'")) : _batchid;
            //_packid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from sto_packcontent where sn = '" + _serial + "'"));

            foreach (DataGridViewRow row in gv_List.Rows)
            {
                _prevbatchid = Convert.ToInt32(row.Cells["cn_batchid"].Value);
                if (row.Cells["cn_serial"].Value.ToString() == _serial)
                    _counttmp++;
            }

            //Check for group
            int isgroup = Convert.ToInt32(Helper.GetOneRecord("select top 1 isnull(groupid, 0) from prod_batchhead where id = " + _prevbatchid));
            _batchid = isgroup != 0
                ? Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where (serial = '" + _serial + "' or analog = '" + _serial + "') and stageid = 7 order by id desc"))
                : Convert.ToInt32(Helper.GetOneRecord("select top 1 ass.batchid from PROD_SerialAssembling ass inner join prod_serialtracing st on (st.serial = '" + _serial + "' or st.analog = '" + _serial + "') and st.stageid = 7  where ass.serial = '" + _serial + "' order by ass.id desc"));
            if (_batchid == 0)
                _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where (serial = '" + _serial + "' or analog = '" + _serial + "') and stageid = 7 order by id desc "));

            _packid = Convert.ToInt32(Helper.GetOneRecord("select top 1 pc.id from sto_packcontent pc inner join sto_delivpackmapping pm on pm.packid = pc.packid " +
                                       " where pc.sn = '" + _serial + "' and pm.batchid = " + _batchid));

            if (_asprimary == -1
                && _serial != _analog
                && _analog != "")
            {
                _res = false;
                ErrorMessage = "You scan original instead of analog!";
            }
            else if (_asprimary == 0
                && _serial != _original
                && _analog != "")
            {
                _res = false;
                ErrorMessage = "You scan analog instead of original!";
            }
            else if (_batchid == 0)
            {
                _res = false;
                ErrorMessage = "There is no such serial: " + _serial + " on FQC stage!";
            }
            else if (_prevbatchid != 0 &&
                _prevbatchid != _batchid)
            {
                _res = false;
                ErrorMessage = "Serial you trying to pack does not match to batch in current box!";
            }
            else if (_packid != 0)
            {
                _res = false;
                ErrorMessage = "You already packed this number in box no: " + (Helper.GetOneRecord("select top 1 p.boxno from sto_packcontent pc left join sto_package p on p.id = pc.packid where pc.sn = '" + _serial + "'")).ToString();
            }
            else if (_counttmp > 0)
            {
                _res = false;
                ErrorMessage = "Serial you trying to pack already packed in current box!";
            }
            else
            {
                _res = true;
                ErrorMessage = "";
            }


            return _res;
        }

        public void InsertRow(int artid, string article, string batch, string serial, int batchid, int coid, string conforder)
        {
            //dobavlaem index
            int _tmpindex = 0;
            try
            {
                _tmpindex = gv_List.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["cn_index"].Value));
            }
            catch { }
            _tmpindex++;


            gv_List.Rows.Add(_tmpindex,
                             artid,
                             article,
                             batch,
                             serial,
                             batchid,
                             coid,
                             conforder);

            gv_List.Sort(gv_List.Columns["cn_index"], ListSortDirection.Descending);
            gv_List.ClearSelection();
        }

        public void FillBoxes()
        {
            var data = (DataTable)Helper.getSP("sp_SelectBoxesNotPlaced");


            gv_Boxes.ThreadSafeCall(delegate
            {
                gv_Boxes.AutoGenerateColumns = false;
                bs_Boxes.DataSource = data;
                gv_Boxes.DataSource = bs_Boxes;

                SetCellsColor();
            });

            bn_Boxes.ThreadSafeCall(delegate
            {
                bn_Boxes.BindingSource = bs_Boxes;
            });
        }

        public void RecalcRowNumbers()
        {
            int _countrows = gv_List.Rows.Count;
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                row.Cells["cn_index"].Value = _countrows;
                _countrows--;
            }
        }
        #endregion

        #region Controls

        private void chk_Serial_CheckedChanged(object sender, EventArgs e)
        {
            //if (chk_Serial.CheckState == CheckState.Checked)
            //{
            //    OutMode = -1;
            //    txt_Oper.Focus();
            //}
            //else
            //{
            //    OutMode = 1;
            //    txt_Oper.Focus();
            //}
        }

        private void chk_Batch_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Batch.CheckState == CheckState.Checked)
            {
                OutMode = 1;
                //Open form for box header
                frm_FCPackHeader frm = new frm_FCPackHeader();
                frm.Mode(0);
                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    int _res = Convert.ToInt32(Helper.getSP("sp_AddStockInBoxHeader", frm.BatchId, frm.COId, frm.Package, frm.Qty, frm.WeightBrut, "", frm.BoxNO, frm.IsClosed, frm.ProdPlace));
                    BLL.AddedBox = _res != 0 ? frm.Package : "";
                    if (frm.IsClosed == -1)
                    {
                        ProdPlace = frm.ProdPlace;

                        string emailaddresses = ProdPlace == 1 ? DAL.EmailAddressesByType(13) : DAL.EmailAddressesByType(11);

                        //MessageBox.Show(emailaddresses);

                        string strMessage = "Box for " + frm.Batch + " is closed!";
                        strMessage = strMessage + "\r\nBox NO: " + frm.BoxNO.ToString();
                        strMessage = strMessage + "\r\nQty: " + frm.Qty.ToString();
                        strMessage = strMessage + "\r\nUser: " + System.Environment.UserName;
                        //strMessage = strMessage + "\r\nArticle: " + dr["custarticle"].ToString();
                        MyHelper.SendDirectEMail(globClass.ReplaceChar(emailaddresses, ";", ","), "[FC packing] Box for " + frm.Batch + " is closed!", strMessage);
                    }

                    DialogResult result1 = KryptonTaskDialog.Show("Box " + BLL.AddedBox + " was added succesfully!",
                                                                    "Box " + BLL.AddedBox + " was added succesfully!",
                                                                    "Box: " + BLL.AddedBox,
                                                                    MessageBoxIcon.Information,
                                                                    TaskDialogButtons.OK);

                    FillBoxes();
                    if (frm.IsClosed == -1)
                        PrintLabel(_res);
                    //btn_Print.PerformClick();
                    OutMode = -1;
                }
                if (result == DialogResult.Cancel)
                {
                    OutMode = -1;
                }

                //OutMode = -1;
                txt_Oper.Focus();
            }
            else
            {
                OutMode = -1;
                txt_Oper.Focus();
            }
        }


        private void frm_FCPacking_Activated(object sender, EventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void frm_FCPacking_Load(object sender, EventArgs e)
        {

            LoadColumns(gv_Boxes);

            FillBoxes();

            txt_Oper.Focus();
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (CheckSave() == false)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Deallocation warning!",
                                                               "Are you want to save changes?",
                                                               "You have moved but unsaved lines!",
                                                               MessageBoxIcon.Warning,
                                                               TaskDialogButtons.Yes |
                                                               TaskDialogButtons.No |
                                                               TaskDialogButtons.Cancel);
                if (result1 == DialogResult.Yes)
                {
                    btn_OK.PerformClick();
                    this.Close();
                }
                else if (result1 == DialogResult.No)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
                this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int _res = 0;
            int _isclosed = 0;
            gv_List.EndEdit();
            if (OutMode == -1
                && gv_List.RowCount > 0)
            {
                int _batchid = Convert.ToInt32(gv_List.Rows[0].Cells["cn_batchid"].Value);
                int _coid = Convert.ToInt32(gv_List.Rows[0].Cells["cn_coid"].Value);

                frm_FCPackHeader frm = new frm_FCPackHeader();
                frm.Mode(1);
                frm.BatchId = _batchid;
                frm.Qty = gv_List.RowCount;
                frm.IsClosed = 0;
                frm.ProdPlace = ProdPlace;


                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _res = Convert.ToInt32(Helper.getSP("sp_AddStockInBoxHeader", _batchid, _coid, frm.Package, frm.Qty, frm.WeightBrut, "", frm.BoxNO, frm.IsClosed, frm.ProdPlace));
                    BLL.AddedBox = _res != 0 ? frm.Package : "";

                    if (frm.IsClosed == -1
                        && _res != 0)
                    {
                        ProdPlace = frm.ProdPlace;
                        _isclosed = frm.IsClosed;

                        string emailaddresses = ProdPlace == 1 ? DAL.EmailAddressesByType(13) : DAL.EmailAddressesByType(11);
                        string strMessage = "Box for " + frm.Batch + " is closed!";
                        strMessage = strMessage + "\r\nBox NO: " + frm.BoxNO.ToString();
                        strMessage = strMessage + "\r\nQty: " + frm.Qty.ToString();
                        strMessage = strMessage + "\r\nUser: " + System.Environment.UserName;
                        strMessage = strMessage + "\r\nAddress: " + (ProdPlace == 1 ? "Valkas 2" : "Valkas 2B");
                        //strMessage = strMessage + "\r\nArticle: " + dr["custarticle"].ToString();
                        MyHelper.SendDirectEMail(globClass.ReplaceChar(emailaddresses, ";", ","), "[FC packing] Box for " + frm.Batch + " is closed!", strMessage);


                    }

                }

                if (_res != 0)
                {
                    DataTable dataserials = new DataTable();
                    dataserials.Columns.Add("serial", typeof(string));
                    dataserials.Columns.Add("tablename", typeof(string));

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        DataRow drser = dataserials.NewRow();
                        drser["serial"] = row.Cells["cn_serial"].Value.ToString();
                        drser["tablename"] = "";
                        dataserials.Rows.Add(drser);
                    }

                    Helper.getSP("sp_AddStockInBoxDets", _res, dataserials);

                    DialogResult result1 = KryptonTaskDialog.Show("Box " + BLL.AddedBox + " was added succesfully!",
                                                                    "Box " + BLL.AddedBox + " was added succesfully!",
                                                                    "Box: " + BLL.AddedBox,
                                                                    MessageBoxIcon.Information,
                                                                    TaskDialogButtons.OK);

                    try
                    {
                        gv_Boxes.ThreadSafeCall(delegate { FillBoxes(); });
                    }
                    catch { }
                    if (_isclosed == -1)
                        PrintLabel(_res);
                    //btn_Print.PerformClick();
                    ClearFields();
                }
                txt_Oper.Focus();
            }
            //MessageBox.Show(CheckBatch("T200811-ASAS").ToString());
            //MessageBox.Show(CheckBatch("T2008").ToString());
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (globClass.ClearConfirm() == true)
            {
                ClearFields();
                txt_Oper.Focus();
            }
            else
            {
                txt_Oper.Focus();
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gv_List.SelectedRows)
            {
                gv_List.Rows.Remove(row);
            }

            RecalcRowNumbers();

            gv_List.ClearSelection();

            txt_Oper.Focus();
        }



        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //MessageBox.Show(_ContType.ToString());
                if (_ContType == -1) //Only in this case adding Serial
                {
                    //Check for Batch

                    string _serial = txt_Oper.Text.Trim();
                    string _original = "";
                    string _analog = "";
                    int _asprimary = 0;

                    SqlConnection sqlConn = new SqlConnection(sConnStr);
                    sqlConn.Open();
                    DataSet ds1 = new DataSet();

                    SqlDataAdapter adapter1 =
                        new SqlDataAdapter(
                            "execute sp_SelectCheckSerialsPacking @serial = '" + _serial + "'", sqlConn);

                    adapter1.Fill(ds1);

                    DataTable dt1 = ds1.Tables[0];

                    if (dt1.Rows.Count > 0)
                    {
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            _original = dr1["original"].ToString();
                            _analog = dr1["analog"].ToString();
                            _asprimary = Convert.ToInt32(dr1["asprimary"]);
                        }
                    }
                    sqlConn.Close();
                    if (CheckErrors(_serial, _original, _analog, _asprimary) == true
                        //&& CheckBatch(_serial) == true
                        //&& CheckRow(_serial) == true
                        )
                    {
                        SqlConnection conn = new SqlConnection(sConnStr);
                        conn.Open();
                        DataSet ds = new DataSet();

                        SqlDataAdapter adapter =
                            new SqlDataAdapter(
                                "execute sp_SelectSerialNrDets @serial = '" + _serial + "'", conn);

                        adapter.Fill(ds);

                        DataTable dt = ds.Tables[0];

                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                if (Convert.ToInt32(dr["artid"]) != 0)
                                    InsertRow(Convert.ToInt32(dr["artid"]), dr["article"].ToString(), dr["batch"].ToString(), _serial, Convert.ToInt32(dr["batchid"]),
                                                         Convert.ToInt32(dr["coid"]), dr["conforder"].ToString());
                            }
                            SetCellsColor();

                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Something wrong! There is no article for this SN: " + _serial + " !";
                            DialogResult result = frm1.ShowDialog();
                            //if (result == DialogResult.Cancel)
                            //{
                            //    txt_Oper.Focus();
                            //}
                            //frm1.MessageText = "";

                            //DialogResult result = KryptonTaskDialog.Show("Error during serial number reading!",
                            //                                        "Something wrong! There is no article for this SN!",
                            //                                        "Serial: " + txt_Oper.Text.Trim(),
                            //                                        MessageBoxIcon.Warning,
                            //                                        TaskDialogButtons.Close);
                        }
                        conn.Close();
                    }
                    else
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        frm_Error frm1 = new frm_Error();
                        //frm1.HeaderText = "Serial number " + _serial + " already packed or belongs to other batch, or there are no batch for this SN, or SN is not on FQC stage!";
                        frm1.HeaderText = ErrorMessage;
                        DialogResult result = frm1.ShowDialog();
                        //if (result == DialogResult.Cancel)
                        //{
                        //    txt_Oper.Focus();
                        //}

                        //DialogResult result = KryptonTaskDialog.Show("Error during serial number reading!",
                        //                                             "Serial number already packed or belongs to other batch, or there are no batch for this SN, or SN is not on FQC stage!",
                        //                                             "Serial: " + txt_Oper.Text.Trim(),
                        //                                             MessageBoxIcon.Warning,
                        //                                             TaskDialogButtons.Close);
                    }

                }

                //Clear temp field
                txt_Oper.Text = "";
                txt_Oper.Focus();

            }
        }

        private void btn_DeleteBox_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_bid"].Value); }
            catch { }

            if (_packid != 0
                && globClass.DeleteConfirm() == true)
            {
                Helper.getSP("sp_DeleteStockInBox", _packid);
                FillBoxes();
                txt_Oper.Focus();
            }
            else
            { txt_Oper.Focus(); }
        }

        private void btn_BoxContent_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_bid"].Value); }
            catch { }

            if (_packid != 0)
            {
                var _query = "sp_SelectBatchBoxContent";

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@packid",SqlDbType.Int) {Value = _packid}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Box content";
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show(); frm.GetKryptonFormFields();
            }
        }


        private void btn_Print_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_bid"].Value); }
            catch { }

            //MessageBox.Show(_packid.ToString());
            if (_packid != 0)
            {
                PrintLabel(_packid);
            }
        }

        public void PrintLabel(int _packid)
        {
            frm_Print frm = new frm_Print();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT TOP 1 lt.ip, sp.name, sp.dpi from bas_labeltemplate lt inner join sys_printers sp on sp.ipadress = lt.ip where lt.id = 7", sConnStr);

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

            frm.LabelQty = 2;
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintLabels.PrinterIp = frm.IP_Address;
                PrintLabels.PrinterDPI = frm.Printer_DPI;

                var sqlparamsfields = new List<SqlParameter>()
                        {
                            new SqlParameter("@packid",SqlDbType.Int) {Value = _packid},
                            new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                        };
                if (frm.LabelQty != 0)
                    PrintLabels.PrintLabel(PrintLabels.LabelConstructor(7, "sp_SelectBatchBoxDet", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                txt_Oper.Focus();
            }
            else
            { }
        }

        private void btn_EditBox_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            string _batch = "";
            double _qty = 0;
            string _package = "";
            int _boxno = 0;
            double _weight = 0;
            int _closed = 0;
            int _prodplaceid = 0;

            try
            {
                _packid = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_bid"].Value);
                _batch = gv_Boxes.CurrentRow.Cells["cn_bbatch"].Value.ToString();
                _package = gv_Boxes.CurrentRow.Cells["cn_bpackage"].Value.ToString();
                _qty = Convert.ToDouble(gv_Boxes.CurrentRow.Cells["cn_bqty"].Value);
                _weight = Convert.ToDouble(gv_Boxes.CurrentRow.Cells["cn_bweightbrut"].Value);
                _boxno = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_bboxno"].Value);
                _closed = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_closed"].Value);
                _prodplaceid = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_prodplaceid"].Value);
            }
            catch { }

            if (_packid != 0)
            {
                if (globClass.IsFormAlreadyOpen("frm_FCPackHeader")) return;

                frm_FCPackHeader frm = new frm_FCPackHeader();
                frm.Mode(-1);
                frm.Batch = _batch;
                frm.Qty = _qty;
                frm.Package = _package;
                frm.Id = _packid;
                frm.BoxNO = _boxno;
                frm.WeightBrut = _weight;
                frm.IsClosed = _closed;
                frm.ProdPlace = _prodplaceid == 0 ? ProdPlace : _prodplaceid;


                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Helper.getSP("sp_EditStockInBoxHeader", _packid, frm.Package, frm.Qty, frm.WeightBrut, "", frm.BoxNO, frm.IsClosed, frm.ProdPlace);
                    if (_closed != frm.IsClosed
                        && frm.IsClosed == -1)
                    {
                        ProdPlace = frm.ProdPlace;

                        string emailaddresses = ProdPlace == 1 ? DAL.EmailAddressesByType(13) : DAL.EmailAddressesByType(11);
                        string strMessage = "Box for " + frm.Batch + " is closed!";
                        strMessage = strMessage + "\r\nBox NO: " + frm.BoxNO.ToString();
                        strMessage = strMessage + "\r\nQty: " + frm.Qty.ToString();
                        strMessage = strMessage + "\r\nUser: " + System.Environment.UserName;
                        strMessage = strMessage + "\r\nAddress: " + (ProdPlace == 1 ? "Valkas 2" : "Valkas 2B");
                        //strMessage = strMessage + "\r\nArticle: " + dr["custarticle"].ToString();
                        MyHelper.SendDirectEMail(globClass.ReplaceChar(emailaddresses, ";", ","), "[FC packing] Box for " + frm.Batch + " is closed!", strMessage);

                        //btn_Print.PerformClick();
                        PrintLabel(_packid);
                    }
                    //_res = BLL.AddStockInBoxHeader(_batchid, _coid, frm.Package, frm.Qty, frm.WeightBrut, "", frm.BoxNO);
                    FillBoxes();
                    //gv_Boxes.ThreadSafeCall(delegate { SetCellsColor(); });
                }
                txt_Oper.Focus();
            }
        }

        private void EditClosed(object sender)
        {
            frm.Close();
            FillBoxes();
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }

        private void AdditClosed(object sender)
        {
            Helper.getSP("sp_AddStockInBoxAdditContent", frma.Id, frma.TextLabel, frma.Qty);

            frma.Close();
            FillBoxes();
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }

        #endregion

        private void chk_Serial_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_Serial.CheckState == CheckState.Checked)
            {
                _ContType = -1;
                //    OutMode = -1;
                txt_Oper.Focus();
            }
            else
            {
                _ContType = 1;
                //    OutMode = 1;
                txt_Oper.Focus();
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Boxes_SelectionChanged(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Boxes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_Click(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Boxes_Click(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void txt_Oper_Leave(object sender, EventArgs e)
        {
            //txt_Oper.Focus();
        }

        private void mni_AdminD_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for boxes list";
            frm.grid = this.gv_Boxes;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Boxes);
            }
        }

        private void gv_Boxes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_EditContent_Click(object sender, EventArgs e)
        {
            gv_Boxes.Invoke(new MethodInvoker(delegate
            {
                int _packid = 0;
                int _batchid = 0;
                int _closed = 0;

                try
                {
                    _packid = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_bid"].Value);
                    _batchid = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_bbatchid"].Value);
                    _closed = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_closed"].Value);
                }
                catch { }

                if (_packid != 0)
                {
                    if (_closed == 0)
                    {
                        frm = new frm_EditBoxContent();
                        frm.PackId = _packid;
                        frm.BatchId = _batchid;
                        frm.gv_List.Invoke(new MethodInvoker(delegate { frm.FillList(_packid); }));
                        frm.FormClosed1 += new FCClosingEventHandler1(EditClosed);

                        frm.ShowDialog();
                    }
                    //DialogResult result = KryptonTaskDialog.Show("Error during serial number reading!",
                    //                                             "Serial number already packed or belongs to other batch, or there are no batch for this SN, or SN is not on FQC stage!",
                    //                                             "Serial: " + txt_Oper.Text.Trim(),
                    //                                             MessageBoxIcon.Warning,
                    //                                             TaskDialogButtons.Close);

                }

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }));
        }

        private void frm_FCPacking_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Dispose();
        }

        private void btn_AdditContent_Click(object sender, EventArgs e)
        {
            gv_Boxes.Invoke(new MethodInvoker(delegate
            {
                int _packid = 0;
                int _closed = 0;

                try
                {
                    _packid = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_bid"].Value);
                    _closed = Convert.ToInt32(gv_Boxes.CurrentRow.Cells["cn_closed"].Value);
                }
                catch { }

                if (_packid != 0)
                {
                    if (_closed == 0)
                    {
                        frma = new frm_FCAdditContent();
                        frma.Id = _packid;
                        frma.FormClosed1 += new FCClosingEventHandler1(AdditClosed);

                        frma.ShowDialog();
                        //frma.txt_Label.Focus();
                    }

                }

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }));
        }
    }
    //internal static class NativeMethods
    //{
    //    // Import SetThreadExecutionState Win32 API and necessary flags
    //    [DllImport("kernel32.dll")]
    //    public static extern uint SetThreadExecutionState(uint esFlags);
    //    public const uint ES_CONTINUOUS = 0x80000000;
    //    public const uint ES_SYSTEM_REQUIRED = 0x00000001;
    //}
}
