using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Odin.Global_Classes;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using System.Data.SqlClient;
using Odin.Tools;
using Odin.CMB_Components.BLL;
using AdvancedDataGridView;
using Odin.Warehouse.Inventory;
using Odin.Warehouse.StockOut.Reports;
using Odin.Warehouse.Movements;
using Odin.Warehouse.Requests;
namespace Odin.Warehouse.StockOut
{
    public partial class frm_StockOut : BaseForm
    {
        public frm_StockOut()
        {
            InitializeComponent();
            //ED = new ExportData(this.gv_List, "StockMovement.xls");
            ED1 = new ExportData(this.gv_Dets, "StockMovementDets.xls", this.Name);
            PopupHelper = new PopupWindowHelper();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        StockOut_BLL SOBll = new StockOut_BLL();
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
        StockInventory Inventory = new StockInventory();


        PopupWindowHelper PopupHelper = null;

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public int Label
        {
            get
            {
                try { return Convert.ToInt32(txt_Label.Text); }
                catch { return 0; }
            }
            set { txt_Label.Text = value.ToString(); }
        }

        public int Mode
        { get; set; }

        public int Reserved
        {
            get
            { if (chk_Reserved.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Reserved.CheckState = CheckState.Checked;
                else
                    chk_Reserved.CheckState = CheckState.Unchecked;
            }            
        }

        public int LeftOnly
        {
            get
            {
                if (chk_Left.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Left.CheckState = CheckState.Checked;
                else
                    chk_Left.CheckState = CheckState.Unchecked;
            }
        }

        public int RequestID
        {
            get { return cmb_Requests1.RequestId; }
            set { cmb_Requests1.RequestId = value; }
        }

        int _PrevDocId = 0;
        public int PrevDocId
        {
            get { return _PrevDocId; }
            set { _PrevDocId = value; }
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

        }

        public void SetCellsColorDets()
        {
            //foreach (DataGridViewRow row in this.gv_Dets.Rows)
            //{
            //    if (Convert.ToDouble(row.Cells["cn_dqtyoper"].Value) < 0)
            //    {
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            cell.Style.BackColor = Color.LightPink;
            //        }
            //    }
            //    else
            //    {
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            cell.Style.BackColor = Color.LightGreen;
            //        }
            //    }
            //    if (Convert.ToInt32(row.Cells["cn_dnewlabel"].Value) == -1)
            //        row.Cells["cn_labelid"].Style.BackColor = Color.Yellow;
            //}
        }

        public void bw_Dets(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = StockOut_BLL.getStockOutDets(cmb_OutcomeDocs1.OutcomeDocId);

            gv_Dets.ThreadSafeCall(delegate
            {
                gv_Dets.AutoGenerateColumns = false;
                bs_Dets.DataSource = data;
                gv_Dets.DataSource = bs_Dets;

                SetCellsColor();
            });


            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_Dets;
            });
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {


            //MessageBox.Show(cmb_Common1.SelectedValue.ToString());
            //header
            tgv_List.ThreadSafeCall(delegate
            {
            if (cmb_Requests1.RequestId != 0)
                this.cn_Reserved.HeaderText = "Requested";
            else
                this.cn_Reserved.HeaderText = "Reserved";
            tgv_List.Nodes.Clear();
            TreeGridNode node;
            Font boldFont = new Font(tgv_List.DefaultCellStyle.Font, FontStyle.Bold);
                 
            var data = StockOut_BLL.getStockOutProceedHead(cmb_Articles1.ArticleId, cmb_Batches1.BatchId, cmb_Requests1.RequestId, cmb_Common1.SelectedValue, LeftOnly);

            foreach (System.Data.DataRow dr in data.AsEnumerable().OrderBy(d => d.Field<string>("unit")).ThenBy(a => a.Field<int>("artid")))
            {



                node = tgv_List.Nodes.Add(null, dr["artid"], dr["artid"], dr["article"], dr["batch"], dr["batchid"], dr["request"],
                                                dr["requestid"], dr["leftinbatch"], dr["reserved"], dr["available"],
                                                dr["unit"], 0, dr["qtystock"], "->", 0, 0, "", "", "", -1, 0);

                foreach (DataGridViewCell cell in node.Cells)
                {
                    cell.Style.BackColor = Color.Azure;//Color.FromArgb(192, 255, 192);
                }

                node.ImageIndex = 1;
                //Add details nodes
                var datad = StockOut_BLL.getStockOutProceedDets(Convert.ToInt32(dr["artid"]), cmb_Batches1.BatchId, Reserved);
                foreach (System.Data.DataRow dr1 in datad.AsEnumerable().OrderBy(a => a.Field<DateTime>("expdate"))
                                                                        .ThenBy(a => a.Field<int>("label")))
                {
                        if (Convert.ToInt32(dr["requestid"]) == 0
                            || (Convert.ToInt32(dr["requestid"]) != 0
                                && Convert.ToInt32(dr1["batchdetid"]) == 0))
                            AddNode(dr1, boldFont, node.Nodes, true);
                }

            }

            foreach (TreeGridNode node1 in tgv_List.Nodes)
            {
                ExpandNodes(node1);
            }

                //foreach (DataGridViewRow row in this.tgv_List.Rows)
                //{

                    //if ((Convert.ToDouble(row.Cells["cn_Available"].Value) + Convert.ToDouble(row.Cells["cn_Reserved"].Value) <= 0
                    //    && Convert.ToInt32(row.Cells["cn_BatchId"].Value) != 0)
                    //    || (Convert.ToInt32(row.Cells["cn_Usage"].Value) == 0 && Convert.ToInt32(row.Cells["cn_BatchId"].Value) == 0))
                    //{
                    //    foreach (DataGridViewCell cell in row.Cells)
                    //    {
                    //        cell.Style.BackColor = Color.LightGray;
                    //    }
                    //}
                    //else
                    //{
                    //    foreach (DataGridViewCell cell in row.Cells)
                    //    {
                    //        cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                    //    }
                    //}
                //}
            });
        }

        public void ExpandNodes(TreeGridNode node)
        {
            foreach (TreeGridNode node1 in node.Nodes)
            {
                node.Expand();
                ExpandNodes(node1);
            }
        }

        private void AddNode(DataRow dr, Font boldFont, TreeGridNodeCollection nodes, bool isAddingImage)
        {
            TreeGridNode node;
            string _tempexpdate = "";

            if (Convert.ToDateTime(dr["expdate"]) != Convert.ToDateTime("01/01/2199"))
                _tempexpdate = Convert.ToDateTime(dr["expdate"]).ToShortDateString();
            else
                _tempexpdate = "";

            node = nodes.Add(null, dr["artid"], dr["artid"], dr["article"], dr["batch"], dr["batchdetid"], "", "0",
                             0, 0, 0, dr["unit"], dr["label"], dr["qtystock"], "->", 0, dr["qtystock"],
                             dr["place"], _tempexpdate, "", dr["usage"], dr["placeid"]);


            if (Convert.ToInt32(node.Parent.Cells["cn_BatchId"].Value) == Convert.ToInt32(dr["batchdetid"]))
            {//Color
                foreach (DataGridViewCell cell in node.Cells)
                {
                    cell.Style.BackColor = Color.FromArgb(192, 255, 192);
                }
            }
            else if (Convert.ToInt32(dr["usage"]) == 0)
            {
                foreach (DataGridViewCell cell in node.Cells)
                {
                    cell.Style.BackColor = Color.LightGray;
                }
            }
            else if (Convert.ToInt32(node.Parent.Cells["cn_BatchId"].Value) != Convert.ToInt32(dr["batchdetid"])
                    && Convert.ToInt32(dr["batchdetid"]) != 0)
            {
                foreach (DataGridViewCell cell in node.Cells)
                {
                    cell.Style.BackColor = Color.PapayaWhip;//Color.FromArgb(255, 224, 192);
                }
            }
            else
            {

            }


            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }

        }
               
        #endregion

        #region Controls


        #region Context menu


        //private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
        //        DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

        //        RowIndex = info.RowIndex;
        //        ColumnIndex = info.ColumnIndex;
        //        //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

        //        gv_List.ClearSelection();
        //        gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
        //        gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

        //        CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
        //        ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
        //        //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

        //    }
        //    catch
        //    {
        //        RowIndex = 0;
        //        ColumnIndex = 0;
        //        return;
        //    }
        //}

        //private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
        //    }
        //    catch
        //    { }
        //    SetCellsColor();

        //}

        //private void mni_Search_Click(object sender, EventArgs e)
        //{
        //    frm_Find frm = new frm_Find();
        //    frm.grid = gv_List;
        //    frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
        //    frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
        //    frm.ShowDialog();

        //}

        //private void mni_FilterBy_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (String.IsNullOrEmpty(bs_List.Filter) == true)
        //        {
        //            if (String.IsNullOrEmpty(CellValue) == true)
        //                bs_List.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
        //            else
        //                bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
        //        }
        //        else
        //        {
        //            if (String.IsNullOrEmpty(CellValue) == true)
        //                bs_List.Filter = bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
        //            else
        //                bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
        //        }
        //        //MessageBox.Show(bs_List.Filter);

        //    }
        //    catch { }
        //    SetCellsColor();


        //}

        //private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (String.IsNullOrEmpty(bs_List.Filter) == true)
        //            bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
        //        else
        //            bs_List.Filter = bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
        //    }
        //    catch { }
        //    SetCellsColor();

        //}

        //private void mni_RemoveFilter_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bs_List.RemoveFilter();
        //    }
        //    catch { }
        //    SetCellsColor();


        //}

        //private void mni_Copy_Click(object sender, EventArgs e)
        //{
        //    Clipboard.SetText(CellValue.ToString());
        //}

        //private void mni_Admin_Click(object sender, EventArgs e)
        //{
        //    frm_GridViewAdm frm = new frm_GridViewAdm();

        //    frm.HeaderText = "Select view for confirmation orders list";
        //    frm.grid = this.gv_List;
        //    frm.formname = this.Name;
        //    DAL.UserLogin = System.Environment.UserName;
        //    frm.UserId = DAL.UserId;

        //    frm.FillData(frm.grid);

        //    DialogResult result = frm.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
        //        LoadColumns(gv_List);
        //    }
        //}

        //private void btn_Excel_Click(object sender, EventArgs e)
        //{
        //    ED.DgvIntoExcel();
        //}

        #endregion


        #region ContextMenuD

        private void mni_SearchD_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Dets;
            frm.ColumnNumber = gv_Dets.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Dets.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

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
                if (String.IsNullOrEmpty(bs_Dets.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_Dets.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_Dets.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_Dets.Filter = bs_Dets.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_Dets.Filter = bs_Dets.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColorDets();
        }

        private void mni_FilterExcludingSelD_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Dets.Filter) == true)
                    bs_Dets.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
                else
                    bs_Dets.Filter = bs_Dets.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
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

            frm.HeaderText = "Select view for confirmation orders list";
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


        private void frm_StockOut_Resize(object sender, EventArgs e)
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

        private void frm_StockOut_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_Dets);
        }

        public void ShowHead(int id)
        {
            CmbBll.OutDocHeadId = id;
            txt_DocDate.Text = CmbBll.OutDocDocDate;
            txt_Comments.Text = CmbBll.OutDocComments;
            txt_Type.Text = CmbBll.OutDocType;
            txt_Reason.Text = CmbBll.OutDocReason;

        }

        public void ShowDets(int id)
        {
            //MessageBox.Show(cmb_OutcomeDocs1.OutcomeDocId.ToString());
            //bwStart(bw_Dets);
            var data = StockOut_BLL.getStockOutDets(cmb_OutcomeDocs1.OutcomeDocId);

            gv_Dets.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_Dets.SortedColumn;
                var dir = Helper.SaveDirection(gv_Dets);
                              

                gv_Dets.AutoGenerateColumns = false;
                bs_Dets.DataSource = data;
                gv_Dets.DataSource = bs_Dets;

                SetCellsColor();

                Helper.RestoreDirection(gv_Dets, oldColumn, dir);
            });


            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_Dets;
            });
        }

        public void RecalcTotalForParent(TreeGridNode node)
        {
            double _Total = 0;
            foreach (TreeGridNode node1 in node.Nodes)
            {
                _Total = _Total + Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);
            }
            node.Cells["cn_QtyToGive"].Value = _Total;
            //Color and font
            node.Cells["cn_QtyToGive"].Style.ForeColor = Color.Red;
            Font boldFont = new Font(tgv_List.DefaultCellStyle.Font, FontStyle.Bold);
            node.Cells["cn_QtyToGive"].Style.Font = boldFont;

            if (_Total > Convert.ToDouble(node.Cells["cn_LeftInBatch"].Value))
            {
                node.Cells["cn_QtyToGive"].Style.BackColor = Color.FromArgb(255, 224, 192);
            }
            else
            {
                node.Cells["cn_QtyToGive"].Style.BackColor = Color.Azure;//Color.FromArgb(192, 255, 192);
            }

            //If request
            //if (cmb_Requests1.RequestId != 0)
            //{
            //    if (Convert.ToDouble(node.Cells["cn_Reserved"].Value) < Convert.ToDouble(node.Cells["cn_QtyToGive"].Value))
            //    {
            //        node.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node.Cells["cn_Reserved"].Value);
            //        RecalcChildrens(node);
            //    }
            //}
            //Check for closing of request
            //if (Convert.ToDouble(node.Cells["cn_Reserved"].Value) <= _Total)
            //    node.Cells["chk_Close"].Value = -1;
            //else
            //    node.Cells["chk_Close"].Value = 0;

        }

        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
            
            if (cmb_Batches1.BatchId != 0
                || cmb_Requests1.RequestId != 0)
                Mode = 1;
            else
                Mode = 2;
        }

        private void cmb_OutcomeDocs1_OutDocChanged(object sender)
        {
            if (PrevDocId != cmb_OutcomeDocs1.OutcomeDocId)
            {
                ShowHead(cmb_OutcomeDocs1.OutcomeDocId);
                ShowDets(cmb_OutcomeDocs1.OutcomeDocId);

                PrevDocId = cmb_OutcomeDocs1.OutcomeDocId;
            }

        }


        private void cmb_OutcomeDocs1_OutDocSaved(object sender)
        {
            ShowHead(cmb_OutcomeDocs1.OutcomeDocId);
            //cmb_Batches1.BatchId = cmb_OutcomeDocs1.BatchId;
            //bwStart(bw_List);
        }

        private void tgv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 14)
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

        private void txt_Label_Validating(object sender, CancelEventArgs e)
        {
            cmb_Articles1.ArticleId = Inventory.ArtIdFromLabel(Label);
        }

        private void tgv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TreeGridNode node = tgv_List.CurrentNode;
            TreeGridNode parentnode = node.Parent;

            tgv_List.EndEdit();
            if (tgv_List.CurrentRow.Cells["btn_Give"].Selected == true)
            {
                if (Mode == 1)
                {
                    #region Batches
                    if (Convert.ToInt32(tgv_List.CurrentRow.Cells["cn_Label"].Value) == 0)
                    {
                        //FIFO
                        double _QtyReserved = Convert.ToDouble(node.Cells["cn_Reserved"].Value);
                        double _QtyLeft = Convert.ToDouble(node.Cells["cn_LeftInBatch"].Value);
                        double _QtyAvailable = Convert.ToDouble(node.Cells["cn_Available"].Value);

                        double _ForOut = 0;
                        if (cmb_Requests1.RequestId != 0)
                            _ForOut = _QtyReserved < _QtyAvailable ? _QtyReserved : _QtyAvailable;
                        else
                            _ForOut = _QtyAvailable + _QtyReserved < _QtyLeft ? _QtyAvailable + _QtyReserved : _QtyLeft;
                        

                        int _BatchDetId = Convert.ToInt32(node.Cells["cn_BatchId"].Value);

                        foreach (TreeGridNode node1 in node.Nodes)
                        {
                            node1.Cells["cn_QtyToGive"].Value = 0;
                        }

                        //MessageBox.Show(Mode.ToString());

                        foreach (TreeGridNode node1 in node.Nodes)
                        {
                            //if (Convert.ToDateTime(DocDate) >= Convert.ToDateTime(node1.Cells["cn_InDate"].Value.ToString()))
                            //{
                            if (Convert.ToInt32(node1.Cells["cn_Usage"].Value) != 0
                                && (Convert.ToInt32(node1.Cells["cn_BatchId"].Value) == _BatchDetId
                                || Convert.ToInt32(node1.Cells["cn_BatchId"].Value) == 0))
                            {
                                if (Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) < _ForOut)
                                {
                                    node1.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value);
                                    node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);
                                    _ForOut = _ForOut - Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value);
                                }
                                else
                                {
                                    node1.Cells["cn_QtyToGive"].Value = _ForOut;
                                    node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);

                                    break;
                                }
                            }
                            //}
                        }
                        RecalcTotalForParent(node);
                    }
                    else
                    {
                        //MANUAL
                        double _Diff = 0;

                        //MessageBox.Show(Convert.ToDateTime(DocDate).ToString() + "/" + Convert.ToDateTime(parentnode.Cells["cn_InDate"].Value.ToString()).ToString());
                        if (cmb_Requests1.RequestId != 0)
                            _Diff = Convert.ToDouble(parentnode.Cells["cn_Available"].Value) - Convert.ToDouble(parentnode.Cells["cn_QtyToGive"].Value);
                        else
                            _Diff = Convert.ToDouble(parentnode.Cells["cn_Reserved"].Value) - Convert.ToDouble(parentnode.Cells["cn_QtyToGive"].Value);

                        if (_Diff > 0)
                        {
                            //if (Convert.ToDateTime(DocDate) >= Convert.ToDateTime(node.Cells["cn_InDate"].Value.ToString()))
                            //{

                            if (_Diff < Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value))
                            {
                                node.Cells["cn_QtyToGive"].Value = _Diff;
                                

                            }
                            else
                            {
                                node.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value);
                            }
                            node.Cells["cn_QtyRest"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node.Cells["cn_QtyToGive"].Value);
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Outcome date can't be earlier than income date!");
                            //}
                        }

                        RecalcTotalForParent(parentnode);

                    }
                    #endregion
                }
                else
                {
                    #region Articles
                    if (Convert.ToInt32(tgv_List.CurrentRow.Cells["cn_Label"].Value) == 0)
                    {
                        //FIFO
                        if (Convert.ToDouble(node.Cells["cn_QtyToGive"].Value) == 0)
                            node.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value);

                        double _QtyLeft = Convert.ToDouble(node.Cells["cn_QtyToGive"].Value);
                        double _QtyAvailable = Convert.ToDouble(node.Cells["cn_Available"].Value);

                        double _ForOut = _QtyAvailable < _QtyLeft ? _QtyAvailable : _QtyLeft;


                        foreach (TreeGridNode node1 in node.Nodes)
                        {
                            node1.Cells["cn_QtyToGive"].Value = 0;
                        }

                        foreach (TreeGridNode node1 in node.Nodes)
                        {
                            if (Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) < _ForOut)
                            {
                                node1.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value);
                                node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);
                                _ForOut = _ForOut - Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value);
                            }
                            else
                            {
                                node1.Cells["cn_QtyToGive"].Value = _ForOut;
                                node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);

                                break;
                            }


                            //if (Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) < _QtyLeft)
                            //{
                            //    node1.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value);
                            //    node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);
                            //    _QtyLeft = _QtyLeft - Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value);
                            //}
                            //else
                            //{
                            //    node1.Cells["cn_QtyToGive"].Value = _QtyLeft;
                            //    node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);

                            //    _QtyLeft = 0;
                            //    break;
                            //}

                        }
                        RecalcTotalForParent(node);
                    }
                    else
                    {
                        //MANUAL
                        //double _Diff = 0;


                        //_Diff = Convert.ToDouble(parentnode.Cells["cn_QtyToGive"].Value);

                        //if (_Diff > 0)
                        //{
                            //if (Convert.ToDateTime(DocDate) >= Convert.ToDateTime(node.Cells["cn_InDate"].Value.ToString()))
                            //{

                        //    if (_Diff < Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value))
                        //        node.Cells["cn_QtyToGive"].Value = _Diff;
                        //    else
                                node.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value);
                                node.Cells["cn_QtyRest"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node.Cells["cn_QtyToGive"].Value);

                        //}
                        //else
                        //{
                        //    MessageBox.Show("Outcome date can't be earlier than income date!");
                        //}
                        // }

                        RecalcTotalForParent(parentnode);

                    }
                    #endregion
                }
            }
        }

        private void RecalcChildrens(TreeGridNode node)
        {
            double _ForOut = Convert.ToDouble(node.Cells["cn_QtyToGive"].Value);
            int _BatchDetId = Convert.ToInt32(node.Cells["cn_BatchId"].Value);
            foreach (TreeGridNode node1 in node.Nodes)
            {
                node1.Cells["cn_QtyToGive"].Value = 0;
                node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);
            }
            foreach (TreeGridNode node1 in node.Nodes)
            {
                if (Convert.ToInt32(node1.Cells["cn_Usage"].Value) != 0
                    && (Convert.ToInt32(node1.Cells["cn_BatchId"].Value) == _BatchDetId
                    || Convert.ToInt32(node1.Cells["cn_BatchId"].Value) == 0))
                {
                    if (Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) < _ForOut)
                    {
                        node1.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value);
                        node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);
                        _ForOut = _ForOut - Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value);
                    }
                    else
                    {
                        node1.Cells["cn_QtyToGive"].Value = _ForOut;
                        node1.Cells["cn_QtyRest"].Value = Convert.ToDouble(node1.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value);

                        break;
                    }
                }                
            }

        }

        private void tgv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double OutVal = 0;
            double RetVal = 0;
            try
            {
                TreeGridNode node = tgv_List.CurrentNode;
                TreeGridNode parentnode = node.Parent;

                tgv_List.EndEdit();
                if (tgv_List.CurrentRow.Cells["cn_QtyToGive"].Selected == true)
                {
                    //if (Convert.ToDateTime(DocDate) >= Convert.ToDateTime(node.Cells["cn_InDate"].Value.ToString()))
                    //{

                    try
                    { OutVal = Convert.ToDouble(node.Cells["cn_QtyToGive"].Value); }
                    catch { OutVal = -1; }

                    if (OutVal == -1)
                        node.Cells["cn_QtyToGive"].Value = 0;


                    if (Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value) < Convert.ToDouble(node.Cells["cn_QtyToGive"].Value))
                        node.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value);

                    node.Cells["cn_QtyRest"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node.Cells["cn_QtyToGive"].Value);

                    double _QtyReserved = 0;
                    double _QtyLeft = 0;
                    double _QtyAvailable = 0;
                    double _ForOut = 0;
                    double _diff = 0;

                    if (node.HasChildren == true)
                    {
                        _QtyReserved = Convert.ToDouble(node.Cells["cn_Reserved"].Value);
                        _QtyLeft = Convert.ToDouble(node.Cells["cn_LeftInBatch"].Value);
                        _QtyAvailable = Convert.ToDouble(node.Cells["cn_Available"].Value);

                        if (cmb_Requests1.RequestId != 0)
                            _ForOut = _QtyAvailable;
                        else
                            _ForOut = _QtyAvailable + _QtyReserved;
                        if (_ForOut < Convert.ToDouble(node.Cells["cn_QtyToGive"].Value))
                        {
                            node.Cells["cn_QtyToGive"].Value = _ForOut;
                        }

                        RecalcChildrens(node);
                    }
                    else
                    {
                        RecalcTotalForParent(parentnode);

                        _QtyReserved = Convert.ToDouble(parentnode.Cells["cn_Reserved"].Value);
                        _QtyLeft = Convert.ToDouble(parentnode.Cells["cn_LeftInBatch"].Value);
                        _QtyAvailable = Convert.ToDouble(parentnode.Cells["cn_Available"].Value);

                        if (cmb_Requests1.RequestId != 0)
                            _ForOut = _QtyAvailable;
                        else
                            _ForOut = _QtyAvailable + _QtyReserved;

                        if (_ForOut < Convert.ToDouble(parentnode.Cells["cn_QtyToGive"].Value))
                        {
                            _diff = Convert.ToDouble(parentnode.Cells["cn_QtyToGive"].Value) - _ForOut;

                            DialogResult result1 = KryptonTaskDialog.Show("Qty warning!",
                                                                       "You can't give qty more than available!",
                                                                       "",
                                                                       MessageBoxIcon.Stop,
                                                                       TaskDialogButtons.OK);
                            node.Cells["cn_QtyToGive"].Value = Convert.ToInt32(node.Cells["cn_QtyToGive"].Value) - _diff;
                            node.Cells["cn_QtyRest"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node.Cells["cn_QtyToGive"].Value);

                            RecalcTotalForParent(parentnode);
                        }
                    }


                }


                if (tgv_List.CurrentRow.Cells["cn_QtyRest"].Selected == true)
                {
                    try
                    { RetVal = Convert.ToDouble(node.Cells["cn_QtyRest"].Value); }
                    catch { RetVal = -1; }

                    if (RetVal == -1)
                        node.Cells["cn_QtyRest"].Value = 0;

                    if (Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value) < Convert.ToDouble(node.Cells["cn_QtyRest"].Value))
                        node.Cells["cn_QtyRest"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value);

                    node.Cells["cn_QtyToGive"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node.Cells["cn_QtyRest"].Value);

                    double _QtyReserved = 0;
                    double _QtyLeft = 0;
                    double _QtyAvailable = 0;
                    double _ForOut = 0;
                    double _diff = 0;

                    if (node.HasChildren == true)
                    {
                        _QtyReserved = Convert.ToDouble(node.Cells["cn_Reserved"].Value);
                        _QtyLeft = Convert.ToDouble(node.Cells["cn_LeftInBatch"].Value);
                        _QtyAvailable = Convert.ToDouble(node.Cells["cn_Available"].Value);

                        if (cmb_Requests1.RequestId != 0)
                            _ForOut = _QtyAvailable;
                        else
                            _ForOut = _QtyAvailable + _QtyReserved;
                        if (_ForOut < Convert.ToDouble(node.Cells["cn_QtyToGive"].Value))
                        {
                            node.Cells["cn_QtyToGive"].Value = _ForOut;
                        }

                        RecalcChildrens(node);
                    }
                    else
                    {
                        RecalcTotalForParent(parentnode);

                        _QtyReserved = Convert.ToDouble(parentnode.Cells["cn_Reserved"].Value);
                        _QtyLeft = Convert.ToDouble(parentnode.Cells["cn_LeftInBatch"].Value);
                        _QtyAvailable = Convert.ToDouble(parentnode.Cells["cn_Available"].Value);

                        if (cmb_Requests1.RequestId != 0)
                            _ForOut = _QtyAvailable;
                        else
                            _ForOut = _QtyAvailable + _QtyReserved;

                        if (_ForOut < Convert.ToDouble(parentnode.Cells["cn_QtyToGive"].Value))
                        {
                            _diff = Convert.ToDouble(parentnode.Cells["cn_QtyToGive"].Value) - _ForOut;

                            DialogResult result1 = KryptonTaskDialog.Show("Qty warning!",
                                                                       "You can't give qty more than available!",
                                                                       "",
                                                                       MessageBoxIcon.Stop,
                                                                       TaskDialogButtons.OK);
                            node.Cells["cn_QtyToGive"].Value = Convert.ToInt32(node.Cells["cn_QtyToGive"].Value) - _diff;
                            node.Cells["cn_QtyRest"].Value = Convert.ToDouble(node.Cells["cn_QtyOnLabel"].Value) - Convert.ToDouble(node.Cells["cn_QtyToGive"].Value);

                            RecalcTotalForParent(parentnode);
                        }
                    }

                }
                //}
            }
            catch { }
        }

        private void btn_ClearList_Click(object sender, EventArgs e)
        {
            tgv_List.Nodes.Clear();
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Expand_Click(object sender, EventArgs e)
        {
            foreach (TreeGridNode node in tgv_List.Nodes)
            {
                node.Expand();
            }
        }

        private void btn_Collapse_Click(object sender, EventArgs e)
        {
            foreach (TreeGridNode node in tgv_List.Nodes)
            {
                node.Collapse();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            
            int _res = cmb_OutcomeDocs1.OutcomeDocId;
            int _resmove = 0;
            if (cmb_OutcomeDocs1.OutcomeDocId != 0)
            {
                int _removereservation = 0;

                foreach (TreeGridNode node in this.tgv_List.Nodes)
                {
                    ExpandNodes(node);
                
                    int _batchdetid = Convert.ToInt32(node.Cells["cn_BatchId"].Value);
                    int _requestid = Convert.ToInt32(node.Cells["cn_RequestId"].Value);
                    int _artid = Convert.ToInt32(node.Cells["cn_ArtId"].Value);
                    double _qtytogive = Convert.ToDouble(node.Cells["cn_QtyToGive"].Value);
                    double _qtyrest = Convert.ToDouble(node.Cells["cn_LeftInBatch"].Value);

                    //if (_batchdetid != 0
                    //            && _qtytogive >= _qtyrest)
                    //    _removereservation = -1;

                        //Labels
                    foreach (TreeGridNode node1 in node.Nodes)
                    {
                        if (Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value) > 0)
                        {
                                //Remove reservation
                            if (Convert.ToInt32(node1.Cells["cn_PlaceId"].Value) != cmb_Places1.PlaceId
                                && cmb_Places1.PlaceId != 0
                                && Convert.ToInt32(node1.Cells["cn_BatchId"].Value) == _batchdetid
                                && _batchdetid != 0
                                && Convert.ToDouble(node1.Cells["cn_QtyRest"].Value) > 0
                                || (_batchdetid != 0
                                && _qtytogive >= _qtyrest))
                                _removereservation = -1;

                            //Esli rashod s drugoj partii - ne ubiraem rezervaciju
                            if (Convert.ToInt32(node1.Cells["cn_BatchId"].Value) != _batchdetid
                                && Convert.ToDouble(node1.Cells["cn_QtyRest"].Value) > 0)
                                _removereservation = 0;

                            //Add stock out
                            _res = SOBll.AddStockOutLine(_res, Convert.ToInt32(node1.Cells["cn_Label"].Value),
                                                        Convert.ToDouble(node1.Cells["cn_QtyToGive"].Value),
                                                        _artid, _batchdetid, _requestid,
                                                        node1.Cells["cn_Comments"].Value.ToString());
                            //Free labels
                            if (_removereservation == -1)
                                _resmove =  SMBll.AddStockMoveLine(_resmove,
                                                            Convert.ToInt32(node1.Cells["cn_Label"].Value),
                                                            Convert.ToDouble(node1.Cells["cn_QtyRest"].Value),
                                                            cmb_Places1.PlaceId,
                                                            _batchdetid,
                                                            0,
                                                            cmb_Batches1.BatchId, 
                                                            0, 
                                                            0,
                                                            "Removing of reservation of " + node1.Cells["cn_Batch"].Value.ToString());
                            //Remove reservation if qty to return > 0
                            if (Convert.ToDouble(node1.Cells["cn_QtyRest"].Value) == 0)
                                SOBll.RemoveLabelReservation(Convert.ToInt32(node1.Cells["cn_Label"].Value));
                        }                       
                    }
                }
                if (_res != 0)
                {
                    //Sending letter about stockout for fixed assets
                    SqlConnection sqlConn = new SqlConnection(sConnStr);
                    SqlCommand sqlComm = new SqlCommand("sp_SelectFixedAssetsOutcomes", sqlConn);
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
                            strMessage = strMessage + "\r\nPlace: " + reader["place"].ToString();
                            strMessage = strMessage + "\r\nSupplier: " + reader["supplier"].ToString();

                        }

                        reader.Close();
                        if (emailaddresses != "")
                        {
                            MyHelper.SendMessage(emailaddresses, "Fixed asset stock outcomes!", strMessage);
                        }

                    }
                    sqlConn.Close();
                }
                SOBll.UpdateSetPrice(_res);
            

            if (cmb_OutcomeDocs1.OutcomeDocId != _res)
                cmb_OutcomeDocs1.OutcomeDocId = _res;
            else
                ShowDets(cmb_OutcomeDocs1.OutcomeDocId);

            bwStart(bw_List);
            //}
            //else
            //{
            //    DialogResult result = KryptonTaskDialog.Show("Quantity counsumption warning!",
            //                                                    "Saving impossible!",
            //                                                    "Outcome document is not selected.",
            //                                                    MessageBoxIcon.Warning,
            //                                                    TaskDialogButtons.OK);

            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            frm_rptStockOut frm = new frm_rptStockOut();
            //frm.FillDataSet();
            frm.DocDate = CmbBll.OutDocDocDate;
            frm.DocName = cmb_OutcomeDocs1.OutcomeDoc;
            frm.OutcomeDocId = cmb_OutcomeDocs1.OutcomeDocId;
            frm.DocReason = CmbBll.OutDocReason;

            frm.Show();
        }

        private void cmb_Places1_SelectedValueChanged(object sender)
        {
            //foreach (DataGridViewRow row in tgv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_PlaceId"].Value) != 0
            //        && Convert.ToInt32(row.Cells["cn_PlaceId"].Value) != cmb_Places1.PlaceId
            //        && cmb_Places1.PlaceId != 0)
            //    {
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            cell.Style.BackColor = Color.WhiteSmoke;
            //        }
            //    }
            //}
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_Dets.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                SOBll.DeleteStockOutLine(_id);
                ShowDets(cmb_OutcomeDocs1.OutcomeDocId);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            bs_List.RemoveFilter();
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            frm_SetManagement frm = new frm_SetManagement();

            frm.HeaderText = "Add assembling for this outcome document";
            frm.CheckEmpty();
            DialogResult result = frm.ShowDialog();

            if (cmb_OutcomeDocs1.OutcomeDocId != 0
                && String.IsNullOrEmpty(txt_DocDate.Text) == false
                && result == DialogResult.OK)

            {
                //MessageBox.Show(cmb_OutcomeDocs1.OutcomeDocId.ToString());
                //Add new income doc
                int _idin = SOBll.AddStockSetHeader(cmb_OutcomeDocs1.OutcomeDocId, frm.BatchId, frm.ArtId, frm.Qty, txt_DocDate.Text, frm.Comments, frm.PlaceId);
                //Recalculate it's price
                if (_idin != 0)
                {

                    SOBll.UpdateSetActPrice(_idin, txt_DocDate.Text);

                    DialogResult result1 = KryptonTaskDialog.Show("Assembling document was created!",
                                                                   "Document: " + SOBll.TmpInsertedDoc,
                                                                   "",
                                                                   MessageBoxIcon.Information,
                                                                   TaskDialogButtons.OK);
                }
                else
                {
                    DialogResult result1 = KryptonTaskDialog.Show("Assembling document was not created!",
                                                                  "There are no suitable records for it!",
                                                                  "",
                                                                  MessageBoxIcon.Information,
                                                                  TaskDialogButtons.OK);
                }
            }

        }

        private void mni_LabelDets_Click(object sender, EventArgs e)
        {
            int _label = 0;

            try { _label = Convert.ToInt32(tgv_List.CurrentRow.Cells["cn_Label"].Value); }
            catch { }

            if (_label != 0)
            {
                Form f;
                f = this.FindForm();

                Point LocationPoint = tgv_List.PointToScreen(Point.Empty);
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

        private void btn_EnabledRequests_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = btn_EnabledRequests.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X + 100;
            int ypos = LocationPoint.Y;
            Point _location = new Point(xpos, ypos);

            frm_EnabledRequests popup = new frm_EnabledRequests();
            popup.frmStockOut = this;
            
            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillList();
            
        }

        private void mnu_MapBatch_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_Dets.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_cmbBatch frm = new frm_cmbBatch();

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && frm.BatchId != 0)
                {
                    SOBll.MapLineToBatch(_id, frm.BatchId);
                    ShowDets(cmb_OutcomeDocs1.OutcomeDocId);
                }
            }
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            if (cmb_Batches1.BatchId != 0
                && cmb_Batches1.IsActive == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
            if (cmb_Batches1.BatchId == 0)
                tgv_List.Nodes.Clear();


            if (cmb_Batches1.BatchId != 0)
            {
                string _res = DAL.AddBatchLock(cmb_Batches1.BatchId, this.Name);
                if (_res != "")
                {
                    DialogResult result1 = KryptonTaskDialog.Show("You can not work with such batch!",
                                                                 "This batch is locked by: " + _res,
                                                                 "",
                                                                 MessageBoxIcon.Warning,
                                                                 TaskDialogButtons.OK);
                    cmb_Batches1.BatchId = 0;
                }
            }
            else
            {
                DAL.DeleteBatchLock(cmb_Batches1.BatchId, this.Name);
            }
        }

        private void frm_StockOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            DAL.DeleteBatchLock(cmb_Batches1.BatchId, this.Name);
        }

       
    }
}
