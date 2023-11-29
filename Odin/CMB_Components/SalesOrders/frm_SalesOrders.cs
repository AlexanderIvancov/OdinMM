using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;
using ComponentFactory.Krypton.Toolkit;
using Odin.Global_Classes;
using Odin.CMB_Components.BLL;
using Odin.Sales;

namespace Odin.CMB_Components.SalesOrders
{
    public partial class frm_SalesOrders : KryptonForm
    {
        public frm_SalesOrders()
        {
            InitializeComponent();
        }

        public frm_SalesOrders(cmb_SalesOrders cmb)
        {
            InitializeComponent();
            f = new cmb_SalesOrders();
            cmb = f;
        }


        int _Type = 0;

        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        CO_BLL COBll = new CO_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_SalesOrders f;

        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }

        public void ChangeCMBElements()
        {
            try
            {
                if (Type == 0)
                {
                    ((cmb_SalesOrders)cmb_SalesOrderOne).txt_SalesOrder.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                    ((cmb_SalesOrders)cmb_SalesOrderOne).SalesOrderId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                }
                else
                {
                    ((cmb_SalesOrdersWithLines)cmb_SalesOrderWithLineOne).txt_SalesOrder.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                    ((cmb_SalesOrdersWithLines)cmb_SalesOrderWithLineOne).SalesOrderId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                }
            }
            catch { }
        }

        public void SendSaveEvent()
        {

        }

        public void FillData(string Beg)
        {
            gv_List.ThreadSafeCall(delegate
            {
                var data = CMB_BLL.getSalesOrders(Beg);

                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;
            });

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddSalesOrder frm = new frm_AddSalesOrder();
            
            frm.FillAutoDoc(1);
            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = COBll.AddSalesOrderHead(frm.CustId, frm.ContPersId, frm.Comments, frm.Contract, frm.CurId, frm.IncotermsId);
                FillData(frm.SalesOrder);
                ((cmb_SalesOrders)cmb_SalesOrderOne).SalesOrdersSendSave();
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
                frm_AddSalesOrder frm = new frm_AddSalesOrder();

                COBll.COHeadId = _id;
                frm.SalesOrder = COBll.COHeader;
                frm.CustId = COBll.COHeadCustId;
                frm.ContPersId = COBll.COHeadContPersId;
                frm.Comments = COBll.COHeadComments;
                frm.Contract = COBll.COHeadContract;
                frm.IncotermsId = COBll.COHeadIncoterms;
                frm.CurId = COBll.COHeadCurId;

                frm.CheckEmpty();
                
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    COBll.EditSalesOrderHead(_id, frm.CustId, frm.ContPersId, frm.Comments, frm.Contract, frm.CurId, frm.IncotermsId);
                    FillData(frm.SalesOrder);
                }
                if (result == DialogResult.Cancel)
                {
                    _showingModal = false;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                COBll.DeleteSalesOrderHead(_id);
                FillData(string.Empty);
                ((cmb_SalesOrders)cmb_SalesOrderOne).SalesOrdersSendSave();
            }

            _showingModal = false;
        }
        private void gv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void gv_List_SelectionChanged(object sender, EventArgs e)
        {
            ChangeCMBElements();
        }
    }
}
