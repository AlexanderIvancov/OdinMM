using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Planning
{
    public delegate void BatchGroupingEventHandler(object sender);
    public partial class frm_BatchGrouping : KryptonForm
    {
        public frm_BatchGrouping()
        {
            InitializeComponent();
        }

        #region Variables

        int _EditMode = 0;
        public int EditMode
        {
            get { return _EditMode; }
            set { _EditMode = value; }
        }

        public event BatchGroupingEventHandler BatchGrouped;

        Plan_BLL BLL = new Plan_BLL();
        class_Global glob_Class = new class_Global();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        int _id = 0;
        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        //public string LaunchGroupName
        //{
        //    get { return cmb_LaunchGroups1.LaunchGroup; }
        //    set { cmb_LaunchGroups1.LaunchGroup = value; }
        //}
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


        public void FillList(DataTable datastages)
        {

            ds_List.Clear();

            var data = Plan_BLL.getGroupBatchesTot(datastages);

            foreach (DataRow row in data.Rows)
            {
                var selectedid = dt_Group.Select("id = " + Convert.ToInt32(row["id"]));

                if (selectedid.Length == 0)
                {
                    DataRow row1 = dt_List.NewRow();

                    row1["id"] = row["id"];
                    row1["batch"] = row["batch"];
                    row1["artid"] = row["artid"];
                    row1["article"] = row["article"];
                    row1["qty"] = row["qty"];
                    row1["customer"] = row["customer"];
                    row1["groupid"] = 0;

                    dt_List.Rows.Add(row1);
                }

            }
            this.bs_List.ResetBindings(false);


            //gv_List.ThreadSafeCall(delegate
            //{

            //    gv_List.AutoGenerateColumns = false;
            //    bs_List.DataSource = data;
            //    gv_List.DataSource = bs_List;

            //    SetCellsColor();
            //});


            //bn_List.ThreadSafeCall(delegate
            //{
            //    bn_List.BindingSource = bs_List;
            //});

        }

        public void tmpFillStages(int BatchId)
        {
            //tmpStages.Clear();


        }
        public void FillGroup(int groupid)
        {
            ds_Group.Clear();

            var data = Plan_BLL.getGroupBatches(groupid);


            foreach (DataRow row in data.Rows)
            {
                DataRow row1 = dt_Group.NewRow();

                row1["id"] = row["id"];
                row1["batch"] = row["batch"];
                row1["artid"] = row["artid"];
                row1["article"] = row["article"];
                row1["qty"] = row["qty"];
                row1["customer"] = row["customer"];
                row1["groupid"] = cmb_Batches1.BatchId;
                row1["ismain"] = row["ismain"];

                dt_Group.Rows.Add(row1);

            }
            this.bs_Group.ResetBindings(false);

            //gv_Group.ThreadSafeCall(delegate
            //{

            //    gv_Group.AutoGenerateColumns = false;
            //    bs_Group.DataSource = data;
            //    gv_Group.DataSource = bs_Group;

            //});


            //bn_Group.ThreadSafeCall(delegate
            //{
            //    bn_Group.BindingSource = bs_Group;
            //});
            SetCellsColor();
        }

        public void ResetEditMode(int _Batchid)
        {
            if (_Batchid == 0)
                EditMode = 0;
            else
            {
                int _res = Convert.ToInt32(Helper.GetOneRecord("select distinct id from PROD_batchHead where groupid = " + _Batchid));
                if (_res != 0)
                {
                    EditMode = -1;
                    btn_Remove.Enabled = false;
                }

                else
                {
                    EditMode = 0;
                    btn_Remove.Enabled = true;
                }
                int _check = Convert.ToInt32(Helper.GetOneRecord("select distinct isnull(groupid, 0) from PROD_batchHead where id = " + _Batchid));
                if (_check != 0)
                {
                    glob_Class.ShowMessage("Batch grouping warning!", "Choose another group!", "Selected batch already in group and can not be as group!");
                    BatchId = 0;
                    EditMode = 0;
                    btn_Remove.Enabled = true;
                    FillGroup(0);
                }
            }
        }
        public void SetCellsColor()
        {

            foreach (DataGridViewRow row in gv_Group.Rows)
            {
                if (Convert.ToInt16(row.Cells["cn_gismain"].Value) != 0)
                    row.DefaultCellStyle.BackColor = Color.Yellow;
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
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }

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

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for delivery planning";
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

        #endregion

        private void btn_Save_Click(object sender, EventArgs e)
        {


        }

        private void frm_LaunchRMReservation_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            //int _launchdetid = 0;

            //try { _launchdetid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            //catch { _launchdetid = -99; }

            //if (_launchdetid != 0)
            //    FillLabels(_launchdetid);
        }

        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataTable datastages = new DataTable();
            datastages.Columns.Add("id", typeof(int));

            if (cmb_Batches1.BatchId != 0)
            {
                var data = Plan_BLL.getBatchStages(BatchId);

                foreach (DataRow row in data.Rows)
                {
                    if (Convert.ToInt32(row["checked"]) == -1)
                    {
                        DataRow dr = datastages.NewRow();
                        dr["id"] = Convert.ToInt32(row["id"]);
                        datastages.Rows.Add(dr);
                    }
                }
            }

            FillList(datastages);
            FillGroup(cmb_Batches1.BatchId);
            ResetEditMode(cmb_Batches1.BatchId);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            foreach (DataRow row in dt_List.Rows)
            {
                if (Convert.ToInt32(row["id"]) == _id)
                {
                    int _tmpid = Convert.ToInt32(row["id"]);

                    DataRow row1 = dt_Group.NewRow();
                    row1["id"] = row["id"];
                    row1["batch"] = row["batch"];
                    row1["artid"] = row["artid"];
                    row1["article"] = row["article"];
                    row1["qty"] = row["qty"];
                    row1["customer"] = row["customer"];
                    row1["groupid"] = row["groupid"];
                    row1["ismain"] = dt_Group.Rows.Count > 0 ? 0 : -1;

                    dt_Group.Rows.Add(row1);
                    this.bs_Group.ResetBindings(false);
                    SetCellsColor();

                    row.Delete();

                    DataTable datastages = new DataTable();
                    datastages.Columns.Add("id", typeof(int));

                    var data = Plan_BLL.getBatchStages(_tmpid);
                    var selectedid = data.Select("checked = -1");

                    if (selectedid.Length == 0)
                    {
                        DataRow dr = datastages.NewRow();
                        dr["id"] = -99;
                        datastages.Rows.Add(dr);
                    }
                    else
                    {
                        foreach (DataRow row2 in data.Rows)
                        {
                            if (Convert.ToInt32(row2["checked"]) == -1)
                            {
                                DataRow dr = datastages.NewRow();
                                dr["id"] = Convert.ToInt32(row2["id"]);
                                datastages.Rows.Add(dr);
                            }
                        }
                    }

                    FillList(datastages);

                    break;

                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            gv_Group.EndEdit();

            int _id = 0;

            try { _id = Convert.ToInt32(gv_Group.CurrentRow.Cells["cn_gid"].Value); }
            catch { }

            foreach (DataRow row in dt_Group.Rows)
            {
                if (Convert.ToInt32(row["id"]) == _id)
                {
                    DataRow row1 = dt_List.NewRow();
                    row1["id"] = row["id"];
                    row1["batch"] = row["batch"];
                    row1["artid"] = row["artid"];
                    row1["article"] = row["article"];
                    row1["qty"] = row["qty"];
                    row1["customer"] = row["customer"];
                    row1["groupid"] = row["groupid"];

                    dt_List.Rows.Add(row1);
                    this.bs_List.ResetBindings(false);
                    row.Delete();
                    SetCellsColor();
                    break;
                }
            }
            if (dt_Group.Rows.Count == 0)
            {
                DataTable datastages = new DataTable();
                datastages.Columns.Add("id", typeof(int));
                FillList(datastages);
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (EditMode == 0)
            {
                int _HeadId = 0;
                gv_Group.EndEdit();
                {
                    foreach (DataRow row in dt_Group.Rows)
                    {
                        if (Convert.ToInt32(row["groupid"]) == 0)
                        {
                            _HeadId = BLL.AddBatchesToGroup(_HeadId, Convert.ToInt32(row["id"]), Convert.ToInt32(row["ismain"]));
                        }
                    }
                    cmb_Batches1.BatchId = _HeadId;
                    ResetEditMode(_HeadId);
                }
            }
            else
            {
                gv_Group.EndEdit();
                {
                    foreach (DataRow row in dt_Group.Rows)
                    {
                        if (Convert.ToInt32(row["groupid"]) == 0)
                        {
                            BLL.AddBatchesToGroup(cmb_Batches1.BatchId, Convert.ToInt32(row["id"]), Convert.ToInt32(row["ismain"]));
                        }
                    }

                    ResetEditMode(cmb_Batches1.BatchId);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_Group_SelectionChanged(object sender, EventArgs e)
        {
            if (EditMode == 0)
                btn_Remove.Enabled = true;
            else
            {
                try
                {
                    btn_Remove.Enabled = Convert.ToInt32(gv_Group.CurrentRow.Cells["cn_ggroupid"].Value) == 0;
                }
                catch { }
            }
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            DataTable datastages = new DataTable();
            datastages.Columns.Add("id", typeof(int));

            if (cmb_Batches1.BatchId != 0)
            {
                var data = Plan_BLL.getBatchStages(BatchId);

                foreach (DataRow row in data.Rows)
                {
                    if (Convert.ToInt32(row["checked"]) == -1)
                    {
                        DataRow dr = datastages.NewRow();
                        dr["id"] = Convert.ToInt32(row["id"]);
                        datastages.Rows.Add(dr);
                    }
                }
            }

            FillList(datastages);
            FillGroup(cmb_Batches1.BatchId);
            ResetEditMode(cmb_Batches1.BatchId);
        }

        private void gv_Group_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
