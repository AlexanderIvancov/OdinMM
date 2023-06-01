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

namespace Odin.Sales
{
    public delegate void QuotIdSendingEventHandler(object sender);

    public partial class ctl_QuotDets : UserControl
    {
        public ctl_QuotDets()
        {
            InitializeComponent();
        }

        #region Variables

        public event QuotIdSendingEventHandler SendQuotId;

        DAL_Functions DLL = new DAL_Functions();
        Helper MyHelper = new Helper();
        class_Global glob_Class = new class_Global();
    
        int _iscopy = 0;

        public int IsCopy
        {
            get { return _iscopy; }
            set { _iscopy = value; }
        }

        public string Quotation
        {
            get { return txt_Quotation.Text; }
            set { txt_Quotation.Text = value; }
        }

        public string Revision
        {
            get { return txt_Revision.Text; }
            set{ txt_Revision.Text = value; }
            
        }

        public int PCB
        {
            get { if (chk_PCB.CheckState == CheckState.Checked)
                    return -1;
                else if (chk_PCB.CheckState == CheckState.Unchecked)
                    return 0;
                else
                    return 1;
            }
            set {
                if (value == -1)
                    chk_PCB.CheckState = CheckState.Checked;
                else if (value == 0)
                    chk_PCB.CheckState = CheckState.Unchecked;
                else chk_PCB.CheckState = CheckState.Indeterminate;
            }
        }

        public int IsProject
        {
            get
            {
                if (chk_project.CheckState == CheckState.Checked)
                    return -1;
                else 
                    return 0;
               
            }
            set
            {
                if (value == -1)
                    chk_project.CheckState = CheckState.Checked;
                else 
                    chk_project.CheckState = CheckState.Unchecked;
               
            }
        }
        public int IsSent
        {
            get
            {
                if (chk_IsSent.CheckState == CheckState.Checked)
                    return -1;
                else 
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_IsSent.CheckState = CheckState.Checked;
                else
                    chk_IsSent.CheckState = CheckState.Unchecked;
               
            }
        }

        class_Global globClass = new class_Global();

        CO_BLL COBll = new CO_BLL();

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }

            set { cmb_Articles1.ArticleId = value; }
        }
       public int CustId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value; }
        }
        public string CustArticle
        {
            get { return txt_CustArticle.Text; }
            set { txt_CustArticle.Text = value; }
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

        public double Spoilage
        {
            get
            {
                try { return Convert.ToDouble(txt_Spoilage.Text); }
                catch { return 0; }
            }
            set { txt_Spoilage.Text = value.ToString(); }
        }

        public int UnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
        }
        public double UnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_UnitPrice.Text); }
                catch { return 0; }
            }
            set { txt_UnitPrice.Text = value.ToString(); }
        }
        
        public int StateId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
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

        public DateTime ReqDateD
        {
            get { return Convert.ToDateTime(txt_ReqDate.Value); }
            set { txt_ReqDate.Value = value; }
        }

        public string ExpDate
        {
            get
            {
                if (txt_ExpDate.Value == null)
                    return "";
                else
                    return txt_ExpDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_ExpDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_ExpDate.Value = null; }
            }
        }

        public string SentDate
        {
            get
            {
                if (txt_SentDate.Value == null)
                    return "";
                else
                    return txt_SentDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_SentDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_SentDate.Value = null; }
            }
        }

        public DateTime ExpDateD
        {
            get { return Convert.ToDateTime(txt_ExpDate.Value); }
            set { txt_ExpDate.Value = value; }
        }

        public DateTime SentDateD
        {
            get { return Convert.ToDateTime(txt_SentDate.Value); }
            set { txt_SentDate.Value = value; }
        }

        public string Week
        {
            get { return cmb_Week1.Week; }
            set { cmb_Week1.Week = value; }
        }

        public string CreatAt
        {
            get { return txt_CreatAt.Text; }
            set { txt_CreatAt.Text = value; }
        }
        public string CreatBy
        {
            get { return txt_CreatBy.Text; }
            set { txt_CreatBy.Text = value; }
        }
        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        int _notpaidadvance = 0;

        public int Resale
        {
            get
            {
                if (chk_resale.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_resale.Checked = true;
                else
                    chk_resale.Checked = false;
            }
        }

        public int NotPaidAdvance
        {
            get
            {
                return _notpaidadvance;
            }
            set
            {
                _notpaidadvance = value;
                if (_notpaidadvance == 0)
                {
                    lbl_NotPaid.Visible = false;
                    lbl_Paid.Visible = false;
                }
                else if (_notpaidadvance == 1)
                {
                    lbl_Paid.Visible = true;
                    lbl_NotPaid.Visible = false;
                }
                else
                {
                    lbl_Paid.Visible = false;
                    lbl_NotPaid.Visible = true;
                }
            }
        }
        int _validbom;
        public int ValidBOM
        {
            get { return _validbom; }
            set {
                _validbom = value;
                if (_validbom == 0)
                {
                    lbl_validbom.Visible = false;
                    lbl_invalidbom.Visible = true;
                }
                else
                {
                    lbl_invalidbom.Visible = false;
                    lbl_validbom.Visible = true;
                }
                }
        }
        public int EndCustomerId
        { get { return cmb_EndCustomer1.FirmId; }
            set { cmb_EndCustomer1.FirmId = value; } }

        public int Internal
        {
            get
            {
                if (chk_internal.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_internal.Checked = true;
                else
                    chk_internal.Checked = false;
            }
        }
        public int Blocked
        {
            get
            {
                if (chk_blockdelivery.CheckState == CheckState.Checked)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_blockdelivery.Checked = true;
                else
                    chk_blockdelivery.Checked = false;
            }
        }

        public int CheckRMQP
        { get; set; }
        public void ClearCODets()
        {
            ArtId = 0;
            Comments = "";
            CreatAt = "";
            CreatBy = "";
            CustArticle = "";
            Qty = 0;
            StateId = 0;
            UnitId = 0;
            UnitPrice = 0;
            ReqDate = "";
            CurId = 0;
            CustOrder = "";
            CustLine = "";
            Internal = 0;
            Spoilage = 0;
            Resale = 0;
            Blocked = 0;
            ValidBOM = 0;
            CheckRMQP = 0;
        }

        public string CustOrder
        {
            get { return txt_CustOrder.Text; }
            set { txt_CustOrder.Text = value; }
        }
        public string CustLine
        {
            get { return txt_CustLine.Text; }
            set { txt_CustLine.Text = value; }
        }

        #endregion

        #region Methods

        public void FillAutoDoc(int _code)
        {
            Quotation = DLL.AutoDoc(_code, System.DateTime.Now.ToShortDateString());
        }

        public void FillStages(int id)
        {
            var data = CO_BLL.getQuotStages(id);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });
        }

        public void FillDates()
        {
            txt_SentDate.Value = System.DateTime.Now;
            txt_SentDate.Value = null;
        }

        int _quotid = 0;
        public int QuotId
        {
            get { return _quotid; }
            set
            {
                _quotid = value;

                CO_BLL COBll = new CO_BLL();

                COBll.QuotId = _quotid;

                CustId = COBll.QCustId;
                if (IsCopy == -1)
                    FillAutoDoc(10);
                else
                    Quotation = COBll.QName;
                ArtId = COBll.QArtId;
                Comments = COBll.QComments;
                CreatAt = COBll.QCreatAt;
                CreatBy = COBll.QCreatBy;
                CustArticle = COBll.QCustArticle;
                Qty = COBll.QQty;
                if (IsCopy == -1)
                    ReqDate = System.DateTime.Now.ToShortDateString();
                else
                    ReqDate = COBll.QReqDate;
                if (IsCopy == -1)
                    StateId = 1; //In process
                else
                    StateId = COBll.QStateId;
                UnitId = COBll.QUnitId;
                UnitPrice = COBll.QUnitPrice;
                Revision = COBll.QRevision;
                PCB = COBll.QPCB;
                if (IsCopy == -1)
                    Week = "W" + (cmb_Week1.WeekNumber(ReqDateD).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(ReqDateD).ToString() : cmb_Week1.WeekNumber(ReqDateD).ToString()) + "." + ReqDateD.Year.ToString();
                else
                    Week = COBll.QWeek;
                CurId = COBll.QCurId;
                CustOrder = COBll.QCOrder;
                CustLine = COBll.QCOLine;
                IsSent = COBll.QIsSent;
                SentDate = COBll.QSentDate;
                ExpDate = COBll.QExpDate;
                NotPaidAdvance = COBll.QNotPaidAdvance;
                EndCustomerId = COBll.QEndCustomerId;
                Internal = COBll.QInternal;
                Spoilage = COBll.QSpoilageQty;
                Resale = COBll.QResale;
                Blocked = COBll.QBlockDelivery;
                IsProject = COBll.QIsProject;
                ValidBOM = COBll.QValidBOM;
                CheckRMQP = COBll.QCheckRMQP;
                
                FillStages(_quotid);

                if (IsCopy == -1)
                    _quotid = 0;

            }
        }

        #endregion

        #region Controls

        private void chk_PCB_CheckStateChanged(object sender, EventArgs e)
        {
            if (chk_PCB.CheckState == CheckState.Checked)
                chk_PCB.Text = "PCB: Yes";
            else if (chk_PCB.CheckState == CheckState.Unchecked)
                chk_PCB.Text = "PCB: No";
            else
                chk_PCB.Text = "PCB: Undefined";
        }

        private void cmb_Week1_SelectedValueChanged(object sender)
        {
            //ReqDateD = cmb_Week1.FirstDateOfWeek.AddDays(4);
        }

        private void txt_ReqDate_ValueChanged(object sender, EventArgs e)
        {
            Week = "W" + (cmb_Week1.WeekNumber(ReqDateD).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(ReqDateD).ToString() : cmb_Week1.WeekNumber(ReqDateD).ToString()) + "." + ReqDateD.Year.ToString();
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Revision.Text = string.Empty;
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_CustArticle.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            int NewLineId = 0;

            if (CheckRMQP != 0 && StateId != 3)
                MessageBox.Show("You have RM reserved on project and can't choose state besides accepted!");
            else
            {
                if (StateId == 3
                    && (DLL.CheckArtId(ArtId) == 0
                        || Qty == 0
                        || CustId == 0/*
                    || NotPaidAdvance == -1*/))
                    MessageBox.Show("You can't accept quotation without article or customer or quantity!");
                else
                {
                    DataTable datastages = new DataTable();
                    datastages.Columns.Add("id", typeof(int));
                    datastages.Columns.Add("osid", typeof(int));
                    datastages.Columns.Add("checked", typeof(int));

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        DataRow dr = datastages.NewRow();
                        dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);

                        if (IsCopy == -1)
                            dr["osid"] = 0;
                        else
                            dr["osid"] = Convert.ToInt32(row.Cells["cn_osid"].Value);

                        dr["checked"] = Convert.ToInt32(row.Cells["chk_checked"].Value);
                        datastages.Rows.Add(dr);

                    }

                    NewLineId = COBll.SaveQuotation(QuotId, DLL.CheckArtId(ArtId), Revision, CustArticle, Qty, UnitId, ReqDate, ExpDate, Week, StateId,
                                                UnitPrice, Comments, CustId, PCB, datastages, CurId, CustOrder, CustLine, IsSent, SentDate, EndCustomerId,
                                                Internal, Spoilage, Resale, Blocked, IsProject);
                    QuotId = NewLineId;
                    COBll.QuotId = QuotId;


                    if (COBll.CreateOrder == true)
                    {
                        //MessageBox.Show("Create order!");
                        int _newOrder = COBll.AddCOFromQuotation(NewLineId);

                        COBll.CreateOrder = false;
                        COBll.COId = _newOrder;
                        COBll.COHeadId = COBll.COHeadId1;
                        if (_newOrder != 0)
                        {
                            string emailaddresses = "";
                            string _neworder = "";
                            if (COBll.IsNewOrderForArt(COBll.COArtId, _newOrder) == false)
                            {
                                emailaddresses = DLL.EmailAddressesByType(1);
                                _neworder = "Repeat";
                            }
                            else
                            {
                                emailaddresses = DLL.EmailAddressesByType(2);
                                _neworder = "New order";
                            }

                            //if (emailaddresses != "")
                            //{ 

                            string strMessage = "Order " + COBll.COHeader;
                            strMessage = strMessage + "\r\nCustomer: " + COBll.COCustomer;
                            strMessage = strMessage + "\r\nArticle: " + DLL.Article(COBll.COArtId);
                            strMessage = strMessage + "\r\nCust. article: " + COBll.COCustArticle;
                            strMessage = strMessage + "\r\nQty: " + COBll.COQty;
                            //strMessage = strMessage + System.Environment.NewLine + "PCB: " + COBll.QPCBText;
                            strMessage = strMessage + "\r\nStages: " + COBll.COStages;
                            strMessage = strMessage + "\r\nLead week: " + COBll.COLeadWeek;//QWeek;
                            strMessage = strMessage + "\r\nComments: " + COBll.COComments;
                            strMessage = strMessage + "\r\n" + _neworder;
                            MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Order: " + COBll.COHeader, strMessage);
                            //MessageBox.Show(COBll.COHeader + " was created!");
                            //}
                        }
                    }


                    //Event
                    if (SendQuotId != null)
                        SendQuotId(this);
                }
            }
            

        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            UnitId = cmb_Articles1.UnitId;
            CustArticle = cmb_Articles1.SecName;
            Internal = cmb_Articles1.IsPF;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_ExpDate.Value = System.DateTime.Now;
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            CurId = cmb_Firms1.CurId;
        }


        #endregion

        private void txt_ExpDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        {
            txt_ExpDate.Value = txt_ExpDate.Value == null ? System.DateTime.Now : txt_ExpDate.Value;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_CustOrder.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_CustLine.Text = string.Empty;
        }

        private void txt_SentDate_DropDown(object sender, ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs e)
        {
            txt_SentDate.Value = txt_SentDate.Value == null ? System.DateTime.Now : txt_SentDate.Value;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_SentDate.Value.ToString());
        }
        
    }
    
}