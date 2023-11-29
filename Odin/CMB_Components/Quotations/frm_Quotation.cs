using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using Odin.Sales;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Quotations
{
    public partial class frm_Quotation : KryptonForm
    {
        public frm_Quotation()
        {
            InitializeComponent();
        }
        public frm_Quotation(cmb_Quotations cmb)
        {
            InitializeComponent();
            f = new cmb_Quotations();
            cmb = f;
        }

        frm_AddQuotation frm = null;

        CO_BLL COBll = new CO_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Quotations f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Quotations)cmb_QuotationOne).txt_Quotation.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_Quotations)cmb_QuotationOne).QuotationId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }


        public void FillData(string Beg)
        {
            var data = CMB_BLL.getQuotations(Beg);

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

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (glob_Class.IsFormAlreadyOpen("frm_AddQuotation")) return;

            frm = new frm_AddQuotation();
            frm.ctl_QuotDets1.QuotId = 0;
            frm.ctl_QuotDets1.FillAutoDoc(10);
            frm.ctl_QuotDets1.StateId = 1;
            frm.ctl_QuotDets1.ReqDateD = System.DateTime.Now;
            //frm.ctl_QuotDets1.Week = "W" + frm.ctl_QuotDets1.cmb_Week1.WeekNumber(System.DateTime.Now).ToString() + "/" + System.DateTime.Now.Year.ToString();


            frm.QuotationSaved += new QuotationSavedEventHandler(AddQuotation);

            frm.Show();
        }

        public void AddQuotation(object sender)
        {
            if (frm.ctl_QuotDets1.QuotId != 0)
            {
                _showingModal = false;
                FillData(frm.ctl_QuotDets1.Quotation);
                ((cmb_Quotations)cmb_QuotationOne).QuotationId = frm.ctl_QuotDets1.QuotId;
                ((cmb_Quotations)cmb_QuotationOne).QuotationSendSave();
                frm.Close();

            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int _id = 0;
            try { _id = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value; }
            catch { }


            if (_id != 0)
            {
                //if (globClass.IsFormAlreadyOpen("frm_AddQuotation")) return;

                COBll.QuotId = _id;
                frm = new frm_AddQuotation();
                frm.ctl_QuotDets1.QuotId = _id;

                frm.QuotationSaved += new QuotationSavedEventHandler(AddQuotation);

                frm.Show();

            }
        }
    }
}
