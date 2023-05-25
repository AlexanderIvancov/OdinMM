using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;

namespace Odin.Register.Articles
{
    public delegate void BOMAnalogClosingEventHandler(object sender);
    public partial class frm_BOMAnalogs : KryptonForm
    {
        public frm_BOMAnalogs()
        {
            InitializeComponent();
        }

        #region Variables

        public string HeaderText
        {
            get { return kryptonHeaderGroup1.ValuesPrimary.Heading; }
            set { kryptonHeaderGroup1.ValuesPrimary.Heading = value; }
        }

        public event BOMAnalogClosingEventHandler BOMAnalogClosing;

        int _cseid = 0;
        int _cstid = 0;
        public int CSTId
        {
            get { return _cstid; }
            set { _cstid = value; }
        }
        public int CSEId
        {
            get { return _cseid; }
            set { _cseid = value; }
        }

        public Reg_BLL Reg = new Reg_BLL();

        class_Global glob_Class = new class_Global();
        #endregion

        #region Methods

        public void FillList()
        {
            var data = Reg.BOMAnalogs(CSEId, CSTId);

            gv_List.ThreadSafeCall(delegate
                {
                    gv_List.AutoGenerateColumns = false;
                    bs_List.DataSource = data;
                    gv_List.DataSource = bs_List;
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
            frm_cmbArt frm = new frm_cmbArt();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK
                && frm.ArticleId != 0)
            {
                Reg.SaveBOMAnalog(0, CSEId, CSTId, frm.ArticleId, frm.Comments);
                FillList();
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _artid = 0;
            string _comments = "";
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
            }
            catch { }
            if (_id != 0
                && _artid != 0)
            {
                frm_cmbArt frm = new frm_cmbArt();
                frm.ArticleId = _artid;
                frm.Comments = _comments;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK
                    && frm.ArticleId != 0)
                {
                    Reg.SaveBOMAnalog(_id, CSEId, CSTId, frm.ArticleId, frm.Comments);
                    FillList();
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
                && glob_Class.DeleteConfirm())
            {
                Reg.DeleteBOMAnalog(_id);
                FillList();
            }
        }


        private void frm_BOMAnalogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BOMAnalogClosing != null)
                BOMAnalogClosing(this);
        }

        #endregion

    }
}
