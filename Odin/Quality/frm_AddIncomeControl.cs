using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Quality
{
    public delegate void IncomeControlSavedEventHandler(object sender);

    public partial class frm_AddIncomeControl : KryptonForm
    {
        public frm_AddIncomeControl()
        {
            InitializeComponent();
        }

        #region Variables

        public event IncomeControlSavedEventHandler IncomeControlSaved;

        public int ID
        { get; set; }

        public string HeaderText
        { get { return this.Text; }
        set { this.Text = value; }
        }

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public int State
        {
            get { return checkBox1.Checked == true ? -1 : 0; }
            set { checkBox1.Checked = value == -1 ? true : false; }
        }


        public int SupId
        { get { return cmb_Firms1.FirmId; }
        set { cmb_Firms1.FirmId = value; } }

        public string Comments
        { get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; } }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            this.Text = string.Empty;
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = ArtId != 0 || SupId != 0;
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            CheckEmpty();
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            CheckEmpty();
        }
    }
}
