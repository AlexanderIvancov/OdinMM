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

namespace Odin.Planning
{
    public delegate void SendSerialNumChangesEventHadler(object sender);
    public partial class frm_AddSerialNumbers : KryptonForm
    {
        public frm_AddSerialNumbers()
        {
            InitializeComponent();
        }

        #region Variables

        public event SendSerialNumChangesEventHadler SendChanges;

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        Plan_BLL BLL = new Plan_BLL();

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isok"].Value) != -1)
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.LightCoral;

            }
        }

        public bool CheckQty()
        {
            if (Convert.ToInt32(txt_SerialTill.Text) - Convert.ToInt32(txt_SerialFrom.Text) > Convert.ToInt32(txt_QtyInBatch.Text))
                return false;
            else
                return true;
        }

        public void SetQtyColor()
        {
            if (CheckQty() == false)
                txt_QtyInBatch.StateCommon.Back.Color1 = Color.LightCoral;
            else
                txt_QtyInBatch.StateCommon.Back.Color1 = Color.White;
        }

        #endregion

        #region Controls

        #endregion

        private void btn_Check_Click(object sender, EventArgs e)
        {
            CheckSerialNumbers();            
        }

        public void CheckSerialNumbers()
        {
            try
            {
                var data = Plan_BLL.getSerialNumbersPool(Convert.ToInt32(txt_SerialFrom.Text), Convert.ToInt32(txt_SerialTill.Text));


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
            catch { }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (cmb_Batches1.BatchId != 0
                && Convert.ToInt32(txt_SerialTill.Text) - Convert.ToInt32(txt_SerialFrom.Text) > 0)
            {
                BLL.SaveSerialNumbersPool(cmb_Batches1.BatchId, Convert.ToInt32(txt_SerialFrom.Text), Convert.ToInt32(txt_SerialTill.Text));

                CheckSerialNumbers();

                if (SendChanges != null)
                    SendChanges(this);
            }
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            txt_QtyInBatch.Text = cmb_Batches1.Qty.ToString();
            SetQtyColor();
        }

        private void txt_SerialFrom_TextChanged(object sender, EventArgs e)
        {
            SetQtyColor();
        }

        private void txt_SerialTill_TextChanged(object sender, EventArgs e)
        {
            SetQtyColor();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
