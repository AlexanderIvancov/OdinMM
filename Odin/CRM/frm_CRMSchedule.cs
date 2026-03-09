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
using Odin.CMB_Components.BLL;
using Odin.CMB_Components.Users;

namespace Odin.CRM
{
    public partial class frm_CRMSchedule : KryptonForm
    {
        public frm_CRMSchedule()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "ActionSchedule.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
       
        CMB_BLL Bllc = new CMB_BLL();
        frm_AddEventSchedule frmEvs = null;
        CRM_BLL BLL = new CRM_BLL();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int _PrevId = 0;

        public int WorkerId
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public void FillList()
        {
            var data = CRM_BLL.getEventScheduleList(cmb_Firms1.FirmId, txt_From.Text.Trim() == "" ? System.DateTime.Now.AddYears(-30).ToShortDateString() : txt_From.Text.Trim(),
                                                txt_Till.Text.Trim() == "" ? System.DateTime.Now.AddYears(1).ToShortDateString() : txt_Till.Text.Trim());

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

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_List.Rows)
            {
                try {
                    if (Convert.ToDateTime(row.Cells["cn_plandate"].Value.ToString()).AddDays(1) < System.DateTime.Now
                        && row.Cells["cn_execdate"].Value.ToString().Trim() == "")
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.LightCoral;
                }
                catch { }
                
            }
        }

        public void ShowEditSchedule()
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddEventSchedule")) return;

            int _id = 0;
            string _action = "";
            try {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _action = gv_List.CurrentRow.Cells["cn_id"].Value.ToString(); }
            catch { }

            if (_id != 0)
            {
                frmEvs = new frm_AddEventSchedule();
                frmEvs.HeaderText = "Edit schedule for: " + cmb_Firms1.Firm;
                
                frmEvs.Id = _id;

                BLL.EventSchedId = _id;

                frmEvs.Action = BLL.EvsAction;
                frmEvs.RespPerson = BLL.EvsRespPerson;
                frmEvs.EventDate = BLL.EvsPlanDate;
                frmEvs.ExecDate = BLL.EvsExecDate;
                frmEvs.StateId = BLL.EvsStateId;
                frmEvs.Result = BLL.EvsResult;
                frmEvs.Comments = BLL.EvsComments;
                frmEvs.EventScheduleSaving += new EventScheduleSavingEventHandler(EditEventSchedule);
                frmEvs.Show();

            }
        }

        public void EditEventSchedule(object sender)
        {
            BLL.EditEventSchedule(frmEvs.Id, frmEvs.Action, frmEvs.RespPerson, frmEvs.EventDate, frmEvs.ExecDate, frmEvs.StateId, frmEvs.Result, frmEvs.Comments);
            FillList();

        }

        #endregion

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

        #region Controls
        
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEditSchedule();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                BLL.DeleteEventSchedule(_id);
                FillList();
            }
        }

        #endregion

        private void frm_Vacations_Load(object sender, EventArgs e)
        {
            //var date = DateTime.Now.AddDays(-7);
            //var difference = date.DayOfWeek - DayOfWeek.Monday;
            //if (difference < 0)
            //    difference += 7;
            //var mondayDate = date.AddDays(-1 * difference).Date;



            txt_From.Value = System.DateTime.Now;//mondayDate;
            txt_Till.Value = DateTime.Now.AddDays(7);

            //FillList();
            LoadColumns(gv_List);
        }

        private void gv_List_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void txt_From_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_From.Value = txt_From.Value == null ? System.DateTime.Now : txt_From.Value;
        }

        private void txt_Till_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_Till.Value = txt_Till.Value == null ? System.DateTime.Now : txt_Till.Value;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillList();
        }

        private void gv_List_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }
    }
}
