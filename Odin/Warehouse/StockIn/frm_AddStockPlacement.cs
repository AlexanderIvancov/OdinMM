using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Register;
using Odin.Register.Articles;
using Odin.Tools;
using Odin.Warehouse.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Odin.Warehouse.StockIn
{
    public partial class frm_AddStockPlacement : KryptonForm
    {

        ProgressForm wait;
                
        public void bwStart(DoWorkEventHandler doWork)
        {
            wait.bwStart(doWork);
        }

        public frm_AddStockPlacement()
        {
            InitializeComponent();
            wait = new ProgressForm(this);
            ED = new ExportData(this.gv_List, "StockNotPlaced.xls", this.Name);
        }

        #region Variables

        public int IdIn
        { get; set; }
        int _PrevId = 0;


        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        StockIn_BLL SIBll = new StockIn_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
        PrinterLabels PrintLabels = new PrinterLabels();
        StockInventory SInvBll = new StockInventory();
        Reg_BLL Reg = new Reg_BLL();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";


        public string ArticleDetsHeader
        {
            get { return HeadArt.ValuesSecondary.Heading; }
            set { HeadArt.ValuesSecondary.Heading = value; }
        }

        public string ExpDate
        {
            get
            {
                if (txt_ExpDate.Value == null)
                    return "";
                else
                    return Convert.ToDateTime(txt_ExpDate.Value).ToShortDateString();
            }
            set
            {
                try
                {
                    txt_ExpDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_ExpDate.Value = null; }
            }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }
        }
        
        public int PlaceId
        {
            get { return cmb_Places1.PlaceId; }
            set { cmb_Places1.PlaceId = value; }
        }
        public double Qty
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }

        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }

        public string DataCode
        {
            get { return txt_DataCode.Text; }
            set { txt_DataCode.Text = value; }
        }

        public int Label
        {
            get { try { return Convert.ToInt32(cmb_Label.Text); }
                catch { return 0; }
            }
            set { cmb_Label.Text = value.ToString(); }
        }

        public int NoExpDate
        {
            get
            {
                if (chk_NoDate.Checked == true)
                    return -1;
                else
                    return 0;
            }
            set
            {
                if (value == -1)
                    chk_NoDate.Checked = true;

                else
                    chk_NoDate.Checked = false;

            }
        }
        public string ManufBatch
        {
            get { return txt_ManufBatch.Text; }
            set { txt_ManufBatch.Text = value; }
        }
        #endregion

        #region Methods

        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(txt_CreatDateFrom.Value.ToShortDateString());
            var data = StockIn_BLL.getStockNotPlaced(cmb_Articles1.ArticleId, cmb_IncomeDoc1.IncomeDocId);

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            gv_List.ThreadSafeCall(delegate
            {
                gv_Placing.Rows.Clear();
            });
        }

        public void FillLabels(int artid)
        {
            var data = StockInventory.getStockRests(artid);

            gv_StockDets.ThreadSafeCall(delegate
            {
                gv_StockDets.AutoGenerateColumns = false;
                bs_StockDets.DataSource = data;
                gv_StockDets.DataSource = bs_StockDets;

            });
            
            SetCellsColorLabels();
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Math.Round(Convert.ToDouble(row.Cells["cn_qty"].Value), 5) <= 0)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Silver;
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
                if (Convert.ToInt32(row.Cells["cn_incomecontrol"].Value) != 0
                    && cmb_Places1.IsQuarantine != -1)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                }
                if (Convert.ToInt32(row.Cells["cn_resale"].Value) != 0)
                {
                    row.Cells["cn_incomedoc"].Style.BackColor = Color.Yellow;
                }
            }
        }

        public void SetCellsColorLabels()
        {
            foreach (DataGridViewRow row in this.gv_StockDets.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_usage"].Value) == 0)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
                }
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

        private bool CheckOldRow()
        {

            try
            {
                IdIn = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch
            {
                IdIn = 0;
            }

            if (_PrevId == IdIn)
            {
                return true;
            }
            else
            {
                _PrevId = IdIn;
                return false;
            }
        }

        public void ShowDetails()
        {

            int _artid = 0;
            string _article = "";
            string _incomedoc = "";
            try
            {
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
                _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
                _incomedoc = gv_List.CurrentRow.Cells["cn_incomedoc"].Value.ToString();
                Qty = Math.Round(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value), 5);
                txt_Unit.Text = gv_List.CurrentRow.Cells["cn_unit"].Value.ToString();
                DataCode = "";
            }
            catch
            { }

            BindLabels(_artid);
            ShowImage(_artid);
           

            DataGridViewColumn oldColumn = gv_StockDets.SortedColumn;
            var dir = Helper.SaveDirection(gv_StockDets);

            FillLabels(_artid);

            Helper.RestoreDirection(gv_StockDets, oldColumn, dir);


            ArticleDetsHeader = "Make placement for " + _article + ", income document: " + _incomedoc;
            
            //Show image
        }

        public void RecalcLeftQty(int idin)
        {
            double _tempqty = 0;
            foreach (DataGridViewRow row in gv_Placing.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_inid"].Value) == idin)
                    _tempqty = Math.Round(_tempqty + Convert.ToDouble(row.Cells["cn_iqty"].Value), 5);
            }

            foreach (DataGridViewRow row1 in gv_List.Rows)
            {
                if (Convert.ToInt32(row1.Cells["cn_id"].Value) == idin)
                {
                    row1.Cells["cn_qty"].Value = Convert.ToDouble(row1.Cells["cn_qtyold"].Value) - _tempqty;

                    break;
                }
            }
        }

        //public void ShowImage(int _artid)
        //{
        //    string _path = DAL.ImagePath(_artid);

        //    try
        //    {
        //        pic_Image.ImageLocation = _path;
        //        pic_Image.Load();
        //    }
        //    catch
        //    {
        //        pic_Image.Image = null;
        //    }
        //}
        private Bitmap GetImageFromPath(string Path)
        {
            StreamReader streamReader = new StreamReader(Path);
            Bitmap originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();
            return originalBitmap;
        }

        public void ShowImage(int _artid)
        {
            string _path = DAL.ImagePath(_artid);

            try
            {
                pic_Image.Image = GetImageFromPath(_path);
                //pic_Image.ImageLocation = _path;
                //pic_Image.Load();
            }
            catch
            {
                pic_Image.Image = null;
            }
        }
        public bool CheckAddIn()
        {
            if (Qty <= 0
                || (PlaceId == 0 && Label == 0)
                || DAL.CheckProduction(cmb_Places1.PlaceId) == true
                || IdIn == 0
                || (DAL.CheckMBLimit(Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value)) == true && ManufBatch.Trim() == "")
                || (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_incomecontrol"].Value) == -1) && cmb_Places1.IsQuarantine != -1)
                return false;
            else
                return true;

        }

        public void BindLabels(int _artid)
        {
            cmb_Label.Text = "";
            
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "SELECT DISTINCT id FROM sto_rests WHERE artid = " + _artid + " union (select 0) ", sConnStr);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            cmb_Label.DataSource = dt;
            cmb_Label.DisplayMember = "id";
            cmb_Label.ValueMember = "id";

            cmb_Label.SelectedValue = 0;
        }

        public void ShowEdit()
        {
            int igvArtId = 0;

            try { igvArtId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value); }
            catch { }

            if (igvArtId != 0)
            {

                frm_AddArticle frm = new frm_AddArticle();
                frm.CheckEmpty();

                Reg.ArtId = igvArtId;

                frm.Id = Reg.ArtId;
                frm.Article = Reg.Article;
                frm.SecName = Reg.SecName;
                frm.Description = Reg.Description;
                frm.TypeId = Reg.TypeId;
                frm.UnitId = Reg.UnitId;
                frm.ImagePath = Reg.ImagePath;
                frm.Comments = Reg.Comments;
                frm.CustCodeId = Reg.CustCodeId;
                frm.QtyReserve = Reg.QtyReserve;
                frm.DeptId = Reg.DeptId;
                frm.CreateSubBatch = Reg.CreateSubBatch;
                frm.Weight = Reg.Weight;
                frm.IsActive = Reg.IsActive;
                frm.Revision = Reg.Revision;
                frm.StoreRules = Reg.StorageRules;
                frm.SpoilNorm = Reg.SpoilNorm;
                frm.ShowImage(frm.ImagePath);
                frm.StageId = Reg.StageId;
                frm.MSL = Reg.MSL;
                frm.Service = Reg.Service;
                //frm.LabelsQty = Reg.LabelsQty;
                //frm.StencilRequired = Reg.StencilRequired;
                //frm.StencilID = Reg.StencilID;
                frm.Warning = Reg.Warning;
                frm.SpoilConst = Reg.SpoilConst;
                frm.AsPF = Reg.AsPF;
                frm.MBLimit = Reg.MBLimit;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //MessageBox.Show(frm.MSL);
                    //Edit
                    int _res = Reg.SaveArticle(frm.Id, Regex.Replace(frm.Article, @"\p{C}+", string.Empty), frm.SecName, frm.Description, frm.TypeId, frm.UnitId, frm.ImagePath, frm.Comments,
                                        frm.CustCodeId, frm.QtyReserve, frm.DeptId, frm.CreateSubBatch, frm.Weight, frm.IsActive,
                                        frm.Revision, frm.StoreRules, frm.SpoilNorm, frm.StageId, frm.MSL, frm.Service, /*frm.LabelsQty, 
                                        frm.StencilRequired, frm.StencilID*/0, 0, 0, frm.Warning, frm.SpoilConst, frm.AsPF, frm.MBLimit);
                    //if (_res != 0)
                    //{
                        
                        DataGridViewColumn oldColumn = gv_List.SortedColumn;
                        var dir = Helper.SaveDirection(gv_List);

                        bwStart(bw_List);

                        Helper.RestoreDirection(gv_List, oldColumn, dir);

                        SetCellsColor();
                        
                    //}
                }
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
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_List.Filter = bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_List.Filter = bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            SetCellsColor();
            

        }

        private void mni_FilterExcludingSel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_List.Filter) == true)
                    bs_List.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
                else
                    bs_List.Filter = bs_List.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //DataGridViewColumn oldColumn = gv_List.SortedColumn;
            //var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            //Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        #endregion

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void frm_AddStockPlacement_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            txt_ExpDate.Value = null;
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                ShowDetails();
            }
        }



        private void btn_AddPlaces_Click(object sender, EventArgs e)
        {
            if (CheckAddIn() == true)
            {
                if (chk_Multiplication.CheckState == CheckState.Checked)
                {
                    double _tempqty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
                    double _qtyadd = 0;
                    while (_tempqty > 0)
                    {
                        if (_tempqty > Qty)
                        {
                            _qtyadd = Math.Round(Qty, 5);
                            _tempqty = _tempqty - Math.Round(Qty, 5);
                        }
                        else
                        {
                            _qtyadd = Math.Round(_tempqty, 5);
                            _tempqty = 0;
                        }
                        gv_Placing.Rows.Add(
                                      Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value),
                                    //IdIn,
                                      gv_List.CurrentRow.Cells["cn_artid"].Value,
                                      gv_List.CurrentRow.Cells["cn_article"].Value,
                                      0,//Label,
                                      _qtyadd,
                                      txt_Unit.Text,
                                      cmb_Places1.PlaceId,
                                      cmb_Places1.txt_Place.Text,
                                      Comments,
                                      DataCode,
                                      ExpDate,
                                      ManufBatch);
                    }

                }
                else
                {
                    gv_Placing.Rows.Add(IdIn,
                                        gv_List.CurrentRow.Cells["cn_artid"].Value,
                                        gv_List.CurrentRow.Cells["cn_article"].Value,
                                        Label,
                                        Qty,
                                        txt_Unit.Text,
                                        cmb_Places1.PlaceId,
                                        cmb_Places1.txt_Place.Text,
                                        Comments,
                                        DataCode,
                                        ExpDate,
                                        ManufBatch);

                }
                RecalcLeftQty(IdIn);
                Qty = Math.Round(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value), 5);

                SetCellsColor();
            }
            else
            {
                MessageBox.Show("Some cells are empty or quarantine check-in is false or manufacturing batch is emmpty!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _inid = 0;

            foreach (DataGridViewRow row in gv_Placing.SelectedRows)
            {
                _inid = Convert.ToInt32(row.Cells["cn_inid"].Value);

                gv_Placing.Rows.Remove(row);
                RecalcLeftQty(_inid);
            }

            if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value) == _inid)
                    Qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
            SetCellsColor();
            //int _inid = 0;
            //try { _inid = Convert.ToInt32(gv_Placing.CurrentRow.Cells["cn_inid"].Value); }
            //catch { }

            //if (_inid != 0)
            //{
            //    gv_Placing.Rows.Remove(gv_Placing.CurrentRow);

            //    RecalcLeftQty(_inid);

            //    if (Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value) == _inid)
            //        Qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);

            //    SetCellsColor();
            //}
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int _res = 0;
           
            if (chk_PrintLabels.CheckState == CheckState.Checked)
            {
                frm_Print frm = new frm_Print();
                frm.cmb_LabPrinter1.ShowDefaults();
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PrintLabels.PrinterIp = frm.IP_Address;
                    PrintLabels.PrinterDPI = frm.Printer_DPI;

                    foreach (DataGridViewRow row in this.gv_Placing.Rows)
                    {
                        try
                        {
                            _res = SIBll.AddStockDeallocation(Convert.ToInt32(row.Cells["cn_inid"].Value),
                                                        Convert.ToInt32(row.Cells["cn_ilabel"].Value),
                                                        Convert.ToInt32(row.Cells["cn_iartid"].Value),
                                                        Convert.ToInt32(row.Cells["cn_iplaceid"].Value),
                                                        Convert.ToDouble(row.Cells["cn_iqty"].Value),
                                                        row.Cells["cn_expdate"].Value.ToString(),
                                                        0,
                                                        -1,
                                                        row.Cells["cn_comments"].Value.ToString(),
                                                        row.Cells["cn_idatacode"].Value.ToString(),
                                                        row.Cells["cn_manufbatch"].Value.ToString());
                            if (_res != 0
                                && NoExpDate == -1)
                                SIBll.SetNoExpDate(_res);

                            var sqlparamsfields = new List<SqlParameter>()
                            {
                                new SqlParameter("@id",SqlDbType.Int) {Value = _res},
                                new SqlParameter("@qty",SqlDbType.Float) {Value =  Convert.ToDouble(row.Cells["cn_iqty"].Value)},
                                new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                            };

                            if (DAL.CheckMSL(Convert.ToInt32(row.Cells["cn_iartid"].Value)) != "0")
                            {
                                PrintLabels.PrintLabel(PrintLabels.LabelConstructor(1, "sp_SelectStockLabelDetsPrint", sqlparamsfields.ToArray()), /*frm.LabelQty*/1);
                                //Thread.Sleep(1000);
                            }
                        }

                        catch { }
                    }
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                    SetCellsColor();
                }
                
            }
            else
            {

                foreach (DataGridViewRow row in this.gv_Placing.Rows)
                {
                    try
                    {
                        _res = SIBll.AddStockDeallocation(Convert.ToInt32(row.Cells["cn_inid"].Value),
                                                    Convert.ToInt32(row.Cells["cn_ilabel"].Value),
                                                    Convert.ToInt32(row.Cells["cn_iartid"].Value),
                                                    Convert.ToInt32(row.Cells["cn_iplaceid"].Value),
                                                    Convert.ToDouble(row.Cells["cn_iqty"].Value),
                                                    row.Cells["cn_expdate"].Value.ToString(),
                                                    0,
                                                    -1,
                                                    row.Cells["cn_comments"].Value.ToString(),
                                                    row.Cells["cn_idatacode"].Value.ToString(),
                                                    row.Cells["cn_manufbatch"].Value.ToString());
                        if (_res != 0
                                && NoExpDate == -1)
                            SIBll.SetNoExpDate(_res);
                    }

                    catch { }
                }
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);

                bwStart(bw_List);

                Helper.RestoreDirection(gv_List, oldColumn, dir);
            }

            int _artid = 0;
            try {
                _artid = Convert.ToInt32(gv_StockDets.CurrentRow.Cells["cn_iartid"].Value);
                DataGridViewColumn oldColumn1 = gv_StockDets.SortedColumn;
                var dir1 = Helper.SaveDirection(gv_StockDets);

                FillLabels(_artid);

                Helper.RestoreDirection(gv_StockDets, oldColumn1, dir1);
            }
            catch { }
            

        }

        private void cmb_Places1_SelectedValueChanged(object sender)
        {
            SetCellsColor();
        }

        private void gv_StockDets_SelectionChanged(object sender, EventArgs e)
        {
            int _placeid = 0;
            try
            {
                _placeid = Convert.ToInt32(gv_StockDets.CurrentRow.Cells["cn_placeid"].Value);
            }
            catch { }

            cmb_Places1.PlaceId = _placeid; 
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_DataCode.Text = string.Empty;
        }

        private void txt_ExpDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ExpDate.Value = txt_ExpDate.Value == null ? System.DateTime.Now : txt_ExpDate.Value;
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void gv_StockDets_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_ManufBatch.Text = string.Empty;
        }
    }
}
