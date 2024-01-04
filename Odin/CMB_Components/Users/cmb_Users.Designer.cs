namespace Odin.CMB_Components.Users
{
    partial class cmb_Users
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
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.txt_User = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_TN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.txt_User);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.txt_TN);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(203, 20);
            this.kryptonSplitContainer1.SplitterDistance = 137;
            this.kryptonSplitContainer1.SplitterWidth = 3;
            this.kryptonSplitContainer1.TabIndex = 16;
            // 
            // txt_User
            // 
            this.txt_User.AllowButtonSpecToolTips = true;
            this.txt_User.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_User.Location = new System.Drawing.Point(0, 0);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(137, 23);
            this.txt_User.TabIndex = 3;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // txt_TN
            // 
            this.txt_TN.AllowButtonSpecToolTips = true;
            this.txt_TN.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_TN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TN.Location = new System.Drawing.Point(0, 0);
            this.txt_TN.Name = "txt_TN";
            this.txt_TN.Size = new System.Drawing.Size(63, 23);
            this.txt_TN.TabIndex = 2;
            this.txt_TN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TN_KeyPress);
            this.txt_TN.Validated += new System.EventHandler(this.txt_TN_Validated);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(203, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 20);
            this.btn_AdvView.TabIndex = 14;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // cmb_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.btn_AdvView);
            this.Name = "cmb_Users";
            this.Size = new System.Drawing.Size(228, 20);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_User;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_TN;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
    }
}
