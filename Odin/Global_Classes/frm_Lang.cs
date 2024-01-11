using System;
using System.Windows.Forms;

namespace Odin.Global_Classes
{
    public partial class frm_Lang : Form
    {
        public frm_Lang()
        {
            InitializeComponent();
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            DAL_Functions df = new DAL_Functions();
            if (this.btn_eng.Checked) df.ChangeUserLang("ENG");
            if (this.btn_rus.Checked) df.ChangeUserLang("RUS");
        }
    }
}