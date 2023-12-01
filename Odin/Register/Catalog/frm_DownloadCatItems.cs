using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Register.Catalog
{
    public delegate void DownloadCatalogEventHandler(object sender);
    public delegate void CloseCatalogEventHandler(object sender);
    public partial class frm_DownloadCatItems : KryptonForm
    {
        public frm_DownloadCatItems()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ResultOfDownloading.xls", this.Name);
        }

        class_Global glob_Class = new class_Global();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        Reg_BLL RegBll = new Reg_BLL();
        ExportData ED;
        AdmMenu mMenu = new AdmMenu();

        DAL_Functions DAL = new DAL_Functions();
       
        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public event DownloadCatalogEventHandler CatalogDownloaded;
        public event CloseCatalogEventHandler CatalogClosed;

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

        private void btn_Download_Click(object sender, EventArgs e)
        {
            string _Article = "";
            string _SupArticle = "";
            double _UnitPrice = 0;
            string _Unit = "";
            string _Currency = "";
            int _VAT = 0;
            double _MPQ = 0;
            double _MOQ = 0;
            string _DataCode = "";
            string _DelivTerm = "";
            string _Manufacturer = "";
            string _Comments = "";
            string _Supplier = "";

            DataTable data = new DataTable();
            data.Columns.Add("article", typeof(string));
            data.Columns.Add("suparticle", typeof(string));
            data.Columns.Add("unitprice", typeof(double));
            data.Columns.Add("unit", typeof(string));
            data.Columns.Add("currency", typeof(string));
            data.Columns.Add("vat", typeof(int));
            data.Columns.Add("moq", typeof(double));
            data.Columns.Add("mpq", typeof(double));
            data.Columns.Add("datacode", typeof(string));
            data.Columns.Add("delivterm", typeof(string));
            data.Columns.Add("manufacturer", typeof(string));
            data.Columns.Add("comments", typeof(string));
            data.Columns.Add("supplier", typeof(string));


            pb_Progress.Value = 0;
            int k = 1;
            //Stream mystream = null;
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.InitialDirectory = "C:\\";
            openfiledialog1.Filter = "Excel Files (*.xls)|*.xls|All files (*.*)|*.*";
            openfiledialog1.FilterIndex = 2;
            openfiledialog1.RestoreDirectory = true;

            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                SqlConnection sqlConn = new SqlConnection(sConnStr);

                string Path = openfiledialog1.FileName;

                Excel myExcel = new Excel();
                myExcel.OpenDocument(Path);

                while (glob_Class.NES(myExcel.GetValue("A" + k.ToString())).Trim() != "")
                {
                    k++;
                }
                pb_Progress.ThreadSafeCall(delegate
                {
                    pb_Progress.Value = 0;
                    pb_Progress.Maximum = k;
                });


                if (k != 1)
                {
                    k = 2;
                    pb_Progress.ThreadSafeCall(delegate { pb_Progress.Value = pb_Progress.Value + 1; });
                    while (glob_Class.NES(myExcel.GetValue("A" + k.ToString())).Trim() != "")
                    {
                        try
                        {
                            _Article = glob_Class.NES(myExcel.GetValue("A" + k.ToString()).Trim());
                            _SupArticle = glob_Class.NES(myExcel.GetValue("B" + k.ToString()).Trim());
                            _UnitPrice = glob_Class.NES(myExcel.GetValue("D" + k.ToString()).Trim().ToUpper()) == "Q" ? 0 : glob_Class.NEN_Double(glob_Class.ReplaceChar(myExcel.GetValue("D" + k.ToString()), ",", "."));
                            _Unit = glob_Class.NES(myExcel.GetValue("E" + k.ToString()));
                            _Currency = glob_Class.NES(myExcel.GetValue("F" + k.ToString()).Trim());
                            _VAT = glob_Class.NEN_Int(myExcel.GetValue("G" + k.ToString()));
                            _MOQ = glob_Class.NEN_Double(glob_Class.ReplaceChar(myExcel.GetValue("H" + k.ToString()), ",", "."));
                            _MPQ = glob_Class.NEN_Double(glob_Class.ReplaceChar(myExcel.GetValue("I" + k.ToString()), ",", "."));
                            _DataCode = glob_Class.NES(myExcel.GetValue("J" + k.ToString()).Trim());
                            _DelivTerm = glob_Class.NES(myExcel.GetValue("K" + k.ToString()).Trim());
                            _Manufacturer = glob_Class.NES(myExcel.GetValue("L" + k.ToString()));
                            _Comments = glob_Class.NES(myExcel.GetValue("M" + k.ToString()).Trim());
                            _Supplier = glob_Class.NES(myExcel.GetValue("N" + k.ToString()).Trim());

                            //if (Math.Round(_UnitPrice, 5) > 0
                            //    || glob_Class.NES(myExcel.GetValue("D" + k.ToString()).Trim().ToUpper()) == "Q")
                            {
                                DataRow drser = data.NewRow();
                                drser["article"] = _Article;
                                drser["suparticle"] = _SupArticle;
                                drser["unitprice"] = _UnitPrice;
                                drser["unit"] = _Unit;
                                drser["currency"] = _Currency;
                                drser["vat"] = _VAT;
                                drser["moq"] = _MOQ;
                                drser["mpq"] = _MPQ;
                                drser["datacode"] = _DataCode;
                                drser["delivterm"] = _DelivTerm;
                                drser["manufacturer"] = _Manufacturer;
                                drser["comments"] = _Comments;
                                drser["supplier"] = _Supplier;
                                
                                data.Rows.Add(drser);
                            }
                        }
                        catch {
                            //MessageBox.Show("Problems with downloading file, row number: " + k.ToString());
                        }
                        //MessageBox.Show(_CustReqDate);
                        //Importation
                        //SqlCommand sqlComm = new SqlCommand("sp_ImportClientOrder", sqlConn);
                        //sqlComm.CommandType = CommandType.StoredProcedure;

                        //sqlComm.Parameters.AddWithValue("@Article", _Article);
                        //sqlComm.Parameters.AddWithValue("@PO", _PO);
                        //sqlComm.Parameters.AddWithValue("@POLine", _POLine);
                        //sqlComm.Parameters.AddWithValue("@CO", _CO);
                        //sqlComm.Parameters.AddWithValue("@COLine", _COLine);
                        //sqlComm.Parameters.AddWithValue("@ReqDate", _ReqDate);
                        //sqlComm.Parameters.AddWithValue("@CustReqDate", _CustReqDate);
                        //sqlComm.Parameters.AddWithValue("@Unit", _Unit);
                        //sqlComm.Parameters.AddWithValue("@Qty", _Qty);
                        //sqlComm.Parameters.AddWithValue("@CustRef", _CustRef);
                        //sqlComm.Parameters.AddWithValue("@Customer", _Customer);
                        //sqlComm.Parameters.AddWithValue("@Comments1", _Comments1);
                        //sqlComm.Parameters.AddWithValue("@Comments2", _Comments2);
                        //sqlComm.Parameters.AddWithValue("@Comments3", _Comments3);
                        //sqlComm.Parameters.AddWithValue("@CustOrder", _CustOrder);
                        //sqlComm.Parameters.AddWithValue("@EndCust", _EndCustomer);
                        //sqlComm.Parameters.AddWithValue("@DelivPlace", _PlaceToSend);
                        //sqlComm.Parameters.AddWithValue("@Release", _Release);
                        //sqlComm.Parameters.AddWithValue("@ConfType", _ConfType);
                        //sqlComm.Parameters.AddWithValue("@ROHS", _ROHS);
                        //sqlComm.Parameters.AddWithValue("@ContPers", _ContPers);
                        //sqlComm.Parameters.AddWithValue("@FamilyCode", _FamilyCode);
                        //sqlComm.Parameters.AddWithValue("@LogComments", _LogiComments);
                        //sqlComm.Parameters.AddWithValue("@MarketCode", _MarketCode);
                        //sqlComm.Parameters.AddWithValue("@CoC", _CoC);

                        //sqlConn.Open();
                        //sqlComm.ExecuteNonQuery();
                        //sqlConn.Close();

                        pb_Progress.ThreadSafeCall(delegate { pb_Progress.Value = pb_Progress.Value + 1; });
                        k++;
                    }
                    var data1 = RegBll.DownloadCatalog(data, cmb_Firms1.FirmId);

                    gv_List.ThreadSafeCall(delegate
                    {
                        gv_List.AutoGenerateColumns = false;
                        bs_List.DataSource = data1;
                        gv_List.DataSource = bs_List;
                    });


                    bn_List.ThreadSafeCall(delegate
                    {
                        bn_List.BindingSource = bs_List;
                    });
                }
                myExcel.CloseDocument();
                myExcel.Close();
                myExcel.Dispose();
                glob_Class.ShowMessage("Result for downloading", "", "Done!");

                if (CatalogDownloaded != null)
                    CatalogDownloaded(this);

            }

        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
                ED.DgvIntoExcel();
        }

        private void frm_DownloadCatItems_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
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

            frm.HeaderText = "Select view for needs list";
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

        #endregion
    }
}
