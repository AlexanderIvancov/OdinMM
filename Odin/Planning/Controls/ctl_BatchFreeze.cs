using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Planning.Controls
{
    public delegate void RMIdSendingEventHandler(int artid, bool general, bool batchrm, bool artrm, bool totalart, bool poreservation);

    public partial class ctl_BatchFreeze : UserControl
    {

        public ctl_BatchFreeze()
        {
            InitializeComponent();
            //frm_Batches.ReceiveRMArtId += new ReceiveRMId(RetArtId);
            ED = new ExportData(this.gv_List, "BatchBOM.xls", this.Name);
        }

        #region Variables

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public event RMIdSendingEventHandler SendArtId;

        ProgressForm wait;
        frm_Batches frmBatches;
        ExportData ED;
        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();

        public double pro
        { get; set; }


        public void bwStart(DoWorkEventHandler doWork)
        {
            wait = new ProgressForm(frmBatches);

            wait.bwStart(doWork);
        }

        int _batchid = 0;

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set {
                //MessageBox.Show(_batchid.ToString());
                _batchid = value;

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
                SetCellsColor();
            }
        }

        public int igvArtId
        {
            get;
            set;
        }
        public int OldigvArtId
        {
            get;
            set;
        }

        public int RetArtId()
        {
            return igvArtId;
        }

        #endregion

        #region Methods

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            try
            {
                var data = Plan_BLL.getBatchRM(BatchId);

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
            catch { }
        }


        public void ShowDets()
        {
            try
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                
                var data = Plan_BLL.getBatchRM(BatchId);

                gv_List.ThreadSafeCall(delegate
                {
                    gv_List.AutoGenerateColumns = false;
                    bs_List.DataSource = data;
                    gv_List.DataSource = bs_List;
                    SetCellsColor();
                });
                
                Helper.RestoreDirection(gv_List, oldColumn, dir);
                SetCellsColor();

                bn_List.ThreadSafeCall(delegate
                {
                    bn_List.BindingSource = bs_List;
                });
            }
            catch { }
        }

        public void SetCellsColor()
        {
            double ToFreeze = 0;
            try
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    //Color of freezed qty
                    row.Cells["cn_reserve"].Style.ForeColor = Convert.ToDouble((row.Cells["cn_reserve"].Value)) < 0
                        ? Color.Blue
                        : Convert.ToDouble((row.Cells["cn_reserve"].Value)) > 0 ? Color.Green : Color.Black;

                    ToFreeze = Convert.ToDouble(row.Cells["cn_qty"].Value)
                                - Convert.ToDouble(row.Cells["cn_reserved"].Value)
                                //- Convert.ToDouble(row.Cells["cn_requested"].Value)
                                - Convert.ToDouble(row.Cells["cn_given"].Value)
                                + Convert.ToDouble(row.Cells["cn_returned"].Value);
                    //Color of available qty
                    if (Convert.ToDouble(row.Cells["cn_missed"].Value) > 0)//(Convert.ToDouble(row.Cells["cn_available"].Value) < ToFreeze)
                    {
                        row.Cells["cn_article"].Style.Font = new Font(this.Font, FontStyle.Bold);
                        row.Cells["cn_article"].Style.ForeColor = Color.Red;
                    }

                    if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) == 0
                        && Convert.ToDouble(row.Cells["cn_qty"].Value) > 0)
                    {
                        //green
                        row.Cells["cn_nomenclature"].Style.BackColor = Color.LightGreen;
                    }
                    else if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) > 0
                        && Convert.ToDouble(row.Cells["cn_qty"].Value) == 0)
                    {
                        //red
                        row.Cells["cn_nomenclature"].Style.BackColor = Color.LightPink;
                    }
                    else if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) >
                       Math.Round(Convert.ToDouble(row.Cells["cn_qty"].Value), 3))
                    {
                        row.Cells["cn_nomenclature"].Style.Font = new Font(this.Font, FontStyle.Bold);
                        row.Cells["cn_nomenclature"].Style.ForeColor = Color.Red;
                    }
                    else { }
                    //if (Convert.ToDouble((row.Cells["cn_TheorRest"].Value)) < 0)
                    //{
                    //    row.Cells["cn_TheorRest"].Style.Font = new Font(this.Font, FontStyle.Bold);
                    //    row.Cells["cn_TheorRest"].Style.ForeColor = Color.Red;
                    //}
                    if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.Gainsboro;
                }
            }
            catch
            { }
        }

        public void SetDefaultQty()
        {
            gv_List.EndEdit();
            double ToFreeze = 0;
            try
            {
                foreach (DataGridViewRow row in gv_List.Rows)
                {
                    ToFreeze = Convert.ToDouble(row.Cells["cn_qty"].Value)
                                    - Convert.ToDouble(row.Cells["cn_reserved"].Value)
                                    //- Convert.ToDouble(row.Cells["cn_requested"].Value)
                                    - Convert.ToDouble(row.Cells["cn_given"].Value)
                                    + Convert.ToDouble(row.Cells["cn_returned"].Value);


                    row.Cells["cn_reserve"].Value = ToFreeze > 0
                        && Convert.ToInt32(row.Cells["cn_detisactive"].Value) == -1
                        ? Convert.ToDouble(row.Cells["cn_available"].Value) >= ToFreeze
                            ? Math.Round(ToFreeze, 5)
                            : (object)Math.Round(Convert.ToDouble(row.Cells["cn_available"].Value), 5)
                        : 0;
                }
            }
            catch { }
            SetCellsColor();
        }

        public void SendArticle(int artid)
        {
            //Event
            SendArtId?.Invoke(artid, false, false, true, true, true);
        }

        private bool CheckOldRow()
        {

            try
            {
                igvArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch
            {
                igvArtId = 0;
            }

            if (OldigvArtId == igvArtId)
            {
                return true;
            }
            else
            {
                OldigvArtId = igvArtId;
                return false;
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

        private void cmb_Batches1_BatchChanged(object sender)
        {
            BatchId = cmb_Batches1.BatchId;
        }

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 10)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.bindingNavigatorAddNewItem_Image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex ==8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorDeleteItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorDeleteItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.bindingNavigatorDeleteItem_Image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
               
        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["cn_reserve"].Selected == true)
            {
                //double k;
                //bool outres = Double.TryParse(gv_List.CurrentRow.Cells["cn_reserve"].Value.ToString(), out k);
                //if (!outres)
                //{
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) < 0)
                    {
                        //proverka osvobozhdenija
                        if (-1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value))
                            gv_List.CurrentRow.Cells["cn_reserve"].Value = -1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value);
                    }
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) > 0)
                    {
                        if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_available"].Value))
                            gv_List.CurrentRow.Cells["cn_reserve"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_available"].Value);
                    }
                //}
                //else
               // {
                //    gv_List.CurrentRow.Cells["cn_reserve"].Value = 0;
                //}              
            }
            SetCellsColor();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                pro = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value);

                if (gv_List.CurrentRow.Cells["btn_free"].Selected == true
                    && gv_List.SelectedRows.Count == 0)
                {
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value) > 0)
                    {
                        //osvobozhdaem esli est' zamorozhennoe
                        gv_List.CurrentRow.Cells["cn_reserve"].Value = -1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value);
                    }

                }
                else if (gv_List.CurrentRow.Cells["btn_freeze"].Selected == true
                    && gv_List.SelectedRows.Count == 0)
                {


                    double ToFreeze = 0;
                    ToFreeze = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value)
                                - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value)
                                //- Convert.ToDouble(gv_List.CurrentRow.Cells["cn_requested"].Value)
                                - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_given"].Value)
                                + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_returned"].Value);


                    gv_List.CurrentRow.Cells["cn_reserve"].Value = ToFreeze > 0
                        ? Convert.ToDouble(gv_List.CurrentRow.Cells["cn_available"].Value) >= ToFreeze
                            ? ToFreeze
                            : (object)Convert.ToDouble(gv_List.CurrentRow.Cells["cn_available"].Value)
                        : 0;

                }
            }
            catch { }

            //bs_List.ResetBindings(true);

            SetCellsColor();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void ctl_BatchFreeze_Paint(object sender, PaintEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_reserve"].Value = 0;
            }
            SetCellsColor();
        }
        

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddBatchRMLine frm = new frm_AddBatchRMLine();
            frm.Id = 0;
            frm.HeaderText = "Add new RM for batch: " + cmb_Batches1.Batch;
            DialogResult result = frm.ShowDialog();


            if (result == DialogResult.OK)
            {
                if (frm.SubBatch == 0)
                {
                    BLL.AddBatchDetail(BatchId, frm.ArtId, frm.Qty, frm.Comments);
                }
                else
                {
                    BLL.AddBatchDetailSB(BatchId, frm.ArtId, frm.Qty);
                }
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
                SetCellsColor();
                //SetDefaultQty();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _bdid = 0;
            try
            {
                _bdid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_bdid == 0)
            {

                frm_AddBatchRMLine frm = new frm_AddBatchRMLine();
                frm.Id = 0;
                frm.ArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                frm.HeaderText = "Add new RM for batch: " + cmb_Batches1.Batch;
                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    if (frm.SubBatch == 0)
                    {
                        BLL.AddBatchDetail(BatchId, frm.ArtId, frm.Qty, frm.Comments);
                    }
                    else
                    {
                        BLL.AddBatchDetailSB(BatchId, frm.ArtId, frm.Qty);
                    }

                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                    SetCellsColor();

                    // SetDefaultQty();
                }
            }
            else
            {
                frm_AddBatchRMLine frm = new frm_AddBatchRMLine();
                frm.BatchDetId = _bdid;
                frm.ArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                frm.Qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                frm.Comments = gv_List.CurrentRow.Cells["cn_detcomments"].Value.ToString();
                frm.IsActive = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_detisactive"].Value);
                frm.DNP = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_dnp"].Value);
                frm.DisableArticle();
                frm.HeaderText = "Edit RM qty or line state for batch: " + cmb_Batches1.Batch + ", Article:" + gv_List.CurrentRow.Cells["cn_article"].Value.ToString();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {

                    BLL.EditBatchDetail(frm.BatchDetId, frm.Qty, frm.Comments, frm.IsActive, frm.DNP);

                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                    SetCellsColor();
                    //SetDefaultQty();
                }

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            if (glob_Class.SaveConfirm() == true)
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (Convert.ToDouble(row.Cells["cn_reserve"].Value) != 0)
                    {
                        BLL.ReserveRM(Convert.ToInt32(row.Cells["cn_id"].Value), Convert.ToDouble(row.Cells["cn_reserve"].Value));
                    }
                }
                //MyLogistics.ChangeBatchRMStatusBH(BatchId);
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);
                Helper.RestoreDirection(gv_List, oldColumn, dir);
                SetCellsColor();
                //SetDefaultQty();

            }
        }

        private void btn_Wiz_Click(object sender, EventArgs e)
        {
            SetDefaultQty();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                SendArticle(igvArtId);
            }
        }

        private void gv_List_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gv_List_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 8) // Проверка происходит в первом столбце
            {
                double temp = 0;
                if (!Double.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Error during entering data, numbers allow only!");
                    //e.Value = 0;
                }
            }
        }


        #endregion

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (glob_Class.DeleteConfirm() == true)
            {
                int _bdid = 0;

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (row.Selected == true)
                    {
                        try
                        {
                            _bdid = Convert.ToInt32(row.Cells["cn_id"].Value);
                        }
                        catch { _bdid = 0; }

                        if (_bdid != 0)
                        {
                            BLL.DeleteBatchDetail(_bdid);
                        }
                    }
                }

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);
                bwStart(bw_List);
                Helper.RestoreDirection(gv_List, oldColumn, dir);


            }

            //int _bdid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            //if (_bdid != 0
            //    && glob_Class.DeleteConfirm() == true)
            //{
            //    if (BLL.DeleteBatchDetail(_bdid) == 1)
            //    {
            //        MessageBox.Show("Deletion of detail was succesfull!");
            //        DataGridViewColumn oldColumn = gv_List.SortedColumn;
            //        var dir = Helper.SaveDirection(gv_List);

            //        bwStart(bw_List);

            //        Helper.RestoreDirection(gv_List, oldColumn, dir);
            //        //SetDefaultQty();
            //    }
            //}
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        private void ctl_BatchFreeze_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void btn_FreeAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_reserve"].Value = 0;
                if (Convert.ToDouble(row.Cells["cn_reserved"].Value) > 0)
                {
                    row.Cells["cn_reserve"].Value = -1 * Convert.ToDouble(row.Cells["cn_reserved"].Value);
                }
            }
            SetCellsColor();
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            int _bdid = 0;
            int _oldartid = 0;
            try
            {
                _bdid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _oldartid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch { }
            if (_bdid != 0)
            {
                frm_AddBatchRMLine frm = new frm_AddBatchRMLine();
                frm.BatchDetId = _bdid;
                frm.ArtId = 0;
                frm.Qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                
                frm.HeaderText = "Replace RM in batch: " + cmb_Batches1.Batch + ", article: " + gv_List.CurrentRow.Cells["cn_article"].Value.ToString();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value) != frm.ArtId)
                    {
                        if (BLL.CheckReplaceStages(frm.BatchDetId, frm.ArtId) == true
                            && BLL.CheckReplaceBatchArticles(frm.ArtId, _oldartid, BatchId) == true)
                        {
                            BLL.ReplaceBatchDetail(frm.BatchDetId, frm.ArtId, frm.Qty);

                            DataGridViewColumn oldColumn = gv_List.SortedColumn;
                            var dir = Helper.SaveDirection(gv_List);

                            bwStart(bw_List);

                            Helper.RestoreDirection(gv_List, oldColumn, dir);

                            SetCellsColor();
                        }
                        else
                        {
                            MessageBox.Show("Replacement impossible, stages are different or articles are in replacements!");
                        }
                        //SetDefaultQty();
                    }
                }

            }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            if (BatchId != 0)
            {
                var _query = "sp_SelectBatchDetHistory";

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@bhid",SqlDbType.Int) {Value = BatchId}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Batch RM history for: " + cmb_Batches1.Batch;
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show();

            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }
    }
}
