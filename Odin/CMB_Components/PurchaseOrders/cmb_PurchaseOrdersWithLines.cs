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

namespace Odin.CMB_Components.PurchaseOrders
{
    public delegate void PurchaseOrdersWHEventHandler(object sender);
    public delegate void POrderClickEventHandler(object sender);

    public partial class cmb_PurchaseOrdersWithLines : UserControl
    {
        public cmb_PurchaseOrdersWithLines()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event PurchaseOrdersWHEventHandler PurchaseOrderChanged;
        public event POrderClickEventHandler ControlClick;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        string _PurchaseOrder = "";
        int _PurchaseOrderId = 0;
        int _PrevLineId = 0;
        string _PurchaseOrderLine = "";
        int _PurchaseOrderLineId = 0;
        int _ArtId = 0;
        bool _key = false;

        public int ArticleId
        {
            get { return _ArtId; }
            set { _ArtId = value; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            PurchaseOrderId = 0;
            PurchaseOrderLineId = 0;
        }

        public string PurchaseOrder
        {
            get { return txt_PurchaseOrder.Text; }
            set
            {

                //_PurchaseOrder = value;
                txt_PurchaseOrder.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM PUR_Header WHERE name = '" + _PurchaseOrder.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PurchaseOrderId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                    }
                }
                else { _PurchaseOrderId = 0; }
                    
                    //return;
                
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

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 * FROM PUR_Header WHERE id = " + _PurchaseOrderId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_PurchaseOrder.Text = dr["name"].ToString();
                    }
                }
                else
                {
                    txt_PurchaseOrder.Text = string.Empty;
                }


                if (ArticleId == 0)
                    FillLines(_PurchaseOrderId);
                else
                    FillLinesArticles(_PurchaseOrderId, ArticleId);

                //if (PurchaseOrderChanged != null)
                //{
                //    PurchaseOrderChanged(this);
                //}

            }
        }

        public string PurchaseOrderLine
        {
            get
            {
                try { return cmb_Lines.Text; }
                catch { return ""; }
            }
            set
            {

                _PurchaseOrderLine = value;
                cmb_Lines.Text = value;
            }
        }

        public int PurchaseOrderLineId
        {
            get
            {
                return _PurchaseOrderLineId;
                //try { return Convert.ToInt32(cmb_Lines.ValueMember); }
                //catch { return 0; }
            }
            set
            {
                _PurchaseOrderLineId = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();
                
                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 d.line, d.headid FROM PUR_Dets d " +
                                                        " WHERE d.id = " + _PurchaseOrderLineId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                //        FillLines(Convert.ToInt32(dr["headid"]));
                //        PurchaseOrderId = Convert.ToInt32(dr["headid"]);
                //        PurchaseOrderLine = dr["line"].ToString();
                    }
                }
                else
                {
                //    PurchaseOrderId = 0;
                //    PurchaseOrderLine = string.Empty;
                }

                //if (PurchaseOrderChanged != null)
                //{
                //    PurchaseOrderChanged(this);
                //}
            }
        }

        public void FillLines(int _POId)
        {
            PurchaseOrderLineId = 0;
            PurchaseOrderLine = "";

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT id, line FROM PUR_Dets WHERE headid = " + _POId + " and (stateid = 1/* or stateid = 2*/) ", sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            cmb_Lines.DataSource = dt;
            cmb_Lines.DisplayMember = "line";
            cmb_Lines.ValueMember = "id";

        }

        public void FillLinesArticles(int _POId, int _ArtId)
        {
            PurchaseOrderLineId = 0;
            PurchaseOrderLine = "";

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT id, line FROM PUR_Dets WHERE headid = " + _POId + 
                    " and artid = isnull(nullif(" + _ArtId + ", 0), artid) and (stateid = 1) " , sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            cmb_Lines.DataSource = dt;
            cmb_Lines.DisplayMember = "line";
            cmb_Lines.ValueMember = "id";

        }

        private void txt_PurchaseOrder_TextChanged(object sender, EventArgs e)
        {
            if (_key == true)
            {
                //try
                //{
                    PurchaseOrder = txt_PurchaseOrder.Text;
                //}
                //catch { }
            }
            //try {
            //    PurchaseOrder = txt_PurchaseOrder.Text;
            //}
            //catch { }
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
            popup.cmb_PurchaseOrderWithLineOne = this;
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

            if (ArticleId == 0)
                popup.FillData(PurchaseOrder);
            else
                popup.FillDataEnabledArticles(PurchaseOrder, ArticleId);
        }

        private int POLineSelectedValue()
        {
            //MessageBox.Show(cmb_Lines.SelectedText);
            int k = 0;

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 d.id FROM PUR_Dets d " +
                                    "inner join PUR_Header h on d.headid = h.id  " +
                                    " WHERE h.name = '" + txt_PurchaseOrder.Text + "'" +
                                    " AND convert(nvarchar(4), d.line) = convert(nvarchar(4), '" + cmb_Lines.Text.Trim() + "')", conn);
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

        private void cmb_Lines_SelectedValueChanged(object sender, EventArgs e)
        {
            _PurchaseOrderLineId = POLineSelectedValue();


            if (PurchaseOrderChanged != null)
            {
                PurchaseOrderChanged(this);
            }
        }

        private void cmb_Lines_Click(object sender, EventArgs e)
        {
            if (ControlClick != null)
            {
                ControlClick(this);
            }
        }

        private void txt_PurchaseOrder_Click(object sender, EventArgs e)
        {
            if (ControlClick != null)
            {
                ControlClick(this);
            }
        }

        private void btn_AdvView_KeyDown(object sender, KeyEventArgs e)
        {
            //if (ControlClick != null)
            //{
            //    ControlClick(this);
            //}
        }

        private void txt_PurchaseOrder_Validated(object sender, EventArgs e)
        {
            //try
            //{
            //    PurchaseOrder = txt_PurchaseOrder.Text;
            //}
            //catch { }
        }

        private void txt_PurchaseOrder_Enter(object sender, EventArgs e)
        {
            _key = true;
        }

        private void txt_PurchaseOrder_Leave(object sender, EventArgs e)
        {
            _key = false;
        }
    }
}
