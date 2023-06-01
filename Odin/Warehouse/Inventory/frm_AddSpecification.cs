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

namespace Odin.Warehouse.Inventory
{
    public partial class frm_AddSpecification : KryptonForm
    {
        public frm_AddSpecification()
        {
            InitializeComponent();
        }

        public int CategoryId
        {
            get { return cmb_Category1.CategoryId; }
            set { cmb_Category1.CategoryId = value; }
        }

        public string Value
        {
            get { return txt_Value.Text; }
            set { txt_Value.Text = value; }
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

        public int Label
        { get; set; }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Value.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        public void CheckEmpty()
        {
            if (String.IsNullOrEmpty(Value) == true
                || Value == ""
                || CategoryId == 0)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        private void cmb_Category1_SelectedValueChanged(object sender)
        {
            CheckEmpty();

        }

        private void txt_Value_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}