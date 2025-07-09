using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public partial class frm_AddArticle : KryptonForm
    {
        public frm_AddArticle()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get
            { try { return Convert.ToInt32(txt_Id.Text); }
                catch { return 0; }
            }
            set { txt_Id.Text = value.ToString(); }
        }
        public int AsPF
        {
            get
            {
                try { return cmb_Articles2.ArticleId; }
                catch { return 0; }
            }
            set { cmb_Articles2.ArticleId = value; }
        }
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        Reg_BLL Reg = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Revision
        {
            get { return txt_Revision.Text; }
            set { txt_Revision.Text = value; }
        }
        public string Article
        {
            get { return txt_Article.Text; }
            set { txt_Article.Text = value; }
        }
        public string SecName
        {
            get { return txt_2ndName.Text; }
            set { txt_2ndName.Text = value; }
        }
       
        public double SpoilNorm
        {
            get
            {
                try { return Convert.ToDouble(txt_SpoilNorm.Text); }
                catch { return 0; }
            }
            set { txt_SpoilNorm.Text = value.ToString(); }
        }
        
        public int UnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
        }
        

        public string Unit
        {
            get { return cmb_Units1.Unit; }
            set { cmb_Units1.Unit = value; }
        }

        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }
        public int TypeId
        {
            get { return cmb_Types1.TypeId; }
            set { cmb_Types1.TypeId = value; }
        }
        public int DeptId
        {
            get { return cmb_Department1.DeptId; }
            set { cmb_Department1.DeptId = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        public string StoreRules
        {
            get { return txt_StorRules.Text; }
            set { txt_StorRules.Text = value; }
        }
        
        public int CustCodeId
        {
            get { return cmb_CustCodes1.CustCodeId; }
            set { cmb_CustCodes1.CustCodeId = value; }
        }
        public double Weight
        {
            get
            {
                try { return Convert.ToDouble(txt_Weight.Text); }
                catch { return 0; }
            }
            set { txt_Weight.Text = value.ToString(); }
        }
       
        public int CreateSubBatch
        {
            get
            {
                return chk_SubBatch.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_SubBatch.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }
        public int Service
        {
            get
            {
                return chk_Service.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_Service.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }
        public string ImagePath
        {
            get { return txt_Image.Text; }
            set { txt_Image.Text = value; }
        }

        public int IsActive
        {
            get
            {
                return chk_IsActive.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_IsActive.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }
        public double QtyReserve
        {
            get {
                try { return Convert.ToDouble(txt_QtyReserve.Text); }
            catch{ return 0; }
        }
            set { txt_QtyReserve.Text = value.ToString(); }
        }

        public int StageId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }

        public string MSL
        {
            get { return cmb_MSL.Text; }
            set { cmb_MSL.Text = value; }
        }

        public string CertState
        {
            get { return cmb_CertState.Text; }
            set { cmb_CertState.Text = value; }
        }

        //public int LabelsQty
        //{
        //    get
        //    {
        //        try { return Convert.ToInt32(txt_LabelsQty.Text); }
        //        catch { return 0; }
        //    }
        //    set { txt_LabelsQty.Text = value.ToString(); }
        //}

        //public int StencilRequired
        //{
        //    get
        //    {
        //        if (chk_StencilRequired.CheckState == CheckState.Checked)
        //            return -1;
        //        else
        //            return 0;
        //    }
        //    set
        //    {
        //        if (value == -1)
        //            chk_StencilRequired.CheckState = CheckState.Checked;
        //        else
        //            chk_StencilRequired.CheckState = CheckState.Unchecked;
        //    }
        //}

        //public int StencilID
        //{
        //    get { return cmb_Stencil.ArticleId; }
        //    set { cmb_Stencil.ArticleId = value; }
        //}

        public double SpoilConst
        {
            get
            {
                try { return Convert.ToDouble(txt_SpoilConst.Text); }
                catch { return 0; }
            }
            set { txt_SpoilConst.Text = value.ToString(); }
        }

        public int Warning
        {
            get
            {
                return chk_Warning.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_Warning.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int MBLimit
        {
            get
            {
                return chk_MBLimit.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_MBLimit.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }


        #endregion


        #region Controls

        public void CheckEmpty()
        {

            if (Article == ""
                || UnitId == 0
                || TypeId == 0
                || DAL.CheckArticleSameName(Id, Article) != 0)
            {
                btn_OK.Enabled = false;
                txt_Article.StateCommon.Back.Color1 = DAL.CheckArticleSameName(Id, Article) != 0 ? Color.LightPink : Color.White;
            }
            else
            {
                btn_OK.Enabled = true;
                txt_Article.StateCommon.Back.Color1 = Color.White;
            }
            if (Id == 0)
            {
                if (DAL.ArticleId(Article) != 0)
                {
                    txt_Article.BackColor = Color.Red;
                    btn_OK.Enabled = false;
                }
                else
                {
                    txt_Article.BackColor = Color.White;
                }

            }
        }

        //public void ShowImage(string Path)
        //{
        //    try
        //    {

        //        pic_Image.ImageLocation = Path;
        //        pic_Image.Load();


        //    }
        //    catch
        //    {

        //        pic_Image.Image = null;
        //    }
        //}
        private Bitmap GetImageFromPath(string Path)
        {
            StreamReader streamReader = new StreamReader(Path);
            Bitmap originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
            return originalBitmap;
        }


        public void ShowImage(string Path)
        {
            try
            {
                pic_Image.Image = GetImageFromPath(Path);
                //pic_Image.ImageLocation = Path;
                //pic_Image.Load();


            }
            catch
            {

                pic_Image.Image = null;
            }
        }

        private void btn_GetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.InitialDirectory = "C:\\";
            openfiledialog1.Filter = "Image Files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openfiledialog1.FilterIndex = 2;
            openfiledialog1.RestoreDirectory = true;


            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImagePath = openfiledialog1.FileName;
                    ShowImage(ImagePath);
                }
                catch (Exception ex)
                { MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message); }
            }
        }
        #endregion
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Article.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_2ndName.Text = string.Empty;
        }
        
        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_Revision.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_Image.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            txt_StorRules.Text = string.Empty;
        }

        private void txt_Article_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void cmb_Types1_SelectedValueChanged(object sender)
        {
            CheckEmpty();
        }

        private void cmb_Units1_UnitChanged(object sender)
        {
            CheckEmpty();
        }

        private void pic_Image_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(ImagePath);
            }
            catch { }
            //frm_FullImage frm = new frm_FullImage();
            //frm.HeaderText = "Image for: " + Article.ToString();

            //frm.ShowImage(ImagePath);

            //DialogResult result = frm.ShowDialog();
        }

        private void btn_Concidences_Click(object sender, EventArgs e)
        {
            string _article = "";

            try { _article = Article; }
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

        private void btn_CreatePF_Click(object sender, EventArgs e)
        {
            int _res = Reg.AddArticlePF();

            Reg.ArtId = _res;

            Id = Reg.ArtId;
            Article = Reg.Article;
            SecName = Reg.SecName;
            Description = Reg.Description;
            TypeId = Reg.TypeId;
            UnitId = Reg.UnitId;
            ImagePath = Reg.ImagePath;
            Comments = Reg.Comments;
            CustCodeId = Reg.CustCodeId;
            QtyReserve = Reg.QtyReserve;
            DeptId = Reg.DeptId;
            CreateSubBatch = Reg.CreateSubBatch;
            Weight = Reg.Weight;
            IsActive = Reg.IsActive;
            CertState = Reg.CertState;
            Revision = Reg.Revision;
            StoreRules = Reg.StorageRules;
            SpoilNorm = Reg.SpoilNorm;
            ShowImage(ImagePath);
            StageId = Reg.StageId;
            MSL = Reg.MSL;
            Service = Reg.Service;
            //frm.LabelsQty = Reg.LabelsQty;
            //frm.StencilRequired = Reg.StencilRequired;
            //frm.StencilID = Reg.StencilID;
            Warning = Reg.Warning;
            SpoilConst = Reg.SpoilConst;
            AsPF = Reg.AsPF;
        }
    }
}
