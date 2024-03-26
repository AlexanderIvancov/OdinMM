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
    public partial class frm_RelinkPaymentOrdersNew : KryptonForm
    {
        public frm_RelinkPaymentOrdersNew()
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
            set { _mode = value; }
        }
        public string Payment
        {
            get { return txt_Payment.Text; }
            set { txt_Payment.Text = value; }
        }
        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        public double Mapped
        {
            get { return Convert.ToDouble(txt_TotalMapped.Text); }
            set { txt_TotalMapped.Text = value.ToString(); }
        }
        public double ToFree
        {
            get { return Convert.ToDouble(txt_ToFree.Text); }
            set { txt_ToFree.Text = value.ToString(); }
        }
        public double Rest
        {
            get { return Convert.ToDouble(txt_Rest.Text); }
            set { txt_Rest.Text = value.ToString(); }
        }
        public double TotalRest
        {
            get { return Convert.ToDouble(txt_TotalFree.Text); }
            set { txt_TotalFree.Text = value.ToString(); }
        }
        public int CurId
        {
            get { return cmb_Currency1.CurrencyId; }
            set { cmb_Currency1.CurrencyId = value; }
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

        public void LoadColumns(DataGridView grid)
        {
            DAL.UserLogin = Environment.UserName;

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
                    foreach (DataGridViewColumn column in grid.Columns)
                        if (column.Name == reader["columnname"].ToString())
                        {
                            column.DisplayIndex = Convert.ToInt32(reader["columnorder"]);
                            column.HeaderText = reader["columntext"].ToString();
                            column.Visible = glob_Class.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                reader.Close();
            }

            sqlConn.Close();
        }

        public void FillDates()
        {
            txt_PayDate.Value = DateTime.Now;
        }

        public void FillAutoDoc()
        {
            Payment = DAL.AutoDoc(18, DateTime.Now.ToShortDateString());
        }

        public void FillList()
        {
            var data = (DataTable)Helper.getSP("sp_PaymentsListByOrdersRelink", cmb_Firms2.FirmId);

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

        public void FillTotals(int _custid)
        {
            ToFree = 0;
            Mapped = 0;
            Rest = Convert.ToDouble(Helper.GetOneRecord("select dbo.fn_PaymentsFreeTotals(" + _custid + ")"));
            TotalRest = Rest;
            CurId = Convert.ToInt32(Helper.GetOneRecord("select dbo.fn_PaymentsCurrencyTotals(" + _custid + ")"));
        }

        public void RecalcTotals()
        {
            double _totfree = 0;
            double _totmap = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                _totfree = _totfree + Convert.ToDouble(row.Cells["cn_tofree"].Value);
                _totmap = _totmap + Convert.ToDouble(row.Cells["cn_tomap"].Value);
            }

            ToFree = _totfree;
            Mapped = _totmap;
            TotalRest = Rest + ToFree;
            txt_TotalMapped.StateDisabled.Back.Color1 = ToFree + Rest < Mapped ? Color.Red : Color.White;
        }

        public void ClearFields()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_tofree"].Value = 0;
                row.Cells["cn_tomap"].Value = 0;
            }
            SetCellsColor();
        }

        public bool CheckPayAll()
        {
            bool _res = false;

            foreach (DataGridViewRow row in this.gv_List.Rows)
                if (Convert.ToInt32(row.Cells["chk_payall"].Value) != 0)
                {
                    _res = true;
                    break;
                }

            return _res;
        }

        public bool CheckEmpty()
        {
            bool res = true;

            if (cmb_Currency1.CurrencyId == 0)
                res = false;
            return res;
        }

        public double AlreadyMapped()
        {
            double _res = 0;
            foreach (DataGridViewRow row in this.gv_List.Rows)
                _res = _res + Convert.ToDouble(row.Cells["cn_tomap"].Value);

            return Math.Round(_res, 2);
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
                Helper.LoadColumns(gv_List, this.Name);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        #endregion

        private void frm_RelinkPaymentOrdersNew_Load(object sender, EventArgs e)
        {
            Helper.LoadColumns(gv_List, this.Name);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillList();
            FillTotals(cmb_Firms2.FirmId);
        }

        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            if (CheckEmpty() == true)
            {
                if (Mapped > 0
                    || ToFree > 0
                    || CheckPayAll() == true)
                {
                    int _headres = Convert.ToInt32(Helper.getSP("sp_AddPaymentHeader", cmb_Firms2.FirmId, 18, Convert.ToDateTime(txt_PayDate.Value).ToShortDateString(), Mapped - ToFree, 0, CurId, 1, Comments));

                    //if (_headres != 0)
                    //{
                    //    foreach (DataGridViewRow row in this.gv_List.Rows)
                    //    {
                    //        //Details
                    //        if (Convert.ToDouble(row.Cells["cn_topay"].Value) > 0)
                    //        {
                    //            COBll.AddPaymentDetails(_headres, Convert.ToInt32(row.Cells["cn_id"].Value),
                    //                            Convert.ToDateTime(txt_PayDate.Value).ToShortDateString(),
                    //                            Convert.ToDouble(row.Cells["cn_topay"].Value));
                    //            SendPaymentNotification(Convert.ToInt32(row.Cells["cn_id"].Value));
                    //        }


                    //    }
                    //}
                    if (_headres != 0)
                    {
                        //1st - free
                        foreach (DataGridViewRow row in this.gv_List.Rows)
                            if (Convert.ToDouble(row.Cells["cn_tofree"].Value) > 0)
                                Helper.getSP("sp_ReleasePaymentDetails", _headres, Convert.ToInt32(row.Cells["cn_id"].Value), CurId,
                                                  Convert.ToDouble(row.Cells["cn_tofree"].Value), Convert.ToInt32(row.Cells["cn_quotid"].Value));

                        //2nd - add
                        foreach (DataGridViewRow row in this.gv_List.Rows)
                            if (Convert.ToDouble(row.Cells["cn_tomap"].Value) > 0
                                || Convert.ToInt32(row.Cells["chk_payall"].Value) != 0)
                                Helper.getSP("sp_RelinkPaymentDetails", _headres, Convert.ToInt32(row.Cells["cn_id"].Value), CurId,
                                                  Convert.ToDouble(row.Cells["cn_tomap"].Value), Convert.ToInt32(row.Cells["chk_payall"].Value),
                                                  Convert.ToInt32(row.Cells["cn_quotid"].Value));
                    }
                }

                FillList();
                FillTotals(cmb_Firms2.FirmId);
            }
            else
                glob_Class.ShowMessage("Empty fields detected!", "Currency is not selected!", "Please choose currency!");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();

            double _alreadymapped = AlreadyMapped();
           
            if (cmb_Currency1.Currency == (gv_List.CurrentRow.Cells["cn_curr"].Value.ToString() == "" ? "EUR" : gv_List.CurrentRow.Cells["cn_curr"].Value.ToString()))
            {

                if (gv_List.CurrentRow.Cells["cn_tofree"].Selected == true)
                {
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_leftinadvance"].Value) < Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tofree"].Value))
                        gv_List.CurrentRow.Cells["cn_tofree"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_leftinadvance"].Value);
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tofree"].Value) < 0)
                        gv_List.CurrentRow.Cells["cn_tofree"].Value = 0;
                }
                if (gv_List.CurrentRow.Cells["cn_tomap"].Selected == true)
                    if (AlreadyMapped() > Rest + ToFree)
                        gv_List.CurrentRow.Cells["cn_tomap"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tomap"].Value) - (AlreadyMapped() - (Rest + ToFree));
            }
            else
            {
                if (gv_List.CurrentRow.Cells["cn_tofree"].Selected == true)
                {
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_leftinadvanceeur"].Value) < Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tofree"].Value))
                        gv_List.CurrentRow.Cells["cn_tofree"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_leftinadvanceeur"].Value);
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tofree"].Value) < 0)
                        gv_List.CurrentRow.Cells["cn_tofree"].Value = 0;
                }
                if (gv_List.CurrentRow.Cells["cn_tomap"].Selected == true)
                    if (AlreadyMapped() > Rest + ToFree)
                        gv_List.CurrentRow.Cells["cn_tomap"].Value = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_tomap"].Value) - (AlreadyMapped() - (Rest + ToFree));
            }
            RecalcTotals();
        }

        private void cmb_Firms2_FirmsChanged(object sender)
        {
            CurId = cmb_Firms2.CurId;            
        }

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 18)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.money_delete.Width;
                var h = Global_Resourses.money_delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.money_delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 20)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.money_add.Width;
                var h = Global_Resourses.money_add.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.money_add, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            //double cocurrate = 0;
            double tmpdiff = 0;

            double _alreadymapped = AlreadyMapped();

            try
            {
                if (cmb_Currency1.Currency == gv_List.CurrentRow.Cells["cn_curr"].Value.ToString())
                    {

                    //cocurrate = Convert.ToDouble(Helper.GetOneRecord("set dateformat dmy select dbo.fn_CurRate(" + Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) + ", "
                    //        + "convert(datetime, '" + (PayDate.Trim() == "" ? System.DateTime.Now.ToShortDateString() : PayDate.Trim()) + "'))"));


                    //tmpdiff = (CurId == Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) ? Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) :
                    //                    (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_curid"].Value) != 1 ? Math.Round(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) * cocurrate, 2) :
                    //                    Math.Round(CurRate == 0 ? 0 : (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_diff"].Value) / CurRate), 2)));

                    tmpdiff = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value) > Rest + ToFree - _alreadymapped ?
                                        Rest + ToFree - _alreadymapped :
                                        (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value) < 0 ? 0 : Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value));

                    if (gv_List.CurrentRow.Cells["btn_add"].Selected == true)
                    {
                        gv_List.CurrentRow.Cells["cn_tomap"].Value = tmpdiff;
                        //if (tmpdiff - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value) > Summa - AlreadyMapped())
                        //    gv_List.CurrentRow.Cells["cn_topay"].Value = Summa - AlreadyMapped() + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value);
                        //else
                        //    gv_List.CurrentRow.Cells["cn_topay"].Value = tmpdiff;
                    }
                    if (gv_List.CurrentRow.Cells["btn_tofree"].Selected == true
                        && Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value) < 0)
                    {
                        gv_List.CurrentRow.Cells["cn_tofree"].Value = -1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value);
                        //if (tmpdiff - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value) > Summa - AlreadyMapped())
                        //    gv_List.CurrentRow.Cells["cn_topay"].Value = Summa - AlreadyMapped() + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value);
                        //else
                        //    gv_List.CurrentRow.Cells["cn_topay"].Value = tmpdiff;
                    }
                }
                else
                    if (gv_List.CurrentRow.Cells["btn_tofree"].Selected == true
                        && Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value) < 0)
                    {
                        gv_List.CurrentRow.Cells["cn_tofree"].Value = -1 * Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value);
                        //if (tmpdiff - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value) > Summa - AlreadyMapped())
                        //    gv_List.CurrentRow.Cells["cn_topay"].Value = Summa - AlreadyMapped() + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value);
                        //else
                        //    gv_List.CurrentRow.Cells["cn_topay"].Value = tmpdiff;
                    }
            }
            catch { }
            RecalcTotals();
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();
            if (gv_List.CurrentRow.Cells["chk_payall"].Selected == true
               && Convert.ToInt32(gv_List.CurrentRow.Cells["chk_payall"].Value) == -1)
            {
                double tmpdiff = 0;
                double _alreadymapped = AlreadyMapped();

                if (cmb_Currency1.Currency == gv_List.CurrentRow.Cells["cn_curr"].Value.ToString())
                {

                    tmpdiff = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value) > Rest + ToFree - _alreadymapped ?
                                        Rest + ToFree - _alreadymapped :
                                        (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value) < 0 ? 0 : Convert.ToDouble(gv_List.CurrentRow.Cells["cn_lefttopay"].Value));

                    if (gv_List.CurrentRow.Cells["chk_payall"].Selected == true)
                    {
                        gv_List.CurrentRow.Cells["cn_tomap"].Value = tmpdiff;
                        //if (tmpdiff - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value) > Summa - AlreadyMapped())
                        //    gv_List.CurrentRow.Cells["cn_topay"].Value = Summa - AlreadyMapped() + Convert.ToDouble(gv_List.CurrentRow.Cells["cn_topay"].Value);
                        //else
                        //    gv_List.CurrentRow.Cells["cn_topay"].Value = tmpdiff;
                    }
                }
            }
            RecalcTotals();
        }

        private void gv_List_CellEndEdit(object sender, DataGridViewCellEventArgs e) { }
    }
}