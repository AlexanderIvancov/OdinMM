using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Batches
{
    public delegate void BatchHeadPDAEventHandler(object sender);
    public delegate void BatchHeadPDAKeyPressedEventHandler(object sender);
   
    public partial class cmb_BatchPDA : UserControl
    {
        public event BatchHeadPDAEventHandler BatchChanged;
       
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        public event BatchHeadPDAKeyPressedEventHandler BatchKeyPressed;
       

        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        BatchHeadEventArgs args = new BatchHeadEventArgs();

        int _enabled = -1;

        public int TextBoxEnabled
        {
            get { return _enabled; }
            set { _enabled = value;
                txt_Batch.Enabled = _enabled == -1;
            }
        }

        int _clearbutton = -1;

        public int ClearButtonVisible
        {
            get { return _clearbutton; }
            set
            {
                _clearbutton = value;
                buttonSpecAny1.Visible = _clearbutton == -1;
            }
        }

        public cmb_BatchPDA()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }
        #region Variables

        int _BatchId = 0;
        string _Batch = "";

        int PrevId = 0;

        public string Batch
        {
            get { return txt_Batch.Text; }
            set
            {
                _Batch = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 id, batch FROM PROD_BatchHead WHERE batch = '" + _Batch + "'", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        BatchId = Convert.ToInt32(dr["id"]);
                    }
                }
                else
                {
                    _BatchId = 0;

                    ClearFields();


                    if (PrevId != BatchId)
                    {
                        if (BatchChanged != null)
                            BatchChanged(this);
                        PrevId = BatchId;
                    }
                    //if (BatchChanged != null)
                    //{
                    //    BatchChanged(this);
                    //}
                }
            }
        }

        public int ArticleId
        { get; set; }

        public double Qty
        { get; set; }
        public string ResDate
        { get; set; }
        public string Article
        { get; set; }
        public string SecName
        { get; set; }

        public int ParentBatchId
        { get; set; }

        public string ConfOrder
        { get; set; }

        public string Customer
        { get; set; }

        public int IsActive
        { get; set; }

        public int StencilRequired
        { get; set; }

        public int QtyLabels
        { get; set; }

        public string Unit
        { get; set; }

        public int COId
        { get; set; }
        
        public int CountID
        { get; set; }

        public int BatchId
        {
            get { return _BatchId; }
            set
            {
                _BatchId = value;

                //if (PrevId != BatchId)

                //{

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("set dateformat dmy SELECT top 1 bh.id, bh.batch, bh.artid, bh.qty, " +
                                                        " convert(nvarchar(10), bh.resdate, 103) as resdate, " +
                                                        " isnull(bh.parentbatchid, 0) as parentbatchid, a.article, " +
                                                        " isnull(a.secname, '') as secname, isnull(ch.name, '') as conforder, " +
                                                        " isnull(c.company, '') as customer, isnull(bh.isactive, 0) as isactive, " +
                                                        " dbo.fn_BatchLabels(bh.id) as qtylabels, " +
                                                        " dbo.fn_StencilRequired(bh.artid) as stencilrequired, " +
                                                        " isnull(u.unit, '') as unit, " +
                                                        " isnull(cb.coid, 0) as coid, " +
                                                        " isnull(ap.countid, 0) as countid " +
                                                        " FROM PROD_BatchHead bh " +
                                                        " INNER JOIN BAS_Articles a on a.id = bh.artid " +
                                                        " INNER JOIN BAS_Unit u on a.unitid = u.id " +
                                                        " LEFT JOIN PROD_COBatch cb on cb.batchid = bh.id " +
                                                        " LEFT JOIN SAL_ClientOrdersDets cd on cd.id = cb.coid " +
                                                        " LEFT JOIN SAL_ClientOrdersHead ch on ch.id = cd.headid " +
                                                        " LEFT JOIN BAS_Companies c on c.id = ch.clientid " +
                                                        " outer apply (select count(id) as countid from PROD_COBatch where Batchid= bh.id) ap " + 
                                                        " WHERE bh.id = " + _BatchId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_Batch.Text = dr["batch"].ToString();
                        ArticleId = Convert.ToInt32(dr["artid"]);
                        Qty = Convert.ToDouble(dr["qty"]);
                        ResDate = dr["resdate"].ToString();
                        Article = dr["article"].ToString();
                        SecName = dr["secname"].ToString();
                        ConfOrder = dr["conforder"].ToString();
                        Customer = dr["customer"].ToString();
                        IsActive = Convert.ToInt32(dr["isactive"]);

                        ParentBatchId = Convert.ToInt32(dr["parentbatchid"]);
                        QtyLabels = Convert.ToInt32(dr["qtylabels"]);
                        StencilRequired = Convert.ToInt32(dr["stencilrequired"]);
                        Unit = dr["unit"].ToString();
                        COId = Convert.ToInt32(dr["coid"]);
                        CountID = Convert.ToInt32(dr["countid"]);
                    }


                    if (PrevId != BatchId)
                    {
                        if (BatchChanged != null)
                            BatchChanged(this);
                        PrevId = BatchId;
                    }
                    //if (BatchChanged != null)
                    //{
                    //    BatchChanged(this);
                    //}
                }
                else
                {
                    txt_Batch.Text = "";
                    ClearFields();
                }
            }
        }



        #endregion

        public void ClearFields()
        {
            ArticleId = 0;
            Qty = 0;
            ResDate = string.Empty;
            ParentBatchId = 0;
            ConfOrder = "";
            Customer = "";
            IsActive = 0;
            StencilRequired = 0;
            QtyLabels = 0;
            Unit = "";
            COId = 0;
            CountID = 0;
        }
        private void ShowBatchFilter(string Beg)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_BatchesPDA popup = new frm_BatchesPDA();
            popup.cmb_BatchOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Beg);
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Batch.Text = string.Empty;
        }

        private void txt_Batch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Batch = txt_Batch.Text;
            }
            catch
            {
                //return;
            }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            ShowBatchFilter(txt_Batch.Text);
        }

        private void txt_Batch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void txt_Batch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (BatchKeyPressed != null)
                {
                    BatchKeyPressed(this);
                }
            }
        }

    }
}
