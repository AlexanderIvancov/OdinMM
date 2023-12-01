using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Workshop
{
    public partial class frm_Capacity : KryptonForm
    {
        public frm_Capacity()
        {
            InitializeComponent();
        }

        #region Variables


        private ProgressForm progress;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Processing_BLL ProcBll = new Processing_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();

        public double TotalByDate
        {
            get { try { return Convert.ToDouble(txt_Total.Text); }
                catch { return 0; } }
            set { txt_Total.Text = value.ToString(); }
        }

        public int TypeSelection
        {
            get {
                if (rb_all.Checked == true)
                    return 1;
                else if (rb_production.Checked == true)
                    return 0;
                else
                    return -1;             
            }
        }
        #endregion

        #region Methods

        public void FillDates()
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

            //var data = Processing_BLL.getStages(cmb_Common1.SelectedValue);
            var data = Processing_BLL.getShifts(cmb_Common1.SelectedValue, cmb_Common2.SelectedValue, cmb_Common3.SelectedValue, TypeSelection);


            foreach (DataRow row in data.Rows)
            {
                InsertRow(Convert.ToInt32(row["id"]), row["stage"].ToString());
            }

            //var data1 = Processing_BLL.getCapacity(cmb_Common1.SelectedValue, Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString());
            var data1 = Processing_BLL.getCapacityShifts(cmb_Common1.SelectedValue, Convert.ToDateTime(txt_From.Value).ToShortDateString(), 
                                            Convert.ToDateTime(txt_Till.Value).ToShortDateString(), cmb_Common2.SelectedValue, cmb_Common3.SelectedValue);


            foreach (DataRow row in data1.Rows)
            {
                foreach (DataGridViewRow rowc in gv_List.Rows)
                {
                    if (row["stage"].ToString() == rowc.Cells[0].Value.ToString())
                    {
                        //update row
                        UpdateRow(rowc, row["date"].ToString(), row["qty"].ToString());
                    }
                }
            }
        }

        private void bw_Operations(object sender, DoWorkEventArgs e)
        {
            gv_List.ThreadSafeCall(delegate
            {
                FillDates();  
            });
        }

        private void InsertRow(int stageid, string headerrow)
        {
            int rownumber = gv_List.Rows.Add();

            gv_List.Rows[rownumber].Cells[0].Value = headerrow;
            gv_List.Rows[rownumber].Cells[1].Value = stageid;

        }

        private void UpdateRow(DataGridViewRow row, string date, string value)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if ("cn_" + Convert.ToInt32(date.Substring(0, 2)).ToString() + Convert.ToInt32(date.Substring(3, 2)).ToString() + date.Substring(6, 4) == cell.OwningColumn.Name/*HeaderText*/)
                {
                    cell.Value = value;
                    break;
                }
            }
        }

        public void RecalcTotal()
        {
            double _res = 0;
            int k = gv_List.CurrentCell.ColumnIndex;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _res = _res + Convert.ToDouble(row.Cells[k].Value);
            }

            TotalByDate = _res;
        }
        #endregion

        #region Controls

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            progress.bwStart(bw_Operations);
        }

        private void frm_Capacity_Load(object sender, EventArgs e)
        {
            progress = new ProgressForm(this);
            txt_Till.Value = DateTime.Now.AddDays(6);
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();

            if (gv_List.CurrentCell.ColumnIndex > 1)
            {
                double number;
                try
                {
                    bool success = Double.TryParse(gv_List.CurrentCell.Value.ToString(), out number);
                    if (success)
                    {
                        //Console.WriteLine("Converted '{0}' to {1}.", value, number);
                    }
                    else
                    {
                        gv_List.CurrentCell.Value = 0;
                        MessageBox.Show("Value must be number!");
                    }
                    RecalcTotal();
                }
                catch { }
                
            }
            
            //if (gv_List.CurrentCell.Value)
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            gv_List.EndEdit();

            btn_OK.Focus();

            DataTable datastages = new DataTable();
            datastages.Columns.Add("stageid", typeof(int));
            datastages.Columns.Add("qty", typeof(double));
            datastages.Columns.Add("date", typeof(DateTime));

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                DataRow dr1 = datastages.NewRow();
                dr1["stageid"] = Convert.ToInt32(row.Cells[1].Value);
                dr1["qty"] = Convert.ToDouble(0);
                dr1["date"] = Convert.ToDateTime(txt_From.Value).ToShortDateString();
                datastages.Rows.Add(dr1);


                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null
                        && cell.Value.ToString() != "0"
                        && cell.Value.ToString() != ""
                        && cell.ColumnIndex > 1)
                    {
                        //MessageBox.Show(cell.OwningColumn.HeaderText);
                        try
                        {
                            DataRow dr = datastages.NewRow();
                            dr["stageid"] = Convert.ToInt32(row.Cells[1].Value);
                            dr["qty"] = Convert.ToDouble(cell.Value);
                            dr["date"] = cell.OwningColumn.HeaderText;
                            datastages.Rows.Add(dr);
                        }
                        catch { }
                    }
                }
                
            }

            //ProcBll.SaveCapacity(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString(), datastages);
            ProcBll.SaveCapacityShift(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString(), datastages);

        }

        #endregion

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_List.CurrentCell.ColumnIndex > 1)
            {
                RecalcTotal();
            }
        }
    }
}
