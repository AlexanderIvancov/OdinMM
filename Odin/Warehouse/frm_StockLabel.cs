using System.Windows.Forms;

namespace Odin.Warehouse
{
    public partial class frm_StockLabel : Form
    {
        public frm_StockLabel()
        {
            InitializeComponent();
        }

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
    }
}
