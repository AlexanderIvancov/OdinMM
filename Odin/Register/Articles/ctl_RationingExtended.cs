using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Register.Articles
{
    public partial class ctl_RationingExtended : UserControl
    {
        public ctl_RationingExtended()
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
                FillStages(_articleid);

            }
        }

        public string Param
        {
            get { return txt_param.Text; }
            set { txt_param.Text = value; }
        }

        public double ParamValue
        {
            get
            {
                try { return Convert.ToDouble(txt_value.Text); }
                catch { return 0; }
            }
            set
            {
                txt_value.Text = value.ToString();
            }

        }

        public string ParamDesc
        {
            get { return txt_paramdesc.Text; }
            set { txt_paramdesc.Text = value; }
        }

        public int OperId
        { get; set; }

        public double Prepa
        {
            get
            {
                try { return Convert.ToDouble(txt_Prepa.Text); }
                catch { return 0; }
            }
            set
            {
                txt_Prepa.Text = value.ToString();
            }

        }

        public double Total
        {
            get
            {
                try { return Convert.ToDouble(txt_Total.Text); }
                catch { return 0; }
            }
            set
            {
                txt_Total.Text = value.ToString();
            }

        }

        #endregion

        #region Methods

        public void FillStages(int artid)
        {

            var data = Reg.getArticleStagesRationings(artid);

            gv_List.ThreadSafeCall(delegate
            {
                //DataGridViewColumn oldColumn = gv_List.SortedColumn;
                //var dir = Helper.SaveDirection(gv_List);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

                //Helper.RestoreDirection(gv_List, oldColumn, dir);

            });


            bn_List.ThreadSafeCall(delegate
            {
                bn_List.BindingSource = bs_List;
            });

            ShowTotals(artid);
        }

        public void FillOpers(int artid, int stageid)
        {

            var data = Reg.getArticleStagesOperations(artid, stageid);

            gv_Opers.ThreadSafeCall(delegate
            {
                //DataGridViewColumn oldColumn = gv_Opers.SortedColumn;
                //var dir = Helper.SaveDirection(gv_Opers);

                gv_Opers.AutoGenerateColumns = false;
                bs_Opers.DataSource = data;
                gv_Opers.DataSource = bs_Opers;

                // Helper.RestoreDirection(gv_List, oldColumn, dir);

            });


            bn_Opers.ThreadSafeCall(delegate
            {
                bn_Opers.BindingSource = bs_Opers;
            });

            SetCellsColor();

        }

        public void FillParams(int operid)
        {

            var data = Reg.getArticleStagesOperParams(operid);

            gv_Params.ThreadSafeCall(delegate
            {
                //DataGridViewColumn oldColumn = gv_Params.SortedColumn;
                //var dir = Helper.SaveDirection(gv_Params);

                gv_Params.AutoGenerateColumns = false;
                bs_Params.DataSource = data;
                gv_Params.DataSource = bs_Params;

                //Helper.RestoreDirection(gv_Params, oldColumn, dir);

            });

        }

        public void ShowTotals(int artid)
        {
            SqlConnection conn = new SqlConnection(sConnStr);
            conn.Open();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "execute sp_SelectArtRatioTotals @artid = " + artid, conn);


            conn.Close();

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Total = Convert.ToDouble(dr["total"]);
                    Prepa = Convert.ToDouble(dr["prepa"]);
                }
            }
            else
            {
                Total = 0;
                Prepa = 0;
            }
        }

        public void SetCellsColor()
        {
            foreach (DataGridViewRow row in this.gv_Opers.Rows)
            {
                if (Convert.ToDouble(row.Cells["cn_opertime"].Value) == -999)
                    row.Cells["cn_opertime"].Style.BackColor = Color.Tomato;
            }

        }

        public void EditOperation()
        {
            int _operid = 0;
            string _operation = "";
            string _formula = "";
            int _useonce = 0;
            int _operno = 0;
            try
            {
                _operid = Convert.ToInt32(gv_Opers.CurrentRow.Cells["cn_operid"].Value);
                _operation = gv_Opers.CurrentRow.Cells["cn_operation"].Value.ToString();
                _formula = gv_Opers.CurrentRow.Cells["cn_formula"].Value.ToString();
                _useonce = Convert.ToInt32(gv_Opers.CurrentRow.Cells["chk_useonetime"].Value);
                _operno = Convert.ToInt32(gv_Opers.CurrentRow.Cells["cn_operno"].Value);
            }
            catch { }

            if (_operid != 0)
            {
                frm_AddOperation frm = new frm_AddOperation();
                frm.Id = _operid;
                frm.Operation = _operation;
                frm.Formula = _formula;
                frm.UsingOnce = _useonce;
                frm.OperNO = _operno;
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Reg.EditRatioOperation(frm.Id, frm.Operation, frm.Formula, frm.UsingOnce, frm.OperNO);
                    //Forumla result update

                    double FormulaRes = Reg.SelectFormulaRes(_operid);
                    //Update formula results
                    Reg.UpdateFormulaRes(_operid, FormulaRes);

                    int _stageid = 0;
                    try { _stageid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value); }
                    catch { }

                    FillOpers(ArtId, _stageid);
                    ShowTotals(ArtId);
                }

            }
        }
        #endregion

        #region Controls

        private void btn_saveparameter_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in this.gv_Params.Rows)
            //{
            //    if (row.Cells["cn_param"].Value.ToString() == Param)
            //    {
            //        row.Cells["cn_paramvalue"].Value = ParamValue;
            //        row.Cells["cn_paramdesc"].Value = ParamDesc;
            //        break;
            //    }
            //}
            //Save formula params
            gv_Params.EndEdit();
            DataTable dataparams = new DataTable();
            dataparams.Columns.Add("id", typeof(int));
            dataparams.Columns.Add("operid", typeof(int));
            dataparams.Columns.Add("param", typeof(string));
            dataparams.Columns.Add("paramdesc", typeof(string));
            dataparams.Columns.Add("value", typeof(double));

            foreach (DataGridViewRow row in this.gv_Params.Rows)
            {
                DataRow dr = dataparams.NewRow();
                dr["id"] = Convert.ToInt32(row.Cells["cn_paramid"].Value);
                dr["operid"] = Convert.ToInt32(row.Cells["cn_paramoperid"].Value);
                dr["param"] = row.Cells["cn_param"].Value.ToString();
                dr["paramdesc"] = row.Cells["cn_paramdesc"].Value.ToString();
                dr["value"] = row.Cells["cn_paramvalue"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(row.Cells["cn_paramvalue"].Value);

                dataparams.Rows.Add(dr);
            }

            if (OperId != 0)
                Reg.SaveFormulaParams(dataparams, OperId);
            //Select formula results
            double FormulaRes = Reg.SelectFormulaRes(OperId);
            //Update formula results
            Reg.UpdateFormulaRes(OperId, FormulaRes);

            int _stageid = 0;
            try { _stageid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value); }
            catch { }

            FillOpers(ArtId, _stageid);
            ShowTotals(ArtId);
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            int _stageid = 0;
            try { _stageid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value); }
            catch { }

            FillOpers(ArtId, _stageid);
        }

        private void gv_Opers_SelectionChanged(object sender, EventArgs e)
        {
            int _operid = 0;
            try { _operid = Convert.ToInt32(gv_Opers.CurrentRow.Cells["cn_operid"].Value); }
            catch { }

            FillParams(_operid);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();
            if (ArtId != 0)
            {
                DataTable dataratios = new DataTable();
                dataratios.Columns.Add("id", typeof(int));
                dataratios.Columns.Add("stageid", typeof(int));
                dataratios.Columns.Add("botline1", typeof(double));
                dataratios.Columns.Add("topline1", typeof(double));
                dataratios.Columns.Add("botline2", typeof(double));
                dataratios.Columns.Add("topline2", typeof(double));
                dataratios.Columns.Add("difficultycoef", typeof(double));

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    DataRow dr = dataratios.NewRow();
                    dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);
                    dr["stageid"] = Convert.ToInt32(row.Cells["cn_stageid"].Value);
                    dr["botline1"] = row.Cells["cn_botline1"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(row.Cells["cn_botline1"].Value);
                    dr["topline1"] = row.Cells["cn_topline1"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(row.Cells["cn_topline1"].Value);
                    dr["botline2"] = row.Cells["cn_botline2"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(row.Cells["cn_botline2"].Value);
                    dr["topline2"] = row.Cells["cn_topline2"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(row.Cells["cn_topline2"].Value);
                    dr["difficultycoef"] = row.Cells["cn_diffcoef"].Value.ToString().Trim() == "" ? 0 : Convert.ToDouble(row.Cells["cn_diffcoef"].Value);

                    dataratios.Rows.Add(dr);
                }

                Reg.SaveArticleRatioStages(ArtId, dataratios);

                cmb_Articles1.ArticleId = ArtId;

                FillStages(ArtId);

            }
        }

        private void gv_Params_SelectionChanged(object sender, EventArgs e)
        {

            string _param = "";
            string _paramdesc = "";
            double _value = 0;
            int _id = 0;
            try
            {
                OperId = Convert.ToInt32(gv_Params.CurrentRow.Cells["cn_paramoperid"].Value);
                _param = gv_Params.CurrentRow.Cells["cn_param"].Value.ToString();
                _paramdesc = gv_Params.CurrentRow.Cells["cn_paramdesc"].Value.ToString();
                _id = Convert.ToInt32(gv_Params.CurrentRow.Cells["cn_paramid"].Value);
                _value = Convert.ToDouble(gv_Params.CurrentRow.Cells["cn_paramvalue"].Value);
            }
            catch
            {
                OperId = 0;
            }

            Param = _param;
            ParamDesc = _paramdesc;
            ParamValue = _value;

        }

        private void btn_AddOper_Click(object sender, EventArgs e)
        {
            int _stageid = 0;
            try { _stageid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value); }
            catch { }

            if (_stageid != 0
                && ArtId != 0)
            {
                frm_AddOperation frm = new frm_AddOperation();
                frm.CheckEmpty();
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Reg.AddRatioOperation(ArtId, _stageid, frm.Operation, frm.Formula, frm.UsingOnce, frm.OperNO);
                    FillOpers(ArtId, _stageid);
                    ShowTotals(ArtId);
                }
            }
        }

        private void btn_EditOper_Click(object sender, EventArgs e)
        {
            EditOperation();
        }

        private void btn_DeleteOper_Click(object sender, EventArgs e)
        {
            int _operid = 0;
            try { _operid = Convert.ToInt32(gv_Opers.CurrentRow.Cells["cn_operid"].Value); }
            catch { }

            if (_operid != 0
                && glob_Class.DeleteConfirm() == true)
            {
                Reg.DeleteRatioOperation(_operid);
                FillParams(0);

                int _stageid = 0;
                try { _stageid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value); }
                catch { }

                FillOpers(ArtId, _stageid);
                ShowTotals(ArtId);
            }
        }



        #endregion

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            ArtId = cmb_Articles1.ArticleId;
        }

        private void gv_Opers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCellsColor();
        }

        private void gv_Opers_DoubleClick(object sender, EventArgs e)
        {
            EditOperation();//btn_EditOper.PerformClick();
        }

        private void gv_Opers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_CopyOper_Click(object sender, EventArgs e)
        {
            if (//glob_Class.MessageConfirm("Are you sure you want to copy ratio?", "Copy ratio?") == true
                //&& 
               ArtId != 0)
            {
                frm_cmbArt frm = new frm_cmbArt();
                frm.HeaderText = "Copy ratio for " + cmb_Articles1.Article + " from article above:";
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Reg.CopyBOMStages(frm.ArticleId, ArtId);
                    FillStages(ArtId);
                    int _stageid = 0;
                    try { _stageid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_stageid"].Value); }
                    catch { }

                    FillOpers(ArtId, _stageid);

                    int _operid = 0;
                    try { _operid = Convert.ToInt32(gv_Opers.CurrentRow.Cells["cn_operid"].Value); }
                    catch { }

                    FillParams(_operid);

                    ShowTotals(ArtId);

                }

            }
        }

        private void btn_CopyRatio_Click(object sender, EventArgs e)
        {
            btn_CopyOper.PerformClick();
        }
    }
}
