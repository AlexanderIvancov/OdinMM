namespace Odin.DataCollection
{
    partial class frm_MasterApproveFin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MasterApproveFin));
            this.btn_DeleteSN = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_launch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtystarrted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_toapprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CheckAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Start = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.rb_Valkas2B = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_Clean = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rb_Valkas2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Qty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_EditContent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_AssignMaster = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SetPlace = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmb_CommonPDA1 = new Odin.CMB_Components.Common.cmb_CommonPDA();
            this.btn_Approve = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Master = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Delete = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gv_Serials = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_rtoapprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isapproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_issn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_opernum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_Serials = new Odin.Global_Classes.SyncBindingSource();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyToStart = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Start1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Serials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Serials)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteSN
            // 
            this.btn_DeleteSN.Image = global::Odin.Global_Resourses.delete2;
            this.btn_DeleteSN.UniqueName = "DA1C7802EB9D4E471E915DBE7CFB126B";
            this.btn_DeleteSN.Visible = false;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_List.ColumnHeadersHeight = 40;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_launch,
            this.cn_artid,
            this.cn_article,
            this.cn_launchid,
            this.cn_coid,
            this.cn_conforder,
            this.cn_qtystarrted,
            this.cn_qty,
            this.cn_toapprove});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 50;
            this.gv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_List.Size = new System.Drawing.Size(913, 208);
            this.gv_List.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_List.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.TabIndex = 228;
            this.gv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellContentClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
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
            this.cn_conforder.ReadOnly = true;
            this.cn_conforder.Visible = false;
            this.cn_conforder.Width = 300;
            // 
            // cn_qtystarrted
            // 
            this.cn_qtystarrted.DataPropertyName = "qtystarted";
            this.cn_qtystarrted.FillWeight = 150F;
            this.cn_qtystarrted.HeaderText = "Started";
            this.cn_qtystarrted.Name = "cn_qtystarrted";
            this.cn_qtystarrted.Width = 150;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 150F;
            this.cn_qty.HeaderText = "Processed";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 150;
            // 
            // cn_toapprove
            // 
            this.cn_toapprove.DataPropertyName = "toapprove";
            this.cn_toapprove.FillWeight = 150F;
            this.cn_toapprove.HeaderText = "To approve";
            this.cn_toapprove.Name = "cn_toapprove";
            this.cn_toapprove.Visible = false;
            this.cn_toapprove.Width = 150;
            // 
            // btn_CheckAll
            // 
            this.btn_CheckAll.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked;
            this.btn_CheckAll.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_CheckAll.Image = global::Odin.Global_Resourses.check21;
            this.btn_CheckAll.Text = "Check all serials";
            this.btn_CheckAll.UniqueName = "81681B3AEC05405E34B119F6E7AE8DA4";
            this.btn_CheckAll.Visible = false;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_DeleteSN,
            this.btn_CheckAll,
            this.btn_Refresh,
            this.btn_Start});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(915, 266);
            this.kryptonHeaderGroup1.TabIndex = 251;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Processed products";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.pci;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Launch list ";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_Refresh.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_Refresh.UniqueName = "FD381D0D561B4DA5DB9A876899A04899";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Image = global::Odin.Global_Resourses.player_play;
            this.btn_Start.UniqueName = "5E6DFDFAA93C49A74C8DD0CB881B9237";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(915, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_QtyToStart);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_Start1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.rb_Valkas2B);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_Clean);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.rb_Valkas2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Qty);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_EditContent);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_AssignMaster);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Master);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(335, 781);
            this.kryptonHeaderGroup2.TabIndex = 249;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Actions";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.agt_update_critical;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Worker info";
            // 
            // rb_Valkas2B
            // 
            this.rb_Valkas2B.Location = new System.Drawing.Point(167, 266);
            this.rb_Valkas2B.Name = "rb_Valkas2B";
            this.rb_Valkas2B.Size = new System.Drawing.Size(113, 26);
            this.rb_Valkas2B.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Valkas2B.TabIndex = 251;
            this.rb_Valkas2B.Values.Text = "Valkas 2B";
            this.rb_Valkas2B.Visible = false;
            // 
            // btn_Clean
            // 
            this.btn_Clean.Location = new System.Drawing.Point(252, 384);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Clean.Size = new System.Drawing.Size(70, 75);
            this.btn_Clean.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clean.TabIndex = 255;
            this.btn_Clean.Values.Image = global::Odin.Global_Resourses.clean;
            this.btn_Clean.Values.Text = "";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click_1);
            // 
            // rb_Valkas2
            // 
            this.rb_Valkas2.Location = new System.Drawing.Point(16, 266);
            this.rb_Valkas2.Name = "rb_Valkas2";
            this.rb_Valkas2.Size = new System.Drawing.Size(100, 26);
            this.rb_Valkas2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Valkas2.TabIndex = 250;
            this.rb_Valkas2.Values.Text = "Valkas 2";
            this.rb_Valkas2.Visible = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(16, 384);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(132, 26);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.TabIndex = 254;
            this.kryptonLabel4.Values.Text = "Approval qty:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Enabled = false;
            this.txt_Qty.Location = new System.Drawing.Point(16, 415);
            this.txt_Qty.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Qty.Multiline = true;
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.ReadOnly = true;
            this.txt_Qty.Size = new System.Drawing.Size(231, 45);
            this.txt_Qty.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Qty.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Qty.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Qty.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Qty.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Qty.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Qty.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.TabIndex = 253;
            this.txt_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_EditContent
            // 
            this.btn_EditContent.Location = new System.Drawing.Point(16, 160);
            this.btn_EditContent.Name = "btn_EditContent";
            this.btn_EditContent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_EditContent.Size = new System.Drawing.Size(306, 70);
            this.btn_EditContent.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditContent.TabIndex = 248;
            this.btn_EditContent.Values.Image = global::Odin.Global_Resourses.edit;
            this.btn_EditContent.Values.Text = "Edit content";
            this.btn_EditContent.Visible = false;
            this.btn_EditContent.Click += new System.EventHandler(this.btn_EditContent_Click);
            // 
            // btn_AssignMaster
            // 
            this.btn_AssignMaster.Location = new System.Drawing.Point(252, 7);
            this.btn_AssignMaster.Name = "btn_AssignMaster";
            this.btn_AssignMaster.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_AssignMaster.Size = new System.Drawing.Size(70, 72);
            this.btn_AssignMaster.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AssignMaster.TabIndex = 246;
            this.btn_AssignMaster.Values.Image = global::Odin.Global_Resourses.Master;
            this.btn_AssignMaster.Values.Text = "";
            this.btn_AssignMaster.Click += new System.EventHandler(this.btn_AssignMaster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_SetPlace);
            this.panel1.Controls.Add(this.cmb_CommonPDA1);
            this.panel1.Controls.Add(this.btn_Approve);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 258);
            this.panel1.TabIndex = 244;
            // 
            // btn_SetPlace
            // 
            this.btn_SetPlace.Location = new System.Drawing.Point(251, 17);
            this.btn_SetPlace.Name = "btn_SetPlace";
            this.btn_SetPlace.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_SetPlace.Size = new System.Drawing.Size(62, 59);
            this.btn_SetPlace.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SetPlace.TabIndex = 266;
            this.btn_SetPlace.Values.Image = global::Odin.Global_Resourses.Ok_big;
            this.btn_SetPlace.Values.Text = "";
            this.btn_SetPlace.Click += new System.EventHandler(this.btn_SetPlace_Click);
            // 
            // cmb_CommonPDA1
            // 
            this.cmb_CommonPDA1.IsEmptyColor = false;
            this.cmb_CommonPDA1.Location = new System.Drawing.Point(16, 25);
            this.cmb_CommonPDA1.Name = "cmb_CommonPDA1";
            this.cmb_CommonPDA1.OrderBy = "id";
            this.cmb_CommonPDA1.sCurrentValue = "";
            this.cmb_CommonPDA1.SelectedValue = 0;
            this.cmb_CommonPDA1.sID_Filled = "id";
            this.cmb_CommonPDA1.Size = new System.Drawing.Size(231, 41);
            this.cmb_CommonPDA1.sTable = "PROD_ProdPlaces";
            this.cmb_CommonPDA1.sText_Filled = "place";
            this.cmb_CommonPDA1.sTitle = "Production place";
            this.cmb_CommonPDA1.TabIndex = 265;
            this.cmb_CommonPDA1.SelectedValueChanged += new Odin.CMB_Components.Common.CommonPDAEventHandler(this.cmb_CommonPDA1_SelectedValueChanged);
            // 
            // btn_Approve
            // 
            this.btn_Approve.Location = new System.Drawing.Point(16, 88);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Approve.Size = new System.Drawing.Size(306, 77);
            this.btn_Approve.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Approve.TabIndex = 241;
            this.btn_Approve.Values.Image = global::Odin.Global_Resourses.Approve_48;
            this.btn_Approve.Values.Text = "Approve selected";
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(16, 171);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Close.Size = new System.Drawing.Size(306, 77);
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.TabIndex = 240;
            this.btn_Close.Values.Image = global::Odin.Global_Resourses.exit;
            this.btn_Close.Values.Text = "Exit";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(16, 7);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(116, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 239;
            this.kryptonLabel2.Values.Text = "Supervisor:";
            // 
            // txt_Master
            // 
            this.txt_Master.Enabled = false;
            this.txt_Master.Location = new System.Drawing.Point(16, 38);
            this.txt_Master.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Master.Multiline = true;
            this.txt_Master.Name = "txt_Master";
            this.txt_Master.ReadOnly = true;
            this.txt_Master.Size = new System.Drawing.Size(231, 41);
            this.txt_Master.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Master.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Master.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Master.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Master.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Master.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Master.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Master.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Master.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Master.TabIndex = 240;
            this.txt_Master.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_Delete});
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 266);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.gv_Serials);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(915, 515);
            this.kryptonHeaderGroup3.TabIndex = 252;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Launch contents";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::Odin.Global_Resourses.pci;
            this.kryptonHeaderGroup3.ValuesSecondary.Heading = "Serial nr. list ";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Odin.Global_Resourses.delete2;
            this.btn_Delete.UniqueName = "DC665B7820CF4C89ECADA5A64DA32509";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // gv_Serials
            // 
            this.gv_Serials.AllowUserToAddRows = false;
            this.gv_Serials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_Serials.ColumnHeadersHeight = 40;
            this.gv_Serials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Serials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_select,
            this.cn_serial,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.cn_rqty,
            this.cn_rtoapprove,
            this.cn_worker,
            this.cn_when,
            this.cn_id,
            this.cn_isapproved,
            this.cn_issn,
            this.cn_opernum});
            this.gv_Serials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Serials.Location = new System.Drawing.Point(0, 0);
            this.gv_Serials.Name = "gv_Serials";
            this.gv_Serials.RowHeadersWidth = 50;
            this.gv_Serials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Serials.Size = new System.Drawing.Size(913, 457);
            this.gv_Serials.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_Serials.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_Serials.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_Serials.TabIndex = 228;
            this.gv_Serials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Serials_CellClick);
            this.gv_Serials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Serials_CellContentClick);
            this.gv_Serials.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Serials_CellEndEdit);
            this.gv_Serials.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Serials_CellValueChanged);
            // 
            // cn_select
            // 
            this.cn_select.DataPropertyName = "toadd";
            this.cn_select.FalseValue = "0";
            this.cn_select.FillWeight = 80F;
            this.cn_select.HeaderText = "Select";
            this.cn_select.IndeterminateValue = "1";
            this.cn_select.Name = "cn_select";
            this.cn_select.TrueValue = "-1";
            this.cn_select.Width = 80;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "artid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Art. id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "article";
            this.dataGridViewTextBoxColumn2.FillWeight = 250F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Article";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "launchid";
            this.dataGridViewTextBoxColumn3.HeaderText = "launchid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "coid";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 300F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Conf. order";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // cn_rqty
            // 
            this.cn_rqty.DataPropertyName = "qty";
            this.cn_rqty.FillWeight = 120F;
            this.cn_rqty.HeaderText = "Quantity";
            this.cn_rqty.Name = "cn_rqty";
            this.cn_rqty.ReadOnly = true;
            this.cn_rqty.Width = 120;
            // 
            // cn_rtoapprove
            // 
            this.cn_rtoapprove.FillWeight = 120F;
            this.cn_rtoapprove.HeaderText = "To approve";
            this.cn_rtoapprove.Name = "cn_rtoapprove";
            this.cn_rtoapprove.Width = 120;
            // 
            // cn_worker
            // 
            this.cn_worker.DataPropertyName = "worker";
            this.cn_worker.FillWeight = 250F;
            this.cn_worker.HeaderText = "Worker";
            this.cn_worker.Name = "cn_worker";
            this.cn_worker.ReadOnly = true;
            this.cn_worker.Width = 250;
            // 
            // cn_when
            // 
            this.cn_when.DataPropertyName = "when";
            this.cn_when.FillWeight = 300F;
            this.cn_when.HeaderText = "Date";
            this.cn_when.Name = "cn_when";
            this.cn_when.ReadOnly = true;
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
            // cn_issn
            // 
            this.cn_issn.DataPropertyName = "issn";
            this.cn_issn.HeaderText = "is sn";
            this.cn_issn.Name = "cn_issn";
            this.cn_issn.Visible = false;
            // 
            // cn_opernum
            // 
            this.cn_opernum.DataPropertyName = "opernum";
            this.cn_opernum.HeaderText = "Oper. №";
            this.cn_opernum.Name = "cn_opernum";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 303);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(218, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 261;
            this.kryptonLabel1.Values.Text = "Qty need to be started:";
            // 
            // txt_QtyToStart
            // 
            this.txt_QtyToStart.Enabled = false;
            this.txt_QtyToStart.Location = new System.Drawing.Point(17, 334);
            this.txt_QtyToStart.Margin = new System.Windows.Forms.Padding(2);
            this.txt_QtyToStart.Multiline = true;
            this.txt_QtyToStart.Name = "txt_QtyToStart";
            this.txt_QtyToStart.ReadOnly = true;
            this.txt_QtyToStart.Size = new System.Drawing.Size(231, 45);
            this.txt_QtyToStart.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyToStart.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_QtyToStart.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_QtyToStart.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_QtyToStart.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_QtyToStart.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_QtyToStart.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_QtyToStart.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyToStart.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyToStart.TabIndex = 260;
            this.txt_QtyToStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Start1
            // 
            this.btn_Start1.Location = new System.Drawing.Point(252, 308);
            this.btn_Start1.Name = "btn_Start1";
            this.btn_Start1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Start1.Size = new System.Drawing.Size(71, 70);
            this.btn_Start1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start1.TabIndex = 259;
            this.btn_Start1.Values.Image = global::Odin.Global_Resourses.play_big;
            this.btn_Start1.Values.Text = "";
            this.btn_Start1.Click += new System.EventHandler(this.btn_Start1_Click);
            // 
            // frm_MasterApproveFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 781);
            this.Controls.Add(this.kryptonHeaderGroup3);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MasterApproveFin";
            this.TabText = "Supervisor\'s Approval";
            this.Text = "Supervisor\'s Approval";
            this.Load += new System.EventHandler(this.frm_MasterApproveTot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Serials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Serials)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_DeleteSN;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_CheckAll;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AssignMaster;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2B;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Approve;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Master;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_EditContent;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Delete;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Serials;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Qty;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Clean;
        private Global_Classes.SyncBindingSource bs_Serials;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtystarrted;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_toapprove;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_select;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_rtoapprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isapproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_issn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_opernum;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_SetPlace;
        private CMB_Components.Common.cmb_CommonPDA cmb_CommonPDA1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Start;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_QtyToStart;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Start1;
    }
}