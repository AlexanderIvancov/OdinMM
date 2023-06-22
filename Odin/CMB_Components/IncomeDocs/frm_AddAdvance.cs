using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;

namespace Odin.CMB_Components.IncomeDocs
{
    public partial class frm_AddAdvance : KryptonForm
    {
        public frm_AddAdvance()
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
            if (cmb_Currency1.CurrencyId == 0
                || UnitCoef == 0
                || Rate == 0
                || Amount == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
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

        public double Amount
        {
            get
            {
                try { return Convert.ToDouble(txt_Amount.Text); }
                catch { return 0; }
            }
            set { txt_Amount.Text = value.ToString(); }
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
