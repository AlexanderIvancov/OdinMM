using Odin.Global_Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.Register.Articles
{
    public delegate void AnalogChangesEventHandler(object sender);

    public partial class frm_FindAnalogs : Form
    {
        public frm_FindAnalogs()
        {
            InitializeComponent();
        }
        public frm_FindAnalogs(ctl_BOMSimple cmb)
        {
            InitializeComponent();
            f = new ctl_BOMSimple();
            f = cmb;
        }

        #region Variables

        public event AnalogChangesEventHandler AnalogChanged;

        ctl_BOMSimple f;
        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
        
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        Helper MyHelper = new Helper();
        Reg_BLL Reg = new Reg_BLL();
        frm_AddAnalog frm = null;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int ArtId
        { get; set; }

        public int ArtCSEId
        { get; set; }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                //if (Convert.ToInt32(row.Cells["cn_allowtoreplace"].Value) == 0)
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.Tomato;
                if (!(Convert.ToInt32(row.Cells["chk_valid"].Value) == -1
                        && Convert.ToInt32(row.Cells["cn_productid"].Value) == ArtCSEId))
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Tomato;
            }
        }

        public void FillList()
        {
            var data = Reg.ArticleAnaloguesData(ArtId, ArtCSEId);

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                Helper.RestoreDirection(gv_List, oldColumn, dir);
                SetCellsColor();

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            //int _analogid = 0;

            //try
            //{
            //    _analogid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_analogid"].Value);

            //}
            //catch { }

            //if (_analogid != 0 
            //    && ArtCSEId != 0
            //    && ArtId != 0)
            //{
            //    Reg.AddAnalogToBOM(ArtCSEId, ArtId, _analogid);

            //    AnalogChanged?.Invoke(this);

            //}
            int _analogid = 0;
            int _productid = 0;
            int _valid = 0;

            try
            {
                _analogid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_analogid"].Value);
                _valid = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_valid"].Value);
                _productid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_productid"].Value);
            }
            catch { }

            if (_analogid != 0
                && ArtCSEId != 0
                && ArtCSEId == _productid
                && ArtId != 0
                && _valid == -1)
            {
                Reg.AddAnalogToBOM(ArtCSEId, ArtId, _analogid);

                if (AnalogChanged != null)
                    AnalogChanged(this);

            }
        }



        #endregion

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.ShowingModal = true;

            frm = new frm_AddAnalog();
            if (ArtCSEId != 0)
                frm.ProductId = ArtCSEId;

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                  && ArtId != 0)
            {
                Reg.AddAnalog(ArtId, frm.AnalogId, frm.CustomerId, frm.Comments, frm.ProductId);
                FillList();
            }

            this.ShowingModal = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            this.ShowingModal = true;

            int _id = 0;
            int _analogid = 0;
            int _customerid = 0;
            string _comments = "";
            int _productid = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _analogid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_analogid"].Value);
                _customerid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_customerid"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _productid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_productid"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddAnalog frm = new frm_AddAnalog();
                frm.AnalogId = _analogid;
                frm.CustomerId = _customerid;
                frm.Comments = _comments;
                frm.ProductId = _productid;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Reg.EditAnalog(_id, frm.AnalogId, frm.CustomerId, frm.Comments, frm.ProductId);
                    FillList();
                }
            }
            this.ShowingModal = false;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.ShowingModal = true;

            int _id = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                Reg.DeleteAnalog(_id);
                FillList();
            }

            this.ShowingModal = false;
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_allowtoreplace"].Value) == 0)
            //    btn_OK.Enabled = false;
            //else
            //    btn_OK.Enabled = true;
        }

        private void btn_Valid_Click(object sender, EventArgs e)
        {
            this.ShowingModal = true;

            int _id = 0;

            int _analogid = 0;
            int _customerid = 0;
            string _comments = "";
            int _productid = 0;
            int _valid = 0;
            string _validat = "";
            string _validby = "";

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _analogid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_analogid"].Value);
                _customerid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_customerid"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _productid = ArtCSEId;//Convert.ToInt32(gv_List.CurrentRow.Cells["cn_productid"].Value);
                _valid = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_valid"].Value);
                _validat = gv_List.CurrentRow.Cells["cn_validat"].Value.ToString();
                _validby = gv_List.CurrentRow.Cells["cn_validby"].Value.ToString();
            }
            catch { }

            if (_id != 0)
            {
                frm_MapAnalog frm = new frm_MapAnalog();
                frm.AnalogId = _analogid;
                frm.CustomerId = _customerid;
                frm.Comments = _comments;
                frm.ProductId = _productid;
                frm.Valid = _valid;
                frm.ValidAt = _validat;
                frm.ValidBy = _validby;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Reg.ValidAnalog(ArtId, frm.AnalogId, frm.ProductId, frm.Valid);
                    FillList();
                }
            }
            this.ShowingModal = false;
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _analogid = 0;
            int _customerid = 0;
            string _comments = "";
            int _productid = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _analogid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_analogid"].Value);
                _customerid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_customerid"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _productid = ArtCSEId;//Convert.ToInt32(gv_List.CurrentRow.Cells["cn_productid"].Value);
            }
            catch { }

            if (_id != 0)
            {
                this.ShowingModal = true;

                frm = new frm_AddAnalog();
                frm.ProductId = _productid;
                frm.AnalogId = _analogid;
                frm.CustomerId = _customerid;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                      && ArtId != 0)
                {
                    Reg.AddAnalog(ArtId, frm.AnalogId, frm.CustomerId, frm.Comments, frm.ProductId);
                    FillList();
                }

                this.ShowingModal = false;
            }
        }
    
    }
}
