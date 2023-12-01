using ComponentFactory.Krypton.Toolkit;

namespace Odin.Purchase
{
    public partial class frm_AddPONeeds : KryptonForm
    {
        public frm_AddPONeeds()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
    }
}
