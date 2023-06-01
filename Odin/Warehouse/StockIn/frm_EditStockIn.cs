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

namespace Odin.Warehouse.StockIn
{
    public delegate void EditStockInSavedEventHandler(object sender);

    public partial class frm_EditStockIn : KryptonForm
    {
        public frm_EditStockIn()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public event EditStockInSavedEventHandler StockInLineSaved;

        private void ctl_StockInEdit1_EditSendStockInId(object sender)
        {
            if (StockInLineSaved != null)
                StockInLineSaved(this);
        }
    }
}