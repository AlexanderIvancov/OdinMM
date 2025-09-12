namespace Odin.Register.Articles
{
    partial class ctl_ArtCertificates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_ArtCertificates));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmb_Articles1 = new Odin.CMB_Components.Articles.cmb_Articles();
            this.cmb_Certs1 = new Odin.CMB_Components.ArtCerts.cmb_ArtCerts();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_certid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_certNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_artid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_tnved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_dateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_IsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            this.btn_Lock = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Lock);
            this.kryptonPanel1.Controls.Add(this.cmb_Articles1);
            this.kryptonPanel1.Controls.Add(this.cmb_Certs1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(924, 52);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // cmb_Articles1
            // 
            this.cmb_Articles1.Article = "";
            this.cmb_Articles1.ArticleId = 0;
            this.cmb_Articles1.ArticleIdRec = 0;
            this.cmb_Articles1.ArtType = null;
            this.cmb_Articles1.BOMState = 0;
            this.cmb_Articles1.CertState = "";
            this.cmb_Articles1.Comments = null;
            this.cmb_Articles1.CustCode = null;
            this.cmb_Articles1.CustCodeId = 0;
            this.cmb_Articles1.Department = null;
            this.cmb_Articles1.DeptId = 0;
            this.cmb_Articles1.Description = null;
            this.cmb_Articles1.IsActive = -1;
            this.cmb_Articles1.IsPF = 0;
            this.cmb_Articles1.Location = new System.Drawing.Point(72, 15);
            this.cmb_Articles1.Manufacturer = "";
            this.cmb_Articles1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Articles1.Name = "cmb_Articles1";
            this.cmb_Articles1.Project = null;
            this.cmb_Articles1.ProjectId = 0;
            this.cmb_Articles1.QtyAvail = 0D;
            this.cmb_Articles1.QtyConsStock = 0D;
            this.cmb_Articles1.RMId = 0;
            this.cmb_Articles1.SecName = null;
            this.cmb_Articles1.Size = new System.Drawing.Size(265, 20);
            this.cmb_Articles1.SMTType = 0;
            this.cmb_Articles1.SpoilConst = 0D;
            this.cmb_Articles1.Stage = "";
            this.cmb_Articles1.StageID = 0;
            this.cmb_Articles1.TabIndex = 45;
            this.cmb_Articles1.TypeId = 0;
            this.cmb_Articles1.Unit = null;
            this.cmb_Articles1.UnitId = 0;
            this.cmb_Articles1.Weight = 0D;
            this.cmb_Articles1.ArticleChanged += new Odin.CMB_Components.Articles.ArticlesEventHandler(this.cmb_Articles1_ArticleChanged);
            // 
            // cmb_Certs1
            // 
            this.cmb_Certs1.Cert = "";
            this.cmb_Certs1.IsEmptyColor = false;
            this.cmb_Certs1.Location = new System.Drawing.Point(352, 15);
            this.cmb_Certs1.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Certs1.Name = "cmb_Certs1";
            this.cmb_Certs1.Size = new System.Drawing.Size(165, 20);
            this.cmb_Certs1.TabIndex = 45;
            this.cmb_Certs1.CertChanged += new Odin.CMB_Components.ArtCerts.ArtCertsEventHandler(this.cmb_Certs1_CertChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel2.TabIndex = 42;
            this.kryptonLabel2.Values.Text = "Article:";
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeight = 25;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_certid,
            this.cn_certNum,
            this.cn_artid,
            this.cn_article,
            this.cn_tnved,
            this.cn_dateFrom,
            this.cn_dateTo,
            this.cn_comments,
            this.chk_IsValid,
            this.cn_createdby,
            this.cn_createdat});
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.Location = new System.Drawing.Point(0, 77);
            this.gv_List.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(924, 248);
            this.gv_List.TabIndex = 46;
            // 
            // cn_certid
            // 
            this.cn_certid.DataPropertyName = "certid";
            this.cn_certid.FillWeight = 70F;
            this.cn_certid.HeaderText = "id";
            this.cn_certid.Name = "cn_certid";
            this.cn_certid.Width = 70;
            // 
            // cn_certNum
            // 
            this.cn_certNum.DataPropertyName = "certNum";
            this.cn_certNum.FillWeight = 150F;
            this.cn_certNum.HeaderText = "Certificate number";
            this.cn_certNum.Name = "cn_certNum";
            this.cn_certNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_certNum.Width = 150;
            // 
            // cn_artid
            // 
            this.cn_artid.DataPropertyName = "artid";
            this.cn_artid.FillWeight = 150F;
            this.cn_artid.HeaderText = "Article Id";
            this.cn_artid.Name = "cn_artid";
            this.cn_artid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_artid.Width = 150;
            // 
            // cn_article
            // 
            this.cn_article.DataPropertyName = "article";
            this.cn_article.FillWeight = 150F;
            this.cn_article.HeaderText = "Article";
            this.cn_article.Name = "cn_article";
            this.cn_article.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cn_article.Width = 150;
            // 
            // cn_tnved
            // 
            this.cn_tnved.DataPropertyName = "tnved";
            this.cn_tnved.FillWeight = 150F;
            this.cn_tnved.HeaderText = "HS code";
            this.cn_tnved.Name = "cn_tnved";
            this.cn_tnved.Width = 150;
            // 
            // cn_dateFrom
            // 
            this.cn_dateFrom.DataPropertyName = "dateFrom";
            this.cn_dateFrom.FillWeight = 150F;
            this.cn_dateFrom.HeaderText = "Valid from";
            this.cn_dateFrom.Name = "cn_dateFrom";
            this.cn_dateFrom.Width = 150;
            // 
            // cn_dateTo
            // 
            this.cn_dateTo.DataPropertyName = "dateTo";
            this.cn_dateTo.FillWeight = 150F;
            this.cn_dateTo.HeaderText = "Valid to";
            this.cn_dateTo.Name = "cn_dateTo";
            this.cn_dateTo.Width = 150;
            // 
            // cn_comments
            // 
            this.cn_comments.DataPropertyName = "comments";
            this.cn_comments.FillWeight = 150F;
            this.cn_comments.HeaderText = "Comments";
            this.cn_comments.Name = "cn_comments";
            this.cn_comments.Width = 150;
            // 
            // chk_IsValid
            // 
            this.chk_IsValid.DataPropertyName = "IsValid";
            this.chk_IsValid.FillWeight = 150F;
            this.chk_IsValid.HeaderText = "IsValid";
            this.chk_IsValid.Name = "chk_IsValid";
            this.chk_IsValid.Visible = false;
            this.chk_IsValid.Width = 150;
            // 
            // cn_createdby
            // 
            this.cn_createdby.DataPropertyName = "createdby";
            this.cn_createdby.HeaderText = "Who";
            this.cn_createdby.Name = "cn_createdby";
            // 
            // cn_createdat
            // 
            this.cn_createdat.DataPropertyName = "createdat";
            this.cn_createdat.HeaderText = "When";
            this.cn_createdat.Name = "cn_createdat";
            // 
            // btn_Add
            // 
            this.btn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeftAutoMirrorImage = true;
            this.btn_Add.Size = new System.Drawing.Size(23, 22);
            this.btn_Add.Text = "Add new";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Edit.Image = global::Odin.Global_Resourses.edit;
            this.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(23, 22);
            this.btn_Edit.Text = "Edit selected line";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RightToLeftAutoMirrorImage = true;
            this.btn_Delete.Size = new System.Drawing.Size(23, 22);
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = null;
            this.bn_List.DeleteItem = null;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_Edit,
            this.btn_Delete});
            this.bn_List.Location = new System.Drawing.Point(0, 52);
            this.bn_List.MoveFirstItem = null;
            this.bn_List.MoveLastItem = null;
            this.bn_List.MoveNextItem = null;
            this.bn_List.MovePreviousItem = null;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = null;
            this.bn_List.Size = new System.Drawing.Size(924, 25);
            this.bn_List.TabIndex = 45;
            this.bn_List.Text = "Bill of materials";
            // 
            // btn_Lock
            // 
            this.btn_Lock.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Lock.Location = new System.Drawing.Point(529, 15);
            this.btn_Lock.Name = "btn_Lock";
            this.btn_Lock.Size = new System.Drawing.Size(27, 25);
            this.btn_Lock.TabIndex = 46;
            this.btn_Lock.Values.Image = global::Odin.Global_Resourses.lock_open;
            this.btn_Lock.Values.Text = "";
            this.btn_Lock.Click += new System.EventHandler(this.btn_Lock_Click);
            // 
            // ctl_ArtCertificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctl_ArtCertificates";
            this.Size = new System.Drawing.Size(924, 325);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private Global_Classes.SyncBindingSource bs_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_certid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_certNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_artid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_tnved;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn chk_IsValid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_dateFrom;
        public CMB_Components.Articles.cmb_Articles cmb_Articles1;
        public CMB_Components.ArtCerts.cmb_ArtCerts cmb_Certs1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripButton btn_Edit;
        private System.Windows.Forms.ToolStripButton btn_Delete;
        private System.Windows.Forms.BindingNavigator bn_List;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Lock;
    }
}
