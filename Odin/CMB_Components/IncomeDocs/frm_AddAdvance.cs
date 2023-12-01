using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Drawing;

namespace Odin.CMB_Components.IncomeDocs
{
    public partial class frm_AddAdvance : KryptonForm
    {
        public frm_AddAdvance()
        {
            InitializeComponent();
        }

        DAL_Functions DLL = new DAL_Functions();
        class_Global glob_Class = new class_Global();

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
                && Rate != 0
                && Amount != 0;
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

        private void cmb_Currency1_CurrencyChanged_1(object sender)
        {
            txt_Rate.ThreadSafeCall(delegate
            {
                DLL.ShowCurRate(CurId, CurDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : CurDate.Trim());
                Rate = DLL.CurRate;
                txt_Rate.StateCommon.Back.Color1 = Rate == 0 ? Color.Red : Color.White;
            });

            CheckEmpty();
        }
    }
}
