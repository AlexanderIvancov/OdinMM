using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Odin.Global_Classes;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using Odin.Planning.Controls;
using Odin.Planning;
using System.Data.SqlClient;
using Odin.Tools;
using System.Windows.Forms.Calendar;
using Odin.Warehouse.StockOut.Reports;
using Odin.Planning.Passport;
using GanttChart;
namespace Odin.Planning
{
    public partial class frm_LaunchesPlanningG : BaseForm
    {
        TextBox txtLog;
        GanttChart.GanttChart ganttChart1;

        public frm_LaunchesPlanningG()
        {
            InitializeComponent();
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;

            Week = "W" + (cmb_Week1.WeekNumber(System.DateTime.Now).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(System.DateTime.Now).ToString() : cmb_Week1.WeekNumber(System.DateTime.Now).ToString()) + "." + System.DateTime.Now.Year.ToString();
            DateFrom = cmb_Week1.FirstDateOfWeek;
            DateTill = cmb_Week1.LastDateOfWeek.AddDays(-2);
            FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
        }

        #region Variables

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

        public DateTime DateFrom
        {
            get { return Convert.ToDateTime(txt_DateFrom.Value); }
            set { txt_DateFrom.Value = value; }
        }

        public DateTime DateTill
        {
            get { return Convert.ToDateTime(txt_DateTill.Value); }
            set { txt_DateTill.Value = value; }
        }
        #endregion

        #region Methods

        public void FillData(string _datefrom, string _datetill)
        {
            //_items.Clear();
            tableLayoutPanel1.Controls.Clear();

            txtLog = new TextBox();
            txtLog.Dock = DockStyle.Fill;
            txtLog.Multiline = true;
            txtLog.Enabled = false;
            txtLog.ScrollBars = ScrollBars.Horizontal;
            tableLayoutPanel1.Controls.Add(txtLog, 0, 1);

            // Gantt Chart
            ganttChart1 = new GanttChart.GanttChart();
            ganttChart1.AllowChange = false;
            ganttChart1.Dock = DockStyle.Fill;
            ganttChart1.AllowManualEditBar = false;
            ganttChart1.FromDate = new DateTime(Convert.ToDateTime(_datefrom).Year, Convert.ToDateTime(_datefrom).Month, Convert.ToDateTime(_datefrom).Day, 0, 0, 0);
            ganttChart1.ToDate = new DateTime(Convert.ToDateTime(_datetill).Year, Convert.ToDateTime(_datetill).Month, Convert.ToDateTime(_datetill).Day, 23, 59, 59);
            tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);
            
            ganttChart1.MouseMove += new MouseEventHandler(ganttChart1.GanttChart_MouseMove);
            ganttChart1.MouseMove += new MouseEventHandler(GanttChart1_MouseMove);
            ganttChart1.MouseDragged += new MouseEventHandler(ganttChart1.GanttChart_MouseDragged);
            ganttChart1.MouseLeave += new EventHandler(ganttChart1.GanttChart_MouseLeave);
            ganttChart1.MouseDown += new MouseEventHandler(ganttChart1.GanttChart_MouseDown);
            //ganttChart1.BarChanged += new EventHandler(ganttChart1_BarChanged);
            ganttChart1.ContextMenuStrip = cm_Main;

            List<BarInformation> lst1 = new List<BarInformation>();

            var data = Plan_BLL.getLaunchesPortfolioGantt(cmb_Firms1.FirmId, cmb_Types1.TypeId, cmb_Common1.SelectedValue, cmb_Articles1.ArticleId,
                                                        _datefrom, _datetill);

            DateTime _starttime;
            DateTime _endtime;
            string _CalendarText = "";
            string _Value = "";
            int _id = 0;
            Color color1;
            int _i = 0;

            foreach (DataRow row in data.Rows)
            {
                _starttime = Convert.ToDateTime(row["startdate"]) < Convert.ToDateTime(_datefrom) ? Convert.ToDateTime(_datefrom) : Convert.ToDateTime(row["startdate"]);
                _endtime = Convert.ToDateTime(row["enddate"]) > Convert.ToDateTime(_datetill) ? Convert.ToDateTime(_datetill) : Convert.ToDateTime(row["enddate"]);
                _id = Convert.ToInt32(row["launchid"]);

                _CalendarText = "Launch: " + row["launch"].ToString() + ", group: " + row["groupname"].ToString();
                _CalendarText = _CalendarText + ", " + row["conforder"].ToString();// + ", Batch: " + row["batch"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Qty: " + row["qty"].ToString() + " " + row["unit"].ToString()
                        + ", Stage: " + row["stage"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Start of production: " + Convert.ToDateTime(row["prodstartdate"].ToString()).ToShortDateString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "End of production: " + Convert.ToDateTime(row["enddate"].ToString()).ToShortDateString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Article: " + row["article"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();
                
                if (row["printedby"].ToString() != "")
                    _CalendarText = _CalendarText + System.Environment.NewLine + "Printed at: " + row["printedat"].ToString() + " by " + row["printedby"].ToString();

                if (row["additcomments"].ToString() != "")
                    _CalendarText = _CalendarText + System.Environment.NewLine + row["additcomments"].ToString();

                _Value = _CalendarText;

                //Started
                if (Convert.ToInt32(row["iscomplected"]) == -1)
                    color1 = Color.White;
                else
                {
                    if (Convert.ToInt32(row["isstarted"]) == -1)
                        color1 = Color.LightSkyBlue;
                    else
                    {
                        //Printed
                        if (row["printedby"].ToString() != "")
                            color1 = Color.LightGreen;
                        else
                            color1 = Color.LightCoral;
                    }
                }
                //if (Convert.ToInt32(row["isstarted"]) == -1)
                //{   
                //    //Complected
                //    if (Convert.ToInt32(row["iscomplected"]) == -1)
                //        color1 = Color.White;
                //    else
                //    {
                //        //Printed
                //        if (row["printedby"].ToString() != "")
                //            color1 = Color.LightGreen;
                //        else
                //            color1 = Color.LightSkyBlue;
                //    }
                //}
                //else
                //{
                //    if (Convert.ToInt32(row["iscomplected"]) == -1)
                //        color1 = Color.White;
                //    else
                //    {
                //        //Printed
                //        if (row["printedby"].ToString() != "")
                //            color1 = Color.LightGreen;
                //        else
                //            color1 = Color.LightCoral;
                //    }
                    
                //}

                if (Convert.ToInt32(row["isactive"]) == 0)
                    color1 = Color.Gainsboro;


                lst1.Add(new BarInformation(row["launch"].ToString(), new DateTime(_starttime.Year, _starttime.Month, _starttime.Day, 0, 0, 0), 
                                                                        new DateTime(_endtime.Year, _endtime.Month, _endtime.Day, 23, 59, 59), 
                                                                        color1, Color.White, _i++, _id, _CalendarText, 
                                                                        row["launch"].ToString() + "; " + row["article"].ToString() + "; " + row["custarticle"].ToString()));
            }
            foreach (BarInformation bar in lst1)
            {
                ganttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index, bar.BarText);
            }
        }

        public void FillDataLaunch(string _datefrom, string _datetill, int _launchid)
        {
            //_items.Clear();
            tableLayoutPanel1.Controls.Clear();

            txtLog = new TextBox();
            txtLog.Dock = DockStyle.Fill;
            txtLog.Multiline = true;
            txtLog.Enabled = false;
            txtLog.ScrollBars = ScrollBars.Horizontal;
            tableLayoutPanel1.Controls.Add(txtLog, 0, 1);

            // Gantt Chart
            ganttChart1 = new GanttChart.GanttChart();
            ganttChart1.AllowChange = false;
            ganttChart1.Dock = DockStyle.Fill;
            ganttChart1.AllowManualEditBar = false;
            ganttChart1.FromDate = new DateTime(Convert.ToDateTime(_datefrom).Year, Convert.ToDateTime(_datefrom).Month, Convert.ToDateTime(_datefrom).Day, 0, 0, 0);
            ganttChart1.ToDate = new DateTime(Convert.ToDateTime(_datetill).Year, Convert.ToDateTime(_datetill).Month, Convert.ToDateTime(_datetill).Day, 23, 59, 59);
            tableLayoutPanel1.Controls.Add(ganttChart1, 0, 0);

            ganttChart1.MouseMove += new MouseEventHandler(ganttChart1.GanttChart_MouseMove);
            ganttChart1.MouseMove += new MouseEventHandler(GanttChart1_MouseMove);
            ganttChart1.MouseDragged += new MouseEventHandler(ganttChart1.GanttChart_MouseDragged);
            ganttChart1.MouseLeave += new EventHandler(ganttChart1.GanttChart_MouseLeave);
            ganttChart1.MouseDown += new MouseEventHandler(ganttChart1.GanttChart_MouseDown);
            //ganttChart1.BarChanged += new EventHandler(ganttChart1_BarChanged);
            ganttChart1.ContextMenuStrip = cm_Main;

            List<BarInformation> lst1 = new List<BarInformation>();

            var data = Plan_BLL.getLaunchHeadDet(cmb_Launches1.LaunchId);

            DateTime _starttime;
            DateTime _endtime;
            string _CalendarText = "";
            string _Value = "";
            int _id = 0;
            Color color1;
            int _i = 0;

            foreach (DataRow row in data.Rows)
            {
                _starttime = Convert.ToDateTime(row["startdate"]);
                _endtime = Convert.ToDateTime(row["enddate"]);
                _id = Convert.ToInt32(row["launchid"]);

                _CalendarText = "Launch: " + row["launch"].ToString() + ", group: " + row["groupname"].ToString(); 
                _CalendarText = _CalendarText + ", " + row["conforder"].ToString();// + ", Batch: " + row["batch"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Qty: " + row["qty"].ToString() + " " + row["unit"].ToString()
                        + ", Stage: " + row["stage"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Start of production: " + Convert.ToDateTime(row["prodstartdate"].ToString()).ToShortDateString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "End of production: " + Convert.ToDateTime(row["enddate"].ToString()).ToShortDateString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Article: " + row["article"].ToString();
                _CalendarText = _CalendarText + System.Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();

                if (row["printedby"].ToString() != "")
                    _CalendarText = _CalendarText + System.Environment.NewLine + "Printed at: " + row["printedat"].ToString() + " by " + row["printedby"].ToString();
                if (row["additcomments"].ToString() != "")
                    _CalendarText = _CalendarText + System.Environment.NewLine + row["additcomments"].ToString();

                _Value = _CalendarText;

                //Started
                if (Convert.ToInt32(row["iscomplected"]) == -1)
                    color1 = Color.White;
                else
                {
                    if (Convert.ToInt32(row["isstarted"]) == -1)
                        color1 = Color.LightSkyBlue;
                    else
                    {
                        //Printed
                        if (row["printedby"].ToString() != "")
                            color1 = Color.LightGreen;
                        else
                            color1 = Color.LightCoral;
                    }
                }
                //if (Convert.ToInt32(row["isstarted"]) == -1)
                //{
                //    if (Convert.ToInt32(row["iscomplected"]) == -1)
                //        color1 = Color.White;
                //    else
                //    {
                //        //Printed
                //        if (row["printedby"].ToString() != "")
                //            color1 = Color.LightGreen;
                //        else
                //            color1 = Color.LightSkyBlue;
                //    }
                //}
                //else
                //{
                //    if (Convert.ToInt32(row["iscomplected"]) == -1)
                //        color1 = Color.White;
                //    else
                //    {
                //        //Printed
                //        if (row["printedby"].ToString() != "")
                //            color1 = Color.LightGreen;
                //        else
                //            color1 = Color.LightCoral;
                //    }
                //}

                if (Convert.ToInt32(row["isactive"]) == 0)
                    color1 = Color.Gainsboro;



                lst1.Add(new BarInformation(row["launch"].ToString(), new DateTime(_starttime.Year, _starttime.Month, _starttime.Day, 0, 0, 0),
                                                                      new DateTime(_endtime.Year, _endtime.Month, _endtime.Day, 23, 59, 59),
                                                                      color1, Color.White, _i++, _id, _CalendarText, 
                                                                      row["launch"].ToString() + "; " + row["article"].ToString() + "; " + row["custarticle"].ToString()));
            }
            foreach (BarInformation bar in lst1)
            {
                ganttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index, bar.BarText);
            }
        }

        private void GanttChart1_MouseMove(Object sender, MouseEventArgs e)
        {
            List<string> toolTipText = new List<string>();
            string toolTipTextBody = "";
            Color color1 = Color.AntiqueWhite;

            if (ganttChart1.MouseOverRowText != null && ganttChart1.MouseOverRowText != "" && ganttChart1.MouseOverRowValue != null)
            {
                object obj = ganttChart1.MouseOverRowValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseOverRowValue;
                    toolTipTextBody = val.Content;
                    toolTipText.Add(val.Content);
                    color1 = val.Color;
                }
                else if (typ.ToLower() == "string")
                {
                    toolTipText.Add(ganttChart1.MouseOverRowValue.ToString());
                   
                }
            }
            else
            {
                toolTipTextBody = "";
                toolTipText.Add("");
            }

            ganttChart1.ToolTipTextTitle = ganttChart1.MouseOverRowText;
            ganttChart1.ToolTipText = toolTipText;
            ganttChart1.ToolTipTextBody = toolTipTextBody;
            Brush brush = new SolidBrush(color1);

            ganttChart1.ToolTypeBrush = brush;
        }

        private void ganttChart1_BarChanged(object sender, EventArgs e)
        {
            BarInformation b = sender as BarInformation;
            txtLog.Text += String.Format("\r\n{0} has changed", b.RowText);
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
            FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString());
            //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
           
        }

        public void EditClosing(object sender)
        {
            //frm.Close();
            //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
            FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString());
        }

        #endregion

        private void monthView1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                DateFrom = monthView1.SelectionStart;
                DateTill = monthView1.SelectionEnd;
                FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString());

                //FillData(monthView1.SelectionStart.ToShortDateString(), monthView1.SelectionEnd.ToShortDateString());
            }
            catch { }
        }

        private void cmb_Week1_SelectedValueChanged(object sender)
        {
            DateFrom = cmb_Week1.FirstDateOfWeek;
            DateTill = cmb_Week1.LastDateOfWeek.AddDays(-2);
            FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString());
            //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            string _beg;
            string _end;

            //try
            //{
            //    _beg = monthView1.SelectionStart.ToShortDateString() == "01/01/0001" || monthView1.SelectionStart.ToShortDateString() == "01.01.0001" ? cmb_Week1.FirstDateOfWeek.ToShortDateString() : monthView1.SelectionStart.ToShortDateString();
            //    _end = monthView1.SelectionEnd.ToShortDateString() == "01/01/0001" || monthView1.SelectionEnd.ToShortDateString() == "01.01.0001" ? cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString() : monthView1.SelectionEnd.ToShortDateString();
            //}
            //catch
            //{
            //    _beg = System.DateTime.Now.ToShortDateString();
            //    _end = System.DateTime.Now.AddDays(-2).ToShortDateString();
            //}
            _beg = DateFrom.ToShortDateString();
            _end = DateTill.ToShortDateString();
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
            frm.Show();
            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (cmb_Launches1.LaunchId == 0)
                FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString());
            //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
            else
            {
                //cmb_Week1.Week = DAL_Functions.Wee
                DateFrom = Convert.ToDateTime(cmb_Launches1.StartDate);
                DateTill = Convert.ToDateTime(cmb_Launches1.StartDate);
                FillDataLaunch(DateFrom.ToShortDateString(), DateTill.ToShortDateString(), cmb_Launches1.LaunchId);
            }
            //     FillDataLaunch(Convert.ToDateTime(cmb_Launches1.StartDate).ToShortDateString(), Convert.ToDateTime(cmb_Launches1.EndDate).ToShortDateString(), cmb_Launches1.LaunchId);
        }

        private void cm_Main_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            frm = new frm_AddLaunch();

            frm.ctl_CreatLaunchDets1.FillDecNum();
            frm.ctl_CreatLaunchDets1.Mode = "new";

            frm.ctl_CreatLaunchDets1.FillDates();

            DateTime dstart = ganttChart1.MouseOverColumnDate;
            //DateTime dend = calendar1.SelectedElementEnd.Date;

            //if (dend.CompareTo(dstart) < 0)
            //{
            //    DateTime dtmp = dend;
            //    dend = dstart;
            //    dstart = dtmp;
            //}

            //DateTime StartDate = dstart;
            TimeSpan duration = new TimeSpan(23, 59, 59);
            DateTime EndDate = dstart.Add(duration);

            frm.ctl_CreatLaunchDets1.txt_StartDate.Value = dstart;
            frm.ctl_CreatLaunchDets1.txt_ProdStartDate.Value = dstart;
            frm.ctl_CreatLaunchDets1.txt_EndDate.Value = EndDate;
            



            frm.LaunchSaved += new LaunchSavedEventHandler(AddLaunch);

            frm.Show();

        }

        private void btn_EditItem_Click(object sender, EventArgs e)
        {

            int _id = 0;

            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }

            if (_id != 0)
            {
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
                frm.Show();
                frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
            }
        }

        private void btn_RMMissings_Click(object sender, EventArgs e)
        {
            
            int _id = 0;

            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }


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
                frm.Show();
            }
        }

        private void mnu_Start_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }

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

                        frm.Show();
                    }
                    else
                    {
                        DialogResult result = KryptonTaskDialog.Show("Launch started successfully!",
                                                           "You can print route list for batch!",
                                                           "Launch started!",
                                                           MessageBoxIcon.Information,
                                                           TaskDialogButtons.OK);
                    }
                    FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString());
                    //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(12).ToShortDateString());

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

        private void mni_AutoReserve_Click(object sender, EventArgs e)
        {
            int _id = 0;
            
            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }

            if (_id != 0
                && glob_Class.ReserveLaunchConfirm() == true)
            {
                Bll.LaunchId = _id;
                if (_id != 0)
                {
                    Bll.AutoReserveLaunch(_id);
                    FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString()/*cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString()*/);
                }
            }
        }

        private void btn_ReserveRM_Click(object sender, EventArgs e)
        {

            int _id = 0;
            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }

            if (_id != 0)
            {
                Bll.LaunchId = _id;

                frm_LaunchRMReservation frm = new frm_LaunchRMReservation();

                frm.LaunchId = _id;
                frm.FillList(_id);


                frm.ShowDialog();

                frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
            }
        }

        private void btn_CopyText_Click(object sender, EventArgs e)
        {
            string _text = "";
            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _text = val.Content;

                }
                else if (typ.ToLower() == "string")
                {
                    _text = "";
                }
            }
            catch { _text = ""; }

            Clipboard.SetText(_text);
            
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }


            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
             {
                MessageBox.Show(Bll.DeleteLaunch(_id));
                FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString());
                //FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());

            }
        
        }

        private void btn_PrintItem_Click(object sender, EventArgs e)
        {
            int _id = 0;
           
            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }

            if (_id != 0)
            {
                
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
                }

                frm.Show();
            }
        }

        private void btn_LaunchPassport_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }

            if (_id != 0)
            {
                    Bll.LaunchId = _id;
                    Bll.PasLaunchId = _id;


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

                    frm.Show();
            }
                        
        }

        private void btn_NotStarted_Click(object sender, EventArgs e)
        {
            //string _beg;
            //string _end;

            //try
            //{
            //    _beg = monthView1.SelectionStart.ToShortDateString() == "01/01/0001" || monthView1.SelectionStart.ToShortDateString() == "01.01.0001" ? cmb_Week1.FirstDateOfWeek.ToShortDateString() : monthView1.SelectionStart.ToShortDateString();
            //    _end = monthView1.SelectionEnd.ToShortDateString() == "01/01/0001" || monthView1.SelectionEnd.ToShortDateString() == "01.01.0001" ? cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString() : monthView1.SelectionEnd.ToShortDateString();
            //}
            //catch
            //{
            //    _beg = System.DateTime.Now.ToShortDateString();
            //    _end = System.DateTime.Now.AddDays(-2).ToShortDateString();
            //}

            string query = "sp_LaunchesPortfolioTabNotStarted";

            var sqlparams = new List<SqlParameter>
            {
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = DateFrom},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = DateTill},
                //new SqlParameter("@launchid",SqlDbType.Int){Value = cmb_Launches1.LaunchId},


            };

            frm_LaunchesPlanningTab frm = new frm_LaunchesPlanningTab();

            frm.Text = "Not started launches ";
            frm.Query = query;
            frm.SqlParams = sqlparams;
            frm.Show();
            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
        }

        private void btn_InsertComment_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                object obj = ganttChart1.MouseClickValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart1.MouseClickValue;
                    _id = val.Id;

                }
                else if (typ.ToLower() == "string")
                {
                    _id = 0;
                }
            }
            catch { _id = 0; }

            if (_id != 0)
            {
                Bll.LaunchId = _id;

                frm_cmbText frm = new frm_cmbText();
                frm.HeaderText = "Insert comments for " + Bll.LaunchName;
                frm.LabelText = "Comments:";
                frm.FormText = Bll.LaunchAdditComments;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                   Bll.AddAdditComments(_id, frm.FormText);
                   FillData(DateFrom.ToShortDateString(), DateTill.ToShortDateString());
                }
            }
        }

        private void btn_GroupLaunches_Click(object sender, EventArgs e)
        {
            frm_LaunchGrouping frm = new frm_LaunchGrouping();

            frm.Show();
        }
    }
}
