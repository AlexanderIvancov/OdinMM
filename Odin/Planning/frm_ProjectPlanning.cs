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
    public partial class frm_ProjectPlanning : BaseForm
    {
        public frm_ProjectPlanning()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ProjectPlanningCanProduce.xls", this.Name);
            ED1 = new ExportData(this.gv_List, "ProjectPlanning.xls", this.Name);
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

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int RowIndexP = 0;
        public int ColumnIndexP = 0;
        public string ColumnNameP = "";
        public string CellValueP = "";

        public double _NSMT
        {
            get;set;        
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
            get {
                try { return Convert.ToDouble(txt_NSMT.Text); }
                catch { return 0; }
            }
            set { txt_NSMT.Text = value.ToString(); }
        }
        public double NTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_NTHT.Text); }
                catch { return 0; }
            }
            set { txt_NTHT.Text = value.ToString(); }
        }
        public double NQSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_NQSMT.Text); }
                catch { return 0; }
            }
            set { txt_NQSMT.Text = value.ToString(); }
        }
        public double NQTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_NQTHT.Text); }
                catch { return 0; }
            }
            set { txt_NQTHT.Text = value.ToString(); }
        }
        public double NFTA
        {
            get
            {
                try { return Convert.ToDouble(txt_NFTA.Text); }
                catch { return 0; }
            }
            set { txt_NFTA.Text = value.ToString(); }
        }
        public double NFQC
        {
            get
            {
                try { return Convert.ToDouble(txt_NFQC.Text); }
                catch { return 0; }
            }
            set { txt_NFQC.Text = value.ToString(); }
        }
        public double NXRAY
        {
            get
            {
                try { return Convert.ToDouble(txt_NXray.Text); }
                catch { return 0; }
            }
            set { txt_NXray.Text = value.ToString(); }
        }
        public double NIPA
        {
            get
            {
                try { return Convert.ToDouble(txt_NIPA.Text); }
                catch { return 0; }
            }
            set { txt_NIPA.Text = value.ToString(); }
        }
        public double NGPA
        {
            get
            {
                try { return Convert.ToDouble(txt_NGPA.Text); }
                catch { return 0; }
            }
            set { txt_NGPA.Text = value.ToString(); }
        }

        public double CSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_CSMT.Text); }
                catch { return 0; }
            }
            set { txt_CSMT.Text = value.ToString(); }
        }
        public double CTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_CTHT.Text); }
                catch { return 0; }
            }
            set { txt_CTHT.Text = value.ToString(); }
        }
        public double CQSMT
        {
            get
            {
                try { return Convert.ToDouble(txt_QCSMT.Text); }
                catch { return 0; }
            }
            set { txt_QCSMT.Text = value.ToString(); }
        }
        public double CQTHT
        {
            get
            {
                try { return Convert.ToDouble(txt_CQTHT.Text); }
                catch { return 0; }
            }
            set { txt_CQTHT.Text = value.ToString(); }
        }
        public double CFTA
        {
            get
            {
                try { return Convert.ToDouble(txt_CFTA.Text); }
                catch { return 0; }
            }
            set { txt_CFTA.Text = value.ToString(); }
        }
        public double CFQC
        {
            get
            {
                try { return Convert.ToDouble(txt_CFQC.Text); }
                catch { return 0; }
            }
            set { txt_CFQC.Text = value.ToString(); }
        }
        public double CXRAY
        {
            get
            {
                try { return Convert.ToDouble(txt_CXRay.Text); }
                catch { return 0; }
            }
            set { txt_CXRay.Text = value.ToString(); }
        }
        public double CIPA
        {
            get
            {
                try { return Convert.ToDouble(txt_CIPA.Text); }
                catch { return 0; }
            }
            set { txt_CIPA.Text = value.ToString(); }
        }
        public double CGPA
        {
            get
            {
                try { return Convert.ToDouble(txt_CGPA.Text); }
                catch { return 0; }
            }
            set { txt_CGPA.Text = value.ToString(); }
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_Planned.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_diff"].Value) < 0)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.LightCoral;              
            }

            //foreach (DataGridViewRow row in this.gv_List.Rows)
            //{
            //    if (Convert.ToDouble(row.Cells["cn_diff"].Value) < 0)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.LightCoral;
            //    else if (Convert.ToDouble(row.Cells["cn_diffafter"].Value) <= 0)
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.Gainsboro;
            //    else
            //        foreach (DataGridViewCell cell in row.Cells)
            //            cell.Style.BackColor = Color.White;
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
            try
            {
                bs_List.RemoveFilter();
                bs_Planned.RemoveFilter();
            }
            catch { }

            var data = Plan_BLL.getProjectPlanning(cmb_Firms1.FirmId, Convert.ToInt32(txt_Perc.Text));

            DataRow[] datacr = data.Select("plannedqty = 0 and diff > 0");
            DataRow[] datar = data.Select("plannedqty > 0");

            //try
            //{
            DataTable datapr = null;
            if (datacr.Any())
                datapr = datacr.CopyToDataTable();
            DataTable datap = null;
            if (datar.Any())
                datap = datar.CopyToDataTable();
            //}
            //catch { }     

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);
                
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = datapr;
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

            //Filling stages
            DataTable databatches = new DataTable();
            databatches.Columns.Add("batchid", typeof(int));
            databatches.Columns.Add("qty", typeof(long));
            databatches.Columns.Add("dateoper", typeof(DateTime));

            DateTime dateof = System.DateTime.Now.AddDays(Convert.ToInt32(txt_Capa.Text) * 7);
            DataRow[] datab = data.Select("plannedqty > 0 and dateofweek < '" + dateof + "'");

            foreach (DataRow row in datab)
            {
                DataRow dr = databatches.NewRow();
                dr["batchid"] = Convert.ToInt32(row["batchid"]);
                dr["qty"] = Convert.ToInt32(row["plannedqty"]);
                dr["dateoper"] = Convert.ToDateTime(row["dateofweek"]);
                databatches.Rows.Add(dr);
            }

            ShowCapacity(Convert.ToInt32(txt_Capa.Text), databatches);
        }

        public void ShowCapacity(int weekoper, DataTable databatches)
        {
            var data = Plan_BLL.getProjectPlanningCapa(weekoper, databatches);

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
            bwStart(bw_List);
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
            SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
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
            //SetCellsColor();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            string _week = "";
            double _qty = 0;
            try {
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
                    PlanBll.AddBatchPlanning(frm.BatchId, frm.Qty, frm.PlanDate);
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
            LoadColumns(gv_List);
            LoadColumns(gv_Planned);
        }

        private void gv_Planned_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_Excel1_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }

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
    }
}
