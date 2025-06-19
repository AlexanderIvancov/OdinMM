using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Register.Articles
{
    public partial class frm_AddArtCertificates : KryptonForm
    {
        public frm_AddArtCertificates()
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

        public int certNum
        { get { return Convert.ToInt32(cn_certNum.Text); }
        set { cn_certNum.Text = value.ToString(); } }

        public string Comments
        { get { return cn_comment.Text; }
        set { cn_comment.Text = value; }
        }

        public string TNVED
        {
            get { return cn_tnved.Text; }
            set { cn_tnved.Text = value; }
        }

        public string dateTo
        { 
            get { return cn_dateTo.Value.ToString(); }
            set { cn_dateTo.Value = Convert.ToDateTime(value); }
        }

        public string dateFrom
        {
            get { return cn_dateFrom.Value.ToString(); }
            set { cn_dateFrom.Value = Convert.ToDateTime(value); }
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            cn_comment.Text = string.Empty;
        }
    }
}
