﻿namespace Odin.CMB_Components.Quotations
{
    partial class cmb_Quotations
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_Quotation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_AddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_Quotation);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(106, 20);
            this.kryptonPanel1.TabIndex = 23;
            // 
            // txt_Quotation
            // 
            this.txt_Quotation.AllowButtonSpecToolTips = true;
            this.txt_Quotation.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Quotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Quotation.Location = new System.Drawing.Point(0, 0);
            this.txt_Quotation.Name = "txt_Quotation";
            this.txt_Quotation.Size = new System.Drawing.Size(106, 20);
            this.txt_Quotation.TabIndex = 17;
            this.txt_Quotation.TextChanged += new System.EventHandler(this.txt_Quotation_TextChanged);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AddNew.Location = new System.Drawing.Point(106, 0);
            this.btn_AddNew.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(25, 20);
            this.btn_AddNew.TabIndex = 22;
            this.btn_AddNew.Values.Image = global::Odin.Global_Resourses.bindingNavigatorAddNewItem_Image;
            this.btn_AddNew.Values.Text = "";
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Edit.Location = new System.Drawing.Point(131, 0);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(25, 20);
            this.btn_Edit.TabIndex = 21;
            this.btn_Edit.Values.Image = global::Odin.Global_Resourses.EditTableHS;
            this.btn_Edit.Values.Text = "";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(156, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 20);
            this.btn_AdvView.TabIndex = 20;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // cmb_Quotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AdvView);
            this.Name = "cmb_Quotations";
            this.Size = new System.Drawing.Size(181, 20);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Quotation;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddNew;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Edit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
    }
}