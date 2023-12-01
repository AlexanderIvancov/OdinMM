using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Sales
{
    public delegate void SaveChangesEventHandler(object sender);

    public partial class frm_AddCODet : KryptonForm
    {
        public frm_AddCODet()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value;}
        }

        public event SaveChangesEventHandler SaveChanges;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SaveChanges?.Invoke(this);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
