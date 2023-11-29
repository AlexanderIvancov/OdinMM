using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;
namespace Odin.Register.Catalog
{
    public delegate void CatSavedEventHandler(object sender);
    public delegate void CatClosedEventHandler(object sender);
    public partial class frm_AddCatItem : KryptonForm
    {
        public frm_AddCatItem()
        {
            InitializeComponent();
        }

        #region Variables

        public event CatSavedEventHandler CatSaved;
        public event CatClosedEventHandler CatClosed;

        DAL_Functions Dll = new DAL_Functions();

        int _catid = 0;

        public int CatID
        {
            get { return _catid; }
            set { _catid = value; }

        }

        public int BargType
        {
            get
            {
                return rb_Supplier.Checked == true ? -1 : rb_Customer.Checked == true ? 1 : 0;
            }
            set
            {
                if (value == -1)
                {
                    rb_Supplier.Checked = true;
                    rb_Customer.Checked = false;
                    rb_All.Checked = false;
                }
                else if (value == 1)
                {
                    rb_Customer.Checked = true;
                    rb_Supplier.Checked = false;
                    rb_All.Checked = false;
                }
                else
                {
                    rb_Customer.Checked = false;
                    rb_Supplier.Checked = false;
                    rb_All.Checked = true;
                }
            }
        }

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public int FirmId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value; }
        }
        public string FirmArt
        {
            get { return txt_FirmArt.Text; }
            set { txt_FirmArt.Text = value; }
        }

        public int UnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
        }

        public double CoefConv
        {
            get
            {
                try { return Convert.ToDouble(txt_CoefConv.Text); }
                catch { return 1; }
            }
            set { txt_CoefConv.Text = value.ToString(); }
        }

        public double UnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_UnitPrice.Text); }
                catch { return 0; }
            }
            set { txt_UnitPrice.Text = value.ToString(); }
        }

        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        public double MOQ
        {
            get
            {
                try { return Convert.ToDouble(txt_MOQ.Text); }
                catch { return 0; }
            }
            set { txt_MOQ.Text = value.ToString(); }
        }

        public double MPQ
        {
            get
            {
                try { return Convert.ToDouble(txt_MPQ.Text); }
                catch { return 0; }
            }
            set { txt_MPQ.Text = value.ToString(); }
        }

        public double Vat
        {
            get
            {
                try { return Convert.ToDouble(txt_Vat.Text); }
                catch { return 0; }
            }
            set { txt_Vat.Text = value.ToString(); }
        }

        public int DelivTerms
        {
            get
            {
                try { return Convert.ToInt32(txt_DelivTerms.Text); }
                catch { return 0; }
            }
            set { txt_DelivTerms.Text = value.ToString(); }
        }

        public int MinExpDays
        {
            get
            {
                try { return Convert.ToInt32(txt_MinExpDays.Text); }
                catch { return 0; }
            }
            set { txt_MinExpDays.Text = value.ToString(); }
        }

        public string Manufacturer
        {
            get { return txt_Manufacturer.Text; }
            set { txt_Manufacturer.Text = value; }
        }

        public int AsDefault
        {
            get
            {
                return chk_Default.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                if (value == -1)
                    chk_Default.Checked = true;

                else
                    chk_Default.CheckState = CheckState.Unchecked;
            }
        }

        public int Quoted
        {
            get
            {
                return chk_Quoted.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                if (value == -1)
                    chk_Quoted.Checked = true;

                else
                    chk_Quoted.CheckState = CheckState.Unchecked;
            }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string DataCode
        {
            get { return txt_DataCode.Text; }
            set { txt_DataCode.Text = value; }
        }

        public string DelivTermTxt
        {
            get { return txt_DelivTermsTxt.Text; }
            set { txt_DelivTermsTxt.Text = value; }
        }

        public string BarCode
        {
            get { return txt_BarCode.Text; }
            set { txt_BarCode.Text = value; }
        }
        public int ForCustomer
        {
            get { return cmb_Firms2.FirmId; }
            set { cmb_Firms2.FirmId = value; }
        }
        #endregion

        #region Controls

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_FirmArt.Text = string.Empty;
        }

        private void cmb_Units1_UnitChanged(object sender)
        {
            CoefConv = Dll.UnitRecalc(cmb_Articles1.UnitId, UnitId);
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            UnitId = cmb_Articles1.UnitId;
            CoefConv = Dll.UnitRecalc(cmb_Articles1.UnitId, UnitId);
            Manufacturer = cmb_Articles1.Manufacturer;
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            CurId = cmb_Firms1.CurId;
            Vat = cmb_Firms1.CountryVAT;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Manufacturer.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }


        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (CatSaved != null)
                CatSaved(this);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (CatClosed != null)
                CatClosed(this);
            this.Close();
        }

        private void frm_AddCatItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CatClosed != null)
                CatClosed(this);
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_DataCode.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_DelivTermsTxt.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_BarCode.Text = string.Empty;
        }
    }
}
