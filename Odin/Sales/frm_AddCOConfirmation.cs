﻿using ComponentFactory.Krypton.Toolkit;
using System;


namespace Odin.Sales
{
    public partial class frm_AddCOConfirmation : KryptonForm
    {
        public frm_AddCOConfirmation()
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

        public int DelivPlaceId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value; }
        }

        public int DelivAddressId
        {
            get { return cmb_Address1.AddressId; }
            set { cmb_Address1.AddressId = value; }
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

        #endregion

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            cmb_Address1.FirmId = cmb_Firms1.FirmId;
        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = Qty > 0
                && ConfDate != "";
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
