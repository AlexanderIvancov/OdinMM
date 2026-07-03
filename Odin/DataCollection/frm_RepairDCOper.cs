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
using Odin.Tools;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading;
using Odin.CustomControls;
using Odin.Workshop;

namespace Odin.DataCollection
{
    public partial class frm_RepairDCOper : BaseForm
    {
        public frm_RepairDCOper()
        {
            InitializeComponent();
            NumericCheckHandler = new KeyPressEventHandler(NumericCheck);
            PopupHelper = new PopupWindowHelper();
        }


        #region Variables
        private static KeyPressEventHandler NumericCheckHandler;
        frm_ScreenNumKeyboard popup;
        PopupWindowHelper PopupHelper = null;
        KryptonTextBox focusedtextbox;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public int ReadValue = 0;
        public string Result = "";

        class_Global globClass = new class_Global();
        PrinterLabels PrintLabels = new PrinterLabels();
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        DC_BLL DCBll = new DC_BLL();
        frm_cmbTextPDA_NC frmSer = null;

        string _worker = "";
        int _workerid = 0;
        public string Worker
        {
            get { return txt_Worker.Text; }
            set { txt_Worker.Text = value; }
        }

        public int WorkerId
        {
            get { return _workerid; }
            set { _workerid = value; }
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

        string _launch = "";

        public string Launch
        {
            get { return txt_Launch.Text; }
            set { txt_Launch.Text = value; }
        }

        int _launchid = 0;

        public int LaunchId
        {
            get { return _launchid; }
            set { _launchid = value; }
        }

        int _workid = 0;

        int _prevstageid = 0;
        public int PrevStageId
        {
            get { return _prevstageid; }
            set { _prevstageid = value; }
        }

        public int WorkId
        {
            get { return _workid; }
            set { _workid = value; }
        }
        
        Processing_BLL ProdBll = new Processing_BLL();

        public int ProdPlace
        {
            get { return cmb_CommonPDA1.SelectedValue; }
            set { cmb_CommonPDA1.SelectedValue = value; }
        }
        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                //if (Convert.ToInt32(row.Cells["cn_islast"].Value) == -1)
                //    row.DefaultCellStyle.BackColor = Color.Gold;
                //    //foreach (DataGridViewCell cell in row.Cells)
                //    //    cell.Style.BackColor = Color.Gold;

                //if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
                //    row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                ////foreach (DataGridViewCell cell in row.Cells)
                ////    cell.Style.BackColor = Color.FromArgb(192, 255, 192);

                //if (Convert.ToInt32(row.Cells["cn_headid"].Value) == 0)
                //    row.Cells["cn_index"].Style.BackColor = Color.Orange;
            }
        }
        public void FillList(int _launchid)
        {
            var data = DC_BLL.getSerialRepairs(_launchid);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });

            //bn_.ThreadSafeCall(delegate
            //{
            //    bn_Materials.BindingSource = bs_Boxes;
            //});
        }

        public void FillMaterials(int _launchid)
        {
            var data = DC_BLL.getMaterialsRepairs(_launchid);


            gv_Materials.ThreadSafeCall(delegate
            {
                gv_Materials.AutoGenerateColumns = false;
                bs_Materials.DataSource = data;
                gv_Materials.DataSource = bs_Materials;

                //SetCellsColor();
            });

            bn_Materials.ThreadSafeCall(delegate
            {
                bn_Materials.BindingSource = bs_Materials;
            });
        }

        public void FillMaterialsByLaunch(int _launchid)
        {
            var data = DC_BLL.getMaterialsRepairs(_launchid);


            gv_Materials.ThreadSafeCall(delegate
            {
                gv_Materials.AutoGenerateColumns = false;
                bs_Materials.DataSource = data;
                gv_Materials.DataSource = bs_Materials;

                //SetCellsColor();
            });

            bn_Materials.ThreadSafeCall(delegate
            {
                bn_Materials.BindingSource = bs_Materials;
            });
        }

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

        public List<int> ParsedOperations;

        public int CheckOperNO()
        {
            return ParsedOperations.Count;        
        }

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (symremove)
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value = symbol;
                focusedtextbox.Text = symbol;
            }
            else
            {
                //dataGridView1.CurrentRow.Cells["cn_value"].Value += symbol;
                focusedtextbox.Text += symbol;
            }

            ParsedOperations = globClass.StringToIntList(focusedtextbox.Text);
        }

        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            TextBox s = sender as TextBox;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void ShowScreenNumKeyboard(KryptonTextBox _focusedtextbox)
        {
            //MessageBox.Show(focusedtextbox.Name);
            //focusedtextbox.Focus();
            popup = new frm_ScreenNumKeyboard();
            popup.ManyDecimals = true;
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            //popup.FormClosing += new FormClosingEventHandler(FocusOn);
            
            //popup.frm_MainOne = this;

            Form f;
            f = this.FindForm();

            Point LocationPoint = _focusedtextbox.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X - popup.Width;//+ _focusedtextbox.Width;
            int ypos = LocationPoint.Y;
            Point _location = new Point(xpos, ypos);

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);
        }

        //public void FocusOn(object sender, FormClosingEventArgs e)
        //{
        //    txt_Oper.Text = string.Empty;
        //    txt_Oper.Focus();

        //    foreach (int OperNO in ParsedOperations.OrderBy(num => num))
        //        DCBll.CheckLaunchParamNecessity(LaunchId, OperNO);

        //    //MessageBox.Show(OldOperNO.ToString() + " " + OperNO.ToString() + " " + LaunchId.ToString() + " " + WorkerId.ToString());
        //    foreach (int OperNO in ParsedOperations.OrderBy(num => num))
        //    {
        //        if (DCBll.CheckParameters == -1
        //          && LaunchId != 0
        //          && WorkerId != 0)
        //        {
        //            frm_AdditContent frm = new frm_AdditContent();
        //            frm.Instructions = DCBll.CheckInstructions;
                    
        //            DialogResult result = frm.ShowDialog();

        //            frm.CheckEmpty();


        //            if (result == DialogResult.OK)
        //            {
        //                DCBll.AddDataCollectionCheckParams(WorkerId, LaunchId, OperNO, frm.Parameters);

        //                txt_Oper.Text = string.Empty;
        //                txt_Oper.Focus();
        //            }
        //        }
        //    }
        //}
              

        public void FocusOnGvUpdate(object sender, FormClosingEventArgs e)
        {
            FillList(LaunchId);
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }
        #endregion

        #region Controls
        private void frm_WorkerDCOper_Activated(object sender, EventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void frm_WorkerDCOper_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            LoadColumns(gv_Materials);
            txt_Oper.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChangeWorker_Click(object sender, EventArgs e)
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
                        "execute sp_SelectWorkerSN @rfid = '" + frm.FormText + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        if (Convert.ToInt32(dr1["isactive"]) == -1)
                        {
                            Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            WorkerId = Convert.ToInt32(dr1["id"].ToString());
                            this.TabText = "Repairs processing (" + dr1["name"].ToString() + ")";
                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong worker scanning! Your state is inactive! Please contact your master!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");
                            Worker = "";
                            WorkerId = 0;
                        }
                    }
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong worker scanning! Your rfid is not correct! Please contact your master!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your rfid is not correct!");
                    Worker = "";
                    WorkerId = 0;
                }
                sqlConn.Close();
              
                ParsedOperations?.Clear();
                //IsLast = 0;
                
                LaunchId = 0;
                Launch = "";

                FillList(LaunchId);
               
                ParsedOperations?.Clear();
                //FillMaterials(WorkerId);
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }

            else
            {
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        public void CheckViza(int LaunchId)
        {
            int _res = Convert.ToInt32(Helper.GetOneRecord("select lh.id from PROD_LaunchHead lh where lh.id = " + LaunchId + " and isnull(lh.qualvisaby, '') != '' and isnull(lh.ingenvisaby, '') != ''"));
            int _res1 = Convert.ToInt32(Helper.GetOneRecord("select lh.id from PROD_LaunchAdditVisas lh where lh.launchid = " + LaunchId + " and isnull(lh.qualvisaby, '') != '' and isnull(lh.ingenvisaby, '') != ''"));
            if (_res == 0
                && _res1 == 0)
                lbl_Viza.Visible = true;
            else
                lbl_Viza.Visible = false;
        }

        private void btn_ChangeLaunch_Click(object sender, EventArgs e)
        {
            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.LabelText = "Scan launch: ";
            frm.HeaderText = "Scan launch: ";
            frm.FormText = Launch;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "select id, name, isnull(dbo.fn_PrevQualityStage(id), 0) as prevstageid from prod_launchhead where name = '" + frm.FormText + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        LaunchId = Convert.ToInt32(dr1["id"].ToString());
                        Launch = dr1["name"].ToString();
                        PrevStageId = Convert.ToInt32(dr1["prevstageid"].ToString());
                    }
                    FillList(LaunchId);
                    FillMaterials(LaunchId);
                    CheckViza(LaunchId);
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
                    FillList(LaunchId);
                    FillMaterials(0);
                    lbl_Viza.Visible = false;
                }
                sqlConn.Close();
                txt_Oper.Text = "";
                txt_Oper.Focus();

                ParsedOperations?.Clear();
                //OperNO = 0;
                //IsLast = 0;
            }
            else
            {
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
            txt_Oper.Focus();
        }

        private void btn_DeleteMT_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_Materials.CurrentRow.Cells["cn_bid"].Value); }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {
                string _res = DCBll.DeleteDataCollectionMaterial(_id);
                if (DCBll.SuccessId == -1)
                    FillMaterials(LaunchId);
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Something wrong! " + _res;
                    DialogResult result1 = frm1.ShowDialog();
                }
                txt_Oper.Text = "";
                //ParsedOperations?.Clear();
                txt_Oper.Focus();
            }
        }

        private void btn_DeleteSN_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _serial = "";

            

            //try
            //{
            //    _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            //    _serial = gv_List.CurrentRow.Cells["cn_serial"].Value.ToString();
            //}
            //catch { }

            if (/*_id != 0
                &&*/ globClass.DeleteConfirm() == true)
            {
                foreach (DataGridViewRow row in this.gv_List.SelectedRows)
                {
                    try
                    {
                        _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                        _serial = row.Cells["cn_serial"].Value.ToString();
                    }
                    catch { }
                    DCBll.DeleteDataCollectionRepair(_id);
                    //string _res = DCBll.DeleteDataCollectionSerial(_id, _serial);
                    //if (DCBll.SuccessId == -1)
                    //    FillList(WorkerId, LaunchId);
                    //else
                    //{
                    //    System.Media.SystemSounds.Exclamation.Play();
                    //    frm_Error frm1 = new frm_Error();
                    //    frm1.HeaderText = "Something wrong! " + _res;
                    //    DialogResult result1 = frm1.ShowDialog();
                    //}
                }
                FillList(LaunchId);
                txt_Oper.Text = "";
                //ParsedOperations?.Clear();
                txt_Oper.Focus();
            }
        }


        private void mni_AdminS_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for serials list";
            frm.grid = this.gv_List;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_List);
            }
        }

        private void mni_AdminM_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for materials list";
            frm.grid = this.gv_Materials;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Materials);
            }

        }
              
      
        public string TmpSerial
        { get; set; }
       
        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (WorkerId == 0
                    || LaunchId == 0)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Empty fields detected! Please check worker or launch!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Empty fields detected!", "Please check worker or launch", "Launch or worker are empty!");
                    txt_Oper.Focus();
                }
                else
                {
                    string _serial = txt_Oper.Text.Trim();

                   
                    //string _res = "";

                    if (_serial != "")
                    {
                        if (DAL.CheckLabel(_serial) == true)
                        {
                            DCBll.AddDataCollectionMaterialRepair(WorkerId, _serial, LaunchId);
                            FillMaterialsByLaunch(LaunchId);
                        }
                        else
                        {
                            DataTable dataplaces = new DataTable();
                            dataplaces.Columns.Add("string", typeof(string));
                            dataplaces.Columns.Add("2ndstring", typeof(string));

                            frm_AddRepairDets frm = new frm_AddRepairDets();
                            frm.Serial = _serial;
                            frm.Mode = 1;
                            frm.FillList();

                            DialogResult result = frm.ShowDialog();


                            if (result == DialogResult.OK)
                            {
                                frm.gv_Defects.EndEdit();
                                foreach (DataGridViewRow row in frm.gv_Defects.Rows)
                                {
                                    if (row.Cells["cn_positions"].Value.ToString().Trim() != "")
                                    {
                                        DataRow dr = dataplaces.NewRow();
                                        dr["string"] = row.Cells["cn_Code"].Value.ToString();
                                        dr["2ndstring"] = row.Cells["cn_positions"].Value.ToString();
                                        dataplaces.Rows.Add(dr);
                                    }
                                }

                                DCBll.AddDataCollectionRepair(WorkerId, LaunchId, _serial, frm.Qty, ProdPlace, frm.WorkTime, dataplaces);
                                FillList(LaunchId);
                                // _res = DCBll.AddDataCollectionSerialOper(WorkerId, _serial, LaunchId, PrevStageId, OperNO, OperNO == 0 ? -1 : IsLast(OperNO), cmb_CommonPDA1.SelectedValue);
                                //MessageBox.Show(DCBll.SuccessId.ToString());
                                //if (DCBll.SuccessId == -1)
                                //    FillList(WorkerId, LaunchId);
                                //else if (DCBll.SuccessId == 1)
                                //    FillMaterialsByLaunch(LaunchId);
                                //else if (DCBll.SuccessId == -2)
                                //{
                                //    TmpSerial = _serial;
                                //    ShowFrmAnalog();
                                //}
                                //else
                                //{
                                //    System.Media.SystemSounds.Exclamation.Play();
                                //    frm_Error frm1 = new frm_Error();
                                //    frm1.HeaderText = "Something wrong! " + _res;
                                //    DialogResult result = frm1.ShowDialog();
                                //}
                                txt_Oper.Text = "";
                                txt_Oper.Focus();
                            }
                            else
                            {
                                txt_Oper.Text = "";
                                txt_Oper.Focus();
                            }
                        }
                    }
                }
            }
        }

        private void btn_DirectQty_Click(object sender, EventArgs e)
        {
            if (WorkerId == 0
                || LaunchId == 0

                )
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Empty fields detected! Please check worker or launch!";
                DialogResult result1 = frm1.ShowDialog();
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
            else
            {
                DataTable dataplaces = new DataTable();
                dataplaces.Columns.Add("string", typeof(string));
                dataplaces.Columns.Add("2ndstring", typeof(string));

                frm_AddRepairDets frm = new frm_AddRepairDets();
                frm.Serial = "";
                frm.Mode = 2;
                frm.FillList();

                DialogResult result = frm.ShowDialog();
               
                if (result == DialogResult.OK)
                {
                    frm.gv_Defects.EndEdit();
                    foreach (DataGridViewRow row in frm.gv_Defects.Rows)
                    {
                        if (row.Cells["cn_positions"].Value.ToString().Trim() != "")
                        {
                            //MessageBox.Show( row.Cells["cn_positions"].Value.ToString());
                            DataRow dr = dataplaces.NewRow();
                            dr["string"] = row.Cells["cn_Code"].Value.ToString();
                            dr["2ndstring"] = row.Cells["cn_positions"].Value.ToString();
                            dataplaces.Rows.Add(dr);
                        }
                    }
                    DCBll.AddDataCollectionRepair(WorkerId, LaunchId, "", frm.Qty, ProdPlace, frm.WorkTime, dataplaces);
                    //DCBll.AddDataCollectionRepair(WorkerId, LaunchId, "", frm.Qty, ProdPlace, frm.WorkTime, dataplaces);
                    FillList(LaunchId);
                }
            }
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }


        #endregion

        private void chk_IsLast_CheckedChanged(object sender, EventArgs e)
        {
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }
               
        public void AddManualSerial(string _Serial)
        {
            string _serial = _Serial;
            string _res = "";
            foreach (int OperNO in ParsedOperations.OrderBy(num => num))
            {
                //_res = DCBll.AddDataCollectionSerialOper(WorkerId, _serial, LaunchId, PrevStageId, OperNO, OperNO == 0 ? -1 : IsLast(OperNO), cmb_CommonPDA1.SelectedValue);
                if (DCBll.SuccessId == -1)
                    FillList(LaunchId);
                else if (DCBll.SuccessId == 1)
                    FillMaterials(LaunchId);
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Something wrong! " + _res;
                    DialogResult result = frm1.ShowDialog();
                }
            }
        }
               

        public void FillPlace()
        {
            int _id = 0;
            try
            {
               _id = Convert.ToInt32(Helper.GetOneRecord("select placeid from SYS_PCPlaces where pcname = '" + System.Environment.MachineName + "'"));
            }
            catch { }
            cmb_CommonPDA1.SelectedValue = _id;
        }

        private void btn_SetPlace_Click(object sender, EventArgs e)
        {
            DAL.MakeDefaultPlace(cmb_CommonPDA1.SelectedValue);
        }

        private void cmb_CommonPDA1_SelectedValueChanged(object sender)
        {

        }

        private void txt_Launch_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection sqlConn = new SqlConnection(sConnStr);
            //sqlConn.Open();
            //DataSet ds1 = new DataSet();

            //SqlDataAdapter adapter1 =
            //    new SqlDataAdapter(
            //        "select id, name, isnull(dbo.fn_PrevQualityStage(id), 0) as prevstageid from prod_launchhead where name = '" + frm.FormText + "'", sqlConn);

            //adapter1.Fill(ds1);

            //DataTable dt1 = ds1.Tables[0];

            //if (dt1.Rows.Count > 0)
            //{
            //    foreach (DataRow dr1 in dt1.Rows)
            //    {
            //        LaunchId = Convert.ToInt32(dr1["id"].ToString());
            //        Launch = dr1["name"].ToString();
            //        PrevStageId = Convert.ToInt32(dr1["prevstageid"].ToString());
            //    }
            //    FillList(WorkerId, LaunchId);
            //    FillMaterialsByLaunch(LaunchId);
            //    CheckViza(LaunchId);
            //    txt_Oper.Focus();

            //}
            //else
            //{
            //    LaunchId = 0;
            //    PrevStageId = 0;
            //    FillList(WorkerId, LaunchId);
            //    FillMaterialsByLaunch(0);
            //    lbl_Viza.Visible = false;
            //}
            //sqlConn.Close();
            //txt_Oper.Text = "";
            
            //txt_OperNO.Text = "";
            ////OperNO = 0;
            //IsLast = 0;
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            var query = "sp_SelectSerialNumbersByWorkerByDateTotal";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@workerid",SqlDbType.Int){Value = WorkerId }
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Totals for worker: " + Worker;
            frm.Query = query;
            frm.SqlParams = sqlparams;
            frm.Show();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int OperNO in ParsedOperations.OrderBy(num => num))
                MessageBox.Show(OperNO.ToString());
        }

        private void gv_List_Click(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Materials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Materials_Click(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Materials_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Materials_SelectionChanged(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void btn_CopyLine_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);  }
            catch { }

            if (WorkerId == 0
                || LaunchId == 0
                || _id == 0)
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Empty fields detected! Please check worker or launch or selected line!";
                DialogResult result1 = frm1.ShowDialog();
                //globClass.ShowMessage("Empty fields detected!", "Please check worker or launch", "Launch or worker are empty!");
                txt_Oper.Focus();
            }
            else           
            {
                frm_cmbTextPDA frm = new frm_cmbTextPDA();
                frm.LabelText = "TARGET serial: ";
                frm.HeaderText = "Scan TARGET serial: ";
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    DCBll.CopyDataCollectionRepair(_id, WorkerId, LaunchId, frm.FormText);
                    FillList(LaunchId);
                }
               
            }
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }
    }
}
