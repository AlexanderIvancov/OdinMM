using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public partial class ctl_ArtCertificates : UserControl
    {
        public ctl_ArtCertificates()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL Reg = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();

        int _articleid = 0;

        public int ArtId
        {
            get {
                return cmb_Articles1.ArticleId;
            }
            set
            {
                _articleid = value;
                //cmb_Articles1.ArticleId = _articleid;
                //bwStart(bw_List);
            }
        }

        #endregion

        #region Methods

        public void ShowDets()
        {
            var data = Reg.ArticleCertificatesData(cmb_Articles1.ArticleId);

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                Helper.RestoreDirection(gv_List, oldColumn, dir);

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

        }

        #endregion

        #region Controls
        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
            ShowDets();
        }
              

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddArtCertificates frm = new frm_AddArtCertificates();

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                  && ArtId != 0)
            {
                Reg.AddArtCertificates(frm.dateFrom, frm.Comments, frm.certNum, frm.TNVED, ArtId, frm.isValid.ToString());
                ShowDets();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _certNum = "";
            string _comments = "";
            string _dateFrom = "";
            string _dateTo = "";
            string _TNVED = "";
            int _IsValid = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_certid"].Value);
                _certNum = gv_List.CurrentRow.Cells["cn_certNum"].Value.ToString();
                _comments = Convert.ToString(gv_List.CurrentRow.Cells["cn_comments"].Value);
                _dateFrom = gv_List.CurrentRow.Cells["cn_dateFrom"].Value.ToString();
                _dateTo = gv_List.CurrentRow.Cells["cn_dateTo"].Value.ToString();
                _TNVED = gv_List.CurrentRow.Cells["cn_tnved"].Value.ToString();
                _IsValid = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_IsValid"].Value);

            }
            catch { }

            if (_id != 0)
            {
                frm_AddArtCertificates frm = new frm_AddArtCertificates();
                frm.Id = _id;
                frm.certNum = _certNum;
                frm.Comments = _comments;
                frm.dateFrom = _dateFrom;
                frm.TNVED = _TNVED;
                frm.isValid = _IsValid;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Reg.EditArtCertificates(_id, frm.dateFrom, frm.Comments, frm.certNum, frm.TNVED, frm.isValid.ToString(), ArtId);
                    ShowDets();
                }
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_certid"].Value);
            }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                Reg.DeleteArtCertificates(_id);
                ShowDets();
            }
        }


        #endregion
    }
}
