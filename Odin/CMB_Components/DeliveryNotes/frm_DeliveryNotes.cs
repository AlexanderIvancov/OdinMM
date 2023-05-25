using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;
using Odin.Warehouse.Deliveries;

namespace Odin.CMB_Components.DeliveryNotes
{
    public partial class frm_DeliveryNotes : Form
    {
        public frm_DeliveryNotes()
        {
            InitializeComponent();
        }

        public frm_DeliveryNotes(cmb_DeliveryNotes cmb)
        {
            InitializeComponent();
            f = new cmb_DeliveryNotes();
            cmb = f;
        }
        DelivNote_BLL DNBll = new DelivNote_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_DeliveryNotes f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {

                ((cmb_DeliveryNotes)cmb_DeliveryNoteOne).txt_DeliveryNote.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_DeliveryNotes)cmb_DeliveryNoteOne).DelivNoteId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;

            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getDeliveryNotes(Beg);

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

            frm_AddDeliveryNote frm = new frm_AddDeliveryNote();

            frm.FillAutoDoc(9);
            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddDelivNoteHead(frm.DocDate, frm.DelivDate, frm.Comments, frm.DelivPlaceId, frm.DelivAddressId,
                                                frm.FinalDelivPlaceId, frm.FinalDelivAddressId, frm.TransportId, frm.IncotermsId,
                                                frm.QtyPalettes, frm.PalettesWeight, frm.CreditAccount, frm.IsReturn, frm.NoReversePVN,
                                                frm.Internal);
                FillData(frm.DelivNote);
                ((cmb_DeliveryNotes)cmb_DeliveryNoteOne).DelivNoteSendSave();
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

                frm_AddDeliveryNote frm = new frm_AddDeliveryNote();

                
                frm.Id = _id;
                
                
                Bll.DelivNoteHeadId = _id;

                frm.HeaderText = "Edit delivery note: " + Bll.DelivNote;
                frm.DelivNote = Bll.DelivNote;
                frm.DocDate = Bll.DLNDocDate;
                frm.DelivDate = Bll.DLNDelivDate;
                frm.Comments = Bll.DLNComments;
                frm.DelivPlaceId = Bll.DLNDelivPlaceId;
                frm.DelivAddressId = Bll.DLNDelivAddressId;
                frm.FinalDelivPlaceId = Bll.DLNFinalDelivPlaceId;
                frm.FinalDelivAddressId = Bll.DLNFinalDelivAddressId;
                frm.TransportId = Bll.DLNTransportId;
                frm.IncotermsId = Bll.DLNIncotermsId;
                frm.QtyPalettes = Bll.DLNPalQty;
                frm.PalettesWeight = Bll.DLNPalWeight;
                frm.CreditAccount = Bll.DLNCreditAccount;
                frm.IsReturn = Bll.DLNIsReturn;
                frm.NoReversePVN = Bll.DLNNoReversePVN;
                frm.Internal = Bll.DLNInternal;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditDelivNoteHead(_id, frm.DocDate, frm.DelivDate, frm.Comments, frm.DelivPlaceId, frm.DelivAddressId,
                                                frm.FinalDelivPlaceId, frm.FinalDelivAddressId, frm.TransportId, frm.IncotermsId,
                                                frm.QtyPalettes, frm.PalettesWeight, frm.CreditAccount, frm.IsReturn, frm.NoReversePVN,
                                                frm.Internal);
                    FillData(frm.DelivNote);
                    ((cmb_DeliveryNotes)cmb_DeliveryNoteOne).DelivNoteSendSave();
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
                Bll.DeleteDelivNoteHead(_id);
                FillData(string.Empty);
            }
        }
    }
}
