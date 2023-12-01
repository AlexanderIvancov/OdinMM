using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Warehouse.Requests;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Requests
{
    public partial class frm_Requests : Form
    {
        public frm_Requests()
        {
            InitializeComponent();
        }

        public frm_Requests(cmb_Requests cmb)
        {
            InitializeComponent();
            f = new cmb_Requests();
            cmb = f;
        }
        Requests_BLL ReqBll = new Requests_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Requests f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {

                ((cmb_Requests)cmb_RequestOne).txt_Request.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_Requests)cmb_RequestOne).RequestId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;

            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getRequests(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddRequest frm = new frm_AddRequest();

            frm.FillAutoDoc(7);

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddRequestHead(frm.Comments, frm.ProdPlaceId);
                FillData(frm.Request);
                ((cmb_Requests)cmb_RequestOne).OutcomeDocSendSave();
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

                frm_AddRequest frm = new frm_AddRequest();

                frm.Id = _id;
                Bll.RequestId = _id;
                frm.Request = Bll.RequestName;
                frm.HeaderText = "Edit document: " + Bll.RequestName;
                frm.Comments = Bll.RequestComments;
                frm.ProdPlaceId = Bll.RequestProdPlace;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditRequestHead(_id, frm.Comments, frm.ProdPlaceId);
                    FillData(frm.Request);
                    ((cmb_Requests)cmb_RequestOne).OutcomeDocSendSave();
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

            if (_id != 0
                && glob_Class.DeleteConfirm() != false)
            {
                Bll.DeleteRequestHead(_id);
                FillData(string.Empty);
            }
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
