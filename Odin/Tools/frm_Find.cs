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
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;

namespace Odin.Tools
{
    public partial class frm_Find : KryptonForm
    {
        public frm_Find()
        {
            InitializeComponent();
        }
        int row = 0;
        int cell = 0;
        int rowByColumn = 0;
        string entireTable = "Entire table";
        private string recordNotFound = "The record is not found";
        private const string ready = "Ready";
        private const string findNext = "Find next";
        private const string looking = "Looking for record...";
        private const string cancel = "Cancel";
        private bool isEnitreTable = true;


        public DataGridView grid
        {
            get;
            set;
        }

        public string ColumnText
        {
            get;
            set;
        }


        public int ColumnNumber
        {
            get;
            set;
        }

        public DataTable SearchDataTable()
        {
            DataTable data = new DataTable();
            data.Columns.Add(new DataColumn("FilterData", typeof(string)));
            data.Columns.Add(new DataColumn("Id", typeof(int)));

            data.Rows.Add(data.NewRow());
            data.Rows.Add(data.NewRow());

            data.Rows[0][0] = ColumnText;
            data.Rows[0][1] = ColumnNumber;
            data.Rows[1][0] = entireTable;
            data.Rows[1][1] = -1;

            return data;
        }

        private string search = string.Empty;
        

        private void frm_Find_Load(object sender, EventArgs e)
        {
            cmb_LookIn.DataSource = SearchDataTable();
            cmb_LookIn.DisplayMember = "FilterData";
            cmb_LookIn.ValueMember = "Id";
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {

            if (bw_Find.IsBusy)
            {
                btn_Find.Enabled = false;
                toolStripProgressBar.Visible = false;

                bw_Find.CancelAsync();
            }
            else
            {
                btn_Find.Text = cancel;
                lbl_Status.Text = looking;
                toolStripProgressBar.Visible = true;

                if (!string.IsNullOrEmpty(txt_Search.Text))
                {
                    if (Convert.ToInt32(cmb_LookIn.SelectedValue) == -1)
                    {
                        isEnitreTable = true;
                    }
                    else
                    {
                        isEnitreTable = false;
                    }

                    bw_Find.RunWorkerAsync();
                }


            }
        }

        private void SearchByColumn(DoWorkEventArgs e)
        {
            bool isFound = false;
            if (search != txt_Search.Text)
            {
                search = txt_Search.Text;
                rowByColumn = 0;
            }

            for (int i = rowByColumn; i < grid.RowCount; i++)
            {

                if (rb_Start.Checked)
                {
                    if (grid[ColumnNumber, i].FormattedValue.ToString().ToUpper().StartsWith(txt_Search.Text.Trim().ToUpper()))
                    {
                        isFound = true;

                        grid.ThreadSafeCall(delegate
                        {
                            SelectCell(i);
                            btn_Find.Text = findNext;
                        });

                        return;
                    }
                }

                if (rb_Any.Checked)
                {
                    if (grid[ColumnNumber, i].FormattedValue.ToString().ToUpper().Contains(txt_Search.Text.Trim().ToUpper()))
                    {
                        isFound = true;

                        grid.ThreadSafeCall(delegate
                        {
                            SelectCell(i);
                            btn_Find.Text = findNext;
                        });


                        return;
                    }
                }

                if (rb_Whole.Checked)
                {
                    if (grid[ColumnNumber, i].FormattedValue.ToString().ToUpper().Equals(txt_Search.Text.Trim().ToUpper()))
                    {
                        isFound = true;
                        grid.ThreadSafeCall(delegate
                        {
                            SelectCell(i);
                            btn_Find.Text = findNext;
                        });

                        return;
                    }
                }


                if (i == grid.RowCount - 1)
                {
                    if (rowByColumn == 0 && !isFound)
                    {
                        MessageBox.Show(recordNotFound);
                    }
                    rowByColumn = 0;
                }

                if (bw_Find.CancellationPending)
                {

                    e.Cancel = true;
                    return;
                }
            }
        }

        private void SelectCell(int i)
        {
            grid.CurrentCell = grid[ColumnNumber, i];
            // if reached last row in the datagridview
            if (i == grid.RowCount - 1)
            {
                rowByColumn = 0;
            }
            else
            {

                rowByColumn = i + 1;
            }
        }

        private void SearchEntireTable(DoWorkEventArgs e)
        {
            bool isFound = false;
            txt_Search.ThreadSafeCall(delegate
            {
                if (search != txt_Search.Text)
                {
                    search = txt_Search.Text;
                    row = 0;
                    cell = 0;
                }
            });


            for (int i = row; i < grid.RowCount; i++)
            {
                for (int c = cell; c < grid.Rows[i].Cells.Count; c++)
                {
                    if (rb_Start.Checked)
                    {
                        if (grid[c, i].FormattedValue.ToString().ToUpper().StartsWith(txt_Search.Text.Trim().ToUpper()))
                        {
                            isFound = true;
                            grid.ThreadSafeCall(delegate
                            {
                                SelectCellEntireTable(i, c);
                            });
                            return;
                        }
                    }

                    if (rb_Any.Checked)
                    {
                        if (grid[c, i].FormattedValue.ToString().ToUpper().Contains(txt_Search.Text.Trim().ToUpper()))
                        {
                            isFound = true;
                            grid.ThreadSafeCall(delegate
                            {
                                SelectCellEntireTable(i, c);
                            });
                            return;
                        }
                    }

                    if (rb_Whole.Checked)
                    {
                        if (grid[c, i].FormattedValue.ToString().ToUpper().Equals(txt_Search.Text.Trim().ToUpper()))
                        {
                            isFound = true;
                            grid.ThreadSafeCall(delegate
                            {
                                SelectCellEntireTable(i, c);
                            });
                            return;
                        }
                    }


                    if (c == grid.Rows[i].Cells.Count - 1)
                    {
                        if (i == grid.RowCount - 1)
                        {
                            if (row == 0 && !isFound)
                            {
                                MessageBox.Show(recordNotFound);
                            }

                            row = 0;
                            cell = 0;
                        }
                        else
                        {
                            cell = 0;
                        }
                    }

                    if (bw_Find.CancellationPending)
                    {

                        e.Cancel = true;
                        return;
                    }
                }
            }

        }

        private void SelectCellEntireTable(int i, int c)
        {
            grid.CurrentCell = grid[c, i];

            // if reached last cell in the row
            if (c == grid.Rows[i].Cells.Count - 1)
            {
                // if reached last row in the datagridview
                if (i == grid.RowCount - 1)
                {
                    row = 0;
                    cell = 0;
                }
                else
                {

                    row = i + 1;
                    cell = 0;
                }

            }
            else
            {
                row = i;
                cell = c + 1;
            }
        }

        private void bw_Find_DoWork(object sender, DoWorkEventArgs e)
        {
            if (isEnitreTable)
            {
                SearchEntireTable(e);
            }
            else
            {
                SearchByColumn(e);
            }

        }

        private void bw_Find_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_Find.Text = findNext;
            btn_Find.Enabled = true;
            toolStripProgressBar.Visible = false;
                   

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                return;
            }

            if (e.Cancelled)
            {
                btn_Find.Text = findNext;
                lbl_Status.Text = ready;
            }
            else
            {
                lbl_Status.Text = ready;
                toolStripProgressBar.Visible = false;
            }
        }

        private void rb_Start_CheckedChanged(object sender, EventArgs e)
        {
            ResetCells();
        }

        private void ResetCells()
        {
            row = 0;
            cell = 0;
            rowByColumn = 0;
        }

        private void rb_Any_CheckedChanged(object sender, EventArgs e)
        {
            ResetCells();
        }

        private void rb_Whole_CheckedChanged(object sender, EventArgs e)
        {
            ResetCells();
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Search.Text = string.Empty;
        }
    }
}
