﻿using System;
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
using Odin.Purchase;

namespace Odin.CMB_Components.PurchaseOrders
{
   

    public partial class frm_PurchaseOrders : KryptonForm
    {
        public frm_PurchaseOrders()
        {
            InitializeComponent();
        }
        
        public frm_PurchaseOrders(cmb_PurchaseOrders cmb)
        {
            InitializeComponent();
            f = new cmb_PurchaseOrders();
            cmb = f;
        }


        int _Type = 0;

        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        PO_BLL POBll = new PO_BLL();
        DAL_Functions Dll = new DAL_Functions();
        class_Global glob_Class = new class_Global();
        CMB_BLL Bll = new CMB_BLL();
        bool _showingModal = false;
        cmb_PurchaseOrders f;

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
                    ((cmb_PurchaseOrders)cmb_PurchaseOrderOne).txt_PurchaseOrder.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                    ((cmb_PurchaseOrders)cmb_PurchaseOrderOne).PurchaseOrderId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                }
                else if (Type == 1)
                {
                    //((cmb_PurchaseOrdersWithLines)cmb_PurchaseOrderWithLineOne).txt_PurchaseOrder.Text = gv_List.CurrentRow.Cells["cn_name"].Value.ToString();
                    ((cmb_PurchaseOrdersWithLines)cmb_PurchaseOrderWithLineOne).PurchaseOrderId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                }
                else
                {
                    ((cmb_PurchaseOrdersLines)cmb_PurchaseOrderLinesOne).PurchaseOrderId = (Int32)gv_List.CurrentRow.Cells["cn_id"].Value;
                }
            }
            catch { }
        }

        public void SendSaveEvent()
        {

        }

        public void FillData(string Beg)
        {
            var data = CMB_BLL.getPurchaseOrders(Beg);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        public void FillDataEnabledArticles(string Beg, int ArticleId)
        {
            var data = CMB_BLL.getPurchaseOrdersEnabledArticles(Beg, ArticleId);

            gv_List.AutoGenerateColumns = false;
            bs_List.DataSource = data;
            gv_List.DataSource = bs_List;

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            _showingModal = true;

            frm_AddPurchaseOrder frm = new frm_AddPurchaseOrder();

            frm.FillAutoDoc(2);
            frm.CheckEmpty();

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _showingModal = false;
                int _res = POBll.AddPurchaseOrderHead(frm.SupId, frm.ContPersId, frm.Comments, frm.Contract, frm.CurId, 
                                                    frm.IncotermsId, frm.DelivPlaceId, frm.DelivAddressId, frm.InProcess);
                FillData(frm.PurchaseOrder);
                ((cmb_PurchaseOrders)cmb_PurchaseOrderOne).PurchaseOrdersSendSave();
            }
            if (result == DialogResult.Cancel)
            {
                _showingModal = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
           

            int _id = 0;

            try { _id = Convert.ToInt32(gv_List.CurrentRow.Cells["cn_id"].Value); }
            catch { }

            if (_id != 0)
            {
                _showingModal = true;

                frm_AddPurchaseOrder frm = new frm_AddPurchaseOrder();

                POBll.POHeadId = _id;
                frm.SupId = POBll.POHeadSupId;
                frm.ContPersId = POBll.POHeadContPersId;
                frm.Comments = POBll.POHeadComments;
                frm.Contract = POBll.POHeadContract;
                frm.IncotermsId = POBll.POHeadIncoterms;
                frm.CurId = POBll.POHeadCurId;
                frm.DelivPlaceId = POBll.POHeadDelivPlaceId;
                frm.DelivAddressId = POBll.POHeadDelivAddressId;
                frm.InProcess = POBll.POHeadProcessing;

                frm.CheckEmpty();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _showingModal = false;
                    POBll.EditPurchaseOrderHead(_id, frm.SupId, frm.ContPersId, frm.Comments, frm.Contract, 
                                                frm.CurId, frm.IncotermsId, frm.DelivPlaceId, frm.DelivAddressId,
                                                frm.InProcess);
                    FillData(frm.PurchaseOrder);
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

            if (_id != 0
                && glob_Class.DeleteConfirm() == true)
            {
                POBll.DeletePurchaseOrderHead(_id);
                FillData(string.Empty);
            }
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