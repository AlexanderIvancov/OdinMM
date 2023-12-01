using ComponentFactory.Krypton.Toolkit;

namespace Odin.Warehouse.StockIn
{
    public delegate void EditStockInSavedEventHandler(object sender);

    public partial class frm_EditStockIn : KryptonForm
    {
        public frm_EditStockIn()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public event EditStockInSavedEventHandler StockInLineSaved;

        private void ctl_StockInEdit1_EditSendStockInId(object sender)
        {
            StockInLineSaved?.Invoke(this);
        }
    }
}
