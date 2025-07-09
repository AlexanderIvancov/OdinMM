namespace Odin.Planning.Controls
{
    partial class ctl_CreatBatchDetsP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_CreatBatchDetsP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.chk_CopyFTA = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chk_CopyTHT = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Serial = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Serial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_PCB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.chk_Urgent = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.txt_StartDate = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyCanBeBatch = new Owf.Controls.NumericTetxBox();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Customer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyInBP = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
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
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_FilterFor = new System.Windows.Forms.ToolStripTextBox();
            this.mni_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_FilterExcludingSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_RemoveFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentcolumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tv_BOM = new AdvancedDataGridView.TreeGridView();
            this.attachmentColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cn_nArticle = new AdvancedDataGridView.TreeGridColumn();
            this.cn_nUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_nArtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nBomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyInProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyInBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nWaitingQtyPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nQtyBOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nMaxQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nOrigArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nWaitigPODate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batchdetid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nstockforbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nFullPOInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dnp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_BOM)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.chk_CopyFTA);
            this.kryptonPanel1.Controls.Add(this.chk_CopyTHT);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel1.Controls.Add(this.lbl_Serial);
            this.kryptonPanel1.Controls.Add(this.txt_Serial);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.txt_PCB);
            this.kryptonPanel1.Controls.Add(this.chk_Urgent);
            this.kryptonPanel1.Controls.Add(this.txt_StartDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel1.Controls.Add(this.btn_Refresh);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel1.Controls.Add(this.txt_QtyCanBeBatch);
            this.kryptonPanel1.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.txt_Customer);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.txt_QtyInBP);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.txt_Comments);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(1296, 202);
            this.kryptonPanel1.TabIndex = 46;
            // 
            // chk_CopyFTA
            // 
            this.chk_CopyFTA.Location = new System.Drawing.Point(771, 144);
            this.chk_CopyFTA.Name = "chk_CopyFTA";
            this.chk_CopyFTA.Size = new System.Drawing.Size(44, 20);
            this.chk_CopyFTA.TabIndex = 307;
            this.chk_CopyFTA.Values.Text = "FTA";
            // 
            // chk_CopyTHT
            // 
            this.chk_CopyTHT.Location = new System.Drawing.Point(720, 144);
            this.chk_CopyTHT.Name = "chk_CopyTHT";
            this.chk_CopyTHT.Size = new System.Drawing.Size(45, 20);
            this.chk_CopyTHT.TabIndex = 306;
            this.chk_CopyTHT.Values.Text = "THT";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(624, 144);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel12.TabIndex = 305;
            this.kryptonLabel12.Values.Text = "Multiply visas:";
            // 
            // lbl_Serial
            // 
            this.lbl_Serial.Location = new System.Drawing.Point(624, 93);
            this.lbl_Serial.Name = "lbl_Serial";
            this.lbl_Serial.Size = new System.Drawing.Size(94, 20);
            this.lbl_Serial.TabIndex = 299;
            this.lbl_Serial.Values.Text = "Serial numbers:";
            // 
            // txt_Serial
            // 
            this.txt_Serial.Location = new System.Drawing.Point(720, 92);
            this.txt_Serial.Multiline = true;
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(150, 46);
            this.txt_Serial.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Serial.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Serial.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Serial.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Serial.TabIndex = 298;
            this.txt_Serial.TextChanged += new System.EventHandler(this.txt_Serial_TextChanged);
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(624, 67);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel11.TabIndex = 297;
            this.kryptonLabel11.Values.Text = "PCB per panel:";
            // 
            // txt_PCB
            // 
            this.txt_PCB.Enabled = false;
            this.txt_PCB.Location = new System.Drawing.Point(720, 65);
            this.txt_PCB.Name = "txt_PCB";
            this.txt_PCB.Size = new System.Drawing.Size(52, 23);
            this.txt_PCB.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_PCB.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_PCB.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_PCB.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_PCB.TabIndex = 296;
            // 
            // chk_Urgent
            // 
            this.chk_Urgent.Location = new System.Drawing.Point(555, 94);
            this.chk_Urgent.Name = "chk_Urgent";
            this.chk_Urgent.Size = new System.Drawing.Size(61, 20);
            this.chk_Urgent.TabIndex = 295;
            this.chk_Urgent.Values.Text = "Urgent";
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.CalendarShowWeekNumbers = true;
            this.txt_StartDate.CustomFormat = null;
            this.txt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_StartDate.Location = new System.Drawing.Point(528, 119);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.NullValue = " ";
            this.txt_StartDate.Size = new System.Drawing.Size(88, 21);
            this.txt_StartDate.TabIndex = 294;
            this.txt_StartDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_StartDate_DropDown);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(436, 119);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel10.TabIndex = 293;
            this.kryptonLabel10.Values.Text = "RM lead time:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Refresh.Location = new System.Drawing.Point(316, 13);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Refresh.Size = new System.Drawing.Size(47, 43);
            this.btn_Refresh.TabIndex = 292;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(196, 93);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(119, 20);
            this.kryptonLabel9.TabIndex = 283;
            this.kryptonLabel9.Values.Text = "Qty can be in batch:";
            // 
            // txt_QtyCanBeBatch
            // 
            this.txt_QtyCanBeBatch.AllowDecimalSeparator = true;
            this.txt_QtyCanBeBatch.AllowSpace = false;
            this.txt_QtyCanBeBatch.Enabled = false;
            this.txt_QtyCanBeBatch.Location = new System.Drawing.Point(321, 91);
            this.txt_QtyCanBeBatch.Name = "txt_QtyCanBeBatch";
            this.txt_QtyCanBeBatch.Size = new System.Drawing.Size(66, 23);
            this.txt_QtyCanBeBatch.StateActive.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeBatch.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyCanBeBatch.StateActive.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_QtyCanBeBatch.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeBatch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyCanBeBatch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_QtyCanBeBatch.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_QtyCanBeBatch.StateDisabled.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_QtyCanBeBatch.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_QtyCanBeBatch.TabIndex = 282;
            this.txt_QtyCanBeBatch.Text = "0";
            // 
            // cmb_Batches1
            // 
            this.cmb_Batches1.ActiveOnly = 0;
            this.cmb_Batches1.Article = null;
            this.cmb_Batches1.ArticleId = 0;
            this.cmb_Batches1.Batch = "";
            this.cmb_Batches1.BatchId = 0;
            this.cmb_Batches1.Comments = null;
            this.cmb_Batches1.ConfOrder = null;
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.CustArticle = null;
            this.cmb_Batches1.Customer = null;
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.IsGroup = 0;
            this.cmb_Batches1.IsProject = -1;
            this.cmb_Batches1.IsQuote = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(138, 39);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(172, 20);
            this.cmb_Batches1.Stages = null;
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 26;
            this.cmb_Batches1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches1_BatchChanged);
            this.cmb_Batches1.ControlClick += new Odin.CMB_Components.Batches.BatchControlEventHeader(this.cmb_Batches1_ControlClick);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(14, 38);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel8.TabIndex = 25;
            this.kryptonLabel8.Values.Text = "Batch project:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(196, 65);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel6.TabIndex = 23;
            this.kryptonLabel6.Values.Text = "Customer:";
            // 
            // txt_Customer
            // 
            this.txt_Customer.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Customer.Enabled = false;
            this.txt_Customer.Location = new System.Drawing.Point(268, 65);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.ReadOnly = true;
            this.txt_Customer.Size = new System.Drawing.Size(348, 23);
            this.txt_Customer.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Customer.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Customer.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Customer.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Customer.TabIndex = 22;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "D5B6C03750554195328E4B264796E65F";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(14, 66);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel5.TabIndex = 21;
            this.kryptonLabel5.Values.Text = "Qty in BP:";
            // 
            // txt_QtyInBP
            // 
            this.txt_QtyInBP.AllowDecimalSeparator = true;
            this.txt_QtyInBP.AllowSpace = false;
            this.txt_QtyInBP.Enabled = false;
            this.txt_QtyInBP.Location = new System.Drawing.Point(105, 65);
            this.txt_QtyInBP.Name = "txt_QtyInBP";
            this.txt_QtyInBP.Size = new System.Drawing.Size(85, 23);
            this.txt_QtyInBP.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.txt_QtyInBP.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyInBP.StateActive.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_QtyInBP.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_QtyInBP.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_QtyInBP.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyInBP.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_QtyInBP.TabIndex = 20;
            this.txt_QtyInBP.Text = "0";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(14, 144);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel7.TabIndex = 19;
            this.kryptonLabel7.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_Comments.Location = new System.Drawing.Point(105, 144);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(511, 44);
            this.txt_Comments.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Comments.TabIndex = 7;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "D5B6C03750554195328E4B264796E65F";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(14, 12);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(118, 20);
            this.kryptonLabel4.TabIndex = 9;
            this.kryptonLabel4.Values.Text = "Confirmation order:";
            // 
            // cmb_SalesOrdersWithLines1
            // 
            this.cmb_SalesOrdersWithLines1.ArticleId = 0;
            this.cmb_SalesOrdersWithLines1.BatchId = 0;
            this.cmb_SalesOrdersWithLines1.Location = new System.Drawing.Point(138, 12);
            this.cmb_SalesOrdersWithLines1.Name = "cmb_SalesOrdersWithLines1";
            this.cmb_SalesOrdersWithLines1.QtyInCO = 0D;
            this.cmb_SalesOrdersWithLines1.SalesOrder = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderId = 0;
            this.cmb_SalesOrdersWithLines1.SalesOrderLine = "";
            this.cmb_SalesOrdersWithLines1.SalesOrderLineId = 0;
            this.cmb_SalesOrdersWithLines1.Size = new System.Drawing.Size(172, 21);
            this.cmb_SalesOrdersWithLines1.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 91);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Batch:";
            // 
            // txt_Batch
            // 
            this.txt_Batch.Location = new System.Drawing.Point(105, 92);
            this.txt_Batch.Name = "txt_Batch";
            this.txt_Batch.Size = new System.Drawing.Size(85, 21);
            this.txt_Batch.StateActive.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Batch.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Batch.StateActive.Content.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Batch.StateNormal.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Batch.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Batch.TabIndex = 8;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(393, 93);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Qty in batch:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.AllowDecimalSeparator = true;
            this.txt_Qty.AllowSpace = false;
            this.txt_Qty.Location = new System.Drawing.Point(479, 92);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(66, 23);
            this.txt_Qty.StateActive.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Qty.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.StateActive.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_Qty.TabIndex = 3;
            this.txt_Qty.Text = "0";
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            this.txt_Qty.Validated += new System.EventHandler(this.txt_Qty_Validated);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(14, 116);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel2.TabIndex = 3;
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
            this.cmb_Articles1.Enabled = false;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.CertState = "";
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(105, 118);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(328, 20);
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
            this.btn_Save,
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 202);
            this.bn_List.MoveFirstItem = null;
            this.bn_List.MoveLastItem = null;
            this.bn_List.MoveNextItem = null;
            this.bn_List.MovePreviousItem = null;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = null;
            this.bn_List.Size = new System.Drawing.Size(1296, 25);
            this.bn_List.TabIndex = 295;
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
            this.btn_Spoilage.Visible = false;
            // 
            // btn_AddNorm
            // 
            this.btn_AddNorm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNorm.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNorm.Image")));
            this.btn_AddNorm.Name = "btn_AddNorm";
            this.btn_AddNorm.RightToLeftAutoMirrorImage = true;
            this.btn_AddNorm.Size = new System.Drawing.Size(23, 22);
            this.btn_AddNorm.Text = "Add new";
            this.btn_AddNorm.Visible = false;
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
            this.btn_AddSubProduct.Visible = false;
            // 
            // btn_DeleteNorm
            // 
            this.btn_DeleteNorm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteNorm.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteNorm.Image")));
            this.btn_DeleteNorm.Name = "btn_DeleteNorm";
            this.btn_DeleteNorm.RightToLeftAutoMirrorImage = true;
            this.btn_DeleteNorm.Size = new System.Drawing.Size(23, 22);
            this.btn_DeleteNorm.Text = "Delete";
            this.btn_DeleteNorm.Visible = false;
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
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(23, 22);
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            // attachmentcolumn1
            // 
            this.attachmentcolumn1.HeaderText = "attachmentcolumn1";
            this.attachmentcolumn1.Name = "attachmentcolumn1";
            this.attachmentcolumn1.Visible = false;
            // 
            // tv_BOM
            // 
            this.tv_BOM.AllowUserToAddRows = false;
            this.tv_BOM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.tv_BOM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tv_BOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tv_BOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachmentColumn,
            this.cn_nArticle,
            this.cn_nUse,
            this.cn_nArtId,
            this.cn_nBomNum,
            this.cn_nUnit,
            this.cn_nQtyInProject,
            this.cn_nQtyInBatch,
            this.cn_nAvailable,
            this.cn_nQtyStock,
            this.cn_nWaitingQtyPO,
            this.cn_nQtyBOM,
            this.cn_nStage,
            this.cn_nMaxQty,
            this.cn_nOrigArt,
            this.cn_nWaitigPODate,
            this.cn_nPO,
            this.cn_nSupplier,
            this.cn_batchdetid,
            this.cn_nstockforbatch,
            this.cn_nFullPOInfo,
            this.cn_dnp});
            this.tv_BOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_BOM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tv_BOM.ImageList = null;
            this.tv_BOM.Location = new System.Drawing.Point(0, 227);
            this.tv_BOM.Name = "tv_BOM";
            this.tv_BOM.RowHeadersWidth = 25;
            this.tv_BOM.ShowCellErrors = false;
            this.tv_BOM.ShowRowErrors = false;
            this.tv_BOM.Size = new System.Drawing.Size(1296, 448);
            this.tv_BOM.TabIndex = 299;
            this.tv_BOM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tv_BOM_CellContentClick);
            this.tv_BOM.Validated += new System.EventHandler(this.tv_BOM_Validated);
            // 
            // attachmentColumn
            // 
            this.attachmentColumn.HeaderText = "attachmentColumn1";
            this.attachmentColumn.Name = "attachmentColumn";
            this.attachmentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attachmentColumn.Visible = false;
            // 
            // cn_nArticle
            // 
            this.cn_nArticle.DefaultNodeImage = null;
            this.cn_nArticle.FillWeight = 150F;
            this.cn_nArticle.HeaderText = "Article";
            this.cn_nArticle.Name = "cn_nArticle";
            this.cn_nArticle.ReadOnly = true;
            this.cn_nArticle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nArticle.Width = 150;
            // 
            // cn_nUse
            // 
            this.cn_nUse.FalseValue = "0";
            this.cn_nUse.FillWeight = 30F;
            this.cn_nUse.HeaderText = "Use";
            this.cn_nUse.IndeterminateValue = "1";
            this.cn_nUse.Name = "cn_nUse";
            this.cn_nUse.TrueValue = "-1";
            this.cn_nUse.Width = 30;
            // 
            // cn_nArtId
            // 
            this.cn_nArtId.FillWeight = 80F;
            this.cn_nArtId.HeaderText = "Art. Id";
            this.cn_nArtId.Name = "cn_nArtId";
            this.cn_nArtId.ReadOnly = true;
            this.cn_nArtId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_nArtId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nArtId.Width = 80;
            // 
            // cn_nBomNum
            // 
            this.cn_nBomNum.FillWeight = 35F;
            this.cn_nBomNum.HeaderText = "Bom N";
            this.cn_nBomNum.Name = "cn_nBomNum";
            this.cn_nBomNum.ReadOnly = true;
            this.cn_nBomNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nBomNum.Width = 35;
            // 
            // cn_nUnit
            // 
            this.cn_nUnit.FillWeight = 40F;
            this.cn_nUnit.HeaderText = "Unit";
            this.cn_nUnit.Name = "cn_nUnit";
            this.cn_nUnit.ReadOnly = true;
            this.cn_nUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nUnit.Width = 40;
            // 
            // cn_nQtyInProject
            // 
            this.cn_nQtyInProject.FillWeight = 80F;
            this.cn_nQtyInProject.HeaderText = "Qty in project";
            this.cn_nQtyInProject.Name = "cn_nQtyInProject";
            this.cn_nQtyInProject.ReadOnly = true;
            this.cn_nQtyInProject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyInProject.Width = 80;
            // 
            // cn_nQtyInBatch
            // 
            this.cn_nQtyInBatch.FillWeight = 80F;
            this.cn_nQtyInBatch.HeaderText = "Qty in batch";
            this.cn_nQtyInBatch.Name = "cn_nQtyInBatch";
            this.cn_nQtyInBatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyInBatch.Width = 80;
            // 
            // cn_nAvailable
            // 
            this.cn_nAvailable.FillWeight = 80F;
            this.cn_nAvailable.HeaderText = "Available";
            this.cn_nAvailable.Name = "cn_nAvailable";
            this.cn_nAvailable.ReadOnly = true;
            this.cn_nAvailable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nAvailable.Width = 80;
            // 
            // cn_nQtyStock
            // 
            this.cn_nQtyStock.FillWeight = 80F;
            this.cn_nQtyStock.HeaderText = "Qty stock";
            this.cn_nQtyStock.Name = "cn_nQtyStock";
            this.cn_nQtyStock.ReadOnly = true;
            this.cn_nQtyStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyStock.Width = 80;
            // 
            // cn_nWaitingQtyPO
            // 
            this.cn_nWaitingQtyPO.FillWeight = 80F;
            this.cn_nWaitingQtyPO.HeaderText = "Waiting in PO";
            this.cn_nWaitingQtyPO.Name = "cn_nWaitingQtyPO";
            this.cn_nWaitingQtyPO.ReadOnly = true;
            this.cn_nWaitingQtyPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nWaitingQtyPO.Width = 80;
            // 
            // cn_nQtyBOM
            // 
            this.cn_nQtyBOM.FillWeight = 50F;
            this.cn_nQtyBOM.HeaderText = "In BOM";
            this.cn_nQtyBOM.Name = "cn_nQtyBOM";
            this.cn_nQtyBOM.ReadOnly = true;
            this.cn_nQtyBOM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nQtyBOM.Width = 50;
            // 
            // cn_nStage
            // 
            this.cn_nStage.FillWeight = 50F;
            this.cn_nStage.HeaderText = "Stage";
            this.cn_nStage.Name = "cn_nStage";
            this.cn_nStage.ReadOnly = true;
            this.cn_nStage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nStage.Width = 50;
            // 
            // cn_nMaxQty
            // 
            this.cn_nMaxQty.HeaderText = "Max. qty";
            this.cn_nMaxQty.Name = "cn_nMaxQty";
            this.cn_nMaxQty.ReadOnly = true;
            this.cn_nMaxQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nMaxQty.Visible = false;
            // 
            // cn_nOrigArt
            // 
            this.cn_nOrigArt.HeaderText = "Orig.art";
            this.cn_nOrigArt.Name = "cn_nOrigArt";
            this.cn_nOrigArt.ReadOnly = true;
            this.cn_nOrigArt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nOrigArt.Visible = false;
            // 
            // cn_nWaitigPODate
            // 
            this.cn_nWaitigPODate.HeaderText = "Waiting PO date";
            this.cn_nWaitigPODate.Name = "cn_nWaitigPODate";
            this.cn_nWaitigPODate.ReadOnly = true;
            this.cn_nWaitigPODate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_nPO
            // 
            this.cn_nPO.HeaderText = "Purchase order";
            this.cn_nPO.Name = "cn_nPO";
            this.cn_nPO.ReadOnly = true;
            this.cn_nPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_nSupplier
            // 
            this.cn_nSupplier.HeaderText = "Supplier";
            this.cn_nSupplier.Name = "cn_nSupplier";
            this.cn_nSupplier.ReadOnly = true;
            this.cn_nSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cn_batchdetid
            // 
            this.cn_batchdetid.HeaderText = "bdid";
            this.cn_batchdetid.Name = "cn_batchdetid";
            this.cn_batchdetid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_batchdetid.Visible = false;
            // 
            // cn_nstockforbatch
            // 
            this.cn_nstockforbatch.HeaderText = "stockforbatch";
            this.cn_nstockforbatch.Name = "cn_nstockforbatch";
            this.cn_nstockforbatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nstockforbatch.Visible = false;
            // 
            // cn_nFullPOInfo
            // 
            this.cn_nFullPOInfo.FillWeight = 250F;
            this.cn_nFullPOInfo.HeaderText = "Full PO info";
            this.cn_nFullPOInfo.Name = "cn_nFullPOInfo";
            this.cn_nFullPOInfo.ReadOnly = true;
            this.cn_nFullPOInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_nFullPOInfo.Width = 250;
            // 
            // cn_dnp
            // 
            this.cn_dnp.HeaderText = "dnp";
            this.cn_dnp.Name = "cn_dnp";
            this.cn_dnp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cn_dnp.Visible = false;
            // 
            // ctl_CreatBatchDetsP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tv_BOM);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_CreatBatchDetsP";
            this.Size = new System.Drawing.Size(1296, 675);
            this.Load += new System.EventHandler(this.ctl_CreatBatchDetsP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            this.mnu_Lines.ResumeLayout(false);
            this.mnu_Lines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_BOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        public Owf.Controls.NumericTetxBox txt_QtyCanBeBatch;
        private CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Customer;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Owf.Controls.NumericTetxBox txt_QtyInBP;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public CMB_Components.SalesOrders.cmb_SalesOrdersWithLines cmb_SalesOrdersWithLines1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Batch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Owf.Controls.NumericTetxBox txt_Qty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public CMB_Components.Articles.cmb_Articles cmb_Articles1;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripButton btn_Spoilage;
        private System.Windows.Forms.ToolStripButton btn_AddNorm;
        private System.Windows.Forms.ToolStripButton btn_AddSubProduct;
        private System.Windows.Forms.ToolStripButton btn_DeleteNorm;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmb_Unit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmb_Decimals;
        private System.Windows.Forms.ToolStripButton btn_Round;
        private System.Windows.Forms.ToolStripButton btn_Clear;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripTextBox mni_FilterFor;
        private System.Windows.Forms.ToolStripMenuItem mni_Search;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterBy;
        private System.Windows.Forms.ToolStripMenuItem mni_FilterExcludingSel;
        private System.Windows.Forms.ToolStripMenuItem mni_RemoveFilter;
        private System.Windows.Forms.ToolStripMenuItem mni_Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        private CustomControls.NullableDateTimePicker txt_StartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Urgent;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private System.Windows.Forms.DataGridViewImageColumn attachmentcolumn1;
        public AdvancedDataGridView.TreeGridView tv_BOM;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_PCB;
        private System.Windows.Forms.DataGridViewImageColumn attachmentColumn;
        private AdvancedDataGridView.TreeGridColumn cn_nArticle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_nUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nArtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nBomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyInProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyInBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nWaitingQtyPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nQtyBOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nMaxQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nOrigArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nWaitigPODate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batchdetid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nstockforbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nFullPOInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dnp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Serial;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Serial;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_CopyFTA;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_CopyTHT;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
    }
}
