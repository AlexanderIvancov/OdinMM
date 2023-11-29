using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Warehouse.StockOut;
using System;
using System.Windows.Forms;


namespace Odin.CMB_Components.OutcomeDocs
{
    public partial class frm_OutDocs : KryptonForm
    {
        public frm_OutDocs()
        {
            InitializeComponent();
        }

        public frm_OutDocs(cmb_OutcomeDocs cmb)
        {
            InitializeComponent();
            f = new cmb_OutcomeDocs();
            cmb = f;
        }
        StockOut_BLL SOBll = new StockOut_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_OutcomeDocs f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {

                ((cmb_OutcomeDocs)cmb_OutcomeDocsOne).txt_OutcomeDoc.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_OutcomeDocs)cmb_OutcomeDocsOne).OutcomeDocId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;

            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getOutcomeDocs(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }
        public void FillDataAll(string Beg)
        {
            var data = CMB_BLL.getOutcomeDocsAll(Beg);

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

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddOutcomeDoc frm = new frm_AddOutcomeDoc();

            frm.FillAutoDoc(4);

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddOutcomeDocHead(frm.DocDate, frm.Comments, frm.TypeOff, frm.ReasonId, frm.BatchId);
                FillData(frm.OutDoc);
                ((cmb_OutcomeDocs)cmb_OutcomeDocsOne).OutcomeDocSendSave();
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

                frm_AddOutcomeDoc frm = new frm_AddOutcomeDoc();

                frm.Id = _id;
                Bll.OutDocHeadId = _id;
                frm.OutDoc = Bll.OutDocName;
                frm.HeaderText = "Edit document: " + Bll.OutDocName;
                frm.DocDate = Bll.OutDocDocDate;
                frm.TypeOff = Bll.OutDocTypeOff;
                frm.Comments = Bll.OutDocComments;
                frm.ReasonId = Bll.OutDocReasonId;
                frm.BatchId = Bll.OutDocBatchId;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditOutcomeDocHead(_id, frm.DocDate, frm.Comments, frm.TypeOff, frm.ReasonId, frm.BatchId);
                    FillData(frm.OutDoc);
                    ((cmb_OutcomeDocs)cmb_OutcomeDocsOne).OutcomeDocSendSave();
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
                && glob_Class.DeleteConfirm() == true)
            {
                Bll.DeleteOutcomeDocHead(_id);
                FillData(string.Empty);
            }
        }
    }
}
