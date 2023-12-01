using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Sales
{
    public partial class frm_AddExInvoicePayment : KryptonForm
    {
        public frm_AddExInvoicePayment()
        {
            InitializeComponent();
        }


        #region Variables

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public double PaidAmount
        {
            get
            {
                try { return Convert.ToDouble(txt_PaidAmount.Text); }
                catch { return 0; }
            }
            set { txt_PaidAmount.Text = value.ToString(); }
        }
        
        public string PaymentDate
        {
            get { return txt_PaymentDate.Value.ToShortDateString(); }
            set
            {
                try { txt_PaymentDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        #endregion

        #region Controls

        #endregion

        #region Methods

        #endregion

    }
}
