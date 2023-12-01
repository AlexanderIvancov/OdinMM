using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.IncomeDocs
{
    public partial class frm_IncomeDocs : KryptonForm
    {
        public frm_IncomeDocs()
        {
            InitializeComponent();
        }

        public frm_IncomeDocs(cmb_IncomeDoc cmb)
        {
            InitializeComponent();
            f = new cmb_IncomeDoc();
            cmb = f;
        }

        //StockIn_BLL POBll = new StockIn_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_IncomeDoc f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                
                    ((cmb_IncomeDoc)cmb_IncomeDocOne).txt_IncomeDoc.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                    ((cmb_IncomeDoc)cmb_IncomeDocOne).IncomeDocId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getIncomeDocs(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddIncomeDoc frm = new frm_AddIncomeDoc();

            frm.FillDate();
            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddIncomeDocHead(frm.IncomeDoc, frm.Serie, frm.RegDate, frm.DocDate, frm.SupId, frm.Comments, frm.CurId, frm.CurRate, frm.SenderCountryId,
                                                frm.ProducerCountryId, frm.Bargain, frm.TransportId, frm.IncotermsId, frm.AdditCost, frm.Advance, frm.AdvanceDate,
                                                frm.PayDate, frm.NoReversePVN, frm.MediatedCost, frm.Check);
                FillData(frm.IncomeDoc);
                ((cmb_IncomeDoc)cmb_IncomeDocOne).IncomeDocSendSave();
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

                frm_AddIncomeDoc frm = new frm_AddIncomeDoc();

                Bll.IncomeDocHeadId = _id;
                frm.IncomeDoc = Bll.IncomeDocName;
                frm.Id = _id;
                frm.HeaderText = "Edit income document: " + frm.IncomeDoc;

                frm.Serie = Bll.IncomeDocSerie;
                frm.RegDate = Bll.IncomeDocRegDate;
                frm.DocDate = Bll.IncomeDocDocDate;
                frm.Comments = Bll.IncomeDocComments;
                frm.SupId = Bll.IncomeDocSupId;
                frm.CurId = Bll.IncomeDocCurId;
                frm.CurRate = Bll.IncomeDocCurRate;
                frm.SenderCountryId = Bll.IncomeDocSender;
                frm.ProducerCountryId = Bll.IncomeDocProducer;
                frm.TransportId = Bll.IncomeDocTransportId;
                frm.IncotermsId = Bll.IncomeDocIncotermsId;
                frm.Bargain = Bll.IncomeDocBargain;
                frm.AdditCost = Bll.IncomeDocAdditCost;
                frm.Advance = Bll.IncomeDocAdvance;
                frm.AdvanceDate = Bll.IncomeDocAdvanceDate;
                frm.PayDate = Bll.IncomeDocPayDate;
                frm.NoReversePVN = Bll.IncomeDocNoReversePVN;
                frm.MediatedCost = Bll.IncomeDocMediatedCost;
                frm.Check = Bll.IncomeDocCheck;
                frm.CheckEmpty();
                frm.RecalcCurRate();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditIncomeDocHead(_id, frm.IncomeDoc, frm.Serie, frm.RegDate, frm.DocDate, frm.SupId, frm.Comments, frm.CurId, frm.CurRate, frm.SenderCountryId,
                                                    frm.ProducerCountryId, frm.Bargain, frm.TransportId, frm.IncotermsId, frm.AdditCost, frm.Advance, frm.AdvanceDate,
                                                    frm.PayDate, frm.NoReversePVN, frm.MediatedCost, frm.Check);
                    if (Bll.IncomeDocRegDate != frm.RegDate)
                        Bll.CheckSendResaleLetter(_id);

                    FillData(frm.IncomeDoc);
                    ((cmb_IncomeDoc)cmb_IncomeDocOne).IncomeDocSendSave();
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
                Bll.DeleteIncomeDocHead(_id);
                FillData(string.Empty);
            }
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }
    }
}
