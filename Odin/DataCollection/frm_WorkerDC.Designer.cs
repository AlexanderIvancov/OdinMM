namespace Odin.DataCollection
{
    partial class frm_WorkerDC
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

        public Main _frm_Main;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_WorkerDC));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_DeleteSN = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isapproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Serials = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminS = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_DeleteMT = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gv_Materials = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_bartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_barticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_blaunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bwhen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Materials = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_AdminM = new System.Windows.Forms.ToolStripMenuItem();
            this.bn_Materials = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_DirectQty = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_ChangeLaunch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Worker = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Launch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.grp_ContentType = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.chk_Launch = new System.Windows.Forms.RadioButton();
            this.chk_Materials = new System.Windows.Forms.RadioButton();
            this.chk_Serial = new System.Windows.Forms.RadioButton();
            this.btn_ChangeWorker = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.bs_Materials = new Odin.Global_Classes.SyncBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Serials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Materials)).BeginInit();
            this.mnu_Materials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_Materials)).BeginInit();
            this.bn_Materials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_ContentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_ContentType.Panel)).BeginInit();
            this.grp_ContentType.Panel.SuspendLayout();
            this.grp_ContentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Materials)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_DeleteSN});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(903, 718);
            this.kryptonHeaderGroup1.TabIndex = 247;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Serial numbers of products";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.pci;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Labels list ";
            // 
            // btn_DeleteSN
            // 
            this.btn_DeleteSN.Image = global::Odin.Global_Resourses.delete2;
            this.btn_DeleteSN.UniqueName = "DA1C7802EB9D4E471E915DBE7CFB126B";
            this.btn_DeleteSN.Click += new System.EventHandler(this.btn_DeleteSN_Click);
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_List.ColumnHeadersHeight = 40;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_index,
            this.cn_serial,
            this.cn_launch,
            this.cn_artid,
            this.cn_article,
            this.cn_launchid,
            this.cn_coid,
            this.cn_conforder,
            this.cn_qty,
            this.cn_when,
            this.cn_id,
            this.cn_isapproved});
            this.gv_List.ContextMenuStrip = this.mnu_Serials;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 50;
            this.gv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_List.Size = new System.Drawing.Size(901, 660);
            this.gv_List.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_List.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.TabIndex = 228;
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            // 
            // cn_index
            // 
            this.cn_index.DataPropertyName = "num";
            this.cn_index.FillWeight = 70F;
            this.cn_index.HeaderText = "NO";
            this.cn_index.Name = "cn_index";
            this.cn_index.ReadOnly = true;
            this.cn_index.Width = 70;
            // 
            // cn_serial
            // 
            this.cn_serial.DataPropertyName = "sn";
            this.cn_serial.FillWeight = 250F;
            this.cn_serial.HeaderText = "Serial NR";
            this.cn_serial.Name = "cn_serial";
            this.cn_serial.ReadOnly = true;
            this.cn_serial.Width = 250;
            // 
            // cn_launch
            // 
            this.cn_launch.DataPropertyName = "launch";
            this.cn_launch.FillWeight = 220F;
            this.cn_launch.HeaderText = "Launch";
            this.cn_launch.Name = "cn_launch";
            this.cn_launch.ReadOnly = true;
            this.cn_launch.Width = 220;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
            this.cn_artid.Visible = false;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 250F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Visible = false;
            this.cn_article.Width = 250;
            // 
            // cn_launchid
            // 
            this.cn_launchid.DataPropertyName = "launchid";
            this.cn_launchid.HeaderText = "launchid";
            this.cn_launchid.Name = "cn_launchid";
            this.cn_launchid.ReadOnly = true;
            this.cn_launchid.Visible = false;
            // 
            // cn_coid
            // 
            this.cn_coid.HeaderText = "coid";
            this.cn_coid.Name = "cn_coid";
            this.cn_coid.Visible = false;
            // 
            // cn_conforder
            // 
            this.cn_conforder.FillWeight = 300F;
            this.cn_conforder.HeaderText = "Conf. order";
            this.cn_conforder.Name = "cn_conforder";
            this.cn_conforder.Visible = false;
            this.cn_conforder.Width = 300;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 120F;
            this.cn_qty.HeaderText = "Quantity";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 120;
            // 
            // cn_when
            // 
            this.cn_when.DataPropertyName = "when";
            this.cn_when.FillWeight = 300F;
            this.cn_when.HeaderText = "When";
            this.cn_when.Name = "cn_when";
            this.cn_when.Width = 300;
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            // 
            // cn_isapproved
            // 
            this.cn_isapproved.DataPropertyName = "isapproved";
            this.cn_isapproved.HeaderText = "isapproved";
            this.cn_isapproved.Name = "cn_isapproved";
            this.cn_isapproved.Visible = false;
            // 
            // mnu_Serials
            // 
            this.mnu_Serials.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Serials.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.mni_AdminS});
            this.mnu_Serials.Name = "mnu_Requests";
            this.mnu_Serials.Size = new System.Drawing.Size(137, 32);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // mni_AdminS
            // 
            this.mni_AdminS.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminS.Name = "mni_AdminS";
            this.mni_AdminS.Size = new System.Drawing.Size(136, 22);
            this.mni_AdminS.Text = "List settings";
            this.mni_AdminS.Click += new System.EventHandler(this.mni_AdminS_Click);
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_DeleteMT});
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 718);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.gv_Materials);
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.bn_Materials);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(903, 343);
            this.kryptonHeaderGroup3.TabIndex = 246;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Materials";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::Odin.Global_Resourses.barcode_2d;
            this.kryptonHeaderGroup3.ValuesSecondary.Heading = "Materials list";
            // 
            // btn_DeleteMT
            // 
            this.btn_DeleteMT.Image = global::Odin.Global_Resourses.delete2;
            this.btn_DeleteMT.UniqueName = "D99B0837D9DD4DE92CB7204AFFD1D4CD";
            this.btn_DeleteMT.Click += new System.EventHandler(this.btn_DeleteMT_Click);
            // 
            // gv_Materials
            // 
            this.gv_Materials.AllowUserToAddRows = false;
            this.gv_Materials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_Materials.ColumnHeadersHeight = 40;
            this.gv_Materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Materials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_bartid,
            this.cn_bid,
            this.cn_barticle,
            this.cn_blaunch,
            this.cn_label,
            this.cn_bwhen,
            this.cn_who});
            this.gv_Materials.ContextMenuStrip = this.mnu_Materials;
            this.gv_Materials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Materials.Location = new System.Drawing.Point(0, 0);
            this.gv_Materials.Name = "gv_Materials";
            this.gv_Materials.RowHeadersWidth = 50;
            this.gv_Materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Materials.Size = new System.Drawing.Size(901, 265);
            this.gv_Materials.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_Materials.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_Materials.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_Materials.TabIndex = 230;
            // 
            // cn_bartid
            // 
            this.cn_bartid.DataPropertyName = "artid";
            this.cn_bartid.HeaderText = "Art. id";
            this.cn_bartid.Name = "cn_bartid";
            this.cn_bartid.ReadOnly = true;
            // 
            // cn_bid
            // 
            this.cn_bid.DataPropertyName = "id";
            this.cn_bid.HeaderText = "id";
            this.cn_bid.Name = "cn_bid";
            this.cn_bid.Visible = false;
            // 
            // cn_barticle
            // 
            this.cn_barticle.DataPropertyName = "article";
            this.cn_barticle.FillWeight = 330F;
            this.cn_barticle.HeaderText = "Article";
            this.cn_barticle.Name = "cn_barticle";
            this.cn_barticle.ReadOnly = true;
            this.cn_barticle.Width = 330;
            // 
            // cn_blaunch
            // 
            this.cn_blaunch.DataPropertyName = "launch";
            this.cn_blaunch.FillWeight = 150F;
            this.cn_blaunch.HeaderText = "Launch";
            this.cn_blaunch.Name = "cn_blaunch";
            this.cn_blaunch.ReadOnly = true;
            this.cn_blaunch.Width = 150;
            // 
            // cn_label
            // 
            this.cn_label.DataPropertyName = "label";
            this.cn_label.FillWeight = 150F;
            this.cn_label.HeaderText = "Label";
            this.cn_label.Name = "cn_label";
            this.cn_label.Width = 150;
            // 
            // cn_bwhen
            // 
            this.cn_bwhen.DataPropertyName = "when";
            this.cn_bwhen.FillWeight = 280F;
            this.cn_bwhen.HeaderText = "When";
            this.cn_bwhen.Name = "cn_bwhen";
            this.cn_bwhen.Width = 280;
            // 
            // cn_who
            // 
            this.cn_who.DataPropertyName = "worker";
            this.cn_who.FillWeight = 150F;
            this.cn_who.HeaderText = "Who";
            this.cn_who.Name = "cn_who";
            this.cn_who.Width = 150;
            // 
            // mnu_Materials
            // 
            this.mnu_Materials.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Materials.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.mni_AdminM});
            this.mnu_Materials.Name = "mnu_Requests";
            this.mnu_Materials.Size = new System.Drawing.Size(137, 32);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // mni_AdminM
            // 
            this.mni_AdminM.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_AdminM.Name = "mni_AdminM";
            this.mni_AdminM.Size = new System.Drawing.Size(136, 22);
            this.mni_AdminM.Text = "List settings";
            this.mni_AdminM.Click += new System.EventHandler(this.mni_AdminM_Click);
            // 
            // bn_Materials
            // 
            this.bn_Materials.AddNewItem = null;
            this.bn_Materials.CountItem = this.toolStripLabel1;
            this.bn_Materials.DeleteItem = null;
            this.bn_Materials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_Materials.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_Materials.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4});
            this.bn_Materials.Location = new System.Drawing.Point(0, 265);
            this.bn_Materials.MoveFirstItem = this.toolStripButton1;
            this.bn_Materials.MoveLastItem = this.toolStripButton4;
            this.bn_Materials.MoveNextItem = this.toolStripButton3;
            this.bn_Materials.MovePreviousItem = this.toolStripButton2;
            this.bn_Materials.Name = "bn_Materials";
            this.bn_Materials.PositionItem = this.toolStripTextBox1;
            this.bn_Materials.Size = new System.Drawing.Size(901, 25);
            this.bn_Materials.TabIndex = 229;
            this.bn_Materials.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
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
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(903, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_DirectQty);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_ChangeLaunch);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Worker);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Launch);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.grp_ContentType);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_ChangeWorker);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(335, 1061);
            this.kryptonHeaderGroup2.TabIndex = 245;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Worker\'s actions";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.role;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Worker info";
            // 
            // btn_DirectQty
            // 
            this.btn_DirectQty.Location = new System.Drawing.Point(16, 303);
            this.btn_DirectQty.Name = "btn_DirectQty";
            this.btn_DirectQty.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_DirectQty.Size = new System.Drawing.Size(306, 64);
            this.btn_DirectQty.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DirectQty.TabIndex = 245;
            this.btn_DirectQty.Values.Image = global::Odin.Global_Resourses.calculator_edit;
            this.btn_DirectQty.Values.Text = "Enter qty";
            this.btn_DirectQty.Click += new System.EventHandler(this.btn_DirectQty_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 908);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 95);
            this.panel1.TabIndex = 244;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(16, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Close.Size = new System.Drawing.Size(306, 67);
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.TabIndex = 240;
            this.btn_Close.Values.Image = global::Odin.Global_Resourses.exit;
            this.btn_Close.Values.Text = "Exit";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_ChangeLaunch
            // 
            this.btn_ChangeLaunch.Location = new System.Drawing.Point(16, 230);
            this.btn_ChangeLaunch.Name = "btn_ChangeLaunch";
            this.btn_ChangeLaunch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_ChangeLaunch.Size = new System.Drawing.Size(306, 67);
            this.btn_ChangeLaunch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeLaunch.TabIndex = 243;
            this.btn_ChangeLaunch.Values.Image = global::Odin.Global_Resourses.launch;
            this.btn_ChangeLaunch.Values.Text = "Assign launch";
            this.btn_ChangeLaunch.Click += new System.EventHandler(this.btn_ChangeLaunch_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(17, 154);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 239;
            this.kryptonLabel2.Values.Text = "Launch:";
            // 
            // txt_Worker
            // 
            this.txt_Worker.Enabled = false;
            this.txt_Worker.Location = new System.Drawing.Point(17, 39);
            this.txt_Worker.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Worker.Multiline = true;
            this.txt_Worker.Name = "txt_Worker";
            this.txt_Worker.ReadOnly = true;
            this.txt_Worker.Size = new System.Drawing.Size(306, 40);
            this.txt_Worker.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worker.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Worker.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Worker.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Worker.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Worker.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Worker.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Worker.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worker.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worker.TabIndex = 242;
            this.txt_Worker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Launch
            // 
            this.txt_Launch.Enabled = false;
            this.txt_Launch.Location = new System.Drawing.Point(16, 185);
            this.txt_Launch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Launch.Multiline = true;
            this.txt_Launch.Name = "txt_Launch";
            this.txt_Launch.ReadOnly = true;
            this.txt_Launch.Size = new System.Drawing.Size(306, 40);
            this.txt_Launch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Launch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Launch.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Launch.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Launch.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Launch.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Launch.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Launch.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Launch.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Launch.TabIndex = 240;
            this.txt_Launch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(16, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(84, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 241;
            this.kryptonLabel1.Values.Text = "Worker:";
            // 
            // grp_ContentType
            // 
            this.grp_ContentType.Location = new System.Drawing.Point(16, 515);
            this.grp_ContentType.Name = "grp_ContentType";
            // 
            // grp_ContentType.Panel
            // 
            this.grp_ContentType.Panel.Controls.Add(this.chk_Launch);
            this.grp_ContentType.Panel.Controls.Add(this.chk_Materials);
            this.grp_ContentType.Panel.Controls.Add(this.chk_Serial);
            this.grp_ContentType.Size = new System.Drawing.Size(306, 206);
            this.grp_ContentType.TabIndex = 234;
            this.grp_ContentType.Values.Heading = "Scanning type";
            this.grp_ContentType.Visible = false;
            // 
            // chk_Launch
            // 
            this.chk_Launch.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_Launch.BackColor = System.Drawing.Color.LightGreen;
            this.chk_Launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Launch.Location = new System.Drawing.Point(9, 122);
            this.chk_Launch.Name = "chk_Launch";
            this.chk_Launch.Size = new System.Drawing.Size(285, 50);
            this.chk_Launch.TabIndex = 231;
            this.chk_Launch.Text = "Direct launch qty";
            this.chk_Launch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_Launch.UseVisualStyleBackColor = false;
            this.chk_Launch.CheckedChanged += new System.EventHandler(this.chk_Launch_CheckedChanged);
            // 
            // chk_Materials
            // 
            this.chk_Materials.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_Materials.BackColor = System.Drawing.Color.LightGreen;
            this.chk_Materials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Materials.Location = new System.Drawing.Point(9, 66);
            this.chk_Materials.Name = "chk_Materials";
            this.chk_Materials.Size = new System.Drawing.Size(285, 50);
            this.chk_Materials.TabIndex = 230;
            this.chk_Materials.Text = "Materials";
            this.chk_Materials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_Materials.UseVisualStyleBackColor = false;
            this.chk_Materials.CheckedChanged += new System.EventHandler(this.chk_Materials_CheckedChanged);
            // 
            // chk_Serial
            // 
            this.chk_Serial.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_Serial.BackColor = System.Drawing.Color.LightPink;
            this.chk_Serial.Checked = true;
            this.chk_Serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Serial.Location = new System.Drawing.Point(9, 10);
            this.chk_Serial.Name = "chk_Serial";
            this.chk_Serial.Size = new System.Drawing.Size(285, 50);
            this.chk_Serial.TabIndex = 229;
            this.chk_Serial.TabStop = true;
            this.chk_Serial.Text = "Serial numbers";
            this.chk_Serial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_Serial.UseVisualStyleBackColor = false;
            this.chk_Serial.CheckedChanged += new System.EventHandler(this.chk_Serial_CheckedChanged);
            // 
            // btn_ChangeWorker
            // 
            this.btn_ChangeWorker.Location = new System.Drawing.Point(16, 84);
            this.btn_ChangeWorker.Name = "btn_ChangeWorker";
            this.btn_ChangeWorker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_ChangeWorker.Size = new System.Drawing.Size(306, 64);
            this.btn_ChangeWorker.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeWorker.TabIndex = 238;
            this.btn_ChangeWorker.Values.Image = global::Odin.Global_Resourses.workers_refresh;
            this.btn_ChangeWorker.Values.Text = "Assign worker";
            this.btn_ChangeWorker.Click += new System.EventHandler(this.btn_ChangeWorker_Click);
            // 
            // txt_Oper
            // 
            this.txt_Oper.Location = new System.Drawing.Point(455, 266);
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.Size = new System.Drawing.Size(121, 91);
            this.txt_Oper.TabIndex = 244;
            this.txt_Oper.Text = "";
            this.txt_Oper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Oper_KeyPress);
            // 
            // frm_WorkerDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 1061);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonHeaderGroup3);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.txt_Oper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_WorkerDC";
            this.TabText = "S/N Data Collection";
            this.Text = "S/N Data Collection";
            this.Activated += new System.EventHandler(this.frm_WorkerDC_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_WorkerDC_FormClosing);
            this.Load += new System.EventHandler(this.frm_WorkerDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.mnu_Serials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Materials)).EndInit();
            this.mnu_Materials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bn_Materials)).EndInit();
            this.bn_Materials.ResumeLayout(false);
            this.bn_Materials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_ContentType.Panel)).EndInit();
            this.grp_ContentType.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_ContentType)).EndInit();
            this.grp_ContentType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Materials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Oper;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ChangeWorker;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Materials;
        private System.Windows.Forms.BindingNavigator bn_Materials;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grp_ContentType;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Worker;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Launch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ChangeLaunch;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private System.Windows.Forms.RadioButton chk_Launch;
        private System.Windows.Forms.RadioButton chk_Materials;
        private System.Windows.Forms.RadioButton chk_Serial;
        private Global_Classes.SyncBindingSource bs_List;
        private Global_Classes.SyncBindingSource bs_Materials;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isapproved;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_DirectQty;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_DeleteSN;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_DeleteMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_barticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_blaunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bwhen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_who;
        private System.Windows.Forms.ContextMenuStrip mnu_Serials;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminS;
        private System.Windows.Forms.ContextMenuStrip mnu_Materials;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mni_AdminM;
    }
}