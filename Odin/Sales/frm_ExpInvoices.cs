using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Register;
using Odin.Sales.Reports;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Odin.Sales
{
    public partial class frm_ExpInvoices : BaseForm
    {
        public frm_ExpInvoices()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ExportInvoices.xls", this.Name);
        }

        #region Variables

        ExportData ED;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        Reg_BLL RegBll = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        Helper MyHelper = new Helper();
        CO_BLL Bll = new CO_BLL();
        CMB_BLL CmbBll = new CMB_BLL();

        public ctl_Payments ctlPayments = null;

        frm_AddExInvoiceLine frm = null;

        public int ControlWidth = 250;
              

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";


        public int InvoiceLineId
        {
            get;
            set;
        }


        public double Billed
        { get; set; }
        public int _PrevId = 0;

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

        public double TotalByProforma
        {
            get { return Convert.ToDouble(txt_TotalByProforma.Text); }
            set { txt_TotalByProforma.Text = value.ToString(); }
        }

        public int IsPaid
        {
            get
            {
                return rb_PaidAll.Checked == true ? 1 : rb_Paid.Checked == true ? -1 : 0;
            }
           
        }

        public int IsActive
        {
            get
            {
                return rb_Active.Checked == true ? -1 : rb_Inactive.Checked == true ? 0 : 1;
            }
           
        }

        #endregion

        #region Methods

        public void ClearDates()
        {
            txt_CreatDateFrom.Value = null;
            txt_CreatDateTill.Value = null;
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

        public void ClearFilter()
        {
            cmb_ExpInvoice1.InvoiceId = 0;
            cmb_Firms1.FirmId = 0;
            cmb_Firms2.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Department1.DeptId = 0;
            cmb_SalesOrders1.SalesOrderId = 0;
            cmb_Common1.SelectedValue = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            txt_CustArticle.Text = string.Empty;
            txt_Comments.Text = string.Empty;
            txt_CreatDateFrom.Value = null; 
            txt_CreatDateTill.Value = null;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();

        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
                if (row.Cells["cn_iscertified"].Value.ToString() == "Certified")
                {
                    row.Cells["cn_article"].Style.BackColor = Color.LightGreen;
                    row.Cells["cn_artid"].Style.BackColor = Color.LightGreen;
                }
        }

        public void bw_List(object sender, DoWorkEventArgs e)
        {
           // MessageBox.Show(cmb_Common1.SelectedValue.ToString());
            var data = CO_BLL.getExInvoices(cmb_ExpInvoice1.InvoiceId,
                                            cmb_Common1.SelectedValue,
                                            cmb_Types1.TypeId, 
                                            cmb_Department1.DeptId, 
                                            cmb_Firms1.FirmId, 
                                            cmb_Firms2.FirmId,
                                            cmb_SalesOrders1.SalesOrderId,
                                            cmb_Articles1.ArticleId,
                                            txt_CustArticle.Text,
                                            txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(),
                                            txt_Comments.Text,
                                            IsPaid,
                                            IsActive);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();

                try
                {
                    RecalcTotals(gv_List.CurrentRow.Cells["cn_name"].Value.ToString(), Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value));
                }
                catch { }

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }
        
        private bool CheckOldRow()
        {

            try
            {
                InvoiceLineId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                Billed = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_totalwithvat"].Value);
            }
            catch
            {
                InvoiceLineId = 0;
                Billed = 0;
            }

            if (_PrevId == InvoiceLineId)
            {
                return true;
            }
            else
            {
                _PrevId = InvoiceLineId;
                return false;
            }
        }

        public void ShowDetails(int idin)
        {
            int _artid = 0;
            int _headid = 0;
            string _docname = "";
            double _billed = 0;

            try
            {
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value);
                _docname = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                _billed = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_totalwithvat"].Value);
                cmb_ExpInvoice1.InvoiceId = _headid;
                RecalcTotals(_docname, _headid);
            }
            catch { }

            FindPaymentPage(_headid, idin, _billed);
        }

        public void FindPaymentPage(int invoiceheadid, int invoicedetid, double billed)
        {
            //foreach (var page in kryptonDockingManager1.Pages)
            //{
            //    ctl_Nomenclatures ctlBOM1 = (ctl_Nomenclatures)page.Controls.Find("ctl_Nomenclatures", true).FirstOrDefault();
            //    if (ctlBOM1 != null
            //        && ctlBOM1.Lock == 0)
            //        ctlBOM1.cmb_Articles1.ArticleId = artid;
            //    //break;
            //}
            foreach (var page in kryptonDockingManager1.Pages)
            {
                ctl_Payments ctlPayments1 = (ctl_Payments)page.Controls.Find("ctl_Payments", true).FirstOrDefault();
                if (ctlPayments1 != null)
                {
                    ctlPayments1.InvoiceHeadId = invoiceheadid;
                    ctlPayments1.InvoiceDetId = invoicedetid;
                    ctlPayments1.Billed = billed;
                }
                //break;
            }
        }

        public void RecalcTotals(string _document, int _headid)
        {
            double _total = 0;
            double _byproforma = 0;
            double _totalvat = 0;
            double _totalwithvat = 0;
            string _cur = "€";
            double _vat = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                try
                {
                    if (row.Cells["cn_name"].Value.ToString() == _document)
                    {
                        _total = _total + Math.Round(Convert.ToDouble(row.Cells["cn_total"].Value), 2, MidpointRounding.AwayFromZero);
                        _totalvat = _totalvat + Math.Round(Convert.ToDouble(row.Cells["cn_totalvat"].Value), 2, MidpointRounding.AwayFromZero);
                        _totalwithvat = _totalwithvat + Math.Round(Convert.ToDouble(row.Cells["cn_totalwithvat"].Value), 2, MidpointRounding.AwayFromZero);
                        _cur = row.Cells["cn_currency"].Value.ToString();
                        if (_vat < Convert.ToDouble(row.Cells["cn_vat"].Value))
                            _vat = Convert.ToDouble(row.Cells["cn_vat"].Value);
                        _byproforma = _byproforma + Math.Round(Convert.ToDouble(row.Cells["cn_paidbyproforma"].Value), 2, MidpointRounding.AwayFromZero);
                    }
                }
                catch { }
            }

            Total = _total;
            TotalVat = Math.Round(_totalvat, 2, MidpointRounding.AwayFromZero);//Math.Round(_total / 100 * _vat, 2);//_totalvat;
            TotalWithVat = Math.Round(_totalwithvat, 2, MidpointRounding.AwayFromZero);//_total + Math.Round(_total / 100 * _vat, 2);
            TotalByProforma = _byproforma;

            lbl_Total.Text = "Total for document (" + _cur + "):";
            lbl_Vat.Text = "VAT (" + _cur + "):";
            lbl_TotalVat.Text = "Total + VAT (" + _cur + "):";
            lbl_ByProforma.Text = "Paid by proforma (" + _cur + "):";
        }

        public void AddInvoiceLine(DataGridView grv)
        {
            if (frm.Mode == 1)
            {
                foreach (DataGridViewRow row in grv.Rows)
                {
                    if (Convert.ToInt32(row.Cells["chk_add"].Value) != 0
                        /*&& (Convert.ToInt32(row.Cells["cn_coid"].Value) != 0 ||
                            Convert.ToInt32(row.Cells["cn_isresale"].Value) != 0 ||
                            Convert.ToInt32(row.Cells["cn_isfinalproduct"].Value) != 0)*/
                        )
                    {
                        if (Convert.ToInt32(row.Cells["cn_delivplaceid"].Value) == CmbBll.ExInvoiceReceiverId)
                        Bll.AddExInvoiceDets(Convert.ToInt32(row.Cells["cn_id"].Value),
                                            cmb_ExpInvoice1.InvoiceId,
                                            Convert.ToInt32(row.Cells["cn_artid"].Value),
                                            row.Cells["cn_custart"].Value.ToString(),
                                            Convert.ToDouble(row.Cells["cn_qty"].Value),
                                            Convert.ToInt32(row.Cells["cn_unitid"].Value),
                                            Convert.ToDouble(row.Cells["cn_unitprice"].Value),
                                            frm.FirmVAT,
                                            Convert.ToDouble(row.Cells["cn_discount"].Value),
                                            row.Cells["cn_custcode"].Value.ToString(),
                                            row.Cells["cn_comments"].Value == null ? "" : row.Cells["cn_comments"].Value.ToString(),
                                            Convert.ToInt32(row.Cells["cn_coid"].Value),
                                            Convert.ToInt32(row.Cells["chk_Service"].Value == null ? 0 : row.Cells["chk_Service"].Value),
                                            Convert.ToInt32(row.Cells["chk_AddExp"].Value == null ? 0 : row.Cells["chk_AddExp"].Value),
                                            0,
                                            0,
                                            Convert.ToDouble(row.Cells["cn_inadvance"].Value),
                                            row.Cells["cn_salescomments"].Value.ToString());
                        else
                            KryptonTaskDialog.Show("Recepient place warning!",
                                "",
                               "Receivers of goods in invoice and in delivery note are different!",
                               MessageBoxIcon.Stop,
                               TaskDialogButtons.OK);
                    }
                }
                frm.Close();
            }
            else //Simple
            {
                if (frm.CurId != frm.InvoiceCurId)
                {
                    KryptonTaskDialog.Show("Currency warning!",
                                 "",
                                "Currencies in invoice and confirmation order are not the same!",
                                MessageBoxIcon.Warning,
                                TaskDialogButtons.OK);
                }
                //else
                //{
                    if (frm.Qty != 0
                        && String.IsNullOrEmpty(frm.Product) != true
                        /*&& frm.AllowToinvoice == -1*/)
                    {
                        Bll.AddExInvoiceDets(0, cmb_ExpInvoice1.InvoiceId, frm.ArtId, frm.Product, frm.cmb_Quotations1.QuotationId == 0 ? frm.Qty : 1, frm.UnitId, frm.UnitPrice,
                                            frm.FirmVAT, frm.Discount, frm.CustCode, frm.Comments, frm.COId, frm.IsService, frm.AdditExpenses, 
                                            frm.QuotId, frm.IsPaid, frm.InAdvance, frm.SalesComments);
                        frm.Close();
                    }
                    else
                    {
                        KryptonTaskDialog.Show("Empty fields warning!",
                                "",
                               "Some cells are empty!",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.OK);
                    }
                //}
               
            }

           

            bwStart(bw_List);
        }

        private KryptonPage NewPage(string name, int image, Control content, int _Width)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage();
            p.Text = name;
            p.TextTitle = name;
            p.TextDescription = name;
            p.ImageSmall = imageListSmall.Images[image];

            //p.Width = _Width;

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);


            return p;
        }

        private KryptonPage NewInputPayments(int invoiceheadid, int invoicedetid, double billed)
        {
            ctlPayments = new ctl_Payments();
            ControlWidth = ctlPayments.Width;
            ctlPayments.InvoiceHeadId = invoiceheadid;
            ctlPayments.InvoiceDetId = invoicedetid;
            ctlPayments.Billed = billed;
            //ctlHis.cmb_Articles1.ArticleId = ArtId;

            return NewPage("Payments ", 1, ctlPayments, ctlPayments.Width);
        }

        #endregion

        #region Controls

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
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

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for export invoices list";
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

        private void frm_ExpInvoices_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            txt_CreatDateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null; //Convert.ToDateTime("01/01/2100");
            cmb_Common1.SelectedValue = 0;
        }

        private void frm_ExpInvoices_Resize(object sender, EventArgs e)
        {
            if (_Main.WindowState == FormWindowState.Maximized)
            {
                foreach (var page in kryptonDockingManager1.PagesDocked)
                {
                    kryptonDockingManager1.RemovePage(page, false);
                    kryptonDockingManager1.AddDockspace("Control",
                                               DockingEdge.Left,
                                               new KryptonPage[] { page });

                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

            SetCellsColor();
        }


        #endregion

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails(InvoiceLineId);
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (cmb_ExpInvoice1.InvoiceId != 0)
            {
                frm = new frm_AddExInvoiceLine();
                CmbBll.ExInvoiceId = cmb_ExpInvoice1.InvoiceId;
                frm.InvoiceCurId = CmbBll.ExInvoiceCurId;
                frm.FirmVAT = CmbBll.ExInvoiceVAT;
                frm.InvoiceType = CmbBll.ExInvoiceType;
                frm.CurrRate = CmbBll.ExInvoiceCurRate;
                frm.BuyerId = CmbBll.ExInvoiceBuyerId;

                frm.SaveChanges += new SaveExDetChangesEventHandler(AddInvoiceLine);

                frm.Show(); frm.GetKryptonFormFields();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (cmb_ExpInvoice1.InvoiceId != 0
                && _id != 0)
            {
                frm_EditExInvoiceLine frm = new frm_EditExInvoiceLine();
                CmbBll.ExInvoiceId = cmb_ExpInvoice1.InvoiceId;
                frm.InvoiceCurId = CmbBll.ExInvoiceCurId;
                frm.FirmVAT = CmbBll.ExInvoiceVAT;
                frm.InvId = _id;
                frm.InvoiceType = CmbBll.ExInvoiceType;
                //MessageBox.Show(_id.ToString());
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK
                    )
                {
                    //if (frm.AllowToinvoice == -1)
                    //{
                        //Edit line
                        Bll.EditExInvoiceDets(_id, frm.ArtId, frm.Product, frm.Qty, frm.UnitId, frm.UnitPrice,
                                               frm.FirmVAT, 0, frm.CustCode, frm.Comments, frm.COId, frm.IsService,
                                               frm.AdditExpenses, frm.QuotId, frm.IsPaid, frm.InAdvance, frm.IsActive, frm.SalesComments, frm.Total, frm.TotalVat);

                        DataGridViewColumn oldColumn = gv_List.SortedColumn;
                        var dir = Helper.SaveDirection(gv_List);

                        bwStart(bw_List);

                        Helper.RestoreDirection(gv_List, oldColumn, dir);
                    //}
                    //else
                    //{
                    //    KryptonTaskDialog.Show("Unpaid advance warning!",
                    //             "",
                    //            "You have unpaid advance!",
                    //            MessageBoxIcon.Warning,
                    //            TaskDialogButtons.OK);
                    //}
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //int _id = 0;

            //try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            //catch { }

            //if (_id != 0
            //    && glob_Class.DeleteConfirm() == true)
            //{
            //    Bll.DeleteExInvoiceDets(_id);
            //    bwStart(bw_List);
            //}

            if (glob_Class.DeleteConfirm() == true)
            {
                int _id = 0;

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (row.Selected == true)
                    {
                        try
                        {
                            _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                        }
                        catch { _id = 0; }

                        if (_id != 0)
                        {
                            Bll.DeleteExInvoiceDets(_id);
                        }
                    }
                }
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
           
        }

        private void mni_LangLat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_ExpInvoice1.ValueForCustoms.ToString());
            frm_rptExInvoicePrinting frm = new frm_rptExInvoicePrinting();
            frm.HeadId = cmb_ExpInvoice1.InvoiceId;
            frm.HeaderText = "Print invoice: " + cmb_ExpInvoice1.Invoice;
            frm.Lang = "RUS";
            frm.ValueForCustoms = cmb_ExpInvoice1.ValueForCustoms.ToString();

            frm.FillReport();

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void mni_LangEng_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_ExpInvoice1.ValueForCustoms.ToString());

            frm_rptExInvoicePrinting frm = new frm_rptExInvoicePrinting();
            frm.HeadId = cmb_ExpInvoice1.InvoiceId;
            frm.HeaderText = "Print invoice: " + cmb_ExpInvoice1.Invoice;
            frm.Lang = "ENG";
            frm.ValueForCustoms = cmb_ExpInvoice1.ValueForCustoms.ToString();

            frm.FillReport();

            frm.Show(); frm.GetKryptonFormFields();
        }

        private void buttonSpecAny5_Click_1(object sender, EventArgs e)
        {
            txt_CreatDateFrom.Value = System.DateTime.Now;
        }
        private void buttonSpecAny4_Click_1(object sender, EventArgs e)
        {
            txt_CreatDateTill.Value = System.DateTime.Now;
        }

        private void txt_CreatDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateFrom.Value = txt_CreatDateFrom.Value == null ? System.DateTime.Now : txt_CreatDateFrom.Value;
        }

        private void txt_CreatDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateTill.Value = txt_CreatDateTill.Value == null ? System.DateTime.Now : txt_CreatDateTill.Value;
        }

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            kryptonDockingManager1.AddDockspace("Control",
                                              DockingEdge.Left,
                                              new KryptonPage[] { NewInputPayments(cmb_ExpInvoice1.InvoiceId ,InvoiceLineId, Billed) });
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (cmb_ExpInvoice1.InvoiceId != 0
                && glob_Class.CloseConfirmInvoice() == true)
            {
                Bll.CloseExInvoice(cmb_ExpInvoice1.InvoiceId);
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }
        }
    }
}
