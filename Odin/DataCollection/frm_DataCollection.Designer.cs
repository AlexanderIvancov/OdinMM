namespace Odin.DataCollection
{
    partial class frm_DataCollection
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

        public Main _frm_Main;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.panelmain = new System.Windows.Forms.Panel();
            this.btn_Pause = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Resume = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Finish = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_Batch = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Worker = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Clock = new Odin.CustomControls.SevenSegmentArray();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bw_Worker = new System.ComponentModel.BackgroundWorker();
            this.bw_Launch = new System.ComponentModel.BackgroundWorker();
            this.bw_WrongWorker = new System.ComponentModel.BackgroundWorker();
            this.bw_Lunch = new System.ComponentModel.BackgroundWorker();
            this.bw_WrongLaunch = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.panelmain.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Oper
            // 
            this.txt_Oper.Location = new System.Drawing.Point(593, 485);
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.Size = new System.Drawing.Size(121, 91);
            this.txt_Oper.TabIndex = 243;
            this.txt_Oper.Text = "";
            this.txt_Oper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Oper_KeyPress);
            // 
            // kryptonHeaderGroup2
            // 
            this.kryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panelmain);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel5);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel4);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel3);
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.panel1);
            this.kryptonHeaderGroup2.Size = new System.Drawing.Size(1307, 1061);
            this.kryptonHeaderGroup2.TabIndex = 244;
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = "Data collection";
            this.kryptonHeaderGroup2.ValuesPrimary.Image = global::Odin.Global_Resourses.db_update;
            this.kryptonHeaderGroup2.ValuesSecondary.Heading = "Actions";
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelmain.Controls.Add(this.btn_Pause);
            this.panelmain.Controls.Add(this.btn_Resume);
            this.panelmain.Controls.Add(this.btn_Finish);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 422);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1305, 480);
            this.panelmain.TabIndex = 240;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Enabled = false;
            this.btn_Pause.Location = new System.Drawing.Point(354, 202);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Pause.Size = new System.Drawing.Size(195, 77);
            this.btn_Pause.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Pause.TabIndex = 247;
            this.btn_Pause.Values.Image = global::Odin.Global_Resourses.pause_big;
            this.btn_Pause.Values.Text = "Pause";
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Resume
            // 
            this.btn_Resume.Enabled = false;
            this.btn_Resume.Location = new System.Drawing.Point(555, 202);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Resume.Size = new System.Drawing.Size(195, 77);
            this.btn_Resume.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Resume.TabIndex = 246;
            this.btn_Resume.Values.Image = global::Odin.Global_Resourses.play_big;
            this.btn_Resume.Values.Text = "Resume";
            this.btn_Resume.Click += new System.EventHandler(this.btn_Resume_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Enabled = false;
            this.btn_Finish.Location = new System.Drawing.Point(756, 202);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Finish.Size = new System.Drawing.Size(195, 77);
            this.btn_Finish.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Finish.TabIndex = 245;
            this.btn_Finish.Values.Image = global::Odin.Global_Resourses.Finish_big;
            this.btn_Finish.Values.Text = "Finish";
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.lbl_Batch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1305, 152);
            this.panel5.TabIndex = 239;
            // 
            // lbl_Batch
            // 
            this.lbl_Batch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Batch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Batch.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_Batch.Location = new System.Drawing.Point(0, 0);
            this.lbl_Batch.Name = "lbl_Batch";
            this.lbl_Batch.Size = new System.Drawing.Size(1305, 152);
            this.lbl_Batch.TabIndex = 2;
            this.lbl_Batch.Text = "Сканируйте запуск";
            this.lbl_Batch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.lbl_Worker);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1305, 94);
            this.panel4.TabIndex = 238;
            // 
            // lbl_Worker
            // 
            this.lbl_Worker.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Worker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Worker.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_Worker.Location = new System.Drawing.Point(0, 0);
            this.lbl_Worker.Name = "lbl_Worker";
            this.lbl_Worker.Size = new System.Drawing.Size(1305, 94);
            this.lbl_Worker.TabIndex = 1;
            this.lbl_Worker.Text = "Сканируйте свой пропуск";
            this.lbl_Worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1305, 176);
            this.panel3.TabIndex = 237;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.kryptonButton1);
            this.panel1.Controls.Add(this.lbl_Clock);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 902);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 101);
            this.panel1.TabIndex = 233;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Enabled = false;
            this.kryptonButton1.Location = new System.Drawing.Point(555, 12);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonButton1.Size = new System.Drawing.Size(195, 77);
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonButton1.TabIndex = 248;
            this.kryptonButton1.Values.Image = global::Odin.Global_Resourses.workers_refresh;
            this.kryptonButton1.Values.Text = "Pause";
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.ArrayCount = 2;
            this.lbl_Clock.ColorBackground = System.Drawing.Color.WhiteSmoke;
            this.lbl_Clock.ColorDark = System.Drawing.Color.Silver;
            this.lbl_Clock.ColorLight = System.Drawing.Color.Green;
            this.lbl_Clock.DecimalShow = true;
            this.lbl_Clock.ElementPadding = new System.Windows.Forms.Padding(4);
            this.lbl_Clock.ElementWidth = 10;
            this.lbl_Clock.ItalicFactor = 0F;
            this.lbl_Clock.Location = new System.Drawing.Point(8, 5);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(114, 91);
            this.lbl_Clock.TabIndex = 246;
            this.lbl_Clock.TabStop = false;
            this.lbl_Clock.Value = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1084, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 101);
            this.panel2.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(13, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Close.Size = new System.Drawing.Size(195, 77);
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.TabIndex = 241;
            this.btn_Close.Values.Image = global::Odin.Global_Resourses.exit;
            this.btn_Close.Values.Text = "Exit";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // bw_Worker
            // 
            this.bw_Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_Worker_DoWork);
            this.bw_Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_Worker_ProgressChanged);
            this.bw_Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_Worker_RunWorkerCompleted);
            // 
            // bw_Launch
            // 
            this.bw_Launch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_Launch_DoWork);
            this.bw_Launch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_Launch_ProgressChanged);
            this.bw_Launch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_Launch_RunWorkerCompleted);
            // 
            // bw_WrongWorker
            // 
            this.bw_WrongWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_WrongWorker_DoWork);
            this.bw_WrongWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_WrongWorker_ProgressChanged);
            this.bw_WrongWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_WrongWorker_RunWorkerCompleted);
            // 
            // bw_WrongLaunch
            // 
            this.bw_WrongLaunch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_WrongLaunch_DoWork);
            this.bw_WrongLaunch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_WrongLaunch_ProgressChanged);
            this.bw_WrongLaunch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_WrongLaunch_RunWorkerCompleted);
            // 
            // frm_DataCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 1061);
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.txt_Oper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_DataCollection";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Data collection";
            this.Text = "Data collection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frm_DataCollection_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DataCollection_FormClosing);
            this.Load += new System.EventHandler(this.frm_DataCollection_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_DataCollection_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.panelmain.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Oper;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.SevenSegmentArray lbl_Clock;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.ComponentModel.BackgroundWorker bw_Worker;
        private System.ComponentModel.BackgroundWorker bw_Launch;
        private System.Windows.Forms.Label lbl_Worker;
        private System.Windows.Forms.Label lbl_Batch;
        private System.ComponentModel.BackgroundWorker bw_WrongWorker;
        private System.Windows.Forms.Panel panelmain;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Pause;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Resume;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Finish;
        private System.ComponentModel.BackgroundWorker bw_Lunch;
        private System.ComponentModel.BackgroundWorker bw_WrongLaunch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}