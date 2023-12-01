using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Warehouse.StockIn
{
    public delegate void StockSavedEventHandler(object sender);

    public partial class frm_AddStockInFromPO : KryptonForm
    {
        public frm_AddStockInFromPO()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "PODetails.xls", this.Name);
            PopupHelper = new PopupWindowHelper();
        }

        #region Variables

        CMB_BLL Bll = new CMB_BLL();

        public event StockSavedEventHandler StockLineSaved;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        StockIn_BLL SIBll = new StockIn_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        PopupWindowHelper PopupHelper = null;
        bool _showingModal = false;
        Helper MyHelper = new Helper();

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int HeadId
        { get; set; }

        public int CurId
        { get; set; }

        public int POId
        {
            get { return cmb_PurchaseOrders1.PurchaseOrderId; }
            set { cmb_PurchaseOrders1.PurchaseOrderId = value; }
        }

        public double Total
        {
            get
            {
                try { return Convert.ToDouble(txt_Total.Text); }
                catch { return 0; }
            }
            set { txt_Total.Text = value.ToString(); }
        }

        public double TotalVAT
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalVAT.Text); }
                catch { return 0; }
            }
            set { txt_TotalVAT.Text = value.ToString(); }
        }

        public double TotalWithVat
        {
            get
            {
                try { return Convert.ToDouble(txt_TotalWVAT.Text); }
                catch { return 0; }
            }
            set { txt_TotalWVAT.Text = value.ToString(); }
        }

        public int PlaceId
        {
            get { return cmb_Places1.PlaceId; }
            set { cmb_Places1.PlaceId = value; }
        }

        public int StockMoveTypeId
        {
            get { return cmb_StockInTypes1.StockMovTypeId; }
            set { cmb_StockInTypes1.StockMovTypeId = value; }
        }

        #endregion

        #region Methods


        public void SetCellsColor()
        {
            //Check currency
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_curid"].Value) != CurId)
                    row.Cells["cn_currency"].Style.BackColor = Color.Tomato;
                if (Convert.ToInt32(row.Cells["cn_unitid"].Value) == 0)
                    row.Cells["cn_unit"].Style.BackColor = Color.Tomato;
                row.Cells["cn_custcode"].Style.BackColor = Convert.ToInt32(row.Cells["cn_custcodeid"].Value) == 0 ? Color.Yellow : Color.White;
            }
        }

        public void RecalcTotals()
        {
            gv_List.EndEdit();

            double _total = 0;
            double _vat = 0;
           
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_add"].Value) != 0)
                {
                    _total = _total + Math.Round(Convert.ToDouble(row.Cells["cn_unitprice"].Value) * Convert.ToDouble(row.Cells["cn_qty"].Value), 2);
                    if (_vat == 0)
                        _vat = Convert.ToDouble(row.Cells["cn_vat"].Value);
                }
            }

            Total = Math.Round(_total, 2);
            TotalVAT = Math.Round((_total / 100 * _vat), 2);
            TotalWithVat = Total + TotalVAT;
        }

        public void FillCustCodes()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                DataGridViewComboBoxCell setDGVCMBCell = row.Cells["cn_custcodecmb"] as DataGridViewComboBoxCell;

               
                setDGVCMBCell.DataSource = DAL_Functions.getCustomCodes();
                
                setDGVCMBCell.ValueMember = "cid";
                setDGVCMBCell.DisplayMember = "code";
                setDGVCMBCell.ReadOnly = false;
                
                setDGVCMBCell.Value = Convert.ToInt32(row.Cells["cn_custcodeid"].Value);
                
            }
        }

        public void FillCountries()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                DataGridViewComboBoxCell setDGVCMBCell = row.Cells["cn_country"] as DataGridViewComboBoxCell;


                setDGVCMBCell.DataSource = DAL_Functions.getCountries();

                setDGVCMBCell.ValueMember = "cid";
                setDGVCMBCell.DisplayMember = "country";
                setDGVCMBCell.ReadOnly = false;

                setDGVCMBCell.Value = 0;//Convert.ToInt32(row.Cells["cn_custcodeid"].Value);

            }
        }

        public void FillnewCustCodes(string custcode, int custcodeid)
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (row.Cells["cn_custcode"].Value.ToString() == custcode)
                    row.Cells["cn_custcodeid"].Value = custcodeid;
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

        public void FillList(int POId)
        {
            var data = StockIn_BLL.getStockInFromPO(POId);

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();

                FillCountries();
                //FillCustCodes();
                try
                {
                    RecalcTotals();
                }
                catch { }
                
                Helper.RestoreDirection(gv_List, oldColumn, dir);
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });
        }

        public bool CheckPlace()
        {
            bool _placeid = true;
            int _place = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_place"].Value) != 0)
                {
                    _place = -1;
                }
            }

            if (_place == -1
                && PlaceId == 0)
            _placeid = false;

            return _placeid;
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
            //MessageBox.Show(ColumnName);
            try
            {
                bs_List.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }

            SetCellsColor();
            RecalcTotals();
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
            RecalcTotals();

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
            RecalcTotals();
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
            SetCellsColor();
            RecalcTotals();

        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for confirmation orders list";
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
        
        private void frm_AddStockInFromPO_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_qty"].Value = row.Cells["cn_oldqty"].Value;
                row.Cells["cn_unitprice"].Value = row.Cells["cn_oldunitprice"].Value;
                row.Cells["chk_add"].Value = 0;
                RecalcTotals();
            }
        }

        private void cmb_PurchaseOrders1_PurchaseOrderChanged(object sender)
        {
            FillList(cmb_PurchaseOrders1.PurchaseOrderId);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            bool _test = true;
            bool _testresale = false;
            int _NewInwardId = 0;
            int _custcodeid = 0;
            string emailaddresses = "";
            emailaddresses = DAL.EmailAddressesByType(3);
            string strMessage = "";

            if (CheckPlace() == false)
            {
                DialogResult result = KryptonTaskDialog.Show("Placement warning!",
                                                                "Are you want to save changes?",
                                                                "You selected to make placement but place is not selected!",
                                                                MessageBoxIcon.Warning,
                                                                TaskDialogButtons.Yes |
                                                                TaskDialogButtons.No);
                _test = result == DialogResult.Yes;

            }


            if (_test == true
                && StockMoveTypeId != 0)
            {
                gv_List.EndEdit();

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (Convert.ToInt32(row.Cells["chk_add"].Value) != 0
                        && Convert.ToInt32(row.Cells["cn_unitid"].Value) != 0)
                    {
                        if (Convert.ToInt32(row.Cells["cn_custcodeid"].Value) == 0
                            && row.Cells["cn_custcode"].Value.ToString() != "")
                        {
                            _custcodeid = Bll.AddCustCode(row.Cells["cn_custcode"].Value.ToString(), "");

                            FillnewCustCodes(row.Cells["cn_custcode"].Value.ToString(), _custcodeid);
                        }
                        DataGridViewComboBoxCell setDGVCMBCell = row.Cells["cn_country"] as DataGridViewComboBoxCell;



                        _NewInwardId = SIBll.AddStockIn(HeadId,
                                                            Convert.ToInt32(row.Cells["cn_artid"].Value),
                                                            row.Cells["cn_suparticle"].Value.ToString(),
                                                            StockMoveTypeId,
                                                            Convert.ToDouble(row.Cells["cn_qty"].Value),
                                                            Convert.ToInt32(row.Cells["cn_unitid"].Value),
                                                            row.Cells["cn_comments"].Value.ToString(),
                                                            Convert.ToDouble(row.Cells["cn_unitprice"].Value),
                                                            0,
                                                            Convert.ToDouble(row.Cells["cn_vat"].Value),
                                                            Convert.ToDouble(row.Cells["cn_coefconv"].Value),
                                                            Convert.ToDouble(row.Cells["cn_weight"].Value),
                                                            Convert.ToInt32(row.Cells["cn_custcodeid"].Value),
                                                            //Convert.ToInt32(setDGVCMBCell.Value),
                                                            0,
                                                            -1,
                                                            Convert.ToInt32(row.Cells["cn_id"].Value),
                                                            Convert.ToInt32(setDGVCMBCell.Value),
                                                            "");
                        if (Convert.ToInt32(row.Cells["chk_place"].Value) != 0
                                             && PlaceId != 0
                                             && _NewInwardId != 0)
                        {
                            SIBll.AddStockDeallocation(_NewInwardId, 0, Convert.ToInt32(row.Cells["cn_artid"].Value),
                                                           PlaceId, Convert.ToDouble(row.Cells["cn_qty"].Value),
                                                           "", 0, -1, row.Cells["cn_comments"].Value.ToString(), "", "");
                        }


                        if (Convert.ToInt32(row.Cells["cn_resale"].Value) == -1)
                        {
                            _testresale = true;
                            strMessage = strMessage + "\r\nPurchase order: " + cmb_PurchaseOrders1.PurchaseOrder + ", line: " + row.Cells["cn_line"].Value.ToString();
                            strMessage = strMessage + "\r\nSupplier: " + cmb_PurchaseOrders1.Supplier; 
                            strMessage = strMessage + "\r\nSuppliers article: " + row.Cells["cn_suparticle"].Value.ToString();
                            strMessage = strMessage + "\r\nArticle: " + row.Cells["cn_article"].Value.ToString();
                            strMessage = strMessage + "\r\nQty: " + Convert.ToDouble(row.Cells["cn_qty"].Value).ToString() + " " + row.Cells["cn_iunit"].Value.ToString();
                        }
                    }
                }

                if (_testresale == true
                    && emailaddresses != "")
                MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Purchase order for resale NR : " + cmb_PurchaseOrders1.PurchaseOrder + " reception!", strMessage);

                FillList(0);
                FillList(cmb_PurchaseOrders1.PurchaseOrderId);
                _testresale = false;

                if (StockLineSaved != null)
                    StockLineSaved(this);
            }
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["chk_add"].Selected == true)
            {
                gv_List.EndEdit();

                RecalcTotals();
            }
        }


        #endregion

        private void gv_List_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["cn_qty"].Selected == true
                || gv_List.CurrentRow.Cells["cn_unitprice"].Selected == true)
                btn_OK.Enabled = false;
        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            gv_List.EndEdit();

            if (gv_List.CurrentRow.Cells["cn_custcode"].Selected == true)
            {
                string _custcode = gv_List.CurrentRow.Cells["cn_custcode"].Value.ToString();

                DataSet ds = new DataSet();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT DISTINCT TOP 1 id FROM BAS_CustCodes WHERE code = '" + _custcode.ToString() + "'", sConnStr);

                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];

                try
                {
                    gv_List.CurrentRow.Cells["cn_custcodeid"].Value = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                }
                catch
                {

                    gv_List.CurrentRow.Cells["cn_custcodeid"].Value = 0;
                
                }


                SetCellsColor();
            }


            RecalcTotals();

            btn_OK.Enabled = true;
        }

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;

            ////if (e.Value == "+")
            ////I supposed your button column is at index 0
            //if (e.ColumnIndex == 19)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
            //    var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
            //    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            //    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            //    e.Graphics.DrawImage(Global_Resourses.bindingNavigatorAddNewItem_Image, new Rectangle(x, y, w, h));
            //    e.Handled = true;
            //}
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
