namespace Odin.Tools
{
    partial class frm_Find
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Find));
            this.bw_Find = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Find = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Search = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rb_Whole = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Any = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Start = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.cmb_LookIn = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LookIn)).BeginInit();
            this.SuspendLayout();
            // 
            // bw_Find
            // 
            this.bw_Find.WorkerSupportsCancellation = true;
            this.bw_Find.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_Find_DoWork);
            this.bw_Find.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_Find_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(253, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Status
            // 
            this.lbl_Status.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(43, 17);
            this.lbl_Status.Text = "Ready";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Maximum = 240;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(149, 203);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(90, 38);
            this.btn_Find.TabIndex = 25;
            this.btn_Find.Values.Image = global::Odin.Global_Resourses.Find_24x24;
            this.btn_Find.Values.Text = "Find";
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Search.Location = new System.Drawing.Point(88, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(154, 20);
            this.txt_Search.TabIndex = 26;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "342E6DBC3D9F439A97B2F7E7C264DEF8";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel1.TabIndex = 27;
            this.kryptonLabel1.Values.Text = "Find what";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(18, 31);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel2.TabIndex = 28;
            this.kryptonLabel2.Values.Text = "Look in";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(15, 78);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Whole);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Any);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Start);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(227, 119);
            this.kryptonGroupBox1.TabIndex = 29;
            this.kryptonGroupBox1.Values.Heading = "Find options";
            // 
            // rb_Whole
            // 
            this.rb_Whole.Location = new System.Drawing.Point(3, 66);
            this.rb_Whole.Name = "rb_Whole";
            this.rb_Whole.Size = new System.Drawing.Size(58, 20);
            this.rb_Whole.TabIndex = 2;
            this.rb_Whole.Values.Text = "Whole";
            this.rb_Whole.CheckedChanged += new System.EventHandler(this.rb_Whole_CheckedChanged);
            // 
            // rb_Any
            // 
            this.rb_Any.Location = new System.Drawing.Point(4, 40);
            this.rb_Any.Name = "rb_Any";
            this.rb_Any.Size = new System.Drawing.Size(110, 20);
            this.rb_Any.TabIndex = 1;
            this.rb_Any.Values.Text = "Any part of field";
            this.rb_Any.CheckedChanged += new System.EventHandler(this.rb_Any_CheckedChanged);
            // 
            // rb_Start
            // 
            this.rb_Start.Checked = true;
            this.rb_Start.Location = new System.Drawing.Point(4, 14);
            this.rb_Start.Name = "rb_Start";
            this.rb_Start.Size = new System.Drawing.Size(90, 20);
            this.rb_Start.TabIndex = 0;
            this.rb_Start.Values.Text = "Start of field";
            this.rb_Start.CheckedChanged += new System.EventHandler(this.rb_Start_CheckedChanged);
            // 
            // cmb_LookIn
            // 
            this.cmb_LookIn.DropDownWidth = 182;
            this.cmb_LookIn.Location = new System.Drawing.Point(18, 54);
            this.cmb_LookIn.Name = "cmb_LookIn";
            this.cmb_LookIn.Size = new System.Drawing.Size(224, 21);
            this.cmb_LookIn.TabIndex = 30;
            // 
            // frm_Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(253, 271);
            this.Controls.Add(this.cmb_LookIn);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Find";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find ";
            this.Load += new System.EventHandler(this.frm_Find_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LookIn)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bw_Find;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Find;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Search;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Whole;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Any;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Start;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_LookIn;
    }
}