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
using Odin.Register;

namespace Odin.CMB_Components.ContactPersons
{
    public partial class frm_ContactPerson : KryptonForm
    {
        public frm_ContactPerson()
        {
            InitializeComponent();
        }

        public frm_ContactPerson(cmb_ContactPersons cmb)
        {
            InitializeComponent();
            f = new cmb_ContactPersons();
            cmb = f;
        }


        class_Global glob_Class = new class_Global();
        Reg_BLL Bll = new Reg_BLL();

        bool _showingModal = false;
        cmb_ContactPersons f;



        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_ContactPersons)cmb_ContactPersonOne).txt_ContPerson.Text = gv_List.CurrentRow.Cells["cn_fullname"].Value.ToString();
                ((cmb_ContactPersons)cmb_ContactPersonOne).ContPersId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }


        public void FillData(int FirmId)
        {
            var data = Reg_BLL.getContacts(FirmId);

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
