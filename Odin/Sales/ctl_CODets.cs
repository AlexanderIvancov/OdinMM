using Odin.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;
namespace Odin.Sales
{
    public delegate void COIdSendingEventHandler(object sender);

    public partial class ctl_CODets : UserControl
    {
        public ctl_CODets()
        {
            InitializeComponent();
            frm_ClientOrders.ReceiveId += new ReceiveCOId(RetCOId);
        }

        #region Variables

        class_Global globClass = new class_Global();
        DAL_Functions DLL = new DAL_Functions();

        public event COIdSendingEventHandler SendCOId;

        public int RetCOId()
        {
            return COId;
        }

        CO_BLL COBll = new CO_BLL();

        public int COHeadId
        {
            get { return cmb_SalesOrders1.SalesOrderId; }
            set { cmb_SalesOrders1.SalesOrderId = value; }
        }

        public int COLine
        {
            get
            {
                try { return Convert.ToInt16(txt_Line.Text); }
                catch { return 0; }
            }
            set { txt_Line.Text = value.ToString();}
        }
        public int COArtId
        {
            get { return cmb_Articles1.ArticleId; }

            set { cmb_Articles1.ArticleId = value; }
        }
        public int COService
        {
            get {
                return chk_Service.CheckState == CheckState.Checked ? -1 : 0;
            }
            set { chk_Service.Checked = value == -1;
            }
        }
        public int COBlocked
        {
            get
            {
                return chk_blockdelivery.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_blockdelivery.Checked = value == -1;
            }
        }
        public string COCustOrder
        {
            get { return txt_CustOrder.Text; }
            set { txt_CustOrder.Text = value; }
        }
        public string COCustLine
        {
            get { return txt_CustLine.Text; }
            set { txt_CustLine.Text = value; }
        }
        public string COPurOrder
        {
            get; set;
        }

        public string COPurLine
        {
            get; set;
        }

        public string COCustArticle
        {
            get { return txt_CustArticle.Text; }
            set { txt_CustArticle.Text = value; }
        }

        public double COQty
        {
            get { try { return Convert.ToDouble(txt_Qty.Text); }
                catch { return 0; }
            }
            set { txt_Qty.Text = value.ToString(); }
        }
        public double COSpoilage
        {
            get
            {
                try { return Convert.ToDouble(txt_Spoilage.Text); }
                catch { return 0; }
            }
            set { txt_Spoilage.Text = value.ToString(); }
        }

        public int COUnitId
        {
            get { return cmb_Units1.UnitId; }
            set { cmb_Units1.UnitId = value; }
        }
        public double COUnitPrice
        {
            get
            {
                try { return Convert.ToDouble(txt_UnitPrice.Text); }
                catch { return 0; }
            }
            set { txt_UnitPrice.Text = value.ToString(); }
        }
        
        public double COVat
        {
            get
            {
                try { return Convert.ToDouble(txt_VAT.Text); }
                catch { return 0; }
            }
            set { txt_VAT.Text = value.ToString(); }
        }
        public int COStateId
        {
            get { return cmb_Common1.SelectedValue; }
            set { cmb_Common1.SelectedValue = value; }
        }
        public string COComments
        {
            get { return txt_Comments.Text; }
            set { txt_Comments.Text = value;}
        }
        public string COComments1
        {
            get { return txt_Comments1.Text; }
            set { txt_Comments1.Text = value; }
        }
        public string COLogComments
        {
            get { return txt_LogComments.Text; }
            set { txt_LogComments.Text = value; }
        }

        public string COSalesComments
        {
            get { return txt_SalesComments.Text; }
            set { txt_SalesComments.Text = value; }
        }

        public int CODelivPlaceId
        {
            get { return cmb_Firms1.FirmId; }
            set { cmb_Firms1.FirmId = value; }
        }
        public int CODelivAddressId
        {
            get { return cmb_Address1.AddressId; }
            set { cmb_Address1.AddressId = value; }
        }

        public string COReqDate
        {
            get { return txt_ReqDate.Value.ToShortDateString(); }
            set {
                try { txt_ReqDate.Value = Convert.ToDateTime(value); }
                catch { }
            }
        }

        public string EndCustOrder
        {
            get; set;
        }
        public string COEndCustRef
        {
            get; set;
        }
        public string COEndCustReqDate
        {
            get; set;
        }
        public string COCreatAt
        {
            get { return txt_CreatAt.Text; }
            set { txt_CreatAt.Text = value; }
        }
        public string COCreatBy
        {
            get { return txt_CreatBy.Text; }
            set { txt_CreatBy.Text = value; }
        }
        public int COInternal
        {
            get
            {
                return chk_internal.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_internal.Checked = value == -1;
            }
        }
        public int COResale
        {
            get
            {
                return chk_resale.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_resale.Checked = value == -1;
            }
        }

        public int COPrimary
        {
            get
            {
                return chk_primary.CheckState == CheckState.Checked ? -1 : 0;
            }
            set
            {
                chk_primary.Checked = value == -1;
            }
        }

        public double COQtyInBatch
        {
            get;set;
        }
        public int COEndCustId
        {
            get { return cmb_EndCustomer1.FirmId; }
            set { cmb_EndCustomer1.FirmId = value; }
        }
        public void ClearCODets()
        {
            COArtId = 0;
            COComments1 = "";
            COComments = "";
            COCreatAt = "";
            COCreatBy = "";
            COCustArticle = "";
            COCustLine = "";
            COCustOrder = "";
            CODelivAddressId = 0;
            CODelivPlaceId = 0;
            COEndCustId = 0;
            COEndCustRef = "";
            COEndCustReqDate = "";
            COLine = 0;
            COLogComments = "";
            COPurLine = "";
            COPurOrder = "";
            COQty = 0;
            COService = 0;
            COStateId = 0;
            COUnitId = 0;
            COUnitPrice = 0;
            COVat = 0;
            COReqDate = "";
            COInternal = 0;
            COResale = 0;
            COSpoilage = 0;
            COQtyInBatch = 0;
            COBlocked = 0;
            COSalesComments = "";
        }

        public void ShowSaveButton(bool _show)
        {
            btn_OK.Visible = _show;
        }

        public void FillAddress(int id)
        {
            cmb_Address1.FirmId = id;
        }

        public void FillStages(int id)
        {
            var data = CO_BLL.getCOStages(id);

            gv_List.ThreadSafeCall(delegate
            {
                gv_List.AutoGenerateColumns = false;
                bs_List.DataSource = data;
                gv_List.DataSource = bs_List;

            });
        }

        int _iscopy = 0;

        public int IsCopy
        {
            get { return _iscopy; }
            set { _iscopy = value; }
        }

        #endregion

        int _coid = 0;
        public int COId
        {
            get { return _coid; }
            set { _coid = value;

                CO_BLL COBll = new CO_BLL();

                COBll.COId = _coid;

                //COHeadId = COBll.COHeadId1;
                COArtId = COBll.COArtId;
                COComments =  COBll.COComments;
                COComments1 = COBll.COComments1;
                COCreatAt = COBll.COCreatAt;
                COCreatBy = COBll.COCreatBy;
                COCustArticle = COBll.COCustArticle;
                COCustLine = COBll.COCustLine;
                COCustOrder = COBll.COCustOrder;
                CODelivAddressId = COBll.CODelivAddressId;
                CODelivPlaceId = COBll.CODelivPlaceId;
                COEndCustId = COBll.COEndCustId;
                COEndCustRef = COBll.COEndCustRef;
                COEndCustReqDate = COBll.COEndCustReqDate;
                COLine = COBll.COLine;
                COLogComments = COBll.COLogComments;
                COPurLine = COBll.COPurLine;
                COPurOrder = COBll.COPurOrder;
                COQty = COBll.COQty;
                COReqDate = COBll.COReqDate;
                COService = COBll.COService;
                COStateId = COBll.COStateId;
                COUnitId = COBll.COUnitId;
                COUnitPrice = COBll.COUnitPrice;
                COVat = COBll.COVat;
                COInternal = COBll.COInternal;
                COResale = COBll.COResale;
                COSpoilage = COBll.COSpoilageQty;
                COQtyInBatch = COBll.COQtyInBatch;
                COBlocked = COBll.COBlocked;
                COSalesComments = COBll.COSalesComments;
                COPrimary = COBll.COPrimary;

                FillStages(_coid);

                if (IsCopy == -1)
                {
                    _coid = 0;
                }
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            txt_CustArticle.Text = string.Empty;
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txt_CustLine.Text = string.Empty;
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txt_CustOrder.Text = string.Empty;
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            txt_Comments.Text = string.Empty;
        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {
            txt_Comments1.Text = string.Empty;
        }

        private void buttonSpecAny6_Click(object sender, EventArgs e)
        {
            txt_LogComments.Text = string.Empty;
        }

        private void cmb_Firms1_FirmsChanged(object sender)
        {
            cmb_Address1.FirmId = cmb_Firms1.FirmId;
        }

        private void cmb_Articles1_ArticleChanged(object sender)
        {
            cmb_Units1.UnitId = cmb_Articles1.UnitId;
            COCustArticle = cmb_Articles1.SecName;
            COInternal = cmb_Articles1.IsPF;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(COEndCustId.ToString());
            gv_List.EndEdit();
            int NewLineId = 0;

            if (DLL.CheckArtId(COArtId) != 0
                 /*&& frm.ctl_CODets1.COQty != 0
                  *&& frm.ctl_CODets1.COUnitPrice != 0*/)
            {
                DataTable datastages = new DataTable();
                datastages.Columns.Add("id", typeof(int));
                datastages.Columns.Add("osid", typeof(int));
                datastages.Columns.Add("checked", typeof(int));

                foreach (DataGridViewRow row in this.gv_List.Rows)
                {
                    DataRow dr = datastages.NewRow();
                    dr["id"] = Convert.ToInt32(row.Cells["cn_id"].Value);

                    dr["osid"] = IsCopy == -1 ? 0 : (object)Convert.ToInt32(row.Cells["cn_osid"].Value);

                    dr["checked"] = Convert.ToInt32(row.Cells["chk_checked"].Value);
                    datastages.Rows.Add(dr);
                    
                }


                NewLineId = COBll.SaveCOLine(COId, COHeadId, COLine, COCustOrder, COCustLine, "", "", COArtId, COCustArticle, COService, COQty,
                                            COUnitId, COReqDate, COStateId, COUnitPrice, COVat, COComments, COComments1,
                                            COLogComments, CODelivPlaceId, CODelivAddressId, COEndCustId, "", "", "", datastages, COInternal, 
                                            COResale, COSpoilage, COBlocked, COSalesComments, COPrimary);

               
            }

            //Event
            if (SendCOId != null)
            {
                SendCOId(this);
            }

        }

        private void txt_Qty_Validated(object sender, EventArgs e)
        {
            if (COId != 0
                && COQtyInBatch > COQty)
            {
                //COQty = COQtyInBatch;
            }
        }
    }
}
