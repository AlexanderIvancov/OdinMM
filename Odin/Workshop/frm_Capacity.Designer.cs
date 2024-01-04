namespace Odin.Workshop
{
    partial class frm_Capacity
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Capacity));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmb_Common3 = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common2 = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_Common1 = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Till = new Odin.CustomControls.NullableDateTimePicker();
            this.txt_From = new Odin.CustomControls.NullableDateTimePicker();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Total = new Owf.Controls.NumericTetxBox();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Oper = new System.Windows.Forms.RichTextBox();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.gv_List = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.rb_all = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_production = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_quality = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rb_quality);
            this.kryptonPanel1.Controls.Add(this.rb_production);
            this.kryptonPanel1.Controls.Add(this.rb_all);
            this.kryptonPanel1.Controls.Add(this.cmb_Common3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.cmb_Common2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.cmb_Common1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txt_Till);
            this.kryptonPanel1.Controls.Add(this.txt_From);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.btn_Refresh);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(1054, 74);
            this.kryptonPanel1.TabIndex = 33;
            // 
            // cmb_Common3
            // 
            this.cmb_Common3.IsEmptyColor = false;
            this.cmb_Common3.Location = new System.Drawing.Point(427, 15);
            this.cmb_Common3.Name = "cmb_Common3";
            this.cmb_Common3.OrderBy = "id";
            this.cmb_Common3.sCurrentValue = "";
            this.cmb_Common3.SelectedValue = 0;
            this.cmb_Common3.sID_Filled = "id";
            this.cmb_Common3.Size = new System.Drawing.Size(171, 20);
            this.cmb_Common3.sTable = "BAS_ProdPlaces";
            this.cmb_Common3.sText_Filled = "prodplace";
            this.cmb_Common3.sTitle = "Production place";
            this.cmb_Common3.TabIndex = 272;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(316, 15);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(105, 20);
            this.kryptonLabel3.TabIndex = 271;
            this.kryptonLabel3.Values.Text = "Production place:";
            // 
            // cmb_Common2
            // 
            this.cmb_Common2.IsEmptyColor = false;
            this.cmb_Common2.Location = new System.Drawing.Point(220, 15);
            this.cmb_Common2.Name = "cmb_Common2";
            this.cmb_Common2.OrderBy = "id";
            this.cmb_Common2.sCurrentValue = "";
            this.cmb_Common2.SelectedValue = 0;
            this.cmb_Common2.sID_Filled = "id";
            this.cmb_Common2.Size = new System.Drawing.Size(90, 20);
            this.cmb_Common2.sTable = "BAS_ShiftReg";
            this.cmb_Common2.sText_Filled = "shift";
            this.cmb_Common2.sTitle = "Shifts";
            this.cmb_Common2.TabIndex = 270;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(170, 15);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel2.TabIndex = 269;
            this.kryptonLabel2.Values.Text = "Shift:";
            // 
            // cmb_Common1
            // 
            this.cmb_Common1.IsEmptyColor = false;
            this.cmb_Common1.Location = new System.Drawing.Point(73, 15);
            this.cmb_Common1.Name = "cmb_Common1";
            this.cmb_Common1.OrderBy = "orderby";
            this.cmb_Common1.sCurrentValue = "";
            this.cmb_Common1.SelectedValue = 0;
            this.cmb_Common1.sID_Filled = "id";
            this.cmb_Common1.Size = new System.Drawing.Size(90, 20);
            this.cmb_Common1.sTable = "BAS_Stages";
            this.cmb_Common1.sText_Filled = "name";
            this.cmb_Common1.sTitle = "Stages of usage";
            this.cmb_Common1.TabIndex = 268;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(23, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel1.TabIndex = 261;
            this.kryptonLabel1.Values.Text = "Stage:";
            // 
            // txt_Till
            // 
            this.txt_Till.CalendarShowWeekNumbers = true;
            this.txt_Till.CustomFormat = null;
            this.txt_Till.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Till.Location = new System.Drawing.Point(220, 41);
            this.txt_Till.Name = "txt_Till";
            this.txt_Till.NullValue = " ";
            this.txt_Till.Size = new System.Drawing.Size(90, 21);
            this.txt_Till.TabIndex = 260;
            // 
            // txt_From
            // 
            this.txt_From.CalendarShowWeekNumbers = true;
            this.txt_From.CustomFormat = null;
            this.txt_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_From.Location = new System.Drawing.Point(73, 41);
            this.txt_From.Name = "txt_From";
            this.txt_From.NullValue = " ";
            this.txt_From.Size = new System.Drawing.Size(85, 21);
            this.txt_From.TabIndex = 259;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(170, 41);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(29, 20);
            this.kryptonLabel11.TabIndex = 258;
            this.kryptonLabel11.Values.Text = "Till:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(23, 42);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 257;
            this.kryptonLabel8.Values.Text = "From:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Refresh.Location = new System.Drawing.Point(614, 17);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Refresh.Size = new System.Drawing.Size(47, 43);
            this.btn_Refresh.TabIndex = 26;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.txt_Total);
            this.kryptonPanel2.Controls.Add(this.btn_OK);
            this.kryptonPanel2.Controls.Add(this.txt_Oper);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 709);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(1054, 51);
            this.kryptonPanel2.TabIndex = 34;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(104, 14);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(133, 20);
            this.kryptonLabel4.TabIndex = 262;
            this.kryptonLabel4.Values.Text = "Total by selected date:";
            // 
            // txt_Total
            // 
            this.txt_Total.AllowDecimalSeparator = true;
            this.txt_Total.AllowSpace = false;
            this.txt_Total.Location = new System.Drawing.Point(243, 9);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(119, 30);
            this.txt_Total.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txt_Total.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Total.TabIndex = 227;
            this.txt_Total.Text = "0";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.Location = new System.Drawing.Point(956, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_OK.Size = new System.Drawing.Size(93, 41);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_OK.Values.Text = "Save";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_Oper
            // 
            this.txt_Oper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Oper.Location = new System.Drawing.Point(12, 109);
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_Oper.Size = new System.Drawing.Size(5, 5);
            this.txt_Oper.TabIndex = 226;
            this.txt_Oper.Text = "";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // gv_List
            // 
            this.gv_List.AllowUserToAddRows = false;
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gv_List.Location = new System.Drawing.Point(0, 74);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 25;
            this.gv_List.Size = new System.Drawing.Size(1054, 635);
            this.gv_List.TabIndex = 35;
            this.gv_List.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellValidated);
            this.gv_List.SelectionChanged += new System.EventHandler(this.gv_List_SelectionChanged);
            // 
            // rb_all
            // 
            this.rb_all.Checked = true;
            this.rb_all.Location = new System.Drawing.Point(342, 42);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(36, 20);
            this.rb_all.TabIndex = 273;
            this.rb_all.Values.Text = "All";
            // 
            // rb_production
            // 
            this.rb_production.Location = new System.Drawing.Point(406, 42);
            this.rb_production.Name = "rb_production";
            this.rb_production.Size = new System.Drawing.Size(82, 20);
            this.rb_production.TabIndex = 274;
            this.rb_production.Values.Text = "Production";
            // 
            // rb_quality
            // 
            this.rb_quality.Location = new System.Drawing.Point(510, 42);
            this.rb_quality.Name = "rb_quality";
            this.rb_quality.Size = new System.Drawing.Size(61, 20);
            this.rb_quality.TabIndex = 275;
            this.rb_quality.Values.Text = "Quality";
            // 
            // frm_Capacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 760);
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Capacity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacity of production";
            this.Load += new System.EventHandler(this.frm_Capacity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private CustomControls.NullableDateTimePicker txt_Till;
        private CustomControls.NullableDateTimePicker txt_From;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private CMB_Components.Common.cmb_Common cmb_Common1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private System.Windows.Forms.RichTextBox txt_Oper;
        private System.Windows.Forms.BindingSource bs_List;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gv_List;
        private CMB_Components.Common.cmb_Common cmb_Common2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private CMB_Components.Common.cmb_Common cmb_Common3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Owf.Controls.NumericTetxBox txt_Total;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_quality;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_production;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_all;
    }
}