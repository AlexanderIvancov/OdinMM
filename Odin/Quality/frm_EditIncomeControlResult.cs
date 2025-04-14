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
    public partial class frm_EditIncomeControlResult : KryptonForm
    {
        public frm_EditIncomeControlResult()
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

        public string Article
        {
            get { return cmb_Articles1.Article; }
            set { cmb_Articles1.Article = value; }
        }
        public double QtyChecked
        {
            get {
                try { return Convert.ToDouble(txt_QtyChecked.Text); }
                catch { return 0; }
            }
            set { txt_QtyChecked.Text = value.ToString(); }         
        }

        public double QtyScrap
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyScrap.Text); }
                catch { return 0; }
            }
            set { txt_QtyScrap.Text = value.ToString(); }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string Reclamation
        {
            get { return txt_Reclamation.Text; }
            set { txt_Reclamation.Text = value; }
        }

        public string CheckDate
        {
            get
            {
                if (txt_CheckDate.Value == null)
                    return "";
                else
                    return txt_CheckDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_CheckDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_CheckDate.Value = null; }
            }
        }

        public string Controller
        {
            get { return txt_Controller.Text; }
            set { txt_Controller.Text = value; }
        }


        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            this.Text = string.Empty;
        }

        public void CheckEmpty()
        {
           
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            CheckEmpty();
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            CheckEmpty();
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Reclamation.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Controller.Text = string.Empty;
        }

        private void txt_CheckDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CheckDate.Value = txt_CheckDate.Value == null ? System.DateTime.Now : txt_CheckDate.Value;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_CheckDate.Value = System.DateTime.Now;
        }
    }
}
