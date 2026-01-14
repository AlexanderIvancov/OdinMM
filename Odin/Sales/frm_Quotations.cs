using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Sales
{
    public partial class frm_Quotations : BaseForm
    {
        public frm_Quotations()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "Quotations.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CO_BLL COBll = new CO_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
              

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        frm_AddQuotation frm = null;

        public int QuotId
        {
            get;
            set;
        }

        public int _PrevId = 0;

        public bool _iscopy = false;

        public int ControlWidth = 250;


        public DateTime DateFromD
        {
            get { return Convert.ToDateTime(txt_ReqDateFrom.Value); }
            set { txt_ReqDateFrom.Value = value; }
        }

        public DateTime DateTillD
        {
            get { return Convert.ToDateTime(txt_ReqDateTill.Value); }
            set { txt_ReqDateTill.Value = value; }
        }

        public int PCB
        {
            get
            {
                return chk_PCB.CheckState == CheckState.Checked ? -1 : chk_PCB.CheckState == CheckState.Unchecked ? 0 : 1;
            }
            set
            {
                chk_PCB.CheckState = value == -1 ? CheckState.Checked : value == 0 ? CheckState.Unchecked : CheckState.Indeterminate;
            }
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
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                    }

                }
                reader.Close();
            }

            sqlConn.Close();

        }

        public void ClearFilter()
        {
            cmb_Quotations1.QuotationId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Department1.DeptId = 0;
            cmb_Common1.SelectedValue = 0;
            cmb_Articles1.ArticleId = 0;
            txt_CustArticle.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_CreatDateFrom.Value = null;
            txt_CreatDateTill.Value = null;
            txt_ReqDateFrom.Value = null;
            txt_ReqDateTill.Value = null;
            cmb_Week1.Week = "";
            PCB = 1;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            var data = CO_BLL.getQuotations(cmb_Quotations1.QuotationId, cmb_Types1.TypeId, cmb_Department1.DeptId, cmb_Firms1.FirmId, cmb_Common1.SelectedValue,
                                            cmb_Articles1.ArticleId,
                                            txt_CustArticle.Text, 
                                            txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(), 
                                            txt_Comments.Text,
                                            txt_ReqDateFrom.Value == null ? "" : txt_ReqDateFrom.Value.ToString().Trim(), 
                                            txt_ReqDateTill.Value == null ? "" : txt_ReqDateTill.Value.ToString().Trim(),
                                            PCB);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                //Yellow - in Progress
                if (Convert.ToInt32(row.Cells["cn_stateid"].Value) == 1)
                {
                    if (Convert.ToInt32(row.Cells["chk_issent"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.FromArgb(255, 255, 192);
                    }
                    else
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Yellow;
                    }
                }
                //Green - Accepted
                if (Convert.ToInt32(row.Cells["cn_stateid"].Value) == 3)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                    }
                }
                //Declined - GREY
                if (Convert.ToInt32(row.Cells["cn_stateid"].Value) == 5)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.FromArgb(224, 224, 224);
                    }
                }
                //Red - no PCB
                if (row.Cells["cn_pcbtext"].Value.ToString() == "No"
                    && Convert.ToInt32(row.Cells["cn_stateid"].Value) == 3)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightCoral;
                    }
                }
            }

        }

        public void AddQuotation(object sender)
        {
            if (frm.ctl_QuotDets1.QuotId != 0
                || frm.ctl_QuotDets1.IsCopy == -1)
                frm.Close();
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
            SetCellsColor();
        }

        #endregion

        #region Controls

        #region Context menu


        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_List.ClearSelection();
                gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColor();

        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_List;
            frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? String.IsNullOrEmpty(CellValue) == true
                        ? "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'"
                    : String.IsNullOrEmpty(CellValue) == true
                        ? bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'"
                    : bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            SetCellsColor();

        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for confirmation orders list";
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

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        #endregion

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void frm_Quotations_Resize(object sender, EventArgs e)
        {
            if (_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });

                }
            }
        }

        private void frm_Quotations_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            txt_CreatDateFrom.Value = null;
            txt_CreatDateTill.Value = null;
            txt_ReqDateFrom.Value = null;
            txt_ReqDateTill.Value = null;
                   

            cmb_Common1.SelectedValue = 0;
            //ctl_btnNum1.GetCountQuery = "exec sp_SelectInvalideBOMsCount";
        }

        public void ClearDates()
        {
            txt_CreatDateFrom.Value = null;
            txt_CreatDateTill.Value = null;
            txt_ReqDateFrom.Value = null;
            txt_ReqDateTill.Value = null;

        }
        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            txt_CustArticle.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CreatDateTill.Value = System.DateTime.Now;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_ReqDateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_ReqDateTill.Value = System.DateTime.Now;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void cmb_Week1_SelectedValueChanged(object sender)
        {
            DateFromD = cmb_Week1.FirstDateOfWeek;
            DateTillD = cmb_Week1.LastDateOfWeek;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        private void chk_PCB_CheckStateChanged(object sender, EventArgs e)
        {
            chk_PCB.Text = chk_PCB.CheckState == CheckState.Checked
                ? "PCB: Yes"
                : chk_PCB.CheckState == CheckState.Unchecked ? "PCB: No" : "PCB: Undefined";
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (globClass.IsFormAlreadyOpen("frm_AddQuotation")) return;

            frm = new frm_AddQuotation();
            frm.ctl_QuotDets1.QuotId = 0;
            frm.ctl_QuotDets1.FillAutoDoc(10);
            frm.ctl_QuotDets1.StateId = 1;
            //frm.ctl_QuotDets1.Week = "W" + frm.ctl_QuotDets1.cmb_Week1.WeekNumber(System.DateTime.Now).ToString() + "/" + System.DateTime.Now.Year.ToString(); 
            frm.ctl_QuotDets1.ReqDateD = System.DateTime.Now;
            frm.ctl_QuotDets1.ExpDateD = System.DateTime.Now.AddMonths(2);
            //frm.ctl_QuotDets1.SentDate = " ";
            frm.ctl_QuotDets1.FillDates();

            frm.QuotationSaved += new QuotationSavedEventHandler(AddQuotation);

            frm.Show(); frm.GetKryptonFormFields();

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }
        public void ShowEdit()
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                //if (globClass.IsFormAlreadyOpen("frm_AddQuotation")) return;

                COBll.QuotId = _id;
                frm = new frm_AddQuotation();
                frm.ctl_QuotDets1.QuotId = _id;

                frm.QuotationSaved += new QuotationSavedEventHandler(AddQuotation);

                frm.Show(); frm.GetKryptonFormFields();

            }
        }
        private void btn_Copy_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                //if (globClass.IsFormAlreadyOpen("frm_AddQuotation")) return;

                COBll.QuotId = _id;
                frm = new frm_AddQuotation();
                frm.ctl_QuotDets1.IsCopy = -1;
                frm.ctl_QuotDets1.QuotId = _id;
                


                frm.QuotationSaved += new QuotationSavedEventHandler(AddQuotation);

                frm.Show(); frm.GetKryptonFormFields();

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && globClass.DeleteConfirm() == true)
            {
                if (COBll.DeleteQuotation(_id) == -1)
                {
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);
                    SetCellsColor();
                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                }
                else
                    MessageBox.Show("Selected qoutation can not be deleted!");
            }

        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }




        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {          

            string emailaddresses = "";
            
            string strMessage = "New CO number: " + COBll.COHeader;
            strMessage = strMessage + System.Environment.NewLine + "Customer: " + COBll.COCustomer;
            strMessage = strMessage + System.Environment.NewLine + "Qty: " + COBll.COQty;
            strMessage = strMessage + System.Environment.NewLine + "PCB: " + COBll.QPCBText;
            strMessage = strMessage + System.Environment.NewLine + "Stages: " + COBll.COStages;
            strMessage = strMessage + System.Environment.NewLine + "Lead week: " + COBll.QWeek;

            MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "New CO: " + COBll.COHeader + " creation", strMessage);

        }

        private void btn_General_Click(object sender, EventArgs e)
        {

        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void txt_CreatDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateFrom.Value = txt_CreatDateFrom.Value == null ? System.DateTime.Now : txt_CreatDateFrom.Value;
        }

        private void txt_CreatDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateTill.Value = txt_CreatDateTill.Value == null ? System.DateTime.Now : txt_CreatDateTill.Value;
        }

        private void txt_ReqDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ReqDateFrom.Value = txt_ReqDateFrom.Value == null ? System.DateTime.Now : txt_ReqDateFrom.Value;
        }

        private void txt_ReqDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ReqDateTill.Value = txt_ReqDateTill.Value == null ? System.DateTime.Now : txt_ReqDateTill.Value;
        }

        private void btn_History_Click(object sender, EventArgs e)
        {

        }

        private void btn_PCBNeeds_Click(object sender, EventArgs e)
        {
            var _query = "sp_SelectArtTotalsListPCB";

            var sqlparams = new List<SqlParameter>()
                {
                   
                };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "PCB needs list ";
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();

        }

        private void btn_InvalideBOMs_Click(object sender, EventArgs e)
        {
            var _query = "sp_SelectInvalideBOMs";

            var sqlparams = new List<SqlParameter>()
            {

            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Invalide BOM's list ";
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_RMConsulting_Click(object sender, EventArgs e)
        {
            if (cmb_Articles1.ArticleId != 0)
            {
                frm_cmbNumber frm = new frm_cmbNumber();
                frm.LabelText = "Qty of final product";
                frm.HeaderText = "Enter qty of final product";

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && Convert.ToInt32(frm.FormNumber) != 0)
                {

                    var _query = "sp_BOMDetailsForecast";
                    var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@id",SqlDbType.Int) {Value = cmb_Articles1.ArticleId},
                    new SqlParameter("@qtycse",SqlDbType.Int) {Value = Convert.ToInt32(frm.FormNumber)}
                };

                    Template_DataGridView frm1 = new Template_DataGridView();

                    frm1.Text = "Stock forecast for: " + cmb_Articles1.Article + ", Qty: " + frm.FormNumber.ToString();
                    frm1.Query = _query;
                    frm1.SqlParams = sqlparams;
                    frm1.Show();
                }
            }
            else
                globClass.ShowMessage("Choose article in filter for analyze!", "Choose article in filter for analyze!", "Article is not selected!");
        }
    }
}
