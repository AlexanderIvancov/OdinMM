namespace Odin.Workshop
{
    partial class ctl_ProcessStageLaunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_ProcessStageLaunch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Stage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bn_List = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cn_inlaunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_tostart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_started = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_tofinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_finished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_freezed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_prevsum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_prevstageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_oldfreezed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_onstage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnu_Lines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_List = new Odin.Global_Classes.SyncBindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).BeginInit();
            this.bn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.mnu_Lines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Stage
            // 
            this.lbl_Stage.AutoSize = false;
            this.lbl_Stage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Stage.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lbl_Stage.Location = new System.Drawing.Point(0, 0);
            this.lbl_Stage.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Stage.Name = "lbl_Stage";
            this.lbl_Stage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lbl_Stage.Size = new System.Drawing.Size(330, 50);
            this.lbl_Stage.StateCommon.LongText.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Stage.StateNormal.LongText.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Stage.StateNormal.ShortText.Color1 = System.Drawing.Color.Yellow;
            this.lbl_Stage.StateNormal.ShortText.Color2 = System.Drawing.Color.Green;
            this.lbl_Stage.StateNormal.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.lbl_Stage.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Stage.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbl_Stage.TabIndex = 6;
            this.lbl_Stage.UseMnemonic = false;
            this.lbl_Stage.Values.Text = "SMT";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 239);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanel1.Size = new System.Drawing.Size(330, 59);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(227, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 39);
            this.btn_OK.TabIndex = 26;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // bn_List
            // 
            this.bn_List.AddNewItem = null;
            this.bn_List.CountItem = this.bindingNavigatorCountItem;
            this.bn_List.DeleteItem = null;
            this.bn_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bn_List.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bn_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bn_List.Location = new System.Drawing.Point(0, 214);
            this.bn_List.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_List.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_List.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_List.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_List.Name = "bn_List";
            this.bn_List.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_List.Size = new System.Drawing.Size(330, 25);
            this.bn_List.TabIndex = 8;
            this.bn_List.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.AllowUserToDeleteRows = false;
            this.gv_List.AllowUserToOrderColumns = true;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_id,
            this.cn_name,
            this.btn_add,
            this.cn_inlaunch,
            this.cn_tostart,
            this.cn_started,
            this.cn_tofinish,
            this.cn_finished,
            this.cn_freezed,
            this.cn_prevsum,
            this.cn_prevstageid,
            this.cn_oldfreezed,
            this.cn_onstage});
            this.gv_List.ContextMenuStrip = this.mnu_Lines;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gv_List.Location = new System.Drawing.Point(0, 50);
            this.gv_List.Name = "gv_List";
            this.gv_List.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.gv_List.RowHeadersWidth = 5;
            this.gv_List.Size = new System.Drawing.Size(330, 164);
            this.gv_List.TabIndex = 9;
            this.gv_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellClick);
            this.gv_List.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gv_List_CellPainting);
            this.gv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValidated);
            this.gv_List.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_List_ColumnHeaderMouseClick);
            // 
            // cn_id
            // 
            this.cn_id.DataPropertyName = "id";
            this.cn_id.HeaderText = "id";
            this.cn_id.Name = "cn_id";
            this.cn_id.ReadOnly = true;
            this.cn_id.Visible = false;
            // 
            // cn_name
            // 
            this.cn_name.DataPropertyName = "name";
            this.cn_name.FillWeight = 90F;
            this.cn_name.HeaderText = "Launch";
            this.cn_name.Name = "cn_name";
            this.cn_name.ReadOnly = true;
            this.cn_name.Width = 90;
            // 
            // btn_add
            // 
            this.btn_add.FillWeight = 25F;
            this.btn_add.HeaderText = "";
            this.btn_add.Name = "btn_add";
            this.btn_add.Width = 25;
            // 
            // cn_inlaunch
            // 
            this.cn_inlaunch.DataPropertyName = "inlaunch";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.cn_inlaunch.DefaultCellStyle = dataGridViewCellStyle1;
            this.cn_inlaunch.FillWeight = 70F;
            this.cn_inlaunch.HeaderText = "In launch";
            this.cn_inlaunch.Name = "cn_inlaunch";
            this.cn_inlaunch.ReadOnly = true;
            this.cn_inlaunch.Width = 70;
            // 
            // cn_tostart
            // 
            this.cn_tostart.DataPropertyName = "tostart";
            this.cn_tostart.FillWeight = 70F;
            this.cn_tostart.HeaderText = "To start";
            this.cn_tostart.Name = "cn_tostart";
            this.cn_tostart.Width = 70;
            // 
            // cn_started
            // 
            this.cn_started.DataPropertyName = "started";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.cn_started.DefaultCellStyle = dataGridViewCellStyle2;
            this.cn_started.FillWeight = 70F;
            this.cn_started.HeaderText = "Started";
            this.cn_started.Name = "cn_started";
            this.cn_started.ReadOnly = true;
            this.cn_started.Width = 70;
            // 
            // cn_tofinish
            // 
            this.cn_tofinish.DataPropertyName = "tofinish";
            this.cn_tofinish.FillWeight = 70F;
            this.cn_tofinish.HeaderText = "To finish";
            this.cn_tofinish.Name = "cn_tofinish";
            this.cn_tofinish.Width = 70;
            // 
            // cn_finished
            // 
            this.cn_finished.DataPropertyName = "finished";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.cn_finished.DefaultCellStyle = dataGridViewCellStyle3;
            this.cn_finished.FillWeight = 70F;
            this.cn_finished.HeaderText = "Finished";
            this.cn_finished.Name = "cn_finished";
            this.cn_finished.ReadOnly = true;
            this.cn_finished.Width = 70;
            // 
            // cn_freezed
            // 
            this.cn_freezed.DataPropertyName = "freezed";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            this.cn_freezed.DefaultCellStyle = dataGridViewCellStyle4;
            this.cn_freezed.HeaderText = "Freezed";
            this.cn_freezed.Name = "cn_freezed";
            // 
            // cn_prevsum
            // 
            this.cn_prevsum.DataPropertyName = "prevsum";
            this.cn_prevsum.HeaderText = "prevsum";
            this.cn_prevsum.Name = "cn_prevsum";
            this.cn_prevsum.ReadOnly = true;
            this.cn_prevsum.Visible = false;
            // 
            // cn_prevstageid
            // 
            this.cn_prevstageid.DataPropertyName = "prevstageid";
            this.cn_prevstageid.HeaderText = "prevstageid";
            this.cn_prevstageid.Name = "cn_prevstageid";
            this.cn_prevstageid.ReadOnly = true;
            this.cn_prevstageid.Visible = false;
            // 
            // cn_oldfreezed
            // 
            this.cn_oldfreezed.DataPropertyName = "oldfreezed";
            this.cn_oldfreezed.HeaderText = "oldfreezed";
            this.cn_oldfreezed.Name = "cn_oldfreezed";
            this.cn_oldfreezed.Visible = false;
            // 
            // cn_onstage
            // 
            this.cn_onstage.DataPropertyName = "onstage";
            this.cn_onstage.HeaderText = "On stage";
            this.cn_onstage.Name = "cn_onstage";
            // 
            // mnu_Lines
            // 
            this.mnu_Lines.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Lines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_Admin});
            this.mnu_Lines.Name = "mnu_Requests";
            this.mnu_Lines.Size = new System.Drawing.Size(137, 26);
            // 
            // mni_Admin
            // 
            this.mni_Admin.Image = global::Odin.Global_Resourses.Settings_24x24;
            this.mni_Admin.Name = "mni_Admin";
            this.mni_Admin.Size = new System.Drawing.Size(136, 22);
            this.mni_Admin.Text = "List settings";
            this.mni_Admin.Click += new System.EventHandler(this.mni_Admin_Click);
            // 
            // ctl_ProcessStageLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.bn_List);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.lbl_Stage);
            this.Name = "ctl_ProcessStageLaunch";
            this.Size = new System.Drawing.Size(330, 298);
            this.Load += new System.EventHandler(this.ctl_ProcessStageLaunch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bn_List)).EndInit();
            this.bn_List.ResumeLayout(false);
            this.bn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.mnu_Lines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Stage;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private System.Windows.Forms.BindingNavigator bn_List;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Global_Classes.SyncBindingSource bs_List;
        private System.Windows.Forms.ContextMenuStrip mnu_Lines;
        private System.Windows.Forms.ToolStripMenuItem mni_Admin;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewButtonColumn btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_inlaunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_tostart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_started;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_tofinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_finished;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_freezed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_prevsum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_prevstageid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_oldfreezed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_onstage;
    }
}
