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
using System.Data.SqlClient;
using Odin.Planning;
using ComponentFactory.Krypton.Toolkit;
using Odin.Tools;


namespace Odin.Warehouse.Requests.Controls
{
    public delegate void SaveRequestDEventHandler(object sender);
    public partial class ctl_CreatReqDets : UserControl
    {
        public ctl_CreatReqDets()
        {
            InitializeComponent();
        }

        #region Variables

        public event SaveRequestDEventHandler SaveRequest;
        DAL_Functions DAL = new DAL_Functions();
        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        Requests_BLL ReqBLL = new Requests_BLL();
        AdmMenu mMenu = new AdmMenu();
        Plan_BLL PlanBLL = new Plan_BLL();
        Helper MyHelper = new Helper();

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public int HeadId
        {
            get { return ReqBLL.RequestHeadId; }
            set { ReqBLL.RequestHeadId = value; }
        }

        public int ArticleId
        {
            get { return cmb_Articles1.ArticleId; }
            set { cmb_Articles1.ArticleId = value; }
        }
        public int BatchId
        {
            get { return cmb_Batches1.BatchId; }
            set { cmb_Batches1.BatchId = value; }
        }

        public string ReqDate
        {
            get { return txt_ReqDate.Value.ToShortDateString(); }
            set
            {
                try { txt_ReqDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public DateTime ReqDateD
        {
            get { return Convert.ToDateTime(txt_ReqDate.Value); }
            set { txt_ReqDate.Value = value; }
        }


        public string Product
        {
            get { return txt_Product.Text; }
            set { txt_Product.Text = value; }
        }

        public string SecName
        {
            get { return txt_SecName.Text; }
            set { txt_SecName.Text = value; }
        }

        public int Mode
        {
            get;
            set;
        }

        public double QtyInBatch
        {
            get { try { return Convert.ToDouble(txt_QtyInBatch.Text); }
                catch { return 0; }
            }
            set { txt_QtyInBatch.Text = value.ToString(); }
        }
        public int ProdPlaceId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }

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

        public bool CheckEmpty()
        {
            if (ReqDate == "")
                return false;
            else
                return true;

        }
        public void AddDetLine(int BatchDetId, int ArtId, string Article, int UnitId, string Unit, double QtyInBatch, double QtyAvail,
                                double QtyRequested, double QtyToRequest, int Urgent, string Comments, string ReqDate, string Batch, 
                                double Reserved, double Given)
        {
            DataRow row = dt_Dets.NewRow();

            row["BDId"] = BatchDetId;
            row["ArtId"] = ArtId;
            row["Article"] = Article;
            row["UnitId"] = UnitId;
            row["Unit"] = Unit;
            row["QtyInBatch"] = QtyInBatch;
            row["QtyAvailable"] = QtyAvail;
            row["QtyRequested"] = QtyRequested;
            row["QtyToRequest"] = QtyToRequest;
            row["Urgent"] = Urgent;
            row["Comments"] = Comments;
            row["ReqDate"] = ReqDate;
            row["Batch"] = Batch;
            row["Given"] = Given;
            row["QtyReserved"] = Reserved;
            row["Reserve"] = 0;
            dt_Dets.Rows.Add(row);
        }

        public void FillBatchDets(int BatchId)
        {
            bool ToAdd = true;
            var data = Plan_BLL.getBatchRM(BatchId);

            foreach (DataRow row in data.Rows)
            {

                ToAdd = true;

                foreach (DataGridViewRow row1 in this.gv_List.Rows)
                {
                    if (Convert.ToInt32(row["id"]) == Convert.ToInt32(row1.Cells["cn_BDId"].Value))
                        ToAdd = false;
                }
                if (ToAdd == true)

                    AddDetLine(Convert.ToInt32(row["id"]), Convert.ToInt32(row["artid"]), row["article"].ToString(),
                            Convert.ToInt32(row["unitid"]), row["unit"].ToString(), Convert.ToDouble(row["qty"]),
                            Convert.ToDouble(row["available"]) + Convert.ToDouble(row["reserved"]), Convert.ToDouble(row["requested"]), 
                            0, 0, "", ReqDate, cmb_Batches1.Batch, Convert.ToDouble(row["reserved"]), Convert.ToDouble(row["given"]));
            }
        }

        public void ClearToRequests()
        {
            foreach (DataRow row in this.dt_Dets.Rows)
            {
                row["QtyToRequest"] = 0;
            }

        }

        public void ClearBatch()
        {
            cmb_Batches1.BatchId = 0;
            Product = "";
            txt_QtyInBatch.Text = "0";
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
                bs_Dets.Filter = ("Convert(" + ColumnName + " , 'System.String') like '%" + mni_FilterFor.Text + "%'");//ColumnName + " like '%" + mni_FilterFor.Text + "%'";
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
                if (String.IsNullOrEmpty(bs_Dets.Filter) == true)
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_Dets.Filter = "(" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_Dets.Filter = "Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
                }
                else
                {
                    if (String.IsNullOrEmpty(CellValue) == true)
                        bs_Dets.Filter = bs_Dets.Filter + "AND (" + ColumnName + " is null OR Convert(" + ColumnName + ", 'System.String') = '')";
                    else
                        bs_Dets.Filter = bs_Dets.Filter + " AND Convert(" + ColumnName + " , 'System.String') = '" + glob_Class.NES(CellValue) + "'";
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
                if (String.IsNullOrEmpty(bs_Dets.Filter) == true)
                    bs_Dets.Filter = "Convert(" + ColumnName + " , 'System.String') <> '" + CellValue + "'";
                else
                    bs_Dets.Filter = bs_Dets.Filter + " AND " + ColumnName + " <> '" + CellValue + "'";
            }
            catch { }
            //SetCellsColor();

        }

        private void mni_RemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                bs_Dets.RemoveFilter();
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

            frm.HeaderText = "Select view for requests list";
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

        private void cmb_Batches1_BatchChanged(object sender)
        {

            Mode = 1;

            Product = cmb_Batches1.Article;
            SecName = cmb_Batches1.SecName;//DAL.Article(cmb_Batches1.ArticleId);
            //SecName = DAL.
            ReqDate = System.DateTime.Now.ToShortDateString();//cmb_Batches1.ResDate;
            QtyInBatch = cmb_Batches1.Qty;

            if (cmb_Batches1.BatchId != 0)
                cmb_Articles1.ArticleId = 0;

            if (cmb_Batches1.IsActive == -1
               || cmb_Batches1.BatchId == 0)
                btn_Add.Enabled = true;
            else
                btn_Add.Enabled = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (CheckEmpty() == true)
            {
                if (Mode == 0) // Articles
                {
                   AddDetLine(0, cmb_Articles1.ArticleId, cmb_Articles1.Article, cmb_Articles1.UnitId, cmb_Articles1.Unit, 0,
                                DAL.AvailQty(cmb_Articles1.ArticleId), 0, 0, 0, "", ReqDate, "", 0, 0);
                }
                else // Batch
                {
                    FillBatchDets(cmb_Batches1.BatchId);
                }
                bs_Dets.Sort = "Article ASC";
            }
            else
            {
                MessageBox.Show("Please check empty requested date or usage code!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearToRequests();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool _test = true;
            bool _testurgent = false;
            bool _isreqdate = true;
            DateTime reqdate;
            //check for header
            gv_List.EndEdit();
            if (ReqBLL.RequestHeadId == 0)
            {
                DialogResult result = KryptonTaskDialog.Show("Request header warning!",
                                                                     "Are you want to save changes?",
                                                                     "Request header is not selected, do you want header to be created automatically?",
                                                                     MessageBoxIcon.Warning,
                                                                     TaskDialogButtons.Yes |
                                                                     TaskDialogButtons.No);
                if (result == DialogResult.Yes)
                {
                    _test = true;
                }
                else
                {
                    _test = false;
                }
            }
            if (_test == true)
            {
                int _res = 0;

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    _isreqdate = DateTime.TryParse(row.Cells["cn_ReqDate"].Value.ToString(), out reqdate);
                    if (Convert.ToDouble(row.Cells["cn_QtyToRequest"].Value) > 0
                        && _isreqdate == true)
                    {
                        int _batchdetid = 0;

                        if (Convert.ToInt32(row.Cells["cn_BDId"].Value) == 0
                            && chk_AddToBatch.CheckState == CheckState.Checked
                            && cmb_Batches1.BatchId != 0)
                        {
                            //Dobavljaem liniju partii
                            _batchdetid = PlanBLL.AddBatchDetail(cmb_Batches1.BatchId, Convert.ToInt32(row.Cells["cn_ArtId"].Value), 0/*Convert.ToDouble(row.Cells["cn_QtyToRequest"].Value)*/, "");
                        }
                        else
                        {
                            _batchdetid = Convert.ToInt32(row.Cells["cn_BDId"].Value);
                        }
                        //MessageBox.Show(Convert.ToInt32(row.Cells["chk_Reserve"].Value).ToString());
                        _res = ReqBLL.AddRequestDetail(ReqBLL.RequestHeadId,
                                                    Convert.ToInt32(row.Cells["cn_ArtId"].Value),
                                                    row.Cells["cn_Article"].Value.ToString(),
                                                    _batchdetid,
                                                    Convert.ToDouble(row.Cells["cn_QtyToRequest"].Value),
                                                    Convert.ToInt32(row.Cells["cn_UnitId"].Value),
                                                    row.Cells["cn_ReqDate"].Value.ToString(),
                                                    Convert.ToInt32(row.Cells["chk_Urgent"].Value),
                                                    row.Cells["cn_Comments"].Value.ToString(),
                                                    0,
                                                    Convert.ToInt32(row.Cells["chk_Reserve"].Value),
                                                    0,
                                                    ProdPlaceId);
                        if (Convert.ToInt32(row.Cells["chk_Urgent"].Value) == -1)
                            _testurgent = true;
                    }
                }
                if (_testurgent == true)
                {
                    //Send letter
                    string emailaddresses = "";
                    emailaddresses = DAL.EmailAddressesByType(4);

                    if (emailaddresses != "")
                    {

                        string strMessage = "Request number: " + ReqBLL.RDReqName;
                        strMessage = strMessage + "\r\nBatch: " + cmb_Batches1.Batch.ToString();
                        MyHelper.SendMessage(glob_Class.ReplaceChar(emailaddresses, ";", ","), "Urgent request NR : " + ReqBLL.RDReqName + " was created!", strMessage);
                    }

                }
            }

            if (SaveRequest != null)
            {
                SaveRequest(this);
            }

        }

        private void btn_Wizard_Click(object sender, EventArgs e)
        {

        }

        private void gv_List_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gv_List.CurrentRow.Cells["cn_QtyToRequest"].Selected == true)
                {
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyToRequest"].Value) < 0)
                        gv_List.CurrentRow.Cells["cn_QtyToRequest"].Value = 0;
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyToRequest"].Value) > Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyAvail"].Value))
                        //gv_Dets.CurrentRow.Cells["cn_QtyToRequest"].Value = gv_Dets.CurrentRow.Cells["cn_QtyAvail"].Value;
                        gv_List.CurrentRow.Cells["cn_QtyAvail"].Style.BackColor = Color.Red;
                    else
                        gv_List.CurrentRow.Cells["cn_QtyAvail"].Style.BackColor = Color.White;


                }
            }
            catch { }
        }

        private void gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double ToRequest = 0;
            try
            {
                if (gv_List.CurrentRow.Cells["bcn_ToReq"].Selected == true)
                {
                    ToRequest = Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyInBatch"].Value)
                                    - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyRequested"].Value)
                                    - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_Reserved"].Value)
                                    - Convert.ToDouble(gv_List.CurrentRow.Cells["cn_Given"].Value);
                                    
                                       
                    gv_List.CurrentRow.Cells["cn_QtyToRequest"].Value = ToRequest;
                    //Color
                    if (Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyToRequest"].Value) < 0)
                        gv_List.CurrentRow.Cells["cn_QtyToRequest"].Value = 0;
                    if (Math.Round(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyToRequest"].Value), 5) > Math.Round(Convert.ToDouble(gv_List.CurrentRow.Cells["cn_QtyAvail"].Value), 5))
                        gv_List.CurrentRow.Cells["cn_QtyAvail"].Style.BackColor = Color.Red;
                    else
                        gv_List.CurrentRow.Cells["cn_QtyAvail"].Style.BackColor = Color.White;
                }
            }
            catch { }
        }

        private void ctl_CreatReqDets_Load(object sender, EventArgs e)
        {
            //LoadColumns(gv_List);
            bn_List.Items.Insert(15, new ToolStripControlHost(chk_AddToBatch));
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            if (cmb_Articles1.ArticleId != 0)
            {
                ClearBatch();
                Mode = 0;
            }


        }


        #endregion

        private void gv_List_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 11)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Global_Resourses.bindingNavigatorAddNewItem_Image.Width;
                var h = Global_Resourses.bindingNavigatorAddNewItem_Image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Global_Resourses.bindingNavigatorAddNewItem_Image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
