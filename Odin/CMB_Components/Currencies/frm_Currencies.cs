using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;


namespace Odin.CMB_Components.Currencies
{
    public partial class frm_Currencies : KryptonForm
    {



        public frm_Currencies()
        {
            InitializeComponent();
            //ControlBox = false;
            //Text = "";
        }

        public frm_Currencies(cmb_Currency cmb)
        {
            InitializeComponent();
            f = new cmb_Currency();
            cmb = f;
        }



        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Currency f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }


        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Currency)cmb_CurrencyOne).txt_Currency.Text = gv_List.CurrentRow.Cells["cn_currency"].Value.ToString();
                ((cmb_Currency)cmb_CurrencyOne).CurrencyId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void ChangeCMBElements(object sender)
        {
            try
            {
                ((cmb_Currency)cmb_CurrencyOne).txt_Currency.Text = gv_List.CurrentRow.Cells["cn_currency"].Value.ToString();
                ((cmb_Currency)cmb_CurrencyOne).CurrencyId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void UpdateCurRate(object sender)
        {
            ((cmb_Currency)cmb_CurrencyOne).UpdateCurRate();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddCurrency frm = new frm_AddCurrency();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddCurrency(frm.Currency, frm.Description, frm.Symbol);
                FillData(frm.Currency);
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
                frm_AddCurrency frm = new frm_AddCurrency();
                frm.Id = _id;
                frm.Currency = gv_List.CurrentRow.Cells["cn_currency"].Value.ToString();
                frm.Description = gv_List.CurrentRow.Cells["cn_description"].Value.ToString();
                frm.Symbol = gv_List.CurrentRow.Cells["cn_symbol"].Value.ToString();


                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditCurrency(frm.Id, frm.Currency, frm.Description, frm.Symbol);
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
                Bll.DeleteCurrency(_id);
                FillData(string.Empty);
            }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getCurrencies(Beg);

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

        private void btn_CurRate_Click(object sender, EventArgs e)
        {
            frm_CurRates frm = new frm_CurRates();
            frm.CurID = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            frm.Show();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            frm_ImportCurRate frm = new frm_ImportCurRate();
            frm.RateSaving += new CurRateSavingEventHandler(UpdateCurRate);
            frm.Show();
        }
    }

}
