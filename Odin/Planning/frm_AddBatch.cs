using ComponentFactory.Krypton.Toolkit;
namespace Odin.Planning
{
    public delegate void BatchSavedEventHandler(object sender);
    public partial class frm_AddBatch : KryptonForm
    {
        public frm_AddBatch()
        {
            InitializeComponent();
        }

        public event BatchSavedEventHandler BatchSaved;
                
        private void ctl_CreatBatchDets1_SaveBatch(object sender)
        {
            BatchSaved?.Invoke(this);
        }
        
    }
}
