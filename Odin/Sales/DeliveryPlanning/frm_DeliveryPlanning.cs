using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace Odin.Sales.DeliveryPlanning
{
    public partial class frm_DeliveryPlanning : BaseForm
    {
        public frm_DeliveryPlanning()
        {
            InitializeComponent();
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;
            
            Week = "W" + (cmb_Week1.WeekNumber(DateTime.Now).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(DateTime.Now).ToString() : cmb_Week1.WeekNumber(DateTime.Now).ToString()) + "." + DateTime.Now.Year.ToString();

            //monthView1.SelectionStart = cmb_Week1.FirstDateOfWeek;
            //monthView1.SelectionEnd = cmb_Week1.LastDateOfWeek;

            calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));

            FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
        }

        #region Variables
        List<CalendarItem> _items = new List<CalendarItem>();
        CO_BLL Bll = new CO_BLL();
                
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
                if (calendar1.ViewIntersects(item))
                    calendar1.Items.Add(item);
        }

        public void FillData(string _datefrom,  string _datetill)
        {
            _items.Clear();

            var data = (DataTable)Helper.getSP("sp_COConfirmationsPortfolio", cmb_Firms1.FirmId, cmb_Types1.TypeId, cmb_Articles1.ArticleId, 
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
                _id = Convert.ToInt32(row["coid"]);
                _CalendarText = row["conforder"].ToString() + ", batch: " + row["batch"].ToString();
                _CalendarText = _CalendarText + Environment.NewLine + "Customer: " + row["client"].ToString();
                _CalendarText = _CalendarText + Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();
                _CalendarText = _CalendarText + Environment.NewLine + "Article: " + row["article"].ToString();
                _CalendarText = _CalendarText + Environment.NewLine + "Cust. order: " + row["custorder"].ToString();
                _CalendarText = _CalendarText + Environment.NewLine + "Conf. qty: " + row["confqty"].ToString() + " " + row["unit"].ToString();
                _CalendarText = _CalendarText + Environment.NewLine + "Deliv. qty: " + row["delivqty"].ToString() + " " + row["unit"].ToString();

                _Value = row["conforder"].ToString() + ", batch: " + row["batch"].ToString();
                _Value = _Value + Environment.NewLine + "Customer: " + row["client"].ToString();
                _Value = _Value + Environment.NewLine + "Cust. article: " + row["custarticle"].ToString();
                _Value = _Value + Environment.NewLine + "Conf. qty: " + row["confqty"].ToString() + " " + row["unit"].ToString();

                CalendarItem cal = new CalendarItem(calendar1, _starttime, _endtime, _Value, _id, _CalendarText);

                //Not confirmed
                if (Convert.ToInt32(row["confirmed"]) == 0)
                    cal.ApplyColor(Color.Yellow);

                //Delivered
                if (Convert.ToDouble(row["confqty"]) <= Convert.ToDouble(row["delivqty"])
                    && Convert.ToInt32(row["confirmed"]) != 0)
                    cal.ApplyColor(Color.FromArgb(192, 255, 192));

                //Delivered, but not confirmed
                if (Convert.ToDouble(row["confqty"]) == 0
                    && Convert.ToDouble(row["delivqty"]) > 0)
                    cal.ApplyColor(Color.LightCoral);

                _items.Add(cal);
            }

            PlaceItems();
        }

        public void ClearFilter()
        {
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Firms1.FirmId = 0;
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

        private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e) { }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            frm_DeliveryItemDets frm = new frm_DeliveryItemDets();
            frm.ItemText = e.Item.Value;

            frm.ShowDialog();
        }

        private void cm_Main_Opening(object sender, CancelEventArgs e)
        {
            contextItem = calendar1.ItemAt(cm_Main.Bounds.Location);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            calendar1.SetViewRange(cmb_Week1.FirstDateOfWeek, cmb_Week1.LastDateOfWeek.AddDays(-2));
            FillData(cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString());
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(monthView1.SelectionStart.ToString());

            string _beg;
            string _end;

            try {
                _beg = monthView1.SelectionStart.ToShortDateString() == "01/01/0001" || monthView1.SelectionStart.ToShortDateString() =="01.01.0001" ? cmb_Week1.FirstDateOfWeek.ToShortDateString() : monthView1.SelectionStart.ToShortDateString();
                _end = monthView1.SelectionEnd.ToShortDateString() == "01/01/0001" || monthView1.SelectionEnd.ToShortDateString() == "01.01.0001" ? cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString() : monthView1.SelectionEnd.ToShortDateString();
            }
            catch {
                _beg = DateTime.Now.ToShortDateString();
                _end = DateTime.Now.AddDays(5).ToShortDateString();
            }

            //cmb_Week1.FirstDateOfWeek.ToShortDateString(), cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString()

            string query = "sp_COConfirmationsPortfolio";

            var sqlparams = new List<SqlParameter>
            {

                new SqlParameter("@custid",SqlDbType.Int){Value = cmb_Firms1.FirmId },
                new SqlParameter("@typeid",SqlDbType.Int){Value = cmb_Types1.TypeId },
                new SqlParameter("@artid",SqlDbType.Int){Value = cmb_Articles1.ArticleId },
                new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = _beg/*monthView1.SelectionStart.ToShortDateString()*/},
                new SqlParameter("@datetill",SqlDbType.NVarChar){Value = _end/*monthView1.SelectionEnd.ToShortDateString()*/}
                //new SqlParameter("@datefrom",SqlDbType.NVarChar){Value = cmb_Week1.FirstDateOfWeek.ToShortDateString()},
                //new SqlParameter("@datetill",SqlDbType.NVarChar){Value = cmb_Week1.LastDateOfWeek.AddDays(-2).ToShortDateString()}

            };

            frm_DeliveryPlanningTab frm = new frm_DeliveryPlanningTab();

            frm.Text = "Delivery planning for: " + _beg /*monthView1.SelectionStart.ToShortDateString()*/ + " - " + _end/*monthView1.SelectionEnd.ToShortDateString()*/;
            frm.Query = query;
            frm.SqlParams = sqlparams;
            frm.Show(); frm.GetKryptonFormFields();
        }
    }
}