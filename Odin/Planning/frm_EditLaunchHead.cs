using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Planning
{
    public delegate void EditLaunchEventHandler(object sender);

    public partial class frm_EditLaunchHead : KryptonForm
    {
        public frm_EditLaunchHead()
        {
            InitializeComponent();
        }

        public event EditLaunchEventHandler EditLaunch;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        class_Global glob_Class = new class_Global();
        Plan_BLL BLL = new Plan_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();


        public int Id
        { get; set; }

        public string HeaderText
        { get { return this.Text; }
            set { this.Text = value; } }

        public string StartDate
        {
            get
            {
                if (txt_StartDate.Value == null)
                    return "";
                else
                    return txt_StartDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_StartDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_StartDate.Value = null; }
            }
        }

        public string ProdStartDate
        {
            get
            {
                if (txt_ProdStartDate.Value == null)
                    return "";
                else
                    return txt_StartDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_ProdStartDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_ProdStartDate.Value = null; }
            }
        }

        public string EndDate
        {
            get
            {
                if (txt_EndDate.Value == null)
                    return "";
                else
                    return txt_EndDate.Value.ToString();
            }
            set
            {
                try
                {
                    txt_EndDate.Value = Convert.ToDateTime(value);
                }
                catch { txt_EndDate.Value = null; }
            }
        }

        public string Comments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value; }

        }

        public double QtyInLaunch
        {
            get
            {
                try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }

        }

        public double oQtyInLaunch
        {
            get; set;

        }
        public bool CheckEmpty()
        {
            if (StartDate.Trim() == ""
                || EndDate.Trim() == ""
                || ProdStartDate.Trim() == ""
                || (Convert.ToDateTime(StartDate) > Convert.ToDateTime(ProdStartDate))
                || (Convert.ToDateTime(ProdStartDate) > Convert.ToDateTime(EndDate))
                )
                return false;
            else
                return true;

        }

       
        public void SetCellsColor()
        {
            int _bdtemp = 0;
            int _colorcount = 0;
            try
            {
                if (gv_List.Rows.Count > 0)
                {
                    _bdtemp = Convert.ToInt32(gv_List.Rows[0].Cells["cn_batchdetid"].Value);
                    _colorcount = 1;

                    foreach (DataGridViewRow row in this.gv_List.Rows)
                    {
                        if (_bdtemp != Convert.ToInt32(row.Cells["cn_batchdetid"].Value))
                        {
                            //Next color

                            //Switch
                            _bdtemp = Convert.ToInt32(row.Cells["cn_batchdetid"].Value);
                            _colorcount++;

                        }
                        row.DefaultCellStyle.BackColor = _colorcount % 2 == 0 ? Color.FromArgb(192, 255, 192) : Color.Azure;//Color.LightGreen : Color.LightPink;

                    }
                }
            }
            catch
            { }
        }

        public void ShowLaunchDets(int _launchid)
        {
            var data = Plan_BLL.getLaunchesEditDet(_launchid);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                SetCellsColor();
            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            FillBatchUnits();
        }

        public void FillBatchUnits()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Unit", typeof(string)));
            string _tmpUnit = "";
            int _k = 0;
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                _k = 0;
                _tmpUnit = row.Cells["cn_unit"].Value.ToString().Trim();
                foreach (DataRow raw1 in dt.Rows)
                {
                    if (raw1["Unit"].ToString().Trim() == _tmpUnit)
                        _k++;
                }
                if (_k == 0)
                {
                    DataRow _addrow = dt.NewRow();
                    _addrow["Unit"] = _tmpUnit;
                    dt.Rows.Add(_addrow);
                }
            }

            cmb_Unit.ComboBox.DataSource = dt;
            cmb_Unit.ComboBox.DisplayMember = "Unit";
            cmb_Unit.ComboBox.ValueMember = "Unit";
        }

        private void txt_ProdStartDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_ProdStartDate.Value = txt_ProdStartDate.Value == null ? System.DateTime.Now : txt_ProdStartDate.Value;
        }

        private void txt_StartDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_StartDate.Value = txt_StartDate.Value == null ? System.DateTime.Now : txt_StartDate.Value;
        }

        private void txt_EndDate_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_EndDate.Value = txt_EndDate.Value == null ? System.DateTime.Now : txt_EndDate.Value;
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

        public void FillDecNum()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(Int32)));

            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());


            dt.Rows[0][0] = 0;
            dt.Rows[1][0] = 1;
            dt.Rows[2][0] = 2;
            dt.Rows[3][0] = 3;
            dt.Rows[4][0] = 4;

            cmb_Decimals.ComboBox.DataSource = dt;
            cmb_Decimals.ComboBox.DisplayMember = "Id";
            cmb_Decimals.ComboBox.ValueMember = "Id";
        }
        public void RecalcQty()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                row.Cells["cn_qty"].Value = Math.Round(Convert.ToDouble(row.Cells["cn_oldqty"].Value) / oQtyInLaunch * QtyInLaunch, 3);
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

            frm.HeaderText = "Select view for batches list";
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
        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddLaunchRMLine frm = new frm_AddLaunchRMLine();
            frm.ShowLaunchDets(Id);
            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
            DialogResult result = frm.ShowDialog();

            frm.ThreadSafeCall(delegate { frm.SetCellsColor(); });
            if (result == DialogResult.OK)
            {
                int _bdtemp = 0;
                frm.gv_List.EndEdit();
                if (frm.gv_List.Rows.Count > 0)
                {
                    _bdtemp = 0;
                    DataTable datadets = new DataTable();
                    datadets.Columns.Add("batchdetid", typeof(int));
                    datadets.Columns.Add("artid", typeof(int));
                    datadets.Columns.Add("qty", typeof(double));

                    foreach (DataGridViewRow row in frm.gv_List.Rows)
                    {
                        if (_bdtemp != Convert.ToInt32(row.Cells["cn_batchdetid"].Value)
                            && Convert.ToDouble(row.Cells["cn_qty"].Value) > 0
                            && Convert.ToInt32(row.Cells["cn_batchdetid"].Value) != 0)
                        {
                            //Insert into temporary table
                            DataRow drl = datadets.NewRow();
                            drl["batchdetid"] = Convert.ToInt32(row.Cells["cn_batchdetid"].Value);
                            drl["artid"] = Convert.ToInt32(row.Cells["cn_artid"].Value);
                            drl["qty"] = Convert.ToDouble(row.Cells["cn_qty"].Value);

                            datadets.Rows.Add(drl);

                            //Switch
                            _bdtemp = Convert.ToInt32(row.Cells["cn_batchdetid"].Value);
                        }
                    }

                    BLL.AddLaunchDets(Id, datadets);
                    
                }
                else
                    MessageBox.Show("Please check quantity and dates of the batch!");
                ShowLaunchDets(Id);
            }
        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                BLL.DeleteLaunchDet(_id);
                ShowLaunchDets(Id);
            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (CheckEmpty() == true)
            {
                string _res = BLL.EditLaunch(Id, StartDate, ProdStartDate, EndDate, Comments, QtyInLaunch);

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    if (Convert.ToDouble(row.Cells["cn_qty"].Value) != Convert.ToDouble(row.Cells["cn_oldqty"].Value))
                    {
                        BLL.EditLaunchDet(Convert.ToInt32(row.Cells["cn_id"].Value), Convert.ToDouble(row.Cells["cn_qty"].Value));
                    }
                }
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Please check dates!!!");
            }
        }

        private void frm_EditLaunchHead_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EditLaunch != null)
                EditLaunch(this);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Round_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                if (row.Cells["cn_unit"].Value.ToString().Trim() == cmb_Unit.Text.Trim())
                {
                    row.Cells["cn_qty"].Value = glob_Class.RoundUp(Convert.ToDouble(row.Cells["cn_qty"].Value), Convert.ToInt32(cmb_Decimals.Text));
                }
            }
        }

        private void frm_EditLaunchHead_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void txt_StartDate_Validated(object sender, EventArgs e)
        {
            ProdStartDate = StartDate;
            EndDate = StartDate;
        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            RecalcQty();
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            RecalcQty();
        }
    }
}
