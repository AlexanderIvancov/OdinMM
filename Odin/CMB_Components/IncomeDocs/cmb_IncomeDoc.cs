using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.IncomeDocs
{
    public delegate void IncomeDocEventHandler(object sender);
    public delegate void IncomeDocSavedEventHandler(object sender);

    public partial class cmb_IncomeDoc : UserControl
    {
        public cmb_IncomeDoc()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event IncomeDocEventHandler IncomeDocChanged;
        public event IncomeDocSavedEventHandler IncomeDocSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;
        int _IncomeDocId = 0;
        int _PrevId = 0;
        public bool _isedit = false;
        //StockIn_BLL SIBll = new StockIn_BLL();
        CMB_BLL Bll = new CMB_BLL();
        bool _EnableSearchId = false;
        string _IncomeDoc = "";
        int _supplierid = 0;
        int _curid = 0;
        public int SupplierId
        {
            get { return _supplierid; }
            set { _supplierid = value; }
        }
        public int CurId
        {
            get { return _curid; }
            set { _curid = value;}
        }
        public string IncomeDoc
        {
            get { return txt_IncomeDoc.Text; }
            set
            {
                _IncomeDoc = value;
                txt_IncomeDoc.Text = value;

                try
                {
                    IncomeDocId = Convert.ToInt32(Helper.QueryDT("SELECT DISTINCT TOP 1 id FROM STO_StockInHead WHERE name = '" + _IncomeDoc.ToString() + "'").Rows[0]["id"].ToString());
                }
                catch
                {
                    _IncomeDocId = 0;
                    return;
                }

                IncomeDocChanged?.Invoke(this);
            }
        }
        public int IncomeDocId
        {
            get
            {
                try { return _IncomeDocId; }
                catch { return 0; }
            }
            set
            {
                _IncomeDocId = value;

                if (_PrevId != _IncomeDocId)
                {
                    DataTable dt = Helper.QueryDT("SELECT top 1 * FROM STO_StockInHead WHERE id = " + _IncomeDocId.ToString());

                    if (dt.Rows.Count > 0)
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_IncomeDoc.Text = dr["name"].ToString();
                            SupplierId = Convert.ToInt32(dr["supid"]);
                            CurId = Convert.ToInt32(dr["curid"]);
                        }
                    else
                    {
                        txt_IncomeDoc.Text = string.Empty;
                        SupplierId = 0;
                        CurId = 0;
                    }

                    _PrevId = _IncomeDocId;

                    IncomeDocChanged?.Invoke(this);
                }
            }
        }
        int _IncomeDocSavedId = 0;
        public int IncomeDocSavedId
        {
            get { return _IncomeDocSavedId; }
            set
            {
                _IncomeDocSavedId = value;
                IncomeDocSaved?.Invoke(this);
            }
        }
        public bool EnableSearchId
        {
            get { return _EnableSearchId; }
            set { _EnableSearchId = value; }
        }

        public void IncomeDocSendSave()
        {
            IncomeDocSaved?.Invoke(this);
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_IncomeDocs popup = new frm_IncomeDocs();
            popup.cmb_IncomeDocOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                    _e.Cancel = true;
            };

            popup.FillData(IncomeDoc);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_IncomeDoc.Text = string.Empty;
        }

        private void txt_IncomeDoc_TextChanged(object sender, EventArgs e)
        {
            try { IncomeDoc = txt_IncomeDoc.Text; }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddIncomeDoc frm = new frm_AddIncomeDoc();

            frm.FillDate();
            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = Convert.ToInt32(Helper.getSP("sp_AddIncomeDocHead", frm.IncomeDoc, frm.Serie, frm.RegDate, frm.DocDate, frm.SupId, frm.Comments, frm.CurId, frm.CurRate, frm.SenderCountryId,
                                                frm.ProducerCountryId, frm.Bargain, frm.TransportId, frm.IncotermsId, frm.AdditCost, frm.Advance, frm.AdvanceDate,
                                                frm.PayDate, frm.NoReversePVN, frm.MediatedCost, frm.Check));
                IncomeDocId = _res;
                IncomeDocChanged?.Invoke(this);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = IncomeDocId; }
            catch { }

            if (_id != 0)
            {
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

                    Helper.getSP("sp_EditIncomeDocHead", _id, frm.IncomeDoc, frm.Serie, frm.RegDate, frm.DocDate, frm.SupId, frm.Comments, frm.CurId, frm.CurRate, frm.SenderCountryId,
                                                    frm.ProducerCountryId, frm.Bargain, frm.TransportId, frm.IncotermsId, frm.AdditCost, frm.Advance, frm.AdvanceDate,
                                                    frm.PayDate, frm.NoReversePVN, frm.MediatedCost, frm.Check);
                    if (Bll.IncomeDocRegDate != frm.RegDate)
                        Bll.CheckSendResaleLetter(_id);

                    Bll.IncomeDocHeadId = _id;
                    _PrevId = 0;
                    IncomeDocId = _id;
                    _isedit = true;
                    IncomeDocChanged?.Invoke(this);
                    _isedit = false;
                }
            }
        }

        private void cmb_IncomeDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
}