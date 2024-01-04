namespace Odin.CMB_Components.Currencies
{
    partial class frm_ImportCurRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ImportCurRate));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Download = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dt_CurDate = new System.Windows.Forms.DateTimePicker();
            this.gv_Info = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dt_CurDateTill = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.dt_CurDateTill);
            this.kryptonPanel1.Controls.Add(this.btn_Download);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.dt_CurDate);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(545, 49);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(432, 5);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(101, 38);
            this.btn_Download.TabIndex = 2;
            this.btn_Download.Values.Image = global::Odin.Global_Resourses.Download_24x24;
            this.btn_Download.Values.Text = "Download";
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Date from:";
            // 
            // dt_CurDate
            // 
            this.dt_CurDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_CurDate.Location = new System.Drawing.Point(83, 15);
            this.dt_CurDate.Name = "dt_CurDate";
            this.dt_CurDate.Size = new System.Drawing.Size(102, 20);
            this.dt_CurDate.TabIndex = 0;
            this.dt_CurDate.ValueChanged += new System.EventHandler(this.dt_CurDate_ValueChanged);
            // 
            // gv_Info
            // 
            this.gv_Info.AllowUserToAddRows = false;
            this.gv_Info.AllowUserToDeleteRows = false;
            this.gv_Info.AllowUserToOrderColumns = true;
            this.gv_Info.ColumnHeadersHeight = 25;
            this.gv_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_Info});
            this.gv_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Info.Location = new System.Drawing.Point(0, 49);
            this.gv_Info.Name = "gv_Info";
            this.gv_Info.ReadOnly = true;
            this.gv_Info.RowHeadersWidth = 20;
            this.gv_Info.Size = new System.Drawing.Size(545, 294);
            this.gv_Info.TabIndex = 7;
            // 
            // cn_Info
            // 
            this.cn_Info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_Info.DataPropertyName = "Info";
            this.cn_Info.FillWeight = 80F;
            this.cn_Info.HeaderText = "Info";
            this.cn_Info.Name = "cn_Info";
            this.cn_Info.ReadOnly = true;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(191, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(55, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Date till:";
            // 
            // dt_CurDateTill
            // 
            this.dt_CurDateTill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_CurDateTill.Location = new System.Drawing.Point(259, 15);
            this.dt_CurDateTill.Name = "dt_CurDateTill";
            this.dt_CurDateTill.Size = new System.Drawing.Size(102, 20);
            this.dt_CurDateTill.TabIndex = 3;
            this.dt_CurDateTill.ValueChanged += new System.EventHandler(this.dt_CurDateTill_ValueChanged);
            // 
            // frm_ImportCurRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(545, 343);
            this.Controls.Add(this.gv_Info);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ImportCurRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download currency rates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ImportCurRate_FormClosing);
            this.Load += new System.EventHandler(this.frm_ImportCurRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Info)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.DateTimePicker dt_CurDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Download;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_Info;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.DateTimePicker dt_CurDateTill;
    }
}