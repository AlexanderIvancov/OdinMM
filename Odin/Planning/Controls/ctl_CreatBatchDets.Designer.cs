namespace Odin.Planning.Controls
{
    partial class ctl_CreatBatchDets
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_CreatBatchDets));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_EndDate = new Odin.CustomControls.NullableDateTimePicker();
            this.txt_StartDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gv_Orders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oreqdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ocustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtyforbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_Orders = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Orders = new System.Data.DataSet();
            this.dt_Orders = new System.Data.DataTable();
            this.dcid = new System.Data.DataColumn();
            this.dccoid = new System.Data.DataColumn();
            this.dcorder = new System.Data.DataColumn();
            this.dcline = new System.Data.DataColumn();
            this.dcarticle = new System.Data.DataColumn();
            this.dcartid = new System.Data.DataColumn();
            this.dcqty = new System.Data.DataColumn();
            this.dcreqdate = new System.Data.DataColumn();
            this.dccustomer = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bn_Orders = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_AddNewOrder = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteOrder = new System.Windows.Forms.ToolStripButton();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chk_Urgent = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lbl_Unit = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_SalesOrdersWithLines1 = new Odin.CMB_Components.SalesOrders.cmb_SalesOrdersWithLines();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Batch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Qty = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.btn_Spoilage = new System.Windows.Forms.ToolStripButton();
            this.btn_AddNorm = new System.Windows.Forms.ToolStripButton();
            this.btn_AddSubProduct = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteNorm = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_Unit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_Decimals = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Round = new System.Windows.Forms.ToolStripButton();
            this.btn_Clear = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tv_BOM = new AdvancedDataGridView.TreeGridView();
            this.attachmentColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cn_nArticle = new AdvancedDataGridView.TreeGridColumn();
            this.cn_nCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_nArtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyInBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nSubProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nWithSpoil = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_nQtyDefOldB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nSubProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nCSEArtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nChildBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nBatchHeadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nWaitingPOQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_WPODelivDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_POrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nSubProdQtyOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nSpoilNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nNumDecimals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nSpoilConst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nSubBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ndetisactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_qtygiven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dnp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Orders)).BeginInit();
            this.bn_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_BOM)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_EndDate);
            this.kryptonPanel1.Controls.Add(this.txt_StartDate);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.txt_Comments);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.chk_Urgent);
            this.kryptonPanel1.Controls.Add(this.lbl_Unit);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.cmb_SalesOrdersWithLines1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txt_Batch);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.txt_Qty);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(1289, 136);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.CalendarShowWeekNumbers = true;
            this.txt_EndDate.CustomFormat = null;
            this.txt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EndDate.Location = new System.Drawing.Point(319, 62);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.NullValue = " ";
            this.txt_EndDate.Size = new System.Drawing.Size(88, 21);
            this.txt_EndDate.TabIndex = 274;
            this.txt_EndDate.Visible = false;
            this.txt_EndDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_EndDate_DropDown);
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.CalendarShowWeekNumbers = true;
            this.txt_StartDate.CustomFormat = null;
            this.txt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartDate.Location = new System.Drawing.Point(102, 62);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.NullValue = " ";
            this.txt_StartDate.Size = new System.Drawing.Size(88, 21);
            this.txt_StartDate.TabIndex = 273;
            this.txt_StartDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartDate_DropDown);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.gv_Orders);
            this.kryptonPanel2.Controls.Add(this.btn_OK);
            this.kryptonPanel2.Controls.Add(this.bn_Orders);
            this.kryptonPanel2.Location = new System.Drawing.Point(414, 3);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(891, 130);
            this.kryptonPanel2.TabIndex = 21;
            // 
            // gv_Orders
            // 
            this.gv_Orders.AllowUserToAddRows = false;
            this.gv_Orders.AllowUserToDeleteRows = false;
            this.gv_Orders.AutoGenerateColumns = false;
            this.gv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_order,
            this.cn_line,
            this.cn_oarticle,
            this.cn_oartid,
            this.cn_oqty,
            this.cn_oreqdate,
            this.cn_ocustomer,
            this.cn_coid,
            this.cn_id,
            this.cn_qtyforbatch});
            this.gv_Orders.DataSource = this.bs_Orders;
            this.gv_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Orders.Location = new System.Drawing.Point(24, 0);
            this.gv_Orders.Name = "gv_Orders";
            this.gv_Orders.RowHeadersWidth = 10;
            this.gv_Orders.Size = new System.Drawing.Size(867, 130);
            this.gv_Orders.TabIndex = 1;
            this.gv_Orders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Orders_CellEnter);
            this.gv_Orders.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Orders_CellValidated);
            // 
            // cn_order
            // 
            this.cn_order.DataPropertyName = "order";
            this.cn_order.HeaderText = "Order";
            this.cn_order.Name = "cn_order";
            // 
            // cn_line
            // 
            this.cn_line.DataPropertyName = "line";
            this.cn_line.FillWeight = 30F;
            this.cn_line.HeaderText = "Line";
            this.cn_line.Name = "cn_line";
            this.cn_line.Width = 30;
            // 
            // cn_oarticle
            // 
            this.cn_oarticle.DataPropertyName = "article";
            this.cn_oarticle.FillWeight = 120F;
            this.cn_oarticle.HeaderText = "Article";
            this.cn_oarticle.Name = "cn_oarticle";
            this.cn_oarticle.Width = 120;
            // 
            // cn_oartid
            // 
            this.cn_oartid.DataPropertyName = "artid";
            this.cn_oartid.FillWeight = 70F;
            this.cn_oartid.HeaderText = "Art. id";
            this.cn_oartid.Name = "cn_oartid";
            this.cn_oartid.Width = 70;
            // 
            // cn_oqty
            // 
            this.cn_oqty.DataPropertyName = "qty";
            this.cn_oqty.FillWeight = 65F;
            this.cn_oqty.HeaderText = "Qty";
            this.cn_oqty.Name = "cn_oqty";
            this.cn_oqty.Width = 65;
            // 
            // cn_oreqdate
            // 
            this.cn_oreqdate.DataPropertyName = "reqdate";
            this.cn_oreqdate.FillWeight = 90F;
            this.cn_oreqdate.HeaderText = "Req. date";
            this.cn_oreqdate.Name = "cn_oreqdate";
            this.cn_oreqdate.Width = 90;
            // 
            // cn_ocustomer
            // 
            this.cn_ocustomer.DataPropertyName = "customer";
            this.cn_ocustomer.FillWeight = 150F;
            this.cn_ocustomer.HeaderText = "Customer";
            this.cn_ocustomer.Name = "cn_ocustomer";
            this.cn_ocustomer.Width = 150;
            // 
            // cn_coid
            // 
            this.cn_coid.DataPropertyName = "coid";
            this.cn_coid.FillWeight = 5F;
            this.cn_coid.HeaderText = "coid";
            this.cn_coid.Name = "cn_coid";
            this.cn_coid.Visible = false;
            this.cn_coid.Width = 5;
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.FillWeight = 5F;
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            this.cn_id.Width = 5;
            // 
            // cn_qtyforbatch
            // 
            this.cn_qtyforbatch.DataPropertyName = "qtyforbatch";
            this.cn_qtyforbatch.HeaderText = "qtyforbatch";
            this.cn_qtyforbatch.Name = "cn_qtyforbatch";
            this.cn_qtyforbatch.Visible = false;
            // 
            // bs_Orders
            // 
            this.bs_Orders.DataMember = "dt_Orders";
            this.bs_Orders.DataSource = this.ds_Orders;
            // 
            // ds_Orders
            // 
            this.ds_Orders.DataSetName = "ds_Orders";
            this.ds_Orders.Tables.AddRange(new System.Data.DataTable[] {
            this.dt_Orders});
            // 
            // dt_Orders
            // 
            this.dt_Orders.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcid,
            this.dccoid,
            this.dcorder,
            this.dcline,
            this.dcarticle,
            this.dcartid,
            this.dcqty,
            this.dcreqdate,
            this.dccustomer,
            this.dataColumn1});
            this.dt_Orders.TableName = "dt_Orders";
            // 
            // dcid
            // 
            this.dcid.ColumnName = "id";
            this.dcid.DataType = typeof(int);
            // 
            // dccoid
            // 
            this.dccoid.ColumnName = "coid";
            this.dccoid.DataType = typeof(int);
            // 
            // dcorder
            // 
            this.dcorder.ColumnName = "order";
            // 
            // dcline
            // 
            this.dcline.ColumnName = "line";
            // 
            // dcarticle
            // 
            this.dcarticle.ColumnName = "article";
            // 
            // dcartid
            // 
            this.dcartid.ColumnName = "artid";
            this.dcartid.DataType = typeof(int);
            // 
            // dcqty
            // 
            this.dcqty.Caption = "qty";
            this.dcqty.ColumnName = "qty";
            this.dcqty.DataType = typeof(double);
            // 
            // dcreqdate
            // 
            this.dcreqdate.Caption = "reqdate";
            this.dcreqdate.ColumnName = "reqdate";
            // 
            // dccustomer
            // 
            this.dccustomer.ColumnName = "customer";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "qtyforbatch";
            this.dataColumn1.DataType = typeof(double);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(61, 78);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(89, 44);
            this.btn_OK.TabIndex = 20;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Visible = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // bn_Orders
            // 
            this.bn_Orders.AddNewItem = null;
            this.bn_Orders.CountItem = null;
            this.bn_Orders.DeleteItem = null;
            this.bn_Orders.Dock = System.Windows.Forms.DockStyle.Left;
            this.bn_Orders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Orders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddNewOrder,
            this.btn_DeleteOrder});
            this.bn_Orders.Location = new System.Drawing.Point(0, 0);
            this.bn_Orders.MoveFirstItem = null;
            this.bn_Orders.MoveLastItem = null;
            this.bn_Orders.MoveNextItem = null;
            this.bn_Orders.MovePreviousItem = null;
            this.bn_Orders.Name = "bn_Orders";
            this.bn_Orders.PositionItem = null;
            this.bn_Orders.Size = new System.Drawing.Size(24, 130);
            this.bn_Orders.TabIndex = 0;
            // 
            // btn_AddNewOrder
            // 
            this.btn_AddNewOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNewOrder.Image")));
            this.btn_AddNewOrder.Name = "btn_AddNewOrder";
            this.btn_AddNewOrder.RightToLeftAutoMirrorImage = true;
            this.btn_AddNewOrder.Size = new System.Drawing.Size(21, 20);
            this.btn_AddNewOrder.Text = "Add new order";
            this.btn_AddNewOrder.Click += new System.EventHandler(this.btn_AddNewOrder_Click);
            // 
            // btn_DeleteOrder
            // 
            this.btn_DeleteOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteOrder.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteOrder.Image")));
            this.btn_DeleteOrder.Name = "btn_DeleteOrder";
            this.btn_DeleteOrder.RightToLeftAutoMirrorImage = true;
            this.btn_DeleteOrder.Size = new System.Drawing.Size(21, 20);
            this.btn_DeleteOrder.Text = "Delete order";
            this.btn_DeleteOrder.Click += new System.EventHandler(this.btn_DeleteOrder_Click);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(10, 87);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel7.TabIndex = 19;
            this.kryptonLabel7.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_Comments.Location = new System.Drawing.Point(88, 89);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(320, 44);
            this.txt_Comments.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Comments.TabIndex = 7;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "D5B6C03750554195328E4B264796E65F";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(240, 62);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel6.TabIndex = 17;
            this.kryptonLabel6.Values.Text = "ends at:";
            this.kryptonLabel6.Visible = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(10, 61);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel5.TabIndex = 15;
            this.kryptonLabel5.Values.Text = "RM lead time:";
            // 
            // chk_Urgent
            // 
            this.chk_Urgent.Location = new System.Drawing.Point(347, 11);
            this.chk_Urgent.Name = "chk_Urgent";
            this.chk_Urgent.Size = new System.Drawing.Size(61, 20);
            this.chk_Urgent.TabIndex = 6;
            this.chk_Urgent.Values.Text = "Urgent";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Location = new System.Drawing.Point(319, 11);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(17, 20);
            this.lbl_Unit.TabIndex = 12;
            this.lbl_Unit.Values.Text = "P";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(886, 51);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(123, 20);
            this.kryptonLabel4.TabIndex = 9;
            this.kryptonLabel4.Values.Text = "Confirmation orders:";
            this.kryptonLabel4.Visible = false;
            // 
            // cmb_SalesOrdersWithLines1
            // 
            this.cmb_SalesOrdersWithLines1.BatchId = 0;
            this.cmb_SalesOrdersWithLines1.Location = new System.Drawing.Point(691, 8);
            this.cmb_SalesOrdersWithLines1.Name = "cmb_SalesOrdersWithLines1";
            this.cmb_SalesOrdersWithLines1.QtyInCO = 0D;
            this.cmb_SalesOrdersWithLines1.SalesOrder = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            this.cmb_SalesOrdersWithLines1.SalesOrderLine = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            this.cmb_SalesOrdersWithLines1.Size = new System.Drawing.Size(210, 21);
            this.cmb_SalesOrdersWithLines1.TabIndex = 1;
            this.cmb_SalesOrdersWithLines1.Visible = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Batch:";
            // 
            // txt_Batch
            // 
            this.txt_Batch.Location = new System.Drawing.Point(67, 10);
            this.txt_Batch.Name = "txt_Batch";
            this.txt_Batch.Size = new System.Drawing.Size(88, 21);
            this.txt_Batch.StateActive.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Batch.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Batch.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Batch.StateNormal.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Batch.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Batch.TabIndex = 8;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(166, 10);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Qty in batch:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.AllowDecimalSeparator = true;
            this.txt_Qty.AllowSpace = false;
            this.txt_Qty.Location = new System.Drawing.Point(252, 10);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(61, 21);
            this.txt_Qty.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Qty.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Qty.TabIndex = 3;
            this.txt_Qty.Text = "0";
            this.txt_Qty.Enter += new System.EventHandler(this.txt_Qty_Enter);
            this.txt_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            this.txt_Qty.Validated += new System.EventHandler(this.txt_Qty_Validated);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(10, 35);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Article:";
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
            this.cmb_Articles1.Location = new System.Drawing.Point(67, 35);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(341, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 2;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleChanged += new Odin.CMB_Components.Articles.ArticlesEventHandler(this.cmb_Articles1_ArticleChanged);
            this.cmb_Articles1.ArticleValidated += new Odin.CMB_Components.Articles.ArticleValidatedEventHandler(this.cmb_Articles1_ArticleValidated);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = null;
            this.bn_List.DeleteItem = null;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Spoilage,
            this.btn_AddNorm,
            this.btn_AddSubProduct,
            this.btn_DeleteNorm,
            this.toolStripLabel1,
            this.cmb_Unit,
            this.toolStripLabel2,
            this.cmb_Decimals,
            this.btn_Round,
            this.btn_Clear,
            this.btn_Save});
            this.bn_List.Location = new System.Drawing.Point(0, 136);
            this.bn_List.MoveFirstItem = null;
            this.bn_List.MoveLastItem = null;
            this.bn_List.MoveNextItem = null;
            this.bn_List.MovePreviousItem = null;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = null;
            this.bn_List.Size = new System.Drawing.Size(1289, 25);
            this.bn_List.TabIndex = 42;
            this.bn_List.Text = "Bill of materials";
            // 
            // btn_Spoilage
            // 
            this.btn_Spoilage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Spoilage.Image = global::Odin.Global_Resourses.trash_green;
            this.btn_Spoilage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Spoilage.Name = "btn_Spoilage";
            this.btn_Spoilage.Size = new System.Drawing.Size(23, 22);
            this.btn_Spoilage.Text = "btn_Spoilage";
            this.btn_Spoilage.ToolTipText = "Without spoilage";
            this.btn_Spoilage.Click += new System.EventHandler(this.btn_Spoilage_Click);
            // 
            // btn_AddNorm
            // 
            this.btn_AddNorm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNorm.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNorm.Image")));
            this.btn_AddNorm.Name = "btn_AddNorm";
            this.btn_AddNorm.RightToLeftAutoMirrorImage = true;
            this.btn_AddNorm.Size = new System.Drawing.Size(23, 22);
            this.btn_AddNorm.Text = "Add new";
            this.btn_AddNorm.Click += new System.EventHandler(this.btn_AddNorm_Click);
            // 
            // btn_AddSubProduct
            // 
            this.btn_AddSubProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddSubProduct.Image = global::Odin.Global_Resourses.node_tree_add;
            this.btn_AddSubProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddSubProduct.Name = "btn_AddSubProduct";
            this.btn_AddSubProduct.Size = new System.Drawing.Size(23, 22);
            this.btn_AddSubProduct.Text = "Add sub-product";
            this.btn_AddSubProduct.Click += new System.EventHandler(this.btn_AddSubProduct_Click);
            // 
            // btn_DeleteNorm
            // 
            this.btn_DeleteNorm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteNorm.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteNorm.Image")));
            this.btn_DeleteNorm.Name = "btn_DeleteNorm";
            this.btn_DeleteNorm.RightToLeftAutoMirrorImage = true;
            this.btn_DeleteNorm.Size = new System.Drawing.Size(23, 22);
            this.btn_DeleteNorm.Text = "Delete";
            this.btn_DeleteNorm.Click += new System.EventHandler(this.btn_DeleteNorm_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Round";
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(18, 22);
            this.toolStripLabel2.Text = "to";
            // 
            // cmb_Decimals
            // 
            this.cmb_Decimals.Name = "cmb_Decimals";
            this.cmb_Decimals.Size = new System.Drawing.Size(75, 25);
            // 
            // btn_Round
            // 
            this.btn_Round.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Round.Image = global::Odin.Global_Resourses.Ok;
            this.btn_Round.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Round.Name = "btn_Round";
            this.btn_Round.Size = new System.Drawing.Size(23, 22);
            this.btn_Round.Text = "Round selected units";
            this.btn_Round.Click += new System.EventHandler(this.btn_Round_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Clear.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(23, 22);
            this.btn_Clear.Text = "Clear quantities to previous state ";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(23, 22);
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 5F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "coid";
            this.dataGridViewTextBoxColumn2.FillWeight = 5F;
            this.dataGridViewTextBoxColumn2.HeaderText = "coid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "order";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "line";
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Line";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn5.FillWeight = 120F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Article";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "artid";
            this.dataGridViewTextBoxColumn6.FillWeight = 70F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Art. id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn7.FillWeight = 65F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 65;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "reqdate";
            this.dataGridViewTextBoxColumn8.FillWeight = 90F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Req. date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "customer";
            this.dataGridViewTextBoxColumn9.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // tv_BOM
            // 
            this.tv_BOM.AllowUserToAddRows = false;
            this.tv_BOM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tv_BOM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tv_BOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tv_BOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachmentColumn,
            this.cn_nArticle,
            this.cn_nCheck,
            this.cn_nArtId,
            this.cn_nUnit,
            this.cn_nQtyDefault,
            this.cn_nQtyInBatch,
            this.cn_nSubProdQty,
            this.cn_nWithSpoil,
            this.cn_nQtyDefOldB,
            this.cn_nBatchId,
            this.cn_nSubProd,
            this.cn_nCSEArtId,
            this.cn_nChildBatchId,
            this.cn_nBatchHeadId,
            this.cn_nQtyStock,
            this.cn_nQtyAvailable,
            this.cn_nWaitingPOQty,
            this.cn_WPODelivDate,
            this.cn_POrder,
            this.cn_Supplier,
            this.cn_nSubProdQtyOld,
            this.cn_nQtyNom,
            this.cn_nSpoilNorm,
            this.cn_nNumDecimals,
            this.cn_nSpoilConst,
            this.cn_nSubBatch,
            this.cn_nStage,
            this.cn_Comments,
            this.cn_ndetisactive,
            this.cn_qtygiven,
            this.cn_dnp});
            this.tv_BOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_BOM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tv_BOM.ImageList = null;
            this.tv_BOM.Location = new System.Drawing.Point(0, 161);
            this.tv_BOM.Name = "tv_BOM";
            this.tv_BOM.RowHeadersWidth = 25;
            this.tv_BOM.ShowCellErrors = false;
            this.tv_BOM.ShowRowErrors = false;
            this.tv_BOM.Size = new System.Drawing.Size(1289, 392);
            this.tv_BOM.TabIndex = 43;
            this.tv_BOM.NodeExpanding += new AdvancedDataGridView.ExpandingEventHandler(this.tv_BOM_NodeExpanding);
            this.tv_BOM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tv_BOM_CellContentClick);
            this.tv_BOM.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tv_BOM_CellValidated);
            // 
            // attachmentColumn
            // 
            this.attachmentColumn.HeaderText = "attachmentColumn1";
            this.attachmentColumn.Name = "attachmentColumn";
            this.attachmentColumn.Visible = false;
            // 
            // cn_nArticle
            // 
            this.cn_nArticle.DefaultNodeImage = null;
            this.cn_nArticle.FillWeight = 200F;
            this.cn_nArticle.HeaderText = "Article";
            this.cn_nArticle.Name = "cn_nArticle";
            this.cn_nArticle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_nArticle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nArticle.Width = 200;
            // 
            // cn_nCheck
            // 
            this.cn_nCheck.FillWeight = 40F;
            this.cn_nCheck.HeaderText = "Create ";
            this.cn_nCheck.Name = "cn_nCheck";
            this.cn_nCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_nCheck.Visible = false;
            this.cn_nCheck.Width = 40;
            // 
            // cn_nArtId
            // 
            this.cn_nArtId.FillWeight = 80F;
            this.cn_nArtId.HeaderText = "Art. id";
            this.cn_nArtId.Name = "cn_nArtId";
            this.cn_nArtId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nArtId.Width = 80;
            // 
            // cn_nUnit
            // 
            this.cn_nUnit.FillWeight = 40F;
            this.cn_nUnit.HeaderText = "Unit";
            this.cn_nUnit.Name = "cn_nUnit";
            this.cn_nUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nUnit.Width = 40;
            // 
            // cn_nQtyDefault
            // 
            this.cn_nQtyDefault.FillWeight = 70F;
            this.cn_nQtyDefault.HeaderText = "Default qty";
            this.cn_nQtyDefault.Name = "cn_nQtyDefault";
            this.cn_nQtyDefault.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyDefault.Width = 70;
            // 
            // cn_nQtyInBatch
            // 
            this.cn_nQtyInBatch.FillWeight = 70F;
            this.cn_nQtyInBatch.HeaderText = "RM Qty in batch";
            this.cn_nQtyInBatch.Name = "cn_nQtyInBatch";
            this.cn_nQtyInBatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyInBatch.Width = 70;
            // 
            // cn_nSubProdQty
            // 
            this.cn_nSubProdQty.FillWeight = 70F;
            this.cn_nSubProdQty.HeaderText = "Sub prod. qty";
            this.cn_nSubProdQty.Name = "cn_nSubProdQty";
            this.cn_nSubProdQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nSubProdQty.Width = 70;
            // 
            // cn_nWithSpoil
            // 
            this.cn_nWithSpoil.FalseValue = "0";
            this.cn_nWithSpoil.FillWeight = 40F;
            this.cn_nWithSpoil.HeaderText = "Spoil";
            this.cn_nWithSpoil.IndeterminateValue = "1";
            this.cn_nWithSpoil.Name = "cn_nWithSpoil";
            this.cn_nWithSpoil.TrueValue = "-1";
            this.cn_nWithSpoil.Width = 40;
            // 
            // cn_nQtyDefOldB
            // 
            this.cn_nQtyDefOldB.HeaderText = "QtyDefOldB";
            this.cn_nQtyDefOldB.Name = "cn_nQtyDefOldB";
            this.cn_nQtyDefOldB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_nQtyDefOldB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyDefOldB.Visible = false;
            // 
            // cn_nBatchId
            // 
            this.cn_nBatchId.HeaderText = "BatchDetId";
            this.cn_nBatchId.Name = "cn_nBatchId";
            this.cn_nBatchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nBatchId.Visible = false;
            // 
            // cn_nSubProd
            // 
            this.cn_nSubProd.HeaderText = "SubProd";
            this.cn_nSubProd.Name = "cn_nSubProd";
            this.cn_nSubProd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nSubProd.Visible = false;
            // 
            // cn_nCSEArtId
            // 
            this.cn_nCSEArtId.HeaderText = "CSEArtId";
            this.cn_nCSEArtId.Name = "cn_nCSEArtId";
            this.cn_nCSEArtId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nCSEArtId.Visible = false;
            // 
            // cn_nChildBatchId
            // 
            this.cn_nChildBatchId.HeaderText = "ChildBatchId";
            this.cn_nChildBatchId.Name = "cn_nChildBatchId";
            this.cn_nChildBatchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nChildBatchId.Visible = false;
            // 
            // cn_nBatchHeadId
            // 
            this.cn_nBatchHeadId.HeaderText = "BatchHeadId";
            this.cn_nBatchHeadId.Name = "cn_nBatchHeadId";
            this.cn_nBatchHeadId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nBatchHeadId.Visible = false;
            // 
            // cn_nQtyStock
            // 
            this.cn_nQtyStock.FillWeight = 80F;
            this.cn_nQtyStock.HeaderText = "Qty stock";
            this.cn_nQtyStock.Name = "cn_nQtyStock";
            this.cn_nQtyStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyStock.Width = 80;
            // 
            // cn_nQtyAvailable
            // 
            this.cn_nQtyAvailable.FillWeight = 80F;
            this.cn_nQtyAvailable.HeaderText = "Available";
            this.cn_nQtyAvailable.Name = "cn_nQtyAvailable";
            this.cn_nQtyAvailable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyAvailable.Width = 80;
            // 
            // cn_nWaitingPOQty
            // 
            this.cn_nWaitingPOQty.FillWeight = 90F;
            this.cn_nWaitingPOQty.HeaderText = "Waiting in PO";
            this.cn_nWaitingPOQty.Name = "cn_nWaitingPOQty";
            this.cn_nWaitingPOQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nWaitingPOQty.Width = 90;
            // 
            // cn_WPODelivDate
            // 
            this.cn_WPODelivDate.DataPropertyName = "WaitingPODate";
            this.cn_WPODelivDate.FillWeight = 80F;
            this.cn_WPODelivDate.HeaderText = "Deliv. date";
            this.cn_WPODelivDate.Name = "cn_WPODelivDate";
            this.cn_WPODelivDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_WPODelivDate.Width = 80;
            // 
            // cn_POrder
            // 
            this.cn_POrder.DataPropertyName = "POrder";
            this.cn_POrder.FillWeight = 80F;
            this.cn_POrder.HeaderText = "Pur. order";
            this.cn_POrder.Name = "cn_POrder";
            this.cn_POrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_POrder.Width = 80;
            // 
            // cn_Supplier
            // 
            this.cn_Supplier.DataPropertyName = "Supplier";
            this.cn_Supplier.HeaderText = "Supplier";
            this.cn_Supplier.Name = "cn_Supplier";
            this.cn_Supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_nSubProdQtyOld
            // 
            this.cn_nSubProdQtyOld.HeaderText = "SubProdQtyOld";
            this.cn_nSubProdQtyOld.Name = "cn_nSubProdQtyOld";
            this.cn_nSubProdQtyOld.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nSubProdQtyOld.Visible = false;
            // 
            // cn_nQtyNom
            // 
            this.cn_nQtyNom.HeaderText = "QtyNom";
            this.cn_nQtyNom.Name = "cn_nQtyNom";
            this.cn_nQtyNom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyNom.Visible = false;
            // 
            // cn_nSpoilNorm
            // 
            this.cn_nSpoilNorm.HeaderText = "SpoilNorm";
            this.cn_nSpoilNorm.Name = "cn_nSpoilNorm";
            this.cn_nSpoilNorm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nSpoilNorm.Visible = false;
            // 
            // cn_nNumDecimals
            // 
            this.cn_nNumDecimals.HeaderText = "NumDecimals";
            this.cn_nNumDecimals.Name = "cn_nNumDecimals";
            this.cn_nNumDecimals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nNumDecimals.Visible = false;
            // 
            // cn_nSpoilConst
            // 
            this.cn_nSpoilConst.HeaderText = "SpoilConst";
            this.cn_nSpoilConst.Name = "cn_nSpoilConst";
            this.cn_nSpoilConst.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nSpoilConst.Visible = false;
            // 
            // cn_nSubBatch
            // 
            this.cn_nSubBatch.HeaderText = "Sub-batch";
            this.cn_nSubBatch.Name = "cn_nSubBatch";
            this.cn_nSubBatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_nStage
            // 
            this.cn_nStage.FillWeight = 60F;
            this.cn_nStage.HeaderText = "Stage";
            this.cn_nStage.Name = "cn_nStage";
            this.cn_nStage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nStage.Width = 60;
            // 
            // cn_Comments
            // 
            this.cn_Comments.FillWeight = 150F;
            this.cn_Comments.HeaderText = "Comments";
            this.cn_Comments.Name = "cn_Comments";
            this.cn_Comments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_Comments.Width = 150;
            // 
            // cn_ndetisactive
            // 
            this.cn_ndetisactive.FalseValue = "0";
            this.cn_ndetisactive.FillWeight = 40F;
            this.cn_ndetisactive.HeaderText = "Active line";
            this.cn_ndetisactive.IndeterminateValue = "1";
            this.cn_ndetisactive.Name = "cn_ndetisactive";
            this.cn_ndetisactive.TrueValue = "-1";
            this.cn_ndetisactive.Width = 40;
            // 
            // cn_qtygiven
            // 
            this.cn_qtygiven.HeaderText = "Given";
            this.cn_qtygiven.Name = "cn_qtygiven";
            this.cn_qtygiven.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_qtygiven.Visible = false;
            // 
            // cn_dnp
            // 
            this.cn_dnp.DataPropertyName = "dnp";
            this.cn_dnp.FalseValue = "0";
            this.cn_dnp.FillWeight = 40F;
            this.cn_dnp.HeaderText = "DNP";
            this.cn_dnp.IndeterminateValue = "1";
            this.cn_dnp.Name = "cn_dnp";
            this.cn_dnp.TrueValue = "-1";
            this.cn_dnp.Width = 40;
            // 
            // ctl_CreatBatchDets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tv_BOM);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_CreatBatchDets";
            this.Size = new System.Drawing.Size(1289, 553);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Orders)).EndInit();
            this.bn_Orders.ResumeLayout(false);
            this.bn_Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_BOM)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Batch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Owf.Controls.NumericTetxBox txt_Qty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Urgent;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Unit;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripButton btn_AddNorm;
        private System.Windows.Forms.ToolStripButton btn_AddSubProduct;
        private System.Windows.Forms.ToolStripButton btn_DeleteNorm;
        private AdvancedDataGridView.TreeGridView tv_BOM;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmb_Unit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmb_Decimals;
        private System.Windows.Forms.ToolStripButton btn_Round;
        private System.Windows.Forms.ToolStripButton btn_Clear;
        private System.Windows.Forms.ToolStripButton btn_Spoilage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        public CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.BindingNavigator bn_Orders;
        private System.Windows.Forms.ToolStripButton btn_AddNewOrder;
        private System.Windows.Forms.ToolStripButton btn_DeleteOrder;
        private System.Data.DataSet ds_Orders;
        private System.Data.DataTable dt_Orders;
        private System.Data.DataColumn dcid;
        private System.Data.DataColumn dccoid;
        private System.Data.DataColumn dcorder;
        private System.Data.DataColumn dcline;
        private System.Data.DataColumn dcarticle;
        private System.Data.DataColumn dcartid;
        private System.Data.DataColumn dcqty;
        private System.Data.DataColumn dcreqdate;
        private System.Data.DataColumn dccustomer;
        public CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private System.Windows.Forms.BindingSource bs_Orders;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oreqdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ocustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtyforbatch;
        private CustomControls.NullableDateTimePicker txt_StartDate;
        private CustomControls.NullableDateTimePicker txt_EndDate;
        private System.Windows.Forms.DataGridViewImageColumn attachmentColumn;
        private AdvancedDataGridView.TreeGridColumn cn_nArticle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_nCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nArtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyInBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nSubProdQty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_nWithSpoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyDefOldB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nSubProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nCSEArtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nChildBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nBatchHeadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nWaitingPOQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_WPODelivDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_POrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nSubProdQtyOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nSpoilNorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nNumDecimals;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nSpoilConst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nSubBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Comments;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_ndetisactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtygiven;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_dnp;
    }
}
