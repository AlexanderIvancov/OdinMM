﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.Warehouse.StockOut
{
    public partial class frm_ImmidiateConsumption : KryptonForm
    {
        public frm_ImmidiateConsumption()
        {
            InitializeComponent();
           
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        Helper MyHelper = new Helper();
        StockOut_BLL BLL = new StockOut_BLL();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int ReasonId
        {
            get
            {
                try { return Convert.ToInt32(cmb_Reason.SelectedValue); }
                catch { return 0; }
            }
            set { cmb_Reason.SelectedValue = value; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
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

        public void FillList()
        {
            var data = StockOut_BLL.getStockOutProceedInDocDets(cmb_IncomeDoc1.IncomeDocId);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

         
                try
                {
                    //RecalcTotals();
                    //RecalcUnitPrice(SellCoef);
                }
                catch { }
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        private void frm_ImmidiateConsumption_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            BindReasons();
        }

        public void SetCellsColor()
        {

        }

        public void BindReasons()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT code, description FROM sto_reasoncodes where lang = 'RUS' and isactive = -1", sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            cmb_Reason.DataSource = dt;
            cmb_Reason.DisplayMember = "description";
            cmb_Reason.ValueMember = "code";

            cmb_Reason.SelectedValue = 0;
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

            frm.HeaderText = "Select view for payment list";
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
            ED = new ExportData(this.gv_List, cmb_IncomeDoc1.IncomeDoc + ".xls", this.Name);
            ED.DgvIntoExcel();
        }

        #endregion

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["chk_toadd"].Selected == true)
            {
                gv_List.EndEdit();

                if (Convert.ToInt32(gv_List.CurrentRow.Cells["chk_toadd"].Value) == 0)
                    gv_List.CurrentRow.Cells["cn_togive"].Value = 0;
                else
                    gv_List.CurrentRow.Cells["cn_togive"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_rest"].Value);
            }
        }

        private void cmb_IncomeDoc1_IncomeDocChanged(object sender)
        {
            FillList();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            int _resout = 0;
            int _count = 0;
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_togive"].Value) > 0)
                    _count++;

            }
            if (_count > 0
                && ReasonId != 0)
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (Convert.ToDouble(row.Cells["cn_togive"].Value) > 0)
                    {
                        _resout = BLL.AddStockOutLineSimple(_resout,
                                                                Convert.ToInt32(row.Cells["cn_id"].Value),
                                                                Convert.ToInt32(row.Cells["cn_label"].Value),
                                                                Convert.ToDouble(row.Cells["cn_togive"].Value),
                                                                Convert.ToInt32(row.Cells["cn_artid"].Value),
                                                                ReasonId, txt_Comments.Text);
                    }



                }

                glob_Class.ShowMessage("Document added", "", "Document: " + BLL.OutcomeDocResult + " was created!");
                FillList();
            }
            else
                glob_Class.ShowMessage("Empty fields warning", "Please check empty field", "Some felds are empty!");

        }
    }
}