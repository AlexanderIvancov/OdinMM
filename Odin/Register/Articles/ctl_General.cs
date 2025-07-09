using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public delegate void ArtIdSendingEventHandler(object sender);

    public partial class ctl_General : UserControl
    {
        public ctl_General()
        {
            InitializeComponent();
            frm_ArticlesManagement.ReceiveId += new ReceiveArtId(RetArtId);
        }

        public event ArtIdSendingEventHandler SendArtId;

        #region Variables
        public int Id
        {
            get
            {
                try { return cmb_Articles1.ArticleId; }
                catch { return 0; }
            }
            set { cmb_Articles1.ArticleId = value; }
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

        public int RetArtId()
        {
            return Id;
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;


        Reg_BLL Reg = new Reg_BLL();
        DAL_Functions DLL = new DAL_Functions();
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
            get { return cmb_Articles1.Article; }
            set { }
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

        public double SpoilConst
        {
            get
            {
                try { return Convert.ToDouble(txt_SpoilConst.Text); }
                catch { return 0; }
            }
            set { txt_SpoilConst.Text = value.ToString(); }
        }


        public int UnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
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
            get
            {
                try { return Convert.ToDouble(txt_QtyReserve.Text); }
                catch { return 0; }
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
        int _artid = 0;

        public int ArtId
        {
            get { return _artid; }
            set
            {
                _artid = value;
                
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "execute sp_SelectArticleDets @id = " + _artid, conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        SecName = dr["secname"].ToString();
                        UnitId = Convert.ToInt32(dr["unitid"]);
                        Description = dr["Description"].ToString();
                        Comments = dr["Comments"].ToString();
                        TypeId = Convert.ToInt32(dr["typeid"]);
                        Weight = Convert.ToDouble(dr["weight"]);
                        CustCodeId = Convert.ToInt32(dr["CustCodeId"]);
                        DeptId = Convert.ToInt32((dr["deptid"]).ToString());
                        ImagePath = dr["imagepath"].ToString();
                        QtyReserve = Convert.ToDouble(dr["QtyReserve"]);
                        CreateSubBatch = Convert.ToInt32(dr["createsubbatch"]);
                        IsActive = Convert.ToInt32(dr["isactive"]);
                        Revision = dr["revision"].ToString();
                        StoreRules = dr["storagerules"].ToString();
                        SpoilNorm = Convert.ToDouble(dr["spoilnorm"]);
                        StageId = Convert.ToInt32(dr["stageid"]);
                        MSL = dr["msl"].ToString();
                        Service = Convert.ToInt32(dr["service"]);
                        //LabelsQty = 0;//Convert.ToInt32(dr["qtylabels"]); 
                        //StencilRequired = Convert.ToInt32(dr["stencilrequired"]); 
                        //StencilID = Convert.ToInt32(dr["stencilid"]); 
                        SpoilConst = Convert.ToDouble(dr["spoilconst"]);
                        AsPF = Convert.ToInt32(dr["AsPF"]);
                    }
                }
                else
                {
                    ClearArtFields();
                }

                ShowImage(ImagePath);
            }


        }

        public void ClearArtFields()
        {
            SecName = "";
            Description = "";
            Comments = "";
            TypeId = 0;

            UnitId = 0;

            DeptId = 0;

            Comments = "";
            CustCodeId = 0;
            ImagePath = "";
            CreateSubBatch = 0;
            Weight = 0;
            QtyReserve = 0;
            Revision = "";
            StoreRules = "";
            IsActive = -1;
            SpoilNorm = 0;
            StageId = 0;
            MSL = "1";
            Service = 0;
            //LabelsQty = 0;
            //StencilRequired = 0;
            //StencilID = 0;
            SpoilConst = 0;
            AsPF = 0;
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
            //MessageBox.Show(cmb_Articles1.Department);
        }

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

        #endregion

        #region Controls


        private void btn_OK_Click(object sender, EventArgs e)
        {
            int _res = Reg.SaveArticle(Id, Regex.Replace(Article, @"\p{C}+", string.Empty), SecName, Description, TypeId, UnitId, ImagePath, Comments,
                                    CustCodeId, QtyReserve, DeptId, CreateSubBatch, Weight, IsActive, "Certified",
                                    Revision, StoreRules, SpoilNorm, StageId, MSL, Service, /*LabelsQty, StencilRequired, StencilID*/
                                    0, 0, 0, Warning, SpoilConst, AsPF, MBLimit);
            //Event
            //if (SendArtId != null)
            //{
            //    SendArtId(this);
            //}
        }

        #endregion

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            SecName = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            Description = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            Comments = string.Empty;
        }

        private void buttonSpecAny7_Click(object sender, EventArgs e)
        {
            StoreRules = string.Empty;
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
    }    
}
