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

namespace Odin.Warehouse.Deliveries
{
    public partial class frm_AddPack : KryptonForm
    {
        public frm_AddPack()
        {
            InitializeComponent();
        }

        #region Variables

        public int Id
        { get; set; }

        public string HeaderText
        { get; set; }

        public string Package
        { get { return cmb_Packages1.Package; }
            set { cmb_Packages1.Package = value; }
        }

        public int QtyPack
        {
            get {
                try { return Convert.ToInt32(txt_QtyPack.Text); }
                catch { return 0; }
            }
            set { txt_QtyPack.Text = value.ToString(); }
        }

        public int BoxNO
        {
            get
            {
                try { return Convert.ToInt32(txt_BoxNO.Text); }
                catch { return 0; }
            }
            set { txt_BoxNO.Text = value.ToString(); }
        }

        public double WeightBrut
        {
            get
            {
                try { return Convert.ToDouble(txt_WeightBrut.Text); }
                catch { return 0; }
            }
            set { txt_WeightBrut.Text = value.ToString(); }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        public void CheckEmpty()
        {
            if (Package == ""
                || String.IsNullOrEmpty(Package) == true)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;

        }

        #endregion

        private void cmb_Packages1_PackagesChanged(object sender)
        {
            CheckEmpty();
        }
    }
}