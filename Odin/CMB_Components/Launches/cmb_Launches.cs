using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Launches
{
    public delegate void LaunchHeadEventHandler(object sender);
    public delegate void LaunchHeadKeyPressedEventHandler(object sender);
    public delegate void LaunchControlEventHeader(object sender);

    public partial class cmb_Launches : UserControl
    {
        public cmb_Launches()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event LaunchHeadEventHandler LaunchChanged;
        public event LaunchHeadKeyPressedEventHandler LaunchKeyPressed;
        public event LaunchControlEventHeader ControlClick;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();

        #region Variables

        int _LaunchId = 0;
        string _Launch = "";

        int PrevId = 0;

        public string Launch
        {
            get { return txt_Launch.Text; }
            set
            {
                _Launch = value;
                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 id, name FROM PROD_LaunchHead WHERE name = '" + _Launch + "'", conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        LaunchId = Convert.ToInt32(dr["id"]);
                    }
                }
                else
                {
                    _LaunchId = 0;

                    ClearFields();


                    if (PrevId != LaunchId)
                    {
                        LaunchChanged?.Invoke(this);
                        PrevId = LaunchId;
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

        public int BatchId
        { get; set; }

        public string Batch

        { get; set; }

        public double Qty
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
              
        public int StageId
        { get; set; } 

        public string StartDate
        { get; set; }

        public string EndDate
        { get; set; }

        public int LaunchId
        {
            get { return _LaunchId; }
            set
            {
                _LaunchId = value;

                //if (PrevId != BatchId)

                //{

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("set dateformat dmy SELECT top 1 lh.id, lh.name, bh.id as batchid, bh.batch, bh.artid, lh.qty, " +
                                                        " convert(nvarchar(10), lh.startdate, 103) as startdate, " +
                                                        " convert(nvarchar(10), isnull(lh.enddate, lh.startdate), 103) as enddate, " +
                                                        " isnull(bh.parentbatchid, 0) as parentbatchid, a.article, " +
                                                        " isnull(a.secname, '') as secname, isnull(ch.name, '') as conforder, " +
                                                        " isnull(c.company, '') as customer, isnull(bh.isactive, 0) as isactive, " +
                                                        " isnull(st.id, 0) as stageid " +
                                                        " FROM PROD_LaunchHead lh " +
                                                        " INNER JOIN PROD_BatchHead bh on bh.id = lh.batchid" +
                                                        " INNER JOIN BAS_Articles a on a.id = bh.artid " +
                                                        " LEFT JOIN PROD_COBatch cb on cb.batchid = bh.id " +
                                                        " LEFT JOIN SAL_ClientOrdersDets cd on cd.id = cb.coid " +
                                                        " LEFT JOIN SAL_ClientOrdersHead ch on ch.id = cd.headid " +
                                                        " LEFT JOIN BAS_Companies c on c.id = ch.clientid " +
                                                        " LEFT JOIN BAS_Stages st on st.id = lh.stageid " +
                                                        " WHERE lh.id = " + _LaunchId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_Launch.Text = dr["name"].ToString();
                        Batch = dr["batch"].ToString();
                        BatchId = Convert.ToInt32(dr["batchid"]);
                        ArticleId = Convert.ToInt32(dr["artid"]);
                        Qty = Convert.ToDouble(dr["qty"]);
                        Article = dr["article"].ToString();
                        SecName = dr["secname"].ToString();
                        ConfOrder = dr["conforder"].ToString();
                        Customer = dr["customer"].ToString();
                        IsActive = Convert.ToInt32(dr["isactive"]);
                        StageId = Convert.ToInt32(dr["stageid"]);
                        StartDate = dr["startdate"].ToString();
                        EndDate = dr["enddate"].ToString();

                        ParentBatchId = Convert.ToInt32(dr["parentbatchid"]);
                        
                    }


                    if (PrevId != LaunchId)
                    {
                        LaunchChanged?.Invoke(this);
                        PrevId = LaunchId;
                    }
                    //if (BatchChanged != null)
                    //{
                    //    BatchChanged(this);
                    //}
                }
                else
                {
                    txt_Launch.Text = "";
                    ClearFields();
                }
            }
        }



        #endregion

        public void ClearFields()
        {
            ArticleId = 0;
            Qty = 0;
            Batch = "";
            BatchId = 0;
            ParentBatchId = 0;
            ConfOrder = "";
            Customer = "";
            IsActive = 0;
            StageId = 0;
            StartDate = "";
            EndDate = "";
            SecName = "";
            Article = "";
        }

        private void ShowLaunchFilter(string Beg)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Launches popup = new frm_Launches();
            popup.cmb_LaunchOne = this;

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

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            ControlClick?.Invoke(this);

            ShowLaunchFilter(txt_Launch.Text);
        }

        private void txt_Launch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Launch = txt_Launch.Text;
            }
            catch
            {
                //return;
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Launch.Text = string.Empty;

            ControlClick?.Invoke(this);

        }

        private void txt_Launch_Click(object sender, EventArgs e)
        {
            ControlClick?.Invoke(this);
        }

        private void txt_Launch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void txt_Launch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LaunchKeyPressed?.Invoke(this);
            }
        }
    }
}
