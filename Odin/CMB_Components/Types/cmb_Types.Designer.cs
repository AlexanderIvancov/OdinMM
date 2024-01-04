namespace Odin.CMB_Components.Types
{
    partial class cmb_Types
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
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_TreeView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_Type = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(149, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 20);
            this.btn_AdvView.TabIndex = 6;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // btn_TreeView
            // 
            this.btn_TreeView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_TreeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TreeView.Location = new System.Drawing.Point(124, 0);
            this.btn_TreeView.Name = "btn_TreeView";
            this.btn_TreeView.Size = new System.Drawing.Size(25, 20);
            this.btn_TreeView.TabIndex = 7;
            this.btn_TreeView.Values.Image = global::Odin.Global_Resourses.view_tree;
            this.btn_TreeView.Values.Text = "";
            this.btn_TreeView.Click += new System.EventHandler(this.btn_TreeView_Click);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "CA75180D396D4E47898DB3BC3339983A";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_Type);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(124, 20);
            this.kryptonPanel1.TabIndex = 8;
            // 
            // txt_Type
            // 
            this.txt_Type.AllowButtonSpecToolTips = true;
            this.txt_Type.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Type.Location = new System.Drawing.Point(0, 0);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(124, 23);
            this.txt_Type.TabIndex = 1;
            this.txt_Type.TextChanged += new System.EventHandler(this.txt_Type_TextChanged);
            this.txt_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Type_KeyPress);
            this.txt_Type.MouseEnter += new System.EventHandler(this.txt_Type_MouseEnter);
            // 
            // cmb_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_TreeView);
            this.Controls.Add(this.btn_AdvView);
            this.Name = "cmb_Types";
            this.Size = new System.Drawing.Size(174, 20);
            this.Load += new System.EventHandler(this.cmb_Types_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_TreeView;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Type;
    }
}
