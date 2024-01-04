using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Planning;
using Odin.Tools;
using Odin.Warehouse.Deliveries;
using Odin.Warehouse.StockOut.Reports;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.Warehouse.Movements
{
    public partial class frm_Movement : BaseForm
    {


        public frm_Movement()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "StockMovement.xls", this.Name);
            ED1 = new ExportData(this.gv_Dets, "StockMovementDets.xls", this.Name);
            PopupHelper = new PopupWindowHelper();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        StockMove_BLL SMBll = new StockMove_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        ExportData ED1;
        Helper MyHelper = new Helper();
        CMB_BLL CmbBll = new CMB_BLL();
        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        PopupWindowHelper PopupHelper = null;
        Plan_BLL PlanBll = new Plan_BLL();

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        int _sender = 0;

        public int _PrevBatchId = 0;

        public int StageId
        {
            get { return cmb_BatchStages1.StageId; }
            set { cmb_BatchStages1.StageId = value; }
        }

        public int Label
        {
            get {
                try { return Convert.ToInt32(txt_Label.Text); }
                catch { return 0; }
            }
            set { txt_Label.Text = value.ToString(); }
        }

        public int Reserve
        {
            get
            {
                return chk_Reserve.CheckState == CheckState.Checked ? -1 : 0;
            }
            set { chk_Reserve.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public double QtyToProduce
        {
            get { try { return Convert.ToDouble(txt_QtyOfProduct.Text); }
                catch { return 0; }
            }
            set { txt_QtyOfProduct.Text = value.ToString(); }
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

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_tomove"].Value) == -1)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                    }
                }
            }
        }


        public void SetCellsColorDets()
        {
            foreach (DataGridViewRow row in this.gv_Dets.Rows)
            {
                //if (Convert.ToDouble(row.Cells["cn_dqtyoper"].Value) < 0)
                //{
                //    foreach (DataGridViewCell cell in row.Cells)
                //    {
                //        cell.Style.BackColor = Color.LightPink;
                //    }
                //}
                //else
                //{
                //    foreach (DataGridViewCell cell in row.Cells)
                //    {
                //        cell.Style.BackColor = Color.LightGreen;
                //    }
                //}
                //if (Convert.ToInt32(row.Cells["cn_dnewlabel"].Value) == -1)
                //    row.Cells["cn_labelid"].Style.BackColor = Color.Yellow;
                row.Cells["cn_placeto"].Style.BackColor = Color.LightPink;
                row.Cells["cn_dplace"].Style.BackColor = Color.LightGreen;
                if (Convert.ToInt32(row.Cells["cn_labelid"].Value) != Convert.ToInt32(row.Cells["cn_labelto"].Value))
                    row.Cells["cn_labelto"].Style.BackColor = Color.Yellow;
            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = StockMove_BLL.getStockMoveRests(Label, cmb_Articles1.ArticleId, cmb_Places2.PlaceId, cmb_Batches1.BatchId, StageId);

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

        public void ShowList()
        {
            var data = StockMove_BLL.getStockMoveRests(Label, cmb_Articles1.ArticleId, cmb_Places2.PlaceId, cmb_Batches1.BatchId, StageId);

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
                              

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public void bw_Dets(object sender, DoWorkEventArgs e)
        {
            var data = StockMove_BLL.getStockMoveDets(cmb_MoveDocs1.MoveDocId);

            gv_Dets.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_Dets.SortedColumn;
                var dir = Helper.SaveDirection(gv_Dets);


                gv_Dets.AutoGenerateColumns = false;
                bs_Dets.DataSource = data;
                gv_Dets.DataSource = bs_Dets;
                
                Helper.RestoreDirection(gv_Dets, oldColumn, dir);
                
                SetCellsColorDets();

            });


            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_Dets;
            });
        }

        public void ShowHead(int id)
        {
            CmbBll.MoveDocHeadId = id;
            txt_DocDate.Text = CmbBll.MoveDocDocDate;
            txt_Comments.Text = CmbBll.MoveDocComments;
            txt_DelivPlace.Text = CmbBll.MoveDocDelivPlace;
            txt_DelivAddress.Text = CmbBll.MoveDocDelivAddress;
            txt_FinDestPlace.Text = CmbBll.MoveDocFinDestPlace;
            txt_FinDestAddress.Text = CmbBll.MoveDocFinDestAddress;
            txt_Transport.Text = CmbBll.MoveDocTransport;
            txt_Incoterms.Text = CmbBll.MoveDocIncoterms;
            txt_PalQty.Text = CmbBll.MoveDocPalettesQty.ToString();
            txt_PalWeight.Text = CmbBll.MoveDocPalettesWeight.ToString();
            //if (_PrevBatchId != cmb_Batches2.BatchId)
            //{

            //    _PrevBatchId = cmb_Batches2.BatchId;
            //}
            
        }

        public void ShowDets(int id)
        {
            bs_Dets.RemoveFilter();
            //bwStart(bw_Dets);
            var data = StockMove_BLL.getStockMoveDets(cmb_MoveDocs1.MoveDocId);

            gv_Dets.ThreadSafeCall(delegate
            {
                gv_Dets.AutoGenerateColumns = false;
                bs_Dets.DataSource = data;
                gv_Dets.DataSource = bs_Dets;

                SetCellsColorDets();
            });


            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_Dets;
            });
        }

        public void ClearFields()
        {
            _sender = 0;
            cmb_MoveDocs1.MoveDocId = 0;
            cmb_Batches1.BatchId = 0;
            cmb_Batches2.BatchId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            Label = 0;
            StageId = 0;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
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
                LoadColumns(gv_List);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }



        #endregion

        #region ContextMenuD


        private void mnu_LinesDets_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Dets.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Dets.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Dets.ClearSelection();
                gv_Dets.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                gv_Dets.CurrentCell = gv_Dets.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = gv_Dets.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = gv_Dets.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_SearchD_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Dets;
            frm.ColumnNumber = gv_Dets.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Dets.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void txt_FilterForD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_Dets.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + txt_FilterForD.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColorDets();
        }

        private void mni_FilterByD_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Dets.Filter = String.IsNullOrEmpty(bs_Dets.Filter) == true
                    ? String.IsNullOrEmpty(CellValue) == true
                        ? "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'"
                    : String.IsNullOrEmpty(CellValue) == true
                        ? bs_Dets.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : bs_Dets.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColorDets();
        }

        private void mni_FilterExcludingSelD_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Dets.Filter = String.IsNullOrEmpty(bs_Dets.Filter) == true
                    ? "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'"
                    : bs_Dets.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            SetCellsColorDets();
        }
        
        private void mni_RemoveFilterD_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Dets.RemoveFilter();
            }
            catch { }
            SetCellsColorDets();
        }
        
        private void mni_CopyD_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }
        
        private void mni_AdminD_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for list";
            frm.grid = this.gv_Dets;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Dets);
            }
        }
        
        private void btn_IntoExcelDets_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }

        #endregion


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.bindingNavigatorAddNewItem_Image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void frm_Movement_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            LoadColumns(gv_Dets);
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (gv_List.CurrentRow.Cells["btn_Add"].Selected == true)
                {
                    gv_List.CurrentRow.Cells["cn_qtytomove"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                }
            }
            catch { }
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            try
            {
                if (gv_List.CurrentRow.Cells["cn_qtytomove"].Selected == true)
                {
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qtytomove"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value))
                    {
                        gv_List.CurrentRow.Cells["cn_qtytomove"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                    }
                }
            }
            catch { gv_List.CurrentRow.Cells["cn_qtytomove"].Value = 0; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            Label = 0;
        }

        private void cmb_MoveDocs1_MoveDocChanged(object sender)
        {
            //MessageBox.Show(cmb_MoveDocs1.MoveDoc);
            if (_sender == 0)
            {
                //MessageBox.Show(cmb_MoveDocs1.MoveDocId.ToString());
                ShowHead(cmb_MoveDocs1.MoveDocId);
                ShowDets(cmb_MoveDocs1.MoveDocId);

                cmb_Batches2.BatchId = CmbBll.MoveDocBatchId;
                cmb_Batches1.BatchId = cmb_Batches2.BatchId;
                if (cmb_Batches1.BatchId != 0)
                    //bwStart(bw_List);
                    ShowList();
                else
                    bs_List.DataSource = null;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            bool _test = true;
           
            if (cmb_Batches1.BatchId != cmb_Batches2.BatchId)
            {
                DialogResult result1 = KryptonTaskDialog.Show("Deallocation warning!",
                                                                "Are you want to save changes?",
                                                                "Batch in movement document and batch line you want to move are not the same!",
                                                                MessageBoxIcon.Warning,
                                                                TaskDialogButtons.Yes |
                                                                TaskDialogButtons.No);
                _test = result1 == DialogResult.Yes;

            }

            if (_test == true)
            {
                int _res = cmb_MoveDocs1.MoveDocId;
                if (cmb_Places1.PlaceId != 0)
                {
                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (row.Cells["cn_qtytomove"].Value != null
                                && String.IsNullOrEmpty(row.Cells["cn_qtytomove"].Value.ToString()) != true
                                && Convert.ToDouble(row.Cells["cn_qtytomove"].Value) != 0
                                && Convert.ToDouble(row.Cells["cn_qtytomove"].Value) > 0)
                        {
                            try
                            {
                                _res = SMBll.AddStockMoveLine(_res,
                                                        Convert.ToInt32(row.Cells["cn_label"].Value),
                                                        Convert.ToDouble(row.Cells["cn_qtytomove"].Value),
                                                        cmb_Places1.PlaceId,
                                                        Convert.ToInt32(row.Cells["cn_bdid"].Value),
                                                        Reserve,
                                                        cmb_Batches1.BatchId,
                                                        StageId,
                                                        QtyToProduce,
                                                        row.Cells["cn_comments"].Value.ToString());
                            }
                            catch
                            {

                                DialogResult result = KryptonTaskDialog.Show("Quantity deallocation line warning!",
                                                                    "Saving of line impossible!",
                                                                    "Please check line: " + row.Index.ToString(),
                                                                    MessageBoxIcon.Warning,
                                                                    TaskDialogButtons.OK);

                            }

                        }
                    }
                    if (_res != 0)
                    {
                        //Sending letter about stockout for fixed assets
                        SqlConnection sqlConn = new SqlConnection(sConnStr);
                        SqlCommand sqlComm = new SqlCommand("sp_SelectFixedAssetsMovements", sqlConn);
                        sqlComm.Parameters.AddWithValue("@id", _res);
                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlConn.Open();

                        SqlDataReader reader = sqlComm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            string strMessage = "";
                            string emailaddresses = "";
                            emailaddresses = DAL.EmailAddressesByType(8);
                           
                            while (reader.Read())
                            {
                                strMessage = strMessage + "\r\nLabel: " + reader["labelid"].ToString();
                                strMessage = strMessage + "\r\nDocument: " + reader["document"].ToString();
                                strMessage = strMessage + "\r\nArticle: " + reader["Article"].ToString();
                                strMessage = strMessage + "\r\nInv. number: " + reader["invnumber"].ToString();
                                strMessage = strMessage + "\r\nSuppliers article: " + reader["suparticle"].ToString();
                                strMessage = strMessage + "\r\nQty: " + reader["qty"].ToString();
                                strMessage = strMessage + "\r\nUnit price: " + reader["unitprice"].ToString();
                                strMessage = strMessage + "\r\nPlace from: " + reader["placefrom"].ToString() + ", Resp. person: " + reader["resppersonfrom"].ToString();
                                strMessage = strMessage + "\r\nPlace to: " + reader["placeto"].ToString() + ", Resp. person: " + reader["resppersonto"].ToString();

                            }

                            reader.Close();
                            if (emailaddresses != "")
                            {
                                MyHelper.SendMessage(emailaddresses, "Fixed asset stock movement!", strMessage);
                            }

                        }
                        sqlConn.Close();
                    }

                    bwStart(bw_List);
                    if (cmb_MoveDocs1.MoveDocId != _res)
                        cmb_MoveDocs1.MoveDocId = _res;
                    else
                        ShowDets(cmb_MoveDocs1.MoveDocId);
                }
                else
                {
                    DialogResult result = KryptonTaskDialog.Show("Quantity deallocation warning!",
                                                                    "Saving impossible!",
                                                                    "Place for movement is not selected.",
                                                                    MessageBoxIcon.Warning,
                                                                    TaskDialogButtons.OK);

                }
            }
        }

        private void frm_Movement_Resize(object sender, EventArgs e)
        {
            if (_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });

                }
            }
        }


        #endregion

        private void btn_ClearList_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_qtytomove"].Value = 0;
            }
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            //if (cmb_Batches1.BatchId == 0)
            //    Reserve = 0;
            //else
            //    Reserve = -1;
            cmb_BatchStages1.BatchId = cmb_Batches1.BatchId;

            //if (cmb_Batches1.BatchId != 0
            //    && cmb_Batches1.StencilRequired == 0)
            //{
            //    lbl_StencilRequired.Visible = true;
            //    btn_OK.Enabled = false;
            //}
            //else
            //{
            //    lbl_StencilRequired.Visible = false;
            //    btn_OK.Enabled = true;
            //}

            if (cmb_Batches1.BatchId == 0)
                cmb_Articles2.Article = "";
            else
                cmb_Articles2.ArticleId = cmb_Batches1.ArticleId;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (glob_Class.DeleteConfirm())
            {
                int _id = 0;

                foreach (DataGridViewRow row in this.gv_Dets.Rows)
                {
                    if (row.Selected == true)
                    {
                        try
                        {
                            _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                        }
                        catch { _id = 0; }

                        if (_id != 0)
                        {
                            SMBll.DeleteStockMoveLine(_id);
                        }
                    }
                }
                

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                ShowDets(cmb_MoveDocs1.MoveDocId);
            }
                //int _id = 0;

                //try { _id = Convert.ToInt32(gv_Dets.CurrentRow.Cells["cn_id"].Value); }
                //catch { }

                //if (_id != 0
                //    && globClass.DeleteConfirm() == true)
                //{
                //    int _res =SMBll.DeleteStockMoveLine(_id);
                //    if (_res != 0)
                //    {
                //        ShowDets(cmb_MoveDocs1.MoveDocId);
                //        bwStart(bw_List);
                //    }
                //    else
                //    {
                //        DialogResult result = KryptonTaskDialog.Show("Deleting warning!",
                //                                                   "Delete impossible!",
                //                                                   "There are movement for this labels after selected line or mistake during operation!",
                //                                                   MessageBoxIcon.Warning,
                //                                                   TaskDialogButtons.OK);
                //    }
                //}
        }

        private void cmb_Batches2_BatchChanged(object sender)
        {
            if (_sender == 1)
            {
                //int _r = 0;

                //if (_PrevBatchId != cmb_Batches2.BatchId)
                //{
                    //try
                    //{
                    //    _r = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from sto_stockouthead where batchid = " + cmb_Batches2.BatchId + " and batchid != 0 and typeout = 7 order by id desc "));
                    //}
                    //catch { _r = 0; }
                    //if (_r != 0)
                    //    cmb_MoveDocs1.MoveDocId = _r;
                    //else
                    //    cmb_MoveDocs1.MoveDocId = 0;

                    //ShowHead(_r);


                    //ShowDets(_r);

                cmb_Batches1.BatchId = cmb_Batches2.BatchId;
                if (cmb_Batches1.BatchId != 0)
                    ShowList();
                //bwStart(bw_List);
                else
                    bs_List.DataSource = null;
                //_PrevBatchId = cmb_Batches2.BatchId;
                //}
            }
           
        }
               
        private void cmb_Batches2_ControlClick(object sender)
        {
            _sender = 1; //Focus on batch
            //MessageBox.Show(_sender.ToString());
        }

        private void cmb_MoveDocs1_ControlClick(object sender)
        {
            _sender = 0; //focus on move doc
            //MessageBox.Show(_sender.ToString());
        }

        private void gv_Dets_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColorDets();
        }

        private void btn_PrintDLN_Click(object sender, EventArgs e)
        {
            frm_rptDeliveryNote frm = new frm_rptDeliveryNote();
            frm.DelivNoteType = 2;
            frm.HeadId = cmb_MoveDocs1.MoveDocId;
            frm.HeaderText = "Print delivery note: " + cmb_MoveDocs1.MoveDocId;
            frm.FillReport();

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void mni_LabelDets_Click(object sender, EventArgs e)
        {
            int _label = 0;

            try { _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value); }
            catch { }

            if (_label != 0)
            {
                Form f;
                f = this.FindForm();

                Point LocationPoint = gv_List.PointToScreen(Point.Empty);
                int xpos = LocationPoint.X + 100;
                int ypos = LocationPoint.Y;
                Point _location = new Point(xpos, ypos);

                frm_StockLabel popup = new frm_StockLabel();

                PopupHelper.ClosePopup();

                PopupHelper.ShowPopup(f, popup, _location);

                PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
                {
                    if (popup.ShowingModal)
                    {
                        _e.Cancel = true;
                    }
                };
                popup.ctl_StockLabel1.btn_OK.Enabled = false;
                popup.ctl_StockLabel1.txt_Label.Text = _label.ToString();
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _placeid = 0;
            try
            {
                _placeid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_placeid"].Value);
            }
            catch { }

            cmb_Places1.PlaceId = _placeid;
        }

        private void mni_Production_Click(object sender, EventArgs e)
        {

            frm_rptStockMove frm = new frm_rptStockMove();

            if (cmb_Launches1.LaunchId == 0)
            {
                PlanBll.BatchId = cmb_Batches2.BatchId;

                frm.HeadId = 0;
                frm.Batch = cmb_Batches2.Batch;
                frm.QtyInBatch = PlanBll.BatchQty;
                frm.ConfOrder = PlanBll.BatchConfOrder;
                frm.AssPerson = cmb_Users1.UserShortName;
                frm.Article = cmb_Batches2.Article;
                frm.DocDate = "";
                frm.Unit = "";
                frm.Customer = PlanBll.BatchCustomer;
                frm.DocName = "";
                frm.SecArticle = cmb_Batches2.SecName;
                frm.StageId = cmb_Common1.SelectedValue;
                frm.Stage = cmb_Common1.SelectedValue == 0 ? "ALL" : cmb_Common1.sCurrentValue;
                frm.Comments = PlanBll.BatchComments;
                frm.BatchId = cmb_Batches2.BatchId;
                frm.QtyLabels = PlanBll.BatchQtyLabels;
                frm.Serials = PlanBll.BatchSerials;
                frm.Stencil = PlanBll.Stencil;
                frm.Stencilplace = PlanBll.Stencilplace;
                frm.RepType = 2;
            }
            else
            {
                PlanBll.LaunchId = cmb_Launches1.LaunchId;

                int _isgroup = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where groupid = " + PlanBll.LaunchBatchId));

                if (_isgroup == 0)
                {

                    frm.HeadId = 0;
                    frm.Batch = PlanBll.LaunchName;
                    frm.QtyInBatch = PlanBll.LaunchQty;
                    frm.ConfOrder = PlanBll.LaunchConfOrder;
                    frm.AssPerson = cmb_Users1.UserShortName;
                    frm.Article = PlanBll.LaunchArticle;
                    frm.DocDate = "";
                    frm.Unit = "";
                    frm.Customer = PlanBll.LaunchCustomer;
                    frm.DocName = "";
                    frm.SecArticle = PlanBll.LaunchSecArticle;
                    frm.StageId = cmb_Common1.SelectedValue;
                    frm.Stage = cmb_Common1.SelectedValue == 0 ? PlanBll.LaunchStage : cmb_Common1.sCurrentValue;
                    //frm.Stage = PlanBll.LaunchStage;
                    frm.Comments = PlanBll.LaunchComments;
                    frm.LaunchId = cmb_Launches1.LaunchId;
                    frm.QtyLabels = PlanBll.LaunchQtyLabels;
                    frm.MoveDate = PlanBll.LaunchStartDate;
                    frm.Serials = PlanBll.LaunchSerials;
                    frm.Stencilplace = PlanBll.Stencilplace;
                    frm.Stencil = PlanBll.Stencil;
                    frm.RepType = 5;
                }
                else
                {
                    frm.HeadId = 0;
                    frm.Batch = PlanBll.LaunchName;
                    frm.QtyInBatch = PlanBll.LaunchQty;
                    frm.ConfOrder = PlanBll.LaunchConfOrder;
                    frm.AssPerson = cmb_Users1.UserShortName;
                    frm.Article = PlanBll.LaunchArticle;
                    frm.DocDate = "";
                    frm.Unit = "";
                    frm.Customer = PlanBll.LaunchCustomer;
                    frm.DocName = "";
                    frm.SecArticle = PlanBll.LaunchSecArticle;
                    frm.StageId = cmb_Common1.SelectedValue;
                    frm.Stage = cmb_Common1.SelectedValue == 0 ? PlanBll.LaunchStage : cmb_Common1.sCurrentValue;
                    //frm.Stage = PlanBll.LaunchStage;
                    frm.Comments = PlanBll.LaunchComments;
                    frm.LaunchId = cmb_Launches1.LaunchId;
                    frm.QtyLabels = PlanBll.LaunchQtyLabels;
                    frm.MoveDate = PlanBll.LaunchStartDate;
                    frm.Serials = PlanBll.LaunchSerials;
                    frm.BatchId = PlanBll.LaunchBatchId;
                    frm.Stencilplace = PlanBll.Stencilplace;
                    frm.Stencil = PlanBll.Stencil;
                    frm.RepType = 9;
                }
            }

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void mni_Movement_Click(object sender, EventArgs e)
        {
            frm_rptStockMove frm = new frm_rptStockMove();
            frm.HeadId = cmb_MoveDocs1.MoveDocId;
            frm.Batch = CmbBll.MoveDocBatch;
            frm.QtyInBatch = CmbBll.MoveQtyInBatch;
            frm.ConfOrder = CmbBll.MoveConfOrder;
            frm.AssPerson = cmb_Users1.UserShortName;
            frm.Article = CmbBll.MoveProduct;
            frm.DocDate = CmbBll.MoveDocDocDate;
            frm.Unit = CmbBll.MoveUnit;
            frm.Customer = CmbBll.MoveCustomer;
            frm.DocName = cmb_MoveDocs1.MoveDoc;
            frm.SecArticle = CmbBll.MoveSecArticle;
            frm.StageId = cmb_Common1.SelectedValue;
            frm.Stage = cmb_Common1.SelectedValue == 0 ? "ALL" : cmb_Common1.sCurrentValue;
            frm.Comments = CmbBll.MoveBatchComments;
            frm.RepType = 1;

            frm.FillDataSet(cmb_MoveDocs1.MoveDocId);

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
    
}
