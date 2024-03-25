using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Warehouse.StockIn
{
    public delegate void BoxSelectionEventHandler(int boxid, DataGridView boxeslist);

    public partial class frm_SelectBox : KryptonForm
    {
        public frm_SelectBox()
        {
            InitializeComponent();
        }

        #region Variables

        public event BoxSelectionEventHandler BoxSelected;
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        DataGridViewRow rowm;

        #endregion

        #region Methods

        public void FillBoxes()
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectBoxesNotPlaced");


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
                SetCellsColor();
            });

            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public void FillBoxesNotMapped(int _idin)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_SelectBoxesNotMapped", _idin);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
                SetCellsColor();
            });

            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public void SetCellsColor()
        {
            //Proverjaem labels - est li v partii takie artikli
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_closed"].Value) == -1)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                //if (Convert.ToInt32(row.Cells["cn_bdid"].Value) == 0
                //    || ((row.Cells["cn_batch"].Value.ToString().Trim() != ""
                //    || string.IsNullOrEmpty(row.Cells["cn_batch"].Value.ToString().Trim()) != true)
                //    && row.Cells["cn_batch"].Value.ToString().ToUpper() != Batch.ToUpper()))
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.LightCoral;
                //else
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.FromArgb(192, 255, 192);

            }

        }


        #endregion

        #region Controls

        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int _packid = 0;
            try { _packid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }
            if (Convert.ToDouble(gv_List.CurrentRow.Cells[10].Value) <= 0) { MessageBox.Show("Error! Weight net of box is 0!"); this.Close(); }
                
            if (_packid != 0
                && BoxSelected != null)
                BoxSelected(_packid, this.gv_List);

            this.Close();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //int _packid = 0;
            //try { _packid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            //catch { }
            //if (_packid != 0
            //   && BoxSelected != null)
            //    BoxSelected(_packid, this.gv_List);

            //this.Close();
        }

        public void FilterByBatch(int batchid)
        {
            gv_List.EndEdit();
            gv_List.ThreadSafeCall(delegate
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

                //MessageBox.Show(String.IsNullOrEmpty(bs_List.Filter).ToString());
                if (k == 0)
                {
                    bs_List.RemoveFilter();
                }
                else
                {
                    bs_List.Filter = "batchid = " + batchid;
                }

                SetCellsColor();
            });
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

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //rowm = gv_List.CurrentRow;
            if (rowm.Cells["chk_add"].Selected == true)
            {
                gv_List.EndEdit();
                FilterByBatch(Convert.ToInt32(rowm.Cells["cn_batchid"].Value));
            }
        }

        private void gv_List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (rowm.Cells["chk_add"].Selected == true
            //    && Convert.ToInt32(rowm.Cells["chk_add"].Value) == -1)
            //{
                //FilterByBatch(Convert.ToInt32(rowm.Cells["cn_batchid"].Value));
            //}
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
