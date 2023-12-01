using ComponentFactory.Krypton.Toolkit;

namespace Odin.Warehouse.StockIn
{
    public delegate void LabelsMergedEventHandler(object sender);

    public partial class frm_MergeLabels : KryptonForm
    {
        public frm_MergeLabels()
        {
            InitializeComponent();
        }

        #region Variables

        public event LabelsMergedEventHandler LabelsMerged;

        #endregion


    }
}
