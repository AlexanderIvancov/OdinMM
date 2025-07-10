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

        public string certNum
        { get { return cn_certNum.Text; }
        set { cn_certNum.Text = value; } }

        public string isValid
        {
            get { return chk_IsValid.Text; }
            set { chk_IsValid.Text = value; }
        }

        public string Comments
        { get { return cn_comment.Text; }
        set { cn_comment.Text = value; }
        }

        public string TNVED
        {
            get { return cn_tnved.Text; }
            set { cn_tnved.Text = value; }
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
