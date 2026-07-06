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
using Odin.DataCollection;

namespace Odin.Workshop
{
    public partial class frm_ProductionResult : BaseForm
    {
        public frm_ProductionResult()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ProductionResults.xls", this.Name);
            ED1 = new ExportData(this.gv_Materials, "ProductionResultsMaterials.xls", this.Name);
            ED2 = new ExportData(this.gv_Machines, "ProductionResultsSMT.xls", this.Name);
            ED3 = new ExportData(this.gv_Repairs, "ProductionResultsRepairs.xls", this.Name);
        }

        #region Variables


        ExportData ED;
        ExportData ED1;
        ExportData ED2;
        ExportData ED3;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Processing_BLL BLL = new Processing_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        Helper MyHelper = new Helper();
        DC_BLL DCBll = new DC_BLL();

        public int ControlWidth = 250;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int mRowIndex = 0;
        public int mColumnIndex = 0;
        public string mColumnName = "";
        public string mCellValue = "";
        public int macRowIndex = 0;
        public int macColumnIndex = 0;
        public string macColumnName = "";
        public string macCellValue = "";
        public int rRowIndex = 0;
        public int rColumnIndex = 0;
        public string rColumnName = "";
        public string rCellValue = "";

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

        public void SetCellsColorRepairs()
        {
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_islast"].Value) == -1)
            //        row.DefaultCellStyle.BackColor = Color.Gold;

            //    if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
            //}
        }

        public void SetCellsColorMaterial()
        {
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_islast"].Value) == -1)
            //        row.DefaultCellStyle.BackColor = Color.Gold;

            //    if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
            //}
        }

        public void SetCellsColorMachine()
        {
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_islast"].Value) == -1)
            //        row.DefaultCellStyle.BackColor = Color.Gold;

            //    if (Convert.ToInt32(row.Cells["cn_isapproved"].Value) == -1)
            //        row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
            //}
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

        public void FillLabels()
        {
            if (dn_Pages.SelectedPage == pg_Workers)
            {
                cmb_Lines.Visible = false;
                lbl_Line.Visible = false;
                cmb_Worker.Visible = true;
                lbl_Worker.Visible = true;
                txt_Serial.Visible = false;
                lbl_Serial.Visible = false;
                chk_ConcOperations.Visible = true;
                chk_Sum.Visible = true;
            }
            if (dn_Pages.SelectedPage == pg_Repairs)
            {
                cmb_Lines.Visible = false;
                lbl_Line.Visible = false;
                cmb_Worker.Visible = true;
                lbl_Worker.Visible = true;
                txt_Serial.Visible = true;
                lbl_Serial.Visible = true;
                chk_ConcOperations.Visible = false;
                chk_Sum.Visible = false;
            }

            else
            {
                cmb_Lines.Visible = true;
                lbl_Line.Visible = true;
                cmb_Worker.Visible = false;
                lbl_Worker.Visible = false;
                txt_Serial.Visible = false;
                lbl_Serial.Visible = false;
                chk_ConcOperations.Visible = true;
                chk_Sum.Visible = true;
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
                    if (String.IsNullOrEmpty(mCellValue) == true)
                        bs_Materials.Filter = "(" + mColumnName + " is null OR Convert(" + mColumnName + ", 'System.String') = '')";
                    else
                        bs_Materials.Filter = "Convert(" + mColumnName + " , 'System.String') = '" + glob_Class.NES(mCellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(mCellValue) == true)
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

        #region Context menu machines


        private void mnu_macLines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Machines.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Machines.HitTest(mpoint.X, mpoint.Y);

                macRowIndex = info.RowIndex;
                macColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Machines.ClearSelection();
                gv_Machines.Rows[macRowIndex].Cells[macColumnIndex].Selected = true;
                gv_Machines.CurrentCell = gv_Machines.Rows[macRowIndex].Cells[macColumnIndex];

                macCellValue = gv_Machines.Rows[macRowIndex].Cells[macColumnIndex].Value.ToString();
                macColumnName = gv_Machines.Columns[macColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                macRowIndex = 0;
                macColumnIndex = 0;
                return;
            }
        }

        private void mni_macFilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (String.IsNullOrEmpty(bs_List.Filter) == true)
                bs_Machines.Filter = "Convert(" + macColumnName + " , 'System.String') like '%" + mni_macFilterFor.Text + "%'";
                //else
                //    bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColorMachine();

        }

        private void mni_macSearch_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Machines;
            frm.ColumnNumber = gv_Machines.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Machines.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_macFilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Machines.Filter) == true)
                {
                    if (String.IsNullOrEmpty(macCellValue) == true)
                        bs_Machines.Filter = "(" + macColumnName + " is null OR Convert(" + macColumnName + ", 'System.String') = '')";
                    else
                        bs_Machines.Filter = "Convert(" + macColumnName + " , 'System.String') = '" + glob_Class.NES(macCellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(macCellValue) == true)
                        bs_Machines.Filter = bs_Machines.Filter + "AND (" + macColumnName + " is null OR Convert(" + macColumnName + ", 'System.String') = '')";
                    else
                        bs_Machines.Filter = bs_Machines.Filter + " AND Convert(" + macColumnName + " , 'System.String') = '" + glob_Class.NES(macCellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColorMachine();

        }

        private void mni_macFilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Machines.Filter) == true)
                    bs_Machines.Filter = "Convert(" + macColumnName + " , 'System.String') <> '" + macCellValue + "'";
                else
                    bs_Machines.Filter = bs_Machines.Filter + " AND " + macColumnName + " <> '" + macCellValue + "'";
            }
            catch { }
            SetCellsColorMachine();

        }

        private void mni_macRemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Machines.RemoveFilter();
            }
            catch { }
            SetCellsColorMachine();

        }
        
        private void mni_macCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(macCellValue.ToString());
        }

        private void mni_macAdmin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for batches list";
            frm.grid = this.gv_Machines;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Machines);
            }
        }

        private void btn_macExcel_Click(object sender, EventArgs e)
        {
            ED2.DgvIntoExcel();
        }
        #endregion

        #region Context menu repairs
        private void mnu_rLines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Repairs.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Repairs.HitTest(mpoint.X, mpoint.Y);

                rRowIndex = info.RowIndex;
                rColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Repairs.ClearSelection();
                gv_Repairs.Rows[rRowIndex].Cells[rColumnIndex].Selected = true;
                gv_Repairs.CurrentCell = gv_Repairs.Rows[rRowIndex].Cells[rColumnIndex];

                rCellValue = gv_Repairs.Rows[rRowIndex].Cells[rColumnIndex].Value.ToString();
                rColumnName = gv_Repairs.Columns[rColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                rRowIndex = 0;
                rColumnIndex = 0;
                return;
            }
        }

        private void mni_rFilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (String.IsNullOrEmpty(bs_List.Filter) == true)
                bs_Repairs.Filter = "Convert(" + rColumnName + " , 'System.String') like '%" + mni_rFilterFor.Text + "%'";
                //else
                //    bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'";
                //bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColorRepairs();
        }

        private void mni_rSearch_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Repairs;
            frm.ColumnNumber = gv_Repairs.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Repairs.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_rFilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Repairs.Filter) == true)
                {
                    if (String.IsNullOrEmpty(rCellValue) == true)
                        bs_Repairs.Filter = "(" + rColumnName + " is null OR Convert(" + rColumnName + ", 'System.String') = '')";
                    else
                        bs_Repairs.Filter = "Convert(" + rColumnName + " , 'System.String') = '" + glob_Class.NES(rCellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(rCellValue) == true)
                        bs_Repairs.Filter = bs_Repairs.Filter + "AND (" + rColumnName + " is null OR Convert(" + rColumnName + ", 'System.String') = '')";
                    else
                        bs_Repairs.Filter = bs_Repairs.Filter + " AND Convert(" + rColumnName + " , 'System.String') = '" + glob_Class.NES(rCellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColorRepairs();
        }

        private void mni_rFilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Repairs.Filter) == true)
                    bs_Repairs.Filter = "Convert(" + rColumnName + " , 'System.String') <> '" + rCellValue + "'";
                else
                    bs_Repairs.Filter = bs_Repairs.Filter + " AND " + rColumnName + " <> '" + rCellValue + "'";
            }
            catch { }
            SetCellsColor();
        }

        private void mni_rRemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Repairs.RemoveFilter();
            }
            catch { }
            SetCellsColorRepairs();
        }

        private void mni_rCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rCellValue.ToString());
        }

        private void mni_rAdmin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for batches list";
            frm.grid = this.gv_Repairs;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Repairs);
            }
        }


        private void btn_ExcelRepairs_Click(object sender, EventArgs e)
        {
            ED3.DgvIntoExcel();
        }

        #endregion  

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            var data = Processing_BLL.getProductionResults(txt_Serial.Text, cmb_Launches1.LaunchId, cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, 
                                            cmb_Types1.TypeId, cmb_Worker.SelectedValue, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim(), chk_Sum.Checked == true ? -1 : 0, chk_ConcOperations.Checked == true ? -1 : 0);

            

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

        public void bw_ListMachines(object sender, DoWorkEventArgs e)
        {

            var data = Processing_BLL.getProductionResultsMachine(txt_Serial.Text, cmb_Launches1.LaunchId, cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId,
                                            cmb_Types1.TypeId, cmb_Lines.SelectedValue, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim());



            gv_Machines.ThreadSafeCall(delegate
            {
                gv_Machines.AutoGenerateColumns = false;
                bs_Machines.DataSource = data;
                gv_Machines.DataSource = bs_Machines;

                SetCellsColorMachine();
            });


            bn_Machines.ThreadSafeCall(delegate
            {
                bn_Machines.BindingSource = bs_Machines;
            });



        }

        public void bw_MaterialList(object sender, DoWorkEventArgs e)
        {
            var datam = Processing_BLL.getProductionMaterials(cmb_Launches1.LaunchId, cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId,
                                            cmb_Types1.TypeId, cmb_Worker.SelectedValue, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim());

            gv_Materials.ThreadSafeCall(delegate
            {
                gv_Materials.AutoGenerateColumns = false;
                bs_Materials.DataSource = datam;
                gv_Materials.DataSource = bs_Materials;

            });

            //Materials
            bn_Materials.ThreadSafeCall(delegate
            {
                bn_Materials.BindingSource = bs_Materials;
            });

        }
        
        public void bw_RepairList(object sender, DoWorkEventArgs e)
        {
            var datar = Processing_BLL.getProductionRepairs(txt_Serial.Text, cmb_Launches1.LaunchId, cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId,
                                            cmb_Types1.TypeId, cmb_Worker.SelectedValue, txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                            txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim(), chk_Sum.Checked == true ? -1 : 0, chk_ConcOperations.Checked == true ? -1 : 0);

            gv_Repairs.ThreadSafeCall(delegate
            {
                gv_Repairs.AutoGenerateColumns = false;
                bs_Repairs.DataSource = datar;
                gv_Repairs.DataSource = bs_Repairs;

            });

            //Materials
            bn_Repairs.ThreadSafeCall(delegate
            {
                bn_Repairs.BindingSource = bs_Repairs;
            });

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void frm_ProductionResult_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            LoadColumns(gv_Materials);
            LoadColumns(gv_Machines);
            LoadColumns(gv_Repairs);
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

            if (dn_Pages.SelectedPage == pg_Workers)
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                gv_List.ThreadSafeCall(delegate { SetCellsColor(); });
            }
            if (dn_Pages.SelectedPage == pg_Repairs)
            {
                DataGridViewColumn oldColumn = gv_Repairs.SortedColumn;
                var dir = Helper.SaveDirection(gv_Repairs);

                bwStart(bw_RepairList);

                Helper.RestoreDirection(gv_Repairs, oldColumn, dir);

                gv_Repairs.ThreadSafeCall(delegate { SetCellsColorRepairs(); });

            }
            else
            {
                DataGridViewColumn oldColumn = gv_Machines.SortedColumn;
                var dir = Helper.SaveDirection(gv_Machines);

                bwStart(bw_ListMachines);

                Helper.RestoreDirection(gv_Machines, oldColumn, dir);

                gv_Machines.ThreadSafeCall(delegate { SetCellsColorMachine(); });
            }


            DataGridViewColumn oldColumnm = gv_Materials.SortedColumn;
            var dirm = Helper.SaveDirection(gv_Materials);

            bwStart(bw_MaterialList);

            Helper.RestoreDirection(gv_Materials, oldColumnm, dirm);

            gv_Materials.ThreadSafeCall(delegate { SetCellsColorMaterial(); });
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

        private void btn_EditHeader_Click(object sender, EventArgs e)
        {
            int _headid = 0;
            string _when = "";
            int _prodtime = 0;
            DataTable dataworkers = new DataTable();
            dataworkers.Columns.Add("id", typeof(int));

            try { _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value);
               
                _prodtime = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_prodtime"].Value);
            }
            catch { }

            if (_headid != 0)
            {
                _when = Helper.GetOneRecord("set dateformat dmy select convert(nvarchar(10), proddate, 103) from PROD_SerialAssemblingHead where id = " + _headid).ToString();//Convert.ToDateTime(gv_List.CurrentRow.Cells["cn_headid"].Value).ToShortDateString();

                string strSQL = "select w.id, w.name + ' ' + w.surname as worker " +
                        " from PROD_SerialAssemblingWorkers sw inner join PROD_Workers w on w.id = sw.workerid where sw.headid = " + _headid;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(strSQL, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];


                frm_FinishShift frm = new frm_FinishShift();
                frm.HeaderText = "Finish work";
                frm.txt_Date.Visible = true;
                frm.lbl_Date.Visible = true;
                frm.ProdDate = _when;

                foreach (DataRow row in dt.Rows)
                {
                    frm.gv_Workers.ThreadSafeCall(delegate { frm.AddWorkerToList(Convert.ToInt32(row["id"]), row["worker"].ToString()); });
                }

                frm.WorkTime = _prodtime;
                
                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    dataworkers.Rows.Clear();

                    foreach (DataGridViewRow row in frm.gv_Workers.Rows)
                    {
                        DataRow dr = dataworkers.NewRow();
                        dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                        dataworkers.Rows.Add(dr);
                    }

                    DCBll.EditDataCollectionFinish(_headid, frm.ProdDate, frm.WorkTime, dataworkers);


                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                    gv_List.ThreadSafeCall(delegate { SetCellsColor(); });
                }

                //if (dt.Rows.Count > 0)
                //{
                //    foreach (DataRow dr in dt.Rows)
                //    {
                //        CheckInstructions = dr["instructions"].ToString();
                //        CheckParameters = Convert.ToInt32(dr["checkbefore"].ToString());

                //    }
                //}

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _serial = "";
            if (globClass.MessageConfirm("Cancelling of shift", "Are you sure you want to cancel of shift for these lines?") == true)
            {
                foreach (DataGridViewRow row in gv_List.SelectedRows)
                {
                    try { _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                        _serial = row.Cells["cn_sn"].Value.ToString();
                    }
                    catch { }

                    if (_id != 0)
                    {
                        DCBll.CancelDataCollectionFinish(_id, _serial);
                    }
                }

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                gv_List.ThreadSafeCall(delegate { SetCellsColor(); });
            }
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            DataTable dataworkers = new DataTable();
            dataworkers.Columns.Add("id", typeof(int));

            DataTable dataworkerstmp = new DataTable();
            dataworkerstmp.Columns.Add("id", typeof(int));
            dataworkerstmp.Columns.Add("worker", typeof(string));

            DataTable dataworks = new DataTable();
            dataworks.Columns.Add("id", typeof(int));
            dataworks.Columns.Add("string", typeof(string));

            foreach (DataGridViewRow row in gv_List.SelectedRows)
            {
                if (Convert.ToInt32(row.Cells["cn_id"].Value) != 0
                    && Convert.ToInt32(row.Cells["cn_headid"].Value) == 0)
                {
                    //Work
                    DataRow dr = dataworks.NewRow();
                    dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                    dr["string"] = row.Cells["cn_sn"].Value.ToString();
                    dataworks.Rows.Add(dr);

                    DataRow dr1 = dataworkerstmp.NewRow();
                    dr1["id"] = Convert.ToInt32(row.Cells["cn_workerid"].Value);
                    dr1["worker"] = row.Cells["cn_worker"].Value.ToString();
                    dataworkerstmp.Rows.Add(dr1);

                }               
            }


            if (dataworks.Rows.Count == 0)
            {
                System.Media.SystemSounds.Exclamation.Play();
                frm_Error frm1 = new frm_Error();
                frm1.HeaderText = "Empty fields detected! Please check selected rows!";
                DialogResult result1 = frm1.ShowDialog();
            }
            else
            {
                frm_FinishShift frm = new frm_FinishShift();
                frm.HeaderText = "Finish work";
                foreach (DataRow row in dataworkerstmp.Rows)
                {
                    frm.gv_Workers.ThreadSafeCall(delegate { frm.AddWorkerToList(Convert.ToInt32(row["id"]), row["worker"].ToString()); });
                    //frm.WorkerMain = Worker;
                    //frm.WorkerIdMain = WorkerId;
                }


                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    dataworkers.Rows.Clear();

                    foreach (DataGridViewRow row in frm.gv_Workers.Rows)
                    {
                        DataRow dr = dataworkers.NewRow();
                        dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                        dataworkers.Rows.Add(dr);
                    }

                    DCBll.AddDataCollectionFinishOutdated(System.DateTime.Now.ToShortDateString(), frm.WorkTime, dataworkers, dataworks);


                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                    gv_List.ThreadSafeCall(delegate { SetCellsColor(); });
                }
            }
        }

        private void btn_ShowParameter_Click(object sender, EventArgs e)
        {
            string _batch = "";
            try { _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString(); }
            catch { }

            if (_batch != "")
            {
                var _query = "sp_SelectDataCollectionParams";

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@batch",SqlDbType.NVarChar) {Value = _batch}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Parameters : " + txt_Serial.Text;
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show();
            }
        }

        private void dn_Pages_Click(object sender, EventArgs e)
        {
            FillLabels();
        }

       
        private void gv_Repairs_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColorRepairs();
        }

    }
}
