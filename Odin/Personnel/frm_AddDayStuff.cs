using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Odin.Personnel
{
    public partial class frm_AddDayStuff : KryptonForm
    {
        public frm_AddDayStuff()
        {
            InitializeComponent();
        }

        #region Variables

        Personnel_BLL PerBLL = new Personnel_BLL();

        #endregion

        #region Methods
        public void FillDates()
        {
            //Stages
            gv_List.Columns.Clear();

            var col = new DataGridViewTextBoxColumn();

            //col.Name = "cn_stage";
            //col.HeaderText = "Stage";
            //col.Frozen = true;
            //col.Visible = true;
            //col.Width = 100;

            //gv_List.Columns.Add(col);

            //col = new DataGridViewTextBoxColumn();

            //col.Name = "cn_stageid";
            //col.HeaderText = "StageId";
            //col.Visible = false;
            //col.Width = 100;

            //gv_List.Columns.Add(col);

            //Dates

            for (DateTime d = Convert.ToDateTime(txt_From.Value); d <= Convert.ToDateTime(txt_Till.Value).AddDays(1); d = d.AddDays(1))
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

            InsertRow();

            var data1 = Personnel_BLL.getDayStaff(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString());

            foreach (DataRow row in data1.Rows)
            {
                foreach (DataGridViewRow rowc in gv_List.Rows)
                {
                    UpdateRow(rowc, row["date"].ToString(), row["qty"].ToString());
                }
            }

            gv_List.ThreadSafeCall(delegate { SetCellsColor(); });
        }

        private void InsertRow()
        {
            int rownumber = gv_List.Rows.Add();
        }

        public void SetCellsColor()
        {
            double _capa = 0;

            DataGridViewRow row = gv_List.CurrentRow;

            foreach (DataGridViewCell cell in row.Cells)
            {
                string _date = cell.OwningColumn.HeaderText;
                double _qty = 0;
                try { _qty = Convert.ToDouble(cell.Value); }
                catch { }

                var param = new List<SqlParameter>
            {
                new SqlParameter("@date", SqlDbType.NVarChar) {Value = _date }

            };

                _capa = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select isnull(sum(cs.qty), 0) as qty " +
                                   " from prod_capacityshifts cs " +
                                   " where cs.date = convert(datetime, @date) ", param.ToArray()));

                cell.Style.BackColor = _qty != _capa ? Color.LightPink : Color.White;
            }
        }
        #endregion

        #region Controls
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            gv_List.ThreadSafeCall(delegate { FillDates(); });
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


        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            DataTable datastages = new DataTable();
            datastages.Columns.Add("stageid", typeof(int));
            datastages.Columns.Add("qty", typeof(double));
            datastages.Columns.Add("date", typeof(DateTime));

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null
                        && cell.Value.ToString() != "0"
                        && cell.Value.ToString() != ""
                        //&& cell.ColumnIndex > 1
                        )
                    {
                        //MessageBox.Show(cell.OwningColumn.HeaderText);
                        try
                        {
                            DataRow dr = datastages.NewRow();
                            dr["stageid"] = 0;
                            dr["qty"] = Convert.ToDouble(cell.Value);
                            dr["date"] = cell.OwningColumn.HeaderText;
                            datastages.Rows.Add(dr);
                        }
                        catch { }
                    }
                }

            }

            //ProcBll.SaveCapacity(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString(), datastages);
            PerBLL.SaveStaffPresence(Convert.ToDateTime(txt_From.Value).ToShortDateString(), Convert.ToDateTime(txt_Till.Value).ToShortDateString(), datastages);
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();

            double _capa = 0;
            DataGridViewCell cell = gv_List.CurrentCell;
            string _date = cell.OwningColumn.HeaderText;
            double _qty = 0;
            try { _qty = Convert.ToDouble(cell.Value); }
            catch { }

            var param = new List<SqlParameter>
            {
                new SqlParameter("@date", SqlDbType.NVarChar) {Value = _date }

            };

            _capa = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select isnull(sum(cs.qty), 0) as qty " +
                               " from prod_capacityshifts cs " +
                               " where cs.date = convert(datetime, @date) ", param.ToArray()));

            cell.Style.BackColor = _qty != _capa ? Color.LightPink : Color.White;

        }
    }
}
