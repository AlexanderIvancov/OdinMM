namespace Odin.Tools
{
    partial class frm_GridViewAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GridViewAdm));
            this.dsColumns = new System.Data.DataSet();
            this.dtColumns = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.bs_Columns = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Up = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Down = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataColumn7 = new System.Data.DataColumn();
            this.cn_ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ColumnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ColumnVis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_ColumnWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ColumnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ColumnExport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dsColumns
            // 
            this.dsColumns.DataSetName = "NewDataSet";
            this.dsColumns.Tables.AddRange(new System.Data.DataTable[] {
            this.dtColumns});
            // 
            // dtColumns
            // 
            this.dtColumns.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dtColumns.TableName = "dtColumns";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "cColumnName";
            this.dataColumn1.ReadOnly = true;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "cColumnText";
            // 
            // dataColumn3
            // 
            this.dataColumn3.AllowDBNull = false;
            this.dataColumn3.ColumnName = "cColumnVis";
            this.dataColumn3.DataType = typeof(int);
            this.dataColumn3.DefaultValue = 0;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "cColumnOrder";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "cColumnId";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "cColumnWidth";
            this.dataColumn6.DataType = typeof(int);
            // 
            // bs_Columns
            // 
            this.bs_Columns.DataMember = "dtColumns";
            this.bs_Columns.DataSource = this.dsColumns;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 426);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(476, 51);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(374, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(275, 6);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 34);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btn_Up);
            this.kryptonPanel2.Controls.Add(this.btn_Down);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel2.Location = new System.Drawing.Point(422, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(54, 426);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(6, 156);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(44, 42);
            this.btn_Up.TabIndex = 14;
            this.btn_Up.Values.Image = global::Odin.Global_Resourses.go_up2;
            this.btn_Up.Values.Text = "";
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(6, 204);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(44, 42);
            this.btn_Down.TabIndex = 13;
            this.btn_Down.Values.Image = global::Odin.Global_Resourses.down2;
            this.btn_Down.Values.Text = "";
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AutoGenerateColumns = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_ColumnId,
            this.cn_ColumnName,
            this.cn_ColumnText,
            this.cn_ColumnVis,
            this.cn_ColumnWidth,
            this.cn_ColumnOrder,
            this.cn_ColumnExport});
            this.gv_List.DataSource = this.bs_Columns;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 5;
            this.gv_List.Size = new System.Drawing.Size(422, 426);
            this.gv_List.TabIndex = 281;
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "cColumnExport";
            this.dataColumn7.DataType = typeof(int);
            // 
            // cn_ColumnId
            // 
            this.cn_ColumnId.DataPropertyName = "cColumnId";
            this.cn_ColumnId.FillWeight = 90F;
            this.cn_ColumnId.HeaderText = "cColumnId";
            this.cn_ColumnId.Name = "cn_ColumnId";
            this.cn_ColumnId.Visible = false;
            this.cn_ColumnId.Width = 90;
            // 
            // cn_ColumnName
            // 
            this.cn_ColumnName.DataPropertyName = "cColumnName";
            this.cn_ColumnName.FillWeight = 60F;
            this.cn_ColumnName.HeaderText = "cColumnName";
            this.cn_ColumnName.Name = "cn_ColumnName";
            this.cn_ColumnName.ReadOnly = true;
            this.cn_ColumnName.Visible = false;
            this.cn_ColumnName.Width = 60;
            // 
            // cn_ColumnText
            // 
            this.cn_ColumnText.DataPropertyName = "cColumnText";
            this.cn_ColumnText.FillWeight = 200F;
            this.cn_ColumnText.HeaderText = "Column header";
            this.cn_ColumnText.Name = "cn_ColumnText";
            this.cn_ColumnText.Width = 200;
            // 
            // cn_ColumnVis
            // 
            this.cn_ColumnVis.DataPropertyName = "cColumnVis";
            this.cn_ColumnVis.FalseValue = "0";
            this.cn_ColumnVis.FillWeight = 50F;
            this.cn_ColumnVis.HeaderText = "Visible";
            this.cn_ColumnVis.Name = "cn_ColumnVis";
            this.cn_ColumnVis.TrueValue = "-1";
            this.cn_ColumnVis.Width = 50;
            // 
            // cn_ColumnWidth
            // 
            this.cn_ColumnWidth.DataPropertyName = "cColumnWidth";
            this.cn_ColumnWidth.HeaderText = "Width";
            this.cn_ColumnWidth.Name = "cn_ColumnWidth";
            // 
            // cn_ColumnOrder
            // 
            this.cn_ColumnOrder.DataPropertyName = "cColumnOrder";
            this.cn_ColumnOrder.HeaderText = "Index";
            this.cn_ColumnOrder.Name = "cn_ColumnOrder";
            this.cn_ColumnOrder.Visible = false;
            // 
            // cn_ColumnExport
            // 
            this.cn_ColumnExport.DataPropertyName = "cColumnExport";
            this.cn_ColumnExport.FalseValue = "0";
            this.cn_ColumnExport.FillWeight = 50F;
            this.cn_ColumnExport.HeaderText = "Export";
            this.cn_ColumnExport.Name = "cn_ColumnExport";
            this.cn_ColumnExport.TrueValue = "-1";
            this.cn_ColumnExport.Width = 50;
            // 
            // frm_GridViewAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 477);
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_GridViewAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gridview administration";
            this.Load += new System.EventHandler(this.frm_GridViewAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dsColumns;
        private System.Data.DataTable dtColumns;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.BindingSource bs_Columns;
        private System.Data.DataColumn dataColumn6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Up;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Down;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ColumnText;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_ColumnVis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ColumnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ColumnOrder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cn_ColumnExport;
    }
}