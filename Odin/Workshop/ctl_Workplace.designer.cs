namespace Odin.Workshop
{
    partial class ctl_Workplace
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
            this.txt_Article = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_CustArticle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmb_Launches1 = new Odin.CMB_Components.Launches.cmb_Launches();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Launch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_Workplace = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_Article);
            this.kryptonPanel1.Controls.Add(this.txt_CustArticle);
            this.kryptonPanel1.Controls.Add(this.cmb_Launches1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.lbl_Launch);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(299, 175);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // txt_Article
            // 
            this.txt_Article.AllowButtonSpecToolTips = true;
            this.txt_Article.Enabled = false;
            this.txt_Article.Location = new System.Drawing.Point(85, 89);
            this.txt_Article.Name = "txt_Article";
            this.txt_Article.Size = new System.Drawing.Size(150, 23);
            this.txt_Article.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Article.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.txt_Article.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Article.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Article.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Article.TabIndex = 246;
            // 
            // txt_CustArticle
            // 
            this.txt_CustArticle.AllowButtonSpecToolTips = true;
            this.txt_CustArticle.Enabled = false;
            this.txt_CustArticle.Location = new System.Drawing.Point(85, 118);
            this.txt_CustArticle.Name = "txt_CustArticle";
            this.txt_CustArticle.Size = new System.Drawing.Size(209, 23);
            this.txt_CustArticle.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_CustArticle.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.txt_CustArticle.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_CustArticle.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_CustArticle.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustArticle.TabIndex = 245;
            // 
            // cmb_Launches1
            // 
            this.cmb_Launches1.Article = "";
            this.cmb_Launches1.ArticleId = 0;
            this.cmb_Launches1.Batch = "";
            this.cmb_Launches1.BatchId = 0;
            this.cmb_Launches1.ConfOrder = "";
            this.cmb_Launches1.Customer = "";
            this.cmb_Launches1.EndDate = "";
            this.cmb_Launches1.IsActive = 0;
            this.cmb_Launches1.Launch = "";
            this.cmb_Launches1.LaunchId = 0;
            this.cmb_Launches1.Location = new System.Drawing.Point(85, 63);
            this.cmb_Launches1.Name = "cmb_Launches1";
            this.cmb_Launches1.ParentBatchId = 0;
            this.cmb_Launches1.Qty = 0D;
            this.cmb_Launches1.SecName = null;
            this.cmb_Launches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Launches1.StageId = 0;
            this.cmb_Launches1.StartDate = null;
            this.cmb_Launches1.TabIndex = 244;
            this.cmb_Launches1.LaunchChanged += new Odin.CMB_Components.Launches.LaunchHeadEventHandler(this.cmb_Launches1_LaunchChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 119);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel2.TabIndex = 243;
            this.kryptonLabel2.Values.Text = "Cust. article";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 90);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel1.TabIndex = 242;
            this.kryptonLabel1.Values.Text = "Article";
            // 
            // lbl_Launch
            // 
            this.lbl_Launch.Location = new System.Drawing.Point(11, 63);
            this.lbl_Launch.Name = "lbl_Launch";
            this.lbl_Launch.Size = new System.Drawing.Size(49, 20);
            this.lbl_Launch.TabIndex = 241;
            this.lbl_Launch.Values.Text = "Launch";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lbl_Workplace);
            this.kryptonPanel2.Controls.Add(this.btn_Clear);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(2, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderRowCustom1;
            this.kryptonPanel2.Size = new System.Drawing.Size(295, 44);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // lbl_Workplace
            // 
            this.lbl_Workplace.AutoSize = false;
            this.lbl_Workplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Workplace.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lbl_Workplace.Location = new System.Drawing.Point(47, 0);
            this.lbl_Workplace.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Workplace.Name = "lbl_Workplace";
            this.lbl_Workplace.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lbl_Workplace.Size = new System.Drawing.Size(248, 44);
            this.lbl_Workplace.StateCommon.LongText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Workplace.StateNormal.LongText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Workplace.StateNormal.ShortText.Color1 = System.Drawing.Color.Yellow;
            this.lbl_Workplace.StateNormal.ShortText.Color2 = System.Drawing.Color.Green;
            this.lbl_Workplace.StateNormal.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.lbl_Workplace.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Workplace.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbl_Workplace.TabIndex = 7;
            this.lbl_Workplace.UseMnemonic = false;
            this.lbl_Workplace.Values.Text = "Workplace";
            // 
            // btn_Clear
            // 
            this.btn_Clear.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Clear.Location = new System.Drawing.Point(0, 0);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(47, 44);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Values.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.Values.Text = "";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // ctl_Workplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_Workplace";
            this.Size = new System.Drawing.Size(299, 175);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Workplace;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Launch;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Article;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustArticle;
        public CMB_Components.Launches.cmb_Launches cmb_Launches1;
    }
}
