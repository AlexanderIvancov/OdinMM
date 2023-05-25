using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Ribbon;
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.Warehouse.Deliveries
{
    public delegate void AddDeliveryBoxesEventHandler(DataGridView gridview);

    public partial class frm_DNPicking : KryptonForm
    {
        public frm_DNPicking()
        {
            InitializeComponent();
        }

        #region Variables

        public event AddDeliveryBoxesEventHandler AddBoxes;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DelivNote_BLL DNBll = new DelivNote_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        ExportData ED;
        Helper MyHelper = new Helper();
        public int ReadValue = 0;

        int _scanmode = 0;

        public int ScanMode
        {
            get { return _scanmode; }
            set
            {

                _scanmode = value;
                if (_scanmode == -1)
                {
                    chk_scan.CheckState = CheckState.Checked;
                    chk_scan.BackColor = Color.LightPink;
                 
                }
                else
                {
                    chk_scan.CheckState = CheckState.Unchecked;
                    chk_scan.BackColor = Color.LightGreen;
                   
                }
            }
        }

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
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

        public void FillList()
        {
            var data = DelivNote_BLL.getBatchBoxesForDelivery();

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();

            });

            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_List;
            });
        }

        public void FillListNotMapped(int idin)
        {
            var data = DelivNote_BLL.getBatchBoxesNotMapped(idin);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();

            });

            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_List;
            });
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_coid"].Value) == 0)
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        #endregion

        #region Controls

        private void chk_scan_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_scan.Checked == true)
            {
                ScanMode = -1;
                txt_Oper.Focus();
            }
            else
            {
                ScanMode = 0;
            }
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
           
        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_List.RemoveFilter();
            }
            catch { }
        }

        private void mni_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValue.ToString());
        }

        private void mni_Admin_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for deliveries list";
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


        private void frm_DNPicking_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        #endregion

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (AddBoxes != null)
                AddBoxes(gv_List);
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ScanMode == -1) //Only in this case adding Serial
                {
                    if (txt_Oper.Text.Substring(0, 1) == "B")
                    {
                        //Check for box number
                        bool _check = Int32.TryParse(txt_Oper.Text.Substring(1), out ReadValue);
                        if (_check == true)
                        {
                            foreach (DataGridViewRow row in this.gv_List.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["cn_id"].Value) == ReadValue)
                                {
                                    row.Cells["chk_add"].Value = -1;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    { MessageBox.Show("This is not box number!"); }
                    //Clear temp field
                    txt_Oper.Text = "";
                    txt_Oper.Focus();
                }
            }
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            int _coid = 0;
            string _batch = "";
            int _id = 0;

            try { _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);
                _coid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_coid"].Value);
                _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString();
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (_batchid != 0)
            {
                frm_SelectOrders frm = new frm_SelectOrders();
                frm.BatchId = _batchid;
                frm.FillOrders(_batchid);
                frm.HeaderText = "Confirmation orders for batch: " + _batch;
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK
                    && frm.COId != _coid
                    && frm.COId != 0
                    && _id != 0)
                {
                    foreach (DataGridViewRow row in gv_List.SelectedRows)
                    {
                        if (Convert.ToInt32(row.Cells["cn_batchid"].Value) == _batchid)
                            DNBll.MapCOToBatch(Convert.ToInt32(row.Cells["cn_id"].Value), _batchid, frm.COId);
                    }
                    FillList();
                }

            }
        }

        private void btn_Separate_Click(object sender, EventArgs e)
        {
            int _batchid = 0;
            int _coid = 0;
            string _batch = "";
            int _id = 0;
            double _qty = 0;


            try
            {
                _batchid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_batchid"].Value);
                _coid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_coid"].Value);
                _batch = gv_List.CurrentRow.Cells["cn_batch"].Value.ToString();
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _qty = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qty"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_cmbNumber frm = new frm_cmbNumber();
                frm.LabelText = "Enter qty to separate:";
                frm.HeaderText = "Separation of boxes";

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK
                    && frm.FormNumber > 0)
                {
                    string _res = DNBll.SeparateBox(_id, frm.FormNumber);
                    MessageBox.Show(_res);
                    FillList();
                }
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _package = "";
            int _qtypack = 0;
            double _weightbrut = 0;
            string _comments = "";
            int _boxno = 0;

            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _qtypack = 1;
                _weightbrut = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_weight"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _package = gv_List.CurrentRow.Cells["cn_package"].Value.ToString();
                _boxno = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_boxno"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddPack frm = new frm_AddPack();
                frm.HeaderText = "Edit package: " + _package;
                frm.Package = _package;
                frm.QtyPack = _qtypack;
                frm.WeightBrut = _weightbrut;
                frm.Comments = _comments;
                frm.BoxNO = _boxno;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DNBll.EditPackage(_id, 0, frm.Package, frm.QtyPack, frm.WeightBrut, frm.Comments, frm.BoxNO);
                    FillList();
                }
            }
        }
    }
}
