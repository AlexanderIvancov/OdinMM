using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.CustomControls
{
    public partial class ctl_btnNum : UserControl
    {
        public ctl_btnNum()
        {
            InitializeComponent();
        }


        #region Variables
        Image _IconPath = global::Odin.Global_Resourses.Decline_32;
        public string strRunQuery
        {
            get;set;
        }
        public string FormText
        { get; set; }

        public List<SqlParameter> sqlParameters;

        public Image IconPath
        {
            get { return btn_ShowDets.Values.Image; }
            set { btn_ShowDets.Values.Image = value; }
        }

        public string ButtonText
        {
            get { return btn_ShowDets.Values.Text; }
            set { btn_ShowDets.Values.Text = value; }
        }
        //this.btn_ShowDets.Values.Image = global::Odin.Global_Resourses.Decline_32;
        //this.btn_ShowDets.Values.Text = "Invalide BOMs";
        public string Qty
        {
            get { return lbl_Qty.Text; }
            set { lbl_Qty.Text = value; }
        }

        //string _GetCountQuery = "select 0";
        public string GetCountQuery
        {
            get;set;
        }
        #endregion

        #region Methods

        #endregion

        #region Controls

        private void btn_ShowDets_Click(object sender, EventArgs e)
        {
            var _query = strRunQuery;

            var sqlparams = new List<SqlParameter>()
            {

            };

            Template_DataGridView frm = new Template_DataGridView();

            frm.Text = FormText;
            frm.Query = _query;
            frm.SqlParams = sqlparams;
            frm.Show();

            Qty = Helper.GetOneRecord(GetCountQuery).ToString();
        }

        private void ctl_btnNum_Load(object sender, EventArgs e)
        {
            Qty = Helper.GetOneRecord(GetCountQuery).ToString();
        }

        #endregion

    }
}
