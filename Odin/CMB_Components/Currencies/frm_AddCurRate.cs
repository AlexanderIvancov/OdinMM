using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.Currencies
{
    public partial class frm_AddCurRate : KryptonForm
    {
        public frm_AddCurRate()
        {
            InitializeComponent();
        }
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public int Id
        { get; set; }
        
        public string CurDate
        {
            get { return txt_Date.Value.ToShortDateString(); }
            set { txt_Date.Value = Convert.ToDateTime(value); }
        }

        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; } 
        }

        public double Rate
        {
            get { try { return Convert.ToDouble(txt_Rate.Text); }
                catch { return 0; }
            }
            set { txt_Rate.Text = value.ToString(); }
        }

        public double UnitCoef
        {
            get
            {
                try { return Convert.ToDouble(txt_UnitCoef.Text); }
                catch { return 0; }
            }
            set { txt_UnitCoef.Text = value.ToString(); }
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = cmb_Currency1.CurrencyId != 0
                && UnitCoef != 0
                && Rate != 0;
        }

        private void cmb_Currency1_CurrencyChanged(object sender)
        {
            CheckEmpty();
        }

        private void txt_Rate_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_UnitCoef_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
