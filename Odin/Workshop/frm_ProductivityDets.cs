using System.Windows.Forms;

namespace Odin.Workshop
{
    public partial class frm_ProductivityDets : Form
    {
        public frm_ProductivityDets()
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
