using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Planning.Passport;
using Odin.Tools;
using Odin.Warehouse.StockOut.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace Odin.Planning
{
    public partial class frm_LaunchesPlanning : BaseForm
    {
        public frm_LaunchesPlanning()
        {
            InitializeComponent();
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            Week = "W" + (cmb_Week1.WeekNumber(System.DateTime.Now).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(System.DateTime.Now).ToString() : cmb_Week1.WeekNumber(System.DateTime.Now).ToString()) + "." + System.DateTime.Now.Year.ToString();

            //monthView1.SelectionStart = cmb_Week1.FirstDateOfWeek;
            //monthView1.SelectionEnd = cmb_Week1.LastDateOfWeek;

            calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));

            FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
        }

        #region Variables
        List<CalendarItem> _items = new List<CalendarItem>();
        Plan_BLL Bll = new Plan_BLL();
        frm_AddLaunch frm = null;
        class_Global glob_Class = new class_Global();
        CalendarItem contextItem = null;
        int _SelItemId = 0;
        string _SelItemText = "";
        DateTime _SelStartDate;
        DateTime _SelEndTime;

        private int SelItemId
        {
            get { return _SelItemId; }
            set { _SelItemId = value; }
        }
        private string SelItemText
        {
            get { return _SelItemText; }
            set { _SelItemText = value; }
        }
        private DateTime SelStartDate
        {
            get { return _SelStartDate; }
            set { _SelStartDate = value; }
        }
        private DateTime SelEndDate
        {
            get { return _SelEndTime; }
            set { _SelEndTime = value; }
        }

        public string Week
        {
            get { return cmb_Week1.Week; }
            set { cmb_Week1.Week = value; }
        }


        #endregion

        #region Methods

        private void PlaceItems()
        {
            foreach (CalendarItem item in _items)
            {

                if (calendar1.ViewIntersects(item))
                {
                    calendar1.Items.Add(item);
                }
            }

        }

        public void FillData(string _datefrom, string _datetill)
        {
            _items.Clear();

            var data = Plan_BLL.getLaunchesPortfolio(cmb_Firms1.FirmId, cmb_Types1.TypeId, cmb_Common1.SelectedValue, cmb_Articles1.ArticleId,
                                                        _datefrom, _datetill);

            DateTime _starttime;
            DateTime _endtime;
            string _CalendarText = "";
            string _Value = "";
            int _id = 0;

            foreach (DataRow row in data.Rows)
            {
                _starttime = Convert.ToDateTime(row["begindate"]);
                _endtime = Convert.ToDateTime(row["enddate"]);
                _id = Convert.ToInt32(row["launchid"]);

                _CalendarText = "Launch: " + row["launch"].ToString() +", group: " + row["groupname"].ToString(); 
                _CalendarText = _CalendarText + ", " + row["conforder"].ToString();// + ", Batch: " + row["batch"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Qty: " + row["qty"].ToString() + " " + row["unit"].ToString()
                        + ", Stage: " + row["stage"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Start of production: " + Convert.ToDateTime(row["prodstartdate"].ToString()).ToShortDateString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "End of production: " + Convert.ToDateTime(row["prodenddate"].ToString()).ToShortDateString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Article: " + row["article"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();

                if (row["printedby"].ToString() != "")
                    _CalendarText = _CalendarText + System.Environment.NewLine + "Printed at: " + row["printedat"].ToString() + " by " + row["printedby"].ToString();
                //_CalendarText = _CalendarText + System.Environment.NewLine + "Customer: " + row["client"].ToString();
                //_CalendarText = _CalendarText + System.Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();
                //_CalendarText = _CalendarText + System.Environment.NewLine + "Cust. order: " + row["custorder"].ToString();

                _Value = _CalendarText;
                //_Value = row["conforder"].ToString() + ", batch: " + row["batch"].ToString();
                //_Value = _Value + System.Environment.NewLine + "Customer: " + row["client"].ToString();
                //_Value = _Value + System.Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();
                //_Value = _Value + System.Environment.NewLine + "Conf. qty: " + row["confqty"].ToString() + " " + row["unit"].ToString();

                CalendarItem cal = new CalendarItem(calendar1, _starttime, _endtime, _CalendarText, _id, _Value);

                //Started
                if (Convert.ToInt32(row["iscomplected"]) == -1)
                    cal.ApplyColor(Color.White);
                else
                {
                    if (Convert.ToInt32(row["isstarted"]) == -1)
                        cal.ApplyColor(Color.LightSkyBlue);
                    else
                    {
                        //Not confirmed
                        if (row["printedby"].ToString() != "")
                            cal.ApplyColor(Color.LightGreen);
                        else
                            cal.ApplyColor(Color.LightCoral);
                    }
                }


                //Not active
                if (Convert.ToInt32(row["isactive"]) == 0)
                    cal.ApplyColor(Color.Gainsboro);
                

                _items.Add(cal);
            }

            PlaceItems();
        }

        public void FillDataLaunch(string _datefrom, string _datetill, int _launchid)
        {
            _items.Clear();

            //MessageBox.Show(_datefrom + _datetill + _launchid.ToString());

            var data = Plan_BLL.getLaunchesPortfolio(cmb_Firms1.FirmId, cmb_Types1.TypeId, cmb_Common1.SelectedValue, cmb_Articles1.ArticleId,
                                                        _datefrom, _datetill);

            DateTime _starttime;
            DateTime _endtime;
            string _CalendarText = "";
            string _Value = "";
            int _id = 0;

            foreach (DataRow row in data.Rows)
            {
                if (Convert.ToInt32(row["launchid"]) == _launchid)
                {
                    _starttime = Convert.ToDateTime(_datefrom);
                    _endtime = Convert.ToDateTime(_datetill).AddHours(23);
                    _id = Convert.ToInt32(row["launchid"]);

                    _CalendarText = "Launch: " + row["launch"].ToString() + ", group: " + row["groupname"].ToString(); 
                    _CalendarText = _CalendarText + ", " + row["conforder"].ToString();// + ", Batch: " + row["batch"].ToString();
                    _CalendarText = _CalendarText + System.Environment.NewLine + "Qty: " + row["qty"].ToString() + " " + row["unit"].ToString()
                            + ", Stage: " + row["stage"].ToString();
                    _CalendarText = _CalendarText + System.Environment.NewLine + "Start of production: " + Convert.ToDateTime(row["prodstartdate"].ToString()).ToShortDateString();
                    _CalendarText = _CalendarText + System.Environment.NewLine + "End of production: " + Convert.ToDateTime(row["prodenddate"].ToString()).ToShortDateString();
                    _CalendarText = _CalendarText + System.Environment.NewLine + "Article: " + row["article"].ToString();
                    _CalendarText = _CalendarText + System.Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();

                    if (row["printedby"].ToString() != "")
                        _CalendarText = _CalendarText + System.Environment.NewLine + "Printed at: " + row["printedat"].ToString() + " by " + row["printedby"].ToString();
                    //_CalendarText = _CalendarText + System.Environment.NewLine + "Customer: " + row["client"].ToString();
                    //_CalendarText = _CalendarText + System.Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();
                    //_CalendarText = _CalendarText + System.Environment.NewLine + "Cust. order: " + row["custorder"].ToString();

                    _Value = _CalendarText;
                    //_Value = row["conforder"].ToString() + ", batch: " + row["batch"].ToString();
                    //_Value = _Value + System.Environment.NewLine + "Customer: " + row["client"].ToString();
                    //_Value = _Value + System.Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();
                    //_Value = _Value + System.Environment.NewLine + "Conf. qty: " + row["confqty"].ToString() + " " + row["unit"].ToString();

                    CalendarItem cal = new CalendarItem(calendar1, _starttime, _endtime, _CalendarText, _id, _Value);

                    if (Convert.ToInt32(row["iscomplected"]) == -1)
                        cal.ApplyColor(Color.White);
                    else
                    {
                        if (Convert.ToInt32(row["isstarted"]) == -1)
                            cal.ApplyColor(Color.LightSkyBlue);
                        else
                        {
                            //Not confirmed
                            if (row["printedby"].ToString() != "")
                                cal.ApplyColor(Color.LightGreen);
                            else
                                cal.ApplyColor(Color.LightCoral);
                        }
                    }
                   
                    //Not active
                    if (Convert.ToInt32(row["isactive"]) == 0)
                        cal.ApplyColor(Color.Gainsboro);
                    _items.Add(cal);
                }
            }

            PlaceItems();
        }

        public void ClearFilter()
        {
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Launches1.LaunchId = 0;
        }

        private void AddLaunch(object sender)
        {
            frm.Close();
            calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
            FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
            //bwStart(bw_List);

            //if (LaunchSaved != null)
            //{
            //    LaunchSaved(this);
            //}
        }


        #endregion

        #region Controls

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
            //calendar1.DaysMode
        }

        private void monthView1_MouseUp(object sender, MouseEventArgs e)
        {
            _items.Clear();
            calendar1.Items.Clear();
            //MessageBox.Show("Go!");
            try
            {
                FillData(monthView1.SelectionStart.ToShortDateString(), monthView1.SelectionEnd.ToShortDateString());
            }
            catch { }
        }

        #region Timescale
        private void hourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixtyMinutes;
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes;
        }

        private void minToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
        }

        private void minToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FiveMinutes;
        }
        #endregion


        private void cmb_Week1_SelectedValueChanged(object sender)
        {
            //monthView1.SelectionStart = cmb_Week1.FirstDateOfWeek;
            //monthView1.SelectionEnd = cmb_Week1.LastDateOfWeek;

            calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));

            FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
        }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            //frm_DeliveryItemDets frm = new frm_DeliveryItemDets();
            //frm.ItemText = e.Item.Value;

            //frm.ShowDialog();
        }

        private void cm_Main_Opening(object sender, CancelEventArgs e)
        {
            contextItem = calendar1.ItemAt(cm_Main.Bounds.Location);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (cmb_Launches1.LaunchId == 0)
                calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
            else
                calendar1.SetViewRange(Convert.ToDateTime(cmb_Launches1.StartDate), Convert.ToDateTime(cmb_Launches1.StartDate));

            if (cmb_Launches1.LaunchId == 0)
                FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
            else
            {
                //Week = "W" + (cmb_Week1.WeekNumber(Convert.ToDateTime(cmb_Launches1.StartDate)).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(Convert.ToDateTime(cmb_Launches1.StartDate)).ToString() : cmb_Week1.WeekNumber(Convert.ToDateTime(cmb_Launches1.StartDate)).ToString()) + "." + (Convert.ToDateTime(cmb_Launches1.StartDate)).Year.ToString();
                FillDataLaunch(Convert.ToDateTime(cmb_Launches1.StartDate).ToShortDateString(), Convert.ToDateTime(cmb_Launches1.StartDate).ToShortDateString(), cmb_Launches1.LaunchId);
            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            //Selected element or calendar span

            frm = new frm_AddLaunch();

            frm.ctl_CreatLaunchDets1.FillDecNum();
            frm.ctl_CreatLaunchDets1.Mode = "new";

            frm.ctl_CreatLaunchDets1.FillDates();

            int countitem = calendar1.GetSelectedItems().Count();

            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();

                DateTime StartDate = item.StartDate;
                DateTime EndDate = item.EndDate;
                frm.ctl_CreatLaunchDets1.txt_StartDate.Value = StartDate;
                frm.ctl_CreatLaunchDets1.txt_ProdStartDate.Value = StartDate;
                frm.ctl_CreatLaunchDets1.txt_EndDate.Value = EndDate;

            }
            else
            { 
           
                CalendarTimeScaleUnit unitEnd = calendar1.SelectedElementEnd as CalendarTimeScaleUnit;
                TimeSpan duration = unitEnd != null ? unitEnd.Duration : new TimeSpan(23, 59, 59);

                DateTime dstart = calendar1.SelectedElementStart.Date;
                DateTime dend = calendar1.SelectedElementEnd.Date;

                if (dend.CompareTo(dstart) < 0)
                {
                    DateTime dtmp = dend;
                    dend = dstart;
                    dstart = dtmp;
                }

                DateTime StartDate = dstart;
                DateTime EndDate = dend.Add(duration);
                
                frm.ctl_CreatLaunchDets1.txt_StartDate.Value = dstart;
                frm.ctl_CreatLaunchDets1.txt_ProdStartDate.Value = StartDate;
                frm.ctl_CreatLaunchDets1.txt_EndDate.Value = EndDate;
            }

           

            frm.LaunchSaved += new LaunchSavedEventHandler(AddLaunch);

            frm.Show(); frm.GetKryptonFormFields();


                //int IdNote = DSBLL.AddDSItem(frm.NoteText, StartDate, EndDate);

                ////MessageBox.Show(IdNote.ToString());
                //if (IdNote != 0)
                //{                    
                //    CalendarItem cal = new CalendarItem(calendar1, StartDate, EndDate, frm.NoteText, IdNote);
                //    _items.Add(cal);
                //    calendar1.Items.Add(cal);
                //}
            
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;

                if (_id != 0
                    && glob_Class.DeleteConfirm() == true)
                {
                    MessageBox.Show(Bll.DeleteLaunch(_id));
                    calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
                    FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());

                }
            }
        }


        private void btn_PrintItem_Click(object sender, EventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;
                Bll.LaunchId = _id;

                frm_rptStockMove frm = new frm_rptStockMove();

                Bll.LaunchId = _id;

                int _isgroup = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where groupid = " + Bll.LaunchBatchId));

                if (_isgroup == 0)
                {

                    frm.HeadId = 0;
                    frm.Batch = Bll.LaunchName;
                    frm.QtyInBatch = Bll.LaunchQty;
                    frm.ConfOrder = Bll.LaunchConfOrder;
                    frm.AssPerson = cmb_Users1.UserShortName;
                    frm.Article = Bll.LaunchArticle;
                    frm.DocDate = "";
                    frm.Unit = "";
                    frm.Customer = Bll.LaunchCustomer;
                    frm.DocName = "";
                    frm.SecArticle = Bll.LaunchSecArticle;
                    frm.LaunchId = _id;
                    frm.RepType = 4;
                    frm.Stage = Bll.LaunchStage;
                    frm.MoveDate = Bll.LaunchStartDate;
                    frm.Serials = Bll.LaunchSerials;
                    frm.Comments = Bll.LaunchComments;
                }
                else
                {
                    frm.HeadId = 0;
                    frm.Batch = Bll.LaunchName;
                    frm.QtyInBatch = Bll.LaunchQty;
                    frm.ConfOrder = Bll.LaunchConfOrder;
                    frm.AssPerson = cmb_Users1.UserShortName;
                    frm.Article = Bll.LaunchArticle;
                    frm.DocDate = "";
                    frm.Unit = "";
                    frm.Customer = Bll.LaunchCustomer;
                    frm.DocName = "";
                    frm.SecArticle = Bll.LaunchSecArticle;
                    frm.LaunchId = _id;
                    frm.BatchId = Bll.LaunchBatchId;
                    frm.RepType = 8;
                    frm.Serials = Bll.LaunchSerials;
                    frm.Comments = Bll.LaunchComments;
                }
                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void mnu_Start_Click(object sender, EventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;
                Bll.LaunchId = _id;

                if (Bll.LaunchIsStarted != -1)
                {
                    if (_id != 0
                        && glob_Class.StartLaunchConfirm() == true)
                    {
                        DataTable datasource = Plan_BLL.StartLaunch(_id);
                        if (datasource.Rows.Count > 0)
                        {
                            DialogResult result = KryptonTaskDialog.Show("Launch starting warning!",
                                                               "Start is impossible!",
                                                               "Launch have missing RM quantities!",
                                                               MessageBoxIcon.Warning,
                                                               TaskDialogButtons.OK);
                            frm_LaunchStartMissings frm = new frm_LaunchStartMissings();
                            frm.data = datasource.Clone();
                            foreach (DataRow dr in datasource.Rows)
                            {
                                frm.data.ImportRow(dr);
                            }

                            frm.FillData();

                            frm.Show(); frm.GetKryptonFormFields();
                        }
                        else
                        {
                            DialogResult result = KryptonTaskDialog.Show("Launch started successfully!",
                                                               "You can print route list for batch!",
                                                               "Launch started!",
                                                               MessageBoxIcon.Information,
                                                               TaskDialogButtons.OK);
                        }

                        //calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
                        //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());


                        //try
                        //{
                        //    calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
                        //    FillData(monthView1.SelectionStart.ToShortDateString(), monthView1.SelectionEnd.ToShortDateString());
                        //}
                        //catch { }
                        if (cmb_Launches1.LaunchId == 0)
                            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
                        else
                            calendar1.SetViewRange(Convert.ToDateTime(cmb_Launches1.StartDate), Convert.ToDateTime(cmb_Launches1.StartDate));

                        if (cmb_Launches1.LaunchId == 0)
                            FillData(monthView1.SelectionStart.ToShortDateString(), monthView1.SelectionEnd.ToShortDateString());
                        else
                        {
                            FillDataLaunch(Convert.ToDateTime(cmb_Launches1.StartDate).ToShortDateString(), Convert.ToDateTime(cmb_Launches1.StartDate).ToShortDateString(), cmb_Launches1.LaunchId);
                        }

                    }
                }
                else
                {
                    DialogResult result = KryptonTaskDialog.Show("Launch starting warning!",
                                                                "Start is impossible!",
                                                                "Launch already started!",
                                                                MessageBoxIcon.Warning,
                                                                TaskDialogButtons.OK);
                }
            }
        }


        #endregion

        private void btn_RMMissings_Click(object sender, EventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;

                if (_id != 0)
                {
                    var _query = "sp_SelectLaunchRMMissings";

                    var sqlparams = new List<SqlParameter>()
                    {
                        new SqlParameter("@launchid",SqlDbType.Int) {Value = _id}
                    };

                    Template_DataGridView frm = new Template_DataGridView();

                    frm.Text = "Launch RM missings ";
                    frm.Query = _query;
                    frm.SqlParams = sqlparams;
                    frm.Show(); frm.GetKryptonFormFields();
                }
            }

        }

        private void calendar1_ItemDoubleClick_1(object sender, CalendarItemEventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;

                if (_id != 0)
                {
                    var _query = "sp_SelectLaunchRMMissings";

                    var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@launchid",SqlDbType.Int) {Value = _id}
                };

                    Template_DataGridView frm = new Template_DataGridView();

                    frm.Text = "Launch RM missings ";
                    frm.Query = _query;
                    frm.SqlParams = sqlparams;
                    frm.Show(); frm.GetKryptonFormFields();
                }
            }
        }

        private void btn_CopyText_Click(object sender, EventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            string _text = "";
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _text = item.Text;
                Clipboard.SetText(_text);
            }
        }

        public void EditClosing(object sender)
        {
            calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
            FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
        }
        private void btn_EditItem_Click(object sender, EventArgs e)
        {

            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;
                Bll.LaunchId = _id;

                frm_EditLaunchHead frm = new frm_EditLaunchHead();

                frm.Id = _id;
                frm.HeaderText = "Edit launch: " + Bll.LaunchName;
                frm.Comments = Bll.LaunchComments;
                frm.StartDate = Bll.LaunchStartDate;
                frm.ProdStartDate = Bll.LaunchProdStartDate;
                frm.EndDate = Bll.LaunchEndDate;
                frm.QtyInLaunch = Bll.LaunchQty;
                frm.oQtyInLaunch = Bll.LaunchQty;

                frm.ShowLaunchDets(_id);

                frm.EditLaunch += new EditLaunchEventHandler(EditClosing);

                frm.Show(); frm.GetKryptonFormFields();

                frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });

                //if (result == DialogResult.OK)
                //{
                //    if (frm.CheckEmpty() == true)
                //    {
                //        string _res = Bll.EditLaunch(_id, frm.StartDate, frm.ProdStartDate, frm.EndDate, frm.Comments);
                //        calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
                //        FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
                //    }
                //    else
                //    {
                //        MessageBox.Show("Please check dates!!!");
                //    }
                //}

            }
        }

        private void btn_LaunchPassport_Click(object sender, EventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;
                Bll.LaunchId = _id;
                Bll.PasLaunchId = _id;

                if (_id != 0)
                {
                    frm_rptPassportTitle frm = new frm_rptPassportTitle();
                    frm.HeaderText = "Print pasport for: " + Bll.LaunchName;
                    frm.LaunchId = _id;
                    frm.Launch = Bll.LaunchName;
                    frm.Batch = Bll.LPasBatch;
                    frm.BatchId = Bll.LaunchBatchId;
                    frm.Article = Bll.LPasArticle;
                    frm.CreatedAt = Bll.LPasCreatedAt;
                    frm.CreatedBy = System.Environment.UserName;//PlanBll.PasCreatedBy;

                    frm.ValidatedBy = Bll.LPasValidatedBy;
                    frm.BatchStages = Bll.LPasLaunchStages;
                    frm.CompanyOwner = Bll.LPasCompany;
                    frm.Address = Bll.LPasAddress;
                    frm.CustArticle = Bll.LPasCustArticle;
                    frm.COrder = Bll.LPasConfOrder;
                    frm.BatchComments = Bll.LPasComments;
                    frm.OrderComments = Bll.LPasOrderComments;
                    frm.Internal = Bll.LPasInternal.ToString();
                    frm.OrderType = Bll.LPasOrderType;
                    frm.Quantity = Bll.LPasQty.ToString();
                    frm.OrderTypeId = Bll.LPasOrderTypeId;
                    frm.RepType = 2;

                    frm.FillReport();

                    frm.Show(); frm.GetKryptonFormFields();
                }
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            string _beg;
            string _end;

            try
            {
                _beg = monthView1.SelectionStart.ToShortDateString() == "01/01/0001" || monthView1.SelectionStart.ToShortDateString() == "01.01.0001" ? cmb_Week1.FirstDateOfWeek.ToShortDateString() : monthView1.SelectionStart.ToShortDateString();
                _end = monthView1.SelectionEnd.ToShortDateString() == "01/01/0001" || monthView1.SelectionEnd.ToShortDateString() == "01.01.0001" ? cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString() : monthView1.SelectionEnd.ToShortDateString();
            }
            catch
            {
                _beg = System.DateTime.Now.ToShortDateString();
                _end = System.DateTime.Now.AddDays(5).ToShortDateString();
            }

            string query = "sp_LaunchesPortfolioTab";

            var sqlparams = new List<SqlParameter>
            {  
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _beg},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _end},
                new SqlParameter("@launchid",SqlDbType.Int){Value = cmb_Launches1.LaunchId},
                new SqlParameter("@stageid",SqlDbType.Int){Value = cmb_Common1.SelectedValue},
                new SqlParameter("@typeid",SqlDbType.Int){Value = cmb_Types1.TypeId},
                new SqlParameter("@artid",SqlDbType.Int){Value = cmb_Articles1.ArticleId}
            };

            frm_LaunchesPlanningTab frm = new frm_LaunchesPlanningTab();

            frm.Text = "Launches planning for: " + _beg /*monthView1.SelectionStart.ToShortDateString()*/ + " - " + _end/*monthView1.SelectionEnd.ToShortDateString()*/;
            frm.Query = query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
        }

        private void btn_ReserveRM_Click(object sender, EventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;
                Bll.LaunchId = _id;

                frm_LaunchRMReservation frm = new frm_LaunchRMReservation();

                frm.LaunchId = _id;
                frm.FillList(_id);
               

                frm.ShowDialog();

                frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
            }
        }

        private void mni_AutoReserve_Click(object sender, EventArgs e)
        {
            int countitem = calendar1.GetSelectedItems().Count();
            int _id = 0;
            if (countitem > 0
                && glob_Class.ReserveLaunchConfirm() == true)
            {
                CalendarItem item = calendar1.GetSelectedItems().FirstOrDefault();
                _id = item.IdItem;
                Bll.LaunchId = _id;
                if (_id != 0)
                {
                    Bll.AutoReserveLaunch(_id);
                    //calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
                    //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
                    //try
                    //{
                    //    FillData(monthView1.SelectionStart.ToShortDateString(), monthView1.SelectionEnd.ToShortDateString());
                    //}
                    //catch { }
                    if (cmb_Launches1.LaunchId == 0)
                        calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
                    //calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
                    else
                        calendar1.SetViewRange(Convert.ToDateTime(cmb_Launches1.StartDate), Convert.ToDateTime(cmb_Launches1.StartDate));

                    if (cmb_Launches1.LaunchId == 0)
                        FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
                    //FillData(monthView1.SelectionStart.ToShortDateString(), monthView1.SelectionEnd.ToShortDateString());
                    else
                    {
                        FillDataLaunch(Convert.ToDateTime(cmb_Launches1.StartDate).ToShortDateString(), Convert.ToDateTime(cmb_Launches1.StartDate).ToShortDateString(), cmb_Launches1.LaunchId);
                    }

                }
            }                
        }
    }
}
