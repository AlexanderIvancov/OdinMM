using Odin.Global_Classes;
using Odin.Sales;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.CMB_Components.Quotations
{
    public delegate void QuotationsEventHandler(object sender);
    public delegate void QuotationsSavedEventHandler(object sender);

    public partial class cmb_Quotations : UserControl
    {
        public cmb_Quotations()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public event QuotationsEventHandler QuotationChanged;
        public event QuotationsSavedEventHandler QuotationSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        CO_BLL COBll = new CO_BLL();

        class_Global globClass = new class_Global();

        int _QuotationId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Quotation = "";
        int _clientid = 0;

        frm_AddQuotation frm = null;

        public int ClientId
        {
            get { return _clientid; }
            set { _clientid = value; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Quotation.Text = string.Empty;
        }

        public string Quotation
        {
            get { return txt_Quotation.Text; }
            set
            {

                _Quotation = value;
                txt_Quotation.Text = value;
                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM SAL_Quotations WHERE name = '" + _Quotation.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    QuotationId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    _QuotationId = 0;
                    //return;
                }

                QuotationChanged?.Invoke(this);
            }
        }

        public int QuotationId
        {
            get
            {
                try { return _QuotationId; }
                catch { return 0; }
            }
            set
            {


                _QuotationId = value;

                if (_PrevId != _QuotationId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM SAL_Quotations WHERE id = " + _QuotationId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Quotation.Text = dr["name"].ToString();
                            ClientId = Convert.ToInt32(dr["custid"]);
                        }
                    }
                    else
                    {
                        txt_Quotation.Text = string.Empty;
                        ClientId = 0;
                    }

                    _PrevId = _QuotationId;

                    QuotationChanged?.Invoke(this);

                }
            }
        }

        int _QuotationSavedId = 0;
        public int QuotationSavedId
        {
            get { return _QuotationSavedId; }
            set
            {
                _QuotationSavedId = value;
                QuotationSaved?.Invoke(this);
            }
        }

        public void QuotationSendSave()
        {
            QuotationSaved?.Invoke(this);
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

        private void txt_Quotation_TextChanged(object sender, EventArgs e)
        {
            try { Quotation = txt_Quotation.Text; }
            catch { }
        }

        private void btn_AdvView_Click(object sender, EventArgs e)
        {
            Form f;
            f = this.FindForm();

            Point LocationPoint = this.PointToScreen(Point.Empty);
            int xpos = LocationPoint.X;
            int ypos = LocationPoint.Y + this.Height;
            Point _location = new Point(xpos, ypos);

            frm_Quotation popup = new frm_Quotation();
            popup.cmb_QuotationOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Quotation);
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (globClass.IsFormAlreadyOpen("frm_AddQuotation")) return;

            frm = new frm_AddQuotation();
            frm.ctl_QuotDets1.QuotId = 0;
            frm.ctl_QuotDets1.FillAutoDoc(10);
            frm.ctl_QuotDets1.StateId = 1;
            frm.ctl_QuotDets1.ReqDateD = System.DateTime.Now;
            //frm.ctl_QuotDets1.Week = "W" + frm.ctl_QuotDets1.cmb_Week1.WeekNumber(System.DateTime.Now).ToString() + "/" + System.DateTime.Now.Year.ToString();


            frm.QuotationSaved += new QuotationSavedEventHandler(AddQuotation);

            frm.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = QuotationId;
            

            if (_id != 0)
            {
                //if (globClass.IsFormAlreadyOpen("frm_AddQuotation")) return;

                COBll.QuotId = _id;
                frm = new frm_AddQuotation();
                frm.ctl_QuotDets1.QuotId = _id;

                frm.QuotationSaved += new QuotationSavedEventHandler(AddQuotation);

                frm.Show();

            }
        }

        public void AddQuotation(object sender)
        {
            if (frm.ctl_QuotDets1.QuotId != 0)
            {
                QuotationId = frm.ctl_QuotDets1.QuotId;
                frm.Close();
                //QuotationSaved(this);
            }
        }

    }
}
