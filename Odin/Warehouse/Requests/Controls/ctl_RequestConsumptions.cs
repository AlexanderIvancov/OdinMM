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

namespace Odin.Warehouse.Requests.Controls
{
    public partial class ctl_RequestConsumptions : UserControl
    {
        public ctl_RequestConsumptions()
        {
            InitializeComponent();
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Requests_BLL BLL = new Requests_BLL();


        int _ReqId = 0;

        public int ReqId
        {
            get { return _ReqId; }
            set
            {
                //cmb_Articles1.ArticleId = value;
                _ReqId = value;
                FillHistory(_ReqId);
                //SetCellsColor();
            }
        }

        public void FillHistory(int ReqId)
        {
            var data = Requests_BLL.getHistoryOutcomes(ReqId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                //SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

    }
}