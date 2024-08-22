using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Articles
{
    public delegate void ArticlesEventHandler(object sender);
    public delegate void ArticlesKeyPressedEventHandler(object sender);
    public delegate void ArticlesIdKeyPressedEventHandler(object sender);
    public delegate void ArticleClearEventHandler(object sender);
    public delegate void ArticleValidatedEventHandler(object sender);

    public delegate void ErrorEventHandler();
    public delegate void ArticlesDoubleClickEventHandler(object sender);
    public delegate void ArticleIdReceivingEventHandler(object sender);

    public partial class cmb_Articles : UserControl
    {
        public event ArticlesEventHandler ArticleChanged;
        public event ArticlesKeyPressedEventHandler ArticleKeyPressed;
        public event ArticlesIdKeyPressedEventHandler ArticleIdKeyPressed;
        public event ErrorEventHandler ErrorChanged;
        public event ArticlesDoubleClickEventHandler DoubleClickControl;
        public event ArticleClearEventHandler ArticleCleared;
        public event ArticleValidatedEventHandler ArticleValidated;
        public event ArticleIdReceivingEventHandler ArticleIdReceiving;

        #region Variables
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        CMB_BLL BLL = new CMB_BLL();
        PopupWindowHelper PopupHelper = null;

        class_Global glob_Class = new class_Global();
        DAL_Functions glob_Function = new DAL_Functions();

        ArticlesEventArgs args = new ArticlesEventArgs();
        int _PrevId = 0;
        int _ArticleId = 0;
        string _Article = "";
        int _isactive = -1;
        int _iscertified = -1;
        public string SecName
        { get; set; }
        public string Comments
        {
            get; set;
        }
        public string ArtType
        {
            get; set;
        }
        public int TypeId
        {
            get; set;
        }
        public string Unit
        {
            get; set;
        }
        public int UnitId
        {
            get; set;
        }
        public double Weight
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public int ProjectId
        { get; set; }
        public string Project
        { get; set; }
        public string CustCode
        { get; set; }
        public int CustCodeId
        { get; set; }
        public double QtyAvail
        {
            get; set;
        }
        public double QtyConsStock
        {
            get;
            set;
        }
        public string Department
        { get; set; }

        public int DeptId
        { get; set; }

        public string Stage
        {
            get; set;
        }

        public int StageID
        {
            get; set;
        }

        public int BOMState
        {
            get; set;
        }

        public int SMTType
        {
            get; set;
        }

        public double SpoilConst
        { get; set; }

        public string Manufacturer
        { get; set; }
        public int IsActive
        {
            get { return _isactive; }
            set
            {
                _isactive = value;

                if (IsActive == 0)
                {
                    txt_Article.StateCommon.Back.Color1 = Color.Silver;
                    txt_Id.StateCommon.Back.Color1 = Color.Silver;
                }
                else
                {
                    txt_Article.StateCommon.Back.Color1 = Color.White;
                    txt_Id.StateCommon.Back.Color1 = Color.White;
                }
            }
        }

        public int IsCertified
        {
            get { return _iscertified; }
            set
            {
                _iscertified = value;
            }
        }
        public int IsPF
        { get; set; }
        public int RMId
        { get; set; }

        #endregion

        public cmb_Articles()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }

        public int ArticleId
        {
            get
            {

                try { return _ArticleId; }
                catch { return 0; }
            }
            set
            {

                _ArticleId = value;
                txt_Id.Text = value.ToString();

                if (_PrevId != _ArticleId)

                {

                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Articles WHERE id = " + _ArticleId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (txt_Article.Text.Trim().ToUpper() != dr["article"].ToString().ToUpper())
                            {
                                txt_Article.Text = dr["article"].ToString();
                                //SetCursor();
                                _Article = dr["article"].ToString();
                            }
                        }
                    }
                    else
                    {
                        //txt_Article.Text = string.Empty;
                        _Article = string.Empty;
                    }

                    ArticleDets(_ArticleId);

                    ArticleChanged?.Invoke(this);
                    //if (ArticleIdReceiving != null)
                    //    ArticleIdReceiving(this);
                    _PrevId = _ArticleId;

                }
            }
        }

        public int ArticleIdRec
        {
            get
            {

                try { return _ArticleId; }
                catch { return 0; }
            }
            set
            {

                _ArticleId = value;
                txt_Id.Text = value.ToString();

                //if (_PrevId != _ArticleId)

                //{

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT top 1 * FROM BAS_Articles WHERE id = " + _ArticleId.ToString(), conn);
                adapter.Fill(ds);

                conn.Close();

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (txt_Article.Text.Trim().ToUpper() != dr["article"].ToString().ToUpper())
                        {
                            txt_Article.Text = dr["article"].ToString();
                            //SetCursor();
                            _Article = dr["article"].ToString();
                        }
                    }
                }
                else
                {
                    //txt_Article.Text = string.Empty;
                    _Article = string.Empty;
                }

                ArticleDets(_ArticleId);

                ArticleIdReceiving?.Invoke(this);
                _PrevId = _ArticleId;

                //}
            }
        }

        public string Article
        {
            get { return txt_Article.Text; }
            set
            {
                txt_Article.Text = value;
                _Article = value;

                SqlConnection conn = new SqlConnection(sConnStr);
                conn.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_Articles WHERE article = '" + _Article.ToString() + "' collate Cyrillic_General_CI_AI ", conn);


                conn.Close();

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    txt_Id.Text = dt.Rows[0]["id"].ToString();
                    ArticleId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                    //SetCursor();
                }
                catch
                {
                    txt_Id.Text = "0";
                    _ArticleId = 0;
                }

                ArticleDets(_ArticleId);

                if (_PrevId != _ArticleId)

                {
                    ArticleChanged?.Invoke(this);

                    _PrevId = _ArticleId;
                }
            }
        }

        public void ArticleDets(int ArtId)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            string strSQL = "set dateformat dmy SELECT DISTINCT a.secname, a.unitid, u.unit, a.description, isnull(a.comments, '') as comments, " +
                                " a.typeid, t.name as type, IsNull(a.weight, 0) as weight, IsNull(c.code, '') as custcode, " +
                                " Isnull(a.qtyavail,0) as avail, isnull(a.deptid, 0) as deptid, isnull(d.department, '') as department, " +
                                " isnull(a.custcodeid, 0) as custcodeid, isnull(s.name, '') as stage, isnull(nv.state, 0) as bomstate, " +
                                " isnull(a.stageid, 0) as stageid, isnull(a.smttype, 0) as smttype, isnull(a.isactive, -1) as isactive, " +
                                " isnull(a.iscertified, -1) as iscertified, isnull(a.spoilconst, 0) as spoilconst, isnull(apc.manufacturer, '') as manufacturer, " +
                                " iif(isnull(pf.id, 0) = 0, 0, -1) as ispf, " +
                                " isnull(a.rmid, 0) as rmid  " +
                                "FROM bas_articles a " +
                                "INNER JOIN bas_unit u ON u.id = a.unitid " +
                                "INNER JOIN bas_type t ON t.id = a.TypeId " +
                                "LEFT JOIN bas_CustCodes c ON a.custcodeid = c.id " +
                                "LEFT JOIN bas_departments d ON a.deptid = d.id " +
                                "LEFT JOIN bas_stages s ON a.stageid = s.id " +
                                "LEFT JOIN BAS_NomenclaturesValidation nv on a.id = nv.artid " +
                                "left join bas_defaults pf on pf.field = 'pftype' and pf.value = t.id " +
                                "outer apply (select top 1 manufacturer from bas_catalog cat where cat.artid = a.id and isnull(rtrim(cat.manufacturer), '') != '' order by createdat desc ) apc " +
                                "WHERE a.id = " + ArtId.ToString();

            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                    new SqlDataAdapter(strSQL, conn);

            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    SecName = dr["secname"].ToString();
                    Unit = dr["unit"].ToString();
                    UnitId = Convert.ToInt32(dr["unitid"]);
                    Description = dr["description"].ToString();
                    Comments = dr["comments"].ToString();
                    ArtType = dr["type"].ToString();
                    TypeId = Convert.ToInt32(dr["typeid"]);
                    Weight = Convert.ToDouble(dr["weight"]);
                    CustCode = dr["custcode"].ToString();
                    QtyAvail = Convert.ToDouble(dr["avail"]);
                    Department = dr["department"].ToString();
                    DeptId = Convert.ToInt32((dr["deptid"]).ToString());
                    CustCodeId = Convert.ToInt32(dr["custcodeid"]);
                    BOMState = Convert.ToInt32(dr["bomstate"]);
                    Stage = dr["Stage"].ToString();
                    StageID = Convert.ToInt32(dr["stageid"]);
                    SMTType = Convert.ToInt32(dr["smttype"]);
                    IsActive = Convert.ToInt32(dr["isactive"]);
                    IsCertified = Convert.ToInt32(dr["iscertified"]);
                    SpoilConst = Convert.ToDouble(dr["spoilconst"]);
                    Manufacturer = dr["manufacturer"].ToString();
                    IsPF = Convert.ToInt32(dr["ispf"]);
                    RMId = Convert.ToInt32(dr["rmid"]);
                }
            }
            else
            {
                ClearFields();
            }
        }

        public void ClearFields()
        {
            SecName = "";
            Unit = "";
            UnitId = 0;
            Description = "";
            Comments = "";
            ArtType = "";
            Weight = 0;
            TypeId = 0;
            ProjectId = 0;
            Project = "";
            CustCode = "";
            QtyAvail = 0;
            QtyConsStock = 0;
            Department = "";
            DeptId = 0;
            CustCodeId = 0;
            Stage = "";
            BOMState = 0;
            StageID = 0;
            SMTType = 0;
            SpoilConst = 0;
            IsActive = -1;
            Manufacturer = "";
            IsPF = 0;
            RMId = 0;
        }

        public void SetCursor()
        {
            txt_Article.SelectionStart = txt_Article.Text.Length;
        }

        public void ShowFilter(string Beg)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Articles popup = new frm_Articles();
            popup.cmb_ArticleOne = this;

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
            popup.gv_List.Focus();
        }
        #region Controls
        private void txt_Article_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            Article = txt_Article.Text;

            ErrorChanged?.Invoke();

            //}
            //catch
            //{
            //    return;
            //}
        }
        private void txt_Id_TextChanged(object sender, EventArgs e)

        {
            try
            {
                ArticleId = Convert.ToInt32(txt_Id.Text);

                ErrorChanged?.Invoke();

            }
            catch
            {
                return;
            }
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            //txt_Article.Text = string.Empty;

            ArticleCleared?.Invoke(this);

            Article = string.Empty;

        }


        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            ArticleCleared?.Invoke(this);

            txt_Id.Text = "0";
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(glob_Function.ImagePath(ArticleId));
            }
            catch { }
            //frm_FullImage frm = new frm_FullImage();
            //frm.HeaderText = "Image for: " + Article.ToString();

            //frm.ShowImage(glob_Function.ImagePath(ArticleId));

            //DialogResult result = frm.ShowDialog();
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            ShowFilter(txt_Article.Text);
        }

        private void txt_Article_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DoubleClickControl?.Invoke(this);
            }
            catch { }
        }

        public void ArticleSendSave()
        {
            ArticleChanged?.Invoke(this);
        }


        #endregion

        private void txt_Article_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
            //else
            //     base.OnKeyPressed(e);
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    if (ArticleKeyPressed != null)
            //    {
            //        ArticleKeyPressed(this);
            //    }
            //}
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    if (ArticleIdKeyPressed != null)
            //    {
            //        ArticleIdKeyPressed(this);
            //    }
            //}
        }

        private void txt_Article_Validated(object sender, EventArgs e)
        {
            ArticleValidated?.Invoke(this);
            //if (ArticleKeyPressed != null)
            //{
            //    ArticleKeyPressed(this);
            //}
        }

        private void txt_Id_Validated(object sender, EventArgs e)
        {
            ArticleValidated?.Invoke(this);
            //if (ArticleIdKeyPressed != null)
            //{
            //    ArticleIdKeyPressed(this);
            //}
        }

        private void txt_Article_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txt_Article.Clear();

                ArticleKeyPressed?.Invoke(this);
            }
            if (e.KeyCode == Keys.Down)
            {
                btn_AdvView.PerformClick();

            }
        }

        private void txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ArticleKeyPressed?.Invoke(this);
            }
        }
    }
    public class ArticlesEventArgs : EventArgs
    {

    }
}
