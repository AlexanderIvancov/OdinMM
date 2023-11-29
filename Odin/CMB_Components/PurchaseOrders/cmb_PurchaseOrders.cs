using Odin.Global_Classes;
using Odin.Purchase;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.PurchaseOrders
{
    public delegate void PurchaseOrdersEventHandler(object sender);
    public delegate void PurchaseOrdersSavedEventHandler(object sender);

    public partial class cmb_PurchaseOrders : UserControl
    {
        public cmb_PurchaseOrders()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event PurchaseOrdersEventHandler PurchaseOrderChanged;
        public event PurchaseOrdersSavedEventHandler PurchaseOrderSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;
        DAL_Functions Dll = new DAL_Functions();

        int _PurchaseOrderId = 0;
        int _PrevId = 0;

        PO_BLL POBll = new PO_BLL();

        bool _EnableSearchId = false;
        string _PurchaseOrder = "";
        int _supplierid = 0;
        int _internal = 0;
        int _contactpersonid = 0;
        string _contract = "";

        public int SupplierId
        {
            get { return _supplierid; }
            set { _supplierid = value; }
        }

        public string Supplier
        { get; set; }

        public int ContactPersonId
        {
            get { return _contactpersonid; }
            set { _contactpersonid = value; }

        }

        public string Contract
        {
            get { return _contract; }
            set { _contract = value; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_PurchaseOrder.Text = string.Empty;
        }

        public string PurchaseOrder
        {
            get { return txt_PurchaseOrder.Text; }
            set
            {

                _PurchaseOrder = value;
                txt_PurchaseOrder.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM PUR_Header WHERE name = '" + _PurchaseOrder.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    PurchaseOrderId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _PurchaseOrderId = 0;
                    return;
                }

                if (PurchaseOrderChanged != null)
                {
                    PurchaseOrderChanged(this);
                }
            }
        }

        public int PurchaseOrderId
        {
            get
            {
                try { return _PurchaseOrderId; }
                catch { return 0; }
            }
            set
            {


                _PurchaseOrderId = value;

                if (_PrevId != _PurchaseOrderId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 h.name, h.supid, isnull(h.contpersid, 0) as contpersid, isnull(h.contract, '') as contract, isnull(c.company, '') as supplier FROM PUR_Header h left join bas_companies c on c.id = h.supid WHERE h.id = " + _PurchaseOrderId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_PurchaseOrder.Text = dr["name"].ToString();
                            SupplierId = Convert.ToInt32(dr["supid"]);
                            Supplier = dr["supplier"].ToString();
                            //Internal = Convert.ToInt32(dr["internal"]);
                            ContactPersonId = Convert.ToInt32(dr["contpersid"]);
                            Contract = dr["contract"].ToString();
                        }
                    }
                    else
                    {
                        txt_PurchaseOrder.Text = string.Empty;

                        SupplierId = 0;
                        Supplier = "";
                        ContactPersonId = 0;
                        Contract = "";
                    }

                    _PrevId = _PurchaseOrderId;

                    if (PurchaseOrderChanged != null)
                    {
                        PurchaseOrderChanged(this);
                    }

                }
            }
        }

        int _PurchaseOrderSavedId = 0;

        public int PurchaseOrderSavedId
        {
            get { return _PurchaseOrderSavedId; }
            set
            {
                _PurchaseOrderSavedId = value;
                if (PurchaseOrderSaved != null)
                {
                    PurchaseOrderSaved(this);
                }
            }
        }

        public void PurchaseOrdersSendSave()
        {
            if (PurchaseOrderSaved != null)
            {
                PurchaseOrderSaved(this);
            }
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

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_PurchaseOrders popup = new frm_PurchaseOrders();
            popup.cmb_PurchaseOrderOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(PurchaseOrder);
        }

        private void txt_PurchaseOrder_TextChanged(object sender, EventArgs e)
        {
            try { PurchaseOrder = txt_PurchaseOrder.Text; }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {

            frm_AddPurchaseOrder frm = new frm_AddPurchaseOrder();

            frm.FillAutoDoc(2);
            frm.CheckEmpty();
            frm.DelivPlaceId = Dll.CurrentCompanyId();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = POBll.AddPurchaseOrderHead(frm.SupId, frm.ContPersId, frm.Comments, frm.Contract, frm.CurId,
                                                        frm.IncotermsId, frm.DelivPlaceId, frm.DelivAddressId, frm.InProcess);

                PurchaseOrderId = _res;

                if (PurchaseOrderSaved != null)
                {
                    PurchaseOrderSaved(this);
                }

            }
            if (result == DialogResult.Cancel)
            {

            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {


            int _id = 0;

            try { _id = PurchaseOrderId; }
            catch { }

            if (_id != 0)
            {
                frm_AddPurchaseOrder frm = new frm_AddPurchaseOrder();

                POBll.POHeadId = _id;
                frm.PurchaseOrder = POBll.POHeader;
                frm.SupId = POBll.POHeadSupId;
                frm.ContPersId = POBll.POHeadContPersId;
                frm.Comments = POBll.POHeadComments;
                frm.Contract = POBll.POHeadContract;
                frm.IncotermsId = POBll.POHeadIncoterms;
                frm.CurId = POBll.POHeadCurId;
                frm.DelivPlaceId = POBll.POHeadDelivPlaceId;
                frm.DelivAddressId = POBll.POHeadDelivAddressId;
                frm.InProcess = POBll.POHeadProcessing;

                frm.CheckEmpty();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {

                    POBll.EditPurchaseOrderHead(_id, frm.SupId, frm.ContPersId, frm.Comments, frm.Contract,
                                                frm.CurId, frm.IncotermsId, frm.DelivPlaceId, frm.DelivAddressId,
                                                frm.InProcess);

                    POBll.POHeadId = _id;
                    _PrevId = 0;
                    PurchaseOrderId = _id;
                    if (PurchaseOrderSaved != null)
                    {
                        PurchaseOrderSaved(this);
                    }

                }

            }
        }

        private void txt_PurchaseOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
}
