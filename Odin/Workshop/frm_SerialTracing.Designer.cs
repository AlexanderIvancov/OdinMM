namespace Odin.Workshop
{
    partial class frm_SerialTracing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SerialTracing));
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.txt_Result = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_DeleteDocs = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Copy = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_AdvView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Order = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_Progess = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pb_Progress = new System.Windows.Forms.ProgressBar();
            this.btn_Download = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chk_FQC = new System.Windows.Forms.CheckBox();
            this.chk_QCTHT = new System.Windows.Forms.CheckBox();
            this.chk_QCSMT = new System.Windows.Forms.CheckBox();
            this.chk_Replace = new System.Windows.Forms.CheckBox();
            this.btn_AddAnalog = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmb_BatchPDA1 = new Odin.CMB_Components.Batches.cmb_BatchPDA();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Oper
            // 
            this.txt_Oper.Location = new System.Drawing.Point(102, 495);
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.Size = new System.Drawing.Size(121, 91);
            this.txt_Oper.TabIndex = 231;
            this.txt_Oper.Text = "";
            this.txt_Oper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Oper_KeyPress);
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.txt_Result);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel2);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1452, 702);
            this.kryptonHeaderGroup1.TabIndex = 232;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Production labels tracing";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = global::Odin.Global_Resourses.barcode_2d;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "Production labels tracing";
            // 
            // txt_Result
            // 
            this.txt_Result.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_DeleteDocs,
            this.btn_Copy});
            this.txt_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Result.Location = new System.Drawing.Point(0, 183);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.Size = new System.Drawing.Size(1450, 466);
            this.txt_Result.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Result.TabIndex = 238;
            this.txt_Result.Click += new System.EventHandler(this.txt_Result_Click);
            this.txt_Result.Enter += new System.EventHandler(this.txt_Result_Enter);
            // 
            // btn_DeleteDocs
            // 
            this.btn_DeleteDocs.Image = global::Odin.Global_Resourses.delete2__2_;
            this.btn_DeleteDocs.UniqueName = "5F57787DA6054DDA7F98467641907D48";
            this.btn_DeleteDocs.Click += new System.EventHandler(this.btn_DeleteDocs_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Image = global::Odin.Global_Resourses.Copy_32x32;
            this.btn_Copy.UniqueName = "17B435C8E25743D5FAB8702948EB4E5F";
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btn_AddAnalog);
            this.kryptonPanel2.Controls.Add(this.btn_Close);
            this.kryptonPanel2.Controls.Add(this.btn_AdvView);
            this.kryptonPanel2.Controls.Add(this.lbl_Order);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.cmb_BatchPDA1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 100);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.kryptonPanel2.Size = new System.Drawing.Size(1450, 83);
            this.kryptonPanel2.TabIndex = 237;
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.Location = new System.Drawing.Point(1187, 10);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Close.Size = new System.Drawing.Size(243, 63);
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.TabIndex = 241;
            this.btn_Close.Values.Image = global::Odin.Global_Resourses.exit;
            this.btn_Close.Values.Text = "Exit";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_AdvView
            // 
            this.btn_AdvView.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AdvView.Location = new System.Drawing.Point(463, 22);
            this.btn_AdvView.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdvView.Name = "btn_AdvView";
            this.btn_AdvView.Size = new System.Drawing.Size(40, 41);
            this.btn_AdvView.TabIndex = 240;
            this.btn_AdvView.Values.Image = global::Odin.Global_Resourses.clear;
            this.btn_AdvView.Values.Text = "";
            this.btn_AdvView.Click += new System.EventHandler(this.btn_AdvView_Click);
            // 
            // lbl_Order
            // 
            this.lbl_Order.Location = new System.Drawing.Point(520, 22);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(360, 43);
            this.lbl_Order.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Order.StateNormal.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Order.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.lbl_Order.StateNormal.ShortText.Color2 = System.Drawing.Color.Red;
            this.lbl_Order.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Order.TabIndex = 239;
            this.lbl_Order.Values.Text = "SCAN BATCH LABEL!";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(111, 43);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateNormal.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 238;
            this.kryptonLabel1.Values.Text = "Batch:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.chk_FQC);
            this.kryptonPanel1.Controls.Add(this.chk_QCTHT);
            this.kryptonPanel1.Controls.Add(this.chk_QCSMT);
            this.kryptonPanel1.Controls.Add(this.chk_Replace);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.kryptonPanel1.Size = new System.Drawing.Size(1450, 100);
            this.kryptonPanel1.TabIndex = 227;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.lbl_Progess);
            this.kryptonPanel3.Controls.Add(this.pb_Progress);
            this.kryptonPanel3.Controls.Add(this.btn_Download);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel3.Location = new System.Drawing.Point(639, 20);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Padding = new System.Windows.Forms.Padding(2);
            this.kryptonPanel3.Size = new System.Drawing.Size(548, 60);
            this.kryptonPanel3.TabIndex = 242;
            // 
            // lbl_Progess
            // 
            this.lbl_Progess.Location = new System.Drawing.Point(94, 5);
            this.lbl_Progess.Name = "lbl_Progess";
            this.lbl_Progess.Size = new System.Drawing.Size(91, 20);
            this.lbl_Progess.TabIndex = 244;
            this.lbl_Progess.Values.Text = "Download files";
            // 
            // pb_Progress
            // 
            this.pb_Progress.Location = new System.Drawing.Point(94, 31);
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(448, 23);
            this.pb_Progress.TabIndex = 243;
            // 
            // btn_Download
            // 
            this.btn_Download.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_Download.Location = new System.Drawing.Point(13, 0);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(63, 60);
            this.btn_Download.TabIndex = 242;
            this.btn_Download.Values.Image = global::Odin.Global_Resourses.download_manager_7535;
            this.btn_Download.Values.Text = "";
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // chk_FQC
            // 
            this.chk_FQC.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_FQC.BackColor = System.Drawing.Color.LightGreen;
            this.chk_FQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_FQC.Location = new System.Drawing.Point(509, 20);
            this.chk_FQC.Name = "chk_FQC";
            this.chk_FQC.Size = new System.Drawing.Size(243, 60);
            this.chk_FQC.TabIndex = 230;
            this.chk_FQC.Text = "FQC";
            this.chk_FQC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_FQC.UseVisualStyleBackColor = false;
            this.chk_FQC.CheckedChanged += new System.EventHandler(this.chk_FQC_CheckedChanged);
            // 
            // chk_QCTHT
            // 
            this.chk_QCTHT.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_QCTHT.BackColor = System.Drawing.Color.LightGreen;
            this.chk_QCTHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_QCTHT.Location = new System.Drawing.Point(260, 20);
            this.chk_QCTHT.Name = "chk_QCTHT";
            this.chk_QCTHT.Size = new System.Drawing.Size(243, 60);
            this.chk_QCTHT.TabIndex = 229;
            this.chk_QCTHT.Text = "QC THT";
            this.chk_QCTHT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_QCTHT.UseVisualStyleBackColor = false;
            this.chk_QCTHT.CheckedChanged += new System.EventHandler(this.chk_QCTHT_CheckedChanged);
            // 
            // chk_QCSMT
            // 
            this.chk_QCSMT.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_QCSMT.BackColor = System.Drawing.Color.LightPink;
            this.chk_QCSMT.Checked = true;
            this.chk_QCSMT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_QCSMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_QCSMT.Location = new System.Drawing.Point(11, 20);
            this.chk_QCSMT.Name = "chk_QCSMT";
            this.chk_QCSMT.Size = new System.Drawing.Size(243, 60);
            this.chk_QCSMT.TabIndex = 228;
            this.chk_QCSMT.Text = "QC SMT";
            this.chk_QCSMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_QCSMT.UseVisualStyleBackColor = false;
            this.chk_QCSMT.CheckedChanged += new System.EventHandler(this.chk_QCSMT_CheckedChanged);
            // 
            // chk_Replace
            // 
            this.chk_Replace.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_Replace.BackColor = System.Drawing.Color.LightGreen;
            this.chk_Replace.Dock = System.Windows.Forms.DockStyle.Right;
            this.chk_Replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_Replace.Location = new System.Drawing.Point(1187, 20);
            this.chk_Replace.Name = "chk_Replace";
            this.chk_Replace.Size = new System.Drawing.Size(243, 60);
            this.chk_Replace.TabIndex = 227;
            this.chk_Replace.Text = "Replace serial";
            this.chk_Replace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_Replace.UseVisualStyleBackColor = false;
            this.chk_Replace.CheckedChanged += new System.EventHandler(this.chk_Replace_CheckedChanged);
            // 
            // btn_AddAnalog
            // 
            this.btn_AddAnalog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AddAnalog.Location = new System.Drawing.Point(944, 10);
            this.btn_AddAnalog.Name = "btn_AddAnalog";
            this.btn_AddAnalog.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_AddAnalog.Size = new System.Drawing.Size(243, 63);
            this.btn_AddAnalog.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddAnalog.TabIndex = 242;
            this.btn_AddAnalog.Values.Image = global::Odin.Global_Resourses.agt_reload24x24;
            this.btn_AddAnalog.Values.Text = "Add analog serial";
            this.btn_AddAnalog.Click += new System.EventHandler(this.btn_AddAnalog_Click);
            // 
            // cmb_BatchPDA1
            // 
            this.cmb_BatchPDA1.Article = null;
            this.cmb_BatchPDA1.ArticleId = 0;
            this.cmb_BatchPDA1.Batch = "";
            this.cmb_BatchPDA1.BatchId = 0;
            this.cmb_BatchPDA1.ClearButtonVisible = 0;
            this.cmb_BatchPDA1.COId = 0;
            this.cmb_BatchPDA1.ConfOrder = null;
            this.cmb_BatchPDA1.CountID = 0;
            this.cmb_BatchPDA1.Customer = null;
            this.cmb_BatchPDA1.IsActive = 0;
            this.cmb_BatchPDA1.Location = new System.Drawing.Point(134, 22);
            this.cmb_BatchPDA1.Name = "cmb_BatchPDA1";
            this.cmb_BatchPDA1.ParentBatchId = 0;
            this.cmb_BatchPDA1.Qty = 0D;
            this.cmb_BatchPDA1.QtyLabels = 0;
            this.cmb_BatchPDA1.ResDate = null;
            this.cmb_BatchPDA1.SecName = null;
            this.cmb_BatchPDA1.Size = new System.Drawing.Size(314, 41);
            this.cmb_BatchPDA1.StencilRequired = 0;
            this.cmb_BatchPDA1.TabIndex = 237;
            this.cmb_BatchPDA1.TextBoxEnabled = 0;
            this.cmb_BatchPDA1.Unit = "";
            this.cmb_BatchPDA1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadPDAEventHandler(this.cmb_BatchPDA1_BatchChanged);
            this.cmb_BatchPDA1.BatchKeyPressed += new Odin.CMB_Components.Batches.BatchHeadPDAKeyPressedEventHandler(this.cmb_BatchPDA1_BatchKeyPressed);
            // 
            // frm_SerialTracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 702);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.txt_Oper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_SerialTracing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial number tracing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frm_SerialTracing_Activated);
            this.Load += new System.EventHandler(this.frm_SerialTracing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            this.kryptonHeaderGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Oper;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.CheckBox chk_Replace;
        private System.Windows.Forms.CheckBox chk_FQC;
        private System.Windows.Forms.CheckBox chk_QCTHT;
        private System.Windows.Forms.CheckBox chk_QCSMT;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Result;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_DeleteDocs;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Order;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CMB_Components.Batches.cmb_BatchPDA cmb_BatchPDA1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AdvView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Download;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Progess;
        private System.Windows.Forms.ProgressBar pb_Progress;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Copy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddAnalog;
    }
}