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
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;

namespace Odin.CMB_Components.Package
{
    public partial class frm_PackagesPDA : KryptonForm
    {
        public frm_PackagesPDA()
        {
            InitializeComponent();
        }

        public frm_PackagesPDA(cmb_PackagesPDA cmb)
        {
            InitializeComponent();
            f = new cmb_PackagesPDA();
            cmb = f;
        }
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_PackagesPDA f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_PackagesPDA)cmb_PackageOne).txt_Packages.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_PackagesPDA)cmb_PackageOne).PackageId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getPackage(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}