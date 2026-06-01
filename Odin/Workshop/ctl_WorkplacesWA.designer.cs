namespace Odin.Workshop
{
    partial class ctl_WorkplacesWA
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
            this.btn_Syncronyze = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Clear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmb_Rooms1 = new Odin.CMB_Components.Rooms.cmb_Rooms();
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Syncronyze);
            this.kryptonPanel1.Controls.Add(this.btn_Clear);
            this.kryptonPanel1.Controls.Add(this.cmb_Rooms1);
            this.kryptonPanel1.Controls.Add(this.btn_Save);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.btn_Refresh);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(573, 47);
            this.kryptonPanel1.TabIndex = 6;
            // 
            // btn_Syncronyze
            // 
            this.btn_Syncronyze.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Syncronyze.Location = new System.Drawing.Point(410, 3);
            this.btn_Syncronyze.Name = "btn_Syncronyze";
            this.btn_Syncronyze.Size = new System.Drawing.Size(78, 43);
            this.btn_Syncronyze.TabIndex = 238;
            this.btn_Syncronyze.Values.Image = global::Odin.Global_Resourses.Transfer;
            this.btn_Syncronyze.Values.Text = "Reset";
            this.btn_Syncronyze.Click += new System.EventHandler(this.btn_Syncronyze_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Clear.Location = new System.Drawing.Point(6, 5);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(38, 37);
            this.btn_Clear.TabIndex = 236;
            this.btn_Clear.Values.Image = global::Odin.Global_Resourses.clear;
            this.btn_Clear.Values.Text = "";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cmb_Rooms1
            // 
            this.cmb_Rooms1.Enabled = false;
            this.cmb_Rooms1.EnableSearchId = false;
            this.cmb_Rooms1.IsEmptyColor = false;
            this.cmb_Rooms1.Location = new System.Drawing.Point(110, 13);
            this.cmb_Rooms1.Name = "cmb_Rooms1";
            this.cmb_Rooms1.PlaceId = 0;
            this.cmb_Rooms1.Room = "IPA";
            this.cmb_Rooms1.RoomId = 6;
            this.cmb_Rooms1.Size = new System.Drawing.Size(196, 20);
            this.cmb_Rooms1.TabCol = 2;
            this.cmb_Rooms1.TabIndex = 235;
            this.cmb_Rooms1.TabRow = 1;
            this.cmb_Rooms1.RoomsChanged += new Odin.CMB_Components.Rooms.RoomsEventHandler(this.cmb_Rooms1_RoomsChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Save.Location = new System.Drawing.Point(366, 6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(38, 37);
            this.btn_Save.TabIndex = 234;
            this.btn_Save.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.Values.Text = "";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(53, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel1.TabIndex = 233;
            this.kryptonLabel1.Values.Text = "Room:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_Refresh.Location = new System.Drawing.Point(312, 6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(38, 37);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_24x24;
            this.btn_Refresh.Values.Text = "";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 47);
            this.panel.Name = "panel";
            this.panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.panel.Size = new System.Drawing.Size(573, 478);
            this.panel.TabIndex = 7;
            // 
            // ctl_WorkplacesWA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ctl_WorkplacesWA";
            this.Size = new System.Drawing.Size(573, 525);
            this.Load += new System.EventHandler(this.ctl_WorkplacesWA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private CMB_Components.Rooms.cmb_Rooms cmb_Rooms1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Syncronyze;
    }
}
