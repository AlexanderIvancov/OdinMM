﻿namespace Odin.CMB_Components.ContactPersons
{
    partial class frm_ContactPerson
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
        public cmb_ContactPersons cmb_ContactPersonOne;
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
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
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
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(201, 162);
            this.kryptonHeaderGroup1.TabIndex = 3;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Contact persons";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.User_16x16;
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
            this.cn_fullname});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gv_List.GridColor = System.Drawing.Color.LightGray;
            this.gv_List.Location = new System.Drawing.Point(0, 0);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersVisible = false;
            this.gv_List.Size = new System.Drawing.Size(199, 139);
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
            // cn_fullname
            // 
            this.cn_fullname.DataPropertyName = "fullname";
            this.cn_fullname.FillWeight = 170F;
            this.cn_fullname.HeaderText = "fullname";
            this.cn_fullname.Name = "cn_fullname";
            this.cn_fullname.Width = 170;
            // 
            // frm_ContactPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 162);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ContactPerson";
            this.Text = "frm_ContactPerson";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private CombBoxGridView.ComboBoxGrid gv_List;
        private System.Windows.Forms.BindingSource bs_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_fullname;
    }
}