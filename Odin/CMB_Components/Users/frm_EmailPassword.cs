using ComponentFactory.Krypton.Toolkit;

namespace Odin.CMB_Components.Users
{
    public partial class frm_EmailPassword : KryptonForm
    {
        public frm_EmailPassword()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int Id
        { get; set; }

        public string UserLogin
        {
            get { return txt_UserLogin.Text; }
            set { txt_UserLogin.Text = value; }
        }

        public string Password
        {
            get { return txt_Password.Text; }
            set { txt_Password.Text = value; }
        }
    }
}
