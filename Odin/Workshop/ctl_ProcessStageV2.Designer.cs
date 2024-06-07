namespace Odin.Workshop
{
    partial class ctl_ProcessStageV2
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
            this.lbl_QtyOut = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyOut = new Owf.Controls.NumericTetxBox();
            this.lbl_QtyInBatch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_QtyInBatch = new Owf.Controls.NumericTetxBox();
            this.gradientPanel22 = new Owf.Controls.GradientPanel2();
            this.txt_OnStage = new Owf.Controls.NumericTetxBox();
            this.btn_Start = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Delete = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Freeze = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Freezed = new Owf.Controls.NumericTetxBox();
            this.lbl_Freezed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Proc = new Owf.Controls.NumericTetxBox();
            this.btn_Wizard = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_Ret = new Owf.Controls.NumericTetxBox();
            this.btn_RetWizard = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Stage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_AddProcess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_DeleteProcess = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lbl_QtyOut);
            this.kryptonPanel1.Controls.Add(this.txt_QtyOut);
            this.kryptonPanel1.Controls.Add(this.lbl_QtyInBatch);
            this.kryptonPanel1.Controls.Add(this.txt_QtyInBatch);
            this.kryptonPanel1.Controls.Add(this.gradientPanel22);
            this.kryptonPanel1.Controls.Add(this.txt_OnStage);
            this.kryptonPanel1.Controls.Add(this.btn_Freeze);
            this.kryptonPanel1.Controls.Add(this.txt_Freezed);
            this.kryptonPanel1.Controls.Add(this.lbl_Freezed);
            this.kryptonPanel1.Controls.Add(this.txt_Proc);
            this.kryptonPanel1.Controls.Add(this.txt_Ret);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.lbl_Stage);
            this.kryptonPanel1.Controls.Add(this.btn_AddProcess);
            this.kryptonPanel1.Controls.Add(this.btn_DeleteProcess);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(171, 275);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // lbl_QtyOut
            // 
            this.lbl_QtyOut.Location = new System.Drawing.Point(6, 126);
            this.lbl_QtyOut.Name = "lbl_QtyOut";
            this.lbl_QtyOut.Size = new System.Drawing.Size(62, 20);
            this.lbl_QtyOut.TabIndex = 242;
            this.lbl_QtyOut.Values.Text = "Delivered";
            this.lbl_QtyOut.Visible = false;
            // 
            // txt_QtyOut
            // 
            this.txt_QtyOut.AllowDecimalSeparator = false;
            this.txt_QtyOut.AllowSpace = false;
            this.txt_QtyOut.Location = new System.Drawing.Point(74, 123);
            this.txt_QtyOut.Name = "txt_QtyOut";
            this.txt_QtyOut.Size = new System.Drawing.Size(90, 26);
            this.txt_QtyOut.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txt_QtyOut.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyOut.TabIndex = 241;
            this.txt_QtyOut.Text = "0";
            this.txt_QtyOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_QtyInBatch
            // 
            this.lbl_QtyInBatch.Location = new System.Drawing.Point(87, 210);
            this.lbl_QtyInBatch.Name = "lbl_QtyInBatch";
            this.lbl_QtyInBatch.Size = new System.Drawing.Size(77, 20);
            this.lbl_QtyInBatch.TabIndex = 240;
            this.lbl_QtyInBatch.Values.Text = "Qty in batch";
            this.lbl_QtyInBatch.Visible = false;
            // 
            // txt_QtyInBatch
            // 
            this.txt_QtyInBatch.AllowDecimalSeparator = false;
            this.txt_QtyInBatch.AllowSpace = false;
            this.txt_QtyInBatch.Location = new System.Drawing.Point(87, 236);
            this.txt_QtyInBatch.Name = "txt_QtyInBatch";
            this.txt_QtyInBatch.Size = new System.Drawing.Size(78, 30);
            this.txt_QtyInBatch.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txt_QtyInBatch.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_QtyInBatch.TabIndex = 239;
            this.txt_QtyInBatch.Text = "0";
            this.txt_QtyInBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_QtyInBatch.Visible = false;
            // 
            // gradientPanel22
            // 
            this.gradientPanel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel22.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel22.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel22.EndColor = System.Drawing.Color.Lime;
            this.gradientPanel22.Location = new System.Drawing.Point(5, 196);
            this.gradientPanel22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel22.Name = "gradientPanel22";
            this.gradientPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel22.ShowBottomBorder = true;
            this.gradientPanel22.ShowLeftBorder = true;
            this.gradientPanel22.ShowRightBorder = true;
            this.gradientPanel22.ShowTopBorder = true;
            this.gradientPanel22.Size = new System.Drawing.Size(160, 2);
            this.gradientPanel22.StartColor = System.Drawing.Color.White;
            this.gradientPanel22.TabIndex = 238;
            // 
            // txt_OnStage
            // 
            this.txt_OnStage.AllowDecimalSeparator = false;
            this.txt_OnStage.AllowSpace = false;
            this.txt_OnStage.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Start,
            this.btn_Delete});
            this.txt_OnStage.Location = new System.Drawing.Point(5, 84);
            this.txt_OnStage.Name = "txt_OnStage";
            this.txt_OnStage.Size = new System.Drawing.Size(160, 36);
            this.txt_OnStage.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txt_OnStage.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_OnStage.TabIndex = 13;
            this.txt_OnStage.Text = "0";
            this.txt_OnStage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Start
            // 
            this.btn_Start.Image = global::Odin.Global_Resourses.edit_add24x24;
            this.btn_Start.UniqueName = "A2B020BD1604421752B26AE175F6B0DF";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Odin.Global_Resourses.delete2;
            this.btn_Delete.UniqueName = "9A8482F4DB464CCAADB325B51C18C687";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Freeze
            // 
            this.btn_Freeze.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btn_Freeze.Location = new System.Drawing.Point(5, 205);
            this.btn_Freeze.Name = "btn_Freeze";
            this.btn_Freeze.Size = new System.Drawing.Size(78, 58);
            this.btn_Freeze.TabIndex = 12;
            this.btn_Freeze.Values.Image = global::Odin.Global_Resourses.snowflake48x48;
            this.btn_Freeze.Values.Text = "";
            this.btn_Freeze.Click += new System.EventHandler(this.btn_Freeze_Click);
            // 
            // txt_Freezed
            // 
            this.txt_Freezed.AllowDecimalSeparator = false;
            this.txt_Freezed.AllowSpace = false;
            this.txt_Freezed.Location = new System.Drawing.Point(87, 236);
            this.txt_Freezed.Name = "txt_Freezed";
            this.txt_Freezed.Size = new System.Drawing.Size(78, 30);
            this.txt_Freezed.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.txt_Freezed.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Freezed.TabIndex = 11;
            this.txt_Freezed.Text = "0";
            this.txt_Freezed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Freezed.Validated += new System.EventHandler(this.txt_Freezed_Validated);
            // 
            // lbl_Freezed
            // 
            this.lbl_Freezed.Location = new System.Drawing.Point(101, 210);
            this.lbl_Freezed.Name = "lbl_Freezed";
            this.lbl_Freezed.Size = new System.Drawing.Size(53, 20);
            this.lbl_Freezed.TabIndex = 10;
            this.lbl_Freezed.Values.Text = "Freezed";
            // 
            // txt_Proc
            // 
            this.txt_Proc.AllowDecimalSeparator = false;
            this.txt_Proc.AllowSpace = false;
            this.txt_Proc.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_Wizard});
            this.txt_Proc.Location = new System.Drawing.Point(87, 122);
            this.txt_Proc.Name = "txt_Proc";
            this.txt_Proc.Size = new System.Drawing.Size(78, 26);
            this.txt_Proc.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txt_Proc.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Proc.TabIndex = 9;
            this.txt_Proc.Text = "0";
            this.txt_Proc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Proc.Validated += new System.EventHandler(this.txt_Proc_Validated);
            // 
            // btn_Wizard
            // 
            this.btn_Wizard.Image = global::Odin.Global_Resourses.wizard;
            this.btn_Wizard.UniqueName = "F8D7E98B438D4B908FAE835F6C5E819F";
            this.btn_Wizard.Click += new System.EventHandler(this.btn_Wizard_Click);
            // 
            // txt_Ret
            // 
            this.txt_Ret.AllowDecimalSeparator = false;
            this.txt_Ret.AllowSpace = false;
            this.txt_Ret.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btn_RetWizard});
            this.txt_Ret.Location = new System.Drawing.Point(5, 122);
            this.txt_Ret.Name = "txt_Ret";
            this.txt_Ret.Size = new System.Drawing.Size(78, 26);
            this.txt_Ret.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.txt_Ret.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Ret.TabIndex = 8;
            this.txt_Ret.Text = "0";
            this.txt_Ret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Ret.Validated += new System.EventHandler(this.txt_Ret_Validated);
            // 
            // btn_RetWizard
            // 
            this.btn_RetWizard.Image = global::Odin.Global_Resourses.wizard;
            this.btn_RetWizard.UniqueName = "737DE8DF9BB9431CCFA31F56B0B70FA0";
            this.btn_RetWizard.Click += new System.EventHandler(this.btn_RetWizard_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(54, 61);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "In process";
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
            this.lbl_Stage.Size = new System.Drawing.Size(171, 58);
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
            this.btn_AddProcess.Location = new System.Drawing.Point(87, 149);
            this.btn_AddProcess.Name = "btn_AddProcess";
            this.btn_AddProcess.Size = new System.Drawing.Size(78, 43);
            this.btn_AddProcess.TabIndex = 4;
            this.btn_AddProcess.Values.Image = global::Odin.Global_Resourses.Forward2;
            this.btn_AddProcess.Values.Text = "";
            this.btn_AddProcess.Click += new System.EventHandler(this.btn_AddProcess_Click);
            // 
            // btn_DeleteProcess
            // 
            this.btn_DeleteProcess.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btn_DeleteProcess.Location = new System.Drawing.Point(5, 149);
            this.btn_DeleteProcess.Name = "btn_DeleteProcess";
            this.btn_DeleteProcess.Size = new System.Drawing.Size(78, 43);
            this.btn_DeleteProcess.TabIndex = 3;
            this.btn_DeleteProcess.Values.Image = global::Odin.Global_Resourses.BackRed;
            this.btn_DeleteProcess.Values.Text = "";
            this.btn_DeleteProcess.Visible = false;
            this.btn_DeleteProcess.Click += new System.EventHandler(this.btn_DeleteProcess_Click);
            // 
            // ctl_ProcessStageV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_ProcessStageV2";
            this.Size = new System.Drawing.Size(171, 275);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Freeze;
        private Owf.Controls.NumericTetxBox txt_Freezed;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Freezed;
        private Owf.Controls.NumericTetxBox txt_Proc;
        private Owf.Controls.NumericTetxBox txt_Ret;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Stage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddProcess;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_DeleteProcess;
        private Owf.Controls.NumericTetxBox txt_OnStage;
        private Owf.Controls.GradientPanel2 gradientPanel22;
        public ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Start;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Wizard;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_RetWizard;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Delete;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_QtyInBatch;
        private Owf.Controls.NumericTetxBox txt_QtyInBatch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_QtyOut;
        private Owf.Controls.NumericTetxBox txt_QtyOut;
    }
}
