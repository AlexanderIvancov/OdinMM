using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public partial class ctl_Assemblies : UserControl
    {
        public ctl_Assemblies()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL BLL = new Reg_BLL();

        int _ArtId = 0;

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                
                _ArtId = value;
                
            }
        }

        public void DeleteList()
        {
            BLL.DeleteArticleForAnalyzisAll();
        }

        public void FillRM()
        {
            var data = Reg_BLL.getArticleForAnalyzis();

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
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArticleId = cmb_Articles1.ArticleId;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Articles1.ArticleId != 0)
            {
                BLL.AddArticleForAnalyzis(ArticleId);
                FillRM();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            BLL.DeleteArticleForAnalyzis(_id);
            FillRM();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectAssemblies");

            gv_ResList.ThreadSafeCall(delegate
            {
                gv_ResList.AutoGenerateColumns = false;
                bs_ResList.DataSource = data;
                gv_ResList.DataSource = bs_ResList;

                //SetCellsColor();
            });


            bn_ResList.ThreadSafeCall(delegate
            {
                bn_ResList.BindingSource = bs_ResList;
            });
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

            BLL.DeleteArticleForAnalyzisAll();
            FillRM();
        }
    }
}
