using Odin.Global_Classes;
using Odin.Planning;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Purchase
{
    public partial class ctl_AddFromNeeds : UserControl
    {
        public ctl_AddFromNeeds()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "NeedsList.xls", this.Name);
        }

        #region Variables
        private frm_Wait m_fmProgress = null;
        private const string processingCancelled = "Processing cancelled.";

        //private Form frm = this;

        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DLL = new DAL_Functions();
        ExportData ED;


        int _deptid = 0;
        int _stageid = 0;

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public int TypeId
        {
            get { return cmb_Types1.TypeId; }
            set { cmb_Types1.TypeId = value; }
        }

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

        public int POHeadId
        { get; set; }

        public int ArtId
        { get; set; }

        public int _PrevId = 0;

        double _qtyfreepo = 0;

        public double QtyFreePO
        {
            get { return _qtyfreepo; }
            set { _qtyfreepo = value; }
        }

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        #endregion

        #region Methods

        public void RefreshData()
        {
            bwStart(bw_List);

            try
            {
                ArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch
            {
                ArtId = 0;
            }

            ShowDetails(ArtId);
            gv_List.ThreadSafeCall(delegate
            { SetCellsColor(); });
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

            var data = Plan_BLL.getArtTotalsListRM(TypeId, DeptId, BatchId, StageId);

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

        private bool CheckOldRow()
        {

            try
            {
                ArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch
            {
                ArtId = 0;
            }

            if (_PrevId == ArtId)
            {
                return true;
            }
            else
            {
                _PrevId = ArtId;
                return false;
            }
        }

        public void ShowDetails(int _artid)
        {

            try { QtyFreePO = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_freepo"].Value); }
            catch { QtyFreePO = 0; }

            ctl_RMNeeds1.ThreadSafeCall(delegate { ctl_RMNeeds1.cmb_Articles1.ArticleId = _artid; });

        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Gainsboro;
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
        #endregion
        private void cmb_Batches1_BatchChanged(object sender)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }


        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(ArtId);
            }
            SetCellsColor();
        }

        #endregion

        private void ctl_AddFromNeeds_Load(object sender, EventArgs e)
        {
            this.kryptonLabel1.Location = new System.Drawing.Point(33, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(42, 13);
            this.kryptonLabel1.TabIndex = 50;
            this.kryptonLabel1.Values.Text = "Batch:";

            this.kryptonLabel2.Location = new System.Drawing.Point(266, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(266, 13);
            this.kryptonLabel2.TabIndex = 52;
            this.kryptonLabel2.Values.Text = "Type:";
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
