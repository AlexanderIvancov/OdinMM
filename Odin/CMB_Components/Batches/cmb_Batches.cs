using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Batches
{
    public delegate void BatchHeadEventHandler(object sender);
    public delegate void BatchControlEventHeader(object sender);
    public delegate void ErrorEventHandler();
    public delegate void BatchHeadKeyPressedEventHandler(object sender);

    public partial class cmb_Batches : UserControl
    {
        public event BatchHeadEventHandler BatchChanged;
        public event ErrorEventHandler ErrorChanged;
        public event BatchControlEventHeader ControlClick;
        public event BatchHeadKeyPressedEventHandler BatchKeyPressed;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        BatchHeadEventArgs args = new BatchHeadEventArgs();

        public cmb_Batches()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        #region Variables

        int _BatchId = 0;
        string _Batch = "";

        int PrevId = 0;
        int _ActiveOnly = 0;

        int _IsProject = 0;
        int _IsQuote = 0;
        int _IsGroup = 0;
       
        public string Batch
        {
            get { return txt_Batch.Text; }
            set { _Batch = value;
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
        
        public int ConfOrderId
        { get; set; }

        public int ActiveOnly
        {
            get { return _ActiveOnly; }
            set { _ActiveOnly = value; }
        }

        public int IsProject
        {
            get { return _IsProject; }
            set { _IsProject = value; }
        }
        public int IsQuote
        {
            get { return _IsQuote; }
            set { _IsQuote = value; }
        }       
        public string Stages
        { get; set; }
        public string CustArticle
        { get; set; }
        public string Comments
        { get; set; }
        public int IsGroup
        {
            get { return _IsGroup; }
            set { _IsGroup = value; }
        }
        public int BatchId
        {
            get { return _BatchId; }
            set {
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
                                                        " isnull(a.secname, '') as secname, isnull(ch.name, '') as conforder, isnull(cd.id, 0) as conforderid, " +
                                                        " isnull(c.company, '') as customer, isnull(bh.isactive, 0) as isactive, isnull(cd.custarticle, '') as custarticle, " +
                                                        " dbo.fn_BatchLabels(bh.id) as qtylabels, " +
                                                         " dbo.fn_StencilRequired(bh.artid) as stencilrequired, " +
                                                        " isnull(dbo.fn_ConcBatchStages(bh.id), '') as stages, " +
                                                        " isnull(bh.comments, '') as comments," +
                                                        " iif(isnull(cb.coid, 0) = 0 and isnull(cb.quotid, 0) != 0, -1, 0) as isquote  " +
                                                        " FROM PROD_BatchHead bh " + 
                                                        " INNER JOIN BAS_Articles a on a.id = bh.artid " +
                                                        " LEFT JOIN PROD_COBatch cb on cb.batchid = bh.id " +
                                                        " LEFT JOIN SAL_ClientOrdersDets cd on cd.id = cb.coid " +
                                                        " LEFT JOIN SAL_ClientOrdersHead ch on ch.id = cd.headid " +
                                                         " LEFT JOIN BAS_Companies c on c.id = ch.clientid " +
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
                        ConfOrderId = Convert.ToInt32(dr["conforderid"]);
                        Stages = dr["stages"].ToString();
                        CustArticle = dr["custarticle"].ToString();
                        Comments = dr["comments"].ToString();
                        IsQuote = Convert.ToInt32(dr["isquote"]);
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
            ConfOrderId = 0;
            Stages = "";
            CustArticle = "";
            Comments = "";
            IsQuote = 0;
        }

        //private void SelectBatchId(string strBeg)
        //{
        //    SqlConnection conn = new SqlConnection(sConnStr);
        //    conn.Open();

        //    DataSet ds = new DataSet();

        //    SqlDataAdapter adapter =
        //        new SqlDataAdapter("SELECT top 1 id, batch FROM PROD_BatchHead WHERE batch = '" + strBeg + "'", conn);
        //    adapter.Fill(ds);

        //    conn.Close();

        //    DataTable dt = ds.Tables[0];

        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            BatchId = Convert.ToInt32(dr["id"]);
        //        }
        //    }
        //    else
        //    {
        //        _BatchId = 0;
        //        ClearFields();
        //    }
        //    //return _BatchId;
            
        //}


        private void ShowBatchFilter(string Beg)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Batches popup = new frm_Batches();
            popup.cmb_BatchOne = this;

            PopupHelper.ClosePopup();
            popup.FillHeading(IsProject);

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Beg, ActiveOnly, IsProject, IsGroup);
        }


        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Batch.Text = string.Empty;
            //Batch = txt_Batch.Text;

            //if (BatchChanged != null)
            //{
            //    BatchChanged(this);
            //}
            if (ControlClick != null)
            {
                ControlClick(this);
            }

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
            if (ControlClick != null)
            {
                ControlClick(this);
            }

            ShowBatchFilter(txt_Batch.Text);
        }

        private void txt_Batch_Click(object sender, EventArgs e)
        {
            if (ControlClick != null)
                ControlClick(this);
        }

        private void txt_Batch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void txt_Batch_Enter(object sender, EventArgs e)
        {
            if (ControlClick != null)
                ControlClick(this);
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
    public class BatchHeadEventArgs : EventArgs
    {

    }
}
