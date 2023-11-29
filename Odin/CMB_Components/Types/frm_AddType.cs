using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.CMB_Components.Types
{
    public partial class frm_AddType : KryptonForm
    {
        public frm_AddType()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        {
            get; set;
        }

        public int ParentId
        {
            get { return cmb_Types1.TypeId; }
            set { cmb_Types1.TypeId = value; }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Type
        {
            get { return txt_Type.Text; }
            set { txt_Type.Text = value; }
        }

        public string TypeLat
        {
            get { return txt_TypeLV.Text; }
            set { txt_TypeLV.Text = value; }
        }

        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }

        public int CustCodeId
        {
            get { return cmb_CustCodes1.CustCodeId; }
            set { cmb_CustCodes1.CustCodeId = value; }
        }

        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Type.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_TypeLV.Text = string.Empty;
        }
    }
}
