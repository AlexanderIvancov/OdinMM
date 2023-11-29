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


namespace Odin.Register.Articles
{
    public delegate void SendRatioArtIdEventHandler(int artid);

    public partial class ctl_Rationing : UserControl
    {
        public ctl_Rationing()
        {
            InitializeComponent();
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public event SendRatioArtIdEventHandler SendRatioArtId;
        class_Global glob_Class = new class_Global();
        Reg_BLL Reg = new Reg_BLL();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();


        int _lock = 0;
        public int Lock
        {
            get
            {
                return _lock;
            }
            set { _lock = value; }

        }


        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        int _articleid = 0;

        public int ArtId
        {
            get { return cmb_Articles1.ArticleId; }
            set
            {
                _articleid = value;
                ShowDets();
                
            }
        }

        public double TotalTime
        {
            get { try { return Convert.ToDouble(txt_Total.Text); }
                catch { return 0; } }
            set { txt_Total.Text = value.ToString(); }
        }

        public int SMTType
        {
            get { if (rb_None.Checked == true)
                    return 0;
                else if (rb_TOP.Checked == true)
                    return 1;
                else
                    return 2;
            }
            set {
                if (value == 0)
                    rb_None.Checked = true;
                else if (value == 1)
                    rb_TOP.Checked = true;
                else
                    rb_TOPBOT.Checked = true;
            }
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

        public void ShowDets()
        {
            var data = Reg.getArticleRationings(ArtId);

            gv_List.ThreadSafeCall(delegate
            {
                DataGridViewColumn oldColumn = gv_List.SortedColumn;
                var dir = Helper.SaveDirection(gv_List);
                
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
               
                Helper.RestoreDirection(gv_List, oldColumn, dir);

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            ShowTotals();

            SMTType = cmb_Articles1.SMTType;
        }

        public void ShowTotals()
        {
            double _res = 0;

            foreach (DataGridViewRow row in this.gv_List.Rows)
            {               
                _res = _res + Convert.ToDouble(row.Cells["cn_stagetime"].Value);
            }

            TotalTime = _res;
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
            ExportData ED;

            string _filename = "BillOfMaterials.xls";
            if (cmb_Articles1.ArticleId != 0)
                _filename = cmb_Articles1.Article + "Ratio.xls";
            ED = new ExportData(this.gv_List, _filename, this.Name);
            ED.DgvIntoExcel();
        }

        #endregion

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            if (Lock == -1)
            {
                this.btn_Lock.Values.Image = global::Odin.Global_Resourses.lock_open;
                Lock = 0;
            }
            else

            {
                this.btn_Lock.Values.Image = global::Odin.Global_Resourses._lock;
                Lock = -1;
            }
        }
        

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            var frm = new frm_cmbArt();
            DialogResult result = frm.ShowDialog();
            frm.HeaderText = "Copy rationing from " + cmb_Articles1.Article;

            if (result == DialogResult.OK)
            {
                //Reg.CopyBOM(ArtId, frm.ArticleId);
                cmb_Articles1.ArticleId = frm.ArticleId;
            }
        }

        private void ctl_Rationing_Load(object sender, EventArgs e)
        {
            LoadColumns(gv_List);
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            if (ArtId != 0)
            {
                DataTable dataratios = new DataTable();
                dataratios.Columns.Add("id", typeof(int));
                dataratios.Columns.Add("stageid", typeof(int));
                dataratios.Columns.Add("stagetime", typeof(double));
                dataratios.Columns.Add("comments", typeof(string));

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    DataRow dr = dataratios.NewRow();
                    dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                    dr["stageid"] = Convert.ToInt32(row.Cells["cn_stageid"].Value);
                    dr["stagetime"] = row.Cells["cn_stagetime"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(row.Cells["cn_stagetime"].Value);
                    dr["comments"] = row.Cells["cn_comments"].Value.ToString();

                    dataratios.Rows.Add(dr);
                }

                Reg.SaveArticleRatio(ArtId, dataratios);
                Reg.SaveArticleSMTType(ArtId, SMTType);

                cmb_Articles1.ArticleId = ArtId;

            }

        }

        #endregion

    }
}
