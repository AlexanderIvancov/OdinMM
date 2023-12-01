using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.StockInTypes
{
    public partial class frm_StockMovTypes : KryptonForm
    {
        public frm_StockMovTypes()
        {
            InitializeComponent();
            
        }

        public frm_StockMovTypes(cmb_StockInTypes cmb)
        {
            InitializeComponent();
            f = new cmb_StockInTypes();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
       
        bool _showingModal = false;
        cmb_StockInTypes f;

        CMB_BLL Bll = new CMB_BLL();
        
        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_StockInTypes)cmb_StockInTypeOne).txt_Type.Text = gv_List.CurrentRow.Cells["cn_type"].Value.ToString();
                ((cmb_StockInTypes)cmb_StockInTypeOne).StockMovTypeId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }


        public void FillData(string _beg, string _lang, int _movtype)
        {
            var data = CMB_BLL.getStockDocsTypes(_beg, _lang, _movtype);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
