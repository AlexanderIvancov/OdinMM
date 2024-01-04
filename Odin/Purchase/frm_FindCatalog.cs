using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Register;
using Odin.Register.Catalog;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Purchase
{
    public partial class frm_FindCatalog : Form
    {
        public frm_FindCatalog()
        {
            InitializeComponent();
        }

        public frm_FindCatalog(ctl_PODets cmb)
        {
            InitializeComponent();
            f = new ctl_PODets();
            f = cmb;
        }

        #region Variables

        ctl_PODets f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        frm_AddCatItem frm = null;

        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        DAL_Functions DAL = new DAL_Functions();
        Helper MyHelper = new Helper();
        Reg_BLL BLL = new Reg_BLL();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int ArtId
        { get; set; }
        public int SupId
        { get; set; }

        #endregion

        #region Methods

        public void ChangeCMBElements()
        {
            int _catid = 0;
            int _artid = 0;
            string _article = "";
            int _unitid = 0;
            double _unitprice = 0;


            try {
                _catid = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;

                _artid = (Int32)gv_List.CurrentRow.Cells["cn_artid"].Value;
                _article = gv_List.CurrentRow.Cells["cn_firmart"].Value.ToString();
                _unitid = (Int32)gv_List.CurrentRow.Cells["cn_unitid"].Value;
                _unitprice = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_unitprice"].Value);
            }
            catch { }

            try {
                if (_catid != 0)
                    ((ctl_PODets)ctlDets).CatId = _catid;
                else
                {
                    ((ctl_PODets)ctlDets).CatId = 0;
                    ((ctl_PODets)ctlDets).FillNotCatalogDets(_artid, _article, _unitid, _unitprice);
                }
            }

            catch { }
        }

        public void FillList(int artid, int supid)
        {
            var data = Reg_BLL.getCatalogArticleSup(artid, supid);

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
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_bargtype"].Value) == 99) //StockIn
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                }
                else if (Convert.ToInt32(row.Cells["cn_bargtype"].Value) == 98) //PO
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Yellow;
                    }
                }
                else { }
            }
        }

        public void CatEdited(object sender)
        {
            BLL.EditCatalogItem(frm.CatID, frm.BargType, frm.ArticleId, frm.FirmId, frm.FirmArt, frm.UnitId, frm.UnitPrice, frm.CurId, frm.Manufacturer, frm.Comments,
                                            frm.DelivTerms, frm.MOQ, frm.MPQ, frm.AsDefault, "", Convert.ToInt32(frm.Vat), frm.MinExpDays, frm.CoefConv, frm.DataCode, 
                                            frm.DelivTermTxt, frm.Quoted, frm.BarCode, frm.ForCustomer);
            BLL.CatId = frm.CatID;
            FillList(ArtId, SupId);


            frm.Close();

            this.ShowingModal = false;
        }

        public void CatAdded(object sender)
        {
            int NewLineId = 0;

            NewLineId = BLL.AddCatalogItem(frm.BargType, frm.ArticleId, frm.FirmId, frm.FirmArt, frm.UnitId, frm.UnitPrice, frm.CurId, frm.Manufacturer, frm.Comments,
                                            frm.DelivTerms, frm.MOQ, frm.MPQ, frm.AsDefault, "", Convert.ToInt32(frm.Vat), frm.MinExpDays, frm.CoefConv, frm.DataCode, 
                                            frm.DelivTermTxt, frm.Quoted, frm.BarCode, frm.ForCustomer);
            FillList(ArtId, SupId);

            frm.Close();

            this.ShowingModal = false;
        }

        public void CatClosed(object sender)
        {
            this.ShowingModal = false;
        }

        #endregion

        #region Controls
        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
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
            SetCellsColor();

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

        #endregion

        #endregion

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.ShowingModal = true;

            frm = new frm_AddCatItem();
            frm.ArticleId = ArtId;
            frm.FirmId = SupId;

            frm.CatSaved += new CatSavedEventHandler(CatAdded);
            frm.CatClosed += new CatClosedEventHandler(CatClosed);

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                this.ShowingModal = true;

                frm = new frm_AddCatItem();
                BLL.CatId = _id;
                frm.CatID = _id;
                frm.ArticleId = BLL.CatArtId;
                frm.BargType = BLL.CatBargain;
                frm.FirmArt = BLL.CatFirmArt;
                frm.FirmId = BLL.CatFirmId;
                frm.UnitId = BLL.CatUnitId;
                frm.UnitPrice = BLL.CatUnitPrice;
                frm.CurId = BLL.CatCurId;
                frm.Manufacturer = BLL.CatManufacturer;
                frm.DelivTerms = BLL.CatDelivDerm;
                frm.MOQ = BLL.CatMOQ;
                frm.MPQ = BLL.CatMPQ;
                frm.AsDefault = BLL.CatAsDefault;
                frm.MinExpDays = BLL.CatMinExpDays;
                frm.CoefConv = BLL.CatCoefConv;
                frm.Comments = BLL.CatComments;
                frm.Vat = BLL.CatVat;
                frm.DataCode = BLL.CatDataCode;
                frm.DelivTermTxt = BLL.CatDelivTermTxt;
                frm.Quoted = BLL.CatQuoted;
                frm.BarCode = BLL.CatBarCode;
                frm.ForCustomer = BLL.CatForCust;
                frm.CatSaved += new CatSavedEventHandler(CatEdited);
                frm.CatClosed += new CatClosedEventHandler(CatClosed);

                frm.Show(); frm.GetKryptonFormFields();
            }
        }
    }
}
