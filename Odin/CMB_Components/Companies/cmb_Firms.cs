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
using Odin.Register;
using Odin.CMB_Components.BLL;
namespace Odin.CMB_Components.Companies
{
    public delegate void FirmsEventHandler(object sender);

    public partial class cmb_Firms : UserControl
    {
        public event FirmsEventHandler FirmsChanged;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        PopupWindowHelper PopupHelper = null;

        Reg_BLL RegBll = new Reg_BLL();
        CMB_BLL CmbBll = new CMB_BLL();

        FirmsEventArgs args = new FirmsEventArgs();
        int _FirmId = 0;
        int _PrevId = 0;

        bool _EnableSearchId = false;
        string _Firm = "";

        public int CurId
        { get; set; }
        public int SupIncotermsId
        { get; set; }
        public int CustIncotermsId
        { get; set; }
        public int CustPaymentId
        { get; set; }
        public int CountryId
        { get; set; }
        public double CountryVAT
        { get; set; }
        public string VATNr
        { get; set; }
        public string SupComments
        { get; set; }
        public cmb_Firms()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }
        public string Firm
        {
            get { return txt_Firm.Text; }
            set
            {
                _Firm = value;
                //if (String.IsNullOrEmpty(_Firm) != true)
                //{
                    txt_Firm.Text = value;
                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter(
                            "SELECT DISTINCT TOP 1 id FROM BAS_Companies WHERE company = N'" + _Firm.ToString() + "'", sConnStr);

                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    try
                    {
                        FirmId = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                    }
                    catch
                    {

                        _FirmId = 0;
                        return;
                    }
                //

                if (FirmsChanged != null)
                {
                    FirmsChanged(this);
                }
            }
        }

        public int FirmId
        {
            get
            {
                try { return _FirmId; }
                catch { return 0; }
            }
            set
            {
                _FirmId = value;

                if (_PrevId != _FirmId)
                {
                    SqlConnection conn = new SqlConnection(sConnStr);
                    conn.Open();

                    DataSet ds = new DataSet();

                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT top 1 * FROM BAS_Companies WHERE id = " + _FirmId.ToString(), conn);
                    adapter.Fill(ds);

                    conn.Close();

                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txt_Firm.Text = dr["company"].ToString();
                        }
                    }
                    else
                    {
                        txt_Firm.Text = string.Empty;
                    }

                    RegBll.FirmId = _FirmId;
                    CustIncotermsId = RegBll.CustIncoterms;
                    SupIncotermsId = RegBll.SupIncoterms;
                    CustPaymentId = RegBll.CustPayment;
                    CountryId = RegBll.CountryId;
                    CmbBll.CountryId = CountryId;
                    CurId = CmbBll.CountryCurId;
                    CountryVAT = CmbBll.CountryVAT;
                    SupComments = RegBll.SupComments;
                    VATNr = RegBll.VAT;
                    _PrevId = _FirmId;

                    if (FirmsChanged != null)
                    {
                        FirmsChanged(this);
                    }

                }
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

        bool _isemptycolor = false;

        public bool IsEmptyColor
        {
            get { return _isemptycolor; }
            set {
                _isemptycolor = value;
                if (value == true)
                    txt_Firm.StateCommon.Back.Color1 = Color.LightPink;
                else
                    txt_Firm.StateCommon.Back.Color1 = Color.White;
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Firm.Text = string.Empty;
            if (FirmsChanged != null)
                FirmsChanged(this);
        }

        private void txt_Firm_TextChanged(object sender, EventArgs e)
        {
            try { Firm = txt_Firm.Text; }
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

            frm_Firms popup = new frm_Firms();
            popup.cmb_FirmOne = this;

            PopupHelper.ClosePopup();

            PopupHelper.ShowPopup(f, popup, _location);

            PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
            {
                if (popup.ShowingModal)
                {
                    _e.Cancel = true;
                }
            };

            popup.FillData(Firm);
        }

        private void txt_Firm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
    public class FirmsEventArgs : EventArgs
    {

    }

}
