namespace Odin.CMB_Components.Places
{
    partial class cmb_Places
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
            this.btn_Lock = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_TreeView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_Place = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Lock
            // 
            this.btn_Lock.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.btn_Lock.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Lock.Location = new System.Drawing.Point(212, 0);
            this.btn_Lock.Name = "btn_Lock";
            this.btn_Lock.Size = new System.Drawing.Size(22, 20);
            this.btn_Lock.TabIndex = 0;
            this.btn_Lock.Values.Image = global::Odin.Global_Resourses.lock_open;
            this.btn_Lock.Values.Text = "";
            this.btn_Lock.Click += new System.EventHandler(this.btn_Lock_Click);
            // 
            // btn_TreeView
            // 
            this.btn_TreeView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_TreeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TreeView.Location = new System.Drawing.Point(187, 0);
            this.btn_TreeView.Name = "btn_TreeView";
            this.btn_TreeView.Size = new System.Drawing.Size(25, 20);
            this.btn_TreeView.TabIndex = 14;
            this.btn_TreeView.Values.Image = global::Odin.Global_Resourses.view_tree;
            this.btn_TreeView.Values.Text = "";
            this.btn_TreeView.Click += new System.EventHandler(this.btn_TreeView_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_Place);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(187, 20);
            this.kryptonPanel1.TabIndex = 16;
            // 
            // txt_Place
            // 
            this.txt_Place.AllowButtonSpecToolTips = true;
            this.txt_Place.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Place.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Place.Location = new System.Drawing.Point(0, 0);
            this.txt_Place.Name = "txt_Place";
            this.txt_Place.Size = new System.Drawing.Size(187, 23);
            this.txt_Place.TabIndex = 1;
            this.txt_Place.TextChanged += new System.EventHandler(this.txt_Place_TextChanged);
            this.txt_Place.Validated += new System.EventHandler(this.txt_Place_Validated);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "CA75180D396D4E47898DB3BC3339983A";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // cmb_Places
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_TreeView);
            this.Controls.Add(this.btn_Lock);
            this.Name = "cmb_Places";
            this.Size = new System.Drawing.Size(234, 20);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Lock;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_TreeView;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Place;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}
