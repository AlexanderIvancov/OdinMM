using ComponentFactory.Krypton.Toolkit;
using Odin.CMB_Components.BLL;
using Odin.Global_Classes;
using System;
using System.Windows.Forms;

namespace Odin.CMB_Components.Transport
{
    public partial class frm_Transport : KryptonForm
    {
        public frm_Transport()
        {
            InitializeComponent();
        }

        public frm_Transport(cmb_Transport cmb)
        {
            InitializeComponent();
            f = new cmb_Transport();
            cmb = f;
        }

        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_Transport f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }


        public void ChangeCMBElements()
        {
            try
            {
                ((cmb_Transport)cmb_TransportOne).txt_Transport.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                ((cmb_Transport)cmb_TransportOne).TransportId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
            }
            catch { }
        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getTransport(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;
            frm_AddTransport frm = new frm_AddTransport();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = Bll.AddTransport(frm.Transport, frm.IntrastatCode, frm.TransType);
                FillData(frm.Transport);
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
                frm_AddTransport frm = new frm_AddTransport();
                frm.Id = _id;
                Bll.TransportId = _id;
                frm.Transport = Bll.Transport;
                frm.IntrastatCode = Bll.TransportIntrastat;
                frm.TransType = Bll.TransType;

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    Bll.EditTransport(frm.Id, frm.Transport, frm.IntrastatCode, frm.TransType);
                    FillData(frm.Transport);
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
                Bll.DeleteTransport(_id);
                FillData(string.Empty);
            }
        }
    }
}
