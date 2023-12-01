using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Register.Articles
{
    public partial class frm_AddAnalog : KryptonForm
    {
        public frm_AddAnalog()
        {
            InitializeComponent();
        }

        #region Variables

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int Id
        { get; set; }

        public int AnalogId
        { get { return cmb_Articles1.ArticleId; }
        set { cmb_Articles1.ArticleId = value; } }

        public string Comments
        { get { return txt_Comments.Text; }
        set { txt_Comments.Text = value; }
        }

        public int CustomerId
        { get { return cmb_Firms1.FirmId; }
        set { cmb_Firms1.FirmId = value; }
        }

        public int ProductId
        {
            get { return cmb_Articles2.ArticleId; }
            set { cmb_Articles2.ArticleId = value; }
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}
