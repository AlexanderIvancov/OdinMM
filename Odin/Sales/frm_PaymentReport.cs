using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
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
    public partial class frm_PaymentReport : BaseForm
    {
        public frm_PaymentReport()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "Payments.xls", this.Name);
            ED1 = new ExportData(this.gv_Orders, "Order payments.xls", this.Name);

        }
        #region Variables

        ExportData ED;
        ExportData ED1;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        Helper MyHelper = new Helper();
        CO_BLL Bll = new CO_BLL();


        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int ControlWidth = 250;

        public int oRowIndex = 0;
        public int oColumnIndex = 0;
        public string oColumnName = "";
        public string oCellValue = "";

        #endregion

        #region Methods

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

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }

            var data = CO_BLL.getPayments(txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(),
                                            cmb_Firms2.FirmId);

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

        public void bw_OrdersList(object sender, DoWorkEventArgs e)
        {
            try
            {
                bs_Orders.RemoveFilter();
            }
            catch { }

            var data = CO_BLL.getPaymentsByOrders(txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(),
                                            cmb_Firms2.FirmId);

            gv_Orders.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_Orders.SortedColumn;
                var dir = Helper.SaveDirection(gv_Orders);


                gv_Orders.AutoGenerateColumns = false;
                bs_Orders.DataSource = data;
                gv_Orders.DataSource = bs_Orders;

                Helper.RestoreDirection(gv_Orders, oldColumn, dir);

            });


            bn_Orders.ThreadSafeCall(delegate
            {
                bn_Orders.BindingSource = bs_Orders;
            });
        }

        public void FillPayments()
        {
            var data = CO_BLL.getPayments(txt_CreatDateFrom.Value == null ? "" : txt_CreatDateFrom.Value.ToString().Trim(),
                                            txt_CreatDateTill.Value == null ? "" : txt_CreatDateTill.Value.ToString().Trim(),
                                            cmb_Firms2.FirmId);

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

        public void PaymentAdded(object sender)
        {
            bwStart(bw_List);
        }

        public void FillPagesDets()
        {
            khg_Dets.Visible = dn_Pages.SelectedPage != pg_Payments;

        }

        public void SaveRelink(object sender)
        {
            bwStart(bw_List);
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_amount"].Value) > Convert.ToDouble(row.Cells["cn_mapped"].Value))
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Gold;
            }
        }
        #endregion

        #region Controls
        private void frm_PaymentReport_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = kryptonDockingManager1.ManageWorkspace(kryptonDockableWorkspace1);
            kryptonDockingManager1.ManageControl(kryptonSplitContainer1.Panel2, w);
            kryptonDockingManager1.ManageFloating(this);

            LoadColumns(gv_List);
            txt_CreatDateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null;
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
                LoadColumns(gv_List);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
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
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Orders);
            }
        }

        private void btn_oExcel_Click(object sender, EventArgs e)
        {
            ED1.DgvIntoExcel();
        }



        #endregion

        #endregion

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (dn_Pages.SelectedPage == pg_Payments)
            {
                bwStart(bw_List);
            }
            else if (dn_Pages.SelectedPage == pg_Invoices)
            {

            }
            else
            {
                bwStart(bw_OrdersList);
            }

        }



        private void txt_CreatDateFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateFrom.Value = txt_CreatDateFrom.Value == null ? System.DateTime.Now : txt_CreatDateFrom.Value;
        }

        private void txt_CreatDateTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_CreatDateTill.Value = txt_CreatDateTill.Value == null ? System.DateTime.Now : txt_CreatDateTill.Value;
        }

        private void frm_PaymentReport_Resize(object sender, EventArgs e)
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

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddPayment")) return;

            frm_AddPayment frm = new frm_AddPayment();
            frm.FillAutoDoc();
            frm.SavePayment += new SavePaymentEventHandler(PaymentAdded);
            frm.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string _payment = "";
            int _headid = 0;
            double _amount = 0;
            double _mapped = 0;
            int _buyerid = 0;
            string _regdate = "";
            double _vatperc = 0;
            string _comments = "";
            int _curid = 0;
            double _currate = 0;
            try
            {
                _payment = gv_List.CurrentRow.Cells["cn_payment"].Value.ToString();
                _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _amount = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_amount"].Value);
                _mapped = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_mapped"].Value);
                _buyerid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_buyerid"].Value);
                _regdate = gv_List.CurrentRow.Cells["cn_regdate"].Value.ToString();
                _vatperc = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_vatperc"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _curid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value);
                _currate = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_currate"].Value);
            }
            catch { }

            if (_headid != 0)
            {

                frm_EditPayment frm = new frm_EditPayment();
                frm.Id = _headid;
                frm.Payment = _payment;
                frm.BuyerId = _buyerid;
                frm.PayDate = _regdate;
                frm.Summa = _amount;
                frm.TotalMapped = _mapped;
                frm.VatPerc = _vatperc;
                frm.CurId = _curid;
                frm.CurRate = _currate;
                frm.Comments = _comments;

                frm.CalcPriceVat();
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string _res = Bll.EditPaymentHeader(frm.Id, frm.PayDate, frm.Summa, frm.VatPerc, frm.CurId, frm.CurRate, frm.Comments);

                    if (Bll.SuccessId == -1)
                        bwStart(bw_List);

                }

            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _headid = 0;
            try { _headid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }
            if (_headid != 0
                && glob_Class.DeleteConfirm() == true)
            {
                Bll.DeletePayment(_headid);

                bwStart(bw_List);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_Firms2.FirmId = 0;
            txt_CreatDateFrom.Value = null;// Convert.ToDateTime("01/01/2000");
            txt_CreatDateTill.Value = null;
            cmb_Quotations1.QuotationId = 0;
            cmb_SalesOrders1.SalesOrderId = 0;
        }

        private void kryptonDockingManager1_DockspaceAdding(object sender, DockspaceEventArgs e)
        {
            e.DockspaceControl.Size = new Size(ControlWidth, kryptonDockableWorkspace1.Height);
        }

        private void gv_Orders_SelectionChanged(object sender, EventArgs e)
        {
            int _coid = 0;
            int _quotid = 0;

            try
            {
                _coid = Convert.ToInt32(gv_Orders.CurrentRow.Cells["cn_oid"].Value);
                _quotid = Convert.ToInt32(gv_Orders.CurrentRow.Cells["cn_oquotid"].Value);
            }
            catch { }

            if (_coid != 0 || _quotid != 0)
            {
                var data = CO_BLL.getCOPayments(_coid, _quotid);

                gv_PayDetails.ThreadSafeCall(delegate
                {
                    DataGridViewColumn oldColumn = gv_PayDetails.SortedColumn;
                    var dir = Helper.SaveDirection(gv_PayDetails);

                    gv_PayDetails.AutoGenerateColumns = false;
                    bs_PayDetails.DataSource = data;
                    gv_PayDetails.DataSource = bs_PayDetails;


                    Helper.RestoreDirection(gv_PayDetails, oldColumn, dir);

                    bn_PayDetails.ThreadSafeCall(delegate
                    {
                        bn_PayDetails.BindingSource = bs_PayDetails;
                    });

                });


            }
        }

        private void btn_relink_Click(object sender, EventArgs e)
        {
            int _id = 0;
            double _amount = 0;
            string _payment = "";
            int _custid = 0;
            string _paydate = "";

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _amount = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_amount"].Value);
                _payment = gv_List.CurrentRow.Cells["cn_payment"].Value.ToString();
                _custid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_buyerid"].Value);
                _paydate = gv_List.CurrentRow.Cells["cn_regdate"].Value.ToString();
            }
            catch { }

            if (_id != 0 && _amount != 0)
            {
                frm_RelinkPaymentOrders frm = new frm_RelinkPaymentOrders();
                frm.HeadId = _id;
                frm.InPayment = _amount;
                frm.CustId = _custid;
                frm.COId = 0;
                frm.HeaderText = "Remapping payment for: " + _payment;
                frm.PayDate = _paydate;
                frm.SaveRelink += new RelinkSavedEventHandler(SaveRelink);
                frm.FillPayment(_id, 0);
                frm.FillNotPaid(_custid);
                frm.RecalcMapped();
                frm.Show();

                frm.gv_List.ThreadSafeCall(delegate { frm.SetCellsColor(); });
                frm.gv_Orders.ThreadSafeCall(delegate { frm.SetCellsColorNotPaid(); });
                //frm.Hed
            }
        }

        private void dn_Pages_Click(object sender, EventArgs e)
        {
            FillPagesDets();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_relink1_Click(object sender, EventArgs e)
        {
            int _id = 0;
            double _amount = 0;
            string _payment = "";
            int _custid = 0;
            string _paydate = "";
            int _coid = 0;

            try
            {
                _id = Convert.ToInt32(gv_PayDetails.CurrentRow.Cells["cn_payheadid"].Value);
                _coid = Convert.ToInt32(gv_Orders.CurrentRow.Cells["cn_oid"].Value);
                _amount = Convert.ToDouble(gv_PayDetails.CurrentRow.Cells["cn_dpaymentsum"].Value);
                _payment = gv_PayDetails.CurrentRow.Cells["cn_dpayment"].Value.ToString();
                _custid = Convert.ToInt32(gv_Orders.CurrentRow.Cells["cn_obuyerid"].Value);
                _paydate = gv_PayDetails.CurrentRow.Cells["cn_paymentdate"].Value.ToString();
            }
            catch { }

            if (_id != 0 && _amount != 0)
            {
                frm_RelinkPaymentOrders frm = new frm_RelinkPaymentOrders();
                frm.HeadId = _id;
                frm.InPayment = _amount;
                frm.CustId = _custid;
                frm.COId = _coid;
                frm.HeaderText = "Remapping payment for: " + _payment;
                frm.PayDate = _paydate;
                frm.SaveRelink += new RelinkSavedEventHandler(SaveRelink);
                frm.FillPayment(_id, _coid);
                frm.FillNotPaid(_custid);
                frm.RecalcMapped();
                frm.Show();

                frm.gv_List.ThreadSafeCall(delegate { frm.SetCellsColor(); });
                frm.gv_Orders.ThreadSafeCall(delegate { frm.SetCellsColorNotPaid(); });
                //frm.Hed
            }
        }

        private void btn_relink2_Click(object sender, EventArgs e)
        {
            frm_RelinkPaymentOrdersCur frm = new frm_RelinkPaymentOrdersCur();
            frm.FillDates();
            frm.FillAutoDoc();
            frm.SavePayment += new SavePaymentEventHandler(SaveRelink);//+= new RelinkSavedEventHandler(SaveRelink);
            frm.Show();
        }
    }
}
