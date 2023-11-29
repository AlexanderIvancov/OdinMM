using ComponentFactory.Krypton.Toolkit;

namespace Odin.Sales
{
    public delegate void QuotationSavedEventHandler(object sender);

    public partial class frm_AddQuotation : KryptonForm
    {
        public frm_AddQuotation()
        {
            InitializeComponent();
        }

        public event QuotationSavedEventHandler QuotationSaved;

        private void ctl_QuotDets1_SendQuotId(object sender)
        {
            if (QuotationSaved != null)
                QuotationSaved(this);
        }
    }
}
