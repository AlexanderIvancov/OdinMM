using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Odin.Global_Classes;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using Odin.Planning.Controls;
using System.Data.SqlClient;
using Odin.Tools;
using Odin.Planning;

namespace Odin.Planning.Passport
{
    public delegate void LaunchSavingPasEventHandler(object sender);

    public partial class frm_LaunchPassport : BaseForm
    {
        public frm_LaunchPassport()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "LaunchesPassportList.xls", this.Name);
            ED1 = new ExportData(this.gv_Comments, "LaunchesPassportComments.xls", this.Name);
            ED2 = new ExportData(this.gv_Visas, "LaunchesPassportVisas.xls", this.Name);
        }

        #region Variables
        public event LaunchSavingPasEventHandler LaunchSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        ExportData ED1;
        ExportData ED2;
        Helper MyHelper = new Helper();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int RowIndexC = 0;
        public int ColumnIndexC = 0;
        public string ColumnNameC = "";
        public string CellValueC = "";

        public int RowIndexV = 0;
        public int ColumnIndexV = 0;
        public string ColumnNameV = "";
        public string CellValueV = "";

        public int ControlWidth = 250;

        public int LaunchId
        { get; set; }

        int _PrevId = 0;

        public int IsActive
        {
            get
            {
                if (chk_Active.CheckState == CheckState.Checked)
                    return -1;
                else if (chk_Active.CheckState == CheckState.Unchecked)
                    return 0;
                else
                    return 1;
            }
            set
            {
                if (value == -1)
                    chk_Active.CheckState = CheckState.Checked;
                else if (value == 0)
                    chk_Active.CheckState = CheckState.Unchecked;
                else
                    chk_Active.CheckState = CheckState.Indeterminate;
            }
        }

        #endregion  

        #region Methods

        public void ClearFilter()
        {
            cmb_Batches1.BatchId = 0;
            cmb_Launches1.LaunchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;

            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;

            txt_StartFrom.Value = null;
            txt_StartTill.Value = null;
            cmb_Common1.SelectedValue = 0;
            cmb_Firms1.FirmId = 0;

        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_Comments.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_cstateid"].Value) == -1) //New
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Yellow;
                if (Convert.ToInt32(row.Cells["cn_cstateid"].Value) == 1) // Cancelled
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.LightCoral;
                if (Convert.ToInt32(row.Cells["cn_cstateid"].Value) == 0) //Closed
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
            }
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_ordertypeid"].Value) == 2) //New
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Orange;
                if (Convert.ToInt32(row.Cells["cn_ordertypeid"].Value) == 1) // Serviss
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.LightCoral;
                if (Convert.ToInt32(row.Cells["cn_ordertypeid"].Value) == 3) //Repeat
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
            }
        }

        public void SetCellsColorVisas()
        {
            foreach (DataGridViewRow row in this.gv_Visas.Rows)
            {
                //if (Convert.ToInt32(row.Cells["cn_cstateid"].Value) == -1) //New
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.Yellow;
                //if (Convert.ToInt32(row.Cells["cn_cstateid"].Value) == 1) // Cancelled
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.LightCoral;
                //if (Convert.ToInt32(row.Cells["cn_cstateid"].Value) == 0) //Closed
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
            }
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
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                    }

                }
                reader.Close();
            }

            sqlConn.Close();

        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            //MessageBox.Show(cmb_SalesOrdersWithLines1.SalesOrderLineId.ToString());
            var data = Plan_BLL.getLaunchesPassport(cmb_Batches1.BatchId, cmb_Launches1.LaunchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, IsActive,
                                            cmb_Types1.TypeId, txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                            txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim(), cmb_Firms1.FirmId, cmb_Common1.SelectedValue);


            gv_List.ThreadSafeCall(delegate
            {
                //bs_List.RemoveFilter();
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

        public void ShowComments(int id)
        {
            var data = Plan_BLL.getLaunchesPassportComments(id);


            gv_Comments.ThreadSafeCall(delegate
            {
                //bs_List.RemoveFilter();
                gv_Comments.AutoGenerateColumns = false;
                bs_Comments.DataSource = data;
                gv_Comments.DataSource = bs_Comments;

                SetCellsColor();
            });


            bn_Comments.ThreadSafeCall(delegate
            {
                bn_Comments.BindingSource = bs_Comments;
            });
        }

        public void ShowAddiVisas(int id)
        {
            var data = Plan_BLL.getLaunchesPassportAddVisas(id);


            gv_Visas.ThreadSafeCall(delegate
            {
                //bs_List.RemoveFilter();
                gv_Visas.AutoGenerateColumns = false;
                bs_Visas.DataSource = data;
                gv_Visas.DataSource = bs_Visas;

                SetCellsColorVisas();
            });


            gv_Visas.ThreadSafeCall(delegate
            {
                bn_Visas.BindingSource = bs_Visas;
            });
        }

        public void SetButtonsPermissions()
        {
            if (DAL.IsUserInGroup(System.Environment.UserName, "RQuality") == true)
            {
                btn_Quality.Enabled = true;
                btn_QualityAdd.Enabled = true;
            }
            else
            {
                btn_Quality.Enabled = false;
                btn_QualityAdd.Enabled = false;
            }

            if (DAL.IsUserInGroup(System.Environment.UserName, "RIngen") == true)
            {
                btn_Ingeneering.Enabled = true;
                btn_IngeneeringAdd.Enabled = true;
            }
            else
            {
                btn_Ingeneering.Enabled = false;
                btn_IngeneeringAdd.Enabled = false;
            }
            if (DAL.IsUserInGroup(System.Environment.UserName, "RQuality") == true
                || DAL.IsUserInGroup(System.Environment.UserName, "RIngen") == true)
            {
                btn_addavisa.Enabled = true;
                btn_editvisa.Enabled = true;
                btn_Edit.Enabled = true;
            }
            else
            {
                btn_addavisa.Enabled = false;
                btn_editvisa.Enabled = false;
                btn_Edit.Enabled = false;
            }
        }

        public void SetPanelColors(string _qualityby, string _techby, int _reset)
        {
            if (_reset == 0)
            {
                pn_Quality.BackColor = Color.White;
                pn_Ingeneering.BackColor = Color.White;
            }
            else
            {
                if (_qualityby == "")
                    pn_Quality.BackColor = Color.LightYellow;
                else
                    pn_Quality.BackColor = Color.FromArgb(192, 255, 192);

                if (_techby == "")
                    pn_Ingeneering.BackColor = Color.LightYellow;
                else
                    pn_Ingeneering.BackColor = Color.FromArgb(192, 255, 192);
            }
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
                //if (String.IsNullOrEmpty(bs_List.Filter) == true)
                bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //else
                //    bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
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
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
                else
                    bs_List.Filter = bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
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

            frm.HeaderText = "Select view for launches list";
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

        #region Context menu comments


        private void mnu_LinesC_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Comments.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Comments.HitTest(mpoint.X, mpoint.Y);

                RowIndexC = info.RowIndex;
                ColumnIndexC = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Comments.ClearSelection();
                gv_Comments.Rows[RowIndexC].Cells[ColumnIndexC].Selected = true;
                gv_Comments.CurrentCell = gv_Comments.Rows[RowIndexC].Cells[ColumnIndexC];

                CellValueC = gv_Comments.Rows[RowIndexC].Cells[ColumnIndexC].Value.ToString();
                ColumnNameC = gv_Comments.Columns[ColumnIndexC].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexC = 0;
                ColumnIndexC = 0;
                return;
            }
        }

        private void mni_FilterForC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (String.IsNullOrEmpty(bs_List.Filter) == true)
                bs_Comments.Filter = "Convert(" + ColumnNameC + " , 'System.String') like '%" + mni_FilterForC.Text + "%'";
                //else
                //    bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }

        }

        private void mni_SearchC_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Comments;
            frm.ColumnNumber = gv_Comments.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Comments.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterByC_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Comments.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValueC) == true)
                        bs_Comments.Filter = "(" + ColumnNameC + " is null OR Convert(" + ColumnNameC + ", 'System.String') = '')";
                    else
                        bs_Comments.Filter = "Convert(" + ColumnNameC + " , 'System.String') = '" + glob_Class.NES(CellValueC) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValueC) == true)
                        bs_Comments.Filter = bs_Comments.Filter + "AND (" + ColumnNameC + " is null OR Convert(" + ColumnNameC + ", 'System.String') = '')";
                    else
                        bs_Comments.Filter = bs_Comments.Filter + " AND Convert(" + ColumnNameC + " , 'System.String') = '" + glob_Class.NES(CellValueC) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }


        }

        private void mni_FilterExcludingSelC_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Comments.Filter) == true)
                    bs_Comments.Filter = "Convert(" + ColumnNameC + " , 'System.String') <> '" + CellValueC + "'";
                else
                    bs_Comments.Filter = bs_Comments.Filter + " AND " + ColumnNameC + " <> '" + CellValueC + "'";
            }
            catch { }


        }

        private void mni_RemoveFilterC_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Comments.RemoveFilter();
            }
            catch { }

        }

        private void mni_CopyC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueC.ToString());
        }

        private void mni_AdminC_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for comments list";
            frm.grid = this.gv_Comments;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Comments);
            }
        }

        private void btn_ExcelC_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }

        #endregion

        #region Context menu visas


        private void mnu_LinesV_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Visas.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Visas.HitTest(mpoint.X, mpoint.Y);

                RowIndexV = info.RowIndex;
                ColumnIndexV = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Visas.ClearSelection();
                gv_Visas.Rows[RowIndexV].Cells[ColumnIndexV].Selected = true;
                gv_Visas.CurrentCell = gv_Visas.Rows[RowIndexV].Cells[ColumnIndexV];

                CellValueV = gv_Visas.Rows[RowIndexV].Cells[ColumnIndexV].Value.ToString();
                ColumnNameV = gv_Visas.Columns[ColumnIndexV].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexV = 0;
                ColumnIndexV = 0;
                return;
            }
        }

        private void mni_FilterForV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (String.IsNullOrEmpty(bs_List.Filter) == true)
                bs_Visas.Filter = "Convert(" + ColumnNameV + " , 'System.String') like '%" + mni_FilterForV.Text + "%'";
                //else
                //    bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }

        }

        private void mni_SearchV_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Visas;
            frm.ColumnNumber = gv_Visas.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Visas.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterByV_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Visas.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValueV) == true)
                        bs_Visas.Filter = "(" + ColumnNameV + " is null OR Convert(" + ColumnNameV + ", 'System.String') = '')";
                    else
                        bs_Visas.Filter = "Convert(" + ColumnNameV + " , 'System.String') = '" + glob_Class.NES(CellValueV) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValueV) == true)
                        bs_Visas.Filter = bs_Visas.Filter + "AND (" + ColumnNameV + " is null OR Convert(" + ColumnNameV + ", 'System.String') = '')";
                    else
                        bs_Visas.Filter = bs_Visas.Filter + " AND Convert(" + ColumnNameV + " , 'System.String') = '" + glob_Class.NES(CellValueV) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }


        }

        private void mni_FilterExcludingSelV_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Visas.Filter) == true)
                    bs_Visas.Filter = "Convert(" + ColumnNameV + " , 'System.String') <> '" + CellValueV + "'";
                else
                    bs_Visas.Filter = bs_Visas.Filter + " AND " + ColumnNameV + " <> '" + CellValueV + "'";
            }
            catch { }


        }

        private void mni_RemoveFilterV_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Visas.RemoveFilter();
            }
            catch { }

        }

        private void mni_CopyV_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueV.ToString());
        }

        private void mni_AdminV_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for visas list";
            frm.grid = this.gv_Visas;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Visas);
            }
        }

        private void btn_ExcelV_Click(object sender, EventArgs e)
        {
            ED2.DgvIntoExcel();
        }

        #endregion


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void frm_LaunchPassport_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            LoadColumns(gv_Comments);
            LoadColumns(gv_Visas);


            SetButtonsPermissions();
            ClearFilter();
        }


        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        private void btn_Quality_Click(object sender, EventArgs e)
        {
            DialogResult result1 = KryptonTaskDialog.Show("Quality visa warning!",
                                                               "Are you want to save changes?",
                                                               "You could not delete visa after!",
                                                               MessageBoxIcon.Warning,
                                                               TaskDialogButtons.Yes |
                                                               TaskDialogButtons.No |
                                                               TaskDialogButtons.Cancel);
            if (result1 == DialogResult.Yes)
            {
                int _id = 0;
                try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
                catch { }

                if (_id != 0)
                {
                    string _res = PlanBll.AddLaunchQualityViza(_id);
                    glob_Class.ShowMessage("Quality visa result", "", _res);
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;

                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                    SetCellsColor();

                }
            }
        }

        private void btn_Ingeneering_Click(object sender, EventArgs e)
        {
            DialogResult result1 = KryptonTaskDialog.Show("TechDep visa warning!",
                                                              "Are you want to save changes?",
                                                              "You could not delete visa after!",
                                                              MessageBoxIcon.Warning,
                                                              TaskDialogButtons.Yes |
                                                              TaskDialogButtons.No |
                                                              TaskDialogButtons.Cancel);
            if (result1 == DialogResult.Yes)
            {
                int _id = 0;
                try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
                catch { }

                if (_id != 0)
                {
                    string _res = PlanBll.AddLaunchIngenViza(_id);
                    glob_Class.ShowMessage("Ingeneering visa result", "", _res);

                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                    SetCellsColor();

                }
            }
        }


        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            string _qualby = "";
            string _techby = "";

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _qualby = gv_List.CurrentRow.Cells["cn_qualvisaby"].Value.ToString();
                _techby = gv_List.CurrentRow.Cells["cn_ingenvisaby"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                ShowComments(_id);
                ShowAddiVisas(_id);
                SetPanelColors(_qualby, _techby, -1);
            }
            else
            {
                SetPanelColors("", "", 0);
            }
        }

        private void btn_AddCom_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _launch = "";

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _launch = gv_List.CurrentRow.Cells["cn_launch"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_AddLaunchPassportComment frm = new frm_AddLaunchPassportComment();
                frm.HeaderText = "Add comments for launch: " + _launch;
                frm.FillRBs(-1);
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PlanBll.SavedLaunchPassportComments(0, _id, frm.Comments, "", frm.StateId);
                    ShowComments(_id);

                    if (frm.SendEmail == -1)
                    {
                        string emailaddresses = DAL.EmailAddressesByType(14);
                       
                        
                        string strMessage = "Launch: " + _launch;
                        strMessage = strMessage + "\r\nComments: " + frm.Comments;
                        strMessage = strMessage + "\r\nState: " + (frm.StateId == -1 ? "New" : (frm.StateId == 0 ? "Closed" : "Cancelled"));
                        strMessage = strMessage + "\r\nUser: " + System.Environment.UserName;
                        
                        //strMessage = strMessage + "\r\nArticle: " + dr["custarticle"].ToString();
                        MyHelper.SendDirectEMail(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Additional info for " + _launch + " is added!", strMessage);

                    }

                }
            }

        }

        private void btn_EditCom_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _comments = "";
            string _techcomments = "";
            int _stateid = 0;
            int _launchid = 0;

            try
            {
                _id = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_cid"].Value);
                _stateid = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_cstateid"].Value);
                _comments = gv_Comments.CurrentRow.Cells["cn_ccomments"].Value.ToString();
                _techcomments = gv_Comments.CurrentRow.Cells["cn_techcomments"].Value.ToString();
                _launchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddLaunchPassportComment frm = new frm_AddLaunchPassportComment();
                frm.HeaderText = "Edit launch comments";
                frm.Comments = _comments;
                frm.TechComments = _techcomments;
                frm.StateId = _stateid;
                frm.FillRBs(0);
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PlanBll.SavedLaunchPassportComments(_id, 0, frm.Comments, frm.TechComments, frm.StateId);
                    ShowComments(_launchid);
                }
            }
        }

        private void btn_DeleteCom_Click(object sender, EventArgs e)
        {

        }

        private void gv_Comments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _id = 0;
            string _comments = "";
            string _techcomments = "";
            int _stateid = 0;
            int _launchid = 0;

            try
            {
                _id = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_cid"].Value);
                _stateid = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_cstateid"].Value);
                _comments = gv_Comments.CurrentRow.Cells["cn_ccomments"].Value.ToString();
                _techcomments = gv_Comments.CurrentRow.Cells["cn_techcomments"].Value.ToString();
                _launchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddLaunchPassportComment frm = new frm_AddLaunchPassportComment();
                frm.HeaderText = "Edit launch comments";
                frm.Comments = _comments;
                frm.TechComments = _techcomments;
                frm.StateId = _stateid;
                frm.FillRBs(0);
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PlanBll.SavedLaunchPassportComments(_id, 0, frm.Comments, frm.TechComments, frm.StateId);
                    ShowComments(_launchid);
                }
            }
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void btn_addavisa_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _launch = "";

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _launch = gv_List.CurrentRow.Cells["cn_launch"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_AddVisa frm = new frm_AddVisa();
                frm.HeaderText = "Add additional visa for launch: " + _launch;
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show(PlanBll.AddLaunchAdditVisa(_id, frm.Comments));
                    ShowAddiVisas(_id);
                }
            }
        }

        private void btn_editvisa_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _comments = "";
            string _launch = "";
            int _launchid = 0;
            try
            {
                _launchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _id = Convert.ToInt32(gv_Visas.CurrentRow.Cells["cn_aid"].Value);
                _comments = gv_Visas.CurrentRow.Cells["cn_acomments"].Value.ToString();
                _launch = gv_List.CurrentRow.Cells["cn_launch"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_AddVisa frm = new frm_AddVisa();
                frm.HeaderText = "Edit additional visa for launch: " + _launch;
                frm.Comments = _comments;
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show(PlanBll.EditLaunchAdditVisa(_id, frm.Comments));
                    ShowAddiVisas(_launchid);
                }
            }
        }

        private void btn_AExcel_Click(object sender, EventArgs e)
        {
            ED2.DgvIntoExcel();
        }

        private void btn_QualityAdd_Click(object sender, EventArgs e)
        {
            DialogResult result1 = KryptonTaskDialog.Show("Quality visa warning!",
                                                               "Are you want to save changes?",
                                                               "You could not delete visa after!",
                                                               MessageBoxIcon.Warning,
                                                               TaskDialogButtons.Yes |
                                                               TaskDialogButtons.No |
                                                               TaskDialogButtons.Cancel);
            if (result1 == DialogResult.Yes)
            {
                int _id = 0;
                int _launchid = 0;
                try
                {
                    _id = Convert.ToInt32(gv_Visas.CurrentRow.Cells["cn_aid"].Value);
                    _launchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                }
                catch { }

                if (_id != 0)
                {
                    string _res = PlanBll.AddLaunchQualityAddViza(_id);
                    glob_Class.ShowMessage("Quality visa result", "", _res);

                    ShowAddiVisas(_launchid);

                }
            }
        }

        private void btn_IngeneeringAdd_Click(object sender, EventArgs e)
        {
            DialogResult result1 = KryptonTaskDialog.Show("TechDep visa warning!",
                                                               "Are you want to save changes?",
                                                               "You could not delete visa after!",
                                                               MessageBoxIcon.Warning,
                                                               TaskDialogButtons.Yes |
                                                               TaskDialogButtons.No |
                                                               TaskDialogButtons.Cancel);
            if (result1 == DialogResult.Yes)
            {
                int _id = 0;
                int _launchid = 0;
                try
                {
                    _id = Convert.ToInt32(gv_Visas.CurrentRow.Cells["cn_aid"].Value);
                    _launchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                }
                catch { }

                if (_id != 0)
                {
                    string _res = PlanBll.AddLaunchAdditIngenViza(_id);
                    glob_Class.ShowMessage("TechDep visa result", "", _res);

                    ShowAddiVisas(_launchid);

                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _comment = "";

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _comment = gv_List.CurrentRow.Cells["cn_visacomment"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_cmbText frm = new frm_cmbText();
                frm.LabelText = "Visa comments: ";
                frm.FormText = _comment;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK
                    && frm.FormText != _comment)
                {
                    string _res = PlanBll.EditLaunchVisaComment(_id, frm.FormText);
                    glob_Class.ShowMessage("Quality visa result", "", _res);

                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                    SetCellsColor();
                }
            }
        }

        private void btn_PrintRouteList_Click(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { _id = 0; }

            if (_id != 0)
            {
                PlanBll.LaunchId = _id;
                PlanBll.PasLaunchId = _id;


                frm_rptPassportTitle frm = new frm_rptPassportTitle();
                frm.HeaderText = "Print pasport for: " + PlanBll.LaunchName;
                frm.LaunchId = _id;
                frm.Launch = PlanBll.LaunchName;
                frm.Batch = PlanBll.LPasBatch;
                frm.BatchId = PlanBll.LaunchBatchId;
                frm.Article = PlanBll.LPasArticle;
                frm.CreatedAt = PlanBll.LPasCreatedAt;
                frm.CreatedBy = System.Environment.UserName;//PlanBll.PasCreatedBy;

                frm.ValidatedBy = PlanBll.LPasValidatedBy;
                frm.BatchStages = PlanBll.LPasLaunchStages;
                frm.CompanyOwner = PlanBll.LPasCompany;
                frm.Address = PlanBll.LPasAddress;
                frm.CustArticle = PlanBll.LPasCustArticle;
                frm.COrder = PlanBll.LPasConfOrder;
                frm.BatchComments = PlanBll.LPasComments;
                frm.OrderComments = PlanBll.LPasOrderComments;
                frm.Internal = PlanBll.LPasInternal.ToString();
                frm.OrderType = PlanBll.LPasOrderType;
                frm.Quantity = PlanBll.LPasQty.ToString();
                frm.OrderTypeId = PlanBll.LPasOrderTypeId;
                frm.Stage = PlanBll.LaunchStage;
                frm.VizaComments = PlanBll.LaunchVizaComments;

                frm.RepType = 3;

                frm.FillReport();

                frm.Show();
            }
        }
    }
}
