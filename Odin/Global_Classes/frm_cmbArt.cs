using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Global_Classes
{
    public partial class frm_cmbArt : KryptonForm
    {
        public frm_cmbArt()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public string Article
        {
            get { return cmb_Articles1.Article; }
            set { cmb_Articles1.Article = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}
