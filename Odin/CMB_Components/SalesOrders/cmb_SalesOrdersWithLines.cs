using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using System.Data.SqlClient;

namespace Odin.CMB_Components.SalesOrders
{
    public delegate void SalesOrdersWHEventHandler(object sender);
    public delegate void OrderClickEventHandler(object sender);

    public partial class cmb_SalesOrdersWithLines : UserControl
    {
        public cmb_SalesOrdersWithLines()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event SalesOrdersWHEventHandler SalesOrderChanged;
        public event OrderClickEventHandler ControlClick;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        string _SalesOrder = "";
        int _SalesOrderId = 0;
        int _PrevId = 0;
        int _PrevLineId = 0;
        string _SalesOrderLine = "";
        int _SalesOrderLineId = 0;
        bool _keypress = false;
        int _articleid = 0;
        
        public int BatchId
        { get; set; }
        public double QtyInCO
        {
            get;set;
        }

        public int ArticleId
        { get; set; }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_SalesOrder.Text = string.Empty;
            SalesOrderLineId = 0;
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

                    SalesOrderId = 0;
                    return;
                }

                FillLines(SalesOrderId);

                //if (SalesOrderChanged != null)
                //{
                //    SalesOrderChanged(this);
                //}
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
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_SalesOrder.Text = dr["name"].ToString();
                           
                        }
                    }
                    else
                    {
                        _SalesOrder = string.Empty;
                                              
                    }

                    _PrevId = _SalesOrderId;

                    FillLines(_SalesOrderId);

                    //if (SalesOrderChanged != null)
                    //{
                    //    SalesOrderChanged(this);
                    //}

                }
            }
        }

        public string SalesOrderLine
        {
            get {
                try { return cmb_Lines.Text; }
                catch { return ""; }
            }
            set {
                
                _SalesOrderLine = value;
                cmb_Lines.Text = value;
                         

                

                //SqlConnection conn = new SqlConnection(sConnStr);
                //conn.Open();

                //DataSet ds = new DataSet();

                //SqlDataAdapter adapter =
                //    new SqlDataAdapter("SELECT top 1 d.id FROM SAL_ClientOrdersDets d " +
                //                                        " WHERE d.orderline = " + _SalesOrderLine + 
                //                                        " AND d.headid = " + SalesOrderId, conn);
                //adapter.Fill(ds);

                //conn.Close();

                //DataTable dt = ds.Tables[0];

                //if (dt.Rows.Count > 0)
                //{
                //    foreach (DataRow dr in dt.Rows)
                //    {
                //        SalesOrderLineId = Convert.ToInt32(dr["id"]);
                //    }
                //}
                //else
                //{
                //    SalesOrderLineId = 0;
                //}
                
                //if (SalesOrderChanged != null)
                //{
                //    SalesOrderChanged(this);
                //}

            }
        }

        public int SalesOrderLineId
        {
            get {
                return _SalesOrderLineId;
                //try { return Convert.ToInt32(cmb_Lines.ValueMember); }
                //catch { return 0; }
            }
            set { _SalesOrderLineId = value;

                if (_PrevLineId != _SalesOrderLineId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 d.orderline, d.headid, isnull(cb.batchid, 0) as batchid, d.qty, d.artid FROM SAL_ClientOrdersDets d left join PROD_COBatch cb on cb.coid = d.id " + 
                                                            " WHERE d.id = " + _SalesOrderLineId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            SalesOrderId = Convert.ToInt32(dr["headid"]);
                            SalesOrderLine = dr["orderline"].ToString();
                            BatchId = Convert.ToInt32(dr["batchid"]);
                            QtyInCO = Convert.ToDouble(dr["qty"]);
                            ArticleId = Convert.ToInt32(dr["artid"]);
                        }
                    }
                    else
                    {
                        SalesOrderId = 0;
                        SalesOrderLine = string.Empty;
                        BatchId = 0;
                        QtyInCO = 0;
                        ArticleId = 0;

                    }

                    _PrevLineId = _SalesOrderLineId;

                    

                    if (SalesOrderChanged != null)
                    {
                        SalesOrderChanged(this);
                    }

                }

            }
        }

        public void FillLines(int _COId)
        {
            SalesOrderLineId = 0;
            SalesOrderLine = "";

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT id, orderline FROM SAL_ClientOrdersDets WHERE headid = " + _COId, sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            cmb_Lines.DataSource = dt;
            cmb_Lines.DisplayMember = "orderline";
            cmb_Lines.ValueMember = "id";

        }

        private void txt_SalesOrder_TextChanged(object sender, EventArgs e)
        {
            if (_keypress == true)
            {
                try { SalesOrder = txt_SalesOrder.Text; }
                catch { }
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
            popup.cmb_SalesOrderWithLineOne = this;
            popup.Type = 1;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(SalesOrder);
        }

        private int SOLineSelectedValue()
        {
            //MessageBox.Show(cmb_Lines.SelectedText);
            int k = 0;

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 d.id FROM SAL_ClientOrdersDets d " + 
                                    "inner join SAL_ClientOrdersHead h on d.headid = h.id  " + 
                                    " WHERE h.name = '" + txt_SalesOrder.Text + "'" + 
                                    " AND convert(nvarchar(4), d.orderline) = convert(nvarchar(4), '" + cmb_Lines.Text.Trim() + "')", conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    k = Convert.ToInt32(dr["id"]);

                }
            }
                        
           return k;
           
        }

        public void ShowCODets(int id)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 d.orderline, d.headid, isnull(cb.batchid, 0) as batchid, d.qty, d.artid FROM SAL_ClientOrdersDets d left join PROD_COBatch cb on cb.coid = d.id " +
                                                    " WHERE d.id = " + id, conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    BatchId = Convert.ToInt32(dr["batchid"]);
                    QtyInCO = Convert.ToDouble(dr["qty"]);
                    ArticleId = Convert.ToInt32(dr["artid"]);
                }
            }
            else
            {
                BatchId = 0;
                QtyInCO = 0;
                ArticleId = 0;
            }
        }

        private void cmb_Lines_SelectedValueChanged(object sender, EventArgs e)
        {

           _PrevLineId = _SalesOrderLineId;
            
           _SalesOrderLineId = SOLineSelectedValue();

            ShowCODets(_SalesOrderLineId);
            
             if (SalesOrderChanged != null)
            {
                SalesOrderChanged(this);
            }
        }

        private void cmb_Lines_Click(object sender, EventArgs e)
        {
            if (ControlClick != null)
            {
                ControlClick(this);
            }
        }

        private void txt_SalesOrder_Enter(object sender, EventArgs e)
        {
            _keypress = true;
        }

        private void txt_SalesOrder_Leave(object sender, EventArgs e)
        {
            _keypress = false;
        }
    }
}
