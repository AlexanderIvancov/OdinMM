using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Planning.Controls;
namespace Odin.Planning
{
    public delegate void AnalogChangesEventHandler(object sender);

    public partial class frm_FindBatchAnalogs : Form
    {
        public frm_FindBatchAnalogs()
        {
            InitializeComponent();
        }
        public frm_FindBatchAnalogs(ctl_BatchFreeze cmb)
        {
            InitializeComponent();
            f = new ctl_BatchFreeze();
            f = cmb;
        }

        #region Variables

        public event AnalogChangesEventHandler AnalogChanged;

        ctl_BatchFreeze f;
        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
        
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        Helper MyHelper = new Helper();
        //Reg_BLL Reg = new Reg_BLL();
        //frm_AddAnalog frm = null;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int ArtId
        { get; set; }

        public int ArtCSEId
        { get; set; }

        public string HeadingText
        {
            get { return kryptonHeaderGroup1.ValuesPrimary.Heading; }
            set { kryptonHeaderGroup1.ValuesPrimary.Heading = value; }
        }
        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                //if (Convert.ToInt32(row.Cells["cn_allowtoreplace"].Value) == 0)
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.Tomato;
                //if (!(Convert.ToInt32(row.Cells["chk_valid"].Value) == -1
                //        && Convert.ToInt32(row.Cells["cn_productid"].Value) == ArtCSEId))
                //    foreach (DataGridViewCell cell in row.Cells)
                //        cell.Style.BackColor = Color.Tomato;
            }
        }

        public void FillList()
        {
            var data = Plan_BLL.getRMAnalogs(ArtId, ArtCSEId);

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
            //int _productid = 0;
            //int _valid = 0;
           
            //try
            //{
            //    _analogid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_analogid"].Value);
            //    _valid = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_valid"].Value);
            //    _productid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_productid"].Value);
            //}
            //catch { }

            //if (_analogid != 0 
            //    && ArtCSEId != 0
            //    && ArtCSEId == _productid
            //    && ArtId != 0
            //    && _valid == -1)
            //{
            //    Reg.AddAnalogToBOM(ArtCSEId, ArtId, _analogid);

            //    if (AnalogChanged != null)
            //        AnalogChanged(this);

            //}
        }



        #endregion

       

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_allowtoreplace"].Value) == 0)
            //    btn_OK.Enabled = false;
            //else
            //    btn_OK.Enabled = true;
        }

        private void btn_Valid_Click(object sender, EventArgs e)
        {
            //this.ShowingModal = true;

            //int _id = 0;

            //int _analogid = 0;
            //int _customerid = 0;
            //string _comments = "";
            //int _productid = 0;
            //int _valid = 0;
            //string _validat = "";
            //string _validby = "";

            //try
            //{
            //    _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            //    _analogid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_analogid"].Value);
            //    _customerid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_customerid"].Value);
            //    _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
            //    _productid = ArtCSEId;//Convert.ToInt32(gv_List.CurrentRow.Cells["cn_productid"].Value);
            //    _valid = Convert.ToInt32(gv_List.CurrentRow.Cells["chk_valid"].Value);
            //    _validat = gv_List.CurrentRow.Cells["cn_validat"].Value.ToString();
            //    _validby = gv_List.CurrentRow.Cells["cn_validby"].Value.ToString();
            //}
            //catch { }

            //if (_id != 0)
            //{
            //    frm_MapAnalog frm = new frm_MapAnalog();
            //    frm.AnalogId = _analogid;
            //    frm.CustomerId = _customerid;
            //    frm.Comments = _comments;
            //    frm.ProductId = _productid;
            //    frm.Valid = _valid;
            //    frm.ValidAt = _validat;
            //    frm.ValidBy = _validby;

            //    DialogResult result = frm.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        Reg.ValidAnalog(ArtId, frm.AnalogId, frm.ProductId, frm.Valid);
            //        FillList();
            //    }
            //}
            //this.ShowingModal = false;

        }
    }
}
