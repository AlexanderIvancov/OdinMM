namespace Odin.DataCollection
{
    partial class frm_AddRepairDets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddRepairDets));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Serial = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Qty = new Owf.Controls.NumericTetxBox();
            this.txt_Worktime = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_Defects = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lbl_Parameters = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_defect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_positions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Defects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.txt_Serial);
            this.kryptonPanel1.Controls.Add(this.txt_Qty);
            this.kryptonPanel1.Controls.Add(this.txt_Worktime);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonHeaderGroup3);
            this.kryptonPanel1.Controls.Add(this.lbl_Parameters);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(622, 523);
            this.kryptonPanel1.TabIndex = 30;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 32);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(99, 26);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.TabIndex = 278;
            this.kryptonLabel3.Values.Text = "PCB S/N:";
            // 
            // txt_Serial
            // 
            this.txt_Serial.Enabled = false;
            this.txt_Serial.Location = new System.Drawing.Point(180, 24);
            this.txt_Serial.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Serial.Multiline = true;
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.ReadOnly = true;
            this.txt_Serial.Size = new System.Drawing.Size(185, 40);
            this.txt_Serial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Serial.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Serial.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Serial.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Serial.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Serial.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Serial.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Serial.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Serial.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Serial.TabIndex = 277;
            this.txt_Serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Qty
            // 
            this.txt_Qty.AllowDecimalSeparator = true;
            this.txt_Qty.AllowSpace = false;
            this.txt_Qty.Location = new System.Drawing.Point(180, 69);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(100, 31);
            this.txt_Qty.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.TabIndex = 268;
            this.txt_Qty.Text = "1";
            // 
            // txt_Worktime
            // 
            this.txt_Worktime.AllowDecimalSeparator = true;
            this.txt_Worktime.AllowSpace = false;
            this.txt_Worktime.Location = new System.Drawing.Point(180, 106);
            this.txt_Worktime.Name = "txt_Worktime";
            this.txt_Worktime.Size = new System.Drawing.Size(100, 31);
            this.txt_Worktime.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worktime.TabIndex = 267;
            this.txt_Worktime.Text = "0";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 72);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 264;
            this.kryptonLabel1.Values.Text = "Qty:";
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 155);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.gv_Defects);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(622, 368);
            this.kryptonHeaderGroup3.TabIndex = 263;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Defects";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::Odin.Global_Resourses.siren;
            this.kryptonHeaderGroup3.ValuesSecondary.Heading = "Workers list ";
            // 
            // gv_Defects
            // 
            this.gv_Defects.AllowUserToAddRows = false;
            this.gv_Defects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_Defects.ColumnHeadersHeight = 40;
            this.gv_Defects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Defects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_Code,
            this.cn_defect,
            this.cn_positions});
            this.gv_Defects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Defects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gv_Defects.Location = new System.Drawing.Point(0, 0);
            this.gv_Defects.Name = "gv_Defects";
            this.gv_Defects.RowHeadersWidth = 50;
            this.gv_Defects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Defects.Size = new System.Drawing.Size(620, 310);
            this.gv_Defects.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_Defects.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_Defects.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_Defects.TabIndex = 228;
            // 
            // lbl_Parameters
            // 
            this.lbl_Parameters.Location = new System.Drawing.Point(3, 108);
            this.lbl_Parameters.Name = "lbl_Parameters";
            this.lbl_Parameters.Size = new System.Drawing.Size(156, 26);
            this.lbl_Parameters.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Parameters.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Parameters.TabIndex = 243;
            this.lbl_Parameters.Values.Text = "Worktime (min):";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(490, 15);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(120, 58);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(490, 79);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 58);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            // 
            // cn_Code
            // 
            this.cn_Code.DataPropertyName = "code";
            this.cn_Code.HeaderText = "Code";
            this.cn_Code.Name = "cn_Code";
            this.cn_Code.ReadOnly = true;
            // 
            // cn_defect
            // 
            this.cn_defect.DataPropertyName = "description";
            this.cn_defect.FillWeight = 200F;
            this.cn_defect.HeaderText = "Defect";
            this.cn_defect.Name = "cn_defect";
            this.cn_defect.ReadOnly = true;
            this.cn_defect.Width = 200;
            // 
            // cn_positions
            // 
            this.cn_positions.DataPropertyName = "positions";
            this.cn_positions.FillWeight = 250F;
            this.cn_positions.HeaderText = "Positions";
            this.cn_positions.Name = "cn_positions";
            this.cn_positions.Width = 250;
            // 
            // frm_AddRepairDets
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 523);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddRepairDets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add repair dets";
            this.Activated += new System.EventHandler(this.frm_FCAdditContent_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Defects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Parameters;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Defects;
        private Owf.Controls.NumericTetxBox txt_Qty;
        private Owf.Controls.NumericTetxBox txt_Worktime;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Serial;
        private Global_Classes.SyncBindingSource bs_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_defect;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_positions;
    }
}