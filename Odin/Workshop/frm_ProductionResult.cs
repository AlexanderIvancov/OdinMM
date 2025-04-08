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
using System.Threading;
using System.Data.SqlClient;
using Odin.Tools;
using Odin.Register.Catalog;
using System.Text.RegularExpressions;

namespace Odin.Workshop
{
    public partial class frm_ProductionResult : BaseForm
    {
        public frm_ProductionResult()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ProductionResults.xls", this.Name);
            ED1 = new ExportData(this.gv_Materials, "ProductionResultsMaterials.xls", this.Name);
        }

        #region Variables


        ExportData ED;


        ExportData ED1;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Processing_BLL BLL = new Processing_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        Helper MyHelper = new Helper();


        public int ControlWidth = 250;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int mRowIndex = 0;
        public int mColumnIndex = 0;
        public string mColumnName = "";
        public string mCellValue = "";

        public int Id
        { get; set; }

        int _PrevId = 0;

        #endregion

        #region Methods

        public void ClearFilter()
        {
            cmb_Launches1.LaunchId = 0;
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            cmb_SalesOrdersWithLines1.SalesOrder = "";
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            txt_Serial.Text = string.Empty;
            txt_DateFrom.Value = null; //Convert.ToDateTime("01/01/2000");
            txt_DateTill.Value = null; //Convert.ToDateTime("01/01/2100");
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_islast"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.Gold;

                if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
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

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }
        #endregion

        #region Context Menu Materials
        
        private void mnu_mLines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Materials.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Materials.HitTest(mpoint.X, mpoint.Y);

                mRowIndex = info.RowIndex;
                mColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Materials.ClearSelection();
                gv_Materials.Rows[mRowIndex].Cells[mColumnIndex].Selected = true;
                gv_Materials.CurrentCell = gv_Materials.Rows[mRowIndex].Cells[mColumnIndex];

                mCellValue = gv_Materials.Rows[mRowIndex].Cells[mColumnIndex].Value.ToString();
                mColumnName = gv_Materials.Columns[mColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                mRowIndex = 0;
                mColumnIndex = 0;
                return;
            }
        }

        private void mni_mFilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (String.IsNullOrEmpty(bs_List.Filter) == true)
                bs_Materials.Filter = "Convert(" + mColumnName + " , 'System.String') like '%" + mni_mFilterFor.Text + "%'";
                //else
                //    bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }          

        }

        private void mni_mSearch_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Materials;
            frm.ColumnNumber = gv_Materials.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Materials.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_mFilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Materials.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_Materials.Filter = "(" + mColumnName + " is null OR Convert(" + mColumnName + ", 'System.String') = '')";
                    else
                        bs_Materials.Filter = "Convert(" + mColumnName + " , 'System.String') = '" + glob_Class.NES(mCellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_Materials.Filter = bs_Materials.Filter + "AND (" + mColumnName + " is null OR Convert(" + mColumnName + ", 'System.String') = '')";
                    else
                        bs_Materials.Filter = bs_Materials.Filter + " AND Convert(" + mColumnName + " , 'System.String') = '" + glob_Class.NES(mCellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
        }

        private void mni_mFilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Materials.Filter) == true)
                    bs_Materials.Filter = "Convert(" + mColumnName + " , 'System.String') <> '" + mCellValue + "'";
                else
                    bs_Materials.Filter = bs_Materials.Filter + " AND " + mColumnName + " <> '" + mCellValue + "'";
            }
            catch { }
          
        }

        private void mni_mRemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Materials.RemoveFilter();
            }
            catch { }
          
        }

        private void mni_mCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mCellValue.ToString());
        }

        private void mni_mAdmin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for materials";
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

        private void btn_mExcel_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }

        #endregion
        public void bw_List(object sender, DoWorkEventArgs e)
        {

            var data = Processing_BLL.getProductionResults(txt_Serial.Text, cmb_Launches1.LaunchId, cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, 
                                            cmb_Types1.TypeId, cmb_Common1.SelectedValue, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim(), chk_Sum.Checked == true ? -1 : 0, chk_ConcOperations.Checked == true ? -1 : 0);

            var datam = Processing_BLL.getProductionMaterials(cmb_Launches1.LaunchId, cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId,
                                            cmb_Types1.TypeId, cmb_Common1.SelectedValue, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim());

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
            //Materials
            gv_Materials.ThreadSafeCall(delegate
            {
                gv_Materials.AutoGenerateColumns = false;
                bs_Materials.DataSource = datam;
                gv_Materials.DataSource = bs_Materials;
                
            });


            bn_Materials.ThreadSafeCall(delegate
            {
                bn_Materials.BindingSource = bs_Materials;
            });

        }

        

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void frm_ProductionResult_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);

            txt_DateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_DateTill.Value = null;
        }
        private void txt_DateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DateFrom.Value = txt_DateFrom.Value == null ? System.DateTime.Now : txt_DateFrom.Value;
        }

        private void txt_DateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_DateTill.Value = txt_DateTill.Value == null ? System.DateTime.Now : txt_DateTill.Value;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            gv_List.ThreadSafeCall(delegate { SetCellsColor(); });
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }


        #endregion

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Serial.Text = string.Empty;
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            UpdateTotal();
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
    }
}
