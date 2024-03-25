using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.StockOut.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Planning
{
    public partial class frm_LaunchGrouping : KryptonForm
    {
        public frm_LaunchGrouping()
        {
            InitializeComponent();
        }

        #region Variables

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
        public int LaunchId
        {
            get { return _id; }
            set { _id = value; }
        }
        public string LaunchGroupName
        {
            get { return cmb_LaunchGroups1.LaunchGroup; }
            set { cmb_LaunchGroups1.LaunchGroup = value; }
        }
        #endregion

        #region Methods
        
        public void FillList(int _stageid)
        {
            ds_List.Clear();

            var data = (DataTable)Helper.getSP("sp_SelectLaunchesGroupTot", _stageid);
                                    
            foreach (DataRow row in data.Rows)
            {
                DataRow row1 = dt_List.NewRow();

                row1["id"] = row["id"];
                row1["launch"] = row["launch"];
                row1["artid"] = row["artid"];
                row1["article"] = row["article"];
                row1["qty"] = row["qty"];
                row1["customer"] = row["customer"];
                row1["groupname"] = "";

                dt_List.Rows.Add(row1);
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

        public void FillGroup(string _groupname)
        {
            ds_Group.Clear();

            var data = (DataTable)Helper.getSP("sp_SelectLaunchesGroup", _groupname);

            foreach (DataRow row in data.Rows)
            {
                DataRow row1 = dt_Group.NewRow();

                row1["id"] = row["id"];
                row1["launch"] = row["launch"];
                row1["artid"] = row["artid"];
                row1["article"] = row["article"];
                row1["qty"] = row["qty"];
                row1["customer"] = row["customer"];
                row1["groupname"] = _groupname;

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
        }

        public void SetCellsColor()
        {
            //foreach (DataGridViewRow row in gv_List.Rows)
            //{
            //    if (Convert.ToDouble(row.Cells["cn_qty"].Value) > Convert.ToDouble(row.Cells["cn_reserved"].Value) + Convert.ToDouble(row.Cells["cn_given"].Value))
            //        row.DefaultCellStyle.BackColor = Color.LightCoral;
            //}
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
                Helper.LoadColumns(gv_List, this.Name);
            }
        }

        #endregion

        private void btn_Save_Click(object sender, EventArgs e) { }
        
        private void frm_LaunchRMReservation_Load(object sender, EventArgs e)
        {
            Helper.LoadColumns(gv_List, this.Name);
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
            FillList(1);
            FillGroup(cmb_LaunchGroups1.LaunchGroup);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            int _id = 0;
                    
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            foreach (DataRow row in dt_List.Rows)
                if (Convert.ToInt32(row["id"]) == _id)
                {
                    DataRow row1 = dt_Group.NewRow();
                    row1["id"] = row["id"];
                    row1["launch"] = row["launch"];
                    row1["artid"] = row["artid"];
                    row1["article"] = row["article"];
                    row1["qty"] = row["qty"];
                    row1["customer"] = row["customer"];
                    row1["groupname"] = row1["groupname"];

                    dt_Group.Rows.Add(row1);
                    this.bs_Group.ResetBindings(false);
                    SetCellsColor();
                    row.Delete();
                    break;
                }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            gv_Group.EndEdit();

            int _id = 0;
            
            try { _id = Convert.ToInt32(gv_Group.CurrentRow.Cells["cn_gid"].Value); }
            catch { }

            foreach (DataRow row in dt_Group.Rows)
                if (Convert.ToInt32(row["id"]) == _id)
                {
                    DataRow row1 = dt_List.NewRow();
                    row1["id"] = row["id"];
                    row1["launch"] = row["launch"];
                    row1["artid"] = row["artid"];
                    row1["article"] = row["article"];
                    row1["qty"] = row["qty"];
                    row1["customer"] = row["customer"];
                    row1["groupname"] = row1["groupname"];

                    dt_List.Rows.Add(row1);
                    this.bs_List.ResetBindings(false);
                    SetCellsColor();
                    row.Delete();
                    break;
                }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_Group.EndEdit();
            {
                //Delete from group
                //Add on group

                DataTable datalaunches = new DataTable();
                datalaunches.Columns.Add("id", typeof(int));
                
                foreach (DataRow row in dt_List.Rows)
                    if (row["groupname"].ToString().Trim() != "")
                    {
                        DataRow dr = datalaunches.NewRow();
                        dr["id"] = Convert.ToInt32(row["id"]);
                        datalaunches.Rows.Add(dr);
                    }
                Helper.getSP("sp_ReleaseLaunchesFromGroup", datalaunches);
                //BLL.ReserveLaunchLabels(_launchdetid, datastages);
                datalaunches.Clear();
                foreach (DataRow row in dt_Group.Rows)
                    if (row["groupname"].ToString().Trim() == "")
                    {
                        DataRow dr = datalaunches.NewRow();
                        dr["id"] = Convert.ToInt32(row["id"]);
                        datalaunches.Rows.Add(dr);
                    }

                string res = Convert.ToString(Helper.getSP("sp_AddLaunchesInGroup", LaunchGroupName, datalaunches));
                LaunchGroupName = res;

                gv_List.ThreadSafeCall(delegate { FillList(1); });
                gv_Group.ThreadSafeCall(delegate { FillGroup(cmb_LaunchGroups1.LaunchGroup); }) ;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            frm_rptStockMove frm = new frm_rptStockMove();

            frm.AssPerson = cmb_Users1.UserShortName;
            frm.RepType = 6;
            frm.MoveDate = DateTime.Today.ToShortDateString();
            frm.GroupName = LaunchGroupName;
           
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Start_Click(object sender, EventArgs e) { }

        private void btn_reserverm_Click(object sender, EventArgs e) { }

        private void btn_MissingRM_Click(object sender, EventArgs e)
        {
            string _groupname = LaunchGroupName;

            if (_groupname != "")
            {
                var _query = "sp_SelectLaunchRMMissingsGroup";

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@groupname",SqlDbType.NVarChar) {Value = _groupname}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Launch RM missings ";
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void btn_PrintRM_Click(object sender, EventArgs e)
        {
            frm_rptStockMove frm = new frm_rptStockMove();

            frm.AssPerson = cmb_Users1.UserShortName;
            frm.RepType = 7;
            frm.MoveDate = System.DateTime.Today.ToShortDateString();
            frm.GroupName = LaunchGroupName;

            frm.Show(); frm.GetKryptonFormFields();
        }
    }
}