using System;
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
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.Planning
{
    public partial class frm_ProductionPlanning : BaseForm
    {
        public frm_ProductionPlanning()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ProductionPlanning.xls", this.Name);
            //ED1 = new ExportData(this.gv_List, "ProjectPlanning.xls", this.Name);
            wait = new ProgressForm(this);
        }

        #region Variables

        ProgressForm wait;

        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        ExportData ED1;
        public ToolTip toolTip1;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int RowIndexP = 0;
        public int ColumnIndexP = 0;
        public string ColumnNameP = "";
        public string CellValueP = "";
        public DataTable data;

        public string Week
        {
            get { return cmb_Week1.Week; }
            set { cmb_Week1.Week = value; }
        }

        public int ProdPlaceId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }

        }

        public int IsActive
        {
            get
            {
                if (chk_Active.CheckState == CheckState.Checked)
                    return -1;
                else if (chk_Active.CheckState == CheckState.Unchecked)
                    return 0;
                else
                    return 1;
            }
            set
            {
                if (value == -1)
                    chk_Active.CheckState = CheckState.Checked;
                else if (value == 0)
                    chk_Active.CheckState = CheckState.Unchecked;
                else
                    chk_Active.CheckState = CheckState.Indeterminate;
            }
        }
        public int WeekCount
        {
            get { return Convert.ToInt32(txt_Weeks.Text); }
            set { }
        }
        public double _NSMT
        {
            get; set;
        }
        public double _NTHT
        {
            get; set;
        }
        public double _NQSMT
        {
            get; set;
        }
        public double _NQTHT
        {
            get; set;
        }
        public double _NFTA
        {
            get; set;
        }
        public double _NFQC
        {
            get; set;
        }
        public double _NXRAY
        {
            get; set;
        }
        public double _NIPA
        {
            get; set;
        }
        public double _NGPA
        {
            get; set;
        }

        public double NSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_NSMT.Text); }
                catch { return 0; }
            }
            set { txt_NSMT.ThreadSafeCall(delegate { txt_NSMT.Text = value.ToString(); }); }
        }
        public double NTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_NTHT.Text); }
                catch { return 0; }
            }
            set { txt_NTHT.ThreadSafeCall(delegate { txt_NTHT.Text = value.ToString(); }); }
        }
        public double NQSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_NQSMT.Text); }
                catch { return 0; }
            }
            set { txt_NQSMT.ThreadSafeCall(delegate { txt_NQSMT.Text = value.ToString(); }); }
        }
        public double NQTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_NQTHT.Text); }
                catch { return 0; }
            }
            set { txt_NQTHT.ThreadSafeCall(delegate { txt_NQTHT.Text = value.ToString(); }); }
        }
        public double NFTA
        {
            get
            {
                try { return Convert.ToDouble(txt_NFTA.Text); }
                catch { return 0; }
            }
            set { txt_NFTA.ThreadSafeCall(delegate { txt_NFTA.Text = value.ToString(); }); }
        }
        public double NFQC
        {
            get
            {
                try { return Convert.ToDouble(txt_NFQC.Text); }
                catch { return 0; }
            }
            set { txt_NFQC.ThreadSafeCall(delegate { txt_NFQC.Text = value.ToString(); }); }
        }
        public double NXRAY
        {
            get
            {
                try { return Convert.ToDouble(txt_NXray.Text); }
                catch { return 0; }
            }
            set { txt_NXray.ThreadSafeCall(delegate { txt_NXray.Text = value.ToString(); }); }
        }
        public double NIPA
        {
            get
            {
                try { return Convert.ToDouble(txt_NIPA.Text); }
                catch { return 0; }
            }
            set { txt_NIPA.ThreadSafeCall(delegate { txt_NIPA.Text = value.ToString(); }); }
        }
        public double NGPA
        {
            get
            {
                try { return Convert.ToDouble(txt_NGPA.Text); }
                catch { return 0; }
            }
            set { txt_NGPA.ThreadSafeCall(delegate { txt_NGPA.Text = value.ToString(); }); }
        }

        public double CSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_CSMT.Text); }
                catch { return 0; }
            }
            set { txt_CSMT.ThreadSafeCall(delegate { txt_CSMT.Text = value.ToString(); }); }
        }
        public double CTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_CTHT.Text); }
                catch { return 0; }
            }
            set { txt_CTHT.ThreadSafeCall(delegate { txt_CTHT.Text = value.ToString(); }); }
        }
        public double CQSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_QCSMT.Text); }
                catch { return 0; }
            }
            set { txt_QCSMT.ThreadSafeCall(delegate { txt_QCSMT.Text = value.ToString(); }); }
        }
        public double CQTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_CQTHT.Text); }
                catch { return 0; }
            }
            set { txt_CQTHT.ThreadSafeCall(delegate { txt_CQTHT.Text = value.ToString(); }); }
        }
        public double CFTA
        {
            get
            {
                try { return Convert.ToDouble(txt_CFTA.Text); }
                catch { return 0; }
            }
            set { txt_CFTA.ThreadSafeCall(delegate { txt_CFTA.Text = value.ToString(); }); }
        }
        public double CFQC
        {
            get
            {
                try { return Convert.ToDouble(txt_CFQC.Text); }
                catch { return 0; }
            }
            set { txt_CFQC.ThreadSafeCall(delegate { txt_CFQC.Text = value.ToString(); }); }
        }
        public double CXRAY
        {
            get
            {
                try { return Convert.ToDouble(txt_CXRay.Text); }
                catch { return 0; }
            }
            set { txt_CXRay.ThreadSafeCall(delegate { txt_CXRay.Text = value.ToString(); }); }
        }
        public double CIPA
        {
            get
            {
                try { return Convert.ToDouble(txt_CIPA.Text); }
                catch { return 0; }
            }
            set { txt_CIPA.ThreadSafeCall(delegate { txt_CIPA.Text = value.ToString(); }); }
        }
        public double CGPA
        {
            get
            {
                try { return Convert.ToDouble(txt_CGPA.Text); }
                catch { return 0; }
            }
            set { txt_CGPA.ThreadSafeCall(delegate { txt_CGPA.Text = value.ToString(); }); }
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            //foreach (DataGridViewRow row in this.gv_Planned.Rows)
            //{
            //    if (Convert.ToDouble(row.Cells["cn_diff"].Value) < 0)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.LightCoral;              
            //}

        }

        public void LoadColumns(DataGridView grid)
        {
            DAL.UserLogin = System.Environment.UserName;

            SqlConnection sqlConn = new SqlConnection(sConnStr);
            SqlCommand sqlComm = new SqlCommand("sp_SelectUserGridViewColumn", sqlConn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@userid", DAL.UserId);
            sqlComm.Parameters.AddWithValue("@formname", this.Name);
            sqlComm.Parameters.AddWithValue("@gridname", grid.Name);

            sqlConn.Open();
            SqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        if (column.Name == reader["columnname"].ToString())
                        {
                            column.DisplayIndex = Convert.ToInt32(reader["columnorder"]);
                            column.HeaderText = reader["columntext"].ToString();
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                    }

                }
                reader.Close();
            }

            sqlConn.Close();

        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            var col = new DataGridViewTextBoxColumn();
            string _checkdate = "";
            try
            {
                bs_List.RemoveFilter();
                bs_Planned.RemoveFilter();
            }
            catch { }


            //MessageBox.Show(cmb_Firms1.FirmId.ToString());
            if (txt_StartFrom.Value != null)
            {
                data = Plan_BLL.getProdPlanning(cmb_Firms1.FirmId, txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                            txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim(),
                                            cmb_Batches1.BatchId, cmb_SalesOrdersWithLines1.SalesOrderLineId, IsActive, ProdPlaceId);

                var datadets = Plan_BLL.getProdPlanningDets(txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                                txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim());

                //DataRow[] datacr = data.Select(/*"plannedqty = 0 and diff > 0"*/);
                //DataRow[] datar = datadets.Select(/*"plannedqty > 0"*/);

                //try
                // {
                //DataTable datapr = null;
                //if (datacr.Any())
                //    datapr = datacr.CopyToDataTable();
                //DataTable datap = null;
                //if (datar.Any())
                //    datap = datar.CopyToDataTable();
                //}
                //catch { }     




                //Dates

                col = new DataGridViewTextBoxColumn();

                int countcol = 0;
                int tmpcol = 0;
                foreach (DataGridViewColumn colre in gv_List.Columns)
                {
                    countcol++;
                }

                for (int l = countcol - 1; l > 13; l--)
                    gv_List.ThreadSafeCall(delegate { gv_List.Columns.RemoveAt(l); });

                for (DateTime d = Convert.ToDateTime(txt_StartFrom.Value); d <= Convert.ToDateTime(txt_StartFrom.Value).AddDays(WeekCount * 7); d = d.AddDays(1))
                {
                    //Add column to datatable

                    if (d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday)
                    {
                        data.Columns.Add("cn_" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString(), typeof(double));
                        data.Columns.Add("cnv_" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString(), typeof(int));
                        data.Columns.Add("cnc_" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString(), typeof(string));

                        col = new DataGridViewTextBoxColumn();

                        col.Name = "cn_" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                        col.HeaderText = d.ToShortDateString();
                        col.Visible = true;
                        col.Width = 50;
                        col.DataPropertyName = "cn_" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                        try
                        {
                            _checkdate = Helper.GetOneRecord("set dateformat dmy select holyday from BAS_Holydays where holyday = convert(datetime, '" + d.ToShortDateString() + "')").ToString();
                        }
                        catch { _checkdate = ""; }
                        if (d.DayOfWeek == DayOfWeek.Saturday
                            || d.DayOfWeek == DayOfWeek.Sunday
                            || _checkdate != "")
                        {
                            //col.HeaderCell.Style.BackColor = Color.Red;
                            col.HeaderCell.Style.ForeColor = Color.Red;
                            //col.HeaderText.
                        }

                        col.ToolTipText = DAL.WeekFromDate(d.ToShortDateString());

                        gv_List.ThreadSafeCall(delegate { gv_List.Columns.Add(col); });

                        tmpcol++;
                        if (tmpcol % 5 == 0)
                        {
                            //Delivered
                            col = new DataGridViewTextBoxColumn();
                            col.Name = "cn_w" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                            col.HeaderText = "FCS sum.";
                            col.Visible = true;
                            col.Width = 60;
                            col.DataPropertyName = "cn_w" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                            col.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                            col.ReadOnly = true;
                            data.Columns.Add("cn_w" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString(), typeof(double));
                            gv_List.ThreadSafeCall(delegate { gv_List.Columns.Add(col); });

                            //Time

                            col = new DataGridViewTextBoxColumn();
                            col.Name = "cn_time" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                            col.HeaderText = "Time need";
                            col.Visible = true;
                            col.Width = 60;
                            col.DataPropertyName = "cn_time" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                            col.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                            col.ReadOnly = true;
                            data.Columns.Add("cn_time" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString(), typeof(double));
                            gv_List.ThreadSafeCall(delegate { gv_List.Columns.Add(col); });

                            //Rest

                            col = new DataGridViewTextBoxColumn();
                            col.Name = "cn_tot" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                            col.HeaderText = "Rest";
                            col.Visible = true;
                            col.Width = 60;
                            col.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                            col.ReadOnly = true;
                            col.DataPropertyName = "cn_tot" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                            data.Columns.Add("cn_tot" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString(), typeof(double));
                            gv_List.ThreadSafeCall(delegate { gv_List.Columns.Add(col); });

                            tmpcol = 0;
                        }


                    }
                }

                //Fill with data
                foreach (DataRow row in datadets.Rows)
                {
                    DataRow dr = data.Select("id=" + row["batchid"]).FirstOrDefault();
                    if (dr != null)
                    {
                        //MessageBox.Show("cn_" + Convert.ToDateTime(row["plandate"]).Day.ToString() + Convert.ToDateTime(row["plandate"]).Month.ToString() + Convert.ToDateTime(row["plandate"]).Year.ToString());
                        try
                        {
                            dr["cn_" + Convert.ToDateTime(row["plandate"]).Day.ToString() + Convert.ToDateTime(row["plandate"]).Month.ToString() + Convert.ToDateTime(row["plandate"]).Year.ToString()] = row["qty"];
                            dr["cnv_" + Convert.ToDateTime(row["plandate"]).Day.ToString() + Convert.ToDateTime(row["plandate"]).Month.ToString() + Convert.ToDateTime(row["plandate"]).Year.ToString()] = row["isapplied"];
                            dr["cnc_" + Convert.ToDateTime(row["plandate"]).Day.ToString() + Convert.ToDateTime(row["plandate"]).Month.ToString() + Convert.ToDateTime(row["plandate"]).Year.ToString()] = row["comments"];
                        }
                        catch { }
                    }
                }

                //Recalculate totals


                /*
                 Update rows with data
                 DataTable dt = new DataTable();

                // Get all DataRows where the name is the name you want.
                IEnumerable<datarow> rows = dt.Rows.Cast<DataRow>().Where(r => r["Name"].ToString() == "SomeName");
                // Loop through the rows and change the name.
                rows.ToList().ForEach(r => r.SetField("Name", "AnotherName"));

                // Alternative approach.
                // Simply loop through the rows, check the value of the Name field and change its value accordingly.
                foreach (DataRow row in dt.Rows)
                {
	                if (row["Name"].ToString() == "SomeName")
		                row.SetField("Name", "AnotherName");
                }
                */


                gv_List.ThreadSafeCall(delegate
                {
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    gv_List.AutoGenerateColumns = false;
                    bs_List.DataSource = data;
                    gv_List.DataSource = bs_List;

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                });


                bn_List.ThreadSafeCall(delegate
                {
                    bn_List.BindingSource = bs_List;
                });

                RecalcTotals();

                //gv_Planned.ThreadSafeCall(delegate
                //{
                //    DataGridViewColumn oldColumn = gv_Planned.SortedColumn;
                //    var dir = Helper.SaveDirection(gv_Planned);



                //    gv_Planned.AutoGenerateColumns = false;
                //    bs_Planned.DataSource = datap;
                //    gv_Planned.DataSource = bs_Planned;


                //    Helper.RestoreDirection(gv_Planned, oldColumn, dir);

                //    SetCellsColor();

                //});


                //bn_Planned.ThreadSafeCall(delegate
                //{
                //    bn_Planned.BindingSource = bs_Planned;
                //});

                ////Filling stages
                //DataTable databatches = new DataTable();
                //databatches.Columns.Add("batchid", typeof(int));
                //databatches.Columns.Add("qty", typeof(long));
                //databatches.Columns.Add("dateoper", typeof(DateTime));

                //DateTime dateof = System.DateTime.Now.AddDays(Convert.ToInt32(txt_Capa.Text) * 7);
                //DataRow[] datab = data.Select("plannedqty > 0 and dateofweek < '" + dateof + "'");

                //foreach (DataRow row in datab)
                //{
                //    DataRow dr = databatches.NewRow();
                //    dr["batchid"] = Convert.ToInt32(row["batchid"]);
                //    dr["qty"] = Convert.ToInt32(row["plannedqty"]);
                //    dr["dateoper"] = Convert.ToDateTime(row["dateofweek"]);
                //    databatches.Rows.Add(dr);
                //}

                //ShowCapacity(Convert.ToInt32(txt_Capa.Text), databatches);}
            }
            else
                glob_Class.ShowMessage("ODIN warning!", "Please select start date!", "You can't select period without start date!");
        }

        //public void ShowCapacity(int weekoper, DataTable databatches)
        public void ShowCapacity(string date)
        {
            ClearCapacity();
            var data = Plan_BLL.getProductionPlanningCapa(date, ProdPlaceId);

            foreach (DataRow row in data.Rows)
            {
                switch (Convert.ToInt32(row["stageid"]))
                {
                    case 1:
                        NSMT = Convert.ToDouble(row["stagetime"]);
                        _NSMT = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 2:
                        NTHT = Convert.ToDouble(row["stagetime"]);
                        _NTHT = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 3:
                        NFTA = Convert.ToDouble(row["stagetime"]);
                        _NFTA = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 4:
                        NIPA = Convert.ToDouble(row["stagetime"]);
                        _NIPA = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 5:
                        NQSMT = Convert.ToDouble(row["stagetime"]);
                        _NQSMT = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 6:
                        NQTHT = Convert.ToDouble(row["stagetime"]);
                        _NQTHT = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 7:
                        NFQC = Convert.ToDouble(row["stagetime"]);
                        _NFQC = Convert.ToDouble(row["stagetime"]);
                        break;
                    case 9:
                        NXRAY = Convert.ToDouble(row["stagetime"]);
                        _NXRAY = Convert.ToDouble(row["stagetime"]);
                        break;
                    default:
                        NGPA = Convert.ToDouble(row["stagetime"]);
                        _NGPA = Convert.ToDouble(row["stagetime"]);
                        break;
                }
            }
        }

        public void ClearCapacity()
        {
            NSMT = 0;
            _NSMT = 0;
            NTHT = 0;
            _NTHT = 0;
            NFTA = 0;
            _NFTA = 0;
            NIPA = 0;
            _NIPA = 0;
            NQSMT = 0;
            _NQSMT = 0;
            NQTHT = 0;
            _NQTHT = 0;
            NFQC = 0;
            _NFQC = 0;
            NXRAY = 0;
            _NXRAY = 0;
            NGPA = 0;
            _NGPA = 0;
        }
        public void RecalcTotals()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                RecalcRowTotals(row);
                RepaintCellColors(row);
            }
        }
        public void RepaintRowColors()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                RepaintCellColors(row);
            }
        }
        public void RecalcRowTotals(DataGridViewRow row)
        {
            try
            {
                double _sumbefore = Convert.ToDouble(row.Cells["cn_sumbefore"].Value);
                double _sumbeforetime = 0;
                double _qtyinbatch = Convert.ToDouble(row.Cells["cn_qtyinbatch"].Value);
                double _teortime = Convert.ToDouble(row.Cells["cn_teortime"].Value);

                int tmpcol = 1;

                for (int j = 14; j < row.Cells.Count; j++)
                {

                    switch (tmpcol % 8)
                    {
                        case 7:
                            break;
                        case 0:
                            tmpcol = 0;
                            row.Cells[j].Value = _qtyinbatch - _sumbefore;
                            break;
                        case 6:
                            row.Cells[j].Value = _sumbefore;
                            row.Cells[j + 1].Value = Math.Round(_sumbeforetime * _teortime / 60, 2);
                            _sumbeforetime = 0;
                            break;
                        default:
                            _sumbefore = _sumbefore + Convert.ToDouble(row.Cells[j].Value.ToString() == "" ? 0 : row.Cells[j].Value);
                            _sumbeforetime = _sumbeforetime + Convert.ToDouble(row.Cells[j].Value.ToString() == "" ? 0 : row.Cells[j].Value);
                            break;
                    }
                    tmpcol++;

                }
                //foreach (DataGridViewCell cell in row.Cells)
                //{
                //    //cell.Value = _sumbefore;
                //    if (cell.ColumnIndex > 12)
                //    {
                //        switch (tmpcol % 8)
                //        {
                //            case 7:
                //                break;
                //            case 0:
                //                tmpcol = 0;
                //                cell.Value = _qtyinbatch - _sumbefore;
                //                break;
                //            case 6:
                //                cell.Value = _sumbefore;
                //                break;
                //            default:
                //                _sumbefore = _sumbefore + Convert.ToDouble(cell.Value.ToString() == "" ? 0 : cell.Value);
                //                break;
                //        }
                //        tmpcol++;
                //    }

                //}
                //if (_qtyinbatch <= _sumbefore)
                //    row.Cells["cn_qtyinbatch"].Style.BackColor = Color.FromArgb(192, 255, 192);
                //else
                //    row.Cells["cn_qtyinbatch"].Style.BackColor = Color.White;
            }
            catch { }
        }

        public void RepaintCellColors(DataGridViewRow row)
        {
            DataTable dr1 = null;


            DataRow[] dr = data.Select("id =" + Convert.ToInt32(row.Cells["cn_batchid"].Value).ToString());

            if (dr.Any())
            {
                dr1 = dr.CopyToDataTable();

                foreach (DataColumn c in dr1.Columns)
                {
                    if (c.ColumnName.Length >= 3 &&
                        c.ColumnName.Substring(0, 3) == "cnv"
                        && dr1.Rows[0][c.ColumnName].ToString() != "0"
                         && dr1.Rows[0][c.ColumnName].ToString() != "")
                    {
                        //dr1.Rows[0][c.ColumnName].ToString() == "0" ? row.Cells["cn" + c.ColumnName.Substring(3)].Style.BackColor = Color.Aquamarine 
                        //        : row.Cells["cn" + c.ColumnName.Substring(3)].Style.BackColor = Color.FromArgb(192, 255, 192);
                        row.Cells["cn" + c.ColumnName.Substring(3)].Style.BackColor =
                                    dr1.Rows[0][c.ColumnName].ToString() == "-1" ? Color.Aquamarine : Color.GreenYellow;
                        //MessageBox.Show(c.ColumnName);
                    }

                    if (c.ColumnName.Length >= 3 &&
                        c.ColumnName.Substring(0, 3) == "cnc"
                        && dr1.Rows[0][c.ColumnName].ToString() != "")
                    {
                        row.Cells["cn" + c.ColumnName.Substring(3)].ToolTipText = dr1.Rows[0][c.ColumnName].ToString();
                        row.Cells["cn" + c.ColumnName.Substring(3)].Style.BackColor = Color.LightPink;
                    }
                }

            }
        }

        public void ShowToolTip(string text)
        {
            toolTip1.Show(text, gv_List);
        }
        /*public void FillOrders()
        {
            var data = Plan_BLL.getProjectPlanning(cmb_Firms1.FirmId, Convert.ToInt32(txt_Perc.Text));
            var datacp = data.Select("plannedqty = 0 and diff > 0");
            var datap = data.Select("plannedqty != 0");


            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);



                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = datacp;
                gv_List.DataSource = bs_List;


                Helper.RestoreDirection(gv_List, oldColumn, dir);
                
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            gv_Planned.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_Planned.SortedColumn;
                var dir = Helper.SaveDirection(gv_Planned);



                gv_Planned.AutoGenerateColumns = false;
                bs_Planned.DataSource = datap;
                gv_Planned.DataSource = bs_Planned;


                Helper.RestoreDirection(gv_Planned, oldColumn, dir);

                SetCellsColor();

            });


            bn_Planned.ThreadSafeCall(delegate
            {
                bn_Planned.BindingSource = bs_Planned;
            });
        }
        */

        #endregion

        #region Controls

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            try
            {
                bwStart(bw_List);
            }
            catch { }
            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }


        #region Context menu


        private void mnu_Lines_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_List.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_List.HitTest(mpoint.X, mpoint.Y);

                RowIndex = info.RowIndex;
                ColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_List.ClearSelection();
                gv_List.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
                gv_List.CurrentCell = gv_List.Rows[RowIndex].Cells[ColumnIndex];

                CellValue = gv_List.Rows[RowIndex].Cells[ColumnIndex].Value.ToString();
                ColumnName = gv_List.Columns[ColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndex = 0;
                ColumnIndex = 0;
                return;
            }
        }

        private void mni_Conditional_Click(object sender, EventArgs e)
        {
            double _missed = 0;

            try
            {
                _missed = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_missed"].Value);

                if (_missed > 0)
                {

                    if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    {
                        bs_List.Filter = "missed > 0 ";
                    }
                    else
                    {
                        bs_List.Filter = bs_List.Filter + " AND missed > 0";

                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    {
                        bs_List.Filter = "missed <= 0 ";
                    }
                    else
                    {
                        bs_List.Filter = bs_List.Filter + " AND missed <= 0";
                    }
                }

            }
            catch { }
            SetCellsColor();
        }

        private void mni_FilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            RepaintRowColors();
            //RecalcTotals();
            SetCellsColor();

        }

        private void mni_Search_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_List;
            frm.ColumnNumber = gv_List.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_List.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            RepaintRowColors();
            // RecalcTotals();
            SetCellsColor();

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
                else
                    bs_List.Filter = bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            RepaintRowColors();
            // RecalcTotals();
            SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            RepaintRowColors();
            //RecalcTotals();
            SetCellsColor();

        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for production deficite list";
            frm.grid = this.gv_List;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_List);
            }
        }



        private void mnu_LinesP_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Planned.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Planned.HitTest(mpoint.X, mpoint.Y);

                RowIndexP = info.RowIndex;
                ColumnIndexP = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Planned.ClearSelection();
                gv_Planned.Rows[RowIndexP].Cells[ColumnIndexP].Selected = true;
                gv_Planned.CurrentCell = gv_Planned.Rows[RowIndexP].Cells[ColumnIndexP];

                CellValueP = gv_Planned.Rows[RowIndexP].Cells[ColumnIndexP].Value.ToString();
                ColumnNameP = gv_Planned.Columns[ColumnIndexP].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexP = 0;
                ColumnIndexP = 0;
                return;
            }
        }


        private void mni_FilterForP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_Planned.Filter = ("Convert(" + ColumnNameP + " , 'System.String') like '%" + mni_FilterForP.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsColor();

        }

        private void mni_SearchP_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Planned;
            frm.ColumnNumber = gv_Planned.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Planned.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterByP_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Planned.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValueP) == true)
                        bs_Planned.Filter = "(" + ColumnNameP + " is null OR Convert(" + ColumnNameP + ", 'System.String') = '')";
                    else
                        bs_Planned.Filter = "Convert(" + ColumnNameP + " , 'System.String') = '" + glob_Class.NES(CellValueP) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_Planned.Filter = bs_Planned.Filter + "AND (" + ColumnNameP + " is null OR Convert(" + ColumnNameP + ", 'System.String') = '')";
                    else
                        bs_Planned.Filter = bs_Planned.Filter + " AND Convert(" + ColumnNameP + " , 'System.String') = '" + glob_Class.NES(CellValueP) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();

        }

        private void mni_FilterExcludingSelP_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    bs_Planned.Filter = "Convert(" + ColumnNameP + " , 'System.String') <> '" + CellValueP + "'";
                else
                    bs_Planned.Filter = bs_Planned.Filter + " AND " + ColumnNameP + " <> '" + CellValueP + "'";
            }
            catch { }
            SetCellsColor();

        }

        private void mni_RemoveFilterP_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Planned.RemoveFilter();
            }
            catch { }
            SetCellsColor();

        }

        private void mni_CopyP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueP.ToString());
        }

        private void mni_AdminP_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for planning list";
            frm.grid = this.gv_Planned;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Planned);
            }
        }

        #endregion

        #endregion

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RecalcTotals();
            //SetCellsColor();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            string _week = "";
            double _qty = 0;
            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);
                _week = gv_List.CurrentRow.Cells["cn_week"].Value.ToString();
                _qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_canproduce"].Value);
                //_qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_minqty"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_planned"].Value) < 0 ? 0
                //    : Convert.ToDouble(gv_List.CurrentRow.Cells["cn_minqty"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_planned"].Value);
            }
            catch { }

            if (_batchid != 0)
            {
                frm_AddBatchPlanning frm = new frm_AddBatchPlanning();
                frm.BatchId = _batchid;
                frm.Week = _week;
                frm.Qty = _qty;
                frm.PlanDateD = frm.cmb_Week1.FirstDateOfWeek;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PlanBll.AddBatchPlanning(frm.BatchId, frm.Qty, frm.PlanDate, frm.Comments);
                    bwStart(bw_List);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            string _week = "";

            try
            {
                _batchid = Convert.ToInt32(gv_Planned.CurrentRow.Cells["cn_pbatchid"].Value);
                _week = gv_Planned.CurrentRow.Cells["cn_pweekoper"].Value.ToString();
            }
            catch { }

            if (_batchid != 0
                && glob_Class.MessageConfirm("Deleting confirmation", "Are you sure you want to delete planned qty?") == true
                )
            {

                PlanBll.DeleteBatchPlanning(_batchid, _week);
                bwStart(bw_List);

            }
        }

        private void frm_ProjectPlanning_Load(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.RemoveAll();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 3000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 0;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;


            LoadColumns(gv_List);
            LoadColumns(gv_Planned);
            ClearFilter();
            txt_StartFrom.Value = System.DateTime.Now;
            Week = "W" + (cmb_Week1.WeekNumber(Convert.ToDateTime(txt_StartFrom.Value)).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(Convert.ToDateTime(txt_StartFrom.Value)).ToString() : cmb_Week1.WeekNumber(Convert.ToDateTime(txt_StartFrom.Value)).ToString()) + "." + Convert.ToDateTime(txt_StartFrom.Value).Year.ToString();
            txt_StartFrom.Value = cmb_Week1.FirstDateOfWeek;
        }

        private void gv_Planned_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_Excel1_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }

        #region Stages
        private void txt_CSMT_TextChanged(object sender, EventArgs e)
        {
            NSMT = _NSMT * CSMT;
        }

        private void txt_QCSMT_TextChanged(object sender, EventArgs e)
        {
            NQSMT = _NQSMT * CQSMT;
        }

        private void txt_CXRay_TextChanged(object sender, EventArgs e)
        {
            NXRAY = _NXRAY * CXRAY;
        }

        private void txt_CTHT_TextChanged(object sender, EventArgs e)
        {
            NTHT = _NTHT * CTHT;
        }

        private void txt_CQTHT_TextChanged(object sender, EventArgs e)
        {
            NQTHT = _NQTHT * CQTHT;
        }

        private void txt_CFTA_TextChanged(object sender, EventArgs e)
        {
            NFTA = _NFTA * CFTA;
        }

        private void txt_CFQC_TextChanged(object sender, EventArgs e)
        {
            NFQC = _NFQC * CFQC;
        }

        private void txt_CIPA_TextChanged(object sender, EventArgs e)
        {
            NIPA = _NIPA * CIPA;
        }

        private void txt_CGPA_TextChanged(object sender, EventArgs e)
        {
            NGPA = _NGPA * CGPA;
        }

        #endregion  
        private void txt_StartFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_StartFrom.Value = txt_StartFrom.Value == null ? System.DateTime.Now : txt_StartFrom.Value;
        }

        private void txt_StartTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_StartTill.Value = txt_StartTill.Value == null ? System.DateTime.Now : txt_StartTill.Value;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            btn_OK.Focus();

            DataTable dataplanning = new DataTable();
            dataplanning.Columns.Add("batchid", typeof(int));
            dataplanning.Columns.Add("qty", typeof(double));
            dataplanning.Columns.Add("plandate", typeof(DateTime));
            dataplanning.Columns.Add("comments", typeof(string));

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex > 13)
                    {
                        //MessageBox.Show(cell.OwningColumn.HeaderText);
                        //try
                        //{
                        if (glob_Class.TextIsDate(cell.OwningColumn.HeaderText) == true)
                        {
                            DataRow dr = dataplanning.NewRow();
                            dr["batchid"] = Convert.ToInt32(row.Cells["cn_batchid"].Value);
                            dr["qty"] = (cell.Value == null || cell.Value.ToString() == "") ? 0 : Convert.ToDouble(cell.Value);
                            dr["plandate"] = Convert.ToDateTime(cell.OwningColumn.HeaderText);
                            dr["comments"] = "";
                            dataplanning.Rows.Add(dr);
                        }
                        // }
                        // catch { }
                    }
                }

            }

            PlanBll.SaveProductionPlanning(dataplanning);

        }

        #region Methods

        public void ClearFilter()
        {
            cmb_Batches1.BatchId = 0;
            cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;

            //cmb_Types1.TypeId = 0;
            //cmb_Department1.DeptId = 0;

            //cmb_Articles1.ArticleId = 0;

            txt_StartFrom.Value = null;
            txt_StartTill.Value = null;
            //txt_EndFrom.Value = null;
            //txt_EndTill.Value = null;
        }


        #endregion

        private void txt_StartFrom_ValueChanged(object sender, EventArgs e)
        {
            //cmb_Week1.Week = cmb_Week1.WeekNumber(Convert.ToDateTime(txt_StartFrom.Value));
            Week = "W" + (cmb_Week1.WeekNumber(Convert.ToDateTime(txt_StartFrom.Value)).ToString().Length == 1 ? "0" + cmb_Week1.WeekNumber(Convert.ToDateTime(txt_StartFrom.Value)).ToString() : cmb_Week1.WeekNumber(Convert.ToDateTime(txt_StartFrom.Value)).ToString()) + "." + Convert.ToDateTime(txt_StartFrom.Value).Year.ToString();
            txt_StartFrom.Value = cmb_Week1.FirstDateOfWeek;
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            RecalcRowTotals(gv_List.CurrentRow);
        }


        int _tmpyear = 0;
        int _tmpweek = 0;
        public int _oldtmpyear = 0;
        public int _oldtmpweek = 0;

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            DateTime curdate = System.DateTime.Now;
            DataGridViewCell cell = gv_List.CurrentCell;
            try
            {
                if (cell.ColumnIndex > 12)
                {
                    int _tmpindex = cell.ColumnIndex;
                    while (glob_Class.IsDateTime(gv_List.CurrentRow.Cells[_tmpindex].OwningColumn.HeaderText) == "")
                    {
                        _tmpindex--;
                    }
                    curdate = Convert.ToDateTime(gv_List.CurrentRow.Cells[_tmpindex].OwningColumn.HeaderText);
                    //MessageBox.Show(curdate.ToShortDateString());
                    //if (glob_Class.IsDateTime(cell.OwningColumn.HeaderText) != "")
                    //{
                    //    curdate = Convert.ToDateTime(cell.OwningColumn.HeaderText);
                    //}


                    _tmpweek = DAL.WeekNumber(curdate);
                    _tmpyear = curdate.Year;

                    if (_tmpyear != _oldtmpyear
                        || _tmpweek != _oldtmpweek)
                    {
                        //MessageBox.Show(DAL.DateOfWeek(_tmpweek, _tmpyear).ToString());
                        //MessageBox.Show("true");
                        ShowCapacity(DAL.DateOfWeek(_tmpweek, _tmpyear).ToString());
                        _oldtmpyear = _tmpyear;
                        _oldtmpweek = _tmpweek;
                    }

                }
                else
                {
                    ClearCapacity();
                }
            }
            catch { }
        }

        private void btn_Launches_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);
            }
            catch { _id = 0; }


            if (_id != 0)
            {
                var _query = "sp_SelectBatchLaunchesPlanning";

                var sqlparams = new List<SqlParameter>()
                {
                    new SqlParameter("@batchid",SqlDbType.Int) {Value = _id}
                };

                Template_DataGridView frm = new Template_DataGridView();

                frm.Text = "Batch launches ";
                frm.Query = _query;
                frm.SqlParams = sqlparams;
                frm.Show();
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            //btn_Save.PerformClick();

            FillReport();

        }

        public void FillReport()
        {
            string FirstDate = "";
            DataTable datadets = new DataTable();
            datadets.Columns.Add("wcount", typeof(int));
            datadets.Columns.Add("wdatecount", typeof(int));
            datadets.Columns.Add("weekday", typeof(string));
            datadets.Columns.Add("date", typeof(DateTime));
            datadets.Columns.Add("batch", typeof(string));
            datadets.Columns.Add("qty", typeof(double));
            datadets.Columns.Add("product", typeof(string));
            datadets.Columns.Add("isgreen", typeof(int));

            //1st
            DateTime curdate = System.DateTime.Now;
            DataGridViewCell cell = gv_List.CurrentCell;
            try
            {
                if (cell.ColumnIndex > 12)
                {
                    int _tmpindex = cell.ColumnIndex;
                    while (glob_Class.IsDateTime(gv_List.CurrentRow.Cells[_tmpindex].OwningColumn.HeaderText) == "")
                    {
                        _tmpindex--;
                    }
                    curdate = Convert.ToDateTime(gv_List.CurrentRow.Cells[_tmpindex].OwningColumn.HeaderText);
                    //MessageBox.Show(curdate.ToShortDateString());
                    //if (glob_Class.IsDateTime(cell.OwningColumn.HeaderText) != "")
                    //{
                    //    curdate = Convert.ToDateTime(cell.OwningColumn.HeaderText);
                    //}
                    _tmpweek = DAL.WeekNumber(curdate);
                    _tmpyear = curdate.Year;

                    //MessageBox.Show("true");


                }
                else
                {
                    _tmpweek = DAL.WeekNumber(System.DateTime.Now);
                    _tmpyear = System.DateTime.Now.Year;
                }
                FirstDate = DAL.DateOfWeek(_tmpweek, _tmpyear).ToShortDateString();
            }
            catch
            {
                _tmpweek = DAL.WeekNumber(System.DateTime.Now);
                _tmpyear = System.DateTime.Now.Year;
                FirstDate = DAL.DateOfWeek(_tmpweek, _tmpyear).ToShortDateString();
            }

            var dets = Plan_BLL.getProdPlanning2Weeks(FirstDate, cmb_Firms1.FirmId, IsActive, ProdPlaceId);

            foreach (DataRow row in dets.Rows)
            {
                DataRow dr = datadets.NewRow();
                dr["wcount"] = Convert.ToInt32(row["wcount"]);
                dr["wdatecount"] = Convert.ToInt32(row["wdatecount"]);
                dr["weekday"] = row["weekday"].ToString();
                dr["date"] = Convert.ToDateTime(row["plandate"]);
                dr["batch"] = row["batch"].ToString();
                dr["qty"] = Convert.ToDouble(row["qty"]);
                dr["product"] = row["secname"].ToString();
                dr["isgreen"] = row["isgreen"].ToString();
                datadets.Rows.Add(dr);

            }

            frm_rptProductionPlanning frm = new frm_rptProductionPlanning();
            frm.Week1 = DAL.WeekFromDate(FirstDate);
            frm.Week2 = DAL.WeekFromDate(Convert.ToDateTime(FirstDate).AddDays(7).ToString());
            //MessageBox.Show(FirstDate + frm.Week1 + frm.Week2);
            frm.data01 = datadets.Clone();
            frm.data02 = datadets.Clone();
            frm.data03 = datadets.Clone();
            frm.data04 = datadets.Clone();
            frm.data05 = datadets.Clone();
            frm.data11 = datadets.Clone();
            frm.data12 = datadets.Clone();
            frm.data13 = datadets.Clone();
            frm.data14 = datadets.Clone();
            frm.data15 = datadets.Clone();

            var data01 = datadets.Select("wcount = 0 and wdatecount = 1");
            var data02 = datadets.Select("wcount = 0 and wdatecount = 2");
            var data03 = datadets.Select("wcount = 0 and wdatecount = 3");
            var data04 = datadets.Select("wcount = 0 and wdatecount = 4");
            var data05 = datadets.Select("wcount = 0 and wdatecount = 5");
            var data11 = datadets.Select("wcount = 1 and wdatecount = 1");
            var data12 = datadets.Select("wcount = 1 and wdatecount = 2");
            var data13 = datadets.Select("wcount = 1 and wdatecount = 3");
            var data14 = datadets.Select("wcount = 1 and wdatecount = 4");
            var data15 = datadets.Select("wcount = 1 and wdatecount = 5");


            foreach (DataRow dr in data01)
                frm.data01.ImportRow(dr);
            foreach (DataRow dr in data02)
                frm.data02.ImportRow(dr);
            foreach (DataRow dr in data03)
                frm.data03.ImportRow(dr);
            foreach (DataRow dr in data04)
                frm.data04.ImportRow(dr);
            foreach (DataRow dr in data05)
                frm.data05.ImportRow(dr);
            foreach (DataRow dr in data11)
                frm.data11.ImportRow(dr);
            foreach (DataRow dr in data12)
                frm.data12.ImportRow(dr);
            foreach (DataRow dr in data13)
                frm.data13.ImportRow(dr);
            foreach (DataRow dr in data14)
                frm.data14.ImportRow(dr);
            foreach (DataRow dr in data15)
                frm.data15.ImportRow(dr);


            //frm.Supplier = _supplier;
            //frm.Seller = _seller;
            //frm.DocType = _doctype;
            //frm.Procedure = _procedure;
            //frm.ChangeDate = _changedate;
            //frm.Numurs = _numurs;
            //frm.BargCode = _bargcode;
            //frm.Incoterm = _incoterm;
            //frm.Total = _total;
            //frm.StatTotal = _stattotal;
            //frm.CurRate = _currate;
            //frm.data = datadets.Clone();
            //frm.datadocs = datadocs.Clone();
            //frm.datataxes = datataxes.Clone();
            //frm.dataoverheads = dataoverheads.Clone();

            //foreach (DataRow dr in datadocs.Rows)
            //{
            //    frm.datadocs.ImportRow(dr);
            //}
            //foreach (DataRow dr in datataxes.Rows)
            //{
            //    frm.datataxes.ImportRow(dr);
            //}
            //foreach (DataRow dr in dataoverheads.Rows)
            //{
            //    frm.dataoverheads.ImportRow(dr);
            //}
            frm.FillReport();

            frm.Show();

        }

        private void gv_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gv_List.CurrentCell.Value = DBNull.Value;
            }
        }

        private void btn_Validate_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            btn_OK.Focus();

            DataTable dataplanning = new DataTable();
            dataplanning.Columns.Add("batchid", typeof(int));
            dataplanning.Columns.Add("qty", typeof(double));
            dataplanning.Columns.Add("plandate", typeof(DateTime));
            dataplanning.Columns.Add("comments", typeof(string));


            foreach (DataGridViewCell cell in gv_List.SelectedCells)
            {
                if (cell.ColumnIndex > 12)
                {
                    //MessageBox.Show(cell.OwningColumn.HeaderText);
                    //try
                    //{
                    if (glob_Class.TextIsDate(cell.OwningColumn.HeaderText) == true)
                    {
                        DataRow dr = dataplanning.NewRow();
                        dr["batchid"] = Convert.ToInt32(cell.OwningRow.Cells["cn_batchid"].Value);
                        dr["qty"] = (cell.Value == null || cell.Value.ToString() == "") ? 0 : Convert.ToDouble(cell.Value);
                        dr["plandate"] = Convert.ToDateTime(cell.OwningColumn.HeaderText);
                        dr["comments"] = "";
                        dataplanning.Rows.Add(dr);

                        cell.Style.BackColor = Color.Aquamarine;
                    }
                    // }
                    // catch { }
                }
            }


            PlanBll.ValidateProductionPlanning(dataplanning, -1);

            glob_Class.ShowMessage("ODIN message", "Validation: ", "Done!");
        }

        private void btn_Invalidate_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            btn_OK.Focus();

            DataTable dataplanning = new DataTable();
            dataplanning.Columns.Add("batchid", typeof(int));
            dataplanning.Columns.Add("qty", typeof(double));
            dataplanning.Columns.Add("plandate", typeof(DateTime));
            dataplanning.Columns.Add("comments", typeof(string));


            foreach (DataGridViewCell cell in gv_List.SelectedCells)
            {
                if (cell.ColumnIndex > 12)
                {
                    //MessageBox.Show(cell.OwningColumn.HeaderText);
                    //try
                    //{
                    if (glob_Class.TextIsDate(cell.OwningColumn.HeaderText) == true)
                    {
                        DataRow dr = dataplanning.NewRow();
                        dr["batchid"] = Convert.ToInt32(cell.OwningRow.Cells["cn_batchid"].Value);
                        dr["qty"] = (cell.Value == null || cell.Value.ToString() == "") ? 0 : Convert.ToDouble(cell.Value);
                        dr["plandate"] = Convert.ToDateTime(cell.OwningColumn.HeaderText);
                        dr["comments"] = "";
                        dataplanning.Rows.Add(dr);

                        cell.Style.BackColor = Color.White;
                    }
                    // }
                    // catch { }
                }
            }

            PlanBll.ValidateProductionPlanning(dataplanning, 0);

            glob_Class.ShowMessage("ODIN message", "Invalidation: ", "Done!");
        }

        private void gv_List_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Compare the column to the column you want to format
            //if (this.dataGridView1.Columns[e.ColumnIndex].Name == "ColumnName")
            //{
            //    //get the IChessitem you are currently binding, using the index of the current row to access the datasource
            //    IChessItem item = sourceList[e.RowIndex];
            //    //check the condition
            //    if (item == condition)
            //    {
            //        e.CellStyle.BackColor = Color.Green;
            //    }
            //}
        }

        private void mni_Comments_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            string _columnname = "";
            string _comments = "";

            DataGridViewCell cell = gv_List.CurrentCell;

            _comments = cell.ToolTipText;
            _batchid = Convert.ToInt32(cell.OwningRow.Cells["cn_batchid"].Value);
            _columnname = cell.OwningColumn.HeaderText;

            if (_batchid != 0)
            {
                frm_cmbText frm = new frm_cmbText();
                frm.HeaderText = "Add comments";
                frm.LabelText = "Comments:";
                frm.FormText = _comments;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK
                    )
                {
                    if (glob_Class.TextIsDate(cell.OwningColumn.HeaderText) == true)
                        PlanBll.EditProductionPlanning(_batchid, _columnname, frm.FormText);
                    cell.ToolTipText = frm.FormText;

                }

            }
            //MessageBox.Show(_batchid.ToString() + " " + _comments + " " + _columnname);

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            btn_OK.Focus();

            DataTable dataplanning = new DataTable();
            dataplanning.Columns.Add("batchid", typeof(int));
            dataplanning.Columns.Add("qty", typeof(double));
            dataplanning.Columns.Add("plandate", typeof(DateTime));
            dataplanning.Columns.Add("comments", typeof(string));


            foreach (DataGridViewCell cell in gv_List.SelectedCells)
            {
                if (cell.ColumnIndex > 12)
                {
                    //MessageBox.Show(cell.OwningColumn.HeaderText);
                    //try
                    //{
                    if (glob_Class.TextIsDate(cell.OwningColumn.HeaderText) == true)
                    {
                        DataRow dr = dataplanning.NewRow();
                        dr["batchid"] = Convert.ToInt32(cell.OwningRow.Cells["cn_batchid"].Value);
                        dr["qty"] = (cell.Value == null || cell.Value.ToString() == "") ? 0 : Convert.ToDouble(cell.Value);
                        dr["plandate"] = Convert.ToDateTime(cell.OwningColumn.HeaderText);
                        dr["comments"] = "";
                        dataplanning.Rows.Add(dr);

                        cell.Style.BackColor = Color.GreenYellow;
                    }
                    // }
                    // catch { }
                }
            }


            PlanBll.ValidateProductionPlanning(dataplanning, 1);

            glob_Class.ShowMessage("ODIN message", "Marking to check: ", "Done!");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frm_ProductionPlanningDets frm = new frm_ProductionPlanningDets();
            frm.Show();
        }

        private void mni_Holidays_Click(object sender, EventArgs e)
        {
            DateTime holyday;
            if (glob_Class.MessageConfirm("Holidays", "Are you sure change holiday property for this date?") == true)
            {
                foreach (DataGridViewCell cell in gv_List.SelectedCells)
                {
                    if (cell.ColumnIndex > 12)
                    {
                        if (glob_Class.TextIsDate(cell.OwningColumn.HeaderText) == true)
                        {
                            holyday = Convert.ToDateTime(cell.OwningColumn.HeaderText);

                            if (DAL.MakeHoliday(holyday.ToShortDateString()) == -1)
                                cell.OwningColumn.HeaderCell.Style.ForeColor = Color.Red;
                            else
                                cell.OwningColumn.HeaderCell.Style.ForeColor = Color.Black;


                        }
                    }
                }
            }
        }
    }
}
