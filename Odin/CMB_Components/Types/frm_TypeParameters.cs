using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CMB_Components.Types
{
    public partial class frm_TypeParameters : KryptonForm
    {
        public frm_TypeParameters()
        {
            InitializeComponent();
            ED = new ExportData(this.gv_List, "Specifications.xls", this.Name);
        }

        #region Variables

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;
        class_Global glob_Class = new class_Global();
        DAL_Functions DAL = new DAL_Functions();
        AdmMenu mMenu = new AdmMenu();
        ExportData ED;
        Helper MyHelper = new Helper();
        CMB_BLL BLL = new CMB_BLL();


        int _typeid = 0;
        public int TypeId
        {
            get { return _typeid; }
            set { _typeid = value; }
        }

        public int RowIndex = 0;
        public int ColumnIndex = 0;
        public string ColumnName = "";
        public string CellValue = "";

        public string HeaderText
        {
            get { return kryptonHeaderGroup1.ValuesPrimary.Heading; }
            set { kryptonHeaderGroup1.ValuesPrimary.Heading = value; }
        }

        #endregion

        #region Methods

        public void FillList(int _typeid)
        {
            var data = CMB_BLL.getTypeSpecificationsAll(TypeId);


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

            frm.HeaderText = "Select view for specification list";
            frm.grid = this.gv_List;
            frm.formname = this.Name;
            DAL.UserLogin = System.Environment.UserName;
            frm.UserId = DAL.UserId;

            frm.FillData(frm.grid);

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                mMenu.CommitUserColumn(frm.UserId, frm.formname, frm.grid.Name, frm.gvList);
                Helper.LoadColumns(gv_List, this.Name);
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ED.DgvIntoExcel();
        }

        #endregion

        #endregion

        #region Controls

        private void frm_TypeParameters_Load(object sender, EventArgs e)
        {
            Helper.LoadColumns(gv_List, this.Name);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddSpecification frm = new frm_AddSpecification();
            frm.HeaderText = "Add new specification";

            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                BLL.AddSpecification(frm.Specification, frm.TypeOfData, frm.Comments, frm.UnitId);
                FillList(TypeId);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string _spec = "";
            string _comments = "";
            string _typeofdata = "";
            int _unitid = 0;

            try {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_specid"].Value);
                _spec = gv_List.CurrentRow.Cells["cn_specification"].Value.ToString();
                _comments = gv_List.CurrentRow.Cells["cn_speccomments"].Value.ToString();
                _typeofdata = gv_List.CurrentRow.Cells["cn_typeofdata"].Value.ToString();
                _unitid = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_unitid"].Value);
            }
            catch { }

            if (_id != 0)
            {
                frm_AddSpecification frm = new frm_AddSpecification();
                frm.HeaderText = "Edit specification: " + _spec;
                frm.Specification = _spec;
                frm.Comments = _comments;
                frm.TypeOfData = _typeofdata;
                frm.UnitId = _unitid;
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    BLL.EditSpecification(_id, frm.Specification, frm.TypeOfData, frm.Comments, frm.UnitId);
                    FillList(TypeId);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;
           
            try
            {
                _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_specid"].Value);
            }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                BLL.DeleteSpecification(_id);
                FillList(TypeId);                
            }
        }

        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            gv_List.EndEdit();

            DataTable dataspecs = new DataTable();
            dataspecs.Columns.Add("id", typeof(int));
           
            foreach (DataGridViewRow row in gv_List.Rows)
            {
                if (Convert.ToInt32(row.Cells["chk_check"].Value) == -1)
                {
                    DataRow dr = dataspecs.NewRow();
                    dr["id"] = Convert.ToInt32(row.Cells["cn_specid"].Value);
                    
                    dataspecs.Rows.Add(dr);
                }
            }
            BLL.SaveSpecsForType(TypeId, dataspecs);

            this.Close();
        }
    }
}
