using ComponentFactory.Krypton.Toolkit;



namespace Odin.Sales.DeliveryPlanning
{
    public partial class frm_DeliveryItemDets : KryptonForm
    {
        public frm_DeliveryItemDets()
        {
            InitializeComponent();
        }

        public string ItemText
        {
            get { return txt_Text.Text; }
            set { txt_Text.Text = value; }
        }
    }
}
