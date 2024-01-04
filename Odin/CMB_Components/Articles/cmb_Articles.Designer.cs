namespace Odin.CMB_Components.Articles
{
    partial class cmb_Articles
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
            this.btn_Image = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.txt_Article = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_Id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AdvView.Location = new System.Drawing.Point(240, 0);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(25, 20);
            this.btn_AdvView.TabIndex = 9;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.arrow_down_blue;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // btn_Image
            // 
            this.btn_Image.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_Image.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Image.Location = new System.Drawing.Point(215, 0);
            this.btn_Image.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(25, 20);
            this.btn_Image.TabIndex = 11;
            this.btn_Image.Values.Image = global::Odin.Global_Resourses.ObjectSmall1;
            this.btn_Image.Values.Text = "";
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
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
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.txt_Article);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.txt_Id);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(215, 20);
            this.kryptonSplitContainer1.SplitterDistance = 146;
            this.kryptonSplitContainer1.SplitterWidth = 3;
            this.kryptonSplitContainer1.TabIndex = 13;
            // 
            // txt_Article
            // 
            this.txt_Article.AllowButtonSpecToolTips = true;
            this.txt_Article.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_Article.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Article.Location = new System.Drawing.Point(0, 0);
            this.txt_Article.Name = "txt_Article";
            this.txt_Article.Size = new System.Drawing.Size(146, 23);
            this.txt_Article.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_Article.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txt_Article.TabIndex = 3;
            this.txt_Article.TextChanged += new System.EventHandler(this.txt_Article_TextChanged);
            this.txt_Article.DoubleClick += new System.EventHandler(this.txt_Article_DoubleClick);
            this.txt_Article.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Article_KeyDown);
            this.txt_Article.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Article_KeyPress);
            this.txt_Article.Validated += new System.EventHandler(this.txt_Article_Validated);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.AllowButtonSpecToolTips = true;
            this.txt_Id.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Id.Location = new System.Drawing.Point(0, 0);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(66, 23);
            this.txt_Id.TabIndex = 2;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            this.txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Id_KeyDown);
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            this.txt_Id.Validated += new System.EventHandler(this.txt_Id_Validated);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "45DE44E33D694823B4A79EE0133E159F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // cmb_Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.btn_AdvView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "cmb_Articles";
            this.Size = new System.Drawing.Size(265, 20);
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

        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Image;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Article;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Id;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}
