namespace Odin.Warehouse.Deliveries
{
    partial class frm_AddDeliveryDets
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddDeliveryDets));
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmb_Packages1 = new Odin.CMB_Components.Package.cmb_Packages();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_WeightNet = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel28 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_WeightBrut = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_PackQty = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Available = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.chk_Return = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CostUP = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_LeftToSend = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CoefConv = new Owf.Controls.NumericTetxBox();
            this.cmb_Units1 = new Odin.CMB_Components.Units.cmb_Units();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CustArticle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_CustCodes1 = new Odin.CMB_Components.CustCodes.cmb_CustCodes();
            this.lbl_SellPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_UnitPrice = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Qty = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_CustOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_ConfOrder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Delivery = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_did = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dconforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ostate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_confdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ddelivplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_daddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_custarticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_Dets = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_AddOrder = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteOrderLine = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Delivery = new System.Windows.Forms.BindingSource(this.components);
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_inid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cn_totake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_iplaceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_iplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Delivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Dets)).BeginInit();
            this.bn_Dets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Delivery)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.cmb_Packages1);
            this.kryptonPanel2.Controls.Add(this.btn_OK);
            this.kryptonPanel2.Controls.Add(this.txt_WeightNet);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel28);
            this.kryptonPanel2.Controls.Add(this.txt_WeightBrut);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.txt_PackQty);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 518);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(971, 49);
            this.kryptonPanel2.TabIndex = 31;
            // 
            // cmb_Packages1
            // 
            this.cmb_Packages1.EnableSearchId = false;
            this.cmb_Packages1.Location = new System.Drawing.Point(568, 17);
            this.cmb_Packages1.Name = "cmb_Packages1";
            this.cmb_Packages1.Package = "";
            this.cmb_Packages1.PackageId = 0;
            this.cmb_Packages1.Size = new System.Drawing.Size(143, 20);
            this.cmb_Packages1.TabIndex = 299;
            this.cmb_Packages1.Visible = false;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(873, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OK.Size = new System.Drawing.Size(93, 39);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_WeightNet
            // 
            this.txt_WeightNet.AllowDecimalSeparator = true;
            this.txt_WeightNet.AllowSpace = false;
            this.txt_WeightNet.Location = new System.Drawing.Point(115, 17);
            this.txt_WeightNet.Name = "txt_WeightNet";
            this.txt_WeightNet.Size = new System.Drawing.Size(64, 23);
            this.txt_WeightNet.TabIndex = 278;
            this.txt_WeightNet.Text = "0";
            this.txt_WeightNet.Visible = false;
            // 
            // kryptonLabel28
            // 
            this.kryptonLabel28.Location = new System.Drawing.Point(14, 17);
            this.kryptonLabel28.Name = "kryptonLabel28";
            this.kryptonLabel28.Size = new System.Drawing.Size(95, 20);
            this.kryptonLabel28.TabIndex = 279;
            this.kryptonLabel28.Values.Text = "Weight net(kg):";
            this.kryptonLabel28.Visible = false;
            // 
            // txt_WeightBrut
            // 
            this.txt_WeightBrut.AllowDecimalSeparator = true;
            this.txt_WeightBrut.AllowSpace = false;
            this.txt_WeightBrut.Location = new System.Drawing.Point(294, 17);
            this.txt_WeightBrut.Name = "txt_WeightBrut";
            this.txt_WeightBrut.Size = new System.Drawing.Size(64, 23);
            this.txt_WeightBrut.TabIndex = 280;
            this.txt_WeightBrut.Text = "0";
            this.txt_WeightBrut.Visible = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(185, 17);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(100, 20);
            this.kryptonLabel4.TabIndex = 281;
            this.kryptonLabel4.Values.Text = "Weight brut(kg):";
            this.kryptonLabel4.Visible = false;
            // 
            // txt_PackQty
            // 
            this.txt_PackQty.AllowDecimalSeparator = true;
            this.txt_PackQty.AllowSpace = false;
            this.txt_PackQty.Location = new System.Drawing.Point(450, 17);
            this.txt_PackQty.Name = "txt_PackQty";
            this.txt_PackQty.Size = new System.Drawing.Size(48, 23);
            this.txt_PackQty.TabIndex = 286;
            this.txt_PackQty.Text = "0";
            this.txt_PackQty.Visible = false;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(364, 17);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel10.TabIndex = 287;
            this.kryptonLabel10.Values.Text = "Package qty:";
            this.kryptonLabel10.Visible = false;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(504, 17);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel11.TabIndex = 289;
            this.kryptonLabel11.Values.Text = "Package:";
            this.kryptonLabel11.Visible = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.txt_Available);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel1.Controls.Add(this.btn_Refresh);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(971, 75);
            this.kryptonPanel1.TabIndex = 33;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(773, 39);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(83, 20);
            this.kryptonLabel8.TabIndex = 55;
            this.kryptonLabel8.Values.Text = "Available qty:";
            // 
            // txt_Available
            // 
            this.txt_Available.AllowDecimalSeparator = true;
            this.txt_Available.AllowSpace = false;
            this.txt_Available.Location = new System.Drawing.Point(873, 39);
            this.txt_Available.Name = "txt_Available";
            this.txt_Available.ReadOnly = true;
            this.txt_Available.Size = new System.Drawing.Size(86, 21);
            this.txt_Available.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Available.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Available.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Available.TabIndex = 54;
            this.txt_Available.Text = "0";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 40);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel2.TabIndex = 49;
            this.kryptonLabel2.Values.Text = "Article:";
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
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(79, 40);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(265, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 48;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleChanged += new Odin.CMB_Components.Articles.ArticlesEventHandler(this.cmb_Articles1_ArticleChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 17);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 28;
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
            this.cmb_Batches1.Location = new System.Drawing.Point(79, 17);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(124, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 27;
            this.cmb_Batches1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches1_BatchChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Refresh.Location = new System.Drawing.Point(365, 17);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Refresh.Size = new System.Drawing.Size(47, 43);
            this.btn_Refresh.TabIndex = 26;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.chk_Return);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel16);
            this.kryptonPanel3.Controls.Add(this.txt_CostUP);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel15);
            this.kryptonPanel3.Controls.Add(this.txt_LeftToSend);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel3.Controls.Add(this.txt_CoefConv);
            this.kryptonPanel3.Controls.Add(this.cmb_Units1);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel3.Controls.Add(this.txt_Comments);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel3.Controls.Add(this.txt_CustArticle);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel3.Controls.Add(this.cmb_CustCodes1);
            this.kryptonPanel3.Controls.Add(this.lbl_SellPrice);
            this.kryptonPanel3.Controls.Add(this.txt_UnitPrice);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel3.Controls.Add(this.txt_Qty);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel3.Controls.Add(this.txt_CustOrder);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel3.Controls.Add(this.txt_ConfOrder);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 435);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel3.Size = new System.Drawing.Size(971, 83);
            this.kryptonPanel3.TabIndex = 34;
            // 
            // chk_Return
            // 
            this.chk_Return.Location = new System.Drawing.Point(594, 57);
            this.chk_Return.Name = "chk_Return";
            this.chk_Return.Size = new System.Drawing.Size(60, 20);
            this.chk_Return.TabIndex = 299;
            this.chk_Return.Values.Text = "Return";
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(665, 33);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(70, 20);
            this.kryptonLabel16.TabIndex = 298;
            this.kryptonLabel16.Values.Text = "Cost UP(€):";
            // 
            // txt_CostUP
            // 
            this.txt_CostUP.AllowDecimalSeparator = false;
            this.txt_CostUP.AllowSpace = false;
            this.txt_CostUP.Enabled = false;
            this.txt_CostUP.Location = new System.Drawing.Point(741, 32);
            this.txt_CostUP.Name = "txt_CostUP";
            this.txt_CostUP.Size = new System.Drawing.Size(66, 21);
            this.txt_CostUP.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_CostUP.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_CostUP.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.txt_CostUP.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_CostUP.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_CostUP.TabIndex = 297;
            this.txt_CostUP.Text = "0";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(182, 31);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel15.TabIndex = 296;
            this.kryptonLabel15.Values.Text = "Left to send:";
            // 
            // txt_LeftToSend
            // 
            this.txt_LeftToSend.AllowDecimalSeparator = true;
            this.txt_LeftToSend.AllowSpace = false;
            this.txt_LeftToSend.Enabled = false;
            this.txt_LeftToSend.Location = new System.Drawing.Point(291, 32);
            this.txt_LeftToSend.Name = "txt_LeftToSend";
            this.txt_LeftToSend.Size = new System.Drawing.Size(64, 21);
            this.txt_LeftToSend.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txt_LeftToSend.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_LeftToSend.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_LeftToSend.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.txt_LeftToSend.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_LeftToSend.TabIndex = 295;
            this.txt_LeftToSend.Text = "0";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(813, 33);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(70, 20);
            this.kryptonLabel14.TabIndex = 294;
            this.kryptonLabel14.Values.Text = "Coef. conv:";
            // 
            // txt_CoefConv
            // 
            this.txt_CoefConv.AllowDecimalSeparator = true;
            this.txt_CoefConv.AllowSpace = false;
            this.txt_CoefConv.Location = new System.Drawing.Point(900, 32);
            this.txt_CoefConv.Name = "txt_CoefConv";
            this.txt_CoefConv.Size = new System.Drawing.Size(59, 23);
            this.txt_CoefConv.TabIndex = 293;
            this.txt_CoefConv.Text = "1";
            this.txt_CoefConv.TextChanged += new System.EventHandler(this.txt_CoefConv_TextChanged);
            // 
            // cmb_Units1
            // 
            this.cmb_Units1.EnableSearchId = false;
            this.cmb_Units1.Location = new System.Drawing.Point(424, 32);
            this.cmb_Units1.Name = "cmb_Units1";
            this.cmb_Units1.Size = new System.Drawing.Size(71, 20);
            this.cmb_Units1.TabIndex = 292;
            this.cmb_Units1.Unit = "";
            this.cmb_Units1.UnitId = 0;
            this.cmb_Units1.UnitChanged += new Odin.CMB_Components.Units.UnitEventHandler(this.cmb_Units1_UnitChanged);
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(11, 57);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel13.TabIndex = 291;
            this.kryptonLabel13.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_Comments.Location = new System.Drawing.Point(112, 57);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(454, 23);
            this.txt_Comments.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Comments.TabIndex = 290;
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny4.UniqueName = "00654834D5824273E0820F141B99704A";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(665, 6);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(110, 20);
            this.kryptonLabel9.TabIndex = 285;
            this.kryptonLabel9.Values.Text = "Customer\'s article:";
            // 
            // txt_CustArticle
            // 
            this.txt_CustArticle.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_CustArticle.Location = new System.Drawing.Point(783, 6);
            this.txt_CustArticle.Name = "txt_CustArticle";
            this.txt_CustArticle.Size = new System.Drawing.Size(176, 23);
            this.txt_CustArticle.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_CustArticle.TabIndex = 284;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "00654834D5824273E0820F141B99704A";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(665, 57);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel5.TabIndex = 283;
            this.kryptonLabel5.Values.Text = "Custom\'s code:";
            // 
            // cmb_CustCodes1
            // 
            this.cmb_CustCodes1.CustCode = "";
            this.cmb_CustCodes1.CustCodeId = 0;
            this.cmb_CustCodes1.EnableSearchId = false;
            this.cmb_CustCodes1.Location = new System.Drawing.Point(783, 57);
            this.cmb_CustCodes1.Name = "cmb_CustCodes1";
            this.cmb_CustCodes1.Size = new System.Drawing.Size(176, 20);
            this.cmb_CustCodes1.TabIndex = 282;
            // 
            // lbl_SellPrice
            // 
            this.lbl_SellPrice.Location = new System.Drawing.Point(501, 32);
            this.lbl_SellPrice.Name = "lbl_SellPrice";
            this.lbl_SellPrice.Size = new System.Drawing.Size(65, 20);
            this.lbl_SellPrice.TabIndex = 57;
            this.lbl_SellPrice.Values.Text = "Sell UP(€):";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.AllowDecimalSeparator = false;
            this.txt_UnitPrice.AllowSpace = false;
            this.txt_UnitPrice.Enabled = false;
            this.txt_UnitPrice.Location = new System.Drawing.Point(594, 32);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(65, 21);
            this.txt_UnitPrice.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_UnitPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_UnitPrice.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.txt_UnitPrice.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_UnitPrice.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_UnitPrice.TabIndex = 56;
            this.txt_UnitPrice.Text = "0";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(361, 32);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel7.TabIndex = 55;
            this.kryptonLabel7.Values.Text = "Unit:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(11, 31);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(97, 20);
            this.kryptonLabel6.TabIndex = 53;
            this.kryptonLabel6.Values.Text = "Qty for delivery:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.AllowDecimalSeparator = true;
            this.txt_Qty.AllowSpace = false;
            this.txt_Qty.Location = new System.Drawing.Point(112, 31);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.ReadOnly = true;
            this.txt_Qty.Size = new System.Drawing.Size(64, 21);
            this.txt_Qty.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_Qty.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Qty.TabIndex = 52;
            this.txt_Qty.Text = "0";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(361, 6);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(107, 20);
            this.kryptonLabel3.TabIndex = 51;
            this.kryptonLabel3.Values.Text = "Customer\'s order:";
            // 
            // txt_CustOrder
            // 
            this.txt_CustOrder.Enabled = false;
            this.txt_CustOrder.Location = new System.Drawing.Point(474, 6);
            this.txt_CustOrder.Name = "txt_CustOrder";
            this.txt_CustOrder.Size = new System.Drawing.Size(185, 23);
            this.txt_CustOrder.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.txt_CustOrder.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_CustOrder.TabIndex = 50;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(11, 5);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(165, 20);
            this.kryptonLabel12.TabIndex = 49;
            this.kryptonLabel12.Values.Text = "Selected confirmation order:";
            // 
            // txt_ConfOrder
            // 
            this.txt_ConfOrder.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_ConfOrder.Location = new System.Drawing.Point(182, 6);
            this.txt_ConfOrder.Name = "txt_ConfOrder";
            this.txt_ConfOrder.ReadOnly = true;
            this.txt_ConfOrder.Size = new System.Drawing.Size(173, 21);
            this.txt_ConfOrder.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ConfOrder.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_ConfOrder.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_ConfOrder.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ConfOrder.TabIndex = 48;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "00654834D5824273E0820F141B99704A";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 248);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_Delivery);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.bn_Dets);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(971, 187);
            this.kryptonHeaderGroup1.TabIndex = 37;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "List of orders for selected batch";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.Docs24x24;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Please select necessary line and add it into list below";
            // 
            // gv_Delivery
            // 
            this.gv_Delivery.AllowUserToAddRows = false;
            this.gv_Delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Delivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_did,
            this.cn_dcoid,
            this.cn_dconforder,
            this.cn_ostate,
            this.cn_dclient,
            this.cn_confdate,
            this.cn_dqty,
            this.cn_dunit,
            this.cn_oUnitPrice,
            this.cn_currency,
            this.cn_custorder,
            this.cn_ddelivplace,
            this.cn_daddress,
            this.cn_custarticle,
            this.cn_dcomments});
            this.gv_Delivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Delivery.Location = new System.Drawing.Point(0, 0);
            this.gv_Delivery.Name = "gv_Delivery";
            this.gv_Delivery.RowHeadersWidth = 25;
            this.gv_Delivery.Size = new System.Drawing.Size(969, 133);
            this.gv_Delivery.TabIndex = 6;
            this.gv_Delivery.SelectionChanged += new System.EventHandler(this.gv_Delivery_SelectionChanged);
            // 
            // cn_did
            // 
            this.cn_did.DataPropertyName = "id";
            this.cn_did.FillWeight = 5F;
            this.cn_did.HeaderText = "id";
            this.cn_did.Name = "cn_did";
            this.cn_did.ReadOnly = true;
            this.cn_did.Visible = false;
            this.cn_did.Width = 5;
            // 
            // cn_dcoid
            // 
            this.cn_dcoid.DataPropertyName = "coid";
            this.cn_dcoid.FillWeight = 80F;
            this.cn_dcoid.HeaderText = "coid";
            this.cn_dcoid.Name = "cn_dcoid";
            this.cn_dcoid.ReadOnly = true;
            this.cn_dcoid.Visible = false;
            this.cn_dcoid.Width = 80;
            // 
            // cn_dconforder
            // 
            this.cn_dconforder.DataPropertyName = "conforder";
            this.cn_dconforder.HeaderText = "Conf. order";
            this.cn_dconforder.Name = "cn_dconforder";
            this.cn_dconforder.ReadOnly = true;
            // 
            // cn_ostate
            // 
            this.cn_ostate.DataPropertyName = "orderstate";
            this.cn_ostate.HeaderText = "State";
            this.cn_ostate.Name = "cn_ostate";
            // 
            // cn_dclient
            // 
            this.cn_dclient.DataPropertyName = "client";
            this.cn_dclient.FillWeight = 120F;
            this.cn_dclient.HeaderText = "Customer";
            this.cn_dclient.Name = "cn_dclient";
            this.cn_dclient.ReadOnly = true;
            this.cn_dclient.Width = 120;
            // 
            // cn_confdate
            // 
            this.cn_confdate.DataPropertyName = "confdate";
            this.cn_confdate.HeaderText = "Conf. date";
            this.cn_confdate.Name = "cn_confdate";
            // 
            // cn_dqty
            // 
            this.cn_dqty.DataPropertyName = "confqty";
            this.cn_dqty.FillWeight = 90F;
            this.cn_dqty.HeaderText = "Conf. qty";
            this.cn_dqty.Name = "cn_dqty";
            this.cn_dqty.ReadOnly = true;
            this.cn_dqty.Width = 90;
            // 
            // cn_dunit
            // 
            this.cn_dunit.DataPropertyName = "unit";
            this.cn_dunit.FillWeight = 40F;
            this.cn_dunit.HeaderText = "Unit";
            this.cn_dunit.Name = "cn_dunit";
            this.cn_dunit.ReadOnly = true;
            this.cn_dunit.Width = 40;
            // 
            // cn_oUnitPrice
            // 
            this.cn_oUnitPrice.DataPropertyName = "unitprice";
            this.cn_oUnitPrice.HeaderText = "Unit price";
            this.cn_oUnitPrice.Name = "cn_oUnitPrice";
            // 
            // cn_currency
            // 
            this.cn_currency.DataPropertyName = "currency";
            this.cn_currency.FillWeight = 50F;
            this.cn_currency.HeaderText = "Curr.";
            this.cn_currency.Name = "cn_currency";
            this.cn_currency.Width = 50;
            // 
            // cn_custorder
            // 
            this.cn_custorder.DataPropertyName = "custorder";
            this.cn_custorder.HeaderText = "Customer\'s order";
            this.cn_custorder.Name = "cn_custorder";
            // 
            // cn_ddelivplace
            // 
            this.cn_ddelivplace.DataPropertyName = "delivplace";
            this.cn_ddelivplace.FillWeight = 150F;
            this.cn_ddelivplace.HeaderText = "Deliv. place";
            this.cn_ddelivplace.Name = "cn_ddelivplace";
            this.cn_ddelivplace.ReadOnly = true;
            this.cn_ddelivplace.Width = 150;
            // 
            // cn_daddress
            // 
            this.cn_daddress.DataPropertyName = "delivaddress";
            this.cn_daddress.FillWeight = 125F;
            this.cn_daddress.HeaderText = "Deliv. address";
            this.cn_daddress.Name = "cn_daddress";
            this.cn_daddress.Width = 125;
            // 
            // cn_custarticle
            // 
            this.cn_custarticle.DataPropertyName = "custarticle";
            this.cn_custarticle.HeaderText = "Cust. article";
            this.cn_custarticle.Name = "cn_custarticle";
            // 
            // cn_dcomments
            // 
            this.cn_dcomments.DataPropertyName = "comments";
            this.cn_dcomments.FillWeight = 170F;
            this.cn_dcomments.HeaderText = "Comments";
            this.cn_dcomments.Name = "cn_dcomments";
            this.cn_dcomments.Width = 170;
            // 
            // bn_Dets
            // 
            this.bn_Dets.AddNewItem = null;
            this.bn_Dets.CountItem = this.bindingNavigatorCountItem;
            this.bn_Dets.DeleteItem = null;
            this.bn_Dets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Dets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Dets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btn_AddOrder,
            this.btn_DeleteOrderLine});
            this.bn_Dets.Location = new System.Drawing.Point(0, 133);
            this.bn_Dets.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_Dets.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_Dets.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_Dets.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_Dets.Name = "bn_Dets";
            this.bn_Dets.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_Dets.Size = new System.Drawing.Size(969, 25);
            this.bn_Dets.TabIndex = 0;
            this.bn_Dets.Text = "Details";
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
            // btn_AddOrder
            // 
            this.btn_AddOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddOrder.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddOrder.Image")));
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.RightToLeftAutoMirrorImage = true;
            this.btn_AddOrder.Size = new System.Drawing.Size(23, 22);
            this.btn_AddOrder.Text = "Add new";
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // btn_DeleteOrderLine
            // 
            this.btn_DeleteOrderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteOrderLine.Image = global::Odin.Global_Resourses.bindingNavigatorDeleteItem_Image;
            this.btn_DeleteOrderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteOrderLine.Name = "btn_DeleteOrderLine";
            this.btn_DeleteOrderLine.Size = new System.Drawing.Size(23, 22);
            this.btn_DeleteOrderLine.Text = "Delete line";
            this.btn_DeleteOrderLine.Click += new System.EventHandler(this.btn_DeleteOrderLine_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 245);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(971, 3);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 75);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(971, 170);
            this.kryptonHeaderGroup2.TabIndex = 39;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Stock details for batch/article";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.box24x24;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Please select necessary line and add it into list below";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_inid,
            this.cn_artid,
            this.cn_label,
            this.cn_article,
            this.cn_batch,
            this.cn_qty,
            this.cn_unit,
            this.btn_add,
            this.cn_totake,
            this.cn_unitprice,
            this.cn_iplaceid,
            this.cn_iplace,
            this.cn_expdate,
            this.cn_comments});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(969, 141);
            this.gv_List.TabIndex = 5;
            this.gv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellClick);
            this.gv_List.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellLeave);
            this.gv_List.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gv_List_CellPainting);
            this.gv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValidated);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.FillWeight = 5F;
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            this.cn_id.Width = 5;
            // 
            // cn_inid
            // 
            this.cn_inid.DataPropertyName = "inid";
            this.cn_inid.HeaderText = "inid";
            this.cn_inid.Name = "cn_inid";
            this.cn_inid.Visible = false;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.HeaderText = "artid";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.Visible = false;
            // 
            // cn_label
            // 
            this.cn_label.DataPropertyName = "label";
            this.cn_label.FillWeight = 80F;
            this.cn_label.HeaderText = "Label";
            this.cn_label.Name = "cn_label";
            this.cn_label.ReadOnly = true;
            this.cn_label.Width = 80;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 120F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.Width = 120;
            // 
            // cn_batch
            // 
            this.cn_batch.DataPropertyName = "batch";
            this.cn_batch.FillWeight = 80F;
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.Width = 80;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qtyrest";
            this.cn_qty.FillWeight = 80F;
            this.cn_qty.HeaderText = "Qty rest";
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
            // btn_add
            // 
            this.btn_add.FillWeight = 25F;
            this.btn_add.HeaderText = "";
            this.btn_add.Name = "btn_add";
            this.btn_add.Width = 25;
            // 
            // cn_totake
            // 
            this.cn_totake.FillWeight = 80F;
            this.cn_totake.HeaderText = "To send";
            this.cn_totake.Name = "cn_totake";
            this.cn_totake.Width = 80;
            // 
            // cn_unitprice
            // 
            this.cn_unitprice.DataPropertyName = "unitprice";
            this.cn_unitprice.HeaderText = "Unit price(BYN)";
            this.cn_unitprice.Name = "cn_unitprice";
            // 
            // cn_iplaceid
            // 
            this.cn_iplaceid.DataPropertyName = "placeid";
            this.cn_iplaceid.HeaderText = "placeid";
            this.cn_iplaceid.Name = "cn_iplaceid";
            this.cn_iplaceid.Visible = false;
            // 
            // cn_iplace
            // 
            this.cn_iplace.DataPropertyName = "place";
            this.cn_iplace.FillWeight = 150F;
            this.cn_iplace.HeaderText = "Place";
            this.cn_iplace.Name = "cn_iplace";
            this.cn_iplace.ReadOnly = true;
            this.cn_iplace.Width = 150;
            // 
            // cn_expdate
            // 
            this.cn_expdate.DataPropertyName = "expdate";
            this.cn_expdate.HeaderText = "Exp. date";
            this.cn_expdate.Name = "cn_expdate";
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 170F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.Width = 170;
            // 
            // frm_AddDeliveryDets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 567);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddDeliveryDets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add delivery details";
            this.Load += new System.EventHandler(this.frm_AddDeliveryDets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Delivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Dets)).EndInit();
            this.bn_Dets.ResumeLayout(false);
            this.bn_Dets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Delivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private BSE.Windows.Forms.Splitter splitter1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_ConfOrder;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_SellPrice;
        private Owf.Controls.NumericTetxBox txt_UnitPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Owf.Controls.NumericTetxBox txt_Qty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Owf.Controls.NumericTetxBox txt_PackQty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustArticle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private CMB_Components.CustCodes.cmb_CustCodes cmb_CustCodes1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Owf.Controls.NumericTetxBox txt_WeightBrut;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel28;
        private Owf.Controls.NumericTetxBox txt_WeightNet;
        private System.Windows.Forms.BindingSource bs_List;
        private System.Windows.Forms.BindingSource bs_Delivery;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Owf.Controls.NumericTetxBox txt_CoefConv;
        private CMB_Components.Units.cmb_Units cmb_Units1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Delivery;
        private System.Windows.Forms.BindingNavigator bn_Dets;
        private System.Windows.Forms.ToolStripButton btn_AddOrder;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Owf.Controls.NumericTetxBox txt_LeftToSend;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Owf.Controls.NumericTetxBox txt_CostUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_did;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dconforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ostate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_confdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ddelivplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_daddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_custarticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dcomments;
        private CMB_Components.Package.cmb_Packages cmb_Packages1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Return;
        private System.Windows.Forms.ToolStripButton btn_DeleteOrderLine;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Owf.Controls.NumericTetxBox txt_Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_totake;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_iplaceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_iplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_expdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
    }
}