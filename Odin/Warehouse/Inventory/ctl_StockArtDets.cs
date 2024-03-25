using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Warehouse.Movements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Odin.Warehouse.Inventory
{
    public delegate void LabelSendingEventHandler(object sender);

    public partial class ctl_StockArtDets : UserControl
    {
        public ctl_StockArtDets()
        {
            InitializeComponent();
            frm_Inventory.ReceiveLabel += new ReceiveMyLabel(RetLabel);
        }

        public event LabelSendingEventHandler SendLabel;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        StockMove_BLL MovBLL = new StockMove_BLL();
        PrinterLabels PrintLabels = new PrinterLabels();
        DAL_Functions Fun = new DAL_Functions();

        #region Variables

        public int Label
        {
            get;set;
        }

        public int _PrevId = 0;

        public int RetLabel()
        {
            return Label;
        }

        public double QtyStock
        {
            get {
                try { return Convert.ToDouble(txt_QtyStock.Text); }
                catch { return 0; }
            }
            set { txt_QtyStock.Text = value.ToString(); }
        }

        public double WeightedAverage
        {
            get
            {
                try { return Convert.ToDouble(txt_WACost.Text); }
                catch { return 0; }
            }
            set { txt_WACost.Text = value.ToString(); }
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

        public double Available
        {
            get
            {
                try { return Convert.ToDouble(txt_Available.Text); }
                catch { return 0; }
            }
            set { txt_Available.Text = value.ToString(); }
        }

        public double Reserved
        {
            get
            {
                try { return Convert.ToDouble(txt_Reserved.Text); }
                catch { return 0; }
            }
            set { txt_Reserved.Text = value.ToString(); }
        }

        public double NotPlaced
        {
            get
            {
                try { return Convert.ToDouble(txt_NotPlaced.Text); }
                catch { return 0; }
            }
            set { txt_NotPlaced.Text = value.ToString(); }
        }

        public double Quarantine
        {
            get
            {
                try { return Convert.ToDouble(txt_Quarantine.Text); }
                catch { return 0; }
            }
            set { txt_Quarantine.Text = value.ToString(); }
        }
        
        public string Unit
        {
            get { return txt_Unit.Text; }
            set { txt_Unit.Text = value; }
        }


        #endregion 

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_usage"].Value) == 0)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Style.BackColor = Color.Silver;
                }
            }
        }

        int _ArticleId = 0;

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set {
                cmb_Articles1.ArticleId = value;
                _ArticleId = value;
                FillLabels(_ArticleId);
                FillTotals(_ArticleId);
            }
        }

        public void FillLabels(int artid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectStockRests", artid);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            SetCellsColor();
        }

        public void FillTotals(int _artid)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "execute sp_SelectStockTotals @artid = " + _artid, conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    QtyStock = Convert.ToDouble(dr["qtyrest"]);
                    WeightedAverage = Convert.ToDouble(dr["weightedaverage"]);
                    Total = Convert.ToDouble(dr["total"]);
                    Reserved = Convert.ToDouble(dr["reserved"]);
                    Available = Convert.ToDouble(dr["available"]) + Convert.ToDouble(dr["notplaced"]);
                    NotPlaced = Convert.ToDouble(dr["notplaced"]);
                    Quarantine = Convert.ToDouble(dr["quarantine"]);

                }
            }
            else
            {
                ClearFields();
            }

        }

        public void ClearFields()
        {
            QtyStock = 0;
            WeightedAverage = 0;
            Total = 0;
            Reserved = 0;
            Available = 0;
            NotPlaced = 0;
            Quarantine = 0;
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            _ArticleId = cmb_Articles1.ArticleId;
            FillLabels(_ArticleId);
            FillTotals(_ArticleId);
            Unit = cmb_Articles1.Unit;
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckOldRow() == false)
            {
                SendLabel?.Invoke(this);
            }
        }

        private bool CheckOldRow()
        {

            try
            {
                Label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value);
            }
            catch
            {
                Label = 0;
            }
                       
            if (_PrevId == Label)
            {
                return true;
            }
            else
            {
                _PrevId = Label;
                return false;
            }
        }

        public void TestValidating()
        {
            string _doc = "";
            int _usage = 0;
            string _datacode = "";
            int _inid = 0;

            if (gv_List.CurrentRow.Cells["chk_merge"].Selected == true)
            {
                gv_List.EndEdit();

                if (Convert.ToInt32(gv_List.CurrentRow.Cells["chk_merge"].Value) == -1)
                {
                    //try
                    //{

                    _doc = gv_List.CurrentRow.Cells["cn_document"].Value.ToString();
                    _datacode = gv_List.CurrentRow.Cells["cn_datacode"].Value.ToString();
                    _usage = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_usage"].Value);
                    _inid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_inid"].Value);

                    //}
                    // catch { }

                    foreach (DataGridViewRow row in gv_List.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["chk_merge"].Value) != 0
                            && (row.Cells["cn_document"].Value.ToString() != _doc
                                || row.Cells["cn_datacode"].Value.ToString() != _datacode
                                || Convert.ToInt32(row.Cells["cn_usage"].Value) != _usage
                                //|| Convert.ToInt32(row.Cells["cn_inid"].Value) != _inid
                                )

                           /* && Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value) != _label*/)
                        {

                            gv_List.CurrentRow.Cells["chk_merge"].Value = 0;

                        }
                    }
                }
            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void ctl_StockArtDets_Paint(object sender, PaintEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            int _label = 0;

            gv_List.EndEdit();

            TestValidating();

            bool _test = false;
            
            DataTable datalabels = new DataTable();
            datalabels.Columns.Add("label", typeof(int));

            foreach (DataGridViewRow row in gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_merge"].Value) != 0)
                {
                    DataRow dr = datalabels.NewRow();
                    dr["label"] = Convert.ToInt32(row.Cells["cn_label"].Value);
                    datalabels.Rows.Add(dr);
                    _test = true;
                }

            }

            try { _label = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_label"].Value); }
            catch { }

            if (_test == true
                && _label != 0
                && Convert.ToInt32(gv_List.CurrentRow.Cells["chk_merge"].Value) == -1)
            {
                DialogResult result = KryptonTaskDialog.Show("Merging warning!",
                                                                 "Target label: " + _label.ToString(),
                                                                 "Are you sure you want merge selected labels on label: " + _label.ToString() + "?",
                                                                 MessageBoxIcon.Warning,
                                                                 TaskDialogButtons.Yes |
                                                                 TaskDialogButtons.No);
                if (result == DialogResult.Yes)
                {
                    int _res = Convert.ToInt32(Helper.getSP("sp_MergeStockLabels", _label, datalabels));

                    if (_res == 0)
                        KryptonTaskDialog.Show("Mistake during merging!",
                                          "Merging was not appears! Please check data!",
                                           "",
                                           MessageBoxIcon.Warning,
                                           TaskDialogButtons.OK);
                    FillLabels(_ArticleId);
                    FillTotals(_ArticleId);
                }

            }

        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TestValidating();
        }

        private void gv_List_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TestValidating();
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            int _label = 0;
            double _qty = 0;
            frm_Print frm = new frm_Print();
            frm.cmb_LabPrinter1.ShowDefaults();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintLabels.PrinterIp = frm.IP_Address;
                PrintLabels.PrinterDPI = frm.Printer_DPI;

                foreach (DataGridViewRow row in this.gv_List.SelectedRows)
                {
                    try { _label = Convert.ToInt32(row.Cells["cn_label"].Value);
                        _qty = Convert.ToDouble(row.Cells["cn_qtyrest"].Value);
                    }
                    catch { _label = 0;
                        _qty = 0;
                    }
                    var sqlparamsfields = new List<SqlParameter>()
                    {
                    new SqlParameter("@id",SqlDbType.Int) {Value = _label},
                    new SqlParameter("@qty",SqlDbType.Float) {Value = _qty},
                    new SqlParameter("@labelqty",SqlDbType.Int) {Value = frm.LabelQty}
                    };

                    if (Fun.CheckMSL(cmb_Articles1.ArticleId) != "0"
                        && frm.LabelQty != 0)
                        PrintLabels.PrintLabel(PrintLabels.LabelConstructor(rb_Simple.Checked == true ? 1 : 3, "sp_SelectStockLabelDetsPrint", sqlparamsfields.ToArray()), 1/*frm.LabelQty*/);
                    else
                        MessageBox.Show("MSL = 0! Printing impossible!");
                }
            }
            else
            { }
        }
    }
}
