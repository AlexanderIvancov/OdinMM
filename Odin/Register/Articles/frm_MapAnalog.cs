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

namespace Odin.Register.Articles
{
    public partial class frm_MapAnalog : KryptonForm
    {
        public frm_MapAnalog()
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

        public int Valid
        {
            get
            {
                if (chk_Valid.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Valid.CheckState = CheckState.Checked;
                else
                    chk_Valid.CheckState = CheckState.Unchecked;
            }
        }
        public string ValidAt
        {
            get { return txt_ValidAt.Text; }
            set { txt_ValidAt.Text = value; }
        }

        public string ValidBy
        {
            get { return txt_ValidBy.Text; }
            set { txt_ValidBy.Text = value; }
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}
