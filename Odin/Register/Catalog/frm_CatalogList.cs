using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using Odin.Global_Classes;
using Odin.Purchase;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Register.Catalog
{
    public partial class frm_CatalogList : BaseForm
    {
        public frm_CatalogList()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "Catalog.xls", this.Name);

        }

        #region Variables

        public int BargType
        {
            get
            {
                return rb_Supplier.Checked == true ? -1 : rb_Customer.Checked == true ? 1 : 0;
            }
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL RegBll = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();

        frm_DownloadCatItems frm1 = null;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public ctl_DownloadResult ctlResult = null;
        public ctl_CatHistory ctlHis = null;
        frm_AddCatItem frm = null;

        public int CatId
        {
            get;
            set;
        }

        public int _PrevId = 0;

        public int igvArtId
        {
            get;
            set;
        }

        public int ControlWidth = 250;

        private KryptonPage NewPage(string name, int image, Control content, int _Width)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name;
            p.TextTitle = name;
            p.TextDescription = name;
            p.ImageSmall = imageListSmall.Images[image];

            //p.Width = _Width;

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);


            return p;
        }

        private KryptonPage NewInputPayments()
        {
            ctlResult = new ctl_DownloadResult();
            ControlWidth = ctlResult.Width;
            ctlResult.FillList();

            //ctlHis.cmb_Articles1.ArticleId = ArtId;

            return NewPage("History ", 1, ctlResult, ctlResult.Width);
        }

        private KryptonPage NewInputHistory(int ArtId)
        {
            ctlHis = new ctl_CatHistory();

            ctlHis.cmb_Articles1.ArticleId = ArtId;
            //ctlCat.SendArtId += new ArtIdSendingEventHandler(ChangeArtIdSelection);
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("History ", 1, ctlHis, ctlHis.Width);
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_firmart"].Style.BackColor = Convert.ToInt32(row.Cells["cn_bargtype"].Value) == -1
                    ? Color.Yellow
                    : Convert.ToInt32(row.Cells["cn_bargtype"].Value) == 1 ? Color.LightGreen : Color.Aqua;
            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = Reg_BLL.getCatalogList(BargType, cmb_Types1.TypeId, cmb_Firms1.FirmId, cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_FirmArt.Text,
                                            txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(), txt_Comments.Text);

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

        private bool CheckOldRow()
        {

            try
            {
                CatId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                igvArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch
            {
                CatId = 0;
                igvArtId = 0;
            }

            if (_PrevId == CatId)
            {
                return true;
            }
            else
            {
                _PrevId = CatId;
                return false;
            }
        }

        public void ShowDetails(int catid)
        {
            RegBll.CatId = catid;


            FindHistoryPages(igvArtId);

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

        public void ClearFilter()
        {
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            txt_FirmArt.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_CreatDateFrom.Value = null; //Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
        }

        public void CatAdded(object sender)
        {
            int NewLineId = 0;

            NewLineId = RegBll.AddCatalogItem(frm.BargType, frm.ArticleId, frm.FirmId, frm.FirmArt, frm.UnitId, frm.UnitPrice, frm.CurId, frm.Manufacturer, frm.Comments,
                                            frm.DelivTerms, frm.MOQ, frm.MPQ, frm.AsDefault, "", Convert.ToInt32(frm.Vat), frm.MinExpDays, frm.CoefConv, frm.DataCode,
                                            frm.DelivTermTxt, frm.Quoted, frm.BarCode, frm.ForCustomer);

            cmb_Articles1.ArticleId = frm.ArticleId;

            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            frm.Close();
        }

        public void CatEdited(object sender)
        {
            RegBll.EditCatalogItem(frm.CatID, frm.BargType, frm.ArticleId, frm.FirmId, frm.FirmArt, frm.UnitId, frm.UnitPrice, frm.CurId, frm.Manufacturer, frm.Comments,
                                            frm.DelivTerms, frm.MOQ, frm.MPQ, frm.AsDefault, "", Convert.ToInt32(frm.Vat), frm.MinExpDays, frm.CoefConv, frm.DataCode,
                                            frm.DelivTermTxt, frm.Quoted, frm.BarCode, frm.ForCustomer);
            RegBll.CatId = frm.CatID;

            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            frm.Close();
        }

        public void FindHistoryPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_CatHistory ctlHis1 = (ctl_CatHistory)page.Controls.Find("ctl_CatHistory", true).FirstOrDefault();
                if (ctlHis1 != null)
                    ctlHis1.cmb_Articles1.ArticleId = artid;
                //break;
            }
        }


        #endregion

        #region Controls

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(CatId);
            }
        }

        private void frm_CatalogList_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            txt_CreatDateFrom.Value = null;
            txt_CreatDateTill.Value = null;

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

        #endregion

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CreatDateTill.Value = System.DateTime.Now;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_FirmArt.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm = new frm_AddCatItem();
            frm.ArticleId = cmb_Articles1.ArticleId;
            frm.CatSaved += new CatSavedEventHandler(CatAdded);

            frm.Show();

        }

        public void ShowEdit()
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm = new frm_AddCatItem();
                RegBll.CatId = _id;
                frm.CatID = _id;
                frm.ArticleId = RegBll.CatArtId;
                frm.BargType = RegBll.CatBargain;
                frm.FirmArt = RegBll.CatFirmArt;
                frm.FirmId = RegBll.CatFirmId;
                frm.UnitId = RegBll.CatUnitId;
                frm.UnitPrice = RegBll.CatUnitPrice;
                frm.CurId = RegBll.CatCurId;
                frm.Manufacturer = RegBll.CatManufacturer;
                frm.DelivTerms = RegBll.CatDelivDerm;
                frm.MOQ = RegBll.CatMOQ;
                frm.MPQ = RegBll.CatMPQ;
                frm.AsDefault = RegBll.CatAsDefault;
                frm.MinExpDays = RegBll.CatMinExpDays;
                frm.CoefConv = RegBll.CatCoefConv;
                frm.Comments = RegBll.CatComments;
                frm.Vat = RegBll.CatVat;
                frm.Quoted = RegBll.CatQuoted;
                frm.BarCode = RegBll.CatBarCode;
                frm.DataCode = RegBll.CatDataCode;
                frm.ForCustomer = RegBll.CatForCust;

                frm.CatSaved += new CatSavedEventHandler(CatEdited);


                frm.Show();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm = new frm_AddCatItem();
                RegBll.CatId = _id;
                frm.CatID = _id;
                frm.ArticleId = RegBll.CatArtId;
                frm.BargType = RegBll.CatBargain;
                frm.FirmArt = RegBll.CatFirmArt;
                frm.FirmId = RegBll.CatFirmId;
                frm.UnitId = RegBll.CatUnitId;
                frm.UnitPrice = RegBll.CatUnitPrice;
                frm.CurId = RegBll.CatCurId;
                frm.Manufacturer = RegBll.CatManufacturer;
                frm.DelivTerms = RegBll.CatDelivDerm;
                frm.MOQ = RegBll.CatMOQ;
                frm.MPQ = RegBll.CatMPQ;
                frm.AsDefault = RegBll.CatAsDefault;
                frm.MinExpDays = RegBll.CatMinExpDays;
                frm.CoefConv = RegBll.CatCoefConv;
                frm.Comments = RegBll.CatComments;
                frm.Vat = RegBll.CatVat;
                frm.DataCode = RegBll.CatDataCode;
                frm.DelivTermTxt = RegBll.CatDelivTermTxt;
                frm.BarCode = RegBll.CatBarCode;
                frm.ForCustomer = RegBll.CatForCust;

                frm.CatSaved += new CatSavedEventHandler(CatAdded);


                frm.Show();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                RegBll.DeleteCatalogItem(_id);
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void btn_General_Click(object sender, EventArgs e)
        {

        }

        private void frm_CatalogList_Resize(object sender, EventArgs e)
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

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_FindOnSite frm = new frm_FindOnSite();
            frm.Show();
        }

        public void CatalogAdded(object sender)
        {
            //frm1.Close();

            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {

            frm1 = new frm_DownloadCatItems();
            frm1.CatalogDownloaded += new DownloadCatalogEventHandler(CatalogAdded);
            frm1.Show();

            //double koef = 1;
            //if (rb_113.Checked == true)
            //    koef = 1.13;

            //pb_Download.Value = 0;
            //int k = 1;
            //string article = "";
            //string unit = "";
            //double unitprice = 0;
            //string manufacturer = "";
            //int leadtime = 0;
            //double moq = 0;

            //OpenFileDialog openfiledialog1 = new OpenFileDialog();
            //openfiledialog1.InitialDirectory = "C:\\";
            //openfiledialog1.Filter = "Excel Files (*.xls)|*.xls|All files (*.*)|*.*";
            //openfiledialog1.FilterIndex = 2;
            //openfiledialog1.RestoreDirectory = true;

            //if (openfiledialog1.ShowDialog() == DialogResult.OK)
            //{
            //    //try
            //    //{

            //    string Path = openfiledialog1.FileName;

            //    Excel myExcel = new Excel();
            //    myExcel.OpenDocument(Path);

            //    while (glob_Class.NES(myExcel.GetValue("A" + k.ToString())).Trim() != "")
            //    {
            //        //MessageBox.Show(glob_Class.NES(myExcel.GetValue("A" + k.ToString())));
            //        k++;
            //    }

            //    SqlConnection sqlConn = new SqlConnection(sConnStr);
            //    string strSQL = "delete from tmp_importrmprice where irp_supid = " + cmb_Firm1.FirmId.ToString();
            //    SqlCommand sqlComm = new SqlCommand(strSQL, sqlConn);
            //    sqlConn.Open();
            //    sqlComm.ExecuteNonQuery();

            //    pb_Download.Maximum = k;
            //    if (k != 1)
            //    {
            //        k = 2;
            //        pb_Download.Value = pb_Download.Value + 1;
            //        while (glob_Class.NES(myExcel.GetValue("A" + k.ToString())) != "")
            //        {
            //            //try
            //            //{



            //            article = myExcel.GetValue("A" + k.ToString()).Trim();

            //            if (chk_BySupArt.CheckState == CheckState.Checked)
            //                article = DLL.ShowArticleBySupArt(cmb_Firm1.FirmId, article);

            //            unit = myExcel.GetValue("B" + k.ToString()).Trim();

            //            try
            //            {
            //                unitprice = glob_Class.NEN_Double(myExcel.GetValue("C" + k.ToString())) * koef;
            //            }
            //            catch { unitprice = 0; }

            //            manufacturer = glob_Class.ReplaceChar(myExcel.GetValue("F" + k.ToString()).Trim(), "'", "");

            //            try
            //            {
            //                leadtime = glob_Class.NEN_Int(myExcel.GetValue("H" + k.ToString()));
            //            }
            //            catch { leadtime = 0; }

            //            try
            //            {
            //                moq = glob_Class.NEN_Double(myExcel.GetValue("G" + k.ToString()));
            //            }
            //            catch { moq = 0; }


            //            strSQL = "insert into tmp_importrmprice (IRP_RefAxon, IRP_Unit, IRP_UnitPrice, IRP_SupId, IRP_MOQ, IRP_LeadTime, IRP_Manufacturer) " +
            //                        " VALUES ('" + article + "','" + unit + "', " + unitprice + ", " + cmb_Firm1.FirmId + ", " + moq + ", " + leadtime + ", '" + manufacturer + "')";

            //            SqlCommand sqlComm1 = new SqlCommand(strSQL, sqlConn);
            //            sqlComm1.ExecuteNonQuery();
            //            //}
            //            //catch { }
            //            pb_Download.Value = pb_Download.Value + 1;
            //            k++;
            //        }
            //    }

            //    sqlConn.Close();

            //    myExcel.CloseDocument();
            //    myExcel.Close();
            //    myExcel.Dispose();
            //    pb_Download.Value = 0;
            //    FillPrices(cmb_Firm1.FirmId);
            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            //    //}
            //}
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputHistory(igvArtId) });
        }

        private void gv_List_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
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

        private void btn_Mouser_Click(object sender, EventArgs e)
        {
            frm_FindOnSite frm = new frm_FindOnSite();
            frm.Show();
        }

        private void btn_Mouser_Click_1(object sender, EventArgs e)
        {
            frm_FindOnSite frm = new frm_FindOnSite();
            frm.Show();
        }
    }
}
