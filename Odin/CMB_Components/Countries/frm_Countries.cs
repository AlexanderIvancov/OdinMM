using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;


namespace Odin.CMB_Components.Countries
{
    public partial class frm_Countries : KryptonForm
    {
        


        public frm_Countries()
        {
            InitializeComponent();
            //ControlBox = false;
            //Text = "";
        }

        public frm_Countries(cmb_Countries cmb)
        {
            InitializeComponent();
            f = new cmb_Countries();
            cmb = f;
        }

        

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Countries f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
       
                
        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Countries)cmb_CountryOne).txt_Country.Text = gv_List.CurrentRow.Cells["cn_country"].Value.ToString();
                ((cmb_Countries)cmb_CountryOne).CountryId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddCountry frm = new frm_AddCountry();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Convert.ToInt32(Helper.getSP("sp_AddCountry", frm.Country, frm.Abbrev, frm.CurId, frm.VAT, frm.EU));
                FillData(frm.Country);
            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                frm_AddCountry frm = new frm_AddCountry();
                frm.Id = _id;
                frm.Country = gv_List.CurrentRow.Cells["cn_country"].Value.ToString();
                frm.Abbrev = gv_List.CurrentRow.Cells["cn_shortname"].Value.ToString();
                frm.EU = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_eurozone"].Value.ToString());
                frm.VAT = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_vat"].Value.ToString());
                frm.CurId = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_currency"].Value.ToString());

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Helper.getSP("sp_EditCountry", frm.Id, frm.Country, frm.Abbrev, frm.CurId, frm.VAT, frm.EU);//Bll.EditUnit(frm.Id, frm.Unit, frm.Description, frm.UnitDecs);
                    FillData(frm.Country);    
                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (glob_Class.DeleteConfirm() == true)
            {
                Helper.getSP("sp_DeleteCountry", _id);
                FillData(string.Empty);
            }
        }

        public void FillData(string Beg)
        {
            var data = (System.Data.DataTable)Helper.getSP("sp_CountrySelectLike", Beg);

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
