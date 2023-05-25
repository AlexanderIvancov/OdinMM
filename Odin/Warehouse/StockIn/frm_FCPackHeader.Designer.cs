namespace Odin.Warehouse.StockIn
{
    partial class frm_FCPackHeader
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.chk_Closed = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btn_scan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_BoxNO = new System.Windows.Forms.TextBox();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_PackagesPDA1 = new Odin.CMB_Components.Package.cmb_PackagesPDA();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Article = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Unit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_BatchPDA1 = new Odin.CMB_Components.Batches.cmb_BatchPDA();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rb_Valkas2B = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Valkas2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rb_Valkas2B);
            this.kryptonPanel1.Controls.Add(this.rb_Valkas2);
            this.kryptonPanel1.Controls.Add(this.chk_Closed);
            this.kryptonPanel1.Controls.Add(this.btn_scan);
            this.kryptonPanel1.Controls.Add(this.txt_BoxNO);
            this.kryptonPanel1.Controls.Add(this.txt_Weight);
            this.kryptonPanel1.Controls.Add(this.txt_Qty);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.cmb_PackagesPDA1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.txt_Article);
            this.kryptonPanel1.Controls.Add(this.txt_Unit);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.cmb_BatchPDA1);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(640, 390);
            this.kryptonPanel1.TabIndex = 30;
            // 
            // chk_Closed
            // 
            this.chk_Closed.AutoSize = false;
            this.chk_Closed.Location = new System.Drawing.Point(123, 85);
            this.chk_Closed.Name = "chk_Closed";
            this.chk_Closed.Size = new System.Drawing.Size(137, 58);
            this.chk_Closed.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_Closed.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_Closed.TabIndex = 256;
            this.chk_Closed.Values.Text = "Closed";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(443, 149);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(45, 41);
            this.btn_scan.TabIndex = 255;
            this.btn_scan.Values.Image = global::Odin.Global_Resourses.scanner;
            this.btn_scan.Values.Text = "";
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // txt_BoxNO
            // 
            this.txt_BoxNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BoxNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_BoxNO.Location = new System.Drawing.Point(394, 336);
            this.txt_BoxNO.Name = "txt_BoxNO";
            this.txt_BoxNO.Size = new System.Drawing.Size(120, 40);
            this.txt_BoxNO.TabIndex = 254;
            this.txt_BoxNO.TextChanged += new System.EventHandler(this.txt_BoxNO_TextChanged);
            this.txt_BoxNO.Enter += new System.EventHandler(this.txt_BoxNO_Enter);
            // 
            // txt_Weight
            // 
            this.txt_Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Weight.Location = new System.Drawing.Point(165, 336);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(120, 40);
            this.txt_Weight.TabIndex = 253;
            this.txt_Weight.TextChanged += new System.EventHandler(this.txt_Weight_TextChanged);
            this.txt_Weight.Enter += new System.EventHandler(this.txt_Weight_Enter);
            this.txt_Weight.Leave += new System.EventHandler(this.txt_Weight_Leave);
            // 
            // txt_Qty
            // 
            this.txt_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Qty.Location = new System.Drawing.Point(123, 290);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(162, 40);
            this.txt_Qty.TabIndex = 252;
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            this.txt_Qty.Enter += new System.EventHandler(this.txt_Qty_Enter);
            this.txt_Qty.Leave += new System.EventHandler(this.txt_Qty_Leave);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(295, 344);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(89, 26);
            this.kryptonLabel7.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel7.TabIndex = 247;
            this.kryptonLabel7.Values.Text = "Box NO:";
            // 
            // cmb_PackagesPDA1
            // 
            this.cmb_PackagesPDA1.EnableSearchId = false;
            this.cmb_PackagesPDA1.Location = new System.Drawing.Point(123, 243);
            this.cmb_PackagesPDA1.Name = "cmb_PackagesPDA1";
            this.cmb_PackagesPDA1.Package = "";
            this.cmb_PackagesPDA1.PackageId = 0;
            this.cmb_PackagesPDA1.Size = new System.Drawing.Size(505, 41);
            this.cmb_PackagesPDA1.TabIndex = 244;
            this.cmb_PackagesPDA1.PackagesChanged += new Odin.CMB_Components.Package.PackagesPDAEventHandler(this.cmb_PackagesPDA1_PackagesChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 203);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(76, 26);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel4.TabIndex = 243;
            this.kryptonLabel4.Values.Text = "Article:";
            // 
            // txt_Article
            // 
            this.txt_Article.Enabled = false;
            this.txt_Article.Location = new System.Drawing.Point(123, 196);
            this.txt_Article.Name = "txt_Article";
            this.txt_Article.Size = new System.Drawing.Size(505, 44);
            this.txt_Article.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Article.TabIndex = 242;
            // 
            // txt_Unit
            // 
            this.txt_Unit.Enabled = false;
            this.txt_Unit.Location = new System.Drawing.Point(394, 290);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(65, 40);
            this.txt_Unit.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Unit.TabIndex = 241;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(295, 298);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(55, 26);
            this.kryptonLabel6.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel6.TabIndex = 240;
            this.kryptonLabel6.Values.Text = "Unit:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 344);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(136, 26);
            this.kryptonLabel5.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel5.TabIndex = 239;
            this.kryptonLabel5.Values.Text = "Weight (brut):";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 298);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(95, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel2.TabIndex = 237;
            this.kryptonLabel2.Values.Text = "Quantity:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 249);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel1.TabIndex = 235;
            this.kryptonLabel1.Values.Text = "Package:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 156);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(71, 26);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabel3.TabIndex = 233;
            this.kryptonLabel3.Values.Text = "Batch:";
            // 
            // cmb_BatchPDA1
            // 
            this.cmb_BatchPDA1.Article = null;
            this.cmb_BatchPDA1.ArticleId = 0;
            this.cmb_BatchPDA1.Batch = "";
            this.cmb_BatchPDA1.BatchId = 0;
            this.cmb_BatchPDA1.ClearButtonVisible = -1;
            this.cmb_BatchPDA1.COId = 0;
            this.cmb_BatchPDA1.ConfOrder = null;
            this.cmb_BatchPDA1.CountID = 0;
            this.cmb_BatchPDA1.Customer = null;
            this.cmb_BatchPDA1.IsActive = 0;
            this.cmb_BatchPDA1.Location = new System.Drawing.Point(123, 149);
            this.cmb_BatchPDA1.Name = "cmb_BatchPDA1";
            this.cmb_BatchPDA1.ParentBatchId = 0;
            this.cmb_BatchPDA1.Qty = 0D;
            this.cmb_BatchPDA1.QtyLabels = 0;
            this.cmb_BatchPDA1.ResDate = null;
            this.cmb_BatchPDA1.SecName = null;
            this.cmb_BatchPDA1.Size = new System.Drawing.Size(314, 41);
            this.cmb_BatchPDA1.StencilRequired = 0;
            this.cmb_BatchPDA1.TabIndex = 34;
            this.cmb_BatchPDA1.TextBoxEnabled = -1;
            this.cmb_BatchPDA1.Unit = "";
            this.cmb_BatchPDA1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadPDAEventHandler(this.cmb_BatchPDA1_BatchChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(495, 12);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(133, 58);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(495, 76);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 58);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // rb_Valkas2B
            // 
            this.rb_Valkas2B.Checked = true;
            this.rb_Valkas2B.Location = new System.Drawing.Point(343, 102);
            this.rb_Valkas2B.Name = "rb_Valkas2B";
            this.rb_Valkas2B.Size = new System.Drawing.Size(116, 26);
            this.rb_Valkas2B.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Valkas2B.TabIndex = 258;
            this.rb_Valkas2B.Values.Text = "Valkas 2B";
            // 
            // rb_Valkas2
            // 
            this.rb_Valkas2.Location = new System.Drawing.Point(232, 102);
            this.rb_Valkas2.Name = "rb_Valkas2";
            this.rb_Valkas2.Size = new System.Drawing.Size(102, 26);
            this.rb_Valkas2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Valkas2.TabIndex = 257;
            this.rb_Valkas2.Values.Text = "Valkas 2";
            // 
            // frm_FCPackHeader
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 390);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_FCPackHeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box header";
            this.Load += new System.EventHandler(this.frm_FCPackHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        public CMB_Components.Batches.cmb_BatchPDA cmb_BatchPDA1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Article;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Unit;
        public CMB_Components.Package.cmb_PackagesPDA cmb_PackagesPDA1;
        public System.Windows.Forms.TextBox txt_BoxNO;
        public System.Windows.Forms.TextBox txt_Weight;
        public System.Windows.Forms.TextBox txt_Qty;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_scan;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_Closed;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2B;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Valkas2;
    }
}