using ComponentFactory.Krypton.Toolkit;
using System;
using Odin.Tools;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Odin.Global_Classes
{
    public partial class frm_cmbDate : KryptonForm
    {
        public frm_cmbDate()
        {
            InitializeComponent();
        }

        public string Date
        {
            get { return txt_Date.Value.ToShortDateString(); }
            set
            {
                try { txt_Date.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            var _query = "sp_SelectBlockDateHistory";

            var sqlparams = new List<SqlParameter>()
            {

            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = "History for block date ";
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }
    }
}
