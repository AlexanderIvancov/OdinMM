namespace Odin.Register.Articles
{
    partial class ctl_BOMSupplier
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
            this.components = new System.ComponentModel.Container();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ArtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpseMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpoilNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpoilConst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnigueRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Positions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Excel = new System.Windows.Forms.ToolStripButton();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.cmb_Batches1 = new Odin.CMB_Components.Batches.cmb_Batches();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(45, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 42;
            this.kryptonLabel2.Values.Text = "Batch:";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonCheckBox1);
            this.kryptonPanel1.Controls.Add(this.cmb_Batches1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 25);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(522, 52);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeight = 25;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtID,
            this.Article,
            this.SecName,
            this.Analog,
            this.Qty,
            this.CpseMark,
            this.Comments,
            this.SpoilNorm,
            this.SpoilConst,
            this.Stage,
            this.UnigueRow,
            this.Positions,
            this.ArtType,
            this.Supplier,
            this.SupArticle,
            this.DN,
            this.CustCode});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 77);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(522, 265);
            this.gv_List.TabIndex = 44;
            // 
            // ArtID
            // 
            this.ArtID.DataPropertyName = "IdCst";
            this.ArtID.HeaderText = "ArtID";
            this.ArtID.Name = "ArtID";
            // 
            // Article
            // 
            this.Article.DataPropertyName = "Article";
            this.Article.HeaderText = "Article";
            this.Article.Name = "Article";
            // 
            // SecName
            // 
            this.SecName.DataPropertyName = "SecName";
            this.SecName.HeaderText = "SecName";
            this.SecName.Name = "SecName";
            // 
            // Analog
            // 
            this.Analog.DataPropertyName = "Analog";
            this.Analog.HeaderText = "Analog";
            this.Analog.Name = "Analog";
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Quantity";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // CpseMark
            // 
            this.CpseMark.DataPropertyName = "CpseMark";
            this.CpseMark.HeaderText = "CpseMark";
            this.CpseMark.Name = "CpseMark";
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            // 
            // SpoilNorm
            // 
            this.SpoilNorm.DataPropertyName = "SpoilNorm";
            this.SpoilNorm.HeaderText = "SpoilNorm";
            this.SpoilNorm.Name = "SpoilNorm";
            // 
            // SpoilConst
            // 
            this.SpoilConst.DataPropertyName = "SpoilConst";
            this.SpoilConst.HeaderText = "SpoilConst";
            this.SpoilConst.Name = "SpoilConst";
            // 
            // Stage
            // 
            this.Stage.DataPropertyName = "Stage";
            this.Stage.HeaderText = "Stage";
            this.Stage.Name = "Stage";
            // 
            // UnigueRow
            // 
            this.UnigueRow.DataPropertyName = "UnigueRow";
            this.UnigueRow.HeaderText = "UnigueRow";
            this.UnigueRow.Name = "UnigueRow";
            // 
            // Positions
            // 
            this.Positions.DataPropertyName = "Positions";
            this.Positions.HeaderText = "Positions";
            this.Positions.Name = "Positions";
            // 
            // ArtType
            // 
            this.ArtType.DataPropertyName = "ArtType";
            this.ArtType.HeaderText = "ArtType";
            this.ArtType.Name = "ArtType";
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            // 
            // SupArticle
            // 
            this.SupArticle.DataPropertyName = "suparticle";
            this.SupArticle.HeaderText = "SupArticle";
            this.SupArticle.Name = "SupArticle";
            // 
            // DN
            // 
            this.DN.DataPropertyName = "delivnote";
            this.DN.HeaderText = "DN";
            this.DN.Name = "DN";
            // 
            // CustCode
            // 
            this.CustCode.DataPropertyName = "custcode";
            this.CustCode.HeaderText = "CustCode";
            this.CustCode.Name = "CustCode";
            // 
            // btn_Excel
            // 
            this.btn_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excel.Image = global::Odin.Global_Resourses.ExcelSpreadsheetSmall;
            this.btn_Excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(23, 22);
            this.btn_Excel.Text = "Export into excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = null;
            this.bn_List.DeleteItem = null;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Excel});
            this.bn_List.Location = new System.Drawing.Point(0, 0);
            this.bn_List.MoveFirstItem = null;
            this.bn_List.MoveLastItem = null;
            this.bn_List.MoveNextItem = null;
            this.bn_List.MovePreviousItem = null;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = null;
            this.bn_List.Size = new System.Drawing.Size(522, 25);
            this.bn_List.TabIndex = 43;
            this.bn_List.Text = "Bill of materials";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(264, 15);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(186, 20);
            this.kryptonCheckBox1.TabIndex = 44;
            this.kryptonCheckBox1.Values.Text = "Show items with supplier only";
            // 
            // cmb_Batches1
            // 
            this.cmb_Batches1.ActiveOnly = 0;
            this.cmb_Batches1.Article = null;
            this.cmb_Batches1.ArticleId = 0;
            this.cmb_Batches1.Batch = "";
            this.cmb_Batches1.BatchId = 0;
            this.cmb_Batches1.Comments = null;
            this.cmb_Batches1.ConfOrder = null;
            this.cmb_Batches1.ConfOrderId = 0;
            this.cmb_Batches1.CustArticle = null;
            this.cmb_Batches1.Customer = null;
            this.cmb_Batches1.IsActive = 0;
            this.cmb_Batches1.IsGroup = 0;
            this.cmb_Batches1.IsProject = 0;
            this.cmb_Batches1.IsQuote = 0;
            this.cmb_Batches1.Location = new System.Drawing.Point(103, 15);
            this.cmb_Batches1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Batches1.Name = "cmb_Batches1";
            this.cmb_Batches1.ParentBatchId = 0;
            this.cmb_Batches1.Qty = 0D;
            this.cmb_Batches1.QtyLabels = 0;
            this.cmb_Batches1.ResDate = null;
            this.cmb_Batches1.SecName = null;
            this.cmb_Batches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Batches1.Stages = null;
            this.cmb_Batches1.StencilRequired = 0;
            this.cmb_Batches1.TabIndex = 43;
            this.cmb_Batches1.BatchChanged += new Odin.CMB_Components.Batches.BatchHeadEventHandler(this.cmb_Batches1_BatchesChanged);
            // 
            // ctl_BOMSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.bn_List);
            this.Name = "ctl_BOMSupplier";
            this.Size = new System.Drawing.Size(522, 342);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ToolStripButton btn_Excel;
        private System.Windows.Forms.BindingNavigator bn_List;
        private Global_Classes.SyncBindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpseMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpoilNorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpoilConst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnigueRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Positions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustCode;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        public CMB_Components.Batches.cmb_Batches cmb_Batches1;
    }
}
