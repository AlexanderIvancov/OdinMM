using ComponentFactory.Krypton.Toolkit;
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
    public delegate void FCClosingEventHandler1(object sender);
    public partial class frm_EditBoxContent : KryptonForm
    {
        public frm_EditBoxContent()
        {
            InitializeComponent();
        }

        public int PackId
        { get; set; }

        public int BatchId
        { get; set; }
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public event FCClosingEventHandler1 FormClosed1;
        class_Global globClass = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        StockIn_BLL BLLIN = new StockIn_BLL();
        AdmMenu mMenu = new AdmMenu();


        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        private void btn_AddSerial_Click(object sender, EventArgs e)
        {
            frm_cmbTextPDA frm = new frm_cmbTextPDA();
            frm.HeaderText = "Scan serial number";
            frm.LabelText = "Serial:";
            frm.txt_Text.Focus();

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK
                && frm.FormText != ""
                && CheckBatch(frm.FormText) == true)
            {
                DataTable dataserials = new DataTable();
                dataserials.Columns.Add("serial", typeof(string));
                dataserials.Columns.Add("tablename", typeof(string));

                DataRow drser = dataserials.NewRow();
                drser["serial"] = frm.FormText;
                drser["tablename"] = "";
                dataserials.Rows.Add(drser);


                Helper.getSP("sp_AddStockInBoxDets", PackId, dataserials);

                FillList(PackId);               
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _pref = "S";



            if (globClass.DeleteConfirm() == true)
            {
                foreach (DataGridViewRow row in gv_List.SelectedRows)
                {
                    try
                    {
                        _id = Convert.ToInt32(row.Cells["cn_id"].Value);
                        _pref = row.Cells["cn_pref"].Value.ToString();

                    }
                    catch { }

                    if (_pref == "S")
                        Helper.getSP("sp_DeleteStockInBoxDets", _id);
                    else
                        Helper.getSP("sp_DeleteStockInBoxAddDets", _id);
                }
                gv_List.ThreadSafeCall(delegate { FillList(PackId); });
                txt_Oper.Text = "";
                txt_Oper.Focus();
            }
        }

        public void FillList(int packid)
        {
            var data = (DataTable)Helper.getSP("sp_SelectBatchBoxContent", packid);


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
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            FormClosed1?.Invoke(this);
            //this.Close();
        }
        public string ErrorMessage
        { get; set; }

        public bool CheckErrors(string _serial, string _original, string _analog, int _asprimary)
        {
            bool _res = true;
            ErrorMessage = "";
            //string _batchtry = "L" + _serial.Substring(0, _serial.IndexOf("-") < 0 ? 0 : _serial.IndexOf("-")).ToString();

            int _batchid = 0;
            int _packid = 0;
            int _counttmp = 0;

            //_batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where (serial = '" + _serial + "' or analog = '" + _serial + "') and stageid = 7 "));
            _packid = Convert.ToInt32(Helper.GetOneRecord("select top 1 pc.id from sto_packcontent pc inner join sto_delivpackmapping pm on pm.packid = pc.packid " +
                                        " where pc.sn = '" + _serial + "' and pm.batchid = " + BatchId));

            foreach (DataGridViewRow row in gv_List.Rows)
            {
                if (row.Cells["cn_serial"].Value.ToString() == _serial)
                    _counttmp++;
            }
            int isgroup = Convert.ToInt32(Helper.GetOneRecord("select top 1 isnull(groupid, 0) from prod_batchhead where id = " + BatchId));
            _batchid = isgroup != 0
                ? Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where (serial = '" + _serial + "' or analog = '" + _serial + "') and stageid = 7 order by id desc "))
                : Convert.ToInt32(Helper.GetOneRecord("select top 1 ass.batchid from PROD_SerialAssembling ass inner join prod_serialtracing st on (st.serial = '" + _serial + "' or st.analog = '" + _serial + "') and st.stageid = 7  where ass.serial = '" + _serial + "' order by ass.id desc"));
            if (_batchid == 0)
                _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where (serial = '" + _serial + "' or analog = '" + _serial + "') and stageid = 7 order by id desc "));

            //MessageBox.Show(BatchId.ToString() + " " + _batchid.ToString());

            if (_asprimary == -1
               && _serial != _analog
               && _analog != "")
            {
                _res = false;
                ErrorMessage = "You scan original instead of analog!";
            }
            else if (_asprimary == 0
                && _serial != _original
                && _analog != "")
            {
                _res = false;
                ErrorMessage = "You scan analog instead of original!";
            }
            else if (_batchid == 0)
            {
                _res = false;
                ErrorMessage = "There is no such serial on FQC stage!";
            }
            else if (BatchId != 0 &&
                BatchId != _batchid)
            {
                _res = false;
                ErrorMessage = "Serial you trying to pack does not match to batch in current box!";
            }
            else if (_packid != 0)
            {
                _res = false;
                ErrorMessage = "You already packed this number in box no: " + (Helper.GetOneRecord("select top 1 p.boxno from sto_packcontent pc left join sto_package p on p.id = pc.packid where pc.sn = '" + _serial + "'")).ToString();
            }
            else if (_counttmp > 0)
            {
                _res = false;
                ErrorMessage = "Serial you trying to pack already packed in current box!";
            }
            else
            {
                _res = true;
                ErrorMessage = "";
            }


            return _res;
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
                            column.Visible = globClass.NumToBool(reader["columnvisibility"].ToString());
                            column.Width = Convert.ToInt32(reader["columnwidth"]);
                        }
                    }

                }
                reader.Close();
            }

            sqlConn.Close();

        }

        public bool CheckBatch(string _serial)
        {
            bool _res = false;
                      

            int _batchid = 0;
            int _packid = 0;
           

            _batchid = Convert.ToInt32(Helper.GetOneRecord("select top 1 batchid from prod_serialtracing where serial = '" + _serial + "' and stageid = 7"));
            //_batchid = _batchid == 0 ? Convert.ToInt32(Helper.GetOneRecord("select top 1 id from prod_batchhead where Batch = '" + _batchtry + "'")) : _batchid;
                    


            if (_batchid == 0
                ||
                (BatchId != 0 &&
                BatchId != _batchid))
                _res = false;
            else
            {
                _packid = Convert.ToInt32(Helper.GetOneRecord("select top 1 id from sto_packcontent where sn = '" + _serial + "'"));
                _res = _packid == 0;
            }
            return _res;
        }

        private void frm_EditBoxContent_Activated(object sender, EventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            //txt_Oper.Text = string.Empty;
            //txt_Oper.Focus();
        }

        private void gv_List_Click(object sender, EventArgs e)
        {
            txt_Oper.Text = string.Empty;
            txt_Oper.Focus();
        }

        private void txt_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string _serial = txt_Oper.Text.Trim();
                string _original = "";
                string _analog = "";
                int _asprimary = 0;

                SqlConnection sqlConn = new SqlConnection(sConnStr);
                sqlConn.Open();
                DataSet ds1 = new DataSet();

                SqlDataAdapter adapter1 =
                    new SqlDataAdapter(
                        "execute sp_SelectCheckSerialsPacking @serial = '" + _serial + "'", sqlConn);

                adapter1.Fill(ds1);

                DataTable dt1 = ds1.Tables[0];

                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        _original = dr1["original"].ToString();
                        _analog = dr1["analog"].ToString();
                        _asprimary = Convert.ToInt32(dr1["asprimary"]);
                    }
                }

                if (_serial != ""
                && /*CheckBatch(_serial) == true*/
                CheckErrors(_serial, _original, _analog, _asprimary) == true)
                {
                    DataTable dataserials = new DataTable();
                    dataserials.Columns.Add("serial", typeof(string));
                    dataserials.Columns.Add("tablename", typeof(string));

                    DataRow drser = dataserials.NewRow();
                    drser["serial"] = _serial;
                    drser["tablename"] = "";
                    dataserials.Rows.Add(drser);

                    Helper.getSP("sp_AddStockInBoxDets", PackId, dataserials);

                    FillList(PackId);
                                       
                }
                else
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    frm_Error frm1 = new frm_Error();
                    frm1.HeaderText = ErrorMessage;
                    DialogResult result = frm1.ShowDialog();
                }
                txt_Oper.Text = "";
                txt_Oper.Focus();

            }            
        }

        private void frm_EditBoxContent_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            txt_Oper.Focus();
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
                bs_List.Filter = String.IsNullOrEmpty(bs_List.Filter) == true
                    ? String.IsNullOrEmpty(CellValue) == true
                        ? "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : "Convert(" + ColumnName + " , 'System.String') = '" + globClass.NES(CellValue) + "'"
                    : String.IsNullOrEmpty(CellValue) == true
                        ? bs_List.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')"
                        : bs_List.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + globClass.NES(CellValue) + "'";
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
      
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

        #endregion

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Oper.Text = "";
            txt_Oper.Focus();
        }
    }
}
