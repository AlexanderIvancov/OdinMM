namespace Odin.Warehouse.Inventory
{
    partial class frm_SeparateLabels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SeparateLabels));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_QtyLabels = new Owf.Controls.NumericTetxBox();
            this.txt_NewQty = new Owf.Controls.NumericTetxBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rb_Multiple = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Once = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_QtyLabels);
            this.kryptonPanel1.Controls.Add(this.txt_NewQty);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(315, 183);
            this.kryptonPanel1.TabIndex = 29;
            // 
            // txt_QtyLabels
            // 
            this.txt_QtyLabels.AllowDecimalSeparator = false;
            this.txt_QtyLabels.AllowSpace = false;
            this.txt_QtyLabels.Location = new System.Drawing.Point(239, 150);
            this.txt_QtyLabels.Name = "txt_QtyLabels";
            this.txt_QtyLabels.Size = new System.Drawing.Size(64, 20);
            this.txt_QtyLabels.TabIndex = 31;
            this.txt_QtyLabels.Text = "1";
            this.txt_QtyLabels.Validated += new System.EventHandler(this.txt_QtyLabels_Validated);
            // 
            // txt_NewQty
            // 
            this.txt_NewQty.AllowDecimalSeparator = true;
            this.txt_NewQty.AllowSpace = false;
            this.txt_NewQty.Location = new System.Drawing.Point(74, 150);
            this.txt_NewQty.Name = "txt_NewQty";
            this.txt_NewQty.Size = new System.Drawing.Size(68, 20);
            this.txt_NewQty.TabIndex = 30;
            this.txt_NewQty.Text = "0";
            this.txt_NewQty.TextChanged += new System.EventHandler(this.txt_NewQty_TextChanged);
            this.txt_NewQty.Validated += new System.EventHandler(this.txt_NewQty_Validated);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(148, 150);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel1.TabIndex = 29;
            this.kryptonLabel1.Values.Text = "Qty of  labels:";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(9, 54);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Multiple);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rb_Once);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(202, 85);
            this.kryptonGroupBox1.TabIndex = 28;
            this.kryptonGroupBox1.Values.Heading = "Separation type";
            // 
            // rb_Multiple
            // 
            this.rb_Multiple.Location = new System.Drawing.Point(3, 29);
            this.rb_Multiple.Name = "rb_Multiple";
            this.rb_Multiple.Size = new System.Drawing.Size(128, 20);
            this.rb_Multiple.TabIndex = 1;
            this.rb_Multiple.Values.Text = "Multiple separation";
            this.rb_Multiple.CheckedChanged += new System.EventHandler(this.rb_Multiple_CheckedChanged);
            // 
            // rb_Once
            // 
            this.rb_Once.Checked = true;
            this.rb_Once.Location = new System.Drawing.Point(3, 3);
            this.rb_Once.Name = "rb_Once";
            this.rb_Once.Size = new System.Drawing.Size(124, 20);
            this.rb_Once.TabIndex = 0;
            this.rb_Once.Values.Text = "Separate one label";
            this.rb_Once.CheckedChanged += new System.EventHandler(this.rb_Once_CheckedChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(217, 14);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(217, 54);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(9, 150);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "New qty:";
            // 
            // frm_SeparateLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 183);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_SeparateLabels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separate label";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Owf.Controls.NumericTetxBox txt_QtyLabels;
        private Owf.Controls.NumericTetxBox txt_NewQty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Multiple;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Once;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}