﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Warehouse.Requests
{
    public partial class frm_EditRequestDet : KryptonForm
    {
        public frm_EditRequestDet()
        {
            InitializeComponent();
        }

        #region Variables

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }

        }

        public int Id
        { get; set; }

        public int BatchDetId
        { get; set; }

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }
        
        //public string Article
        //{
        //    get { }
        //    set { }
        //}

        public double Qty
        {
            get {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public double QtyOut
        {
            get
            {
                try { return Convert.ToDouble(txt_QtyOut.Text); }
                catch { return 0; }
            }
            set { txt_QtyOut.Text = value.ToString(); }
        }

        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }

        public string ReqDate
        {
            get { return txt_ReqDate.Value.ToShortDateString(); }
            set
            {
                try { txt_ReqDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string Batch
        {
            get { return txt_Batch.Text; }
            set { txt_Batch.Text = value; }
        }

        public int Urgent
        {
            get {
                return chk_Urgent.Checked == true ? -1 : 0;
            }
            set { chk_Urgent.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int State
        {
            get
            {
                return rb_Enabled.Checked == true ? -1 : rb_Closed.Checked == true ? 0 : 1;
            }
            set
            {
                if (value == -1)
                    rb_Enabled.Checked = true;
                else if (value == 0)
                    rb_Closed.Checked = true;
                else
                    rb_New.Checked = true;
            }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int CauseId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value;}
        }
        public string Serials
        {
            get { return txt_Serials.Text; }
            set { txt_Serials.Text = value; }
        }

        #endregion

        #region Methods

        public void EnableArticle()
        {
            cmb_Articles1.Enabled = BatchDetId == 0;

        }

        public void CheckEmpty()
        {
            btn_OK.Enabled = cmb_Articles1.ArticleId != 0
                && Qty > 0;
        }
        #endregion

        #region Controls

        #endregion

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            Unit = cmb_Articles1.Unit;
            CheckEmpty();
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }
    }
}
