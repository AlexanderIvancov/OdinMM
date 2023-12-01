using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Odin.CMB_Components.Types
{
    public partial class frm_Types : KryptonForm
    {
        public frm_Types()
        {
            InitializeComponent();
        }

        public frm_Types(cmb_Types cmb)
        {
            InitializeComponent();
            f = new cmb_Types();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Types f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Types)cmb_TypeOne).txt_Type.Text = gv_List.CurrentRow.Cells["cn_types"].Value.ToString();
                ((cmb_Types)cmb_TypeOne).TypeId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _type = "";
            string _description = "";
            int _parentid = 0;
            string _typelat = "";
            int _custcodeid = 0;
            try {
                _id = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                _type = gv_List.CurrentRow.Cells["cn_types"].Value.ToString();
                _description = gv_List.CurrentRow.Cells["cn_description"].Value.ToString();
                _parentid = (Int32)gv_List.CurrentRow.Cells["cn_parentid"].Value;
                _typelat = gv_List.CurrentRow.Cells["cn_TypeLat"].Value.ToString();
                _custcodeid = (Int32)gv_List.CurrentRow.Cells["cn_custcodeid"].Value;
            }
            catch { }

            if (_id != 0)
            {
                _showingModal = true;

                frm_AddType frm = new frm_AddType();

                try
                {
                    frm.ParentId = _parentid;
                    frm.HeaderText = "Edit type for: " + _type;
                }
                catch
                {
                    frm.ParentId = 0;
                    frm.HeaderText = "Add type for root";
                }

                frm.Type = _type;


                frm.Id = _id;
                frm.Description = _description;
                frm.TypeLat = _typelat;
                frm.CustCodeId = _custcodeid;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    int _res = Bll.EditType(frm.Id, frm.Type, frm.Description, frm.ParentId, frm.TypeLat, frm.CustCodeId);
                    cmb_TypeOne.TypeId = _id;
                    FillData(frm.Type);
                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getTypes(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _type = "";
            try
            {
                _id = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                _type = gv_List.CurrentRow.Cells["cn_types"].Value.ToString();
            }
            catch { }

            var _query = "sp_AnalyzeArticlesDifference";

            var sqlparams = new List<SqlParameter>()
            {
                new SqlParameter("@typeid",SqlDbType.Int) {Value = _id}
            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "Articles coincidences for type: " + _type;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show();
        }

        private void btn_Parameters_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _type = "";
            try
            {
                _id = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                _type = gv_List.CurrentRow.Cells["cn_types"].Value.ToString();
            }
            catch { }

            frm_TypeParameters frm = new frm_TypeParameters();
            frm.HeaderText = "Type specification for: " +_type;
            frm.TypeId = _id;
            frm.FillList(_id);

            frm.Show();
        }
    }
}
