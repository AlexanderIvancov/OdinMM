using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Warehouse.Movements;
using System;
using System.Windows.Forms;


namespace Odin.CMB_Components.MoveDocs
{
    public partial class frm_MoveDocs : KryptonForm
    {
        public frm_MoveDocs()
        {
            InitializeComponent();
        }

        public frm_MoveDocs(cmb_MoveDocs cmb)
        {
            InitializeComponent();
            f = new cmb_MoveDocs();
            cmb = f;
        }

        StockMove_BLL MovBll = new StockMove_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_MoveDocs f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {

                ((cmb_MoveDocs)cmb_MoveDocOne).txt_MoveDoc.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_MoveDocs)cmb_MoveDocOne).MoveDocId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;

            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getMoveDocs(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddMoveDoc frm = new frm_AddMoveDoc();

            frm.FillAutoDoc(6);
            
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddMoveDocHead(frm.DocDate, frm.DelivDate, frm.Comments, frm.DestPlaceId, frm.DelivAddressId, frm.FinDestPlaceId, frm.FinDelivAddressId,
                                                frm.TransportId, frm.IncotermsId, frm.PalettesQty, frm.PalettesWeight, frm.BatchId, frm.StageId, frm.QtyToProduce);
                FillData(frm.MoveDoc);
                ((cmb_MoveDocs)cmb_MoveDocOne).MoveDocSendSave();
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

                frm_AddMoveDoc frm = new frm_AddMoveDoc();

                Bll.MoveDocHeadId = _id;

                frm.HeaderText = "Edit document: " + Bll.MoveDocName;
                frm.MoveDoc = Bll.MoveDocName;
                frm.DocDate = Bll.MoveDocDocDate;
                frm.DelivDate = Bll.MoveDocDelivDate;
                frm.Comments = Bll.MoveDocComments;
                frm.DestPlaceId = Bll.MoveDocDelivPlaceId;
                frm.DelivAddressId = Bll.MoveDocDelivAddressId;
                frm.FinDestPlaceId = Bll.MoveDocFinDestPlaceId;
                frm.FinDelivAddressId = Bll.MoveDocFinDestAddressId;
                frm.TransportId = Bll.MoveDocTransportId;
                frm.IncotermsId = Bll.MoveDocIncotermsId;
                frm.PalettesQty = Bll.MoveDocPalettesQty;
                frm.PalettesWeight = Bll.MoveDocPalettesWeight;
                frm.BatchId = Bll.MoveDocBatchId;
                frm.QtyToProduce = Bll.MoveQtyOnStage;
                frm.StageId = Bll.MoveStageId;
               
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditMoveDocHead(_id, frm.DocDate, frm.DelivDate, frm.Comments, frm.DestPlaceId, frm.DelivAddressId, frm.FinDestPlaceId, frm.FinDelivAddressId,
                                       frm.TransportId, frm.IncotermsId, frm.PalettesQty, frm.PalettesWeight, frm.BatchId, frm.StageId, frm.QtyToProduce);
                    FillData(frm.MoveDoc);
                    ((cmb_MoveDocs)cmb_MoveDocOne).MoveDocSendSave();
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
                Bll.DeleteMoveDocHead(_id);
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
