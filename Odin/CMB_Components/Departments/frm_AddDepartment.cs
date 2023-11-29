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

namespace Odin.CMB_Components.Departments
{
    public partial class frm_AddDepartment : KryptonForm
    {
        public frm_AddDepartment()
        {
            InitializeComponent();
        }

        public int Id
        {
            get;set;
        }

        public int ParentId
        {
            get;set;
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Department
        {
            get { return txt_Department.Text; }
            set { txt_Department.Text = value; }
        }

        public string Description
        {
            get { return txt_Description.Text; }
            set { txt_Description.Text = value; }
        }

        public string RespPerson
        {
            get { return txt_RespTN.Text; }
            set { txt_RespTN.Text = value; }
        }


        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Department.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Description.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_RespTN.Text = string.Empty;
        }
    }
}
