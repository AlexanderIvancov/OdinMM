using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public delegate void SendRMArtIdEventHandler (int artid);
    public delegate void SendBOMArtIdEventHandler(int artid);

    public partial class ctl_BOMSimple : UserControl
    {
        public ctl_BOMSimple()
        {
            InitializeComponent();
            frm_ArticlesManagement.ReceiveNormArtId += new ReceiveNormArtId(RetArtId);
            PopupHelper = new PopupWindowHelper();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public event SendRMArtIdEventHandler SendRMArtId;
        public event SendBOMArtIdEventHandler SendBOMArtId;

        class_Global glob_Class = new class_Global();
        Reg_BLL Reg = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        private frm_Wait m_fmProgress = null;
        private const string processingCancelled = "Processing cancelled.";
        Font boldFont;
        Helper MyHelper = new Helper();
        PopupWindowHelper PopupHelper = null;

        int _lock = 0;
        public int Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        public string fileName
        {
            get;
            set;
        }

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        int _articleid = 0;

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                _articleid = value;
                ShowValidation(ArtId);
                ShowDets();
                //bwStart(bw_List);
            }
        }

        public void RefreshList(object sender)
        {
            ShowDets();//bwStart(bw_List);
        }

        public event ArtIdNormSendingEventHandler SendArtId;

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
        int _validid = 0;
        public int ValidId 
        {
            get { return _validid; }
            set { _validid = value; }
        }
        public string ValidAt
        {
            get { return txt_ValidAt.Text; }
            set { txt_ValidAt.Text = value; }
        }

        public string ValidBy
        {
            get { return txt_ValidBy.Text; }
            set { txt_ValidBy.Text = value; }
        }

        public string ValidState
        {
            get { return txt_ValidState.Text; }
            set { txt_ValidState.Text = value; }
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (row.Cells["cn_ciscse"].Value.ToString() == "Y")
                {
                    row.Cells["cn_art"].Style.Font = boldFont;
                    row.Cells["cn_art"].Style.ForeColor = Color.Red;
                }

                if (Convert.ToInt32(row.Cells["cn_isvalidated"].Value) == 0)
                    if (row.Cells["cn_lastchange"].Value.ToString() != ""
                        && Convert.ToDateTime(row.Cells["cn_lastchange"].Value).AddMinutes(1) >= Convert.ToDateTime(row.Cells["cn_validat"].Value))
                        if (Convert.ToInt32(row.Cells["cn_typechange"].Value) != 0)
                            foreach (DataGridViewCell cell in row.Cells)
                                cell.Style.BackColor = Color.Gold;
                        else
                            foreach (DataGridViewCell cell in row.Cells)
                                cell.Style.BackColor = Color.Plum;
                if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
            }
        }

        public bool CheckStages()
        {
            bool _tests = true;

            foreach (DataGridViewRow row in this.gv_List.Rows)
                if (Convert.ToInt32(row.Cells["cn_StageID"].Value) == 0)
                {
                    _tests = false;
                    break;
                }

            return _tests;
        }

        public bool CheckUse()
        {
            bool _tests = true;

            foreach (DataGridViewRow row in this.gv_List.Rows)
                if (Convert.ToInt32(row.Cells["cn_using"].Value) == 0)
                {
                    _tests = false;
                    break;
                }

            return _tests;
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
            var data = (DataTable)Helper.getSP("sp_BOMDetails", ArtId);

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
            SendBOMArtId?.Invoke(ArtId);
        }

        public void ShowDets()
        {
            var data = (DataTable)Helper.getSP("sp_BOMDetails", ArtId);

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

            SendBOMArtId?.Invoke(ArtId);
        }

        public void SetFont()
        {
            boldFont = new Font(gv_List.DefaultCellStyle.Font, FontStyle.Bold);
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
                return true;
            else
            {
                OldigvArtId = igvArtId;
                return false;
            }
        }

        public void SendArticle(int artid)
        {
            //Event
            SendArtId?.Invoke(this);
        }

        public void ShowValidation(int artid)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            string strSQL = "select distinct nv.id, " +
                                " nv.validat, " + 
	                            " nv.validby, " +
	                            " case nv.state when -1 then 'valid' else 'invalid' end as validstate " +
                                " from BAS_NomenclaturesValidation nv " +
                                " where artid = " + ArtId.ToString();

            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                    new SqlDataAdapter(strSQL, conn);

            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
                foreach (DataRow dr in dt.Rows)
                {
                    ValidId = Convert.ToInt32(dr["id"]);
                    ValidAt = dr["validat"].ToString();
                    ValidBy = dr["validby"].ToString();
                    ValidState = dr["validstate"].ToString();
                }
            else
            {
                ValidId = 0;
                ValidAt = "";
                ValidBy = "";
                ValidState = "invalid";
            }
        }

        public void ShowEdit()
        {

            var frm = new frm_AddBOM();
            var spoilConst = gv_List.CurrentRow.Cells["cn_spoilconst"].Value as double?;

            frm.IdCSE = Convert.ToInt32(cmb_Articles1.ArticleId);
            frm.Number = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_num"].Value);
            frm.Text = "Edit BOM line";
            frm.IdCST = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            frm.Qty = Convert.ToDecimal(gv_List.CurrentRow.Cells["cn_qty"].Value);
            frm.Comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
            frm.SpoilConst = spoilConst ?? 0;
            frm.SpoilPerc = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_spoilperc"].Value ?? 0);
            frm.Using = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_using"].Value);
            frm.StageId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value);
            frm.Positions = gv_List.CurrentRow.Cells["cn_positions"].Value.ToString();

            DialogResult result = frm.ShowDialog();
            int isUsing = frm.Using;// == -1 ? true : false;

            if (result == DialogResult.OK)
            {
                var _ID = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);

                Helper.getSP("sp_EditBOMLine", Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value),
                    frm.IdCST, frm.Number, frm.Qty, frm.Using,
                    frm.Comments, frm.SpoilConst, frm.SpoilPerc, 
                    frm.StageId, frm.Positions);

                //DataGridViewColumn oldColumn = gv_List.SortedColumn;
                //var dir = Helper.SaveDirection(gv_List);

                ShowDets();//bwStart(bw_List);

                //Helper.RestoreDirection(gv_List, oldColumn, dir);

                //SetCellsColor();

                ShowValidation(ArtId);
            }
        }
        #endregion

        #region Controls

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            if (Lock == -1)
            {
                this.btn_Lock.Values.Image = global::Odin.Global_Resourses.lock_open;
                Lock = 0;
            }
            else
            {
                this.btn_Lock.Values.Image = global::Odin.Global_Resourses._lock;
                Lock = -1;
            }
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
                Helper.LoadColumns(gv_List, this.Name);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ExportData ED;

            string _filename = "BillOfMaterials.xls";
            if (cmb_Articles1.ArticleId != 0)
                _filename = cmb_Articles1.Article + ".xls";
            ED = new ExportData(this.gv_List, _filename, this.Name);
            ED.DgvIntoExcel();
        }

        #endregion
        
        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
                SendArticle(igvArtId);
        }

        private void btn_AddNorm_Click(object sender, EventArgs e)
        {
            var frm = new frm_AddBOM();
            var numId = 0;

            try
            {
                frm.HeaderText = string.Format("Add BOM line for: " + Convert.ToString(cmb_Articles1.Article));
            }
            catch
            {
                frm.HeaderText = string.Empty;
            }

            numId = Reg.MaxNumber(ArtId);


            numId++;

            frm.Number = numId;
            frm.IdCSE = ArtId;
            frm.Tag = "Add";
            
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var insertedId = Convert.ToInt32(Helper.getSP("sp_AddBOMLine", frm.IdCSE, frm.IdCST, frm.Number, frm.Qty, frm.Using,
                                                    frm.Comments, frm.SpoilConst, frm.SpoilPerc, frm.StageId,
                                                    frm.Positions));
                //DataGridViewColumn oldColumn = gv_List.SortedColumn;
                //var dir = Helper.SaveDirection(gv_List);

                ShowDets();//bwStart(bw_List);

                //Helper.RestoreDirection(gv_List, oldColumn, dir);

                //SetCellsColor();

                ShowValidation(ArtId);
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            var frm = new frm_AddBOM();
            var numId = 0;
          
            frm.IdCSE = Convert.ToInt32(cmb_Articles1.ArticleId);
            numId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_num"].Value);
            numId++;
                       
            frm.HeaderText = string.Format("Insert new BOM line for ", Convert.ToString(cmb_Articles1.Article));
            frm.Number = numId;

            DialogResult result = frm.ShowDialog();
            int isUsing = frm.Using;// == 1 ? true : false;

            if (result == DialogResult.OK)
            {
                //Reg.IncreaseBOMNumbers(cmb_Articles1.ArticleId,
               //                             Convert.ToInt32(gv_List.CurrentRow.Cells["cn_num"].Value));

                var insertedId = Convert.ToInt32(Helper.getSP("sp_AddBOMLine", frm.IdCSE, frm.IdCST, frm.Number, frm.Qty, frm.Using,
                                                 frm.Comments, frm.SpoilConst, frm.SpoilPerc, frm.StageId,
                                                 frm.Positions));
                //DataGridViewColumn oldColumn = gv_List.SortedColumn;
                //var dir = Helper.SaveDirection(gv_List);

                ShowDets();//bwStart(bw_List);

                //Helper.RestoreDirection(gv_List, oldColumn, dir);
                //SetCellsColor();

                ShowValidation(ArtId);
            }
        }

        private void btn_EditNorm_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            var frm = new frm_cmbArt();
            frm.txt_Comments.Visible = false;
            frm.lbl_Comments.Visible = false;
            DialogResult result = frm.ShowDialog();
            frm.HeaderText = "Copy BOM from " + cmb_Articles1.Article;

            if (result == DialogResult.OK)
            {
                Helper.getSP("sp_CopyBOM", ArtId, frm.ArticleId);
                cmb_Articles1.ArticleId = frm.ArticleId;
            }
        }

        private void btn_DeleteNorm_Click(object sender, EventArgs e)
        {
            if (gv_List.SelectedRows.Count > 0)
                if (glob_Class.DeleteConfirm())
                {

                    //int _id = 0;
                    //try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
                    //catch { _id = 0; }
                    //if (_id != 0)
                    //{
                    //    Reg.DeleteBOMLine(_id);
                    //    bwStart(bw_List);
                    //}
                    int _id = 0;

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                        if (row.Selected == true)
                        {
                            try
                            {
                                _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                            }
                            catch { _id = 0; }

                            if (_id != 0)
                                Helper.getSP("sp_DeleteBOMLineById", _id);
                        }

                    //Reg.DeclineBOM(ArtId);

                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                    SetCellsColor();

                    ShowValidation(ArtId);
                }
            else
                glob_Class.ShowMessage("Warning!", "Please select rows", "You have no selected rows!");
        }

        private void ctl_BOMSimple_Load(object sender, EventArgs e)
        {
            Helper.LoadColumns(gv_List, this.Name);
            SetFont();
        }

        private void btn_Validate_Click(object sender, EventArgs e)
        {
            if (ArtId != 0
                && CheckStages() == true)
                if (CheckUse() == false)
                {
                    if (glob_Class.ConfirmMessage("Validation warning!", "Dou you still want to valid BOM?", "You have not active lines!") == true)
                    {
                        Helper.getSP("sp_AddBOMValidation", ArtId, "");
                        ShowValidation(ArtId);
                    }
                }
                else
                {
                    Helper.getSP("sp_AddBOMValidation", ArtId, "");
                    ShowValidation(ArtId);
                }

            else
                KryptonTaskDialog.Show("Validation warning!",
                                       "Some stages or article are empty!",
                                       "Some stages or article are empty!",
                                       MessageBoxIcon.Warning,
                                       TaskDialogButtons.OK);
        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            if (glob_Class.MessageConfirm("Remove validation confirmation", "Are you sure you want invalide BOM?") == true
                && ValidId != 0)
            {
                frm_cmbText frm = new frm_cmbText();
                frm.LabelText = "Comments:";
                frm.HeaderText = "Add comments for validation deletion!" ;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                    Helper.getSP("sp_DeleteBOMValidationCom", ArtId, frm.FormText);
            }
            ShowValidation(ArtId);
        }

        private void mni_Analog_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_BOMAnalogs") == true) return;

            int _cstid = 0;

            try { _cstid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value); }
            catch { }

            if (_cstid != 0
                && cmb_Articles1.ArticleId != 0)

            {
                frm_BOMAnalogs frm = new frm_BOMAnalogs();
                frm.HeaderText = "Analogs list for: " + gv_List.CurrentRow.Cells["cn_art"].Value.ToString() ;
                frm.CSEId = cmb_Articles1.ArticleId;
                frm.CSTId = _cstid;
                frm.FillList();
                frm.BOMAnalogClosing += new BOMAnalogClosingEventHandler(RefreshList);

                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        #endregion

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void mni_FilterHistory_Click(object sender, EventArgs e)
        {
            int _cstid = 0;

            try { _cstid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value); }
            catch { }

            if (_cstid != 0
                && SendRMArtId != null)
                SendRMArtId(_cstid);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowValidation(ArtId);
            ShowDets();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            var _query = "sp_SelectBOMValidationHistory";

            var sqlparams = new List<SqlParameter>()
            {
                new SqlParameter("@artid",SqlDbType.Int) {Value = cmb_Articles1.ArticleId}
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "BOM validation history for: " + cmb_Articles1.Article;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_ExportForQuote_Click(object sender, EventArgs e)
        {
            frm_cmbNumber frm = new frm_cmbNumber();
            frm.LabelText = "Qty of final product";
            frm.HeaderText = "Enter qty of final product";

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                && Convert.ToInt32(frm.FormNumber) != 0)
            {

                var _query = "sp_BOMDetailsForQuote";
                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@id",SqlDbType.Int) {Value = cmb_Articles1.ArticleId},
                    new SqlParameter("@qtycse",SqlDbType.Int) {Value = Convert.ToInt32(frm.FormNumber)}
                };

                ExportData ED;

                string _filename = "BOMQuote.xls";
                //if (cmb_Articles1.ArticleId != 0)
                //    _filename = cmb_Articles1.Article + ".xls";
                ED = new ExportData(this.gv_List, _filename, this.Name);
                ED.Query = _query;
                ED.SqlParams = sqlparams;

                ED.QueryIntoExcel();
            }
        }

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.agt_reload24x24, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        int xpos1 = 0;
        int ypos1 = 0;
        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (gv_List.CurrentRow.Cells["btn_Analogs"].Selected == true)
            //{
            //    int _cstid = 0;

            //    try { _cstid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value); }
            //    catch { }


            //    Form f;
            //    f = this.FindForm();


            //    Point LocationPoint = gv_List.PointToScreen(Point.Empty);
            //    int xpos = LocationPoint.X + 800;//xpos1 + 50;//100;
            //    int ypos = LocationPoint.Y;
            //    Point _location = new Point(xpos, ypos);
            //    //Point _location = new Point(800, 600);
            //    frm_FindAnalogs popup = new frm_FindAnalogs();

            //    PopupHelper.ClosePopup();

            //    PopupHelper.ShowPopup(f, popup, _location);

            //    PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            //    {
            //        if (popup.ShowingModal)
            //        {
            //            _e.Cancel = true;
            //        }
            //    };

            //    popup.ArtId = _cstid;
            //    popup.ArtCSEId = ArtId;
            //    //MessageBox.Show(SupId.ToString());
            //    popup.FillList();
            //    popup.AnalogChanged += new AnalogChangesEventHandler(RefreshList);
            //    //popup.ctl_StockLabel1.btn_OK.Enabled = false;
            //    //popup.ctl_StockLabel1.txt_Label.Text = _label.ToString();

            //}
        }

        private void gv_List_MouseClick(object sender, MouseEventArgs e) { }

        private void gv_List_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Rectangle rect = gv_List.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            xpos1 = rect.X;
            ypos1 = rect.Y;
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if (glob_Class.MessageConfirm("Sorting confirmation", "Are you sure you to sort BOM by types?") == true)
            {
                Helper.getSP("sp_SortBOMByType", ArtId);

                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);

                SetCellsColor();
            }
        }


        //Peretaskivanie linii

        int dragRow = -1;
        Label dragLabel = null;
        int DragId = 0;

        private void gv_List_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
                dragRow = e.RowIndex;
                if (dragLabel == null) dragLabel = new Label();
                dragLabel.Text = gv_List[e.ColumnIndex, e.RowIndex].Value.ToString();
                dragLabel.Parent = gv_List;
                dragLabel.Location = e.Location;
                DragId = Convert.ToInt32(gv_List["cn_id", e.RowIndex].Value);
            }
        }

        private void gv_List_MouseMove(object sender, MouseEventArgs e)
        {
            //if (ModifierKeys.HasFlag(Keys.Control))
                if (e.Button == MouseButtons.Left && dragLabel != null)
                {
                    dragLabel.Location = e.Location;
                    gv_List.ClearSelection();
                }
        }

        private void gv_List_MouseUp(object sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                try
                {
                    int _LineNumber = 0;
                    var hit = gv_List.HitTest(e.X, e.Y);
                    int dropRow = -1;
                    if (hit.Type != DataGridViewHitTestType.None)
                    {
                        dropRow = hit.RowIndex;
                        if (dragRow >= 0
                            && dragRow != dropRow)
                        {

                            DataGridViewRow row = gv_List.Rows[dropRow];

                            _LineNumber = Convert.ToInt32(row.Cells["cn_num"].Value);

                            Helper.getSP("sp_EditBOMLineNumber", DragId, _LineNumber);

                            DataGridViewColumn oldColumn = gv_List.SortedColumn;
                            var dir = Helper.SaveDirection(gv_List);

                            bwStart(bw_List);

                            Helper.RestoreDirection(gv_List, oldColumn, dir);

                            SetCellsColor();

                        }
                    }
                    else { gv_List.Rows[dragRow].Selected = true; }

                    if (dragLabel != null)
                    {
                        dragLabel.Dispose();
                        dragLabel = null;
                    }
                }
                catch { }
            }
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["btn_Analogs"].Selected == true)
            {
                int _cstid = 0;

                try { _cstid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value); }
                catch { }


                Form f;
                f = this.FindForm();


                Point LocationPoint = gv_List.PointToScreen(Point.Empty);
                int xpos = LocationPoint.X + 800;//xpos1 + 50;//100;
                int ypos = LocationPoint.Y;
                Point _location = new Point(xpos, ypos);
                //Point _location = new Point(800, 600);
                frm_FindAnalogs popup = new frm_FindAnalogs();

                PopupHelper.ClosePopup();

                PopupHelper.ShowPopup(f, popup, _location);

                PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
                {
                    if (popup.ShowingModal)
                        _e.Cancel = true;
                };

                popup.ArtId = _cstid;
                popup.ArtCSEId = ArtId;
                //MessageBox.Show(SupId.ToString());
                popup.FillList();
                popup.AnalogChanged += new AnalogChangesEventHandler(RefreshList);
                //popup.ctl_StockLabel1.btn_OK.Enabled = false;
                //popup.ctl_StockLabel1.txt_Label.Text = _label.ToString();

            }
        }
    }
}