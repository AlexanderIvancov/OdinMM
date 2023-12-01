using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public partial class frm_ProductivityIndicator : BaseForm
    {
        public frm_ProductivityIndicator()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
            ED = new ExportData(this.gv_List, "ProductivityIndicator.xls", this.Name);
        }

        #region Variables
        ExportData ED;

        PopupWindowHelper PopupHelper = null;
        class_Global glob_Class = new class_Global();

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public ctl_ProductivityChart ctlChart = null;
        public int ControlWidth = 2000;

        //public DataTable dataindic;


        #endregion

        #region Pages

        private KryptonPage NewPage(string name, int image, Control content, int _Width)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name;
            p.TextTitle = name;
            p.TextDescription = name;
            p.ImageSmall = imageListSmall.Images[image];
            
            //p.Width = _Width;

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            return p;
        }

        private KryptonPage NewInputChart(/*DataTable datasource*/)
        {            

            ctlChart = new ctl_ProductivityChart();

            ctlChart.FillData(productivity1.ProductivityDataTable);
            ctlChart.Refresh();
            ControlWidth = ctlChart.Width;
            
            return NewPage("Charting", 1, ctlChart, ctlChart.Width);
        }

        public void FindChartPages()
        {
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_ProductivityChart ctlChart1 = (ctl_ProductivityChart)page.Controls.Find("ctl_ProductivityChart", true).FirstOrDefault();
                if (ctlChart1 != null)
                {

                    ctlChart1.ThreadSafeCall(delegate { ctlChart1.FillData(productivity1.ProductivityDataTable); }) ;
                }
                
            }
        }

        #endregion

        #region Methods

        public void FillChart()
        {
            kryptonPanel1.ThreadSafeCall(delegate { RemoveControls(this, typeof(ctl_ProductivityChart)); });

            ctlChart = new ctl_ProductivityChart();
            ctlChart.ThreadSafeCall(delegate { ctlChart.FillData(productivity1.ProductivityDataTable); });
            kryptonPanel1.ThreadSafeCall(delegate { kryptonPanel1.Controls.Add(ctlChart); });

            //ctl_ProductivityChart1.ThreadSafeCall(delegate { ctl_ProductivityChart1.FillData(productivity1.ProductivityDataTable); });
        }
        public void FillDates()
        {
            productivity1.Clear();

            //Stages
            gv_List.Columns.Clear();

            var col = new DataGridViewTextBoxColumn();

            col.Name = "cn_stage";
            col.HeaderText = "Stage";
            col.Frozen = true;
            col.Visible = true;
            col.Width = 100;

            gv_List.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();

            col.Name = "cn_total";
            col.HeaderText = "Total (%)";
            col.Frozen = true;
            col.Visible = true;
            col.Width = 80;

            gv_List.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();

            col.Name = "cn_stageid";
            col.HeaderText = "StageId";
            col.Visible = false;
            col.Width = 100;

            gv_List.Columns.Add(col);

            //Weeks
            var dataweeks = DAL_Functions.getWeeks(txt_From.Text.Trim() == "" ? System.DateTime.Now.AddYears(-1).ToShortDateString() : txt_From.Text, 
                                                txt_Till.Text.Trim() == "" ? System.DateTime.Now.AddYears(1).ToShortDateString() : txt_Till.Text);

            foreach (DataRow row in dataweeks.Rows)
            {
                col = new DataGridViewTextBoxColumn();
                col.Name = "cn_" + row["week"].ToString();
                col.HeaderText = row["week"].ToString();
                col.Visible = true;
                col.Width = 80;

                gv_List.Columns.Add(col);

            }

            var data = Processing_BLL.getStages(0);

            foreach (DataRow row in data.Rows)
            {
                InsertRow(Convert.ToInt32(row["id"]), row["stage"].ToString());
            }

            //Summas
            var datasum = Processing_BLL.getProductivityIndicatorSum(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString());
            foreach (DataRow row in datasum.Rows)
            {
                foreach (DataGridViewRow rowc in gv_List.Rows)
                {
                    if (row["stage"].ToString() == rowc.Cells[0].Value.ToString())
                    {
                        //update row
                        rowc.Cells["cn_total"].Value = row["percentage"].ToString();
                        //if (Convert.ToDouble(row["percentage"]) < 80)
                        //    rowc.Cells["cn_total"].Style.BackColor = Color.Tomato;

                    }
                }
            }


            var data1 = Processing_BLL.getProductivityIndicator(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString());

            int _rowcount = 1;

            foreach (DataRow row in data1.Rows)
            {
                foreach (DataGridViewRow rowc in gv_List.Rows)
                {
                    if (row["stage"].ToString() == rowc.Cells[0].Value.ToString())
                    {
                        //update row
                        UpdateRowWeek(rowc, row["proddate"].ToString(), row["percentage"].ToString());
                    }
                }
                DataRow rowprod = productivity1.ProductivityDataTable.NewRow();
                rowprod["Stage"] = row["stage"];
                rowprod["Week"] = row["proddate"].ToString();
                rowprod["Percentage"] = row["percentage"];
                rowprod["Id"] = _rowcount;
                rowprod["realtime"] = row["realtime"].ToString();
                rowprod["capacitytime"] = row["capacitytime"].ToString();
                rowprod["legend"] = row["legend"].ToString();

                _rowcount++;

                productivity1.ProductivityDataTable.Rows.Add(rowprod);
            }

            txt_Tufta.Text = "61.5 %";
        }

        public void FillDatesOld()
        {
            //Stages
            gv_List.Columns.Clear();

            var col = new DataGridViewTextBoxColumn();

            col.Name = "cn_stage";
            col.HeaderText = "Stage";
            col.Frozen = true;
            col.Visible = true;
            col.Width = 100;

            gv_List.Columns.Add(col);
            
            col = new DataGridViewTextBoxColumn();

            col.Name = "cn_total";
            col.HeaderText = "Total (%)";
            col.Frozen = true;
            col.Visible = true;
            col.Width = 80;

            gv_List.Columns.Add(col);
            
            col = new DataGridViewTextBoxColumn();

            col.Name = "cn_stageid";
            col.HeaderText = "StageId";
            col.Visible = false;
            col.Width = 100;

            gv_List.Columns.Add(col);

            //Dates

            for (DateTime d = Convert.ToDateTime(txt_From.Value); d <= Convert.ToDateTime(txt_Till.Value); d = d.AddDays(1))
            {
                col = new DataGridViewTextBoxColumn();

                col.Name = "cn_" + d.Day.ToString() + d.Month.ToString() + d.Year.ToString();
                col.HeaderText = d.ToShortDateString();
                col.Visible = true;
                col.Width = 80;

                if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday)
                {
                    //col.HeaderCell.Style.BackColor = Color.Red;
                    col.HeaderCell.Style.ForeColor = Color.Red;
                    //col.HeaderText.
                }
                gv_List.Columns.Add(col);
            }

            var data = Processing_BLL.getStages(0);

            foreach (DataRow row in data.Rows)
            {
                InsertRow(Convert.ToInt32(row["id"]), row["stage"].ToString());
            }

            //Summas
            var datasum = Processing_BLL.getProductivityIndicatorSum(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString());
            foreach (DataRow row in datasum.Rows)
            {
                foreach (DataGridViewRow rowc in gv_List.Rows)
                {
                    if (row["stage"].ToString() == rowc.Cells[0].Value.ToString())
                    {
                        //update row
                        rowc.Cells["cn_total"].Value = row["percentage"].ToString();
                        //if (Convert.ToDouble(row["percentage"]) < 80)
                        //    rowc.Cells["cn_total"].Style.BackColor = Color.Tomato;

                    }
                }
            }


            var data1 = Processing_BLL.getProductivityIndicator(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString());


            foreach (DataRow row in data1.Rows)
            {
                foreach (DataGridViewRow rowc in gv_List.Rows)
                {
                    if (row["stage"].ToString() == rowc.Cells[0].Value.ToString())
                    {
                        //update row
                        UpdateRow(rowc, row["proddate"].ToString(), row["percentage"].ToString());
                    }
                }
            }
        }

        private void InsertRow(int stageid, string headerrow)
        {
            int rownumber = gv_List.Rows.Add();

            gv_List.Rows[rownumber].Cells[0].Value = headerrow;
            gv_List.Rows[rownumber].Cells[2].Value = stageid;

        }

        private void UpdateRow(DataGridViewRow row, string date, string value)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if ("cn_" + Convert.ToInt32(date.Substring(0, 2)).ToString() + Convert.ToInt32(date.Substring(3, 2)).ToString() + date.Substring(6, 4) == cell.OwningColumn.Name/*HeaderText*/)
                {
                    cell.Value = value;
                    //if (Convert.ToDouble(value) < 80)
                    //    cell.Style.BackColor = Color.Tomato;
                    break;
                }
            }
        }

        private void UpdateRowWeek(DataGridViewRow row, string date, string value)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if ("cn_" + date == cell.OwningColumn.Name/*HeaderText*/)
                {
                    cell.Value = value;
                    //if (Convert.ToDouble(value) < 100)
                    //    cell.Style.BackColor = Color.Tomato;
                    break;
                }
            }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            gv_List.ThreadSafeCall(delegate
            {
                FillDates();
            });
            FillChart();
            //FindChartPages();
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv, bool IgnoreHideColumns = true)
        {
            //var dt = new DataTable();
            //foreach (DataGridViewColumn column in dgv.Columns)
            //{
            //    if (column.Visible)
            //    {
            //        // You could potentially name the column based on the DGV column name (beware of dupes)
            //        // or assign a type based on the data type of the data bound to this DGV column.
            //        dt.Columns.Add();
            //    }
            //}

            //object[] cellValues = new object[dgv.Columns.Count];
            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    for (int i = 0; i < row.Cells.Count; i++)
            //    {
            //        cellValues[i] = row.Cells[i].Value;
            //    }
            //    dt.Rows.Add(cellValues);
            //}

            //return dt;
            //try
            //{
                if (dgv.ColumnCount == 0) return null;
                DataTable dtSource = new DataTable();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (IgnoreHideColumns & !col.Visible) continue;
                    if (col.Name == string.Empty) continue;
                    dtSource.Columns.Add(col.Name);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                if (dtSource.Columns.Count == 0) return null;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            //}
            //catch { return null; }
        }

        #endregion

        #region Controls
        private void frm_ProductivityIndicator_Load(object sender, EventArgs e)
        {
            //KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            //kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            //kryptonDockingManager1.ManageFloating(this);

            var date = DateTime.Now.AddDays(-14);
            var difference = date.DayOfWeek - DayOfWeek.Monday;
            if (difference < 0)
                difference += 7;
            var mondayDate = date.AddDays(-1 * difference).Date;



            txt_From.Value = mondayDate;//DateTime.Now.AddDays(-14);
            



            txt_Till.Value = DateTime.Now;

            //bwStart(bw_List);

            //FillChart();
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_From.Value = DateTime.Now.AddDays(-14);
            txt_Till.Value = DateTime.Now;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            bwStart(bw_List);
        }


        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Open additional information about stages, capacity and batches
            if (e.ColumnIndex > 1)
            {

                int _stageid = 0;
                string _date = "";
                try
                {

                    _stageid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value);
                    _date = gv_List.CurrentCell.OwningColumn.HeaderText;
                }
                catch { }

                if (_stageid != 0)
                {
                    //if (glob_Class.IsFormAlreadyOpen("frm_ProductivityDets")) return;
                    if (glob_Class.IsFormAlreadyOpen("frm_ProductivityDets"))
                    {
                        frm_ProductivityDets obj = (frm_ProductivityDets)Application.OpenForms["frm_ProductivityDets"];
                        obj.Close();
                    }

                    frm_ProductivityDets popup = new frm_ProductivityDets();
                    popup.ctl_ProductivityDets1.StageId = _stageid;
                    popup.ctl_ProductivityDets1.cmb_Week1.Week = _date;
                    popup.ctl_ProductivityDets1.DateFrom = Convert.ToDateTime(txt_From.Value).ToShortDateString();
                    popup.ctl_ProductivityDets1.DateTill = Convert.ToDateTime(txt_Till.Value).ToShortDateString();
                    popup.ctl_ProductivityDets1.FillHistory();
                    popup.Show();
                    popup.ctl_ProductivityDets1.gv_List.ThreadSafeCall(delegate { popup.ctl_ProductivityDets1.SetCellsColor(); });

                    //Form f;
                    //f = this.FindForm();

                    //Point LocationPoint = gv_List.PointToScreen(Point.Empty);
                    //int xpos = LocationPoint.X + 100;
                    //int ypos = LocationPoint.Y;
                    //Point _location = new Point(xpos, ypos);

                    //frm_ProductivityDets popup = new frm_ProductivityDets();

                    //PopupHelper.ClosePopup();

                    //PopupHelper.ShowPopup(f, popup, _location);

                    //PopupHelper.PopupCancel += delegate (object _sender, PopupCancelEventArgs _e)
                    //{
                    //    if (popup.ShowingModal)
                    //    {
                    //        _e.Cancel = true;
                    //    }
                    //};
                    //popup.ctl_ProductivityDets1.StageId = _stageid;
                    ////popup.ctl_ProductivityDets1.txt_Date.Value = Convert.ToDateTime(_date);
                    //popup.ctl_ProductivityDets1.cmb_Week1.Week = _date;
                    //popup.ctl_ProductivityDets1.FillHistory();
                }
            }
        }


        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        #endregion

        private void txt_From_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_From.Value = txt_From.Value == null ? System.DateTime.Now : txt_From.Value;
        }

        private void txt_Till_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_Till.Value = txt_Till.Value == null ? System.DateTime.Now : txt_Till.Value;
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
          
            //kryptonDockingManager1.AddDockspace("Control",
            //                                 DockingEdge.Left,
            //                                 new KryptonPage[] { NewInputChart(/*GetDataTableFromDGV(gv_List)*/) });
        }

        private void frm_ProductivityIndicator_Resize(object sender, EventArgs e)
        {
            if (_frm_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });

                }
            }
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            //e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void RemoveControls(Control control, Type type)
        {
            List<Control> controls = new List<Control>();
            Stack<Control> stack = new Stack<Control>();
            stack.Push(control);
            while (stack.Count > 0)
                foreach (Control child in stack.Pop().Controls)
                    if (child.GetType() == type)
                        controls.Add(child);
                    else
                        if (true == child.HasChildren)
                        stack.Push(child);

            foreach (Control ctrl in controls)
            {
                control.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
        }

        private void txt_From_ValueChanged(object sender, EventArgs e)
        {
            txt_From.Value = txt_From.Value == null ? System.DateTime.Now : txt_From.Value;
        }

        private void txt_Till_ValueChanged(object sender, EventArgs e)
        {
            txt_Till.Value = txt_Till.Value == null ? System.DateTime.Now : txt_Till.Value;
        }
    }
}
