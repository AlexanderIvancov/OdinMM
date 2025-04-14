using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Odin.Global_Classes;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using Odin.Planning.Controls;
using System.Threading;
using System.Data.SqlClient;
using Odin.Tools;


namespace Odin.Quality
{
    public partial class frm_IncomeControlResult : BaseForm
    {
        public frm_IncomeControlResult()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "IncomeControlResult.xls", this.Name);
        }

        #region Variables

        ExportData ED;
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        class_Global globClass = new class_Global();
        Helper MyHelper = new Helper();
        Quality_BLL BLL = new Quality_BLL();
        frm_AddIncomeControlResult frm;

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        #endregion

        #region Methods

        public void ClearFilter()
        {
            cmb_Firms1.FirmId = 0;
            cmb_Types1.TypeId = 0;
            cmb_Articles1.ArticleId = 0;
            cmb_Articles1.Article = "";
            txt_SecArticle.Text = string.Empty;
            mni_FilterFor.Text = string.Empty;
            bs_List.RemoveFilter();
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


        public void bw_List(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(cmb_DeliveryNotes1.DelivNoteId.ToString());
            var data = Quality_BLL.getIncomeControlResultList(cmb_Types1.TypeId, cmb_Firms1.FirmId,
                                                        cmb_Articles1.ArticleId, cmb_Articles1.Article, txt_SecArticle.Text,
                                                        txt_StartFrom.Value == null ? "" : txt_StartFrom.Value.ToString().Trim(),
                                                        txt_StartTill.Value == null ? "" : txt_StartTill.Value.ToString().Trim(), 
                                                        cmb_Batches1.BatchId);

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

        public void AddIncomeControlResult(object sender)
        {
            frm.gv_List.EndEdit();
            foreach (DataGridViewRow row in frm.gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["cn_qtychecked"].Value) > 0)
                {
                    BLL.SaveIncomeControlResult(0, 
                            Convert.ToInt32(row.Cells["cn_id"].Value),
                            Convert.ToDouble(row.Cells["cn_qtychecked"].Value),
                            Convert.ToDouble(row.Cells["cn_qtyscrap"].Value),
                            row.Cells["cn_reclamation"].Value.ToString(),
                            row.Cells["cn_comments"].Value.ToString(),
                            row.Cells["cn_checkdate"].Value.ToString(),
                            row.Cells["cn_controller"].Value.ToString());
                }
            }
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);

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

            frm.HeaderText = "Select view for articles list";
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
        private void frm_IncomeControl_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
            txt_StartFrom.Value = null;
            txt_StartTill.Value = null;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DataGridViewColumn oldColumn = gv_List.SortedColumn;
            var dir = Helper.SaveDirection(gv_List);

            bwStart(bw_List);

            Helper.RestoreDirection(gv_List, oldColumn, dir);
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frm = new frm_AddIncomeControlResult();
            frm.HeaderText = "Add new income control results ";
            frm.IncomeControlSaved += new IncomeControlResSavedEventHandler(AddIncomeControlResult);
            frm.Show();

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
       
            string _comments = "";
            string _reclamation = "";
            double _qtychecked = 0;
            double _qtyscrap = 0;
            string _article = "";
            string _checkdate = "";
            string _controller = "";

            try {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
                _comments = gv_List.CurrentRow.Cells["cn_comments"].Value.ToString();
                _reclamation = gv_List.CurrentRow.Cells["cn_reclamation"].Value.ToString();
                _qtychecked = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qtychecked"].Value);
                _qtyscrap = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_qtyscrap"].Value);
                _article = gv_List.CurrentRow.Cells["cn_article"].Value.ToString();
                _checkdate = gv_List.CurrentRow.Cells["cn_checkdate"].Value.ToString();
                _controller = gv_List.CurrentRow.Cells["cn_controller"].Value.ToString();
            }

            catch { }

            if (_id != 0)
            {
                frm_EditIncomeControlResult frm = new frm_EditIncomeControlResult();
                frm.HeaderText = "Edit income control results ";
                frm.ID = _id;
                frm.Article = _article;
                frm.Comments = _comments;
                frm.Reclamation = _reclamation;
                frm.QtyChecked = _qtychecked;
                frm.QtyScrap = _qtyscrap;
                frm.Controller = _controller;
                frm.CheckDate = _checkdate;

                DialogResult result = frm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    BLL.SaveIncomeControlResult(_id,
                            0,
                            frm.QtyChecked,
                            frm.QtyScrap,
                            frm.Reclamation,
                            frm.Comments,
                            frm.CheckDate,
                            frm.Controller);
                    DataGridViewColumn oldColumn = gv_List.SortedColumn;
                    var dir = Helper.SaveDirection(gv_List);

                    bwStart(bw_List);

                    Helper.RestoreDirection(gv_List, oldColumn, dir);

                }

                //frm_AddIncomeControl frm = new frm_AddIncomeControl();
                //frm.HeaderText = "Edit income control parameters ";
                //frm.ID = _id;
                //frm.ArtId = _artid;
                //frm.SupId = _supid;
                //frm.Comments = _comments;

                //DialogResult result = frm.ShowDialog();

                //if (result == DialogResult.OK)
                //{
                //    BLL.SaveIncomeControl(_id, frm.ArtId, frm.SupId, frm.Comments);

                //    bwStart(bw_List);
                //}

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
           
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            }

            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {

                BLL.DeleteIncomeControlResult(_id);
                bwStart(bw_List);

            }
        }



        #endregion

        private void txt_StartFrom_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_StartFrom.Value = txt_StartFrom.Value == null ? System.DateTime.Now : txt_StartFrom.Value;
        }

        private void txt_StartTill_DropDown(object sender, DateTimePickerDropArgs e)
        {
            txt_StartTill.Value = txt_StartTill.Value == null ? System.DateTime.Now : txt_StartTill.Value;
        }
    }
}
