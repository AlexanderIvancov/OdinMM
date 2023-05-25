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
    public partial class frm_LaunchPassportComments : BaseForm
    {
        public frm_LaunchPassportComments()
        {
            InitializeComponent();
            ED1 = new ExportData(this.gv_Comments, "LaunchesPassportComments.xls", this.Name);
        }

        #region Variables
        public event LaunchSavingPasEventHandler LaunchSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED1;


        public int RowIndexC = 0;
        public int ColumnIndexC = 0;
        public string ColumnNameC = "";
        public string CellValueC = "";


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

        public int State
        {
            get
            {
                if (rb_All.Checked == true)
                    return -99;
                else if (rb_New.Checked == true)
                    return -1;
                else if (rb_Closed.Checked == true)
                    return 0;
                else
                    return 1;
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

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            //MessageBox.Show(cmb_SalesOrdersWithLines1.SalesOrderLineId.ToString());
            var data = Plan_BLL.getLaunchesPassportCommentsList(cmb_Batches1.BatchId, cmb_Launches1.LaunchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, IsActive,
                                            cmb_Types1.TypeId, txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                            txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim(), cmb_Firms1.FirmId, cmb_Common1.SelectedValue, State);


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


        #endregion

        #region Controls
        private void frm_LaunchPassportComments_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_Comments);

            ClearFilter();
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }


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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_Comments.SortedColumn;
            var dir = Helper.SaveDirection(gv_Comments);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_Comments, oldColumn, dir);

            SetCellsColor();
        }

        private void btn_EditCom_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _comments = "";
            string _techcomments = "";
            int _stateid = 0;
            int _launchid = 0;
            string _launch = "";
            try
            {
                _id = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_cid"].Value);
                _stateid = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_cstateid"].Value);
                _comments = gv_Comments.CurrentRow.Cells["cn_ccomments"].Value.ToString();
                _techcomments = gv_Comments.CurrentRow.Cells["cn_techcomments"].Value.ToString();
                _launchid = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_launchid"].Value);
                _launch = gv_Comments.CurrentRow.Cells["cn_launch"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_AddLaunchPassportComment frm = new frm_AddLaunchPassportComment();
                frm.HeaderText = "Edit launch comments for: " + _launch; 
                frm.Comments = _comments;
                frm.TechComments = _techcomments;
                frm.StateId = _stateid;
                frm.FillRBs(0);
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PlanBll.SavedLaunchPassportComments(_id, 0, frm.Comments, frm.TechComments, frm.StateId);
                    DataGridViewColumn oldColumn = gv_Comments.SortedColumn;
                    var dir = Helper.SaveDirection(gv_Comments);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_Comments, oldColumn, dir);

                    SetCellsColor();
                }
            }
        }


        #endregion

        private void gv_Comments_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void gv_Comments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _id = 0;
            string _comments = "";
            string _techcomments = "";
            int _stateid = 0;
            int _launchid = 0;
            string _launch = "";
            try
            {
                _id = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_cid"].Value);
                _stateid = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_cstateid"].Value);
                _comments = gv_Comments.CurrentRow.Cells["cn_ccomments"].Value.ToString();
                _techcomments = gv_Comments.CurrentRow.Cells["cn_techcomments"].Value.ToString();
                _launchid = Convert.ToInt32(gv_Comments.CurrentRow.Cells["cn_launchid"].Value);
                _launch = gv_Comments.CurrentRow.Cells["cn_launch"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_AddLaunchPassportComment frm = new frm_AddLaunchPassportComment();
                frm.HeaderText = "Edit launch comments for: " + _launch;
                frm.Comments = _comments;
                frm.TechComments = _techcomments;
                frm.StateId = _stateid;
                frm.FillRBs(0);
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PlanBll.SavedLaunchPassportComments(_id, 0, frm.Comments, frm.TechComments, frm.StateId);
                    DataGridViewColumn oldColumn = gv_Comments.SortedColumn;
                    var dir = Helper.SaveDirection(gv_Comments);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_Comments, oldColumn, dir);

                    SetCellsColor();
                }
            }
        }
    }
}
