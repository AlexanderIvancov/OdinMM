namespace Odin.DataCollection
{
    partial class frm_MasterApprove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MasterApprove));
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Started = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_ChangeLaunch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Qty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Launch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_AssignMaster = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_Valkas2B = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Valkas2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_Clean = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Approve = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Master = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_DeleteSN = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_CheckAll = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.chk_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_coid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_conforder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_toapprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_isapproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_issn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(903, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Started);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_ChangeLaunch);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Qty);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Launch);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.btn_AssignMaster);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Master);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(335, 1061);
            this.kryptonHeaderGroup2.TabIndex = 246;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Actions";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.agt_update_critical;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Worker info";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(16, 313);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(137, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 253;
            this.kryptonLabel1.Values.Text = "Qty available:";
            // 
            // txt_Started
            // 
            this.txt_Started.Enabled = false;
            this.txt_Started.Location = new System.Drawing.Point(168, 303);
            this.txt_Started.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Started.Multiline = true;
            this.txt_Started.Name = "txt_Started";
            this.txt_Started.ReadOnly = true;
            this.txt_Started.Size = new System.Drawing.Size(155, 45);
            this.txt_Started.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Started.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Started.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Started.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Started.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Started.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Started.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Started.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Started.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Started.TabIndex = 252;
            this.txt_Started.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ChangeLaunch
            // 
            this.btn_ChangeLaunch.Location = new System.Drawing.Point(16, 230);
            this.btn_ChangeLaunch.Name = "btn_ChangeLaunch";
            this.btn_ChangeLaunch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_ChangeLaunch.Size = new System.Drawing.Size(306, 68);
            this.btn_ChangeLaunch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeLaunch.TabIndex = 251;
            this.btn_ChangeLaunch.Values.Image = global::Odin.Global_Resourses.launch;
            this.btn_ChangeLaunch.Values.Text = "Select launch";
            this.btn_ChangeLaunch.Click += new System.EventHandler(this.btn_ChangeLaunch_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(16, 360);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(151, 26);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.TabIndex = 250;
            this.kryptonLabel4.Values.Text = "Qty to approve:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Enabled = false;
            this.txt_Qty.Location = new System.Drawing.Point(168, 352);
            this.txt_Qty.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Qty.Multiline = true;
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.ReadOnly = true;
            this.txt_Qty.Size = new System.Drawing.Size(155, 45);
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
            this.txt_Qty.TabIndex = 249;
            this.txt_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(16, 156);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(85, 26);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.TabIndex = 247;
            this.kryptonLabel3.Values.Text = "Launch:";
            // 
            // txt_Launch
            // 
            this.txt_Launch.Enabled = false;
            this.txt_Launch.Location = new System.Drawing.Point(16, 187);
            this.txt_Launch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Launch.Multiline = true;
            this.txt_Launch.Name = "txt_Launch";
            this.txt_Launch.ReadOnly = true;
            this.txt_Launch.Size = new System.Drawing.Size(306, 38);
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
            this.txt_Launch.TabIndex = 248;
            this.txt_Launch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AssignMaster
            // 
            this.btn_AssignMaster.Location = new System.Drawing.Point(16, 84);
            this.btn_AssignMaster.Name = "btn_AssignMaster";
            this.btn_AssignMaster.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_AssignMaster.Size = new System.Drawing.Size(306, 70);
            this.btn_AssignMaster.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AssignMaster.TabIndex = 246;
            this.btn_AssignMaster.Values.Image = global::Odin.Global_Resourses.Master;
            this.btn_AssignMaster.Values.Text = "Assign master";
            this.btn_AssignMaster.Click += new System.EventHandler(this.btn_AssignMaster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rb_Valkas2B);
            this.panel1.Controls.Add(this.rb_Valkas2);
            this.panel1.Controls.Add(this.btn_Clean);
            this.panel1.Controls.Add(this.btn_Approve);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 745);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 258);
            this.panel1.TabIndex = 244;
            // 
            // rb_Valkas2B
            // 
            this.rb_Valkas2B.Location = new System.Drawing.Point(167, 26);
            this.rb_Valkas2B.Name = "rb_Valkas2B";
            this.rb_Valkas2B.Size = new System.Drawing.Size(113, 26);
            this.rb_Valkas2B.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Valkas2B.TabIndex = 251;
            this.rb_Valkas2B.Values.Text = "Valkas 2B";
            // 
            // rb_Valkas2
            // 
            this.rb_Valkas2.Location = new System.Drawing.Point(16, 26);
            this.rb_Valkas2.Name = "rb_Valkas2";
            this.rb_Valkas2.Size = new System.Drawing.Size(100, 26);
            this.rb_Valkas2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Valkas2.TabIndex = 250;
            this.rb_Valkas2.Values.Text = "Valkas 2";
            // 
            // btn_Clean
            // 
            this.btn_Clean.Location = new System.Drawing.Point(16, 88);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Clean.Size = new System.Drawing.Size(141, 77);
            this.btn_Clean.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clean.TabIndex = 249;
            this.btn_Clean.Values.Image = global::Odin.Global_Resourses.clean;
            this.btn_Clean.Values.Text = "Clear";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Approve
            // 
            this.btn_Approve.Location = new System.Drawing.Point(167, 88);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Approve.Size = new System.Drawing.Size(155, 77);
            this.btn_Approve.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Approve.TabIndex = 241;
            this.btn_Approve.Values.Image = global::Odin.Global_Resourses.Approve_48;
            this.btn_Approve.Values.Text = "Approve";
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
            this.kryptonLabel2.Size = new System.Drawing.Size(81, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 239;
            this.kryptonLabel2.Values.Text = "Master:";
            // 
            // txt_Master
            // 
            this.txt_Master.Enabled = false;
            this.txt_Master.Location = new System.Drawing.Point(16, 38);
            this.txt_Master.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Master.Multiline = true;
            this.txt_Master.Name = "txt_Master";
            this.txt_Master.ReadOnly = true;
            this.txt_Master.Size = new System.Drawing.Size(306, 41);
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
            // txt_Oper
            // 
            this.txt_Oper.Location = new System.Drawing.Point(559, 485);
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.Size = new System.Drawing.Size(121, 91);
            this.txt_Oper.TabIndex = 247;
            this.txt_Oper.Text = "";
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_DeleteSN,
            this.btn_CheckAll});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(903, 1061);
            this.kryptonHeaderGroup1.TabIndex = 248;
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
            // btn_CheckAll
            // 
            this.btn_CheckAll.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked;
            this.btn_CheckAll.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_CheckAll.Image = global::Odin.Global_Resourses.check21;
            this.btn_CheckAll.Text = "Check all serials";
            this.btn_CheckAll.UniqueName = "81681B3AEC05405E34B119F6E7AE8DA4";
            this.btn_CheckAll.Visible = false;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_List.ColumnHeadersHeight = 40;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_check,
            this.cn_serial,
            this.cn_launch,
            this.cn_artid,
            this.cn_article,
            this.cn_launchid,
            this.cn_coid,
            this.cn_conforder,
            this.cn_qty,
            this.cn_toapprove,
            this.cn_worker,
            this.cn_when,
            this.cn_id,
            this.cn_isapproved,
            this.cn_issn});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 50;
            this.gv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_List.Size = new System.Drawing.Size(901, 1003);
            this.gv_List.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_List.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.TabIndex = 228;
            this.gv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellClick);
            this.gv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellContentClick);
            this.gv_List.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellEndEdit);
            this.gv_List.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_CellMouseClick);
            this.gv_List.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValueChanged);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gv_List_EditingControlShowing);
            this.gv_List.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gv_List_MouseDown);
            this.gv_List.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gv_List_MouseUp);
            // 
            // chk_check
            // 
            this.chk_check.DataPropertyName = "toadd";
            this.chk_check.FalseValue = "0";
            this.chk_check.FillWeight = 80F;
            this.chk_check.HeaderText = "Check";
            this.chk_check.IndeterminateValue = "1";
            this.chk_check.Name = "chk_check";
            this.chk_check.TrueValue = "-1";
            this.chk_check.Width = 80;
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
            this.cn_conforder.ReadOnly = true;
            this.cn_conforder.Visible = false;
            this.cn_conforder.Width = 300;
            // 
            // cn_qty
            // 
            this.cn_qty.DataPropertyName = "qty";
            this.cn_qty.FillWeight = 120F;
            this.cn_qty.HeaderText = "Quantity";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.ReadOnly = true;
            this.cn_qty.Width = 120;
            // 
            // cn_toapprove
            // 
            this.cn_toapprove.FillWeight = 120F;
            this.cn_toapprove.HeaderText = "To approve";
            this.cn_toapprove.Name = "cn_toapprove";
            this.cn_toapprove.Width = 120;
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
            this.cn_when.HeaderText = "When";
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
            // frm_MasterApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 1061);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.txt_Oper);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MasterApprove";
            this.TabText = "Master\'s approvement";
            this.Text = "Master\'s approvement";
            this.Activated += new System.EventHandler(this.frm_MasterApprove_Activated);
            this.Load += new System.EventHandler(this.frm_MasterApprove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AssignMaster;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Master;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Oper;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_DeleteSN;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Approve;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_CheckAll;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Qty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Launch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Clean;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ChangeLaunch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_coid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_conforder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_toapprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_when;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_isapproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_issn;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2B;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Started;
    }
}