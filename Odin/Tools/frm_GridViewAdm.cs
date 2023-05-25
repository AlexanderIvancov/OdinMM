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
using System.Data.SqlClient;
namespace Odin.Tools
{
    public partial class frm_GridViewAdm : KryptonForm
    {
        public frm_GridViewAdm()
        {
            InitializeComponent();
        }

        #region variables

        class_Global globClass = new class_Global();
        DAL_Functions DLL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public DataGridView grid
        { get; set; }
        public string formname
        { get; set; }
        public int UserId
        { get; set; }
        public DataGridView gvList
        {
            get { return this.gv_List; }
        }

        #endregion

        #region methods

        public void FillData(DataGridView gridview)
        {
            dsColumns.Clear();
            foreach (DataGridViewColumn column in gridview.Columns)
            {
                DataRow row1 = dtColumns.NewRow();
                row1["cColumnName"] = column.Name;
                row1["cColumnText"] = column.HeaderText;
                row1["cColumnVis"] = globClass.BoolToCheck(column.Visible);
                row1["cColumnOrder"] = column.DisplayIndex;
                row1["cColumnId"] = 0;
                row1["cColumnWidth"] = column.Width;
                row1["cColumnExport"] = Convert.ToInt32(Helper.GetOneRecord("select isnull(columnexport, 0) as cex from mnu_colvis where formname = '" + formname 
                                        + "' and gridname = '" + grid.Name + "' and columnname = '" + column.Name + "' and userid = " + UserId  + ""));//globClass.BoolToCheck(column.Visible);
               
                dtColumns.Rows.Add(row1);


            }
            //Update of ColumnIDs
            UpdateColIDs(UserId, formname, grid.Name);
            ReorderData();
        }
        public void UpdateColIDs(int UserId, string FormName, string GridName)
        {
            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectUserGridViewColumn", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@userid", UserId);
            sqlComm.Parameters.AddWithValue("@formname", FormName);
            sqlComm.Parameters.AddWithValue("@gridname", GridName);

            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows)
            {
                //MessageBox.Show("True!");
                while (reader.Read())
                {
                    foreach (DataRow row in dtColumns.Rows)
                    {
                        if (row["cColumnName"].ToString() == reader["columnname"].ToString())
                        {
                            row.BeginEdit();
                            row["cColumnId"] = Convert.ToInt32(reader["id"]);
                            row.EndEdit();
                        }
                    }
                }
                reader.Close();
            }

            sqlConn.Close();
        }
        public void ReorderData()
        {
            bs_Columns.Sort = "cColumnOrder";
        }
        #endregion

        private void frm_GridViewAdm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(gvList.CurrentRow.Cells["cn_ColumnOrder"].Value);

            foreach (DataRow row in dtColumns.Rows)
            {
                if ((Int32)row["cColumnOrder"] == (k - 1))
                {
                    row.BeginEdit();
                    row["cColumnOrder"] = k;
                    row.EndEdit();
                }
                else if ((Int32)row["cColumnOrder"] == k)
                {
                    row.BeginEdit();
                    row["cColumnOrder"] = k - 1;
                    row.EndEdit();
                }
            }

            bs_Columns.ResetBindings(true);

            ReorderData();
            gvList.ClearSelection();
            //gvList.CurrentCell = gv_POLines.Rows[RowIndex].Cells[ColumnIndex];
            foreach (DataGridViewRow row in this.gvList.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_ColumnOrder"].Value) == (k - 1))
                {
                    row.Cells["cn_ColumnText"].Selected = true;
                    gvList.CurrentCell = row.Cells["cn_ColumnText"];
                }
                break;
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            int totalRows = gvList.Rows.Count;

            int k = Convert.ToInt32(gvList.CurrentRow.Cells["cn_ColumnOrder"].Value);

            if (k + 1 < totalRows)
            {
                foreach (DataRow row in dtColumns.Rows)
                {
                    if ((Int32)row["cColumnOrder"] == k)
                    {
                        row.BeginEdit();
                        row["cColumnOrder"] = k + 1;
                        row.EndEdit();
                    }
                    else if ((Int32)row["cColumnOrder"] == (k + 1))
                    {
                        row.BeginEdit();
                        row["cColumnOrder"] = k;
                        row.EndEdit();
                    }
                }

                bs_Columns.ResetBindings(true);

                ReorderData();
                gvList.ClearSelection();
                //gvList.CurrentCell = gv_POLines.Rows[RowIndex].Cells[ColumnIndex];
                foreach (DataGridViewRow row in this.gvList.Rows)
                {
                    if (Convert.ToInt32(row.Cells["cn_ColumnOrder"].Value) == (k + 1))
                    {
                        row.Cells["cn_ColumnText"].Selected = true;
                        gvList.CurrentCell = row.Cells["cn_ColumnText"];
                    }
                    break;
                }
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(gvList.CurrentRow.Cells["cn_ColumnOrder"].Value) == 0)
                    btn_Up.Enabled = false;
                else
                    btn_Up.Enabled = true;
            }
            catch { }

        }
    }
}
