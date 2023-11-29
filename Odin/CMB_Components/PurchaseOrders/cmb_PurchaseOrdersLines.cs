using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.PurchaseOrders
{
    public delegate void PurchaseOrdersLinesEventHandler(object sender);

    public partial class cmb_PurchaseOrdersLines : UserControl
    {
        public cmb_PurchaseOrdersLines()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event PurchaseOrdersLinesEventHandler PurchaseOrderChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        string _PurchaseOrder = "";
        int _PurchaseOrderId = 0;
        int _PrevLineId = 0;
        int _PurchaseOrderLine = 0;
        int _PurchaseOrderLineId = 0;

        int _ArtId = 0;
        public int ArticleId
        {
            get { return _ArtId; }
            set { _ArtId = value; }
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
                        "SELECT DISTINCT TOP 1 id FROM PUR_Header WHERE name = '" + _PurchaseOrder + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PurchaseOrderId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                    }
                }
                else
                {
                    _PurchaseOrderId = 0;
                    _PurchaseOrderLineId = 0;
                    PurchaseOrderLine = 0;
                    //if (PurchaseOrderChanged != null)
                    //    PurchaseOrderChanged(this);
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


                //if (ArticleId == 0)
                //    FillLines(_PurchaseOrderId);
                //else
                //    FillLinesArticles(_PurchaseOrderId, ArticleId);
            }
        }

        public int PurchaseOrderLine
        {
            get
            {
                try { return Convert.ToInt32(txt_Line.Text); }
                catch { return 0; }
            }
            set
            {
                //_PurchaseOrderLine = value;
                txt_Line.Text = value.ToString();
            }
        }

        public int PurchaseOrderLineId
        {
            get
            {
                return _PurchaseOrderLineId;
            }
            set
            {
                _PurchaseOrderLineId = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 d.line, d.headid, h.name FROM PUR_Dets d inner join pur_header h on h.id = d.headid " +
                                                        " WHERE d.id = " + _PurchaseOrderLineId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        PurchaseOrderId = Convert.ToInt32(dr["headid"]);
                        PurchaseOrderLine = Convert.ToInt32(dr["line"].ToString());
                    }
                }
                else
                {
                    PurchaseOrderId = 0;
                    PurchaseOrderLine = 0;
                }

                if (_PrevLineId != PurchaseOrderLineId
                    || _PrevLineId == 0)
                {
                    if (PurchaseOrderChanged != null)
                    {
                        PurchaseOrderChanged(this);
                    }
                    _PrevLineId = PurchaseOrderLineId;
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

            frm_PurchaseOrders popup = new frm_PurchaseOrders();
            popup.cmb_PurchaseOrderLinesOne = this;
            popup.Type = 2;

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

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            PurchaseOrderId = 0;
            PurchaseOrderLineId = 0;
        }

        private void btn_AdvViewLine_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X + txt_PurchaseOrder.Width + btn_AdvView.Width;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_PurchaseOrdersLines popup = new frm_PurchaseOrdersLines();
            popup.cmb_PurchaseOrderLinesOne = this;

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
                popup.FillData(PurchaseOrderId);
            else
                popup.FillDataEnabledArticles(PurchaseOrderId, ArticleId);
        }

        private void txt_Line_TextChanged(object sender, EventArgs e)
        {
            //try {

            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 id FROM PUR_Dets WHERE headid = " + _PurchaseOrderId.ToString() + " and line = " + PurchaseOrderLine, conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    PurchaseOrderLineId = Convert.ToInt32(dr["id"]);
                }
            }
            else
            {
                _PrevLineId = 0;
                _PurchaseOrderLineId = 0;
                if (PurchaseOrderChanged != null)
                    PurchaseOrderChanged(this);

            }

            //}
            //catch { }
        }

        private void txt_PurchaseOrder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrder = txt_PurchaseOrder.Text;
            }
            catch { }
        }
    }
}
