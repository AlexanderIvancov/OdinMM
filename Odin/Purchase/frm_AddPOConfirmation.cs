﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;


namespace Odin.Purchase
{
    public partial class frm_AddPOConfirmation : KryptonForm
    {
        public frm_AddPOConfirmation()
        {
            InitializeComponent();
        }

        #region Variables

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public string ConfDate
        {
            get { return txt_ConfDate.Value.ToShortDateString(); }
            set
            {
                try { txt_ConfDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string ConfType
        {
            get { return cmb_ConfType.Text; }
            set { cmb_ConfType.Text = value; }
        }

        #endregion

        #region Methods

        public void FillType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Txt", typeof(string)));

            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());

            dt.Rows[0][0] = "";
            dt.Rows[1][0] = "Firm";
            dt.Rows[2][0] = "Estimated";
            dt.Rows[3][0] = "Not confirmed";

            cmb_ConfType.DataSource = dt;
            cmb_ConfType.DisplayMember = "Txt";
            cmb_ConfType.ValueMember = "Txt";

            ConfType = "Firm";
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = Qty > 0
                && ConfDate != "";
        }

        #endregion

        #region Controls

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }


        #endregion

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void frm_AddPOConfirmation_Load(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
