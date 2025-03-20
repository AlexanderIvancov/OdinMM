namespace Odin.Warehouse.History
{
    partial class frm_StockHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Main _Main;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnu_IncomeLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForI = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchI = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByI = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelI = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterI = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminI = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.mnu_OutcomeLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForO = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchO = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByO = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelO = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterO = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyO = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminO = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_MovementLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForM = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchM = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByM = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelM = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterM = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TracingLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForT = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByT = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelT = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterT = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminT = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_TracingList = new System.Windows.Forms.BindingSource(this.components);
            this.mnu_CostLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForC = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchC = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByC = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterC = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminC = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.mnu_ReturnsLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForR = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchR = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByR = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelR = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterR = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyR = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminR = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.chk_Summary = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_groupbybatch = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cmb_IncomeDoc1 = new Odin.CMB_Components.IncomeDocs.cmb_IncomeDoc();
            this.cmb_OutcomeDocs1 = new Odin.CMB_Components.OutcomeDocs.cmb_OutcomeDocs();
            this.lbl_Document = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_MoveDocs1 = new Odin.CMB_Components.MoveDocs.cmb_MoveDocs();
            this.lbl_SalesOrders = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_SalesOrders1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrders();
            this.cmb_Operation = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbl_FirmsArt = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_FirmArt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lbl_PlaceTo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Places2 = new Odin.CMB_Components.Places.cmb_Places();
            this.lbl_Place = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Places1 = new Odin.CMB_Components.Places.cmb_Places();
            this.lbl_Operation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.txt_DateTill = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_DateFrom = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lbl_Article = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.lbl_Till = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_From = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Period = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Type = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Types1 = new Odin.CMB_Components.Types.cmb_Types();
            this.lbl_Supplier = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Firms1 = new Odin.CMB_Components.Companies.cmb_Firms();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dn_Pages = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.pg_Incomes = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_IncomeList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_regdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_docdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_supart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_itype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ioperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_supid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coefconv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totalvat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totalwithvat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitpriceeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totaleur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totalvateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_totalwithvateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pcesperunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_icountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_IncomeList = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcelI = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Rests = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_PO = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Tracing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pg_Withdraw = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_OutcomeList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_oid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oheadid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_odelivdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_odocdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocustarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_otype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ooperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ounit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ounitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_obatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_orequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocustorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocustcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocreatat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocreatby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_countryoforigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_writeoffreason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_olabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_osecname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_olaunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_incomedoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_incomedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_datacode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_manufbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_OutcomeList = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcelO = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalOutcomes = new Owf.Controls.NumericTetxBox();
            this.kryptonButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pg_Movements = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_MovementList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_mfromlabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mtolabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mdocdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_martid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_marticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_moperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_munit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_munitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mplacefrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mPlaceto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mcreatedat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_mcountryoforigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_MovementList = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcelM = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalMovements = new Owf.Controls.NumericTetxBox();
            this.kryptonButton8 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pg_Returns = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_ReturnsList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_rid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rlabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_runit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_runitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rcreatedat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rcreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rdocdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rcountryoforigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_operationin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_ReturnsList = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcelR = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TotalReturns = new Owf.Controls.NumericTetxBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pg_Tracing = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_TracingList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_TracingList = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcelT = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Label = new Owf.Controls.NumericTetxBox();
            this.pg_Cost = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.gv_CostList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_cartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_carticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_cqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_cunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_cunitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_csupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_csuparticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_cdelivnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_clabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isreturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_setdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_crequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ccustcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_awaitingcost2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_bomcost1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chk_ExcludeA = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_COPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_BOMCost = new Owf.Controls.NumericTetxBox();
            this.txt_COPrice = new Owf.Controls.NumericTetxBox();
            this.chk_GroupByDoc = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Total = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyIn = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CostPrice = new Owf.Controls.NumericTetxBox();
            this.bn_CostList = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_ExcelC = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.btn_BOMDetails = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_AwaitingCost1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_showcostdets = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_AwaitingCost = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.bs_IncomeList = new Odin.Global_Classes.SyncBindingSource();
            this.bs_OutcomeList = new Odin.Global_Classes.SyncBindingSource();
            this.bs_MovementList = new Odin.Global_Classes.SyncBindingSource();
            this.bs_CostList = new Odin.Global_Classes.SyncBindingSource();
            this.bs_ReturnsList = new Odin.Global_Classes.SyncBindingSource();
            this.mnu_IncomeLines.SuspendLayout();
            this.mnu_OutcomeLines.SuspendLayout();
            this.mnu_MovementLines.SuspendLayout();
            this.mnu_TracingLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TracingList)).BeginInit();
            this.mnu_CostLines.SuspendLayout();
            this.mnu_ReturnsLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Operation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dn_Pages)).BeginInit();
            this.dn_Pages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Incomes)).BeginInit();
            this.pg_Incomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_IncomeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_IncomeList)).BeginInit();
            this.bn_IncomeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Withdraw)).BeginInit();
            this.pg_Withdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_OutcomeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_OutcomeList)).BeginInit();
            this.bn_OutcomeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Movements)).BeginInit();
            this.pg_Movements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MovementList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_MovementList)).BeginInit();
            this.bn_MovementList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Returns)).BeginInit();
            this.pg_Returns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ReturnsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_ReturnsList)).BeginInit();
            this.bn_ReturnsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Tracing)).BeginInit();
            this.pg_Tracing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TracingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_TracingList)).BeginInit();
            this.bn_TracingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Cost)).BeginInit();
            this.pg_Cost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CostList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_CostList)).BeginInit();
            this.bn_CostList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_IncomeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OutcomeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MovementList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CostList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ReturnsList)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu_IncomeLines
            // 
            this.mnu_IncomeLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_IncomeLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForI,
            this.mni_SearchI,
            this.mni_FilterByI,
            this.mni_FilterExcludingSelI,
            this.mni_RemoveFilterI,
            this.mni_CopyI,
            this.toolStripSeparator2,
            this.mni_AdminI});
            this.mnu_IncomeLines.Name = "mnu_Requests";
            this.mnu_IncomeLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_IncomeLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesI_Opening);
            // 
            // mni_FilterForI
            // 
            this.mni_FilterForI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForI.Name = "mni_FilterForI";
            this.mni_FilterForI.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForI.TextChanged += new System.EventHandler(this.mni_FilterForI_TextChanged);
            // 
            // mni_SearchI
            // 
            this.mni_SearchI.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchI.Name = "mni_SearchI";
            this.mni_SearchI.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchI.Text = "Search for record";
            this.mni_SearchI.Click += new System.EventHandler(this.mni_SearchI_Click);
            // 
            // mni_FilterByI
            // 
            this.mni_FilterByI.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByI.Name = "mni_FilterByI";
            this.mni_FilterByI.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByI.Text = "Filter by selection";
            this.mni_FilterByI.Click += new System.EventHandler(this.mni_FilterByI_Click);
            // 
            // mni_FilterExcludingSelI
            // 
            this.mni_FilterExcludingSelI.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelI.Name = "mni_FilterExcludingSelI";
            this.mni_FilterExcludingSelI.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelI.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelI.Click += new System.EventHandler(this.mni_FilterExcludingSelI_Click);
            // 
            // mni_RemoveFilterI
            // 
            this.mni_RemoveFilterI.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterI.Name = "mni_RemoveFilterI";
            this.mni_RemoveFilterI.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterI.Text = "Remove filter";
            this.mni_RemoveFilterI.Click += new System.EventHandler(this.mni_RemoveFilterI_Click);
            // 
            // mni_CopyI
            // 
            this.mni_CopyI.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyI.Name = "mni_CopyI";
            this.mni_CopyI.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyI.Text = "Copy";
            this.mni_CopyI.Click += new System.EventHandler(this.mni_CopyI_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminI
            // 
            this.mni_AdminI.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminI.Name = "mni_AdminI";
            this.mni_AdminI.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminI.Text = "List settings";
            this.mni_AdminI.Click += new System.EventHandler(this.mni_AdminI_Click);
            // 
            // kryptonDockingManager1
            // 
            this.kryptonDockingManager1.DefaultCloseRequest = ComponentFactory.Krypton.Docking.DockingCloseRequest.RemovePageAndDispose;
            this.kryptonDockingManager1.DockspaceAdding += new System.EventHandler<ComponentFactory.Krypton.Docking.DockspaceEventArgs>(this.kryptonDockingManager1_DockspaceAdding);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "document_plain.png");
            this.imageListSmall.Images.SetKeyName(1, "preferences.png");
            this.imageListSmall.Images.SetKeyName(2, "information2.png");
            // 
            // mnu_OutcomeLines
            // 
            this.mnu_OutcomeLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_OutcomeLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForO,
            this.mni_SearchO,
            this.mni_FilterByO,
            this.mni_FilterExcludingSelO,
            this.mni_RemoveFilterO,
            this.mni_CopyO,
            this.toolStripSeparator1,
            this.mni_AdminO});
            this.mnu_OutcomeLines.Name = "mnu_Requests";
            this.mnu_OutcomeLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_OutcomeLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesO_Opening);
            // 
            // mni_FilterForO
            // 
            this.mni_FilterForO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForO.Name = "mni_FilterForO";
            this.mni_FilterForO.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForO.TextChanged += new System.EventHandler(this.mni_FilterForO_TextChanged);
            // 
            // mni_SearchO
            // 
            this.mni_SearchO.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchO.Name = "mni_SearchO";
            this.mni_SearchO.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchO.Text = "Search for record";
            this.mni_SearchO.Click += new System.EventHandler(this.mni_SearchO_Click);
            // 
            // mni_FilterByO
            // 
            this.mni_FilterByO.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByO.Name = "mni_FilterByO";
            this.mni_FilterByO.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByO.Text = "Filter by selection";
            this.mni_FilterByO.Click += new System.EventHandler(this.mni_FilterByO_Click);
            // 
            // mni_FilterExcludingSelO
            // 
            this.mni_FilterExcludingSelO.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelO.Name = "mni_FilterExcludingSelO";
            this.mni_FilterExcludingSelO.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelO.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelO.Click += new System.EventHandler(this.mni_FilterExcludingSelO_Click);
            // 
            // mni_RemoveFilterO
            // 
            this.mni_RemoveFilterO.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterO.Name = "mni_RemoveFilterO";
            this.mni_RemoveFilterO.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterO.Text = "Remove filter";
            this.mni_RemoveFilterO.Click += new System.EventHandler(this.mni_RemoveFilterO_Click);
            // 
            // mni_CopyO
            // 
            this.mni_CopyO.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyO.Name = "mni_CopyO";
            this.mni_CopyO.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyO.Text = "Copy";
            this.mni_CopyO.Click += new System.EventHandler(this.mni_CopyO_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminO
            // 
            this.mni_AdminO.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminO.Name = "mni_AdminO";
            this.mni_AdminO.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminO.Text = "List settings";
            this.mni_AdminO.Click += new System.EventHandler(this.mni_AdminO_Click);
            // 
            // mnu_MovementLines
            // 
            this.mnu_MovementLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_MovementLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForM,
            this.mni_SearchM,
            this.mni_FilterByM,
            this.mni_FilterExcludingSelM,
            this.mni_RemoveFilterM,
            this.mni_CopyM,
            this.toolStripSeparator3,
            this.mni_AdminM});
            this.mnu_MovementLines.Name = "mnu_Requests";
            this.mnu_MovementLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_MovementLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesM_Opening);
            // 
            // mni_FilterForM
            // 
            this.mni_FilterForM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForM.Name = "mni_FilterForM";
            this.mni_FilterForM.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForM.TextChanged += new System.EventHandler(this.mni_FilterForM_TextChanged);
            // 
            // mni_SearchM
            // 
            this.mni_SearchM.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchM.Name = "mni_SearchM";
            this.mni_SearchM.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchM.Text = "Search for record";
            // 
            // mni_FilterByM
            // 
            this.mni_FilterByM.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByM.Name = "mni_FilterByM";
            this.mni_FilterByM.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByM.Text = "Filter by selection";
            this.mni_FilterByM.Click += new System.EventHandler(this.mni_FilterByM_Click);
            // 
            // mni_FilterExcludingSelM
            // 
            this.mni_FilterExcludingSelM.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelM.Name = "mni_FilterExcludingSelM";
            this.mni_FilterExcludingSelM.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelM.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelM.Click += new System.EventHandler(this.mni_FilterExcludingSelM_Click);
            // 
            // mni_RemoveFilterM
            // 
            this.mni_RemoveFilterM.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterM.Name = "mni_RemoveFilterM";
            this.mni_RemoveFilterM.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterM.Text = "Remove filter";
            this.mni_RemoveFilterM.Click += new System.EventHandler(this.mni_RemoveFilterM_Click);
            // 
            // mni_CopyM
            // 
            this.mni_CopyM.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyM.Name = "mni_CopyM";
            this.mni_CopyM.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyM.Text = "Copy";
            this.mni_CopyM.Click += new System.EventHandler(this.mni_CopyM_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminM
            // 
            this.mni_AdminM.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminM.Name = "mni_AdminM";
            this.mni_AdminM.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminM.Text = "List settings";
            this.mni_AdminM.Click += new System.EventHandler(this.mni_AdminM_Click);
            // 
            // mnu_TracingLines
            // 
            this.mnu_TracingLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_TracingLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForT,
            this.mni_Search,
            this.mni_FilterByT,
            this.mni_FilterExcludingSelT,
            this.mni_RemoveFilterT,
            this.mni_CopyT,
            this.toolStripSeparator13,
            this.mni_AdminT});
            this.mnu_TracingLines.Name = "mnu_Requests";
            this.mnu_TracingLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_TracingLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesT_Opening);
            // 
            // mni_FilterForT
            // 
            this.mni_FilterForT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForT.Name = "mni_FilterForT";
            this.mni_FilterForT.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForT.Click += new System.EventHandler(this.mni_FilterForT_TextChanged);
            // 
            // mni_Search
            // 
            this.mni_Search.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_Search.Name = "mni_Search";
            this.mni_Search.Size = new System.Drawing.Size(210, 22);
            this.mni_Search.Text = "Search for record";
            this.mni_Search.Click += new System.EventHandler(this.mni_SearchT_Click);
            // 
            // mni_FilterByT
            // 
            this.mni_FilterByT.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByT.Name = "mni_FilterByT";
            this.mni_FilterByT.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByT.Text = "Filter by selection";
            this.mni_FilterByT.Click += new System.EventHandler(this.mni_FilterByT_Click);
            // 
            // mni_FilterExcludingSelT
            // 
            this.mni_FilterExcludingSelT.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelT.Name = "mni_FilterExcludingSelT";
            this.mni_FilterExcludingSelT.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelT.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelT.Click += new System.EventHandler(this.mni_FilterExcludingSelT_Click);
            // 
            // mni_RemoveFilterT
            // 
            this.mni_RemoveFilterT.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterT.Name = "mni_RemoveFilterT";
            this.mni_RemoveFilterT.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterT.Text = "Remove filter";
            this.mni_RemoveFilterT.Click += new System.EventHandler(this.mni_RemoveFilterT_Click);
            // 
            // mni_CopyT
            // 
            this.mni_CopyT.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyT.Name = "mni_CopyT";
            this.mni_CopyT.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyT.Text = "Copy";
            this.mni_CopyT.Click += new System.EventHandler(this.mni_CopyT_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminT
            // 
            this.mni_AdminT.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminT.Name = "mni_AdminT";
            this.mni_AdminT.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminT.Text = "List settings";
            this.mni_AdminT.Click += new System.EventHandler(this.mni_AdminT_Click);
            // 
            // mnu_CostLines
            // 
            this.mnu_CostLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_CostLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForC,
            this.mni_SearchC,
            this.mni_FilterByC,
            this.mni_FilterExcludingSel,
            this.mni_RemoveFilterC,
            this.mni_CopyC,
            this.toolStripSeparator17,
            this.mni_AdminC});
            this.mnu_CostLines.Name = "mnu_Requests";
            this.mnu_CostLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_CostLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_CostLines_Opening);
            // 
            // mni_FilterForC
            // 
            this.mni_FilterForC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForC.Name = "mni_FilterForC";
            this.mni_FilterForC.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForC.TextChanged += new System.EventHandler(this.mni_FilterForC_TextChanged);
            // 
            // mni_SearchC
            // 
            this.mni_SearchC.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchC.Name = "mni_SearchC";
            this.mni_SearchC.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchC.Text = "Search for record";
            this.mni_SearchC.Click += new System.EventHandler(this.mni_SearchC_Click);
            // 
            // mni_FilterByC
            // 
            this.mni_FilterByC.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByC.Name = "mni_FilterByC";
            this.mni_FilterByC.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByC.Text = "Filter by selection";
            this.mni_FilterByC.Click += new System.EventHandler(this.mni_FilterByC_Click);
            // 
            // mni_FilterExcludingSel
            // 
            this.mni_FilterExcludingSel.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSel.Name = "mni_FilterExcludingSel";
            this.mni_FilterExcludingSel.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSel.Text = "Filter excluding selection";
            this.mni_FilterExcludingSel.Click += new System.EventHandler(this.mni_FilterExcludingSel_Click);
            // 
            // mni_RemoveFilterC
            // 
            this.mni_RemoveFilterC.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterC.Name = "mni_RemoveFilterC";
            this.mni_RemoveFilterC.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterC.Text = "Remove filter";
            this.mni_RemoveFilterC.Click += new System.EventHandler(this.mni_RemoveFilterC_Click);
            // 
            // mni_CopyC
            // 
            this.mni_CopyC.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyC.Name = "mni_CopyC";
            this.mni_CopyC.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyC.Text = "Copy";
            this.mni_CopyC.Click += new System.EventHandler(this.mni_CopyC_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminC
            // 
            this.mni_AdminC.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminC.Name = "mni_AdminC";
            this.mni_AdminC.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminC.Text = "List settings";
            this.mni_AdminC.Click += new System.EventHandler(this.mni_AdminC_Click);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::Odin.Global_Resourses.reload_4545;
            this.buttonSpecAny2.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            // 
            // mnu_ReturnsLines
            // 
            this.mnu_ReturnsLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_ReturnsLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForR,
            this.mni_SearchR,
            this.mni_FilterByR,
            this.mni_FilterExcludingSelR,
            this.mni_RemoveFilterR,
            this.mni_CopyR,
            this.toolStripSeparator21,
            this.mni_AdminR});
            this.mnu_ReturnsLines.Name = "mnu_Requests";
            this.mnu_ReturnsLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_ReturnsLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_ReturnsLines_Opening);
            // 
            // mni_FilterForR
            // 
            this.mni_FilterForR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForR.Name = "mni_FilterForR";
            this.mni_FilterForR.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForR.TextChanged += new System.EventHandler(this.mni_FilterForR_TextChanged);
            // 
            // mni_SearchR
            // 
            this.mni_SearchR.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchR.Name = "mni_SearchR";
            this.mni_SearchR.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchR.Text = "Search for record";
            this.mni_SearchR.Click += new System.EventHandler(this.mni_SearchR_Click);
            // 
            // mni_FilterByR
            // 
            this.mni_FilterByR.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByR.Name = "mni_FilterByR";
            this.mni_FilterByR.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByR.Text = "Filter by selection";
            this.mni_FilterByR.Click += new System.EventHandler(this.mni_FilterByR_Click);
            // 
            // mni_FilterExcludingSelR
            // 
            this.mni_FilterExcludingSelR.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelR.Name = "mni_FilterExcludingSelR";
            this.mni_FilterExcludingSelR.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelR.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelR.Click += new System.EventHandler(this.mni_FilterExcludingSelR_Click);
            // 
            // mni_RemoveFilterR
            // 
            this.mni_RemoveFilterR.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterR.Name = "mni_RemoveFilterR";
            this.mni_RemoveFilterR.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterR.Text = "Remove filter";
            this.mni_RemoveFilterR.Click += new System.EventHandler(this.mni_RemoveFilterR_Click);
            // 
            // mni_CopyR
            // 
            this.mni_CopyR.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyR.Name = "mni_CopyR";
            this.mni_CopyR.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyR.Text = "Copy";
            this.mni_CopyR.Click += new System.EventHandler(this.mni_CopyR_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminR
            // 
            this.mni_AdminR.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminR.Name = "mni_AdminR";
            this.mni_AdminR.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminR.Text = "List settings";
            this.mni_AdminR.Click += new System.EventHandler(this.mni_AdminR_Click);
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonSplitContainer2);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonPanel3);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1588, 645);
            this.kryptonSplitContainer1.SplitterDistance = 547;
            this.kryptonSplitContainer1.TabIndex = 10;
            // 
            // kryptonSplitContainer2
            // 
            this.kryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.kryptonSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer2.Name = "kryptonSplitContainer2";
            // 
            // kryptonSplitContainer2.Panel1
            // 
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_Summary);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.chk_groupbybatch);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_IncomeDoc1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_OutcomeDocs1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Document);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_MoveDocs1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_SalesOrders);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_SalesOrders1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Operation);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_FirmsArt);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_FirmArt);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_PlaceTo);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Places2);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Place);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Places1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Operation);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonLabel1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Batches1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_DateTill);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.txt_DateFrom);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Article);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Articles1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Till);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_From);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Period);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Type);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Types1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.lbl_Supplier);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.cmb_Firms1);
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.dn_Pages);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1588, 547);
            this.kryptonSplitContainer2.SplitterDistance = 299;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // chk_Summary
            // 
            this.chk_Summary.Location = new System.Drawing.Point(215, 419);
            this.chk_Summary.Name = "chk_Summary";
            this.chk_Summary.Size = new System.Drawing.Size(75, 20);
            this.chk_Summary.TabIndex = 296;
            this.chk_Summary.Values.Text = "Summary";
            // 
            // chk_groupbybatch
            // 
            this.chk_groupbybatch.Location = new System.Drawing.Point(9, 419);
            this.chk_groupbybatch.Name = "chk_groupbybatch";
            this.chk_groupbybatch.Size = new System.Drawing.Size(108, 20);
            this.chk_groupbybatch.TabIndex = 295;
            this.chk_groupbybatch.Values.Text = "Group by batch";
            // 
            // cmb_IncomeDoc1
            // 
            this.cmb_IncomeDoc1.CurId = 0;
            this.cmb_IncomeDoc1.EnableSearchId = false;
            this.cmb_IncomeDoc1.IncomeDoc = "";
            this.cmb_IncomeDoc1.IncomeDocId = 0;
            this.cmb_IncomeDoc1.IncomeDocSavedId = 0;
            this.cmb_IncomeDoc1.Location = new System.Drawing.Point(87, 52);
            this.cmb_IncomeDoc1.Name = "cmb_IncomeDoc1";
            this.cmb_IncomeDoc1.Size = new System.Drawing.Size(204, 20);
            this.cmb_IncomeDoc1.SupplierId = 0;
            this.cmb_IncomeDoc1.TabIndex = 294;
            // 
            // cmb_OutcomeDocs1
            // 
            this.cmb_OutcomeDocs1.BatchId = 0;
            this.cmb_OutcomeDocs1.EnableDN = true;
            this.cmb_OutcomeDocs1.EnableSearchId = false;
            this.cmb_OutcomeDocs1.Location = new System.Drawing.Point(87, 52);
            this.cmb_OutcomeDocs1.Name = "cmb_OutcomeDocs1";
            this.cmb_OutcomeDocs1.OutcomeDoc = "";
            this.cmb_OutcomeDocs1.OutcomeDocId = 0;
            this.cmb_OutcomeDocs1.OutcomeDocSavedId = 0;
            this.cmb_OutcomeDocs1.Size = new System.Drawing.Size(204, 20);
            this.cmb_OutcomeDocs1.TabIndex = 293;
            // 
            // lbl_Document
            // 
            this.lbl_Document.Location = new System.Drawing.Point(4, 52);
            this.lbl_Document.Name = "lbl_Document";
            this.lbl_Document.Size = new System.Drawing.Size(70, 20);
            this.lbl_Document.TabIndex = 292;
            this.lbl_Document.Values.Text = "Document:";
            // 
            // cmb_MoveDocs1
            // 
            this.cmb_MoveDocs1.EnableSearchId = false;
            this.cmb_MoveDocs1.Location = new System.Drawing.Point(88, 52);
            this.cmb_MoveDocs1.MoveDoc = "";
            this.cmb_MoveDocs1.MoveDocId = 0;
            this.cmb_MoveDocs1.MoveDocSavedId = 0;
            this.cmb_MoveDocs1.Name = "cmb_MoveDocs1";
            this.cmb_MoveDocs1.Size = new System.Drawing.Size(203, 20);
            this.cmb_MoveDocs1.TabIndex = 291;
            // 
            // lbl_SalesOrders
            // 
            this.lbl_SalesOrders.Location = new System.Drawing.Point(4, 266);
            this.lbl_SalesOrders.Name = "lbl_SalesOrders";
            this.lbl_SalesOrders.Size = new System.Drawing.Size(75, 20);
            this.lbl_SalesOrders.TabIndex = 290;
            this.lbl_SalesOrders.Values.Text = "Conf. order:";
            // 
            // cmb_SalesOrders1
            // 
            this.cmb_SalesOrders1.ClientId = 0;
            this.cmb_SalesOrders1.ContactPersonId = 0;
            this.cmb_SalesOrders1.Contract = "";
            this.cmb_SalesOrders1.EnableSearchId = false;
            this.cmb_SalesOrders1.Internal = 0;
            this.cmb_SalesOrders1.Location = new System.Drawing.Point(87, 266);
            this.cmb_SalesOrders1.Name = "cmb_SalesOrders1";
            this.cmb_SalesOrders1.SalesOrder = "";
            this.cmb_SalesOrders1.SalesOrderId = 0;
            this.cmb_SalesOrders1.SalesOrderSavedId = 0;
            this.cmb_SalesOrders1.Size = new System.Drawing.Size(203, 20);
            this.cmb_SalesOrders1.TabIndex = 289;
            // 
            // cmb_Operation
            // 
            this.cmb_Operation.DropDownWidth = 209;
            this.cmb_Operation.Location = new System.Drawing.Point(87, 130);
            this.cmb_Operation.Name = "cmb_Operation";
            this.cmb_Operation.Size = new System.Drawing.Size(203, 21);
            this.cmb_Operation.TabIndex = 288;
            // 
            // lbl_FirmsArt
            // 
            this.lbl_FirmsArt.Location = new System.Drawing.Point(3, 195);
            this.lbl_FirmsArt.Name = "lbl_FirmsArt";
            this.lbl_FirmsArt.Size = new System.Drawing.Size(102, 20);
            this.lbl_FirmsArt.TabIndex = 287;
            this.lbl_FirmsArt.Values.Text = "Supplier\'s article:";
            // 
            // txt_FirmArt
            // 
            this.txt_FirmArt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_FirmArt.Location = new System.Drawing.Point(8, 215);
            this.txt_FirmArt.Name = "txt_FirmArt";
            this.txt_FirmArt.Size = new System.Drawing.Size(283, 23);
            this.txt_FirmArt.TabIndex = 286;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "37A7E4CC6EDD4E03049882481BF8DE9B";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // lbl_PlaceTo
            // 
            this.lbl_PlaceTo.Location = new System.Drawing.Point(3, 372);
            this.lbl_PlaceTo.Name = "lbl_PlaceTo";
            this.lbl_PlaceTo.Size = new System.Drawing.Size(59, 20);
            this.lbl_PlaceTo.TabIndex = 283;
            this.lbl_PlaceTo.Values.Text = "Move to:";
            // 
            // cmb_Places2
            // 
            this.cmb_Places2.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Places2.Department = "";
            this.cmb_Places2.IsQuarantine = 0;
            this.cmb_Places2.Location = new System.Drawing.Point(9, 393);
            this.cmb_Places2.Lock = 0;
            this.cmb_Places2.Name = "cmb_Places2";
            this.cmb_Places2.PlaceId = 0;
            this.cmb_Places2.SelectedNode = null;
            this.cmb_Places2.Size = new System.Drawing.Size(282, 20);
            this.cmb_Places2.TabIndex = 282;
            // 
            // lbl_Place
            // 
            this.lbl_Place.Location = new System.Drawing.Point(4, 331);
            this.lbl_Place.Name = "lbl_Place";
            this.lbl_Place.Size = new System.Drawing.Size(73, 20);
            this.lbl_Place.TabIndex = 281;
            this.lbl_Place.Values.Text = "Move from:";
            // 
            // cmb_Places1
            // 
            this.cmb_Places1.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Places1.Department = "";
            this.cmb_Places1.IsQuarantine = 0;
            this.cmb_Places1.Location = new System.Drawing.Point(9, 351);
            this.cmb_Places1.Lock = 0;
            this.cmb_Places1.Name = "cmb_Places1";
            this.cmb_Places1.PlaceId = 0;
            this.cmb_Places1.SelectedNode = null;
            this.cmb_Places1.Size = new System.Drawing.Size(282, 20);
            this.cmb_Places1.TabIndex = 280;
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.Location = new System.Drawing.Point(4, 130);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(68, 20);
            this.lbl_Operation.TabIndex = 279;
            this.lbl_Operation.Values.Text = "Operation:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 240);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 239;
            this.kryptonLabel1.Values.Text = "Batch:";
            // 
            // cmb_Batches1
            // 
            this.cmb_Batches1.ActiveOnly = 0;
            this.cmb_Batches1.Article = null;
            this.cmb_Batches1.ArticleId = 0;
            this.cmb_Batches1.Batch = "";
            this.cmb_Batches1.BatchId = 0;
            this.cmb_Batches1.Comments = "";
            this.cmb_Batches1.ConfOrder = "";
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.CustArticle = "";
            this.cmb_Batches1.Customer = "";
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.IsGroup = 0;
            this.cmb_Batches1.IsProject = 0;
            this.cmb_Batches1.IsQuote = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(87, 240);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(153, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 238;
            // 
            // txt_DateTill
            // 
            this.txt_DateTill.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_DateTill.CalendarShowWeekNumbers = true;
            this.txt_DateTill.CustomFormat = null;
            this.txt_DateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateTill.Location = new System.Drawing.Point(187, 308);
            this.txt_DateTill.Name = "txt_DateTill";
            this.txt_DateTill.NullValue = " ";
            this.txt_DateTill.Size = new System.Drawing.Size(104, 21);
            this.txt_DateTill.TabIndex = 232;
            this.txt_DateTill.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_DateTill_DropDown);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny4.UniqueName = "6A2751F9284C45EEA28C814570A892DD";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // txt_DateFrom
            // 
            this.txt_DateFrom.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_DateFrom.CalendarShowWeekNumbers = true;
            this.txt_DateFrom.CustomFormat = null;
            this.txt_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateFrom.Location = new System.Drawing.Point(51, 308);
            this.txt_DateFrom.Name = "txt_DateFrom";
            this.txt_DateFrom.NullValue = " ";
            this.txt_DateFrom.Size = new System.Drawing.Size(105, 21);
            this.txt_DateFrom.TabIndex = 231;
            this.txt_DateFrom.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_DateFrom_DropDown);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny3.UniqueName = "E61697DA9D484B901DB9E49E0F0EE20E";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // lbl_Article
            // 
            this.lbl_Article.Location = new System.Drawing.Point(4, 149);
            this.lbl_Article.Name = "lbl_Article";
            this.lbl_Article.Size = new System.Drawing.Size(48, 20);
            this.lbl_Article.TabIndex = 230;
            this.lbl_Article.Values.Text = "Article:";
            // 
            // cmb_Articles1
            // 
            this.cmb_Articles1.Article = "";
            this.cmb_Articles1.ArticleId = 0;
            this.cmb_Articles1.ArticleIdRec = 0;
            this.cmb_Articles1.ArtType = null;
            this.cmb_Articles1.BOMState = 0;
            this.cmb_Articles1.Comments = null;
            this.cmb_Articles1.CustCode = null;
            this.cmb_Articles1.CustCodeId = 0;
            this.cmb_Articles1.Department = null;
            this.cmb_Articles1.DeptId = 0;
            this.cmb_Articles1.Description = null;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.IsCertified = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(8, 172);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(283, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 229;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            // 
            // lbl_Till
            // 
            this.lbl_Till.Location = new System.Drawing.Point(158, 309);
            this.lbl_Till.Name = "lbl_Till";
            this.lbl_Till.Size = new System.Drawing.Size(26, 20);
            this.lbl_Till.TabIndex = 226;
            this.lbl_Till.Values.Text = "till:";
            // 
            // lbl_From
            // 
            this.lbl_From.Location = new System.Drawing.Point(4, 308);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(41, 20);
            this.lbl_From.TabIndex = 225;
            this.lbl_From.Values.Text = "From:";
            // 
            // lbl_Period
            // 
            this.lbl_Period.Location = new System.Drawing.Point(4, 286);
            this.lbl_Period.Name = "lbl_Period";
            this.lbl_Period.Size = new System.Drawing.Size(48, 20);
            this.lbl_Period.TabIndex = 224;
            this.lbl_Period.Values.Text = "Period:";
            // 
            // lbl_Type
            // 
            this.lbl_Type.Location = new System.Drawing.Point(3, 104);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(39, 20);
            this.lbl_Type.TabIndex = 223;
            this.lbl_Type.Values.Text = "Type:";
            // 
            // cmb_Types1
            // 
            this.cmb_Types1.Location = new System.Drawing.Point(87, 104);
            this.cmb_Types1.Name = "cmb_Types1";
            this.cmb_Types1.Path = "";
            this.cmb_Types1.SelectedNode = null;
            this.cmb_Types1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Types1.TabIndex = 222;
            this.cmb_Types1.Type = "";
            this.cmb_Types1.TypeId = 0;
            this.cmb_Types1.TypeIDs = ((System.Collections.Generic.List<int>)(resources.GetObject("cmb_Types1.TypeIDs")));
            this.cmb_Types1.TypeLat = "";
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.Location = new System.Drawing.Point(3, 78);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(58, 20);
            this.lbl_Supplier.TabIndex = 221;
            this.lbl_Supplier.Values.Text = "Supplier:";
            // 
            // cmb_Firms1
            // 
            this.cmb_Firms1.CountryId = 0;
            this.cmb_Firms1.CountryVAT = 0D;
            this.cmb_Firms1.CurId = 0;
            this.cmb_Firms1.CustIncotermsId = 0;
            this.cmb_Firms1.CustPaymentId = 0;
            this.cmb_Firms1.EnableSearchId = false;
            this.cmb_Firms1.Firm = "";
            this.cmb_Firms1.FirmId = 0;
            this.cmb_Firms1.IsEmptyColor = false;
            this.cmb_Firms1.Location = new System.Drawing.Point(87, 78);
            this.cmb_Firms1.Name = "cmb_Firms1";
            this.cmb_Firms1.Size = new System.Drawing.Size(204, 20);
            this.cmb_Firms1.SupComments = null;
            this.cmb_Firms1.SupIncotermsId = 0;
            this.cmb_Firms1.TabIndex = 220;
            this.cmb_Firms1.VATNr = null;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Refresh,
            this.btn_Clear});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(299, 42);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Filter";
            this.kryptonHeader1.Values.Image = global::Odin.Global_Resourses.Filter;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.UniqueName = "B6748632D5384B24EEB0EB4621A7108D";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.UniqueName = "3502D2542D5C42F0078623FF0A695273";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dn_Pages
            // 
            this.dn_Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dn_Pages.Location = new System.Drawing.Point(0, 0);
            this.dn_Pages.Name = "dn_Pages";
            this.dn_Pages.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pg_Incomes,
            this.pg_Withdraw,
            this.pg_Movements,
            this.pg_Returns,
            this.pg_Tracing,
            this.pg_Cost});
            this.dn_Pages.SelectedIndex = 0;
            this.dn_Pages.Size = new System.Drawing.Size(1284, 547);
            this.dn_Pages.TabIndex = 0;
            this.dn_Pages.Text = "kryptonDockableNavigator1";
            this.dn_Pages.Click += new System.EventHandler(this.dn_Pages_Click);
            // 
            // pg_Incomes
            // 
            this.pg_Incomes.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Incomes.Controls.Add(this.gv_IncomeList);
            this.pg_Incomes.Controls.Add(this.bn_IncomeList);
            this.pg_Incomes.Controls.Add(this.kryptonPanel1);
            this.pg_Incomes.Flags = 65534;
            this.pg_Incomes.LastVisibleSet = true;
            this.pg_Incomes.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Incomes.Name = "pg_Incomes";
            this.pg_Incomes.Size = new System.Drawing.Size(1282, 520);
            this.pg_Incomes.Text = "Incomes";
            this.pg_Incomes.ToolTipTitle = "Page ToolTip";
            this.pg_Incomes.UniqueName = "A65C89D28BBC4329B7BA1979C00591EB";
            // 
            // gv_IncomeList
            // 
            this.gv_IncomeList.AllowUserToAddRows = false;
            this.gv_IncomeList.AllowUserToDeleteRows = false;
            this.gv_IncomeList.AllowUserToOrderColumns = true;
            this.gv_IncomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_IncomeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_headid,
            this.cn_name,
            this.cn_regdate,
            this.cn_docdate,
            this.cn_Supplier,
            this.cn_artid,
            this.cn_article,
            this.cn_supart,
            this.cn_itype,
            this.cn_ioperation,
            this.cn_supid,
            this.cn_qty,
            this.cn_unit,
            this.cn_unitprice,
            this.cn_discount,
            this.cn_currency,
            this.cn_vat,
            this.cn_Batch,
            this.cn_comments,
            this.cn_coefconv,
            this.cn_weight,
            this.cn_total,
            this.cn_totalvat,
            this.cn_totalwithvat,
            this.cn_unitpriceeur,
            this.cn_totaleur,
            this.cn_totalvateur,
            this.cn_totalwithvateur,
            this.cn_custcode,
            this.cn_createdat,
            this.cn_createdby,
            this.cn_state,
            this.cn_pcesperunit,
            this.cn_icountry});
            this.gv_IncomeList.ContextMenuStrip = this.mnu_IncomeLines;
            this.gv_IncomeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_IncomeList.Location = new System.Drawing.Point(0, 49);
            this.gv_IncomeList.Name = "gv_IncomeList";
            this.gv_IncomeList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_IncomeList.ReadOnly = true;
            this.gv_IncomeList.RowHeadersWidth = 20;
            this.gv_IncomeList.Size = new System.Drawing.Size(1282, 446);
            this.gv_IncomeList.TabIndex = 9;
            this.gv_IncomeList.SelectionChanged += new System.EventHandler(this.gv_IncomeList_SelectionChanged);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            // 
            // cn_headid
            // 
            this.cn_headid.DataPropertyName = "headid";
            this.cn_headid.HeaderText = "headid";
            this.cn_headid.Name = "cn_headid";
            this.cn_headid.ReadOnly = true;
            this.cn_headid.Visible = false;
            // 
            // cn_name
            // 
            this.cn_name.DataPropertyName = "name";
            this.cn_name.HeaderText = "Income doc.";
            this.cn_name.Name = "cn_name";
            this.cn_name.ReadOnly = true;
            // 
            // cn_regdate
            // 
            this.cn_regdate.DataPropertyName = "regdate";
            this.cn_regdate.FillWeight = 90F;
            this.cn_regdate.HeaderText = "Reg. date";
            this.cn_regdate.Name = "cn_regdate";
            this.cn_regdate.ReadOnly = true;
            this.cn_regdate.Width = 90;
            // 
            // cn_docdate
            // 
            this.cn_docdate.DataPropertyName = "docdate";
            this.cn_docdate.FillWeight = 90F;
            this.cn_docdate.HeaderText = "Doc. date";
            this.cn_docdate.Name = "cn_docdate";
            this.cn_docdate.ReadOnly = true;
            this.cn_docdate.Width = 90;
            // 
            // cn_Supplier
            // 
            this.cn_Supplier.DataPropertyName = "supplier";
            this.cn_Supplier.FillWeight = 120F;
            this.cn_Supplier.HeaderText = "Supplier";
            this.cn_Supplier.Name = "cn_Supplier";
            this.cn_Supplier.ReadOnly = true;
            this.cn_Supplier.Width = 120;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 80F;
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
            this.cn_artid.Width = 80;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 200F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Width = 200;
            // 
            // cn_supart
            // 
            this.cn_supart.DataPropertyName = "suparticle";
            this.cn_supart.FillWeight = 200F;
            this.cn_supart.HeaderText = "Supplier\'s article";
            this.cn_supart.Name = "cn_supart";
            this.cn_supart.ReadOnly = true;
            this.cn_supart.Width = 200;
            // 
            // cn_itype
            // 
            this.cn_itype.DataPropertyName = "type";
            this.cn_itype.HeaderText = "Type";
            this.cn_itype.Name = "cn_itype";
            this.cn_itype.ReadOnly = true;
            // 
            // cn_ioperation
            // 
            this.cn_ioperation.DataPropertyName = "operation";
            this.cn_ioperation.HeaderText = "Operation";
            this.cn_ioperation.Name = "cn_ioperation";
            this.cn_ioperation.ReadOnly = true;
            // 
            // cn_supid
            // 
            this.cn_supid.DataPropertyName = "supid";
            this.cn_supid.FillWeight = 30F;
            this.cn_supid.HeaderText = "supid";
            this.cn_supid.Name = "cn_supid";
            this.cn_supid.ReadOnly = true;
            this.cn_supid.Visible = false;
            this.cn_supid.Width = 30;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 80F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 80;
            // 
            // cn_unit
            // 
            this.cn_unit.DataPropertyName = "unit";
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.ReadOnly = true;
            this.cn_unit.Width = 40;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price";
            this.cn_unitprice.Name = "cn_unitprice";
            this.cn_unitprice.ReadOnly = true;
            // 
            // cn_discount
            // 
            this.cn_discount.DataPropertyName = "discount";
            this.cn_discount.FillWeight = 40F;
            this.cn_discount.HeaderText = "Disc.";
            this.cn_discount.Name = "cn_discount";
            this.cn_discount.ReadOnly = true;
            this.cn_discount.Width = 40;
            // 
            // cn_currency
            // 
            this.cn_currency.DataPropertyName = "currency";
            this.cn_currency.FillWeight = 40F;
            this.cn_currency.HeaderText = "Currency";
            this.cn_currency.Name = "cn_currency";
            this.cn_currency.ReadOnly = true;
            this.cn_currency.Width = 40;
            // 
            // cn_vat
            // 
            this.cn_vat.DataPropertyName = "vat";
            this.cn_vat.FillWeight = 30F;
            this.cn_vat.HeaderText = "Vat";
            this.cn_vat.Name = "cn_vat";
            this.cn_vat.ReadOnly = true;
            this.cn_vat.Width = 30;
            // 
            // cn_Batch
            // 
            this.cn_Batch.DataPropertyName = "batch";
            this.cn_Batch.HeaderText = "Batch";
            this.cn_Batch.Name = "cn_Batch";
            this.cn_Batch.ReadOnly = true;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.ReadOnly = true;
            this.cn_comments.Width = 150;
            // 
            // cn_coefconv
            // 
            this.cn_coefconv.DataPropertyName = "coefconv";
            this.cn_coefconv.HeaderText = "CoefConv";
            this.cn_coefconv.Name = "cn_coefconv";
            this.cn_coefconv.ReadOnly = true;
            this.cn_coefconv.Visible = false;
            // 
            // cn_weight
            // 
            this.cn_weight.DataPropertyName = "weight";
            this.cn_weight.FillWeight = 80F;
            this.cn_weight.HeaderText = "Weight net";
            this.cn_weight.Name = "cn_weight";
            this.cn_weight.ReadOnly = true;
            this.cn_weight.Width = 80;
            // 
            // cn_total
            // 
            this.cn_total.DataPropertyName = "total";
            this.cn_total.HeaderText = "Total";
            this.cn_total.Name = "cn_total";
            this.cn_total.ReadOnly = true;
            // 
            // cn_totalvat
            // 
            this.cn_totalvat.DataPropertyName = "totalvat";
            this.cn_totalvat.HeaderText = "Total Vat";
            this.cn_totalvat.Name = "cn_totalvat";
            this.cn_totalvat.ReadOnly = true;
            // 
            // cn_totalwithvat
            // 
            this.cn_totalwithvat.DataPropertyName = "totalwithvat";
            this.cn_totalwithvat.HeaderText = "Total + Vat";
            this.cn_totalwithvat.Name = "cn_totalwithvat";
            this.cn_totalwithvat.ReadOnly = true;
            // 
            // cn_unitpriceeur
            // 
            this.cn_unitpriceeur.DataPropertyName = "unitpriceeur";
            this.cn_unitpriceeur.HeaderText = "Unit price (BR)";
            this.cn_unitpriceeur.Name = "cn_unitpriceeur";
            this.cn_unitpriceeur.ReadOnly = true;
            // 
            // cn_totaleur
            // 
            this.cn_totaleur.DataPropertyName = "totaleur";
            this.cn_totaleur.HeaderText = "Total (BR)";
            this.cn_totaleur.Name = "cn_totaleur";
            this.cn_totaleur.ReadOnly = true;
            // 
            // cn_totalvateur
            // 
            this.cn_totalvateur.DataPropertyName = "totalvateur";
            this.cn_totalvateur.HeaderText = "Total Vat (BR)";
            this.cn_totalvateur.Name = "cn_totalvateur";
            this.cn_totalvateur.ReadOnly = true;
            // 
            // cn_totalwithvateur
            // 
            this.cn_totalwithvateur.DataPropertyName = "totalwithvateur";
            this.cn_totalwithvateur.HeaderText = "Total + VAT (BR)";
            this.cn_totalwithvateur.Name = "cn_totalwithvateur";
            this.cn_totalwithvateur.ReadOnly = true;
            // 
            // cn_custcode
            // 
            this.cn_custcode.DataPropertyName = "custcode";
            this.cn_custcode.HeaderText = "Cust. code";
            this.cn_custcode.Name = "cn_custcode";
            this.cn_custcode.ReadOnly = true;
            // 
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "createdat";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.cn_createdat.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_createdat.FillWeight = 85F;
            this.cn_createdat.HeaderText = "Created at";
            this.cn_createdat.Name = "cn_createdat";
            this.cn_createdat.ReadOnly = true;
            this.cn_createdat.Width = 85;
            // 
            // cn_createdby
            // 
            this.cn_createdby.DataPropertyName = "createdby";
            this.cn_createdby.HeaderText = "Created by";
            this.cn_createdby.Name = "cn_createdby";
            this.cn_createdby.ReadOnly = true;
            // 
            // cn_state
            // 
            this.cn_state.DataPropertyName = "state";
            this.cn_state.HeaderText = "State";
            this.cn_state.Name = "cn_state";
            this.cn_state.ReadOnly = true;
            this.cn_state.Visible = false;
            // 
            // cn_pcesperunit
            // 
            this.cn_pcesperunit.DataPropertyName = "pcesperunit";
            this.cn_pcesperunit.HeaderText = "Pces/unit";
            this.cn_pcesperunit.Name = "cn_pcesperunit";
            this.cn_pcesperunit.ReadOnly = true;
            // 
            // cn_icountry
            // 
            this.cn_icountry.DataPropertyName = "country";
            this.cn_icountry.HeaderText = "Country";
            this.cn_icountry.Name = "cn_icountry";
            this.cn_icountry.ReadOnly = true;
            // 
            // bn_IncomeList
            // 
            this.bn_IncomeList.AddNewItem = null;
            this.bn_IncomeList.CountItem = this.bindingNavigatorCountItem;
            this.bn_IncomeList.DeleteItem = null;
            this.bn_IncomeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_IncomeList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_IncomeList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btn_ExcelI});
            this.bn_IncomeList.Location = new System.Drawing.Point(0, 495);
            this.bn_IncomeList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_IncomeList.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_IncomeList.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_IncomeList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_IncomeList.Name = "bn_IncomeList";
            this.bn_IncomeList.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_IncomeList.Size = new System.Drawing.Size(1282, 25);
            this.bn_IncomeList.TabIndex = 8;
            this.bn_IncomeList.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ExcelI
            // 
            this.btn_ExcelI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelI.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExcelI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelI.Name = "btn_ExcelI";
            this.btn_ExcelI.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelI.Text = "Export into excel";
            this.btn_ExcelI.Click += new System.EventHandler(this.btn_ExcelI_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Rests);
            this.kryptonPanel1.Controls.Add(this.btn_PO);
            this.kryptonPanel1.Controls.Add(this.btn_Tracing);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1282, 49);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // btn_Rests
            // 
            this.btn_Rests.Location = new System.Drawing.Point(210, 5);
            this.btn_Rests.Name = "btn_Rests";
            this.btn_Rests.Size = new System.Drawing.Size(100, 39);
            this.btn_Rests.TabIndex = 12;
            this.btn_Rests.Values.Image = global::Odin.Global_Resourses.box32x32;
            this.btn_Rests.Values.Text = "Rests";
            this.btn_Rests.Click += new System.EventHandler(this.btn_Rests_Click);
            // 
            // btn_PO
            // 
            this.btn_PO.Location = new System.Drawing.Point(107, 5);
            this.btn_PO.Name = "btn_PO";
            this.btn_PO.Size = new System.Drawing.Size(100, 39);
            this.btn_PO.TabIndex = 11;
            this.btn_PO.Values.Image = global::Odin.Global_Resourses.basket_8134;
            this.btn_PO.Values.Text = "PO";
            // 
            // btn_Tracing
            // 
            this.btn_Tracing.Location = new System.Drawing.Point(4, 5);
            this.btn_Tracing.Name = "btn_Tracing";
            this.btn_Tracing.Size = new System.Drawing.Size(100, 39);
            this.btn_Tracing.TabIndex = 10;
            this.btn_Tracing.Values.Image = global::Odin.Global_Resourses.Synchronize_24x24;
            this.btn_Tracing.Values.Text = "Trace";
            this.btn_Tracing.Click += new System.EventHandler(this.btn_Tracing_Click);
            // 
            // pg_Withdraw
            // 
            this.pg_Withdraw.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Withdraw.Controls.Add(this.gv_OutcomeList);
            this.pg_Withdraw.Controls.Add(this.bn_OutcomeList);
            this.pg_Withdraw.Controls.Add(this.kryptonPanel2);
            this.pg_Withdraw.Flags = 65534;
            this.pg_Withdraw.LastVisibleSet = true;
            this.pg_Withdraw.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Withdraw.Name = "pg_Withdraw";
            this.pg_Withdraw.Size = new System.Drawing.Size(1282, 520);
            this.pg_Withdraw.Text = "Withdraw";
            this.pg_Withdraw.ToolTipTitle = "Page ToolTip";
            this.pg_Withdraw.UniqueName = "0F8B1C886E2B4459F5A398784EE31DD3";
            // 
            // gv_OutcomeList
            // 
            this.gv_OutcomeList.AllowUserToAddRows = false;
            this.gv_OutcomeList.AllowUserToDeleteRows = false;
            this.gv_OutcomeList.AllowUserToOrderColumns = true;
            this.gv_OutcomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_OutcomeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_oid,
            this.cn_oheadid,
            this.cn_oname,
            this.cn_odelivdate,
            this.cn_odocdate,
            this.cn_ocustomer,
            this.cn_oartid,
            this.cn_oarticle,
            this.cn_ocustarticle,
            this.cn_otype,
            this.cn_ooperation,
            this.cn_oqty,
            this.cn_ounit,
            this.cn_ounitprice,
            this.cn_obatch,
            this.cn_orequest,
            this.cn_oconforder,
            this.cn_ocustorder,
            this.cn_ocomments,
            this.cn_oplace,
            this.cn_ototal,
            this.cn_ocustcode,
            this.cn_ocreatat,
            this.cn_ocreatby,
            this.cn_oset,
            this.cn_countryoforigin,
            this.cn_writeoffreason,
            this.cn_olabel,
            this.cn_osecname,
            this.cn_olaunch,
            this.cn_incomedoc,
            this.cn_incomedate,
            this.cn_datacode,
            this.cn_manufbatch});
            this.gv_OutcomeList.ContextMenuStrip = this.mnu_OutcomeLines;
            this.gv_OutcomeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_OutcomeList.Location = new System.Drawing.Point(0, 49);
            this.gv_OutcomeList.Name = "gv_OutcomeList";
            this.gv_OutcomeList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_OutcomeList.ReadOnly = true;
            this.gv_OutcomeList.RowHeadersWidth = 20;
            this.gv_OutcomeList.Size = new System.Drawing.Size(1282, 446);
            this.gv_OutcomeList.TabIndex = 21;
            // 
            // cn_oid
            // 
            this.cn_oid.DataPropertyName = "id";
            this.cn_oid.HeaderText = "id";
            this.cn_oid.Name = "cn_oid";
            this.cn_oid.ReadOnly = true;
            this.cn_oid.Visible = false;
            // 
            // cn_oheadid
            // 
            this.cn_oheadid.DataPropertyName = "headid";
            this.cn_oheadid.HeaderText = "headid";
            this.cn_oheadid.Name = "cn_oheadid";
            this.cn_oheadid.ReadOnly = true;
            this.cn_oheadid.Visible = false;
            // 
            // cn_oname
            // 
            this.cn_oname.DataPropertyName = "name";
            this.cn_oname.HeaderText = "Outcome doc.";
            this.cn_oname.Name = "cn_oname";
            this.cn_oname.ReadOnly = true;
            // 
            // cn_odelivdate
            // 
            this.cn_odelivdate.DataPropertyName = "delivdate";
            this.cn_odelivdate.FillWeight = 90F;
            this.cn_odelivdate.HeaderText = "Deliv. date";
            this.cn_odelivdate.Name = "cn_odelivdate";
            this.cn_odelivdate.ReadOnly = true;
            this.cn_odelivdate.Width = 90;
            // 
            // cn_odocdate
            // 
            this.cn_odocdate.DataPropertyName = "docdate";
            this.cn_odocdate.FillWeight = 90F;
            this.cn_odocdate.HeaderText = "Doc. date";
            this.cn_odocdate.Name = "cn_odocdate";
            this.cn_odocdate.ReadOnly = true;
            this.cn_odocdate.Width = 90;
            // 
            // cn_ocustomer
            // 
            this.cn_ocustomer.DataPropertyName = "customer";
            this.cn_ocustomer.FillWeight = 120F;
            this.cn_ocustomer.HeaderText = "Customer";
            this.cn_ocustomer.Name = "cn_ocustomer";
            this.cn_ocustomer.ReadOnly = true;
            this.cn_ocustomer.Width = 120;
            // 
            // cn_oartid
            // 
            this.cn_oartid.DataPropertyName = "artid";
            this.cn_oartid.FillWeight = 80F;
            this.cn_oartid.HeaderText = "Art. id";
            this.cn_oartid.Name = "cn_oartid";
            this.cn_oartid.ReadOnly = true;
            this.cn_oartid.Width = 80;
            // 
            // cn_oarticle
            // 
            this.cn_oarticle.DataPropertyName = "article";
            this.cn_oarticle.FillWeight = 200F;
            this.cn_oarticle.HeaderText = "Article";
            this.cn_oarticle.Name = "cn_oarticle";
            this.cn_oarticle.ReadOnly = true;
            this.cn_oarticle.Width = 200;
            // 
            // cn_ocustarticle
            // 
            this.cn_ocustarticle.DataPropertyName = "custarticle";
            this.cn_ocustarticle.FillWeight = 200F;
            this.cn_ocustarticle.HeaderText = "Customer\'s article";
            this.cn_ocustarticle.Name = "cn_ocustarticle";
            this.cn_ocustarticle.ReadOnly = true;
            this.cn_ocustarticle.Width = 200;
            // 
            // cn_otype
            // 
            this.cn_otype.DataPropertyName = "type";
            this.cn_otype.HeaderText = "Type";
            this.cn_otype.Name = "cn_otype";
            this.cn_otype.ReadOnly = true;
            // 
            // cn_ooperation
            // 
            this.cn_ooperation.DataPropertyName = "operation";
            this.cn_ooperation.HeaderText = "Operation";
            this.cn_ooperation.Name = "cn_ooperation";
            this.cn_ooperation.ReadOnly = true;
            // 
            // cn_oqty
            // 
            this.cn_oqty.DataPropertyName = "qty";
            this.cn_oqty.FillWeight = 80F;
            this.cn_oqty.HeaderText = "Qty";
            this.cn_oqty.Name = "cn_oqty";
            this.cn_oqty.ReadOnly = true;
            this.cn_oqty.Width = 80;
            // 
            // cn_ounit
            // 
            this.cn_ounit.DataPropertyName = "unit";
            this.cn_ounit.FillWeight = 40F;
            this.cn_ounit.HeaderText = "Unit";
            this.cn_ounit.Name = "cn_ounit";
            this.cn_ounit.ReadOnly = true;
            this.cn_ounit.Width = 40;
            // 
            // cn_ounitprice
            // 
            this.cn_ounitprice.DataPropertyName = "unitprice";
            this.cn_ounitprice.HeaderText = "Unit price (BR)";
            this.cn_ounitprice.Name = "cn_ounitprice";
            this.cn_ounitprice.ReadOnly = true;
            // 
            // cn_obatch
            // 
            this.cn_obatch.DataPropertyName = "batch";
            this.cn_obatch.HeaderText = "Batch";
            this.cn_obatch.Name = "cn_obatch";
            this.cn_obatch.ReadOnly = true;
            // 
            // cn_orequest
            // 
            this.cn_orequest.DataPropertyName = "request";
            this.cn_orequest.HeaderText = "Request";
            this.cn_orequest.Name = "cn_orequest";
            this.cn_orequest.ReadOnly = true;
            // 
            // cn_oconforder
            // 
            this.cn_oconforder.DataPropertyName = "conforder";
            this.cn_oconforder.HeaderText = "Conf. order";
            this.cn_oconforder.Name = "cn_oconforder";
            this.cn_oconforder.ReadOnly = true;
            // 
            // cn_ocustorder
            // 
            this.cn_ocustorder.DataPropertyName = "custorder";
            this.cn_ocustorder.HeaderText = "Cust. order";
            this.cn_ocustorder.Name = "cn_ocustorder";
            this.cn_ocustorder.ReadOnly = true;
            // 
            // cn_ocomments
            // 
            this.cn_ocomments.DataPropertyName = "comments";
            this.cn_ocomments.FillWeight = 150F;
            this.cn_ocomments.HeaderText = "Comments";
            this.cn_ocomments.Name = "cn_ocomments";
            this.cn_ocomments.ReadOnly = true;
            this.cn_ocomments.Width = 150;
            // 
            // cn_oplace
            // 
            this.cn_oplace.DataPropertyName = "place";
            this.cn_oplace.FillWeight = 120F;
            this.cn_oplace.HeaderText = "Place";
            this.cn_oplace.Name = "cn_oplace";
            this.cn_oplace.ReadOnly = true;
            this.cn_oplace.Width = 120;
            // 
            // cn_ototal
            // 
            this.cn_ototal.DataPropertyName = "total";
            this.cn_ototal.HeaderText = "Total";
            this.cn_ototal.Name = "cn_ototal";
            this.cn_ototal.ReadOnly = true;
            // 
            // cn_ocustcode
            // 
            this.cn_ocustcode.DataPropertyName = "custcode";
            this.cn_ocustcode.HeaderText = "Cust. code";
            this.cn_ocustcode.Name = "cn_ocustcode";
            this.cn_ocustcode.ReadOnly = true;
            // 
            // cn_ocreatat
            // 
            this.cn_ocreatat.DataPropertyName = "createdat";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.cn_ocreatat.DefaultCellStyle = dataGridViewCellStyle2;
            this.cn_ocreatat.FillWeight = 85F;
            this.cn_ocreatat.HeaderText = "Created at";
            this.cn_ocreatat.Name = "cn_ocreatat";
            this.cn_ocreatat.ReadOnly = true;
            this.cn_ocreatat.Width = 85;
            // 
            // cn_ocreatby
            // 
            this.cn_ocreatby.DataPropertyName = "createdby";
            this.cn_ocreatby.HeaderText = "Created by";
            this.cn_ocreatby.Name = "cn_ocreatby";
            this.cn_ocreatby.ReadOnly = true;
            // 
            // cn_oset
            // 
            this.cn_oset.DataPropertyName = "set";
            this.cn_oset.HeaderText = "Assembled doc.";
            this.cn_oset.Name = "cn_oset";
            this.cn_oset.ReadOnly = true;
            // 
            // cn_countryoforigin
            // 
            this.cn_countryoforigin.DataPropertyName = "countryoforigin";
            this.cn_countryoforigin.HeaderText = "Country of origin";
            this.cn_countryoforigin.Name = "cn_countryoforigin";
            this.cn_countryoforigin.ReadOnly = true;
            // 
            // cn_writeoffreason
            // 
            this.cn_writeoffreason.DataPropertyName = "writeoffreason";
            this.cn_writeoffreason.HeaderText = "Write-off reason";
            this.cn_writeoffreason.Name = "cn_writeoffreason";
            this.cn_writeoffreason.ReadOnly = true;
            // 
            // cn_olabel
            // 
            this.cn_olabel.DataPropertyName = "label";
            this.cn_olabel.HeaderText = "Label";
            this.cn_olabel.Name = "cn_olabel";
            this.cn_olabel.ReadOnly = true;
            // 
            // cn_osecname
            // 
            this.cn_osecname.DataPropertyName = "secname";
            this.cn_osecname.HeaderText = "2nd name";
            this.cn_osecname.Name = "cn_osecname";
            this.cn_osecname.ReadOnly = true;
            // 
            // cn_olaunch
            // 
            this.cn_olaunch.DataPropertyName = "launch";
            this.cn_olaunch.HeaderText = "Launch";
            this.cn_olaunch.Name = "cn_olaunch";
            this.cn_olaunch.ReadOnly = true;
            // 
            // cn_incomedoc
            // 
            this.cn_incomedoc.DataPropertyName = "incomedoc";
            this.cn_incomedoc.HeaderText = "Income doc.";
            this.cn_incomedoc.Name = "cn_incomedoc";
            this.cn_incomedoc.ReadOnly = true;
            // 
            // cn_incomedate
            // 
            this.cn_incomedate.DataPropertyName = "incomedate";
            this.cn_incomedate.HeaderText = "Income date";
            this.cn_incomedate.Name = "cn_incomedate";
            this.cn_incomedate.ReadOnly = true;
            // 
            // cn_datacode
            // 
            this.cn_datacode.DataPropertyName = "datacode";
            this.cn_datacode.HeaderText = "Datacode";
            this.cn_datacode.Name = "cn_datacode";
            this.cn_datacode.ReadOnly = true;
            // 
            // cn_manufbatch
            // 
            this.cn_manufbatch.DataPropertyName = "manufbatch";
            this.cn_manufbatch.HeaderText = "Manuf. batch";
            this.cn_manufbatch.Name = "cn_manufbatch";
            this.cn_manufbatch.ReadOnly = true;
            // 
            // bn_OutcomeList
            // 
            this.bn_OutcomeList.AddNewItem = null;
            this.bn_OutcomeList.CountItem = this.toolStripLabel1;
            this.bn_OutcomeList.DeleteItem = null;
            this.bn_OutcomeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_OutcomeList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_OutcomeList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripTextBox3,
            this.toolStripLabel1,
            this.toolStripSeparator5,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator6,
            this.btn_ExcelO});
            this.bn_OutcomeList.Location = new System.Drawing.Point(0, 495);
            this.bn_OutcomeList.MoveFirstItem = this.toolStripButton1;
            this.bn_OutcomeList.MoveLastItem = this.toolStripButton4;
            this.bn_OutcomeList.MoveNextItem = this.toolStripButton3;
            this.bn_OutcomeList.MovePreviousItem = this.toolStripButton2;
            this.bn_OutcomeList.Name = "bn_OutcomeList";
            this.bn_OutcomeList.PositionItem = this.toolStripTextBox3;
            this.bn_OutcomeList.Size = new System.Drawing.Size(1282, 25);
            this.bn_OutcomeList.TabIndex = 20;
            this.bn_OutcomeList.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Position";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ExcelO
            // 
            this.btn_ExcelO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelO.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExcelO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelO.Name = "btn_ExcelO";
            this.btn_ExcelO.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelO.Text = "Export into excel";
            this.btn_ExcelO.Click += new System.EventHandler(this.btn_ExcelO_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel2.Controls.Add(this.txt_TotalOutcomes);
            this.kryptonPanel2.Controls.Add(this.kryptonButton5);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1282, 49);
            this.kryptonPanel2.TabIndex = 7;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(176, 15);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel12.TabIndex = 25;
            this.kryptonLabel12.Values.Text = "Total (BR):";
            // 
            // txt_TotalOutcomes
            // 
            this.txt_TotalOutcomes.AllowDecimalSeparator = true;
            this.txt_TotalOutcomes.AllowSpace = false;
            this.txt_TotalOutcomes.Location = new System.Drawing.Point(239, 15);
            this.txt_TotalOutcomes.Name = "txt_TotalOutcomes";
            this.txt_TotalOutcomes.Size = new System.Drawing.Size(124, 21);
            this.txt_TotalOutcomes.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_TotalOutcomes.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalOutcomes.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_TotalOutcomes.TabIndex = 24;
            this.txt_TotalOutcomes.Text = "0";
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Location = new System.Drawing.Point(4, 5);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(100, 39);
            this.kryptonButton5.TabIndex = 1;
            this.kryptonButton5.Values.Image = global::Odin.Global_Resourses.Docs;
            this.kryptonButton5.Values.Text = "General";
            // 
            // pg_Movements
            // 
            this.pg_Movements.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Movements.Controls.Add(this.gv_MovementList);
            this.pg_Movements.Controls.Add(this.bn_MovementList);
            this.pg_Movements.Controls.Add(this.kryptonPanel4);
            this.pg_Movements.Flags = 65534;
            this.pg_Movements.LastVisibleSet = true;
            this.pg_Movements.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Movements.Name = "pg_Movements";
            this.pg_Movements.Size = new System.Drawing.Size(1282, 520);
            this.pg_Movements.Text = "Movements";
            this.pg_Movements.ToolTipTitle = "Page ToolTip";
            this.pg_Movements.UniqueName = "5D334FC2014744A2D383125A1FED036C";
            // 
            // gv_MovementList
            // 
            this.gv_MovementList.AllowUserToAddRows = false;
            this.gv_MovementList.AllowUserToDeleteRows = false;
            this.gv_MovementList.AllowUserToOrderColumns = true;
            this.gv_MovementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_MovementList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_mfromlabel,
            this.cn_mtolabel,
            this.cn_mname,
            this.cn_mdocdate,
            this.cn_martid,
            this.cn_marticle,
            this.cn_mtype,
            this.cn_moperation,
            this.cn_mqty,
            this.cn_munit,
            this.cn_munitprice,
            this.cn_mbatch,
            this.cn_mplacefrom,
            this.cn_mPlaceto,
            this.cn_mcomments,
            this.cn_mcreatedat,
            this.cn_mcreatedby,
            this.cn_mtotal,
            this.cn_mcountryoforigin});
            this.gv_MovementList.ContextMenuStrip = this.mnu_MovementLines;
            this.gv_MovementList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_MovementList.Location = new System.Drawing.Point(0, 49);
            this.gv_MovementList.Name = "gv_MovementList";
            this.gv_MovementList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_MovementList.ReadOnly = true;
            this.gv_MovementList.RowHeadersWidth = 20;
            this.gv_MovementList.Size = new System.Drawing.Size(1282, 446);
            this.gv_MovementList.TabIndex = 22;
            // 
            // cn_mfromlabel
            // 
            this.cn_mfromlabel.DataPropertyName = "labelfrom";
            this.cn_mfromlabel.FillWeight = 80F;
            this.cn_mfromlabel.HeaderText = "From label";
            this.cn_mfromlabel.Name = "cn_mfromlabel";
            this.cn_mfromlabel.ReadOnly = true;
            this.cn_mfromlabel.Width = 80;
            // 
            // cn_mtolabel
            // 
            this.cn_mtolabel.DataPropertyName = "labelto";
            this.cn_mtolabel.FillWeight = 80F;
            this.cn_mtolabel.HeaderText = "To label";
            this.cn_mtolabel.Name = "cn_mtolabel";
            this.cn_mtolabel.ReadOnly = true;
            this.cn_mtolabel.Width = 80;
            // 
            // cn_mname
            // 
            this.cn_mname.DataPropertyName = "name";
            this.cn_mname.FillWeight = 110F;
            this.cn_mname.HeaderText = "Move doc.";
            this.cn_mname.Name = "cn_mname";
            this.cn_mname.ReadOnly = true;
            this.cn_mname.Width = 110;
            // 
            // cn_mdocdate
            // 
            this.cn_mdocdate.DataPropertyName = "docdate";
            this.cn_mdocdate.FillWeight = 90F;
            this.cn_mdocdate.HeaderText = "Doc. date";
            this.cn_mdocdate.Name = "cn_mdocdate";
            this.cn_mdocdate.ReadOnly = true;
            this.cn_mdocdate.Width = 90;
            // 
            // cn_martid
            // 
            this.cn_martid.DataPropertyName = "artid";
            this.cn_martid.FillWeight = 80F;
            this.cn_martid.HeaderText = "Art. id";
            this.cn_martid.Name = "cn_martid";
            this.cn_martid.ReadOnly = true;
            this.cn_martid.Width = 80;
            // 
            // cn_marticle
            // 
            this.cn_marticle.DataPropertyName = "article";
            this.cn_marticle.FillWeight = 200F;
            this.cn_marticle.HeaderText = "Article";
            this.cn_marticle.Name = "cn_marticle";
            this.cn_marticle.ReadOnly = true;
            this.cn_marticle.Width = 200;
            // 
            // cn_mtype
            // 
            this.cn_mtype.DataPropertyName = "type";
            this.cn_mtype.HeaderText = "Type";
            this.cn_mtype.Name = "cn_mtype";
            this.cn_mtype.ReadOnly = true;
            // 
            // cn_moperation
            // 
            this.cn_moperation.DataPropertyName = "operation";
            this.cn_moperation.HeaderText = "Operation";
            this.cn_moperation.Name = "cn_moperation";
            this.cn_moperation.ReadOnly = true;
            // 
            // cn_mqty
            // 
            this.cn_mqty.DataPropertyName = "qty";
            this.cn_mqty.FillWeight = 80F;
            this.cn_mqty.HeaderText = "Qty";
            this.cn_mqty.Name = "cn_mqty";
            this.cn_mqty.ReadOnly = true;
            this.cn_mqty.Width = 80;
            // 
            // cn_munit
            // 
            this.cn_munit.DataPropertyName = "unit";
            this.cn_munit.FillWeight = 40F;
            this.cn_munit.HeaderText = "Unit";
            this.cn_munit.Name = "cn_munit";
            this.cn_munit.ReadOnly = true;
            this.cn_munit.Width = 40;
            // 
            // cn_munitprice
            // 
            this.cn_munitprice.DataPropertyName = "unitprice";
            this.cn_munitprice.HeaderText = "Unit price (BR)";
            this.cn_munitprice.Name = "cn_munitprice";
            this.cn_munitprice.ReadOnly = true;
            // 
            // cn_mbatch
            // 
            this.cn_mbatch.DataPropertyName = "batch";
            this.cn_mbatch.HeaderText = "Batch";
            this.cn_mbatch.Name = "cn_mbatch";
            this.cn_mbatch.ReadOnly = true;
            // 
            // cn_mplacefrom
            // 
            this.cn_mplacefrom.DataPropertyName = "placefrom";
            this.cn_mplacefrom.FillWeight = 220F;
            this.cn_mplacefrom.HeaderText = "Place from";
            this.cn_mplacefrom.Name = "cn_mplacefrom";
            this.cn_mplacefrom.ReadOnly = true;
            this.cn_mplacefrom.Width = 220;
            // 
            // cn_mPlaceto
            // 
            this.cn_mPlaceto.DataPropertyName = "placeto";
            this.cn_mPlaceto.FillWeight = 220F;
            this.cn_mPlaceto.HeaderText = "Place to";
            this.cn_mPlaceto.Name = "cn_mPlaceto";
            this.cn_mPlaceto.ReadOnly = true;
            this.cn_mPlaceto.Width = 220;
            // 
            // cn_mcomments
            // 
            this.cn_mcomments.DataPropertyName = "comments";
            this.cn_mcomments.FillWeight = 150F;
            this.cn_mcomments.HeaderText = "Comments";
            this.cn_mcomments.Name = "cn_mcomments";
            this.cn_mcomments.ReadOnly = true;
            this.cn_mcomments.Width = 150;
            // 
            // cn_mcreatedat
            // 
            this.cn_mcreatedat.DataPropertyName = "createdat";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.cn_mcreatedat.DefaultCellStyle = dataGridViewCellStyle3;
            this.cn_mcreatedat.FillWeight = 85F;
            this.cn_mcreatedat.HeaderText = "Created at";
            this.cn_mcreatedat.Name = "cn_mcreatedat";
            this.cn_mcreatedat.ReadOnly = true;
            this.cn_mcreatedat.Width = 85;
            // 
            // cn_mcreatedby
            // 
            this.cn_mcreatedby.DataPropertyName = "createdby";
            this.cn_mcreatedby.HeaderText = "Created by";
            this.cn_mcreatedby.Name = "cn_mcreatedby";
            this.cn_mcreatedby.ReadOnly = true;
            // 
            // cn_mtotal
            // 
            this.cn_mtotal.DataPropertyName = "total";
            this.cn_mtotal.HeaderText = "Total (BR)";
            this.cn_mtotal.Name = "cn_mtotal";
            this.cn_mtotal.ReadOnly = true;
            // 
            // cn_mcountryoforigin
            // 
            this.cn_mcountryoforigin.DataPropertyName = "countryoforigin";
            this.cn_mcountryoforigin.HeaderText = "Country of origin";
            this.cn_mcountryoforigin.Name = "cn_mcountryoforigin";
            this.cn_mcountryoforigin.ReadOnly = true;
            // 
            // bn_MovementList
            // 
            this.bn_MovementList.AddNewItem = null;
            this.bn_MovementList.CountItem = this.toolStripLabel2;
            this.bn_MovementList.DeleteItem = null;
            this.bn_MovementList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_MovementList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_MovementList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator7,
            this.toolStripTextBox4,
            this.toolStripLabel2,
            this.toolStripSeparator8,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripSeparator9,
            this.btn_ExcelM});
            this.bn_MovementList.Location = new System.Drawing.Point(0, 495);
            this.bn_MovementList.MoveFirstItem = this.toolStripButton6;
            this.bn_MovementList.MoveLastItem = this.toolStripButton9;
            this.bn_MovementList.MoveNextItem = this.toolStripButton8;
            this.bn_MovementList.MovePreviousItem = this.toolStripButton7;
            this.bn_MovementList.Name = "bn_MovementList";
            this.bn_MovementList.PositionItem = this.toolStripTextBox4;
            this.bn_MovementList.Size = new System.Drawing.Size(1282, 25);
            this.bn_MovementList.TabIndex = 20;
            this.bn_MovementList.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move first";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move previous";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.AccessibleName = "Position";
            this.toolStripTextBox4.AutoSize = false;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox4.Text = "0";
            this.toolStripTextBox4.ToolTipText = "Current position";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move next";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Move last";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ExcelM
            // 
            this.btn_ExcelM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelM.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExcelM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelM.Name = "btn_ExcelM";
            this.btn_ExcelM.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelM.Text = "Export into excel";
            this.btn_ExcelM.Click += new System.EventHandler(this.btn_ExcelM_Click);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel4.Controls.Add(this.txt_TotalMovements);
            this.kryptonPanel4.Controls.Add(this.kryptonButton8);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(1282, 49);
            this.kryptonPanel4.TabIndex = 7;
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(176, 15);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel13.TabIndex = 27;
            this.kryptonLabel13.Values.Text = "Total (BR):";
            // 
            // txt_TotalMovements
            // 
            this.txt_TotalMovements.AllowDecimalSeparator = true;
            this.txt_TotalMovements.AllowSpace = false;
            this.txt_TotalMovements.Location = new System.Drawing.Point(239, 15);
            this.txt_TotalMovements.Name = "txt_TotalMovements";
            this.txt_TotalMovements.Size = new System.Drawing.Size(124, 21);
            this.txt_TotalMovements.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_TotalMovements.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalMovements.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_TotalMovements.TabIndex = 26;
            this.txt_TotalMovements.Text = "0";
            // 
            // kryptonButton8
            // 
            this.kryptonButton8.Location = new System.Drawing.Point(4, 5);
            this.kryptonButton8.Name = "kryptonButton8";
            this.kryptonButton8.Size = new System.Drawing.Size(109, 39);
            this.kryptonButton8.TabIndex = 6;
            this.kryptonButton8.Values.Image = global::Odin.Global_Resourses.emblem_library_9156;
            this.kryptonButton8.Values.Text = "History";
            this.kryptonButton8.Visible = false;
            // 
            // pg_Returns
            // 
            this.pg_Returns.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Returns.Controls.Add(this.gv_ReturnsList);
            this.pg_Returns.Controls.Add(this.bn_ReturnsList);
            this.pg_Returns.Controls.Add(this.kryptonPanel7);
            this.pg_Returns.Flags = 65534;
            this.pg_Returns.LastVisibleSet = true;
            this.pg_Returns.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Returns.Name = "pg_Returns";
            this.pg_Returns.Size = new System.Drawing.Size(1282, 520);
            this.pg_Returns.Text = "Returns";
            this.pg_Returns.ToolTipTitle = "Page ToolTip";
            this.pg_Returns.UniqueName = "C524233D6BA44C0B3F8269DF87FEA2C2";
            // 
            // gv_ReturnsList
            // 
            this.gv_ReturnsList.AllowUserToAddRows = false;
            this.gv_ReturnsList.AllowUserToDeleteRows = false;
            this.gv_ReturnsList.AllowUserToOrderColumns = true;
            this.gv_ReturnsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_ReturnsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_rid,
            this.cn_rlabel,
            this.cn_rartid,
            this.cn_rarticle,
            this.cn_rbatch,
            this.cn_rqty,
            this.cn_runit,
            this.cn_runitprice,
            this.cn_rtotal,
            this.cn_rcreatedat,
            this.cn_rcreatedby,
            this.cn_rname,
            this.cn_rdocdate,
            this.cn_rplace,
            this.dataGridViewTextBoxColumn19,
            this.cn_rcountryoforigin,
            this.cn_operationin,
            this.dataGridViewTextBoxColumn10});
            this.gv_ReturnsList.ContextMenuStrip = this.mnu_ReturnsLines;
            this.gv_ReturnsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_ReturnsList.Location = new System.Drawing.Point(0, 49);
            this.gv_ReturnsList.Name = "gv_ReturnsList";
            this.gv_ReturnsList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_ReturnsList.ReadOnly = true;
            this.gv_ReturnsList.RowHeadersWidth = 20;
            this.gv_ReturnsList.Size = new System.Drawing.Size(1282, 446);
            this.gv_ReturnsList.TabIndex = 22;
            // 
            // cn_rid
            // 
            this.cn_rid.DataPropertyName = "id";
            this.cn_rid.HeaderText = "id";
            this.cn_rid.Name = "cn_rid";
            this.cn_rid.ReadOnly = true;
            this.cn_rid.Visible = false;
            // 
            // cn_rlabel
            // 
            this.cn_rlabel.DataPropertyName = "label";
            this.cn_rlabel.HeaderText = "Label";
            this.cn_rlabel.Name = "cn_rlabel";
            this.cn_rlabel.ReadOnly = true;
            // 
            // cn_rartid
            // 
            this.cn_rartid.DataPropertyName = "artid";
            this.cn_rartid.FillWeight = 80F;
            this.cn_rartid.HeaderText = "Art. id";
            this.cn_rartid.Name = "cn_rartid";
            this.cn_rartid.ReadOnly = true;
            this.cn_rartid.Width = 80;
            // 
            // cn_rarticle
            // 
            this.cn_rarticle.DataPropertyName = "article";
            this.cn_rarticle.FillWeight = 200F;
            this.cn_rarticle.HeaderText = "Article";
            this.cn_rarticle.Name = "cn_rarticle";
            this.cn_rarticle.ReadOnly = true;
            this.cn_rarticle.Width = 200;
            // 
            // cn_rbatch
            // 
            this.cn_rbatch.DataPropertyName = "batch";
            this.cn_rbatch.HeaderText = "Batch";
            this.cn_rbatch.Name = "cn_rbatch";
            this.cn_rbatch.ReadOnly = true;
            // 
            // cn_rqty
            // 
            this.cn_rqty.DataPropertyName = "qty";
            this.cn_rqty.FillWeight = 80F;
            this.cn_rqty.HeaderText = "Qty";
            this.cn_rqty.Name = "cn_rqty";
            this.cn_rqty.ReadOnly = true;
            this.cn_rqty.Width = 80;
            // 
            // cn_runit
            // 
            this.cn_runit.DataPropertyName = "unit";
            this.cn_runit.FillWeight = 40F;
            this.cn_runit.HeaderText = "Unit";
            this.cn_runit.Name = "cn_runit";
            this.cn_runit.ReadOnly = true;
            this.cn_runit.Width = 40;
            // 
            // cn_runitprice
            // 
            this.cn_runitprice.DataPropertyName = "unitprice";
            this.cn_runitprice.HeaderText = "Unit price (BR)";
            this.cn_runitprice.Name = "cn_runitprice";
            this.cn_runitprice.ReadOnly = true;
            // 
            // cn_rtotal
            // 
            this.cn_rtotal.DataPropertyName = "total";
            this.cn_rtotal.HeaderText = "Total";
            this.cn_rtotal.Name = "cn_rtotal";
            this.cn_rtotal.ReadOnly = true;
            // 
            // cn_rcreatedat
            // 
            this.cn_rcreatedat.DataPropertyName = "createdat";
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = null;
            this.cn_rcreatedat.DefaultCellStyle = dataGridViewCellStyle4;
            this.cn_rcreatedat.FillWeight = 115F;
            this.cn_rcreatedat.HeaderText = "Returned at";
            this.cn_rcreatedat.Name = "cn_rcreatedat";
            this.cn_rcreatedat.ReadOnly = true;
            this.cn_rcreatedat.Width = 115;
            // 
            // cn_rcreatedby
            // 
            this.cn_rcreatedby.DataPropertyName = "createdby";
            this.cn_rcreatedby.HeaderText = "Returned by";
            this.cn_rcreatedby.Name = "cn_rcreatedby";
            this.cn_rcreatedby.ReadOnly = true;
            // 
            // cn_rname
            // 
            this.cn_rname.DataPropertyName = "name";
            this.cn_rname.HeaderText = "Outcome doc.";
            this.cn_rname.Name = "cn_rname";
            this.cn_rname.ReadOnly = true;
            // 
            // cn_rdocdate
            // 
            this.cn_rdocdate.DataPropertyName = "docdate";
            this.cn_rdocdate.FillWeight = 90F;
            this.cn_rdocdate.HeaderText = "Outcome date";
            this.cn_rdocdate.Name = "cn_rdocdate";
            this.cn_rdocdate.ReadOnly = true;
            this.cn_rdocdate.Width = 90;
            // 
            // cn_rplace
            // 
            this.cn_rplace.DataPropertyName = "place";
            this.cn_rplace.FillWeight = 150F;
            this.cn_rplace.HeaderText = "Place";
            this.cn_rplace.Name = "cn_rplace";
            this.cn_rplace.ReadOnly = true;
            this.cn_rplace.Width = 150;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "comments";
            this.dataGridViewTextBoxColumn19.FillWeight = 150F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // cn_rcountryoforigin
            // 
            this.cn_rcountryoforigin.DataPropertyName = "countryoforigin";
            this.cn_rcountryoforigin.HeaderText = "Country of origin";
            this.cn_rcountryoforigin.Name = "cn_rcountryoforigin";
            this.cn_rcountryoforigin.ReadOnly = true;
            // 
            // cn_operationin
            // 
            this.cn_operationin.DataPropertyName = "operationin";
            this.cn_operationin.HeaderText = "Income type";
            this.cn_operationin.Name = "cn_operationin";
            this.cn_operationin.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn10.HeaderText = "Type";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // bn_ReturnsList
            // 
            this.bn_ReturnsList.AddNewItem = null;
            this.bn_ReturnsList.CountItem = this.toolStripLabel5;
            this.bn_ReturnsList.DeleteItem = null;
            this.bn_ReturnsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_ReturnsList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_ReturnsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator18,
            this.toolStripTextBox5,
            this.toolStripLabel5,
            this.toolStripSeparator19,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator20,
            this.btn_ExcelR});
            this.bn_ReturnsList.Location = new System.Drawing.Point(0, 495);
            this.bn_ReturnsList.MoveFirstItem = this.toolStripButton17;
            this.bn_ReturnsList.MoveLastItem = this.toolStripButton20;
            this.bn_ReturnsList.MoveNextItem = this.toolStripButton19;
            this.bn_ReturnsList.MovePreviousItem = this.toolStripButton18;
            this.bn_ReturnsList.Name = "bn_ReturnsList";
            this.bn_ReturnsList.PositionItem = this.toolStripTextBox5;
            this.bn_ReturnsList.Size = new System.Drawing.Size(1282, 25);
            this.bn_ReturnsList.TabIndex = 21;
            this.bn_ReturnsList.Text = "Returns";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "of {0}";
            this.toolStripLabel5.ToolTipText = "Total number of items";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "Move first";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "Move previous";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.AccessibleName = "Position";
            this.toolStripTextBox5.AutoSize = false;
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox5.Text = "0";
            this.toolStripTextBox5.ToolTipText = "Current position";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.RightToLeftAutoMirrorImage = true;
            this.toolStripButton19.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton19.Text = "Move next";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton20.Text = "Move last";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ExcelR
            // 
            this.btn_ExcelR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelR.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExcelR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelR.Name = "btn_ExcelR";
            this.btn_ExcelR.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelR.Text = "Export into excel";
            this.btn_ExcelR.Click += new System.EventHandler(this.btn_ExcelR_Click);
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel7.Controls.Add(this.txt_TotalReturns);
            this.kryptonPanel7.Controls.Add(this.kryptonButton1);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(1282, 49);
            this.kryptonPanel7.TabIndex = 8;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(176, 15);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel10.TabIndex = 27;
            this.kryptonLabel10.Values.Text = "Total (€):";
            // 
            // txt_TotalReturns
            // 
            this.txt_TotalReturns.AllowDecimalSeparator = true;
            this.txt_TotalReturns.AllowSpace = false;
            this.txt_TotalReturns.Location = new System.Drawing.Point(239, 15);
            this.txt_TotalReturns.Name = "txt_TotalReturns";
            this.txt_TotalReturns.Size = new System.Drawing.Size(124, 21);
            this.txt_TotalReturns.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_TotalReturns.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_TotalReturns.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_TotalReturns.TabIndex = 26;
            this.txt_TotalReturns.Text = "0";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(4, 5);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(109, 39);
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Image = global::Odin.Global_Resourses.emblem_library_9156;
            this.kryptonButton1.Values.Text = "History";
            this.kryptonButton1.Visible = false;
            // 
            // pg_Tracing
            // 
            this.pg_Tracing.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Tracing.Controls.Add(this.gv_TracingList);
            this.pg_Tracing.Controls.Add(this.bn_TracingList);
            this.pg_Tracing.Controls.Add(this.kryptonPanel5);
            this.pg_Tracing.Flags = 65534;
            this.pg_Tracing.LastVisibleSet = true;
            this.pg_Tracing.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Tracing.Name = "pg_Tracing";
            this.pg_Tracing.Size = new System.Drawing.Size(1282, 520);
            this.pg_Tracing.Text = "Tracing";
            this.pg_Tracing.ToolTipTitle = "Page ToolTip";
            this.pg_Tracing.UniqueName = "C23EB652E4424BB2B6B5696532AEF61B";
            this.pg_Tracing.Visible = false;
            // 
            // gv_TracingList
            // 
            this.gv_TracingList.AllowUserToAddRows = false;
            this.gv_TracingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_TracingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33});
            this.gv_TracingList.ContextMenuStrip = this.mnu_MovementLines;
            this.gv_TracingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_TracingList.Location = new System.Drawing.Point(0, 49);
            this.gv_TracingList.Name = "gv_TracingList";
            this.gv_TracingList.RowHeadersWidth = 25;
            this.gv_TracingList.Size = new System.Drawing.Size(1282, 446);
            this.gv_TracingList.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn23.FillWeight = 5F;
            this.dataGridViewTextBoxColumn23.HeaderText = "id";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            this.dataGridViewTextBoxColumn23.Width = 5;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "headid";
            this.dataGridViewTextBoxColumn24.HeaderText = "headid";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "artid";
            this.dataGridViewTextBoxColumn25.FillWeight = 80F;
            this.dataGridViewTextBoxColumn25.HeaderText = "Art. id";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 80;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn26.FillWeight = 130F;
            this.dataGridViewTextBoxColumn26.HeaderText = "Article";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 130;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn27.FillWeight = 80F;
            this.dataGridViewTextBoxColumn27.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 80;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "qtyold";
            this.dataGridViewTextBoxColumn28.HeaderText = "qtyold";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Visible = false;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "unit";
            this.dataGridViewTextBoxColumn29.FillWeight = 40F;
            this.dataGridViewTextBoxColumn29.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 40;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "unitprice";
            this.dataGridViewTextBoxColumn30.FillWeight = 80F;
            this.dataGridViewTextBoxColumn30.HeaderText = "Unit price";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 80;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "incomedoc";
            this.dataGridViewTextBoxColumn31.FillWeight = 110F;
            this.dataGridViewTextBoxColumn31.HeaderText = "Income doc.";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 110;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "regdate";
            this.dataGridViewTextBoxColumn32.HeaderText = "Reg. date";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "supplier";
            this.dataGridViewTextBoxColumn33.FillWeight = 130F;
            this.dataGridViewTextBoxColumn33.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 130;
            // 
            // bn_TracingList
            // 
            this.bn_TracingList.AddNewItem = null;
            this.bn_TracingList.CountItem = this.toolStripLabel3;
            this.bn_TracingList.DeleteItem = null;
            this.bn_TracingList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_TracingList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_TracingList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton10,
            this.toolStripSeparator10,
            this.toolStripTextBox1,
            this.toolStripLabel3,
            this.toolStripSeparator11,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripSeparator12,
            this.btn_ExcelT});
            this.bn_TracingList.Location = new System.Drawing.Point(0, 495);
            this.bn_TracingList.MoveFirstItem = this.toolStripButton5;
            this.bn_TracingList.MoveLastItem = this.toolStripButton12;
            this.bn_TracingList.MoveNextItem = this.toolStripButton11;
            this.bn_TracingList.MovePreviousItem = this.toolStripButton10;
            this.bn_TracingList.Name = "bn_TracingList";
            this.bn_TracingList.PositionItem = this.toolStripTextBox1;
            this.bn_TracingList.Size = new System.Drawing.Size(1282, 25);
            this.bn_TracingList.TabIndex = 23;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "of {0}";
            this.toolStripLabel3.ToolTipText = "Total number of items";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move first";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move previous";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move next";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move last";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ExcelT
            // 
            this.btn_ExcelT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelT.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExcelT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelT.Name = "btn_ExcelT";
            this.btn_ExcelT.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelT.Text = "Export into excel";
            this.btn_ExcelT.Click += new System.EventHandler(this.btn_ExcelT_Click);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel5.Controls.Add(this.txt_Label);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(1282, 49);
            this.kryptonPanel5.TabIndex = 22;
            this.kryptonPanel5.Visible = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 14);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel3.TabIndex = 287;
            this.kryptonLabel3.Values.Text = "Label:";
            // 
            // txt_Label
            // 
            this.txt_Label.AllowDecimalSeparator = false;
            this.txt_Label.AllowSpace = false;
            this.txt_Label.Location = new System.Drawing.Point(95, 15);
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.Size = new System.Drawing.Size(100, 23);
            this.txt_Label.TabIndex = 286;
            this.txt_Label.Text = "0";
            // 
            // pg_Cost
            // 
            this.pg_Cost.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pg_Cost.Controls.Add(this.gv_CostList);
            this.pg_Cost.Controls.Add(this.kryptonPanel6);
            this.pg_Cost.Controls.Add(this.bn_CostList);
            this.pg_Cost.Flags = 65534;
            this.pg_Cost.LastVisibleSet = true;
            this.pg_Cost.MinimumSize = new System.Drawing.Size(50, 50);
            this.pg_Cost.Name = "pg_Cost";
            this.pg_Cost.Size = new System.Drawing.Size(1282, 520);
            this.pg_Cost.Text = "Production cost";
            this.pg_Cost.ToolTipTitle = "Page ToolTip";
            this.pg_Cost.UniqueName = "E4092347B37F43BCEA94D370CC4FCC28";
            // 
            // gv_CostList
            // 
            this.gv_CostList.AllowUserToAddRows = false;
            this.gv_CostList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_CostList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_cid,
            this.chk_use,
            this.cn_cname,
            this.cn_cartid,
            this.cn_carticle,
            this.cn_cqty,
            this.cn_cunit,
            this.cn_cunitprice,
            this.cn_csupplier,
            this.cn_csuparticle,
            this.cn_cdelivnote,
            this.cn_clabel,
            this.cn_ctotal,
            this.cn_isreturn,
            this.cn_setdoc,
            this.cn_crequest,
            this.cn_ccustcode});
            this.gv_CostList.ContextMenuStrip = this.mnu_CostLines;
            this.gv_CostList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_CostList.Location = new System.Drawing.Point(0, 49);
            this.gv_CostList.Name = "gv_CostList";
            this.gv_CostList.RowHeadersWidth = 25;
            this.gv_CostList.Size = new System.Drawing.Size(1282, 446);
            this.gv_CostList.TabIndex = 23;
            this.gv_CostList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CostList_CellContentClick);
            // 
            // cn_cid
            // 
            this.cn_cid.DataPropertyName = "id";
            this.cn_cid.HeaderText = "id";
            this.cn_cid.Name = "cn_cid";
            this.cn_cid.Visible = false;
            // 
            // chk_use
            // 
            this.chk_use.DataPropertyName = "checkuse";
            this.chk_use.FalseValue = "0";
            this.chk_use.FillWeight = 30F;
            this.chk_use.HeaderText = "Use";
            this.chk_use.IndeterminateValue = "1";
            this.chk_use.Name = "chk_use";
            this.chk_use.TrueValue = "-1";
            this.chk_use.Width = 30;
            // 
            // cn_cname
            // 
            this.cn_cname.DataPropertyName = "name";
            this.cn_cname.HeaderText = "Out. doc";
            this.cn_cname.Name = "cn_cname";
            // 
            // cn_cartid
            // 
            this.cn_cartid.DataPropertyName = "artid";
            this.cn_cartid.FillWeight = 70F;
            this.cn_cartid.HeaderText = "Art. id";
            this.cn_cartid.Name = "cn_cartid";
            this.cn_cartid.Width = 70;
            // 
            // cn_carticle
            // 
            this.cn_carticle.DataPropertyName = "article";
            this.cn_carticle.FillWeight = 150F;
            this.cn_carticle.HeaderText = "Article";
            this.cn_carticle.Name = "cn_carticle";
            this.cn_carticle.Width = 150;
            // 
            // cn_cqty
            // 
            this.cn_cqty.DataPropertyName = "qty";
            this.cn_cqty.FillWeight = 70F;
            this.cn_cqty.HeaderText = "Qty";
            this.cn_cqty.Name = "cn_cqty";
            this.cn_cqty.Width = 70;
            // 
            // cn_cunit
            // 
            this.cn_cunit.DataPropertyName = "unit";
            this.cn_cunit.FillWeight = 40F;
            this.cn_cunit.HeaderText = "Unit";
            this.cn_cunit.Name = "cn_cunit";
            this.cn_cunit.Width = 40;
            // 
            // cn_cunitprice
            // 
            this.cn_cunitprice.DataPropertyName = "unitprice";
            this.cn_cunitprice.FillWeight = 80F;
            this.cn_cunitprice.HeaderText = "Unit price (BR)";
            this.cn_cunitprice.Name = "cn_cunitprice";
            this.cn_cunitprice.Width = 80;
            // 
            // cn_csupplier
            // 
            this.cn_csupplier.DataPropertyName = "supplier";
            this.cn_csupplier.HeaderText = "Supplier";
            this.cn_csupplier.Name = "cn_csupplier";
            // 
            // cn_csuparticle
            // 
            this.cn_csuparticle.DataPropertyName = "suparticle";
            this.cn_csuparticle.HeaderText = "Sup. article";
            this.cn_csuparticle.Name = "cn_csuparticle";
            // 
            // cn_cdelivnote
            // 
            this.cn_cdelivnote.DataPropertyName = "delivnote";
            this.cn_cdelivnote.HeaderText = "Deliv. note";
            this.cn_cdelivnote.Name = "cn_cdelivnote";
            // 
            // cn_clabel
            // 
            this.cn_clabel.DataPropertyName = "label";
            this.cn_clabel.HeaderText = "Label";
            this.cn_clabel.Name = "cn_clabel";
            // 
            // cn_ctotal
            // 
            this.cn_ctotal.DataPropertyName = "total";
            this.cn_ctotal.FillWeight = 90F;
            this.cn_ctotal.HeaderText = "Total";
            this.cn_ctotal.Name = "cn_ctotal";
            this.cn_ctotal.Width = 90;
            // 
            // cn_isreturn
            // 
            this.cn_isreturn.DataPropertyName = "isreturn";
            this.cn_isreturn.HeaderText = "Return";
            this.cn_isreturn.Name = "cn_isreturn";
            this.cn_isreturn.Visible = false;
            // 
            // cn_setdoc
            // 
            this.cn_setdoc.DataPropertyName = "setdoc";
            this.cn_setdoc.HeaderText = "FP doc.";
            this.cn_setdoc.Name = "cn_setdoc";
            // 
            // cn_crequest
            // 
            this.cn_crequest.DataPropertyName = "request";
            this.cn_crequest.HeaderText = "Request";
            this.cn_crequest.Name = "cn_crequest";
            // 
            // cn_ccustcode
            // 
            this.cn_ccustcode.DataPropertyName = "custcode";
            this.cn_ccustcode.HeaderText = "Cust. code";
            this.cn_ccustcode.Name = "cn_ccustcode";
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.btn_awaitingcost2);
            this.kryptonPanel6.Controls.Add(this.btn_bomcost1);
            this.kryptonPanel6.Controls.Add(this.chk_ExcludeA);
            this.kryptonPanel6.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel6.Controls.Add(this.lbl_COPrice);
            this.kryptonPanel6.Controls.Add(this.txt_BOMCost);
            this.kryptonPanel6.Controls.Add(this.txt_COPrice);
            this.kryptonPanel6.Controls.Add(this.chk_GroupByDoc);
            this.kryptonPanel6.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel6.Controls.Add(this.txt_Total);
            this.kryptonPanel6.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel6.Controls.Add(this.txt_QtyIn);
            this.kryptonPanel6.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel6.Controls.Add(this.txt_CostPrice);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(1282, 49);
            this.kryptonPanel6.TabIndex = 22;
            // 
            // btn_awaitingcost2
            // 
            this.btn_awaitingcost2.Location = new System.Drawing.Point(1196, 11);
            this.btn_awaitingcost2.Name = "btn_awaitingcost2";
            this.btn_awaitingcost2.Size = new System.Drawing.Size(46, 25);
            this.btn_awaitingcost2.TabIndex = 29;
            this.btn_awaitingcost2.Values.Image = global::Odin.Global_Resourses.coins1;
            this.btn_awaitingcost2.Values.Text = "";
            this.btn_awaitingcost2.Click += new System.EventHandler(this.btn_AwaitingCost_Click);
            // 
            // btn_bomcost1
            // 
            this.btn_bomcost1.Location = new System.Drawing.Point(1144, 11);
            this.btn_bomcost1.Name = "btn_bomcost1";
            this.btn_bomcost1.Size = new System.Drawing.Size(46, 25);
            this.btn_bomcost1.TabIndex = 28;
            this.btn_bomcost1.Values.Image = global::Odin.Global_Resourses.list16x16;
            this.btn_bomcost1.Values.Text = "";
            this.btn_bomcost1.Click += new System.EventHandler(this.btn_showcostdets_Click);
            // 
            // chk_ExcludeA
            // 
            this.chk_ExcludeA.Location = new System.Drawing.Point(151, 14);
            this.chk_ExcludeA.Name = "chk_ExcludeA";
            this.chk_ExcludeA.Size = new System.Drawing.Size(114, 20);
            this.chk_ExcludeA.TabIndex = 27;
            this.chk_ExcludeA.Values.Text = "Exclude projectA";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(947, 15);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(122, 20);
            this.kryptonLabel14.TabIndex = 21;
            this.kryptonLabel14.Values.Text = "BOM cost price (BR):";
            // 
            // lbl_COPrice
            // 
            this.lbl_COPrice.Location = new System.Drawing.Point(279, 14);
            this.lbl_COPrice.Name = "lbl_COPrice";
            this.lbl_COPrice.Size = new System.Drawing.Size(86, 20);
            this.lbl_COPrice.TabIndex = 26;
            this.lbl_COPrice.Values.Text = "CO price (BR):";
            // 
            // txt_BOMCost
            // 
            this.txt_BOMCost.AllowDecimalSeparator = true;
            this.txt_BOMCost.AllowSpace = false;
            this.txt_BOMCost.Location = new System.Drawing.Point(1065, 14);
            this.txt_BOMCost.Name = "txt_BOMCost";
            this.txt_BOMCost.Size = new System.Drawing.Size(73, 21);
            this.txt_BOMCost.StateActive.Content.Color1 = System.Drawing.Color.Fuchsia;
            this.txt_BOMCost.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_BOMCost.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_BOMCost.TabIndex = 20;
            this.txt_BOMCost.Text = "0";
            this.txt_BOMCost.DoubleClick += new System.EventHandler(this.txt_BOMCost_DoubleClick);
            this.txt_BOMCost.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_BOMCost_MouseDoubleClick);
            // 
            // txt_COPrice
            // 
            this.txt_COPrice.AllowDecimalSeparator = true;
            this.txt_COPrice.AllowSpace = false;
            this.txt_COPrice.Location = new System.Drawing.Point(378, 13);
            this.txt_COPrice.Name = "txt_COPrice";
            this.txt_COPrice.Size = new System.Drawing.Size(85, 21);
            this.txt_COPrice.StateActive.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_COPrice.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_COPrice.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_COPrice.TabIndex = 25;
            this.txt_COPrice.Text = "0";
            // 
            // chk_GroupByDoc
            // 
            this.chk_GroupByDoc.Checked = true;
            this.chk_GroupByDoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_GroupByDoc.Location = new System.Drawing.Point(12, 14);
            this.chk_GroupByDoc.Name = "chk_GroupByDoc";
            this.chk_GroupByDoc.Size = new System.Drawing.Size(133, 20);
            this.chk_GroupByDoc.TabIndex = 24;
            this.chk_GroupByDoc.Values.Text = "Group by document";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(792, 14);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel2.TabIndex = 23;
            this.kryptonLabel2.Values.Text = "Total (BR):";
            // 
            // txt_Total
            // 
            this.txt_Total.AllowDecimalSeparator = true;
            this.txt_Total.AllowSpace = false;
            this.txt_Total.Location = new System.Drawing.Point(855, 14);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(84, 21);
            this.txt_Total.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Total.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Total.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Total.TabIndex = 22;
            this.txt_Total.Text = "0";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(651, 14);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel5.TabIndex = 21;
            this.kryptonLabel5.Values.Text = "Qty in:";
            // 
            // txt_QtyIn
            // 
            this.txt_QtyIn.AllowDecimalSeparator = true;
            this.txt_QtyIn.AllowSpace = false;
            this.txt_QtyIn.Location = new System.Drawing.Point(703, 14);
            this.txt_QtyIn.Name = "txt_QtyIn";
            this.txt_QtyIn.Size = new System.Drawing.Size(62, 21);
            this.txt_QtyIn.StateActive.Content.Color1 = System.Drawing.Color.Green;
            this.txt_QtyIn.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyIn.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_QtyIn.TabIndex = 20;
            this.txt_QtyIn.Text = "0";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(469, 14);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel9.TabIndex = 19;
            this.kryptonLabel9.Values.Text = "Cost price (BR):";
            // 
            // txt_CostPrice
            // 
            this.txt_CostPrice.AllowDecimalSeparator = true;
            this.txt_CostPrice.AllowSpace = false;
            this.txt_CostPrice.Location = new System.Drawing.Point(560, 13);
            this.txt_CostPrice.Name = "txt_CostPrice";
            this.txt_CostPrice.Size = new System.Drawing.Size(85, 21);
            this.txt_CostPrice.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_CostPrice.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_CostPrice.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_CostPrice.TabIndex = 18;
            this.txt_CostPrice.Text = "0";
            // 
            // bn_CostList
            // 
            this.bn_CostList.AddNewItem = null;
            this.bn_CostList.CountItem = this.toolStripLabel4;
            this.bn_CostList.DeleteItem = null;
            this.bn_CostList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_CostList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_CostList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripSeparator14,
            this.toolStripTextBox2,
            this.toolStripLabel4,
            this.toolStripSeparator15,
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripSeparator16,
            this.btn_ExcelC});
            this.bn_CostList.Location = new System.Drawing.Point(0, 495);
            this.bn_CostList.MoveFirstItem = this.toolStripButton13;
            this.bn_CostList.MoveLastItem = this.toolStripButton16;
            this.bn_CostList.MoveNextItem = this.toolStripButton15;
            this.bn_CostList.MovePreviousItem = this.toolStripButton14;
            this.bn_CostList.Name = "bn_CostList";
            this.bn_CostList.PositionItem = this.toolStripTextBox2;
            this.bn_CostList.Size = new System.Drawing.Size(1282, 25);
            this.bn_CostList.TabIndex = 21;
            this.bn_CostList.Text = "bindingNavigator1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "of {0}";
            this.toolStripLabel4.ToolTipText = "Total number of items";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move first";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Move previous";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Move next";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "Move last";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_ExcelC
            // 
            this.btn_ExcelC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExcelC.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExcelC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcelC.Name = "btn_ExcelC";
            this.btn_ExcelC.Size = new System.Drawing.Size(23, 22);
            this.btn_ExcelC.Text = "Export into excel";
            this.btn_ExcelC.Click += new System.EventHandler(this.btn_ExcelC_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonDockableWorkspace1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1588, 93);
            this.kryptonPanel3.TabIndex = 6;
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.AutoScroll = true;
            this.kryptonDockableWorkspace1.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "3603EBC349EA4AA52F8724469FC85DA3";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(1588, 93);
            this.kryptonDockableWorkspace1.TabIndex = 7;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // btn_BOMDetails
            // 
            this.btn_BOMDetails.Image = global::Odin.Global_Resourses.list16x16;
            this.btn_BOMDetails.UniqueName = "7AE15EAFD5864A8EA6956FF047B2EAC1";
            this.btn_BOMDetails.Click += new System.EventHandler(this.btn_showcostdets_Click);
            // 
            // btn_AwaitingCost1
            // 
            this.btn_AwaitingCost1.Image = global::Odin.Global_Resourses.coins1;
            this.btn_AwaitingCost1.UniqueName = "D969AC740B4C49A39A97816967AB8E17";
            this.btn_AwaitingCost1.Click += new System.EventHandler(this.btn_AwaitingCost_Click);
            // 
            // btn_showcostdets
            // 
            this.btn_showcostdets.Image = global::Odin.Global_Resourses.list16x16;
            this.btn_showcostdets.UniqueName = "EBD3283BFF7B412512A4A6BB48387BF1";
            this.btn_showcostdets.Click += new System.EventHandler(this.btn_showcostdets_Click);
            // 
            // btn_AwaitingCost
            // 
            this.btn_AwaitingCost.Image = global::Odin.Global_Resourses.coins1;
            this.btn_AwaitingCost.UniqueName = "EDCA732E821046384D85C3730FBA73EB";
            this.btn_AwaitingCost.Click += new System.EventHandler(this.btn_AwaitingCost_Click);
            // 
            // frm_StockHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 645);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_StockHistory";
            this.TabText = "Stock history";
            this.Text = "Stock history";
            this.Load += new System.EventHandler(this.frm_StockHistory_Load);
            this.Resize += new System.EventHandler(this.frm_StockHistory_Resize);
            this.mnu_IncomeLines.ResumeLayout(false);
            this.mnu_IncomeLines.PerformLayout();
            this.mnu_OutcomeLines.ResumeLayout(false);
            this.mnu_OutcomeLines.PerformLayout();
            this.mnu_MovementLines.ResumeLayout(false);
            this.mnu_MovementLines.PerformLayout();
            this.mnu_TracingLines.ResumeLayout(false);
            this.mnu_TracingLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TracingList)).EndInit();
            this.mnu_CostLines.ResumeLayout(false);
            this.mnu_CostLines.PerformLayout();
            this.mnu_ReturnsLines.ResumeLayout(false);
            this.mnu_ReturnsLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Operation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dn_Pages)).EndInit();
            this.dn_Pages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pg_Incomes)).EndInit();
            this.pg_Incomes.ResumeLayout(false);
            this.pg_Incomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_IncomeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_IncomeList)).EndInit();
            this.bn_IncomeList.ResumeLayout(false);
            this.bn_IncomeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pg_Withdraw)).EndInit();
            this.pg_Withdraw.ResumeLayout(false);
            this.pg_Withdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_OutcomeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_OutcomeList)).EndInit();
            this.bn_OutcomeList.ResumeLayout(false);
            this.bn_OutcomeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Movements)).EndInit();
            this.pg_Movements.ResumeLayout(false);
            this.pg_Movements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MovementList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_MovementList)).EndInit();
            this.bn_MovementList.ResumeLayout(false);
            this.bn_MovementList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Returns)).EndInit();
            this.pg_Returns.ResumeLayout(false);
            this.pg_Returns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ReturnsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_ReturnsList)).EndInit();
            this.bn_ReturnsList.ResumeLayout(false);
            this.bn_ReturnsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            this.kryptonPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Tracing)).EndInit();
            this.pg_Tracing.ResumeLayout(false);
            this.pg_Tracing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TracingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_TracingList)).EndInit();
            this.bn_TracingList.ResumeLayout(false);
            this.bn_TracingList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pg_Cost)).EndInit();
            this.pg_Cost.ResumeLayout(false);
            this.pg_Cost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CostList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            this.kryptonPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_CostList)).EndInit();
            this.bn_CostList.ResumeLayout(false);
            this.bn_CostList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_IncomeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OutcomeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_MovementList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CostList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ReturnsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private CustomControls.NullableDateTimePicker txt_DateTill;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private CustomControls.NullableDateTimePicker txt_DateFrom;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Article;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Till;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_From;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Period;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Type;
        private CMB_Components.Types.cmb_Types cmb_Types1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Supplier;
        private CMB_Components.Companies.cmb_Firms cmb_Firms1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ContextMenuStrip mnu_IncomeLines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForI;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchI;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByI;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelI;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterI;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminI;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Operation;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator dn_Pages;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Incomes;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Withdraw;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Movements;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Tracing;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.BindingNavigator bn_IncomeList;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btn_ExcelI;
        private System.Windows.Forms.BindingNavigator bn_OutcomeList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_ExcelO;
        private System.Windows.Forms.BindingNavigator bn_MovementList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btn_ExcelM;
        private System.Windows.Forms.ContextMenuStrip mnu_OutcomeLines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForO;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchO;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByO;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelO;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterO;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminO;
        private System.Windows.Forms.ContextMenuStrip mnu_MovementLines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForM;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchM;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByM;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelM;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterM;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminM;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_PlaceTo;
        private CMB_Components.Places.cmb_Places cmb_Places2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_PO;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Rests;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_IncomeList;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Tracing;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_TracingList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.BindingNavigator bn_TracingList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btn_ExcelT;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private System.Windows.Forms.ContextMenuStrip mnu_TracingLines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForT;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByT;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelT;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterT;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminT;
        private System.Windows.Forms.BindingSource bs_TracingList;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_FirmsArt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_FirmArt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_Operation;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Owf.Controls.NumericTetxBox txt_Label;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Place;
        private CMB_Components.Places.cmb_Places cmb_Places1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_SalesOrders;
        private CMB_Components.SalesOrders.cmb_SalesOrders cmb_SalesOrders1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_OutcomeList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_MovementList;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Cost;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Owf.Controls.NumericTetxBox txt_Total;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Owf.Controls.NumericTetxBox txt_QtyIn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Owf.Controls.NumericTetxBox txt_CostPrice;
        private System.Windows.Forms.BindingNavigator bn_CostList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripButton btn_ExcelC;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_CostList;
        private System.Windows.Forms.ContextMenuStrip mnu_CostLines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForC;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchC;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByC;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterC;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminC;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_GroupByDoc;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_COPrice;
        private Owf.Controls.NumericTetxBox txt_COPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Owf.Controls.NumericTetxBox txt_TotalOutcomes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Owf.Controls.NumericTetxBox txt_TotalMovements;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Document;
        private CMB_Components.MoveDocs.cmb_MoveDocs cmb_MoveDocs1;
        private CMB_Components.OutcomeDocs.cmb_OutcomeDocs cmb_OutcomeDocs1;
        private CMB_Components.IncomeDocs.cmb_IncomeDoc cmb_IncomeDoc1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Owf.Controls.NumericTetxBox txt_BOMCost;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Navigator.KryptonPage pg_Returns;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_ReturnsList;
        private System.Windows.Forms.BindingNavigator bn_ReturnsList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripButton btn_ExcelR;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Owf.Controls.NumericTetxBox txt_TotalReturns;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ContextMenuStrip mnu_ReturnsLines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForR;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchR;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByR;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelR;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterR;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminR;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_showcostdets;
        private Global_Classes.SyncBindingSource bs_IncomeList;
        private Global_Classes.SyncBindingSource bs_OutcomeList;
        private Global_Classes.SyncBindingSource bs_MovementList;
        private Global_Classes.SyncBindingSource bs_CostList;
        private Global_Classes.SyncBindingSource bs_ReturnsList;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_AwaitingCost;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_ExcludeA;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_BOMDetails;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_AwaitingCost1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_awaitingcost2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_bomcost1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_groupbybatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mfromlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mtolabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mdocdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_martid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_marticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_moperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_munit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_munitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mplacefrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mPlaceto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mcreatedat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_mcountryoforigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_runit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_runitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rcreatedat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rcreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rdocdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rcountryoforigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_operationin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oheadid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_odelivdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_odocdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocustarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_otype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ooperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ounit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ounitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_obatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_orequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocustorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ototal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocustcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocreatat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocreatby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oset;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_countryoforigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_writeoffreason;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_olabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_osecname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_olaunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_incomedoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_incomedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_datacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_manufbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_carticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cunitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_csupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_csuparticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_cdelivnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_clabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ctotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isreturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_setdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_crequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ccustcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_regdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_docdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_supart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_itype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ioperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_supid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coefconv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totalvat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totalwithvat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitpriceeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totaleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totalvateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totalwithvateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pcesperunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_icountry;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Summary;
    }
}