using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.LabPrinters
{
    public partial class frm_LabPrinters : Form
    {
        PopupWindowHelper PopupHelper = null;

        cmb_LabPrinter f;
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        DAL_Functions DAL = new DAL_Functions();
        
        bool _showingModal = false;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public frm_LabPrinters()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();
        }

        public frm_LabPrinters(cmb_LabPrinter cmb)
        {
            InitializeComponent();
            f = new cmb_LabPrinter();
            f = cmb;
        }

        private void ChangeCMBElements()
        {
            try
            {
                ((cmb_LabPrinter)cmb_LabPrinterOne).PrinterName = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_LabPrinter)cmb_LabPrinterOne).IP_Adress = gv_List.CurrentRow.Cells["cn_address"].Value.ToString();
            }
            catch
            { }
        }

        public void FillData()
        {
            var data = CMB_BLL.getPrinters(System.Environment.MachineName);

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

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_List.CurrentRow.Cells["cn_default"].Selected == true)
            {
                gv_List.EndEdit();
                Bll.MakeDefaultPinter((Int32)gv_List.CurrentRow.Cells["cn_id"].Value);
                FillData();
            }
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddPrinter popup = new frm_AddPrinter();

            DialogResult result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    _showingModal = false;
                    Bll.AddPrinter(popup.PrinterName, popup.IP_Address, popup.Default);
                }
                catch
                {

                }
            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
            FillData();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddPrinter popup = new frm_AddPrinter();

            popup.Id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value);
            popup.PrinterName = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
            popup.IP_Address = gv_List.CurrentRow.Cells["cn_address"].Value.ToString();
            popup.Default = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_default"].Value);

            DialogResult result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                //try
                //{
                _showingModal = false;
                //MessageBox.Show(popup.Default.ToString());
                Bll.EditPrinter(popup.Id, popup.PrinterName, popup.IP_Address, popup.Default);
                //}
                //catch
                // {

                //}

            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
            FillData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (glob_Class.DeleteConfirm())
            {
                try
                {
                    int id = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                    Bll.DeletePrinter(id);
                }
                catch
                {
                    return;
                }

            }
            FillData();
        }
    }
}
