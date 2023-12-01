using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Warehouse.Movements;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.MoveDocs
{
    public delegate void MoveDocEventHandler(object sender);
    public delegate void MoveDocSavedEventHandler(object sender);
    public delegate void MoveDocControlEventHeader(object sender);

    public partial class cmb_MoveDocs : UserControl
    {
        public cmb_MoveDocs()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event MoveDocEventHandler MoveDocChanged;
        public event MoveDocSavedEventHandler MoveDocSaved;
        public event MoveDocControlEventHeader ControlClick;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        int _MoveDocId = 0;
        int _PrevId = 0;

        StockMove_BLL SMBll = new StockMove_BLL();
        CMB_BLL Bll = new CMB_BLL();

        bool _EnableSearchId = false;
        string _MoveDoc = "";

        public string MoveDoc
        {
            get { return txt_MoveDoc.Text; }
            set
            {

                _MoveDoc = value;
                txt_MoveDoc.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM STO_StockOutHead WHERE name = '" + _MoveDoc.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    MoveDocId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                else
                {
                    

                    _MoveDocId = 0;
                    //return;
                }
                MoveDocChanged?.Invoke(this);


            }
        }

        public int MoveDocId
        {
            get
            {
                try { return _MoveDocId; }
                catch { return 0; }
            }
            set
            {


                _MoveDocId = value;
                //MessageBox.Show(_MoveDocId.ToString());

                if (_PrevId != _MoveDocId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM STO_StockOutHead WHERE id = " + _MoveDocId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_MoveDoc.Text = dr["name"].ToString();
                        }
                        MoveDocChanged?.Invoke(this);
                    }
                    else
                    {
                        txt_MoveDoc.Text = string.Empty;
                    }

                    _PrevId = _MoveDocId;

                    //if (MoveDocChanged != null)
                    //{
                    //    MoveDocChanged(this);
                    //}

                }
            }
        }

        int _MoveDocSavedId = 0;

        public int MoveDocSavedId
        {
            get { return _MoveDocSavedId; }
            set
            {
                _MoveDocSavedId = value;
                MoveDocSaved?.Invoke(this);
            }
        }

        public void MoveDocSendSave()
        {
            MoveDocSaved?.Invoke(this);
        }

        public bool EnableSearchId
        {
            get
            {
                return _EnableSearchId;
            }
            set
            {
                _EnableSearchId = value;
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddMoveDoc frm = new frm_AddMoveDoc();

            frm.FillAutoDoc(6);

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                
                int _res = Bll.AddMoveDocHead(frm.DocDate, frm.DelivDate, frm.Comments, frm.DestPlaceId, frm.DelivAddressId, frm.FinDestPlaceId, frm.FinDelivAddressId,
                                                frm.TransportId, frm.IncotermsId, frm.PalettesQty, frm.PalettesWeight, frm.BatchId, frm.StageId, frm.QtyToProduce);
                MoveDocId = _res;
                MoveDocChanged?.Invoke(this);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = MoveDocId; }
            catch { }

            if (_id != 0)
            {

                frm_AddMoveDoc frm = new frm_AddMoveDoc();

                Bll.MoveDocHeadId = _id;

                frm.Id = _id;
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
                frm.StageId = Bll.MoveStageId;
                frm.QtyToProduce = Bll.MoveQtyOnStage;
                
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {

                    Bll.EditMoveDocHead(_id, frm.DocDate, frm.DelivDate, frm.Comments, frm.DestPlaceId, frm.DelivAddressId, frm.FinDestPlaceId, frm.FinDelivAddressId,
                                       frm.TransportId, frm.IncotermsId, frm.PalettesQty, frm.PalettesWeight, frm.BatchId, frm.StageId, frm.QtyToProduce);

                    Bll.MoveDocHeadId = _id;
                    MoveDocId = _id;
                    MoveDocChanged?.Invoke(this);
                }
            }
        }
        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            ControlClick?.Invoke(this);

            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_MoveDocs popup = new frm_MoveDocs();
            popup.cmb_MoveDocOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(MoveDoc);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_MoveDoc.Text = string.Empty;
            try { MoveDoc = txt_MoveDoc.Text; }
            catch { }

            ControlClick?.Invoke(this);
        }

        private void txt_MoveDoc_TextChanged(object sender, EventArgs e)
        {
            //try {
                MoveDoc = txt_MoveDoc.Text; //}
            //catch { }
            //if (ControlClick != null)
            //    ControlClick(this);
        }

        private void txt_MoveDoc_Click(object sender, EventArgs e)
        {
            ControlClick?.Invoke(this);
        }

        private void txt_MoveDoc_Enter(object sender, EventArgs e)
        {
            ControlClick?.Invoke(this);
        }

        private void txt_MoveDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
}
