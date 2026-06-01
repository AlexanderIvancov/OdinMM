namespace Odin.Workshop
{
    partial class ctl_WorkplaceWA
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
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_hours = new Owf.Controls.NumericTetxBox();
            this.chk_fulltime = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Article = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_CustArticle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Launch = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_Workplace = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmb_Workers = new Odin.CMB_Components.Common.cmb_Common();
            this.cmb_Launches1 = new Odin.CMB_Components.Launches.cmb_Launches();
            this.txt_WorkDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txt_WorkDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.txt_hours);
            this.kryptonPanel1.Controls.Add(this.chk_fulltime);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.cmb_Workers);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.txt_Article);
            this.kryptonPanel1.Controls.Add(this.txt_CustArticle);
            this.kryptonPanel1.Controls.Add(this.cmb_Launches1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.lbl_Launch);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(340, 239);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(11, 142);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel4.TabIndex = 253;
            this.kryptonLabel4.Values.Text = "Minutes:";
            // 
            // txt_hours
            // 
            this.txt_hours.AllowDecimalSeparator = false;
            this.txt_hours.AllowSpace = false;
            this.txt_hours.Enabled = false;
            this.txt_hours.Location = new System.Drawing.Point(85, 142);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.Size = new System.Drawing.Size(78, 23);
            this.txt_hours.TabIndex = 252;
            this.txt_hours.Text = "0";
            // 
            // chk_fulltime
            // 
            this.chk_fulltime.Checked = true;
            this.chk_fulltime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_fulltime.Location = new System.Drawing.Point(183, 116);
            this.chk_fulltime.Name = "chk_fulltime";
            this.chk_fulltime.Size = new System.Drawing.Size(70, 20);
            this.chk_fulltime.TabIndex = 251;
            this.chk_fulltime.Values.Text = "Full time";
            this.chk_fulltime.CheckedChanged += new System.EventHandler(this.chk_fulltime_CheckedChanged);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(11, 115);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel8.TabIndex = 249;
            this.kryptonLabel8.Values.Text = "Date:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(11, 89);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel3.TabIndex = 247;
            this.kryptonLabel3.Values.Text = "Worker:";
            // 
            // txt_Article
            // 
            this.txt_Article.AllowButtonSpecToolTips = true;
            this.txt_Article.Enabled = false;
            this.txt_Article.Location = new System.Drawing.Point(85, 172);
            this.txt_Article.Name = "txt_Article";
            this.txt_Article.Size = new System.Drawing.Size(150, 23);
            this.txt_Article.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_Article.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.txt_Article.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Article.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Article.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Article.TabIndex = 246;
            // 
            // txt_CustArticle
            // 
            this.txt_CustArticle.AllowButtonSpecToolTips = true;
            this.txt_CustArticle.Enabled = false;
            this.txt_CustArticle.Location = new System.Drawing.Point(85, 201);
            this.txt_CustArticle.Name = "txt_CustArticle";
            this.txt_CustArticle.Size = new System.Drawing.Size(209, 23);
            this.txt_CustArticle.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.txt_CustArticle.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.txt_CustArticle.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_CustArticle.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_CustArticle.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustArticle.TabIndex = 245;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 202);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel2.TabIndex = 243;
            this.kryptonLabel2.Values.Text = "Cust. article:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 173);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel1.TabIndex = 242;
            this.kryptonLabel1.Values.Text = "Article:";
            // 
            // lbl_Launch
            // 
            this.lbl_Launch.Location = new System.Drawing.Point(11, 63);
            this.lbl_Launch.Name = "lbl_Launch";
            this.lbl_Launch.Size = new System.Drawing.Size(52, 20);
            this.lbl_Launch.TabIndex = 241;
            this.lbl_Launch.Values.Text = "Launch:";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lbl_Workplace);
            this.kryptonPanel2.Controls.Add(this.btn_Clear);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(2, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderRowCustom1;
            this.kryptonPanel2.Size = new System.Drawing.Size(336, 44);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // lbl_Workplace
            // 
            this.lbl_Workplace.AutoSize = false;
            this.lbl_Workplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Workplace.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lbl_Workplace.Location = new System.Drawing.Point(0, 0);
            this.lbl_Workplace.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Workplace.Name = "lbl_Workplace";
            this.lbl_Workplace.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.lbl_Workplace.Size = new System.Drawing.Size(289, 44);
            this.lbl_Workplace.StateCommon.LongText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Workplace.StateNormal.LongText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Workplace.StateNormal.ShortText.Color1 = System.Drawing.Color.Yellow;
            this.lbl_Workplace.StateNormal.ShortText.Color2 = System.Drawing.Color.Green;
            this.lbl_Workplace.StateNormal.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.lbl_Workplace.StateNormal.ShortText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Workplace.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbl_Workplace.TabIndex = 7;
            this.lbl_Workplace.UseMnemonic = false;
            this.lbl_Workplace.Values.Text = "Worker assignment";
            // 
            // btn_Clear
            // 
            this.btn_Clear.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Clear.Location = new System.Drawing.Point(289, 0);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(47, 44);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Values.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.Values.Text = "";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cmb_Workers
            // 
            this.cmb_Workers.IsEmptyColor = false;
            this.cmb_Workers.Location = new System.Drawing.Point(85, 89);
            this.cmb_Workers.Name = "cmb_Workers";
            this.cmb_Workers.OrderBy = "surname";
            this.cmb_Workers.sCurrentValue = "";
            this.cmb_Workers.SelectedValue = 0;
            this.cmb_Workers.sID_Filled = "id";
            this.cmb_Workers.Size = new System.Drawing.Size(246, 20);
            this.cmb_Workers.sTable = "vw_Workers";
            this.cmb_Workers.sText_Filled = "worker";
            this.cmb_Workers.sTitle = "Worker";
            this.cmb_Workers.TabIndex = 248;
            // 
            // cmb_Launches1
            // 
            this.cmb_Launches1.Article = "";
            this.cmb_Launches1.ArticleId = 0;
            this.cmb_Launches1.Batch = "";
            this.cmb_Launches1.BatchId = 0;
            this.cmb_Launches1.ConfOrder = "";
            this.cmb_Launches1.Customer = "";
            this.cmb_Launches1.EndDate = "";
            this.cmb_Launches1.IsActive = 0;
            this.cmb_Launches1.Launch = "";
            this.cmb_Launches1.LaunchId = 0;
            this.cmb_Launches1.Location = new System.Drawing.Point(85, 63);
            this.cmb_Launches1.Name = "cmb_Launches1";
            this.cmb_Launches1.ParentBatchId = 0;
            this.cmb_Launches1.Qty = 0D;
            this.cmb_Launches1.SecName = null;
            this.cmb_Launches1.Size = new System.Drawing.Size(150, 20);
            this.cmb_Launches1.StageId = 0;
            this.cmb_Launches1.StartDate = null;
            this.cmb_Launches1.TabIndex = 244;
            this.cmb_Launches1.LaunchChanged += new Odin.CMB_Components.Launches.LaunchHeadEventHandler(this.cmb_Launches1_LaunchChanged);
            // 
            // txt_WorkDate
            // 
            this.txt_WorkDate.CalendarShowWeekNumbers = true;
            this.txt_WorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_WorkDate.Location = new System.Drawing.Point(85, 116);
            this.txt_WorkDate.Name = "txt_WorkDate";
            this.txt_WorkDate.Size = new System.Drawing.Size(92, 21);
            this.txt_WorkDate.TabIndex = 287;
            // 
            // ctl_WorkplaceWA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_WorkplaceWA";
            this.Size = new System.Drawing.Size(340, 239);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Workplace;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Launch;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Article;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_CustArticle;
        public CMB_Components.Launches.cmb_Launches cmb_Launches1;
        private CMB_Components.Common.cmb_Common cmb_Workers;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_fulltime;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Owf.Controls.NumericTetxBox txt_hours;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker txt_WorkDate;
    }
}
