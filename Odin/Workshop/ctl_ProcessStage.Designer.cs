namespace Odin.Workshop
{
    partial class ctl_ProcessStage
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
            this.btn_Freeze = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Freezed = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_InProc = new Owf.Controls.NumericTetxBox();
            this.txt_Prev = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Stage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_AddProcess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_DeleteProcess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Freeze);
            this.kryptonPanel1.Controls.Add(this.txt_Freezed);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.txt_InProc);
            this.kryptonPanel1.Controls.Add(this.txt_Prev);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.lbl_Stage);
            this.kryptonPanel1.Controls.Add(this.btn_AddProcess);
            this.kryptonPanel1.Controls.Add(this.btn_DeleteProcess);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(170, 276);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btn_Freeze
            // 
            this.btn_Freeze.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btn_Freeze.Location = new System.Drawing.Point(5, 209);
            this.btn_Freeze.Name = "btn_Freeze";
            this.btn_Freeze.Size = new System.Drawing.Size(78, 60);
            this.btn_Freeze.TabIndex = 12;
            this.btn_Freeze.Values.Image = global::Odin.Global_Resourses.snowflake48x48;
            this.btn_Freeze.Values.Text = "";
            this.btn_Freeze.Click += new System.EventHandler(this.btn_Freeze_Click);
            // 
            // txt_Freezed
            // 
            this.txt_Freezed.AllowDecimalSeparator = false;
            this.txt_Freezed.AllowSpace = false;
            this.txt_Freezed.Location = new System.Drawing.Point(87, 242);
            this.txt_Freezed.Name = "txt_Freezed";
            this.txt_Freezed.Size = new System.Drawing.Size(78, 27);
            this.txt_Freezed.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_Freezed.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Freezed.TabIndex = 11;
            this.txt_Freezed.Text = "0";
            this.txt_Freezed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(101, 216);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel3.TabIndex = 10;
            this.kryptonLabel3.Values.Text = "Freezed";
            // 
            // txt_InProc
            // 
            this.txt_InProc.AllowDecimalSeparator = false;
            this.txt_InProc.AllowSpace = false;
            this.txt_InProc.Location = new System.Drawing.Point(87, 92);
            this.txt_InProc.Name = "txt_InProc";
            this.txt_InProc.Size = new System.Drawing.Size(78, 27);
            this.txt_InProc.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txt_InProc.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_InProc.TabIndex = 9;
            this.txt_InProc.Text = "0";
            this.txt_InProc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_InProc.Validated += new System.EventHandler(this.txt_InProc_Validated);
            // 
            // txt_Prev
            // 
            this.txt_Prev.AllowDecimalSeparator = false;
            this.txt_Prev.AllowSpace = false;
            this.txt_Prev.Location = new System.Drawing.Point(5, 92);
            this.txt_Prev.Name = "txt_Prev";
            this.txt_Prev.Size = new System.Drawing.Size(78, 27);
            this.txt_Prev.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Prev.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Prev.TabIndex = 8;
            this.txt_Prev.Text = "0";
            this.txt_Prev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Prev.Validated += new System.EventHandler(this.txt_Prev_Validated);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(88, 62);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "In process";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 62);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "On previous";
            // 
            // lbl_Stage
            // 
            this.lbl_Stage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Stage.AutoSize = false;
            this.lbl_Stage.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lbl_Stage.Location = new System.Drawing.Point(0, 0);
            this.lbl_Stage.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Stage.Name = "lbl_Stage";
            this.lbl_Stage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lbl_Stage.Size = new System.Drawing.Size(170, 59);
            this.lbl_Stage.StateCommon.LongText.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Stage.StateNormal.LongText.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Stage.StateNormal.ShortText.Color1 = System.Drawing.Color.Yellow;
            this.lbl_Stage.StateNormal.ShortText.Color2 = System.Drawing.Color.Green;
            this.lbl_Stage.StateNormal.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.lbl_Stage.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Stage.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbl_Stage.TabIndex = 5;
            this.lbl_Stage.UseMnemonic = false;
            this.lbl_Stage.Values.Text = "SMT";
            // 
            // btn_AddProcess
            // 
            this.btn_AddProcess.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btn_AddProcess.Location = new System.Drawing.Point(5, 125);
            this.btn_AddProcess.Name = "btn_AddProcess";
            this.btn_AddProcess.Size = new System.Drawing.Size(78, 78);
            this.btn_AddProcess.TabIndex = 4;
            this.btn_AddProcess.Values.Image = global::Odin.Global_Resourses.Assembling_48x48;
            this.btn_AddProcess.Values.Text = "";
            this.btn_AddProcess.Click += new System.EventHandler(this.btn_AddProcess_Click);
            // 
            // btn_DeleteProcess
            // 
            this.btn_DeleteProcess.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btn_DeleteProcess.Location = new System.Drawing.Point(87, 125);
            this.btn_DeleteProcess.Name = "btn_DeleteProcess";
            this.btn_DeleteProcess.Size = new System.Drawing.Size(78, 78);
            this.btn_DeleteProcess.TabIndex = 3;
            this.btn_DeleteProcess.Values.Image = global::Odin.Global_Resourses.Delete1;
            this.btn_DeleteProcess.Values.Text = "";
            this.btn_DeleteProcess.Click += new System.EventHandler(this.btn_DeleteProcess_Click);
            // 
            // ctl_ProcessStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_ProcessStage";
            this.Size = new System.Drawing.Size(170, 276);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Stage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_DeleteProcess;
        private Owf.Controls.NumericTetxBox txt_InProc;
        private Owf.Controls.NumericTetxBox txt_Prev;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Freeze;
        private Owf.Controls.NumericTetxBox txt_Freezed;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}
