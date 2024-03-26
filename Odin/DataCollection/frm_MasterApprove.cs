using ComponentFactory.Krypton.Toolkit;
using Odin.CustomControls;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Workshop;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.DataCollection
{
    public delegate void DisplayKeyboardSymbolEventHandler(string symbol, bool symremove);

    public partial class frm_MasterApprove : BaseForm
    {
        public frm_MasterApprove()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
            NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
            this.gv_List.EditingControlShowing +=
                new DataGridViewEditingControlShowingEventHandler(gv_List_EditingControlShowing);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public int ReadValue = 0;
        public string Result = "";

        class_Global globClass = new class_Global();
        PrinterLabels PrintLabels = new PrinterLabels();
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        DC_BLL DCBll = new DC_BLL();

        private static KeyPressEventHandler NumericCheckHandler;
        
        PopupWindowHelper PopupHelper = null;
        frm_ScreenNumKeyboard popup;
        TextBox focusedtextbox;


        int _masterid = 0;

        public int MasterId
        {
            get { return _masterid; }
            set { _masterid = value; }
        }
        int _stateid = 0;
        /*
        0 - Available
        1 - At work
        2 - Paused             
        */
        public int StateId
        {
            get { return _stateid; }
            set { _stateid = value; }
        }

        public string Master
        {
            get { return txt_Master.Text; }
            set { txt_Master.Text = value; }
        }

        int _prevstageid = 0;
        public int PrevStageId
        {
            get { return _prevstageid; }
            set { _prevstageid = value; }
        }

        int _launchid = 0;

        public int LaunchId
        {
            get { return _launchid; }
            set { _launchid = value; }
        }

        string _launch = "";

        public string Launch
        {
            get { return txt_Launch.Text; }
            set { txt_Launch.Text = value; }
        }

        public double Qty
        {
            get { return Convert.ToDouble(txt_Qty.Text); }
            set { txt_Qty.Text = value.ToString(); }
        }

        public double QtyStarted
        {
            get { return Convert.ToDouble(txt_Started.Text); }
            set { txt_Started.Text = value.ToString(); }
        }

        public int NextStageId
        { get; set; }

        public string PrevStage
        { get; set; }

        public int AllowMoveBack
        { get; set; }

        public int IsNextStageLast
        { get; set; }

        public int ProdPlace
        {
            get
            {
                return rb_Valkas2.Checked == true ? 1 : rb_Valkas2B.Checked == true ? 2 : 0;
            }
            set
            {
                if (value == 1)
                {
                    rb_Valkas2.Checked = true;
                    rb_Valkas2B.Checked = false;
                }
                else if (value == 2)
                {
                    rb_Valkas2.Checked = false;
                    rb_Valkas2B.Checked = true;
                }
                else
                {
                    rb_Valkas2.Checked = false;
                    rb_Valkas2B.Checked = false;
                }
            }
        }

        public int StageId
        {
            get;set;
        }

        public double Freezed
        {
            get;set;
        }
        public double OldFreezed
        { get; set; }
        public int BatchId
        { get; set; }

        public int FreezedHasFocus
        {
            get;set;
        }
        

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
        public void FillList(int launchid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectSerialNumbersNA", LaunchId, ProdPlace);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;


                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["cn_toapprove"].Value = Convert.ToDouble(row.Cells["cn_qty"].Value);
                }


                SetCellsColor();
            });

            RecalcQty();
            //bn_.ThreadSafeCall(delegate
            //{
            //    bn_Materials.BindingSource = bs_Boxes;
            //});
        }

        public void FillData(int _batchid, int _stageid)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectBatchStageDets", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 3000;
            sqlComm.Parameters.AddWithValue("@batchid", _batchid);
            sqlComm.Parameters.AddWithValue("@stageid", _stageid);

            sqlConn.Open();

            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows == true)
            {
                reader.Read();

                PrevStage = reader["prevname"].ToString();
                PrevStageId = Convert.ToInt32(reader["previd"]);
                NextStageId = Convert.ToInt32(reader["nextid"]);
                AllowMoveBack = Convert.ToInt32(reader["allowmoveback"]);
                IsNextStageLast = Convert.ToInt32(reader["isnextstagelast"]);

                reader.Close();
            }
            else
                ClearFields();
            sqlConn.Close();

        }

        public void ClearFields()
        {

            PrevStage = "";
            PrevStageId = 0;
            NextStageId = 0;
            AllowMoveBack = -1;
            IsNextStageLast = 0;
        }

        public void RecalcQty()
        {
            gv_List.EndEdit();
            double _qty = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_check"].Value) == -1)
                    try
                    {
                        _qty = _qty + Convert.ToDouble(row.Cells["cn_toapprove"].Value);
                    }
                    catch { _qty = _qty + 0; }
            }
            Qty = _qty;
        }

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (symremove)
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value = symbol;
                gv_List.CurrentCell.Value = symbol;
            }
            else
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value += symbol;
                if (Convert.ToDouble(gv_List.CurrentCell.Value + symbol) <= Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value))
                    gv_List.CurrentCell.Value += symbol;
            }
            RecalcQty();
        }
                
        private void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
            {
                e.Handled = e.KeyChar == '-' ? s.Text.Contains(e.KeyChar) : !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }

        }
       
        private void gv_List_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gv_List.CurrentCell.ColumnIndex == 9)
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
            else
            {
                e.Control.KeyPress -= NumericCheckHandler;
            }
        }

        private float _measCellValue;
        public float MeasCellValue
        {
            get { return _measCellValue; }
            set { _measCellValue = value; }
        }

        #endregion

        #region Controls
        private void frm_MasterApprove_Load(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void frm_MasterApprove_Activated(object sender, EventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void ShowScreenNumKeyboard(DataGridViewCellEventArgs e, int columnIndex, int rowIndex)
        {
            string columnName = gv_List.Columns["cn_toapprove"].Name;

            //int rowHeight = dataGridView1.Rows[e.RowIndex].Height;
            int columnWidth = gv_List.Columns[columnName].Width;

            int ColumnIndex = columnIndex != -1 ? columnIndex : e.ColumnIndex;
            int RowIndex = rowIndex != -1 ? rowIndex : e.RowIndex;

            Rectangle cellRectangle = gv_List.GetCellDisplayRectangle(ColumnIndex, RowIndex, false);

            cellRectangle.X += gv_List.Left + columnWidth;
            cellRectangle.Y += gv_List.Top - 20;

            Point displayPoint = PointToScreen(new Point(cellRectangle.X, cellRectangle.Y));

            popup = new frm_ScreenNumKeyboard();
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            //popup.frm_MainOne = this;

            Form f;
            f = this.FindForm();

            PopupHelper.ShowPopup(f, popup, displayPoint);
        }

        private void ShowScreenNumKeyboardTB(TextBox _focusedtextbox)
        {
            //MessageBox.Show(focusedtextbox.Name);
            //focusedtextbox.Focus();
            popup = new frm_ScreenNumKeyboard();
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            //popup.frm_MainOne = this;

            Form f;
            f = this.FindForm();

            Point LocationPoint = _focusedtextbox.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X + _focusedtextbox.Width;
            int ypos = LocationPoint.Y;
            Point _location = new Point(xpos, ypos);

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);
        }
        #endregion

        private void btn_AssignMaster_Click(object sender, EventArgs e)
        {
            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.LabelText = "Scan your rfid: ";
            frm.HeaderText = "Scan your rfid: ";
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "execute sp_SelectMasterSN @rfid = '" + frm.FormText + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        if (Convert.ToInt32(dr1["isactive"]) == -1)
                        {
                            Master = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            MasterId = Convert.ToInt32(dr1["id"].ToString());
                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong master scanning! Your state is inactive!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");
                            Master = "";
                            MasterId = 0;
                        }
                    }
                }

                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong msater scanning! Your rfid is not correct or you have no master access!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your rfid is not correct!");
                    Master = "";
                    MasterId = 0;
                }
                sqlConn.Close();

                //FillList();

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }

            else
            {
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            if (MasterId != 0
                && LaunchId != 0)
            {
                if (Qty <= QtyStarted)
                {
                    //Save info
                    DataTable data = new DataTable();
                    data.Columns.Add("id", typeof(int));
                    data.Columns.Add("issn", typeof(int));
                    data.Columns.Add("qty", typeof(double));

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["chk_check"].Value) == -1
                            && Convert.ToDouble(row.Cells["cn_toapprove"].Value) > 0)
                        {
                            DataRow drser = data.NewRow();
                            drser["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                            drser["issn"] = Convert.ToInt32(row.Cells["cn_issn"].Value);
                            drser["qty"] = Convert.ToDouble(row.Cells["cn_toapprove"].Value);
                            data.Rows.Add(drser);
                        }
                    }

                    double _qty = 0;

                    _qty = Convert.ToDouble(Helper.getSP("sp_AddDataCollectionApprove", data, MasterId));

                    if (_qty > 0 || Freezed != OldFreezed)
                    {
                        //MessageBox.Show("Save launch");
                        int _res = Convert.ToInt32(Helper.getSP("sp_SaveLaunchStageProcess", LaunchId,
                            PrevStageId, StageId, NextStageId,
                            0,
                            _qty,
                            Freezed,
                            IsNextStageLast == -1 ? 0 : ProdPlace));
                    }

                    DialogResult result = KryptonTaskDialog.Show("Approving of info was successful!",
                                                                    "Approving of info was successful!",
                                                                    "",
                                                                    MessageBoxIcon.Information,
                                                                    TaskDialogButtons.OK);

                    LaunchId = 0;
                    BatchId = 0;
                    StageId = 0;
                    FillList(LaunchId);
                    FillData(0, 0);
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Started qty less than you want to approve!";
                    DialogResult result1 = frm1.ShowDialog();
                }
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Please check Master and Launch!";
                DialogResult result1 = frm1.ShowDialog();
            }
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            gv_List.ThreadSafeCall(delegate
            {
                
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    row.Cells["cn_toapprove"].Value = Convert.ToDouble(row.Cells["cn_qty"].Value);
                }


                SetCellsColor();

                RecalcQty();

            });

           
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChangeLaunch_Click(object sender, EventArgs e)
        {
            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.LabelText = "Scan launch: ";
            frm.HeaderText = "Scan launch: ";
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "select lh.id, lh.name, lh.stageid, lh.batchid, isnull(dbo.fn_PrevQualityStage(lh.id), 0) as prevstageid, " + 
                                    " convert(float, isnull(fb.qty, 0)) as freezed, convert(float, isnull(sta.qtystarted, 0)) as started " + 
                                    " from prod_launchhead lh " +
                                    " left join PROD_FreezedLaunchStages fb on fb.launchid = lh.id and fb.stageid = lh.stageid" +
                                    " left join (select lsh.launchid, sum(lsh.qty) as qtystarted from PROD_LaunchStagesHis lsh " + 
                                    "                   inner join PROD_LaunchHead lh1 on lh1.id = lsh.launchid and lsh.stageid = lh1.stageid" +
                                    "                    where lh1.name = '" + frm.FormText + "'" +                                    
                                    "                    group by lh1.batchid, lsh.stageid, lsh.launchid) sta on sta.launchid = lh.id" + 
                                    " where name = '" + frm.FormText + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        LaunchId = Convert.ToInt32(dr1["id"].ToString());
                        Launch = dr1["name"].ToString();
                        PrevStageId = Convert.ToInt32(dr1["prevstageid"].ToString());
                        StageId = Convert.ToInt32(dr1["stageid"].ToString());
                        Freezed = Convert.ToDouble(dr1["freezed"].ToString());
                        OldFreezed = Convert.ToDouble(dr1["freezed"].ToString());
                        BatchId = Convert.ToInt32(dr1["batchid"].ToString());
                        QtyStarted = Convert.ToDouble(dr1["started"].ToString()) - Convert.ToDouble(dr1["freezed"].ToString());
                    }
                }
                else
                {
                    //globClass.ShowMessage("Wrong launch scanning", "Please contact your master", "Your launch is not correct!");
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong launch scanning! Scan correct launch!";
                    DialogResult result1 = frm1.ShowDialog();
                    LaunchId = 0;
                    Launch = "";
                    PrevStageId = 0;
                    StageId = 0;
                    Freezed = 0;
                    OldFreezed = 0;
                    BatchId = 0;
                    QtyStarted = 0;
                }
                sqlConn.Close();
                FillList(LaunchId);
                FillData(BatchId, StageId);
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
            else
            {
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            if (gv_List.CurrentRow.Cells["chk_check"].Selected == true)
            {
                RecalcQty();
            }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {                
                if (e.ColumnIndex == 9
                    && Convert.ToInt32(gv_List.CurrentRow.Cells["cn_issn"].Value) == 0)
                {
                    //MessageBox.Show(gv_List.CurrentCell.OwningColumn.Name);
                    ShowScreenNumKeyboard(e, -1, -1);
                    popup.CellText = gv_List.CurrentRow.Cells["cn_toapprove"].FormattedValue.ToString();
                }
            }
        }

        private void gv_List_MouseUp(object sender, MouseEventArgs e)
        {
            //txt_Oper.Focus();
        }

        private void gv_List_MouseDown(object sender, MouseEventArgs e)
        {
            //txt_Oper.Focus();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //txt_Oper.Focus();
        }

        private void gv_List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_issn"].Value) == -1)
                    gv_List.CurrentRow.Cells["cn_toapprove"].Value = 1;
                else
                {
                    if (gv_List.CurrentCell.Value != null &&
                        gv_List.CurrentCell.Value.ToString() == "-")
                    {
                        gv_List.CurrentCell.Value = null;
                    }

                    var cellValue = gv_List.CurrentCell.Value;
                    if (cellValue != null)
                    {

                        if (gv_List.Rows[e.RowIndex].Cells["cn_toapprove"].Value.ToString() != "")
                        {
                            MeasCellValue = float.Parse(gv_List.Rows[e.RowIndex].Cells["cn_toapprove"].Value.ToString());
                        }

                    }
                }
            }
        }

        private void gv_List_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gv_List.CurrentRow != null)
                {
                    popup.CellText = gv_List.CurrentRow.Cells["cn_toapprove"].Value.ToString();
                }
            }
            catch { }
        }

        private void btn_DeleteSN_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _issn = 0;
            try {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _issn = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_issn"].Value);
            }
            catch { }
            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {
                if (MasterId != 0)
                {
                    Helper.getSP("sp_DeleteDataCollection", _id, _issn);
                    FillList(LaunchId);
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Select master!";
                    DialogResult result1 = frm1.ShowDialog();
                }
            }
           
        }
    }
    
}
