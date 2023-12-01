using ComponentFactory.Krypton.Toolkit;
namespace Odin.Planning
{
    public delegate void BatchSavedPEventHandler(object sender);
    public partial class frm_AddBatchP : KryptonForm
    {
        public frm_AddBatchP()
        {
            InitializeComponent();
        }

        public event BatchSavedPEventHandler BatchSaved;
               
        private void ctl_CreatBatchDetsP1_SaveBatch(object sender)
        {
            BatchSaved?.Invoke(this);
        }
    }
}
