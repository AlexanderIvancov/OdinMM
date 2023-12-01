using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Finances
{
    public partial class frm_CheckAccounts : KryptonForm
    {
        public frm_CheckAccounts()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
            //ED = new ExportData(this.gv_List, "CheckAccount" + AccountId + ".xls");
        }

        ProgressForm wait;

        #region Variables

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int AccountId
        {
            get
            {
                if (rb_PF.Checked == true)
                    return 2120;
                else if (rb_RM.Checked == true)
                    return 2110;
                else
                    return 2130;
            }
        }

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

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }

            try
            {
                var data = Finances_BLL.getCheckAccounts(txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim(),
                                                                   txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim(),
                                                                   AccountId);

                gv_List.ThreadSafeCall(delegate
                {
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);



                    gv_List.AutoGenerateColumns = false;
                    bs_List.DataSource = data;
                    gv_List.DataSource = bs_List;

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                });


                bn_List.ThreadSafeCall(delegate
                {
                    bn_List.BindingSource = bs_List;
                });
            }
            catch { }
        }

        #endregion

        private void frm_CheckAccounts_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            txt_DateFrom.Value = System.DateTime.Now;
            txt_DateTill.Value = System.DateTime.Now;
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
            bwStart(bw_List);
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

            frm.HeaderText = "Select view for deliveries list";
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
            ED = new ExportData(this.gv_List, "CheckAccount" + AccountId + ".xls", this.Name);

            ED.DgvIntoExcel();
        }

        #endregion

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _headid = 0;
            try { _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value); }
            catch { }

            string _typedoc = "";

            if (_headid != 0)
            {
                var _query = "";
                if (AccountId == 2110
                    && gv_List.CurrentRow.Cells["cn_outcome"].Selected == true)
                {
                    _typedoc = "Outcome ";
                    _query = "sp_CheckDifference2110OutDets";
                }
                else if (AccountId == 2120
                    && gv_List.CurrentRow.Cells["cn_outcome"].Selected == true)
                {
                    _typedoc = "Outcome ";
                    _query = "sp_CheckDifference2120OutDets";
                }
                else if (AccountId == 2120
                && gv_List.CurrentRow.Cells["cn_income"].Selected == true)
                {
                    _typedoc = "Income ";
                    _query = "sp_CheckDifference2120InDets";
                }
                else
                    _query = "";

                if (_query != "")
                {
                    var sqlparams = new List<SqlParameter>
                {
                new SqlParameter("@headid",SqlDbType.NVarChar){Value = _headid},
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = txt_DateFrom.Value == null ? "" : txt_DateFrom.Value.ToString().Trim()},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = txt_DateTill.Value == null ? "" : txt_DateTill.Value.ToString().Trim()}
                };

                    Template_DataGridView frm = new Template_DataGridView();

                    frm.Text = _typedoc + "details for: " + gv_List.CurrentRow.Cells["cn_document"].Value.ToString();
                    frm.Query = _query;
                    frm.SqlParams = sqlparams;
                    frm.Show();
                }

            }
        }
    }
}
