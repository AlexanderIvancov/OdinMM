using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Sales
{
    public delegate void SavePaymentEventHandler(object sender);

    public partial class frm_AddPayment : KryptonForm
    {
        public frm_AddPayment()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "Payments.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        Helper MyHelper = new Helper();
        CO_BLL COBll = new CO_BLL();
       
        public event SavePaymentEventHandler SavePayment;

        int _id = 0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _mode = "new";

        public string Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
              
            }
        }
        
        public string Payment
        {
            get { return txt_Payment.Text; }
            set { txt_Payment.Text = value; }
        }

        public int InvoiceType
        {
            get
            {
                return rb_Invoice.Checked == true ? 3 : rb_Proforma.Checked == true ? 13 : 0;
            }
            set
            {
                if (value == 13)
                {
                    rb_Proforma.Checked = true;
                    rb_Invoice.Checked = false;
                    rb_All.Checked = false;
                }
                else if (value == 3)
                {
                    rb_Invoice.Checked = true;
                    rb_Proforma.Checked = false;
                    rb_All.Checked = false;
                }
                else
                {
                    rb_Invoice.Checked = false;
                    rb_Proforma.Checked = false;
                    rb_All.Checked = true;
                }
            }
        }

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public double Summa
        {
            get { return Convert.ToDouble(txt_Summa.Text); }
            set { txt_Summa.Text = value.ToString(); }
        }
        public double SummaWVat
        {
            get { return Convert.ToDouble(txt_SummaWVat.Text); }
            set { txt_SummaWVat.Text = value.ToString(); }
        }

        public double Vat
        {
            get { return Convert.ToDouble(txt_Vat.Text); }
            set { txt_Vat.Text = value.ToString(); }
        }

        public double VatPerc
        {
            get { return Convert.ToDouble(txt_VatPerc.Text); }
            set { txt_VatPerc.Text = value.ToString(); }
        }

        public double TotalMapped
        {
            get { return Convert.ToDouble(txt_TotalMapped.Text); }
            set { txt_TotalMapped.Text = value.ToString(); }
        }

        public int BuyerId
        {
            get { return cmb_Firms2.FirmId; }
            set { cmb_Firms2.FirmId = value; }
        }

        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
        }

        public double CurRate
        {
            get { return Convert.ToDouble(txt_CurRate.Text); }
            set { txt_CurRate.Text = value.ToString(); }
        }

        public string PayDate
        {
            get
            {
                return txt_PayDate.Value == null ? "" : txt_PayDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_PayDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_PayDate.Value = null; }
            }
        }

        public double Mapped
        {
            get { return Convert.ToDouble(txt_TotalMapped.Text); }
            set { txt_TotalMapped.Text = value.ToString(); }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                //if (Convert.ToInt32(row.Cells["cn_isresale"].Value) == -1)
                //    foreach (DataGridViewCell cell in row.Cells)
                //    { cell.Style.BackColor = Color.FromArgb(255, 255, 192); }
                //if (Convert.ToInt32(row.Cells["cn_allowtoinvoice"].Value) == 0)
                //    foreach (DataGridViewCell cell in row.Cells)
                //    { cell.Style.BackColor = Color.Tomato; }
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

        public void FillDates()
        {
            txt_PayDate.Value = System.DateTime.Now;
        }

        public void FillAutoDoc()
        {
            Payment = DAL.AutoDoc(15, System.DateTime.Now.ToShortDateString());
        }

        public void FillList()
        {
            var data = CO_BLL.getNotPaidInvoice(cmb_Firms2.FirmId, InvoiceType);


            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();

                try
                {
                    //RecalcTotals();
                    //RecalcUnitPrice(SellCoef);
                }
                catch { }
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        private void CalcPriceVat()
        {
            Vat = Math.Round(Summa * VatPerc / (100 + VatPerc), 2);
            SummaWVat = Math.Round(Summa - Vat, 2, MidpointRounding.AwayFromZero);
            
        }

        private void CalcPrice()
        {
            Summa = Math.Round(((SummaWVat * 100) / (100 + VatPerc)), 5, MidpointRounding.AwayFromZero);
        }

        public void ClearToPay()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_topay"].Value = 0;
            }
        }

        public double AlreadyMapped()
        {
            double _res = 0;
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _res = _res + Convert.ToDouble(row.Cells["cn_topay"].Value);
            }

            return Math.Round(_res, 2);
        }

        public bool CheckEmpty()
        {
            bool _res = cmb_Currency1.CurrencyId != 0
                && cmb_Firms2.FirmId != 0;
            return _res;
        }

        public void ClearHeader()
        {
            cmb_Firms2.FirmId = 0;
            Summa = 0;
            VatPerc = 0;
            Comments = "";
            TotalMapped = 0;
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

            frm.HeaderText = "Select view for payment list";
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

        private void frm_AddPayment_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void txt_PayDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_PayDate.Value = txt_PayDate.Value == null ? System.DateTime.Now : txt_PayDate.Value;
        }

        private void btn_Wizard_Click(object sender, EventArgs e)
        {
            double tmppay = Summa;
            double tmpdiff = 0;
            double cocurrate = 0;
            ClearToPay();

            foreach (DataGridViewRow row in gv_List.Rows)
            {
                if (tmppay > 0)
                {
                    cocurrate = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select dbo.fn_CurRate(" + Convert.ToInt32(row.Cells["cn_curid"].Value) + ", " 
                        + "convert(datetime, '" + (PayDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : PayDate.Trim()) + "'))"));

                    
                    tmpdiff = (CurId == Convert.ToInt32(row.Cells["cn_curid"].Value) ? Convert.ToDouble(row.Cells["cn_diff"].Value) :
                                        (Convert.ToInt32(row.Cells["cn_curid"].Value) != 1 ? Math.Round(Convert.ToDouble(row.Cells["cn_diff"].Value) / cocurrate, 2) :
                                        Math.Round(CurRate == 0 ? 0 : (Convert.ToDouble(row.Cells["cn_diff"].Value) * CurRate), 2))) ;

                    if (tmpdiff > tmppay)
                    {
                        row.Cells["cn_topay"].Value = tmppay;
                        tmppay = 0;

                    }
                    else
                    {
                        row.Cells["cn_topay"].Value = tmpdiff;
                        tmppay = tmppay - tmpdiff;
                    }

                }
                else
                    break;
            }
            TotalMapped = AlreadyMapped();
            //ClearToPay();

            //double _paysum = 0;
            //int _headid = 0;
            //try { _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value); }
            //catch { }

            //foreach(DataGridViewRow row in gv_List.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells["cn_headid"].Value) == _headid)
            //    {
            //        row.Cells["cn_topay"].Value = Convert.ToDouble(row.Cells["cn_diff"].Value);
            //        _paysum = _paysum + Convert.ToDouble(row.Cells["cn_diff"].Value);
            //    }
            //}

            //Summa = _paysum;

            //TotalMapped = AlreadyMapped();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearToPay();
        }

        private void cmb_Firms2_FirmsChanged(object sender)
        {
            cmb_Currency1.CurrencyId = cmb_Firms2.CurId;
            VatPerc = cmb_Firms2.CountryVAT;
            FillList();
            CheckEmpty();
        }

        private void rb_Proforma_CheckedChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void rb_Invoice_CheckedChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void rb_All_CheckedChanged(object sender, EventArgs e)
        {
            FillList();
        }

        #endregion

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 11)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.bindingNavigatorAddNewItem_Image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 12)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.addGroup, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 13)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.Cancel.Width;
                var h = Global_Resourses.Cancel.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.Cancel, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            btn_OK.Focus();
            gv_List.EndEdit();
            if (AlreadyMapped() > 0
                && CheckEmpty() == true)
            {
                int _headres = COBll.AddPaymentHeader(BuyerId, 15, Convert.ToDateTime(txt_PayDate.Value).ToShortDateString(), Summa, VatPerc, CurId, CurRate, Comments);

                if (_headres != 0)
                {
                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        //Details
                        if (Convert.ToDouble(row.Cells["cn_topay"].Value) > 0)
                        {
                            COBll.AddPaymentDetails(_headres, Convert.ToInt32(row.Cells["cn_id"].Value),
                                            Convert.ToDateTime(txt_PayDate.Value).ToShortDateString(),
                                            Convert.ToDouble(row.Cells["cn_topay"].Value));
                            SendPaymentNotification(Convert.ToInt32(row.Cells["cn_id"].Value));
                        }


                    }
                }
                MessageBox.Show("Document added!");
                ClearHeader();

                gv_List.ThreadSafeCall(delegate { FillList(); });
               
                CalcPriceVat();
                FillAutoDoc();
                if (SavePayment != null)
                    SavePayment(this);
            }
            else
            {
                MessageBox.Show("Please check empty fields and sum for payment!");
            }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            double cocurrate = 0;
            double tmpdiff = 0;

            double _alreadymapped = AlreadyMapped();

            try {

                cocurrate = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select dbo.fn_CurRate(" + Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) + ", "
                        + "convert(datetime, '" + (PayDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : PayDate.Trim()) + "'))"));


                tmpdiff = (CurId == Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) ? Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) :
                                    (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) != 1 ? Math.Round(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) / cocurrate, 2) :
                                    Math.Round(CurRate == 0 ? 0 : (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) * CurRate), 2)));

                if (gv_List.CurrentRow.Cells["btn_add"].Selected == true)
                {
                    //if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value) > Summa - AlreadyMapped())
                    //    gv_List.CurrentRow.Cells["cn_topay"].Value = Summa - AlreadyMapped() + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value);
                    //else
                    //    gv_List.CurrentRow.Cells["cn_topay"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value);
                    gv_List.CurrentRow.Cells["cn_topay"].Value = tmpdiff - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value) > Summa - AlreadyMapped()
                        ? Summa - AlreadyMapped() + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value)
                        : (object)tmpdiff;
                }
                

            }
            catch { }

            try
            {
                if (gv_List.CurrentRow.Cells["btn_addgroup"].Selected == true)
                {
                    //double _paysum = 0;
                    int _headid = 0;
                    try { _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value); }
                    catch { }

                    foreach (DataGridViewRow row in gv_List.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_headid"].Value) == _headid)
                        {
                            cocurrate = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select dbo.fn_CurRate(" + Convert.ToInt32(row.Cells["cn_curid"].Value) + ", "
                            + "convert(datetime, '" + (PayDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : PayDate.Trim()) + "'))"));


                            tmpdiff = (CurId == Convert.ToInt32(row.Cells["cn_curid"].Value) ? Convert.ToDouble(row.Cells["cn_diff"].Value) :
                                                (Convert.ToInt32(row.Cells["cn_curid"].Value) != 1 ? Math.Round(Convert.ToDouble(row.Cells["cn_diff"].Value) / cocurrate, 2) :
                                                Math.Round(CurRate == 0 ? 0 : (Convert.ToDouble(row.Cells["cn_diff"].Value) * CurRate), 2)));

                            row.Cells["cn_topay"].Value = tmpdiff - Convert.ToDouble(row.Cells["cn_topay"].Value) > Summa - AlreadyMapped()
                                ? Summa - AlreadyMapped() + Convert.ToDouble(row.Cells["cn_topay"].Value)
                                : (object)tmpdiff;

                            //if (Convert.ToDouble(row.Cells["cn_diff"].Value) - Convert.ToDouble(row.Cells["cn_topay"].Value) > Summa - AlreadyMapped())
                            //   row.Cells["cn_topay"].Value = Summa - AlreadyMapped() + Convert.ToDouble(row.Cells["cn_topay"].Value);
                            //else
                            //   row.Cells["cn_topay"].Value = Convert.ToDouble(row.Cells["cn_diff"].Value);

                        }
                    }

                    TotalMapped = AlreadyMapped();
                    //Summa = AlreadyMapped();
              
                }

            }
            catch { }

            try
            {
                if (gv_List.CurrentRow.Cells["btn_cancelgroup"].Selected == true)
                {
                    //double _paysum = 0;
                    int _headid = 0;
                    try { _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_headid"].Value); }
                    catch { }

                    foreach (DataGridViewRow row in gv_List.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_headid"].Value) == _headid)
                        {
                            row.Cells["cn_topay"].Value = 0;
                        }
                    }

                    TotalMapped = AlreadyMapped();
                    //Summa = AlreadyMapped();

                }

            }
            catch { }

            TotalMapped = AlreadyMapped();
        }

        private void cmb_Currency1_CurrencyChanged(object sender)
        {
            txt_CurRate.ThreadSafeCall(delegate
            {
                DAL.ShowCurRate(CurId, PayDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : PayDate.Trim());
                CurRate = DAL.CurRate;
                txt_CurRate.StateCommon.Back.Color1 = CurRate == 0 ? Color.Red : Color.White;
            });

            CheckEmpty();
        }

        private void txt_VatPerc_TextChanged(object sender, EventArgs e)
        {
            CalcPriceVat();
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double cocurrate = 0;
            double tmpdiff = 0;

            gv_List.EndEdit();

            double _alreadymapped = AlreadyMapped();

            try
            {
                cocurrate = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select dbo.fn_CurRate(" + Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) + ", "
                        + "convert(datetime, '" + (PayDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : PayDate.Trim()) + "'))"));


                tmpdiff = (CurId == Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) ? Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) :
                                    (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) != 1 ? Math.Round(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) / cocurrate, 2) :
                                    Math.Round(CurRate == 0 ? 0 : (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) * CurRate), 2)));
                //if (gv_List.CurrentRow.Cells["cn_topay"].Selected == true)
                //{
                gv_List.CurrentRow.Cells["cn_topay"].Value = Summa - AlreadyMapped() < 0
                    ? Summa - (AlreadyMapped() - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value)) > tmpdiff ?
                                         tmpdiff :
                                         Summa - (AlreadyMapped() - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value))
                    : (object)(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value) > tmpdiff ?
                                        tmpdiff :
                                        Convert.ToDouble( gv_List.CurrentRow.Cells["cn_topay"].Value));

            }
            catch { }
            TotalMapped = AlreadyMapped();
        }

        private void gv_List_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Summa_TextChanged(object sender, EventArgs e)
        {
            CalcPriceVat();
        }

        private void btn_FIFO_Click(object sender, EventArgs e)
        {
            double tmppay = Summa;
            ClearToPay();
            double tmpdiff = 0;
            double cocurrate = 0;

            foreach (DataGridViewRow row in gv_List.Rows)
            {
                cocurrate = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select dbo.fn_CurRate(" + Convert.ToInt32(row.Cells["cn_curid"].Value) + ", "
                        + "convert(datetime, '" + (PayDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : PayDate.Trim()) + "'))"));


                tmpdiff = (CurId == Convert.ToInt32(row.Cells["cn_curid"].Value) ? Convert.ToDouble(row.Cells["cn_diff"].Value) :
                                    (Convert.ToInt32(row.Cells["cn_curid"].Value) != 1 ? Math.Round(Convert.ToDouble(row.Cells["cn_diff"].Value) / cocurrate, 2) :
                                    Math.Round(CurRate == 0 ? 0 : (Convert.ToDouble(row.Cells["cn_diff"].Value) * CurRate), 2)));

                if (tmppay > 0)
                {
                    if (tmpdiff > tmppay)
                    {
                        row.Cells["cn_topay"].Value = tmppay;
                        tmppay = 0;

                    }
                    else
                    {
                        row.Cells["cn_topay"].Value = tmpdiff;
                        tmppay = tmppay - tmpdiff;
                    }
                }
                else
                    break;
            }
            TotalMapped = AlreadyMapped();
        }
        public void SendPaymentNotification(int InvoiceDetId)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                //new SqlDataAdapter("SELECT top 1 isnull(d.ispaid, 0) as ispaid, isnull(q.name, '') as quotation, " +
                //                    "isnull(c.company, '') as customer, isnull(q.article, '') as custarticle " + 
                //                    "FROM FIN_DocDets d INNER JOIN SAL_Quotations q on q.id = d.quotid " +
                //                    "INNER JOIN BAS_Companies c on c.id = q.custid " +
                //                    "WHERE d.id = " + InvoiceDetId.ToString(), conn);
                new SqlDataAdapter("SELECT top 1 isnull(d.ispaid, 0) as ispaid,  " +
                                "isnull(q.name, isnulL(q1.name, ch.name)) as quotation,  " +
                                "isnull(c.company, isnull(c1.company, '')) as customer,  " +
                                "isnull(q.article, isnull(cd.custarticle, 'custarticle')) as custarticle " +
                                "FROM FIN_DocDets d " +
                                "LEFT JOIN SAL_Quotations q on q.id = d.quotid " +
                                "left JOIN BAS_Companies c on c.id = q.custid " +
                                "left join SAL_ClientOrdersDets cd on cd.id = d.coid " +
                                "left join SAL_ClientOrdersHead ch on ch.id = cd.headid " +
                                "left JOIN BAS_Companies c1 on c1.id = ch.clientid " +
                                "LEFT JOIN SAL_Quotations q1 on q1.id = cd.quotid " +
                                "WHERE d.id = " + InvoiceDetId.ToString(), conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["ispaid"]) == -1
                        && dr["quotation"].ToString() != "")
                    {
                        //Send letter to sales dept

                        string emailaddresses = DAL.EmailAddressesByType(6);

                        string strMessage = "Quotation/conf.order " + dr["quotation"].ToString() + " is paid!";
                        strMessage = strMessage + "\r\nCustomer: " + dr["customer"].ToString();
                        strMessage = strMessage + "\r\nArticle: " + dr["custarticle"].ToString();
                        MyHelper.SendDirectEMail(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Quotation/conf.order: " + dr["quotation"].ToString() + " is paid!", strMessage);

                    }
                }
            }
        }
    }
}
