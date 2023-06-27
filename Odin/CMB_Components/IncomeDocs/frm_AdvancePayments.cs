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

namespace Odin.CMB_Components.IncomeDocs
{
    public partial class frm_AdvancePayments : KryptonForm
    {
        public frm_AdvancePayments()
        {
            InitializeComponent();
        }
        CMB_BLL Bll = new CMB_BLL();
        class_Global glob_Class = new class_Global();
        #region Variables
        public int HeadId
        { get; set; }

        #endregion

        #region Methods

        public void FillAdvances(int headid)
        {
            var data = CMB_BLL.getIncomeAdvances(headid);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;
        }

        #endregion

        #region Controls

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm_AddAdvance frm = new frm_AddAdvance();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bll.AddIncomeDocAdvance(HeadId, frm.Amount, frm.CurId, frm.CurDate, frm.Rate);
                FillAdvances(HeadId);
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id  = 0;
            double _amount = 0;
            int _curid = 0;
            string _curdate = "";
            double _rate = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _amount = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_amount"].Value);
                _curid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value);
                _curdate = gv_List.CurrentRow.Cells["cn_paydate"].Value.ToString();
                _rate = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_currate"].Value);
            }
            catch { }
            if (_id != 0)
            {
                frm_AddAdvance frm = new frm_AddAdvance();
                frm.Amount = _amount;
                frm.CurId = _curid;
                frm.CurDate = _curdate;
                frm.Rate = _rate;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Bll.EditIncomeDocAdvance(_id, frm.Amount, frm.CurId, frm.CurDate, frm.Rate);
                    FillAdvances(HeadId);
                }

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
           

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                
            }
            catch { }
            if (_id != 0 && glob_Class.DeleteConfirm() == true)
            {
                Bll.DeleteIncomeDocAdvance(_id);
                FillAdvances(HeadId);
            }
        }

        #endregion

    }
}