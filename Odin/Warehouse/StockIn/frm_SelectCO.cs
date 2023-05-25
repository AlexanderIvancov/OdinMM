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
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.Warehouse.StockIn
{
    public delegate void COSelectionEventHandler(DataGridView colist);

    public partial class frm_SelectCO : KryptonForm
    {
        public frm_SelectCO()
        {
            InitializeComponent();
        }

        #region Variables

        public event COSelectionEventHandler COSelected;
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        DataGridViewRow rowm;
        public int BatchId
        { get; set; }
        #endregion

        #region Methods

        public void FillCO(int _batchid)
        {
            var data = StockIn_BLL.getBatchCONotIn(_batchid);


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
                
            }

        }


        #endregion

        #region Controls

        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && COSelected != null)
                COSelected(this.gv_List);

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
            //gv_List.EndEdit();
            //gv_List.ThreadSafeCall(delegate
            //{
            //    int k = 0;

            //    foreach (DataGridViewRow row in this.gv_List.Rows)
            //    {
            //        if (row.Cells["chk_add"].Value != DBNull.Value
            //        && Convert.ToInt16(row.Cells["chk_add"].Value) != 0)
            //        {
            //            k++;
            //        }
            //    }

            //    //MessageBox.Show(String.IsNullOrEmpty(bs_List.Filter).ToString());
            //    if (k == 0)
            //    {
            //        bs_List.RemoveFilter();
            //    }
            //    else
            //    {
            //        bs_List.Filter = "batchid = " + batchid;
            //    }

            //    SetCellsColor();
            //});
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
                //FilterByBatch(Convert.ToInt32(rowm.Cells["cn_batchid"].Value));
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
