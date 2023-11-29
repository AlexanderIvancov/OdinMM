using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Tools;

namespace Odin.Register.Articles
{
    public partial class ctl_Analogs : UserControl
    {
        public ctl_Analogs()
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
        int _artcseid = 0;

        public int ArtCseId
        { get { return _artcseid; }
            set { _artcseid = value; } }
        #endregion

        #region Methods

        public void ShowDets()
        {
            var data = Reg.ArticleAnaloguesData(ArtId, ArtCseId);

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
        }
              

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddAnalog frm = new frm_AddAnalog();

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                  && ArtId != 0)
            {
                Reg.AddAnalog(ArtId, frm.AnalogId, frm.CustomerId, frm.Comments, frm.ProductId);
                ShowDets();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _analogid = 0;
            int _customerid = 0;
            string _comments = "";
            int _productid = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _analogid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_analogid"].Value);
                _customerid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_customerid"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _productid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_productid"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddAnalog frm = new frm_AddAnalog();
                frm.AnalogId = _analogid;
                frm.CustomerId = _customerid;
                frm.Comments = _comments;
                frm.ProductId = _productid;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Reg.EditAnalog (_id, frm.AnalogId, frm.CustomerId, frm.Comments, frm.ProductId);
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
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                Reg.DeleteAnalog(_id);
                ShowDets();
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ExportData ED;

            string _filename = "Analog.xls";
            if (cmb_Articles1.ArticleId != 0)
                _filename = "Analogs " + cmb_Articles1.Article + ".xls";
            ED = new ExportData(this.gv_List, _filename, this.Name);
            ED.DgvIntoExcel();
        }

        #endregion
    }
}
