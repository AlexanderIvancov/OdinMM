using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.ToolsType
{
    public partial class frm_AddToolsType : KryptonForm
    {
        public frm_AddToolsType()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }

        public string Headertext
        {
            get { return this.Text; }
            set{ this.Text = value; }
        }

        public string ToolsType
        {
            get { return txt_ToolsType.Text; }
            set { txt_ToolsType.Text = value; }
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = txt_ToolsType.Text != ""
                && String.IsNullOrEmpty(ToolsType) != true;
        }
        #endregion


        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_ToolsType.Text = string.Empty;
        }

        private void txt_ToolsType_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
