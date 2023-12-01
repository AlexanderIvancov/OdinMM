using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Odin.Warehouse.Corrections
{
    public delegate void SendLabelQtyEventHandler(int label, double qty, int printlabel);

    public partial class frm_BCCorrection : KryptonForm
    {
        public frm_BCCorrection()
        {
            InitializeComponent();
        }

        #region Variables

        public double QtyOnLabel
        {
            get { return Convert.ToDouble(txt_Qty.Text); }
            set { txt_Qty.Text = value.ToString(); }
        }

        public double QtyInDB
        {
            get { return Convert.ToDouble(txt_QtyInDB.Text); }
            set { txt_QtyInDB.Text = value.ToString(); }
        }

        public string Label
        {
            get { return txt_Label.Text; }
            set { txt_Label.Text = value; }
        }

        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value.ToString(); }
        }

        public event SendLabelQtyEventHandler SendLabelQty;

        #endregion

        #region Methods

        public void ReceiveFocus()
        {
            txt_Qty.Focus();
        }

        #endregion

        #region Controls


        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            if (QtyOnLabel < 0)
                QtyOnLabel = 0;
        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendLabelQty(Convert.ToInt32(Label), QtyOnLabel, chk_PrintLabels.Checked == true ? -1 : 0);
            }
        }


        private void frm_BCCorrection_Load(object sender, EventArgs e)
        {
            ReceiveFocus();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SendLabelQty(Convert.ToInt32(Label), QtyOnLabel, chk_PrintLabels.Checked == true ? -1 : 0);
        }

        #endregion

    }
}
