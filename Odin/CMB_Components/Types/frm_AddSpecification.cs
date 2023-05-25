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

namespace Odin.CMB_Components.Types
{
    public partial class frm_AddSpecification : KryptonForm
    {
        public frm_AddSpecification()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        {
            get; set;
        }
               

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Specification
        {
            get { return txt_Specification.Text; }
            set { txt_Specification.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string TypeOfData
        {
            get { return cmb_TypeOfData.Text; }
            set { cmb_TypeOfData.Text = value; }
        }

        public void CheckEmpty()
        {
            if (txt_Specification.Text == String.Empty
                || txt_Specification.Text == "")
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;

        }

        public int UnitId
        {
            get { return cmb_CharUnits1.UnitId; }
            set { cmb_CharUnits1.UnitId = value; }
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Specification.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void txt_Specification_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
