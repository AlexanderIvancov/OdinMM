using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using Odin.Warehouse.Deliveries;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Sales
{
    public delegate void SaveExDetChangesEventHandler(DataGridView gvList);

    public partial class frm_AddExInvoiceLine : KryptonForm
    {
        public frm_AddExInvoiceLine()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "DLNForInvoices.xls", this.Name);
        }

        public event SaveExDetChangesEventHandler SaveChanges;

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        Helper MyHelper = new Helper();
        DelivNote_BLL DNBll = new DelivNote_BLL();
        CO_BLL COBll = new CO_BLL();

        int _invtype = 3;

        public int InvoiceType
        {
            get { return _invtype; }
            set
            {
                _invtype = value;
                if (value == 13)
                {
                    chk_ispaid.Visible = true;
                    txt_InAdvance.Visible = false;
                    txt_LeftInAdvance.Visible = false;
                    lbl_InAdvance.Visible = false;
                    lbl_LeftinAdvance.Visible = false;
                    //lbl_UnitPrice.Text = "Total PAY:";
                    //lbl_TotalPayPerc.Visible = true;
                    //txt_TotalPayPerc.Visible = true;
                    //txt_Qty.Enabled = false;
                    //txt_Qty.Visible = false;
                    //lbl_Qty.Visible = false;
                }
                else
                {
                    chk_ispaid.Visible = false;
                    txt_InAdvance.Visible = true;
                    txt_LeftInAdvance.Visible = true;
                    lbl_InAdvance.Visible = true;
                    lbl_LeftinAdvance.Visible = true;
                    lbl_TotalPayPerc.Visible = false;
                    txt_TotalPayPerc.Visible = false;
                    txt_Qty.Enabled = true;
                    txt_Qty.Visible = true;
                    lbl_Qty.Visible = true;
                }

            }
        }

        public int Mode
        {
            get {
                return cn_Type.SelectedPage == pg_DelivNote ? 1 : 2;
            }
            set {  }
        }

        //int _allowtoinvoice = -1;
        //public int AllowToinvoice
        //{
        //    get {
        //        return _allowtoinvoice;
        //    }
        //    set {
        //        _allowtoinvoice = value;
        //        if (_allowtoinvoice == -1)
        //            lbl_NotPaid.Visible = false;
        //        else
        //            lbl_NotPaid.Visible = true;
        //    }
        //}

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public double Total
        {
            get { return Convert.ToDouble(txt_Total.Text); }
            set { txt_Total.Text = value.ToString(); }
        }
        public double TotalVat
        {
            get { return Convert.ToDouble(txt_TotalVat.Text); }
            set { txt_TotalVat.Text = value.ToString(); }
        }

        public double TotalWithVat
        {
            get { return Convert.ToDouble(txt_TotalWithVat.Text); }
            set { txt_TotalWithVat.Text = value.ToString(); }
        }

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }

        public int UnitId
        { get { return cmb_Units1.UnitId; }
        set { cmb_Units1.UnitId = value; }
        }
        public string Product
        {
            get { return txt_Product.Text; }
            set { txt_Product.Text = value; }
        }
        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        public int COCurId
        { get; set; }
        public int InvoiceCurId
        { get; set; }
        public double FirmVAT
        { get; set; }
        public int BuyerId
        { get; set; }

        public double Qty
        {
            get { try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public double COQty
        {
            get
            {
                try { return Convert.ToDouble(txt_COQty.Text); }
                catch { return 0; }
            }
            set { txt_COQty.Text = value.ToString(); }
        }

        public double UnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_UnitPrice.Text); }
                catch { return 0; }
            }
            set { txt_UnitPrice.Text = value.ToString(); }
        }


        public double COUnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_COUnitPrice.Text); }
                catch { return 0; }
            }
            set { txt_COUnitPrice.Text = value.ToString(); }
        }

        public double COTotal
        {
            get
            {
                try { return Convert.ToDouble(txt_COTotal.Text); }
                catch { return 0; }
            }
            set { txt_COTotal.Text = value.ToString(); }
        }


        public double InAdvance
        {
            get
            {
                try { return Convert.ToDouble(txt_InAdvance.Text); }
                catch { return 0; }
            }
            set { txt_InAdvance.Text = value.ToString(); }
        }

        public double LeftInAdvance
        {
            get
            {
                try { return Convert.ToDouble(txt_LeftInAdvance.Text); }
                catch { return 0; }
            }
            set { txt_LeftInAdvance.Text = value.ToString(); }
        }

        public double Discount
        {
            get
            {
                try { return Convert.ToDouble(txt_Discount.Text); }
                catch { return 0; }
            }
            set { txt_Discount.Text = value.ToString(); }
        }

        public string CustCode
        {
            get { return cmb_CustCodes1.CustCode; }
            set { cmb_CustCodes1.CustCode = value; }
        }
        public int CustCodeId
        {
            get { return cmb_CustCodes1.CustCodeId; }
            set { cmb_CustCodes1.CustCodeId = value; }
        }
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }

        public int IsService
        {
            get {
                return chk_IsService.CheckState == CheckState.Checked ? -1 : 0;
            }
            set {
                chk_IsService.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int IsPaid
        {
            get
            {
                return chk_ispaid.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_ispaid.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int AdditExpenses
        {
            get
            {
                return chk_AdditCost.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_AdditCost.CheckState = value == -1 ? CheckState.Checked : CheckState.Unchecked;
            }
        }

        public int COId
        {
            get { return cmb_SalesOrdersWithLines1.SalesOrderLineId; }
            set { cmb_SalesOrdersWithLines1.SalesOrderLineId = value; }
        }

        public int QuotId
        {
            get { return cmb_Quotations1.QuotationId; }
            set { cmb_Quotations1.QuotationId = value; }
        }

        public double SellCoef
        {
            get {
                try { return Convert.ToDouble(txt_SellCoef.Text); }
                catch { return 1; }
            }
            set { txt_SellCoef.Text = value.ToString(); }
        }

        public double SellCoefSimple
        {
            get
            {
                try { return Convert.ToDouble(txt_SellCoefSimple.Text); }
                catch { return 1; }
            }
            set { txt_SellCoefSimple.Text = value.ToString(); }
        }

        public double tmpUnitPrice
        { get; set; }

        public double tmpQty
        {
            get;set;
        }

        public double TotalPayPerc
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalPayPerc.Text); }
                catch { return 0; }
            }
            set { txt_TotalPayPerc.Text = value.ToString(); }
        }

        public double CurrRate
        {
            get;
            set;
        }

        public double COCurRate
        {
            get;set;
        }

        public string SalesComments
        {
            get { return txt_SalesComments.Text; }
            set { txt_SalesComments.Text = value; }
        }

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_isresale"].Value) == -1)
                    foreach (DataGridViewCell cell in row.Cells)
                    { cell.Style.BackColor = Color.FromArgb(255, 255, 192); }
                if (Convert.ToInt32(row.Cells["cn_allowtoinvoice"].Value) == 0)
                    foreach (DataGridViewCell cell in row.Cells)
                    { cell.Style.BackColor = Color.Tomato; }
                if (row.Cells["cn_salescomments"].Value.ToString().Trim() != "")
                    foreach (DataGridViewCell cell in row.Cells)
                    { cell.Style.BackColor = Color.Plum; }
            }
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
        
        public void RecalcTotals()
        {
            double _total = 0;
            double _totalvat = 0;
            double _totalwithvat = 0;

            string _cur = "€";

            if (Mode == 1)
            {
                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    try
                    {
                        if (Convert.ToInt32(row.Cells["chk_add"].Value) == -1)
                        {
                            _total = _total + Math.Round(Convert.ToDouble(row.Cells["cn_unitprice"].Value) * Convert.ToDouble(row.Cells["cn_qty"].Value), 2, MidpointRounding.AwayFromZero);
                            _totalvat = _totalvat + Math.Round(Convert.ToDouble(row.Cells["cn_unitprice"].Value) * Convert.ToDouble(row.Cells["cn_qty"].Value)
                                                                / 100 * FirmVAT, 2, MidpointRounding.AwayFromZero);
                            _totalwithvat = _totalwithvat + Math.Round((Convert.ToDouble(row.Cells["cn_unitprice"].Value) * Convert.ToDouble(row.Cells["cn_qty"].Value))
                                                                + Convert.ToDouble(row.Cells["cn_unitprice"].Value) * Convert.ToDouble(row.Cells["cn_qty"].Value)
                                                                / 100 * FirmVAT, 2, MidpointRounding.AwayFromZero);
                            _cur = row.Cells["cn_currency"].Value.ToString();
                        }
                    }
                    catch { }
                }
            }
            else
            {
                _total = Math.Round(Qty * UnitPrice, 2, MidpointRounding.AwayFromZero);
                _totalvat = Math.Round(Qty * UnitPrice / 100 * FirmVAT, 2, MidpointRounding.AwayFromZero);
                _totalwithvat = Math.Round((Qty * UnitPrice) + (Qty * UnitPrice / 100 * FirmVAT), 2, MidpointRounding.AwayFromZero);
                _cur = cmb_Currency1.Currency;
            }

            Total = _total;
            TotalVat = _totalvat;
            TotalWithVat = _totalwithvat;

            lbl_Total.Text = "Total for document (" + _cur + "):";
            lbl_Vat.Text = "VAT (" + _cur + "):";
            lbl_TotalVat.Text = "Total + VAT (" + _cur + "):";
        }

        public void ShowOrderDets(int coid)
        {
            COBll.COId = coid;
            ArtId = COBll.COArtId;
            Product = COBll.COCustArticle;
            SalesComments = COBll.COSalesComments;
            if (InvoiceType == 13)
            {
                Qty = 1;//COBll.QQty - COBll.QQtyInvoiced;
                tmpQty = 1; //COBll.QQty - COBll.QQtyInvoiced;
                UnitId = COBll.QUnitId;
                UnitPrice = Math.Round(COBll.COUnitPrice * COBll.COQty, 5);
                tmpUnitPrice = Math.Round(COBll.COUnitPrice * COBll.COQty, 5);
            }
            else
            {
                Qty = COBll.COQty - COBll.COQtyInvoiced;
                tmpQty = COBll.COQty - COBll.COQtyInvoiced;
                UnitId = COBll.COUnitId;
                UnitPrice = COBll.COUnitPrice;

                tmpUnitPrice = COBll.COUnitPrice;
            }
            
            //VAT = COBll.COVat;
            COBll.COHeadId = COBll.COHeadId1;
            CurId = COBll.COHeadCurId;
            COCurRate = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select convert(float, isnull(dbo.fn_CurRate(" + CurId + ", convert(datetime, '" + System.DateTime.Now.ToShortDateString() + "')), 1))"));
            //if (CurId != InvoiceCurId)
            //    KryptonTaskDialog.Show("Currency warning!",
            //             "",
            //            "Currencies in invoice and confirmation order are not the same!",
            //            MessageBoxIcon.Warning,
            //            TaskDialogButtons.OK);
            CustCodeId = cmb_Articles1.CustCodeId;
            IsService = COBll.COService;
            LeftInAdvance = COBll.COLeftInAdvance;
            //AllowToinvoice = COBll.COAllowToInvoice;
            COQty = COBll.COQty;
            COUnitPrice = COBll.COUnitPrice;
            COTotal = Math.Round(COBll.COQty * COBll.COUnitPrice, 2);

            RecalcUnitPriceSimple(SellCoefSimple);
        }

        public void ShowQuotDets(int quotid)
        {
            COBll.QuotId = quotid;
            ArtId = COBll.QArtId;
            Product = COBll.QCustArticle;
            Qty = 1;//COBll.QQty - COBll.QQtyInvoiced;
            tmpQty = 1; //COBll.QQty - COBll.QQtyInvoiced;
            UnitId = COBll.QUnitId;
            //UnitPrice = Math.Round(COBll.QUnitPrice * COBll.QQty, 5);
            //tmpUnitPrice = Math.Round(COBll.QUnitPrice * COBll.QQty, 5);
            UnitPrice = Math.Round(COBll.QQty * COBll.QUnitPrice, 2);
            tmpUnitPrice = Math.Round(COBll.QQty * COBll.QUnitPrice, 2);

            CurId = COBll.QCurId;
            CustCodeId = cmb_Articles1.CustCodeId;
            COCurRate = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select convert(float, isnull(dbo.fn_CurRate(" + CurId + ", convert(datetime, '" + System.DateTime.Now.ToShortDateString() + "')), 1))"));
            COQty = COBll.QQty;
            COUnitPrice = COBll.QUnitPrice;
            COTotal = Math.Round(COBll.QQty * COBll.QUnitPrice, 2);
            //AllowToinvoice = -1;

            RecalcUnitPriceSimpleQuot(SellCoefSimple);
            TotalPayPerc = 100;
        }

        public void RecalcUnitPrice(double sellcoef)
        {
            int _nativecurid = 0;
            double _currate = 0;
            _nativecurid = Convert.ToInt32(Helper.GetOneRecord("select isnull(convert(int, value), -1) from BAS_Defaults where field = 'currency'"));
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_curid"].Value) != InvoiceCurId)
                {
                    _currate = InvoiceCurId == _nativecurid ? CurrRate : Convert.ToDouble(row.Cells["cn_cocurrate"].Value) / (CurrRate == 0 ? 1 : CurrRate);
                    row.Cells["cn_unitprice"].Value = Math.Round(
                        (Convert.ToDouble(row.Cells["cn_unitpriceorig"].Value) * _currate) * sellcoef, 2);
                }
                else
                row.Cells["cn_unitprice"].Value = Math.Round(
                        (Convert.ToInt32(row.Cells["cn_curid"].Value) != InvoiceCurId ? Convert.ToDouble(row.Cells["cn_unitpriceorig"].Value) * (CurrRate/* / Convert.ToDouble(row.Cells["cn_cocurrate"].Value)*/) * sellcoef 
                        : Convert.ToDouble(row.Cells["cn_unitpriceorig"].Value) * sellcoef), 
                        2);
            }
            RecalcTotals();
        }

        public void RecalcUnitPriceSimple(double sellcoef)
        {
            int _nativecurid = 0;
            double _currate = 0;
            _nativecurid = Convert.ToInt32(Helper.GetOneRecord("select isnull(convert(int, value), -1) from BAS_Defaults where field = 'currency'"));
            if (CurId != InvoiceCurId)
            {
                _currate = InvoiceCurId == _nativecurid ? CurrRate : COCurRate / (CurrRate == 0 ? 1 : CurrRate);
                UnitPrice = InvoiceType != 13
                    ? Math.Round(
                            COBll.COUnitPrice * _currate * sellcoef,
                            2)
                    : Math.Round(
                        COBll.COUnitPrice * COBll.COQty * _currate * sellcoef,
                        2);
            }
            else
            {
                UnitPrice = InvoiceType != 13
                    ? Math.Round(
                        COBll.COUnitPrice * sellcoef,
                        2)
                    : Math.Round(
                        COBll.COUnitPrice * COBll.COQty * sellcoef,
                        2);
            }
            
            //if (InvoiceType != 13)
            //    UnitPrice = Math.Round(
            //        CurId != COCurId ? COBll.COUnitPrice * (CurrRate / COCurRate) * sellcoef
            //        : COBll.COUnitPrice * sellcoef, 
            //        5);
            //else
            //    UnitPrice = Math.Round(
            //        CurId != COCurId ? COBll.COUnitPrice * COBll.COQty  * (CurrRate / COCurRate) * sellcoef
            //        : COBll.COUnitPrice * COBll.COQty * sellcoef, 
            //        5);

            RecalcTotals();
        }

        public void RecalcUnitPriceSimpleQuot(double sellcoef)
        {
            if (InvoiceCurId != CurId)
            {
                UnitPrice = Math.Round(COBll.QUnitPrice * COBll.QQty * (CurrRate / COCurRate), 5);
                RecalcTotals();
            }
        }


        #endregion

        #region Controls


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

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for export invoices creation list";
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

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        #endregion

        private void cmb_DeliveryNotes1_DelivNoteChanged(object sender)
        {
        }

        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SaveChanges?.Invoke(gv_List);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            var data = (DataTable)Helper.getSP("sp_SelectDelivNoteDets", cmb_DeliveryNotes1.DelivNoteId);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();

                try {
                    RecalcTotals();
                    RecalcUnitPrice(SellCoef);
                }
                catch { }
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        private void cmb_SalesOrdersWithLines1_SalesOrderChanged(object sender)
        {
            if (cmb_Quotations1.QuotationId != 0)
            {
                cmb_Quotations1.QuotationId = 0;
                lbl_UnitPrice.Text = "Unit price";
            }
                //cmb_Articles1.ArticleId = cmb_SalesOrdersWithLines1.
            ShowOrderDets(cmb_SalesOrdersWithLines1.SalesOrderLineId);
            RecalcTotals();
            CheckQtyVisible();
        }
              

        private void frm_AddExInvoiceLine_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void chk_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SelectAll.Checked == true)
            {
                foreach (DataGridViewRow row in gv_List.Rows)
                {
                    row.Cells["chk_add"].Value = string.IsNullOrEmpty(row.Cells["cn_invoices"].Value.ToString().Trim()) == false ? 0 : (object)-1;
                }
            }
            else
            {
                foreach (DataGridViewRow row in gv_List.Rows)
                {
                    row.Cells["chk_add"].Value = 0;
                }
            }
            try { RecalcTotals(); }
            catch { }
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();

            if (gv_List.CurrentRow.Cells["chk_add"].Selected == true)
            {
                if (string.IsNullOrEmpty(gv_List.CurrentRow.Cells["cn_invoices"].Value.ToString().Trim()) == false)
                {
                    MessageBox.Show("You already have invoice for this delivery!");
                    //gv_List.CurrentRow.Cells["chk_add"].Value = 0;
                }

                if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) != InvoiceCurId)
                {
                    MessageBox.Show("Currency for customer order is not the same with invoice! Be careful!");
                }

                if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_supplierid"].Value) == BuyerId
                    && Convert.ToInt32(gv_List.CurrentRow.Cells["cn_isresale"].Value) == -1)
                {
                    MessageBox.Show("You can not make invoice for resale for the same buyer than supplier!");
                    gv_List.CurrentRow.Cells["chk_add"].Value = 0;
                }

                //if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_isresale"].Value) == -1
                //    && )
            }

            try { RecalcTotals(); }
            catch { }
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            UnitId = cmb_Articles1.UnitId;
            CustCodeId = cmb_Articles1.CustCodeId;
            if (cmb_SalesOrdersWithLines1.SalesOrderLineId == 0)
            {
                CurId = InvoiceCurId;
                Product = cmb_Articles1.SecName;
                txt_ArtComments.Text = cmb_Articles1.Comments;
            }
        }

        private void cn_Type_TabClicked(object sender, ComponentFactory.Krypton.Navigator.KryptonPageEventArgs e)
        {
            RecalcTotals();
        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            RecalcTotals();
        }

        private void txt_UnitPrice_Validated(object sender, EventArgs e)
        {
            RecalcTotals();
        }

        private void txt_VAT_Validated(object sender, EventArgs e)
        {
            RecalcTotals();
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            RecalcTotals();
            if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_inadvance"].Value) > Convert.ToInt32(gv_List.CurrentRow.Cells["cn_leftinadvance"].Value))
                gv_List.CurrentRow.Cells["cn_inadvance"].Value = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_leftinadvance"].Value);
        }

        private void cn_Type_SelectedPageChanged(object sender, EventArgs e)
        {
           // RecalcTotals();
        }
               

        private void txt_SellCoef_TextChanged(object sender, EventArgs e)
        {
            RecalcUnitPrice(SellCoef);
        }

        private void txt_SellCoefSimple_TextChanged(object sender, EventArgs e)
        {
            RecalcUnitPriceSimple(SellCoefSimple);
        }

        private void cmb_Quotations1_QuotationChanged(object sender)
        {
            //MessageBox.Show(cmb_Quotations1.QuotationId.ToString());
            if (cmb_Quotations1.QuotationId != 0
                || InvoiceType == 13)
            {
                cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
                lbl_UnitPrice.Text = "Total PAY:";
                lbl_TotalPayPerc.Visible = true;
                txt_TotalPayPerc.Visible = true;
                txt_Qty.Enabled = false;
                txt_Qty.Visible = false;
                lbl_Qty.Visible = false;
            }
            else
            {
                lbl_UnitPrice.Text = "Unit price:";
                lbl_TotalPayPerc.Visible = false;
                txt_TotalPayPerc.Visible = false;
                txt_Qty.Enabled = true;
                txt_Qty.Visible = true;
                lbl_Qty.Visible = true;
            }
            CheckQtyVisible();
            ShowQuotDets(cmb_Quotations1.QuotationId);
            RecalcTotals();
        }

        private void txt_InAdvance_Validated(object sender, EventArgs e)
        {
            if (InAdvance > LeftInAdvance)
            {
                InAdvance = LeftInAdvance;
            }
        }

        private void txt_TotalPayPerc_Validated(object sender, EventArgs e)
        {
            UnitPrice = Math.Round(tmpUnitPrice / 100 * TotalPayPerc, 2);
            RecalcTotals();
        }

        public void CheckQtyVisible()
        {
            if ((cmb_Quotations1.QuotationId != 0 || cmb_SalesOrdersWithLines1.SalesOrderLineId != 0)
                && InvoiceType == 13)
            {
                lbl_UnitPrice.Text = "Total PAY:";
                lbl_TotalPayPerc.Visible = true;
                txt_TotalPayPerc.Visible = true;
                txt_Qty.Enabled = false;
                txt_Qty.Visible = false;
                lbl_Qty.Visible = false;
            }
            else
            {
                lbl_UnitPrice.Text = "Unit price:";
                lbl_TotalPayPerc.Visible = false;
                txt_TotalPayPerc.Visible = false;
                txt_Qty.Enabled = true;
                txt_Qty.Visible = true;
                lbl_Qty.Visible = true;
            }
        }
    }
}
