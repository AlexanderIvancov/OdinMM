using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Planning;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Warehouse.Requests
{
    public partial class frm_BatchArticles : Form
    {
        public frm_BatchArticles()
        {
            InitializeComponent();
        }

        public frm_BatchArticles(frm_AddRequestSimple cmb)
        {
            InitializeComponent();
            f = new frm_AddRequestSimple();
            f = cmb;
        }

        frm_AddRequestSimple f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        DAL_Functions DAL = new DAL_Functions();
        Helper MyHelper = new Helper();


        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        #region Methods

        public void FillList(int batchid)
        {
            var data = Plan_BLL.getBatchRM(batchid);

            gv_List.ThreadSafeCall(delegate
            {

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

        }

        #endregion

        #region Methods

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            int _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            string _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
            string _unit = gv_List.CurrentRow.Cells["cn_unit"].Value.ToString();
            int unitid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_unitid"].Value);

            ((frm_AddRequestSimple)frmAddRequestSimple).AddGridRow(_id, _artid, _article, 0, _unit, "", unitid);

            this.Close();
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
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? String.IsNullOrEmpty(CellValue) == true
                        ? "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'"
                    : String.IsNullOrEmpty(CellValue) == true
                        ? bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }


        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'"
                    : bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }


        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }


        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        #endregion

        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _artid = 0;
            string _article;
            string _unit;
            int _unitid;
            foreach (DataGridViewRow row in this.gv_List.SelectedRows)
            {
                _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                _artid = Convert.ToInt32(row.Cells["cn_artid"].Value);
                _article = row.Cells["cn_article"].Value.ToString();
                _unit = row.Cells["cn_unit"].Value.ToString();
                _unitid = Convert.ToInt32(row.Cells["cn_unitid"].Value);

                ((frm_AddRequestSimple)frmAddRequestSimple).AddGridRow(_id, _artid, _article, 0, _unit, "", _unitid);
            }
            this.Close();
        }
    }
}
