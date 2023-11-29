using AdvancedDataGridView;
using ComponentFactory.Krypton.Toolkit;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using Odin.Global_Classes;
using Odin.Register;
using Odin.Register.Catalog;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Purchase
{
    public partial class frm_NeedsProcessing : BaseForm
    {
        public frm_NeedsProcessing()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "NeedsHeadersList.xls", this.Name);
            ED1 = new ExportData(this.gv_List, "NeedsPOsList.xls", this.Name);
        }


        #region Variables

        private frm_Wait fmWait = null;
        private HSSFWorkbook hssfworkbook;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        PO_BLL POBll = new PO_BLL();
        Reg_BLL RegBll = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        ExportData ED1;
        Helper MyHelper = new Helper();
        frm_AddCatItem frmcat = null;
        public string fileName
        {
            get;
            set;
        }

        public int ControlWidth = 250;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int RowIndexPO = 0;
        public int ColumnIndexPO = 0;
        public string ColumnNamePO = "";
        public string CellValuePO = "";

        public int RowIndexD = 0;
        public int ColumnIndexD = 0;
        public string ColumnNameD = "";
        public string CellValueD = "";

        frm_DownloadCatItems frm = null;

        int _previd = 0;
        public int PrevId
        {
            get { return _previd; }
            set { _previd = value; }
        }

        int _prevartid = 0;

        public int PrevArtId
        {
            get { return _prevartid; }
            set { _prevartid = value; }
        }


        //Font FontOK = new Font(tv_Details.DefaultCellStyle.Font, FontStyle.Bold, );

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

            var data = PO_BLL.getNeedsHeaders(cmb_Batches1.BatchId, chk_active.Checked == true ? -1 : 0);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
                //SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            //MessageBox.Show(cmb_Articles1.QtyAvail.ToString());

        }

        public void NeedsAdded(object sender)
        {
            bwStart(bw_List);
        }

        public void FillGrid(int needid)
        {
            tv_Details.Nodes.Clear();
            Font boldFont = new Font(tv_Details.DefaultCellStyle.Font, FontStyle.Bold);

            var data = PO_BLL.getNeedsDetails(needid);

            foreach (System.Data.DataRow dr in data.AsEnumerable().OrderBy(d => d.Field<string>("article")))
            {
                AddNode(dr, boldFont, tv_Details.Nodes, true, true);
            }

            //FillGridDets();
            FillGridDets1();

            tv_Details.Focus();
            foreach (TreeGridNode node1 in tv_Details.Nodes)
            {
                ExpandNodes(node1);
            }
            SetCellsColor();
        }

        public void FillPOGrid(int needid)
        {
            var data = PO_BLL.getNeedsPOs(needid);

            gv_POList.ThreadSafeCall(delegate
            {
                gv_POList.AutoGenerateColumns = false;
                bs_POList.DataSource = data;
                gv_POList.DataSource = bs_POList;
                //SetCellsColor();
            });


            bn_POList.ThreadSafeCall(delegate
            {
                bn_POList.BindingSource = bs_POList;
            });
        }
        public void SetCellsColor()
        {
            Font boldFont = new Font(tv_Details.DefaultCellStyle.Font, FontStyle.Bold);
            try
            {
                foreach (TreeGridNode node in tv_Details.Nodes)
                {
                    if (Convert.ToInt32(node.Cells["cn_dstate"].Value) == 0)
                    {
                        node.DefaultCellStyle.BackColor = Color.Gainsboro;
                        foreach (TreeGridNode nodechild in node.Nodes)
                            nodechild.DefaultCellStyle.BackColor = Color.Gainsboro;
                    }
                    if (Math.Round(Convert.ToDouble(node.Cells["cn_dqtyneed"].Value), 5) != Math.Round(Convert.ToDouble(node.Cells["cn_dqtyinpo"].Value), 5))
                        node.Cells["cn_dqtyinpo"].Style.ForeColor = Color.Red;
                    else
                    {
                        node.Cells["cn_dqtyinpo"].Style.ForeColor = Color.Green;
                        node.Cells["cn_dqtyinpo"].Style.Font = boldFont;
                    }
                }
                //foreach (DataGridViewRow row in this.tv_BOM.Rows)
                //{
                //    row.Cells["cn_nQtyDefault"].Style.BackColor = Color.Silver;
                //    if (Convert.ToDouble(row.Cells["cn_nSubProdQty"].Value) > 0)
                //        row.Cells["cn_nSubProdQty"].Style.BackColor = Color.Yellow;
                //    if (Convert.ToDouble(row.Cells["cn_nQtyAvailable"].Value) + Convert.ToDouble(row.Cells["cn_nWaitingPOQty"].Value)
                //                        < Convert.ToDouble(row.Cells["cn_nQtyInBatch"].Value))
                //    {
                //        foreach (DataGridViewCell cell in row.Cells)
                //        {
                //            cell.Style.BackColor = Color.MistyRose;
                //        }
                //    }
                //}
            }
            catch { }
        }

        public void SetNeedColor(int artid)
        {
            int _headid = 0;
            var data = PO_BLL.getNeedsForArticle(artid);

            foreach (DataGridViewRow row1 in this.gv_List.Rows)
            {
                _headid = Convert.ToInt32(row1.Cells["cn_id"].Value);
                var selectedid = data.Select("headid = " + _headid);

                row1.DefaultCellStyle.BackColor = selectedid.Length > 0 ? Color.Gold : Color.White;
            }

        }
        private void AddNode(DataRow dr, Font boldFont, TreeGridNodeCollection nodes, bool isAddingImage, bool useBold)
        {
            TreeGridNode node;

            node = nodes.Add(null,
                            dr["article"],
                            dr["artid"],
                            dr["secname"],
                            dr["unit"],
                            dr["supplier"],
                            Convert.ToDouble(dr["qtyneeds"]),
                            "",
                            Convert.ToDouble(dr["qtyinpo"]),
                            Convert.ToDouble(dr["unitprice"]),
                            dr["currency"],
                            Convert.ToDouble(dr["unitpriceeur"]),
                            dr["datacode"],
                            dr["delivterm"],
                            Convert.ToDouble(dr["moq"]),
                            Convert.ToDouble(dr["mpq"]),
                            dr["manufacturer"],
                            dr["comments"],
                            Convert.ToInt32(dr["id"]),
                            Convert.ToInt32(dr["state"]),
                            Convert.ToInt32(dr["catid"]),
                            Convert.ToInt32(dr["pocatid"]),
                            Convert.ToDouble(dr["qtyinpo"]),
                            Convert.ToDouble(dr["techmissings"]),
                            dr["creatdate"],
                            Convert.ToDouble(dr["inproject"]),
                            dr["analogs"]);

            if (useBold == true)
                node.DefaultCellStyle.Font = boldFont;

            if (isAddingImage)
            {
                node.ImageIndex = 1;
            }

        }

        //public void FillGridDets()
        //{
        //    Font boldFont = new Font(tv_Details.DefaultCellStyle.Font, FontStyle.Bold);

        //    foreach (TreeGridNode node in tv_Details.Nodes)
        //    {
        //        var data1 = PO_BLL.getNeedsDetailsCat(Convert.ToInt32(node.Cells["cn_did"].Value));

        //        if (data1.Rows.Count > 0)
        //        {
        //            node.Expand();
        //            foreach (System.Data.DataRow dr1 in data1.AsEnumerable().OrderByDescending(d => d.Field<int>("catid")))
        //            {
        //                AddNode(dr1, boldFont, node.Nodes, true, false);
        //            }
        //            node.Collapse();
        //        }
        //    }
        //}
        public void FillGridDets1()
        {
            Font boldFont = new Font(tv_Details.DefaultCellStyle.Font, FontStyle.Bold);

            var data1 = PO_BLL.getNeedsDetailsCat(Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value));

            if (data1.Rows.Count > 0)
            {
                foreach (System.Data.DataRow dr1 in data1.AsEnumerable().OrderBy(d => d.Field<int>("id")).ThenByDescending(d => d.Field<int>("catid")))
                {
                    foreach (TreeGridNode node in tv_Details.Nodes)
                    {
                        if (Convert.ToInt32(node.Cells["cn_did"].Value) == Convert.ToInt32(dr1["id"]))
                            AddNode(dr1, boldFont, node.Nodes, true, false);
                    }
                }
            }
        }
        public void ExpandNodes(TreeGridNode node)
        {
            foreach (TreeGridNode node1 in node.Nodes)
            {
                node.Expand();
                ExpandNodes(node1);
            }
        }

        public void CatAdded(object sender)
        {
            Font boldFont = new Font(tv_Details.DefaultCellStyle.Font, FontStyle.Bold);

            int NewLineId = 0;

            NewLineId = RegBll.AddCatalogItem(frmcat.BargType, frmcat.ArticleId, frmcat.FirmId, frmcat.FirmArt,
                                            frmcat.UnitId, frmcat.UnitPrice, frmcat.CurId, frmcat.Manufacturer, frmcat.Comments,
                                            frmcat.DelivTerms, frmcat.MOQ, frmcat.MPQ, frmcat.AsDefault, "",
                                            Convert.ToInt32(frmcat.Vat), frmcat.MinExpDays, frmcat.CoefConv, frmcat.DataCode, frmcat.DelivTermTxt,
                                            frmcat.Quoted, frmcat.BarCode, frmcat.ForCustomer);

            TreeGridNode node = tv_Details.CurrentNode;
            if (node.Level == 2)
                node = node.Parent;
            node.Nodes.Clear();

            var data1 = PO_BLL.getNeedsDetailsCatDet(Convert.ToInt32(node.Cells["cn_did"].Value));

            if (data1.Rows.Count > 0)
            {
                node.Expand();
                foreach (System.Data.DataRow dr1 in data1.AsEnumerable().OrderByDescending(d => d.Field<int>("catid")))
                {
                    AddNode(dr1, boldFont, node.Nodes, true, false);
                }
                node.Collapse();
            }

            ExpandNodes(node);

            frmcat.Close();
        }

        public double MOQMPQ(double Qty, double MOQ, double MPQ)
        {
            double Ret = 0;

            if (Qty > 0)
            {
                if (Qty < MOQ)
                {
                    Ret = globClass.ApprovePOMOQ() == true ? MOQ : Qty;
                }
                else
                {
                    if (MPQ > 0)
                    {
                        Ret = Math.Round((Qty % MPQ), 5) == 0 ? Qty : globClass.ApprovePOMOQ() == true ? Qty - (Qty % MPQ) + MPQ : Qty;
                    }
                    else
                        Ret = Qty;
                }
            }

            return Ret;
        }

        #endregion

        #region Controls

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

            frm.HeaderText = "Select view for needs list";
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

        #region Context menu PO


        private void mnu_LinesPO_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_POList.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_POList.HitTest(mpoint.X, mpoint.Y);

                RowIndexPO = info.RowIndex;
                ColumnIndexPO = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_POList.ClearSelection();
                gv_POList.Rows[RowIndexPO].Cells[ColumnIndexPO].Selected = true;
                gv_POList.CurrentCell = gv_POList.Rows[RowIndexPO].Cells[ColumnIndexPO];

                CellValuePO = gv_POList.Rows[RowIndexPO].Cells[ColumnIndexPO].Value.ToString();
                ColumnNamePO = gv_POList.Columns[ColumnIndexPO].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexPO = 0;
                ColumnIndexPO = 0;
                return;
            }
        }

        private void mni_FilterForPO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_POList.Filter = ("Convert(" + ColumnNamePO + " , 'System.String') like '%" + mni_FilterForPO.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            //SetCellsColor();

        }

        private void mni_SearchPO_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_List;
            frm.ColumnNumber = gv_POList.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_POList.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterByPO_Click(object sender, EventArgs e)
        {
            try
            {
                bs_POList.Filter = String.IsNullOrEmpty(bs_POList.Filter) == true
                    ? String.IsNullOrEmpty(CellValuePO) == true
                        ? "(" + ColumnNamePO + " is null OR Convert(" + ColumnNamePO + ", 'System.String') = '')"
                        : "Convert(" + ColumnNamePO + " , 'System.String') = '" + glob_Class.NES(CellValuePO) + "'"
                    : String.IsNullOrEmpty(CellValuePO) == true
                        ? bs_POList.Filter + "AND (" + ColumnNamePO + " is null OR Convert(" + ColumnNamePO + ", 'System.String') = '')"
                        : bs_POList.Filter + " AND Convert(" + ColumnNamePO + " , 'System.String') = '" + glob_Class.NES(CellValuePO) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            //SetCellsColor();

        }

        private void mni_FilterExcludingSelPO_Click(object sender, EventArgs e)
        {
            try
            {
                bs_POList.Filter = String.IsNullOrEmpty(bs_POList.Filter) == true
                    ? "Convert(" + ColumnNamePO + " , 'System.String') <> '" + CellValuePO + "'"
                    : bs_POList.Filter + " AND " + ColumnNamePO + " <> '" + CellValuePO + "'";
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_RemoveFilterPO_Click(object sender, EventArgs e)
        {
            try
            {
                bs_POList.RemoveFilter();
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_CopyPO_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValuePO.ToString());
        }

        private void mni_AdminPO_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view PO list";
            frm.grid = this.gv_POList;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_POList);
            }
        }

        #endregion

        #region Context menu Details


        private void mnu_DLines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = tv_Details.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = tv_Details.HitTest(mpoint.X, mpoint.Y);

                RowIndexD = info.RowIndex;
                ColumnIndexD = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                tv_Details.ClearSelection();
                tv_Details.Rows[RowIndexD].Cells[ColumnIndexD].Selected = true;
                tv_Details.CurrentCell = tv_Details.Rows[RowIndexD].Cells[ColumnIndexD];

                CellValueD = tv_Details.Rows[RowIndexD].Cells[ColumnIndexD].Value.ToString();
                ColumnNameD = tv_Details.Columns[ColumnIndexD].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexD = 0;
                ColumnIndexD = 0;
                return;
            }
        }


        private void mni_SearchD_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = tv_Details;
            frm.ColumnNumber = tv_Details.CurrentCell.ColumnIndex;
            frm.ColumnText = tv_Details.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_CopyD_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueD.ToString());
        }

        private void mni_AdminD_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view needs list";
            frm.grid = this.tv_Details;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(tv_Details);
            }
        }

        public void CatalogAdded(object sender)
        {
            //frm.Close();

            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0)
            {
                tv_Details.ThreadSafeCall(delegate { FillGrid(_id); });
            }
        }
        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
        }

        private void btn_AddNeeds_Click(object sender, EventArgs e)
        {
            frm_AddNeedsProcessing frm = new frm_AddNeedsProcessing();
            frm.NeedsAdded += new NeedsAddingEventHandler(NeedsAdded);

            frm.Show();

            frm.gv_Batches.ThreadSafeCall(delegate { frm.FillBatches(); });

        }

        private void btn_DeleteNeeds_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                MessageBox.Show(POBll.DeletePONeed(_id));
                bwStart(bw_List);
            }
        }

        private void frm_NeedsProcessing_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            LoadColumns(gv_POList);
            LoadColumns(tv_Details);

            //bn_Dets.Items.Insert(17, new ToolStripControlHost(chk_Accumulate));
        }

        private void tv_Details_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0)
            {
                if (_id != PrevId)
                {
                    FillGrid(_id);
                    FillPOGrid(_id);
                    PrevId = _id;
                }
                else
                {

                }
            }
        }


        private void tv_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            double qtyneeds = 0;
            double oldqtypo = 0;

            try
            {
                TreeGridNode node = tv_Details.CurrentNode;
                TreeGridNode parentnode = node.Parent;

                if (tv_Details.CurrentRow.Cells["btn_adddet"].Selected == true
                    && node.Level == 2)
                {
                    qtyneeds = Convert.ToDouble(parentnode.Cells["cn_dqtyneed"].Value);

                    foreach (TreeGridNode node1 in parentnode.Nodes)
                    {
                        if (node1 != node)
                            oldqtypo = oldqtypo + Convert.ToDouble(node1.Cells["cn_dqtyinpo"].Value);
                    }

                    node.Cells["cn_dqtyinpo"].Value = qtyneeds - oldqtypo < Convert.ToDouble(node.Cells["cn_dmoq"].Value) ? Convert.ToDouble(node.Cells["cn_dmoq"].Value) : qtyneeds - oldqtypo;

                    node.Cells["cn_dqtyinpo"].Value = MOQMPQ(Convert.ToDouble(node.Cells["cn_dqtyinpo"].Value), Convert.ToDouble(node.Cells["cn_dmoq"].Value), Convert.ToDouble(node.Cells["cn_dmpq"].Value));

                    RecalcTotalForParent(parentnode);
                }

            }
            catch { }
        }

        private void tv_Details_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double OutVal = 0;
            double oldqtypo = 0;
            double oldqtypototal = 0;

            try
            {
                TreeGridNode node = tv_Details.CurrentNode;
                TreeGridNode parentnode = node.Parent;

                tv_Details.EndEdit();

                if (node.Level == 2) //Rabotaem s katalogom
                {
                    if (tv_Details.CurrentRow.Cells["cn_dqtyinpo"].Selected == true)
                    {
                        oldqtypo = Convert.ToDouble(tv_Details.CurrentRow.Cells["cn_doldqtyinpo"].Value);
                        oldqtypototal = Convert.ToDouble(parentnode.Cells["cn_doldqtyinpo"].Value);

                        try
                        { OutVal = Convert.ToDouble(node.Cells["cn_dqtyinpo"].Value); }
                        catch { OutVal = -1; }

                        node.Cells["cn_dqtyinpo"].Value = OutVal == -1
                            ? 0
                            : (object)MOQMPQ(OutVal, Convert.ToDouble(tv_Details.CurrentRow.Cells["cn_dmoq"].Value), Convert.ToDouble(tv_Details.CurrentRow.Cells["cn_dmpq"].Value));

                        RecalcTotalForParent(parentnode);

                    }
                }
            }
            catch { }
        }

        public void RecalcTotalForParent(TreeGridNode node)
        {
            double _Total = 0;
            foreach (TreeGridNode node1 in node.Nodes)
            {
                _Total = _Total + Convert.ToDouble(node1.Cells["cn_dqtyinpo"].Value);
            }
            node.Cells["cn_dqtyinpo"].Value = _Total;
            SetCellsColor();
        }

        private void btn_addneeddet_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_cmbArtQty frm = new frm_cmbArtQty();
                frm.HeaderText = "Add article for selected need";

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && frm.Qty != 0
                    && frm.ArticleId != 0)
                {
                    POBll.AddNewNeedDet(_id, frm.ArticleId, frm.Qty);
                    FillGrid(_id);
                }
            }
        }

        private void btn_deleteneeddet_Click(object sender, EventArgs e)
        {
            int _needid = 0;
            try
            {
                _needid = Convert.ToInt32(tv_Details.CurrentRow.Cells["cn_did"].Value);
            }
            catch { }

            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }


            if (_needid != 0
                && glob_Class.DeleteConfirm() == true)
            {
                MessageBox.Show(POBll.DeletePONeedLine(_needid));
                FillGrid(_id);
            }
        }

        private void btn_addcatalog_Click(object sender, EventArgs e)
        {
            int _artid = 0;
            TreeGridNode node = tv_Details.CurrentNode;
            _artid = Convert.ToInt32(node.Cells["cn_dartid"].Value);

            frmcat = new frm_AddCatItem();
            frmcat.ArticleId = _artid;
            frmcat.CatSaved += new CatSavedEventHandler(CatAdded);

            frmcat.Show();

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            tv_Details.EndEdit();
            int _needid = 0;
            foreach (TreeGridNode node in tv_Details.Nodes)
            {
                _needid = Convert.ToInt32(node.Cells["cn_did"].Value);

                ExpandNodes(node);

                foreach (TreeGridNode node1 in node.Nodes)
                {
                    if (Convert.ToDouble(node1.Cells["cn_dqtyinpo"].Value) != Convert.ToDouble(node1.Cells["cn_doldqtyinpo"].Value))
                    {

                        POBll.SavePOLineFromNeeds(_needid, Convert.ToDouble(node1.Cells["cn_dqtyinpo"].Value),
                                    Convert.ToInt32(node1.Cells["cn_dcatid"].Value));
                    }
                }
            }

            //Check for closing of Need
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }

            if (_id != 0)
            {
                int _countactive = Convert.ToInt32(Helper.GetOneRecord("select count(id) from PUR_NeedsDets where headid = " + _id + " and [state] = -1"));
                if (_countactive > 0)
                {

                }
            }

            KryptonTaskDialog.Show("Purchase orders updating",
                                   "Purchase orders was updating!",
                                   "",
                                   MessageBoxIcon.Information,
                                   TaskDialogButtons.OK);

            bwStart(bw_List);
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

            }
            catch { }

            if (_id != 0)
            {
                //if (_id != PrevId)
                //{
                FillGrid(_id);
                FillPOGrid(_id);
                PrevId = _id;
                //}
                //else
                //{

                //}
            }

        }

        private void btn_DeletePOline_Click(object sender, EventArgs e)
        {
            int _pid = 0;
            try
            {
                _pid = Convert.ToInt32(gv_POList.CurrentRow.Cells["cn_pid"].Value);
            }
            catch { }

            if (_pid != 0
                && globClass.DeleteConfirm() == true)
            {
                MessageBox.Show(POBll.DeletePOLine(_pid));

                bwStart(bw_List);
            }

        }


        #endregion

        private void btn_ExportPO_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _article = "";

            try
            {
                _id = Convert.ToInt32(tv_Details.CurrentRow.Cells["cn_dartid"].Value);
                _article = tv_Details.CurrentRow.Cells["cn_darticle"].Value.ToString();
            }
            catch { }

            var _query = "sp_SelectCatalogSupHistory";

            var sqlparams = new List<SqlParameter>()
            {
                new SqlParameter("@artid",SqlDbType.Int) {Value = _id}
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Catalog history list for: " + _article;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show();


        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            frm = new frm_DownloadCatItems();
            frm.CatalogDownloaded += new DownloadCatalogEventHandler(CatalogAdded);
            frm.Show();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //MessageBox.Show(path);
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.InitialDirectory = path;

            savefiledialog1.FileName = "Articles for quotation";
            savefiledialog1.DefaultExt = "xls";
            savefiledialog1.Filter = "Excel Files (*.xls)|*.xls|All files (*.*)|*.*";
            savefiledialog1.FilterIndex = 1;
            savefiledialog1.RestoreDirectory = true;


            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = savefiledialog1.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    //dgv.Enabled = false;
                    BackgroundWorker bw = new BackgroundWorker();
                    bw.DoWork += ImportData;

                    bw.RunWorkerCompleted += ImportCompleted;

                    fmWait = new frm_Wait();

                    bw.RunWorkerAsync();
                    fmWait.Start();
                    fmWait.Show();

                }
            }
        }

        #region Into Excel
        private void ImportCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (fmWait != null)
            {
                fmWait.Close();
                fmWait = null;

            }

            if (e.Error != null)
            {
                return;
            }

            // Check to see if the background process was cancelled.
            if (e.Cancelled)
            {
                return;
            }
        }

        private void InitializeWorkbook()
        {
            hssfworkbook = new HSSFWorkbook();

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Exported";
            hssfworkbook.SummaryInformation = si;
        }

        private void ImportData(object sender, DoWorkEventArgs e)
        {
            InitializeWorkbook();

            ISheet sheet1 = hssfworkbook.CreateSheet("Sheet1");
            var param = e.Argument as List<DataGridViewColumn>;
            //MessageBox.Show(dgv.Rows.Count.ToString());
            for (int i = 0; i < tv_Details.Nodes.Count; i++)
            {
                TreeGridNode row = tv_Details.Nodes[i]; // rows
                IRow rowExcel = sheet1.CreateRow(i + 1);

                fmWait.progressBar1.BeginInvoke(
                (MethodInvoker)delegate
                  {
                      fmWait.progressBar1.Value = Convert.ToInt32(i * 10 * (100.0 / tv_Details.Nodes.Count));
                  }
                );


                rowExcel.CreateCell(0).SetCellValue(row.Cells["cn_darticle"].Value.ToString());
                rowExcel.CreateCell(1).SetCellValue(""/*row.Cells["cn_dsecname"].Value.ToString()*/);
                rowExcel.CreateCell(2).SetCellValue(Convert.ToDouble(row.Cells["cn_dqtyneed"].Value));
                rowExcel.CreateCell(3).SetCellValue("");
                rowExcel.CreateCell(4).SetCellValue(row.Cells["cn_dunit"].Value.ToString());
                rowExcel.CreateCell(5).SetCellValue("");
                rowExcel.CreateCell(6).SetCellValue("");
                rowExcel.CreateCell(7).SetCellValue("");
                rowExcel.CreateCell(8).SetCellValue("");
                rowExcel.CreateCell(9).SetCellValue("");
                rowExcel.CreateCell(10).SetCellValue("");
                rowExcel.CreateCell(11).SetCellValue(row.Cells["cn_dmanufacturer"].Value.ToString());
                rowExcel.CreateCell(12).SetCellValue("");
                rowExcel.CreateCell(13).SetCellValue("");

                //// Rows adding
                //foreach (DataGridViewColumn column in dgv.Columns)// columns
                //{
                //    if (param != null)
                //    {
                //        var col = param.Where(p => p.Name == column.Name).SingleOrDefault();
                //        if (col != null)
                //        {
                //            try
                //            {
                //                rowExcel.CreateCell(columnNumber).SetCellValue(row.Cells[column.Index].Value.ToString());
                //            }
                //            catch { rowExcel.CreateCell(columnNumber).SetCellValue(""); }
                //            columnNumber++;
                //        }
                //    }

                //}

            }

            IRow rowExcel1 = sheet1.CreateRow(0);
            rowExcel1.CreateCell(0).SetCellValue("Article");
            rowExcel1.CreateCell(1).SetCellValue("Suppler's article");
            rowExcel1.CreateCell(2).SetCellValue("Quantity");
            rowExcel1.CreateCell(3).SetCellValue("Unit price");
            rowExcel1.CreateCell(4).SetCellValue("Unit");
            rowExcel1.CreateCell(5).SetCellValue("Currency");
            rowExcel1.CreateCell(6).SetCellValue("VAT");
            rowExcel1.CreateCell(7).SetCellValue("MOQ");
            rowExcel1.CreateCell(8).SetCellValue("MPQ");
            rowExcel1.CreateCell(9).SetCellValue("DataCode");
            rowExcel1.CreateCell(10).SetCellValue("Deliv. terms");
            rowExcel1.CreateCell(11).SetCellValue("Manufacturer");
            rowExcel1.CreateCell(12).SetCellValue("Comments");
            rowExcel1.CreateCell(13).SetCellValue("Supplier");


            //Write the stream data of workbook to the root directory
            FileStream file = new FileStream(fileName, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();

        }

        private void SetHeaderValue(ISheet sheet1, DataGridViewColumn column, IRow headerRow, int j)
        {
            ICell cell1 = HSSFCellUtil.CreateCell(headerRow, j, column.HeaderText);

            IFont font1 = hssfworkbook.CreateFont();
            font1.Boldweight = (short)FontBoldWeight.Bold;

            ICellStyle style2 = hssfworkbook.CreateCellStyle();
            style2.SetFont(font1);

            cell1.CellStyle = style2;
            sheet1.AutoSizeColumn(j);
        }
        #endregion

        private void btn_EditNeed_Click(object sender, EventArgs e)
        {
            int _id = 0;
            double _qty = 0;
            string _comments = "";
            TreeGridNode node = tv_Details.CurrentNode;
            TreeGridNode parentnode = node.Parent;

            tv_Details.EndEdit();

            int _hid = 0;
            try
            {
                _hid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            try
            {


                if (node.Level == 2) //Rabotaem s katalogom
                {
                    _id = Convert.ToInt32(parentnode.Cells["cn_did"].Value);
                    _qty = Convert.ToDouble(parentnode.Cells["cn_dqtyneed"].Value);
                    _comments = parentnode.Cells["cn_dcomments"].Value.ToString();
                }
                else
                {
                    _id = Convert.ToInt32(node.Cells["cn_did"].Value);
                    _qty = Convert.ToDouble(node.Cells["cn_dqtyneed"].Value);
                    _comments = node.Cells["cn_dcomments"].Value.ToString();
                }

            }
            catch { }
            if (_id != 0)
            {
                frm_EditPOneed frm = new frm_EditPOneed();
                frm.Qty = _qty;
                frm.Comments = _comments;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && (_qty != frm.Qty || _comments != frm.Comments))
                {
                    int _state = POBll.EditNeedDets(_id, frm.Qty, frm.Comments);
                    //FillGrid(_hid);
                    //Update data
                    if (node.Level == 2)
                    {
                        parentnode.Cells["cn_dqtyneed"].Value = frm.Qty;
                        parentnode.Cells["cn_dcomments"].Value = frm.Comments;
                        parentnode.Cells["cn_dstate"].Value = _state;
                        foreach (TreeGridNode nodechild in parentnode.Nodes)
                            nodechild.Cells["cn_dqtyneed"].Value = frm.Qty;
                    }
                    else
                    {
                        node.Cells["cn_dqtyneed"].Value = frm.Qty;
                        node.Cells["cn_dcomments"].Value = frm.Comments;
                        node.Cells["cn_dstate"].Value = _state;
                        foreach (TreeGridNode nodechild in node.Nodes)
                            nodechild.Cells["cn_dqtyneed"].Value = frm.Qty;

                    }
                    //Cells color
                    if (node.Level == 2)
                    {
                        if (_state == 0)
                        {
                            parentnode.DefaultCellStyle.BackColor = Color.Gainsboro;
                            foreach (TreeGridNode nodechild in parentnode.Nodes)
                                nodechild.DefaultCellStyle.BackColor = Color.Gainsboro;
                        }
                        else
                        {
                            parentnode.DefaultCellStyle.BackColor = Color.White;
                            foreach (TreeGridNode nodechild in parentnode.Nodes)
                                nodechild.DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        if (_state == 0)
                        {
                            node.DefaultCellStyle.BackColor = Color.Gainsboro;
                            foreach (TreeGridNode nodechild in node.Nodes)
                                nodechild.DefaultCellStyle.BackColor = Color.Gainsboro;
                        }
                        else
                        {
                            node.DefaultCellStyle.BackColor = Color.White;
                            foreach (TreeGridNode nodechild in node.Nodes)
                                nodechild.DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }

            }
        }

        #region Export Result Data

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            string filename = "";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //MessageBox.Show(path);
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.InitialDirectory = path;

            try { filename = globClass.ReplaceChar("Proceeded needs " + gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), "-", "_"); }
            catch { filename = "Proceeded needs"; }

            savefiledialog1.FileName = filename;
            savefiledialog1.DefaultExt = "xls";
            savefiledialog1.Filter = "Excel Files (*.xls)|*.xls|All files (*.*)|*.*";
            savefiledialog1.FilterIndex = 1;
            savefiledialog1.RestoreDirectory = true;


            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = savefiledialog1.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    //dgv.Enabled = false;
                    BackgroundWorker bw = new BackgroundWorker();
                    bw.DoWork += ImportDataForMail;

                    bw.RunWorkerCompleted += ImportCompleted;

                    fmWait = new frm_Wait();

                    bw.RunWorkerAsync();
                    fmWait.Start();
                    fmWait.Show();

                }
            }

        }

        private void ImportDataForMail(object sender, DoWorkEventArgs e)
        {
            InitializeWorkbook();

            ISheet sheet1 = hssfworkbook.CreateSheet("Sheet1");

            IFont font1 = hssfworkbook.CreateFont();
            font1.Boldweight = (short)FontBoldWeight.Bold;

            ICellStyle style1 = hssfworkbook.CreateCellStyle();
            style1.SetFont(font1);

            style1.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;
            //style1.FillPattern = FillPatternType.SOLID_FOREGROUND;

            ICellStyle style2 = hssfworkbook.CreateCellStyle();
            style2.SetFont(font1);

            IRow rowExcel1 = sheet1.CreateRow(0);
            ICell cell = rowExcel1.CreateCell(0);
            cell.SetCellValue("Article");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(1);
            cell.SetCellValue("Suppler's article");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(2);
            cell.SetCellValue("Supplier");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(3);
            cell.SetCellValue("Quantity need");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(4);
            cell.SetCellValue("Quantity in PO");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(5);
            cell.SetCellValue("Unit price");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(6);
            cell.SetCellValue("Unit");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(7);
            cell.SetCellValue("Currency");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(8);
            cell.SetCellValue("Catalog's date");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(9);
            cell.SetCellValue("MOQ");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(10);
            cell.SetCellValue("MPQ");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(11);
            cell.SetCellValue("DataCode");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(12);
            cell.SetCellValue("Deliv. terms");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(13);
            cell.SetCellValue("Manufacturer");
            cell.CellStyle = style1;
            cell = rowExcel1.CreateCell(14);
            cell.SetCellValue("Comments");
            cell.CellStyle = style1;


            var param = e.Argument as List<DataGridViewColumn>;
            int j = 1;
            //MessageBox.Show(dgv.Rows.Count.ToString());
            for (int i = 0; i < tv_Details.Nodes.Count; i++)
            {
                TreeGridNode row = tv_Details.Nodes[i]; // rows
                IRow rowExcel = sheet1.CreateRow(j);

                fmWait.progressBar1.BeginInvoke(
                (MethodInvoker)delegate
                {
                    fmWait.progressBar1.Value = Convert.ToInt32(i * 10 * (100.0 / tv_Details.Nodes.Count));
                }
                );

                cell = rowExcel.CreateCell(0);
                cell.SetCellValue(row.Cells["cn_darticle"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(1);
                cell.SetCellValue(row.Cells["cn_dsecname"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(2);
                cell.SetCellValue(row.Cells["cn_dsupplier"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(3);
                cell.SetCellValue(Convert.ToDouble(row.Cells["cn_dqtyneed"].Value));
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(4);
                cell.SetCellValue(Convert.ToDouble(row.Cells["cn_dqtyinpo"].Value));
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(5);
                cell.SetCellValue(Convert.ToDouble(row.Cells["cn_dunitprice"].Value));
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(6);
                cell.SetCellValue(row.Cells["cn_dunit"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(7);
                cell.SetCellValue(row.Cells["cn_dcurr"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(8);
                cell.SetCellValue(row.Cells["cn_dcatdate"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(9);
                cell.SetCellValue(Convert.ToDouble(row.Cells["cn_dmoq"].Value));
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(10);
                cell.SetCellValue(Convert.ToDouble(row.Cells["cn_dmpq"].Value));
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(11);
                cell.SetCellValue(row.Cells["cn_ddatacode"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(12);
                cell.SetCellValue(row.Cells["cn_ddelivterm"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(13);
                cell.SetCellValue(row.Cells["cn_dmanufacturer"].Value.ToString());
                cell.CellStyle = style2;

                cell = rowExcel.CreateCell(14);
                cell.SetCellValue(row.Cells["cn_dcomments"].Value.ToString());
                cell.CellStyle = style2;

                j++;

                int beg = 0;
                foreach (TreeGridNode node in row.Nodes)
                {
                    rowExcel = sheet1.CreateRow(j);

                    rowExcel.CreateCell(0).SetCellValue(node.Cells["cn_darticle"].Value.ToString());
                    rowExcel.CreateCell(1).SetCellValue(row.Cells["cn_dsecname"].Value.ToString());
                    rowExcel.CreateCell(2).SetCellValue(node.Cells["cn_dsupplier"].Value.ToString());
                    rowExcel.CreateCell(3).SetCellValue(Convert.ToDouble(node.Cells["cn_dqtyneed"].Value));
                    rowExcel.CreateCell(4).SetCellValue(Convert.ToDouble(node.Cells["cn_dqtyinpo"].Value));
                    rowExcel.CreateCell(5).SetCellValue(Convert.ToDouble(node.Cells["cn_dunitprice"].Value));
                    rowExcel.CreateCell(6).SetCellValue(node.Cells["cn_dunit"].Value.ToString());
                    rowExcel.CreateCell(7).SetCellValue(node.Cells["cn_dcurr"].Value.ToString());
                    rowExcel.CreateCell(8).SetCellValue(node.Cells["cn_dcatdate"].Value.ToString());
                    rowExcel.CreateCell(9).SetCellValue(Convert.ToDouble(node.Cells["cn_dmoq"].Value));
                    rowExcel.CreateCell(10).SetCellValue(Convert.ToDouble(node.Cells["cn_dmpq"].Value));
                    rowExcel.CreateCell(11).SetCellValue(node.Cells["cn_ddatacode"].Value.ToString());
                    rowExcel.CreateCell(12).SetCellValue(node.Cells["cn_ddelivterm"].Value.ToString());
                    rowExcel.CreateCell(13).SetCellValue(node.Cells["cn_dmanufacturer"].Value.ToString());
                    rowExcel.CreateCell(14).SetCellValue(node.Cells["cn_dcomments"].Value.ToString());


                    beg++;
                    j++;
                }

                sheet1.GroupRow(j - beg, j);
            }

            //ICell cell1 = HSSFCellUtil.CreateCell(headerRow, j, column.Caption);



            //cell1.CellStyle = style2;


            for (int k = 0; k <= 14; k++)
                sheet1.AutoSizeColumn(k);


            //Write the stream data of workbook to the root directory
            FileStream file = new FileStream(fileName, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();

        }


        /*
        private MemoryStream ImportData(DataTable data)
        {

            InitializeWorkbook();

            // new sheet
            ISheet sheet1 = hssfworkbook.CreateSheet("Sheet1");
            int columnNumber = 0;

            // Rows adding
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
                IRow rowExcel = sheet1.CreateRow(i + 1);
                columnNumber = 0;

                // columns
                foreach (DataColumn column in data.Columns)
                {
                    rowExcel.CreateCell(columnNumber).SetCellValue(row[column.Ordinal].ToString());
                    columnNumber++;
                }
            }

            // Column headers
            //var headerRow = sheet1.CreateRow(0);
            //int j = 0;
            //foreach (DataColumn column in data.Columns)
            //{
            //    SetHeaderValue(sheet1, column, headerRow, j);
            //    j++;
            //}

            var ms = new NpoiMemoryStream();
            ms.AllowClose = false;
            hssfworkbook.Write(ms);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            ms.AllowClose = true;
            return ms;
        }
        
        public class NpoiMemoryStream : MemoryStream
        {
            public NpoiMemoryStream()
            {
                AllowClose = true;
            }

            public bool AllowClose { get; set; }

            public override void Close()
            {
                if (AllowClose)
                    base.Close();
            }
        }

        private void SetHeaderValue(ISheet sheet1, DataColumn column, IRow headerRow, int j)
        {
            ICell cell1 = HSSFCellUtil.CreateCell(headerRow, j, column.Caption);

            IFont font1 = hssfworkbook.CreateFont();
            font1.Boldweight = (short)FontBoldWeight.BOLD;

            ICellStyle style2 = hssfworkbook.CreateCellStyle();
            style2.SetFont(font1);

            cell1.CellStyle = style2;
            sheet1.AutoSizeColumn(j);
        }
        */
        #endregion

        private void btn_CloseNeeds_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0
                && glob_Class.CloseProjectConfirm() == true)
            {
                MessageBox.Show(POBll.ClosePONeed(_id));
                bwStart(bw_List);
            }

        }

        private void btn_EditComments_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _comments = "";
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_cmbText frm = new frm_cmbText();
                frm.LabelText = "Comments: ";
                frm.FormText = _comments;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    POBll.EditPONeedComments(_id, frm.FormText);
                    gv_List.CurrentRow.Cells["cn_comments"].Value = frm.FormText;
                }
            }

        }

        private void cmb_Articles1_ArticleIdKeyPressed(object sender)
        {
            SetNeedColor(cmb_Articles1.ArticleId);
        }

        private void cmb_Articles1_ArticleKeyPressed(object sender)
        {
            SetNeedColor(cmb_Articles1.ArticleId);
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetNeedColor(cmb_Articles1.ArticleId);
        }

        private void tv_Details_SelectionChanged(object sender, EventArgs e)
        {
            //Change color of needs
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(tv_Details.CurrentRow.Cells["cn_dartid"].Value);
            }
            catch { }

            if (PrevArtId != _id
                && cmb_Articles1.ArticleId == 0)
            {
                SetNeedColor(_id);
                PrevArtId = _id;
            }
        }

        private void btn_NeedsList_Click(object sender, EventArgs e)
        {
            var _query = "sp_SelectNeedsHeaders";

            var sqlparams = new List<SqlParameter>()
            {
                //new SqlParameter("@artid",SqlDbType.Int) {Value = _id}
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Needs list";
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show();
        }
    }
}
