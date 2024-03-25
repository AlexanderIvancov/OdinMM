﻿using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public partial class frm_Workers : KryptonForm
    {
        public frm_Workers()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "WorkersList.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        Tools_BLL Bll = new Tools_BLL();
        CMB_BLL Bllc = new CMB_BLL();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int _PrevId = 0;

        public int WorkerId
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public void FillList()
        {
            var data = (DataTable)Helper.getSP("sp_WorkersList");

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

        private bool CheckOldRow()
        {

            try
            {
                WorkerId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                WorkerId = 0;
            }

            if (_PrevId == WorkerId)
            {
                return true;
            }
            else
            {
                _PrevId = WorkerId;
                return false;
            }
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
            }
        }


        #endregion

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
            SetCellsColor();


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
            SetCellsColor();

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

            frm.HeaderText = "Select view for confirmation orders list";
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

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }


        #endregion

        #region Controls

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddWorker frm = new frm_AddWorker();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                int _res = Convert.ToInt32(Helper.getSP("sp_SaveWorker", 0, frm.UserName, frm.UserSurName, frm.UserTabNR, frm.IsActive, frm.RFID, frm.Comments, frm.IsMaster));
                FillList();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _name = "";
            string _surname = "";
            string _rfid = "";
            string _tabnum = "";
            string _comments = "";
            int _isactive = 0;
            int _ismaster = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _isactive = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_isactive"].Value);
                _name = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                _surname = gv_List.CurrentRow.Cells["cn_surname"].Value.ToString();
                _tabnum = gv_List.CurrentRow.Cells["cn_tabnr"].Value.ToString();
                _rfid = gv_List.CurrentRow.Cells["cn_rfid"].Value.ToString();
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _ismaster = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_ismaster"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddWorker frm = new frm_AddWorker();
                frm.UserName = _name;
                frm.UserSurName = _surname;
                frm.UserTabNR = _tabnum;
                frm.RFID = _rfid;
                frm.IsActive = _isactive;
                frm.Comments = _comments;
                frm.IsMaster = _ismaster;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int _res = Convert.ToInt32(Helper.getSP("sp_SaveWorker", _id, frm.UserName, frm.UserSurName, frm.UserTabNR, frm.IsActive, frm.RFID, frm.Comments, frm.IsMaster));
                    FillList();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
               
            }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                glob_Class.ShowMessage("Workers deletion result:", "", Convert.ToString(Helper.getSP("sp_DeleteWorker", _id)));
                FillList();
            }
        }

        #endregion

        private void frm_Workers_Load(object sender, EventArgs e)
        {
            FillList();
            Helper.LoadColumns(gv_List, this.Name);
        }

        private void frm_Workers_Activated(object sender, EventArgs e)
        {

        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
