using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.Purchase
{
    public delegate void NeedsAddingEventHandler(object sender);
    public partial class frm_AddNeedsProcessing : KryptonForm
    {
        public frm_AddNeedsProcessing()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "NeedsList.xls", this.Name);
        }

        public event NeedsAddingEventHandler NeedsAdded;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        private frm_Wait m_fmProgress = null;
        private const string processingCancelled = "Processing cancelled.";

        class_Global glob_Class = new class_Global();
        PO_BLL BLL = new PO_BLL();
        DAL_Functions DAL = new DAL_Functions();
        ExportData ED;
        AdmMenu mMenu = new AdmMenu();

        int _deptid = 0;
        int _stageid = 0;
        //public int BatchId
        //{
        //    get { return cmb_Batches1.BatchId; }
        //    set { cmb_Batches1.BatchId = value; }
        //}

        //public int TypeId
        //{
        //    get { return cmb_Types1.TypeId; }
        //    set { cmb_Types1.TypeId = value; }
        //}
        public int DeptId
        {
            get { return _deptid; }
            set { _deptid = value; }
        }
        public int StageId
        {
            get { return _stageid; }
            set { _stageid = value; }
        }
        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int RowIndexB = 0;
        public int ColumnIndexB = 0;
        public string ColumnNameB = "";
        public string CellValueB = "";

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            gv_Batches.EndEdit();
            //bs_List.Clear();

            DataTable databatches = new DataTable();
            databatches.Columns.Add("id", typeof(int));


            foreach (DataGridViewRow row in this.gv_Batches.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_toaddb"].Value) != 0)
                {
                    DataRow drser = databatches.NewRow();
                    drser["id"] = Convert.ToInt32(row.Cells["cn_batchid"].Value.ToString());
                    databatches.Rows.Add(drser);
                }
            }

            var data = (DataTable)Helper.getSP("sp_SelectArtTotalsListForAddingBatches", databatches, StageId);

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

        public void FillBatches()
        {
            var data = (DataTable)Helper.getSP("sp_SelectActiveBatches");

            gv_Batches.ThreadSafeCall(delegate
            {
                gv_Batches.AutoGenerateColumns = false;
                bs_Batches.DataSource = data;
                gv_Batches.DataSource = bs_Batches;
            });

            bn_Batches.ThreadSafeCall(delegate
            {
                bn_Batches.BindingSource = bs_Batches;
            });
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
        }

        public void bwStart(DoWorkEventHandler doWork)
        {

            // Create a background thread
            var bw = new BackgroundWorker();
            bw.DoWork += doWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            // Create a progress form on the UI thread
            m_fmProgress = new frm_Wait();
            m_fmProgress.Start();
            // Kick off the Async thread
            bw.RunWorkerAsync();

            // Lock up the UI with this modal progress form.
            m_fmProgress.ShowDialog();
            m_fmProgress = null;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide the Progress Form
            if (m_fmProgress != null)
            {
                m_fmProgress.Stop();
                m_fmProgress.Close();
                m_fmProgress = null;
            }

            // Check to see if an error occured in the 
            // background process.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                return;
            }

            // Check to see if the background process was cancelled.
            if (e.Cancelled)
            {
                MessageBox.Show(processingCancelled);
                return;
            }
        }

        public void LoadColumns(DataGridView grid)
        {
            DAL.UserLogin = Environment.UserName;

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
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            //SetCellsColor();
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
            //SetCellsColor();
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
            //SetCellsColor();
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            //SetCellsColor();
        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for needs details list";
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

        #region Context menu Batches

        private void mnu_LinesB_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Batches.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Batches.HitTest(mpoint.X, mpoint.Y);

                RowIndexB = info.RowIndex;
                ColumnIndexB = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Batches.ClearSelection();
                gv_Batches.Rows[RowIndexB].Cells[ColumnIndexB].Selected = true;
                gv_Batches.CurrentCell = gv_Batches.Rows[RowIndexB].Cells[ColumnIndexB];

                CellValueB = gv_Batches.Rows[RowIndexB].Cells[ColumnIndexB].Value.ToString();
                ColumnNameB = gv_Batches.Columns[ColumnIndexB].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));
            }
            catch
            {
                RowIndexB = 0;
                ColumnIndexB = 0;
                return;
            }
        }

        private void mni_FilterForB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_Batches.Filter = ("Convert(" + ColumnNameB + " , 'System.String') like '%" + mni_FilterForB.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            //SetCellsColor();
        }

        private void mni_SearchB_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Batches;
            frm.ColumnNumber = gv_Batches.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Batches.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterByB_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Batches.Filter = String.IsNullOrEmpty(bs_Batches.Filter) == true
                    ? String.IsNullOrEmpty(CellValueB) == true
                        ? "(" + ColumnNameB + " is null OR Convert(" + ColumnNameB + ", 'System.String') = '')"
                        : "Convert(" + ColumnNameB + " , 'System.String') = '" + glob_Class.NES(CellValueB) + "'"
                    : String.IsNullOrEmpty(CellValueB) == true
                        ? bs_Batches.Filter + "AND (" + ColumnNameB + " is null OR Convert(" + ColumnNameB + ", 'System.String') = '')"
                        : bs_Batches.Filter + " AND Convert(" + ColumnNameB + " , 'System.String') = '" + glob_Class.NES(CellValueB) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            //SetCellsColor();
        }

        private void mni_FilterExcludingSelB_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Batches.Filter = String.IsNullOrEmpty(bs_Batches.Filter) == true
                    ? "Convert(" + ColumnNameB + " , 'System.String') <> '" + CellValueB + "'"
                    : bs_Batches.Filter + " AND " + ColumnNameB + " <> '" + CellValueB + "'";
            }
            catch { }
            //SetCellsColor();
        }

        private void mni_RemoveFilterB_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Batches.RemoveFilter();
            }
            catch { }
            //SetCellsColor();
        }

        private void mni_CopyB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueB.ToString());
        }

        private void mni_AdminB_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for batches list";
            frm.grid = this.gv_Batches;
            frm.formname = this.Name;
            DAL.UserLogin = Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Batches);
            }
        }

        #endregion

        private void frm_AddNeedsProcessing_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            LoadColumns(gv_Batches);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            gv_Batches.EndEdit();
            
            int _count = 0;
            foreach (DataGridViewRow row in this.gv_List.Rows)
                if (Convert.ToInt32(row.Cells["chk_toadd"].Value) != 0)
                    _count++;
            if (_count > 0)
            {
                DataTable databatches = new DataTable();
                databatches.Columns.Add("id", typeof(int));
                

                foreach (DataGridViewRow row in this.gv_Batches.Rows)
                    if (Convert.ToInt32(row.Cells["chk_toaddb"].Value) != 0)
                    {
                        DataRow drser = databatches.NewRow();
                        drser["id"] = Convert.ToInt32(row.Cells["cn_batchid"].Value.ToString());
                        databatches.Rows.Add(drser);
                    }

                DataTable data = new DataTable();
                data.Columns.Add("artid", typeof(int));
                data.Columns.Add("qty", typeof(double));

                foreach (DataGridViewRow row in this.gv_List.Rows)
                    if (Convert.ToInt32(row.Cells["chk_toadd"].Value) != 0)
                    {
                        DataRow drser = data.NewRow();
                        drser["artid"] = Convert.ToInt32(row.Cells["cn_artid"].Value.ToString());
                        drser["qty"] = -1 * Convert.ToDouble(row.Cells["cn_missed"].Value.ToString()); 
                        data.Rows.Add(drser);
                    }

                Helper.getSP("sp_AddPONeedsForProcessBatches", txt_Comments.Text, databatches, data);
                
                bwStart(bw_List);

                NeedsAdded?.Invoke(this);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}