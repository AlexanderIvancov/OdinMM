using ComponentFactory.Krypton.Toolkit;
using System;

namespace Odin.Warehouse.StockOut
{
    public partial class frm_SetManagement : KryptonForm
    {
        public frm_SetManagement()
        {
            InitializeComponent();
        }

        #region Variables

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public double Qty
        {
            get { try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value;}
        }

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int PlaceId
        {
            get { return cmb_Places1.PlaceId; }
            set { cmb_Places1.PlaceId = value; }
        }

        #endregion

        #region Methods

        public void CheckEmpty()
        {
            btn_OK.Enabled = cmb_Articles1.ArticleId != 0
                && cmb_Places1.PlaceId != 0
                && Qty > 0;
        }

        #endregion

        #region Control

        #endregion

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            Unit = cmb_Articles1.Unit;
            CheckEmpty();
        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void cmb_Places1_SelectedValueChanged(object sender)
        {
            CheckEmpty();
        }

        private void cmb_Batches1_BatchChanged(object sender)
        {
            ArtId = cmb_Batches1.ArticleId;
        }
    }
}
