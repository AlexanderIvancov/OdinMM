namespace Odin.Purchase
{
    partial class frm_NeedsProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NeedsProcessing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_NeedsList = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_AddNeeds = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_EditComments = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_CloseNeeds = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_DeleteNeeds = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_endcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.chk_active = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.tv_Details = new AdvancedDataGridView.TreeGridView();
            this.mnu_DLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_SearchD = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminD = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_Dets = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_addneeddet = new System.Windows.Forms.ToolStripButton();
            this.btn_EditNeed = new System.Windows.Forms.ToolStripButton();
            this.btn_addcatalog = new System.Windows.Forms.ToolStripButton();
            this.btn_Upload = new System.Windows.Forms.ToolStripButton();
            this.btn_Download = new System.Windows.Forms.ToolStripButton();
            this.btn_History = new System.Windows.Forms.ToolStripButton();
            this.btn_SendEmail = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btn_deleteneeddet = new System.Windows.Forms.ToolStripButton();
            this.kryptonSplitContainer3 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_POList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_print = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_headid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtydeliv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reqdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_suporder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bestbefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_catalogid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coefconv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_inprocess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_confdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_resale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_POLines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterForPO = new System.Windows.Forms.ToolStripTextBox();
            this.mni_SearchPO = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterByPO = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSelPO = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilterPO = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_CopyPO = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminPO = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_POList = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_DeletePOline = new System.Windows.Forms.ToolStripButton();
            this.btn_ExportPO = new System.Windows.Forms.ToolStripButton();
            this.kryptonHeaderGroup4 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.bs_POList = new Odin.Global_Classes.SyncBindingSource();
            this.bs_Dets = new Odin.Global_Classes.SyncBindingSource();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.attachmentColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cn_darticle = new AdvancedDataGridView.TreeGridColumn();
            this.cn_dartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dsecname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dsupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dqtyneed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_adddet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cn_dqtyinpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunitpricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ddatacode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ddelivterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dmoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dmpq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dmanufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_did = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcatid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_pocatid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_doldqtyinpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dtechmissings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcatdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyproject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_analogs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Details)).BeginInit();
            this.mnu_DLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Dets)).BeginInit();
            this.bn_Dets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel1)).BeginInit();
            this.kryptonSplitContainer3.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel2)).BeginInit();
            this.kryptonSplitContainer3.Panel2.SuspendLayout();
            this.kryptonSplitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_POList)).BeginInit();
            this.mnu_POLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_POList)).BeginInit();
            this.bn_POList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup4.Panel)).BeginInit();
            this.kryptonHeaderGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_POList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Dets)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonHeaderGroup1);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonSplitContainer2);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1804, 961);
            this.kryptonSplitContainer1.SplitterDistance = 288;
            this.kryptonSplitContainer1.TabIndex = 2;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.AllowButtonSpecToolTips = true;
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_Refresh,
            this.btn_NeedsList,
            this.btn_AddNeeds,
            this.btn_EditComments,
            this.btn_CloseNeeds,
            this.btn_DeleteNeeds});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_List);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(288, 961);
            this.kryptonHeaderGroup1.TabIndex = 1;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Needs";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.messagebox_warning;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Header of need";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.UniqueName = "012AF09007074B0D3281B75DF874AFBC";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_NeedsList
            // 
            this.btn_NeedsList.Image = global::Odin.Global_Resourses.table_go;
            this.btn_NeedsList.UniqueName = "B0BB9A6D6A41430D23982971463C0973";
            this.btn_NeedsList.Click += new System.EventHandler(this.btn_NeedsList_Click);
            // 
            // btn_AddNeeds
            // 
            this.btn_AddNeeds.Image = global::Odin.Global_Resourses.add_set;
            this.btn_AddNeeds.ToolTipTitle = "Add needs";
            this.btn_AddNeeds.UniqueName = "BAE9FA1A098F4A03898AD99488790CFA";
            this.btn_AddNeeds.Click += new System.EventHandler(this.btn_AddNeeds_Click);
            // 
            // btn_EditComments
            // 
            this.btn_EditComments.Image = global::Odin.Global_Resourses.edit;
            this.btn_EditComments.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.btn_EditComments.ToolTipTitle = "Edit selected need";
            this.btn_EditComments.UniqueName = "D924FB6FA3A34E114F88432068576721";
            this.btn_EditComments.Click += new System.EventHandler(this.btn_EditComments_Click);
            // 
            // btn_CloseNeeds
            // 
            this.btn_CloseNeeds.Image = global::Odin.Global_Resourses.stop16x16_1;
            this.btn_CloseNeeds.ToolTipTitle = "Close selected need";
            this.btn_CloseNeeds.UniqueName = "2420DE0B97F04806569CDB7223EDF26E";
            this.btn_CloseNeeds.Click += new System.EventHandler(this.btn_CloseNeeds_Click);
            // 
            // btn_DeleteNeeds
            // 
            this.btn_DeleteNeeds.Image = global::Odin.Global_Resourses.delete2;
            this.btn_DeleteNeeds.ToolTipTitle = "Delete selected need";
            this.btn_DeleteNeeds.UniqueName = "EEE67D485FFE4E7F0F9A50DE56AE73D9";
            this.btn_DeleteNeeds.Click += new System.EventHandler(this.btn_DeleteNeeds_Click);
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeight = 25;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_name,
            this.cn_batch,
            this.cn_isactive,
            this.cn_createdat,
            this.cn_createdby,
            this.cn_comments,
            this.cn_article,
            this.cn_conforder,
            this.cn_customer,
            this.cn_endcustomer});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 92);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 20;
            this.gv_List.Size = new System.Drawing.Size(286, 780);
            this.gv_List.TabIndex = 12;
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            // 
            // cn_name
            // 
            this.cn_name.DataPropertyName = "name";
            this.cn_name.FillWeight = 80F;
            this.cn_name.HeaderText = "Need name";
            this.cn_name.Name = "cn_name";
            this.cn_name.ReadOnly = true;
            this.cn_name.Width = 80;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            // 
            // cn_isactive
            // 
            this.cn_isactive.DataPropertyName = "isactive";
            this.cn_isactive.HeaderText = "isactive";
            this.cn_isactive.Name = "cn_isactive";
            this.cn_isactive.Visible = false;
            // 
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "createdat";
            this.cn_createdat.HeaderText = "Created at";
            this.cn_createdat.Name = "cn_createdat";
            // 
            // cn_createdby
            // 
            this.cn_createdby.DataPropertyName = "createdby";
            this.cn_createdby.HeaderText = "Created by";
            this.cn_createdby.Name = "cn_createdby";
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            // 
            // cn_conforder
            // 
            this.cn_conforder.DataPropertyName = "conforder";
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            // 
            // cn_customer
            // 
            this.cn_customer.DataPropertyName = "customer";
            this.cn_customer.HeaderText = "Customer";
            this.cn_customer.Name = "cn_customer";
            // 
            // cn_endcustomer
            // 
            this.cn_endcustomer.DataPropertyName = "endcustomer";
            this.cn_endcustomer.HeaderText = "End customer";
            this.cn_endcustomer.Name = "cn_endcustomer";
            // 
            // mnu_Lines
            // 
            this.mnu_Lines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Lines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterFor,
            this.mni_Search,
            this.mni_FilterBy,
            this.mni_FilterExcludingSel,
            this.mni_RemoveFilter,
            this.mni_Copy,
            this.toolStripSeparator2,
            this.mni_Admin});
            this.mnu_Lines.Name = "mnu_Requests";
            this.mnu_Lines.Size = new System.Drawing.Size(211, 167);
            this.mnu_Lines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_Lines_Opening);
            // 
            // mni_FilterFor
            // 
            this.mni_FilterFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterFor.Name = "mni_FilterFor";
            this.mni_FilterFor.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterFor.TextChanged += new System.EventHandler(this.mni_FilterFor_TextChanged);
            // 
            // mni_Search
            // 
            this.mni_Search.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_Search.Name = "mni_Search";
            this.mni_Search.Size = new System.Drawing.Size(210, 22);
            this.mni_Search.Text = "Search for record";
            this.mni_Search.Click += new System.EventHandler(this.mni_Search_Click);
            // 
            // mni_FilterBy
            // 
            this.mni_FilterBy.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterBy.Name = "mni_FilterBy";
            this.mni_FilterBy.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterBy.Text = "Filter by selection";
            this.mni_FilterBy.Click += new System.EventHandler(this.mni_FilterBy_Click);
            // 
            // mni_FilterExcludingSel
            // 
            this.mni_FilterExcludingSel.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSel.Name = "mni_FilterExcludingSel";
            this.mni_FilterExcludingSel.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSel.Text = "Filter excluding selection";
            this.mni_FilterExcludingSel.Click += new System.EventHandler(this.mni_FilterExcludingSel_Click);
            // 
            // mni_RemoveFilter
            // 
            this.mni_RemoveFilter.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilter.Name = "mni_RemoveFilter";
            this.mni_RemoveFilter.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilter.Text = "Remove filter";
            this.mni_RemoveFilter.Click += new System.EventHandler(this.mni_RemoveFilter_Click);
            // 
            // mni_Copy
            // 
            this.mni_Copy.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_Copy.Name = "mni_Copy";
            this.mni_Copy.Size = new System.Drawing.Size(210, 22);
            this.mni_Copy.Text = "Copy";
            this.mni_Copy.Click += new System.EventHandler(this.mni_Copy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_Admin
            // 
            this.mni_Admin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_Admin.Name = "mni_Admin";
            this.mni_Admin.Size = new System.Drawing.Size(210, 22);
            this.mni_Admin.Text = "List settings";
            this.mni_Admin.Click += new System.EventHandler(this.mni_Admin_Click);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = this.bindingNavigatorCountItem;
            this.bn_List.DeleteItem = null;
            this.bn_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 872);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(286, 25);
            this.bn_List.TabIndex = 11;
            this.bn_List.Text = "bn_Needs";
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
            // btn_Excel
            // 
            this.btn_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(23, 22);
            this.btn_Excel.Text = "Export into excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.gradientPanel22);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel1.Controls.Add(this.chk_active);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(286, 92);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 39);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(128, 20);
            this.kryptonLabel2.TabIndex = 240;
            this.kryptonLabel2.Values.Text = "Need contains article:";
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(8, 35);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(298, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 239;
            // 
            // cmb_Articles1
            // 
            this.cmb_Articles1.Article = "";
            this.cmb_Articles1.ArticleId = 0;
            this.cmb_Articles1.ArtType = null;
            this.cmb_Articles1.BOMState = 0;
            this.cmb_Articles1.Comments = null;
            this.cmb_Articles1.CustCode = null;
            this.cmb_Articles1.CustCodeId = 0;
            this.cmb_Articles1.Department = null;
            this.cmb_Articles1.DeptId = 0;
            this.cmb_Articles1.Description = null;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(8, 61);
            this.cmb_Articles1.Manufacturer = null;
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(265, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = null;
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 3;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleKeyPressed += new Odin.CMB_Components.Articles.ArticlesKeyPressedEventHandler(this.cmb_Articles1_ArticleKeyPressed);
            this.cmb_Articles1.ArticleIdKeyPressed += new Odin.CMB_Components.Articles.ArticlesIdKeyPressedEventHandler(this.cmb_Articles1_ArticleIdKeyPressed);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 2;
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
            this.cmb_Batches1.ConfOrder = null;
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.CustArticle = "";
            this.cmb_Batches1.Customer = null;
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.IsGroup = 0;
            this.cmb_Batches1.IsProject = 0;
            this.cmb_Batches1.IsQuote = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(64, 7);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Batches1.Stages = null;
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 1;
            // 
            // chk_active
            // 
            this.chk_active.Checked = true;
            this.chk_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_active.Location = new System.Drawing.Point(220, 8);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(57, 20);
            this.chk_active.TabIndex = 0;
            this.chk_active.Values.Text = "Active";
            // 
            // kryptonSplitContainer2
            // 
            this.kryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer2.Name = "kryptonSplitContainer2";
            // 
            // kryptonSplitContainer2.Panel1
            // 
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.kryptonHeaderGroup2);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.kryptonSplitContainer3);
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1511, 961);
            this.kryptonSplitContainer2.SplitterDistance = 1019;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.tv_Details);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.bn_Dets);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(1019, 961);
            this.kryptonHeaderGroup2.TabIndex = 0;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Details";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.ksirtet32x32;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Details of needs";
            // 
            // tv_Details
            // 
            this.tv_Details.AllowUserToAddRows = false;
            this.tv_Details.AllowUserToDeleteRows = false;
            this.tv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tv_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachmentColumn,
            this.cn_darticle,
            this.cn_dartid,
            this.cn_dsecname,
            this.cn_dunit,
            this.cn_dsupplier,
            this.cn_dqtyneed,
            this.btn_adddet,
            this.cn_dqtyinpo,
            this.cn_dunitprice,
            this.cn_dcurr,
            this.cn_dunitpricee,
            this.cn_ddatacode,
            this.cn_ddelivterm,
            this.cn_dmoq,
            this.cn_dmpq,
            this.cn_dmanufacturer,
            this.cn_dcomments,
            this.cn_did,
            this.cn_dstate,
            this.cn_dcatid,
            this.cn_pocatid,
            this.cn_doldqtyinpo,
            this.cn_dtechmissings,
            this.cn_dcatdate,
            this.cn_qtyproject,
            this.cn_analogs});
            this.tv_Details.ContextMenuStrip = this.mnu_DLines;
            this.tv_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_Details.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tv_Details.ImageList = null;
            this.tv_Details.Location = new System.Drawing.Point(0, 0);
            this.tv_Details.Name = "tv_Details";
            this.tv_Details.RowHeadersWidth = 20;
            this.tv_Details.Size = new System.Drawing.Size(1017, 878);
            this.tv_Details.TabIndex = 47;
            this.tv_Details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tv_Details_CellClick);
            this.tv_Details.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tv_Details_CellPainting);
            this.tv_Details.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tv_Details_CellValidated);
            this.tv_Details.SelectionChanged += new System.EventHandler(this.tv_Details_SelectionChanged);
            // 
            // mnu_DLines
            // 
            this.mnu_DLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_DLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_SearchD,
            this.mni_CopyD,
            this.toolStripSeparator9,
            this.mni_AdminD});
            this.mnu_DLines.Name = "mnu_Requests";
            this.mnu_DLines.Size = new System.Drawing.Size(165, 76);
            this.mnu_DLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_DLines_Opening);
            // 
            // mni_SearchD
            // 
            this.mni_SearchD.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchD.Name = "mni_SearchD";
            this.mni_SearchD.Size = new System.Drawing.Size(164, 22);
            this.mni_SearchD.Text = "Search for record";
            this.mni_SearchD.Click += new System.EventHandler(this.mni_SearchD_Click);
            // 
            // mni_CopyD
            // 
            this.mni_CopyD.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyD.Name = "mni_CopyD";
            this.mni_CopyD.Size = new System.Drawing.Size(164, 22);
            this.mni_CopyD.Text = "Copy";
            this.mni_CopyD.Click += new System.EventHandler(this.mni_CopyD_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(161, 6);
            // 
            // mni_AdminD
            // 
            this.mni_AdminD.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminD.Name = "mni_AdminD";
            this.mni_AdminD.Size = new System.Drawing.Size(164, 22);
            this.mni_AdminD.Text = "List settings";
            this.mni_AdminD.Click += new System.EventHandler(this.mni_AdminD_Click);
            // 
            // bn_Dets
            // 
            this.bn_Dets.AddNewItem = null;
            this.bn_Dets.CountItem = this.toolStripLabel1;
            this.bn_Dets.DeleteItem = null;
            this.bn_Dets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Dets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Dets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.btn_addneeddet,
            this.btn_EditNeed,
            this.btn_addcatalog,
            this.btn_Upload,
            this.btn_Download,
            this.btn_History,
            this.btn_SendEmail,
            this.toolStripLabel3,
            this.btn_Save,
            this.toolStripLabel2,
            this.btn_deleteneeddet});
            this.bn_Dets.Location = new System.Drawing.Point(0, 878);
            this.bn_Dets.MoveFirstItem = this.toolStripButton1;
            this.bn_Dets.MoveLastItem = this.toolStripButton4;
            this.bn_Dets.MoveNextItem = this.toolStripButton3;
            this.bn_Dets.MovePreviousItem = this.toolStripButton2;
            this.bn_Dets.Name = "bn_Dets";
            this.bn_Dets.PositionItem = this.toolStripTextBox1;
            this.bn_Dets.Size = new System.Drawing.Size(1017, 25);
            this.bn_Dets.TabIndex = 45;
            this.bn_Dets.Text = "bn_Needs";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_addneeddet
            // 
            this.btn_addneeddet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_addneeddet.Image = global::Odin.Global_Resourses.bindingNavigatorAddNewItem_Image;
            this.btn_addneeddet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addneeddet.Name = "btn_addneeddet";
            this.btn_addneeddet.Size = new System.Drawing.Size(23, 22);
            this.btn_addneeddet.Text = "Add need";
            this.btn_addneeddet.Click += new System.EventHandler(this.btn_addneeddet_Click);
            // 
            // btn_EditNeed
            // 
            this.btn_EditNeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EditNeed.Image = global::Odin.Global_Resourses.edit;
            this.btn_EditNeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditNeed.Name = "btn_EditNeed";
            this.btn_EditNeed.Size = new System.Drawing.Size(23, 22);
            this.btn_EditNeed.Text = "Edit need";
            this.btn_EditNeed.Click += new System.EventHandler(this.btn_EditNeed_Click);
            // 
            // btn_addcatalog
            // 
            this.btn_addcatalog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_addcatalog.Image = global::Odin.Global_Resourses.addGroup;
            this.btn_addcatalog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addcatalog.Name = "btn_addcatalog";
            this.btn_addcatalog.Size = new System.Drawing.Size(23, 22);
            this.btn_addcatalog.Text = "Add catalog info";
            this.btn_addcatalog.Click += new System.EventHandler(this.btn_addcatalog_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Image = global::Odin.Global_Resourses.Upload_24x24;
            this.btn_Upload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(164, 22);
            this.btn_Upload.Text = "Upload data for quotation";
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Image = global::Odin.Global_Resourses.Download_16x16;
            this.btn_Download.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(191, 22);
            this.btn_Download.Text = "Download data from quotation";
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_History
            // 
            this.btn_History.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_History.Image = global::Odin.Global_Resourses.history24x24;
            this.btn_History.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(23, 22);
            this.btn_History.Text = "History of catalog";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_SendEmail.Image = global::Odin.Global_Resourses.SendMail;
            this.btn_SendEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(23, 22);
            this.btn_SendEmail.Text = "Send emails with results";
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel3.Text = "       ";
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(23, 22);
            this.btn_Save.Text = "Add needs to PO";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel2.Text = "           ";
            // 
            // btn_deleteneeddet
            // 
            this.btn_deleteneeddet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_deleteneeddet.Image = global::Odin.Global_Resourses.bindingNavigatorDeleteItem_Image;
            this.btn_deleteneeddet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_deleteneeddet.Name = "btn_deleteneeddet";
            this.btn_deleteneeddet.Size = new System.Drawing.Size(23, 22);
            this.btn_deleteneeddet.Text = "Delete need dets";
            this.btn_deleteneeddet.Click += new System.EventHandler(this.btn_deleteneeddet_Click);
            // 
            // kryptonSplitContainer3
            // 
            this.kryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer3.Name = "kryptonSplitContainer3";
            this.kryptonSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer3.Panel1
            // 
            this.kryptonSplitContainer3.Panel1.Controls.Add(this.kryptonHeaderGroup3);
            // 
            // kryptonSplitContainer3.Panel2
            // 
            this.kryptonSplitContainer3.Panel2.Controls.Add(this.kryptonHeaderGroup4);
            this.kryptonSplitContainer3.Size = new System.Drawing.Size(487, 961);
            this.kryptonSplitContainer3.SplitterDistance = 892;
            this.kryptonSplitContainer3.TabIndex = 0;
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.gv_POList);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.bn_POList);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(487, 892);
            this.kryptonHeaderGroup3.TabIndex = 0;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Purchase orders";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::Odin.Global_Resourses.basket_8134;
            this.kryptonHeaderGroup3.ValuesSecondary.Heading = "Purchase order for selected need";
            // 
            // gv_POList
            // 
            this.gv_POList.AllowUserToAddRows = false;
            this.gv_POList.AllowUserToDeleteRows = false;
            this.gv_POList.AllowUserToOrderColumns = true;
            this.gv_POList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_POList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_pid,
            this.chk_print,
            this.cn_headid,
            this.dataGridViewTextBoxColumn2,
            this.cn_supplier,
            this.cn_contract,
            this.cn_line,
            this.cn_artid,
            this.dataGridViewTextBoxColumn3,
            this.cn_type,
            this.cn_qty,
            this.cn_qtydeliv,
            this.cn_unit,
            this.cn_reqdate,
            this.cn_state,
            this.cn_unitprice,
            this.cn_currency,
            this.cn_vat,
            this.cn_discount,
            this.cn_suporder,
            this.cn_secname,
            this.dataGridViewTextBoxColumn4,
            this.cn_bestbefore,
            this.cn_catalogid,
            this.cn_coefconv,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.cn_inprocess,
            this.cn_confdate,
            this.cn_resale});
            this.gv_POList.ContextMenuStrip = this.mnu_POLines;
            this.gv_POList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_POList.Location = new System.Drawing.Point(0, 0);
            this.gv_POList.Name = "gv_POList";
            this.gv_POList.RowHeadersWidth = 20;
            this.gv_POList.Size = new System.Drawing.Size(485, 809);
            this.gv_POList.TabIndex = 47;
            // 
            // cn_pid
            // 
            this.cn_pid.DataPropertyName = "id";
            this.cn_pid.HeaderText = "id";
            this.cn_pid.Name = "cn_pid";
            this.cn_pid.Visible = false;
            // 
            // chk_print
            // 
            this.chk_print.DataPropertyName = "toprint";
            this.chk_print.FalseValue = "0";
            this.chk_print.FillWeight = 40F;
            this.chk_print.HeaderText = "Print";
            this.chk_print.IndeterminateValue = "1";
            this.chk_print.Name = "chk_print";
            this.chk_print.TrueValue = "-1";
            this.chk_print.Visible = false;
            this.chk_print.Width = 40;
            // 
            // cn_headid
            // 
            this.cn_headid.DataPropertyName = "headid";
            this.cn_headid.HeaderText = "headid";
            this.cn_headid.Name = "cn_headid";
            this.cn_headid.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.FillWeight = 90F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Order";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // cn_supplier
            // 
            this.cn_supplier.DataPropertyName = "supplier";
            this.cn_supplier.FillWeight = 120F;
            this.cn_supplier.HeaderText = "Supplier";
            this.cn_supplier.Name = "cn_supplier";
            this.cn_supplier.Width = 120;
            // 
            // cn_contract
            // 
            this.cn_contract.DataPropertyName = "contract";
            this.cn_contract.HeaderText = "Contract";
            this.cn_contract.Name = "cn_contract";
            this.cn_contract.Visible = false;
            // 
            // cn_line
            // 
            this.cn_line.DataPropertyName = "line";
            this.cn_line.FillWeight = 30F;
            this.cn_line.HeaderText = "Line";
            this.cn_line.Name = "cn_line";
            this.cn_line.Width = 30;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Article";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // cn_type
            // 
            this.cn_type.DataPropertyName = "type";
            this.cn_type.HeaderText = "Type";
            this.cn_type.Name = "cn_type";
            this.cn_type.Visible = false;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 70F;
            this.cn_qty.HeaderText = "Quantity";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 70;
            // 
            // cn_qtydeliv
            // 
            this.cn_qtydeliv.DataPropertyName = "qtydeliv";
            this.cn_qtydeliv.FillWeight = 70F;
            this.cn_qtydeliv.HeaderText = "Deliv. qty";
            this.cn_qtydeliv.Name = "cn_qtydeliv";
            this.cn_qtydeliv.Width = 70;
            // 
            // cn_unit
            // 
            this.cn_unit.DataPropertyName = "unit";
            this.cn_unit.FillWeight = 40F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.Width = 40;
            // 
            // cn_reqdate
            // 
            this.cn_reqdate.DataPropertyName = "reqdate";
            this.cn_reqdate.HeaderText = "Requested date";
            this.cn_reqdate.Name = "cn_reqdate";
            // 
            // cn_state
            // 
            this.cn_state.DataPropertyName = "state";
            this.cn_state.FillWeight = 80F;
            this.cn_state.HeaderText = "State";
            this.cn_state.Name = "cn_state";
            this.cn_state.Width = 80;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price";
            this.cn_unitprice.Name = "cn_unitprice";
            // 
            // cn_currency
            // 
            this.cn_currency.DataPropertyName = "currency";
            this.cn_currency.FillWeight = 40F;
            this.cn_currency.HeaderText = "Currency";
            this.cn_currency.Name = "cn_currency";
            this.cn_currency.Width = 40;
            // 
            // cn_vat
            // 
            this.cn_vat.DataPropertyName = "vat";
            this.cn_vat.FillWeight = 30F;
            this.cn_vat.HeaderText = "VAT";
            this.cn_vat.Name = "cn_vat";
            this.cn_vat.Width = 30;
            // 
            // cn_discount
            // 
            this.cn_discount.DataPropertyName = "discount";
            this.cn_discount.FillWeight = 40F;
            this.cn_discount.HeaderText = "Disc.";
            this.cn_discount.Name = "cn_discount";
            this.cn_discount.Visible = false;
            this.cn_discount.Width = 40;
            // 
            // cn_suporder
            // 
            this.cn_suporder.DataPropertyName = "suporder";
            this.cn_suporder.HeaderText = "Sup. order";
            this.cn_suporder.Name = "cn_suporder";
            this.cn_suporder.Visible = false;
            // 
            // cn_secname
            // 
            this.cn_secname.DataPropertyName = "suparticle";
            this.cn_secname.FillWeight = 150F;
            this.cn_secname.HeaderText = "Sup. article";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.Visible = false;
            this.cn_secname.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "comments";
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // cn_bestbefore
            // 
            this.cn_bestbefore.DataPropertyName = "bestbefore";
            this.cn_bestbefore.HeaderText = "Best before";
            this.cn_bestbefore.Name = "cn_bestbefore";
            this.cn_bestbefore.Visible = false;
            // 
            // cn_catalogid
            // 
            this.cn_catalogid.DataPropertyName = "catalogid";
            this.cn_catalogid.HeaderText = "CatalogId";
            this.cn_catalogid.Name = "cn_catalogid";
            this.cn_catalogid.Visible = false;
            // 
            // cn_coefconv
            // 
            this.cn_coefconv.DataPropertyName = "coefconv";
            this.cn_coefconv.HeaderText = "CoefConv";
            this.cn_coefconv.Name = "cn_coefconv";
            this.cn_coefconv.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "createdat";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Created at";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "createdby";
            this.dataGridViewTextBoxColumn6.HeaderText = "Created by";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // cn_inprocess
            // 
            this.cn_inprocess.DataPropertyName = "inprocess";
            this.cn_inprocess.HeaderText = "inprocess";
            this.cn_inprocess.Name = "cn_inprocess";
            this.cn_inprocess.Visible = false;
            // 
            // cn_confdate
            // 
            this.cn_confdate.DataPropertyName = "confdate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.cn_confdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_confdate.HeaderText = "Conf. date";
            this.cn_confdate.Name = "cn_confdate";
            // 
            // cn_resale
            // 
            this.cn_resale.DataPropertyName = "resale";
            this.cn_resale.HeaderText = "Resale";
            this.cn_resale.Name = "cn_resale";
            this.cn_resale.Visible = false;
            // 
            // mnu_POLines
            // 
            this.mnu_POLines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_POLines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_FilterForPO,
            this.mni_SearchPO,
            this.mni_FilterByPO,
            this.mni_FilterExcludingSelPO,
            this.mni_RemoveFilterPO,
            this.mni_CopyPO,
            this.toolStripSeparator8,
            this.mni_AdminPO});
            this.mnu_POLines.Name = "mnu_Requests";
            this.mnu_POLines.Size = new System.Drawing.Size(211, 167);
            this.mnu_POLines.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_LinesPO_Opening);
            // 
            // mni_FilterForPO
            // 
            this.mni_FilterForPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mni_FilterForPO.Name = "mni_FilterForPO";
            this.mni_FilterForPO.Size = new System.Drawing.Size(150, 23);
            this.mni_FilterForPO.Click += new System.EventHandler(this.mni_FilterForPO_TextChanged);
            // 
            // mni_SearchPO
            // 
            this.mni_SearchPO.Image = global::Odin.Global_Resourses.binoculars_8090;
            this.mni_SearchPO.Name = "mni_SearchPO";
            this.mni_SearchPO.Size = new System.Drawing.Size(210, 22);
            this.mni_SearchPO.Text = "Search for record";
            this.mni_SearchPO.Click += new System.EventHandler(this.mni_SearchPO_Click);
            // 
            // mni_FilterByPO
            // 
            this.mni_FilterByPO.Image = global::Odin.Global_Resourses.FilterBySel;
            this.mni_FilterByPO.Name = "mni_FilterByPO";
            this.mni_FilterByPO.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterByPO.Text = "Filter by selection";
            this.mni_FilterByPO.Click += new System.EventHandler(this.mni_FilterByPO_Click);
            // 
            // mni_FilterExcludingSelPO
            // 
            this.mni_FilterExcludingSelPO.Image = global::Odin.Global_Resourses.scissors_3838;
            this.mni_FilterExcludingSelPO.Name = "mni_FilterExcludingSelPO";
            this.mni_FilterExcludingSelPO.Size = new System.Drawing.Size(210, 22);
            this.mni_FilterExcludingSelPO.Text = "Filter excluding selection";
            this.mni_FilterExcludingSelPO.Click += new System.EventHandler(this.mni_FilterExcludingSelPO_Click);
            // 
            // mni_RemoveFilterPO
            // 
            this.mni_RemoveFilterPO.Image = global::Odin.Global_Resourses.RemoveFilter;
            this.mni_RemoveFilterPO.Name = "mni_RemoveFilterPO";
            this.mni_RemoveFilterPO.Size = new System.Drawing.Size(210, 22);
            this.mni_RemoveFilterPO.Text = "Remove filter";
            this.mni_RemoveFilterPO.Click += new System.EventHandler(this.mni_RemoveFilterPO_Click);
            // 
            // mni_CopyPO
            // 
            this.mni_CopyPO.Image = global::Odin.Global_Resourses.Copy_16x16;
            this.mni_CopyPO.Name = "mni_CopyPO";
            this.mni_CopyPO.Size = new System.Drawing.Size(210, 22);
            this.mni_CopyPO.Text = "Copy";
            this.mni_CopyPO.Click += new System.EventHandler(this.mni_CopyPO_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(207, 6);
            // 
            // mni_AdminPO
            // 
            this.mni_AdminPO.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminPO.Name = "mni_AdminPO";
            this.mni_AdminPO.Size = new System.Drawing.Size(210, 22);
            this.mni_AdminPO.Text = "List settings";
            this.mni_AdminPO.Click += new System.EventHandler(this.mni_AdminPO_Click);
            // 
            // bn_POList
            // 
            this.bn_POList.AddNewItem = null;
            this.bn_POList.CountItem = this.toolStripLabel4;
            this.bn_POList.DeleteItem = null;
            this.bn_POList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_POList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_POList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator5,
            this.toolStripTextBox2,
            this.toolStripLabel4,
            this.toolStripSeparator6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator7,
            this.btn_DeletePOline,
            this.btn_ExportPO});
            this.bn_POList.Location = new System.Drawing.Point(0, 809);
            this.bn_POList.MoveFirstItem = this.toolStripButton5;
            this.bn_POList.MoveLastItem = this.toolStripButton8;
            this.bn_POList.MoveNextItem = this.toolStripButton7;
            this.bn_POList.MovePreviousItem = this.toolStripButton6;
            this.bn_POList.Name = "bn_POList";
            this.bn_POList.PositionItem = this.toolStripTextBox2;
            this.bn_POList.Size = new System.Drawing.Size(485, 25);
            this.bn_POList.TabIndex = 46;
            this.bn_POList.Text = "bn_Needs";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "of {0}";
            this.toolStripLabel4.ToolTipText = "Total number of items";
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
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move previous";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move next";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move last";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_DeletePOline
            // 
            this.btn_DeletePOline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeletePOline.Image = global::Odin.Global_Resourses.bindingNavigatorDeleteItem_Image;
            this.btn_DeletePOline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeletePOline.Name = "btn_DeletePOline";
            this.btn_DeletePOline.Size = new System.Drawing.Size(23, 22);
            this.btn_DeletePOline.Text = "Dleete PO line";
            this.btn_DeletePOline.Click += new System.EventHandler(this.btn_DeletePOline_Click);
            // 
            // btn_ExportPO
            // 
            this.btn_ExportPO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ExportPO.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_ExportPO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExportPO.Name = "btn_ExportPO";
            this.btn_ExportPO.Size = new System.Drawing.Size(23, 22);
            this.btn_ExportPO.Text = "Export into excel";
            this.btn_ExportPO.Click += new System.EventHandler(this.btn_ExportPO_Click);
            // 
            // kryptonHeaderGroup4
            // 
            this.kryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup4.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup4.Name = "kryptonHeaderGroup4";
            this.kryptonHeaderGroup4.Size = new System.Drawing.Size(487, 64);
            this.kryptonHeaderGroup4.TabIndex = 0;
            this.kryptonHeaderGroup4.ValuesPrimary.Heading = "Request for quotations";
            this.kryptonHeaderGroup4.ValuesPrimary.Image = global::Odin.Global_Resourses.table_tab_search;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // attachmentColumn
            // 
            this.attachmentColumn.HeaderText = "attachmentColumn";
            this.attachmentColumn.Name = "attachmentColumn";
            this.attachmentColumn.Visible = false;
            // 
            // cn_darticle
            // 
            this.cn_darticle.DataPropertyName = "article";
            this.cn_darticle.DefaultNodeImage = null;
            this.cn_darticle.FillWeight = 200F;
            this.cn_darticle.HeaderText = "Article";
            this.cn_darticle.Name = "cn_darticle";
            this.cn_darticle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_darticle.Width = 200;
            // 
            // cn_dartid
            // 
            this.cn_dartid.DataPropertyName = "artid";
            this.cn_dartid.FillWeight = 70F;
            this.cn_dartid.HeaderText = "Art. id";
            this.cn_dartid.Name = "cn_dartid";
            this.cn_dartid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dartid.Width = 70;
            // 
            // cn_dsecname
            // 
            this.cn_dsecname.DataPropertyName = "secname";
            this.cn_dsecname.HeaderText = "Sup. article";
            this.cn_dsecname.Name = "cn_dsecname";
            this.cn_dsecname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_dunit
            // 
            this.cn_dunit.DataPropertyName = "unit";
            this.cn_dunit.FillWeight = 40F;
            this.cn_dunit.HeaderText = "Unit";
            this.cn_dunit.Name = "cn_dunit";
            this.cn_dunit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dunit.Width = 40;
            // 
            // cn_dsupplier
            // 
            this.cn_dsupplier.DataPropertyName = "supplier";
            this.cn_dsupplier.FillWeight = 110F;
            this.cn_dsupplier.HeaderText = "Supplier";
            this.cn_dsupplier.Name = "cn_dsupplier";
            this.cn_dsupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dsupplier.Width = 110;
            // 
            // cn_dqtyneed
            // 
            this.cn_dqtyneed.DataPropertyName = "qtyneeds";
            this.cn_dqtyneed.FillWeight = 70F;
            this.cn_dqtyneed.HeaderText = "Qty needs";
            this.cn_dqtyneed.Name = "cn_dqtyneed";
            this.cn_dqtyneed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dqtyneed.Width = 70;
            // 
            // btn_adddet
            // 
            this.btn_adddet.FillWeight = 25F;
            this.btn_adddet.HeaderText = "";
            this.btn_adddet.Name = "btn_adddet";
            this.btn_adddet.Width = 25;
            // 
            // cn_dqtyinpo
            // 
            this.cn_dqtyinpo.DataPropertyName = "qtyinpo";
            this.cn_dqtyinpo.FillWeight = 80F;
            this.cn_dqtyinpo.HeaderText = "Qty in PO";
            this.cn_dqtyinpo.Name = "cn_dqtyinpo";
            this.cn_dqtyinpo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dqtyinpo.Width = 80;
            // 
            // cn_dunitprice
            // 
            this.cn_dunitprice.DataPropertyName = "unitprice";
            this.cn_dunitprice.FillWeight = 80F;
            this.cn_dunitprice.HeaderText = "Unit price";
            this.cn_dunitprice.Name = "cn_dunitprice";
            this.cn_dunitprice.ReadOnly = true;
            this.cn_dunitprice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dunitprice.Width = 80;
            // 
            // cn_dcurr
            // 
            this.cn_dcurr.DataPropertyName = "currency";
            this.cn_dcurr.FillWeight = 40F;
            this.cn_dcurr.HeaderText = "Curr.";
            this.cn_dcurr.Name = "cn_dcurr";
            this.cn_dcurr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dcurr.Width = 40;
            // 
            // cn_dunitpricee
            // 
            this.cn_dunitpricee.DataPropertyName = "unitpriceeur";
            this.cn_dunitpricee.FillWeight = 90F;
            this.cn_dunitpricee.HeaderText = "Unit price (BYN)";
            this.cn_dunitpricee.Name = "cn_dunitpricee";
            this.cn_dunitpricee.ReadOnly = true;
            this.cn_dunitpricee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dunitpricee.Width = 90;
            // 
            // cn_ddatacode
            // 
            this.cn_ddatacode.DataPropertyName = "datacode";
            this.cn_ddatacode.FillWeight = 70F;
            this.cn_ddatacode.HeaderText = "Data code";
            this.cn_ddatacode.Name = "cn_ddatacode";
            this.cn_ddatacode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_ddatacode.Width = 70;
            // 
            // cn_ddelivterm
            // 
            this.cn_ddelivterm.DataPropertyName = "delivterm";
            this.cn_ddelivterm.FillWeight = 60F;
            this.cn_ddelivterm.HeaderText = "Deliv. term";
            this.cn_ddelivterm.Name = "cn_ddelivterm";
            this.cn_ddelivterm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_ddelivterm.Width = 60;
            // 
            // cn_dmoq
            // 
            this.cn_dmoq.DataPropertyName = "moq";
            this.cn_dmoq.FillWeight = 60F;
            this.cn_dmoq.HeaderText = "MOQ";
            this.cn_dmoq.Name = "cn_dmoq";
            this.cn_dmoq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dmoq.Width = 60;
            // 
            // cn_dmpq
            // 
            this.cn_dmpq.DataPropertyName = "mpq";
            this.cn_dmpq.FillWeight = 60F;
            this.cn_dmpq.HeaderText = "MPQ";
            this.cn_dmpq.Name = "cn_dmpq";
            this.cn_dmpq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dmpq.Width = 60;
            // 
            // cn_dmanufacturer
            // 
            this.cn_dmanufacturer.DataPropertyName = "manufacturer";
            this.cn_dmanufacturer.HeaderText = "Manufacturer";
            this.cn_dmanufacturer.Name = "cn_dmanufacturer";
            this.cn_dmanufacturer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_dcomments
            // 
            this.cn_dcomments.DataPropertyName = "comments";
            this.cn_dcomments.HeaderText = "Comments";
            this.cn_dcomments.Name = "cn_dcomments";
            this.cn_dcomments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_did
            // 
            this.cn_did.DataPropertyName = "id";
            this.cn_did.HeaderText = "id";
            this.cn_did.Name = "cn_did";
            this.cn_did.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_dstate
            // 
            this.cn_dstate.DataPropertyName = "state";
            this.cn_dstate.HeaderText = "State";
            this.cn_dstate.Name = "cn_dstate";
            this.cn_dstate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dstate.Visible = false;
            // 
            // cn_dcatid
            // 
            this.cn_dcatid.DataPropertyName = "catid";
            this.cn_dcatid.HeaderText = "catid";
            this.cn_dcatid.Name = "cn_dcatid";
            this.cn_dcatid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dcatid.Visible = false;
            // 
            // cn_pocatid
            // 
            this.cn_pocatid.DataPropertyName = "pocatid";
            this.cn_pocatid.HeaderText = "pocatid";
            this.cn_pocatid.Name = "cn_pocatid";
            this.cn_pocatid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_pocatid.Visible = false;
            // 
            // cn_doldqtyinpo
            // 
            this.cn_doldqtyinpo.DataPropertyName = "oldqtyinpo";
            this.cn_doldqtyinpo.HeaderText = "oldqtyinpo";
            this.cn_doldqtyinpo.Name = "cn_doldqtyinpo";
            this.cn_doldqtyinpo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_doldqtyinpo.Visible = false;
            // 
            // cn_dtechmissings
            // 
            this.cn_dtechmissings.DataPropertyName = "techmissings";
            this.cn_dtechmissings.FillWeight = 60F;
            this.cn_dtechmissings.HeaderText = "Tech. missings";
            this.cn_dtechmissings.Name = "cn_dtechmissings";
            this.cn_dtechmissings.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dtechmissings.Width = 60;
            // 
            // cn_dcatdate
            // 
            this.cn_dcatdate.DataPropertyName = "creatdate";
            this.cn_dcatdate.HeaderText = "Cat. date";
            this.cn_dcatdate.Name = "cn_dcatdate";
            this.cn_dcatdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_qtyproject
            // 
            this.cn_qtyproject.DataPropertyName = "inproject";
            this.cn_qtyproject.HeaderText = "In project";
            this.cn_qtyproject.Name = "cn_qtyproject";
            this.cn_qtyproject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_analogs
            // 
            this.cn_analogs.DataPropertyName = "analogs";
            this.cn_analogs.HeaderText = "Analogs";
            this.cn_analogs.Name = "cn_analogs";
            this.cn_analogs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frm_NeedsProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 961);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_NeedsProcessing";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.TabText = "Needs processing";
            this.Text = "Needs processing";
            this.Load += new System.EventHandler(this.frm_NeedsProcessing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tv_Details)).EndInit();
            this.mnu_DLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bn_Dets)).EndInit();
            this.bn_Dets.ResumeLayout(false);
            this.bn_Dets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel1)).EndInit();
            this.kryptonSplitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel2)).EndInit();
            this.kryptonSplitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3)).EndInit();
            this.kryptonSplitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_POList)).EndInit();
            this.mnu_POLines.ResumeLayout(false);
            this.mnu_POLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_POList)).EndInit();
            this.bn_POList.ResumeLayout(false);
            this.bn_POList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup4.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup4)).EndInit();
            this.kryptonHeaderGroup4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_POList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Dets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_AddNeeds;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_DeleteNeeds;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_active;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup4;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private System.Windows.Forms.BindingNavigator bn_Dets;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private AdvancedDataGridView.TreeGridView tv_Details;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.ToolStripButton btn_addneeddet;
        private System.Windows.Forms.ToolStripButton btn_addcatalog;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_deleteneeddet;
        private System.Windows.Forms.BindingNavigator bn_POList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private Global_Classes.SyncBindingSource bs_POList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_POList;
        private System.Windows.Forms.ToolStripButton btn_DeletePOline;
        private System.Windows.Forms.ContextMenuStrip mnu_POLines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterForPO;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchPO;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterByPO;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSelPO;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilterPO;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyPO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminPO;
        private System.Windows.Forms.ToolStripButton btn_ExportPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_headid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtydeliv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reqdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_suporder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bestbefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_catalogid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coefconv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inprocess;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_confdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_resale;
        private Global_Classes.SyncBindingSource bs_Dets;
        private System.Windows.Forms.ContextMenuStrip mnu_DLines;
        private System.Windows.Forms.ToolStripMenuItem mni_SearchD;
        private System.Windows.Forms.ToolStripMenuItem mni_CopyD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminD;
        private System.Windows.Forms.ToolStripButton btn_Upload;
        private System.Windows.Forms.ToolStripButton btn_Download;
        private System.Windows.Forms.ToolStripButton btn_History;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.ToolStripButton btn_EditNeed;
        private System.Windows.Forms.ToolStripButton btn_SendEmail;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_CloseNeeds;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_EditComments;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_NeedsList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_endcustomer;
        private System.Windows.Forms.DataGridViewImageColumn attachmentColumn;
        private AdvancedDataGridView.TreeGridColumn cn_darticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dsecname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dsupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dqtyneed;
        private System.Windows.Forms.DataGridViewButtonColumn btn_adddet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dqtyinpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunitpricee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ddatacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ddelivterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dmoq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dmpq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dmanufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcomments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_did;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcatid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_pocatid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_doldqtyinpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dtechmissings;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcatdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyproject;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_analogs;
    }
}