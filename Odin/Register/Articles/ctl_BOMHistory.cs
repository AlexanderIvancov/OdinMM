using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Planning.Controls;
using System.Threading;
using System.Data.SqlClient;
using Odin.Tools;
using Odin.Register.Catalog;


namespace Odin.Register.Articles
{
    public partial class ctl_BOMHistory : UserControl
    {
        public ctl_BOMHistory()
        {
            InitializeComponent();
            ED1 = new ExportData(this.gv_HistoryList, "BOMHistory.xls", this.Name);
        }

        #region Variables
        ExportData ED1;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Reg_BLL Reg = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();

        public int RowIndexH = 0;
        public int ColumnIndexH = 0;
        public string ColumnNameH = "";
        public string CellValueH = "";

        int _artid = 0;
        public int ArtId
        {
            get { return _artid; }
            set {
                _artid = value;
                ShowHistory(_artid);
            }
        }

        public string HeaderText
        {
            get { return kryptonHeaderGroup3.ValuesPrimary.Heading; }
            set { kryptonHeaderGroup3.ValuesPrimary.Heading = value; }
        }

        #endregion

        #region Methods

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

        public void SetCellsHistoryColor()
        {
            foreach (DataGridViewRow row in this.gv_HistoryList.Rows)
            {
                if (row.Cells["cn_typechange"].Value.ToString() == "deleted")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
                }
                else if (row.Cells["cn_typechange"].Value.ToString() == "inserted")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Gold;// Color.FromArgb(192, 255, 192);
                }
                else if (row.Cells["cn_typechange"].Value.ToString() == "valid")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.GreenYellow;
                }
                else if (row.Cells["cn_typechange"].Value.ToString() == "invalid")
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Tomato;
                }
                else
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Plum;
                }
            }
        }

        public void ShowHistory(int artid)
        {
            bs_HistoryList.RemoveFilter();

            var datah = Reg_BLL.getBOMHistory(artid);

            gv_HistoryList.ThreadSafeCall(delegate
            {
                gv_HistoryList.AutoGenerateColumns = false;
                bs_HistoryList.DataSource = datah;
                gv_HistoryList.DataSource = bs_HistoryList;

                SetCellsHistoryColor();
            });


            bn_HistoryList.ThreadSafeCall(delegate
            {
                bn_HistoryList.BindingSource = bs_HistoryList;
            });
        }

        #endregion
        #region Context menu history
        private void mnu_LinesHis_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_HistoryList.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_HistoryList.HitTest(mpoint.X, mpoint.Y);

                RowIndexH = info.RowIndex;
                ColumnIndexH = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_HistoryList.ClearSelection();
                gv_HistoryList.Rows[RowIndexH].Cells[ColumnIndexH].Selected = true;
                gv_HistoryList.CurrentCell = gv_HistoryList.Rows[RowIndexH].Cells[ColumnIndexH];

                CellValueH = gv_HistoryList.Rows[RowIndexH].Cells[ColumnIndexH].Value.ToString();
                ColumnNameH = gv_HistoryList.Columns[ColumnIndexH].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexH = 0;
                ColumnIndexH = 0;
                return;
            }
        }

        private void mni_FilterForHis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_HistoryList.Filter = ("Convert(" + ColumnNameH + " , 'System.String') like '%" + mni_FilterForHis.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            SetCellsHistoryColor();
        }

        private void mni_SearchHis_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_HistoryList;
            frm.ColumnNumber = gv_HistoryList.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_HistoryList.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterByHis_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_HistoryList.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValueH) == true)
                        bs_HistoryList.Filter = "(" + ColumnNameH + " is null OR Convert(" + ColumnNameH + ", 'System.String') = '')";
                    else
                        bs_HistoryList.Filter = "Convert(" + ColumnNameH + " , 'System.String') = '" + glob_Class.NES(CellValueH) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValueH) == true)
                        bs_HistoryList.Filter = bs_HistoryList.Filter + "AND (" + ColumnNameH + " is null OR Convert(" + ColumnNameH + ", 'System.String') = '')";
                    else
                        bs_HistoryList.Filter = bs_HistoryList.Filter + " AND Convert(" + ColumnNameH + " , 'System.String') = '" + glob_Class.NES(CellValueH) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsHistoryColor();
        }

        private void mni_FilterExcludingSelHis_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_HistoryList.Filter) == true)
                    bs_HistoryList.Filter = "Convert(" + ColumnNameH + " , 'System.String') <> '" + CellValueH + "'";
                else
                    bs_HistoryList.Filter = bs_HistoryList.Filter + " AND " + ColumnNameH + " <> '" + CellValueH + "'";
            }
            catch { }
            SetCellsHistoryColor();
        }

        private void mni_RemoveFilterHis_Click(object sender, EventArgs e)
        {
            try
            {
                bs_HistoryList.RemoveFilter();
            }
            catch { }
            SetCellsHistoryColor();
        }

        private void mni_CopyHis_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueH.ToString());
        }

        private void mni_AdminHis_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for bom history list";
            frm.grid = this.gv_HistoryList;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_HistoryList);
            }
        }

        private void btn_HistoryExcel_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }

        #endregion

        #region Controls

        private void gv_HistoryList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsHistoryColor();
        }


        private void ctl_BOMHistory_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_HistoryList);
        }
        #endregion

        private void ctl_BOMHistory_Paint(object sender, PaintEventArgs e)
        {
            SetCellsHistoryColor();
        }
    }
}
