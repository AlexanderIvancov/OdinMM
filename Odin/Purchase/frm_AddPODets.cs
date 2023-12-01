using ComponentFactory.Krypton.Toolkit;
namespace Odin.Purchase
{
    public delegate void POSavedEventHandler(object sender);
    public partial class frm_AddPODets : KryptonForm
    {
        public frm_AddPODets()
        {
            InitializeComponent();
        }

        public event POSavedEventHandler POLineSaved;

        private void ctl_PODets1_SendPOId(object sender)
        {
            if (POLineSaved != null)
                POLineSaved(this);
        }
    }
}
