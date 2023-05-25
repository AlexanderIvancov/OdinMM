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
    public partial class frm_FillOrders : KryptonForm
    {
        public frm_FillOrders()
        {
            InitializeComponent();
        }

        #region Variables


        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Plan_BLL PlanBll = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        DataGridViewRow rowm;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        int _bpmode = 0;

        public int BPMode
        {
            get { return _bpmode; }
            set { _bpmode = value; }
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {

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

        public void FillOrders(int typeid)
        {
            var data = Plan_BLL.getOrdersForBatches(cmb_Types1.TypeId);
            
            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });
        }

        public void FillOrdersBP(int typeid)
        {
            var data = Plan_BLL.getOrdersForBatchesBP(cmb_Types1.TypeId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });
        }

        #endregion

        #region Controls
        private void cmb_Types1_SelectedValueChanged(object sender)
        {
            FillOrders(cmb_Types1.TypeId);
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

            frm.HeaderText = "Select view for confirmation orders list";
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




        #endregion

        private void frm_FillOrders_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        public void FilterByArticle(int ArtId)
        {
            int k = 0;
                                    
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (row.Cells["chk_add"].Value != DBNull.Value
                && Convert.ToInt16(row.Cells["chk_add"].Value) != 0)
                {
                   k++;
                }
            }

            if (k == 0)
            {
                bs_List.RemoveFilter();
            }
            else
            {
                bs_List.Filter = "artid = " + ArtId;
            }
        }

        public void FilterByCO(int COId, int QuotId)
        {
            int k = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (row.Cells["chk_add"].Value != DBNull.Value
                && Convert.ToInt16(row.Cells["chk_add"].Value) != 0)
                {
                    k++;
                }
            }

            if (k == 0)
            {
                bs_List.RemoveFilter();
            }
            else
            {
                if (COId != 0)
                    bs_List.Filter = "id = " + COId;
                else
                    bs_List.Filter = "quotid = " + QuotId;
            }
        }

        public void FilterByArticleEdit(int ArtId)
        {
            bs_List.RemoveFilter();
            bs_List.Filter = "artid = " + ArtId;
        }

        #endregion

        private void gv_List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (rowm.Cells["chk_add"].Selected == true)
            {
                if (Convert.ToInt32(rowm.Cells["chk_add"].Value) == -1)
                {
                    if (BPMode == 0)
                        FilterByArticle(Convert.ToInt32(rowm.Cells["cn_artid"].Value));
                    else
                        FilterByCO(Convert.ToInt32(rowm.Cells["cn_id"].Value), Convert.ToInt32(rowm.Cells["cn_quotid"].Value));
                }
                else
                    bs_List.RemoveFilter();
            }
            
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rowm.Cells["chk_add"].Selected == true)
            {
                gv_List.EndEdit();
            }
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            rowm = gv_List.CurrentRow;
            gv_List.EndEdit();
            
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            rowm = gv_List.CurrentRow;
        }


    }
}
