using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public partial class ctl_BOMSetup : UserControl
    {
        public ctl_BOMSetup()
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
            get { return cmb_Articles1.ArticleId; }
            set
            {
                _articleid = value;
                //cmb_Articles1.ArticleId = _articleid;
                ShowDets();
                //bwStart(bw_List);
            }
        }

        int _lock = 0;
        public int Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        #endregion

        #region Methods

        public void ShowDets()
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectBOMSetup", ArtId);

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddSetup frm = new frm_AddSetup();

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                  && ArtId != 0)
            {
                Helper.getSP("sp_AddBOMSetup", ArtId, frm.ToolTypeId, frm.ToolId, frm.Required, frm.Qty, frm.Comments);
                ShowDets();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _tooltypeid = 0;
            int _toolid = 0;
            int _required = 0;
            double _qty = 0;
            string _comments = "";

            try {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _tooltypeid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_toolstypeid"].Value);
                _toolid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                _required = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_required"].Value);
                _qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_AddSetup frm = new frm_AddSetup();
                frm.ToolTypeId = _tooltypeid;
                frm.ToolId = _toolid;
                frm.Required = _required;
                frm.Qty = _qty;
                frm.Comments = _comments;   

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Helper.getSP("sp_EditBOMSetup", _id, frm.ToolTypeId, frm.ToolId, frm.Required, frm.Qty, frm.Comments);
                    ShowDets();
                }
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            if (//glob_Class.MessageConfirm("Are you sure you want to copy setup?", "Copy setup?") == true
                
                //&& 
                ArtId != 0)
            {
                frm_cmbArt frm = new frm_cmbArt();
                frm.HeaderText = "Copy BOM setup for " + cmb_Articles1.Article + " from article above:";
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Helper.getSP("sp_CopyBOMSetup", frm.ArticleId, ArtId);
                    ShowDets();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
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
                Helper.getSP("sp_DeleteBOMSetup", _id);
                ShowDets();
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ExportData ED;

            string _filename = "Setup.xls";
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

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _id = 0;
            int _tooltypeid = 0;
            int _toolid = 0;
            int _required = 0;
            double _qty = 0;
            string _comments = "";

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _tooltypeid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_toolstypeid"].Value);
                _toolid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                _required = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_required"].Value);
                _qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_AddSetup frm = new frm_AddSetup();
                frm.ToolTypeId = _tooltypeid;
                frm.ToolId = _toolid;
                frm.Required = _required;
                frm.Qty = _qty;
                frm.Comments = _comments;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Helper.getSP("sp_EditBOMSetup", _id, frm.ToolTypeId, frm.ToolId, frm.Required, frm.Qty, frm.Comments);
                    ShowDets();
                }
            }
        }

        private void btn_CopySetup_Click(object sender, EventArgs e)
        {
            btn_Copy.PerformClick();
        }
    }
}