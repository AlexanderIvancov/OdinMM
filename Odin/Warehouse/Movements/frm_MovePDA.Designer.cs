namespace Odin.Warehouse.Movements
{
    partial class frm_MovePDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MovePDA));
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.txt_Documents = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_DeleteDocs = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chk_CheckLabel = new System.Windows.Forms.CheckBox();
            this.chk_PrintDoc = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btn_Delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Batch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.grp_MoveType = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.chk_ReturnFromProduction = new System.Windows.Forms.CheckBox();
            this.chk_InProduction = new System.Windows.Forms.CheckBox();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_qtybeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_placeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_datacode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_bdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_MoveType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_MoveType.Panel)).BeginInit();
            this.grp_MoveType.Panel.SuspendLayout();
            this.grp_MoveType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Oper
            // 
            this.txt_Oper.Location = new System.Drawing.Point(-152, 446);
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.Size = new System.Drawing.Size(121, 91);
            this.txt_Oper.TabIndex = 230;
            this.txt_Oper.Text = "";
            this.txt_Oper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Oper_KeyPress);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(808, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Documents);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Batch);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.grp_MoveType);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.txt_Oper);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(302, 926);
            this.kryptonHeaderGroup2.TabIndex = 231;
            // 
            // txt_Documents
            // 
            this.txt_Documents.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_DeleteDocs});
            this.txt_Documents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Documents.Location = new System.Drawing.Point(0, 236);
            this.txt_Documents.Multiline = true;
            this.txt_Documents.Name = "txt_Documents";
            this.txt_Documents.Size = new System.Drawing.Size(300, 174);
            this.txt_Documents.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Documents.TabIndex = 234;
            this.txt_Documents.Enter += new System.EventHandler(this.txt_Documents_Enter);
            // 
            // btn_DeleteDocs
            // 
            this.btn_DeleteDocs.Image = global::Odin.Global_Resourses.delete2__2_;
            this.btn_DeleteDocs.UniqueName = "5F57787DA6054DDA7F98467641907D48";
            this.btn_DeleteDocs.Click += new System.EventHandler(this.btn_DeleteDocs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Controls.Add(this.chk_CheckLabel);
            this.panel1.Controls.Add(this.chk_PrintDoc);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 463);
            this.panel1.TabIndex = 233;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(205, 16);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Print.Size = new System.Drawing.Size(83, 50);
            this.btn_Print.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Print.TabIndex = 244;
            this.btn_Print.Values.Image = global::Odin.Global_Resourses.Print2;
            this.btn_Print.Values.Text = "";
            this.btn_Print.Visible = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // chk_CheckLabel
            // 
            this.chk_CheckLabel.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_CheckLabel.BackColor = System.Drawing.Color.LightGreen;
            this.chk_CheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_CheckLabel.Location = new System.Drawing.Point(17, 16);
            this.chk_CheckLabel.Name = "chk_CheckLabel";
            this.chk_CheckLabel.Size = new System.Drawing.Size(182, 50);
            this.chk_CheckLabel.TabIndex = 243;
            this.chk_CheckLabel.Text = "Check label";
            this.chk_CheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_CheckLabel.UseVisualStyleBackColor = false;
            this.chk_CheckLabel.Visible = false;
            this.chk_CheckLabel.CheckedChanged += new System.EventHandler(this.chk_CheckLabel_CheckedChanged);
            // 
            // chk_PrintDoc
            // 
            this.chk_PrintDoc.Location = new System.Drawing.Point(40, 84);
            this.chk_PrintDoc.Name = "chk_PrintDoc";
            this.chk_PrintDoc.Size = new System.Drawing.Size(224, 23);
            this.chk_PrintDoc.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_PrintDoc.TabIndex = 241;
            this.chk_PrintDoc.Values.Text = "Print movement document";
            this.chk_PrintDoc.CheckedChanged += new System.EventHandler(this.chk_PrintDoc_CheckedChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(17, 209);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Delete.Size = new System.Drawing.Size(272, 77);
            this.btn_Delete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.TabIndex = 240;
            this.btn_Delete.Values.Image = global::Odin.Global_Resourses.Delete_48x48;
            this.btn_Delete.Values.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(17, 373);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Close.Size = new System.Drawing.Size(272, 77);
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.TabIndex = 239;
            this.btn_Close.Values.Image = global::Odin.Global_Resourses.exit;
            this.btn_Close.Values.Text = "Exit";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(17, 292);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Clear.Size = new System.Drawing.Size(272, 75);
            this.btn_Clear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clear.TabIndex = 238;
            this.btn_Clear.Values.Image = global::Odin.Global_Resourses.clean;
            this.btn_Clear.Values.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(17, 126);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OK.Size = new System.Drawing.Size(272, 77);
            this.btn_OK.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.TabIndex = 237;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_48x48;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 187);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(71, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 232;
            this.kryptonLabel1.Values.Text = "Batch:";
            // 
            // txt_Batch
            // 
            this.txt_Batch.Enabled = false;
            this.txt_Batch.Location = new System.Drawing.Point(81, 171);
            this.txt_Batch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Batch.Multiline = true;
            this.txt_Batch.Name = "txt_Batch";
            this.txt_Batch.ReadOnly = true;
            this.txt_Batch.Size = new System.Drawing.Size(209, 56);
            this.txt_Batch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Batch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Batch.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Batch.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Batch.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Batch.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Batch.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Batch.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Batch.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Batch.TabIndex = 231;
            // 
            // grp_MoveType
            // 
            this.grp_MoveType.Location = new System.Drawing.Point(5, 6);
            this.grp_MoveType.Name = "grp_MoveType";
            // 
            // grp_MoveType.Panel
            // 
            this.grp_MoveType.Panel.Controls.Add(this.chk_ReturnFromProduction);
            this.grp_MoveType.Panel.Controls.Add(this.chk_InProduction);
            this.grp_MoveType.Size = new System.Drawing.Size(292, 160);
            this.grp_MoveType.TabIndex = 230;
            this.grp_MoveType.Values.Heading = "Movement type";
            // 
            // chk_ReturnFromProduction
            // 
            this.chk_ReturnFromProduction.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_ReturnFromProduction.BackColor = System.Drawing.Color.LightGreen;
            this.chk_ReturnFromProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_ReturnFromProduction.Location = new System.Drawing.Point(10, 71);
            this.chk_ReturnFromProduction.Name = "chk_ReturnFromProduction";
            this.chk_ReturnFromProduction.Size = new System.Drawing.Size(272, 50);
            this.chk_ReturnFromProduction.TabIndex = 226;
            this.chk_ReturnFromProduction.Text = "Return from production";
            this.chk_ReturnFromProduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_ReturnFromProduction.UseVisualStyleBackColor = false;
            this.chk_ReturnFromProduction.CheckedChanged += new System.EventHandler(this.chk_ReturnFromProduction_CheckedChanged);
            // 
            // chk_InProduction
            // 
            this.chk_InProduction.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_InProduction.BackColor = System.Drawing.Color.Pink;
            this.chk_InProduction.Checked = true;
            this.chk_InProduction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_InProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_InProduction.Location = new System.Drawing.Point(10, 15);
            this.chk_InProduction.Name = "chk_InProduction";
            this.chk_InProduction.Size = new System.Drawing.Size(272, 50);
            this.chk_InProduction.TabIndex = 225;
            this.chk_InProduction.Text = "Move into production";
            this.chk_InProduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_InProduction.UseVisualStyleBackColor = false;
            this.chk_InProduction.CheckedChanged += new System.EventHandler(this.chk_InProduction_CheckedChanged);
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(808, 926);
            this.kryptonHeaderGroup1.TabIndex = 232;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Labels";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.barcode_2d;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Numbers list ";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_List.ColumnHeadersHeight = 40;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_index,
            this.cn_artid,
            this.cn_article,
            this.cn_label,
            this.cn_qty,
            this.cn_qtybeg,
            this.cn_unit,
            this.cn_batch,
            this.cn_placeid,
            this.cn_place,
            this.cn_comments,
            this.cn_datacode,
            this.cn_expdate,
            this.cn_bdid});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 50;
            this.gv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_List.Size = new System.Drawing.Size(806, 873);
            this.gv_List.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_List.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_List.TabIndex = 228;
            this.gv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellClick);
            this.gv_List.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellEndEdit);
            this.gv_List.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellEndEdit);
            this.gv_List.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_CellMouseClick);
            this.gv_List.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValueChanged);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            this.gv_List.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gv_List_EditingControlShowing);
            this.gv_List.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gv_List_MouseDown);
            this.gv_List.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gv_List_MouseUp);
            // 
            // cn_index
            // 
            this.cn_index.HeaderText = "index";
            this.cn_index.Name = "cn_index";
            this.cn_index.ReadOnly = true;
            this.cn_index.Visible = false;
            // 
            // cn_artid
            // 
            this.cn_artid.HeaderText = "Art. id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.ReadOnly = true;
            // 
            // cn_article
            // 
            this.cn_article.FillWeight = 250F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.ReadOnly = true;
            this.cn_article.Width = 250;
            // 
            // cn_label
            // 
            this.cn_label.FillWeight = 150F;
            this.cn_label.HeaderText = "Label";
            this.cn_label.Name = "cn_label";
            this.cn_label.ReadOnly = true;
            this.cn_label.Width = 150;
            // 
            // cn_qty
            // 
            this.cn_qty.FillWeight = 120F;
            this.cn_qty.HeaderText = "Qty";
            this.cn_qty.Name = "cn_qty";
            this.cn_qty.Width = 120;
            // 
            // cn_qtybeg
            // 
            this.cn_qtybeg.DataPropertyName = "qtybeg";
            this.cn_qtybeg.HeaderText = "qtybeg";
            this.cn_qtybeg.Name = "cn_qtybeg";
            this.cn_qtybeg.Visible = false;
            // 
            // cn_unit
            // 
            this.cn_unit.FillWeight = 55F;
            this.cn_unit.HeaderText = "Unit";
            this.cn_unit.Name = "cn_unit";
            this.cn_unit.ReadOnly = true;
            this.cn_unit.Width = 55;
            // 
            // cn_batch
            // 
            this.cn_batch.FillWeight = 150F;
            this.cn_batch.HeaderText = "Batch";
            this.cn_batch.Name = "cn_batch";
            this.cn_batch.ReadOnly = true;
            this.cn_batch.Width = 150;
            // 
            // cn_placeid
            // 
            this.cn_placeid.HeaderText = "placeid";
            this.cn_placeid.Name = "cn_placeid";
            this.cn_placeid.Visible = false;
            // 
            // cn_place
            // 
            this.cn_place.FillWeight = 150F;
            this.cn_place.HeaderText = "Place";
            this.cn_place.Name = "cn_place";
            this.cn_place.ReadOnly = true;
            this.cn_place.Visible = false;
            this.cn_place.Width = 150;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 250F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.ReadOnly = true;
            this.cn_comments.Width = 250;
            // 
            // cn_datacode
            // 
            this.cn_datacode.FillWeight = 150F;
            this.cn_datacode.HeaderText = "DataCode";
            this.cn_datacode.Name = "cn_datacode";
            this.cn_datacode.ReadOnly = true;
            this.cn_datacode.Width = 150;
            // 
            // cn_expdate
            // 
            this.cn_expdate.FillWeight = 150F;
            this.cn_expdate.HeaderText = "Exp. date";
            this.cn_expdate.Name = "cn_expdate";
            this.cn_expdate.ReadOnly = true;
            this.cn_expdate.Width = 150;
            // 
            // cn_bdid
            // 
            this.cn_bdid.HeaderText = "bdetid";
            this.cn_bdid.Name = "cn_bdid";
            this.cn_bdid.ReadOnly = true;
            this.cn_bdid.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "index";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Art. id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 250F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Article";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 150F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Label";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 120F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qtybeg";
            this.dataGridViewTextBoxColumn6.HeaderText = "qtybeg";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 55F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 55;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 150F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Batch";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "placeid";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 150F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Place";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "comments";
            this.dataGridViewTextBoxColumn11.FillWeight = 250F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 250;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.FillWeight = 150F;
            this.dataGridViewTextBoxColumn12.HeaderText = "DataCode";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.FillWeight = 150F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Exp. date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "bdetid";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // frm_MovePDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 926);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MovePDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock movement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frm_MovePDA_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MovePDA_FormClosing);
            this.Load += new System.EventHandler(this.frm_MovePDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_MoveType.Panel)).EndInit();
            this.grp_MoveType.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_MoveType)).EndInit();
            this.grp_MoveType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Oper;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Batch;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grp_MoveType;
        private System.Windows.Forms.CheckBox chk_ReturnFromProduction;
        private System.Windows.Forms.CheckBox chk_InProduction;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Delete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Documents;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_DeleteDocs;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_PrintDoc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
        private System.Windows.Forms.CheckBox chk_CheckLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_qtybeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_placeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_datacode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_expdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_bdid;
    }
}