using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Workspace;
using Odin.Global_Classes;
using Odin.Register.Catalog;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public delegate int ReceiveArtId();
    public delegate int ReceiveNormArtId();

    public partial class frm_ArticlesManagement : BaseForm
    {

        public static event ReceiveArtId ReceiveId;
        public static event ReceiveNormArtId ReceiveNormArtId;

        KryptonDockableWorkspace kryptonDockableWorkspace = null;//kryptonDockableWorkspace1;

        public frm_ArticlesManagement()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ArticlesList.xls", this.Name);
            //_Main.ResizeBegin += (sender, e) => { ResizeBegin1(); };
            //ResizeBegin2 += new EventHandler(_Main.ResizeBegin);
        }

        #region Variables
        ExportData ED;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        string currentArticleName = String.Empty;
        //private string wrongNumberFormat = "Wrong number format entered!";
        //HSSFWorkbook hssfworkbook;
        //private string warning = "Warning! All nomenclatures for selected line will be deleted! Proceed?";
        //private List<FindAssemblyData> assemblyData = new List<FindAssemblyData>();
        OpenFileDialog openFileDialogPreview = new OpenFileDialog();
        private const string wrongFileSelected = "Wrong file selected!";
        private readonly Color notSavedCutListColor = Color.Gainsboro;
        private readonly Color parentCutListColor = Color.FromArgb(240, 240, 240);
        private readonly Color notFoundNomColor = Color.LightBlue;
        private readonly Color qtyExceedColor = Color.FromArgb(255, 170, 170);
        private const string notSavedRecordError = "The record is not saved. Impossible to complete the operation.";
        private const string notSavedRecordTitleError = "Not saved record";
        private const string decimalStringFormat = "0.##";
        private const string cpseMarkConst = "Y";
       
        //private bool isNotSavedRecords; // variable to detect emty inserted cutting list row

        private const string deleteChildsConfirm = "Are you sure want to delete all nodes?";

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



        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
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

        public ctl_Nomenclatures ctlBOM = null;
        public ctl_General ctlGen = null;
        public ctl_CatDets ctlCat = null;
        public ctl_History ctlHis = null;
        public ctl_BOMSimple ctlBOMSimple = null;
        public ctl_Assemblies ctlAssemblies = null;
        public ctl_RationingExtended ctlRatio = null;
        public ctl_Analogs ctlAnalogue = null;
        public int ControlWidth = 250;
        
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
                if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Silver;
                    }
                }
                if (Convert.ToInt32(row.Cells["cn_barg"].Value) == -1)
                    row.Cells["cn_reffirm"].Style.BackColor = Color.Yellow;
                if (Convert.ToInt32(row.Cells["cn_barg"].Value) == 1)
                    row.Cells["cn_reffirm"].Style.BackColor = Color.LightGreen;
                if (Convert.ToInt32(row.Cells["cn_barg"].Value) == 0)
                    row.Cells["cn_reffirm"].Style.BackColor = Color.Aqua;
            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            var data = Reg_BLL.getArticles(cmb_Articles1.ArticleId, cmb_Articles1.Article.Trim(), txt_SecArticle.Text, Description, 
                                            cmb_Types1.TypeId, cmb_Department1.DeptId, txt_Comments.Text, cmb_Firms1.FirmId, 
                                            txt_ExtArt.Text, chk_IsActive.CheckState == CheckState.Checked ? -1 : (chk_IsActive.CheckState == CheckState.Indeterminate ? 1 : 0),
                                            cmb_Common1.SelectedValue, rb_All.Checked == true ? 1 : (rb_Valid.Checked == true ? -1 : 0),
                                            chk_BOM.CheckState == CheckState.Checked ? -1 : (chk_BOM.CheckState == CheckState.Indeterminate ? 1 : 0),
                                            chk_MSL.CheckState == CheckState.Checked ? -1 : (chk_MSL.CheckState == CheckState.Indeterminate ? 1 : 0));

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

        public void ClearFilter()
        {
            cmb_Articles1.Article = "";
            cmb_Articles1.ArticleId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Department1.DeptId = 0;
            txt_SecArticle.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_Description.Text = string.Empty;
            txt_ExtArt.Text = string.Empty;
            cmb_Common1.SelectedValue = 0;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
        }

        private void ChangeArtIdSelection(object sender)
        {
            cmb_Articles1.ArticleId = ReceiveId();
        }
        

        private void ShowGenDetails(object sender)
        {
            int _artid = ReceiveNormArtId();
            Reg.ArtId = _artid;
            FindArtPages(_artid);
            FindCatPages(_artid);

        }

        private void ShowGenDetailsFromBOM(object sender)
        {
            int _artid = ReceiveNormArtId();
            //Reg.ArtId = _artid;
            FindArtPages(_artid);
            FindCatPages(_artid);
        }

        #endregion

        #region Controls


        private KryptonPage NewInputGeneral(string Article, int ArtId)
        {
            ctlGen = new ctl_General();
            ControlWidth = ctlGen.Width;


            ctlGen.cmb_Articles1.ArticleId = ArtId;
            ctlGen.SendArtId += new ArtIdSendingEventHandler(ChangeArtIdSelection);

            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("General article", 1, ctlGen, ctlGen.Width);
        }

        private KryptonPage NewInputBOM(string Article, int ArtId)
        {
            //ctlBOM = new ctl_Nomenclatures();
            //ControlWidth = ctlBOM.Width;

            //ctlBOM.SetFont();
            //ctlBOM.cmb_Articles1.ArticleId = ArtId;
            //ctlBOM.SendArtId += new ArtIdNormSendingEventHandler(ShowGenDetails);
            //return NewPage("Bill of materials ", 1, ctlBOM, ctlBOM.Width);

            ctlBOMSimple = new ctl_BOMSimple();
            ControlWidth = ctlBOMSimple.Width;

            ctlBOMSimple.SetFont();
            ctlBOMSimple.cmb_Articles1.ArticleId = ArtId;
            ctlBOMSimple.SendArtId += new ArtIdNormSendingEventHandler(ShowGenDetailsFromBOM);
            return NewPage("Bill of materials ", 1, ctlBOMSimple, ctlBOMSimple.Width);
        }

        private KryptonPage NewInputRatio(string Article, int ArtId)
        {
            ctlRatio  = new ctl_RationingExtended();
            ControlWidth = ctlRatio.Width;
            ctlRatio.cmb_Articles1.ArticleId = ArtId;
            return NewPage("Rationing ", 1, ctlRatio, ctlRatio.Width);
        }

        private KryptonPage NewInputAnalogue(string Article, int ArtId)
        {
            ctlAnalogue = new ctl_Analogs();
            ControlWidth = ctlAnalogue.Width;
            ctlAnalogue.cmb_Articles1.ArticleId = ArtId;
            return NewPage("Analogues ", 1, ctlAnalogue, ctlAnalogue.Width);
        }

        private KryptonPage NewInputCatalog(string Article, int ArtId)
        {
            ctlCat = new ctl_CatDets();

            ctlCat.cmb_Articles1.ArticleId = ArtId;
            //ctlCat.SendArtId += new ArtIdSendingEventHandler(ChangeArtIdSelection);
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("Catalog ", 1, ctlCat, ctlCat.Width);
        }

        private KryptonPage NewInputHistory(string Article, int ArtId)
        {
            ctlHis = new ctl_History();

            ctlHis.cmb_Articles1.ArticleId = ArtId;
            //ctlCat.SendArtId += new ArtIdSendingEventHandler(ChangeArtIdSelection);
            //MessageBox.Show(ctl.Width.ToString());
            return NewPage("History ", 1, ctlHis, ctlHis.Width);
        }

        private KryptonPage NewInputAssemblies(string Article, int ArtId)
        {
            ctlAssemblies = new ctl_Assemblies();
            ControlWidth = ctlAssemblies.Width;

            ctlAssemblies.cmb_Articles1.ArticleId = ArtId;

            ctlAssemblies.DeleteList();//FillRM();
            return NewPage("Assemblies ", 1, ctlAssemblies, ctlAssemblies.Width);
        }

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

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            Description = string.Empty;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        private void frm_ArticlesManagement_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);
            LoadColumns(gv_List);
                      
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_ExtArt.Text = string.Empty;
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
                int _res = Reg.SaveArticle(frm.Id, Regex.Replace(frm.Article, @"\p{C}+", string.Empty), frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                    frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive, 
                                    frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, 0, 0, 0/*frm.LabelsQty, frm.StencilRequired, 
                                    frm.StencilID*/, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit);
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


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
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
            ED = new ExportData(this.gv_List, "ArticlesList.xls", this.Name);
            ED.DgvIntoExcel();
        }

        #endregion

        private void btn_General_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputGeneral(Reg.Article, Reg.ArtId) });
            
            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputGeneral(Reg.Article, Reg.ArtId) });
            

            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputGeneral(Reg.Article, Reg.ArtId) });

        }

        private void btn_BOM_Click(object sender, EventArgs e)
        {           
            //kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputBOM(Reg.Article, Reg.ArtId) });
            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputBOM(Reg.Article, Reg.ArtId) });
        }


        private void btn_Rationing_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputRatio(Reg.Article, Reg.ArtId) });
        }
        
        private void btn_Suppliers_Click(object sender, EventArgs e)
        {

            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputCatalog(Reg.Article, Reg.ArtId) });

        }

        private void btn_Documents_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_SecArticle.Text = string.Empty;
        }


        private void btn_History_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddToWorkspace("Workspace", new KryptonPage[] { NewInputHistory(Reg.Article, Reg.ArtId) });
            //kryptonDockingManager1.AddDockspace("Control",
            //                                  DockingEdge.Right,
            //                                  new KryptonPage[] { NewInputHistory(Reg.Article, Reg.ArtId) });
        }
        private void btn_Assemblies_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { NewInputAssemblies(Reg.Article, Reg.ArtId) });
        }
        #endregion


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
            
            //if (igvArtId != 0)
            //    cmb_Articles1.ArticleId = igvArtId;


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

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(igvArtId);
            }
        }

        public void ShowDetails(int artid)
        {
            Reg.ArtId = artid;

            //if (ctlGen != null)
            //    ctlGen.cmb_Articles1.ArticleId = artid;

            //ctl_General ctlGen1 = (ctl_General)kryptonDockingManager1.Pages.Contains<>

            FindArtPages(artid);
            FindBOMPages(artid);
            FindRatioPages(artid);
            FindAnaloguesPages(artid);
            FindCatPages(artid);
            FindHistoryPages(artid);
            FindAssembliesPages(artid);
            //if (ctlBOM != null)
            //    ctlBOM.cmb_Articles1.ArticleId = artid;
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
                int _res = Reg.SaveArticle(frm.Id, Regex.Replace(frm.Article, @"\p{C}+", string.Empty), frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                    frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive,
                                    frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, /*frm.LabelsQty, frm.StencilRequired, 
                                    frm.StencilID*/0, 0, 0, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit);
                //MessageBox.Show(_res.ToString());
                if (_res != 0)
                {
                    //cmb_Articles1.ArticleId = _res;
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);
                    
                    SetCellsColor();

                    Reg.ArtId = _res;
                }
            }
        }
        public void FindArtPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_General ctlGen1 = (ctl_General)page.Controls.Find("ctl_General", true).FirstOrDefault();
                if (ctlGen1 != null)
                    ctlGen1.cmb_Articles1.ArticleId = artid;
                //break;
            }
        }

        public void FindHistoryPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_History ctlHis1 = (ctl_History)page.Controls.Find("ctl_History", true).FirstOrDefault();
                if (ctlHis1 != null)
                    ctlHis1.cmb_Articles1.ArticleId = artid;
                //break;
            }
        }

        public void FindAssembliesPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Assemblies ctlAss1 = (ctl_Assemblies)page.Controls.Find("ctl_Assemblies", true).FirstOrDefault();
                if (ctlAss1 != null)
                    ctlAss1.cmb_Articles1.ArticleId = artid;
                //break;
            }
        }

        public void FindBOMPages(int artid)
        {
            //foreach (var page in kryptonDockingManager1.Pages)
            //{
            //    ctl_Nomenclatures ctlBOM1 = (ctl_Nomenclatures)page.Controls.Find("ctl_Nomenclatures", true).FirstOrDefault();
            //    if (ctlBOM1 != null
            //        && ctlBOM1.Lock == 0)
            //        ctlBOM1.cmb_Articles1.ArticleId = artid;
            //    //break;
            //}
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_BOMSimple ctlBOM1 = (ctl_BOMSimple)page.Controls.Find("ctl_BOMSimple", true).FirstOrDefault();
                if (ctlBOM1 != null
                    && ctlBOM1.Lock == 0)
                    ctlBOM1.cmb_Articles1.ArticleId = artid;
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

        public void FindAnaloguesPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Analogs ctlAnalogues1 = (ctl_Analogs)page.Controls.Find("ctl_Analogs", true).FirstOrDefault();
                if (ctlAnalogues1 != null)
                    ctlAnalogues1.cmb_Articles1.ArticleId = artid;

            }
        }

        public void FindCatPages(int artid)
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_CatDets ctlCat1 = (ctl_CatDets)page.Controls.Find("ctl_CatDets", true).FirstOrDefault();
                if (ctlCat1 != null)
                    ctlCat1.cmb_Articles1.ArticleId = artid;
                //break;
            }
        }

        private void gv_List_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    try
                    {
                        // Add this
                        gv_List.CurrentCell = gv_List.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    catch { gv_List.CurrentCell = gv_List.Rows[0].Cells[0]; }
                    // Can leave these here - doesn't hurt
                    gv_List.Rows[e.RowIndex].Selected = true;
                    gv_List.Focus();
                }
            }
            catch { }
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            //MessageBox.Show("Event!");
            if (cmb_Articles1.ArticleId != 0)
                ShowDetails(cmb_Articles1.ArticleId);
            igvArtId = cmb_Articles1.ArticleId;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (globClass.DeleteConfirm() == true)
            {
                Reg.DeleteArticle(igvArtId);
                cmb_Articles1.ArticleId = 0;
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
            //kryptonDockingManager1.HideAllPages();
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
            frm.AsPF = Reg.AsPF;
            frm.MBLimit = Reg.MBLimit;
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                //Edit
                int _res = Reg.SaveArticle(0, Regex.Replace(frm.Article, @"\p{C}+", string.Empty), frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                    frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive,
                                    frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, /*frm.LabelsQty, frm.StencilRequired, 
                                    frm.StencilID*/0, 0, 0, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit);
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

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void kryptonDockableWorkspace1_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            e.Cell.Button.CloseButtonAction = CloseButtonAction.HidePage;
        }

        private void frm_ArticlesManagement_Resize(object sender, EventArgs e)
        {
            if (_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage [] { page });
                    
                }
            }
        }

        //public void ResizeBegin1(object sender, EventArgs e)
        //{
        //    kryptonDockingManager1.HideAllPages();
        //}

        //public void ResizeBegin2(object sender)
        //{
        //    //MessageBox.Show("Hide");
        //    //kryptonDockingManager1.HideAllPages();
        //}

        //public void InitiateResize()
        //{
        //    //_Main.Deactivate += ResizeBegin1;
        //    //_Main.MinimizeForm += ResizeBegin2;
        //}


        //public void ResizeEnd1(object sender)
        //{
        //    //kryptonDockingManager1.ShowAllPages();
        //} 
        //private void frm_ArticlesManagement_ResizeBegin(object sender, EventArgs e)
        //{
            
        //}

        //private void frm_ArticlesManagement_ResizeEnd(object sender, EventArgs e)
        //{
           
        //}

        private void btn_Properties_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.HideAllPages();
        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            //kryptonDockingManager1.HideAllPages();
            //kryptonDockingManager1.StoreAllPages();
            //_Main.WindowState = FormWindowState.Minimized;
            //_Main.WindowState = FormWindowState.Minimized; 
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void cmb_Articles1_ArticleKeyPressed(object sender)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
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

        private void cmb_Common1_SelectedValueChanged(object sender)
        {
           //bwStart(bw_List);
        }

        private void cmb_Types1_SelectedValueChanged(object sender)
        {
            //bwStart(bw_List);
        }

        private void cmb_Department1_SelectedValueChanged(object sender)
        {
            //bwStart(bw_List);
        }

        private void chk_IsActive_CheckedChanged(object sender, EventArgs e)
        {
            //bwStart(bw_List);
        }

        private void txt_SecArticle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

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

                bwStart(bw_List);

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

                bwStart(bw_List);

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

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
            }
        }

        private void btn_Analogs_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputAnalogue(Reg.Article, Reg.ArtId) });
        }
    }
}
