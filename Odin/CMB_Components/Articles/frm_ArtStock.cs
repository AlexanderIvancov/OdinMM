using System.Windows.Forms;

namespace Odin.CMB_Components.Articles
{
    public partial class frm_ArtStock : Form
    {
        public frm_ArtStock()
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
