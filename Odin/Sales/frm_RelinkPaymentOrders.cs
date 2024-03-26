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
    public delegate void RelinkSavedEventHandler(object sender);
    public partial class frm_RelinkPaymentOrders : KryptonForm
    {
        public frm_RelinkPaymentOrders()
        {
            InitializeComponent();
        }

        #region Variables

        public event RelinkSavedEventHandler SaveRelink;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        Helper MyHelper = new Helper();
        CO_BLL Bll = new CO_BLL();

        int _headid = 0;
        int _coid = 0;
        public int HeadId
        {
            get { return _headid; }
            set { _headid = value; }
        }
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public int CustId
        {
            get;
            set;
        }
        public int COId
        {
            get { return _coid; }
            set { _coid = value; }
        }
        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int ControlWidth = 250;
        public int oRowIndex = 0;
        public int oColumnIndex = 0;
        public string oColumnName = "";
        public string oCellValue = "";
        public double Mapped
        {
            get { return Convert.ToDouble(txt_TotalMapped.Text); }
            set { txt_TotalMapped.Text = value.ToString(); }
        }
        public double InPayment
        {
            get { return Convert.ToDouble(txt_TotalInPayment.Text); }
            set { txt_TotalInPayment.Text = value.ToString(); }
        }
        public double Rest
        {
            get { return Convert.ToDouble(txt_Rest.Text); }
            set { txt_Rest.Text = value.ToString(); }
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

        #endregion

        #region Methods

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                //if (Convert.ToInt32(row.Cells["cn_isresale"].Value) == -1)
                //    foreach (DataGridViewCell cell in row.Cells)
                //    { cell.Style.BackColor = Color.LemonChiffon; }
                //if (Convert.ToInt32(row.Cells["cn_allowtoinvoice"].Value) == 0)
                //    foreach (DataGridViewCell cell in row.Cells)
                //    { cell.Style.BackColor = Color.Tomato; }
            }
        }

        public void SetCellsColorNotPaid()
        {
            foreach (DataGridViewRow row in this.gv_Orders.Rows)
            {
                //if (Convert.ToInt32(row.Cells["cn_isresale"].Value) == -1)
                //    foreach (DataGridViewCell cell in row.Cells)
                //    { cell.Style.BackColor = Color.LemonChiffon; }
                //if (Convert.ToInt32(row.Cells["cn_allowtoinvoice"].Value) == 0)
                //    foreach (DataGridViewCell cell in row.Cells)
                //    { cell.Style.BackColor = Color.Tomato; }
            }
        }


        public void FillPayment(int _paymentid, int _coid)
        {
            ds_List.Clear();

            var data = (DataTable)Helper.getSP("sp_SelectPaymentDets", _paymentid, _coid);
           
            foreach (DataRow row in data.Rows)
            {
                DataRow row1 = dt_List.NewRow();

                row1["id"] = row["id"];
                row1["invoice"] = row["invoice"];
                row1["conforder"] = row["conforder"];
                row1["quota"] = row["quota"];
                row1["amount"] = row["amount"];
                row1["currency"] = row["currency"];
                row1["artid"] = row["artid"];
                row1["article"] = row["article"];
                row1["coid"] = row["coid"];
                row1["quotid"] = row["quotid"];
                row1["invoiceid"] = row["invoiceid"];
                row1["oldamount"] = row["amount"];

                dt_List.Rows.Add(row1);
            }
            this.bs_List.ResetBindings(false);
            SetCellsColor();
        }

        public void FillNotPaid(int _custid)
        {
            ds_Orders.Clear();

            var data = (DataTable)Helper.getSP("sp_SelectPaymentNotPaidDets", _custid, InvoiceType);

            foreach (DataRow row in data.Rows)
            {
                DataRow row1 = dt_Orders.NewRow();

                row1["id"] = row["id"];
                row1["invoice"] = row["invoice"];
                row1["conforder"] = row["conforder"];
                row1["quota"] = row["quota"];
                row1["amount"] = row["amount"];
                row1["currency"] = row["currency"];
                row1["artid"] = row["artid"];
                row1["article"] = row["article"];
                row1["coid"] = row["coid"];
                row1["quotid"] = row["quotid"];
                row1["invoiceid"] = row["invoiceid"];
                row1["topay"] = row["amount"];

                dt_Orders.Rows.Add(row1);
            }
            this.bs_Orders.ResetBindings(false);
            SetCellsColorNotPaid();
        }

        public void RecalcMapped()
        {
            double _mapped = 0;
            foreach (DataRow row in dt_List.Rows)
                _mapped = _mapped + Convert.ToDouble(row["amount"]);
            Mapped = Math.Round(_mapped, 2);
            Rest = Math.Round(InPayment - Mapped, 2);
        }

        public bool CheckMapped()
        {
            return Mapped <= InPayment;
        }
        public void FillDates()
        {
            txt_PayDate.Value = DateTime.Now;
        }

        public void SendPaymentNotification(int InvoiceDetId)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT top 1 isnull(d.ispaid, 0) as ispaid, isnull(q.name, '') as quotation, " +
                                    "isnull(c.company, '') as customer, isnull(q.article, '') as custarticle " +
                                    "FROM FIN_DocDets d INNER JOIN SAL_Quotations q on q.id = d.quotid " +
                                    "INNER JOIN BAS_Companies c on c.id = q.custid " +
                                    "WHERE d.id = " + InvoiceDetId.ToString(), conn);
            adapter.Fill(ds);

            conn.Close();

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
                foreach (DataRow dr in dt.Rows)
                    if (Convert.ToInt32(dr["ispaid"]) == -1
                        && dr["quotation"].ToString() != "")
                    {
                        //Send letter to sales dept

                        string emailaddresses = DAL.EmailAddressesByType(6);

                        string strMessage = "Quotation " + dr["quotation"].ToString() + " is paid!";
                        strMessage = strMessage + "\r\nCustomer: " + dr["customer"].ToString();
                        strMessage = strMessage + "\r\nArticle: " + dr["custarticle"].ToString();
                        MyHelper.SendDirectEMail(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Quotation: " + dr["quotation"].ToString() + " is paid!", strMessage);
                    }
        }

        #endregion

        #region Controls
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _k = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            foreach (DataRow row in dt_List.Rows)
            {
                if (Convert.ToInt32(row["id"]) == _id)
                {
                    //Add to not-paid or update existed

                    foreach (DataRow row2 in dt_Orders.Rows)
                        if (Convert.ToInt32(row2["invoiceid"]) == Convert.ToInt32(row["invoiceid"]))
                        {
                            row2["amount"] = Convert.ToDouble(row2["amount"]) + Convert.ToDouble(row["amount"]);
                            row2["topay"] = Convert.ToDouble(row["amount"]);
                            row2["id"] = Convert.ToInt32(row["id"]);
                            row2["oldamount"] = row["oldamount"];
                            _k++;
                            break;
                        }

                    if (_k == 0)
                    {
                        DataRow row1 = dt_Orders.NewRow();

                        row1["id"] = row["id"];
                        row1["invoice"] = row["invoice"];
                        row1["conforder"] = row["conforder"];
                        row1["quota"] = row["quota"];
                        row1["amount"] = row["amount"];
                        row1["currency"] = row["currency"];
                        row1["artid"] = row["artid"];
                        row1["article"] = row["article"];
                        row1["coid"] = row["coid"];
                        row1["quotid"] = row["quotid"];
                        row1["invoiceid"] = row["invoiceid"];
                        row1["topay"] = 0;
                        row1["oldamount"] = row["oldamount"];

                        dt_Orders.Rows.Add(row1);
                    }

                    //Delete from existed
                    row.Delete();
                    RecalcMapped();

                    this.bs_List.ResetBindings(false);

                    SetCellsColor();
                    SetCellsColorNotPaid();

                    break;
                }
            }
        }
        
        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {
            int _k = 0;

            foreach (DataRow row in dt_List.Rows)
            {
                //Add to not-paid or update existed
                _k = 0;
                foreach (DataRow row2 in dt_Orders.Rows)
                    if (Convert.ToInt32(row2["invoiceid"]) == Convert.ToInt32(row["invoiceid"]))
                    {
                        row2["amount"] = Convert.ToDouble(row2["amount"]) + Convert.ToDouble(row["amount"]);
                        row2["topay"] = Convert.ToDouble(row["amount"]);
                        row2["id"] = Convert.ToInt32(row["id"]);
                        row2["oldamount"] = row["oldamount"];
                        _k++;
                        break;
                    }
                if (_k == 0)
                {
                    DataRow row1 = dt_Orders.NewRow();

                    row1["id"] = row["id"];
                    row1["invoice"] = row["invoice"];
                    row1["conforder"] = row["conforder"];
                    row1["quota"] = row["quota"];
                    row1["amount"] = row["amount"];
                    row1["currency"] = row["currency"];
                    row1["artid"] = row["artid"];
                    row1["article"] = row["article"];
                    row1["coid"] = row["coid"];
                    row1["quotid"] = row["quotid"];
                    row1["invoiceid"] = row["invoiceid"];
                    row1["topay"] = 0;
                    row1["oldamount"] = row["oldamount"];

                    dt_Orders.Rows.Add(row1);
                }

            }
            dt_List.Clear();
            RecalcMapped();

            this.bs_List.ResetBindings(false);

            SetCellsColor();
            SetCellsColorNotPaid();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            gv_Orders.EndEdit();

            int _id = 0;
            int _k = 0;

            try { _id = Convert.ToInt32(gv_Orders.CurrentRow.Cells["cn_oinvoiceid"].Value); }
            catch { }

            foreach (DataRow row in dt_Orders.Rows)
                if (Convert.ToInt32(row["invoiceid"]) == _id)
                    if (InPayment >= Mapped + Convert.ToDouble(row["topay"]))
                    {
                        foreach (DataRow row2 in dt_List.Rows)
                            if (Convert.ToInt32(row2["invoiceid"]) == Convert.ToInt32(row["invoiceid"]))
                            {
                                row2["amount"] = Convert.ToDouble(row2["amount"]) + Convert.ToDouble(row["topay"]);
                                _k++;
                                break;
                            }

                        if (_k == 0)
                        {
                            DataRow row1 = dt_List.NewRow();

                            row1["id"] = row["id"];
                            row1["invoice"] = row["invoice"];
                            row1["conforder"] = row["conforder"];
                            row1["quota"] = row["quota"];
                            row1["amount"] = row["topay"];
                            row1["currency"] = row["currency"];
                            row1["artid"] = row["artid"];
                            row1["article"] = row["article"];
                            row1["coid"] = row["coid"];
                            row1["quotid"] = row["quotid"];
                            row1["invoiceid"] = row["invoiceid"];
                            row1["oldamount"] = row["oldamount"];

                            dt_List.Rows.Add(row1);
                        }

                        if (Convert.ToDouble(row["topay"]) >= Convert.ToDouble(row["amount"]))
                            //Add to not-paid

                            //Delete from existed
                            row.Delete();
                        else
                        {
                            row["amount"] = Convert.ToDouble(row["amount"]) - Convert.ToDouble(row["topay"]);
                            row["topay"] = 0;
                        }

                        RecalcMapped();

                        this.bs_Orders.ResetBindings(false);

                        SetCellsColor();
                        SetCellsColorNotPaid();

                        break;
                    }
                    else
                        glob_Class.ShowMessage("Error in check-in!", "Please check mapped sum!", "Mapped sum can not be more than in payment!");
        }

        private void btn_Wizard_Click(object sender, EventArgs e) { }

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
            //SetCellsColor();
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
            //SetCellsColor();
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
            //SetCellsColor();
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            //SetCellsColor();
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
                Helper.LoadColumns(gv_List, this.Name);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            //ED.DgvIntoExcel();
        }

        #endregion

        #region Context menu orders

        private void mnu_Orders_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Orders.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Orders.HitTest(mpoint.X, mpoint.Y);

                oRowIndex = info.RowIndex;
                oColumnIndex = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Orders.ClearSelection();
                gv_Orders.Rows[oRowIndex].Cells[oColumnIndex].Selected = true;
                gv_Orders.CurrentCell = gv_Orders.Rows[oRowIndex].Cells[oColumnIndex];

                oCellValue = gv_Orders.Rows[oRowIndex].Cells[oColumnIndex].Value.ToString();
                oColumnName = gv_Orders.Columns[oColumnIndex].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));
            }
            catch
            {
                oRowIndex = 0;
                oColumnIndex = 0;
                return;
            }
        }

        private void mni_oFilterFor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_Orders.Filter = ("Convert(" + oColumnName + " , 'System.String') like '%" + mni_oFilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            //SetCellsColor();
        }

        private void mni_oSearch_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Orders;
            frm.ColumnNumber = gv_Orders.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Orders.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_oFilterBy_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Orders.Filter = String.IsNullOrEmpty(bs_Orders.Filter) == true
                    ? String.IsNullOrEmpty(oCellValue) == true
                        ? "(" + oColumnName + " is null OR Convert(" + oColumnName + ", 'System.String') = '')"
                        : "Convert(" + oColumnName + " , 'System.String') = '" + glob_Class.NES(oCellValue) + "'"
                    : String.IsNullOrEmpty(oCellValue) == true
                        ? bs_Orders.Filter + "AND (" + oColumnName + " is null OR Convert(" + oColumnName + ", 'System.String') = '')"
                        : bs_Orders.Filter + " AND Convert(" + oColumnName + " , 'System.String') = '" + glob_Class.NES(oCellValue) + "'";
                //MessageBox.Show(bs_List.Filter);
            }
            catch { }
            //SetCellsColor();
        }

        private void mni_oFilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Orders.Filter = String.IsNullOrEmpty(bs_Orders.Filter) == true
                    ? "Convert(" + oColumnName + " , 'System.String') <> '" + oCellValue + "'"
                    : bs_Orders.Filter + " AND " + oColumnName + " <> '" + oCellValue + "'";
            }
            catch { }
            //SetCellsColor();
        }

        private void mni_oRemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Orders.RemoveFilter();
            }
            catch { }
            //SetCellsColor();
        }

        private void mni_oCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(oCellValue.ToString());
        }

        private void mni_oAdmin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for order payments list";
            frm.grid = this.gv_Orders;
            frm.formname = this.Name;
            DAL.UserLogin = Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                Helper.LoadColumns(gv_Orders, this.Name);
            }
        }

        private void btn_oExcel_Click(object sender, EventArgs e)
        {
            //ED1.DgvIntoExcel();
        }

        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (CheckMapped() == true)
            {
                string _expr = "";
                DataRow[] foundRows;

                foreach (DataRow row in dt_List.Rows)
                    if (Convert.ToInt32(row["id"]) == 0)
                    {
                        //Adding line
                        Helper.getSP("sp_AddPaymentDetails", HeadId, Convert.ToInt32(row["invoiceid"]),
                                                Convert.ToDateTime(txt_PayDate.Value).ToShortDateString(),
                                                Convert.ToDouble(row["amount"]));
                        SendPaymentNotification(Convert.ToInt32(row["invoiceid"]));
                    }
                    else
                        if (Convert.ToDouble(row["amount"]) != Convert.ToDouble(row["oldamount"]))
                        //Updating line
                        {
                            Helper.getSP("sp_EditPaymentDetails", Convert.ToInt32(row["id"]), Convert.ToDouble(row["amount"]),
                                                    Convert.ToDateTime(txt_PayDate.Value).ToShortDateString());
                            SendPaymentNotification(Convert.ToInt32(row["invoiceid"]));
                        }

                foreach (DataRow row1 in dt_Orders.Rows)
                    if (Convert.ToInt32(row1["id"]) != 0)
                    {
                        _expr = "id = " + row1["id"].ToString();
                        foundRows = dt_List.Select(_expr);
                        if (foundRows.Length == 0)
                            //Delete row from payment
                            Helper.getSP("sp_DeletePaymentDetails", Convert.ToInt32(row1["id"]));
                    }

                FillPayment(HeadId, COId);
                FillNotPaid(CustId);
                SaveRelink?.Invoke(this);
            }
            else
                glob_Class.ShowMessage("Error in check-in!", "Please check mapped sum!", "Mapped sum can not be more than in payment!");
        }

        #endregion

        private void frm_RelinkPaymentOrders_Load(object sender, EventArgs e)
        {
            Helper.LoadColumns(gv_List, this.Name);
            Helper.LoadColumns(gv_Orders, this.Name);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TotalInPayment_TextChanged(object sender, EventArgs e) { }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void gv_Orders_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColorNotPaid();
        }

        private void gv_Orders_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_Orders.EndEdit();
            if (Convert.ToDouble(gv_Orders.CurrentRow.Cells["cn_topay"].Value) > Convert.ToDouble(gv_Orders.CurrentRow.Cells["cn_oamount"].Value))
                gv_Orders.CurrentRow.Cells["cn_topay"].Value = Convert.ToDouble(gv_Orders.CurrentRow.Cells["cn_oamount"].Value);
        }

        private void txt_PayDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_PayDate.Value = txt_PayDate.Value == null ? System.DateTime.Now : txt_PayDate.Value;
        }

        private void rb_Proforma_CheckedChanged(object sender, EventArgs e)
        {
            FillPayment(HeadId, COId);
            FillNotPaid(CustId);
        }

        private void rb_Invoice_CheckedChanged(object sender, EventArgs e)
        {
            FillPayment(HeadId, COId);
            FillNotPaid(CustId);
        }

        private void rb_All_CheckedChanged(object sender, EventArgs e)
        {
            FillPayment(HeadId, COId);
            FillNotPaid(CustId);
        }

        private void btn_Add_MouseMove(object sender, MouseEventArgs e)
        {
            gv_Orders.EndEdit();
        }

        private void btn_Add_MouseDown(object sender, MouseEventArgs e) { }
    }
}