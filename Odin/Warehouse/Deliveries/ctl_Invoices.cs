﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;

namespace Odin.Warehouse.Deliveries
{
    public partial class ctl_Invoices : UserControl
    {
        public ctl_Invoices()
        {
            InitializeComponent();
        }


        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();

        int _delivid = 0;

        public int DelivId
        {
            get { return _delivid; }
            set
            {

                _delivid = value;
                FillInvoices(_delivid);
            }
        }

        public void FillInvoices(int _delivid)
        {
            var data = DelivNote_BLL.getDelivInvoices(_delivid);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

    }
}
