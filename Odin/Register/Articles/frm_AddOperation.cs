﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;

namespace Odin.Register.Articles
{
    public partial class frm_AddOperation : KryptonForm
    {
        public frm_AddOperation()
        {
            InitializeComponent();
        }
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int Id
        { get; set; }

        public int UsingOnce
        {
            get
            {
                if (chk_Use.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_Use.CheckState = CheckState.Checked;
                else
                    chk_Use.CheckState = CheckState.Unchecked;
            }
        }
        public string Operation
        {
            get { return txt_Operation.Text; }
            set { txt_Operation.Text = value; }
        }
        public string Formula
        {
            get { return txt_Formula.Text; }
            set { txt_Formula.Text = value; }
        }

        public void CheckEmpty()
        {
            if (txt_Formula.Text == ""
                || txt_Operation.Text == ""
                || txt_Operation.Text == string.Empty
                || txt_Formula.Text == string.Empty)
                btn_OK.Enabled = false;
            else
                btn_OK.Enabled = true;
        }

        private void txt_Operation_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void txt_Formula_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void chk_Use_CheckedChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Operation.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Formula.Text = string.Empty;
        }

        private void btn_AddFromTemplate_Click(object sender, EventArgs e)
        {
            Operation = cmb_Operations1.Operation;
            Formula = cmb_Operations1.Formula;
        }
    }
}