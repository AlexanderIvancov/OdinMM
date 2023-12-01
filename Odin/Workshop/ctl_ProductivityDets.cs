using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.Workshop
{
    public partial class ctl_ProductivityDets : UserControl
    {
        public ctl_ProductivityDets()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ProductivityHistory.xls", this.Name);
        }



        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Processing_BLL ProcBll = new Processing_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();

        public int ControlWidth = 250;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int StageId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }

        public string DateFrom
        { get; set; }

        public string DateTill
        { get; set; }

        #endregion

        #region Methods

        public void FillHistory()
        {
            //var data = Processing_BLL.getProductivityIndicatorDets(StageId, txt_Date.Value == null ? "" : txt_Date.Value.ToString().Trim(),
            //                                                         txt_Date.Value == null ? "" : txt_Date.Value.ToString().Trim());
            var data = Processing_BLL.getProductivityIndicatorDets(StageId, cmb_Week1.FirstDateOfWeek.ToShortDateString(),
                                                                     cmb_Week1.LastDateOfWeek.ToShortDateString());
            //var data = Processing_BLL.getProductivityIndicatorDets(StageId, DateFrom,
            //                                                         DateTill);
            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                RecalcQty();
                SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            ShowCapacityWeeks();
        }

        public void RecalcQty()
        {
            double _qty = 0;
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _qty = _qty + Convert.ToDouble(row.Cells["cn_qty"].Value);
            }
            txt_Qty.Text = _qty.ToString();
        }

        public void ShowCapacity()
        {
            double _capa = 0;
            var param = new List<SqlParameter>
            {
                new SqlParameter("@stageid", SqlDbType.Int) {Value = StageId},
                new SqlParameter("@date", SqlDbType.NVarChar) {Value = txt_Date.Value == null ? "''" : txt_Date.Value.ToString().Trim()}
            };

            try {
                _capa = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select isnull(qty * 8, 0) as capahours from prod_capacity cp where cp.stageid = @stageid and cp.date = convert(datetime, nullif(@date, ''))", param.ToArray()));
            }
            catch { }

            txt_Capacity.Text = _capa.ToString();
        }

        public void ShowCapacityWeeks()
        {
            double _capa = 0;
            var param = new List<SqlParameter>
            {
                new SqlParameter("@stageid", SqlDbType.Int) {Value = StageId},
                new SqlParameter("@datefrom", SqlDbType.NVarChar) { Value = cmb_Week1.FirstDateOfWeek.ToShortDateString() },
                new SqlParameter("@datetill", SqlDbType.NVarChar) { Value = cmb_Week1.LastDateOfWeek.ToShortDateString()}
            };

            try
            {
                _capa = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select sum(isnull(cp.qty * 8, 0)) as capahours " + 
                                " from (select cs.stageid, " +
                                "               cs.date, " +
                                "               sum(cs.qty) as qty " +
                                " from prod_capacityshifts cs " +
                                " group by cs.stageid, cs.date) cp where cp.stageid = @stageid " +
                                                                " and cp.date >= convert(datetime, nullif(@datefrom, '')) " +
                                                                " and cp.date <= convert(datetime, nullif(@datetill, ''))  ", param.ToArray()));
            }
            catch { }

            txt_Capacity.Text = _capa.ToString();
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_teortime"].Value) == 0)
                    row.Cells["cn_teortime"].Style.BackColor = Color.LightPink;
            }
        }

        #endregion

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
