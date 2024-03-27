using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Warehouse.Deliveries;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.DeliveryNotes
{
    public delegate void DelivNoteEventHandler(object sender);
    public delegate void DelivNoteSavedEventHandler(object sender);

    public partial class cmb_DeliveryNotes : UserControl
    {
        public cmb_DeliveryNotes()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event DelivNoteEventHandler DelivNoteChanged;
        public event DelivNoteSavedEventHandler DelivNoteSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _DelivNoteId = 0;
        int _PrevId = 0;

        DelivNote_BLL SMBll = new DelivNote_BLL();
        CMB_BLL Bll = new CMB_BLL();

        bool _EnableSearchId = false;
        string _DelivNote = "";
        public string DelivNote
        {
            get { return txt_DeliveryNote.Text; }
            set
            {
                _DelivNote = value;
                txt_DeliveryNote.Text = value;

                //if (_PrevId != _DelivNoteId)
                //{
                    DataTable dt = Helper.QueryDT("SELECT DISTINCT TOP 1 id FROM STO_StockOutHead WHERE name = '" + _DelivNote.ToString() + "'");

                    if (dt.Rows.Count > 0)
                        foreach (DataRow dr in dt.Rows)
                            DelivNoteId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                    else
                        _DelivNoteId = 0;

                    DelivNoteChanged?.Invoke(this);
                    //return;
                    //}

                    //_PrevId = _DelivNoteId;
            }
        }
        public int DelivNoteId
        {
            get
            {
                try { return _DelivNoteId; }
                catch { return 0; }
            }
            set
            {
                _DelivNoteId = value;

                if (_PrevId != _DelivNoteId)
                {
                    DataTable dt = Helper.QueryDT("SELECT top 1 * FROM STO_StockOutHead WHERE id = " + _DelivNoteId.ToString());

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                            //DelivNote = dr["name"].ToString();
                            txt_DeliveryNote.Text = dr["name"].ToString();
                        DelivNoteChanged?.Invoke(this);
                    }
                    else
                         //DelivNote = string.Empty;
                        txt_DeliveryNote.Text = string.Empty;

                    _PrevId = _DelivNoteId;

                    //if (OutDocChanged != null)
                    //{
                    //    OutDocChanged(this);
                    //}
                }
            }
        }
        int _DelivNoteSavedId = 0;
        public int DelivNoteSavedId
        {
            get { return _DelivNoteSavedId; }
            set
            {
                _DelivNoteSavedId = value;
                DelivNoteSaved?.Invoke(this);
            }
        }

        public void DelivNoteSendSave()
        {
            DelivNoteSaved?.Invoke(this);
        }

        public bool EnableSearchId
        {
            get { return _EnableSearchId; }
            set { _EnableSearchId = value; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_DeliveryNote.Text = string.Empty;
        }

        private void txt_DeliveryNote_TextChanged(object sender, EventArgs e)
        {
            //try {
                DelivNote = txt_DeliveryNote.Text;
           // }
            //catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddDeliveryNote frm = new frm_AddDeliveryNote();

            frm.FillAutoDoc(9);
            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = Convert.ToInt32(Helper.getSP("sp_AddDelivNoteHead", frm.DocDate, frm.DelivDate, frm.Comments, frm.DelivPlaceId, frm.DelivAddressId,
                                                frm.FinalDelivPlaceId, frm.FinalDelivAddressId, frm.TransportId, frm.IncotermsId,
                                                frm.QtyPalettes, frm.PalettesWeight, frm.CreditAccount, frm.IsReturn, frm.NoReversePVN,
                                                frm.Internal));
                DelivNoteId = _res;
                DelivNoteChanged?.Invoke(this);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (DelivNoteId != 0)
            {
                frm_AddDeliveryNote frm = new frm_AddDeliveryNote();

                frm.Id = DelivNoteId;

                Bll.DelivNoteHeadId = DelivNoteId;

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
                    Helper.getSP("sp_EditDelivNoteHead", DelivNoteId, frm.DocDate, frm.DelivDate, frm.Comments, frm.DelivPlaceId, frm.DelivAddressId,
                                                frm.FinalDelivPlaceId, frm.FinalDelivAddressId, frm.TransportId, frm.IncotermsId,
                                                frm.QtyPalettes, frm.PalettesWeight, frm.CreditAccount, frm.IsReturn, frm.NoReversePVN,
                                                frm.Internal);
                    DelivNoteChanged?.Invoke(this);
                }
            }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_DeliveryNotes popup = new frm_DeliveryNotes();
            popup.cmb_DeliveryNoteOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                    _e.Cancel = true;
            };

            //MessageBox.Show("OK");

            popup.FillData(DelivNote);
        }

        private void txt_DeliveryNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
}