namespace Odin.DataCollection
{
    partial class uc_RepairCardItem
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
            this.headerGroupCard = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.splitCard = new System.Windows.Forms.SplitContainer();
            this.gv_Dets = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_defect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_repdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_reparation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_visualcontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_validstatestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Materials = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_barticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_who = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupCard.Panel)).BeginInit();
            this.headerGroupCard.Panel.SuspendLayout();
            this.headerGroupCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCard)).BeginInit();
            this.splitCard.Panel1.SuspendLayout();
            this.splitCard.Panel2.SuspendLayout();
            this.splitCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Dets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Materials)).BeginInit();
            this.SuspendLayout();
            // 
            // headerGroupCard
            // 
            this.headerGroupCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerGroupCard.HeaderVisibleSecondary = true;
            this.headerGroupCard.Location = new System.Drawing.Point(4, 4);
            this.headerGroupCard.Name = "headerGroupCard";
            // 
            // headerGroupCard.Panel
            // 
            this.headerGroupCard.Panel.Controls.Add(this.splitCard);
            this.headerGroupCard.Panel.Padding = new System.Windows.Forms.Padding(2);
            this.headerGroupCard.Size = new System.Drawing.Size(492, 392);
            this.headerGroupCard.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.headerGroupCard.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.headerGroupCard.StateCommon.Border.Rounding = 6;
            this.headerGroupCard.StateCommon.Border.Width = 2;
            this.headerGroupCard.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.headerGroupCard.StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.headerGroupCard.TabIndex = 0;
            this.headerGroupCard.ValuesPrimary.Heading = "Card: RC-0000";
            this.headerGroupCard.ValuesPrimary.Image = global::Odin.Global_Resourses.Repair32x32;
            this.headerGroupCard.ValuesSecondary.Heading = "SN: - | Batch: -";
            // 
            // splitCard
            // 
            this.splitCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCard.Location = new System.Drawing.Point(2, 2);
            this.splitCard.Name = "splitCard";
            this.splitCard.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCard.Panel1
            // 
            this.splitCard.Panel1.Controls.Add(this.gv_Dets);
            // 
            // splitCard.Panel2
            // 
            this.splitCard.Panel2.Controls.Add(this.gv_Materials);
            this.splitCard.Size = new System.Drawing.Size(484, 318);
            this.splitCard.SplitterDistance = 165;
            this.splitCard.SplitterWidth = 6;
            this.splitCard.TabIndex = 0;
            // 
            // gv_Dets
            // 
            this.gv_Dets.AllowUserToAddRows = false;
            this.gv_Dets.AllowUserToDeleteRows = false;
            this.gv_Dets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Dets.ColumnHeadersHeight = 32;
            this.gv_Dets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_defect,
            this.cn_repdescription,
            this.cn_createdinfo,
            this.cn_reparation,
            this.cn_visualcontrol,
            this.cn_validstatestr});
            this.gv_Dets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Dets.Location = new System.Drawing.Point(0, 0);
            this.gv_Dets.MultiSelect = false;
            this.gv_Dets.Name = "gv_Dets";
            this.gv_Dets.ReadOnly = true;
            this.gv_Dets.RowHeadersVisible = false;
            this.gv_Dets.RowTemplate.Height = 36;
            this.gv_Dets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Dets.Size = new System.Drawing.Size(484, 165);
            this.gv_Dets.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular);
            this.gv_Dets.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_Dets.TabIndex = 0;
            // 
            // cn_defect
            // 
            this.cn_defect.DataPropertyName = "defect";
            this.cn_defect.FillWeight = 19F;
            this.cn_defect.HeaderText = "Defect";
            this.cn_defect.Name = "cn_defect";
            this.cn_defect.ReadOnly = true;
            // 
            // cn_repdescription
            // 
            this.cn_repdescription.DataPropertyName = "repair_description";
            this.cn_repdescription.FillWeight = 20F;
            this.cn_repdescription.HeaderText = "Action";
            this.cn_repdescription.Name = "cn_repdescription";
            this.cn_repdescription.ReadOnly = true;
            // 
            // cn_createdinfo
            // 
            this.cn_createdinfo.FillWeight = 17F;
            this.cn_createdinfo.HeaderText = "Created by/at";
            this.cn_createdinfo.Name = "cn_createdinfo";
            this.cn_createdinfo.ReadOnly = true;
            // 
            // cn_reparation
            // 
            this.cn_reparation.FillWeight = 18F;
            this.cn_reparation.HeaderText = "Reparation";
            this.cn_reparation.Name = "cn_reparation";
            this.cn_reparation.ReadOnly = true;
            // 
            // cn_visualcontrol
            // 
            this.cn_visualcontrol.FillWeight = 18F;
            this.cn_visualcontrol.HeaderText = "Visual Control";
            this.cn_visualcontrol.Name = "cn_visualcontrol";
            this.cn_visualcontrol.ReadOnly = true;
            // 
            // cn_validstatestr
            // 
            this.cn_validstatestr.DataPropertyName = "validstatestr";
            this.cn_validstatestr.FillWeight = 8F;
            this.cn_validstatestr.HeaderText = "Valid";
            this.cn_validstatestr.Name = "cn_validstatestr";
            this.cn_validstatestr.ReadOnly = true;
            // 
            // gv_Materials
            // 
            this.gv_Materials.AllowUserToAddRows = false;
            this.gv_Materials.AllowUserToDeleteRows = false;
            this.gv_Materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Materials.ColumnHeadersHeight = 30;
            this.gv_Materials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_barticle,
            this.cn_label,
            this.cn_who});
            this.gv_Materials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Materials.Location = new System.Drawing.Point(0, 0);
            this.gv_Materials.MultiSelect = false;
            this.gv_Materials.Name = "gv_Materials";
            this.gv_Materials.ReadOnly = true;
            this.gv_Materials.RowHeadersVisible = false;
            this.gv_Materials.RowTemplate.Height = 30;
            this.gv_Materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Materials.Size = new System.Drawing.Size(484, 147);
            this.gv_Materials.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gv_Materials.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.gv_Materials.TabIndex = 1;
            // 
            // cn_barticle
            // 
            this.cn_barticle.DataPropertyName = "article";
            this.cn_barticle.FillWeight = 45F;
            this.cn_barticle.HeaderText = "Mat. Article";
            this.cn_barticle.Name = "cn_barticle";
            this.cn_barticle.ReadOnly = true;
            // 
            // cn_label
            // 
            this.cn_label.DataPropertyName = "label";
            this.cn_label.FillWeight = 25F;
            this.cn_label.HeaderText = "Label";
            this.cn_label.Name = "cn_label";
            this.cn_label.ReadOnly = true;
            // 
            // cn_who
            // 
            this.cn_who.DataPropertyName = "who";
            this.cn_who.FillWeight = 30F;
            this.cn_who.HeaderText = "Worker";
            this.cn_who.Name = "cn_who";
            this.cn_who.ReadOnly = true;
            // 
            // uc_RepairCardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerGroupCard);
            this.Name = "uc_RepairCardItem";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupCard.Panel)).EndInit();
            this.headerGroupCard.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupCard)).EndInit();
            this.headerGroupCard.ResumeLayout(false);
            this.splitCard.Panel1.ResumeLayout(false);
            this.splitCard.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCard)).EndInit();
            this.splitCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Dets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Materials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup headerGroupCard;
        private System.Windows.Forms.SplitContainer splitCard;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Dets;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_Materials;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_defect;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_repdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_reparation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_visualcontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_validstatestr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_barticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_who;
    }
}