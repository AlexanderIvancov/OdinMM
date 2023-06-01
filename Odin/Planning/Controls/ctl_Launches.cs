﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.Planning.Controls
{
    public partial class ctl_Launches : UserControl
    {
        public ctl_Launches()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "Launches.xls", this.Name);
        }


        #region Variables

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;


        ProgressForm wait;
        ExportData ED;
        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        Plan_BLL PlanBll = new Plan_BLL();

        int _batchid = 0;
        int _coid = 0;

        public int BatchId
        {
            get { return _batchid; }
            set
            {

                _batchid = value;

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                FillLaunches(_batchid);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
            }
        }

        public int COId
        {
            get { return _coid; }
            set
            {

                _coid = value;

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                FillLaunchesCO(_coid);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        #endregion

        #region Methods

        public void FillLaunches(int BatchId)
        {
            var data = Plan_BLL.getBatchLaunches(BatchId);

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

        public void FillLaunchesCO(int COId)
        {
            var data = Plan_BLL.getBatchLaunchesCO(COId);

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
                if (Convert.ToInt32(row.Cells["chk_isstarted"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                if (Convert.ToInt32(row.Cells["cn_isfinished"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.Gainsboro;
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

        #endregion

        private void ctl_Launches_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

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

            frm.HeaderText = "Select view for batches list";
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

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            if (COId == 0)
                FillLaunches(BatchId);
            else
                FillLaunchesCO(COId);
            Helper.RestoreDirection(gv_List, oldColumn, dir);
            SetCellsColor();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void gv_List_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < gv_List.RowCount - 1)
            {
                if (gv_List.Rows[e.RowIndex].Cells["chk_isstarted"].Value.ToString() == "-1")
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

                if (gv_List.Rows[e.RowIndex].Cells["cn_isfinished"].Value.ToString() == "-1")
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }
    }
}