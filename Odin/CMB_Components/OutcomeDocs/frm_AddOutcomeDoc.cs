using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Odin.CMB_Components.OutcomeDocs
{
    public partial class frm_AddOutcomeDoc : KryptonForm
    {
        public frm_AddOutcomeDoc()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DLL = new DAL_Functions();

        public int ReasonId
        {
            get {
                try { return Convert.ToInt32(cmb_Reason.SelectedValue); }
                catch { return 0; }
            }
            set { cmb_Reason.SelectedValue = value; }
        }

        public int TypeOff
        {
            get { if (rb_Production.Checked == true)
                    return 5;
                else
                    return 17;
            }
            set
            {
                if (value == 5)
                    rb_Production.Checked = true;
                else
                    rb_WriteOff.Checked = true;
            }
        }

        public int Id
        { get; set; }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string OutDoc
        {
            get { return txt_OutDoc.Text; }
            set { txt_OutDoc.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        
        public string DocDate
        {
            get { return txt_DocDate.Value.ToShortDateString(); }
            set
            {
                try { txt_DocDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }


        #endregion

        #region Controls


        private void rb_Production_CheckedChanged(object sender, EventArgs e)
        {
            if (TypeOff == 5)
            {
                cmb_Reason.Enabled = false;
                ReasonId = 0;
            }
            else
            {
                cmb_Reason.Enabled = true;
                BindReasons();
            }
            CheckReason();
        }

        private void rb_WriteOff_CheckedChanged(object sender, EventArgs e)
        {
            if (TypeOff == 5)
            {
                cmb_Reason.Enabled = false;
                ReasonId = 0;
            }
            else
            {
                cmb_Reason.Enabled = true;
                BindReasons();
            }
            CheckReason();
        }

        #endregion

        #region Methods

        public void BindReasons()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT code, description FROM sto_reasoncodes where lang = 'RUS' and isactive = -1", sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            cmb_Reason.DataSource = dt;
            cmb_Reason.DisplayMember = "description";
            cmb_Reason.ValueMember = "code";

            cmb_Reason.SelectedValue = 0;
        }

        public void FillAutoDoc(int _code)
        {
            OutDoc = DLL.AutoDoc(_code, System.DateTime.Now.ToShortDateString());
        }

        public void CheckReason()
        {
            if (TypeOff == 17
                && ReasonId == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }
        #endregion

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_OutDoc.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void cmb_Reason_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_Reason_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(ReasonId.ToString());
            CheckReason();
        }

        private void cmb_Reason_ValueMemberChanged(object sender, EventArgs e)
        {
            CheckReason();
        }
    }
}
