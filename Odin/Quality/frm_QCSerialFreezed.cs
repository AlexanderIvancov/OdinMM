using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.AddSerialFreezed;
using Odin.Global_Classes;
using Odin.Planning;
using Odin.Tools;
using Odin.Workshop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Quality
{
    public partial class frm_QCSerialFreezed : KryptonForm
    {
        public frm_QCSerialFreezed()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "QCSerialFreezed.xls", this.Name);
        }

        #region variables

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
        Processing_BLL ProdBll = new Processing_BLL();

        int _batchid = 0;
        bool _showingModal = false;
        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
        public int BatchId
        {
            get { return _batchid; }
            set
            {
                _batchid = value;

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                FillQCSerialFreezed(_batchid);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        #endregion

        #region Methods

        public void FillQCSerialFreezed(int BatchId)
        {
            var data = Processing_BLL.getQCSerialFreezed(BatchId, txt_Serial.Text);

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
                    foreach (DataGridViewColumn column in grid.Columns)
                        if (column.Name == reader["columnname"].ToString())
                        {
                            column.DisplayIndex = Convert.ToInt32(reader["columnorder"]);
                            column.HeaderText = reader["columntext"].ToString();
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                reader.Close();
            }

            sqlConn.Close();
        }

        #endregion

        #region Controls

        private void frm_QCSerialFreezed_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            BatchId = cmb_Batches1.BatchId;
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

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            FillQCSerialFreezed(BatchId);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) { }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddSerialFreezed frm = new frm_AddSerialFreezed();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                ProdBll.AddSerialFreezed(frm.StageId, frm.BatchId, frm.Serial, frm.Position, frm.FreezedReasonId);
                FillQCSerialFreezed(frm.BatchId);
            }
            if (result == DialogResult.Cancel)
                _showingModal = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_AddSerialFreezed frm = new frm_AddSerialFreezed();

                frm.StageId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value.ToString());
                frm.BatchId = BatchId;
                frm.Serial = gv_List.CurrentRow.Cells["cn_serial"].Value.ToString();
                frm.Position = gv_List.CurrentRow.Cells["cn_placement"].Value.ToString();
                frm.FreezedReasonId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_reasonid"].Value.ToString());

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    ProdBll.EditSerialFreezed(_id, frm.StageId, frm.BatchId, frm.Serial, frm.Position, frm.FreezedReasonId);
                    FillQCSerialFreezed(frm.BatchId);
                }
                if (result == DialogResult.Cancel)
                    _showingModal = false;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true)
            {
                ProdBll.DeleteSerialFreezed(_id);
                FillQCSerialFreezed(0);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Serial.Text != string.Empty)
            {
                var _query = "sp_SelectQCSerialFreezed";
                DAL_Functions df = new DAL_Functions();

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@batchid",SqlDbType.Int) {Value = BatchId},
                    new SqlParameter("@lang",SqlDbType.NVarChar) {Value = df.UserLang},
                    new SqlParameter("@serial",SqlDbType.NVarChar) {Value = txt_Serial.Text}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Freezed for serial: " + txt_Serial.Text;
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Serial.Text = string.Empty;
        }
    }
}