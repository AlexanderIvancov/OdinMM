﻿using System;
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
using Odin.Planning.Passport;

namespace Odin.Planning
{
    public partial class frm_SerialNumbers : BaseForm
    {
        public frm_SerialNumbers()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "SerialNumbersList.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

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

        // rb_All.Checked == true ? 1 : (rb_Valid.Checked == true ? -1 : 0)


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
            txt_Serial.Text = "0";
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;

            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;

            txt_UseFrom.Value = null;
            txt_UseTill.Value = null;
            txt_UseFrom.Value = null;
            txt_UseTill.Value = null;
            rb_All.Checked = true;
        }

        public void SetCellsColor()
        {
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_complected"].Value) != 0)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.FromArgb(192, 255, 192);
            //    if (Convert.ToInt32(row.Cells["chk_isactive"].Value) == 0)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.Gainsboro;

            //}
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(cmb_SalesOrdersWithLines1.SalesOrderLineId.ToString());
            var data = Plan_BLL.getSerialNumbers(Convert.ToInt32(txt_Serial.Text), rb_All.Checked == true ? 1 : (rb_Used.Checked == true ? -1 : 0), 
                                            cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, IsActive,
                                            cmb_Types1.TypeId, txt_UseFrom.Value == null ? "" : txt_UseFrom.Value.ToString().Trim(),
                                            txt_UseTill.Value == null ? "" : txt_UseTill.Value.ToString().Trim());


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

        public void RefreshData(object sender)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;

            var dir = Helper.SaveDirection(gv_List);

            var data = Plan_BLL.getSerialNumbers(Convert.ToInt32(txt_Serial.Text), rb_All.Checked == true ? 1 : (rb_Used.Checked == true ? -1 : 0),
                                             cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, cmb_Articles1.ArticleId, IsActive,
                                             cmb_Types1.TypeId, txt_UseFrom.Value == null ? "" : txt_UseFrom.Value.ToString().Trim(),
                                             txt_UseTill.Value == null ? "" : txt_UseTill.Value.ToString().Trim());


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        #endregion

        #region Controls

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
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

            frm.HeaderText = "Select view for serial numbers list";
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
        
        private void frm_SerialNumbers_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);


            LoadColumns(gv_List);

            ClearFilter();
        }

        private void frm_SerialNumbers_Resize(object sender, EventArgs e)
        {
            if (_frm_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    //ctl_BatchOrders ctlBatchCO1 = (ctl_BatchOrders)page.Controls.Find("ctl_BatchOrders", true).FirstOrDefault();
                    //if (ctlBatchCO1 != null)
                    //{
                    //    //ctlBatchCO1 = new ctl_BatchOrders();
                    //    ControlWidth = ctlBatchOrdersWidth;
                    //}
                    //ctl_BatchFreeze ctlFreeze1 = (ctl_BatchFreeze)page.Controls.Find("ctl_BatchFreeze", true).FirstOrDefault();
                    //if (ctlFreeze1 != null)
                    //{
                    //    //ctlFreeze1 = new ctl_BatchFreeze();
                    //    ControlWidth = ctlBatchRMWidth;//ctlFreeze1.Width;
                    //}

                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });
                }
            }
        }


        #endregion

        private void txt_UseFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_UseFrom.Value = txt_UseFrom.Value == null ? System.DateTime.Now : txt_UseFrom.Value;
        }

        private void txt_UseTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_UseTill.Value = txt_UseTill.Value == null ? System.DateTime.Now : txt_UseTill.Value;
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddSerialNumbers frm = new frm_AddSerialNumbers();
            frm.BatchId = cmb_Batches1.BatchId;
            frm.SendChanges += new SendSerialNumChangesEventHadler(RefreshData);

            frm.Show();
        }
        
        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            if (glob_Class.DeleteConfirm() == true)
            {
                try
                {
                    foreach (DataGridViewRow row in this.gv_List.SelectedRows)
                    {
                        _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                        PlanBll.DeleteSerialNumber(_id);
                    }
                }
                catch { }
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
            }
        }
    }
}
