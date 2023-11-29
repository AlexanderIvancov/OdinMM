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
    public partial class frm_LaunchRMReservation : KryptonForm
    {
        public frm_LaunchRMReservation()
        {
            InitializeComponent();
        }

        #region Variables

        Plan_BLL BLL = new Plan_BLL();
        class_Global glob_Class = new class_Global();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        AdmMenu mMenu = new AdmMenu();
        DAL_Functions DAL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        int _id = 0;
        public int LaunchId
        {
            get { return _id; }
            set { _id = value; }
        }
        string _launchgroup = "";
        public string LaunchGroup
        {
            get { return _launchgroup; }
            set { _launchgroup = value; }
        }

        public bool IsMB
        {
            get;
            set;
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


        public void FillList(int _launchid)
        {
            var data = Plan_BLL.getLaunchesDet(_launchid);

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

        }

        public void FillListGroup(string _launch)
        {
            var data = Plan_BLL.getLaunchesGroupDet(_launch);

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

        }

        public void FillLabels(int _launchdetid)
        {
            var data = Plan_BLL.getLaunchesStockDet(_launchdetid);

            gv_Labels.ThreadSafeCall(delegate
            {

                gv_Labels.AutoGenerateColumns = false;
                bs_Labels.DataSource = data;
                gv_Labels.DataSource = bs_Labels;

            });


            bn_Labels.ThreadSafeCall(delegate
            {
                bn_Labels.BindingSource = bs_Labels;
            });

        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_qty"].Value) > Convert.ToDouble(row.Cells["cn_reserved"].Value) + Convert.ToDouble(row.Cells["cn_given"].Value))
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
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

            frm.HeaderText = "Select view for delivery planning";
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            double _qtytmp = 0;
            gv_Labels.EndEdit();
            {
                int _launchdetid = 0;
                try { _launchdetid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
                catch { _launchdetid = 0; }

                if (_launchdetid != 0)
                {
                    DataTable datastages = new DataTable();
                    datastages.Columns.Add("label", typeof(int));
                    datastages.Columns.Add("reserve", typeof(int));
                    datastages.Columns.Add("qty", typeof(double));

                    foreach (DataGridViewRow row in gv_Labels.Rows)
                    {
                        DataRow dr = datastages.NewRow();
                        dr["label"] = Convert.ToInt32(row.Cells["cn_rlabel"].Value);
                        dr["reserve"] = Convert.ToInt32(row.Cells["chk_rchecked"].Value);
                        dr["qty"] = Convert.ToDouble(row.Cells["cn_toreserve"].Value);
                        datastages.Rows.Add(dr);

                        if (Convert.ToInt32(row.Cells["chk_rchecked"].Value) == -1)
                            _qtytmp = _qtytmp + Convert.ToDouble(row.Cells["cn_rqty"].Value);
                    }

                    BLL.ReserveLaunchLabels(_launchdetid, datastages);

                    gv_List.CurrentRow.Cells["cn_reserved"].Value = _qtytmp;
                    SetCellsColor();
                    //gv_List.ThreadSafeCall(delegate { FillList(LaunchId); }) ;
                    gv_Labels.ThreadSafeCall(delegate { FillLabels(_launchdetid); });
                }
            }

        }

        private void frm_LaunchRMReservation_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _launchdetid = 0;
            int _artid = 0;

            try
            {
                _launchdetid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _artid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_artid"].Value);
            }
            catch
            {
                _launchdetid = -99;
                _artid = 0;
            }

            IsMB = DAL.CheckMBLimit(_artid);
            if (_launchdetid != 0)
                FillLabels(_launchdetid);
        }

        #endregion

        private void gv_Labels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _manufbatch = "";
            string _tmpmanufbatch = "";
            int _tmpchecked = 0;
            bool _testmb = true;
            if (gv_Labels.CurrentRow.Cells["chk_rchecked"].Selected == true)
            {
                gv_Labels.EndEdit();

                if (Convert.ToInt32(gv_Labels.CurrentRow.Cells["chk_rchecked"].Value) == -1)
                {
                    if (IsMB == true)
                    {
                        try { _manufbatch = gv_Labels.CurrentRow.Cells["cn_manufbatch"].Value.ToString(); }
                        catch { _manufbatch = ""; }
                        foreach (DataGridViewRow rowt in gv_Labels.Rows)
                        {
                            try
                            {
                                _tmpmanufbatch = rowt.Cells["cn_manufbatch"].Value.ToString();
                                _tmpchecked = Convert.ToInt32(rowt.Cells["chk_rchecked"].Value);
                            }
                            catch
                            {
                                _tmpmanufbatch = "";
                                _tmpchecked = 0;
                            }

                            if (_tmpmanufbatch.Trim() != ""
                                    && _tmpmanufbatch != _manufbatch
                                    && _tmpchecked == -1
                                    && _manufbatch == "")
                            {
                                _testmb = false;
                                break;
                            }
                        }


                        if (_testmb == false)
                        {
                            glob_Class.ShowMessage("You can't reserve different manufacturing batches for this article!", "Please check manufacturing batches!", "Labels check-in error");
                            gv_Labels.CurrentRow.Cells["chk_rchecked"].Value = 0;
                            gv_Labels.CurrentRow.Cells["cn_toreserve"].Value = 0;
                        }
                        else
                        {
                            gv_Labels.CurrentRow.Cells["cn_toreserve"].Value = Convert.ToDouble(gv_Labels.CurrentRow.Cells["cn_rqty"].Value);
                        }
                    }
                    else
                        gv_Labels.CurrentRow.Cells["cn_toreserve"].Value = Convert.ToDouble(gv_Labels.CurrentRow.Cells["cn_rqty"].Value);
                }
                else
                {
                    gv_Labels.CurrentRow.Cells["cn_toreserve"].Value = 0;
                }

                bs_Labels.ResetBindings(true);
            }
        }

        private void btn_ReleaseLaunch_Click(object sender, EventArgs e)
        {
            if (glob_Class.MessageConfirm("Are you sure you want to release all labels from launch?", "Labels releasing") == true)
            {
                BLL.ReleaseLaunchLabels(LaunchId);

                gv_List.ThreadSafeCall(delegate { FillList(LaunchId); });

            }
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
