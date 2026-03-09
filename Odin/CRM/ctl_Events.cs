using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using Odin.Tools;
using System.Data.SqlClient;

namespace Odin.CRM
{
    public partial class ctl_Events : UserControl
    {
        public ctl_Events()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "EventList.xls", this.Name);
        }

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        CRM_BLL BLL = new CRM_BLL();
        ExportData ED;
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        frm_AddEvent frmEv = null;
        frm_AddEventSchedule frmEvs = null;
        public int Id
        {
            get;
            set;
        }

        int _FirmId = 0;

        public int FirmId
        {
            get { return cmb_Firms1.FirmId; }
            set
            {
                _FirmId = value;
                FillEvents(_FirmId);
            }
        }

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";
        public int RowIndexD = 0;
        public int ColumnIndexD = 0;
        public string ColumnNameD = "";
        public string CellValueD = "";


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

        public void FillEvents(int Firmid)
        {
            var data = CRM_BLL.getEvents(Firmid);

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

        public void FillSchedule(int EventId)
        {
            var data = CRM_BLL.getEventSchedule(EventId);

            gv_Dets.ThreadSafeCall(delegate
            {
                gv_Dets.AutoGenerateColumns = false;
                bs_Dets.DataSource = data;
                gv_Dets.DataSource = bs_Dets;

            });


            bn_Dets.ThreadSafeCall(delegate
            {
                bn_Dets.BindingSource = bs_Dets;
            });
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddEvent")) return;

            frmEv = new frm_AddEvent();
            frmEv.HeaderText = "Add new event for: " + cmb_Firms1.Firm;
            frmEv.FirmId = FirmId;
            frmEv.EventSaving += new EventSavingEventHandler(AddEvent);
            frmEv.Show();
                        
        }

        public void AddEvent(object sender)
        {
            int _res = BLL.AddEvent(FirmId, frmEv.ContactId, frmEv.Contact, frmEv.Goal, frmEv.Theme, frmEv.Place, frmEv.EventDate,
                                    frmEv.ContWay, frmEv.State, frmEv.Result, frmEv.Comments, frmEv.Link);

            FillEvents(FirmId);
        }

        public void EditEvent(object sender)
        {
            BLL.EditEvent(frmEv.Id, FirmId, frmEv.ContactId, frmEv.Contact, frmEv.Goal, frmEv.Theme, frmEv.Place, frmEv.EventDate,
                                   frmEv.ContWay, frmEv.State, frmEv.Result, frmEv.Comments, frmEv.Link);

            FillEvents(FirmId);
        }

        public void AddEventSchedule(object sender)
        {
            BLL.AddEventSchedule(Id, frmEvs.Action, frmEvs.RespPerson, frmEvs.EventDate, frmEvs.ExecDate, frmEvs.StateId, frmEvs.Result, frmEvs.Comments);

            FillSchedule(Id);
        }

        public void EditEventSchedule(object sender)
        {
            BLL.EditEventSchedule(frmEvs.Id, frmEvs.Action, frmEvs.RespPerson, frmEvs.EventDate, frmEvs.ExecDate, frmEvs.StateId, frmEvs.Result, frmEvs.Comments);
            FillSchedule(Id);

        }
        public void ShowEdit()
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddEvent")) return;

            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frmEv = new frm_AddEvent();
                frmEv.HeaderText = "Edit event for: " + cmb_Firms1.Firm;
                frmEv.FirmId = FirmId;

                frmEv.Id = _id;

                BLL.EventId = _id;

                frmEv.ContactId = BLL.EvContactId;
                frmEv.Contact = BLL.EvContact;
                frmEv.Goal = BLL.EvGoal;
                frmEv.Theme = BLL.EvTheme;
                frmEv.Place = BLL.EvPlace;
                frmEv.EventDate = BLL.EvDate;
                frmEv.ContWay = BLL.EvWay;
                frmEv.State = BLL.EvState;
                frmEv.Result = BLL.EvResult;
                frmEv.Comments = BLL.EvComments;
                frmEv.Link = BLL.EvLink;
                frmEv.EventSaving += new EventSavingEventHandler(EditEvent);
                frmEv.Show();

                //DialogResult result = frm.ShowDialog();

                //if (result == DialogResult.OK)
                //{
                //    BLL.EditEvent(frm.Id, FirmId, frm.ContactId, frm.Contact, frm.Goal, frm.Theme, frm.Place, frm.EventDate,
                //                    frm.ContWay, frm.State, frm.Result, frm.Comments, frm.Link);

                //    FillEvents(FirmId);
                //}
            }
        }

        public void ShowEditSchedule()
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddEventSchedule")) return;

            int _id = 0;
            try { _id = Convert.ToInt32(gv_Dets.CurrentRow.Cells["cn_sid"].Value); }
            catch { }

            if (_id != 0)
            {                
                frmEvs = new frm_AddEventSchedule();
                frmEvs.HeaderText = "Edit schedule for: " + cmb_Firms1.Firm;
                frmEvs.FirmId = FirmId;

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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ShowEdit();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                BLL.DeleteEvent(_id);
                FillEvents(FirmId);
            }
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            FirmId = cmb_Firms1.FirmId;
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            BLL.ActId = _id;

            FillSchedule(_id);
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
            //SetCellsColor();

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
           // SetCellsColor();

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

            frm.HeaderText = "Select view for events list";
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

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (gv_List.CurrentRow.Cells["cn_link"].Selected == true)
                {
                    string Link = gv_List.CurrentRow.Cells["cn_link"].Value.ToString();
                    if (glob_Class.NES(Link) != "")
                        System.Diagnostics.Process.Start(Link);
                }

            }
            catch
            { }
        }


        #endregion

        #region Context menu schedule




        private void mnu_LinesD_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Point mpoint = gv_Dets.PointToClient(DataGridView.MousePosition);
                DataGridView.HitTestInfo info = gv_Dets.HitTest(mpoint.X, mpoint.Y);

                RowIndexD = info.RowIndex;
                ColumnIndexD = info.ColumnIndex;
                //MessageBox.Show(RowIndex.ToString() + "MO," + ColumnIndex.ToString());

                gv_Dets.ClearSelection();
                gv_Dets.Rows[RowIndexD].Cells[ColumnIndexD].Selected = true;
                gv_Dets.CurrentCell = gv_Dets.Rows[RowIndexD].Cells[ColumnIndexD];

                CellValueD = gv_Dets.Rows[RowIndexD].Cells[ColumnIndexD].Value.ToString();
                ColumnNameD = gv_Dets.Columns[ColumnIndexD].DataPropertyName.ToString();
                //gv_List.SelectionChanged += new EventHandler(gv_List_SelectionChanged(this));

            }
            catch
            {
                RowIndexD = 0;
                ColumnIndexD = 0;
                return;
            }
        }

        private void mni_FilterForD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs_Dets.Filter = ("Convert(" + ColumnNameD + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
            }
            catch
            { }
            //SetCellsColor();

        }

        private void mni_SearchD_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find();
            frm.grid = gv_Dets;
            frm.ColumnNumber = gv_Dets.CurrentCell.ColumnIndex;
            frm.ColumnText = gv_Dets.Columns[frm.ColumnNumber].HeaderText;
            frm.ShowDialog();
        }

        private void mni_FilterByD_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Dets.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValueD) == true)
                        bs_Dets.Filter = "(" + ColumnNameD + " is null OR Convert(" + ColumnNameD + ", 'System.String') = '')";
                    else
                        bs_Dets.Filter = "Convert(" + ColumnNameD + " , 'System.String') = '" + glob_Class.NES(CellValueD) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValueD) == true)
                        bs_Dets.Filter = bs_Dets.Filter + "AND (" + ColumnNameD + " is null OR Convert(" + ColumnNameD + ", 'System.String') = '')";
                    else
                        bs_Dets.Filter = bs_Dets.Filter + " AND Convert(" + ColumnNameD + " , 'System.String') = '" + glob_Class.NES(CellValueD) + "'";
                }
                //MessageBox.Show(bs_List.Filter);

            }
            catch { }
            //SetCellsColor();

        }

        private void mni_FilterExcludingSelD_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(bs_Dets.Filter) == true)
                    bs_Dets.Filter = "Convert(" + ColumnNameD + " , 'System.String') <> '" + CellValueD + "'";
                else
                    bs_Dets.Filter = bs_Dets.Filter + " AND " + ColumnNameD + " <> '" + CellValueD + "'";
            }
            catch { }
            // SetCellsColor();

        }

        private void mni_RemoveFilterD_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Dets.RemoveFilter();
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_CopyD_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CellValueD.ToString());
        }


        private void mni_AdminD_Click(object sender, EventArgs e)
        {
            frm_GridViewAdm frm = new frm_GridViewAdm();

            frm.HeaderText = "Select view for schedule list";
            frm.grid = this.gv_Dets;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                LoadColumns(gv_Dets);
            }
        }
        
        #endregion

        private void ctl_Events_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            LoadColumns(gv_Dets);
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEdit();
        }

        private void gv_Dets_SelectionChanged(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = Convert.ToInt32(gv_Dets.CurrentRow.Cells["cn_sid"].Value); }
            catch { }

            BLL.EventSchedId = _id;
        }

        private void btn_AddEvSched_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddEventSchedule")) return;

            int _id = 0;
            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            Id = _id;
            frmEvs = new frm_AddEventSchedule();

            frmEvs.HeaderText = "Add new event schedule for: " + cmb_Firms1.Firm;
            frmEvs.FirmId = FirmId;
            frmEvs.EventId = _id;
            frmEvs.FillDate();
            frmEvs.EventScheduleSaving += new EventScheduleSavingEventHandler(AddEventSchedule);
            frmEvs.Show();

        }

        private void btn_EditEvSched_Click(object sender, EventArgs e)
        {
            ShowEditSchedule();
        }

        private void btn_DeleteEvSched_Click(object sender, EventArgs e)
        {
            int _sid = 0;
            int _id = 0;
            try {
                _sid = Convert.ToInt32(gv_Dets.CurrentRow.Cells["cn_sid"].Value);
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }
            catch { }

            if (glob_Class.DeleteConfirm() == true
                && _id != 0)
            {
                BLL.DeleteEventSchedule(_sid);
                FillSchedule(_id);
            }
        }

        private void gv_Dets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEditSchedule();
        }
    }
}
