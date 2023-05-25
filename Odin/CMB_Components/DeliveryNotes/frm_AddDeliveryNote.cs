﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;
using ComponentFactory.Krypton.Ribbon;
using Odin.Tools;
using System.Data.SqlClient;


namespace Odin.CMB_Components.DeliveryNotes
{
    public partial class frm_AddDeliveryNote : KryptonForm
    {
        public frm_AddDeliveryNote()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }

        DAL_Functions DLL = new DAL_Functions();

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string DelivNote
        {
            get { return txt_DeliveryNote.Text; }
            set { txt_DeliveryNote.Text = value; }
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

        public string DelivDate
        {
            get { return txt_DelivDate.Value.ToShortDateString(); }
            set
            {
                try { txt_DelivDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
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

        public int FinalDelivPlaceId
        {
            get { return cmb_Firms2.FirmId; }
            set { cmb_Firms2.FirmId = value; }
        }

        public int FinalDelivAddressId
        {
            get { return cmb_Address2.AddressId; }
            set { cmb_Address2.AddressId = value; }
        }

        public int IncotermsId
        {
            get { return cmb_Incoterms1.IncotermId; }
            set { cmb_Incoterms1.IncotermId = value; }
        }

        public int TransportId
        {
            get { return cmb_Transport1.TransportId; }
            set { cmb_Transport1.TransportId = value; }
        }

        public int QtyPalettes
        {
            get { try { return Convert.ToInt32(txt_QtyPalettes.Text); }
                catch { return 0; }
            }
            set { txt_QtyPalettes.Text = value.ToString(); }
        }

        public double PalettesWeight
        {
            get
            {
                try { return Convert.ToDouble(txt_PalettesWeight.Text); }
                catch { return 0; }
            }
            set { txt_PalettesWeight.Text = value.ToString(); }
        }

        public string CreditAccount
        {
            get { return txt_CreditAccount.Text; }
            set { txt_CreditAccount.Text = value; }
        }

        public int IsReturn
        {
            get { if (chk_return.Checked == true)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_return.Checked = true;
                else
                    chk_return.Checked = false;
            }
        }

        public int NoReversePVN
        {
            get
            {
                if (chk_noreversepvn.Checked == true)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_noreversepvn.Checked = true;
                else
                    chk_noreversepvn.Checked = false;
            }
        }

        public int Internal
        {
            get
            {
                if (chk_Internal.Checked == true)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Internal.Checked = true;
                else
                    chk_Internal.Checked = false;
            }
        }

        #endregion

        #region Methods

        public void FillAutoDoc(int _code)
        {
            DelivNote = DLL.AutoDoc(_code, System.DateTime.Now.ToShortDateString());
        }

        public void CheckEmpty()
        {
            if (cmb_Firms1.FirmId == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        #endregion

        #region Controls

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            cmb_Address1.DefaultDelivPlace = -1;
            cmb_Address1.FirmId = cmb_Firms1.FirmId;
            CheckEmpty();
        }

        private void cmb_Firms2_FirmsChanged(object sender)
        {
            cmb_Address2.DefaultDelivPlace = -1;
            cmb_Address2.FirmId = cmb_Firms2.FirmId;
            CheckEmpty();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            cmb_Firms2.FirmId = cmb_Firms1.FirmId;
            cmb_Address2.AddressId = cmb_Address1.AddressId;
            CheckEmpty();
        }


        #endregion

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_CreditAccount.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }
    }
}
