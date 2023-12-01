using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Week
{
    public delegate void WeekEventHandler(object sender);

    public partial class cmb_Week : UserControl
    {
        public cmb_Week()
        {
            InitializeComponent();
        }


        public event WeekEventHandler SelectedValueChanged;

        #region Variables

        DayOfWeek _currentDay;

        public DateTime FirstDateOfWeek
        {
            get;
            set;
        }

        public DateTime LastDateOfWeek
        {
            get;
            set;
        }

        public int weekNumber
        {
            get;
            set;
        }

        public string Week
        {
            get { return txt_Week.Text; }
            set { txt_Week.Text = value; }
        }
        #endregion

        #region Methods

        public int WeekNumber(DateTime fromDate)
        {
            // Получаем 1 января указанного нами года
            DateTime startOfYear = fromDate.AddDays(-fromDate.Day + 1).AddMonths(-fromDate.Month + 1);
            // Получение 31 декабря указанного нами года
            DateTime endOfYear = startOfYear.AddYears(1).AddDays(-1);
            //Согласно ISO 8601 четверг считается 
            //четвёртым днём недели, а также днём, 
            //который определяет нумерацию недель: 
            //первая неделя года определяется как неделя, 
            //содержащая первый четверг года, и так далее.
            //Вносим соответствующие корректировки
            int[] iso8601Correction = { 6, 7, 8, 9, 10, 4, 5 };
            int nds = fromDate.Subtract(startOfYear).Days +
            iso8601Correction[(int)startOfYear.DayOfWeek];
            int wk = nds / 7;
            switch (wk)
            {
                case 0:
                    // Возвращаем номер недели от 31 декабря предыдущего года
                    return WeekNumber(startOfYear.AddDays(-1));
                case 53:
                    // Если 31 декабря выпадает до четверга 1 недели следующего года                    
                    return endOfYear.DayOfWeek < DayOfWeek.Thursday ? 1 : wk;
                default: return wk;
            }
        }


        public void ValueChanged()
        {
            SelectedValueChanged?.Invoke(this);
        }

        public void DatesOfWeek(DateTime date)
        {
            _currentDay = date.DayOfWeek;

            //return (int)_currentDay;

            FirstDateOfWeek = date;//;.AddDays(-1 * (int)_currentDay);
            LastDateOfWeek = date.AddDays(7 - (int)_currentDay);

        }

        public DateTime DateOfWeek(int week, int year)
        {
            DateTime _res;

            //_res = System.DateTime.Now;

            var startDate = new DateTime(year, 1, 4); // вычисляем опорную дату — 4 января текущего года (почему, читать тут http://planetcalc.ru/1252/)


            int offsetToFirstMonday = startDate.DayOfWeek == DayOfWeek.Sunday ? 6 : ((int)startDate.DayOfWeek) - 1; // смещение к понедельнику первой недели текущего года, в днях
            int offsetToDemandedMonday = -offsetToFirstMonday + 7 * (week - 1); // смещение к искомому понедельнику, в днях
            _res = startDate + new TimeSpan(offsetToDemandedMonday, 0, 0, 0);


            return _res;
        }

        #endregion

        #region Controls


        private void btn_Next_Click(object sender, EventArgs e)
        {
            int _week = 0;
            int _year = 0;
            try
            {
                _week = Convert.ToInt32(txt_Week.Text.Substring(1, 2));
                _year = Convert.ToInt32(txt_Week.Text.Substring(4, 4));
            }
            catch
            {
                _week = WeekNumber(System.DateTime.Now);
                _year = System.DateTime.Now.Year;
            }

            //Vichisljaem kolichectvo nedel' v godu
            int _weekinyear = 0;
            // Получаем 1 января указанного нами года
            DateTime startOfYear = Convert.ToDateTime("01/01/" + _year.ToString());
            // Получение 31 декабря указанного нами года
            DateTime endOfYear = startOfYear.AddYears(1).AddDays(-1);
            _weekinyear = endOfYear.DayOfWeek < DayOfWeek.Thursday ? 52 : 53;
            //Vichisljaem sledujuschuju nedelju

            if (_week < _weekinyear)
                _week++;
            else
            {
                _week = 1;
                _year++;
            }
            string _strweek = _week < 10 ? "0" + _week.ToString() : _week.ToString();
            Week = "W" + _strweek + "/" + _year.ToString();

            DateTime _date = DateOfWeek(_week, _year);

            //MessageBox.Show(_date.ToShortDateString());

            DatesOfWeek(_date);

            SelectedValueChanged?.Invoke(this);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            int _week = 0;
            int _year = 0;
            try
            {
                _week = Convert.ToInt32(txt_Week.Text.Substring(1, 2));
                _year = Convert.ToInt32(txt_Week.Text.Substring(4, 4));
            }
            catch
            {
                _week = WeekNumber(System.DateTime.Now);
                _year = System.DateTime.Now.Year;
            }

            //Vichisljaem kolichectvo nedel' v godu
            int _weekinyear = 0;
            // Получаем 1 января предыдущего года
            DateTime startOfYear = Convert.ToDateTime("01/01/" + (_year - 1).ToString());
            // Получение 31 декабря указанного нами года
            DateTime endOfYear = startOfYear.AddYears(1).AddDays(-1);
            _weekinyear = endOfYear.DayOfWeek < DayOfWeek.Thursday ? 52 : 53;

            if (_week == 1)
            {
                _week = _weekinyear;
                _year = _year - 1;
            }
            else
            { _week = _week - 1; }

            string _strweek = _week < 10 ? "0" + _week.ToString() : _week.ToString();
            Week = "W" + _strweek + "/" + _year.ToString();

            DateTime _date = DateOfWeek(_week, _year);

            DatesOfWeek(_date);

            SelectedValueChanged?.Invoke(this);
        }

        private void txt_Week_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int _week = Convert.ToInt32(txt_Week.Text.Substring(1, 2));
                int _year = Convert.ToInt32(txt_Week.Text.Substring(4, 4));

                DateTime _date = DateOfWeek(_week, _year);

                DatesOfWeek(_date);

            }
            catch
            {
                DatesOfWeek(System.DateTime.Now);
            }

            SelectedValueChanged?.Invoke(this);
        }

        #endregion
    }
}
