using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Odin.Register.Articles
{
    public partial class frm_BOMManagement : BaseForm
    {
        public frm_BOMManagement()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "BOMList.xls", this.Name);
            //ED1 = new ExportData(this.gv_HistoryList, "BOMHistory.xls");
        }

        #region Variables

        ExportData ED;

        ExportData ED1;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL Reg = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        //ExportData ED;
        //ExportData ED1;
        //private string example = "Example";
        //Font boldFont;
        Helper MyHelper = new Helper();
        //DGVColumnHeader checkBoxColumn;
        //private List<CutListTempInstructions> tempInstructions = new List<CutListTempInstructions>();

        public ctl_BOMHistory ctlHis = null;
        public ctl_BOMSetup ctlSetup = null;
        public ctl_BOMSupplier ctlSupplier = null;
        public ctl_RationingExtended ctlRatio = null;
        public int ControlWidth = 250;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        //public int RowIndexH = 0;
        //public int ColumnIndexH = 0;
        //public string ColumnNameH = "";
        //public string CellValueH = "";


        //private int currentColumnIndex = 0;


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


        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }

        public int _PrevId = 0;

        private KryptonPage NewInputHistory(string Article, int ArtId)
        {
            ctlHis = new ctl_BOMHistory();

            ctlHis.ArtId = ArtId;
            ctlHis.HeaderText = "History for BOM changes for: " + Article;
            ctlHis.gv_HistoryList.ThreadSafeCall(delegate { ctlHis.SetCellsHistoryColor(); });
                       

            return NewPage("History ", 1, ctlHis, ctlHis.Width);

        }

        private KryptonPage NewSetup(string Article, int ArtId)
        {
            ctlSetup = new ctl_BOMSetup();
            ControlWidth = ctlSetup.Width;

            ctlSetup.cmb_Articles1.ArticleId = ArtId;

            return NewPage("Setup ", 1, ctlSetup, ctlSetup.Width);

        }
        private KryptonPage NewSupplier(string Article, int ArtId)
        {
            ctlSupplier = new ctl_BOMSupplier();
            ControlWidth = ctlSupplier.Width;

            return NewPage("Supplier ", 1, ctlSupplier, ctlSupplier.Width);

        }

        private KryptonPage NewPage(string name, int image, Control content, int _Width)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name;
            p.TextTitle = name;
            p.TextDescription = name;
           
            //p.Width = _Width;

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);


            return p;
        }
        public void SetHistoryPagesColor()
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BOMHistory ctlHis1 = (ctl_BOMHistory)page.Controls.Find("ctl_BOMHistory", true).FirstOrDefault();
                if (ctlHis1 != null)
                {
                    ctlHis1.SetCellsHistoryColor();
                }
                //break;
            }
        }

        private KryptonPage NewInputRatio(string Article, int ArtId)
        {
            ctlRatio = new ctl_RationingExtended();
            ControlWidth = ctlRatio.Width;
            ctlRatio.cmb_Articles1.ArticleId = ArtId;
            return NewPage("Rationing ", 1, ctlRatio, ctlRatio.Width);
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
                if (Convert.ToInt32(row.Cells["cn_bomstate"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Tomato;//LightCoral;
                else if (Convert.ToInt32(row.Cells["cn_bomstate"].Value) == -1)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.GreenYellow;//Color.FromArgb(192, 255, 192);
                    if (Convert.ToString(row.Cells["cn_stencil"].Value) == "Not Required")
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.FromArgb(121, 178, 32);
                    if (Convert.ToString(row.Cells["cn_stencil"].Value) == "")
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.FromArgb(135, 206, 250);
                }
                else
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Gold;
                if (Convert.ToString(row.Cells["cn_description"].Value) == "!!! Cancelled !!!")
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.FromArgb(130, 137, 142);
                if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
            }
        }

        //public void SetCellsHistoryColor()
        //{
        //    foreach (DataGridViewRow row in this.gv_HistoryList.Rows)
        //    {
        //        if (row.Cells["cn_typechange"].Value.ToString() == "deleted")
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //                cell.Style.BackColor = Color.LightCoral;
        //        }
        //        else if (row.Cells["cn_typechange"].Value.ToString() == "inserted")
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //                cell.Style.BackColor = Color.FromArgb(192, 255, 192);
        //        }
        //        else
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //                cell.Style.BackColor = Color.Plum;
        //        }

        //    }
        //}

        private bool CheckOldRow()
        {

            try
            {
                igvArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
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

        public void ShowDetails(int artid)
        {
           Reg.ArtId = artid;
           ctl_BOMSimple1.ThreadSafeCall(delegate
           {
               ctl_BOMSimple1.SetFont();
               ctl_BOMSimple1.cmb_Articles1.ArticleId = artid;
           });
            //ShowHistory(artid);
        }

        //public void ShowHistory(int artid)
        //{
        //    bs_HistoryList.RemoveFilter();

        //    var datah = Reg_BLL.getBOMHistory(artid);

        //    gv_HistoryList.ThreadSafeCall(delegate
        //    {
        //        gv_HistoryList.AutoGenerateColumns = false;
        //        bs_HistoryList.DataSource = datah;
        //        gv_HistoryList.DataSource = bs_HistoryList;

        //        //SetCellsHistoryColor();
        //    });


        //    bn_HistoryList.ThreadSafeCall(delegate
        //    {
        //        bn_HistoryList.BindingSource = bs_HistoryList;
        //    });
        //}

        public void ClearFilter()
        {
            cmb_Articles1.Article = "";
            cmb_Articles1.ArticleId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            txt_SecArticle.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_Description.Text = string.Empty;
            txt_ExtArt.Text = string.Empty;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {

            try
            {
                //MessageBox.Show(cmb_Articles1.Article);
                //bs_List.DataSource = null;

                gv_List.ThreadSafeCall(delegate
                {
                    var data = (DataTable)Helper.getSP("sp_BOMList", cmb_Articles1.ArticleId, cmb_Articles1.Article.Trim(), txt_SecArticle.Text, Description,
                                                cmb_Types1.TypeId, txt_Comments.Text, cmb_Firms1.FirmId,
                                                txt_ExtArt.Text, chk_IsActive.CheckState == CheckState.Checked ? -1 : (chk_IsActive.CheckState == CheckState.Indeterminate ? 1 : 0),
                                                rb_All.Checked == true ? 1 : (rb_Valid.Checked == true ? -1 : 0),
                                                chk_OrderExists.CheckState == CheckState.Checked ? -1 : (chk_OrderExists.CheckState == CheckState.Indeterminate ? 1 : 0));

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

        public void ShowDetails()
        {
            var data = (DataTable)Helper.getSP("sp_BOMList", cmb_Articles1.ArticleId, cmb_Articles1.Article.Trim(), txt_SecArticle.Text, Description,
                                               cmb_Types1.TypeId, txt_Comments.Text, cmb_Firms1.FirmId,
                                               txt_ExtArt.Text, chk_IsActive.CheckState == CheckState.Checked ? -1 : (chk_IsActive.CheckState == CheckState.Indeterminate ? 1 : 0),
                                               rb_All.Checked == true ? 1 : (rb_Valid.Checked == true ? -1 : 0),
                                               chk_OrderExists.CheckState == CheckState.Checked ? -1 : (chk_OrderExists.CheckState == CheckState.Indeterminate ? 1 : 0));
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

        public void FindHistoryPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BOMHistory ctlHis1 = (ctl_BOMHistory)page.Controls.Find("ctl_BOMHistory", true).FirstOrDefault();
                if (ctlHis1 != null)
                {
                    ctlHis1.ArtId = artid;
                    ctlHis1.HeaderText = "History for BOM changes for: " + Reg.Article;
                }
                //break;
            }
        }

        public void FindSetupPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BOMSetup ctlSetup1 = (ctl_BOMSetup)page.Controls.Find("ctl_BOMSetup", true).FirstOrDefault();
                if (ctlSetup1 != null
                    && ctlSetup1.Lock == 0)
                    ctlSetup1.cmb_Articles1.ArticleId = artid;
                //break;
            }
        }
        public void FindRatioPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_RationingExtended ctlRatio1 = (ctl_RationingExtended)page.Controls.Find("ctl_RationingExtended", true).FirstOrDefault();
                if (ctlRatio1 != null
                    && ctlRatio1.Lock == 0)
                    ctlRatio1.cmb_Articles1.ArticleId = artid;

            }
        }
        public void FindSupplierPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BOMSetup ctl_BOMSetup1 = (ctl_BOMSetup)page.Controls.Find("ctl_BOMSetup", true).FirstOrDefault();
            }
        }
        public void ShowEdit()
        {
            frm_AddArticle frm = new frm_AddArticle();
            frm.CheckEmpty();

            Reg.ArtId = igvArtId;

            frm.Id = Reg.ArtId;
            frm.Article = Reg.Article;
            frm.SecName = Reg.SecName;
            frm.Description = Reg.Description;
            frm.TypeId = Reg.TypeId;
            frm.UnitId = Reg.UnitId;
            frm.ImagePath = Reg.ImagePath;
            frm.Comments = Reg.Comments;
            frm.CustCodeId = Reg.CustCodeId;
            frm.QtyReserve = Reg.QtyReserve;
            frm.DeptId = Reg.DeptId;
            frm.CreateSubBatch = Reg.CreateSubBatch;
            frm.Weight = Reg.Weight;
            frm.IsActive = Reg.IsActive;
            frm.Revision = Reg.Revision;
            frm.StoreRules = Reg.StorageRules;
            frm.SpoilNorm = Reg.SpoilNorm;
            frm.ShowImage(frm.ImagePath);
            frm.StageId = Reg.StageId;
            frm.MSL = Reg.MSL;
            frm.Service = Reg.Service;
            //frm.LabelsQty = Reg.LabelsQty;
            //frm.StencilRequired = Reg.StencilRequired;
            //frm.StencilID = Reg.StencilID;
            frm.Warning = Reg.Warning;
            frm.SpoilConst = Reg.SpoilConst;
            frm.AsPF = Reg.AsPF;
            frm.MBLimit = Reg.MBLimit;
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                //MessageBox.Show(frm.MSL);
                //Edit
                int _res = Convert.ToInt32(Helper.getSP("sp_SaveArticle", frm.Id, Regex.Replace(frm.Article, @"\p{C}+", string.Empty), frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                    frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive,
                                    frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, /*frm.LabelsQty, frm.StencilRequired, 
                                    frm.StencilID*/0, 0, 0, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit));
                if (_res != 0)
                {
                    cmb_Articles1.ArticleId = _res;
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                    SetCellsColor();

                    Reg.ArtId = _res;
                }
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

            frm.HeaderText = "Select view for articles list";
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

        private void mni_Conditional_Click(object sender, EventArgs e)
        {
            int _bomstate = 0;

            try
            {
                _bomstate = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_bomstate"].Value);

                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? "bomstate = '" + glob_Class.NES(_bomstate.ToString()) + "'"
                    : bs_List.Filter + " AND bomstate = '" + glob_Class.NES(_bomstate.ToString()) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();
        }

        #endregion

        #region Context menu history
        //private void mnu_LinesHis_Opening(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        Point mpoint = gv_HistoryList.PointToClient(DataGridView.MousePosition);
        //        DataGridView.HitTestInfo info = gv_HistoryList.HitTest(mpoint.X, mpoint.Y);

        //        RowIndexH = info.RowIndex;
        //        ColumnIndexH = info.ColumnIndex;
        //        //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

        //        gv_HistoryList.ClearSelection();
        //        gv_HistoryList.Rows[RowIndexH].Cells[ColumnIndexH].Selected = true;
        //        gv_HistoryList.CurrentCell = gv_HistoryList.Rows[RowIndexH].Cells[ColumnIndexH];

        //        CellValueH = gv_HistoryList.Rows[RowIndexH].Cells[ColumnIndexH].Value.ToString();
        //        ColumnNameH = gv_HistoryList.Columns[ColumnIndexH].DataPropertyName.ToString();
        //        //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

        //    }
        //    catch
        //    {
        //        RowIndexH = 0;
        //        ColumnIndexH = 0;
        //        return;
        //    }
        //}

        //private void mni_FilterForHis_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bs_HistoryList.Filter = ("Convert(" + ColumnNameH + " , 'System.String') like '%" + mni_FilterForHis.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
        //    }
        //    catch
        //    { }
        //}

        //private void mni_SearchHis_Click(object sender, EventArgs e)
        //{
        //    frm_Find frm = new frm_Find();
        //    frm.grid = gv_HistoryList;
        //    frm.ColumnNumber = gv_HistoryList.CurrentCell.ColumnIndex;
        //    frm.ColumnText = gv_HistoryList.Columns[frm.ColumnNumber].HeaderText;
        //    frm.ShowDialog();
        //}

        //private void mni_FilterByHis_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (String.IsNullOrEmpty(bs_HistoryList.Filter) == true)
        //        {
        //            if (String.IsNullOrEmpty(CellValue) == true)
        //                bs_HistoryList.Filter = "(" + ColumnNameH + " is null OR Convert(" + ColumnNameH + ", 'System.String') = '')";
        //            else
        //                bs_HistoryList.Filter = "Convert(" + ColumnNameH + " , 'System.String') = '" + glob_Class.NES(CellValueH) + "'";
        //        }
        //        else
        //        {
        //            if (String.IsNullOrEmpty(CellValue) == true)
        //                bs_HistoryList.Filter = bs_HistoryList.Filter + "AND (" + ColumnNameH + " is null OR Convert(" + ColumnNameH + ", 'System.String') = '')";
        //            else
        //                bs_HistoryList.Filter = bs_HistoryList.Filter + " AND Convert(" + ColumnNameH + " , 'System.String') = '" + glob_Class.NES(CellValueH) + "'";
        //        }
        //        //MessageBox.Show(bs_List.Filter);

        //    }
        //    catch { }
        //}

        //private void mni_FilterExcludingSelHis_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (String.IsNullOrEmpty(bs_HistoryList.Filter) == true)
        //            bs_HistoryList.Filter = "Convert(" + ColumnNameH + " , 'System.String') <> '" + CellValueH + "'";
        //        else
        //            bs_HistoryList.Filter = bs_HistoryList.Filter + " AND " + ColumnNameH + " <> '" + CellValueH + "'";
        //    }
        //    catch { }
        //}

        //private void mni_RemoveFilterHis_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bs_HistoryList.RemoveFilter();
        //    }
        //    catch { }
        //}

        //private void mni_CopyHis_Click(object sender, EventArgs e)
        //{
        //    Clipboard.SetText(CellValueH.ToString());
        //}

        //private void mni_AdminHis_Click(object sender, EventArgs e)
        //{
        //    frm_GridViewAdm frm = new frm_GridViewAdm();

        //    frm.HeaderText = "Select view for bom history list";
        //    frm.grid = this.gv_HistoryList;
        //    frm.formname = this.Name;
        //    DAL.UserLogin = System.Environment.UserName;
        //    frm.UserId = DAL.UserId;

        //    frm.FillData(frm.grid);

        //    DialogResult result = frm.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
        //        LoadColumns(gv_HistoryList);
        //    }
        //}

        #endregion  

        private void frm_BOMManagement_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);
            LoadColumns(gv_List);
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputHistory("",0) });
            
            //foreach (var page in kryptonDockingManager1.Pages)
            //{
            //    ctl_BOMHistory ctlHis1 = (ctl_BOMHistory)page.Controls.Find("ctl_BOMHistory", true).FirstOrDefault();
            //    if (ctlHis1 != null)
            //    {
            //        ctlHis.Select();
            //    }
            //    //break;
            //}

            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewSetup("", 0) });
            //LoadColumns(gv_HistoryList);
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                gv_List.ThreadSafeCall(delegate
                {
                    if (CheckOldRow() == false)
                    {
                        ShowDetails(igvArtId);
                        FindHistoryPages(igvArtId);
                        FindSetupPages(igvArtId);
                    }
                });
            }
            catch { }
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_SecArticle.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_ExtArt.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                ShowDetails();//gv_List.ThreadSafeCall(delegate { bwStart(bw_List); });

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
                //SetCellsHistoryColor();
            }
            catch { }
        }
        #endregion

        private void ctl_BOMSimple1_SendRMArtId(int artid)
        {
            bs_HistoryList.Filter = artid != 0 ? " artid = '" + artid + "'" : "";
        }

        private void cmb_Articles1_ArticleKeyPressed(object sender)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            ShowDetails();//bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        private void txt_SecArticle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                ShowDetails();//bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
            }
        }

        private void txt_Description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                ShowDetails();//bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
            }
        }

        private void txt_ExtArt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                ShowDetails();// bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
            }
        }

        private void txt_Comments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                ShowDetails(); bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
            }
        }

        private void txt_SecArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void txt_Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void txt_ExtArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void txt_Comments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void ctl_BOMSimple1_SendBOMArtId(int artid)
        {
            //MessageBox.Show(artid.ToString());
            FindHistoryPages(artid);
            FindSetupPages(artid);
            FindRatioPages(artid);
            FindSupplierPages(artid);
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_HistoryExcel_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void gv_HistoryList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //SetCellsHistoryColor();
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void frm_BOMManagement_Resize(object sender, EventArgs e)
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

        private void btn_History_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputHistory(Reg.Article, Reg.ArtId) });
            //SetHistoryPagesColor();
            //FindHistoryPages(Reg.ArtId);

        }

        private void kryptonDockingManager1_DockableWorkspaceAdded(object sender, DockableWorkspaceEventArgs e)
        {
            
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddArticle frm = new frm_AddArticle();
            frm.CheckEmpty();
            frm.Id = 0;

            int number;

            bool success = Int32.TryParse(DAL.DefaultValue("unit"), out number);

            frm.UnitId = success ? number : 0;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                //s = Regex.Replace(s, @"\p{C}+", string.Empty);
                //Add new 
                int _res = Convert.ToInt32(Helper.getSP("sp_SaveArticle", 0, Regex.Replace(frm.Article, @"\p{C}+", string.Empty), frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                    frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive,
                                    frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, 0, 0, 0,/* frm.LabelsQty, 
                                    frm.StencilRequired, frm.StencilID,*/ frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit));
                if (_res != 0)
                {
                    cmb_Articles1.ArticleId = _res;
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                }
                else
                {
                    KryptonTaskDialog.Show("Mistake during creation of article!",
                                       "Article was not created!",
                                        "Please check article! Maybe such article already exists!",
                                        MessageBoxIcon.Warning,
                                        TaskDialogButtons.OK);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (globClass.DeleteConfirm() == true)
            {
                Helper.getSP("sp_DeleteArticle", igvArtId);
                cmb_Articles1.ArticleId = 0;
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            frm_AddArticle frm = new frm_AddArticle();
            frm.CheckEmpty();
            frm.Id = 0;// Reg.ArtId;
            frm.Article = Reg.Article;
            frm.SecName = Reg.SecName;
            frm.Description = Reg.Description;
            frm.TypeId = Reg.TypeId;
            frm.UnitId = Reg.UnitId;
            frm.ImagePath = "";
            frm.Comments = Reg.Comments;
            frm.CustCodeId = Reg.CustCodeId;
            frm.QtyReserve = Reg.QtyReserve;
            frm.DeptId = Reg.DeptId;
            frm.CreateSubBatch = Reg.CreateSubBatch;
            frm.Weight = Reg.Weight;
            frm.IsActive = Reg.IsActive;
            frm.Revision = Reg.Revision;
            frm.StoreRules = Reg.StorageRules;
            frm.SpoilNorm = Reg.SpoilNorm;
            //frm.ShowImage(frm.ImagePath);
            frm.StageId = Reg.StageId;
            frm.MSL = Reg.MSL;
            frm.Service = Reg.Service;
            //frm.LabelsQty = Reg.LabelsQty;
            //frm.StencilRequired = Reg.StencilRequired;
            //frm.StencilID = Reg.StencilID;
            frm.Warning = Reg.Warning;
            frm.SpoilConst = Reg.SpoilConst;
            frm.AsPF = 0;
            frm.MBLimit = Reg.MBLimit;
            DialogResult result = frm.ShowDialog();
            

            if (result == DialogResult.OK)
            {
                //Edit
                int _res = Convert.ToInt32(Helper.getSP("sp_SaveArticle", 0, Regex.Replace(frm.Article, @"\p{C}+", string.Empty), frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                    frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive,
                                    frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, /*frm.LabelsQty, 
                                    frm.StencilRequired, frm.StencilID*/0, 0, 0, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit));
                if (_res != 0)
                {
                    cmb_Articles1.ArticleId = _res;
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                }
            }
        }

        private void btn_Setup_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddDockspace("Control",
            //                                   DockingEdge.Left,
            //                                   new KryptonPage[] { NewSetup(Reg.Article, Reg.ArtId) });
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewSetup(Reg.Article, Reg.ArtId) });
        }
        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddDockspace("Control",
            //                                   DockingEdge.Left,
            //                                   new KryptonPage[] { NewSetup(Reg.Article, Reg.ArtId) });
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewSupplier(Reg.Article, Reg.ArtId) });
        }

        private void frm_BOMManagement_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void kryptonDockableWorkspace1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Rationing_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputRatio(Reg.Article, Reg.ArtId) });
        }

        private void btn_RatioList_Click(object sender, EventArgs e)
        {
            string query = "sp_RatioList";

            var sqlparams = new List<SqlParameter>
            {
            
            };

            frm_RatioTab frm = new frm_RatioTab();

            frm.Text = "Articles ratio list";
            frm.Query = query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
        }
    }
}
