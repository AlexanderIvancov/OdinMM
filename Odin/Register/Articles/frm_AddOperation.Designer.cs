namespace Odin.Register.Articles
{
    partial class frm_AddOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddOperation));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_OperNO = new Owf.Controls.NumericTetxBox();
            this.btn_AddFromTemplate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmb_Operations1 = new Odin.CMB_Components.Operations.cmb_Operations();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chk_Use = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Formula = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Operation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.txt_Comments);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.txt_OperNO);
            this.kryptonPanel1.Controls.Add(this.btn_AddFromTemplate);
            this.kryptonPanel1.Controls.Add(this.cmb_Operations1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.chk_Use);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txt_Formula);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.txt_Operation);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(425, 321);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 72);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel3.TabIndex = 28;
            this.kryptonLabel3.Values.Text = "Oper NO.:";
            // 
            // txt_OperNO
            // 
            this.txt_OperNO.AllowDecimalSeparator = false;
            this.txt_OperNO.AllowSpace = false;
            this.txt_OperNO.Location = new System.Drawing.Point(84, 71);
            this.txt_OperNO.Name = "txt_OperNO";
            this.txt_OperNO.Size = new System.Drawing.Size(42, 23);
            this.txt_OperNO.TabIndex = 27;
            this.txt_OperNO.Text = "0";
            // 
            // btn_AddFromTemplate
            // 
            this.btn_AddFromTemplate.Location = new System.Drawing.Point(383, 99);
            this.btn_AddFromTemplate.Name = "btn_AddFromTemplate";
            this.btn_AddFromTemplate.Size = new System.Drawing.Size(30, 22);
            this.btn_AddFromTemplate.TabIndex = 24;
            this.btn_AddFromTemplate.Values.Image = global::Odin.Global_Resourses.wizard;
            this.btn_AddFromTemplate.Values.Text = "";
            this.btn_AddFromTemplate.Click += new System.EventHandler(this.btn_AddFromTemplate_Click);
            // 
            // cmb_Operations1
            // 
            this.cmb_Operations1.EnableSearchId = false;
            this.cmb_Operations1.Formula = null;
            this.cmb_Operations1.Location = new System.Drawing.Point(84, 100);
            this.cmb_Operations1.Name = "cmb_Operations1";
            this.cmb_Operations1.Operation = "";
            this.cmb_Operations1.OperationId = 0;
            this.cmb_Operations1.Size = new System.Drawing.Size(293, 20);
            this.cmb_Operations1.TabIndex = 23;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 100);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel2.TabIndex = 22;
            this.kryptonLabel2.Values.Text = "Template:";
            // 
            // chk_Use
            // 
            this.chk_Use.Location = new System.Drawing.Point(84, 227);
            this.chk_Use.Name = "chk_Use";
            this.chk_Use.Size = new System.Drawing.Size(188, 20);
            this.chk_Use.TabIndex = 21;
            this.chk_Use.Values.Text = "Use once during work process";
            this.chk_Use.CheckedChanged += new System.EventHandler(this.chk_Use_CheckedChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 168);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel1.TabIndex = 19;
            this.kryptonLabel1.Values.Text = "Formula:";
            // 
            // txt_Formula
            // 
            this.txt_Formula.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txt_Formula.Location = new System.Drawing.Point(84, 168);
            this.txt_Formula.Multiline = true;
            this.txt_Formula.Name = "txt_Formula";
            this.txt_Formula.Size = new System.Drawing.Size(329, 53);
            this.txt_Formula.TabIndex = 18;
            this.txt_Formula.TextChanged += new System.EventHandler(this.txt_Formula_TextChanged);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "4687129580114F1960B04C89E02869BE";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 126);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel5.TabIndex = 17;
            this.kryptonLabel5.Values.Text = "Operation:";
            // 
            // txt_Operation
            // 
            this.txt_Operation.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_Operation.Location = new System.Drawing.Point(84, 126);
            this.txt_Operation.Multiline = true;
            this.txt_Operation.Name = "txt_Operation";
            this.txt_Operation.Size = new System.Drawing.Size(329, 36);
            this.txt_Operation.TabIndex = 16;
            this.txt_Operation.TextChanged += new System.EventHandler(this.txt_Operation_TextChanged);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "4687129580114F1960B04C89E02869BE";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(323, 52);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(323, 12);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 253);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel4.TabIndex = 30;
            this.kryptonLabel4.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_Comments.Location = new System.Drawing.Point(84, 253);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(329, 53);
            this.txt_Comments.TabIndex = 29;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "4687129580114F1960B04C89E02869BE";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // frm_AddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 321);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddOperation";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add operation";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Formula;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Operation;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Use;
        private CMB_Components.Operations.cmb_Operations cmb_Operations1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddFromTemplate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Owf.Controls.NumericTetxBox txt_OperNO;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
    }
}