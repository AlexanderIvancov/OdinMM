using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Tools;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;


namespace Odin.Tools
{
    public partial class Template_DataGridView : KryptonForm
    {
        public Template_DataGridView()
        {
            InitializeComponent();
            ED = new ExportData(gv_List, "TemplateData.xls", this.Name);
        }

        class_Global glob_Class = new class_Global();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
       

        ExportData ED;

        public string Query
        {
            get;
            set;
        }

        public List<SqlParameter> SqlParams
        {
            get;
            set;
        }

        public void BindData(string StoredProcedure, params SqlParameter[] ParamList)
        {
            var data = Helper.QuerySP(StoredProcedure, ParamList);

            gv_List.AutoGenerateColumns = true;


            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;
            bn_List.BindingSource = bs_List;

            foreach (DataGridViewColumn column in gv_List.Columns)
            {
                if (column.Name == "autoincrement")
                    column.Visible = false;
                column.HeaderText = column.HeaderText.Replace('_', ' ');
                column.Width = 150;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            
        }

        private void Template_DataGridView_Load(object sender, EventArgs e)
        {
            BindData(Query, SqlParams.ToArray());
            try { Helper.LoadColumns(gv_List, Name); }
            catch { }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
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
                bs_List.Filter = ("Convert([" + ColumnName + "] , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
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
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = "([" + ColumnName + "] is null OR Convert([" + ColumnName + "], 'System.String') = '')";
                    else
                        bs_List.Filter = "Convert([" + ColumnName + "] , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = bs_List.Filter + "AND ([" + ColumnName + "] is null OR Convert([" + ColumnName + "], 'System.String') = '')";
                    else
                        bs_List.Filter = bs_List.Filter + " AND Convert([" + ColumnName + "] , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    bs_List.Filter = "Convert([" + ColumnName + "] , 'System.String') <> '" + CellValue + "'";
                else
                    bs_List.Filter = bs_List.Filter + " AND [" + ColumnName + "] <> '" + CellValue + "'";
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

            frm.HeaderText = "Select view for template list";
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

        private void UpdateTotal()
        {
            //int WithdrawalTotal = 0;
            //int DepositTotal = 0;
            double SelectedCellTotal = 0;
            int counter;

            // Iterate through all the rows and sum up the appropriate columns.
            //for (counter = 0; counter < (gv_List.Rows.Count);
            //    counter++)
            //{
            //    if (DataGridView1.Rows[counter].Cells["Withdrawals"].Value
            //        != null)
            //    {
            //        if (DataGridView1.Rows[counter].
            //            Cells["Withdrawals"].Value.ToString().Length != 0)
            //        {
            //            WithdrawalTotal += int.Parse(DataGridView1.Rows[counter].
            //                Cells["Withdrawals"].Value.ToString());
            //        }
            //    }

            //    if (DataGridView1.Rows[counter].Cells["Deposits"].Value != null)
            //    {
            //        if (DataGridView1.Rows[counter]
            //            .Cells["Deposits"].Value.ToString().Length != 0)
            //        {
            //            DepositTotal += int.Parse(DataGridView1.Rows[counter]
            //                .Cells["Deposits"].Value.ToString());
            //        }
            //    }
            //}

            // Iterate through the SelectedCells collection and sum up the values.
            for (counter = 0;
                counter < (gv_List.SelectedCells.Count); counter++)
            {
                if (gv_List.SelectedCells[counter].FormattedValueType ==
                    Type.GetType("System.String"))
                {
                    string value = null;

                    // If the cell contains a value that has not been commited,
                    // use the modified value.
                    if (gv_List.IsCurrentCellDirty == true)
                    {

                        value = gv_List.SelectedCells[counter]
                            .EditedFormattedValue.ToString();
                    }
                    else
                    {
                        value = gv_List.SelectedCells[counter]
                            .FormattedValue.ToString();
                    }
                    if (value != null)
                    {
                        try
                        {
                            // Ignore cells in the Description column.
                            if (value.Length != 0)
                            {
                                SelectedCellTotal += double.Parse(value);
                            }
                        }
                        catch { }
                    }
                }
            }

            // Set the labels to reflect the current state of the DataGridView.
            //Label1.Text = "Withdrawals Total: " + WithdrawalTotal.ToString();
            //Label2.Text = "Deposits Total: " + DepositTotal.ToString();
            txt_Sum.Text = SelectedCellTotal.ToString();
            //Label4.Text = "Total entries: " + DataGridView1.RowCount.ToString();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }
    }
}
