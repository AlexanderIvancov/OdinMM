using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Planning.Controls
{
    public partial class ctl_RMNeeds : UserControl
    {
        public ctl_RMNeeds()
        {
            InitializeComponent();
        }

        #region Variables
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        private frm_Wait m_fmProgress = null;
        private const string processingCancelled = "Processing cancelled.";

        //private Form frm = this;

        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DLL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();

        public DataTable data;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int BatchId
        { get; set; }

        public int RetBatchId()
        {
            return BatchId;
        }

        int _articleid = 0;
        double _qtyfreeinpo = 0;

        public double QtyFreeInPO
        {
            get { return _qtyfreeinpo; }
            set { _qtyfreeinpo = value; }
        }

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                _articleid = value;
                ShowDets();
                //bwStart(bw_List);
                AvailableQty = DLL.AvailQty(cmb_Articles1.ArticleId);
                RecalcPOQty();
            }
        }
         
        public string Comments
        {
            get { return txt_comments.Text; }
            set { txt_comments.Text = value; }
        }
              
        public string Description
        {
            get { return txt_description.Text; }
            set { txt_description.Text = value; }
        }

        public double AvailableQty
        {
            get
            {
                try { return Convert.ToDouble(txt_Available.Text); }
                catch { return 0; }
            }
            set
            {
                txt_Available.Text = value.ToString();
            }
        }

        public double PurchasedQty
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyToPo.Text); }
                catch { return 0; }
            }
            set
            {
                txt_QtyToPo.Text = value.ToString();
            }
        }

        public void EnableSave(bool _istrue)
        {
            btn_Save.Enabled = _istrue == true;
        }

        int _mode = 0; //By default new order

        public int Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        #endregion

        #region Controls

        private void btn_AddAll_Click(object sender, EventArgs e)
        {
            if (Mode == 0)
                RecalcAllQty();
            else
                RecalcFIFOQty();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    row.Cells["cn_purchase"].Value = 0;
            //}
            foreach (DataRow row in data.Rows)
            {
                row["topurchase"] = 0;
            }
            RecalcPOQty();
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

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
            DLL.UserLogin = System.Environment.UserName;
            frm.UserId = DLL.UserId;

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

        #region Methods

        public void LoadColumns(DataGridView grid)
        {
            DLL.UserLogin = System.Environment.UserName;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectUserGridViewColumn", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@userid", DLL.UserId);
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

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            data = Plan_BLL.getNeedsRM(ArtId);

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
            //MessageBox.Show(cmb_Articles1.QtyAvail.ToString());

        }

        public void ShowDets()
        {

            data = Plan_BLL.getNeedsRM(ArtId);

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

        private void SetCellsColor()
        {
            try
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    //Color of freezed qty
                    if (Convert.ToDouble((row.Cells["cn_missed"].Value)) < 0)
                        row.Cells["cn_missed"].Style.ForeColor = Color.Red;
                }
            }
            catch
            { }
        }

        public void RecalcPOQty()
        {
            double Qty = 0;
            double Qty1 = 0;


            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                try
                {
                    Qty1 = Math.Round(Convert.ToDouble(row.Cells["cn_purchase"].Value), 5);
                    Qty = Math.Round(Qty + Qty1, 5);
                }
                catch
                { }
            }

            PurchasedQty = Math.Round(Qty, 5);
        }

        public void RecalcAllQty()
        {
            //Clear
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    row.Cells["cn_purchase"].Value = row.Cells["cn_missed"].Value;
            //}
            foreach (DataRow row in data.Rows)
            {
                row["topurchase"] = row["missed"];
            }
            RecalcPOQty();
        }

        public void RecalcFIFOQty()
        {
            double _QtyDistr = QtyFreeInPO;
            ////Clear
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    row.Cells["cn_purchase"].Value = 0;
            //}
            ////Clear
            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToDouble(row.Cells["cn_missed"].Value) > 0
            //                && _QtyDistr > 0)
            //    {
            //        if (Convert.ToDouble(row.Cells["cn_missed"].Value) > _QtyDistr)
            //        {
            //            row.Cells["cn_purchase"].Value = _QtyDistr;
            //            _QtyDistr = 0;
            //            break;
            //        }
            //        else
            //        {
            //            row.Cells["cn_purchase"].Value = Convert.ToDouble(row.Cells["cn_missed"].Value);
            //            _QtyDistr = _QtyDistr - Convert.ToDouble(row.Cells["cn_missed"].Value);
            //        }
            //    }
            //}
            //Clear
            foreach (DataRow row in data.Rows)
            {
                row["topurchase"] = 0;
            }
            //Clear
            foreach (DataRow row in data.Rows)
            {
                if (Convert.ToDouble(row["missed"]) > 0
                            && _QtyDistr > 0)
                {
                    if (Convert.ToDouble(row["missed"]) > _QtyDistr)
                    {
                        row["topurchase"] = _QtyDistr;
                        _QtyDistr = 0;
                        break;
                    }
                    else
                    {
                        row["topurchase"] = Convert.ToDouble(row["missed"]);
                        _QtyDistr = _QtyDistr - Convert.ToDouble(row["missed"]);
                    }
                }
            }

            RecalcPOQty();
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["chk_add"].Selected == true)
            {
                gv_List.EndEdit();

                gv_List.CurrentRow.Cells["cn_purchase"].Value = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_add"].Value) == -1
                    ? Convert.ToDouble(gv_List.CurrentRow.Cells["cn_missed"].Value)
                    : (object)0;

                bs_List.ResetBindings(true);

                RecalcPOQty();
            }
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            bool _test = true;
            gv_List.EndEdit();
            if (gv_List.CurrentRow.Cells["cn_purchase"].Selected == true)
            {
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_purchase"].Value) < 0)
                    gv_List.CurrentRow.Cells["cn_purchase"].Value = 0;
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_purchase"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_missed"].Value))
                {
                    
                    DialogResult result = KryptonTaskDialog.Show("Quaninty comparison!",
                                                                     "Are you want to save changes?",
                                                                     "Missed quantity is less than you want to purchase! Are you sure?",
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.Yes |
                                                                     TaskDialogButtons.No);
                    _test = result != DialogResult.Yes;
                    if (_test == true)
                        gv_List.CurrentRow.Cells["cn_purchase"].Value = gv_List.CurrentRow.Cells["cn_missed"].Value;
                }
                
                RecalcPOQty();
            }
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
            Comments = cmb_Articles1.Comments;
            Description = cmb_Articles1.Description;
        }

        public double SumMissedQty()
        {
            double Qty = 0;
            double Qty1 = 0;


            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                try
                {
                    Qty1 = Math.Round(Convert.ToDouble(row.Cells["cn_missed"].Value), 5);
                    Qty = Math.Round(Qty + Qty1, 5);
                }
                catch
                { }
            }

            return Qty;
        }


        #endregion

        private void ctl_RMNeeds_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }
    }
}
