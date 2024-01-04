namespace Odin.Workshop
{
    partial class ctl_LaunchProcess
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
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rb_Valkas2B = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Valkas2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            this.panel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Refresh);
            this.kryptonPanel1.Controls.Add(this.rb_Valkas2B);
            this.kryptonPanel1.Controls.Add(this.rb_Valkas2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(1800, 47);
            this.kryptonPanel1.TabIndex = 5;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.Location = new System.Drawing.Point(231, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(38, 37);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // rb_Valkas2B
            // 
            this.rb_Valkas2B.Location = new System.Drawing.Point(335, 12);
            this.rb_Valkas2B.Name = "rb_Valkas2B";
            this.rb_Valkas2B.Size = new System.Drawing.Size(74, 20);
            this.rb_Valkas2B.TabIndex = 3;
            this.rb_Valkas2B.Values.Text = "Valkas 2B";
            this.rb_Valkas2B.Visible = false;
            this.rb_Valkas2B.CheckedChanged += new System.EventHandler(this.rb_Valkas2B_CheckedChanged);
            // 
            // rb_Valkas2
            // 
            this.rb_Valkas2.Checked = true;
            this.rb_Valkas2.Location = new System.Drawing.Point(469, 12);
            this.rb_Valkas2.Name = "rb_Valkas2";
            this.rb_Valkas2.Size = new System.Drawing.Size(67, 20);
            this.rb_Valkas2.TabIndex = 2;
            this.rb_Valkas2.Values.Text = "Valkas 2";
            this.rb_Valkas2.Visible = false;
            this.rb_Valkas2.CheckedChanged += new System.EventHandler(this.rb_Valkas2_CheckedChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Batch:";
            // 
            // cmb_Batches1
            // 
            this.cmb_Batches1.ActiveOnly = 0;
            this.cmb_Batches1.Article = null;
            this.cmb_Batches1.ArticleId = 0;
            this.cmb_Batches1.Batch = "";
            this.cmb_Batches1.BatchId = 0;
            this.cmb_Batches1.Comments = "";
            this.cmb_Batches1.ConfOrder = "";
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.CustArticle = "";
            this.cmb_Batches1.Customer = "";
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.IsGroup = 0;
            this.cmb_Batches1.IsProject = 0;
            this.cmb_Batches1.IsQuote = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(75, 12);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Batches1.Stages = "";
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 0;
            this.cmb_Batches1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches1_BatchChanged);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 47);
            this.panel.Name = "panel";
            this.panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.panel.Size = new System.Drawing.Size(1800, 278);
            this.panel.TabIndex = 6;
            // 
            // ctl_LaunchProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_LaunchProcess";
            this.Size = new System.Drawing.Size(1800, 325);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ctl_LaunchProcess_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2B;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public CMB_Components.Batches.cmb_Batches cmb_Batches1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
    }
}
