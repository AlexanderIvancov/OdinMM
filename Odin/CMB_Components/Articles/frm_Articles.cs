using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Register;
using Odin.Register.Articles;
using Odin.Tools;
using Odin.Warehouse.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Odin.CMB_Components.Articles
{
    public partial class frm_Articles : Form
    {
        cmb_Articles f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        DAL_Functions DAL = new DAL_Functions();
        Reg_BLL Reg = new Reg_BLL();

        PopupWindowHelper PopupHelper = null;

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
        
        public frm_Articles()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public frm_Articles(cmb_Articles cmb)
        {
            InitializeComponent();
            f = new cmb_Articles();
            f = cmb;
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Articles)cmb_ArticleOne).txt_Article.Text = gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
                ((cmb_Articles)cmb_ArticleOne).ArticleId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                FillAliases(Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value));
            }
            catch { }
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isactive"].Value) == 0)
                {
                    row.Cells["cn_article"].Style.BackColor = Color.Silver;
                    row.Cells["cn_secname"].Style.BackColor = Color.Silver;
                    row.Cells["cn_id"].Style.BackColor = Color.Silver;
                }
            }
        }


        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddArticle frm = new frm_AddArticle();
            frm.CheckEmpty();
            frm.Id = 0;

            int number;

            bool success = Int32.TryParse(DAL.DefaultValue("unit"), out number);

            frm.UnitId = success ? number : 0;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                //Add new 
                int _res = Reg.SaveArticle(frm.Id, frm.Article, frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                    frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive, frm.CertState,
                                    frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, 
                                    /*frm.LabelsQty, frm.StencilRequired, frm.StencilID*/0, 0, 0, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit);
                if (_res != 0)
                {
                    FillData(frm.Article);
                    ((cmb_Articles)cmb_ArticleOne).ArticleSendSave();
                }
            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                _showingModal = true;

                frm_AddArticle frm = new frm_AddArticle();
                frm.CheckEmpty();

                Reg.ArtId = _id;

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
                frm.CertState = Reg.CertState;
                frm.ShowImage(frm.ImagePath);
                frm.StageId = Reg.StageId;
                frm.MSL = Reg.MSL;
                frm.Service = Reg.Service;
                //frm.LabelsQty = Reg.LabelsQty;
                //frm.StencilID = Reg.StencilID;
                //frm.StencilRequired = Reg.StencilRequired;
                frm.Warning = Reg.Warning;
                frm.SpoilConst = Reg.SpoilConst;
                frm.AsPF = Reg.AsPF;
                frm.MBLimit = Reg.MBLimit;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    //Edit
                    int _res = Reg.SaveArticle(frm.Id, frm.Article, frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                        frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive, frm.CertState,
                                        frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, /*frm.LabelsQty, frm.StencilRequired, 
                                        frm.StencilID*/0, 0, 0, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit);
                    if (_res != 0)
                    {                        
                        Reg.ArtId = _res;
                        FillData(frm.Article);
                        ((cmb_Articles)cmb_ArticleOne).ArticleId = _res;
                        ((cmb_Articles)cmb_ArticleOne).ArticleDets(_res);
                        ((cmb_Articles)cmb_ArticleOne).ArticleSendSave();
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }


            if (_id != 0 &&
                glob_Class.DeleteConfirm() == true)
            {
                Reg.DeleteArticle(_id);
                FillData("");
                ((cmb_Articles)cmb_ArticleOne).ArticleSendSave();
            }

        }

        private void txt_Stock_Click(object sender, EventArgs e)
        {
            ShowTotals();
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getArticles(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

            SetCellsColor();

        }

        public void FillAliases(int ArtId)
        {
            var data = CMB_BLL.getAliases(ArtId);

            gv_AliasList.AutoGenerateColumns = false;
            bs_AliasesList.DataSource = data;
            gv_AliasList.DataSource = bs_AliasesList;

        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void frm_Articles_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frm_Articles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && e.Control)
            {
                ShowTotals();
            }
        }

        private void gv_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && e.Control)
            {
                ShowTotals();
            }
        }

        public void ShowTotals()
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                Form f;
                f = this.FindForm();

                Point LocationPoint = this.PointToScreen(Point.Empty);
                int xpos = LocationPoint.X + this.Width;
                int ypos = LocationPoint.Y;
                Point _location = new Point(xpos, ypos);

                frm_ArtStock popup = new frm_ArtStock();

                PopupHelper.ClosePopup();

                PopupHelper.ShowPopup(f, popup, _location);

                PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
                {
                    if (popup.ShowingModal)
                    {
                        _e.Cancel = true;
                    }
                };

                popup.ctl_ArtTotals1.cmb_Articles1.ArticleId = _id;
            }
        }

        public void ShowSetup()
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                Form f;
                f = this.FindForm();

                Point LocationPoint = this.PointToScreen(Point.Empty);
                int xpos = LocationPoint.X + this.Width;
                int ypos = LocationPoint.Y;
                Point _location = new Point(xpos, ypos);

                frm_ArtSetup popup = new frm_ArtSetup();

                
                popup.Show();
                popup.Location = _location;
                //PopupHelper.ClosePopup();

                //PopupHelper.ShowPopup(f, popup, _location);

                //PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
                //{
                //    if (popup.ShowingModal)
                //    {
                //        _e.Cancel = true;
                //    }
                //};

                popup.ctl_BOMSetup1.cmb_Articles1.ArticleId = _id;
            }
        }
        public void ShowSupplier()
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                Form f;
                f = this.FindForm();

                Point LocationPoint = this.PointToScreen(Point.Empty);
                int xpos = LocationPoint.X + this.Width;
                int ypos = LocationPoint.Y;
                Point _location = new Point(xpos, ypos);

                frm_ArtSetup popup = new frm_ArtSetup();


                popup.Show();
                popup.Location = _location;
                //PopupHelper.ClosePopup();

                //PopupHelper.ShowPopup(f, popup, _location);

                //PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
                //{
                //    if (popup.ShowingModal)
                //    {
                //        _e.Cancel = true;
                //    }
                //};
            }
        }

        private void btn_CONeeds_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            var _query = "sp_RMNeedsForOrdersDets";

            var sqlparams = new List<SqlParameter>()
            {
                new SqlParameter("@ArtId",SqlDbType.Int) {Value = _id}
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "CO rm needs for: " + gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_AddAlias_Click(object sender, EventArgs e)
        {
            int _artid = 0;
            string _article = "";

            try { _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString(); }
            catch { }

            if (_artid != 0)
            {
                _showingModal = true;
                frm_cmbText frm = new frm_cmbText();
                frm.Id = 0;
                frm.HeaderText = "Add new alias for " + _article;
                frm.LabelText = "Alias:";

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    //Add new 
                    int _res = Reg.SaveAlias(0, _artid, frm.FormText);
                    if (_res != 0)
                    {
                        FillAliases(_artid);
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
        }

        private void btn_EditAlias_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _artid = 0;
            string _article = "";
            string _alias = "";
            try
            {
                _id = Convert.ToInt32(gv_AliasList.CurrentRow.Cells["cn_aliasid"].Value);
                _artid = Convert.ToInt32(gv_AliasList.CurrentRow.Cells["cn_artid"].Value);
                _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
                _alias = gv_AliasList.CurrentRow.Cells["cn_aliases"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                _showingModal = true;
                frm_cmbText frm = new frm_cmbText();
                frm.Id = 0;
                frm.HeaderText = "Edit alias for " + _article;
                frm.LabelText = "Alias:";
                frm.FormText = _alias;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    //Add new 
                    int _res = Reg.SaveAlias(_id, _artid, frm.FormText);
                    if (_res != 0)
                    {
                        FillAliases(_artid);
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
        }

        private void btn_DeleteAlias_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _artid = 0;

            try { _id = Convert.ToInt32(gv_AliasList.CurrentRow.Cells["cn_aliasid"].Value);
                _artid = Convert.ToInt32(gv_AliasList.CurrentRow.Cells["cn_artid"].Value);
            }
            catch { }


            if (_id != 0 &&
                glob_Class.DeleteConfirm() == true)
            {
                Reg.DeleteAlias(_id);
                FillAliases(_artid);
            }
        }

        private void btn_ProductCard_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                DAL.UserLogin = System.Environment.UserName;

                frm_rptProductCard frm = new frm_rptProductCard();
               
                Reg.ArtId = _id;

                frm.ArtId = Reg.ArtId.ToString();
                frm.Article = Reg.Article;
                frm.Unit = Reg.Unit;
                frm.Qty = Reg.QtyStock.ToString();
                frm.Initials = DAL.UserInitials;
                frm.Date = System.DateTime.Now.ToShortDateString();

                frm.Show(); frm.GetKryptonFormFields();
               
            }
            
        }

        private void btn_Coincidences_Click(object sender, EventArgs e)
        {
            string _article = "";

            try { _article = ((cmb_Articles)cmb_ArticleOne).Article; }
            catch { }

            var _query = "sp_AnalyzeArticlesDifferenceForArticle";

            var sqlparams = new List<SqlParameter>()
            {
                new SqlParameter("@article",SqlDbType.NVarChar, 150) {Value = _article}
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Articles coincidences for: " + _article;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Setup_Click(object sender, EventArgs e)
        {
            ShowSetup();
        }
        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            ShowSupplier();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                _showingModal = true;

                frm_AddArticle frm = new frm_AddArticle();
                frm.CheckEmpty();

                Reg.ArtId = _id;

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
                    _showingModal = false;

                    //Copy
                    int _res = Reg.SaveArticle(0, Regex.Replace(frm.Article, @"\p{C}+", string.Empty), frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                    frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive, frm.CertState,
                                    frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, /*frm.LabelsQty, frm.StencilRequired, 
                                    frm.StencilID*/0, 0, 0, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit);
                    if (_res != 0)
                    {
                        Reg.ArtId = _res;
                        FillData(frm.Article);
                        ((cmb_Articles)cmb_ArticleOne).ArticleId = _res;
                        ((cmb_Articles)cmb_ArticleOne).ArticleDets(_res);
                        ((cmb_Articles)cmb_ArticleOne).ArticleSendSave();
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
        }
    }
}
