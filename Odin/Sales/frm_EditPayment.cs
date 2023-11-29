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
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.Deliveries;
using System.Data.SqlClient;
using Odin.Sales;

namespace Odin.Sales
{
    public partial class frm_EditPayment : KryptonForm
    {
        public frm_EditPayment()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        Helper MyHelper = new Helper();
        CO_BLL COBll = new CO_BLL();

        public event SavePaymentEventHandler SavePayment;

        int _id = 0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
               

        public string Payment
        {
            get { return txt_Payment.Text; }
            set { txt_Payment.Text = value; }
        }
        
        public double Summa
        {
            get { return Convert.ToDouble(txt_Summa.Text); }
            set { txt_Summa.Text = value.ToString(); }
        }
        public double SummaWVat
        {
            get { return Convert.ToDouble(txt_SummaWVat.Text); }
            set { txt_SummaWVat.Text = value.ToString(); }
        }

        public double Vat
        {
            get { return Convert.ToDouble(txt_Vat.Text); }
            set { txt_Vat.Text = value.ToString(); }
        }

        public double VatPerc
        {
            get { return Convert.ToDouble(txt_VatPerc.Text); }
            set { txt_VatPerc.Text = value.ToString(); }
        }

        public double TotalMapped
        {
            get { return Convert.ToDouble(txt_TotalMapped.Text); }
            set { txt_TotalMapped.Text = value.ToString(); }
        }

        public int BuyerId
        {
            get { return cmb_Firms2.FirmId; }
            set { cmb_Firms2.FirmId = value; }
        }

        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        public double CurRate
        {
            get { return Convert.ToDouble(txt_CurRate.Text); }
            set { txt_CurRate.Text = value.ToString(); }
        }

        public string PayDate
        {
            get
            {
                if (txt_PayDate.Value == null)
                    return "";
                else
                    return txt_PayDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_PayDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_PayDate.Value = null; }
            }
        }

        public double Mapped
        {
            get { return Convert.ToDouble(txt_TotalMapped.Text); }
            set { txt_TotalMapped.Text = value.ToString(); }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        #endregion

        #region Methods

        public void CalcPriceVat()
        {
            Vat = Math.Round(Summa * VatPerc / (100 + VatPerc), 2);
            SummaWVat = Math.Round(Summa - Vat, 2, MidpointRounding.AwayFromZero);

        }

        public void CalcPrice()
        {
            Summa = Math.Round(((SummaWVat * 100) / (100 + VatPerc)), 5, MidpointRounding.AwayFromZero);
        }

        public bool CheckEmpty()
        {
            bool _res = false;

            if (cmb_Currency1.CurrencyId == 0
                || cmb_Firms2.FirmId == 0
                || Summa < TotalMapped
                )
                _res = false;
            else
                _res = true;

            return _res;
        }



        #endregion

        #region Controls

        #endregion

        private void txt_Summa_Validated(object sender, EventArgs e)
        {
            if (Summa < TotalMapped)

            {
                Summa = TotalMapped;
                CalcPriceVat();
            }
        }

        private void txt_VatPerc_TextChanged(object sender, EventArgs e)
        {
            CalcPriceVat();
        }

        private void txt_Summa_TextChanged(object sender, EventArgs e)
        {
            CalcPriceVat();
        }
    }
}
