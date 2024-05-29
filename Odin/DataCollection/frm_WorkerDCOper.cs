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
    public partial class frm_WorkerDCOper : BaseForm
    {
        public frm_WorkerDCOper()
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

        public int OperNO
        {
            get
            {
                try { return Convert.ToInt32(txt_OperNO.Text); }
                catch { return 0; }
            }
            set { txt_OperNO.Text = value.ToString(); }
        }

        public int IsFreezed
        {
            get
            {
                return chk_IsFreezed.Checked == true ? -1 : 0;
            }
            set
            {
                chk_IsFreezed.Checked = value == -1;
            }
        }

        public int IsLast
        {
            get
            {
                return chk_IsLast.Checked == true ? -1 : 0;
            }
            set
            {
                chk_IsLast.Checked = value == -1;
            }
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_islast"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.Gold;

                if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
        public void FillList(int _workerid, int _launchid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectSerialNumbersByWorkerByDate", _workerid, _launchid);


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

        public void FillMaterials(int _workerid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectMaterialsByWorkerByDate", _workerid);

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
            var data = (DataTable)Helper.getSP("sp_SelectMaterialsByLaunch", _launchid);

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

        private void insertKeyboardSymbol(string symbol, bool symremove)
        {
            if (symremove)
                //dataGridView1.CurrentRow.Cells["cn_value"].Value = symbol;
                focusedtextbox.Text = symbol;
            else
                //dataGridView1.CurrentRow.Cells["cn_value"].Value += symbol;
                focusedtextbox.Text += symbol;
        }

        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            TextBox s = sender as TextBox;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
                e.Handled = e.KeyChar == '-' ? s.Text.Contains(e.KeyChar) : !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void ShowScreenNumKeyboard(KryptonTextBox _focusedtextbox)
        {
            //MessageBox.Show(focusedtextbox.Name);
            //focusedtextbox.Focus();
            popup = new frm_ScreenNumKeyboard();
            popup.DisplayKeyboardSymbol += new CustomControls.DisplayKeyboardSymbolEventHandler(insertKeyboardSymbol);
            popup.FormClosing += new FormClosingEventHandler(FocusOn);
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

        public void FocusOn(object sender, FormClosingEventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        public void FocusOnGvUpdate(object sender, FormClosingEventArgs e)
        {
            FillList(WorkerId, LaunchId);
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
            Helper.LoadColumns(gv_List, this.Name);
            Helper.LoadColumns(gv_Materials, this.Name);
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
                    foreach (DataRow dr1 in dt1.Rows)
                        if (Convert.ToInt32(dr1["isactive"]) == -1)
                        {
                            Worker = dr1["name"].ToString() + " " + dr1["surname"].ToString();
                            WorkerId = Convert.ToInt32(dr1["id"].ToString());
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
                txt_OperNO.Text = "";
                IsLast = 0;
                LaunchId = 0;
                Launch = "";

                FillList(WorkerId, LaunchId);
                txt_OperNO.Text = "";
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
            lbl_Viza.Visible = _res == 0
                && _res1 == 0;
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
                    FillList(WorkerId, LaunchId);
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
                    PrevStageId = 0;
                    FillList(WorkerId, LaunchId);
                    FillMaterialsByLaunch(0);
                    lbl_Viza.Visible = false;
                }
                sqlConn.Close();
                txt_Oper.Text = "";
                txt_Oper.Focus();
                txt_OperNO.Text = "";
                //OperNO = 0;
                IsLast = 0;
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
                    DCBll.DeleteDataCollectionSerial(_id, _serial);
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
                Helper.LoadColumns(gv_List, this.Name);
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
                Helper.LoadColumns(gv_Materials, this.Name);
            }

        }


        private void txt_OperNO_Enter(object sender, EventArgs e)
        {
            //focusedtextbox = txt_OperNO;
            //txt_OperNO.ThreadSafeCall(delegate { ShowScreenNumKeyboard(txt_OperNO); });
            //popup.CellText = txt_OperNO.Text.ToString();
        }

        private void txt_OperNO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popup.CellText = txt_OperNO.Text.ToString();
                txt_OperNO.SelectionStart = txt_OperNO.Text.Length;
            }
            catch { }
        }
        public void AddSerialAnalogue(string serial, string analogue, int asprimary)
        {
            string _res = Convert.ToString(Helper.getSP("sp_AddSerialAnalogue", serial, analogue, asprimary));            
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

        public void ShowFrmAnalog()
        {
            frmSer = new frm_cmbTextPDA_NC();
            frmSer.HeaderText = "Enter serial for: " + TmpSerial;
            frmSer.LabelText = "Serial: ";
            frmSer.TextEntering += new TextEnteringEventHandler(AddSerialAnalog);
            frmSer.FormClosing += new FormClosingEventHandler(FocusOnGvUpdate);

            frmSer.ShowDialog();
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (WorkerId == 0
                    || LaunchId == 0
                    || OperNO == 0)
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

                    bool check = DCBll.CheckDataCollectionSerialOper(_serial, 4, LaunchId);
                    if (!check)
                    {
                        frm_Confirmation frm2 = new frm_Confirmation();
                        frm2.HeaderText = "New serial number! Make sure the side is correct.";
                        System.Media.SystemSounds.Exclamation.Play();
                        DialogResult result2 = frm2.ShowDialog();
                        check = result2 == DialogResult.OK ? true : false;
                    }

                    if (check)
                    {
                        string _res = DCBll.AddDataCollectionSerialOper(WorkerId, _serial, LaunchId, PrevStageId, OperNO, OperNO == 0 ? -1 : IsLast, cmb_CommonPDA1.SelectedValue);
                        //MessageBox.Show(DCBll.SuccessId.ToString());
                        if (DCBll.SuccessId == -1)
                            FillList(WorkerId, LaunchId);
                        else if (DCBll.SuccessId == 1)
                            FillMaterialsByLaunch(LaunchId);
                        else if (DCBll.SuccessId == -2)
                        {
                            TmpSerial = _serial;
                            ShowFrmAnalog();
                        }
                        else
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            frm_Error frm1 = new frm_Error();
                            frm1.HeaderText = "Something wrong! " + _res;
                            DialogResult result = frm1.ShowDialog();
                        }

                        if (IsFreezed != 0)
                        {
                            CMB_Components.AddSerialFreezed.frm_AddSerialFreezed frm = new CMB_Components.AddSerialFreezed.frm_AddSerialFreezed();
                            frm.Serial = _serial;
                            frm.LaunchId = _launchid;
                            DialogResult result = frm.ShowDialog();

                            if (result == DialogResult.OK)
                                Helper.getSP("sp_AddSerialFreezed", frm.StageId, frm.BatchId, frm.LaunchId, frm.Serial, frm.Position, frm.FreezedReasonId);
                        }
                        txt_Oper.Text = "";
                        txt_Oper.Focus();
                    }
                }
            }
        }

        private void btn_DirectQty_Click(object sender, EventArgs e)
        {
            if (WorkerId == 0
                     || LaunchId == 0
                     || OperNO == 0)
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Empty fields detected! Please check worker or launch or operation!";
                DialogResult result1 = frm1.ShowDialog();
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
            else
            {
                frm_AddNumPDA frm = new frm_AddNumPDA();
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string _res = DCBll.AddDataCollectionQtyOper(WorkerId, LaunchId, frm.Qty, OperNO, OperNO == 0 ? -1 : IsLast, cmb_CommonPDA1.SelectedValue);
                    if (DCBll.SuccessId == -1)
                        FillList(WorkerId, LaunchId);
                    else
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                        frm_Error frm1 = new frm_Error();
                        frm1.HeaderText = "Something wrong! " + _res;
                        DialogResult result1 = frm1.ShowDialog();
                    }
                    //MessageBox.Show(frm.Qty.ToString());
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            focusedtextbox = txt_OperNO;
            txt_OperNO.ThreadSafeCall(delegate { ShowScreenNumKeyboard(txt_OperNO); });
            popup.CellText = txt_OperNO.Text.ToString();
        }

        public void AddManualSerial(string _Serial)
        {
            string _serial = _Serial;
            bool check = DCBll.CheckDataCollectionSerialOper(_serial, 4, LaunchId);
            if (!check)
            {
                frm_Confirmation frm2 = new frm_Confirmation();
                frm2.HeaderText = "New serial number! Make sure the side is correct.";
                System.Media.SystemSounds.Exclamation.Play();
                DialogResult result2 = frm2.ShowDialog();
                check = result2 == DialogResult.OK ? true : false;
            }

            if (check)
            {
                string _res = DCBll.AddDataCollectionSerialOper(WorkerId, _serial, LaunchId, PrevStageId, OperNO, OperNO == 0 ? -1 : IsLast, cmb_CommonPDA1.SelectedValue);
                if (DCBll.SuccessId == -1)
                    FillList(WorkerId, LaunchId);
                else if (DCBll.SuccessId == 1)
                    FillMaterialsByLaunch(LaunchId);
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = "Something wrong! " + _res;
                    DialogResult result = frm1.ShowDialog();
                }

                if (IsFreezed != 0)
                {
                    CMB_Components.AddSerialFreezed.frm_AddSerialFreezed frm = new CMB_Components.AddSerialFreezed.frm_AddSerialFreezed();
                    frm.Serial = _serial;
                    frm.LaunchId = _launchid;

                    DialogResult result = frm.ShowDialog();

                    if (result == DialogResult.OK)
                        Helper.getSP("sp_AddSerialFreezed", frm.StageId, frm.BatchId, frm.LaunchId, frm.Serial, frm.Position, frm.FreezedReasonId);
                }
            }
        }

        private void btn_Assembling_Click(object sender, EventArgs e)
        {
            if (WorkerId == 0
                || LaunchId == 0)
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
                frm_cmbTextPDA_NC frm = new frm_cmbTextPDA_NC();
                frm.LabelText = "Serial: ";
                frm.TextEntering += new TextEnteringEventHandler(AddManualSerial);
                frm.FormClosing += new FormClosingEventHandler(FocusOn);

                frm.Show(); frm.GetKryptonFormFields();
            }
            //txt_Oper.Text = "";
            //txt_Oper.Focus();
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
    }
}