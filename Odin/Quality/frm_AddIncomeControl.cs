using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;

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
            if (ArtId == 0 && SupId == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
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
