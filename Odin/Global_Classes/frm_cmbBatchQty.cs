﻿using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Global_Classes
{
    public partial class frm_cmbBatchQty : KryptonForm
    {
        public frm_cmbBatchQty()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public string Batch
        {
            get { return cmb_Batches1.Batch; }
            set { cmb_Batches1.Batch = value; }
        }

        public int IsActive
        {
            get { return cmb_Batches1.IsActive; }
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

    }
}
