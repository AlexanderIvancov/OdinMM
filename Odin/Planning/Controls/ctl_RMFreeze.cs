using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Planning.Controls
{
    //public delegate void BatchIdSendingEventHandler(object sender);
    public delegate void ArtIdSendingEventHandler(int artid, bool general, bool batchrm, bool artrm, bool totalart, bool poreservation);


    public partial class ctl_RMFreeze : UserControl
    {
        public ctl_RMFreeze()
        {
            InitializeComponent();
            //frm_Batches.ReceiveBatchId += new ReceiveBatchId(RetBatchId);
            //frm_Batches.ReceiveRMArtId += new ReceiveRMId(RetArtId);
            ED = new ExportData(this.gv_List, "RMBatches.xls", this.Name);
        }

        #region Variables

        ProgressForm wait;
        frm_Batches frmBatches;
        ExportData ED;
        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DLL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        AdmMenu mMenu = new AdmMenu();

        //public event BatchIdSendingEventHandler SendBatchId;
        public event ArtIdSendingEventHandler SendArtId;

        public DataTable data;
        public int BatchId { get; set; }
        //public int RetBatchId()
        //{
        //    return BatchId;
        //}

        //public int RetArtId()
        //{
        //    return ArtId;
        //}
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
        public void bwStart(DoWorkEventHandler doWork)
        {
            wait = new ProgressForm(frmBatches);
            wait.bwStart(doWork);
        }

        int _articleid = 0;
        double _FreeQty = 0;
        int _previd = 0;
        public int PrevId
        {
            get { return _previd; }
            set { _previd = value; }
        }
        public int ArtId
        {
            get { return cmb_Articles1.ArticleIdRec; }
            set
            {
                if (PrevId != value
                    && value != 0)
                {
                    //MessageBox.Show("!!!");
                    _articleid = value;
                    //bwStart(bw_List);
                    ShowDets();
                    AvailableQty = DLL.AvailQty(cmb_Articles1.ArticleIdRec);
                    FreeQty = AvailableQty;
                    PrevId = value;
                }
            }
        }
        public double FreeQty
        {
            get { return _FreeQty; }
            set
            {
                _FreeQty = value;
                txt_Available.Text = value.ToString();
            }
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
        double _pro = 0;
        public double pro
        {
            get { return _pro; }
            set { _pro = value; }
        }

        #endregion


        #region Methods
        public void LoadColumns(DataGridView grid)
        {
            DLL.UserLogin = Environment.UserName;

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
        public void bw_List(object sender, DoWorkEventArgs e)
        {
            try
            {
                data = (DataTable)Helper.getSP("sp_SelectArticleFreezedDets", ArtId);

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
            catch { }
        }

        public void ShowDets()
        {
            //MessageBox.Show("!!");
            try
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                data = (DataTable)Helper.getSP("sp_SelectArticleFreezedDets", ArtId);

                gv_List.ThreadSafeCall(delegate
                {
                    gv_List.AutoGenerateColumns = false;
                    bs_List.DataSource = data;
                    gv_List.DataSource = bs_List;
                    SetCellsColor();
                });
                Helper.RestoreDirection(gv_List, oldColumn, dir);

                bn_List.ThreadSafeCall(delegate
                {
                    bn_List.BindingSource = bs_List;
                });
                //MessageBox.Show(cmb_Articles1.QtyAvail.ToString());
            }
            catch { }
        }

        public void bw_Freeze(object sender, DoWorkEventArgs e)
        {
            gv_List.ThreadSafeCall(delegate
            {
                int prevbd = 0;
                foreach (DataRow row in data.AsEnumerable().OrderBy(o => o.Field<int>("id")))//<double>("QtyOper")))
                    if (Math.Round(Convert.ToDouble(row["toreserve"]), 5) != 0
                        && prevbd != Convert.ToInt32(row["id"]))
                        Helper.getSP("sp_ReserveBatchRM", Convert.ToInt32(row["id"]), Math.Round(Convert.ToDouble(row["toreserve"]), 5));
            });
        }

        private void SetCellsColor()
        {
            try
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    //Color of freezed qty
                    row.Cells["cn_reserve"].Style.ForeColor = Convert.ToDouble((row.Cells["cn_reserve"].Value)) < 0
                        ? Color.Blue
                        : Convert.ToDouble((row.Cells["cn_reserve"].Value)) > 0 ? Color.Green : Color.Black;

                    if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) == 0
                                            && Convert.ToDouble(row.Cells["cn_qty"].Value) > 0)
                        //green
                        row.Cells["cn_nomenclature"].Style.BackColor = Color.LightGreen;
                    else if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) > 0
                        && Convert.ToDouble(row.Cells["cn_qty"].Value) == 0)
                        //red
                        row.Cells["cn_nomenclature"].Style.BackColor = Color.LightPink;
                    else if (Math.Round(Convert.ToDouble((row.Cells["cn_nomenclature"].Value)), 3) !=
                       Math.Round(Convert.ToDouble(row.Cells["cn_qty"].Value), 3))
                    {
                        row.Cells["cn_nomenclature"].Style.Font = new Font(this.Font, FontStyle.Bold);
                        row.Cells["cn_nomenclature"].Style.ForeColor = Color.Red;
                    }
                }
            }
            catch
            { }
        }

        public void RecalcAvailableQty()
        {
            double Qty = 0;
            double Qty1 = 0;

            try
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                    try
                    {
                        Qty1 = Math.Round(Convert.ToDouble(row.Cells["cn_reserve"].Value), 5);
                        Qty = Math.Round(Qty + Qty1, 5);
                    }
                    catch
                    { }
            }
            catch { }

            AvailableQty = Math.Round(FreeQty - Qty, 5);
        }

        public double OperAvail
        {
            get
            {
                double Qty = 0;
                double Qty1 = 0;
                foreach (DataGridViewRow row in this.gv_List.Rows)
                    try
                    {
                        Qty1 = Convert.ToDouble(row.Cells["cn_reserve"].Value);
                        Qty = Qty + Qty1;
                    }
                    catch
                    { }
                return FreeQty - Qty;
            }
        }

        double _OperAvail = 0;

        public void RecalcFIFO()
        {
            //Clear
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_reserve"].Value = 0;
            }
            RecalcAvailableQty();
            //FIFO distribution
            double k = 0;

            foreach (DataRow row in data.AsEnumerable().OrderBy(o => o.Field<DateTime>("resdate")))
            {
                k = Convert.ToDouble(row["qty"])
                                    - Convert.ToDouble(row["reserved"])
                                    //- Convert.ToDouble(row["requested"])
                                    - Convert.ToDouble(row["given"])
                                    + Convert.ToDouble(row["returned"]);
                if (k > 0)
                    if (k < AvailableQty)
                    {
                        row.BeginEdit();
                        row["toreserve"] = k;
                        row.EndEdit();
                        RecalcAvailableQty();
                    }
                    else
                    {
                        row.BeginEdit();
                        row["toreserve"] = Math.Round(AvailableQty, 5);
                        row.EndEdit();
                        RecalcAvailableQty();
                        break;
                    }
            }

            SetCellsColor();
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

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 12)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.bindingNavigatorAddNewItem_Image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 10)
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

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            //ArtId = cmb_Articles1.ArticleId;
            //Comments = cmb_Articles1.Comments;
            //Description = cmb_Articles1.Description;

            //if (SendArtId != null)
            //    SendArtId(ArtId, true, false, false, true, true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            if (glob_Class.SaveConfirm() == true)
            {
                bwStart(bw_Freeze);

                bwStart(bw_List);

                AvailableQty = DLL.AvailQty(cmb_Articles1.ArticleId);
                FreeQty = AvailableQty;
            }
            SendArtId?.Invoke(ArtId, true, true, false, true, true);
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pro = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value);

                if (gv_List.CurrentRow.Cells["btn_free"].Selected == true)
                    //osvobozhdaem esli est' zamorozhennoe
                    if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_ispre"].Value) == -1)
                        gv_List.CurrentRow.Cells["cn_reserve"].Value = Math.Round(-1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value), 5);
                    else
                        if (gv_List.CurrentRow.Cells["cn_inprod"].Value.ToString() != "YES"
                            && glob_Class.MessageConfirm("Confirm RM releasing!", "Are you sure you want to release qty from batch?") == true)
                            gv_List.CurrentRow.Cells["cn_reserve"].Value = Math.Round(-1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value), 5);

                else if (gv_List.CurrentRow.Cells["btn_freeze"].Selected == true)
                {
                    //esli est' osvobozhdennoe
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) < 0)
                    {
                        /*gv_FreezeDets.CurrentRow.Cells["cn_Operate"].Value = 0;*/
                        if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) > pro)
                            if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) >= _OperAvail + pro)
                                gv_List.CurrentRow.Cells["cn_reserve"].Value = _OperAvail + pro;
                        RecalcAvailableQty();
                    }
                    //morozim esli est' svobodnoe i esli nado zamorozit'
                    if (/*AvailableQty*/ _OperAvail + pro > 0)
                    {
                        double ToFreeze = 0;
                        ToFreeze = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value)
                                    - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value)
                                    //- Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyReq"].Value)
                                    - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_given"].Value)
                                    + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_returned"].Value);
                        if (ToFreeze > 0)
                            gv_List.CurrentRow.Cells["cn_reserve"].Value = _OperAvail + pro >= ToFreeze ? ToFreeze : (object)(_OperAvail + pro);
                    }
                }
                //
                _OperAvail = OperAvail;
                //bs_List.ResetBindings(true);
                SetCellsColor();
            }
            catch { }
            RecalcAvailableQty();
        }

        double _tmpqty = 0;

        private void gv_List_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["cn_reserve"].Selected == true)
                _tmpqty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value);
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            if (gv_List.CurrentRow.Cells["cn_reserve"].Selected == true
                && Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) != _tmpqty)
            {
                //MessageBox.Show(pro.ToString());
                // 
                // try {
                //    double val = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value);
                //}
                //catch { gv_List.CurrentRow.Cells["cn_reserve"].Value = 0; }

                //!!Proverjaem osvobozhdaem ili naoborot, esli zamorazhivaem - proverka available
                //if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) > pro)
                //{
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) >= AvailableQty + pro)
                    gv_List.CurrentRow.Cells["cn_reserve"].Value = AvailableQty + pro;
                //}

                //osvobozhdaem esli est' zamorozhennoe
                if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) < 0)
                    if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_ispre"].Value) == -1)
                        if (-1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value))
                            gv_List.CurrentRow.Cells["cn_reserve"].Value = -1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value);
                    else
                        if (gv_List.CurrentRow.Cells["cn_inprod"].Value.ToString() != "YES"
                           && glob_Class.MessageConfirm("Confirm RM releasing!", "Are you sure you want to release qty from batch?") == true
                           )
                            if (-1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value))
                                gv_List.CurrentRow.Cells["cn_reserve"].Value = -1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserved"].Value);
                        else
                            gv_List.CurrentRow.Cells["cn_reserve"].Value = 0;
                    //proverka osvobozhdenija
            }
            RecalcAvailableQty();
            SetCellsColor();
        }

        private void btn_FreeAll_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in this.gv_List.Rows)
                //row.Cells["cn_Operate"].Value = 0;
                if (Convert.ToDouble(row.Cells["cn_reserved"].Value) > 0
                    && Convert.ToInt32(row.Cells["cn_ispre"].Value) == -1)
                    row.Cells["cn_reserve"].Value = -1 * Convert.ToDouble(row.Cells["cn_reserved"].Value);
            RecalcAvailableQty();
            SetCellsColor();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
                row.Cells["cn_reserve"].Value = 0;
            RecalcAvailableQty();

            SetCellsColor();
        }

        private void btn_Wiz_Click(object sender, EventArgs e)
        {
            RecalcFIFO();
        }

        #endregion

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _bdid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            if (_bdid != 0
                && glob_Class.DeleteConfirm() == true)
                if (Convert.ToInt32(Helper.getSP("sp_DeleteBatchDet", _bdid)) == 1)
                {
                    MessageBox.Show("Deletion of detail was succesfull!");
                    bwStart(bw_List);
                }
        }

        private void ctl_RMFreeze_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try {
            //pro = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value);
            //}
            //catch { }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                pro = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_reserve"].Value);
                //MessageBox.Show(pro.ToString());
            }
            catch { }
        }

        private void gv_List_CellLeave(object sender, DataGridViewCellEventArgs e) { }

        private void cmb_Articles1_ArticleIdKeyPressed(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
            Comments = cmb_Articles1.Comments;
            Description = cmb_Articles1.Description;
            SendArtId?.Invoke(ArtId, true, false, false, true, true);
        }

        private void cmb_Articles1_ArticleKeyPressed(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
            Comments = cmb_Articles1.Comments;
            Description = cmb_Articles1.Description;
            SendArtId?.Invoke(ArtId, true, false, false, true, true);
        }

        private void cmb_Articles1_ArticleIdReceiving(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
            Comments = cmb_Articles1.Comments;
            Description = cmb_Articles1.Description;
            SendArtId?.Invoke(ArtId, true, false, false, true, true);
        }

        private void cmb_Articles1_ArticleValidated(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
            Comments = cmb_Articles1.Comments;
            Description = cmb_Articles1.Description;
            SendArtId?.Invoke(ArtId, true, false, false, true, true);
        }
    }
}