using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Global_Classes
{
    public partial class frm_cmbArtQty : KryptonForm
    {
        public frm_cmbArtQty()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public int Id
        { get; set; }

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

    }
}
