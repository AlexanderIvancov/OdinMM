﻿namespace Odin.CMB_Components.Launches
{
    partial class frm_Launches
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
        public cmb_Launches cmb_LaunchOne;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gv_List = new CombBoxGridView.ComboBoxGrid();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_launches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_secname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn_stages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_started = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.gv_List);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(353, 221);
            this.kryptonHeaderGroup1.TabIndex = 3;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Launches";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.launch;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Select units";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToResizeRows = false;
            this.gv_List.BackgroundColor = System.Drawing.Color.White;
            this.gv_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.ColumnHeadersVisible = false;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_launches,
            this.cn_secname,
            this.sn_stages,
            this.cn_started});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gv_List.GridColor = System.Drawing.Color.LightGray;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersVisible = false;
            this.gv_List.Size = new System.Drawing.Size(351, 184);
            this.gv_List.TabIndex = 5;
            this.gv_List.TabStop = false;
            this.gv_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellDoubleClick);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.Visible = false;
            // 
            // cn_launches
            // 
            this.cn_launches.DataPropertyName = "name";
            this.cn_launches.FillWeight = 90F;
            this.cn_launches.HeaderText = "Launches";
            this.cn_launches.Name = "cn_launches";
            this.cn_launches.Width = 90;
            // 
            // cn_secname
            // 
            this.cn_secname.DataPropertyName = "secname";
            this.cn_secname.FillWeight = 130F;
            this.cn_secname.HeaderText = "2nd name";
            this.cn_secname.Name = "cn_secname";
            this.cn_secname.Width = 130;
            // 
            // sn_stages
            // 
            this.sn_stages.DataPropertyName = "stages";
            this.sn_stages.FillWeight = 110F;
            this.sn_stages.HeaderText = "stages";
            this.sn_stages.Name = "sn_stages";
            this.sn_stages.Width = 110;
            // 
            // cn_started
            // 
            this.cn_started.DataPropertyName = "isstarted";
            this.cn_started.HeaderText = "started";
            this.cn_started.Name = "cn_started";
            this.cn_started.Visible = false;
            // 
            // frm_Launches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 221);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Launches";
            this.Text = "frm_Launches";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private CombBoxGridView.ComboBoxGrid gv_List;
        private System.Windows.Forms.BindingSource bs_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_launches;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_secname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn_stages;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_started;
    }
}