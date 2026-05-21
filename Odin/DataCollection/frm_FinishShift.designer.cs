namespace Odin.DataCollection
{
    partial class frm_FinishShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FinishShift));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeaderGroup3 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Delete = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_add = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gv_Workers = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Worktime = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_AddTime = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Instructions = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Parameters = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lbl_Date = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).BeginInit();
            this.kryptonHeaderGroup3.Panel.SuspendLayout();
            this.kryptonHeaderGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Workers)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_Date);
            this.kryptonPanel1.Controls.Add(this.lbl_Date);
            this.kryptonPanel1.Controls.Add(this.kryptonHeaderGroup3);
            this.kryptonPanel1.Controls.Add(this.txt_Worktime);
            this.kryptonPanel1.Controls.Add(this.btn_AddTime);
            this.kryptonPanel1.Controls.Add(this.lbl_Instructions);
            this.kryptonPanel1.Controls.Add(this.lbl_Parameters);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(510, 476);
            this.kryptonPanel1.TabIndex = 30;
            // 
            // kryptonHeaderGroup3
            // 
            this.kryptonHeaderGroup3.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_Delete,
            this.btn_add});
            this.kryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderGroup3.Location = new System.Drawing.Point(0, 256);
            this.kryptonHeaderGroup3.Name = "kryptonHeaderGroup3";
            // 
            // kryptonHeaderGroup3.Panel
            // 
            this.kryptonHeaderGroup3.Panel.Controls.Add(this.gv_Workers);
            this.kryptonHeaderGroup3.Size = new System.Drawing.Size(510, 220);
            this.kryptonHeaderGroup3.TabIndex = 263;
            this.kryptonHeaderGroup3.ValuesPrimary.Heading = "Workers";
            this.kryptonHeaderGroup3.ValuesPrimary.Image = global::Odin.Global_Resourses.role;
            this.kryptonHeaderGroup3.ValuesSecondary.Heading = "Workers list ";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Odin.Global_Resourses.delete2;
            this.btn_Delete.UniqueName = "DC665B7820CF4C89ECADA5A64DA32509";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btn_add.Image = global::Odin.Global_Resourses.add__2_;
            this.btn_add.UniqueName = "FC9D1396BD5E4703B6A811764A8C866A";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gv_Workers
            // 
            this.gv_Workers.AllowUserToAddRows = false;
            this.gv_Workers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gv_Workers.ColumnHeadersHeight = 40;
            this.gv_Workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_Workers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_worker});
            this.gv_Workers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Workers.Location = new System.Drawing.Point(0, 0);
            this.gv_Workers.Name = "gv_Workers";
            this.gv_Workers.RowHeadersWidth = 50;
            this.gv_Workers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Workers.Size = new System.Drawing.Size(508, 156);
            this.gv_Workers.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.gv_Workers.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_Workers.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gv_Workers.TabIndex = 228;
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            // 
            // cn_worker
            // 
            this.cn_worker.DataPropertyName = "worker";
            this.cn_worker.FillWeight = 420F;
            this.cn_worker.HeaderText = "Worker";
            this.cn_worker.Name = "cn_worker";
            this.cn_worker.ReadOnly = true;
            this.cn_worker.Width = 420;
            // 
            // txt_Worktime
            // 
            this.txt_Worktime.Enabled = false;
            this.txt_Worktime.Location = new System.Drawing.Point(199, 204);
            this.txt_Worktime.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Worktime.Multiline = true;
            this.txt_Worktime.Name = "txt_Worktime";
            this.txt_Worktime.ReadOnly = true;
            this.txt_Worktime.Size = new System.Drawing.Size(141, 40);
            this.txt_Worktime.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worktime.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.txt_Worktime.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Worktime.StateDisabled.Border.Color1 = System.Drawing.Color.White;
            this.txt_Worktime.StateDisabled.Border.Color2 = System.Drawing.Color.White;
            this.txt_Worktime.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Worktime.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Worktime.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worktime.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Worktime.TabIndex = 262;
            this.txt_Worktime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AddTime
            // 
            this.btn_AddTime.Location = new System.Drawing.Point(378, 192);
            this.btn_AddTime.Name = "btn_AddTime";
            this.btn_AddTime.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_AddTime.Size = new System.Drawing.Size(120, 58);
            this.btn_AddTime.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddTime.TabIndex = 261;
            this.btn_AddTime.Values.Image = global::Odin.Global_Resourses.calculator_edit;
            this.btn_AddTime.Values.Text = "";
            this.btn_AddTime.Click += new System.EventHandler(this.btn_AddTime_Click);
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.Location = new System.Drawing.Point(12, 15);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(111, 26);
            this.lbl_Instructions.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Instructions.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Instructions.TabIndex = 244;
            this.lbl_Instructions.Values.Text = "Finish shift";
            // 
            // lbl_Parameters
            // 
            this.lbl_Parameters.Location = new System.Drawing.Point(12, 209);
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
            this.btn_OK.Location = new System.Drawing.Point(378, 15);
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
            this.btn_Cancel.Location = new System.Drawing.Point(378, 79);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 58);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Date
            // 
            this.txt_Date.CalendarShowWeekNumbers = true;
            this.txt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Date.Location = new System.Drawing.Point(199, 170);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(141, 29);
            this.txt_Date.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.TabIndex = 265;
            this.txt_Date.Visible = false;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Location = new System.Drawing.Point(12, 170);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(62, 26);
            this.lbl_Date.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.TabIndex = 264;
            this.lbl_Date.Values.Text = "Date:";
            this.lbl_Date.Visible = false;
            // 
            // frm_FinishShift
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 476);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_FinishShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finish shift";
            this.Activated += new System.EventHandler(this.frm_FCAdditContent_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3.Panel)).EndInit();
            this.kryptonHeaderGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup3)).EndInit();
            this.kryptonHeaderGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Workers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Parameters;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Instructions;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Worktime;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddTime;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup3;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Delete;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_add;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Workers;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_worker;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txt_Date;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Date;
    }
}