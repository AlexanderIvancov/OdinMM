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
    public partial class frm_MachineDCOper : BaseForm
    {
        public frm_MachineDCOper()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }


        #region Variables
        
        frm_ScreenNumKeyboard16 popup;
        frm_Feeders popupfed;

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
               
        public string Launch
        {
            get { return txt_Launch.Text; }
            set { txt_Launch.Text = value; }
        }

        int _termprofilestate = 0;
        public int TermProfile
        {
            get { return _termprofilestate; }
            set { _termprofilestate = value; }
        }

        int _mounterstate = 0;
        public int Mounter
        {
            get { return _mounterstate; }
            set { _mounterstate = value; }
        }

        public string MounterBy
        {
            get { return lbl_MounterProfile.Values.Text; }
            set { lbl_MounterProfile.Text = value; }
        }

        int _ovencheck = 0;
        public int OvenCheck
        {
            get { return _ovencheck; }
            set { _ovencheck = value; }
        }

        public string OvenCheckBy
        {
            get { return lbl_OvenCheck.Values.Text; }
            set { lbl_OvenCheck.Text = value; }
        }


        public string TermProfileBy
        {
            get { return lbl_OvenProfile.Values.Text; }
            set { lbl_OvenProfile.Text = value; }
        }
       
        int _batchid = 0;

        public int BatchId
        {
            get { return _batchid; }
            set { _batchid = value; }
        }

        int _pastestate = 0;
        public int PasteState
        {
            get { return _pastestate; }
            set { _pastestate = value; }
        }

        public string PasteBy
        {
            get { return lbl_PasteProfile.Values.Text; }
            set { lbl_PasteProfile.Text = value; }
        }


        int _launchid = 0;

        public int LaunchId
        {
            get { return _launchid; }
            set { _launchid = value; }
        }

        int _workid = 0;
               

        public int WorkId
        {
            get { return _workid; }
            set { _workid = value; }
        }
              
              
        public int LineId
        {
            get { return cmb_CommonPDA1.SelectedValue; }
            set { cmb_CommonPDA1.SelectedValue = value; }
        }

        int _headid = 0;
        public int HeadId
        {
            get { return _headid; }
            set { _headid = value; }

        }
        Processing_BLL ProdBll = new Processing_BLL();

        int _TopBot = 2;      


        public int TopBot
        {
            get { return _TopBot; }
            set
            {
                _TopBot = value;
                switch (_TopBot)
                {
                    case 1:
                        chk_TOP.Checked = true;
                        chk_BOT.Checked = false;
                        chk_TOP.BackColor = Color.LightGreen;
                        chk_BOT.BackColor = Color.Gainsboro;
                        break;
                        
                    default:
                        chk_TOP.Checked = false;
                        chk_BOT.Checked = true;
                        chk_TOP.BackColor = Color.Gainsboro;
                        chk_BOT.BackColor = Color.LightGreen;
                        break;
                }
            }
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

        public void SetCellsColorMaterial()
        {
            foreach (DataGridViewRow row in this.gv_Materials.Rows)
            {
                switch (Convert.ToInt32(row.Cells["cn_stencilstate"].Value))
                {
                    case -1: //OK
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.GreenYellow;
                        break;
                    case 0: //NOT OK
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.Tomato;
                        break;
                    default:
                        
                        break;
                }
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

        public void FillList(int _launchid, int _topbot)
        {
            var data = DC_BLL.getSerialNumbersMach(_launchid, _topbot);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });

          
        }

        
        public void FillMaterialsByLaunch(int _launchid)
        {
            var data = DC_BLL.getMaterialsByLaunch(_launchid, TopBot);

            gv_Materials.ThreadSafeCall(delegate
            {
                gv_Materials.AutoGenerateColumns = false;
                bs_Materials.DataSource = data;
                gv_Materials.DataSource = bs_Materials;

                SetCellsColorMaterial();
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
                      

        public void FocusOnGvUpdate(object sender, FormClosingEventArgs e)
        {
            FillList(WorkerId, LaunchId);
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        public void ClearFields()
        {
            LaunchId = 0;
            Launch = "";
            Worker = "";
            WorkerId = 0;
            TopBot = 2;
            Mounter = 0;
            MounterBy = "Mounter profile state";
            TermProfile = 0;
            TermProfileBy = "Oven profile state";
            PasteState = 0;
            PasteBy = "Paste profile state";
        }

        public void AddHeader()
        {

            int _res = LaunchTopBotID(LaunchId, TopBot);
            if (_res == 0)
            {
                HeadId = DCBll.SaveControlCardHeader(0, LineId, LaunchId, BatchId, Worker, TopBot);
            }
            else
                HeadId = _res;
            FillHeader(HeadId);
            FillList(LaunchId, TopBot);
            FillMaterialsByLaunch(LaunchId);
            CheckViza(LaunchId);
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }

        public void FillHeader(int _headid)
        {
            DCBll.MDCHeadid = _headid;
            if (DCBll.MDCTermProfDate.Trim() == "")
            {
                TermProfile = 0;
                TermProfileBy = "NO TERM PROFILE!";
            }
            else
            {
                TermProfile = -1;
                TermProfileBy = "Term profile: " + System.Environment.NewLine  + DCBll.MDCTermProfBy + System.Environment.NewLine + DCBll.MDCTermProfDate;
            }
            if (DCBll.MDCMountDate.Trim() == "")
            {
                Mounter = 0;
                MounterBy = "NO MOUNTER PROFILE!";
            }
            else
            {
                Mounter = -1;
                MounterBy = "Mounter profile: " + System.Environment.NewLine + DCBll.MDCMountBy + System.Environment.NewLine + DCBll.MDCMountDate;
            }
            if (DCBll.MDCPasteDate.Trim() == "")
            {
                PasteState = 0;
                PasteBy = "Paste not checked!";
            }
            else
            {
                PasteState = -1;
                PasteBy = "Paste checked: " + System.Environment.NewLine + DCBll.MDCPasteBy + System.Environment.NewLine + DCBll.MDCPasteDate;
            }
            if (DCBll.MDCOvenCheckDate.Trim() == "")
            {
                OvenCheck = 0;
                OvenCheckBy = "Oven not checked!";
            }
            else
            {
                OvenCheck = -1;
                OvenCheckBy = "Oven checked: " + System.Environment.NewLine + DCBll.MDCOvenCheckBy + System.Environment.NewLine + DCBll.MDCOvenCheckDate;
            }

        }
        #endregion

        #region Controls
        private void frm_MachineDCOper_Activated(object sender, EventArgs e)
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
                            this.TabText = "SMT processing (" + dr1["name"].ToString() + ")";
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

        public int LaunchTopBotID(int LaunchId, int TopBot)
        {
            int _res = Convert.ToInt32(Helper.GetOneRecord("select ch.id from PROD_ControlCardHead ch where ch.launchid = " + LaunchId + " and isnull(ch.topbot, 1) = " + TopBot));
            return _res;
        }


        private void btn_ChangeLaunch_Click(object sender, EventArgs e)
        {
            if (WorkerId == 0)
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Please scan worker first!";
                DialogResult result1 = frm1.ShowDialog();
                LaunchId = 0;
                Launch = "";

                FillList(LaunchId, TopBot);
                FillMaterialsByLaunch(0);
                lbl_Viza.Visible = false;

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }

            else
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
                            "select lh.id, lh.name, bh.id as batchid, bh.batch from prod_launchhead lh " +
                                            "left join PROD_BatchHead bh on bh.id = lh.batchid where lh.name = '" + frm.FormText + "'", sqlConn);

                    adapter1.Fill(ds1);

                    DataTable dt1 = ds1.Tables[0];

                    if (dt1.Rows.Count > 0)
                    {
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            LaunchId = Convert.ToInt32(dr1["id"].ToString());
                            Launch = dr1["name"].ToString();
                            BatchId = Convert.ToInt32(dr1["batchid"].ToString());
                        }

                        int _res = LaunchTopBotID(LaunchId, TopBot);
                        if (_res == 0)
                        {
                            HeadId = DCBll.SaveControlCardHeader(0, LineId, LaunchId, BatchId, Worker, TopBot);
                        }
                        else
                            HeadId = _res;

                        FillHeader(HeadId);
                        FillList(LaunchId, TopBot);
                        FillMaterialsByLaunch(LaunchId);
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

                        HeadId = 0;
                        FillList(LaunchId, TopBot);
                        FillMaterialsByLaunch(0);
                        lbl_Viza.Visible = false;
                    }
                    sqlConn.Close();
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
                    FillMaterialsByLaunch(LaunchId);
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
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                
            }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {
                DCBll.DeleteDataCollectionMachine(_id);
                FillList(WorkerId, LaunchId);
                txt_Oper.Text = "";
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
          
        public void AddSerialAnalogue(string serial, string analogue, int asprimary)
        {
            string _res = ProdBll.AddSerialNumberAnalogue(serial, analogue, asprimary);            
        }

        public void AddSerialAnalog(string Analogue)
        {
            if (Analogue != "")
            {
                AddSerialAnalogue(TmpSerial, Analogue, -1);
                frmSer.Close();
            }
            //else
            //    frmSer.FormClosing += new FormClosingEventHandler();
        }

        public string TmpSerial
        { get; set; }
      

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (WorkerId == 0
                    || LaunchId == 0
                    || HeadId == 0
                    
                    //|| txt_OperNO.Text.Trim() == ""
                    )
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Empty fields detected! Please check worker or launch or operation!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Empty fields detected!", "Please check worker or launch", "Launch or worker are empty!");
                    txt_Oper.Focus();
                }
                else
                {
                    string _serial = txt_Oper.Text.Trim();
                    string _res = "";
                   
                        _res = DCBll.AddDataCollectionMachMaterial(WorkerId, _serial, LaunchId, TopBot);
                        //MessageBox.Show(DCBll.SuccessId.ToString());
                        if (DCBll.SuccessId == 1)
                            FillMaterialsByLaunch(LaunchId);
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Something wrong! " + _res;
                            DialogResult result = frm1.ShowDialog();
                        }
                   
                    txt_Oper.Text = "";
                    txt_Oper.Focus();
                }
            }
        }

        

        #endregion
               
        //public void AddManualSerial(string _Serial)
        //{
        //    string _serial = _Serial;
        //    string _res = "";
            
        //       // _res = DCBll.AddDataCollectionSerialOper(WorkerId, _serial, LaunchId, PrevStageId, OperNO, OperNO == 0 ? -1 : IsLast(OperNO), cmb_CommonPDA1.SelectedValue);
        //        if (DCBll.SuccessId == -1)
        //            FillList(WorkerId, LaunchId);
        //        else if (DCBll.SuccessId == 1)
        //            FillMaterialsByLaunch(LaunchId);
        //        else
        //        {
        //            System.Media.SystemSounds.Exclamation.Play();
        //            frm_Error frm1 = new frm_Error();
        //            frm1.HeaderText = "Something wrong! " + _res;
        //            DialogResult result = frm1.ShowDialog();
        //        }
            
        //}

       

        public void FillLine()
        {
            int _id = 0;
            try
            {
               _id = Convert.ToInt32(Helper.GetOneRecord("select lineid from SYS_PCPlaces where pcname = '" + System.Environment.MachineName + "'"));
            }
            catch { }
            cmb_CommonPDA1.SelectedValue = _id;
        }

        private void btn_SetPlace_Click(object sender, EventArgs e)
        {
            DAL.MakeDefaultLine(cmb_CommonPDA1.SelectedValue);
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
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            /*var query = "sp_SelectSerialNumbersByWorkerByDateTotal";

            var sqlparams = new List<SqlParameter>
            {
                 new SqlParameter("@workerid",SqlDbType.Int){Value = WorkerId }
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Totals for worker: " + Worker;
            frm.Query = query;
            frm.SqlParams = sqlparams;
            frm.Show();*/
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            ClearFields();
        }        
              
        
        private void btn_EditCardDet_Click(object sender, EventArgs e)
        {
            frm_AddMachDCDet frm = new frm_AddMachDCDet();
            frm.LineId = LineId;
            frm.Launch = Launch;
            frm.HeadId = HeadId;

            if (LineId != 0)
            {
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    DCBll.SaveControlCardDet(0, HeadId, frm.Feeder, frm.OldLabel, frm.Label, frm.Serial, WorkerId );
                    FillList(LaunchId, TopBot);
                }

            }

            else
                globClass.ShowMessage("Error!", "Please start shift or choose line!", "Empty field detected!");

            txt_Oper.Text = "";
            txt_Oper.Focus();

        }

        private void chk_TOP_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TOP.CheckState == CheckState.Checked)
            {
                TopBot = 1;
                AddHeader();
                FillHeader(HeadId);
                FillList(LaunchId, TopBot);
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void chk_BOT_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_BOT.CheckState == CheckState.Checked)
            {
                TopBot = 2;
                AddHeader();
                FillHeader(HeadId);
                FillList(LaunchId, TopBot);
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void btn_ClearOven_Click(object sender, EventArgs e)
        {
            if (globClass.ConfirmMessage("Are you sure you want to clear oven profile?", "Press OK to clear", "Oven profile deleting") == true)
            {
                DCBll.SetControlCardHeaderTerm(HeadId, Worker, 0);
                FillHeader(HeadId);

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void btn_ClearProg_Click(object sender, EventArgs e)
        {
            if (globClass.ConfirmMessage("Are you sure you want to clear mounter profile?", "Press OK to clear", "Mounter profile deleting") == true)
            {
                DCBll.SetControlCardHeaderMount(HeadId, Worker, 0);
                FillHeader(HeadId);

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void btn_MounterProgram_Click(object sender, EventArgs e)
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
                            string _Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            DCBll.SetControlCardHeaderMount(HeadId, _Worker, -1);
                            FillHeader(HeadId);

                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong worker scanning! Your state is inactive! Please contact your master!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");
                            
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
                  
                }
                sqlConn.Close();

                //FillMaterials(WorkerId);
                txt_Oper.Text = "";
                txt_Oper.Focus();

            }
        }

        private void btn_OvenProfile_Click(object sender, EventArgs e)
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
                            string _Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            DCBll.SetControlCardHeaderTerm(HeadId, _Worker, -1);
                            FillHeader(HeadId);

                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong worker scanning! Your state is inactive! Please contact your master!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");
                           
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
                 
                }
                sqlConn.Close();

                //FillMaterials(WorkerId);
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void gv_Materials_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColorMaterial();
            txt_Oper.Focus();
        }

        private void btn_PasteProfile_Click(object sender, EventArgs e)
        {
            string _userlogin = "";
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
                            string _Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            _userlogin = dr1["userlogin"].ToString();

                            if (DAL.IsUserInGroup(_userlogin, "RQuality") == true)
                            {
                                DCBll.SetControlCardHeaderPaste(HeadId, _Worker, -1);
                                FillHeader(HeadId);
                            }
                            else
                            {
                                System.Media.SystemSounds.Exclamation.Play();
                                frm_Error frm1 = new frm_Error();
                                frm1.HeaderText = "Wrong worker scanning! You are not in quality group!";
                                DialogResult result1 = frm1.ShowDialog();
                            }
                            
                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong worker scanning! Your state is inactive! Please contact your supervisor!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");

                        }
                    }
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong worker scanning! Your rfid is not correct!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your rfid is not correct!");

                }
                sqlConn.Close();

                //FillMaterials(WorkerId);
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }

           
        }

        private void btn_ClearPaste_Click(object sender, EventArgs e)
        {
            if (DAL.IsUserInGroup(System.Environment.UserName, "RQuality") == true
                &&
                globClass.ConfirmMessage("Are you sure you want to clear paste check?", "Press OK to clear", "Paste check deleting") == true)
            {
                DCBll.SetControlCardHeaderPaste(HeadId, Worker, 0);
                FillHeader(HeadId);

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_Click(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Materials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Materials_Click(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void gv_Materials_SelectionChanged(object sender, EventArgs e)
        {
            txt_Oper.Focus();
        }

        private void btn_OvenCheck_Click(object sender, EventArgs e)
        {
            string _userlogin = "";
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
                            string _Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            _userlogin = dr1["userlogin"].ToString();

                            if (DAL.IsUserInGroup(_userlogin, "RQuality") == true)
                            {
                                DCBll.SetControlCardHeaderOvenCheck(HeadId, _Worker, -1);
                                FillHeader(HeadId);
                            }
                            else
                            {
                                System.Media.SystemSounds.Exclamation.Play();
                                frm_Error frm1 = new frm_Error();
                                frm1.HeaderText = "Wrong worker scanning! You are not in quality group!";
                                DialogResult result1 = frm1.ShowDialog();
                            }

                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Wrong worker scanning! Your state is inactive! Please contact your supervisor!";
                            DialogResult result1 = frm1.ShowDialog();
                            //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your state is inactive!");

                        }
                    }
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Wrong worker scanning! Your rfid is not correct!";
                    DialogResult result1 = frm1.ShowDialog();
                    //globClass.ShowMessage("Wrong worker scanning", "Please contact your master", "Your rfid is not correct!");

                }
                sqlConn.Close();

                //FillMaterials(WorkerId);
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        private void btn_ClearOvenCheck_Click(object sender, EventArgs e)
        {
            if (DAL.IsUserInGroup(System.Environment.UserName, "RQuality") == true
               &&
               globClass.ConfirmMessage("Are you sure you want to clear oven check?", "Press OK to clear", "Oven check deleting") == true)
            {
                DCBll.SetControlCardHeaderOvenCheck(HeadId, Worker, 0);
                FillHeader(HeadId);

                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }
    }
}
