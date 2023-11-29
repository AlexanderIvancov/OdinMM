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
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.Planning.Passport
{
    public partial class frm_AddLaunchPassportComment : KryptonForm
    {
        public frm_AddLaunchPassportComment()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string TechComments
        {
            get { return txt_TechComments.Text; }
            set { txt_TechComments.Text = value; }
        }

        public int StateId
        {
            get { if (rb_New.Checked == true)
                    return -1;
                else if (rb_Closed.Checked == true)
                    return 0;
                else
                    return 1;
            }
            set {
                if (value == -1)
                {
                    rb_New.Checked = true;
                    rb_Closed.Checked = false;
                    rb_Cancelled.Checked = false;
                } 
                else if (value == 0)
                {
                    rb_New.Checked = false;
                    rb_Closed.Checked = true;
                    rb_Cancelled.Checked = false;
                }
                else
                {
                    rb_New.Checked = false;
                    rb_Closed.Checked = false;
                    rb_Cancelled.Checked = true;
                }

            }
        }       
        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = "";
        }

        public void FillRBs(int stateid)
        {
            if (stateid == -1)
            {
                StateId = -1;
                rb_Cancelled.Enabled = false;
                rb_Closed.Enabled = false;
            }
            else
            {
                rb_New.Enabled = true;
                rb_Cancelled.Enabled = true;
                rb_Closed.Enabled = true;
            }
        }

        public void CheckEmpty()
        {
            if (txt_Comments.Text == "")
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        private void txt_Comments_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_TechComments.Text = "";
        }

        public int SendEmail
        {
            get { if (chk_SendEmail.Checked == true)
                    return -1;
                else
                    return 0; 
            }
            set{
                if (value == 0)
                    chk_SendEmail.Checked = false;
                else
                    chk_SendEmail.Checked = true;
            }
            
        }
    }
}
