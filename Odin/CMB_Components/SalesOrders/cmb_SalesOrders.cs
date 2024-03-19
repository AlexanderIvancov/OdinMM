using Odin.Global_Classes;
using Odin.Sales;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.SalesOrders
{
    public delegate void SalesOrdersEventHandler(object sender);
    public delegate void SalesOrdersSavedEventHandler(object sender);

    public partial class cmb_SalesOrders : UserControl
    {
        public cmb_SalesOrders()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event SalesOrdersEventHandler SalesOrderChanged;
        public event SalesOrdersSavedEventHandler SalesOrderSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        CO_BLL COBll = new CO_BLL();

        int _SalesOrderId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _SalesOrder = "";
        int _clientid = 0;
        int _internal = 0;
        int _contactpersonid = 0;
        string _contract = "";

        public int ClientId
        {
            get { return _clientid; }
            set { _clientid = value; }
        }

        public int ContactPersonId
        {
            get { return _contactpersonid; }
            set{ _contactpersonid = value; }
        }

        public string Contract
        {
            get { return _contract; }
            set { _contract = value; }
        }

        public int Internal
        {
            get { return _internal; }
            set { _internal = value; }
        }
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_SalesOrder.Text = string.Empty;
        }

        public string SalesOrder
        {
            get { return txt_SalesOrder.Text; }
            set
            {

                _SalesOrder = value;
                txt_SalesOrder.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM SAL_ClientOrdersHead WHERE name = '" + _SalesOrder.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    SalesOrderId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {
                    _SalesOrderId = 0;
                    return;
                }

                SalesOrderChanged?.Invoke(this);
            }
        }

        public int SalesOrderId
        {
            get
            {
                try { return _SalesOrderId; }
                catch { return 0; }
            }
            set
            {
                _SalesOrderId = value;

                if (_PrevId != _SalesOrderId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM SAL_ClientOrdersHead WHERE id = " + _SalesOrderId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_SalesOrder.Text = dr["name"].ToString();
                            ClientId = Convert.ToInt32(dr["clientid"]);
                            //Internal = Convert.ToInt32(dr["internal"]);
                            ContactPersonId = Convert.ToInt32(dr["contpersonid"]);
                            Contract = dr["contract"].ToString();
                        }
                    else
                    {
                        txt_SalesOrder.Text = string.Empty;

                        ClientId = 0;
                        Internal = 0;
                        ContactPersonId = 0;
                        Contract = "";
                    }

                    _PrevId = _SalesOrderId;

                    SalesOrderChanged?.Invoke(this);

                }
            }
        }

        int _SalesOrderSavedId = 0;
        public int SalesOrderSavedId
        {
            get { return _SalesOrderSavedId; }
            set {
                _SalesOrderSavedId = value;
                SalesOrderSaved?.Invoke(this);
            }
        }

        public void SalesOrdersSendSave()
        {
            SalesOrderSaved?.Invoke(this);
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

            frm_SalesOrders popup = new frm_SalesOrders();
            popup.cmb_SalesOrderOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                    _e.Cancel = true;
            };

            popup.FillData(SalesOrder);
        }

        private void txt_SalesOrder_TextChanged(object sender, EventArgs e)
        {
            try { SalesOrder = txt_SalesOrder.Text; }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            
            frm_AddSalesOrder frm = new frm_AddSalesOrder();

            frm.FillAutoDoc(1);
            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                int _res = Convert.ToInt32(Helper.getSP("sp_AddSalesOrderHead", frm.CustId, frm.ContPersId, frm.Comments, frm.Contract, frm.CurId, frm.IncotermsId));
                SalesOrderId = _res;
                SalesOrderSaved?.Invoke(this);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = SalesOrderId; }
            catch { }

            if (_id != 0)
            {
                frm_AddSalesOrder frm = new frm_AddSalesOrder();

                COBll.COHeadId = _id;
                frm.SalesOrder = COBll.COHeader;
                frm.CustId = COBll.COHeadCustId;
                frm.ContPersId = COBll.COHeadContPersId;
                frm.Comments = COBll.COHeadComments;
                frm.Contract = COBll.COHeadContract;
                frm.IncotermsId = COBll.COHeadIncoterms;
                frm.CurId = COBll.COHeadCurId;

                frm.CheckEmpty();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    COBll.EditSalesOrderHead(_id, frm.CustId, frm.ContPersId, frm.Comments, frm.Contract, frm.CurId, frm.IncotermsId);
                    COBll.COHeadId = _id;
                    SalesOrderSaved?.Invoke(this);
                }
                
            }
        }
    }
}