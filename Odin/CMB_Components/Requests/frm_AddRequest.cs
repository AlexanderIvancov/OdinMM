using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;

namespace Odin.CMB_Components.Requests
{
    public partial class frm_AddRequest : KryptonForm
    {
        public frm_AddRequest()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DLL = new DAL_Functions();

        public int Id
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Request
        {
            get { return txt_Request.Text; }
            set { txt_Request.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int ProdPlaceId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }

        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Request.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        public void FillAutoDoc(int _code)
        {
            Request = DLL.AutoDoc(_code, System.DateTime.Now.ToShortDateString());
        }
    }
}
