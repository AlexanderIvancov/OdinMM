using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.Tools
{
    public partial class frm_LabelDesigner : KryptonForm
    {
        public frm_LabelDesigner()
        {
            InitializeComponent();
        }

        #region Variables

        public int TemplateId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }

        PrinterLabels PrintLabels = new PrinterLabels();

        Tools_BLL BLL = new Tools_BLL();

        public string TemplateText
        {
            get { return txt_LabelText.Text; }
            set { txt_LabelText.Text = value; }
        }

        #endregion

        #region Methods

        public void ShowFields(int id)
        {
            var data = Tools_BLL.getLabelFields(id);

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

        public void ShowDets(int id)
        {
            BLL.TempLabelId = id;
            TemplateText = BLL.TempLabelText;
        }

        #endregion

        #region Controls

        private void cmb_Common1_SelectedValueChanged(object sender)
        {
            //MessageBox.Show(TemplateId.ToString());
            ShowDets(TemplateId);
            ShowFields(TemplateId);
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            int _res = BLL.SaveLabelTemplate(TemplateId, TemplateText);

            if (_res == 0)
                KryptonTaskDialog.Show("Saving was unsuccessful!",
                                      "You have no permission to save data!",
                                      "",
                                       MessageBoxIcon.Warning,
                                       TaskDialogButtons.OK);

            ShowFields(TemplateId);
            ShowDets(TemplateId);
        }

        private void btn_Erase_Click(object sender, EventArgs e)
        {
            txt_LabelText.Text = string.Empty;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            frm_Print popup = new frm_Print();
            popup.cmb_LabPrinter1.ShowDefaults();

            DialogResult result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintLabels.PrinterIp = popup.IP_Address;
                PrintLabels.PrinterDPI = popup.Printer_DPI;

                PrintLabels.PrintLabel(TemplateText, popup.LabelQty);

            }
            else
            {

            }

        }

        #endregion

    }
}
